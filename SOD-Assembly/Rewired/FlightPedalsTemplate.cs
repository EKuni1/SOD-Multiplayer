using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Rewired
{
	// Token: 0x020008F2 RID: 2290
	[Token(Token = "0x20008F2")]
	public sealed class FlightPedalsTemplate : ControllerTemplate, IEnumerator<object>, IDisposable
	{
		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06002CFA RID: 11514 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000331")]
		private IControllerTemplateAxis leftPedal
		{
			[Token(Token = "0x6002CFA")]
			[Address(RVA = "0xCD8B20", Offset = "0xCD7B20", VA = "0x180CD8B20", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000332")]
		private IControllerTemplateAxis rightPedal
		{
			[Token(Token = "0x6002CFB")]
			[Address(RVA = "0xCD8B60", Offset = "0xCD7B60", VA = "0x180CD8B60", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000333")]
		private IControllerTemplateAxis slide
		{
			[Token(Token = "0x6002CFC")]
			[Address(RVA = "0xCD8BB0", Offset = "0xCD7BB0", VA = "0x180CD8BB0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CFD")]
		[Address(RVA = "0xCD4D30", Offset = "0xCD3D30", VA = "0x180CD4D30")]
		public FlightPedalsTemplate(object payload)
		{
		}

		// Token: 0x04004CFF RID: 19711
		[Token(Token = "0x4004CFF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Guid typeGuid;

		// Token: 0x04004D00 RID: 19712
		[Token(Token = "0x4004D00")]
		public const int elementId_leftPedal = 0;

		// Token: 0x04004D01 RID: 19713
		[Token(Token = "0x4004D01")]
		public const int elementId_rightPedal = 1;

		// Token: 0x04004D02 RID: 19714
		[Token(Token = "0x4004D02")]
		public const int elementId_slide = 2;
	}
}
