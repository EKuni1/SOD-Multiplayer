using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002CB RID: 715
[Token(Token = "0x20002CB")]
public class CruncherSurveillanceActorEntry : MonoBehaviour
{
	// Token: 0x06000FF1 RID: 4081 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF1")]
	[Address(RVA = "0x68AD70", Offset = "0x689D70", VA = "0x18068AD70")]
	public void Setup(SurveillanceApp newParent, Human newHuman)
	{
	}

	// Token: 0x06000FF2 RID: 4082 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF2")]
	[Address(RVA = "0x68AF70", Offset = "0x689F70", VA = "0x18068AF70")]
	public void LoadHeadshot()
	{
	}

	// Token: 0x06000FF3 RID: 4083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF3")]
	[Address(RVA = "0x68B0B0", Offset = "0x68A0B0", VA = "0x18068B0B0")]
	public void SetOnOver(bool val, bool forceUpdate = false)
	{
	}

	// Token: 0x06000FF4 RID: 4084 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF4")]
	[Address(RVA = "0x68B420", Offset = "0x68A420", VA = "0x18068B420")]
	public void UpdateText()
	{
	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF5")]
	[Address(RVA = "0x68BA20", Offset = "0x68AA20", VA = "0x18068BA20")]
	public void Press()
	{
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF6")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public CruncherSurveillanceActorEntry()
	{
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x00008370 File Offset: 0x00006570
	[Token(Token = "0x6000FF7")]
	[Address(RVA = "0x68BAA0", Offset = "0x68AAA0", VA = "0x18068BAA0")]
	private bool <SetOnOver>b__11_0(SceneRecorder.ActorCapture item)
	{
		return default(bool);
	}

	// Token: 0x0400131F RID: 4895
	[Token(Token = "0x400131F")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04001320 RID: 4896
	[Token(Token = "0x4001320")]
	[FieldOffset(Offset = "0x20")]
	public RawImage headshotImg;

	// Token: 0x04001321 RID: 4897
	[Token(Token = "0x4001321")]
	[FieldOffset(Offset = "0x28")]
	public bool loadedHeadshot;

	// Token: 0x04001322 RID: 4898
	[Token(Token = "0x4001322")]
	[FieldOffset(Offset = "0x30")]
	public ComputerOSUIComponent component;

	// Token: 0x04001323 RID: 4899
	[Token(Token = "0x4001323")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform namePopup;

	// Token: 0x04001324 RID: 4900
	[Token(Token = "0x4001324")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI popupText;

	// Token: 0x04001325 RID: 4901
	[Token(Token = "0x4001325")]
	[FieldOffset(Offset = "0x48")]
	public SurveillanceApp appParent;

	// Token: 0x04001326 RID: 4902
	[Token(Token = "0x4001326")]
	[FieldOffset(Offset = "0x50")]
	public Human human;

	// Token: 0x04001327 RID: 4903
	[Token(Token = "0x4001327")]
	[FieldOffset(Offset = "0x58")]
	public bool isOver;
}
