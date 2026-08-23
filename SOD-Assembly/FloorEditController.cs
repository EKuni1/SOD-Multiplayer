using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200023F RID: 575
[Token(Token = "0x200023F")]
public class FloorEditController : MonoBehaviour
{
	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06000CFA RID: 3322 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700006F")]
	public static FloorEditController Instance
	{
		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x5A8720", Offset = "0x5A7720", VA = "0x1805A8720")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0x5A8760", Offset = "0x5A7760", VA = "0x1805A8760")]
	private void Awake()
	{
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CFC")]
	[Address(RVA = "0x5A8AB0", Offset = "0x5A7AB0", VA = "0x1805A8AB0")]
	private void Start()
	{
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CFD")]
	[Address(RVA = "0x5A9BC0", Offset = "0x5A8BC0", VA = "0x1805A9BC0")]
	public void StartGame()
	{
	}

	// Token: 0x06000CFE RID: 3326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CFE")]
	[Address(RVA = "0x5AA440", Offset = "0x5A9440", VA = "0x1805AA440")]
	private void Update()
	{
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CFF")]
	[Address(RVA = "0x5ABCC0", Offset = "0x5AACC0", VA = "0x1805ABCC0")]
	private void UpdateStatusText()
	{
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D00")]
	[Address(RVA = "0x5ACFB0", Offset = "0x5ABFB0", VA = "0x1805ACFB0")]
	public void SelectNewTile(NewTile newSelect)
	{
	}

	// Token: 0x06000D01 RID: 3329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D01")]
	[Address(RVA = "0x5AD2A0", Offset = "0x5AC2A0", VA = "0x1805AD2A0")]
	public void SelectNewNode(NewNode newSelect)
	{
	}

	// Token: 0x06000D02 RID: 3330 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D02")]
	[Address(RVA = "0x5AD540", Offset = "0x5AC540", VA = "0x1805AD540")]
	public void SelectNewWall(NewWall newSelect)
	{
	}

	// Token: 0x06000D03 RID: 3331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D03")]
	[Address(RVA = "0x5AD7E0", Offset = "0x5AC7E0", VA = "0x1805AD7E0")]
	public void SetDisplayMode(FloorEditController.EditorDisplayMode newMode)
	{
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D04")]
	[Address(RVA = "0x5AE8F0", Offset = "0x5AD8F0", VA = "0x1805AE8F0")]
	public void SetSelectionMode(FloorEditController.EditorSelectionMode newMode)
	{
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x5AEB90", Offset = "0x5ADB90", VA = "0x1805AEB90")]
	public void OnPauseChange(bool openDesktopMode)
	{
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x5B0420", Offset = "0x5AF420", VA = "0x1805B0420")]
	public void SetTool(int newTool)
	{
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x5B0430", Offset = "0x5AF430", VA = "0x1805B0430")]
	public void SetTool(FloorEditController.FloorEditTool newTool, bool forceRefresh = false)
	{
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x5B1180", Offset = "0x5B0180", VA = "0x1805B1180")]
	public void NewFloorButton()
	{
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x5B1390", Offset = "0x5B0390", VA = "0x1805B1390")]
	public void SaveFloorButton()
	{
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0x5B14A0", Offset = "0x5B04A0", VA = "0x1805B14A0")]
	public void SaveAsFloorButton()
	{
	}

	// Token: 0x06000D0B RID: 3339 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0x5B16B0", Offset = "0x5B06B0", VA = "0x1805B16B0")]
	public void EnableSelectionMode(bool val)
	{
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D0C")]
	[Address(RVA = "0x5B1800", Offset = "0x5B0800", VA = "0x1805B1800")]
	public void LoadFloorButton()
	{
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0x5B1C70", Offset = "0x5B0C70", VA = "0x1805B1C70")]
	public void CreateNewFloorTrigger()
	{
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0x5B1FE0", Offset = "0x5B0FE0", VA = "0x1805B1FE0")]
	public void CreateNewFloor()
	{
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0x5B2390", Offset = "0x5B1390", VA = "0x1805B2390")]
	public void SaveAs()
	{
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D10")]
	[Address(RVA = "0x5B2530", Offset = "0x5B1530", VA = "0x1805B2530")]
	public void LoadTrigger()
	{
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D11")]
	[Address(RVA = "0x5B27B0", Offset = "0x5B17B0", VA = "0x1805B27B0")]
	public void Load()
	{
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D12")]
	[Address(RVA = "0x5B28E0", Offset = "0x5B18E0", VA = "0x1805B28E0")]
	public void RecalculateAllTrigger()
	{
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D13")]
	[Address(RVA = "0x5B2A30", Offset = "0x5B1A30", VA = "0x1805B2A30")]
	public void SaveCurrentData(NewFloor data)
	{
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D14")]
	[Address(RVA = "0x5B2D70", Offset = "0x5B1D70", VA = "0x1805B2D70")]
	public void OnCompleteSaveData(NewFloor floor, FloorSaveData newSaveData)
	{
	}

	// Token: 0x06000D15 RID: 3349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D15")]
	[Address(RVA = "0x5B3340", Offset = "0x5B2340", VA = "0x1805B3340")]
	public void LoadData(FloorSaveData savedData)
	{
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D16")]
	[Address(RVA = "0x5B3920", Offset = "0x5B2920", VA = "0x1805B3920")]
	public void LoadEditorFloorToWorld()
	{
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D17")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void OnPause()
	{
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D18")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void OnPlay()
	{
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D19")]
	[Address(RVA = "0x5B3F90", Offset = "0x5B2F90", VA = "0x1805B3F90")]
	public void OnNewFloorDesignationSetting()
	{
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D1A")]
	[Address(RVA = "0x5B3FC0", Offset = "0x5B2FC0", VA = "0x1805B3FC0")]
	public void OnNewAddressDesignationSelection()
	{
	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D1B")]
	[Address(RVA = "0x5B4400", Offset = "0x5B3400", VA = "0x1805B4400")]
	public void OnNewAddressDesignationSelection2()
	{
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D1C")]
	[Address(RVA = "0x5B4840", Offset = "0x5B3840", VA = "0x1805B4840")]
	public void OnNewAddressTypeSelection()
	{
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D1D")]
	[Address(RVA = "0x5B4A60", Offset = "0x5B3A60", VA = "0x1805B4A60")]
	public void AddNewAddressButton()
	{
	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D1E")]
	[Address(RVA = "0x5B4AE0", Offset = "0x5B3AE0", VA = "0x1805B4AE0")]
	public void RemoveAddress()
	{
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0x5B4E10", Offset = "0x5B3E10", VA = "0x1805B4E10")]
	public void OnNewWallDesignationSetting()
	{
	}

	// Token: 0x06000D20 RID: 3360 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D20")]
	[Address(RVA = "0x5B4EE0", Offset = "0x5B3EE0", VA = "0x1805B4EE0")]
	public void OnNewForceRoomSetting()
	{
	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D21")]
	[Address(RVA = "0x5B5210", Offset = "0x5B4210", VA = "0x1805B5210")]
	public void GenerateAddressLayoutButton()
	{
	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D22")]
	[Address(RVA = "0x5B53D0", Offset = "0x5B43D0", VA = "0x1805B53D0")]
	public void GenerateAddressDecorButton()
	{
	}

	// Token: 0x06000D23 RID: 3363 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D23")]
	[Address(RVA = "0x5B5600", Offset = "0x5B4600", VA = "0x1805B5600")]
	public void GenerateAddressLayoutAll()
	{
	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D24")]
	[Address(RVA = "0x5B58B0", Offset = "0x5B48B0", VA = "0x1805B58B0")]
	public void GenerateAddressDecorAll()
	{
	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D25")]
	[Address(RVA = "0x5B5E50", Offset = "0x5B4E50", VA = "0x1805B5E50")]
	public void RemoveAllForcedRooms()
	{
	}

	// Token: 0x06000D26 RID: 3366 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D26")]
	[Address(RVA = "0x5B6250", Offset = "0x5B5250", VA = "0x1805B6250")]
	public void ResetAllEntrances()
	{
	}

	// Token: 0x06000D27 RID: 3367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D27")]
	[Address(RVA = "0x5B63F0", Offset = "0x5B53F0", VA = "0x1805B63F0")]
	public void UpdateAddressDropdowns()
	{
	}

	// Token: 0x06000D28 RID: 3368 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D28")]
	[Address(RVA = "0x5B6940", Offset = "0x5B5940", VA = "0x1805B6940")]
	public void UpdateRoomConfigsDropdown()
	{
	}

	// Token: 0x06000D29 RID: 3369 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D29")]
	[Address(RVA = "0x5B6D20", Offset = "0x5B5D20", VA = "0x1805B6D20")]
	public void OnNewRoomVariationSelection()
	{
	}

	// Token: 0x06000D2A RID: 3370 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D2A")]
	[Address(RVA = "0x5B7100", Offset = "0x5B6100", VA = "0x1805B7100")]
	public void UpdateRoomDesignationIDsDropdown()
	{
	}

	// Token: 0x06000D2B RID: 3371 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D2B")]
	[Address(RVA = "0x5B77F0", Offset = "0x5B67F0", VA = "0x1805B77F0")]
	public void OnNewRoomSelection()
	{
	}

	// Token: 0x06000D2C RID: 3372 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D2C")]
	[Address(RVA = "0x5B7E80", Offset = "0x5B6E80", VA = "0x1805B7E80")]
	public void UpdateRoomLayoutAssignDropdown()
	{
	}

	// Token: 0x06000D2D RID: 3373 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D2D")]
	[Address(RVA = "0x5B8780", Offset = "0x5B7780", VA = "0x1805B8780")]
	public void OnAssignNewRoom()
	{
	}

	// Token: 0x06000D2E RID: 3374 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D2E")]
	[Address(RVA = "0x5B8BB0", Offset = "0x5B7BB0", VA = "0x1805B8BB0")]
	public void SaveCurrentVariation()
	{
	}

	// Token: 0x06000D2F RID: 3375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D2F")]
	[Address(RVA = "0x5B8CE0", Offset = "0x5B7CE0", VA = "0x1805B8CE0")]
	public void SaveLoadedAddressVariation(NewAddress add)
	{
	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D30")]
	[Address(RVA = "0x5B97B0", Offset = "0x5B87B0", VA = "0x1805B97B0")]
	public void AddVariationConfiguration()
	{
	}

	// Token: 0x06000D31 RID: 3377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D31")]
	[Address(RVA = "0x5BA160", Offset = "0x5B9160", VA = "0x1805BA160")]
	public void RemoveVariationConfiguration()
	{
	}

	// Token: 0x06000D32 RID: 3378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D32")]
	[Address(RVA = "0x5BA3C0", Offset = "0x5B93C0", VA = "0x1805BA3C0")]
	public void AddRoom()
	{
	}

	// Token: 0x06000D33 RID: 3379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D33")]
	[Address(RVA = "0x5BA630", Offset = "0x5B9630", VA = "0x1805BA630")]
	public void RemoveRoom()
	{
	}

	// Token: 0x06000D34 RID: 3380 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D34")]
	[Address(RVA = "0x5BACE0", Offset = "0x5B9CE0", VA = "0x1805BACE0")]
	public AddressLayoutVariation GetLoadedVariation(NewAddress forAddress)
	{
		return null;
	}

	// Token: 0x06000D35 RID: 3381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D35")]
	[Address(RVA = "0x5BAE70", Offset = "0x5B9E70", VA = "0x1805BAE70")]
	public FloorEditController()
	{
	}

	// Token: 0x06000D36 RID: 3382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D36")]
	[Address(RVA = "0x5B3F90", Offset = "0x5B2F90", VA = "0x1805B3F90")]
	private void <StartGame>b__89_0(int <p0>)
	{
	}

	// Token: 0x06000D37 RID: 3383 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D37")]
	[Address(RVA = "0x5BB210", Offset = "0x5BA210", VA = "0x1805BB210")]
	private void <StartGame>b__89_1(int <p0>)
	{
	}

	// Token: 0x06000D38 RID: 3384 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D38")]
	[Address(RVA = "0x5BB220", Offset = "0x5BA220", VA = "0x1805BB220")]
	private void <StartGame>b__89_2(int <p0>)
	{
	}

	// Token: 0x06000D39 RID: 3385 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D39")]
	[Address(RVA = "0x5BB230", Offset = "0x5BA230", VA = "0x1805BB230")]
	private void <StartGame>b__89_3(int <p0>)
	{
	}

	// Token: 0x06000D3A RID: 3386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D3A")]
	[Address(RVA = "0x5B4E10", Offset = "0x5B3E10", VA = "0x1805B4E10")]
	private void <StartGame>b__89_4(int <p0>)
	{
	}

	// Token: 0x06000D3B RID: 3387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D3B")]
	[Address(RVA = "0x5BB240", Offset = "0x5BA240", VA = "0x1805BB240")]
	private void <StartGame>b__89_5(int <p0>)
	{
	}

	// Token: 0x06000D3C RID: 3388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D3C")]
	[Address(RVA = "0x5BB250", Offset = "0x5BA250", VA = "0x1805BB250")]
	private void <StartGame>b__89_6(int <p0>)
	{
	}

	// Token: 0x06000D3D RID: 3389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D3D")]
	[Address(RVA = "0x5BB260", Offset = "0x5BA260", VA = "0x1805BB260")]
	private void <StartGame>b__89_7(int <p0>)
	{
	}

	// Token: 0x06000D3E RID: 3390 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D3E")]
	[Address(RVA = "0x5BB270", Offset = "0x5BA270", VA = "0x1805BB270")]
	private void <StartGame>b__89_8(int <p0>)
	{
	}

	// Token: 0x06000D3F RID: 3391 RVA: 0x000072D8 File Offset: 0x000054D8
	[Token(Token = "0x6000D3F")]
	[Address(RVA = "0x5BB280", Offset = "0x5BA280", VA = "0x1805BB280")]
	private bool <OnNewAddressDesignationSelection>b__118_0(LayoutConfiguration item)
	{
		return default(bool);
	}

	// Token: 0x06000D40 RID: 3392 RVA: 0x000072F0 File Offset: 0x000054F0
	[Token(Token = "0x6000D40")]
	[Address(RVA = "0x5BB280", Offset = "0x5BA280", VA = "0x1805BB280")]
	private bool <OnNewAddressDesignationSelection2>b__119_0(LayoutConfiguration item)
	{
		return default(bool);
	}

	// Token: 0x06000D41 RID: 3393 RVA: 0x00007308 File Offset: 0x00005508
	[Token(Token = "0x6000D41")]
	[Address(RVA = "0x5BB2C0", Offset = "0x5BA2C0", VA = "0x1805BB2C0")]
	private bool <OnAssignNewRoom>b__137_0(RoomTypePreset item)
	{
		return default(bool);
	}

	// Token: 0x04000E4C RID: 3660
	[Token(Token = "0x4000E4C")]
	[FieldOffset(Offset = "0x18")]
	public CityTile cityTile;

	// Token: 0x04000E4D RID: 3661
	[Token(Token = "0x4000E4D")]
	[FieldOffset(Offset = "0x20")]
	public NewBuilding building;

	// Token: 0x04000E4E RID: 3662
	[Token(Token = "0x4000E4E")]
	[FieldOffset(Offset = "0x28")]
	public Transform editorFloorParent;

	// Token: 0x04000E4F RID: 3663
	[Token(Token = "0x4000E4F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject enabledInScrollView;

	// Token: 0x04000E50 RID: 3664
	[Token(Token = "0x4000E50")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform toolOptionsWindow;

	// Token: 0x04000E51 RID: 3665
	[Token(Token = "0x4000E51")]
	[FieldOffset(Offset = "0x40")]
	public FloorEditController.EditorDisplayMode displayMode;

	// Token: 0x04000E52 RID: 3666
	[Token(Token = "0x4000E52")]
	[FieldOffset(Offset = "0x44")]
	public FloorEditController.EditorSelectionMode selectionModeType;

	// Token: 0x04000E53 RID: 3667
	[Token(Token = "0x4000E53")]
	[FieldOffset(Offset = "0x48")]
	public InteractablePreset lightswitchPreset;

	// Token: 0x04000E54 RID: 3668
	[Token(Token = "0x4000E54")]
	[FieldOffset(Offset = "0x50")]
	public Transform fakeCitizenHolder;

	// Token: 0x04000E55 RID: 3669
	[Token(Token = "0x4000E55")]
	[FieldOffset(Offset = "0x58")]
	public bool heldDown;

	// Token: 0x04000E56 RID: 3670
	[Token(Token = "0x4000E56")]
	[FieldOffset(Offset = "0x60")]
	public NewNode heldDownOriginNode;

	// Token: 0x04000E57 RID: 3671
	[Token(Token = "0x4000E57")]
	[FieldOffset(Offset = "0x68")]
	public Transform heldDownTransform;

	// Token: 0x04000E58 RID: 3672
	[Token(Token = "0x4000E58")]
	[FieldOffset(Offset = "0x70")]
	private int recalculationDelay;

	// Token: 0x04000E59 RID: 3673
	[Token(Token = "0x4000E59")]
	[FieldOffset(Offset = "0x78")]
	private string currentRecalculation;

	// Token: 0x04000E5A RID: 3674
	[Token(Token = "0x4000E5A")]
	[FieldOffset(Offset = "0x80")]
	public bool isSaving;

	// Token: 0x04000E5B RID: 3675
	[Token(Token = "0x4000E5B")]
	[FieldOffset(Offset = "0x81")]
	public bool loaded;

	// Token: 0x04000E5C RID: 3676
	[Token(Token = "0x4000E5C")]
	[FieldOffset(Offset = "0x82")]
	public bool rightMouse;

	// Token: 0x04000E5D RID: 3677
	[Token(Token = "0x4000E5D")]
	[FieldOffset(Offset = "0x84")]
	private int selectionLayerMask;

	// Token: 0x04000E5E RID: 3678
	[Token(Token = "0x4000E5E")]
	[FieldOffset(Offset = "0x88")]
	private int wallsSelectionMask;

	// Token: 0x04000E5F RID: 3679
	[Token(Token = "0x4000E5F")]
	[FieldOffset(Offset = "0x90")]
	public RectTransform newFloorWindow;

	// Token: 0x04000E60 RID: 3680
	[Token(Token = "0x4000E60")]
	[FieldOffset(Offset = "0x98")]
	public TMP_InputField newFloorName;

	// Token: 0x04000E61 RID: 3681
	[Token(Token = "0x4000E61")]
	[FieldOffset(Offset = "0xA0")]
	public TMP_InputField newFloorSizeX;

	// Token: 0x04000E62 RID: 3682
	[Token(Token = "0x4000E62")]
	[FieldOffset(Offset = "0xA8")]
	public TMP_InputField newFloorSizeY;

	// Token: 0x04000E63 RID: 3683
	[Token(Token = "0x4000E63")]
	[FieldOffset(Offset = "0xB0")]
	public TMP_InputField newFloorFloorHeight;

	// Token: 0x04000E64 RID: 3684
	[Token(Token = "0x4000E64")]
	[FieldOffset(Offset = "0xB8")]
	public TMP_InputField newFloorCeilingHeight;

	// Token: 0x04000E65 RID: 3685
	[Token(Token = "0x4000E65")]
	[FieldOffset(Offset = "0xC0")]
	public RectTransform saveAsFloorWindow;

	// Token: 0x04000E66 RID: 3686
	[Token(Token = "0x4000E66")]
	[FieldOffset(Offset = "0xC8")]
	public InputField newSaveAsFloorName;

	// Token: 0x04000E67 RID: 3687
	[Token(Token = "0x4000E67")]
	[FieldOffset(Offset = "0xD0")]
	public RectTransform loadFloorWindow;

	// Token: 0x04000E68 RID: 3688
	[Token(Token = "0x4000E68")]
	[FieldOffset(Offset = "0xD8")]
	public TMP_Dropdown loadDropdown;

	// Token: 0x04000E69 RID: 3689
	[Token(Token = "0x4000E69")]
	[FieldOffset(Offset = "0xE0")]
	private List<string> loadFilePaths;

	// Token: 0x04000E6A RID: 3690
	[Token(Token = "0x4000E6A")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject mapParent;

	// Token: 0x04000E6B RID: 3691
	[Token(Token = "0x4000E6B")]
	[FieldOffset(Offset = "0xF0")]
	public NewFloor editFloor;

	// Token: 0x04000E6C RID: 3692
	[Token(Token = "0x4000E6C")]
	[FieldOffset(Offset = "0xF8")]
	public bool selectionMode;

	// Token: 0x04000E6D RID: 3693
	[Token(Token = "0x4000E6D")]
	[FieldOffset(Offset = "0x100")]
	public Transform selectionObject;

	// Token: 0x04000E6E RID: 3694
	[Token(Token = "0x4000E6E")]
	[FieldOffset(Offset = "0x108")]
	public Transform floorSelectCursorObject;

	// Token: 0x04000E6F RID: 3695
	[Token(Token = "0x4000E6F")]
	[FieldOffset(Offset = "0x110")]
	public Transform wallSelectCursorObject;

	// Token: 0x04000E70 RID: 3696
	[Token(Token = "0x4000E70")]
	[FieldOffset(Offset = "0x118")]
	public TextMeshProUGUI statusText;

	// Token: 0x04000E71 RID: 3697
	[Token(Token = "0x4000E71")]
	[FieldOffset(Offset = "0x120")]
	public NewTile tileSelection;

	// Token: 0x04000E72 RID: 3698
	[Token(Token = "0x4000E72")]
	[FieldOffset(Offset = "0x128")]
	public NewNode nodeSelection;

	// Token: 0x04000E73 RID: 3699
	[Token(Token = "0x4000E73")]
	[FieldOffset(Offset = "0x130")]
	public NewWall wallSelection;

	// Token: 0x04000E74 RID: 3700
	[Token(Token = "0x4000E74")]
	[FieldOffset(Offset = "0x138")]
	public Vector2 selectionCoord;

	// Token: 0x04000E75 RID: 3701
	[Token(Token = "0x4000E75")]
	[FieldOffset(Offset = "0x140")]
	public FloorEditController.FloorEditTool tool;

	// Token: 0x04000E76 RID: 3702
	[Token(Token = "0x4000E76")]
	[FieldOffset(Offset = "0x148")]
	public List<GameObject> wallTriggers;

	// Token: 0x04000E77 RID: 3703
	[Token(Token = "0x4000E77")]
	[FieldOffset(Offset = "0x150")]
	public RectTransform floorDesignationOptions;

	// Token: 0x04000E78 RID: 3704
	[Token(Token = "0x4000E78")]
	[FieldOffset(Offset = "0x158")]
	public TMP_Dropdown floorDesignationDropdown;

	// Token: 0x04000E79 RID: 3705
	[Token(Token = "0x4000E79")]
	[FieldOffset(Offset = "0x160")]
	public NewNode.FloorTileType floorDesignationTypeSelection;

	// Token: 0x04000E7A RID: 3706
	[Token(Token = "0x4000E7A")]
	[FieldOffset(Offset = "0x168")]
	public List<Color> editorAddressColours;

	// Token: 0x04000E7B RID: 3707
	[Token(Token = "0x4000E7B")]
	[FieldOffset(Offset = "0x170")]
	public Material adddressDesignationMaterial;

	// Token: 0x04000E7C RID: 3708
	[Token(Token = "0x4000E7C")]
	[FieldOffset(Offset = "0x178")]
	public RectTransform addressDesignationOptions;

	// Token: 0x04000E7D RID: 3709
	[Token(Token = "0x4000E7D")]
	[FieldOffset(Offset = "0x180")]
	public TMP_Dropdown addressDropdown;

	// Token: 0x04000E7E RID: 3710
	[Token(Token = "0x4000E7E")]
	[FieldOffset(Offset = "0x188")]
	public TMP_Dropdown addressTypeDropdown;

	// Token: 0x04000E7F RID: 3711
	[Token(Token = "0x4000E7F")]
	[FieldOffset(Offset = "0x190")]
	public NewAddress addressSelection;

	// Token: 0x04000E80 RID: 3712
	[Token(Token = "0x4000E80")]
	[FieldOffset(Offset = "0x198")]
	public LayoutConfiguration addressTypeSelection;

	// Token: 0x04000E81 RID: 3713
	[Token(Token = "0x4000E81")]
	[FieldOffset(Offset = "0x1A0")]
	public Image addressDesignationColourImage;

	// Token: 0x04000E82 RID: 3714
	[Token(Token = "0x4000E82")]
	[FieldOffset(Offset = "0x1A8")]
	public Image addressDesignationColourImage2;

	// Token: 0x04000E83 RID: 3715
	[Token(Token = "0x4000E83")]
	[FieldOffset(Offset = "0x1B0")]
	public RectTransform roomDesignationOptions;

	// Token: 0x04000E84 RID: 3716
	[Token(Token = "0x4000E84")]
	[FieldOffset(Offset = "0x1B8")]
	public TMP_Dropdown roomConfigAddressDropdown;

	// Token: 0x04000E85 RID: 3717
	[Token(Token = "0x4000E85")]
	[FieldOffset(Offset = "0x1C0")]
	public TMP_Dropdown roomConfigsDropdown;

	// Token: 0x04000E86 RID: 3718
	[Token(Token = "0x4000E86")]
	[FieldOffset(Offset = "0x1C8")]
	public TMP_Dropdown roomIDsDropdown;

	// Token: 0x04000E87 RID: 3719
	[Token(Token = "0x4000E87")]
	[FieldOffset(Offset = "0x1D0")]
	public TMP_Dropdown roomLayoutAssignDropdown;

	// Token: 0x04000E88 RID: 3720
	[Token(Token = "0x4000E88")]
	[FieldOffset(Offset = "0x1D8")]
	public NewRoom roomSelection;

	// Token: 0x04000E89 RID: 3721
	[Token(Token = "0x4000E89")]
	[FieldOffset(Offset = "0x1E0")]
	public RectTransform wallPairsOptions;

	// Token: 0x04000E8A RID: 3722
	[Token(Token = "0x4000E8A")]
	[FieldOffset(Offset = "0x1E8")]
	public TMP_Dropdown wallPairsDropdown;

	// Token: 0x04000E8B RID: 3723
	[Token(Token = "0x4000E8B")]
	[FieldOffset(Offset = "0x1F0")]
	public DoorPairPreset wallPairPresetSelection;

	// Token: 0x04000E8C RID: 3724
	[Token(Token = "0x4000E8C")]
	[FieldOffset(Offset = "0x1F8")]
	public RectTransform forceRoomOptions;

	// Token: 0x04000E8D RID: 3725
	[Token(Token = "0x4000E8D")]
	[FieldOffset(Offset = "0x200")]
	public TMP_Dropdown forceRoomDropdown;

	// Token: 0x04000E8E RID: 3726
	[Token(Token = "0x4000E8E")]
	[FieldOffset(Offset = "0x208")]
	[NonSerialized]
	public RoomConfiguration forceRoomSelection;

	// Token: 0x04000E8F RID: 3727
	[Token(Token = "0x4000E8F")]
	[FieldOffset(Offset = "0x210")]
	public Toggle forceBasementToggle;

	// Token: 0x04000E90 RID: 3728
	[Token(Token = "0x4000E90")]
	[FieldOffset(Offset = "0x218")]
	public Material editorFloorMaterial;

	// Token: 0x04000E91 RID: 3729
	[Token(Token = "0x4000E91")]
	[FieldOffset(Offset = "0x220")]
	public Material editorFloorEdgeMaterial;

	// Token: 0x04000E92 RID: 3730
	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0x228")]
	public MaterialGroupPreset defaultFloorMaterial;

	// Token: 0x04000E93 RID: 3731
	[Token(Token = "0x4000E93")]
	[FieldOffset(Offset = "0x230")]
	public Toolbox.MaterialKey defaultMaterialKey;

	// Token: 0x04000E94 RID: 3732
	[Token(Token = "0x4000E94")]
	[FieldOffset(Offset = "0x238")]
	public RoomTypePreset nullRoomType;

	// Token: 0x04000E95 RID: 3733
	[Token(Token = "0x4000E95")]
	[FieldOffset(Offset = "0x240")]
	private List<RoomTypePreset> allLayoutTypes;

	// Token: 0x04000E96 RID: 3734
	[Token(Token = "0x4000E96")]
	[FieldOffset(Offset = "0x248")]
	private List<LayoutConfiguration> allLayouts;

	// Token: 0x04000E97 RID: 3735
	[Token(Token = "0x4000E97")]
	[FieldOffset(Offset = "0x250")]
	private List<RoomConfiguration> allRoomConfigs;

	// Token: 0x04000E98 RID: 3736
	[Token(Token = "0x4000E98")]
	[FieldOffset(Offset = "0x258")]
	private List<DoorPairPreset> allDoorPairs;

	// Token: 0x04000E99 RID: 3737
	[Token(Token = "0x4000E99")]
	[FieldOffset(Offset = "0x260")]
	private List<DoorPairPreset> selectableDoorPairs;

	// Token: 0x04000E9A RID: 3738
	[Token(Token = "0x4000E9A")]
	[FieldOffset(Offset = "0x268")]
	private List<RoomConfiguration> selectableRooms;

	// Token: 0x04000E9B RID: 3739
	[Token(Token = "0x4000E9B")]
	[FieldOffset(Offset = "0x270")]
	public Transform debugContainer;

	// Token: 0x04000E9C RID: 3740
	[Token(Token = "0x4000E9C")]
	[FieldOffset(Offset = "0x278")]
	public GenerationDebugController currentlyDisplayingArea;

	// Token: 0x04000E9D RID: 3741
	[Token(Token = "0x4000E9D")]
	[FieldOffset(Offset = "0x0")]
	private static FloorEditController _instance;

	// Token: 0x02000240 RID: 576
	[Token(Token = "0x2000240")]
	public enum EditorDisplayMode
	{
		// Token: 0x04000E9F RID: 3743
		[Token(Token = "0x4000E9F")]
		normal,
		// Token: 0x04000EA0 RID: 3744
		[Token(Token = "0x4000EA0")]
		displayAddressDesignation,
		// Token: 0x04000EA1 RID: 3745
		[Token(Token = "0x4000EA1")]
		displayRoomSelection
	}

	// Token: 0x02000241 RID: 577
	[Token(Token = "0x2000241")]
	public enum EditorSelectionMode
	{
		// Token: 0x04000EA3 RID: 3747
		[Token(Token = "0x4000EA3")]
		tile,
		// Token: 0x04000EA4 RID: 3748
		[Token(Token = "0x4000EA4")]
		wall,
		// Token: 0x04000EA5 RID: 3749
		[Token(Token = "0x4000EA5")]
		node
	}

	// Token: 0x02000242 RID: 578
	[Token(Token = "0x2000242")]
	public enum FloorEditTool
	{
		// Token: 0x04000EA7 RID: 3751
		[Token(Token = "0x4000EA7")]
		none,
		// Token: 0x04000EA8 RID: 3752
		[Token(Token = "0x4000EA8")]
		floorDesignation,
		// Token: 0x04000EA9 RID: 3753
		[Token(Token = "0x4000EA9")]
		addressDesignation,
		// Token: 0x04000EAA RID: 3754
		[Token(Token = "0x4000EAA")]
		wallDesignation,
		// Token: 0x04000EAB RID: 3755
		[Token(Token = "0x4000EAB")]
		rotateFloor,
		// Token: 0x04000EAC RID: 3756
		[Token(Token = "0x4000EAC")]
		mainEntrance,
		// Token: 0x04000EAD RID: 3757
		[Token(Token = "0x4000EAD")]
		secondaryEntrance,
		// Token: 0x04000EAE RID: 3758
		[Token(Token = "0x4000EAE")]
		stairwell,
		// Token: 0x04000EAF RID: 3759
		[Token(Token = "0x4000EAF")]
		elevator,
		// Token: 0x04000EB0 RID: 3760
		[Token(Token = "0x4000EB0")]
		forceRoom,
		// Token: 0x04000EB1 RID: 3761
		[Token(Token = "0x4000EB1")]
		roomDesignation
	}

	// Token: 0x02000243 RID: 579
	[Token(Token = "0x2000243")]
	private sealed class <>c__DisplayClass124_0
	{
		// Token: 0x06000D42 RID: 3394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D42")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass124_0()
		{
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00007320 File Offset: 0x00005520
		[Token(Token = "0x6000D43")]
		[Address(RVA = "0x5E6860", Offset = "0x5E5860", VA = "0x1805E6860")]
		internal bool <OnNewForceRoomSetting>b__0(RoomConfiguration item)
		{
			return default(bool);
		}

		// Token: 0x04000EB2 RID: 3762
		[Token(Token = "0x4000EB2")]
		[FieldOffset(Offset = "0x10")]
		public string lastElement;
	}

	// Token: 0x02000244 RID: 580
	[Token(Token = "0x2000244")]
	private sealed class <>c__DisplayClass135_0
	{
		// Token: 0x06000D44 RID: 3396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D44")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass135_0()
		{
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00007338 File Offset: 0x00005538
		[Token(Token = "0x6000D45")]
		[Address(RVA = "0x5E68D0", Offset = "0x5E58D0", VA = "0x1805E68D0")]
		internal bool <OnNewRoomSelection>b__0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x04000EB3 RID: 3763
		[Token(Token = "0x4000EB3")]
		[FieldOffset(Offset = "0x10")]
		public int getID;
	}
}
