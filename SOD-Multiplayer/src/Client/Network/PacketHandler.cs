using System;
using System.Collections.Generic;
using UnityEngine;
using SOD.Multiplayer.Shared;

namespace SOD.Multiplayer.Client.Network
{
    public class PacketHandler
    {
        private NetworkClient _client;
        
        public PacketHandler(NetworkClient client)
        {
            _client = client;
            _client.OnPacketReceived += HandlePacket;
        }
        
        private void HandlePacket(Packet packet)
        {
            switch (packet.Type)
            {
                case PacketType.JoinAccepted:
                    OnJoinAccepted(packet as JoinResponsePacket);
                    break;
                    
                case PacketType.JoinRejected:
                    OnJoinRejected(packet);
                    break;
                    
                case PacketType.PlayerJoined:
                    OnPlayerJoined(packet);
                    break;
                    
                case PacketType.PlayerLeft:
                    OnPlayerLeft(packet);
                    break;
                    
                case PacketType.PlayerList:
                    OnPlayerListReceived(packet);
                    break;
                    
                case PacketType.GameState:
                    OnGameStateReceived(packet as GameStatePacket);
                    break;
                    
                case PacketType.ChatBroadcast:
                    OnChatMessage(packet as ChatPacket);
                    break;
                    
                default:
                    NetworkClient.LogInfo($"Unknown packet type: {packet.Type}");
                    break;
            }
        }
        
        private void OnJoinAccepted(JoinResponsePacket packet)
        {
            NetworkClient.LogInfo($"Successfully joined server as {packet.AssignedPlayerId}");
            // Initialize local player with assigned ID
        }
        
        private void OnJoinRejected(Packet packet)
        {
            var response = packet as JoinResponsePacket;
            NetworkClient.LogError($"Join rejected: {response?.Reason}");
            // Show error UI to player
        }
        
        private void OnPlayerJoined(Packet packet)
        {
            NetworkClient.LogInfo("Player joined the game");
            // Add remote player to scene
        }
        
        private void OnPlayerLeft(Packet packet)
        {
            NetworkClient.LogInfo("Player left the game");
            // Remove remote player from scene
        }
        
        private void OnPlayerListReceived(Packet packet)
        {
            NetworkClient.LogInfo("Received player list");
            // Sync all players
        }
        
        private void OnGameStateReceived(GameStatePacket packet)
        {
            // Update game state based on server data
            NetworkClient.LogInfo($"Game state update: Time={packet.TimeOfDay}");
        }
        
        private void OnChatMessage(ChatPacket packet)
        {
            NetworkClient.LogInfo($"Chat: {packet.Message}");
            // Display chat message in UI
        }
    }
}
