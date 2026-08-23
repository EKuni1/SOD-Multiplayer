using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004BE RID: 1214
[Token(Token = "0x20004BE")]
public class PlayerModelController : MonoBehaviour
{
	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x06001B43 RID: 6979 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000D3")]
	public static PlayerModelController Instance
	{
		[Token(Token = "0x6001B43")]
		[Address(RVA = "0x9B18C0", Offset = "0x9B08C0", VA = "0x1809B18C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001B44 RID: 6980 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B44")]
	[Address(RVA = "0x9B1900", Offset = "0x9B0900", VA = "0x1809B1900")]
	private void Awake()
	{
	}

	// Token: 0x06001B45 RID: 6981 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B45")]
	[Address(RVA = "0x9B1C50", Offset = "0x9B0C50", VA = "0x1809B1C50")]
	public void DisableMeshRenderers()
	{
	}

	// Token: 0x06001B46 RID: 6982 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B46")]
	[Address(RVA = "0x9B1D50", Offset = "0x9B0D50", VA = "0x1809B1D50")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001B47 RID: 6983 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B47")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public PlayerModelController()
	{
	}

	// Token: 0x04002159 RID: 8537
	[Token(Token = "0x4002159")]
	[FieldOffset(Offset = "0x0")]
	private static PlayerModelController _instance;

	// Token: 0x0400215A RID: 8538
	[Token(Token = "0x400215A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject playerCitizenPrefab;

	// Token: 0x0400215B RID: 8539
	[Token(Token = "0x400215B")]
	[FieldOffset(Offset = "0x20")]
	public Transform citizenModelsTransform;

	// Token: 0x0400215C RID: 8540
	[Token(Token = "0x400215C")]
	[FieldOffset(Offset = "0x28")]
	public Citizen playerCitizen;
}
