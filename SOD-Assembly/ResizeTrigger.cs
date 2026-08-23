using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000037 RID: 55
[Token(Token = "0x2000037")]
public class ResizeTrigger : MonoBehaviour
{
	// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x5CAA70", Offset = "0x5C9A70", VA = "0x1805CAA70")]
	public void TriggerGraffitiChecks()
	{
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x5CAC50", Offset = "0x5C9C50", VA = "0x1805CAC50")]
	private IEnumerator DoResizeTrigger()
	{
		return null;
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x5CACF0", Offset = "0x5C9CF0", VA = "0x1805CACF0")]
	public ResizeTrigger()
	{
	}

	// Token: 0x0400011E RID: 286
	[Token(Token = "0x400011E")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask layerMask;

	// Token: 0x0400011F RID: 287
	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x20")]
	public DecalProjector decal;

	// Token: 0x04000120 RID: 288
	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x28")]
	public float hitboxSizeModifier;

	// Token: 0x04000121 RID: 289
	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x2C")]
	public float pixelScaleMultiplier;

	// Token: 0x04000122 RID: 290
	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x30")]
	public int maxResizeTimes;

	// Token: 0x04000123 RID: 291
	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x34")]
	public int maxRepositionTimes;

	// Token: 0x04000124 RID: 292
	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x38")]
	public float maxRepositionDistance;

	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	private sealed class <DoResizeTrigger>d__8 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <DoResizeTrigger>d__8(int <>1__state)
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x5CAD50", Offset = "0x5C9D50", VA = "0x1805CAD50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000020")]
		private object Current
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x5CBDD0", Offset = "0x5CADD0", VA = "0x1805CBDD0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000021")]
		private object Current
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x20")]
		public ResizeTrigger <>4__this;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x28")]
		private bool <obscured>5__2;
	}
}
