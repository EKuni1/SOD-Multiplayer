using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL.MathUtil
{
	// Token: 0x020009FB RID: 2555
	[Token(Token = "0x20009FB")]
	public class Vertex
	{
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06003668 RID: 13928 RVA: 0x00012BB8 File Offset: 0x00010DB8
		// (set) Token: 0x06003669 RID: 13929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057A")]
		public Vector3 Position
		{
			[Token(Token = "0x6003668")]
			[Address(RVA = "0xD99180", Offset = "0xD98180", VA = "0x180D99180")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003669")]
			[Address(RVA = "0xD991A0", Offset = "0xD981A0", VA = "0x180D991A0")]
			private set
			{
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x0600366A RID: 13930 RVA: 0x00012BD0 File Offset: 0x00010DD0
		// (set) Token: 0x0600366B RID: 13931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057B")]
		public int OriginalIndex
		{
			[Token(Token = "0x600366A")]
			[Address(RVA = "0xD181F0", Offset = "0xD171F0", VA = "0x180D181F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600366B")]
			[Address(RVA = "0xD18200", Offset = "0xD17200", VA = "0x180D18200")]
			private set
			{
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600366C RID: 13932 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600366D RID: 13933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057C")]
		public Vertex PreviousVertex
		{
			[Token(Token = "0x600366C")]
			[Address(RVA = "0x3ED8F0", Offset = "0x3EC8F0", VA = "0x1803ED8F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600366D")]
			[Address(RVA = "0xD991B0", Offset = "0xD981B0", VA = "0x180D991B0")]
			set
			{
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600366E RID: 13934 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600366F RID: 13935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057D")]
		public Vertex NextVertex
		{
			[Token(Token = "0x600366E")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600366F")]
			[Address(RVA = "0xD99210", Offset = "0xD98210", VA = "0x180D99210")]
			set
			{
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06003670 RID: 13936 RVA: 0x00012BE8 File Offset: 0x00010DE8
		[Token(Token = "0x1700057E")]
		public float TriangleArea
		{
			[Token(Token = "0x6003670")]
			[Address(RVA = "0xD99270", Offset = "0xD98270", VA = "0x180D99270")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003671")]
		[Address(RVA = "0xD993A0", Offset = "0xD983A0", VA = "0x180D993A0")]
		public Vertex(int originalIndex, Vector3 position)
		{
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x00012C00 File Offset: 0x00010E00
		[Token(Token = "0x6003672")]
		[Address(RVA = "0xD993C0", Offset = "0xD983C0", VA = "0x180D993C0")]
		public Vector2 GetPosOnPlane(Vector3 planeNormal)
		{
			return default(Vector2);
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003673")]
		[Address(RVA = "0xD99600", Offset = "0xD98600", VA = "0x180D99600")]
		private void ComputeTriangleArea()
		{
		}

		// Token: 0x040053D5 RID: 21461
		[Token(Token = "0x40053D5")]
		[FieldOffset(Offset = "0x10")]
		private Vertex prevVertex;

		// Token: 0x040053D6 RID: 21462
		[Token(Token = "0x40053D6")]
		[FieldOffset(Offset = "0x18")]
		private Vertex nextVertex;

		// Token: 0x040053D7 RID: 21463
		[Token(Token = "0x40053D7")]
		[FieldOffset(Offset = "0x20")]
		private float triangleArea;

		// Token: 0x040053D8 RID: 21464
		[Token(Token = "0x40053D8")]
		[FieldOffset(Offset = "0x24")]
		private bool triangleHasChanged;

		// Token: 0x040053D9 RID: 21465
		[Token(Token = "0x40053D9")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 <Position>k__BackingField;

		// Token: 0x040053DA RID: 21466
		[Token(Token = "0x40053DA")]
		[FieldOffset(Offset = "0x34")]
		private int <OriginalIndex>k__BackingField;
	}
}
