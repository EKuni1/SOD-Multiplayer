using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using SOD.Multiplayer.Shared;

namespace SOD.Multiplayer.Master
{
    public class Program
    {
        private static ConcurrentDictionary<string, ServerInfo> _servers = new();
        
        public static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("  Shadows of Doubt Master Server");
            Console.WriteLine("  Server List & Discovery Service");
            Console.WriteLine("========================================\n");
            
            var config = LoadConfig(args);
            var builder = WebApplication.CreateBuilder(args);
            builder.WebHost.UseUrls($"http://{config.BindAddress}:{config.Port}");
            builder.Services.AddCors();
            
            var app = builder.Build();
            
            // Enable CORS for client access
            app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            
            // Health check endpoint
            app.MapGet("/api/health", () => 
            {
                return Results.Ok(new { Status = "Healthy", Servers = _servers.Count });
            });
            
            // Get server list
            app.MapGet("/api/servers", (HttpContext http) =>
            {
                if (!IsAuthorized(config, http))
                    return Results.Unauthorized();

                // Filter out servers that haven't sent a heartbeat within the configured timeout.
                var now = DateTime.UtcNow;
                var activeServers = _servers.Values
                    .Where(s => (now - s.LastHeartbeat).TotalSeconds < config.HeartbeatTimeout)
                    .ToList();
                
                return Results.Json(activeServers);
            });
            
            // Register server (heartbeat)
            app.MapPost("/api/servers/register", async (HttpContext http) =>
            {
                if (!IsAuthorized(config, http))
                    return Results.Unauthorized();

                using var reader = new StreamReader(http.Request.Body);
                var json = await reader.ReadToEndAsync();
                
                try
                {
                    var serverInfo = JsonConvert.DeserializeObject<ServerInfo>(json);
                    
                    if (serverInfo != null && !string.IsNullOrEmpty(serverInfo.Id))
                    {
                        serverInfo.LastHeartbeat = DateTime.UtcNow;
                        _servers[serverInfo.Id] = serverInfo;
                        
                        Console.WriteLine($"[Master] Server registered: {serverInfo.Name} ({serverInfo.Ip}:{serverInfo.Port}) - Players: {serverInfo.CurrentPlayers}/{serverInfo.MaxPlayers}");
                        
                        return Results.Ok(new { Success = true, ServerId = serverInfo.Id });
                    }
                    
                    return Results.BadRequest(new { Error = "Invalid server info" });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Master] Registration error: {ex.Message}");
                    return Results.BadRequest(new { Error = ex.Message });
                }
            });
            
            // Unregister server
            app.MapDelete("/api/servers/{id}", (string id, HttpContext http) =>
            {
                if (!IsAuthorized(config, http))
                    return Results.Unauthorized();

                if (_servers.TryRemove(id, out var server))
                {
                    Console.WriteLine($"[Master] Server unregistered: {server.Name}");
                    return Results.Ok(new { Success = true });
                }
                
                return Results.NotFound(new { Error = "Server not found" });
            });
            
            Console.WriteLine($"Master Server is running on http://{config.BindAddress}:{config.Port}");
            Console.WriteLine("Press Ctrl+C to stop.\n");
            
            app.Run();
        }

        private static bool IsAuthorized(MasterConfig config, HttpContext http)
        {
            return string.IsNullOrEmpty(config.AuthToken)
                || string.Equals(http.Request.Headers["X-Auth-Token"], config.AuthToken, StringComparison.Ordinal);
        }

        private static MasterConfig LoadConfig(string[] args)
        {
            var configPath = Environment.GetEnvironmentVariable("SOD_MASTER_CONFIG")
                ?? Path.Combine(AppContext.BaseDirectory, "master.cfg");
            var config = new MasterConfig();

            if (File.Exists(configPath))
            {
                var json = File.ReadAllText(configPath);
                config = JsonConvert.DeserializeObject<MasterConfig>(json) ?? config;
                Console.WriteLine($"Master-Konfiguration geladen: {configPath}");
            }
            else
            {
                Console.WriteLine($"Keine Master-Konfiguration gefunden: {configPath}; Defaults werden verwendet.");
            }

            foreach (var arg in args)
            {
                if (arg.StartsWith("--port=", StringComparison.OrdinalIgnoreCase)
                    && int.TryParse(arg[7..], out var port))
                {
                    config.Port = port;
                }
            }

            return config;
        }

        private sealed class MasterConfig
        {
            public string BindAddress { get; set; } = "192.168.178.76";
            public int Port { get; set; } = 5000;
            public int HeartbeatTimeout { get; set; } = 30;
            public string Region { get; set; } = "EU";
            public string AuthToken { get; set; } = "change-this-token";
        }
    }
}
