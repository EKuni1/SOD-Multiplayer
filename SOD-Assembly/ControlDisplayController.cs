using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200032A RID: 810
[Token(Token = "0x200032A")]
public class ControlDisplayController : MonoBehaviour
{
	// Token: 0x0600123E RID: 4670 RVA: 0x00008B50 File Offset: 0x00006D50
	[Token(Token = "0x600123E")]
	[Address(RVA = "0x6FF0F0", Offset = "0x6FE0F0", VA = "0x1806FF0F0")]
	public bool UpdateDisplay(InteractablePreset.InteractionKey newKey, InteractionController.InteractionSetting newAction)
	{
		return default(bool);
	}

	// Token: 0x0600123F RID: 4671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600123F")]
	[Address(RVA = "0x6FF3F0", Offset = "0x6FE3F0", VA = "0x1806FF3F0")]
	private void Update()
	{
	}

	// Token: 0x06001240 RID: 4672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001240")]
	[Address(RVA = "0x6FFE80", Offset = "0x6FEE80", VA = "0x1806FFE80")]
	private void OnEnable()
	{
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001241")]
	[Address(RVA = "0x6FFF50", Offset = "0x6FEF50", VA = "0x1806FFF50")]
	private void OnDisable()
	{
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001242")]
	[Address(RVA = "0x7001E0", Offset = "0x6FF1E0", VA = "0x1807001E0")]
	public void RefreshIcon()
	{
	}

	// Token: 0x06001243 RID: 4675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001243")]
	[Address(RVA = "0x700340", Offset = "0x6FF340", VA = "0x180700340")]
	public void Remove()
	{
	}

	// Token: 0x06001244 RID: 4676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001244")]
	[Address(RVA = "0x7004B0", Offset = "0x6FF4B0", VA = "0x1807004B0")]
	public void Execute()
	{
	}

	// Token: 0x06001245 RID: 4677 RVA: 0x00008B68 File Offset: 0x00006D68
	[Token(Token = "0x6001245")]
	[Address(RVA = "0x700540", Offset = "0x6FF540", VA = "0x180700540")]
	public bool SetControlText(InteractablePreset.InteractionKey key, string newText, bool useContext = false)
	{
		return default(bool);
	}

	// Token: 0x06001246 RID: 4678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001246")]
	[Address(RVA = "0x700E50", Offset = "0x6FFE50", VA = "0x180700E50")]
	public ControlDisplayController()
	{
	}

	// Token: 0x040016A9 RID: 5801
	[Token(Token = "0x40016A9")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x040016AA RID: 5802
	[Token(Token = "0x40016AA")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI controlText;

	// Token: 0x040016AB RID: 5803
	[Token(Token = "0x40016AB")]
	[FieldOffset(Offset = "0x28")]
	public List<CanvasRenderer> renderers;

	// Token: 0x040016AC RID: 5804
	[Token(Token = "0x40016AC")]
	[FieldOffset(Offset = "0x30")]
	public Image background;

	// Token: 0x040016AD RID: 5805
	[Token(Token = "0x40016AD")]
	[FieldOffset(Offset = "0x38")]
	public SoundIndicatorController soundIndicator;

	// Token: 0x040016AE RID: 5806
	[Token(Token = "0x40016AE")]
	[FieldOffset(Offset = "0x40")]
	public JuiceController juiceController;

	// Token: 0x040016AF RID: 5807
	[Token(Token = "0x40016AF")]
	[FieldOffset(Offset = "0x48")]
	public InteractablePreset.InteractionKey key;

	// Token: 0x040016B0 RID: 5808
	[Token(Token = "0x40016B0")]
	[FieldOffset(Offset = "0x50")]
	public InteractionController.InteractionSetting interactionSetting;

	// Token: 0x040016B1 RID: 5809
	[Token(Token = "0x40016B1")]
	[FieldOffset(Offset = "0x58")]
	public float fadeIn;

	// Token: 0x040016B2 RID: 5810
	[Token(Token = "0x40016B2")]
	[FieldOffset(Offset = "0x5C")]
	public bool remove;

	// Token: 0x040016B3 RID: 5811
	[Token(Token = "0x40016B3")]
	[FieldOffset(Offset = "0x60")]
	public ControlDisplayController.ControlPositioning positioning;

	// Token: 0x040016B4 RID: 5812
	[Token(Token = "0x40016B4")]
	[FieldOffset(Offset = "0x64")]
	public Vector2 desiredPosition;

	// Token: 0x040016B5 RID: 5813
	[Token(Token = "0x40016B5")]
	[FieldOffset(Offset = "0x6C")]
	public Vector2 spawnPosition;

	// Token: 0x040016B6 RID: 5814
	[Token(Token = "0x40016B6")]
	[FieldOffset(Offset = "0x74")]
	public bool assignedSpawnPosition;

	// Token: 0x040016B7 RID: 5815
	[Token(Token = "0x40016B7")]
	[FieldOffset(Offset = "0x75")]
	public bool execute;

	// Token: 0x040016B8 RID: 5816
	[Token(Token = "0x40016B8")]
	[FieldOffset(Offset = "0x78")]
	public float executeProgress;

	// Token: 0x040016B9 RID: 5817
	[Token(Token = "0x40016B9")]
	[FieldOffset(Offset = "0x80")]
	public string actionName;

	// Token: 0x0200032B RID: 811
	[Token(Token = "0x200032B")]
	public enum ControlPositioning
	{
		// Token: 0x040016BB RID: 5819
		[Token(Token = "0x40016BB")]
		neutral,
		// Token: 0x040016BC RID: 5820
		[Token(Token = "0x40016BC")]
		up,
		// Token: 0x040016BD RID: 5821
		[Token(Token = "0x40016BD")]
		down,
		// Token: 0x040016BE RID: 5822
		[Token(Token = "0x40016BE")]
		left,
		// Token: 0x040016BF RID: 5823
		[Token(Token = "0x40016BF")]
		right
	}
}
