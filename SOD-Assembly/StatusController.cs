using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000662 RID: 1634
[Token(Token = "0x2000662")]
public class StatusController : MonoBehaviour
{
	// Token: 0x17000129 RID: 297
	// (get) Token: 0x06002415 RID: 9237 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000129")]
	public static StatusController Instance
	{
		[Token(Token = "0x6002415")]
		[Address(RVA = "0xB80090", Offset = "0xB7F090", VA = "0x180B80090")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002416 RID: 9238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002416")]
	[Address(RVA = "0xB800D0", Offset = "0xB7F0D0", VA = "0x180B800D0")]
	private void Awake()
	{
	}

	// Token: 0x06002417 RID: 9239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002417")]
	[Address(RVA = "0xB80420", Offset = "0xB7F420", VA = "0x180B80420")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002418 RID: 9240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002418")]
	[Address(RVA = "0xB80630", Offset = "0xB7F630", VA = "0x180B80630")]
	private void Start()
	{
	}

	// Token: 0x06002419 RID: 9241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002419")]
	[Address(RVA = "0xB80D50", Offset = "0xB7FD50", VA = "0x180B80D50")]
	private void DisplayCheck()
	{
	}

	// Token: 0x0600241A RID: 9242 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600241A")]
	[Address(RVA = "0xB81070", Offset = "0xB80070", VA = "0x180B81070")]
	public void RemoveAllCounts(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x0600241B RID: 9243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600241B")]
	[Address(RVA = "0xB81570", Offset = "0xB80570", VA = "0x180B81570")]
	public void RemoveAllCounts(StatusPreset preset)
	{
	}

	// Token: 0x0600241C RID: 9244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600241C")]
	[Address(RVA = "0xB81CC0", Offset = "0xB80CC0", VA = "0x180B81CC0")]
	public void ForceStatusCheck()
	{
	}

	// Token: 0x0600241D RID: 9245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600241D")]
	[Address(RVA = "0xB81CD0", Offset = "0xB80CD0", VA = "0x180B81CD0")]
	public void ForceStatusCheck(bool bypassKOCheck = false)
	{
	}

	// Token: 0x0600241E RID: 9246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600241E")]
	[Address(RVA = "0xB844E0", Offset = "0xB834E0", VA = "0x180B844E0")]
	private void Update()
	{
	}

	// Token: 0x0600241F RID: 9247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600241F")]
	[Address(RVA = "0xB85930", Offset = "0xB84930", VA = "0x180B85930")]
	public void AddFineRecord(NewAddress address, Interactable obj, StatusController.CrimeType crime, bool confirm = false, int forcedPenalty = -1, bool ignoreDuplicates = false)
	{
	}

	// Token: 0x06002420 RID: 9248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002420")]
	[Address(RVA = "0xB86360", Offset = "0xB85360", VA = "0x180B86360")]
	public void RemoveFineRecord(NewAddress address, Interactable obj, StatusController.CrimeType crime, bool onlyUnconfirmed = false, bool matchAddress = true)
	{
	}

	// Token: 0x06002421 RID: 9249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002421")]
	[Address(RVA = "0xB86550", Offset = "0xB85550", VA = "0x180B86550")]
	public void FineEscapeCheck()
	{
	}

	// Token: 0x06002422 RID: 9250 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002422")]
	[Address(RVA = "0xB86B00", Offset = "0xB85B00", VA = "0x180B86B00")]
	public void SetWantedInBuilding(NewBuilding b, float time)
	{
	}

	// Token: 0x06002423 RID: 9251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002423")]
	[Address(RVA = "0xB86C30", Offset = "0xB85C30", VA = "0x180B86C30")]
	public void SetDetainedInBuilding(NewBuilding b, bool val)
	{
	}

	// Token: 0x06002424 RID: 9252 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
	[Token(Token = "0x6002424")]
	[Address(RVA = "0xB870E0", Offset = "0xB860E0", VA = "0x180B870E0")]
	public bool GetCurrentDetainedStatus()
	{
		return default(bool);
	}

	// Token: 0x06002425 RID: 9253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002425")]
	[Address(RVA = "0xB875C0", Offset = "0xB865C0", VA = "0x180B875C0")]
	public void ConfirmFinesAtLocation(NewAddress address, StatusController.CrimeType crime)
	{
	}

	// Token: 0x06002426 RID: 9254 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002426")]
	[Address(RVA = "0xB87910", Offset = "0xB86910", VA = "0x180B87910")]
	public void ConfirmFine(NewAddress address, Interactable obj, StatusController.CrimeType crime)
	{
	}

	// Token: 0x06002427 RID: 9255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002427")]
	[Address(RVA = "0xB87B10", Offset = "0xB86B10", VA = "0x180B87B10")]
	public void PayActiveFines()
	{
	}

	// Token: 0x06002428 RID: 9256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002428")]
	[Address(RVA = "0xB88400", Offset = "0xB87400", VA = "0x180B88400")]
	public void Trespassing(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002429 RID: 9257 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002429")]
	[Address(RVA = "0xB88B40", Offset = "0xB87B40", VA = "0x180B88B40")]
	public void AlarmActive(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x0600242A RID: 9258 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600242A")]
	[Address(RVA = "0xB890D0", Offset = "0xB880D0", VA = "0x180B890D0")]
	public void IllegalAction(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x0600242B RID: 9259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600242B")]
	[Address(RVA = "0xB891C0", Offset = "0xB881C0", VA = "0x180B891C0")]
	public void CaptureRisk(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x0600242C RID: 9260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600242C")]
	[Address(RVA = "0xB89DA0", Offset = "0xB88DA0", VA = "0x180B89DA0")]
	public void ImageCaptured(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x0600242D RID: 9261 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600242D")]
	[Address(RVA = "0xB89FF0", Offset = "0xB88FF0", VA = "0x180B89FF0")]
	public void Wanted(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x0600242E RID: 9262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600242E")]
	[Address(RVA = "0xB8A420", Offset = "0xB89420", VA = "0x180B8A420")]
	public void GuestPass(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x0600242F RID: 9263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600242F")]
	[Address(RVA = "0xB8A940", Offset = "0xB89940", VA = "0x180B8A940")]
	public void Detained(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002430 RID: 9264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002430")]
	[Address(RVA = "0xB8AD80", Offset = "0xB89D80", VA = "0x180B8AD80")]
	public void Echelons(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002431 RID: 9265 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002431")]
	[Address(RVA = "0xB8B260", Offset = "0xB8A260", VA = "0x180B8B260")]
	public void Hiding(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002432 RID: 9266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002432")]
	[Address(RVA = "0xB8B450", Offset = "0xB8A450", VA = "0x180B8B450")]
	public void Stinky(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002433 RID: 9267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002433")]
	[Address(RVA = "0xB8B8D0", Offset = "0xB8A8D0", VA = "0x180B8B8D0")]
	public void Cold(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002434 RID: 9268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002434")]
	[Address(RVA = "0xB8BD40", Offset = "0xB8AD40", VA = "0x180B8BD40")]
	public void Hungry(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002435 RID: 9269 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002435")]
	[Address(RVA = "0xB8C020", Offset = "0xB8B020", VA = "0x180B8C020")]
	public void Energized(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002436 RID: 9270 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002436")]
	[Address(RVA = "0xB8C2E0", Offset = "0xB8B2E0", VA = "0x180B8C2E0")]
	public void Thirsty(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002437 RID: 9271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002437")]
	[Address(RVA = "0xB8C5C0", Offset = "0xB8B5C0", VA = "0x180B8C5C0")]
	public void Hydrated(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002438 RID: 9272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002438")]
	[Address(RVA = "0xB8C880", Offset = "0xB8B880", VA = "0x180B8C880")]
	public void Drunk(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002439 RID: 9273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002439")]
	[Address(RVA = "0xB8CB40", Offset = "0xB8BB40", VA = "0x180B8CB40")]
	public void Sick(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x0600243A RID: 9274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600243A")]
	[Address(RVA = "0xB8CF40", Offset = "0xB8BF40", VA = "0x180B8CF40")]
	public void StarchAddiction(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x0600243B RID: 9275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600243B")]
	[Address(RVA = "0xB8D200", Offset = "0xB8C200", VA = "0x180B8D200")]
	public void Headache(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x0600243C RID: 9276 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600243C")]
	[Address(RVA = "0xB8D4C0", Offset = "0xB8C4C0", VA = "0x180B8D4C0")]
	public void Wet(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x0600243D RID: 9277 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600243D")]
	[Address(RVA = "0xB8D780", Offset = "0xB8C780", VA = "0x180B8D780")]
	public void BrokenLeg(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x0600243E RID: 9278 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600243E")]
	[Address(RVA = "0xB8DA30", Offset = "0xB8CA30", VA = "0x180B8DA30")]
	public void Bruised(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x0600243F RID: 9279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600243F")]
	[Address(RVA = "0xB8DCE0", Offset = "0xB8CCE0", VA = "0x180B8DCE0")]
	public void BlackEye(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002440 RID: 9280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002440")]
	[Address(RVA = "0xB8DF90", Offset = "0xB8CF90", VA = "0x180B8DF90")]
	public void BlackedOut(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002441 RID: 9281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002441")]
	[Address(RVA = "0xB8E1E0", Offset = "0xB8D1E0", VA = "0x180B8E1E0")]
	public void Numb(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002442 RID: 9282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002442")]
	[Address(RVA = "0xB8E4A0", Offset = "0xB8D4A0", VA = "0x180B8E4A0")]
	public void Poisoned(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002443 RID: 9283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002443")]
	[Address(RVA = "0xB8E750", Offset = "0xB8D750", VA = "0x180B8E750")]
	public void Blinded(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002444 RID: 9284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002444")]
	[Address(RVA = "0xB8EA00", Offset = "0xB8DA00", VA = "0x180B8EA00")]
	public void Bleeding(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002445 RID: 9285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002445")]
	[Address(RVA = "0xB8ECB0", Offset = "0xB8DCB0", VA = "0x180B8ECB0")]
	public void Tired(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002446 RID: 9286 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002446")]
	[Address(RVA = "0xB8F190", Offset = "0xB8E190", VA = "0x180B8F190")]
	public void Focused(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002447 RID: 9287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002447")]
	[Address(RVA = "0xB8F450", Offset = "0xB8E450", VA = "0x180B8F450")]
	public void Pursued(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002448 RID: 9288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002448")]
	[Address(RVA = "0xB8F650", Offset = "0xB8E650", VA = "0x180B8F650")]
	public void WellRested(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x06002449 RID: 9289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002449")]
	[Address(RVA = "0xB8F900", Offset = "0xB8E900", VA = "0x180B8F900")]
	public void SyncDiskInstall(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x0600244A RID: 9290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600244A")]
	[Address(RVA = "0xB8FB50", Offset = "0xB8EB50", VA = "0x180B8FB50")]
	public void ToxicGas(StatusController.StatusInstance inst)
	{
	}

	// Token: 0x0600244B RID: 9291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600244B")]
	[Address(RVA = "0xB8FDA0", Offset = "0xB8EDA0", VA = "0x180B8FDA0")]
	public StatusController()
	{
	}

	// Token: 0x04002E1A RID: 11802
	[Token(Token = "0x4002E1A")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform statusParent;

	// Token: 0x04002E1B RID: 11803
	[Token(Token = "0x4002E1B")]
	[FieldOffset(Offset = "0x20")]
	public float elementDefaultWdith;

	// Token: 0x04002E1C RID: 11804
	[Token(Token = "0x4002E1C")]
	[FieldOffset(Offset = "0x24")]
	public float elementMinimizedWidth;

	// Token: 0x04002E1D RID: 11805
	[Token(Token = "0x4002E1D")]
	[FieldOffset(Offset = "0x28")]
	public float elementDefaultHeight;

	// Token: 0x04002E1E RID: 11806
	[Token(Token = "0x4002E1E")]
	[FieldOffset(Offset = "0x2C")]
	public float elementYInterval;

	// Token: 0x04002E1F RID: 11807
	[Token(Token = "0x4002E1F")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve detailTextFadeInCurve;

	// Token: 0x04002E20 RID: 11808
	[Token(Token = "0x4002E20")]
	[FieldOffset(Offset = "0x38")]
	public bool disabledRecovery;

	// Token: 0x04002E21 RID: 11809
	[Token(Token = "0x4002E21")]
	[FieldOffset(Offset = "0x39")]
	public bool disabledSprint;

	// Token: 0x04002E22 RID: 11810
	[Token(Token = "0x4002E22")]
	[FieldOffset(Offset = "0x3A")]
	public bool disabledJump;

	// Token: 0x04002E23 RID: 11811
	[Token(Token = "0x4002E23")]
	[FieldOffset(Offset = "0x3C")]
	public float recoveryRateMultiplier;

	// Token: 0x04002E24 RID: 11812
	[Token(Token = "0x4002E24")]
	[FieldOffset(Offset = "0x40")]
	public float maxHealthMultiplier;

	// Token: 0x04002E25 RID: 11813
	[Token(Token = "0x4002E25")]
	[FieldOffset(Offset = "0x44")]
	public float movementSpeedMultiplier;

	// Token: 0x04002E26 RID: 11814
	[Token(Token = "0x4002E26")]
	[FieldOffset(Offset = "0x48")]
	public float temperatureGainMultiplier;

	// Token: 0x04002E27 RID: 11815
	[Token(Token = "0x4002E27")]
	[FieldOffset(Offset = "0x4C")]
	public float damageIncomingMultiplier;

	// Token: 0x04002E28 RID: 11816
	[Token(Token = "0x4002E28")]
	[FieldOffset(Offset = "0x50")]
	public float damageOutgoingMultiplier;

	// Token: 0x04002E29 RID: 11817
	[Token(Token = "0x4002E29")]
	[FieldOffset(Offset = "0x54")]
	public float drunkControls;

	// Token: 0x04002E2A RID: 11818
	[Token(Token = "0x4002E2A")]
	[FieldOffset(Offset = "0x58")]
	public Dictionary<AnimationCurve, float> affectHeadBobs;

	// Token: 0x04002E2B RID: 11819
	[Token(Token = "0x4002E2B")]
	[FieldOffset(Offset = "0x60")]
	public float drunkVision;

	// Token: 0x04002E2C RID: 11820
	[Token(Token = "0x4002E2C")]
	[FieldOffset(Offset = "0x64")]
	public float shiverVision;

	// Token: 0x04002E2D RID: 11821
	[Token(Token = "0x4002E2D")]
	[FieldOffset(Offset = "0x68")]
	public float headacheVision;

	// Token: 0x04002E2E RID: 11822
	[Token(Token = "0x4002E2E")]
	[FieldOffset(Offset = "0x6C")]
	public float drunkLensDistort;

	// Token: 0x04002E2F RID: 11823
	[Token(Token = "0x4002E2F")]
	[FieldOffset(Offset = "0x70")]
	public float tripChanceWet;

	// Token: 0x04002E30 RID: 11824
	[Token(Token = "0x4002E30")]
	[FieldOffset(Offset = "0x74")]
	public float tripChanceDrunk;

	// Token: 0x04002E31 RID: 11825
	[Token(Token = "0x4002E31")]
	[FieldOffset(Offset = "0x78")]
	public float bloomIntensityMultiplier;

	// Token: 0x04002E32 RID: 11826
	[Token(Token = "0x4002E32")]
	[FieldOffset(Offset = "0x7C")]
	public float motionBlurMultiplier;

	// Token: 0x04002E33 RID: 11827
	[Token(Token = "0x4002E33")]
	[FieldOffset(Offset = "0x80")]
	public float chromaticAbberationAmount;

	// Token: 0x04002E34 RID: 11828
	[Token(Token = "0x4002E34")]
	[FieldOffset(Offset = "0x84")]
	public float vignetteAmount;

	// Token: 0x04002E35 RID: 11829
	[Token(Token = "0x4002E35")]
	[FieldOffset(Offset = "0x88")]
	public float exposureAmount;

	// Token: 0x04002E36 RID: 11830
	[Token(Token = "0x4002E36")]
	[FieldOffset(Offset = "0x8C")]
	public float channelRedR;

	// Token: 0x04002E37 RID: 11831
	[Token(Token = "0x4002E37")]
	[FieldOffset(Offset = "0x90")]
	public float channelRedG;

	// Token: 0x04002E38 RID: 11832
	[Token(Token = "0x4002E38")]
	[FieldOffset(Offset = "0x94")]
	public float channelRedB;

	// Token: 0x04002E39 RID: 11833
	[Token(Token = "0x4002E39")]
	[FieldOffset(Offset = "0x98")]
	public float channelGreenR;

	// Token: 0x04002E3A RID: 11834
	[Token(Token = "0x4002E3A")]
	[FieldOffset(Offset = "0x9C")]
	public float channelGreenG;

	// Token: 0x04002E3B RID: 11835
	[Token(Token = "0x4002E3B")]
	[FieldOffset(Offset = "0xA0")]
	public float channelGreenB;

	// Token: 0x04002E3C RID: 11836
	[Token(Token = "0x4002E3C")]
	[FieldOffset(Offset = "0xA4")]
	public float channelBlueR;

	// Token: 0x04002E3D RID: 11837
	[Token(Token = "0x4002E3D")]
	[FieldOffset(Offset = "0xA8")]
	public float channelBlueG;

	// Token: 0x04002E3E RID: 11838
	[Token(Token = "0x4002E3E")]
	[FieldOffset(Offset = "0xAC")]
	public float channelBlueB;

	// Token: 0x04002E3F RID: 11839
	[Token(Token = "0x4002E3F")]
	[FieldOffset(Offset = "0xB0")]
	public List<StateElementController> spawnedControllers;

	// Token: 0x04002E40 RID: 11840
	[Token(Token = "0x4002E40")]
	[FieldOffset(Offset = "0xB8")]
	public Dictionary<StatusController.StatusInstance, List<StatusController.StatusCount>> activeStatusCounts;

	// Token: 0x04002E41 RID: 11841
	[Token(Token = "0x4002E41")]
	[FieldOffset(Offset = "0xC0")]
	public HashSet<StatusPreset> activeStatuses;

	// Token: 0x04002E42 RID: 11842
	[Token(Token = "0x4002E42")]
	[FieldOffset(Offset = "0xC8")]
	public List<StatusController.FineRecord> activeFineRecords;

	// Token: 0x04002E43 RID: 11843
	[Token(Token = "0x4002E43")]
	[FieldOffset(Offset = "0xD0")]
	private Dictionary<StatusPreset, MethodInfo> checkingRef;

	// Token: 0x04002E44 RID: 11844
	[Token(Token = "0x4002E44")]
	[FieldOffset(Offset = "0x0")]
	private static StatusController _instance;

	// Token: 0x02000663 RID: 1635
	[Token(Token = "0x2000663")]
	[Serializable]
	public class FineRecord
	{
		// Token: 0x0600244C RID: 9292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244C")]
		[Address(RVA = "0xB902D0", Offset = "0xB8F2D0", VA = "0x180B902D0")]
		public FineRecord(NewAddress ad, Interactable obj, StatusController.CrimeType newCrime)
		{
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244D")]
		[Address(RVA = "0xB90410", Offset = "0xB8F410", VA = "0x180B90410")]
		public void SetConfirmed(bool val)
		{
		}

		// Token: 0x04002E45 RID: 11845
		[Token(Token = "0x4002E45")]
		[FieldOffset(Offset = "0x10")]
		public int addressID;

		// Token: 0x04002E46 RID: 11846
		[Token(Token = "0x4002E46")]
		[FieldOffset(Offset = "0x14")]
		public int objectID;

		// Token: 0x04002E47 RID: 11847
		[Token(Token = "0x4002E47")]
		[FieldOffset(Offset = "0x18")]
		public StatusController.CrimeType crime;

		// Token: 0x04002E48 RID: 11848
		[Token(Token = "0x4002E48")]
		[FieldOffset(Offset = "0x1C")]
		public bool confirmed;

		// Token: 0x04002E49 RID: 11849
		[Token(Token = "0x4002E49")]
		[FieldOffset(Offset = "0x20")]
		public int forcedPenalty;
	}

	// Token: 0x02000664 RID: 1636
	[Token(Token = "0x2000664")]
	public enum CrimeType
	{
		// Token: 0x04002E4B RID: 11851
		[Token(Token = "0x4002E4B")]
		assault,
		// Token: 0x04002E4C RID: 11852
		[Token(Token = "0x4002E4C")]
		theft,
		// Token: 0x04002E4D RID: 11853
		[Token(Token = "0x4002E4D")]
		breakingAndEntering,
		// Token: 0x04002E4E RID: 11854
		[Token(Token = "0x4002E4E")]
		trespassing,
		// Token: 0x04002E4F RID: 11855
		[Token(Token = "0x4002E4F")]
		tampering,
		// Token: 0x04002E50 RID: 11856
		[Token(Token = "0x4002E50")]
		vandalism
	}

	// Token: 0x02000665 RID: 1637
	[Token(Token = "0x2000665")]
	public struct StatusInstance
	{
		// Token: 0x04002E51 RID: 11857
		[Token(Token = "0x4002E51")]
		[FieldOffset(Offset = "0x0")]
		public StatusPreset preset;

		// Token: 0x04002E52 RID: 11858
		[Token(Token = "0x4002E52")]
		[FieldOffset(Offset = "0x8")]
		public NewBuilding building;

		// Token: 0x04002E53 RID: 11859
		[Token(Token = "0x4002E53")]
		[FieldOffset(Offset = "0x10")]
		public NewAddress address;
	}

	// Token: 0x02000666 RID: 1638
	[Token(Token = "0x2000666")]
	public class StatusCount
	{
		// Token: 0x0600244E RID: 9294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244E")]
		[Address(RVA = "0xB90420", Offset = "0xB8F420", VA = "0x180B90420")]
		public StatusCount(StatusController.StatusInstance newInstance)
		{
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244F")]
		[Address(RVA = "0xB90F40", Offset = "0xB8FF40", VA = "0x180B90F40")]
		public StatusCount(StatusController.StatusInstance newInstance, StatusPreset.StatusCountConfig newConfig)
		{
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002450")]
		[Address(RVA = "0xB91A50", Offset = "0xB90A50", VA = "0x180B91A50")]
		public void Remove()
		{
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		[Token(Token = "0x6002451")]
		[Address(RVA = "0xB922E0", Offset = "0xB912E0", VA = "0x180B922E0")]
		public int GetPenaltyAmount()
		{
			return 0;
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		[Token(Token = "0x6002452")]
		[Address(RVA = "0xB92470", Offset = "0xB91470", VA = "0x180B92470")]
		private bool <.ctor>b__5_0(StateElementController item)
		{
			return default(bool);
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
		[Token(Token = "0x6002453")]
		[Address(RVA = "0xB927B0", Offset = "0xB917B0", VA = "0x180B927B0")]
		private bool <.ctor>b__6_0(StateElementController item)
		{
			return default(bool);
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x0000E808 File Offset: 0x0000CA08
		[Token(Token = "0x6002454")]
		[Address(RVA = "0xB92AF0", Offset = "0xB91AF0", VA = "0x180B92AF0")]
		private bool <Remove>b__7_0(StateElementController item)
		{
			return default(bool);
		}

		// Token: 0x04002E54 RID: 11860
		[Token(Token = "0x4002E54")]
		[FieldOffset(Offset = "0x10")]
		public StatusController.StatusInstance statusInstance;

		// Token: 0x04002E55 RID: 11861
		[Token(Token = "0x4002E55")]
		[FieldOffset(Offset = "0x28")]
		public StatusPreset preset;

		// Token: 0x04002E56 RID: 11862
		[Token(Token = "0x4002E56")]
		[FieldOffset(Offset = "0x30")]
		public StatusPreset.StatusCountConfig statusCountConfig;

		// Token: 0x04002E57 RID: 11863
		[Token(Token = "0x4002E57")]
		[FieldOffset(Offset = "0x38")]
		public StatusController.FineRecord fineRecord;

		// Token: 0x04002E58 RID: 11864
		[Token(Token = "0x4002E58")]
		[FieldOffset(Offset = "0x40")]
		public float amount;
	}

	// Token: 0x02000667 RID: 1639
	[Token(Token = "0x2000667")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002456 RID: 9302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002456")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x0000E820 File Offset: 0x0000CA20
		[Token(Token = "0x6002457")]
		[Address(RVA = "0xB92EE0", Offset = "0xB91EE0", VA = "0x180B92EE0")]
		internal int <Start>b__51_0(StatusPreset p2, StatusPreset p1)
		{
			return 0;
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x0000E838 File Offset: 0x0000CA38
		[Token(Token = "0x6002458")]
		[Address(RVA = "0xB92F20", Offset = "0xB91F20", VA = "0x180B92F20")]
		internal int <ForceStatusCheck>b__56_0(StateElementController p2, StateElementController p1)
		{
			return 0;
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x0000E850 File Offset: 0x0000CA50
		[Token(Token = "0x6002459")]
		[Address(RVA = "0xB92F20", Offset = "0xB91F20", VA = "0x180B92F20")]
		internal int <Update>b__57_0(StateElementController p2, StateElementController p1)
		{
			return 0;
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x0000E868 File Offset: 0x0000CA68
		[Token(Token = "0x600245A")]
		[Address(RVA = "0xB92F70", Offset = "0xB91F70", VA = "0x180B92F70")]
		internal bool <Trespassing>b__67_1(StatusController.FineRecord item)
		{
			return default(bool);
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x0000E880 File Offset: 0x0000CA80
		[Token(Token = "0x600245B")]
		[Address(RVA = "0xB92FF0", Offset = "0xB91FF0", VA = "0x180B92FF0")]
		internal bool <Trespassing>b__67_0(StatusController.FineRecord item)
		{
			return default(bool);
		}

		// Token: 0x04002E59 RID: 11865
		[Token(Token = "0x4002E59")]
		[FieldOffset(Offset = "0x0")]
		public static readonly StatusController.<>c <>9;

		// Token: 0x04002E5A RID: 11866
		[Token(Token = "0x4002E5A")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<StatusPreset> <>9__51_0;

		// Token: 0x04002E5B RID: 11867
		[Token(Token = "0x4002E5B")]
		[FieldOffset(Offset = "0x10")]
		public static Comparison<StateElementController> <>9__56_0;

		// Token: 0x04002E5C RID: 11868
		[Token(Token = "0x4002E5C")]
		[FieldOffset(Offset = "0x18")]
		public static Comparison<StateElementController> <>9__57_0;

		// Token: 0x04002E5D RID: 11869
		[Token(Token = "0x4002E5D")]
		[FieldOffset(Offset = "0x20")]
		public static Predicate<StatusController.FineRecord> <>9__67_1;

		// Token: 0x04002E5E RID: 11870
		[Token(Token = "0x4002E5E")]
		[FieldOffset(Offset = "0x28")]
		public static Predicate<StatusController.FineRecord> <>9__67_0;
	}

	// Token: 0x02000668 RID: 1640
	[Token(Token = "0x2000668")]
	private sealed class <>c__DisplayClass58_0
	{
		// Token: 0x0600245C RID: 9308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass58_0()
		{
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x0000E898 File Offset: 0x0000CA98
		[Token(Token = "0x600245D")]
		[Address(RVA = "0xB93020", Offset = "0xB92020", VA = "0x180B93020")]
		internal bool <AddFineRecord>b__0(StatusController.FineRecord item)
		{
			return default(bool);
		}

		// Token: 0x04002E5F RID: 11871
		[Token(Token = "0x4002E5F")]
		[FieldOffset(Offset = "0x10")]
		public bool ignoreDuplicates;

		// Token: 0x04002E60 RID: 11872
		[Token(Token = "0x4002E60")]
		[FieldOffset(Offset = "0x18")]
		public NewAddress address;

		// Token: 0x04002E61 RID: 11873
		[Token(Token = "0x4002E61")]
		[FieldOffset(Offset = "0x20")]
		public StatusController.CrimeType crime;

		// Token: 0x04002E62 RID: 11874
		[Token(Token = "0x4002E62")]
		[FieldOffset(Offset = "0x28")]
		public Interactable obj;
	}

	// Token: 0x02000669 RID: 1641
	[Token(Token = "0x2000669")]
	private sealed class <>c__DisplayClass59_0
	{
		// Token: 0x0600245E RID: 9310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass59_0()
		{
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		[Token(Token = "0x600245F")]
		[Address(RVA = "0xB93280", Offset = "0xB92280", VA = "0x180B93280")]
		internal bool <RemoveFineRecord>b__0(StatusController.FineRecord item)
		{
			return default(bool);
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		[Token(Token = "0x6002460")]
		[Address(RVA = "0xB934E0", Offset = "0xB924E0", VA = "0x180B934E0")]
		internal bool <RemoveFineRecord>b__1(StatusController.FineRecord item)
		{
			return default(bool);
		}

		// Token: 0x04002E63 RID: 11875
		[Token(Token = "0x4002E63")]
		[FieldOffset(Offset = "0x10")]
		public bool matchAddress;

		// Token: 0x04002E64 RID: 11876
		[Token(Token = "0x4002E64")]
		[FieldOffset(Offset = "0x18")]
		public NewAddress address;

		// Token: 0x04002E65 RID: 11877
		[Token(Token = "0x4002E65")]
		[FieldOffset(Offset = "0x20")]
		public StatusController.CrimeType crime;

		// Token: 0x04002E66 RID: 11878
		[Token(Token = "0x4002E66")]
		[FieldOffset(Offset = "0x28")]
		public Interactable obj;
	}

	// Token: 0x0200066A RID: 1642
	[Token(Token = "0x200066A")]
	private sealed class <>c__DisplayClass64_0
	{
		// Token: 0x06002461 RID: 9313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002461")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass64_0()
		{
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		[Token(Token = "0x6002462")]
		[Address(RVA = "0xB93740", Offset = "0xB92740", VA = "0x180B93740")]
		internal bool <ConfirmFinesAtLocation>b__0(StatusController.FineRecord item)
		{
			return default(bool);
		}

		// Token: 0x04002E67 RID: 11879
		[Token(Token = "0x4002E67")]
		[FieldOffset(Offset = "0x10")]
		public NewAddress address;

		// Token: 0x04002E68 RID: 11880
		[Token(Token = "0x4002E68")]
		[FieldOffset(Offset = "0x18")]
		public StatusController.CrimeType crime;
	}

	// Token: 0x0200066B RID: 1643
	[Token(Token = "0x200066B")]
	private sealed class <>c__DisplayClass65_0
	{
		// Token: 0x06002463 RID: 9315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002463")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass65_0()
		{
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
		[Token(Token = "0x6002464")]
		[Address(RVA = "0xB93960", Offset = "0xB92960", VA = "0x180B93960")]
		internal bool <ConfirmFine>b__0(StatusController.FineRecord item)
		{
			return default(bool);
		}

		// Token: 0x04002E69 RID: 11881
		[Token(Token = "0x4002E69")]
		[FieldOffset(Offset = "0x10")]
		public NewAddress address;

		// Token: 0x04002E6A RID: 11882
		[Token(Token = "0x4002E6A")]
		[FieldOffset(Offset = "0x18")]
		public StatusController.CrimeType crime;

		// Token: 0x04002E6B RID: 11883
		[Token(Token = "0x4002E6B")]
		[FieldOffset(Offset = "0x20")]
		public Interactable obj;
	}

	// Token: 0x0200066C RID: 1644
	[Token(Token = "0x200066C")]
	private sealed class <>c__DisplayClass66_0
	{
		// Token: 0x06002465 RID: 9317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002465")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass66_0()
		{
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0000E910 File Offset: 0x0000CB10
		[Token(Token = "0x6002466")]
		[Address(RVA = "0xB93BC0", Offset = "0xB92BC0", VA = "0x180B93BC0")]
		internal bool <PayActiveFines>b__0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x04002E6C RID: 11884
		[Token(Token = "0x4002E6C")]
		[FieldOffset(Offset = "0x10")]
		public StatusController.StatusCount count;
	}

	// Token: 0x0200066D RID: 1645
	[Token(Token = "0x200066D")]
	private sealed class <>c__DisplayClass70_0
	{
		// Token: 0x06002467 RID: 9319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002467")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass70_0()
		{
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0000E928 File Offset: 0x0000CB28
		[Token(Token = "0x6002468")]
		[Address(RVA = "0xB93BF0", Offset = "0xB92BF0", VA = "0x180B93BF0")]
		internal bool <CaptureRisk>b__0(StatusPreset.StatusCountConfig item)
		{
			return default(bool);
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x0000E940 File Offset: 0x0000CB40
		[Token(Token = "0x6002469")]
		[Address(RVA = "0xB93CC0", Offset = "0xB92CC0", VA = "0x180B93CC0")]
		internal bool <CaptureRisk>b__1(StatusController.StatusCount item)
		{
			return default(bool);
		}

		// Token: 0x04002E6D RID: 11885
		[Token(Token = "0x4002E6D")]
		[FieldOffset(Offset = "0x10")]
		public StatusController.FineRecord f;
	}
}
