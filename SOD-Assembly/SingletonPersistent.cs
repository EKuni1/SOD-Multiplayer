using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008DC RID: 2268
[Token(Token = "0x20008DC")]
public class SingletonPersistent<T> : MonoBehaviour where T : Component
{
	// Token: 0x1700015B RID: 347
	// (get) Token: 0x06002ADD RID: 10973 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06002ADE RID: 10974 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015B")]
	public static T Instance
	{
		[Token(Token = "0x6002ADD")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002ADE")]
		private set
		{
		}
	}

	// Token: 0x06002ADF RID: 10975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002ADF")]
	public virtual void Awake()
	{
	}

	// Token: 0x06002AE0 RID: 10976 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002AE0")]
	public SingletonPersistent()
	{
	}

	// Token: 0x04004B1C RID: 19228
	[Token(Token = "0x4004B1C")]
	[FieldOffset(Offset = "0x0")]
	private static T <Instance>k__BackingField;
}
