using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BrainFailProductions.PolyFew.AsImpL;
using Il2CppDummyDll;
using UnityEngine;
using UnityMeshSimplifier;

namespace BrainFailProductions.PolyFewRuntime
{
	// Token: 0x02000A0D RID: 2573
	[Token(Token = "0x2000A0D")]
	public class PolyfewRuntime : MonoBehaviour
	{
		// Token: 0x060036DA RID: 14042 RVA: 0x00012D80 File Offset: 0x00010F80
		[Token(Token = "0x60036DA")]
		[Address(RVA = "0xDAB110", Offset = "0xDAA110", VA = "0x180DAB110")]
		public static int SimplifyObjectDeep(GameObject toSimplify, PolyfewRuntime.SimplificationOptions simplificationOptions, Action<GameObject, PolyfewRuntime.MeshRendererPair> OnEachMeshSimplified)
		{
			return 0;
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036DB")]
		[Address(RVA = "0xDAD160", Offset = "0xDAC160", VA = "0x180DAD160")]
		public static PolyfewRuntime.ObjectMeshPairs SimplifyObjectDeep(GameObject toSimplify, PolyfewRuntime.SimplificationOptions simplificationOptions)
		{
			return null;
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x00012D98 File Offset: 0x00010F98
		[Token(Token = "0x60036DC")]
		[Address(RVA = "0xDAEFF0", Offset = "0xDADFF0", VA = "0x180DAEFF0")]
		public static int SimplifyObjectDeep(PolyfewRuntime.ObjectMeshPairs objectMeshPairs, PolyfewRuntime.SimplificationOptions simplificationOptions, Action<GameObject, PolyfewRuntime.MeshRendererPair> OnEachMeshSimplified)
		{
			return 0;
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036DD")]
		[Address(RVA = "0xDB0FE0", Offset = "0xDAFFE0", VA = "0x180DB0FE0")]
		public static List<Mesh> SimplifyMeshes(List<Mesh> meshesToSimplify, PolyfewRuntime.SimplificationOptions simplificationOptions, Action<Mesh> OnEachMeshSimplified)
		{
			return null;
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036DE")]
		[Address(RVA = "0xDB20E0", Offset = "0xDB10E0", VA = "0x180DB20E0")]
		public static PolyfewRuntime.ObjectMeshPairs GetObjectMeshPairs(GameObject forObject, bool includeInactive)
		{
			return null;
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036DF")]
		[Address(RVA = "0xDB2670", Offset = "0xDB1670", VA = "0x180DB2670")]
		public static void CombineMeshesInGameObject(GameObject forObject, bool skipInactiveRenderers, Action<string, string> OnError, PolyfewRuntime.MeshCombineTarget combineTarget = PolyfewRuntime.MeshCombineTarget.SkinnedAndStatic)
		{
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036E0")]
		[Address(RVA = "0xDB4600", Offset = "0xDB3600", VA = "0x180DB4600")]
		public static GameObject CombineMeshesFromRenderers(Transform rootTransform, MeshRenderer[] originalMeshRenderers, SkinnedMeshRenderer[] originalSkinnedMeshRenderers, Action<string, string> OnError)
		{
			return null;
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E1")]
		[Address(RVA = "0xDB5100", Offset = "0xDB4100", VA = "0x180DB5100")]
		public static void ConvertSkinnedMeshesInGameObject(GameObject forObject, bool skipInactiveRenderers, Action<string, string> OnError)
		{
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036E2")]
		[Address(RVA = "0xDB5F70", Offset = "0xDB4F70", VA = "0x180DB5F70")]
		public static Tuple<SkinnedMeshRenderer, MeshRenderer, Mesh>[] ConvertSkinnedMeshesFromRenderers(SkinnedMeshRenderer[] renderersToConvert, Action<string, string> OnError)
		{
			return null;
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E3")]
		[Address(RVA = "0xDB67E0", Offset = "0xDB57E0", VA = "0x180DB67E0")]
		public static void ImportOBJFromFileSystem(string objAbsolutePath, string texturesFolderPath, string materialsFolderPath, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] PolyfewRuntime.OBJImportOptions importOptions)
		{
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E4")]
		[Address(RVA = "0xDB6B60", Offset = "0xDB5B60", VA = "0x180DB6B60")]
		public static void ImportOBJFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] PolyfewRuntime.OBJImportOptions importOptions)
		{
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E5")]
		[Address(RVA = "0xDB7080", Offset = "0xDB6080", VA = "0x180DB7080")]
		public static void ExportGameObjectToOBJ(GameObject toExport, string exportPath, Action OnSuccess, Action<Exception> OnError, [Optional] PolyfewRuntime.OBJExportOptions exportOptions)
		{
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x00012DB0 File Offset: 0x00010FB0
		[Token(Token = "0x60036E6")]
		[Address(RVA = "0xDB73B0", Offset = "0xDB63B0", VA = "0x180DB73B0")]
		public static int CountTriangles(bool countDeep, GameObject forObject)
		{
			return 0;
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x00012DC8 File Offset: 0x00010FC8
		[Token(Token = "0x60036E7")]
		[Address(RVA = "0xDB7910", Offset = "0xDB6910", VA = "0x180DB7910")]
		public static int CountTriangles(List<Mesh> toCount)
		{
			return 0;
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036E8")]
		[Address(RVA = "0xDB7BA0", Offset = "0xDB6BA0", VA = "0x180DB7BA0")]
		public static List<PolyfewRuntime.MaterialProperties> GetMaterialsProperties(GameObject forObject)
		{
			return null;
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E9")]
		[Address(RVA = "0xDB83C0", Offset = "0xDB73C0", VA = "0x180DB83C0")]
		public static void ChangeMaterialProperties(PolyfewRuntime.MaterialProperties changeTo, GameObject forObject)
		{
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036EA")]
		[Address(RVA = "0xDB85E0", Offset = "0xDB75E0", VA = "0x180DB85E0")]
		private static void SetParametersForSimplifier(PolyfewRuntime.SimplificationOptions simplificationOptions, MeshSimplifier meshSimplifier)
		{
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x00012DE0 File Offset: 0x00010FE0
		[Token(Token = "0x60036EB")]
		[Address(RVA = "0xDB8660", Offset = "0xDB7660", VA = "0x180DB8660")]
		private static bool AreAnyFeasibleMeshes(PolyfewRuntime.ObjectMeshPairs objectMeshPairs)
		{
			return default(bool);
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036EC")]
		[Address(RVA = "0xDB8C70", Offset = "0xDB7C70", VA = "0x180DB8C70")]
		private static void AssignReducedMesh(GameObject gameObject, Mesh originalMesh, Mesh reducedMesh, bool attachedToMeshfilter, bool assignBindposes)
		{
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x00012DF8 File Offset: 0x00010FF8
		[Token(Token = "0x60036ED")]
		[Address(RVA = "0xDB9000", Offset = "0xDB8000", VA = "0x180DB9000")]
		private static int CountTriangles(PolyfewRuntime.ObjectMeshPairs objectMeshPairs)
		{
			return 0;
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036EE")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public PolyfewRuntime()
		{
		}

		// Token: 0x04005434 RID: 21556
		[Token(Token = "0x4005434")]
		private const int MAX_LOD_COUNT = 8;

		// Token: 0x02000A0E RID: 2574
		[Token(Token = "0x2000A0E")]
		[Serializable]
		public class ObjectMeshPairs : Dictionary<GameObject, PolyfewRuntime.MeshRendererPair>
		{
			// Token: 0x060036EF RID: 14063 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036EF")]
			[Address(RVA = "0xDB93A0", Offset = "0xDB83A0", VA = "0x180DB93A0")]
			public ObjectMeshPairs()
			{
			}
		}

		// Token: 0x02000A0F RID: 2575
		[Token(Token = "0x2000A0F")]
		public enum MeshCombineTarget
		{
			// Token: 0x04005436 RID: 21558
			[Token(Token = "0x4005436")]
			SkinnedAndStatic,
			// Token: 0x04005437 RID: 21559
			[Token(Token = "0x4005437")]
			StaticOnly,
			// Token: 0x04005438 RID: 21560
			[Token(Token = "0x4005438")]
			SkinnedOnly
		}

		// Token: 0x02000A10 RID: 2576
		[Token(Token = "0x2000A10")]
		[Serializable]
		public class MeshRendererPair
		{
			// Token: 0x060036F0 RID: 14064 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036F0")]
			[Address(RVA = "0xDB9400", Offset = "0xDB8400", VA = "0x180DB9400")]
			public MeshRendererPair(bool attachedToMeshFilter, Mesh mesh)
			{
			}

			// Token: 0x060036F1 RID: 14065 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036F1")]
			[Address(RVA = "0xDB9460", Offset = "0xDB8460", VA = "0x180DB9460")]
			public void Destruct()
			{
			}

			// Token: 0x04005439 RID: 21561
			[Token(Token = "0x4005439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool attachedToMeshFilter;

			// Token: 0x0400543A RID: 21562
			[Token(Token = "0x400543A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Mesh mesh;
		}

		// Token: 0x02000A11 RID: 2577
		[Token(Token = "0x2000A11")]
		[Serializable]
		public class CustomMeshActionStructure
		{
			// Token: 0x060036F2 RID: 14066 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036F2")]
			[Address(RVA = "0x3EDAA0", Offset = "0x3ECAA0", VA = "0x1803EDAA0")]
			public CustomMeshActionStructure(PolyfewRuntime.MeshRendererPair meshRendererPair, GameObject gameObject, Action action)
			{
			}

			// Token: 0x0400543B RID: 21563
			[Token(Token = "0x400543B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PolyfewRuntime.MeshRendererPair meshRendererPair;

			// Token: 0x0400543C RID: 21564
			[Token(Token = "0x400543C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject gameObject;

			// Token: 0x0400543D RID: 21565
			[Token(Token = "0x400543D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action action;
		}

		// Token: 0x02000A12 RID: 2578
		[Token(Token = "0x2000A12")]
		[Serializable]
		public class SimplificationOptions
		{
			// Token: 0x060036F3 RID: 14067 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036F3")]
			[Address(RVA = "0xDB9580", Offset = "0xDB8580", VA = "0x180DB9580")]
			public SimplificationOptions()
			{
			}

			// Token: 0x060036F4 RID: 14068 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036F4")]
			[Address(RVA = "0xDB9660", Offset = "0xDB8660", VA = "0x180DB9660")]
			public SimplificationOptions(float simplificationStrength, bool simplifyOptimal, bool enableSmartlink, bool recalculateNormals, bool preserveUVSeamEdges, bool preserveUVFoldoverEdges, bool preserveBorderEdges, bool regardToleranceSphere, List<PolyfewRuntime.PreservationSphere> preservationSpheres, bool regardCurvature, int maxIterations, float aggressiveness, bool useEdgeSort)
			{
			}

			// Token: 0x0400543E RID: 21566
			[Token(Token = "0x400543E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float simplificationStrength;

			// Token: 0x0400543F RID: 21567
			[Token(Token = "0x400543F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool simplifyMeshLossless;

			// Token: 0x04005440 RID: 21568
			[Token(Token = "0x4005440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			public bool enableSmartlinking;

			// Token: 0x04005441 RID: 21569
			[Token(Token = "0x4005441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
			public bool recalculateNormals;

			// Token: 0x04005442 RID: 21570
			[Token(Token = "0x4005442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
			public bool preserveUVSeamEdges;

			// Token: 0x04005443 RID: 21571
			[Token(Token = "0x4005443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool preserveUVFoldoverEdges;

			// Token: 0x04005444 RID: 21572
			[Token(Token = "0x4005444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool preserveBorderEdges;

			// Token: 0x04005445 RID: 21573
			[Token(Token = "0x4005445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			public bool regardPreservationSpheres;

			// Token: 0x04005446 RID: 21574
			[Token(Token = "0x4005446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<PolyfewRuntime.PreservationSphere> preservationSpheres;

			// Token: 0x04005447 RID: 21575
			[Token(Token = "0x4005447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool regardCurvature;

			// Token: 0x04005448 RID: 21576
			[Token(Token = "0x4005448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int maxIterations;

			// Token: 0x04005449 RID: 21577
			[Token(Token = "0x4005449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float aggressiveness;

			// Token: 0x0400544A RID: 21578
			[Token(Token = "0x400544A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool useEdgeSort;
		}

		// Token: 0x02000A13 RID: 2579
		[Token(Token = "0x2000A13")]
		[Serializable]
		public class PreservationSphere
		{
			// Token: 0x060036F5 RID: 14069 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036F5")]
			[Address(RVA = "0xDB9830", Offset = "0xDB8830", VA = "0x180DB9830")]
			public PreservationSphere(Vector3 worldPosition, float diameter, float preservationStrength)
			{
			}

			// Token: 0x0400544B RID: 21579
			[Token(Token = "0x400544B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 worldPosition;

			// Token: 0x0400544C RID: 21580
			[Token(Token = "0x400544C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float diameter;

			// Token: 0x0400544D RID: 21581
			[Token(Token = "0x400544D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float preservationStrength;
		}

		// Token: 0x02000A14 RID: 2580
		[Token(Token = "0x2000A14")]
		[Serializable]
		public class OBJImportOptions : ImportOptions
		{
			// Token: 0x060036F6 RID: 14070 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036F6")]
			[Address(RVA = "0xDB9850", Offset = "0xDB8850", VA = "0x180DB9850")]
			public OBJImportOptions()
			{
			}
		}

		// Token: 0x02000A15 RID: 2581
		[Token(Token = "0x2000A15")]
		[Serializable]
		public class OBJExportOptions
		{
			// Token: 0x060036F7 RID: 14071 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036F7")]
			[Address(RVA = "0xDB9860", Offset = "0xDB8860", VA = "0x180DB9860")]
			public OBJExportOptions(bool applyPosition, bool applyRotation, bool applyScale, bool generateMaterials, bool exportTextures)
			{
			}

			// Token: 0x0400544E RID: 21582
			[Token(Token = "0x400544E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly bool applyPosition;

			// Token: 0x0400544F RID: 21583
			[Token(Token = "0x400544F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public readonly bool applyRotation;

			// Token: 0x04005450 RID: 21584
			[Token(Token = "0x4005450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			public readonly bool applyScale;

			// Token: 0x04005451 RID: 21585
			[Token(Token = "0x4005451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
			public readonly bool generateMaterials;

			// Token: 0x04005452 RID: 21586
			[Token(Token = "0x4005452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public readonly bool exportTextures;
		}

		// Token: 0x02000A16 RID: 2582
		[Token(Token = "0x2000A16")]
		public class ReferencedNumeric<T> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
		{
			// Token: 0x17000583 RID: 1411
			// (get) Token: 0x060036F8 RID: 14072 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060036F9 RID: 14073 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000583")]
			public T Value
			{
				[Token(Token = "0x60036F8")]
				get
				{
					return null;
				}
				[Token(Token = "0x60036F9")]
				set
				{
				}
			}

			// Token: 0x060036FA RID: 14074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036FA")]
			public ReferencedNumeric(T value)
			{
			}

			// Token: 0x04005453 RID: 21587
			[Token(Token = "0x4005453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T val;
		}

		// Token: 0x02000A17 RID: 2583
		[Token(Token = "0x2000A17")]
		[Serializable]
		public class MaterialProperties
		{
			// Token: 0x060036FB RID: 14075 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036FB")]
			[Address(RVA = "0xDB9880", Offset = "0xDB8880", VA = "0x180DB9880")]
			public MaterialProperties(int texArrIndex, int matIndex, string materialName, Material originalMaterial, Color albedoTint, Vector4 uvTileOffset, float normalIntensity, float occlusionIntensity, float smoothnessIntensity, float glossMapScale, float metalIntensity, Color emissionColor, Vector4 detailUVTileOffset, float alphaCutoff, Color specularColor, float detailNormalScale, float heightIntensity, float uvSec)
			{
			}

			// Token: 0x060036FC RID: 14076 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036FC")]
			[Address(RVA = "0xDB9A70", Offset = "0xDB8A70", VA = "0x180DB9A70")]
			public void BurnAttrToImg(ref Texture2D burnOn, int index, int textureArrayIndex)
			{
			}

			// Token: 0x04005454 RID: 21588
			[Token(Token = "0x4005454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly int texArrIndex;

			// Token: 0x04005455 RID: 21589
			[Token(Token = "0x4005455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public readonly int matIndex;

			// Token: 0x04005456 RID: 21590
			[Token(Token = "0x4005456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly string materialName;

			// Token: 0x04005457 RID: 21591
			[Token(Token = "0x4005457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public readonly Material originalMaterial;

			// Token: 0x04005458 RID: 21592
			[Token(Token = "0x4005458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Color albedoTint;

			// Token: 0x04005459 RID: 21593
			[Token(Token = "0x4005459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector4 uvTileOffset;

			// Token: 0x0400545A RID: 21594
			[Token(Token = "0x400545A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float normalIntensity;

			// Token: 0x0400545B RID: 21595
			[Token(Token = "0x400545B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float occlusionIntensity;

			// Token: 0x0400545C RID: 21596
			[Token(Token = "0x400545C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public float smoothnessIntensity;

			// Token: 0x0400545D RID: 21597
			[Token(Token = "0x400545D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float glossMapScale;

			// Token: 0x0400545E RID: 21598
			[Token(Token = "0x400545E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float metalIntensity;

			// Token: 0x0400545F RID: 21599
			[Token(Token = "0x400545F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Color emissionColor;

			// Token: 0x04005460 RID: 21600
			[Token(Token = "0x4005460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Vector4 detailUVTileOffset;

			// Token: 0x04005461 RID: 21601
			[Token(Token = "0x4005461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public float alphaCutoff;

			// Token: 0x04005462 RID: 21602
			[Token(Token = "0x4005462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Color specularColor;

			// Token: 0x04005463 RID: 21603
			[Token(Token = "0x4005463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public float detailNormalScale;

			// Token: 0x04005464 RID: 21604
			[Token(Token = "0x4005464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public float heightIntensity;

			// Token: 0x04005465 RID: 21605
			[Token(Token = "0x4005465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public readonly float uvSec;
		}

		// Token: 0x02000A18 RID: 2584
		[Token(Token = "0x2000A18")]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x060036FD RID: 14077 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036FD")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x04005466 RID: 21606
			[Token(Token = "0x4005466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int totalTriangles;

			// Token: 0x04005467 RID: 21607
			[Token(Token = "0x4005467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PolyfewRuntime.SimplificationOptions simplificationOptions;

			// Token: 0x04005468 RID: 21608
			[Token(Token = "0x4005468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float quality;

			// Token: 0x04005469 RID: 21609
			[Token(Token = "0x4005469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object threadLock1;

			// Token: 0x0400546A RID: 21610
			[Token(Token = "0x400546A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int threadsRunning;

			// Token: 0x0400546B RID: 21611
			[Token(Token = "0x400546B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int meshesHandled;

			// Token: 0x0400546C RID: 21612
			[Token(Token = "0x400546C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public object threadLock3;

			// Token: 0x0400546D RID: 21613
			[Token(Token = "0x400546D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public object threadLock2;

			// Token: 0x0400546E RID: 21614
			[Token(Token = "0x400546E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool isError;

			// Token: 0x0400546F RID: 21615
			[Token(Token = "0x400546F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string error;

			// Token: 0x04005470 RID: 21616
			[Token(Token = "0x4005470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<PolyfewRuntime.CustomMeshActionStructure> meshAssignments;

			// Token: 0x04005471 RID: 21617
			[Token(Token = "0x4005471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public List<PolyfewRuntime.CustomMeshActionStructure> callbackFlusher;
		}

		// Token: 0x02000A19 RID: 2585
		[Token(Token = "0x2000A19")]
		private sealed class <>c__DisplayClass11_1
		{
			// Token: 0x060036FE RID: 14078 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036FE")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass11_1()
			{
			}

			// Token: 0x060036FF RID: 14079 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036FF")]
			[Address(RVA = "0xDBA000", Offset = "0xDB9000", VA = "0x180DBA000")]
			internal void <SimplifyObjectDeep>b__0()
			{
			}

			// Token: 0x06003700 RID: 14080 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003700")]
			[Address(RVA = "0xDBA800", Offset = "0xDB9800", VA = "0x180DBA800")]
			internal void <SimplifyObjectDeep>b__1()
			{
			}

			// Token: 0x04005472 RID: 21618
			[Token(Token = "0x4005472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PolyfewRuntime.MeshRendererPair meshRendererPair;

			// Token: 0x04005473 RID: 21619
			[Token(Token = "0x4005473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject gameObject;

			// Token: 0x04005474 RID: 21620
			[Token(Token = "0x4005474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MeshSimplifier meshSimplifier;

			// Token: 0x04005475 RID: 21621
			[Token(Token = "0x4005475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PolyfewRuntime.<>c__DisplayClass11_0 CS$<>8__locals1;

			// Token: 0x04005476 RID: 21622
			[Token(Token = "0x4005476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action <>9__1;
		}

		// Token: 0x02000A1A RID: 2586
		[Token(Token = "0x2000A1A")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003702 RID: 14082 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003702")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c()
			{
			}

			// Token: 0x06003703 RID: 14083 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003703")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			internal void <SimplifyObjectDeep>b__11_2()
			{
			}

			// Token: 0x06003704 RID: 14084 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003704")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			internal void <SimplifyObjectDeep>b__13_2()
			{
			}

			// Token: 0x06003705 RID: 14085 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003705")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			internal void <SimplifyMeshes>b__14_2()
			{
			}

			// Token: 0x06003706 RID: 14086 RVA: 0x00012E10 File Offset: 0x00011010
			[Token(Token = "0x6003706")]
			[Address(RVA = "0xDBA990", Offset = "0xDB9990", VA = "0x180DBA990")]
			internal bool <CombineMeshesInGameObject>b__16_0(Renderer renderer)
			{
				return default(bool);
			}

			// Token: 0x06003707 RID: 14087 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6003707")]
			[Address(RVA = "0xDBADD0", Offset = "0xDB9DD0", VA = "0x180DBADD0")]
			internal MeshRenderer <CombineMeshesInGameObject>b__16_1(Renderer renderer)
			{
				return null;
			}

			// Token: 0x06003708 RID: 14088 RVA: 0x00012E28 File Offset: 0x00011028
			[Token(Token = "0x6003708")]
			[Address(RVA = "0xDBAE50", Offset = "0xDB9E50", VA = "0x180DBAE50")]
			internal bool <CombineMeshesInGameObject>b__16_2(Renderer renderer)
			{
				return default(bool);
			}

			// Token: 0x06003709 RID: 14089 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6003709")]
			[Address(RVA = "0xDBB1B0", Offset = "0xDBA1B0", VA = "0x180DBB1B0")]
			internal SkinnedMeshRenderer <CombineMeshesInGameObject>b__16_3(Renderer renderer)
			{
				return null;
			}

			// Token: 0x0600370A RID: 14090 RVA: 0x00012E40 File Offset: 0x00011040
			[Token(Token = "0x600370A")]
			[Address(RVA = "0xDBB230", Offset = "0xDBA230", VA = "0x180DBB230")]
			internal bool <CombineMeshesInGameObject>b__16_4(Renderer renderer)
			{
				return default(bool);
			}

			// Token: 0x0600370B RID: 14091 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600370B")]
			[Address(RVA = "0xDBB660", Offset = "0xDBA660", VA = "0x180DBB660")]
			internal MeshRenderer <CombineMeshesInGameObject>b__16_5(Renderer renderer)
			{
				return null;
			}

			// Token: 0x0600370C RID: 14092 RVA: 0x00012E58 File Offset: 0x00011058
			[Token(Token = "0x600370C")]
			[Address(RVA = "0xDBB6E0", Offset = "0xDBA6E0", VA = "0x180DBB6E0")]
			internal bool <CombineMeshesInGameObject>b__16_6(Renderer renderer)
			{
				return default(bool);
			}

			// Token: 0x0600370D RID: 14093 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600370D")]
			[Address(RVA = "0xDBB9F0", Offset = "0xDBA9F0", VA = "0x180DBB9F0")]
			internal SkinnedMeshRenderer <CombineMeshesInGameObject>b__16_7(Renderer renderer)
			{
				return null;
			}

			// Token: 0x0600370E RID: 14094 RVA: 0x00012E70 File Offset: 0x00011070
			[Token(Token = "0x600370E")]
			[Address(RVA = "0xDBBA70", Offset = "0xDBAA70", VA = "0x180DBBA70")]
			internal bool <CombineMeshesInGameObject>b__16_8(SkinnedMeshRenderer renderer)
			{
				return default(bool);
			}

			// Token: 0x0600370F RID: 14095 RVA: 0x00012E88 File Offset: 0x00011088
			[Token(Token = "0x600370F")]
			[Address(RVA = "0xDBBBD0", Offset = "0xDBABD0", VA = "0x180DBBBD0")]
			internal bool <CombineMeshesFromRenderers>b__17_0(MeshRenderer renderer)
			{
				return default(bool);
			}

			// Token: 0x06003710 RID: 14096 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6003710")]
			[Address(RVA = "0xDBBEE0", Offset = "0xDBAEE0", VA = "0x180DBBEE0")]
			internal MeshRenderer <CombineMeshesFromRenderers>b__17_1(MeshRenderer renderer)
			{
				return null;
			}

			// Token: 0x06003711 RID: 14097 RVA: 0x00012EA0 File Offset: 0x000110A0
			[Token(Token = "0x6003711")]
			[Address(RVA = "0xDBBEF0", Offset = "0xDBAEF0", VA = "0x180DBBEF0")]
			internal bool <CombineMeshesFromRenderers>b__17_2(SkinnedMeshRenderer renderer)
			{
				return default(bool);
			}

			// Token: 0x06003712 RID: 14098 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6003712")]
			[Address(RVA = "0xDBBEE0", Offset = "0xDBAEE0", VA = "0x180DBBEE0")]
			internal SkinnedMeshRenderer <CombineMeshesFromRenderers>b__17_3(SkinnedMeshRenderer renderer)
			{
				return null;
			}

			// Token: 0x06003713 RID: 14099 RVA: 0x00012EB8 File Offset: 0x000110B8
			[Token(Token = "0x6003713")]
			[Address(RVA = "0xDBC0C0", Offset = "0xDBB0C0", VA = "0x180DBC0C0")]
			internal bool <ConvertSkinnedMeshesInGameObject>b__18_0(SkinnedMeshRenderer renderer)
			{
				return default(bool);
			}

			// Token: 0x06003714 RID: 14100 RVA: 0x00012ED0 File Offset: 0x000110D0
			[Token(Token = "0x6003714")]
			[Address(RVA = "0xDBC320", Offset = "0xDBB320", VA = "0x180DBC320")]
			internal bool <ConvertSkinnedMeshesInGameObject>b__18_1(SkinnedMeshRenderer renderer)
			{
				return default(bool);
			}

			// Token: 0x06003715 RID: 14101 RVA: 0x00012EE8 File Offset: 0x000110E8
			[Token(Token = "0x6003715")]
			[Address(RVA = "0xDBC480", Offset = "0xDBB480", VA = "0x180DBC480")]
			internal bool <ConvertSkinnedMeshesFromRenderers>b__19_0(SkinnedMeshRenderer renderer)
			{
				return default(bool);
			}

			// Token: 0x04005477 RID: 21623
			[Token(Token = "0x4005477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly PolyfewRuntime.<>c <>9;

			// Token: 0x04005478 RID: 21624
			[Token(Token = "0x4005478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__11_2;

			// Token: 0x04005479 RID: 21625
			[Token(Token = "0x4005479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action <>9__13_2;

			// Token: 0x0400547A RID: 21626
			[Token(Token = "0x400547A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Action <>9__14_2;

			// Token: 0x0400547B RID: 21627
			[Token(Token = "0x400547B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<Renderer, bool> <>9__16_0;

			// Token: 0x0400547C RID: 21628
			[Token(Token = "0x400547C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<Renderer, MeshRenderer> <>9__16_1;

			// Token: 0x0400547D RID: 21629
			[Token(Token = "0x400547D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<Renderer, bool> <>9__16_2;

			// Token: 0x0400547E RID: 21630
			[Token(Token = "0x400547E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<Renderer, SkinnedMeshRenderer> <>9__16_3;

			// Token: 0x0400547F RID: 21631
			[Token(Token = "0x400547F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<Renderer, bool> <>9__16_4;

			// Token: 0x04005480 RID: 21632
			[Token(Token = "0x4005480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static Func<Renderer, MeshRenderer> <>9__16_5;

			// Token: 0x04005481 RID: 21633
			[Token(Token = "0x4005481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static Func<Renderer, bool> <>9__16_6;

			// Token: 0x04005482 RID: 21634
			[Token(Token = "0x4005482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static Func<Renderer, SkinnedMeshRenderer> <>9__16_7;

			// Token: 0x04005483 RID: 21635
			[Token(Token = "0x4005483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static Func<SkinnedMeshRenderer, bool> <>9__16_8;

			// Token: 0x04005484 RID: 21636
			[Token(Token = "0x4005484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static Func<MeshRenderer, bool> <>9__17_0;

			// Token: 0x04005485 RID: 21637
			[Token(Token = "0x4005485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static Func<MeshRenderer, MeshRenderer> <>9__17_1;

			// Token: 0x04005486 RID: 21638
			[Token(Token = "0x4005486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static Func<SkinnedMeshRenderer, bool> <>9__17_2;

			// Token: 0x04005487 RID: 21639
			[Token(Token = "0x4005487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static Func<SkinnedMeshRenderer, SkinnedMeshRenderer> <>9__17_3;

			// Token: 0x04005488 RID: 21640
			[Token(Token = "0x4005488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public static Func<SkinnedMeshRenderer, bool> <>9__18_0;

			// Token: 0x04005489 RID: 21641
			[Token(Token = "0x4005489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static Func<SkinnedMeshRenderer, bool> <>9__18_1;

			// Token: 0x0400548A RID: 21642
			[Token(Token = "0x400548A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public static Func<SkinnedMeshRenderer, bool> <>9__19_0;
		}

		// Token: 0x02000A1B RID: 2587
		[Token(Token = "0x2000A1B")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06003716 RID: 14102 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003716")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x0400548B RID: 21643
			[Token(Token = "0x400548B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PolyfewRuntime.ObjectMeshPairs toReturn;

			// Token: 0x0400548C RID: 21644
			[Token(Token = "0x400548C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PolyfewRuntime.SimplificationOptions simplificationOptions;

			// Token: 0x0400548D RID: 21645
			[Token(Token = "0x400548D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float quality;

			// Token: 0x0400548E RID: 21646
			[Token(Token = "0x400548E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object threadLock1;

			// Token: 0x0400548F RID: 21647
			[Token(Token = "0x400548F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int threadsRunning;

			// Token: 0x04005490 RID: 21648
			[Token(Token = "0x4005490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int meshesHandled;

			// Token: 0x04005491 RID: 21649
			[Token(Token = "0x4005491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public object threadLock2;

			// Token: 0x04005492 RID: 21650
			[Token(Token = "0x4005492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool isError;

			// Token: 0x04005493 RID: 21651
			[Token(Token = "0x4005493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string error;

			// Token: 0x04005494 RID: 21652
			[Token(Token = "0x4005494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public List<PolyfewRuntime.CustomMeshActionStructure> meshAssignments;
		}

		// Token: 0x02000A1C RID: 2588
		[Token(Token = "0x2000A1C")]
		private sealed class <>c__DisplayClass12_1
		{
			// Token: 0x06003717 RID: 14103 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003717")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass12_1()
			{
			}

			// Token: 0x06003718 RID: 14104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003718")]
			[Address(RVA = "0xDBC5E0", Offset = "0xDBB5E0", VA = "0x180DBC5E0")]
			internal void <SimplifyObjectDeep>b__0()
			{
			}

			// Token: 0x06003719 RID: 14105 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003719")]
			[Address(RVA = "0xDBCAD0", Offset = "0xDBBAD0", VA = "0x180DBCAD0")]
			internal void <SimplifyObjectDeep>b__1()
			{
			}

			// Token: 0x04005495 RID: 21653
			[Token(Token = "0x4005495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PolyfewRuntime.MeshRendererPair meshRendererPair;

			// Token: 0x04005496 RID: 21654
			[Token(Token = "0x4005496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject gameObject;

			// Token: 0x04005497 RID: 21655
			[Token(Token = "0x4005497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MeshSimplifier meshSimplifier;

			// Token: 0x04005498 RID: 21656
			[Token(Token = "0x4005498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PolyfewRuntime.<>c__DisplayClass12_0 CS$<>8__locals1;

			// Token: 0x04005499 RID: 21657
			[Token(Token = "0x4005499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action <>9__1;
		}

		// Token: 0x02000A1D RID: 2589
		[Token(Token = "0x2000A1D")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x0600371A RID: 14106 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600371A")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x0400549A RID: 21658
			[Token(Token = "0x400549A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int totalTriangles;

			// Token: 0x0400549B RID: 21659
			[Token(Token = "0x400549B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PolyfewRuntime.SimplificationOptions simplificationOptions;

			// Token: 0x0400549C RID: 21660
			[Token(Token = "0x400549C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float quality;

			// Token: 0x0400549D RID: 21661
			[Token(Token = "0x400549D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object threadLock1;

			// Token: 0x0400549E RID: 21662
			[Token(Token = "0x400549E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int threadsRunning;

			// Token: 0x0400549F RID: 21663
			[Token(Token = "0x400549F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int meshesHandled;

			// Token: 0x040054A0 RID: 21664
			[Token(Token = "0x40054A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public object threadLock3;

			// Token: 0x040054A1 RID: 21665
			[Token(Token = "0x40054A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public object threadLock2;

			// Token: 0x040054A2 RID: 21666
			[Token(Token = "0x40054A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool isError;

			// Token: 0x040054A3 RID: 21667
			[Token(Token = "0x40054A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string error;

			// Token: 0x040054A4 RID: 21668
			[Token(Token = "0x40054A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<PolyfewRuntime.CustomMeshActionStructure> meshAssignments;

			// Token: 0x040054A5 RID: 21669
			[Token(Token = "0x40054A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public List<PolyfewRuntime.CustomMeshActionStructure> callbackFlusher;
		}

		// Token: 0x02000A1E RID: 2590
		[Token(Token = "0x2000A1E")]
		private sealed class <>c__DisplayClass13_1
		{
			// Token: 0x0600371B RID: 14107 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600371B")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass13_1()
			{
			}

			// Token: 0x0600371C RID: 14108 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600371C")]
			[Address(RVA = "0xDBCD60", Offset = "0xDBBD60", VA = "0x180DBCD60")]
			internal void <SimplifyObjectDeep>b__0()
			{
			}

			// Token: 0x0600371D RID: 14109 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600371D")]
			[Address(RVA = "0xDBA800", Offset = "0xDB9800", VA = "0x180DBA800")]
			internal void <SimplifyObjectDeep>b__1()
			{
			}

			// Token: 0x040054A6 RID: 21670
			[Token(Token = "0x40054A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PolyfewRuntime.MeshRendererPair meshRendererPair;

			// Token: 0x040054A7 RID: 21671
			[Token(Token = "0x40054A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject gameObject;

			// Token: 0x040054A8 RID: 21672
			[Token(Token = "0x40054A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MeshSimplifier meshSimplifier;

			// Token: 0x040054A9 RID: 21673
			[Token(Token = "0x40054A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PolyfewRuntime.<>c__DisplayClass13_0 CS$<>8__locals1;

			// Token: 0x040054AA RID: 21674
			[Token(Token = "0x40054AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action <>9__1;
		}

		// Token: 0x02000A1F RID: 2591
		[Token(Token = "0x2000A1F")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x0600371E RID: 14110 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600371E")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x040054AB RID: 21675
			[Token(Token = "0x40054AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Mesh> simplifiedMeshes;

			// Token: 0x040054AC RID: 21676
			[Token(Token = "0x40054AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PolyfewRuntime.SimplificationOptions simplificationOptions;

			// Token: 0x040054AD RID: 21677
			[Token(Token = "0x40054AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float quality;

			// Token: 0x040054AE RID: 21678
			[Token(Token = "0x40054AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object threadLock1;

			// Token: 0x040054AF RID: 21679
			[Token(Token = "0x40054AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int threadsRunning;

			// Token: 0x040054B0 RID: 21680
			[Token(Token = "0x40054B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int meshesHandled;

			// Token: 0x040054B1 RID: 21681
			[Token(Token = "0x40054B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public object threadLock3;

			// Token: 0x040054B2 RID: 21682
			[Token(Token = "0x40054B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public object threadLock2;

			// Token: 0x040054B3 RID: 21683
			[Token(Token = "0x40054B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool isError;

			// Token: 0x040054B4 RID: 21684
			[Token(Token = "0x40054B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string error;

			// Token: 0x040054B5 RID: 21685
			[Token(Token = "0x40054B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<PolyfewRuntime.CustomMeshActionStructure> meshAssignments;

			// Token: 0x040054B6 RID: 21686
			[Token(Token = "0x40054B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public List<PolyfewRuntime.CustomMeshActionStructure> callbackFlusher;
		}

		// Token: 0x02000A20 RID: 2592
		[Token(Token = "0x2000A20")]
		private sealed class <>c__DisplayClass14_1
		{
			// Token: 0x0600371F RID: 14111 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600371F")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass14_1()
			{
			}

			// Token: 0x06003720 RID: 14112 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003720")]
			[Address(RVA = "0xDBD520", Offset = "0xDBC520", VA = "0x180DBD520")]
			internal void <SimplifyMeshes>b__0()
			{
			}

			// Token: 0x06003721 RID: 14113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003721")]
			[Address(RVA = "0xDBDD60", Offset = "0xDBCD60", VA = "0x180DBDD60")]
			internal void <SimplifyMeshes>b__1()
			{
			}

			// Token: 0x040054B7 RID: 21687
			[Token(Token = "0x40054B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Mesh meshToSimplify;

			// Token: 0x040054B8 RID: 21688
			[Token(Token = "0x40054B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MeshSimplifier meshSimplifier;

			// Token: 0x040054B9 RID: 21689
			[Token(Token = "0x40054B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.<>c__DisplayClass14_0 CS$<>8__locals1;

			// Token: 0x040054BA RID: 21690
			[Token(Token = "0x40054BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action <>9__1;
		}

		// Token: 0x02000A21 RID: 2593
		[Token(Token = "0x2000A21")]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x06003722 RID: 14114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003722")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x06003723 RID: 14115 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003723")]
			[Address(RVA = "0xDBDF30", Offset = "0xDBCF30", VA = "0x180DBDF30")]
			internal void <ImportOBJFromFileSystem>b__0(GameObject importedObject)
			{
			}

			// Token: 0x040054BB RID: 21691
			[Token(Token = "0x40054BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			// Token: 0x040054BC RID: 21692
			[Token(Token = "0x40054BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<GameObject> OnSuccess;
		}

		// Token: 0x02000A22 RID: 2594
		[Token(Token = "0x2000A22")]
		[StructLayout(3)]
		private struct <ImportOBJFromFileSystem>d__20 : IEnumerator<object>
		{
			// Token: 0x06003724 RID: 14116 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003724")]
			[Address(RVA = "0xDBDF60", Offset = "0xDBCF60", VA = "0x180DBDF60", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06003725 RID: 14117 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003725")]
			[Address(RVA = "0x6F8FA0", Offset = "0x6F7FA0", VA = "0x1806F8FA0", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040054BD RID: 21693
			[Token(Token = "0x40054BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040054BE RID: 21694
			[Token(Token = "0x40054BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040054BF RID: 21695
			[Token(Token = "0x40054BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<GameObject> OnSuccess;

			// Token: 0x040054C0 RID: 21696
			[Token(Token = "0x40054C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objAbsolutePath;

			// Token: 0x040054C1 RID: 21697
			[Token(Token = "0x40054C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string texturesFolderPath;

			// Token: 0x040054C2 RID: 21698
			[Token(Token = "0x40054C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string materialsFolderPath;

			// Token: 0x040054C3 RID: 21699
			[Token(Token = "0x40054C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public PolyfewRuntime.OBJImportOptions importOptions;

			// Token: 0x040054C4 RID: 21700
			[Token(Token = "0x40054C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private PolyfewRuntime.<>c__DisplayClass20_0 <>8__1;

			// Token: 0x040054C5 RID: 21701
			[Token(Token = "0x40054C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Action<Exception> OnError;

			// Token: 0x040054C6 RID: 21702
			[Token(Token = "0x40054C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000A23 RID: 2595
		[Token(Token = "0x2000A23")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06003726 RID: 14118 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003726")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x06003727 RID: 14119 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003727")]
			[Address(RVA = "0xDBDF30", Offset = "0xDBCF30", VA = "0x180DBDF30")]
			internal void <ImportOBJFromNetwork>b__0(GameObject importedObject)
			{
			}

			// Token: 0x06003728 RID: 14120 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003728")]
			[Address(RVA = "0xDBE5F0", Offset = "0xDBD5F0", VA = "0x180DBE5F0")]
			internal void <ImportOBJFromNetwork>b__1(Exception ex)
			{
			}

			// Token: 0x040054C7 RID: 21703
			[Token(Token = "0x40054C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			// Token: 0x040054C8 RID: 21704
			[Token(Token = "0x40054C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<GameObject> OnSuccess;

			// Token: 0x040054C9 RID: 21705
			[Token(Token = "0x40054C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<Exception> OnError;
		}

		// Token: 0x02000A24 RID: 2596
		[Token(Token = "0x2000A24")]
		[StructLayout(3)]
		private struct <ImportOBJFromNetwork>d__21 : IEnumerator<object>
		{
			// Token: 0x06003729 RID: 14121 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003729")]
			[Address(RVA = "0xDBE620", Offset = "0xDBD620", VA = "0x180DBE620", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x0600372A RID: 14122 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600372A")]
			[Address(RVA = "0x6F8FA0", Offset = "0x6F7FA0", VA = "0x1806F8FA0", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040054CA RID: 21706
			[Token(Token = "0x40054CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040054CB RID: 21707
			[Token(Token = "0x40054CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040054CC RID: 21708
			[Token(Token = "0x40054CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<GameObject> OnSuccess;

			// Token: 0x040054CD RID: 21709
			[Token(Token = "0x40054CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<Exception> OnError;

			// Token: 0x040054CE RID: 21710
			[Token(Token = "0x40054CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string objURL;

			// Token: 0x040054CF RID: 21711
			[Token(Token = "0x40054CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string objName;

			// Token: 0x040054D0 RID: 21712
			[Token(Token = "0x40054D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string diffuseTexURL;

			// Token: 0x040054D1 RID: 21713
			[Token(Token = "0x40054D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string bumpTexURL;

			// Token: 0x040054D2 RID: 21714
			[Token(Token = "0x40054D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string specularTexURL;

			// Token: 0x040054D3 RID: 21715
			[Token(Token = "0x40054D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public string opacityTexURL;

			// Token: 0x040054D4 RID: 21716
			[Token(Token = "0x40054D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public string materialURL;

			// Token: 0x040054D5 RID: 21717
			[Token(Token = "0x40054D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			// Token: 0x040054D6 RID: 21718
			[Token(Token = "0x40054D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public PolyfewRuntime.OBJImportOptions importOptions;

			// Token: 0x040054D7 RID: 21719
			[Token(Token = "0x40054D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private PolyfewRuntime.<>c__DisplayClass21_0 <>8__1;

			// Token: 0x040054D8 RID: 21720
			[Token(Token = "0x40054D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000A25 RID: 2597
		[Token(Token = "0x2000A25")]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x0600372B RID: 14123 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600372B")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x0600372C RID: 14124 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600372C")]
			[Address(RVA = "0xDBEC60", Offset = "0xDBDC60", VA = "0x180DBEC60")]
			internal void <ExportGameObjectToOBJ>b__0()
			{
			}

			// Token: 0x040054D9 RID: 21721
			[Token(Token = "0x40054D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			// Token: 0x040054DA RID: 21722
			[Token(Token = "0x40054DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action OnSuccess;
		}

		// Token: 0x02000A26 RID: 2598
		[Token(Token = "0x2000A26")]
		[StructLayout(3)]
		private struct <ExportGameObjectToOBJ>d__22 : IEnumerator<object>
		{
			// Token: 0x0600372D RID: 14125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600372D")]
			[Address(RVA = "0xDBEC90", Offset = "0xDBDC90", VA = "0x180DBEC90", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x0600372E RID: 14126 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600372E")]
			[Address(RVA = "0x6F8FA0", Offset = "0x6F7FA0", VA = "0x1806F8FA0", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040054DB RID: 21723
			[Token(Token = "0x40054DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040054DC RID: 21724
			[Token(Token = "0x40054DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040054DD RID: 21725
			[Token(Token = "0x40054DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action OnSuccess;

			// Token: 0x040054DE RID: 21726
			[Token(Token = "0x40054DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject toExport;

			// Token: 0x040054DF RID: 21727
			[Token(Token = "0x40054DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string exportPath;

			// Token: 0x040054E0 RID: 21728
			[Token(Token = "0x40054E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public PolyfewRuntime.OBJExportOptions exportOptions;

			// Token: 0x040054E1 RID: 21729
			[Token(Token = "0x40054E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action<Exception> OnError;

			// Token: 0x040054E2 RID: 21730
			[Token(Token = "0x40054E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private PolyfewRuntime.<>c__DisplayClass22_0 <>8__1;

			// Token: 0x040054E3 RID: 21731
			[Token(Token = "0x40054E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private TaskAwaiter <>u__1;
		}
	}
}
