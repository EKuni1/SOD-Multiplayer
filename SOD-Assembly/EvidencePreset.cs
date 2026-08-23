using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007D3 RID: 2003
[Token(Token = "0x20007D3")]
public class EvidencePreset : SoCustomComparison
{
	// Token: 0x06002960 RID: 10592 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002960")]
	[Address(RVA = "0xCA4CB0", Offset = "0xCA3CB0", VA = "0x180CA4CB0")]
	public List<Evidence.DataKey> GetValidProfileKeys()
	{
		return null;
	}

	// Token: 0x06002961 RID: 10593 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002961")]
	[Address(RVA = "0xCA4E80", Offset = "0xCA3E80", VA = "0x180CA4E80")]
	public List<Evidence.DataKey> GetUniqueProfileKeys()
	{
		return null;
	}

	// Token: 0x06002962 RID: 10594 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
	[Token(Token = "0x6002962")]
	[Address(RVA = "0xCA5050", Offset = "0xCA4050", VA = "0x180CA5050")]
	public bool IsKeyValid(Evidence.DataKey key, out bool countTowardsProfile)
	{
		return default(bool);
	}

	// Token: 0x06002963 RID: 10595 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
	[Token(Token = "0x6002963")]
	[Address(RVA = "0xCA5150", Offset = "0xCA4150", VA = "0x180CA5150")]
	public bool IsKeyUnique(Evidence.DataKey key)
	{
		return default(bool);
	}

	// Token: 0x06002964 RID: 10596 RVA: 0x0000F900 File Offset: 0x0000DB00
	[Token(Token = "0x6002964")]
	[Address(RVA = "0xCA5260", Offset = "0xCA4260", VA = "0x180CA5260")]
	public int GetProfileKeyCount(List<Evidence.DataKey> keyList)
	{
		return 0;
	}

	// Token: 0x06002965 RID: 10597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002965")]
	[Address(RVA = "0xCA5470", Offset = "0xCA4470", VA = "0x180CA5470")]
	public EvidencePreset()
	{
	}

	// Token: 0x040039FB RID: 14843
	[Token(Token = "0x40039FB")]
	[FieldOffset(Offset = "0x20")]
	public string subClass;

	// Token: 0x040039FC RID: 14844
	[Token(Token = "0x40039FC")]
	[FieldOffset(Offset = "0x28")]
	public WindowStylePreset windowStyle;

	// Token: 0x040039FD RID: 14845
	[Token(Token = "0x40039FD")]
	[FieldOffset(Offset = "0x30")]
	public bool useDataKeys;

	// Token: 0x040039FE RID: 14846
	[Token(Token = "0x40039FE")]
	[FieldOffset(Offset = "0x38")]
	public List<DataKeyControls.DataKeySettings> validKeys;

	// Token: 0x040039FF RID: 14847
	[Token(Token = "0x40039FF")]
	[FieldOffset(Offset = "0x40")]
	public List<EvidencePreset.DataKeyAutomaticTies> passiveTies;

	// Token: 0x04003A00 RID: 14848
	[Token(Token = "0x4003A00")]
	[FieldOffset(Offset = "0x48")]
	public bool notifyOfTies;

	// Token: 0x04003A01 RID: 14849
	[Token(Token = "0x4003A01")]
	[FieldOffset(Offset = "0x49")]
	public bool useBelongsToInName;

	// Token: 0x04003A02 RID: 14850
	[Token(Token = "0x4003A02")]
	[FieldOffset(Offset = "0x4A")]
	public bool isSingleton;

	// Token: 0x04003A03 RID: 14851
	[Token(Token = "0x4003A03")]
	[FieldOffset(Offset = "0x4B")]
	public bool disableHistory;

	// Token: 0x04003A04 RID: 14852
	[Token(Token = "0x4003A04")]
	[FieldOffset(Offset = "0x4C")]
	public bool allowCustomNames;

	// Token: 0x04003A05 RID: 14853
	[Token(Token = "0x4003A05")]
	[FieldOffset(Offset = "0x4D")]
	public bool markAsDiscoveredOnAnyInteraction;

	// Token: 0x04003A06 RID: 14854
	[Token(Token = "0x4003A06")]
	[FieldOffset(Offset = "0x4E")]
	public bool forceWorldInteraction;

	// Token: 0x04003A07 RID: 14855
	[Token(Token = "0x4003A07")]
	[FieldOffset(Offset = "0x4F")]
	public bool useWindowFocusMode;

	// Token: 0x04003A08 RID: 14856
	[Token(Token = "0x4003A08")]
	[FieldOffset(Offset = "0x50")]
	public Sprite iconSpriteLarge;

