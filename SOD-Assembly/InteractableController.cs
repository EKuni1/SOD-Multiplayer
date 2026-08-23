using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x0200046D RID: 1133
[Token(Token = "0x200046D")]
public class InteractableController : Controller
{
	// Token: 0x060019CF RID: 6607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019CF")]
	[Address(RVA = "0x958200", Offset = "0x957200", VA = "0x180958200")]
	public void Setup(Interactable newInteractable)
	{
	}

	// Token: 0x060019D0 RID: 6608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019D0")]
	[Address(RVA = "0x9599D0", Offset = "0x9589D0", VA = "0x1809599D0")]
	public void SetupDecal(ArtPreset foundArt, Interactable.Passed dynamic, bool doGraffitiChecks = true)
	{
	}

	// Token: 0x060019D1 RID: 6609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019D1")]
	[Address(RVA = "0x95A320", Offset = "0x959320", VA = "0x18095A320")]
	public void UpdateSwitchSync()
	{
	}

	// Token: 0x060019D2 RID: 6610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019D2")]
	[Address(RVA = "0x95A5B0", Offset = "0x9595B0", VA = "0x18095A5B0")]
	public void OnPageChange(int newPage)
	{
	}

	// Token: 0x060019D3 RID: 6611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019D3")]
	[Address(RVA = "0x95AA30", Offset = "0x959A30", VA = "0x18095AA30")]
	private void OnDestroy()
	{
	}

	// Token: 0x060019D4 RID: 6612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019D4")]
	[Address(RVA = "0x95ACD0", Offset = "0x959CD0", VA = "0x18095ACD0")]
	public void GetScreenBox(out Vector2 uiMin, out Vector2 uiMax)
	{
	}

	// Token: 0x060019D5 RID: 6613 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019D5")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void OnExitInteractionMode()
	{
	}

	// Token: 0x060019D6 RID: 6614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019D6")]
	[Address(RVA = "0x95B9F0", Offset = "0x95A9F0", VA = "0x18095B9F0")]
	public void MovablePickUpThis()
	{
	}

	// Token: 0x060019D7 RID: 6615 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019D7")]
	[Address(RVA = "0x95C970", Offset = "0x95B970", VA = "0x18095C970")]
	public void RotateHeldObject(float val)
	{
	}

	// Token: 0x060019D8 RID: 6616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019D8")]
	[Address(RVA = "0x95CB30", Offset = "0x95BB30", VA = "0x18095CB30")]
	private void Update()
	{
	}

	// Token: 0x060019D9 RID: 6617 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
	[Token(Token = "0x60019D9")]
	[Address(RVA = "0x95ED70", Offset = "0x95DD70", VA = "0x18095ED70")]
	private Vector3 ConvertBoundsPositionToTransformPosition(Vector3 boundsPosition)
	{
		return default(Vector3);
	}

	// Token: 0x060019DA RID: 6618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019DA")]
	[Address(RVA = "0x95EFA0", Offset = "0x95DFA0", VA = "0x18095EFA0")]
	public void DropThis(bool throwThis)
	{
	}

