using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine.UI;

// Token: 0x020002D7 RID: 727
[Token(Token = "0x20002D7")]
public class ProfileApp : CruncherAppContent
{
	// Token: 0x0600101F RID: 4127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101F")]
	[Address(RVA = "0x690370", Offset = "0x68F370", VA = "0x180690370", Slot = "5")]
	public override void OnSetup()
	{
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001020")]
	[Address(RVA = "0x691660", Offset = "0x690660", VA = "0x180691660")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001021")]
	[Address(RVA = "0x68D560", Offset = "0x68C560", VA = "0x18068D560")]
	public void ExitButton()
	{
	}

	// Token: 0x06001022 RID: 4130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001022")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ProfileApp()
	{
	}

	// Token: 0x04001347 RID: 4935
	[Token(Token = "0x4001347")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI titleText;

	// Token: 0x04001348 RID: 4936
	[Token(Token = "0x4001348")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI infoText;

	// Token: 0x04001349 RID: 4937
	[Token(Token = "0x4001349")]
	[FieldOffset(Offset = "0x30")]
	public RawImage actorImage;
}
