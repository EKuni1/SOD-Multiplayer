using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200040F RID: 1039
[Token(Token = "0x200040F")]
public class ActiveDoorWedgeController : MonoBehaviour
{
	// Token: 0x0600178B RID: 6027 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600178B")]
	[Address(RVA = "0x896C60", Offset = "0x895C60", VA = "0x180896C60")]
	private void Update()
	{
	}

	// Token: 0x0600178C RID: 6028 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600178C")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ActiveDoorWedgeController()
	{
	}

	// Token: 0x04001CB4 RID: 7348
	[Token(Token = "0x4001CB4")]
	[FieldOffset(Offset = "0x18")]
	public InteractableController controller;

	// Token: 0x04001CB5 RID: 7349
	[Token(Token = "0x4001CB5")]
	[FieldOffset(Offset = "0x20")]
	public Transform wedge1;

	// Token: 0x04001CB6 RID: 7350
	[Token(Token = "0x4001CB6")]
	[FieldOffset(Offset = "0x28")]
	public Transform wedge2;

	// Token: 0x04001CB7 RID: 7351
	[Token(Token = "0x4001CB7")]
	[FieldOffset(Offset = "0x30")]
	public float setupProgress;
}
