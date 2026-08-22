using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007B9 RID: 1977
[Token(Token = "0x20007B9")]
public class CutScenePreset : SoCustomComparison
{
	// Token: 0x0600294C RID: 10572 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600294C")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void RecordCurrentPositionToNewShot()
	{
	}

	// Token: 0x0600294D RID: 10573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600294D")]
	[Address(RVA = "0xCA2FE0", Offset = "0xCA1FE0", VA = "0x180CA2FE0")]
	public CutScenePreset()
	{
	}

	// Token: 0x040038EB RID: 14571
	[Token(Token = "0x40038EB")]
	[FieldOffset(Offset = "0x20")]
	public List<CutScenePreset.CutSceneElement> elementList;

	// Token: 0x040038EC RID: 14572
	[Token(Token = "0x40038EC")]
	[FieldOffset(Offset = "0x28")]
	public bool fadeIn;

	// Token: 0x040038ED RID: 14573
	[Token(Token = "0x40038ED")]
	[FieldOffset(Offset = "0x2C")]
	public float fadeInTime;

	// Token: 0x040038EE RID: 14574
	[Token(Token = "0x40038EE")]
	[FieldOffset(Offset = "0x30")]
	public bool fadeOut;

	// Token: 0x040038EF RID: 14575
	[Token(Token = "0x40038EF")]
	[FieldOffset(Offset = "0x34")]
	public float fadeOutTime;

	// Token: 0x040038F0 RID: 14576
	[Token(Token = "0x40038F0")]
	[FieldOffset(Offset = "0x38")]
	public Sprite displayImage;

	// Token: 0x040038F1 RID: 14577
	[Token(Token = "0x40038F1")]
	[FieldOffset(Offset = "0x40")]
	public float imageFadeIn;

	// Token: 0x040038F2 RID: 14578
	[Token(Token = "0x40038F2")]
	[FieldOffset(Offset = "0x44")]
	public float imageFadeInSpeed;

	// Token: 0x040038F3 RID: 14579
	[Token(Token = "0x40038F3")]
	[FieldOffset(Offset = "0x48")]
	public float imageFadeOut;

	// Token: 0x040038F4 RID: 14580
	[Token(Token = "0x40038F4")]
	[FieldOffset(Offset = "0x4C")]
	public float imageFadeOutSpeed;

	// Token: 0x040038F5 RID: 14581
	[Token(Token = "0x40038F5")]
	[FieldOffset(Offset = "0x50")]
	public bool disableAISpeech;

	// Token: 0x040038F6 RID: 14582
	[Token(Token = "0x40038F6")]
	[FieldOffset(Offset = "0x54")]
	public CutScenePreset.OnEndScene onEnd;

	// Token: 0x020007BA RID: 1978
	[Token(Token = "0x20007BA")]
	[Serializable]
	public class CutSceneElement
	{
		// Token: 0x0600294E RID: 10574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600294E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public CutSceneElement()
		{
		}

		// Token: 0x040038F7 RID: 14583
		[Token(Token = "0x40038F7")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040038F8 RID: 14584
		[Token(Token = "0x40038F8")]
		[FieldOffset(Offset = "0x18")]
		public bool disable;

		// Token: 0x040038F9 RID: 14585
		[Token(Token = "0x40038F9")]
		[FieldOffset(Offset = "0x1C")]
		public CutScenePreset.ElementType elementType;

		// Token: 0x040038FA RID: 14586
		[Token(Token = "0x40038FA")]
		[FieldOffset(Offset = "0x20")]
		public List<CutScenePreset.CameraMovement> movement;

		// Token: 0x040038FB RID: 14587
		[Token(Token = "0x40038FB")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve lerpPositionGraph;

		// Token: 0x040038FC RID: 14588
		[Token(Token = "0x40038FC")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve lerpRotationGraph;

		// Token: 0x040038FD RID: 14589
		[Token(Token = "0x40038FD")]
		[FieldOffset(Offset = "0x38")]
		public string ddsMessage;

		// Token: 0x040038FE RID: 14590
		[Token(Token = "0x40038FE")]
		[FieldOffset(Offset = "0x40")]
		public float messageDelay;
	}

	// Token: 0x020007BB RID: 1979
	[Token(Token = "0x20007BB")]
	public enum ElementType
	{
		// Token: 0x04003900 RID: 14592
		[Token(Token = "0x4003900")]
		newShot,
		// Token: 0x04003901 RID: 14593
		[Token(Token = "0x4003901")]
		ddsMessage
	}

	// Token: 0x020007BC RID: 1980
	[Token(Token = "0x20007BC")]
	public enum OnEndScene
	{
		// Token: 0x04003903 RID: 14595
		[Token(Token = "0x4003903")]
		resumeGameplay,
		// Token: 0x04003904 RID: 14596
		[Token(Token = "0x4003904")]
		startGame,
		// Token: 0x04003905 RID: 14597
		[Token(Token = "0x4003905")]
		endGame
	}

	// Token: 0x020007BD RID: 1981
	[Token(Token = "0x20007BD")]
	public enum AnchorType
	{
		// Token: 0x04003907 RID: 14599
		[Token(Token = "0x4003907")]
		blockCorner,
		// Token: 0x04003908 RID: 14600
		[Token(Token = "0x4003908")]
		middle
	}

	// Token: 0x020007BE RID: 1982
	[Token(Token = "0x20007BE")]
	[Serializable]
	public class CameraMovement
	{
		// Token: 0x0600294F RID: 10575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600294F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public CameraMovement()
		{
		}

		// Token: 0x04003909 RID: 14601
		[Token(Token = "0x4003909")]
		[FieldOffset(Offset = "0x10")]
		public float atDuration;

		// Token: 0x0400390A RID: 14602
		[Token(Token = "0x400390A")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 camPos;

		// Token: 0x0400390B RID: 14603
		[Token(Token = "0x400390B")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 camEuler;

		// Token: 0x0400390C RID: 14604
		[Token(Token = "0x400390C")]
		[FieldOffset(Offset = "0x2C")]
		public CutScenePreset.AnchorType anchor;

		// Token: 0x0400390D RID: 14605
		[Token(Token = "0x400390D")]
		[FieldOffset(Offset = "0x30")]
		public bool overridePosGraph;

		// Token: 0x0400390E RID: 14606
		[Token(Token = "0x400390E")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve lerpPositionGraphOverride;

		// Token: 0x0400390F RID: 14607
		[Token(Token = "0x400390F")]
		[FieldOffset(Offset = "0x40")]
		public bool overrideRotGraph;

		// Token: 0x04003910 RID: 14608
		[Token(Token = "0x4003910")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve lerpRotationGraphOverride;
	}
}
