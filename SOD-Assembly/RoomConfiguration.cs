using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000878 RID: 2168
[Token(Token = "0x2000878")]
public class RoomConfiguration : SoCustomComparison
{
	// Token: 0x060029E7 RID: 10727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029E7")]
	[Address(RVA = "0xCB1EE0", Offset = "0xCB0EE0", VA = "0x180CB1EE0")]
	public void CopyWallFrontage()
	{
	}

	// Token: 0x060029E8 RID: 10728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029E8")]
	[Address(RVA = "0xCB1FE0", Offset = "0xCB0FE0", VA = "0x180CB1FE0")]
	public void AddWallFrontage()
	{
	}

	// Token: 0x060029E9 RID: 10729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029E9")]
	[Address(RVA = "0xCB2070", Offset = "0xCB1070", VA = "0x180CB2070")]
	public RoomConfiguration()
	{
	}

	// Token: 0x04004215 RID: 16917
	[Token(Token = "0x4004215")]
	[FieldOffset(Offset = "0x20")]
	public RoomTypePreset roomType;

	// Token: 0x04004216 RID: 16918
	[Token(Token = "0x4004216")]
	[FieldOffset(Offset = "0x28")]
	public RoomClassPreset roomClass;

	// Token: 0x04004217 RID: 16919
	[Token(Token = "0x4004217")]
	[FieldOffset(Offset = "0x30")]
	public bool canBeOpenPlan;

	// Token: 0x04004218 RID: 16920
	[Token(Token = "0x4004218")]
	[FieldOffset(Offset = "0x38")]
	public RoomTypePreset openPlanRoom;

	// Token: 0x04004219 RID: 16921
	[Token(Token = "0x4004219")]
	[FieldOffset(Offset = "0x40")]
	public RoomConfiguration.SecurityDoorRule securityDoors;

	// Token: 0x0400421A RID: 16922
	[Token(Token = "0x400421A")]
	[FieldOffset(Offset = "0x44")]
	public bool limitSecurityCameras;

	// Token: 0x0400421B RID: 16923
	[Token(Token = "0x400421B")]
	[FieldOffset(Offset = "0x48")]
	public int securityCameraLimit;

	// Token: 0x0400421C RID: 16924
	[Token(Token = "0x400421C")]
	[FieldOffset(Offset = "0x4C")]
	public bool useMainLights;

	// Token: 0x0400421D RID: 16925
	[Token(Token = "0x400421D")]
	[FieldOffset(Offset = "0x4D")]
	public bool useLightSwitches;

	// Token: 0x0400421E RID: 16926
	[Token(Token = "0x400421E")]
	[FieldOffset(Offset = "0x4E")]
	public bool lightsOnAtStart;

	// Token: 0x0400421F RID: 16927
	[Token(Token = "0x400421F")]
	[FieldOffset(Offset = "0x4F")]
	public bool wellLit;

	// Token: 0x04004220 RID: 16928
	[Token(Token = "0x4004220")]
	[FieldOffset(Offset = "0x50")]
	public bool autoDisableLightsOutOfVicinity;

	// Token: 0x04004221 RID: 16929
	[Token(Token = "0x4004221")]
	[FieldOffset(Offset = "0x51")]
	public bool onlyAutoDisableInNonStairwell;

	// Token: 0x04004222 RID: 16930
	[Token(Token = "0x4004222")]
	[FieldOffset(Offset = "0x52")]
	public bool useAdditionalAreaLights;

	// Token: 0x04004223 RID: 16931
	[Token(Token = "0x4004223")]
	[FieldOffset(Offset = "0x53")]
	public bool useDistrictSettingsAsBase;

	// Token: 0x04004224 RID: 16932
	[Token(Token = "0x4004224")]
	[FieldOffset(Offset = "0x54")]
	public int minimumLightZoneSizeForAreaLights;

