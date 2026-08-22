using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200042A RID: 1066
[Token(Token = "0x200042A")]
[Serializable]
public class FurnitureLocation
{
	// Token: 0x06001800 RID: 6144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001800")]
	[Address(RVA = "0x8B3430", Offset = "0x8B2430", VA = "0x1808B3430")]
	public FurnitureLocation(List<FurnitureClass> newClasses, int newAngle, NewNode newAnchor, List<NewNode> newCoversNodes, bool newUseFOVBlock = false, [Optional] Vector2 newFovDirection, int newFOVBlockMax = 5, [Optional] Vector3 newScale, bool newUserPlaced = false, [Optional] Vector3 newOffset)
	{
	}

	// Token: 0x06001801 RID: 6145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001801")]
	[Address(RVA = "0x8B3CB0", Offset = "0x8B2CB0", VA = "0x1808B3CB0")]
	public void AssignID(NewRoom fromRoom)
	{
	}

	// Token: 0x06001802 RID: 6146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001802")]
	[Address(RVA = "0x8B3CE0", Offset = "0x8B2CE0", VA = "0x1808B3CE0")]
	public FurnitureLocation(FurnitureClusterLocation newCluster, List<FurnitureClass> newClasses, int newAngle, NewNode newAnchor, List<NewNode> newCoversNodes, bool newUseFOVBlock = false, [Optional] Vector2 newFovDirection, int newFOVBlockMax = 5, [Optional] Vector3 newScale, bool newUserPlaced = false, [Optional] Vector3 newOffset)
	{
	}

	// Token: 0x06001803 RID: 6147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001803")]
	[Address(RVA = "0x8B4610", Offset = "0x8B3610", VA = "0x1808B4610")]
	public FurnitureLocation(int loadID, FurnitureClusterLocation newCluster, List<FurnitureClass> newClasses, int newAngle, NewNode newAnchor, List<NewNode> newCoversNodes, bool newUseFOVBlock = false, [Optional] Vector2 newFovDirection, int newFOVBlockMax = 5, [Optional] Vector3 newScale, bool newUserPlaced = false, [Optional] Vector3 newOffset)
	{
	}

	// Token: 0x06001804 RID: 6148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001804")]
	[Address(RVA = "0x8B4F10", Offset = "0x8B3F10", VA = "0x1808B4F10")]
	public void RaiseLightswitch()
	{
	}

	// Token: 0x06001805 RID: 6149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001805")]
	[Address(RVA = "0x8B52E0", Offset = "0x8B42E0", VA = "0x1808B52E0")]
	private void DiagonalRotation()
	{
	}

	// Token: 0x06001806 RID: 6150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001806")]
	[Address(RVA = "0x8B5750", Offset = "0x8B4750", VA = "0x1808B5750")]
	public void SpawnObject(bool forceSpawnImmediate = false)
	{
	}

	// Token: 0x06001807 RID: 6151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001807")]
	[Address(RVA = "0x8B8410", Offset = "0x8B7410", VA = "0x1808B8410")]
	public void DespawnObject()
	{
	}

	// Token: 0x06001808 RID: 6152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001808")]
	[Address(RVA = "0x8B85A0", Offset = "0x8B75A0", VA = "0x1808B85A0")]
	public void Delete(bool removeIntegratedInteractables, FurnitureClusterLocation.RemoveInteractablesOption removeSpawnedInteractables)
	{
	}

	// Token: 0x06001809 RID: 6153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001809")]
	[Address(RVA = "0x8B8670", Offset = "0x8B7670", VA = "0x1808B8670")]
	public void RemoveSpawnedInteractables()
	{
	}

	// Token: 0x0600180A RID: 6154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600180A")]
	[Address(RVA = "0x8B87D0", Offset = "0x8B77D0", VA = "0x1808B87D0")]
	public void RemoveIntegratedInteractables()
	{
	}

	// Token: 0x0600180B RID: 6155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600180B")]
	[Address(RVA = "0x8B89E0", Offset = "0x8B79E0", VA = "0x1808B89E0")]
	public void CreateInteractables()
	{
	}

	// Token: 0x0600180C RID: 6156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600180C")]
	[Address(RVA = "0x8BA3A0", Offset = "0x8B93A0", VA = "0x1808BA3A0")]
	public void AssignOwner(Human newOwner, bool updateIntegratedObjectOwnership)
	{
	}

	// Token: 0x0600180D RID: 6157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600180D")]
	[Address(RVA = "0x8BAC60", Offset = "0x8B9C60", VA = "0x1808BAC60")]
	public void AssignOwner(NewAddress newOwner, bool updateIntegratedObjectOwnership)
	{
	}

	// Token: 0x0600180E RID: 6158 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600180E")]
	[Address(RVA = "0x8BB190", Offset = "0x8BA190", VA = "0x1808BB190")]
	public void UpdateIntegratedObjectOwnership()
	{
	}

