using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000676 RID: 1654
[Token(Token = "0x2000676")]
public class FurnishingsController : PageBasedContent
{
	// Token: 0x0600249F RID: 9375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600249F")]
	[Address(RVA = "0xB9C0C0", Offset = "0xB9B0C0", VA = "0x180B9C0C0")]
	public void Setup(WindowContentController newContentController)
	{
	}

	// Token: 0x060024A0 RID: 9376 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024A0")]
	[Address(RVA = "0xB94820", Offset = "0xB93820", VA = "0x180B94820")]
	public void SetPageSize(Vector2 newSize)
	{
	}

	// Token: 0x060024A1 RID: 9377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024A1")]
	[Address(RVA = "0xB9C610", Offset = "0xB9B610", VA = "0x180B9C610")]
	public void SetTabState(int newState)
	{
	}

	// Token: 0x060024A2 RID: 9378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024A2")]
	[Address(RVA = "0xB9C620", Offset = "0xB9B620", VA = "0x180B9C620")]
	public void SetTabState(FurnishingsController.TabState newState, bool forceUpdate = false)
	{
	}

	// Token: 0x060024A3 RID: 9379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024A3")]
	[Address(RVA = "0xB9C850", Offset = "0xB9B850", VA = "0x180B9C850", Slot = "5")]
	public override void UpdateListDisplay()
	{
	}

	// Token: 0x060024A4 RID: 9380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024A4")]
	[Address(RVA = "0xB9E6B0", Offset = "0xB9D6B0", VA = "0x180B9E6B0")]
	public void ToggleDisplayClass(int classInt)
	{
	}

	// Token: 0x060024A5 RID: 9381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024A5")]
	[Address(RVA = "0xB9E7A0", Offset = "0xB9D7A0", VA = "0x180B9E7A0")]
	public void SetSelected(FurniturePreset newSelection, FurnitureLocation existingLocation, bool newPlaceExistingRoomObject)
	{
	}

	// Token: 0x060024A6 RID: 9382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024A6")]
	[Address(RVA = "0xB9ED70", Offset = "0xB9DD70", VA = "0x180B9ED70")]
	public void ClearSearchButton()
	{
	}

	// Token: 0x060024A7 RID: 9383 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024A7")]
	[Address(RVA = "0x535F20", Offset = "0x534F20", VA = "0x180535F20")]
	public void OnFurnitureChange()
	{
	}

	// Token: 0x060024A8 RID: 9384 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024A8")]
	[Address(RVA = "0xB9EDD0", Offset = "0xB9DDD0", VA = "0x180B9EDD0")]
	public void OnChangeRoom()
	{
	}

	// Token: 0x060024A9 RID: 9385 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024A9")]
	[Address(RVA = "0xB9EEA0", Offset = "0xB9DEA0", VA = "0x180B9EEA0")]
	private void OnDisable()
	{
	}

	// Token: 0x060024AA RID: 9386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024AA")]
	[Address(RVA = "0xB9F000", Offset = "0xB9E000", VA = "0x180B9F000")]
	private void OnEnable()
	{
	}

	// Token: 0x060024AB RID: 9387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024AB")]
	[Address(RVA = "0xB9F160", Offset = "0xB9E160", VA = "0x180B9F160")]
	private void OnDestroy()
	{
	}

	// Token: 0x060024AC RID: 9388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024AC")]
	[Address(RVA = "0xB9F5F0", Offset = "0xB9E5F0", VA = "0x180B9F5F0")]
	public void MoveAllToStorageButton()
	{
	}

	// Token: 0x060024AD RID: 9389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024AD")]
	[Address(RVA = "0xB9F880", Offset = "0xB9E880", VA = "0x180B9F880")]
	public void ConfirmMoveToStorage()
	{
	}

	// Token: 0x060024AE RID: 9390 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024AE")]
	[Address(RVA = "0xB9FC00", Offset = "0xB9EC00", VA = "0x180B9FC00")]
	public void CancelMoveToStorage()
	{
	}

