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
                    UnityEngine.Debug.LogWarning($"[SOD Multiplayer] Unknown packet type: {packet.Type}");
                    break;
            }
        }
        
        private void OnJoinAccepted(JoinResponsePacket packet)
        {
            UnityEngine.Debug.Log($"[SOD Multiplayer] Successfully joined server as {packet.AssignedPlayerId}");
            // Initialize local player with assigned ID
        }
        
        private void OnJoinRejected(Packet packet)
        {
            var response = packet as JoinResponsePacket;
            UnityEngine.Debug.LogError($"[SOD Multiplayer] Join rejected: {response?.Reason}");
            // Show error UI to player
        }
        
        private void OnPlayerJoined(Packet packet)
        {
            UnityEngine.Debug.Log($"[SOD Multiplayer] Player joined the game");
            // Add remote player to scene
        }
        
        private void OnPlayerLeft(Packet packet)
        {
            UnityEngine.Debug.Log($"[SOD Multiplayer] Player left the game");
            // Remove remote player from scene
        }
        
        private void OnPlayerListReceived(Packet packet)
        {
            UnityEngine.Debug.Log($"[SOD Multiplayer] Received player list");
            // Sync all players
        }
        
        private void OnGameStateReceived(GameStatePacket packet)
        {
            // Update game state based on server data
            UnityEngine.Debug.Log($"[SOD Multiplayer] Game state update: Time={packet.TimeOfDay}");
        }
        
        private void OnChatMessage(ChatPacket packet)
        {
            UnityEngine.Debug.Log($"[SOD Multiplayer] Chat: {packet.Message}");
            // Display chat message in UI
        }
    }
}
