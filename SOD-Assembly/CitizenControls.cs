using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008A8 RID: 2216
[Token(Token = "0x20008A8")]
public class CitizenControls : MonoBehaviour
{
	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06002A11 RID: 10769 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700014C")]
	public static CitizenControls Instance
	{
		[Token(Token = "0x6002A11")]
		[Address(RVA = "0xCB5330", Offset = "0xCB4330", VA = "0x180CB5330")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002A12 RID: 10770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A12")]
	[Address(RVA = "0xCB5370", Offset = "0xCB4370", VA = "0x180CB5370")]
	private void Awake()
	{
	}

	// Token: 0x06002A13 RID: 10771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A13")]
	[Address(RVA = "0xCB56C0", Offset = "0xCB46C0", VA = "0x180CB56C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002A14 RID: 10772 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A14")]
	[Address(RVA = "0xCB58D0", Offset = "0xCB48D0", VA = "0x180CB58D0")]
	public void ClearManualAnimation()
	{
	}

	// Token: 0x06002A15 RID: 10773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A15")]
	[Address(RVA = "0xCB5940", Offset = "0xCB4940", VA = "0x180CB5940")]
	public void AddManualKeyframe()
	{
	}

	// Token: 0x06002A16 RID: 10774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A16")]
	[Address(RVA = "0xCB5E50", Offset = "0xCB4E50", VA = "0x180CB5E50")]
	public void DebugCitizensStuck()
	{
	}

	// Token: 0x06002A17 RID: 10775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A17")]
	[Address(RVA = "0xCB6DB0", Offset = "0xCB5DB0", VA = "0x180CB6DB0")]
	public CitizenControls()
	{
	}

	// Token: 0x04004554 RID: 17748
	[Token(Token = "0x4004554")]
	[FieldOffset(Offset = "0x18")]
	public float baseCitizenWalkSpeed;

	// Token: 0x04004555 RID: 17749
	[Token(Token = "0x4004555")]
	[FieldOffset(Offset = "0x1C")]
	public float baseCitizenRunSpeed;

	// Token: 0x04004556 RID: 17750
	[Token(Token = "0x4004556")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve acceleration;

	// Token: 0x04004557 RID: 17751
	[Token(Token = "0x4004557")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve decceleration;

	// Token: 0x04004558 RID: 17752
	[Token(Token = "0x4004558")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 movementSpeedMultiplierRange;

	// Token: 0x04004559 RID: 17753
	[Token(Token = "0x4004559")]
	[FieldOffset(Offset = "0x38")]
	public float citizenFaceSpeed;

	// Token: 0x0400455A RID: 17754
	[Token(Token = "0x400455A")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 citizenLookAtSpeed;

	// Token: 0x0400455B RID: 17755
	[Token(Token = "0x400455B")]
	[FieldOffset(Offset = "0x44")]
	public float citizenFootstepDistance;

	// Token: 0x0400455C RID: 17756
	[Token(Token = "0x400455C")]
	[FieldOffset(Offset = "0x48")]
	public float drunkMovementPenalty;

	// Token: 0x0400455D RID: 17757
	[Token(Token = "0x400455D")]
	[FieldOffset(Offset = "0x4C")]
	public float drunkFallChance;

	// Token: 0x0400455E RID: 17758
	[Token(Token = "0x400455E")]
	[FieldOffset(Offset = "0x50")]
	public Vector2 capsuleMovementThickness;

	// Token: 0x0400455F RID: 17759
	[Token(Token = "0x400455F")]
	[FieldOffset(Offset = "0x58")]
	public float baseScale;

	// Token: 0x04004560 RID: 17760
	[Token(Token = "0x4004560")]
	[FieldOffset(Offset = "0x5C")]
	public float speechBubbleHeight;

	// Token: 0x04004561 RID: 17761
	[Token(Token = "0x4004561")]
	[FieldOffset(Offset = "0x60")]
	public DialogPreset askAboutJob;

	// Token: 0x04004562 RID: 17762
	[Token(Token = "0x4004562")]
	[FieldOffset(Offset = "0x68")]
	public int maxSpeechBubbles;

	// Token: 0x04004563 RID: 17763
	[Token(Token = "0x4004563")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve societalClassSavingsCurve;

	// Token: 0x04004564 RID: 17764
	[Token(Token = "0x4004564")]
	[FieldOffset(Offset = "0x78")]
	public List<CharacterTrait> savingsBoostTrait;

	// Token: 0x04004565 RID: 17765
	[Token(Token = "0x4004565")]
	[FieldOffset(Offset = "0x80")]
	public List<CharacterTrait> savingsDebuffTrait;

	// Token: 0x04004566 RID: 17766
	[Token(Token = "0x4004566")]
	[FieldOffset(Offset = "0x88")]
	public DialogPreset telephoneGreeting;

	// Token: 0x04004567 RID: 17767
	[Token(Token = "0x4004567")]
	[FieldOffset(Offset = "0x90")]
	public DialogPreset identifyNumberDialog;

	// Token: 0x04004568 RID: 17768
	[Token(Token = "0x4004568")]
	[FieldOffset(Offset = "0x98")]
	public DialogPreset lastCallerDialog;

	// Token: 0x04004569 RID: 17769
	[Token(Token = "0x4004569")]
	[FieldOffset(Offset = "0xA0")]
	public DialogPreset policeDialog;

	// Token: 0x0400456A RID: 17770
	[Token(Token = "0x400456A")]
	[FieldOffset(Offset = "0xA8")]
	public DialogPreset coverUpOffer;

	// Token: 0x0400456B RID: 17771
	[Token(Token = "0x400456B")]
	[FieldOffset(Offset = "0xB0")]
	public DialogPreset coverUpBodyLocation;

	// Token: 0x0400456C RID: 17772
	[Token(Token = "0x400456C")]
	[FieldOffset(Offset = "0xB8")]
	public DialogPreset coverUpSuccess;

	// Token: 0x0400456D RID: 17773
	[Token(Token = "0x400456D")]
	[FieldOffset(Offset = "0xC0")]
	public DialogPreset telephoneWrongPerson;

	// Token: 0x0400456E RID: 17774
	[Token(Token = "0x400456E")]
	[FieldOffset(Offset = "0xC8")]
	public List<EvidenceWitness.DialogOption> coverUpConvoOptions;

	// Token: 0x0400456F RID: 17775
	[Token(Token = "0x400456F")]
	[FieldOffset(Offset = "0xD0")]
	public string fallbackTelephoneConversation;

	// Token: 0x04004570 RID: 17776
	[Token(Token = "0x4004570")]
	[FieldOffset(Offset = "0xD8")]
	public float minimumInvestigateTime;

	// Token: 0x04004571 RID: 17777
	[Token(Token = "0x4004571")]
	[FieldOffset(Offset = "0xDC")]
	public float persuitChaseLogicAdditionPerSecond;

	// Token: 0x04004572 RID: 17778
	[Token(Token = "0x4004572")]
	[FieldOffset(Offset = "0xE0")]
	public int maxChaseLogic;

	// Token: 0x04004573 RID: 17779
	[Token(Token = "0x4004573")]
	[FieldOffset(Offset = "0xE4")]
	public Vector2 persuitTimerThreshold;

	// Token: 0x04004574 RID: 17780
	[Token(Token = "0x4004574")]
	[FieldOffset(Offset = "0xEC")]
	public float persuitForgetThreshold;

	// Token: 0x04004575 RID: 17781
	[Token(Token = "0x4004575")]
	[FieldOffset(Offset = "0xF0")]
	public float hearingForgetThreshold;

	// Token: 0x04004576 RID: 17782
	[Token(Token = "0x4004576")]
	[FieldOffset(Offset = "0xF4")]
	public float persuitMinInvestigationTimeMP;

	// Token: 0x04004577 RID: 17783
	[Token(Token = "0x4004577")]
	[FieldOffset(Offset = "0xF8")]
	public float sightingMinInvestigationTimeMP;

	// Token: 0x04004578 RID: 17784
	[Token(Token = "0x4004578")]
	[FieldOffset(Offset = "0xFC")]
	public float soundMinInvestigationTimeMP;

	// Token: 0x04004579 RID: 17785
	[Token(Token = "0x4004579")]
	[FieldOffset(Offset = "0x100")]
	public float lookAtGracePeriod;

	// Token: 0x0400457A RID: 17786
	[Token(Token = "0x400457A")]
	[FieldOffset(Offset = "0x104")]
	public float punchedResponseRange;

	// Token: 0x0400457B RID: 17787
	[Token(Token = "0x400457B")]
	[FieldOffset(Offset = "0x108")]
	public int defaultMemoryLimit;

	// Token: 0x0400457C RID: 17788
	[Token(Token = "0x400457C")]
	[FieldOffset(Offset = "0x10C")]
	public float citizenBaseRecoveryRate;

	// Token: 0x0400457D RID: 17789
	[Token(Token = "0x400457D")]
	[FieldOffset(Offset = "0x110")]
	public Vector2 citizenBaseCombatSkillRange;

	// Token: 0x0400457E RID: 17790
	[Token(Token = "0x400457E")]
	[FieldOffset(Offset = "0x118")]
	public float citizenCombatHeftMultiplier;

	// Token: 0x0400457F RID: 17791
	[Token(Token = "0x400457F")]
	[FieldOffset(Offset = "0x11C")]
	public float throwMinRange;

	// Token: 0x04004580 RID: 17792
	[Token(Token = "0x4004580")]
	[FieldOffset(Offset = "0x120")]
	public float throwMaxRange;

	// Token: 0x04004581 RID: 17793
	[Token(Token = "0x4004581")]
	[FieldOffset(Offset = "0x124")]
	public float nerveDamageShockMultiplier;

	// Token: 0x04004582 RID: 17794
	[Token(Token = "0x4004582")]
	[FieldOffset(Offset = "0x128")]
	public float nerveWeaponDrawMultiplier;

	// Token: 0x04004583 RID: 17795
	[Token(Token = "0x4004583")]
	[FieldOffset(Offset = "0x12C")]
	public float nerveRecoveryRateMultiplier;

	// Token: 0x04004584 RID: 17796
	[Token(Token = "0x4004584")]
	[FieldOffset(Offset = "0x130")]
	public float doorBargeKOForceMultiplier;

	// Token: 0x04004585 RID: 17797
	[Token(Token = "0x4004585")]
	[FieldOffset(Offset = "0x134")]
	public float damageRecieveForceMultiplier;

	// Token: 0x04004586 RID: 17798
	[Token(Token = "0x4004586")]
	[FieldOffset(Offset = "0x138")]
	public float ragdollTransitionTime;

	// Token: 0x04004587 RID: 17799
	[Token(Token = "0x4004587")]
	[FieldOffset(Offset = "0x13C")]
	public float getUpTimer;

	// Token: 0x04004588 RID: 17800
	[Token(Token = "0x4004588")]
	[FieldOffset(Offset = "0x140")]
	public List<CitizenControls.ManualAnimation> getUpManualAnimation;

	// Token: 0x04004589 RID: 17801
	[Token(Token = "0x4004589")]
	[FieldOffset(Offset = "0x148")]
	public float stealthSkillApplicationRate;

	// Token: 0x0400458A RID: 17802
	[Token(Token = "0x400458A")]
	[FieldOffset(Offset = "0x14C")]
	public float stealthSkillCancelRate;

	// Token: 0x0400458B RID: 17803
	[Token(Token = "0x400458B")]
	[FieldOffset(Offset = "0x150")]
	public float leftExtent;

	// Token: 0x0400458C RID: 17804
	[Token(Token = "0x400458C")]
	[FieldOffset(Offset = "0x154")]
	public float rightExtent;

	// Token: 0x0400458D RID: 17805
	[Token(Token = "0x400458D")]
	[FieldOffset(Offset = "0x158")]
	public float upExtent;

	// Token: 0x0400458E RID: 17806
	[Token(Token = "0x400458E")]
	[FieldOffset(Offset = "0x15C")]
	public float downExtent;

	// Token: 0x0400458F RID: 17807
	[Token(Token = "0x400458F")]
	[FieldOffset(Offset = "0x160")]
	public float sittingYOffset;

	// Token: 0x04004590 RID: 17808
	[Token(Token = "0x4004590")]
	[FieldOffset(Offset = "0x164")]
	public float armsStandingYOffset;

	// Token: 0x04004591 RID: 17809
	[Token(Token = "0x4004591")]
	[FieldOffset(Offset = "0x168")]
	public Texture2D unknownPrint;

	// Token: 0x04004592 RID: 17810
	[Token(Token = "0x4004592")]
	[FieldOffset(Offset = "0x170")]
	public List<Texture2D> prints;

	// Token: 0x04004593 RID: 17811
	[Token(Token = "0x4004593")]
	[FieldOffset(Offset = "0x178")]
	public CharacterTrait destitute;

	// Token: 0x04004594 RID: 17812
	[Token(Token = "0x4004594")]
	[FieldOffset(Offset = "0x180")]
	public CharacterTrait litterBug;

	// Token: 0x04004595 RID: 17813
	[Token(Token = "0x4004595")]
	[FieldOffset(Offset = "0x188")]
	public CharacterTrait likesTheRain;

	// Token: 0x04004596 RID: 17814
	[Token(Token = "0x4004596")]
	[FieldOffset(Offset = "0x190")]
	public CharacterTrait shoesNormal;

	// Token: 0x04004597 RID: 17815
	[Token(Token = "0x4004597")]
	[FieldOffset(Offset = "0x198")]
	public CharacterTrait shoesBoots;

	// Token: 0x04004598 RID: 17816
	[Token(Token = "0x4004598")]
	[FieldOffset(Offset = "0x1A0")]
	public CharacterTrait shoesHeels;

	// Token: 0x04004599 RID: 17817
	[Token(Token = "0x4004599")]
	[FieldOffset(Offset = "0x1A8")]
	public CharacterTrait coffeeLiker;

	// Token: 0x0400459A RID: 17818
	[Token(Token = "0x400459A")]
	[FieldOffset(Offset = "0x1B0")]
	public CharacterTrait teaLiker;

	// Token: 0x0400459B RID: 17819
	[Token(Token = "0x400459B")]
	[FieldOffset(Offset = "0x1B8")]
	public List<CharacterTrait> bbCardTraits;

	// Token: 0x0400459C RID: 17820
	[Token(Token = "0x400459C")]
	[FieldOffset(Offset = "0x1C0")]
	public CharacterTrait bald;

	// Token: 0x0400459D RID: 17821
	[Token(Token = "0x400459D")]
	[FieldOffset(Offset = "0x1C8")]
	public CharacterTrait shortHair;

	// Token: 0x0400459E RID: 17822
	[Token(Token = "0x400459E")]
	[FieldOffset(Offset = "0x1D0")]
	public CharacterTrait longHair;

	// Token: 0x0400459F RID: 17823
	[Token(Token = "0x400459F")]
	[FieldOffset(Offset = "0x1D8")]
	public Vector2 shoeSizeRange;

	// Token: 0x040045A0 RID: 17824
	[Token(Token = "0x40045A0")]
	[FieldOffset(Offset = "0x1E0")]
	public List<Vector3> nodeLocalSubdivisions;

	// Token: 0x040045A1 RID: 17825
	[Token(Token = "0x40045A1")]
	[FieldOffset(Offset = "0x1E8")]
	public List<CitizenControls.StartingInventory> citizenStartingInventory;

	// Token: 0x040045A2 RID: 17826
	[Token(Token = "0x40045A2")]
	[FieldOffset(Offset = "0x1F0")]
	public InteractablePreset citizenInteractable;

	// Token: 0x040045A3 RID: 17827
	[Token(Token = "0x40045A3")]
	[FieldOffset(Offset = "0x1F8")]
	public InteractablePreset handInteractable;

	// Token: 0x040045A4 RID: 17828
	[Token(Token = "0x40045A4")]
	[FieldOffset(Offset = "0x200")]
	public AIActionPreset sleep;

	// Token: 0x040045A5 RID: 17829
	[Token(Token = "0x40045A5")]
	[FieldOffset(Offset = "0x208")]
	public MatchPreset matchWithPhoto;

	// Token: 0x040045A6 RID: 17830
	[Token(Token = "0x40045A6")]
	[FieldOffset(Offset = "0x210")]
	public MatchPreset weakVisualSighting;

	// Token: 0x040045A7 RID: 17831
	[Token(Token = "0x40045A7")]
	[FieldOffset(Offset = "0x218")]
	public MatchPreset mediumVisualSighting;

	// Token: 0x040045A8 RID: 17832
	[Token(Token = "0x40045A8")]
	[FieldOffset(Offset = "0x220")]
	public MatchPreset strongVisualSighting;

	// Token: 0x040045A9 RID: 17833
	[Token(Token = "0x40045A9")]
	[FieldOffset(Offset = "0x228")]
	public CharacterTrait randomPassword;

	// Token: 0x040045AA RID: 17834
	[Token(Token = "0x40045AA")]
	[FieldOffset(Offset = "0x230")]
	public InteractablePreset deadBodySearchInteractable;

	// Token: 0x040045AB RID: 17835
	[Token(Token = "0x40045AB")]
	[FieldOffset(Offset = "0x238")]
	public InteractablePreset entryWound;

	// Token: 0x040045AC RID: 17836
	[Token(Token = "0x40045AC")]
	[FieldOffset(Offset = "0x240")]
	public InteractablePreset exitWound;

	// Token: 0x040045AD RID: 17837
	[Token(Token = "0x40045AD")]
	[FieldOffset(Offset = "0x248")]
	public InteractablePreset toothbrush;

	// Token: 0x040045AE RID: 17838
	[Token(Token = "0x40045AE")]
	[FieldOffset(Offset = "0x250")]
	public InteractablePreset addressBook;

	// Token: 0x040045AF RID: 17839
	[Token(Token = "0x40045AF")]
	[FieldOffset(Offset = "0x258")]
	public GameObject umbrella;

	// Token: 0x040045B0 RID: 17840
	[Token(Token = "0x40045B0")]
	[FieldOffset(Offset = "0x260")]
	public SpatterPatternPreset vomitSpatter;

	// Token: 0x040045B1 RID: 17841
	[Token(Token = "0x40045B1")]
	[FieldOffset(Offset = "0x268")]
	public CitizenOutfitController debugSelectCitizen;

	// Token: 0x040045B2 RID: 17842
	[Token(Token = "0x40045B2")]
	[FieldOffset(Offset = "0x0")]
	private static CitizenControls _instance;

	// Token: 0x020008A9 RID: 2217
	[Token(Token = "0x20008A9")]
	[Serializable]
	public class LimbPos
	{
		// Token: 0x06002A18 RID: 10776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A18")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public LimbPos()
		{
		}

		// Token: 0x040045B3 RID: 17843
		[Token(Token = "0x40045B3")]
		[FieldOffset(Offset = "0x10")]
		public CitizenOutfitController.CharacterAnchor anchor;

		// Token: 0x040045B4 RID: 17844
		[Token(Token = "0x40045B4")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 localPosition;

		// Token: 0x040045B5 RID: 17845
		[Token(Token = "0x40045B5")]
		[FieldOffset(Offset = "0x20")]
		public Quaternion localRotation;
	}

	// Token: 0x020008AA RID: 2218
	[Token(Token = "0x20008AA")]
	[Serializable]
	public class ManualAnimation
	{
		// Token: 0x06002A19 RID: 10777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A19")]
		[Address(RVA = "0xCB7370", Offset = "0xCB6370", VA = "0x180CB7370")]
		public ManualAnimation()
		{
		}

		// Token: 0x040045B6 RID: 17846
		[Token(Token = "0x40045B6")]
		[FieldOffset(Offset = "0x10")]
		public float timeline;

		// Token: 0x040045B7 RID: 17847
		[Token(Token = "0x40045B7")]
		[FieldOffset(Offset = "0x18")]
		public List<CitizenControls.LimbPos> limbData;
	}

	// Token: 0x020008AB RID: 2219
	[Token(Token = "0x20008AB")]
	[Serializable]
	public class StartingInventory
	{
		// Token: 0x06002A1A RID: 10778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A1A")]
		[Address(RVA = "0xCB7440", Offset = "0xCB6440", VA = "0x180CB7440")]
		public StartingInventory()
		{
		}

		// Token: 0x040045B8 RID: 17848
		[Token(Token = "0x40045B8")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040045B9 RID: 17849
		[Token(Token = "0x40045B9")]
		[FieldOffset(Offset = "0x18")]
		public List<InteractablePreset> presets;

		// Token: 0x040045BA RID: 17850
		[Token(Token = "0x40045BA")]
		[FieldOffset(Offset = "0x20")]
		public float baseChance;

		// Token: 0x040045BB RID: 17851
		[Token(Token = "0x40045BB")]
		[FieldOffset(Offset = "0x28")]
		public List<MurderPreset.MurdererModifierRule> modifiers;
	}

	// Token: 0x020008AC RID: 2220
	[Token(Token = "0x20008AC")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002A1C RID: 10780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A1C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x0000FB70 File Offset: 0x0000DD70
		[Token(Token = "0x6002A1D")]
		[Address(RVA = "0xCB7660", Offset = "0xCB6660", VA = "0x180CB7660")]
		internal int <DebugCitizensStuck>b__104_0(Citizen p1, Citizen p2)
		{
			return 0;
		}

		// Token: 0x040045BC RID: 17852
		[Token(Token = "0x40045BC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CitizenControls.<>c <>9;

		// Token: 0x040045BD RID: 17853
		[Token(Token = "0x40045BD")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<Citizen> <>9__104_0;
	}
}
