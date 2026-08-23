using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005B4 RID: 1460
[Token(Token = "0x20005B4")]
public class ReactionIndicatorController : MonoBehaviour
{
	// Token: 0x06002024 RID: 8228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002024")]
	[Address(RVA = "0xAD0E10", Offset = "0xACFE10", VA = "0x180AD0E10")]
	public void Setup(Actor newActor)
	{
	}

	// Token: 0x06002025 RID: 8229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002025")]
	[Address(RVA = "0xAD0EE0", Offset = "0xACFEE0", VA = "0x180AD0EE0")]
	public void UpdateReactionType()
	{
	}

	// Token: 0x06002026 RID: 8230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002026")]
	[Address(RVA = "0xAD1220", Offset = "0xAD0220", VA = "0x180AD1220")]
	private void Update()
	{
	}

	// Token: 0x06002027 RID: 8231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002027")]
	[Address(RVA = "0xAD28F0", Offset = "0xAD18F0", VA = "0x180AD28F0")]
	public ReactionIndicatorController()
	{
	}

	// Token: 0x0400299A RID: 10650
	[Token(Token = "0x400299A")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x0400299B RID: 10651
	[Token(Token = "0x400299B")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform bubbleRect;

	// Token: 0x0400299C RID: 10652
	[Token(Token = "0x400299C")]
	[FieldOffset(Offset = "0x28")]
	public Image img;

	// Token: 0x0400299D RID: 10653
	[Token(Token = "0x400299D")]
	[FieldOffset(Offset = "0x30")]
	public float distance;

	// Token: 0x0400299E RID: 10654
	[Token(Token = "0x400299E")]
	[FieldOffset(Offset = "0x34")]
	public float fadeProgress;

	// Token: 0x0400299F RID: 10655
	[Token(Token = "0x400299F")]
	[FieldOffset(Offset = "0x38")]
	public Actor actor;

	// Token: 0x040029A0 RID: 10656
	[Token(Token = "0x40029A0")]
	[FieldOffset(Offset = "0x40")]
	public InterfaceController.AwarenessIcon awarenessIcon;

	// Token: 0x040029A1 RID: 10657
	[Token(Token = "0x40029A1")]
	[FieldOffset(Offset = "0x48")]
	private NewAIController.ReactionState previousReactionState;

	// Token: 0x040029A2 RID: 10658
	[Token(Token = "0x40029A2")]
	[FieldOffset(Offset = "0x50")]
	public List<CanvasRenderer> graphics;

	// Token: 0x040029A3 RID: 10659
	[Token(Token = "0x40029A3")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 bubbleDesiredSize;

	// Token: 0x040029A4 RID: 10660
	[Token(Token = "0x40029A4")]
	[FieldOffset(Offset = "0x60")]
	public bool displayOnScreen;

	// Token: 0x040029A5 RID: 10661
	[Token(Token = "0x40029A5")]
	[FieldOffset(Offset = "0x64")]
	public Vector3 desiredPosition;

	// Token: 0x040029A6 RID: 10662
	[Token(Token = "0x40029A6")]
	[FieldOffset(Offset = "0x70")]
	private bool firstPositionInit;

	// Token: 0x040029A7 RID: 10663
	[Token(Token = "0x40029A7")]
	[FieldOffset(Offset = "0x74")]
	public float removalProgress;

	// Token: 0x040029A8 RID: 10664
	[Token(Token = "0x40029A8")]
	[FieldOffset(Offset = "0x78")]
	public bool removeHit;

	// Token: 0x040029A9 RID: 10665
	[Token(Token = "0x40029A9")]
	[FieldOffset(Offset = "0x79")]
	public bool removeBlocked;

	// Token: 0x040029AA RID: 10666
	[Token(Token = "0x40029AA")]
	[FieldOffset(Offset = "0x7A")]
	public bool removeFade;

	// Token: 0x040029AB RID: 10667
	[Token(Token = "0x40029AB")]
	[FieldOffset(Offset = "0x7C")]
	public float abortProgress;
}
