using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003D1 RID: 977
[Token(Token = "0x20003D1")]
public class NewFloor : Controller
{
	// Token: 0x14000022 RID: 34
	// (add) Token: 0x060015E0 RID: 5600 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060015E1 RID: 5601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000022")]
	public event NewFloor.SaveDataComplete OnSaveDataComplete
	{
		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x820760", Offset = "0x81F760", VA = "0x180820760")]
		add
		{
		}
		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x820860", Offset = "0x81F860", VA = "0x180820860")]
		remove
		{
		}
	}

	// Token: 0x060015E2 RID: 5602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015E2")]
	[Address(RVA = "0x820960", Offset = "0x81F960", VA = "0x180820960")]
	public void Setup(int newFloor, NewBuilding newBuilding, string newName, Vector2 newSize, int newFloorHeight, int newCeilingHeight)
	{
	}

	// Token: 0x060015E3 RID: 5603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015E3")]
	[Address(RVA = "0x821AA0", Offset = "0x820AA0", VA = "0x180821AA0")]
	public void Load(CitySaveData.FloorCitySave data, NewBuilding newBuilding)
	{
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015E4")]
	[Address(RVA = "0x822DA0", Offset = "0x821DA0", VA = "0x180822DA0")]
	public void AddNewAddress(NewAddress newAddress)
	{
	}

	// Token: 0x060015E5 RID: 5605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015E5")]
	[Address(RVA = "0x823320", Offset = "0x822320", VA = "0x180823320")]
	public void RemoveAddress(NewAddress newAddress)
	{
	}

	// Token: 0x060015E6 RID: 5606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015E6")]
	[Address(RVA = "0x823490", Offset = "0x822490", VA = "0x180823490")]
	public void GetSaveData()
	{
	}

	// Token: 0x060015E7 RID: 5607 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015E7")]
	[Address(RVA = "0x823540", Offset = "0x822540", VA = "0x180823540")]
	private IEnumerator GenerateFloorSaveData()
	{
		return null;
	}

	// Token: 0x060015E8 RID: 5608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015E8")]
	[Address(RVA = "0x8235E0", Offset = "0x8225E0", VA = "0x1808235E0")]
	public void LoadDataToFloor(FloorSaveData savedData)
	{
	}

	// Token: 0x060015E9 RID: 5609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015E9")]
	[Address(RVA = "0x823D60", Offset = "0x822D60", VA = "0x180823D60")]
	public void LoadVariation(NewAddress currentAdd, AddressLayoutVariation newVar)
	{
	}

	// Token: 0x060015EA RID: 5610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015EA")]
	[Address(RVA = "0x8245D0", Offset = "0x8235D0", VA = "0x1808245D0")]
	public void FinalizeLoadingIn()
	{
	}

	// Token: 0x060015EB RID: 5611 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015EB")]
	[Address(RVA = "0x825870", Offset = "0x824870", VA = "0x180825870")]
	public NewAddress CreateNewAddress(LayoutConfiguration newRoomConfig, DesignStylePreset newDesign)
	{
		return null;
	}

	// Token: 0x060015EC RID: 5612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015EC")]
	[Address(RVA = "0x825B40", Offset = "0x824B40", VA = "0x180825B40")]
	public void ConnectNodesOnFloor()
	{
	}

	// Token: 0x060015ED RID: 5613 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015ED")]
	[Address(RVA = "0x826310", Offset = "0x825310", VA = "0x180826310")]
	public void AssignWindowUVData(bool debug = false)
	{
	}

	// Token: 0x060015EE RID: 5614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015EE")]
	[Address(RVA = "0x8285F0", Offset = "0x8275F0", VA = "0x1808285F0")]
	public void GenerateAirDucts()
	{
	}

	// Token: 0x060015EF RID: 5615 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015EF")]
	[Address(RVA = "0x828740", Offset = "0x827740", VA = "0x180828740")]
	public void AddSecurityDoor(Interactable newInteractable)
	{
	}

	// Token: 0x060015F0 RID: 5616 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015F0")]
	[Address(RVA = "0x8287A0", Offset = "0x8277A0", VA = "0x1808287A0")]
	public NewAddress GetLobbyAddress()
	{
		return null;
	}

	// Token: 0x060015F1 RID: 5617 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015F1")]
	[Address(RVA = "0x8289D0", Offset = "0x8279D0", VA = "0x1808289D0")]
	public void SetAlarmLockdown(bool newVal, [Optional] NewAddress addressOnly)
	{
	}

	// Token: 0x060015F2 RID: 5618 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015F2")]
	[Address(RVA = "0x829670", Offset = "0x828670", VA = "0x180829670")]
	public CitySaveData.FloorCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015F3")]
	[Address(RVA = "0x829C50", Offset = "0x828C50", VA = "0x180829C50")]
	public void DebugWindowUVAssign()
	{
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015F4")]
	[Address(RVA = "0x829C60", Offset = "0x828C60", VA = "0x180829C60")]
	public void SetBreakerSecurity(Interactable newObject)
	{
	}

	// Token: 0x060015F5 RID: 5621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015F5")]
	[Address(RVA = "0x829CD0", Offset = "0x828CD0", VA = "0x180829CD0")]
	public void SetBreakerLights(Interactable newObject)
	{
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015F6")]
	[Address(RVA = "0x829D40", Offset = "0x828D40", VA = "0x180829D40")]
	public void SetBreakerDoors(Interactable newObject)
	{
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015F7")]
	[Address(RVA = "0x829DB0", Offset = "0x828DB0", VA = "0x180829DB0")]
	public Interactable GetBreakerSecurity()
	{
		return null;
	}

	// Token: 0x060015F8 RID: 5624 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015F8")]
	[Address(RVA = "0x829F40", Offset = "0x828F40", VA = "0x180829F40")]
	public Interactable GetBreakerLights()
	{
		return null;
	}

	// Token: 0x060015F9 RID: 5625 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015F9")]
	[Address(RVA = "0x82A0D0", Offset = "0x8290D0", VA = "0x18082A0D0")]
	public Interactable GetBreakerDoors()
	{
		return null;
	}

	// Token: 0x060015FA RID: 5626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015FA")]
	[Address(RVA = "0x82A260", Offset = "0x829260", VA = "0x18082A260")]
	public NewFloor()
	{
	}

	// Token: 0x060015FB RID: 5627 RVA: 0x0000A320 File Offset: 0x00008520
	[Token(Token = "0x60015FB")]
	[Address(RVA = "0x82A900", Offset = "0x829900", VA = "0x18082A900")]
	private int <AssignWindowUVData>b__50_0(NewWall p1, NewWall p2)
	{
		return 0;
	}

	// Token: 0x060015FC RID: 5628 RVA: 0x0000A338 File Offset: 0x00008538
	[Token(Token = "0x60015FC")]
	[Address(RVA = "0x82AA40", Offset = "0x829A40", VA = "0x18082AA40")]
	private int <AssignWindowUVData>b__50_1(NewWall p1, NewWall p2)
	{
		return 0;
	}

	// Token: 0x060015FD RID: 5629 RVA: 0x0000A350 File Offset: 0x00008550
	[Token(Token = "0x60015FD")]
	[Address(RVA = "0x82AB80", Offset = "0x829B80", VA = "0x18082AB80")]
	private int <AssignWindowUVData>b__50_2(NewWall p1, NewWall p2)
	{
		return 0;
	}

	// Token: 0x060015FE RID: 5630 RVA: 0x0000A368 File Offset: 0x00008568
	[Token(Token = "0x60015FE")]
	[Address(RVA = "0x82ACC0", Offset = "0x829CC0", VA = "0x18082ACC0")]
	private int <AssignWindowUVData>b__50_3(NewWall p1, NewWall p2)
	{
		return 0;
	}

	// Token: 0x060015FF RID: 5631 RVA: 0x0000A380 File Offset: 0x00008580
	[Token(Token = "0x60015FF")]
	[Address(RVA = "0x82AE00", Offset = "0x829E00", VA = "0x18082AE00")]
	private bool <GetBreakerSecurity>b__60_0(Interactable item)
	{
		return default(bool);
	}

	// Token: 0x06001600 RID: 5632 RVA: 0x0000A398 File Offset: 0x00008598
	[Token(Token = "0x6001600")]
	[Address(RVA = "0x82AE20", Offset = "0x829E20", VA = "0x18082AE20")]
	private bool <GetBreakerLights>b__61_0(Interactable item)
	{
		return default(bool);
	}

	// Token: 0x06001601 RID: 5633 RVA: 0x0000A3B0 File Offset: 0x000085B0
	[Token(Token = "0x6001601")]
	[Address(RVA = "0x82AE40", Offset = "0x829E40", VA = "0x18082AE40")]
	private bool <GetBreakerDoors>b__62_0(Interactable item)
	{
		return default(bool);
	}

	// Token: 0x04001A7C RID: 6780
	[Token(Token = "0x4001A7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int floorID;

	// Token: 0x04001A7D RID: 6781
	[Token(Token = "0x4001A7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int assignID;

	// Token: 0x04001A7E RID: 6782
	[Token(Token = "0x4001A7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public NewBuilding building;

	// Token: 0x04001A7F RID: 6783
	[Token(Token = "0x4001A7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int floor;

	// Token: 0x04001A80 RID: 6784
	[Token(Token = "0x4001A80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int assignResidence;

	// Token: 0x04001A81 RID: 6785
	[Token(Token = "0x4001A81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<NewAddress> addresses;

	// Token: 0x04001A82 RID: 6786
	[Token(Token = "0x4001A82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public NewAddress lobbyAddress;

	// Token: 0x04001A83 RID: 6787
	[Token(Token = "0x4001A83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public NewAddress outsideAddress;

	// Token: 0x04001A84 RID: 6788
	[Token(Token = "0x4001A84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Dictionary<Vector2Int, NewTile> tileMap;

	// Token: 0x04001A85 RID: 6789
	[Token(Token = "0x4001A85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Dictionary<Vector2Int, NewNode> nodeMap;

	// Token: 0x04001A86 RID: 6790
	[Token(Token = "0x4001A86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<NewWall> buildingEntrances;

	// Token: 0x04001A87 RID: 6791
	[Token(Token = "0x4001A87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Interactable> securityDoors;

	// Token: 0x04001A88 RID: 6792
	[Token(Token = "0x4001A88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool alarmLockdown;

	// Token: 0x04001A89 RID: 6793
	[Token(Token = "0x4001A89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int layoutIndex;

	// Token: 0x04001A8A RID: 6794
	[Token(Token = "0x4001A8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int breakerSecurityID;

	// Token: 0x04001A8B RID: 6795
	[Token(Token = "0x4001A8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int breakerDoorsID;

	// Token: 0x04001A8C RID: 6796
	[Token(Token = "0x4001A8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int breakerLightsID;

	// Token: 0x04001A8D RID: 6797
	[Token(Token = "0x4001A8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[NonSerialized]
	public Interactable breakerSecurity;

	// Token: 0x04001A8E RID: 6798
	[Token(Token = "0x4001A8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[NonSerialized]
	public Interactable breakerDoors;

	// Token: 0x04001A8F RID: 6799
	[Token(Token = "0x4001A8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[NonSerialized]
	public Interactable breakerLights;

	// Token: 0x04001A90 RID: 6800
	[Token(Token = "0x4001A90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float breakerSecurityState;

	// Token: 0x04001A91 RID: 6801
	[Token(Token = "0x4001A91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float breakerLightsState;

	// Token: 0x04001A92 RID: 6802
	[Token(Token = "0x4001A92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float breakerDoorsState;

	// Token: 0x04001A93 RID: 6803
	[Token(Token = "0x4001A93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public string floorName;

	// Token: 0x04001A94 RID: 6804
	[Token(Token = "0x4001A94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Vector2 size;

	// Token: 0x04001A95 RID: 6805
	[Token(Token = "0x4001A95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public int defaultFloorHeight;

	// Token: 0x04001A96 RID: 6806
	[Token(Token = "0x4001A96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public int defaultCeilingHeight;

	// Token: 0x04001A97 RID: 6807
	[Token(Token = "0x4001A97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public bool isEchelons;

	// Token: 0x04001A98 RID: 6808
	[Token(Token = "0x4001A98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public MapDuctsButtonController mapDucts;

	// Token: 0x04001A99 RID: 6809
	[Token(Token = "0x4001A99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public int maxDuctExtrusion;

	// Token: 0x04001A9A RID: 6810
	[Token(Token = "0x4001A9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private FloorSaveData saveData;

	// Token: 0x04001A9B RID: 6811
	[Token(Token = "0x4001A9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public List<NewRoom> frontWindowDebug;

	// Token: 0x04001A9C RID: 6812
	[Token(Token = "0x4001A9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public List<NewRoom> rearWindowDebug;

	// Token: 0x04001A9D RID: 6813
	[Token(Token = "0x4001A9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<NewRoom> leftWindowDebug;

	// Token: 0x04001A9E RID: 6814
	[Token(Token = "0x4001A9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public List<NewRoom> rightWindowDebug;

	// Token: 0x020003D2 RID: 978
	// (Invoke) Token: 0x06001603 RID: 5635
	[Token(Token = "0x20003D2")]
	public delegate void SaveDataComplete(NewFloor floor, FloorSaveData data);

	// Token: 0x020003D3 RID: 979
	[Token(Token = "0x20003D3")]
	private sealed class <GenerateFloorSaveData>d__44 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001606 RID: 5638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <GenerateFloorSaveData>d__44(int <>1__state)
		{
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x861B20", Offset = "0x860B20", VA = "0x180861B20", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x0000A3C8 File Offset: 0x000085C8
		[Token(Token = "0x6001608")]
		[Address(RVA = "0x861BE0", Offset = "0x860BE0", VA = "0x180861BE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x863450", Offset = "0x862450", VA = "0x180863450")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000BC")]
		private object Current
		{
			[Token(Token = "0x600160A")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600160B")]
		[Address(RVA = "0x8634A0", Offset = "0x8624A0", VA = "0x1808634A0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000BD")]
		private object Current
		{
			[Token(Token = "0x600160C")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001AA0 RID: 6816
		[Token(Token = "0x4001AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001AA1 RID: 6817
		[Token(Token = "0x4001AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001AA2 RID: 6818
		[Token(Token = "0x4001AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NewFloor <>4__this;

		// Token: 0x04001AA3 RID: 6819
		[Token(Token = "0x4001AA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<NewAddress>.Enumerator <>7__wrap1;

		// Token: 0x04001AA4 RID: 6820
		[Token(Token = "0x4001AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private NewAddress <ad>5__3;
	}

	// Token: 0x020003D4 RID: 980
	[Token(Token = "0x20003D4")]
	private sealed class <>c__DisplayClass47_0
	{
		// Token: 0x0600160D RID: 5645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600160D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass47_0()
		{
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[Token(Token = "0x600160E")]
		[Address(RVA = "0x8634F0", Offset = "0x8624F0", VA = "0x1808634F0")]
		internal bool <FinalizeLoadingIn>b__0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001AA5 RID: 6821
		[Token(Token = "0x4001AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 facedWallOffset;
	}

	// Token: 0x020003D5 RID: 981
	[Token(Token = "0x20003D5")]
	private sealed class <>c__DisplayClass50_0
	{
		// Token: 0x0600160F RID: 5647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600160F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass50_0()
		{
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x0000A3F8 File Offset: 0x000085F8
		[Token(Token = "0x6001610")]
		[Address(RVA = "0x863540", Offset = "0x862540", VA = "0x180863540")]
		internal bool <AssignWindowUVData>b__4(BuildingPreset.WindowUVBlock item)
		{
			return default(bool);
		}

		// Token: 0x04001AA6 RID: 6822
		[Token(Token = "0x4001AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;
	}

	// Token: 0x020003D6 RID: 982
	[Token(Token = "0x20003D6")]
	private sealed class <>c__DisplayClass50_1
	{
		// Token: 0x06001611 RID: 5649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001611")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass50_1()
		{
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x0000A410 File Offset: 0x00008610
		[Token(Token = "0x6001612")]
		[Address(RVA = "0x863540", Offset = "0x862540", VA = "0x180863540")]
		internal bool <AssignWindowUVData>b__5(BuildingPreset.WindowUVBlock item)
		{
			return default(bool);
		}

		// Token: 0x04001AA7 RID: 6823
		[Token(Token = "0x4001AA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;
	}

	// Token: 0x020003D7 RID: 983
	[Token(Token = "0x20003D7")]
	private sealed class <>c__DisplayClass50_2
	{
		// Token: 0x06001613 RID: 5651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001613")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass50_2()
		{
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x0000A428 File Offset: 0x00008628
		[Token(Token = "0x6001614")]
		[Address(RVA = "0x863540", Offset = "0x862540", VA = "0x180863540")]
		internal bool <AssignWindowUVData>b__6(BuildingPreset.WindowUVBlock item)
		{
			return default(bool);
		}

		// Token: 0x04001AA8 RID: 6824
		[Token(Token = "0x4001AA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;
	}

	// Token: 0x020003D8 RID: 984
	[Token(Token = "0x20003D8")]
	private sealed class <>c__DisplayClass50_3
	{
		// Token: 0x06001615 RID: 5653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001615")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass50_3()
		{
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x0000A440 File Offset: 0x00008640
		[Token(Token = "0x6001616")]
		[Address(RVA = "0x863540", Offset = "0x862540", VA = "0x180863540")]
		internal bool <AssignWindowUVData>b__7(BuildingPreset.WindowUVBlock item)
		{
			return default(bool);
		}

		// Token: 0x04001AA9 RID: 6825
		[Token(Token = "0x4001AA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;
	}

	// Token: 0x020003D9 RID: 985
	[Token(Token = "0x20003D9")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001618 RID: 5656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001618")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x0000A458 File Offset: 0x00008658
		[Token(Token = "0x6001619")]
		[Address(RVA = "0x863610", Offset = "0x862610", VA = "0x180863610")]
		internal bool <GetLobbyAddress>b__53_0(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x04001AAA RID: 6826
		[Token(Token = "0x4001AAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly NewFloor.<>c <>9;

		// Token: 0x04001AAB RID: 6827
		[Token(Token = "0x4001AAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<NewAddress> <>9__53_0;
	}
}
