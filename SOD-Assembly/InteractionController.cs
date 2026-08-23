using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200033A RID: 826
[Token(Token = "0x200033A")]
public class InteractionController : MonoBehaviour
{
	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06001290 RID: 4752 RVA: 0x00008D78 File Offset: 0x00006F78
	// (set) Token: 0x06001291 RID: 4753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000A3")]
	public float interactionActionAmount
	{
		[Token(Token = "0x6001290")]
		[Address(RVA = "0x70EBD0", Offset = "0x70DBD0", VA = "0x18070EBD0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001291")]
		[Address(RVA = "0x70EBE0", Offset = "0x70DBE0", VA = "0x18070EBE0")]
		private set
		{
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06001293 RID: 4755 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001292 RID: 4754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000A4")]
	public Transform interactionActionLookAt
	{
		[Token(Token = "0x6001293")]
		[Address(RVA = "0x70EC50", Offset = "0x70DC50", VA = "0x18070EC50")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001292")]
		[Address(RVA = "0x70EBF0", Offset = "0x70DBF0", VA = "0x18070EBF0")]
		private set
		{
		}
	}

	// Token: 0x1400001B RID: 27
	// (add) Token: 0x06001294 RID: 4756 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001295 RID: 4757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400001B")]
	public event InteractionController.ReturnFromLockedIn OnReturnFromLockedIn
	{
		[Token(Token = "0x6001294")]
		[Address(RVA = "0x70EC60", Offset = "0x70DC60", VA = "0x18070EC60")]
		add
		{
		}
		[Token(Token = "0x6001295")]
		[Address(RVA = "0x70ED60", Offset = "0x70DD60", VA = "0x18070ED60")]
		remove
		{
		}
	}

	// Token: 0x1400001C RID: 28
	// (add) Token: 0x06001296 RID: 4758 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001297 RID: 4759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400001C")]
	public event InteractionController.InteractionActionCompleted OnInteractionActionCompleted
	{
		[Token(Token = "0x6001296")]
		[Address(RVA = "0x70EE60", Offset = "0x70DE60", VA = "0x18070EE60")]
		add
		{
		}
		[Token(Token = "0x6001297")]
		[Address(RVA = "0x70EF60", Offset = "0x70DF60", VA = "0x18070EF60")]
		remove
		{
		}
	}

	// Token: 0x1400001D RID: 29
	// (add) Token: 0x06001298 RID: 4760 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001299 RID: 4761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400001D")]
	public event InteractionController.InteractionActionProgressChange OnInteractionActionProgressChange
	{
		[Token(Token = "0x6001298")]
		[Address(RVA = "0x70F060", Offset = "0x70E060", VA = "0x18070F060")]
		add
		{
		}
		[Token(Token = "0x6001299")]
		[Address(RVA = "0x70F160", Offset = "0x70E160", VA = "0x18070F160")]
		remove
		{
		}
	}

	// Token: 0x1400001E RID: 30
	// (add) Token: 0x0600129A RID: 4762 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600129B RID: 4763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400001E")]
	public event InteractionController.InteractionActionLookedAway OnInteractionActionLookedAway
	{
		[Token(Token = "0x600129A")]
		[Address(RVA = "0x70F260", Offset = "0x70E260", VA = "0x18070F260")]
		add
		{
		}
		[Token(Token = "0x600129B")]
		[Address(RVA = "0x70F360", Offset = "0x70E360", VA = "0x18070F360")]
		remove
		{
		}
	}

	// Token: 0x1400001F RID: 31
	// (add) Token: 0x0600129C RID: 4764 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600129D RID: 4765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400001F")]
	public event InteractionController.InteractionActionCancelled OnInteractionActionCancelled
	{
		[Token(Token = "0x600129C")]
		[Address(RVA = "0x70F460", Offset = "0x70E460", VA = "0x18070F460")]
		add
		{
		}
		[Token(Token = "0x600129D")]
		[Address(RVA = "0x70F560", Offset = "0x70E560", VA = "0x18070F560")]
		remove
		{
		}
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x0600129E RID: 4766 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000A5")]
	public static InteractionController Instance
	{
		[Token(Token = "0x600129E")]
		[Address(RVA = "0x70F660", Offset = "0x70E660", VA = "0x18070F660")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600129F RID: 4767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600129F")]
	[Address(RVA = "0x70F6A0", Offset = "0x70E6A0", VA = "0x18070F6A0")]
	private void Awake()
	{
	}

	// Token: 0x060012A0 RID: 4768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012A0")]
	[Address(RVA = "0x70F9F0", Offset = "0x70E9F0", VA = "0x18070F9F0")]
	private void Start()
	{
	}

	// Token: 0x060012A1 RID: 4769 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012A1")]
	[Address(RVA = "0x70FF40", Offset = "0x70EF40", VA = "0x18070FF40")]
	private void Update()
	{
	}

	// Token: 0x060012A2 RID: 4770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012A2")]
	[Address(RVA = "0x7135F0", Offset = "0x7125F0", VA = "0x1807135F0")]
	public void StartDecorEdit()
	{
	}

	// Token: 0x060012A3 RID: 4771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012A3")]
	[Address(RVA = "0x713B10", Offset = "0x712B10", VA = "0x180713B10")]
	public void SetCurrentPlayerInteraction(InteractablePreset.InteractionKey key, Interactable newInteractable, Interactable.InteractableCurrentAction newCurrentAction, bool fpsItem = false, int forcePriority = -1)
	{
	}

	// Token: 0x060012A4 RID: 4772 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012A4")]
	[Address(RVA = "0x714E20", Offset = "0x713E20", VA = "0x180714E20")]
	public void DisplayInteractionCursor(bool val, bool forceUpdate = false)
	{
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012A5")]
	[Address(RVA = "0x716800", Offset = "0x715800", VA = "0x180716800")]
	public void AlignInteractionIcons()
	{
	}

	// Token: 0x060012A6 RID: 4774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012A6")]
	[Address(RVA = "0x716CD0", Offset = "0x715CD0", VA = "0x180716CD0")]
	public void SetDistanceRecognitionMode(bool val)
	{
	}

	// Token: 0x060012A7 RID: 4775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012A7")]
	[Address(RVA = "0x7171F0", Offset = "0x7161F0", VA = "0x1807171F0")]
	public void SetReadingMode(bool val, bool stopImmediately)
	{
	}

	// Token: 0x060012A8 RID: 4776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012A8")]
	[Address(RVA = "0x717610", Offset = "0x716610", VA = "0x180717610")]
	public void UpdateReadingModeText()
	{
	}

	// Token: 0x060012A9 RID: 4777 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012A9")]
	[Address(RVA = "0x7198C0", Offset = "0x7188C0", VA = "0x1807198C0")]
	private IEnumerator ReadingMode()
	{
		return null;
	}

	// Token: 0x060012AA RID: 4778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012AA")]
	[Address(RVA = "0x719960", Offset = "0x718960", VA = "0x180719960")]
	public void UpdateInteractionText()
	{
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012AB")]
	[Address(RVA = "0x71B330", Offset = "0x71A330", VA = "0x18071B330")]
	public void UpdateInteractionText(string newText)
	{
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012AC")]
	[Address(RVA = "0x71B650", Offset = "0x71A650", VA = "0x18071B650")]
	public void InteractionRaycastCheck()
	{
	}

	// Token: 0x060012AD RID: 4781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012AD")]
	[Address(RVA = "0x71CF40", Offset = "0x71BF40", VA = "0x18071CF40")]
	public void OnPlayerLookAtChange()
	{
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012AE")]
	[Address(RVA = "0x71E1F0", Offset = "0x71D1F0", VA = "0x18071E1F0")]
	public void OnPlayerLookAtInteractableChange()
	{
	}

	// Token: 0x060012AF RID: 4783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012AF")]
	[Address(RVA = "0x71E250", Offset = "0x71D250", VA = "0x18071E250")]
	public void SetLockedInInteractionMode(Interactable val, int reference = 0, bool dropCarriedCheck = true)
	{
	}

	// Token: 0x060012B0 RID: 4784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B0")]
	[Address(RVA = "0x71F520", Offset = "0x71E520", VA = "0x18071F520")]
	public void SetInteractionAction(float startingValue, float newThreshold, float increaseRate, string dictName, bool isIllegal, bool useLockpicks, Transform lookAtToComplete, bool cancelIfTooFar = true)
	{
	}

	// Token: 0x060012B1 RID: 4785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B1")]
	[Address(RVA = "0x720440", Offset = "0x71F440", VA = "0x180720440")]
	public void SetIllegalActionActive(bool val)
	{
	}

	// Token: 0x060012B2 RID: 4786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B2")]
	[Address(RVA = "0x720660", Offset = "0x71F660", VA = "0x180720660")]
	public void CancelInteractionAction()
	{
	}

	// Token: 0x060012B3 RID: 4787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B3")]
	[Address(RVA = "0x720970", Offset = "0x71F970", VA = "0x180720970")]
	public void CompleteInteractionAction()
	{
	}

	// Token: 0x060012B4 RID: 4788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B4")]
	[Address(RVA = "0x720CF0", Offset = "0x71FCF0", VA = "0x180720CF0")]
	private void OnDisable()
	{
	}

	// Token: 0x060012B5 RID: 4789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B5")]
	[Address(RVA = "0x720D60", Offset = "0x71FD60", VA = "0x180720D60")]
	public void PickUp(Interactable newObj)
	{
	}

	// Token: 0x060012B6 RID: 4790 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B6")]
	[Address(RVA = "0x721070", Offset = "0x720070", VA = "0x180721070")]
	public void SetDialog(bool val, Interactable newTalkingTo, bool newIsRemote = false, [Optional] Interactable newRemoteOverrideInteractable, InteractionController.ConversationType newConvoType = InteractionController.ConversationType.normal)
	{
	}

	// Token: 0x060012B7 RID: 4791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B7")]
	[Address(RVA = "0x7220E0", Offset = "0x7210E0", VA = "0x1807220E0")]
	public void RefreshDialogOptions()
	{
	}

	// Token: 0x060012B8 RID: 4792 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B8")]
	[Address(RVA = "0x723450", Offset = "0x722450", VA = "0x180723450")]
	public void SetDialogSelection(int newVal)
	{
	}

	// Token: 0x060012B9 RID: 4793 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B9")]
	[Address(RVA = "0x723A50", Offset = "0x722A50", VA = "0x180723A50")]
	public void OnSabotage(Interactable inter)
	{
	}

	// Token: 0x060012BA RID: 4794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012BA")]
	[Address(RVA = "0x7244D0", Offset = "0x7234D0", VA = "0x1807244D0")]
	public void OnSabotageProgressChange(float amountChangeThisFrame, float amountToal)
	{
	}

	// Token: 0x060012BB RID: 4795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012BB")]
	[Address(RVA = "0x724790", Offset = "0x723790", VA = "0x180724790")]
	public void OnCompleteSabotage()
	{
	}

	// Token: 0x060012BC RID: 4796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012BC")]
	[Address(RVA = "0x724B20", Offset = "0x723B20", VA = "0x180724B20")]
	public void OnReturnFromSabotage()
	{
	}

	// Token: 0x060012BD RID: 4797 RVA: 0x00008D90 File Offset: 0x00006F90
	[Token(Token = "0x60012BD")]
	[Address(RVA = "0x725090", Offset = "0x724090", VA = "0x180725090")]
	public bool GetValidPlayerActionIllegal(Interactable inter, NewNode location, bool allowPublic = true, bool illegalIfNotPlayersHome = true)
	{
		return default(bool);
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012BE")]
	[Address(RVA = "0x725BA0", Offset = "0x724BA0", VA = "0x180725BA0")]
	public void UpdateNearbyInteractables()
	{
	}

	// Token: 0x060012BF RID: 4799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012BF")]
	[Address(RVA = "0x726EC0", Offset = "0x725EC0", VA = "0x180726EC0")]
	public void ClearNearbyInteractables()
	{
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012C0")]
	[Address(RVA = "0x726F30", Offset = "0x725F30", VA = "0x180726F30")]
	private List<Interactable> GetValidNearbyInteractables(NewNode node)
	{
		return null;
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C1")]
	[Address(RVA = "0x7278C0", Offset = "0x7268C0", VA = "0x1807278C0")]
	public void FocusOnInteractable(Interactable interactable)
	{
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C2")]
	[Address(RVA = "0x727B90", Offset = "0x726B90", VA = "0x180727B90")]
	public void UpdateInteractionIcons()
	{
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C3")]
	[Address(RVA = "0x727FC0", Offset = "0x726FC0", VA = "0x180727FC0")]
	public void UpdateHighlightedInteractionIcon()
	{
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012C4")]
	[Address(RVA = "0x728250", Offset = "0x727250", VA = "0x180728250")]
	public InteractionController()
	{
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x00008DA8 File Offset: 0x00006FA8
	[Token(Token = "0x60012C5")]
	[Address(RVA = "0x728980", Offset = "0x727980", VA = "0x180728980")]
	private bool <UpdateReadingModeText>b__103_3(BookPreset item)
	{
		return default(bool);
	}

	// Token: 0x060012C6 RID: 4806 RVA: 0x00008DC0 File Offset: 0x00006FC0
	[Token(Token = "0x60012C6")]
	[Address(RVA = "0x728980", Offset = "0x727980", VA = "0x180728980")]
	private bool <UpdateReadingModeText>b__103_4(BookPreset item)
	{
		return default(bool);
	}

	// Token: 0x04001726 RID: 5926
	[Token(Token = "0x4001726")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<InteractablePreset.InteractionKey, InteractionController.InteractionSetting> currentInteractions;

	// Token: 0x04001727 RID: 5927
	[Token(Token = "0x4001727")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<InteractablePreset.InteractionKey> allInteractionKeys;

	// Token: 0x04001728 RID: 5928
	[Token(Token = "0x4001728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Interactable> nearbyInteractables;

	// Token: 0x04001729 RID: 5929
	[Token(Token = "0x4001729")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<SelectionIconController> selectionIcons;

	// Token: 0x0400172A RID: 5930
	[Token(Token = "0x400172A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int nearbyInteractablesHint;

	// Token: 0x0400172B RID: 5931
	[Token(Token = "0x400172B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float inputCooldown;

	// Token: 0x0400172C RID: 5932
	[Token(Token = "0x400172C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool lookingAtInteractable;

	// Token: 0x0400172D RID: 5933
	[Token(Token = "0x400172D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool displayingInteraction;

	// Token: 0x0400172E RID: 5934
	[Token(Token = "0x400172E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private InteractableController previousLookingAtInteractable;

	// Token: 0x0400172F RID: 5935
	[Token(Token = "0x400172F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public InteractableController currentLookingAtInteractable;

	// Token: 0x04001730 RID: 5936
	[Token(Token = "0x4001730")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform currentLookAtTransform;

	// Token: 0x04001731 RID: 5937
	[Token(Token = "0x4001731")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private InteractableController currentLookingAtReadingRange;

	// Token: 0x04001732 RID: 5938
	[Token(Token = "0x4001732")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public InteractableController currentInteractable;

	// Token: 0x04001733 RID: 5939
	[Token(Token = "0x4001733")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool interactionMode;

	// Token: 0x04001734 RID: 5940
	[Token(Token = "0x4001734")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	public bool distanceRecognitionMode;

	// Token: 0x04001735 RID: 5941
	[Token(Token = "0x4001735")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
	public bool readingMode;

	// Token: 0x04001736 RID: 5942
	[Token(Token = "0x4001736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float readingModeTransition;

	// Token: 0x04001737 RID: 5943
	[Token(Token = "0x4001737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Coroutine readingModeCoroutine;

	// Token: 0x04001738 RID: 5944
	[Token(Token = "0x4001738")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float interactionAnimationModifier;

	// Token: 0x04001739 RID: 5945
	[Token(Token = "0x4001739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float interactionLookProgress;

	// Token: 0x0400173A RID: 5946
	[Token(Token = "0x400173A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public InteractableController carryingObject;

	// Token: 0x0400173B RID: 5947
	[Token(Token = "0x400173B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<NewDoor> addedToDoorInteractionList;

	// Token: 0x0400173C RID: 5948
	[Token(Token = "0x400173C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public RigidbodyDragObject currentlyDragging;

	// Token: 0x0400173D RID: 5949
	[Token(Token = "0x400173D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private RaycastHit playerPreviousRaycastHit;

	// Token: 0x0400173E RID: 5950
	[Token(Token = "0x400173E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[NonSerialized]
	public RaycastHit playerCurrentRaycastHit;

	// Token: 0x0400173F RID: 5951
	[Token(Token = "0x400173F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[NonSerialized]
	public Interactable lockedInInteraction;

	// Token: 0x04001740 RID: 5952
	[Token(Token = "0x4001740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public int lockedInInteractionRef;

	// Token: 0x04001741 RID: 5953
	[Token(Token = "0x4001741")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[NonSerialized]
	public Interactable hideInteractable;

	// Token: 0x04001742 RID: 5954
	[Token(Token = "0x4001742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public bool activeInteractionAction;

	// Token: 0x04001743 RID: 5955
	[Token(Token = "0x4001743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private float <interactionActionAmount>k__BackingField;

	// Token: 0x04001744 RID: 5956
	[Token(Token = "0x4001744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private float interactionActionThreshold;

	// Token: 0x04001745 RID: 5957
	[Token(Token = "0x4001745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private float interactionActionMultiplier;

	// Token: 0x04001746 RID: 5958
	[Token(Token = "0x4001746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public string interactionActionName;

	// Token: 0x04001747 RID: 5959
	[Token(Token = "0x4001747")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Transform <interactionActionLookAt>k__BackingField;

	// Token: 0x04001748 RID: 5960
	[Token(Token = "0x4001748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private bool activeInteractionActionLookCheck;

	// Token: 0x04001749 RID: 5961
	[Token(Token = "0x4001749")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
	private bool canFailLookCheck;

	// Token: 0x0400174A RID: 5962
	[Token(Token = "0x400174A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public GameObject lockpickGraphics;

	// Token: 0x0400174B RID: 5963
	[Token(Token = "0x400174B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private bool cancelInteractionIfOutOfRange;

	// Token: 0x0400174C RID: 5964
	[Token(Token = "0x400174C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private float lastLookAtForInteraction;

	// Token: 0x0400174D RID: 5965
	[Token(Token = "0x400174D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Dictionary<Interactable, float> discoveryOverTime;

	// Token: 0x0400174E RID: 5966
	[Token(Token = "0x400174E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public Dictionary<Evidence, float> discoveryOverTimeEvidence;

	// Token: 0x0400174F RID: 5967
	[Token(Token = "0x400174F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Dictionary<MetaObject, float> discoveryOverTimeMeta;

	// Token: 0x04001750 RID: 5968
	[Token(Token = "0x4001750")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public Dictionary<EvidenceMultiPage.MultiPageContent, float> discoveryOverTimeDiscovery;

	// Token: 0x04001751 RID: 5969
	[Token(Token = "0x4001751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public List<LockpickProgressController> spawnedProgressControllers;

	// Token: 0x04001752 RID: 5970
	[Token(Token = "0x4001752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Interactable sabotageInteractable;

	// Token: 0x04001753 RID: 5971
	[Token(Token = "0x4001753")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public bool dialogMode;

	// Token: 0x04001754 RID: 5972
	[Token(Token = "0x4001754")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x179")]
	public bool isRemote;

	// Token: 0x04001755 RID: 5973
	[Token(Token = "0x4001755")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	public float dialogTransition;

	// Token: 0x04001756 RID: 5974
	[Token(Token = "0x4001756")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public InteractionController.ConversationType dialogType;

	// Token: 0x04001757 RID: 5975
	[Token(Token = "0x4001757")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public TextMeshProUGUI citizenNameText;

	// Token: 0x04001758 RID: 5976
	[Token(Token = "0x4001758")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[NonSerialized]
	public Interactable talkingTo;

	// Token: 0x04001759 RID: 5977
	[Token(Token = "0x4001759")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[NonSerialized]
	public Interactable remoteOverride;

	// Token: 0x0400175A RID: 5978
	[Token(Token = "0x400175A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public List<DialogButtonController> dialogOptions;

	// Token: 0x0400175B RID: 5979
	[Token(Token = "0x400175B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public int dialogSelection;

	// Token: 0x0400175C RID: 5980
	[Token(Token = "0x400175C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public RectTransform moreOptionsScrollUpArrow;

	// Token: 0x0400175D RID: 5981
	[Token(Token = "0x400175D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public RectTransform moreOptionsScrollDownArrow;

	// Token: 0x0400175E RID: 5982
	[Token(Token = "0x400175E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public Human mugger;

	// Token: 0x0400175F RID: 5983
	[Token(Token = "0x400175F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public Human debtCollector;

	// Token: 0x04001760 RID: 5984
	[Token(Token = "0x4001760")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public Human fameAndFortune;

	// Token: 0x04001761 RID: 5985
	[Token(Token = "0x4001761")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public bool inOut;

	// Token: 0x04001762 RID: 5986
	[Token(Token = "0x4001762")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	public float inOutProgress;

	// Token: 0x04001763 RID: 5987
	[Token(Token = "0x4001763")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public float displayProgress;

	// Token: 0x04001764 RID: 5988
	[Token(Token = "0x4001764")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private AudioController.LoopingSoundInfo lockpickLoop;

	// Token: 0x0400176A RID: 5994
	[Token(Token = "0x400176A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static InteractionController _instance;

	// Token: 0x0200033B RID: 827
	[Token(Token = "0x200033B")]
	public class InteractionSetting
	{
		// Token: 0x060012C7 RID: 4807 RVA: 0x00008DD8 File Offset: 0x00006FD8
		[Token(Token = "0x60012C7")]
		[Address(RVA = "0x78FD30", Offset = "0x78ED30", VA = "0x18078FD30")]
		public int GetActionCost()
		{
			return 0;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public InteractionSetting()
		{
		}

		// Token: 0x0400176B RID: 5995
		[Token(Token = "0x400176B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractablePreset.InteractionAction currentAction;

		// Token: 0x0400176C RID: 5996
		[Token(Token = "0x400176C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Interactable.InteractableCurrentAction currentSetting;

		// Token: 0x0400176D RID: 5997
		[Token(Token = "0x400176D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Interactable interactable;

		// Token: 0x0400176E RID: 5998
		[Token(Token = "0x400176E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isFPSItem;

		// Token: 0x0400176F RID: 5999
		[Token(Token = "0x400176F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEvent audioEvent;

		// Token: 0x04001770 RID: 6000
		[Token(Token = "0x4001770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int priority;

		// Token: 0x04001771 RID: 6001
		[Token(Token = "0x4001771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string actionText;

		// Token: 0x04001772 RID: 6002
		[Token(Token = "0x4001772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ControlDisplayController newUIRef;
	}

	// Token: 0x0200033C RID: 828
	[Token(Token = "0x200033C")]
	public enum ConversationType
	{
		// Token: 0x04001774 RID: 6004
		[Token(Token = "0x4001774")]
		normal,
		// Token: 0x04001775 RID: 6005
		[Token(Token = "0x4001775")]
		mugging,
		// Token: 0x04001776 RID: 6006
		[Token(Token = "0x4001776")]
		loanSharkVisit,
		// Token: 0x04001777 RID: 6007
		[Token(Token = "0x4001777")]
		accuseMurderer,
		// Token: 0x04001778 RID: 6008
		[Token(Token = "0x4001778")]
		killerCleanUp,
		// Token: 0x04001779 RID: 6009
		[Token(Token = "0x4001779")]
		fameAndFortune
	}

	// Token: 0x0200033D RID: 829
	// (Invoke) Token: 0x060012CA RID: 4810
	[Token(Token = "0x200033D")]
	public delegate void ReturnFromLockedIn();

	// Token: 0x0200033E RID: 830
	// (Invoke) Token: 0x060012CE RID: 4814
	[Token(Token = "0x200033E")]
	public delegate void InteractionActionCompleted();

	// Token: 0x0200033F RID: 831
	// (Invoke) Token: 0x060012D2 RID: 4818
	[Token(Token = "0x200033F")]
	public delegate void InteractionActionProgressChange(float amountThisFrame, float amountTotal);

	// Token: 0x02000340 RID: 832
	// (Invoke) Token: 0x060012D6 RID: 4822
	[Token(Token = "0x2000340")]
	public delegate void InteractionActionLookedAway();

	// Token: 0x02000341 RID: 833
	// (Invoke) Token: 0x060012DA RID: 4826
	[Token(Token = "0x2000341")]
	public delegate void InteractionActionCancelled();

	// Token: 0x02000342 RID: 834
	[Token(Token = "0x2000342")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060012DE RID: 4830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00008DF0 File Offset: 0x00006FF0
		[Token(Token = "0x60012DF")]
		[Address(RVA = "0x790000", Offset = "0x78F000", VA = "0x180790000")]
		internal bool <StartDecorEdit>b__97_0(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00008E08 File Offset: 0x00007008
		[Token(Token = "0x60012E0")]
		[Address(RVA = "0x790090", Offset = "0x78F090", VA = "0x180790090")]
		internal bool <UpdateReadingModeText>b__103_0(DDSSaveClasses.DDSBlockCondition item)
		{
			return default(bool);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00008E20 File Offset: 0x00007020
		[Token(Token = "0x60012E1")]
		[Address(RVA = "0x7900B0", Offset = "0x78F0B0", VA = "0x1807900B0")]
		internal bool <UpdateReadingModeText>b__103_1(DDSSaveClasses.DDSBlockCondition item)
		{
			return default(bool);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00008E38 File Offset: 0x00007038
		[Token(Token = "0x60012E2")]
		[Address(RVA = "0x7900D0", Offset = "0x78F0D0", VA = "0x1807900D0")]
		internal bool <UpdateReadingModeText>b__103_2(DDSSaveClasses.DDSBlockCondition item)
		{
			return default(bool);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00008E50 File Offset: 0x00007050
		[Token(Token = "0x60012E3")]
		[Address(RVA = "0x7900F0", Offset = "0x78F0F0", VA = "0x1807900F0")]
		internal bool <UpdateReadingModeText>b__103_5(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00008E68 File Offset: 0x00007068
		[Token(Token = "0x60012E4")]
		[Address(RVA = "0x7901F0", Offset = "0x78F1F0", VA = "0x1807901F0")]
		internal bool <InteractionRaycastCheck>b__107_0(NewAIController.TrackingTarget item)
		{
			return default(bool);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00008E80 File Offset: 0x00007080
		[Token(Token = "0x60012E5")]
		[Address(RVA = "0x790320", Offset = "0x78F320", VA = "0x180790320")]
		internal bool <SetLockedInInteractionMode>b__110_0(InteractableActionsPreset item)
		{
			return default(bool);
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00008E98 File Offset: 0x00007098
		[Token(Token = "0x60012E6")]
		[Address(RVA = "0x790340", Offset = "0x78F340", VA = "0x180790340")]
		internal int <RefreshDialogOptions>b__118_0(EvidenceWitness.DialogOption p1, EvidenceWitness.DialogOption p2)
		{
			return 0;
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00008EB0 File Offset: 0x000070B0
		[Token(Token = "0x60012E7")]
		[Address(RVA = "0x790390", Offset = "0x78F390", VA = "0x180790390")]
		internal int <UpdateNearbyInteractables>b__125_0(Interactable p1, Interactable p2)
		{
			return 0;
		}

		// Token: 0x0400177A RID: 6010
		[Token(Token = "0x400177A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly InteractionController.<>c <>9;

		// Token: 0x0400177B RID: 6011
		[Token(Token = "0x400177B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<InfoWindow> <>9__97_0;

		// Token: 0x0400177C RID: 6012
		[Token(Token = "0x400177C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<DDSSaveClasses.DDSBlockCondition> <>9__103_0;

		// Token: 0x0400177D RID: 6013
		[Token(Token = "0x400177D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<DDSSaveClasses.DDSBlockCondition> <>9__103_1;

		// Token: 0x0400177E RID: 6014
		[Token(Token = "0x400177E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<DDSSaveClasses.DDSBlockCondition> <>9__103_2;

		// Token: 0x0400177F RID: 6015
		[Token(Token = "0x400177F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<Interactable> <>9__103_5;

		// Token: 0x04001780 RID: 6016
		[Token(Token = "0x4001780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<NewAIController.TrackingTarget> <>9__107_0;

		// Token: 0x04001781 RID: 6017
		[Token(Token = "0x4001781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Predicate<InteractableActionsPreset> <>9__110_0;

		// Token: 0x04001782 RID: 6018
		[Token(Token = "0x4001782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Comparison<EvidenceWitness.DialogOption> <>9__118_0;

		// Token: 0x04001783 RID: 6019
		[Token(Token = "0x4001783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Comparison<Interactable> <>9__125_0;
	}

	// Token: 0x02000343 RID: 835
	[Token(Token = "0x2000343")]
	private sealed class <>c__DisplayClass104_0
	{
		// Token: 0x060012E8 RID: 4840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass104_0()
		{
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00008EC8 File Offset: 0x000070C8
		[Token(Token = "0x60012E9")]
		[Address(RVA = "0x790820", Offset = "0x78F820", VA = "0x180790820")]
		internal bool <ReadingMode>b__0(EvidenceMultiPage.MultiPageContent item)
		{
			return default(bool);
		}

		// Token: 0x04001784 RID: 6020
		[Token(Token = "0x4001784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EvidenceMultiPage pageEv;
	}

	// Token: 0x02000344 RID: 836
	[Token(Token = "0x2000344")]
	private sealed class <ReadingMode>d__104 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060012EA RID: 4842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EA")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <ReadingMode>d__104(int <>1__state)
		{
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00008EE0 File Offset: 0x000070E0
		[Token(Token = "0x60012EC")]
		[Address(RVA = "0x790870", Offset = "0x78F870", VA = "0x180790870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000A6")]
		private object Current
		{
			[Token(Token = "0x60012ED")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EE")]
		[Address(RVA = "0x7917A0", Offset = "0x7907A0", VA = "0x1807917A0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000A7")]
		private object Current
		{
			[Token(Token = "0x60012EF")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001785 RID: 6021
		[Token(Token = "0x4001785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001786 RID: 6022
		[Token(Token = "0x4001786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001787 RID: 6023
		[Token(Token = "0x4001787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionController <>4__this;

		// Token: 0x04001788 RID: 6024
		[Token(Token = "0x4001788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <displayPage>5__2;
	}

	// Token: 0x02000345 RID: 837
	[Token(Token = "0x2000345")]
	private sealed class <>c__DisplayClass105_0
	{
		// Token: 0x060012F0 RID: 4848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass105_0()
		{
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00008EF8 File Offset: 0x000070F8
		[Token(Token = "0x60012F1")]
		[Address(RVA = "0x7917F0", Offset = "0x7907F0", VA = "0x1807917F0")]
		internal bool <UpdateInteractionText>b__0(ControlsDisplayController.CustomActionsDisplayed item)
		{
			return default(bool);
		}

		// Token: 0x04001789 RID: 6025
		[Token(Token = "0x4001789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractablePreset.InteractionKey key;
	}
}
