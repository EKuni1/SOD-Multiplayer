using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200048B RID: 1163
[Token(Token = "0x200048B")]
public class RainBlocker : MonoBehaviour
{
	// Token: 0x06001A81 RID: 6785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A81")]
	[Address(RVA = "0x986210", Offset = "0x985210", VA = "0x180986210")]
	private void OnEnable()
	{
	}

	// Token: 0x06001A82 RID: 6786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A82")]
	[Address(RVA = "0x986540", Offset = "0x985540", VA = "0x180986540")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001A83 RID: 6787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A83")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public RainBlocker()
	{
	}

	// Token: 0x04002034 RID: 8244
	[Token(Token = "0x4002034")]
	[FieldOffset(Offset = "0x18")]
	public Collider rainCollider;
}
