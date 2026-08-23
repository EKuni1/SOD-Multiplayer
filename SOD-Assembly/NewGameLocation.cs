using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x02000141 RID: 321
[Token(Token = "0x2000141")]
public class NewGameLocation : Controller
{
	// Token: 0x060008F9 RID: 2297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x4E8C50", Offset = "0x4E7C50", VA = "0x1804E8C50")]
	public void CommonSetup(bool newIsOutside, DistrictController newDistrict, DesignStylePreset newDefaultStyle)
	{
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008FA")]
	[Address(RVA = "0x4E9240", Offset = "0x4E8240", VA = "0x1804E9240")]
	public void AddNewNode(NewNode newNode)
	{
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008FB")]
	[Address(RVA = "0x4E9840", Offset = "0x4E8840", VA = "0x1804E9840")]
	public void RemoveNode(NewNode newNode)
	{
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x4E99B0", Offset = "0x4E89B0", VA = "0x1804E99B0")]
	public void AddNewRoom(NewRoom newRoom)
	{
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x4E9EF0", Offset = "0x4E8EF0", VA = "0x1804E9EF0")]
	public void RemoveRoom(NewRoom newRoom)
	{
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008FE")]
	[Address(RVA = "0x4EA120", Offset = "0x4E9120", VA = "0x1804EA120", Slot = "6")]
	public virtual void AddOccupant(Actor newOcc)
	{
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008FF")]
	[Address(RVA = "0x4EA440", Offset = "0x4E9440", VA = "0x1804EA440", Slot = "7")]
	public virtual void RemoveOccupant(Actor remOcc)
	{
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000900")]
	[Address(RVA = "0x4EA740", Offset = "0x4E9740", VA = "0x1804EA740")]
	public NewNode.NodeAccess GetMainEntrance()
	{
		return null;
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000901")]
	[Address(RVA = "0x4EAC50", Offset = "0x4E9C50", VA = "0x1804EAC50")]
	public void SetDesignStyle(DesignStylePreset newStyle)
	{
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000902")]
	[Address(RVA = "0x4EB250", Offset = "0x4EA250", VA = "0x1804EB250")]
	public void AddEntrance(NewNode fromNode, NewNode toNode, bool forceAccessType = false, NewNode.NodeAccess.AccessType forcedAccessType = NewNode.NodeAccess.AccessType.adjacent, bool forceWalkable = false)
	{
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000903")]
	[Address(RVA = "0x4EBCD0", Offset = "0x4EACD0", VA = "0x1804EBCD0")]
	public void RemoveEntrance(NewNode fromNode, NewNode toNode)
	{
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000904")]
	[Address(RVA = "0x4EC0B0", Offset = "0x4EB0B0", VA = "0x1804EC0B0")]
	public Interactable PlaceObject(InteractablePreset interactable, Human belongsTo, Human writer, Human reciever, out FurnitureLocation pickedFurn, bool passVariable = false, Interactable.PassedVarType passedVarType = Interactable.PassedVarType.jobID, int passedValue = -1, bool forceSecuritySettings = false, int forcedSecurity = 0, InteractablePreset.OwnedPlacementRule forcedOwnership = InteractablePreset.OwnedPlacementRule.nonOwnedOnly, int forcedPriority = 0, [Optional] RetailItemPreset retailItem, bool printDebug = false, [Optional] HashSet<NewRoom> dontPlaceInRooms, [Optional] string loadGUID, [Optional] NewNode placeClosestTo, string ddsOverride = "", bool ignoreLimits = false)
	{
		return null;
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000905")]
	[Address(RVA = "0x4EC350", Offset = "0x4EB350", VA = "0x1804EC350")]
	public Interactable PlaceObject(InteractablePreset interactable, Human belongsTo, Human writer, Human receiver, out FurnitureLocation pickedFurn, [Optional] List<Interactable.Passed> passedVars, bool forceSecuritySettings = false, int forcedSecurity = 0, InteractablePreset.OwnedPlacementRule forcedOwnership = InteractablePreset.OwnedPlacementRule.nonOwnedOnly, int forcedPriority = 0, [Optional] object passedObject, bool printDebug = false, [Optional] HashSet<NewRoom> dontPlaceInRooms, [Optional] string loadGUID, [Optional] NewNode placeClosestTo, string ddsOverride = "", bool ignoreLimits = false)
	{
		return null;
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000906")]
	[Address(RVA = "0x4EE540", Offset = "0x4ED540", VA = "0x1804EE540")]
	public NewGameLocation.ObjectPlacement GetBestSpawnLocation(InteractablePreset interactable, bool warmItem, Human belongsTo, Human writer, Human receiver, out FurnitureLocation pickedFurn, [Optional] List<Interactable.Passed> passedVars, bool forceSecuritySettings = false, int forcedSecurity = 0, InteractablePreset.OwnedPlacementRule forcedOwnership = InteractablePreset.OwnedPlacementRule.nonOwnedOnly, int forcedPriority = 0, [Optional] object passedObject, bool printDebug = false, [Optional] HashSet<NewRoom> dontPlaceInRooms, [Optional] string loadGUID, [Optional] NewNode placeClosestTo, string ddsOverride = "", bool ignoreLimits = false, bool usePutDownPosition = false)
	{
		return null;
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000907")]
	[Address(RVA = "0x4F1A70", Offset = "0x4F0A70", VA = "0x1804F1A70")]
	public NewGameLocation.ObjectPlacement GetPutDownLocation(InteractablePreset interactable, out FurnitureLocation pickedFurn)
	{
		return null;
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000908")]
	[Address(RVA = "0x4F2860", Offset = "0x4F1860", VA = "0x1804F2860")]
	public void AddToPlacementPool(InteractablePreset interactable, Human belongsTo, Human writer, Human receiver, [Optional] List<Interactable.Passed> passedVars, int security = 0, InteractablePreset.OwnedPlacementRule ownership = InteractablePreset.OwnedPlacementRule.nonOwnedOnly, int priority = 0, [Optional] object passedObject, [Optional] HashSet<NewRoom> dontPlaceInRooms)
	{
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000909")]
	[Address(RVA = "0x4F30F0", Offset = "0x4F20F0", VA = "0x1804F30F0")]
	public void PlaceObjects()
	{
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x00005E80 File Offset: 0x00004080
	[Token(Token = "0x600090A")]
	[Address(RVA = "0x4F9E20", Offset = "0x4F8E20", VA = "0x1804F9E20")]
	public bool IsPublicallyOpen(bool forPlayer)
	{
		return default(bool);
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600090B")]
	[Address(RVA = "0x4FA8B0", Offset = "0x4F98B0", VA = "0x1804FA8B0")]
	public void AddEscalation(Actor actor)
	{
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x00005E98 File Offset: 0x00004098
	[Token(Token = "0x600090C")]
	[Address(RVA = "0x4FAF20", Offset = "0x4F9F20", VA = "0x1804FAF20")]
	public int GetAdditionalEscalation(Actor actor)
	{
		return 0;
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600090D")]
	[Address(RVA = "0x4FB0A0", Offset = "0x4FA0A0", VA = "0x1804FB0A0")]
	public void RemoveEscalation(Actor actor, bool removeAll = false)
	{
	}

	// Token: 0x0600090E RID: 2318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600090E")]
	[Address(RVA = "0x4FB3D0", Offset = "0x4FA3D0", VA = "0x1804FB3D0")]
	public void AddSecurityCamera(Interactable newInteractable)
	{
	}

	// Token: 0x0600090F RID: 2319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600090F")]
	[Address(RVA = "0x4FB430", Offset = "0x4FA430", VA = "0x1804FB430")]
	public void SetAsCrimeScene(bool val)
	{
	}

	// Token: 0x06000910 RID: 2320 RVA: 0x00005EB0 File Offset: 0x000040B0
	[Token(Token = "0x6000910")]
	[Address(RVA = "0x418400", Offset = "0x417400", VA = "0x180418400", Slot = "8")]
	public virtual bool IsAlarmSystemTarget(Human human)
	{
		return default(bool);
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x00005EC8 File Offset: 0x000040C8
	[Token(Token = "0x6000911")]
	[Address(RVA = "0x4FB9E0", Offset = "0x4FA9E0", VA = "0x1804FB9E0", Slot = "9")]
	public virtual bool IsAlarmActive(out float retAlarmTimer, out NewBuilding.AlarmTargetMode retTargetMode, out List<Human> retTargets)
	{
		return default(bool);
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x00005EE0 File Offset: 0x000040E0
	[Token(Token = "0x6000912")]
	[Address(RVA = "0x4FBA30", Offset = "0x4FAA30", VA = "0x1804FBA30", Slot = "10")]
	public virtual bool IsOutside()
	{
		return default(bool);
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000913")]
	[Address(RVA = "0x4FBA40", Offset = "0x4FAA40", VA = "0x1804FBA40")]
	public string GetReplicableSeed()
	{
		return null;
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000914")]
	[Address(RVA = "0x4FBC50", Offset = "0x4FAC50", VA = "0x1804FBC50")]
	public void ResetLoiteringTimer()
	{
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000915")]
	[Address(RVA = "0x4FBC80", Offset = "0x4FAC80", VA = "0x1804FBC80")]
	public void LoiteringPurchase()
	{
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000916")]
	[Address(RVA = "0x4FBCE0", Offset = "0x4FACE0", VA = "0x1804FBCE0")]
	public void RemoveEverything()
	{
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000917")]
	[Address(RVA = "0x4FBD00", Offset = "0x4FAD00", VA = "0x1804FBD00")]
	public void RemoveAllInhabitantFurniture(bool removeSkipAddressInhabitantsFurniture, FurnitureClusterLocation.RemoveInteractablesOption spawnedOnFurnitureRemovalOption)
	{
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000918")]
	[Address(RVA = "0x4FBE70", Offset = "0x4FAE70", VA = "0x1804FBE70")]
	public void DisplayAccess()
	{
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x00005EF8 File Offset: 0x000040F8
	[Token(Token = "0x6000919")]
	[Address(RVA = "0x4FC4D0", Offset = "0x4FB4D0", VA = "0x1804FC4D0")]
	public int GetSQM(bool print = true)
	{
		return 0;
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x00005F10 File Offset: 0x00004110
	[Token(Token = "0x600091A")]
	[Address(RVA = "0x4FC720", Offset = "0x4FB720", VA = "0x1804FC720")]
	public int GetPrice(bool print = true)
	{
		return 0;
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600091B")]
	[Address(RVA = "0x4FD050", Offset = "0x4FC050", VA = "0x1804FD050")]
	public void GetAIActions()
	{
	}

	// Token: 0x0600091C RID: 2332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600091C")]
	[Address(RVA = "0x4FD320", Offset = "0x4FC320", VA = "0x1804FD320")]
	public void IsThisOutside()
	{
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x00005F28 File Offset: 0x00004128
	[Token(Token = "0x600091D")]
	[Address(RVA = "0x4FD390", Offset = "0x4FC390", VA = "0x1804FD390")]
	public bool AllowEmployeeDoors()
	{
		return default(bool);
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600091E")]
	[Address(RVA = "0x4FDB20", Offset = "0x4FCB20", VA = "0x1804FDB20")]
	public NewGameLocation()
	{
	}

	// Token: 0x04000938 RID: 2360
	[Token(Token = "0x4000938")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[NonSerialized]
	public NewAddress thisAsAddress;

	// Token: 0x04000939 RID: 2361
	[Token(Token = "0x4000939")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public StreetController thisAsStreet;

	// Token: 0x0400093A RID: 2362
	[Token(Token = "0x400093A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string seed;

	// Token: 0x0400093B RID: 2363
	[Token(Token = "0x400093B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public DistrictController district;

	// Token: 0x0400093C RID: 2364
	[Token(Token = "0x400093C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public NewBuilding building;

	// Token: 0x0400093D RID: 2365
	[Token(Token = "0x400093D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public NewFloor floor;

	// Token: 0x0400093E RID: 2366
	[Token(Token = "0x400093E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int residenceNumber;

	// Token: 0x0400093F RID: 2367
	[Token(Token = "0x400093F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MapAddressButtonController mapButton;

	// Token: 0x04000940 RID: 2368
	[Token(Token = "0x4000940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool isLobby;

	// Token: 0x04000941 RID: 2369
	[Token(Token = "0x4000941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool isOutside;

	// Token: 0x04000942 RID: 2370
	[Token(Token = "0x4000942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
	public bool isCrimeScene;

	// Token: 0x04000943 RID: 2371
	[Token(Token = "0x4000943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float loggedAsCrimeScene;

	// Token: 0x04000944 RID: 2372
	[Token(Token = "0x4000944")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AddressPreset.AccessType access;

	// Token: 0x04000945 RID: 2373
	[Token(Token = "0x4000945")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public NewRoom nullRoom;

	// Token: 0x04000946 RID: 2374
	[Token(Token = "0x4000946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<NewRoom> rooms;

	// Token: 0x04000947 RID: 2375
	[Token(Token = "0x4000947")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<NewNode> nodes;

	// Token: 0x04000948 RID: 2376
	[Token(Token = "0x4000948")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<Actor> currentOccupants;

	// Token: 0x04000949 RID: 2377
	[Token(Token = "0x4000949")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public DesignStylePreset designStyle;

	// Token: 0x0400094A RID: 2378
	[Token(Token = "0x400094A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<ArtPreset> artPieces;

	// Token: 0x0400094B RID: 2379
	[Token(Token = "0x400094B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool placedKey;

	// Token: 0x0400094C RID: 2380
	[Token(Token = "0x400094C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<Interactable> securityCameras;

	// Token: 0x0400094D RID: 2381
	[Token(Token = "0x400094D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<Interactable> stacks;

	// Token: 0x0400094E RID: 2382
	[Token(Token = "0x400094E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<Telephone> telephones;

	// Token: 0x0400094F RID: 2383
	[Token(Token = "0x400094F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<Interactable> resetBehaviourObjects;

	// Token: 0x04000950 RID: 2384
	[Token(Token = "0x4000950")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Dictionary<FurnitureClass.OwnershipClass, Dictionary<FurnitureLocation, List<Human>>> furnitureBelongsTo;

	// Token: 0x04000951 RID: 2385
	[Token(Token = "0x4000951")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<NewNode.NodeAccess> entrances;

	// Token: 0x04000952 RID: 2386
	[Token(Token = "0x4000952")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[NonSerialized]
	public NewNode.NodeAccess streetAccess;

	// Token: 0x04000953 RID: 2387
	[Token(Token = "0x4000953")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public NewNode anchorNode;

	// Token: 0x04000954 RID: 2388
	[Token(Token = "0x4000954")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Dictionary<AIActionPreset, List<Interactable>> actionReference;

	// Token: 0x04000955 RID: 2389
	[Token(Token = "0x4000955")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Dictionary<AIActionPreset, List<Interactable>> nearestPublicActionReference;

	// Token: 0x04000956 RID: 2390
	[Token(Token = "0x4000956")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Dictionary<Actor, NewGameLocation.TrespassEscalation> escalation;

	// Token: 0x04000957 RID: 2391
	[Token(Token = "0x4000957")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float playerLoiteringTimer;

	// Token: 0x04000958 RID: 2392
	[Token(Token = "0x4000958")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[NonSerialized]
	public EvidenceLocation evidenceEntry;

	// Token: 0x04000959 RID: 2393
	[Token(Token = "0x4000959")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public List<NewGameLocation.ObjectPlace> objectsToPlace;

	// Token: 0x0400095A RID: 2394
	[Token(Token = "0x400095A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public bool objectPoolPlaced;

	// Token: 0x02000142 RID: 322
	[Token(Token = "0x2000142")]
	[Serializable]
	public class TrespassEscalation
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public TrespassEscalation()
		{
		}

		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int actor;

		// Token: 0x0400095C RID: 2396
		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool isPlayer;

		// Token: 0x0400095D RID: 2397
		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float lastEscalationCheck;

		// Token: 0x0400095E RID: 2398
		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float timeEscalation;
	}

	// Token: 0x02000143 RID: 323
	[Token(Token = "0x2000143")]
	public class ObjectPlacement
	{
		// Token: 0x06000920 RID: 2336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ObjectPlacement()
		{
		}

		// Token: 0x0400095F RID: 2399
		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurniturePreset.SubObject location;

		// Token: 0x04000960 RID: 2400
		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FurnitureLocation furnParent;

		// Token: 0x04000961 RID: 2401
		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Interactable existing;

		// Token: 0x04000962 RID: 2402
		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Interactable subSpawn;
	}

	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	public struct ObjectPlace
	{
		// Token: 0x04000963 RID: 2403
		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractablePreset interactable;

		// Token: 0x04000964 RID: 2404
		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Human belongsTo;

		// Token: 0x04000965 RID: 2405
		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human writer;

		// Token: 0x04000966 RID: 2406
		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Human receiver;

		// Token: 0x04000967 RID: 2407
		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Interactable.Passed> passedVars;

		// Token: 0x04000968 RID: 2408
		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int security;

		// Token: 0x04000969 RID: 2409
		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public InteractablePreset.OwnedPlacementRule ownership;

		// Token: 0x0400096A RID: 2410
		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int priority;

		// Token: 0x0400096B RID: 2411
		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public object passedObject;

		// Token: 0x0400096C RID: 2412
		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public HashSet<NewRoom> dontPlaceInRooms;
	}

	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000145")]
	public class Placement
	{
		// Token: 0x06000921 RID: 2337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public Placement()
		{
		}

		// Token: 0x0400096D RID: 2413
		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewRoom room;

		// Token: 0x0400096E RID: 2414
		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FurnitureLocation furniture;

		// Token: 0x0400096F RID: 2415
		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SubObjectClassPreset placementClass;

		// Token: 0x04000970 RID: 2416
		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FurniturePreset.SubObject subObject;

		// Token: 0x04000971 RID: 2417
		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Interactable subSpawn;

		// Token: 0x04000972 RID: 2418
		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rank;
	}

	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	private sealed class <>c__DisplayClass48_0
	{
		// Token: 0x06000922 RID: 2338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass48_0()
		{
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00005F40 File Offset: 0x00004140
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x4FE580", Offset = "0x4FD580", VA = "0x1804FE580")]
		internal bool <AddEntrance>b__0(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00005F58 File Offset: 0x00004158
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x4FE5B0", Offset = "0x4FD5B0", VA = "0x1804FE5B0")]
		internal bool <AddEntrance>b__1(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00005F70 File Offset: 0x00004170
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x4FE580", Offset = "0x4FD580", VA = "0x1804FE580")]
		internal bool <AddEntrance>b__2(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x04000973 RID: 2419
		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewNode fromNode;

		// Token: 0x04000974 RID: 2420
		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewNode toNode;
	}

	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	private sealed class <>c__DisplayClass49_0
	{
		// Token: 0x06000926 RID: 2342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass49_0()
		{
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00005F88 File Offset: 0x00004188
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x4FE580", Offset = "0x4FD580", VA = "0x1804FE580")]
		internal bool <RemoveEntrance>b__1(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00005FA0 File Offset: 0x000041A0
		[Token(Token = "0x6000928")]
		[Address(RVA = "0x4FE580", Offset = "0x4FD580", VA = "0x1804FE580")]
		internal bool <RemoveEntrance>b__0(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x04000975 RID: 2421
		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewNode fromNode;

		// Token: 0x04000976 RID: 2422
		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewNode toNode;
	}

	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	private sealed class <>c__DisplayClass51_0
	{
		// Token: 0x06000929 RID: 2345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000929")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass51_0()
		{
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00005FB8 File Offset: 0x000041B8
		[Token(Token = "0x600092A")]
		[Address(RVA = "0x4FE620", Offset = "0x4FD620", VA = "0x1804FE620")]
		internal bool <PlaceObject>b__1(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00005FD0 File Offset: 0x000041D0
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x4FE680", Offset = "0x4FD680", VA = "0x1804FE680")]
		internal bool <PlaceObject>b__2(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00005FE8 File Offset: 0x000041E8
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x4FE8A0", Offset = "0x4FD8A0", VA = "0x1804FE8A0")]
		internal bool <PlaceObject>b__3(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04000977 RID: 2423
		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractablePreset interactable;

		// Token: 0x04000978 RID: 2424
		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Human belongsTo;

		// Token: 0x04000979 RID: 2425
		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Predicate<Interactable> <>9__1;

		// Token: 0x0400097A RID: 2426
		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Predicate<Interactable> <>9__2;

		// Token: 0x0400097B RID: 2427
		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Predicate<Interactable> <>9__3;
	}

	// Token: 0x02000149 RID: 329
	[Token(Token = "0x2000149")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600092E RID: 2350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00006000 File Offset: 0x00004200
		[Token(Token = "0x600092F")]
		[Address(RVA = "0x4FE9D0", Offset = "0x4FD9D0", VA = "0x1804FE9D0")]
		internal bool <PlaceObject>b__51_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00006018 File Offset: 0x00004218
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x4FE9F0", Offset = "0x4FD9F0", VA = "0x1804FE9F0")]
		internal int <PlaceObjects>b__55_0(NewGameLocation.ObjectPlace p1, NewGameLocation.ObjectPlace p2)
		{
			return 0;
		}

		// Token: 0x0400097C RID: 2428
		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly NewGameLocation.<>c <>9;

		// Token: 0x0400097D RID: 2429
		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Interactable.Passed> <>9__51_0;

		// Token: 0x0400097E RID: 2430
		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Comparison<NewGameLocation.ObjectPlace> <>9__55_0;
	}

	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	private sealed class <>c__DisplayClass52_0
	{
		// Token: 0x06000931 RID: 2353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass52_0()
		{
		}

		// Token: 0x0400097F RID: 2431
		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractablePreset interactable;
	}

	// Token: 0x0200014B RID: 331
	[Token(Token = "0x200014B")]
	private sealed class <>c__DisplayClass52_1
	{
		// Token: 0x06000932 RID: 2354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass52_1()
		{
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00006030 File Offset: 0x00004230
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x4FEA10", Offset = "0x4FDA10", VA = "0x1804FEA10")]
		internal bool <GetBestSpawnLocation>b__0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurnitureLocation f;

		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewGameLocation.<>c__DisplayClass52_0 CS$<>8__locals1;
	}

	// Token: 0x0200014C RID: 332
	[Token(Token = "0x200014C")]
	private sealed class <>c__DisplayClass52_2
	{
		// Token: 0x06000934 RID: 2356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass52_2()
		{
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x6000935")]
		[Address(RVA = "0x4FEA10", Offset = "0x4FDA10", VA = "0x1804FEA10")]
		internal bool <GetBestSpawnLocation>b__1(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04000982 RID: 2434
		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurnitureLocation obj;

		// Token: 0x04000983 RID: 2435
		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewGameLocation.<>c__DisplayClass52_0 CS$<>8__locals2;
	}

	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	private sealed class <>c__DisplayClass52_3
	{
		// Token: 0x06000936 RID: 2358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass52_3()
		{
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00006060 File Offset: 0x00004260
		[Token(Token = "0x6000937")]
		[Address(RVA = "0x4FEAA0", Offset = "0x4FDAA0", VA = "0x1804FEAA0")]
		internal bool <GetBestSpawnLocation>b__2(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x04000984 RID: 2436
		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SubObjectClassPreset placeClass;
	}

	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	private sealed class <>c__DisplayClass52_4
	{
		// Token: 0x06000938 RID: 2360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass52_4()
		{
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00006078 File Offset: 0x00004278
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x478670", Offset = "0x477670", VA = "0x180478670")]
		internal bool <GetBestSpawnLocation>b__3(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04000985 RID: 2437
		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurniturePreset.SubObject loc;
	}

	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	private sealed class <>c__DisplayClass52_5
	{
		// Token: 0x0600093A RID: 2362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass52_5()
		{
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00006090 File Offset: 0x00004290
		[Token(Token = "0x600093B")]
		[Address(RVA = "0x4FEAA0", Offset = "0x4FDAA0", VA = "0x1804FEAA0")]
		internal bool <GetBestSpawnLocation>b__4(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x04000986 RID: 2438
		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SubObjectClassPreset placeClass;
	}

	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	private sealed class <>c__DisplayClass52_6
	{
		// Token: 0x0600093C RID: 2364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass52_6()
		{
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000060A8 File Offset: 0x000042A8
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x478670", Offset = "0x477670", VA = "0x180478670")]
		internal bool <GetBestSpawnLocation>b__5(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04000987 RID: 2439
		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurniturePreset.SubObject s;
	}

	// Token: 0x02000151 RID: 337
	[Token(Token = "0x2000151")]
	private sealed class <>c__DisplayClass52_7
	{
		// Token: 0x0600093E RID: 2366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass52_7()
		{
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000060C0 File Offset: 0x000042C0
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x4FEAA0", Offset = "0x4FDAA0", VA = "0x1804FEAA0")]
		internal bool <GetBestSpawnLocation>b__6(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x04000988 RID: 2440
		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SubObjectClassPreset placeClass;
	}

	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	private sealed class <>c__DisplayClass52_8
	{
		// Token: 0x06000940 RID: 2368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass52_8()
		{
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000060D8 File Offset: 0x000042D8
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x478670", Offset = "0x477670", VA = "0x180478670")]
		internal bool <GetBestSpawnLocation>b__7(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04000989 RID: 2441
		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurniturePreset.SubObject s;
	}

	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	private sealed class <>c__DisplayClass53_0
	{
		// Token: 0x06000942 RID: 2370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass53_0()
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x000060F0 File Offset: 0x000042F0
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x4FEAA0", Offset = "0x4FDAA0", VA = "0x1804FEAA0")]
		internal bool <GetPutDownLocation>b__0(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SubObjectClassPreset placeClass;
	}

	// Token: 0x02000154 RID: 340
	[Token(Token = "0x2000154")]
	private sealed class <>c__DisplayClass53_1
	{
		// Token: 0x06000944 RID: 2372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass53_1()
		{
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00006108 File Offset: 0x00004308
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x4FEAA0", Offset = "0x4FDAA0", VA = "0x1804FEAA0")]
		internal bool <GetPutDownLocation>b__1(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x0400098B RID: 2443
		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SubObjectClassPreset placeClass;
	}

	// Token: 0x02000155 RID: 341
	[Token(Token = "0x2000155")]
	private sealed class <>c__DisplayClass53_2
	{
		// Token: 0x06000946 RID: 2374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass53_2()
		{
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00006120 File Offset: 0x00004320
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x478670", Offset = "0x477670", VA = "0x180478670")]
		internal bool <GetPutDownLocation>b__2(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x0400098C RID: 2444
		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurniturePreset.SubObject s;
	}

	// Token: 0x02000156 RID: 342
	[Token(Token = "0x2000156")]
	private sealed class <>c__DisplayClass54_0
	{
		// Token: 0x06000948 RID: 2376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass54_0()
		{
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00006138 File Offset: 0x00004338
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <AddToPlacementPool>b__0(NewGameLocation.ObjectPlace item)
		{
			return default(bool);
		}

		// Token: 0x0400098D RID: 2445
		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractablePreset interactable;
	}

	// Token: 0x02000157 RID: 343
	[Token(Token = "0x2000157")]
	private sealed class <>c__DisplayClass55_0
	{
		// Token: 0x0600094A RID: 2378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass55_0()
		{
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00006150 File Offset: 0x00004350
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <PlaceObjects>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x0400098E RID: 2446
		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000158 RID: 344
	[Token(Token = "0x2000158")]
	private sealed class <>c__DisplayClass55_1
	{
		// Token: 0x0600094C RID: 2380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass55_1()
		{
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00006168 File Offset: 0x00004368
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <PlaceObjects>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x0400098F RID: 2447
		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000159 RID: 345
	[Token(Token = "0x2000159")]
	private sealed class <>c__DisplayClass55_2
	{
		// Token: 0x0600094E RID: 2382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass55_2()
		{
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00006180 File Offset: 0x00004380
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <PlaceObjects>b__3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000990 RID: 2448
		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x0200015A RID: 346
	[Token(Token = "0x200015A")]
	private sealed class <>c__DisplayClass55_3
	{
		// Token: 0x06000950 RID: 2384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass55_3()
		{
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00006198 File Offset: 0x00004398
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <PlaceObjects>b__4(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000991 RID: 2449
		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x0200015B RID: 347
	[Token(Token = "0x200015B")]
	private sealed class <>c__DisplayClass55_4
	{
		// Token: 0x06000952 RID: 2386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass55_4()
		{
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x000061B0 File Offset: 0x000043B0
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x4FEB40", Offset = "0x4FDB40", VA = "0x1804FEB40")]
		internal bool <PlaceObjects>b__6(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x000061C8 File Offset: 0x000043C8
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x4FE8A0", Offset = "0x4FD8A0", VA = "0x1804FE8A0")]
		internal bool <PlaceObjects>b__7(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x000061E0 File Offset: 0x000043E0
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <PlaceObjects>b__5(NewGameLocation.ObjectPlace item)
		{
			return default(bool);
		}

		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewGameLocation.ObjectPlace pl;

		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Predicate<Interactable> <>9__6;

		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Predicate<Interactable> <>9__7;
	}

	// Token: 0x0200015C RID: 348
	[Token(Token = "0x200015C")]
	private sealed class <>c__DisplayClass55_5
	{
		// Token: 0x06000956 RID: 2390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass55_5()
		{
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x000061F8 File Offset: 0x000043F8
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x4FED60", Offset = "0x4FDD60", VA = "0x1804FED60")]
		internal bool <PlaceObjects>b__8(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractablePreset.SpecialCase stackType;
	}
}
