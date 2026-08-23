using System;
using System.Collections.Concurrent;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
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
            var config = MasterConfig.Load();
            Console.WriteLine("========================================");
            Console.WriteLine("  Shadows of Doubt Master Server");
            Console.WriteLine("  Server List & Discovery Service");
            Console.WriteLine("========================================\n");
            
            var bindAddress = NetworkBinding.GetLocalBindAddress(config.BindAddress, "Master");
            var builder = WebApplication.CreateBuilder(args);
            builder.WebHost.UseUrls($"http://{bindAddress}:{config.Port}");
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
            app.MapGet("/api/servers", () =>
            {
                // Filter out servers that haven't sent heartbeat in 30 seconds
                var now = DateTime.UtcNow;
                var activeServers = _servers.Values
                    .Where(s => (now - s.LastHeartbeat).TotalSeconds < 30)
                    .ToList();
                
                return Results.Json(activeServers);
            });
            
            // Register server (heartbeat)
            app.MapPost("/api/servers/register", async (HttpContext http) =>
            {
                if (!TokensMatch(http.Request.Headers["X-Master-Token"].ToString(), config.AuthToken))
                {
                    return Results.Unauthorized();
                }

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
            app.MapDelete("/api/servers/{id}", (string id) =>
            {
                if (_servers.TryRemove(id, out var server))
                {
                    Console.WriteLine($"[Master] Server unregistered: {server.Name}");
                    return Results.Ok(new { Success = true });
                }
                
                return Results.NotFound(new { Error = "Server not found" });
            });
            
            Console.WriteLine($"Master Server is running on http://{bindAddress}:{config.Port}");
            Console.WriteLine("Press Ctrl+C to stop.\n");
            
            app.Run();
        }

        private static bool TokensMatch(string provided, string expected)
        {
            if (string.IsNullOrEmpty(expected) || string.IsNullOrEmpty(provided))
            {
                return false;
            }

            return CryptographicOperations.FixedTimeEquals(
                Encoding.UTF8.GetBytes(provided), Encoding.UTF8.GetBytes(expected));
        }
    }

    internal sealed class MasterConfig
    {
        public string BindAddress { get; set; } = "0.0.0.0";
        public int Port { get; set; } = 5000;
        public string AuthToken { get; set; } = "change-this-token";

        public static MasterConfig Load()
        {
            var path = Environment.GetEnvironmentVariable("SOD_MASTER_CONFIG") ?? "master.json";
            if (!File.Exists(path))
            {
                return new MasterConfig();
            }

            return Newtonsoft.Json.JsonConvert.DeserializeObject<MasterConfig>(File.ReadAllText(path))
                ?? new MasterConfig();
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

            if (IPAddress.TryParse(configuredAddress, out var address) && IsLocalAddress(address))
            {
                return configuredAddress;
            }

            Console.WriteLine($"[{serviceName}] BindAddress '{configuredAddress}' is not assigned to this machine. Using 0.0.0.0 instead.");
            return "0.0.0.0";
        }

        private static bool IsLocalAddress(IPAddress address)
        {
            if (IPAddress.IsLoopback(address))
            {
                return true;
            }

            return NetworkInterface.GetAllNetworkInterfaces()
                .SelectMany(networkInterface => networkInterface.GetIPProperties().UnicastAddresses)
                .Any(unicastAddress => unicastAddress.Address.Equals(address));
        }
    }
}
