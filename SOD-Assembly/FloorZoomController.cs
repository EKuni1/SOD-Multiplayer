using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000636 RID: 1590
[Token(Token = "0x2000636")]
public class FloorZoomController : MonoBehaviour
{
	// Token: 0x060022E4 RID: 8932 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022E4")]
	[Address(RVA = "0xB41320", Offset = "0xB40320", VA = "0x180B41320")]
	public void AddFloor(int addVal)
	{
	}

	// Token: 0x060022E5 RID: 8933 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022E5")]
	[Address(RVA = "0xB413C0", Offset = "0xB403C0", VA = "0x180B413C0")]
	public void OnSliderChangeFloor()
	{
	}

	// Token: 0x060022E6 RID: 8934 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022E6")]
	[Address(RVA = "0xB41450", Offset = "0xB40450", VA = "0x180B41450")]
	public void CentreOnPlayer()
	{
	}

	// Token: 0x060022E7 RID: 8935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022E7")]
	[Address(RVA = "0xB41530", Offset = "0xB40530", VA = "0x180B41530")]
	public void CancelRouteButton()
	{
	}

	// Token: 0x060022E8 RID: 8936 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022E8")]
	[Address(RVA = "0xB415E0", Offset = "0xB405E0", VA = "0x180B415E0")]
	public void AutoTravelButton()
	{
	}

	// Token: 0x060022E9 RID: 8937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022E9")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public FloorZoomController()
	{
	}

	// Token: 0x04002CA9 RID: 11433
	[Token(Token = "0x4002CA9")]
	[FieldOffset(Offset = "0x18")]
	public SliderController floorSlider;

	// Token: 0x04002CAA RID: 11434
	[Token(Token = "0x4002CAA")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI floorText;
}
