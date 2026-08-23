using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos
{
	// Token: 0x02000975 RID: 2421
	[Token(Token = "0x2000975")]
	public class TouchJoystickExample : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>
	{
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060033EC RID: 13292 RVA: 0x000124E0 File Offset: 0x000106E0
		// (set) Token: 0x060033ED RID: 13293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052F")]
		public Vector2 position
		{
			[Token(Token = "0x60033EC")]
			[Address(RVA = "0xD47360", Offset = "0xD46360", VA = "0x180D47360")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60033ED")]
			[Address(RVA = "0xD47380", Offset = "0xD46380", VA = "0x180D47380")]
			private set
			{
			}
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EE")]
		[Address(RVA = "0xD47390", Offset = "0xD46390", VA = "0x180D47390")]
		private void Start()
		{
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EF")]
		[Address(RVA = "0xD473F0", Offset = "0xD463F0", VA = "0x180D473F0")]
		private void Update()
		{
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F0")]
		[Address(RVA = "0xD47500", Offset = "0xD46500", VA = "0x180D47500")]
		private void Restart()
		{
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F1")]
		[Address(RVA = "0xD47650", Offset = "0xD46650", VA = "0x180D47650")]
		private void StoreOrigValues()
		{
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F2")]
		[Address(RVA = "0xD47900", Offset = "0xD46900", VA = "0x180D47900")]
		private void UpdateValue(Vector3 value)
		{
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F3")]
		[Address(RVA = "0xD47950", Offset = "0xD46950", VA = "0x180D47950", Slot = "4")]
		private void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F4")]
		[Address(RVA = "0xD479A0", Offset = "0xD469A0", VA = "0x180D479A0", Slot = "5")]
		private void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F5")]
		[Address(RVA = "0xD479F0", Offset = "0xD469F0", VA = "0x180D479F0", Slot = "6")]
		private void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x000124F8 File Offset: 0x000106F8
		[Token(Token = "0x60033F6")]
		[Address(RVA = "0xD47340", Offset = "0xD46340", VA = "0x180D47340")]
		private static bool IsMousePointerId(int id)
		{
			return default(bool);
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F7")]
		[Address(RVA = "0xD47BC0", Offset = "0xD46BC0", VA = "0x180D47BC0")]
		public TouchJoystickExample()
		{
		}

		// Token: 0x04005079 RID: 20601
		[Token(Token = "0x4005079")]
		[FieldOffset(Offset = "0x18")]
		public bool allowMouseControl;

		// Token: 0x0400507A RID: 20602
		[Token(Token = "0x400507A")]
		[FieldOffset(Offset = "0x1C")]
		public int radius;

		// Token: 0x0400507B RID: 20603
		[Token(Token = "0x400507B")]
		[FieldOffset(Offset = "0x20")]
		private Vector2 origAnchoredPosition;

		// Token: 0x0400507C RID: 20604
		[Token(Token = "0x400507C")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 origWorldPosition;

		// Token: 0x0400507D RID: 20605
		[Token(Token = "0x400507D")]
		[FieldOffset(Offset = "0x34")]
		private Vector2 origScreenResolution;

		// Token: 0x0400507E RID: 20606
		[Token(Token = "0x400507E")]
		[FieldOffset(Offset = "0x3C")]
		private ScreenOrientation origScreenOrientation;

		// Token: 0x0400507F RID: 20607
		[Token(Token = "0x400507F")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		private bool hasFinger;

		// Token: 0x04005080 RID: 20608
		[Token(Token = "0x4005080")]
		[FieldOffset(Offset = "0x44")]
		[NonSerialized]
		private int lastFingerId;

		// Token: 0x04005081 RID: 20609
		[Token(Token = "0x4005081")]
		[FieldOffset(Offset = "0x48")]
		private Vector2 <position>k__BackingField;
	}
}
