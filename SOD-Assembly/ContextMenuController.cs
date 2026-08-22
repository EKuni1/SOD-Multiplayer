using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200056C RID: 1388
[Token(Token = "0x200056C")]
public class ContextMenuController : MonoBehaviour, IEnumerator<object>, IDisposable
{
	// Token: 0x1400002C RID: 44
	// (add) Token: 0x06001E37 RID: 7735 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001E38 RID: 7736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400002C")]
	public event ContextMenuController.OpenedMenu OnOpenMenu
	{
		[Token(Token = "0x6001E37")]
		[Address(RVA = "0xA48040", Offset = "0xA47040", VA = "0x180A48040")]
		add
		{
		}
		[Token(Token = "0x6001E38")]
		[Address(RVA = "0xA48130", Offset = "0xA47130", VA = "0x180A48130")]
		remove
		{
		}
	}

	// Token: 0x06001E39 RID: 7737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E39")]
	[Address(RVA = "0xA48220", Offset = "0xA47220", VA = "0x180A48220", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x06001E3A RID: 7738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E3A")]
	[Address(RVA = "0xA48280", Offset = "0xA47280", VA = "0x180A48280")]
	public void OpenMenu()
	{
	}

	// Token: 0x06001E3B RID: 7739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E3B")]
	[Address(RVA = "0xA49680", Offset = "0xA48680", VA = "0x180A49680")]
	public void OnCommand(ContextButtonController button)
	{
	}

	// Token: 0x06001E3C RID: 7740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E3C")]
	[Address(RVA = "0xA49720", Offset = "0xA48720", VA = "0x180A49720")]
	public void ForceClose()
	{
	}

	// Token: 0x06001E3D RID: 7741 RVA: 0x0000DA28 File Offset: 0x0000BC28
	[Token(Token = "0x6001E3D")]
	[Address(RVA = "0xA49820", Offset = "0xA48820", VA = "0x180A49820")]
	private Vector2 ClampToWindow(Vector2 rawPointerPosition)
	{
		return default(Vector2);
	}

	// Token: 0x06001E3E RID: 7742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E3E")]
	[Address(RVA = "0xA499C0", Offset = "0xA489C0", VA = "0x180A499C0")]
	public void SetScreenPosition(Vector2 pointerPosition)
	{
	}

	// Token: 0x06001E3F RID: 7743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E3F")]
	[Address(RVA = "0xA49C90", Offset = "0xA48C90", VA = "0x180A49C90")]
	public ContextMenuController()
	{
	}

	// Token: 0x040026B9 RID: 9913
	[Token(Token = "0x40026B9")]
	[FieldOffset(Offset = "0x18")]
	public bool useLeftButton;

	// Token: 0x040026BA RID: 9914
	[Token(Token = "0x40026BA")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 pos;

	// Token: 0x040026BB RID: 9915
	[Token(Token = "0x40026BB")]
	[FieldOffset(Offset = "0x24")]
	public bool useCursorPos;

	// Token: 0x040026BC RID: 9916
	[Token(Token = "0x40026BC")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 cursorPosOffset;

	// Token: 0x040026BD RID: 9917
	[Token(Token = "0x40026BD")]
	[FieldOffset(Offset = "0x30")]
	public bool useGlobalWidth;

	// Token: 0x040026BE RID: 9918
	[Token(Token = "0x40026BE")]
	[FieldOffset(Offset = "0x34")]
	public float width;

	// Token: 0x040026BF RID: 9919
	[Token(Token = "0x40026BF")]
	[FieldOffset(Offset = "0x38")]
	public ContextMenuController.MenuFlag flag;

	// Token: 0x040026C0 RID: 9920
	[Token(Token = "0x40026C0")]
	[FieldOffset(Offset = "0x40")]
	public List<ContextMenuController.ContextMenuButtonSetup> menuButtons;

	// Token: 0x040026C1 RID: 9921
	[Token(Token = "0x40026C1")]
	[FieldOffset(Offset = "0x48")]
	public List<string> disabledItems;

	// Token: 0x040026C2 RID: 9922
	[Token(Token = "0x40026C2")]
	[FieldOffset(Offset = "0x50")]
	public MonoBehaviour commandObject;

	// Token: 0x040026C3 RID: 9923
	[Token(Token = "0x40026C3")]
	[FieldOffset(Offset = "0x0")]
	public static ContextMenuController activeMenu;

	// Token: 0x040026C4 RID: 9924
	[Token(Token = "0x40026C4")]
	[FieldOffset(Offset = "0x58")]
	public ContextButtonController lastButton;

	// Token: 0x040026C5 RID: 9925
	[Token(Token = "0x40026C5")]
	[FieldOffset(Offset = "0x60")]
	public GameObject spawnedMenu;

	// Token: 0x040026C6 RID: 9926
	[Token(Token = "0x40026C6")]
	[FieldOffset(Offset = "0x68")]
	private RectTransform menuRect;

	// Token: 0x0200056D RID: 1389
	[Token(Token = "0x200056D")]
	public enum MenuFlag
	{
		// Token: 0x040026C9 RID: 9929
		[Token(Token = "0x40026C9")]
		none,
		// Token: 0x040026CA RID: 9930
		[Token(Token = "0x40026CA")]
		pinnedSelected
	}

	// Token: 0x0200056E RID: 1390
	[Token(Token = "0x200056E")]
	[Serializable]
	public class ContextMenuButtonSetup
	{
		// Token: 0x06001E40 RID: 7744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E40")]
		[Address(RVA = "0xA49E60", Offset = "0xA48E60", VA = "0x180A49E60")]
		public ContextMenuButtonSetup()
		{
		}

		// Token: 0x040026CB RID: 9931
		[Token(Token = "0x40026CB")]
		[FieldOffset(Offset = "0x10")]
		public string commandString;

		// Token: 0x040026CC RID: 9932
		[Token(Token = "0x40026CC")]
		[FieldOffset(Offset = "0x18")]
		public bool useText;

		// Token: 0x040026CD RID: 9933
		[Token(Token = "0x40026CD")]
		[FieldOffset(Offset = "0x20")]
		public string overrideText;

		// Token: 0x040026CE RID: 9934
		[Token(Token = "0x40026CE")]
		[FieldOffset(Offset = "0x28")]
		public bool useColour;

		// Token: 0x040026CF RID: 9935
		[Token(Token = "0x40026CF")]
		[FieldOffset(Offset = "0x2C")]
		public Color colour;

		// Token: 0x040026D0 RID: 9936
		[Token(Token = "0x40026D0")]
		[FieldOffset(Offset = "0x3C")]
		public bool devOnly;

		// Token: 0x040026D1 RID: 9937
		[Token(Token = "0x40026D1")]
		[FieldOffset(Offset = "0x3D")]
		public bool disableForRatModifier;
	}

	// Token: 0x0200056F RID: 1391
	// (Invoke) Token: 0x06001E42 RID: 7746
	[Token(Token = "0x200056F")]
	public delegate void OpenedMenu();
}
