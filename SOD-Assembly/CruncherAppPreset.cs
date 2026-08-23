using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007B7 RID: 1975
[Token(Token = "0x20007B7")]
public class CruncherAppPreset : SoCustomComparison
{
	// Token: 0x0600294A RID: 10570 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600294A")]
	[Address(RVA = "0xCA2CB0", Offset = "0xCA1CB0", VA = "0x180CA2CB0")]
	public CruncherAppPreset()
	{
	}

	// Token: 0x040038CF RID: 14543
	[Token(Token = "0x40038CF")]
	[FieldOffset(Offset = "0x20")]
	public Material loadBackground;

	// Token: 0x040038D0 RID: 14544
	[Token(Token = "0x40038D0")]
	[FieldOffset(Offset = "0x28")]
	public Material loadedBackground;

	// Token: 0x040038D1 RID: 14545
	[Token(Token = "0x40038D1")]
	[FieldOffset(Offset = "0x30")]
	public bool useCursor;

	// Token: 0x040038D2 RID: 14546
	[Token(Token = "0x40038D2")]
	[FieldOffset(Offset = "0x38")]
	public Sprite cursorSprite;

	// Token: 0x040038D3 RID: 14547
	[Token(Token = "0x40038D3")]
	[FieldOffset(Offset = "0x40")]
	public bool useTimer;

	// Token: 0x040038D4 RID: 14548
	[Token(Token = "0x40038D4")]
	[FieldOffset(Offset = "0x44")]
	public float timerLength;

	// Token: 0x040038D5 RID: 14549
	[Token(Token = "0x40038D5")]
	[FieldOffset(Offset = "0x48")]
	public float loadTime;

	// Token: 0x040038D6 RID: 14550
	[Token(Token = "0x40038D6")]
	[FieldOffset(Offset = "0x4C")]
	public float loadDemand;

	// Token: 0x040038D7 RID: 14551
	[Token(Token = "0x40038D7")]
	[FieldOffset(Offset = "0x50")]
	public bool alwaysLoad;

	// Token: 0x040038D8 RID: 14552
	[Token(Token = "0x40038D8")]
	[FieldOffset(Offset = "0x54")]
	public float alwaysLoadDemand;

	// Token: 0x040038D9 RID: 14553
	[Token(Token = "0x40038D9")]
	[FieldOffset(Offset = "0x58")]
	public Sprite desktopIcon;

	// Token: 0x040038DA RID: 14554
	[Token(Token = "0x40038DA")]
	[FieldOffset(Offset = "0x60")]
	public Color screenLightColourOnLoad;

	// Token: 0x040038DB RID: 14555
	[Token(Token = "0x40038DB")]
	[FieldOffset(Offset = "0x70")]
	public Color screenLightColourOnFinishLoad;

	// Token: 0x040038DC RID: 14556
	[Token(Token = "0x40038DC")]
	[FieldOffset(Offset = "0x80")]
	public bool alwaysInstalled;

	// Token: 0x040038DD RID: 14557
	[Token(Token = "0x40038DD")]
	[FieldOffset(Offset = "0x81")]
	public bool onlyIfCorporateSabotageSkill;

	// Token: 0x040038DE RID: 14558
	[Token(Token = "0x40038DE")]
	[FieldOffset(Offset = "0x82")]
	public bool companyOnly;

	// Token: 0x040038DF RID: 14559
	[Token(Token = "0x40038DF")]
	[FieldOffset(Offset = "0x83")]
	public bool salesRecordsOnly;

	// Token: 0x040038E0 RID: 14560
	[Token(Token = "0x40038E0")]
	[FieldOffset(Offset = "0x84")]
	public bool onlyIfOwner;

	// Token: 0x040038E1 RID: 14561
	[Token(Token = "0x40038E1")]
	[FieldOffset(Offset = "0x88")]
	public List<CruncherAppPreset.AppAccess> installationConditions;

	// Token: 0x040038E2 RID: 14562
	[Token(Token = "0x40038E2")]
	[FieldOffset(Offset = "0x90")]
	public List<AddressPreset> onlyInAddresses;

	// Token: 0x040038E3 RID: 14563
	[Token(Token = "0x40038E3")]
	[FieldOffset(Offset = "0x98")]
	public bool onlyIfResidential;

	// Token: 0x040038E4 RID: 14564
	[Token(Token = "0x40038E4")]
	[FieldOffset(Offset = "0xA0")]
	public List<GameObject> appContent;

	// Token: 0x040038E5 RID: 14565
	[Token(Token = "0x40038E5")]
	[FieldOffset(Offset = "0xA8")]
	public AudioEvent onStartSound;

	// Token: 0x040038E6 RID: 14566
	[Token(Token = "0x40038E6")]
	[FieldOffset(Offset = "0xB0")]
	public AudioEvent onExitSound;

	// Token: 0x040038E7 RID: 14567
	[Token(Token = "0x40038E7")]
	[FieldOffset(Offset = "0xB8")]
	public AudioEvent onFinishedLoadingSound;

	// Token: 0x040038E8 RID: 14568
	[Token(Token = "0x40038E8")]
	[FieldOffset(Offset = "0xC0")]
	public CruncherAppPreset openOnEnd;

	// Token: 0x020007B8 RID: 1976
	[Token(Token = "0x20007B8")]
	[Serializable]
	public class AppAccess
	{
		// Token: 0x0600294B RID: 10571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600294B")]
		[Address(RVA = "0xCA2F10", Offset = "0xCA1F10", VA = "0x180CA2F10")]
		public AppAccess()
		{
		}

		// Token: 0x040038E9 RID: 14569
		[Token(Token = "0x40038E9")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait.RuleType rule;

		// Token: 0x040038EA RID: 14570
		[Token(Token = "0x40038EA")]
		[FieldOffset(Offset = "0x18")]
		public List<CharacterTrait> traitList;
	}
}
