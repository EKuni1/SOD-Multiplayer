using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000422 RID: 1058
[Token(Token = "0x2000422")]
public class FingerprintScannerController : MonoBehaviour
{
	// Token: 0x060017D5 RID: 6101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017D5")]
	[Address(RVA = "0x8A53C0", Offset = "0x8A43C0", VA = "0x1808A53C0")]
	private void Start()
	{
	}

	// Token: 0x060017D6 RID: 6102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017D6")]
	[Address(RVA = "0x8A5840", Offset = "0x8A4840", VA = "0x1808A5840")]
	public void SetOn(bool val)
	{
	}

	// Token: 0x060017D7 RID: 6103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017D7")]
	[Address(RVA = "0x8A5DA0", Offset = "0x8A4DA0", VA = "0x1808A5DA0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060017D8 RID: 6104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017D8")]
	[Address(RVA = "0x8A62F0", Offset = "0x8A52F0", VA = "0x1808A62F0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x060017D9 RID: 6105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017D9")]
	[Address(RVA = "0x8A9530", Offset = "0x8A8530", VA = "0x1808A9530")]
	public void Flash(int newRepeat, bool colourOverride, [Optional] Color colour, float speed = 10f)
	{
	}

	// Token: 0x060017DA RID: 6106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017DA")]
	[Address(RVA = "0x8A95E0", Offset = "0x8A85E0", VA = "0x1808A95E0")]
	public void OnHoverOnNewPrint()
	{
	}

	// Token: 0x060017DB RID: 6107 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017DB")]
	[Address(RVA = "0x8AA2E0", Offset = "0x8A92E0", VA = "0x1808AA2E0")]
	private HashSet<FingerprintScannerController.Print> GetDynamicPrints(InteractableController interactable)
	{
		return null;
	}

	// Token: 0x060017DC RID: 6108 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017DC")]
	[Address(RVA = "0x8AAF50", Offset = "0x8A9F50", VA = "0x1808AAF50")]
	private HashSet<FingerprintScannerController.Print> GetPrintPoints(Transform checkTransform)
	{
		return null;
	}

	// Token: 0x060017DD RID: 6109 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017DD")]
	[Address(RVA = "0x8AC7E0", Offset = "0x8AB7E0", VA = "0x1808AC7E0")]
	private List<Vector3> GetPrintLocationsOnMeshNonDynamic(MeshFilter meshFilter, float printDensityPerUnit, out List<Vector3> normals, bool useHeightThreshold = false, [Optional] NewRoom heightThresholdRoom)
	{
		return null;
	}

	// Token: 0x060017DE RID: 6110 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017DE")]
	[Address(RVA = "0x8ACF40", Offset = "0x8ABF40", VA = "0x1808ACF40")]
	private List<Vector3> GetPrintLocationsOnMesh(MeshFilter meshFilter, int prints, out List<Vector3> normals, bool useHeightThreshold = false, [Optional] NewRoom heightThresholdRoom, [Optional] List<string> seeds)
	{
		return null;
	}

	// Token: 0x060017DF RID: 6111 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017DF")]
	[Address(RVA = "0x8AE3E0", Offset = "0x8AD3E0", VA = "0x1808AE3E0")]
	private float[] GetTriSizes(int[] tris, Vector3[] verts)
	{
		return null;
	}

	// Token: 0x060017E0 RID: 6112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017E0")]
	[Address(RVA = "0x8AE6C0", Offset = "0x8AD6C0", VA = "0x1808AE6C0")]
	private void StartPrintScannerHaptics()
	{
	}

	// Token: 0x060017E1 RID: 6113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017E1")]
	[Address(RVA = "0x8AE850", Offset = "0x8AD850", VA = "0x1808AE850")]
	private void StopPrintScannerHaptics()
	{
	}

	// Token: 0x060017E2 RID: 6114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017E2")]
	[Address(RVA = "0x8AEA00", Offset = "0x8ADA00", VA = "0x1808AEA00")]
	public FingerprintScannerController()
	{
	}

