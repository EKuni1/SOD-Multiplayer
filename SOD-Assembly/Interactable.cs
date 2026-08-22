using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000457 RID: 1111
[Token(Token = "0x2000457")]
[Serializable]
public class Interactable
{
	// Token: 0x14000023 RID: 35
	// (add) Token: 0x060018EB RID: 6379 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060018EC RID: 6380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000023")]
	public event Interactable.SwitchChange OnSwitchChange
	{
		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x919940", Offset = "0x918940", VA = "0x180919940")]
		add
		{
		}
		[Token(Token = "0x60018EC")]
		[Address(RVA = "0x919A40", Offset = "0x918A40", VA = "0x180919A40")]
		remove
		{
		}
	}

	// Token: 0x14000024 RID: 36
	// (add) Token: 0x060018ED RID: 6381 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060018EE RID: 6382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000024")]
	public event Interactable.State1Change OnState1Change
	{
		[Token(Token = "0x60018ED")]
		[Address(RVA = "0x919B40", Offset = "0x918B40", VA = "0x180919B40")]
		add
		{
		}
		[Token(Token = "0x60018EE")]
		[Address(RVA = "0x919C40", Offset = "0x918C40", VA = "0x180919C40")]
		remove
		{
		}
	}

	// Token: 0x14000025 RID: 37
	// (add) Token: 0x060018EF RID: 6383 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060018F0 RID: 6384 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000025")]
	public event Interactable.Deleted OnDelete
	{
		[Token(Token = "0x60018EF")]
		[Address(RVA = "0x919D40", Offset = "0x918D40", VA = "0x180919D40")]
		add
		{
		}
		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x919E40", Offset = "0x918E40", VA = "0x180919E40")]
		remove
		{
		}
	}

	// Token: 0x14000026 RID: 38
	// (add) Token: 0x060018F1 RID: 6385 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060018F2 RID: 6386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000026")]
	public event Interactable.RemovedFromWorld OnRemovedFromWorld
	{
		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x919F40", Offset = "0x918F40", VA = "0x180919F40")]
		add
		{
		}
		[Token(Token = "0x60018F2")]
		[Address(RVA = "0x91A040", Offset = "0x919040", VA = "0x18091A040")]
		remove
		{
		}
	}

	// Token: 0x060018F3 RID: 6387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F3")]
	[Address(RVA = "0x91A140", Offset = "0x919140", VA = "0x18091A140")]
	public Interactable(InteractablePreset newPreset)
	{
	}

	// Token: 0x060018F4 RID: 6388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F4")]
	[Address(RVA = "0x91A8D0", Offset = "0x9198D0", VA = "0x18091A8D0")]
	public void MainSetupStart()
	{
	}

	// Token: 0x060018F5 RID: 6389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F5")]
	[Address(RVA = "0x91AB30", Offset = "0x919B30", VA = "0x18091AB30")]
	public void UpdatePassedVariables()
	{
	}

	// Token: 0x060018F6 RID: 6390 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F6")]
	[Address(RVA = "0x91C540", Offset = "0x91B540", VA = "0x18091C540")]
	public void OnCreate()
	{
	}

	// Token: 0x060018F7 RID: 6391 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F7")]
	[Address(RVA = "0x91E0A0", Offset = "0x91D0A0", VA = "0x18091E0A0")]
	public void OnLoad()
	{
	}

	// Token: 0x060018F8 RID: 6392 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F8")]
	[Address(RVA = "0x9203A0", Offset = "0x91F3A0", VA = "0x1809203A0")]
	public void MainSetupEnd()
	{
	}

	// Token: 0x060018F9 RID: 6393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F9")]
	[Address(RVA = "0x921350", Offset = "0x920350", VA = "0x180921350")]
	public void OnDecorItemMoveToStorage()
	{
	}

	// Token: 0x060018FA RID: 6394 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018FA")]
	[Address(RVA = "0x9213C0", Offset = "0x9203C0", VA = "0x1809213C0")]
	public void OnDecorItemRePlace()
	{
	}

	// Token: 0x060018FB RID: 6395 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018FB")]
	[Address(RVA = "0x921660", Offset = "0x920660", VA = "0x180921660")]
	private void UpdateSpecialCaseReferences()
	{
	}

	// Token: 0x060018FC RID: 6396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018FC")]
	[Address(RVA = "0x9234C0", Offset = "0x9224C0", VA = "0x1809234C0")]
	public void RemoveSpecialCaseReferences()
	{
	}

	// Token: 0x060018FD RID: 6397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018FD")]
	[Address(RVA = "0x924510", Offset = "0x923510", VA = "0x180924510")]
	public void SpawnCheck()
	{
	}

	// Token: 0x060018FE RID: 6398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018FE")]
	[Address(RVA = "0x924750", Offset = "0x923750", VA = "0x180924750")]
	public void GenerateLightData()
	{
	}

	// Token: 0x060018FF RID: 6399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018FF")]
	[Address(RVA = "0x925990", Offset = "0x924990", VA = "0x180925990")]
	public void SetMaterialKey(Toolbox.MaterialKey newMatKey)
	{
	}

	// Token: 0x06001900 RID: 6400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001900")]
	[Address(RVA = "0x493FB0", Offset = "0x492FB0", VA = "0x180493FB0")]
	public void SetPolymorphicReference(object newRef)
	{
	}

	// Token: 0x06001901 RID: 6401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001901")]
	[Address(RVA = "0x925E10", Offset = "0x924E10", VA = "0x180925E10")]
	public void SetValue(float newValue)
	{
	}

	// Token: 0x06001902 RID: 6402 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001902")]
	[Address(RVA = "0x925E40", Offset = "0x924E40", VA = "0x180925E40")]
	public void SetExtraStateValue(float newValue, bool setSpecialCaseValues = true)
	{
	}

	// Token: 0x06001903 RID: 6403 RVA: 0x0000BAC0 File Offset: 0x00009CC0
	[Token(Token = "0x6001903")]
	[Address(RVA = "0x926810", Offset = "0x925810", VA = "0x180926810")]
	public float GetExtraStateValue()
	{
		return 0f;
	}

	// Token: 0x06001904 RID: 6404 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001904")]
	[Address(RVA = "0x9269F0", Offset = "0x9259F0", VA = "0x1809269F0")]
	public void SetDDSOverride(string newTreeID)
	{
	}

	// Token: 0x06001905 RID: 6405 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001905")]
	[Address(RVA = "0x926E60", Offset = "0x925E60", VA = "0x180926E60")]
	public void AssignIDWorld()
	{
	}

	// Token: 0x06001906 RID: 6406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001906")]
	[Address(RVA = "0x927000", Offset = "0x926000", VA = "0x180927000")]
	public void AssignRoomBasedID(NewRoom r)
	{
	}

	// Token: 0x06001907 RID: 6407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001907")]
	[Address(RVA = "0x927400", Offset = "0x926400", VA = "0x180927400")]
	public void AssignFurnitureBasedID(FurnitureLocation f)
	{
	}

	// Token: 0x06001908 RID: 6408 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001908")]
	[Address(RVA = "0x927480", Offset = "0x926480", VA = "0x180927480")]
	public void MoveInteractable(Vector3 newWorldPos, Vector3 newEulerAngle, bool updateSpawnPosition)
	{
	}

	// Token: 0x06001909 RID: 6409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001909")]
	[Address(RVA = "0x927530", Offset = "0x926530", VA = "0x180927530")]
	public void SetNewPositionAndParent(Transform newParent, Vector3 newLocalPos, Vector3 newLocalEuler, bool updateSpawnPosition)
	{
	}

	// Token: 0x0600190A RID: 6410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600190A")]
	[Address(RVA = "0x927900", Offset = "0x926900", VA = "0x180927900")]
	public void SetNewPosition(Vector3 newLocalPos, Vector3 newLocalEuler, bool updateSpawnPosition)
	{
	}

	// Token: 0x0600190B RID: 6411 RVA: 0x0000BAD8 File Offset: 0x00009CD8
	[Token(Token = "0x600190B")]
	[Address(RVA = "0x927BA0", Offset = "0x926BA0", VA = "0x180927BA0")]
	public Vector3 GetWorldPosition(bool useSpawnedPosition = true)
	{
		return default(Vector3);
	}

	// Token: 0x0600190C RID: 6412 RVA: 0x0000BAF0 File Offset: 0x00009CF0
	[Token(Token = "0x600190C")]
	[Address(RVA = "0x927DA0", Offset = "0x926DA0", VA = "0x180927DA0")]
	public Vector3 UpdateWorldPositionAndNode(bool updateSpawnPosition, bool forceUpdate = false)
	{
		return default(Vector3);
	}

	// Token: 0x0600190D RID: 6413 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600190D")]
	[Address(RVA = "0x92A650", Offset = "0x929650", VA = "0x18092A650")]
	public void SetPasswordSource(object newPSource)
	{
	}

	// Token: 0x0600190E RID: 6414 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600190E")]
	[Address(RVA = "0x92ADA0", Offset = "0x929DA0", VA = "0x18092ADA0")]
	public void SetOwner(Human newOwner, bool updateName = true)
	{
	}

	// Token: 0x0600190F RID: 6415 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600190F")]
	[Address(RVA = "0x92B4C0", Offset = "0x92A4C0", VA = "0x18092B4C0")]
	public void SetWriter(Human newWriter)
	{
	}

	// Token: 0x06001910 RID: 6416 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001910")]
	[Address(RVA = "0x92B650", Offset = "0x92A650", VA = "0x18092B650")]
	public void SetReciever(Human newReciever)
	{
	}

	// Token: 0x06001911 RID: 6417 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001911")]
	[Address(RVA = "0x92B7E0", Offset = "0x92A7E0", VA = "0x18092B7E0")]
	public string GetName()
	{
		return null;
	}

	// Token: 0x06001912 RID: 6418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001912")]
	[Address(RVA = "0x92C3A0", Offset = "0x92B3A0", VA = "0x18092C3A0")]
	public void UpdateName(bool assignNewNamingEvidenceKey = false, Evidence.DataKey newKey = Evidence.DataKey.name)
	{
	}

	// Token: 0x06001913 RID: 6419 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001913")]
	[Address(RVA = "0x92C770", Offset = "0x92B770", VA = "0x18092C770")]
	public void SetInInventory(Human newActor)
	{
	}

	// Token: 0x06001914 RID: 6420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001914")]
	[Address(RVA = "0x92D850", Offset = "0x92C850", VA = "0x18092D850")]
	public void SetAsNotInventory(NewNode newNode)
	{
	}

	// Token: 0x06001915 RID: 6421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001915")]
	[Address(RVA = "0x92DE50", Offset = "0x92CE50", VA = "0x18092DE50")]
	public void UpdateCurrentActions()
	{
	}

	// Token: 0x06001916 RID: 6422 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001916")]
	[Address(RVA = "0x9316C0", Offset = "0x9306C0", VA = "0x1809316C0", Slot = "4")]
	public virtual void SetSwitchState(bool val, Actor interactor, bool playSFX = true, bool forceUpdate = false, bool forceInstantLights = false)
	{
	}

