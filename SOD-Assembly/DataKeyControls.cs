using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008B6 RID: 2230
[Token(Token = "0x20008B6")]
public class DataKeyControls : MonoBehaviour
{
	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06002A2E RID: 10798 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000150")]
	public static DataKeyControls Instance
	{
		[Token(Token = "0x6002A2E")]
		[Address(RVA = "0xCB9820", Offset = "0xCB8820", VA = "0x180CB9820")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002A2F RID: 10799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A2F")]
	[Address(RVA = "0xCB9860", Offset = "0xCB8860", VA = "0x180CB9860")]
	private void Awake()
	{
	}

	// Token: 0x06002A30 RID: 10800 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A30")]
	[Address(RVA = "0xCB9BB0", Offset = "0xCB8BB0", VA = "0x180CB9BB0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002A31 RID: 10801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A31")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public DataKeyControls()
	{
	}

	// Token: 0x04004660 RID: 18016
	[Token(Token = "0x4004660")]
	[FieldOffset(Offset = "0x0")]
	private static DataKeyControls _instance;

	// Token: 0x020008B7 RID: 2231
	[Token(Token = "0x20008B7")]
	[Serializable]
	public class DataKeySettings
	{
		// Token: 0x06002A32 RID: 10802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A32")]
		[Address(RVA = "0xCB9DC0", Offset = "0xCB8DC0", VA = "0x180CB9DC0")]
		public DataKeySettings()
		{
		}

		// Token: 0x04004661 RID: 18017
		[Token(Token = "0x4004661")]
		[FieldOffset(Offset = "0x10")]
		public Evidence.DataKey key;

		// Token: 0x04004662 RID: 18018
		[Token(Token = "0x4004662")]
		[FieldOffset(Offset = "0x14")]
		public bool uniqueKey;

		// Token: 0x04004663 RID: 18019
		[Token(Token = "0x4004663")]
		[FieldOffset(Offset = "0x15")]
		public bool countTowardsProfile;
	}
}
