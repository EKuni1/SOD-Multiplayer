using System;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;

// Token: 0x02000201 RID: 513
[Token(Token = "0x2000201")]
public class CityEditorInputController : MonoBehaviour
{
	// Token: 0x06000C3E RID: 3134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C3E")]
	[Address(RVA = "0x5910A0", Offset = "0x5900A0", VA = "0x1805910A0")]
	private void Awake()
	{
	}

	// Token: 0x06000C3F RID: 3135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0x5911E0", Offset = "0x5901E0", VA = "0x1805911E0")]
	private void Start()
	{
	}

	// Token: 0x06000C40 RID: 3136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C40")]
	[Address(RVA = "0x591390", Offset = "0x590390", VA = "0x180591390")]
	private void Update()
	{
	}

	// Token: 0x06000C41 RID: 3137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x591490", Offset = "0x590490", VA = "0x180591490")]
	private void HandleCameraInputs()
	{
	}

	// Token: 0x06000C42 RID: 3138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C42")]
	[Address(RVA = "0x592890", Offset = "0x591890", VA = "0x180592890")]
	private void ConstrainCameraPivotPosition()
	{
	}

	// Token: 0x06000C43 RID: 3139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C43")]
	[Address(RVA = "0x592A50", Offset = "0x591A50", VA = "0x180592A50")]
	private void ConstrainCameraZoom()
	{
	}

	// Token: 0x06000C44 RID: 3140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C44")]
	[Address(RVA = "0x592AC0", Offset = "0x591AC0", VA = "0x180592AC0")]
	public CityEditorInputController()
	{
	}

	// Token: 0x04000CA4 RID: 3236
	[Token(Token = "0x4000CA4")]
	[FieldOffset(Offset = "0x18")]
	public Camera editorCam;

	// Token: 0x04000CA5 RID: 3237
	[Token(Token = "0x4000CA5")]
	[FieldOffset(Offset = "0x20")]
	public Transform cameraPitch;

	// Token: 0x04000CA6 RID: 3238
	[Token(Token = "0x4000CA6")]
	[FieldOffset(Offset = "0x28")]
	public Transform cameraPivot;

	// Token: 0x04000CA7 RID: 3239
	[Token(Token = "0x4000CA7")]
	[FieldOffset(Offset = "0x30")]
	public float rotateSpeed;

	// Token: 0x04000CA8 RID: 3240
	[Token(Token = "0x4000CA8")]
	[FieldOffset(Offset = "0x34")]
	public float flySpeed;

	// Token: 0x04000CA9 RID: 3241
	[Token(Token = "0x4000CA9")]
	[FieldOffset(Offset = "0x38")]
	public float minZoom;

	// Token: 0x04000CAA RID: 3242
	[Token(Token = "0x4000CAA")]
	[FieldOffset(Offset = "0x3C")]
	public float maxZoom;

	// Token: 0x04000CAB RID: 3243
	[Token(Token = "0x4000CAB")]
	[FieldOffset(Offset = "0x40")]
	public float zoomFactor;

	// Token: 0x04000CAC RID: 3244
	[Token(Token = "0x4000CAC")]
	[FieldOffset(Offset = "0x44")]
	public float zoomSpeed;

	// Token: 0x04000CAD RID: 3245
	[Token(Token = "0x4000CAD")]
	[FieldOffset(Offset = "0x48")]
	private Rewired.Player _player;

	// Token: 0x04000CAE RID: 3246
	[Token(Token = "0x4000CAE")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 targetZoomPos;

	// Token: 0x04000CAF RID: 3247
	[Token(Token = "0x4000CAF")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 curZoomPos;

	// Token: 0x04000CB0 RID: 3248
	[Token(Token = "0x4000CB0")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 curRot;

	// Token: 0x04000CB1 RID: 3249
	[Token(Token = "0x4000CB1")]
	[FieldOffset(Offset = "0x74")]
	public Vector3 tgtRot;
}
