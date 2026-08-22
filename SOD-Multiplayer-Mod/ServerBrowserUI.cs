using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// SOD Multiplayer Mod - Server Browser Component
/// Zeigt eine Liste aller verfügbaren Multiplayer-Server an
/// </summary>
[Token(Token = "0x2000600")]
public class ServerBrowserUI : MonoBehaviour
{
    [Token(Token = "0x4002500")]
    [FieldOffset(Offset = "0x18")]
    public GameObject serverListPanel;
    
    [Token(Token = "0x4002501")]
    [FieldOffset(Offset = "0x20")]
    public Transform serverListContent;
    
    [Token(Token = "0x4002502")]
    [FieldOffset(Offset = "0x28")]
    public GameObject serverEntryPrefab;
    
    [Token(Token = "0x4002503")]
    [FieldOffset(Offset = "0x30")]
    public Button refreshButton;
    
    [Token(Token = "0x4002504")]
    [FieldOffset(Offset = "0x38")]
    public Button closeButton;
    
    [Token(Token = "0x4002505")]
    [FieldOffset(Offset = "0x40")]
    public InputField passwordInput;
    
    [Token(Token = "0x4002506")]
    [FieldOffset(Offset = "0x48")]
    public Button joinButton;
    
    [Token(Token = "0x4002507")]
    [FieldOffset(Offset = "0x50")]
    public Text statusText;
    
    [Token(Token = "0x4002508")]
    [FieldOffset(Offset = "0x58")]
    private List<ServerInfo> serverList;
    
    [Token(Token = "0x4002509")]
    [FieldOffset(Offset = "0x60")]
    private ServerInfo selectedServer;
    
    [Token(Token = "0x6002000")]
    [Address(RVA = "0xB00000", Offset = "0xAFF000", VA = "0x180B00000")]
    public void Awake()
    {
        serverList = new List<ServerInfo>();
        InitializeUI();
    }
    
    [Token(Token = "0x6002001")]
    [Address(RVA = "0xB00100", Offset = "0xAFF100", VA = "0x180B00100")]
    private void InitializeUI()
    {
        if (refreshButton != null)
            refreshButton.onClick.AddListener(RefreshServerList);
        
        if (closeButton != null)
            closeButton.onClick.AddListener(CloseBrowser);
        
        if (joinButton != null)
            joinButton.onClick.AddListener(JoinSelectedServer);
    }
    
    [Token(Token = "0x6002002")]
    [Address(RVA = "0xB00200", Offset = "0xAFF200", VA = "0x180B00200")]
    public void RefreshServerList()
    {
        if (statusText != null)
            statusText.text = "Suche nach Servern...";
        
        // Anfrage an den Hauptserver starten
        MultiplayerManager.Instance.RequestServerList();
    }
    
    [Token(Token = "0x6002003")]
    [Address(RVA = "0xB00300", Offset = "0xAFF300", VA = "0x180B00300")]
    public void UpdateServerList(List<ServerInfo> servers)
    {
        serverList = servers ?? new List<ServerInfo>();
        ClearServerListUI();
        
        foreach (var server in serverList)
        {
            CreateServerEntry(server);
        }
        
        if (statusText != null)
            statusText.text = $"{serverList.Count} Server gefunden";
    }
    
    [Token(Token = "0x6002004")]
    [Address(RVA = "0xB00400", Offset = "0xAFF400", VA = "0x180B00400")]
    private void CreateServerEntry(ServerInfo server)
    {
        if (serverEntryPrefab == null || serverListContent == null)
            return;
        
        GameObject entry = Instantiate(serverEntryPrefab, serverListContent);
        var entryController = entry.GetComponent<ServerEntryController>();
        
        if (entryController != null)
        {
            entryController.Initialize(server, this);
        }
    }
    
    [Token(Token = "0x6002005")]
    [Address(RVA = "0xB00500", Offset = "0xAFF500", VA = "0x180B00500")]
    private void ClearServerListUI()
    {
        if (serverListContent == null)
            return;
        
        for (int i = serverListContent.childCount - 1; i >= 0; i--)
        {
            Destroy(serverListContent.GetChild(i).gameObject);
        }
    }
    
    [Token(Token = "0x6002006")]
    [Address(RVA = "0xB00600", Offset = "0xAFF600", VA = "0x180B00600")]
    public void SelectServer(ServerInfo server)
    {
        selectedServer = server;
        
        if (server.RequiresPassword)
        {
            if (passwordInput != null)
                passwordInput.gameObject.SetActive(true);
            else
                passwordInput = null;
        }
        else
        {
            if (passwordInput != null)
                passwordInput.gameObject.SetActive(false);
        }
        
        if (joinButton != null)
            joinButton.interactable = true;
    }
    
    [Token(Token = "0x6002007")]
    [Address(RVA = "0xB00700", Offset = "0xAFF700", VA = "0x180B00700")]
    public void JoinSelectedServer()
    {
        if (selectedServer == null)
            return;
        
        string password = "";
        if (selectedServer.RequiresPassword && passwordInput != null)
        {
            password = passwordInput.text;
        }
        
        MultiplayerManager.Instance.JoinServer(selectedServer, password);
    }
    
    [Token(Token = "0x6002008")]
    [Address(RVA = "0xB00800", Offset = "0xAFF800", VA = "0x180B00800")]
    public void CloseBrowser()
    {
        gameObject.SetActive(false);
    }
    
    [Token(Token = "0x6002009")]
    [Address(RVA = "0xB00900", Offset = "0xAFF900", VA = "0x180B00900")]
    public void ShowError(string message)
    {
        if (statusText != null)
            statusText.text = $"FEHLER: {message}";
    }
}
