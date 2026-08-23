using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000573 RID: 1395
[Token(Token = "0x2000573")]
public class ControlGraphicController : MonoBehaviour
{
	// Token: 0x06001E52 RID: 7762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E52")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	private void OnEnable()
	{
	}

	// Token: 0x06001E53 RID: 7763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E53")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ControlGraphicController()
	{
	}

	// Token: 0x040026E4 RID: 9956
	[Token(Token = "0x40026E4")]
	[FieldOffset(Offset = "0x18")]
	public Image img;

	// Token: 0x040026E5 RID: 9957
	[Token(Token = "0x40026E5")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI controlText;

	// Token: 0x040026E6 RID: 9958
	[Token(Token = "0x40026E6")]
	[FieldOffset(Offset = "0x28")]
	public ControlGraphicController.ControlGraphicType controlType;

	// Token: 0x040026E7 RID: 9959
	[Token(Token = "0x40026E7")]
	[FieldOffset(Offset = "0x30")]
	public string trackControl;

	// Token: 0x040026E8 RID: 9960
	[Token(Token = "0x40026E8")]
	[FieldOffset(Offset = "0x38")]
	public string buttonStr;

	// Token: 0x02000574 RID: 1396
	[Token(Token = "0x2000574")]
	public enum ControlGraphicType
	{
		// Token: 0x040026EA RID: 9962
		[Token(Token = "0x40026EA")]
		keyboard,
		// Token: 0x040026EB RID: 9963
		[Token(Token = "0x40026EB")]
		mouse,
		// Token: 0x040026EC RID: 9964
		[Token(Token = "0x40026EC")]
		controller
	}
}
