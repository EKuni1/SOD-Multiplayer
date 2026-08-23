using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003FA RID: 1018
[Token(Token = "0x20003FA")]
public class NewWall
{
	// Token: 0x06001712 RID: 5906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001712")]
	[Address(RVA = "0x87C060", Offset = "0x87B060", VA = "0x18087C060")]
	public void Setup(DoorPairPreset newPreset, NewNode newNode, Vector2 newOffset, bool newIsExterior)
	{
	}

	// Token: 0x06001713 RID: 5907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001713")]
	[Address(RVA = "0x87CBE0", Offset = "0x87BBE0", VA = "0x18087CBE0")]
	public void Load(CitySaveData.WallCitySave data, NewNode newNode)
	{
	}

	// Token: 0x06001714 RID: 5908 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001714")]
	[Address(RVA = "0x87D3C0", Offset = "0x87C3C0", VA = "0x18087D3C0")]
	public void SetDoorStrength(float newVal)
	{
	}

	// Token: 0x06001715 RID: 5909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001715")]
	[Address(RVA = "0x87DA90", Offset = "0x87CA90", VA = "0x18087DA90")]
	public void SetLockStrengthBase(float newVal)
	{
	}

	// Token: 0x06001716 RID: 5910 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001716")]
	[Address(RVA = "0x87DAC0", Offset = "0x87CAC0", VA = "0x18087DAC0")]
	public void ResetLockStrength()
	{
	}

	// Token: 0x06001717 RID: 5911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001717")]
	[Address(RVA = "0x87DAE0", Offset = "0x87CAE0", VA = "0x18087DAE0")]
	public void SetDoorStrengthBase(float newVal)
	{
	}

	// Token: 0x06001718 RID: 5912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001718")]
	[Address(RVA = "0x87DB10", Offset = "0x87CB10", VA = "0x18087DB10")]
	public void ResetDoorStrength()
	{
	}

	// Token: 0x06001719 RID: 5913 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001719")]
	[Address(RVA = "0x87DB30", Offset = "0x87CB30", VA = "0x18087DB30")]
	public void SetCurrentLockStrength(float newVal)
	{
	}

	// Token: 0x0600171A RID: 5914 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600171A")]
	[Address(RVA = "0x87E130", Offset = "0x87D130", VA = "0x18087E130")]
	public void SpawnWall(bool prepForCombinedMeshes)
	{
	}

	// Token: 0x0600171B RID: 5915 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600171B")]
	[Address(RVA = "0x87F450", Offset = "0x87E450", VA = "0x18087F450")]
	public void RemoveWall()
	{
	}

	// Token: 0x0600171C RID: 5916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600171C")]
	[Address(RVA = "0x87FCD0", Offset = "0x87ECD0", VA = "0x18087FCD0")]
	private void UpdateSegmentData()
	{
	}

	// Token: 0x0600171D RID: 5917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600171D")]
	[Address(RVA = "0x87FD70", Offset = "0x87ED70", VA = "0x18087FD70")]
	public void SpawnCorner(bool prepForCombinedMeshes)
	{
	}

	// Token: 0x0600171E RID: 5918 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600171E")]
	[Address(RVA = "0x880E10", Offset = "0x87FE10", VA = "0x180880E10")]
	public void SpawnFrontage(bool overrideWithKey = false, [Optional] Toolbox.MaterialKey keyOverride)
	{
	}

	// Token: 0x0600171F RID: 5919 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600171F")]
	[Address(RVA = "0x8821F0", Offset = "0x8811F0", VA = "0x1808821F0")]
	public void RemoveFrontage()
	{
	}

	// Token: 0x06001720 RID: 5920 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001720")]
	[Address(RVA = "0x882310", Offset = "0x881310", VA = "0x180882310")]
	public void SetDoorPairPreset(DoorPairPreset newPreset, bool enableUpdate = true, bool newIsDivider = false, bool setPair = true)
	{
	}

