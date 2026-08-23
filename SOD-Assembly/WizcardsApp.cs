using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002F7 RID: 759
[Token(Token = "0x20002F7")]
public class WizcardsApp : CruncherAppContent
{
	// Token: 0x060010AF RID: 4271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010AF")]
	[Address(RVA = "0x6AB060", Offset = "0x6AA060", VA = "0x1806AB060")]
	public void StartMatch()
	{
	}

	// Token: 0x060010B0 RID: 4272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010B0")]
	[Address(RVA = "0x6AB430", Offset = "0x6AA430", VA = "0x1806AB430")]
	public void PlayerTurn()
	{
	}

	// Token: 0x060010B1 RID: 4273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010B1")]
	[Address(RVA = "0x6AB4A0", Offset = "0x6AA4A0", VA = "0x1806AB4A0")]
	public void EnemyTurn()
	{
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010B2")]
	[Address(RVA = "0x6AB550", Offset = "0x6AA550", VA = "0x1806AB550")]
	private IEnumerator CO_EnemyTurn()
	{
		return null;
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010B3")]
	[Address(RVA = "0x6AB5F0", Offset = "0x6AA5F0", VA = "0x1806AB5F0")]
	public List<BoardSpace> UnoccupiedEnemyTerritory()
	{
		return null;
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010B4")]
	[Address(RVA = "0x6AB7C0", Offset = "0x6AA7C0", VA = "0x1806AB7C0")]
	public IEnumerator WarTurn()
	{
		return null;
	}

	// Token: 0x060010B5 RID: 4277 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010B5")]
	[Address(RVA = "0x6AB860", Offset = "0x6AA860", VA = "0x1806AB860")]
	public void Concede()
	{
	}

	// Token: 0x060010B6 RID: 4278 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010B6")]
	[Address(RVA = "0x6AB8B0", Offset = "0x6AA8B0", VA = "0x1806AB8B0")]
	public void GoToMainMenu()
	{
	}

	// Token: 0x060010B7 RID: 4279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010B7")]
	[Address(RVA = "0x68D560", Offset = "0x68C560", VA = "0x18068D560")]
	public void ExitButton()
	{
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010B8")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public WizcardsApp()
	{
	}

	// Token: 0x04001441 RID: 5185
	[Token(Token = "0x4001441")]
	[FieldOffset(Offset = "0x20")]
	public WizcardEnemyPlayer enemyPlayer;

	// Token: 0x04001442 RID: 5186
	[Token(Token = "0x4001442")]
	[FieldOffset(Offset = "0x28")]
	public Wizcard selectedWizcard;

	// Token: 0x04001443 RID: 5187
	[Token(Token = "0x4001443")]
	[FieldOffset(Offset = "0x30")]
	public List<Wizcard> wizcards;

	// Token: 0x04001444 RID: 5188
	[Token(Token = "0x4001444")]
	[FieldOffset(Offset = "0x38")]
	public List<BoardSpace> boardSpaces;

	// Token: 0x04001445 RID: 5189
	[Token(Token = "0x4001445")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI titleText;

	// Token: 0x04001446 RID: 5190
	[Token(Token = "0x4001446")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI infoText;

	// Token: 0x04001447 RID: 5191
	[Token(Token = "0x4001447")]
	[FieldOffset(Offset = "0x50")]
	public RawImage actorImage;

	// Token: 0x04001448 RID: 5192
	[Token(Token = "0x4001448")]
	[FieldOffset(Offset = "0x58")]
	public WizcardPlayer player;

	// Token: 0x04001449 RID: 5193
	[Token(Token = "0x4001449")]
	[FieldOffset(Offset = "0x60")]
	public bool currentlyAnimating;

	// Token: 0x0400144A RID: 5194
	[Token(Token = "0x400144A")]
	[FieldOffset(Offset = "0x61")]
	public bool isPlayerTurn;

	// Token: 0x0400144B RID: 5195
	[Token(Token = "0x400144B")]
	[FieldOffset(Offset = "0x68")]
	public GameObject crystalWizcard;

	// Token: 0x0400144C RID: 5196
	[Token(Token = "0x400144C")]
	[FieldOffset(Offset = "0x70")]
	public Wizcard playersCrystal;

	// Token: 0x0400144D RID: 5197
	[Token(Token = "0x400144D")]
	[FieldOffset(Offset = "0x78")]
	public Wizcard enemiesCrystal;

	// Token: 0x0400144E RID: 5198
	[Token(Token = "0x400144E")]
	[FieldOffset(Offset = "0x80")]
	public MatchEndText matchEndText;

	// Token: 0x0400144F RID: 5199
	[Token(Token = "0x400144F")]
	[FieldOffset(Offset = "0x88")]
	public GameObject MainMenuScene;

	// Token: 0x04001450 RID: 5200
	[Token(Token = "0x4001450")]
	[FieldOffset(Offset = "0x90")]
	public GameObject MatchScene;

	// Token: 0x04001451 RID: 5201
	[Token(Token = "0x4001451")]
	[FieldOffset(Offset = "0x98")]
	public GameObject EndTurnButton;

	// Token: 0x04001452 RID: 5202
	[Token(Token = "0x4001452")]
	[FieldOffset(Offset = "0xA0")]
	public DrawPile drawPile;

	// Token: 0x04001453 RID: 5203
	[Token(Token = "0x4001453")]
	[FieldOffset(Offset = "0xA8")]
	public JuiceController manaBarJuice;

	// Token: 0x04001454 RID: 5204
	[Token(Token = "0x4001454")]
	[FieldOffset(Offset = "0xB0")]
	public JuiceController manaStarJuice;

	// Token: 0x04001455 RID: 5205
	[Token(Token = "0x4001455")]
	[FieldOffset(Offset = "0xB8")]
	public JuiceController deckPileJuice;

	// Token: 0x04001456 RID: 5206
	[Token(Token = "0x4001456")]
	[FieldOffset(Offset = "0xC0")]
	public AudioEvent lowManaAudioEvent;

	// Token: 0x04001457 RID: 5207
	[Token(Token = "0x4001457")]
	[FieldOffset(Offset = "0xC8")]
	private bool completedWarTurn;

	// Token: 0x020002F8 RID: 760
	[Token(Token = "0x20002F8")]
	private sealed class <CO_EnemyTurn>d__26 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060010B9 RID: 4281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B9")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <CO_EnemyTurn>d__26(int <>1__state)
		{
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x000085B0 File Offset: 0x000067B0
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0x6ABDC0", Offset = "0x6AADC0", VA = "0x1806ABDC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000088")]
		private object Current
		{
			[Token(Token = "0x60010BC")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x6AC2D0", Offset = "0x6AB2D0", VA = "0x1806AC2D0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060010BE RID: 4286 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000089")]
		private object Current
		{
			[Token(Token = "0x60010BE")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001458 RID: 5208
		[Token(Token = "0x4001458")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001459 RID: 5209
		[Token(Token = "0x4001459")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400145A RID: 5210
		[Token(Token = "0x400145A")]
		[FieldOffset(Offset = "0x20")]
		public WizcardsApp <>4__this;
	}

	// Token: 0x020002F9 RID: 761
	[Token(Token = "0x20002F9")]
	private sealed class <WarTurn>d__28 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060010BF RID: 4287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BF")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <WarTurn>d__28(int <>1__state)
		{
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x000085C8 File Offset: 0x000067C8
		[Token(Token = "0x60010C1")]
		[Address(RVA = "0x6AC320", Offset = "0x6AB320", VA = "0x1806AC320", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700008A")]
		private object Current
		{
			[Token(Token = "0x60010C2")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C3")]
		[Address(RVA = "0x6AD1C0", Offset = "0x6AC1C0", VA = "0x1806AD1C0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700008B")]
		private object Current
		{
			[Token(Token = "0x60010C4")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400145B RID: 5211
		[Token(Token = "0x400145B")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400145C RID: 5212
		[Token(Token = "0x400145C")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400145D RID: 5213
		[Token(Token = "0x400145D")]
		[FieldOffset(Offset = "0x20")]
		public WizcardsApp <>4__this;

		// Token: 0x0400145E RID: 5214
		[Token(Token = "0x400145E")]
		[FieldOffset(Offset = "0x28")]
		private int <i>5__2;
	}
}
