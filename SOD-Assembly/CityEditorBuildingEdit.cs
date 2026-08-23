using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001FA RID: 506
[Token(Token = "0x20001FA")]
public class CityEditorBuildingEdit : MonoBehaviour
{
	// Token: 0x14000012 RID: 18
	// (add) Token: 0x06000C07 RID: 3079 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000C08 RID: 3080 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000012")]
	public event CityEditorBuildingEdit.NewTileSelection OnNewTileSelection
	{
		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x587C50", Offset = "0x586C50", VA = "0x180587C50")]
		add
		{
		}
		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x587D40", Offset = "0x586D40", VA = "0x180587D40")]
		remove
		{
		}
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C09")]
	[Address(RVA = "0x587E30", Offset = "0x586E30", VA = "0x180587E30")]
	private void Awake()
	{
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C0A")]
	[Address(RVA = "0x588330", Offset = "0x587330", VA = "0x180588330")]
	private void Update()
	{
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C0B")]
	[Address(RVA = "0x589130", Offset = "0x588130", VA = "0x180589130")]
	private void SelectBuilding(CityTile newTile)
	{
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C0C")]
	[Address(RVA = "0x5897C0", Offset = "0x5887C0", VA = "0x1805897C0")]
	public void OnRandomBuildingNameButton()
	{
	}

	// Token: 0x06000C0D RID: 3085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C0D")]
	[Address(RVA = "0x589A60", Offset = "0x588A60", VA = "0x180589A60")]
	public void OnChangeBuildingType()
	{
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C0E")]
	[Address(RVA = "0x58A000", Offset = "0x589000", VA = "0x18058A000")]
	public void OnChangeBuildingNameButton()
	{
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C0F")]
	[Address(RVA = "0x58A4C0", Offset = "0x5894C0", VA = "0x18058A4C0")]
	private void OnChangeBuildingNamePopupCancel()
	{
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C10")]
	[Address(RVA = "0x58A620", Offset = "0x589620", VA = "0x18058A620")]
	private void OnChangeBuildingNamePopupConfirm()
	{
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C11")]
	[Address(RVA = "0x58AA00", Offset = "0x589A00", VA = "0x18058AA00")]
	public void RenameSelectedBuilding(string newBuildingName)
	{
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x58AB80", Offset = "0x589B80", VA = "0x18058AB80")]
	public void OnRotateButton()
	{
	}

	// Token: 0x06000C13 RID: 3091 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C13")]
	[Address(RVA = "0x58B080", Offset = "0x58A080", VA = "0x18058B080")]
	private void ProcessSwapBuildingInput()
	{
	}

	// Token: 0x06000C14 RID: 3092 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x58B230", Offset = "0x58A230", VA = "0x18058B230")]
	private CityTile TryGetTile()
	{
		return null;
	}

	// Token: 0x06000C15 RID: 3093 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C15")]
	[Address(RVA = "0x58B750", Offset = "0x58A750", VA = "0x18058B750")]
	private void SwapTiles(CityTile originTile, CityTile targetTile)
	{
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C16")]
	[Address(RVA = "0x58BC80", Offset = "0x58AC80", VA = "0x18058BC80")]
	private void ResetSelection()
	{
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C17")]
	[Address(RVA = "0x58BC90", Offset = "0x58AC90", VA = "0x18058BC90")]
	private void OnDisable()
	{
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C18")]
	[Address(RVA = "0x58C130", Offset = "0x58B130", VA = "0x18058C130")]
	public CityEditorBuildingEdit()
	{
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x00007098 File Offset: 0x00005298
	[Token(Token = "0x6000C19")]
	[Address(RVA = "0x58C2E0", Offset = "0x58B2E0", VA = "0x18058C2E0")]
	private bool <OnChangeBuildingType>b__19_0(BuildingPreset item)
	{
		return default(bool);
	}

	// Token: 0x04000C79 RID: 3193
	[Token(Token = "0x4000C79")]
	[FieldOffset(Offset = "0x18")]
	public GameObject tileSelect1;

	// Token: 0x04000C7A RID: 3194
	[Token(Token = "0x4000C7A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject tileSelect2;

	// Token: 0x04000C7B RID: 3195
	[Token(Token = "0x4000C7B")]
	[FieldOffset(Offset = "0x28")]
	public DropdownController buildingTypeDropdown;

	// Token: 0x04000C7C RID: 3196
	[Token(Token = "0x4000C7C")]
	[FieldOffset(Offset = "0x30")]
	public ButtonController buildingNameButton;

	// Token: 0x04000C7D RID: 3197
	[Token(Token = "0x4000C7D")]
	[FieldOffset(Offset = "0x38")]
	public ButtonController randomNameButton;

	// Token: 0x04000C7E RID: 3198
	[Token(Token = "0x4000C7E")]
	[FieldOffset(Offset = "0x40")]
	public ButtonController rotateButton;

	// Token: 0x04000C7F RID: 3199
	[Token(Token = "0x4000C7F")]
	[FieldOffset(Offset = "0x48")]
	public CityTile currentlyMousedOverTile;

	// Token: 0x04000C80 RID: 3200
	[Token(Token = "0x4000C80")]
	[FieldOffset(Offset = "0x50")]
	public CityTile currentlySelectedTile;

	// Token: 0x04000C81 RID: 3201
	[Token(Token = "0x4000C81")]
	[FieldOffset(Offset = "0x58")]
	private List<BuildingPreset> buildingPresets;

	// Token: 0x04000C82 RID: 3202
	[Token(Token = "0x4000C82")]
	[FieldOffset(Offset = "0x60")]
	private List<NewBuilding> animatingBuildingRotation;

	// Token: 0x04000C83 RID: 3203
	[Token(Token = "0x4000C83")]
	[FieldOffset(Offset = "0x68")]
	private TMP_Text _buildingNameText;

	// Token: 0x020001FB RID: 507
	// (Invoke) Token: 0x06000C1B RID: 3099
	[Token(Token = "0x20001FB")]
	public delegate void NewTileSelection(CityTile newSelected);
}
