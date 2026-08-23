using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000202 RID: 514
[Token(Token = "0x2000202")]
public class CityEditorStreetEdit : MonoBehaviour
{
	// Token: 0x06000C45 RID: 3141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C45")]
	[Address(RVA = "0x592B20", Offset = "0x591B20", VA = "0x180592B20")]
	private void OnEnable()
	{
	}

	// Token: 0x06000C46 RID: 3142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C46")]
	[Address(RVA = "0x592E10", Offset = "0x591E10", VA = "0x180592E10")]
	private void Update()
	{
	}

	// Token: 0x06000C47 RID: 3143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C47")]
	[Address(RVA = "0x593390", Offset = "0x592390", VA = "0x180593390")]
	public void ResetStreets()
	{
	}

	// Token: 0x06000C48 RID: 3144 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C48")]
	[Address(RVA = "0x593590", Offset = "0x592590", VA = "0x180593590")]
	private StreetController TryGetStreet()
	{
		return null;
	}

	// Token: 0x06000C49 RID: 3145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C49")]
	[Address(RVA = "0x5939E0", Offset = "0x5929E0", VA = "0x1805939E0")]
	public void SetSelectedStreet(StreetController newSt)
	{
	}

	// Token: 0x06000C4A RID: 3146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C4A")]
	[Address(RVA = "0x593BB0", Offset = "0x592BB0", VA = "0x180593BB0")]
	private void DrawStreetSelection(StreetController street, bool isMouseOver)
	{
	}

	// Token: 0x06000C4B RID: 3147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0x594030", Offset = "0x593030", VA = "0x180594030")]
	private void RemoveStreetSelection(bool isMouseOver)
	{
	}

	// Token: 0x06000C4C RID: 3148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C4C")]
	[Address(RVA = "0x5943A0", Offset = "0x5933A0", VA = "0x1805943A0")]
	public void RenameSelectedStreet(string newStreetName)
	{
	}

	// Token: 0x06000C4D RID: 3149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C4D")]
	[Address(RVA = "0x594510", Offset = "0x593510", VA = "0x180594510")]
	private void ResetSelection()
	{
	}

	// Token: 0x06000C4E RID: 3150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C4E")]
	[Address(RVA = "0x594570", Offset = "0x593570", VA = "0x180594570")]
	public void OnGenerateNewCityMap()
	{
	}

	// Token: 0x06000C4F RID: 3151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C4F")]
	[Address(RVA = "0x594600", Offset = "0x593600", VA = "0x180594600")]
	public void RepopulateStreetList()
	{
	}

	// Token: 0x06000C50 RID: 3152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C50")]
	[Address(RVA = "0x594BC0", Offset = "0x593BC0", VA = "0x180594BC0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000C51 RID: 3153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C51")]
	[Address(RVA = "0x594EB0", Offset = "0x593EB0", VA = "0x180594EB0")]
	public CityEditorStreetEdit()
	{
	}

	// Token: 0x04000CB2 RID: 3250
	[Token(Token = "0x4000CB2")]
	[FieldOffset(Offset = "0x18")]
	public GameObject streetListElementPrefab;

	// Token: 0x04000CB3 RID: 3251
	[Token(Token = "0x4000CB3")]
	[FieldOffset(Offset = "0x20")]
	public GameObject streetSelectionDisplayPrefab;

	// Token: 0x04000CB4 RID: 3252
	[Token(Token = "0x4000CB4")]
	[FieldOffset(Offset = "0x28")]
	public GameObject streetMouseOverDisplayPrefab;

	// Token: 0x04000CB5 RID: 3253
	[Token(Token = "0x4000CB5")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform streetListContentRect;

	// Token: 0x04000CB6 RID: 3254
	[Token(Token = "0x4000CB6")]
	[FieldOffset(Offset = "0x38")]
	public VerticalLayoutGroup listLayout;

	// Token: 0x04000CB7 RID: 3255
	[Token(Token = "0x4000CB7")]
	[FieldOffset(Offset = "0x40")]
	public StreetController currentlySelectedStreet;

	// Token: 0x04000CB8 RID: 3256
	[Token(Token = "0x4000CB8")]
	[FieldOffset(Offset = "0x48")]
	public StreetController currentlyMousedOverStreet;

	// Token: 0x04000CB9 RID: 3257
	[Token(Token = "0x4000CB9")]
	[FieldOffset(Offset = "0x50")]
	private StreetController previouslyMousedOverStreet;

	// Token: 0x04000CBA RID: 3258
	[Token(Token = "0x4000CBA")]
	[FieldOffset(Offset = "0x58")]
	private List<CityEditorStreetsEditListElement> spawnedStreetListElements;

	// Token: 0x04000CBB RID: 3259
	[Token(Token = "0x4000CBB")]
	[FieldOffset(Offset = "0x60")]
	private List<GameObject> spawnedStreetSelectionObjects;

	// Token: 0x04000CBC RID: 3260
	[Token(Token = "0x4000CBC")]
	[FieldOffset(Offset = "0x68")]
	private List<GameObject> spawnedStreetMouseOverObjects;
}
