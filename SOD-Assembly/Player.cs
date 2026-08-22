using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

// Token: 0x0200003E RID: 62
[Token(Token = "0x200003E")]
public class Player : Human
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000001")]
	public event Player.TransitionCompleted OnTransitionCompleted
	{
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x4465B0", Offset = "0x4455B0", VA = "0x1804465B0")]
		add
		{
		}
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x4466B0", Offset = "0x4456B0", VA = "0x1804466B0")]
		remove
		{
		}
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000002")]
	public event Player.StartAutoTravel OnExecuteAutoTravel
	{
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x4467B0", Offset = "0x4457B0", VA = "0x1804467B0")]
		add
		{
		}
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x4468B0", Offset = "0x4458B0", VA = "0x1804468B0")]
		remove
		{
		}
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x0600020A RID: 522 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000003")]
	public event Player.AutoTravelEnd OnEndAutoTravel
	{
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x4469B0", Offset = "0x4459B0", VA = "0x1804469B0")]
		add
		{
		}
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x446AB0", Offset = "0x445AB0", VA = "0x180446AB0")]
		remove
		{
		}
	}

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000004")]
	public event Player.GameLocationChange OnNewGameLocation
	{
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x446BB0", Offset = "0x445BB0", VA = "0x180446BB0")]
		add
		{
		}
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x446CB0", Offset = "0x445CB0", VA = "0x180446CB0")]
		remove
		{
		}
	}

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000005")]
	public event Player.RoomChange OnNewRoom
	{
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x446DB0", Offset = "0x445DB0", VA = "0x180446DB0")]
		add
		{
		}
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x446EB0", Offset = "0x445EB0", VA = "0x180446EB0")]
		remove
		{
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000210 RID: 528 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000025")]
	public static Player Instance
	{
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x446FB0", Offset = "0x445FB0", VA = "0x180446FB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000211")]
	[Address(RVA = "0x446FF0", Offset = "0x445FF0", VA = "0x180446FF0")]
	private void Awake()
	{
	}

	// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000212")]
	[Address(RVA = "0x4474C0", Offset = "0x4464C0", VA = "0x1804474C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000213")]
	[Address(RVA = "0x4476D0", Offset = "0x4466D0", VA = "0x1804476D0")]
	private void Start()
	{
	}

	// Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000214")]
	[Address(RVA = "0x447BA0", Offset = "0x446BA0", VA = "0x180447BA0")]
	public void EnablePlayerMovement(bool val, bool updateCulling = true)
	{
	}

	// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000215")]
	[Address(RVA = "0x447D50", Offset = "0x446D50", VA = "0x180447D50")]
	public void EnablePlayerMouseLook(bool val, bool forceHideMouseOnDisable = false)
	{
	}

	// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000216")]
	[Address(RVA = "0x448020", Offset = "0x447020", VA = "0x180448020")]
	private void OnPauseChange(bool openDesktopMode)
	{
	}

	// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000217")]
	[Address(RVA = "0x448230", Offset = "0x447230", VA = "0x180448230", Slot = "8")]
	public override void UpdateGameLocation(float feetOffset = 0f, bool forceNodePositionUpdate = false)
	{
	}

	// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000218")]
	[Address(RVA = "0x4488C0", Offset = "0x4478C0", VA = "0x1804488C0", Slot = "99")]
	public virtual void OnDuctGroupChange()
	{
	}

	// Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000219")]
	[Address(RVA = "0x4488D0", Offset = "0x4478D0", VA = "0x1804488D0")]
	public void OnDuctSectionChange()
	{
	}

	// Token: 0x0600021A RID: 538 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021A")]
	[Address(RVA = "0x449060", Offset = "0x448060", VA = "0x180449060", Slot = "9")]
	public override void OnCityTileChange()
	{
	}

	// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021B")]
	[Address(RVA = "0x449950", Offset = "0x448950", VA = "0x180449950", Slot = "12")]
	public override void OnGameLocationChange(bool enableSocialSightings = true, bool forceDisableLocationMemory = false)
	{
	}

	// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021C")]
	[Address(RVA = "0x44A850", Offset = "0x449850", VA = "0x18044A850")]
	private void ResetNegativeStatuses(float resetLevel)
	{
	}

	// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021D")]
	[Address(RVA = "0x44A9E0", Offset = "0x4499E0", VA = "0x18044A9E0", Slot = "10")]
	public override void OnBuildingChange()
	{
	}

	// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021E")]
	[Address(RVA = "0x44AD70", Offset = "0x449D70", VA = "0x18044AD70")]
	public void UpdateCurrentBuildingModelVisibility()
	{
	}

	// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600021F")]
	[Address(RVA = "0x44B590", Offset = "0x44A590", VA = "0x18044B590", Slot = "13")]
	public override void OnNodeChange()
	{
	}

	// Token: 0x06000220 RID: 544 RVA: 0x00002D90 File Offset: 0x00000F90
	[Token(Token = "0x6000220")]
	[Address(RVA = "0x44C760", Offset = "0x44B760", VA = "0x18044C760")]
	public bool DoFallThroughFloorCheck()
	{
		return default(bool);
	}

	// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000221")]
	[Address(RVA = "0x44CD00", Offset = "0x44BD00", VA = "0x18044CD00")]
	private void OnDisable()
	{
	}

	// Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000222")]
	[Address(RVA = "0x44CD60", Offset = "0x44BD60", VA = "0x18044CD60")]
	private void Update()
	{
	}

	// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000223")]
	[Address(RVA = "0x453310", Offset = "0x452310", VA = "0x180453310")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000224")]
	[Address(RVA = "0x453320", Offset = "0x452320", VA = "0x180453320")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000225 RID: 549 RVA: 0x00002DA8 File Offset: 0x00000FA8
	[Token(Token = "0x6000225")]
	[Address(RVA = "0x453360", Offset = "0x452360", VA = "0x180453360")]
	private float GetRotationalLerpValue(Quaternion originalRotation, Quaternion targetRotation, float multiplier, out float angleBetween, float distanceToNext)
	{
		return 0f;
	}

	// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000226")]
	[Address(RVA = "0x453460", Offset = "0x452460", VA = "0x180453460")]
	public void UpdateMovementPhysics(bool forceUpdateBeforeGameStart = false)
	{
	}

	// Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000227")]
	[Address(RVA = "0x453C10", Offset = "0x452C10", VA = "0x180453C10")]
	public void ExecuteTransition()
	{
	}

	// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000228")]
	[Address(RVA = "0x456840", Offset = "0x455840", VA = "0x180456840")]
	public void ConvertModifierMovementToPlayerMovement(bool resetCamRoll = true)
	{
	}

	// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000229")]
	[Address(RVA = "0x457080", Offset = "0x456080", VA = "0x180457080")]
	public void ConvertPlayerMovementToModifierMovement()
	{
	}

	// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022A")]
	[Address(RVA = "0x457650", Offset = "0x456650", VA = "0x180457650")]
	public void ForceLookAt(Interactable interactable, float time)
	{
	}

	// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022B")]
	[Address(RVA = "0x4577B0", Offset = "0x4567B0", VA = "0x1804577B0")]
	public void ExecuteForceLookAt()
	{
	}

	// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022C")]
	[Address(RVA = "0x4582D0", Offset = "0x4572D0", VA = "0x1804582D0")]
	public void TransformPlayerController(PlayerTransitionPreset newEnterTransition, PlayerTransitionPreset newExitTransition, Interactable newInteractable, Transform newLookAt, bool newForceMovementOnEnd = false, bool forceTime = false, float forcedTime = 0f, bool useAdditionalLookMultiplier = false, [Optional] Vector3 newAdditionalLookMultiplier, float newRollMultiplier = 1f, bool writeReturnPosition = true)
	{
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022D")]
	[Address(RVA = "0x45A060", Offset = "0x459060", VA = "0x18045A060")]
	public void RestorePlayerMovementSpeed()
	{
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022E")]
	[Address(RVA = "0x45AA30", Offset = "0x459A30", VA = "0x18045AA30")]
	public void UpdateSkinWidth()
	{
	}

	// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022F")]
	[Address(RVA = "0x45AF80", Offset = "0x459F80", VA = "0x18045AF80")]
	public void ReturnFromTransform(bool immediate = false, bool restorePlayerTransform = true)
	{
	}

	// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000230")]
	[Address(RVA = "0x45B8F0", Offset = "0x45A8F0", VA = "0x18045B8F0")]
	public void OnTransitionComplete()
	{
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000231")]
	[Address(RVA = "0x45BE50", Offset = "0x45AE50", VA = "0x18045BE50")]
	public void EnableCharacterController(bool val)
	{
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000232")]
	[Address(RVA = "0x45BF80", Offset = "0x45AF80", VA = "0x18045BF80", Slot = "56")]
	public override void UpdateIllegalStatus()
	{
	}

	// Token: 0x06000233 RID: 563 RVA: 0x00002DC0 File Offset: 0x00000FC0
	[Token(Token = "0x6000233")]
	[Address(RVA = "0x45C360", Offset = "0x45B360", VA = "0x18045C360", Slot = "55")]
	public override bool IsTrespassing(NewRoom room, out int trespassEscalation, bool enforcersAllowedEverywhere = true)
	{
		return default(bool);
	}

	// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000234")]
	[Address(RVA = "0x45D1A0", Offset = "0x45C1A0", VA = "0x18045D1A0", Slot = "24")]
	public override void OnStealthModeChange()
	{
	}

	// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000235")]
	[Address(RVA = "0x45D250", Offset = "0x45C250", VA = "0x18045D250", Slot = "25")]
	public override void OnCrouchedChange()
	{
	}

	// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000236")]
	[Address(RVA = "0x45D3A0", Offset = "0x45C3A0", VA = "0x18045D3A0")]
	public void SetLockpickingState(bool val)
	{
	}

	// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000237")]
	[Address(RVA = "0x45D530", Offset = "0x45C530", VA = "0x18045D530")]
	public void SetMaxSpeed(float newWalkSpeed, float newRunSpeed)
	{
	}

	// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000238")]
	[Address(RVA = "0x45D8D0", Offset = "0x45C8D0", VA = "0x18045D8D0")]
	public void SetCameraHeight(float newHeight)
	{
	}

	// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000239")]
	[Address(RVA = "0x45D9E0", Offset = "0x45C9E0", VA = "0x18045D9E0")]
	public void SetPlayerHeight(float newHeight, bool stayOnFloorPlane = true)
	{
	}

	// Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600023A")]
	[Address(RVA = "0x45DDF0", Offset = "0x45CDF0", VA = "0x18045DDF0", Slot = "23")]
	public override void UpdateLightLevel()
	{
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600023B")]
	[Address(RVA = "0x45DF70", Offset = "0x45CF70", VA = "0x18045DF70", Slot = "14")]
	public override void OnRoomChange()
	{
	}

	// Token: 0x0600023C RID: 572 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600023C")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "11")]
	public override void OnTileChange()
	{
	}

	// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600023D")]
	[Address(RVA = "0x45E980", Offset = "0x45D980", VA = "0x18045E980")]
	public void UpdateCullingShortly()
	{
	}

	// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600023E")]
	[Address(RVA = "0x45E990", Offset = "0x45D990", VA = "0x18045E990")]
	public void UpdateCullingOnEndOfFrame()
	{
	}

	// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600023F")]
	[Address(RVA = "0x45EB40", Offset = "0x45DB40", VA = "0x18045EB40")]
	public void UpdateCulling()
	{
	}

	// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000240")]
	[Address(RVA = "0x45EDA0", Offset = "0x45DDA0", VA = "0x18045EDA0", Slot = "58")]
	public override void SetResidence(ResidenceController newHome, bool removePreviousResidence = true)
	{
	}

	// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000241")]
	[Address(RVA = "0x45F130", Offset = "0x45E130", VA = "0x18045F130", Slot = "16")]
	public override void AddToKeyring(NewAddress ad, bool gameMessage = true)
	{
	}

	// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000242")]
	[Address(RVA = "0x45F470", Offset = "0x45E470", VA = "0x18045F470", Slot = "17")]
	public override void AddToKeyring(NewDoor ac, bool gameMessage = true)
	{
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000243")]
	[Address(RVA = "0x45F860", Offset = "0x45E860", VA = "0x18045F860")]
	public void AddToKeyring(Interactable inter, bool gameMessage = true)
	{
	}

	// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000244")]
	[Address(RVA = "0x45F950", Offset = "0x45E950", VA = "0x18045F950", Slot = "19")]
	public override void RemoveFromKeyring(NewDoor ac)
	{
	}

	// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000245")]
	[Address(RVA = "0x45F9C0", Offset = "0x45E9C0", VA = "0x18045F9C0")]
	public void RemoveFromKeyring(Interactable inter)
	{
	}

	// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000246")]
	[Address(RVA = "0x45FA50", Offset = "0x45EA50", VA = "0x18045FA50")]
	public void TriggerPlayerKO(Vector3 KODirection, float RollMP, bool forceDirtyDeath = false)
	{
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000247")]
	[Address(RVA = "0x460D00", Offset = "0x45FD00", VA = "0x180460D00")]
	public void TriggerPlayerRecovery()
	{
	}

	// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000248")]
	[Address(RVA = "0x460FD0", Offset = "0x45FFD0", VA = "0x180460FD0", Slot = "7")]
	public override void Teleport(NewNode teleportLocation, Interactable.UsagePoint usagePoint, bool cancelVent = true, bool teleportYPostionOnly = false, bool goalDeeactivation = true)
	{
	}

	// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000249")]
	[Address(RVA = "0x4618F0", Offset = "0x4608F0", VA = "0x1804618F0")]
	public void SetPosition(Vector3 newWorldPos, Quaternion newRot)
	{
	}

	// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024A")]
	[Address(RVA = "0x461C80", Offset = "0x460C80", VA = "0x180461C80")]
	public void UpdatePlayerAmbientState()
	{
	}

	// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024B")]
	[Address(RVA = "0x4621E0", Offset = "0x4611E0", VA = "0x1804621E0")]
	public void OnHide(Interactable newHideInteractable, int reference = 0, bool instant = false, bool allowReturnPositionWrite = true)
	{
	}

	// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024C")]
	[Address(RVA = "0x462C30", Offset = "0x461C30", VA = "0x180462C30")]
	public void OnReturnFromHide()
	{
	}

	// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024D")]
	[Address(RVA = "0x4634A0", Offset = "0x4624A0", VA = "0x1804634A0")]
	public void OnAnswerPhone(Interactable newPhone)
	{
	}

	// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024E")]
	[Address(RVA = "0x463690", Offset = "0x462690", VA = "0x180463690")]
	public void OnReturnFromAnswerPhone()
	{
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024F")]
	[Address(RVA = "0x4638A0", Offset = "0x4628A0", VA = "0x1804638A0")]
	public void OnCrawlIntoVent(Interactable vent, bool instant = false)
	{
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000250")]
	[Address(RVA = "0x463CF0", Offset = "0x462CF0", VA = "0x180463CF0")]
	public void OnCrawlOutOfVent(Interactable vent, bool instant = false)
	{
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000251")]
	[Address(RVA = "0x464120", Offset = "0x463120", VA = "0x180464120")]
	public void EnterVent(bool restoreTransform = false)
	{
	}

	// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000252")]
	[Address(RVA = "0x464430", Offset = "0x463430", VA = "0x180464430")]
	public void ExitVent(bool restoreTransform = false)
	{
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000253")]
	[Address(RVA = "0x464770", Offset = "0x463770", VA = "0x180464770")]
	public void OnUseComputer(Interactable newComp, bool instant = false)
	{
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000254")]
	[Address(RVA = "0x464CE0", Offset = "0x463CE0", VA = "0x180464CE0")]
	public void OnReturnFromUseComputer()
	{
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000255")]
	[Address(RVA = "0x464ED0", Offset = "0x463ED0", VA = "0x180464ED0")]
	public void OnTakePrint(Interactable newHand)
	{
	}

	// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000256")]
	[Address(RVA = "0x465580", Offset = "0x464580", VA = "0x180465580")]
	public void OnCompleteTakePrint()
	{
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000257")]
	[Address(RVA = "0x465970", Offset = "0x464970", VA = "0x180465970")]
	public void OnReturnFromTakePrint()
	{
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000258")]
	[Address(RVA = "0x465B30", Offset = "0x464B30", VA = "0x180465B30")]
	public void OnSearch(Interactable newSearchItem)
	{
	}

	// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000259")]
	[Address(RVA = "0x466FA0", Offset = "0x465FA0", VA = "0x180466FA0")]
	public void OnCompleteSearch()
	{
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025A")]
	[Address(RVA = "0x4676C0", Offset = "0x4666C0", VA = "0x1804676C0")]
	public void OnReturnFromSearch()
	{
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025B")]
	[Address(RVA = "0x467B60", Offset = "0x466B60", VA = "0x180467B60")]
	public void OnDrink(Interactable newSearchItem)
	{
	}

	// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025C")]
	[Address(RVA = "0x4680F0", Offset = "0x4670F0", VA = "0x1804680F0")]
	public void DrinkProgress(float amountChangeThisFrame, float amountToal)
	{
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025D")]
	[Address(RVA = "0x4682B0", Offset = "0x4672B0", VA = "0x1804682B0")]
	public void OnLookAwayFromFountain()
	{
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025E")]
	[Address(RVA = "0x468320", Offset = "0x467320", VA = "0x180468320")]
	public void OnCompleteDrink()
	{
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025F")]
	[Address(RVA = "0x468790", Offset = "0x467790", VA = "0x180468790")]
	public void OnReturnFromDrink()
	{
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000260")]
	[Address(RVA = "0x468F20", Offset = "0x467F20", VA = "0x180468F20")]
	public void OnInteractionActionProgress(float amountThisFrame, float interactionActionAmount)
	{
	}

	// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000261")]
	[Address(RVA = "0x469070", Offset = "0x468070", VA = "0x180469070")]
	public void OnGenericTimedAction(string actionName, float threshold, float increaseRate, Interactable newItem, bool playObjectsSearchLoop = false)
	{
	}

	// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000262")]
	[Address(RVA = "0x469650", Offset = "0x468650", VA = "0x180469650")]
	public void OnReturnFromGenericAction()
	{
	}

	// Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000263")]
	[Address(RVA = "0x469940", Offset = "0x468940", VA = "0x180469940")]
	public void OnHandcuff(Interactable newBody)
	{
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000264")]
	[Address(RVA = "0x46A1F0", Offset = "0x4691F0", VA = "0x18046A1F0")]
	public void OnCompleteHandcuff()
	{
	}

	// Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000265")]
	[Address(RVA = "0x46A680", Offset = "0x469680", VA = "0x18046A680")]
	public void OnReturnFromHandcuff()
	{
	}

	// Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000266")]
	[Address(RVA = "0x46A940", Offset = "0x469940", VA = "0x18046A940")]
	public void EnableGhostMovement(bool ghost, bool clipping = false, float stickToGround = 0f)
	{
	}

	// Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000267")]
	[Address(RVA = "0x46ADF0", Offset = "0x469DF0", VA = "0x18046ADF0")]
	public void SetActionDisable(string newString, bool val)
	{
	}

	// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000268")]
	[Address(RVA = "0x46B240", Offset = "0x46A240", VA = "0x18046B240")]
	public void ClearAllDisabledActions()
	{
	}

	// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000269")]
	[Address(RVA = "0x46B4F0", Offset = "0x46A4F0", VA = "0x18046B4F0", Slot = "98")]
	public override void SetVehicle(Transform newVehicle)
	{
	}

	// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026A")]
	[Address(RVA = "0x46BCF0", Offset = "0x46ACF0", VA = "0x18046BCF0")]
	public void SetVehicle(Transform newVehicle, bool overrideSessionStarted)
	{
	}

	// Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026B")]
	[Address(RVA = "0x46C4D0", Offset = "0x46B4D0", VA = "0x18046C4D0")]
	public void SetSettingAlarmMode(bool val)
	{
	}

	// Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026C")]
	[Address(RVA = "0x46C9F0", Offset = "0x46B9F0", VA = "0x18046C9F0")]
	public void AddToAlarmTime(float plusTime)
	{
	}

	// Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026D")]
	[Address(RVA = "0x46D010", Offset = "0x46C010", VA = "0x18046D010")]
	public void SetSpendingTimeMode(bool val)
	{
	}

	// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026E")]
	[Address(RVA = "0x46D860", Offset = "0x46C860", VA = "0x18046D860", Slot = "27")]
	public override void RecieveDamage(float amount, Actor fromWho, Vector3 damagePosition, Vector3 damageDirection, SpatterPatternPreset forwardSpatter, SpatterPatternPreset backSpatter, SpatterSimulation.EraseMode eraseMode = SpatterSimulation.EraseMode.quickDespawn, bool alertSurrounding = true, bool forceRagdoll = false, float forcedRagdollDuration = 0f, float shockMP = 1f, bool enableKill = false, bool allowRecoil = true, float ragdollForceMP = 1f)
	{
	}

	// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026F")]
	[Address(RVA = "0x46EDF0", Offset = "0x46DDF0", VA = "0x18046EDF0", Slot = "85")]
	public override void SetFootwear(Human.ShoeType newType)
	{
	}

	// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000270")]
	[Address(RVA = "0x46EEA0", Offset = "0x46DEA0", VA = "0x18046EEA0", Slot = "28")]
	public override void AddHealth(float amount, bool affectedByGameDifficulty = true, bool displayDamageIndicator = false)
	{
	}

	// Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000271")]
	[Address(RVA = "0x46F610", Offset = "0x46E610", VA = "0x18046F610", Slot = "29")]
	public override void SetHealth(float amount)
	{
	}

	// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000272")]
	[Address(RVA = "0x46FB60", Offset = "0x46EB60", VA = "0x18046FB60", Slot = "32")]
	public override void OnZeroHealthReached()
	{
	}

	// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000273")]
	[Address(RVA = "0x46FCC0", Offset = "0x46ECC0", VA = "0x18046FCC0", Slot = "45")]
	public override void SightingCheck(float fov, bool ignoreLightAndStealth = false)
	{
	}

	// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000274")]
	[Address(RVA = "0x470D50", Offset = "0x46FD50", VA = "0x180470D50", Slot = "60")]
	public override void PrepForStart()
	{
	}

	// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000275")]
	[Address(RVA = "0x4715C0", Offset = "0x4705C0", VA = "0x1804715C0")]
	public void GeneratePlayerDetails()
	{
	}

	// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000276")]
	[Address(RVA = "0x4726F0", Offset = "0x4716F0", VA = "0x1804726F0")]
	public void SetupPlayerPhysicalPresence()
	{
	}

	// Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000277")]
	[Address(RVA = "0x472C10", Offset = "0x471C10", VA = "0x180472C10", Slot = "62")]
	public override void AddNourishment(float addVal)
	{
	}

	// Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000278")]
	[Address(RVA = "0x472C50", Offset = "0x471C50", VA = "0x180472C50", Slot = "63")]
	public override void AddHydration(float addVal)
	{
	}

	// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000279")]
	[Address(RVA = "0x472C90", Offset = "0x471C90", VA = "0x180472C90", Slot = "65")]
	public override void AddEnergy(float addVal)
	{
	}

	// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027A")]
	[Address(RVA = "0x472CD0", Offset = "0x471CD0", VA = "0x180472CD0", Slot = "64")]
	public override void AddAlertness(float addVal)
	{
	}

	// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027B")]
	[Address(RVA = "0x472D30", Offset = "0x471D30", VA = "0x180472D30", Slot = "68")]
	public override void AddHygiene(float addVal)
	{
	}

	// Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027C")]
	[Address(RVA = "0x472D70", Offset = "0x471D70", VA = "0x180472D70", Slot = "69")]
	public override void AddHeat(float addVal)
	{
	}

	// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027D")]
	[Address(RVA = "0x472E20", Offset = "0x471E20", VA = "0x180472E20", Slot = "70")]
	public override void AddDrunk(float addVal)
	{
	}

	// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027E")]
	[Address(RVA = "0x472E60", Offset = "0x471E60", VA = "0x180472E60", Slot = "71")]
	public override void AddSick(float addVal)
	{
	}

	// Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027F")]
	[Address(RVA = "0x472EA0", Offset = "0x471EA0", VA = "0x180472EA0", Slot = "72")]
	public override void AddHeadache(float addVal)
	{
	}

	// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000280")]
	[Address(RVA = "0x472EE0", Offset = "0x471EE0", VA = "0x180472EE0", Slot = "73")]
	public override void AddWet(float addVal)
	{
	}

	// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000281")]
	[Address(RVA = "0x473000", Offset = "0x472000", VA = "0x180473000", Slot = "74")]
	public override void AddBrokenLeg(float addVal)
	{
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000282")]
	[Address(RVA = "0x4730C0", Offset = "0x4720C0", VA = "0x1804730C0", Slot = "75")]
	public override void AddBruised(float addVal)
	{
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000283")]
	[Address(RVA = "0x473180", Offset = "0x472180", VA = "0x180473180", Slot = "76")]
	public override void AddBlackEye(float addVal)
	{
	}

	// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000284")]
	[Address(RVA = "0x473240", Offset = "0x472240", VA = "0x180473240", Slot = "77")]
	public override void AddBlackedOut(float addVal)
	{
	}

	// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000285")]
	[Address(RVA = "0x473280", Offset = "0x472280", VA = "0x180473280", Slot = "78")]
	public override void AddNumb(float addVal)
	{
	}

	// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000286")]
	[Address(RVA = "0x4732C0", Offset = "0x4722C0", VA = "0x1804732C0", Slot = "80")]
	public override void AddBleeding(float addVal)
	{
	}

	// Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000287")]
	[Address(RVA = "0x473380", Offset = "0x472380", VA = "0x180473380", Slot = "82")]
	public override void AddStarchAddiction(float addVal)
	{
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000288")]
	[Address(RVA = "0x4733C0", Offset = "0x4723C0", VA = "0x1804733C0", Slot = "84")]
	public override void AddSyncDiskInstall(float addVal)
	{
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000289")]
	[Address(RVA = "0x473400", Offset = "0x472400", VA = "0x180473400")]
	public void StatusCheckEndOfFrame()
	{
	}

	// Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600028A")]
	[Address(RVA = "0x473490", Offset = "0x472490", VA = "0x180473490", Slot = "15")]
	public override void SetOnStreet(bool val)
	{
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600028B")]
	[Address(RVA = "0x4734D0", Offset = "0x4724D0", VA = "0x1804734D0")]
	public void Trip(float damage, bool forwards = false, bool playSound = true)
	{
	}

	// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600028C")]
	[Address(RVA = "0x473910", Offset = "0x472910", VA = "0x180473910", Slot = "26")]
	public override void SetHiding(bool val, Interactable newHidingPlace)
	{
	}

	// Token: 0x0600028D RID: 653 RVA: 0x00002DD8 File Offset: 0x00000FD8
	[Token(Token = "0x600028D")]
	[Address(RVA = "0x473FE0", Offset = "0x472FE0", VA = "0x180473FE0")]
	public float GetPlayerHeightNormal()
	{
		return 0f;
	}

	// Token: 0x0600028E RID: 654 RVA: 0x00002DF0 File Offset: 0x00000FF0
	[Token(Token = "0x600028E")]
	[Address(RVA = "0x474090", Offset = "0x473090", VA = "0x180474090")]
	public float GetPlayerHeightCrouched()
	{
		return 0f;
	}

	// Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600028F")]
	[Address(RVA = "0x474140", Offset = "0x473140", VA = "0x180474140")]
	public void ExecuteAutoTravel(Evidence toLocation, bool fastTravel = false)
	{
	}

	// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000290")]
	[Address(RVA = "0x4743E0", Offset = "0x4733E0", VA = "0x1804743E0")]
	public void ExecuteAutoTravel(NewGameLocation toLocation, bool fastTravel = false)
	{
	}

	// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000291")]
	[Address(RVA = "0x4746D0", Offset = "0x4736D0", VA = "0x1804746D0")]
	public void ExecuteAutoTravel(NewBuilding toBuilding, bool fastTravel = false)
	{
	}

	// Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000292")]
	[Address(RVA = "0x474920", Offset = "0x473920", VA = "0x180474920")]
	public void ExecuteAutoTravel(NewNode toNode, bool fastTravel = false)
	{
	}

	// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000293")]
	[Address(RVA = "0x474CA0", Offset = "0x473CA0", VA = "0x180474CA0")]
	public void EndAutoTravel()
	{
	}

	// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000294")]
	[Address(RVA = "0x475550", Offset = "0x474550", VA = "0x180475550")]
	public void KillPlayer()
	{
	}

	// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000295")]
	[Address(RVA = "0x475580", Offset = "0x474580", VA = "0x180475580")]
	public void GetCurrentNodeCoord()
	{
	}

	// Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000296")]
	[Address(RVA = "0x475650", Offset = "0x474650", VA = "0x180475650")]
	public void SetPositionFixSolutionsEnabled(bool condition)
	{
	}

	// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000297")]
	[Address(RVA = "0x475770", Offset = "0x474770", VA = "0x180475770")]
	public Player()
	{
	}

	// Token: 0x06000298 RID: 664 RVA: 0x00002E08 File Offset: 0x00001008
	[Token(Token = "0x6000298")]
	[Address(RVA = "0x475FC0", Offset = "0x474FC0", VA = "0x180475FC0")]
	private bool <UpdateCurrentBuildingModelVisibility>b__172_0(BuildingPreset.ForceHideModelsForRoom item)
	{
		return default(bool);
	}

	// Token: 0x06000299 RID: 665 RVA: 0x00002E20 File Offset: 0x00001020
	[Token(Token = "0x6000299")]
	[Address(RVA = "0x476030", Offset = "0x475030", VA = "0x180476030")]
	private bool <Update>b__176_1(Company item)
	{
		return default(bool);
	}

	// Token: 0x0600029A RID: 666 RVA: 0x00002E38 File Offset: 0x00001038
	[Token(Token = "0x600029A")]
	[Address(RVA = "0x476030", Offset = "0x475030", VA = "0x180476030")]
	private bool <Update>b__176_2(Company item)
	{
		return default(bool);
	}

	// Token: 0x0400016A RID: 362
	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
	public bool fpsMode;

	// Token: 0x0400016B RID: 363
	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C0")]
	public FirstPersonController fps;

	// Token: 0x0400016C RID: 364
	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C8")]
	public CharacterController charController;

	// Token: 0x0400016D RID: 365
	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D0")]
	public CapsuleCollider transitionDamageTrigger;

	// Token: 0x0400016E RID: 366
	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D8")]
	public CameraController cam;

	// Token: 0x0400016F RID: 367
	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E0")]
	public Transform camHeightParent;

	// Token: 0x04000170 RID: 368
	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E8")]
	public Transform playerContainer;

	// Token: 0x04000171 RID: 369
	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F0")]
	public AirDuctGroup.AirDuctSection previousDuctSection;

	// Token: 0x04000172 RID: 370
	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F8")]
	public AirDuctGroup.AirDuctSection currentDuctSection;

	// Token: 0x04000173 RID: 371
	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x600")]
	public bool isCrunchingDatabase;

	// Token: 0x04000174 RID: 372
	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x608")]
	public SceneRecorder sceneRecorder;

	// Token: 0x04000175 RID: 373
	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x610")]
	public bool setAlarmMode;

	// Token: 0x04000176 RID: 374
	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x611")]
	public bool editingHours;

	// Token: 0x04000177 RID: 375
	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x614")]
	private float setAlarmFlashCounter;

	// Token: 0x04000178 RID: 376
	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x618")]
	public float alarm;

	// Token: 0x04000179 RID: 377
	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61C")]
	private bool alarmFlash;

	// Token: 0x0400017A RID: 378
	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x620")]
	public float setAlarmModeAfterDelay;

	// Token: 0x0400017B RID: 379
	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x624")]
	public float spendingTimeDelay;

	// Token: 0x0400017C RID: 380
	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x628")]
	public bool spendingTimeMode;

	// Token: 0x0400017D RID: 381
	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x629")]
	public bool autoTravelActive;

	// Token: 0x0400017E RID: 382
	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62C")]
	private float toleranceRecalcTimer;

	// Token: 0x0400017F RID: 383
	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x630")]
	private NewDoor autoTravelDoor;

	// Token: 0x04000180 RID: 384
	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x638")]
	private NewNode.NodeAccess currentAutoTravelDest;

	// Token: 0x04000181 RID: 385
	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x640")]
	private NewNode.NodeSpace currentNodeSpaceDest;

	// Token: 0x04000182 RID: 386
	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x648")]
	private float currentNodeSpaceDestTimer;

	// Token: 0x04000183 RID: 387
	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64C")]
	public float autoTravelDistanceToNext;

	// Token: 0x04000184 RID: 388
	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x650")]
	public Vector3 autoTravelForward;

	// Token: 0x04000185 RID: 389
	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x660")]
	[NonSerialized]
	public Telephone answeringPhone;

	// Token: 0x04000186 RID: 390
	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x668")]
	[NonSerialized]
	public TelephoneController.PhoneCall activeCall;

	// Token: 0x04000187 RID: 391
	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x670")]
	public List<CanvasRenderer> footstepSoundObjects;

	// Token: 0x04000188 RID: 392
	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x678")]
	public float crouchedTransition;

	// Token: 0x04000189 RID: 393
	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x67C")]
	public bool crouchTransitionActive;

	// Token: 0x0400018A RID: 394
	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x680")]
	private int updateNodeSpace;

	// Token: 0x0400018B RID: 395
	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x684")]
	private float takeDamageIndicatorTimer;

	// Token: 0x0400018C RID: 396
	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x688")]
	private float takeDamageDisplaySpeed;

	// Token: 0x0400018D RID: 397
	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68C")]
	private float spawnProtection;

	// Token: 0x0400018E RID: 398
	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x690")]
	private bool wasMoving;

	// Token: 0x0400018F RID: 399
	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x694")]
	private int nearbyInteractableUpdate;

	// Token: 0x04000190 RID: 400
	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x698")]
	public float gasLevel;

	// Token: 0x04000191 RID: 401
	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69C")]
	public float hurt;

	// Token: 0x04000192 RID: 402
	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A0")]
	private Interactable bed;

	// Token: 0x04000193 RID: 403
	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A8")]
	public List<CityTile> cityTilesInVicinity;

	// Token: 0x04000194 RID: 404
	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6B0")]
	public List<Interactable> playerKeyringInt;

	// Token: 0x04000195 RID: 405
	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6B8")]
	public bool forceLookAtActive;

	// Token: 0x04000196 RID: 406
	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C0")]
	public Interactable forceLookAtInteractable;

	// Token: 0x04000197 RID: 407
	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C8")]
	public float forceLookAtTime;

	// Token: 0x04000198 RID: 408
	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6CC")]
	private float lookAtTime;

	// Token: 0x04000199 RID: 409
	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D0")]
	private float lookAtProgress;

	// Token: 0x0400019A RID: 410
	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D4")]
	private Quaternion originalLookAtModRotationGlobal;

	// Token: 0x0400019B RID: 411
	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6E4")]
	public bool transitionActive;

	// Token: 0x0400019C RID: 412
	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6E8")]
	private float transitionTime;

	// Token: 0x0400019D RID: 413
	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6EC")]
	public float transitionProgress;

	// Token: 0x0400019E RID: 414
	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6F0")]
	[NonSerialized]
	public Interactable transitionInteractable;

	// Token: 0x0400019F RID: 415
	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6F8")]
	public PlayerTransitionPreset currentTransition;

	// Token: 0x040001A0 RID: 416
	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x700")]
	public PlayerTransitionPreset exitTransition;

	// Token: 0x040001A1 RID: 417
	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x708")]
	public Vector3 originalPlayerPosition;

	// Token: 0x040001A2 RID: 418
	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x714")]
	public Vector3 originalModPosition;

	// Token: 0x040001A3 RID: 419
	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x720")]
	public float originalPlayerHeight;

	// Token: 0x040001A4 RID: 420
	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x724")]
	public float originalCamHeight;

	// Token: 0x040001A5 RID: 421
	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x728")]
	public Vector3 startingLookPointWorldPosition;

	// Token: 0x040001A6 RID: 422
	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x734")]
	public bool transitionRecoilState;

	// Token: 0x040001A7 RID: 423
	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x738")]
	private List<PlayerTransitionPreset.SFXSetting> soundsPlayed;

	// Token: 0x040001A8 RID: 424
	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x740")]
	public Quaternion originalModRotationGlobal;

	// Token: 0x040001A9 RID: 425
	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x750")]
	public Quaternion originalModRotationLocal;

	// Token: 0x040001AA RID: 426
	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x760")]
	public Vector3 additionalLookMultiplier;

	// Token: 0x040001AB RID: 427
	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x76C")]
	public float rollMultiplier;

	// Token: 0x040001AC RID: 428
	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x770")]
	public bool transitionForceTime;

	// Token: 0x040001AD RID: 429
	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x774")]
	public float transtionForcedTime;

	// Token: 0x040001AE RID: 430
	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x778")]
	public Transform transitionLookAt;

	// Token: 0x040001AF RID: 431
	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x780")]
	private bool movementOnTransitionComplete;

	// Token: 0x040001B0 RID: 432
	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x781")]
	private bool restoreHolsterOnTransitionComplete;

	// Token: 0x040001B1 RID: 433
	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x782")]
	public bool citizensArrestActive;

	// Token: 0x040001B2 RID: 434
	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x788")]
	public List<string> disabledActions;

	// Token: 0x040001B3 RID: 435
	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x790")]
	public int forcedLeanState;

	// Token: 0x040001B4 RID: 436
	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x794")]
	public float extraLeanSpeed;

	// Token: 0x040001B5 RID: 437
	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x798")]
	public float normalStepOffset;

	// Token: 0x040001B6 RID: 438
	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79C")]
	public float airVentStepOffset;

	// Token: 0x040001B7 RID: 439
	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7A0")]
	public Vector3 storedTransitionPosition;

	// Token: 0x040001B8 RID: 440
	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7AC")]
	public float desiredWalkSpeed;

	// Token: 0x040001B9 RID: 441
	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7B0")]
	public float desiredRunSpeed;

	// Token: 0x040001BA RID: 442
	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7B4")]
	private bool playerKOFadeOut;

	// Token: 0x040001BB RID: 443
	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7B5")]
	private bool paidFines;

	// Token: 0x040001BC RID: 444
	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7B8")]
	private float KOTime;

	// Token: 0x040001BD RID: 445
	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7BC")]
	private float KOTimePassed;

	// Token: 0x040001BE RID: 446
	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C0")]
	private bool KORecovery;

	// Token: 0x040001BF RID: 447
	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C1")]
	private bool dirtyDeath;

	// Token: 0x040001C0 RID: 448
	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C8")]
	private GameplayController.LoanDebt debtPayment;

	// Token: 0x040001C1 RID: 449
	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D0")]
	public bool pausedRememberPlayerMovement;

	// Token: 0x040001C2 RID: 450
	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D8")]
	[NonSerialized]
	public Interactable hideInteractable;

	// Token: 0x040001C3 RID: 451
	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7E0")]
	[NonSerialized]
	public int hideReference;

	// Token: 0x040001C4 RID: 452
	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7E8")]
	[NonSerialized]
	public Interactable phoneInteractable;

	// Token: 0x040001C5 RID: 453
	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7F0")]
	[NonSerialized]
	public Interactable computerInteractable;

	// Token: 0x040001C6 RID: 454
	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7F8")]
	[NonSerialized]
	public Interactable restrainedInteractable;

	// Token: 0x040001C7 RID: 455
	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x800")]
	[NonSerialized]
	public FirstPersonItemController.InventorySlot restrainedHandcuffsSlot;

	// Token: 0x040001C8 RID: 456
	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x808")]
	[NonSerialized]
	public Interactable searchInteractable;

	// Token: 0x040001C9 RID: 457
	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x810")]
	[NonSerialized]
	public Interactable genericActionInteractable;

	// Token: 0x040001CA RID: 458
	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x818")]
	[NonSerialized]
	public int nodesTraversedWhileWalking;

	// Token: 0x040001CB RID: 459
	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81C")]
	public float lastDamageAt;

	// Token: 0x040001CC RID: 460
	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x820")]
	public Actor lastDmgFrom;

	// Token: 0x040001CD RID: 461
	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x828")]
	[NonSerialized]
	public float illegalActionTimer;

	// Token: 0x040001CE RID: 462
	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x82C")]
	public float seenProgress;

	// Token: 0x040001CF RID: 463
	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x830")]
	public float seenProgressLag;

	// Token: 0x040001D0 RID: 464
	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x834")]
	public float persuedProgress;

	// Token: 0x040001D1 RID: 465
	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x838")]
	public float persuedProgressLag;

	// Token: 0x040001D2 RID: 466
	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x840")]
	[NonSerialized]
	public AudioController.LoopingSoundInfo trespassingSnapshot;

	// Token: 0x040001D3 RID: 467
	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x848")]
	[NonSerialized]
	public AudioController.LoopingSoundInfo combatSnapshot;

	// Token: 0x040001D4 RID: 468
	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x850")]
	[NonSerialized]
	public AudioController.LoopingSoundInfo syncMachineSnapshot;

	// Token: 0x040001D5 RID: 469
	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x858")]
	[NonSerialized]
	public AudioController.LoopingSoundInfo onlyMusicSnapshot;

	// Token: 0x040001D6 RID: 470
	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x860")]
	[NonSerialized]
	public AudioController.LoopingSoundInfo wristwatchLoop;

	// Token: 0x040001D7 RID: 471
	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x868")]
	[NonSerialized]
	public float visibilityLag;

	// Token: 0x040001D8 RID: 472
	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x86C")]
	private float stealthLag;

	// Token: 0x040001D9 RID: 473
	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x870")]
	public float seenIconLag;

	// Token: 0x040001DA RID: 474
	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x874")]
	private int spotCheckTimer;

	// Token: 0x040001DB RID: 475
	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x878")]
	public bool playerKOInProgress;

	// Token: 0x040001DC RID: 476
	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x879")]
	public bool isLockpicking;

	// Token: 0x040001DD RID: 477
	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x87A")]
	public bool isGrounded;

	// Token: 0x040001DE RID: 478
	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x87B")]
	private bool wasGrounded;

	// Token: 0x040001DF RID: 479
	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x87C")]
	public bool inElevator;

	// Token: 0x040001E0 RID: 480
	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x880")]
	public InteractableController elevatorInteractable;

	// Token: 0x040001E1 RID: 481
	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x888")]
	public bool claimedAccidentCover;

	// Token: 0x040001E2 RID: 482
	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x890")]
	public List<int> foodHygeinePhotos;

	// Token: 0x040001E3 RID: 483
	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x898")]
	public List<int> sanitaryHygeinePhotos;

	// Token: 0x040001E4 RID: 484
	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8A0")]
	public List<int> illegalOpsPhotos;

	// Token: 0x040001E5 RID: 485
	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8A8")]
	public bool firstFrame;

	// Token: 0x040001E6 RID: 486
	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8A9")]
	private bool lateFixedUpdate;

	// Token: 0x040001E7 RID: 487
	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8AA")]
	private bool drinkLoopStarted;

	// Token: 0x040001E8 RID: 488
	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8B0")]
	private AudioController.LoopingSoundInfo drinkLoop;

	// Token: 0x040001E9 RID: 489
	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8B8")]
	public List<NewAddress> apartmentsOwned;

	// Token: 0x040001EA RID: 490
	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C0")]
	private bool cullingUpdateRequest;

	// Token: 0x040001EB RID: 491
	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C4")]
	private float cullingUpdateTimer;

	// Token: 0x040001EC RID: 492
	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C8")]
	private Action updateCullingAction;

	// Token: 0x040001ED RID: 493
	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8D0")]
	private Action updateStatusAction;

	// Token: 0x040001EE RID: 494
	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8D8")]
	public List<Actor> spottedByPlayer;

	// Token: 0x040001EF RID: 495
	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8E0")]
	public List<Actor> spottedWhileHiding;

	// Token: 0x040001F0 RID: 496
	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8E8")]
	[NonSerialized]
	public Interactable hidingInteractable;

	// Token: 0x040001F6 RID: 502
	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Player _instance;

	// Token: 0x040001F7 RID: 503
	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x918")]
	private List<CityTile> requiredVicinity;

	// Token: 0x0200003F RID: 63
	// (Invoke) Token: 0x0600029C RID: 668
	[Token(Token = "0x200003F")]
	public delegate void TransitionCompleted(bool restoreTransform);

	// Token: 0x02000040 RID: 64
	// (Invoke) Token: 0x060002A0 RID: 672
	[Token(Token = "0x2000040")]
	public delegate void StartAutoTravel();

	// Token: 0x02000041 RID: 65
	// (Invoke) Token: 0x060002A4 RID: 676
	[Token(Token = "0x2000041")]
	public delegate void AutoTravelEnd();

	// Token: 0x02000042 RID: 66
	// (Invoke) Token: 0x060002A8 RID: 680
	[Token(Token = "0x2000042")]
	public delegate void GameLocationChange();

	// Token: 0x02000043 RID: 67
	// (Invoke) Token: 0x060002AC RID: 684
	[Token(Token = "0x2000043")]
	public delegate void RoomChange();

	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x5D1D00", Offset = "0x5D0D00", VA = "0x1805D1D00")]
		internal bool <OnGameLocationChange>b__169_0(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x5D1D90", Offset = "0x5D0D90", VA = "0x1805D1D90")]
		internal bool <Update>b__176_3(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x5D1DC0", Offset = "0x5D0DC0", VA = "0x1805D1DC0")]
		internal bool <Update>b__176_4(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x477760", Offset = "0x476760", VA = "0x180477760")]
		internal bool <Update>b__176_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x5D1E60", Offset = "0x5D0E60", VA = "0x1805D1E60")]
		internal bool <TriggerPlayerKO>b__212_0(GameplayController.LoanDebt item)
		{
			return default(bool);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x5D1EE0", Offset = "0x5D0EE0", VA = "0x1805D1EE0")]
		internal bool <OnCompleteSearch>b__231_0(InteractableActionsPreset item)
		{
			return default(bool);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x5D1F70", Offset = "0x5D0F70", VA = "0x1805D1F70")]
		internal bool <RecieveDamage>b__252_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Player.<>c <>9;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<InfoWindow> <>9__169_0;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<NewRoom> <>9__176_3;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__176_4;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__176_0;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<GameplayController.LoanDebt> <>9__212_0;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<InteractableActionsPreset> <>9__231_0;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__252_0;
	}

	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	private sealed class <>c__DisplayClass207_0
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass207_0()
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x596BB0", Offset = "0x595BB0", VA = "0x180596BB0")]
		internal bool <AddToKeyring>b__0(InterfaceController.GameMessage item)
		{
			return default(bool);
		}

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string msg;
	}

	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	private sealed class <>c__DisplayClass208_0
	{
		// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass208_0()
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x596BB0", Offset = "0x595BB0", VA = "0x180596BB0")]
		internal bool <AddToKeyring>b__0(InterfaceController.GameMessage item)
		{
			return default(bool);
		}

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string msg;
	}
}
