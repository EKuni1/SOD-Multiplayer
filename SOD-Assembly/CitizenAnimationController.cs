using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000109 RID: 265
[Token(Token = "0x2000109")]
public class CitizenAnimationController : MonoBehaviour
{
	// Token: 0x06000768 RID: 1896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000768")]
	[Address(RVA = "0x481FC0", Offset = "0x480FC0", VA = "0x180481FC0")]
	public void ForceUpdateAnimationSate(bool onBecomeVisibile = false)
	{
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000769")]
	[Address(RVA = "0x482540", Offset = "0x481540", VA = "0x180482540")]
	public void UpdateMovementSpeed()
	{
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076A")]
	[Address(RVA = "0x482740", Offset = "0x481740", VA = "0x180482740")]
	public void SetArmsBoolState(CitizenAnimationController.ArmsBoolSate newState)
	{
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076B")]
	[Address(RVA = "0x482FC0", Offset = "0x481FC0", VA = "0x180482FC0")]
	public void SetUmbrella(bool val)
	{
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076C")]
	[Address(RVA = "0x483A60", Offset = "0x482A60", VA = "0x180483A60")]
	public void SetCarryingItem(bool val)
	{
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076D")]
	[Address(RVA = "0x483AC0", Offset = "0x482AC0", VA = "0x180483AC0")]
	public void SetCarryItemType(int carryType)
	{
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076E")]
	[Address(RVA = "0x483B20", Offset = "0x482B20", VA = "0x180483B20")]
	public void SetInCombat(bool val)
	{
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600076F")]
	[Address(RVA = "0x483DD0", Offset = "0x482DD0", VA = "0x180483DD0")]
	public void SetCombatArmsOverride(int val)
	{
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000770")]
	[Address(RVA = "0x483ED0", Offset = "0x482ED0", VA = "0x180483ED0")]
	public void SetRestrained(bool val)
	{
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000771")]
	[Address(RVA = "0x483F70", Offset = "0x482F70", VA = "0x180483F70")]
	public void SetIdleAnimationState(CitizenAnimationController.IdleAnimationState newState)
	{
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000772")]
	[Address(RVA = "0x4840A0", Offset = "0x4830A0", VA = "0x1804840A0")]
	public void SetInBed(bool val, bool isLowBed, bool onRightSide = false, bool instant = false)
	{
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000773")]
	[Address(RVA = "0x484210", Offset = "0x483210", VA = "0x180484210")]
	public void FlipAnimationToRight(bool val)
	{
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000774")]
	[Address(RVA = "0x484280", Offset = "0x483280", VA = "0x180484280")]
	public void SetDead(bool val)
	{
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000775")]
	[Address(RVA = "0x4842E0", Offset = "0x4832E0", VA = "0x1804842E0")]
	public void TriggerTrip()
	{
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000776")]
	[Address(RVA = "0x484380", Offset = "0x483380", VA = "0x180484380")]
	public void CancelTrip()
	{
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000777")]
	[Address(RVA = "0x4844B0", Offset = "0x4834B0", VA = "0x1804844B0")]
	public void AttackTrigger()
	{
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000778")]
	[Address(RVA = "0x4847A0", Offset = "0x4837A0", VA = "0x1804847A0")]
	public void ThrowTrigger()
	{
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000779")]
	[Address(RVA = "0x4848A0", Offset = "0x4838A0", VA = "0x1804848A0")]
	public void AbortAttackTrigger()
	{
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600077A")]
	[Address(RVA = "0x4849A0", Offset = "0x4839A0", VA = "0x1804849A0")]
	public void BlockTrigger(float blockDelay, bool perfect = false)
	{
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600077B")]
	[Address(RVA = "0x484A90", Offset = "0x483A90", VA = "0x180484A90")]
	public void TakeDamageRecoil(Vector3 hitPosition)
	{
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600077C")]
	[Address(RVA = "0x484D60", Offset = "0x483D60", VA = "0x180484D60")]
	public void SetPauseAnimation(bool val)
	{
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600077D")]
	[Address(RVA = "0x484F70", Offset = "0x483F70", VA = "0x180484F70")]
	public void SetRagdoll(bool val, bool dead = false)
	{
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600077E")]
	[Address(RVA = "0x48E0D0", Offset = "0x48D0D0", VA = "0x18048E0D0")]
	private void ApplyRagdollJointSettings(ref CharacterJoint joint)
	{
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600077F")]
	[Address(RVA = "0x48E370", Offset = "0x48D370", VA = "0x18048E370")]
	public List<CitizenAnimationController.RagdollSnapshot> GetLimbSnapshot()
	{
		return null;
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000780")]
	[Address(RVA = "0x48E6F0", Offset = "0x48D6F0", VA = "0x18048E6F0")]
	public List<CitizenAnimationController.RagdollSnapshotWorld> GetLimbSnapshotWorld()
	{
		return null;
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000781")]
	[Address(RVA = "0x48EA70", Offset = "0x48DA70", VA = "0x18048EA70")]
	public void LoadLimbSnapshot(List<CitizenAnimationController.RagdollSnapshot> snapshot)
	{
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000782")]
	[Address(RVA = "0x491290", Offset = "0x490290", VA = "0x180491290")]
	public void LoadLimbSnapshot(List<CitizenAnimationController.RagdollSnapshotWorld> snapshot)
	{
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000783")]
	[Address(RVA = "0x493AF0", Offset = "0x492AF0", VA = "0x180493AF0")]
	public CitizenAnimationController()
	{
	}

	// Token: 0x0400077F RID: 1919
	[Token(Token = "0x400077F")]
	[FieldOffset(Offset = "0x18")]
	public Human cit;

	// Token: 0x04000780 RID: 1920
	[Token(Token = "0x4000780")]
	[FieldOffset(Offset = "0x20")]
	public Animator mainAnimator;

	// Token: 0x04000781 RID: 1921
	[Token(Token = "0x4000781")]
	[FieldOffset(Offset = "0x28")]
	public GameObject spawnedUmbrella;

	// Token: 0x04000782 RID: 1922
	[Token(Token = "0x4000782")]
	[FieldOffset(Offset = "0x30")]
	public Transform umbrellaCanopy;

	// Token: 0x04000783 RID: 1923
	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0x38")]
	public float armsLayerDesiredWeight;

	// Token: 0x04000784 RID: 1924
	[Token(Token = "0x4000784")]
	[FieldOffset(Offset = "0x3C")]
	public float umbreallLayerDesiredWeight;

	// Token: 0x04000785 RID: 1925
	[Token(Token = "0x4000785")]
	[FieldOffset(Offset = "0x40")]
	public float oneShotUseReset;

	// Token: 0x04000786 RID: 1926
	[Token(Token = "0x4000786")]
	[FieldOffset(Offset = "0x44")]
	public CitizenAnimationController.ArmsBoolSate armsBoolAnimationState;

	// Token: 0x04000787 RID: 1927
	[Token(Token = "0x4000787")]
	[FieldOffset(Offset = "0x48")]
	public CitizenAnimationController.IdleAnimationState idleAnimationState;

	// Token: 0x04000788 RID: 1928
	[Token(Token = "0x4000788")]
	[FieldOffset(Offset = "0x4C")]
	public bool flipToRightAnimation;

	// Token: 0x04000789 RID: 1929
	[Token(Token = "0x4000789")]
	[FieldOffset(Offset = "0x4D")]
	public bool paused;

	// Token: 0x0400078A RID: 1930
	[Token(Token = "0x400078A")]
	[FieldOffset(Offset = "0x4E")]
	public bool umbrella;

	// Token: 0x0400078B RID: 1931
	[Token(Token = "0x400078B")]
	[FieldOffset(Offset = "0x50")]
	public float unpausedAnimatorSpeed;

	// Token: 0x0400078C RID: 1932
	[Token(Token = "0x400078C")]
	[FieldOffset(Offset = "0x58")]
	public Transform armsParent;

	// Token: 0x0400078D RID: 1933
	[Token(Token = "0x400078D")]
	[FieldOffset(Offset = "0x60")]
	public BoxCollider newBoxCollider;

	// Token: 0x0400078E RID: 1934
	[Token(Token = "0x400078E")]
	[FieldOffset(Offset = "0x68")]
	[NonSerialized]
	public Rigidbody upperTorsoRB;

	// Token: 0x0400078F RID: 1935
	[Token(Token = "0x400078F")]
	[FieldOffset(Offset = "0x70")]
	public Dictionary<CitizenOutfitController.CharacterAnchor, CitizenAnimationController.CitizenPhysics> physicsComponents;

	// Token: 0x04000790 RID: 1936
	[Token(Token = "0x4000790")]
	[FieldOffset(Offset = "0x78")]
	[NonSerialized]
	public List<Rigidbody> createdRBs;

	// Token: 0x04000791 RID: 1937
	[Token(Token = "0x4000791")]
	[FieldOffset(Offset = "0x80")]
	[NonSerialized]
	public List<CharacterJoint> createdJoints;

	// Token: 0x04000792 RID: 1938
	[Token(Token = "0x4000792")]
	[FieldOffset(Offset = "0x88")]
	[NonSerialized]
	public List<Collider> createdColliders;

	// Token: 0x04000793 RID: 1939
	[Token(Token = "0x4000793")]
	[FieldOffset(Offset = "0x90")]
	[NonSerialized]
	public RagdollSFXController sfx;

	// Token: 0x04000794 RID: 1940
	[Token(Token = "0x4000794")]
	[FieldOffset(Offset = "0x98")]
	private CharacterJoint headJoint;

	// Token: 0x04000795 RID: 1941
	[Token(Token = "0x4000795")]
	[FieldOffset(Offset = "0xA0")]
	private CharacterJoint upperTorsoJoint;

	// Token: 0x04000796 RID: 1942
	[Token(Token = "0x4000796")]
	[FieldOffset(Offset = "0xA8")]
	private CharacterJoint midriffJoint;

	// Token: 0x04000797 RID: 1943
	[Token(Token = "0x4000797")]
	[FieldOffset(Offset = "0xB0")]
	private CharacterJoint leftUpperArmJoint;

	// Token: 0x04000798 RID: 1944
	[Token(Token = "0x4000798")]
	[FieldOffset(Offset = "0xB8")]
	private CharacterJoint leftLowerArmJoint;

	// Token: 0x04000799 RID: 1945
	[Token(Token = "0x4000799")]
	[FieldOffset(Offset = "0xC0")]
	private CharacterJoint leftHandJoint;

	// Token: 0x0400079A RID: 1946
	[Token(Token = "0x400079A")]
	[FieldOffset(Offset = "0xC8")]
	private CharacterJoint rightUpperArmJoint;

	// Token: 0x0400079B RID: 1947
	[Token(Token = "0x400079B")]
	[FieldOffset(Offset = "0xD0")]
	private CharacterJoint rightLowerArmJoint;

	// Token: 0x0400079C RID: 1948
	[Token(Token = "0x400079C")]
	[FieldOffset(Offset = "0xD8")]
	private CharacterJoint rightHandJoint;

	// Token: 0x0400079D RID: 1949
	[Token(Token = "0x400079D")]
	[FieldOffset(Offset = "0xE0")]
	private CharacterJoint leftUpperLegJoint;

	// Token: 0x0400079E RID: 1950
	[Token(Token = "0x400079E")]
	[FieldOffset(Offset = "0xE8")]
	private CharacterJoint leftLowerLegJoint;

	// Token: 0x0400079F RID: 1951
	[Token(Token = "0x400079F")]
	[FieldOffset(Offset = "0xF0")]
	private CharacterJoint rightUpperLegJoint;

	// Token: 0x040007A0 RID: 1952
	[Token(Token = "0x40007A0")]
	[FieldOffset(Offset = "0xF8")]
	private CharacterJoint rightLowerLegJoint;

	// Token: 0x040007A1 RID: 1953
	[Token(Token = "0x40007A1")]
	[FieldOffset(Offset = "0x100")]
	private CharacterJoint rightFootJoint;

	// Token: 0x040007A2 RID: 1954
	[Token(Token = "0x40007A2")]
	[FieldOffset(Offset = "0x108")]
	private CharacterJoint leftFootJoint;

	// Token: 0x040007A3 RID: 1955
	[Token(Token = "0x40007A3")]
	[FieldOffset(Offset = "0x110")]
	[NonSerialized]
	public List<CitizenAnimationController.RagdollSnapshot> ragdollSnapshot;

	// Token: 0x040007A4 RID: 1956
	[Token(Token = "0x40007A4")]
	[FieldOffset(Offset = "0x118")]
	public float debugMainAnimatorSpeed;

	// Token: 0x0200010A RID: 266
	[Token(Token = "0x200010A")]
	public enum ArmsBoolSate
	{
		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		none,
		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		armsResting,
		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		armsTyping,
		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		armsUse,
		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		armsLocking,
		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		armsCuffed,
		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		armsConsuming,
		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		armsOneShotUse,
		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		armsSmoking,
		// Token: 0x040007AF RID: 1967
		[Token(Token = "0x40007AF")]
		armsSmokingPipe,
		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		armsReading,
		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		armsFleeing
	}

	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	public enum IdleAnimationState
	{
		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		none,
		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		sitting,
		// Token: 0x040007B5 RID: 1973
		[Token(Token = "0x40007B5")]
		sweeping,
		// Token: 0x040007B6 RID: 1974
		[Token(Token = "0x40007B6")]
		warmingHands,
		// Token: 0x040007B7 RID: 1975
		[Token(Token = "0x40007B7")]
		telephone,
		// Token: 0x040007B8 RID: 1976
		[Token(Token = "0x40007B8")]
		washingHands,
		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x40007B9")]
		cleaningBar,
		// Token: 0x040007BA RID: 1978
		[Token(Token = "0x40007BA")]
		bargingDoor,
		// Token: 0x040007BB RID: 1979
		[Token(Token = "0x40007BB")]
		cookingChopping,
		// Token: 0x040007BC RID: 1980
		[Token(Token = "0x40007BC")]
		cookingFrying,
		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x40007BD")]
		sitAgainstWall,
		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x40007BE")]
		leanAgainstWall,
		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x40007BF")]
		showering,
		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		rubbingEyes,
		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		cowering,
		// Token: 0x040007C2 RID: 1986
		[Token(Token = "0x40007C2")]
		checkPulse,
		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		brushingTeeth,
		// Token: 0x040007C4 RID: 1988
		[Token(Token = "0x40007C4")]
		pickUpFromFloor,
		// Token: 0x040007C5 RID: 1989
		[Token(Token = "0x40007C5")]
		danceTwist,
		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x40007C6")]
		danceWatusi,
		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		stackingObjects,
		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		stackingObjectsCrouching
	}

	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	[Serializable]
	public class CitizenPhysics
	{
		// Token: 0x06000784 RID: 1924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public CitizenPhysics()
		{
		}

		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0x10")]
		public CitizenOutfitController.AnchorConfig anchorConfig;

		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		[FieldOffset(Offset = "0x18")]
		public Collider coll;

		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x40007CB")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody rb;
	}

	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	[Serializable]
	public class RagdollSnapshot
	{
		// Token: 0x06000785 RID: 1925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public RagdollSnapshot()
		{
		}

		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		[FieldOffset(Offset = "0x10")]
		public CitizenOutfitController.AnchorConfig anchorConfig;

		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 localPos;

		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		[FieldOffset(Offset = "0x24")]
		public Quaternion localRot;
	}

	// Token: 0x0200010E RID: 270
	[Token(Token = "0x200010E")]
	[Serializable]
	public class RagdollSnapshotWorld
	{
		// Token: 0x06000786 RID: 1926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public RagdollSnapshotWorld()
		{
		}

		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0x10")]
		public CitizenOutfitController.AnchorConfig anchorConfig;

		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 worldPos;

		// Token: 0x040007D1 RID: 2001
		[Token(Token = "0x40007D1")]
		[FieldOffset(Offset = "0x24")]
		public Quaternion worldRot;
	}

	// Token: 0x0200010F RID: 271
	[Token(Token = "0x200010F")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000788 RID: 1928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00004F38 File Offset: 0x00003138
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x494140", Offset = "0x493140", VA = "0x180494140")]
		internal bool <LoadLimbSnapshot>b__68_0(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00004F50 File Offset: 0x00003150
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x494170", Offset = "0x493170", VA = "0x180494170")]
		internal bool <LoadLimbSnapshot>b__68_1(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00004F68 File Offset: 0x00003168
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x4941A0", Offset = "0x4931A0", VA = "0x1804941A0")]
		internal bool <LoadLimbSnapshot>b__68_2(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00004F80 File Offset: 0x00003180
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x4941D0", Offset = "0x4931D0", VA = "0x1804941D0")]
		internal bool <LoadLimbSnapshot>b__68_3(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00004F98 File Offset: 0x00003198
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x494200", Offset = "0x493200", VA = "0x180494200")]
		internal bool <LoadLimbSnapshot>b__68_4(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00004FB0 File Offset: 0x000031B0
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x494230", Offset = "0x493230", VA = "0x180494230")]
		internal bool <LoadLimbSnapshot>b__68_5(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x494260", Offset = "0x493260", VA = "0x180494260")]
		internal bool <LoadLimbSnapshot>b__68_6(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00004FE0 File Offset: 0x000031E0
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x494290", Offset = "0x493290", VA = "0x180494290")]
		internal bool <LoadLimbSnapshot>b__68_7(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00004FF8 File Offset: 0x000031F8
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x4942C0", Offset = "0x4932C0", VA = "0x1804942C0")]
		internal bool <LoadLimbSnapshot>b__68_8(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00005010 File Offset: 0x00003210
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x4942F0", Offset = "0x4932F0", VA = "0x1804942F0")]
		internal bool <LoadLimbSnapshot>b__68_9(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00005028 File Offset: 0x00003228
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x494320", Offset = "0x493320", VA = "0x180494320")]
		internal bool <LoadLimbSnapshot>b__68_10(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00005040 File Offset: 0x00003240
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x494350", Offset = "0x493350", VA = "0x180494350")]
		internal bool <LoadLimbSnapshot>b__68_11(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x494380", Offset = "0x493380", VA = "0x180494380")]
		internal bool <LoadLimbSnapshot>b__68_12(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00005070 File Offset: 0x00003270
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x4943B0", Offset = "0x4933B0", VA = "0x1804943B0")]
		internal bool <LoadLimbSnapshot>b__68_13(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00005088 File Offset: 0x00003288
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x4943E0", Offset = "0x4933E0", VA = "0x1804943E0")]
		internal bool <LoadLimbSnapshot>b__68_14(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x000050A0 File Offset: 0x000032A0
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x494410", Offset = "0x493410", VA = "0x180494410")]
		internal bool <LoadLimbSnapshot>b__68_15(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000050B8 File Offset: 0x000032B8
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x494440", Offset = "0x493440", VA = "0x180494440")]
		internal bool <LoadLimbSnapshot>b__68_16(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x000050D0 File Offset: 0x000032D0
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x494470", Offset = "0x493470", VA = "0x180494470")]
		internal bool <LoadLimbSnapshot>b__68_17(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000050E8 File Offset: 0x000032E8
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x4944A0", Offset = "0x4934A0", VA = "0x1804944A0")]
		internal bool <LoadLimbSnapshot>b__68_18(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00005100 File Offset: 0x00003300
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x4944D0", Offset = "0x4934D0", VA = "0x1804944D0")]
		internal bool <LoadLimbSnapshot>b__68_19(CitizenAnimationController.RagdollSnapshot item)
		{
			return default(bool);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00005118 File Offset: 0x00003318
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x494140", Offset = "0x493140", VA = "0x180494140")]
		internal bool <LoadLimbSnapshot>b__69_0(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00005130 File Offset: 0x00003330
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x494170", Offset = "0x493170", VA = "0x180494170")]
		internal bool <LoadLimbSnapshot>b__69_1(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00005148 File Offset: 0x00003348
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x4941A0", Offset = "0x4931A0", VA = "0x1804941A0")]
		internal bool <LoadLimbSnapshot>b__69_2(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00005160 File Offset: 0x00003360
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x4941D0", Offset = "0x4931D0", VA = "0x1804941D0")]
		internal bool <LoadLimbSnapshot>b__69_3(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00005178 File Offset: 0x00003378
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x494200", Offset = "0x493200", VA = "0x180494200")]
		internal bool <LoadLimbSnapshot>b__69_4(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00005190 File Offset: 0x00003390
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x494230", Offset = "0x493230", VA = "0x180494230")]
		internal bool <LoadLimbSnapshot>b__69_5(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x000051A8 File Offset: 0x000033A8
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x494260", Offset = "0x493260", VA = "0x180494260")]
		internal bool <LoadLimbSnapshot>b__69_6(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000051C0 File Offset: 0x000033C0
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x494290", Offset = "0x493290", VA = "0x180494290")]
		internal bool <LoadLimbSnapshot>b__69_7(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x000051D8 File Offset: 0x000033D8
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x4942C0", Offset = "0x4932C0", VA = "0x1804942C0")]
		internal bool <LoadLimbSnapshot>b__69_8(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000051F0 File Offset: 0x000033F0
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x4942F0", Offset = "0x4932F0", VA = "0x1804942F0")]
		internal bool <LoadLimbSnapshot>b__69_9(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00005208 File Offset: 0x00003408
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x494320", Offset = "0x493320", VA = "0x180494320")]
		internal bool <LoadLimbSnapshot>b__69_10(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00005220 File Offset: 0x00003420
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x494350", Offset = "0x493350", VA = "0x180494350")]
		internal bool <LoadLimbSnapshot>b__69_11(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00005238 File Offset: 0x00003438
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x494380", Offset = "0x493380", VA = "0x180494380")]
		internal bool <LoadLimbSnapshot>b__69_12(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00005250 File Offset: 0x00003450
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x4943B0", Offset = "0x4933B0", VA = "0x1804943B0")]
		internal bool <LoadLimbSnapshot>b__69_13(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00005268 File Offset: 0x00003468
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x4943E0", Offset = "0x4933E0", VA = "0x1804943E0")]
		internal bool <LoadLimbSnapshot>b__69_14(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00005280 File Offset: 0x00003480
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x494410", Offset = "0x493410", VA = "0x180494410")]
		internal bool <LoadLimbSnapshot>b__69_15(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00005298 File Offset: 0x00003498
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x494440", Offset = "0x493440", VA = "0x180494440")]
		internal bool <LoadLimbSnapshot>b__69_16(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000052B0 File Offset: 0x000034B0
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x494470", Offset = "0x493470", VA = "0x180494470")]
		internal bool <LoadLimbSnapshot>b__69_17(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000052C8 File Offset: 0x000034C8
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x4944A0", Offset = "0x4934A0", VA = "0x1804944A0")]
		internal bool <LoadLimbSnapshot>b__69_18(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000052E0 File Offset: 0x000034E0
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x4944D0", Offset = "0x4934D0", VA = "0x1804944D0")]
		internal bool <LoadLimbSnapshot>b__69_19(CitizenAnimationController.RagdollSnapshotWorld item)
		{
			return default(bool);
		}

		// Token: 0x040007D2 RID: 2002
		[Token(Token = "0x40007D2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CitizenAnimationController.<>c <>9;

		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_0;

		// Token: 0x040007D4 RID: 2004
		[Token(Token = "0x40007D4")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_1;

		// Token: 0x040007D5 RID: 2005
		[Token(Token = "0x40007D5")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_2;

		// Token: 0x040007D6 RID: 2006
		[Token(Token = "0x40007D6")]
		[FieldOffset(Offset = "0x20")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_3;

		// Token: 0x040007D7 RID: 2007
		[Token(Token = "0x40007D7")]
		[FieldOffset(Offset = "0x28")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_4;

		// Token: 0x040007D8 RID: 2008
		[Token(Token = "0x40007D8")]
		[FieldOffset(Offset = "0x30")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_5;

		// Token: 0x040007D9 RID: 2009
		[Token(Token = "0x40007D9")]
		[FieldOffset(Offset = "0x38")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_6;

		// Token: 0x040007DA RID: 2010
		[Token(Token = "0x40007DA")]
		[FieldOffset(Offset = "0x40")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_7;

		// Token: 0x040007DB RID: 2011
		[Token(Token = "0x40007DB")]
		[FieldOffset(Offset = "0x48")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_8;

		// Token: 0x040007DC RID: 2012
		[Token(Token = "0x40007DC")]
		[FieldOffset(Offset = "0x50")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_9;

		// Token: 0x040007DD RID: 2013
		[Token(Token = "0x40007DD")]
		[FieldOffset(Offset = "0x58")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_10;

		// Token: 0x040007DE RID: 2014
		[Token(Token = "0x40007DE")]
		[FieldOffset(Offset = "0x60")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_11;

		// Token: 0x040007DF RID: 2015
		[Token(Token = "0x40007DF")]
		[FieldOffset(Offset = "0x68")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_12;

		// Token: 0x040007E0 RID: 2016
		[Token(Token = "0x40007E0")]
		[FieldOffset(Offset = "0x70")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_13;

		// Token: 0x040007E1 RID: 2017
		[Token(Token = "0x40007E1")]
		[FieldOffset(Offset = "0x78")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_14;

		// Token: 0x040007E2 RID: 2018
		[Token(Token = "0x40007E2")]
		[FieldOffset(Offset = "0x80")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_15;

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0x88")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_16;

		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		[FieldOffset(Offset = "0x90")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_17;

		// Token: 0x040007E5 RID: 2021
		[Token(Token = "0x40007E5")]
		[FieldOffset(Offset = "0x98")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_18;

		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0xA0")]
		public static Predicate<CitizenAnimationController.RagdollSnapshot> <>9__68_19;

		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		[FieldOffset(Offset = "0xA8")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_0;

		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		[FieldOffset(Offset = "0xB0")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_1;

		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		[FieldOffset(Offset = "0xB8")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_2;

		// Token: 0x040007EA RID: 2026
		[Token(Token = "0x40007EA")]
		[FieldOffset(Offset = "0xC0")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_3;

		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		[FieldOffset(Offset = "0xC8")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_4;

		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x40007EC")]
		[FieldOffset(Offset = "0xD0")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_5;

		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0xD8")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_6;

		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0xE0")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_7;

		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x40007EF")]
		[FieldOffset(Offset = "0xE8")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_8;

		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		[FieldOffset(Offset = "0xF0")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_9;

		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		[FieldOffset(Offset = "0xF8")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_10;

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0x100")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_11;

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x108")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_12;

		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0x110")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_13;

		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x40007F5")]
		[FieldOffset(Offset = "0x118")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_14;

		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x40007F6")]
		[FieldOffset(Offset = "0x120")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_15;

		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x40007F7")]
		[FieldOffset(Offset = "0x128")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_16;

		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x40007F8")]
		[FieldOffset(Offset = "0x130")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_17;

		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		[FieldOffset(Offset = "0x138")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_18;

		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x40007FA")]
		[FieldOffset(Offset = "0x140")]
		public static Predicate<CitizenAnimationController.RagdollSnapshotWorld> <>9__69_19;
	}
}
