using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000522 RID: 1314
[Token(Token = "0x2000522")]
public class Toolbox : MonoBehaviour
{
	// Token: 0x170000DB RID: 219
	// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001C27 RID: 7207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000DB")]
	public static GameObject PoolingGroup
	{
		[Token(Token = "0x6001C26")]
		[Address(RVA = "0x9D3090", Offset = "0x9D2090", VA = "0x1809D3090")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001C27")]
		[Address(RVA = "0x9D30D0", Offset = "0x9D20D0", VA = "0x1809D30D0")]
		private set
		{
		}
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000DC")]
	public static Toolbox Instance
	{
		[Token(Token = "0x6001C28")]
		[Address(RVA = "0x9D3170", Offset = "0x9D2170", VA = "0x1809D3170")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001C29 RID: 7209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C29")]
	[Address(RVA = "0x9D31B0", Offset = "0x9D21B0", VA = "0x1809D31B0")]
	private void Awake()
	{
	}

	// Token: 0x06001C2A RID: 7210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C2A")]
	[Address(RVA = "0x9D47F0", Offset = "0x9D37F0", VA = "0x1809D47F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001C2B RID: 7211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C2B")]
	[Address(RVA = "0x9D4A00", Offset = "0x9D3A00", VA = "0x1809D4A00")]
	private void Start()
	{
	}

	// Token: 0x06001C2C RID: 7212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C2C")]
	[Address(RVA = "0x9D5540", Offset = "0x9D4540", VA = "0x1809D5540")]
	private void LoadDDS()
	{
	}

	// Token: 0x06001C2D RID: 7213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C2D")]
	[Address(RVA = "0x9D5750", Offset = "0x9D4750", VA = "0x1809D5750")]
	public void LoadModdedDDSFiles()
	{
	}

	// Token: 0x06001C2E RID: 7214 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C2E")]
	[Address(RVA = "0x9D6790", Offset = "0x9D5790", VA = "0x1809D6790")]
	public void LoadDDSFilesFromPath(string path)
	{
	}

	// Token: 0x06001C2F RID: 7215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C2F")]
	[Address(RVA = "0x9D79D0", Offset = "0x9D69D0", VA = "0x1809D79D0")]
	public void ProcessLoadedScriptableObject(ScriptableObject so)
	{
	}

	// Token: 0x06001C30 RID: 7216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C30")]
	[Address(RVA = "0x9D9310", Offset = "0x9D8310", VA = "0x1809D9310")]
	private void LoadAll()
	{
	}

	// Token: 0x06001C31 RID: 7217 RVA: 0x0000CCD8 File Offset: 0x0000AED8
	[Token(Token = "0x6001C31")]
	[Address(RVA = "0x9DB880", Offset = "0x9DA880", VA = "0x1809DB880")]
	public bool TryReplaceInResourcesCache(ScriptableObject so)
	{
		return default(bool);
	}

	// Token: 0x06001C32 RID: 7218 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
	[Token(Token = "0x6001C32")]
	[Address(RVA = "0x9DC130", Offset = "0x9DB130", VA = "0x1809DC130")]
	public float RoundToPlaces(float input, int decimals)
	{
		return 0f;
	}

	// Token: 0x06001C33 RID: 7219 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C33")]
	[Address(RVA = "0x9DC1D0", Offset = "0x9DB1D0", VA = "0x1809DC1D0")]
	public string AddZeros(float num, int decimals)
	{
		return null;
	}

	// Token: 0x06001C34 RID: 7220 RVA: 0x0000CD08 File Offset: 0x0000AF08
	[Token(Token = "0x6001C34")]
	[Address(RVA = "0x9DC380", Offset = "0x9DB380", VA = "0x1809DC380")]
	public float RoundToPlaces(double input, int decimals)
	{
		return 0f;
	}

	// Token: 0x06001C35 RID: 7221 RVA: 0x0000CD20 File Offset: 0x0000AF20
	[Token(Token = "0x6001C35")]
	[Address(RVA = "0x9DC3F0", Offset = "0x9DB3F0", VA = "0x1809DC3F0")]
	public float TravelTimeEstimate(Human cc, NewNode origin, NewNode destination)
	{
		return 0f;
	}

	// Token: 0x06001C36 RID: 7222 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C36")]
	[Address(RVA = "0x9DCC10", Offset = "0x9DBC10", VA = "0x1809DCC10")]
	public void AddToTravelTimeRecords(Actor cc, float discrepency)
	{
	}

	// Token: 0x06001C37 RID: 7223 RVA: 0x0000CD38 File Offset: 0x0000AF38
	[Token(Token = "0x6001C37")]
	[Address(RVA = "0x9DCD70", Offset = "0x9DBD70", VA = "0x1809DCD70")]
	public int TravelTimeEstimateMinutes(Citizen cc, NewNode origin, NewNode destination)
	{
		return 0;
	}

	// Token: 0x06001C38 RID: 7224 RVA: 0x0000CD50 File Offset: 0x0000AF50
	[Token(Token = "0x6001C38")]
	[Address(RVA = "0x9DCDA0", Offset = "0x9DBDA0", VA = "0x1809DCDA0")]
	public float RandomRangeWeighted(float minimum, float maximum, float weightedValue, int stepResolution = 5)
	{
		return 0f;
	}

	// Token: 0x06001C39 RID: 7225 RVA: 0x0000CD68 File Offset: 0x0000AF68
	[Token(Token = "0x6001C39")]
	[Address(RVA = "0x9DCE90", Offset = "0x9DBE90", VA = "0x1809DCE90")]
	public float RandomRangeWeightedSeedContained(float minimum, float maximum, float weightedValue, ref string inputSeed, int stepResolution = 5)
	{
		return 0f;
	}

	// Token: 0x06001C3A RID: 7226 RVA: 0x0000CD80 File Offset: 0x0000AF80
	[Token(Token = "0x6001C3A")]
	[Address(RVA = "0x9DD010", Offset = "0x9DC010", VA = "0x1809DD010")]
	public float MinDistanceFromPath(NewNode pathOrigin, NewNode pathDestination, Vector3 inputPosition)
	{
		return 0f;
	}

	// Token: 0x06001C3B RID: 7227 RVA: 0x0000CD98 File Offset: 0x0000AF98
	[Token(Token = "0x6001C3B")]
	[Address(RVA = "0x9DD3E0", Offset = "0x9DC3E0", VA = "0x1809DD3E0")]
	public Rect RectTransformToScreenSpace(RectTransform transform)
	{
		return default(Rect);
	}

	// Token: 0x06001C3C RID: 7228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C3C")]
	[Address(RVA = "0x9DD750", Offset = "0x9DC750", VA = "0x1809DD750")]
	public void InvokeEndOfFrame(Action action, string newDebug)
	{
	}

	// Token: 0x06001C3D RID: 7229 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C3D")]
	[Address(RVA = "0x9DD8F0", Offset = "0x9DC8F0", VA = "0x1809DD8F0")]
	private IEnumerator ExeEndOfFrame()
	{
		return null;
	}

	// Token: 0x06001C3E RID: 7230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C3E")]
	[Address(RVA = "0x9DD990", Offset = "0x9DC990", VA = "0x1809DD990")]
	public void UpdateButtonListPositions(List<ButtonController> buttons, float edgeMargin = 5f, float iconMargin = 4f)
	{
	}

	// Token: 0x06001C3F RID: 7231 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
	[Token(Token = "0x6001C3F")]
	[Address(RVA = "0x9DDF00", Offset = "0x9DCF00", VA = "0x1809DDF00")]
	public bool GameTimeRangeOverlap(Vector2 range1, Vector2 range2, bool equalsIsOverlapping = true)
	{
		return default(bool);
	}

	// Token: 0x06001C40 RID: 7232 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
	[Token(Token = "0x6001C40")]
	[Address(RVA = "0x9DDF60", Offset = "0x9DCF60", VA = "0x1809DDF60")]
	public bool DecimalTimeRangeOverlap(Vector2 range1, Vector2 range2, bool equalsIsOverlapping = true)
	{
		return default(bool);
	}

	// Token: 0x06001C41 RID: 7233 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
	[Token(Token = "0x6001C41")]
	[Address(RVA = "0x9DDFE0", Offset = "0x9DCFE0", VA = "0x1809DDFE0")]
	public Vector2 RotateVector2ACW(Vector2 v, float degrees)
	{
		return default(Vector2);
	}

	// Token: 0x06001C42 RID: 7234 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
	[Token(Token = "0x6001C42")]
	[Address(RVA = "0x59E4D0", Offset = "0x59D4D0", VA = "0x18059E4D0")]
	public Vector2 RotateVector2CW(Vector2 v, float degrees)
	{
		return default(Vector2);
	}

	// Token: 0x06001C43 RID: 7235 RVA: 0x0000CE10 File Offset: 0x0000B010
	[Token(Token = "0x6001C43")]
	[Address(RVA = "0x9DE060", Offset = "0x9DD060", VA = "0x1809DE060")]
	public Descriptors.EthnicGroup RandomEthnicGroup(ref string seed)
	{
		return Descriptors.EthnicGroup.westEuropean;
	}

	// Token: 0x06001C44 RID: 7236 RVA: 0x0000CE28 File Offset: 0x0000B028
	[Token(Token = "0x6001C44")]
	[Address(RVA = "0x9DE120", Offset = "0x9DD120", VA = "0x1809DE120")]
	public Color GetRenderTexturePixel(RenderTexture rt)
	{
		return default(Color);
	}

	// Token: 0x06001C45 RID: 7237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C45")]
	[Address(RVA = "0x9DE360", Offset = "0x9DD360", VA = "0x1809DE360")]
	public void SetLightLayer(GameObject objectWithMesh, NewBuilding building, bool includeStreetLighting = false)
	{
	}

	// Token: 0x06001C46 RID: 7238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C46")]
	[Address(RVA = "0x9DE440", Offset = "0x9DD440", VA = "0x1809DE440")]
	public void SetLightLayer(MeshRenderer meshRend, NewBuilding building, bool includeStreetLighting = false)
	{
	}

	// Token: 0x06001C47 RID: 7239 RVA: 0x0000CE40 File Offset: 0x0000B040
	[Token(Token = "0x6001C47")]
	public bool LoadDataFromResources<T>(string searchName, out T output) where T : ScriptableObject
	{
		return default(bool);
	}

	// Token: 0x06001C48 RID: 7240 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C48")]
	public List<T> GetList<T>(T[] elements)
	{
		return null;
	}

	// Token: 0x06001C49 RID: 7241 RVA: 0x0000CE58 File Offset: 0x0000B058
	[Token(Token = "0x6001C49")]
	[Address(RVA = "0x9DE660", Offset = "0x9DD660", VA = "0x1809DE660")]
	public float HeuristicCostEstimate(NewNode start, NewNode goal)
	{
		return 0f;
	}

	// Token: 0x06001C4A RID: 7242 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C4A")]
	[Address(RVA = "0x9DE740", Offset = "0x9DD740", VA = "0x1809DE740")]
	public List<NewNode> ConstructPathAccurate(Dictionary<NewNode, NewNode> cameFrom, NewNode current)
	{
		return null;
	}

	// Token: 0x06001C4B RID: 7243 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C4B")]
	[Address(RVA = "0x9DE910", Offset = "0x9DD910", VA = "0x1809DE910")]
	public Evidence GetOrCreateEvidenceForInteractable(InteractablePreset preset, string newID, Interactable interactable, Human belongsTo, Human writer, Human reciever, SideJob jobParent, NewGameLocation gameLocation, RetailItemPreset retailItem, List<Interactable.Passed> passedVars)
	{
		return null;
	}

	// Token: 0x06001C4C RID: 7244 RVA: 0x0000CE70 File Offset: 0x0000B070
	[Token(Token = "0x6001C4C")]
	[Address(RVA = "0x9DF680", Offset = "0x9DE680", VA = "0x1809DF680")]
	public bool TryGetEvidence(string evID, out Evidence evidence)
	{
		return default(bool);
	}

	// Token: 0x06001C4D RID: 7245 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C4D")]
	[Address(RVA = "0x9DFE30", Offset = "0x9DEE30", VA = "0x1809DFE30")]
	public Interactable SpawnSpareKey(NewAddress ad, [Optional] string loadGUID)
	{
		return null;
	}

	// Token: 0x06001C4E RID: 7246 RVA: 0x0000CE88 File Offset: 0x0000B088
	[Token(Token = "0x6001C4E")]
	[Address(RVA = "0x9E12A0", Offset = "0x9E02A0", VA = "0x1809E12A0")]
	public float GetAngleForOffset(Vector2 offset1)
	{
		return 0f;
	}

	// Token: 0x06001C4F RID: 7247 RVA: 0x0000CEA0 File Offset: 0x0000B0A0
	[Token(Token = "0x6001C4F")]
	[Address(RVA = "0x9E1370", Offset = "0x9E0370", VA = "0x1809E1370")]
	public Vector2 GetOffsetFromAngle(int angle)
	{
		return default(Vector2);
	}

	// Token: 0x06001C50 RID: 7248 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
	[Token(Token = "0x6001C50")]
	[Address(RVA = "0x9E1470", Offset = "0x9E0470", VA = "0x1809E1470")]
	public float GetAngleBetween(Vector3 origin, Vector3 lookAt)
	{
		return 0f;
	}

	// Token: 0x06001C51 RID: 7249 RVA: 0x0000CED0 File Offset: 0x0000B0D0
	[Token(Token = "0x6001C51")]
	[Address(RVA = "0x9E15B0", Offset = "0x9E05B0", VA = "0x1809E15B0")]
	private Vector3 GetAveragePosition(List<NewNode> nodes)
	{
		return default(Vector3);
	}

	// Token: 0x06001C52 RID: 7250 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
	[Token(Token = "0x6001C52")]
	[Address(RVA = "0x9E17F0", Offset = "0x9E07F0", VA = "0x1809E17F0")]
	public bool IsWorkDay(int day, Citizen cit)
	{
		return default(bool);
	}

	// Token: 0x06001C53 RID: 7251 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C53")]
	[Address(RVA = "0x9E1940", Offset = "0x9E0940", VA = "0x1809E1940")]
	public Interactable FindNearestWithAction(AIActionPreset action, NewRoom startRoom, Human person, AIActionPreset.FindSetting findSetting, bool overrideWithHome = true, [Optional] HashSet<NewRoom> ignore, [Optional] NewGameLocation restrictTo, [Optional] NewBuilding restrictToBuilding, bool useSpecialCasesOnly = false, InteractablePreset.SpecialCase mustBeSpecial = InteractablePreset.SpecialCase.none, bool filterWithRoomType = false, [Optional] List<RoomTypePreset> roomTypeFilter, bool preferUnused = true, bool enforcersAllowedEverywhere = false, float robberyPriority = 0f, [Optional] List<Interactable> avoidInteractables, [Optional] List<InteractablePreset> shopItems, bool printDebug = false, bool mustContainDesireCategory = false, CompanyPreset.CompanyCategory containDesireCategory = CompanyPreset.CompanyCategory.meal, bool excludeAIUsingThis = false, bool useToiletSettings = false)
	{
		return null;
	}

	// Token: 0x06001C54 RID: 7252 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C54")]
	[Address(RVA = "0x9E4810", Offset = "0x9E3810", VA = "0x1809E4810")]
	public Company FindNearestThatSells(InteractablePreset sellsItem, NewGameLocation startLocation, bool checkOpen = true)
	{
		return null;
	}

	// Token: 0x06001C55 RID: 7253 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C55")]
	[Address(RVA = "0x9E4E60", Offset = "0x9E3E60", VA = "0x1809E4E60")]
	public string GetNumbericalStringReference(int number)
	{
		return null;
	}

	// Token: 0x06001C56 RID: 7254 RVA: 0x0000CF00 File Offset: 0x0000B100
	[Token(Token = "0x6001C56")]
	[Address(RVA = "0x9E51B0", Offset = "0x9E41B0", VA = "0x1809E51B0")]
	public Vector2 Rotate(Vector2 aPoint, float aDegree)
	{
		return default(Vector2);
	}

	// Token: 0x06001C57 RID: 7255 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C57")]
	[Address(RVA = "0x9E53C0", Offset = "0x9E43C0", VA = "0x1809E53C0")]
	public List<Vector2> PlotLine(Vector2 point1, Vector2 point2)
	{
		return null;
	}

	// Token: 0x06001C58 RID: 7256 RVA: 0x0000CF18 File Offset: 0x0000B118
	[Token(Token = "0x6001C58")]
	[Address(RVA = "0x9E5680", Offset = "0x9E4680", VA = "0x1809E5680")]
	public Quaternion ClampRotation(Quaternion q, float minimumUpDown, float maximumUpDown, float minimumLeftRight, float maximumLeftRight)
	{
		return default(Quaternion);
	}

	// Token: 0x06001C59 RID: 7257 RVA: 0x0000CF30 File Offset: 0x0000B130
	[Token(Token = "0x6001C59")]
	[Address(RVA = "0x9E5770", Offset = "0x9E4770", VA = "0x1809E5770")]
	public float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}

	// Token: 0x06001C5A RID: 7258 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C5A")]
	[Address(RVA = "0x9E57E0", Offset = "0x9E47E0", VA = "0x1809E57E0")]
	public void ShuffleList(ref List<CharacterTrait> list)
	{
	}

	// Token: 0x06001C5B RID: 7259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C5B")]
	[Address(RVA = "0x9E5980", Offset = "0x9E4980", VA = "0x1809E5980")]
	public void ShuffleListSeedContained(ref List<CharacterTrait> list, string input, out string output)
	{
	}

	// Token: 0x06001C5C RID: 7260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C5C")]
	[Address(RVA = "0x9E5B70", Offset = "0x9E4B70", VA = "0x1809E5B70")]
	public void ShuffleList(ref List<Human.WalletItem> list)
	{
	}

	// Token: 0x06001C5D RID: 7261 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C5D")]
	[Address(RVA = "0x9E5D50", Offset = "0x9E4D50", VA = "0x1809E5D50")]
	public GameObject SpawnObject(GameObject newObj, Transform newParent)
	{
		return null;
	}

	// Token: 0x06001C5E RID: 7262 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C5E")]
	[Address(RVA = "0x9E5DD0", Offset = "0x9E4DD0", VA = "0x1809E5DD0")]
	public GameObject SpawnObject(GameObject newObj, Vector3 newPos, Quaternion newRot, Transform newParent)
	{
		return null;
	}

	// Token: 0x06001C5F RID: 7263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C5F")]
	[Address(RVA = "0x9E5E80", Offset = "0x9E4E80", VA = "0x1809E5E80")]
	public void DestroyObject(GameObject newObj)
	{
	}

	// Token: 0x06001C60 RID: 7264 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C60")]
	[Address(RVA = "0x9E5FA0", Offset = "0x9E4FA0", VA = "0x1809E5FA0")]
	public Material SpawnMaterial(Material newObj)
	{
		return null;
	}

	// Token: 0x06001C61 RID: 7265 RVA: 0x0000CF48 File Offset: 0x0000B148
	[Token(Token = "0x6001C61")]
	[Address(RVA = "0x9E6010", Offset = "0x9E5010", VA = "0x1809E6010")]
	public Vector3 GetLocalEulerAtRotation(Transform transform, Quaternion targetRotation)
	{
		return default(Vector3);
	}

	// Token: 0x06001C62 RID: 7266 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C62")]
	[Address(RVA = "0x9E62F0", Offset = "0x9E52F0", VA = "0x1809E62F0")]
	public List<int> GetKeyCodeFromString(string str)
	{
		return null;
	}

	// Token: 0x06001C63 RID: 7267 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C63")]
	[Address(RVA = "0x9E6D20", Offset = "0x9E5D20", VA = "0x1809E6D20")]
	public string GenerateEvidenceIdentifier(Evidence ev)
	{
		return null;
	}

	// Token: 0x06001C64 RID: 7268 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C64")]
	[Address(RVA = "0x9E6F00", Offset = "0x9E5F00", VA = "0x1809E6F00")]
	public string GenerateUniqueID()
	{
		return null;
	}

	// Token: 0x06001C65 RID: 7269 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C65")]
	[Address(RVA = "0x9E6F90", Offset = "0x9E5F90", VA = "0x1809E6F90")]
	public Interactable FindClosestObjectTo(InteractablePreset objectType, Vector3 closestTo, NewBuilding constrainToBuilding, NewGameLocation constrainToLocation, NewRoom constrainToRoom, out float distance, bool publicOnly = false)
	{
		return null;
	}

	// Token: 0x06001C66 RID: 7270 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C66")]
	[Address(RVA = "0x9E8390", Offset = "0x9E7390", VA = "0x1809E8390")]
	public FurnitureLocation FindFurnitureWithinGameLocation(NewGameLocation location, FurnitureClass furnitureClass, out NewRoom room)
	{
		return null;
	}

	// Token: 0x06001C67 RID: 7271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C67")]
	[Address(RVA = "0x9E87A0", Offset = "0x9E77A0", VA = "0x1809E87A0")]
	public void SetRectSize(RectTransform trs, float left, float top, float right, float bottom)
	{
	}

	// Token: 0x06001C68 RID: 7272 RVA: 0x0000CF60 File Offset: 0x0000B160
	[Token(Token = "0x6001C68")]
	[Address(RVA = "0x9E8810", Offset = "0x9E7810", VA = "0x1809E8810")]
	public Rect GetWorldRect(RectTransform rt, Vector2 scale)
	{
		return default(Rect);
	}

	// Token: 0x06001C69 RID: 7273 RVA: 0x0000CF78 File Offset: 0x0000B178
	[Token(Token = "0x6001C69")]
	[Address(RVA = "0x9E8990", Offset = "0x9E7990", VA = "0x1809E8990")]
	public int CreateLayerMask(Toolbox.LayerMaskMode castMode, int[] aLayers)
	{
		return 0;
	}

	// Token: 0x06001C6A RID: 7274 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C6A")]
	[Address(RVA = "0x9E89F0", Offset = "0x9E79F0", VA = "0x1809E89F0")]
	public NewNode FindClosestValidNodeToWorldPosition(Vector3 worldPos, bool onlyAccessibleNodes = false, bool checkUpAndDown = true, bool limitToDirection = false, [Optional] Vector3Int limitedDirection, bool limitToFloor = false, int limitedToFloor = 0, bool outsideOnly = false, int safety = 200)
	{
		return null;
	}

	// Token: 0x06001C6B RID: 7275 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C6B")]
	[Address(RVA = "0x9E9670", Offset = "0x9E8670", VA = "0x1809E9670")]
	public MaterialGroupPreset GetMaterialProperties(Material mat)
	{
		return null;
	}

	// Token: 0x06001C6C RID: 7276 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C6C")]
	[Address(RVA = "0x9E9730", Offset = "0x9E8730", VA = "0x1809E9730")]
	public FurniturePreset GetFurnitureFromMesh(Mesh mesh)
	{
		return null;
	}

	// Token: 0x06001C6D RID: 7277 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C6D")]
	[Address(RVA = "0x9E9880", Offset = "0x9E8880", VA = "0x1809E9880")]
	public FurniturePreset GetFurnitureFromGameObject(NewNode currentNode, GameObject gameObj)
	{
		return null;
	}

	// Token: 0x06001C6E RID: 7278 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C6E")]
	[Address(RVA = "0x9E9E30", Offset = "0x9E8E30", VA = "0x1809E9E30")]
	public InteractablePreset GetInteractablePreset(string interactableName)
	{
		return null;
	}

	// Token: 0x06001C6F RID: 7279 RVA: 0x0000CF90 File Offset: 0x0000B190
	[Token(Token = "0x6001C6F")]
	[Address(RVA = "0x9E9ED0", Offset = "0x9E8ED0", VA = "0x1809E9ED0")]
	public Quaternion TransformRotation(Quaternion worldRotation, Transform targetsLocal)
	{
		return default(Quaternion);
	}

	// Token: 0x06001C70 RID: 7280 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
	[Token(Token = "0x6001C70")]
	[Address(RVA = "0x9E9ED0", Offset = "0x9E8ED0", VA = "0x1809E9ED0")]
	public Quaternion InverseTransformRotation(Quaternion localRotation, Transform target)
	{
		return default(Quaternion);
	}

	// Token: 0x06001C71 RID: 7281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C71")]
	[Address(RVA = "0x9EA140", Offset = "0x9E9140", VA = "0x1809EA140")]
	public void Shoot(Actor fromThis, Vector3 muzzlePoint, Vector3 aimPoint, float aimRange, float accuracy, float damage, MurderWeaponPreset weapon, bool ejectBrass, Vector3 ejectBrassPoint, bool forcePhysicsEjectBrass, bool firstShot = true)
	{
	}

	// Token: 0x06001C72 RID: 7282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C72")]
	[Address(RVA = "0x9EBC20", Offset = "0x9EAC20", VA = "0x1809EBC20")]
	public void CreateBulletSurfaceContactFX(MurderWeaponPreset weapon, RaycastHit hit)
	{
	}

	// Token: 0x06001C73 RID: 7283 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
	[Token(Token = "0x6001C73")]
	[Address(RVA = "0x9EC190", Offset = "0x9EB190", VA = "0x1809EC190")]
	public float GetPsuedoRandomNumber(float lowerRange, float upperRange, ref string seedInput, bool updateLastKey = false, bool addCitySeed = false)
	{
		return 0f;
	}

	// Token: 0x06001C74 RID: 7284 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
	[Token(Token = "0x6001C74")]
	[Address(RVA = "0x9EC610", Offset = "0x9EB610", VA = "0x1809EC610")]
	public int GetPsuedoRandomNumber(int lowerRange, int upperRange, ref string seedInput, bool updateLastKey = false, bool addCitySeed = false)
	{
		return 0;
	}

	// Token: 0x06001C75 RID: 7285 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
	[Token(Token = "0x6001C75")]
	[Address(RVA = "0x9ECAB0", Offset = "0x9EBAB0", VA = "0x1809ECAB0")]
	public float GetPsuedoRandomNumber(float lowerRange, float upperRange, ref int seedInput, bool updateLastKey = false, bool addCitySeed = false)
	{
		return 0f;
	}

	// Token: 0x06001C76 RID: 7286 RVA: 0x0000D008 File Offset: 0x0000B208
	[Token(Token = "0x6001C76")]
	[Address(RVA = "0x9ECEE0", Offset = "0x9EBEE0", VA = "0x1809ECEE0")]
	public int GetPsuedoRandomNumber(int lowerRange, int upperRange, ref int seedInput, bool updateLastKey = false, bool addCitySeed = false)
	{
		return 0;
	}

	// Token: 0x06001C77 RID: 7287 RVA: 0x0000D020 File Offset: 0x0000B220
	[Token(Token = "0x6001C77")]
	[Address(RVA = "0x9ED340", Offset = "0x9EC340", VA = "0x1809ED340")]
	public float Rand(float min, float max, bool definitelyNotPartOfCityGeneration = false)
	{
		return 0f;
	}

	// Token: 0x06001C78 RID: 7288 RVA: 0x0000D038 File Offset: 0x0000B238
	[Token(Token = "0x6001C78")]
	[Address(RVA = "0x9ED530", Offset = "0x9EC530", VA = "0x1809ED530")]
	public int Rand(int min, int max, bool definitelyNotPartOfCityGeneration = false)
	{
		return 0;
	}

	// Token: 0x06001C79 RID: 7289 RVA: 0x0000D050 File Offset: 0x0000B250
	[Token(Token = "0x6001C79")]
	[Address(RVA = "0x9ED740", Offset = "0x9EC740", VA = "0x1809ED740")]
	public float SeedRand(float min, float max)
	{
		return 0f;
	}

	// Token: 0x06001C7A RID: 7290 RVA: 0x0000D068 File Offset: 0x0000B268
	[Token(Token = "0x6001C7A")]
	[Address(RVA = "0x9ED950", Offset = "0x9EC950", VA = "0x1809ED950")]
	public int SeedRand(int min, int max)
	{
		return 0;
	}

	// Token: 0x06001C7B RID: 7291 RVA: 0x0000D080 File Offset: 0x0000B280
	[Token(Token = "0x6001C7B")]
	[Address(RVA = "0x9EDAF0", Offset = "0x9ECAF0", VA = "0x1809EDAF0")]
	public float VectorToRandom(Vector2 vec)
	{
		return 0f;
	}

	// Token: 0x06001C7C RID: 7292 RVA: 0x0000D098 File Offset: 0x0000B298
	[Token(Token = "0x6001C7C")]
	[Address(RVA = "0x9EDB20", Offset = "0x9ECB20", VA = "0x1809EDB20")]
	public float VectorToRandomSeedContained(Vector2 vec, ref string seedInput)
	{
		return 0f;
	}

	// Token: 0x06001C7D RID: 7293 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
	[Token(Token = "0x6001C7D")]
	[Address(RVA = "0x9EDB50", Offset = "0x9ECB50", VA = "0x1809EDB50")]
	public float RandContained(float min, float max, ref string seedInput)
	{
		return 0f;
	}

	// Token: 0x06001C7E RID: 7294 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
	[Token(Token = "0x6001C7E")]
	[Address(RVA = "0x9EDB60", Offset = "0x9ECB60", VA = "0x1809EDB60")]
	public int RandContained(int min, int max, ref string seedInput)
	{
		return 0;
	}

	// Token: 0x06001C7F RID: 7295 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
	[Token(Token = "0x6001C7F")]
	[Address(RVA = "0x9EDB70", Offset = "0x9ECB70", VA = "0x1809EDB70")]
	public float GetPsuedoRandomNumberContained(float lowerRange, float upperRange, ref string seedInput)
	{
		return 0f;
	}

	// Token: 0x06001C80 RID: 7296 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
	[Token(Token = "0x6001C80")]
	[Address(RVA = "0x9EDD80", Offset = "0x9ECD80", VA = "0x1809EDD80")]
	public int GetPsuedoRandomNumberContained(int lowerRange, int upperRange, ref string seedInput)
	{
		return 0;
	}

	// Token: 0x06001C81 RID: 7297 RVA: 0x0000D110 File Offset: 0x0000B310
	[Token(Token = "0x6001C81")]
	[Address(RVA = "0x9EDFD0", Offset = "0x9ECFD0", VA = "0x1809EDFD0")]
	public bool DDSTraitConditionLogicAcquaintance(Human thisPerson, Acquaintance acquaintance, DDSSaveClasses.TraitConditionType logic, ref List<string> traitList)
	{
		return default(bool);
	}

	// Token: 0x06001C82 RID: 7298 RVA: 0x0000D128 File Offset: 0x0000B328
	[Token(Token = "0x6001C82")]
	[Address(RVA = "0x9EE030", Offset = "0x9ED030", VA = "0x1809EE030")]
	public bool DDSTraitConditionLogic(Human thisPerson, Human otherPerson, DDSSaveClasses.TraitConditionType logic, ref List<string> traitList)
	{
		return default(bool);
	}

	// Token: 0x06001C83 RID: 7299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C83")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void LoadInteractableToWorld()
	{
	}

	// Token: 0x06001C84 RID: 7300 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C84")]
	[Address(RVA = "0x9EE720", Offset = "0x9ED720", VA = "0x1809EE720")]
	public string ToBase26(int myNumber)
	{
		return null;
	}

	// Token: 0x06001C85 RID: 7301 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C85")]
	[Address(RVA = "0x9EE9D0", Offset = "0x9ED9D0", VA = "0x1809EE9D0")]
	public string GenerateSeed(int digits = 16, bool useSeed = false, string newSeed = "")
	{
		return null;
	}

	// Token: 0x06001C86 RID: 7302 RVA: 0x0000D140 File Offset: 0x0000B340
	[Token(Token = "0x6001C86")]
	[Address(RVA = "0x9EEC50", Offset = "0x9EDC50", VA = "0x1809EEC50")]
	public bool RaycastCheck(Transform from, Transform to, float maxRange, out RaycastHit hit)
	{
		return default(bool);
	}

	// Token: 0x06001C87 RID: 7303 RVA: 0x0000D158 File Offset: 0x0000B358
	[Token(Token = "0x6001C87")]
	[Address(RVA = "0x9EED30", Offset = "0x9EDD30", VA = "0x1809EED30")]
	public bool RaycastCheck(Vector3 from, Transform to, float maxRange, out RaycastHit hit)
	{
		return default(bool);
	}

	// Token: 0x06001C88 RID: 7304 RVA: 0x0000D170 File Offset: 0x0000B370
	[Token(Token = "0x6001C88")]
	[Address(RVA = "0x9EF090", Offset = "0x9EE090", VA = "0x1809EF090")]
	public bool RaycastCheck(Vector3 from, Collider to, float maxRange, out RaycastHit hit)
	{
		return default(bool);
	}

	// Token: 0x06001C89 RID: 7305 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C89")]
	[Address(RVA = "0x9EF3A0", Offset = "0x9EE3A0", VA = "0x1809EF3A0")]
	public void SetPivot(RectTransform rectTransform, Vector2 pivot)
	{
	}

	// Token: 0x06001C8A RID: 7306 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C8A")]
	[Address(RVA = "0x9EF830", Offset = "0x9EE830", VA = "0x1809EF830")]
	public void SetAnchor(RectTransform rectTransform, Vector2 anchorMin, Vector2 anchorMax)
	{
	}

	// Token: 0x06001C8B RID: 7307 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C8B")]
	[Address(RVA = "0x9EF9C0", Offset = "0x9EE9C0", VA = "0x1809EF9C0")]
	public Transform[] GetAllTransforms(Transform t)
	{
		return null;
	}

	// Token: 0x06001C8C RID: 7308 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C8C")]
	[Address(RVA = "0x9EFA10", Offset = "0x9EEA10", VA = "0x1809EFA10")]
	public Transform SearchForTransform(Transform parent, string search, bool printDebug = false)
	{
		return null;
	}

	// Token: 0x06001C8D RID: 7309 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C8D")]
	[Address(RVA = "0x9EFF50", Offset = "0x9EEF50", VA = "0x1809EFF50")]
	public List<Transform> GetTagsWithinTransform(Transform parent, string tag)
	{
		return null;
	}

	// Token: 0x06001C8E RID: 7310 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C8E")]
	[Address(RVA = "0x9F0090", Offset = "0x9EF090", VA = "0x1809F0090")]
	public void NewVmailThread(Human from, List<Human> otherParticipiants, string treeID, float timeStamp, int progress = 999, StateSaveData.CustomDataSource overrideDataSource = StateSaveData.CustomDataSource.sender, int newDataSourceID = -1)
	{
	}

	// Token: 0x06001C8F RID: 7311 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C8F")]
	[Address(RVA = "0x9F02D0", Offset = "0x9EF2D0", VA = "0x1809F02D0")]
	public StateSaveData.MessageThreadSave NewVmailThread(Human from, Human to1, Human to2, Human to3, List<Human> cc, string treeID, float timeStamp, int progress = 999, StateSaveData.CustomDataSource overrideDataSource = StateSaveData.CustomDataSource.sender, int newDataSourceID = -1)
	{
		return null;
	}

	// Token: 0x06001C90 RID: 7312 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C90")]
	[Address(RVA = "0x9F1500", Offset = "0x9F0500", VA = "0x1809F1500")]
	public List<Human.DDSRank> GetMessageTreeLinkRankings(StateSaveData.MessageThreadSave thread, DDSSaveClasses.DDSMessageSettings thisMsg)
	{
		return null;
	}

	// Token: 0x06001C91 RID: 7313 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C91")]
	[Address(RVA = "0x9F1D80", Offset = "0x9F0D80", VA = "0x1809F1D80")]
	public void ProgressVmailThread(StateSaveData.MessageThreadSave thread, int addProgress)
	{
	}

	// Token: 0x06001C92 RID: 7314 RVA: 0x0000D188 File Offset: 0x0000B388
	[Token(Token = "0x6001C92")]
	[Address(RVA = "0x9F25B0", Offset = "0x9F15B0", VA = "0x1809F25B0")]
	public bool GetVmailParticipant(Human initiator, DDSSaveClasses.DDSParticipant participant, List<Human> banned, out Human chosen)
	{
		return default(bool);
	}

	// Token: 0x06001C93 RID: 7315 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C93")]
	[Address(RVA = "0x9F3170", Offset = "0x9F2170", VA = "0x1809F3170")]
	public MaterialGroupPreset SelectMaterial(RoomClassPreset roomType, float wealthLevel, DesignStylePreset designStyle, MaterialGroupPreset.MaterialType materialType, ref string seedInput)
	{
		return null;
	}

	// Token: 0x06001C94 RID: 7316 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C94")]
	[Address(RVA = "0x9F3A30", Offset = "0x9F2A30", VA = "0x1809F3A30")]
	public WallFrontagePreset SelectWallFrontage(DesignStylePreset designStyle, WallFrontageClass frontageClass, string seed)
	{
		return null;
	}

	// Token: 0x06001C95 RID: 7317 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
	[Token(Token = "0x6001C95")]
	[Address(RVA = "0x9F3C40", Offset = "0x9F2C40", VA = "0x1809F3C40")]
	public float GetNormalizedLandValue(NewGameLocation location, bool print = false)
	{
		return 0f;
	}

	// Token: 0x06001C96 RID: 7318 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
	[Token(Token = "0x6001C96")]
	[Address(RVA = "0x9F4210", Offset = "0x9F3210", VA = "0x1809F4210")]
	public float GetNormalizedLandValue(NewBuilding location)
	{
		return 0f;
	}

	// Token: 0x06001C97 RID: 7319 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C97")]
	[Address(RVA = "0x9F4240", Offset = "0x9F3240", VA = "0x1809F4240")]
	public List<Human> GetFingerprintOwnerPool(NewRoom room, FurnitureLocation furn, Interactable inter, RoomConfiguration.PrintsSource source, Vector3 worldPos, bool forceFind)
	{
		return null;
	}

	// Token: 0x06001C98 RID: 7320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C98")]
	[Address(RVA = "0x9F62C0", Offset = "0x9F52C0", VA = "0x1809F62C0")]
	public void SpawnWindowAfterSeconds(Evidence ev, float after)
	{
	}

	// Token: 0x06001C99 RID: 7321 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C99")]
	[Address(RVA = "0x9F6380", Offset = "0x9F5380", VA = "0x1809F6380")]
	private IEnumerator SpawnTelephoneEntryWindow(Evidence ev, float after)
	{
		return null;
	}

	// Token: 0x06001C9A RID: 7322 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C9A")]
	[Address(RVA = "0x9F6420", Offset = "0x9F5420", VA = "0x1809F6420")]
	public CityInfoData GenerateCityInfoFile(FileInfo citySave)
	{
		return null;
	}

	// Token: 0x06001C9B RID: 7323 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C9B")]
	[Address(RVA = "0x9F6DB0", Offset = "0x9F5DB0", VA = "0x1809F6DB0")]
	public string GetTelephoneNumberString(int number)
	{
		return null;
	}

	// Token: 0x06001C9C RID: 7324 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
	[Token(Token = "0x6001C9C")]
	[Address(RVA = "0x9F6F30", Offset = "0x9F5F30", VA = "0x1809F6F30")]
	public int GetLockpicksNeeded(float lockStrength)
	{
		return 0;
	}

	// Token: 0x06001C9D RID: 7325 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
	[Token(Token = "0x6001C9D")]
	[Address(RVA = "0x9F70B0", Offset = "0x9F60B0", VA = "0x1809F70B0")]
	public Vector2 CreateTimeRange(float actualTime, float accuracyMargin, bool limitToNow, bool round, int roundToMinutes)
	{
		return default(Vector2);
	}

	// Token: 0x06001C9E RID: 7326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C9E")]
	[Address(RVA = "0x9F7270", Offset = "0x9F6270", VA = "0x1809F7270")]
	public void ScrollScrollRectOLD(CustomScrollRect scrollRect, Vector3 targetPos, bool allowHorizontal, bool allowVertical, float timeTaken = 0.2f, float extraScrollThreshold = 0.2f)
	{
	}

	// Token: 0x06001C9F RID: 7327 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C9F")]
	[Address(RVA = "0x9F7380", Offset = "0x9F6380", VA = "0x1809F7380")]
	private IEnumerator ExecuteScrollScrollRectOLD(CustomScrollRect scrollRect, Vector3 targetPos, bool allowHorizontal, bool allowVertical, float timeTaken = 0.2f, float extraScrollThreshold = 0.2f)
	{
		return null;
	}

	// Token: 0x06001CA0 RID: 7328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CA0")]
	[Address(RVA = "0x9F7470", Offset = "0x9F6470", VA = "0x1809F7470")]
	public void ScrollRectPosition(CustomScrollRect scrollRect, RectTransform target, bool allowHorizontal, bool allowVertical, float timeTaken = 0.2f)
	{
	}

	// Token: 0x06001CA1 RID: 7329 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CA1")]
	[Address(RVA = "0x9F7EA0", Offset = "0x9F6EA0", VA = "0x1809F7EA0")]
	private IEnumerator LerpScrollRect(CustomScrollRect scrollRect, Vector2 anchoredPos, float timeTaken = 0.2f)
	{
		return null;
	}

	// Token: 0x06001CA2 RID: 7330 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CA2")]
	[Address(RVA = "0x9F7F70", Offset = "0x9F6F70", VA = "0x1809F7F70")]
	public NewNode PickNearbyNode(NewNode toThis)
	{
		return null;
	}

	// Token: 0x06001CA3 RID: 7331 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CA3")]
	[Address(RVA = "0x9F8630", Offset = "0x9F7630", VA = "0x1809F8630")]
	public NewNode GetDoorSideNode(NewNode currentNode, NewDoor door)
	{
		return null;
	}

	// Token: 0x06001CA4 RID: 7332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CA4")]
	[Address(RVA = "0x9F9410", Offset = "0x9F8410", VA = "0x1809F9410")]
	public void TestTimeRangeOverlap()
	{
	}

	// Token: 0x06001CA5 RID: 7333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CA5")]
	[Address(RVA = "0x9F94C0", Offset = "0x9F84C0", VA = "0x1809F94C0")]
	public void AutomaticNavigationSetup(ref List<Button> selectables, float differenceBuffer = 2f)
	{
	}

	// Token: 0x06001CA6 RID: 7334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CA6")]
	[Address(RVA = "0x9F9D50", Offset = "0x9F8D50", VA = "0x1809F9D50")]
	public void AddNavigationInput(Selectable selectable, [Optional] Selectable newLeft, [Optional] Selectable newRight, [Optional] Selectable newUp, [Optional] Selectable newDown, bool clearOld = false)
	{
	}

	// Token: 0x06001CA7 RID: 7335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CA7")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public static void SetTextureImporterFormat(Texture2D texture, bool isReadable)
	{
	}

	// Token: 0x06001CA8 RID: 7336 RVA: 0x0000D200 File Offset: 0x0000B400
	[Token(Token = "0x6001CA8")]
	[Address(RVA = "0x9FA4D0", Offset = "0x9F94D0", VA = "0x1809FA4D0")]
	public bool GetRelocateAuthority(Actor actor, Interactable obj)
	{
		return default(bool);
	}

	// Token: 0x06001CA9 RID: 7337 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CA9")]
	[Address(RVA = "0x9FAB30", Offset = "0x9F9B30", VA = "0x1809FAB30")]
	public NewNode GetNearestGroundLevelOutside(Vector3 pos)
	{
		return null;
	}

	// Token: 0x06001CAA RID: 7338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CAA")]
	[Address(RVA = "0x9FABB0", Offset = "0x9F9BB0", VA = "0x1809FABB0")]
	public void HandleLaserBehaviour(SecuritySystem secSystem, GameObject laser, Light laserLight, float maxRange = 16f)
	{
	}

	// Token: 0x06001CAB RID: 7339 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CAB")]
	[Address(RVA = "0x9FBF00", Offset = "0x9FAF00", VA = "0x1809FBF00")]
	public Interactable GetLocalizedSnapshot(Interactable obj)
	{
		return null;
	}

	// Token: 0x06001CAC RID: 7340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CAC")]
	[Address(RVA = "0x9FDD30", Offset = "0x9FCD30", VA = "0x1809FDD30")]
	public void RetroactiveSurveillanceAddition(Human who, NewNode routeFrom, NewNode routeTo, bool addReturnJourney, NewNode returnTo, float arrivalTime, float stayTime, ClothesPreset.OutfitCategory outfit)
	{
	}

	// Token: 0x06001CAD RID: 7341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CAD")]
	[Address(RVA = "0xA00060", Offset = "0x9FF060", VA = "0x180A00060")]
	public void ExplodeGrenade(Interactable grenade)
	{
	}

	// Token: 0x06001CAE RID: 7342 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CAE")]
	[Address(RVA = "0xA02050", Offset = "0xA01050", VA = "0x180A02050")]
	public Dictionary<NewNode, float> GetNodeCoverageFromRadius(Interactable grenade, float radius, out Dictionary<Human, float> humanOutput)
	{
		return null;
	}

	// Token: 0x06001CAF RID: 7343 RVA: 0x0000D218 File Offset: 0x0000B418
	[Token(Token = "0x6001CAF")]
	[Address(RVA = "0xA02EB0", Offset = "0xA01EB0", VA = "0x180A02EB0")]
	public bool RankRoomShadiness(NewRoom room, out float score)
	{
		return default(bool);
	}

	// Token: 0x06001CB0 RID: 7344 RVA: 0x0000D230 File Offset: 0x0000B430
	[Token(Token = "0x6001CB0")]
	[Address(RVA = "0xA032F0", Offset = "0xA022F0", VA = "0x180A032F0")]
	public bool RankNodeShadiness(NewNode node, out float score)
	{
		return default(bool);
	}

	// Token: 0x06001CB1 RID: 7345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CB1")]
	[Address(RVA = "0xA03600", Offset = "0xA02600", VA = "0x180A03600")]
	public void TriggerBriefcaseBomb(Interactable briefcase, Human actor)
	{
	}

	// Token: 0x06001CB2 RID: 7346 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CB2")]
	[Address(RVA = "0xA03960", Offset = "0xA02960", VA = "0x180A03960")]
	public Interactable GetMailbox(Human forHuman)
	{
		return null;
	}

	// Token: 0x06001CB3 RID: 7347 RVA: 0x0000D248 File Offset: 0x0000B448
	[Token(Token = "0x6001CB3")]
	[Address(RVA = "0xA043F0", Offset = "0xA033F0", VA = "0x180A043F0")]
	public bool IsStoryMissionActive(out Chapter script, out int chapter)
	{
		return default(bool);
	}

	// Token: 0x06001CB4 RID: 7348 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CB4")]
	[Address(RVA = "0xA04830", Offset = "0xA03830", VA = "0x180A04830")]
	public string GetShareCode(ref CitySaveData cityData)
	{
		return null;
	}

	// Token: 0x06001CB5 RID: 7349 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CB5")]
	[Address(RVA = "0xA048D0", Offset = "0xA038D0", VA = "0x180A048D0")]
	public string GetShareCode(string cityName, int citySizeX, int citySizeY, string version, string seed)
	{
		return null;
	}

	// Token: 0x06001CB6 RID: 7350 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CB6")]
	[Address(RVA = "0xA04DD0", Offset = "0xA03DD0", VA = "0x180A04DD0")]
	public void ParseShareCode(string input, out string cityName, out int citySizeX, out int citySizeY, out string version, out string seed)
	{
	}

	// Token: 0x06001CB7 RID: 7351 RVA: 0x0000D260 File Offset: 0x0000B460
	[Token(Token = "0x6001CB7")]
	[Address(RVA = "0xA05590", Offset = "0xA04590", VA = "0x180A05590")]
	public int VersionToNumbers(string version)
	{
		return 0;
	}

	// Token: 0x06001CB8 RID: 7352 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CB8")]
	[Address(RVA = "0xA05760", Offset = "0xA04760", VA = "0x180A05760")]
	public string NumbersToVersion(int numbers)
	{
		return null;
	}

	// Token: 0x06001CB9 RID: 7353 RVA: 0x0000D278 File Offset: 0x0000B478
	[Token(Token = "0x6001CB9")]
	[Address(RVA = "0xA05810", Offset = "0xA04810", VA = "0x180A05810")]
	public Vector2 GetCitySizeFromValue(int val)
	{
		return default(Vector2);
	}

	// Token: 0x06001CBA RID: 7354 RVA: 0x0000D290 File Offset: 0x0000B490
	[Token(Token = "0x6001CBA")]
	[Address(RVA = "0xA05940", Offset = "0xA04940", VA = "0x180A05940")]
	public Vector3 ToVector3(Vector3Int input)
	{
		return default(Vector3);
	}

	// Token: 0x06001CBB RID: 7355 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
	[Token(Token = "0x6001CBB")]
	[Address(RVA = "0xA05970", Offset = "0xA04970", VA = "0x180A05970")]
	public Vector3 ToVector3(int3 input)
	{
		return default(Vector3);
	}

	// Token: 0x06001CBC RID: 7356 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
	[Token(Token = "0x6001CBC")]
	[Address(RVA = "0xA05940", Offset = "0xA04940", VA = "0x180A05940")]
	public float3 ToFloat3(Vector3Int input)
	{
		return default(float3);
	}

	// Token: 0x06001CBD RID: 7357 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
	[Token(Token = "0x6001CBD")]
	[Address(RVA = "0xA059A0", Offset = "0xA049A0", VA = "0x180A059A0")]
	public int3 ToInt3(Vector3Int input)
	{
		return default(int3);
	}

	// Token: 0x06001CBE RID: 7358 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
	[Token(Token = "0x6001CBE")]
	[Address(RVA = "0xA059C0", Offset = "0xA049C0", VA = "0x180A059C0")]
	public Vector3Int toVector3Int(int3 input)
	{
		return default(Vector3Int);
	}

	// Token: 0x06001CBF RID: 7359 RVA: 0x0000D308 File Offset: 0x0000B508
	[Token(Token = "0x6001CBF")]
	[Address(RVA = "0xA059E0", Offset = "0xA049E0", VA = "0x180A059E0")]
	public Vector2 ToVector2(Vector2Int input)
	{
		return default(Vector2);
	}

	// Token: 0x06001CC0 RID: 7360 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CC0")]
	[Address(RVA = "0xA05A00", Offset = "0xA04A00", VA = "0x180A05A00")]
	public GameplayController.HotelGuest GetHotelRoom(Human person)
	{
		return null;
	}

	// Token: 0x06001CC1 RID: 7361 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CC1")]
	[Address(RVA = "0xA06360", Offset = "0xA05360", VA = "0x180A06360")]
	public FileInfo GetCityFile(string code, out string codeVersion, out string codeSeed)
	{
		return null;
	}

	// Token: 0x06001CC2 RID: 7362 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CC2")]
	[Address(RVA = "0xA06430", Offset = "0xA05430", VA = "0x180A06430")]
	public FileInfo GetCityFile(string codeName, string codeSeed, int codeSizeX, int codeSizeY, string codeVersion)
	{
		return null;
	}

	// Token: 0x06001CC3 RID: 7363 RVA: 0x0000D320 File Offset: 0x0000B520
	[Token(Token = "0x6001CC3")]
	[Address(RVA = "0xA075B0", Offset = "0xA065B0", VA = "0x180A075B0")]
	public bool IsConsoleBuild()
	{
		return default(bool);
	}

	// Token: 0x06001CC4 RID: 7364 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CC4")]
	[Address(RVA = "0xA07680", Offset = "0xA06680", VA = "0x180A07680")]
	public string CensorText(string inputText)
	{
		return null;
	}

	// Token: 0x06001CC5 RID: 7365 RVA: 0x0000D338 File Offset: 0x0000B538
	[Token(Token = "0x6001CC5")]
	[Address(RVA = "0xA07960", Offset = "0xA06960", VA = "0x180A07960")]
	public bool TryGetSniperVantagePoint(Human sniper, NewGameLocation requiredTargetSite, out NewWall vantagePoint, out float vantageScore, [Optional] List<NewNode.NodeAccess> accessCheckList)
	{
		return default(bool);
	}

	// Token: 0x06001CC6 RID: 7366 RVA: 0x0000D350 File Offset: 0x0000B550
	[Token(Token = "0x6001CC6")]
	[Address(RVA = "0xA08990", Offset = "0xA07990", VA = "0x180A08990")]
	private bool ScanBuildingForSniperVantagePoints(Human sniper, NewBuilding building, NewGameLocation requiredTargetSite, out NewWall vantagePoint, out float vantageScore, ref List<NewNode.NodeAccess> accessCheckList)
	{
		return default(bool);
	}

	// Token: 0x06001CC7 RID: 7367 RVA: 0x0000D368 File Offset: 0x0000B568
	[Token(Token = "0x6001CC7")]
	[Address(RVA = "0xA09DB0", Offset = "0xA08DB0", VA = "0x180A09DB0")]
	public bool TryGetSniperVantagePoint(NewGameLocation vantageLocation, out NewWall vantagePoint, out float vantageScore, out List<NewGameLocation> possibleTargetSites, [Optional] NewGameLocation requiredTargetSite)
	{
		return default(bool);
	}

	// Token: 0x06001CC8 RID: 7368 RVA: 0x0000D380 File Offset: 0x0000B580
	[Token(Token = "0x6001CC8")]
	[Address(RVA = "0xA0AA70", Offset = "0xA09A70", VA = "0x180A0AA70")]
	public bool TryGetSniperVantagePoint(NewRoom vantageRoom, out NewWall vantagePoint, out float vantageScore, out List<NewGameLocation> possibleTargetSites, [Optional] NewGameLocation requiredTargetSite)
	{
		return default(bool);
	}

	// Token: 0x06001CC9 RID: 7369 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CC9")]
	[Address(RVA = "0xA0CD50", Offset = "0xA0BD50", VA = "0x180A0CD50")]
	private NewBuilding GetFacingBuildingFromWindow(NewNode.NodeAccess windowAccess, out Vector3 windowDir)
	{
		return null;
	}

	// Token: 0x06001CCA RID: 7370 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CCA")]
	[Address(RVA = "0xA0D1B0", Offset = "0xA0C1B0", VA = "0x180A0D1B0")]
	public Telephone GetClosestTelephone(Actor toActor, float maxDistance = 18f, bool prioritiseSameLocation = true, bool payPhonesOnly = false, bool mustHaveValidAccess = true)
	{
		return null;
	}

	// Token: 0x06001CCB RID: 7371 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CCB")]
	[Address(RVA = "0xA0D8D0", Offset = "0xA0C8D0", VA = "0x180A0D8D0")]
	public SceneRecorder.SceneCapture GetSceneCaptureFromID(int captureID)
	{
		return null;
	}

	// Token: 0x06001CCC RID: 7372 RVA: 0x0000D398 File Offset: 0x0000B598
	[Token(Token = "0x6001CCC")]
	[Address(RVA = "0xA0DF50", Offset = "0xA0CF50", VA = "0x180A0DF50")]
	public int GetNearestFactorOf(int inputValue, int factor = 4)
	{
		return 0;
	}

	// Token: 0x06001CCD RID: 7373 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
	[Token(Token = "0x6001CCD")]
	[Address(RVA = "0xA0E010", Offset = "0xA0D010", VA = "0x180A0E010")]
	public int AddDigits(int n1, int n2)
	{
		return 0;
	}

	// Token: 0x06001CCE RID: 7374 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
	[Token(Token = "0x6001CCE")]
	[Address(RVA = "0xA0E040", Offset = "0xA0D040", VA = "0x180A0E040")]
	public bool CheckForLatin(string stringToCheck)
	{
		return default(bool);
	}

	// Token: 0x06001CCF RID: 7375 RVA: 0x0000D3E0 File Offset: 0x0000B5E0
	[Token(Token = "0x6001CCF")]
	[Address(RVA = "0xA0E0B0", Offset = "0xA0D0B0", VA = "0x180A0E0B0")]
	public bool ColorsAreClose(Color a, Color z, float threshold)
	{
		return default(bool);
	}

	// Token: 0x06001CD0 RID: 7376 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CD0")]
	[Address(RVA = "0xA0E0F0", Offset = "0xA0D0F0", VA = "0x180A0E0F0")]
	public DialogPreset ConstructDialogPresetFromDDSMessage(DDSSaveClasses.DDSTreeSave tree, DDSSaveClasses.DDSMessageSettings msgInstance, DDSSaveClasses.DDSMessageSave msg)
	{
		return null;
	}

	// Token: 0x06001CD1 RID: 7377 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CD1")]
	[Address(RVA = "0xA0EA10", Offset = "0xA0DA10", VA = "0x180A0EA10")]
	public InteractablePreset PickItemFromDDSStringPool(DDSSaveClasses.DDSTreeSave tree)
	{
		return null;
	}

	// Token: 0x06001CD2 RID: 7378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CD2")]
	[Address(RVA = "0xA0ECD0", Offset = "0xA0DCD0", VA = "0x180A0ECD0")]
	public Toolbox()
	{
	}

	// Token: 0x040024F4 RID: 9460
	[Token(Token = "0x40024F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool endOfFrameInvoke;

	// Token: 0x040024F5 RID: 9461
	[Token(Token = "0x40024F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HashSet<Action> invokeEndOfFrame;

	// Token: 0x040024F6 RID: 9462
	[Token(Token = "0x40024F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<string> debugInvokeEndOfFrame;

	// Token: 0x040024F7 RID: 9463
	[Token(Token = "0x40024F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Censor censor;

	// Token: 0x040024F8 RID: 9464
	[Token(Token = "0x40024F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject <PoolingGroup>k__BackingField;

	// Token: 0x040024F9 RID: 9465
	[Token(Token = "0x40024F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Human.ShoeType> allShoeTypes;

	// Token: 0x040024FA RID: 9466
	[Token(Token = "0x40024FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Evidence.DataKey> allDataKeys;

	// Token: 0x040024FB RID: 9467
	[Token(Token = "0x40024FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Descriptors.EthnicGroup> allEthnicities;

	// Token: 0x040024FC RID: 9468
	[Token(Token = "0x40024FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<DDSSaveClasses.TreeTriggers> allTreeTriggers;

	// Token: 0x040024FD RID: 9469
	[Token(Token = "0x40024FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<Acquaintance.ConnectionType> allConnectionTypes;

	// Token: 0x040024FE RID: 9470
	[Token(Token = "0x40024FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<CompanyPreset.CompanyCategory> allCompanyCategories;

	// Token: 0x040024FF RID: 9471
	[Token(Token = "0x40024FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<ClothesPreset.OutfitCategory> allOutfitCategories;

	// Token: 0x04002500 RID: 9472
	[Token(Token = "0x4002500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<CitizenOutfitController.CharacterAnchor> allCharacterAnchors;

	// Token: 0x04002501 RID: 9473
	[Token(Token = "0x4002501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<ArtPreset> allArt;

	// Token: 0x04002502 RID: 9474
	[Token(Token = "0x4002502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<OccupationPreset> allCriminalJobs;

	// Token: 0x04002503 RID: 9475
	[Token(Token = "0x4002503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<StreetTilePreset> allStreetTiles;

	// Token: 0x04002504 RID: 9476
	[Token(Token = "0x4002504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<SyncDiskPreset> allSyncDisks;

	// Token: 0x04002505 RID: 9477
	[Token(Token = "0x4002505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<JobPreset> allSideJobs;

	// Token: 0x04002506 RID: 9478
	[Token(Token = "0x4002506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<DistrictPreset> allDistricts;

	// Token: 0x04002507 RID: 9479
	[Token(Token = "0x4002507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<HandwritingPreset> allHandwriting;

	// Token: 0x04002508 RID: 9480
	[Token(Token = "0x4002508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<InteractablePreset> allBasBouleCards;

	// Token: 0x04002509 RID: 9481
	[Token(Token = "0x4002509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<BookPreset> allBooks;

	// Token: 0x0400250A RID: 9482
	[Token(Token = "0x400250A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Dictionary<string, EvidencePreset> evidencePresetDictionary;

	// Token: 0x0400250B RID: 9483
	[Token(Token = "0x400250B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Dictionary<string, FactPreset> factPresetDictionary;

	// Token: 0x0400250C RID: 9484
	[Token(Token = "0x400250C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Dictionary<string, GroupPreset> groupsDictionary;

	// Token: 0x0400250D RID: 9485
	[Token(Token = "0x400250D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Dictionary<string, DDSScope> scopeDictionary;

	// Token: 0x0400250E RID: 9486
	[Token(Token = "0x400250E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Dictionary<string, DDSScope> globalScopeDictionary;

	// Token: 0x0400250F RID: 9487
	[Token(Token = "0x400250F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Dictionary<string, InteractablePreset> objectPresetDictionary;

	// Token: 0x04002510 RID: 9488
	[Token(Token = "0x4002510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<InteractablePreset> placeAtGameLocationInteractables;

	// Token: 0x04002511 RID: 9489
	[Token(Token = "0x4002511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public List<InteractablePreset> placePerOwnerInteractables;

	// Token: 0x04002512 RID: 9490
	[Token(Token = "0x4002512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Dictionary<SubObjectClassPreset, List<InteractablePreset>> subObjectsDictionary;

	// Token: 0x04002513 RID: 9491
	[Token(Token = "0x4002513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Dictionary<string, AudioEvent> voiceActedDictionary;

	// Token: 0x04002514 RID: 9492
	[Token(Token = "0x4002514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public List<CharacterTrait> allCharacterTraits;

	// Token: 0x04002515 RID: 9493
	[Token(Token = "0x4002515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public List<CharacterTrait> stage0Traits;

	// Token: 0x04002516 RID: 9494
	[Token(Token = "0x4002516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public List<CharacterTrait> stage1Traits;

	// Token: 0x04002517 RID: 9495
	[Token(Token = "0x4002517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public List<CharacterTrait> stage2Traits;

	// Token: 0x04002518 RID: 9496
	[Token(Token = "0x4002518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public List<CharacterTrait> stage3Traits;

	// Token: 0x04002519 RID: 9497
	[Token(Token = "0x4002519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public List<CharacterTrait> reasons;

	// Token: 0x0400251A RID: 9498
	[Token(Token = "0x400251A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public List<AddressPreset> allAddressPresets;

	// Token: 0x0400251B RID: 9499
	[Token(Token = "0x400251B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public List<DesignStylePreset> allDesignStyles;

	// Token: 0x0400251C RID: 9500
	[Token(Token = "0x400251C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public List<MaterialGroupPreset> allMaterialGroups;

	// Token: 0x0400251D RID: 9501
	[Token(Token = "0x400251D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Dictionary<DesignStylePreset, List<FurniturePreset>> furnitureDesignStyleRef;

	// Token: 0x0400251E RID: 9502
	[Token(Token = "0x400251E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public Dictionary<RoomClassPreset, HashSet<FurniturePreset>> furnitureRoomTypeRef;

	// Token: 0x0400251F RID: 9503
	[Token(Token = "0x400251F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Dictionary<DesignStylePreset, Dictionary<MaterialGroupPreset.MaterialType, List<MaterialGroupPreset>>> materialDesignStyleRef;

	// Token: 0x04002520 RID: 9504
	[Token(Token = "0x4002520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public Dictionary<DesignStylePreset, Dictionary<WallFrontageClass, List<WallFrontagePreset>>> wallFrontageStyleRef;

	// Token: 0x04002521 RID: 9505
	[Token(Token = "0x4002521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public List<FurnitureCluster> allFurnitureClusters;

	// Token: 0x04002522 RID: 9506
	[Token(Token = "0x4002522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public List<FurniturePreset> allFurniture;

	// Token: 0x04002523 RID: 9507
	[Token(Token = "0x4002523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public List<AIGoalPreset> allGoals;

	// Token: 0x04002524 RID: 9508
	[Token(Token = "0x4002524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public List<DialogPreset> allDialog;

	// Token: 0x04002525 RID: 9509
	[Token(Token = "0x4002525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public List<DialogPreset> defaultDialogOptions;

	// Token: 0x04002526 RID: 9510
	[Token(Token = "0x4002526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public List<InteractablePreset> allWeapons;

	// Token: 0x04002527 RID: 9511
	[Token(Token = "0x4002527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public Dictionary<string, DDSSaveClasses.DDSBlockSave> allDDSBlocks;

	// Token: 0x04002528 RID: 9512
	[Token(Token = "0x4002528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public Dictionary<string, DDSSaveClasses.DDSMessageSave> allDDSMessages;

	// Token: 0x04002529 RID: 9513
	[Token(Token = "0x4002529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public Dictionary<string, DDSSaveClasses.DDSTreeSave> allDDSTrees;

	// Token: 0x0400252A RID: 9514
	[Token(Token = "0x400252A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public List<DDSSaveClasses.DDSTreeSave> allArticleTrees;

	// Token: 0x0400252B RID: 9515
	[Token(Token = "0x400252B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public Dictionary<DDSSaveClasses.DDSMessageSettings, DialogPreset> constructedDialogPresets;

	// Token: 0x0400252C RID: 9516
	[Token(Token = "0x400252C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public Dictionary<string, HelpContentPage> allHelpContent;

	// Token: 0x0400252D RID: 9517
	[Token(Token = "0x400252D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public List<ClothesPreset> allClothes;

	// Token: 0x0400252E RID: 9518
	[Token(Token = "0x400252E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public Dictionary<string, ClothesPreset> clothesDictionary;

	// Token: 0x0400252F RID: 9519
	[Token(Token = "0x400252F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public List<StatusPreset> allStatuses;

	// Token: 0x04002530 RID: 9520
	[Token(Token = "0x4002530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public int aiSightingLayerMask;

	// Token: 0x04002531 RID: 9521
	[Token(Token = "0x4002531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	public int interactionRayLayerMask;

	// Token: 0x04002532 RID: 9522
	[Token(Token = "0x4002532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public int interactionRayLayerMaskNoRoomMesh;

	// Token: 0x04002533 RID: 9523
	[Token(Token = "0x4002533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
	public int printDetectionRayLayerMask;

	// Token: 0x04002534 RID: 9524
	[Token(Token = "0x4002534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public int sceneCaptureLayerMask;

	// Token: 0x04002535 RID: 9525
	[Token(Token = "0x4002535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	public int mugShotCaptureLayerMask;

	// Token: 0x04002536 RID: 9526
	[Token(Token = "0x4002536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public int physicalObjectsLayerMask;

	// Token: 0x04002537 RID: 9527
	[Token(Token = "0x4002537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	public int playerMovementLayerMask;

	// Token: 0x04002538 RID: 9528
	[Token(Token = "0x4002538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public int autoTravelMovementLayerMask;

	// Token: 0x04002539 RID: 9529
	[Token(Token = "0x4002539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	public int heldObjectsObjectsLayerMask;

	// Token: 0x0400253A RID: 9530
	[Token(Token = "0x400253A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public int spatterLayerMask;

	// Token: 0x0400253B RID: 9531
	[Token(Token = "0x400253B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	public int textToImageMask;

	// Token: 0x0400253C RID: 9532
	[Token(Token = "0x400253C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public int lightCullingMask;

	// Token: 0x0400253D RID: 9533
	[Token(Token = "0x400253D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	public int sniperLOSMask;

	// Token: 0x0400253E RID: 9534
	[Token(Token = "0x400253E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private List<Descriptors.EthnicGroup> rEthnicity;

	// Token: 0x0400253F RID: 9535
	[Token(Token = "0x400253F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public char[] alphabet;

	// Token: 0x04002540 RID: 9536
	[Token(Token = "0x4002540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public Dictionary<Type, Dictionary<string, ScriptableObject>> resourcesCache;

	// Token: 0x04002541 RID: 9537
	[Token(Token = "0x4002541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public Dictionary<Material, MaterialGroupPreset> materialProperties;

	// Token: 0x04002542 RID: 9538
	[Token(Token = "0x4002542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public Dictionary<Mesh, FurniturePreset> furnitureMeshReference;

	// Token: 0x04002543 RID: 9539
	[Token(Token = "0x4002543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	public string lastRandomNumberKey;

	// Token: 0x04002544 RID: 9540
	[Token(Token = "0x4002544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private char[] seedLetters;

	// Token: 0x04002545 RID: 9541
	[Token(Token = "0x4002545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private char[] seedNumbers;

	// Token: 0x04002546 RID: 9542
	[Token(Token = "0x4002546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public Vector2 debugTimeRange1;

	// Token: 0x04002547 RID: 9543
	[Token(Token = "0x4002547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	public Vector2 debugTimeRange2;

	// Token: 0x04002548 RID: 9544
	[Token(Token = "0x4002548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Toolbox _instance;

	// Token: 0x02000523 RID: 1315
	[Token(Token = "0x2000523")]
	[Serializable]
	public class MaterialKey
	{
		// Token: 0x06001CD3 RID: 7379 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		[Token(Token = "0x6001CD3")]
		[Address(RVA = "0xA10FF0", Offset = "0xA0FFF0", VA = "0x180A10FF0")]
		public bool Equals(Toolbox.MaterialKey other)
		{
			return default(bool);
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x0000D410 File Offset: 0x0000B610
		[Token(Token = "0x6001CD4")]
		[Address(RVA = "0xA11030", Offset = "0xA10030", VA = "0x180A11030", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0000D428 File Offset: 0x0000B628
		[Token(Token = "0x6001CD5")]
		[Address(RVA = "0xA11500", Offset = "0xA10500", VA = "0x180A11500")]
		private bool Approximately(Color colour1, Color colour2)
		{
			return default(bool);
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0000D440 File Offset: 0x0000B640
		[Token(Token = "0x6001CD6")]
		[Address(RVA = "0xA11570", Offset = "0xA10570", VA = "0x180A11570", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0000D458 File Offset: 0x0000B658
		[Token(Token = "0x6001CD7")]
		[Address(RVA = "0xA11900", Offset = "0xA10900", VA = "0x180A11900")]
		public static bool operator ==(Toolbox.MaterialKey c1, Toolbox.MaterialKey c2)
		{
			return default(bool);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0000D470 File Offset: 0x0000B670
		[Token(Token = "0x6001CD8")]
		[Address(RVA = "0xA11940", Offset = "0xA10940", VA = "0x180A11940")]
		public static bool operator !=(Toolbox.MaterialKey c1, Toolbox.MaterialKey c2)
		{
			return default(bool);
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public MaterialKey()
		{
		}

		// Token: 0x04002549 RID: 9545
		[Token(Token = "0x4002549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material baseMaterial;

		// Token: 0x0400254A RID: 9546
		[Token(Token = "0x400254A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color mainColour;

		// Token: 0x0400254B RID: 9547
		[Token(Token = "0x400254B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color colour1;

		// Token: 0x0400254C RID: 9548
		[Token(Token = "0x400254C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color colour2;

		// Token: 0x0400254D RID: 9549
		[Token(Token = "0x400254D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color colour3;

		// Token: 0x0400254E RID: 9550
		[Token(Token = "0x400254E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float grubiness;
	}

	// Token: 0x02000524 RID: 1316
	[Token(Token = "0x2000524")]
	public struct SpecialItemPlacement
	{
		// Token: 0x0400254F RID: 9551
		[Token(Token = "0x400254F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string reference;

		// Token: 0x04002550 RID: 9552
		[Token(Token = "0x4002550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public InteractablePreset preset;

		// Token: 0x04002551 RID: 9553
		[Token(Token = "0x4002551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human belongsTo;

		// Token: 0x04002552 RID: 9554
		[Token(Token = "0x4002552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object passedObject;
	}

	// Token: 0x02000525 RID: 1317
	[Token(Token = "0x2000525")]
	public enum LayerMaskMode
	{
		// Token: 0x04002554 RID: 9556
		[Token(Token = "0x4002554")]
		castAllExcept,
		// Token: 0x04002555 RID: 9557
		[Token(Token = "0x4002555")]
		onlyCast
	}

	// Token: 0x02000526 RID: 1318
	[Token(Token = "0x2000526")]
	private sealed class <>c__DisplayClass99_0
	{
		// Token: 0x06001CDA RID: 7386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass99_0()
		{
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x0000D488 File Offset: 0x0000B688
		[Token(Token = "0x6001CDB")]
		[Address(RVA = "0xA119A0", Offset = "0xA109A0", VA = "0x180A119A0")]
		internal bool <LoadAll>b__0(ScriptableObject item)
		{
			return default(bool);
		}

		// Token: 0x04002556 RID: 9558
		[Token(Token = "0x4002556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public KeyValuePair<string, ScriptableObject> pair2;

		// Token: 0x04002557 RID: 9559
		[Token(Token = "0x4002557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Type existingType;
	}

	// Token: 0x02000527 RID: 1319
	[Token(Token = "0x2000527")]
	private sealed class <ExeEndOfFrame>d__112 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001CDC RID: 7388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDC")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <ExeEndOfFrame>d__112(int <>1__state)
		{
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		[Token(Token = "0x6001CDE")]
		[Address(RVA = "0xA11AB0", Offset = "0xA10AB0", VA = "0x180A11AB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000DD")]
		private object Current
		{
			[Token(Token = "0x6001CDF")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0xA11D00", Offset = "0xA10D00", VA = "0x180A11D00", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000DE")]
		private object Current
		{
			[Token(Token = "0x6001CE1")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002558 RID: 9560
		[Token(Token = "0x4002558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002559 RID: 9561
		[Token(Token = "0x4002559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400255A RID: 9562
		[Token(Token = "0x400255A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Toolbox <>4__this;

		// Token: 0x0400255B RID: 9563
		[Token(Token = "0x400255B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <wait>5__2;
	}

	// Token: 0x02000528 RID: 1320
	[Token(Token = "0x2000528")]
	private sealed class <>c__DisplayClass126_0
	{
		// Token: 0x06001CE2 RID: 7394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass126_0()
		{
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		[Token(Token = "0x6001CE3")]
		[Address(RVA = "0xA11D50", Offset = "0xA10D50", VA = "0x180A11D50")]
		internal bool <GetOrCreateEvidenceForInteractable>b__0(Evidence item)
		{
			return default(bool);
		}

		// Token: 0x0400255C RID: 9564
		[Token(Token = "0x400255C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractablePreset preset;
	}

	// Token: 0x02000529 RID: 1321
	[Token(Token = "0x2000529")]
	private sealed class <>c__DisplayClass127_0
	{
		// Token: 0x06001CE4 RID: 7396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass127_0()
		{
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		[Token(Token = "0x6001CE5")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <TryGetEvidence>b__0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x0400255D RID: 9565
		[Token(Token = "0x400255D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int iID;
	}

	// Token: 0x0200052A RID: 1322
	[Token(Token = "0x200052A")]
	private sealed class <>c__DisplayClass128_0
	{
		// Token: 0x06001CE6 RID: 7398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass128_0()
		{
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		[Token(Token = "0x6001CE7")]
		[Address(RVA = "0x478670", Offset = "0x477670", VA = "0x180478670")]
		internal bool <SpawnSpareKey>b__2(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x0400255E RID: 9566
		[Token(Token = "0x400255E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurniturePreset.SubObject ownCheck;
	}

	// Token: 0x0200052B RID: 1323
	[Token(Token = "0x200052B")]
	private sealed class <>c__DisplayClass128_1
	{
		// Token: 0x06001CE8 RID: 7400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass128_1()
		{
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0000D500 File Offset: 0x0000B700
		[Token(Token = "0x6001CE9")]
		[Address(RVA = "0xA11DC0", Offset = "0xA10DC0", VA = "0x180A11DC0")]
		internal bool <SpawnSpareKey>b__3(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x0400255F RID: 9567
		[Token(Token = "0x400255F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurniturePreset.SubObject pickedPos;
	}

	// Token: 0x0200052C RID: 1324
	[Token(Token = "0x200052C")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001CEB RID: 7403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CEB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x0000D518 File Offset: 0x0000B718
		[Token(Token = "0x6001CEC")]
		[Address(RVA = "0xA11E80", Offset = "0xA10E80", VA = "0x180A11E80")]
		internal bool <SpawnSpareKey>b__128_0(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x0000D530 File Offset: 0x0000B730
		[Token(Token = "0x6001CED")]
		[Address(RVA = "0xA11E80", Offset = "0xA10E80", VA = "0x180A11E80")]
		internal bool <SpawnSpareKey>b__128_1(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x0000D548 File Offset: 0x0000B748
		[Token(Token = "0x6001CEE")]
		[Address(RVA = "0xA11F20", Offset = "0xA10F20", VA = "0x180A11F20")]
		internal bool <FindClosestObjectTo>b__152_0(Company item)
		{
			return default(bool);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0000D560 File Offset: 0x0000B760
		[Token(Token = "0x6001CEF")]
		[Address(RVA = "0xA12080", Offset = "0xA11080", VA = "0x180A12080")]
		internal bool <FindClosestObjectTo>b__152_1(Company item)
		{
			return default(bool);
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x0000D578 File Offset: 0x0000B778
		[Token(Token = "0x6001CF0")]
		[Address(RVA = "0x6F0700", Offset = "0x6EF700", VA = "0x1806F0700")]
		internal char <ToBase26>b__184_0(int s)
		{
			return '\0';
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x0000D590 File Offset: 0x0000B790
		[Token(Token = "0x6001CF1")]
		[Address(RVA = "0x4E6D90", Offset = "0x4E5D90", VA = "0x1804E6D90")]
		internal int <GetMessageTreeLinkRankings>b__196_0(Human.DDSRank p1, Human.DDSRank p2)
		{
			return 0;
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		[Token(Token = "0x6001CF2")]
		[Address(RVA = "0xA120B0", Offset = "0xA110B0", VA = "0x180A120B0")]
		internal bool <GetFingerprintOwnerPool>b__203_0(Human item)
		{
			return default(bool);
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		[Token(Token = "0x6001CF3")]
		[Address(RVA = "0xA12100", Offset = "0xA11100", VA = "0x180A12100")]
		internal bool <GetFingerprintOwnerPool>b__203_1(Human item)
		{
			return default(bool);
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
		[Token(Token = "0x6001CF4")]
		[Address(RVA = "0xA12150", Offset = "0xA11150", VA = "0x180A12150")]
		internal bool <PickNearbyNode>b__214_0(AirDuctGroup.AirDuctSection item)
		{
			return default(bool);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		[Token(Token = "0x6001CF5")]
		[Address(RVA = "0xA12170", Offset = "0xA11170", VA = "0x180A12170")]
		internal int <RetroactiveSurveillanceAddition>b__224_3(SceneRecorder.SceneCapture p1, SceneRecorder.SceneCapture p2)
		{
			return 0;
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x0000D608 File Offset: 0x0000B808
		[Token(Token = "0x6001CF6")]
		[Address(RVA = "0xA12170", Offset = "0xA11170", VA = "0x180A12170")]
		internal int <RetroactiveSurveillanceAddition>b__224_7(SceneRecorder.SceneCapture p1, SceneRecorder.SceneCapture p2)
		{
			return 0;
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x0000D620 File Offset: 0x0000B820
		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0x80D590", Offset = "0x80C590", VA = "0x18080D590")]
		internal bool <ScanBuildingForSniperVantagePoints>b__250_0(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0000D638 File Offset: 0x0000B838
		[Token(Token = "0x6001CF8")]
		[Address(RVA = "0x80D590", Offset = "0x80C590", VA = "0x18080D590")]
		internal bool <TryGetSniperVantagePoint>b__252_0(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x04002560 RID: 9568
		[Token(Token = "0x4002560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Toolbox.<>c <>9;

		// Token: 0x04002561 RID: 9569
		[Token(Token = "0x4002561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<FurniturePreset.SubObject> <>9__128_0;

		// Token: 0x04002562 RID: 9570
		[Token(Token = "0x4002562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<FurniturePreset.SubObject> <>9__128_1;

		// Token: 0x04002563 RID: 9571
		[Token(Token = "0x4002563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<Company> <>9__152_0;

		// Token: 0x04002564 RID: 9572
		[Token(Token = "0x4002564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<Company> <>9__152_1;

		// Token: 0x04002565 RID: 9573
		[Token(Token = "0x4002565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<int, char> <>9__184_0;

		// Token: 0x04002566 RID: 9574
		[Token(Token = "0x4002566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Comparison<Human.DDSRank> <>9__196_0;

		// Token: 0x04002567 RID: 9575
		[Token(Token = "0x4002567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Predicate<Human> <>9__203_0;

		// Token: 0x04002568 RID: 9576
		[Token(Token = "0x4002568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Predicate<Human> <>9__203_1;

		// Token: 0x04002569 RID: 9577
		[Token(Token = "0x4002569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Predicate<AirDuctGroup.AirDuctSection> <>9__214_0;

		// Token: 0x0400256A RID: 9578
		[Token(Token = "0x400256A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Comparison<SceneRecorder.SceneCapture> <>9__224_3;

		// Token: 0x0400256B RID: 9579
		[Token(Token = "0x400256B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Comparison<SceneRecorder.SceneCapture> <>9__224_7;

		// Token: 0x0400256C RID: 9580
		[Token(Token = "0x400256C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Predicate<NewNode.NodeAccess> <>9__250_0;

		// Token: 0x0400256D RID: 9581
		[Token(Token = "0x400256D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Predicate<NewNode.NodeAccess> <>9__252_0;
	}

	// Token: 0x0200052D RID: 1325
	[Token(Token = "0x200052D")]
	private sealed class <>c__DisplayClass134_0
	{
		// Token: 0x06001CF9 RID: 7417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass134_0()
		{
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x0000D650 File Offset: 0x0000B850
		[Token(Token = "0x6001CFA")]
		[Address(RVA = "0xA12200", Offset = "0xA11200", VA = "0x180A12200")]
		internal bool <FindNearestWithAction>b__0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x0000D668 File Offset: 0x0000B868
		[Token(Token = "0x6001CFB")]
		[Address(RVA = "0xA12250", Offset = "0xA11250", VA = "0x180A12250")]
		internal bool <FindNearestWithAction>b__1(InteractablePreset item)
		{
			return default(bool);
		}

		// Token: 0x0400256E RID: 9582
		[Token(Token = "0x400256E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CompanyPreset.CompanyCategory containDesireCategory;

		// Token: 0x0400256F RID: 9583
		[Token(Token = "0x400256F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<Interactable> <>9__0;

		// Token: 0x04002570 RID: 9584
		[Token(Token = "0x4002570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Predicate<InteractablePreset> <>9__1;
	}

	// Token: 0x0200052E RID: 1326
	[Token(Token = "0x200052E")]
	private sealed class <>c__DisplayClass152_0
	{
		// Token: 0x06001CFC RID: 7420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass152_0()
		{
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x0000D680 File Offset: 0x0000B880
		[Token(Token = "0x6001CFD")]
		[Address(RVA = "0x4FE620", Offset = "0x4FD620", VA = "0x1804FE620")]
		internal bool <FindClosestObjectTo>b__2(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04002571 RID: 9585
		[Token(Token = "0x4002571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractablePreset objectType;

		// Token: 0x04002572 RID: 9586
		[Token(Token = "0x4002572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<Interactable> <>9__2;
	}

	// Token: 0x0200052F RID: 1327
	[Token(Token = "0x200052F")]
	private sealed class <>c__DisplayClass199_0
	{
		// Token: 0x06001CFE RID: 7422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass199_0()
		{
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x0000D698 File Offset: 0x0000B898
		[Token(Token = "0x6001CFF")]
		[Address(RVA = "0x4FEAA0", Offset = "0x4FDAA0", VA = "0x1804FEAA0")]
		internal bool <SelectMaterial>b__0(MaterialGroupPreset.MaterialSettings item)
		{
			return default(bool);
		}

		// Token: 0x04002573 RID: 9587
		[Token(Token = "0x4002573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DesignStylePreset designStyle;

		// Token: 0x04002574 RID: 9588
		[Token(Token = "0x4002574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<MaterialGroupPreset.MaterialSettings> <>9__0;
	}

	// Token: 0x02000530 RID: 1328
	[Token(Token = "0x2000530")]
	private sealed class <SpawnTelephoneEntryWindow>d__205 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001D00 RID: 7424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D00")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <SpawnTelephoneEntryWindow>d__205(int <>1__state)
		{
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D01")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		[Token(Token = "0x6001D02")]
		[Address(RVA = "0xA12290", Offset = "0xA11290", VA = "0x180A12290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000DF")]
		private object Current
		{
			[Token(Token = "0x6001D03")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D04")]
		[Address(RVA = "0xA124A0", Offset = "0xA114A0", VA = "0x180A124A0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E0")]
		private object Current
		{
			[Token(Token = "0x6001D05")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002575 RID: 9589
		[Token(Token = "0x4002575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002576 RID: 9590
		[Token(Token = "0x4002576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002577 RID: 9591
		[Token(Token = "0x4002577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Evidence ev;

		// Token: 0x04002578 RID: 9592
		[Token(Token = "0x4002578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;
	}

	// Token: 0x02000531 RID: 1329
	[Token(Token = "0x2000531")]
	private sealed class <ExecuteScrollScrollRectOLD>d__211 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001D06 RID: 7430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D06")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <ExecuteScrollScrollRectOLD>d__211(int <>1__state)
		{
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D07")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
		[Token(Token = "0x6001D08")]
		[Address(RVA = "0xA124F0", Offset = "0xA114F0", VA = "0x180A124F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E1")]
		private object Current
		{
			[Token(Token = "0x6001D09")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0A")]
		[Address(RVA = "0xA12A00", Offset = "0xA11A00", VA = "0x180A12A00", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E2")]
		private object Current
		{
			[Token(Token = "0x6001D0B")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002579 RID: 9593
		[Token(Token = "0x4002579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400257A RID: 9594
		[Token(Token = "0x400257A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400257B RID: 9595
		[Token(Token = "0x400257B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CustomScrollRect scrollRect;

		// Token: 0x0400257C RID: 9596
		[Token(Token = "0x400257C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 targetPos;

		// Token: 0x0400257D RID: 9597
		[Token(Token = "0x400257D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool allowHorizontal;

		// Token: 0x0400257E RID: 9598
		[Token(Token = "0x400257E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float extraScrollThreshold;

		// Token: 0x0400257F RID: 9599
		[Token(Token = "0x400257F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool allowVertical;

		// Token: 0x04002580 RID: 9600
		[Token(Token = "0x4002580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float timeTaken;

		// Token: 0x04002581 RID: 9601
		[Token(Token = "0x4002581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float <progress>5__2;

		// Token: 0x04002582 RID: 9602
		[Token(Token = "0x4002582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector2 <newPos>5__3;
	}

	// Token: 0x02000532 RID: 1330
	[Token(Token = "0x2000532")]
	private sealed class <LerpScrollRect>d__213 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001D0C RID: 7436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0C")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <LerpScrollRect>d__213(int <>1__state)
		{
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0xA12A50", Offset = "0xA11A50", VA = "0x180A12A50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E3")]
		private object Current
		{
			[Token(Token = "0x6001D0F")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D10")]
		[Address(RVA = "0xA12CC0", Offset = "0xA11CC0", VA = "0x180A12CC0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E4")]
		private object Current
		{
			[Token(Token = "0x6001D11")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002583 RID: 9603
		[Token(Token = "0x4002583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002584 RID: 9604
		[Token(Token = "0x4002584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002585 RID: 9605
		[Token(Token = "0x4002585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float timeTaken;

		// Token: 0x04002586 RID: 9606
		[Token(Token = "0x4002586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CustomScrollRect scrollRect;

		// Token: 0x04002587 RID: 9607
		[Token(Token = "0x4002587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 anchoredPos;

		// Token: 0x04002588 RID: 9608
		[Token(Token = "0x4002588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <progress>5__2;
	}

	// Token: 0x02000533 RID: 1331
	[Token(Token = "0x2000533")]
	private sealed class <>c__DisplayClass224_0
	{
		// Token: 0x06001D12 RID: 7442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D12")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass224_0()
		{
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
		[Token(Token = "0x6001D13")]
		[Address(RVA = "0x66E290", Offset = "0x66D290", VA = "0x18066E290")]
		internal bool <RetroactiveSurveillanceAddition>b__2(SceneRecorder.ActorCapture item)
		{
			return default(bool);
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x0000D710 File Offset: 0x0000B910
		[Token(Token = "0x6001D14")]
		[Address(RVA = "0x66E290", Offset = "0x66D290", VA = "0x18066E290")]
		internal bool <RetroactiveSurveillanceAddition>b__6(SceneRecorder.ActorCapture item)
		{
			return default(bool);
		}

		// Token: 0x04002589 RID: 9609
		[Token(Token = "0x4002589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human who;

		// Token: 0x0400258A RID: 9610
		[Token(Token = "0x400258A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<SceneRecorder.ActorCapture> <>9__2;

		// Token: 0x0400258B RID: 9611
		[Token(Token = "0x400258B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Predicate<SceneRecorder.ActorCapture> <>9__6;
	}

	// Token: 0x02000534 RID: 1332
	[Token(Token = "0x2000534")]
	private sealed class <>c__DisplayClass224_1
	{
		// Token: 0x06001D15 RID: 7445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D15")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass224_1()
		{
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x0000D728 File Offset: 0x0000B928
		[Token(Token = "0x6001D16")]
		[Address(RVA = "0xA12D10", Offset = "0xA11D10", VA = "0x180A12D10")]
		internal bool <RetroactiveSurveillanceAddition>b__0(SceneRecorder.SceneCapture item)
		{
			return default(bool);
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x0000D740 File Offset: 0x0000B940
		[Token(Token = "0x6001D17")]
		[Address(RVA = "0xA12DB0", Offset = "0xA11DB0", VA = "0x180A12DB0")]
		internal bool <RetroactiveSurveillanceAddition>b__1(SceneRecorder.SceneCapture item)
		{
			return default(bool);
		}

		// Token: 0x0400258C RID: 9612
		[Token(Token = "0x400258C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float backwardsTime;

		// Token: 0x0400258D RID: 9613
		[Token(Token = "0x400258D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HashSet<SceneRecorder.SceneCapture> addedToCaptures;

		// Token: 0x0400258E RID: 9614
		[Token(Token = "0x400258E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Predicate<SceneRecorder.SceneCapture> <>9__0;

		// Token: 0x0400258F RID: 9615
		[Token(Token = "0x400258F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Predicate<SceneRecorder.SceneCapture> <>9__1;
	}

	// Token: 0x02000535 RID: 1333
	[Token(Token = "0x2000535")]
	private sealed class <>c__DisplayClass224_2
	{
		// Token: 0x06001D18 RID: 7448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D18")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass224_2()
		{
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x0000D758 File Offset: 0x0000B958
		[Token(Token = "0x6001D19")]
		[Address(RVA = "0xA12EF0", Offset = "0xA11EF0", VA = "0x180A12EF0")]
		internal bool <RetroactiveSurveillanceAddition>b__4(SceneRecorder.SceneCapture item)
		{
			return default(bool);
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x0000D770 File Offset: 0x0000B970
		[Token(Token = "0x6001D1A")]
		[Address(RVA = "0xA12FA0", Offset = "0xA11FA0", VA = "0x180A12FA0")]
		internal bool <RetroactiveSurveillanceAddition>b__5(SceneRecorder.SceneCapture item)
		{
			return default(bool);
		}

		// Token: 0x04002590 RID: 9616
		[Token(Token = "0x4002590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float forwardsTime;

		// Token: 0x04002591 RID: 9617
		[Token(Token = "0x4002591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toolbox.<>c__DisplayClass224_1 CS$<>8__locals1;

		// Token: 0x04002592 RID: 9618
		[Token(Token = "0x4002592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Predicate<SceneRecorder.SceneCapture> <>9__4;

		// Token: 0x04002593 RID: 9619
		[Token(Token = "0x4002593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Predicate<SceneRecorder.SceneCapture> <>9__5;
	}

	// Token: 0x02000536 RID: 1334
	[Token(Token = "0x2000536")]
	private sealed class <>c__DisplayClass230_0
	{
		// Token: 0x06001D1B RID: 7451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass230_0()
		{
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x0000D788 File Offset: 0x0000B988
		[Token(Token = "0x6001D1C")]
		[Address(RVA = "0xA130F0", Offset = "0xA120F0", VA = "0x180A130F0")]
		internal bool <GetMailbox>b__0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
		[Token(Token = "0x6001D1D")]
		[Address(RVA = "0xA13330", Offset = "0xA12330", VA = "0x180A13330")]
		internal bool <GetMailbox>b__1(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04002594 RID: 9620
		[Token(Token = "0x4002594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human forHuman;

		// Token: 0x04002595 RID: 9621
		[Token(Token = "0x4002595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<Interactable> <>9__0;

		// Token: 0x04002596 RID: 9622
		[Token(Token = "0x4002596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Predicate<Interactable> <>9__1;
	}

	// Token: 0x02000537 RID: 1335
	[Token(Token = "0x2000537")]
	private sealed class <>c__DisplayClass233_0
	{
		// Token: 0x06001D1E RID: 7454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass233_0()
		{
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		[Token(Token = "0x6001D1F")]
		[Address(RVA = "0xA13570", Offset = "0xA12570", VA = "0x180A13570")]
		internal bool <GetShareCode>b__0(CityControls.CitySize item)
		{
			return default(bool);
		}

		// Token: 0x04002597 RID: 9623
		[Token(Token = "0x4002597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int citySizeX;

		// Token: 0x04002598 RID: 9624
		[Token(Token = "0x4002598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int citySizeY;
	}

	// Token: 0x02000538 RID: 1336
	[Token(Token = "0x2000538")]
	private sealed class <>c__DisplayClass244_0
	{
		// Token: 0x06001D20 RID: 7456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D20")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass244_0()
		{
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		[Token(Token = "0x6001D21")]
		[Address(RVA = "0xA135D0", Offset = "0xA125D0", VA = "0x180A135D0")]
		internal bool <GetHotelRoom>b__0(GameplayController.HotelGuest item)
		{
			return default(bool);
		}

		// Token: 0x04002599 RID: 9625
		[Token(Token = "0x4002599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human person;
	}

	// Token: 0x02000539 RID: 1337
	[Token(Token = "0x2000539")]
	private sealed class <>c__DisplayClass255_0
	{
		// Token: 0x06001D22 RID: 7458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D22")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass255_0()
		{
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
		[Token(Token = "0x6001D23")]
		[Address(RVA = "0x80D810", Offset = "0x80C810", VA = "0x18080D810")]
		internal bool <GetSceneCaptureFromID>b__0(SceneRecorder.SceneCapture item)
		{
			return default(bool);
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x0000D800 File Offset: 0x0000BA00
		[Token(Token = "0x6001D24")]
		[Address(RVA = "0x80D810", Offset = "0x80C810", VA = "0x18080D810")]
		internal bool <GetSceneCaptureFromID>b__2(SceneRecorder.SceneCapture item)
		{
			return default(bool);
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x0000D818 File Offset: 0x0000BA18
		[Token(Token = "0x6001D25")]
		[Address(RVA = "0x80D810", Offset = "0x80C810", VA = "0x18080D810")]
		internal bool <GetSceneCaptureFromID>b__1(SceneRecorder.SceneCapture item)
		{
			return default(bool);
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0000D830 File Offset: 0x0000BA30
		[Token(Token = "0x6001D26")]
		[Address(RVA = "0x80D810", Offset = "0x80C810", VA = "0x18080D810")]
		internal bool <GetSceneCaptureFromID>b__3(SceneRecorder.SceneCapture item)
		{
			return default(bool);
		}

		// Token: 0x0400259A RID: 9626
		[Token(Token = "0x400259A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int captureID;

		// Token: 0x0400259B RID: 9627
		[Token(Token = "0x400259B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<SceneRecorder.SceneCapture> <>9__2;

		// Token: 0x0400259C RID: 9628
		[Token(Token = "0x400259C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Predicate<SceneRecorder.SceneCapture> <>9__3;
	}

	// Token: 0x0200053A RID: 1338
	[Token(Token = "0x200053A")]
	private sealed class <>c__DisplayClass260_0
	{
		// Token: 0x06001D27 RID: 7463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D27")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass260_0()
		{
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x0000D848 File Offset: 0x0000BA48
		[Token(Token = "0x6001D28")]
		[Address(RVA = "0x5E6860", Offset = "0x5E5860", VA = "0x1805E6860")]
		internal bool <ConstructDialogPresetFromDDSMessage>b__0(CharacterTrait item)
		{
			return default(bool);
		}

		// Token: 0x0400259D RID: 9629
		[Token(Token = "0x400259D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string str;
	}
}
