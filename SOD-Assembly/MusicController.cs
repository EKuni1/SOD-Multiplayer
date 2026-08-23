using System;
using System.Collections.Generic;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000404 RID: 1028
[Token(Token = "0x2000404")]
public class MusicController : MonoBehaviour
{
	// Token: 0x170000BE RID: 190
	// (get) Token: 0x06001749 RID: 5961 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000BE")]
	public static MusicController Instance
	{
		[Token(Token = "0x6001749")]
		[Address(RVA = "0x8899B0", Offset = "0x8889B0", VA = "0x1808899B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600174A RID: 5962 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600174A")]
	[Address(RVA = "0x8899F0", Offset = "0x8889F0", VA = "0x1808899F0")]
	private void Awake()
	{
	}

	// Token: 0x0600174B RID: 5963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600174B")]
	[Address(RVA = "0x889E70", Offset = "0x888E70", VA = "0x180889E70")]
	public void SetGameState(MusicCue.MusicTriggerGameState newGameState)
	{
	}

	// Token: 0x0600174C RID: 5964 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600174C")]
	[Address(RVA = "0x889F60", Offset = "0x888F60", VA = "0x180889F60")]
	public void SetPlayerState(MusicCue.MusicTriggerPlayerState newPlayerState)
	{
	}

	// Token: 0x0600174D RID: 5965 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600174D")]
	[Address(RVA = "0x88A050", Offset = "0x889050", VA = "0x18088A050")]
	public void SetPlayerLocation(MusicCue.MusicTriggerPlayerLocation newPlayerLocation)
	{
	}

	// Token: 0x0600174E RID: 5966 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600174E")]
	[Address(RVA = "0x88A140", Offset = "0x889140", VA = "0x18088A140")]
	public void MusicTriggerCheck(MusicCue.MusicTriggerEvent passEvent = MusicCue.MusicTriggerEvent.none)
	{
	}

	// Token: 0x0600174F RID: 5967 RVA: 0x0000ACB0 File Offset: 0x00008EB0
	[Token(Token = "0x600174F")]
	[Address(RVA = "0x88B130", Offset = "0x88A130", VA = "0x18088B130")]
	public bool IsTriggerValid(MusicCue.MusicTrigger trigger, MusicCue.MusicTriggerEvent passEvent, bool debug)
	{
		return default(bool);
	}

	// Token: 0x06001750 RID: 5968 RVA: 0x0000ACC8 File Offset: 0x00008EC8
	[Token(Token = "0x6001750")]
	[Address(RVA = "0x88C970", Offset = "0x88B970", VA = "0x18088C970")]
	private float GetPreviouslyPlayedBias(MusicCue cue)
	{
		return 0f;
	}

	// Token: 0x06001751 RID: 5969 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001751")]
	[Address(RVA = "0x88CAA0", Offset = "0x88BAA0", VA = "0x18088CAA0")]
	public void PlayNewTrack(MusicCue newTrack, bool interupt = false)
	{
	}

	// Token: 0x06001752 RID: 5970 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001752")]
	[Address(RVA = "0x88CD10", Offset = "0x88BD10", VA = "0x18088CD10")]
	private void Update()
	{
	}

	// Token: 0x06001753 RID: 5971 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001753")]
	[Address(RVA = "0x88D240", Offset = "0x88C240", VA = "0x18088D240")]
	public void StopCurrentTrack()
	{
	}

	// Token: 0x06001754 RID: 5972 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001754")]
	[Address(RVA = "0x88D720", Offset = "0x88C720", VA = "0x18088D720")]
	public void ForceNextTrack()
	{
	}

	// Token: 0x06001755 RID: 5973 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001755")]
	[Address(RVA = "0x88D730", Offset = "0x88C730", VA = "0x18088D730")]
	public void AudioFiltersCheck()
	{
	}

	// Token: 0x06001756 RID: 5974 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001756")]
	[Address(RVA = "0x88E050", Offset = "0x88D050", VA = "0x18088E050")]
	public void StartMusicOnlySnapshot()
	{
	}

	// Token: 0x06001757 RID: 5975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001757")]
	[Address(RVA = "0x88E2E0", Offset = "0x88D2E0", VA = "0x18088E2E0")]
	public void StopMusicOnlySnapshot()
	{
	}

	// Token: 0x06001758 RID: 5976 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001758")]
	[Address(RVA = "0x88E4E0", Offset = "0x88D4E0", VA = "0x18088E4E0")]
	public MusicController()
	{
	}

	// Token: 0x06001759 RID: 5977 RVA: 0x0000ACE0 File Offset: 0x00008EE0
	[Token(Token = "0x6001759")]
	[Address(RVA = "0x88E820", Offset = "0x88D820", VA = "0x18088E820")]
	private int <MusicTriggerCheck>b__22_0(MusicCue p1, MusicCue p2)
	{
		return 0;
	}

	// Token: 0x04001C46 RID: 7238
	[Token(Token = "0x4001C46")]
	[FieldOffset(Offset = "0x18")]
	[NonSerialized]
	public List<MusicCue> cues;

	// Token: 0x04001C47 RID: 7239
	[Token(Token = "0x4001C47")]
	[FieldOffset(Offset = "0x20")]
	public bool enableMusic;

	// Token: 0x04001C48 RID: 7240
	[Token(Token = "0x4001C48")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 silenceBetweenTracks;

	// Token: 0x04001C49 RID: 7241
	[Token(Token = "0x4001C49")]
	[FieldOffset(Offset = "0x30")]
	public List<MusicCue> currentValidCues;

	// Token: 0x04001C4A RID: 7242
	[Token(Token = "0x4001C4A")]
	[FieldOffset(Offset = "0x38")]
	public List<MusicCue> playedOnceTracks;

	// Token: 0x04001C4B RID: 7243
	[Token(Token = "0x4001C4B")]
	[FieldOffset(Offset = "0x40")]
	public bool isPlaying;

	// Token: 0x04001C4C RID: 7244
	[Token(Token = "0x4001C4C")]
	[FieldOffset(Offset = "0x44")]
	public float nextTrackTriggerTime;

	// Token: 0x04001C4D RID: 7245
	[Token(Token = "0x4001C4D")]
	[FieldOffset(Offset = "0x48")]
	public MusicCue.MusicTriggerGameState currentGameState;

	// Token: 0x04001C4E RID: 7246
	[Token(Token = "0x4001C4E")]
	[FieldOffset(Offset = "0x4C")]
	public MusicCue.MusicTriggerPlayerState currentPlayerSate;

	// Token: 0x04001C4F RID: 7247
	[Token(Token = "0x4001C4F")]
	[FieldOffset(Offset = "0x50")]
	public MusicCue.MusicTriggerPlayerLocation currentPlayerLocation;

	// Token: 0x04001C50 RID: 7248
	[Token(Token = "0x4001C50")]
	[FieldOffset(Offset = "0x58")]
	public List<MusicCue> previousTracks;

	// Token: 0x04001C51 RID: 7249
	[Token(Token = "0x4001C51")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<MusicCue, EventInstance> activeTracks;

	// Token: 0x04001C52 RID: 7250
	[Token(Token = "0x4001C52")]
	[FieldOffset(Offset = "0x68")]
	public List<MusicCue> activeCuePresets;

	// Token: 0x04001C53 RID: 7251
	[Token(Token = "0x4001C53")]
	[FieldOffset(Offset = "0x70")]
	public AudioController.LoopingSoundInfo hyperacusisFilter;

	// Token: 0x04001C54 RID: 7252
	[Token(Token = "0x4001C54")]
	[FieldOffset(Offset = "0x78")]
	public AudioController.LoopingSoundInfo bassReductionFilter;

	// Token: 0x04001C55 RID: 7253
	[Token(Token = "0x4001C55")]
	[FieldOffset(Offset = "0x0")]
	private static MusicController _instance;
}
