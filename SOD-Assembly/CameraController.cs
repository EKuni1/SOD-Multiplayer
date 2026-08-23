using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.UI;

// Token: 0x0200003B RID: 59
[Token(Token = "0x200003B")]
public class CameraController : MonoBehaviour
{
	// Token: 0x17000022 RID: 34
	// (get) Token: 0x060001F2 RID: 498 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000022")]
	public static CameraController Instance
	{
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x5CD4C0", Offset = "0x5CC4C0", VA = "0x1805CD4C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x5CD500", Offset = "0x5CC500", VA = "0x1805CD500")]
	private void Awake()
	{
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x5CD8D0", Offset = "0x5CC8D0", VA = "0x1805CD8D0")]
	public void NewHighlightScroll(Vector2 newScrollPosPathmap)
	{
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x5CDAD0", Offset = "0x5CCAD0", VA = "0x1805CDAD0")]
	public void CancelHighlightScroll()
	{
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x5CDAF0", Offset = "0x5CCAF0", VA = "0x1805CDAF0")]
	public void ImmediateCancelHighlightScroll()
	{
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x5CDCF0", Offset = "0x5CCCF0", VA = "0x1805CDCF0")]
	public void SetupFPS()
	{
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x5CE650", Offset = "0x5CD650", VA = "0x1805CE650")]
	public void FadeCamera(float fadeSpeed)
	{
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x5CE7E0", Offset = "0x5CD7E0", VA = "0x1805CE7E0")]
	public void UnFadeCamera(float fadeSpeed)
	{
	}

	// Token: 0x060001FA RID: 506 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x5CE970", Offset = "0x5CD970", VA = "0x1805CE970")]
	private IEnumerator CameraFade(bool fade = true, float fadeSpeed = 1f)
	{
		return null;
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00002D60 File Offset: 0x00000F60
	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x5CEA30", Offset = "0x5CDA30", VA = "0x1805CEA30")]
	public float GetPlayerLightLevel()
	{
		return 0f;
	}

	// Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x5D0180", Offset = "0x5CF180", VA = "0x1805D0180")]
	private void OnDestroy()
	{
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x5D0220", Offset = "0x5CF220", VA = "0x1805D0220")]
	private void LateUpdate()
	{
	}

	// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x5D14B0", Offset = "0x5D04B0", VA = "0x1805D14B0")]
	public CameraController()
	{
	}

	// Token: 0x04000141 RID: 321
	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0x18")]
	public GameObject cameraObj;

	// Token: 0x04000142 RID: 322
	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0x20")]
	public GameObject container;

	// Token: 0x04000143 RID: 323
	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0x28")]
	public Camera cam;

	// Token: 0x04000144 RID: 324
	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0x30")]
	public HDAdditionalCameraData hdrpCam;

	// Token: 0x04000145 RID: 325
	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0x38")]
	public bool fadeActive;

	// Token: 0x04000146 RID: 326
	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x40")]
	public Image fadeImage;

	// Token: 0x04000147 RID: 327
	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 camHeightLimit;

	// Token: 0x04000148 RID: 328
	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x50")]
	public float heightRatio;

	// Token: 0x04000149 RID: 329
	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0x54")]
	public Vector3 defaultCameraEuler;

	// Token: 0x0400014A RID: 330
	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x60")]
	public float scrollSensitivity;

	// Token: 0x0400014B RID: 331
	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x64")]
	public float camScrollHeightModifier;

	// Token: 0x0400014C RID: 332
	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x68")]
	public float rotateSensitivity;

	// Token: 0x0400014D RID: 333
	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x6C")]
	public float zoomSensitivity;

	// Token: 0x0400014E RID: 334
	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x70")]
	public float smoothRotateSpeed;

	// Token: 0x0400014F RID: 335
	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x74")]
	public float smoothZoomSpeed;

	// Token: 0x04000150 RID: 336
	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x78")]
	public float highlightScrollSpeed;

	// Token: 0x04000151 RID: 337
	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x7C")]
	public float isoCamBoundaryMultiplier;

	// Token: 0x04000152 RID: 338
	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x80")]
	public float topCamBoundaryMultiplier;

	// Token: 0x04000153 RID: 339
	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x84")]
	public bool highlightScrollActive;

	// Token: 0x04000154 RID: 340
	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x85")]
	public bool highlightScrollCancelFlag;

	// Token: 0x04000155 RID: 341
	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x88")]
	public Vector3 originalCameraPosition;

	// Token: 0x04000156 RID: 342
	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x94")]
	public Vector3 highlightScroll;

	// Token: 0x04000157 RID: 343
	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject highlightScrollMarker;

	// Token: 0x04000158 RID: 344
	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0xA8")]
	public float highlightTileHeight;

	// Token: 0x04000159 RID: 345
	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x0")]
	private static CameraController _instance;

	// Token: 0x0400015A RID: 346
	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0xB0")]
	private List<CameraController.LightRaycastData> lightRaycastDataCollection;

	// Token: 0x0400015B RID: 347
	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0xB8")]
	private List<RaycastCommand> raycastCommands;

	// Token: 0x0400015C RID: 348
	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0xC0")]
	private NativeArray<RaycastHit> results;

	// Token: 0x0400015D RID: 349
	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0xD0")]
	private NativeArray<RaycastCommand> commands;

	// Token: 0x0400015E RID: 350
	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0xE0")]
	private JobHandle handle;

	// Token: 0x0400015F RID: 351
	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0xF0")]
	private bool isLightLevelJobInProgress;

	// Token: 0x04000160 RID: 352
	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0xF4")]
	private float lightLevel;

	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	private struct LightRaycastData
	{
		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x5D18C0", Offset = "0x5D08C0", VA = "0x1805D18C0")]
		public LightRaycastData(float maxRange, float lightMultiplier, int phase, bool isReverseCheck)
		{
		}

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x0")]
		public float MaxRange;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x4")]
		public float LightMultiplier;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x8")]
		public int Phase;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0xC")]
		public bool IsReverseCheck;
	}

	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	private sealed class <CameraFade>d__34 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <CameraFade>d__34(int <>1__state)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x5D18E0", Offset = "0x5D08E0", VA = "0x1805D18E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000023")]
		private object Current
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x5D1B80", Offset = "0x5D0B80", VA = "0x1805D1B80", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000024")]
		private object Current
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x20")]
		public bool fade;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x28")]
		public CameraController <>4__this;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x30")]
		private float <snapProgress>5__2;
	}
}
