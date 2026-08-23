using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.ControllerExtensions;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x02000976 RID: 2422
	[Token(Token = "0x2000976")]
	public class DualShock4SpecialFeaturesExample : MonoBehaviour
	{
		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060033F8 RID: 13304 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000530")]
		private Player player
		{
			[Token(Token = "0x60033F8")]
			[Address(RVA = "0xD47C10", Offset = "0xD46C10", VA = "0x180D47C10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F9")]
		[Address(RVA = "0xD47C80", Offset = "0xD46C80", VA = "0x180D47C80")]
		private void Awake()
		{
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FA")]
		[Address(RVA = "0xD47C90", Offset = "0xD46C90", VA = "0x180D47C90")]
		private void Update()
		{
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FB")]
		[Address(RVA = "0xD48300", Offset = "0xD47300", VA = "0x180D48300")]
		private void OnGUI()
		{
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FC")]
		[Address(RVA = "0xD48AA0", Offset = "0xD47AA0", VA = "0x180D48AA0")]
		private void ResetOrientation()
		{
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FD")]
		[Address(RVA = "0xD48B60", Offset = "0xD47B60", VA = "0x180D48B60")]
		private void SetRandomLightColor()
		{
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FE")]
		[Address(RVA = "0xD48E70", Offset = "0xD47E70", VA = "0x180D48E70")]
		private void StartLightFlash()
		{
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FF")]
		[Address(RVA = "0xD49030", Offset = "0xD48030", VA = "0x180D49030")]
		private void StopLightFlash()
		{
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003400")]
		[Address(RVA = "0xD491C0", Offset = "0xD481C0", VA = "0x180D491C0")]
		private IDualShock4Extension GetFirstDS4(Player player)
		{
			return null;
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003401")]
		[Address(RVA = "0xD49460", Offset = "0xD48460", VA = "0x180D49460")]
		private void InitializeTouchObjects()
		{
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003402")]
		[Address(RVA = "0xD499F0", Offset = "0xD489F0", VA = "0x180D499F0")]
		private void HandleTouchpad(IDualShock4Extension ds4)
		{
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003403")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public DualShock4SpecialFeaturesExample()
		{
		}

		// Token: 0x04005082 RID: 20610
		[Token(Token = "0x4005082")]
		private const int maxTouches = 2;

		// Token: 0x04005083 RID: 20611
		[Token(Token = "0x4005083")]
		[FieldOffset(Offset = "0x18")]
		public int playerId;

		// Token: 0x04005084 RID: 20612
		[Token(Token = "0x4005084")]
		[FieldOffset(Offset = "0x20")]
		public Transform touchpadTransform;

		// Token: 0x04005085 RID: 20613
		[Token(Token = "0x4005085")]
		[FieldOffset(Offset = "0x28")]
		public GameObject lightObject;

		// Token: 0x04005086 RID: 20614
		[Token(Token = "0x4005086")]
		[FieldOffset(Offset = "0x30")]
		public Transform accelerometerTransform;

		// Token: 0x04005087 RID: 20615
		[Token(Token = "0x4005087")]
		[FieldOffset(Offset = "0x38")]
		private List<DualShock4SpecialFeaturesExample.Touch> touches;

		// Token: 0x04005088 RID: 20616
		[Token(Token = "0x4005088")]
		[FieldOffset(Offset = "0x40")]
		private Queue<DualShock4SpecialFeaturesExample.Touch> unusedTouches;

		// Token: 0x04005089 RID: 20617
		[Token(Token = "0x4005089")]
		[FieldOffset(Offset = "0x48")]
		private bool isFlashing;

		// Token: 0x0400508A RID: 20618
		[Token(Token = "0x400508A")]
		[FieldOffset(Offset = "0x50")]
		private GUIStyle textStyle;

		// Token: 0x02000977 RID: 2423
		[Token(Token = "0x2000977")]
		private class Touch
		{
			// Token: 0x06003404 RID: 13316 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003404")]
			[Address(RVA = "0x9BB130", Offset = "0x9BA130", VA = "0x1809BB130")]
			public Touch()
			{
			}

			// Token: 0x0400508B RID: 20619
			[Token(Token = "0x400508B")]
			[FieldOffset(Offset = "0x10")]
			public GameObject go;

			// Token: 0x0400508C RID: 20620
			[Token(Token = "0x400508C")]
			[FieldOffset(Offset = "0x18")]
			public int touchId;
		}

		// Token: 0x02000978 RID: 2424
		[Token(Token = "0x2000978")]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x06003405 RID: 13317 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003405")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x06003406 RID: 13318 RVA: 0x00012510 File Offset: 0x00010710
			[Token(Token = "0x6003406")]
			[Address(RVA = "0x80D810", Offset = "0x80C810", VA = "0x18080D810")]
			internal bool <HandleTouchpad>b__0(DualShock4SpecialFeaturesExample.Touch x)
			{
				return default(bool);
			}

			// Token: 0x0400508D RID: 20621
			[Token(Token = "0x400508D")]
			[FieldOffset(Offset = "0x10")]
			public int touchId;
		}
	}
}
