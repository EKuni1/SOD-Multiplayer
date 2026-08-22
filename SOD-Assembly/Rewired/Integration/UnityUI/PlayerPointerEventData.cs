using System;
using Il2CppDummyDll;
using Rewired.UI;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x02000900 RID: 2304
	[Token(Token = "0x2000900")]
	public class PlayerPointerEventData : PointerEventData
	{
		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06002DFB RID: 11771 RVA: 0x00010980 File Offset: 0x0000EB80
		// (set) Token: 0x06002DFC RID: 11772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000370")]
		public int playerId
		{
			[Token(Token = "0x6002DFB")]
			[Address(RVA = "0xCE44F0", Offset = "0xCE34F0", VA = "0x180CE44F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002DFC")]
			[Address(RVA = "0xCE4500", Offset = "0xCE3500", VA = "0x180CE4500")]
			set
			{
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x00010998 File Offset: 0x0000EB98
		// (set) Token: 0x06002DFE RID: 11774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000371")]
		public int inputSourceIndex
		{
			[Token(Token = "0x6002DFD")]
			[Address(RVA = "0xCE4510", Offset = "0xCE3510", VA = "0x180CE4510")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002DFE")]
			[Address(RVA = "0xCE4520", Offset = "0xCE3520", VA = "0x180CE4520")]
			set
			{
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E00 RID: 11776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000372")]
		public IMouseInputSource mouseSource
		{
			[Token(Token = "0x6002DFF")]
			[Address(RVA = "0xCE4530", Offset = "0xCE3530", VA = "0x180CE4530")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E00")]
			[Address(RVA = "0xCE4540", Offset = "0xCE3540", VA = "0x180CE4540")]
			set
			{
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E02 RID: 11778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000373")]
		public ITouchInputSource touchSource
		{
			[Token(Token = "0x6002E01")]
			[Address(RVA = "0xCE45A0", Offset = "0xCE35A0", VA = "0x180CE45A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E02")]
			[Address(RVA = "0xCE45B0", Offset = "0xCE35B0", VA = "0x180CE45B0")]
			set
			{
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x000109B0 File Offset: 0x0000EBB0
		// (set) Token: 0x06002E04 RID: 11780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000374")]
		public PointerEventType sourceType
		{
			[Token(Token = "0x6002E03")]
			[Address(RVA = "0xCE4610", Offset = "0xCE3610", VA = "0x180CE4610")]
			get
			{
				return PointerEventType.Mouse;
			}
			[Token(Token = "0x6002E04")]
			[Address(RVA = "0xCE4620", Offset = "0xCE3620", VA = "0x180CE4620")]
			set
			{
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06002E05 RID: 11781 RVA: 0x000109C8 File Offset: 0x0000EBC8
		// (set) Token: 0x06002E06 RID: 11782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000375")]
		public int buttonIndex
		{
			[Token(Token = "0x6002E05")]
			[Address(RVA = "0xCE4630", Offset = "0xCE3630", VA = "0x180CE4630")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002E06")]
			[Address(RVA = "0xCE4640", Offset = "0xCE3640", VA = "0x180CE4640")]
			set
			{
			}
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E07")]
		[Address(RVA = "0xCE4650", Offset = "0xCE3650", VA = "0x180CE4650")]
		public PlayerPointerEventData(EventSystem eventSystem)
		{
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E08")]
		[Address(RVA = "0xCE4680", Offset = "0xCE3680", VA = "0x180CE4680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04004D72 RID: 19826
		[Token(Token = "0x4004D72")]
		[FieldOffset(Offset = "0x170")]
		private int <playerId>k__BackingField;

		// Token: 0x04004D73 RID: 19827
		[Token(Token = "0x4004D73")]
		[FieldOffset(Offset = "0x174")]
		private int <inputSourceIndex>k__BackingField;

		// Token: 0x04004D74 RID: 19828
		[Token(Token = "0x4004D74")]
		[FieldOffset(Offset = "0x178")]
		private IMouseInputSource <mouseSource>k__BackingField;

		// Token: 0x04004D75 RID: 19829
		[Token(Token = "0x4004D75")]
		[FieldOffset(Offset = "0x180")]
		private ITouchInputSource <touchSource>k__BackingField;

		// Token: 0x04004D76 RID: 19830
		[Token(Token = "0x4004D76")]
		[FieldOffset(Offset = "0x188")]
		private PointerEventType <sourceType>k__BackingField;

		// Token: 0x04004D77 RID: 19831
		[Token(Token = "0x4004D77")]
		[FieldOffset(Offset = "0x18C")]
		private int <buttonIndex>k__BackingField;
	}
}