	// Token: 0x04004225 RID: 16933
	[Token(Token = "0x4004225")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 areaLightOffset;

	// Token: 0x04004226 RID: 16934
	[Token(Token = "0x4004226")]
	[FieldOffset(Offset = "0x64")]
	public float areaLightBrightness;

	// Token: 0x04004227 RID: 16935
	[Token(Token = "0x4004227")]
	[FieldOffset(Offset = "0x68")]
	public Color areaLightColor;

	// Token: 0x04004228 RID: 16936
	[Token(Token = "0x4004228")]
	[FieldOffset(Offset = "0x78")]
	public float areaLightRange;

	// Token: 0x04004229 RID: 16937
	[Token(Token = "0x4004229")]
	[FieldOffset(Offset = "0x7C")]
	public float areaLightCoverageMultiplier;

	// Token: 0x0400422A RID: 16938
	[Token(Token = "0x400422A")]
	[FieldOffset(Offset = "0x80")]
	public bool boostCeilingEmission;

	// Token: 0x0400422B RID: 16939
	[Token(Token = "0x400422B")]
	[FieldOffset(Offset = "0x84")]
	public Color ceilingEmissionBoost;

	// Token: 0x0400422C RID: 16940
	[Token(Token = "0x400422C")]
	[FieldOffset(Offset = "0x94")]
	public float chanceOfCeilingFans;

	// Token: 0x0400422D RID: 16941
	[Token(Token = "0x400422D")]
	[FieldOffset(Offset = "0x98")]
	public bool baseLightingShadowTint;

	// Token: 0x0400422E RID: 16942
	[Token(Token = "0x400422E")]
	[FieldOffset(Offset = "0x9C")]
	public float baseLightingShadowTintIntensity;

	// Token: 0x0400422F RID: 16943
	[Token(Token = "0x400422F")]
	[FieldOffset(Offset = "0xA0")]
	public bool areaLightingShadowTint;

	// Token: 0x04004230 RID: 16944
	[Token(Token = "0x4004230")]
	[FieldOffset(Offset = "0xA4")]
	public float areaLightingShadowTintIntensity;

	// Token: 0x04004231 RID: 16945
	[Token(Token = "0x4004231")]
	[FieldOffset(Offset = "0xA8")]
	public bool overrideAreaLightShadowTint;

	// Token: 0x04004232 RID: 16946
	[Token(Token = "0x4004232")]
	[FieldOffset(Offset = "0xAC")]
	public Color areaLightShadowTintOverride;

	// Token: 0x04004233 RID: 16947
	[Token(Token = "0x4004233")]
	[FieldOffset(Offset = "0xBC")]
	public float areaLightShadowDimmer;

	// Token: 0x04004234 RID: 16948
	[Token(Token = "0x4004234")]
	[FieldOffset(Offset = "0xC0")]
	public List<RoomConfiguration.AILightingBehaviour> lightingBehaviour;

	// Token: 0x04004235 RID: 16949
	[Token(Token = "0x4004235")]
	[FieldOffset(Offset = "0xC8")]
	public int cleanness;

	// Token: 0x04004236 RID: 16950
	[Token(Token = "0x4004236")]
	[FieldOffset(Offset = "0xD0")]
	public List<ColourSchemePreset> forceColourSchemes;

	// Token: 0x04004237 RID: 16951
	[Token(Token = "0x4004237")]
	[FieldOffset(Offset = "0xD8")]
	public float minimumGrubiness;

	// Token: 0x04004238 RID: 16952
	[Token(Token = "0x4004238")]
	[FieldOffset(Offset = "0xDC")]
	public float maximumGrubiness;

	// Token: 0x04004239 RID: 16953
	[Token(Token = "0x4004239")]
	[FieldOffset(Offset = "0xE0")]
	public RoomConfiguration.DecorSetting decorSetting;

	// Token: 0x0400423A RID: 16954
	[Token(Token = "0x400423A")]
	[FieldOffset(Offset = "0xE4")]
	public bool excludeFromOthersCopyingDecorStyle;

	// Token: 0x0400423B RID: 16955
	[Token(Token = "0x400423B")]
	[FieldOffset(Offset = "0xE8")]
	public float chanceOfOverrideMatIfGroundFloor;

	// Token: 0x0400423C RID: 16956
	[Token(Token = "0x400423C")]
	[FieldOffset(Offset = "0xEC")]
	public float chanceOfOverrideMatIfBasement;

	// Token: 0x0400423D RID: 16957
	[Token(Token = "0x400423D")]
	[FieldOffset(Offset = "0xF0")]
	public float chanceOfOverrideMatIfStairwell;

	// Token: 0x0400423E RID: 16958
	[Token(Token = "0x400423E")]
	[FieldOffset(Offset = "0xF8")]
	public List<MaterialGroupPreset> floorOverrides;

	// Token: 0x0400423F RID: 16959
	[Token(Token = "0x400423F")]
	[FieldOffset(Offset = "0x100")]
	public List<MaterialGroupPreset> wallOverrides;

	// Token: 0x04004240 RID: 16960
	[Token(Token = "0x4004240")]
	[FieldOffset(Offset = "0x108")]
	public List<MaterialGroupPreset> ceilingOverrides;

	// Token: 0x04004241 RID: 16961
	[Token(Token = "0x4004241")]
	[FieldOffset(Offset = "0x110")]
	public int decorationPriority;

	// Token: 0x04004242 RID: 16962
	[Token(Token = "0x4004242")]
	[FieldOffset(Offset = "0x114")]
	public bool useOwnership;

	// Token: 0x04004243 RID: 16963
	[Token(Token = "0x4004243")]
	[FieldOffset(Offset = "0x118")]
	public int assignBelongsToOwners;

	// Token: 0x04004244 RID: 16964
	[Token(Token = "0x4004244")]
	[FieldOffset(Offset = "0x11C")]
	public bool preferCouples;

	// Token: 0x04004245 RID: 16965
	[Token(Token = "0x4004245")]
	[FieldOffset(Offset = "0x120")]
	public List<OccupationPreset> belongsToJob;

	// Token: 0x04004246 RID: 16966
	[Token(Token = "0x4004246")]
	[FieldOffset(Offset = "0x128")]
	public DoorPreset exteriorDoor;

	// Token: 0x04004247 RID: 16967
	[Token(Token = "0x4004247")]
	[FieldOffset(Offset = "0x130")]
	public DoorPreset addressDoor;

	// Token: 0x04004248 RID: 16968
	[Token(Token = "0x4004248")]
	[FieldOffset(Offset = "0x138")]
	public DoorPreset internalDoor;

	// Token: 0x04004249 RID: 16969
	[Token(Token = "0x4004249")]
	[FieldOffset(Offset = "0x140")]
	public int passwordPriority;

	// Token: 0x0400424A RID: 16970
	[Token(Token = "0x400424A")]
	[FieldOffset(Offset = "0x144")]
	public RoomConfiguration.RoomPasswordPreference preferredPassword;

	// Token: 0x0400424B RID: 16971
	[Token(Token = "0x400424B")]
	[FieldOffset(Offset = "0x148")]
	public List<RoomConfiguration.KeyPlacement> placeKey;

	// Token: 0x0400424C RID: 16972
	[Token(Token = "0x400424C")]
	[FieldOffset(Offset = "0x150")]
	public InteractablePreset.OwnedPlacementRule keyOwnershipPlacement;

	// Token: 0x0400424D RID: 16973
	[Token(Token = "0x400424D")]
	[FieldOffset(Offset = "0x158")]
	public GameObject steps;

	// Token: 0x0400424E RID: 16974
	[Token(Token = "0x400424E")]
	[FieldOffset(Offset = "0x160")]
	public DoorPairPreset replaceWindows;

	// Token: 0x0400424F RID: 16975
	[Token(Token = "0x400424F")]
	[FieldOffset(Offset = "0x168")]
	public DoorPairPreset replaceWalls;

	// Token: 0x04004250 RID: 16976
	[Token(Token = "0x4004250")]
	[FieldOffset(Offset = "0x170")]
	public DoorPairPreset replaceEntrance;

	// Token: 0x04004251 RID: 16977
	[Token(Token = "0x4004251")]
	[FieldOffset(Offset = "0x178")]
	public bool replaceInsideAlso;

	// Token: 0x04004252 RID: 16978
	[Token(Token = "0x4004252")]
	[FieldOffset(Offset = "0x179")]
	public bool replaceOnlyIfOtherIs;

	// Token: 0x04004253 RID: 16979
	[Token(Token = "0x4004253")]
	[FieldOffset(Offset = "0x180")]
	public List<RoomTypePreset> onlyReplaceIf;

	// Token: 0x04004254 RID: 16980
	[Token(Token = "0x4004254")]
	[FieldOffset(Offset = "0x188")]
	public bool forceStreetLightLayer;

	// Token: 0x04004255 RID: 16981
	[Token(Token = "0x4004255")]
	[FieldOffset(Offset = "0x189")]
	public bool drawBuildingModel;

	// Token: 0x04004256 RID: 16982
	[Token(Token = "0x4004256")]
	[FieldOffset(Offset = "0x190")]
	public List<RoomConfiguration.WallFrontage> wallFrontage;

	// Token: 0x04004257 RID: 16983
	[Token(Token = "0x4004257")]
	[FieldOffset(Offset = "0x198")]
	public bool oneFrontagePerNode;

	// Token: 0x04004258 RID: 16984
	[Token(Token = "0x4004258")]
	[FieldOffset(Offset = "0x19C")]
	public int maximumVents;

	// Token: 0x04004259 RID: 16985
	[Token(Token = "0x4004259")]
	[FieldOffset(Offset = "0x1A0")]
	public int chanceOfRoofVent;

	// Token: 0x0400425A RID: 16986
	[Token(Token = "0x400425A")]
	[FieldOffset(Offset = "0x1A4")]
	public int chanceOfWallVentUpper;

	// Token: 0x0400425B RID: 16987
	[Token(Token = "0x400425B")]
	[FieldOffset(Offset = "0x1A8")]
	public int chanceOfWallVentLower;

	// Token: 0x0400425C RID: 16988
	[Token(Token = "0x400425C")]
	[FieldOffset(Offset = "0x1AC")]
	public bool allowUpperWallLevelDucts;

	// Token: 0x0400425D RID: 16989
	[Token(Token = "0x400425D")]
	[FieldOffset(Offset = "0x1AD")]
	public bool onlyAllowUpperIfFloorLevelIsZero;

	// Token: 0x0400425E RID: 16990
	[Token(Token = "0x400425E")]
	[FieldOffset(Offset = "0x1B0")]
	public int limitUpperLevelDucts;

	// Token: 0x0400425F RID: 16991
	[Token(Token = "0x400425F")]
	[FieldOffset(Offset = "0x1B4")]
	public bool allowLowerWallLevelDucts;

	// Token: 0x04004260 RID: 16992
	[Token(Token = "0x4004260")]
	[FieldOffset(Offset = "0x1B5")]
	public bool overrideAddressEnvironment;

	// Token: 0x04004261 RID: 16993
	[Token(Token = "0x4004261")]
	[FieldOffset(Offset = "0x1B8")]
	public SessionData.SceneProfile sceneClean;

	// Token: 0x04004262 RID: 16994
	[Token(Token = "0x4004262")]
	[FieldOffset(Offset = "0x1BC")]
	public SessionData.SceneProfile sceneDirty;

	// Token: 0x04004263 RID: 16995
	[Token(Token = "0x4004263")]
	[FieldOffset(Offset = "0x1C0")]
	public float baseRoomAtmosphere;

	// Token: 0x04004264 RID: 16996
	[Token(Token = "0x4004264")]
	[FieldOffset(Offset = "0x1C4")]
	public RoomConfiguration.OutsideSetting forceOutside;

	// Token: 0x04004265 RID: 16997
	[Token(Token = "0x4004265")]
	[FieldOffset(Offset = "0x1C8")]
	public AmbientZone ambientZone;

	// Token: 0x04004266 RID: 16998
	[Token(Token = "0x4004266")]
	[FieldOffset(Offset = "0x1D0")]
	public bool fingerprintsEnabled;

	// Token: 0x04004267 RID: 16999
	[Token(Token = "0x4004267")]
	[FieldOffset(Offset = "0x1D1")]
	public bool footprintsEnabled;

	// Token: 0x04004268 RID: 17000
	[Token(Token = "0x4004268")]
	[FieldOffset(Offset = "0x1D4")]
	public RoomConfiguration.PrintsSource printsSource;

	// Token: 0x04004269 RID: 17001
	[Token(Token = "0x4004269")]
	[FieldOffset(Offset = "0x1D8")]
	public float fingerprintWallDensity;

	// Token: 0x0400426A RID: 17002
	[Token(Token = "0x400426A")]
	[FieldOffset(Offset = "0x1DC")]
	public bool allowCoving;

	// Token: 0x0400426B RID: 17003
	[Token(Token = "0x400426B")]
	[FieldOffset(Offset = "0x1DD")]
	public bool allowBugs;

	// Token: 0x0400426C RID: 17004
	[Token(Token = "0x400426C")]
	[FieldOffset(Offset = "0x1E0")]
	public float bugAmountMultiplier;

	// Token: 0x0400426D RID: 17005
	[Token(Token = "0x400426D")]
	[FieldOffset(Offset = "0x1E4")]
	public RoomConfiguration.Forbidden forbidden;

	// Token: 0x0400426E RID: 17006
	[Token(Token = "0x400426E")]
	[FieldOffset(Offset = "0x1E8")]
	public bool allowedIfGivenCorrectPassword;

	// Token: 0x0400426F RID: 17007
	[Token(Token = "0x400426F")]
	[FieldOffset(Offset = "0x1E9")]
	public bool AIknowPassword;

	// Token: 0x04004270 RID: 17008
	[Token(Token = "0x4004270")]
	[FieldOffset(Offset = "0x1EC")]
	public int escalationLevelNormal;

	// Token: 0x04004271 RID: 17009
	[Token(Token = "0x4004271")]
	[FieldOffset(Offset = "0x1F0")]
	public int escalationLevelAfterHours;

	// Token: 0x04004272 RID: 17010
	[Token(Token = "0x4004272")]
	[FieldOffset(Offset = "0x1F4")]
	public int securityLevel;

	// Token: 0x04004273 RID: 17011
	[Token(Token = "0x4004273")]
	[FieldOffset(Offset = "0x1F8")]
	public bool allowPersonalAffects;

	// Token: 0x04004274 RID: 17012
	[Token(Token = "0x4004274")]
	[FieldOffset(Offset = "0x1F9")]
	public bool overrideMaxFurnitureClusters;

	// Token: 0x04004275 RID: 17013
	[Token(Token = "0x4004275")]
	[FieldOffset(Offset = "0x1FC")]
	public int overridenMaxFurniture;

	// Token: 0x04004276 RID: 17014
	[Token(Token = "0x4004276")]
	[FieldOffset(Offset = "0x200")]
	public bool overrideAttemptsPerNodeMultiplier;

	// Token: 0x04004277 RID: 17015
	[Token(Token = "0x4004277")]
	[FieldOffset(Offset = "0x204")]
	public float overridenAttemptsPerNode;

	// Token: 0x04004278 RID: 17016
	[Token(Token = "0x4004278")]
	[FieldOffset(Offset = "0x208")]
	public int shadinessValue;

	// Token: 0x04004279 RID: 17017
	[Token(Token = "0x4004279")]
	[FieldOffset(Offset = "0x20C")]
	public bool allowMuggings;

	// Token: 0x0400427A RID: 17018
	[Token(Token = "0x400427A")]
	[FieldOffset(Offset = "0x20D")]
	public bool muggingAwakenRoom;

	// Token: 0x0400427B RID: 17019
	[Token(Token = "0x400427B")]
	[FieldOffset(Offset = "0x210")]
	public RoomConfiguration debugRoom;

	// Token: 0x02000879 RID: 2169
	[Token(Token = "0x2000879")]
	public enum DecorSetting
	{
		// Token: 0x0400427D RID: 17021
		[Token(Token = "0x400427D")]
		ownStyle,
		// Token: 0x0400427E RID: 17022
		[Token(Token = "0x400427E")]
		borrowFromAdjoining,
		// Token: 0x0400427F RID: 17023
		[Token(Token = "0x400427F")]
		borrowFromBuilding
	}

	// Token: 0x0200087A RID: 2170
	[Token(Token = "0x200087A")]
	public enum RoomZoning
	{
		// Token: 0x04004281 RID: 17025
		[Token(Token = "0x4004281")]
		lobby,
		// Token: 0x04004282 RID: 17026
		[Token(Token = "0x4004282")]
		residential,
		// Token: 0x04004283 RID: 17027
		[Token(Token = "0x4004283")]
		commerical,
		// Token: 0x04004284 RID: 17028
		[Token(Token = "0x4004284")]
		industrial,
		// Token: 0x04004285 RID: 17029
		[Token(Token = "0x4004285")]
		municpial,
		// Token: 0x04004286 RID: 17030
		[Token(Token = "0x4004286")]
		park
	}

	// Token: 0x0200087B RID: 2171
	[Token(Token = "0x200087B")]
	public enum Forbidden
	{
		// Token: 0x04004288 RID: 17032
		[Token(Token = "0x4004288")]
		alwaysAllowed,
		// Token: 0x04004289 RID: 17033
		[Token(Token = "0x4004289")]
		alwaysForbidden,
		// Token: 0x0400428A RID: 17034
		[Token(Token = "0x400428A")]
		allowedDuringOpenHours
	}

	// Token: 0x0200087C RID: 2172
	[Token(Token = "0x200087C")]
	public enum SecurityDoorRule
	{
		// Token: 0x0400428C RID: 17036
		[Token(Token = "0x400428C")]
		never,
		// Token: 0x0400428D RID: 17037
		[Token(Token = "0x400428D")]
		allAdjoining,
		// Token: 0x0400428E RID: 17038
		[Token(Token = "0x400428E")]
		onlyToOtherAddress,
		// Token: 0x0400428F RID: 17039
		[Token(Token = "0x400428F")]
		onlyToStairwell
	}

	// Token: 0x0200087D RID: 2173
	[Token(Token = "0x200087D")]
	[Serializable]
	public class AILightingBehaviour
	{
		// Token: 0x060029EA RID: 10730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029EA")]
		[Address(RVA = "0xCB26B0", Offset = "0xCB16B0", VA = "0x180CB26B0")]
		public AILightingBehaviour()
		{
		}

		// Token: 0x04004290 RID: 17040
		[Token(Token = "0x4004290")]
		[FieldOffset(Offset = "0x10")]
		public RoomConfiguration.AILightingBehaviour.TimeOfDay dayRule;

		// Token: 0x04004291 RID: 17041
		[Token(Token = "0x4004291")]
		[FieldOffset(Offset = "0x14")]
		public RoomConfiguration.AILightingBehaviour.LightingPreference passthroughBehaviour;

		// Token: 0x04004292 RID: 17042
		[Token(Token = "0x4004292")]
		[FieldOffset(Offset = "0x18")]
		public RoomConfiguration.AILightingBehaviour.LightingPreference destinationBehaviour;

		// Token: 0x04004293 RID: 17043
		[Token(Token = "0x4004293")]
		[FieldOffset(Offset = "0x1C")]
		public RoomConfiguration.AILightingBehaviour.LightingPreference exitRoomBehaviour;

		// Token: 0x04004294 RID: 17044
		[Token(Token = "0x4004294")]
		[FieldOffset(Offset = "0x20")]
		public RoomConfiguration.AILightingBehaviour.LightingPreference exitGameLocationBehaviour;

		// Token: 0x0200087E RID: 2174
		[Token(Token = "0x200087E")]
		public enum TimeOfDay
		{
			// Token: 0x04004296 RID: 17046
			[Token(Token = "0x4004296")]
			always,
			// Token: 0x04004297 RID: 17047
			[Token(Token = "0x4004297")]
			daytime,
			// Token: 0x04004298 RID: 17048
			[Token(Token = "0x4004298")]
			evening
		}

		// Token: 0x0200087F RID: 2175
		[Token(Token = "0x200087F")]
		public enum LightingPreference
		{
			// Token: 0x0400429A RID: 17050
			[Token(Token = "0x400429A")]
			mainOn,
			// Token: 0x0400429B RID: 17051
			[Token(Token = "0x400429B")]
			secondaryOn,
			// Token: 0x0400429C RID: 17052
			[Token(Token = "0x400429C")]
			eitherPriorityMain,
			// Token: 0x0400429D RID: 17053
			[Token(Token = "0x400429D")]
			eitherPrioritySecondary,
			// Token: 0x0400429E RID: 17054
			[Token(Token = "0x400429E")]
			allOff,
			// Token: 0x0400429F RID: 17055
			[Token(Token = "0x400429F")]
			mainOff,
			// Token: 0x040042A0 RID: 17056
			[Token(Token = "0x40042A0")]
			secondaryOff,
			// Token: 0x040042A1 RID: 17057
			[Token(Token = "0x40042A1")]
			none,
			// Token: 0x040042A2 RID: 17058
			[Token(Token = "0x40042A2")]
			mainOnSecondaryAny
		}
	}

	// Token: 0x02000880 RID: 2176
	[Token(Token = "0x2000880")]
	public enum RoomPasswordPreference
	{
		// Token: 0x040042A4 RID: 17060
		[Token(Token = "0x40042A4")]
		interactableBelongsTo,
		// Token: 0x040042A5 RID: 17061
		[Token(Token = "0x40042A5")]
		thisRoom,
		// Token: 0x040042A6 RID: 17062
		[Token(Token = "0x40042A6")]
		thisAddress
	}

	// Token: 0x02000881 RID: 2177
	[Token(Token = "0x2000881")]
	public enum KeyPlacement
	{
		// Token: 0x040042A8 RID: 17064
		[Token(Token = "0x40042A8")]
		thisAddress,
		// Token: 0x040042A9 RID: 17065
		[Token(Token = "0x40042A9")]
		belongsToHome,
		// Token: 0x040042AA RID: 17066
		[Token(Token = "0x40042AA")]
		belongsToWork
	}

	// Token: 0x02000882 RID: 2178
	[Token(Token = "0x2000882")]
	[Serializable]
	public class WallFrontage
	{
		// Token: 0x060029EB RID: 10731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029EB")]
		[Address(RVA = "0xCB26D0", Offset = "0xCB16D0", VA = "0x180CB26D0")]
		public WallFrontage()
		{
		}

		// Token: 0x040042AB RID: 17067
		[Token(Token = "0x40042AB")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040042AC RID: 17068
		[Token(Token = "0x40042AC")]
		[FieldOffset(Offset = "0x18")]
		public DoorPairPreset wallPreset;

		// Token: 0x040042AD RID: 17069
		[Token(Token = "0x40042AD")]
		[FieldOffset(Offset = "0x20")]
		public List<WallFrontageClass> insideFrontage;

		// Token: 0x040042AE RID: 17070
		[Token(Token = "0x40042AE")]
		[FieldOffset(Offset = "0x28")]
		public List<WallFrontageClass> outsideFrontage;

		// Token: 0x040042AF RID: 17071
		[Token(Token = "0x40042AF")]
		[FieldOffset(Offset = "0x30")]
		public bool onlyIfBorderingOutside;

		// Token: 0x040042B0 RID: 17072
		[Token(Token = "0x40042B0")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 localOffset;

		// Token: 0x040042B1 RID: 17073
		[Token(Token = "0x40042B1")]
		[FieldOffset(Offset = "0x40")]
		public bool limitToBuildingTypes;

		// Token: 0x040042B2 RID: 17074
		[Token(Token = "0x40042B2")]
		[FieldOffset(Offset = "0x48")]
		public List<BuildingPreset> limitedToBuildings;
	}

	// Token: 0x02000883 RID: 2179
	[Token(Token = "0x2000883")]
	public enum OutsideSetting
	{
		// Token: 0x040042B4 RID: 17076
		[Token(Token = "0x40042B4")]
		dontChange,
		// Token: 0x040042B5 RID: 17077
		[Token(Token = "0x40042B5")]
		forceOutside,
		// Token: 0x040042B6 RID: 17078
		[Token(Token = "0x40042B6")]
		forceInside
	}

	// Token: 0x02000884 RID: 2180
	[Token(Token = "0x2000884")]
	public enum PrintsSource
	{
		// Token: 0x040042B8 RID: 17080
		[Token(Token = "0x40042B8")]
		owners,
		// Token: 0x040042B9 RID: 17081
		[Token(Token = "0x40042B9")]
		inhabitants,
		// Token: 0x040042BA RID: 17082
		[Token(Token = "0x40042BA")]
		buildingResidents,
		// Token: 0x040042BB RID: 17083
		[Token(Token = "0x40042BB")]
		customersAll,
		// Token: 0x040042BC RID: 17084
		[Token(Token = "0x40042BC")]
		customersMale,
		// Token: 0x040042BD RID: 17085
		[Token(Token = "0x40042BD")]
		customersFemale,
		// Token: 0x040042BE RID: 17086
		[Token(Token = "0x40042BE")]
		publicAll,
		// Token: 0x040042BF RID: 17087
		[Token(Token = "0x40042BF")]
		inhabitantsAndCustomers,
		// Token: 0x040042C0 RID: 17088
		[Token(Token = "0x40042C0")]
		writers,
		// Token: 0x040042C1 RID: 17089
		[Token(Token = "0x40042C1")]
		receivers,
		// Token: 0x040042C2 RID: 17090
		[Token(Token = "0x40042C2")]
		ownersAndWriters,
		// Token: 0x040042C3 RID: 17091
		[Token(Token = "0x40042C3")]
		ownersWritersReceivers,
		// Token: 0x040042C4 RID: 17092
		[Token(Token = "0x40042C4")]
		killer
	}
}
