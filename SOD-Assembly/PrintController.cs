using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000489 RID: 1161
[Token(Token = "0x2000489")]
public class PrintController : MonoBehaviour
{
	// Token: 0x06001A76 RID: 6774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A76")]
	[Address(RVA = "0x984230", Offset = "0x983230", VA = "0x180984230")]
	private void Awake()
	{
	}

	// Token: 0x06001A77 RID: 6775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A77")]
	[Address(RVA = "0x9842C0", Offset = "0x9832C0", VA = "0x1809842C0")]
	public void SetPoints()
	{
	}

	// Token: 0x06001A78 RID: 6776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A78")]
	[Address(RVA = "0x984530", Offset = "0x983530", VA = "0x180984530")]
	public void Setup(FingerprintScannerController.Print newPrint)
	{
	}

	// Token: 0x06001A79 RID: 6777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A79")]
	[Address(RVA = "0x984DA0", Offset = "0x983DA0", VA = "0x180984DA0")]
	private void Update()
	{
	}

	// Token: 0x06001A7A RID: 6778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A7A")]
	[Address(RVA = "0x9850C0", Offset = "0x9840C0", VA = "0x1809850C0")]
	public void ResetScan()
	{
	}

	// Token: 0x06001A7B RID: 6779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A7B")]
	[Address(RVA = "0x9850D0", Offset = "0x9840D0", VA = "0x1809850D0")]
	public void PrintConfirmed()
	{
	}

	// Token: 0x06001A7C RID: 6780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A7C")]
	[Address(RVA = "0x985F50", Offset = "0x984F50", VA = "0x180985F50")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001A7D RID: 6781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A7D")]
	[Address(RVA = "0x986070", Offset = "0x985070", VA = "0x180986070")]
	public PrintController()
	{
	}

	// Token: 0x04002027 RID: 8231
	[Token(Token = "0x4002027")]
	[FieldOffset(Offset = "0x18")]
	public FingerprintScannerController.Print printData;

	// Token: 0x04002028 RID: 8232
	[Token(Token = "0x4002028")]
	[FieldOffset(Offset = "0x20")]
	public Material fingerprintMaterial;

	// Token: 0x04002029 RID: 8233
	[Token(Token = "0x4002029")]
	[FieldOffset(Offset = "0x28")]
	public Material instancedMaterial;

	// Token: 0x0400202A RID: 8234
	[Token(Token = "0x400202A")]
	[FieldOffset(Offset = "0x30")]
	public DecalProjector projector;

	// Token: 0x0400202B RID: 8235
	[Token(Token = "0x400202B")]
	[FieldOffset(Offset = "0x38")]
	public Color visibleColour;

	// Token: 0x0400202C RID: 8236
	[Token(Token = "0x400202C")]
	[FieldOffset(Offset = "0x48")]
	public Color invisibleColour;

	// Token: 0x0400202D RID: 8237
	[Token(Token = "0x400202D")]
	[FieldOffset(Offset = "0x58")]
	public float scanProgress;

	// Token: 0x0400202E RID: 8238
	[Token(Token = "0x400202E")]
	[FieldOffset(Offset = "0x5C")]
	public bool printConfirmed;

	// Token: 0x0400202F RID: 8239
	[Token(Token = "0x400202F")]
	[FieldOffset(Offset = "0x60")]
	public Transform beamTargetTransform;

	// Token: 0x04002030 RID: 8240
	[Token(Token = "0x4002030")]
	[FieldOffset(Offset = "0x68")]
	public InteractableController printInteractable;

	// Token: 0x04002031 RID: 8241
	[Token(Token = "0x4002031")]
	[FieldOffset(Offset = "0x70")]
	private LineRenderer _lineRenderer;

	// Token: 0x0200048A RID: 1162
	[Token(Token = "0x200048A")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001A7F RID: 6783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A7F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x0000C648 File Offset: 0x0000A848
		[Token(Token = "0x6001A80")]
		[Address(RVA = "0x986180", Offset = "0x985180", VA = "0x180986180")]
		internal bool <PrintConfirmed>b__16_0(Objective item)
		{
			return default(bool);
		}

		// Token: 0x04002032 RID: 8242
		[Token(Token = "0x4002032")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PrintController.<>c <>9;

		// Token: 0x04002033 RID: 8243
		[Token(Token = "0x4002033")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Objective> <>9__16_0;
	}
}
