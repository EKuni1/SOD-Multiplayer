using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

// Token: 0x0200030B RID: 779
[Token(Token = "0x200030B")]
public class PlayerInteresectingGeometryJobcast : MonoBehaviour
{
	// Token: 0x0600110F RID: 4367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600110F")]
	[Address(RVA = "0x6B9D90", Offset = "0x6B8D90", VA = "0x1806B9D90")]
	private void Update()
	{
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001110")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public PlayerInteresectingGeometryJobcast()
	{
	}

	// Token: 0x040014DB RID: 5339
	[Token(Token = "0x40014DB")]
	[FieldOffset(Offset = "0x18")]
	public CharacterController characterController;

	// Token: 0x040014DC RID: 5340
	[Token(Token = "0x40014DC")]
	[FieldOffset(Offset = "0x20")]
	public FirstPersonController fpsController;

	// Token: 0x040014DD RID: 5341
	[Token(Token = "0x40014DD")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 _origin;

	// Token: 0x040014DE RID: 5342
	[Token(Token = "0x40014DE")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 _direction;

	// Token: 0x040014DF RID: 5343
	[Token(Token = "0x40014DF")]
	[FieldOffset(Offset = "0x40")]
	public LayerMask mask;
}
