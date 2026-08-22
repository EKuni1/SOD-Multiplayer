using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x020002CC RID: 716
[Token(Token = "0x20002CC")]
public class CruncherTimelineEntry : ComputerOSUIComponent
{
	// Token: 0x06000FF8 RID: 4088 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF8")]
	[Address(RVA = "0x68BAD0", Offset = "0x68AAD0", VA = "0x18068BAD0")]
	public void Setup(SurveillanceApp newApp, SceneRecorder.SceneCapture newCap)
	{
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF9")]
	[Address(RVA = "0x68BB80", Offset = "0x68AB80", VA = "0x18068BB80")]
	public void SetMouseOver(bool val)
	{
	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FFA")]
	[Address(RVA = "0x68BB90", Offset = "0x68AB90", VA = "0x18068BB90")]
	public void SetFlagged(bool val)
	{
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FFB")]
	[Address(RVA = "0x68BBA0", Offset = "0x68ABA0", VA = "0x18068BBA0")]
	public void VisualUpdate()
	{
	}

	// Token: 0x06000FFC RID: 4092 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FFC")]
	[Address(RVA = "0x68BDD0", Offset = "0x68ADD0", VA = "0x18068BDD0", Slot = "4")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FFD")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public CruncherTimelineEntry()
	{
	}

	// Token: 0x04001328 RID: 4904
	[Token(Token = "0x4001328")]
	[FieldOffset(Offset = "0x28")]
	public SurveillanceApp app;

	// Token: 0x04001329 RID: 4905
	[Token(Token = "0x4001329")]
	[FieldOffset(Offset = "0x30")]
	public Image img;

	// Token: 0x0400132A RID: 4906
	[Token(Token = "0x400132A")]
	[FieldOffset(Offset = "0x38")]
	public JuiceController juice;

	// Token: 0x0400132B RID: 4907
	[Token(Token = "0x400132B")]
	[FieldOffset(Offset = "0x40")]
	[NonSerialized]
	public SceneRecorder.SceneCapture sceneReference;

	// Token: 0x0400132C RID: 4908
	[Token(Token = "0x400132C")]
	[FieldOffset(Offset = "0x48")]
	public bool mousedOver;

	// Token: 0x0400132D RID: 4909
	[Token(Token = "0x400132D")]
	[FieldOffset(Offset = "0x49")]
	public bool flagged;
}
