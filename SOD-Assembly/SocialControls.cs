using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008C4 RID: 2244
[Token(Token = "0x20008C4")]
public class SocialControls : MonoBehaviour
{
	// Token: 0x17000157 RID: 343
	// (get) Token: 0x06002A50 RID: 10832 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000157")]
	public static SocialControls Instance
	{
		[Token(Token = "0x6002A50")]
		[Address(RVA = "0xCBEBF0", Offset = "0xCBDBF0", VA = "0x180CBEBF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002A51 RID: 10833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A51")]
	[Address(RVA = "0xCBEC30", Offset = "0xCBDC30", VA = "0x180CBEC30")]
	private void Awake()
	{
	}

	// Token: 0x06002A52 RID: 10834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A52")]
	[Address(RVA = "0xCBEF80", Offset = "0xCBDF80", VA = "0x180CBEF80")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002A53 RID: 10835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A53")]
	[Address(RVA = "0xCBF190", Offset = "0xCBE190", VA = "0x180CBF190")]
	public SocialControls()
	{
	}

	// Token: 0x04004A17 RID: 18967
	[Token(Token = "0x4004A17")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 knowLoverRange;

	// Token: 0x04004A18 RID: 18968
	[Token(Token = "0x4004A18")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 knowHousemateRange;

	// Token: 0x04004A19 RID: 18969
	[Token(Token = "0x4004A19")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 knowFriendRange;

	// Token: 0x04004A1A RID: 18970
	[Token(Token = "0x4004A1A")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 knowNeighborRange;

	// Token: 0x04004A1B RID: 18971
	[Token(Token = "0x4004A1B")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 knowBossRange;

	// Token: 0x04004A1C RID: 18972
	[Token(Token = "0x4004A1C")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 knowWorkTeamRange;

	// Token: 0x04004A1D RID: 18973
	[Token(Token = "0x4004A1D")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 knowWorkRange;

	// Token: 0x04004A1E RID: 18974
	[Token(Token = "0x4004A1E")]
	[FieldOffset(Offset = "0x50")]
	public Vector2 knowWorkOtherRange;

	// Token: 0x04004A1F RID: 18975
	[Token(Token = "0x4004A1F")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 knowRegularCustomerRange;

	// Token: 0x04004A20 RID: 18976
	[Token(Token = "0x4004A20")]
	[FieldOffset(Offset = "0x60")]
	public Vector2 knowParamourRange;

	// Token: 0x04004A21 RID: 18977
	[Token(Token = "0x4004A21")]
	[FieldOffset(Offset = "0x68")]
	public Vector2 knowGroupRange;

	// Token: 0x04004A22 RID: 18978
	[Token(Token = "0x4004A22")]
	[FieldOffset(Offset = "0x70")]
	public CharacterTrait paramour;

	// Token: 0x04004A23 RID: 18979
	[Token(Token = "0x4004A23")]
	[FieldOffset(Offset = "0x78")]
	public int basePreferredBookCount;

	// Token: 0x04004A24 RID: 18980
	[Token(Token = "0x4004A24")]
	[FieldOffset(Offset = "0x80")]
	public List<float> wageRanges;

	// Token: 0x04004A25 RID: 18981
	[Token(Token = "0x4004A25")]
	[FieldOffset(Offset = "0x88")]
	public List<Vector2> overtimeRanges;

	// Token: 0x04004A26 RID: 18982
	[Token(Token = "0x4004A26")]
	[FieldOffset(Offset = "0x90")]
	public float accuracy1;

	// Token: 0x04004A27 RID: 18983
	[Token(Token = "0x4004A27")]
	[FieldOffset(Offset = "0x94")]
	public float accuracy2;

	// Token: 0x04004A28 RID: 18984
	[Token(Token = "0x4004A28")]
	[FieldOffset(Offset = "0x98")]
	public float accuracy3;

	// Token: 0x04004A29 RID: 18985
	[Token(Token = "0x4004A29")]
	[FieldOffset(Offset = "0x9C")]
	public float accuracy4;

	// Token: 0x04004A2A RID: 18986
	[Token(Token = "0x4004A2A")]
	[FieldOffset(Offset = "0xA0")]
	public float accuracy5;

	// Token: 0x04004A2B RID: 18987
	[Token(Token = "0x4004A2B")]
	[FieldOffset(Offset = "0xA4")]
	public float telephoneBookInclusionThreshold;

	// Token: 0x04004A2C RID: 18988
	[Token(Token = "0x4004A2C")]
	[FieldOffset(Offset = "0xA8")]
	public float knowPlaceOfWorkThreshold;

	// Token: 0x04004A2D RID: 18989
	[Token(Token = "0x4004A2D")]
	[FieldOffset(Offset = "0xAC")]
	public float knowAddressThreshold;

	// Token: 0x04004A2E RID: 18990
	[Token(Token = "0x4004A2E")]
	[FieldOffset(Offset = "0xB0")]
	public float knowMournThreshold;

	// Token: 0x04004A2F RID: 18991
	[Token(Token = "0x4004A2F")]
	[FieldOffset(Offset = "0xB4")]
	public float knowBirthdayThreshold;

	// Token: 0x04004A30 RID: 18992
	[Token(Token = "0x4004A30")]
	[FieldOffset(Offset = "0xB8")]
	public float knowImmediateLocationThreshold;

	// Token: 0x04004A31 RID: 18993
	[Token(Token = "0x4004A31")]
	[FieldOffset(Offset = "0xBC")]
	public bool randomSocialCreditBuffs;

	// Token: 0x04004A32 RID: 18994
	[Token(Token = "0x4004A32")]
	[FieldOffset(Offset = "0xC0")]
	public AudioEvent perkNotificationAudioEvent;

	// Token: 0x04004A33 RID: 18995
	[Token(Token = "0x4004A33")]
	[FieldOffset(Offset = "0xC8")]
	public List<SocialControls.SocialCreditBuff> socialCreditBuffs;

	// Token: 0x04004A34 RID: 18996
	[Token(Token = "0x4004A34")]
	[FieldOffset(Offset = "0x0")]
	private static SocialControls _instance;

	// Token: 0x020008C5 RID: 2245
	[Token(Token = "0x20008C5")]
	[Serializable]
	public class SocialCreditBuff
	{
		// Token: 0x06002A54 RID: 10836 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002A54")]
		[Address(RVA = "0xCBF4E0", Offset = "0xCBE4E0", VA = "0x180CBF4E0")]
		public UpgradeEffectController.AppliedEffect GetEffect()
		{
			return null;
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A55")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public SocialCreditBuff()
		{
		}

		// Token: 0x04004A35 RID: 18997
		[Token(Token = "0x4004A35")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04004A36 RID: 18998
		[Token(Token = "0x4004A36")]
		[FieldOffset(Offset = "0x18")]
		public string description;

		// Token: 0x04004A37 RID: 18999
		[Token(Token = "0x4004A37")]
		[FieldOffset(Offset = "0x20")]
		public SyncDiskPreset.Effect effect;

		// Token: 0x04004A38 RID: 19000
		[Token(Token = "0x4004A38")]
		[FieldOffset(Offset = "0x24")]
		public float value;

		// Token: 0x04004A39 RID: 19001
		[Token(Token = "0x4004A39")]
		[FieldOffset(Offset = "0x28")]
		public int randomGrouping;
	}
}
