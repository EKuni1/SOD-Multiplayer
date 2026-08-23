using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000413 RID: 1043
[Token(Token = "0x2000413")]
public class CCTV : Machine
{
	// Token: 0x06001798 RID: 6040 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001798")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void Setup(NewNode newLoc)
	{
	}

	// Token: 0x06001799 RID: 6041 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001799")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void SetName()
	{
	}

	// Token: 0x0600179A RID: 6042 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600179A")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void OnCitizenEnter(Citizen cc)
	{
	}

	// Token: 0x0600179B RID: 6043 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600179B")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void OnCitizenExit(Citizen cc)
	{
	}

	// Token: 0x0600179C RID: 6044 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600179C")]
	[Address(RVA = "0x898C10", Offset = "0x897C10", VA = "0x180898C10")]
	public CCTV()
	{
	}

	// Token: 0x04001CCA RID: 7370
	[Token(Token = "0x4001CCA")]
	[FieldOffset(Offset = "0x258")]
	public Transform cameraTransform;
}
