using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A1 RID: 673
[Token(Token = "0x20002A1")]
public class CitizenOutfitController : MonoBehaviour
{
	// Token: 0x06000F67 RID: 3943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F67")]
	[Address(RVA = "0x66E880", Offset = "0x66D880", VA = "0x18066E880")]
	private void Awake()
	{
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F68")]
	[Address(RVA = "0x66EBE0", Offset = "0x66DBE0", VA = "0x18066EBE0")]
	public void GenerateOutfits(bool forceSpecificDebugOutfit = false)
	{
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F69")]
	[Address(RVA = "0x674380", Offset = "0x673380", VA = "0x180674380")]
	public Transform GetBodyAnchor(CitizenOutfitController.CharacterAnchor anchor)
	{
		return null;
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6A")]
	[Address(RVA = "0x6744C0", Offset = "0x6734C0", VA = "0x1806744C0")]
	public void MakeClothed()
	{
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6B")]
	[Address(RVA = "0x674AC0", Offset = "0x673AC0", VA = "0x180674AC0")]
	public void SetCurrentOutfit(ClothesPreset.OutfitCategory category, bool forceLoad = false, bool forceReload = false, bool ignoreIfDead = true)
	{
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6C")]
	[Address(RVA = "0x6751D0", Offset = "0x6741D0", VA = "0x1806751D0")]
	public void LoadCurrentOutfit(bool forceLoad = false, bool forceReload = false)
	{
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6D")]
	[Address(RVA = "0x676D80", Offset = "0x675D80", VA = "0x180676D80")]
	private void SpawnClothingElement(CitizenOutfitController.OutfitClothes cl, ClothesPreset cp)
	{
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6E")]
	[Address(RVA = "0x678790", Offset = "0x677790", VA = "0x180678790")]
	private void AddMeshRenderer(MeshRenderer rend, ref Material applyMat, bool isLOD, ref CitizenOutfitController.OutfitClothes clothesOutfit, ClothesPreset.ModelSettings model)
	{
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6F")]
	[Address(RVA = "0x679010", Offset = "0x678010", VA = "0x180679010")]
	private void RemoveSpecificModel(CitizenOutfitController.OutfitClothes cl, CitizenOutfitController.CharacterAnchor a)
	{
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F70")]
	[Address(RVA = "0x6794D0", Offset = "0x6784D0", VA = "0x1806794D0")]
	public void HairHatCompatibilityCheck()
	{
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F71")]
	[Address(RVA = "0x679870", Offset = "0x678870", VA = "0x180679870")]
	private void RemoveClothingComponent(CitizenOutfitController.OutfitClothes cl)
	{
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F72")]
	[Address(RVA = "0x679FA0", Offset = "0x678FA0", VA = "0x180679FA0")]
	private void RemoveDebugRenderers()
	{
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F73")]
	[Address(RVA = "0x67A140", Offset = "0x679140", VA = "0x18067A140")]
	public void RemoveCurrentOutfit()
	{
	}

	// Token: 0x06000F74 RID: 3956 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F74")]
	[Address(RVA = "0x67AB50", Offset = "0x679B50", VA = "0x18067AB50")]
	public void LoadSpecificOutfit()
	{
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F75")]
	[Address(RVA = "0x67AB80", Offset = "0x679B80", VA = "0x18067AB80")]
	public void SelectRandomOutfits()
	{
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F76")]
	[Address(RVA = "0x67ABB0", Offset = "0x679BB0", VA = "0x18067ABB0")]
	public void CycleOutfits()
	{
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F77")]
	[Address(RVA = "0x67AFA0", Offset = "0x679FA0", VA = "0x18067AFA0")]
	public void ResetAllOutfits()
	{
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F78")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CreateNewClothingPreset()
	{
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F79")]
	[Address(RVA = "0x67B070", Offset = "0x67A070", VA = "0x18067B070")]
	public void LoadExpression()
	{
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F7A")]
	public T SafeDestroyGameObject<T>(T component) where T : Component
	{
		return null;
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F7B")]
	public T SafeDestroy<T>(T obj) where T : UnityEngine.Object
	{
		return null;
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x000080A0 File Offset: 0x000062A0
	[Token(Token = "0x6000F7C")]
	[Address(RVA = "0x67B3A0", Offset = "0x67A3A0", VA = "0x18067B3A0")]
	private Color PickColourFromPalette(ref List<ColourPalettePreset> palettes, string debug = "")
	{
		return default(Color);
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x000080B8 File Offset: 0x000062B8
	[Token(Token = "0x6000F7D")]
	[Address(RVA = "0x67B940", Offset = "0x67A940", VA = "0x18067B940")]
	private Color GetColourFromUnderneath(ClothesPreset thisPreset, ClothesPreset.OutfitCategory category, ClothesPreset.ClothingColourSource source, ref Dictionary<string, ClothesPreset> clothesDictionary)
	{
		return default(Color);
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x000080D0 File Offset: 0x000062D0
	[Token(Token = "0x6000F7E")]
	[Address(RVA = "0x67BE70", Offset = "0x67AE70", VA = "0x18067BE70")]
	public bool GetChance(Human human, ref List<ClothesPreset.TraitPickRule> pickRules, out int addChance)
	{
		return default(bool);
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F7F")]
	[Address(RVA = "0x67C850", Offset = "0x67B850", VA = "0x18067C850")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000F80 RID: 3968 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F80")]
	[Address(RVA = "0x67C980", Offset = "0x67B980", VA = "0x18067C980")]
	public CitizenOutfitController()
	{
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x000080E8 File Offset: 0x000062E8
	[Token(Token = "0x6000F81")]
	[Address(RVA = "0x67D390", Offset = "0x67C390", VA = "0x18067D390")]
	private bool <LoadCurrentOutfit>b__71_0(CitizenOutfitController.Outfit item)
	{
		return default(bool);
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x00008100 File Offset: 0x00006300
	[Token(Token = "0x6000F82")]
	[Address(RVA = "0x67D3B0", Offset = "0x67C3B0", VA = "0x18067D3B0")]
	private bool <LoadExpression>b__84_0(CitizenOutfitController.ExpressionSetup item)
	{
		return default(bool);
	}

	// Token: 0x04001227 RID: 4647
	[Token(Token = "0x4001227")]
	[FieldOffset(Offset = "0x18")]
	public Human human;

	// Token: 0x04001228 RID: 4648
	[Token(Token = "0x4001228")]
	[FieldOffset(Offset = "0x20")]
	public LODGroup lod;

	// Token: 0x04001229 RID: 4649
	[Token(Token = "0x4001229")]
	[FieldOffset(Offset = "0x28")]
	public MeshRenderer distantLOD;

	// Token: 0x0400122A RID: 4650
	[Token(Token = "0x400122A")]
	[FieldOffset(Offset = "0x30")]
	public bool isPoser;

	// Token: 0x0400122B RID: 4651
	[Token(Token = "0x400122B")]
	[FieldOffset(Offset = "0x38")]
	public ScenePoserController poser;

	// Token: 0x0400122C RID: 4652
	[Token(Token = "0x400122C")]
	[FieldOffset(Offset = "0x40")]
	public List<CitizenOutfitController.AnchorConfig> anchorConfig;

	// Token: 0x0400122D RID: 4653
	[Token(Token = "0x400122D")]
	[FieldOffset(Offset = "0x48")]
	public Dictionary<CitizenOutfitController.CharacterAnchor, Transform> anchorReference;

	// Token: 0x0400122E RID: 4654
	[Token(Token = "0x400122E")]
	[FieldOffset(Offset = "0x50")]
	public Transform pupilParent;

	// Token: 0x0400122F RID: 4655
	[Token(Token = "0x400122F")]
	[FieldOffset(Offset = "0x58")]
	public Transform leftPupil;

	// Token: 0x04001230 RID: 4656
	[Token(Token = "0x4001230")]
	[FieldOffset(Offset = "0x60")]
	public Transform rightPupil;

	// Token: 0x04001231 RID: 4657
	[Token(Token = "0x4001231")]
	[FieldOffset(Offset = "0x68")]
	public Transform eyebrowParent;

	// Token: 0x04001232 RID: 4658
	[Token(Token = "0x4001232")]
	[FieldOffset(Offset = "0x70")]
	public Transform rightEyebrow;

	// Token: 0x04001233 RID: 4659
	[Token(Token = "0x4001233")]
	[FieldOffset(Offset = "0x78")]
	public Transform leftEyebrow;

	// Token: 0x04001234 RID: 4660
	[Token(Token = "0x4001234")]
	[FieldOffset(Offset = "0x80")]
	public Transform mouth;

	// Token: 0x04001235 RID: 4661
	[Token(Token = "0x4001235")]
	[FieldOffset(Offset = "0x88")]
	public List<MeshRenderer> eyeRenderers;

	// Token: 0x04001236 RID: 4662
	[Token(Token = "0x4001236")]
	[FieldOffset(Offset = "0x90")]
	public List<MeshRenderer> eyebrowRenderers;

	// Token: 0x04001237 RID: 4663
	[Token(Token = "0x4001237")]
	[FieldOffset(Offset = "0x98")]
	public MeshRenderer mouthRenderer;

	// Token: 0x04001238 RID: 4664
	[Token(Token = "0x4001238")]
	[FieldOffset(Offset = "0xA0")]
	public Vector3 pupilParentOffset;

	// Token: 0x04001239 RID: 4665
	[Token(Token = "0x4001239")]
	[FieldOffset(Offset = "0xB0")]
	public List<CitizenOutfitController.ExpressionSetup> expressions;

	// Token: 0x0400123A RID: 4666
	[Token(Token = "0x400123A")]
	[FieldOffset(Offset = "0xB8")]
	public Dictionary<CitizenOutfitController.Expression, CitizenOutfitController.ExpressionSetup> expressionReference;

	// Token: 0x0400123B RID: 4667
	[Token(Token = "0x400123B")]
	[FieldOffset(Offset = "0xC0")]
	public Material bluePupil;

	// Token: 0x0400123C RID: 4668
	[Token(Token = "0x400123C")]
	[FieldOffset(Offset = "0xC8")]
	public Material greenPupil;

	// Token: 0x0400123D RID: 4669
	[Token(Token = "0x400123D")]
	[FieldOffset(Offset = "0xD0")]
	public Material brownPupil;

	// Token: 0x0400123E RID: 4670
	[Token(Token = "0x400123E")]
	[FieldOffset(Offset = "0xD8")]
	public Material greyPupil;

	// Token: 0x0400123F RID: 4671
	[Token(Token = "0x400123F")]
	[FieldOffset(Offset = "0xE0")]
	private Material eyebrowMat;

	// Token: 0x04001240 RID: 4672
	[Token(Token = "0x4001240")]
	[FieldOffset(Offset = "0xE8")]
	public ClothesPreset.OutfitCategory loadedOutfit;

	// Token: 0x04001241 RID: 4673
	[Token(Token = "0x4001241")]
	[FieldOffset(Offset = "0xEC")]
	public ClothesPreset.OutfitCategory currentOutfit;

	// Token: 0x04001242 RID: 4674
	[Token(Token = "0x4001242")]
	[FieldOffset(Offset = "0xF0")]
	public ClothesPreset.OutfitCategory previousOutfit;

	// Token: 0x04001243 RID: 4675
	[Token(Token = "0x4001243")]
	[FieldOffset(Offset = "0xF8")]
	[NonSerialized]
	public List<CitizenOutfitController.OutfitClothes> currentlyLoadedClothes;

	// Token: 0x04001244 RID: 4676
	[Token(Token = "0x4001244")]
	[FieldOffset(Offset = "0x100")]
	public List<MeshRenderer> allCurrentMeshes;

	// Token: 0x04001245 RID: 4677
	[Token(Token = "0x4001245")]
	[FieldOffset(Offset = "0x108")]
	public List<MeshFilter> allCurrentMeshFilters;

	// Token: 0x04001246 RID: 4678
	[Token(Token = "0x4001246")]
	[FieldOffset(Offset = "0x110")]
	private ClothesPreset currentHair;

	// Token: 0x04001247 RID: 4679
	[Token(Token = "0x4001247")]
	[FieldOffset(Offset = "0x118")]
	private MeshRenderer currentHairRend;

	// Token: 0x04001248 RID: 4680
	[Token(Token = "0x4001248")]
	[FieldOffset(Offset = "0x120")]
	private ClothesPreset currentHat;

	// Token: 0x04001249 RID: 4681
	[Token(Token = "0x4001249")]
	[FieldOffset(Offset = "0x128")]
	private MeshRenderer currentHatRend;

	// Token: 0x0400124A RID: 4682
	[Token(Token = "0x400124A")]
	[FieldOffset(Offset = "0x130")]
	public List<CitizenOutfitController.Outfit> outfits;

	// Token: 0x0400124B RID: 4683
	[Token(Token = "0x400124B")]
	[FieldOffset(Offset = "0x138")]
	public List<MeshRenderer> debugRenderers;

	// Token: 0x0400124C RID: 4684
	[Token(Token = "0x400124C")]
	[FieldOffset(Offset = "0x140")]
	public bool debugOverride;

	// Token: 0x0400124D RID: 4685
	[Token(Token = "0x400124D")]
	[FieldOffset(Offset = "0x148")]
	public OccupationPreset debugOverrideJob;

	// Token: 0x0400124E RID: 4686
	[Token(Token = "0x400124E")]
	[FieldOffset(Offset = "0x150")]
	public Human.Gender debugOverrideGender;

	// Token: 0x0400124F RID: 4687
	[Token(Token = "0x400124F")]
	[FieldOffset(Offset = "0x154")]
	public Descriptors.BuildType debugOverrideBuild;

	// Token: 0x04001250 RID: 4688
	[Token(Token = "0x4001250")]
	[FieldOffset(Offset = "0x158")]
	public Descriptors.HairStyle debugOverrideHair;

	// Token: 0x04001251 RID: 4689
	[Token(Token = "0x4001251")]
	[FieldOffset(Offset = "0x15C")]
	public Descriptors.EyeColour debugOverrideEyeColour;

	// Token: 0x04001252 RID: 4690
	[Token(Token = "0x4001252")]
	[FieldOffset(Offset = "0x160")]
	public Human.ShoeType debugOverrideShoeType;

	// Token: 0x04001253 RID: 4691
	[Token(Token = "0x4001253")]
	[FieldOffset(Offset = "0x164")]
	public float debugOverrideLipstick;

	// Token: 0x04001254 RID: 4692
	[Token(Token = "0x4001254")]
	[FieldOffset(Offset = "0x168")]
	public Color debugOverrideSkinColour;

	// Token: 0x04001255 RID: 4693
	[Token(Token = "0x4001255")]
	[FieldOffset(Offset = "0x178")]
	public Color debugOverrideHairColour;

	// Token: 0x04001256 RID: 4694
	[Token(Token = "0x4001256")]
	[FieldOffset(Offset = "0x188")]
	public CitizenOutfitController.Expression debugOverrideExpression;

	// Token: 0x04001257 RID: 4695
	[Token(Token = "0x4001257")]
	[FieldOffset(Offset = "0x18C")]
	public float debugOverrideGrub;

	// Token: 0x04001258 RID: 4696
	[Token(Token = "0x4001258")]
	[FieldOffset(Offset = "0x190")]
	public bool enableDebugLog;

	// Token: 0x04001259 RID: 4697
	[Token(Token = "0x4001259")]
	[FieldOffset(Offset = "0x198")]
	public List<string> outfitDebug;

	// Token: 0x0400125A RID: 4698
	[Token(Token = "0x400125A")]
	[FieldOffset(Offset = "0x1A0")]
	public List<ClothesPreset> outfitToLoad;

	// Token: 0x0400125B RID: 4699
	[Token(Token = "0x400125B")]
	[FieldOffset(Offset = "0x1A8")]
	public string newClothingName;

	// Token: 0x0400125C RID: 4700
	[Token(Token = "0x400125C")]
	[FieldOffset(Offset = "0x1B0")]
	public CitizenOutfitController.ClothingCreatorDirectory directory;

	// Token: 0x0400125D RID: 4701
	[Token(Token = "0x400125D")]
	[FieldOffset(Offset = "0x1B8")]
	public List<GameObject> newClothingComponents;

	// Token: 0x0400125E RID: 4702
	[Token(Token = "0x400125E")]
	[FieldOffset(Offset = "0x1C0")]
	public bool CreateFlippedArmsAndLegsFromRightSide;

	// Token: 0x0400125F RID: 4703
	[Token(Token = "0x400125F")]
	[FieldOffset(Offset = "0x1C8")]
	private Dictionary<CitizenOutfitController.CharacterAnchor, int> coveredAnchors;

	// Token: 0x020002A2 RID: 674
	[Token(Token = "0x20002A2")]
	public enum CharacterAnchor
	{
		// Token: 0x04001261 RID: 4705
		[Token(Token = "0x4001261")]
		lowerTorso,
		// Token: 0x04001262 RID: 4706
		[Token(Token = "0x4001262")]
		upperTorso,
		// Token: 0x04001263 RID: 4707
		[Token(Token = "0x4001263")]
		Head,
		// Token: 0x04001264 RID: 4708
		[Token(Token = "0x4001264")]
		Hat,
		// Token: 0x04001265 RID: 4709
		[Token(Token = "0x4001265")]
		UpperArmRight,
		// Token: 0x04001266 RID: 4710
		[Token(Token = "0x4001266")]
		UpperArmLeft,
		// Token: 0x04001267 RID: 4711
		[Token(Token = "0x4001267")]
		LowerArmRight,
		// Token: 0x04001268 RID: 4712
		[Token(Token = "0x4001268")]
		LowerArmLeft,
		// Token: 0x04001269 RID: 4713
		[Token(Token = "0x4001269")]
		HandRight,
		// Token: 0x0400126A RID: 4714
		[Token(Token = "0x400126A")]
		HandLeft,
		// Token: 0x0400126B RID: 4715
		[Token(Token = "0x400126B")]
		UpperLegRight,
		// Token: 0x0400126C RID: 4716
		[Token(Token = "0x400126C")]
		UpperLegLeft,
		// Token: 0x0400126D RID: 4717
		[Token(Token = "0x400126D")]
		LowerLegRight,
		// Token: 0x0400126E RID: 4718
		[Token(Token = "0x400126E")]
		LowerLegLeft,
		// Token: 0x0400126F RID: 4719
		[Token(Token = "0x400126F")]
		Midriff,
		// Token: 0x04001270 RID: 4720
		[Token(Token = "0x4001270")]
		RightFoot,
		// Token: 0x04001271 RID: 4721
		[Token(Token = "0x4001271")]
		LeftFoot,
		// Token: 0x04001272 RID: 4722
		[Token(Token = "0x4001272")]
		Hair,
		// Token: 0x04001273 RID: 4723
		[Token(Token = "0x4001273")]
		Glasses,
		// Token: 0x04001274 RID: 4724
		[Token(Token = "0x4001274")]
		ArmsParent,
		// Token: 0x04001275 RID: 4725
		[Token(Token = "0x4001275")]
		beard
	}

	// Token: 0x020002A3 RID: 675
	[Token(Token = "0x20002A3")]
	[Serializable]
	public class AnchorConfig
	{
		// Token: 0x06000F83 RID: 3971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x67D410", Offset = "0x67C410", VA = "0x18067D410")]
		public AnchorConfig()
		{
		}

		// Token: 0x04001276 RID: 4726
		[Token(Token = "0x4001276")]
		[FieldOffset(Offset = "0x10")]
		public CitizenOutfitController.CharacterAnchor anchor;

		// Token: 0x04001277 RID: 4727
		[Token(Token = "0x4001277")]
		[FieldOffset(Offset = "0x18")]
		public Transform trans;

		// Token: 0x04001278 RID: 4728
		[Token(Token = "0x4001278")]
		[FieldOffset(Offset = "0x20")]
		public bool outline;

		// Token: 0x04001279 RID: 4729
		[Token(Token = "0x4001279")]
		[FieldOffset(Offset = "0x21")]
		public bool captureInSurveillance;

		// Token: 0x0400127A RID: 4730
		[Token(Token = "0x400127A")]
		[FieldOffset(Offset = "0x24")]
		public float weight;
	}

	// Token: 0x020002A4 RID: 676
	[Token(Token = "0x20002A4")]
	[Serializable]
	public class Outfit
	{
		// Token: 0x06000F84 RID: 3972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F84")]
		[Address(RVA = "0x67D420", Offset = "0x67C420", VA = "0x18067D420")]
		public Outfit()
		{
		}

		// Token: 0x0400127B RID: 4731
		[Token(Token = "0x400127B")]
		[FieldOffset(Offset = "0x10")]
		public ClothesPreset.OutfitCategory category;

		// Token: 0x0400127C RID: 4732
		[Token(Token = "0x400127C")]
		[FieldOffset(Offset = "0x18")]
		public List<CitizenOutfitController.OutfitClothes> clothes;
	}

	// Token: 0x020002A5 RID: 677
	[Token(Token = "0x20002A5")]
	[Serializable]
	public class OutfitClothes
	{
		// Token: 0x06000F85 RID: 3973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F85")]
		[Address(RVA = "0x67D4F0", Offset = "0x67C4F0", VA = "0x18067D4F0")]
		public OutfitClothes()
		{
		}

		// Token: 0x0400127D RID: 4733
		[Token(Token = "0x400127D")]
		[FieldOffset(Offset = "0x10")]
		public string clothes;

		// Token: 0x0400127E RID: 4734
		[Token(Token = "0x400127E")]
		[FieldOffset(Offset = "0x18")]
		public List<ClothesPreset.ClothesTags> tags;

		// Token: 0x0400127F RID: 4735
		[Token(Token = "0x400127F")]
		[FieldOffset(Offset = "0x20")]
		public Color baseColor;

		// Token: 0x04001280 RID: 4736
		[Token(Token = "0x4001280")]
		[FieldOffset(Offset = "0x30")]
		public Color color1;

		// Token: 0x04001281 RID: 4737
		[Token(Token = "0x4001281")]
		[FieldOffset(Offset = "0x40")]
		public Color color2;

		// Token: 0x04001282 RID: 4738
		[Token(Token = "0x4001282")]
		[FieldOffset(Offset = "0x50")]
		public Color color3;

		// Token: 0x04001283 RID: 4739
		[Token(Token = "0x4001283")]
		[FieldOffset(Offset = "0x60")]
		public bool borrowed;

		// Token: 0x04001284 RID: 4740
		[Token(Token = "0x4001284")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Dictionary<CitizenOutfitController.CharacterAnchor, List<MeshRenderer>> spawned;

		// Token: 0x04001285 RID: 4741
		[Token(Token = "0x4001285")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public int rank;

		// Token: 0x04001286 RID: 4742
		[Token(Token = "0x4001286")]
		[FieldOffset(Offset = "0x74")]
		[NonSerialized]
		public bool incomplete;

		// Token: 0x04001287 RID: 4743
		[Token(Token = "0x4001287")]
		[FieldOffset(Offset = "0x75")]
		[NonSerialized]
		public bool loadedThisCycle;
	}

	// Token: 0x020002A6 RID: 678
	[Token(Token = "0x20002A6")]
	public struct BackupCovering
	{
		// Token: 0x04001288 RID: 4744
		[Token(Token = "0x4001288")]
		[FieldOffset(Offset = "0x0")]
		public CitizenOutfitController.Outfit outfit;

		// Token: 0x04001289 RID: 4745
		[Token(Token = "0x4001289")]
		[FieldOffset(Offset = "0x8")]
		public ClothesPreset preset;
	}

	// Token: 0x020002A7 RID: 679
	[Token(Token = "0x20002A7")]
	public class NewClothingCreation
	{
		// Token: 0x06000F86 RID: 3974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F86")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public NewClothingCreation()
		{
		}

		// Token: 0x0400128A RID: 4746
		[Token(Token = "0x400128A")]
		[FieldOffset(Offset = "0x10")]
		public GameObject newPrefab;

		// Token: 0x0400128B RID: 4747
		[Token(Token = "0x400128B")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 offset;

		// Token: 0x0400128C RID: 4748
		[Token(Token = "0x400128C")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 euler;
	}

	// Token: 0x020002A8 RID: 680
	[Token(Token = "0x20002A8")]
	public enum ClothingCreatorDirectory
	{
		// Token: 0x0400128E RID: 4750
		[Token(Token = "0x400128E")]
		Tops,
		// Token: 0x0400128F RID: 4751
		[Token(Token = "0x400128F")]
		Bottoms,
		// Token: 0x04001290 RID: 4752
		[Token(Token = "0x4001290")]
		Hats,
		// Token: 0x04001291 RID: 4753
		[Token(Token = "0x4001291")]
		Heads,
		// Token: 0x04001292 RID: 4754
		[Token(Token = "0x4001292")]
		Shoes,
		// Token: 0x04001293 RID: 4755
		[Token(Token = "0x4001293")]
		Underwear,
		// Token: 0x04001294 RID: 4756
		[Token(Token = "0x4001294")]
		Undressed
	}

	// Token: 0x020002A9 RID: 681
	[Token(Token = "0x20002A9")]
	public enum Expression
	{
		// Token: 0x04001296 RID: 4758
		[Token(Token = "0x4001296")]
		neutral,
		// Token: 0x04001297 RID: 4759
		[Token(Token = "0x4001297")]
		angry,
		// Token: 0x04001298 RID: 4760
		[Token(Token = "0x4001298")]
		sad,
		// Token: 0x04001299 RID: 4761
		[Token(Token = "0x4001299")]
		surprised,
		// Token: 0x0400129A RID: 4762
		[Token(Token = "0x400129A")]
		happy,
		// Token: 0x0400129B RID: 4763
		[Token(Token = "0x400129B")]
		asleep
	}

	// Token: 0x020002AA RID: 682
	[Token(Token = "0x20002AA")]
	[Serializable]
	public class ExpressionSetup
	{
		// Token: 0x06000F87 RID: 3975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F87")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ExpressionSetup()
		{
		}

		// Token: 0x0400129C RID: 4764
		[Token(Token = "0x400129C")]
		[FieldOffset(Offset = "0x10")]
		public CitizenOutfitController.Expression expression;

		// Token: 0x0400129D RID: 4765
		[Token(Token = "0x400129D")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 eyebrowsEuler;

		// Token: 0x0400129E RID: 4766
		[Token(Token = "0x400129E")]
		[FieldOffset(Offset = "0x20")]
		public float eyebrowsRaise;

		// Token: 0x0400129F RID: 4767
		[Token(Token = "0x400129F")]
		[FieldOffset(Offset = "0x24")]
		public float eyeHeightMultiplier;

		// Token: 0x040012A0 RID: 4768
		[Token(Token = "0x40012A0")]
		[FieldOffset(Offset = "0x28")]
		public bool allowBlinking;
	}

	// Token: 0x020002AB RID: 683
	[Token(Token = "0x20002AB")]
	private sealed class <>c__DisplayClass67_0
	{
		// Token: 0x06000F88 RID: 3976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F88")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass67_0()
		{
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00008118 File Offset: 0x00006318
		[Token(Token = "0x6000F89")]
		[Address(RVA = "0x67D6A0", Offset = "0x67C6A0", VA = "0x18067D6A0")]
		internal bool <GenerateOutfits>b__1(ClothesPreset item)
		{
			return default(bool);
		}

		// Token: 0x040012A1 RID: 4769
		[Token(Token = "0x40012A1")]
		[FieldOffset(Offset = "0x10")]
		public CitizenOutfitController.CharacterAnchor req;
	}

	// Token: 0x020002AC RID: 684
	[Token(Token = "0x20002AC")]
	private sealed class <>c__DisplayClass67_1
	{
		// Token: 0x06000F8A RID: 3978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass67_1()
		{
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00008130 File Offset: 0x00006330
		[Token(Token = "0x6000F8B")]
		[Address(RVA = "0x67D730", Offset = "0x67C730", VA = "0x18067D730")]
		internal bool <GenerateOutfits>b__2(CitizenOutfitController.OutfitClothes item)
		{
			return default(bool);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00008148 File Offset: 0x00006348
		[Token(Token = "0x6000F8C")]
		[Address(RVA = "0x67D730", Offset = "0x67C730", VA = "0x18067D730")]
		internal bool <GenerateOutfits>b__4(CitizenOutfitController.OutfitClothes item)
		{
			return default(bool);
		}

		// Token: 0x040012A2 RID: 4770
		[Token(Token = "0x40012A2")]
		[FieldOffset(Offset = "0x10")]
		public ClothesPreset.IncompatibilitySetting inc;

		// Token: 0x040012A3 RID: 4771
		[Token(Token = "0x40012A3")]
		[FieldOffset(Offset = "0x18")]
		public Predicate<CitizenOutfitController.OutfitClothes> <>9__4;
	}

	// Token: 0x020002AD RID: 685
	[Token(Token = "0x20002AD")]
	private sealed class <>c__DisplayClass67_2
	{
		// Token: 0x06000F8D RID: 3981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass67_2()
		{
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00008160 File Offset: 0x00006360
		[Token(Token = "0x6000F8E")]
		[Address(RVA = "0x67D7B0", Offset = "0x67C7B0", VA = "0x18067D7B0")]
		internal bool <GenerateOutfits>b__3(CitizenOutfitController.OutfitClothes item)
		{
			return default(bool);
		}

		// Token: 0x040012A4 RID: 4772
		[Token(Token = "0x40012A4")]
		[FieldOffset(Offset = "0x10")]
		public ClothesPreset.ClothesTags t;
	}

	// Token: 0x020002AE RID: 686
	[Token(Token = "0x20002AE")]
	private sealed class <>c__DisplayClass67_3
	{
		// Token: 0x06000F8F RID: 3983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass67_3()
		{
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00008178 File Offset: 0x00006378
		[Token(Token = "0x6000F90")]
		[Address(RVA = "0x67D840", Offset = "0x67C840", VA = "0x18067D840")]
		internal bool <GenerateOutfits>b__5(CitizenOutfitController.OutfitClothes item)
		{
			return default(bool);
		}

		// Token: 0x040012A5 RID: 4773
		[Token(Token = "0x40012A5")]
		[FieldOffset(Offset = "0x10")]
		public ClothesPreset.ClothesTags t;
	}

	// Token: 0x020002AF RID: 687
	[Token(Token = "0x20002AF")]
	private sealed class <>c__DisplayClass67_4
	{
		// Token: 0x06000F91 RID: 3985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F91")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass67_4()
		{
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00008190 File Offset: 0x00006390
		[Token(Token = "0x6000F92")]
		[Address(RVA = "0x67D8D0", Offset = "0x67C8D0", VA = "0x18067D8D0")]
		internal bool <GenerateOutfits>b__6(CitizenOutfitController.Outfit item)
		{
			return default(bool);
		}

		// Token: 0x040012A6 RID: 4774
		[Token(Token = "0x40012A6")]
		[FieldOffset(Offset = "0x10")]
		public KeyValuePair<ClothesPreset.OutfitCategory, List<CitizenOutfitController.CharacterAnchor>> pair;
	}

	// Token: 0x020002B0 RID: 688
	[Token(Token = "0x20002B0")]
	private sealed class <>c__DisplayClass67_5
	{
		// Token: 0x06000F93 RID: 3987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F93")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass67_5()
		{
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x000081A8 File Offset: 0x000063A8
		[Token(Token = "0x6000F94")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <GenerateOutfits>b__7(CitizenOutfitController.Outfit item)
		{
			return default(bool);
		}

		// Token: 0x040012A7 RID: 4775
		[Token(Token = "0x40012A7")]
		[FieldOffset(Offset = "0x10")]
		public ClothesPreset.OutfitCategory backupCat;
	}

	// Token: 0x020002B1 RID: 689
	[Token(Token = "0x20002B1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000F96 RID: 3990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F96")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x000081C0 File Offset: 0x000063C0
		[Token(Token = "0x6000F97")]
		[Address(RVA = "0x67D9D0", Offset = "0x67C9D0", VA = "0x18067D9D0")]
		internal int <GenerateOutfits>b__67_0(CitizenOutfitController.OutfitClothes p2, CitizenOutfitController.OutfitClothes p1)
		{
			return 0;
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x000081D8 File Offset: 0x000063D8
		[Token(Token = "0x6000F98")]
		[Address(RVA = "0x67D9D0", Offset = "0x67C9D0", VA = "0x18067D9D0")]
		internal int <GenerateOutfits>b__67_8(CitizenOutfitController.OutfitClothes p2, CitizenOutfitController.OutfitClothes p1)
		{
			return 0;
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x000081F0 File Offset: 0x000063F0
		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x67DA10", Offset = "0x67CA10", VA = "0x18067DA10")]
		internal bool <RemoveCurrentOutfit>b__78_0(MeshRenderer item)
		{
			return default(bool);
		}

		// Token: 0x040012A8 RID: 4776
		[Token(Token = "0x40012A8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CitizenOutfitController.<>c <>9;

		// Token: 0x040012A9 RID: 4777
		[Token(Token = "0x40012A9")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<CitizenOutfitController.OutfitClothes> <>9__67_0;

		// Token: 0x040012AA RID: 4778
		[Token(Token = "0x40012AA")]
		[FieldOffset(Offset = "0x10")]
		public static Comparison<CitizenOutfitController.OutfitClothes> <>9__67_8;

		// Token: 0x040012AB RID: 4779
		[Token(Token = "0x40012AB")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<MeshRenderer> <>9__78_0;
	}

	// Token: 0x020002B2 RID: 690
	[Token(Token = "0x20002B2")]
	private sealed class <>c__DisplayClass71_0
	{
		// Token: 0x06000F9A RID: 3994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass71_0()
		{
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00008208 File Offset: 0x00006408
		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0x67DAB0", Offset = "0x67CAB0", VA = "0x18067DAB0")]
		internal bool <LoadCurrentOutfit>b__1(CitizenOutfitController.OutfitClothes item)
		{
			return default(bool);
		}

		// Token: 0x040012AC RID: 4780
		[Token(Token = "0x40012AC")]
		[FieldOffset(Offset = "0x10")]
		public CitizenOutfitController.OutfitClothes req;
	}

	// Token: 0x020002B3 RID: 691
	[Token(Token = "0x20002B3")]
	private sealed class <>c__DisplayClass88_0
	{
		// Token: 0x06000F9C RID: 3996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass88_0()
		{
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00008220 File Offset: 0x00006420
		[Token(Token = "0x6000F9D")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <GetColourFromUnderneath>b__0(CitizenOutfitController.Outfit item)
		{
			return default(bool);
		}

		// Token: 0x040012AD RID: 4781
		[Token(Token = "0x40012AD")]
		[FieldOffset(Offset = "0x10")]
		public ClothesPreset.OutfitCategory lookInCategory;
	}

	// Token: 0x020002B4 RID: 692
	[Token(Token = "0x20002B4")]
	private sealed class <>c__DisplayClass89_0
	{
		// Token: 0x06000F9E RID: 3998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass89_0()
		{
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00008238 File Offset: 0x00006438
		[Token(Token = "0x6000F9F")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GetChance>b__0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040012AE RID: 4782
		[Token(Token = "0x40012AE")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x020002B5 RID: 693
	[Token(Token = "0x20002B5")]
	private sealed class <>c__DisplayClass89_1
	{
		// Token: 0x06000FA0 RID: 4000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FA0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass89_1()
		{
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00008250 File Offset: 0x00006450
		[Token(Token = "0x6000FA1")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GetChance>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040012AF RID: 4783
		[Token(Token = "0x40012AF")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x020002B6 RID: 694
	[Token(Token = "0x20002B6")]
	private sealed class <>c__DisplayClass89_2
	{
		// Token: 0x06000FA2 RID: 4002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FA2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass89_2()
		{
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00008268 File Offset: 0x00006468
		[Token(Token = "0x6000FA3")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GetChance>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040012B0 RID: 4784
		[Token(Token = "0x40012B0")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x020002B7 RID: 695
	[Token(Token = "0x20002B7")]
	private sealed class <>c__DisplayClass89_3
	{
		// Token: 0x06000FA4 RID: 4004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FA4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass89_3()
		{
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00008280 File Offset: 0x00006480
		[Token(Token = "0x6000FA5")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GetChance>b__3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040012B1 RID: 4785
		[Token(Token = "0x40012B1")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}
}
