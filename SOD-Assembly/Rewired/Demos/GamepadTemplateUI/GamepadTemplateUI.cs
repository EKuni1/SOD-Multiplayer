using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos.GamepadTemplateUI
{
	// Token: 0x0200099A RID: 2458
	[Token(Token = "0x200099A")]
	public class GamepadTemplateUI : MonoBehaviour
	{
		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060034CC RID: 13516 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000548")]
		private Player player
		{
			[Token(Token = "0x60034CC")]
			[Address(RVA = "0xD61300", Offset = "0xD60300", VA = "0x180D61300")]
			get
			{
				return null;
			}
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CD")]
		[Address(RVA = "0xD61370", Offset = "0xD60370", VA = "0x180D61370")]
		private void Awake()
		{
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CE")]
		[Address(RVA = "0xD62730", Offset = "0xD61730", VA = "0x180D62730")]
		private void Start()
		{
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CF")]
		[Address(RVA = "0xD627D0", Offset = "0xD617D0", VA = "0x180D627D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D0")]
		[Address(RVA = "0xD628C0", Offset = "0xD618C0", VA = "0x180D628C0")]
		private void Update()
		{
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D1")]
		[Address(RVA = "0xD62960", Offset = "0xD61960", VA = "0x180D62960")]
		private void DrawActiveElements()
		{
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D2")]
		[Address(RVA = "0xD62DE0", Offset = "0xD61DE0", VA = "0x180D62DE0")]
		private void ActivateElements(Player player, int actionId)
		{
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D3")]
		[Address(RVA = "0xD63230", Offset = "0xD62230", VA = "0x180D63230")]
		private void DrawLabels()
		{
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D4")]
		[Address(RVA = "0xD634F0", Offset = "0xD624F0", VA = "0x180D634F0")]
		private void DrawLabels(Player player, InputAction action)
		{
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D5")]
		[Address(RVA = "0xD63820", Offset = "0xD62820", VA = "0x180D63820")]
		private void DrawLabel(ControllerUIElement uiElement, InputAction action, ControllerMap controllerMap, IControllerTemplate template, IControllerTemplateElement element)
		{
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034D6")]
		[Address(RVA = "0xD63BC0", Offset = "0xD62BC0", VA = "0x180D63BC0")]
		private GamepadTemplateUI.Stick GetStick(int elementId)
		{
			return null;
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D7")]
		[Address(RVA = "0xD63D80", Offset = "0xD62D80", VA = "0x180D63D80")]
		private void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D8")]
		[Address(RVA = "0xD63D80", Offset = "0xD62D80", VA = "0x180D63D80")]
		private void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D9")]
		[Address(RVA = "0xD63D90", Offset = "0xD62D90", VA = "0x180D63D90")]
		public GamepadTemplateUI()
		{
		}

		// Token: 0x0400515A RID: 20826
		[Token(Token = "0x400515A")]
		private const float stickRadius = 20f;

		// Token: 0x0400515B RID: 20827
		[Token(Token = "0x400515B")]
		[FieldOffset(Offset = "0x18")]
		public int playerId;

		// Token: 0x0400515C RID: 20828
		[Token(Token = "0x400515C")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform leftStick;

		// Token: 0x0400515D RID: 20829
		[Token(Token = "0x400515D")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform rightStick;

		// Token: 0x0400515E RID: 20830
		[Token(Token = "0x400515E")]
		[FieldOffset(Offset = "0x30")]
		private ControllerUIElement leftStickX;

		// Token: 0x0400515F RID: 20831
		[Token(Token = "0x400515F")]
		[FieldOffset(Offset = "0x38")]
		private ControllerUIElement leftStickY;

		// Token: 0x04005160 RID: 20832
		[Token(Token = "0x4005160")]
		[FieldOffset(Offset = "0x40")]
		private ControllerUIElement leftStickButton;

		// Token: 0x04005161 RID: 20833
		[Token(Token = "0x4005161")]
		[FieldOffset(Offset = "0x48")]
		private ControllerUIElement rightStickX;

		// Token: 0x04005162 RID: 20834
		[Token(Token = "0x4005162")]
		[FieldOffset(Offset = "0x50")]
		private ControllerUIElement rightStickY;

		// Token: 0x04005163 RID: 20835
		[Token(Token = "0x4005163")]
		[FieldOffset(Offset = "0x58")]
		private ControllerUIElement rightStickButton;

		// Token: 0x04005164 RID: 20836
		[Token(Token = "0x4005164")]
		[FieldOffset(Offset = "0x60")]
		private ControllerUIElement actionBottomRow1;

		// Token: 0x04005165 RID: 20837
		[Token(Token = "0x4005165")]
		[FieldOffset(Offset = "0x68")]
		private ControllerUIElement actionBottomRow2;

		// Token: 0x04005166 RID: 20838
		[Token(Token = "0x4005166")]
		[FieldOffset(Offset = "0x70")]
		private ControllerUIElement actionBottomRow3;

		// Token: 0x04005167 RID: 20839
		[Token(Token = "0x4005167")]
		[FieldOffset(Offset = "0x78")]
		private ControllerUIElement actionTopRow1;

		// Token: 0x04005168 RID: 20840
		[Token(Token = "0x4005168")]
		[FieldOffset(Offset = "0x80")]
		private ControllerUIElement actionTopRow2;

		// Token: 0x04005169 RID: 20841
		[Token(Token = "0x4005169")]
		[FieldOffset(Offset = "0x88")]
		private ControllerUIElement actionTopRow3;

		// Token: 0x0400516A RID: 20842
		[Token(Token = "0x400516A")]
		[FieldOffset(Offset = "0x90")]
		private ControllerUIElement leftShoulder;

		// Token: 0x0400516B RID: 20843
		[Token(Token = "0x400516B")]
		[FieldOffset(Offset = "0x98")]
		private ControllerUIElement leftTrigger;

		// Token: 0x0400516C RID: 20844
		[Token(Token = "0x400516C")]
		[FieldOffset(Offset = "0xA0")]
		private ControllerUIElement rightShoulder;

		// Token: 0x0400516D RID: 20845
		[Token(Token = "0x400516D")]
		[FieldOffset(Offset = "0xA8")]
		private ControllerUIElement rightTrigger;

		// Token: 0x0400516E RID: 20846
		[Token(Token = "0x400516E")]
		[FieldOffset(Offset = "0xB0")]
		private ControllerUIElement center1;

		// Token: 0x0400516F RID: 20847
		[Token(Token = "0x400516F")]
		[FieldOffset(Offset = "0xB8")]
		private ControllerUIElement center2;

		// Token: 0x04005170 RID: 20848
		[Token(Token = "0x4005170")]
		[FieldOffset(Offset = "0xC0")]
		private ControllerUIElement center3;

		// Token: 0x04005171 RID: 20849
		[Token(Token = "0x4005171")]
		[FieldOffset(Offset = "0xC8")]
		private ControllerUIElement dPadUp;

		// Token: 0x04005172 RID: 20850
		[Token(Token = "0x4005172")]
		[FieldOffset(Offset = "0xD0")]
		private ControllerUIElement dPadRight;

		// Token: 0x04005173 RID: 20851
		[Token(Token = "0x4005173")]
		[FieldOffset(Offset = "0xD8")]
		private ControllerUIElement dPadDown;

		// Token: 0x04005174 RID: 20852
		[Token(Token = "0x4005174")]
		[FieldOffset(Offset = "0xE0")]
		private ControllerUIElement dPadLeft;

		// Token: 0x04005175 RID: 20853
		[Token(Token = "0x4005175")]
		[FieldOffset(Offset = "0xE8")]
		private GamepadTemplateUI.UIElement[] _uiElementsArray;

		// Token: 0x04005176 RID: 20854
		[Token(Token = "0x4005176")]
		[FieldOffset(Offset = "0xF0")]
		private Dictionary<int, ControllerUIElement> _uiElements;

		// Token: 0x04005177 RID: 20855
		[Token(Token = "0x4005177")]
		[FieldOffset(Offset = "0xF8")]
		private IList<ControllerTemplateElementTarget> _tempTargetList;

		// Token: 0x04005178 RID: 20856
		[Token(Token = "0x4005178")]
		[FieldOffset(Offset = "0x100")]
		private GamepadTemplateUI.Stick[] _sticks;

		// Token: 0x0200099B RID: 2459
		[Token(Token = "0x200099B")]
		private class Stick
		{
			// Token: 0x17000549 RID: 1353
			// (get) Token: 0x060034DA RID: 13530 RVA: 0x00012630 File Offset: 0x00010830
			// (set) Token: 0x060034DB RID: 13531 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000549")]
			public Vector2 position
			{
				[Token(Token = "0x60034DA")]
				[Address(RVA = "0xD63FE0", Offset = "0xD62FE0", VA = "0x180D63FE0")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x60034DB")]
				[Address(RVA = "0xD64170", Offset = "0xD63170", VA = "0x180D64170")]
				set
				{
				}
			}

			// Token: 0x060034DC RID: 13532 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034DC")]
			[Address(RVA = "0xD642F0", Offset = "0xD632F0", VA = "0x180D642F0")]
			public Stick(RectTransform transform, int xAxisElementId, int yAxisElementId)
			{
			}

			// Token: 0x060034DD RID: 13533 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034DD")]
			[Address(RVA = "0xD64490", Offset = "0xD63490", VA = "0x180D64490")]
			public void Reset()
			{
			}

			// Token: 0x060034DE RID: 13534 RVA: 0x00012648 File Offset: 0x00010848
			[Token(Token = "0x60034DE")]
			[Address(RVA = "0xD64600", Offset = "0xD63600", VA = "0x180D64600")]
			public bool ContainsElement(int elementId)
			{
				return default(bool);
			}

			// Token: 0x060034DF RID: 13535 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034DF")]
			[Address(RVA = "0xD64740", Offset = "0xD63740", VA = "0x180D64740")]
			public void SetAxisPosition(int elementId, float value)
			{
			}

			// Token: 0x04005179 RID: 20857
			[Token(Token = "0x4005179")]
			[FieldOffset(Offset = "0x10")]
			private RectTransform _transform;

			// Token: 0x0400517A RID: 20858
			[Token(Token = "0x400517A")]
			[FieldOffset(Offset = "0x18")]
			private Vector2 _origPosition;

			// Token: 0x0400517B RID: 20859
			[Token(Token = "0x400517B")]
			[FieldOffset(Offset = "0x20")]
			private int _xAxisElementId;

			// Token: 0x0400517C RID: 20860
			[Token(Token = "0x400517C")]
			[FieldOffset(Offset = "0x24")]
			private int _yAxisElementId;
		}

		// Token: 0x0200099C RID: 2460
		[Token(Token = "0x200099C")]
		private class UIElement
		{
			// Token: 0x060034E0 RID: 13536 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034E0")]
			[Address(RVA = "0xD64B40", Offset = "0xD63B40", VA = "0x180D64B40")]
			public UIElement(int id, ControllerUIElement element)
			{
			}

			// Token: 0x0400517D RID: 20861
			[Token(Token = "0x400517D")]
			[FieldOffset(Offset = "0x10")]
			public int id;

			// Token: 0x0400517E RID: 20862
			[Token(Token = "0x400517E")]
			[FieldOffset(Offset = "0x18")]
			public ControllerUIElement element;
		}
	}
}
