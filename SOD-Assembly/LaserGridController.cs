using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000477 RID: 1143
[Token(Token = "0x2000477")]
public class LaserGridController : SwitchSyncBehaviour
{
	// Token: 0x06001A28 RID: 6696 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A28")]
	[Address(RVA = "0x973910", Offset = "0x972910", VA = "0x180973910")]
	private void Awake()
	{
	}

	// Token: 0x06001A29 RID: 6697 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A29")]
	[Address(RVA = "0x973A40", Offset = "0x972A40", VA = "0x180973A40")]
	private void Update()
	{
	}

	// Token: 0x06001A2A RID: 6698 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A2A")]
	[Address(RVA = "0x974B10", Offset = "0x973B10", VA = "0x180974B10")]
	public LaserGridController()
	{
	}

	// Token: 0x04001F93 RID: 8083
	[Token(Token = "0x4001F93")]
	[FieldOffset(Offset = "0x40")]
	public Transform movementParent;

	// Token: 0x04001F94 RID: 8084
	[Token(Token = "0x4001F94")]
	[FieldOffset(Offset = "0x48")]
	public Transform laserParent;

	// Token: 0x04001F95 RID: 8085
	[Token(Token = "0x4001F95")]
	[FieldOffset(Offset = "0x50")]
	public Transform laser;

	// Token: 0x04001F96 RID: 8086
	[Token(Token = "0x4001F96")]
	[FieldOffset(Offset = "0x58")]
	public InteractableController controller;

	// Token: 0x04001F97 RID: 8087
	[Token(Token = "0x4001F97")]
	[FieldOffset(Offset = "0x60")]
	public float speed;

	// Token: 0x04001F98 RID: 8088
	[Token(Token = "0x4001F98")]
	[FieldOffset(Offset = "0x64")]
	public float range;

	// Token: 0x04001F99 RID: 8089
	[Token(Token = "0x4001F99")]
	[FieldOffset(Offset = "0x68")]
	public bool useMovementX;

	// Token: 0x04001F9A RID: 8090
	[Token(Token = "0x4001F9A")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve movementX;

	// Token: 0x04001F9B RID: 8091
	[Token(Token = "0x4001F9B")]
	[FieldOffset(Offset = "0x78")]
	public bool useMovementY;

	// Token: 0x04001F9C RID: 8092
	[Token(Token = "0x4001F9C")]
	[FieldOffset(Offset = "0x80")]
	public AnimationCurve movementY;

	// Token: 0x04001F9D RID: 8093
	[Token(Token = "0x4001F9D")]
	[FieldOffset(Offset = "0x88")]
	public bool useMovementZ;

	// Token: 0x04001F9E RID: 8094
	[Token(Token = "0x4001F9E")]
	[FieldOffset(Offset = "0x90")]
	public AnimationCurve movementZ;

	// Token: 0x04001F9F RID: 8095
	[Token(Token = "0x4001F9F")]
	[FieldOffset(Offset = "0x98")]
	public bool useRotationX;

	// Token: 0x04001FA0 RID: 8096
	[Token(Token = "0x4001FA0")]
	[FieldOffset(Offset = "0xA0")]
	public AnimationCurve rotationX;

	// Token: 0x04001FA1 RID: 8097
	[Token(Token = "0x4001FA1")]
	[FieldOffset(Offset = "0xA8")]
	public bool useRotationY;

	// Token: 0x04001FA2 RID: 8098
	[Token(Token = "0x4001FA2")]
	[FieldOffset(Offset = "0xB0")]
	public AnimationCurve rotationY;

	// Token: 0x04001FA3 RID: 8099
	[Token(Token = "0x4001FA3")]
	[FieldOffset(Offset = "0xB8")]
	public bool useRotationZ;

	// Token: 0x04001FA4 RID: 8100
	[Token(Token = "0x4001FA4")]
	[FieldOffset(Offset = "0xC0")]
	public AnimationCurve rotationZ;

	// Token: 0x04001FA5 RID: 8101
	[Token(Token = "0x4001FA5")]
	[FieldOffset(Offset = "0xC8")]
	public float cycle;

	// Token: 0x04001FA6 RID: 8102
	[Token(Token = "0x4001FA6")]
	[FieldOffset(Offset = "0xCC")]
	public bool bounce;

	// Token: 0x04001FA7 RID: 8103
	[Token(Token = "0x4001FA7")]
	[FieldOffset(Offset = "0xD0")]
	public float randomMultiplier;
}
