using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000859 RID: 2137
[Token(Token = "0x2000859")]
public class MusicCue : SoCustomComparison
{
	// Token: 0x060029CE RID: 10702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029CE")]
	[Address(RVA = "0xCAF7F0", Offset = "0xCAE7F0", VA = "0x180CAF7F0")]
	public MusicCue()
	{
	}

	// Token: 0x040040AA RID: 16554
	[Token(Token = "0x40040AA")]
	[FieldOffset(Offset = "0x20")]
	public string fmodGUID;

	// Token: 0x040040AB RID: 16555
	[Token(Token = "0x40040AB")]
	[FieldOffset(Offset = "0x28")]
	public bool disabled;

	// Token: 0x040040AC RID: 16556
	[Token(Token = "0x40040AC")]
	[FieldOffset(Offset = "0x29")]
	public bool debug;

	// Token: 0x040040AD RID: 16557
	[Token(Token = "0x40040AD")]
	[FieldOffset(Offset = "0x2A")]
	public bool playOnce;

	// Token: 0x040040AE RID: 16558
	[Token(Token = "0x40040AE")]
	[FieldOffset(Offset = "0x2B")]
	public bool interrupt;

	// Token: 0x040040AF RID: 16559
	[Token(Token = "0x40040AF")]
	[FieldOffset(Offset = "0x2C")]
	public bool stopOnIncompatibleStateSwitch;

	// Token: 0x040040B0 RID: 16560
	[Token(Token = "0x40040B0")]
	[FieldOffset(Offset = "0x2D")]
	public bool avoidRepetition;

	// Token: 0x040040B1 RID: 16561
	[Token(Token = "0x40040B1")]
	[FieldOffset(Offset = "0x30")]
	public int ambientPriority;

	// Token: 0x040040B2 RID: 16562
	[Token(Token = "0x40040B2")]
	[FieldOffset(Offset = "0x38")]
	public List<MusicCue.MusicTrigger> triggers;

	// Token: 0x0200085A RID: 2138
	[Token(Token = "0x200085A")]
	public enum MusicTriggerGameState
	{
		// Token: 0x040040B4 RID: 16564
		[Token(Token = "0x40040B4")]
		any,
		// Token: 0x040040B5 RID: 16565
		[Token(Token = "0x40040B5")]
		menu,
		// Token: 0x040040B6 RID: 16566
		[Token(Token = "0x40040B6")]
		inGame,
		// Token: 0x040040B7 RID: 16567
		[Token(Token = "0x40040B7")]
		inCutscene
	}

	// Token: 0x0200085B RID: 2139
	[Token(Token = "0x200085B")]
	public enum MusicTriggerPlayerState
	{
		// Token: 0x040040B9 RID: 16569
		[Token(Token = "0x40040B9")]
		any,
		// Token: 0x040040BA RID: 16570
		[Token(Token = "0x40040BA")]
		safe,
		// Token: 0x040040BB RID: 16571
		[Token(Token = "0x40040BB")]
		trespass,
		// Token: 0x040040BC RID: 16572
		[Token(Token = "0x40040BC")]
		combat,
		// Token: 0x040040BD RID: 16573
		[Token(Token = "0x40040BD")]
		passingTime
	}

	// Token: 0x0200085C RID: 2140
	[Token(Token = "0x200085C")]
	public enum MusicTriggerPlayerLocation
	{
		// Token: 0x040040BF RID: 16575
		[Token(Token = "0x40040BF")]
		any,
		// Token: 0x040040C0 RID: 16576
		[Token(Token = "0x40040C0")]
		outdoors,
		// Token: 0x040040C1 RID: 16577
		[Token(Token = "0x40040C1")]
		indoors,
		// Token: 0x040040C2 RID: 16578
		[Token(Token = "0x40040C2")]
		playersApartment
	}

	// Token: 0x0200085D RID: 2141
	[Token(Token = "0x200085D")]
	public enum MusicTriggerEvent
	{
		// Token: 0x040040C4 RID: 16580
		[Token(Token = "0x40040C4")]
		none,
		// Token: 0x040040C5 RID: 16581
		[Token(Token = "0x40040C5")]
		newMurderCase,
		// Token: 0x040040C6 RID: 16582
		[Token(Token = "0x40040C6")]
		caseComplete,
		// Token: 0x040040C7 RID: 16583
		[Token(Token = "0x40040C7")]
		caseFailed,
		// Token: 0x040040C8 RID: 16584
		[Token(Token = "0x40040C8")]
		caseUnsolved,
		// Token: 0x040040C9 RID: 16585
		[Token(Token = "0x40040C9")]
		socialCreditLevelUp,
		// Token: 0x040040CA RID: 16586
		[Token(Token = "0x40040CA")]
		resolveScreen,
		// Token: 0x040040CB RID: 16587
		[Token(Token = "0x40040CB")]
		arriveAtCrimeScene,
		// Token: 0x040040CC RID: 16588
		[Token(Token = "0x40040CC")]
		passingTime
	}

	// Token: 0x0200085E RID: 2142
	[Token(Token = "0x200085E")]
	[Serializable]
	public class MusicTrigger
	{
		// Token: 0x060029CF RID: 10703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029CF")]
		[Address(RVA = "0xCAF8D0", Offset = "0xCAE8D0", VA = "0x180CAF8D0")]
		public MusicTrigger()
		{
		}

