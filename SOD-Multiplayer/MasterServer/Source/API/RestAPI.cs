using System;
using System.Text.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SOD_Multiplayer.MasterServer.Models;

namespace SOD_Multiplayer.MasterServer.API
{
    /// <summary>
    /// REST API für den Master-Server
    /// </summary>
    public class RestApi
    {
        private readonly ServerListManager _serverListManager;
        private WebApplication _app;
        
        public RestApi(ServerListManager serverListManager)
        {
            _serverListManager = serverListManager;
        }
        
        /// <summary>
        /// API konfigurieren und starten
        /// </summary>
        public void Start(int port)
        {
            var builder = WebApplication.CreateBuilder();
            builder.WebHost.ConfigureKestrel(options =>
            {
                options.ListenAnyIP(port);
            });
            
            _app = builder.Build();
            
            // Routes konfigurieren
            ConfigureRoutes();
            
            Console.WriteLine($"[RestAPI] Gestartet auf Port {port}");
            _app.RunAsync();
        }
        
        /// <summary>
        /// Routes konfigurieren
        /// </summary>
        private void ConfigureRoutes()
        {
            // Health Check
            _app.MapGet("/api/health", async context =>
            {
                await WriteJson(context, new { status = "ok", servers = _serverListManager.ServerCount });
            });
            
            // Server registrieren
            _app.MapPost("/api/servers/register", async context =>
            {
                try
                {
                    var request = await ReadJson<RegisterServerRequest>(context);
                    if (request == null)
                    {
                        context.Response.StatusCode = 400;
                        await WriteJson(context, new { success = false, message = "Invalid request" });
                        return;
                    }
                    
                    var clientIp = context.Connection.RemoteIpAddress?.ToString() ?? "127.0.0.1";
                    var server = _serverListManager.RegisterServer(request, clientIp);
                    
                    if (server != null)
                    {
                        await WriteJson(context, new RegisterServerResponse
                        {
                            Success = true,
                            ServerId = server.Id,
                            Message = "Server registered successfully"
                        });
                    }
                    else
                    {
                        context.Response.StatusCode = 500;
                        await WriteJson(context, new { success = false, message = "Failed to register server" });
                    }
                }
                catch (Exception ex)
                {
                    context.Response.StatusCode = 500;
                    await WriteJson(context, new { success = false, message = ex.Message });
                }
            });
            
            // Server deregistrieren
            _app.MapDelete("/api/servers/{id}", async context =>
            {
                var id = context.Request.RouteValues["id"]?.ToString();
                
                if (_serverListManager.UnregisterServer(id))
                {
                    await WriteJson(context, new { success = true });
                }
                else
                {
                    context.Response.StatusCode = 404;
                    await WriteJson(context, new { success = false, message = "Server not found" });
                }
            });
            
            // Heartbeat empfangen
            _app.MapPut("/api/servers/{id}/heartbeat", async context =>
            {
                var id = context.Request.RouteValues["id"]?.ToString();
                
                try
                {
                    var heartbeat = await ReadJson<HeartbeatRequest>(context);
                    
                    if (_serverListManager.ReceiveHeartbeat(id, heartbeat.CurrentPlayers))
                    {
                        await WriteJson(context, new { success = true });
                    }
                    else
                    {
                        context.Response.StatusCode = 404;
                        await WriteJson(context, new { success = false, message = "Server not found" });
                    }
                }
                catch (Exception ex)
                {
                    context.Response.StatusCode = 500;
                    await WriteJson(context, new { success = false, message = ex.Message });
                }
            });
            
            // Serverliste abrufen
            _app.MapGet("/api/servers", async context =>
            {
                var servers = _serverListManager.GetOnlineServers();
                
                await WriteJson(context, new ServerListResponse
                {
                    Servers = servers.ToArray(),
                    TotalCount = servers.Count
                });
            });
            
            // Einzelnen Server abrufen
            _app.MapGet("/api/servers/{id}", async context =>
            {
                var id = context.Request.RouteValues["id"]?.ToString();
                var server = _serverListManager.GetServerById(id);
                
                if (server != null)
                {
                    await WriteJson(context, server);
                }
                else
                {
                    context.Response.StatusCode = 404;
                    await WriteJson(context, new { error = "Server not found" });
                }
            });
        }
        
        /// <summary>
        /// JSON schreiben
        /// </summary>
        private static async Task WriteJson(HttpContext context, object data)
        {
            context.Response.ContentType = "application/json";
            await JsonSerializer.SerializeAsync(context.Response.Body, data);
        }
        
        /// <summary>
        /// JSON lesen
        /// </summary>
        private static async Task<T> ReadJson<T>(HttpContext context)
        {
            return await JsonSerializer.DeserializeAsync<T>(context.Request.Body);
        }
        
        /// <summary>
        /// API stoppen
        /// </summary>
        public void Stop()
        {
            _app?.StopAsync();
        }
    }
}
