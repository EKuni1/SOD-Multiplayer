using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000585 RID: 1413
[Token(Token = "0x2000585")]
public class FlashController : MonoBehaviour
{
	// Token: 0x06001EAB RID: 7851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EAB")]
	[Address(RVA = "0xA55FB0", Offset = "0xA54FB0", VA = "0x180A55FB0")]
	private void Start()
	{
	}

	// Token: 0x06001EAC RID: 7852 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EAC")]
	[Address(RVA = "0xA56100", Offset = "0xA55100", VA = "0x180A56100")]
	public void Flash(int newRepeat)
	{
	}

	// Token: 0x06001EAD RID: 7853 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EAD")]
	[Address(RVA = "0xA561D0", Offset = "0xA551D0", VA = "0x180A561D0")]
	public IEnumerator FlashColour(int newRepeat)
	{
		return null;
	}

	// Token: 0x06001EAE RID: 7854 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EAE")]
	[Address(RVA = "0xA56280", Offset = "0xA55280", VA = "0x180A56280")]
	private void OnDisable()
	{
	}

	// Token: 0x06001EAF RID: 7855 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EAF")]
	[Address(RVA = "0xA563D0", Offset = "0xA553D0", VA = "0x180A563D0")]
	public FlashController()
	{
	}

	// Token: 0x0400273E RID: 10046
	[Token(Token = "0x400273E")]
	[FieldOffset(Offset = "0x18")]
	public List<Image> colourCodeElements;

	// Token: 0x0400273F RID: 10047
	[Token(Token = "0x400273F")]
	[FieldOffset(Offset = "0x20")]
	public bool getNormalColourAtStart;

	// Token: 0x04002740 RID: 10048
	[Token(Token = "0x4002740")]
	[FieldOffset(Offset = "0x24")]
	public Color normalColour;

	// Token: 0x04002741 RID: 10049
	[Token(Token = "0x4002741")]
	[FieldOffset(Offset = "0x34")]
	public Color flashColour;

	// Token: 0x04002742 RID: 10050
	[Token(Token = "0x4002742")]
	[FieldOffset(Offset = "0x44")]
	public float speed;

	// Token: 0x04002743 RID: 10051
	[Token(Token = "0x4002743")]
	[FieldOffset(Offset = "0x48")]
	private bool flashActive;

	// Token: 0x04002744 RID: 10052
	[Token(Token = "0x4002744")]
	[FieldOffset(Offset = "0x4C")]
	private int repeat;

	// Token: 0x02000586 RID: 1414
	[Token(Token = "0x2000586")]
	private sealed class <FlashColour>d__9 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001EB0 RID: 7856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB0")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <FlashColour>d__9(int <>1__state)
		{
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x0000DA88 File Offset: 0x0000BC88
		[Token(Token = "0x6001EB2")]
		[Address(RVA = "0xA564F0", Offset = "0xA554F0", VA = "0x180A564F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F8")]
		private object Current
		{
			[Token(Token = "0x6001EB3")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB4")]
		[Address(RVA = "0xA567E0", Offset = "0xA557E0", VA = "0x180A567E0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F9")]
		private object Current
		{
			[Token(Token = "0x6001EB5")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002745 RID: 10053
		[Token(Token = "0x4002745")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002746 RID: 10054
		[Token(Token = "0x4002746")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002747 RID: 10055
		[Token(Token = "0x4002747")]
		[FieldOffset(Offset = "0x20")]
		public FlashController <>4__this;

		// Token: 0x04002748 RID: 10056
		[Token(Token = "0x4002748")]
		[FieldOffset(Offset = "0x28")]
		public int newRepeat;

		// Token: 0x04002749 RID: 10057
		[Token(Token = "0x4002749")]
		[FieldOffset(Offset = "0x2C")]
		private int <cycle>5__2;

		// Token: 0x0400274A RID: 10058
		[Token(Token = "0x400274A")]
		[FieldOffset(Offset = "0x30")]
		private float <progress>5__3;
	}
}
