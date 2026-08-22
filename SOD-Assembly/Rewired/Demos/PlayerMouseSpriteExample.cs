using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x0200097B RID: 2427
	[Token(Token = "0x200097B")]
	public class PlayerMouseSpriteExample : MonoBehaviour
	{
		// Token: 0x06003416 RID: 13334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003416")]
		[Address(RVA = "0xD4B2E0", Offset = "0xD4A2E0", VA = "0x180D4B2E0")]
		private void Awake()
		{
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003417")]
		[Address(RVA = "0xD4B9F0", Offset = "0xD4A9F0", VA = "0x180D4B9F0")]
		private void Update()
		{
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003418")]
		[Address(RVA = "0xD4BD80", Offset = "0xD4AD80", VA = "0x180D4BD80")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003419")]
		[Address(RVA = "0xD4BE90", Offset = "0xD4AE90", VA = "0x180D4BE90")]
		private void CreateClickEffect(Color color)
		{
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341A")]
		[Address(RVA = "0xD4C280", Offset = "0xD4B280", VA = "0x180D4C280")]
		private void OnScreenPositionChanged(Vector2 position)
		{
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341B")]
		[Address(RVA = "0xD4C430", Offset = "0xD4B430", VA = "0x180D4C430")]
		public PlayerMouseSpriteExample()
		{
		}

		// Token: 0x0400509E RID: 20638
		[Token(Token = "0x400509E")]
		[FieldOffset(Offset = "0x18")]
		public int playerId;

		// Token: 0x0400509F RID: 20639
		[Token(Token = "0x400509F")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAction;

		// Token: 0x040050A0 RID: 20640
		[Token(Token = "0x40050A0")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAction;

		// Token: 0x040050A1 RID: 20641
		[Token(Token = "0x40050A1")]
		[FieldOffset(Offset = "0x30")]
		public string wheelAction;

		// Token: 0x040050A2 RID: 20642
		[Token(Token = "0x40050A2")]
		[FieldOffset(Offset = "0x38")]
		public string leftButtonAction;

		// Token: 0x040050A3 RID: 20643
		[Token(Token = "0x40050A3")]
		[FieldOffset(Offset = "0x40")]
		public string rightButtonAction;

		// Token: 0x040050A4 RID: 20644
		[Token(Token = "0x40050A4")]
		[FieldOffset(Offset = "0x48")]
		public string middleButtonAction;

		// Token: 0x040050A5 RID: 20645
		[Token(Token = "0x40050A5")]
		[FieldOffset(Offset = "0x50")]
		public float distanceFromCamera;

		// Token: 0x040050A6 RID: 20646
		[Token(Token = "0x40050A6")]
		[FieldOffset(Offset = "0x54")]
		public float spriteScale;

		// Token: 0x040050A7 RID: 20647
		[Token(Token = "0x40050A7")]
		[FieldOffset(Offset = "0x58")]
		public GameObject pointerPrefab;

		// Token: 0x040050A8 RID: 20648
		[Token(Token = "0x40050A8")]
		[FieldOffset(Offset = "0x60")]
		public GameObject clickEffectPrefab;

		// Token: 0x040050A9 RID: 20649
		[Token(Token = "0x40050A9")]
		[FieldOffset(Offset = "0x68")]
		public bool hideHardwarePointer;

		// Token: 0x040050AA RID: 20650
		[Token(Token = "0x40050AA")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private GameObject pointer;

		// Token: 0x040050AB RID: 20651
		[Token(Token = "0x40050AB")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private PlayerMouse mouse;
	}
}
