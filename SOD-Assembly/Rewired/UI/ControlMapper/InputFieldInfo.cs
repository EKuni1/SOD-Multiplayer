using System;
using Il2CppDummyDll;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200093F RID: 2367
	[Token(Token = "0x200093F")]
	public class InputFieldInfo : UIElementInfo
	{
		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060031D8 RID: 12760 RVA: 0x00011CD0 File Offset: 0x0000FED0
		// (set) Token: 0x060031D9 RID: 12761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046E")]
		public int actionId
		{
			[Token(Token = "0x60031D8")]
			[Address(RVA = "0xD28F40", Offset = "0xD27F40", VA = "0x180D28F40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60031D9")]
			[Address(RVA = "0xD28F50", Offset = "0xD27F50", VA = "0x180D28F50")]
			set
			{
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060031DA RID: 12762 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		// (set) Token: 0x060031DB RID: 12763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046F")]
		public AxisRange axisRange
		{
			[Token(Token = "0x60031DA")]
			[Address(RVA = "0xCF71C0", Offset = "0xCF61C0", VA = "0x180CF71C0")]
			get
			{
				return AxisRange.Full;
			}
			[Token(Token = "0x60031DB")]
			[Address(RVA = "0xD28F60", Offset = "0xD27F60", VA = "0x180D28F60")]
			set
			{
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060031DC RID: 12764 RVA: 0x00011D00 File Offset: 0x0000FF00
		// (set) Token: 0x060031DD RID: 12765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000470")]
		public int actionElementMapId
		{
			[Token(Token = "0x60031DC")]
			[Address(RVA = "0xD28F70", Offset = "0xD27F70", VA = "0x180D28F70")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60031DD")]
			[Address(RVA = "0xD28F80", Offset = "0xD27F80", VA = "0x180D28F80")]
			set
			{
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060031DE RID: 12766 RVA: 0x00011D18 File Offset: 0x0000FF18
		// (set) Token: 0x060031DF RID: 12767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000471")]
		public ControllerType controllerType
		{
			[Token(Token = "0x60031DE")]
			[Address(RVA = "0xCF72A0", Offset = "0xCF62A0", VA = "0x180CF72A0")]
			get
			{
				return ControllerType.Keyboard;
			}
			[Token(Token = "0x60031DF")]
			[Address(RVA = "0xD28F90", Offset = "0xD27F90", VA = "0x180D28F90")]
			set
			{
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060031E0 RID: 12768 RVA: 0x00011D30 File Offset: 0x0000FF30
		// (set) Token: 0x060031E1 RID: 12769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000472")]
		public int controllerId
		{
			[Token(Token = "0x60031E0")]
			[Address(RVA = "0xCF7310", Offset = "0xCF6310", VA = "0x180CF7310")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60031E1")]
			[Address(RVA = "0xD28FA0", Offset = "0xD27FA0", VA = "0x180D28FA0")]
			set
			{
			}
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031E2")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public InputFieldInfo()
		{
		}

		// Token: 0x04004F42 RID: 20290
		[Token(Token = "0x4004F42")]
		[FieldOffset(Offset = "0x38")]
		private int <actionId>k__BackingField;

		// Token: 0x04004F43 RID: 20291
		[Token(Token = "0x4004F43")]
		[FieldOffset(Offset = "0x3C")]
		private AxisRange <axisRange>k__BackingField;

		// Token: 0x04004F44 RID: 20292
		[Token(Token = "0x4004F44")]
		[FieldOffset(Offset = "0x40")]
		private int <actionElementMapId>k__BackingField;

		// Token: 0x04004F45 RID: 20293
		[Token(Token = "0x4004F45")]
		[FieldOffset(Offset = "0x44")]
		private ControllerType <controllerType>k__BackingField;

		// Token: 0x04004F46 RID: 20294
		[Token(Token = "0x4004F46")]
		[FieldOffset(Offset = "0x48")]
		private int <controllerId>k__BackingField;
	}
}
