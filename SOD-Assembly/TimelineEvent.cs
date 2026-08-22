using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200062E RID: 1582
[Token(Token = "0x200062E")]
[Serializable]
public class TimelineEvent : IEnumerator<object>
{
	// Token: 0x1400003D RID: 61
	// (add) Token: 0x060022B7 RID: 8887 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060022B8 RID: 8888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400003D")]
	public event TimelineEvent.OnNameChange OnNameChanged
	{
		[Token(Token = "0x60022B7")]
		[Address(RVA = "0xB3EDF0", Offset = "0xB3DDF0", VA = "0x180B3EDF0")]
		add
		{
		}
		[Token(Token = "0x60022B8")]
		[Address(RVA = "0xB3EEE0", Offset = "0xB3DEE0", VA = "0x180B3EEE0")]
		remove
		{
		}
	}

	// Token: 0x1400003E RID: 62
	// (add) Token: 0x060022B9 RID: 8889 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060022BA RID: 8890 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400003E")]
	public event TimelineEvent.RecallAccuracyChange OnRecallAccuracyChange
	{
		[Token(Token = "0x60022B9")]
		[Address(RVA = "0xB3EFD0", Offset = "0xB3DFD0", VA = "0x180B3EFD0")]
		add
		{
		}
		[Token(Token = "0x60022BA")]
		[Address(RVA = "0xB3F0C0", Offset = "0xB3E0C0", VA = "0x180B3F0C0")]
		remove
		{
		}
	}

	// Token: 0x1400003F RID: 63
	// (add) Token: 0x060022BB RID: 8891 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060022BC RID: 8892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400003F")]
	public event TimelineEvent.OnCalledUponTimeUpdate OnCalledUponTimeUpdated
	{
		[Token(Token = "0x60022BB")]
		[Address(RVA = "0xB3F1B0", Offset = "0xB3E1B0", VA = "0x180B3F1B0")]
		add
		{
		}
		[Token(Token = "0x60022BC")]
		[Address(RVA = "0xB3F2A0", Offset = "0xB3E2A0", VA = "0x180B3F2A0")]
		remove
		{
		}
	}

	// Token: 0x060022BD RID: 8893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022BD")]
	[Address(RVA = "0xB3F390", Offset = "0xB3E390", VA = "0x180B3F390")]
	public TimelineEvent(TimelineEvent.EventType newType, NewNode newLocation, TimelineEvent newParentEvent, bool autoCallUpon, bool overrideHappenedAt = false, float happenedOverride = 0f)
	{
	}

	// Token: 0x060022BE RID: 8894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022BE")]
	[Address(RVA = "0xB3F890", Offset = "0xB3E890", VA = "0x180B3F890", Slot = "5")]
	public virtual void UpdateName()
	{
	}

	// Token: 0x060022BF RID: 8895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022BF")]
	[Address(RVA = "0xB3FCC0", Offset = "0xB3ECC0", VA = "0x180B3FCC0")]
	public void AddChildEventToThis(TimelineEvent newTied)
	{
	}

	// Token: 0x060022C0 RID: 8896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022C0")]
	[Address(RVA = "0xB3FE30", Offset = "0xB3EE30", VA = "0x180B3FE30", Slot = "6")]
	public virtual void CallUpon(bool forceAccuracy = false, int forceAccuracyToMinutes = 0)
	{
	}

	// Token: 0x060022C1 RID: 8897 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022C1")]
	[Address(RVA = "0xB40010", Offset = "0xB3F010", VA = "0x180B40010")]
	public void SetTimeRecallAccuracy(float newVal)
	{
	}

	// Token: 0x060022C2 RID: 8898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022C2")]
	[Address(RVA = "0xB40030", Offset = "0xB3F030", VA = "0x180B40030")]
	public void OnTimeUpdated()
	{
	}

	// Token: 0x060022C3 RID: 8899 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022C3")]
	[Address(RVA = "0x7AE9B0", Offset = "0x7AD9B0", VA = "0x1807AE9B0", Slot = "7")]
	public virtual void OnAppearInTimeline()
	{
	}

	// Token: 0x060022C4 RID: 8900 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
	[Token(Token = "0x60022C4")]
	[Address(RVA = "0xB40050", Offset = "0xB3F050", VA = "0x180B40050", Slot = "4")]
	public int CompareTo(TimelineEvent otherObject)
	{
		return 0;
	}

