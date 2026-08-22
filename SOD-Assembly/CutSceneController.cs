using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002FA RID: 762
[Token(Token = "0x20002FA")]
public class CutSceneController : MonoBehaviour
{
	// Token: 0x1700008C RID: 140
	// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700008C")]
	public static CutSceneController Instance
	{
		[Token(Token = "0x60010C5")]
		[Address(RVA = "0x6AD210", Offset = "0x6AC210", VA = "0x1806AD210")]
		get
		{
			return null;
		}
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010C6")]
	[Address(RVA = "0x6AD250", Offset = "0x6AC250", VA = "0x1806AD250")]
	private void Awake()
	{
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010C7")]
	[Address(RVA = "0x6AD5A0", Offset = "0x6AC5A0", VA = "0x1806AD5A0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010C8")]
	[Address(RVA = "0x6AD7B0", Offset = "0x6AC7B0", VA = "0x1806AD7B0")]
	public void PlayCutScene(CutScenePreset newPreset)
	{
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010C9")]
	[Address(RVA = "0x6ADB80", Offset = "0x6ACB80", VA = "0x1806ADB80")]
	private void Update()
	{
	}

	// Token: 0x060010CA RID: 4298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010CA")]
	[Address(RVA = "0x6AEFF0", Offset = "0x6ADFF0", VA = "0x1806AEFF0")]
	private void UpdateCam(Vector3 position, Quaternion rotation, bool updateMixing)
	{
	}

	// Token: 0x060010CB RID: 4299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010CB")]
	[Address(RVA = "0x6AF290", Offset = "0x6AE290", VA = "0x1806AF290")]
	private void SetActive(bool val)
	{
	}

	// Token: 0x060010CC RID: 4300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010CC")]
	[Address(RVA = "0x6B0710", Offset = "0x6AF710", VA = "0x1806B0710")]
	public void PlayScene()
	{
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010CD")]
	[Address(RVA = "0x6B0730", Offset = "0x6AF730", VA = "0x1806B0730")]
	public void StopScene()
	{
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010CE")]
	[Address(RVA = "0x6B08E0", Offset = "0x6AF8E0", VA = "0x1806B08E0")]
	public CutSceneController()
	{
	}

	// Token: 0x0400145F RID: 5215
	[Token(Token = "0x400145F")]
	[FieldOffset(Offset = "0x18")]
	public Image displayImage;

	// Token: 0x04001460 RID: 5216
	[Token(Token = "0x4001460")]
	[FieldOffset(Offset = "0x20")]
	public CanvasRenderer displayImageRend;

	// Token: 0x04001461 RID: 5217
	[Token(Token = "0x4001461")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI cutSceneSkipText;

	// Token: 0x04001462 RID: 5218
	[Token(Token = "0x4001462")]
	[FieldOffset(Offset = "0x30")]
	public bool cutSceneActive;

	// Token: 0x04001463 RID: 5219
	[Token(Token = "0x4001463")]
	[FieldOffset(Offset = "0x34")]
	public float sceneTimer;

	// Token: 0x04001464 RID: 5220
	[Token(Token = "0x4001464")]
	[FieldOffset(Offset = "0x38")]
	public CutScenePreset preset;

	// Token: 0x04001465 RID: 5221
	[Token(Token = "0x4001465")]
	[FieldOffset(Offset = "0x40")]
	public int cursor;

	// Token: 0x04001466 RID: 5222
	[Token(Token = "0x4001466")]
	[FieldOffset(Offset = "0x48")]
	private CutScenePreset.CutSceneElement previousElement;

	// Token: 0x04001467 RID: 5223
	[Token(Token = "0x4001467")]
	[FieldOffset(Offset = "0x50")]
	private List<CutScenePreset.CameraMovement> currentCamMovement;

	// Token: 0x04001468 RID: 5224
	[Token(Token = "0x4001468")]
	[FieldOffset(Offset = "0x58")]
	private CutScenePreset.CameraMovement currentFrom;

	// Token: 0x04001469 RID: 5225
	[Token(Token = "0x4001469")]
	[FieldOffset(Offset = "0x60")]
	private CutScenePreset.CameraMovement currentTo;

	// Token: 0x0400146A RID: 5226
	[Token(Token = "0x400146A")]
	[FieldOffset(Offset = "0x68")]
	public float currentShotTimer;

	// Token: 0x0400146B RID: 5227
	[Token(Token = "0x400146B")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 playerSavedPosition;

	// Token: 0x0400146C RID: 5228
	[Token(Token = "0x400146C")]
	[FieldOffset(Offset = "0x78")]
	private Quaternion camSavedLocalQuat;

	// Token: 0x0400146D RID: 5229
	[Token(Token = "0x400146D")]
	[FieldOffset(Offset = "0x88")]
	private bool savedFreeCam;

	// Token: 0x0400146E RID: 5230
	[Token(Token = "0x400146E")]
	[FieldOffset(Offset = "0x89")]
	private bool savedInaudible;

	// Token: 0x0400146F RID: 5231
	[Token(Token = "0x400146F")]
	[FieldOffset(Offset = "0x8A")]
	private bool savedInvisible;

	// Token: 0x04001470 RID: 5232
	[Token(Token = "0x4001470")]
	[FieldOffset(Offset = "0x8B")]
	private bool savedInvincible;

	// Token: 0x04001471 RID: 5233
	[Token(Token = "0x4001471")]
	[FieldOffset(Offset = "0x8C")]
	private bool savedPhotoMode;

	// Token: 0x04001472 RID: 5234
	[Token(Token = "0x4001472")]
	[FieldOffset(Offset = "0x8D")]
	private bool triggeredFadeOut;

	// Token: 0x04001473 RID: 5235
	[Token(Token = "0x4001473")]
	[FieldOffset(Offset = "0x90")]
	private CutScenePreset.CutSceneElement finalShot;

	// Token: 0x04001474 RID: 5236
	[Token(Token = "0x4001474")]
	[FieldOffset(Offset = "0x98")]
	private bool triggeredImage;

	// Token: 0x04001475 RID: 5237
	[Token(Token = "0x4001475")]
	[FieldOffset(Offset = "0x9C")]
	private float imageFadeIn;

	// Token: 0x04001476 RID: 5238
	[Token(Token = "0x4001476")]
	[FieldOffset(Offset = "0xA0")]
	private float imageFadeOut;

	// Token: 0x04001477 RID: 5239
	[Token(Token = "0x4001477")]
	[FieldOffset(Offset = "0xA8")]
	public CutScenePreset debugLoad;

	// Token: 0x04001478 RID: 5240
	[Token(Token = "0x4001478")]
	[FieldOffset(Offset = "0x0")]
	private static CutSceneController _instance;

	// Token: 0x020002FB RID: 763
	[Token(Token = "0x20002FB")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060010D0 RID: 4304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x000085E0 File Offset: 0x000067E0
		[Token(Token = "0x60010D1")]
		[Address(RVA = "0x6B09E0", Offset = "0x6AF9E0", VA = "0x1806B09E0")]
		internal int <Update>b__31_0(CutScenePreset.CameraMovement p1, CutScenePreset.CameraMovement p2)
		{
			return 0;
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x000085F8 File Offset: 0x000067F8
		[Token(Token = "0x60010D2")]
		[Address(RVA = "0x6B0A70", Offset = "0x6AFA70", VA = "0x1806B0A70")]
		internal bool <SetActive>b__33_0(PlayerPrefsController.GameSetting item)
		{
			return default(bool);
		}

		// Token: 0x04001479 RID: 5241
		[Token(Token = "0x4001479")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CutSceneController.<>c <>9;

		// Token: 0x0400147A RID: 5242
		[Token(Token = "0x400147A")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<CutScenePreset.CameraMovement> <>9__31_0;

		// Token: 0x0400147B RID: 5243
		[Token(Token = "0x400147B")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<PlayerPrefsController.GameSetting> <>9__33_0;
	}
}
