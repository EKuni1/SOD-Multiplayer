using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007CD RID: 1997
[Token(Token = "0x20007CD")]
public class DoorPreset : SoCustomComparison
{
	// Token: 0x0600295C RID: 10588 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600295C")]
	[Address(RVA = "0xCA48D0", Offset = "0xCA38D0", VA = "0x180CA48D0")]
	public DoorPreset()
	{
	}

	// Token: 0x040039C4 RID: 14788
	[Token(Token = "0x40039C4")]
	[FieldOffset(Offset = "0x20")]
	public GameObject doorModel;

	// Token: 0x040039C5 RID: 14789
	[Token(Token = "0x40039C5")]
	[FieldOffset(Offset = "0x28")]
	public InteractablePreset objectPreset;

	// Token: 0x040039C6 RID: 14790
	[Token(Token = "0x40039C6")]
	[FieldOffset(Offset = "0x30")]
	public GameObject handleModel;

	// Token: 0x040039C7 RID: 14791
	[Token(Token = "0x40039C7")]
	[FieldOffset(Offset = "0x38")]
	public InteractablePreset handlePreset;

	// Token: 0x040039C8 RID: 14792
	[Token(Token = "0x40039C8")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 handleOffset;

	// Token: 0x040039C9 RID: 14793
	[Token(Token = "0x40039C9")]
	[FieldOffset(Offset = "0x4C")]
	public bool isTransparent;

	// Token: 0x040039CA RID: 14794
	[Token(Token = "0x40039CA")]
	[FieldOffset(Offset = "0x50")]
	public Material nonRainGlassMaterial;

	// Token: 0x040039CB RID: 14795
	[Token(Token = "0x40039CB")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 doorSignOffset;

	// Token: 0x040039CC RID: 14796
	[Token(Token = "0x40039CC")]
	[FieldOffset(Offset = "0x68")]
	public List<DoorPreset.DoorSign> doorSigns;

	// Token: 0x040039CD RID: 14797
	[Token(Token = "0x40039CD")]
	[FieldOffset(Offset = "0x70")]
	public bool inheritColouringFromDecor;

	// Token: 0x040039CE RID: 14798
	[Token(Token = "0x40039CE")]
	[FieldOffset(Offset = "0x74")]
	public FurniturePreset.ShareColours shareColours;

	// Token: 0x040039CF RID: 14799
	[Token(Token = "0x40039CF")]
	[FieldOffset(Offset = "0x78")]
	public List<MaterialGroupPreset.MaterialVariation> variations;

	// Token: 0x040039D0 RID: 14800
	[Token(Token = "0x40039D0")]
	[FieldOffset(Offset = "0x80")]
	public float doorOpenSpeed;

	// Token: 0x040039D1 RID: 14801
	[Token(Token = "0x40039D1")]
	[FieldOffset(Offset = "0x84")]
	public float openAngle;

	// Token: 0x040039D2 RID: 14802
	[Token(Token = "0x40039D2")]
	[FieldOffset(Offset = "0x88")]
	public bool canPeakUnderneath;

	// Token: 0x040039D3 RID: 14803
	[Token(Token = "0x40039D3")]
	[FieldOffset(Offset = "0x8C")]
	public DoorPreset.ClosingBehaviour closeBehaviour;

	// Token: 0x040039D4 RID: 14804
	[Token(Token = "0x40039D4")]
	[FieldOffset(Offset = "0x90")]
	public DoorPreset.LockType lockType;

	// Token: 0x040039D5 RID: 14805
	[Token(Token = "0x40039D5")]
	[FieldOffset(Offset = "0x98")]
	public InteractablePreset lockInteractable;

	// Token: 0x040039D6 RID: 14806
	[Token(Token = "0x40039D6")]
	[FieldOffset(Offset = "0xA0")]
	public Vector3 lockOffsetFront;

	// Token: 0x040039D7 RID: 14807
	[Token(Token = "0x40039D7")]
	[FieldOffset(Offset = "0xAC")]
	public Vector3 lockOffsetRear;

	// Token: 0x040039D8 RID: 14808
	[Token(Token = "0x40039D8")]
	[FieldOffset(Offset = "0xB8")]
	public bool armLockOnClose;

	// Token: 0x040039D9 RID: 14809
	[Token(Token = "0x40039D9")]
	[FieldOffset(Offset = "0xBC")]
	public Vector2 doorStrengthRange;

	// Token: 0x040039DA RID: 14810
	[Token(Token = "0x40039DA")]
	[FieldOffset(Offset = "0xC4")]
	public Vector2 lockStrengthRange;

	// Token: 0x040039DB RID: 14811
	[Token(Token = "0x40039DB")]
	[FieldOffset(Offset = "0xD0")]
	public AudioEvent audioOpen;

	// Token: 0x040039DC RID: 14812
	[Token(Token = "0x40039DC")]
	[FieldOffset(Offset = "0xD8")]
	public AudioEvent audioClose;

	// Token: 0x040039DD RID: 14813
	[Token(Token = "0x40039DD")]
	[FieldOffset(Offset = "0xE0")]
	public AudioEvent audioCloseAction;

	// Token: 0x040039DE RID: 14814
	[Token(Token = "0x40039DE")]
	[FieldOffset(Offset = "0xE8")]
	public AudioEvent audioLock;

	// Token: 0x040039DF RID: 14815
	[Token(Token = "0x40039DF")]
	[FieldOffset(Offset = "0xF0")]
	public AudioEvent audioUnlock;

	// Token: 0x040039E0 RID: 14816
	[Token(Token = "0x40039E0")]
	[FieldOffset(Offset = "0xF8")]
	public AudioEvent audioLockedEntryAttempt;

	// Token: 0x040039E1 RID: 14817
	[Token(Token = "0x40039E1")]
	[FieldOffset(Offset = "0x100")]
	public AudioEvent audioKnockLight;

	// Token: 0x040039E2 RID: 14818
	[Token(Token = "0x40039E2")]
	[FieldOffset(Offset = "0x108")]
	public AudioEvent audioKnockMed;

	// Token: 0x040039E3 RID: 14819
	[Token(Token = "0x40039E3")]
	[FieldOffset(Offset = "0x110")]
	public AudioEvent audioKnockHeavy;

	// Token: 0x040039E4 RID: 14820
	[Token(Token = "0x40039E4")]
	[FieldOffset(Offset = "0x118")]
	public AudioEvent doorBargeContact;

	// Token: 0x040039E5 RID: 14821
	[Token(Token = "0x40039E5")]
	[FieldOffset(Offset = "0x120")]
	public AudioEvent doorBargeBreak;

	// Token: 0x020007CE RID: 1998
	[Token(Token = "0x20007CE")]
	public enum LockType
	{
		// Token: 0x040039E7 RID: 14823
		[Token(Token = "0x40039E7")]
		none,
		// Token: 0x040039E8 RID: 14824
		[Token(Token = "0x40039E8")]
		key,
		// Token: 0x040039E9 RID: 14825
		[Token(Token = "0x40039E9")]
		keypad
	}

	// Token: 0x020007CF RID: 1999
	[Token(Token = "0x20007CF")]
	[Serializable]
	public class DoorSign
	{
		// Token: 0x0600295D RID: 10589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600295D")]
		[Address(RVA = "0xCA4B30", Offset = "0xCA3B30", VA = "0x180CA4B30")]
		public DoorSign()
		{
		}

		// Token: 0x040039EA RID: 14826
		[Token(Token = "0x40039EA")]
		[FieldOffset(Offset = "0x10")]
		public List<GameObject> signagePool;

		// Token: 0x040039EB RID: 14827
		[Token(Token = "0x40039EB")]
		[FieldOffset(Offset = "0x18")]
		public List<RoomConfiguration> ifEntranceToRoom;

		// Token: 0x040039EC RID: 14828
		[Token(Token = "0x40039EC")]
		[FieldOffset(Offset = "0x20")]
		public bool placeIfFromPublicArea;

		// Token: 0x040039ED RID: 14829
		[Token(Token = "0x40039ED")]
		[FieldOffset(Offset = "0x21")]
		public bool placeIfFromOutside;

		// Token: 0x040039EE RID: 14830
		[Token(Token = "0x40039EE")]
		[FieldOffset(Offset = "0x22")]
		public bool placeIfFromInside;

		// Token: 0x040039EF RID: 14831
		[Token(Token = "0x40039EF")]
		[FieldOffset(Offset = "0x23")]
		public bool onlyPlaceIfInhabited;
	}

	// Token: 0x020007D0 RID: 2000
	[Token(Token = "0x20007D0")]
	public enum ClosingBehaviour
	{
		// Token: 0x040039F1 RID: 14833
		[Token(Token = "0x40039F1")]
		nothing,
		// Token: 0x040039F2 RID: 14834
		[Token(Token = "0x40039F2")]
		closeOnCull,
		// Token: 0x040039F3 RID: 14835
		[Token(Token = "0x40039F3")]
		closeOnDespawn
	}
}
