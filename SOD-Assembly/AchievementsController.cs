using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200040D RID: 1037
[Token(Token = "0x200040D")]
public class AchievementsController : MonoBehaviour
{
	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x0600177E RID: 6014 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000C0")]
	public static AchievementsController Instance
	{
		[Token(Token = "0x600177E")]
		[Address(RVA = "0x894D70", Offset = "0x893D70", VA = "0x180894D70")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600177F")]
	[Address(RVA = "0x894DB0", Offset = "0x893DB0", VA = "0x180894DB0")]
	private void Awake()
	{
	}

	// Token: 0x06001780 RID: 6016 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001780")]
	[Address(RVA = "0x895100", Offset = "0x894100", VA = "0x180895100")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001781 RID: 6017 RVA: 0x0000ADE8 File Offset: 0x00008FE8
	[Token(Token = "0x6001781")]
	[Address(RVA = "0x895310", Offset = "0x894310", VA = "0x180895310")]
	public bool GetAchievementStatus(string id)
	{
		return default(bool);
	}

	// Token: 0x06001782 RID: 6018 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001782")]
	[Address(RVA = "0x8953C0", Offset = "0x8943C0", VA = "0x1808953C0")]
	public void UnlockAchievement(string nameReference, string id)
	{
	}

	// Token: 0x06001783 RID: 6019 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001783")]
	[Address(RVA = "0x895600", Offset = "0x894600", VA = "0x180895600")]
	public void AddToStat(string nameReference, string id, int add)
	{
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001784")]
	[Address(RVA = "0x896010", Offset = "0x895010", VA = "0x180896010")]
	public void ClearAchievement(string id)
	{
	}

	// Token: 0x06001785 RID: 6021 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001785")]
	[Address(RVA = "0x896100", Offset = "0x895100", VA = "0x180896100")]
	public void LoadTrackingDataFromSave(ref StateSaveData data)
	{
	}

	// Token: 0x06001786 RID: 6022 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001786")]
	[Address(RVA = "0x896250", Offset = "0x895250", VA = "0x180896250")]
	public void TestKOEverybody()
	{
	}

	// Token: 0x06001787 RID: 6023 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001787")]
	[Address(RVA = "0x8965B0", Offset = "0x8955B0", VA = "0x1808965B0")]
	public AchievementsController()
	{
	}

	// Token: 0x04001CA7 RID: 7335
	[Token(Token = "0x4001CA7")]
	[FieldOffset(Offset = "0x18")]
	public bool freeHealthCareFlag;

	// Token: 0x04001CA8 RID: 7336
	[Token(Token = "0x4001CA8")]
	[FieldOffset(Offset = "0x1C")]
	public int notTheAnswerFlag;

	// Token: 0x04001CA9 RID: 7337
	[Token(Token = "0x4001CA9")]
	[FieldOffset(Offset = "0x20")]
	public int privateSlyFlag;

	// Token: 0x04001CAA RID: 7338
	[Token(Token = "0x4001CAA")]
	[FieldOffset(Offset = "0x28")]
	public List<string> allConnectedReference;

	// Token: 0x04001CAB RID: 7339
	[Token(Token = "0x4001CAB")]
	[FieldOffset(Offset = "0x30")]
	public bool pacifistFlag;

	// Token: 0x04001CAC RID: 7340
	[Token(Token = "0x4001CAC")]
	[FieldOffset(Offset = "0x31")]
	public bool notAScratchFlag;

	// Token: 0x04001CAD RID: 7341
	[Token(Token = "0x4001CAD")]
	[FieldOffset(Offset = "0x38")]
	public List<int> spareNoOneReference;

	// Token: 0x04001CAE RID: 7342
	[Token(Token = "0x4001CAE")]
	[FieldOffset(Offset = "0x0")]
	private static AchievementsController _instance;
}
