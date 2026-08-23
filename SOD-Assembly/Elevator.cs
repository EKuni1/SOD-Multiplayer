using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000419 RID: 1049
[Token(Token = "0x2000419")]
[Serializable]
public class Elevator
{
	// Token: 0x060017BC RID: 6076 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017BC")]
	[Address(RVA = "0x89F670", Offset = "0x89E670", VA = "0x18089F670")]
	public Elevator(StairwellPreset newPreset, NewBuilding newBuilding, NewTile newBottom)
	{
	}

	// Token: 0x060017BD RID: 6077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017BD")]
	[Address(RVA = "0x8A0620", Offset = "0x89F620", VA = "0x1808A0620")]
	public void LoadElevatorSaveData(StateSaveData.ElevatorStateSave data)
	{
	}

	// Token: 0x060017BE RID: 6078 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017BE")]
	[Address(RVA = "0x8A0C70", Offset = "0x89FC70", VA = "0x1808A0C70")]
	public void AddFloor(NewTile newTile)
	{
	}

	// Token: 0x060017BF RID: 6079 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017BF")]
	[Address(RVA = "0x8A1080", Offset = "0x8A0080", VA = "0x1808A1080")]
	public void OnSpawnStairwell(NewTile tile)
	{
	}

	// Token: 0x060017C0 RID: 6080 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017C0")]
	[Address(RVA = "0x8A1B50", Offset = "0x8A0B50", VA = "0x1808A1B50")]
	public void CallElevator(int newFloor, bool upButton)
	{
	}

	// Token: 0x060017C1 RID: 6081 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017C1")]
	[Address(RVA = "0x8A2010", Offset = "0x8A1010", VA = "0x1808A2010")]
	public void ElevatorUpdate()
	{
	}

	// Token: 0x060017C2 RID: 6082 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017C2")]
	[Address(RVA = "0x8A3F20", Offset = "0x8A2F20", VA = "0x1808A3F20")]
	private void UpdateCables()
	{
	}

	// Token: 0x060017C3 RID: 6083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017C3")]
	[Address(RVA = "0x8A41F0", Offset = "0x8A31F0", VA = "0x1808A41F0")]
	private void EndMovement()
	{
	}

	// Token: 0x060017C4 RID: 6084 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017C4")]
	[Address(RVA = "0x8A42A0", Offset = "0x8A32A0", VA = "0x1808A42A0")]
	public void SetInTransit(bool val)
	{
	}

	// Token: 0x060017C5 RID: 6085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017C5")]
	[Address(RVA = "0x8A45E0", Offset = "0x8A35E0", VA = "0x1808A45E0")]
	public void UpdateDestination()
	{
	}

	// Token: 0x04001CF6 RID: 7414
	[Token(Token = "0x4001CF6")]
	[FieldOffset(Offset = "0x10")]
	public NewBuilding building;

	// Token: 0x04001CF7 RID: 7415
	[Token(Token = "0x4001CF7")]
	[FieldOffset(Offset = "0x18")]
	public Transform spawnedObject;

	// Token: 0x04001CF8 RID: 7416
	[Token(Token = "0x4001CF8")]
	[FieldOffset(Offset = "0x20")]
	public StairwellPreset preset;

	// Token: 0x04001CF9 RID: 7417
	[Token(Token = "0x4001CF9")]
	[FieldOffset(Offset = "0x28")]
	[NonSerialized]
	public Interactable controls;

	// Token: 0x04001CFA RID: 7418
	[Token(Token = "0x4001CFA")]
	[FieldOffset(Offset = "0x30")]
	public Collider vehicleDetector;

	// Token: 0x04001CFB RID: 7419
	[Token(Token = "0x4001CFB")]
	[FieldOffset(Offset = "0x38")]
	public Transform cable1;

	// Token: 0x04001CFC RID: 7420
	[Token(Token = "0x4001CFC")]
	[FieldOffset(Offset = "0x40")]
	public Transform cable2;

	// Token: 0x04001CFD RID: 7421
	[Token(Token = "0x4001CFD")]
	[FieldOffset(Offset = "0x48")]
	public AudioController.LoopingSoundInfo movementAudio;

	// Token: 0x04001CFE RID: 7422
	[Token(Token = "0x4001CFE")]
	[FieldOffset(Offset = "0x50")]
	public Dictionary<int, Elevator.ElevatorFloor> elevatorFloors;

	// Token: 0x04001CFF RID: 7423
	[Token(Token = "0x4001CFF")]
	[FieldOffset(Offset = "0x58")]
	public NewTile bottom;

	// Token: 0x04001D00 RID: 7424
	[Token(Token = "0x4001D00")]
	[FieldOffset(Offset = "0x60")]
	public NewTile top;

	// Token: 0x04001D01 RID: 7425
	[Token(Token = "0x4001D01")]
	[FieldOffset(Offset = "0x68")]
	private float reachedSpeed;

	// Token: 0x04001D02 RID: 7426
	[Token(Token = "0x4001D02")]
	[FieldOffset(Offset = "0x6C")]
	public float currentSpeed;

	// Token: 0x04001D03 RID: 7427
	[Token(Token = "0x4001D03")]
	[FieldOffset(Offset = "0x70")]
	public float desiredY;

	// Token: 0x04001D04 RID: 7428
	[Token(Token = "0x4001D04")]
	[FieldOffset(Offset = "0x74")]
	private float prevY;

	// Token: 0x04001D05 RID: 7429
	[Token(Token = "0x4001D05")]
	[FieldOffset(Offset = "0x78")]
	public float liftTimer;

	// Token: 0x04001D06 RID: 7430
	[Token(Token = "0x4001D06")]
	[FieldOffset(Offset = "0x7C")]
	public int currentFloor;

