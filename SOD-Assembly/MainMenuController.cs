using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AeLa.EasyFeedback;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005A8 RID: 1448
[Token(Token = "0x20005A8")]
public class MainMenuController : MonoBehaviour
{
	// Token: 0x1700010B RID: 267
	// (get) Token: 0x06001F91 RID: 8081 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700010B")]
	public static MainMenuController Instance
	{
		[Token(Token = "0x6001F91")]
		[Address(RVA = "0xA7D3B0", Offset = "0xA7C3B0", VA = "0x180A7D3B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001F92 RID: 8082 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F92")]
	[Address(RVA = "0xA7D3F0", Offset = "0xA7C3F0", VA = "0x180A7D3F0")]
	private void Awake()
	{
	}

	// Token: 0x06001F93 RID: 8083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F93")]
	[Address(RVA = "0xA7D740", Offset = "0xA7C740", VA = "0x180A7D740")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001F94 RID: 8084 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F94")]
	[Address(RVA = "0xA7D950", Offset = "0xA7C950", VA = "0x180A7D950")]
	private void Start()
	{
	}

	// Token: 0x06001F95 RID: 8085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F95")]
	[Address(RVA = "0xA7F510", Offset = "0xA7E510", VA = "0x180A7F510")]
	public void LoadDropdownContent()
	{
	}

	// Token: 0x06001F96 RID: 8086 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F96")]
	[Address(RVA = "0xA81C50", Offset = "0xA80C50", VA = "0x180A81C50")]
	public void OnNewMouseOver()
	{
	}

	// Token: 0x06001F97 RID: 8087 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F97")]
	[Address(RVA = "0xA81F70", Offset = "0xA80F70", VA = "0x180A81F70")]
	public void EnableMainMenu(bool val, bool useFade = false, bool exitMain = false, MainMenuController.Component menuPhase = MainMenuController.Component.mainMenuButtons)
	{
	}

	// Token: 0x06001F98 RID: 8088 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F98")]
	[Address(RVA = "0xA828C0", Offset = "0xA818C0", VA = "0x180A828C0")]
	public void SelectHighestRankedActiveButton(bool prioritisePreviouslySelected = true)
	{
	}

	// Token: 0x06001F99 RID: 8089 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F99")]
	[Address(RVA = "0xA83200", Offset = "0xA82200", VA = "0x180A83200")]
	private void Update()
	{
	}

	// Token: 0x06001F9A RID: 8090 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F9A")]
	[Address(RVA = "0xA839F0", Offset = "0xA829F0", VA = "0x180A839F0")]
	private IEnumerator FadeMenu()
	{
		return null;
	}

	// Token: 0x06001F9B RID: 8091 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F9B")]
	[Address(RVA = "0xA83A90", Offset = "0xA82A90", VA = "0x180A83A90")]
	public void SetMenuComponent(int newComponent)
	{
	}

	// Token: 0x06001F9C RID: 8092 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F9C")]
	[Address(RVA = "0xA83AA0", Offset = "0xA82AA0", VA = "0x180A83AA0")]
	public void SetMenuComponent(MainMenuController.Component newComponent)
	{
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F9D")]
	[Address(RVA = "0xA84460", Offset = "0xA83460", VA = "0x180A84460")]
	public void SetToStreamerMode()
	{
	}

	// Token: 0x06001F9E RID: 8094 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F9E")]
	[Address(RVA = "0xA84840", Offset = "0xA83840", VA = "0x180A84840")]
	public void CancelStreamerMode()
	{
	}

	// Token: 0x06001F9F RID: 8095 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F9F")]
	[Address(RVA = "0xA849A0", Offset = "0xA839A0", VA = "0x180A849A0")]
	public void AcceptEULA()
	{
	}

	// Token: 0x06001FA0 RID: 8096 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FA0")]
	[Address(RVA = "0xA84B30", Offset = "0xA83B30", VA = "0x180A84B30")]
	public void DeclineEULA()
	{
	}

	// Token: 0x06001FA1 RID: 8097 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FA1")]
	[Address(RVA = "0xA84CD0", Offset = "0xA83CD0", VA = "0x180A84CD0")]
	private IEnumerator MenuMotion(bool skipMotion)
	{
		return null;
	}

	// Token: 0x06001FA2 RID: 8098 RVA: 0x0000DD58 File Offset: 0x0000BF58
	[Token(Token = "0x6001FA2")]
	[Address(RVA = "0xA84D90", Offset = "0xA83D90", VA = "0x180A84D90")]
	public bool IsSaveGameAllowed()
	{
		return default(bool);
	}

	// Token: 0x06001FA3 RID: 8099 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FA3")]
	[Address(RVA = "0xA84E90", Offset = "0xA83E90", VA = "0x180A84E90")]
	public void OnMenuComponentSwitchComplete()
	{
	}

	// Token: 0x06001FA4 RID: 8100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FA4")]
	[Address(RVA = "0xA854E0", Offset = "0xA844E0", VA = "0x180A854E0")]
	public void ResetBackButtonControllerIcons()
	{
	}

	// Token: 0x06001FA5 RID: 8101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FA5")]
	[Address(RVA = "0xA857A0", Offset = "0xA847A0", VA = "0x180A857A0")]
	public void SelectCityButton()
	{
	}

	// Token: 0x06001FA6 RID: 8102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FA6")]
	[Address(RVA = "0xA85BC0", Offset = "0xA84BC0", VA = "0x180A85BC0")]
	private void RefreshMapDropdown()
	{
	}

	// Token: 0x06001FA7 RID: 8103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FA7")]
	[Address(RVA = "0xA86EF0", Offset = "0xA85EF0", VA = "0x180A86EF0")]
	public void OnNewCitySelected()
	{
	}

	// Token: 0x06001FA8 RID: 8104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FA8")]
	[Address(RVA = "0xA86FE0", Offset = "0xA85FE0", VA = "0x180A86FE0")]
	public void LoadCityInfo(FileInfo fileInfo)
	{
	}

	// Token: 0x06001FA9 RID: 8105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FA9")]
	[Address(RVA = "0xA87CB0", Offset = "0xA86CB0", VA = "0x180A87CB0")]
	public void SelectGenNewCity()
	{
	}

	// Token: 0x06001FAA RID: 8106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FAA")]
	[Address(RVA = "0xA88000", Offset = "0xA87000", VA = "0x180A88000")]
	public void RandomCityName()
	{
	}

	// Token: 0x06001FAB RID: 8107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FAB")]
	[Address(RVA = "0xA88770", Offset = "0xA87770", VA = "0x180A88770")]
	public void PasteShareCode()
	{
	}

	// Token: 0x06001FAC RID: 8108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FAC")]
	[Address(RVA = "0xA88870", Offset = "0xA87870", VA = "0x180A88870")]
	private void ParseShareCode(string newCode)
	{
	}

	// Token: 0x06001FAD RID: 8109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FAD")]
	[Address(RVA = "0xA88D80", Offset = "0xA87D80", VA = "0x180A88D80")]
	public void CopyShareCodeGenerate()
	{
	}

	// Token: 0x06001FAE RID: 8110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FAE")]
	[Address(RVA = "0xA88E00", Offset = "0xA87E00", VA = "0x180A88E00")]
	public void CustomShareCodeButton()
	{
	}

	// Token: 0x06001FAF RID: 8111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FAF")]
	[Address(RVA = "0xA89110", Offset = "0xA88110", VA = "0x180A89110")]
	public void OnChangeShareCodePopupCancel()
	{
	}

	// Token: 0x06001FB0 RID: 8112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FB0")]
	[Address(RVA = "0xA89270", Offset = "0xA88270", VA = "0x180A89270")]
	public void OnChangeShareCodePopupConfirm()
	{
	}

	// Token: 0x06001FB1 RID: 8113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FB1")]
	[Address(RVA = "0xA89430", Offset = "0xA88430", VA = "0x180A89430")]
	public void OnGenerateNewSeed()
	{
	}

	// Token: 0x06001FB2 RID: 8114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FB2")]
	[Address(RVA = "0xA89550", Offset = "0xA88550", VA = "0x180A89550")]
	public void OnChangeCityNameButton()
	{
	}

	// Token: 0x06001FB3 RID: 8115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FB3")]
	[Address(RVA = "0xA89870", Offset = "0xA88870", VA = "0x180A89870")]
	public void OnChangeCityNamePopupCancel()
	{
	}

	// Token: 0x06001FB4 RID: 8116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FB4")]
	[Address(RVA = "0xA899D0", Offset = "0xA889D0", VA = "0x180A899D0")]
	public void OnChangeCityNamePopupConfirm()
	{
	}

	// Token: 0x06001FB5 RID: 8117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FB5")]
	[Address(RVA = "0xA89C50", Offset = "0xA88C50", VA = "0x180A89C50")]
	public void OnChangeCityGenerationOption()
	{
	}

	// Token: 0x06001FB6 RID: 8118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FB6")]
	[Address(RVA = "0xA8A590", Offset = "0xA89590", VA = "0x180A8A590")]
	public void NewCharacter()
	{
	}

	// Token: 0x06001FB7 RID: 8119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FB7")]
	[Address(RVA = "0xA8A780", Offset = "0xA89780", VA = "0x180A8A780")]
	public void SetPlayerName(string newName)
	{
	}

	// Token: 0x06001FB8 RID: 8120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FB8")]
	[Address(RVA = "0xA8AB70", Offset = "0xA89B70", VA = "0x180A8AB70")]
	public void RandomPlayerName(bool surnameOnly = false)
	{
	}

	// Token: 0x06001FB9 RID: 8121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FB9")]
	[Address(RVA = "0xA8B310", Offset = "0xA8A310", VA = "0x180A8B310")]
	public void OnChangeNameButton()
	{
	}

	// Token: 0x06001FBA RID: 8122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FBA")]
	[Address(RVA = "0xA8B6A0", Offset = "0xA8A6A0", VA = "0x180A8B6A0")]
	public void OnChangeNamePopupCancel()
	{
	}

	// Token: 0x06001FBB RID: 8123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FBB")]
	[Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
	public void OnChangeNamePopupConfirm()
	{
	}

	// Token: 0x06001FBC RID: 8124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FBC")]
	[Address(RVA = "0xA8BA00", Offset = "0xA8AA00", VA = "0x180A8BA00")]
	public void OnPlayerNameChanged()
	{
	}

	// Token: 0x06001FBD RID: 8125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FBD")]
	[Address(RVA = "0xA8BEE0", Offset = "0xA8AEE0", VA = "0x180A8BEE0")]
	public void OnPlayerGenderChange()
	{
	}

	// Token: 0x06001FBE RID: 8126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FBE")]
	[Address(RVA = "0xA8C010", Offset = "0xA8B010", VA = "0x180A8C010")]
	public void OnPartnerGenderChange()
	{
	}

	// Token: 0x06001FBF RID: 8127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FBF")]
	[Address(RVA = "0xA8C080", Offset = "0xA8B080", VA = "0x180A8C080")]
	public void RandomPlayerGender()
	{
	}

	// Token: 0x06001FC0 RID: 8128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FC0")]
	[Address(RVA = "0xA8C110", Offset = "0xA8B110", VA = "0x180A8C110")]
	public void RandomPartnerGender()
	{
	}

	// Token: 0x06001FC1 RID: 8129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FC1")]
	[Address(RVA = "0xA8C1A0", Offset = "0xA8B1A0", VA = "0x180A8C1A0")]
	public void RandomSkinTone()
	{
	}

	// Token: 0x06001FC2 RID: 8130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FC2")]
	[Address(RVA = "0xA8C220", Offset = "0xA8B220", VA = "0x180A8C220")]
	public void OnSkinToneChange()
	{
	}

	// Token: 0x06001FC3 RID: 8131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FC3")]
	[Address(RVA = "0xA8C2A0", Offset = "0xA8B2A0", VA = "0x180A8C2A0")]
	public void SaveGame()
	{
	}

	// Token: 0x06001FC4 RID: 8132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FC4")]
	[Address(RVA = "0xA8C320", Offset = "0xA8B320", VA = "0x180A8C320")]
	public void LoadGame()
	{
	}

	// Token: 0x06001FC5 RID: 8133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FC5")]
	[Address(RVA = "0xA8C4C0", Offset = "0xA8B4C0", VA = "0x180A8C4C0")]
	public void OnSaveButton()
	{
	}

	// Token: 0x06001FC6 RID: 8134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FC6")]
	[Address(RVA = "0xA8D5C0", Offset = "0xA8C5C0", VA = "0x180A8D5C0")]
	public void CancelOverwriteSave()
	{
	}

	// Token: 0x06001FC7 RID: 8135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FC7")]
	[Address(RVA = "0xA8D720", Offset = "0xA8C720", VA = "0x180A8D720")]
	public void OverwriteSave()
	{
	}

	// Token: 0x06001FC8 RID: 8136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FC8")]
	[Address(RVA = "0xA8D890", Offset = "0xA8C890", VA = "0x180A8D890")]
	public void StartSaveAsync()
	{
	}

	// Token: 0x06001FC9 RID: 8137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FC9")]
	[Address(RVA = "0xA8DA50", Offset = "0xA8CA50", VA = "0x180A8DA50")]
	private void SaveCompleteMessage()
	{
	}

	// Token: 0x06001FCA RID: 8138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FCA")]
	[Address(RVA = "0xA8DBE0", Offset = "0xA8CBE0", VA = "0x180A8DBE0")]
	public void OnDeleteSaveButton()
	{
	}

	// Token: 0x06001FCB RID: 8139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FCB")]
	[Address(RVA = "0xA8DF90", Offset = "0xA8CF90", VA = "0x180A8DF90")]
	public void CancelDeleteSave()
	{
	}

	// Token: 0x06001FCC RID: 8140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FCC")]
	[Address(RVA = "0xA8E0F0", Offset = "0xA8D0F0", VA = "0x180A8E0F0")]
	public void DeleteSave()
	{
	}

	// Token: 0x06001FCD RID: 8141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FCD")]
	[Address(RVA = "0xA8E2E0", Offset = "0xA8D2E0", VA = "0x180A8E2E0")]
	public void DeleteCurrentSaveGame()
	{
	}

	// Token: 0x06001FCE RID: 8142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FCE")]
	[Address(RVA = "0xA8E910", Offset = "0xA8D910", VA = "0x180A8E910")]
	public void RefreshSaveEntries()
	{
	}

	// Token: 0x06001FCF RID: 8143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FCF")]
	[Address(RVA = "0xA8FF70", Offset = "0xA8EF70", VA = "0x180A8FF70")]
	public void SelectNewSave(SaveGameEntryController sec)
	{
	}

	// Token: 0x06001FD0 RID: 8144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FD0")]
	[Address(RVA = "0xA90890", Offset = "0xA8F890", VA = "0x180A90890")]
	public void DeleteCityButton()
	{
	}

	// Token: 0x06001FD1 RID: 8145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FD1")]
	[Address(RVA = "0xA90B90", Offset = "0xA8FB90", VA = "0x180A90B90")]
	public void CancelDeleteCity()
	{
	}

	// Token: 0x06001FD2 RID: 8146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FD2")]
	[Address(RVA = "0xA90CF0", Offset = "0xA8FCF0", VA = "0x180A90CF0")]
	public void DeleteCity()
	{
	}

	// Token: 0x06001FD3 RID: 8147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FD3")]
	[Address(RVA = "0xA91300", Offset = "0xA90300", VA = "0x180A91300")]
	public void ExitGame()
	{
	}

	// Token: 0x06001FD4 RID: 8148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FD4")]
	[Address(RVA = "0xA916B0", Offset = "0xA906B0", VA = "0x180A916B0")]
	public void SaveOnExitYes()
	{
	}

	// Token: 0x06001FD5 RID: 8149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FD5")]
	[Address(RVA = "0xA91920", Offset = "0xA90920", VA = "0x180A91920")]
	public void SaveOnExitNo()
	{
	}

	// Token: 0x06001FD6 RID: 8150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FD6")]
	[Address(RVA = "0xA91B60", Offset = "0xA90B60", VA = "0x180A91B60")]
	public void SaveOnExitCancel()
	{
	}

	// Token: 0x06001FD7 RID: 8151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FD7")]
	[Address(RVA = "0xA91D60", Offset = "0xA90D60", VA = "0x180A91D60")]
	public void ResumeGame()
	{
	}

	// Token: 0x06001FD8 RID: 8152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FD8")]
	[Address(RVA = "0xA91DD0", Offset = "0xA90DD0", VA = "0x180A91DD0")]
	public void Help()
	{
	}

	// Token: 0x06001FD9 RID: 8153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FD9")]
	[Address(RVA = "0xA92000", Offset = "0xA91000", VA = "0x180A92000")]
	public void BugReport()
	{
	}

	// Token: 0x06001FDA RID: 8154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FDA")]
	[Address(RVA = "0xA92450", Offset = "0xA91450", VA = "0x180A92450")]
	public void FeedbackForm()
	{
	}

	// Token: 0x06001FDB RID: 8155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FDB")]
	[Address(RVA = "0xA924D0", Offset = "0xA914D0", VA = "0x180A924D0")]
	public void OnFeedbackFormClosed()
	{
	}

	// Token: 0x06001FDC RID: 8156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FDC")]
	[Address(RVA = "0xA928E0", Offset = "0xA918E0", VA = "0x180A928E0")]
	public void OnOpenBugReport()
	{
	}

	// Token: 0x06001FDD RID: 8157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FDD")]
	[Address(RVA = "0xA92B80", Offset = "0xA91B80", VA = "0x180A92B80")]
	public void OnCloseBugReport()
	{
	}

	// Token: 0x06001FDE RID: 8158 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FDE")]
	[Address(RVA = "0xA92D40", Offset = "0xA91D40", VA = "0x180A92D40")]
	public void SumbitBugReport()
	{
	}

	// Token: 0x06001FDF RID: 8159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FDF")]
	[Address(RVA = "0xA94280", Offset = "0xA93280", VA = "0x180A94280")]
	public void RefreshSaveGameDropdown()
	{
	}

	// Token: 0x06001FE0 RID: 8160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FE0")]
	[Address(RVA = "0xA94890", Offset = "0xA93890", VA = "0x180A94890")]
	public void ResetBugReportDetails()
	{
	}

	// Token: 0x06001FE1 RID: 8161 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FE1")]
	[Address(RVA = "0xA949F0", Offset = "0xA939F0", VA = "0x180A949F0")]
	public void OnChangeBugNameButton()
	{
	}

	// Token: 0x06001FE2 RID: 8162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FE2")]
	[Address(RVA = "0xA94D10", Offset = "0xA93D10", VA = "0x180A94D10")]
	public void OnChangeBugNameCancel()
	{
	}

	// Token: 0x06001FE3 RID: 8163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FE3")]
	[Address(RVA = "0xA94E70", Offset = "0xA93E70", VA = "0x180A94E70")]
	public void OnChangeBugNameConfirm()
	{
	}

	// Token: 0x06001FE4 RID: 8164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FE4")]
	[Address(RVA = "0xA95060", Offset = "0xA94060", VA = "0x180A95060")]
	public void OnChangeBugDetailsButton()
	{
	}

	// Token: 0x06001FE5 RID: 8165 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FE5")]
	[Address(RVA = "0xA95380", Offset = "0xA94380", VA = "0x180A95380")]
	public void OnChangeBugDetailsCancel()
	{
	}

	// Token: 0x06001FE6 RID: 8166 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FE6")]
	[Address(RVA = "0xA954E0", Offset = "0xA944E0", VA = "0x180A954E0")]
	public void OnChangeBugDetailsConfirm()
	{
	}

	// Token: 0x06001FE7 RID: 8167 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FE7")]
	[Address(RVA = "0xA956D0", Offset = "0xA946D0", VA = "0x180A956D0")]
	public void PlayButtonClick()
	{
	}

	// Token: 0x06001FE8 RID: 8168 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FE8")]
	[Address(RVA = "0xA95780", Offset = "0xA94780", VA = "0x180A95780")]
	public void PlayForwardButtonClick()
	{
	}

	// Token: 0x06001FE9 RID: 8169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FE9")]
	[Address(RVA = "0xA95830", Offset = "0xA94830", VA = "0x180A95830")]
	public void PlayBackButtonClick()
	{
	}

	// Token: 0x06001FEA RID: 8170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FEA")]
	[Address(RVA = "0xA958E0", Offset = "0xA948E0", VA = "0x180A958E0")]
	public void PlayTickbox()
	{
	}

	// Token: 0x06001FEB RID: 8171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FEB")]
	[Address(RVA = "0xA95990", Offset = "0xA94990", VA = "0x180A95990")]
	public void OnLanguageChange()
	{
	}

	// Token: 0x06001FEC RID: 8172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FEC")]
	[Address(RVA = "0xA95C20", Offset = "0xA94C20", VA = "0x180A95C20")]
	private void LangRestartGame()
	{
	}

	// Token: 0x06001FED RID: 8173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FED")]
	[Address(RVA = "0xA95EB0", Offset = "0xA94EB0", VA = "0x180A95EB0")]
	private void LangCancelRestartGame()
	{
	}

	// Token: 0x06001FEE RID: 8174 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FEE")]
	[Address(RVA = "0xA960D0", Offset = "0xA950D0", VA = "0x180A960D0")]
	public void OnChangeResolution()
	{
	}

	// Token: 0x06001FEF RID: 8175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FEF")]
	[Address(RVA = "0xA96630", Offset = "0xA95630", VA = "0x180A96630")]
	public void LowResolutionTextScalingCheck()
	{
	}

	// Token: 0x06001FF0 RID: 8176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FF0")]
	[Address(RVA = "0xA96B00", Offset = "0xA95B00", VA = "0x180A96B00")]
	public void CopyShareCodeToClipboard()
	{
	}

	// Token: 0x06001FF1 RID: 8177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FF1")]
	[Address(RVA = "0xA96BF0", Offset = "0xA95BF0", VA = "0x180A96BF0")]
	public void NewGameTypeButton(bool sandbox)
	{
	}

	// Token: 0x06001FF2 RID: 8178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FF2")]
	[Address(RVA = "0xA96CA0", Offset = "0xA95CA0", VA = "0x180A96CA0")]
	public void PreviousMenu()
	{
	}

	// Token: 0x06001FF3 RID: 8179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FF3")]
	[Address(RVA = "0xA96CB0", Offset = "0xA95CB0", VA = "0x180A96CB0")]
	public void LoadTip()
	{
	}

	// Token: 0x06001FF4 RID: 8180 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FF4")]
	[Address(RVA = "0xA97190", Offset = "0xA96190", VA = "0x180A97190")]
	public void ShadowsWebsiteLink()
	{
	}

	// Token: 0x06001FF5 RID: 8181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FF5")]
	[Address(RVA = "0xA97210", Offset = "0xA96210", VA = "0x180A97210")]
	public void OnEffectStatusChange()
	{
	}

	// Token: 0x06001FF6 RID: 8182 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FF6")]
	[Address(RVA = "0xA97220", Offset = "0xA96220", VA = "0x180A97220")]
	public void SetStatusEffectOptionsAccordingToDropdown()
	{
	}

	// Token: 0x06001FF7 RID: 8183 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FF7")]
	[Address(RVA = "0xA979F0", Offset = "0xA969F0", VA = "0x180A979F0")]
	public void SetDropdownAccordingToStatusEffects()
	{
	}

	// Token: 0x06001FF8 RID: 8184 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FF8")]
	[Address(RVA = "0xA97C10", Offset = "0xA96C10", VA = "0x180A97C10")]
	public void ResetControls()
	{
	}

	// Token: 0x06001FF9 RID: 8185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FF9")]
	[Address(RVA = "0xA97C80", Offset = "0xA96C80", VA = "0x180A97C80")]
	public void OnOpenModMenu()
	{
	}

	// Token: 0x06001FFA RID: 8186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FFA")]
	[Address(RVA = "0xA97CD0", Offset = "0xA96CD0", VA = "0x180A97CD0")]
	public void OnContinueCityGeneration()
	{
	}

	// Token: 0x06001FFB RID: 8187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FFB")]
	[Address(RVA = "0xA98320", Offset = "0xA97320", VA = "0x180A98320")]
	public void ConfirmCityGeneration()
	{
	}

	// Token: 0x06001FFC RID: 8188 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FFC")]
	[Address(RVA = "0xA984A0", Offset = "0xA974A0", VA = "0x180A984A0")]
	public void RejectCityGeneration()
	{
	}

	// Token: 0x06001FFD RID: 8189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FFD")]
	[Address(RVA = "0xA98610", Offset = "0xA97610", VA = "0x180A98610")]
	public void CleanOrphanPhotoCacheFiles()
	{
	}

	// Token: 0x06001FFE RID: 8190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FFE")]
	[Address(RVA = "0xA98B00", Offset = "0xA97B00", VA = "0x180A98B00")]
	public static void DeletePhotoCache(string target_dir)
	{
	}

	// Token: 0x06001FFF RID: 8191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FFF")]
	[Address(RVA = "0xA98CD0", Offset = "0xA97CD0", VA = "0x180A98CD0")]
	public MainMenuController()
	{
	}

	// Token: 0x06002000 RID: 8192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002000")]
	[Address(RVA = "0xA993F0", Offset = "0xA983F0", VA = "0x180A993F0")]
	private void <Start>b__131_0()
	{
	}

	// Token: 0x06002001 RID: 8193 RVA: 0x0000DD70 File Offset: 0x0000BF70
	[Token(Token = "0x6002001")]
	[Address(RVA = "0xA99540", Offset = "0xA98540", VA = "0x180A99540")]
	private bool <LoadCityInfo>b__151_0(CityControls.CitySize item)
	{
		return default(bool);
	}

	// Token: 0x06002002 RID: 8194 RVA: 0x0000DD88 File Offset: 0x0000BF88
	[Token(Token = "0x6002002")]
	[Address(RVA = "0xA995D0", Offset = "0xA985D0", VA = "0x180A995D0")]
	private bool <SumbitBugReport>b__205_0(FileInfo item)
	{
		return default(bool);
	}

	// Token: 0x06002003 RID: 8195 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
	[Token(Token = "0x6002003")]
	[Address(RVA = "0xA996D0", Offset = "0xA986D0", VA = "0x180A996D0")]
	private bool <OnChangeResolution>b__221_0(Resolution item)
	{
		return default(bool);
	}

	// Token: 0x040028D0 RID: 10448
	[Token(Token = "0x40028D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RectTransform mainMenuContainer;

	// Token: 0x040028D1 RID: 10449
	[Token(Token = "0x40028D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image backgroundImage;

	// Token: 0x040028D2 RID: 10450
	[Token(Token = "0x40028D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image logoImage;

	// Token: 0x040028D3 RID: 10451
	[Token(Token = "0x40028D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI buildText;

	// Token: 0x040028D4 RID: 10452
	[Token(Token = "0x40028D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject buildNameObject;

	// Token: 0x040028D5 RID: 10453
	[Token(Token = "0x40028D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float time;

	// Token: 0x040028D6 RID: 10454
	[Token(Token = "0x40028D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public MainMenuController.Component previousComponent;

	// Token: 0x040028D7 RID: 10455
	[Token(Token = "0x40028D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MainMenuController.MenuComponent currentComponent;

	// Token: 0x040028D8 RID: 10456
	[Token(Token = "0x40028D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float componentMotion;

	// Token: 0x040028D9 RID: 10457
	[Token(Token = "0x40028D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public FeedbackForm feedbackForm;

	// Token: 0x040028DA RID: 10458
	[Token(Token = "0x40028DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public FormField feedbackPlayerInfo;

	// Token: 0x040028DB RID: 10459
	[Token(Token = "0x40028DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool saveDof;

	// Token: 0x040028DC RID: 10460
	[Token(Token = "0x40028DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI betaMessageText;

	// Token: 0x040028DD RID: 10461
	[Token(Token = "0x40028DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GraphicRaycaster raycaster;

	// Token: 0x040028DE RID: 10462
	[Token(Token = "0x40028DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool askedStreamerQuestion;

	// Token: 0x040028DF RID: 10463
	[Token(Token = "0x40028DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	public bool acceptedEULA;

	// Token: 0x040028E0 RID: 10464
	[Token(Token = "0x40028E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<MainMenuController.MenuComponent> components;

	// Token: 0x040028E1 RID: 10465
	[Token(Token = "0x40028E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public string loadingTipsDDSTree;

	// Token: 0x040028E2 RID: 10466
	[Token(Token = "0x40028E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<MainMenuController.LoadingTip> loadingTips;

	// Token: 0x040028E3 RID: 10467
	[Token(Token = "0x40028E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float nextTipTimer;

	// Token: 0x040028E4 RID: 10468
	[Token(Token = "0x40028E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public DropdownController languageDropdown;

	// Token: 0x040028E5 RID: 10469
	[Token(Token = "0x40028E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public DropdownController resolutionsDropdown;

	// Token: 0x040028E6 RID: 10470
	[Token(Token = "0x40028E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public DropdownController fullScreenModeDropdown;

	// Token: 0x040028E7 RID: 10471
	[Token(Token = "0x40028E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public DropdownController startTimeDropdown;

	// Token: 0x040028E8 RID: 10472
	[Token(Token = "0x40028E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public DropdownController gameDifficultyDropdown;

	// Token: 0x040028E9 RID: 10473
	[Token(Token = "0x40028E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public DropdownController gameDifficultyDropdown2;

	// Token: 0x040028EA RID: 10474
	[Token(Token = "0x40028EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public DropdownController gameLengthDropdown;

	// Token: 0x040028EB RID: 10475
	[Token(Token = "0x40028EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public DropdownController selectCityDropdown;

	// Token: 0x040028EC RID: 10476
	[Token(Token = "0x40028EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public DropdownController playerGenderDropdown;

	// Token: 0x040028ED RID: 10477
	[Token(Token = "0x40028ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public DropdownController partnerGenderDropdown;

	// Token: 0x040028EE RID: 10478
	[Token(Token = "0x40028EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public DropdownController citySizeDropdown;

	// Token: 0x040028EF RID: 10479
	[Token(Token = "0x40028EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public DropdownController cityPopDropdown;

	// Token: 0x040028F0 RID: 10480
	[Token(Token = "0x40028F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public DropdownController statusEffectsDropdown;

	// Token: 0x040028F1 RID: 10481
	[Token(Token = "0x40028F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public DropdownController aaModeDropdown;

	// Token: 0x040028F2 RID: 10482
	[Token(Token = "0x40028F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public DropdownController aaQualityDropdown;

	// Token: 0x040028F3 RID: 10483
	[Token(Token = "0x40028F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public DropdownController dlssModeDropdown;

	// Token: 0x040028F4 RID: 10484
	[Token(Token = "0x40028F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public DropdownController hyperacusisDropdown;

	// Token: 0x040028F5 RID: 10485
	[Token(Token = "0x40028F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public DropdownController bassReductionDropdown;

	// Token: 0x040028F6 RID: 10486
	[Token(Token = "0x40028F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public List<ToggleController> statusEffectToggles;

	// Token: 0x040028F7 RID: 10487
	[Token(Token = "0x40028F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public ButtonController saveGameButton;

	// Token: 0x040028F8 RID: 10488
	[Token(Token = "0x40028F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public ButtonController loadGameButton;

	// Token: 0x040028F9 RID: 10489
	[Token(Token = "0x40028F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public ButtonController sandboxGameButton;

	// Token: 0x040028FA RID: 10490
	[Token(Token = "0x40028FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public ButtonController cityGenButton;

	// Token: 0x040028FB RID: 10491
	[Token(Token = "0x40028FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public ButtonController resumeGameButton;

	// Token: 0x040028FC RID: 10492
	[Token(Token = "0x40028FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public ButtonController helpButton;

	// Token: 0x040028FD RID: 10493
	[Token(Token = "0x40028FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public ButtonController bugReportButton;

	// Token: 0x040028FE RID: 10494
	[Token(Token = "0x40028FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public ButtonController modsButton;

	// Token: 0x040028FF RID: 10495
	[Token(Token = "0x40028FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public TextMeshProUGUI selectedCityShareCode;

	// Token: 0x04002900 RID: 10496
	[Token(Token = "0x4002900")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public TextMeshProUGUI selectedCityDetailsText;

	// Token: 0x04002901 RID: 10497
	[Token(Token = "0x4002901")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public ButtonController selectedCityContinueButton;

	// Token: 0x04002902 RID: 10498
	[Token(Token = "0x4002902")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[NonSerialized]
	public CityInfoData selectedCityInfoData;

	// Token: 0x04002903 RID: 10499
	[Token(Token = "0x4002903")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public ButtonController selectedCityCopyShareCodeButton;

	// Token: 0x04002904 RID: 10500
	[Token(Token = "0x4002904")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public ButtonController deleteCityButton;

	// Token: 0x04002905 RID: 10501
	[Token(Token = "0x4002905")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private List<FileInfo> cityMapFiles;

	// Token: 0x04002906 RID: 10502
	[Token(Token = "0x4002906")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private List<FileInfo> cityInfoFiles;

	// Token: 0x04002907 RID: 10503
	[Token(Token = "0x4002907")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private Dictionary<string, CityInfoData> cityInfoDict;

	// Token: 0x04002908 RID: 10504
	[Token(Token = "0x4002908")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public ButtonController developerOptionsButton;

	// Token: 0x04002909 RID: 10505
	[Token(Token = "0x4002909")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public Slider windSlider;

	// Token: 0x0400290A RID: 10506
	[Token(Token = "0x400290A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public Slider rainSlider;

	// Token: 0x0400290B RID: 10507
	[Token(Token = "0x400290B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public Slider lightningSlider;

	// Token: 0x0400290C RID: 10508
	[Token(Token = "0x400290C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public Slider snowSlider;

	// Token: 0x0400290D RID: 10509
	[Token(Token = "0x400290D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public Slider fogSlider;

	// Token: 0x0400290E RID: 10510
	[Token(Token = "0x400290E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public Button setWeatherButton;

	// Token: 0x0400290F RID: 10511
	[Token(Token = "0x400290F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public ToggleController allowLicensedMusicToggle;

	// Token: 0x04002910 RID: 10512
	[Token(Token = "0x4002910")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public ButtonController playerNameButton;

	// Token: 0x04002911 RID: 10513
	[Token(Token = "0x4002911")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public MultiSelectController playerSkinToneSelect;

	// Token: 0x04002912 RID: 10514
	[Token(Token = "0x4002912")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public ToggleController mousedOverModifier;

	// Token: 0x04002913 RID: 10515
	[Token(Token = "0x4002913")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public TMP_Text modifiersHeader;

	// Token: 0x04002914 RID: 10516
	[Token(Token = "0x4002914")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public TMP_Text modifiersDescription;

	// Token: 0x04002915 RID: 10517
	[Token(Token = "0x4002915")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public TextMeshProUGUI shareCodeText;

	// Token: 0x04002916 RID: 10518
	[Token(Token = "0x4002916")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public ButtonController pasteShareCodeButton;

	// Token: 0x04002917 RID: 10519
	[Token(Token = "0x4002917")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public ButtonController changeCityNameButton;

	// Token: 0x04002918 RID: 10520
	[Token(Token = "0x4002918")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public TextMeshProUGUI generationWarningText;

	// Token: 0x04002919 RID: 10521
	[Token(Token = "0x4002919")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	public TextMeshProUGUI creditsText;

	// Token: 0x0400291A RID: 10522
	[Token(Token = "0x400291A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	public RectTransform creditsPageContent;

	// Token: 0x0400291B RID: 10523
	[Token(Token = "0x400291B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	public TextMeshProUGUI mouseOverText;

	// Token: 0x0400291C RID: 10524
	[Token(Token = "0x400291C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public bool mainMenuActive;

	// Token: 0x0400291D RID: 10525
	[Token(Token = "0x400291D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	public string loadedLanguage;

	// Token: 0x0400291E RID: 10526
	[Token(Token = "0x400291E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	public TextMeshProUGUI loadingText;

	// Token: 0x0400291F RID: 10527
	[Token(Token = "0x400291F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	public Slider loadingSlider;

	// Token: 0x04002920 RID: 10528
	[Token(Token = "0x4002920")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	public TextMeshProUGUI tipText;

	// Token: 0x04002921 RID: 10529
	[Token(Token = "0x4002921")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	public Image tipImg;

	// Token: 0x04002922 RID: 10530
	[Token(Token = "0x4002922")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	public CanvasRenderer fadeOverlay;

	// Token: 0x04002923 RID: 10531
	[Token(Token = "0x4002923")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	public float desiredFade;

	// Token: 0x04002924 RID: 10532
	[Token(Token = "0x4002924")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
	public float fade;

	// Token: 0x04002925 RID: 10533
	[Token(Token = "0x4002925")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private bool exitMainMenuAfterFade;

	// Token: 0x04002926 RID: 10534
	[Token(Token = "0x4002926")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	public RectTransform loadGameContentRect;

	// Token: 0x04002927 RID: 10535
	[Token(Token = "0x4002927")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	public RectTransform saveGameContentRect;

	// Token: 0x04002928 RID: 10536
	[Token(Token = "0x4002928")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	public GameObject saveGameEntryPrefab;

	// Token: 0x04002929 RID: 10537
	[Token(Token = "0x4002929")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	private List<SaveGameEntryController> spawnedSaveGames;

	// Token: 0x0400292A RID: 10538
	[Token(Token = "0x400292A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	private List<SaveGameEntryController> spawnedLoadGames;

	// Token: 0x0400292B RID: 10539
	[Token(Token = "0x400292B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	public SaveGameEntryController selectedSave;

	// Token: 0x0400292C RID: 10540
	[Token(Token = "0x400292C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	public ButtonController saveButton;

	// Token: 0x0400292D RID: 10541
	[Token(Token = "0x400292D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	public ButtonController loadButton;

	// Token: 0x0400292E RID: 10542
	[Token(Token = "0x400292E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	public ButtonController deleteButton;

	// Token: 0x0400292F RID: 10543
	[Token(Token = "0x400292F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	public ButtonController deleteButton2;

	// Token: 0x04002930 RID: 10544
	[Token(Token = "0x4002930")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	public SaveGameEntryController newSaveGameEntry;

	// Token: 0x04002931 RID: 10545
	[Token(Token = "0x4002931")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	public TextMeshProUGUI selectedSaveText1;

	// Token: 0x04002932 RID: 10546
	[Token(Token = "0x4002932")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	public TextMeshProUGUI selectedSaveText2;

	// Token: 0x04002933 RID: 10547
	[Token(Token = "0x4002933")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	public DropdownController bugSaveDropdown;

	// Token: 0x04002934 RID: 10548
	[Token(Token = "0x4002934")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	public DropdownController priorityDropdown;

	// Token: 0x04002935 RID: 10549
	[Token(Token = "0x4002935")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	public DropdownController categoryDropdown;

	// Token: 0x04002936 RID: 10550
	[Token(Token = "0x4002936")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	public ButtonController bugNameInput;

	// Token: 0x04002937 RID: 10551
	[Token(Token = "0x4002937")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	public ButtonController bugDetailsInput;

	// Token: 0x04002938 RID: 10552
	[Token(Token = "0x4002938")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	public ToggleController sendScreenshotToggle;

	// Token: 0x04002939 RID: 10553
	[Token(Token = "0x4002939")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	public ToggleController sendSystemSpecsToggle;

	// Token: 0x0400293A RID: 10554
	[Token(Token = "0x400293A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	public ToggleController sendPrevLogToggle;

	// Token: 0x0400293B RID: 10555
	[Token(Token = "0x400293B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	public float bugReportTimer;

	// Token: 0x0400293C RID: 10556
	[Token(Token = "0x400293C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	public TMP_Dropdown ffPriority;

	// Token: 0x0400293D RID: 10557
	[Token(Token = "0x400293D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	public TMP_Dropdown ffCategory;

	// Token: 0x0400293E RID: 10558
	[Token(Token = "0x400293E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	public TMP_InputField ffNameInput;

	// Token: 0x0400293F RID: 10559
	[Token(Token = "0x400293F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	public TMP_InputField ffDescriptionInput;

	// Token: 0x04002940 RID: 10560
	[Token(Token = "0x4002940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	public FormField ffSystemInfo;

	// Token: 0x04002941 RID: 10561
	[Token(Token = "0x4002941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	public FormElement ffPrevLogCollector;

	// Token: 0x04002942 RID: 10562
	[Token(Token = "0x4002942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
	public List<DropdownController> disableWithDynamicResolution;

	// Token: 0x04002943 RID: 10563
	[Token(Token = "0x4002943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	public List<DropdownController> enableWithDynamicResolution;

	// Token: 0x04002944 RID: 10564
	[Token(Token = "0x4002944")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
	public List<ButtonController> activeBackButtons;

	// Token: 0x04002945 RID: 10565
	[Token(Token = "0x4002945")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
	public bool gameHasBeenSaved;

	// Token: 0x04002946 RID: 10566
	[Token(Token = "0x4002946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A9")]
	public bool exitPrompt;

	// Token: 0x04002947 RID: 10567
	[Token(Token = "0x4002947")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
	public CanvasRenderer topBarRend;

	// Token: 0x04002948 RID: 10568
	[Token(Token = "0x4002948")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
	public CanvasRenderer bottomBarRend;

	// Token: 0x04002949 RID: 10569
	[Token(Token = "0x4002949")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
	public TextMeshProUGUI titleText;

	// Token: 0x0400294A RID: 10570
	[Token(Token = "0x400294A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
	public AnimationCurve titleTextKerningAnimation;

	// Token: 0x0400294B RID: 10571
	[Token(Token = "0x400294B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MainMenuController _instance;

	// Token: 0x020005A9 RID: 1449
	[Token(Token = "0x20005A9")]
	[Serializable]
	public class MenuComponent
	{
		// Token: 0x06002004 RID: 8196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002004")]
		[Address(RVA = "0xACC750", Offset = "0xACB750", VA = "0x180ACC750")]
		public MenuComponent()
		{
		}

		// Token: 0x0400294C RID: 10572
		[Token(Token = "0x400294C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MainMenuController.Component component;

		// Token: 0x0400294D RID: 10573
		[Token(Token = "0x400294D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform rect;

		// Token: 0x0400294E RID: 10574
		[Token(Token = "0x400294E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int xPhase;

		// Token: 0x0400294F RID: 10575
		[Token(Token = "0x400294F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 onscreenAnchoredPosition;

		// Token: 0x04002950 RID: 10576
		[Token(Token = "0x4002950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<ButtonController> buttons;

		// Token: 0x04002951 RID: 10577
		[Token(Token = "0x4002951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ButtonController previouslySelected;

		// Token: 0x04002952 RID: 10578
		[Token(Token = "0x4002952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool skipMotion;
	}

	// Token: 0x020005AA RID: 1450
	[Token(Token = "0x20005AA")]
	public enum Component
	{
		// Token: 0x04002954 RID: 10580
		[Token(Token = "0x4002954")]
		none,
		// Token: 0x04002955 RID: 10581
		[Token(Token = "0x4002955")]
		mainMenuButtons,
		// Token: 0x04002956 RID: 10582
		[Token(Token = "0x4002956")]
		settings,
		// Token: 0x04002957 RID: 10583
		[Token(Token = "0x4002957")]
		newGameSelect,
		// Token: 0x04002958 RID: 10584
		[Token(Token = "0x4002958")]
		city,
		// Token: 0x04002959 RID: 10585
		[Token(Token = "0x4002959")]
		citySelect,
		// Token: 0x0400295A RID: 10586
		[Token(Token = "0x400295A")]
		generateCity,
		// Token: 0x0400295B RID: 10587
		[Token(Token = "0x400295B")]
		charSetup,
		// Token: 0x0400295C RID: 10588
		[Token(Token = "0x400295C")]
		interfaceSettings,
		// Token: 0x0400295D RID: 10589
		[Token(Token = "0x400295D")]
		graphicsSettings,
		// Token: 0x0400295E RID: 10590
		[Token(Token = "0x400295E")]
		audioSettings,
		// Token: 0x0400295F RID: 10591
		[Token(Token = "0x400295F")]
		gameplaySettings,
		// Token: 0x04002960 RID: 10592
		[Token(Token = "0x4002960")]
		controlSettings,
		// Token: 0x04002961 RID: 10593
		[Token(Token = "0x4002961")]
		devSettings,
		// Token: 0x04002962 RID: 10594
		[Token(Token = "0x4002962")]
		saveGame,
		// Token: 0x04002963 RID: 10595
		[Token(Token = "0x4002963")]
		loadGame,
		// Token: 0x04002964 RID: 10596
		[Token(Token = "0x4002964")]
		credits,
		// Token: 0x04002965 RID: 10597
		[Token(Token = "0x4002965")]
		loadingCity,
		// Token: 0x04002966 RID: 10598
		[Token(Token = "0x4002966")]
		splash,
		// Token: 0x04002967 RID: 10599
		[Token(Token = "0x4002967")]
		controlDetect,
		// Token: 0x04002968 RID: 10600
		[Token(Token = "0x4002968")]
		streamingSettings,
		// Token: 0x04002969 RID: 10601
		[Token(Token = "0x4002969")]
		bugReport,
		// Token: 0x0400296A RID: 10602
		[Token(Token = "0x400296A")]
		mods,
		// Token: 0x0400296B RID: 10603
		[Token(Token = "0x400296B")]
		gameplayModifiers,
		// Token: 0x0400296C RID: 10604
		[Token(Token = "0x400296C")]
		controlBindings
	}

	// Token: 0x020005AB RID: 1451
	[Token(Token = "0x20005AB")]
	[Serializable]
	public class LoadingTip
	{
		// Token: 0x06002005 RID: 8197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002005")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public LoadingTip()
		{
		}

		// Token: 0x0400296D RID: 10605
		[Token(Token = "0x400296D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string dictRef;

		// Token: 0x0400296E RID: 10606
		[Token(Token = "0x400296E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite image;
	}

	// Token: 0x020005AC RID: 1452
	[Token(Token = "0x20005AC")]
	private sealed class <FadeMenu>d__137 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06002006 RID: 8198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002006")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <FadeMenu>d__137(int <>1__state)
		{
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002007")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		[Token(Token = "0x6002008")]
		[Address(RVA = "0xACC820", Offset = "0xACB820", VA = "0x180ACC820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010C")]
		private object Current
		{
			[Token(Token = "0x6002009")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200A")]
		[Address(RVA = "0xACCE90", Offset = "0xACBE90", VA = "0x180ACCE90", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010D")]
		private object Current
		{
			[Token(Token = "0x600200B")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400296F RID: 10607
		[Token(Token = "0x400296F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002970 RID: 10608
		[Token(Token = "0x4002970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002971 RID: 10609
		[Token(Token = "0x4002971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MainMenuController <>4__this;
	}

	// Token: 0x020005AD RID: 1453
	[Token(Token = "0x20005AD")]
	private sealed class <>c__DisplayClass139_0
	{
		// Token: 0x0600200C RID: 8204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass139_0()
		{
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
		[Token(Token = "0x600200D")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <SetMenuComponent>b__0(MainMenuController.MenuComponent item)
		{
			return default(bool);
		}

		// Token: 0x04002972 RID: 10610
		[Token(Token = "0x4002972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MainMenuController.Component newComponent;
	}

	// Token: 0x020005AE RID: 1454
	[Token(Token = "0x20005AE")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600200F RID: 8207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		[Token(Token = "0x6002010")]
		[Address(RVA = "0xACCF90", Offset = "0xACBF90", VA = "0x180ACCF90")]
		internal bool <SetMenuComponent>b__139_1(ButtonController item)
		{
			return default(bool);
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x0000DE00 File Offset: 0x0000C000
		[Token(Token = "0x6002011")]
		[Address(RVA = "0xACD090", Offset = "0xACC090", VA = "0x180ACD090")]
		internal bool <SetToStreamerMode>b__140_0(PlayerPrefsController.GameSetting item)
		{
			return default(bool);
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x0000DE18 File Offset: 0x0000C018
		[Token(Token = "0x6002012")]
		[Address(RVA = "0xACD120", Offset = "0xACC120", VA = "0x180ACD120")]
		internal int <RefreshSaveEntries>b__189_0(FileInfo p2, FileInfo p1)
		{
			return 0;
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x0000DE30 File Offset: 0x0000C030
		[Token(Token = "0x6002013")]
		[Address(RVA = "0xACD1F0", Offset = "0xACC1F0", VA = "0x180ACD1F0")]
		internal int <RefreshSaveGameDropdown>b__206_0(FileInfo p2, FileInfo p1)
		{
			return 0;
		}

		// Token: 0x04002973 RID: 10611
		[Token(Token = "0x4002973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly MainMenuController.<>c <>9;

		// Token: 0x04002974 RID: 10612
		[Token(Token = "0x4002974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<ButtonController> <>9__139_1;

		// Token: 0x04002975 RID: 10613
		[Token(Token = "0x4002975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<PlayerPrefsController.GameSetting> <>9__140_0;

		// Token: 0x04002976 RID: 10614
		[Token(Token = "0x4002976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Comparison<FileInfo> <>9__189_0;

		// Token: 0x04002977 RID: 10615
		[Token(Token = "0x4002977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Comparison<FileInfo> <>9__206_0;
	}

	// Token: 0x020005AF RID: 1455
	[Token(Token = "0x20005AF")]
	private sealed class <MenuMotion>d__144 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06002014 RID: 8212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002014")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <MenuMotion>d__144(int <>1__state)
		{
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002015")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x0000DE48 File Offset: 0x0000C048
		[Token(Token = "0x6002016")]
		[Address(RVA = "0xACD2C0", Offset = "0xACC2C0", VA = "0x180ACD2C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010E")]
		private object Current
		{
			[Token(Token = "0x6002017")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002018")]
		[Address(RVA = "0xACE290", Offset = "0xACD290", VA = "0x180ACE290", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010F")]
		private object Current
		{
			[Token(Token = "0x6002019")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002978 RID: 10616
		[Token(Token = "0x4002978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002979 RID: 10617
		[Token(Token = "0x4002979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400297A RID: 10618
		[Token(Token = "0x400297A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MainMenuController <>4__this;

		// Token: 0x0400297B RID: 10619
		[Token(Token = "0x400297B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool skipMotion;
	}

	// Token: 0x020005B0 RID: 1456
	[Token(Token = "0x20005B0")]
	private sealed class <>c__DisplayClass155_0
	{
		// Token: 0x0600201A RID: 8218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass155_0()
		{
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x0000DE60 File Offset: 0x0000C060
		[Token(Token = "0x600201B")]
		[Address(RVA = "0xA13570", Offset = "0xA12570", VA = "0x180A13570")]
		internal bool <ParseShareCode>b__0(CityControls.CitySize item)
		{
			return default(bool);
		}

		// Token: 0x0400297C RID: 10620
		[Token(Token = "0x400297C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int parsedSizeX;

		// Token: 0x0400297D RID: 10621
		[Token(Token = "0x400297D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int parsedSizeY;
	}

	// Token: 0x020005B1 RID: 1457
	[Token(Token = "0x20005B1")]
	[StructLayout(3)]
	private struct <StartSaveAsync>d__183 : IEnumerator<object>
	{
		// Token: 0x0600201C RID: 8220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201C")]
		[Address(RVA = "0xACE2E0", Offset = "0xACD2E0", VA = "0x180ACE2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201D")]
		[Address(RVA = "0x6F8FA0", Offset = "0x6F7FA0", VA = "0x1806F8FA0", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x0400297E RID: 10622
		[Token(Token = "0x400297E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x0400297F RID: 10623
		[Token(Token = "0x400297F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		// Token: 0x04002980 RID: 10624
		[Token(Token = "0x4002980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MainMenuController <>4__this;

		// Token: 0x04002981 RID: 10625
		[Token(Token = "0x4002981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter <>u__1;
	}
}
