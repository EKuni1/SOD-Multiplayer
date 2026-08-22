using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL.MathUtil
{
	// Token: 0x020009FD RID: 2557
	[Token(Token = "0x20009FD")]
	public static class Triangulation
	{
		// Token: 0x06003678 RID: 13944 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003678")]
		[Address(RVA = "0xD999E0", Offset = "0xD989E0", VA = "0x180D999E0")]
		public static List<Triangle> TriangulateConvexPolygon(List<Vertex> vertices, bool preserveOriginalVertices = true)
		{
			return null;
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003679")]
		[Address(RVA = "0xD99BF0", Offset = "0xD98BF0", VA = "0x180D99BF0")]
		public static List<Triangle> TriangulateByEarClipping(List<Vertex> origVertices, Vector3 planeNormal, string meshName, bool preserveOriginalVertices = true)
		{
			return null;
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600367A")]
		[Address(RVA = "0xD9A2D0", Offset = "0xD992D0", VA = "0x180D9A2D0")]
		public static Triangle ClipTriangle(Vertex vertex, List<Vertex> vertices)
		{
			return null;
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600367B")]
		[Address(RVA = "0xD9A470", Offset = "0xD99470", VA = "0x180D9A470")]
		private static Triangle ClipEar(Vertex earVertex, List<Vertex> earVertices, List<Vertex> vertices, Vector3 planeNormal)
		{
			return null;
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600367C")]
		[Address(RVA = "0xD9A5D0", Offset = "0xD995D0", VA = "0x180D9A5D0")]
		private static Vertex FindMaxAreaEarVertex(List<Vertex> earVertices)
		{
			return null;
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600367D")]
		[Address(RVA = "0xD9A7B0", Offset = "0xD997B0", VA = "0x180D9A7B0")]
		private static List<Vertex> FindEarVertices(List<Vertex> vertices, Vector3 planeNormal)
		{
			return null;
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x00012C78 File Offset: 0x00010E78
		[Token(Token = "0x600367E")]
		[Address(RVA = "0xD9A910", Offset = "0xD99910", VA = "0x180D9A910")]
		private static bool IsVertexReflex(Vertex v, Vector3 vNormal)
		{
			return default(bool);
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x00012C90 File Offset: 0x00010E90
		[Token(Token = "0x600367F")]
		[Address(RVA = "0xD9AA30", Offset = "0xD99A30", VA = "0x180D9AA30")]
		private static bool IsVertexEar(Vertex v, List<Vertex> vertices, Vector3 planeNormal)
		{
			return default(bool);
		}
	}
}
