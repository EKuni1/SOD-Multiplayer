using System;

namespace SOD_Multiplayer.MasterServer
{
    /// <summary>
    /// Entry Point für den Master-Server
    /// </summary>
    class Program
    {
        private static ServerListManager _serverListManager;
        private static API.RestApi _restApi;
        private static bool _isRunning = true;
        
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("  Shadow of Doubt - Master Server");
            Console.WriteLine("  Version: 0.1.0");
            Console.WriteLine("========================================");
            Console.WriteLine();
            
            // Port aus Argumenten oder Default-Wert laden
            int port = 27016;
            
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "--port":
                    case "-p":
                        if (i + 1 < args.Length && int.TryParse(args[++i], out var p))
                            port = p;
                        break;
                        
                    case "--help":
                    case "-h":
                        PrintHelp();
                        Environment.Exit(0);
                        break;
                }
            }
            
            Console.WriteLine($"[Program] Master Server Port: {port}");
            Console.WriteLine();
            
            // ServerListManager initialisieren
            _serverListManager = new ServerListManager();
            
            // REST API initialisieren und starten
            _restApi = new API.RestApi(_serverListManager);
            _restApi.Start(port);
            
            // Ctrl+C Handler
            Console.CancelKeyPress += (s, e) =>
            {
                e.Cancel = true;
                _isRunning = false;
                Console.WriteLine("\n[Program] Shutdown signal received...");
            };
            
            Console.WriteLine();
            Console.WriteLine("[Program] Master Server läuft. Drücke Ctrl+C zum Beenden.");
            Console.WriteLine();
            Console.WriteLine("API Endpoints:");
            Console.WriteLine($"  GET  http://localhost:{port}/api/health         - Health Check");
            Console.WriteLine($"  POST http://localhost:{port}/api/servers/register - Server registrieren");
            Console.WriteLine($"  DELETE http://localhost:{port}/api/servers/{{id}} - Server entfernen");
            Console.WriteLine($"  PUT  http://localhost:{port}/api/servers/{{id}}/heartbeat - Heartbeat");
            Console.WriteLine($"  GET  http://localhost:{port}/api/servers        - Serverliste");
            Console.WriteLine();
            
            // Hauptloop
            while (_isRunning)
            {
                System.Threading.Thread.Sleep(1000);
                
                // Status alle 60 Sekunden ausgeben
                if (DateTime.UtcNow.Second == 0)
                {
                    Console.WriteLine($"[Program] Aktive Server: {_serverListManager.ServerCount}");
                }
            }
            
            // Server stoppen
            _restApi?.Stop();
            _serverListManager?.Stop();
            
            Console.WriteLine("[Program] Master Server beendet.");
        }
        
        /// <summary>
        /// Hilfe ausgeben
        /// </summary>
        private static void PrintHelp()
        {
            Console.WriteLine("Verwendung: SODMasterServer [Optionen]");
            Console.WriteLine();
            Console.WriteLine("Optionen:");
            Console.WriteLine("  --port, -p <port>       API-Port (Default: 27016)");
            Console.WriteLine("  --help, -h              Diese Hilfe anzeigen");
            Console.WriteLine();
            Console.WriteLine("Beispiel:");
            Console.WriteLine("  ./SODMasterServer --port 27016");
        }
    }
}
