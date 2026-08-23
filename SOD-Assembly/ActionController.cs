using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000F4 RID: 244
[Token(Token = "0x20000F4")]
public class ActionController : MonoBehaviour
{
	// Token: 0x1400000B RID: 11
	// (add) Token: 0x06000689 RID: 1673 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600068A RID: 1674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400000B")]
	public event ActionController.PlayerAction OnPlayerAction
	{
		[Token(Token = "0x6000689")]
		[Address(RVA = "0xE20C80", Offset = "0xE1FC80", VA = "0x180E20C80")]
		add
		{
		}
		[Token(Token = "0x600068A")]
		[Address(RVA = "0xE20D70", Offset = "0xE1FD70", VA = "0x180E20D70")]
		remove
		{
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x0600068B RID: 1675 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700002B")]
	public static ActionController Instance
	{
		[Token(Token = "0x600068B")]
		[Address(RVA = "0xE20E60", Offset = "0xE1FE60", VA = "0x180E20E60")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600068C")]
	[Address(RVA = "0xE20EA0", Offset = "0xE1FEA0", VA = "0x180E20EA0")]
	private void Awake()
	{
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600068D")]
	[Address(RVA = "0xE21520", Offset = "0xE20520", VA = "0x180E21520")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600068E")]
	[Address(RVA = "0xE21730", Offset = "0xE20730", VA = "0x180E21730")]
	public void ExecuteAction(AIActionPreset action, Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600068F")]
	[Address(RVA = "0xE21A00", Offset = "0xE20A00", VA = "0x180E21A00")]
	public void TurnOnMainLight(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000690")]
	[Address(RVA = "0xE21EA0", Offset = "0xE20EA0", VA = "0x180E21EA0")]
	public void TurnOffMainLight(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000691")]
	[Address(RVA = "0xE22340", Offset = "0xE21340", VA = "0x180E22340")]
	public void TurnOnSecondaryLight(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000692")]
	[Address(RVA = "0xE22560", Offset = "0xE21560", VA = "0x180E22560")]
	public void TurnOffSecondaryLight(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000693")]
	[Address(RVA = "0xE22940", Offset = "0xE21940", VA = "0x180E22940")]
	public void TurnOnTV(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000694")]
	[Address(RVA = "0xE22970", Offset = "0xE21970", VA = "0x180E22970")]
	public void TurnOffTV(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000695")]
	[Address(RVA = "0xE22B70", Offset = "0xE21B70", VA = "0x180E22B70")]
	public void PickUp(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000696")]
	[Address(RVA = "0xE23240", Offset = "0xE22240", VA = "0x180E23240")]
	public void PutDown(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000697")]
	[Address(RVA = "0xE235D0", Offset = "0xE225D0", VA = "0x180E235D0")]
	public void Throw(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000698")]
	[Address(RVA = "0xE23800", Offset = "0xE22800", VA = "0x180E23800")]
	public void OpenDoor(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000699")]
	[Address(RVA = "0xE242A0", Offset = "0xE232A0", VA = "0x180E242A0")]
	public void CloseDoor(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600069A")]
	[Address(RVA = "0xE247F0", Offset = "0xE237F0", VA = "0x180E247F0")]
	public void Open(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600069B")]
	[Address(RVA = "0xE24A80", Offset = "0xE23A80", VA = "0x180E24A80")]
	public void KnockOnDoor(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600069C")]
	[Address(RVA = "0xE24CC0", Offset = "0xE23CC0", VA = "0x180E24CC0")]
	public void LockDoor(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600069D")]
	[Address(RVA = "0xE25340", Offset = "0xE24340", VA = "0x180E25340")]
	public void UnlockDoor(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600069E")]
	[Address(RVA = "0xE259C0", Offset = "0xE249C0", VA = "0x180E259C0")]
	public void Lockpick(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600069F")]
	[Address(RVA = "0xE260C0", Offset = "0xE250C0", VA = "0x180E260C0")]
	public void PeekUnderDoor(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A0")]
	[Address(RVA = "0xE26230", Offset = "0xE25230", VA = "0x180E26230")]
	public void Hide(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A1")]
	[Address(RVA = "0xE26400", Offset = "0xE25400", VA = "0x180E26400")]
	public void AnswerTelephone(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A2")]
	[Address(RVA = "0xE26720", Offset = "0xE25720", VA = "0x180E26720")]
	public void AIHangUp(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A3")]
	[Address(RVA = "0xE26760", Offset = "0xE25760", VA = "0x180E26760")]
	public void Return(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A4")]
	[Address(RVA = "0xE267D0", Offset = "0xE257D0", VA = "0x180E267D0")]
	public void PullPlayerFromHidingPlace(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A5")]
	[Address(RVA = "0xE26860", Offset = "0xE25860", VA = "0x180E26860")]
	public void TakeKey(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A6")]
	[Address(RVA = "0xE27160", Offset = "0xE26160", VA = "0x180E27160")]
	public void TakeBlueprints(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A7")]
	[Address(RVA = "0xE27A40", Offset = "0xE26A40", VA = "0x180E27A40")]
	public void TakeMoney(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A8")]
	[Address(RVA = "0xE27DA0", Offset = "0xE26DA0", VA = "0x180E27DA0")]
	public void AIPickUpItemFromFloor(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A9")]
	[Address(RVA = "0xE28920", Offset = "0xE27920", VA = "0x180E28920")]
	public void AIPutBack(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006AA")]
	[Address(RVA = "0xE289C0", Offset = "0xE279C0", VA = "0x180E289C0")]
	public void CleanUp(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006AB")]
	[Address(RVA = "0xE28F30", Offset = "0xE27F30", VA = "0x180E28F30")]
	public void TakeSyncDisk(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006AC")]
	[Address(RVA = "0xE291E0", Offset = "0xE281E0", VA = "0x180E291E0")]
	public void TakeLockpick(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006AD")]
	[Address(RVA = "0xE29360", Offset = "0xE28360", VA = "0x180E29360")]
	public void TakeLockpickKit(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006AE")]
	[Address(RVA = "0xE294E0", Offset = "0xE284E0", VA = "0x180E294E0")]
	public void Rob(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006AF")]
	[Address(RVA = "0xE29510", Offset = "0xE28510", VA = "0x180E29510")]
	public void Inspect(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B0")]
	[Address(RVA = "0xE296E0", Offset = "0xE286E0", VA = "0x180E296E0")]
	public void InspectRemove(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B1")]
	[Address(RVA = "0xE298D0", Offset = "0xE288D0", VA = "0x180E298D0")]
	public void InspectComputer(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B2")]
	[Address(RVA = "0xE2A490", Offset = "0xE29490", VA = "0x180E2A490")]
	public void InspectMultiPage(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B3")]
	[Address(RVA = "0xE2AAE0", Offset = "0xE29AE0", VA = "0x180E2AAE0")]
	public void TalkTo(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B4")]
	[Address(RVA = "0xE2ABA0", Offset = "0xE29BA0", VA = "0x180E2ABA0")]
	public void Call(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B5")]
	[Address(RVA = "0xE2AC90", Offset = "0xE29C90", VA = "0x180E2AC90")]
	public void Dial(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B6")]
	[Address(RVA = "0xE2AE60", Offset = "0xE29E60", VA = "0x180E2AE60")]
	public void CallSomeone(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B7")]
	[Address(RVA = "0xE2C320", Offset = "0xE2B320", VA = "0x180E2C320")]
	public void Say(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60006B8")]
	[Address(RVA = "0xE2C6E0", Offset = "0xE2B6E0", VA = "0x180E2C6E0")]
	public IEnumerator _DialogInputBox(Interactable what, NewNode where, Actor who, DialogButtonController button, DialogPreset preset)
	{
		return null;
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B9")]
	[Address(RVA = "0xE2C950", Offset = "0xE2B950", VA = "0x180E2C950")]
	private void _InvokeDialog(Interactable what, NewNode where, Actor who, DialogButtonController button, DialogPreset preset, DialogController.ForceSuccess forceSuccess, [Optional] Human.InteractionDialogInstance interactionInstance)
	{
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006BA")]
	[Address(RVA = "0xE2C990", Offset = "0xE2B990", VA = "0x180E2C990")]
	private void _InvokeDialog(Interactable what, NewNode where, Actor who, EvidenceWitness.DialogOption option, DialogPreset preset, DialogController.ForceSuccess forceSuccess, [Optional] Human.InteractionDialogInstance interactionInstance)
	{
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006BB")]
	[Address(RVA = "0xE2DAE0", Offset = "0xE2CAE0", VA = "0x180E2DAE0")]
	public void CrawlIntoVent(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006BC")]
	[Address(RVA = "0xE2DC30", Offset = "0xE2CC30", VA = "0x180E2DC30")]
	public void UseKeypad(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006BD")]
	[Address(RVA = "0xE2E140", Offset = "0xE2D140", VA = "0x180E2E140")]
	public void NextPage(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006BE")]
	[Address(RVA = "0xE2E230", Offset = "0xE2D230", VA = "0x180E2E230")]
	public void PreviousPage(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006BF")]
	[Address(RVA = "0xE2E2F0", Offset = "0xE2D2F0", VA = "0x180E2E2F0")]
	public void SetCurrentMonth(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006C0")]
	[Address(RVA = "0xE26230", Offset = "0xE25230", VA = "0x180E26230")]
	public void Sleep(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006C1")]
	[Address(RVA = "0xE26760", Offset = "0xE25760", VA = "0x180E26760")]
	public void GetUp(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006C2")]
	[Address(RVA = "0xE2E3D0", Offset = "0xE2D3D0", VA = "0x180E2E3D0")]
	public void CallElevator(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006C3")]
	[Address(RVA = "0xE2E660", Offset = "0xE2D660", VA = "0x180E2E660")]
	public void PassTime(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006C4")]
	[Address(RVA = "0xE2E910", Offset = "0xE2D910", VA = "0x180E2E910")]
	public void CancelPassTime(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006C5")]
	[Address(RVA = "0xE2E9C0", Offset = "0xE2D9C0", VA = "0x180E2E9C0")]
	public void HoursMinutesToggle(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006C6")]
	[Address(RVA = "0xE2ED10", Offset = "0xE2DD10", VA = "0x180E2ED10")]
	public void ActivateTimePass(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006C7")]
	[Address(RVA = "0xE2F260", Offset = "0xE2E260", VA = "0x180E2F260")]
	public void WatchForward(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006C8")]
	[Address(RVA = "0xE2F340", Offset = "0xE2E340", VA = "0x180E2F340")]
	public void WatchBack(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006C9")]
	[Address(RVA = "0xE2F420", Offset = "0xE2E420", VA = "0x180E2F420")]
	public void HideInstant(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006CA")]
	[Address(RVA = "0xE2F490", Offset = "0xE2E490", VA = "0x180E2F490")]
	public void BargeDoor(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006CB")]
	[Address(RVA = "0xE2F820", Offset = "0xE2E820", VA = "0x180E2F820")]
	public void BargeReturn(bool restoreTransform = false)
	{
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006CC")]
	[Address(RVA = "0xE2F9D0", Offset = "0xE2E9D0", VA = "0x180E2F9D0")]
	public void UseComputer(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006CD")]
	[Address(RVA = "0xE2FA30", Offset = "0xE2EA30", VA = "0x180E2FA30")]
	public void ReturnComputer(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006CE")]
	[Address(RVA = "0xE2FA80", Offset = "0xE2EA80", VA = "0x180E2FA80")]
	public void TriggerAlarm(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006CF")]
	[Address(RVA = "0xE30450", Offset = "0xE2F450", VA = "0x180E30450")]
	public void Search(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006D0")]
	[Address(RVA = "0xE30730", Offset = "0xE2F730", VA = "0x180E30730")]
	public void Vomit(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006D1")]
	[Address(RVA = "0xE307F0", Offset = "0xE2F7F0", VA = "0x180E307F0")]
	public void TakePrint(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006D2")]
	[Address(RVA = "0xE30850", Offset = "0xE2F850", VA = "0x180E30850")]
	public void NextChoice(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006D3")]
	[Address(RVA = "0xE30940", Offset = "0xE2F940", VA = "0x180E30940")]
	public void PreviousChoice(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006D4")]
	[Address(RVA = "0xE30A30", Offset = "0xE2FA30", VA = "0x180E30A30")]
	public void TakeFirstPersonItem(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60006D5")]
	[Address(RVA = "0xE30B10", Offset = "0xE2FB10", VA = "0x180E30B10")]
	private IEnumerator AddFirstPersonItemDelay(Interactable newInteractable)
	{
		return null;
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006D6")]
	[Address(RVA = "0xE30BB0", Offset = "0xE2FBB0", VA = "0x180E30BB0")]
	public void TakeFirstPersonItemUsed(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006D7")]
	[Address(RVA = "0xE30C30", Offset = "0xE2FC30", VA = "0x180E30C30")]
	public void Buy(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006D8")]
	[Address(RVA = "0xE30E10", Offset = "0xE2FE10", VA = "0x180E30E10")]
	public void TakeConsumable(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006D9")]
	[Address(RVA = "0xE32220", Offset = "0xE31220", VA = "0x180E32220")]
	public void MakeCoffeeStart(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006DA")]
	[Address(RVA = "0xE32A00", Offset = "0xE31A00", VA = "0x180E32A00")]
	public void MakeCoffeeEnd(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006DB")]
	[Address(RVA = "0xE32ED0", Offset = "0xE31ED0", VA = "0x180E32ED0")]
	public void TurnOnHob(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006DC")]
	[Address(RVA = "0xE335F0", Offset = "0xE325F0", VA = "0x180E335F0")]
	public void TurnOffHob(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006DD")]
	[Address(RVA = "0xE33820", Offset = "0xE32820", VA = "0x180E33820")]
	public void TurnOnMusic(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006DE")]
	[Address(RVA = "0xE33C10", Offset = "0xE32C10", VA = "0x180E33C10")]
	public void TurnOffMusic(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006DF")]
	[Address(RVA = "0xE340C0", Offset = "0xE330C0", VA = "0x180E340C0")]
	public void PurchaseItem(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E0")]
	[Address(RVA = "0xE35300", Offset = "0xE34300", VA = "0x180E35300")]
	public void Consume(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E1")]
	[Address(RVA = "0xE354E0", Offset = "0xE344E0", VA = "0x180E354E0")]
	public void Dispose(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E2")]
	[Address(RVA = "0xE36C20", Offset = "0xE35C20", VA = "0x180E36C20")]
	public void PostJob(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E3")]
	[Address(RVA = "0xE375B0", Offset = "0xE365B0", VA = "0x180E375B0")]
	public void LogOnComputer(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E4")]
	[Address(RVA = "0xE37940", Offset = "0xE36940", VA = "0x180E37940")]
	public void Sabotage(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E5")]
	[Address(RVA = "0xE37B80", Offset = "0xE36B80", VA = "0x180E37B80")]
	public void DryOff(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E6")]
	[Address(RVA = "0xE37DD0", Offset = "0xE36DD0", VA = "0x180E37DD0")]
	public void OpenSyncDisks(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E7")]
	[Address(RVA = "0xE37F40", Offset = "0xE36F40", VA = "0x180E37F40")]
	public void CallEnforcers(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E8")]
	[Address(RVA = "0xE38A90", Offset = "0xE37A90", VA = "0x180E38A90")]
	public void PutUpPoliceTape(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E9")]
	[Address(RVA = "0xE38C60", Offset = "0xE37C60", VA = "0x180E38C60")]
	public void RemovePoliceTape(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006EA")]
	[Address(RVA = "0xE38E30", Offset = "0xE37E30", VA = "0x180E38E30")]
	public void PutUpStreetCrimeScene(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006EB")]
	[Address(RVA = "0xE39030", Offset = "0xE38030", VA = "0x180E39030")]
	public void GetCaseForm(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006EC")]
	[Address(RVA = "0xE393C0", Offset = "0xE383C0", VA = "0x180E393C0")]
	public void HandInCase(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006ED")]
	[Address(RVA = "0xE3A950", Offset = "0xE39950", VA = "0x180E3A950")]
	public void RetirementConfirm()
	{
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006EE")]
	[Address(RVA = "0xE3AE50", Offset = "0xE39E50", VA = "0x180E3AE50")]
	public void RetirementCancel()
	{
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006EF")]
	[Address(RVA = "0xE3AFB0", Offset = "0xE39FB0", VA = "0x180E3AFB0")]
	public void CheckPulse(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F0")]
	[Address(RVA = "0xE3B580", Offset = "0xE3A580", VA = "0x180E3B580")]
	public void TakeActiveCodebreaker(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F1")]
	[Address(RVA = "0xE3B960", Offset = "0xE3A960", VA = "0x180E3B960")]
	public void TakeActiveDoorWedge(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F2")]
	[Address(RVA = "0xE3BDE0", Offset = "0xE3ADE0", VA = "0x180E3BDE0")]
	public void TakeActiveTracker(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F3")]
	[Address(RVA = "0xE3C1C0", Offset = "0xE3B1C0", VA = "0x180E3C1C0")]
	public void TakeActiveFlashBomb(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F4")]
	[Address(RVA = "0xE3C5A0", Offset = "0xE3B5A0", VA = "0x180E3C5A0")]
	public void TakeActiveIncapacitator(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F5")]
	[Address(RVA = "0xE3C980", Offset = "0xE3B980", VA = "0x180E3C980")]
	public void OpenBreaker(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F6")]
	[Address(RVA = "0xE3C9F0", Offset = "0xE3B9F0", VA = "0x180E3C9F0")]
	public void CloseBreaker(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F7")]
	[Address(RVA = "0xE3CA50", Offset = "0xE3BA50", VA = "0x180E3CA50")]
	public void ShootPoolBall(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F8")]
	[Address(RVA = "0xE3CB80", Offset = "0xE3BB80", VA = "0x180E3CB80")]
	public void ResetPoolGame(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void PutBack(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FA")]
	[Address(RVA = "0xE3CDE0", Offset = "0xE3BDE0", VA = "0x180E3CDE0")]
	public void Release(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FB")]
	[Address(RVA = "0xE3D2A0", Offset = "0xE3C2A0", VA = "0x180E3D2A0")]
	public void TakeDetectiveStuff(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FC")]
	[Address(RVA = "0xE3DD60", Offset = "0xE3CD60", VA = "0x180E3DD60")]
	public void Mugging(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FD")]
	[Address(RVA = "0xE3E4C0", Offset = "0xE3D4C0", VA = "0x180E3E4C0")]
	public void DebtCollection(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FE")]
	[Address(RVA = "0xE3EB20", Offset = "0xE3DB20", VA = "0x180E3EB20")]
	public void NextTrack(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FF")]
	[Address(RVA = "0xE3EB40", Offset = "0xE3DB40", VA = "0x180E3EB40")]
	public void PreviousTrack(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000700")]
	[Address(RVA = "0xE3EB60", Offset = "0xE3DB60", VA = "0x180E3EB60")]
	public void CancelPutDownHomeInventoryItem(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000701")]
	[Address(RVA = "0xE3EC20", Offset = "0xE3DC20", VA = "0x180E3EC20")]
	public void RotatePhysicsLeft(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000702")]
	[Address(RVA = "0xE3EDC0", Offset = "0xE3DDC0", VA = "0x180E3EDC0")]
	public void RotatePhysicsRight(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000703")]
	[Address(RVA = "0xE3EF60", Offset = "0xE3DF60", VA = "0x180E3EF60")]
	public void Drink(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000704")]
	[Address(RVA = "0xE3EFD0", Offset = "0xE3DFD0", VA = "0x180E3EFD0")]
	public void LoiteringConfront(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000705")]
	[Address(RVA = "0xE3F0C0", Offset = "0xE3E0C0", VA = "0x180E3F0C0")]
	public void FameAndFortune(Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000706")]
	[Address(RVA = "0xE3F720", Offset = "0xE3E720", VA = "0x180E3F720")]
	public ActionController()
	{
	}

	// Token: 0x0400071C RID: 1820
	[Token(Token = "0x400071C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<AIActionPreset> allActions;

	// Token: 0x0400071D RID: 1821
	[Token(Token = "0x400071D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<AIActionPreset, MethodInfo> actionRef;

	// Token: 0x0400071E RID: 1822
	[Token(Token = "0x400071E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[NonSerialized]
	private Interactable bargeDoor;

	// Token: 0x04000720 RID: 1824
	[Token(Token = "0x4000720")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ActionController _instance;

	// Token: 0x020000F5 RID: 245
	// (Invoke) Token: 0x06000708 RID: 1800
	[Token(Token = "0x20000F5")]
	public delegate void PlayerAction(AIActionPreset action, Interactable what, NewNode where, Actor who);

	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000F6")]
	private sealed class <>c__DisplayClass19_0
	{
		// Token: 0x0600070B RID: 1803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass19_0()
		{
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00004B90 File Offset: 0x00002D90
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x4774E0", Offset = "0x4764E0", VA = "0x1804774E0")]
		internal bool <PickUp>b__0(NewAIController.TrackingTarget item)
		{
			return default(bool);
		}

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Actor who;

		// Token: 0x04000722 RID: 1826
		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<NewAIController.TrackingTarget> <>9__0;
	}

	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600070E RID: 1806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x477740", Offset = "0x476740", VA = "0x180477740")]
		internal bool <TakeKey>b__35_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x477760", Offset = "0x476760", VA = "0x180477760")]
		internal bool <PassTime>b__65_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x477780", Offset = "0x476780", VA = "0x180477780")]
		internal bool <ActivateTimePass>b__68_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x4777A0", Offset = "0x4767A0", VA = "0x1804777A0")]
		internal bool <MakeCoffeeStart>b__87_0(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x477830", Offset = "0x476830", VA = "0x180477830")]
		internal bool <MakeCoffeeEnd>b__88_0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x4778D0", Offset = "0x4768D0", VA = "0x1804778D0")]
		internal bool <MakeCoffeeEnd>b__88_1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x477970", Offset = "0x476970", VA = "0x180477970")]
		internal bool <TurnOnHob>b__89_0(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x477A00", Offset = "0x476A00", VA = "0x180477A00")]
		internal bool <Dispose>b__95_0(EvidenceMultiPage.MultiPageContent item)
		{
			return default(bool);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x477A00", Offset = "0x476A00", VA = "0x180477A00")]
		internal bool <Dispose>b__95_1(EvidenceMultiPage.MultiPageContent item)
		{
			return default(bool);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x477A20", Offset = "0x476A20", VA = "0x180477A20")]
		internal bool <CallEnforcers>b__101_0(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x477AC0", Offset = "0x476AC0", VA = "0x180477AC0")]
		internal bool <TakeDetectiveStuff>b__121_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x477B00", Offset = "0x476B00", VA = "0x180477B00")]
		internal bool <Mugging>b__122_0(EvidenceWitness.DialogOption item)
		{
			return default(bool);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x477B90", Offset = "0x476B90", VA = "0x180477B90")]
		internal bool <DebtCollection>b__123_0(EvidenceWitness.DialogOption item)
		{
			return default(bool);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x477C20", Offset = "0x476C20", VA = "0x180477C20")]
		internal bool <FameAndFortune>b__131_0(EvidenceWitness.DialogOption item)
		{
			return default(bool);
		}

		// Token: 0x04000723 RID: 1827
		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ActionController.<>c <>9;

		// Token: 0x04000724 RID: 1828
		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Interactable.Passed> <>9__35_0;

		// Token: 0x04000725 RID: 1829
		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__65_0;

		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__68_0;

		// Token: 0x04000727 RID: 1831
		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<FurniturePreset.SubObject> <>9__87_0;

		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<Human.Trait> <>9__88_0;

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<Human.Trait> <>9__88_1;

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Predicate<FurniturePreset.SubObject> <>9__89_0;

		// Token: 0x0400072B RID: 1835
		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Predicate<EvidenceMultiPage.MultiPageContent> <>9__95_0;

		// Token: 0x0400072C RID: 1836
		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Predicate<EvidenceMultiPage.MultiPageContent> <>9__95_1;

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Predicate<NewAIGoal> <>9__101_0;

		// Token: 0x0400072E RID: 1838
		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__121_0;

		// Token: 0x0400072F RID: 1839
		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Predicate<EvidenceWitness.DialogOption> <>9__122_0;

		// Token: 0x04000730 RID: 1840
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Predicate<EvidenceWitness.DialogOption> <>9__123_0;

		// Token: 0x04000731 RID: 1841
		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static Predicate<EvidenceWitness.DialogOption> <>9__131_0;
	}

	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	private sealed class <_DialogInputBox>d__54 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600071D RID: 1821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <_DialogInputBox>d__54(int <>1__state)
		{
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x477CB0", Offset = "0x476CB0", VA = "0x180477CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002C")]
		private object Current
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x4782B0", Offset = "0x4772B0", VA = "0x1804782B0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002D")]
		private object Current
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000732 RID: 1842
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000733 RID: 1843
		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000734 RID: 1844
		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DialogPreset preset;

		// Token: 0x04000735 RID: 1845
		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ActionController <>4__this;

		// Token: 0x04000736 RID: 1846
		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Interactable what;

		// Token: 0x04000737 RID: 1847
		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public NewNode where;

		// Token: 0x04000738 RID: 1848
		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Actor who;

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DialogButtonController button;
	}

	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	private sealed class <>c__DisplayClass77_0
	{
		// Token: 0x06000723 RID: 1827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass77_0()
		{
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x478300", Offset = "0x477300", VA = "0x180478300")]
		internal bool <Search>b__0(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Interactable what;
	}

	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	private sealed class <AddFirstPersonItemDelay>d__83 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000725 RID: 1829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <AddFirstPersonItemDelay>d__83(int <>1__state)
		{
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00004D28 File Offset: 0x00002F28
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x4784C0", Offset = "0x4774C0", VA = "0x1804784C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002E")]
		private object Current
		{
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x478620", Offset = "0x477620", VA = "0x180478620", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002F")]
		private object Current
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400073C RID: 1852
		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400073D RID: 1853
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Interactable newInteractable;

		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <delay>5__2;
	}

	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	private sealed class <>c__DisplayClass96_0
	{
		// Token: 0x0600072B RID: 1835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass96_0()
		{
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x478670", Offset = "0x477670", VA = "0x180478670")]
		internal bool <PostJob>b__0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurniturePreset.SubObject so;
	}
}
