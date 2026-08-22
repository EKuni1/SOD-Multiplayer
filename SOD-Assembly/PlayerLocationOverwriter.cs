using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000032 RID: 50
[Token(Token = "0x2000032")]
public class PlayerLocationOverwriter : MonoBehaviour
{
	// Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x5C90E0", Offset = "0x5C80E0", VA = "0x1805C90E0")]
	private void Start()
	{
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x5C9170", Offset = "0x5C8170", VA = "0x1805C9170")]
	public void OverWriteLocation()
	{
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x5C9660", Offset = "0x5C8660", VA = "0x1805C9660")]
	public PlayerLocationOverwriter()
	{
	}

	// Token: 0x04000116 RID: 278
	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x18")]
	public float ColliderSizePercent;

	// Token: 0x04000117 RID: 279
	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x1C")]
	public LayerMask layerMask;

	// Token: 0x04000118 RID: 280
	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x20")]
	private CharacterController characterController;
}
