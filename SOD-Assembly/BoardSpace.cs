using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002E1 RID: 737
[Token(Token = "0x20002E1")]
public class BoardSpace : MonoBehaviour
{
	// Token: 0x06001062 RID: 4194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001062")]
	[Address(RVA = "0x6A0AC0", Offset = "0x69FAC0", VA = "0x1806A0AC0")]
	private void Update()
	{
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001063")]
	[Address(RVA = "0x6A0C80", Offset = "0x69FC80", VA = "0x1806A0C80")]
	public void UpdateStatsAndImage()
	{
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x000084C0 File Offset: 0x000066C0
	[Token(Token = "0x6001064")]
	[Address(RVA = "0x6A1450", Offset = "0x6A0450", VA = "0x1806A1450")]
	private bool IsCursorOverCard()
	{
		return default(bool);
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001065")]
	[Address(RVA = "0x6A17B0", Offset = "0x6A07B0", VA = "0x1806A17B0")]
	private void Start()
	{
	}

	// Token: 0x06001066 RID: 4198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001066")]
	[Address(RVA = "0x6A2120", Offset = "0x6A1120", VA = "0x1806A2120")]
	public void BecomeTerritory(bool isEnemyTerritory)
	{
	}

	// Token: 0x06001067 RID: 4199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001067")]
	[Address(RVA = "0x6A2310", Offset = "0x6A1310", VA = "0x1806A2310")]
	public void BecomeNoMansLand()
	{
	}

	// Token: 0x06001068 RID: 4200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001068")]
	[Address(RVA = "0x6A24F0", Offset = "0x6A14F0", VA = "0x1806A24F0")]
	public void PlaceHere()
	{
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001069")]
	[Address(RVA = "0x6A2D00", Offset = "0x6A1D00", VA = "0x1806A2D00")]
	public void ForcePlaceHere()
	{
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600106A")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public BoardSpace()
	{
	}

	// Token: 0x040013B9 RID: 5049
	[Token(Token = "0x40013B9")]
	[FieldOffset(Offset = "0x18")]
	public bool occupied;

	// Token: 0x040013BA RID: 5050
	[Token(Token = "0x40013BA")]
	[FieldOffset(Offset = "0x1C")]
	public TerritoryOwner owner;

	// Token: 0x040013BB RID: 5051
	[Token(Token = "0x40013BB")]
	[FieldOffset(Offset = "0x20")]
	public Wizcard myWizcard;

	// Token: 0x040013BC RID: 5052
	[Token(Token = "0x40013BC")]
	[FieldOffset(Offset = "0x28")]
	public Sprite emptySprite;

	// Token: 0x040013BD RID: 5053
	[Token(Token = "0x40013BD")]
	[FieldOffset(Offset = "0x30")]
	public Sprite enemyTileSprite;

	// Token: 0x040013BE RID: 5054
	[Token(Token = "0x40013BE")]
	[FieldOffset(Offset = "0x38")]
	public Sprite playerTileSprite;

	// Token: 0x040013BF RID: 5055
	[Token(Token = "0x40013BF")]
	[FieldOffset(Offset = "0x40")]
	public Sprite blankSprite;

	// Token: 0x040013C0 RID: 5056
	[Token(Token = "0x40013C0")]
	[FieldOffset(Offset = "0x48")]
	[NonSerialized]
	public Image iconImage;

	// Token: 0x040013C1 RID: 5057
	[Token(Token = "0x40013C1")]
	[FieldOffset(Offset = "0x50")]
	[NonSerialized]
	public Image boardSpaceImage;

	// Token: 0x040013C2 RID: 5058
	[Token(Token = "0x40013C2")]
	[FieldOffset(Offset = "0x58")]
	[NonSerialized]
	public Animator animator;

	// Token: 0x040013C3 RID: 5059
	[Token(Token = "0x40013C3")]
	[FieldOffset(Offset = "0x60")]
	private WizcardsApp app;

	// Token: 0x040013C4 RID: 5060
	[Token(Token = "0x40013C4")]
	[FieldOffset(Offset = "0x68")]
	private ComputerController comp;

	// Token: 0x040013C5 RID: 5061
	[Token(Token = "0x40013C5")]
	[FieldOffset(Offset = "0x70")]
	private ComputerOSUIComponent hoverComponent;

	// Token: 0x040013C6 RID: 5062
	[Token(Token = "0x40013C6")]
	[FieldOffset(Offset = "0x78")]
	private bool isHovered;

	// Token: 0x040013C7 RID: 5063
	[Token(Token = "0x40013C7")]
	[FieldOffset(Offset = "0x80")]
	private RectTransform rectTransform;

	// Token: 0x040013C8 RID: 5064
	[Token(Token = "0x40013C8")]
	[FieldOffset(Offset = "0x88")]
	public WizcardStats[] wizcardStats;
}
