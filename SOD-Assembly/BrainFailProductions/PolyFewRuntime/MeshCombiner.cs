using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace BrainFailProductions.PolyFewRuntime
{
	// Token: 0x02000A06 RID: 2566
	[Token(Token = "0x2000A06")]
	public static class MeshCombiner
	{
		// Token: 0x060036AF RID: 13999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036AF")]
		[Address(RVA = "0xD9FA00", Offset = "0xD9EA00", VA = "0x180D9FA00")]
		public static MeshCombiner.StaticRenderer[] GetStaticRenderers(MeshRenderer[] renderers)
		{
			return null;
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036B0")]
		[Address(RVA = "0xD9FF60", Offset = "0xD9EF60", VA = "0x180D9FF60")]
		public static MeshCombiner.SkinnedRenderer[] GetSkinnedRenderers(SkinnedMeshRenderer[] renderers)
		{
			return null;
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036B1")]
		[Address(RVA = "0xDA04C0", Offset = "0xD9F4C0", VA = "0x180DA04C0")]
		public static MeshCombiner.StaticRenderer[] CombineStaticMeshes(Transform transform, int levelIndex, MeshRenderer[] renderers, bool autoName = true, string combinedBaseName = "")
		{
			return null;
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036B2")]
		[Address(RVA = "0xDA1070", Offset = "0xDA0070", VA = "0x180DA1070")]
		public static MeshCombiner.SkinnedRenderer[] CombineSkinnedMeshes(Transform transform, int levelIndex, SkinnedMeshRenderer[] renderers, ref SkinnedMeshRenderer[] renderersActuallyCombined, bool autoName = true, string combinedBaseName = "")
		{
			return null;
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036B3")]
		[Address(RVA = "0xDA1B40", Offset = "0xDA0B40", VA = "0x180DA1B40")]
		public static Mesh CombineMeshes(Transform rootTransform, MeshRenderer[] renderers, out Material[] resultMaterials, [Optional] Dictionary<Transform, Transform> topLevelParents, [Optional] Dictionary<string, MeshCombiner.BlendShapeFrame> blendShapes)
		{
			return null;
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036B4")]
		[Address(RVA = "0xDA2A40", Offset = "0xDA1A40", VA = "0x180DA2A40")]
		public static Mesh CombineMeshes(Transform rootTransform, SkinnedMeshRenderer[] renderers, out Material[] resultMaterials, out Transform[] resultBones)
		{
			return null;
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036B5")]
		[Address(RVA = "0xDA3EA0", Offset = "0xDA2EA0", VA = "0x180DA3EA0")]
		public static Mesh CombineMeshes(Mesh[] meshes, Matrix4x4[] transforms, Tuple<Matrix4x4, bool>[] normalsTransforms, Material[][] materials, out Material[] resultMaterials, [Optional] Dictionary<string, MeshCombiner.BlendShapeFrame> blendShapes)
		{
			return null;
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036B6")]
		[Address(RVA = "0xDA3FF0", Offset = "0xDA2FF0", VA = "0x180DA3FF0")]
		public static Mesh CombineMeshes(Mesh[] meshes, Matrix4x4[] transforms, Tuple<Matrix4x4, bool>[] normalsTransforms, Material[][] materials, Transform[][] bones, out Material[] resultMaterials, out Transform[] resultBones, [Optional] Dictionary<string, MeshCombiner.BlendShapeFrame> blendShapes)
		{
			return null;
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036B7")]
		[Address(RVA = "0xDA63B0", Offset = "0xDA53B0", VA = "0x180DA63B0")]
		private static void ParentAndResetTransform(Transform transform, Transform parentTransform)
		{
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036B8")]
		[Address(RVA = "0xDA65C0", Offset = "0xDA55C0", VA = "0x180DA65C0")]
		private static void ParentAndOffsetTransform(Transform transform, Transform parentTransform, Transform originalTransform)
		{
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036B9")]
		[Address(RVA = "0xDA6860", Offset = "0xDA5860", VA = "0x180DA6860")]
		private static Transform FindBestRootBone(Transform transform, SkinnedMeshRenderer[] skinnedMeshRenderers)
		{
			return null;
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036BA")]
		[Address(RVA = "0xDA6C00", Offset = "0xDA5C00", VA = "0x180DA6C00")]
		private static Transform FindBestRootBone(Dictionary<Transform, Transform> topLevelParents, SkinnedMeshRenderer[] skinnedMeshRenderers)
		{
			return null;
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036BB")]
		[Address(RVA = "0xDA7000", Offset = "0xDA6000", VA = "0x180DA7000")]
		private static Transform GetTopLevelParent(Transform forObject)
		{
			return null;
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036BC")]
		[Address(RVA = "0xDA71C0", Offset = "0xDA61C0", VA = "0x180DA71C0")]
		private static void CopyVertexPositions(List<Vector3> list, Vector3[] arr)
		{
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036BD")]
		private static void CopyVertexAttributes<T>(ref List<T> dest, IEnumerable<T> src, int previousVertexCount, int meshVertexCount, int totalVertexCount, T defaultValue)
		{
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036BE")]
		private static T[] MergeArrays<T>(T[] arr1, T[] arr2)
		{
			return null;
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036BF")]
		[Address(RVA = "0xDA72D0", Offset = "0xDA62D0", VA = "0x180DA72D0")]
		private static void TransformVertices(Vector3[] vertices, ref Matrix4x4 transform)
		{
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C0")]
		[Address(RVA = "0xDA73C0", Offset = "0xDA63C0", VA = "0x180DA73C0")]
		private static void TransformNormals(Vector3[] normals, ref Tuple<Matrix4x4, bool> transform)
		{
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C1")]
		[Address(RVA = "0xDA76B0", Offset = "0xDA66B0", VA = "0x180DA76B0")]
		private static void TransformTangents(Vector4[] tangents, ref Tuple<Matrix4x4, bool> transform)
		{
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C2")]
		[Address(RVA = "0xDA7820", Offset = "0xDA6820", VA = "0x180DA7820")]
		private static void RemapBones(BoneWeight[] boneWeights, int[] boneIndices)
		{
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x00012D08 File Offset: 0x00010F08
		[Token(Token = "0x60036C3")]
		[Address(RVA = "0xDA7920", Offset = "0xDA6920", VA = "0x180DA7920")]
		private static Matrix4x4 ScaleMatrix(ref Matrix4x4 matrix, float scale)
		{
			return default(Matrix4x4);
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C4")]
		[Address(RVA = "0xDA79F0", Offset = "0xDA69F0", VA = "0x180DA79F0")]
		private static void CombineMeshesUnity(Transform parentTransform, MeshFilter[] meshFilters)
		{
		}

		// Token: 0x04005415 RID: 21525
		[Token(Token = "0x4005415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static MeshRenderer[] unityCombinedMeshRenderers;

		// Token: 0x04005416 RID: 21526
		[Token(Token = "0x4005416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Material[] unityCombinedMeshesMats;

		// Token: 0x04005417 RID: 21527
		[Token(Token = "0x4005417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool didUseUnityCombine;

		// Token: 0x04005418 RID: 21528
		[Token(Token = "0x4005418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public static bool generateUV2;

		// Token: 0x02000A07 RID: 2567
		[Token(Token = "0x2000A07")]
		public struct StaticRenderer
		{
			// Token: 0x04005419 RID: 21529
			[Token(Token = "0x4005419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x0400541A RID: 21530
			[Token(Token = "0x400541A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool isNewMesh;

			// Token: 0x0400541B RID: 21531
			[Token(Token = "0x400541B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			// Token: 0x0400541C RID: 21532
			[Token(Token = "0x400541C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Mesh mesh;

			// Token: 0x0400541D RID: 21533
			[Token(Token = "0x400541D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Material[] materials;
		}

		// Token: 0x02000A08 RID: 2568
		[Token(Token = "0x2000A08")]
		public struct SkinnedRenderer
		{
			// Token: 0x0400541E RID: 21534
			[Token(Token = "0x400541E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool hasBlendShapes;

			// Token: 0x0400541F RID: 21535
			[Token(Token = "0x400541F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string name;

			// Token: 0x04005420 RID: 21536
			[Token(Token = "0x4005420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isNewMesh;

			// Token: 0x04005421 RID: 21537
			[Token(Token = "0x4005421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform transform;

			// Token: 0x04005422 RID: 21538
			[Token(Token = "0x4005422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Mesh mesh;

			// Token: 0x04005423 RID: 21539
			[Token(Token = "0x4005423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Material[] materials;

			// Token: 0x04005424 RID: 21540
			[Token(Token = "0x4005424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform rootBone;

			// Token: 0x04005425 RID: 21541
			[Token(Token = "0x4005425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform[] bones;
		}

		// Token: 0x02000A09 RID: 2569
		[Token(Token = "0x2000A09")]
		[Serializable]
		public struct BlendShape
		{
			// Token: 0x060036C5 RID: 14021 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036C5")]
			[Address(RVA = "0x3EB9E0", Offset = "0x3EA9E0", VA = "0x1803EB9E0")]
			public BlendShape(string shapeName, MeshCombiner.BlendShapeFrame[] frames)
			{
			}

			// Token: 0x04005426 RID: 21542
			[Token(Token = "0x4005426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string ShapeName;

			// Token: 0x04005427 RID: 21543
			[Token(Token = "0x4005427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MeshCombiner.BlendShapeFrame[] Frames;
		}

		// Token: 0x02000A0A RID: 2570
		[Token(Token = "0x2000A0A")]
		[Serializable]
		public struct BlendShapeFrame
		{
			// Token: 0x060036C6 RID: 14022 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036C6")]
			[Address(RVA = "0xDA8E00", Offset = "0xDA7E00", VA = "0x180DA8E00")]
			public BlendShapeFrame(float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents)
			{
			}

			// Token: 0x060036C7 RID: 14023 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036C7")]
			[Address(RVA = "0xDA8FC0", Offset = "0xDA7FC0", VA = "0x180DA8FC0")]
			public BlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents, int vertexOffset)
			{
			}

			// Token: 0x04005428 RID: 21544
			[Token(Token = "0x4005428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string shapeName;

			// Token: 0x04005429 RID: 21545
			[Token(Token = "0x4005429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float frameWeight;

			// Token: 0x0400542A RID: 21546
			[Token(Token = "0x400542A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] deltaVertices;

			// Token: 0x0400542B RID: 21547
			[Token(Token = "0x400542B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3[] deltaNormals;

			// Token: 0x0400542C RID: 21548
			[Token(Token = "0x400542C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3[] deltaTangents;

			// Token: 0x0400542D RID: 21549
			[Token(Token = "0x400542D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int vertexOffset;
		}

		// Token: 0x02000A0B RID: 2571
		[Token(Token = "0x2000A0B")]
		public static class MeshUtils
		{
			// Token: 0x060036C8 RID: 14024 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60036C8")]
			[Address(RVA = "0xDA9140", Offset = "0xDA8140", VA = "0x180DA9140")]
			public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs, Matrix4x4[] bindposes, MeshCombiner.BlendShape[] blendShapes)
			{
				return null;
			}

			// Token: 0x060036C9 RID: 14025 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60036C9")]
			[Address(RVA = "0xDA91A0", Offset = "0xDA81A0", VA = "0x180DA91A0")]
			public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector4>[] uvs, Matrix4x4[] bindposes, MeshCombiner.BlendShape[] blendShapes)
			{
				return null;
			}

			// Token: 0x060036CA RID: 14026 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60036CA")]
			[Address(RVA = "0xDA9200", Offset = "0xDA8200", VA = "0x180DA9200")]
			public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs2D, List<Vector3>[] uvs3D, List<Vector4>[] uvs4D, Matrix4x4[] bindposes, MeshCombiner.BlendShape[] blendShapes)
			{
				return null;
			}

			// Token: 0x060036CB RID: 14027 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60036CB")]
			[Address(RVA = "0xDA9800", Offset = "0xDA8800", VA = "0x180DA9800")]
			public static MeshCombiner.BlendShape[] GetMeshBlendShapes(Mesh mesh)
			{
				return null;
			}

			// Token: 0x060036CC RID: 14028 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036CC")]
			[Address(RVA = "0xDA9D40", Offset = "0xDA8D40", VA = "0x180DA9D40")]
			public static void ApplyMeshBlendShapes(Mesh mesh, MeshCombiner.BlendShape[] blendShapes)
			{
			}

			// Token: 0x060036CD RID: 14029 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60036CD")]
			[Address(RVA = "0xDA9FB0", Offset = "0xDA8FB0", VA = "0x180DA9FB0")]
			public static List<Vector4>[] GetMeshUVs(Mesh mesh)
			{
				return null;
			}

			// Token: 0x060036CE RID: 14030 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60036CE")]
			[Address(RVA = "0xDAA230", Offset = "0xDA9230", VA = "0x180DAA230")]
			public static List<Vector4> GetMeshUVs(Mesh mesh, int channel)
			{
				return null;
			}

			// Token: 0x060036CF RID: 14031 RVA: 0x00012D20 File Offset: 0x00010F20
			[Token(Token = "0x60036CF")]
			[Address(RVA = "0xDAA460", Offset = "0xDA9460", VA = "0x180DAA460")]
			public static int GetUsedUVComponents(List<Vector4> uvs)
			{
				return 0;
			}

			// Token: 0x060036D0 RID: 14032 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60036D0")]
			[Address(RVA = "0xDAA700", Offset = "0xDA9700", VA = "0x180DAA700")]
			public static Vector2[] ConvertUVsTo2D(List<Vector4> uvs)
			{
				return null;
			}

			// Token: 0x060036D1 RID: 14033 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60036D1")]
			[Address(RVA = "0xDAA7E0", Offset = "0xDA97E0", VA = "0x180DAA7E0")]
			public static Vector3[] ConvertUVsTo3D(List<Vector4> uvs)
			{
				return null;
			}

			// Token: 0x060036D2 RID: 14034 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60036D2")]
			[Address(RVA = "0xDAA8D0", Offset = "0xDA98D0", VA = "0x180DAA8D0")]
			public static Vector2Int[] GetSubMeshIndexMinMax(int[][] indices, out IndexFormat indexFormat)
			{
				return null;
			}

			// Token: 0x060036D3 RID: 14035 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036D3")]
			[Address(RVA = "0xDAAA60", Offset = "0xDA9A60", VA = "0x180DAAA60")]
			private static void GetIndexMinMax(int[] indices, out int minIndex, out int maxIndex)
			{
			}

			// Token: 0x0400542E RID: 21550
			[Token(Token = "0x400542E")]
			public const int UVChannelCount = 8;
		}

		// Token: 0x02000A0C RID: 2572
		[Token(Token = "0x2000A0C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060036D5 RID: 14037 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036D5")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c()
			{
			}

			// Token: 0x060036D6 RID: 14038 RVA: 0x00012D38 File Offset: 0x00010F38
			[Token(Token = "0x60036D6")]
			[Address(RVA = "0xDAAB90", Offset = "0xDA9B90", VA = "0x180DAAB90")]
			internal bool <CombineStaticMeshes>b__11_0(MeshRenderer renderer)
			{
				return default(bool);
			}

			// Token: 0x060036D7 RID: 14039 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60036D7")]
			[Address(RVA = "0xDAAE10", Offset = "0xDA9E10", VA = "0x180DAAE10")]
			internal MeshFilter <CombineStaticMeshes>b__11_1(MeshRenderer renderer)
			{
				return null;
			}

			// Token: 0x060036D8 RID: 14040 RVA: 0x00012D50 File Offset: 0x00010F50
			[Token(Token = "0x60036D8")]
			[Address(RVA = "0xDAAE60", Offset = "0xDA9E60", VA = "0x180DAAE60")]
			internal bool <CombineSkinnedMeshes>b__12_0(SkinnedMeshRenderer renderer)
			{
				return default(bool);
			}

			// Token: 0x060036D9 RID: 14041 RVA: 0x00012D68 File Offset: 0x00010F68
			[Token(Token = "0x60036D9")]
			[Address(RVA = "0xDAAFB0", Offset = "0xDA9FB0", VA = "0x180DAAFB0")]
			internal bool <CombineSkinnedMeshes>b__12_1(SkinnedMeshRenderer renderer)
			{
				return default(bool);
			}

			// Token: 0x0400542F RID: 21551
			[Token(Token = "0x400542F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly MeshCombiner.<>c <>9;

			// Token: 0x04005430 RID: 21552
			[Token(Token = "0x4005430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<MeshRenderer, bool> <>9__11_0;

			// Token: 0x04005431 RID: 21553
			[Token(Token = "0x4005431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<MeshRenderer, MeshFilter> <>9__11_1;

			// Token: 0x04005432 RID: 21554
			[Token(Token = "0x4005432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<SkinnedMeshRenderer, bool> <>9__12_0;

			// Token: 0x04005433 RID: 21555
			[Token(Token = "0x4005433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<SkinnedMeshRenderer, bool> <>9__12_1;
		}
	}
}
