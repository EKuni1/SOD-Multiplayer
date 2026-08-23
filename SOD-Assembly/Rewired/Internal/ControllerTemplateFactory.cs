using System;
using Il2CppDummyDll;

namespace Rewired.Internal
{
	// Token: 0x020008FF RID: 2303
	[Token(Token = "0x20008FF")]
	public static class ControllerTemplateFactory
	{
		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06002DF7 RID: 11767 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700036E")]
		public static Type[] templateTypes
		{
			[Token(Token = "0x6002DF7")]
			[Address(RVA = "0xCE37A0", Offset = "0xCE27A0", VA = "0x180CE37A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06002DF8 RID: 11768 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700036F")]
		public static Type[] templateInterfaceTypes
		{
			[Token(Token = "0x6002DF8")]
			[Address(RVA = "0xCE3800", Offset = "0xCE2800", VA = "0x180CE3800")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DF9")]
		[Address(RVA = "0xCE3860", Offset = "0xCE2860", VA = "0x180CE3860")]
		public static IControllerTemplate Create(Guid typeGuid, object payload)
		{
			return null;
		}

		// Token: 0x04004D70 RID: 19824
		[Token(Token = "0x4004D70")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] _defaultTemplateTypes;

		// Token: 0x04004D71 RID: 19825
		[Token(Token = "0x4004D71")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type[] _defaultTemplateInterfaceTypes;
	}
}
