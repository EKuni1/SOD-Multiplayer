using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x020009F7 RID: 2551
	[Token(Token = "0x20009F7")]
	public class ObjectImporterUI : MonoBehaviour
	{
		// Token: 0x0600365C RID: 13916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365C")]
		[Address(RVA = "0xD96F50", Offset = "0xD95F50", VA = "0x180D96F50")]
		private void Awake()
		{
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365D")]
		[Address(RVA = "0xD97460", Offset = "0xD96460", VA = "0x180D97460")]
		private void OnEnable()
		{
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365E")]
		[Address(RVA = "0xD97700", Offset = "0xD96700", VA = "0x180D97700")]
		private void OnDisable()
		{
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365F")]
		[Address(RVA = "0xD979A0", Offset = "0xD969A0", VA = "0x180D979A0")]
		private void Update()
		{
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003660")]
		[Address(RVA = "0xD984B0", Offset = "0xD974B0", VA = "0x180D984B0")]
		private void OnImportStart()
		{
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003661")]
		[Address(RVA = "0xD988F0", Offset = "0xD978F0", VA = "0x180D988F0")]
		private void OnImportComplete()
		{
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003662")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public ObjectImporterUI()
		{
		}

		// Token: 0x040053C6 RID: 21446
		[Token(Token = "0x40053C6")]
		[FieldOffset(Offset = "0x18")]
		public Text progressText;

		// Token: 0x040053C7 RID: 21447
		[Token(Token = "0x40053C7")]
		[FieldOffset(Offset = "0x20")]
		public Slider progressSlider;

		// Token: 0x040053C8 RID: 21448
		[Token(Token = "0x40053C8")]
		[FieldOffset(Offset = "0x28")]
		public Image progressImage;

		// Token: 0x040053C9 RID: 21449
		[Token(Token = "0x40053C9")]
		[FieldOffset(Offset = "0x30")]
		private ObjectImporter objImporter;
	}
}
