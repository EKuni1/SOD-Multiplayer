using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001FC RID: 508
[Token(Token = "0x20001FC")]
public class CityEditorController : HighlanderSingleton<CityEditorController>
{
	// Token: 0x14000013 RID: 19
	// (add) Token: 0x06000C1E RID: 3102 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000C1F RID: 3103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000013")]
	public event CityEditorController.NewCityEditorData OnNewCityEditorData
	{
		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x58C5B0", Offset = "0x58B5B0", VA = "0x18058C5B0")]
		add
		{
		}
		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x58C6B0", Offset = "0x58B6B0", VA = "0x18058C6B0")]
		remove
		{
		}
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C20")]
	[Address(RVA = "0x58C7B0", Offset = "0x58B7B0", VA = "0x18058C7B0", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06000C21 RID: 3105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C21")]
	[Address(RVA = "0x58CA90", Offset = "0x58BA90", VA = "0x18058CA90")]
	private void Start()
	{
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C22")]
	[Address(RVA = "0x58CAB0", Offset = "0x58BAB0", VA = "0x18058CAB0")]
	private void Update()
	{
	}

	// Token: 0x06000C23 RID: 3107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C23")]
	[Address(RVA = "0x58CAD0", Offset = "0x58BAD0", VA = "0x18058CAD0")]
	private void GetComponentReferences()
	{
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C24")]
	[Address(RVA = "0x58CC60", Offset = "0x58BC60", VA = "0x18058CC60")]
	public void RerunPathfinder()
	{
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C25")]
	[Address(RVA = "0x58D240", Offset = "0x58C240", VA = "0x18058D240")]
	public void GenerateNewCityEditorData()
	{
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C26")]
	[Address(RVA = "0x58D8B0", Offset = "0x58C8B0", VA = "0x18058D8B0")]
	public void OnHaltOnEndOfLoadState(CityConstructor.LoadState haltedOnState)
	{
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C27")]
	[Address(RVA = "0x58DAB0", Offset = "0x58CAB0", VA = "0x18058DAB0")]
	public void ClearCurrentCityEditorData()
	{
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C28")]
	[Address(RVA = "0x58E5F0", Offset = "0x58D5F0", VA = "0x18058E5F0")]
	public void FinishLoading()
	{
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C29")]
	[Address(RVA = "0x58EC80", Offset = "0x58DC80", VA = "0x18058EC80")]
	public void SetCityEditorWarning(string warning)
	{
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0x58ED30", Offset = "0x58DD30", VA = "0x18058ED30")]
	public void SetCityEditor(bool condition)
	{
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0x58F660", Offset = "0x58E660", VA = "0x18058F660")]
	public void SwitchEditorMode(CityEditorController.CityEditorMode mode)
	{
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x58F750", Offset = "0x58E750", VA = "0x18058F750")]
	public void SwitchEditorSubMode(CityEditorController.CityEditorSubMode submode)
	{
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0x58F830", Offset = "0x58E830", VA = "0x18058F830")]
	private void DeactivateEditors()
	{
	}

	// Token: 0x06000C2E RID: 3118 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C2E")]
	[Address(RVA = "0x58F960", Offset = "0x58E960", VA = "0x18058F960")]
	public ButtonController GetLastSelected()
	{
		return null;
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0x58F9F0", Offset = "0x58E9F0", VA = "0x18058F9F0")]
	private void InitializeSelectedModeComponents()
	{
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C30")]
	[Address(RVA = "0x58FB30", Offset = "0x58EB30", VA = "0x18058FB30")]
	public void OnNewTileSelected(CityTile newSelection)
	{
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x000070B0 File Offset: 0x000052B0
	[Token(Token = "0x6000C31")]
	[Address(RVA = "0x58FB50", Offset = "0x58EB50", VA = "0x18058FB50")]
	public bool DoesCurrentMapMeetCityRequirements(bool displayPopups)
	{
		return default(bool);
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C32")]
	[Address(RVA = "0x590AC0", Offset = "0x58FAC0", VA = "0x180590AC0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C33")]
	[Address(RVA = "0x590CA0", Offset = "0x58FCA0", VA = "0x180590CA0")]
	public CityEditorController()
	{
	}

	// Token: 0x04000C85 RID: 3205
	[Token(Token = "0x4000C85")]
	[FieldOffset(Offset = "0x18")]
	public NewBuilding activeBuilding;

	// Token: 0x04000C86 RID: 3206
	[Token(Token = "0x4000C86")]
	[FieldOffset(Offset = "0x20")]
	public Camera cityEditorCam;

	// Token: 0x04000C87 RID: 3207
	[Token(Token = "0x4000C87")]
	[FieldOffset(Offset = "0x28")]
	public CityEditorController.CityEditorMode currentMode;

	// Token: 0x04000C88 RID: 3208
	[Token(Token = "0x4000C88")]
	[FieldOffset(Offset = "0x2C")]
	public CityEditorController.CityEditorSubMode currentSubMode;

	// Token: 0x04000C89 RID: 3209
	[Token(Token = "0x4000C89")]
	[FieldOffset(Offset = "0x30")]
	public PrototypeDebugPanel canvasController;

	// Token: 0x04000C8A RID: 3210
	[Token(Token = "0x4000C8A")]
	[FieldOffset(Offset = "0x38")]
	public GameObject cityEditorPostProcessingVolume;

	// Token: 0x04000C8B RID: 3211
	[Token(Token = "0x4000C8B")]
	[FieldOffset(Offset = "0x40")]
	public List<GameObject> disableWhileActive;

	// Token: 0x04000C8C RID: 3212
	[Token(Token = "0x4000C8C")]
	[FieldOffset(Offset = "0x48")]
	public GameObject cityEditFloor;

	// Token: 0x04000C8D RID: 3213
	[Token(Token = "0x4000C8D")]
	[FieldOffset(Offset = "0x50")]
	public bool needsUpdatedPathfinding;

	// Token: 0x04000C8E RID: 3214
	[Token(Token = "0x4000C8E")]
	[FieldOffset(Offset = "0x51")]
	public bool dataGenerated;

	// Token: 0x04000C8F RID: 3215
	[Token(Token = "0x4000C8F")]
	[FieldOffset(Offset = "0x52")]
	public bool isLoading;

	// Token: 0x04000C90 RID: 3216
	[Token(Token = "0x4000C90")]
	[FieldOffset(Offset = "0x58")]
	public ButtonController previouslySelected;

	// Token: 0x04000C91 RID: 3217
	[Token(Token = "0x4000C91")]
	[FieldOffset(Offset = "0x60")]
	public bool canFinishLoadFromCurrentState;

	// Token: 0x04000C92 RID: 3218
	[Token(Token = "0x4000C92")]
	[FieldOffset(Offset = "0x68")]
	public CityEditorStreetEdit cityEditorStreetEdit;

	// Token: 0x04000C93 RID: 3219
	[Token(Token = "0x4000C93")]
	[FieldOffset(Offset = "0x70")]
	private CityEditorBuildingEdit _buildingEditor;

	// Token: 0x04000C94 RID: 3220
	[Token(Token = "0x4000C94")]
	[FieldOffset(Offset = "0x78")]
	private CityEditorStreetEdit _streetEditor;

	// Token: 0x04000C95 RID: 3221
	[Token(Token = "0x4000C95")]
	[FieldOffset(Offset = "0x80")]
	private CityEditorInputController _editCam;

	// Token: 0x020001FD RID: 509
	[Token(Token = "0x20001FD")]
	[Serializable]
	public enum CityEditorMode
	{
		// Token: 0x04000C98 RID: 3224
		[Token(Token = "0x4000C98")]
		EditBuildings = 1,
		// Token: 0x04000C99 RID: 3225
		[Token(Token = "0x4000C99")]
		EditStreets,
		// Token: 0x04000C9A RID: 3226
		[Token(Token = "0x4000C9A")]
		Default = 0
	}

	// Token: 0x020001FE RID: 510
	[Token(Token = "0x20001FE")]
	[Serializable]
	public enum CityEditorSubMode
	{
		// Token: 0x04000C9C RID: 3228
		[Token(Token = "0x4000C9C")]
		MoveSelection = 1,
		// Token: 0x04000C9D RID: 3229
		[Token(Token = "0x4000C9D")]
		RenameSelection,
		// Token: 0x04000C9E RID: 3230
		[Token(Token = "0x4000C9E")]
		Default = 0
	}

	// Token: 0x020001FF RID: 511
	// (Invoke) Token: 0x06000C35 RID: 3125
	[Token(Token = "0x20001FF")]
	public delegate void NewCityEditorData();

	// Token: 0x02000200 RID: 512
	[Token(Token = "0x2000200")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000C39 RID: 3129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x000070C8 File Offset: 0x000052C8
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x590E60", Offset = "0x58FE60", VA = "0x180590E60")]
		internal bool <FinishLoading>b__31_0(MainMenuController.MenuComponent item)
		{
			return default(bool);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x000070E0 File Offset: 0x000052E0
		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x590E80", Offset = "0x58FE80", VA = "0x180590E80")]
		internal bool <DoesCurrentMapMeetCityRequirements>b__40_0(NewBuilding item)
		{
			return default(bool);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x000070F8 File Offset: 0x000052F8
		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x590F20", Offset = "0x58FF20", VA = "0x180590F20")]
		internal bool <DoesCurrentMapMeetCityRequirements>b__40_1(NewBuilding item)
		{
			return default(bool);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00007110 File Offset: 0x00005310
		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x590FC0", Offset = "0x58FFC0", VA = "0x180590FC0")]
		internal bool <DoesCurrentMapMeetCityRequirements>b__40_2(AddressSaveData item)
		{
			return default(bool);
		}

		// Token: 0x04000C9F RID: 3231
		[Token(Token = "0x4000C9F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CityEditorController.<>c <>9;

		// Token: 0x04000CA0 RID: 3232
		[Token(Token = "0x4000CA0")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<MainMenuController.MenuComponent> <>9__31_0;

		// Token: 0x04000CA1 RID: 3233
		[Token(Token = "0x4000CA1")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<NewBuilding> <>9__40_0;

		// Token: 0x04000CA2 RID: 3234
		[Token(Token = "0x4000CA2")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<NewBuilding> <>9__40_1;

		// Token: 0x04000CA3 RID: 3235
		[Token(Token = "0x4000CA3")]
		[FieldOffset(Offset = "0x20")]
		public static Predicate<AddressSaveData> <>9__40_2;
	}
}
