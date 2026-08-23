using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000874 RID: 2164
[Token(Token = "0x2000874")]
public class RevengeObjective : SoCustomComparison
{
	// Token: 0x060029DB RID: 10715 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
	[Token(Token = "0x60029DB")]
	[Address(RVA = "0xCB0EB0", Offset = "0xCAFEB0", VA = "0x180CB0EB0")]
	public float Vandalism(int target, int location, float amount)
	{
		return 0f;
	}

	// Token: 0x060029DC RID: 10716 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
	[Token(Token = "0x60029DC")]
	[Address(RVA = "0xCB1090", Offset = "0xCB0090", VA = "0x180CB1090")]
	public float VandalismTrash(int target, int location, float amount)
	{
		return 0f;
	}

	// Token: 0x060029DD RID: 10717 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
	[Token(Token = "0x60029DD")]
	[Address(RVA = "0xCB1270", Offset = "0xCB0270", VA = "0x180CB1270")]
	public float VandalismWindow(int target, int location, float amount)
	{
		return 0f;
	}

	// Token: 0x060029DE RID: 10718 RVA: 0x0000FA08 File Offset: 0x0000DC08
	[Token(Token = "0x60029DE")]
	[Address(RVA = "0xCB1450", Offset = "0xCB0450", VA = "0x180CB1450")]
	public bool Handcuff(int target, int location, float amount)
	{
		return default(bool);
	}

	// Token: 0x060029DF RID: 10719 RVA: 0x0000FA20 File Offset: 0x0000DC20
	[Token(Token = "0x60029DF")]
	[Address(RVA = "0xCB1610", Offset = "0xCB0610", VA = "0x180CB1610")]
	public bool BeatUp(int target, int location, float amount)
	{
		return default(bool);
	}

	// Token: 0x060029E0 RID: 10720 RVA: 0x0000FA38 File Offset: 0x0000DC38
	[Token(Token = "0x60029E0")]
	[Address(RVA = "0xCB17B0", Offset = "0xCB07B0", VA = "0x180CB17B0")]
	public bool KickDownDoor(int target, int location, float amount)
	{
		return default(bool);
	}

	// Token: 0x060029E1 RID: 10721 RVA: 0x0000FA50 File Offset: 0x0000DC50
	[Token(Token = "0x60029E1")]
	[Address(RVA = "0x418400", Offset = "0x417400", VA = "0x180418400")]
	public bool ManualTrigger(int target, int location, float amount)
	{
		return default(bool);
	}

	// Token: 0x060029E2 RID: 10722 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029E2")]
	[Address(RVA = "0xCB19F0", Offset = "0xCB09F0", VA = "0x180CB19F0")]
	public RevengeObjective()
	{
	}

	// Token: 0x040041F7 RID: 16887
	[Token(Token = "0x40041F7")]
	[FieldOffset(Offset = "0x20")]
	public bool disabled;

	// Token: 0x040041F8 RID: 16888
	[Token(Token = "0x40041F8")]
	[FieldOffset(Offset = "0x24")]
	public int baseChance;

	// Token: 0x040041F9 RID: 16889
	[Token(Token = "0x40041F9")]
	[FieldOffset(Offset = "0x28")]
	public bool useHEXACO;

	// Token: 0x040041FA RID: 16890
	[Token(Token = "0x40041FA")]
	[FieldOffset(Offset = "0x2C")]
	public int feminineMasculine;

	// Token: 0x040041FB RID: 16891
	[Token(Token = "0x40041FB")]
	[FieldOffset(Offset = "0x30")]
	public int humility;

	// Token: 0x040041FC RID: 16892
	[Token(Token = "0x40041FC")]
	[FieldOffset(Offset = "0x34")]
	public int emotionality;

	// Token: 0x040041FD RID: 16893
	[Token(Token = "0x40041FD")]
	[FieldOffset(Offset = "0x38")]
	public int extraversion;

	// Token: 0x040041FE RID: 16894
	[Token(Token = "0x40041FE")]
	[FieldOffset(Offset = "0x3C")]
	public int agreeableness;

