using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x02000615 RID: 1557
[Token(Token = "0x2000615")]
public class PhotoSelectButtonController : ButtonController
{
	// Token: 0x0600223B RID: 8763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600223B")]
	[Address(RVA = "0xB28EA0", Offset = "0xB27EA0", VA = "0x180B28EA0")]
	public void Setup(Human newCitizen, Case.CaseElement newCaseElement, InfoWindow newThisWindow)
	{
	}

	// Token: 0x0600223C RID: 8764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600223C")]
	[Address(RVA = "0xB29010", Offset = "0xB28010", VA = "0x180B29010", Slot = "11")]
	public override void UpdateButtonText()
	{
	}

	// Token: 0x0600223D RID: 8765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600223D")]
	[Address(RVA = "0xB291D0", Offset = "0xB281D0", VA = "0x180B291D0", Slot = "17")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x0600223E RID: 8766 RVA: 0x0000E208 File Offset: 0x0000C408
	[Token(Token = "0x600223E")]
	[Address(RVA = "0xB2AD00", Offset = "0xB29D00", VA = "0x180B2AD00")]
	private bool IsActiveKiller(Human person)
	{
		return default(bool);
	}

	// Token: 0x0600223F RID: 8767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600223F")]
	[Address(RVA = "0xB2B090", Offset = "0xB2A090", VA = "0x180B2B090")]
	private void MergeTargetKeys(Evidence.DataKey key)
	{
	}

	// Token: 0x06002240 RID: 8768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002240")]
	[Address(RVA = "0xA2C450", Offset = "0xA2B450", VA = "0x180A2C450")]
	public PhotoSelectButtonController()
	{
	}

	// Token: 0x04002BDF RID: 11231
	[Token(Token = "0x4002BDF")]
	[FieldOffset(Offset = "0x1A8")]
	public Human citizen;

	// Token: 0x04002BE0 RID: 11232
	[Token(Token = "0x4002BE0")]
	[FieldOffset(Offset = "0x1B0")]
	public Case.CaseElement element;

	// Token: 0x04002BE1 RID: 11233
	[Token(Token = "0x4002BE1")]
	[FieldOffset(Offset = "0x1B8")]
	public RawImage photo;

	// Token: 0x04002BE2 RID: 11234
	[Token(Token = "0x4002BE2")]
	[FieldOffset(Offset = "0x1C0")]
	public InfoWindow thisWindow;

	// Token: 0x02000616 RID: 1558
	[Token(Token = "0x2000616")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002242 RID: 8770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002242")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x0000E220 File Offset: 0x0000C420
		[Token(Token = "0x6002243")]
		[Address(RVA = "0x792170", Offset = "0x791170", VA = "0x180792170")]
		internal bool <OnLeftClick>b__6_0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x0000E238 File Offset: 0x0000C438
		[Token(Token = "0x6002244")]
		[Address(RVA = "0x792140", Offset = "0x791140", VA = "0x180792140")]
		internal bool <OnLeftClick>b__6_1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04002BE3 RID: 11235
		[Token(Token = "0x4002BE3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PhotoSelectButtonController.<>c <>9;

		// Token: 0x04002BE4 RID: 11236
		[Token(Token = "0x4002BE4")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Human.Trait> <>9__6_0;

		// Token: 0x04002BE5 RID: 11237
		[Token(Token = "0x4002BE5")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<Human.Trait> <>9__6_1;
	}

	// Token: 0x02000617 RID: 1559
	[Token(Token = "0x2000617")]
	private sealed class <>c__DisplayClass7_0
	{
		// Token: 0x06002245 RID: 8773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002245")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_0()
		{
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x0000E250 File Offset: 0x0000C450
		[Token(Token = "0x6002246")]
		[Address(RVA = "0xB2B380", Offset = "0xB2A380", VA = "0x180B2B380")]
		internal bool <IsActiveKiller>b__0(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x04002BE6 RID: 11238
		[Token(Token = "0x4002BE6")]
		[FieldOffset(Offset = "0x10")]
		public Human person;
	}
}
