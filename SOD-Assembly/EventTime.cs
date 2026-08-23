using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200062B RID: 1579
[Token(Token = "0x200062B")]
public class EventTime
{
	// Token: 0x1400003C RID: 60
	// (add) Token: 0x060022AF RID: 8879 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060022B0 RID: 8880 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400003C")]
	public event EventTime.OnCalledUponTimeUpdate OnCalledUponTimeUpdated
	{
		[Token(Token = "0x60022AF")]
		[Address(RVA = "0xB3E3C0", Offset = "0xB3D3C0", VA = "0x180B3E3C0")]
		add
		{
		}
		[Token(Token = "0x60022B0")]
		[Address(RVA = "0xB3E4B0", Offset = "0xB3D4B0", VA = "0x180B3E4B0")]
		remove
		{
		}
	}

	// Token: 0x060022B1 RID: 8881 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022B1")]
	[Address(RVA = "0xB3E5A0", Offset = "0xB3D5A0", VA = "0x180B3E5A0")]
	public EventTime(TimelineEvent newParent, bool forceAccuracy = false, int forceAccuracyToMinutes = 0, bool forceRange = false, float forcedFrom = 0f, float forcedTo = 0f)
	{
	}

	// Token: 0x060022B2 RID: 8882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022B2")]
	[Address(RVA = "0xB3EA10", Offset = "0xB3DA10", VA = "0x180B3EA10")]
	public void CalculateTimings()
	{
	}

	// Token: 0x04002C5C RID: 11356
	[Token(Token = "0x4002C5C")]
	[FieldOffset(Offset = "0x10")]
	public TimelineEvent parentMemory;

	// Token: 0x04002C5D RID: 11357
	[Token(Token = "0x4002C5D")]
	[FieldOffset(Offset = "0x18")]
	public bool forcedAccuracy;

	// Token: 0x04002C5E RID: 11358
	[Token(Token = "0x4002C5E")]
	[FieldOffset(Offset = "0x1C")]
	public int forcedAccuracyToMinutes;

	// Token: 0x04002C5F RID: 11359
	[Token(Token = "0x4002C5F")]
	[FieldOffset(Offset = "0x20")]
	public bool forcedRange;

	// Token: 0x04002C60 RID: 11360
	[Token(Token = "0x4002C60")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 forcedTimeRange;

	// Token: 0x04002C61 RID: 11361
	[Token(Token = "0x4002C61")]
	[FieldOffset(Offset = "0x2C")]
	public float timeStart;

	// Token: 0x04002C62 RID: 11362
	[Token(Token = "0x4002C62")]
	[FieldOffset(Offset = "0x30")]
	public float timeEnd;

	// Token: 0x04002C63 RID: 11363
	[Token(Token = "0x4002C63")]
	[FieldOffset(Offset = "0x34")]
	public float timeMidPoint;

	// Token: 0x04002C64 RID: 11364
	[Token(Token = "0x4002C64")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 timeRange;

	// Token: 0x04002C65 RID: 11365
	[Token(Token = "0x4002C65")]
	[FieldOffset(Offset = "0x40")]
	public string accurateString;

	// Token: 0x04002C66 RID: 11366
	[Token(Token = "0x4002C66")]
	[FieldOffset(Offset = "0x48")]
	public string startString;

	// Token: 0x04002C67 RID: 11367
	[Token(Token = "0x4002C67")]
	[FieldOffset(Offset = "0x50")]
	public string endString;

	// Token: 0x04002C68 RID: 11368
	[Token(Token = "0x4002C68")]
	[FieldOffset(Offset = "0x58")]
	public float roundedTo;

	// Token: 0x04002C69 RID: 11369
	[Token(Token = "0x4002C69")]
	[FieldOffset(Offset = "0x5C")]
	public EventTime.RecallAccuracy recallAccuracy;

	// Token: 0x0200062C RID: 1580
	[Token(Token = "0x200062C")]
	public enum RecallAccuracy
	{
		// Token: 0x04002C6C RID: 11372
		[Token(Token = "0x4002C6C")]
		veryLow,
		// Token: 0x04002C6D RID: 11373
		[Token(Token = "0x4002C6D")]
		low,
		// Token: 0x04002C6E RID: 11374
		[Token(Token = "0x4002C6E")]
		med,
		// Token: 0x04002C6F RID: 11375
		[Token(Token = "0x4002C6F")]
		high,
		// Token: 0x04002C70 RID: 11376
		[Token(Token = "0x4002C70")]
		veryHigh
	}

	// Token: 0x0200062D RID: 1581
	// (Invoke) Token: 0x060022B4 RID: 8884
	[Token(Token = "0x200062D")]
	public delegate void OnCalledUponTimeUpdate();
}
