using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007CB RID: 1995
[Token(Token = "0x20007CB")]
public class DoorPairPreset : ScriptableObjectIDSystem
{
	// Token: 0x0600295A RID: 10586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600295A")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void UpdateIDs()
	{
	}

	// Token: 0x0600295B RID: 10587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600295B")]
	[Address(RVA = "0xCA44E0", Offset = "0xCA34E0", VA = "0x180CA44E0")]
	public DoorPairPreset()
	{
	}

	// Token: 0x040039A2 RID: 14754
	[Token(Token = "0x40039A2")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> parentWallsLong;

	// Token: 0x040039A3 RID: 14755
	[Token(Token = "0x40039A3")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> childWallsLong;

	// Token: 0x040039A4 RID: 14756
	[Token(Token = "0x40039A4")]
	[FieldOffset(Offset = "0x30")]
	public List<GameObject> parentWallsShort;

	// Token: 0x040039A5 RID: 14757
	[Token(Token = "0x40039A5")]
	[FieldOffset(Offset = "0x38")]
	public List<GameObject> childWallsShort;

	// Token: 0x040039A6 RID: 14758
	[Token(Token = "0x40039A6")]
	[FieldOffset(Offset = "0x40")]
	public List<GameObject> corners;

	// Token: 0x040039A7 RID: 14759
	[Token(Token = "0x40039A7")]
	[FieldOffset(Offset = "0x48")]
	public List<GameObject> quoins;

	// Token: 0x040039A8 RID: 14760
	[Token(Token = "0x40039A8")]
	[FieldOffset(Offset = "0x50")]
	public bool optimizeSections;

	// Token: 0x040039A9 RID: 14761
	[Token(Token = "0x40039A9")]
	[FieldOffset(Offset = "0x51")]
	public bool appearInEditor;

	// Token: 0x040039AA RID: 14762
	[Token(Token = "0x40039AA")]
	[FieldOffset(Offset = "0x52")]
	public bool supportsWallProps;

	// Token: 0x040039AB RID: 14763
	[Token(Token = "0x40039AB")]
	[FieldOffset(Offset = "0x53")]
	public bool isFence;

	// Token: 0x040039AC RID: 14764
	[Token(Token = "0x40039AC")]
	[FieldOffset(Offset = "0x54")]
	public bool divider;

	// Token: 0x040039AD RID: 14765
	[Token(Token = "0x40039AD")]
	[FieldOffset(Offset = "0x55")]
	public bool dividerLeft;

	// Token: 0x040039AE RID: 14766
	[Token(Token = "0x40039AE")]
	[FieldOffset(Offset = "0x56")]
	public bool dividerRight;

	// Token: 0x040039AF RID: 14767
	[Token(Token = "0x40039AF")]
	[FieldOffset(Offset = "0x57")]
	public bool canFeatureDoor;

	// Token: 0x040039B0 RID: 14768
	[Token(Token = "0x40039B0")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 doorOffset;

	// Token: 0x040039B1 RID: 14769
	[Token(Token = "0x40039B1")]
	[FieldOffset(Offset = "0x64")]
	public DoorPairPreset.WallSectionClass sectionClass;

	// Token: 0x040039B2 RID: 14770
	[Token(Token = "0x40039B2")]
	[FieldOffset(Offset = "0x68")]
	public bool ignoreCullingRaycasts;

	// Token: 0x040039B3 RID: 14771
	[Token(Token = "0x40039B3")]
	[FieldOffset(Offset = "0x70")]
	public DoorPairPreset raisedFloorOverride;

	// Token: 0x040039B4 RID: 14772
	[Token(Token = "0x40039B4")]
	[FieldOffset(Offset = "0x78")]
	public MaterialGroupPreset materialOverride;

	// Token: 0x040039B5 RID: 14773
	[Token(Token = "0x40039B5")]
	[FieldOffset(Offset = "0x80")]
	public List<Texture2D> mapOverride;

	// Token: 0x040039B6 RID: 14774
	[Token(Token = "0x40039B6")]
	[FieldOffset(Offset = "0x88")]
	public bool overrideWallNormal;

	// Token: 0x040039B7 RID: 14775
	[Token(Token = "0x40039B7")]
	[FieldOffset(Offset = "0x90")]
	public DoorPairPreset wallNormalOverrride;

	// Token: 0x040039B8 RID: 14776
	[Token(Token = "0x40039B8")]
	[FieldOffset(Offset = "0x98")]
	public bool overrideDuctLower;

	// Token: 0x040039B9 RID: 14777
	[Token(Token = "0x40039B9")]
	[FieldOffset(Offset = "0xA0")]
	public DoorPairPreset ductLowerOverrride;

	// Token: 0x040039BA RID: 14778
	[Token(Token = "0x40039BA")]
	[FieldOffset(Offset = "0xA8")]
	public bool overrideDuctUpper;

	// Token: 0x040039BB RID: 14779
	[Token(Token = "0x40039BB")]
	[FieldOffset(Offset = "0xB0")]
	public DoorPairPreset ductUpperOverrride;

	// Token: 0x020007CC RID: 1996
	[Token(Token = "0x20007CC")]
	public enum WallSectionClass
	{
		// Token: 0x040039BD RID: 14781
		[Token(Token = "0x40039BD")]
		wall,
		// Token: 0x040039BE RID: 14782
		[Token(Token = "0x40039BE")]
		window,
		// Token: 0x040039BF RID: 14783
		[Token(Token = "0x40039BF")]
		windowLarge,
		// Token: 0x040039C0 RID: 14784
		[Token(Token = "0x40039C0")]
		entrance,
		// Token: 0x040039C1 RID: 14785
		[Token(Token = "0x40039C1")]
		ventUpper,
		// Token: 0x040039C2 RID: 14786
		[Token(Token = "0x40039C2")]
		ventLower,
		// Token: 0x040039C3 RID: 14787
		[Token(Token = "0x40039C3")]
		ventTop
	}
}
