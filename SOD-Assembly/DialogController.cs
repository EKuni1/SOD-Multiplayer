using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000117 RID: 279
[Token(Token = "0x2000117")]
public class DialogController : MonoBehaviour
{
	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000030")]
	public static DialogController Instance
	{
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x49FE70", Offset = "0x49EE70", VA = "0x18049FE70")]
		get
		{
			return null;
		}
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x49FEB0", Offset = "0x49EEB0", VA = "0x18049FEB0")]
	private void Start()
	{
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E5")]
	[Address(RVA = "0x4A04D0", Offset = "0x49F4D0", VA = "0x1804A04D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x00005460 File Offset: 0x00003660
	[Token(Token = "0x60007E6")]
	[Address(RVA = "0x4A06E0", Offset = "0x49F6E0", VA = "0x1804A06E0")]
	public bool ExecuteDialog(EvidenceWitness.DialogOption dialog, Interactable saysTo, NewNode where, Actor saidBy, DialogController.ForceSuccess forceSuccess = DialogController.ForceSuccess.none, [Optional] Human.InteractionDialogInstance interactionInstance)
	{
		return default(bool);
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x00005478 File Offset: 0x00003678
	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x4A3110", Offset = "0x4A2110", VA = "0x1804A3110")]
	public bool TestSpecialCaseAvailability(DialogPreset preset, Citizen saysTo, SideJob jobRef)
	{
		return default(bool);
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x4A5200", Offset = "0x4A4200", VA = "0x1804A5200")]
	public void OnDialogEnd(AIActionPreset.AISpeechPreset dialog, string dialogPresetStr, Interactable saysToInteractable, Actor saidBy, int jobRef)
	{
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x4A5B80", Offset = "0x4A4B80", VA = "0x1804A5B80")]
	public void BribeForCode(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007EA")]
	[Address(RVA = "0x4A60A0", Offset = "0x4A50A0", VA = "0x1804A60A0")]
	public void Beg(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007EB")]
	[Address(RVA = "0x4A61A0", Offset = "0x4A51A0", VA = "0x1804A61A0")]
	public void PayForCode(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007EC")]
	[Address(RVA = "0x4A6980", Offset = "0x4A5980", VA = "0x1804A6980")]
	public void IssueGuestPass(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007ED")]
	[Address(RVA = "0x4A6C80", Offset = "0x4A5C80", VA = "0x1804A6C80")]
	public void DoYouKnowThisPerson(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007EE")]
	[Address(RVA = "0x4A6F20", Offset = "0x4A5F20", VA = "0x1804A6F20")]
	public void DoYouKnowThisPersonBribe1(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007EF")]
	[Address(RVA = "0x4A71C0", Offset = "0x4A61C0", VA = "0x1804A71C0")]
	public void DoYouKnowThisPersonBribe2(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F0")]
	[Address(RVA = "0x4A7460", Offset = "0x4A6460", VA = "0x1804A7460")]
	public void DoYouKnowThisPersonBribe3(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F1")]
	[Address(RVA = "0x4A7700", Offset = "0x4A6700", VA = "0x1804A7700")]
	public void BuySomething(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F2")]
	[Address(RVA = "0x4A79D0", Offset = "0x4A69D0", VA = "0x1804A79D0")]
	public void PhoneKeypad(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F3")]
	[Address(RVA = "0x4A7BA0", Offset = "0x4A6BA0", VA = "0x1804A7BA0")]
	public void IdentifyNumber(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F4")]
	[Address(RVA = "0x4A7CA0", Offset = "0x4A6CA0", VA = "0x1804A7CA0")]
	public void LastCalled(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F5")]
	[Address(RVA = "0x4A82C0", Offset = "0x4A72C0", VA = "0x1804A82C0")]
	public void Police(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x4A8340", Offset = "0x4A7340", VA = "0x1804A8340")]
	public void Escape(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x4A8890", Offset = "0x4A7890", VA = "0x1804A8890")]
	public void PayMedicalFees(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x4A8AB0", Offset = "0x4A7AB0", VA = "0x1804A8AB0")]
	public void WarnNotewriter(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void InstallNewSyncDiskSlot(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x4A8D50", Offset = "0x4A7D50", VA = "0x1804A8D50")]
	public void TakeALookAround(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x4A8F40", Offset = "0x4A7F40", VA = "0x1804A8F40")]
	public void TakeALookAroundBribe1(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x4A9130", Offset = "0x4A8130", VA = "0x1804A9130")]
	public void TakeALookAroundBribe2(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x4A9320", Offset = "0x4A8320", VA = "0x1804A9320")]
	public void TakeALookAroundBribe3(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x4A9510", Offset = "0x4A8510", VA = "0x1804A9510")]
	public void TakeALookAroundBribe4(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x4A9700", Offset = "0x4A8700", VA = "0x1804A9700")]
	public void Job_HouseMeet_StolenItem(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000800")]
	[Address(RVA = "0x4A9C20", Offset = "0x4A8C20", VA = "0x1804A9C20")]
	public void SeenOrHeardUnusual(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000801")]
	[Address(RVA = "0x4AAD70", Offset = "0x4A9D70", VA = "0x1804AAD70")]
	public void GivePassword(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000802")]
	[Address(RVA = "0x4AB080", Offset = "0x4AA080", VA = "0x1804AB080")]
	public void MuggingAcquiesce(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000803")]
	[Address(RVA = "0x4AB300", Offset = "0x4AA300", VA = "0x1804AB300")]
	public void FFAcquiesce(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000804")]
	[Address(RVA = "0x4AB580", Offset = "0x4AA580", VA = "0x1804AB580")]
	public void FFMistaken(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000805")]
	[Address(RVA = "0x4AB800", Offset = "0x4AA800", VA = "0x1804AB800")]
	public void LoanShark_AcceptLoan(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000806")]
	[Address(RVA = "0x4AB9B0", Offset = "0x4AA9B0", VA = "0x1804AB9B0")]
	public void LoanShark_Pay(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000807")]
	[Address(RVA = "0x4ABD30", Offset = "0x4AAD30", VA = "0x1804ABD30")]
	public void Give(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000808")]
	[Address(RVA = "0x4ABF00", Offset = "0x4AAF00", VA = "0x1804ABF00")]
	public void BuyBriefcase(Citizen saysTo, Interactable saysToInteractable, NewNode where, Actor saidBy, bool success, NewRoom roomRef, SideJob jobRef)
	{
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000809")]
	[Address(RVA = "0x4AC2D0", Offset = "0x4AB2D0", VA = "0x1804AC2D0")]
	public DialogController()
	{
	}

	// Token: 0x0400083A RID: 2106
	[Token(Token = "0x400083A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public DialogPreset payForCode;

	// Token: 0x0400083B RID: 2107
	[Token(Token = "0x400083B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public InfoWindow askWindow;

	// Token: 0x0400083C RID: 2108
	[Token(Token = "0x400083C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Human askTarget;

	// Token: 0x0400083D RID: 2109
	[Token(Token = "0x400083D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Evidence.DataKey> askTargetKeys;

	// Token: 0x0400083E RID: 2110
	[Token(Token = "0x400083E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Dictionary<DialogPreset, MethodInfo> dialogRef;

	// Token: 0x0400083F RID: 2111
	[Token(Token = "0x400083F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[NonSerialized]
	public SideJob sideJobReference;

	// Token: 0x04000840 RID: 2112
	[Token(Token = "0x4000840")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[NonSerialized]
	public DialogPreset preset;

	// Token: 0x04000841 RID: 2113
	[Token(Token = "0x4000841")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[NonSerialized]
	public Citizen cit;

	// Token: 0x04000842 RID: 2114
	[Token(Token = "0x4000842")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static DialogController _instance;

	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	public enum ForceSuccess
	{
		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		none,
		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		success,
		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		fail
	}

	// Token: 0x02000119 RID: 281
	[Token(Token = "0x2000119")]
	private sealed class <>c__DisplayClass14_0
	{
		// Token: 0x0600080A RID: 2058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass14_0()
		{
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00005490 File Offset: 0x00003690
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x4AC4A0", Offset = "0x4AB4A0", VA = "0x1804AC4A0")]
		internal bool <ExecuteDialog>b__0(SideJobController.JobTracking item)
		{
			return default(bool);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x000054A8 File Offset: 0x000036A8
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x4AC600", Offset = "0x4AB600", VA = "0x1804AC600")]
		internal bool <ExecuteDialog>b__3(SideJob item)
		{
			return default(bool);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000054C0 File Offset: 0x000036C0
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x4AC7D0", Offset = "0x4AB7D0", VA = "0x1804AC7D0")]
		internal bool <ExecuteDialog>b__4(SideJobController.JobTracking item)
		{
			return default(bool);
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x000054D8 File Offset: 0x000036D8
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x4AC930", Offset = "0x4AB930", VA = "0x1804AC930")]
		internal bool <ExecuteDialog>b__5(SideJob item)
		{
			return default(bool);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x000054F0 File Offset: 0x000036F0
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x4ACB00", Offset = "0x4ABB00", VA = "0x1804ACB00")]
		internal bool <ExecuteDialog>b__1(SideJobController.JobTracking item)
		{
			return default(bool);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00005508 File Offset: 0x00003708
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x4ACC60", Offset = "0x4ABC60", VA = "0x1804ACC60")]
		internal bool <ExecuteDialog>b__6(SideJob item)
		{
			return default(bool);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00005520 File Offset: 0x00003720
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x4ACE30", Offset = "0x4ABE30", VA = "0x1804ACE30")]
		internal bool <ExecuteDialog>b__7(SideJobController.JobTracking item)
		{
			return default(bool);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00005538 File Offset: 0x00003738
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x4ACF90", Offset = "0x4ABF90", VA = "0x1804ACF90")]
		internal bool <ExecuteDialog>b__8(SideJob item)
		{
			return default(bool);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00005550 File Offset: 0x00003750
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x4AD160", Offset = "0x4AC160", VA = "0x1804AD160")]
		internal bool <ExecuteDialog>b__2(GameplayController.LoanDebt item)
		{
			return default(bool);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00005568 File Offset: 0x00003768
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x4AD160", Offset = "0x4AC160", VA = "0x1804AD160")]
		internal bool <ExecuteDialog>b__9(GameplayController.LoanDebt item)
		{
			return default(bool);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00005580 File Offset: 0x00003780
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x4AD1B0", Offset = "0x4AC1B0", VA = "0x1804AD1B0")]
		internal bool <ExecuteDialog>b__10(AIActionPreset.AISpeechPreset item)
		{
			return default(bool);
		}

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DialogController <>4__this;

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool success;

		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Predicate<SideJob> <>9__3;

		// Token: 0x0400084A RID: 2122
		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Predicate<SideJob> <>9__5;

		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Predicate<SideJob> <>9__6;

		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Predicate<SideJob> <>9__8;
	}

	// Token: 0x0200011A RID: 282
	[Token(Token = "0x200011A")]
	private sealed class <>c__DisplayClass15_0
	{
		// Token: 0x06000816 RID: 2070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass15_0()
		{
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00005598 File Offset: 0x00003798
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x4AD1F0", Offset = "0x4AC1F0", VA = "0x1804AD1F0")]
		internal bool <TestSpecialCaseAvailability>b__4(GameplayController.LoanDebt item)
		{
			return default(bool);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x000055B0 File Offset: 0x000037B0
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x4AD230", Offset = "0x4AC230", VA = "0x1804AD230")]
		internal bool <TestSpecialCaseAvailability>b__1(GameplayController.HotelGuest item)
		{
			return default(bool);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x000055C8 File Offset: 0x000037C8
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x4AD580", Offset = "0x4AC580", VA = "0x1804AD580")]
		internal bool <TestSpecialCaseAvailability>b__2(GameplayController.HotelGuest item)
		{
			return default(bool);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x000055E0 File Offset: 0x000037E0
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x4AD8D0", Offset = "0x4AC8D0", VA = "0x1804AD8D0")]
		internal bool <TestSpecialCaseAvailability>b__3(GameplayController.HotelGuest item)
		{
			return default(bool);
		}

		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Citizen saysTo;
	}

	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600081C RID: 2076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000055F8 File Offset: 0x000037F8
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x4ADCD0", Offset = "0x4ACCD0", VA = "0x1804ADCD0")]
		internal bool <TestSpecialCaseAvailability>b__15_0(Citizen item)
		{
			return default(bool);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00005610 File Offset: 0x00003810
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x4ADE00", Offset = "0x4ACE00", VA = "0x1804ADE00")]
		internal bool <SeenOrHeardUnusual>b__40_1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00005628 File Offset: 0x00003828
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x4ADF00", Offset = "0x4ACF00", VA = "0x1804ADF00")]
		internal bool <SeenOrHeardUnusual>b__40_2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DialogController.<>c <>9;

		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Citizen> <>9__15_0;

		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<Human.Trait> <>9__40_1;

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<Human.Trait> <>9__40_2;
	}

	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	private sealed class <>c__DisplayClass40_0
	{
		// Token: 0x06000820 RID: 2080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass40_0()
		{
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00005640 File Offset: 0x00003840
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x4ADF90", Offset = "0x4ACF90", VA = "0x1804ADF90")]
		internal bool <SeenOrHeardUnusual>b__0(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Citizen saysTo;
	}
}
