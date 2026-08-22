using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x020009C2 RID: 2498
	[Token(Token = "0x20009C2")]
	public class DataSet
	{
		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06003569 RID: 13673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700055A")]
		public string CurrGroupName
		{
			[Token(Token = "0x6003569")]
			[Address(RVA = "0xD722A0", Offset = "0xD712A0", VA = "0x180D722A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600356A RID: 13674 RVA: 0x00012930 File Offset: 0x00010B30
		[Token(Token = "0x1700055B")]
		public bool IsEmpty
		{
			[Token(Token = "0x600356A")]
			[Address(RVA = "0xD722F0", Offset = "0xD712F0", VA = "0x180D722F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600356B")]
		[Address(RVA = "0xD72340", Offset = "0xD71340", VA = "0x180D72340")]
		public static string GetFaceIndicesKey(DataSet.FaceIndices fi)
		{
			return null;
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600356C")]
		[Address(RVA = "0xD72530", Offset = "0xD71530", VA = "0x180D72530")]
		public static string FixMaterialName(string mtlName)
		{
			return null;
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600356D")]
		[Address(RVA = "0xD72630", Offset = "0xD71630", VA = "0x180D72630")]
		public DataSet()
		{
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600356E")]
		[Address(RVA = "0xD72BB0", Offset = "0xD71BB0", VA = "0x180D72BB0")]
		public void AddObject(string objectName)
		{
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600356F")]
		[Address(RVA = "0xD72F40", Offset = "0xD71F40", VA = "0x180D72F40")]
		public void AddGroup(string groupName)
		{
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003570")]
		[Address(RVA = "0xD73250", Offset = "0xD72250", VA = "0x180D73250")]
		public void AddMaterialName(string matName)
		{
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003571")]
		[Address(RVA = "0xD73400", Offset = "0xD72400", VA = "0x180D73400")]
		public void AddVertex(Vector3 vertex)
		{
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003572")]
		[Address(RVA = "0xD734D0", Offset = "0xD724D0", VA = "0x180D734D0")]
		public void AddUV(Vector2 uv)
		{
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003573")]
		[Address(RVA = "0xD73530", Offset = "0xD72530", VA = "0x180D73530")]
		public void AddNormal(Vector3 normal)
		{
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003574")]
		[Address(RVA = "0xD73600", Offset = "0xD72600", VA = "0x180D73600")]
		public void AddColor(Color color)
		{
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003575")]
		[Address(RVA = "0xD736C0", Offset = "0xD726C0", VA = "0x180D736C0")]
		public void AddFaceIndices(DataSet.FaceIndices faceIdx)
		{
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003576")]
		[Address(RVA = "0xD73840", Offset = "0xD72840", VA = "0x180D73840")]
		public void PrintSummary()
		{
		}

		// Token: 0x04005244 RID: 21060
		[Token(Token = "0x4005244")]
		[FieldOffset(Offset = "0x10")]
		public List<DataSet.ObjectData> objectList;

		// Token: 0x04005245 RID: 21061
		[Token(Token = "0x4005245")]
		[FieldOffset(Offset = "0x18")]
		public List<Vector3> vertList;

		// Token: 0x04005246 RID: 21062
		[Token(Token = "0x4005246")]
		[FieldOffset(Offset = "0x20")]
		public List<Vector2> uvList;

		// Token: 0x04005247 RID: 21063
		[Token(Token = "0x4005247")]
		[FieldOffset(Offset = "0x28")]
		public List<Vector3> normalList;

		// Token: 0x04005248 RID: 21064
		[Token(Token = "0x4005248")]
		[FieldOffset(Offset = "0x30")]
		public List<Color> colorList;

		// Token: 0x04005249 RID: 21065
		[Token(Token = "0x4005249")]
		[FieldOffset(Offset = "0x38")]
		private int unnamedGroupIndex;

		// Token: 0x0400524A RID: 21066
		[Token(Token = "0x400524A")]
		[FieldOffset(Offset = "0x40")]
		private DataSet.ObjectData currObjData;

		// Token: 0x0400524B RID: 21067
		[Token(Token = "0x400524B")]
		[FieldOffset(Offset = "0x48")]
		private DataSet.FaceGroupData currGroup;

		// Token: 0x0400524C RID: 21068
		[Token(Token = "0x400524C")]
		[FieldOffset(Offset = "0x50")]
		private bool noFaceDefined;

		// Token: 0x020009C3 RID: 2499
		[Token(Token = "0x20009C3")]
		public struct FaceIndices
		{
			// Token: 0x0400524D RID: 21069
			[Token(Token = "0x400524D")]
			[FieldOffset(Offset = "0x0")]
			public int vertIdx;

			// Token: 0x0400524E RID: 21070
			[Token(Token = "0x400524E")]
			[FieldOffset(Offset = "0x4")]
			public int uvIdx;

			// Token: 0x0400524F RID: 21071
			[Token(Token = "0x400524F")]
			[FieldOffset(Offset = "0x8")]
			public int normIdx;
		}

		// Token: 0x020009C4 RID: 2500
		[Token(Token = "0x20009C4")]
		public class ObjectData
		{
			// Token: 0x06003577 RID: 13687 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003577")]
			[Address(RVA = "0xD74590", Offset = "0xD73590", VA = "0x180D74590")]
			public ObjectData()
			{
			}

			// Token: 0x04005250 RID: 21072
			[Token(Token = "0x4005250")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04005251 RID: 21073
			[Token(Token = "0x4005251")]
			[FieldOffset(Offset = "0x18")]
			public List<DataSet.FaceGroupData> faceGroups;

			// Token: 0x04005252 RID: 21074
			[Token(Token = "0x4005252")]
			[FieldOffset(Offset = "0x20")]
			public List<DataSet.FaceIndices> allFaces;

			// Token: 0x04005253 RID: 21075
			[Token(Token = "0x4005253")]
			[FieldOffset(Offset = "0x28")]
			public bool hasNormals;

			// Token: 0x04005254 RID: 21076
			[Token(Token = "0x4005254")]
			[FieldOffset(Offset = "0x29")]
			public bool hasColors;
		}

		// Token: 0x020009C5 RID: 2501
		[Token(Token = "0x20009C5")]
		public class FaceGroupData
		{
			// Token: 0x06003578 RID: 13688 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003578")]
			[Address(RVA = "0xD74700", Offset = "0xD73700", VA = "0x180D74700")]
			public FaceGroupData()
			{
			}

			// Token: 0x1700055C RID: 1372
			// (get) Token: 0x06003579 RID: 13689 RVA: 0x00012948 File Offset: 0x00010B48
			[Token(Token = "0x1700055C")]
			public bool IsEmpty
			{
				[Token(Token = "0x6003579")]
				[Address(RVA = "0xD747C0", Offset = "0xD737C0", VA = "0x180D747C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04005255 RID: 21077
			[Token(Token = "0x4005255")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04005256 RID: 21078
			[Token(Token = "0x4005256")]
			[FieldOffset(Offset = "0x18")]
			public string materialName;

			// Token: 0x04005257 RID: 21079
			[Token(Token = "0x4005257")]
			[FieldOffset(Offset = "0x20")]
			public List<DataSet.FaceIndices> faces;
		}
	}
}
