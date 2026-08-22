using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000891 RID: 2193
[Token(Token = "0x2000891")]
public class StatusPreset : SoCustomComparison
{
	// Token: 0x06002A01 RID: 10753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A01")]
	[Address(RVA = "0xCB3BE0", Offset = "0xCB2BE0", VA = "0x180CB3BE0")]
	public StatusPreset()
	{
	}

	// Token: 0x04004339 RID: 17209
	[Token(Token = "0x4004339")]
	[FieldOffset(Offset = "0x20")]
	public Color color;

	// Token: 0x0400433A RID: 17210
	[Token(Token = "0x400433A")]
	[FieldOffset(Offset = "0x30")]
	public Color alternateColour;

	// Token: 0x0400433B RID: 17211
	[Token(Token = "0x400433B")]
	[FieldOffset(Offset = "0x40")]
	public Sprite icon;

	// Token: 0x0400433C RID: 17212
	[Token(Token = "0x400433C")]
	[FieldOffset(Offset = "0x48")]
	public Sprite alternateIcon;

	// Token: 0x0400433D RID: 17213
	[Token(Token = "0x400433D")]
	[FieldOffset(Offset = "0x50")]
	public bool minimizeToIcon;

	// Token: 0x0400433E RID: 17214
	[Token(Token = "0x400433E")]
	[FieldOffset(Offset = "0x51")]
	public bool pulseBackground;

	// Token: 0x0400433F RID: 17215
	[Token(Token = "0x400433F")]
	[FieldOffset(Offset = "0x52")]
	public bool pulseIcon;

	// Token: 0x04004340 RID: 17216
	[Token(Token = "0x4004340")]
	[FieldOffset(Offset = "0x54")]
	public Color pulseIconAdditiveColour;

	// Token: 0x04004341 RID: 17217
	[Token(Token = "0x4004341")]
	[FieldOffset(Offset = "0x64")]
	public bool includeDescription;

	// Token: 0x04004342 RID: 17218
	[Token(Token = "0x4004342")]
	[FieldOffset(Offset = "0x65")]
	public bool autoNotificationMessage;

	// Token: 0x04004343 RID: 17219
	[Token(Token = "0x4004343")]
	[FieldOffset(Offset = "0x68")]
	public int priority;

	// Token: 0x04004344 RID: 17220
	[Token(Token = "0x4004344")]
	[FieldOffset(Offset = "0x6C")]
	public bool fadeToWhite;

	// Token: 0x04004345 RID: 17221
	[Token(Token = "0x4004345")]
	[FieldOffset(Offset = "0x6D")]
	public bool enableProgressBar;

	// Token: 0x04004346 RID: 17222
	[Token(Token = "0x4004346")]
	[FieldOffset(Offset = "0x70")]
	public StatusPreset.ProgressBarTrack barTracking;

	// Token: 0x04004347 RID: 17223
	[Token(Token = "0x4004347")]
	[FieldOffset(Offset = "0x74")]
	public bool useCustomMethod;

	// Token: 0x04004348 RID: 17224
	[Token(Token = "0x4004348")]
	[FieldOffset(Offset = "0x78")]
	public AudioEvent onAcquire;

	// Token: 0x04004349 RID: 17225
	[Token(Token = "0x4004349")]
	[FieldOffset(Offset = "0x80")]
	public AudioEvent onRemove;

	// Token: 0x0400434A RID: 17226
	[Token(Token = "0x400434A")]
	[FieldOffset(Offset = "0x88")]
	public StatusPreset.StatusCountType countType;

	// Token: 0x0400434B RID: 17227
	[Token(Token = "0x400434B")]
	[FieldOffset(Offset = "0x8C")]
	public bool overrrideColorWithCount;

	// Token: 0x0400434C RID: 17228
	[Token(Token = "0x400434C")]
	[FieldOffset(Offset = "0x8D")]
	public bool displayCountCountsInMainText;

	// Token: 0x0400434D RID: 17229
	[Token(Token = "0x400434D")]
	[FieldOffset(Offset = "0x8E")]
	public bool replaceDescriptionBasedOnCounts;

	// Token: 0x0400434E RID: 17230
	[Token(Token = "0x400434E")]
	[FieldOffset(Offset = "0x8F")]
	public bool displayAddressInDetailText;

	// Token: 0x0400434F RID: 17231
	[Token(Token = "0x400434F")]
	[FieldOffset(Offset = "0x90")]
	public bool displayBuildingInDetailText;

	// Token: 0x04004350 RID: 17232
	[Token(Token = "0x4004350")]
	[FieldOffset(Offset = "0x91")]
	public bool listCountsInDetailText;

