using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos
{
	// Token: 0x0200097D RID: 2429
	[Token(Token = "0x200097D")]
	public sealed class UIPointer : UIBehaviour
	{
		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06003429 RID: 13353 RVA: 0x00012528 File Offset: 0x00010728
		// (set) Token: 0x0600342A RID: 13354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000531")]
		public bool autoSort
		{
			[Token(Token = "0x6003429")]
			[Address(RVA = "0xCDB320", Offset = "0xCDA320", VA = "0x180CDB320")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600342A")]
			[Address(RVA = "0xD4F6B0", Offset = "0xD4E6B0", VA = "0x180D4F6B0")]
			set
			{
			}
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600342B")]
		[Address(RVA = "0xD4F760", Offset = "0xD4E760", VA = "0x180D4F760", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600342C")]
		[Address(RVA = "0xD4F900", Offset = "0xD4E900", VA = "0x180D4F900")]
		private void Update()
		{
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600342D")]
		[Address(RVA = "0xD4FB50", Offset = "0xD4EB50", VA = "0x180D4FB50", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600342E")]
		[Address(RVA = "0xD4FB50", Offset = "0xD4EB50", VA = "0x180D4FB50", Slot = "14")]
		protected override void OnCanvasGroupChanged()
		{
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600342F")]
		[Address(RVA = "0xD4FB60", Offset = "0xD4EB60", VA = "0x180D4FB60")]
		public void OnScreenPositionChanged(Vector2 screenPosition)
		{
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003430")]
		[Address(RVA = "0xD4FF70", Offset = "0xD4EF70", VA = "0x180D4FF70")]
		private void GetDependencies()
		{
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003431")]
		[Address(RVA = "0xD500A0", Offset = "0xD4F0A0", VA = "0x180D500A0")]
		public UIPointer()
		{
		}

		// Token: 0x040050AF RID: 20655
		[Token(Token = "0x40050AF")]
		[FieldOffset(Offset = "0x18")]
		private bool _hideHardwarePointer;

		// Token: 0x040050B0 RID: 20656
		[Token(Token = "0x40050B0")]
		[FieldOffset(Offset = "0x19")]
		private bool _autoSort;

		// Token: 0x040050B1 RID: 20657
		[Token(Token = "0x40050B1")]
		[FieldOffset(Offset = "0x20")]
		private Canvas _canvas;
	}
}