	// Token: 0x0600180F RID: 6159 RVA: 0x0000AED8 File Offset: 0x000090D8
	[Token(Token = "0x600180F")]
	[Address(RVA = "0x8BC4D0", Offset = "0x8BB4D0", VA = "0x1808BC4D0")]
	public Vector3 GetWorldAveragePosition()
	{
		return default(Vector3);
	}

	// Token: 0x06001810 RID: 6160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001810")]
	[Address(RVA = "0x8BC710", Offset = "0x8BB710", VA = "0x1808BC710")]
	public void CalculateWalkableSublocations()
	{
	}

	// Token: 0x06001811 RID: 6161 RVA: 0x0000AEF0 File Offset: 0x000090F0
	[Token(Token = "0x6001811")]
	[Address(RVA = "0x8BD250", Offset = "0x8BC250", VA = "0x1808BD250")]
	public Vector3 GetSubObjectLocalPosition(FurniturePreset.SubObject subObj)
	{
		return default(Vector3);
	}

	// Token: 0x06001812 RID: 6162 RVA: 0x0000AF08 File Offset: 0x00009108
	[Token(Token = "0x6001812")]
	[Address(RVA = "0x8BD970", Offset = "0x8BC970", VA = "0x1808BD970")]
	public Vector3 GetSubObjectLocalEuler(FurniturePreset.SubObject subObj)
	{
		return default(Vector3);
	}

