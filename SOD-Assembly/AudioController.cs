using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200025C RID: 604
[Token(Token = "0x200025C")]
public class AudioController : MonoBehaviour
{
	// Token: 0x17000074 RID: 116
	// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000074")]
	public static AudioController Instance
	{
		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x5EF9B0", Offset = "0x5EE9B0", VA = "0x1805EF9B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D9F")]
	[Address(RVA = "0x5EF9F0", Offset = "0x5EE9F0", VA = "0x1805EF9F0")]
	private void Awake()
	{
	}

	// Token: 0x06000DA0 RID: 3488 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA0")]
	[Address(RVA = "0x5EFF00", Offset = "0x5EEF00", VA = "0x1805EFF00")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000DA1 RID: 3489 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA1")]
	[Address(RVA = "0x5F0110", Offset = "0x5EF110", VA = "0x1805F0110")]
	private void Start()
	{
	}

	// Token: 0x06000DA2 RID: 3490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA2")]
	[Address(RVA = "0x5F0510", Offset = "0x5EF510", VA = "0x1805F0510")]
	public void UpdateMixing()
	{
	}

	// Token: 0x06000DA3 RID: 3491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA3")]
	[Address(RVA = "0x5F1580", Offset = "0x5F0580", VA = "0x1805F1580")]
	public void StartAmbienceTracks()
	{
	}

	// Token: 0x06000DA4 RID: 3492 RVA: 0x000073C8 File Offset: 0x000055C8
	[Token(Token = "0x6000DA4")]
	[Address(RVA = "0x5F1820", Offset = "0x5F0820", VA = "0x1805F1820")]
	public bool PlayWorldFootstep(AudioEvent eventPreset, Actor actor, bool rightFoot = false)
	{
		return default(bool);
	}

	// Token: 0x06000DA5 RID: 3493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA5")]
	[Address(RVA = "0x5F3340", Offset = "0x5F2340", VA = "0x1805F3340")]
	public void PlayerPlayerImpactSound(float fallCount)
	{
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x000073E0 File Offset: 0x000055E0
	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0x5F4210", Offset = "0x5F3210", VA = "0x1805F4210")]
	public EventInstance PlayWorldOneShot(AudioEvent eventPreset, Actor who, NewNode location, Vector3 worldPosition, [Optional] Interactable interactable, [Optional] List<AudioController.FMODParam> parameters, float volumeOverride = 1f, [Optional] List<NewNode> additionalSources, bool forceIgnoreOcclusion = false, [Optional] AudioController.SoundMaterialOverride surfaceData, bool forceSuspicious = false)
	{
		return default(EventInstance);
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0x5F6760", Offset = "0x5F5760", VA = "0x1805F6760")]
	public void PlayOneShotDelayed(float delay, AudioEvent eventPreset, Actor who, NewNode location, Vector3 worldPosition, [Optional] List<AudioController.FMODParam> parameters, float volumeOverride = 1f, [Optional] List<NewNode> additionalSources, bool forceIgnoreOcclusion = false)
	{
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DA8")]
	[Address(RVA = "0x5F6A30", Offset = "0x5F5A30", VA = "0x1805F6A30")]
	public AudioController.LoopingSoundInfo PlayWorldLooping(AudioEvent eventPreset, Actor who, Interactable interactable, [Optional] List<AudioController.FMODParam> parameters, float volumeOverride = 1f, bool forceSuspicious = false, [Optional] SessionData.TelevisionChannel isBroadcast, [Optional] InteractablePreset.IfSwitchStateSFX newSwitchInfo)
	{
		return null;
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DA9")]
	[Address(RVA = "0x5F6AC0", Offset = "0x5F5AC0", VA = "0x1805F6AC0")]
	public AudioController.LoopingSoundInfo PlayWorldLoopingStatic(AudioEvent eventPreset, Actor who, NewNode worldNode, Vector3 worldPos, [Optional] List<AudioController.FMODParam> parameters, float volumeOverride = 1f, bool forceSuspicious = false, [Optional] SessionData.TelevisionChannel isBroadcast, [Optional] InteractablePreset.IfSwitchStateSFX newSwitchInfo)
	{
		return null;
	}

	// Token: 0x06000DAA RID: 3498 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0x5F6B40", Offset = "0x5F5B40", VA = "0x1805F6B40")]
	public AudioController.LoopingSoundInfo PlayWorldLooping(AudioEvent eventPreset, Actor who, NewNode worldNode, Vector3 worldPosition, [Optional] Interactable interactable, [Optional] List<AudioController.FMODParam> parameters, float volumeOverride = 1f, bool forceSuspicious = false, [Optional] SessionData.TelevisionChannel isBroadcast, [Optional] InteractablePreset.IfSwitchStateSFX newSwitchInfo)
	{
		return null;
	}

	// Token: 0x06000DAB RID: 3499 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0x5F7320", Offset = "0x5F6320", VA = "0x1805F7320")]
	public AudioController.LoopingSoundInfo Play2DLooping(AudioEvent eventPreset, [Optional] List<AudioController.FMODParam> parameters, float volumeOverride = 1f)
	{
		return null;
	}

	// Token: 0x06000DAC RID: 3500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DAC")]
	[Address(RVA = "0x5F7A00", Offset = "0x5F6A00", VA = "0x1805F7A00")]
	public void UpdateAllLoopingSoundOcclusion()
	{
	}

	// Token: 0x06000DAD RID: 3501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DAD")]
	[Address(RVA = "0x5F7E10", Offset = "0x5F6E10", VA = "0x1805F7E10")]
	public void UpdateClosestWindowAndDoor(bool doorCheckOnly = false)
	{
	}

	// Token: 0x06000DAE RID: 3502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DAE")]
	[Address(RVA = "0x5F8E00", Offset = "0x5F7E00", VA = "0x1805F8E00")]
	public void UpdateDistanceFromEdge()
	{
	}

	// Token: 0x06000DAF RID: 3503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DAF")]
	[Address(RVA = "0x5F94B0", Offset = "0x5F84B0", VA = "0x1805F94B0")]
	public void PassWindowDistance()
	{
	}

	// Token: 0x06000DB0 RID: 3504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0x5F9720", Offset = "0x5F8720", VA = "0x1805F9720")]
	public void PassDistanceFromExternalDoor()
	{
	}

	// Token: 0x06000DB1 RID: 3505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DB1")]
	[Address(RVA = "0x5F9990", Offset = "0x5F8990", VA = "0x1805F9990")]
	public void PassWeatherParams()
	{
	}

	// Token: 0x06000DB2 RID: 3506 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0x5F9D70", Offset = "0x5F8D70", VA = "0x1805F9D70")]
	public void PassIndoorOutdoor()
	{
	}

	// Token: 0x06000DB3 RID: 3507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DB3")]
	[Address(RVA = "0x5FA090", Offset = "0x5F9090", VA = "0x1805FA090")]
	public void UpdateVentIndoorOutdoor()
	{
	}

	// Token: 0x06000DB4 RID: 3508 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DB4")]
	[Address(RVA = "0x5FA890", Offset = "0x5F9890", VA = "0x1805FA890")]
	public void UpdateDistanceToVent()
	{
	}

	// Token: 0x06000DB5 RID: 3509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DB5")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void PassTimeOfDay()
	{
	}

	// Token: 0x06000DB6 RID: 3510 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DB6")]
	[Address(RVA = "0x5FB0D0", Offset = "0x5FA0D0", VA = "0x1805FB0D0")]
	public void PassEdgeDistance()
	{
	}

	// Token: 0x06000DB7 RID: 3511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DB7")]
	[Address(RVA = "0x5FB1A0", Offset = "0x5FA1A0", VA = "0x1805FB1A0")]
	public void UpdateClosestExteriorWall()
	{
	}

	// Token: 0x06000DB8 RID: 3512 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DB8")]
	[Address(RVA = "0x5FBD60", Offset = "0x5FAD60", VA = "0x1805FBD60")]
	public void PassExteriorWallDistance()
	{
	}

	// Token: 0x06000DB9 RID: 3513 RVA: 0x000073F8 File Offset: 0x000055F8
	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0x5FBE60", Offset = "0x5FAE60", VA = "0x1805FBE60")]
	public bool IsSoundPlaying(AudioController.LoopingSoundInfo sound)
	{
		return default(bool);
	}

	// Token: 0x06000DBA RID: 3514 RVA: 0x00007410 File Offset: 0x00005610
	[Token(Token = "0x6000DBA")]
	[Address(RVA = "0x5FBF20", Offset = "0x5FAF20", VA = "0x1805FBF20")]
	public bool IsSoundPlaying(EventInstance sound)
	{
		return default(bool);
	}

	// Token: 0x06000DBB RID: 3515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0x5FBFC0", Offset = "0x5FAFC0", VA = "0x1805FBFC0")]
	public void StopSound(AudioController.LoopingSoundInfo loop, AudioController.StopType stop)
	{
	}

	// Token: 0x06000DBC RID: 3516 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0x5FC1E0", Offset = "0x5FB1E0", VA = "0x1805FC1E0")]
	public void StopSound(EventInstance sound, AudioController.StopType stop)
	{
	}

	// Token: 0x06000DBD RID: 3517 RVA: 0x00007428 File Offset: 0x00005628
	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0x5FC460", Offset = "0x5FB460", VA = "0x1805FC460")]
	public EventInstance Play2DSound(AudioEvent eventPreset, [Optional] List<AudioController.FMODParam> parameters, float volumeOverride = 1f)
	{
		return default(EventInstance);
	}

	// Token: 0x06000DBE RID: 3518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0x5FCA80", Offset = "0x5FBA80", VA = "0x1805FCA80")]
	public void Play2DSoundDelayed(AudioEvent eventPreset, float delay, [Optional] List<AudioController.FMODParam> parameters, float volumeOverride = 1f)
	{
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x00007440 File Offset: 0x00005640
	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x5FCD80", Offset = "0x5FBD80", VA = "0x1805FCD80")]
	public float GetOcculusion(NewNode listenerLocation, NewNode sourceLocation, AudioEvent audioEvent, float baseVolume, Actor soundMaker, AudioController.SoundMaterialOverride detailedMaterialData, out int penetrationCount, out List<AudioController.ActiveListener> activeListeners, out bool isSuspicious, out List<NewRoom> audibleRooms, out float rangeHearing, [Optional] List<NewNode> additionalLocations, bool forceSuspicious = false)
	{
		return 0f;
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x00007458 File Offset: 0x00005658
	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0x600A00", Offset = "0x5FFA00", VA = "0x180600A00")]
	public float GetAmbientZoneOcculusion(NewNode listenerLocation, AudioController.AmbientZoneInstance ambientZone, out float distance, out int penetrationCount, out NewRoom audibleRoom)
	{
		return 0f;
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0x601EE0", Offset = "0x600EE0", VA = "0x180601EE0")]
	public void ForceOutlineCheck(AudioEvent audioEvent, Interactable inter, bool forceOff = false)
	{
	}

	// Token: 0x06000DC2 RID: 3522 RVA: 0x00007470 File Offset: 0x00005670
	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x602370", Offset = "0x601370", VA = "0x180602370")]
	public float GetPlayersSoundLevel(NewNode sourceLocation, AudioEvent audioEvent, float occludedVolume, AudioController.SoundMaterialOverride detailedMaterialData)
	{
		return 0f;
	}

	// Token: 0x06000DC3 RID: 3523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0x6026C0", Offset = "0x6016C0", VA = "0x1806026C0")]
	public void UpdateAmbientZonesOnEndOfFrame()
	{
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0x602860", Offset = "0x601860", VA = "0x180602860")]
	public void UpdateAmbientZones()
	{
	}

	// Token: 0x06000DC5 RID: 3525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0x602C50", Offset = "0x601C50", VA = "0x180602C50")]
	public void ResetThis()
	{
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0x602D00", Offset = "0x601D00", VA = "0x180602D00")]
	public void SetVCALevel(string vcaName, float value)
	{
	}

	// Token: 0x06000DC7 RID: 3527 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC7")]
	[Address(RVA = "0x602F90", Offset = "0x601F90", VA = "0x180602F90")]
	public void UpdateAmbientPlaybackState()
	{
	}

	// Token: 0x06000DC8 RID: 3528 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0x602FF0", Offset = "0x601FF0", VA = "0x180602FF0")]
	public void StopAllSounds()
	{
	}

	// Token: 0x06000DC9 RID: 3529 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0x603600", Offset = "0x602600", VA = "0x180603600")]
	public void UpdateVolumeChanging()
	{
	}

	// Token: 0x06000DCA RID: 3530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DCA")]
	[Address(RVA = "0x603D80", Offset = "0x602D80", VA = "0x180603D80")]
	public void DebugWeatherLoopDisplay()
	{
	}

	// Token: 0x06000DCB RID: 3531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DCB")]
	[Address(RVA = "0x604020", Offset = "0x603020", VA = "0x180604020")]
	public void NextTVShow()
	{
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DCC")]
	[Address(RVA = "0x604210", Offset = "0x603210", VA = "0x180604210")]
	public void UpdateLoopBasedControllerVibration()
	{
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DCD")]
	[Address(RVA = "0x604C70", Offset = "0x603C70", VA = "0x180604C70")]
	public AudioController()
	{
	}

	// Token: 0x04000F47 RID: 3911
	[Token(Token = "0x4000F47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public StudioListener playerListener;

	// Token: 0x04000F48 RID: 3912
	[Token(Token = "0x4000F48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speedOfSound;

	// Token: 0x04000F49 RID: 3913
	[Token(Token = "0x4000F49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float occlusionUnitVolumeModifier;

	// Token: 0x04000F4A RID: 3914
	[Token(Token = "0x4000F4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int openDoorOcclusionUnits;

	// Token: 0x04000F4B RID: 3915
	[Token(Token = "0x4000F4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int closedDoorOcclusionUnits;

	// Token: 0x04000F4C RID: 3916
	[Token(Token = "0x4000F4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int windowOcclusionUnits;

	// Token: 0x04000F4D RID: 3917
	[Token(Token = "0x4000F4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int wallOcclusionUnits;

	// Token: 0x04000F4E RID: 3918
	[Token(Token = "0x4000F4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int ceilingOcclusionUnits;

	// Token: 0x04000F4F RID: 3919
	[Token(Token = "0x4000F4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int floorOcclusionUnits;

	// Token: 0x04000F50 RID: 3920
	[Token(Token = "0x4000F50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int floorDifferenceOcclusionUnits;

	// Token: 0x04000F51 RID: 3921
	[Token(Token = "0x4000F51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int loopingMaximum;

	// Token: 0x04000F52 RID: 3922
	[Token(Token = "0x4000F52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int maxRoomDistance;

	// Token: 0x04000F53 RID: 3923
	[Token(Token = "0x4000F53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve emulationRolloff;

	// Token: 0x04000F54 RID: 3924
	[Token(Token = "0x4000F54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float aiHearingThreshold;

	// Token: 0x04000F55 RID: 3925
	[Token(Token = "0x4000F55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float playerHearingThreshold;

	// Token: 0x04000F56 RID: 3926
	[Token(Token = "0x4000F56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float soundIconRangeUnit;

	// Token: 0x04000F57 RID: 3927
	[Token(Token = "0x4000F57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int updateClosestWindowTicker;

	// Token: 0x04000F58 RID: 3928
	[Token(Token = "0x4000F58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int updateMixingTicker;

	// Token: 0x04000F59 RID: 3929
	[Token(Token = "0x4000F59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float updateAmbientZonesTimer;

	// Token: 0x04000F5A RID: 3930
	[Token(Token = "0x4000F5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int updateClosestWindow;

	// Token: 0x04000F5B RID: 3931
	[Token(Token = "0x4000F5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int updateMixing;

	// Token: 0x04000F5C RID: 3932
	[Token(Token = "0x4000F5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector3 windowAudioPosition;

	// Token: 0x04000F5D RID: 3933
	[Token(Token = "0x4000F5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float closestWindowDistance;

	// Token: 0x04000F5E RID: 3934
	[Token(Token = "0x4000F5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float closestWindowDistanceNormalized;

	// Token: 0x04000F5F RID: 3935
	[Token(Token = "0x4000F5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float closestWindowDistanceMultiplier;

	// Token: 0x04000F60 RID: 3936
	[Token(Token = "0x4000F60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public AnimationCurve openMultiplierCurve;

	// Token: 0x04000F61 RID: 3937
	[Token(Token = "0x4000F61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float ventOutdoorsIndoors;

	// Token: 0x04000F62 RID: 3938
	[Token(Token = "0x4000F62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float nearbyVent;

	// Token: 0x04000F63 RID: 3939
	[Token(Token = "0x4000F63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Vector3 doorAudioPosition;

	// Token: 0x04000F64 RID: 3940
	[Token(Token = "0x4000F64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float closestDoorDistance;

	// Token: 0x04000F65 RID: 3941
	[Token(Token = "0x4000F65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float closestDoorDistanceNormalized;

	// Token: 0x04000F66 RID: 3942
	[Token(Token = "0x4000F66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public float closestDoorDistanceMultiplier;

	// Token: 0x04000F67 RID: 3943
	[Token(Token = "0x4000F67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float edgeDistance;

	// Token: 0x04000F68 RID: 3944
	[Token(Token = "0x4000F68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public float edgeDistanceNormalized;

	// Token: 0x04000F69 RID: 3945
	[Token(Token = "0x4000F69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float edgeDistanceMultiplier;

	// Token: 0x04000F6A RID: 3946
	[Token(Token = "0x4000F6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public float extWallDistance;

	// Token: 0x04000F6B RID: 3947
	[Token(Token = "0x4000F6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float extWallNormalized;

	// Token: 0x04000F6C RID: 3948
	[Token(Token = "0x4000F6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public float extWallDistanceMultiplier;

	// Token: 0x04000F6D RID: 3949
	[Token(Token = "0x4000F6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float passedWind;

	// Token: 0x04000F6E RID: 3950
	[Token(Token = "0x4000F6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float passedRain;

	// Token: 0x04000F6F RID: 3951
	[Token(Token = "0x4000F6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public float passedCity;

	// Token: 0x04000F70 RID: 3952
	[Token(Token = "0x4000F70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public List<AudioController.AmbientZoneInstance> ambientZones;

	// Token: 0x04000F71 RID: 3953
	[Token(Token = "0x4000F71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Dictionary<AmbientZone, AudioController.AmbientZoneInstance> ambientZoneReference;

	// Token: 0x04000F72 RID: 3954
	[Token(Token = "0x4000F72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public AnimationCurve ambientFalloff;

	// Token: 0x04000F73 RID: 3955
	[Token(Token = "0x4000F73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public AudioController.LoopingSoundInfo ambienceWind;

	// Token: 0x04000F74 RID: 3956
	[Token(Token = "0x4000F74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public AudioController.LoopingSoundInfo ambienceRain;

	// Token: 0x04000F75 RID: 3957
	[Token(Token = "0x4000F75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public AudioController.LoopingSoundInfo ambiencePA;

	// Token: 0x04000F76 RID: 3958
	[Token(Token = "0x4000F76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public string hapticsPlaying;

	// Token: 0x04000F77 RID: 3959
	[Token(Token = "0x4000F77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[NonSerialized]
	public AudioController.LoopingSoundInfo threatLoop;

	// Token: 0x04000F78 RID: 3960
	[Token(Token = "0x4000F78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public List<AudioController.LoopingSoundInfo> loopingSounds;

	// Token: 0x04000F79 RID: 3961
	[Token(Token = "0x4000F79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public HashSet<AudioController.LoopingSoundInfo> volumeChangingSounds;

	// Token: 0x04000F7A RID: 3962
	[Token(Token = "0x4000F7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public List<AudioController.DelayedSoundInfo> delayedSound;

	// Token: 0x04000F7B RID: 3963
	[Token(Token = "0x4000F7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public int footstepLayerMask;

	// Token: 0x04000F7C RID: 3964
	[Token(Token = "0x4000F7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private List<AudioController.LoopingSoundInfo> forceFeedbackLoops;

	// Token: 0x04000F7D RID: 3965
	[Token(Token = "0x4000F7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Action updateAmbientZonesAction;

	// Token: 0x04000F7E RID: 3966
	[Token(Token = "0x4000F7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AudioController _instance;

	// Token: 0x0200025D RID: 605
	[Token(Token = "0x200025D")]
	[Serializable]
	public class AmbientZoneInstance
	{
		// Token: 0x06000DCE RID: 3534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x63A0A0", Offset = "0x6390A0", VA = "0x18063A0A0")]
		public AmbientZoneInstance(AmbientZone newPreset)
		{
		}

		// Token: 0x04000F7F RID: 3967
		[Token(Token = "0x4000F7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AmbientZone preset;

		// Token: 0x04000F80 RID: 3968
		[Token(Token = "0x4000F80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float playerDistance;

		// Token: 0x04000F81 RID: 3969
		[Token(Token = "0x4000F81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int penetrationCount;

		// Token: 0x04000F82 RID: 3970
		[Token(Token = "0x4000F82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NewRoom audibleRoom;

		// Token: 0x04000F83 RID: 3971
		[Token(Token = "0x4000F83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isActive;

		// Token: 0x04000F84 RID: 3972
		[Token(Token = "0x4000F84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float desiredVolume;

		// Token: 0x04000F85 RID: 3973
		[Token(Token = "0x4000F85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float actualVolume;

		// Token: 0x04000F86 RID: 3974
		[Token(Token = "0x4000F86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float desiredWalla;

		// Token: 0x04000F87 RID: 3975
		[Token(Token = "0x4000F87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float actualWalla;

		// Token: 0x04000F88 RID: 3976
		[Token(Token = "0x4000F88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public AudioController.LoopingSoundInfo eventData;

		// Token: 0x04000F89 RID: 3977
		[Token(Token = "0x4000F89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public HashSet<NewRoom> rooms;
	}

	// Token: 0x0200025E RID: 606
	[Token(Token = "0x200025E")]
	[Serializable]
	public class LoopingSoundInfo
	{
		// Token: 0x06000DCF RID: 3535 RVA: 0x00007488 File Offset: 0x00005688
		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x63A2A0", Offset = "0x6392A0", VA = "0x18063A2A0")]
		public PLAYBACK_STATE UpdatePlayState()
		{
			return PLAYBACK_STATE.PLAYING;
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x63A320", Offset = "0x639320", VA = "0x18063A320")]
		public void UpdateWorldPosition(Vector3 newWorldPos, NewNode newNodePos)
		{
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x63A7E0", Offset = "0x6397E0", VA = "0x18063A7E0")]
		public void UpdateOcclusion(bool ignoreLastUpdateTime = false)
		{
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x63C570", Offset = "0x63B570", VA = "0x18063C570")]
		public void SetVolumeImmediate(float vol)
		{
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x63C730", Offset = "0x63B730", VA = "0x18063C730")]
		public void SetVolumeFadeTo(float vol)
		{
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x63C860", Offset = "0x63B860", VA = "0x18063C860")]
		public void OnPauseChange()
		{
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x63CA10", Offset = "0x63BA10", VA = "0x18063CA10")]
		public void UpdateDynamicClip()
		{
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x63DAE0", Offset = "0x63CAE0", VA = "0x18063DAE0")]
		private void PassCrowdReaction()
		{
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x63DDB0", Offset = "0x63CDB0", VA = "0x18063DDB0")]
		public LoopingSoundInfo()
		{
		}

		// Token: 0x04000F8A RID: 3978
		[Token(Token = "0x4000F8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000F8B RID: 3979
		[Token(Token = "0x4000F8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool init;

		// Token: 0x04000F8C RID: 3980
		[Token(Token = "0x4000F8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventInstance audioEvent;

		// Token: 0x04000F8D RID: 3981
		[Token(Token = "0x4000F8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isValid;

		// Token: 0x04000F8E RID: 3982
		[Token(Token = "0x4000F8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventDescription description;

		// Token: 0x04000F8F RID: 3983
		[Token(Token = "0x4000F8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volumeOverride;

		// Token: 0x04000F90 RID: 3984
		[Token(Token = "0x4000F90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioEvent eventPreset;

		// Token: 0x04000F91 RID: 3985
		[Token(Token = "0x4000F91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public NewNode sourceLocation;

		// Token: 0x04000F92 RID: 3986
		[Token(Token = "0x4000F92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Actor who;

		// Token: 0x04000F93 RID: 3987
		[Token(Token = "0x4000F93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Interactable interactable;

		// Token: 0x04000F94 RID: 3988
		[Token(Token = "0x4000F94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool forceSuspicious;

		// Token: 0x04000F95 RID: 3989
		[Token(Token = "0x4000F95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<AudioController.FMODParam> parameters;

		// Token: 0x04000F96 RID: 3990
		[Token(Token = "0x4000F96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float lastUpdated;

		// Token: 0x04000F97 RID: 3991
		[Token(Token = "0x4000F97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int currentOcclusion;

		// Token: 0x04000F98 RID: 3992
		[Token(Token = "0x4000F98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool pauseWhenGamePaused;

		// Token: 0x04000F99 RID: 3993
		[Token(Token = "0x4000F99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Vector3 worldPos;

		// Token: 0x04000F9A RID: 3994
		[Token(Token = "0x4000F9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public PLAYBACK_STATE state;

		// Token: 0x04000F9B RID: 3995
		[Token(Token = "0x4000F9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool paused;

		// Token: 0x04000F9C RID: 3996
		[Token(Token = "0x4000F9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<NewRoom> audibleRooms;

		// Token: 0x04000F9D RID: 3997
		[Token(Token = "0x4000F9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public SessionData.TelevisionChannel isBroadcast;

		// Token: 0x04000F9E RID: 3998
		[Token(Token = "0x4000F9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float occlusionVolume;

		// Token: 0x04000F9F RID: 3999
		[Token(Token = "0x4000F9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float fadeToVolume;

		// Token: 0x04000FA0 RID: 4000
		[Token(Token = "0x4000FA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float vol;

		// Token: 0x04000FA1 RID: 4001
		[Token(Token = "0x4000FA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool isActive;

		// Token: 0x04000FA2 RID: 4002
		[Token(Token = "0x4000FA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string debugStoppedReason;

		// Token: 0x04000FA3 RID: 4003
		[Token(Token = "0x4000FA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public InteractablePreset.IfSwitchStateSFX interactableLoopInfo;

		// Token: 0x04000FA4 RID: 4004
		[Token(Token = "0x4000FA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool clipIsValid;

		// Token: 0x04000FA5 RID: 4005
		[Token(Token = "0x4000FA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		public bool clipPaused;

		// Token: 0x04000FA6 RID: 4006
		[Token(Token = "0x4000FA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public PLAYBACK_STATE clipState;

		// Token: 0x04000FA7 RID: 4007
		[Token(Token = "0x4000FA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public EventInstance clipAudioEvent;
	}

	// Token: 0x0200025F RID: 607
	[Token(Token = "0x200025F")]
	public class ActiveListener
	{
		// Token: 0x06000DD8 RID: 3544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ActiveListener()
		{
		}

		// Token: 0x04000FA8 RID: 4008
		[Token(Token = "0x4000FA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Actor listener;

		// Token: 0x04000FA9 RID: 4009
		[Token(Token = "0x4000FA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float soundLevel;

		// Token: 0x04000FAA RID: 4010
		[Token(Token = "0x4000FAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int escalationLevel;
	}

	// Token: 0x02000260 RID: 608
	[Token(Token = "0x2000260")]
	[Serializable]
	public class DelayedSoundInfo
	{
		// Token: 0x06000DD9 RID: 3545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x63DE80", Offset = "0x63CE80", VA = "0x18063DE80")]
		public DelayedSoundInfo(float newDelay, AudioEvent newEventPreset, Actor newWho, NewNode newLocation, Vector3 newWorldPosition, [Optional] List<AudioController.FMODParam> newParameters, float newVolumeOverride = 1f, [Optional] List<NewNode> newAdditionalSources, bool newForceIgnoreOcclusion = false, bool newIs2D = false)
		{
		}

		// Token: 0x04000FAB RID: 4011
		[Token(Token = "0x4000FAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float delay;

		// Token: 0x04000FAC RID: 4012
		[Token(Token = "0x4000FAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioEvent eventPreset;

		// Token: 0x04000FAD RID: 4013
		[Token(Token = "0x4000FAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Actor who;

		// Token: 0x04000FAE RID: 4014
		[Token(Token = "0x4000FAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NewNode location;

		// Token: 0x04000FAF RID: 4015
		[Token(Token = "0x4000FAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 worldPosition;

		// Token: 0x04000FB0 RID: 4016
		[Token(Token = "0x4000FB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<AudioController.FMODParam> parameters;

		// Token: 0x04000FB1 RID: 4017
		[Token(Token = "0x4000FB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float volumeOverride;

		// Token: 0x04000FB2 RID: 4018
		[Token(Token = "0x4000FB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<NewNode> additionalSources;

		// Token: 0x04000FB3 RID: 4019
		[Token(Token = "0x4000FB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool forceIgnoreOcclusion;

		// Token: 0x04000FB4 RID: 4020
		[Token(Token = "0x4000FB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool is2D;
	}

	// Token: 0x02000261 RID: 609
	[Token(Token = "0x2000261")]
	[Serializable]
	public class SoundMaterialOverride
	{
		// Token: 0x06000DDA RID: 3546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x63E070", Offset = "0x63D070", VA = "0x18063E070")]
		public SoundMaterialOverride(float newConcrete, float newWood, float newCarpet, float newTile, float newPlaster, float newFabric, float newMetal, float newGlass)
		{
		}

		// Token: 0x04000FB5 RID: 4021
		[Token(Token = "0x4000FB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float concrete;

		// Token: 0x04000FB6 RID: 4022
		[Token(Token = "0x4000FB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float wood;

		// Token: 0x04000FB7 RID: 4023
		[Token(Token = "0x4000FB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float carpet;

		// Token: 0x04000FB8 RID: 4024
		[Token(Token = "0x4000FB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float tile;

		// Token: 0x04000FB9 RID: 4025
		[Token(Token = "0x4000FB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float plaster;

		// Token: 0x04000FBA RID: 4026
		[Token(Token = "0x4000FBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fabric;

		// Token: 0x04000FBB RID: 4027
		[Token(Token = "0x4000FBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float metal;

		// Token: 0x04000FBC RID: 4028
		[Token(Token = "0x4000FBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float glass;
	}

	// Token: 0x02000262 RID: 610
	[Token(Token = "0x2000262")]
	public enum CitizenReaction
	{
		// Token: 0x04000FBE RID: 4030
		[Token(Token = "0x4000FBE")]
		investigate,
		// Token: 0x04000FBF RID: 4031
		[Token(Token = "0x4000FBF")]
		immediatePersue,
		// Token: 0x04000FC0 RID: 4032
		[Token(Token = "0x4000FC0")]
		alarm
	}

	// Token: 0x02000263 RID: 611
	[Token(Token = "0x2000263")]
	public enum SurfaceType
	{
		// Token: 0x04000FC2 RID: 4034
		[Token(Token = "0x4000FC2")]
		concrete,
		// Token: 0x04000FC3 RID: 4035
		[Token(Token = "0x4000FC3")]
		woodenFloor,
		// Token: 0x04000FC4 RID: 4036
		[Token(Token = "0x4000FC4")]
		tile,
		// Token: 0x04000FC5 RID: 4037
		[Token(Token = "0x4000FC5")]
		carpet
	}

	// Token: 0x02000264 RID: 612
	[Token(Token = "0x2000264")]
	public enum StopType
	{
		// Token: 0x04000FC7 RID: 4039
		[Token(Token = "0x4000FC7")]
		immediate,
		// Token: 0x04000FC8 RID: 4040
		[Token(Token = "0x4000FC8")]
		fade,
		// Token: 0x04000FC9 RID: 4041
		[Token(Token = "0x4000FC9")]
		triggerCue
	}

	// Token: 0x02000265 RID: 613
	[Token(Token = "0x2000265")]
	public struct FMODParam
	{
		// Token: 0x04000FCA RID: 4042
		[Token(Token = "0x4000FCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x04000FCB RID: 4043
		[Token(Token = "0x4000FCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float value;
	}

	// Token: 0x02000266 RID: 614
	[Token(Token = "0x2000266")]
	private sealed class <>c__DisplayClass112_0
	{
		// Token: 0x06000DDB RID: 3547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass112_0()
		{
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x000074A0 File Offset: 0x000056A0
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x4810F0", Offset = "0x4800F0", VA = "0x1804810F0")]
		internal bool <UpdateLoopBasedControllerVibration>b__0(InputController.ControllerVibration item)
		{
			return default(bool);
		}

		// Token: 0x04000FCC RID: 4044
		[Token(Token = "0x4000FCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InputController.ControllerVibration v;
	}

	// Token: 0x02000267 RID: 615
	[Token(Token = "0x2000267")]
	private sealed class <>c__DisplayClass112_1
	{
		// Token: 0x06000DDD RID: 3549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass112_1()
		{
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x000074B8 File Offset: 0x000056B8
		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <UpdateLoopBasedControllerVibration>b__1(InputController.ControllerVibration item)
		{
			return default(bool);
		}

		// Token: 0x04000FCD RID: 4045
		[Token(Token = "0x4000FCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;
	}
}
