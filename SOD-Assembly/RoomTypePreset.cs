using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000888 RID: 2184
[Token(Token = "0x2000888")]
public class RoomTypePreset : SoCustomComparison
{
	// Token: 0x060029EE RID: 10734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029EE")]
	[Address(RVA = "0xCB2BB0", Offset = "0xCB1BB0", VA = "0x180CB2BB0")]
	public RoomTypePreset()
	{
	}

	// Token: 0x040042D6 RID: 17110
	[Token(Token = "0x40042D6")]
	[FieldOffset(Offset = "0x20")]
	public RoomConfiguration forceConfiguration;

	// Token: 0x040042D7 RID: 17111
	[Token(Token = "0x40042D7")]
	[FieldOffset(Offset = "0x28")]
	public float chance;

	// Token: 0x040042D8 RID: 17112
	[Token(Token = "0x40042D8")]
	[FieldOffset(Offset = "0x2C")]
	public int minimumAddressSize;

	// Token: 0x040042D9 RID: 17113
	[Token(Token = "0x40042D9")]
	[FieldOffset(Offset = "0x30")]
	public int maximumRoomTypesPerAddress;

	// Token: 0x040042DA RID: 17114
	[Token(Token = "0x40042DA")]
	[FieldOffset(Offset = "0x34")]
	public int cyclePriority;

	// Token: 0x040042DB RID: 17115
	[Token(Token = "0x40042DB")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 minimumRoomAreaShape;

	// Token: 0x040042DC RID: 17116
	[Token(Token = "0x40042DC")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 maximumRoomAreaShape;

	// Token: 0x040042DD RID: 17117
	[Token(Token = "0x40042DD")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 tesselationShape;

	// Token: 0x040042DE RID: 17118
	[Token(Token = "0x40042DE")]
	[FieldOffset(Offset = "0x50")]
	public int floorSpaceWeight;

	// Token: 0x040042DF RID: 17119
	[Token(Token = "0x40042DF")]
	[FieldOffset(Offset = "0x54")]
	public int exteriorWallWeight;

	// Token: 0x040042E0 RID: 17120
	[Token(Token = "0x40042E0")]
	[FieldOffset(Offset = "0x58")]
	public int exteriorWindowWeight;

	// Token: 0x040042E1 RID: 17121
	[Token(Token = "0x40042E1")]
	[FieldOffset(Offset = "0x5C")]
	public int entranceWeight;

	// Token: 0x040042E2 RID: 17122
	[Token(Token = "0x40042E2")]
	[FieldOffset(Offset = "0x60")]
	public List<RoomTypePreset> mustAdjoinRooms;

	// Token: 0x040042E3 RID: 17123
	[Token(Token = "0x40042E3")]
	[FieldOffset(Offset = "0x68")]
	public int doorPriority;

	// Token: 0x040042E4 RID: 17124
	[Token(Token = "0x40042E4")]
	[FieldOffset(Offset = "0x6C")]
	public float chanceOfNoDoor;

	// Token: 0x040042E5 RID: 17125
	[Token(Token = "0x40042E5")]
	[FieldOffset(Offset = "0x70")]
	public int maxDoors;

	// Token: 0x040042E6 RID: 17126
	[Token(Token = "0x40042E6")]
	[FieldOffset(Offset = "0x74")]
	public bool forceNoDoors;

	// Token: 0x040042E7 RID: 17127
	[Token(Token = "0x40042E7")]
	[FieldOffset(Offset = "0x78")]
	public NewDoor.DoorSetting doorSetting;

	// Token: 0x040042E8 RID: 17128
	[Token(Token = "0x40042E8")]
	[FieldOffset(Offset = "0x7C")]
	public bool allowRoomDividers;

	// Token: 0x040042E9 RID: 17129
	[Token(Token = "0x40042E9")]
	[FieldOffset(Offset = "0x80")]
	public int maxDividers;

	// Token: 0x040042EA RID: 17130
	[Token(Token = "0x40042EA")]
	[FieldOffset(Offset = "0x88")]
	public List<RoomTypePreset> onlyAllowDividersAdjoining;

	// Token: 0x040042EB RID: 17131
	[Token(Token = "0x40042EB")]
	[FieldOffset(Offset = "0x90")]
	public bool allowMainAddressEntrance;

	// Token: 0x040042EC RID: 17132
	[Token(Token = "0x40042EC")]
	[FieldOffset(Offset = "0x91")]
	public bool allowSecondaryAddressEntrance;

	// Token: 0x040042ED RID: 17133
	[Token(Token = "0x40042ED")]
	[FieldOffset(Offset = "0x92")]
	public bool preferMainAddressEntrance;

	// Token: 0x040042EE RID: 17134
	[Token(Token = "0x40042EE")]
	[FieldOffset(Offset = "0x93")]
	public bool mustConnectWithEntrance;

	// Token: 0x040042EF RID: 17135
	[Token(Token = "0x40042EF")]
	[FieldOffset(Offset = "0x94")]
	public bool overridable;

	// Token: 0x040042F0 RID: 17136
	[Token(Token = "0x40042F0")]
	[FieldOffset(Offset = "0x98")]
	public int overwriteWithPriorityUpTo;

	// Token: 0x040042F1 RID: 17137
	[Token(Token = "0x40042F1")]
	[FieldOffset(Offset = "0xA0")]
	public List<RoomTypePreset> blockOverridesFromType;

	// Token: 0x040042F2 RID: 17138
	[Token(Token = "0x40042F2")]
	[FieldOffset(Offset = "0xA8")]
	public int overwriteLimit;

	// Token: 0x040042F3 RID: 17139
	[Token(Token = "0x40042F3")]
	[FieldOffset(Offset = "0xAC")]
	public bool expandIntoNull;

	// Token: 0x040042F4 RID: 17140
	[Token(Token = "0x40042F4")]
	[FieldOffset(Offset = "0xB0")]
	public int expandIntoNullAdjacencyMinimum;

	// Token: 0x040042F5 RID: 17141
	[Token(Token = "0x40042F5")]
	[FieldOffset(Offset = "0xB4")]
	public bool shareFeaturesWithCommonAdjacent;

	// Token: 0x040042F6 RID: 17142
	[Token(Token = "0x40042F6")]
	[FieldOffset(Offset = "0xB5")]
	public bool allowCorridorReplacement;

	// Token: 0x040042F7 RID: 17143
	[Token(Token = "0x40042F7")]
	[FieldOffset(Offset = "0xB6")]
	public bool overrideFloorHeight;

	// Token: 0x040042F8 RID: 17144
	[Token(Token = "0x40042F8")]
	[FieldOffset(Offset = "0xB8")]
	public int floorHeight;

	// Token: 0x040042F9 RID: 17145
	[Token(Token = "0x40042F9")]
	[FieldOffset(Offset = "0xC0")]
	public RoomConfiguration copyFrom;
}
