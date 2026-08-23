using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x020009C9 RID: 2505
	[Token(Token = "0x20009C9")]
	public class ObjectBuilder
	{
		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700055D")]
		public Dictionary<string, Material> ImportedMaterials
		{
			[Token(Token = "0x6003581")]
			[Address(RVA = "0xD166E0", Offset = "0xD156E0", VA = "0x180D166E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06003582 RID: 13698 RVA: 0x00012990 File Offset: 0x00010B90
		[Token(Token = "0x1700055E")]
		public int NumImportedMaterials
		{
			[Token(Token = "0x6003582")]
			[Address(RVA = "0xD755A0", Offset = "0xD745A0", VA = "0x180D755A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003583")]
		[Address(RVA = "0xD755F0", Offset = "0xD745F0", VA = "0x180D755F0")]
		public void InitBuildMaterials(List<MaterialData> materialData, bool hasColors)
		{
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x000129A8 File Offset: 0x00010BA8
		[Token(Token = "0x6003584")]
		[Address(RVA = "0xD759C0", Offset = "0xD749C0", VA = "0x180D759C0")]
		public bool BuildMaterials(ObjectBuilder.ProgressInfo info)
		{
			return default(bool);
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003585")]
		[Address(RVA = "0xD75C10", Offset = "0xD74C10", VA = "0x180D75C10")]
		public void StartBuildObjectAsync(DataSet dataSet, GameObject parentObj, [Optional] Dictionary<string, Material> materials)
		{
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x000129C0 File Offset: 0x00010BC0
		[Token(Token = "0x6003586")]
		[Address(RVA = "0xD75D10", Offset = "0xD74D10", VA = "0x180D75D10")]
		public bool BuildObjectAsync(ref ObjectBuilder.ProgressInfo info)
		{
			return default(bool);
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003587")]
		[Address(RVA = "0xD75D90", Offset = "0xD74D90", VA = "0x180D75D90")]
		public static void Solve(Mesh origMesh)
		{
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003588")]
		[Address(RVA = "0xD76960", Offset = "0xD75960", VA = "0x180D76960")]
		public static void BuildMeshCollider(GameObject targetObject, bool convex = false, bool isTrigger = false, bool inflateMesh = false, float skinWidth = 0.01f)
		{
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x000129D8 File Offset: 0x00010BD8
		[Token(Token = "0x6003589")]
		[Address(RVA = "0xD76C70", Offset = "0xD75C70", VA = "0x180D76C70")]
		protected bool BuildNextObject(GameObject parentObj, Dictionary<string, Material> mats)
		{
			return default(bool);
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600358A")]
		[Address(RVA = "0xD77D60", Offset = "0xD76D60", VA = "0x180D77D60")]
		private GameObject ImportSubObject(GameObject parentObj, DataSet.ObjectData objData, Dictionary<string, Material> mats)
		{
			return null;
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600358B")]
		[Address(RVA = "0xD79590", Offset = "0xD78590", VA = "0x180D79590")]
		private Material BuildMaterial(MaterialData md)
		{
			return null;
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x000129F0 File Offset: 0x00010BF0
		[Token(Token = "0x600358C")]
		[Address(RVA = "0xD7A7F0", Offset = "0xD797F0", VA = "0x180D7A7F0")]
		private bool Using32bitIndices()
		{
			return default(bool);
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358D")]
		[Address(RVA = "0xD7A810", Offset = "0xD79810", VA = "0x180D7A810")]
		public ObjectBuilder()
		{
		}

		// Token: 0x0400526E RID: 21102
		[Token(Token = "0x400526E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ImportOptions buildOptions;

		// Token: 0x0400526F RID: 21103
		[Token(Token = "0x400526F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ObjectBuilder.BuildStatus buildStatus;

		// Token: 0x04005270 RID: 21104
		[Token(Token = "0x4005270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DataSet currDataSet;

		// Token: 0x04005271 RID: 21105
		[Token(Token = "0x4005271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject currParentObj;

		// Token: 0x04005272 RID: 21106
		[Token(Token = "0x4005272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, Material> currMaterials;

		// Token: 0x04005273 RID: 21107
		[Token(Token = "0x4005273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<MaterialData> materialData;

		// Token: 0x04005274 RID: 21108
		[Token(Token = "0x4005274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int MAX_VERTICES_LIMIT_FOR_A_MESH;

		// Token: 0x04005275 RID: 21109
		[Token(Token = "0x4005275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int MAX_INDICES_LIMIT_FOR_A_MESH;

		// Token: 0x04005276 RID: 21110
		[Token(Token = "0x4005276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int MAX_VERT_COUNT;

		// Token: 0x020009CA RID: 2506
		[Token(Token = "0x20009CA")]
		public class ProgressInfo
		{
			// Token: 0x0600358F RID: 13711 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600358F")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public ProgressInfo()
			{
			}

			// Token: 0x04005277 RID: 21111
			[Token(Token = "0x4005277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int materialsLoaded;

			// Token: 0x04005278 RID: 21112
			[Token(Token = "0x4005278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int objectsLoaded;

			// Token: 0x04005279 RID: 21113
			[Token(Token = "0x4005279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int groupsLoaded;

			// Token: 0x0400527A RID: 21114
			[Token(Token = "0x400527A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int numGroups;
		}

		// Token: 0x020009CB RID: 2507
		[Token(Token = "0x20009CB")]
		private class BuildStatus
		{
			// Token: 0x06003590 RID: 13712 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003590")]
			[Address(RVA = "0xD7A940", Offset = "0xD79940", VA = "0x180D7A940")]
			public BuildStatus()
			{
			}

			// Token: 0x0400527B RID: 21115
			[Token(Token = "0x400527B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool newObject;

			// Token: 0x0400527C RID: 21116
			[Token(Token = "0x400527C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int objCount;

			// Token: 0x0400527D RID: 21117
			[Token(Token = "0x400527D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int subObjCount;

			// Token: 0x0400527E RID: 21118
			[Token(Token = "0x400527E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int idxCount;

			// Token: 0x0400527F RID: 21119
			[Token(Token = "0x400527F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int grpIdx;

			// Token: 0x04005280 RID: 21120
			[Token(Token = "0x4005280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int numGroups;

			// Token: 0x04005281 RID: 21121
			[Token(Token = "0x4005281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int grpFaceIdx;

			// Token: 0x04005282 RID: 21122
			[Token(Token = "0x4005282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int meshPartIdx;

			// Token: 0x04005283 RID: 21123
			[Token(Token = "0x4005283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int totFaceIdxCount;

			// Token: 0x04005284 RID: 21124
			[Token(Token = "0x4005284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public GameObject currObjGameObject;

			// Token: 0x04005285 RID: 21125
			[Token(Token = "0x4005285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal GameObject subObjParent;
		}
	}
}
