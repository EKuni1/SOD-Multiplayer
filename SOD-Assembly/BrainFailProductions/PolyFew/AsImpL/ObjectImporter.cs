using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BrainFailProductions.PolyFewRuntime;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x020009F3 RID: 2547
	[Token(Token = "0x20009F3")]
	public class ObjectImporter : MonoBehaviour
	{
		// Token: 0x06003642 RID: 13890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003642")]
		[Address(RVA = "0xD94290", Offset = "0xD93290", VA = "0x180D94290")]
		public ObjectImporter()
		{
		}

		// Token: 0x1400007D RID: 125
		// (add) Token: 0x06003643 RID: 13891 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003644 RID: 13892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007D")]
		public event Action ImportingStart
		{
			[Token(Token = "0x6003643")]
			[Address(RVA = "0xD943F0", Offset = "0xD933F0", VA = "0x180D943F0")]
			add
			{
			}
			[Token(Token = "0x6003644")]
			[Address(RVA = "0xD944E0", Offset = "0xD934E0", VA = "0x180D944E0")]
			remove
			{
			}
		}

		// Token: 0x1400007E RID: 126
		// (add) Token: 0x06003645 RID: 13893 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003646 RID: 13894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007E")]
		public event Action ImportingComplete
		{
			[Token(Token = "0x6003645")]
			[Address(RVA = "0xD945D0", Offset = "0xD935D0", VA = "0x180D945D0")]
			add
			{
			}
			[Token(Token = "0x6003646")]
			[Address(RVA = "0xD946C0", Offset = "0xD936C0", VA = "0x180D946C0")]
			remove
			{
			}
		}

		// Token: 0x1400007F RID: 127
		// (add) Token: 0x06003647 RID: 13895 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003648 RID: 13896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007F")]
		public event Action<GameObject, string> CreatedModel
		{
			[Token(Token = "0x6003647")]
			[Address(RVA = "0xD947B0", Offset = "0xD937B0", VA = "0x180D947B0")]
			add
			{
			}
			[Token(Token = "0x6003648")]
			[Address(RVA = "0xD948C0", Offset = "0xD938C0", VA = "0x180D948C0")]
			remove
			{
			}
		}

		// Token: 0x14000080 RID: 128
		// (add) Token: 0x06003649 RID: 13897 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600364A RID: 13898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000080")]
		public event Action<GameObject, string> ImportedModel
		{
			[Token(Token = "0x6003649")]
			[Address(RVA = "0xD949D0", Offset = "0xD939D0", VA = "0x180D949D0")]
			add
			{
			}
			[Token(Token = "0x600364A")]
			[Address(RVA = "0xD94AE0", Offset = "0xD93AE0", VA = "0x180D94AE0")]
			remove
			{
			}
		}

		// Token: 0x14000081 RID: 129
		// (add) Token: 0x0600364B RID: 13899 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600364C RID: 13900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000081")]
		public event Action<string> ImportError
		{
			[Token(Token = "0x600364B")]
			[Address(RVA = "0xD94BF0", Offset = "0xD93BF0", VA = "0x180D94BF0")]
			add
			{
			}
			[Token(Token = "0x600364C")]
			[Address(RVA = "0xD94D00", Offset = "0xD93D00", VA = "0x180D94D00")]
			remove
			{
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x0600364D RID: 13901 RVA: 0x00012BA0 File Offset: 0x00010DA0
		[Token(Token = "0x17000578")]
		public int NumImportRequests
		{
			[Token(Token = "0x600364D")]
			[Address(RVA = "0x6AA6E0", Offset = "0x6A96E0", VA = "0x1806AA6E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600364E")]
		[Address(RVA = "0xD94E10", Offset = "0xD93E10", VA = "0x180D94E10")]
		private Loader CreateLoader(string absolutePath, bool isNetwork = false)
		{
			return null;
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600364F")]
		[Address(RVA = "0xD951D0", Offset = "0xD941D0", VA = "0x180D951D0")]
		public Task<GameObject> ImportModelAsync(string objName, string filePath, Transform parentObj, ImportOptions options, string texturesFolderPath = "", string materialsFolderPath = "")
		{
			return null;
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003650")]
		[Address(RVA = "0xD95570", Offset = "0xD94570", VA = "0x180D95570")]
		public Task<GameObject> ImportModelFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, ImportOptions options)
		{
			return null;
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003651")]
		[Address(RVA = "0xD95A10", Offset = "0xD94A10", VA = "0x180D95A10")]
		public void ImportModelFromNetworkWebGL(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, ImportOptions options, Action<GameObject> OnSuccess, Action<Exception> OnError)
		{
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003652")]
		[Address(RVA = "0xD95E80", Offset = "0xD94E80", VA = "0x180D95E80", Slot = "4")]
		public virtual void UpdateStatus()
		{
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003653")]
		[Address(RVA = "0xD96110", Offset = "0xD95110", VA = "0x180D96110", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003654")]
		[Address(RVA = "0x528560", Offset = "0x527560", VA = "0x180528560", Slot = "6")]
		protected virtual void OnImportingComplete()
		{
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003655")]
		[Address(RVA = "0xD96130", Offset = "0xD95130", VA = "0x180D96130", Slot = "7")]
		protected virtual void OnModelCreated(GameObject obj, string absolutePath)
		{
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003656")]
		[Address(RVA = "0xD96150", Offset = "0xD95150", VA = "0x180D96150", Slot = "8")]
		protected virtual void OnImported(GameObject obj, string absolutePath)
		{
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003657")]
		[Address(RVA = "0xD96170", Offset = "0xD95170", VA = "0x180D96170", Slot = "9")]
		protected virtual void OnImportError(string absolutePath)
		{
		}

		// Token: 0x04005399 RID: 21401
		[Token(Token = "0x4005399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

		// Token: 0x0400539A RID: 21402
		[Token(Token = "0x400539A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int activeDownloads;

		// Token: 0x0400539B RID: 21403
		[Token(Token = "0x400539B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static float objDownloadProgress;

		// Token: 0x0400539C RID: 21404
		[Token(Token = "0x400539C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static float textureDownloadProgress;

		// Token: 0x0400539D RID: 21405
		[Token(Token = "0x400539D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static float materialDownloadProgress;

		// Token: 0x0400539E RID: 21406
		[Token(Token = "0x400539E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isException;

		// Token: 0x0400539F RID: 21407
		[Token(Token = "0x400539F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int numTotalImports;

		// Token: 0x040053A0 RID: 21408
		[Token(Token = "0x40053A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected bool allLoaded;

		// Token: 0x040053A1 RID: 21409
		[Token(Token = "0x40053A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ImportOptions buildOptions;

		// Token: 0x040053A2 RID: 21410
		[Token(Token = "0x40053A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected List<Loader> loaderList;

		// Token: 0x040053A3 RID: 21411
		[Token(Token = "0x40053A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ObjectImporter.ImportPhase importPhase;

		// Token: 0x020009F4 RID: 2548
		[Token(Token = "0x20009F4")]
		private enum ImportPhase
		{
			// Token: 0x040053AA RID: 21418
			[Token(Token = "0x40053AA")]
			Idle,
			// Token: 0x040053AB RID: 21419
			[Token(Token = "0x40053AB")]
			TextureImport,
			// Token: 0x040053AC RID: 21420
			[Token(Token = "0x40053AC")]
			ObjLoad,
			// Token: 0x040053AD RID: 21421
			[Token(Token = "0x40053AD")]
			AssetBuild,
			// Token: 0x040053AE RID: 21422
			[Token(Token = "0x40053AE")]
			Done
		}

		// Token: 0x020009F5 RID: 2549
		[Token(Token = "0x20009F5")]
		[StructLayout(3)]
		private struct <ImportModelAsync>d__31 : IEnumerator<object>
		{
			// Token: 0x06003658 RID: 13912 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003658")]
			[Address(RVA = "0xD96190", Offset = "0xD95190", VA = "0x180D96190", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06003659 RID: 13913 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003659")]
			[Address(RVA = "0xD967C0", Offset = "0xD957C0", VA = "0x180D967C0", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040053AF RID: 21423
			[Token(Token = "0x40053AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040053B0 RID: 21424
			[Token(Token = "0x40053B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> <>t__builder;

			// Token: 0x040053B1 RID: 21425
			[Token(Token = "0x40053B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ObjectImporter <>4__this;

			// Token: 0x040053B2 RID: 21426
			[Token(Token = "0x40053B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string filePath;

			// Token: 0x040053B3 RID: 21427
			[Token(Token = "0x40053B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ImportOptions options;

			// Token: 0x040053B4 RID: 21428
			[Token(Token = "0x40053B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string objName;

			// Token: 0x040053B5 RID: 21429
			[Token(Token = "0x40053B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform parentObj;

			// Token: 0x040053B6 RID: 21430
			[Token(Token = "0x40053B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string texturesFolderPath;

			// Token: 0x040053B7 RID: 21431
			[Token(Token = "0x40053B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string materialsFolderPath;

			// Token: 0x040053B8 RID: 21432
			[Token(Token = "0x40053B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private TaskAwaiter<GameObject> <>u__1;
		}

		// Token: 0x020009F6 RID: 2550
		[Token(Token = "0x20009F6")]
		[StructLayout(3)]
		private struct <ImportModelFromNetwork>d__32 : IEnumerator<object>
		{
			// Token: 0x0600365A RID: 13914 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600365A")]
			[Address(RVA = "0xD96830", Offset = "0xD95830", VA = "0x180D96830", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x0600365B RID: 13915 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600365B")]
			[Address(RVA = "0xD96EE0", Offset = "0xD95EE0", VA = "0x180D96EE0", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040053B9 RID: 21433
			[Token(Token = "0x40053B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040053BA RID: 21434
			[Token(Token = "0x40053BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> <>t__builder;

			// Token: 0x040053BB RID: 21435
			[Token(Token = "0x40053BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ObjectImporter <>4__this;

			// Token: 0x040053BC RID: 21436
			[Token(Token = "0x40053BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ImportOptions options;

			// Token: 0x040053BD RID: 21437
			[Token(Token = "0x40053BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objName;

			// Token: 0x040053BE RID: 21438
			[Token(Token = "0x40053BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			// Token: 0x040053BF RID: 21439
			[Token(Token = "0x40053BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string objURL;

			// Token: 0x040053C0 RID: 21440
			[Token(Token = "0x40053C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string diffuseTexURL;

			// Token: 0x040053C1 RID: 21441
			[Token(Token = "0x40053C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string bumpTexURL;

			// Token: 0x040053C2 RID: 21442
			[Token(Token = "0x40053C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string specularTexURL;

			// Token: 0x040053C3 RID: 21443
			[Token(Token = "0x40053C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public string opacityTexURL;

			// Token: 0x040053C4 RID: 21444
			[Token(Token = "0x40053C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public string materialURL;

			// Token: 0x040053C5 RID: 21445
			[Token(Token = "0x40053C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private TaskAwaiter<GameObject> <>u__1;
		}
	}
}
