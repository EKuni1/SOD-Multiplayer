using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000691 RID: 1681
[Token(Token = "0x2000691")]
public class TooltipController : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x1400004C RID: 76
	// (add) Token: 0x06002544 RID: 9540 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002545 RID: 9541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400004C")]
	public event TooltipController.BeforeTooltipSpawn OnBeforeTooltipSpawn
	{
		[Token(Token = "0x6002544")]
		[Address(RVA = "0xBBA470", Offset = "0xBB9470", VA = "0x180BBA470")]
		add
		{
		}
		[Token(Token = "0x6002545")]
		[Address(RVA = "0xBBA570", Offset = "0xBB9570", VA = "0x180BBA570")]
		remove
		{
		}
	}

	// Token: 0x06002546 RID: 9542 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002546")]
	[Address(RVA = "0xBBA670", Offset = "0xBB9670", VA = "0x180BBA670")]
	private void Start()
	{
	}

	// Token: 0x06002547 RID: 9543 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002547")]
	[Address(RVA = "0xBBAA60", Offset = "0xBB9A60", VA = "0x180BBAA60", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06002548 RID: 9544 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002548")]
	[Address(RVA = "0xBBAAD0", Offset = "0xBB9AD0", VA = "0x180BBAAD0", Slot = "6")]
	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06002549 RID: 9545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002549")]
	[Address(RVA = "0xBBAC30", Offset = "0xBB9C30", VA = "0x180BBAC30", Slot = "7")]
	public virtual void OnButtonHover()
	{
	}

	// Token: 0x0600254A RID: 9546 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600254A")]
	[Address(RVA = "0xBBAC50", Offset = "0xBB9C50", VA = "0x180BBAC50", Slot = "8")]
	public virtual void OnButtonExitHover()
	{
	}

	// Token: 0x0600254B RID: 9547 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600254B")]
	[Address(RVA = "0xBBAC70", Offset = "0xBB9C70", VA = "0x180BBAC70", Slot = "9")]
	public virtual void SetPointerOver(bool val)
	{
	}

	// Token: 0x0600254C RID: 9548 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600254C")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "10")]
	public virtual void OnMouseEnterCustom()
	{
	}

	// Token: 0x0600254D RID: 9549 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600254D")]
	[Address(RVA = "0xBBAF60", Offset = "0xBB9F60", VA = "0x180BBAF60", Slot = "11")]
	public virtual void GetText()
	{
	}

	// Token: 0x0600254E RID: 9550 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600254E")]
	[Address(RVA = "0xBBB130", Offset = "0xBBA130", VA = "0x180BBB130")]
	private IEnumerator MouseOver()
	{
		return null;
	}

	// Token: 0x0600254F RID: 9551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600254F")]
	[Address(RVA = "0xBBB1D0", Offset = "0xBBA1D0", VA = "0x180BBB1D0")]
	public void OpenTooltip()
	{
	}

	// Token: 0x06002550 RID: 9552 RVA: 0x0000EB68 File Offset: 0x0000CD68
	[Token(Token = "0x6002550")]
	[Address(RVA = "0xBBC280", Offset = "0xBBB280", VA = "0x180BBC280")]
	private Vector2 ClampToWindow(Vector2 rawPointerPosition)
	{
		return default(Vector2);
	}

	// Token: 0x06002551 RID: 9553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002551")]
	[Address(RVA = "0xBBC450", Offset = "0xBBB450", VA = "0x180BBC450")]
	public void ClampThisOnscreen()
	{
	}

	// Token: 0x06002552 RID: 9554 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002552")]
	[Address(RVA = "0xBBCA40", Offset = "0xBBBA40", VA = "0x180BBCA40")]
	private void OnDisable()
	{
	}

	// Token: 0x06002553 RID: 9555 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002553")]
	[Address(RVA = "0xBBCB50", Offset = "0xBBBB50", VA = "0x180BBCB50")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002554 RID: 9556 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002554")]
	[Address(RVA = "0xBBCC60", Offset = "0xBBBC60", VA = "0x180BBCC60")]
	public static void RemoveActiveTooltip()
	{
	}

	// Token: 0x06002555 RID: 9557 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002555")]
	[Address(RVA = "0xBBCDA0", Offset = "0xBBBDA0", VA = "0x180BBCDA0")]
	public void ForceClose()
	{
	}

	// Token: 0x06002556 RID: 9558 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002556")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "12")]
	public virtual void OnMouseOverCustom()
	{
	}

	// Token: 0x06002557 RID: 9559 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002557")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "13")]
	public virtual void OnMouseOffCustom()
	{
	}

	// Token: 0x06002558 RID: 9560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002558")]
	[Address(RVA = "0xBBD280", Offset = "0xBBC280", VA = "0x180BBD280")]
	public TooltipController()
	{
	}

	// Token: 0x04002F8E RID: 12174
	[Token(Token = "0x4002F8E")]
	[FieldOffset(Offset = "0x18")]
	public bool tooltipEnabled;

	// Token: 0x04002F8F RID: 12175
	[Token(Token = "0x4002F8F")]
	[FieldOffset(Offset = "0x19")]
	public bool handleOwnBehaviour;

	// Token: 0x04002F90 RID: 12176
	[Token(Token = "0x4002F90")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform parentOverride;

	// Token: 0x04002F91 RID: 12177
	[Token(Token = "0x4002F91")]
	[FieldOffset(Offset = "0x28")]
	public bool useMainDictionaryEntry;

	// Token: 0x04002F92 RID: 12178
	[Token(Token = "0x4002F92")]
	[FieldOffset(Offset = "0x30")]
	public string mainDictionary;

	// Token: 0x04002F93 RID: 12179
	[Token(Token = "0x4002F93")]
	[FieldOffset(Offset = "0x38")]
	public string mainDictionaryKey;

	// Token: 0x04002F94 RID: 12180
	[Token(Token = "0x4002F94")]
	[FieldOffset(Offset = "0x40")]
	public bool useDetailDictionaryEntry;

	// Token: 0x04002F95 RID: 12181
	[Token(Token = "0x4002F95")]
	[FieldOffset(Offset = "0x48")]
	public string detailDictionary;

	// Token: 0x04002F96 RID: 12182
	[Token(Token = "0x4002F96")]
	[FieldOffset(Offset = "0x50")]
	public string detailDictionaryKey;

	// Token: 0x04002F97 RID: 12183
	[Token(Token = "0x4002F97")]
	[FieldOffset(Offset = "0x58")]
	public string mainText;

	// Token: 0x04002F98 RID: 12184
	[Token(Token = "0x4002F98")]
	[FieldOffset(Offset = "0x60")]
	public string detailText;

	// Token: 0x04002F99 RID: 12185
	[Token(Token = "0x4002F99")]
	[FieldOffset(Offset = "0x68")]
	public bool isOver;

	// Token: 0x04002F9A RID: 12186
	[Token(Token = "0x4002F9A")]
	[FieldOffset(Offset = "0x6C")]
	public float additionalSpawnDelay;

	// Token: 0x04002F9B RID: 12187
	[Token(Token = "0x4002F9B")]
	[FieldOffset(Offset = "0x70")]
	public float moTimer;

	// Token: 0x04002F9C RID: 12188
	[Token(Token = "0x4002F9C")]
	[FieldOffset(Offset = "0x78")]
	public GameObject spawnedTooltip;

	// Token: 0x04002F9D RID: 12189
	[Token(Token = "0x4002F9D")]
	[FieldOffset(Offset = "0x80")]
	public TextMeshProUGUI tooltipText;

	// Token: 0x04002F9E RID: 12190
	[Token(Token = "0x4002F9E")]
	[FieldOffset(Offset = "0x88")]
	public float fadeIn;

	// Token: 0x04002F9F RID: 12191
	[Token(Token = "0x4002F9F")]
	[FieldOffset(Offset = "0x90")]
	public CanvasRenderer rend;

	// Token: 0x04002FA0 RID: 12192
	[Token(Token = "0x4002FA0")]
	[FieldOffset(Offset = "0x98")]
	public CanvasRenderer textRend;

	// Token: 0x04002FA1 RID: 12193
	[Token(Token = "0x4002FA1")]
	[FieldOffset(Offset = "0xA0")]
	public Vector2 pos;

	// Token: 0x04002FA2 RID: 12194
	[Token(Token = "0x4002FA2")]
	[FieldOffset(Offset = "0xA8")]
	public bool useCursorPos;

	// Token: 0x04002FA3 RID: 12195
	[Token(Token = "0x4002FA3")]
	[FieldOffset(Offset = "0xAC")]
	public Vector2 cursorPosOffset;

	// Token: 0x04002FA4 RID: 12196
	[Token(Token = "0x4002FA4")]
	[FieldOffset(Offset = "0xB4")]
	public bool limitWidth;

	// Token: 0x04002FA5 RID: 12197
	[Token(Token = "0x4002FA5")]
	[FieldOffset(Offset = "0xB8")]
	public int extendTooltipWidth;

	// Token: 0x04002FA6 RID: 12198
	[Token(Token = "0x4002FA6")]
	[FieldOffset(Offset = "0xC0")]
	private Outline outline;

	// Token: 0x04002FA7 RID: 12199
	[Token(Token = "0x4002FA7")]
	[FieldOffset(Offset = "0xC8")]
	public bool enableOutlineMouseOver;

	// Token: 0x04002FA8 RID: 12200
	[Token(Token = "0x4002FA8")]
	[FieldOffset(Offset = "0xD0")]
	private Image img;

	// Token: 0x04002FA9 RID: 12201
	[Token(Token = "0x4002FA9")]
	[FieldOffset(Offset = "0xD8")]
	public Sprite mouseOverSprite;

	// Token: 0x04002FAA RID: 12202
	[Token(Token = "0x4002FAA")]
	[FieldOffset(Offset = "0xE0")]
	private Sprite originalSprite;

	// Token: 0x04002FAB RID: 12203
	[Token(Token = "0x4002FAB")]
	[FieldOffset(Offset = "0xE8")]
	public ContextMenuController contextMenuBelongingToThis;

	// Token: 0x04002FAC RID: 12204
	[Token(Token = "0x4002FAC")]
	[FieldOffset(Offset = "0xF0")]
	public bool updateTooltipPosition;

	// Token: 0x04002FAD RID: 12205
	[Token(Token = "0x4002FAD")]
	[FieldOffset(Offset = "0x0")]
	public static TooltipController activeTooltip;

	// Token: 0x02000692 RID: 1682
	// (Invoke) Token: 0x0600255A RID: 9562
	[Token(Token = "0x2000692")]
	public delegate void BeforeTooltipSpawn();

	// Token: 0x02000693 RID: 1683
	[Token(Token = "0x2000693")]
	private sealed class <MouseOver>d__44 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600255D RID: 9565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600255D")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <MouseOver>d__44(int <>1__state)
		{
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600255E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x0000EB80 File Offset: 0x0000CD80
		[Token(Token = "0x600255F")]
		[Address(RVA = "0xBBD570", Offset = "0xBBC570", VA = "0x180BBD570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700012F")]
		private object Current
		{
			[Token(Token = "0x6002560")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002561")]
		[Address(RVA = "0xBBE3A0", Offset = "0xBBD3A0", VA = "0x180BBE3A0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000130")]
		private object Current
		{
			[Token(Token = "0x6002562")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002FAF RID: 12207
		[Token(Token = "0x4002FAF")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002FB0 RID: 12208
		[Token(Token = "0x4002FB0")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002FB1 RID: 12209
		[Token(Token = "0x4002FB1")]
		[FieldOffset(Offset = "0x20")]
		public TooltipController <>4__this;
	}
}
