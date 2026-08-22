using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002E8 RID: 744
[Token(Token = "0x20002E8")]
public class MatchEndText : MonoBehaviour
{
	// Token: 0x0600107D RID: 4221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600107D")]
	[Address(RVA = "0x6A5190", Offset = "0x6A4190", VA = "0x1806A5190")]
	public void EndGame(string key)
	{
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600107E")]
	[Address(RVA = "0x6A53A0", Offset = "0x6A43A0", VA = "0x1806A53A0")]
	private IEnumerator CO_EndGame(TextData textData)
	{
		return null;
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600107F")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public MatchEndText()
	{
	}

	// Token: 0x040013E3 RID: 5091
	[Token(Token = "0x40013E3")]
	[FieldOffset(Offset = "0x18")]
	public TextData[] textVariations;

	// Token: 0x040013E4 RID: 5092
	[Token(Token = "0x40013E4")]
	[FieldOffset(Offset = "0x20")]
	public int secondsToShowText;

	// Token: 0x040013E5 RID: 5093
	[Token(Token = "0x40013E5")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI text;

	// Token: 0x040013E6 RID: 5094
	[Token(Token = "0x40013E6")]
	[FieldOffset(Offset = "0x30")]
	public WizcardsApp app;

	// Token: 0x020002E9 RID: 745
	[Token(Token = "0x20002E9")]
	private sealed class <CO_EndGame>d__5 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001080 RID: 4224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001080")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <CO_EndGame>d__5(int <>1__state)
		{
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001081")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00008508 File Offset: 0x00006708
		[Token(Token = "0x6001082")]
		[Address(RVA = "0x6A54C0", Offset = "0x6A44C0", VA = "0x1806A54C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000080")]
		private object Current
		{
			[Token(Token = "0x6001083")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001084")]
		[Address(RVA = "0x6A56A0", Offset = "0x6A46A0", VA = "0x1806A56A0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000081")]
		private object Current
		{
			[Token(Token = "0x6001085")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040013E7 RID: 5095
		[Token(Token = "0x40013E7")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040013E8 RID: 5096
		[Token(Token = "0x40013E8")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040013E9 RID: 5097
		[Token(Token = "0x40013E9")]
		[FieldOffset(Offset = "0x20")]
		public MatchEndText <>4__this;

		// Token: 0x040013EA RID: 5098
		[Token(Token = "0x40013EA")]
		[FieldOffset(Offset = "0x28")]
		public TextData textData;
	}
}
