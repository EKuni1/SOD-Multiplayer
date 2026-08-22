using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000885 RID: 2181
[Token(Token = "0x2000885")]
public class RoomLightingPreset : SoCustomComparison
{
	// Token: 0x060029EC RID: 10732 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029EC")]
	[Address(RVA = "0xCB2720", Offset = "0xCB1720", VA = "0x180CB2720")]
	public RoomLightingPreset()
	{
	}

	// Token: 0x040042C5 RID: 17093
	[Token(Token = "0x40042C5")]
	[FieldOffset(Offset = "0x20")]
	public bool disable;

	// Token: 0x040042C6 RID: 17094
	[Token(Token = "0x40042C6")]
	[FieldOffset(Offset = "0x28")]
	public List<InteractablePreset> lightObjects;

	// Token: 0x040042C7 RID: 17095
	[Token(Token = "0x40042C7")]
	[FieldOffset(Offset = "0x30")]
	public LightingPreset lightingPreset;

	// Token: 0x040042C8 RID: 17096
	[Token(Token = "0x40042C8")]
	[FieldOffset(Offset = "0x38")]
	public List<RoomConfiguration> roomCompatibility;

	// Token: 0x040042C9 RID: 17097
	[Token(Token = "0x40042C9")]
	[FieldOffset(Offset = "0x40")]
	public int minimumRoomSize;

	// Token: 0x040042CA RID: 17098
	[Token(Token = "0x40042CA")]
	[FieldOffset(Offset = "0x44")]
	public int maximumRoomSize;

	// Token: 0x040042CB RID: 17099
	[Token(Token = "0x40042CB")]
	[FieldOffset(Offset = "0x48")]
	public List<BuildingPreset> onlyAllowInBuildings;

	// Token: 0x040042CC RID: 17100
	[Token(Token = "0x40042CC")]
	[FieldOffset(Offset = "0x50")]
	public List<BuildingPreset> banFromBuildings;

	// Token: 0x040042CD RID: 17101
	[Token(Token = "0x40042CD")]
	[FieldOffset(Offset = "0x58")]
	public RoomLightingPreset.StairwellLightRule stairwellRule;

	// Token: 0x040042CE RID: 17102
	[Token(Token = "0x40042CE")]
	[FieldOffset(Offset = "0x60")]
	public List<DesignStylePreset> designStyleCompatibility;

	// Token: 0x040042CF RID: 17103
	[Token(Token = "0x40042CF")]
	[FieldOffset(Offset = "0x68")]
	public List<GameObject> ceilingFans;

	// Token: 0x040042D0 RID: 17104
	[Token(Token = "0x40042D0")]
	[FieldOffset(Offset = "0x70")]
	public int frequency;

	// Token: 0x02000886 RID: 2182
	[Token(Token = "0x2000886")]
	public enum StairwellLightRule
	{
		// Token: 0x040042D2 RID: 17106
		[Token(Token = "0x40042D2")]
		noStairwells,
		// Token: 0x040042D3 RID: 17107
		[Token(Token = "0x40042D3")]
		onlyStairwells,
		// Token: 0x040042D4 RID: 17108
		[Token(Token = "0x40042D4")]
		either
	}
}
