using System;

namespace SOD_Multiplayer.Server
{
    /// <summary>
    /// Verwaltet die Game-Session auf dem Dedicated Server
    /// Handhabt Spielzustand, Zeit, Wetter, etc.
    /// </summary>
    public class SessionManager
    {
        private readonly NetworkServer _networkServer;
        private readonly PlayerManager _playerManager;
        
        /// <summary>
        /// Aktuelle Spielzeit
        /// </summary>
        private float _gameTime = 8.0f; // Start um 8:00
        
        /// <summary>
        /// Aktueller Tag
        /// </summary>
        private int _day = 1;
        
        /// <summary>
        /// Aktuelles Datum
        /// </summary>
        private int _date = 1;
        private int _month = 1;
        private int _year = 2024;
        
        /// <summary>
        /// Ist die Session aktiv?
        /// </summary>
        public bool IsRunning { get; private set; }
        
        public SessionManager(NetworkServer networkServer, PlayerManager playerManager)
        {
            _networkServer = networkServer;
            _playerManager = playerManager;
        }
        
        /// <summary>
        /// Session starten
        /// </summary>
        public void Start()
        {
            if (IsRunning)
                return;
                
            Console.WriteLine("[SessionManager] Session gestartet");
            IsRunning = true;
            
            // Game-Timer starten (läuft im Hintergrund)
            // In Phase 7: Vollständige Spielzustands-Synchronisation
        }
        
        /// <summary>
        /// Session stoppen
        /// </summary>
        public void Stop()
        {
            if (!IsRunning)
                return;
                
            Console.WriteLine("[SessionManager] Session gestoppt");
            IsRunning = false;
        }
        
        /// <summary>
        /// Spieler-Position verarbeiten und broadcasten
        /// </summary>
        public void HandlePlayerPosition(ConnectedClient client, PlayerPositionPacket packet)
        {
            // Position von anderen Spielern broadcasten
            // Nicht an den Absender zurücksenden
            _networkServer.BroadcastToAll(packet, client);
        }
        
        /// <summary>
        /// Spielzeit aktualisieren und broadcasten
        /// </summary>
        public void UpdateGameTime(float deltaTime)
        {
            _gameTime += deltaTime;
            
            // Bei 24h zurücksetzen und Tag erhöhen
            if (_gameTime >= 24.0f)
            {
                _gameTime -= 24.0f;
                _day++;
                _date++;
                
                // Monatswechsel (vereinfacht)
                if (_date > 30)
                {
                    _date = 1;
                    _month++;
                    
                    if (_month > 12)
                    {
                        _month = 1;
                        _year++;
                    }
                }
            }
            
            // Zeit an Clients senden (Phase 7)
            BroadcastGameState();
        }
        
        /// <summary>
        /// Spielzustand an alle Clients broadcasten
        /// </summary>
        private void BroadcastGameState()
        {
            // Spielzeit broadcasten
            var timePacket = new Network.GameTimePacket
            {
                GameTime = _gameTime,
                Day = _day,
                Date = _date,
                Month = _month,
                Year = _year
            };
            _networkServer.BroadcastToAll(timePacket);
            
            // Wetter würde hier broadcasten werden (Phase 7)
        }
        
        /// <summary>
        /// Wetter einstellen (Phase 7)
        /// </summary>
        public void SetWeather(float rain, float wind, float snow, float lightning, float fog)
        {
            var weatherPacket = new Network.WeatherPacket
            {
                Rain = rain,
                Wind = wind,
                Snow = snow,
                Lightning = lightning,
                Fog = fog
            };
            _networkServer.BroadcastToAll(weatherPacket);
        }
    }
}
