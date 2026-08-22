using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006CB RID: 1739
[Token(Token = "0x20006CB")]
public class CaseComponent
{
	// Token: 0x1400004F RID: 79
	// (add) Token: 0x060026C5 RID: 9925 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060026C6 RID: 9926 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400004F")]
	public event CaseComponent.DiscoveredThis OnDiscoveredThis
	{
		[Token(Token = "0x60026C5")]
		[Address(RVA = "0xBF4B00", Offset = "0xBF3B00", VA = "0x180BF4B00")]
		add
		{
		}
		[Token(Token = "0x60026C6")]
		[Address(RVA = "0xBF4BF0", Offset = "0xBF3BF0", VA = "0x180BF4BF0")]
		remove
		{
		}
	}

	// Token: 0x14000050 RID: 80
	// (add) Token: 0x060026C7 RID: 9927 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060026C8 RID: 9928 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000050")]
	public event CaseComponent.NewName OnNewName
	{
		[Token(Token = "0x60026C7")]
		[Address(RVA = "0xBF4CE0", Offset = "0xBF3CE0", VA = "0x180BF4CE0")]
		add
		{
		}
		[Token(Token = "0x60026C8")]
		[Address(RVA = "0xBF4DD0", Offset = "0xBF3DD0", VA = "0x180BF4DD0")]
		remove
		{
		}
	}

	// Token: 0x14000051 RID: 81
	// (add) Token: 0x060026C9 RID: 9929 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060026CA RID: 9930 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000051")]
	public event CaseComponent.NewSprite OnNewSprite
	{
		[Token(Token = "0x60026C9")]
		[Address(RVA = "0xBF4EC0", Offset = "0xBF3EC0", VA = "0x180BF4EC0")]
		add
		{
		}
		[Token(Token = "0x60026CA")]
		[Address(RVA = "0xBF4FB0", Offset = "0xBF3FB0", VA = "0x180BF4FB0")]
		remove
		{
		}
	}

	// Token: 0x060026CB RID: 9931 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026CB")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public CaseComponent()
	{
	}

	// Token: 0x060026CC RID: 9932 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026CC")]
	[Address(RVA = "0xBF50A0", Offset = "0xBF40A0", VA = "0x180BF50A0", Slot = "4")]
	public virtual void SetFound(bool newVal)
	{
	}

	// Token: 0x060026CD RID: 9933 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026CD")]
	[Address(RVA = "0xBF5100", Offset = "0xBF4100", VA = "0x180BF5100", Slot = "5")]
	public virtual string GetIdentifier()
	{
		return null;
	}

	// Token: 0x060026CE RID: 9934 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026CE")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "6")]
	public virtual void OnDiscovery()
	{
	}

	// Token: 0x060026CF RID: 9935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026CF")]
	[Address(RVA = "0xBF5140", Offset = "0xBF4140", VA = "0x180BF5140", Slot = "7")]
	public virtual void UpdateName()
	{
	}

	// Token: 0x060026D0 RID: 9936 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026D0")]
	[Address(RVA = "0xBF5290", Offset = "0xBF4290", VA = "0x180BF5290", Slot = "8")]
	public virtual string GenerateName()
	{
		return null;
	}

	// Token: 0x060026D1 RID: 9937 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026D1")]
	[Address(RVA = "0xBF52D0", Offset = "0xBF42D0", VA = "0x180BF52D0", Slot = "9")]
	public virtual string FoundAtName()
	{
		return null;
	}

	// Token: 0x060026D2 RID: 9938 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026D2")]
	[Address(RVA = "0xBF5310", Offset = "0xBF4310", VA = "0x180BF5310", Slot = "10")]
	public virtual string GenerateNameSuffix()
	{
		return null;
	}

	// Token: 0x060026D3 RID: 9939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026D3")]
	[Address(RVA = "0xBF5350", Offset = "0xBF4350", VA = "0x180BF5350")]
	public void SetNewIcon(Sprite newLarge)
	{
	}

	// Token: 0x04003215 RID: 12821
	[Token(Token = "0x4003215")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	// Token: 0x04003216 RID: 12822
	[Token(Token = "0x4003216")]
	[FieldOffset(Offset = "0x18")]
	public bool isFound;

	// Token: 0x04003217 RID: 12823
	[Token(Token = "0x4003217")]
	[FieldOffset(Offset = "0x20")]
	public Sprite iconSprite;

	// Token: 0x020006CC RID: 1740
	// (Invoke) Token: 0x060026D5 RID: 9941
	[Token(Token = "0x20006CC")]
	public delegate void DiscoveredThis(CaseComponent discovered);

	// Token: 0x020006CD RID: 1741
	// (Invoke) Token: 0x060026D9 RID: 9945
	[Token(Token = "0x20006CD")]
	public delegate void NewName();

	// Token: 0x020006CE RID: 1742
	// (Invoke) Token: 0x060026DD RID: 9949
	[Token(Token = "0x20006CE")]
	public delegate void NewSprite();
}
