using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BrainFailProductions.PolyFew.AsImpL;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFewRuntime
{
	// Token: 0x02000A27 RID: 2599
	[Token(Token = "0x2000A27")]
	public class UtilityServicesRuntime : MonoBehaviour
	{
		// Token: 0x0600372F RID: 14127 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600372F")]
		[Address(RVA = "0xDBF1C0", Offset = "0xDBE1C0", VA = "0x180DBF1C0")]
		public static Texture2D DuplicateTexture(Texture2D source)
		{
			return null;
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003730")]
		[Address(RVA = "0xDBF520", Offset = "0xDBE520", VA = "0x180DBF520")]
		public static Renderer[] GetChildRenderersForCombining(GameObject forObject, bool skipInactiveChildObjects)
		{
			return null;
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003731")]
		[Address(RVA = "0xDBF870", Offset = "0xDBE870", VA = "0x180DBF870")]
		public static MeshRenderer CreateStaticLevelRenderer(string name, Transform parentTransform, Transform originalTransform, Mesh mesh, Material[] materials)
		{
			return null;
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003732")]
		[Address(RVA = "0xDBFC40", Offset = "0xDBEC40", VA = "0x180DBFC40")]
		public static SkinnedMeshRenderer CreateSkinnedLevelRenderer(string name, Transform parentTransform, Transform originalTransform, Mesh mesh, Material[] materials, Transform rootBone, Transform[] bones)
		{
			return null;
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003733")]
		[Address(RVA = "0xDC0010", Offset = "0xDBF010", VA = "0x180DC0010")]
		private static void CollectChildRenderersForCombining(Transform transform, List<Renderer> resultRenderers, bool skipInactiveChildObjects)
		{
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003734")]
		[Address(RVA = "0xDA63B0", Offset = "0xDA53B0", VA = "0x180DA63B0")]
		private static void ParentAndResetTransform(Transform transform, Transform parentTransform)
		{
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003735")]
		[Address(RVA = "0xDA65C0", Offset = "0xDA55C0", VA = "0x180DA65C0")]
		public static void ParentAndOffsetTransform(Transform transform, Transform parentTransform, Transform originalTransform)
		{
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003736")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public UtilityServicesRuntime()
		{
		}

		// Token: 0x02000A28 RID: 2600
		[Token(Token = "0x2000A28")]
		public class OBJExporterImporter
		{
			// Token: 0x06003737 RID: 14135 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003737")]
			[Address(RVA = "0xDC0360", Offset = "0xDBF360", VA = "0x180DC0360")]
			public OBJExporterImporter()
			{
			}

			// Token: 0x06003738 RID: 14136 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003738")]
			[Address(RVA = "0xDC0370", Offset = "0xDBF370", VA = "0x180DC0370")]
			private void InitializeExporter(GameObject toExport, string exportPath, PolyfewRuntime.OBJExportOptions exportOptions)
			{
			}

			// Token: 0x06003739 RID: 14137 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003739")]
			[Address(RVA = "0xDC0B50", Offset = "0xDBFB50", VA = "0x180DC0B50")]
			private void InitializeExporter(Mesh toExport, string exportPath)
			{
			}

			// Token: 0x0600373A RID: 14138 RVA: 0x00012F00 File Offset: 0x00011100
			[Token(Token = "0x600373A")]
			[Address(RVA = "0xDC0F30", Offset = "0xDBFF30", VA = "0x180DC0F30")]
			private Vector3 RotateAroundPoint(Vector3 point, Vector3 pivot, Quaternion angle)
			{
				return default(Vector3);
			}

			// Token: 0x0600373B RID: 14139 RVA: 0x00012F18 File Offset: 0x00011118
			[Token(Token = "0x600373B")]
			[Address(RVA = "0xDC1140", Offset = "0xDC0140", VA = "0x180DC1140")]
			private Vector3 MultiplyVec3s(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			// Token: 0x0600373C RID: 14140 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600373C")]
			[Address(RVA = "0xDC1180", Offset = "0xDC0180", VA = "0x180DC1180")]
			public void ExportGameObjectToOBJ(GameObject toExport, string exportPath, [Optional] PolyfewRuntime.OBJExportOptions exportOptions, [Optional] Action OnSuccess)
			{
			}

			// Token: 0x0600373D RID: 14141 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600373D")]
			[Address(RVA = "0xDC2AA0", Offset = "0xDC1AA0", VA = "0x180DC2AA0")]
			public Task ExportMeshToOBJ(Mesh mesh, string exportPath)
			{
				return null;
			}

			// Token: 0x0600373E RID: 14142 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600373E")]
			[Address(RVA = "0xDC2D30", Offset = "0xDC1D30", VA = "0x180DC2D30")]
			private string TryExportTexture(string propertyName, Material m, string exportPath)
			{
				return null;
			}

			// Token: 0x0600373F RID: 14143 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600373F")]
			[Address(RVA = "0xDC2EE0", Offset = "0xDC1EE0", VA = "0x180DC2EE0")]
			private string ExportTexture(Texture2D t, string exportPath)
			{
				return null;
			}

			// Token: 0x06003740 RID: 14144 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6003740")]
			[Address(RVA = "0xDC3320", Offset = "0xDC2320", VA = "0x180DC3320")]
			private string ConstructOBJString(int index)
			{
				return null;
			}

			// Token: 0x06003741 RID: 14145 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6003741")]
			[Address(RVA = "0xDC34F0", Offset = "0xDC24F0", VA = "0x180DC34F0")]
			private string MaterialToString(Material m)
			{
				return null;
			}

			// Token: 0x06003742 RID: 14146 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6003742")]
			[Address(RVA = "0xDC3E90", Offset = "0xDC2E90", VA = "0x180DC3E90")]
			public Task ImportFromLocalFileSystem(string objPath, string texturesFolderPath, string materialsFolderPath, Action<GameObject> Callback, [Optional] PolyfewRuntime.OBJImportOptions importOptions)
			{
				return null;
			}

			// Token: 0x06003743 RID: 14147 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003743")]
			[Address(RVA = "0xDC41B0", Offset = "0xDC31B0", VA = "0x180DC41B0")]
			public void ImportFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] PolyfewRuntime.OBJImportOptions importOptions)
			{
			}

			// Token: 0x06003744 RID: 14148 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003744")]
			[Address(RVA = "0xDC46C0", Offset = "0xDC36C0", VA = "0x180DC46C0")]
			public void ImportFromNetworkWebGL(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] PolyfewRuntime.OBJImportOptions importOptions)
			{
			}

			// Token: 0x040054E4 RID: 21732
			[Token(Token = "0x40054E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool applyPosition;

			// Token: 0x040054E5 RID: 21733
			[Token(Token = "0x40054E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private bool applyRotation;

			// Token: 0x040054E6 RID: 21734
			[Token(Token = "0x40054E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			private bool applyScale;

			// Token: 0x040054E7 RID: 21735
			[Token(Token = "0x40054E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
			private bool generateMaterials;

			// Token: 0x040054E8 RID: 21736
			[Token(Token = "0x40054E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool exportTextures;

			// Token: 0x040054E9 RID: 21737
			[Token(Token = "0x40054E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string exportPath;

			// Token: 0x040054EA RID: 21738
			[Token(Token = "0x40054EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private MeshFilter meshFilter;

			// Token: 0x040054EB RID: 21739
			[Token(Token = "0x40054EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Mesh meshToExport;

			// Token: 0x040054EC RID: 21740
			[Token(Token = "0x40054EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private MeshRenderer meshRenderer;

			// Token: 0x02000A29 RID: 2601
			[Token(Token = "0x2000A29")]
			[StructLayout(3)]
			private struct <ExportMeshToOBJ>d__15 : IEnumerator<object>
			{
				// Token: 0x06003745 RID: 14149 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003745")]
				[Address(RVA = "0xDC4BD0", Offset = "0xDC3BD0", VA = "0x180DC4BD0", Slot = "4")]
				private void MoveNext()
				{
				}

				// Token: 0x06003746 RID: 14150 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003746")]
				[Address(RVA = "0xDC67F0", Offset = "0xDC57F0", VA = "0x180DC67F0", Slot = "5")]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}

				// Token: 0x040054ED RID: 21741
				[Token(Token = "0x40054ED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int <>1__state;

				// Token: 0x040054EE RID: 21742
				[Token(Token = "0x40054EE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncTaskMethodBuilder <>t__builder;

				// Token: 0x040054EF RID: 21743
				[Token(Token = "0x40054EF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public UtilityServicesRuntime.OBJExporterImporter <>4__this;

				// Token: 0x040054F0 RID: 21744
				[Token(Token = "0x40054F0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Mesh mesh;

				// Token: 0x040054F1 RID: 21745
				[Token(Token = "0x40054F1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public string exportPath;

				// Token: 0x040054F2 RID: 21746
				[Token(Token = "0x40054F2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private string <objectName>5__2;

				// Token: 0x040054F3 RID: 21747
				[Token(Token = "0x40054F3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private StringBuilder <sb>5__3;

				// Token: 0x040054F4 RID: 21748
				[Token(Token = "0x40054F4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private int <lastIndex>5__4;

				// Token: 0x040054F5 RID: 21749
				[Token(Token = "0x40054F5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
				private int <faceOrder>5__5;

				// Token: 0x040054F6 RID: 21750
				[Token(Token = "0x40054F6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private Vector3[] <>7__wrap5;

				// Token: 0x040054F7 RID: 21751
				[Token(Token = "0x40054F7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private int <>7__wrap6;

				// Token: 0x040054F8 RID: 21752
				[Token(Token = "0x40054F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
				private Vector3 <vx>5__8;

				// Token: 0x040054F9 RID: 21753
				[Token(Token = "0x40054F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private TaskAwaiter <>u__1;

				// Token: 0x040054FA RID: 21754
				[Token(Token = "0x40054FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private Vector2[] <>7__wrap8;

				// Token: 0x040054FB RID: 21755
				[Token(Token = "0x40054FB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private Vector2 <v>5__10;

				// Token: 0x040054FC RID: 21756
				[Token(Token = "0x40054FC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private int[] <tris>5__11;

				// Token: 0x040054FD RID: 21757
				[Token(Token = "0x40054FD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private int <t>5__12;
			}

			// Token: 0x02000A2A RID: 2602
			[Token(Token = "0x2000A2A")]
			[StructLayout(3)]
			private struct <ImportFromLocalFileSystem>d__20 : IEnumerator<object>
			{
				// Token: 0x06003747 RID: 14151 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003747")]
				[Address(RVA = "0xDC6850", Offset = "0xDC5850", VA = "0x180DC6850", Slot = "4")]
				private void MoveNext()
				{
				}

				// Token: 0x06003748 RID: 14152 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003748")]
				[Address(RVA = "0xDC73A0", Offset = "0xDC63A0", VA = "0x180DC73A0", Slot = "5")]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}

				// Token: 0x040054FE RID: 21758
				[Token(Token = "0x40054FE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int <>1__state;

				// Token: 0x040054FF RID: 21759
				[Token(Token = "0x40054FF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncTaskMethodBuilder <>t__builder;

				// Token: 0x04005500 RID: 21760
				[Token(Token = "0x4005500")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public string objPath;

				// Token: 0x04005501 RID: 21761
				[Token(Token = "0x4005501")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public string texturesFolderPath;

				// Token: 0x04005502 RID: 21762
				[Token(Token = "0x4005502")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public string materialsFolderPath;

				// Token: 0x04005503 RID: 21763
				[Token(Token = "0x4005503")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public PolyfewRuntime.OBJImportOptions importOptions;

				// Token: 0x04005504 RID: 21764
				[Token(Token = "0x4005504")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public Action<GameObject> Callback;

				// Token: 0x04005505 RID: 21765
				[Token(Token = "0x4005505")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private GameObject <objectToPopulate>5__2;

				// Token: 0x04005506 RID: 21766
				[Token(Token = "0x4005506")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private ObjectImporter <objImporter>5__3;

				// Token: 0x04005507 RID: 21767
				[Token(Token = "0x4005507")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private TaskAwaiter<GameObject> <>u__1;
			}

			// Token: 0x02000A2B RID: 2603
			[Token(Token = "0x2000A2B")]
			[StructLayout(3)]
			private struct <ImportFromNetwork>d__21 : IEnumerator<object>
			{
				// Token: 0x06003749 RID: 14153 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003749")]
				[Address(RVA = "0xDED350", Offset = "0xDEC350", VA = "0x180DED350", Slot = "4")]
				private void MoveNext()
				{
				}

				// Token: 0x0600374A RID: 14154 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600374A")]
				[Address(RVA = "0x6F8FA0", Offset = "0x6F7FA0", VA = "0x1806F8FA0", Slot = "5")]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}

				// Token: 0x04005508 RID: 21768
				[Token(Token = "0x4005508")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int <>1__state;

				// Token: 0x04005509 RID: 21769
				[Token(Token = "0x4005509")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncVoidMethodBuilder <>t__builder;

				// Token: 0x0400550A RID: 21770
				[Token(Token = "0x400550A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public string objURL;

				// Token: 0x0400550B RID: 21771
				[Token(Token = "0x400550B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public string diffuseTexURL;

				// Token: 0x0400550C RID: 21772
				[Token(Token = "0x400550C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public string materialURL;

				// Token: 0x0400550D RID: 21773
				[Token(Token = "0x400550D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

				// Token: 0x0400550E RID: 21774
				[Token(Token = "0x400550E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public PolyfewRuntime.OBJImportOptions importOptions;

				// Token: 0x0400550F RID: 21775
				[Token(Token = "0x400550F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				public string objName;

				// Token: 0x04005510 RID: 21776
				[Token(Token = "0x4005510")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public string bumpTexURL;

				// Token: 0x04005511 RID: 21777
				[Token(Token = "0x4005511")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				public string specularTexURL;

				// Token: 0x04005512 RID: 21778
				[Token(Token = "0x4005512")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				public string opacityTexURL;

				// Token: 0x04005513 RID: 21779
				[Token(Token = "0x4005513")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				public Action<GameObject> OnSuccess;

				// Token: 0x04005514 RID: 21780
				[Token(Token = "0x4005514")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				public Action<Exception> OnError;

				// Token: 0x04005515 RID: 21781
				[Token(Token = "0x4005515")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private GameObject <objectToPopulate>5__2;

				// Token: 0x04005516 RID: 21782
				[Token(Token = "0x4005516")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private ObjectImporter <objImporter>5__3;

				// Token: 0x04005517 RID: 21783
				[Token(Token = "0x4005517")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				private TaskAwaiter<GameObject> <>u__1;
			}

			// Token: 0x02000A2C RID: 2604
			[Token(Token = "0x2000A2C")]
			private sealed class <>c__DisplayClass22_0
			{
				// Token: 0x0600374B RID: 14155 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600374B")]
				[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
				public <>c__DisplayClass22_0()
				{
				}

				// Token: 0x0600374C RID: 14156 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600374C")]
				[Address(RVA = "0xDED9F0", Offset = "0xDEC9F0", VA = "0x180DED9F0")]
				internal void <ImportFromNetworkWebGL>b__0(GameObject imported)
				{
				}

				// Token: 0x0600374D RID: 14157 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600374D")]
				[Address(RVA = "0xDEDA80", Offset = "0xDECA80", VA = "0x180DEDA80")]
				internal void <ImportFromNetworkWebGL>b__1(Exception exception)
				{
				}

				// Token: 0x04005518 RID: 21784
				[Token(Token = "0x4005518")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public ObjectImporter objImporter;

				// Token: 0x04005519 RID: 21785
				[Token(Token = "0x4005519")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Action<GameObject> OnSuccess;

				// Token: 0x0400551A RID: 21786
				[Token(Token = "0x400551A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public GameObject objectToPopulate;

				// Token: 0x0400551B RID: 21787
				[Token(Token = "0x400551B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Action<Exception> OnError;
			}

			// Token: 0x02000A2D RID: 2605
			[Token(Token = "0x2000A2D")]
			[StructLayout(3)]
			private struct <ImportFromNetworkWebGL>d__22 : IEnumerator<object>
			{
				// Token: 0x0600374E RID: 14158 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600374E")]
				[Address(RVA = "0xDEDB10", Offset = "0xDECB10", VA = "0x180DEDB10", Slot = "4")]
				private void MoveNext()
				{
				}

				// Token: 0x0600374F RID: 14159 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600374F")]
				[Address(RVA = "0x6F8FA0", Offset = "0x6F7FA0", VA = "0x1806F8FA0", Slot = "5")]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}

				// Token: 0x0400551C RID: 21788
				[Token(Token = "0x400551C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int <>1__state;

				// Token: 0x0400551D RID: 21789
				[Token(Token = "0x400551D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncVoidMethodBuilder <>t__builder;

				// Token: 0x0400551E RID: 21790
				[Token(Token = "0x400551E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Action<GameObject> OnSuccess;

				// Token: 0x0400551F RID: 21791
				[Token(Token = "0x400551F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public Action<Exception> OnError;

				// Token: 0x04005520 RID: 21792
				[Token(Token = "0x4005520")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public string objURL;

				// Token: 0x04005521 RID: 21793
				[Token(Token = "0x4005521")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public string diffuseTexURL;

				// Token: 0x04005522 RID: 21794
				[Token(Token = "0x4005522")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public string materialURL;

				// Token: 0x04005523 RID: 21795
				[Token(Token = "0x4005523")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

				// Token: 0x04005524 RID: 21796
				[Token(Token = "0x4005524")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public PolyfewRuntime.OBJImportOptions importOptions;

				// Token: 0x04005525 RID: 21797
				[Token(Token = "0x4005525")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				public string objName;

				// Token: 0x04005526 RID: 21798
				[Token(Token = "0x4005526")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				public string bumpTexURL;

				// Token: 0x04005527 RID: 21799
				[Token(Token = "0x4005527")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				public string specularTexURL;

				// Token: 0x04005528 RID: 21800
				[Token(Token = "0x4005528")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				public string opacityTexURL;
			}
		}
	}
}