	// Token: 0x04001D24 RID: 7460
	[Token(Token = "0x4001D24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshPro screenText;

	// Token: 0x04001D25 RID: 7461
	[Token(Token = "0x4001D25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform progressBar;

	// Token: 0x04001D26 RID: 7462
	[Token(Token = "0x4001D26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform beamRoot;

	// Token: 0x04001D27 RID: 7463
	[Token(Token = "0x4001D27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MeshRenderer screen;

	// Token: 0x04001D28 RID: 7464
	[Token(Token = "0x4001D28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform printTransform;

	// Token: 0x04001D29 RID: 7465
	[Token(Token = "0x4001D29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject pixelPrefab;

	// Token: 0x04001D2A RID: 7466
	[Token(Token = "0x4001D2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<GameObject> pixels;

	// Token: 0x04001D2B RID: 7467
	[Token(Token = "0x4001D2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<GameObject> blockedPixelsActive;

	// Token: 0x04001D2C RID: 7468
	[Token(Token = "0x4001D2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject screenLight;

	// Token: 0x04001D2D RID: 7469
	[Token(Token = "0x4001D2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Light scanLight;

	// Token: 0x04001D2E RID: 7470
	[Token(Token = "0x4001D2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool isOn;

	// Token: 0x04001D2F RID: 7471
	[Token(Token = "0x4001D2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float screenOnDelay;

	// Token: 0x04001D30 RID: 7472
	[Token(Token = "0x4001D30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AudioEvent progressLoop;

	// Token: 0x04001D31 RID: 7473
	[Token(Token = "0x4001D31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AudioEvent detect;

	// Token: 0x04001D32 RID: 7474
	[Token(Token = "0x4001D32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AudioEvent detectExisting;

	// Token: 0x04001D33 RID: 7475
	[Token(Token = "0x4001D33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public AudioEvent success;

	// Token: 0x04001D34 RID: 7476
	[Token(Token = "0x4001D34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public AudioEvent hoverOff;

	// Token: 0x04001D35 RID: 7477
	[Token(Token = "0x4001D35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private AudioController.LoopingSoundInfo progressLoopEvent;

	// Token: 0x04001D36 RID: 7478
	[Token(Token = "0x4001D36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<Transform> lookingAt;

	// Token: 0x04001D37 RID: 7479
	[Token(Token = "0x4001D37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<PrintController> spawnedPrints;

	// Token: 0x04001D38 RID: 7480
	[Token(Token = "0x4001D38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public PrintController hoverPrint;

	// Token: 0x04001D39 RID: 7481
	[Token(Token = "0x4001D39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public FootprintController hoverFootPrint;

	// Token: 0x04001D3A RID: 7482
	[Token(Token = "0x4001D3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float scanSpeed;

	// Token: 0x04001D3B RID: 7483
	[Token(Token = "0x4001D3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private bool flashActive;

	// Token: 0x04001D3C RID: 7484
	[Token(Token = "0x4001D3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float flashSpeed;

	// Token: 0x04001D3D RID: 7485
	[Token(Token = "0x4001D3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public Color flashColour;

	// Token: 0x04001D3E RID: 7486
	[Token(Token = "0x4001D3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private int cycle;

	// Token: 0x04001D3F RID: 7487
	[Token(Token = "0x4001D3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float flashProgress;

	// Token: 0x04001D40 RID: 7488
	[Token(Token = "0x4001D40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float flashF;

	// Token: 0x04001D41 RID: 7489
	[Token(Token = "0x4001D41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int flashRepeat;

	// Token: 0x04001D42 RID: 7490
	[Token(Token = "0x4001D42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Dictionary<Transform, HashSet<FingerprintScannerController.Print>> cachedStaticPrints;

	// Token: 0x04001D43 RID: 7491
	[Token(Token = "0x4001D43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Dictionary<Interactable, HashSet<FingerprintScannerController.Print>> cachedDynamicPrints;

	// Token: 0x02000423 RID: 1059
	[Token(Token = "0x2000423")]
	[Serializable]
	public class Print
	{
		// Token: 0x060017E3 RID: 6115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60017E3")]
		[Address(RVA = "0x8AEE50", Offset = "0x8ADE50", VA = "0x1808AEE50")]
		public Human GetOwner()
		{
			return null;
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public Print()
		{
		}

		// Token: 0x04001D44 RID: 7492
		[Token(Token = "0x4001D44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 worldPos;

		// Token: 0x04001D45 RID: 7493
		[Token(Token = "0x4001D45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 normal;

		// Token: 0x04001D46 RID: 7494
		[Token(Token = "0x4001D46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FingerprintScannerController.Print.PrintType type;

		// Token: 0x04001D47 RID: 7495
		[Token(Token = "0x4001D47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public RoomConfiguration.PrintsSource source;

		// Token: 0x04001D48 RID: 7496
		[Token(Token = "0x4001D48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Transform parentTranform;

		// Token: 0x04001D49 RID: 7497
		[Token(Token = "0x4001D49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public NewRoom room;

		// Token: 0x04001D4A RID: 7498
		[Token(Token = "0x4001D4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Interactable interactable;

		// Token: 0x04001D4B RID: 7499
		[Token(Token = "0x4001D4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public FurnitureLocation furniture;

		// Token: 0x04001D4C RID: 7500
		[Token(Token = "0x4001D4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Human dynamicOwner;

		// Token: 0x02000424 RID: 1060
		[Token(Token = "0x2000424")]
		public enum PrintType
		{
			// Token: 0x04001D4E RID: 7502
			[Token(Token = "0x4001D4E")]
			fingerPrint,
			// Token: 0x04001D4F RID: 7503
			[Token(Token = "0x4001D4F")]
			footPrint
		}
	}
}
