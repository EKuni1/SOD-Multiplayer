using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000545 RID: 1349
[Token(Token = "0x2000545")]
public class SceneCapture : MonoBehaviour
{
	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x06001D5D RID: 7517 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000E7")]
	public static SceneCapture Instance
	{
		[Token(Token = "0x6001D5D")]
		[Address(RVA = "0xA1F3B0", Offset = "0xA1E3B0", VA = "0x180A1F3B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001D5E RID: 7518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D5E")]
	[Address(RVA = "0xA1F3F0", Offset = "0xA1E3F0", VA = "0x180A1F3F0")]
	private void Awake()
	{
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D5F")]
	[Address(RVA = "0xA1F740", Offset = "0xA1E740", VA = "0x180A1F740")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001D60 RID: 7520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D60")]
	[Address(RVA = "0xA1FCC0", Offset = "0xA1ECC0", VA = "0x180A1FCC0")]
	private void Start()
	{
	}

	// Token: 0x06001D61 RID: 7521 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D61")]
	[Address(RVA = "0xA1FD20", Offset = "0xA1ED20", VA = "0x180A1FD20")]
	public Texture2D CapturePhotoOfEvidence(Evidence ev, bool forceNew = false)
	{
		return null;
	}

	// Token: 0x06001D62 RID: 7522 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D62")]
	[Address(RVA = "0xA22F10", Offset = "0xA21F10", VA = "0x180A22F10")]
	public Texture2D GetSurveillanceScene(SceneRecorder.SceneCapture scene, bool saveToCache = true)
	{
		return null;
	}

	// Token: 0x06001D63 RID: 7523 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D63")]
	[Address(RVA = "0xA25750", Offset = "0xA24750", VA = "0x180A25750")]
	public Texture2D CaptureScene(Vector3 pos, Vector3 euler, int layerMask, bool changeTimeOfDay, float decimalClock, RenderTexture renderPrefab, float fov = 70f, [Optional] List<Interactable> forceHide, [Optional] NewNode passNode, bool useCaptureLight = true, bool basicMode = false, bool ignoreEarlyCapError = false, SceneCapture.PostProcessingProfile captureProfile = SceneCapture.PostProcessingProfile.captureNormal, bool useFlashlight = false, bool useFlash = false, bool readOnly = true, bool sampleCentrePixel = false, [Optional] SceneRecorder.SceneCapture sceneRef, bool saveToDisk = true)
	{
		return null;
	}

	// Token: 0x06001D64 RID: 7524 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D64")]
	[Address(RVA = "0xA25960", Offset = "0xA24960", VA = "0x180A25960")]
	public Texture2D CaptureScene(Vector3 pos, Vector3 euler, int layerMask, bool changeTimeOfDay, float decimalClock, RenderTexture renderPrefab, ref List<SceneRecorder.ActorCapture> humanRef, out List<SceneCapture.ActorScreenPosition> actorScreenPointCapture, float fov = 70f, [Optional] List<Interactable> forceHide, [Optional] NewNode passNode, bool useCaptureLight = true, bool basicMode = false, bool ignoreEarlyCapError = false, SceneCapture.PostProcessingProfile captureProfile = SceneCapture.PostProcessingProfile.captureNormal, bool useFlashlight = false, bool useFlash = false, bool readOnly = true, [Optional] AirDuctGroup inAirDuctGroup, bool sampleCentrePixel = false, [Optional] SceneRecorder.SceneCapture sceneRef, bool saveToDisk = true)
	{
		return null;
	}

	// Token: 0x06001D65 RID: 7525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D65")]
	[Address(RVA = "0xA29170", Offset = "0xA28170", VA = "0x180A29170")]
	public void ClearRenderCache()
	{
	}

	// Token: 0x06001D66 RID: 7526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D66")]
	[Address(RVA = "0xA29500", Offset = "0xA28500", VA = "0x180A29500")]
	public SceneCapture()
	{
	}

	// Token: 0x040025E9 RID: 9705
	[Token(Token = "0x40025E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RenderTexture evidenceRenderTexturePrefab;

	// Token: 0x040025EA RID: 9706
	[Token(Token = "0x40025EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RenderTexture surveillanceRenderTexturePrefab;

	// Token: 0x040025EB RID: 9707
	[Token(Token = "0x40025EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float evidenceFoV;

	// Token: 0x040025EC RID: 9708
	[Token(Token = "0x40025EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float surveillanceFov;

	// Token: 0x040025ED RID: 9709
	[Token(Token = "0x40025ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[NonSerialized]
	public SceneRecorder.SceneCapture currrentlyViewing;

	// Token: 0x040025EE RID: 9710
	[Token(Token = "0x40025EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int maxEvidenceCache;

	// Token: 0x040025EF RID: 9711
	[Token(Token = "0x40025EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int cachedEvidencePhotos;

	// Token: 0x040025F0 RID: 9712
	[Token(Token = "0x40025F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Dictionary<Evidence, SceneCapture.PhotoCache> cachedRenders;

	// Token: 0x040025F1 RID: 9713
	[Token(Token = "0x40025F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Color lastCentrePixel;

	// Token: 0x040025F2 RID: 9714
	[Token(Token = "0x40025F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int maxSurveillanceCache;

	// Token: 0x040025F3 RID: 9715
	[Token(Token = "0x40025F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int cachedSurveillancePhotos;

	// Token: 0x040025F4 RID: 9716
	[Token(Token = "0x40025F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Dictionary<SceneRecorder.SceneCapture, SceneCapture.PhotoCache> cachedSurveillance;

	// Token: 0x040025F5 RID: 9717
	[Token(Token = "0x40025F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject photoRoomParent;

	// Token: 0x040025F6 RID: 9718
	[Token(Token = "0x40025F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform cameraTransform;

	// Token: 0x040025F7 RID: 9719
	[Token(Token = "0x40025F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform itemTransform;

	// Token: 0x040025F8 RID: 9720
	[Token(Token = "0x40025F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SceneCapture _instance;

	// Token: 0x02000546 RID: 1350
	[Token(Token = "0x2000546")]
	[Serializable]
	public class PhotoCache
	{
		// Token: 0x06001D67 RID: 7527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D67")]
		[Address(RVA = "0xA296F0", Offset = "0xA286F0", VA = "0x180A296F0")]
		public void Remove()
		{
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D68")]
		[Address(RVA = "0xA29860", Offset = "0xA28860", VA = "0x180A29860")]
		public PhotoCache()
		{
		}

		// Token: 0x040025F9 RID: 9721
		[Token(Token = "0x40025F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D img;

		// Token: 0x040025FA RID: 9722
		[Token(Token = "0x40025FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float lastUsed;

		// Token: 0x040025FB RID: 9723
		[Token(Token = "0x40025FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SceneCapture.ActorScreenPosition> actorSP;
	}

	// Token: 0x02000547 RID: 1351
	[Token(Token = "0x2000547")]
	[Serializable]
	public class PhotoSaveToDisk
	{
		// Token: 0x06001D69 RID: 7529 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001D69")]
		[Address(RVA = "0xA29920", Offset = "0xA28920", VA = "0x180A29920")]
		public Texture2D GetImage()
		{
			return null;
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6A")]
		[Address(RVA = "0xA29AD0", Offset = "0xA28AD0", VA = "0x180A29AD0")]
		public PhotoSaveToDisk()
		{
		}

		// Token: 0x040025FC RID: 9724
		[Token(Token = "0x40025FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] data;

		// Token: 0x040025FD RID: 9725
		[Token(Token = "0x40025FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D img;

		// Token: 0x040025FE RID: 9726
		[Token(Token = "0x40025FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float lastUsed;

		// Token: 0x040025FF RID: 9727
		[Token(Token = "0x40025FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<SceneCapture.ActorScreenPosition> actorSP;

		// Token: 0x04002600 RID: 9728
		[Token(Token = "0x4002600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool readOnly;
	}

	// Token: 0x02000548 RID: 1352
	[Token(Token = "0x2000548")]
	[Serializable]
	public class PhotoCacheLinking
	{
		// Token: 0x06001D6B RID: 7531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6B")]
		[Address(RVA = "0xA29B90", Offset = "0xA28B90", VA = "0x180A29B90")]
		public PhotoCacheLinking()
		{
		}

		// Token: 0x04002601 RID: 9729
		[Token(Token = "0x4002601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<string> usedInSaveFiles;
	}

	// Token: 0x02000549 RID: 1353
	[Token(Token = "0x2000549")]
	public struct ActorScreenPosition
	{
		// Token: 0x04002602 RID: 9730
		[Token(Token = "0x4002602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Human human;

		// Token: 0x04002603 RID: 9731
		[Token(Token = "0x4002603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 screenPoint;
	}

	// Token: 0x0200054A RID: 1354
	[Token(Token = "0x200054A")]
	public enum PostProcessingProfile
	{
		// Token: 0x04002605 RID: 9733
		[Token(Token = "0x4002605")]
		captureNormal,
		// Token: 0x04002606 RID: 9734
		[Token(Token = "0x4002606")]
		captureCCTV
	}

	// Token: 0x0200054B RID: 1355
	[Token(Token = "0x200054B")]
	private sealed class <>c__DisplayClass27_0
	{
		// Token: 0x06001D6C RID: 7532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass27_0()
		{
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
		[Token(Token = "0x6001D6D")]
		[Address(RVA = "0x526E20", Offset = "0x525E20", VA = "0x180526E20")]
		internal bool <GetSurveillanceScene>b__0(AirDuctGroup item)
		{
			return default(bool);
		}

		// Token: 0x04002607 RID: 9735
		[Token(Token = "0x4002607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SceneRecorder.SceneCapture scene;
	}
}
