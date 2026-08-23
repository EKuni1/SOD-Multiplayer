using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000771 RID: 1905
[Token(Token = "0x2000771")]
public class BaseboulePlayer : ScriptableObject
{
	// Token: 0x06002905 RID: 10501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002905")]
	[Address(RVA = "0x5C7970", Offset = "0x5C6970", VA = "0x1805C7970")]
	public BaseboulePlayer()
	{
	}

	// Token: 0x04003686 RID: 13958
	[Token(Token = "0x4003686")]
	[FieldOffset(Offset = "0x18")]
	public string firstName;

	// Token: 0x04003687 RID: 13959
	[Token(Token = "0x4003687")]
	[FieldOffset(Offset = "0x20")]
	public string surName;

	// Token: 0x04003688 RID: 13960
	[Token(Token = "0x4003688")]
	[FieldOffset(Offset = "0x28")]
	public int playerSkill;

	// Token: 0x04003689 RID: 13961
	[Token(Token = "0x4003689")]
	[FieldOffset(Offset = "0x30")]
	public string funFact;

	// Token: 0x02000772 RID: 1906
	[Token(Token = "0x2000772")]
	public enum Experience
	{
		// Token: 0x0400368B RID: 13963
		[Token(Token = "0x400368B")]
		Rookie,
		// Token: 0x0400368C RID: 13964
		[Token(Token = "0x400368C")]
		Experienced,
		// Token: 0x0400368D RID: 13965
		[Token(Token = "0x400368D")]
		Veteran,
		// Token: 0x0400368E RID: 13966
		[Token(Token = "0x400368E")]
		AllStar
	}

	// Token: 0x02000773 RID: 1907
	[Token(Token = "0x2000773")]
	public enum Position
	{
		// Token: 0x04003690 RID: 13968
		[Token(Token = "0x4003690")]
		Rouleur,
		// Token: 0x04003691 RID: 13969
		[Token(Token = "0x4003691")]
		Fielder,
		// Token: 0x04003692 RID: 13970
		[Token(Token = "0x4003692")]
		Tireur
	}
}
