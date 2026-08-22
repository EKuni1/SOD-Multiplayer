using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000415 RID: 1045
[Token(Token = "0x2000415")]
public class ColliderAudio : MonoBehaviour
{
	// Token: 0x060017A2 RID: 6050 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017A2")]
	[Address(RVA = "0x8996A0", Offset = "0x8986A0", VA = "0x1808996A0")]
	private void OnTriggerEnter(Collider coll)
	{
	}

	// Token: 0x060017A3 RID: 6051 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017A3")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ColliderAudio()
	{
	}

	// Token: 0x04001CD0 RID: 7376
	[Token(Token = "0x4001CD0")]
	[FieldOffset(Offset = "0x18")]
	public AudioEvent playSound;
}
