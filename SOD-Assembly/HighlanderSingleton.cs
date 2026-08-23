using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008DB RID: 2267
[Token(Token = "0x20008DB")]
public abstract class HighlanderSingleton<T> : MonoBehaviour where T : Component
{
	// Token: 0x1700015A RID: 346
	// (get) Token: 0x06002AD8 RID: 10968 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700015A")]
	public static T Instance
	{
		[Token(Token = "0x6002AD8")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002AD9 RID: 10969 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002AD9")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06002ADA RID: 10970 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002ADA")]
	public void DestroySelf()
	{
	}

	// Token: 0x06002ADB RID: 10971 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002ADB")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002ADC RID: 10972 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002ADC")]
	protected HighlanderSingleton()
	{
	}

	// Token: 0x04004B1B RID: 19227
	[Token(Token = "0x4004B1B")]
	[FieldOffset(Offset = "0x0")]
	private static T instance;
}
