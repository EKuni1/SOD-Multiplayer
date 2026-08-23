using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020005CA RID: 1482
[Token(Token = "0x20005CA")]
public class AddressBookController : MonoBehaviour
{
	// Token: 0x0600208F RID: 8335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600208F")]
	[Address(RVA = "0xADDF90", Offset = "0xADCF90", VA = "0x180ADDF90")]
	private void OnEnable()
	{
	}

	// Token: 0x06002090 RID: 8336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002090")]
	[Address(RVA = "0xADE3E0", Offset = "0xADD3E0", VA = "0x180ADE3E0")]
	private void OnDisable()
	{
	}

	// Token: 0x06002091 RID: 8337 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002091")]
	[Address(RVA = "0xADE680", Offset = "0xADD680", VA = "0x180ADE680")]
	public void CheckEnabled()
	{
	}

	// Token: 0x06002092 RID: 8338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002092")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public AddressBookController()
	{
	}

	// Token: 0x04002A21 RID: 10785
	[Token(Token = "0x4002A21")]
	[FieldOffset(Offset = "0x18")]
	public WindowContentController windowContent;

	// Token: 0x04002A22 RID: 10786
	[Token(Token = "0x4002A22")]
	[FieldOffset(Offset = "0x20")]
	public InfoWindow parentWindow;

	// Token: 0x04002A23 RID: 10787
	[Token(Token = "0x4002A23")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI descriptionText;

	// Token: 0x020005CB RID: 1483
	[Token(Token = "0x20005CB")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002094 RID: 8340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002094")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x0000DF38 File Offset: 0x0000C138
		[Token(Token = "0x6002095")]
		[Address(RVA = "0xAE1080", Offset = "0xAE0080", VA = "0x180AE1080")]
		internal bool <CheckEnabled>b__5_1(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x0000DF50 File Offset: 0x0000C150
		[Token(Token = "0x6002096")]
		[Address(RVA = "0xAE1080", Offset = "0xAE0080", VA = "0x180AE1080")]
		internal bool <CheckEnabled>b__5_2(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x0000DF68 File Offset: 0x0000C168
		[Token(Token = "0x6002097")]
		[Address(RVA = "0xAE10A0", Offset = "0xAE00A0", VA = "0x180AE10A0")]
		internal int <CheckEnabled>b__5_0(Human p1, Human p2)
		{
			return 0;
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x0000DF80 File Offset: 0x0000C180
		[Token(Token = "0x6002098")]
		[Address(RVA = "0x799570", Offset = "0x798570", VA = "0x180799570")]
		internal int <CheckEnabled>b__5_3(Acquaintance p2, Acquaintance p1)
		{
			return 0;
		}

		// Token: 0x04002A24 RID: 10788
		[Token(Token = "0x4002A24")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AddressBookController.<>c <>9;

		// Token: 0x04002A25 RID: 10789
		[Token(Token = "0x4002A25")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Interactable.Passed> <>9__5_1;

		// Token: 0x04002A26 RID: 10790
		[Token(Token = "0x4002A26")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<Interactable.Passed> <>9__5_2;

		// Token: 0x04002A27 RID: 10791
		[Token(Token = "0x4002A27")]
		[FieldOffset(Offset = "0x18")]
		public static Comparison<Human> <>9__5_0;

		// Token: 0x04002A28 RID: 10792
		[Token(Token = "0x4002A28")]
		[FieldOffset(Offset = "0x20")]
		public static Comparison<Acquaintance> <>9__5_3;
	}
}
