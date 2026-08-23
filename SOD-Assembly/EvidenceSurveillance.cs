using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200070A RID: 1802
[Token(Token = "0x200070A")]
public class EvidenceSurveillance : Evidence
{
	// Token: 0x060027EB RID: 10219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027EB")]
	[Address(RVA = "0xC13650", Offset = "0xC12650", VA = "0x180C13650")]
	public EvidenceSurveillance(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x060027EC RID: 10220 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027EC")]
	[Address(RVA = "0xC138F0", Offset = "0xC128F0", VA = "0x180C138F0", Slot = "8")]
	public override string GenerateName()
	{
		return null;
	}

	// Token: 0x060027ED RID: 10221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027ED")]
	[Address(RVA = "0xC13B20", Offset = "0xC12B20", VA = "0x180C13B20", Slot = "6")]
	public override void OnDiscovery()
	{
	}

	// Token: 0x040032D0 RID: 13008
	[Token(Token = "0x40032D0")]
	[FieldOffset(Offset = "0x150")]
	public int captureID;

	// Token: 0x040032D1 RID: 13009
	[Token(Token = "0x40032D1")]
	[FieldOffset(Offset = "0x158")]
	public SceneRecorder.SceneCapture savedCapture;
}
