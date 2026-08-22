using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// SOD Multiplayer Mod - Server Eintrag UI Controller
/// Zeigt Informationen eines einzelnen Servers in der Liste an
/// </summary>
[Token(Token = "0x2000603")]
public class ServerEntryController : MonoBehaviour
{
    [Token(Token = "0x4002540")]
    [FieldOffset(Offset = "0x18")]
    public Text serverNameText;
    
    [Token(Token = "0x4002541")]
    [FieldOffset(Offset = "0x20")]
    public Text mapNameText;
    
    [Token(Token = "0x4002542")]
    [FieldOffset(Offset = "0x28")]
    public Text playersText;
    
    [Token(Token = "0x4002543")]
    [FieldOffset(Offset = "0x30")]
    public Text pingText;
    
    [Token(Token = "0x4002544")]
    [FieldOffset(Offset = "0x38")]
    public Image passwordIcon;
    
    [Token(Token = "0x4002545")]
    [FieldOffset(Offset = "0x40")]
    public Button selectButton;
    
    [Token(Token = "0x4002546")]
    [FieldOffset(Offset = "0x48")]
    private ServerInfo serverInfo;
    
    [Token(Token = "0x4002547")]
    [FieldOffset(Offset = "0x50")]
    private ServerBrowserUI parentBrowser;
    
    [Token(Token = "0x6002040")]
    [Address(RVA = "0xB03000", Offset = "0xB02000", VA = "0x180B03000")]
    public void Initialize(ServerInfo server, ServerBrowserUI browser)
    {
        serverInfo = server;
        parentBrowser = browser;
        
        UpdateDisplay();
        
        if (selectButton != null)
        {
            selectButton.onClick.AddListener(OnSelected);
        }
    }
    
    [Token(Token = "0x6002041")]
    [Address(RVA = "0xB03100", Offset = "0xB02100", VA = "0x180B03100")]
    private void UpdateDisplay()
    {
        if (serverNameText != null)
            serverNameText.text = serverInfo.ServerName;
        
        if (mapNameText != null)
            mapNameText.text = serverInfo.MapName;
        
        if (playersText != null)
            playersText.text = $"{serverInfo.CurrentPlayers}/{serverInfo.MaxPlayers}";
        
        if (pingText != null)
            pingText.text = $"{serverInfo.Ping}ms";
        
        if (passwordIcon != null)
            passwordIcon.gameObject.SetActive(serverInfo.RequiresPassword);
        
        // Graue aus wenn voll
        if (!serverInfo.HasFreeSlot())
        {
            var canvasGroup = GetComponent<CanvasGroup>();
            if (canvasGroup != null)
                canvasGroup.alpha = 0.5f;
        }
    }
    
    [Token(Token = "0x6002042")]
    [Address(RVA = "0xB03200", Offset = "0xB02200", VA = "0x180B03200")]
    private void OnSelected()
    {
        if (parentBrowser != null && serverInfo != null)
        {
            parentBrowser.SelectServer(serverInfo);
        }
    }
    
    [Token(Token = "0x6002043")]
    [Address(RVA = "0xB03300", Offset = "0xB02300", VA = "0x180B03300")]
    public void SetSelected(bool isSelected)
    {
        var image = GetComponent<Image>();
        if (image != null)
        {
            image.color = isSelected ? new Color(0.2f, 0.6f, 1f, 0.5f) : new Color(1f, 1f, 1f, 0.1f);
        }
    }
}
