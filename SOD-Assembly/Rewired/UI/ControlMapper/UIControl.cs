using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000955 RID: 2389
	[Token(Token = "0x2000955")]
	public class UIControl : MonoBehaviour
	{
		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060032DD RID: 13021 RVA: 0x00012000 File Offset: 0x00010200
		[Token(Token = "0x170004FD")]
		public int id
		{
			[Token(Token = "0x60032DD")]
			[Address(RVA = "0x6AA670", Offset = "0x6A9670", VA = "0x1806AA670")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032DE")]
		[Address(RVA = "0xD30660", Offset = "0xD2F660", VA = "0x180D30660")]
		private void Awake()
		{
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060032DF RID: 13023 RVA: 0x00012018 File Offset: 0x00010218
		// (set) Token: 0x060032E0 RID: 13024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004FE")]
		public bool showTitle
		{
			[Token(Token = "0x60032DF")]
			[Address(RVA = "0x409EB0", Offset = "0x408EB0", VA = "0x180409EB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032E0")]
			[Address(RVA = "0xD306D0", Offset = "0xD2F6D0", VA = "0x180D306D0")]
			set
			{
			}
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "4")]
		public virtual void SetCancelCallback(Action cancelCallback)
		{
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x00012030 File Offset: 0x00010230
		[Token(Token = "0x60032E2")]
		[Address(RVA = "0xD30880", Offset = "0xD2F880", VA = "0x180D30880")]
		private static int GetNextUid()
		{
			return 0;
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E3")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public UIControl()
		{
		}

		// Token: 0x04004FDD RID: 20445
		[Token(Token = "0x4004FDD")]
		[FieldOffset(Offset = "0x18")]
		public TMP_Text title;

		// Token: 0x04004FDE RID: 20446
		[Token(Token = "0x4004FDE")]
		[FieldOffset(Offset = "0x20")]
		private int _id;

		// Token: 0x04004FDF RID: 20447
		[Token(Token = "0x4004FDF")]
		[FieldOffset(Offset = "0x24")]
		private bool _showTitle;

		// Token: 0x04004FE0 RID: 20448
		[Token(Token = "0x4004FE0")]
		[FieldOffset(Offset = "0x0")]
		private static int _uidCounter;
	}
}
