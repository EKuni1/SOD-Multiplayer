using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000889 RID: 2185
[Token(Token = "0x2000889")]
public class ScriptableObjectIDSystem : ScriptableObject
{
	// Token: 0x060029EF RID: 10735 RVA: 0x0000FA80 File Offset: 0x0000DC80
	[Token(Token = "0x60029EF")]
	[Address(RVA = "0xA10FF0", Offset = "0xA0FFF0", VA = "0x180A10FF0")]
	public bool Equals(DoorPairPreset other)
	{
		return default(bool);
	}

	// Token: 0x060029F0 RID: 10736 RVA: 0x0000FA98 File Offset: 0x0000DC98
	[Token(Token = "0x60029F0")]
	[Address(RVA = "0xCB2E20", Offset = "0xCB1E20", VA = "0x180CB2E20", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	// Token: 0x060029F1 RID: 10737 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
	[Token(Token = "0x60029F1")]
	[Address(RVA = "0xCB2F50", Offset = "0xCB1F50", VA = "0x180CB2F50", Slot = "2")]
	public override int GetHashCode()
	{
		return 0;
	}

	// Token: 0x060029F2 RID: 10738 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
	[Token(Token = "0x60029F2")]
	[Address(RVA = "0xCB30C0", Offset = "0xCB20C0", VA = "0x180CB30C0")]
	public static bool operator ==(ScriptableObjectIDSystem c1, ScriptableObjectIDSystem c2)
	{
		return default(bool);
	}

	// Token: 0x060029F3 RID: 10739 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
	[Token(Token = "0x60029F3")]
	[Address(RVA = "0xCB30E0", Offset = "0xCB20E0", VA = "0x180CB30E0")]
	public static bool operator !=(ScriptableObjectIDSystem c1, ScriptableObjectIDSystem c2)
	{
		return default(bool);
	}

	// Token: 0x060029F4 RID: 10740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029F4")]
	[Address(RVA = "0x5C7970", Offset = "0x5C6970", VA = "0x1805C7970")]
	public ScriptableObjectIDSystem()
	{
	}

	// Token: 0x040042FA RID: 17146
	[Token(Token = "0x40042FA")]
	[FieldOffset(Offset = "0x18")]
	public string id;
}
