using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x020008AD RID: 2221
[Token(Token = "0x20008AD")]
public class CityControls : MonoBehaviour
{
	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06002A1E RID: 10782 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700014D")]
	public static CityControls Instance
	{
		[Token(Token = "0x6002A1E")]
		[Address(RVA = "0xCB76F0", Offset = "0xCB66F0", VA = "0x180CB76F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002A1F RID: 10783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A1F")]
	[Address(RVA = "0xCB7730", Offset = "0xCB6730", VA = "0x180CB7730")]
	private void Awake()
	{
	}

	// Token: 0x06002A20 RID: 10784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A20")]
	[Address(RVA = "0xCB7AF0", Offset = "0xCB6AF0", VA = "0x180CB7AF0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002A21 RID: 10785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A21")]
	[Address(RVA = "0xCB8070", Offset = "0xCB7070", VA = "0x180CB8070")]
	public CityControls()
	{
	}

	// Token: 0x040045BE RID: 17854
	[Token(Token = "0x40045BE")]
	[FieldOffset(Offset = "0x18")]
	public string wardName;

	// Token: 0x040045BF RID: 17855
	[Token(Token = "0x40045BF")]
	[FieldOffset(Offset = "0x20")]
	public string cityCustoms;

	// Token: 0x040045C0 RID: 17856
	[Token(Token = "0x40045C0")]
	[FieldOffset(Offset = "0x28")]
	public string cityCustomsAbr;

	// Token: 0x040045C1 RID: 17857
	[Token(Token = "0x40045C1")]
	[FieldOffset(Offset = "0x30")]
	public string cityTax;

	// Token: 0x040045C2 RID: 17858
	[Token(Token = "0x40045C2")]
	[FieldOffset(Offset = "0x38")]
	public string cityTaxAbr;

	// Token: 0x040045C3 RID: 17859
	[Token(Token = "0x40045C3")]
	[FieldOffset(Offset = "0x40")]
	public string cityCurrency;

	// Token: 0x040045C4 RID: 17860
	[Token(Token = "0x40045C4")]
	[FieldOffset(Offset = "0x48")]
	public List<CityControls.CitySize> citySizes;

	// Token: 0x040045C5 RID: 17861
	[Token(Token = "0x40045C5")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 cityTileSize;

	// Token: 0x040045C6 RID: 17862
	[Token(Token = "0x40045C6")]
	[FieldOffset(Offset = "0x5C")]
	public int tileMultiplier;

	// Token: 0x040045C7 RID: 17863
	[Token(Token = "0x40045C7")]
	[FieldOffset(Offset = "0x60")]
	public int nodeMultiplier;

	// Token: 0x040045C8 RID: 17864
	[Token(Token = "0x40045C8")]
	[FieldOffset(Offset = "0x64")]
	public int maxBlockSize;

	// Token: 0x040045C9 RID: 17865
	[Token(Token = "0x40045C9")]
	[FieldOffset(Offset = "0x68")]
	public float blockExpandChance;

	// Token: 0x040045CA RID: 17866
	[Token(Token = "0x40045CA")]
	[FieldOffset(Offset = "0x6C")]
	public float blockExpandCentreMultiplier;

	// Token: 0x040045CB RID: 17867
	[Token(Token = "0x40045CB")]
	[FieldOffset(Offset = "0x70")]
	public float nonFavouredExpandMultiplier;

	// Token: 0x040045CC RID: 17868
	[Token(Token = "0x40045CC")]
	[FieldOffset(Offset = "0x74")]
	public int districtSizeMin;

	// Token: 0x040045CD RID: 17869
	[Token(Token = "0x40045CD")]
	[FieldOffset(Offset = "0x78")]
	public int districtSizeMax;

	// Token: 0x040045CE RID: 17870
	[Token(Token = "0x40045CE")]
	[FieldOffset(Offset = "0x7C")]
	public float sideAlleyChance;

	// Token: 0x040045CF RID: 17871
	[Token(Token = "0x40045CF")]
	[FieldOffset(Offset = "0x80")]
	public float sideAlleyExtentionChance;

	// Token: 0x040045D0 RID: 17872
	[Token(Token = "0x40045D0")]
	[FieldOffset(Offset = "0x84")]
	public bool overheadStreet;

	// Token: 0x040045D1 RID: 17873
	[Token(Token = "0x40045D1")]
	[FieldOffset(Offset = "0x88")]
	public float travelTimeCrowFliesMultiplierEstimate;

	// Token: 0x040045D2 RID: 17874
	[Token(Token = "0x40045D2")]
	[FieldOffset(Offset = "0x8C")]
	public float travelTimeMultiplier;

	// Token: 0x040045D3 RID: 17875
	[Token(Token = "0x40045D3")]
	[FieldOffset(Offset = "0x90")]
	public float homelessMultiplier;

	// Token: 0x040045D4 RID: 17876
	[Token(Token = "0x40045D4")]
	[FieldOffset(Offset = "0x94")]
	public float residentialRatio;

	// Token: 0x040045D5 RID: 17877
	[Token(Token = "0x40045D5")]
	[FieldOffset(Offset = "0x98")]
	public float commercialRatio;

	// Token: 0x040045D6 RID: 17878
	[Token(Token = "0x40045D6")]
	[FieldOffset(Offset = "0x9C")]
	public float industrialRatio;

	// Token: 0x040045D7 RID: 17879
	[Token(Token = "0x40045D7")]
	[FieldOffset(Offset = "0xA0")]
	public float municipalRatio;

	// Token: 0x040045D8 RID: 17880
	[Token(Token = "0x40045D8")]
	[FieldOffset(Offset = "0xA4")]
	public float parksRatio;

	// Token: 0x040045D9 RID: 17881
	[Token(Token = "0x40045D9")]
	[FieldOffset(Offset = "0xA8")]
	public AddressPreset lobbyPreset;

	// Token: 0x040045DA RID: 17882
	[Token(Token = "0x40045DA")]
	[FieldOffset(Offset = "0xB0")]
	public Vector2 smallUnitRange;

	// Token: 0x040045DB RID: 17883
	[Token(Token = "0x40045DB")]
	[FieldOffset(Offset = "0xB8")]
	public Vector2 mediumUnitRange;

	// Token: 0x040045DC RID: 17884
	[Token(Token = "0x40045DC")]
	[FieldOffset(Offset = "0xC0")]
	public Vector2 lageUnitRange;

	// Token: 0x040045DD RID: 17885
	[Token(Token = "0x40045DD")]
	[FieldOffset(Offset = "0xC8")]
	public DesignStylePreset defaultStyle;

	// Token: 0x040045DE RID: 17886
	[Token(Token = "0x40045DE")]
	[FieldOffset(Offset = "0xD0")]
	public DoorPairPreset defaultWalls;

	// Token: 0x040045DF RID: 17887
	[Token(Token = "0x40045DF")]
	[FieldOffset(Offset = "0xD8")]
	public MaterialGroupPreset defaultFloorMaterialGroup;

	// Token: 0x040045E0 RID: 17888
	[Token(Token = "0x40045E0")]
	[FieldOffset(Offset = "0xE0")]
	public MaterialGroupPreset defaultCeilingMaterialGroup;

	// Token: 0x040045E1 RID: 17889
	[Token(Token = "0x40045E1")]
	[FieldOffset(Offset = "0xE8")]
	public MaterialGroupPreset defaultWallMaterialGroup;

	// Token: 0x040045E2 RID: 17890
	[Token(Token = "0x40045E2")]
	[FieldOffset(Offset = "0xF0")]
	public RoomConfiguration nullDefaultRoom;

	// Token: 0x040045E3 RID: 17891
	[Token(Token = "0x40045E3")]
	[FieldOffset(Offset = "0xF8")]
	public RoomConfiguration streetRoom;

	// Token: 0x040045E4 RID: 17892
	[Token(Token = "0x40045E4")]
	[FieldOffset(Offset = "0x100")]
	public RoomConfiguration alleyRoom;

	// Token: 0x040045E5 RID: 17893
	[Token(Token = "0x40045E5")]
	[FieldOffset(Offset = "0x108")]
	public RoomConfiguration backstreetRoom;

	// Token: 0x040045E6 RID: 17894
	[Token(Token = "0x40045E6")]
	[FieldOffset(Offset = "0x110")]
	public LayoutConfiguration outsideLayoutConfig;

	// Token: 0x040045E7 RID: 17895
	[Token(Token = "0x40045E7")]
	[FieldOffset(Offset = "0x118")]
	public LayoutConfiguration lobbyLayoutConfig;

	// Token: 0x040045E8 RID: 17896
	[Token(Token = "0x40045E8")]
	[FieldOffset(Offset = "0x120")]
	public DesignStylePreset street;

	// Token: 0x040045E9 RID: 17897
	[Token(Token = "0x40045E9")]
	[FieldOffset(Offset = "0x128")]
	public int lowestFloor;

	// Token: 0x040045EA RID: 17898
	[Token(Token = "0x40045EA")]
	[FieldOffset(Offset = "0x12C")]
	public float lowestFloorLightMultiplier;

	// Token: 0x040045EB RID: 17899
	[Token(Token = "0x40045EB")]
	[FieldOffset(Offset = "0x130")]
	public float lowestFloorIncreaseFlickerChance;

	// Token: 0x040045EC RID: 17900
	[Token(Token = "0x40045EC")]
	[FieldOffset(Offset = "0x134")]
	public float basementWaterLevel;

	// Token: 0x040045ED RID: 17901
	[Token(Token = "0x40045ED")]
	[FieldOffset(Offset = "0x138")]
	public DesignStylePreset fallbackStyle;

	// Token: 0x040045EE RID: 17902
	[Token(Token = "0x40045EE")]
	[FieldOffset(Offset = "0x140")]
	public ColourSchemePreset fallbackColourScheme;

	// Token: 0x040045EF RID: 17903
	[Token(Token = "0x40045EF")]
	[FieldOffset(Offset = "0x148")]
	public MaterialGroupPreset fallbackFloorMat;

	// Token: 0x040045F0 RID: 17904
	[Token(Token = "0x40045F0")]
	[FieldOffset(Offset = "0x150")]
	public MaterialGroupPreset fallbackWallMat;

	// Token: 0x040045F1 RID: 17905
	[Token(Token = "0x40045F1")]
	[FieldOffset(Offset = "0x158")]
	public MaterialGroupPreset fallbackCeilingMat;

	// Token: 0x040045F2 RID: 17906
	[Token(Token = "0x40045F2")]
	[FieldOffset(Offset = "0x160")]
	public Light sunLight;

	// Token: 0x040045F3 RID: 17907
	[Token(Token = "0x40045F3")]
	[FieldOffset(Offset = "0x168")]
	public Transform sunPosition;

	// Token: 0x040045F4 RID: 17908
	[Token(Token = "0x40045F4")]
	[FieldOffset(Offset = "0x170")]
	public HDAdditionalLightData hdrpLightSunData;

	// Token: 0x040045F5 RID: 17909
	[Token(Token = "0x40045F5")]
	[FieldOffset(Offset = "0x178")]
	public Light exteriorAmbientLight;

	// Token: 0x040045F6 RID: 17910
	[Token(Token = "0x40045F6")]
	[FieldOffset(Offset = "0x180")]
	public HDAdditionalLightData exteriorAmbientHDRP;

	// Token: 0x040045F7 RID: 17911
	[Token(Token = "0x40045F7")]
	[FieldOffset(Offset = "0x188")]
	public Light interiorAmbientLight;

	// Token: 0x040045F8 RID: 17912
	[Token(Token = "0x40045F8")]
	[FieldOffset(Offset = "0x190")]
	public HDAdditionalLightData interiorAmbientHDRP;

	// Token: 0x040045F9 RID: 17913
	[Token(Token = "0x40045F9")]
	[FieldOffset(Offset = "0x198")]
	public Material seaMaterial;

	// Token: 0x040045FA RID: 17914
	[Token(Token = "0x40045FA")]
	[FieldOffset(Offset = "0x1A0")]
	public MeshRenderer seaRenderer;

	// Token: 0x040045FB RID: 17915
	[Token(Token = "0x40045FB")]
	[FieldOffset(Offset = "0x1A8")]
	public Material skylineMaterial;

	// Token: 0x040045FC RID: 17916
	[Token(Token = "0x40045FC")]
	[FieldOffset(Offset = "0x1B0")]
	public List<MeshRenderer> skylineRenderers;

	// Token: 0x040045FD RID: 17917
	[Token(Token = "0x40045FD")]
	[FieldOffset(Offset = "0x1B8")]
	public Material smokeMaterial;

	// Token: 0x040045FE RID: 17918
	[Token(Token = "0x40045FE")]
	[FieldOffset(Offset = "0x1C0")]
	public DesignStylePreset echelonDesignStyle;

	// Token: 0x040045FF RID: 17919
	[Token(Token = "0x40045FF")]
	[FieldOffset(Offset = "0x1C8")]
	public Color echelonWood;

	// Token: 0x04004600 RID: 17920
	[Token(Token = "0x4004600")]
	[FieldOffset(Offset = "0x1D8")]
	public MaterialGroupPreset echelonFloorMaterial;

	// Token: 0x04004601 RID: 17921
	[Token(Token = "0x4004601")]
	[FieldOffset(Offset = "0x1E0")]
	public MaterialGroupPreset.MaterialVariation echelonFloorVariation;

	// Token: 0x04004602 RID: 17922
	[Token(Token = "0x4004602")]
	[FieldOffset(Offset = "0x1E8")]
	public MaterialGroupPreset echelonCeilingMaterial;

	// Token: 0x04004603 RID: 17923
	[Token(Token = "0x4004603")]
	[FieldOffset(Offset = "0x1F0")]
	public MaterialGroupPreset.MaterialVariation echelonCeilingVariation;

	// Token: 0x04004604 RID: 17924
	[Token(Token = "0x4004604")]
	[FieldOffset(Offset = "0x1F8")]
	public MaterialGroupPreset echelonDefaultWallMaterial;

	// Token: 0x04004605 RID: 17925
	[Token(Token = "0x4004605")]
	[FieldOffset(Offset = "0x200")]
	public MaterialGroupPreset.MaterialVariation echelonWallVariation;

	// Token: 0x04004606 RID: 17926
	[Token(Token = "0x4004606")]
	[FieldOffset(Offset = "0x208")]
	public ColourSchemePreset echelonColourScheme;

	// Token: 0x04004607 RID: 17927
	[Token(Token = "0x4004607")]
	[FieldOffset(Offset = "0x210")]
	public List<CityControls.PPProfile> sceneProfileSetup;

	// Token: 0x04004608 RID: 17928
	[Token(Token = "0x4004608")]
	[FieldOffset(Offset = "0x218")]
	public CityControls.PPProfile captureSceneNormal;

	// Token: 0x04004609 RID: 17929
	[Token(Token = "0x4004609")]
	[FieldOffset(Offset = "0x220")]
	public CityControls.PPProfile captureSceneCCTV;

	// Token: 0x0400460A RID: 17930
	[Token(Token = "0x400460A")]
	[FieldOffset(Offset = "0x228")]
	public Transform ships1;

	// Token: 0x0400460B RID: 17931
	[Token(Token = "0x400460B")]
	[FieldOffset(Offset = "0x230")]
	public float angleOfSun;

	// Token: 0x0400460C RID: 17932
	[Token(Token = "0x400460C")]
	[FieldOffset(Offset = "0x234")]
	public Vector2 lightsOff;

	// Token: 0x0400460D RID: 17933
	[Token(Token = "0x400460D")]
	[FieldOffset(Offset = "0x23C")]
	public Vector2 lightsOn;

	// Token: 0x0400460E RID: 17934
	[Token(Token = "0x400460E")]
	[FieldOffset(Offset = "0x248")]
	public DoorPairPreset alleyBlockWallPreset;

	// Token: 0x0400460F RID: 17935
	[Token(Token = "0x400460F")]
	[FieldOffset(Offset = "0x250")]
	public FogPreset weatherSettings;

	// Token: 0x04004610 RID: 17936
	[Token(Token = "0x4004610")]
	[FieldOffset(Offset = "0x258")]
	public float timeForCityToGetWet;

	// Token: 0x04004611 RID: 17937
	[Token(Token = "0x4004611")]
	[FieldOffset(Offset = "0x25C")]
	public float timeForCityToGetDry;

	// Token: 0x04004612 RID: 17938
	[Token(Token = "0x4004612")]
	[FieldOffset(Offset = "0x260")]
	public float timeForCityToGetSnow;

	// Token: 0x04004613 RID: 17939
	[Token(Token = "0x4004613")]
	[FieldOffset(Offset = "0x264")]
	public float timeForCityToGetNotSnow;

	// Token: 0x04004614 RID: 17940
	[Token(Token = "0x4004614")]
	[FieldOffset(Offset = "0x268")]
	public Material neonMaterial;

	// Token: 0x04004615 RID: 17941
	[Token(Token = "0x4004615")]
	[FieldOffset(Offset = "0x270")]
	public float neonIntensity;

	// Token: 0x04004616 RID: 17942
	[Token(Token = "0x4004616")]
	[FieldOffset(Offset = "0x278")]
	public List<CityControls.NeonMaterial> neonColours;

	// Token: 0x04004617 RID: 17943
	[Token(Token = "0x4004617")]
	[FieldOffset(Offset = "0x280")]
	public List<CityControls.StreetCable> cables;

	// Token: 0x04004618 RID: 17944
	[Token(Token = "0x4004618")]
	[FieldOffset(Offset = "0x288")]
	public float maximumCableAngle;

	// Token: 0x04004619 RID: 17945
	[Token(Token = "0x4004619")]
	[FieldOffset(Offset = "0x290")]
	public LayoutConfiguration park;

	// Token: 0x0400461A RID: 17946
	[Token(Token = "0x400461A")]
	[FieldOffset(Offset = "0x298")]
	public int hotelCostLower;

	// Token: 0x0400461B RID: 17947
	[Token(Token = "0x400461B")]
	[FieldOffset(Offset = "0x29C")]
	public int hotelCostUpper;

	// Token: 0x0400461C RID: 17948
	[Token(Token = "0x400461C")]
	[FieldOffset(Offset = "0x2A0")]
	public float kickoutTime;

	// Token: 0x0400461D RID: 17949
	[Token(Token = "0x400461D")]
	[FieldOffset(Offset = "0x2A8")]
	public Transform basementWaterTransform;

	// Token: 0x0400461E RID: 17950
	[Token(Token = "0x400461E")]
	[FieldOffset(Offset = "0x2B0")]
	public InteractablePreset lostAndFoundNote;

	// Token: 0x0400461F RID: 17951
	[Token(Token = "0x400461F")]
	[FieldOffset(Offset = "0x2B8")]
	public List<InteractablePreset> lostAndFoundItems;

	// Token: 0x04004620 RID: 17952
	[Token(Token = "0x4004620")]
	[FieldOffset(Offset = "0x2C0")]
	public DoorPairPreset dividerCenter;

	// Token: 0x04004621 RID: 17953
	[Token(Token = "0x4004621")]
	[FieldOffset(Offset = "0x2C8")]
	public DoorPairPreset dividerLeft;

	// Token: 0x04004622 RID: 17954
	[Token(Token = "0x4004622")]
	[FieldOffset(Offset = "0x2D0")]
	public DoorPairPreset dividerRight;

	// Token: 0x04004623 RID: 17955
	[Token(Token = "0x4004623")]
	[FieldOffset(Offset = "0x2D8")]
	public InteractablePreset jobNote;

	// Token: 0x04004624 RID: 17956
	[Token(Token = "0x4004624")]
	[FieldOffset(Offset = "0x0")]
	private static CityControls _instance;

	// Token: 0x020008AE RID: 2222
	[Token(Token = "0x20008AE")]
	[Serializable]
	public struct WindowColour
	{
		// Token: 0x04004625 RID: 17957
		[Token(Token = "0x4004625")]
		[FieldOffset(Offset = "0x0")]
		public Color colourOne;

		// Token: 0x04004626 RID: 17958
		[Token(Token = "0x4004626")]
		[FieldOffset(Offset = "0x10")]
		public Color colourTwo;
	}

	// Token: 0x020008AF RID: 2223
	[Token(Token = "0x20008AF")]
	[Serializable]
	public class NeonMaterial
	{
		// Token: 0x06002A22 RID: 10786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A22")]
		[Address(RVA = "0xCB8A80", Offset = "0xCB7A80", VA = "0x180CB8A80")]
		public NeonMaterial()
		{
		}

		// Token: 0x04004627 RID: 17959
		[Token(Token = "0x4004627")]
		[FieldOffset(Offset = "0x10")]
		public Color neonColour;

		// Token: 0x04004628 RID: 17960
		[Token(Token = "0x4004628")]
		[FieldOffset(Offset = "0x20")]
		public Color altColour2;

		// Token: 0x04004629 RID: 17961
		[Token(Token = "0x4004629")]
		[FieldOffset(Offset = "0x30")]
		public Color altColour3;

		// Token: 0x0400462A RID: 17962
		[Token(Token = "0x400462A")]
		[FieldOffset(Offset = "0x40")]
		public Material regularMat;

		// Token: 0x0400462B RID: 17963
		[Token(Token = "0x400462B")]
		[FieldOffset(Offset = "0x48")]
		public Material flickingMat;

		// Token: 0x0400462C RID: 17964
		[Token(Token = "0x400462C")]
		[FieldOffset(Offset = "0x50")]
		public AudioEvent flickerAudio;

		// Token: 0x0400462D RID: 17965
		[Token(Token = "0x400462D")]
		[FieldOffset(Offset = "0x58")]
		public bool flicker;

		// Token: 0x0400462E RID: 17966
		[Token(Token = "0x400462E")]
		[FieldOffset(Offset = "0x5C")]
		public float flickerColourMultiplier;

		// Token: 0x0400462F RID: 17967
		[Token(Token = "0x400462F")]
		[FieldOffset(Offset = "0x60")]
		public float pulseSpeed;

		// Token: 0x04004630 RID: 17968
		[Token(Token = "0x4004630")]
		[FieldOffset(Offset = "0x64")]
		public float flickerState;

		// Token: 0x04004631 RID: 17969
		[Token(Token = "0x4004631")]
		[FieldOffset(Offset = "0x68")]
		public bool flickerSwitch;

		// Token: 0x04004632 RID: 17970
		[Token(Token = "0x4004632")]
		[FieldOffset(Offset = "0x69")]
		public bool flickerInterval;

		// Token: 0x04004633 RID: 17971
		[Token(Token = "0x4004633")]
		[FieldOffset(Offset = "0x6C")]
		public float interval;

		// Token: 0x04004634 RID: 17972
		[Token(Token = "0x4004634")]
		[FieldOffset(Offset = "0x70")]
		public float intervalTime;

		// Token: 0x04004635 RID: 17973
		[Token(Token = "0x4004635")]
		[FieldOffset(Offset = "0x74")]
		public float brightness;

		// Token: 0x04004636 RID: 17974
		[Token(Token = "0x4004636")]
		[FieldOffset(Offset = "0x78")]
		public string colourTag;
	}

	// Token: 0x020008B0 RID: 2224
	[Token(Token = "0x20008B0")]
	[Serializable]
	public class CitySize
	{
		// Token: 0x06002A23 RID: 10787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A23")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public CitySize()
		{
		}

		// Token: 0x04004637 RID: 17975
		[Token(Token = "0x4004637")]
		[FieldOffset(Offset = "0x10")]
		public CityControls.Size size;

		// Token: 0x04004638 RID: 17976
		[Token(Token = "0x4004638")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 v2;
	}

	// Token: 0x020008B1 RID: 2225
	[Token(Token = "0x20008B1")]
	public enum Size
	{
		// Token: 0x0400463A RID: 17978
		[Token(Token = "0x400463A")]
		small,
		// Token: 0x0400463B RID: 17979
		[Token(Token = "0x400463B")]
		medium,
		// Token: 0x0400463C RID: 17980
		[Token(Token = "0x400463C")]
		large,
		// Token: 0x0400463D RID: 17981
		[Token(Token = "0x400463D")]
		veryLarge
	}

	// Token: 0x020008B2 RID: 2226
	[Token(Token = "0x20008B2")]
	[Serializable]
	public class PPProfile
	{
		// Token: 0x06002A24 RID: 10788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A24")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public PPProfile()
		{
		}

		// Token: 0x0400463E RID: 17982
		[Token(Token = "0x400463E")]
		[FieldOffset(Offset = "0x10")]
		public SessionData.SceneProfile profile;

		// Token: 0x0400463F RID: 17983
		[Token(Token = "0x400463F")]
		[FieldOffset(Offset = "0x18")]
		public Volume volume;

		// Token: 0x04004640 RID: 17984
		[Token(Token = "0x4004640")]
		[FieldOffset(Offset = "0x20")]
		public GameObject objectRef;
	}

	// Token: 0x020008B3 RID: 2227
	[Token(Token = "0x20008B3")]
	[Serializable]
	public class StreetCable
	{
		// Token: 0x06002A25 RID: 10789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A25")]
		[Address(RVA = "0xCB8AB0", Offset = "0xCB7AB0", VA = "0x180CB8AB0")]
		public StreetCable()
		{
		}

		// Token: 0x04004641 RID: 17985
		[Token(Token = "0x4004641")]
		[FieldOffset(Offset = "0x10")]
		public GameObject prefab;

		// Token: 0x04004642 RID: 17986
		[Token(Token = "0x4004642")]
		[FieldOffset(Offset = "0x18")]
		public float maximumWidth;

		// Token: 0x04004643 RID: 17987
		[Token(Token = "0x4004643")]
		[FieldOffset(Offset = "0x1C")]
		public int frequency;

		// Token: 0x04004644 RID: 17988
		[Token(Token = "0x4004644")]
		[FieldOffset(Offset = "0x20")]
		public float maximumCableAngle;

		// Token: 0x04004645 RID: 17989
		[Token(Token = "0x4004645")]
		[FieldOffset(Offset = "0x24")]
		public float minimumHeight;

		// Token: 0x04004646 RID: 17990
		[Token(Token = "0x4004646")]
		[FieldOffset(Offset = "0x28")]
		public float maximumHeight;

		// Token: 0x04004647 RID: 17991
		[Token(Token = "0x4004647")]
		[FieldOffset(Offset = "0x2C")]
		public bool onlyFromZoneType;

		// Token: 0x04004648 RID: 17992
		[Token(Token = "0x4004648")]
		[FieldOffset(Offset = "0x30")]
		public BuildingPreset.ZoneType zone;

		// Token: 0x04004649 RID: 17993
		[Token(Token = "0x4004649")]
		[FieldOffset(Offset = "0x34")]
		public bool disitrctFrequencyModifier;

		// Token: 0x0400464A RID: 17994
		[Token(Token = "0x400464A")]
		[FieldOffset(Offset = "0x38")]
		public List<DistrictPreset> districts;

		// Token: 0x0400464B RID: 17995
		[Token(Token = "0x400464B")]
		[FieldOffset(Offset = "0x40")]
		public int frequencyModifier;

		// Token: 0x0400464C RID: 17996
		[Token(Token = "0x400464C")]
		[FieldOffset(Offset = "0x44")]
		public bool alterAreaLighting;

		// Token: 0x0400464D RID: 17997
		[Token(Token = "0x400464D")]
		[FieldOffset(Offset = "0x48")]
		public List<Color> possibleColours;

		// Token: 0x0400464E RID: 17998
		[Token(Token = "0x400464E")]
		[FieldOffset(Offset = "0x50")]
		public DistrictPreset.AffectStreetAreaLights lightOperation;

		// Token: 0x0400464F RID: 17999
		[Token(Token = "0x400464F")]
		[FieldOffset(Offset = "0x54")]
		public float lightAmount;

		// Token: 0x04004650 RID: 18000
		[Token(Token = "0x4004650")]
		[FieldOffset(Offset = "0x58")]
		public float brightnessModifier;
	}
}
