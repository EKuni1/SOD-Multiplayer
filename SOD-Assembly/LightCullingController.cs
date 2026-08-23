using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

// Token: 0x0200037B RID: 891
[Token(Token = "0x200037B")]
public class LightCullingController : MonoBehaviour
{
	// Token: 0x170000AA RID: 170
	// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000AA")]
	public static LightCullingController Instance
	{
		[Token(Token = "0x60013F5")]
		[Address(RVA = "0x7A4480", Offset = "0x7A3480", VA = "0x1807A4480")]
		get
		{
			return null;
		}
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F6")]
	[Address(RVA = "0x7A44C0", Offset = "0x7A34C0", VA = "0x1807A44C0")]
	private void Awake()
	{
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F7")]
	[Address(RVA = "0x7A4810", Offset = "0x7A3810", VA = "0x1807A4810")]
	private void OnDestroy()
	{
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F8")]
	[Address(RVA = "0x7A4A20", Offset = "0x7A3A20", VA = "0x1807A4A20")]
	private void Update()
	{
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F9")]
	[Address(RVA = "0x7A6870", Offset = "0x7A5870", VA = "0x1807A6870")]
	public LightCullingController()
	{
	}

	// Token: 0x0400184F RID: 6223
	[Token(Token = "0x400184F")]
	[FieldOffset(Offset = "0x18")]
	public int lightsToCheckPerFrame;

	// Token: 0x04001850 RID: 6224
	[Token(Token = "0x4001850")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 radiusChecksPerLight;

	// Token: 0x04001851 RID: 6225
	[Token(Token = "0x4001851")]
	[FieldOffset(Offset = "0x24")]
	public float minimumLightUnculledTime;

	// Token: 0x04001852 RID: 6226
	[Token(Token = "0x4001852")]
	[FieldOffset(Offset = "0x28")]
	public List<LightController> lightsToCheck;

	// Token: 0x04001853 RID: 6227
	[Token(Token = "0x4001853")]
	[FieldOffset(Offset = "0x30")]
	public int checkingCursor;

	// Token: 0x04001854 RID: 6228
	[Token(Token = "0x4001854")]
	[FieldOffset(Offset = "0x38")]
	private List<LightController> lightsCheckedThisFrame;

	// Token: 0x04001855 RID: 6229
	[Token(Token = "0x4001855")]
	[FieldOffset(Offset = "0x40")]
	public List<LightController> culledLights;

	// Token: 0x04001856 RID: 6230
	[Token(Token = "0x4001856")]
	[FieldOffset(Offset = "0x48")]
	private JobHandle handlePrimary;

	// Token: 0x04001857 RID: 6231
	[Token(Token = "0x4001857")]
	[FieldOffset(Offset = "0x58")]
	private NativeArray<RaycastHit> resultsPrimary;

	// Token: 0x04001858 RID: 6232
	[Token(Token = "0x4001858")]
	[FieldOffset(Offset = "0x68")]
	private NativeArray<RaycastCommand> commandsPrimary;

	// Token: 0x04001859 RID: 6233
	[Token(Token = "0x4001859")]
	[FieldOffset(Offset = "0x78")]
	private NativeArray<Vector3> originsPrimary;

	// Token: 0x0400185A RID: 6234
	[Token(Token = "0x400185A")]
	[FieldOffset(Offset = "0x88")]
	private NativeArray<Vector3> directionsPrimary;

	// Token: 0x0400185B RID: 6235
	[Token(Token = "0x400185B")]
	[FieldOffset(Offset = "0x98")]
	private NativeArray<float> rangePrimary;

	// Token: 0x0400185C RID: 6236
	[Token(Token = "0x400185C")]
	[FieldOffset(Offset = "0xA8")]
	private bool primaryJobsActive;

	// Token: 0x0400185D RID: 6237
	[Token(Token = "0x400185D")]
	[FieldOffset(Offset = "0xA9")]
	private bool primaryJobsCompleted;

	// Token: 0x0400185E RID: 6238
	[Token(Token = "0x400185E")]
	[FieldOffset(Offset = "0xB0")]
	private JobHandle handleSecondary;

	// Token: 0x0400185F RID: 6239
	[Token(Token = "0x400185F")]
	[FieldOffset(Offset = "0xC0")]
	private NativeArray<RaycastHit> resultsSecondary;

	// Token: 0x04001860 RID: 6240
	[Token(Token = "0x4001860")]
	[FieldOffset(Offset = "0xD0")]
	private NativeArray<RaycastCommand> commandsSecondary;

	// Token: 0x04001861 RID: 6241
	[Token(Token = "0x4001861")]
	[FieldOffset(Offset = "0xE0")]
	private NativeArray<Vector3> originsSecondary;

	// Token: 0x04001862 RID: 6242
	[Token(Token = "0x4001862")]
	[FieldOffset(Offset = "0xF0")]
	private NativeArray<Vector3> directionsSecondary;

	// Token: 0x04001863 RID: 6243
	[Token(Token = "0x4001863")]
	[FieldOffset(Offset = "0x100")]
	private NativeArray<float> rangeSecondary;

	// Token: 0x04001864 RID: 6244
	[Token(Token = "0x4001864")]
	[FieldOffset(Offset = "0x110")]
	private bool secondaryJobsActive;

	// Token: 0x04001865 RID: 6245
	[Token(Token = "0x4001865")]
	[FieldOffset(Offset = "0x111")]
	private bool secondaryJobsCompleted;

	// Token: 0x04001866 RID: 6246
	[Token(Token = "0x4001866")]
	[FieldOffset(Offset = "0x118")]
	private List<LightController> notCulled;

	// Token: 0x04001867 RID: 6247
	[Token(Token = "0x4001867")]
	[FieldOffset(Offset = "0x120")]
	private List<LightCullingController.LightRaycastData> lightRaycastDataCollectionFromRadius;

	// Token: 0x04001868 RID: 6248
	[Token(Token = "0x4001868")]
	[FieldOffset(Offset = "0x128")]
	private List<LightCullingController.LightRaycastData> lightRaycastDataCollection;

	// Token: 0x04001869 RID: 6249
	[Token(Token = "0x4001869")]
	[FieldOffset(Offset = "0x0")]
	private static LightCullingController _instance;

	// Token: 0x0200037C RID: 892
	[Token(Token = "0x200037C")]
	private struct LightRaycastData
	{
		// Token: 0x060013FA RID: 5114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FA")]
		[Address(RVA = "0x7A6C10", Offset = "0x7A5C10", VA = "0x1807A6C10")]
		public LightRaycastData(LightController newLightRef, LightCullingController.LightRaycastData.RayType newRayType, Vector3 newOriginPoint, Vector3 newDir, float newRange)
		{
		}

		// Token: 0x0400186A RID: 6250
		[Token(Token = "0x400186A")]
		[FieldOffset(Offset = "0x0")]
		public LightCullingController.LightRaycastData.RayType rayType;

		// Token: 0x0400186B RID: 6251
		[Token(Token = "0x400186B")]
		[FieldOffset(Offset = "0x8")]
		public LightController lightRef;

		// Token: 0x0400186C RID: 6252
		[Token(Token = "0x400186C")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 originPoint;

		// Token: 0x0400186D RID: 6253
		[Token(Token = "0x400186D")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 direction;

		// Token: 0x0400186E RID: 6254
		[Token(Token = "0x400186E")]
		[FieldOffset(Offset = "0x28")]
		public float range;

		// Token: 0x0200037D RID: 893
		[Token(Token = "0x200037D")]
		public enum RayType
		{
			// Token: 0x04001870 RID: 6256
			[Token(Token = "0x4001870")]
			lightToCam,
			// Token: 0x04001871 RID: 6257
			[Token(Token = "0x4001871")]
			lightToFeet,
			// Token: 0x04001872 RID: 6258
			[Token(Token = "0x4001872")]
			lightToRadiusPoint,
			// Token: 0x04001873 RID: 6259
			[Token(Token = "0x4001873")]
			radiusPointToCam
		}
	}

	// Token: 0x0200037E RID: 894
	[Token(Token = "0x200037E")]
	private struct SetupCommandJob : IEnumerator<object>
	{
		// Token: 0x060013FB RID: 5115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FB")]
		[Address(RVA = "0x7A6CB0", Offset = "0x7A5CB0", VA = "0x1807A6CB0", Slot = "4")]
		public void Execute(int index)
		{
		}

		// Token: 0x04001874 RID: 6260
		[Token(Token = "0x4001874")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<RaycastCommand> commands;

		// Token: 0x04001875 RID: 6261
		[Token(Token = "0x4001875")]
		[FieldOffset(Offset = "0x10")]
		public NativeArray<Vector3> directions;

		// Token: 0x04001876 RID: 6262
		[Token(Token = "0x4001876")]
		[FieldOffset(Offset = "0x20")]
		public NativeArray<Vector3> origins;

		// Token: 0x04001877 RID: 6263
		[Token(Token = "0x4001877")]
		[FieldOffset(Offset = "0x30")]
		public NativeArray<float> ranges;

		// Token: 0x04001878 RID: 6264
		[Token(Token = "0x4001878")]
		[FieldOffset(Offset = "0x40")]
		public int mask;
	}
}
