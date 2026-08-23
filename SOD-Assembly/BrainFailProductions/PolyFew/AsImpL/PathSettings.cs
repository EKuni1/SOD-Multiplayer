using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x020009F9 RID: 2553
	[Token(Token = "0x20009F9")]
	public class PathSettings : MonoBehaviour
	{
		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06003663 RID: 13923 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000579")]
		public string RootPath
		{
			[Token(Token = "0x6003663")]
			[Address(RVA = "0xD98D40", Offset = "0xD97D40", VA = "0x180D98D40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003664")]
		[Address(RVA = "0xD98EA0", Offset = "0xD97EA0", VA = "0x180D98EA0")]
		public static PathSettings FindPathComponent(GameObject obj)
		{
			return null;
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003665")]
		[Address(RVA = "0xD990F0", Offset = "0xD980F0", VA = "0x180D990F0")]
		public string FullPath(string path)
		{
			return null;
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003666")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public PathSettings()
		{
		}

		// Token: 0x040053D0 RID: 21456
		[Token(Token = "0x40053D0")]
		[FieldOffset(Offset = "0x18")]
		public RootPathEnum defaultRootPath;

		// Token: 0x040053D1 RID: 21457
		[Token(Token = "0x40053D1")]
		[FieldOffset(Offset = "0x1C")]
		public RootPathEnum mobileRootPath;
	}
}
