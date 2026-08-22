using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008DA RID: 2266
[Token(Token = "0x20008DA")]
public class WindowMapper : MonoBehaviour
{
	// Token: 0x06002AD4 RID: 10964 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002AD4")]
	[Address(RVA = "0xCC2DF0", Offset = "0xCC1DF0", VA = "0x180CC2DF0")]
	public void SpawnObjectsOnWindows()
	{
	}

	// Token: 0x06002AD5 RID: 10965 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002AD5")]
	[Address(RVA = "0xCC45D0", Offset = "0xCC35D0", VA = "0x180CC45D0")]
	public void GenerateCableLinkingPoints()
	{
	}

	// Token: 0x06002AD6 RID: 10966 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002AD6")]
	[Address(RVA = "0xCC4C50", Offset = "0xCC3C50", VA = "0x180CC4C50")]
	public void GenerateNeonSignSidePoints()
	{
	}

	// Token: 0x06002AD7 RID: 10967 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002AD7")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public WindowMapper()
	{
	}

	// Token: 0x04004B15 RID: 19221
	[Token(Token = "0x4004B15")]
	[FieldOffset(Offset = "0x18")]
	public GameObject buildingObject;

	// Token: 0x04004B16 RID: 19222
	[Token(Token = "0x4004B16")]
	[FieldOffset(Offset = "0x20")]
	public GameObject debugWindow;

	// Token: 0x04004B17 RID: 19223
	[Token(Token = "0x4004B17")]
	[FieldOffset(Offset = "0x28")]
	public BuildingPreset preset;

	// Token: 0x04004B18 RID: 19224
	[Token(Token = "0x4004B18")]
	[FieldOffset(Offset = "0x30")]
	public Transform buildingModel;

	// Token: 0x04004B19 RID: 19225
	[Token(Token = "0x4004B19")]
	[FieldOffset(Offset = "0x38")]
	public Transform cableLinkingContainer;

	// Token: 0x04004B1A RID: 19226
	[Token(Token = "0x4004B1A")]
	[FieldOffset(Offset = "0x40")]
	public Transform neonSideSignContainer;
}
