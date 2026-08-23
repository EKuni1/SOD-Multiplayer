using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ModIO;

// Token: 0x0200039F RID: 927
[Token(Token = "0x200039F")]
[Serializable]
public class ModSettingsData
{
	// Token: 0x060014CA RID: 5322 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014CA")]
	[Address(RVA = "0x7D3800", Offset = "0x7D2800", VA = "0x1807D3800")]
	public string GetContentDirectory()
	{
		return null;
	}

	// Token: 0x060014CB RID: 5323 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014CB")]
	[Address(RVA = "0x7D3840", Offset = "0x7D2840", VA = "0x1807D3840")]
	public void SaveSettings()
	{
	}

	// Token: 0x060014CC RID: 5324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014CC")]
	[Address(RVA = "0x7D3A50", Offset = "0x7D2A50", VA = "0x1807D3A50")]
	public ModSettingsData()
	{
	}

	// Token: 0x04001939 RID: 6457
	[Token(Token = "0x4001939")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	// Token: 0x0400193A RID: 6458
	[Token(Token = "0x400193A")]
	[FieldOffset(Offset = "0x18")]
	public string version;

	// Token: 0x0400193B RID: 6459
	[Token(Token = "0x400193B")]
	[FieldOffset(Offset = "0x20")]
	public int loadOrderValue;

	// Token: 0x0400193C RID: 6460
	[Token(Token = "0x400193C")]
	[FieldOffset(Offset = "0x28")]
	public string creator;

	// Token: 0x0400193D RID: 6461
	[Token(Token = "0x400193D")]
	[FieldOffset(Offset = "0x30")]
	public string summary;

	// Token: 0x0400193E RID: 6462
	[Token(Token = "0x400193E")]
	[FieldOffset(Offset = "0x38")]
	public bool enabled;

	// Token: 0x0400193F RID: 6463
	[Token(Token = "0x400193F")]
	[FieldOffset(Offset = "0x3C")]
	public ModSettingsData.ModSource modSource;

	// Token: 0x04001940 RID: 6464
	[Token(Token = "0x4001940")]
	[FieldOffset(Offset = "0x40")]
	public string workshopPath;

	// Token: 0x04001941 RID: 6465
	[Token(Token = "0x4001941")]
	[FieldOffset(Offset = "0x48")]
	public string workshopID;

	// Token: 0x04001942 RID: 6466
	[Token(Token = "0x4001942")]
	[FieldOffset(Offset = "0x50")]
	public List<string> workshopTags;

	// Token: 0x04001943 RID: 6467
	[Token(Token = "0x4001943")]
	[FieldOffset(Offset = "0x58")]
	[NonSerialized]
	public UserInstalledMod modData;

	// Token: 0x04001944 RID: 6468
	[Token(Token = "0x4001944")]
	[FieldOffset(Offset = "0x2B0")]
	[NonSerialized]
	public string directory;

	// Token: 0x020003A0 RID: 928
	[Token(Token = "0x20003A0")]
	public enum ModSource
	{
		// Token: 0x04001946 RID: 6470
		[Token(Token = "0x4001946")]
		local,
		// Token: 0x04001947 RID: 6471
		[Token(Token = "0x4001947")]
		modIO,
		// Token: 0x04001948 RID: 6472
		[Token(Token = "0x4001948")]
		steamWorkshop
	}
}
