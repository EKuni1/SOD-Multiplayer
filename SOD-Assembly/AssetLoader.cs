using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

// Token: 0x0200025A RID: 602
[Token(Token = "0x200025A")]
public class AssetLoader
{
	// Token: 0x17000073 RID: 115
	// (get) Token: 0x06000D87 RID: 3463 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000073")]
	public static AssetLoader Instance
	{
		[Token(Token = "0x6000D87")]
		[Address(RVA = "0x5EBC40", Offset = "0x5EAC40", VA = "0x1805EBC40")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D88 RID: 3464 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D88")]
	[Address(RVA = "0x5EBD60", Offset = "0x5EAD60", VA = "0x1805EBD60")]
	private void SortScriptableObject(ScriptableObject scriptableObject)
	{
	}

	// Token: 0x06000D89 RID: 3465 RVA: 0x000073B0 File Offset: 0x000055B0
	[Token(Token = "0x6000D89")]
	[Address(RVA = "0x5EC2E0", Offset = "0x5EB2E0", VA = "0x1805EC2E0")]
	private static float TimeDiff(float time)
	{
		return 0f;
	}

	// Token: 0x06000D8A RID: 3466 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D8A")]
	[Address(RVA = "0x5EC340", Offset = "0x5EB340", VA = "0x1805EC340")]
	private static string TimeDiffStr(float time)
	{
		return null;
	}

	// Token: 0x06000D8B RID: 3467 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D8B")]
	[Address(RVA = "0x5EC440", Offset = "0x5EB440", VA = "0x1805EC440")]
	public Task PerformInitialLoadAsync()
	{
		return null;
	}

	// Token: 0x06000D8C RID: 3468 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D8C")]
	[Address(RVA = "0x5EC610", Offset = "0x5EB610", VA = "0x1805EC610")]
	public List<ScriptableObject> GetAllPresets()
	{
		return null;
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0x5EC7E0", Offset = "0x5EB7E0", VA = "0x1805EC7E0")]
	public List<AmbientZone> GetAllAmbientZones()
	{
		return null;
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0x5EC9B0", Offset = "0x5EB9B0", VA = "0x1805EC9B0")]
	public List<MusicCue> GetAllMusicCues()
	{
		return null;
	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0x5ECB80", Offset = "0x5EBB80", VA = "0x1805ECB80")]
	public List<ChapterPreset> GetAllChapters()
	{
		return null;
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D90")]
	[Address(RVA = "0x5ECD50", Offset = "0x5EBD50", VA = "0x1805ECD50")]
	public List<AIActionPreset> GetAllActions()
	{
		return null;
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D91")]
	[Address(RVA = "0x5ECF20", Offset = "0x5EBF20", VA = "0x1805ECF20")]
	public List<TextAsset> GetAllFloorData()
	{
		return null;
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D92")]
	[Address(RVA = "0x5ED0F0", Offset = "0x5EC0F0", VA = "0x1805ED0F0")]
	public List<BuildingPreset> GetAllBuildingPresets()
	{
		return null;
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D93")]
	[Address(RVA = "0x5ED2C0", Offset = "0x5EC2C0", VA = "0x1805ED2C0")]
	public List<FurniturePreset> GetAllFurniture()
	{
		return null;
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D94")]
	[Address(RVA = "0x5ED490", Offset = "0x5EC490", VA = "0x1805ED490")]
	public List<InteractablePreset> GetAllInteractables()
	{
		return null;
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D95")]
	[Address(RVA = "0x5ED660", Offset = "0x5EC660", VA = "0x1805ED660")]
	public List<ClothesPreset> GetAllClothes()
	{
		return null;
	}

	// Token: 0x06000D96 RID: 3478 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D96")]
	[Address(RVA = "0x5ED830", Offset = "0x5EC830", VA = "0x1805ED830")]
	public List<LayoutConfiguration> GetAllLayoutConfigurations()
	{
		return null;
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D97")]
	[Address(RVA = "0x5EDA00", Offset = "0x5ECA00", VA = "0x1805EDA00")]
	public List<RoomConfiguration> GetAllRoomConfigurations()
	{
		return null;
	}

	// Token: 0x06000D98 RID: 3480 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D98")]
	[Address(RVA = "0x5EDBD0", Offset = "0x5ECBD0", VA = "0x1805EDBD0")]
	public List<RoomTypePreset> GetAllRoomTypePresets()
	{
		return null;
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D99")]
	[Address(RVA = "0x5EDDA0", Offset = "0x5ECDA0", VA = "0x1805EDDA0")]
	public List<DoorPairPreset> GetAllDoorPairPresets()
	{
		return null;
	}

	// Token: 0x06000D9A RID: 3482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D9A")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public AssetLoader()
	{
	}

	// Token: 0x04000F21 RID: 3873
	[Token(Token = "0x4000F21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string DATA_GROUP;

	// Token: 0x04000F22 RID: 3874
	[Token(Token = "0x4000F22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string AMBIENT_ZONES_GROUP;

	// Token: 0x04000F23 RID: 3875
	[Token(Token = "0x4000F23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string MUSIC_CUES_GROUP;

	// Token: 0x04000F24 RID: 3876
	[Token(Token = "0x4000F24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string CHAPTERS_GROUP;

	// Token: 0x04000F25 RID: 3877
	[Token(Token = "0x4000F25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string ACTIONS_GROUP;

	// Token: 0x04000F26 RID: 3878
	[Token(Token = "0x4000F26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly string FLOOR_DATA_GROUP;

	// Token: 0x04000F27 RID: 3879
	[Token(Token = "0x4000F27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly string BUILDING_DATA_GROUP;

	// Token: 0x04000F28 RID: 3880
	[Token(Token = "0x4000F28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly string FURNITURE_GROUP;

	// Token: 0x04000F29 RID: 3881
	[Token(Token = "0x4000F29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly string INTERACTABLES_GROUP;

	// Token: 0x04000F2A RID: 3882
	[Token(Token = "0x4000F2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static readonly string CLOTHES_GROUP;

	// Token: 0x04000F2B RID: 3883
	[Token(Token = "0x4000F2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static readonly string LAYOUT_CONFIG_GROUP;

	// Token: 0x04000F2C RID: 3884
	[Token(Token = "0x4000F2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static readonly string ROOM_CONFIG_GROUP;

	// Token: 0x04000F2D RID: 3885
	[Token(Token = "0x4000F2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static readonly string ROOM_PRESETS_GROUP;

	// Token: 0x04000F2E RID: 3886
	[Token(Token = "0x4000F2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static readonly string DOOR_PAIR_PRESETS_GROUP;

	// Token: 0x04000F2F RID: 3887
	[Token(Token = "0x4000F2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static AssetLoader instance;

	// Token: 0x04000F30 RID: 3888
	[Token(Token = "0x4000F30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<ScriptableObject> allPresets;

	// Token: 0x04000F31 RID: 3889
	[Token(Token = "0x4000F31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<AmbientZone> allAmbientZones;

	// Token: 0x04000F32 RID: 3890
	[Token(Token = "0x4000F32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<MusicCue> allMusicCues;

	// Token: 0x04000F33 RID: 3891
	[Token(Token = "0x4000F33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<ChapterPreset> allChapters;

	// Token: 0x04000F34 RID: 3892
	[Token(Token = "0x4000F34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<AIActionPreset> allActions;

	// Token: 0x04000F35 RID: 3893
	[Token(Token = "0x4000F35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<TextAsset> allFloorData;

	// Token: 0x04000F36 RID: 3894
	[Token(Token = "0x4000F36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<BuildingPreset> allBuildingData;

	// Token: 0x04000F37 RID: 3895
	[Token(Token = "0x4000F37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<FurniturePreset> allFurniture;

	// Token: 0x04000F38 RID: 3896
	[Token(Token = "0x4000F38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<InteractablePreset> allInteractables;

	// Token: 0x04000F39 RID: 3897
	[Token(Token = "0x4000F39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<ClothesPreset> allClothes;

	// Token: 0x04000F3A RID: 3898
	[Token(Token = "0x4000F3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<LayoutConfiguration> allLayoutConfigurations;

	// Token: 0x04000F3B RID: 3899
	[Token(Token = "0x4000F3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<RoomConfiguration> allRoomConfigurations;

	// Token: 0x04000F3C RID: 3900
	[Token(Token = "0x4000F3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<RoomTypePreset> allRoomTypePresets;

	// Token: 0x04000F3D RID: 3901
	[Token(Token = "0x4000F3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<DoorPairPreset> allDoorPairPresets;

	// Token: 0x0200025B RID: 603
	[Token(Token = "0x200025B")]
	[StructLayout(3)]
	private struct <PerformInitialLoadAsync>d__34 : IEnumerator<object>
	{
		// Token: 0x06000D9C RID: 3484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x5EE720", Offset = "0x5ED720", VA = "0x1805EE720", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x5EF950", Offset = "0x5EE950", VA = "0x1805EF950", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04000F3E RID: 3902
		[Token(Token = "0x4000F3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04000F3F RID: 3903
		[Token(Token = "0x4000F3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		// Token: 0x04000F40 RID: 3904
		[Token(Token = "0x4000F40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AssetLoader <>4__this;

		// Token: 0x04000F41 RID: 3905
		[Token(Token = "0x4000F41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time>5__2;

		// Token: 0x04000F42 RID: 3906
		[Token(Token = "0x4000F42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <originalVSync>5__3;

		// Token: 0x04000F43 RID: 3907
		[Token(Token = "0x4000F43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AsyncOperationHandle<IList<ScriptableObject>> <asyncOperationHandleData>5__4;

		// Token: 0x04000F44 RID: 3908
		[Token(Token = "0x4000F44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AsyncOperationHandle<IList<TextAsset>> <asyncOperationHandleFloorData>5__5;

		// Token: 0x04000F45 RID: 3909
		[Token(Token = "0x4000F45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TaskAwaiter<IList<ScriptableObject>> <>u__1;

		// Token: 0x04000F46 RID: 3910
		[Token(Token = "0x4000F46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TaskAwaiter<IList<TextAsset>> <>u__2;
	}
}
