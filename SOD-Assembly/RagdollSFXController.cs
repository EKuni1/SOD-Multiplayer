using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B8 RID: 696
[Token(Token = "0x20002B8")]
public class RagdollSFXController : MonoBehaviour
{
	// Token: 0x06000FA6 RID: 4006 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA6")]
	[Address(RVA = "0x67DD10", Offset = "0x67CD10", VA = "0x18067DD10")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA7")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public RagdollSFXController()
	{
	}

	// Token: 0x040012B2 RID: 4786
	[Token(Token = "0x40012B2")]
	[FieldOffset(Offset = "0x18")]
	public Actor actor;

	// Token: 0x040012B3 RID: 4787
	[Token(Token = "0x40012B3")]
	[FieldOffset(Offset = "0x20")]
	public bool playedFloorImpact;
}