	// Token: 0x04001D07 RID: 7431
	[Token(Token = "0x4001D07")]
	[FieldOffset(Offset = "0x80")]
	public bool inTransit;

	// Token: 0x04001D08 RID: 7432
	[Token(Token = "0x4001D08")]
	[FieldOffset(Offset = "0x81")]
	public bool isGoingUp;

	// Token: 0x04001D09 RID: 7433
	[Token(Token = "0x4001D09")]
	[FieldOffset(Offset = "0x84")]
	public int currentDestination;

	// Token: 0x04001D0A RID: 7434
	[Token(Token = "0x4001D0A")]
	[FieldOffset(Offset = "0x88")]
	public int ultimateDesitnation;

	// Token: 0x04001D0B RID: 7435
	[Token(Token = "0x4001D0B")]
	[FieldOffset(Offset = "0x8C")]
	public bool isActive;

	// Token: 0x04001D0C RID: 7436
	[Token(Token = "0x4001D0C")]
	[FieldOffset(Offset = "0x8D")]
	public bool isMoving;

	// Token: 0x04001D0D RID: 7437
	[Token(Token = "0x4001D0D")]
	[FieldOffset(Offset = "0x90")]
	public Dictionary<int, List<Elevator.ElevatorCall>> calls;

	// Token: 0x0200041A RID: 1050
	[Token(Token = "0x200041A")]
	[Serializable]
	public class ElevatorFloor
	{
		// Token: 0x060017C6 RID: 6086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ElevatorFloor()
		{
		}

		// Token: 0x04001D0E RID: 7438
		[Token(Token = "0x4001D0E")]
		[FieldOffset(Offset = "0x10")]
		public int floor;

		// Token: 0x04001D0F RID: 7439
		[Token(Token = "0x4001D0F")]
		[FieldOffset(Offset = "0x18")]
		public NewTile elevatorTile;

		// Token: 0x04001D10 RID: 7440
		[Token(Token = "0x4001D10")]
		[FieldOffset(Offset = "0x20")]
		public NewRoom elevatorRoom;

		// Token: 0x04001D11 RID: 7441
		[Token(Token = "0x4001D11")]
		[FieldOffset(Offset = "0x28")]
		public GameObject spawned;

		// Token: 0x04001D12 RID: 7442
		[Token(Token = "0x4001D12")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Interactable upButton;

		// Token: 0x04001D13 RID: 7443
		[Token(Token = "0x4001D13")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Interactable downButton;

		// Token: 0x04001D14 RID: 7444
		[Token(Token = "0x4001D14")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Interactable door;
	}

	// Token: 0x0200041B RID: 1051
	[Token(Token = "0x200041B")]
	[Serializable]
	public class ElevatorCall
	{
		// Token: 0x060017C7 RID: 6087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x8A49F0", Offset = "0x8A39F0", VA = "0x1808A49F0")]
		public ElevatorCall(Elevator.ElevatorFloor newFloor, bool newUp, float newRegistered)
		{
		}

		// Token: 0x04001D15 RID: 7445
		[Token(Token = "0x4001D15")]
		[FieldOffset(Offset = "0x10")]
		public Elevator.ElevatorFloor floor;

		// Token: 0x04001D16 RID: 7446
		[Token(Token = "0x4001D16")]
		[FieldOffset(Offset = "0x18")]
		public bool callUp;

		// Token: 0x04001D17 RID: 7447
		[Token(Token = "0x4001D17")]
		[FieldOffset(Offset = "0x1C")]
		public float registered;
	}

	// Token: 0x0200041C RID: 1052
	[Token(Token = "0x200041C")]
	private sealed class <>c__DisplayClass27_0
	{
		// Token: 0x060017C8 RID: 6088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass27_0()
		{
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x0000AE48 File Offset: 0x00009048
		[Token(Token = "0x60017C9")]
		[Address(RVA = "0x8A4A60", Offset = "0x8A3A60", VA = "0x1808A4A60")]
		internal bool <LoadElevatorSaveData>b__0(KeyValuePair<int, NewFloor> x)
		{
			return default(bool);
		}

		// Token: 0x04001D18 RID: 7448
		[Token(Token = "0x4001D18")]
		[FieldOffset(Offset = "0x10")]
		public StateSaveData.ElevatorStateSave data;
	}

	// Token: 0x0200041D RID: 1053
	[Token(Token = "0x200041D")]
	private sealed class <>c__DisplayClass30_0
	{
		// Token: 0x060017CA RID: 6090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass30_0()
		{
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x0000AE60 File Offset: 0x00009060
		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x8A4AC0", Offset = "0x8A3AC0", VA = "0x1808A4AC0")]
		internal bool <CallElevator>b__0(Elevator.ElevatorCall item)
		{
			return default(bool);
		}

		// Token: 0x04001D19 RID: 7449
		[Token(Token = "0x4001D19")]
		[FieldOffset(Offset = "0x10")]
		public bool upButton;
	}

	// Token: 0x0200041E RID: 1054
	[Token(Token = "0x200041E")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060017CD RID: 6093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x0000AE78 File Offset: 0x00009078
		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x8A4B90", Offset = "0x8A3B90", VA = "0x1808A4B90")]
		internal bool <ElevatorUpdate>b__31_0(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x0000AE90 File Offset: 0x00009090
		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x8A4C20", Offset = "0x8A3C20", VA = "0x1808A4C20")]
		internal bool <ElevatorUpdate>b__31_1(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x04001D1A RID: 7450
		[Token(Token = "0x4001D1A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Elevator.<>c <>9;

		// Token: 0x04001D1B RID: 7451
		[Token(Token = "0x4001D1B")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__31_0;

		// Token: 0x04001D1C RID: 7452
		[Token(Token = "0x4001D1C")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__31_1;
	}
}
