using System;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using Newtonsoft.Json;

namespace SOD.Multiplayer.Dedicated
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("  Shadows of Doubt Dedicated Server");
            Console.WriteLine("  Multiplayer Mod v1.0");
            Console.WriteLine("========================================");
            
            // Load configuration
            var config = ServerConfig.Load();
            string serverName = Environment.GetEnvironmentVariable("SOD_SERVER_NAME") ?? config.ServerName;
            string bindAddress = Environment.GetEnvironmentVariable("SOD_SERVER_BIND") ?? config.BindAddress;
            string publicAddress = Environment.GetEnvironmentVariable("SOD_SERVER_IP") ?? config.PublicAddress;
            int port = int.TryParse(Environment.GetEnvironmentVariable("SOD_SERVER_PORT"), out var configuredPort)
                ? configuredPort : config.Port;
            string password = Environment.GetEnvironmentVariable("SOD_SERVER_PASSWORD") ?? config.Password;
            string masterServerUrl = Environment.GetEnvironmentVariable("SOD_MASTER_URL") ?? config.MasterServerUrl;
            string masterToken = Environment.GetEnvironmentVariable("SOD_MASTER_TOKEN") ?? config.MasterToken;
            string map = Environment.GetEnvironmentVariable("SOD_SERVER_MAP") ?? config.Map;
            string saveGame = Environment.GetEnvironmentVariable("SOD_SERVER_SAVE") ?? config.SaveGame;
            
            Console.WriteLine($"\nConfiguration:");
            Console.WriteLine($"  Server Name: {serverName}");
            Console.WriteLine($"  Port: {port}");
            Console.WriteLine($"  Bind Address: {bindAddress}");
            Console.WriteLine($"  Public Address: {publicAddress}");
            Console.WriteLine($"  Password Protected: {!string.IsNullOrEmpty(password)}");
            Console.WriteLine($"  Master Server: {masterServerUrl}");
            Console.WriteLine($"  Map: {map}");
            Console.WriteLine($"  Save: {saveGame}");
            Console.WriteLine($"  Max Players: 4");
            Console.WriteLine();
            
            var localBindAddress = NetworkBinding.GetLocalBindAddress(bindAddress, "Dedicated Server");
            var gameServer = new GameServer(serverName, localBindAddress, publicAddress, port, password, masterServerUrl, masterToken, map, saveGame);
            await gameServer.StartAsync();
            
            Console.WriteLine("\nServer is running. Press Ctrl+C to stop.");
            
            // Keep running
            while (true)
            {
                await Task.Delay(1000);
            }
        }
    }

    internal sealed class ServerConfig
    {
        public string ServerName { get; set; } = "My SOD Server";
        public string BindAddress { get; set; } = "0.0.0.0";
        public string PublicAddress { get; set; } = "127.0.0.1";
        public int Port { get; set; } = 7777;
        public string Password { get; set; } = "";
        public string MasterServerUrl { get; set; } = "http://127.0.0.1:5000";
        public string MasterToken { get; set; } = "change-this-token";
        public string Map { get; set; } = "Default";
        public string SaveGame { get; set; } = "New session";

        public static ServerConfig Load()
        {
            var path = Environment.GetEnvironmentVariable("SOD_SERVER_CONFIG") ?? "server.json";
            if (!File.Exists(path))
            {
                return new ServerConfig();
            }

            return JsonConvert.DeserializeObject<ServerConfig>(File.ReadAllText(path))
                ?? new ServerConfig();
        }
    }

    internal static class NetworkBinding
    {
        public static string GetLocalBindAddress(string configuredAddress, string serviceName)
        {
            if (string.IsNullOrWhiteSpace(configuredAddress) || configuredAddress == "0.0.0.0")
            {
                return "0.0.0.0";
            }

            if (IPAddress.TryParse(configuredAddress, out var address) &&
                (IPAddress.IsLoopback(address) || NetworkInterface.GetAllNetworkInterfaces()
                    .SelectMany(networkInterface => networkInterface.GetIPProperties().UnicastAddresses)
                    .Any(unicastAddress => unicastAddress.Address.Equals(address))))
            {
                return configuredAddress;
            }

            Console.WriteLine($"[{serviceName}] BindAddress '{configuredAddress}' is not assigned to this machine. Using 0.0.0.0 instead.");
            return "0.0.0.0";
        }
    }
}
