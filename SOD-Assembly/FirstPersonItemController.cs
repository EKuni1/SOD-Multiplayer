using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000310 RID: 784
[Token(Token = "0x2000310")]
public class FirstPersonItemController : MonoBehaviour
{
	// Token: 0x17000093 RID: 147
	// (get) Token: 0x06001125 RID: 4389 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000093")]
	public static FirstPersonItemController Instance
	{
		[Token(Token = "0x6001125")]
		[Address(RVA = "0x6BF580", Offset = "0x6BE580", VA = "0x1806BF580")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001126")]
	[Address(RVA = "0x6BF5C0", Offset = "0x6BE5C0", VA = "0x1806BF5C0")]
	private void Awake()
	{
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001127")]
	[Address(RVA = "0x6BF910", Offset = "0x6BE910", VA = "0x1806BF910")]
	private void Start()
	{
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001128")]
	[Address(RVA = "0x6BFA00", Offset = "0x6BEA00", VA = "0x1806BFA00")]
	private void Update()
	{
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001129")]
	[Address(RVA = "0x6C1D30", Offset = "0x6C0D30", VA = "0x1806C1D30")]
	public void StartSmokeToke()
	{
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600112A")]
	[Address(RVA = "0x6C1E00", Offset = "0x6C0E00", VA = "0x1806C1E00")]
	private IEnumerator SmokingToke()
	{
		return null;
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600112B")]
	[Address(RVA = "0x6C1EA0", Offset = "0x6C0EA0", VA = "0x1806C1EA0")]
	private IEnumerator HideCig(float delay, bool destroy = false, float preDelay = 0f, bool triggerAnimations = true)
	{
		return null;
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600112C")]
	[Address(RVA = "0x6C1F80", Offset = "0x6C0F80", VA = "0x1806C1F80")]
	private void OnConsumableFinished(Interactable consumableFinished)
	{
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600112D")]
	[Address(RVA = "0x6C2F60", Offset = "0x6C1F60", VA = "0x1806C2F60")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600112E")]
	[Address(RVA = "0x6C3320", Offset = "0x6C2320", VA = "0x1806C3320")]
	public void SetSlotSize(int newSize)
	{
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600112F")]
	[Address(RVA = "0x6C3D90", Offset = "0x6C2D90", VA = "0x1806C3D90")]
	public FirstPersonItemController.InventorySlot AddSpecificStaticSlot(FirstPersonItemController.InventorySlot.StaticSlot staticItem)
	{
		return null;
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001130")]
	[Address(RVA = "0x6C4870", Offset = "0x6C3870", VA = "0x1806C4870")]
	public void RemoveSpecificStaticSlot(FirstPersonItemController.InventorySlot.StaticSlot staticItem)
	{
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001131")]
	[Address(RVA = "0x6C4E70", Offset = "0x6C3E70", VA = "0x1806C4E70")]
	public void PlayerMoneyCheck()
	{
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x000086A0 File Offset: 0x000068A0
	[Token(Token = "0x6001132")]
	[Address(RVA = "0x6C51C0", Offset = "0x6C41C0", VA = "0x1806C51C0")]
	public bool PickUpItem(Interactable pickUpThis, bool switchToNew = false, bool allowSwap = false, bool enableFullMessage = true, bool enablePickupMessage = true, bool playSound = true)
	{
		return default(bool);
	}

	// Token: 0x06001133 RID: 4403 RVA: 0x000086B8 File Offset: 0x000068B8
	[Token(Token = "0x6001133")]
	[Address(RVA = "0x6C61F0", Offset = "0x6C51F0", VA = "0x1806C61F0")]
	public bool IsSlotAvailable()
	{
		return default(bool);
	}

	// Token: 0x06001134 RID: 4404 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001134")]
	[Address(RVA = "0x6C6390", Offset = "0x6C5390", VA = "0x1806C6390")]
	public void EmptySlot(FirstPersonItemController.InventorySlot emptySlot, bool throwObject = false, bool destroyObject = false, bool removeStolenFine = true, bool playSound = true)
	{
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001135")]
	[Address(RVA = "0x6C7FB0", Offset = "0x6C6FB0", VA = "0x1806C7FB0")]
	public void UpdateCurrentActions()
	{
	}

	// Token: 0x06001136 RID: 4406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001136")]
	[Address(RVA = "0x6CB2D0", Offset = "0x6CA2D0", VA = "0x1806CB2D0")]
	public void OnHolster()
	{
	}

	// Token: 0x06001137 RID: 4407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001137")]
	[Address(RVA = "0x6CB3F0", Offset = "0x6CA3F0", VA = "0x1806CB3F0")]
	public void RefreshHeldObjects()
	{
	}

	// Token: 0x06001138 RID: 4408 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001138")]
	[Address(RVA = "0x6CCE40", Offset = "0x6CBE40", VA = "0x1806CCE40")]
	private GameObject GetLeftHandPrefab(out Vector3 spawnScaleModifier)
	{
		return null;
	}

	// Token: 0x06001139 RID: 4409 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001139")]
	[Address(RVA = "0x6CD0D0", Offset = "0x6CC0D0", VA = "0x1806CD0D0")]
	private GameObject GetRightHandPrefab(out Vector3 spawnScaleModifier)
	{
		return null;
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113A")]
	[Address(RVA = "0x6CD4D0", Offset = "0x6CC4D0", VA = "0x1806CD4D0")]
	public void GenerateSkinColourMaterials()
	{
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113B")]
	[Address(RVA = "0x6CDBA0", Offset = "0x6CCBA0", VA = "0x1806CDBA0")]
	public void SetFirstPersonItem(FirstPersonItem newItem, bool forceSwitch = true)
	{
	}

	// Token: 0x0600113C RID: 4412 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113C")]
	[Address(RVA = "0x6CE5D0", Offset = "0x6CD5D0", VA = "0x1806CE5D0")]
	public void SetFirstPersonSkinColour()
	{
	}

	// Token: 0x0600113D RID: 4413 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113D")]
	[Address(RVA = "0x6CEA30", Offset = "0x6CDA30", VA = "0x1806CEA30")]
	public void ReadyNewItemDraw()
	{
	}

	// Token: 0x0600113E RID: 4414 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113E")]
	[Address(RVA = "0x6CF010", Offset = "0x6CE010", VA = "0x1806CF010")]
	public void FinishedDrawingNewItem()
	{
	}

	// Token: 0x0600113F RID: 4415 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113F")]
	[Address(RVA = "0x6CF0E0", Offset = "0x6CE0E0", VA = "0x1806CF0E0")]
	public void OnInteraction(InteractablePreset.InteractionKey input)
	{
	}

	// Token: 0x06001140 RID: 4416 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001140")]
	[Address(RVA = "0x6D0150", Offset = "0x6CF150", VA = "0x1806D0150")]
	public void ForceHolster()
	{
	}

	// Token: 0x06001141 RID: 4417 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001141")]
	[Address(RVA = "0x6D0400", Offset = "0x6CF400", VA = "0x1806D0400")]
	public void RestoreItemSelection()
	{
	}

	// Token: 0x06001142 RID: 4418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001142")]
	[Address(RVA = "0x6D04E0", Offset = "0x6CF4E0", VA = "0x1806D04E0")]
	public void SetEnableFirstPersonItemSelection(bool val)
	{
	}

	// Token: 0x06001143 RID: 4419 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001143")]
	[Address(RVA = "0x6D0550", Offset = "0x6CF550", VA = "0x1806D0550")]
	public void SetFlashlight(bool val)
	{
	}

	// Token: 0x06001144 RID: 4420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001144")]
	[Address(RVA = "0x6D09C0", Offset = "0x6CF9C0", VA = "0x1806D09C0")]
	public void ToggleFlashlight()
	{
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001145")]
	[Address(RVA = "0x6D09E0", Offset = "0x6CF9E0", VA = "0x1806D09E0")]
	public void MeleeAttack()
	{
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001146")]
	[Address(RVA = "0x6D2700", Offset = "0x6D1700", VA = "0x1806D2700")]
	public void Block()
	{
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001147")]
	[Address(RVA = "0x6D3140", Offset = "0x6D2140", VA = "0x1806D3140")]
	public void CounterAttack()
	{
	}

	// Token: 0x06001148 RID: 4424 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001148")]
	[Address(RVA = "0x6D3750", Offset = "0x6D2750", VA = "0x1806D3750")]
	public void ThrowCoin()
	{
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001149")]
	[Address(RVA = "0x6D3E60", Offset = "0x6D2E60", VA = "0x1806D3E60")]
	public void Handcuff()
	{
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600114A")]
	[Address(RVA = "0x6D4060", Offset = "0x6D3060", VA = "0x1806D4060")]
	public void Takedown()
	{
	}

	// Token: 0x0600114B RID: 4427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600114B")]
	[Address(RVA = "0x6D4810", Offset = "0x6D3810", VA = "0x1806D4810")]
	public void SetConsuming(bool val)
	{
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600114C")]
	[Address(RVA = "0x6D4C00", Offset = "0x6D3C00", VA = "0x1806D4C00")]
	public void TakeOne()
	{
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600114D")]
	[Address(RVA = "0x6D4E20", Offset = "0x6D3E20", VA = "0x1806D4E20")]
	private IEnumerator TakeOneExecute()
	{
		return null;
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600114E")]
	[Address(RVA = "0x6D4EC0", Offset = "0x6D3EC0", VA = "0x1806D4EC0")]
	public void Smoke()
	{
	}

	// Token: 0x0600114F RID: 4431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600114F")]
	[Address(RVA = "0x6D59E0", Offset = "0x6D49E0", VA = "0x1806D59E0")]
	public void ForceCanelSmoking()
	{
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001150")]
	[Address(RVA = "0x6D5B30", Offset = "0x6D4B30", VA = "0x1806D5B30")]
	public void SetRaised(bool val)
	{
	}

	// Token: 0x06001151 RID: 4433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001151")]
	[Address(RVA = "0x6D5C50", Offset = "0x6D4C50", VA = "0x1806D5C50")]
	public void PutDown()
	{
	}

	// Token: 0x06001152 RID: 4434 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001152")]
	[Address(RVA = "0x6D5D00", Offset = "0x6D4D00", VA = "0x1806D5D00")]
	public void ThrowFood()
	{
	}

	// Token: 0x06001153 RID: 4435 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001153")]
	[Address(RVA = "0x6D5DF0", Offset = "0x6D4DF0", VA = "0x1806D5DF0")]
	public void ThrowGrenade()
	{
	}

	// Token: 0x06001154 RID: 4436 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001154")]
	[Address(RVA = "0x6D65B0", Offset = "0x6D55B0", VA = "0x1806D65B0")]
	public void TakePicture()
	{
	}

	// Token: 0x06001155 RID: 4437 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001155")]
	[Address(RVA = "0x6D86F0", Offset = "0x6D76F0", VA = "0x1806D86F0")]
	private IEnumerator AnimateFlash()
	{
		return null;
	}

	// Token: 0x06001156 RID: 4438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001156")]
	[Address(RVA = "0x6D8740", Offset = "0x6D7740", VA = "0x1806D8740")]
	public void PlaceCodebreaker()
	{
	}

	// Token: 0x06001157 RID: 4439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001157")]
	[Address(RVA = "0x6D8EC0", Offset = "0x6D7EC0", VA = "0x1806D8EC0")]
	public void PlaceDoorWedge()
	{
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001158")]
	[Address(RVA = "0x6D9900", Offset = "0x6D8900", VA = "0x1806D9900")]
	public void PlaceTracker()
	{
	}

	// Token: 0x06001159 RID: 4441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001159")]
	[Address(RVA = "0x6DA6E0", Offset = "0x6D96E0", VA = "0x1806DA6E0")]
	public void PlaceGrenade(InteractablePreset activeGrenade)
	{
	}

	// Token: 0x0600115A RID: 4442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600115A")]
	[Address(RVA = "0x6DB520", Offset = "0x6DA520", VA = "0x1806DB520")]
	public void PlaceFurniture()
	{
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600115B")]
	[Address(RVA = "0x6DBD70", Offset = "0x6DAD70", VA = "0x1806DBD70")]
	public void PlaceFurnitureConfirm()
	{
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600115C")]
	[Address(RVA = "0x6DBF10", Offset = "0x6DAF10", VA = "0x1806DBF10")]
	public void PlaceFurnitureCancel()
	{
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600115D")]
	[Address(RVA = "0x6DC070", Offset = "0x6DB070", VA = "0x1806DC070")]
	public void CancelFurniture()
	{
	}

	// Token: 0x0600115E RID: 4446 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600115E")]
	[Address(RVA = "0x6DC100", Offset = "0x6DB100", VA = "0x1806DC100")]
	public void Give()
	{
	}

	// Token: 0x0600115F RID: 4447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600115F")]
	[Address(RVA = "0x6DC470", Offset = "0x6DB470", VA = "0x1806DC470")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001160 RID: 4448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001160")]
	[Address(RVA = "0x6DC940", Offset = "0x6DB940", VA = "0x1806DC940")]
	public FirstPersonItemController()
	{
	}

	// Token: 0x040014F9 RID: 5369
	[Token(Token = "0x40014F9")]
	[FieldOffset(Offset = "0x18")]
	public List<FirstPersonItemController.InventorySlot> slots;

	// Token: 0x040014FA RID: 5370
	[Token(Token = "0x40014FA")]
	[FieldOffset(Offset = "0x20")]
	public int inventorySlots;

	// Token: 0x040014FB RID: 5371
	[Token(Token = "0x40014FB")]
	[FieldOffset(Offset = "0x24")]
	public bool enableItemSelection;

	// Token: 0x040014FC RID: 5372
	[Token(Token = "0x40014FC")]
	[FieldOffset(Offset = "0x28")]
	public Transform lagPivotTransform;

	// Token: 0x040014FD RID: 5373
	[Token(Token = "0x40014FD")]
	[FieldOffset(Offset = "0x30")]
	public FirstPersonItem previousItem;

	// Token: 0x040014FE RID: 5374
	[Token(Token = "0x40014FE")]
	[FieldOffset(Offset = "0x38")]
	public FirstPersonItem currentItem;

	// Token: 0x040014FF RID: 5375
	[Token(Token = "0x40014FF")]
	[FieldOffset(Offset = "0x40")]
	public FirstPersonItem drawnItem;

	// Token: 0x04001500 RID: 5376
	[Token(Token = "0x4001500")]
	[FieldOffset(Offset = "0x48")]
	public bool finishedDrawingItem;

	// Token: 0x04001501 RID: 5377
	[Token(Token = "0x4001501")]
	[FieldOffset(Offset = "0x4C")]
	public float attackMainDelay;

	// Token: 0x04001502 RID: 5378
	[Token(Token = "0x4001502")]
	[FieldOffset(Offset = "0x50")]
	public float attackSecondaryDelay;

	// Token: 0x04001503 RID: 5379
	[Token(Token = "0x4001503")]
	[FieldOffset(Offset = "0x58")]
	public Transform leftHandObjectParent;

	// Token: 0x04001504 RID: 5380
	[Token(Token = "0x4001504")]
	[FieldOffset(Offset = "0x60")]
	public Transform rightHandObjectParent;

	// Token: 0x04001505 RID: 5381
	[Token(Token = "0x4001505")]
	[FieldOffset(Offset = "0x68")]
	public AnimationClip nothingClip;

	// Token: 0x04001506 RID: 5382
	[Token(Token = "0x4001506")]
	[FieldOffset(Offset = "0x70")]
	private GameObject rightPrefabReference;

	// Token: 0x04001507 RID: 5383
	[Token(Token = "0x4001507")]
	[FieldOffset(Offset = "0x78")]
	private GameObject leftPrefabReference;

	// Token: 0x04001508 RID: 5384
	[Token(Token = "0x4001508")]
	[FieldOffset(Offset = "0x80")]
	private float equipSoundDelay;

	// Token: 0x04001509 RID: 5385
	[Token(Token = "0x4001509")]
	[FieldOffset(Offset = "0x84")]
	private float holsterSoundDelay;

	// Token: 0x0400150A RID: 5386
	[Token(Token = "0x400150A")]
	[FieldOffset(Offset = "0x88")]
	private Material fistMaterial;

	// Token: 0x0400150B RID: 5387
	[Token(Token = "0x400150B")]
	[FieldOffset(Offset = "0x90")]
	private Material fingerUpperMaterial;

	// Token: 0x0400150C RID: 5388
	[Token(Token = "0x400150C")]
	[FieldOffset(Offset = "0x98")]
	private Material fingerLowerMaterial;

	// Token: 0x0400150D RID: 5389
	[Token(Token = "0x400150D")]
	[FieldOffset(Offset = "0xA0")]
	private Material fingerTipMaterial;

	// Token: 0x0400150E RID: 5390
	[Token(Token = "0x400150E")]
	[FieldOffset(Offset = "0xA8")]
	private Material thumbJointMaterial;

	// Token: 0x0400150F RID: 5391
	[Token(Token = "0x400150F")]
	[FieldOffset(Offset = "0xB0")]
	public bool forceHolstered;

	// Token: 0x04001510 RID: 5392
	[Token(Token = "0x4001510")]
	[FieldOffset(Offset = "0xB8")]
	public FirstPersonItemController.InventorySlot selectedWhenForceHolstered;

	// Token: 0x04001511 RID: 5393
	[Token(Token = "0x4001511")]
	[FieldOffset(Offset = "0xC0")]
	public bool listenForHolster;

	// Token: 0x04001512 RID: 5394
	[Token(Token = "0x4001512")]
	[FieldOffset(Offset = "0xC1")]
	public bool listenForDrawFinish;

	// Token: 0x04001513 RID: 5395
	[Token(Token = "0x4001513")]
	[FieldOffset(Offset = "0xC8")]
	public Dictionary<InteractablePreset.InteractionKey, Interactable.InteractableCurrentAction> currentActions;

	// Token: 0x04001514 RID: 5396
	[Token(Token = "0x4001514")]
	[FieldOffset(Offset = "0xD0")]
	public bool isConsuming;

	// Token: 0x04001515 RID: 5397
	[Token(Token = "0x4001515")]
	[FieldOffset(Offset = "0xD1")]
	public bool isRaised;

	// Token: 0x04001516 RID: 5398
	[Token(Token = "0x4001516")]
	[FieldOffset(Offset = "0xD2")]
	private bool takeOneActive;

	// Token: 0x04001517 RID: 5399
	[Token(Token = "0x4001517")]
	[FieldOffset(Offset = "0xD3")]
	public bool flashlight;

	// Token: 0x04001518 RID: 5400
	[Token(Token = "0x4001518")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject flashLightObject;

	// Token: 0x04001519 RID: 5401
	[Token(Token = "0x4001519")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject captureLightObject;

	// Token: 0x0400151A RID: 5402
	[Token(Token = "0x400151A")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject fingerprintLights;

	// Token: 0x0400151B RID: 5403
	[Token(Token = "0x400151B")]
	[FieldOffset(Offset = "0xF0")]
	public Light printScannerPulseLight;

	// Token: 0x0400151C RID: 5404
	[Token(Token = "0x400151C")]
	[FieldOffset(Offset = "0xF8")]
	public bool cameraFlash;

	// Token: 0x0400151D RID: 5405
	[Token(Token = "0x400151D")]
	[FieldOffset(Offset = "0x100")]
	public FingerprintScannerController activeScanner;

	// Token: 0x0400151E RID: 5406
	[Token(Token = "0x400151E")]
	[FieldOffset(Offset = "0x108")]
	public bool umbrellaUp;

	// Token: 0x0400151F RID: 5407
	[Token(Token = "0x400151F")]
	[FieldOffset(Offset = "0x10C")]
	public int smokingActive;

	// Token: 0x04001520 RID: 5408
	[Token(Token = "0x4001520")]
	[FieldOffset(Offset = "0x110")]
	public float smokingProgress;

	// Token: 0x04001521 RID: 5409
	[Token(Token = "0x4001521")]
	[FieldOffset(Offset = "0x118")]
	public GameObject smokingObject;

	// Token: 0x04001522 RID: 5410
	[Token(Token = "0x4001522")]
	[FieldOffset(Offset = "0x120")]
	public bool smokingTokeActive;

	// Token: 0x04001523 RID: 5411
	[Token(Token = "0x4001523")]
	[FieldOffset(Offset = "0x124")]
	public Vector3 scannerRayPoint;

	// Token: 0x04001524 RID: 5412
	[Token(Token = "0x4001524")]
	[FieldOffset(Offset = "0x130")]
	public float printDetectionRadius;

	// Token: 0x04001525 RID: 5413
	[Token(Token = "0x4001525")]
	[FieldOffset(Offset = "0x138")]
	public InteractablePreset worldCoin;

	// Token: 0x04001526 RID: 5414
	[Token(Token = "0x4001526")]
	[FieldOffset(Offset = "0x140")]
	public AudioController.LoopingSoundInfo activeLoop;

	// Token: 0x04001527 RID: 5415
	[Token(Token = "0x4001527")]
	[FieldOffset(Offset = "0x148")]
	public AudioController.LoopingSoundInfo consumeLoop;

	// Token: 0x04001528 RID: 5416
	[Token(Token = "0x4001528")]
	[FieldOffset(Offset = "0x150")]
	private Actor counterAttackActor;

	// Token: 0x04001529 RID: 5417
	[Token(Token = "0x4001529")]
	[FieldOffset(Offset = "0x158")]
	private Vector3 counterAttackPoint;

	// Token: 0x0400152A RID: 5418
	[Token(Token = "0x400152A")]
	[FieldOffset(Offset = "0x164")]
	private int updateInteractionCounter;

	// Token: 0x0400152B RID: 5419
	[Token(Token = "0x400152B")]
	[FieldOffset(Offset = "0x0")]
	private static FirstPersonItemController _instance;

	// Token: 0x02000311 RID: 785
	[Token(Token = "0x2000311")]
	[Serializable]
	public class InventorySlot
	{
		// Token: 0x06001161 RID: 4449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001161")]
		[Address(RVA = "0x6DCB30", Offset = "0x6DBB30", VA = "0x1806DCB30")]
		public void SetSegmentContent(Interactable newI)
		{
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001162")]
		[Address(RVA = "0x6DCEA0", Offset = "0x6DBEA0", VA = "0x1806DCEA0")]
		public Interactable GetInteractable()
		{
			return null;
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001163")]
		[Address(RVA = "0x6DD0B0", Offset = "0x6DC0B0", VA = "0x1806DD0B0")]
		public FirstPersonItem GetFirstPersonItem()
		{
			return null;
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001164")]
		[Address(RVA = "0x6DD260", Offset = "0x6DC260", VA = "0x1806DD260")]
		public void SetHotKey(string newHotkey)
		{
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001165")]
		[Address(RVA = "0x6DD8B0", Offset = "0x6DC8B0", VA = "0x1806DD8B0")]
		public InventorySlot()
		{
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x000086D0 File Offset: 0x000068D0
		[Token(Token = "0x6001166")]
		[Address(RVA = "0x6DD8C0", Offset = "0x6DC8C0", VA = "0x1806DD8C0")]
		private bool <GetInteractable>b__8_0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x0400152C RID: 5420
		[Token(Token = "0x400152C")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x0400152D RID: 5421
		[Token(Token = "0x400152D")]
		[FieldOffset(Offset = "0x14")]
		public int interactableID;

		// Token: 0x0400152E RID: 5422
		[Token(Token = "0x400152E")]
		[FieldOffset(Offset = "0x18")]
		public string debugName;

		// Token: 0x0400152F RID: 5423
		[Token(Token = "0x400152F")]
		[FieldOffset(Offset = "0x20")]
		public string hotkey;

		// Token: 0x04001530 RID: 5424
		[Token(Token = "0x4001530")]
		[FieldOffset(Offset = "0x28")]
		public FirstPersonItemController.InventorySlot.StaticSlot isStatic;

		// Token: 0x04001531 RID: 5425
		[Token(Token = "0x4001531")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public InventorySquareController spawnedSegment;

		// Token: 0x02000312 RID: 786
		[Token(Token = "0x2000312")]
		public enum StaticSlot
		{
			// Token: 0x04001533 RID: 5427
			[Token(Token = "0x4001533")]
			nonStatic,
			// Token: 0x04001534 RID: 5428
			[Token(Token = "0x4001534")]
			holster,
			// Token: 0x04001535 RID: 5429
			[Token(Token = "0x4001535")]
			watch,
			// Token: 0x04001536 RID: 5430
			[Token(Token = "0x4001536")]
			fists,
			// Token: 0x04001537 RID: 5431
			[Token(Token = "0x4001537")]
			coin,
			// Token: 0x04001538 RID: 5432
			[Token(Token = "0x4001538")]
			printReader
		}
	}

	// Token: 0x02000313 RID: 787
	[Token(Token = "0x2000313")]
	private sealed class <SmokingToke>d__58 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001167 RID: 4455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001167")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <SmokingToke>d__58(int <>1__state)
		{
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001168")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x000086E8 File Offset: 0x000068E8
		[Token(Token = "0x6001169")]
		[Address(RVA = "0x6DD8E0", Offset = "0x6DC8E0", VA = "0x1806DD8E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000094")]
		private object Current
		{
			[Token(Token = "0x600116A")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116B")]
		[Address(RVA = "0x6DE650", Offset = "0x6DD650", VA = "0x1806DE650", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000095")]
		private object Current
		{
			[Token(Token = "0x600116C")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001539 RID: 5433
		[Token(Token = "0x4001539")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400153A RID: 5434
		[Token(Token = "0x400153A")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400153B RID: 5435
		[Token(Token = "0x400153B")]
		[FieldOffset(Offset = "0x20")]
		public FirstPersonItemController <>4__this;

		// Token: 0x0400153C RID: 5436
		[Token(Token = "0x400153C")]
		[FieldOffset(Offset = "0x28")]
		private float <smokingTokeProgress>5__2;

		// Token: 0x0400153D RID: 5437
		[Token(Token = "0x400153D")]
		[FieldOffset(Offset = "0x30")]
		private Material <activeCigMat>5__3;

		// Token: 0x0400153E RID: 5438
		[Token(Token = "0x400153E")]
		[FieldOffset(Offset = "0x38")]
		private ParticleSystem <smokingExhale>5__4;
	}

	// Token: 0x02000314 RID: 788
	[Token(Token = "0x2000314")]
	private sealed class <HideCig>d__59 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600116D RID: 4461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116D")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <HideCig>d__59(int <>1__state)
		{
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x00008700 File Offset: 0x00006900
		[Token(Token = "0x600116F")]
		[Address(RVA = "0x6DE6A0", Offset = "0x6DD6A0", VA = "0x1806DE6A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000096")]
		private object Current
		{
			[Token(Token = "0x6001170")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001171")]
		[Address(RVA = "0x6DEFE0", Offset = "0x6DDFE0", VA = "0x1806DEFE0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000097")]
		private object Current
		{
			[Token(Token = "0x6001172")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400153F RID: 5439
		[Token(Token = "0x400153F")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001540 RID: 5440
		[Token(Token = "0x4001540")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001541 RID: 5441
		[Token(Token = "0x4001541")]
		[FieldOffset(Offset = "0x20")]
		public bool triggerAnimations;

		// Token: 0x04001542 RID: 5442
		[Token(Token = "0x4001542")]
		[FieldOffset(Offset = "0x24")]
		public float preDelay;

		// Token: 0x04001543 RID: 5443
		[Token(Token = "0x4001543")]
		[FieldOffset(Offset = "0x28")]
		public float delay;

		// Token: 0x04001544 RID: 5444
		[Token(Token = "0x4001544")]
		[FieldOffset(Offset = "0x30")]
		public FirstPersonItemController <>4__this;

		// Token: 0x04001545 RID: 5445
		[Token(Token = "0x4001545")]
		[FieldOffset(Offset = "0x38")]
		public bool destroy;
	}

	// Token: 0x02000315 RID: 789
	[Token(Token = "0x2000315")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001174 RID: 4468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001174")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00008718 File Offset: 0x00006918
		[Token(Token = "0x6001175")]
		[Address(RVA = "0x513660", Offset = "0x512660", VA = "0x180513660")]
		internal bool <SetSlotSize>b__62_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00008730 File Offset: 0x00006930
		[Token(Token = "0x6001176")]
		[Address(RVA = "0x477AC0", Offset = "0x476AC0", VA = "0x180477AC0")]
		internal bool <SetSlotSize>b__62_2(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00008748 File Offset: 0x00006948
		[Token(Token = "0x6001177")]
		[Address(RVA = "0x477AC0", Offset = "0x476AC0", VA = "0x180477AC0")]
		internal bool <SetSlotSize>b__62_3(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00008760 File Offset: 0x00006960
		[Token(Token = "0x6001178")]
		[Address(RVA = "0x477780", Offset = "0x476780", VA = "0x180477780")]
		internal bool <SetSlotSize>b__62_1(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00008778 File Offset: 0x00006978
		[Token(Token = "0x6001179")]
		[Address(RVA = "0x6DF0E0", Offset = "0x6DE0E0", VA = "0x1806DF0E0")]
		internal bool <AddSpecificStaticSlot>b__63_1(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x00008790 File Offset: 0x00006990
		[Token(Token = "0x600117A")]
		[Address(RVA = "0x6DF170", Offset = "0x6DE170", VA = "0x1806DF170")]
		internal bool <AddSpecificStaticSlot>b__63_2(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x000087A8 File Offset: 0x000069A8
		[Token(Token = "0x600117B")]
		[Address(RVA = "0x6DF200", Offset = "0x6DE200", VA = "0x1806DF200")]
		internal bool <AddSpecificStaticSlot>b__63_3(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x000087C0 File Offset: 0x000069C0
		[Token(Token = "0x600117C")]
		[Address(RVA = "0x6DF290", Offset = "0x6DE290", VA = "0x1806DF290")]
		internal bool <AddSpecificStaticSlot>b__63_4(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x000087D8 File Offset: 0x000069D8
		[Token(Token = "0x600117D")]
		[Address(RVA = "0x6DF320", Offset = "0x6DE320", VA = "0x1806DF320")]
		internal bool <AddSpecificStaticSlot>b__63_5(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x000087F0 File Offset: 0x000069F0
		[Token(Token = "0x600117E")]
		[Address(RVA = "0x477780", Offset = "0x476780", VA = "0x180477780")]
		internal bool <AddSpecificStaticSlot>b__63_6(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00008808 File Offset: 0x00006A08
		[Token(Token = "0x600117F")]
		[Address(RVA = "0x477780", Offset = "0x476780", VA = "0x180477780")]
		internal bool <RemoveSpecificStaticSlot>b__64_1(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00008820 File Offset: 0x00006A20
		[Token(Token = "0x6001180")]
		[Address(RVA = "0x6DF3B0", Offset = "0x6DE3B0", VA = "0x1806DF3B0")]
		internal bool <PlayerMoneyCheck>b__65_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x00008838 File Offset: 0x00006A38
		[Token(Token = "0x6001181")]
		[Address(RVA = "0x6DF3B0", Offset = "0x6DE3B0", VA = "0x1806DF3B0")]
		internal bool <PlayerMoneyCheck>b__65_1(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00008850 File Offset: 0x00006A50
		[Token(Token = "0x6001182")]
		[Address(RVA = "0x477AC0", Offset = "0x476AC0", VA = "0x180477AC0")]
		internal bool <PickUpItem>b__66_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00008868 File Offset: 0x00006A68
		[Token(Token = "0x6001183")]
		[Address(RVA = "0x477AC0", Offset = "0x476AC0", VA = "0x180477AC0")]
		internal bool <IsSlotAvailable>b__67_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00008880 File Offset: 0x00006A80
		[Token(Token = "0x6001184")]
		[Address(RVA = "0x477780", Offset = "0x476780", VA = "0x180477780")]
		internal bool <EmptySlot>b__68_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00008898 File Offset: 0x00006A98
		[Token(Token = "0x6001185")]
		[Address(RVA = "0x6DF3D0", Offset = "0x6DE3D0", VA = "0x1806DF3D0")]
		internal int <UpdateCurrentActions>b__69_0(FirstPersonItem.FPSInteractionAction p1, FirstPersonItem.FPSInteractionAction p2)
		{
			return 0;
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x000088B0 File Offset: 0x00006AB0
		[Token(Token = "0x6001186")]
		[Address(RVA = "0x477780", Offset = "0x476780", VA = "0x180477780")]
		internal bool <ForceHolster>b__80_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x000088C8 File Offset: 0x00006AC8
		[Token(Token = "0x6001187")]
		[Address(RVA = "0x6DF420", Offset = "0x6DE420", VA = "0x1806DF420")]
		internal bool <TakePicture>b__100_0(NewAIController.TrackingTarget item)
		{
			return default(bool);
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x000088E0 File Offset: 0x00006AE0
		[Token(Token = "0x6001188")]
		[Address(RVA = "0x6DF420", Offset = "0x6DE420", VA = "0x1806DF420")]
		internal bool <PlaceTracker>b__104_0(NewAIController.TrackingTarget item)
		{
			return default(bool);
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x000088F8 File Offset: 0x00006AF8
		[Token(Token = "0x6001189")]
		[Address(RVA = "0x6DF420", Offset = "0x6DE420", VA = "0x1806DF420")]
		internal bool <PlaceGrenade>b__105_0(NewAIController.TrackingTarget item)
		{
			return default(bool);
		}

		// Token: 0x04001546 RID: 5446
		[Token(Token = "0x4001546")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FirstPersonItemController.<>c <>9;

		// Token: 0x04001547 RID: 5447
		[Token(Token = "0x4001547")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__62_0;

		// Token: 0x04001548 RID: 5448
		[Token(Token = "0x4001548")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__62_2;

		// Token: 0x04001549 RID: 5449
		[Token(Token = "0x4001549")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__62_3;

		// Token: 0x0400154A RID: 5450
		[Token(Token = "0x400154A")]
		[FieldOffset(Offset = "0x20")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__62_1;

		// Token: 0x0400154B RID: 5451
		[Token(Token = "0x400154B")]
		[FieldOffset(Offset = "0x28")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__63_1;

		// Token: 0x0400154C RID: 5452
		[Token(Token = "0x400154C")]
		[FieldOffset(Offset = "0x30")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__63_2;

		// Token: 0x0400154D RID: 5453
		[Token(Token = "0x400154D")]
		[FieldOffset(Offset = "0x38")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__63_3;

		// Token: 0x0400154E RID: 5454
		[Token(Token = "0x400154E")]
		[FieldOffset(Offset = "0x40")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__63_4;

		// Token: 0x0400154F RID: 5455
		[Token(Token = "0x400154F")]
		[FieldOffset(Offset = "0x48")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__63_5;

		// Token: 0x04001550 RID: 5456
		[Token(Token = "0x4001550")]
		[FieldOffset(Offset = "0x50")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__63_6;

		// Token: 0x04001551 RID: 5457
		[Token(Token = "0x4001551")]
		[FieldOffset(Offset = "0x58")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__64_1;

		// Token: 0x04001552 RID: 5458
		[Token(Token = "0x4001552")]
		[FieldOffset(Offset = "0x60")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__65_0;

		// Token: 0x04001553 RID: 5459
		[Token(Token = "0x4001553")]
		[FieldOffset(Offset = "0x68")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__65_1;

		// Token: 0x04001554 RID: 5460
		[Token(Token = "0x4001554")]
		[FieldOffset(Offset = "0x70")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__66_0;

		// Token: 0x04001555 RID: 5461
		[Token(Token = "0x4001555")]
		[FieldOffset(Offset = "0x78")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__67_0;

		// Token: 0x04001556 RID: 5462
		[Token(Token = "0x4001556")]
		[FieldOffset(Offset = "0x80")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__68_0;

		// Token: 0x04001557 RID: 5463
		[Token(Token = "0x4001557")]
		[FieldOffset(Offset = "0x88")]
		public static Comparison<FirstPersonItem.FPSInteractionAction> <>9__69_0;

		// Token: 0x04001558 RID: 5464
		[Token(Token = "0x4001558")]
		[FieldOffset(Offset = "0x90")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__80_0;

		// Token: 0x04001559 RID: 5465
		[Token(Token = "0x4001559")]
		[FieldOffset(Offset = "0x98")]
		public static Predicate<NewAIController.TrackingTarget> <>9__100_0;

		// Token: 0x0400155A RID: 5466
		[Token(Token = "0x400155A")]
		[FieldOffset(Offset = "0xA0")]
		public static Predicate<NewAIController.TrackingTarget> <>9__104_0;

		// Token: 0x0400155B RID: 5467
		[Token(Token = "0x400155B")]
		[FieldOffset(Offset = "0xA8")]
		public static Predicate<NewAIController.TrackingTarget> <>9__105_0;
	}

	// Token: 0x02000316 RID: 790
	[Token(Token = "0x2000316")]
	private sealed class <>c__DisplayClass63_0
	{
		// Token: 0x0600118A RID: 4490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass63_0()
		{
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00008910 File Offset: 0x00006B10
		[Token(Token = "0x600118B")]
		[Address(RVA = "0x64F560", Offset = "0x64E560", VA = "0x18064F560")]
		internal bool <AddSpecificStaticSlot>b__0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x0400155C RID: 5468
		[Token(Token = "0x400155C")]
		[FieldOffset(Offset = "0x10")]
		public FirstPersonItemController.InventorySlot.StaticSlot staticItem;
	}

	// Token: 0x02000317 RID: 791
	[Token(Token = "0x2000317")]
	private sealed class <>c__DisplayClass64_0
	{
		// Token: 0x0600118C RID: 4492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass64_0()
		{
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x00008928 File Offset: 0x00006B28
		[Token(Token = "0x600118D")]
		[Address(RVA = "0x64F560", Offset = "0x64E560", VA = "0x18064F560")]
		internal bool <RemoveSpecificStaticSlot>b__0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x0400155D RID: 5469
		[Token(Token = "0x400155D")]
		[FieldOffset(Offset = "0x10")]
		public FirstPersonItemController.InventorySlot.StaticSlot staticItem;
	}

	// Token: 0x02000318 RID: 792
	[Token(Token = "0x2000318")]
	private sealed class <TakeOneExecute>d__93 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600118E RID: 4494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118E")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <TakeOneExecute>d__93(int <>1__state)
		{
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00008940 File Offset: 0x00006B40
		[Token(Token = "0x6001190")]
		[Address(RVA = "0x6DF450", Offset = "0x6DE450", VA = "0x1806DF450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000098")]
		private object Current
		{
			[Token(Token = "0x6001191")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001192")]
		[Address(RVA = "0x6DFF90", Offset = "0x6DEF90", VA = "0x1806DFF90", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000099")]
		private object Current
		{
			[Token(Token = "0x6001193")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400155E RID: 5470
		[Token(Token = "0x400155E")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400155F RID: 5471
		[Token(Token = "0x400155F")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001560 RID: 5472
		[Token(Token = "0x4001560")]
		[FieldOffset(Offset = "0x20")]
		public FirstPersonItemController <>4__this;

		// Token: 0x04001561 RID: 5473
		[Token(Token = "0x4001561")]
		[FieldOffset(Offset = "0x28")]
		private float <progress>5__2;

		// Token: 0x04001562 RID: 5474
		[Token(Token = "0x4001562")]
		[FieldOffset(Offset = "0x30")]
		private Interactable <consumable>5__3;
	}

	// Token: 0x02000319 RID: 793
	[Token(Token = "0x2000319")]
	private sealed class <AnimateFlash>d__101 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001194 RID: 4500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001194")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <AnimateFlash>d__101(int <>1__state)
		{
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001195")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00008958 File Offset: 0x00006B58
		[Token(Token = "0x6001196")]
		[Address(RVA = "0x6DFFE0", Offset = "0x6DEFE0", VA = "0x1806DFFE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700009A")]
		private object Current
		{
			[Token(Token = "0x6001197")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001198")]
		[Address(RVA = "0x6E08C0", Offset = "0x6DF8C0", VA = "0x1806E08C0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700009B")]
		private object Current
		{
			[Token(Token = "0x6001199")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001563 RID: 5475
		[Token(Token = "0x4001563")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001564 RID: 5476
		[Token(Token = "0x4001564")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001565 RID: 5477
		[Token(Token = "0x4001565")]
		[FieldOffset(Offset = "0x20")]
		private float <timer>5__2;

		// Token: 0x04001566 RID: 5478
		[Token(Token = "0x4001566")]
		[FieldOffset(Offset = "0x28")]
		private Light <flash>5__3;

		// Token: 0x04001567 RID: 5479
		[Token(Token = "0x4001567")]
		[FieldOffset(Offset = "0x30")]
		private HDAdditionalLightData <hdData>5__4;
	}
}
