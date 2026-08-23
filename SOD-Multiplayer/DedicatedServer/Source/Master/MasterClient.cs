using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SOD_Multiplayer.Master
{
    /// <summary>
    /// Client für Kommunikation mit dem Master-Server
    /// Registriert den Dedicated Server und sendet Heartbeats
    /// </summary>
    public class MasterClient
    {
        private readonly string _masterServerUrl;
        private readonly ServerConfig _config;
        private readonly HttpClient _httpClient;
        private string _serverId;
        private System.Timers.Timer _heartbeatTimer;
        
        /// <summary>
        /// Eindeutige Server-ID (wird bei Registrierung zugewiesen)
        /// </summary>
        public string ServerId => _serverId;
        
        /// <summary>
        /// Ist der Server beim Master registriert?
        /// </summary>
        public bool IsRegistered => !string.IsNullOrEmpty(_serverId);
        
        public MasterClient(string masterServerUrl, ServerConfig config)
        {
            _masterServerUrl = masterServerUrl.TrimEnd('/');
            _config = config;
            _httpClient = new HttpClient();
            
            Console.WriteLine($"[MasterClient] Verbunden mit Master: {_masterServerUrl}");
        }
        
        /// <summary>
        /// Server beim Master registrieren
        /// </summary>
        public async void RegisterServer()
        {
            try
            {
                var requestData = new
                {
                    serverName = _config.ServerName,
                    port = _config.Port,
                    maxPlayers = _config.MaxPlayers,
                    hasPassword = !string.IsNullOrEmpty(_config.Password),
                    region = _config.Region,
                    version = "0.1.0"
                };
                
                var json = JsonConvert.SerializeObject(requestData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                
                var response = await _httpClient.PostAsync($"{_masterServerUrl}/api/servers/register", content);
                
                if (response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    var responseData = JsonConvert.DeserializeObject<RegisterResponse>(responseJson);
                    
                    _serverId = responseData?.ServerId;
                    Console.WriteLine($"[MasterClient] Beim Master registriert! Server-ID: {_serverId}");
                    
                    // Heartbeat-Timer starten
                    StartHeartbeatTimer();
                }
                else
                {
                    var errorJson = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"[MasterClient] Registrierungsfehler: {response.StatusCode} - {errorJson}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[MasterClient] Fehler bei Registrierung: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Server vom Master abmelden
        /// </summary>
        public async void UnregisterServer()
        {
            if (string.IsNullOrEmpty(_serverId))
                return;
                
            try
            {
                StopHeartbeatTimer();
                
                var response = await _httpClient.DeleteAsync($"{_masterServerUrl}/api/servers/{_serverId}");
                
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"[MasterClient] Vom Master abgemeldet");
                    _serverId = null;
                }
                else
                {
                    Console.WriteLine($"[MasterClient] Abmelde-Fehler: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[MasterClient] Fehler bei Abmeldung: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Heartbeat an Master senden
        /// </summary>
        public async void SendHeartbeat(int currentPlayers)
        {
            if (string.IsNullOrEmpty(_serverId))
                return;
                
            try
            {
                var requestData = new
                {
                    currentPlayers = currentPlayers,
                    timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
                };
                
                var json = JsonConvert.SerializeObject(requestData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                
                var response = await _httpClient.PutAsync(
                    $"{_masterServerUrl}/api/servers/{_serverId}/heartbeat", 
                    content);
                
                if (!response.IsSuccessStatusCode)
                {
                    var errorJson = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"[MasterClient] Heartbeat-Fehler: {response.StatusCode} - {errorJson}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[MasterClient] Heartbeat-Fehler: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Heartbeat-Timer starten (alle 10 Sekunden)
        /// </summary>
        private void StartHeartbeatTimer()
        {
            _heartbeatTimer = new System.Timers.Timer(10000); // 10 Sekunden
            _heartbeatTimer.Elapsed += (s, e) => 
            {
                // GameServer Instance holen für aktuelle Spielerzahl
                var gameServer = GameServerInstance.Instance;
                SendHeartbeat(gameServer?.PlayerCount ?? 0);
            };
            _heartbeatTimer.AutoReset = true;
            _heartbeatTimer.Enabled = true;
            
            Console.WriteLine("[MasterClient] Heartbeat-Timer gestartet (10s Intervall)");
        }
        
        /// <summary>
        /// Heartbeat-Timer stoppen
        /// </summary>
        private void StopHeartbeatTimer()
        {
            _heartbeatTimer?.Stop();
            _heartbeatTimer?.Dispose();
            _heartbeatTimer = null;
            
            Console.WriteLine("[MasterClient] Heartbeat-Timer gestoppt");
        }
        
        /// <summary>
        /// Response von Register API
        /// </summary>
        private class RegisterResponse
        {
            [JsonProperty("serverId")]
            public string ServerId { get; set; }
            
            [JsonProperty("success")]
            public bool Success { get; set; }
        }
    }
}
