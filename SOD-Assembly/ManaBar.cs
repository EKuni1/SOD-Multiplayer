using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002E5 RID: 741
[Token(Token = "0x20002E5")]
public class ManaBar : MonoBehaviour
{
	// Token: 0x06001077 RID: 4215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001077")]
	[Address(RVA = "0x6A4970", Offset = "0x6A3970", VA = "0x1806A4970")]
	private void Update()
	{
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001078")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ManaBar()
	{
	}

	// Token: 0x040013D7 RID: 5079
	[Token(Token = "0x40013D7")]
	[FieldOffset(Offset = "0x18")]
	public float lerpSpeed;

	// Token: 0x040013D8 RID: 5080
	[Token(Token = "0x40013D8")]
	[FieldOffset(Offset = "0x20")]
	public WizcardPlayer player;

	// Token: 0x040013D9 RID: 5081
	[Token(Token = "0x40013D9")]
	[FieldOffset(Offset = "0x28")]
	public Image image;
}