	// Token: 0x04001D6C RID: 7532
	[Token(Token = "0x4001D6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	// Token: 0x04001D6D RID: 7533
	[Token(Token = "0x4001D6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<FurnitureClass> furnitureClasses;

	// Token: 0x04001D6E RID: 7534
	[Token(Token = "0x4001D6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int angle;

	// Token: 0x04001D6F RID: 7535
	[Token(Token = "0x4001D6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 offset;

	// Token: 0x04001D70 RID: 7536
	[Token(Token = "0x4001D70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public NewNode anchorNode;

	// Token: 0x04001D71 RID: 7537
	[Token(Token = "0x4001D71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<NewNode> coversNodes;

	// Token: 0x04001D72 RID: 7538
	[Token(Token = "0x4001D72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public FurnitureClusterLocation cluster;

	// Token: 0x04001D73 RID: 7539
	[Token(Token = "0x4001D73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool useFOVBLock;

	// Token: 0x04001D74 RID: 7540
	[Token(Token = "0x4001D74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector2 fovDirection;

	// Token: 0x04001D75 RID: 7541
	[Token(Token = "0x4001D75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int fovMaxDistance;

	// Token: 0x04001D76 RID: 7542
	[Token(Token = "0x4001D76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector3 scaleMultiplier;

	// Token: 0x04001D77 RID: 7543
	[Token(Token = "0x4001D77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Interactable.UsagePoint> usage;

	// Token: 0x04001D78 RID: 7544
	[Token(Token = "0x4001D78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Dictionary<NewNode, List<Vector3>> sublocations;

	// Token: 0x04001D79 RID: 7545
	[Token(Token = "0x4001D79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public FurniturePreset furniture;

	// Token: 0x04001D7A RID: 7546
	[Token(Token = "0x4001D7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject spawnedObject;

	// Token: 0x04001D7B RID: 7547
	[Token(Token = "0x4001D7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<MeshRenderer> meshes;

	// Token: 0x04001D7C RID: 7548
	[Token(Token = "0x4001D7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool pickedMaterials;

	// Token: 0x04001D7D RID: 7549
	[Token(Token = "0x4001D7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool createdInteractables;

	// Token: 0x04001D7E RID: 7550
	[Token(Token = "0x4001D7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
	public bool pickedOwners;

	// Token: 0x04001D7F RID: 7551
	[Token(Token = "0x4001D7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
	public bool pickedArt;

	// Token: 0x04001D80 RID: 7552
	[Token(Token = "0x4001D80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool userPlaced;

	// Token: 0x04001D81 RID: 7553
	[Token(Token = "0x4001D81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public int diagonalAngle;

	// Token: 0x04001D82 RID: 7554
	[Token(Token = "0x4001D82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Toolbox.MaterialKey matKey;

	// Token: 0x04001D83 RID: 7555
	[Token(Token = "0x4001D83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<Interactable> integratedInteractables;

	// Token: 0x04001D84 RID: 7556
	[Token(Token = "0x4001D84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public int integratedIDAssign;

	// Token: 0x04001D85 RID: 7557
	[Token(Token = "0x4001D85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<Interactable> spawnedInteractables;

	// Token: 0x04001D86 RID: 7558
	[Token(Token = "0x4001D86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public ArtPreset art;

	// Token: 0x04001D87 RID: 7559
	[Token(Token = "0x4001D87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Toolbox.MaterialKey artMatKey;

	// Token: 0x04001D88 RID: 7560
	[Token(Token = "0x4001D88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public List<int> loadOwners;

	// Token: 0x04001D89 RID: 7561
	[Token(Token = "0x4001D89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Dictionary<FurnitureLocation.OwnerKey, int> ownerMap;

	// Token: 0x04001D8A RID: 7562
	[Token(Token = "0x4001D8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public List<MonoBehaviour> debugOwners;

	// Token: 0x0200042B RID: 1067
	[Token(Token = "0x200042B")]
	public struct OwnerKey
	{
		// Token: 0x06001813 RID: 6163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001813")]
		[Address(RVA = "0x94EF60", Offset = "0x94DF60", VA = "0x18094EF60")]
		public OwnerKey(Human newHuman)
		{
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001814")]
		[Address(RVA = "0x94F010", Offset = "0x94E010", VA = "0x18094F010")]
		public OwnerKey(NewAddress newAddress)
		{
		}

		// Token: 0x04001D8B RID: 7563
		[Token(Token = "0x4001D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Human human;

		// Token: 0x04001D8C RID: 7564
		[Token(Token = "0x4001D8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public NewAddress address;
	}

	// Token: 0x0200042C RID: 1068
	[Token(Token = "0x200042C")]
	private sealed class <>c__DisplayClass38_0
	{
		// Token: 0x06001815 RID: 6165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001815")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass38_0()
		{
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x0000AF20 File Offset: 0x00009120
		[Token(Token = "0x6001816")]
		[Address(RVA = "0x94F0C0", Offset = "0x94E0C0", VA = "0x18094F0C0")]
		internal bool <SpawnObject>b__0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04001D8D RID: 7565
		[Token(Token = "0x4001D8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractableController ic;
	}

	// Token: 0x0200042D RID: 1069
	[Token(Token = "0x200042D")]
	private sealed class <>c__DisplayClass43_0
	{
		// Token: 0x06001817 RID: 6167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001817")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass43_0()
		{
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x0000AF38 File Offset: 0x00009138
		[Token(Token = "0x6001818")]
		[Address(RVA = "0x887780", Offset = "0x886780", VA = "0x180887780")]
		internal bool <CreateInteractables>b__0(InteractableController item)
		{
			return default(bool);
		}

		// Token: 0x04001D8E RID: 7566
		[Token(Token = "0x4001D8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurniturePreset.IntegratedInteractable integrated;

		// Token: 0x04001D8F RID: 7567
		[Token(Token = "0x4001D8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FurnitureLocation <>4__this;
	}

	// Token: 0x0200042E RID: 1070
	[Token(Token = "0x200042E")]
	private sealed class <>c__DisplayClass43_1
	{
		// Token: 0x06001819 RID: 6169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001819")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass43_1()
		{
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x0000AF50 File Offset: 0x00009150
		[Token(Token = "0x600181A")]
		[Address(RVA = "0x94F100", Offset = "0x94E100", VA = "0x18094F100")]
		internal bool <CreateInteractables>b__1(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04001D90 RID: 7568
		[Token(Token = "0x4001D90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int lookingForID;

		// Token: 0x04001D91 RID: 7569
		[Token(Token = "0x4001D91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FurnitureLocation.<>c__DisplayClass43_0 CS$<>8__locals1;
	}

	// Token: 0x0200042F RID: 1071
	[Token(Token = "0x200042F")]
	private sealed class <>c__DisplayClass46_0
	{
		// Token: 0x0600181B RID: 6171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass46_0()
		{
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0000AF68 File Offset: 0x00009168
		[Token(Token = "0x600181C")]
		[Address(RVA = "0x80D810", Offset = "0x80C810", VA = "0x18080D810")]
		internal bool <UpdateIntegratedObjectOwnership>b__0(FurniturePreset.IntegratedInteractable item)
		{
			return default(bool);
		}

		// Token: 0x04001D92 RID: 7570
		[Token(Token = "0x4001D92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractableController.InteractableID pairTo;
	}

	// Token: 0x02000430 RID: 1072
	[Token(Token = "0x2000430")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600181E RID: 6174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x0000AF80 File Offset: 0x00009180
		[Token(Token = "0x600181F")]
		[Address(RVA = "0x94F200", Offset = "0x94E200", VA = "0x18094F200")]
		internal bool <UpdateIntegratedObjectOwnership>b__46_1(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x04001D93 RID: 7571
		[Token(Token = "0x4001D93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly FurnitureLocation.<>c <>9;

		// Token: 0x04001D94 RID: 7572
		[Token(Token = "0x4001D94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Interactable.Passed> <>9__46_1;
	}

	// Token: 0x02000431 RID: 1073
	[Token(Token = "0x2000431")]
	private sealed class <>c__DisplayClass48_0
	{
		// Token: 0x06001820 RID: 6176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001820")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass48_0()
		{
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x0000AF98 File Offset: 0x00009198
		[Token(Token = "0x6001821")]
		[Address(RVA = "0x94F220", Offset = "0x94E220", VA = "0x18094F220")]
		internal bool <CalculateWalkableSublocations>b__0(NewNode item)
		{
			return default(bool);
		}

		// Token: 0x04001D95 RID: 7573
		[Token(Token = "0x4001D95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 offsetCoord;
	}
}