	// Token: 0x04004351 RID: 17233
	[Token(Token = "0x4004351")]
	[FieldOffset(Offset = "0x92")]
	public bool displayFineTotalInMainText;

	// Token: 0x04004352 RID: 17234
	[Token(Token = "0x4004352")]
	[FieldOffset(Offset = "0x93")]
	public bool alertWhenNewCountIsAdded;

	// Token: 0x04004353 RID: 17235
	[Token(Token = "0x4004353")]
	[FieldOffset(Offset = "0x94")]
	public bool displayTotalFineWhenMinimized;

	// Token: 0x04004354 RID: 17236
	[Token(Token = "0x4004354")]
	[FieldOffset(Offset = "0x98")]
	public List<StatusPreset.StatusCountConfig> countConfig;

	// Token: 0x04004355 RID: 17237
	[Token(Token = "0x4004355")]
	[FieldOffset(Offset = "0xA0")]
	public bool stopsRecovery;

	// Token: 0x04004356 RID: 17238
	[Token(Token = "0x4004356")]
	[FieldOffset(Offset = "0xA1")]
	public bool stopsSprint;

	// Token: 0x04004357 RID: 17239
	[Token(Token = "0x4004357")]
	[FieldOffset(Offset = "0xA2")]
	public bool stopsJump;

	// Token: 0x04004358 RID: 17240
	[Token(Token = "0x4004358")]
	[FieldOffset(Offset = "0xA4")]
	public float recoveryRatePlusMP;

	// Token: 0x04004359 RID: 17241
	[Token(Token = "0x4004359")]
	[FieldOffset(Offset = "0xA8")]
	public float maxHealthPlusMP;

	// Token: 0x0400435A RID: 17242
	[Token(Token = "0x400435A")]
	[FieldOffset(Offset = "0xAC")]
	public float movementSpeedPlusMP;

	// Token: 0x0400435B RID: 17243
	[Token(Token = "0x400435B")]
	[FieldOffset(Offset = "0xB0")]
	public float temperatureGainPlusMP;

	// Token: 0x0400435C RID: 17244
	[Token(Token = "0x400435C")]
	[FieldOffset(Offset = "0xB4")]
	public float damageIncomingPlusMP;

	// Token: 0x0400435D RID: 17245
	[Token(Token = "0x400435D")]
	[FieldOffset(Offset = "0xB8")]
	public float damageOutgoingPlusMP;

	// Token: 0x0400435E RID: 17246
	[Token(Token = "0x400435E")]
	[FieldOffset(Offset = "0xBC")]
	public float drunkControls;

	// Token: 0x0400435F RID: 17247
	[Token(Token = "0x400435F")]
	[FieldOffset(Offset = "0xC0")]
	public float tripChanceWet;

	// Token: 0x04004360 RID: 17248
	[Token(Token = "0x4004360")]
	[FieldOffset(Offset = "0xC4")]
	public float tripChanceDrunk;

	// Token: 0x04004361 RID: 17249
	[Token(Token = "0x4004361")]
	[FieldOffset(Offset = "0xC8")]
	public float affectHeadBob;

	// Token: 0x04004362 RID: 17250
	[Token(Token = "0x4004362")]
	[FieldOffset(Offset = "0xD0")]
	public AnimationCurve headBob;

	// Token: 0x04004363 RID: 17251
	[Token(Token = "0x4004363")]
	[FieldOffset(Offset = "0xD8")]
	public float drunkVision;

	// Token: 0x04004364 RID: 17252
	[Token(Token = "0x4004364")]
	[FieldOffset(Offset = "0xDC")]
	public float shiverVision;

	// Token: 0x04004365 RID: 17253
	[Token(Token = "0x4004365")]
	[FieldOffset(Offset = "0xE0")]
	public float drunkLensDistort;

	// Token: 0x04004366 RID: 17254
	[Token(Token = "0x4004366")]
	[FieldOffset(Offset = "0xE4")]
	public float headacheVision;

	// Token: 0x04004367 RID: 17255
	[Token(Token = "0x4004367")]
	[FieldOffset(Offset = "0xE8")]
	public float bloomIntensityPlusMP;

	// Token: 0x04004368 RID: 17256
	[Token(Token = "0x4004368")]
	[FieldOffset(Offset = "0xEC")]
	public float motionBlurPlusMP;

	// Token: 0x04004369 RID: 17257
	[Token(Token = "0x4004369")]
	[FieldOffset(Offset = "0xF0")]
	public float chromaticAbberationAmount;

