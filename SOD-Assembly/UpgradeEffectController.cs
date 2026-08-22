using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000697 RID: 1687
[Token(Token = "0x2000697")]
public class UpgradeEffectController : MonoBehaviour
{
	// Token: 0x06002576 RID: 9590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002576")]
	[Address(RVA = "0xBC6480", Offset = "0xBC5480", VA = "0x180BC6480")]
	public void OnInstall(UpgradesController.Upgrades disk, SyncDiskPreset.Effect effect, float value)
	{
	}

	// Token: 0x06002577 RID: 9591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002577")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void OnUninstall(UpgradesController.Upgrades disk, SyncDiskPreset.Effect effect, float value)
	{
	}

	// Token: 0x06002578 RID: 9592 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002578")]
	[Address(RVA = "0xBC6530", Offset = "0xBC5530", VA = "0x180BC6530")]
	public void OnUpgrade(UpgradesController.Upgrades disk, SyncDiskPreset.UpgradeEffect effect, float value, int level)
	{
	}

	// Token: 0x06002579 RID: 9593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002579")]
	[Address(RVA = "0xBC6570", Offset = "0xBC5570", VA = "0x180BC6570")]
	public void OnSyncDiskChange(bool forceUpdate = false)
	{
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x0600257A RID: 9594 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000131")]
	public static UpgradeEffectController Instance
	{
		[Token(Token = "0x600257A")]
		[Address(RVA = "0xBC6AB0", Offset = "0xBC5AB0", VA = "0x180BC6AB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600257B RID: 9595 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600257B")]
	[Address(RVA = "0xBC6AF0", Offset = "0xBC5AF0", VA = "0x180BC6AF0")]
	private void Awake()
	{
	}

	// Token: 0x0600257C RID: 9596 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
	[Token(Token = "0x600257C")]
	[Address(RVA = "0xBC6E40", Offset = "0xBC5E40", VA = "0x180BC6E40")]
	public float GetUpgradeEffect(SyncDiskPreset.Effect effect)
	{
		return 0f;
	}

	// Token: 0x0600257D RID: 9597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600257D")]
	[Address(RVA = "0xBC7060", Offset = "0xBC6060", VA = "0x180BC7060")]
	public UpgradeEffectController()
	{
	}

	// Token: 0x04002FD3 RID: 12243
	[Token(Token = "0x4002FD3")]
	[FieldOffset(Offset = "0x18")]
	public List<UpgradeEffectController.AppliedEffect> appliedEffects;

	// Token: 0x04002FD4 RID: 12244
	[Token(Token = "0x4002FD4")]
	[FieldOffset(Offset = "0x0")]
	private static UpgradeEffectController _instance;

	// Token: 0x02000698 RID: 1688
	[Token(Token = "0x2000698")]
	[Serializable]
	public class AppliedEffect
	{
		// Token: 0x0600257E RID: 9598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600257E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public AppliedEffect()
		{
		}

		// Token: 0x04002FD5 RID: 12245
		[Token(Token = "0x4002FD5")]
		[FieldOffset(Offset = "0x10")]
		public UpgradesController.Upgrades disk;

		// Token: 0x04002FD6 RID: 12246
		[Token(Token = "0x4002FD6")]
		[FieldOffset(Offset = "0x18")]
		public SyncDiskPreset.Effect effect;

		// Token: 0x04002FD7 RID: 12247
		[Token(Token = "0x4002FD7")]
		[FieldOffset(Offset = "0x1C")]
		public float value;
	}
}
