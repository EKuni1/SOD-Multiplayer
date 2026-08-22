using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000269 RID: 617
[Token(Token = "0x2000269")]
public class Benchmarking : MonoBehaviour
{
	// Token: 0x17000075 RID: 117
	// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000075")]
	public static Benchmarking Instance
	{
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x63EC20", Offset = "0x63DC20", VA = "0x18063EC20")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DE5")]
	[Address(RVA = "0x63EC60", Offset = "0x63DC60", VA = "0x18063EC60")]
	private void Awake()
	{
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DE6")]
	[Address(RVA = "0x63EFF0", Offset = "0x63DFF0", VA = "0x18063EFF0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DE7")]
	[Address(RVA = "0x63F200", Offset = "0x63E200", VA = "0x18063F200")]
	private void Update()
	{
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DE8")]
	[Address(RVA = "0x63F710", Offset = "0x63E710", VA = "0x18063F710")]
	public void StartBenchmarking()
	{
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DE9")]
	[Address(RVA = "0x63F800", Offset = "0x63E800", VA = "0x18063F800")]
	public void PauseBenchmarking()
	{
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0x63F810", Offset = "0x63E810", VA = "0x18063F810")]
	public void StopBenchmarking()
	{
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DEB")]
	[Address(RVA = "0x63F920", Offset = "0x63E920", VA = "0x18063F920")]
	public void ResetBenchmarking()
	{
	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DEC")]
	[Address(RVA = "0x63F940", Offset = "0x63E940", VA = "0x18063F940")]
	public Benchmarking()
	{
	}

	// Token: 0x04000FD1 RID: 4049
	[Token(Token = "0x4000FD1")]
	[FieldOffset(Offset = "0x18")]
	public bool benchmarkingActive;

	// Token: 0x04000FD2 RID: 4050
	[Token(Token = "0x4000FD2")]
	[FieldOffset(Offset = "0x1C")]
	public int frames;

	// Token: 0x04000FD3 RID: 4051
	[Token(Token = "0x4000FD3")]
	[FieldOffset(Offset = "0x20")]
	public float secondsPassed;

	// Token: 0x04000FD4 RID: 4052
	[Token(Token = "0x4000FD4")]
	[FieldOffset(Offset = "0x24")]
	public float fpsLow;

	// Token: 0x04000FD5 RID: 4053
	[Token(Token = "0x4000FD5")]
	[FieldOffset(Offset = "0x28")]
	public float fpsHigh;

	// Token: 0x04000FD6 RID: 4054
	[Token(Token = "0x4000FD6")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI fpsText;

	// Token: 0x04000FD7 RID: 4055
	[Token(Token = "0x4000FD7")]
	[FieldOffset(Offset = "0x0")]
	private static Benchmarking _instance;
}
