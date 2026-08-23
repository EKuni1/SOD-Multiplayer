using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006BB RID: 1723
[Token(Token = "0x20006BB")]
public class ZoomContent : MonoBehaviour
{
	// Token: 0x0600269F RID: 9887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600269F")]
	[Address(RVA = "0xBEE140", Offset = "0xBED140", VA = "0x180BEE140")]
	private void Awake()
	{
	}

	// Token: 0x060026A0 RID: 9888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026A0")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	private void Start()
	{
	}

	// Token: 0x060026A1 RID: 9889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026A1")]
	[Address(RVA = "0xBEE7E0", Offset = "0xBED7E0", VA = "0x180BEE7E0")]
	private void SetPivotPoint(float pivotBias, ZoomContent.ZoomPivot usePivot = ZoomContent.ZoomPivot.mousePosition)
	{
	}

	// Token: 0x060026A2 RID: 9890 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026A2")]
	[Address(RVA = "0xBEF660", Offset = "0xBEE660", VA = "0x180BEF660")]
	public void ResetPivot()
	{
	}

	// Token: 0x060026A3 RID: 9891 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026A3")]
	[Address(RVA = "0xBEF7D0", Offset = "0xBEE7D0", VA = "0x180BEF7D0")]
	private void LateUpdate()
	{
	}

	// Token: 0x060026A4 RID: 9892 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
	[Token(Token = "0x60026A4")]
	[Address(RVA = "0xBF0420", Offset = "0xBEF420", VA = "0x180BF0420")]
	public float GetNormalizedZoom(float zoom)
	{
		return 0f;
	}

	// Token: 0x060026A5 RID: 9893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026A5")]
	[Address(RVA = "0xBF0450", Offset = "0xBEF450", VA = "0x180BF0450")]
	public void ApplyZoom(float normalizedZoom)
	{
	}

	// Token: 0x060026A6 RID: 9894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026A6")]
	[Address(RVA = "0xBF08F0", Offset = "0xBEF8F0", VA = "0x180BF08F0")]
	public void SetZoom(float newZoom)
	{
	}

	// Token: 0x060026A7 RID: 9895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026A7")]
	[Address(RVA = "0xBF0960", Offset = "0xBEF960", VA = "0x180BF0960")]
	public ZoomContent()
	{
	}

	// Token: 0x040030B3 RID: 12467
	[Token(Token = "0x40030B3")]
	[FieldOffset(Offset = "0x18")]
	public string zoomAxis;

	// Token: 0x040030B4 RID: 12468
	[Token(Token = "0x40030B4")]
	[FieldOffset(Offset = "0x20")]
	public bool enableZoomWithMouseWheel;

	// Token: 0x040030B5 RID: 12469
	[Token(Token = "0x40030B5")]
	[FieldOffset(Offset = "0x21")]
	public bool enableInFirstPersonMap;

	// Token: 0x040030B6 RID: 12470
	[Token(Token = "0x40030B6")]
	[FieldOffset(Offset = "0x22")]
	public bool useZoomSteps;

	// Token: 0x040030B7 RID: 12471
	[Token(Token = "0x40030B7")]
	[FieldOffset(Offset = "0x24")]
	public int numberOfSteps;

	// Token: 0x040030B8 RID: 12472
	[Token(Token = "0x40030B8")]
	[FieldOffset(Offset = "0x28")]
	public float zoomSensitivity;

	// Token: 0x040030B9 RID: 12473
	[Token(Token = "0x40030B9")]
	[FieldOffset(Offset = "0x2C")]
	public float controllerSensitivityMultiplier;

	// Token: 0x040030BA RID: 12474
	[Token(Token = "0x40030BA")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve zoomCurve;

	// Token: 0x040030BB RID: 12475
	[Token(Token = "0x40030BB")]
	[FieldOffset(Offset = "0x38")]
	public float smoothZoomSpeed;

	// Token: 0x040030BC RID: 12476
	[Token(Token = "0x40030BC")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 zoomLimit;

	// Token: 0x040030BD RID: 12477
	[Token(Token = "0x40030BD")]
	[FieldOffset(Offset = "0x44")]
	public float zoomToCursorPercentage;

	// Token: 0x040030BE RID: 12478
	[Token(Token = "0x40030BE")]
	[FieldOffset(Offset = "0x48")]
	public float zoom;

	// Token: 0x040030BF RID: 12479
	[Token(Token = "0x40030BF")]
	[FieldOffset(Offset = "0x4C")]
	public float desiredZoom;

	// Token: 0x040030C0 RID: 12480
	[Token(Token = "0x40030C0")]
	[FieldOffset(Offset = "0x50")]
	public float normalizedZoom;

	// Token: 0x040030C1 RID: 12481
	[Token(Token = "0x40030C1")]
	[FieldOffset(Offset = "0x54")]
	public float zoomProgress;

	// Token: 0x040030C2 RID: 12482
	[Token(Token = "0x40030C2")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 normalSize;

	// Token: 0x040030C3 RID: 12483
	[Token(Token = "0x40030C3")]
	[FieldOffset(Offset = "0x60")]
	public float axisInputDelay;

	// Token: 0x040030C4 RID: 12484
	[Token(Token = "0x40030C4")]
	[FieldOffset(Offset = "0x68")]
	public List<string> allowedMouseOverTags;

	// Token: 0x040030C5 RID: 12485
	[Token(Token = "0x40030C5")]
	[FieldOffset(Offset = "0x70")]
	public List<RectTransform> additionalRects;

	// Token: 0x040030C6 RID: 12486
	[Token(Token = "0x40030C6")]
	[FieldOffset(Offset = "0x78")]
	public InfoWindow window;

	// Token: 0x040030C7 RID: 12487
	[Token(Token = "0x40030C7")]
	[FieldOffset(Offset = "0x80")]
	public RectTransform containerRect;

	// Token: 0x040030C8 RID: 12488
	[Token(Token = "0x40030C8")]
	[FieldOffset(Offset = "0x88")]
	public CustomScrollRect scroll;

	// Token: 0x040030C9 RID: 12489
	[Token(Token = "0x40030C9")]
	[FieldOffset(Offset = "0x90")]
	public RectTransform scrollRectArea;

	// Token: 0x040030CA RID: 12490
	[Token(Token = "0x40030CA")]
	[FieldOffset(Offset = "0x98")]
	public ViewportMouseOver viewportMouseOver;

	// Token: 0x040030CB RID: 12491
	[Token(Token = "0x40030CB")]
	[FieldOffset(Offset = "0xA0")]
	public WindowContentController contentController;

	// Token: 0x040030CC RID: 12492
	[Token(Token = "0x40030CC")]
	[FieldOffset(Offset = "0xA8")]
	public CanvasGroup canvasGroup;

	// Token: 0x020006BC RID: 1724
	[Token(Token = "0x20006BC")]
	public enum ZoomPivot
	{
		// Token: 0x040030CE RID: 12494
		[Token(Token = "0x40030CE")]
		mousePosition,
		// Token: 0x040030CF RID: 12495
		[Token(Token = "0x40030CF")]
		playerMapPosition
	}
}