	// Token: 0x060024AF RID: 9391 RVA: 0x0000EA18 File Offset: 0x0000CC18
	[Token(Token = "0x60024AF")]
	[Address(RVA = "0xB9FD60", Offset = "0xB9ED60", VA = "0x180B9FD60", Slot = "4")]
	public override int GetMaxPages()
	{
		return 0;
	}

	// Token: 0x060024B0 RID: 9392 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024B0")]
	[Address(RVA = "0xB9FDF0", Offset = "0xB9EDF0", VA = "0x180B9FDF0")]
	public FurnishingsController()
	{
	}

	// Token: 0x060024B1 RID: 9393 RVA: 0x0000EA30 File Offset: 0x0000CC30
	[Token(Token = "0x60024B1")]
	[Address(RVA = "0xBA0100", Offset = "0xB9F100", VA = "0x180BA0100")]
	private bool <UpdateListDisplay>b__30_2(FurniturePreset item)
	{
		return default(bool);
	}

	// Token: 0x04002EA8 RID: 11944
	[Token(Token = "0x4002EA8")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform rect;

	// Token: 0x04002EA9 RID: 11945
	[Token(Token = "0x4002EA9")]
	[FieldOffset(Offset = "0x28")]
	public WindowContentController wcc;

	// Token: 0x04002EAA RID: 11946
	[Token(Token = "0x4002EAA")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform entryParent;

	// Token: 0x04002EAB RID: 11947
	[Token(Token = "0x4002EAB")]
	[FieldOffset(Offset = "0x38")]
	public ButtonController inRoomButton;

	// Token: 0x04002EAC RID: 11948
	[Token(Token = "0x4002EAC")]
	[FieldOffset(Offset = "0x40")]
	public ButtonController inStorageButton;

	// Token: 0x04002EAD RID: 11949
	[Token(Token = "0x4002EAD")]
	[FieldOffset(Offset = "0x48")]
	public ButtonController inShopButton;

	// Token: 0x04002EAE RID: 11950
	[Token(Token = "0x4002EAE")]
	[FieldOffset(Offset = "0x50")]
	public GameObject furnitureElementPrefab;

	// Token: 0x04002EAF RID: 11951
	[Token(Token = "0x4002EAF")]
	[FieldOffset(Offset = "0x58")]
	public ButtonController chairsButton;

	// Token: 0x04002EB0 RID: 11952
	[Token(Token = "0x4002EB0")]
	[FieldOffset(Offset = "0x60")]
	public ButtonController tablesButton;

	// Token: 0x04002EB1 RID: 11953
	[Token(Token = "0x4002EB1")]
	[FieldOffset(Offset = "0x68")]
	public ButtonController unitsButton;

	// Token: 0x04002EB2 RID: 11954
	[Token(Token = "0x4002EB2")]
	[FieldOffset(Offset = "0x70")]
	public ButtonController electronicsButton;

	// Token: 0x04002EB3 RID: 11955
	[Token(Token = "0x4002EB3")]
	[FieldOffset(Offset = "0x78")]
	public ButtonController structuralButton;

	// Token: 0x04002EB4 RID: 11956
	[Token(Token = "0x4002EB4")]
	[FieldOffset(Offset = "0x80")]
	public ButtonController decorationButton;

	// Token: 0x04002EB5 RID: 11957
	[Token(Token = "0x4002EB5")]
	[FieldOffset(Offset = "0x88")]
	public ButtonController miscButton;

	// Token: 0x04002EB6 RID: 11958
	[Token(Token = "0x4002EB6")]
	[FieldOffset(Offset = "0x90")]
	public Sprite uncheckedSprite;

	// Token: 0x04002EB7 RID: 11959
	[Token(Token = "0x4002EB7")]
	[FieldOffset(Offset = "0x98")]
	public Sprite checkedSprite;

	// Token: 0x04002EB8 RID: 11960
	[Token(Token = "0x4002EB8")]
	[FieldOffset(Offset = "0xA0")]
	public bool isSetup;

	// Token: 0x04002EB9 RID: 11961
	[Token(Token = "0x4002EB9")]
	[FieldOffset(Offset = "0xA4")]
	public FurnishingsController.TabState tabState;

	// Token: 0x04002EBA RID: 11962
	[Token(Token = "0x4002EBA")]
	[FieldOffset(Offset = "0xA8")]
	public List<FurniturePreset.DecorClass> displayClasses;

	// Token: 0x04002EBB RID: 11963
	[Token(Token = "0x4002EBB")]
	[FieldOffset(Offset = "0xB0")]
	public NewRoom room;

	// Token: 0x04002EBC RID: 11964
	[Token(Token = "0x4002EBC")]
	[FieldOffset(Offset = "0xB8")]
	public MaterialKeyController keyController;

	// Token: 0x04002EBD RID: 11965
	[Token(Token = "0x4002EBD")]
	[FieldOffset(Offset = "0xC0")]
	public TMP_InputField searchInputField;

	// Token: 0x04002EBE RID: 11966
	[Token(Token = "0x4002EBE")]
	[FieldOffset(Offset = "0xC8")]
	private List<FurniturePreset> allRequired;

	// Token: 0x04002EBF RID: 11967
	[Token(Token = "0x4002EBF")]
	[FieldOffset(Offset = "0xD0")]
	private List<FurnitureLocation> allRequiredExisting;

	// Token: 0x04002EC0 RID: 11968
	[Token(Token = "0x4002EC0")]
	[FieldOffset(Offset = "0xD8")]
	public List<DecorElementController> spawnedEntries;

	// Token: 0x02000677 RID: 1655
	[Token(Token = "0x2000677")]
	public enum TabState
	{
		// Token: 0x04002EC2 RID: 11970
		[Token(Token = "0x4002EC2")]
		inRoom,
		// Token: 0x04002EC3 RID: 11971
		[Token(Token = "0x4002EC3")]
		inStorage,
		// Token: 0x04002EC4 RID: 11972
		[Token(Token = "0x4002EC4")]
		inShop
	}

	// Token: 0x02000678 RID: 1656
	[Token(Token = "0x2000678")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060024B3 RID: 9395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x0000EA48 File Offset: 0x0000CC48
		[Token(Token = "0x60024B4")]
		[Address(RVA = "0xBA0250", Offset = "0xB9F250", VA = "0x180BA0250")]
		internal bool <UpdateListDisplay>b__30_0(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x0000EA60 File Offset: 0x0000CC60
		[Token(Token = "0x60024B5")]
		[Address(RVA = "0xBA0390", Offset = "0xB9F390", VA = "0x180BA0390")]
		internal bool <UpdateListDisplay>b__30_1(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x0000EA78 File Offset: 0x0000CC78
		[Token(Token = "0x60024B6")]
		[Address(RVA = "0xBA04D0", Offset = "0xB9F4D0", VA = "0x180BA04D0")]
		internal int <UpdateListDisplay>b__30_3(FurniturePreset p1, FurniturePreset p2)
		{
			return 0;
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x0000EA90 File Offset: 0x0000CC90
		[Token(Token = "0x60024B7")]
		[Address(RVA = "0xBA0510", Offset = "0xB9F510", VA = "0x180BA0510")]
		internal int <UpdateListDisplay>b__30_4(FurnitureLocation p1, FurnitureLocation p2)
		{
			return 0;
		}

		// Token: 0x04002EC5 RID: 11973
		[Token(Token = "0x4002EC5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FurnishingsController.<>c <>9;

		// Token: 0x04002EC6 RID: 11974
		[Token(Token = "0x4002EC6")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<FurnitureLocation> <>9__30_0;

		// Token: 0x04002EC7 RID: 11975
		[Token(Token = "0x4002EC7")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<FurnitureLocation> <>9__30_1;

		// Token: 0x04002EC8 RID: 11976
		[Token(Token = "0x4002EC8")]
		[FieldOffset(Offset = "0x18")]
		public static Comparison<FurniturePreset> <>9__30_3;

		// Token: 0x04002EC9 RID: 11977
		[Token(Token = "0x4002EC9")]
		[FieldOffset(Offset = "0x20")]
		public static Comparison<FurnitureLocation> <>9__30_4;
	}
}
