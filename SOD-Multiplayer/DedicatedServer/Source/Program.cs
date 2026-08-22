using System;

namespace SOD_Multiplayer.Server
{
    /// <summary>
    /// Entry Point für den Dedicated Multiplayer Server
    /// </summary>
    class Program
    {
        private static GameServer _gameServer;
        private static bool _isRunning = true;
        
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("  Shadow of Doubt - Dedicated Server");
            Console.WriteLine("  Version: 0.1.0");
            Console.WriteLine("========================================");
            Console.WriteLine();
            
            // Konfiguration laden
            var config = LoadConfig(args);
            
            // GameServer Instance setzen (für Singleton-Zugriff)
            GameServerInstance.Instance = new GameServer(config);
            _gameServer = GameServerInstance.Instance;
            
            // Ctrl+C Handler
            Console.CancelKeyPress += (s, e) =>
            {
                e.Cancel = true;
                _isRunning = false;
                Console.WriteLine("\n[Program] Shutdown signal received...");
            };
            
            // Server starten
            _gameServer.Start();
            
            Console.WriteLine();
            Console.WriteLine("[Program] Server läuft. Drücke Ctrl+C zum Beenden.");
            Console.WriteLine();
            
            // Hauptloop
            while (_isRunning)
            {
                System.Threading.Thread.Sleep(1000);
                
                // Periodische Aufgaben
                _gameServer.SendHeartbeat(); // Alle 10 Sekunden an Master
            }
            
            // Server stoppen
            _gameServer.Stop();
            
            Console.WriteLine("[Program] Server beendet.");
        }
        
        /// <summary>
        /// Konfiguration aus Argumenten oder Default-Werten laden
        /// </summary>
        private static ServerConfig LoadConfig(string[] args)
        {
            var config = new ServerConfig();
            
            // Command-Line Argumente parsen
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "--name":
                    case "-n":
                        if (i + 1 < args.Length)
                            config.ServerName = args[++i];
                        break;
                        
                    case "--port":
                    case "-p":
                        if (i + 1 < args.Length && int.TryParse(args[++i], out var port))
                            config.Port = port;
                        break;
                        
                    case "--maxplayers":
                    case "-m":
                        if (i + 1 < args.Length && int.TryParse(args[++i], out var max))
                            config.MaxPlayers = Math.Min(max, 4); // Max 4 erzwingen
                        break;
                        
                    case "--password":
                    case "-pw":
                        if (i + 1 < args.Length)
                            config.Password = args[++i];
                        break;
                        
                    case "--master":
                        if (i + 1 < args.Length)
                            config.MasterServerUrl = args[++i];
                        break;
                        
                    case "--region":
                    case "-r":
                        if (i + 1 < args.Length)
                            config.Region = args[++i];
                        break;
                        
                    case "--help":
                    case "-h":
                        PrintHelp();
                        Environment.Exit(0);
                        break;
                }
            }
            
            // Config ausgeben
            Console.WriteLine("[Program] Konfiguration:");
            Console.WriteLine($"  Server Name: {config.ServerName}");
            Console.WriteLine($"  Port: {config.Port}");
            Console.WriteLine($"  Max Players: {config.MaxPlayers}");
            Console.WriteLine($"  Region: {config.Region}");
            Console.WriteLine($"  Master Server: {config.MasterServerUrl}");
            Console.WriteLine($"  Passwort: {(string.IsNullOrEmpty(config.Password) ? "Nein" : "Ja")}");
            Console.WriteLine();
            
            return config;
        }
        
        /// <summary>
        /// Hilfe ausgeben
        /// </summary>
        private static void PrintHelp()
        {
            Console.WriteLine("Verwendung: SODMultiplayerServer [Optionen]");
            Console.WriteLine();
            Console.WriteLine("Optionen:");
            Console.WriteLine("  --name, -n <name>       Server-Name (Default: 'SOD Multiplayer Server')");
            Console.WriteLine("  --port, -p <port>       Server-Port (Default: 27015)");
            Console.WriteLine("  --maxplayers, -m <num>  Maximale Spieler (Default: 4, Max: 4)");
            Console.WriteLine("  --password, -pw <pass>  Server-Passwort (Optional)");
            Console.WriteLine("  --master <url>          Master-Server URL (Default: http://localhost:27016)");
            Console.WriteLine("  --region, -r <region>   Region (Default: EU)");
            Console.WriteLine("  --help, -h              Diese Hilfe anzeigen");
            Console.WriteLine();
            Console.WriteLine("Beispiel:");
            Console.WriteLine("  ./SODMultiplayerServer --name \"My SOD Server\" --port 27015 --maxplayers 4");
        }
    }
}