	// Token: 0x06001917 RID: 6423 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001917")]
	[Address(RVA = "0x933250", Offset = "0x932250", VA = "0x180933250", Slot = "5")]
	public virtual void SetCustomState1(bool val, Actor interactor, bool playSFX = true, bool forceUpdate = false, bool forceInstantLights = false)
	{
	}

	// Token: 0x06001918 RID: 6424 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001918")]
	[Address(RVA = "0x933E10", Offset = "0x932E10", VA = "0x180933E10", Slot = "6")]
	public virtual void SetCustomState2(bool val, Actor interactor, bool playSFX = true, bool forceUpdate = false, bool forceInstantLights = false)
	{
	}

	// Token: 0x06001919 RID: 6425 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001919")]
	[Address(RVA = "0x934700", Offset = "0x933700", VA = "0x180934700", Slot = "7")]
	public virtual void SetCustomState3(bool val, Actor interactor, bool playSFX = true, bool forceUpdate = false, bool forceInstantLights = false)
	{
	}

	// Token: 0x0600191A RID: 6426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600191A")]
	[Address(RVA = "0x934EA0", Offset = "0x933EA0", VA = "0x180934EA0", Slot = "8")]
	public virtual void SetLockedState(bool val, Actor interactor, bool playSFX = true, bool forceUpdate = false)
	{
	}

	// Token: 0x0600191B RID: 6427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600191B")]
	[Address(RVA = "0x935CC0", Offset = "0x934CC0", VA = "0x180935CC0", Slot = "9")]
	public virtual void SetPhysicsPickupState(bool val, Actor interactor, bool playSFX = true, bool forceUpdate = false)
	{
	}

	// Token: 0x0600191C RID: 6428 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600191C")]
	[Address(RVA = "0x9365E0", Offset = "0x9355E0", VA = "0x1809365E0")]
	public void ResetToDefaultSwitchState()
	{
	}

	// Token: 0x0600191D RID: 6429 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600191D")]
	[Address(RVA = "0x936740", Offset = "0x935740", VA = "0x180936740")]
	public void UpdateSwitchStateAudio(InteractablePreset.IfSwitchStateSFX aud, bool swState, List<NewNode> doorNodes, Actor interactor)
	{
	}

	// Token: 0x0600191E RID: 6430 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600191E")]
	[Address(RVA = "0x937630", Offset = "0x936630", VA = "0x180937630")]
	public void MusicPlayerNextTrack(int add)
	{
	}

	// Token: 0x0600191F RID: 6431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600191F")]
	[Address(RVA = "0x937740", Offset = "0x936740", VA = "0x180937740")]
	public void UpdateMusicPlayer()
	{
	}

	// Token: 0x06001920 RID: 6432 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001920")]
	[Address(RVA = "0x937E40", Offset = "0x936E40", VA = "0x180937E40")]
	public void UpdateLoopingAudioParams()
	{
	}

	// Token: 0x06001921 RID: 6433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001921")]
	[Address(RVA = "0x9389B0", Offset = "0x9379B0", VA = "0x1809389B0")]
	public void OnInteraction(InteractablePreset.InteractionKey input, Actor who)
	{
	}

	// Token: 0x06001922 RID: 6434 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001922")]
	[Address(RVA = "0x938A60", Offset = "0x937A60", VA = "0x180938A60")]
	public void OnInteraction(InteractablePreset.InteractionAction action, Actor who, bool allowDelays = true, float additionalDelay = 0f)
	{
	}

	// Token: 0x06001923 RID: 6435 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001923")]
	[Address(RVA = "0x93A380", Offset = "0x939380", VA = "0x18093A380")]
	public void LoadInteractableToWorld(bool respawn = false, bool forceSpawnImmediate = false)
	{
	}

	// Token: 0x06001924 RID: 6436 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001924")]
	[Address(RVA = "0x93A6C0", Offset = "0x9396C0", VA = "0x18093A6C0")]
	public void SetSpawnPositionRelevent(bool val)
	{
	}

	// Token: 0x06001925 RID: 6437 RVA: 0x0000BB08 File Offset: 0x00009D08
	[Token(Token = "0x6001925")]
	[Address(RVA = "0x93AC30", Offset = "0x939C30", VA = "0x18093AC30")]
	public bool IsSpawnPositionRelevent()
	{
		return default(bool);
	}

	// Token: 0x06001926 RID: 6438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001926")]
	[Address(RVA = "0x93ADE0", Offset = "0x939DE0", VA = "0x18093ADE0")]
	public void SpawnObject(out bool wasPooled)
	{
	}

	// Token: 0x06001927 RID: 6439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001927")]
	[Address(RVA = "0x93D4E0", Offset = "0x93C4E0", VA = "0x18093D4E0")]
	public void UnloadInteractable()
	{
	}

	// Token: 0x06001928 RID: 6440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001928")]
	[Address(RVA = "0x93D5C0", Offset = "0x93C5C0", VA = "0x18093D5C0")]
	public void DespawnObject()
	{
	}

	// Token: 0x06001929 RID: 6441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001929")]
	[Address(RVA = "0x93DA00", Offset = "0x93CA00", VA = "0x18093DA00")]
	public void OnSpawn()
	{
	}

	// Token: 0x0600192A RID: 6442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600192A")]
	[Address(RVA = "0x93E820", Offset = "0x93D820", VA = "0x18093E820")]
	public void SpawnLock()
	{
	}

	// Token: 0x0600192B RID: 6443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600192B")]
	[Address(RVA = "0x93F100", Offset = "0x93E100", VA = "0x18093F100")]
	public void MarkAsTrash(bool val, bool forceTime = false, float forcedTime = 0f)
	{
	}

	// Token: 0x0600192C RID: 6444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600192C")]
	[Address(RVA = "0x93F690", Offset = "0x93E690", VA = "0x18093F690")]
	public void RemoveFromPlacement()
	{
	}

	// Token: 0x0600192D RID: 6445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600192D")]
	[Address(RVA = "0x9406A0", Offset = "0x93F6A0", VA = "0x1809406A0")]
	public void SafeDelete(bool removeFromInventory = false)
	{
	}

	// Token: 0x0600192E RID: 6446 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600192E")]
	[Address(RVA = "0x940A60", Offset = "0x93FA60", VA = "0x180940A60")]
	public void Delete()
	{
	}

	// Token: 0x0600192F RID: 6447 RVA: 0x0000BB20 File Offset: 0x00009D20
	[Token(Token = "0x600192F")]
	[Address(RVA = "0x9426D0", Offset = "0x9416D0", VA = "0x1809426D0")]
	public bool IsSafeToDelete(bool displayDebug = false)
	{
		return default(bool);
	}

	// Token: 0x06001930 RID: 6448 RVA: 0x0000BB38 File Offset: 0x00009D38
	[Token(Token = "0x6001930")]
	[Address(RVA = "0x943390", Offset = "0x942390", VA = "0x180943390")]
	public bool IsSaveStateEligable()
	{
		return default(bool);
	}

	// Token: 0x06001931 RID: 6449 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001931")]
	[Address(RVA = "0x9436C0", Offset = "0x9426C0", VA = "0x1809436C0")]
	public string GetReasonForSaveStateEligable()
	{
		return null;
	}

	// Token: 0x06001932 RID: 6450 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001932")]
	[Address(RVA = "0x943B60", Offset = "0x942B60", VA = "0x180943B60")]
	public void SetAsLight(LightingPreset newLightPreset, int newLightZoneSize, bool newIsMainLight, Interactable.LightConfiguration preconfiguredLight)
	{
	}

	// Token: 0x06001933 RID: 6451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001933")]
	[Address(RVA = "0x943E60", Offset = "0x942E60", VA = "0x180943E60")]
	public void SetNextAIInteraction(NewAIAction newAction, NewAIController ai)
	{
	}

	// Token: 0x06001934 RID: 6452 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001934")]
	[Address(RVA = "0x944030", Offset = "0x943030", VA = "0x180944030")]
	public void OnDoorMovementClosed()
	{
	}

	// Token: 0x06001935 RID: 6453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001935")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void OnDoorMovementOpened()
	{
	}

	// Token: 0x06001936 RID: 6454 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001936")]
	[Address(RVA = "0x944210", Offset = "0x943210", VA = "0x180944210")]
	public List<int> GetPasswordFromSource(out List<string> notePlacements)
	{
		return null;
	}

	// Token: 0x06001937 RID: 6455 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001937")]
	[Address(RVA = "0x944C40", Offset = "0x943C40", VA = "0x180944C40")]
	public GameplayController.Passcode GetPasswordSource()
	{
		return null;
	}

	// Token: 0x06001938 RID: 6456 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001938")]
	[Address(RVA = "0x9450C0", Offset = "0x9440C0", VA = "0x1809450C0")]
	public void AddPasswordSourceToAcquired()
	{
	}

	// Token: 0x06001939 RID: 6457 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001939")]
	[Address(RVA = "0x945590", Offset = "0x944590", VA = "0x180945590")]
	public void SetActionHighlight(string newString, bool val)
	{
	}

	// Token: 0x0600193A RID: 6458 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600193A")]
	[Address(RVA = "0x945960", Offset = "0x944960", VA = "0x180945960")]
	public void SetActionDisable(string newString, bool val)
	{
	}

	// Token: 0x0600193B RID: 6459 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600193B")]
	[Address(RVA = "0x945F70", Offset = "0x944F70", VA = "0x180945F70")]
	public void SetOriginalPosition(bool newVal, bool setGameTime = true, bool forceUpdate = false)
	{
	}

	// Token: 0x0600193C RID: 6460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600193C")]
	[Address(RVA = "0x946750", Offset = "0x945750", VA = "0x180946750")]
	public void SetTampered(bool val)
	{
	}

	// Token: 0x0600193D RID: 6461 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600193D")]
	[Address(RVA = "0x9469F0", Offset = "0x9459F0", VA = "0x1809469F0")]
	public void AddNewDynamicFingerprint(Human from, Interactable.PrintLife life)
	{
	}

	// Token: 0x0600193E RID: 6462 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600193E")]
	[Address(RVA = "0x946E30", Offset = "0x945E30", VA = "0x180946E30")]
	public void RemoveDynamicPrint(Interactable.DynamicFingerprint print)
	{
	}

	// Token: 0x0600193F RID: 6463 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600193F")]
	[Address(RVA = "0x946F50", Offset = "0x945F50", VA = "0x180946F50")]
	public void OnHourChange()
	{
	}

	// Token: 0x06001940 RID: 6464 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001940")]
	[Address(RVA = "0x947760", Offset = "0x946760", VA = "0x180947760")]
	public void OnLockpick()
	{
	}

	// Token: 0x06001941 RID: 6465 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001941")]
	[Address(RVA = "0x9481E0", Offset = "0x9471E0", VA = "0x1809481E0")]
	public void OnLockpickLookedAway()
	{
	}

	// Token: 0x06001942 RID: 6466 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001942")]
	[Address(RVA = "0x948250", Offset = "0x947250", VA = "0x180948250")]
	public void OnLockpickProgressChange(float amountChangeThisFrame, float amountToal)
	{
	}

