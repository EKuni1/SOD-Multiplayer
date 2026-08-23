using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003CB RID: 971
[Token(Token = "0x20003CB")]
public class NewDoor : MonoBehaviour
{
	// Token: 0x060015AC RID: 5548 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015AC")]
	[Address(RVA = "0x80E540", Offset = "0x80D540", VA = "0x18080E540")]
	public void Setup(NewWall newParent)
	{
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015AD")]
	[Address(RVA = "0x80FA40", Offset = "0x80EA40", VA = "0x18080FA40")]
	public void PlaceKeys()
	{
	}

	// Token: 0x060015AE RID: 5550 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015AE")]
	[Address(RVA = "0x8105F0", Offset = "0x80F5F0", VA = "0x1808105F0")]
	private void GetPreset()
	{
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015AF")]
	[Address(RVA = "0x811160", Offset = "0x810160", VA = "0x180811160")]
	public void SelectColouring(bool overrideWithKey = false, [Optional] Toolbox.MaterialKey keyOverride)
	{
	}

	// Token: 0x060015B0 RID: 5552 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015B0")]
	[Address(RVA = "0x811CE0", Offset = "0x810CE0", VA = "0x180811CE0")]
	public void SpawnDoor()
	{
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015B1")]
	[Address(RVA = "0x8140E0", Offset = "0x8130E0", VA = "0x1808140E0")]
	private void UpdateMapDoor(bool updateIfDoorIsCulled = false)
	{
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015B2")]
	[Address(RVA = "0x814530", Offset = "0x813530", VA = "0x180814530")]
	public void UpdateNameBasedOnPlayerPosition()
	{
	}

	// Token: 0x060015B3 RID: 5555 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015B3")]
	[Address(RVA = "0x814880", Offset = "0x813880", VA = "0x180814880")]
	private NewNode GetBehindNode()
	{
		return null;
	}

	// Token: 0x060015B4 RID: 5556 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015B4")]
	[Address(RVA = "0x814B10", Offset = "0x813B10", VA = "0x180814B10")]
	private NewNode GetInfontNode()
	{
		return null;
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015B5")]
	[Address(RVA = "0x814DA0", Offset = "0x813DA0", VA = "0x180814DA0")]
	public string GetNameForParent()
	{
		return null;
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015B6")]
	[Address(RVA = "0x814DE0", Offset = "0x813DE0", VA = "0x180814DE0")]
	public string GetName()
	{
		return null;
	}

	// Token: 0x060015B7 RID: 5559 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015B7")]
	[Address(RVA = "0x8150A0", Offset = "0x8140A0", VA = "0x1808150A0")]
	public void ParentToRoom(NewRoom newRoom)
	{
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015B8")]
	[Address(RVA = "0x815760", Offset = "0x814760", VA = "0x180815760")]
	public void SetKnowLockedStatus(bool val)
	{
	}

	// Token: 0x060015B9 RID: 5561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015B9")]
	[Address(RVA = "0x815C20", Offset = "0x814C20", VA = "0x180815C20")]
	public void SetPlayerHasKey(bool val)
	{
	}

	// Token: 0x060015BA RID: 5562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015BA")]
	[Address(RVA = "0x815D10", Offset = "0x814D10", VA = "0x180815D10")]
	public void OpenByActor(Actor actor, bool forceInverseOpenDirection = false, float speedMultiplier = 1f)
	{
	}

	// Token: 0x060015BB RID: 5563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015BB")]
	[Address(RVA = "0x816320", Offset = "0x815320", VA = "0x180816320")]
	public void SetOpen(float newAjar, Actor actor, bool skipAnimation = false, float speedMultiplier = 1f)
	{
	}

	// Token: 0x060015BC RID: 5564 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015BC")]
	[Address(RVA = "0x817220", Offset = "0x816220", VA = "0x180817220")]
	private void OnEnable()
	{
	}

	// Token: 0x060015BD RID: 5565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015BD")]
	[Address(RVA = "0x817230", Offset = "0x816230", VA = "0x180817230")]
	private void OnDisable()
	{
	}

	// Token: 0x060015BE RID: 5566 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015BE")]
	[Address(RVA = "0x817930", Offset = "0x816930", VA = "0x180817930")]
	private IEnumerator OpenDoor(Actor actor, float speedMultiplier)
	{
		return null;
	}

	// Token: 0x060015BF RID: 5567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015BF")]
	[Address(RVA = "0x817A50", Offset = "0x816A50", VA = "0x180817A50")]
	public void OnClose(Actor actor)
	{
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C0")]
	[Address(RVA = "0x818640", Offset = "0x817640", VA = "0x180818640")]
	public void SetCollisionsWithPlayerActive(bool val)
	{
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C1")]
	[Address(RVA = "0x8189E0", Offset = "0x8179E0", VA = "0x1808189E0")]
	public void OnOpen(Actor actor)
	{
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C2")]
	[Address(RVA = "0x819140", Offset = "0x818140", VA = "0x180819140")]
	public void SetLocked(bool val, Actor actor, bool playSound = true)
	{
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C3")]
	[Address(RVA = "0x8198D0", Offset = "0x8188D0", VA = "0x1808198D0")]
	public void SetJammed(bool val, [Optional] Interactable doorWedgeUsed, bool createUsedWedge = true)
	{
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C4")]
	[Address(RVA = "0x819C00", Offset = "0x818C00", VA = "0x180819C00")]
	public void SetForbidden(bool val)
	{
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C5")]
	[Address(RVA = "0x81A040", Offset = "0x819040", VA = "0x18081A040")]
	public void SetPoliceTape(bool policeTapActive)
	{
	}

	// Token: 0x060015C6 RID: 5574 RVA: 0x0000A260 File Offset: 0x00008460
	[Token(Token = "0x60015C6")]
	[Address(RVA = "0x81A400", Offset = "0x819400", VA = "0x18081A400")]
	public bool CitizenPassCheck(Human cc, out NewDoor.CitizenPassResult reason)
	{
		return default(bool);
	}

	// Token: 0x060015C7 RID: 5575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C7")]
	[Address(RVA = "0x81A950", Offset = "0x819950", VA = "0x18081A950")]
	public void Barge(Actor barger)
	{
	}

	// Token: 0x060015C8 RID: 5576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C8")]
	[Address(RVA = "0x81C120", Offset = "0x81B120", VA = "0x18081C120")]
	public void OnKnock(Actor actor, int knockCount = 2, float forceAdditionalUrgency = 0f)
	{
	}

	// Token: 0x060015C9 RID: 5577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C9")]
	[Address(RVA = "0x81C1D0", Offset = "0x81B1D0", VA = "0x18081C1D0")]
	public void OnDoorPeek()
	{
	}

	// Token: 0x060015CA RID: 5578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015CA")]
	[Address(RVA = "0x81CC40", Offset = "0x81BC40", VA = "0x18081CC40")]
	public void OnReturnFromPeek()
	{
	}

	// Token: 0x060015CB RID: 5579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015CB")]
	[Address(RVA = "0x81D130", Offset = "0x81C130", VA = "0x18081D130")]
	public void OnLockpick()
	{
	}

	// Token: 0x060015CC RID: 5580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015CC")]
	[Address(RVA = "0x81D890", Offset = "0x81C890", VA = "0x18081D890")]
	public void OnLockpickLookedAway()
	{
	}

	// Token: 0x060015CD RID: 5581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015CD")]
	[Address(RVA = "0x81D900", Offset = "0x81C900", VA = "0x18081D900")]
	public void OnLockpickProgressChange(float amountChangeThisFrame, float amountToal)
	{
	}

	// Token: 0x060015CE RID: 5582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015CE")]
	[Address(RVA = "0x81DD40", Offset = "0x81CD40", VA = "0x18081DD40")]
	public void OnCompleteLockpick()
	{
	}

	// Token: 0x060015CF RID: 5583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015CF")]
	[Address(RVA = "0x81E0E0", Offset = "0x81D0E0", VA = "0x18081E0E0")]
	public void OnReturnFromLockpick()
	{
	}

	// Token: 0x060015D0 RID: 5584 RVA: 0x0000A278 File Offset: 0x00008478
	[Token(Token = "0x60015D0")]
	[Address(RVA = "0x81E6B0", Offset = "0x81D6B0", VA = "0x18081E6B0")]
	public bool GetDefaultLockState()
	{
		return default(bool);
	}

	// Token: 0x060015D1 RID: 5585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015D1")]
	[Address(RVA = "0x81EFB0", Offset = "0x81DFB0", VA = "0x18081EFB0")]
	public void DebugTestPlayersRelativePosition()
	{
	}

	// Token: 0x060015D2 RID: 5586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015D2")]
	[Address(RVA = "0x81F1C0", Offset = "0x81E1C0", VA = "0x18081F1C0")]
	public NewDoor()
	{
	}

	// Token: 0x060015D3 RID: 5587 RVA: 0x0000A290 File Offset: 0x00008490
	[Token(Token = "0x60015D3")]
	[Address(RVA = "0x81F590", Offset = "0x81E590", VA = "0x18081F590")]
	private bool <CitizenPassCheck>b__77_0(NewNode.NodeAccess item)
	{
		return default(bool);
	}

	// Token: 0x04001A32 RID: 6706
	[Token(Token = "0x4001A32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public NewWall wall;

	// Token: 0x04001A33 RID: 6707
	[Token(Token = "0x4001A33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public NewRoom playerRoom;

	// Token: 0x04001A34 RID: 6708
	[Token(Token = "0x4001A34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public NewWall parentedWall;

	// Token: 0x04001A35 RID: 6709
	[Token(Token = "0x4001A35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public DoorPairPreset doorPairPreset;

	// Token: 0x04001A36 RID: 6710
	[Token(Token = "0x4001A36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public DoorPreset preset;

	// Token: 0x04001A37 RID: 6711
	[Token(Token = "0x4001A37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject spawnedDoor;

	// Token: 0x04001A38 RID: 6712
	[Token(Token = "0x4001A38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Collider> spawnedDoorColliders;

	// Token: 0x04001A39 RID: 6713
	[Token(Token = "0x4001A39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[NonSerialized]
	public Interactable doorInteractable;

	// Token: 0x04001A3A RID: 6714
	[Token(Token = "0x4001A3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[NonSerialized]
	public Interactable handleInteractable;

	// Token: 0x04001A3B RID: 6715
	[Token(Token = "0x4001A3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[NonSerialized]
	public Interactable peekInteractable;

	// Token: 0x04001A3C RID: 6716
	[Token(Token = "0x4001A3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RectTransform mapDoorObject;

	// Token: 0x04001A3D RID: 6717
	[Token(Token = "0x4001A3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject doorSignFront;

	// Token: 0x04001A3E RID: 6718
	[Token(Token = "0x4001A3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject doorSignRear;

	// Token: 0x04001A3F RID: 6719
	[Token(Token = "0x4001A3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public InteractableController doorInteractableController;

	// Token: 0x04001A40 RID: 6720
	[Token(Token = "0x4001A40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public InteractableController doorHandleInteractableController;

	// Token: 0x04001A41 RID: 6721
	[Token(Token = "0x4001A41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public InteractableController peekInteractableController;

	// Token: 0x04001A42 RID: 6722
	[Token(Token = "0x4001A42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject policeTape;

	// Token: 0x04001A43 RID: 6723
	[Token(Token = "0x4001A43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool policeTapeSpawned;

	// Token: 0x04001A44 RID: 6724
	[Token(Token = "0x4001A44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float ajar;

	// Token: 0x04001A45 RID: 6725
	[Token(Token = "0x4001A45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool isClosed;

	// Token: 0x04001A46 RID: 6726
	[Token(Token = "0x4001A46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	public bool isClosing;

	// Token: 0x04001A47 RID: 6727
	[Token(Token = "0x4001A47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float ajarProgress;

	// Token: 0x04001A48 RID: 6728
	[Token(Token = "0x4001A48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float doorOpenSpeed;

	// Token: 0x04001A49 RID: 6729
	[Token(Token = "0x4001A49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public bool animating;

	// Token: 0x04001A4A RID: 6730
	[Token(Token = "0x4001A4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public NewDoor.DoorSetting doorSetting;

	// Token: 0x04001A4B RID: 6731
	[Token(Token = "0x4001A4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public NewDoor.LockSetting lockSetting;

	// Token: 0x04001A4C RID: 6732
	[Token(Token = "0x4001A4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public HashSet<Actor> usingDoorList;

	// Token: 0x04001A4D RID: 6733
	[Token(Token = "0x4001A4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool peekedUnder;

	// Token: 0x04001A4E RID: 6734
	[Token(Token = "0x4001A4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	public bool otherSideIsTrespassing;

	// Token: 0x04001A4F RID: 6735
	[Token(Token = "0x4001A4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public int otherSideTrespassingEscalation;

	// Token: 0x04001A50 RID: 6736
	[Token(Token = "0x4001A50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private NewRoom playerOtherSideRoom;

	// Token: 0x04001A51 RID: 6737
	[Token(Token = "0x4001A51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public float desiredAngle;

	// Token: 0x04001A52 RID: 6738
	[Token(Token = "0x4001A52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public float openAngle;

	// Token: 0x04001A53 RID: 6739
	[Token(Token = "0x4001A53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public bool isLocked;

	// Token: 0x04001A54 RID: 6740
	[Token(Token = "0x4001A54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
	public bool isJammed;

	// Token: 0x04001A55 RID: 6741
	[Token(Token = "0x4001A55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[NonSerialized]
	public Interactable doorWedge;

	// Token: 0x04001A56 RID: 6742
	[Token(Token = "0x4001A56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public bool forbiddenForPublic;

	// Token: 0x04001A57 RID: 6743
	[Token(Token = "0x4001A57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
	public bool knowLockStatus;

	// Token: 0x04001A58 RID: 6744
	[Token(Token = "0x4001A58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
	public bool knockingInProgress;

	// Token: 0x04001A59 RID: 6745
	[Token(Token = "0x4001A59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF3")]
	public bool featuresNeonSign;

	// Token: 0x04001A5A RID: 6746
	[Token(Token = "0x4001A5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[NonSerialized]
	public Interactable lockInteractableFront;

	// Token: 0x04001A5B RID: 6747
	[Token(Token = "0x4001A5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[NonSerialized]
	public Interactable lockInteractableRear;

	// Token: 0x04001A5C RID: 6748
	[Token(Token = "0x4001A5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public NewRoom passwordDoorsRoom;

	// Token: 0x04001A5D RID: 6749
	[Token(Token = "0x4001A5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private AudioController.LoopingSoundInfo lockpickLoop;

	// Token: 0x04001A5E RID: 6750
	[Token(Token = "0x4001A5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public List<NewNode> bothNodesForAudioSource;

	// Token: 0x04001A5F RID: 6751
	[Token(Token = "0x4001A5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool audioLoopStarted;

	// Token: 0x04001A60 RID: 6752
	[Token(Token = "0x4001A60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public List<string> passwordPlacementDebug;

	// Token: 0x04001A61 RID: 6753
	[Token(Token = "0x4001A61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public List<string> isLockedDebug;

	// Token: 0x020003CC RID: 972
	[Token(Token = "0x20003CC")]
	public enum DoorSetting
	{
		// Token: 0x04001A63 RID: 6755
		[Token(Token = "0x4001A63")]
		leaveOpen,
		// Token: 0x04001A64 RID: 6756
		[Token(Token = "0x4001A64")]
		leaveClosed
	}

	// Token: 0x020003CD RID: 973
	[Token(Token = "0x20003CD")]
	public enum LockSetting
	{
		// Token: 0x04001A66 RID: 6758
		[Token(Token = "0x4001A66")]
		keepUnlocked,
		// Token: 0x04001A67 RID: 6759
		[Token(Token = "0x4001A67")]
		keepLocked
	}

	// Token: 0x020003CE RID: 974
	[Token(Token = "0x20003CE")]
	public enum CitizenPassResult
	{
		// Token: 0x04001A69 RID: 6761
		[Token(Token = "0x4001A69")]
		success,
		// Token: 0x04001A6A RID: 6762
		[Token(Token = "0x4001A6A")]
		isLocked,
		// Token: 0x04001A6B RID: 6763
		[Token(Token = "0x4001A6B")]
		isJammed,
		// Token: 0x04001A6C RID: 6764
		[Token(Token = "0x4001A6C")]
		isForbidden
	}

	// Token: 0x020003CF RID: 975
	[Token(Token = "0x20003CF")]
	private sealed class <OpenDoor>d__69 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060015D4 RID: 5588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D4")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <OpenDoor>d__69(int <>1__state)
		{
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x0000A2A8 File Offset: 0x000084A8
		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x81F740", Offset = "0x81E740", VA = "0x18081F740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060015D7 RID: 5591 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000BA")]
		private object Current
		{
			[Token(Token = "0x60015D7")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x8202F0", Offset = "0x81F2F0", VA = "0x1808202F0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000BB")]
		private object Current
		{
			[Token(Token = "0x60015D9")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001A6D RID: 6765
		[Token(Token = "0x4001A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001A6E RID: 6766
		[Token(Token = "0x4001A6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001A6F RID: 6767
		[Token(Token = "0x4001A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NewDoor <>4__this;

		// Token: 0x04001A70 RID: 6768
		[Token(Token = "0x4001A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speedMultiplier;

		// Token: 0x04001A71 RID: 6769
		[Token(Token = "0x4001A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Actor actor;

		// Token: 0x04001A72 RID: 6770
		[Token(Token = "0x4001A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <angle>5__2;

		// Token: 0x04001A73 RID: 6771
		[Token(Token = "0x4001A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <amountToRotate>5__3;

		// Token: 0x04001A74 RID: 6772
		[Token(Token = "0x4001A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <doorSpeedMultiplier>5__4;

		// Token: 0x04001A75 RID: 6773
		[Token(Token = "0x4001A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int <audioUpdateTicker>5__5;

		// Token: 0x04001A76 RID: 6774
		[Token(Token = "0x4001A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool <closeSFXPlayed>5__6;
	}

	// Token: 0x020003D0 RID: 976
	[Token(Token = "0x20003D0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060015DB RID: 5595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0000A2C0 File Offset: 0x000084C0
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x8203F0", Offset = "0x81F3F0", VA = "0x1808203F0")]
		internal bool <OnClose>b__70_0(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x0000A2D8 File Offset: 0x000084D8
		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x820590", Offset = "0x81F590", VA = "0x180820590")]
		internal bool <OnClose>b__70_1(InteractablePreset.SwitchState item2)
		{
			return default(bool);
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x0000A2F0 File Offset: 0x000084F0
		[Token(Token = "0x60015DE")]
		[Address(RVA = "0x8205C0", Offset = "0x81F5C0", VA = "0x1808205C0")]
		internal bool <OnClose>b__70_2(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x0000A308 File Offset: 0x00008508
		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x820590", Offset = "0x81F590", VA = "0x180820590")]
		internal bool <OnClose>b__70_3(InteractablePreset.SwitchState item2)
		{
			return default(bool);
		}

		// Token: 0x04001A77 RID: 6775
		[Token(Token = "0x4001A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly NewDoor.<>c <>9;

		// Token: 0x04001A78 RID: 6776
		[Token(Token = "0x4001A78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<InteractablePreset.SwitchState> <>9__70_1;

		// Token: 0x04001A79 RID: 6777
		[Token(Token = "0x4001A79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__70_0;

		// Token: 0x04001A7A RID: 6778
		[Token(Token = "0x4001A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<InteractablePreset.SwitchState> <>9__70_3;

		// Token: 0x04001A7B RID: 6779
		[Token(Token = "0x4001A7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__70_2;
	}
}
