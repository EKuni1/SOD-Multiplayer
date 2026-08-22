using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Rewired;
using TMPro;
using UnityEngine;

// Token: 0x02000571 RID: 1393
[Token(Token = "0x2000571")]
public class ControlDetectController : MonoBehaviour
{
	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x06001E4A RID: 7754 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000F0")]
	public static ControlDetectController Instance
	{
		[Token(Token = "0x6001E4A")]
		[Address(RVA = "0xA4ABC0", Offset = "0xA49BC0", VA = "0x180A4ABC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001E4B RID: 7755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E4B")]
	[Address(RVA = "0xA4AC00", Offset = "0xA49C00", VA = "0x180A4AC00")]
	private void Awake()
	{
	}

	// Token: 0x06001E4C RID: 7756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E4C")]
	[Address(RVA = "0xA4AF50", Offset = "0xA49F50", VA = "0x180A4AF50")]
	private void Start()
	{
	}

	// Token: 0x06001E4D RID: 7757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E4D")]
	[Address(RVA = "0xA4B330", Offset = "0xA4A330", VA = "0x180A4B330")]
	private void Update()
	{
	}

	// Token: 0x06001E4E RID: 7758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E4E")]
	[Address(RVA = "0xA4BD10", Offset = "0xA4AD10", VA = "0x180A4BD10")]
	private void LoadMainScene()
	{
	}

	// Token: 0x06001E4F RID: 7759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E4F")]
	[Address(RVA = "0xA4BED0", Offset = "0xA4AED0", VA = "0x180A4BED0")]
	public ControlDetectController()
	{
	}

	// Token: 0x040026D6 RID: 9942
	[Token(Token = "0x40026D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI pressAnyKeyText;

	// Token: 0x040026D7 RID: 9943
	[Token(Token = "0x40026D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<CanvasRenderer> fadeOutRenderers;

	// Token: 0x040026D8 RID: 9944
	[Token(Token = "0x40026D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<CanvasRenderer> fadeInRenderers;

	// Token: 0x040026D9 RID: 9945
	[Token(Token = "0x40026D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RectTransform loadingIcon;

	// Token: 0x040026DA RID: 9946
	[Token(Token = "0x40026DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AnimationCurve loadingIconAnimCurve;

	// Token: 0x040026DB RID: 9947
	[Token(Token = "0x40026DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[NonSerialized]
	public Rewired.Player player;

	// Token: 0x040026DC RID: 9948
	[Token(Token = "0x40026DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool loadSceneTriggered;

	// Token: 0x040026DD RID: 9949
	[Token(Token = "0x40026DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool loadingScene;

	// Token: 0x040026DE RID: 9950
	[Token(Token = "0x40026DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float fadeOut;

	// Token: 0x040026DF RID: 9951
	[Token(Token = "0x40026DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ControlDetectController _instance;

	// Token: 0x02000572 RID: 1394
	[Token(Token = "0x2000572")]
	[StructLayout(3)]
	private struct <LoadMainScene>d__15 : IEnumerator<object>
	{
		// Token: 0x06001E50 RID: 7760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E50")]
		[Address(RVA = "0xA4C060", Offset = "0xA4B060", VA = "0x180A4C060", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E51")]
		[Address(RVA = "0x6F8FA0", Offset = "0x6F7FA0", VA = "0x1806F8FA0", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040026E0 RID: 9952
		[Token(Token = "0x40026E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040026E1 RID: 9953
		[Token(Token = "0x40026E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		// Token: 0x040026E2 RID: 9954
		[Token(Token = "0x40026E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ControlDetectController <>4__this;

		// Token: 0x040026E3 RID: 9955
		[Token(Token = "0x40026E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter <>u__1;
	}
}
