using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020004BF RID: 1215
[Token(Token = "0x20004BF")]
public class PlayerPrefsController : MonoBehaviour
{
	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x06001B48 RID: 6984 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000D4")]
	public static PlayerPrefsController Instance
	{
		[Token(Token = "0x6001B48")]
		[Address(RVA = "0x9B1F60", Offset = "0x9B0F60", VA = "0x1809B1F60")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001B49 RID: 6985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B49")]
	[Address(RVA = "0x9B1FA0", Offset = "0x9B0FA0", VA = "0x1809B1FA0")]
	private void Awake()
	{
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B4A")]
	[Address(RVA = "0x9B2660", Offset = "0x9B1660", VA = "0x1809B2660")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B4B")]
	[Address(RVA = "0x9B2870", Offset = "0x9B1870", VA = "0x1809B2870")]
	public void LoadPlayerPrefs(bool lateLoad = false)
	{
	}

	// Token: 0x06001B4C RID: 6988 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B4C")]
	[Address(RVA = "0x9B3900", Offset = "0x9B2900", VA = "0x1809B3900")]
	public void ResetPlayerPrefsToDefaults()
	{
	}

	// Token: 0x06001B4D RID: 6989 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
	[Token(Token = "0x6001B4D")]
	[Address(RVA = "0x9B4160", Offset = "0x9B3160", VA = "0x1809B4160")]
	public int GetSettingInt(string id)
	{
		return 0;
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B4E")]
	[Address(RVA = "0x9B42A0", Offset = "0x9B32A0", VA = "0x1809B42A0")]
	public string GetSettingStr(string id)
	{
		return null;
	}

	// Token: 0x06001B4F RID: 6991 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B4F")]
	[Address(RVA = "0x9B4400", Offset = "0x9B3400", VA = "0x1809B4400")]
	public void OnToggleChanged(string id, bool fetchValueFromControls, [Optional] MonoBehaviour elementScript)
	{
	}

	// Token: 0x06001B50 RID: 6992 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B50")]
	[Address(RVA = "0x9B9250", Offset = "0x9B8250", VA = "0x1809B9250")]
	public void ResetFirstPlay()
	{
	}

	// Token: 0x06001B51 RID: 6993 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B51")]
	[Address(RVA = "0x9B9290", Offset = "0x9B8290", VA = "0x1809B9290")]
	public void ResetLowEndHardware()
	{
	}

	// Token: 0x06001B52 RID: 6994 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B52")]
	[Address(RVA = "0x9B92D0", Offset = "0x9B82D0", VA = "0x1809B92D0")]
	public PlayerPrefsController()
	{
	}

	// Token: 0x0400215D RID: 8541
	[Token(Token = "0x400215D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<PlayerPrefsController.GameSetting> gameSettingControls;

	// Token: 0x0400215E RID: 8542
	[Token(Token = "0x400215E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool playedBefore;

	// Token: 0x0400215F RID: 8543
	[Token(Token = "0x400215F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool acceptedEULA;

	// Token: 0x04002160 RID: 8544
	[Token(Token = "0x4002160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool loadedPlayerPrefs;

	// Token: 0x04002161 RID: 8545
	[Token(Token = "0x4002161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool initialiseAsLowEndHardware;

	// Token: 0x04002162 RID: 8546
	[Token(Token = "0x4002162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PlayerPrefsController _instance;

	// Token: 0x020004C0 RID: 1216
	[Token(Token = "0x20004C0")]
	[Serializable]
	public class GameSetting
	{
		// Token: 0x06001B53 RID: 6995 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		[Token(Token = "0x6001B53")]
		[Address(RVA = "0x9B93D0", Offset = "0x9B83D0", VA = "0x1809B93D0")]
		public int GetDefaultInt()
		{
			return 0;
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B54")]
		[Address(RVA = "0x9B9790", Offset = "0x9B8790", VA = "0x1809B9790")]
		public string GetDefaultStr()
		{
			return null;
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B55")]
		[Address(RVA = "0x9B9930", Offset = "0x9B8930", VA = "0x1809B9930")]
		public GameSetting()
		{
		}

		// Token: 0x04002163 RID: 8547
		[Token(Token = "0x4002163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string identifier;

		// Token: 0x04002164 RID: 8548
		[Token(Token = "0x4002164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int intDefault;

		// Token: 0x04002165 RID: 8549
		[Token(Token = "0x4002165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int intValue;

		// Token: 0x04002166 RID: 8550
		[Token(Token = "0x4002166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string strDefault;

		// Token: 0x04002167 RID: 8551
		[Token(Token = "0x4002167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string strValue;

		// Token: 0x04002168 RID: 8552
		[Token(Token = "0x4002168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ToggleController toggle;

		// Token: 0x04002169 RID: 8553
		[Token(Token = "0x4002169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SliderController slider;

		// Token: 0x0400216A RID: 8554
		[Token(Token = "0x400216A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DropdownController dropdown;

		// Token: 0x0400216B RID: 8555
		[Token(Token = "0x400216B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DropdownController secondaryDropdown;

		// Token: 0x0400216C RID: 8556
		[Token(Token = "0x400216C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MultiSelectController multiselect;

		// Token: 0x0400216D RID: 8557
		[Token(Token = "0x400216D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI valueDisplayText;

		// Token: 0x0400216E RID: 8558
		[Token(Token = "0x400216E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool lateLoad;

		// Token: 0x0400216F RID: 8559
		[Token(Token = "0x400216F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool useDropdownInt;

		// Token: 0x04002170 RID: 8560
		[Token(Token = "0x4002170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<PlayerPrefsController.PlatformSpecificDefault> platformSpecificDefaults;

		// Token: 0x04002171 RID: 8561
		[Token(Token = "0x4002171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool onlyDisplayInDevMode;

		// Token: 0x04002172 RID: 8562
		[Token(Token = "0x4002172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<Game.BuildConfig> dontDisplayOnPlatforms;

		// Token: 0x020004C1 RID: 1217
		[Token(Token = "0x20004C1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001B57 RID: 6999 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001B57")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c()
			{
			}

			// Token: 0x06001B58 RID: 7000 RVA: 0x0000CA08 File Offset: 0x0000AC08
			[Token(Token = "0x6001B58")]
			[Address(RVA = "0x9B9B50", Offset = "0x9B8B50", VA = "0x1809B9B50")]
			internal bool <GetDefaultInt>b__16_0(PlayerPrefsController.PlatformSpecificDefault item)
			{
				return default(bool);
			}

			// Token: 0x06001B59 RID: 7001 RVA: 0x0000CA20 File Offset: 0x0000AC20
			[Token(Token = "0x6001B59")]
			[Address(RVA = "0x9B9B70", Offset = "0x9B8B70", VA = "0x1809B9B70")]
			internal bool <GetDefaultInt>b__16_1(PlayerPrefsController.PlatformSpecificDefault item)
			{
				return default(bool);
			}

			// Token: 0x06001B5A RID: 7002 RVA: 0x0000CA38 File Offset: 0x0000AC38
			[Token(Token = "0x6001B5A")]
			[Address(RVA = "0x9B9B70", Offset = "0x9B8B70", VA = "0x1809B9B70")]
			internal bool <GetDefaultStr>b__17_0(PlayerPrefsController.PlatformSpecificDefault item)
			{
				return default(bool);
			}

			// Token: 0x04002173 RID: 8563
			[Token(Token = "0x4002173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly PlayerPrefsController.GameSetting.<>c <>9;

			// Token: 0x04002174 RID: 8564
			[Token(Token = "0x4002174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<PlayerPrefsController.PlatformSpecificDefault> <>9__16_0;

			// Token: 0x04002175 RID: 8565
			[Token(Token = "0x4002175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<PlayerPrefsController.PlatformSpecificDefault> <>9__16_1;

			// Token: 0x04002176 RID: 8566
			[Token(Token = "0x4002176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<PlayerPrefsController.PlatformSpecificDefault> <>9__17_0;
		}
	}

	// Token: 0x020004C2 RID: 1218
	[Token(Token = "0x20004C2")]
	[Serializable]
	public class PlatformSpecificDefault
	{
		// Token: 0x06001B5B RID: 7003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B5B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public PlatformSpecificDefault()
		{
		}

		// Token: 0x04002177 RID: 8567
		[Token(Token = "0x4002177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool lowEndHardware;

		// Token: 0x04002178 RID: 8568
		[Token(Token = "0x4002178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Game.BuildConfig platform;

		// Token: 0x04002179 RID: 8569
		[Token(Token = "0x4002179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int intDefault;

		// Token: 0x0400217A RID: 8570
		[Token(Token = "0x400217A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string strDefault;
	}

	// Token: 0x020004C3 RID: 1219
	[Token(Token = "0x20004C3")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001B5D RID: 7005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B5D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0000CA50 File Offset: 0x0000AC50
		[Token(Token = "0x6001B5E")]
		[Address(RVA = "0x9B9C80", Offset = "0x9B8C80", VA = "0x1809B9C80")]
		internal bool <LoadPlayerPrefs>b__12_0(Game.BuildConfig item)
		{
			return default(bool);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0000CA68 File Offset: 0x0000AC68
		[Token(Token = "0x6001B5F")]
		[Address(RVA = "0x9B9C80", Offset = "0x9B8C80", VA = "0x1809B9C80")]
		internal bool <LoadPlayerPrefs>b__12_1(Game.BuildConfig item)
		{
			return default(bool);
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0000CA80 File Offset: 0x0000AC80
		[Token(Token = "0x6001B60")]
		[Address(RVA = "0x9B9C80", Offset = "0x9B8C80", VA = "0x1809B9C80")]
		internal bool <LoadPlayerPrefs>b__12_2(Game.BuildConfig item)
		{
			return default(bool);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0000CA98 File Offset: 0x0000AC98
		[Token(Token = "0x6001B61")]
		[Address(RVA = "0x9B9C80", Offset = "0x9B8C80", VA = "0x1809B9C80")]
		internal bool <LoadPlayerPrefs>b__12_3(Game.BuildConfig item)
		{
			return default(bool);
		}

		// Token: 0x0400217B RID: 8571
		[Token(Token = "0x400217B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly PlayerPrefsController.<>c <>9;

		// Token: 0x0400217C RID: 8572
		[Token(Token = "0x400217C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Game.BuildConfig> <>9__12_0;

		// Token: 0x0400217D RID: 8573
		[Token(Token = "0x400217D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<Game.BuildConfig> <>9__12_1;

		// Token: 0x0400217E RID: 8574
		[Token(Token = "0x400217E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<Game.BuildConfig> <>9__12_2;

		// Token: 0x0400217F RID: 8575
		[Token(Token = "0x400217F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<Game.BuildConfig> <>9__12_3;
	}

	// Token: 0x020004C4 RID: 1220
	[Token(Token = "0x20004C4")]
	private sealed class <>c__DisplayClass14_0
	{
		// Token: 0x06001B62 RID: 7010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B62")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass14_0()
		{
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		[Token(Token = "0x6001B63")]
		[Address(RVA = "0x958170", Offset = "0x957170", VA = "0x180958170")]
		internal bool <GetSettingInt>b__0(PlayerPrefsController.GameSetting item)
		{
			return default(bool);
		}

		// Token: 0x04002180 RID: 8576
		[Token(Token = "0x4002180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;
	}

	// Token: 0x020004C5 RID: 1221
	[Token(Token = "0x20004C5")]
	private sealed class <>c__DisplayClass15_0
	{
		// Token: 0x06001B64 RID: 7012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B64")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass15_0()
		{
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		[Token(Token = "0x6001B65")]
		[Address(RVA = "0x958170", Offset = "0x957170", VA = "0x180958170")]
		internal bool <GetSettingStr>b__0(PlayerPrefsController.GameSetting item)
		{
			return default(bool);
		}

		// Token: 0x04002181 RID: 8577
		[Token(Token = "0x4002181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;
	}

	// Token: 0x020004C6 RID: 1222
	[Token(Token = "0x20004C6")]
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x06001B66 RID: 7014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B66")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass16_0()
		{
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x958170", Offset = "0x957170", VA = "0x180958170")]
		internal bool <OnToggleChanged>b__0(PlayerPrefsController.GameSetting item)
		{
			return default(bool);
		}

		// Token: 0x04002182 RID: 8578
		[Token(Token = "0x4002182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;
	}
}