	// Token: 0x04003A09 RID: 14857
	[Token(Token = "0x4003A09")]
	[FieldOffset(Offset = "0x58")]
	public Texture2D defaultNullImage;

	// Token: 0x04003A0A RID: 14858
	[Token(Token = "0x4003A0A")]
	[FieldOffset(Offset = "0x60")]
	public bool useInGamePhoto;

	// Token: 0x04003A0B RID: 14859
	[Token(Token = "0x4003A0B")]
	[FieldOffset(Offset = "0x61")]
	public bool useWriter;

	// Token: 0x04003A0C RID: 14860
	[Token(Token = "0x4003A0C")]
	[FieldOffset(Offset = "0x64")]
	public Vector3 relativeCamPhotoPos;

	// Token: 0x04003A0D RID: 14861
	[Token(Token = "0x4003A0D")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 relativeCamPhotoEuler;

	// Token: 0x04003A0E RID: 14862
	[Token(Token = "0x4003A0E")]
	[FieldOffset(Offset = "0x7C")]
	public EvidencePreset.CaptureRules captureRules;

	// Token: 0x04003A0F RID: 14863
	[Token(Token = "0x4003A0F")]
	[FieldOffset(Offset = "0x80")]
	public bool changeTimeOfDay;

	// Token: 0x04003A10 RID: 14864
	[Token(Token = "0x4003A10")]
	[FieldOffset(Offset = "0x84")]
	public float captureTimeOfDay;

	// Token: 0x04003A11 RID: 14865
	[Token(Token = "0x4003A11")]
	[FieldOffset(Offset = "0x88")]
	public bool useCaptureLight;

	// Token: 0x04003A12 RID: 14866
	[Token(Token = "0x4003A12")]
	[FieldOffset(Offset = "0x89")]
	public bool useSurveillanceCapture;

	// Token: 0x04003A13 RID: 14867
	[Token(Token = "0x4003A13")]
	[FieldOffset(Offset = "0x8C")]
	public EvidencePreset.BelongsToSetting itemOwner;

	// Token: 0x04003A14 RID: 14868
	[Token(Token = "0x4003A14")]
	[FieldOffset(Offset = "0x90")]
	public EvidencePreset.BelongsToSetting itemWriter;

	// Token: 0x04003A15 RID: 14869
	[Token(Token = "0x4003A15")]
	[FieldOffset(Offset = "0x94")]
	public EvidencePreset.BelongsToSetting itemReceiver;

	// Token: 0x04003A16 RID: 14870
	[Token(Token = "0x4003A16")]
	[FieldOffset(Offset = "0x98")]
	public List<EvidencePreset.EvidenceFactSetup> factSetup;

	// Token: 0x04003A17 RID: 14871
	[Token(Token = "0x4003A17")]
	[FieldOffset(Offset = "0xA0")]
	public List<EvidencePreset.FactLinkSetup> addFactLinks;

	// Token: 0x04003A18 RID: 14872
	[Token(Token = "0x4003A18")]
	[FieldOffset(Offset = "0xA8")]
	public bool discoverOnCreate;

	// Token: 0x04003A19 RID: 14873
	[Token(Token = "0x4003A19")]
	[FieldOffset(Offset = "0xB0")]
	public List<EvidencePreset.MergeKeysSetup> keyMergeOnDiscovery;

	// Token: 0x04003A1A RID: 14874
	[Token(Token = "0x4003A1A")]
	[FieldOffset(Offset = "0xB8")]
	public List<Evidence.Discovery> discoveryTriggers;

	// Token: 0x04003A1B RID: 14875
	[Token(Token = "0x4003A1B")]
	[FieldOffset(Offset = "0xC0")]
	public List<EvidencePreset.DiscoveryApplication> applicationOnDiscover;

	// Token: 0x04003A1C RID: 14876
	[Token(Token = "0x4003A1C")]
	[FieldOffset(Offset = "0xC8")]
	public string ddsDocumentID;

	// Token: 0x04003A1D RID: 14877
	[Token(Token = "0x4003A1D")]
	[FieldOffset(Offset = "0xD0")]
	public bool isMatchParent;

	// Token: 0x04003A1E RID: 14878
	[Token(Token = "0x4003A1E")]
	[FieldOffset(Offset = "0xD8")]
	public List<MatchPreset> matchTypes;

	// Token: 0x04003A1F RID: 14879
	[Token(Token = "0x4003A1F")]
	[FieldOffset(Offset = "0xE0")]
	public bool enableSummary;

	// Token: 0x04003A20 RID: 14880
	[Token(Token = "0x4003A20")]
	[FieldOffset(Offset = "0xE1")]
	public bool enableFacts;

	// Token: 0x04003A21 RID: 14881
	[Token(Token = "0x4003A21")]
	[FieldOffset(Offset = "0xE4")]
	public EvidencePreset.PinnedStyle pinnedStyle;

	// Token: 0x04003A22 RID: 14882
	[Token(Token = "0x4003A22")]
	[FieldOffset(Offset = "0xE8")]
	public Color pinnedBackgroundColour;

	// Token: 0x020007D4 RID: 2004
	[Token(Token = "0x20007D4")]
	public enum CaptureRules
	{
		// Token: 0x04003A24 RID: 14884
		[Token(Token = "0x4003A24")]
		building,
		// Token: 0x04003A25 RID: 14885
		[Token(Token = "0x4003A25")]
		location,
		// Token: 0x04003A26 RID: 14886
		[Token(Token = "0x4003A26")]
		item,
		// Token: 0x04003A27 RID: 14887
		[Token(Token = "0x4003A27")]
		citizen
	}

	// Token: 0x020007D5 RID: 2005
	[Token(Token = "0x20007D5")]
	public enum BelongsToSetting
	{
		// Token: 0x04003A29 RID: 14889
		[Token(Token = "0x4003A29")]
		self,
		// Token: 0x04003A2A RID: 14890
		[Token(Token = "0x4003A2A")]
		partner,
		// Token: 0x04003A2B RID: 14891
		[Token(Token = "0x4003A2B")]
		paramour,
		// Token: 0x04003A2C RID: 14892
		[Token(Token = "0x4003A2C")]
		boss,
		// Token: 0x04003A2D RID: 14893
		[Token(Token = "0x4003A2D")]
		doctor,
		// Token: 0x04003A2E RID: 14894
		[Token(Token = "0x4003A2E")]
		landlord
	}

	// Token: 0x020007D6 RID: 2006
	[Token(Token = "0x20007D6")]
	public enum Subject
	{
		// Token: 0x04003A30 RID: 14896
		[Token(Token = "0x4003A30")]
		self,
		// Token: 0x04003A31 RID: 14897
		[Token(Token = "0x4003A31")]
		writer,
		// Token: 0x04003A32 RID: 14898
		[Token(Token = "0x4003A32")]
		receiver,
		// Token: 0x04003A33 RID: 14899
		[Token(Token = "0x4003A33")]
		parent,
		// Token: 0x04003A34 RID: 14900
		[Token(Token = "0x4003A34")]
		interactable,
		// Token: 0x04003A35 RID: 14901
		[Token(Token = "0x4003A35")]
		interactableLocation
	}

	// Token: 0x020007D7 RID: 2007
	[Token(Token = "0x20007D7")]
	[Serializable]
	public class EvidenceFactSetup
	{
		// Token: 0x06002966 RID: 10598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002966")]
		[Address(RVA = "0xCA5B50", Offset = "0xCA4B50", VA = "0x180CA5B50")]
		public EvidenceFactSetup()
		{
		}

		// Token: 0x04003A36 RID: 14902
		[Token(Token = "0x4003A36")]
		[FieldOffset(Offset = "0x10")]
		public FactPreset preset;

		// Token: 0x04003A37 RID: 14903
		[Token(Token = "0x4003A37")]
		[FieldOffset(Offset = "0x18")]
		public EvidencePreset.Subject link;

		// Token: 0x04003A38 RID: 14904
		[Token(Token = "0x4003A38")]
		[FieldOffset(Offset = "0x1C")]
		public bool onlyIfInOwnedPosition;

		// Token: 0x04003A39 RID: 14905
		[Token(Token = "0x4003A39")]
		[FieldOffset(Offset = "0x1D")]
		public bool createOnDiscovery;

		// Token: 0x04003A3A RID: 14906
		[Token(Token = "0x4003A3A")]
		[FieldOffset(Offset = "0x1E")]
		public bool forceDiscoveryOnCreation;

		// Token: 0x04003A3B RID: 14907
		[Token(Token = "0x4003A3B")]
		[FieldOffset(Offset = "0x1F")]
		public bool switchFindingFactToFrom;
	}

	// Token: 0x020007D8 RID: 2008
	[Token(Token = "0x20007D8")]
	[Serializable]
	public class FactLinkSetup
	{
		// Token: 0x06002967 RID: 10599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002967")]
		[Address(RVA = "0x401CA0", Offset = "0x400CA0", VA = "0x180401CA0")]
		public FactLinkSetup()
		{
		}

		// Token: 0x04003A3C RID: 14908
		[Token(Token = "0x4003A3C")]
		[FieldOffset(Offset = "0x10")]
		public EvidencePreset.FactLinkSubject subject;

		// Token: 0x04003A3D RID: 14909
		[Token(Token = "0x4003A3D")]
		[FieldOffset(Offset = "0x18")]
		public string factDictionary;

		// Token: 0x04003A3E RID: 14910
		[Token(Token = "0x4003A3E")]
		[FieldOffset(Offset = "0x20")]
		public Evidence.DataKey key;

		// Token: 0x04003A3F RID: 14911
		[Token(Token = "0x4003A3F")]
		[FieldOffset(Offset = "0x24")]
		public bool discovery;
	}

	// Token: 0x020007D9 RID: 2009
	[Token(Token = "0x20007D9")]
	[Serializable]
	public class DataKeyAutomaticTies
	{
		// Token: 0x06002968 RID: 10600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002968")]
		[Address(RVA = "0xCA5B60", Offset = "0xCA4B60", VA = "0x180CA5B60")]
		public DataKeyAutomaticTies()
		{
		}

		// Token: 0x04003A40 RID: 14912
		[Token(Token = "0x4003A40")]
		[FieldOffset(Offset = "0x10")]
		public Evidence.DataKey mainKey;

		// Token: 0x04003A41 RID: 14913
		[Token(Token = "0x4003A41")]
		[FieldOffset(Offset = "0x18")]
		public List<Evidence.DataKey> mergeAtStart;
	}

	// Token: 0x020007DA RID: 2010
	[Token(Token = "0x20007DA")]
	public enum FactLinkSubject
	{
		// Token: 0x04003A43 RID: 14915
		[Token(Token = "0x4003A43")]
		writer,
		// Token: 0x04003A44 RID: 14916
		[Token(Token = "0x4003A44")]
		receiver
	}

	// Token: 0x020007DB RID: 2011
	[Token(Token = "0x20007DB")]
	[Serializable]
	public class MergeKeysSetup
	{
		// Token: 0x06002969 RID: 10601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002969")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public MergeKeysSetup()
		{
		}

		// Token: 0x04003A45 RID: 14917
		[Token(Token = "0x4003A45")]
		[FieldOffset(Offset = "0x10")]
		public EvidencePreset.Subject link;

		// Token: 0x04003A46 RID: 14918
		[Token(Token = "0x4003A46")]
		[FieldOffset(Offset = "0x18")]
		public List<Evidence.DataKey> mergeKeys;
	}

	// Token: 0x020007DC RID: 2012
	[Token(Token = "0x20007DC")]
	[Serializable]
	public class DiscoveryApplication
	{
		// Token: 0x0600296A RID: 10602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600296A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DiscoveryApplication()
		{
		}

		// Token: 0x04003A47 RID: 14919
		[Token(Token = "0x4003A47")]
		[FieldOffset(Offset = "0x10")]
		public EvidencePreset.Subject link;

		// Token: 0x04003A48 RID: 14920
		[Token(Token = "0x4003A48")]
		[FieldOffset(Offset = "0x14")]
		public Evidence.Discovery applyDiscoveryTrigger;
	}

	// Token: 0x020007DD RID: 2013
	[Token(Token = "0x20007DD")]
	public enum PinnedStyle
	{
		// Token: 0x04003A4A RID: 14922
		[Token(Token = "0x4003A4A")]
		polaroid,
		// Token: 0x04003A4B RID: 14923
		[Token(Token = "0x4003A4B")]
		stickNote
	}

	// Token: 0x020007DE RID: 2014
	[Token(Token = "0x20007DE")]
	private sealed class <>c__DisplayClass52_0
	{
		// Token: 0x0600296B RID: 10603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600296B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass52_0()
		{
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x0000F918 File Offset: 0x0000DB18
		[Token(Token = "0x600296C")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <IsKeyValid>b__0(DataKeyControls.DataKeySettings item)
		{
			return default(bool);
		}

		// Token: 0x04003A4C RID: 14924
		[Token(Token = "0x4003A4C")]
		[FieldOffset(Offset = "0x10")]
		public Evidence.DataKey key;
	}

	// Token: 0x020007DF RID: 2015
	[Token(Token = "0x20007DF")]
	private sealed class <>c__DisplayClass53_0
	{
		// Token: 0x0600296D RID: 10605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600296D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass53_0()
		{
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x0000F930 File Offset: 0x0000DB30
		[Token(Token = "0x600296E")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <IsKeyUnique>b__0(DataKeyControls.DataKeySettings item)
		{
			return default(bool);
		}

		// Token: 0x04003A4D RID: 14925
		[Token(Token = "0x4003A4D")]
		[FieldOffset(Offset = "0x10")]
		public Evidence.DataKey key;
	}
}