	// Token: 0x060019DB RID: 6619 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019DB")]
	[Address(RVA = "0x95FC00", Offset = "0x95EC00", VA = "0x18095FC00")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	// Token: 0x060019DC RID: 6620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019DC")]
	[Address(RVA = "0x962950", Offset = "0x961950", VA = "0x180962950")]
	public void BreakObject(Vector3 contactPoint, Vector3 normal, float magnitude, Actor breaker)
	{
	}

	// Token: 0x060019DD RID: 6621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019DD")]
	[Address(RVA = "0x9632B0", Offset = "0x9622B0", VA = "0x1809632B0")]
	public void Spatter(Vector3 target)
	{
	}

	// Token: 0x060019DE RID: 6622 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019DE")]
	[Address(RVA = "0x963BC0", Offset = "0x962BC0", VA = "0x180963BC0")]
	public void ParticleObjectCreation()
	{
	}

	// Token: 0x060019DF RID: 6623 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
	[Token(Token = "0x60019DF")]
	[Address(RVA = "0x9643B0", Offset = "0x9633B0", VA = "0x1809643B0")]
	private Vector3 UvTo3D(Vector2 uv, Mesh mesh)
	{
		return default(Vector3);
	}

	// Token: 0x060019E0 RID: 6624 RVA: 0x0000C408 File Offset: 0x0000A608
	[Token(Token = "0x60019E0")]
	[Address(RVA = "0x964920", Offset = "0x963920", VA = "0x180964920")]
	private float Area(Vector2 p1, Vector2 p2, Vector2 p3)
	{
		return 0f;
	}

	// Token: 0x060019E1 RID: 6625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E1")]
	[Address(RVA = "0x964980", Offset = "0x963980", VA = "0x180964980")]
	public void Shatter(Vector3 contact, float force)
	{
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E2")]
	[Address(RVA = "0x965DD0", Offset = "0x964DD0", VA = "0x180965DD0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060019E3 RID: 6627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E3")]
	[Address(RVA = "0x9667D0", Offset = "0x9657D0", VA = "0x1809667D0")]
	public void SetPhysics(bool val, [Optional] Actor setThrownBy)
	{
	}

	// Token: 0x060019E4 RID: 6628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E4")]
	[Address(RVA = "0x967A40", Offset = "0x966A40", VA = "0x180967A40")]
	public void SetVisible(bool val, bool forceUpdate = false)
	{
	}

	// Token: 0x060019E5 RID: 6629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E5")]
	[Address(RVA = "0x967D10", Offset = "0x966D10", VA = "0x180967D10")]
	private void UpdateLastMovement()
	{
	}

	// Token: 0x060019E6 RID: 6630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E6")]
	[Address(RVA = "0x968130", Offset = "0x967130", VA = "0x180968130")]
	public void UpdateParticleSystemDistance()
	{
	}

	// Token: 0x060019E7 RID: 6631 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E7")]
	[Address(RVA = "0x968680", Offset = "0x967680", VA = "0x180968680")]
	public void State1Change()
	{
	}

	// Token: 0x060019E8 RID: 6632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E8")]
	[Address(RVA = "0x9688A0", Offset = "0x9678A0", VA = "0x1809688A0")]
	public void DisplayCCTVVectors()
	{
	}

	// Token: 0x060019E9 RID: 6633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E9")]
	[Address(RVA = "0x968C50", Offset = "0x967C50", VA = "0x180968C50")]
	public void RefreshCCTVCoveredArea()
	{
	}

	// Token: 0x060019EA RID: 6634 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019EA")]
	[Address(RVA = "0x968CA0", Offset = "0x967CA0", VA = "0x180968CA0")]
	public void DisplayCCTVViewNodes()
	{
	}

	// Token: 0x060019EB RID: 6635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019EB")]
	[Address(RVA = "0x9690D0", Offset = "0x9680D0", VA = "0x1809690D0")]
	public void UpdateSaveFlags()
	{
	}

	// Token: 0x060019EC RID: 6636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019EC")]
	[Address(RVA = "0x969130", Offset = "0x968130", VA = "0x180969130")]
	public void GetSaveStateEligable()
	{
	}

	// Token: 0x060019ED RID: 6637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019ED")]
	[Address(RVA = "0x9692A0", Offset = "0x9682A0", VA = "0x1809692A0")]
	public void WasThisLoadedFromSaveGameData()
	{
	}

	// Token: 0x060019EE RID: 6638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019EE")]
	[Address(RVA = "0x969310", Offset = "0x968310", VA = "0x180969310")]
	public void SetupInteractable()
	{
	}

	// Token: 0x060019EF RID: 6639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019EF")]
	[Address(RVA = "0x96A050", Offset = "0x969050", VA = "0x18096A050")]
	public void IsOnPoolList()
	{
	}

	// Token: 0x060019F0 RID: 6640 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019F0")]
	[Address(RVA = "0x96A4F0", Offset = "0x9694F0", VA = "0x18096A4F0")]
	public void LoadWalkable()
	{
	}

	// Token: 0x060019F1 RID: 6641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019F1")]
	[Address(RVA = "0x96A9E0", Offset = "0x9699E0", VA = "0x18096A9E0")]
	public void ListUsers()
	{
	}

	// Token: 0x060019F2 RID: 6642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019F2")]
	[Address(RVA = "0x96ACF0", Offset = "0x969CF0", VA = "0x18096ACF0")]
	public void CalculateLocalFurniturePostion()
	{
	}

	// Token: 0x060019F3 RID: 6643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019F3")]
	[Address(RVA = "0x96AD90", Offset = "0x969D90", VA = "0x18096AD90")]
	public void TogglePrintDebug()
	{
	}

	// Token: 0x060019F4 RID: 6644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019F4")]
	[Address(RVA = "0x96AEC0", Offset = "0x969EC0", VA = "0x18096AEC0")]
	public void Explode()
	{
	}

	// Token: 0x060019F5 RID: 6645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019F5")]
	[Address(RVA = "0x96B020", Offset = "0x96A020", VA = "0x18096B020")]
	public void GetLocalizedSnapshot()
	{
	}

	// Token: 0x060019F6 RID: 6646 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019F6")]
	[Address(RVA = "0x96B160", Offset = "0x96A160", VA = "0x18096B160")]
	public void UpdateName()
	{
	}

	// Token: 0x060019F7 RID: 6647 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019F7")]
	[Address(RVA = "0x96B190", Offset = "0x96A190", VA = "0x18096B190")]
	public void RevealUsePointPosition()
	{
	}

	// Token: 0x060019F8 RID: 6648 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019F8")]
	[Address(RVA = "0x96B560", Offset = "0x96A560", VA = "0x18096B560")]
	public void CalculatePositionWithoutGameObject()
	{
	}

	// Token: 0x060019F9 RID: 6649 RVA: 0x0000C420 File Offset: 0x0000A620
	[Token(Token = "0x60019F9")]
	[Address(RVA = "0x96D7E0", Offset = "0x96C7E0", VA = "0x18096D7E0")]
	private bool TrySetRaycastMeshFilter(GameObject targetObject)
	{
		return default(bool);
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019FA")]
	[Address(RVA = "0x96D840", Offset = "0x96C840", VA = "0x18096D840")]
	public InteractableController()
	{
	}

	// Token: 0x060019FB RID: 6651 RVA: 0x0000C438 File Offset: 0x0000A638
	[Token(Token = "0x60019FB")]
	[Address(RVA = "0x96DB80", Offset = "0x96CB80", VA = "0x18096DB80")]
	private bool <CalculatePositionWithoutGameObject>b__119_0(InteractableController item)
	{
		return default(bool);
	}

	// Token: 0x04001F13 RID: 7955
	[Token(Token = "0x4001F13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[NonSerialized]
	public Interactable interactable;

	// Token: 0x04001F14 RID: 7956
	[Token(Token = "0x4001F14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public InteractableController.InteractableID id;

	// Token: 0x04001F15 RID: 7957
	[Token(Token = "0x4001F15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<MeshRenderer> meshes;

	// Token: 0x04001F16 RID: 7958
	[Token(Token = "0x4001F16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LODGroup lod;

	// Token: 0x04001F17 RID: 7959
	[Token(Token = "0x4001F17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rigidbody rb;

	// Token: 0x04001F18 RID: 7960
	[Token(Token = "0x4001F18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Collider coll;

	// Token: 0x04001F19 RID: 7961
	[Token(Token = "0x4001F19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Collider altColl;

	// Token: 0x04001F1A RID: 7962
	[Token(Token = "0x4001F1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Collider> additionalPhysicsOnlyColliders;

	// Token: 0x04001F1B RID: 7963
	[Token(Token = "0x4001F1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform alternativePhysicsParent;

	// Token: 0x04001F1C RID: 7964
	[Token(Token = "0x4001F1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public WorldFlashController flash;

	// Token: 0x04001F1D RID: 7965
	[Token(Token = "0x4001F1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public DoorMovementController doorMovement;

	// Token: 0x04001F1E RID: 7966
	[Token(Token = "0x4001F1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public DoorMovementController secondaryDoorMovement;

	// Token: 0x04001F1F RID: 7967
	[Token(Token = "0x4001F1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public DoorMovementController thirdDoorMovement;

	// Token: 0x04001F20 RID: 7968
	[Token(Token = "0x4001F20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public LightController lightController;

	// Token: 0x04001F21 RID: 7969
	[Token(Token = "0x4001F21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public SteamController steam;

	// Token: 0x04001F22 RID: 7970
	[Token(Token = "0x4001F22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public ComputerController computer;

	// Token: 0x04001F23 RID: 7971
	[Token(Token = "0x4001F23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public SecuritySystem securitySystem;

	// Token: 0x04001F24 RID: 7972
	[Token(Token = "0x4001F24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public FileSystemController fileSystem;

	// Token: 0x04001F25 RID: 7973
	[Token(Token = "0x4001F25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public DecalProjector decalProjector;

	// Token: 0x04001F26 RID: 7974
	[Token(Token = "0x4001F26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<Transform> pages;

	// Token: 0x04001F27 RID: 7975
	[Token(Token = "0x4001F27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ParticleSystem partSystem;

	// Token: 0x04001F28 RID: 7976
	[Token(Token = "0x4001F28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public EchelonsLaserScreenController echelonsScreen;

	// Token: 0x04001F29 RID: 7977
	[Token(Token = "0x4001F29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool useSmokeMaterial;

	// Token: 0x04001F2A RID: 7978
	[Token(Token = "0x4001F2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Transform lockParentOverride;

	// Token: 0x04001F2B RID: 7979
	[Token(Token = "0x4001F2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Vector3 lockedInTransformOffset;

	// Token: 0x04001F2C RID: 7980
	[Token(Token = "0x4001F2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public bool enableSwitchSync;

	// Token: 0x04001F2D RID: 7981
	[Token(Token = "0x4001F2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public List<SwitchSyncBehaviour> switchSyncObjects;

	// Token: 0x04001F2E RID: 7982
	[Token(Token = "0x4001F2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public bool isVisible;

	// Token: 0x04001F2F RID: 7983
	[Token(Token = "0x4001F2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
	public bool isCarriedByPlayer;

	// Token: 0x04001F30 RID: 7984
	[Token(Token = "0x4001F30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float carryProgress;

	// Token: 0x04001F31 RID: 7985
	[Token(Token = "0x4001F31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float rotProgress;

	// Token: 0x04001F32 RID: 7986
	[Token(Token = "0x4001F32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private Vector3 pickupPos;

	// Token: 0x04001F33 RID: 7987
	[Token(Token = "0x4001F33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Quaternion pickupRot;

	// Token: 0x04001F34 RID: 7988
	[Token(Token = "0x4001F34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Vector3 heldEuler;

	// Token: 0x04001F35 RID: 7989
	[Token(Token = "0x4001F35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private bool setHeldEuler;

	// Token: 0x04001F36 RID: 7990
	[Token(Token = "0x4001F36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
	public bool physicsOn;

	// Token: 0x04001F37 RID: 7991
	[Token(Token = "0x4001F37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public float minimumPhysicsTime;

	// Token: 0x04001F38 RID: 7992
	[Token(Token = "0x4001F38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public bool damageEligable;

	// Token: 0x04001F39 RID: 7993
	[Token(Token = "0x4001F39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12D")]
	public bool wasTrigger;

	// Token: 0x04001F3A RID: 7994
	[Token(Token = "0x4001F3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Actor thrownBy;

	// Token: 0x04001F3B RID: 7995
	[Token(Token = "0x4001F3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float objectParticleCreationDelay;

	// Token: 0x04001F3C RID: 7996
	[Token(Token = "0x4001F3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private Vector3 colliderExtents;

	// Token: 0x04001F3D RID: 7997
	[Token(Token = "0x4001F3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public bool apartmentPlacementIsValid;

	// Token: 0x04001F3E RID: 7998
	[Token(Token = "0x4001F3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public Transform lookAtTarget;

	// Token: 0x04001F3F RID: 7999
	[Token(Token = "0x4001F3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public InfoWindow interactionWindow;

	// Token: 0x04001F40 RID: 8000
	[Token(Token = "0x4001F40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public NewDoor isDoor;

	// Token: 0x04001F41 RID: 8001
	[Token(Token = "0x4001F41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Actor isActor;

	// Token: 0x04001F42 RID: 8002
	[Token(Token = "0x4001F42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public Human belongsTo;

	// Token: 0x04001F43 RID: 8003
	[Token(Token = "0x4001F43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public bool isPhone;

	// Token: 0x04001F44 RID: 8004
	[Token(Token = "0x4001F44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public GameObject phoneReciever;

	// Token: 0x04001F45 RID: 8005
	[Token(Token = "0x4001F45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public float particleSystemDistance;

	// Token: 0x04001F46 RID: 8006
	[Token(Token = "0x4001F46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	public bool willBeSavedWithCity;

	// Token: 0x04001F47 RID: 8007
	[Token(Token = "0x4001F47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18D")]
	public bool willBeSavedWithState;

	// Token: 0x04001F48 RID: 8008
	[Token(Token = "0x4001F48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18E")]
	public bool isMainLight;

	// Token: 0x04001F49 RID: 8009
	[Token(Token = "0x4001F49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18F")]
	private bool broken;

	// Token: 0x04001F4A RID: 8010
	[Token(Token = "0x4001F4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public List<Interactable> debugInteractable;

	// Token: 0x04001F4B RID: 8011
	[Token(Token = "0x4001F4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public int debugAngle;

	// Token: 0x04001F4C RID: 8012
	[Token(Token = "0x4001F4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	public Vector3 debugFurnitureAnchorNodePos;

	// Token: 0x04001F4D RID: 8013
	[Token(Token = "0x4001F4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public Vector3 debugLocalPos;

	// Token: 0x04001F4E RID: 8014
	[Token(Token = "0x4001F4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	public Vector3 debugLocalEuler;

	// Token: 0x04001F4F RID: 8015
	[Token(Token = "0x4001F4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public Vector3 debugWorldPos;

	// Token: 0x04001F50 RID: 8016
	[Token(Token = "0x4001F50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	public Vector3 debugInteractablePredictedWorldPos;

	// Token: 0x04001F51 RID: 8017
	[Token(Token = "0x4001F51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public Vector3 debugNodeCoord;

	// Token: 0x04001F52 RID: 8018
	[Token(Token = "0x4001F52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public Interactable.UsagePoint debugUsagePoint;

	// Token: 0x04001F53 RID: 8019
	[Token(Token = "0x4001F53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public Human debugOwnedBy;

	// Token: 0x04001F54 RID: 8020
	[Token(Token = "0x4001F54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public Human debugWrittenBy;

	// Token: 0x04001F55 RID: 8021
	[Token(Token = "0x4001F55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public Human debugReceivedBy;

	// Token: 0x04001F56 RID: 8022
	[Token(Token = "0x4001F56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public object debugPasswordSource;

	// Token: 0x04001F57 RID: 8023
	[Token(Token = "0x4001F57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public List<MonoBehaviour> debugFurnitureOwnedBy;

	// Token: 0x04001F58 RID: 8024
	[Token(Token = "0x4001F58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public bool debugSwitchState;

	// Token: 0x04001F59 RID: 8025
	[Token(Token = "0x4001F59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x219")]
	public bool debugState1;

	// Token: 0x04001F5A RID: 8026
	[Token(Token = "0x4001F5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public NewRoom debugRoom;

	// Token: 0x04001F5B RID: 8027
	[Token(Token = "0x4001F5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public AirDuctGroup.AirVent debugVent;

	// Token: 0x04001F5C RID: 8028
	[Token(Token = "0x4001F5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private Renderer _raycastHitMeshRenderer;

	// Token: 0x04001F5D RID: 8029
	[Token(Token = "0x4001F5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private Vector3 _hitMeshBounds;

	// Token: 0x04001F5E RID: 8030
	[Token(Token = "0x4001F5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
	private Vector2 _ceilingEdgeMin;

	// Token: 0x04001F5F RID: 8031
	[Token(Token = "0x4001F5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
	private Vector2 _ceilingEdgeMax;

	// Token: 0x0200046E RID: 1134
	[Token(Token = "0x200046E")]
	public enum InteractableID
	{
		// Token: 0x04001F61 RID: 8033
		[Token(Token = "0x4001F61")]
		A,
		// Token: 0x04001F62 RID: 8034
		[Token(Token = "0x4001F62")]
		B,
		// Token: 0x04001F63 RID: 8035
		[Token(Token = "0x4001F63")]
		C,
		// Token: 0x04001F64 RID: 8036
		[Token(Token = "0x4001F64")]
		D,
		// Token: 0x04001F65 RID: 8037
		[Token(Token = "0x4001F65")]
		E,
		// Token: 0x04001F66 RID: 8038
		[Token(Token = "0x4001F66")]
		F,
		// Token: 0x04001F67 RID: 8039
		[Token(Token = "0x4001F67")]
		G,
		// Token: 0x04001F68 RID: 8040
		[Token(Token = "0x4001F68")]
		H,
		// Token: 0x04001F69 RID: 8041
		[Token(Token = "0x4001F69")]
		I,
		// Token: 0x04001F6A RID: 8042
		[Token(Token = "0x4001F6A")]
		J,
		// Token: 0x04001F6B RID: 8043
		[Token(Token = "0x4001F6B")]
		hidingPlace,
		// Token: 0x04001F6C RID: 8044
		[Token(Token = "0x4001F6C")]
		none,
		// Token: 0x04001F6D RID: 8045
		[Token(Token = "0x4001F6D")]
		K,
		// Token: 0x04001F6E RID: 8046
		[Token(Token = "0x4001F6E")]
		L,
		// Token: 0x04001F6F RID: 8047
		[Token(Token = "0x4001F6F")]
		M,
		// Token: 0x04001F70 RID: 8048
		[Token(Token = "0x4001F70")]
		N,
		// Token: 0x04001F71 RID: 8049
		[Token(Token = "0x4001F71")]
		O,
		// Token: 0x04001F72 RID: 8050
		[Token(Token = "0x4001F72")]
		P,
		// Token: 0x04001F73 RID: 8051
		[Token(Token = "0x4001F73")]
		Q,
		// Token: 0x04001F74 RID: 8052
		[Token(Token = "0x4001F74")]
		R,
		// Token: 0x04001F75 RID: 8053
		[Token(Token = "0x4001F75")]
		S,
		// Token: 0x04001F76 RID: 8054
		[Token(Token = "0x4001F76")]
		T,
		// Token: 0x04001F77 RID: 8055
		[Token(Token = "0x4001F77")]
		U,
		// Token: 0x04001F78 RID: 8056
		[Token(Token = "0x4001F78")]
		V,
		// Token: 0x04001F79 RID: 8057
		[Token(Token = "0x4001F79")]
		W,
		// Token: 0x04001F7A RID: 8058
		[Token(Token = "0x4001F7A")]
		X,
		// Token: 0x04001F7B RID: 8059
		[Token(Token = "0x4001F7B")]
		Y,
		// Token: 0x04001F7C RID: 8060
		[Token(Token = "0x4001F7C")]
		Z,
		// Token: 0x04001F7D RID: 8061
		[Token(Token = "0x4001F7D")]
		AA,
		// Token: 0x04001F7E RID: 8062
		[Token(Token = "0x4001F7E")]
		BB,
		// Token: 0x04001F7F RID: 8063
		[Token(Token = "0x4001F7F")]
		CC,
		// Token: 0x04001F80 RID: 8064
		[Token(Token = "0x4001F80")]
		DD
	}

	// Token: 0x0200046F RID: 1135
	[Token(Token = "0x200046F")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060019FD RID: 6653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019FD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x0000C450 File Offset: 0x0000A650
		[Token(Token = "0x60019FE")]
		[Address(RVA = "0x96DD20", Offset = "0x96CD20", VA = "0x18096DD20")]
		internal bool <Setup>b__78_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0000C468 File Offset: 0x0000A668
		[Token(Token = "0x60019FF")]
		[Address(RVA = "0x96DD40", Offset = "0x96CD40", VA = "0x18096DD40")]
		internal bool <OnCollisionEnter>b__90_0(Objective item)
		{
			return default(bool);
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0000C480 File Offset: 0x0000A680
		[Token(Token = "0x6001A00")]
		[Address(RVA = "0x96DDE0", Offset = "0x96CDE0", VA = "0x18096DDE0")]
		internal bool <SetPhysics>b__98_0(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0000C498 File Offset: 0x0000A698
		[Token(Token = "0x6001A01")]
		[Address(RVA = "0x96DE70", Offset = "0x96CE70", VA = "0x18096DE70")]
		internal bool <SetPhysics>b__98_1(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		[Token(Token = "0x6001A02")]
		[Address(RVA = "0x96E030", Offset = "0x96D030", VA = "0x18096E030")]
		internal bool <SetPhysics>b__98_2(InteractableActionsPreset item)
		{
			return default(bool);
		}

		// Token: 0x04001F81 RID: 8065
		[Token(Token = "0x4001F81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly InteractableController.<>c <>9;

		// Token: 0x04001F82 RID: 8066
		[Token(Token = "0x4001F82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Interactable.Passed> <>9__78_0;

		// Token: 0x04001F83 RID: 8067
		[Token(Token = "0x4001F83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<Objective> <>9__90_0;

		// Token: 0x04001F84 RID: 8068
		[Token(Token = "0x4001F84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<FurniturePreset.SubObject> <>9__98_0;

		// Token: 0x04001F85 RID: 8069
		[Token(Token = "0x4001F85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<InteractableActionsPreset> <>9__98_2;

		// Token: 0x04001F86 RID: 8070
		[Token(Token = "0x4001F86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<Interactable> <>9__98_1;
	}

	// Token: 0x02000470 RID: 1136
	[Token(Token = "0x2000470")]
	private sealed class <>c__DisplayClass79_0
	{
		// Token: 0x06001A03 RID: 6659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A03")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass79_0()
		{
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		[Token(Token = "0x6001A04")]
		[Address(RVA = "0x96E0C0", Offset = "0x96D0C0", VA = "0x18096E0C0")]
		internal bool <SetupDecal>b__0(TMP_FontAsset item)
		{
			return default(bool);
		}

		// Token: 0x04001F87 RID: 8071
		[Token(Token = "0x4001F87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string[] parsed;
	}

	// Token: 0x02000471 RID: 1137
	[Token(Token = "0x2000471")]
	private sealed class <>c__DisplayClass90_0
	{
		// Token: 0x06001A05 RID: 6661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A05")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass90_0()
		{
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		[Token(Token = "0x6001A06")]
		[Address(RVA = "0x96E140", Offset = "0x96D140", VA = "0x18096E140")]
		internal bool <OnCollisionEnter>b__1(NewAIController.TrackingTarget item)
		{
			return default(bool);
		}

		// Token: 0x04001F88 RID: 8072
		[Token(Token = "0x4001F88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Actor soundMaker;

		// Token: 0x04001F89 RID: 8073
		[Token(Token = "0x4001F89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<NewAIController.TrackingTarget> <>9__1;
	}

	// Token: 0x02000472 RID: 1138
	[Token(Token = "0x2000472")]
	private sealed class <>c__DisplayClass90_1
	{
		// Token: 0x06001A07 RID: 6663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A07")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass90_1()
		{
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		[Token(Token = "0x6001A08")]
		[Address(RVA = "0x96E2F0", Offset = "0x96D2F0", VA = "0x18096E2F0")]
		internal bool <OnCollisionEnter>b__2(Case.ResolveQuestion item)
		{
			return default(bool);
		}

		// Token: 0x04001F8A RID: 8074
		[Token(Token = "0x4001F8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human hitCit;

		// Token: 0x04001F8B RID: 8075
		[Token(Token = "0x4001F8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<Case.ResolveQuestion> <>9__2;
	}

	// Token: 0x02000473 RID: 1139
	[Token(Token = "0x2000473")]
	private sealed class <>c__DisplayClass97_0
	{
		// Token: 0x06001A09 RID: 6665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A09")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass97_0()
		{
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0000C510 File Offset: 0x0000A710
		[Token(Token = "0x6001A0A")]
		[Address(RVA = "0x4E7450", Offset = "0x4E6450", VA = "0x1804E7450")]
		internal bool <OnTriggerEnter>b__0(Objective.ObjectiveTrigger item)
		{
			return default(bool);
		}

		// Token: 0x04001F8C RID: 8076
		[Token(Token = "0x4001F8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Citizen cit;

		// Token: 0x04001F8D RID: 8077
		[Token(Token = "0x4001F8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<Objective.ObjectiveTrigger> <>9__0;
	}
}
