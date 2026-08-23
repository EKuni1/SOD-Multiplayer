using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace BrainFailProductions.PolyFew
{
	// Token: 0x020009B0 RID: 2480
	[Token(Token = "0x20009B0")]
	public static class SystemServices
	{
		// Token: 0x06003531 RID: 13617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003531")]
		[Address(RVA = "0xD69770", Offset = "0xD68770", VA = "0x180D69770")]
		private static void SetPatterns()
		{
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003532")]
		[Address(RVA = "0xD69AA0", Offset = "0xD68AA0", VA = "0x180D69AA0")]
		public static IEnumerator UnityAsyncGETRequest(string encodedUrl, Action<string, long> callback, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
			return null;
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003533")]
		[Address(RVA = "0xD69C20", Offset = "0xD68C20", VA = "0x180D69C20")]
		public static void UnityBlockingGETRequest(string encodedUrl, Action<string, long> callback, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003534")]
		[Address(RVA = "0xD6A130", Offset = "0xD69130", VA = "0x180D6A130")]
		public static void UnityBlockingPOSTRequest(string baseUrl, Action<string, long> callback, byte[] data, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003535")]
		[Address(RVA = "0xD6A6D0", Offset = "0xD696D0", VA = "0x180D6A6D0")]
		public static IEnumerator UnityAsyncPOSTRequest(string baseUrl, Action<string, long> callback, byte[] data, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
			return null;
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003536")]
		[Address(RVA = "0xD6A8B0", Offset = "0xD698B0", VA = "0x180D6A8B0")]
		public static Task SendHTTPRequestAsync(string baseUrl, SystemServices.HTTPMethod requestMethod, Action<string, HttpStatusCode?> callback, Dictionary<string, string> requestParameters, byte[] postData, string contentType, [Optional] int? timeout, [Optional] Dictionary<string, string> header)
		{
			return null;
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003537")]
		[Address(RVA = "0xD6AC30", Offset = "0xD69C30", VA = "0x180D6AC30")]
		public static void SendHTTPRequestBlocking(string baseUrl, SystemServices.HTTPMethod requestMethod, Action<string, HttpStatusCode?> callback, Dictionary<string, string> requestParameters, byte[] postData, string contentType, [Optional] int? timeout, [Optional] Dictionary<string, string> header)
		{
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003538")]
		[Address(RVA = "0xD6B880", Offset = "0xD6A880", VA = "0x180D6B880")]
		public static Task AsyncResourceDownload(string resourceUrl, Action<byte[], string, HttpStatusCode?> callback, [Optional] int? timeout)
		{
			return null;
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003539")]
		[Address(RVA = "0xD6BAB0", Offset = "0xD6AAB0", VA = "0x180D6BAB0")]
		public static Task AsyncReachabilityCheck(string testUrl, Action<bool> callback)
		{
			return null;
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600353A")]
		[Address(RVA = "0xD6BCB0", Offset = "0xD6ACB0", VA = "0x180D6BCB0")]
		public static void BlockingReachabilityCheck(string url, Action<bool> callback)
		{
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x000128D0 File Offset: 0x00010AD0
		[Token(Token = "0x600353B")]
		[Address(RVA = "0xD6BE30", Offset = "0xD6AE30", VA = "0x180D6BE30")]
		public static SystemServices.MessagePatternPair ParseResponseMessage(string message)
		{
			return default(SystemServices.MessagePatternPair);
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x000128E8 File Offset: 0x00010AE8
		[Token(Token = "0x600353C")]
		[Address(RVA = "0xD6C190", Offset = "0xD6B190", VA = "0x180D6C190")]
		public static bool IsSuccessStatusCode(long statusCode)
		{
			return default(bool);
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600353D")]
		[Address(RVA = "0xD6C1B0", Offset = "0xD6B1B0", VA = "0x180D6C1B0")]
		public static string GetQueryStringFromKeyValues(Dictionary<string, string> parameters)
		{
			return null;
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600353E")]
		[Address(RVA = "0xD6C440", Offset = "0xD6B440", VA = "0x180D6C440")]
		public static Task RunDelayedCommand(float secs, Action command)
		{
			return null;
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600353F")]
		[Address(RVA = "0xD6C600", Offset = "0xD6B600", VA = "0x180D6C600")]
		public static byte[] ReadAllBytes(Stream source)
		{
			return null;
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003540")]
		[Address(RVA = "0xD6C880", Offset = "0xD6B880", VA = "0x180D6C880")]
		public static Task WriteTextureAsync(Texture2D texture, SystemServices.ImageFormat format, string fileName, string path, Action<string> callback)
		{
			return null;
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003541")]
		[Address(RVA = "0xD6CB50", Offset = "0xD6BB50", VA = "0x180D6CB50")]
		public static Task WriteBytesAsync(byte[] data, string fullPath, Action<string> callback)
		{
			return null;
		}

		// Token: 0x040051ED RID: 20973
		[Token(Token = "0x40051ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SystemServices.RegexPatterns regexPatterns;

		// Token: 0x020009B1 RID: 2481
		[Token(Token = "0x20009B1")]
		[Serializable]
		public struct RegexPatterns
		{
			// Token: 0x040051EE RID: 20974
			[Token(Token = "0x40051EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string netError;

			// Token: 0x040051EF RID: 20975
			[Token(Token = "0x40051EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string nullOrEmpty;

			// Token: 0x040051F0 RID: 20976
			[Token(Token = "0x40051F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string generalError;

			// Token: 0x040051F1 RID: 20977
			[Token(Token = "0x40051F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string apiMistmatch;

			// Token: 0x040051F2 RID: 20978
			[Token(Token = "0x40051F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string parametersMismatch;

			// Token: 0x040051F3 RID: 20979
			[Token(Token = "0x40051F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string nothing;
		}

		// Token: 0x020009B2 RID: 2482
		[Token(Token = "0x20009B2")]
		public struct MessagePatternPair
		{
			// Token: 0x17000554 RID: 1364
			// (get) Token: 0x06003543 RID: 13635 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003542 RID: 13634 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000554")]
			public string patternAppended
			{
				[Token(Token = "0x6003543")]
				[Address(RVA = "0x3EB790", Offset = "0x3EA790", VA = "0x1803EB790")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003542")]
				[Address(RVA = "0xD2FF60", Offset = "0xD2EF60", VA = "0x180D2FF60")]
				private set
				{
				}
			}

			// Token: 0x17000555 RID: 1365
			// (get) Token: 0x06003545 RID: 13637 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003544 RID: 13636 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000555")]
			public string parsedMessage
			{
				[Token(Token = "0x6003545")]
				[Address(RVA = "0x3EB7A0", Offset = "0x3EA7A0", VA = "0x1803EB7A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003544")]
				[Address(RVA = "0xA10F90", Offset = "0xA0FF90", VA = "0x180A10F90")]
				private set
				{
				}
			}

			// Token: 0x06003546 RID: 13638 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003546")]
			[Address(RVA = "0x3EB9E0", Offset = "0x3EA9E0", VA = "0x1803EB9E0")]
			public MessagePatternPair(string patternAppended, string parsedMessage)
			{
			}

			// Token: 0x040051F4 RID: 20980
			[Token(Token = "0x40051F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private string <patternAppended>k__BackingField;

			// Token: 0x040051F5 RID: 20981
			[Token(Token = "0x40051F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private string <parsedMessage>k__BackingField;
		}

		// Token: 0x020009B3 RID: 2483
		[Token(Token = "0x20009B3")]
		public class HTTPMethod
		{
			// Token: 0x06003547 RID: 13639 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003547")]
			[Address(RVA = "0xD6CDD0", Offset = "0xD6BDD0", VA = "0x180D6CDD0")]
			public HTTPMethod(SystemServices.HTTPMethod.HTTPMethods method)
			{
			}

			// Token: 0x040051F6 RID: 20982
			[Token(Token = "0x40051F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string methodName;

			// Token: 0x020009B4 RID: 2484
			[Token(Token = "0x20009B4")]
			public enum HTTPMethods
			{
				// Token: 0x040051F8 RID: 20984
				[Token(Token = "0x40051F8")]
				POST,
				// Token: 0x040051F9 RID: 20985
				[Token(Token = "0x40051F9")]
				GET
			}
		}

		// Token: 0x020009B5 RID: 2485
		[Token(Token = "0x20009B5")]
		public enum ImageFormat
		{
			// Token: 0x040051FB RID: 20987
			[Token(Token = "0x40051FB")]
			PNG,
			// Token: 0x040051FC RID: 20988
			[Token(Token = "0x40051FC")]
			JPG,
			// Token: 0x040051FD RID: 20989
			[Token(Token = "0x40051FD")]
			EXR
		}

		// Token: 0x020009B6 RID: 2486
		[Token(Token = "0x20009B6")]
		private sealed class <UnityAsyncGETRequest>d__3 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x06003548 RID: 13640 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003548")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <UnityAsyncGETRequest>d__3(int <>1__state)
			{
			}

			// Token: 0x06003549 RID: 13641 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003549")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x0600354A RID: 13642 RVA: 0x00012900 File Offset: 0x00010B00
			[Token(Token = "0x600354A")]
			[Address(RVA = "0xD6CFA0", Offset = "0xD6BFA0", VA = "0x180D6CFA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000556 RID: 1366
			// (get) Token: 0x0600354B RID: 13643 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000556")]
			private object Current
			{
				[Token(Token = "0x600354B")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600354C RID: 13644 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600354C")]
			[Address(RVA = "0xD6D580", Offset = "0xD6C580", VA = "0x180D6D580", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000557 RID: 1367
			// (get) Token: 0x0600354D RID: 13645 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000557")]
			private object Current
			{
				[Token(Token = "0x600354D")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x040051FE RID: 20990
			[Token(Token = "0x40051FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040051FF RID: 20991
			[Token(Token = "0x40051FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04005200 RID: 20992
			[Token(Token = "0x4005200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string encodedUrl;

			// Token: 0x04005201 RID: 20993
			[Token(Token = "0x4005201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int? timeout;

			// Token: 0x04005202 RID: 20994
			[Token(Token = "0x4005202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Dictionary<string, string> headers;

			// Token: 0x04005203 RID: 20995
			[Token(Token = "0x4005203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<string, long> callback;

			// Token: 0x04005204 RID: 20996
			[Token(Token = "0x4005204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <webRequest>5__2;
		}

		// Token: 0x020009B7 RID: 2487
		[Token(Token = "0x20009B7")]
		private sealed class <UnityAsyncPOSTRequest>d__6 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x0600354E RID: 13646 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600354E")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <UnityAsyncPOSTRequest>d__6(int <>1__state)
			{
			}

			// Token: 0x0600354F RID: 13647 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600354F")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x06003550 RID: 13648 RVA: 0x00012918 File Offset: 0x00010B18
			[Token(Token = "0x6003550")]
			[Address(RVA = "0xD6D5D0", Offset = "0xD6C5D0", VA = "0x180D6D5D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000558 RID: 1368
			// (get) Token: 0x06003551 RID: 13649 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000558")]
			private object Current
			{
				[Token(Token = "0x6003551")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003552 RID: 13650 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003552")]
			[Address(RVA = "0xD6DC60", Offset = "0xD6CC60", VA = "0x180D6DC60", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000559 RID: 1369
			// (get) Token: 0x06003553 RID: 13651 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000559")]
			private object Current
			{
				[Token(Token = "0x6003553")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04005205 RID: 20997
			[Token(Token = "0x4005205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04005206 RID: 20998
			[Token(Token = "0x4005206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04005207 RID: 20999
			[Token(Token = "0x4005207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string baseUrl;

			// Token: 0x04005208 RID: 21000
			[Token(Token = "0x4005208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int? timeout;

			// Token: 0x04005209 RID: 21001
			[Token(Token = "0x4005209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public byte[] data;

			// Token: 0x0400520A RID: 21002
			[Token(Token = "0x400520A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Dictionary<string, string> headers;

			// Token: 0x0400520B RID: 21003
			[Token(Token = "0x400520B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<string, long> callback;

			// Token: 0x0400520C RID: 21004
			[Token(Token = "0x400520C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UnityWebRequest <webRequest>5__2;
		}

		// Token: 0x020009B8 RID: 2488
		[Token(Token = "0x20009B8")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06003554 RID: 13652 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003554")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06003555 RID: 13653 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003555")]
			[Address(RVA = "0xD6DCB0", Offset = "0xD6CCB0", VA = "0x180D6DCB0")]
			internal void <SendHTTPRequestAsync>b__0()
			{
			}

			// Token: 0x06003556 RID: 13654 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003556")]
			[Address(RVA = "0xD6DDB0", Offset = "0xD6CDB0", VA = "0x180D6DDB0")]
			internal void <SendHTTPRequestAsync>b__1()
			{
			}

			// Token: 0x0400520D RID: 21005
			[Token(Token = "0x400520D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HttpWebRequest request;

			// Token: 0x0400520E RID: 21006
			[Token(Token = "0x400520E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] postData;

			// Token: 0x0400520F RID: 21007
			[Token(Token = "0x400520F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HttpWebResponse httpResponse;
		}

		// Token: 0x020009B9 RID: 2489
		[Token(Token = "0x20009B9")]
		[StructLayout(3)]
		private struct <SendHTTPRequestAsync>d__7 : IEnumerator<object>
		{
			// Token: 0x06003557 RID: 13655 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003557")]
			[Address(RVA = "0xD6DED0", Offset = "0xD6CED0", VA = "0x180D6DED0", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06003558 RID: 13656 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003558")]
			[Address(RVA = "0xD6F640", Offset = "0xD6E640", VA = "0x180D6F640", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04005210 RID: 21008
			[Token(Token = "0x4005210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04005211 RID: 21009
			[Token(Token = "0x4005211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04005212 RID: 21010
			[Token(Token = "0x4005212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public byte[] postData;

			// Token: 0x04005213 RID: 21011
			[Token(Token = "0x4005213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private SystemServices.<>c__DisplayClass7_0 <>8__1;

			// Token: 0x04005214 RID: 21012
			[Token(Token = "0x4005214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string baseUrl;

			// Token: 0x04005215 RID: 21013
			[Token(Token = "0x4005215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<string, HttpStatusCode?> callback;

			// Token: 0x04005216 RID: 21014
			[Token(Token = "0x4005216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int? timeout;

			// Token: 0x04005217 RID: 21015
			[Token(Token = "0x4005217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public SystemServices.HTTPMethod requestMethod;

			// Token: 0x04005218 RID: 21016
			[Token(Token = "0x4005218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Dictionary<string, string> header;

			// Token: 0x04005219 RID: 21017
			[Token(Token = "0x4005219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Dictionary<string, string> requestParameters;

			// Token: 0x0400521A RID: 21018
			[Token(Token = "0x400521A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private TaskAwaiter <>u__1;

			// Token: 0x0400521B RID: 21019
			[Token(Token = "0x400521B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private byte[] <paramsData>5__2;

			// Token: 0x0400521C RID: 21020
			[Token(Token = "0x400521C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private TaskAwaiter<Stream> <>u__2;

			// Token: 0x0400521D RID: 21021
			[Token(Token = "0x400521D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private TaskAwaiter<string> <>u__3;
		}

		// Token: 0x020009BA RID: 2490
		[Token(Token = "0x20009BA")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06003559 RID: 13657 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003559")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x0600355A RID: 13658 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600355A")]
			[Address(RVA = "0xD6F6A0", Offset = "0xD6E6A0", VA = "0x180D6F6A0")]
			internal void <AsyncResourceDownload>b__0()
			{
			}

			// Token: 0x0400521E RID: 21022
			[Token(Token = "0x400521E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HttpWebResponse httpResponse;

			// Token: 0x0400521F RID: 21023
			[Token(Token = "0x400521F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HttpWebRequest request;
		}

		// Token: 0x020009BB RID: 2491
		[Token(Token = "0x20009BB")]
		[StructLayout(3)]
		private struct <AsyncResourceDownload>d__9 : IEnumerator<object>
		{
			// Token: 0x0600355B RID: 13659 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600355B")]
			[Address(RVA = "0xD6F7C0", Offset = "0xD6E7C0", VA = "0x180D6F7C0", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x0600355C RID: 13660 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600355C")]
			[Address(RVA = "0xD70540", Offset = "0xD6F540", VA = "0x180D70540", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04005220 RID: 21024
			[Token(Token = "0x4005220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04005221 RID: 21025
			[Token(Token = "0x4005221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04005222 RID: 21026
			[Token(Token = "0x4005222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private SystemServices.<>c__DisplayClass9_0 <>8__1;

			// Token: 0x04005223 RID: 21027
			[Token(Token = "0x4005223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string resourceUrl;

			// Token: 0x04005224 RID: 21028
			[Token(Token = "0x4005224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<byte[], string, HttpStatusCode?> callback;

			// Token: 0x04005225 RID: 21029
			[Token(Token = "0x4005225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int? timeout;

			// Token: 0x04005226 RID: 21030
			[Token(Token = "0x4005226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020009BC RID: 2492
		[Token(Token = "0x20009BC")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x0600355D RID: 13661 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600355D")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x0600355E RID: 13662 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600355E")]
			[Address(RVA = "0xD705A0", Offset = "0xD6F5A0", VA = "0x180D705A0")]
			internal void <AsyncReachabilityCheck>b__0(string response, HttpStatusCode? statusCode)
			{
			}

			// Token: 0x04005227 RID: 21031
			[Token(Token = "0x4005227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool> callback;
		}

		// Token: 0x020009BD RID: 2493
		[Token(Token = "0x20009BD")]
		[StructLayout(3)]
		private struct <AsyncReachabilityCheck>d__10 : IEnumerator<object>
		{
			// Token: 0x0600355F RID: 13663 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600355F")]
			[Address(RVA = "0xD70650", Offset = "0xD6F650", VA = "0x180D70650", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06003560 RID: 13664 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003560")]
			[Address(RVA = "0xD70A80", Offset = "0xD6FA80", VA = "0x180D70A80", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04005228 RID: 21032
			[Token(Token = "0x4005228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04005229 RID: 21033
			[Token(Token = "0x4005229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400522A RID: 21034
			[Token(Token = "0x400522A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<bool> callback;

			// Token: 0x0400522B RID: 21035
			[Token(Token = "0x400522B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string testUrl;

			// Token: 0x0400522C RID: 21036
			[Token(Token = "0x400522C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020009BE RID: 2494
		[Token(Token = "0x20009BE")]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06003561 RID: 13665 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003561")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x06003562 RID: 13666 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003562")]
			[Address(RVA = "0xD70AE0", Offset = "0xD6FAE0", VA = "0x180D70AE0")]
			internal void <BlockingReachabilityCheck>b__0(string response, HttpStatusCode? statusCode)
			{
			}

			// Token: 0x0400522D RID: 21037
			[Token(Token = "0x400522D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool> callback;
		}

		// Token: 0x020009BF RID: 2495
		[Token(Token = "0x20009BF")]
		[StructLayout(3)]
		private struct <RunDelayedCommand>d__17 : IEnumerator<object>
		{
			// Token: 0x06003563 RID: 13667 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003563")]
			[Address(RVA = "0xD70B90", Offset = "0xD6FB90", VA = "0x180D70B90", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06003564 RID: 13668 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003564")]
			[Address(RVA = "0xD70EE0", Offset = "0xD6FEE0", VA = "0x180D70EE0", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400522E RID: 21038
			[Token(Token = "0x400522E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400522F RID: 21039
			[Token(Token = "0x400522F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04005230 RID: 21040
			[Token(Token = "0x4005230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float secs;

			// Token: 0x04005231 RID: 21041
			[Token(Token = "0x4005231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action command;

			// Token: 0x04005232 RID: 21042
			[Token(Token = "0x4005232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020009C0 RID: 2496
		[Token(Token = "0x20009C0")]
		[StructLayout(3)]
		private struct <WriteTextureAsync>d__19 : IEnumerator<object>
		{
			// Token: 0x06003565 RID: 13669 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003565")]
			[Address(RVA = "0xD70F40", Offset = "0xD6FF40", VA = "0x180D70F40", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06003566 RID: 13670 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003566")]
			[Address(RVA = "0xD71AF0", Offset = "0xD70AF0", VA = "0x180D71AF0", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04005233 RID: 21043
			[Token(Token = "0x4005233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04005234 RID: 21044
			[Token(Token = "0x4005234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04005235 RID: 21045
			[Token(Token = "0x4005235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SystemServices.ImageFormat format;

			// Token: 0x04005236 RID: 21046
			[Token(Token = "0x4005236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Texture2D texture;

			// Token: 0x04005237 RID: 21047
			[Token(Token = "0x4005237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string fileName;

			// Token: 0x04005238 RID: 21048
			[Token(Token = "0x4005238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string path;

			// Token: 0x04005239 RID: 21049
			[Token(Token = "0x4005239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<string> callback;

			// Token: 0x0400523A RID: 21050
			[Token(Token = "0x400523A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private byte[] <data>5__2;

			// Token: 0x0400523B RID: 21051
			[Token(Token = "0x400523B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private FileStream <fileStream>5__3;

			// Token: 0x0400523C RID: 21052
			[Token(Token = "0x400523C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020009C1 RID: 2497
		[Token(Token = "0x20009C1")]
		[StructLayout(3)]
		private struct <WriteBytesAsync>d__20 : IEnumerator<object>
		{
			// Token: 0x06003567 RID: 13671 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003567")]
			[Address(RVA = "0xD71B50", Offset = "0xD70B50", VA = "0x180D71B50", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06003568 RID: 13672 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003568")]
			[Address(RVA = "0xD72240", Offset = "0xD71240", VA = "0x180D72240", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400523D RID: 21053
			[Token(Token = "0x400523D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400523E RID: 21054
			[Token(Token = "0x400523E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400523F RID: 21055
			[Token(Token = "0x400523F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string fullPath;

			// Token: 0x04005240 RID: 21056
			[Token(Token = "0x4005240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public byte[] data;

			// Token: 0x04005241 RID: 21057
			[Token(Token = "0x4005241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> callback;

			// Token: 0x04005242 RID: 21058
			[Token(Token = "0x4005242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private FileStream <fileStream>5__2;

			// Token: 0x04005243 RID: 21059
			[Token(Token = "0x4005243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter <>u__1;
		}
	}
}
