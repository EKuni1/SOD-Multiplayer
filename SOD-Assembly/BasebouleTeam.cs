using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000775 RID: 1909
[Token(Token = "0x2000775")]
public class BasebouleTeam : ScriptableObject
{
	// Token: 0x0600290F RID: 10511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600290F")]
	[Address(RVA = "0x5C7970", Offset = "0x5C6970", VA = "0x1805C7970")]
	public BasebouleTeam()
	{
	}

	// Token: 0x040036A4 RID: 13988
	[Token(Token = "0x40036A4")]
	[FieldOffset(Offset = "0x18")]
	public string teamName;

	// Token: 0x040036A5 RID: 13989
	[Token(Token = "0x40036A5")]
	[FieldOffset(Offset = "0x20")]
	public string teamIntroductionWhenFirstInLineUp;

	// Token: 0x040036A6 RID: 13990
	[Token(Token = "0x40036A6")]
	[FieldOffset(Offset = "0x28")]
	public string teamIntroductionWhenSecondInLineUp;

	// Token: 0x040036A7 RID: 13991
	[Token(Token = "0x40036A7")]
	[FieldOffset(Offset = "0x30")]
	public List<BaseboulePlayer> roster;
}