	// Token: 0x06001721 RID: 5921 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001721")]
	[Address(RVA = "0x884120", Offset = "0x883120", VA = "0x180884120")]
	public void SelectFrontage()
	{
	}

	// Token: 0x06001722 RID: 5922 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001722")]
	[Address(RVA = "0x8858E0", Offset = "0x8848E0", VA = "0x1808858E0")]
	public void SetWallMaterial(MaterialGroupPreset newMat, Toolbox.MaterialKey newKey)
	{
	}

	// Token: 0x06001723 RID: 5923 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001723")]
	[Address(RVA = "0x885CC0", Offset = "0x884CC0", VA = "0x180885CC0")]
	public void SetAsLightswitch(NewRoom newRoom, bool createInteractable = true)
	{
	}

	// Token: 0x06001724 RID: 5924 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001724")]
	[Address(RVA = "0x886E80", Offset = "0x885E80", VA = "0x180886E80")]
	public CitySaveData.WallCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x06001725 RID: 5925 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001725")]
	[Address(RVA = "0x887470", Offset = "0x886470", VA = "0x180887470")]
	public NewWall()
	{
	}

	// Token: 0x06001726 RID: 5926 RVA: 0x0000AB18 File Offset: 0x00008D18
	[Token(Token = "0x6001726")]
	[Address(RVA = "0x887600", Offset = "0x886600", VA = "0x180887600")]
	private bool <SpawnCorner>b__55_0(NewWall item)
	{
		return default(bool);
	}

	// Token: 0x06001727 RID: 5927 RVA: 0x0000AB30 File Offset: 0x00008D30
	[Token(Token = "0x6001727")]
	[Address(RVA = "0x887650", Offset = "0x886650", VA = "0x180887650")]
	private bool <SetDoorPairPreset>b__58_0(NewWall item)
	{
		return default(bool);
	}

	// Token: 0x06001728 RID: 5928 RVA: 0x0000AB48 File Offset: 0x00008D48
	[Token(Token = "0x6001728")]
	[Address(RVA = "0x887600", Offset = "0x886600", VA = "0x180887600")]
	private bool <SetDoorPairPreset>b__58_1(NewWall item)
	{
		return default(bool);
	}

	// Token: 0x06001729 RID: 5929 RVA: 0x0000AB60 File Offset: 0x00008D60
	[Token(Token = "0x6001729")]
	[Address(RVA = "0x887600", Offset = "0x886600", VA = "0x180887600")]
	private bool <SetAsLightswitch>b__61_0(NewWall item)
	{
		return default(bool);
	}

