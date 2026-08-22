using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008B4 RID: 2228
[Token(Token = "0x20008B4")]
public class CriminalControls : MonoBehaviour
{
	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06002A26 RID: 10790 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700014E")]
	public static CriminalControls Instance
	{
		[Token(Token = "0x6002A26")]
		[Address(RVA = "0xCB8C40", Offset = "0xCB7C40", VA = "0x180CB8C40")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002A27 RID: 10791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A27")]
	[Address(RVA = "0xCB8C80", Offset = "0xCB7C80", VA = "0x180CB8C80")]
	private void Awake()
	{
	}

	// Token: 0x06002A28 RID: 10792 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A28")]
	[Address(RVA = "0xCB8FD0", Offset = "0xCB7FD0", VA = "0x180CB8FD0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002A29 RID: 10793 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A29")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public CriminalControls()
	{
	}

	// Token: 0x04004651 RID: 18001
	[Token(Token = "0x4004651")]
	[FieldOffset(Offset = "0x18")]
	public SpatterPatternPreset punchSpatter;

	// Token: 0x04004652 RID: 18002
	[Token(Token = "0x4004652")]
	[FieldOffset(Offset = "0x20")]
	public MurderWeaponPreset sniperRifle;

	// Token: 0x04004653 RID: 18003
	[Token(Token = "0x4004653")]
	[FieldOffset(Offset = "0x0")]
	private static CriminalControls _instance;
}
