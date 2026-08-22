using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Rewired.Components;
using Rewired.Integration.UnityUI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020006A4 RID: 1700
[Token(Token = "0x20006A4")]
public class VirtualCursorController : MonoBehaviour
{
	// Token: 0x17000137 RID: 311
	// (get) Token: 0x060025C0 RID: 9664 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060025C1 RID: 9665 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000137")]
	public static VirtualCursorController Instance
	{
		[Token(Token = "0x60025C0")]
		[Address(RVA = "0xBD2160", Offset = "0xBD1160", VA = "0x180BD2160")]
		get
		{
			return null;
		}
		[Token(Token = "0x60025C1")]
		[Address(RVA = "0xBD21A0", Offset = "0xBD11A0", VA = "0x180BD21A0")]
		private set
		{
		}
	}

	// Token: 0x060025C2 RID: 9666 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025C2")]
	[Address(RVA = "0xBD2240", Offset = "0xBD1240", VA = "0x180BD2240")]
	private void Awake()
	{
	}

	// Token: 0x060025C3 RID: 9667 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025C3")]
	[Address(RVA = "0xBD25A0", Offset = "0xBD15A0", VA = "0x180BD25A0")]
	private void Start()
	{
	}

	// Token: 0x060025C4 RID: 9668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025C4")]
	[Address(RVA = "0xBD25B0", Offset = "0xBD15B0", VA = "0x180BD25B0")]
	private void Update()
	{
	}

	// Token: 0x060025C5 RID: 9669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025C5")]
	[Address(RVA = "0xBD2A60", Offset = "0xBD1A60", VA = "0x180BD2A60")]
	public void TryActivateVirtualCursor(VirtualCursorController.StartingMousePosition startingPos = VirtualCursorController.StartingMousePosition.usePrevious, [Optional] RectTransform setToRectTransform)
	{
	}

	// Token: 0x060025C6 RID: 9670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025C6")]
	[Address(RVA = "0xBD3110", Offset = "0xBD2110", VA = "0x180BD3110")]
	public void UpdateCursorSpeed()
	{
	}

	// Token: 0x060025C7 RID: 9671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025C7")]
	[Address(RVA = "0xBD3280", Offset = "0xBD2280", VA = "0x180BD3280")]
	public void SetCursorPosition(Vector2 screenPosition)
	{
	}

	// Token: 0x060025C8 RID: 9672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025C8")]
	[Address(RVA = "0xBD3610", Offset = "0xBD2610", VA = "0x180BD3610")]
	public void SetCursorPosition(RectTransform objectRect)
	{
	}

	// Token: 0x060025C9 RID: 9673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025C9")]
	[Address(RVA = "0xBD3A30", Offset = "0xBD2A30", VA = "0x180BD3A30")]
	public void DeactivateVirtualCursor()
	{
	}

	// Token: 0x060025CA RID: 9674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025CA")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public VirtualCursorController()
	{
	}

	// Token: 0x0400301D RID: 12317
	[Token(Token = "0x400301D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static VirtualCursorController <Instance>k__BackingField;

	// Token: 0x0400301E RID: 12318
	[Token(Token = "0x400301E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static VirtualCursorController _instance;

	// Token: 0x0400301F RID: 12319
	[Token(Token = "0x400301F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public StandaloneInputModule standardInput;

	// Token: 0x04003020 RID: 12320
	[Token(Token = "0x4003020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RewiredStandaloneInputModule rewiredInput;

	// Token: 0x04003021 RID: 12321
	[Token(Token = "0x4003021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public PlayerMouse mouse;

	// Token: 0x04003022 RID: 12322
	[Token(Token = "0x4003022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isActive;

	// Token: 0x04003023 RID: 12323
	[Token(Token = "0x4003023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool animatingTransition;

	// Token: 0x04003024 RID: 12324
	[Token(Token = "0x4003024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float alpha;

	// Token: 0x04003025 RID: 12325
	[Token(Token = "0x4003025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool activatedBefore;

	// Token: 0x04003026 RID: 12326
	[Token(Token = "0x4003026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform animationTransform;

	// Token: 0x04003027 RID: 12327
	[Token(Token = "0x4003027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AnimationCurve animateActiveScale;

	// Token: 0x04003028 RID: 12328
	[Token(Token = "0x4003028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve animateInactiveScale;

	// Token: 0x04003029 RID: 12329
	[Token(Token = "0x4003029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject cursorObject;

	// Token: 0x0400302A RID: 12330
	[Token(Token = "0x400302A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Image cursorImage;

	// Token: 0x0400302B RID: 12331
	[Token(Token = "0x400302B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RawImage cursorRaw;

	// Token: 0x0400302C RID: 12332
	[Token(Token = "0x400302C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector2 lastKnownPos;

	// Token: 0x020006A5 RID: 1701
	[Token(Token = "0x20006A5")]
	public enum StartingMousePosition
	{
		// Token: 0x0400302E RID: 12334
		[Token(Token = "0x400302E")]
		usePrevious,
		// Token: 0x0400302F RID: 12335
		[Token(Token = "0x400302F")]
		centreScreen,
		// Token: 0x04003030 RID: 12336
		[Token(Token = "0x4003030")]
		coordinate
	}
}
