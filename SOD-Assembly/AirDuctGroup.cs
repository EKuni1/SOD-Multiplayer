using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000FC RID: 252
[Token(Token = "0x20000FC")]
public class AirDuctGroup : Controller
{
	// Token: 0x0600072D RID: 1837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072D")]
	[Address(RVA = "0x4786A0", Offset = "0x4776A0", VA = "0x1804786A0")]
	public void SetupNew(NewBuilding newBuilding)
	{
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072E")]
	[Address(RVA = "0x478890", Offset = "0x477890", VA = "0x180478890")]
	public void Load(CitySaveData.AirDuctGroupCitySave load, NewBuilding newBuilding)
	{
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072F")]
	[Address(RVA = "0x4793F0", Offset = "0x4783F0", VA = "0x1804793F0")]
	public void AddAirDuctSection(int level, Vector3Int duct, Vector3Int previous, Vector3Int next, NewNode newNode, int index = 0)
	{
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000730")]
	[Address(RVA = "0x479780", Offset = "0x478780", VA = "0x180479780")]
	public void AddAirVent(AirDuctGroup.AirVent newVent)
	{
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000731")]
	[Address(RVA = "0x479900", Offset = "0x478900", VA = "0x180479900")]
	public void AddAdjoiningDuctGroup(AirDuctGroup ductGroup)
	{
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000732")]
	[Address(RVA = "0x4799B0", Offset = "0x4789B0", VA = "0x1804799B0")]
	public void LoadDucts()
	{
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000733")]
	[Address(RVA = "0x47C850", Offset = "0x47B850", VA = "0x18047C850")]
	public void SetVisible(bool newVis, bool forceUpdate = false)
	{
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000734")]
	[Address(RVA = "0x47CEE0", Offset = "0x47BEE0", VA = "0x18047CEE0")]
	public List<Vector3Int> GetDuctOffsets(NewNode thisNode, AirDuctGroup.AirDuctSection duct)
	{
		return null;
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000735")]
	[Address(RVA = "0x47E2E0", Offset = "0x47D2E0", VA = "0x18047E2E0")]
	public CitySaveData.AirDuctGroupCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000736")]
	[Address(RVA = "0x47E8F0", Offset = "0x47D8F0", VA = "0x18047E8F0")]
	public AirDuctGroup()
	{
	}

	// Token: 0x04000740 RID: 1856
	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0x18")]
	public int ductID;

	// Token: 0x04000741 RID: 1857
	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0x0")]
	public static int assignID;

	// Token: 0x04000742 RID: 1858
	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0x20")]
	public NewBuilding building;

	// Token: 0x04000743 RID: 1859
	[Token(Token = "0x4000743")]
	[FieldOffset(Offset = "0x28")]
	public bool isExterior;

	// Token: 0x04000744 RID: 1860
	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0x29")]
	public bool isVisible;

	// Token: 0x04000745 RID: 1861
	[Token(Token = "0x4000745")]
	[FieldOffset(Offset = "0x30")]
	public List<AirDuctGroup.AirVent> airVents;

	// Token: 0x04000746 RID: 1862
	[Token(Token = "0x4000746")]
	[FieldOffset(Offset = "0x38")]
	public List<AirDuctGroup.AirDuctSection> airDucts;

	// Token: 0x04000747 RID: 1863
	[Token(Token = "0x4000747")]
	[FieldOffset(Offset = "0x40")]
	public MeshFilter meshFilter;

	// Token: 0x04000748 RID: 1864
	[Token(Token = "0x4000748")]
	[FieldOffset(Offset = "0x48")]
	public MeshRenderer combinedMesh;

	// Token: 0x04000749 RID: 1865
	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0x50")]
	public List<AirDuctGroup> adjoiningGroups;

	// Token: 0x0400074A RID: 1866
	[Token(Token = "0x400074A")]
	[FieldOffset(Offset = "0x58")]
	public List<NewRoom> ventRooms;

	// Token: 0x020000FD RID: 253
	[Token(Token = "0x20000FD")]
	[Serializable]
	public class AirVent
	{
		// Token: 0x06000738 RID: 1848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x47EC20", Offset = "0x47DC20", VA = "0x18047EC20")]
		public AirVent(NewAddress.AirVent newType, NewRoom newRoom)
		{
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x47ED50", Offset = "0x47DD50", VA = "0x18047ED50")]
		public void SetDiscovered(bool val)
		{
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x47EEE0", Offset = "0x47DEE0", VA = "0x18047EEE0")]
		public AirVent(CitySaveData.AirVentSave load)
		{
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x47EF90", Offset = "0x47DF90", VA = "0x18047EF90")]
		public void Remove()
		{
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x47F490", Offset = "0x47E490", VA = "0x18047F490")]
		public AirDuctGroup.AirDuctSection GetDuctSection()
		{
			return null;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x47F630", Offset = "0x47E630", VA = "0x18047F630")]
		private bool <GetDuctSection>b__18_0(AirDuctGroup.AirDuctSection item)
		{
			return default(bool);
		}

		// Token: 0x0400074B RID: 1867
		[Token(Token = "0x400074B")]
		[FieldOffset(Offset = "0x10")]
		public int ventID;

		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x400074C")]
		[FieldOffset(Offset = "0x0")]
		public static int assignVentID;

		// Token: 0x0400074D RID: 1869
		[Token(Token = "0x400074D")]
		[FieldOffset(Offset = "0x14")]
		public NewAddress.AirVent ventType;

		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x400074E")]
		[FieldOffset(Offset = "0x18")]
		public NewWall wall;

		// Token: 0x0400074F RID: 1871
		[Token(Token = "0x400074F")]
		[FieldOffset(Offset = "0x20")]
		public NewNode node;

		// Token: 0x04000750 RID: 1872
		[Token(Token = "0x4000750")]
		[FieldOffset(Offset = "0x28")]
		public NewNode roomNode;

		// Token: 0x04000751 RID: 1873
		[Token(Token = "0x4000751")]
		[FieldOffset(Offset = "0x30")]
		public NewRoom room;

		// Token: 0x04000752 RID: 1874
		[Token(Token = "0x4000752")]
		[FieldOffset(Offset = "0x38")]
		public AirDuctGroup group;

		// Token: 0x04000753 RID: 1875
		[Token(Token = "0x4000753")]
		[FieldOffset(Offset = "0x40")]
		public MapDuctsButtonController mapButton;

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0x48")]
		public bool discovered;

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0x49")]
		public bool removed;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x50")]
		public InteractableController spawned;

		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0x58")]
		public Vector3 debugNode;

		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4000758")]
		[FieldOffset(Offset = "0x64")]
		public Vector3 debugRoomNode;
	}

	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	[Serializable]
	public class AirDuctSection
	{
		// Token: 0x0600073E RID: 1854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x47F6E0", Offset = "0x47E6E0", VA = "0x18047F6E0")]
		public AirDuctSection(int newLevel, int newIndex, Vector3Int newDuct, Vector3Int newPrevious, Vector3Int newNext, NewNode newNode, AirDuctGroup newGroup, bool newPeek, Vector3Int newAdditionalRot)
		{
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x47FA80", Offset = "0x47EA80", VA = "0x18047FA80")]
		public void SetDiscovered(bool val)
		{
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x47FC70", Offset = "0x47EC70", VA = "0x18047FC70")]
		public List<AirDuctGroup.AirDuctSection> GetNeighborSections(out List<Vector3Int> relativeOffsets, out List<AirDuctGroup.AirVent> vents, out List<Vector3Int> ventRelativeOffsets)
		{
			return null;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x4807E0", Offset = "0x47F7E0", VA = "0x1804807E0")]
		public List<AirDuctGroup.AirVent> FindVents(out List<Vector3Int> ventRelativeOffsets)
		{
			return null;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x480DE0", Offset = "0x47FDE0", VA = "0x180480DE0")]
		public Vector3 GetWorldPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x480F50", Offset = "0x47FF50", VA = "0x180480F50")]
		private bool <GetNeighborSections>b__14_0(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x480F50", Offset = "0x47FF50", VA = "0x180480F50")]
		private bool <FindVents>b__15_0(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		[FieldOffset(Offset = "0x10")]
		public int level;

		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x400075A")]
		[FieldOffset(Offset = "0x14")]
		public int index;

		// Token: 0x0400075B RID: 1883
		[Token(Token = "0x400075B")]
		[FieldOffset(Offset = "0x18")]
		public Vector3Int duct;

		// Token: 0x0400075C RID: 1884
		[Token(Token = "0x400075C")]
		[FieldOffset(Offset = "0x24")]
		public Vector3Int previous;

		// Token: 0x0400075D RID: 1885
		[Token(Token = "0x400075D")]
		[FieldOffset(Offset = "0x30")]
		public Vector3Int next;

		// Token: 0x0400075E RID: 1886
		[Token(Token = "0x400075E")]
		[FieldOffset(Offset = "0x3C")]
		public bool ext;

		// Token: 0x0400075F RID: 1887
		[Token(Token = "0x400075F")]
		[FieldOffset(Offset = "0x3D")]
		public bool peekSection;

		// Token: 0x04000760 RID: 1888
		[Token(Token = "0x4000760")]
		[FieldOffset(Offset = "0x40")]
		public Vector3Int additionalRot;

		// Token: 0x04000761 RID: 1889
		[Token(Token = "0x4000761")]
		[FieldOffset(Offset = "0x50")]
		public NewNode node;

		// Token: 0x04000762 RID: 1890
		[Token(Token = "0x4000762")]
		[FieldOffset(Offset = "0x58")]
		public AirDuctGroup group;

		// Token: 0x04000763 RID: 1891
		[Token(Token = "0x4000763")]
		[FieldOffset(Offset = "0x60")]
		public MapDuctsButtonController mapButton;

		// Token: 0x04000764 RID: 1892
		[Token(Token = "0x4000764")]
		[FieldOffset(Offset = "0x68")]
		public bool discovered;

		// Token: 0x020000FF RID: 255
		[Token(Token = "0x20000FF")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06000745 RID: 1861 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x06000746 RID: 1862 RVA: 0x00004DB8 File Offset: 0x00002FB8
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x480F80", Offset = "0x47FF80", VA = "0x180480F80")]
			internal bool <GetNeighborSections>b__1(AirDuctGroup.AirVent item)
			{
				return default(bool);
			}

			// Token: 0x04000765 RID: 1893
			[Token(Token = "0x4000765")]
			[FieldOffset(Offset = "0x10")]
			public NewNode foundNode;

			// Token: 0x04000766 RID: 1894
			[Token(Token = "0x4000766")]
			[FieldOffset(Offset = "0x18")]
			public AirDuctGroup.AirDuctSection <>4__this;
		}

		// Token: 0x02000100 RID: 256
		[Token(Token = "0x2000100")]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x06000747 RID: 1863 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x06000748 RID: 1864 RVA: 0x00004DD0 File Offset: 0x00002FD0
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x480F80", Offset = "0x47FF80", VA = "0x180480F80")]
			internal bool <FindVents>b__1(AirDuctGroup.AirVent item)
			{
				return default(bool);
			}

			// Token: 0x04000767 RID: 1895
			[Token(Token = "0x4000767")]
			[FieldOffset(Offset = "0x10")]
			public NewNode foundNode;

			// Token: 0x04000768 RID: 1896
			[Token(Token = "0x4000768")]
			[FieldOffset(Offset = "0x18")]
			public AirDuctGroup.AirDuctSection <>4__this;
		}
	}

	// Token: 0x02000101 RID: 257
	[Token(Token = "0x2000101")]
	private sealed class <>c__DisplayClass14_0
	{
		// Token: 0x06000749 RID: 1865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass14_0()
		{
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <Load>b__0(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x04000769 RID: 1897
		[Token(Token = "0x4000769")]
		[FieldOffset(Offset = "0x10")]
		public int ventID;
	}

	// Token: 0x02000102 RID: 258
	[Token(Token = "0x2000102")]
	private sealed class <>c__DisplayClass15_0
	{
		// Token: 0x0600074B RID: 1867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass15_0()
		{
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x480FE0", Offset = "0x47FFE0", VA = "0x180480FE0")]
		internal bool <AddAirDuctSection>b__0(AirDuctGroup.AirDuctSection item)
		{
			return default(bool);
		}

		// Token: 0x0400076A RID: 1898
		[Token(Token = "0x400076A")]
		[FieldOffset(Offset = "0x10")]
		public int level;

		// Token: 0x0400076B RID: 1899
		[Token(Token = "0x400076B")]
		[FieldOffset(Offset = "0x18")]
		public NewNode newNode;
	}

	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000103")]
	private sealed class <>c__DisplayClass18_0
	{
		// Token: 0x0600074D RID: 1869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass18_0()
		{
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00004E18 File Offset: 0x00003018
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x481010", Offset = "0x480010", VA = "0x180481010")]
		internal bool <LoadDucts>b__0(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x0400076C RID: 1900
		[Token(Token = "0x400076C")]
		[FieldOffset(Offset = "0x10")]
		public AirDuctGroup.AirDuctSection duct;

		// Token: 0x0400076D RID: 1901
		[Token(Token = "0x400076D")]
		[FieldOffset(Offset = "0x18")]
		public Predicate<AirDuctGroup.AirVent> <>9__0;
	}

	// Token: 0x02000104 RID: 260
	[Token(Token = "0x2000104")]
	private sealed class <>c__DisplayClass18_1
	{
		// Token: 0x0600074F RID: 1871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass18_1()
		{
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x481050", Offset = "0x480050", VA = "0x180481050")]
		internal bool <LoadDucts>b__1(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00004E48 File Offset: 0x00003048
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x4810A0", Offset = "0x4800A0", VA = "0x1804810A0")]
		internal bool <LoadDucts>b__2(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x0400076E RID: 1902
		[Token(Token = "0x400076E")]
		[FieldOffset(Offset = "0x10")]
		public NewNode foundNode;

		// Token: 0x0400076F RID: 1903
		[Token(Token = "0x400076F")]
		[FieldOffset(Offset = "0x18")]
		public AirDuctGroup.<>c__DisplayClass18_0 CS$<>8__locals1;
	}

	// Token: 0x02000105 RID: 261
	[Token(Token = "0x2000105")]
	private sealed class <>c__DisplayClass20_0
	{
		// Token: 0x06000752 RID: 1874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass20_0()
		{
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00004E60 File Offset: 0x00003060
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x4810F0", Offset = "0x4800F0", VA = "0x1804810F0")]
		internal bool <GetDuctOffsets>b__0(AirDuctGroup.AirDuctSection item)
		{
			return default(bool);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x481120", Offset = "0x480120", VA = "0x180481120")]
		internal bool <GetDuctOffsets>b__1(AirDuctGroup.AirDuctSection item)
		{
			return default(bool);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x481150", Offset = "0x480150", VA = "0x180481150")]
		internal bool <GetDuctOffsets>b__3(AirDuctGroup.AirDuctSection item)
		{
			return default(bool);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00004EA8 File Offset: 0x000030A8
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x481180", Offset = "0x480180", VA = "0x180481180")]
		internal bool <GetDuctOffsets>b__5(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x4811B0", Offset = "0x4801B0", VA = "0x1804811B0")]
		internal bool <GetDuctOffsets>b__6(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x04000770 RID: 1904
		[Token(Token = "0x4000770")]
		[FieldOffset(Offset = "0x10")]
		public AirDuctGroup.AirDuctSection duct;

		// Token: 0x04000771 RID: 1905
		[Token(Token = "0x4000771")]
		[FieldOffset(Offset = "0x18")]
		public NewNode thisNode;

		// Token: 0x04000772 RID: 1906
		[Token(Token = "0x4000772")]
		[FieldOffset(Offset = "0x20")]
		public Predicate<AirDuctGroup.AirDuctSection> <>9__0;

		// Token: 0x04000773 RID: 1907
		[Token(Token = "0x4000773")]
		[FieldOffset(Offset = "0x28")]
		public Predicate<AirDuctGroup.AirVent> <>9__6;
	}

	// Token: 0x02000106 RID: 262
	[Token(Token = "0x2000106")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000759 RID: 1881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x481280", Offset = "0x480280", VA = "0x180481280")]
		internal bool <GetDuctOffsets>b__20_2(AirDuctGroup.AirDuctSection item)
		{
			return default(bool);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x4812A0", Offset = "0x4802A0", VA = "0x1804812A0")]
		internal bool <GetDuctOffsets>b__20_4(AirDuctGroup.AirDuctSection item)
		{
			return default(bool);
		}

		// Token: 0x04000774 RID: 1908
		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AirDuctGroup.<>c <>9;

		// Token: 0x04000775 RID: 1909
		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<AirDuctGroup.AirDuctSection> <>9__20_2;

		// Token: 0x04000776 RID: 1910
		[Token(Token = "0x4000776")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<AirDuctGroup.AirDuctSection> <>9__20_4;
	}
}