	// Token: 0x06001943 RID: 6467 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001943")]
	[Address(RVA = "0x948C10", Offset = "0x947C10", VA = "0x180948C10")]
	public void OnCompleteLockpick()
	{
	}

	// Token: 0x06001944 RID: 6468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001944")]
	[Address(RVA = "0x948F20", Offset = "0x947F20", VA = "0x180948F20")]
	public void OnReturnFromLockpick()
	{
	}

	// Token: 0x06001945 RID: 6469 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001945")]
	[Address(RVA = "0x949580", Offset = "0x948580", VA = "0x180949580")]
	public void ForcePhysicsActive(bool forceSpawnLocation, bool applyForce, [Optional] Vector3 force, ForceMode forceMode = ForceMode.VelocityChange, bool useThrowingForce = false)
	{
	}

	// Token: 0x06001946 RID: 6470 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001946")]
	[Address(RVA = "0x94A0B0", Offset = "0x9490B0", VA = "0x18094A0B0")]
	public void ConvertToFurnitureSpawnedObject(FurnitureLocation newFurniture, FurniturePreset.SubObject newSubObject, bool updatePosition = true, bool updateSpawnPosition = true)
	{
	}

	// Token: 0x06001947 RID: 6471 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001947")]
	[Address(RVA = "0x94A590", Offset = "0x949590", VA = "0x18094A590")]
	public void ConvertToWorldObject(bool updatePosition = true)
	{
	}

	// Token: 0x06001948 RID: 6472 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001948")]
	[Address(RVA = "0x94A710", Offset = "0x949710", VA = "0x18094A710")]
	public void ResetToFurnitureObject(bool updatePosition = true)
	{
	}

	// Token: 0x06001949 RID: 6473 RVA: 0x0000BB50 File Offset: 0x00009D50
	[Token(Token = "0x6001949")]
	[Address(RVA = "0x94B650", Offset = "0x94A650", VA = "0x18094B650")]
	public bool IsLitter()
	{
		return default(bool);
	}

	// Token: 0x0600194A RID: 6474 RVA: 0x0000BB68 File Offset: 0x00009D68
	[Token(Token = "0x600194A")]
	[Address(RVA = "0x94B820", Offset = "0x94A820", VA = "0x18094B820")]
	public bool PickUpTarget(Human pickerUpper, bool pickUpLitter = false)
	{
		return default(bool);
	}

	// Token: 0x0600194B RID: 6475 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600194B")]
	[Address(RVA = "0x94C2C0", Offset = "0x94B2C0", VA = "0x18094C2C0")]
	public void RemoveManuallyCreatedFingerprints()
	{
	}

	// Token: 0x0600194C RID: 6476 RVA: 0x0000BB80 File Offset: 0x00009D80
	[Token(Token = "0x600194C")]
	[Address(RVA = "0x94C3A0", Offset = "0x94B3A0", VA = "0x18094C3A0")]
	public float GetReachDistance()
	{
		return 0f;
	}

	// Token: 0x0600194D RID: 6477 RVA: 0x0000BB98 File Offset: 0x00009D98
	[Token(Token = "0x600194D")]
	[Address(RVA = "0x94C470", Offset = "0x94B470", VA = "0x18094C470")]
	public float GetSecurityStrength()
	{
		return 0f;
	}

	// Token: 0x0600194E RID: 6478 RVA: 0x0000BBB0 File Offset: 0x00009DB0
	[Token(Token = "0x600194E")]
	[Address(RVA = "0x94C6F0", Offset = "0x94B6F0", VA = "0x18094C6F0")]
	public bool IsInteractablePhysicsObject()
	{
		return default(bool);
	}

	// Token: 0x0600194F RID: 6479 RVA: 0x0000BBC8 File Offset: 0x00009DC8
	[Token(Token = "0x600194F")]
	[Address(RVA = "0x94C730", Offset = "0x94B730", VA = "0x18094C730")]
	public bool GetSwitchQuery(InteractablePreset.Switch switchState)
	{
		return default(bool);
	}

	// Token: 0x06001950 RID: 6480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001950")]
	[Address(RVA = "0x94CAF0", Offset = "0x94BAF0", VA = "0x18094CAF0")]
	public void SetSwtichByType(InteractablePreset.Switch switchState, bool val, Actor interactor, bool playSFX = true, bool forceUpdate = false)
	{
	}

	// Token: 0x06001951 RID: 6481 RVA: 0x0000BBE0 File Offset: 0x00009DE0
	[Token(Token = "0x6001951")]
	[Address(RVA = "0x94CBF0", Offset = "0x94BBF0", VA = "0x18094CBF0")]
	public bool TryGetCreationTime(out float creationTime)
	{
		return default(bool);
	}

	// Token: 0x06001952 RID: 6482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001952")]
	[Address(RVA = "0x94CD60", Offset = "0x94BD60", VA = "0x18094CD60")]
	public void MarkInspected()
	{
	}

	// Token: 0x06001953 RID: 6483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001953")]
	[Address(RVA = "0x94D110", Offset = "0x94C110", VA = "0x18094D110")]
	public void MarkLastMovedAt()
	{
	}

	// Token: 0x06001954 RID: 6484 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001954")]
	[Address(RVA = "0x94D5F0", Offset = "0x94C5F0", VA = "0x18094D5F0")]
	public void ResetLastMovedAt()
	{
	}

	// Token: 0x06001955 RID: 6485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001955")]
	[Address(RVA = "0x94D7F0", Offset = "0x94C7F0", VA = "0x18094D7F0")]
	public void SetObjectSpawnPriority(int val)
	{
	}

	// Token: 0x06001956 RID: 6486 RVA: 0x0000BBF8 File Offset: 0x00009DF8
	[Token(Token = "0x6001956")]
	[Address(RVA = "0x94DCB0", Offset = "0x94CCB0", VA = "0x18094DCB0")]
	public int GetObjectSpawnPriority()
	{
		return 0;
	}

	// Token: 0x06001957 RID: 6487 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001957")]
	[Address(RVA = "0x94DE60", Offset = "0x94CE60", VA = "0x18094DE60")]
	public void SetDistanceRecognitionMode(bool val)
	{
	}

	// Token: 0x06001958 RID: 6488 RVA: 0x0000BC10 File Offset: 0x00009E10
	[Token(Token = "0x6001958")]
	[Address(RVA = "0x94E320", Offset = "0x94D320", VA = "0x18094E320")]
	public bool GetDistanceRecognitionMode()
	{
		return default(bool);
	}

	// Token: 0x06001959 RID: 6489 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001959")]
	[Address(RVA = "0x94E4D0", Offset = "0x94D4D0", VA = "0x18094E4D0")]
	public void CopyState(Interactable existing)
	{
	}

	// Token: 0x0600195B RID: 6491 RVA: 0x0000BC28 File Offset: 0x00009E28
	[Token(Token = "0x600195B")]
	[Address(RVA = "0x94EBA0", Offset = "0x94DBA0", VA = "0x18094EBA0")]
	private bool <OnCreate>b__138_0(GameplayControls.SyncDiskColour item)
	{
		return default(bool);
	}

	// Token: 0x0600195C RID: 6492 RVA: 0x0000BC40 File Offset: 0x00009E40
	[Token(Token = "0x600195C")]
	[Address(RVA = "0x94EBA0", Offset = "0x94DBA0", VA = "0x18094EBA0")]
	private bool <OnCreate>b__138_1(GameplayControls.SyncDiskColour item)
	{
		return default(bool);
	}

	// Token: 0x0600195D RID: 6493 RVA: 0x0000BC58 File Offset: 0x00009E58
	[Token(Token = "0x600195D")]
	[Address(RVA = "0x94EBA0", Offset = "0x94DBA0", VA = "0x18094EBA0")]
	private bool <OnCreate>b__138_2(GameplayControls.SyncDiskColour item)
	{
		return default(bool);
	}

	// Token: 0x0600195E RID: 6494 RVA: 0x0000BC70 File Offset: 0x00009E70
	[Token(Token = "0x600195E")]
	[Address(RVA = "0x94EBA0", Offset = "0x94DBA0", VA = "0x18094EBA0")]
	private bool <OnCreate>b__138_3(GameplayControls.SyncDiskColour item)
	{
		return default(bool);
	}

	// Token: 0x0600195F RID: 6495 RVA: 0x0000BC88 File Offset: 0x00009E88
	[Token(Token = "0x600195F")]
	[Address(RVA = "0x94EBD0", Offset = "0x94DBD0", VA = "0x18094EBD0")]
	private bool <OnDecorItemRePlace>b__142_0(StateSaveData.ChangedLightswitch item)
	{
		return default(bool);
	}

	// Token: 0x06001960 RID: 6496 RVA: 0x0000BCA0 File Offset: 0x00009EA0
	[Token(Token = "0x6001960")]
	[Address(RVA = "0x94EC90", Offset = "0x94DC90", VA = "0x18094EC90")]
	private bool <RemoveSpecialCaseReferences>b__144_0(NewWall item)
	{
		return default(bool);
	}

	// Token: 0x06001961 RID: 6497 RVA: 0x0000BCB8 File Offset: 0x00009EB8
	[Token(Token = "0x6001961")]
	[Address(RVA = "0x94EBD0", Offset = "0x94DBD0", VA = "0x18094EBD0")]
	private bool <RemoveSpecialCaseReferences>b__144_1(StateSaveData.ChangedLightswitch item)
	{
		return default(bool);
	}

	// Token: 0x06001962 RID: 6498 RVA: 0x0000BCD0 File Offset: 0x00009ED0
	[Token(Token = "0x6001962")]
	[Address(RVA = "0x94ECB0", Offset = "0x94DCB0", VA = "0x18094ECB0")]
	private bool <RemoveSpecialCaseReferences>b__144_2(StateSaveData.ChangedLightswitch item)
	{
		return default(bool);
	}

	// Token: 0x06001963 RID: 6499 RVA: 0x0000BCE8 File Offset: 0x00009EE8
	[Token(Token = "0x6001963")]
	[Address(RVA = "0x64F560", Offset = "0x64E560", VA = "0x18064F560")]
	private bool <SetInInventory>b__167_0(Human.InteractionDialogInstance item)
	{
		return default(bool);
	}

	// Token: 0x06001964 RID: 6500 RVA: 0x0000BD00 File Offset: 0x00009F00
	[Token(Token = "0x6001964")]
	[Address(RVA = "0x94ED70", Offset = "0x94DD70", VA = "0x18094ED70")]
	private bool <SpawnObject>b__186_0(InteractableController item)
	{
		return default(bool);
	}

	// Token: 0x06001965 RID: 6501 RVA: 0x0000BD18 File Offset: 0x00009F18
	[Token(Token = "0x6001965")]
	[Address(RVA = "0x94EDA0", Offset = "0x94DDA0", VA = "0x18094EDA0")]
	private bool <SpawnObject>b__186_1(FurnitureLocation item)
	{
		return default(bool);
	}

