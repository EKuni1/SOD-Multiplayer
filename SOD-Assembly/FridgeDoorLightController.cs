using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000426 RID: 1062
[Token(Token = "0x2000426")]
public class FridgeDoorLightController : MonoBehaviour
{
	// Token: 0x060017EE RID: 6126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017EE")]
	[Address(RVA = "0x8B0A70", Offset = "0x8AFA70", VA = "0x1808B0A70")]
	private void Start()
	{
	}

	// Token: 0x060017EF RID: 6127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017EF")]
	[Address(RVA = "0x8B0C50", Offset = "0x8AFC50", VA = "0x1808B0C50")]
	private void OnDestroy()
	{
	}

	// Token: 0x060017F0 RID: 6128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017F0")]
	[Address(RVA = "0x8B0DD0", Offset = "0x8AFDD0", VA = "0x1808B0DD0")]
	public void OnSwitchStateChange()
	{
	}

	// Token: 0x060017F1 RID: 6129 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017F1")]
	[Address(RVA = "0x8B0FA0", Offset = "0x8AFFA0", VA = "0x1808B0FA0")]
	private IEnumerator LightOffDelay()
	{
		return null;
	}

	// Token: 0x060017F2 RID: 6130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017F2")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public FridgeDoorLightController()
	{
	}

	// Token: 0x04001D5B RID: 7515
	[Token(Token = "0x4001D5B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject lightContainer;

	// Token: 0x04001D5C RID: 7516
	[Token(Token = "0x4001D5C")]
	[FieldOffset(Offset = "0x20")]
	public InteractableController ic;

	// Token: 0x02000427 RID: 1063
	[Token(Token = "0x2000427")]
	private sealed class <LightOffDelay>d__5 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060017F3 RID: 6131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F3")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <LightOffDelay>d__5(int <>1__state)
		{
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x0000AEA8 File Offset: 0x000090A8
		[Token(Token = "0x60017F5")]
		[Address(RVA = "0x8B1040", Offset = "0x8B0040", VA = "0x1808B1040", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C1")]
		private object Current
		{
			[Token(Token = "0x60017F6")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F7")]
		[Address(RVA = "0x8B1190", Offset = "0x8B0190", VA = "0x1808B1190", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C2")]
		private object Current
		{
			[Token(Token = "0x60017F8")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001D5D RID: 7517
		[Token(Token = "0x4001D5D")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001D5E RID: 7518
		[Token(Token = "0x4001D5E")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001D5F RID: 7519
		[Token(Token = "0x4001D5F")]
		[FieldOffset(Offset = "0x20")]
		public FridgeDoorLightController <>4__this;

		// Token: 0x04001D60 RID: 7520
		[Token(Token = "0x4001D60")]
		[FieldOffset(Offset = "0x28")]
		private float <timer>5__2;
	}
}
