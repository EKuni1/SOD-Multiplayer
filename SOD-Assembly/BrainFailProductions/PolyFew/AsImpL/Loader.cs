using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BrainFailProductions.PolyFewRuntime;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x020009CE RID: 2510
	[Token(Token = "0x20009CE")]
	public abstract class Loader : MonoBehaviour
	{
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06003594 RID: 13716 RVA: 0x00012A20 File Offset: 0x00010C20
		// (set) Token: 0x06003595 RID: 13717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700055F")]
		public bool ConvertVertAxis
		{
			[Token(Token = "0x6003594")]
			[Address(RVA = "0xD7B180", Offset = "0xD7A180", VA = "0x180D7B180")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003595")]
			[Address(RVA = "0xD7B1A0", Offset = "0xD7A1A0", VA = "0x180D7B1A0")]
			set
			{
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06003596 RID: 13718 RVA: 0x00012A38 File Offset: 0x00010C38
		// (set) Token: 0x06003597 RID: 13719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000560")]
		public float Scaling
		{
			[Token(Token = "0x6003596")]
			[Address(RVA = "0xD7B270", Offset = "0xD7A270", VA = "0x180D7B270")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003597")]
			[Address(RVA = "0xD7B290", Offset = "0xD7A290", VA = "0x180D7B290")]
			set
			{
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06003598 RID: 13720
		[Token(Token = "0x17000561")]
		protected abstract bool HasMaterialLibrary { [Token(Token = "0x6003598")] get; }

		// Token: 0x1400007A RID: 122
		// (add) Token: 0x06003599 RID: 13721 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600359A RID: 13722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007A")]
		public event Action<GameObject, string> ModelCreated
		{
			[Token(Token = "0x6003599")]
			[Address(RVA = "0xD7B360", Offset = "0xD7A360", VA = "0x180D7B360")]
			add
			{
			}
			[Token(Token = "0x600359A")]
			[Address(RVA = "0xD7B470", Offset = "0xD7A470", VA = "0x180D7B470")]
			remove
			{
			}
		}

		// Token: 0x1400007B RID: 123
		// (add) Token: 0x0600359B RID: 13723 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600359C RID: 13724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007B")]
		public event Action<GameObject, string> ModelLoaded
		{
			[Token(Token = "0x600359B")]
			[Address(RVA = "0xD7B580", Offset = "0xD7A580", VA = "0x180D7B580")]
			add
			{
			}
			[Token(Token = "0x600359C")]
			[Address(RVA = "0xD7B690", Offset = "0xD7A690", VA = "0x180D7B690")]
			remove
			{
			}
		}

		// Token: 0x1400007C RID: 124
		// (add) Token: 0x0600359D RID: 13725 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600359E RID: 13726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007C")]
		public event Action<string> ModelError
		{
			[Token(Token = "0x600359D")]
			[Address(RVA = "0xD7B7A0", Offset = "0xD7A7A0", VA = "0x180D7B7A0")]
			add
			{
			}
			[Token(Token = "0x600359E")]
			[Address(RVA = "0xD7B8C0", Offset = "0xD7A8C0", VA = "0x180D7B8C0")]
			remove
			{
			}
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600359F")]
		[Address(RVA = "0xD7B9E0", Offset = "0xD7A9E0", VA = "0x180D7B9E0")]
		public static GameObject GetModelByPath(string absolutePath)
		{
			return null;
		}

		// Token: 0x060035A0 RID: 13728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035A0")]
		[Address(RVA = "0xD7BAE0", Offset = "0xD7AAE0", VA = "0x180D7BAE0")]
		public Task<GameObject> Load(string objName, string objAbsolutePath, Transform parentObj, string texturesFolderPath = "", string materialsFolderPath = "")
		{
			return null;
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035A1")]
		[Address(RVA = "0xD7BE40", Offset = "0xD7AE40", VA = "0x180D7BE40")]
		public Task<GameObject> LoadFromNetwork(string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, string objName)
		{
			return null;
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035A2")]
		[Address(RVA = "0xD7C240", Offset = "0xD7B240", VA = "0x180D7C240")]
		public IEnumerator LoadFromNetworkWebGL(string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, string objName, Action<GameObject> OnSuccess, Action<Exception> OnError)
		{
			return null;
		}

		// Token: 0x060035A3 RID: 13731
		[Token(Token = "0x60035A3")]
		public abstract string[] ParseTexturePaths(string absolutePath);

		// Token: 0x060035A4 RID: 13732
		[Token(Token = "0x60035A4")]
		protected abstract Task LoadModelFile(string absolutePath, string texturesFolderPath = "", string materialsFolderPath = "");

		// Token: 0x060035A5 RID: 13733
		[Token(Token = "0x60035A5")]
		protected abstract Task LoadModelFileNetworked(string objURL);

		// Token: 0x060035A6 RID: 13734
		[Token(Token = "0x60035A6")]
		protected abstract IEnumerator LoadModelFileNetworkedWebGL(string objURL, Action<Exception> OnError);

		// Token: 0x060035A7 RID: 13735
		[Token(Token = "0x60035A7")]
		protected abstract Task LoadMaterialLibrary(string absolutePath, string materialsFolderPath = "");

		// Token: 0x060035A8 RID: 13736
		[Token(Token = "0x60035A8")]
		protected abstract Task LoadMaterialLibrary(string materialURL);

		// Token: 0x060035A9 RID: 13737
		[Token(Token = "0x60035A9")]
		protected abstract IEnumerator LoadMaterialLibraryWebGL(string materialURL);

		// Token: 0x060035AA RID: 13738 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035AA")]
		[Address(RVA = "0xD7C620", Offset = "0xD7B620", VA = "0x180D7C620")]
		protected Task Build(string absolutePath, string objName, Transform parentTransform, string texturesFolderPath = "")
		{
			return null;
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035AB")]
		[Address(RVA = "0xD7C950", Offset = "0xD7B950", VA = "0x180D7C950")]
		protected Task NetworkedBuild(Transform parentTransform, string objName, string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL)
		{
			return null;
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035AC")]
		[Address(RVA = "0xD7CD70", Offset = "0xD7BD70", VA = "0x180D7CD70")]
		protected IEnumerator NetworkedBuildWebGL(Transform parentTransform, string objName, string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL)
		{
			return null;
		}

		// Token: 0x060035AD RID: 13741 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035AD")]
		[Address(RVA = "0xD7D0A0", Offset = "0xD7C0A0", VA = "0x180D7D0A0")]
		protected string GetDirName(string absolutePath)
		{
			return null;
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035AE")]
		[Address(RVA = "0xD7D1D0", Offset = "0xD7C1D0", VA = "0x180D7D1D0", Slot = "12")]
		protected virtual void OnLoaded(GameObject obj, string absolutePath)
		{
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035AF")]
		[Address(RVA = "0xD7D950", Offset = "0xD7C950", VA = "0x180D7D950", Slot = "13")]
		protected virtual void OnCreated(GameObject obj, string absolutePath)
		{
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B0")]
		[Address(RVA = "0xD7DAB0", Offset = "0xD7CAB0", VA = "0x180D7DAB0", Slot = "14")]
		protected virtual void OnLoadFailed(string absolutePath)
		{
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035B1")]
		[Address(RVA = "0xD7DAE0", Offset = "0xD7CAE0", VA = "0x180D7DAE0")]
		private string GetTextureUrl(string basePath, string texturePath)
		{
			return null;
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035B2")]
		[Address(RVA = "0xD7DCB0", Offset = "0xD7CCB0", VA = "0x180D7DCB0")]
		private Task LoadMaterialTexture(string basePath, string path, string texturesFolderPath = "")
		{
			return null;
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035B3")]
		[Address(RVA = "0xD7DF90", Offset = "0xD7CF90", VA = "0x180D7DF90")]
		private Task LoadMaterialTexture(string textureURL)
		{
			return null;
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035B4")]
		[Address(RVA = "0xD7E1A0", Offset = "0xD7D1A0", VA = "0x180D7E1A0")]
		private IEnumerator LoadMaterialTextureWebGL(string textureURL)
		{
			return null;
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035B5")]
		[Address(RVA = "0xD7E2B0", Offset = "0xD7D2B0", VA = "0x180D7E2B0")]
		private Texture2D LoadTexture(UnityWebRequest loader)
		{
			return null;
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035B6")]
		[Address(RVA = "0xD7E840", Offset = "0xD7D840", VA = "0x180D7E840")]
		public IEnumerator DownloadFile(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<byte[]> DownloadComplete, Action<string> OnError)
		{
			return null;
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035B7")]
		[Address(RVA = "0xD7EA60", Offset = "0xD7DA60", VA = "0x180D7EA60")]
		private IEnumerator GetProgress(WWW www, PolyfewRuntime.ReferencedNumeric<float> downloadProgress)
		{
			return null;
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035B8")]
		[Address(RVA = "0xD7EB70", Offset = "0xD7DB70", VA = "0x180D7EB70")]
		public IEnumerator DownloadFileWebGL(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<string> DownloadComplete, Action<string> OnError)
		{
			return null;
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035B9")]
		[Address(RVA = "0xD7ED90", Offset = "0xD7DD90", VA = "0x180D7ED90")]
		public IEnumerator DownloadTexFileWebGL(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<Texture2D> DownloadComplete, Action<string> OnError)
		{
			return null;
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035BA")]
		[Address(RVA = "0xD7EFB0", Offset = "0xD7DFB0", VA = "0x180D7EFB0")]
		protected Loader()
		{
		}

		// Token: 0x04005294 RID: 21140
		[Token(Token = "0x4005294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LoadingProgress totalProgress;

		// Token: 0x04005295 RID: 21141
		[Token(Token = "0x4005295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ImportOptions buildOptions;

		// Token: 0x04005296 RID: 21142
		[Token(Token = "0x4005296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PolyfewRuntime.ReferencedNumeric<float> individualProgress;

		// Token: 0x04005297 RID: 21143
		[Token(Token = "0x4005297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static float LOAD_PHASE_PERC;

		// Token: 0x04005298 RID: 21144
		[Token(Token = "0x4005298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected static float TEXTURE_PHASE_PERC;

		// Token: 0x04005299 RID: 21145
		[Token(Token = "0x4005299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static float MATERIAL_PHASE_PERC;

		// Token: 0x0400529A RID: 21146
		[Token(Token = "0x400529A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected static float BUILD_PHASE_PERC;

		// Token: 0x0400529B RID: 21147
		[Token(Token = "0x400529B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected static Dictionary<string, GameObject> loadedModels;

		// Token: 0x0400529C RID: 21148
		[Token(Token = "0x400529C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected static Dictionary<string, int> instanceCount;

		// Token: 0x0400529D RID: 21149
		[Token(Token = "0x400529D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected DataSet dataSet;

		// Token: 0x0400529E RID: 21150
		[Token(Token = "0x400529E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected ObjectBuilder objectBuilder;

		// Token: 0x0400529F RID: 21151
		[Token(Token = "0x400529F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<MaterialData> materialData;

		// Token: 0x040052A0 RID: 21152
		[Token(Token = "0x40052A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected SingleLoadingProgress objLoadingProgress;

		// Token: 0x040052A1 RID: 21153
		[Token(Token = "0x40052A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Loader.Stats loadStats;

		// Token: 0x040052A2 RID: 21154
		[Token(Token = "0x40052A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Texture2D loadedTexture;

		// Token: 0x020009CF RID: 2511
		[Token(Token = "0x20009CF")]
		protected struct BuildStats
		{
			// Token: 0x040052A6 RID: 21158
			[Token(Token = "0x40052A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float texturesTime;

			// Token: 0x040052A7 RID: 21159
			[Token(Token = "0x40052A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float materialsTime;

			// Token: 0x040052A8 RID: 21160
			[Token(Token = "0x40052A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float objectsTime;
		}

		// Token: 0x020009D0 RID: 2512
		[Token(Token = "0x20009D0")]
		protected struct Stats
		{
			// Token: 0x040052A9 RID: 21161
			[Token(Token = "0x40052A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float modelParseTime;

			// Token: 0x040052AA RID: 21162
			[Token(Token = "0x40052AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float materialsParseTime;

			// Token: 0x040052AB RID: 21163
			[Token(Token = "0x40052AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float buildTime;

			// Token: 0x040052AC RID: 21164
			[Token(Token = "0x40052AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Loader.BuildStats buildStats;

			// Token: 0x040052AD RID: 21165
			[Token(Token = "0x40052AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float totalTime;
		}

		// Token: 0x020009D1 RID: 2513
		[Token(Token = "0x20009D1")]
		[StructLayout(3)]
		private struct <Load>d__33 : IEnumerator<object>
		{
			// Token: 0x060035BC RID: 13756 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035BC")]
			[Address(RVA = "0xD7F620", Offset = "0xD7E620", VA = "0x180D7F620", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x060035BD RID: 13757 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035BD")]
			[Address(RVA = "0xD80250", Offset = "0xD7F250", VA = "0x180D80250", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040052AE RID: 21166
			[Token(Token = "0x40052AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040052AF RID: 21167
			[Token(Token = "0x40052AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> <>t__builder;

			// Token: 0x040052B0 RID: 21168
			[Token(Token = "0x40052B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string objAbsolutePath;

			// Token: 0x040052B1 RID: 21169
			[Token(Token = "0x40052B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string objName;

			// Token: 0x040052B2 RID: 21170
			[Token(Token = "0x40052B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Loader <>4__this;

			// Token: 0x040052B3 RID: 21171
			[Token(Token = "0x40052B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string texturesFolderPath;

			// Token: 0x040052B4 RID: 21172
			[Token(Token = "0x40052B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string materialsFolderPath;

			// Token: 0x040052B5 RID: 21173
			[Token(Token = "0x40052B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform parentObj;

			// Token: 0x040052B6 RID: 21174
			[Token(Token = "0x40052B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <lastTime>5__2;

			// Token: 0x040052B7 RID: 21175
			[Token(Token = "0x40052B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float <startTime>5__3;

			// Token: 0x040052B8 RID: 21176
			[Token(Token = "0x40052B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			// Token: 0x040052B9 RID: 21177
			[Token(Token = "0x40052B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private TaskAwaiter <>u__2;
		}

		// Token: 0x020009D2 RID: 2514
		[Token(Token = "0x20009D2")]
		[StructLayout(3)]
		private struct <LoadFromNetwork>d__34 : IEnumerator<object>
		{
			// Token: 0x060035BE RID: 13758 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035BE")]
			[Address(RVA = "0xD802C0", Offset = "0xD7F2C0", VA = "0x180D802C0", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x060035BF RID: 13759 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035BF")]
			[Address(RVA = "0xD80F70", Offset = "0xD7FF70", VA = "0x180D80F70", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040052BA RID: 21178
			[Token(Token = "0x40052BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040052BB RID: 21179
			[Token(Token = "0x40052BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> <>t__builder;

			// Token: 0x040052BC RID: 21180
			[Token(Token = "0x40052BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string objName;

			// Token: 0x040052BD RID: 21181
			[Token(Token = "0x40052BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Loader <>4__this;

			// Token: 0x040052BE RID: 21182
			[Token(Token = "0x40052BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objURL;

			// Token: 0x040052BF RID: 21183
			[Token(Token = "0x40052BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string materialURL;

			// Token: 0x040052C0 RID: 21184
			[Token(Token = "0x40052C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string diffuseTexURL;

			// Token: 0x040052C1 RID: 21185
			[Token(Token = "0x40052C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string bumpTexURL;

			// Token: 0x040052C2 RID: 21186
			[Token(Token = "0x40052C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string specularTexURL;

			// Token: 0x040052C3 RID: 21187
			[Token(Token = "0x40052C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string opacityTexURL;

			// Token: 0x040052C4 RID: 21188
			[Token(Token = "0x40052C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float <lastTime>5__2;

			// Token: 0x040052C5 RID: 21189
			[Token(Token = "0x40052C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float <startTime>5__3;

			// Token: 0x040052C6 RID: 21190
			[Token(Token = "0x40052C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			// Token: 0x040052C7 RID: 21191
			[Token(Token = "0x40052C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private TaskAwaiter <>u__2;
		}

		// Token: 0x020009D3 RID: 2515
		[Token(Token = "0x20009D3")]
		private sealed class <LoadFromNetworkWebGL>d__35 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x060035C0 RID: 13760 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035C0")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <LoadFromNetworkWebGL>d__35(int <>1__state)
			{
			}

			// Token: 0x060035C1 RID: 13761 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035C1")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x060035C2 RID: 13762 RVA: 0x00012A50 File Offset: 0x00010C50
			[Token(Token = "0x60035C2")]
			[Address(RVA = "0xD80FE0", Offset = "0xD7FFE0", VA = "0x180D80FE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000562 RID: 1378
			// (get) Token: 0x060035C3 RID: 13763 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000562")]
			private object Current
			{
				[Token(Token = "0x60035C3")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060035C4 RID: 13764 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035C4")]
			[Address(RVA = "0xD81690", Offset = "0xD80690", VA = "0x180D81690", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000563 RID: 1379
			// (get) Token: 0x060035C5 RID: 13765 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000563")]
			private object Current
			{
				[Token(Token = "0x60035C5")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x040052C8 RID: 21192
			[Token(Token = "0x40052C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040052C9 RID: 21193
			[Token(Token = "0x40052C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040052CA RID: 21194
			[Token(Token = "0x40052CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string objName;

			// Token: 0x040052CB RID: 21195
			[Token(Token = "0x40052CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Loader <>4__this;

			// Token: 0x040052CC RID: 21196
			[Token(Token = "0x40052CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objURL;

			// Token: 0x040052CD RID: 21197
			[Token(Token = "0x40052CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<Exception> OnError;

			// Token: 0x040052CE RID: 21198
			[Token(Token = "0x40052CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string materialURL;

			// Token: 0x040052CF RID: 21199
			[Token(Token = "0x40052CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string diffuseTexURL;

			// Token: 0x040052D0 RID: 21200
			[Token(Token = "0x40052D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string bumpTexURL;

			// Token: 0x040052D1 RID: 21201
			[Token(Token = "0x40052D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string specularTexURL;

			// Token: 0x040052D2 RID: 21202
			[Token(Token = "0x40052D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public string opacityTexURL;

			// Token: 0x040052D3 RID: 21203
			[Token(Token = "0x40052D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Action<GameObject> OnSuccess;

			// Token: 0x040052D4 RID: 21204
			[Token(Token = "0x40052D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private float <lastTime>5__2;

			// Token: 0x040052D5 RID: 21205
			[Token(Token = "0x40052D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private float <startTime>5__3;
		}

		// Token: 0x020009D4 RID: 2516
		[Token(Token = "0x20009D4")]
		[StructLayout(3)]
		private struct <Build>d__43 : IEnumerator<object>
		{
			// Token: 0x060035C6 RID: 13766 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035C6")]
			[Address(RVA = "0xD816E0", Offset = "0xD806E0", VA = "0x180D816E0", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x060035C7 RID: 13767 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035C7")]
			[Address(RVA = "0xD830F0", Offset = "0xD820F0", VA = "0x180D830F0", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040052D6 RID: 21206
			[Token(Token = "0x40052D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040052D7 RID: 21207
			[Token(Token = "0x40052D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040052D8 RID: 21208
			[Token(Token = "0x40052D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			// Token: 0x040052D9 RID: 21209
			[Token(Token = "0x40052D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string absolutePath;

			// Token: 0x040052DA RID: 21210
			[Token(Token = "0x40052DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string texturesFolderPath;

			// Token: 0x040052DB RID: 21211
			[Token(Token = "0x40052DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string objName;

			// Token: 0x040052DC RID: 21212
			[Token(Token = "0x40052DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform parentTransform;

			// Token: 0x040052DD RID: 21213
			[Token(Token = "0x40052DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <prevTime>5__2;

			// Token: 0x040052DE RID: 21214
			[Token(Token = "0x40052DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private string <basePath>5__3;

			// Token: 0x040052DF RID: 21215
			[Token(Token = "0x40052DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int <count>5__4;

			// Token: 0x040052E0 RID: 21216
			[Token(Token = "0x40052E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private List<MaterialData>.Enumerator <>7__wrap4;

			// Token: 0x040052E1 RID: 21217
			[Token(Token = "0x40052E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private MaterialData <mtl>5__6;

			// Token: 0x040052E2 RID: 21218
			[Token(Token = "0x40052E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020009D5 RID: 2517
		[Token(Token = "0x20009D5")]
		[StructLayout(3)]
		private struct <NetworkedBuild>d__44 : IEnumerator<object>
		{
			// Token: 0x060035C8 RID: 13768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035C8")]
			[Address(RVA = "0xD83150", Offset = "0xD82150", VA = "0x180D83150", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x060035C9 RID: 13769 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035C9")]
			[Address(RVA = "0xD85280", Offset = "0xD84280", VA = "0x180D85280", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040052E3 RID: 21219
			[Token(Token = "0x40052E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040052E4 RID: 21220
			[Token(Token = "0x40052E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040052E5 RID: 21221
			[Token(Token = "0x40052E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			// Token: 0x040052E6 RID: 21222
			[Token(Token = "0x40052E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string diffuseTexURL;

			// Token: 0x040052E7 RID: 21223
			[Token(Token = "0x40052E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bumpTexURL;

			// Token: 0x040052E8 RID: 21224
			[Token(Token = "0x40052E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string specularTexURL;

			// Token: 0x040052E9 RID: 21225
			[Token(Token = "0x40052E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string opacityTexURL;

			// Token: 0x040052EA RID: 21226
			[Token(Token = "0x40052EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string objName;

			// Token: 0x040052EB RID: 21227
			[Token(Token = "0x40052EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform parentTransform;

			// Token: 0x040052EC RID: 21228
			[Token(Token = "0x40052EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string objURL;

			// Token: 0x040052ED RID: 21229
			[Token(Token = "0x40052ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float <prevTime>5__2;

			// Token: 0x040052EE RID: 21230
			[Token(Token = "0x40052EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private ObjectBuilder.ProgressInfo <info>5__3;

			// Token: 0x040052EF RID: 21231
			[Token(Token = "0x40052EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private float <objInitPerc>5__4;

			// Token: 0x040052F0 RID: 21232
			[Token(Token = "0x40052F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private GameObject <newObj>5__5;

			// Token: 0x040052F1 RID: 21233
			[Token(Token = "0x40052F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private float <initProgress>5__6;

			// Token: 0x040052F2 RID: 21234
			[Token(Token = "0x40052F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private int <count>5__7;

			// Token: 0x040052F3 RID: 21235
			[Token(Token = "0x40052F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private List<MaterialData>.Enumerator <>7__wrap7;

			// Token: 0x040052F4 RID: 21236
			[Token(Token = "0x40052F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private MaterialData <mtl>5__9;

			// Token: 0x040052F5 RID: 21237
			[Token(Token = "0x40052F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020009D6 RID: 2518
		[Token(Token = "0x20009D6")]
		private sealed class <NetworkedBuildWebGL>d__45 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x060035CA RID: 13770 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035CA")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <NetworkedBuildWebGL>d__45(int <>1__state)
			{
			}

			// Token: 0x060035CB RID: 13771 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035CB")]
			[Address(RVA = "0xD852E0", Offset = "0xD842E0", VA = "0x180D852E0", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x060035CC RID: 13772 RVA: 0x00012A68 File Offset: 0x00010C68
			[Token(Token = "0x60035CC")]
			[Address(RVA = "0xD853A0", Offset = "0xD843A0", VA = "0x180D853A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x060035CD RID: 13773 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035CD")]
			[Address(RVA = "0xD86A00", Offset = "0xD85A00", VA = "0x180D86A00")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000564 RID: 1380
			// (get) Token: 0x060035CE RID: 13774 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000564")]
			private object Current
			{
				[Token(Token = "0x60035CE")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060035CF RID: 13775 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035CF")]
			[Address(RVA = "0xD86A50", Offset = "0xD85A50", VA = "0x180D86A50", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000565 RID: 1381
			// (get) Token: 0x060035D0 RID: 13776 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000565")]
			private object Current
			{
				[Token(Token = "0x60035D0")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x040052F6 RID: 21238
			[Token(Token = "0x40052F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040052F7 RID: 21239
			[Token(Token = "0x40052F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040052F8 RID: 21240
			[Token(Token = "0x40052F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			// Token: 0x040052F9 RID: 21241
			[Token(Token = "0x40052F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string diffuseTexURL;

			// Token: 0x040052FA RID: 21242
			[Token(Token = "0x40052FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bumpTexURL;

			// Token: 0x040052FB RID: 21243
			[Token(Token = "0x40052FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string specularTexURL;

			// Token: 0x040052FC RID: 21244
			[Token(Token = "0x40052FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string opacityTexURL;

			// Token: 0x040052FD RID: 21245
			[Token(Token = "0x40052FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string objName;

			// Token: 0x040052FE RID: 21246
			[Token(Token = "0x40052FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform parentTransform;

			// Token: 0x040052FF RID: 21247
			[Token(Token = "0x40052FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string objURL;

			// Token: 0x04005300 RID: 21248
			[Token(Token = "0x4005300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float <prevTime>5__2;

			// Token: 0x04005301 RID: 21249
			[Token(Token = "0x4005301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private int <count>5__3;

			// Token: 0x04005302 RID: 21250
			[Token(Token = "0x4005302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private List<MaterialData>.Enumerator <>7__wrap3;

			// Token: 0x04005303 RID: 21251
			[Token(Token = "0x4005303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private MaterialData <mtl>5__5;
		}

		// Token: 0x020009D7 RID: 2519
		[Token(Token = "0x20009D7")]
		[StructLayout(3)]
		private struct <LoadMaterialTexture>d__51 : IEnumerator<object>
		{
			// Token: 0x060035D1 RID: 13777 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035D1")]
			[Address(RVA = "0xD86B20", Offset = "0xD85B20", VA = "0x180D86B20", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x060035D2 RID: 13778 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035D2")]
			[Address(RVA = "0xD87560", Offset = "0xD86560", VA = "0x180D87560", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04005304 RID: 21252
			[Token(Token = "0x4005304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04005305 RID: 21253
			[Token(Token = "0x4005305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04005306 RID: 21254
			[Token(Token = "0x4005306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			// Token: 0x04005307 RID: 21255
			[Token(Token = "0x4005307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string texturesFolderPath;

			// Token: 0x04005308 RID: 21256
			[Token(Token = "0x4005308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string basePath;

			// Token: 0x04005309 RID: 21257
			[Token(Token = "0x4005309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string path;

			// Token: 0x0400530A RID: 21258
			[Token(Token = "0x400530A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private byte[] <result>5__2;

			// Token: 0x0400530B RID: 21259
			[Token(Token = "0x400530B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private FileStream <stream>5__3;

			// Token: 0x0400530C RID: 21260
			[Token(Token = "0x400530C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x020009D8 RID: 2520
		[Token(Token = "0x20009D8")]
		private sealed class <>c__DisplayClass52_0
		{
			// Token: 0x060035D3 RID: 13779 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035D3")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass52_0()
			{
			}

			// Token: 0x060035D4 RID: 13780 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035D4")]
			[Address(RVA = "0xD875C0", Offset = "0xD865C0", VA = "0x180D875C0")]
			internal void <LoadMaterialTexture>b__0(byte[] bytes)
			{
			}

			// Token: 0x060035D5 RID: 13781 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035D5")]
			[Address(RVA = "0xD87620", Offset = "0xD86620", VA = "0x180D87620")]
			internal void <LoadMaterialTexture>b__1(string error)
			{
			}

			// Token: 0x0400530D RID: 21261
			[Token(Token = "0x400530D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			// Token: 0x0400530E RID: 21262
			[Token(Token = "0x400530E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] downloadedBytes;
		}

		// Token: 0x020009D9 RID: 2521
		[Token(Token = "0x20009D9")]
		[StructLayout(3)]
		private struct <LoadMaterialTexture>d__52 : IEnumerator<object>
		{
			// Token: 0x060035D6 RID: 13782 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035D6")]
			[Address(RVA = "0xD876D0", Offset = "0xD866D0", VA = "0x180D876D0", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x060035D7 RID: 13783 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035D7")]
			[Address(RVA = "0xD87FE0", Offset = "0xD86FE0", VA = "0x180D87FE0", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400530F RID: 21263
			[Token(Token = "0x400530F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04005310 RID: 21264
			[Token(Token = "0x4005310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04005311 RID: 21265
			[Token(Token = "0x4005311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			// Token: 0x04005312 RID: 21266
			[Token(Token = "0x4005312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string textureURL;

			// Token: 0x04005313 RID: 21267
			[Token(Token = "0x4005313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Loader.<>c__DisplayClass52_0 <>8__1;

			// Token: 0x04005314 RID: 21268
			[Token(Token = "0x4005314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020009DA RID: 2522
		[Token(Token = "0x20009DA")]
		private sealed class <>c__DisplayClass53_0
		{
			// Token: 0x060035D8 RID: 13784 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035D8")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass53_0()
			{
			}

			// Token: 0x060035D9 RID: 13785 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035D9")]
			[Address(RVA = "0xD88040", Offset = "0xD87040", VA = "0x180D88040")]
			internal void <LoadMaterialTextureWebGL>b__0(Texture2D texture)
			{
			}

			// Token: 0x060035DA RID: 13786 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035DA")]
			[Address(RVA = "0xD880B0", Offset = "0xD870B0", VA = "0x180D880B0")]
			internal void <LoadMaterialTextureWebGL>b__1(string error)
			{
			}

			// Token: 0x04005315 RID: 21269
			[Token(Token = "0x4005315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			// Token: 0x04005316 RID: 21270
			[Token(Token = "0x4005316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Loader <>4__this;
		}

		// Token: 0x020009DB RID: 2523
		[Token(Token = "0x20009DB")]
		private sealed class <LoadMaterialTextureWebGL>d__53 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x060035DB RID: 13787 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035DB")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <LoadMaterialTextureWebGL>d__53(int <>1__state)
			{
			}

			// Token: 0x060035DC RID: 13788 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035DC")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x060035DD RID: 13789 RVA: 0x00012A80 File Offset: 0x00010C80
			[Token(Token = "0x60035DD")]
			[Address(RVA = "0xD88160", Offset = "0xD87160", VA = "0x180D88160", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000566 RID: 1382
			// (get) Token: 0x060035DE RID: 13790 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000566")]
			private object Current
			{
				[Token(Token = "0x60035DE")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060035DF RID: 13791 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035DF")]
			[Address(RVA = "0xD88810", Offset = "0xD87810", VA = "0x180D88810", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000567 RID: 1383
			// (get) Token: 0x060035E0 RID: 13792 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000567")]
			private object Current
			{
				[Token(Token = "0x60035E0")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04005317 RID: 21271
			[Token(Token = "0x4005317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04005318 RID: 21272
			[Token(Token = "0x4005318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04005319 RID: 21273
			[Token(Token = "0x4005319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			// Token: 0x0400531A RID: 21274
			[Token(Token = "0x400531A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string textureURL;

			// Token: 0x0400531B RID: 21275
			[Token(Token = "0x400531B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Loader.<>c__DisplayClass53_0 <>8__1;
		}

		// Token: 0x020009DC RID: 2524
		[Token(Token = "0x20009DC")]
		private sealed class <DownloadFile>d__57 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x060035E1 RID: 13793 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035E1")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <DownloadFile>d__57(int <>1__state)
			{
			}

			// Token: 0x060035E2 RID: 13794 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035E2")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x060035E3 RID: 13795 RVA: 0x00012A98 File Offset: 0x00010C98
			[Token(Token = "0x60035E3")]
			[Address(RVA = "0xD88860", Offset = "0xD87860", VA = "0x180D88860", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000568 RID: 1384
			// (get) Token: 0x060035E4 RID: 13796 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000568")]
			private object Current
			{
				[Token(Token = "0x60035E4")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060035E5 RID: 13797 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035E5")]
			[Address(RVA = "0xD88CF0", Offset = "0xD87CF0", VA = "0x180D88CF0", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000569 RID: 1385
			// (get) Token: 0x060035E6 RID: 13798 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000569")]
			private object Current
			{
				[Token(Token = "0x60035E6")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400531C RID: 21276
			[Token(Token = "0x400531C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400531D RID: 21277
			[Token(Token = "0x400531D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400531E RID: 21278
			[Token(Token = "0x400531E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			// Token: 0x0400531F RID: 21279
			[Token(Token = "0x400531F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			// Token: 0x04005320 RID: 21280
			[Token(Token = "0x4005320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> OnError;

			// Token: 0x04005321 RID: 21281
			[Token(Token = "0x4005321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Loader <>4__this;

			// Token: 0x04005322 RID: 21282
			[Token(Token = "0x4005322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<byte[]> DownloadComplete;

			// Token: 0x04005323 RID: 21283
			[Token(Token = "0x4005323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private WWW <www>5__2;

			// Token: 0x04005324 RID: 21284
			[Token(Token = "0x4005324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <oldProgress>5__3;

			// Token: 0x04005325 RID: 21285
			[Token(Token = "0x4005325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Coroutine <progress>5__4;
		}

		// Token: 0x020009DD RID: 2525
		[Token(Token = "0x20009DD")]
		private sealed class <GetProgress>d__58 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x060035E7 RID: 13799 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035E7")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <GetProgress>d__58(int <>1__state)
			{
			}

			// Token: 0x060035E8 RID: 13800 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035E8")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x060035E9 RID: 13801 RVA: 0x00012AB0 File Offset: 0x00010CB0
			[Token(Token = "0x60035E9")]
			[Address(RVA = "0xD88D40", Offset = "0xD87D40", VA = "0x180D88D40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700056A RID: 1386
			// (get) Token: 0x060035EA RID: 13802 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700056A")]
			private object Current
			{
				[Token(Token = "0x60035EA")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060035EB RID: 13803 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035EB")]
			[Address(RVA = "0xD89010", Offset = "0xD88010", VA = "0x180D89010", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x1700056B RID: 1387
			// (get) Token: 0x060035EC RID: 13804 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700056B")]
			private object Current
			{
				[Token(Token = "0x60035EC")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04005326 RID: 21286
			[Token(Token = "0x4005326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04005327 RID: 21287
			[Token(Token = "0x4005327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04005328 RID: 21288
			[Token(Token = "0x4005328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			// Token: 0x04005329 RID: 21289
			[Token(Token = "0x4005329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public WWW www;

			// Token: 0x0400532A RID: 21290
			[Token(Token = "0x400532A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldProgress>5__2;
		}

		// Token: 0x020009DE RID: 2526
		[Token(Token = "0x20009DE")]
		private sealed class <DownloadFileWebGL>d__59 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x060035ED RID: 13805 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035ED")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <DownloadFileWebGL>d__59(int <>1__state)
			{
			}

			// Token: 0x060035EE RID: 13806 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035EE")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x060035EF RID: 13807 RVA: 0x00012AC8 File Offset: 0x00010CC8
			[Token(Token = "0x60035EF")]
			[Address(RVA = "0xD89060", Offset = "0xD88060", VA = "0x180D89060", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700056C RID: 1388
			// (get) Token: 0x060035F0 RID: 13808 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700056C")]
			private object Current
			{
				[Token(Token = "0x60035F0")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060035F1 RID: 13809 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035F1")]
			[Address(RVA = "0xD895F0", Offset = "0xD885F0", VA = "0x180D895F0", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x1700056D RID: 1389
			// (get) Token: 0x060035F2 RID: 13810 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700056D")]
			private object Current
			{
				[Token(Token = "0x60035F2")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400532B RID: 21291
			[Token(Token = "0x400532B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400532C RID: 21292
			[Token(Token = "0x400532C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400532D RID: 21293
			[Token(Token = "0x400532D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			// Token: 0x0400532E RID: 21294
			[Token(Token = "0x400532E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			// Token: 0x0400532F RID: 21295
			[Token(Token = "0x400532F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> OnError;

			// Token: 0x04005330 RID: 21296
			[Token(Token = "0x4005330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Loader <>4__this;

			// Token: 0x04005331 RID: 21297
			[Token(Token = "0x4005331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<string> DownloadComplete;

			// Token: 0x04005332 RID: 21298
			[Token(Token = "0x4005332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private WWW <www>5__2;

			// Token: 0x04005333 RID: 21299
			[Token(Token = "0x4005333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <oldProgress>5__3;

			// Token: 0x04005334 RID: 21300
			[Token(Token = "0x4005334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Coroutine <progress>5__4;
		}

		// Token: 0x020009DF RID: 2527
		[Token(Token = "0x20009DF")]
		private sealed class <DownloadTexFileWebGL>d__60 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x060035F3 RID: 13811 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035F3")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <DownloadTexFileWebGL>d__60(int <>1__state)
			{
			}

			// Token: 0x060035F4 RID: 13812 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035F4")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x060035F5 RID: 13813 RVA: 0x00012AE0 File Offset: 0x00010CE0
			[Token(Token = "0x60035F5")]
			[Address(RVA = "0xD89640", Offset = "0xD88640", VA = "0x180D89640", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700056E RID: 1390
			// (get) Token: 0x060035F6 RID: 13814 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700056E")]
			private object Current
			{
				[Token(Token = "0x60035F6")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060035F7 RID: 13815 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035F7")]
			[Address(RVA = "0xD89BF0", Offset = "0xD88BF0", VA = "0x180D89BF0", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x1700056F RID: 1391
			// (get) Token: 0x060035F8 RID: 13816 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700056F")]
			private object Current
			{
				[Token(Token = "0x60035F8")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04005335 RID: 21301
			[Token(Token = "0x4005335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04005336 RID: 21302
			[Token(Token = "0x4005336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04005337 RID: 21303
			[Token(Token = "0x4005337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			// Token: 0x04005338 RID: 21304
			[Token(Token = "0x4005338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			// Token: 0x04005339 RID: 21305
			[Token(Token = "0x4005339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> OnError;

			// Token: 0x0400533A RID: 21306
			[Token(Token = "0x400533A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Loader <>4__this;

			// Token: 0x0400533B RID: 21307
			[Token(Token = "0x400533B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<Texture2D> DownloadComplete;

			// Token: 0x0400533C RID: 21308
			[Token(Token = "0x400533C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private WWW <www>5__2;

			// Token: 0x0400533D RID: 21309
			[Token(Token = "0x400533D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <oldProgress>5__3;

			// Token: 0x0400533E RID: 21310
			[Token(Token = "0x400533E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Coroutine <progress>5__4;
		}
	}
}
