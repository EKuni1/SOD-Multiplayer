using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000639 RID: 1593
[Token(Token = "0x2000639")]
public class MapController : MonoBehaviour
{
	// Token: 0x14000041 RID: 65
	// (add) Token: 0x0600230A RID: 8970 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600230B RID: 8971 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000041")]
	public event MapController.RoutePlot OnPlotRoute
	{
		[Token(Token = "0x600230A")]
		[Address(RVA = "0xB4B1C0", Offset = "0xB4A1C0", VA = "0x180B4B1C0")]
		add
		{
		}
		[Token(Token = "0x600230B")]
		[Address(RVA = "0xB4B2C0", Offset = "0xB4A2C0", VA = "0x180B4B2C0")]
		remove
		{
		}
	}

	// Token: 0x14000042 RID: 66
	// (add) Token: 0x0600230C RID: 8972 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600230D RID: 8973 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000042")]
	public event MapController.RemoveRoute OnRemoveRoute
	{
		[Token(Token = "0x600230C")]
		[Address(RVA = "0xB4B3C0", Offset = "0xB4A3C0", VA = "0x180B4B3C0")]
		add
		{
		}
		[Token(Token = "0x600230D")]
		[Address(RVA = "0xB4B4C0", Offset = "0xB4A4C0", VA = "0x180B4B4C0")]
		remove
		{
		}
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x0600230E RID: 8974 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000120")]
	public static MapController Instance
	{
		[Token(Token = "0x600230E")]
		[Address(RVA = "0xB4B5C0", Offset = "0xB4A5C0", VA = "0x180B4B5C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600230F RID: 8975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600230F")]
	[Address(RVA = "0xB4B600", Offset = "0xB4A600", VA = "0x180B4B600")]
	private void Awake()
	{
	}

	// Token: 0x06002310 RID: 8976 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002310")]
	[Address(RVA = "0xB4B950", Offset = "0xB4A950", VA = "0x180B4B950")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002311 RID: 8977 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002311")]
	[Address(RVA = "0xB4BB60", Offset = "0xB4AB60", VA = "0x180B4BB60")]
	public void Setup()
	{
	}

	// Token: 0x06002312 RID: 8978 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002312")]
	[Address(RVA = "0xB4C670", Offset = "0xB4B670", VA = "0x180B4C670")]
	public void ControllerMapHoverChange(ButtonController hoveredButton, bool hovered)
	{
	}

	// Token: 0x06002313 RID: 8979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002313")]
	[Address(RVA = "0xB4C760", Offset = "0xB4B760", VA = "0x180B4C760")]
	public void BuildMap()
	{
	}

	// Token: 0x06002314 RID: 8980 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002314")]
	[Address(RVA = "0xB50670", Offset = "0xB4F670", VA = "0x180B50670")]
	public void UpdateNeededMapDisplay()
	{
	}

	// Token: 0x06002315 RID: 8981 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002315")]
	[Address(RVA = "0xB51170", Offset = "0xB50170", VA = "0x180B51170")]
	public void AddUpdateCall(MapAddressButtonController loc, bool needsImageRebuild = true)
	{
	}

	// Token: 0x06002316 RID: 8982 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002316")]
	[Address(RVA = "0xB512F0", Offset = "0xB502F0", VA = "0x180B512F0")]
	public void AddDuctUpdateCall(MapDuctsButtonController loc, bool needsImageRebuild = true)
	{
	}

	// Token: 0x06002317 RID: 8983 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002317")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void OnPinNewEvidence(Evidence ev)
	{
	}

	// Token: 0x06002318 RID: 8984 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002318")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void OnUnpinEvidence(Evidence ev)
	{
	}

	// Token: 0x06002319 RID: 8985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002319")]
	[Address(RVA = "0xB51470", Offset = "0xB50470", VA = "0x180B51470")]
	public void PinnedDataKeyChange()
	{
	}

	// Token: 0x0600231A RID: 8986 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600231A")]
	[Address(RVA = "0xB51770", Offset = "0xB50770", VA = "0x180B51770")]
	public void AddNewTrackedObject(Transform gameObj, Sprite mapIcon, Vector2 size, Color colour, bool isDynamic, object buttonReference)
	{
	}

	// Token: 0x0600231B RID: 8987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600231B")]
	[Address(RVA = "0xB51CA0", Offset = "0xB50CA0", VA = "0x180B51CA0")]
	public void PressTracked(ButtonController pressedButton)
	{
	}

	// Token: 0x0600231C RID: 8988 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600231C")]
	[Address(RVA = "0xB51E80", Offset = "0xB50E80", VA = "0x180B51E80")]
	public void HoverTracked(ButtonController hoveredButton, bool hovered)
	{
	}

	// Token: 0x0600231D RID: 8989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600231D")]
	[Address(RVA = "0xB52230", Offset = "0xB51230", VA = "0x180B52230")]
	public void RemoveTrackedObject(Transform gameObj)
	{
	}

	// Token: 0x0600231E RID: 8990 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600231E")]
	[Address(RVA = "0xB52830", Offset = "0xB51830", VA = "0x180B52830")]
	public void UpdateTrackedObject(Transform gameObj, RectTransform mapObj)
	{
	}

	// Token: 0x0600231F RID: 8991 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600231F")]
	[Address(RVA = "0xB52BE0", Offset = "0xB51BE0", VA = "0x180B52BE0")]
	public void CentreOnTrackedObject(Transform gameObj, bool instant = false)
	{
	}

	// Token: 0x06002320 RID: 8992 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002320")]
	[Address(RVA = "0xB52EB0", Offset = "0xB51EB0", VA = "0x180B52EB0")]
	public void CentreOnObject(RectTransform mapObj, bool instant = false, bool showPointer = false)
	{
	}

	// Token: 0x06002321 RID: 8993 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002321")]
	[Address(RVA = "0xB535E0", Offset = "0xB525E0", VA = "0x180B535E0")]
	public void CentreOnNodeCoordinate(Vector3 pathCoord, bool instant = false, bool showPointer = false)
	{
	}

	// Token: 0x06002322 RID: 8994 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
	[Token(Token = "0x6002322")]
	[Address(RVA = "0xB53AB0", Offset = "0xB52AB0", VA = "0x180B53AB0")]
	public Vector2 ClampMapScrollPosition(Vector2 focusPos)
	{
		return default(Vector2);
	}

	// Token: 0x06002323 RID: 8995 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002323")]
	[Address(RVA = "0xB53CF0", Offset = "0xB52CF0", VA = "0x180B53CF0")]
	public void SetFloorLayer(int newFloor, bool forceLoad = false)
	{
	}

	// Token: 0x06002324 RID: 8996 RVA: 0x0000E508 File Offset: 0x0000C708
	[Token(Token = "0x6002324")]
	[Address(RVA = "0xB54F40", Offset = "0xB53F40", VA = "0x180B54F40")]
	public Vector2 NodeCoordToMap(Vector3 pos)
	{
		return default(Vector2);
	}

	// Token: 0x06002325 RID: 8997 RVA: 0x0000E520 File Offset: 0x0000C720
	[Token(Token = "0x6002325")]
	[Address(RVA = "0xB54F90", Offset = "0xB53F90", VA = "0x180B54F90")]
	public Vector2 RealPosToMap(Vector3 coords)
	{
		return default(Vector2);
	}

	// Token: 0x06002326 RID: 8998 RVA: 0x0000E538 File Offset: 0x0000C738
	[Token(Token = "0x6002326")]
	[Address(RVA = "0xB55150", Offset = "0xB54150", VA = "0x180B55150")]
	public Vector2 MapToNode(Vector2 coords)
	{
		return default(Vector2);
	}

	// Token: 0x06002327 RID: 8999 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002327")]
	[Address(RVA = "0xB55280", Offset = "0xB54280", VA = "0x180B55280")]
	private void Update()
	{
	}

	// Token: 0x06002328 RID: 9000 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002328")]
	[Address(RVA = "0xB57550", Offset = "0xB56550", VA = "0x180B57550")]
	private void OnEnable()
	{
	}

	// Token: 0x06002329 RID: 9001 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002329")]
	[Address(RVA = "0xB57C30", Offset = "0xB56C30", VA = "0x180B57C30")]
	private void OnDisable()
	{
	}

	// Token: 0x0600232A RID: 9002 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600232A")]
	[Address(RVA = "0xB58210", Offset = "0xB57210", VA = "0x180B58210")]
	private void UpdateSize()
	{
	}

	// Token: 0x0600232B RID: 9003 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600232B")]
	[Address(RVA = "0xB582A0", Offset = "0xB572A0", VA = "0x180B582A0")]
	public void OpenMap(bool firstPerson, bool playSound = true)
	{
	}

	// Token: 0x0600232C RID: 9004 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600232C")]
	[Address(RVA = "0xB58B70", Offset = "0xB57B70", VA = "0x180B58B70")]
	private IEnumerator Open()
	{
		return null;
	}

	// Token: 0x0600232D RID: 9005 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600232D")]
	[Address(RVA = "0xB58C10", Offset = "0xB57C10", VA = "0x180B58C10")]
	public void CloseMap(bool playSound = true)
	{
	}

	// Token: 0x0600232E RID: 9006 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600232E")]
	[Address(RVA = "0xB59A00", Offset = "0xB58A00", VA = "0x180B59A00")]
	private IEnumerator Close()
	{
		return null;
	}

	// Token: 0x0600232F RID: 9007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600232F")]
	[Address(RVA = "0xB59AA0", Offset = "0xB58AA0", VA = "0x180B59AA0")]
	public void LocateEvidenceOnMap(Evidence ev)
	{
	}

	// Token: 0x06002330 RID: 9008 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002330")]
	[Address(RVA = "0xB5A2D0", Offset = "0xB592D0", VA = "0x180B5A2D0")]
	public void LocateRoomOnMap(NewRoom room)
	{
	}

	// Token: 0x06002331 RID: 9009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002331")]
	[Address(RVA = "0xB5A6F0", Offset = "0xB596F0", VA = "0x180B5A6F0")]
	public void PlotPlayerRoute(Evidence ev)
	{
	}

	// Token: 0x06002332 RID: 9010 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002332")]
	[Address(RVA = "0xB5AA70", Offset = "0xB59A70", VA = "0x180B5AA70")]
	public void PlotPlayerRoute(NewGameLocation loc)
	{
	}

	// Token: 0x06002333 RID: 9011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002333")]
	[Address(RVA = "0xB5AE70", Offset = "0xB59E70", VA = "0x180B5AE70")]
	public void PlotPlayerRoute(NewAddress loc)
	{
	}

	// Token: 0x06002334 RID: 9012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002334")]
	[Address(RVA = "0xB5AFD0", Offset = "0xB59FD0", VA = "0x180B5AFD0")]
	public void PlotPlayerRoute(StreetController loc)
	{
	}

	// Token: 0x06002335 RID: 9013 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002335")]
	[Address(RVA = "0xB5B130", Offset = "0xB5A130", VA = "0x180B5B130")]
	public void PlotPlayerRoute(NewNode loc, bool nodeSpecific, [Optional] NewGameLocation destinationTextOverride)
	{
	}

	// Token: 0x06002336 RID: 9014 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002336")]
	[Address(RVA = "0xB5C290", Offset = "0xB5B290", VA = "0x180B5C290")]
	public void RemovePlayerRoute()
	{
	}

	// Token: 0x06002337 RID: 9015 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002337")]
	[Address(RVA = "0xB5C2B0", Offset = "0xB5B2B0", VA = "0x180B5C2B0")]
	private void SetTimelineCitizenTransparency(int citizenFloor, RectTransform objectRect)
	{
	}

	// Token: 0x06002338 RID: 9016 RVA: 0x0000E550 File Offset: 0x0000C750
	[Token(Token = "0x6002338")]
	[Address(RVA = "0xB5C4A0", Offset = "0xB5B4A0", VA = "0x180B5C4A0")]
	private Vector3 FindWorldPoint(PathFinder.PathData pathData, float percentAlong, out int lastPointIndex, out float distanceSinceLastPoint, out int nextPointIndex)
	{
		return default(Vector3);
	}

	// Token: 0x06002339 RID: 9017 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002339")]
	[Address(RVA = "0xB5C510", Offset = "0xB5B510", VA = "0x180B5C510")]
	public void DisplayDirectionArrow(bool val)
	{
	}

	// Token: 0x0600233A RID: 9018 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600233A")]
	[Address(RVA = "0xB5C630", Offset = "0xB5B630", VA = "0x180B5C630")]
	public void ResetThis()
	{
	}

	// Token: 0x0600233B RID: 9019 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600233B")]
	[Address(RVA = "0xB5D840", Offset = "0xB5C840", VA = "0x180B5D840")]
	public void ToggleDrawingMode()
	{
	}

	// Token: 0x0600233C RID: 9020 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600233C")]
	[Address(RVA = "0xB5DC90", Offset = "0xB5CC90", VA = "0x180B5DC90")]
	public void OnChangeDrawingColour()
	{
	}

	// Token: 0x0600233D RID: 9021 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600233D")]
	[Address(RVA = "0xB5DEA0", Offset = "0xB5CEA0", VA = "0x180B5DEA0")]
	public void ToggleEraser()
	{
	}

	// Token: 0x0600233E RID: 9022 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600233E")]
	[Address(RVA = "0xB5E190", Offset = "0xB5D190", VA = "0x180B5E190")]
	public void ClearDrawing()
	{
	}

	// Token: 0x0600233F RID: 9023 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600233F")]
	[Address(RVA = "0xB5E210", Offset = "0xB5D210", VA = "0x180B5E210")]
	public void OpenEvidence()
	{
	}

	// Token: 0x06002340 RID: 9024 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002340")]
	[Address(RVA = "0xB5E3F0", Offset = "0xB5D3F0", VA = "0x180B5E3F0")]
	public void PlotRoute()
	{
	}

	// Token: 0x06002341 RID: 9025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002341")]
	[Address(RVA = "0xB5E520", Offset = "0xB5D520", VA = "0x180B5E520")]
	public void AutoTravel()
	{
	}

	// Token: 0x06002342 RID: 9026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002342")]
	[Address(RVA = "0xB5C290", Offset = "0xB5B290", VA = "0x180B5C290")]
	public void CancelRoute()
	{
	}

	// Token: 0x06002343 RID: 9027 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002343")]
	[Address(RVA = "0xB5E690", Offset = "0xB5D690", VA = "0x180B5E690")]
	public void DebugAccess()
	{
	}

	// Token: 0x06002344 RID: 9028 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002344")]
	[Address(RVA = "0xB5EF70", Offset = "0xB5DF70", VA = "0x180B5EF70")]
	public MapController()
	{
	}

	// Token: 0x04002CBF RID: 11455
	[Token(Token = "0x4002CBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RectTransform contentRect;

	// Token: 0x04002CC0 RID: 11456
	[Token(Token = "0x4002CC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RectTransform paperRect;

	// Token: 0x04002CC1 RID: 11457
	[Token(Token = "0x4002CC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RectTransform viewport;

	// Token: 0x04002CC2 RID: 11458
	[Token(Token = "0x4002CC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ZoomContent zoomController;

	// Token: 0x04002CC3 RID: 11459
	[Token(Token = "0x4002CC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public DragCoverage drag;

	// Token: 0x04002CC4 RID: 11460
	[Token(Token = "0x4002CC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public CustomScrollRect scrollRect;

	// Token: 0x04002CC5 RID: 11461
	[Token(Token = "0x4002CC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RectTransform controlsRect;

	// Token: 0x04002CC6 RID: 11462
	[Token(Token = "0x4002CC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Canvas contentCanvas;

	// Token: 0x04002CC7 RID: 11463
	[Token(Token = "0x4002CC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ButtonController mapCloseButton;

	// Token: 0x04002CC8 RID: 11464
	[Token(Token = "0x4002CC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RectTransform mapCursor;

	// Token: 0x04002CC9 RID: 11465
	[Token(Token = "0x4002CC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ContextMenuController mapContextMenu;

	// Token: 0x04002CCA RID: 11466
	[Token(Token = "0x4002CCA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI districtMapName;

	// Token: 0x04002CCB RID: 11467
	[Token(Token = "0x4002CCB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ButtonController centreOnPlayerButton;

	// Token: 0x04002CCC RID: 11468
	[Token(Token = "0x4002CCC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ButtonController controllerSelectMapButton;

	// Token: 0x04002CCD RID: 11469
	[Token(Token = "0x4002CCD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ButtonController plotRouteButton;

	// Token: 0x04002CCE RID: 11470
	[Token(Token = "0x4002CCE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public ButtonController autoTravelButton;

	// Token: 0x04002CCF RID: 11471
	[Token(Token = "0x4002CCF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public JuiceController plotRouteActiveJuice;

	// Token: 0x04002CD0 RID: 11472
	[Token(Token = "0x4002CD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public JuiceController autoTravelActiveJuice;

	// Token: 0x04002CD1 RID: 11473
	[Token(Token = "0x4002CD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Sprite autoTravelIcon;

	// Token: 0x04002CD2 RID: 11474
	[Token(Token = "0x4002CD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Sprite fastTravelIcon;

	// Token: 0x04002CD3 RID: 11475
	[Token(Token = "0x4002CD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public RectTransform viewportCenter;

	// Token: 0x04002CD4 RID: 11476
	[Token(Token = "0x4002CD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject mapLoadingGraphic;

	// Token: 0x04002CD5 RID: 11477
	[Token(Token = "0x4002CD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool drawingMode;

	// Token: 0x04002CD6 RID: 11478
	[Token(Token = "0x4002CD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	public bool eraseMode;

	// Token: 0x04002CD7 RID: 11479
	[Token(Token = "0x4002CD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public Color drawingColour;

	// Token: 0x04002CD8 RID: 11480
	[Token(Token = "0x4002CD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public RectTransform drawBrushRect;

	// Token: 0x04002CD9 RID: 11481
	[Token(Token = "0x4002CD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public ButtonController toggleDrawingButton;

	// Token: 0x04002CDA RID: 11482
	[Token(Token = "0x4002CDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public ColourSelectorButtonController colourButton;

	// Token: 0x04002CDB RID: 11483
	[Token(Token = "0x4002CDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public ButtonController eraserButton;

	// Token: 0x04002CDC RID: 11484
	[Token(Token = "0x4002CDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public ButtonController clearButton;

	// Token: 0x04002CDD RID: 11485
	[Token(Token = "0x4002CDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public int load;

	// Token: 0x04002CDE RID: 11486
	[Token(Token = "0x4002CDE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public bool displayPlayerCharacter;

	// Token: 0x04002CDF RID: 11487
	[Token(Token = "0x4002CDF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
	public bool displayFirstPerson;

	// Token: 0x04002CE0 RID: 11488
	[Token(Token = "0x4002CE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public RectTransform playerCharacterRect;

	// Token: 0x04002CE1 RID: 11489
	[Token(Token = "0x4002CE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public NewNode mapCursorNode;

	// Token: 0x04002CE2 RID: 11490
	[Token(Token = "0x4002CE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private NewNode cursorNodeChange;

	// Token: 0x04002CE3 RID: 11491
	[Token(Token = "0x4002CE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Vector2 cursorPos;

	// Token: 0x04002CE4 RID: 11492
	[Token(Token = "0x4002CE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public List<MapAddressButtonController> mapUpdateList;

	// Token: 0x04002CE5 RID: 11493
	[Token(Token = "0x4002CE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public List<MapDuctsButtonController> ductsUpdateList;

	// Token: 0x04002CE6 RID: 11494
	[Token(Token = "0x4002CE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public List<MapAddressButtonController> mapDrawnList;

	// Token: 0x04002CE7 RID: 11495
	[Token(Token = "0x4002CE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public RectTransform routesRect;

	// Token: 0x04002CE8 RID: 11496
	[Token(Token = "0x4002CE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public RectTransform linesRouteRect;

	// Token: 0x04002CE9 RID: 11497
	[Token(Token = "0x4002CE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public RectTransform citizensRouteRect;

	// Token: 0x04002CEA RID: 11498
	[Token(Token = "0x4002CEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public RectTransform sightingsRoutRect;

	// Token: 0x04002CEB RID: 11499
	[Token(Token = "0x4002CEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public RectTransform overlayAll;

	// Token: 0x04002CEC RID: 11500
	[Token(Token = "0x4002CEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public RectTransform pinsRect;

	// Token: 0x04002CED RID: 11501
	[Token(Token = "0x4002CED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public RectTransform tooltipOverride;

	// Token: 0x04002CEE RID: 11502
	[Token(Token = "0x4002CEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private List<MapController.PointerData> pointers;

	// Token: 0x04002CEF RID: 11503
	[Token(Token = "0x4002CEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public Dictionary<Transform, List<RectTransform>> dynamicTrackedObjects;

	// Token: 0x04002CF0 RID: 11504
	[Token(Token = "0x4002CF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public Dictionary<Transform, List<RectTransform>> staticTrackedObjects;

	// Token: 0x04002CF1 RID: 11505
	[Token(Token = "0x4002CF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public Dictionary<InfoWindow, MapPinButtonController> pinnedObjects;

	// Token: 0x04002CF2 RID: 11506
	[Token(Token = "0x4002CF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public List<InfoWindow> invisiblePins;

	// Token: 0x04002CF3 RID: 11507
	[Token(Token = "0x4002CF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public TextMeshProUGUI keyUnexplored;

	// Token: 0x04002CF4 RID: 11508
	[Token(Token = "0x4002CF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public TextMeshProUGUI keyExploredSafe;

	// Token: 0x04002CF5 RID: 11509
	[Token(Token = "0x4002CF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public TextMeshProUGUI keyExploredPrivate;

	// Token: 0x04002CF6 RID: 11510
	[Token(Token = "0x4002CF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public TextMeshProUGUI keyVent;

	// Token: 0x04002CF7 RID: 11511
	[Token(Token = "0x4002CF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public TextMeshProUGUI keyDuct;

	// Token: 0x04002CF8 RID: 11512
	[Token(Token = "0x4002CF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public TextMeshProUGUI keyOpenHoursOnly;

	// Token: 0x04002CF9 RID: 11513
	[Token(Token = "0x4002CF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public float nodePositionMultiplier;

	// Token: 0x04002CFA RID: 11514
	[Token(Token = "0x4002CFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	private float realPositionMultiplier;

	// Token: 0x04002CFB RID: 11515
	[Token(Token = "0x4002CFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public float positionBuffer;

	// Token: 0x04002CFC RID: 11516
	[Token(Token = "0x4002CFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public float edgeBuffer;

	// Token: 0x04002CFD RID: 11517
	[Token(Token = "0x4002CFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public float focusSpeed;

	// Token: 0x04002CFE RID: 11518
	[Token(Token = "0x4002CFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
	public float openProgress;

	// Token: 0x04002CFF RID: 11519
	[Token(Token = "0x4002CFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public float savedSize;

	// Token: 0x04002D00 RID: 11520
	[Token(Token = "0x4002D00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public RectTransform baseLayer;

	// Token: 0x04002D01 RID: 11521
	[Token(Token = "0x4002D01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public FloorZoomController fzc;

	// Token: 0x04002D02 RID: 11522
	[Token(Token = "0x4002D02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private bool forceFocusActive;

	// Token: 0x04002D03 RID: 11523
	[Token(Token = "0x4002D03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	private float forceFocusProgress;

	// Token: 0x04002D04 RID: 11524
	[Token(Token = "0x4002D04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private RectTransform focusRect;

	// Token: 0x04002D05 RID: 11525
	[Token(Token = "0x4002D05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private Vector2 focusPos;

	// Token: 0x04002D06 RID: 11526
	[Token(Token = "0x4002D06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private Vector2 lastViewportCentrePos;

	// Token: 0x04002D07 RID: 11527
	[Token(Token = "0x4002D07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public MapController.MapRoute playerRoute;

	// Token: 0x04002D08 RID: 11528
	[Token(Token = "0x4002D08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public float mapResolutionDivision;

	// Token: 0x04002D09 RID: 11529
	[Token(Token = "0x4002D09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
	public int wallWidth;

	// Token: 0x04002D0A RID: 11530
	[Token(Token = "0x4002D0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public Color roomBaseColor;

	// Token: 0x04002D0B RID: 11531
	[Token(Token = "0x4002D0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public Color highlightedColourAdditive;

	// Token: 0x04002D0C RID: 11532
	[Token(Token = "0x4002D0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	public Texture2D publicFloorTexture;

	// Token: 0x04002D0D RID: 11533
	[Token(Token = "0x4002D0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	public Texture2D privateFloorTexture;

	// Token: 0x04002D0E RID: 11534
	[Token(Token = "0x4002D0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public Texture2D nullRoomTexture;

	// Token: 0x04002D0F RID: 11535
	[Token(Token = "0x4002D0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	public Texture2D undiscoveredTexture;

	// Token: 0x04002D10 RID: 11536
	[Token(Token = "0x4002D10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	public Texture2D wallTexture;

	// Token: 0x04002D11 RID: 11537
	[Token(Token = "0x4002D11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	public Texture2D wallTexCorners;

	// Token: 0x04002D12 RID: 11538
	[Token(Token = "0x4002D12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	public List<Texture2D> wallEdge;

	// Token: 0x04002D13 RID: 11539
	[Token(Token = "0x4002D13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	public List<Texture2D> wallDoorway;

	// Token: 0x04002D14 RID: 11540
	[Token(Token = "0x4002D14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	public List<Texture2D> wallWindow;

	// Token: 0x04002D15 RID: 11541
	[Token(Token = "0x4002D15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	public List<Texture2D> outsideWindow;

	// Token: 0x04002D16 RID: 11542
	[Token(Token = "0x4002D16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	public List<Texture2D> dividerLeft;

	// Token: 0x04002D17 RID: 11543
	[Token(Token = "0x4002D17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	public List<Texture2D> dividerRight;

	// Token: 0x04002D18 RID: 11544
	[Token(Token = "0x4002D18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	public List<Texture2D> stairwell;

	// Token: 0x04002D19 RID: 11545
	[Token(Token = "0x4002D19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	public Texture2D vent;

	// Token: 0x04002D1A RID: 11546
	[Token(Token = "0x4002D1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	public Texture2D ventUpwardsConnection;

	// Token: 0x04002D1B RID: 11547
	[Token(Token = "0x4002D1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	public Texture2D ventDownwardsConnection;

	// Token: 0x04002D1C RID: 11548
	[Token(Token = "0x4002D1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	public GameObject directionalArrowContainer;

	// Token: 0x04002D1D RID: 11549
	[Token(Token = "0x4002D1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	public bool displayDirectionArrow;

	// Token: 0x04002D1E RID: 11550
	[Token(Token = "0x4002D1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	public Transform directionalArrow;

	// Token: 0x04002D1F RID: 11551
	[Token(Token = "0x4002D1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	public float directionalArrowDesiredFade;

	// Token: 0x04002D20 RID: 11552
	[Token(Token = "0x4002D20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
	public float directionalArrowAlpha;

	// Token: 0x04002D21 RID: 11553
	[Token(Token = "0x4002D21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	public Material arrowMaterial;

	// Token: 0x04002D22 RID: 11554
	[Token(Token = "0x4002D22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	public Dictionary<int, MapController.MapLayer> mapLayers;

	// Token: 0x04002D23 RID: 11555
	[Token(Token = "0x4002D23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	public List<MapAddressButtonController> buttons;

	// Token: 0x04002D24 RID: 11556
	[Token(Token = "0x4002D24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	private List<GameObject> spawnedDebugComponents;

	// Token: 0x04002D27 RID: 11559
	[Token(Token = "0x4002D27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MapController _instance;

	// Token: 0x0200063A RID: 1594
	[Token(Token = "0x200063A")]
	public class PointerData
	{
		// Token: 0x06002345 RID: 9029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002345")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public PointerData()
		{
		}

		// Token: 0x04002D28 RID: 11560
		[Token(Token = "0x4002D28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform pointerObject;

		// Token: 0x04002D29 RID: 11561
		[Token(Token = "0x4002D29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform followRect;

		// Token: 0x04002D2A RID: 11562
		[Token(Token = "0x4002D2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 followPos;

		// Token: 0x04002D2B RID: 11563
		[Token(Token = "0x4002D2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float pointerShow;
	}

	// Token: 0x0200063B RID: 1595
	[Token(Token = "0x200063B")]
	public class MapRoute
	{
		// Token: 0x06002346 RID: 9030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002346")]
		[Address(RVA = "0xB5FAF0", Offset = "0xB5EAF0", VA = "0x180B5FAF0")]
		public MapRoute(NewNode newStart, NewNode newEnd, Human newHuman, bool newNodeSpecific, NewGameLocation newDestinationTextOverride)
		{
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x0000E568 File Offset: 0x0000C768
		[Token(Token = "0x6002347")]
		[Address(RVA = "0xB5FFF0", Offset = "0xB5EFF0", VA = "0x180B5FFF0")]
		public bool TryUpdateRouteCursor(out int newCursor, out int usedTolerance, int offcourseTolerance = 1)
		{
			return default(bool);
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002348")]
		[Address(RVA = "0xB60670", Offset = "0xB5F670", VA = "0x180B60670")]
		public void UpdateRouteBasedOnPlayerPosition()
		{
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x0000E580 File Offset: 0x0000C780
		[Token(Token = "0x6002349")]
		[Address(RVA = "0xB60C60", Offset = "0xB5FC60", VA = "0x180B60C60")]
		public bool UpdatePathData(NewNode fromNode)
		{
			return default(bool);
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234A")]
		[Address(RVA = "0xB61370", Offset = "0xB60370", VA = "0x180B61370")]
		public void UpdateDrawnRoute()
		{
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234B")]
		[Address(RVA = "0xB61E70", Offset = "0xB60E70", VA = "0x180B61E70")]
		public void Remove()
		{
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600234C")]
		[Address(RVA = "0xB62BD0", Offset = "0xB61BD0", VA = "0x180B62BD0")]
		public string GetDestinationText()
		{
			return null;
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600234D")]
		[Address(RVA = "0xB62D10", Offset = "0xB61D10", VA = "0x180B62D10")]
		public NewGameLocation GetDestinationLocation()
		{
			return null;
		}

		// Token: 0x04002D2C RID: 11564
		[Token(Token = "0x4002D2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewNode start;

		// Token: 0x04002D2D RID: 11565
		[Token(Token = "0x4002D2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewNode end;

		// Token: 0x04002D2E RID: 11566
		[Token(Token = "0x4002D2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NewGameLocation destinationTextOverride;

		// Token: 0x04002D2F RID: 11567
		[Token(Token = "0x4002D2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Human human;

		// Token: 0x04002D30 RID: 11568
		[Token(Token = "0x4002D30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int routeCursor;

		// Token: 0x04002D31 RID: 11569
		[Token(Token = "0x4002D31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public PathFinder.PathData pathData;

		// Token: 0x04002D32 RID: 11570
		[Token(Token = "0x4002D32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool nodeSpecific;

		// Token: 0x04002D33 RID: 11571
		[Token(Token = "0x4002D33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int lastUsedTolerance;

		// Token: 0x04002D34 RID: 11572
		[Token(Token = "0x4002D34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private NewNode drawnFrom;

		// Token: 0x04002D35 RID: 11573
		[Token(Token = "0x4002D35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NewNode drawnTo;

		// Token: 0x04002D36 RID: 11574
		[Token(Token = "0x4002D36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Dictionary<GameObject, NewNode> spawnedObjects;

		// Token: 0x0200063C RID: 1596
		[Token(Token = "0x200063C")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x0600234E RID: 9038 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600234E")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x0600234F RID: 9039 RVA: 0x0000E598 File Offset: 0x0000C798
			[Token(Token = "0x600234F")]
			[Address(RVA = "0xB62E30", Offset = "0xB61E30", VA = "0x180B62E30")]
			internal bool <TryUpdateRouteCursor>b__0(NewNode.NodeAccess item)
			{
				return default(bool);
			}

			// Token: 0x04002D37 RID: 11575
			[Token(Token = "0x4002D37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 searchNodeCoord;
		}

		// Token: 0x0200063D RID: 1597
		[Token(Token = "0x200063D")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002351 RID: 9041 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002351")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c()
			{
			}

			// Token: 0x06002352 RID: 9042 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
			[Token(Token = "0x6002352")]
			[Address(RVA = "0xB62FF0", Offset = "0xB61FF0", VA = "0x180B62FF0")]
			internal bool <UpdatePathData>b__14_0(NewNode.NodeAccess item)
			{
				return default(bool);
			}

			// Token: 0x04002D38 RID: 11576
			[Token(Token = "0x4002D38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly MapController.MapRoute.<>c <>9;

			// Token: 0x04002D39 RID: 11577
			[Token(Token = "0x4002D39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<NewNode.NodeAccess> <>9__14_0;
		}
	}

	// Token: 0x0200063E RID: 1598
	[Token(Token = "0x200063E")]
	public struct MapLayer
	{
		// Token: 0x04002D3A RID: 11578
		[Token(Token = "0x4002D3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Canvas canvas;

		// Token: 0x04002D3B RID: 11579
		[Token(Token = "0x4002D3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CanvasGroup canvasGroup;

		// Token: 0x04002D3C RID: 11580
		[Token(Token = "0x4002D3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform backgroundContainer;

		// Token: 0x04002D3D RID: 11581
		[Token(Token = "0x4002D3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform baseContainer;

		// Token: 0x04002D3E RID: 11582
		[Token(Token = "0x4002D3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RectTransform ductsContainer;

		// Token: 0x04002D3F RID: 11583
		[Token(Token = "0x4002D3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DrawingController drawingController;

		// Token: 0x04002D40 RID: 11584
		[Token(Token = "0x4002D40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<Vector2, RawImage> baseBackgroundImages;

		// Token: 0x04002D41 RID: 11585
		[Token(Token = "0x4002D41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<Vector2, Image> wallImages;
	}

	// Token: 0x0200063F RID: 1599
	// (Invoke) Token: 0x06002354 RID: 9044
	[Token(Token = "0x200063F")]
	public delegate void RoutePlot();

	// Token: 0x02000640 RID: 1600
	// (Invoke) Token: 0x06002358 RID: 9048
	[Token(Token = "0x2000640")]
	public delegate void RemoveRoute();

	// Token: 0x02000641 RID: 1601
	[Token(Token = "0x2000641")]
	private sealed class <>c__DisplayClass120_0
	{
		// Token: 0x0600235B RID: 9051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass120_0()
		{
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		[Token(Token = "0x600235C")]
		[Address(RVA = "0xB63020", Offset = "0xB62020", VA = "0x180B63020")]
		internal bool <BuildMap>b__0(NewTile item)
		{
			return default(bool);
		}

		// Token: 0x04002D42 RID: 11586
		[Token(Token = "0x4002D42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewTile searchTile;
	}

	// Token: 0x02000642 RID: 1602
	[Token(Token = "0x2000642")]
	private sealed class <>c__DisplayClass120_1
	{
		// Token: 0x0600235D RID: 9053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass120_1()
		{
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		[Token(Token = "0x600235E")]
		[Address(RVA = "0xB63090", Offset = "0xB62090", VA = "0x180B63090")]
		internal bool <BuildMap>b__1(NewTile item)
		{
			return default(bool);
		}

		// Token: 0x04002D43 RID: 11587
		[Token(Token = "0x4002D43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewTile searchTile;
	}

	// Token: 0x02000643 RID: 1603
	[Token(Token = "0x2000643")]
	private sealed class <>c__DisplayClass121_0
	{
		// Token: 0x0600235F RID: 9055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass121_0()
		{
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		[Token(Token = "0x6002360")]
		[Address(RVA = "0xB63100", Offset = "0xB62100", VA = "0x180B63100")]
		internal int <UpdateNeededMapDisplay>b__0(MapAddressButtonController p1, MapAddressButtonController p2)
		{
			return 0;
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x0000E610 File Offset: 0x0000C810
		[Token(Token = "0x6002361")]
		[Address(RVA = "0xB63100", Offset = "0xB62100", VA = "0x180B63100")]
		internal int <UpdateNeededMapDisplay>b__1(MapAddressButtonController p1, MapAddressButtonController p2)
		{
			return 0;
		}

		// Token: 0x04002D44 RID: 11588
		[Token(Token = "0x4002D44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 centralMapPosition;
	}

	// Token: 0x02000644 RID: 1604
	[Token(Token = "0x2000644")]
	private sealed class <Open>d__145 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06002362 RID: 9058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002362")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Open>d__145(int <>1__state)
		{
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002363")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x0000E628 File Offset: 0x0000C828
		[Token(Token = "0x6002364")]
		[Address(RVA = "0xB631D0", Offset = "0xB621D0", VA = "0x180B631D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000121")]
		private object Current
		{
			[Token(Token = "0x6002365")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002366")]
		[Address(RVA = "0xB63600", Offset = "0xB62600", VA = "0x180B63600", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000122")]
		private object Current
		{
			[Token(Token = "0x6002367")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002D45 RID: 11589
		[Token(Token = "0x4002D45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002D46 RID: 11590
		[Token(Token = "0x4002D46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002D47 RID: 11591
		[Token(Token = "0x4002D47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MapController <>4__this;
	}

	// Token: 0x02000645 RID: 1605
	[Token(Token = "0x2000645")]
	private sealed class <Close>d__147 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06002368 RID: 9064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002368")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Close>d__147(int <>1__state)
		{
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002369")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x0000E640 File Offset: 0x0000C840
		[Token(Token = "0x600236A")]
		[Address(RVA = "0xB63650", Offset = "0xB62650", VA = "0x180B63650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000123")]
		private object Current
		{
			[Token(Token = "0x600236B")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236C")]
		[Address(RVA = "0xB63A40", Offset = "0xB62A40", VA = "0x180B63A40", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000124")]
		private object Current
		{
			[Token(Token = "0x600236D")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002D48 RID: 11592
		[Token(Token = "0x4002D48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002D49 RID: 11593
		[Token(Token = "0x4002D49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002D4A RID: 11594
		[Token(Token = "0x4002D4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MapController <>4__this;
	}

	// Token: 0x02000646 RID: 1606
	[Token(Token = "0x2000646")]
	private sealed class <>c__DisplayClass148_0
	{
		// Token: 0x0600236E RID: 9070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass148_0()
		{
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x0000E658 File Offset: 0x0000C858
		[Token(Token = "0x600236F")]
		[Address(RVA = "0xB63A90", Offset = "0xB62A90", VA = "0x180B63A90")]
		internal bool <LocateEvidenceOnMap>b__0(MapAddressButtonController item)
		{
			return default(bool);
		}

		// Token: 0x04002D4B RID: 11595
		[Token(Token = "0x4002D4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EvidenceLocation loc;
	}

	// Token: 0x02000647 RID: 1607
	[Token(Token = "0x2000647")]
	private sealed class <>c__DisplayClass148_1
	{
		// Token: 0x06002370 RID: 9072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002370")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass148_1()
		{
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x0000E670 File Offset: 0x0000C870
		[Token(Token = "0x6002371")]
		[Address(RVA = "0xB63AC0", Offset = "0xB62AC0", VA = "0x180B63AC0")]
		internal bool <LocateEvidenceOnMap>b__1(MapAddressButtonController item)
		{
			return default(bool);
		}

		// Token: 0x04002D4C RID: 11596
		[Token(Token = "0x4002D4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewAddress lob;
	}
}
