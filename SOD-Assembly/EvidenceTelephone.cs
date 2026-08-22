using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200070B RID: 1803
[Token(Token = "0x200070B")]
public class EvidenceTelephone : Evidence
{
	// Token: 0x060027EE RID: 10222 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027EE")]
	[Address(RVA = "0xC14080", Offset = "0xC13080", VA = "0x180C14080")]
	public EvidenceTelephone(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x060027EF RID: 10223 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027EF")]
	[Address(RVA = "0xC14730", Offset = "0xC13730", VA = "0x180C14730", Slot = "8")]
	public override string GenerateName()
	{
		return null;
	}

	// Token: 0x060027F0 RID: 10224 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027F0")]
	[Address(RVA = "0xC14790", Offset = "0xC13790", VA = "0x180C14790", Slot = "12")]
	public override void BuildDataSources()
	{
	}

	// Token: 0x060027F1 RID: 10225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027F1")]
	[Address(RVA = "0xC147A0", Offset = "0xC137A0", VA = "0x180C147A0", Slot = "13")]
	public override void OnConnectedFactDiscovery(CaseComponent discovered)
	{
	}

	// Token: 0x060027F2 RID: 10226 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027F2")]
	[Address(RVA = "0xC147E0", Offset = "0xC137E0", VA = "0x180C147E0", Slot = "6")]
	public override void OnDiscovery()
	{
	}

	// Token: 0x060027F3 RID: 10227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027F3")]
	[Address(RVA = "0xC14810", Offset = "0xC13810", VA = "0x180C14810")]
	public void OnInhabitantDiscovery(Evidence.Discovery disc)
	{
	}

	// Token: 0x060027F4 RID: 10228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027F4")]
	[Address(RVA = "0xC14830", Offset = "0xC13830", VA = "0x180C14830")]
	public void MergedDataCheck(bool displayMessage)
	{
	}

	// Token: 0x040032D2 RID: 13010
	[Token(Token = "0x40032D2")]
	[FieldOffset(Offset = "0x150")]
	public Telephone telephone;

	// Token: 0x040032D3 RID: 13011
	[Token(Token = "0x40032D3")]
	[FieldOffset(Offset = "0x158")]
	public bool discoveredEverything;
}
