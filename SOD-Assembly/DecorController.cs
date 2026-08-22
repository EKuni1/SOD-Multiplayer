using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000674 RID: 1652
[Token(Token = "0x2000674")]
public class DecorController : PageBasedContent
{
	// Token: 0x06002490 RID: 9360 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002490")]
	[Address(RVA = "0xB9A360", Offset = "0xB99360", VA = "0x180B9A360")]
	public void Setup(WindowContentController newContentController)
	{
	}

	// Token: 0x06002491 RID: 9361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002491")]
	[Address(RVA = "0xB9A720", Offset = "0xB99720", VA = "0x180B9A720")]
	public void SetDecorType(int newType)
	{
	}

	// Token: 0x06002492 RID: 9362 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002492")]
	[Address(RVA = "0xB94820", Offset = "0xB93820", VA = "0x180B94820")]
	public void SetPageSize(Vector2 newSize)
	{
	}

	// Token: 0x06002493 RID: 9363 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002493")]
	[Address(RVA = "0xB9A740", Offset = "0xB99740", VA = "0x180B9A740", Slot = "5")]
	public override void UpdateListDisplay()
	{
	}

	// Token: 0x06002494 RID: 9364 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002494")]
	[Address(RVA = "0xB9B640", Offset = "0xB9A640", VA = "0x180B9B640")]
	public void ClearSearchButton()
	{
	}

	// Token: 0x06002495 RID: 9365 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002495")]
	[Address(RVA = "0xB9B6A0", Offset = "0xB9A6A0", VA = "0x180B9B6A0")]
	public void SetSelected(MaterialGroupPreset newSelection)
	{
	}

	// Token: 0x06002496 RID: 9366 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002496")]
	[Address(RVA = "0xB9B8D0", Offset = "0xB9A8D0", VA = "0x180B9B8D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002497 RID: 9367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002497")]
	[Address(RVA = "0xB9BAE0", Offset = "0xB9AAE0", VA = "0x180B9BAE0")]
	private void OnDisable()
	{
	}

	// Token: 0x06002498 RID: 9368 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002498")]
	[Address(RVA = "0xB9BC30", Offset = "0xB9AC30", VA = "0x180B9BC30")]
	private void OnEnable()
	{
	}

	// Token: 0x06002499 RID: 9369 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
	[Token(Token = "0x6002499")]
	[Address(RVA = "0xB9BD80", Offset = "0xB9AD80", VA = "0x180B9BD80", Slot = "4")]
	public override int GetMaxPages()
	{
		return 0;
	}

	// Token: 0x0600249A RID: 9370 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600249A")]
	[Address(RVA = "0xB9BDE0", Offset = "0xB9ADE0", VA = "0x180B9BDE0")]
	public DecorController()
	{
	}

	// Token: 0x0600249B RID: 9371 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
	[Token(Token = "0x600249B")]
	[Address(RVA = "0xB9BFA0", Offset = "0xB9AFA0", VA = "0x180B9BFA0")]
	private bool <UpdateListDisplay>b__17_0(MaterialGroupPreset item)
	{
		return default(bool);
	}

	// Token: 0x04002E98 RID: 11928
	[Token(Token = "0x4002E98")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform rect;

	// Token: 0x04002E99 RID: 11929
	[Token(Token = "0x4002E99")]
	[FieldOffset(Offset = "0x28")]
	public WindowContentController wcc;

	// Token: 0x04002E9A RID: 11930
	[Token(Token = "0x4002E9A")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform entryParent;

	// Token: 0x04002E9B RID: 11931
	[Token(Token = "0x4002E9B")]
	[FieldOffset(Offset = "0x38")]
	public ButtonController wallsButton;

	// Token: 0x04002E9C RID: 11932
	[Token(Token = "0x4002E9C")]
	[FieldOffset(Offset = "0x40")]
	public ButtonController ceilingButton;

	// Token: 0x04002E9D RID: 11933
	[Token(Token = "0x4002E9D")]
	[FieldOffset(Offset = "0x48")]
	public ButtonController floorButton;

	// Token: 0x04002E9E RID: 11934
	[Token(Token = "0x4002E9E")]
	[FieldOffset(Offset = "0x50")]
	public GameObject decorElementPrefab;

	// Token: 0x04002E9F RID: 11935
	[Token(Token = "0x4002E9F")]
	[FieldOffset(Offset = "0x58")]
	public MaterialGroupPreset.MaterialType decorType;

	// Token: 0x04002EA0 RID: 11936
	[Token(Token = "0x4002EA0")]
	[FieldOffset(Offset = "0x5C")]
	public bool isSetup;

	// Token: 0x04002EA1 RID: 11937
	[Token(Token = "0x4002EA1")]
	[FieldOffset(Offset = "0x60")]
	public NewRoom room;

	// Token: 0x04002EA2 RID: 11938
	[Token(Token = "0x4002EA2")]
	[FieldOffset(Offset = "0x68")]
	public MaterialKeyController keyController;

	// Token: 0x04002EA3 RID: 11939
	[Token(Token = "0x4002EA3")]
	[FieldOffset(Offset = "0x70")]
	public TMP_InputField searchInputField;

	// Token: 0x04002EA4 RID: 11940
	[Token(Token = "0x4002EA4")]
	[FieldOffset(Offset = "0x78")]
	private List<MaterialGroupPreset> allRequired;

	// Token: 0x04002EA5 RID: 11941
	[Token(Token = "0x4002EA5")]
	[FieldOffset(Offset = "0x80")]
	public List<DecorElementController> spawnedEntries;

	// Token: 0x02000675 RID: 1653
	[Token(Token = "0x2000675")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600249D RID: 9373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x0000EA00 File Offset: 0x0000CC00
		[Token(Token = "0x600249E")]
		[Address(RVA = "0xB9C080", Offset = "0xB9B080", VA = "0x180B9C080")]
		internal int <UpdateListDisplay>b__17_1(MaterialGroupPreset p1, MaterialGroupPreset p2)
		{
			return 0;
		}

		// Token: 0x04002EA6 RID: 11942
		[Token(Token = "0x4002EA6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DecorController.<>c <>9;

		// Token: 0x04002EA7 RID: 11943
		[Token(Token = "0x4002EA7")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<MaterialGroupPreset> <>9__17_1;
	}
}
