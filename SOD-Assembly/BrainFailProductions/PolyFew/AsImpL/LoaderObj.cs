using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x020009E0 RID: 2528
	[Token(Token = "0x20009E0")]
	public class LoaderObj : Loader
	{
		// Token: 0x060035F9 RID: 13817 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035F9")]
		[Address(RVA = "0xD89C40", Offset = "0xD88C40", VA = "0x180D89C40", Slot = "5")]
		public override string[] ParseTexturePaths(string absolutePath)
		{
			return null;
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035FA")]
		[Address(RVA = "0xD8A0E0", Offset = "0xD890E0", VA = "0x180D8A0E0", Slot = "6")]
		protected override Task LoadModelFile(string absolutePath, string texturesFolderPath = "", string materialsFolderPath = "")
		{
			return null;
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035FB")]
		[Address(RVA = "0xD8A2F0", Offset = "0xD892F0", VA = "0x180D8A2F0", Slot = "7")]
		protected override Task LoadModelFileNetworked(string objURL)
		{
			return null;
		}

		// Token: 0x060035FC RID: 13820 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035FC")]
		[Address(RVA = "0xD8A500", Offset = "0xD89500", VA = "0x180D8A500", Slot = "8")]
		protected override IEnumerator LoadModelFileNetworkedWebGL(string objURL, Action<Exception> OnError)
		{
			return null;
		}

		// Token: 0x060035FD RID: 13821 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035FD")]
		[Address(RVA = "0xD8A670", Offset = "0xD89670", VA = "0x180D8A670", Slot = "9")]
		protected override Task LoadMaterialLibrary(string absolutePath, string materialsFolderPath = "")
		{
			return null;
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035FE")]
		[Address(RVA = "0xD8A8F0", Offset = "0xD898F0", VA = "0x180D8A8F0", Slot = "10")]
		protected override Task LoadMaterialLibrary(string materialURL)
		{
			return null;
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035FF")]
		[Address(RVA = "0xD8AB00", Offset = "0xD89B00", VA = "0x180D8AB00", Slot = "11")]
		protected override IEnumerator LoadMaterialLibraryWebGL(string materialURL)
		{
			return null;
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003600")]
		[Address(RVA = "0xD8AC10", Offset = "0xD89C10", VA = "0x180D8AC10")]
		private void GetFaceIndicesByOneFaceLine(DataSet.FaceIndices[] faces, string[] p, bool isFaceIndexPlus)
		{
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x00012AF8 File Offset: 0x00010CF8
		[Token(Token = "0x6003601")]
		[Address(RVA = "0xD8B2A0", Offset = "0xD8A2A0", VA = "0x180D8B2A0")]
		private Vector3 ConvertVec3(float x, float y, float z)
		{
			return default(Vector3);
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x00012B10 File Offset: 0x00010D10
		[Token(Token = "0x6003602")]
		[Address(RVA = "0xD8B330", Offset = "0xD8A330", VA = "0x180D8B330")]
		private float ParseFloat(string floatString)
		{
			return 0f;
		}

		// Token: 0x06003603 RID: 13827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003603")]
		[Address(RVA = "0xD8B3F0", Offset = "0xD8A3F0", VA = "0x180D8B3F0")]
		protected void ParseGeometryData(string objDataText)
		{
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003604")]
		[Address(RVA = "0xD8BFB0", Offset = "0xD8AFB0", VA = "0x180D8BFB0")]
		private string ParseMaterialLibName(string path)
		{
			return null;
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06003605 RID: 13829 RVA: 0x00012B28 File Offset: 0x00010D28
		[Token(Token = "0x17000570")]
		protected override bool HasMaterialLibrary
		{
			[Token(Token = "0x6003605")]
			[Address(RVA = "0xD8C130", Offset = "0xD8B130", VA = "0x180D8C130", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003606 RID: 13830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003606")]
		[Address(RVA = "0xD8C140", Offset = "0xD8B140", VA = "0x180D8C140")]
		private void ParseMaterialData(string data)
		{
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003607")]
		[Address(RVA = "0xD8C370", Offset = "0xD8B370", VA = "0x180D8C370")]
		private void ParseMaterialData(string[] lines, List<MaterialData> mtlData)
		{
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003608")]
		[Address(RVA = "0xD8D4A0", Offset = "0xD8C4A0", VA = "0x180D8D4A0")]
		private void ParseBumpParameters(string[] param, MaterialData mtlData)
		{
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x00012B40 File Offset: 0x00010D40
		[Token(Token = "0x6003609")]
		[Address(RVA = "0xD8E280", Offset = "0xD8D280", VA = "0x180D8E280")]
		private Color StringsToColor(string[] p)
		{
			return default(Color);
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600360A")]
		[Address(RVA = "0xD8E330", Offset = "0xD8D330", VA = "0x180D8E330")]
		private IEnumerator LoadOrDownloadText(string url, bool notifyErrors = true)
		{
			return null;
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600360B")]
		[Address(RVA = "0xD8E460", Offset = "0xD8D460", VA = "0x180D8E460")]
		public LoaderObj()
		{
		}

		// Token: 0x0400533F RID: 21311
		[Token(Token = "0x400533F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string mtlLib;

		// Token: 0x04005340 RID: 21312
		[Token(Token = "0x4005340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string loadedText;

		// Token: 0x020009E1 RID: 2529
		[Token(Token = "0x20009E1")]
		private class BumpParamDef
		{
			// Token: 0x0600360C RID: 13836 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600360C")]
			[Address(RVA = "0xD8E4B0", Offset = "0xD8D4B0", VA = "0x180D8E4B0")]
			public BumpParamDef(string name, string type, int numMin, int numMax)
			{
			}

			// Token: 0x04005341 RID: 21313
			[Token(Token = "0x4005341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string optionName;

			// Token: 0x04005342 RID: 21314
			[Token(Token = "0x4005342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string valueType;

			// Token: 0x04005343 RID: 21315
			[Token(Token = "0x4005343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int valueNumMin;

			// Token: 0x04005344 RID: 21316
			[Token(Token = "0x4005344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int valueNumMax;
		}

		// Token: 0x020009E2 RID: 2530
		[Token(Token = "0x20009E2")]
		[StructLayout(3)]
		private struct <LoadModelFile>d__3 : IEnumerator<object>
		{
			// Token: 0x0600360D RID: 13837 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600360D")]
			[Address(RVA = "0xD8E570", Offset = "0xD8D570", VA = "0x180D8E570", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x0600360E RID: 13838 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600360E")]
			[Address(RVA = "0xD8EC90", Offset = "0xD8DC90", VA = "0x180D8EC90", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04005345 RID: 21317
			[Token(Token = "0x4005345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04005346 RID: 21318
			[Token(Token = "0x4005346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04005347 RID: 21319
			[Token(Token = "0x4005347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string absolutePath;

			// Token: 0x04005348 RID: 21320
			[Token(Token = "0x4005348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LoaderObj <>4__this;

			// Token: 0x04005349 RID: 21321
			[Token(Token = "0x4005349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private StreamReader <sr>5__2;

			// Token: 0x0400534A RID: 21322
			[Token(Token = "0x400534A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<string> <>u__1;
		}

		// Token: 0x020009E3 RID: 2531
		[Token(Token = "0x20009E3")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x0600360F RID: 13839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600360F")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x06003610 RID: 13840 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003610")]
			[Address(RVA = "0xD875C0", Offset = "0xD865C0", VA = "0x180D875C0")]
			internal void <LoadModelFileNetworked>b__0(byte[] bytes)
			{
			}

			// Token: 0x06003611 RID: 13841 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003611")]
			[Address(RVA = "0xD8ECF0", Offset = "0xD8DCF0", VA = "0x180D8ECF0")]
			internal void <LoadModelFileNetworked>b__1(string error)
			{
			}

			// Token: 0x0400534B RID: 21323
			[Token(Token = "0x400534B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			// Token: 0x0400534C RID: 21324
			[Token(Token = "0x400534C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] downloadedBytes;

			// Token: 0x0400534D RID: 21325
			[Token(Token = "0x400534D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Exception ex;
		}

		// Token: 0x020009E4 RID: 2532
		[Token(Token = "0x20009E4")]
		[StructLayout(3)]
		private struct <LoadModelFileNetworked>d__4 : IEnumerator<object>
		{
			// Token: 0x06003612 RID: 13842 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003612")]
			[Address(RVA = "0xD8EE00", Offset = "0xD8DE00", VA = "0x180D8EE00", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06003613 RID: 13843 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003613")]
			[Address(RVA = "0xD8FD50", Offset = "0xD8ED50", VA = "0x180D8FD50", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400534E RID: 21326
			[Token(Token = "0x400534E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400534F RID: 21327
			[Token(Token = "0x400534F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04005350 RID: 21328
			[Token(Token = "0x4005350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			// Token: 0x04005351 RID: 21329
			[Token(Token = "0x4005351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string objURL;

			// Token: 0x04005352 RID: 21330
			[Token(Token = "0x4005352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private LoaderObj.<>c__DisplayClass4_0 <>8__1;

			// Token: 0x04005353 RID: 21331
			[Token(Token = "0x4005353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter <>u__1;

			// Token: 0x04005354 RID: 21332
			[Token(Token = "0x4005354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private StreamReader <sr>5__2;

			// Token: 0x04005355 RID: 21333
			[Token(Token = "0x4005355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<string> <>u__2;
		}

		// Token: 0x020009E5 RID: 2533
		[Token(Token = "0x20009E5")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06003614 RID: 13844 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003614")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x06003615 RID: 13845 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003615")]
			[Address(RVA = "0xD8FDB0", Offset = "0xD8EDB0", VA = "0x180D8FDB0")]
			internal void <LoadModelFileNetworkedWebGL>b__0(string text)
			{
			}

			// Token: 0x06003616 RID: 13846 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003616")]
			[Address(RVA = "0xD8FE20", Offset = "0xD8EE20", VA = "0x180D8FE20")]
			internal void <LoadModelFileNetworkedWebGL>b__1(string error)
			{
			}

			// Token: 0x04005356 RID: 21334
			[Token(Token = "0x4005356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			// Token: 0x04005357 RID: 21335
			[Token(Token = "0x4005357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LoaderObj <>4__this;

			// Token: 0x04005358 RID: 21336
			[Token(Token = "0x4005358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Exception ex;

			// Token: 0x04005359 RID: 21337
			[Token(Token = "0x4005359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<Exception> OnError;
		}

		// Token: 0x020009E6 RID: 2534
		[Token(Token = "0x20009E6")]
		private sealed class <LoadModelFileNetworkedWebGL>d__5 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x06003617 RID: 13847 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003617")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <LoadModelFileNetworkedWebGL>d__5(int <>1__state)
			{
			}

			// Token: 0x06003618 RID: 13848 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003618")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x06003619 RID: 13849 RVA: 0x00012B58 File Offset: 0x00010D58
			[Token(Token = "0x6003619")]
			[Address(RVA = "0xD8FF70", Offset = "0xD8EF70", VA = "0x180D8FF70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000571 RID: 1393
			// (get) Token: 0x0600361A RID: 13850 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000571")]
			private object Current
			{
				[Token(Token = "0x600361A")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600361B RID: 13851 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600361B")]
			[Address(RVA = "0xD90710", Offset = "0xD8F710", VA = "0x180D90710", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000572 RID: 1394
			// (get) Token: 0x0600361C RID: 13852 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000572")]
			private object Current
			{
				[Token(Token = "0x600361C")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400535A RID: 21338
			[Token(Token = "0x400535A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400535B RID: 21339
			[Token(Token = "0x400535B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400535C RID: 21340
			[Token(Token = "0x400535C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			// Token: 0x0400535D RID: 21341
			[Token(Token = "0x400535D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<Exception> OnError;

			// Token: 0x0400535E RID: 21342
			[Token(Token = "0x400535E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objURL;

			// Token: 0x0400535F RID: 21343
			[Token(Token = "0x400535F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private LoaderObj.<>c__DisplayClass5_0 <>8__1;
		}

		// Token: 0x020009E7 RID: 2535
		[Token(Token = "0x20009E7")]
		[StructLayout(3)]
		private struct <LoadMaterialLibrary>d__6 : IEnumerator<object>
		{
			// Token: 0x0600361D RID: 13853 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600361D")]
			[Address(RVA = "0xD90760", Offset = "0xD8F760", VA = "0x180D90760", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x0600361E RID: 13854 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600361E")]
			[Address(RVA = "0xD91020", Offset = "0xD90020", VA = "0x180D91020", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04005360 RID: 21344
			[Token(Token = "0x4005360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04005361 RID: 21345
			[Token(Token = "0x4005361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04005362 RID: 21346
			[Token(Token = "0x4005362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			// Token: 0x04005363 RID: 21347
			[Token(Token = "0x4005363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string absolutePath;

			// Token: 0x04005364 RID: 21348
			[Token(Token = "0x4005364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string materialsFolderPath;

			// Token: 0x04005365 RID: 21349
			[Token(Token = "0x4005365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private StreamReader <sr>5__2;

			// Token: 0x04005366 RID: 21350
			[Token(Token = "0x4005366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<string> <>u__1;
		}

		// Token: 0x020009E8 RID: 2536
		[Token(Token = "0x20009E8")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x0600361F RID: 13855 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600361F")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06003620 RID: 13856 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003620")]
			[Address(RVA = "0xD875C0", Offset = "0xD865C0", VA = "0x180D875C0")]
			internal void <LoadMaterialLibrary>b__0(byte[] bytes)
			{
			}

			// Token: 0x06003621 RID: 13857 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003621")]
			[Address(RVA = "0xD91080", Offset = "0xD90080", VA = "0x180D91080")]
			internal void <LoadMaterialLibrary>b__1(string error)
			{
			}

			// Token: 0x04005367 RID: 21351
			[Token(Token = "0x4005367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			// Token: 0x04005368 RID: 21352
			[Token(Token = "0x4005368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] downloadedBytes;
		}

		// Token: 0x020009E9 RID: 2537
		[Token(Token = "0x20009E9")]
		[StructLayout(3)]
		private struct <LoadMaterialLibrary>d__7 : IEnumerator<object>
		{
			// Token: 0x06003622 RID: 13858 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003622")]
			[Address(RVA = "0xD91130", Offset = "0xD90130", VA = "0x180D91130", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06003623 RID: 13859 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003623")]
			[Address(RVA = "0xD91F60", Offset = "0xD90F60", VA = "0x180D91F60", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04005369 RID: 21353
			[Token(Token = "0x4005369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400536A RID: 21354
			[Token(Token = "0x400536A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400536B RID: 21355
			[Token(Token = "0x400536B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			// Token: 0x0400536C RID: 21356
			[Token(Token = "0x400536C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string materialURL;

			// Token: 0x0400536D RID: 21357
			[Token(Token = "0x400536D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private LoaderObj.<>c__DisplayClass7_0 <>8__1;

			// Token: 0x0400536E RID: 21358
			[Token(Token = "0x400536E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter <>u__1;

			// Token: 0x0400536F RID: 21359
			[Token(Token = "0x400536F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private StreamReader <sr>5__2;

			// Token: 0x04005370 RID: 21360
			[Token(Token = "0x4005370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<string> <>u__2;
		}

		// Token: 0x020009EA RID: 2538
		[Token(Token = "0x20009EA")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06003624 RID: 13860 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003624")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06003625 RID: 13861 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003625")]
			[Address(RVA = "0xD8FDB0", Offset = "0xD8EDB0", VA = "0x180D8FDB0")]
			internal void <LoadMaterialLibraryWebGL>b__0(string text)
			{
			}

			// Token: 0x06003626 RID: 13862 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003626")]
			[Address(RVA = "0xD91FC0", Offset = "0xD90FC0", VA = "0x180D91FC0")]
			internal void <LoadMaterialLibraryWebGL>b__1(string error)
			{
			}

			// Token: 0x04005371 RID: 21361
			[Token(Token = "0x4005371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			// Token: 0x04005372 RID: 21362
			[Token(Token = "0x4005372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LoaderObj <>4__this;
		}

		// Token: 0x020009EB RID: 2539
		[Token(Token = "0x20009EB")]
		private sealed class <LoadMaterialLibraryWebGL>d__8 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x06003627 RID: 13863 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003627")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <LoadMaterialLibraryWebGL>d__8(int <>1__state)
			{
			}

			// Token: 0x06003628 RID: 13864 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003628")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x06003629 RID: 13865 RVA: 0x00012B70 File Offset: 0x00010D70
			[Token(Token = "0x6003629")]
			[Address(RVA = "0xD92070", Offset = "0xD91070", VA = "0x180D92070", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000573 RID: 1395
			// (get) Token: 0x0600362A RID: 13866 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000573")]
			private object Current
			{
				[Token(Token = "0x600362A")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600362B RID: 13867 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600362B")]
			[Address(RVA = "0xD924E0", Offset = "0xD914E0", VA = "0x180D924E0", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000574 RID: 1396
			// (get) Token: 0x0600362C RID: 13868 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000574")]
			private object Current
			{
				[Token(Token = "0x600362C")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04005373 RID: 21363
			[Token(Token = "0x4005373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04005374 RID: 21364
			[Token(Token = "0x4005374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04005375 RID: 21365
			[Token(Token = "0x4005375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			// Token: 0x04005376 RID: 21366
			[Token(Token = "0x4005376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string materialURL;

			// Token: 0x04005377 RID: 21367
			[Token(Token = "0x4005377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private LoaderObj.<>c__DisplayClass8_0 <>8__1;
		}

		// Token: 0x020009EC RID: 2540
		[Token(Token = "0x20009EC")]
		private sealed class <LoadOrDownloadText>d__20 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x0600362D RID: 13869 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600362D")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <LoadOrDownloadText>d__20(int <>1__state)
			{
			}

			// Token: 0x0600362E RID: 13870 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600362E")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x0600362F RID: 13871 RVA: 0x00012B88 File Offset: 0x00010D88
			[Token(Token = "0x600362F")]
			[Address(RVA = "0xD92530", Offset = "0xD91530", VA = "0x180D92530", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000575 RID: 1397
			// (get) Token: 0x06003630 RID: 13872 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000575")]
			private object Current
			{
				[Token(Token = "0x6003630")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003631 RID: 13873 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003631")]
			[Address(RVA = "0xD927A0", Offset = "0xD917A0", VA = "0x180D927A0", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000576 RID: 1398
			// (get) Token: 0x06003632 RID: 13874 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000576")]
			private object Current
			{
				[Token(Token = "0x6003632")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04005378 RID: 21368
			[Token(Token = "0x4005378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04005379 RID: 21369
			[Token(Token = "0x4005379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400537A RID: 21370
			[Token(Token = "0x400537A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			// Token: 0x0400537B RID: 21371
			[Token(Token = "0x400537B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			// Token: 0x0400537C RID: 21372
			[Token(Token = "0x400537C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool notifyErrors;

			// Token: 0x0400537D RID: 21373
			[Token(Token = "0x400537D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest <uwr>5__2;
		}
	}
}
