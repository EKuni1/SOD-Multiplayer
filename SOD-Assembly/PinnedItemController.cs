using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020006AB RID: 1707
[Token(Token = "0x20006AB")]
public class PinnedItemController : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>
{
	// Token: 0x1400004D RID: 77
	// (add) Token: 0x06002600 RID: 9728 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002601 RID: 9729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400004D")]
	public event PinnedItemController.OnMove OnMoved
	{
		[Token(Token = "0x6002600")]
		[Address(RVA = "0xBDAD30", Offset = "0xBD9D30", VA = "0x180BDAD30")]
		add
		{
		}
		[Token(Token = "0x6002601")]
		[Address(RVA = "0xBDAE30", Offset = "0xBD9E30", VA = "0x180BDAE30")]
		remove
		{
		}
	}

	// Token: 0x06002602 RID: 9730 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002602")]
	[Address(RVA = "0xBDAF30", Offset = "0xBD9F30", VA = "0x180BDAF30")]
	public void Setup(Case.CaseElement newElement)
	{
	}

	// Token: 0x06002603 RID: 9731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002603")]
	[Address(RVA = "0xBDBE50", Offset = "0xBDAE50", VA = "0x180BDBE50")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002604 RID: 9732 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002604")]
	[Address(RVA = "0xBDC390", Offset = "0xBDB390", VA = "0x180BDC390")]
	public void SetPostion(Vector2 newPos)
	{
	}

	// Token: 0x06002605 RID: 9733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002605")]
	[Address(RVA = "0xBDC430", Offset = "0xBDB430", VA = "0x180BDC430")]
	public void AutoPinPostion()
	{
	}

	// Token: 0x06002606 RID: 9734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002606")]
	[Address(RVA = "0xBDCA20", Offset = "0xBDBA20", VA = "0x180BDCA20")]
	public void OnMoveThis()
	{
	}

	// Token: 0x06002607 RID: 9735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002607")]
	[Address(RVA = "0xBDCE90", Offset = "0xBDBE90", VA = "0x180BDCE90")]
	public void VisualUpdate()
	{
	}

	// Token: 0x06002608 RID: 9736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002608")]
	[Address(RVA = "0xBDD400", Offset = "0xBDC400", VA = "0x180BDD400")]
	public void UpdateNewInfoIcon()
	{
	}

	// Token: 0x06002609 RID: 9737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002609")]
	[Address(RVA = "0xBDD770", Offset = "0xBDC770", VA = "0x180BDD770", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x0600260A RID: 9738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600260A")]
	[Address(RVA = "0xBDD820", Offset = "0xBDC820", VA = "0x180BDD820", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x0600260B RID: 9739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600260B")]
	[Address(RVA = "0xBDDA10", Offset = "0xBDCA10", VA = "0x180BDDA10")]
	public void SetHovered(bool val)
	{
	}

	// Token: 0x0600260C RID: 9740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600260C")]
	[Address(RVA = "0xBDDAE0", Offset = "0xBDCAE0", VA = "0x180BDDAE0", Slot = "6")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x0600260D RID: 9741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600260D")]
	[Address(RVA = "0xBDDE40", Offset = "0xBDCE40", VA = "0x180BDDE40", Slot = "7")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x0600260E RID: 9742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600260E")]
	[Address(RVA = "0xBDDE70", Offset = "0xBDCE70", VA = "0x180BDDE70", Slot = "8")]
	public void OnDrag(PointerEventData data)
	{
	}

	// Token: 0x0600260F RID: 9743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600260F")]
	[Address(RVA = "0xBDDEA0", Offset = "0xBDCEA0", VA = "0x180BDDEA0")]
	public void ForceDrag()
	{
	}

	// Token: 0x06002610 RID: 9744 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002610")]
	[Address(RVA = "0xBDE550", Offset = "0xBDD550", VA = "0x180BDE550", Slot = "9")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06002611 RID: 9745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002611")]
	[Address(RVA = "0xBDE5C0", Offset = "0xBDD5C0", VA = "0x180BDE5C0")]
	public void ForcePointerUp()
	{
	}

	// Token: 0x06002612 RID: 9746 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002612")]
	[Address(RVA = "0xBDE690", Offset = "0xBDD690", VA = "0x180BDE690")]
	private IEnumerator IsOver()
	{
		return null;
	}

	// Token: 0x06002613 RID: 9747 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002613")]
	[Address(RVA = "0xBDE730", Offset = "0xBDD730", VA = "0x180BDE730")]
	private IEnumerator IsDragging()
	{
		return null;
	}

	// Token: 0x06002614 RID: 9748 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002614")]
	[Address(RVA = "0xBDE7D0", Offset = "0xBDD7D0", VA = "0x180BDE7D0")]
	private IEnumerator Rescale(Vector3 size)
	{
		return null;
	}

	// Token: 0x06002615 RID: 9749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002615")]
	[Address(RVA = "0xBDE8A0", Offset = "0xBDD8A0", VA = "0x180BDE8A0")]
	public void SetSelected(bool val, bool permenantSelected)
	{
	}

	// Token: 0x06002616 RID: 9750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002616")]
	[Address(RVA = "0xBDF300", Offset = "0xBDE300", VA = "0x180BDF300")]
	public void ChangeBaseColour(Color newBaseColour)
	{
	}

	// Token: 0x06002617 RID: 9751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002617")]
	[Address(RVA = "0xBDF3C0", Offset = "0xBDE3C0", VA = "0x180BDF3C0")]
	public void UpdateTooltipText()
	{
	}

	// Token: 0x06002618 RID: 9752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002618")]
	[Address(RVA = "0xBDF710", Offset = "0xBDE710", VA = "0x180BDF710")]
	public void ToggleHideChildren()
	{
	}

	// Token: 0x06002619 RID: 9753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002619")]
	[Address(RVA = "0xBDF730", Offset = "0xBDE730", VA = "0x180BDF730")]
	public void HideConnections()
	{
	}

	// Token: 0x0600261A RID: 9754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600261A")]
	[Address(RVA = "0xBDFE50", Offset = "0xBDEE50", VA = "0x180BDFE50")]
	public void ShowConnections()
	{
	}

	// Token: 0x0600261B RID: 9755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600261B")]
	[Address(RVA = "0xBE0590", Offset = "0xBDF590", VA = "0x180BE0590")]
	public void ToggleMinimize()
	{
	}

	// Token: 0x0600261C RID: 9756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600261C")]
	[Address(RVA = "0xBE05C0", Offset = "0xBDF5C0", VA = "0x180BE05C0")]
	public void Minimize()
	{
	}

	// Token: 0x0600261D RID: 9757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600261D")]
	[Address(RVA = "0xBE0A00", Offset = "0xBDFA00", VA = "0x180BE0A00")]
	public void Restore()
	{
	}

	// Token: 0x0600261E RID: 9758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600261E")]
	[Address(RVA = "0xBE1070", Offset = "0xBE0070", VA = "0x180BE1070")]
	public void OpenEvidence()
	{
	}

	// Token: 0x0600261F RID: 9759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600261F")]
	[Address(RVA = "0xBE1190", Offset = "0xBE0190", VA = "0x180BE1190")]
	public void Unpin()
	{
	}

	// Token: 0x06002620 RID: 9760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002620")]
	[Address(RVA = "0xBE12F0", Offset = "0xBE02F0", VA = "0x180BE12F0")]
	public void Cancel()
	{
	}

	// Token: 0x06002621 RID: 9761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002621")]
	[Address(RVA = "0xBE1410", Offset = "0xBE0410", VA = "0x180BE1410")]
	private void LateUpdate()
	{
	}

	// Token: 0x06002622 RID: 9762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002622")]
	[Address(RVA = "0xBE14B0", Offset = "0xBE04B0", VA = "0x180BE14B0")]
	public void UpdateContextMenuOptions()
	{
	}

	// Token: 0x06002623 RID: 9763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002623")]
	[Address(RVA = "0xBE1740", Offset = "0xBE0740", VA = "0x180BE1740")]
	public void CreateCustomString()
	{
	}

	// Token: 0x06002624 RID: 9764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002624")]
	[Address(RVA = "0xBE17A0", Offset = "0xBE07A0", VA = "0x180BE17A0")]
	public void ForceCancelDrag()
	{
	}

	// Token: 0x06002625 RID: 9765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002625")]
	[Address(RVA = "0xBE17F0", Offset = "0xBE07F0", VA = "0x180BE17F0")]
	public void ToggleCrossedOut()
	{
	}

	// Token: 0x06002626 RID: 9766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002626")]
	[Address(RVA = "0xBE1BA0", Offset = "0xBE0BA0", VA = "0x180BE1BA0")]
	public void PlotRoute()
	{
	}

	// Token: 0x06002627 RID: 9767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002627")]
	[Address(RVA = "0xBE1C00", Offset = "0xBE0C00", VA = "0x180BE1C00")]
	public void LocateOnMap()
	{
	}

	// Token: 0x06002628 RID: 9768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002628")]
	[Address(RVA = "0xBE1C60", Offset = "0xBE0C60", VA = "0x180BE1C60")]
	public void ToggleCollapse()
	{
	}

	// Token: 0x06002629 RID: 9769 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002629")]
	[Address(RVA = "0xBE1E40", Offset = "0xBE0E40", VA = "0x180BE1E40")]
	public void NewStickyNote()
	{
	}

	// Token: 0x0600262A RID: 9770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600262A")]
	[Address(RVA = "0xBE23A0", Offset = "0xBE13A0", VA = "0x180BE23A0")]
	public void MinimizeAll()
	{
	}

	// Token: 0x0600262B RID: 9771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600262B")]
	[Address(RVA = "0xBE24F0", Offset = "0xBE14F0", VA = "0x180BE24F0")]
	public void PinAllLinks()
	{
	}

	// Token: 0x0600262C RID: 9772 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600262C")]
	[Address(RVA = "0xBE2F00", Offset = "0xBE1F00", VA = "0x180BE2F00")]
	public void UnpinAllLinks()
	{
	}

	// Token: 0x0600262D RID: 9773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600262D")]
	[Address(RVA = "0xBE38D0", Offset = "0xBE28D0", VA = "0x180BE38D0")]
	public void SetColourRed()
	{
	}

	// Token: 0x0600262E RID: 9774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600262E")]
	[Address(RVA = "0xBE3AA0", Offset = "0xBE2AA0", VA = "0x180BE3AA0")]
	public void SetColourBlue()
	{
	}

	// Token: 0x0600262F RID: 9775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600262F")]
	[Address(RVA = "0xBE3C70", Offset = "0xBE2C70", VA = "0x180BE3C70")]
	public void SetColourYellow()
	{
	}

	// Token: 0x06002630 RID: 9776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002630")]
	[Address(RVA = "0xBE3E40", Offset = "0xBE2E40", VA = "0x180BE3E40")]
	public void SetColourGreen()
	{
	}

	// Token: 0x06002631 RID: 9777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002631")]
	[Address(RVA = "0xBE4010", Offset = "0xBE3010", VA = "0x180BE4010")]
	public void SetColourPurple()
	{
	}

	// Token: 0x06002632 RID: 9778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002632")]
	[Address(RVA = "0xBE41E0", Offset = "0xBE31E0", VA = "0x180BE41E0")]
	public void SetColourWhite()
	{
	}

	// Token: 0x06002633 RID: 9779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002633")]
	[Address(RVA = "0xBE43B0", Offset = "0xBE33B0", VA = "0x180BE43B0")]
	public void SetColourBlack()
	{
	}

	// Token: 0x06002634 RID: 9780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002634")]
	[Address(RVA = "0xBE4580", Offset = "0xBE3580", VA = "0x180BE4580")]
	public void UpdatePulsate()
	{
	}

	// Token: 0x06002635 RID: 9781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002635")]
	[Address(RVA = "0xBE4B70", Offset = "0xBE3B70", VA = "0x180BE4B70")]
	public void DisplayEvidenceIdentifier()
	{
	}

	// Token: 0x06002636 RID: 9782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002636")]
	[Address(RVA = "0xBE4BB0", Offset = "0xBE3BB0", VA = "0x180BE4BB0")]
	public PinnedItemController()
	{
	}

	// Token: 0x06002637 RID: 9783 RVA: 0x0000ED18 File Offset: 0x0000CF18
	[Token(Token = "0x6002637")]
	[Address(RVA = "0xBE4DE0", Offset = "0xBE3DE0", VA = "0x180BE4DE0")]
	private bool <HideConnections>b__58_0(Case item)
	{
		return default(bool);
	}

	// Token: 0x06002638 RID: 9784 RVA: 0x0000ED30 File Offset: 0x0000CF30
	[Token(Token = "0x6002638")]
	[Address(RVA = "0xBE4DE0", Offset = "0xBE3DE0", VA = "0x180BE4DE0")]
	private bool <HideConnections>b__58_1(Case item)
	{
		return default(bool);
	}

	// Token: 0x06002639 RID: 9785 RVA: 0x0000ED48 File Offset: 0x0000CF48
	[Token(Token = "0x6002639")]
	[Address(RVA = "0xBE4DE0", Offset = "0xBE3DE0", VA = "0x180BE4DE0")]
	private bool <ShowConnections>b__59_0(Case item)
	{
		return default(bool);
	}

	// Token: 0x0600263A RID: 9786 RVA: 0x0000ED60 File Offset: 0x0000CF60
	[Token(Token = "0x600263A")]
	[Address(RVA = "0xBE4DE0", Offset = "0xBE3DE0", VA = "0x180BE4DE0")]
	private bool <ShowConnections>b__59_1(Case item)
	{
		return default(bool);
	}

	// Token: 0x0600263B RID: 9787 RVA: 0x0000ED78 File Offset: 0x0000CF78
	[Token(Token = "0x600263B")]
	[Address(RVA = "0xBE4DE0", Offset = "0xBE3DE0", VA = "0x180BE4DE0")]
	private bool <Unpin>b__64_0(Case item)
	{
		return default(bool);
	}

	// Token: 0x0600263C RID: 9788 RVA: 0x0000ED90 File Offset: 0x0000CF90
	[Token(Token = "0x600263C")]
	[Address(RVA = "0xBE4DE0", Offset = "0xBE3DE0", VA = "0x180BE4DE0")]
	private bool <NewStickyNote>b__74_0(Case item)
	{
		return default(bool);
	}

	// Token: 0x0400305A RID: 12378
	[Token(Token = "0x400305A")]
	[FieldOffset(Offset = "0x18")]
	public Case.CaseElement caseElement;

	// Token: 0x0400305B RID: 12379
	[Token(Token = "0x400305B")]
	[FieldOffset(Offset = "0x20")]
	public Evidence evidence;

	// Token: 0x0400305C RID: 12380
	[Token(Token = "0x400305C")]
	[FieldOffset(Offset = "0x28")]
	public EvidenceButtonController evidenceButton;

	// Token: 0x0400305D RID: 12381
	[Token(Token = "0x400305D")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform newInfoIcon;

	// Token: 0x0400305E RID: 12382
	[Token(Token = "0x400305E")]
	[FieldOffset(Offset = "0x38")]
	public Image background;

	// Token: 0x0400305F RID: 12383
	[Token(Token = "0x400305F")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI titleText;

	// Token: 0x04003060 RID: 12384
	[Token(Token = "0x4003060")]
	[FieldOffset(Offset = "0x48")]
	public RectTransform rect;

	// Token: 0x04003061 RID: 12385
	[Token(Token = "0x4003061")]
	[FieldOffset(Offset = "0x50")]
	public RectTransform pinnedRect;

	// Token: 0x04003062 RID: 12386
	[Token(Token = "0x4003062")]
	[FieldOffset(Offset = "0x58")]
	public PinnedPinButtonController pinButtonController;

	// Token: 0x04003063 RID: 12387
	[Token(Token = "0x4003063")]
	[FieldOffset(Offset = "0x60")]
	public DragCasePanel dragController;

	// Token: 0x04003064 RID: 12388
	[Token(Token = "0x4003064")]
	[FieldOffset(Offset = "0x68")]
	public RectTransform crossedOut;

	// Token: 0x04003065 RID: 12389
	[Token(Token = "0x4003065")]
	[FieldOffset(Offset = "0x70")]
	public Rigidbody2D rb;

	// Token: 0x04003066 RID: 12390
	[Token(Token = "0x4003066")]
	[FieldOffset(Offset = "0x78")]
	public HingeJoint2D joint;

	// Token: 0x04003067 RID: 12391
	[Token(Token = "0x4003067")]
	[FieldOffset(Offset = "0x80")]
	public JuiceController juice;

	// Token: 0x04003068 RID: 12392
	[Token(Token = "0x4003068")]
	[FieldOffset(Offset = "0x88")]
	public ContextMenuController contextMenu;

	// Token: 0x04003069 RID: 12393
	[Token(Token = "0x4003069")]
	[FieldOffset(Offset = "0x90")]
	public TooltipController tooltip;

	// Token: 0x0400306A RID: 12394
	[Token(Token = "0x400306A")]
	[FieldOffset(Offset = "0x98")]
	public List<StringController> connectedStrings;

	// Token: 0x0400306B RID: 12395
	[Token(Token = "0x400306B")]
	[FieldOffset(Offset = "0x0")]
	public static PinnedQuickMenuController activeQuickMenu;

	// Token: 0x0400306C RID: 12396
	[Token(Token = "0x400306C")]
	[FieldOffset(Offset = "0xA0")]
	public bool hideConnections;

	// Token: 0x0400306D RID: 12397
	[Token(Token = "0x400306D")]
	[FieldOffset(Offset = "0xA4")]
	public Vector2 originalSize;

	// Token: 0x0400306E RID: 12398
	[Token(Token = "0x400306E")]
	[FieldOffset(Offset = "0xAC")]
	public bool isOver;

	// Token: 0x0400306F RID: 12399
	[Token(Token = "0x400306F")]
	[FieldOffset(Offset = "0xAD")]
	public bool isDragging;

	// Token: 0x04003070 RID: 12400
	[Token(Token = "0x4003070")]
	[FieldOffset(Offset = "0xAE")]
	public bool isSelected;

	// Token: 0x04003071 RID: 12401
	[Token(Token = "0x4003071")]
	[FieldOffset(Offset = "0xAF")]
	public bool permSelected;

	// Token: 0x04003072 RID: 12402
	[Token(Token = "0x4003072")]
	[FieldOffset(Offset = "0xB0")]
	public bool pinPlaceActive;

	// Token: 0x04003073 RID: 12403
	[Token(Token = "0x4003073")]
	[FieldOffset(Offset = "0xB4")]
	public float scalingSpeed;

	// Token: 0x04003074 RID: 12404
	[Token(Token = "0x4003074")]
	[FieldOffset(Offset = "0xB8")]
	public Vector3 mouseOverScale;

	// Token: 0x04003075 RID: 12405
	[Token(Token = "0x4003075")]
	[FieldOffset(Offset = "0xC4")]
	public Vector3 prevLocalPos;

	// Token: 0x04003076 RID: 12406
	[Token(Token = "0x4003076")]
	[FieldOffset(Offset = "0xD0")]
	public List<string> debug;

	// Token: 0x04003077 RID: 12407
	[Token(Token = "0x4003077")]
	[FieldOffset(Offset = "0x8")]
	public static List<float> angleSteps;

	// Token: 0x04003078 RID: 12408
	[Token(Token = "0x4003078")]
	[FieldOffset(Offset = "0xD8")]
	public bool minimized;

	// Token: 0x020006AC RID: 1708
	// (Invoke) Token: 0x0600263E RID: 9790
	[Token(Token = "0x20006AC")]
	public delegate void OnMove();

	// Token: 0x020006AD RID: 1709
	[Token(Token = "0x20006AD")]
	private sealed class <IsOver>d__51 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06002641 RID: 9793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002641")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <IsOver>d__51(int <>1__state)
		{
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002642")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		[Token(Token = "0x6002643")]
		[Address(RVA = "0xBE4E10", Offset = "0xBE3E10", VA = "0x180BE4E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700013B")]
		private object Current
		{
			[Token(Token = "0x6002644")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002645")]
		[Address(RVA = "0xBE5DA0", Offset = "0xBE4DA0", VA = "0x180BE5DA0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700013C")]
		private object Current
		{
			[Token(Token = "0x6002646")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400307A RID: 12410
		[Token(Token = "0x400307A")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400307B RID: 12411
		[Token(Token = "0x400307B")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400307C RID: 12412
		[Token(Token = "0x400307C")]
		[FieldOffset(Offset = "0x20")]
		public PinnedItemController <>4__this;

		// Token: 0x0400307D RID: 12413
		[Token(Token = "0x400307D")]
		[FieldOffset(Offset = "0x28")]
		private bool <selected>5__2;

		// Token: 0x0400307E RID: 12414
		[Token(Token = "0x400307E")]
		[FieldOffset(Offset = "0x2C")]
		private float <quickMenuTimer>5__3;

		// Token: 0x0400307F RID: 12415
		[Token(Token = "0x400307F")]
		[FieldOffset(Offset = "0x30")]
		private bool <deselectTimer>5__4;
	}

	// Token: 0x020006AE RID: 1710
	[Token(Token = "0x20006AE")]
	private sealed class <IsDragging>d__52 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06002647 RID: 9799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002647")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <IsDragging>d__52(int <>1__state)
		{
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002648")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		[Token(Token = "0x6002649")]
		[Address(RVA = "0xBE5DF0", Offset = "0xBE4DF0", VA = "0x180BE5DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700013D")]
		private object Current
		{
			[Token(Token = "0x600264A")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600264B")]
		[Address(RVA = "0xBE6DF0", Offset = "0xBE5DF0", VA = "0x180BE6DF0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700013E")]
		private object Current
		{
			[Token(Token = "0x600264C")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04003080 RID: 12416
		[Token(Token = "0x4003080")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04003081 RID: 12417
		[Token(Token = "0x4003081")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04003082 RID: 12418
		[Token(Token = "0x4003082")]
		[FieldOffset(Offset = "0x20")]
		public PinnedItemController <>4__this;
	}

	// Token: 0x020006AF RID: 1711
	[Token(Token = "0x20006AF")]
	private sealed class <Rescale>d__53 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600264D RID: 9805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600264D")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Rescale>d__53(int <>1__state)
		{
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600264E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		[Token(Token = "0x600264F")]
		[Address(RVA = "0xBE6E40", Offset = "0xBE5E40", VA = "0x180BE6E40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700013F")]
		private object Current
		{
			[Token(Token = "0x6002650")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002651")]
		[Address(RVA = "0xBE70D0", Offset = "0xBE60D0", VA = "0x180BE70D0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000140")]
		private object Current
		{
			[Token(Token = "0x6002652")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04003083 RID: 12419
		[Token(Token = "0x4003083")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04003084 RID: 12420
		[Token(Token = "0x4003084")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04003085 RID: 12421
		[Token(Token = "0x4003085")]
		[FieldOffset(Offset = "0x20")]
		public PinnedItemController <>4__this;

		// Token: 0x04003086 RID: 12422
		[Token(Token = "0x4003086")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 size;

		// Token: 0x04003087 RID: 12423
		[Token(Token = "0x4003087")]
		[FieldOffset(Offset = "0x34")]
		private float <len>5__2;
	}

	// Token: 0x020006B0 RID: 1712
	[Token(Token = "0x20006B0")]
	private sealed class <>c__DisplayClass76_0
	{
		// Token: 0x06002653 RID: 9811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002653")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass76_0()
		{
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		[Token(Token = "0x6002654")]
		[Address(RVA = "0xBE7120", Offset = "0xBE6120", VA = "0x180BE7120")]
		internal bool <PinAllLinks>b__0(Case item)
		{
			return default(bool);
		}

		// Token: 0x04003088 RID: 12424
		[Token(Token = "0x4003088")]
		[FieldOffset(Offset = "0x10")]
		public PinnedItemController pic;
	}

	// Token: 0x020006B1 RID: 1713
	[Token(Token = "0x20006B1")]
	private sealed class <>c__DisplayClass77_0
	{
		// Token: 0x06002655 RID: 9813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002655")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass77_0()
		{
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x0000EE08 File Offset: 0x0000D008
		[Token(Token = "0x6002656")]
		[Address(RVA = "0xBE7120", Offset = "0xBE6120", VA = "0x180BE7120")]
		internal bool <UnpinAllLinks>b__0(Case item)
		{
			return default(bool);
		}

		// Token: 0x04003089 RID: 12425
		[Token(Token = "0x4003089")]
		[FieldOffset(Offset = "0x10")]
		public PinnedItemController pic;
	}

	// Token: 0x020006B2 RID: 1714
	[Token(Token = "0x20006B2")]
	private sealed class <>c__DisplayClass85_0
	{
		// Token: 0x06002657 RID: 9815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002657")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass85_0()
		{
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x0000EE20 File Offset: 0x0000D020
		[Token(Token = "0x6002658")]
		[Address(RVA = "0xBE7150", Offset = "0xBE6150", VA = "0x180BE7150")]
		internal bool <UpdatePulsate>b__0(RaycastResult item)
		{
			return default(bool);
		}

		// Token: 0x0400308A RID: 12426
		[Token(Token = "0x400308A")]
		[FieldOffset(Offset = "0x10")]
		public InfoWindow w;
	}
}
