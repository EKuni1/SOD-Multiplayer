using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200028A RID: 650
[Token(Token = "0x200028A")]
public class ChapterIntro : Chapter
{
	// Token: 0x06000E6C RID: 3692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E6C")]
	[Address(RVA = "0x6051D0", Offset = "0x6041D0", VA = "0x1806051D0", Slot = "4")]
	public override void OnLoaded()
	{
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E6D")]
	[Address(RVA = "0x6051F0", Offset = "0x6041F0", VA = "0x1806051F0", Slot = "7")]
	public override void OnGameStart()
	{
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E6E")]
	[Address(RVA = "0x605390", Offset = "0x604390", VA = "0x180605390")]
	private void SetUpMission()
	{
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E6F")]
	[Address(RVA = "0x608D70", Offset = "0x607D70", VA = "0x180608D70", Slot = "14")]
	public override StateSaveData.ChaperStateSave GetChapterSaveData()
	{
		return null;
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E70")]
	[Address(RVA = "0x6098D0", Offset = "0x6088D0", VA = "0x1806098D0", Slot = "15")]
	public override void LoadStateSaveData(StateSaveData.ChaperStateSave newData)
	{
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E71")]
	[Address(RVA = "0x60B0A0", Offset = "0x60A0A0", VA = "0x18060B0A0", Slot = "6")]
	public override void OnObjectsCreated()
	{
	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E72")]
	[Address(RVA = "0x60B130", Offset = "0x60A130", VA = "0x18060B130")]
	private void SpawnPlayerApartmentClues()
	{
	}

	// Token: 0x06000E73 RID: 3699 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E73")]
	[Address(RVA = "0x60D060", Offset = "0x60C060", VA = "0x18060D060")]
	private void SpawnKidnapperClues()
	{
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E74")]
	[Address(RVA = "0x60EB10", Offset = "0x60DB10", VA = "0x18060EB10")]
	private void SpawnNotewriterClues()
	{
	}

	// Token: 0x06000E75 RID: 3701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E75")]
	[Address(RVA = "0x60F7F0", Offset = "0x60E7F0", VA = "0x18060F7F0")]
	private void SpawnKillerClues()
	{
	}

	// Token: 0x06000E76 RID: 3702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E76")]
	[Address(RVA = "0x610340", Offset = "0x60F340", VA = "0x180610340")]
	private void SpawnMiscClues()
	{
	}

	// Token: 0x06000E77 RID: 3703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E77")]
	[Address(RVA = "0x610CA0", Offset = "0x60FCA0", VA = "0x180610CA0")]
	public void ExecutePreSim()
	{
	}

	// Token: 0x06000E78 RID: 3704 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E78")]
	[Address(RVA = "0x6112E0", Offset = "0x6102E0", VA = "0x1806112E0")]
	private IEnumerator PreSimHandling()
	{
		return null;
	}

	// Token: 0x06000E79 RID: 3705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E79")]
	[Address(RVA = "0x611380", Offset = "0x610380", VA = "0x180611380", Slot = "9")]
	public override void OnGameWorldLoop()
	{
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E7A")]
	[Address(RVA = "0x614340", Offset = "0x613340", VA = "0x180614340")]
	public void OnReturnToApartmentOption()
	{
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E7B")]
	[Address(RVA = "0x614670", Offset = "0x613670", VA = "0x180614670")]
	public void OnSkipAheadOption()
	{
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E7C")]
	[Address(RVA = "0x614930", Offset = "0x613930", VA = "0x180614930")]
	public void OnCancelOption()
	{
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E7D")]
	[Address(RVA = "0x614BD0", Offset = "0x613BD0", VA = "0x180614BD0")]
	private void ChooseInvestigatePhone()
	{
	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E7E")]
	[Address(RVA = "0x615220", Offset = "0x614220", VA = "0x180615220")]
	private void ChooseInvestigateCCTV()
	{
	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E7F")]
	[Address(RVA = "0x6159A0", Offset = "0x6149A0", VA = "0x1806159A0")]
	private void ChooseInvestigateVmails()
	{
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E80")]
	[Address(RVA = "0x616050", Offset = "0x615050", VA = "0x180616050")]
	private void ChooseInvestigateMurderWeapon()
	{
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E81")]
	[Address(RVA = "0x6165E0", Offset = "0x6155E0", VA = "0x1806165E0")]
	private void ChooseCancelLeads()
	{
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E82")]
	[Address(RVA = "0x6169A0", Offset = "0x6159A0", VA = "0x1806169A0")]
	public void ChangeLeadTip()
	{
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E83")]
	[Address(RVA = "0x616B30", Offset = "0x615B30", VA = "0x180616B30")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E84")]
	[Address(RVA = "0x616DD0", Offset = "0x615DD0", VA = "0x180616DD0")]
	public void OnMurderStateChange(MurderController.MurderState newState)
	{
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E85")]
	[Address(RVA = "0x617020", Offset = "0x616020", VA = "0x180617020")]
	private void PickCharacters()
	{
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E86")]
	[Address(RVA = "0x619CE0", Offset = "0x618CE0", VA = "0x180619CE0")]
	public void TurnOnLight(int passedVar)
	{
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E87")]
	[Address(RVA = "0x61B5D0", Offset = "0x61A5D0", VA = "0x18061B5D0")]
	public void FindPartner(int passedVar)
	{
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E88")]
	[Address(RVA = "0x61C480", Offset = "0x61B480", VA = "0x18061C480")]
	public void TelephoneRing(int passedVar)
	{
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E89")]
	[Address(RVA = "0x61C880", Offset = "0x61B880", VA = "0x18061C880")]
	private void RingPhone()
	{
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E8A")]
	[Address(RVA = "0x61D210", Offset = "0x61C210", VA = "0x18061D210")]
	public void AnswerCall(int passedVar)
	{
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E8B")]
	[Address(RVA = "0x61DA60", Offset = "0x61CA60", VA = "0x18061DA60")]
	public void SomethingWrong(int passedVar)
	{
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E8C")]
	[Address(RVA = "0x61DF00", Offset = "0x61CF00", VA = "0x18061DF00")]
	public void OpenName(int passedVar)
	{
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E8D")]
	[Address(RVA = "0x61E720", Offset = "0x61D720", VA = "0x18061E720")]
	public void PinCitizen(int passedVar)
	{
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E8E")]
	[Address(RVA = "0x61F3F0", Offset = "0x61E3F0", VA = "0x18061F3F0")]
	public void PinNote(int passedVar)
	{
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E8F")]
	[Address(RVA = "0x61FC50", Offset = "0x61EC50", VA = "0x18061FC50")]
	public void CloseCaseBoard1(int passedVar)
	{
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E90")]
	[Address(RVA = "0x620330", Offset = "0x61F330", VA = "0x180620330")]
	public void InspectCityDirectory(int passedVar)
	{
	}

	// Token: 0x06000E91 RID: 3729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E91")]
	[Address(RVA = "0x620770", Offset = "0x61F770", VA = "0x180620770")]
	public void AddressLookup(int passedVar)
	{
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E92")]
	[Address(RVA = "0x621140", Offset = "0x620140", VA = "0x180621140")]
	public void PinAddress(int passedVar)
	{
	}

	// Token: 0x06000E93 RID: 3731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E93")]
	[Address(RVA = "0x621D40", Offset = "0x620D40", VA = "0x180621D40")]
	public void Pickup(int passedVar)
	{
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E94")]
	[Address(RVA = "0x622020", Offset = "0x621020", VA = "0x180622020")]
	public void AcquireLockpicks(int passedVar)
	{
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E95")]
	[Address(RVA = "0x622A60", Offset = "0x621A60", VA = "0x180622A60")]
	public void UnlockBox(int passedVar)
	{
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E96")]
	[Address(RVA = "0x622DD0", Offset = "0x621DD0", VA = "0x180622DD0")]
	public void GatherItems(int passedVar)
	{
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E97")]
	[Address(RVA = "0x623040", Offset = "0x622040", VA = "0x180623040")]
	public void TakeKey(int passedVar)
	{
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E98")]
	[Address(RVA = "0x6233B0", Offset = "0x6223B0", VA = "0x1806233B0")]
	public void SetRouteOpenCaseBoard(int passedVar)
	{
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E99")]
	[Address(RVA = "0x6235E0", Offset = "0x6225E0", VA = "0x1806235E0")]
	public void SetRoute(int passedVar)
	{
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E9A")]
	[Address(RVA = "0x623EE0", Offset = "0x622EE0", VA = "0x180623EE0")]
	public void CloseCaseBoard2(int passedVar)
	{
	}

	// Token: 0x06000E9B RID: 3739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E9B")]
	[Address(RVA = "0x624310", Offset = "0x623310", VA = "0x180624310")]
	public void UnlockFrontDoor(int passedVar)
	{
	}

	// Token: 0x06000E9C RID: 3740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E9C")]
	[Address(RVA = "0x624650", Offset = "0x623650", VA = "0x180624650")]
	public void FindNoteWriter(int passedVar)
	{
	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E9D")]
	[Address(RVA = "0x625B00", Offset = "0x624B00", VA = "0x180625B00")]
	public void Knock(int passedVar)
	{
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E9E")]
	[Address(RVA = "0x625F10", Offset = "0x624F10", VA = "0x180625F10")]
	public void FindWayInside(int passedVar)
	{
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E9F")]
	[Address(RVA = "0x626220", Offset = "0x625220", VA = "0x180626220")]
	public void InvestigateWriterAddress(int passedVar)
	{
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA0")]
	[Address(RVA = "0x626AB0", Offset = "0x625AB0", VA = "0x180626AB0")]
	private void EscapeTutorial()
	{
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA1")]
	[Address(RVA = "0x626B40", Offset = "0x625B40", VA = "0x180626B40")]
	public void FoundBody(int passedVar)
	{
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA2")]
	[Address(RVA = "0x627220", Offset = "0x626220", VA = "0x180627220")]
	public void CrimeSceneClues(int passedVar)
	{
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA3")]
	[Address(RVA = "0x629740", Offset = "0x628740", VA = "0x180629740")]
	public void PrintsTutorial()
	{
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA4")]
	[Address(RVA = "0x6297D0", Offset = "0x6287D0", VA = "0x1806297D0")]
	private void InventoryPrompt()
	{
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA5")]
	[Address(RVA = "0x6298B0", Offset = "0x6288B0", VA = "0x1806298B0")]
	public void FindMeetingNote()
	{
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA6")]
	[Address(RVA = "0x629940", Offset = "0x628940", VA = "0x180629940")]
	public void FindAddressNote()
	{
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA7")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void FindAddressBook()
	{
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA8")]
	[Address(RVA = "0x6299C0", Offset = "0x6289C0", VA = "0x1806299C0")]
	public void FindWorkID()
	{
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA9")]
	[Address(RVA = "0x629A40", Offset = "0x628A40", VA = "0x180629A40")]
	public void FindReceipt()
	{
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAA")]
	[Address(RVA = "0x629AD0", Offset = "0x628AD0", VA = "0x180629AD0")]
	public void FindCalendar()
	{
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAB")]
	[Address(RVA = "0x629B50", Offset = "0x628B50", VA = "0x180629B50")]
	public void FindPrints()
	{
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAC")]
	[Address(RVA = "0x629BE0", Offset = "0x628BE0", VA = "0x180629BE0")]
	public void PoliceCall(int passedVar)
	{
	}

	// Token: 0x06000EAD RID: 3757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAD")]
	[Address(RVA = "0x62A0E0", Offset = "0x6290E0", VA = "0x18062A0E0")]
	private void StealthTutorial()
	{
	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAE")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	private void TriggerEscapeEvents()
	{
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAF")]
	[Address(RVA = "0x62A170", Offset = "0x629170", VA = "0x18062A170")]
	public void CollectHandIn(int passedVar)
	{
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB0")]
	[Address(RVA = "0x62A550", Offset = "0x629550", VA = "0x18062A550")]
	public void ViewHandIn(int passedVar)
	{
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB1")]
	[Address(RVA = "0x62A730", Offset = "0x629730", VA = "0x18062A730")]
	public void ViewedHandIn(int passedVar)
	{
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0x62AA00", Offset = "0x629A00", VA = "0x18062AA00")]
	public void DisplayLeads(int passedVar)
	{
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0x62ABF0", Offset = "0x629BF0", VA = "0x18062ABF0")]
	public void ExecuteChangeLeadsManual()
	{
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB4")]
	[Address(RVA = "0x62B180", Offset = "0x62A180", VA = "0x18062B180")]
	public void ClearLeads(bool clearDiner, bool clearOffice, bool clearPhone, bool clearWeaponsDealer)
	{
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB5")]
	[Address(RVA = "0x62B570", Offset = "0x62A570", VA = "0x18062B570")]
	public void InvestigateCCTV(int passedVar)
	{
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB6")]
	[Address(RVA = "0x62B970", Offset = "0x62A970", VA = "0x18062B970")]
	public void InvestigateVmails(int passedVar)
	{
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB7")]
	[Address(RVA = "0x62BD70", Offset = "0x62AD70", VA = "0x18062BD70")]
	public void InvesitgatePhone(int passedVar)
	{
	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB8")]
	[Address(RVA = "0x62BFE0", Offset = "0x62AFE0", VA = "0x18062BFE0")]
	public void InvestigateMurderWeapon(int passedVar)
	{
	}

	// Token: 0x06000EB9 RID: 3769 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB9")]
	[Address(RVA = "0x62C540", Offset = "0x62B540", VA = "0x18062C540")]
	public void ArrivalDiner(int passedVar)
	{
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBA")]
	[Address(RVA = "0x62CFC0", Offset = "0x62BFC0", VA = "0x18062CFC0")]
	private void BreakerBox()
	{
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBB")]
	[Address(RVA = "0x62D1D0", Offset = "0x62C1D0", VA = "0x18062D1D0")]
	private void BreakerTip()
	{
	}

	// Token: 0x06000EBC RID: 3772 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0x62D250", Offset = "0x62C250", VA = "0x18062D250")]
	public void AccessBackroom(int passedVar)
	{
	}

	// Token: 0x06000EBD RID: 3773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBD")]
	[Address(RVA = "0x62D550", Offset = "0x62C550", VA = "0x18062D550")]
	public void LaunchSurveillance(int passedVar)
	{
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBE")]
	[Address(RVA = "0x62D790", Offset = "0x62C790", VA = "0x18062D790")]
	public void FoundRecords(int passedVar)
	{
	}

	// Token: 0x06000EBF RID: 3775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBF")]
	[Address(RVA = "0x62DBB0", Offset = "0x62CBB0", VA = "0x18062DBB0")]
	private void UpdateCamReferences()
	{
	}

	// Token: 0x06000EC0 RID: 3776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC0")]
	[Address(RVA = "0x62E110", Offset = "0x62D110", VA = "0x18062E110")]
	public void KidnapperOnCam(int passedVar)
	{
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC1")]
	[Address(RVA = "0x62E390", Offset = "0x62D390", VA = "0x18062E390")]
	public void OpenNotewirterEvidence(int passedVar)
	{
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC2")]
	[Address(RVA = "0x62E740", Offset = "0x62D740", VA = "0x18062E740")]
	public void FindFlyer(int passedVar)
	{
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC3")]
	[Address(RVA = "0x62E810", Offset = "0x62D810", VA = "0x18062E810")]
	public void ArrivalWorkplace(int passedVar)
	{
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC4")]
	[Address(RVA = "0x62FA00", Offset = "0x62EA00", VA = "0x18062FA00")]
	private void BreakerBoxWorkplace()
	{
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC5")]
	[Address(RVA = "0x62FC30", Offset = "0x62EC30", VA = "0x18062FC30")]
	private void ComputerTutorial()
	{
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC6")]
	[Address(RVA = "0x62FCC0", Offset = "0x62ECC0", VA = "0x18062FCC0")]
	public void LaunchVmail(int passedVar)
	{
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC7")]
	[Address(RVA = "0x6300C0", Offset = "0x62F0C0", VA = "0x1806300C0")]
	public void AccessKidnapperCruncher(int passedVar)
	{
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC8")]
	[Address(RVA = "0x6305D0", Offset = "0x62F5D0", VA = "0x1806305D0")]
	public void FoundNotewriterID(int passedVar)
	{
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EC9")]
	[Address(RVA = "0x630870", Offset = "0x62F870", VA = "0x180630870")]
	public void WarnNotewriter()
	{
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ECA")]
	[Address(RVA = "0x630D10", Offset = "0x62FD10", VA = "0x180630D10")]
	public void AccessCabinet(int passedVar)
	{
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ECB")]
	[Address(RVA = "0x631150", Offset = "0x630150", VA = "0x180631150")]
	public void TraceCall(int passedVar)
	{
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ECC")]
	[Address(RVA = "0x6313F0", Offset = "0x6303F0", VA = "0x1806313F0")]
	public void SearchCallSource(int passedVar)
	{
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ECD")]
	[Address(RVA = "0x632060", Offset = "0x631060", VA = "0x180632060")]
	public void AccessOtherAddress(int passedVar)
	{
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ECE")]
	[Address(RVA = "0x6322B0", Offset = "0x6312B0", VA = "0x1806322B0")]
	public void SearchOtherAddress(int passedVar)
	{
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ECF")]
	[Address(RVA = "0x6324D0", Offset = "0x6314D0", VA = "0x1806324D0")]
	public void SearchFail(int passedVar)
	{
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED0")]
	[Address(RVA = "0x632800", Offset = "0x631800", VA = "0x180632800")]
	private void DudLead()
	{
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED1")]
	[Address(RVA = "0x632920", Offset = "0x631920", VA = "0x180632920")]
	public void SearchWeaponsDealer(int passedVar)
	{
	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED2")]
	[Address(RVA = "0x632CF0", Offset = "0x631CF0", VA = "0x180632CF0")]
	public void FoundKillerID(int passedVar)
	{
	}

	// Token: 0x06000ED3 RID: 3795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED3")]
	[Address(RVA = "0x6330D0", Offset = "0x6320D0", VA = "0x1806330D0")]
	public void ProveKiller(int passedVar)
	{
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED4")]
	[Address(RVA = "0x6334C0", Offset = "0x6324C0", VA = "0x1806334C0")]
	public void ReturnHome(int passedVar)
	{
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED5")]
	[Address(RVA = "0x633E30", Offset = "0x632E30", VA = "0x180633E30")]
	public void VistSlophouseOwner(int passedVar)
	{
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED6")]
	[Address(RVA = "0x634940", Offset = "0x633940", VA = "0x180634940")]
	private void NobodyHome()
	{
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED7")]
	[Address(RVA = "0x634AD0", Offset = "0x633AD0", VA = "0x180634AD0")]
	public void GoToSlophouse(int passedVar)
	{
	}

	// Token: 0x06000ED8 RID: 3800 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED8")]
	[Address(RVA = "0x636090", Offset = "0x635090", VA = "0x180636090")]
	public void ArrivedAtSlophouse(int passedVar)
	{
	}

	// Token: 0x06000ED9 RID: 3801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CancelLeads(int passedVar)
	{
	}

	// Token: 0x06000EDA RID: 3802 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDA")]
	[Address(RVA = "0x636870", Offset = "0x635870", VA = "0x180636870")]
	public void End(int passedVar)
	{
	}

	// Token: 0x06000EDB RID: 3803 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDB")]
	[Address(RVA = "0x637BE0", Offset = "0x636BE0", VA = "0x180637BE0")]
	public void NotewriterLayLow()
	{
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDC")]
	[Address(RVA = "0x637FC0", Offset = "0x636FC0", VA = "0x180637FC0")]
	private void NotewritersLeads()
	{
	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDD")]
	[Address(RVA = "0x638D10", Offset = "0x637D10", VA = "0x180638D10")]
	public void ManualTriggerNotewriterMurder()
	{
	}

	// Token: 0x06000EDE RID: 3806 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDE")]
	[Address(RVA = "0x638D20", Offset = "0x637D20", VA = "0x180638D20")]
	public void SkipPreSim()
	{
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDF")]
	[Address(RVA = "0x638D30", Offset = "0x637D30", VA = "0x180638D30")]
	public void TriggerNotewriterLeads()
	{
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EE0")]
	[Address(RVA = "0x638D40", Offset = "0x637D40", VA = "0x180638D40")]
	public ChapterIntro()
	{
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x00007860 File Offset: 0x00005A60
	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0x638F80", Offset = "0x637F80", VA = "0x180638F80")]
	private bool <OnGameWorldLoop>b__153_2(Interactable.DynamicFingerprint item)
	{
		return default(bool);
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00007878 File Offset: 0x00005A78
	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0x638F80", Offset = "0x637F80", VA = "0x180638F80")]
	private bool <OnGameWorldLoop>b__153_4(Interactable.DynamicFingerprint item)
	{
		return default(bool);
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x00007890 File Offset: 0x00005A90
	[Token(Token = "0x6000EE3")]
	[Address(RVA = "0x638FB0", Offset = "0x637FB0", VA = "0x180638FB0")]
	private bool <PickCharacters>b__165_3(Citizen item)
	{
		return default(bool);
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x000078A8 File Offset: 0x00005AA8
	[Token(Token = "0x6000EE4")]
	[Address(RVA = "0x639780", Offset = "0x638780", VA = "0x180639780")]
	private bool <OpenName>b__172_0(InfoWindow item)
	{
		return default(bool);
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x000078C0 File Offset: 0x00005AC0
	[Token(Token = "0x6000EE5")]
	[Address(RVA = "0x639780", Offset = "0x638780", VA = "0x180639780")]
	private bool <PinCitizen>b__173_0(InfoWindow item)
	{
		return default(bool);
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x000078D8 File Offset: 0x00005AD8
	[Token(Token = "0x6000EE6")]
	[Address(RVA = "0x6397C0", Offset = "0x6387C0", VA = "0x1806397C0")]
	private bool <PinCitizen>b__173_1(InfoWindow item)
	{
		return default(bool);
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x000078F0 File Offset: 0x00005AF0
	[Token(Token = "0x6000EE7")]
	[Address(RVA = "0x639780", Offset = "0x638780", VA = "0x180639780")]
	private bool <PinNote>b__174_0(InfoWindow item)
	{
		return default(bool);
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x00007908 File Offset: 0x00005B08
	[Token(Token = "0x6000EE8")]
	[Address(RVA = "0x6397F0", Offset = "0x6387F0", VA = "0x1806397F0")]
	private bool <PinAddress>b__178_0(InfoWindow item)
	{
		return default(bool);
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x00007920 File Offset: 0x00005B20
	[Token(Token = "0x6000EE9")]
	[Address(RVA = "0x6397F0", Offset = "0x6387F0", VA = "0x1806397F0")]
	private bool <SetRoute>b__185_0(InfoWindow item)
	{
		return default(bool);
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00007938 File Offset: 0x00005B38
	[Token(Token = "0x6000EEA")]
	[Address(RVA = "0x638F80", Offset = "0x637F80", VA = "0x180638F80")]
	private bool <CrimeSceneClues>b__194_2(Interactable.DynamicFingerprint item)
	{
		return default(bool);
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00007950 File Offset: 0x00005B50
	[Token(Token = "0x6000EEB")]
	[Address(RVA = "0x638F80", Offset = "0x637F80", VA = "0x180638F80")]
	private bool <CrimeSceneClues>b__194_3(Interactable.DynamicFingerprint item)
	{
		return default(bool);
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x00007968 File Offset: 0x00005B68
	[Token(Token = "0x6000EEC")]
	[Address(RVA = "0x639830", Offset = "0x638830", VA = "0x180639830")]
	private bool <UpdateCamReferences>b__223_0(SceneRecorder.ActorCapture item)
	{
		return default(bool);
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x00007980 File Offset: 0x00005B80
	[Token(Token = "0x6000EED")]
	[Address(RVA = "0x639860", Offset = "0x638860", VA = "0x180639860")]
	private bool <UpdateCamReferences>b__223_1(SceneRecorder.ActorCapture item)
	{
		return default(bool);
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x00007998 File Offset: 0x00005B98
	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0x639890", Offset = "0x638890", VA = "0x180639890")]
	private bool <ArrivalWorkplace>b__227_1(EvidenceMultiPage.MultiPageContent item)
	{
		return default(bool);
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x000079B0 File Offset: 0x00005BB0
	[Token(Token = "0x6000EEF")]
	[Address(RVA = "0x639950", Offset = "0x638950", VA = "0x180639950")]
	private bool <SearchCallSource>b__236_0(TelephoneController.PhoneCall item)
	{
		return default(bool);
	}

	// Token: 0x04001094 RID: 4244
	[Token(Token = "0x4001094")]
	[FieldOffset(Offset = "0x58")]
	public Human noteWriter;

	// Token: 0x04001095 RID: 4245
	[Token(Token = "0x4001095")]
	[FieldOffset(Offset = "0x60")]
	public Human kidnapper;

	// Token: 0x04001096 RID: 4246
	[Token(Token = "0x4001096")]
	[FieldOffset(Offset = "0x68")]
	public Human killer;

	// Token: 0x04001097 RID: 4247
	[Token(Token = "0x4001097")]
	[FieldOffset(Offset = "0x70")]
	public Human slophouseOwner;

	// Token: 0x04001098 RID: 4248
	[Token(Token = "0x4001098")]
	[FieldOffset(Offset = "0x78")]
	private GroupsController.SocialGroup meetGroup;

	// Token: 0x04001099 RID: 4249
	[Token(Token = "0x4001099")]
	[FieldOffset(Offset = "0x80")]
	private NewAIGoal meetFoodNotewriter;

	// Token: 0x0400109A RID: 4250
	[Token(Token = "0x400109A")]
	[FieldOffset(Offset = "0x88")]
	private NewAIGoal meetFoodKidnapper;

	// Token: 0x0400109B RID: 4251
	[Token(Token = "0x400109B")]
	[FieldOffset(Offset = "0x90")]
	private NewAIGoal postNote;

	// Token: 0x0400109C RID: 4252
	[Token(Token = "0x400109C")]
	[FieldOffset(Offset = "0x98")]
	private NewAIGoal kidnapperGoHome;

	// Token: 0x0400109D RID: 4253
	[Token(Token = "0x400109D")]
	[FieldOffset(Offset = "0xA0")]
	private NewAIGoal kidnapperRunAway;

	// Token: 0x0400109E RID: 4254
	[Token(Token = "0x400109E")]
	[FieldOffset(Offset = "0xA8")]
	private NewAIGoal returnToApartment;

	// Token: 0x0400109F RID: 4255
	[Token(Token = "0x400109F")]
	[FieldOffset(Offset = "0xB0")]
	private MurderController.Murder murder;

	// Token: 0x040010A0 RID: 4256
	[Token(Token = "0x40010A0")]
	[FieldOffset(Offset = "0xB8")]
	private MurderController.Murder murder2;

	// Token: 0x040010A1 RID: 4257
	[Token(Token = "0x40010A1")]
	[FieldOffset(Offset = "0xC0")]
	private bool handlePreSim;

	// Token: 0x040010A2 RID: 4258
	[Token(Token = "0x40010A2")]
	[FieldOffset(Offset = "0xC1")]
	private bool murderPreSimPass;

	// Token: 0x040010A3 RID: 4259
	[Token(Token = "0x40010A3")]
	[FieldOffset(Offset = "0xC4")]
	public int preSimPhase;

	// Token: 0x040010A4 RID: 4260
	[Token(Token = "0x40010A4")]
	[FieldOffset(Offset = "0xC8")]
	public float timeSinceCallObjective;

	// Token: 0x040010A5 RID: 4261
	[Token(Token = "0x40010A5")]
	[FieldOffset(Offset = "0xCC")]
	public int noteWriterID;

	// Token: 0x040010A6 RID: 4262
	[Token(Token = "0x40010A6")]
	[FieldOffset(Offset = "0xD0")]
	public int kidnapperID;

	// Token: 0x040010A7 RID: 4263
	[Token(Token = "0x40010A7")]
	[FieldOffset(Offset = "0xD4")]
	public int killerID;

	// Token: 0x040010A8 RID: 4264
	[Token(Token = "0x40010A8")]
	[FieldOffset(Offset = "0xD8")]
	public int playersAparment;

	// Token: 0x040010A9 RID: 4265
	[Token(Token = "0x40010A9")]
	[FieldOffset(Offset = "0xDC")]
	public int eatery;

	// Token: 0x040010AA RID: 4266
	[Token(Token = "0x40010AA")]
	[FieldOffset(Offset = "0xE0")]
	public int slopHouseOwnerID;

	// Token: 0x040010AB RID: 4267
	[Token(Token = "0x40010AB")]
	[FieldOffset(Offset = "0xE4")]
	public int slopHouseID;

	// Token: 0x040010AC RID: 4268
	[Token(Token = "0x40010AC")]
	[FieldOffset(Offset = "0xE8")]
	public int addressBookID;

	// Token: 0x040010AD RID: 4269
	[Token(Token = "0x40010AD")]
	[FieldOffset(Offset = "0xEC")]
	public float meetTime;

	// Token: 0x040010AE RID: 4270
	[Token(Token = "0x40010AE")]
	[FieldOffset(Offset = "0xF0")]
	public bool enforcerEventsTrigger;

	// Token: 0x040010AF RID: 4271
	[Token(Token = "0x40010AF")]
	[FieldOffset(Offset = "0xF1")]
	public bool findNotewriter;

	// Token: 0x040010B0 RID: 4272
	[Token(Token = "0x40010B0")]
	[FieldOffset(Offset = "0xF2")]
	public bool notewriterDialogAdded;

	// Token: 0x040010B1 RID: 4273
	[Token(Token = "0x40010B1")]
	[FieldOffset(Offset = "0xF3")]
	public bool lastCallPlaced;

	// Token: 0x040010B2 RID: 4274
	[Token(Token = "0x40010B2")]
	[FieldOffset(Offset = "0xF4")]
	public float notewriterMurderTimer;

	// Token: 0x040010B3 RID: 4275
	[Token(Token = "0x40010B3")]
	[FieldOffset(Offset = "0xF8")]
	public bool notewriterManualMurderTrigger;

	// Token: 0x040010B4 RID: 4276
	[Token(Token = "0x40010B4")]
	[FieldOffset(Offset = "0xF9")]
	public bool notewriterMurderTriggered;

	// Token: 0x040010B5 RID: 4277
	[Token(Token = "0x40010B5")]
	[FieldOffset(Offset = "0xFA")]
	public bool receiptSearchPromt;

	// Token: 0x040010B6 RID: 4278
	[Token(Token = "0x40010B6")]
	[FieldOffset(Offset = "0xFB")]
	public bool addressBookSearchPrompt;

	// Token: 0x040010B7 RID: 4279
	[Token(Token = "0x40010B7")]
	[FieldOffset(Offset = "0xFC")]
	public bool fingerprintPrompt;

	// Token: 0x040010B8 RID: 4280
	[Token(Token = "0x40010B8")]
	[FieldOffset(Offset = "0x100")]
	public float receiptSearchTimer;

	// Token: 0x040010B9 RID: 4281
	[Token(Token = "0x40010B9")]
	[FieldOffset(Offset = "0x104")]
	public float addressBookSearchTimer;

	// Token: 0x040010BA RID: 4282
	[Token(Token = "0x40010BA")]
	[FieldOffset(Offset = "0x108")]
	public float printSearchTimer;

	// Token: 0x040010BB RID: 4283
	[Token(Token = "0x40010BB")]
	[FieldOffset(Offset = "0x10C")]
	public bool receiptSearchActivated;

	// Token: 0x040010BC RID: 4284
	[Token(Token = "0x40010BC")]
	[FieldOffset(Offset = "0x10D")]
	public bool addressBookSearchActivated;

	// Token: 0x040010BD RID: 4285
	[Token(Token = "0x40010BD")]
	[FieldOffset(Offset = "0x10E")]
	public bool printSearchActivated;

	// Token: 0x040010BE RID: 4286
	[Token(Token = "0x40010BE")]
	[FieldOffset(Offset = "0x110")]
	public int killerBarID;

	// Token: 0x040010BF RID: 4287
	[Token(Token = "0x40010BF")]
	[FieldOffset(Offset = "0x114")]
	public int redGumMeetID;

	// Token: 0x040010C0 RID: 4288
	[Token(Token = "0x40010C0")]
	[FieldOffset(Offset = "0x118")]
	public int chosenRouterAddressID;

	// Token: 0x040010C1 RID: 4289
	[Token(Token = "0x40010C1")]
	[FieldOffset(Offset = "0x11C")]
	public int weaponSellerID;

	// Token: 0x040010C2 RID: 4290
	[Token(Token = "0x40010C2")]
	[FieldOffset(Offset = "0x120")]
	public bool discoveredWeaponsDealer;

	// Token: 0x040010C3 RID: 4291
	[Token(Token = "0x40010C3")]
	[FieldOffset(Offset = "0x121")]
	public bool completed;

	// Token: 0x040010C4 RID: 4292
	[Token(Token = "0x40010C4")]
	[FieldOffset(Offset = "0x128")]
	public NewAddress apartment;

	// Token: 0x040010C5 RID: 4293
	[Token(Token = "0x40010C5")]
	[FieldOffset(Offset = "0x130")]
	private NewRoom playerBedroom;

	// Token: 0x040010C6 RID: 4294
	[Token(Token = "0x40010C6")]
	[FieldOffset(Offset = "0x138")]
	private NewRoom playerLounge;

	// Token: 0x040010C7 RID: 4295
	[Token(Token = "0x40010C7")]
	[FieldOffset(Offset = "0x140")]
	private NewRoom playerKitchen;

	// Token: 0x040010C8 RID: 4296
	[Token(Token = "0x40010C8")]
	[FieldOffset(Offset = "0x148")]
	private NewRoom kidnappersBedroom;

	// Token: 0x040010C9 RID: 4297
	[Token(Token = "0x40010C9")]
	[FieldOffset(Offset = "0x150")]
	private NewRoom noteWritersBedroom;

	// Token: 0x040010CA RID: 4298
	[Token(Token = "0x40010CA")]
	[FieldOffset(Offset = "0x158")]
	public NewAddress restaurant;

	// Token: 0x040010CB RID: 4299
	[Token(Token = "0x40010CB")]
	[FieldOffset(Offset = "0x160")]
	private NewRoom restaurantBackroom;

	// Token: 0x040010CC RID: 4300
	[Token(Token = "0x40010CC")]
	[FieldOffset(Offset = "0x168")]
	public NewAddress killerBar;

	// Token: 0x040010CD RID: 4301
	[Token(Token = "0x40010CD")]
	[FieldOffset(Offset = "0x170")]
	public NewAddress redGumMeet;

	// Token: 0x040010CE RID: 4302
	[Token(Token = "0x40010CE")]
	[FieldOffset(Offset = "0x178")]
	public NewAddress chosenRouterAddress;

	// Token: 0x040010CF RID: 4303
	[Token(Token = "0x40010CF")]
	[FieldOffset(Offset = "0x180")]
	public NewAddress weaponSeller;

	// Token: 0x040010D0 RID: 4304
	[Token(Token = "0x40010D0")]
	[FieldOffset(Offset = "0x188")]
	public NewAddress slophouse;

	// Token: 0x040010D1 RID: 4305
	[Token(Token = "0x40010D1")]
	[FieldOffset(Offset = "0x190")]
	private Interactable note;

	// Token: 0x040010D2 RID: 4306
	[Token(Token = "0x40010D2")]
	[FieldOffset(Offset = "0x198")]
	private Interactable key;

	// Token: 0x040010D3 RID: 4307
	[Token(Token = "0x40010D3")]
	[FieldOffset(Offset = "0x1A0")]
	private Interactable detectiveStuff;

	// Token: 0x040010D4 RID: 4308
	[Token(Token = "0x40010D4")]
	[FieldOffset(Offset = "0x1A8")]
	private Interactable policeBadge;

	// Token: 0x040010D5 RID: 4309
	[Token(Token = "0x40010D5")]
	[FieldOffset(Offset = "0x1B0")]
	private Interactable hairpin;

	// Token: 0x040010D6 RID: 4310
	[Token(Token = "0x40010D6")]
	[FieldOffset(Offset = "0x1B8")]
	private Interactable paperclip;

	// Token: 0x040010D7 RID: 4311
	[Token(Token = "0x40010D7")]
	[FieldOffset(Offset = "0x1C0")]
	private Interactable spareKeyDoormat;

	// Token: 0x040010D8 RID: 4312
	[Token(Token = "0x40010D8")]
	[FieldOffset(Offset = "0x1C8")]
	private Interactable workID;

	// Token: 0x040010D9 RID: 4313
	[Token(Token = "0x40010D9")]
	[FieldOffset(Offset = "0x1D0")]
	private Interactable safePasscode;

	// Token: 0x040010DA RID: 4314
	[Token(Token = "0x40010DA")]
	[FieldOffset(Offset = "0x1D8")]
	private Interactable rewardSyncDisk;

	// Token: 0x040010DB RID: 4315
	[Token(Token = "0x40010DB")]
	[FieldOffset(Offset = "0x1E0")]
	[NonSerialized]
	public Interactable murderWeapon;

	// Token: 0x040010DC RID: 4316
	[Token(Token = "0x40010DC")]
	[FieldOffset(Offset = "0x1E8")]
	private Interactable kidnapperDiary;

	// Token: 0x040010DD RID: 4317
	[Token(Token = "0x40010DD")]
	[FieldOffset(Offset = "0x1F0")]
	private Interactable envelopeWithCredits;

	// Token: 0x040010DE RID: 4318
	[Token(Token = "0x40010DE")]
	[FieldOffset(Offset = "0x1F8")]
	private Interactable corpLetter;

	// Token: 0x040010DF RID: 4319
	[Token(Token = "0x40010DF")]
	[FieldOffset(Offset = "0x200")]
	private Interactable crumpledFlyer;

	// Token: 0x040010E0 RID: 4320
	[Token(Token = "0x40010E0")]
	[FieldOffset(Offset = "0x208")]
	private Interactable printedVmail;

	// Token: 0x040010E1 RID: 4321
	[Token(Token = "0x40010E1")]
	[FieldOffset(Offset = "0x210")]
	private Interactable meetingNote;

	// Token: 0x040010E2 RID: 4322
	[Token(Token = "0x40010E2")]
	[FieldOffset(Offset = "0x218")]
	private Interactable noteOnNapkin;

	// Token: 0x040010E3 RID: 4323
	[Token(Token = "0x40010E3")]
	[FieldOffset(Offset = "0x220")]
	private Interactable tornPhotograph;

	// Token: 0x040010E4 RID: 4324
	[Token(Token = "0x40010E4")]
	[FieldOffset(Offset = "0x228")]
	private Interactable travelreceipt;

	// Token: 0x040010E5 RID: 4325
	[Token(Token = "0x40010E5")]
	[FieldOffset(Offset = "0x230")]
	private List<Interactable> playerApartmentLockpicks;

	// Token: 0x040010E6 RID: 4326
	[Token(Token = "0x40010E6")]
	[FieldOffset(Offset = "0x238")]
	[NonSerialized]
	public Evidence restaurantReceipt;

	// Token: 0x040010E7 RID: 4327
	[Token(Token = "0x40010E7")]
	[FieldOffset(Offset = "0x240")]
	public bool receiptInBin;

	// Token: 0x040010E8 RID: 4328
	[Token(Token = "0x40010E8")]
	[FieldOffset(Offset = "0x248")]
	private Interactable noteWriterDiary;

	// Token: 0x040010E9 RID: 4329
	[Token(Token = "0x40010E9")]
	[FieldOffset(Offset = "0x250")]
	public Interactable playersStorageBox;

	// Token: 0x040010EA RID: 4330
	[Token(Token = "0x40010EA")]
	[FieldOffset(Offset = "0x258")]
	private Interactable policeCertificate;

	// Token: 0x040010EB RID: 4331
	[Token(Token = "0x40010EB")]
	[FieldOffset(Offset = "0x260")]
	private Interactable fieldsAdvert;

	// Token: 0x040010EC RID: 4332
	[Token(Token = "0x40010EC")]
	[FieldOffset(Offset = "0x268")]
	private Interactable scientificPaper;

	// Token: 0x040010ED RID: 4333
	[Token(Token = "0x40010ED")]
	[FieldOffset(Offset = "0x270")]
	private Interactable playersPasscodeReminder;

	// Token: 0x040010EE RID: 4334
	[Token(Token = "0x40010EE")]
	[FieldOffset(Offset = "0x278")]
	private Interactable killerPropaganda;

	// Token: 0x040010EF RID: 4335
	[Token(Token = "0x40010EF")]
	[FieldOffset(Offset = "0x280")]
	private Interactable killerNotewriterDetails;

	// Token: 0x040010F0 RID: 4336
	[Token(Token = "0x40010F0")]
	[FieldOffset(Offset = "0x288")]
	private Interactable killerPoliceFines;

	// Token: 0x040010F1 RID: 4337
	[Token(Token = "0x40010F1")]
	[FieldOffset(Offset = "0x290")]
	private Interactable killerBusinessCard;

	// Token: 0x040010F2 RID: 4338
	[Token(Token = "0x40010F2")]
	[FieldOffset(Offset = "0x298")]
	private Interactable killerCorpSponsorship;

	// Token: 0x040010F3 RID: 4339
	[Token(Token = "0x40010F3")]
	[FieldOffset(Offset = "0x2A0")]
	private Interactable killerBarTab;

	// Token: 0x040010F4 RID: 4340
	[Token(Token = "0x40010F4")]
	[FieldOffset(Offset = "0x2A8")]
	private Interactable robItem;

	// Token: 0x040010F5 RID: 4341
	[Token(Token = "0x40010F5")]
	[FieldOffset(Offset = "0x2B0")]
	private Interactable workplaceReceipt;

	// Token: 0x040010F6 RID: 4342
	[Token(Token = "0x40010F6")]
	[FieldOffset(Offset = "0x2B8")]
	private Interactable workplaceMessageNote;

	// Token: 0x040010F7 RID: 4343
	[Token(Token = "0x40010F7")]
	[FieldOffset(Offset = "0x2C0")]
	private Interactable dinerFlyer;

	// Token: 0x040010F8 RID: 4344
	[Token(Token = "0x40010F8")]
	[FieldOffset(Offset = "0x2C8")]
	private Interactable finalNoticeBill;

	// Token: 0x040010F9 RID: 4345
	[Token(Token = "0x40010F9")]
	[FieldOffset(Offset = "0x2D0")]
	private Interactable evictionNotice;

	// Token: 0x040010FA RID: 4346
	[Token(Token = "0x40010FA")]
	[FieldOffset(Offset = "0x2D8")]
	private Interactable flophouseWelcomeLetter;

	// Token: 0x040010FB RID: 4347
	[Token(Token = "0x40010FB")]
	[FieldOffset(Offset = "0x2E0")]
	private Interactable flophouseSyncDiskNote;

	// Token: 0x040010FC RID: 4348
	[Token(Token = "0x40010FC")]
	[FieldOffset(Offset = "0x2E8")]
	private Interactable flophouseJobNote;

	// Token: 0x040010FD RID: 4349
	[Token(Token = "0x40010FD")]
	[FieldOffset(Offset = "0x2F0")]
	private Interactable flophouseSyncDisk;

	// Token: 0x040010FE RID: 4350
	[Token(Token = "0x40010FE")]
	[FieldOffset(Offset = "0x2F8")]
	private FurnitureLocation kidnappersSafe;

	// Token: 0x040010FF RID: 4351
	[Token(Token = "0x40010FF")]
	[FieldOffset(Offset = "0x300")]
	private FurnitureLocation bed;

	// Token: 0x04001100 RID: 4352
	[Token(Token = "0x4001100")]
	[FieldOffset(Offset = "0x308")]
	private Interactable closestSleep;

	// Token: 0x04001101 RID: 4353
	[Token(Token = "0x4001101")]
	[FieldOffset(Offset = "0x310")]
	private Interactable closestLight;

	// Token: 0x04001102 RID: 4354
	[Token(Token = "0x4001102")]
	[FieldOffset(Offset = "0x318")]
	private NewNode.NodeAccess apartmentEntrance;

	// Token: 0x04001103 RID: 4355
	[Token(Token = "0x4001103")]
	[FieldOffset(Offset = "0x320")]
	private NewNode interiorDoorNode;

	// Token: 0x04001104 RID: 4356
	[Token(Token = "0x4001104")]
	[FieldOffset(Offset = "0x328")]
	private NewNode exteriorDoorNode;

	// Token: 0x04001105 RID: 4357
	[Token(Token = "0x4001105")]
	[FieldOffset(Offset = "0x330")]
	private Interactable playerCalendar;

	// Token: 0x04001106 RID: 4358
	[Token(Token = "0x4001106")]
	[FieldOffset(Offset = "0x338")]
	private Interactable cityDir;

	// Token: 0x04001107 RID: 4359
	[Token(Token = "0x4001107")]
	[FieldOffset(Offset = "0x340")]
	private FurnitureLocation noteWritersBed;

	// Token: 0x04001108 RID: 4360
	[Token(Token = "0x4001108")]
	[FieldOffset(Offset = "0x348")]
	private Interactable dinerCruncher;

	// Token: 0x04001109 RID: 4361
	[Token(Token = "0x4001109")]
	[FieldOffset(Offset = "0x350")]
	private NewNode.NodeAccess kidnappersEntrance;

	// Token: 0x0400110A RID: 4362
	[Token(Token = "0x400110A")]
	[FieldOffset(Offset = "0x358")]
	private NewNode kidnappersDoorNode;

	// Token: 0x0400110B RID: 4363
	[Token(Token = "0x400110B")]
	[FieldOffset(Offset = "0x360")]
	private NewDoor kidnappersDoor;

	// Token: 0x0400110C RID: 4364
	[Token(Token = "0x400110C")]
	[FieldOffset(Offset = "0x368")]
	private Interactable kidnappersCalendar;

	// Token: 0x0400110D RID: 4365
	[Token(Token = "0x400110D")]
	[FieldOffset(Offset = "0x370")]
	private Interactable kidnappersAddressBook;

	// Token: 0x0400110E RID: 4366
	[Token(Token = "0x400110E")]
	[FieldOffset(Offset = "0x378")]
	private Interactable kidnapperBin;

	// Token: 0x0400110F RID: 4367
	[Token(Token = "0x400110F")]
	[FieldOffset(Offset = "0x380")]
	private Interactable kidnapperPhone;

	// Token: 0x04001110 RID: 4368
	[Token(Token = "0x4001110")]
	[FieldOffset(Offset = "0x388")]
	private Interactable weaponsSalesLedger;

	// Token: 0x04001111 RID: 4369
	[Token(Token = "0x4001111")]
	[FieldOffset(Offset = "0x390")]
	private Interactable kidnapperRouter;

	// Token: 0x04001112 RID: 4370
	[Token(Token = "0x4001112")]
	[FieldOffset(Offset = "0x398")]
	private Interactable kidnapperRouterDoor;

	// Token: 0x04001113 RID: 4371
	[Token(Token = "0x4001113")]
	[FieldOffset(Offset = "0x3A0")]
	private EvidenceTime meetingTimeEvidence;

	// Token: 0x04001114 RID: 4372
	[Token(Token = "0x4001114")]
	[FieldOffset(Offset = "0x3A8")]
	[NonSerialized]
	public NewAIGoal layLowGoal;

	// Token: 0x04001115 RID: 4373
	[Token(Token = "0x4001115")]
	[FieldOffset(Offset = "0x3B0")]
	private RectTransform pointer;

	// Token: 0x04001116 RID: 4374
	[Token(Token = "0x4001116")]
	[FieldOffset(Offset = "0x3B8")]
	private PulseGlowController glow;

	// Token: 0x04001117 RID: 4375
	[Token(Token = "0x4001117")]
	[FieldOffset(Offset = "0x3C0")]
	private float nextLeadDelay;

	// Token: 0x04001118 RID: 4376
	[Token(Token = "0x4001118")]
	[FieldOffset(Offset = "0x3C4")]
	private bool notewriterOnCam;

	// Token: 0x04001119 RID: 4377
	[Token(Token = "0x4001119")]
	[FieldOffset(Offset = "0x3C5")]
	private bool kidnapperOnCam;

	// Token: 0x0400111A RID: 4378
	[Token(Token = "0x400111A")]
	[FieldOffset(Offset = "0x3C8")]
	public int lockpicksNeeded;

	// Token: 0x0400111B RID: 4379
	[Token(Token = "0x400111B")]
	[FieldOffset(Offset = "0x3CC")]
	private float endDelayTimer;

	// Token: 0x0400111C RID: 4380
	[Token(Token = "0x400111C")]
	[FieldOffset(Offset = "0x3D0")]
	private float passcodeNoteTimer;

	// Token: 0x0400111D RID: 4381
	[Token(Token = "0x400111D")]
	[FieldOffset(Offset = "0x3D4")]
	private bool triggeredPasscodeNoteHint;

	// Token: 0x0400111E RID: 4382
	[Token(Token = "0x400111E")]
	[FieldOffset(Offset = "0x3D8")]
	private float triggeredTutorialSkip;

	// Token: 0x0200028B RID: 651
	[Token(Token = "0x200028B")]
	public class IntoCharacterPick
	{
		// Token: 0x06000EF0 RID: 3824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public IntoCharacterPick()
		{
		}

		// Token: 0x0400111F RID: 4383
		[Token(Token = "0x400111F")]
		[FieldOffset(Offset = "0x10")]
		public Human noteWriter;

		// Token: 0x04001120 RID: 4384
		[Token(Token = "0x4001120")]
		[FieldOffset(Offset = "0x18")]
		public Human kidnapper;

		// Token: 0x04001121 RID: 4385
		[Token(Token = "0x4001121")]
		[FieldOffset(Offset = "0x20")]
		public float score;
	}

	// Token: 0x0200028C RID: 652
	[Token(Token = "0x200028C")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000EF2 RID: 3826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x000079C8 File Offset: 0x00005BC8
		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x655E20", Offset = "0x654E20", VA = "0x180655E20")]
		internal bool <SetUpMission>b__142_0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x000079E0 File Offset: 0x00005BE0
		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x655ED0", Offset = "0x654ED0", VA = "0x180655ED0")]
		internal bool <SetUpMission>b__142_1(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x000079F8 File Offset: 0x00005BF8
		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x4E73D0", Offset = "0x4E63D0", VA = "0x1804E73D0")]
		internal bool <SetUpMission>b__142_2(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00007A10 File Offset: 0x00005C10
		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x4E73D0", Offset = "0x4E63D0", VA = "0x1804E73D0")]
		internal bool <SetUpMission>b__142_3(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00007A28 File Offset: 0x00005C28
		[Token(Token = "0x6000EF7")]
		[Address(RVA = "0x655ED0", Offset = "0x654ED0", VA = "0x180655ED0")]
		internal bool <SetUpMission>b__142_4(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00007A40 File Offset: 0x00005C40
		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0x655F80", Offset = "0x654F80", VA = "0x180655F80")]
		internal bool <SetUpMission>b__142_5(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00007A58 File Offset: 0x00005C58
		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x656030", Offset = "0x655030", VA = "0x180656030")]
		internal bool <SpawnMiscClues>b__150_0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00007A70 File Offset: 0x00005C70
		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0x6560D0", Offset = "0x6550D0", VA = "0x1806560D0")]
		internal bool <PreSimHandling>b__152_0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00007A88 File Offset: 0x00005C88
		[Token(Token = "0x6000EFB")]
		[Address(RVA = "0x656240", Offset = "0x655240", VA = "0x180656240")]
		internal bool <PreSimHandling>b__152_1(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00007AA0 File Offset: 0x00005CA0
		[Token(Token = "0x6000EFC")]
		[Address(RVA = "0x6563F0", Offset = "0x6553F0", VA = "0x1806563F0")]
		internal bool <PreSimHandling>b__152_2(FurnitureClass item)
		{
			return default(bool);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00007AB8 File Offset: 0x00005CB8
		[Token(Token = "0x6000EFD")]
		[Address(RVA = "0x656480", Offset = "0x655480", VA = "0x180656480")]
		internal bool <OnGameWorldLoop>b__153_0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00007AD0 File Offset: 0x00005CD0
		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0x656580", Offset = "0x655580", VA = "0x180656580")]
		internal bool <OnGameWorldLoop>b__153_1(InteractableActionsPreset item)
		{
			return default(bool);
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00007AE8 File Offset: 0x00005CE8
		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x656720", Offset = "0x655720", VA = "0x180656720")]
		internal bool <OnGameWorldLoop>b__153_3(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00007B00 File Offset: 0x00005D00
		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x656820", Offset = "0x655820", VA = "0x180656820")]
		internal bool <PickCharacters>b__165_0(Occupation item)
		{
			return default(bool);
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00007B18 File Offset: 0x00005D18
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x6568B0", Offset = "0x6558B0", VA = "0x1806568B0")]
		internal bool <PickCharacters>b__165_4(Company item)
		{
			return default(bool);
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00007B30 File Offset: 0x00005D30
		[Token(Token = "0x6000F02")]
		[Address(RVA = "0x656940", Offset = "0x655940", VA = "0x180656940")]
		internal bool <PickCharacters>b__165_5(Company item)
		{
			return default(bool);
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00007B48 File Offset: 0x00005D48
		[Token(Token = "0x6000F03")]
		[Address(RVA = "0x6569D0", Offset = "0x6559D0", VA = "0x1806569D0")]
		internal bool <PickCharacters>b__165_1(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00007B60 File Offset: 0x00005D60
		[Token(Token = "0x6000F04")]
		[Address(RVA = "0x656A80", Offset = "0x655A80", VA = "0x180656A80")]
		internal bool <PickCharacters>b__165_6(Acquaintance item)
		{
			return default(bool);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00007B78 File Offset: 0x00005D78
		[Token(Token = "0x6000F05")]
		[Address(RVA = "0x656BA0", Offset = "0x655BA0", VA = "0x180656BA0")]
		internal bool <PickCharacters>b__165_7(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00007B90 File Offset: 0x00005D90
		[Token(Token = "0x6000F06")]
		[Address(RVA = "0x656D50", Offset = "0x655D50", VA = "0x180656D50")]
		internal bool <PickCharacters>b__165_9(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00007BA8 File Offset: 0x00005DA8
		[Token(Token = "0x6000F07")]
		[Address(RVA = "0x4E6D90", Offset = "0x4E5D90", VA = "0x1804E6D90")]
		internal int <PickCharacters>b__165_2(ChapterIntro.IntoCharacterPick p1, ChapterIntro.IntoCharacterPick p2)
		{
			return 0;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00007BC0 File Offset: 0x00005DC0
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x656E20", Offset = "0x655E20", VA = "0x180656E20")]
		internal bool <TurnOnLight>b__166_0(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x656EC0", Offset = "0x655EC0", VA = "0x180656EC0")]
		internal bool <RingPhone>b__169_0(Telephone item)
		{
			return default(bool);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00007BF0 File Offset: 0x00005DF0
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x657030", Offset = "0x656030", VA = "0x180657030")]
		internal bool <RingPhone>b__169_1(Telephone item)
		{
			return default(bool);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00007C08 File Offset: 0x00005E08
		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x657070", Offset = "0x656070", VA = "0x180657070")]
		internal bool <AddressLookup>b__177_0(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00007C20 File Offset: 0x00005E20
		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0x657130", Offset = "0x656130", VA = "0x180657130")]
		internal bool <FindNoteWriter>b__188_0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00007C38 File Offset: 0x00005E38
		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0x6571C0", Offset = "0x6561C0", VA = "0x1806571C0")]
		internal bool <FindNoteWriter>b__188_1(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00007C50 File Offset: 0x00005E50
		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x4FE9D0", Offset = "0x4FD9D0", VA = "0x1804FE9D0")]
		internal bool <CrimeSceneClues>b__194_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00007C68 File Offset: 0x00005E68
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x4FE9D0", Offset = "0x4FD9D0", VA = "0x1804FE9D0")]
		internal bool <CrimeSceneClues>b__194_1(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00007C80 File Offset: 0x00005E80
		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x657270", Offset = "0x656270", VA = "0x180657270")]
		internal bool <InvestigateMurderWeapon>b__216_0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00007C98 File Offset: 0x00005E98
		[Token(Token = "0x6000F11")]
		[Address(RVA = "0x6572C0", Offset = "0x6562C0", VA = "0x1806572C0")]
		internal bool <ArrivalDiner>b__217_0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00007CB0 File Offset: 0x00005EB0
		[Token(Token = "0x6000F12")]
		[Address(RVA = "0x657430", Offset = "0x656430", VA = "0x180657430")]
		internal bool <ArrivalWorkplace>b__227_0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00007CC8 File Offset: 0x00005EC8
		[Token(Token = "0x6000F13")]
		[Address(RVA = "0x657490", Offset = "0x656490", VA = "0x180657490")]
		internal bool <LaunchVmail>b__230_0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00007CE0 File Offset: 0x00005EE0
		[Token(Token = "0x6000F14")]
		[Address(RVA = "0x6574F0", Offset = "0x6564F0", VA = "0x1806574F0")]
		internal bool <AccessKidnapperCruncher>b__231_0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00007CF8 File Offset: 0x00005EF8
		[Token(Token = "0x6000F15")]
		[Address(RVA = "0x657540", Offset = "0x656540", VA = "0x180657540")]
		internal bool <FoundNotewriterID>b__232_0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00007D10 File Offset: 0x00005F10
		[Token(Token = "0x6000F16")]
		[Address(RVA = "0x657590", Offset = "0x656590", VA = "0x180657590")]
		internal bool <SearchWeaponsDealer>b__241_0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00007D28 File Offset: 0x00005F28
		[Token(Token = "0x6000F17")]
		[Address(RVA = "0x6575E0", Offset = "0x6565E0", VA = "0x1806575E0")]
		internal bool <FoundKillerID>b__242_0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00007D40 File Offset: 0x00005F40
		[Token(Token = "0x6000F18")]
		[Address(RVA = "0x657630", Offset = "0x656630", VA = "0x180657630")]
		internal bool <ProveKiller>b__243_0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00007D58 File Offset: 0x00005F58
		[Token(Token = "0x6000F19")]
		[Address(RVA = "0x657680", Offset = "0x656680", VA = "0x180657680")]
		internal bool <GoToSlophouse>b__247_0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00007D70 File Offset: 0x00005F70
		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0x6576E0", Offset = "0x6566E0", VA = "0x1806576E0")]
		internal bool <ArrivedAtSlophouse>b__248_0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00007D88 File Offset: 0x00005F88
		[Token(Token = "0x6000F1B")]
		[Address(RVA = "0x657740", Offset = "0x656740", VA = "0x180657740")]
		internal bool <ArrivedAtSlophouse>b__248_1(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00007DA0 File Offset: 0x00005FA0
		[Token(Token = "0x6000F1C")]
		[Address(RVA = "0x6577D0", Offset = "0x6567D0", VA = "0x1806577D0")]
		internal bool <NotewritersLeads>b__252_0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04001122 RID: 4386
		[Token(Token = "0x4001122")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ChapterIntro.<>c <>9;

		// Token: 0x04001123 RID: 4387
		[Token(Token = "0x4001123")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<NewRoom> <>9__142_0;

		// Token: 0x04001124 RID: 4388
		[Token(Token = "0x4001124")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<NewRoom> <>9__142_1;

		// Token: 0x04001125 RID: 4389
		[Token(Token = "0x4001125")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<NewNode.NodeAccess> <>9__142_2;

		// Token: 0x04001126 RID: 4390
		[Token(Token = "0x4001126")]
		[FieldOffset(Offset = "0x20")]
		public static Predicate<NewNode.NodeAccess> <>9__142_3;

		// Token: 0x04001127 RID: 4391
		[Token(Token = "0x4001127")]
		[FieldOffset(Offset = "0x28")]
		public static Predicate<NewRoom> <>9__142_4;

		// Token: 0x04001128 RID: 4392
		[Token(Token = "0x4001128")]
		[FieldOffset(Offset = "0x30")]
		public static Predicate<Interactable> <>9__142_5;

		// Token: 0x04001129 RID: 4393
		[Token(Token = "0x4001129")]
		[FieldOffset(Offset = "0x38")]
		public static Predicate<NewRoom> <>9__150_0;

		// Token: 0x0400112A RID: 4394
		[Token(Token = "0x400112A")]
		[FieldOffset(Offset = "0x40")]
		public static Predicate<NewRoom> <>9__152_0;

		// Token: 0x0400112B RID: 4395
		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0x48")]
		public static Predicate<FurnitureClass> <>9__152_2;

		// Token: 0x0400112C RID: 4396
		[Token(Token = "0x400112C")]
		[FieldOffset(Offset = "0x50")]
		public static Predicate<FurnitureLocation> <>9__152_1;

		// Token: 0x0400112D RID: 4397
		[Token(Token = "0x400112D")]
		[FieldOffset(Offset = "0x58")]
		public static Predicate<Interactable> <>9__153_0;

		// Token: 0x0400112E RID: 4398
		[Token(Token = "0x400112E")]
		[FieldOffset(Offset = "0x60")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__153_3;

		// Token: 0x0400112F RID: 4399
		[Token(Token = "0x400112F")]
		[FieldOffset(Offset = "0x68")]
		public static Predicate<InteractableActionsPreset> <>9__153_1;

		// Token: 0x04001130 RID: 4400
		[Token(Token = "0x4001130")]
		[FieldOffset(Offset = "0x70")]
		public static Predicate<Occupation> <>9__165_0;

		// Token: 0x04001131 RID: 4401
		[Token(Token = "0x4001131")]
		[FieldOffset(Offset = "0x78")]
		public static Predicate<Company> <>9__165_4;

		// Token: 0x04001132 RID: 4402
		[Token(Token = "0x4001132")]
		[FieldOffset(Offset = "0x80")]
		public static Predicate<Company> <>9__165_5;

		// Token: 0x04001133 RID: 4403
		[Token(Token = "0x4001133")]
		[FieldOffset(Offset = "0x88")]
		public static Predicate<Interactable> <>9__165_1;

		// Token: 0x04001134 RID: 4404
		[Token(Token = "0x4001134")]
		[FieldOffset(Offset = "0x90")]
		public static Predicate<Acquaintance> <>9__165_6;

		// Token: 0x04001135 RID: 4405
		[Token(Token = "0x4001135")]
		[FieldOffset(Offset = "0x98")]
		public static Predicate<FurnitureLocation> <>9__165_9;

		// Token: 0x04001136 RID: 4406
		[Token(Token = "0x4001136")]
		[FieldOffset(Offset = "0xA0")]
		public static Predicate<NewRoom> <>9__165_7;

		// Token: 0x04001137 RID: 4407
		[Token(Token = "0x4001137")]
		[FieldOffset(Offset = "0xA8")]
		public static Comparison<ChapterIntro.IntoCharacterPick> <>9__165_2;

		// Token: 0x04001138 RID: 4408
		[Token(Token = "0x4001138")]
		[FieldOffset(Offset = "0xB0")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__166_0;

		// Token: 0x04001139 RID: 4409
		[Token(Token = "0x4001139")]
		[FieldOffset(Offset = "0xB8")]
		public static Predicate<Telephone> <>9__169_0;

		// Token: 0x0400113A RID: 4410
		[Token(Token = "0x400113A")]
		[FieldOffset(Offset = "0xC0")]
		public static Predicate<Telephone> <>9__169_1;

		// Token: 0x0400113B RID: 4411
		[Token(Token = "0x400113B")]
		[FieldOffset(Offset = "0xC8")]
		public static Predicate<InfoWindow> <>9__177_0;

		// Token: 0x0400113C RID: 4412
		[Token(Token = "0x400113C")]
		[FieldOffset(Offset = "0xD0")]
		public static Predicate<Interactable> <>9__188_0;

		// Token: 0x0400113D RID: 4413
		[Token(Token = "0x400113D")]
		[FieldOffset(Offset = "0xD8")]
		public static Predicate<Interactable> <>9__188_1;

		// Token: 0x0400113E RID: 4414
		[Token(Token = "0x400113E")]
		[FieldOffset(Offset = "0xE0")]
		public static Predicate<Interactable.Passed> <>9__194_0;

		// Token: 0x0400113F RID: 4415
		[Token(Token = "0x400113F")]
		[FieldOffset(Offset = "0xE8")]
		public static Predicate<Interactable.Passed> <>9__194_1;

		// Token: 0x04001140 RID: 4416
		[Token(Token = "0x4001140")]
		[FieldOffset(Offset = "0xF0")]
		public static Predicate<NewRoom> <>9__216_0;

		// Token: 0x04001141 RID: 4417
		[Token(Token = "0x4001141")]
		[FieldOffset(Offset = "0xF8")]
		public static Predicate<NewRoom> <>9__217_0;

		// Token: 0x04001142 RID: 4418
		[Token(Token = "0x4001142")]
		[FieldOffset(Offset = "0x100")]
		public static Predicate<NewRoom> <>9__227_0;

		// Token: 0x04001143 RID: 4419
		[Token(Token = "0x4001143")]
		[FieldOffset(Offset = "0x108")]
		public static Predicate<NewRoom> <>9__230_0;

		// Token: 0x04001144 RID: 4420
		[Token(Token = "0x4001144")]
		[FieldOffset(Offset = "0x110")]
		public static Predicate<NewRoom> <>9__231_0;

		// Token: 0x04001145 RID: 4421
		[Token(Token = "0x4001145")]
		[FieldOffset(Offset = "0x118")]
		public static Predicate<NewRoom> <>9__232_0;

		// Token: 0x04001146 RID: 4422
		[Token(Token = "0x4001146")]
		[FieldOffset(Offset = "0x120")]
		public static Predicate<NewRoom> <>9__241_0;

		// Token: 0x04001147 RID: 4423
		[Token(Token = "0x4001147")]
		[FieldOffset(Offset = "0x128")]
		public static Predicate<NewRoom> <>9__242_0;

		// Token: 0x04001148 RID: 4424
		[Token(Token = "0x4001148")]
		[FieldOffset(Offset = "0x130")]
		public static Predicate<NewRoom> <>9__243_0;

		// Token: 0x04001149 RID: 4425
		[Token(Token = "0x4001149")]
		[FieldOffset(Offset = "0x138")]
		public static Predicate<NewRoom> <>9__247_0;

		// Token: 0x0400114A RID: 4426
		[Token(Token = "0x400114A")]
		[FieldOffset(Offset = "0x140")]
		public static Predicate<NewRoom> <>9__248_0;

		// Token: 0x0400114B RID: 4427
		[Token(Token = "0x400114B")]
		[FieldOffset(Offset = "0x148")]
		public static Predicate<FurnitureLocation> <>9__248_1;

		// Token: 0x0400114C RID: 4428
		[Token(Token = "0x400114C")]
		[FieldOffset(Offset = "0x150")]
		public static Predicate<Interactable> <>9__252_0;
	}

	// Token: 0x0200028D RID: 653
	[Token(Token = "0x200028D")]
	private sealed class <>c__DisplayClass152_0
	{
		// Token: 0x06000F1D RID: 3869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass152_0()
		{
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00007DB8 File Offset: 0x00005FB8
		[Token(Token = "0x6000F1E")]
		[Address(RVA = "0x478670", Offset = "0x477670", VA = "0x180478670")]
		internal bool <PreSimHandling>b__3(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x0400114D RID: 4429
		[Token(Token = "0x400114D")]
		[FieldOffset(Offset = "0x10")]
		public FurniturePreset.SubObject sub;
	}

	// Token: 0x0200028E RID: 654
	[Token(Token = "0x200028E")]
	private sealed class <PreSimHandling>d__152 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000F1F RID: 3871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <PreSimHandling>d__152(int <>1__state)
		{
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F20")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00007DD0 File Offset: 0x00005FD0
		[Token(Token = "0x6000F21")]
		[Address(RVA = "0x657800", Offset = "0x656800", VA = "0x180657800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000079")]
		private object Current
		{
			[Token(Token = "0x6000F22")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F23")]
		[Address(RVA = "0x65DD70", Offset = "0x65CD70", VA = "0x18065DD70", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700007A")]
		private object Current
		{
			[Token(Token = "0x6000F24")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400114E RID: 4430
		[Token(Token = "0x400114E")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400114F RID: 4431
		[Token(Token = "0x400114F")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001150 RID: 4432
		[Token(Token = "0x4001150")]
		[FieldOffset(Offset = "0x20")]
		public ChapterIntro <>4__this;

		// Token: 0x04001151 RID: 4433
		[Token(Token = "0x4001151")]
		[FieldOffset(Offset = "0x28")]
		private float <prevTime>5__2;

		// Token: 0x04001152 RID: 4434
		[Token(Token = "0x4001152")]
		[FieldOffset(Offset = "0x2C")]
		private bool <findRestaurantSeat>5__3;

		// Token: 0x04001153 RID: 4435
		[Token(Token = "0x4001153")]
		[FieldOffset(Offset = "0x30")]
		private NewNode <boothSeatNode>5__4;

		// Token: 0x04001154 RID: 4436
		[Token(Token = "0x4001154")]
		[FieldOffset(Offset = "0x38")]
		private Interactable <boothSeat1>5__5;

		// Token: 0x04001155 RID: 4437
		[Token(Token = "0x4001155")]
		[FieldOffset(Offset = "0x40")]
		private Interactable <boothSeat2>5__6;

		// Token: 0x04001156 RID: 4438
		[Token(Token = "0x4001156")]
		[FieldOffset(Offset = "0x48")]
		private float <sittingTime>5__7;

		// Token: 0x04001157 RID: 4439
		[Token(Token = "0x4001157")]
		[FieldOffset(Offset = "0x4C")]
		private float <preMeetTime>5__8;

		// Token: 0x04001158 RID: 4440
		[Token(Token = "0x4001158")]
		[FieldOffset(Offset = "0x50")]
		private bool <findMeetTime>5__9;

		// Token: 0x04001159 RID: 4441
		[Token(Token = "0x4001159")]
		[FieldOffset(Offset = "0x54")]
		private float <preMeetingLength>5__10;

		// Token: 0x0400115A RID: 4442
		[Token(Token = "0x400115A")]
		[FieldOffset(Offset = "0x58")]
		private float <meetingTimeLength>5__11;

		// Token: 0x0400115B RID: 4443
		[Token(Token = "0x400115B")]
		[FieldOffset(Offset = "0x5C")]
		private float <phase0LoadRatio>5__12;

		// Token: 0x0400115C RID: 4444
		[Token(Token = "0x400115C")]
		[FieldOffset(Offset = "0x60")]
		private bool <noteWriterPathingComplete>5__13;

		// Token: 0x0400115D RID: 4445
		[Token(Token = "0x400115D")]
		[FieldOffset(Offset = "0x61")]
		private bool <nWpathsCalc>5__14;

		// Token: 0x0400115E RID: 4446
		[Token(Token = "0x400115E")]
		[FieldOffset(Offset = "0x64")]
		private int <nWcaptureCursor>5__15;

		// Token: 0x0400115F RID: 4447
		[Token(Token = "0x400115F")]
		[FieldOffset(Offset = "0x68")]
		private PathFinder.PathData <nWcapturePath>5__16;

		// Token: 0x04001160 RID: 4448
		[Token(Token = "0x4001160")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<NewRoom, List<NewNode>> <nWnodesPool>5__17;

		// Token: 0x04001161 RID: 4449
		[Token(Token = "0x4001161")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<NewNode, List<Interactable>> <nWcameraCoverage>5__18;

		// Token: 0x04001162 RID: 4450
		[Token(Token = "0x4001162")]
		[FieldOffset(Offset = "0x80")]
		private HashSet<NewRoom> <nWroutesCovered>5__19;

		// Token: 0x04001163 RID: 4451
		[Token(Token = "0x4001163")]
		[FieldOffset(Offset = "0x88")]
		private bool <nWwaitingForCapture>5__20;

		// Token: 0x04001164 RID: 4452
		[Token(Token = "0x4001164")]
		[FieldOffset(Offset = "0x8C")]
		private float <nWwaitForCaptureTime>5__21;

		// Token: 0x04001165 RID: 4453
		[Token(Token = "0x4001165")]
		[FieldOffset(Offset = "0x90")]
		private Interactable <nWcam>5__22;

		// Token: 0x04001166 RID: 4454
		[Token(Token = "0x4001166")]
		[FieldOffset(Offset = "0x98")]
		private bool <kidnapperPathingComplete>5__23;

		// Token: 0x04001167 RID: 4455
		[Token(Token = "0x4001167")]
		[FieldOffset(Offset = "0x99")]
		private bool <kpathsCalc>5__24;

		// Token: 0x04001168 RID: 4456
		[Token(Token = "0x4001168")]
		[FieldOffset(Offset = "0x9C")]
		private int <kcaptureCursor>5__25;

		// Token: 0x04001169 RID: 4457
		[Token(Token = "0x4001169")]
		[FieldOffset(Offset = "0xA0")]
		private PathFinder.PathData <kcapturePath>5__26;

		// Token: 0x0400116A RID: 4458
		[Token(Token = "0x400116A")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<NewRoom, List<NewNode>> <knodesPool>5__27;

		// Token: 0x0400116B RID: 4459
		[Token(Token = "0x400116B")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<NewNode, List<Interactable>> <kcameraCoverage>5__28;

		// Token: 0x0400116C RID: 4460
		[Token(Token = "0x400116C")]
		[FieldOffset(Offset = "0xB8")]
		private HashSet<NewRoom> <kroutesCovered>5__29;

		// Token: 0x0400116D RID: 4461
		[Token(Token = "0x400116D")]
		[FieldOffset(Offset = "0xC0")]
		private bool <kwaitingForCapture>5__30;

		// Token: 0x0400116E RID: 4462
		[Token(Token = "0x400116E")]
		[FieldOffset(Offset = "0xC4")]
		private float <kwaitForCaptureTime>5__31;

		// Token: 0x0400116F RID: 4463
		[Token(Token = "0x400116F")]
		[FieldOffset(Offset = "0xC8")]
		private Interactable <kcam>5__32;

		// Token: 0x04001170 RID: 4464
		[Token(Token = "0x4001170")]
		[FieldOffset(Offset = "0xD0")]
		private float <nwAv>5__33;

		// Token: 0x04001171 RID: 4465
		[Token(Token = "0x4001171")]
		[FieldOffset(Offset = "0xD4")]
		private float <kAv>5__34;

		// Token: 0x04001172 RID: 4466
		[Token(Token = "0x4001172")]
		[FieldOffset(Offset = "0xD8")]
		private float <recordedDistance2>5__35;

		// Token: 0x04001173 RID: 4467
		[Token(Token = "0x4001173")]
		[FieldOffset(Offset = "0xDC")]
		private float <startDistance2>5__36;

		// Token: 0x04001174 RID: 4468
		[Token(Token = "0x4001174")]
		[FieldOffset(Offset = "0xE0")]
		private float <phase1LoadRatio>5__37;

		// Token: 0x04001175 RID: 4469
		[Token(Token = "0x4001175")]
		[FieldOffset(Offset = "0xE4")]
		private bool <setupFinalPhase>5__38;

		// Token: 0x04001176 RID: 4470
		[Token(Token = "0x4001176")]
		[FieldOffset(Offset = "0xE8")]
		private float <recordedDistance>5__39;

		// Token: 0x04001177 RID: 4471
		[Token(Token = "0x4001177")]
		[FieldOffset(Offset = "0xEC")]
		private float <startDistance>5__40;

		// Token: 0x04001178 RID: 4472
		[Token(Token = "0x4001178")]
		[FieldOffset(Offset = "0xF0")]
		private float <phase2LoadRatio>5__41;

		// Token: 0x04001179 RID: 4473
		[Token(Token = "0x4001179")]
		[FieldOffset(Offset = "0xF4")]
		private float <murderTime>5__42;
	}

	// Token: 0x0200028F RID: 655
	[Token(Token = "0x200028F")]
	private sealed class <>c__DisplayClass165_0
	{
		// Token: 0x06000F25 RID: 3877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F25")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass165_0()
		{
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00007DE8 File Offset: 0x00005FE8
		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x65DE00", Offset = "0x65CE00", VA = "0x18065DE00")]
		internal bool <PickCharacters>b__8(Citizen item)
		{
			return default(bool);
		}

		// Token: 0x0400117A RID: 4474
		[Token(Token = "0x400117A")]
		[FieldOffset(Offset = "0x10")]
		public ChapterIntro.IntoCharacterPick newPick;
	}

	// Token: 0x02000290 RID: 656
	[Token(Token = "0x2000290")]
	private sealed class <>c__DisplayClass217_0
	{
		// Token: 0x06000F27 RID: 3879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass217_0()
		{
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00007E00 File Offset: 0x00006000
		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x65DEC0", Offset = "0x65CEC0", VA = "0x18065DEC0")]
		internal bool <ArrivalDiner>b__1(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x0400117B RID: 4475
		[Token(Token = "0x400117B")]
		[FieldOffset(Offset = "0x10")]
		public ChapterIntro <>4__this;

		// Token: 0x0400117C RID: 4476
		[Token(Token = "0x400117C")]
		[FieldOffset(Offset = "0x18")]
		public NewRoom eateryRoom;
	}
}