	// Token: 0x04001BFB RID: 7163
	[Token(Token = "0x4001BFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 position;

	// Token: 0x04001BFC RID: 7164
	[Token(Token = "0x4001BFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 localEulerAngles;

	// Token: 0x04001BFD RID: 7165
	[Token(Token = "0x4001BFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject physicalObject;

	// Token: 0x04001BFE RID: 7166
	[Token(Token = "0x4001BFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public NewNode node;

	// Token: 0x04001BFF RID: 7167
	[Token(Token = "0x4001BFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector2 wallOffset;

	// Token: 0x04001C00 RID: 7168
	[Token(Token = "0x4001C00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isExterior;

	// Token: 0x04001C01 RID: 7169
	[Token(Token = "0x4001C01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool separateWall;

	// Token: 0x04001C02 RID: 7170
	[Token(Token = "0x4001C02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int id;

	// Token: 0x04001C03 RID: 7171
	[Token(Token = "0x4001C03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool preventEntrance;

	// Token: 0x04001C04 RID: 7172
	[Token(Token = "0x4001C04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool foundDoorMaterialKey;

	// Token: 0x04001C05 RID: 7173
	[Token(Token = "0x4001C05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Toolbox.MaterialKey doorMatKey;

	// Token: 0x04001C06 RID: 7174
	[Token(Token = "0x4001C06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float baseDoorStrength;

	// Token: 0x04001C07 RID: 7175
	[Token(Token = "0x4001C07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float currentDoorStrength;

	// Token: 0x04001C08 RID: 7176
	[Token(Token = "0x4001C08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float baseLockStrength;

	// Token: 0x04001C09 RID: 7177
	[Token(Token = "0x4001C09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float currentLockStrength;

	// Token: 0x04001C0A RID: 7178
	[Token(Token = "0x4001C0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public DoorPairPreset preset;

	// Token: 0x04001C0B RID: 7179
	[Token(Token = "0x4001C0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public NewWall otherWall;

	// Token: 0x04001C0C RID: 7180
	[Token(Token = "0x4001C0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public NewWall parentWall;

	// Token: 0x04001C0D RID: 7181
	[Token(Token = "0x4001C0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public NewWall childWall;

	// Token: 0x04001C0E RID: 7182
	[Token(Token = "0x4001C0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<NewWall.FrontageSetting> frontagePresets;

	// Token: 0x04001C0F RID: 7183
	[Token(Token = "0x4001C0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[NonSerialized]
	public int otherWallID;

	// Token: 0x04001C10 RID: 7184
	[Token(Token = "0x4001C10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[NonSerialized]
	public int parentWallID;

	// Token: 0x04001C11 RID: 7185
	[Token(Token = "0x4001C11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[NonSerialized]
	public int childWallID;

	// Token: 0x04001C12 RID: 7186
	[Token(Token = "0x4001C12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool optimizationOverride;

	// Token: 0x04001C13 RID: 7187
	[Token(Token = "0x4001C13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	public bool optimizationAnchor;

	// Token: 0x04001C14 RID: 7188
	[Token(Token = "0x4001C14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public int nonOptimizedSegment;

	// Token: 0x04001C15 RID: 7189
	[Token(Token = "0x4001C15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject spawnedWall;

	// Token: 0x04001C16 RID: 7190
	[Token(Token = "0x4001C16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject wallPrefabRef;

	// Token: 0x04001C17 RID: 7191
	[Token(Token = "0x4001C17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject spawnedCorner;

	// Token: 0x04001C18 RID: 7192
	[Token(Token = "0x4001C18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject spawnedCoving;

	// Token: 0x04001C19 RID: 7193
	[Token(Token = "0x4001C19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject spawnedCornerCoving;

	// Token: 0x04001C1A RID: 7194
	[Token(Token = "0x4001C1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject cornerPrefabRef;

	// Token: 0x04001C1B RID: 7195
	[Token(Token = "0x4001C1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject spawnedSteps;

	// Token: 0x04001C1C RID: 7196
	[Token(Token = "0x4001C1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public GameObject editorTrigger;

	// Token: 0x04001C1D RID: 7197
	[Token(Token = "0x4001C1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public bool isShortWall;

	// Token: 0x04001C1E RID: 7198
	[Token(Token = "0x4001C1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private GameObject blueprint;

	// Token: 0x04001C1F RID: 7199
	[Token(Token = "0x4001C1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[NonSerialized]
	public Interactable lightswitchInteractable;

	// Token: 0x04001C20 RID: 7200
	[Token(Token = "0x4001C20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public NewDoor door;

	// Token: 0x04001C21 RID: 7201
	[Token(Token = "0x4001C21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public List<GameObject> spawnedFrontage;

	// Token: 0x04001C22 RID: 7202
	[Token(Token = "0x4001C22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public NewRoom containsLightswitch;

	// Token: 0x04001C23 RID: 7203
	[Token(Token = "0x4001C23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public int windowUVHorizonalPosition;

	// Token: 0x04001C24 RID: 7204
	[Token(Token = "0x4001C24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public BuildingPreset.WindowUVBlock windowUV;

	// Token: 0x04001C25 RID: 7205
	[Token(Token = "0x4001C25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public bool placedWallFurn;

	// Token: 0x020003FB RID: 1019
	[Token(Token = "0x20003FB")]
	[Serializable]
	public class FrontageSetting
	{
		// Token: 0x0600172A RID: 5930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600172A")]
		[Address(RVA = "0x8876B0", Offset = "0x8866B0", VA = "0x1808876B0")]
		public FrontageSetting()
		{
		}

		// Token: 0x04001C26 RID: 7206
		[Token(Token = "0x4001C26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WallFrontagePreset preset;

		// Token: 0x04001C27 RID: 7207
		[Token(Token = "0x4001C27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toolbox.MaterialKey matKey;

		// Token: 0x04001C28 RID: 7208
		[Token(Token = "0x4001C28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool colors;

		// Token: 0x04001C29 RID: 7209
		[Token(Token = "0x4001C29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 offset;

		// Token: 0x04001C2A RID: 7210
		[Token(Token = "0x4001C2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public List<Interactable> createdInteractables;

		// Token: 0x04001C2B RID: 7211
		[Token(Token = "0x4001C2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Transform mainTransform;
	}

	// Token: 0x020003FC RID: 1020
	[Token(Token = "0x20003FC")]
	private sealed class <>c__DisplayClass55_0
	{
		// Token: 0x0600172B RID: 5931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600172B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass55_0()
		{
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x0000AB78 File Offset: 0x00008D78
		[Token(Token = "0x600172C")]
		[Address(RVA = "0x8634F0", Offset = "0x8624F0", VA = "0x1808634F0")]
		internal bool <SpawnCorner>b__1(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001C2C RID: 7212
		[Token(Token = "0x4001C2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 wallChk;
	}

	// Token: 0x020003FD RID: 1021
	[Token(Token = "0x20003FD")]
	private sealed class <>c__DisplayClass55_1
	{
		// Token: 0x0600172D RID: 5933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600172D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass55_1()
		{
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x0000AB90 File Offset: 0x00008D90
		[Token(Token = "0x600172E")]
		[Address(RVA = "0x8634F0", Offset = "0x8624F0", VA = "0x1808634F0")]
		internal bool <SpawnCorner>b__2(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001C2D RID: 7213
		[Token(Token = "0x4001C2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 wallChk2;
	}

	// Token: 0x020003FE RID: 1022
	[Token(Token = "0x20003FE")]
	private sealed class <>c__DisplayClass56_0
	{
		// Token: 0x0600172F RID: 5935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600172F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass56_0()
		{
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		[Token(Token = "0x6001730")]
		[Address(RVA = "0x887780", Offset = "0x886780", VA = "0x180887780")]
		internal bool <SpawnFrontage>b__0(InteractableController item)
		{
			return default(bool);
		}

		// Token: 0x04001C2E RID: 7214
		[Token(Token = "0x4001C2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurniturePreset.IntegratedInteractable integrated;
	}

	// Token: 0x020003FF RID: 1023
	[Token(Token = "0x20003FF")]
	private sealed class <>c__DisplayClass58_0
	{
		// Token: 0x06001731 RID: 5937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001731")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass58_0()
		{
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		[Token(Token = "0x6001732")]
		[Address(RVA = "0x8877B0", Offset = "0x8867B0", VA = "0x1808877B0")]
		internal bool <SetDoorPairPreset>b__2(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		[Token(Token = "0x6001733")]
		[Address(RVA = "0x887810", Offset = "0x886810", VA = "0x180887810")]
		internal bool <SetDoorPairPreset>b__3(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		[Token(Token = "0x6001734")]
		[Address(RVA = "0x8877B0", Offset = "0x8867B0", VA = "0x1808877B0")]
		internal bool <SetDoorPairPreset>b__4(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0000AC08 File Offset: 0x00008E08
		[Token(Token = "0x6001735")]
		[Address(RVA = "0x887810", Offset = "0x886810", VA = "0x180887810")]
		internal bool <SetDoorPairPreset>b__5(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001C2F RID: 7215
		[Token(Token = "0x4001C2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 rightWallOffset;

		// Token: 0x04001C30 RID: 7216
		[Token(Token = "0x4001C30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 leftWallOffset;
	}

	// Token: 0x02000400 RID: 1024
	[Token(Token = "0x2000400")]
	private sealed class <>c__DisplayClass59_0
	{
		// Token: 0x06001736 RID: 5942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001736")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass59_0()
		{
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0000AC20 File Offset: 0x00008E20
		[Token(Token = "0x6001737")]
		[Address(RVA = "0x887870", Offset = "0x886870", VA = "0x180887870")]
		internal bool <SelectFrontage>b__1(NewWall.FrontageSetting item)
		{
			return default(bool);
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0000AC38 File Offset: 0x00008E38
		[Token(Token = "0x6001738")]
		[Address(RVA = "0x887870", Offset = "0x886870", VA = "0x180887870")]
		internal bool <SelectFrontage>b__2(NewWall.FrontageSetting item)
		{
			return default(bool);
		}

		// Token: 0x04001C31 RID: 7217
		[Token(Token = "0x4001C31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WallFrontagePreset chosenPreset;

		// Token: 0x04001C32 RID: 7218
		[Token(Token = "0x4001C32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<NewWall.FrontageSetting> <>9__1;

		// Token: 0x04001C33 RID: 7219
		[Token(Token = "0x4001C33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Predicate<NewWall.FrontageSetting> <>9__2;
	}

	// Token: 0x02000401 RID: 1025
	[Token(Token = "0x2000401")]
	private sealed class <>c__DisplayClass59_1
	{
		// Token: 0x06001739 RID: 5945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001739")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass59_1()
		{
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x0000AC50 File Offset: 0x00008E50
		[Token(Token = "0x600173A")]
		[Address(RVA = "0x8878B0", Offset = "0x8868B0", VA = "0x1808878B0")]
		internal bool <SelectFrontage>b__3(NewWall.FrontageSetting item)
		{
			return default(bool);
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x0000AC68 File Offset: 0x00008E68
		[Token(Token = "0x600173B")]
		[Address(RVA = "0x8878B0", Offset = "0x8868B0", VA = "0x1808878B0")]
		internal bool <SelectFrontage>b__4(NewWall.FrontageSetting item)
		{
			return default(bool);
		}

		// Token: 0x04001C34 RID: 7220
		[Token(Token = "0x4001C34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WallFrontagePreset chosenPreset;

		// Token: 0x04001C35 RID: 7221
		[Token(Token = "0x4001C35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<NewWall.FrontageSetting> <>9__3;

		// Token: 0x04001C36 RID: 7222
		[Token(Token = "0x4001C36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Predicate<NewWall.FrontageSetting> <>9__4;
	}

	// Token: 0x02000402 RID: 1026
	[Token(Token = "0x2000402")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600173D RID: 5949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600173D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0000AC80 File Offset: 0x00008E80
		[Token(Token = "0x600173E")]
		[Address(RVA = "0x887990", Offset = "0x886990", VA = "0x180887990")]
		internal bool <SelectFrontage>b__59_0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x0000AC98 File Offset: 0x00008E98
		[Token(Token = "0x600173F")]
		[Address(RVA = "0x875850", Offset = "0x874850", VA = "0x180875850")]
		internal bool <SetWallMaterial>b__60_0(NewNode item)
		{
			return default(bool);
		}

		// Token: 0x04001C37 RID: 7223
		[Token(Token = "0x4001C37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly NewWall.<>c <>9;

		// Token: 0x04001C38 RID: 7224
		[Token(Token = "0x4001C38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<NewWall> <>9__59_0;

		// Token: 0x04001C39 RID: 7225
		[Token(Token = "0x4001C39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<NewNode, bool> <>9__60_0;
	}
}
