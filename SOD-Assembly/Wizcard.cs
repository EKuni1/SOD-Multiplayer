using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002EE RID: 750
[Token(Token = "0x20002EE")]
[Serializable]
public class Wizcard : MonoBehaviour
{
	// Token: 0x06001086 RID: 4230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001086")]
	[Address(RVA = "0x6A56F0", Offset = "0x6A46F0", VA = "0x1806A56F0")]
	private void Update()
	{
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001087")]
	[Address(RVA = "0x6A57B0", Offset = "0x6A47B0", VA = "0x1806A57B0")]
	private void Start()
	{
	}

	// Token: 0x06001088 RID: 4232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001088")]
	[Address(RVA = "0x6A5A30", Offset = "0x6A4A30", VA = "0x1806A5A30")]
	public void FindApp()
	{
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001089")]
	[Address(RVA = "0x6A5B20", Offset = "0x6A4B20", VA = "0x1806A5B20")]
	public void UpdateStatVisuals()
	{
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x00008520 File Offset: 0x00006720
	[Token(Token = "0x600108A")]
	[Address(RVA = "0x6A5F90", Offset = "0x6A4F90", VA = "0x1806A5F90")]
	private bool IsCursorOverCard()
	{
		return default(bool);
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600108B")]
	[Address(RVA = "0x6A6300", Offset = "0x6A5300", VA = "0x1806A6300")]
	public void PickUp()
	{
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600108C")]
	[Address(RVA = "0x6A67A0", Offset = "0x6A57A0", VA = "0x1806A67A0")]
	public void ChangeVisibility(bool visible)
	{
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600108D")]
	[Address(RVA = "0x6A6E40", Offset = "0x6A5E40", VA = "0x1806A6E40")]
	public void Buff()
	{
	}

	// Token: 0x0600108E RID: 4238 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600108E")]
	[Address(RVA = "0x6A6EF0", Offset = "0x6A5EF0", VA = "0x1806A6EF0")]
	public IEnumerator BuffCO()
	{
		return null;
	}

	// Token: 0x0600108F RID: 4239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600108F")]
	[Address(RVA = "0x6A6F90", Offset = "0x6A5F90", VA = "0x1806A6F90")]
	public void Move()
	{
	}

	// Token: 0x06001090 RID: 4240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001090")]
	[Address(RVA = "0x6A7B40", Offset = "0x6A6B40", VA = "0x1806A7B40")]
	public void Summon()
	{
	}

	// Token: 0x06001091 RID: 4241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001091")]
	[Address(RVA = "0x6A82A0", Offset = "0x6A72A0", VA = "0x1806A82A0")]
	public void Attack()
	{
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001092")]
	[Address(RVA = "0x6A8350", Offset = "0x6A7350", VA = "0x1806A8350")]
	public IEnumerator AttackCO()
	{
		return null;
	}

	// Token: 0x06001093 RID: 4243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001093")]
	[Address(RVA = "0x6A83F0", Offset = "0x6A73F0", VA = "0x1806A83F0")]
	public void Die()
	{
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001094")]
	[Address(RVA = "0x6A86C0", Offset = "0x6A76C0", VA = "0x1806A86C0")]
	public Wizcard()
	{
	}

	// Token: 0x04001406 RID: 5126
	[Token(Token = "0x4001406")]
	[FieldOffset(Offset = "0x18")]
	public string cardName;

	// Token: 0x04001407 RID: 5127
	[Token(Token = "0x4001407")]
	[FieldOffset(Offset = "0x20")]
	public string cardDescription;

	// Token: 0x04001408 RID: 5128
	[Token(Token = "0x4001408")]
	[FieldOffset(Offset = "0x28")]
	public int attack;

	// Token: 0x04001409 RID: 5129
	[Token(Token = "0x4001409")]
	[FieldOffset(Offset = "0x2C")]
	public int health;

	// Token: 0x0400140A RID: 5130
	[Token(Token = "0x400140A")]
	[FieldOffset(Offset = "0x30")]
	public int startHealth;

	// Token: 0x0400140B RID: 5131
	[Token(Token = "0x400140B")]
	[FieldOffset(Offset = "0x34")]
	public int mana;

	// Token: 0x0400140C RID: 5132
	[Token(Token = "0x400140C")]
	[FieldOffset(Offset = "0x38")]
	public int manaPerTurn;

	// Token: 0x0400140D RID: 5133
	[Token(Token = "0x400140D")]
	[FieldOffset(Offset = "0x40")]
	public Sprite[] boardSprites;

	// Token: 0x0400140E RID: 5134
	[Token(Token = "0x400140E")]
	[FieldOffset(Offset = "0x48")]
	public CardSpace cardSpace;

	// Token: 0x0400140F RID: 5135
	[Token(Token = "0x400140F")]
	[FieldOffset(Offset = "0x50")]
	public bool occupySpace;

	// Token: 0x04001410 RID: 5136
	[Token(Token = "0x4001410")]
	[FieldOffset(Offset = "0x51")]
	public bool enemy;

	// Token: 0x04001411 RID: 5137
	[Token(Token = "0x4001411")]
	[FieldOffset(Offset = "0x58")]
	public SpecialInteraction[] specialInteractions;

	// Token: 0x04001412 RID: 5138
	[Token(Token = "0x4001412")]
	[FieldOffset(Offset = "0x60")]
	public Wizcard.Labels labels;

	// Token: 0x04001413 RID: 5139
	[Token(Token = "0x4001413")]
	[FieldOffset(Offset = "0x68")]
	public bool[] moveSpaces;

	// Token: 0x04001414 RID: 5140
	[Token(Token = "0x4001414")]
	[FieldOffset(Offset = "0x70")]
	public bool[] spawnSpaces;

	// Token: 0x04001415 RID: 5141
	[Token(Token = "0x4001415")]
	[FieldOffset(Offset = "0x78")]
	public bool[] attackSpaces;

	// Token: 0x04001416 RID: 5142
	[Token(Token = "0x4001416")]
	[FieldOffset(Offset = "0x80")]
	public bool[] buffSpaces;

	// Token: 0x04001417 RID: 5143
	[Token(Token = "0x4001417")]
	[FieldOffset(Offset = "0x88")]
	private WizcardsApp app;

	// Token: 0x04001418 RID: 5144
	[Token(Token = "0x4001418")]
	[FieldOffset(Offset = "0x90")]
	public int myBoardSpace;

	// Token: 0x04001419 RID: 5145
	[Token(Token = "0x4001419")]
	[FieldOffset(Offset = "0x94")]
	public bool isHovered;

	// Token: 0x0400141A RID: 5146
	[Token(Token = "0x400141A")]
	[FieldOffset(Offset = "0x98")]
	private ComputerController comp;

	// Token: 0x0400141B RID: 5147
	[Token(Token = "0x400141B")]
	[FieldOffset(Offset = "0xA0")]
	private ComputerOSUIComponent hoverComponent;

	// Token: 0x0400141C RID: 5148
	[Token(Token = "0x400141C")]
	[FieldOffset(Offset = "0xA8")]
	private RectTransform rectTransform;

	// Token: 0x020002EF RID: 751
	[Token(Token = "0x20002EF")]
	public enum Labels
	{
		// Token: 0x0400141E RID: 5150
		[Token(Token = "0x400141E")]
		None,
		// Token: 0x0400141F RID: 5151
		[Token(Token = "0x400141F")]
		Monster,
		// Token: 0x04001420 RID: 5152
		[Token(Token = "0x4001420")]
		Animal,
		// Token: 0x04001421 RID: 5153
		[Token(Token = "0x4001421")]
		Building = 4,
		// Token: 0x04001422 RID: 5154
		[Token(Token = "0x4001422")]
		Metallic = 8,
		// Token: 0x04001423 RID: 5155
		[Token(Token = "0x4001423")]
		Wooden = 16,
		// Token: 0x04001424 RID: 5156
		[Token(Token = "0x4001424")]
		Human = 32,
		// Token: 0x04001425 RID: 5157
		[Token(Token = "0x4001425")]
		Mage = 64,
		// Token: 0x04001426 RID: 5158
		[Token(Token = "0x4001426")]
		Fabric = 128
	}

	// Token: 0x020002F0 RID: 752
	[Token(Token = "0x20002F0")]
	private sealed class <BuffCO>d__32 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001095 RID: 4245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001095")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <BuffCO>d__32(int <>1__state)
		{
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001096")]
		[Address(RVA = "0x6A88C0", Offset = "0x6A78C0", VA = "0x1806A88C0", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00008538 File Offset: 0x00006738
		[Token(Token = "0x6001097")]
		[Address(RVA = "0x6A8980", Offset = "0x6A7980", VA = "0x1806A8980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001098")]
		[Address(RVA = "0x6A98F0", Offset = "0x6A88F0", VA = "0x1806A98F0")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000082")]
		private object Current
		{
			[Token(Token = "0x6001099")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109A")]
		[Address(RVA = "0x6A9940", Offset = "0x6A8940", VA = "0x1806A9940", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000083")]
		private object Current
		{
			[Token(Token = "0x600109B")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001427 RID: 5159
		[Token(Token = "0x4001427")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001428 RID: 5160
		[Token(Token = "0x4001428")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001429 RID: 5161
		[Token(Token = "0x4001429")]
		[FieldOffset(Offset = "0x20")]
		public Wizcard <>4__this;

		// Token: 0x0400142A RID: 5162
		[Token(Token = "0x400142A")]
		[FieldOffset(Offset = "0x28")]
		private SpecialInteraction[] <>7__wrap1;

		// Token: 0x0400142B RID: 5163
		[Token(Token = "0x400142B")]
		[FieldOffset(Offset = "0x30")]
		private int <>7__wrap2;

		// Token: 0x0400142C RID: 5164
		[Token(Token = "0x400142C")]
		[FieldOffset(Offset = "0x38")]
		private SpecialInteraction <specialInteraction>5__4;

		// Token: 0x0400142D RID: 5165
		[Token(Token = "0x400142D")]
		[FieldOffset(Offset = "0x60")]
		private List<Wizcard>.Enumerator <>7__wrap4;
	}

	// Token: 0x020002F1 RID: 753
	[Token(Token = "0x20002F1")]
	private sealed class <AttackCO>d__36 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600109C RID: 4252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109C")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <AttackCO>d__36(int <>1__state)
		{
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109D")]
		[Address(RVA = "0x6A9990", Offset = "0x6A8990", VA = "0x1806A9990", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00008550 File Offset: 0x00006750
		[Token(Token = "0x600109E")]
		[Address(RVA = "0x6A9A50", Offset = "0x6A8A50", VA = "0x1806A9A50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109F")]
		[Address(RVA = "0x6AA5D0", Offset = "0x6A95D0", VA = "0x1806AA5D0")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000084")]
		private object Current
		{
			[Token(Token = "0x60010A0")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A1")]
		[Address(RVA = "0x6AA620", Offset = "0x6A9620", VA = "0x1806AA620", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000085")]
		private object Current
		{
			[Token(Token = "0x60010A2")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400142E RID: 5166
		[Token(Token = "0x400142E")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400142F RID: 5167
		[Token(Token = "0x400142F")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001430 RID: 5168
		[Token(Token = "0x4001430")]
		[FieldOffset(Offset = "0x20")]
		public Wizcard <>4__this;

		// Token: 0x04001431 RID: 5169
		[Token(Token = "0x4001431")]
		[FieldOffset(Offset = "0x28")]
		private List<Wizcard>.Enumerator <>7__wrap1;

		// Token: 0x04001432 RID: 5170
		[Token(Token = "0x4001432")]
		[FieldOffset(Offset = "0x40")]
		private Wizcard <wizcard>5__3;
	}
}
