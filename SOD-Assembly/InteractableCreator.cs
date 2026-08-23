using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000474 RID: 1140
[Token(Token = "0x2000474")]
public class InteractableCreator : MonoBehaviour
{
	// Token: 0x170000CA RID: 202
	// (get) Token: 0x06001A0B RID: 6667 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000CA")]
	public static InteractableCreator Instance
	{
		[Token(Token = "0x6001A0B")]
		[Address(RVA = "0x96E3A0", Offset = "0x96D3A0", VA = "0x18096E3A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001A0C RID: 6668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A0C")]
	[Address(RVA = "0x96E3E0", Offset = "0x96D3E0", VA = "0x18096E3E0")]
	private void Awake()
	{
	}

	// Token: 0x06001A0D RID: 6669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A0D")]
	[Address(RVA = "0x96E730", Offset = "0x96D730", VA = "0x18096E730")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001A0E RID: 6670 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A0E")]
	[Address(RVA = "0x96E940", Offset = "0x96D940", VA = "0x18096E940")]
	public Interactable CreateCitizenInteractable(InteractablePreset preset, Human citizen, Transform trans, Evidence evidence)
	{
		return null;
	}

	// Token: 0x06001A0F RID: 6671 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A0F")]
	[Address(RVA = "0x96EE50", Offset = "0x96DE50", VA = "0x18096EE50")]
	public Interactable CreateTransformInteractable(InteractablePreset preset, Transform trans, Human belongsTo, Evidence evidence, Vector3 localPos, Vector3 localEuler, List<Interactable.Passed> passedVars)
	{
		return null;
	}

	// Token: 0x06001A10 RID: 6672 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A10")]
	[Address(RVA = "0x96F060", Offset = "0x96E060", VA = "0x18096F060")]
	public Interactable CreateFurnitureIntegratedInteractable(InteractablePreset preset, NewRoom room, FurnitureLocation furniture, Human belongsTo, Human writer, Human recevier, Vector3 localPos, Vector3 localEuler, InteractableController.InteractableID pairTo, FurniturePreset.SubObjectOwnership pairToOwner, LightingPreset isLight, List<Interactable.Passed> passedVars)
	{
		return null;
	}

	// Token: 0x06001A11 RID: 6673 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A11")]
	[Address(RVA = "0x96F730", Offset = "0x96E730", VA = "0x18096F730")]
	public Interactable CreateFurnitureSpawnedInteractableThreadSafe(InteractablePreset preset, NewRoom room, FurnitureLocation furniture, FurniturePreset.SubObject subObject, Human belongsTo, Human writer, Human recevier, List<Interactable.Passed> passedVars, LightingPreset isLight, object passedObject, string ddsOverride = "")
	{
		return null;
	}

	// Token: 0x06001A12 RID: 6674 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A12")]
	[Address(RVA = "0x96FDF0", Offset = "0x96EDF0", VA = "0x18096FDF0")]
	public Interactable CreateFurnitureSpawnedInteractable(InteractablePreset preset, FurnitureLocation furniture, FurniturePreset.SubObject subObject, Human belongsTo, Human writer, Human recevier, List<Interactable.Passed> passedVars, LightingPreset isLight, object passedObject, string ddsOverride = "")
	{
		return null;
	}

	// Token: 0x06001A13 RID: 6675 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A13")]
	[Address(RVA = "0x970490", Offset = "0x96F490", VA = "0x180970490")]
	public Interactable CreateWorldInteractable(InteractablePreset preset, Human belongsTo, Human writer, Human recevier, Vector3 worldPos, Vector3 worldEuler, List<Interactable.Passed> passedVars, object passedObject, string ddsOverride = "")
	{
		return null;
	}

	// Token: 0x06001A14 RID: 6676 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A14")]
	[Address(RVA = "0x970980", Offset = "0x96F980", VA = "0x180970980")]
	public Interactable CreateWorldInteractableFromMetaObject(MetaObject meta, InteractablePreset preset, Vector3 worldPos, Vector3 worldEuler)
	{
		return null;
	}

	// Token: 0x06001A15 RID: 6677 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A15")]
	[Address(RVA = "0x970D70", Offset = "0x96FD70", VA = "0x180970D70")]
	public Interactable CreateDoorParentedInteractable(InteractablePreset preset, NewDoor door, Human belongsTo, Vector3 localPos, Vector3 localEuler, List<Interactable.Passed> passedVars, string ddsOverride = "")
	{
		return null;
	}

	// Token: 0x06001A16 RID: 6678 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A16")]
	[Address(RVA = "0x9710A0", Offset = "0x9700A0", VA = "0x1809710A0")]
	public Interactable CreateMainLightInteractable(InteractablePreset preset, NewRoom room, Vector3 worldPos, Vector3 worldEuler, LightingPreset lightPreset, Interactable.LightConfiguration preconfiguredLight, int lightZoneSize = -1)
	{
		return null;
	}

	// Token: 0x06001A17 RID: 6679 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A17")]
	[Address(RVA = "0x971220", Offset = "0x970220", VA = "0x180971220")]
	public Interactable CreateBookInteractable(InteractablePreset preset, NewRoom room, FurnitureLocation furniture, Human belongsTo, Vector3 localPos, Vector3 localEuler, BookPreset book)
	{
		return null;
	}

	// Token: 0x06001A18 RID: 6680 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A18")]
	[Address(RVA = "0x971450", Offset = "0x970450", VA = "0x180971450")]
	public Interactable CreateFingerprintInteractable(Human belongsTo, Vector3 worldPos, Vector3 worldEuler, FingerprintScannerController.Print print)
	{
		return null;
	}

	// Token: 0x06001A19 RID: 6681 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A19")]
	[Address(RVA = "0x971700", Offset = "0x970700", VA = "0x180971700")]
	public Interactable CreateFootprintInteractable(Human belongsTo, Vector3 worldPos, Vector3 worldEuler, GameplayController.Footprint print)
	{
		return null;
	}

	// Token: 0x06001A1A RID: 6682 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A1A")]
	[Address(RVA = "0x971930", Offset = "0x970930", VA = "0x180971930")]
	public Interactable CreateInteractableLock(InteractablePreset preset, FurnitureLocation furniture, Human belongsTo, Vector3 localPos, Vector3 localEuler, InteractableController.InteractableID pairTo)
	{
		return null;
	}

	// Token: 0x06001A1B RID: 6683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A1B")]
	[Address(RVA = "0x971A90", Offset = "0x970A90", VA = "0x180971A90")]
	public void FindInteractable()
	{
	}

	// Token: 0x06001A1C RID: 6684 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A1C")]
	[Address(RVA = "0x971F80", Offset = "0x970F80", VA = "0x180971F80")]
	public void ForceSpawnCheck()
	{
	}

	// Token: 0x06001A1D RID: 6685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A1D")]
	[Address(RVA = "0x9723E0", Offset = "0x9713E0", VA = "0x1809723E0")]
	public void ListFurnitureParentSpawned()
	{
	}

	// Token: 0x06001A1E RID: 6686 RVA: 0x0000C528 File Offset: 0x0000A728
	[Token(Token = "0x6001A1E")]
	[Address(RVA = "0x972E60", Offset = "0x971E60", VA = "0x180972E60")]
	public int GetRoomBasedInteractableID(NewRoom r)
	{
		return 0;
	}

	// Token: 0x06001A1F RID: 6687 RVA: 0x0000C540 File Offset: 0x0000A740
	[Token(Token = "0x6001A1F")]
	[Address(RVA = "0x972F70", Offset = "0x971F70", VA = "0x180972F70")]
	public int GetFurnitureBasedInteractableID(FurnitureLocation f)
	{
		return 0;
	}

	// Token: 0x06001A20 RID: 6688 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A20")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public InteractableCreator()
	{
	}

	// Token: 0x06001A21 RID: 6689 RVA: 0x0000C558 File Offset: 0x0000A758
	[Token(Token = "0x6001A21")]
	[Address(RVA = "0x972F90", Offset = "0x971F90", VA = "0x180972F90")]
	private bool <FindInteractable>b__19_0(Interactable item)
	{
		return default(bool);
	}

	// Token: 0x06001A22 RID: 6690 RVA: 0x0000C570 File Offset: 0x0000A770
	[Token(Token = "0x6001A22")]
	[Address(RVA = "0x972F90", Offset = "0x971F90", VA = "0x180972F90")]
	private bool <ForceSpawnCheck>b__20_0(Interactable item)
	{
		return default(bool);
	}

	// Token: 0x06001A23 RID: 6691 RVA: 0x0000C588 File Offset: 0x0000A788
	[Token(Token = "0x6001A23")]
	[Address(RVA = "0x972F90", Offset = "0x971F90", VA = "0x180972F90")]
	private bool <ListFurnitureParentSpawned>b__21_0(Interactable item)
	{
		return default(bool);
	}

	// Token: 0x04001F8E RID: 8078
	[Token(Token = "0x4001F8E")]
	[FieldOffset(Offset = "0x18")]
	public int debugFindID;

	// Token: 0x04001F8F RID: 8079
	[Token(Token = "0x4001F8F")]
	[FieldOffset(Offset = "0x0")]
	private static InteractableCreator _instance;
}