	// Token: 0x0400436A RID: 17258
	[Token(Token = "0x400436A")]
	[FieldOffset(Offset = "0xF4")]
	public float vignetteAmount;

	// Token: 0x0400436B RID: 17259
	[Token(Token = "0x400436B")]
	[FieldOffset(Offset = "0xF8")]
	public float expsosure;

	// Token: 0x0400436C RID: 17260
	[Token(Token = "0x400436C")]
	[FieldOffset(Offset = "0xFC")]
	public bool useChannelMixer;

	// Token: 0x0400436D RID: 17261
	[Token(Token = "0x400436D")]
	[FieldOffset(Offset = "0x100")]
	public int redR;

	// Token: 0x0400436E RID: 17262
	[Token(Token = "0x400436E")]
	[FieldOffset(Offset = "0x104")]
	public int redG;

	// Token: 0x0400436F RID: 17263
	[Token(Token = "0x400436F")]
	[FieldOffset(Offset = "0x108")]
	public int redB;

	// Token: 0x04004370 RID: 17264
	[Token(Token = "0x4004370")]
	[FieldOffset(Offset = "0x10C")]
	public int greenR;

	// Token: 0x04004371 RID: 17265
	[Token(Token = "0x4004371")]
	[FieldOffset(Offset = "0x110")]
	public int greenG;

	// Token: 0x04004372 RID: 17266
	[Token(Token = "0x4004372")]
	[FieldOffset(Offset = "0x114")]
	public int greenB;

	// Token: 0x04004373 RID: 17267
	[Token(Token = "0x4004373")]
	[FieldOffset(Offset = "0x118")]
	public int blueR;

	// Token: 0x04004374 RID: 17268
	[Token(Token = "0x4004374")]
	[FieldOffset(Offset = "0x11C")]
	public int blueG;

	// Token: 0x04004375 RID: 17269
	[Token(Token = "0x4004375")]
	[FieldOffset(Offset = "0x120")]
	public int blueB;

	// Token: 0x02000892 RID: 2194
	[Token(Token = "0x2000892")]
	public enum ProgressBarTrack
	{
		// Token: 0x04004377 RID: 17271
		[Token(Token = "0x4004377")]
		none,
		// Token: 0x04004378 RID: 17272
		[Token(Token = "0x4004378")]
		witnesses,
		// Token: 0x04004379 RID: 17273
		[Token(Token = "0x4004379")]
		wantedInBuilding,
		// Token: 0x0400437A RID: 17274
		[Token(Token = "0x400437A")]
		alarmTime,
		// Token: 0x0400437B RID: 17275
		[Token(Token = "0x400437B")]
		guestPassTime
	}

	// Token: 0x02000893 RID: 2195
	[Token(Token = "0x2000893")]
	public enum StatusCountType
	{
		// Token: 0x0400437D RID: 17277
		[Token(Token = "0x400437D")]
		none,
		// Token: 0x0400437E RID: 17278
		[Token(Token = "0x400437E")]
		crime
	}

	// Token: 0x02000894 RID: 2196
	[Token(Token = "0x2000894")]
	[Serializable]
	public class StatusCountConfig
	{
		// Token: 0x06002A02 RID: 10754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A02")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public StatusCountConfig()
		{
		}

		// Token: 0x0400437F RID: 17279
		[Token(Token = "0x400437F")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04004380 RID: 17280
		[Token(Token = "0x4004380")]
		[FieldOffset(Offset = "0x18")]
		public Sprite icon;

		// Token: 0x04004381 RID: 17281
		[Token(Token = "0x4004381")]
		[FieldOffset(Offset = "0x20")]
		public Color colour;

		// Token: 0x04004382 RID: 17282
		[Token(Token = "0x4004382")]
		[FieldOffset(Offset = "0x30")]
		public StatusPreset.PenaltyRule penaltyRule;

		// Token: 0x04004383 RID: 17283
		[Token(Token = "0x4004383")]
		[FieldOffset(Offset = "0x34")]
		public float penalty;

		// Token: 0x04004384 RID: 17284
		[Token(Token = "0x4004384")]
		[FieldOffset(Offset = "0x38")]
		public AudioEvent onAcquire;
	}

	// Token: 0x02000895 RID: 2197
	[Token(Token = "0x2000895")]
	public enum PenaltyRule
	{
		// Token: 0x04004386 RID: 17286
		[Token(Token = "0x4004386")]
		fixedValue,
		// Token: 0x04004387 RID: 17287
		[Token(Token = "0x4004387")]
		percentageValue,
		// Token: 0x04004388 RID: 17288
		[Token(Token = "0x4004388")]
		objectValueMultiplied
	}
}
