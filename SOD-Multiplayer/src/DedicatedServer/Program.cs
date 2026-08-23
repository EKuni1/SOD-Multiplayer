using System;
using System.Threading.Tasks;

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
            string serverName = Environment.GetEnvironmentVariable("SOD_SERVER_NAME") ?? "My SOD Server";
            int port = int.Parse(Environment.GetEnvironmentVariable("SOD_SERVER_PORT") ?? "7777");
            string password = Environment.GetEnvironmentVariable("SOD_SERVER_PASSWORD") ?? "";
            string masterServerUrl = Environment.GetEnvironmentVariable("SOD_MASTER_URL") ?? "http://localhost:5000";
            
            Console.WriteLine($"\nConfiguration:");
            Console.WriteLine($"  Server Name: {serverName}");
            Console.WriteLine($"  Port: {port}");
            Console.WriteLine($"  Password Protected: {!string.IsNullOrEmpty(password)}");
            Console.WriteLine($"  Master Server: {masterServerUrl}");
            Console.WriteLine($"  Max Players: 4");
            Console.WriteLine();
            
            var gameServer = new GameServer(serverName, port, password, masterServerUrl);
            await gameServer.StartAsync();
            
            Console.WriteLine("\nServer is running. Press Ctrl+C to stop.");
            
            // Keep running
            while (true)
            {
                await Task.Delay(1000);
            }
        }
    }
}