		// Token: 0x040040CD RID: 16589
		[Token(Token = "0x40040CD")]
		[FieldOffset(Offset = "0x10")]
		public MusicCue.MusicTriggerGameState onGameState;

		// Token: 0x040040CE RID: 16590
		[Token(Token = "0x40040CE")]
		[FieldOffset(Offset = "0x18")]
		public CutScenePreset cutSceneReference;

		// Token: 0x040040CF RID: 16591
		[Token(Token = "0x40040CF")]
		[FieldOffset(Offset = "0x20")]
		public MusicCue.MusicTriggerPlayerState onPlayerSate;

		// Token: 0x040040D0 RID: 16592
		[Token(Token = "0x40040D0")]
		[FieldOffset(Offset = "0x24")]
		public MusicCue.MusicTriggerPlayerLocation onPlayerLocation;

		// Token: 0x040040D1 RID: 16593
		[Token(Token = "0x40040D1")]
		[FieldOffset(Offset = "0x28")]
		public MusicCue.MusicTriggerEvent onEvent;

		// Token: 0x040040D2 RID: 16594
		[Token(Token = "0x40040D2")]
		[FieldOffset(Offset = "0x2C")]
		public float eventTriggerChance;

		// Token: 0x040040D3 RID: 16595
		[Token(Token = "0x40040D3")]
		[FieldOffset(Offset = "0x30")]
		public bool triggerOnlyOnEvents;

		// Token: 0x040040D4 RID: 16596
		[Token(Token = "0x40040D4")]
		[FieldOffset(Offset = "0x31")]
		public bool ignoreSilentTimeBetweenTracks;

		// Token: 0x040040D5 RID: 16597
		[Token(Token = "0x40040D5")]
		[FieldOffset(Offset = "0x32")]
		public bool onlyInDistricts;

		// Token: 0x040040D6 RID: 16598
		[Token(Token = "0x40040D6")]
		[FieldOffset(Offset = "0x38")]
		public List<DistrictPreset> compatibleDistricts;

		// Token: 0x040040D7 RID: 16599
		[Token(Token = "0x40040D7")]
		[FieldOffset(Offset = "0x40")]
		public bool excludeDistricts;

		// Token: 0x040040D8 RID: 16600
		[Token(Token = "0x40040D8")]
		[FieldOffset(Offset = "0x48")]
		public List<DistrictPreset> excludedDistricts;

		// Token: 0x040040D9 RID: 16601
		[Token(Token = "0x40040D9")]
		[FieldOffset(Offset = "0x50")]
		public bool onlyInBuildings;

		// Token: 0x040040DA RID: 16602
		[Token(Token = "0x40040DA")]
		[FieldOffset(Offset = "0x58")]
		public List<BuildingPreset> compatibleBuildings;

		// Token: 0x040040DB RID: 16603
		[Token(Token = "0x40040DB")]
		[FieldOffset(Offset = "0x60")]
		public bool excludeBuildings;

		// Token: 0x040040DC RID: 16604
		[Token(Token = "0x40040DC")]
		[FieldOffset(Offset = "0x68")]
		public List<BuildingPreset> excludedBuildings;

		// Token: 0x040040DD RID: 16605
		[Token(Token = "0x40040DD")]
		[FieldOffset(Offset = "0x70")]
		public bool onlyInLocations;

		// Token: 0x040040DE RID: 16606
		[Token(Token = "0x40040DE")]
		[FieldOffset(Offset = "0x78")]
		public List<AddressPreset> compatibleAddressTypes;

		// Token: 0x040040DF RID: 16607
		[Token(Token = "0x40040DF")]
		[FieldOffset(Offset = "0x80")]
		public bool excludeLocations;

		// Token: 0x040040E0 RID: 16608
		[Token(Token = "0x40040E0")]
		[FieldOffset(Offset = "0x88")]
		public List<AddressPreset> excludedAddressTypes;

		// Token: 0x040040E1 RID: 16609
		[Token(Token = "0x40040E1")]
		[FieldOffset(Offset = "0x90")]
		public bool onlyDuringStatuses;

		// Token: 0x040040E2 RID: 16610
		[Token(Token = "0x40040E2")]
		[FieldOffset(Offset = "0x98")]
		public List<StatusPreset> compatibleStatuses;

		// Token: 0x040040E3 RID: 16611
		[Token(Token = "0x40040E3")]
		[FieldOffset(Offset = "0xA0")]
		public bool excludeStatuses;

		// Token: 0x040040E4 RID: 16612
		[Token(Token = "0x40040E4")]
		[FieldOffset(Offset = "0xA8")]
		public List<StatusPreset> excludedStatuses;

		// Token: 0x040040E5 RID: 16613
		[Token(Token = "0x40040E5")]
		[FieldOffset(Offset = "0xB0")]
		public bool useDecorGrimeRange;

		// Token: 0x040040E6 RID: 16614
		[Token(Token = "0x40040E6")]
		[FieldOffset(Offset = "0xB4")]
		public Vector2 grimeRange;

		// Token: 0x040040E7 RID: 16615
		[Token(Token = "0x40040E7")]
		[FieldOffset(Offset = "0xC0")]
		public List<Vector2> floorRanges;

		// Token: 0x040040E8 RID: 16616
		[Token(Token = "0x40040E8")]
		[FieldOffset(Offset = "0xC8")]
		public List<Vector2> timeRanges;
	}
}