	// Token: 0x06001966 RID: 6502 RVA: 0x0000BD30 File Offset: 0x00009F30
	[Token(Token = "0x6001966")]
	[Address(RVA = "0x94EC90", Offset = "0x94DC90", VA = "0x18094EC90")]
	private bool <RemoveFromPlacement>b__192_0(NewWall item)
	{
		return default(bool);
	}

	// Token: 0x06001967 RID: 6503 RVA: 0x0000BD48 File Offset: 0x00009F48
	[Token(Token = "0x6001967")]
	[Address(RVA = "0x94EBD0", Offset = "0x94DBD0", VA = "0x18094EBD0")]
	private bool <RemoveFromPlacement>b__192_1(StateSaveData.ChangedLightswitch item)
	{
		return default(bool);
	}

	// Token: 0x06001968 RID: 6504 RVA: 0x0000BD60 File Offset: 0x00009F60
	[Token(Token = "0x6001968")]
	[Address(RVA = "0x94ECB0", Offset = "0x94DCB0", VA = "0x18094ECB0")]
	private bool <RemoveFromPlacement>b__192_2(StateSaveData.ChangedLightswitch item)
	{
		return default(bool);
	}

	// Token: 0x06001969 RID: 6505 RVA: 0x0000BD78 File Offset: 0x00009F78
	[Token(Token = "0x6001969")]
	[Address(RVA = "0x94EDE0", Offset = "0x94DDE0", VA = "0x18094EDE0")]
	private bool <Delete>b__194_0(InfoWindow item)
	{
		return default(bool);
	}

	// Token: 0x0600196A RID: 6506 RVA: 0x0000BD90 File Offset: 0x00009F90
	[Token(Token = "0x600196A")]
	[Address(RVA = "0x94EE10", Offset = "0x94DE10", VA = "0x18094EE10")]
	private bool <Delete>b__194_1(GameplayController.History item)
	{
		return default(bool);
	}

	// Token: 0x0600196B RID: 6507 RVA: 0x0000BDA8 File Offset: 0x00009FA8
	[Token(Token = "0x600196B")]
	[Address(RVA = "0x94EE10", Offset = "0x94DE10", VA = "0x18094EE10")]
	private bool <IsSafeToDelete>b__195_0(GameplayController.History item)
	{
		return default(bool);
	}

	// Token: 0x0600196C RID: 6508 RVA: 0x0000BDC0 File Offset: 0x00009FC0
	[Token(Token = "0x600196C")]
	[Address(RVA = "0x94EE80", Offset = "0x94DE80", VA = "0x18094EE80")]
	private bool <IsSafeToDelete>b__195_1(InfoWindow item)
	{
		return default(bool);
	}

	// Token: 0x0600196D RID: 6509 RVA: 0x0000BDD8 File Offset: 0x00009FD8
	[Token(Token = "0x600196D")]
	[Address(RVA = "0x94EEC0", Offset = "0x94DEC0", VA = "0x18094EEC0")]
	private bool <IsSafeToDelete>b__195_2(Case.CaseElement item)
	{
		return default(bool);
	}

	// Token: 0x0600196E RID: 6510 RVA: 0x0000BDF0 File Offset: 0x00009FF0
	[Token(Token = "0x600196E")]
	[Address(RVA = "0x94EEC0", Offset = "0x94DEC0", VA = "0x18094EEC0")]
	private bool <IsSafeToDelete>b__195_3(Case.CaseElement item)
	{
		return default(bool);
	}

	// Token: 0x0600196F RID: 6511 RVA: 0x0000BE08 File Offset: 0x0000A008
	[Token(Token = "0x600196F")]
	[Address(RVA = "0x82AE00", Offset = "0x829E00", VA = "0x18082AE00")]
	private bool <ResetToFurnitureObject>b__220_0(FurnitureLocation item)
	{
		return default(bool);
	}

	// Token: 0x06001970 RID: 6512 RVA: 0x0000BE20 File Offset: 0x0000A020
	[Token(Token = "0x6001970")]
	[Address(RVA = "0x82AE00", Offset = "0x829E00", VA = "0x18082AE00")]
	private bool <ResetToFurnitureObject>b__220_1(FurnitureLocation item)
	{
		return default(bool);
	}

	// Token: 0x06001971 RID: 6513 RVA: 0x0000BE38 File Offset: 0x0000A038
	[Token(Token = "0x6001971")]
	[Address(RVA = "0x82AE00", Offset = "0x829E00", VA = "0x18082AE00")]
	private bool <ResetToFurnitureObject>b__220_2(FurnitureLocation item)
	{
		return default(bool);
	}

	// Token: 0x06001972 RID: 6514 RVA: 0x0000BE50 File Offset: 0x0000A050
	[Token(Token = "0x6001972")]
	[Address(RVA = "0x94EF30", Offset = "0x94DF30", VA = "0x18094EF30")]
	private bool <PickUpTarget>b__222_0(FirstPersonItemController.InventorySlot item)
	{
		return default(bool);
	}