	// Token: 0x040041FF RID: 16895
	[Token(Token = "0x40041FF")]
	[FieldOffset(Offset = "0x40")]
	public int conscientiousness;

	// Token: 0x04004200 RID: 16896
	[Token(Token = "0x4004200")]
	[FieldOffset(Offset = "0x44")]
	public int creativity;

	// Token: 0x04004201 RID: 16897
	[Token(Token = "0x4004201")]
	[FieldOffset(Offset = "0x48")]
	public bool useTraits;

	// Token: 0x04004202 RID: 16898
	[Token(Token = "0x4004202")]
	[FieldOffset(Offset = "0x50")]
	public List<ClothesPreset.TraitPickRule> characterTraitsPoster;

	// Token: 0x04004203 RID: 16899
	[Token(Token = "0x4004203")]
	[FieldOffset(Offset = "0x58")]
	public List<ClothesPreset.TraitPickRule> characterTraitsPurp;

	// Token: 0x04004204 RID: 16900
	[Token(Token = "0x4004204")]
	[FieldOffset(Offset = "0x60")]
	public List<RevengeObjective.SpecialConditions> specialConditions;

	// Token: 0x04004205 RID: 16901
	[Token(Token = "0x4004205")]
	[FieldOffset(Offset = "0x68")]
	public string d0Name;

	// Token: 0x04004206 RID: 16902
	[Token(Token = "0x4004206")]
	[FieldOffset(Offset = "0x70")]
	public string d1Name;

	// Token: 0x04004207 RID: 16903
	[Token(Token = "0x4004207")]
	[FieldOffset(Offset = "0x78")]
	public string idTargetName;

	// Token: 0x04004208 RID: 16904
	[Token(Token = "0x4004208")]
	[FieldOffset(Offset = "0x80")]
	public JobPreset.JobTag tag;

	// Token: 0x04004209 RID: 16905
	[Token(Token = "0x4004209")]
	[FieldOffset(Offset = "0x84")]
	public InterfaceControls.Icon icon;

	// Token: 0x0400420A RID: 16906
	[Token(Token = "0x400420A")]
	[FieldOffset(Offset = "0x88")]
	public Vector2 passedNumberRange;

	// Token: 0x0400420B RID: 16907
	[Token(Token = "0x400420B")]
	[FieldOffset(Offset = "0x90")]
	public Vector2 rewardMultiplier;

	// Token: 0x0400420C RID: 16908
	[Token(Token = "0x400420C")]
	[FieldOffset(Offset = "0x98")]
	public string resolveQuestionName;

	// Token: 0x0400420D RID: 16909
	[Token(Token = "0x400420D")]
	[FieldOffset(Offset = "0xA0")]
	public string resolveQuestionNameAlternate;

	// Token: 0x0400420E RID: 16910
	[Token(Token = "0x400420E")]
	[FieldOffset(Offset = "0xA8")]
	public string answerMethod;

	// Token: 0x02000875 RID: 2165
	[Token(Token = "0x2000875")]
	public enum SpecialConditions
	{
		// Token: 0x04004210 RID: 16912
		[Token(Token = "0x4004210")]
		mustHaveWindows,
		// Token: 0x04004211 RID: 16913
		[Token(Token = "0x4004211")]
		trackProgressFromAddressQuestion,
		// Token: 0x04004212 RID: 16914
		[Token(Token = "0x4004212")]
		trackProgressFromNameQuestion
	}

	// Token: 0x02000876 RID: 2166
	[Token(Token = "0x2000876")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060029E4 RID: 10724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029E4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x0000FA68 File Offset: 0x0000DC68
		[Token(Token = "0x60029E5")]
		[Address(RVA = "0xCB1DA0", Offset = "0xCB0DA0", VA = "0x180CB1DA0")]
		internal bool <KickDownDoor>b__30_0(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x04004213 RID: 16915
		[Token(Token = "0x4004213")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RevengeObjective.<>c <>9;

		// Token: 0x04004214 RID: 16916
		[Token(Token = "0x4004214")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<NewNode.NodeAccess> <>9__30_0;
	}
}
