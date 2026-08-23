using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E3 RID: 739
[Token(Token = "0x20002E3")]
public class DrawPile : MonoBehaviour
{
	// Token: 0x0600106C RID: 4204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600106C")]
	[Address(RVA = "0x6A3320", Offset = "0x6A2320", VA = "0x1806A3320")]
	public void DrawCard()
	{
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600106D")]
	[Address(RVA = "0x6A3BE0", Offset = "0x6A2BE0", VA = "0x1806A3BE0")]
	public CardSpace GetFirstEmptySpace()
	{
		return null;
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600106E")]
	[Address(RVA = "0x6A3E80", Offset = "0x6A2E80", VA = "0x1806A3E80")]
	private IEnumerator MoveCardToAvailableSpace(GameObject card, CardSpace space)
	{
		return null;
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600106F")]
	public static List<T> Shuffle<T>(List<T> list)
	{
		return null;
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001070")]
	[Address(RVA = "0x6A3FF0", Offset = "0x6A2FF0", VA = "0x1806A3FF0")]
	public DrawPile()
	{
	}

	// Token: 0x040013CB RID: 5067
	[Token(Token = "0x40013CB")]
	[FieldOffset(Offset = "0x18")]
	public WizcardPlayer player;

	// Token: 0x040013CC RID: 5068
	[Token(Token = "0x40013CC")]
	[FieldOffset(Offset = "0x20")]
	public CardSpace[] cardSpaces;

	// Token: 0x040013CD RID: 5069
	[Token(Token = "0x40013CD")]
	[FieldOffset(Offset = "0x28")]
	public Queue<GameObject> playerCards;

	// Token: 0x040013CE RID: 5070
	[Token(Token = "0x40013CE")]
	[FieldOffset(Offset = "0x30")]
	public float lerpSpeed;

	// Token: 0x020002E4 RID: 740
	[Token(Token = "0x20002E4")]
	private sealed class <MoveCardToAvailableSpace>d__6 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001071 RID: 4209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001071")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <MoveCardToAvailableSpace>d__6(int <>1__state)
		{
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001072")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x000084D8 File Offset: 0x000066D8
		[Token(Token = "0x6001073")]
		[Address(RVA = "0x6A4100", Offset = "0x6A3100", VA = "0x1806A4100", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700007E")]
		private object Current
		{
			[Token(Token = "0x6001074")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001075")]
		[Address(RVA = "0x6A4920", Offset = "0x6A3920", VA = "0x1806A4920", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700007F")]
		private object Current
		{
			[Token(Token = "0x6001076")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040013CF RID: 5071
		[Token(Token = "0x40013CF")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040013D0 RID: 5072
		[Token(Token = "0x40013D0")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040013D1 RID: 5073
		[Token(Token = "0x40013D1")]
		[FieldOffset(Offset = "0x20")]
		public CardSpace space;

		// Token: 0x040013D2 RID: 5074
		[Token(Token = "0x40013D2")]
		[FieldOffset(Offset = "0x28")]
		public GameObject card;

		// Token: 0x040013D3 RID: 5075
		[Token(Token = "0x40013D3")]
		[FieldOffset(Offset = "0x30")]
		public DrawPile <>4__this;

		// Token: 0x040013D4 RID: 5076
		[Token(Token = "0x40013D4")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 <startPosition>5__2;

		// Token: 0x040013D5 RID: 5077
		[Token(Token = "0x40013D5")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 <endPosition>5__3;

		// Token: 0x040013D6 RID: 5078
		[Token(Token = "0x40013D6")]
		[FieldOffset(Offset = "0x50")]
		private float <time>5__4;
	}
}