	// Token: 0x04001E20 RID: 7712
	[Token(Token = "0x4001E20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	// Token: 0x04001E21 RID: 7713
	[Token(Token = "0x4001E21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[NonSerialized]
	public static int worldAssignID;

	// Token: 0x04001E22 RID: 7714
	[Token(Token = "0x4001E22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector3 wPos;

	// Token: 0x04001E23 RID: 7715
	[Token(Token = "0x4001E23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 wEuler;

	// Token: 0x04001E24 RID: 7716
	[Token(Token = "0x4001E24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 lPos;

	// Token: 0x04001E25 RID: 7717
	[Token(Token = "0x4001E25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 lEuler;

	// Token: 0x04001E26 RID: 7718
	[Token(Token = "0x4001E26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 spWPos;

	// Token: 0x04001E27 RID: 7719
	[Token(Token = "0x4001E27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3 spWEuler;

	// Token: 0x04001E28 RID: 7720
	[Token(Token = "0x4001E28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string p;

	// Token: 0x04001E29 RID: 7721
	[Token(Token = "0x4001E29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Interactable.Passed> pv;

	// Token: 0x04001E2A RID: 7722
	[Token(Token = "0x4001E2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int fp;

	// Token: 0x04001E2B RID: 7723
	[Token(Token = "0x4001E2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int fsoi;

	// Token: 0x04001E2C RID: 7724
	[Token(Token = "0x4001E2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int dp;

	// Token: 0x04001E2D RID: 7725
	[Token(Token = "0x4001E2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Toolbox.MaterialKey mk;

	// Token: 0x04001E2E RID: 7726
	[Token(Token = "0x4001E2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Interactable.LightConfiguration lcd;

	// Token: 0x04001E2F RID: 7727
	[Token(Token = "0x4001E2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public string lp;

	// Token: 0x04001E30 RID: 7728
	[Token(Token = "0x4001E30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string dds;

	// Token: 0x04001E31 RID: 7729
	[Token(Token = "0x4001E31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public int w;

	// Token: 0x04001E32 RID: 7730
	[Token(Token = "0x4001E32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public int r;

	// Token: 0x04001E33 RID: 7731
	[Token(Token = "0x4001E33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public int b;

	// Token: 0x04001E34 RID: 7732
	[Token(Token = "0x4001E34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public int inv;

	// Token: 0x04001E35 RID: 7733
	[Token(Token = "0x4001E35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float val;

	// Token: 0x04001E36 RID: 7734
	[Token(Token = "0x4001E36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public float cs;

	// Token: 0x04001E37 RID: 7735
	[Token(Token = "0x4001E37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool wo;

	// Token: 0x04001E38 RID: 7736
	[Token(Token = "0x4001E38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public string bo;

	// Token: 0x04001E39 RID: 7737
	[Token(Token = "0x4001E39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public string sd;

	// Token: 0x04001E3A RID: 7738
	[Token(Token = "0x4001E3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public bool sw0;

	// Token: 0x04001E3B RID: 7739
	[Token(Token = "0x4001E3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
	public bool sw1;

	// Token: 0x04001E3C RID: 7740
	[Token(Token = "0x4001E3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD2")]
	public bool sw2;

	// Token: 0x04001E3D RID: 7741
	[Token(Token = "0x4001E3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD3")]
	public bool sw3;

	// Token: 0x04001E3E RID: 7742
	[Token(Token = "0x4001E3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool locked;

	// Token: 0x04001E3F RID: 7743
	[Token(Token = "0x4001E3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public int lzs;

	// Token: 0x04001E40 RID: 7744
	[Token(Token = "0x4001E40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public bool ml;

	// Token: 0x04001E41 RID: 7745
	[Token(Token = "0x4001E41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public List<InteractablePreset.SubSpawnSlot> ssp;

	// Token: 0x04001E42 RID: 7746
	[Token(Token = "0x4001E42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public float mtr;

	// Token: 0x04001E43 RID: 7747
	[Token(Token = "0x4001E43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public bool cr;

	// Token: 0x04001E44 RID: 7748
	[Token(Token = "0x4001E44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
	public bool rem;

	// Token: 0x04001E45 RID: 7749
	[Token(Token = "0x4001E45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEE")]
	public bool rPl;

	// Token: 0x04001E46 RID: 7750
	[Token(Token = "0x4001E46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEF")]
	public bool spCh;

	// Token: 0x04001E47 RID: 7751
	[Token(Token = "0x4001E47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public bool force;

	// Token: 0x04001E48 RID: 7752
	[Token(Token = "0x4001E48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public List<Interactable.DynamicFingerprint> df;

	// Token: 0x04001E49 RID: 7753
	[Token(Token = "0x4001E49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public List<Interactable.SavedPrint> print;

	// Token: 0x04001E4A RID: 7754
	[Token(Token = "0x4001E4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public List<SceneRecorder.SceneCapture> cap;

	// Token: 0x04001E4B RID: 7755
	[Token(Token = "0x4001E4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public List<SceneRecorder.SceneCapture> sCap;

	// Token: 0x04001E4C RID: 7756
	[Token(Token = "0x4001E4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public int nEvKey;

	// Token: 0x04001E4D RID: 7757
	[Token(Token = "0x4001E4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public bool ft;

	// Token: 0x04001E4E RID: 7758
	[Token(Token = "0x4001E4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public GameplayController.Passcode passcode;

	// Token: 0x04001E4F RID: 7759
	[Token(Token = "0x4001E4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[NonSerialized]
	public string name;

	// Token: 0x04001E50 RID: 7760
	[Token(Token = "0x4001E50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[NonSerialized]
	public Vector3Int spNode;

	// Token: 0x04001E51 RID: 7761
	[Token(Token = "0x4001E51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	[NonSerialized]
	public int pt;

	// Token: 0x04001E52 RID: 7762
	[Token(Token = "0x4001E52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[NonSerialized]
	public bool mov;

	// Token: 0x04001E53 RID: 7763
	[Token(Token = "0x4001E53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
	[NonSerialized]
	public bool phy;

	// Token: 0x04001E54 RID: 7764
	[Token(Token = "0x4001E54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x142")]
	[NonSerialized]
	public bool audioLoopStarted;

	// Token: 0x04001E55 RID: 7765
	[Token(Token = "0x4001E55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[NonSerialized]
	public Telephone t;

	// Token: 0x04001E56 RID: 7766
	[Token(Token = "0x4001E56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[NonSerialized]
	public string seed;

	// Token: 0x04001E57 RID: 7767
	[Token(Token = "0x4001E57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[NonSerialized]
	public bool save;

	// Token: 0x04001E58 RID: 7768
	[Token(Token = "0x4001E58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
	[NonSerialized]
	public bool isTampered;

	// Token: 0x04001E59 RID: 7769
	[Token(Token = "0x4001E59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	[NonSerialized]
	public float distanceFromSpawn;

	// Token: 0x04001E5A RID: 7770
	[Token(Token = "0x4001E5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	[NonSerialized]
	public bool originalPosition;

	// Token: 0x04001E5B RID: 7771
	[Token(Token = "0x4001E5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	[NonSerialized]
	public Vector3 cvp;

	// Token: 0x04001E5C RID: 7772
	[Token(Token = "0x4001E5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	[NonSerialized]
	public Vector3 cve;

	// Token: 0x04001E5D RID: 7773
	[Token(Token = "0x4001E5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	[NonSerialized]
	public Evidence evidence;

	// Token: 0x04001E5E RID: 7774
	[Token(Token = "0x4001E5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[NonSerialized]
	public SceneRecorder sceneRecorder;

	// Token: 0x04001E5F RID: 7775
	[Token(Token = "0x4001E5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[NonSerialized]
	public Transform spawnParent;

	// Token: 0x04001E60 RID: 7776
	[Token(Token = "0x4001E60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[NonSerialized]
	public Transform parentTransform;

	// Token: 0x04001E61 RID: 7777
	[Token(Token = "0x4001E61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	[NonSerialized]
	public Human inInventory;

	// Token: 0x04001E62 RID: 7778
	[Token(Token = "0x4001E62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[NonSerialized]
	public InteractablePreset preset;

	// Token: 0x04001E63 RID: 7779
	[Token(Token = "0x4001E63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	[NonSerialized]
	public FurnitureLocation furnitureParent;

	// Token: 0x04001E64 RID: 7780
	[Token(Token = "0x4001E64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	[NonSerialized]
	public FurniturePreset.SubObject subObject;

	// Token: 0x04001E65 RID: 7781
	[Token(Token = "0x4001E65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	[NonSerialized]
	public SideJob jobParent;

	// Token: 0x04001E66 RID: 7782
	[Token(Token = "0x4001E66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	[NonSerialized]
	public MurderController.Murder murderParent;

	// Token: 0x04001E67 RID: 7783
	[Token(Token = "0x4001E67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	[NonSerialized]
	public SpeechController speechController;

	// Token: 0x04001E68 RID: 7784
	[Token(Token = "0x4001E68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	[NonSerialized]
	public InteractableController controller;

	// Token: 0x04001E69 RID: 7785
	[Token(Token = "0x4001E69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	[NonSerialized]
	public LightController lightController;

	// Token: 0x04001E6A RID: 7786
	[Token(Token = "0x4001E6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	[NonSerialized]
	public Interactable lockInteractable;

	// Token: 0x04001E6B RID: 7787
	[Token(Token = "0x4001E6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	[NonSerialized]
	public Interactable thisDoor;

	// Token: 0x04001E6C RID: 7788
	[Token(Token = "0x4001E6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	[NonSerialized]
	public object passwordSource;

	// Token: 0x04001E6D RID: 7789
	[Token(Token = "0x4001E6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	[NonSerialized]
	public GameObject spawnedObject;

	// Token: 0x04001E6E RID: 7790
	[Token(Token = "0x4001E6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	[NonSerialized]
	public NewNode node;

	// Token: 0x04001E6F RID: 7791
	[Token(Token = "0x4001E6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	[NonSerialized]
	public NewNode spawnNode;

	// Token: 0x04001E70 RID: 7792
	[Token(Token = "0x4001E70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	[NonSerialized]
	public NewRoom worldObjectRoomParent;

	// Token: 0x04001E71 RID: 7793
	[Token(Token = "0x4001E71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	[NonSerialized]
	public Interactable.UsagePoint usagePoint;

	// Token: 0x04001E72 RID: 7794
	[Token(Token = "0x4001E72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	[NonSerialized]
	public NewAIAction nextAIInteraction;

	// Token: 0x04001E73 RID: 7795
	[Token(Token = "0x4001E73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	[NonSerialized]
	public LightingPreset isLight;

	// Token: 0x04001E74 RID: 7796
	[Token(Token = "0x4001E74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	[NonSerialized]
	public object objectRef;

	// Token: 0x04001E75 RID: 7797
	[Token(Token = "0x4001E75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	[NonSerialized]
	public Human writer;

	// Token: 0x04001E76 RID: 7798
	[Token(Token = "0x4001E76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	[NonSerialized]
	public Human reciever;

	// Token: 0x04001E77 RID: 7799
	[Token(Token = "0x4001E77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	[NonSerialized]
	public Human belongsTo;

	// Token: 0x04001E78 RID: 7800
	[Token(Token = "0x4001E78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	[NonSerialized]
	public Actor isActor;

	// Token: 0x04001E79 RID: 7801
	[Token(Token = "0x4001E79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	[NonSerialized]
	public BookPreset book;

	// Token: 0x04001E7A RID: 7802
	[Token(Token = "0x4001E7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	[NonSerialized]
	public SyncDiskPreset syncDisk;

	// Token: 0x04001E7B RID: 7803
	[Token(Token = "0x4001E7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	[NonSerialized]
	public GroupsController.SocialGroup group;

	// Token: 0x04001E7C RID: 7804
	[Token(Token = "0x4001E7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	[NonSerialized]
	public float recentCallCheck;

	// Token: 0x04001E7D RID: 7805
	[Token(Token = "0x4001E7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	[NonSerialized]
	private Transform ceilingFan;

	// Token: 0x04001E7E RID: 7806
	[Token(Token = "0x4001E7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	[NonSerialized]
	public NewAddress forSale;

	// Token: 0x04001E7F RID: 7807
	[Token(Token = "0x4001E7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	[NonSerialized]
	public List<Human> proxy;

	// Token: 0x04001E80 RID: 7808
	[Token(Token = "0x4001E80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	[NonSerialized]
	public List<SpatterSimulation.DecalSpawnData> spawnedDecals;

	// Token: 0x04001E81 RID: 7809
	[Token(Token = "0x4001E81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	[NonSerialized]
	public AudioController.LoopingSoundInfo actionLoop;

	// Token: 0x04001E82 RID: 7810
	[Token(Token = "0x4001E82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	[NonSerialized]
	public bool loadedGeometry;

	// Token: 0x04001E83 RID: 7811
	[Token(Token = "0x4001E83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	[NonSerialized]
	public Dictionary<InteractablePreset.InteractionKey, Interactable.InteractableCurrentAction> currentActions;

	// Token: 0x04001E84 RID: 7812
	[Token(Token = "0x4001E84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	[NonSerialized]
	public List<InteractablePreset.InteractionAction> highlightActions;

	// Token: 0x04001E85 RID: 7813
	[Token(Token = "0x4001E85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	[NonSerialized]
	public List<InteractablePreset.InteractionAction> disabledActions;

	// Token: 0x04001E86 RID: 7814
	[Token(Token = "0x4001E86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	[NonSerialized]
	public Dictionary<AIActionPreset, InteractablePreset.InteractionAction> aiActionReference;

	// Token: 0x04001E87 RID: 7815
	[Token(Token = "0x4001E87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	[NonSerialized]
	public float readingDelay;

	// Token: 0x04001E88 RID: 7816
	[Token(Token = "0x4001E88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	[NonSerialized]
	public Dictionary<AIActionPreset, AudioEvent> actionAudioEventOverrides;

	// Token: 0x04001E89 RID: 7817
	[Token(Token = "0x4001E89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	[NonSerialized]
	public List<AudioController.LoopingSoundInfo> loopingAudio;

	// Token: 0x04001E8A RID: 7818
	[Token(Token = "0x4001E8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	[NonSerialized]
	private bool isSetup;

	// Token: 0x04001E8B RID: 7819
	[Token(Token = "0x4001E8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E9")]
	[NonSerialized]
	public bool wasLoadedFromSave;

	// Token: 0x04001E8C RID: 7820
	[Token(Token = "0x4001E8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2EA")]
	[NonSerialized]
	public bool mainSetupRun;

	// Token: 0x04001E8D RID: 7821
	[Token(Token = "0x4001E8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2EB")]
	[NonSerialized]
	public bool printDebug;

	// Token: 0x02000458 RID: 1112
	[Token(Token = "0x2000458")]
	[Serializable]
	public class LightConfiguration
	{
		// Token: 0x06001973 RID: 6515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001973")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public LightConfiguration()
		{
		}

		// Token: 0x04001E92 RID: 7826
		[Token(Token = "0x4001E92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color colour;

		// Token: 0x04001E93 RID: 7827
		[Token(Token = "0x4001E93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float intensity;

		// Token: 0x04001E94 RID: 7828
		[Token(Token = "0x4001E94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float flickerColourMultiplier;

		// Token: 0x04001E95 RID: 7829
		[Token(Token = "0x4001E95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float pulseSpeed;

		// Token: 0x04001E96 RID: 7830
		[Token(Token = "0x4001E96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intervalTime;

		// Token: 0x04001E97 RID: 7831
		[Token(Token = "0x4001E97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool flicker;

		// Token: 0x04001E98 RID: 7832
		[Token(Token = "0x4001E98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float range;
	}

	// Token: 0x02000459 RID: 1113
	[Token(Token = "0x2000459")]
	[Serializable]
	public class SavedPrint
	{
		// Token: 0x06001974 RID: 6516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001974")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public SavedPrint()
		{
		}

		// Token: 0x04001E99 RID: 7833
		[Token(Token = "0x4001E99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 worldPos;

		// Token: 0x04001E9A RID: 7834
		[Token(Token = "0x4001E9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int interactableID;
	}

	// Token: 0x0200045A RID: 1114
	[Token(Token = "0x200045A")]
	[Serializable]
	public class DynamicFingerprint
	{
		// Token: 0x06001975 RID: 6517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001975")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DynamicFingerprint()
		{
		}

		// Token: 0x04001E9B RID: 7835
		[Token(Token = "0x4001E9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x04001E9C RID: 7836
		[Token(Token = "0x4001E9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float created;

		// Token: 0x04001E9D RID: 7837
		[Token(Token = "0x4001E9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string seed;

		// Token: 0x04001E9E RID: 7838
		[Token(Token = "0x4001E9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Interactable.PrintLife life;
	}

	// Token: 0x0200045B RID: 1115
	[Token(Token = "0x200045B")]
	public enum PrintLife
	{
		// Token: 0x04001EA0 RID: 7840
		[Token(Token = "0x4001EA0")]
		timed,
		// Token: 0x04001EA1 RID: 7841
		[Token(Token = "0x4001EA1")]
		manualRemoval
	}

	// Token: 0x0200045C RID: 1116
	[Token(Token = "0x200045C")]
	public class InteractableCurrentAction
	{
		// Token: 0x06001976 RID: 6518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001976")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public InteractableCurrentAction()
		{
		}

		// Token: 0x04001EA2 RID: 7842
		[Token(Token = "0x4001EA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractablePreset.InteractionAction currentAction;

		// Token: 0x04001EA3 RID: 7843
		[Token(Token = "0x4001EA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool display;

		// Token: 0x04001EA4 RID: 7844
		[Token(Token = "0x4001EA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool enabled;

		// Token: 0x04001EA5 RID: 7845
		[Token(Token = "0x4001EA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string overrideInteractionName;

		// Token: 0x04001EA6 RID: 7846
		[Token(Token = "0x4001EA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool forcePositioning;

		// Token: 0x04001EA7 RID: 7847
		[Token(Token = "0x4001EA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ControlDisplayController.ControlPositioning forcePosition;

		// Token: 0x04001EA8 RID: 7848
		[Token(Token = "0x4001EA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool highlight;
	}

	// Token: 0x0200045D RID: 1117
	[Token(Token = "0x200045D")]
	[Serializable]
	public class UsagePoint
	{
		// Token: 0x06001977 RID: 6519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001977")]
		[Address(RVA = "0x953D00", Offset = "0x952D00", VA = "0x180953D00")]
		public UsagePoint(InteractablePreset.AIUseSetting newPreset, Interactable newInteractable, NewNode newNode)
		{
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001978")]
		[Address(RVA = "0x953FA0", Offset = "0x952FA0", VA = "0x180953FA0")]
		public void PositionUpdate()
		{
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x0000BE68 File Offset: 0x0000A068
		[Token(Token = "0x6001979")]
		[Address(RVA = "0x954F20", Offset = "0x953F20", VA = "0x180954F20")]
		public Vector3 GetUsageWorldPosition(Vector3 userPos, Actor actor)
		{
			return default(Vector3);
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x0000BE80 File Offset: 0x0000A080
		[Token(Token = "0x600197A")]
		[Address(RVA = "0x955D40", Offset = "0x954D40", VA = "0x180955D40")]
		private Vector3 GetPositionWithInvertedZ()
		{
			return default(Vector3);
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x0000BE98 File Offset: 0x0000A098
		[Token(Token = "0x600197B")]
		[Address(RVA = "0x956520", Offset = "0x955520", VA = "0x180956520")]
		public bool TrySetUser(Interactable.UsePointSlot slot, Human newUser, string debug = "")
		{
			return default(bool);
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197C")]
		[Address(RVA = "0x957000", Offset = "0x956000", VA = "0x180957000")]
		public void SetReserved(GroupsController.SocialGroup group)
		{
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		[Token(Token = "0x600197D")]
		[Address(RVA = "0x957340", Offset = "0x956340", VA = "0x180957340")]
		public bool TryGetUserAtSlot(Interactable.UsePointSlot slot, out Human user)
		{
			return default(bool);
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197E")]
		[Address(RVA = "0x9574F0", Offset = "0x9564F0", VA = "0x1809574F0")]
		public void RemoveUserFromAllSlots(Human user)
		{
		}

		// Token: 0x04001EA9 RID: 7849
		[Token(Token = "0x4001EA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractablePreset.AIUseSetting useSetting;

		// Token: 0x04001EAA RID: 7850
		[Token(Token = "0x4001EAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Interactable interactable;

		// Token: 0x04001EAB RID: 7851
		[Token(Token = "0x4001EAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NewNode node;

		// Token: 0x04001EAC RID: 7852
		[Token(Token = "0x4001EAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<Interactable.UsePointSlot, Human> users;

		// Token: 0x04001EAD RID: 7853
		[Token(Token = "0x4001EAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public GroupsController.SocialGroup reserved;

		// Token: 0x04001EAE RID: 7854
		[Token(Token = "0x4001EAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 useageWorldPosition;

		// Token: 0x04001EAF RID: 7855
		[Token(Token = "0x4001EAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 worldLookAtPoint;

		// Token: 0x04001EB0 RID: 7856
		[Token(Token = "0x4001EB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Human debugDefaultSlot;

		// Token: 0x04001EB1 RID: 7857
		[Token(Token = "0x4001EB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Human debugSlot1;

		// Token: 0x04001EB2 RID: 7858
		[Token(Token = "0x4001EB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Human debugSlot2;

		// Token: 0x04001EB3 RID: 7859
		[Token(Token = "0x4001EB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<string> slotLog;
	}

	// Token: 0x0200045E RID: 1118
	[Token(Token = "0x200045E")]
	public enum UsePointSlot
	{
		// Token: 0x04001EB5 RID: 7861
		[Token(Token = "0x4001EB5")]
		defaultSlot,
		// Token: 0x04001EB6 RID: 7862
		[Token(Token = "0x4001EB6")]
		slot1,
		// Token: 0x04001EB7 RID: 7863
		[Token(Token = "0x4001EB7")]
		slot2
	}

	// Token: 0x0200045F RID: 1119
	[Token(Token = "0x200045F")]
	public enum PassedVarType
	{
		// Token: 0x04001EB9 RID: 7865
		[Token(Token = "0x4001EB9")]
		jobID,
		// Token: 0x04001EBA RID: 7866
		[Token(Token = "0x4001EBA")]
		humanID,
		// Token: 0x04001EBB RID: 7867
		[Token(Token = "0x4001EBB")]
		noteID,
		// Token: 0x04001EBC RID: 7868
		[Token(Token = "0x4001EBC")]
		roomID,
		// Token: 0x04001EBD RID: 7869
		[Token(Token = "0x4001EBD")]
		addressID,
		// Token: 0x04001EBE RID: 7870
		[Token(Token = "0x4001EBE")]
		time,
		// Token: 0x04001EBF RID: 7871
		[Token(Token = "0x4001EBF")]
		savedSceneCapID,
		// Token: 0x04001EC0 RID: 7872
		[Token(Token = "0x4001EC0")]
		menuIndex,
		// Token: 0x04001EC1 RID: 7873
		[Token(Token = "0x4001EC1")]
		vmailThreadID,
		// Token: 0x04001EC2 RID: 7874
		[Token(Token = "0x4001EC2")]
		consumableAmount,
		// Token: 0x04001EC3 RID: 7875
		[Token(Token = "0x4001EC3")]
		companyID,
		// Token: 0x04001EC4 RID: 7876
		[Token(Token = "0x4001EC4")]
		stringInteractablePreset,
		// Token: 0x04001EC5 RID: 7877
		[Token(Token = "0x4001EC5")]
		isTrash,
		// Token: 0x04001EC6 RID: 7878
		[Token(Token = "0x4001EC6")]
		jobTag,
		// Token: 0x04001EC7 RID: 7879
		[Token(Token = "0x4001EC7")]
		groupID,
		// Token: 0x04001EC8 RID: 7880
		[Token(Token = "0x4001EC8")]
		ddsOverride,
		// Token: 0x04001EC9 RID: 7881
		[Token(Token = "0x4001EC9")]
		metaObjectID,
		// Token: 0x04001ECA RID: 7882
		[Token(Token = "0x4001ECA")]
		murderID,
		// Token: 0x04001ECB RID: 7883
		[Token(Token = "0x4001ECB")]
		decal,
		// Token: 0x04001ECC RID: 7884
		[Token(Token = "0x4001ECC")]
		decalDynamicText,
		// Token: 0x04001ECD RID: 7885
		[Token(Token = "0x4001ECD")]
		ownedByAddress,
		// Token: 0x04001ECE RID: 7886
		[Token(Token = "0x4001ECE")]
		vmailThreadMsgIndex,
		// Token: 0x04001ECF RID: 7887
		[Token(Token = "0x4001ECF")]
		phoneNumber,
		// Token: 0x04001ED0 RID: 7888
		[Token(Token = "0x4001ED0")]
		lostItemPreset,
		// Token: 0x04001ED1 RID: 7889
		[Token(Token = "0x4001ED1")]
		lostItemBuilding,
		// Token: 0x04001ED2 RID: 7890
		[Token(Token = "0x4001ED2")]
		lostItemReward,
		// Token: 0x04001ED3 RID: 7891
		[Token(Token = "0x4001ED3")]
		lostItemFloorX,
		// Token: 0x04001ED4 RID: 7892
		[Token(Token = "0x4001ED4")]
		lostItemFloorY,
		// Token: 0x04001ED5 RID: 7893
		[Token(Token = "0x4001ED5")]
		creationTime,
		// Token: 0x04001ED6 RID: 7894
		[Token(Token = "0x4001ED6")]
		stateValue,
		// Token: 0x04001ED7 RID: 7895
		[Token(Token = "0x4001ED7")]
		inspected,
		// Token: 0x04001ED8 RID: 7896
		[Token(Token = "0x4001ED8")]
		lma,
		// Token: 0x04001ED9 RID: 7897
		[Token(Token = "0x4001ED9")]
		spR,
		// Token: 0x04001EDA RID: 7898
		[Token(Token = "0x4001EDA")]
		spP,
		// Token: 0x04001EDB RID: 7899
		[Token(Token = "0x4001EDB")]
		phy,
		// Token: 0x04001EDC RID: 7900
		[Token(Token = "0x4001EDC")]
		drm,
		// Token: 0x04001EDD RID: 7901
		[Token(Token = "0x4001EDD")]
		lhc,
		// Token: 0x04001EDE RID: 7902
		[Token(Token = "0x4001EDE")]
		inStorage
	}

	// Token: 0x02000460 RID: 1120
	[Token(Token = "0x2000460")]
	[Serializable]
	public class Passed
	{
		// Token: 0x0600197F RID: 6527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197F")]
		[Address(RVA = "0x957970", Offset = "0x956970", VA = "0x180957970")]
		public Passed(Interactable.PassedVarType newType, float newVal, [Optional] string newStr)
		{
		}

		// Token: 0x04001EDF RID: 7903
		[Token(Token = "0x4001EDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Interactable.PassedVarType varType;

		// Token: 0x04001EE0 RID: 7904
		[Token(Token = "0x4001EE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float value;

		// Token: 0x04001EE1 RID: 7905
		[Token(Token = "0x4001EE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string str;
	}

	// Token: 0x02000461 RID: 1121
	// (Invoke) Token: 0x06001981 RID: 6529
	[Token(Token = "0x2000461")]
	public delegate void SwitchChange();

	// Token: 0x02000462 RID: 1122
	// (Invoke) Token: 0x06001985 RID: 6533
	[Token(Token = "0x2000462")]
	public delegate void State1Change();

	// Token: 0x02000463 RID: 1123
	// (Invoke) Token: 0x06001989 RID: 6537
	[Token(Token = "0x2000463")]
	public delegate void Deleted(Interactable destroyed);

	// Token: 0x02000464 RID: 1124
	// (Invoke) Token: 0x0600198D RID: 6541
	[Token(Token = "0x2000464")]
	public delegate void RemovedFromWorld();

	// Token: 0x02000465 RID: 1125
	[Token(Token = "0x2000465")]
	private sealed class <>c__DisplayClass137_0
	{
		// Token: 0x06001990 RID: 6544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001990")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass137_0()
		{
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		[Token(Token = "0x6001991")]
		[Address(RVA = "0x9579D0", Offset = "0x9569D0", VA = "0x1809579D0")]
		internal bool <UpdatePassedVariables>b__0(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		[Token(Token = "0x6001992")]
		[Address(RVA = "0x9579D0", Offset = "0x9569D0", VA = "0x1809579D0")]
		internal bool <UpdatePassedVariables>b__1(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		[Token(Token = "0x6001993")]
		[Address(RVA = "0x957A00", Offset = "0x956A00", VA = "0x180957A00")]
		internal bool <UpdatePassedVariables>b__2(GroupsController.SocialGroup item)
		{
			return default(bool);
		}

		// Token: 0x04001EE2 RID: 7906
		[Token(Token = "0x4001EE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Interactable.Passed p;
	}

	// Token: 0x02000466 RID: 1126
	[Token(Token = "0x2000466")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001995 RID: 6549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001995")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x0000BF10 File Offset: 0x0000A110
		[Token(Token = "0x6001996")]
		[Address(RVA = "0x957AF0", Offset = "0x956AF0", VA = "0x180957AF0")]
		internal bool <UpdateSpecialCaseReferences>b__143_1(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x0000BF28 File Offset: 0x0000A128
		[Token(Token = "0x6001997")]
		[Address(RVA = "0x790090", Offset = "0x78F090", VA = "0x180790090")]
		internal bool <UpdateSpecialCaseReferences>b__143_0(InteractablePreset.IfSwitchStateSFX item)
		{
			return default(bool);
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x0000BF40 File Offset: 0x0000A140
		[Token(Token = "0x6001998")]
		[Address(RVA = "0x957B10", Offset = "0x956B10", VA = "0x180957B10")]
		internal bool <SetExtraStateValue>b__150_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0000BF58 File Offset: 0x0000A158
		[Token(Token = "0x6001999")]
		[Address(RVA = "0x957B10", Offset = "0x956B10", VA = "0x180957B10")]
		internal bool <GetExtraStateValue>b__151_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0000BF70 File Offset: 0x0000A170
		[Token(Token = "0x600199A")]
		[Address(RVA = "0x57B220", Offset = "0x57A220", VA = "0x18057B220")]
		internal bool <SetDDSOverride>b__152_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0000BF88 File Offset: 0x0000A188
		[Token(Token = "0x600199B")]
		[Address(RVA = "0x790090", Offset = "0x78F090", VA = "0x180790090")]
		internal bool <GetName>b__165_0(DDSSaveClasses.DDSBlockCondition item)
		{
			return default(bool);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		[Token(Token = "0x600199C")]
		[Address(RVA = "0x957B30", Offset = "0x956B30", VA = "0x180957B30")]
		internal bool <SetInInventory>b__167_1(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		[Token(Token = "0x600199D")]
		[Address(RVA = "0x957B60", Offset = "0x956B60", VA = "0x180957B60")]
		internal int <SetInInventory>b__167_2(Interactable p1, Interactable p2)
		{
			return 0;
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		[Token(Token = "0x600199E")]
		[Address(RVA = "0x6DF3D0", Offset = "0x6DE3D0", VA = "0x1806DF3D0")]
		internal int <UpdateCurrentActions>b__169_0(InteractablePreset.InteractionAction p1, InteractablePreset.InteractionAction p2)
		{
			return 0;
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		[Token(Token = "0x600199F")]
		[Address(RVA = "0x957BA0", Offset = "0x956BA0", VA = "0x180957BA0")]
		internal bool <UpdateCurrentActions>b__169_1(Case item)
		{
			return default(bool);
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x0000C000 File Offset: 0x0000A200
		[Token(Token = "0x60019A0")]
		[Address(RVA = "0x790090", Offset = "0x78F090", VA = "0x180790090")]
		internal bool <SetSwitchState>b__170_0(InteractablePreset.IfSwitchStateSFX item)
		{
			return default(bool);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x0000C018 File Offset: 0x0000A218
		[Token(Token = "0x60019A1")]
		[Address(RVA = "0x790090", Offset = "0x78F090", VA = "0x180790090")]
		internal bool <SetCustomState1>b__171_0(InteractablePreset.IfSwitchStateSFX item)
		{
			return default(bool);
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x0000C030 File Offset: 0x0000A230
		[Token(Token = "0x60019A2")]
		[Address(RVA = "0x790090", Offset = "0x78F090", VA = "0x180790090")]
		internal bool <SetCustomState2>b__172_0(InteractablePreset.IfSwitchStateSFX item)
		{
			return default(bool);
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x0000C048 File Offset: 0x0000A248
		[Token(Token = "0x60019A3")]
		[Address(RVA = "0x790090", Offset = "0x78F090", VA = "0x180790090")]
		internal bool <SetCustomState3>b__173_0(InteractablePreset.IfSwitchStateSFX item)
		{
			return default(bool);
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0000C060 File Offset: 0x0000A260
		[Token(Token = "0x60019A4")]
		[Address(RVA = "0x790090", Offset = "0x78F090", VA = "0x180790090")]
		internal bool <SetLockedState>b__174_0(InteractablePreset.IfSwitchStateSFX item)
		{
			return default(bool);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0000C078 File Offset: 0x0000A278
		[Token(Token = "0x60019A5")]
		[Address(RVA = "0x957BC0", Offset = "0x956BC0", VA = "0x180957BC0")]
		internal bool <SetPhysicsPickupState>b__175_2(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x0000C090 File Offset: 0x0000A290
		[Token(Token = "0x60019A6")]
		[Address(RVA = "0x957BC0", Offset = "0x956BC0", VA = "0x180957BC0")]
		internal bool <SetPhysicsPickupState>b__175_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		[Token(Token = "0x60019A7")]
		[Address(RVA = "0x790090", Offset = "0x78F090", VA = "0x180790090")]
		internal bool <SetPhysicsPickupState>b__175_1(InteractablePreset.IfSwitchStateSFX item)
		{
			return default(bool);
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		[Token(Token = "0x60019A8")]
		[Address(RVA = "0x957BE0", Offset = "0x956BE0", VA = "0x180957BE0")]
		internal bool <UpdateSwitchStateAudio>b__177_1(SessionData.TelevisionChannel item)
		{
			return default(bool);
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		[Token(Token = "0x60019A9")]
		[Address(RVA = "0x477780", Offset = "0x476780", VA = "0x180477780")]
		internal bool <OnInteraction>b__182_1(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		[Token(Token = "0x60019AA")]
		[Address(RVA = "0x957C70", Offset = "0x956C70", VA = "0x180957C70")]
		internal bool <SetSpawnPositionRelevent>b__184_1(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x0000C108 File Offset: 0x0000A308
		[Token(Token = "0x60019AB")]
		[Address(RVA = "0x957C70", Offset = "0x956C70", VA = "0x180957C70")]
		internal bool <SetSpawnPositionRelevent>b__184_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x0000C120 File Offset: 0x0000A320
		[Token(Token = "0x60019AC")]
		[Address(RVA = "0x957C70", Offset = "0x956C70", VA = "0x180957C70")]
		internal bool <IsSpawnPositionRelevent>b__185_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x0000C138 File Offset: 0x0000A338
		[Token(Token = "0x60019AD")]
		[Address(RVA = "0x957C90", Offset = "0x956C90", VA = "0x180957C90")]
		internal bool <OnDoorMovementClosed>b__200_0(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x0000C150 File Offset: 0x0000A350
		[Token(Token = "0x60019AE")]
		[Address(RVA = "0x820590", Offset = "0x81F590", VA = "0x180820590")]
		internal bool <OnDoorMovementClosed>b__200_1(InteractablePreset.SwitchState item2)
		{
			return default(bool);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x0000C168 File Offset: 0x0000A368
		[Token(Token = "0x60019AF")]
		[Address(RVA = "0x957E40", Offset = "0x956E40", VA = "0x180957E40")]
		internal bool <OnHourChange>b__211_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x0000C180 File Offset: 0x0000A380
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x957E40", Offset = "0x956E40", VA = "0x180957E40")]
		internal bool <OnHourChange>b__211_1(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x0000C198 File Offset: 0x0000A398
		[Token(Token = "0x60019B1")]
		[Address(RVA = "0x957E60", Offset = "0x956E60", VA = "0x180957E60")]
		internal bool <IsLitter>b__221_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		[Token(Token = "0x60019B2")]
		[Address(RVA = "0x957E80", Offset = "0x956E80", VA = "0x180957E80")]
		internal bool <PickUpTarget>b__222_1(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		[Token(Token = "0x60019B3")]
		[Address(RVA = "0x957F40", Offset = "0x956F40", VA = "0x180957F40")]
		internal bool <GetSwitchQuery>b__227_0(Actor item)
		{
			return default(bool);
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		[Token(Token = "0x60019B4")]
		[Address(RVA = "0x66D270", Offset = "0x66C270", VA = "0x18066D270")]
		internal bool <MarkInspected>b__230_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		[Token(Token = "0x60019B5")]
		[Address(RVA = "0x957F70", Offset = "0x956F70", VA = "0x180957F70")]
		internal bool <MarkLastMovedAt>b__231_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x0000C210 File Offset: 0x0000A410
		[Token(Token = "0x60019B6")]
		[Address(RVA = "0x957F70", Offset = "0x956F70", VA = "0x180957F70")]
		internal bool <ResetLastMovedAt>b__232_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x0000C228 File Offset: 0x0000A428
		[Token(Token = "0x60019B7")]
		[Address(RVA = "0x957F90", Offset = "0x956F90", VA = "0x180957F90")]
		internal bool <SetObjectSpawnPriority>b__233_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x0000C240 File Offset: 0x0000A440
		[Token(Token = "0x60019B8")]
		[Address(RVA = "0x957F90", Offset = "0x956F90", VA = "0x180957F90")]
		internal bool <SetObjectSpawnPriority>b__233_1(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x0000C258 File Offset: 0x0000A458
		[Token(Token = "0x60019B9")]
		[Address(RVA = "0x957F90", Offset = "0x956F90", VA = "0x180957F90")]
		internal bool <GetObjectSpawnPriority>b__234_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x0000C270 File Offset: 0x0000A470
		[Token(Token = "0x60019BA")]
		[Address(RVA = "0x957FB0", Offset = "0x956FB0", VA = "0x180957FB0")]
		internal bool <SetDistanceRecognitionMode>b__235_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0000C288 File Offset: 0x0000A488
		[Token(Token = "0x60019BB")]
		[Address(RVA = "0x957FB0", Offset = "0x956FB0", VA = "0x180957FB0")]
		internal bool <SetDistanceRecognitionMode>b__235_1(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		[Token(Token = "0x60019BC")]
		[Address(RVA = "0x957FB0", Offset = "0x956FB0", VA = "0x180957FB0")]
		internal bool <GetDistanceRecognitionMode>b__236_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x04001EE3 RID: 7907
		[Token(Token = "0x4001EE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Interactable.<>c <>9;

		// Token: 0x04001EE4 RID: 7908
		[Token(Token = "0x4001EE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Interactable.Passed> <>9__143_1;

		// Token: 0x04001EE5 RID: 7909
		[Token(Token = "0x4001EE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<InteractablePreset.IfSwitchStateSFX> <>9__143_0;

		// Token: 0x04001EE6 RID: 7910
		[Token(Token = "0x4001EE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<Interactable.Passed> <>9__150_0;

		// Token: 0x04001EE7 RID: 7911
		[Token(Token = "0x4001EE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<Interactable.Passed> <>9__151_0;

		// Token: 0x04001EE8 RID: 7912
		[Token(Token = "0x4001EE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<Interactable.Passed> <>9__152_0;

		// Token: 0x04001EE9 RID: 7913
		[Token(Token = "0x4001EE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<DDSSaveClasses.DDSBlockCondition> <>9__165_0;

		// Token: 0x04001EEA RID: 7914
		[Token(Token = "0x4001EEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Predicate<Interactable> <>9__167_1;

		// Token: 0x04001EEB RID: 7915
		[Token(Token = "0x4001EEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Comparison<Interactable> <>9__167_2;

		// Token: 0x04001EEC RID: 7916
		[Token(Token = "0x4001EEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Comparison<InteractablePreset.InteractionAction> <>9__169_0;

		// Token: 0x04001EED RID: 7917
		[Token(Token = "0x4001EED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Predicate<Case> <>9__169_1;

		// Token: 0x04001EEE RID: 7918
		[Token(Token = "0x4001EEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Predicate<InteractablePreset.IfSwitchStateSFX> <>9__170_0;

		// Token: 0x04001EEF RID: 7919
		[Token(Token = "0x4001EEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Predicate<InteractablePreset.IfSwitchStateSFX> <>9__171_0;

		// Token: 0x04001EF0 RID: 7920
		[Token(Token = "0x4001EF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Predicate<InteractablePreset.IfSwitchStateSFX> <>9__172_0;

		// Token: 0x04001EF1 RID: 7921
		[Token(Token = "0x4001EF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static Predicate<InteractablePreset.IfSwitchStateSFX> <>9__173_0;

		// Token: 0x04001EF2 RID: 7922
		[Token(Token = "0x4001EF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static Predicate<InteractablePreset.IfSwitchStateSFX> <>9__174_0;

		// Token: 0x04001EF3 RID: 7923
		[Token(Token = "0x4001EF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static Predicate<Interactable.Passed> <>9__175_2;

		// Token: 0x04001EF4 RID: 7924
		[Token(Token = "0x4001EF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static Predicate<Interactable.Passed> <>9__175_0;

		// Token: 0x04001EF5 RID: 7925
		[Token(Token = "0x4001EF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static Predicate<InteractablePreset.IfSwitchStateSFX> <>9__175_1;

		// Token: 0x04001EF6 RID: 7926
		[Token(Token = "0x4001EF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static Predicate<SessionData.TelevisionChannel> <>9__177_1;

		// Token: 0x04001EF7 RID: 7927
		[Token(Token = "0x4001EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__182_1;

		// Token: 0x04001EF8 RID: 7928
		[Token(Token = "0x4001EF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static Predicate<Interactable.Passed> <>9__184_1;

		// Token: 0x04001EF9 RID: 7929
		[Token(Token = "0x4001EF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static Predicate<Interactable.Passed> <>9__184_0;

		// Token: 0x04001EFA RID: 7930
		[Token(Token = "0x4001EFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static Predicate<Interactable.Passed> <>9__185_0;

		// Token: 0x04001EFB RID: 7931
		[Token(Token = "0x4001EFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static Predicate<InteractablePreset.SwitchState> <>9__200_1;

		// Token: 0x04001EFC RID: 7932
		[Token(Token = "0x4001EFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__200_0;

		// Token: 0x04001EFD RID: 7933
		[Token(Token = "0x4001EFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static Predicate<Interactable.Passed> <>9__211_0;

		// Token: 0x04001EFE RID: 7934
		[Token(Token = "0x4001EFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static Predicate<Interactable.Passed> <>9__211_1;

		// Token: 0x04001EFF RID: 7935
		[Token(Token = "0x4001EFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static Predicate<Interactable.Passed> <>9__221_0;

		// Token: 0x04001F00 RID: 7936
		[Token(Token = "0x4001F00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__222_1;

		// Token: 0x04001F01 RID: 7937
		[Token(Token = "0x4001F01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static Predicate<Actor> <>9__227_0;

		// Token: 0x04001F02 RID: 7938
		[Token(Token = "0x4001F02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public static Predicate<Interactable.Passed> <>9__230_0;

		// Token: 0x04001F03 RID: 7939
		[Token(Token = "0x4001F03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static Predicate<Interactable.Passed> <>9__231_0;

		// Token: 0x04001F04 RID: 7940
		[Token(Token = "0x4001F04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public static Predicate<Interactable.Passed> <>9__232_0;

		// Token: 0x04001F05 RID: 7941
		[Token(Token = "0x4001F05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static Predicate<Interactable.Passed> <>9__233_0;

		// Token: 0x04001F06 RID: 7942
		[Token(Token = "0x4001F06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public static Predicate<Interactable.Passed> <>9__233_1;

		// Token: 0x04001F07 RID: 7943
		[Token(Token = "0x4001F07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public static Predicate<Interactable.Passed> <>9__234_0;

		// Token: 0x04001F08 RID: 7944
		[Token(Token = "0x4001F08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public static Predicate<Interactable.Passed> <>9__235_0;

		// Token: 0x04001F09 RID: 7945
		[Token(Token = "0x4001F09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public static Predicate<Interactable.Passed> <>9__235_1;

		// Token: 0x04001F0A RID: 7946
		[Token(Token = "0x4001F0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public static Predicate<Interactable.Passed> <>9__236_0;
	}

	// Token: 0x02000467 RID: 1127
	[Token(Token = "0x2000467")]
	private sealed class <>c__DisplayClass169_0
	{
		// Token: 0x060019BD RID: 6589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019BD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass169_0()
		{
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
		[Token(Token = "0x60019BE")]
		[Address(RVA = "0x952DC0", Offset = "0x951DC0", VA = "0x180952DC0")]
		internal bool <UpdateCurrentActions>b__2(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001F0B RID: 7947
		[Token(Token = "0x4001F0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewNode forwardsNode;
	}

	// Token: 0x02000468 RID: 1128
	[Token(Token = "0x2000468")]
	private sealed class <>c__DisplayClass177_0
	{
		// Token: 0x060019BF RID: 6591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019BF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass177_0()
		{
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		[Token(Token = "0x60019C0")]
		[Address(RVA = "0x957FD0", Offset = "0x956FD0", VA = "0x180957FD0")]
		internal bool <UpdateSwitchStateAudio>b__0(AudioController.LoopingSoundInfo item)
		{
			return default(bool);
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		[Token(Token = "0x60019C1")]
		[Address(RVA = "0x958030", Offset = "0x957030", VA = "0x180958030")]
		internal bool <UpdateSwitchStateAudio>b__2(AudioController.LoopingSoundInfo item)
		{
			return default(bool);
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x0000C300 File Offset: 0x0000A500
		[Token(Token = "0x60019C2")]
		[Address(RVA = "0x957FD0", Offset = "0x956FD0", VA = "0x180957FD0")]
		internal bool <UpdateSwitchStateAudio>b__3(AudioController.LoopingSoundInfo item)
		{
			return default(bool);
		}

		// Token: 0x04001F0C RID: 7948
		[Token(Token = "0x4001F0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractablePreset.IfSwitchStateSFX aud;

		// Token: 0x04001F0D RID: 7949
		[Token(Token = "0x4001F0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Interactable <>4__this;
	}

	// Token: 0x02000469 RID: 1129
	[Token(Token = "0x2000469")]
	private sealed class <>c__DisplayClass179_0
	{
		// Token: 0x060019C3 RID: 6595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass179_0()
		{
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x0000C318 File Offset: 0x0000A518
		[Token(Token = "0x60019C4")]
		[Address(RVA = "0x9580E0", Offset = "0x9570E0", VA = "0x1809580E0")]
		internal bool <UpdateMusicPlayer>b__0(AudioController.LoopingSoundInfo item)
		{
			return default(bool);
		}

		// Token: 0x04001F0E RID: 7950
		[Token(Token = "0x4001F0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioEvent trackToPlay;
	}

	// Token: 0x0200046A RID: 1130
	[Token(Token = "0x200046A")]
	private sealed class <>c__DisplayClass182_0
	{
		// Token: 0x060019C5 RID: 6597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass182_0()
		{
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x0000C330 File Offset: 0x0000A530
		[Token(Token = "0x60019C6")]
		[Address(RVA = "0x958140", Offset = "0x957140", VA = "0x180958140")]
		internal bool <OnInteraction>b__0(NewAIController.QueuedAction item)
		{
			return default(bool);
		}

		// Token: 0x04001F0F RID: 7951
		[Token(Token = "0x4001F0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractablePreset.InteractionAction action;

		// Token: 0x04001F10 RID: 7952
		[Token(Token = "0x4001F10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Interactable <>4__this;
	}

	// Token: 0x0200046B RID: 1131
	[Token(Token = "0x200046B")]
	private sealed class <>c__DisplayClass205_0
	{
		// Token: 0x060019C7 RID: 6599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C7")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass205_0()
		{
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x0000C348 File Offset: 0x0000A548
		[Token(Token = "0x60019C8")]
		[Address(RVA = "0x958170", Offset = "0x957170", VA = "0x180958170")]
		internal bool <SetActionHighlight>b__0(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x0000C360 File Offset: 0x0000A560
		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x958170", Offset = "0x957170", VA = "0x180958170")]
		internal bool <SetActionHighlight>b__1(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x0000C378 File Offset: 0x0000A578
		[Token(Token = "0x60019CA")]
		[Address(RVA = "0x958170", Offset = "0x957170", VA = "0x180958170")]
		internal bool <SetActionHighlight>b__2(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x04001F11 RID: 7953
		[Token(Token = "0x4001F11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string newString;
	}

	// Token: 0x0200046C RID: 1132
	[Token(Token = "0x200046C")]
	private sealed class <>c__DisplayClass206_0
	{
		// Token: 0x060019CB RID: 6603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019CB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass206_0()
		{
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x0000C390 File Offset: 0x0000A590
		[Token(Token = "0x60019CC")]
		[Address(RVA = "0x958170", Offset = "0x957170", VA = "0x180958170")]
		internal bool <SetActionDisable>b__0(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
		[Token(Token = "0x60019CD")]
		[Address(RVA = "0x958170", Offset = "0x957170", VA = "0x180958170")]
		internal bool <SetActionDisable>b__1(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
		[Token(Token = "0x60019CE")]
		[Address(RVA = "0x958170", Offset = "0x957170", VA = "0x180958170")]
		internal bool <SetActionDisable>b__2(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x04001F12 RID: 7954
		[Token(Token = "0x4001F12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string newString;
	}
}
