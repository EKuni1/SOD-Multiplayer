using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004B9 RID: 1209
[Token(Token = "0x20004B9")]
public class PlayerApartmentController : MonoBehaviour
{
	// Token: 0x14000028 RID: 40
	// (add) Token: 0x06001B13 RID: 6931 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001B14 RID: 6932 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000028")]
	public event PlayerApartmentController.FurnitureChange OnFurnitureChange
	{
		[Token(Token = "0x6001B13")]
		[Address(RVA = "0x9A6840", Offset = "0x9A5840", VA = "0x1809A6840")]
		add
		{
		}
		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x9A6940", Offset = "0x9A5940", VA = "0x1809A6940")]
		remove
		{
		}
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x06001B15 RID: 6933 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000D2")]
	public static PlayerApartmentController Instance
	{
		[Token(Token = "0x6001B15")]
		[Address(RVA = "0x9A6A40", Offset = "0x9A5A40", VA = "0x1809A6A40")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001B16 RID: 6934 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B16")]
	[Address(RVA = "0x9A6A80", Offset = "0x9A5A80", VA = "0x1809A6A80")]
	private void Awake()
	{
	}

	// Token: 0x06001B17 RID: 6935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B17")]
	[Address(RVA = "0x9A6E20", Offset = "0x9A5E20", VA = "0x1809A6E20")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001B18 RID: 6936 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B18")]
	[Address(RVA = "0x9A7030", Offset = "0x9A6030", VA = "0x1809A7030")]
	public void SortSwatches()
	{
	}

	// Token: 0x06001B19 RID: 6937 RVA: 0x0000C900 File Offset: 0x0000AB00
	[Token(Token = "0x6001B19")]
	[Address(RVA = "0x9A7230", Offset = "0x9A6230", VA = "0x1809A7230")]
	public int Step(Color colour)
	{
		return 0;
	}

	// Token: 0x06001B1A RID: 6938 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B1A")]
	[Address(RVA = "0x9A7320", Offset = "0x9A6320", VA = "0x1809A7320")]
	public void BuyNewResidence(ResidenceController newHome, bool removePreviousResidence = false)
	{
	}

	// Token: 0x06001B1B RID: 6939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B1B")]
	[Address(RVA = "0x9A7B90", Offset = "0x9A6B90", VA = "0x1809A7B90")]
	public void SetFurniturePlacementMode(bool val, PlayerApartmentController.FurniturePlacement newPlacement, NewRoom forRoom, bool newPlaceExistingRoomObject = false, bool forceUpdate = false)
	{
	}

	// Token: 0x06001B1C RID: 6940 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B1C")]
	[Address(RVA = "0x9A8300", Offset = "0x9A7300", VA = "0x1809A8300")]
	public InfoWindow OpenOrUpdateMaterialWindow(FurniturePreset furn, Toolbox.MaterialKey useKey, MaterialGroupPreset newSelection)
	{
		return null;
	}

	// Token: 0x06001B1D RID: 6941 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B1D")]
	[Address(RVA = "0x9A8690", Offset = "0x9A7690", VA = "0x1809A8690")]
	public void SetDecoratingMode(bool val, MaterialGroupPreset materialPreset, MaterialGroupPreset.MaterialType editType = MaterialGroupPreset.MaterialType.walls, [Optional] Toolbox.MaterialKey editKey, [Optional] NewRoom forRoom)
	{
	}

	// Token: 0x06001B1E RID: 6942 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B1E")]
	[Address(RVA = "0x9A8D40", Offset = "0x9A7D40", VA = "0x1809A8D40")]
	private void Update()
	{
	}

	// Token: 0x06001B1F RID: 6943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B1F")]
	[Address(RVA = "0x9AB480", Offset = "0x9AA480", VA = "0x1809AB480")]
	public void RemoveBeingPlaced()
	{
	}

	// Token: 0x06001B20 RID: 6944 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B20")]
	[Address(RVA = "0x9AB730", Offset = "0x9AA730", VA = "0x1809AB730")]
	public FurnitureLocation GetExistingFurniture()
	{
		return null;
	}

	// Token: 0x06001B21 RID: 6945 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B21")]
	[Address(RVA = "0x9AB760", Offset = "0x9AA760", VA = "0x1809AB760")]
	public void UpdatePlacementColourKey()
	{
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B22")]
	[Address(RVA = "0x9AC1B0", Offset = "0x9AB1B0", VA = "0x1809AC1B0")]
	private NewNode UpdateFurnitureDesiredPosition()
	{
		return null;
	}

	// Token: 0x06001B23 RID: 6947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B23")]
	[Address(RVA = "0x9AD750", Offset = "0x9AC750", VA = "0x1809AD750")]
	public void RotateFurn(bool right)
	{
	}

	// Token: 0x06001B24 RID: 6948 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B24")]
	[Address(RVA = "0x9AD900", Offset = "0x9AC900", VA = "0x1809AD900")]
	public void AddFurnitureRotation(int angle)
	{
	}

	// Token: 0x06001B25 RID: 6949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B25")]
	[Address(RVA = "0x9AD950", Offset = "0x9AC950", VA = "0x1809AD950")]
	public void ExecutePlacement()
	{
	}

	// Token: 0x06001B26 RID: 6950 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B26")]
	[Address(RVA = "0x9AE140", Offset = "0x9AD140", VA = "0x1809AE140")]
	public void ResetExisting()
	{
	}

	// Token: 0x06001B27 RID: 6951 RVA: 0x0000C918 File Offset: 0x0000AB18
	[Token(Token = "0x6001B27")]
	[Address(RVA = "0x9AE220", Offset = "0x9AD220", VA = "0x1809AE220")]
	public int GetCurrentCost()
	{
		return 0;
	}

	// Token: 0x06001B28 RID: 6952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B28")]
	[Address(RVA = "0x9AE310", Offset = "0x9AD310", VA = "0x1809AE310")]
	public void CancelPlacement(bool restoreExistingPosition)
	{
	}

	// Token: 0x06001B29 RID: 6953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B29")]
	[Address(RVA = "0x9AE5F0", Offset = "0x9AD5F0", VA = "0x1809AE5F0")]
	public void MoveFurnitureToStorage(FurnitureLocation newStorage)
	{
	}

	// Token: 0x06001B2A RID: 6954 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B2A")]
	[Address(RVA = "0x9AEA60", Offset = "0x9ADA60", VA = "0x1809AEA60")]
	public void RemoveFromStorage(FurnitureLocation newStorage)
	{
	}

	// Token: 0x06001B2B RID: 6955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B2B")]
	[Address(RVA = "0x9AED20", Offset = "0x9ADD20", VA = "0x1809AED20")]
	public void SellFurniture(FurnitureLocation newSell)
	{
	}

	// Token: 0x06001B2C RID: 6956 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B2C")]
	[Address(RVA = "0x9AF120", Offset = "0x9AE120", VA = "0x1809AF120")]
	public void MoveItemToStorage(Interactable newStorage)
	{
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B2D")]
	[Address(RVA = "0x9AF7F0", Offset = "0x9AE7F0", VA = "0x1809AF7F0")]
	public void RemoveItemFromStorage(Interactable newStorage)
	{
	}

	// Token: 0x06001B2E RID: 6958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B2E")]
	[Address(RVA = "0x9AFA90", Offset = "0x9AEA90", VA = "0x1809AFA90")]
	public void SellItem(Interactable newSell)
	{
	}

	// Token: 0x06001B2F RID: 6959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B2F")]
	[Address(RVA = "0x9AFCE0", Offset = "0x9AECE0", VA = "0x1809AFCE0")]
	public void UpdateDecorColourKey()
	{
	}

	// Token: 0x06001B30 RID: 6960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B30")]
	[Address(RVA = "0x9AFD20", Offset = "0x9AED20", VA = "0x1809AFD20")]
	public void ApplyDecor(MaterialGroupPreset.MaterialType decorType, MaterialGroupPreset material, Toolbox.MaterialKey key, bool saveChanges)
	{
	}

	// Token: 0x06001B31 RID: 6961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B31")]
	[Address(RVA = "0x9B0450", Offset = "0x9AF450", VA = "0x1809B0450")]
	public void RevertDecor(MaterialGroupPreset.MaterialType decorType)
	{
	}

	// Token: 0x06001B32 RID: 6962 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B32")]
	[Address(RVA = "0x9B08C0", Offset = "0x9AF8C0", VA = "0x1809B08C0")]
	public void PlaceIndividualCluster(FurnitureCluster cluster, NewAddress address, [Optional] DesignStylePreset styleOverride)
	{
	}

	// Token: 0x06001B33 RID: 6963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B33")]
	[Address(RVA = "0x9B0F20", Offset = "0x9AFF20", VA = "0x1809B0F20")]
	public PlayerApartmentController()
	{
	}

	// Token: 0x06001B34 RID: 6964 RVA: 0x0000C930 File Offset: 0x0000AB30
	[Token(Token = "0x6001B34")]
	[Address(RVA = "0x9B1420", Offset = "0x9B0420", VA = "0x1809B1420")]
	private int <SortSwatches>b__43_0(Color p1, Color p2)
	{
		return 0;
	}

	// Token: 0x04002124 RID: 8484
	[Token(Token = "0x4002124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform placementCursor;

	// Token: 0x04002125 RID: 8485
	[Token(Token = "0x4002125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color placementValidLerpColour;

	// Token: 0x04002126 RID: 8486
	[Token(Token = "0x4002126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color placementInvalidLerpColour;

	// Token: 0x04002127 RID: 8487
	[Token(Token = "0x4002127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public FirstPersonItem furnitureFPSItem;

	// Token: 0x04002128 RID: 8488
	[Token(Token = "0x4002128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public FurnitureCluster nullCluster;

	// Token: 0x04002129 RID: 8489
	[Token(Token = "0x4002129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Color> swatches;

	// Token: 0x0400212A RID: 8490
	[Token(Token = "0x400212A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<FurnitureLocation> furnitureStorage;

	// Token: 0x0400212B RID: 8491
	[Token(Token = "0x400212B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Interactable> itemStorage;

	// Token: 0x0400212C RID: 8492
	[Token(Token = "0x400212C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool furniturePlacementMode;

	// Token: 0x0400212D RID: 8493
	[Token(Token = "0x400212D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool placeExistingRoomObject;

	// Token: 0x0400212E RID: 8494
	[Token(Token = "0x400212E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public PlayerApartmentController.FurniturePlacement furnPlacement;

	// Token: 0x0400212F RID: 8495
	[Token(Token = "0x400212F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public NewRoom furnPlacementRoom;

	// Token: 0x04002130 RID: 8496
	[Token(Token = "0x4002130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject spawnedPlacementObj;

	// Token: 0x04002131 RID: 8497
	[Token(Token = "0x4002131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public MeshRenderer spawnedPlacementMesh;

	// Token: 0x04002132 RID: 8498
	[Token(Token = "0x4002132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int furnitureRotation;

	// Token: 0x04002133 RID: 8499
	[Token(Token = "0x4002133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<Material> cloneMaterials;

	// Token: 0x04002134 RID: 8500
	[Token(Token = "0x4002134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<Collider> placementColliders;

	// Token: 0x04002135 RID: 8501
	[Token(Token = "0x4002135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float materialPulse;

	// Token: 0x04002136 RID: 8502
	[Token(Token = "0x4002136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public Color lerpColour;

	// Token: 0x04002137 RID: 8503
	[Token(Token = "0x4002137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public NewNode placementNode;

	// Token: 0x04002138 RID: 8504
	[Token(Token = "0x4002138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool isPlacementValid;

	// Token: 0x04002139 RID: 8505
	[Token(Token = "0x4002139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	public bool decoratingMode;

	// Token: 0x0400213A RID: 8506
	[Token(Token = "0x400213A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public MaterialGroupPreset decoratingMaterial;

	// Token: 0x0400213B RID: 8507
	[Token(Token = "0x400213B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public MaterialGroupPreset.MaterialType decoratingType;

	// Token: 0x0400213C RID: 8508
	[Token(Token = "0x400213C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Toolbox.MaterialKey decoratingKey;

	// Token: 0x0400213D RID: 8509
	[Token(Token = "0x400213D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public NewRoom decoratingRoom;

	// Token: 0x0400213E RID: 8510
	[Token(Token = "0x400213E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public InfoWindow materialKeyWindow;

	// Token: 0x0400213F RID: 8511
	[Token(Token = "0x400213F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public WindowTabPreset.TabContentType rememberContent;

	// Token: 0x04002140 RID: 8512
	[Token(Token = "0x4002140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public MaterialGroupPreset.MaterialType rememberDecorType;

	// Token: 0x04002141 RID: 8513
	[Token(Token = "0x4002141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public FurnishingsController.TabState rememberRoomStorageShop;

	// Token: 0x04002142 RID: 8514
	[Token(Token = "0x4002142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public List<FurniturePreset.DecorClass> rememberDisplayClasses;

	// Token: 0x04002143 RID: 8515
	[Token(Token = "0x4002143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public List<InteractablePreset.ItemClass> rememberItemDisplayClasses;

	// Token: 0x04002145 RID: 8517
	[Token(Token = "0x4002145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PlayerApartmentController _instance;

	// Token: 0x020004BA RID: 1210
	[Token(Token = "0x20004BA")]
	[Serializable]
	public class PlayerFurniture
	{
		// Token: 0x06001B35 RID: 6965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B35")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public PlayerFurniture()
		{
		}

		// Token: 0x04002146 RID: 8518
		[Token(Token = "0x4002146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Toolbox.MaterialKey matKey;

		// Token: 0x04002147 RID: 8519
		[Token(Token = "0x4002147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string presetStr;

		// Token: 0x04002148 RID: 8520
		[Token(Token = "0x4002148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public FurniturePreset preset;

		// Token: 0x04002149 RID: 8521
		[Token(Token = "0x4002149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public FurnitureLocation placement;
	}

	// Token: 0x020004BB RID: 1211
	[Token(Token = "0x20004BB")]
	[Serializable]
	public class FurniturePlacement
	{
		// Token: 0x06001B36 RID: 6966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B36")]
		[Address(RVA = "0x9B1640", Offset = "0x9B0640", VA = "0x1809B1640")]
		public FurniturePlacement()
		{
		}

		// Token: 0x0400214A RID: 8522
		[Token(Token = "0x400214A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurniturePreset preset;

		// Token: 0x0400214B RID: 8523
		[Token(Token = "0x400214B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FurnitureLocation existing;

		// Token: 0x0400214C RID: 8524
		[Token(Token = "0x400214C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Toolbox.MaterialKey materialKey;

		// Token: 0x0400214D RID: 8525
		[Token(Token = "0x400214D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ArtPreset art;

		// Token: 0x0400214E RID: 8526
		[Token(Token = "0x400214E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public NewNode anchorNode;

		// Token: 0x0400214F RID: 8527
		[Token(Token = "0x400214F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<NewNode> coversNodes;

		// Token: 0x04002150 RID: 8528
		[Token(Token = "0x4002150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int angle;

		// Token: 0x04002151 RID: 8529
		[Token(Token = "0x4002151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 offset;
	}

	// Token: 0x020004BC RID: 1212
	// (Invoke) Token: 0x06001B38 RID: 6968
	[Token(Token = "0x20004BC")]
	public delegate void FurnitureChange();

	// Token: 0x020004BD RID: 1213
	[Token(Token = "0x20004BD")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001B3C RID: 6972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0000C948 File Offset: 0x0000AB48
		[Token(Token = "0x6001B3D")]
		[Address(RVA = "0x477780", Offset = "0x476780", VA = "0x180477780")]
		internal bool <SetFurniturePlacementMode>b__46_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0000C960 File Offset: 0x0000AB60
		[Token(Token = "0x6001B3E")]
		[Address(RVA = "0x477780", Offset = "0x476780", VA = "0x180477780")]
		internal bool <SetDecoratingMode>b__48_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0000C978 File Offset: 0x0000AB78
		[Token(Token = "0x6001B3F")]
		[Address(RVA = "0x874F10", Offset = "0x873F10", VA = "0x180874F10")]
		internal bool <Update>b__49_0(AirDuctGroup.AirDuctSection item)
		{
			return default(bool);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0000C990 File Offset: 0x0000AB90
		[Token(Token = "0x6001B40")]
		[Address(RVA = "0x4812A0", Offset = "0x4802A0", VA = "0x1804812A0")]
		internal bool <Update>b__49_1(AirDuctGroup.AirDuctSection item)
		{
			return default(bool);
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		[Token(Token = "0x6001B41")]
		[Address(RVA = "0x9B17F0", Offset = "0x9B07F0", VA = "0x1809B17F0")]
		internal bool <Update>b__49_2(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		[Token(Token = "0x6001B42")]
		[Address(RVA = "0x9B18A0", Offset = "0x9B08A0", VA = "0x1809B18A0")]
		internal bool <RemoveItemFromStorage>b__64_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x04002152 RID: 8530
		[Token(Token = "0x4002152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly PlayerApartmentController.<>c <>9;

		// Token: 0x04002153 RID: 8531
		[Token(Token = "0x4002153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__46_0;

		// Token: 0x04002154 RID: 8532
		[Token(Token = "0x4002154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__48_0;

		// Token: 0x04002155 RID: 8533
		[Token(Token = "0x4002155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<AirDuctGroup.AirDuctSection> <>9__49_0;

		// Token: 0x04002156 RID: 8534
		[Token(Token = "0x4002156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<AirDuctGroup.AirDuctSection> <>9__49_1;

		// Token: 0x04002157 RID: 8535
		[Token(Token = "0x4002157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<FurnitureLocation> <>9__49_2;

		// Token: 0x04002158 RID: 8536
		[Token(Token = "0x4002158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<Interactable.Passed> <>9__64_0;
	}
}
