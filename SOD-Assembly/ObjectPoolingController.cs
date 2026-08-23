using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000484 RID: 1156
[Token(Token = "0x2000484")]
public class ObjectPoolingController : MonoBehaviour
{
	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06001A5B RID: 6747 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000CE")]
	public static ObjectPoolingController Instance
	{
		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x9804B0", Offset = "0x97F4B0", VA = "0x1809804B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001A5C RID: 6748 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A5C")]
	[Address(RVA = "0x9804F0", Offset = "0x97F4F0", VA = "0x1809804F0")]
	private void Awake()
	{
	}

	// Token: 0x06001A5D RID: 6749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A5D")]
	[Address(RVA = "0x980B20", Offset = "0x97FB20", VA = "0x180980B20")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001A5E RID: 6750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A5E")]
	[Address(RVA = "0x980D30", Offset = "0x97FD30", VA = "0x180980D30")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001A5F RID: 6751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A5F")]
	[Address(RVA = "0x980F60", Offset = "0x97FF60", VA = "0x180980F60")]
	private void ExecuteInteractableCheckingPool(int maxPooledLoops, int maxNewObjectLoops)
	{
	}

	// Token: 0x06001A60 RID: 6752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A60")]
	[Address(RVA = "0x9810B0", Offset = "0x9800B0", VA = "0x1809810B0")]
	private void ExecuteFurnitureCheckingPool(int maxLoops)
	{
	}

	// Token: 0x06001A61 RID: 6753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A61")]
	[Address(RVA = "0x981320", Offset = "0x980320", VA = "0x180981320")]
	public void MarkAsToLoad(Interactable interactable)
	{
	}

	// Token: 0x06001A62 RID: 6754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A62")]
	[Address(RVA = "0x9818E0", Offset = "0x9808E0", VA = "0x1809818E0")]
	public void MarkAsNotNeeded(Interactable interactable)
	{
	}

	// Token: 0x06001A63 RID: 6755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A63")]
	[Address(RVA = "0x981AF0", Offset = "0x980AF0", VA = "0x180981AF0")]
	public void MarkAsToLoad(FurnitureLocation furniture, bool forceSpawnImmediate = false)
	{
	}

	// Token: 0x06001A64 RID: 6756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A64")]
	[Address(RVA = "0x981B20", Offset = "0x980B20", VA = "0x180981B20")]
	public void MarkAsNotNeeded(FurnitureLocation furniture)
	{
	}

	// Token: 0x06001A65 RID: 6757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A65")]
	[Address(RVA = "0x981BB0", Offset = "0x980BB0", VA = "0x180981BB0")]
	public void UpdateObjectRanges()
	{
	}

	// Token: 0x06001A66 RID: 6758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A66")]
	[Address(RVA = "0x981C40", Offset = "0x980C40", VA = "0x180981C40")]
	public void ExecuteUpdateObjectRanges()
	{
	}

	// Token: 0x06001A67 RID: 6759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A67")]
	[Address(RVA = "0x981C50", Offset = "0x980C50", VA = "0x180981C50")]
	public void ExecuteUpdateObjectRanges(bool forceImmediateSpawning = false)
	{
	}

	// Token: 0x06001A68 RID: 6760 RVA: 0x0000C618 File Offset: 0x0000A818
	[Token(Token = "0x6001A68")]
	[Address(RVA = "0x982470", Offset = "0x981470", VA = "0x180982470")]
	public bool SpawnRangeCheck(Interactable interactable, out float distance)
	{
		return default(bool);
	}

	// Token: 0x06001A69 RID: 6761 RVA: 0x0000C630 File Offset: 0x0000A830
	[Token(Token = "0x6001A69")]
	[Address(RVA = "0x982780", Offset = "0x981780", VA = "0x180982780")]
	public bool SpawnRangeCheck(FurnitureLocation furniture, out float distance)
	{
		return default(bool);
	}

	// Token: 0x06001A6A RID: 6762 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A6A")]
	[Address(RVA = "0x982AE0", Offset = "0x981AE0", VA = "0x180982AE0")]
	public GameObject GetInteractableObject(Interactable interactable, out bool wasPooled, out bool isSelf)
	{
		return null;
	}

	// Token: 0x06001A6B RID: 6763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A6B")]
	[Address(RVA = "0x982F60", Offset = "0x981F60", VA = "0x180982F60")]
	public void RemoveFromPool(Interactable interactable)
	{
	}

	// Token: 0x06001A6C RID: 6764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A6C")]
	[Address(RVA = "0x983060", Offset = "0x982060", VA = "0x180983060")]
	public void PoolInteractable(Interactable interactable)
	{
	}

	// Token: 0x06001A6D RID: 6765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A6D")]
	[Address(RVA = "0x9832F0", Offset = "0x9822F0", VA = "0x1809832F0")]
	public void MarkRoomStuffToLoad(NewRoom room)
	{
	}

	// Token: 0x06001A6E RID: 6766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A6E")]
	[Address(RVA = "0x983400", Offset = "0x982400", VA = "0x180983400")]
	public void MarkRoomStuffNotNeeded(NewRoom room)
	{
	}

	// Token: 0x06001A6F RID: 6767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A6F")]
	[Address(RVA = "0x983490", Offset = "0x982490", VA = "0x180983490")]
	private void ExecuteRoomStuffPool(int maxPerFrame)
	{
	}

	// Token: 0x06001A70 RID: 6768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A70")]
	[Address(RVA = "0x983620", Offset = "0x982620", VA = "0x180983620")]
	public ObjectPoolingController()
	{
	}

	// Token: 0x04001FF6 RID: 8182
	[Token(Token = "0x4001FF6")]
	[FieldOffset(Offset = "0x18")]
	public bool useGradualSpawning;

	// Token: 0x04001FF7 RID: 8183
	[Token(Token = "0x4001FF7")]
	[FieldOffset(Offset = "0x1C")]
	public int loadNewObjectPerFrame;

	// Token: 0x04001FF8 RID: 8184
	[Token(Token = "0x4001FF8")]
	[FieldOffset(Offset = "0x20")]
	public int loadPooledObjectPerFrame;

	// Token: 0x04001FF9 RID: 8185
	[Token(Token = "0x4001FF9")]
	[FieldOffset(Offset = "0x24")]
	public bool usePooling;

	// Token: 0x04001FFA RID: 8186
	[Token(Token = "0x4001FFA")]
	[FieldOffset(Offset = "0x28")]
	public int maximumInteractablePoolCache;

	// Token: 0x04001FFB RID: 8187
	[Token(Token = "0x4001FFB")]
	[FieldOffset(Offset = "0x2C")]
	public bool useRange;

	// Token: 0x04001FFC RID: 8188
	[Token(Token = "0x4001FFC")]
	[FieldOffset(Offset = "0x30")]
	public List<ObjectPoolingController.ObjectLoadRangeConfig> loadRangeConfig;

	// Token: 0x04001FFD RID: 8189
	[Token(Token = "0x4001FFD")]
	[FieldOffset(Offset = "0x38")]
	public int maximumRangeCheckingPerFrame;

	// Token: 0x04001FFE RID: 8190
	[Token(Token = "0x4001FFE")]
	[FieldOffset(Offset = "0x3C")]
	public bool roomCacheLimit;

	// Token: 0x04001FFF RID: 8191
	[Token(Token = "0x4001FFF")]
	[FieldOffset(Offset = "0x40")]
	public int maxRoomCache;

	// Token: 0x04002000 RID: 8192
	[Token(Token = "0x4002000")]
	[FieldOffset(Offset = "0x44")]
	public bool allowGradualRoomLoading;

	// Token: 0x04002001 RID: 8193
	[Token(Token = "0x4002001")]
	[FieldOffset(Offset = "0x48")]
	public int roomsLoadedPerFrame;

	// Token: 0x04002002 RID: 8194
	[Token(Token = "0x4002002")]
	[FieldOffset(Offset = "0x4C")]
	public int interactablesLoaded;

	// Token: 0x04002003 RID: 8195
	[Token(Token = "0x4002003")]
	[FieldOffset(Offset = "0x50")]
	public int interactablesToLoadCount;

	// Token: 0x04002004 RID: 8196
	[Token(Token = "0x4002004")]
	[FieldOffset(Offset = "0x54")]
	public int interactablesRangeCount;

	// Token: 0x04002005 RID: 8197
	[Token(Token = "0x4002005")]
	[FieldOffset(Offset = "0x58")]
	[NonSerialized]
	public float updateObjectRangesTimer;

	// Token: 0x04002006 RID: 8198
	[Token(Token = "0x4002006")]
	[FieldOffset(Offset = "0x5C")]
	public int furntiureCheckCount;

	// Token: 0x04002007 RID: 8199
	[Token(Token = "0x4002007")]
	[FieldOffset(Offset = "0x60")]
	public int furnitureToLoadCount;

	// Token: 0x04002008 RID: 8200
	[Token(Token = "0x4002008")]
	[FieldOffset(Offset = "0x64")]
	public int furnitureRangeCount;

	// Token: 0x04002009 RID: 8201
	[Token(Token = "0x4002009")]
	[FieldOffset(Offset = "0x68")]
	public int interactablesCurrentlyPooled;

	// Token: 0x0400200A RID: 8202
	[Token(Token = "0x400200A")]
	[FieldOffset(Offset = "0x6C")]
	public int interactableInstancesSaved;

	// Token: 0x0400200B RID: 8203
	[Token(Token = "0x400200B")]
	[FieldOffset(Offset = "0x70")]
	public float interactableFullPercentage;

	// Token: 0x0400200C RID: 8204
	[Token(Token = "0x400200C")]
	[FieldOffset(Offset = "0x74")]
	public int roomsLoaded;

	// Token: 0x0400200D RID: 8205
	[Token(Token = "0x400200D")]
	[FieldOffset(Offset = "0x78")]
	public int roomStuffToLoad;

	// Token: 0x0400200E RID: 8206
	[Token(Token = "0x400200E")]
	[FieldOffset(Offset = "0x80")]
	public Dictionary<int, float> loadRanges;

	// Token: 0x0400200F RID: 8207
	[Token(Token = "0x400200F")]
	[FieldOffset(Offset = "0x88")]
	public List<Interactable> interactableRangeToLoadList;

	// Token: 0x04002010 RID: 8208
	[Token(Token = "0x4002010")]
	[FieldOffset(Offset = "0x90")]
	[NonSerialized]
	public List<Interactable> interactableRangeToEnableDisableList;

	// Token: 0x04002011 RID: 8209
	[Token(Token = "0x4002011")]
	[FieldOffset(Offset = "0x98")]
	public HashSet<Interactable> interactableLoadList;

	// Token: 0x04002012 RID: 8210
	[Token(Token = "0x4002012")]
	[FieldOffset(Offset = "0xA0")]
	private List<FurnitureLocation> furnitureRangeToLoadList;

	// Token: 0x04002013 RID: 8211
	[Token(Token = "0x4002013")]
	[FieldOffset(Offset = "0xA8")]
	[NonSerialized]
	public HashSet<FurnitureLocation> furnitureRangeToEnableDisableList;

	// Token: 0x04002014 RID: 8212
	[Token(Token = "0x4002014")]
	[FieldOffset(Offset = "0xB0")]
	public Dictionary<InteractablePreset, HashSet<Interactable>> interactablePool;

	// Token: 0x04002015 RID: 8213
	[Token(Token = "0x4002015")]
	[FieldOffset(Offset = "0xB8")]
	private HashSet<Interactable> entirePoolReference;

	// Token: 0x04002016 RID: 8214
	[Token(Token = "0x4002016")]
	[FieldOffset(Offset = "0xC0")]
	private HashSet<FurnitureLocation> furnitureCheckingPool;

	// Token: 0x04002017 RID: 8215
	[Token(Token = "0x4002017")]
	[FieldOffset(Offset = "0xC8")]
	public HashSet<NewRoom> roomStuffQueuedToLoad;

	// Token: 0x04002018 RID: 8216
	[Token(Token = "0x4002018")]
	[FieldOffset(Offset = "0xD0")]
	private Action UpdateObjectRange;

	// Token: 0x04002019 RID: 8217
	[Token(Token = "0x4002019")]
	[FieldOffset(Offset = "0x0")]
	private static ObjectPoolingController _instance;

	// Token: 0x02000485 RID: 1157
	[Token(Token = "0x2000485")]
	public enum ObjectLoadRange
	{
		// Token: 0x0400201B RID: 8219
		[Token(Token = "0x400201B")]
		veryClose,
		// Token: 0x0400201C RID: 8220
		[Token(Token = "0x400201C")]
		close,
		// Token: 0x0400201D RID: 8221
		[Token(Token = "0x400201D")]
		medium,
		// Token: 0x0400201E RID: 8222
		[Token(Token = "0x400201E")]
		far,
		// Token: 0x0400201F RID: 8223
		[Token(Token = "0x400201F")]
		veryFar,
		// Token: 0x04002020 RID: 8224
		[Token(Token = "0x4002020")]
		maximum
	}

	// Token: 0x02000486 RID: 1158
	[Token(Token = "0x2000486")]
	[Serializable]
	public class ObjectLoadRangeConfig
	{
		// Token: 0x06001A71 RID: 6769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ObjectLoadRangeConfig()
		{
		}

		// Token: 0x04002021 RID: 8225
		[Token(Token = "0x4002021")]
		[FieldOffset(Offset = "0x10")]
		public ObjectPoolingController.ObjectLoadRange range;

		// Token: 0x04002022 RID: 8226
		[Token(Token = "0x4002022")]
		[FieldOffset(Offset = "0x14")]
		public float loadDistance;
	}
}