	// Token: 0x04002C71 RID: 11377
	[Token(Token = "0x4002C71")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	// Token: 0x04002C72 RID: 11378
	[Token(Token = "0x4002C72")]
	[FieldOffset(Offset = "0x18")]
	public string detail;

	// Token: 0x04002C73 RID: 11379
	[Token(Token = "0x4002C73")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public bool intialised;

	// Token: 0x04002C74 RID: 11380
	[Token(Token = "0x4002C74")]
	[FieldOffset(Offset = "0x24")]
	public TimelineEvent.EventType eventType;

	// Token: 0x04002C75 RID: 11381
	[Token(Token = "0x4002C75")]
	[FieldOffset(Offset = "0x28")]
	public bool isSelfLocational;

	// Token: 0x04002C76 RID: 11382
	[Token(Token = "0x4002C76")]
	[FieldOffset(Offset = "0x29")]
	public bool isGlobalEvent;

	// Token: 0x04002C77 RID: 11383
	[Token(Token = "0x4002C77")]
	[FieldOffset(Offset = "0x2C")]
	public int eventID;

	// Token: 0x04002C78 RID: 11384
	[Token(Token = "0x4002C78")]
	[FieldOffset(Offset = "0x0")]
	public static int assignEventID;

	// Token: 0x04002C79 RID: 11385
	[Token(Token = "0x4002C79")]
	[FieldOffset(Offset = "0x30")]
	public NewNode location;

	// Token: 0x04002C7A RID: 11386
	[Token(Token = "0x4002C7A")]
	[FieldOffset(Offset = "0x38")]
	public float happenedAt;

	// Token: 0x04002C7B RID: 11387
	[Token(Token = "0x4002C7B")]
	[FieldOffset(Offset = "0x3C")]
	public float timeAccuracy;

	// Token: 0x04002C7C RID: 11388
	[Token(Token = "0x4002C7C")]
	[FieldOffset(Offset = "0x40")]
	[NonSerialized]
	public float totalSuspicion;

	// Token: 0x04002C7D RID: 11389
	[Token(Token = "0x4002C7D")]
	[FieldOffset(Offset = "0x44")]
	public bool calledUpon;

	// Token: 0x04002C7E RID: 11390
	[Token(Token = "0x4002C7E")]
	[FieldOffset(Offset = "0x48")]
	[NonSerialized]
	public EventTime eventTime;

	// Token: 0x04002C7F RID: 11391
	[Token(Token = "0x4002C7F")]
	[FieldOffset(Offset = "0x50")]
	[NonSerialized]
	public List<TimelineEvent> childEvents;

	// Token: 0x04002C80 RID: 11392
	[Token(Token = "0x4002C80")]
	[FieldOffset(Offset = "0x58")]
	[NonSerialized]
	public TimelineEvent parentEvent;

	// Token: 0x04002C81 RID: 11393
	[Token(Token = "0x4002C81")]
	[FieldOffset(Offset = "0x60")]
	public bool discoveredByQuestioned;

	// Token: 0x04002C85 RID: 11397
	[Token(Token = "0x4002C85")]
	[FieldOffset(Offset = "0x80")]
	public int debugLocationID;

	// Token: 0x04002C86 RID: 11398
	[Token(Token = "0x4002C86")]
	[FieldOffset(Offset = "0x88")]
	public string debugLocationName;

	// Token: 0x0200062F RID: 1583
	[Token(Token = "0x200062F")]
	public enum EventType
	{
		// Token: 0x04002C88 RID: 11400
		[Token(Token = "0x4002C88")]
		sightingStreet,
		// Token: 0x04002C89 RID: 11401
		[Token(Token = "0x4002C89")]
		sightingWindow,
		// Token: 0x04002C8A RID: 11402
		[Token(Token = "0x4002C8A")]
		sightingHere,
		// Token: 0x04002C8B RID: 11403
		[Token(Token = "0x4002C8B")]
		sightingArrive,
		// Token: 0x04002C8C RID: 11404
		[Token(Token = "0x4002C8C")]
		sightingDepart,
		// Token: 0x04002C8D RID: 11405
		[Token(Token = "0x4002C8D")]
		selfArrive,
		// Token: 0x04002C8E RID: 11406
		[Token(Token = "0x4002C8E")]
		selfDepart,
		// Token: 0x04002C8F RID: 11407
		[Token(Token = "0x4002C8F")]
		wakeUp,
		// Token: 0x04002C90 RID: 11408
		[Token(Token = "0x4002C90")]
		goToBed,
		// Token: 0x04002C91 RID: 11409
		[Token(Token = "0x4002C91")]
		heardSound,
		// Token: 0x04002C92 RID: 11410
		[Token(Token = "0x4002C92")]
		nonPersonSighting,
		// Token: 0x04002C93 RID: 11411
		[Token(Token = "0x4002C93")]
		smell,
		// Token: 0x04002C94 RID: 11412
		[Token(Token = "0x4002C94")]
		questioned,
		// Token: 0x04002C95 RID: 11413
		[Token(Token = "0x4002C95")]
		delayBegin,
		// Token: 0x04002C96 RID: 11414
		[Token(Token = "0x4002C96")]
		delayEnd,
		// Token: 0x04002C97 RID: 11415
		[Token(Token = "0x4002C97")]
		timeOfDeath,
		// Token: 0x04002C98 RID: 11416
		[Token(Token = "0x4002C98")]
		sightingWentToBed,
		// Token: 0x04002C99 RID: 11417
		[Token(Token = "0x4002C99")]
		sightingWokeUp,
		// Token: 0x04002C9A RID: 11418
		[Token(Token = "0x4002C9A")]
		forcedEntryInvestigate
	}

	// Token: 0x02000630 RID: 1584
	// (Invoke) Token: 0x060022C6 RID: 8902
	[Token(Token = "0x2000630")]
	public delegate void OnNameChange();

	// Token: 0x02000631 RID: 1585
	// (Invoke) Token: 0x060022CA RID: 8906
	[Token(Token = "0x2000631")]
	public delegate void RecallAccuracyChange();

	// Token: 0x02000632 RID: 1586
	// (Invoke) Token: 0x060022CE RID: 8910
	[Token(Token = "0x2000632")]
	public delegate void OnCalledUponTimeUpdate();
}
