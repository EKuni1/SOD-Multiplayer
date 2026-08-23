using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000911 RID: 2321
	[Token(Token = "0x2000911")]
	public class ControlMapper : MonoBehaviour
	{
		// Token: 0x14000066 RID: 102
		// (add) Token: 0x06002ED4 RID: 11988 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002ED5 RID: 11989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000066")]
		public event Action ScreenClosedEvent
		{
			[Token(Token = "0x6002ED4")]
			[Address(RVA = "0xCF5CE0", Offset = "0xCF4CE0", VA = "0x180CF5CE0")]
			add
			{
			}
			[Token(Token = "0x6002ED5")]
			[Address(RVA = "0xCF5DE0", Offset = "0xCF4DE0", VA = "0x180CF5DE0")]
			remove
			{
			}
		}

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x06002ED6 RID: 11990 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002ED7 RID: 11991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000067")]
		public event Action ScreenOpenedEvent
		{
			[Token(Token = "0x6002ED6")]
			[Address(RVA = "0xCF5EE0", Offset = "0xCF4EE0", VA = "0x180CF5EE0")]
			add
			{
			}
			[Token(Token = "0x6002ED7")]
			[Address(RVA = "0xCF5FE0", Offset = "0xCF4FE0", VA = "0x180CF5FE0")]
			remove
			{
			}
		}

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x06002ED8 RID: 11992 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002ED9 RID: 11993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000068")]
		public event Action PopupWindowClosedEvent
		{
			[Token(Token = "0x6002ED8")]
			[Address(RVA = "0xCF60E0", Offset = "0xCF50E0", VA = "0x180CF60E0")]
			add
			{
			}
			[Token(Token = "0x6002ED9")]
			[Address(RVA = "0xCF61E0", Offset = "0xCF51E0", VA = "0x180CF61E0")]
			remove
			{
			}
		}

		// Token: 0x14000069 RID: 105
		// (add) Token: 0x06002EDA RID: 11994 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002EDB RID: 11995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000069")]
		public event Action PopupWindowOpenedEvent
		{
			[Token(Token = "0x6002EDA")]
			[Address(RVA = "0xCF62E0", Offset = "0xCF52E0", VA = "0x180CF62E0")]
			add
			{
			}
			[Token(Token = "0x6002EDB")]
			[Address(RVA = "0xCF63E0", Offset = "0xCF53E0", VA = "0x180CF63E0")]
			remove
			{
			}
		}

		// Token: 0x1400006A RID: 106
		// (add) Token: 0x06002EDC RID: 11996 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002EDD RID: 11997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400006A")]
		public event Action InputPollingStartedEvent
		{
			[Token(Token = "0x6002EDC")]
			[Address(RVA = "0xCF64E0", Offset = "0xCF54E0", VA = "0x180CF64E0")]
			add
			{
			}
			[Token(Token = "0x6002EDD")]
			[Address(RVA = "0xCF65E0", Offset = "0xCF55E0", VA = "0x180CF65E0")]
			remove
			{
			}
		}

		// Token: 0x1400006B RID: 107
		// (add) Token: 0x06002EDE RID: 11998 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002EDF RID: 11999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400006B")]
		public event Action InputPollingEndedEvent
		{
			[Token(Token = "0x6002EDE")]
			[Address(RVA = "0xCF66E0", Offset = "0xCF56E0", VA = "0x180CF66E0")]
			add
			{
			}
			[Token(Token = "0x6002EDF")]
			[Address(RVA = "0xCF67E0", Offset = "0xCF57E0", VA = "0x180CF67E0")]
			remove
			{
			}
		}

		// Token: 0x1400006C RID: 108
		// (add) Token: 0x06002EE0 RID: 12000 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002EE1 RID: 12001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400006C")]
		public event UnityAction onScreenClosed
		{
			[Token(Token = "0x6002EE0")]
			[Address(RVA = "0xCF68E0", Offset = "0xCF58E0", VA = "0x180CF68E0")]
			add
			{
			}
			[Token(Token = "0x6002EE1")]
			[Address(RVA = "0xCF6910", Offset = "0xCF5910", VA = "0x180CF6910")]
			remove
			{
			}
		}

		// Token: 0x1400006D RID: 109
		// (add) Token: 0x06002EE2 RID: 12002 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002EE3 RID: 12003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400006D")]
		public event UnityAction onScreenOpened
		{
			[Token(Token = "0x6002EE2")]
			[Address(RVA = "0xCF6970", Offset = "0xCF5970", VA = "0x180CF6970")]
			add
			{
			}
			[Token(Token = "0x6002EE3")]
			[Address(RVA = "0xCF69A0", Offset = "0xCF59A0", VA = "0x180CF69A0")]
			remove
			{
			}
		}

		// Token: 0x1400006E RID: 110
		// (add) Token: 0x06002EE4 RID: 12004 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002EE5 RID: 12005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400006E")]
		public event UnityAction onPopupWindowClosed
		{
			[Token(Token = "0x6002EE4")]
			[Address(RVA = "0xCF6A00", Offset = "0xCF5A00", VA = "0x180CF6A00")]
			add
			{
			}
			[Token(Token = "0x6002EE5")]
			[Address(RVA = "0xCF6A30", Offset = "0xCF5A30", VA = "0x180CF6A30")]
			remove
			{
			}
		}

		// Token: 0x1400006F RID: 111
		// (add) Token: 0x06002EE6 RID: 12006 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002EE7 RID: 12007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400006F")]
		public event UnityAction onPopupWindowOpened
		{
			[Token(Token = "0x6002EE6")]
			[Address(RVA = "0xCF6A90", Offset = "0xCF5A90", VA = "0x180CF6A90")]
			add
			{
			}
			[Token(Token = "0x6002EE7")]
			[Address(RVA = "0xCF6AC0", Offset = "0xCF5AC0", VA = "0x180CF6AC0")]
			remove
			{
			}
		}

		// Token: 0x14000070 RID: 112
		// (add) Token: 0x06002EE8 RID: 12008 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002EE9 RID: 12009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000070")]
		public event UnityAction onInputPollingStarted
		{
			[Token(Token = "0x6002EE8")]
			[Address(RVA = "0xCF6B20", Offset = "0xCF5B20", VA = "0x180CF6B20")]
			add
			{
			}
			[Token(Token = "0x6002EE9")]
			[Address(RVA = "0xCF6B50", Offset = "0xCF5B50", VA = "0x180CF6B50")]
			remove
			{
			}
		}

		// Token: 0x14000071 RID: 113
		// (add) Token: 0x06002EEA RID: 12010 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002EEB RID: 12011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000071")]
		public event UnityAction onInputPollingEnded
		{
			[Token(Token = "0x6002EEA")]
			[Address(RVA = "0xCF6BB0", Offset = "0xCF5BB0", VA = "0x180CF6BB0")]
			add
			{
			}
			[Token(Token = "0x6002EEB")]
			[Address(RVA = "0xCF6BE0", Offset = "0xCF5BE0", VA = "0x180CF6BE0")]
			remove
			{
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06002EEC RID: 12012 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002EED RID: 12013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A4")]
		public InputManager rewiredInputManager
		{
			[Token(Token = "0x6002EEC")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EED")]
			[Address(RVA = "0xCF6C40", Offset = "0xCF5C40", VA = "0x180CF6C40")]
			set
			{
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06002EEE RID: 12014 RVA: 0x00011040 File Offset: 0x0000F240
		// (set) Token: 0x06002EEF RID: 12015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A5")]
		public bool dontDestroyOnLoad
		{
			[Token(Token = "0x6002EEE")]
			[Address(RVA = "0x6B74A0", Offset = "0x6B64A0", VA = "0x1806B74A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002EEF")]
			[Address(RVA = "0xCF6CF0", Offset = "0xCF5CF0", VA = "0x180CF6CF0")]
			set
			{
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06002EF0 RID: 12016 RVA: 0x00011058 File Offset: 0x0000F258
		// (set) Token: 0x06002EF1 RID: 12017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A6")]
		public int keyboardMapDefaultLayout
		{
			[Token(Token = "0x6002EF0")]
			[Address(RVA = "0xCF6E40", Offset = "0xCF5E40", VA = "0x180CF6E40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002EF1")]
			[Address(RVA = "0xCF6E50", Offset = "0xCF5E50", VA = "0x180CF6E50")]
			set
			{
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06002EF2 RID: 12018 RVA: 0x00011070 File Offset: 0x0000F270
		// (set) Token: 0x06002EF3 RID: 12019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A7")]
		public int mouseMapDefaultLayout
		{
			[Token(Token = "0x6002EF2")]
			[Address(RVA = "0xCF6EB0", Offset = "0xCF5EB0", VA = "0x180CF6EB0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002EF3")]
			[Address(RVA = "0xCF6EC0", Offset = "0xCF5EC0", VA = "0x180CF6EC0")]
			set
			{
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06002EF4 RID: 12020 RVA: 0x00011088 File Offset: 0x0000F288
		// (set) Token: 0x06002EF5 RID: 12021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A8")]
		public int joystickMapDefaultLayout
		{
			[Token(Token = "0x6002EF4")]
			[Address(RVA = "0xCF6F20", Offset = "0xCF5F20", VA = "0x180CF6F20")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002EF5")]
			[Address(RVA = "0xCF6F30", Offset = "0xCF5F30", VA = "0x180CF6F30")]
			set
			{
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06002EF6 RID: 12022 RVA: 0x000110A0 File Offset: 0x0000F2A0
		// (set) Token: 0x06002EF7 RID: 12023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A9")]
		public bool showPlayers
		{
			[Token(Token = "0x6002EF6")]
			[Address(RVA = "0xCF6F90", Offset = "0xCF5F90", VA = "0x180CF6F90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002EF7")]
			[Address(RVA = "0xCF7010", Offset = "0xCF6010", VA = "0x180CF7010")]
			set
			{
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06002EF8 RID: 12024 RVA: 0x000110B8 File Offset: 0x0000F2B8
		// (set) Token: 0x06002EF9 RID: 12025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AA")]
		public bool showControllers
		{
			[Token(Token = "0x6002EF8")]
			[Address(RVA = "0xCF7070", Offset = "0xCF6070", VA = "0x180CF7070")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002EF9")]
			[Address(RVA = "0xCF7080", Offset = "0xCF6080", VA = "0x180CF7080")]
			set
			{
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06002EFA RID: 12026 RVA: 0x000110D0 File Offset: 0x0000F2D0
		// (set) Token: 0x06002EFB RID: 12027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AB")]
		public bool showKeyboard
		{
			[Token(Token = "0x6002EFA")]
			[Address(RVA = "0xCF70E0", Offset = "0xCF60E0", VA = "0x180CF70E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002EFB")]
			[Address(RVA = "0xCF70F0", Offset = "0xCF60F0", VA = "0x180CF70F0")]
			set
			{
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x000110E8 File Offset: 0x0000F2E8
		// (set) Token: 0x06002EFD RID: 12029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AC")]
		public bool showMouse
		{
			[Token(Token = "0x6002EFC")]
			[Address(RVA = "0xCF7150", Offset = "0xCF6150", VA = "0x180CF7150")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002EFD")]
			[Address(RVA = "0xCF7160", Offset = "0xCF6160", VA = "0x180CF7160")]
			set
			{
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06002EFE RID: 12030 RVA: 0x00011100 File Offset: 0x0000F300
		// (set) Token: 0x06002EFF RID: 12031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AD")]
		public int maxControllersPerPlayer
		{
			[Token(Token = "0x6002EFE")]
			[Address(RVA = "0xCF71C0", Offset = "0xCF61C0", VA = "0x180CF71C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002EFF")]
			[Address(RVA = "0xCF71D0", Offset = "0xCF61D0", VA = "0x180CF71D0")]
			set
			{
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06002F00 RID: 12032 RVA: 0x00011118 File Offset: 0x0000F318
		// (set) Token: 0x06002F01 RID: 12033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AE")]
		public bool showActionCategoryLabels
		{
			[Token(Token = "0x6002F00")]
			[Address(RVA = "0xCF7230", Offset = "0xCF6230", VA = "0x180CF7230")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F01")]
			[Address(RVA = "0xCF7240", Offset = "0xCF6240", VA = "0x180CF7240")]
			set
			{
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06002F02 RID: 12034 RVA: 0x00011130 File Offset: 0x0000F330
		// (set) Token: 0x06002F03 RID: 12035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AF")]
		public int keyboardInputFieldCount
		{
			[Token(Token = "0x6002F02")]
			[Address(RVA = "0xCF72A0", Offset = "0xCF62A0", VA = "0x180CF72A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002F03")]
			[Address(RVA = "0xCF72B0", Offset = "0xCF62B0", VA = "0x180CF72B0")]
			set
			{
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06002F04 RID: 12036 RVA: 0x00011148 File Offset: 0x0000F348
		// (set) Token: 0x06002F05 RID: 12037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B0")]
		public int mouseInputFieldCount
		{
			[Token(Token = "0x6002F04")]
			[Address(RVA = "0xCF7310", Offset = "0xCF6310", VA = "0x180CF7310")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002F05")]
			[Address(RVA = "0xCF7320", Offset = "0xCF6320", VA = "0x180CF7320")]
			set
			{
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06002F06 RID: 12038 RVA: 0x00011160 File Offset: 0x0000F360
		// (set) Token: 0x06002F07 RID: 12039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B1")]
		public int controllerInputFieldCount
		{
			[Token(Token = "0x6002F06")]
			[Address(RVA = "0xCF7380", Offset = "0xCF6380", VA = "0x180CF7380")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002F07")]
			[Address(RVA = "0xCF7390", Offset = "0xCF6390", VA = "0x180CF7390")]
			set
			{
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06002F08 RID: 12040 RVA: 0x00011178 File Offset: 0x0000F378
		// (set) Token: 0x06002F09 RID: 12041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B2")]
		public bool showFullAxisInputFields
		{
			[Token(Token = "0x6002F08")]
			[Address(RVA = "0xCE4AE0", Offset = "0xCE3AE0", VA = "0x180CE4AE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F09")]
			[Address(RVA = "0xCF73F0", Offset = "0xCF63F0", VA = "0x180CF73F0")]
			set
			{
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06002F0A RID: 12042 RVA: 0x00011190 File Offset: 0x0000F390
		// (set) Token: 0x06002F0B RID: 12043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B3")]
		public bool showSplitAxisInputFields
		{
			[Token(Token = "0x6002F0A")]
			[Address(RVA = "0xCF7450", Offset = "0xCF6450", VA = "0x180CF7450")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F0B")]
			[Address(RVA = "0xCF7460", Offset = "0xCF6460", VA = "0x180CF7460")]
			set
			{
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06002F0C RID: 12044 RVA: 0x000111A8 File Offset: 0x0000F3A8
		// (set) Token: 0x06002F0D RID: 12045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B4")]
		public bool allowElementAssignmentConflicts
		{
			[Token(Token = "0x6002F0C")]
			[Address(RVA = "0xCF74C0", Offset = "0xCF64C0", VA = "0x180CF74C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F0D")]
			[Address(RVA = "0xCF74D0", Offset = "0xCF64D0", VA = "0x180CF74D0")]
			set
			{
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06002F0E RID: 12046 RVA: 0x000111C0 File Offset: 0x0000F3C0
		// (set) Token: 0x06002F0F RID: 12047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B5")]
		public bool allowElementAssignmentSwap
		{
			[Token(Token = "0x6002F0E")]
			[Address(RVA = "0xCF74E0", Offset = "0xCF64E0", VA = "0x180CF74E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F0F")]
			[Address(RVA = "0xCF74F0", Offset = "0xCF64F0", VA = "0x180CF74F0")]
			set
			{
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06002F10 RID: 12048 RVA: 0x000111D8 File Offset: 0x0000F3D8
		// (set) Token: 0x06002F11 RID: 12049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B6")]
		public int actionLabelWidth
		{
			[Token(Token = "0x6002F10")]
			[Address(RVA = "0xCF7500", Offset = "0xCF6500", VA = "0x180CF7500")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002F11")]
			[Address(RVA = "0xCF7510", Offset = "0xCF6510", VA = "0x180CF7510")]
			set
			{
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06002F12 RID: 12050 RVA: 0x000111F0 File Offset: 0x0000F3F0
		// (set) Token: 0x06002F13 RID: 12051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B7")]
		public int keyboardColMaxWidth
		{
			[Token(Token = "0x6002F12")]
			[Address(RVA = "0xCF7570", Offset = "0xCF6570", VA = "0x180CF7570")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002F13")]
			[Address(RVA = "0xCF7580", Offset = "0xCF6580", VA = "0x180CF7580")]
			set
			{
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06002F14 RID: 12052 RVA: 0x00011208 File Offset: 0x0000F408
		// (set) Token: 0x06002F15 RID: 12053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B8")]
		public int mouseColMaxWidth
		{
			[Token(Token = "0x6002F14")]
			[Address(RVA = "0xCF75E0", Offset = "0xCF65E0", VA = "0x180CF75E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002F15")]
			[Address(RVA = "0xCF75F0", Offset = "0xCF65F0", VA = "0x180CF75F0")]
			set
			{
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06002F16 RID: 12054 RVA: 0x00011220 File Offset: 0x0000F420
		// (set) Token: 0x06002F17 RID: 12055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B9")]
		public int controllerColMaxWidth
		{
			[Token(Token = "0x6002F16")]
			[Address(RVA = "0xCF7650", Offset = "0xCF6650", VA = "0x180CF7650")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002F17")]
			[Address(RVA = "0xCF7660", Offset = "0xCF6660", VA = "0x180CF7660")]
			set
			{
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06002F18 RID: 12056 RVA: 0x00011238 File Offset: 0x0000F438
		// (set) Token: 0x06002F19 RID: 12057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BA")]
		public int inputRowHeight
		{
			[Token(Token = "0x6002F18")]
			[Address(RVA = "0xCF76C0", Offset = "0xCF66C0", VA = "0x180CF76C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002F19")]
			[Address(RVA = "0xCF76D0", Offset = "0xCF66D0", VA = "0x180CF76D0")]
			set
			{
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06002F1A RID: 12058 RVA: 0x00011250 File Offset: 0x0000F450
		// (set) Token: 0x06002F1B RID: 12059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BB")]
		public int inputColumnSpacing
		{
			[Token(Token = "0x6002F1A")]
			[Address(RVA = "0xCF7730", Offset = "0xCF6730", VA = "0x180CF7730")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002F1B")]
			[Address(RVA = "0xCF7740", Offset = "0xCF6740", VA = "0x180CF7740")]
			set
			{
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06002F1C RID: 12060 RVA: 0x00011268 File Offset: 0x0000F468
		// (set) Token: 0x06002F1D RID: 12061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BC")]
		public int inputRowCategorySpacing
		{
			[Token(Token = "0x6002F1C")]
			[Address(RVA = "0xCF77A0", Offset = "0xCF67A0", VA = "0x180CF77A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002F1D")]
			[Address(RVA = "0xCF77B0", Offset = "0xCF67B0", VA = "0x180CF77B0")]
			set
			{
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06002F1E RID: 12062 RVA: 0x00011280 File Offset: 0x0000F480
		// (set) Token: 0x06002F1F RID: 12063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BD")]
		public int invertToggleWidth
		{
			[Token(Token = "0x6002F1E")]
			[Address(RVA = "0xCF7810", Offset = "0xCF6810", VA = "0x180CF7810")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002F1F")]
			[Address(RVA = "0xCF7820", Offset = "0xCF6820", VA = "0x180CF7820")]
			set
			{
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06002F20 RID: 12064 RVA: 0x00011298 File Offset: 0x0000F498
		// (set) Token: 0x06002F21 RID: 12065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BE")]
		public int defaultWindowWidth
		{
			[Token(Token = "0x6002F20")]
			[Address(RVA = "0xCF7880", Offset = "0xCF6880", VA = "0x180CF7880")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002F21")]
			[Address(RVA = "0xCF7890", Offset = "0xCF6890", VA = "0x180CF7890")]
			set
			{
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06002F22 RID: 12066 RVA: 0x000112B0 File Offset: 0x0000F4B0
		// (set) Token: 0x06002F23 RID: 12067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BF")]
		public int defaultWindowHeight
		{
			[Token(Token = "0x6002F22")]
			[Address(RVA = "0xCF78F0", Offset = "0xCF68F0", VA = "0x180CF78F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002F23")]
			[Address(RVA = "0xCF7900", Offset = "0xCF6900", VA = "0x180CF7900")]
			set
			{
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06002F24 RID: 12068 RVA: 0x000112C8 File Offset: 0x0000F4C8
		// (set) Token: 0x06002F25 RID: 12069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C0")]
		public float controllerAssignmentTimeout
		{
			[Token(Token = "0x6002F24")]
			[Address(RVA = "0xCF7960", Offset = "0xCF6960", VA = "0x180CF7960")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002F25")]
			[Address(RVA = "0xCF7970", Offset = "0xCF6970", VA = "0x180CF7970")]
			set
			{
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x000112E0 File Offset: 0x0000F4E0
		// (set) Token: 0x06002F27 RID: 12071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C1")]
		public float preInputAssignmentTimeout
		{
			[Token(Token = "0x6002F26")]
			[Address(RVA = "0xCF7980", Offset = "0xCF6980", VA = "0x180CF7980")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002F27")]
			[Address(RVA = "0xCF7990", Offset = "0xCF6990", VA = "0x180CF7990")]
			set
			{
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x000112F8 File Offset: 0x0000F4F8
		// (set) Token: 0x06002F29 RID: 12073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C2")]
		public float inputAssignmentTimeout
		{
			[Token(Token = "0x6002F28")]
			[Address(RVA = "0xCF79A0", Offset = "0xCF69A0", VA = "0x180CF79A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002F29")]
			[Address(RVA = "0xCF79B0", Offset = "0xCF69B0", VA = "0x180CF79B0")]
			set
			{
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06002F2A RID: 12074 RVA: 0x00011310 File Offset: 0x0000F510
		// (set) Token: 0x06002F2B RID: 12075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C3")]
		public float axisCalibrationTimeout
		{
			[Token(Token = "0x6002F2A")]
			[Address(RVA = "0xCF79C0", Offset = "0xCF69C0", VA = "0x180CF79C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002F2B")]
			[Address(RVA = "0xCF79D0", Offset = "0xCF69D0", VA = "0x180CF79D0")]
			set
			{
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06002F2C RID: 12076 RVA: 0x00011328 File Offset: 0x0000F528
		// (set) Token: 0x06002F2D RID: 12077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C4")]
		public bool ignoreMouseXAxisAssignment
		{
			[Token(Token = "0x6002F2C")]
			[Address(RVA = "0xCF79E0", Offset = "0xCF69E0", VA = "0x180CF79E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F2D")]
			[Address(RVA = "0xCF79F0", Offset = "0xCF69F0", VA = "0x180CF79F0")]
			set
			{
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06002F2E RID: 12078 RVA: 0x00011340 File Offset: 0x0000F540
		// (set) Token: 0x06002F2F RID: 12079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C5")]
		public bool ignoreMouseYAxisAssignment
		{
			[Token(Token = "0x6002F2E")]
			[Address(RVA = "0xCF7A00", Offset = "0xCF6A00", VA = "0x180CF7A00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F2F")]
			[Address(RVA = "0xCF7A10", Offset = "0xCF6A10", VA = "0x180CF7A10")]
			set
			{
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06002F30 RID: 12080 RVA: 0x00011358 File Offset: 0x0000F558
		// (set) Token: 0x06002F31 RID: 12081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C6")]
		public bool universalCancelClosesScreen
		{
			[Token(Token = "0x6002F30")]
			[Address(RVA = "0xCF7A20", Offset = "0xCF6A20", VA = "0x180CF7A20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F31")]
			[Address(RVA = "0xCF7A30", Offset = "0xCF6A30", VA = "0x180CF7A30")]
			set
			{
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06002F32 RID: 12082 RVA: 0x00011370 File Offset: 0x0000F570
		// (set) Token: 0x06002F33 RID: 12083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C7")]
		public bool showInputBehaviorSettings
		{
			[Token(Token = "0x6002F32")]
			[Address(RVA = "0xCF7A40", Offset = "0xCF6A40", VA = "0x180CF7A40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F33")]
			[Address(RVA = "0xCF7A50", Offset = "0xCF6A50", VA = "0x180CF7A50")]
			set
			{
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06002F34 RID: 12084 RVA: 0x00011388 File Offset: 0x0000F588
		// (set) Token: 0x06002F35 RID: 12085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C8")]
		public bool useThemeSettings
		{
			[Token(Token = "0x6002F34")]
			[Address(RVA = "0xCF7AB0", Offset = "0xCF6AB0", VA = "0x180CF7AB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F35")]
			[Address(RVA = "0xCF7AC0", Offset = "0xCF6AC0", VA = "0x180CF7AC0")]
			set
			{
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06002F36 RID: 12086 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002F37 RID: 12087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C9")]
		public LanguageDataBase language
		{
			[Token(Token = "0x6002F36")]
			[Address(RVA = "0xCEAE00", Offset = "0xCE9E00", VA = "0x180CEAE00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F37")]
			[Address(RVA = "0xCF7B20", Offset = "0xCF6B20", VA = "0x180CF7B20")]
			set
			{
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06002F38 RID: 12088 RVA: 0x000113A0 File Offset: 0x0000F5A0
		// (set) Token: 0x06002F39 RID: 12089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CA")]
		public bool showPlayersGroupLabel
		{
			[Token(Token = "0x6002F38")]
			[Address(RVA = "0xCEA2E0", Offset = "0xCE92E0", VA = "0x180CEA2E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F39")]
			[Address(RVA = "0xCF7CF0", Offset = "0xCF6CF0", VA = "0x180CF7CF0")]
			set
			{
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06002F3A RID: 12090 RVA: 0x000113B8 File Offset: 0x0000F5B8
		// (set) Token: 0x06002F3B RID: 12091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CB")]
		public bool showControllerGroupLabel
		{
			[Token(Token = "0x6002F3A")]
			[Address(RVA = "0xCEA300", Offset = "0xCE9300", VA = "0x180CEA300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F3B")]
			[Address(RVA = "0xCF7D50", Offset = "0xCF6D50", VA = "0x180CF7D50")]
			set
			{
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06002F3C RID: 12092 RVA: 0x000113D0 File Offset: 0x0000F5D0
		// (set) Token: 0x06002F3D RID: 12093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CC")]
		public bool showAssignedControllersGroupLabel
		{
			[Token(Token = "0x6002F3C")]
			[Address(RVA = "0xCEA320", Offset = "0xCE9320", VA = "0x180CEA320")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F3D")]
			[Address(RVA = "0xCF7DB0", Offset = "0xCF6DB0", VA = "0x180CF7DB0")]
			set
			{
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06002F3E RID: 12094 RVA: 0x000113E8 File Offset: 0x0000F5E8
		// (set) Token: 0x06002F3F RID: 12095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CD")]
		public bool showSettingsGroupLabel
		{
			[Token(Token = "0x6002F3E")]
			[Address(RVA = "0xCEA340", Offset = "0xCE9340", VA = "0x180CEA340")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F3F")]
			[Address(RVA = "0xCF7E10", Offset = "0xCF6E10", VA = "0x180CF7E10")]
			set
			{
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06002F40 RID: 12096 RVA: 0x00011400 File Offset: 0x0000F600
		// (set) Token: 0x06002F41 RID: 12097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CE")]
		public bool showMapCategoriesGroupLabel
		{
			[Token(Token = "0x6002F40")]
			[Address(RVA = "0xCEA360", Offset = "0xCE9360", VA = "0x180CEA360")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F41")]
			[Address(RVA = "0xCF7E70", Offset = "0xCF6E70", VA = "0x180CF7E70")]
			set
			{
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06002F42 RID: 12098 RVA: 0x00011418 File Offset: 0x0000F618
		// (set) Token: 0x06002F43 RID: 12099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CF")]
		public bool showControllerNameLabel
		{
			[Token(Token = "0x6002F42")]
			[Address(RVA = "0xCEAB20", Offset = "0xCE9B20", VA = "0x180CEAB20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F43")]
			[Address(RVA = "0xCF7ED0", Offset = "0xCF6ED0", VA = "0x180CF7ED0")]
			set
			{
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06002F44 RID: 12100 RVA: 0x00011430 File Offset: 0x0000F630
		// (set) Token: 0x06002F45 RID: 12101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D0")]
		public bool showAssignedControllers
		{
			[Token(Token = "0x6002F44")]
			[Address(RVA = "0xCF7F30", Offset = "0xCF6F30", VA = "0x180CF7F30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F45")]
			[Address(RVA = "0xCF7F40", Offset = "0xCF6F40", VA = "0x180CF7F40")]
			set
			{
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06002F46 RID: 12102 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002F47 RID: 12103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D1")]
		public Action restoreDefaultsDelegate
		{
			[Token(Token = "0x6002F46")]
			[Address(RVA = "0xCF7FA0", Offset = "0xCF6FA0", VA = "0x180CF7FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F47")]
			[Address(RVA = "0xCF7FB0", Offset = "0xCF6FB0", VA = "0x180CF7FB0")]
			set
			{
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06002F48 RID: 12104 RVA: 0x00011448 File Offset: 0x0000F648
		[Token(Token = "0x170003D2")]
		public bool isOpen
		{
			[Token(Token = "0x6002F48")]
			[Address(RVA = "0xCF8010", Offset = "0xCF7010", VA = "0x180CF8010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06002F49 RID: 12105 RVA: 0x00011460 File Offset: 0x0000F660
		[Token(Token = "0x170003D3")]
		private bool isFocused
		{
			[Token(Token = "0x6002F49")]
			[Address(RVA = "0xCF8230", Offset = "0xCF7230", VA = "0x180CF8230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06002F4A RID: 12106 RVA: 0x00011478 File Offset: 0x0000F678
		[Token(Token = "0x170003D4")]
		private bool inputAllowed
		{
			[Token(Token = "0x6002F4A")]
			[Address(RVA = "0xCF8270", Offset = "0xCF7270", VA = "0x180CF8270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06002F4B RID: 12107 RVA: 0x00011490 File Offset: 0x0000F690
		[Token(Token = "0x170003D5")]
		private int inputGridColumnCount
		{
			[Token(Token = "0x6002F4B")]
			[Address(RVA = "0xCF82D0", Offset = "0xCF72D0", VA = "0x180CF82D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06002F4C RID: 12108 RVA: 0x000114A8 File Offset: 0x0000F6A8
		[Token(Token = "0x170003D6")]
		private int inputGridWidth
		{
			[Token(Token = "0x6002F4C")]
			[Address(RVA = "0xCF8300", Offset = "0xCF7300", VA = "0x180CF8300")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06002F4D RID: 12109 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003D7")]
		private Player currentPlayer
		{
			[Token(Token = "0x6002F4D")]
			[Address(RVA = "0xCF8370", Offset = "0xCF7370", VA = "0x180CF8370")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06002F4E RID: 12110 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003D8")]
		private InputCategory currentMapCategory
		{
			[Token(Token = "0x6002F4E")]
			[Address(RVA = "0xCF83E0", Offset = "0xCF73E0", VA = "0x180CF83E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06002F4F RID: 12111 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003D9")]
		private ControlMapper.MappingSet currentMappingSet
		{
			[Token(Token = "0x6002F4F")]
			[Address(RVA = "0xCF8450", Offset = "0xCF7450", VA = "0x180CF8450")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06002F50 RID: 12112 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003DA")]
		private Joystick currentJoystick
		{
			[Token(Token = "0x6002F50")]
			[Address(RVA = "0xCF84C0", Offset = "0xCF74C0", VA = "0x180CF84C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06002F51 RID: 12113 RVA: 0x000114C0 File Offset: 0x0000F6C0
		[Token(Token = "0x170003DB")]
		private bool isJoystickSelected
		{
			[Token(Token = "0x6002F51")]
			[Address(RVA = "0xCF8530", Offset = "0xCF7530", VA = "0x180CF8530")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06002F52 RID: 12114 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003DC")]
		private GameObject currentUISelection
		{
			[Token(Token = "0x6002F52")]
			[Address(RVA = "0xCF8540", Offset = "0xCF7540", VA = "0x180CF8540")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06002F53 RID: 12115 RVA: 0x000114D8 File Offset: 0x0000F6D8
		[Token(Token = "0x170003DD")]
		private bool showSettings
		{
			[Token(Token = "0x6002F53")]
			[Address(RVA = "0xCF8690", Offset = "0xCF7690", VA = "0x180CF8690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06002F54 RID: 12116 RVA: 0x000114F0 File Offset: 0x0000F6F0
		[Token(Token = "0x170003DE")]
		private bool showMapCategories
		{
			[Token(Token = "0x6002F54")]
			[Address(RVA = "0xCF86D0", Offset = "0xCF76D0", VA = "0x180CF86D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F55")]
		[Address(RVA = "0xCF86F0", Offset = "0xCF76F0", VA = "0x180CF86F0")]
		private void Awake()
		{
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F56")]
		[Address(RVA = "0xCF8860", Offset = "0xCF7860", VA = "0x180CF8860")]
		private void Start()
		{
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F57")]
		[Address(RVA = "0xCF8880", Offset = "0xCF7880", VA = "0x180CF8880")]
		private void Update()
		{
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F58")]
		[Address(RVA = "0xCF89E0", Offset = "0xCF79E0", VA = "0x180CF89E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F59")]
		[Address(RVA = "0xCF8C90", Offset = "0xCF7C90", VA = "0x180CF8C90")]
		private void PreInitialize()
		{
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F5A")]
		[Address(RVA = "0xCF8EF0", Offset = "0xCF7EF0", VA = "0x180CF8EF0")]
		private void Initialize()
		{
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F5B")]
		[Address(RVA = "0xCF9E10", Offset = "0xCF8E10", VA = "0x180CF9E10")]
		private void OnJoystickConnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F5C")]
		[Address(RVA = "0xCF9E10", Offset = "0xCF8E10", VA = "0x180CF9E10")]
		private void OnJoystickDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F5D")]
		[Address(RVA = "0xCF9E80", Offset = "0xCF8E80", VA = "0x180CF9E80")]
		private void OnJoystickPreDisconnect(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F5E")]
		[Address(RVA = "0xCF9E90", Offset = "0xCF8E90", VA = "0x180CF9E90")]
		public void OnButtonActivated(ButtonInfo buttonInfo)
		{
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F5F")]
		[Address(RVA = "0xCFA400", Offset = "0xCF9400", VA = "0x180CFA400")]
		public void OnInputFieldActivated(InputFieldInfo fieldInfo)
		{
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F60")]
		[Address(RVA = "0xCFA620", Offset = "0xCF9620", VA = "0x180CFA620")]
		public void OnInputFieldInvertToggleStateChanged(ToggleInfo toggleInfo, bool newState)
		{
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F61")]
		[Address(RVA = "0xCFA760", Offset = "0xCF9760", VA = "0x180CFA760")]
		private void OnPlayerSelected(int playerId, bool redraw)
		{
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F62")]
		[Address(RVA = "0xCFA790", Offset = "0xCF9790", VA = "0x180CFA790")]
		private void OnControllerSelected(int joystickId)
		{
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F63")]
		[Address(RVA = "0xCFA7B0", Offset = "0xCF97B0", VA = "0x180CFA7B0")]
		private void OnRemoveCurrentController()
		{
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F64")]
		[Address(RVA = "0xCFA820", Offset = "0xCF9820", VA = "0x180CFA820")]
		private void OnMapCategorySelected(int id, bool redraw)
		{
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F65")]
		[Address(RVA = "0xCFA850", Offset = "0xCF9850", VA = "0x180CFA850")]
		private void OnRestoreDefaults()
		{
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F66")]
		[Address(RVA = "0xCFAA30", Offset = "0xCF9A30", VA = "0x180CFAA30")]
		private void OnScreenToggleActionPressed(InputActionEventData data)
		{
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F67")]
		[Address(RVA = "0xCFAAA0", Offset = "0xCF9AA0", VA = "0x180CFAAA0")]
		private void OnScreenOpenActionPressed(InputActionEventData data)
		{
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F68")]
		[Address(RVA = "0xCFAAB0", Offset = "0xCF9AB0", VA = "0x180CFAAB0")]
		private void OnScreenCloseActionPressed(InputActionEventData data)
		{
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F69")]
		[Address(RVA = "0xCFAB10", Offset = "0xCF9B10", VA = "0x180CFAB10")]
		private void OnUniversalCancelActionPressed(InputActionEventData data)
		{
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6A")]
		[Address(RVA = "0xCFABA0", Offset = "0xCF9BA0", VA = "0x180CFABA0")]
		private void OnWindowCancel(int windowId)
		{
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6B")]
		[Address(RVA = "0xCFABC0", Offset = "0xCF9BC0", VA = "0x180CFABC0")]
		private void OnRemoveElementAssignment(int windowId, ControllerMap map, ActionElementMap aem)
		{
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6C")]
		[Address(RVA = "0xCFAC10", Offset = "0xCF9C10", VA = "0x180CFAC10")]
		private void OnBeginElementAssignment(InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, string actionName)
		{
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6D")]
		[Address(RVA = "0xCFAF80", Offset = "0xCF9F80", VA = "0x180CFAF80")]
		private void OnControllerAssignmentConfirmed(int windowId, Player player, int controllerId)
		{
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6E")]
		[Address(RVA = "0xCFAFD0", Offset = "0xCF9FD0", VA = "0x180CFAFD0")]
		private void OnMouseAssignmentConfirmed(int windowId, Player player)
		{
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6F")]
		[Address(RVA = "0xCFB250", Offset = "0xCFA250", VA = "0x180CFB250")]
		private void OnElementAssignmentConflictReplaceConfirmed(int windowId, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers, bool allowSwap)
		{
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F70")]
		[Address(RVA = "0xCFBB60", Offset = "0xCFAB60", VA = "0x180CFBB60")]
		private void OnElementAssignmentAddConfirmed(int windowId, ControlMapper.InputMapping mapping, ElementAssignment assignment)
		{
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F71")]
		[Address(RVA = "0xCFBBF0", Offset = "0xCFABF0", VA = "0x180CFBBF0")]
		private void OnRestoreDefaultsConfirmed(int windowId)
		{
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F72")]
		[Address(RVA = "0xCFBF60", Offset = "0xCFAF60", VA = "0x180CFBF60")]
		private void OnAssignControllerWindowUpdate(int windowId)
		{
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F73")]
		[Address(RVA = "0xCFC1F0", Offset = "0xCFB1F0", VA = "0x180CFC1F0")]
		private void OnElementAssignmentPrePollingWindowUpdate(int windowId)
		{
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F74")]
		[Address(RVA = "0xCFC460", Offset = "0xCFB460", VA = "0x180CFC460")]
		private void OnJoystickElementAssignmentPollingWindowUpdate(int windowId)
		{
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F75")]
		[Address(RVA = "0xCFC930", Offset = "0xCFB930", VA = "0x180CFC930")]
		private void OnKeyboardElementAssignmentPollingWindowUpdate(int windowId)
		{
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F76")]
		[Address(RVA = "0xCFCD90", Offset = "0xCFBD90", VA = "0x180CFCD90")]
		private void OnMouseElementAssignmentPollingWindowUpdate(int windowId)
		{
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F77")]
		[Address(RVA = "0xCFD380", Offset = "0xCFC380", VA = "0x180CFD380")]
		private void OnCalibrateAxisStep1WindowUpdate(int windowId)
		{
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F78")]
		[Address(RVA = "0xCFD520", Offset = "0xCFC520", VA = "0x180CFD520")]
		private void OnCalibrateAxisStep2WindowUpdate(int windowId)
		{
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F79")]
		[Address(RVA = "0xCFD800", Offset = "0xCFC800", VA = "0x180CFD800")]
		private void ShowAssignControllerWindow()
		{
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7A")]
		[Address(RVA = "0xCFDBC0", Offset = "0xCFCBC0", VA = "0x180CFDBC0")]
		private void ShowControllerAssignmentConflictWindow(int controllerId)
		{
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7B")]
		[Address(RVA = "0xCFE380", Offset = "0xCFD380", VA = "0x180CFE380")]
		private void ShowBeginElementAssignmentReplacementWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, ActionElementMap aem, string actionName)
		{
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7C")]
		[Address(RVA = "0xCFEB90", Offset = "0xCFDB90", VA = "0x180CFEB90")]
		private void ShowCreateNewElementAssignmentWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, string actionName)
		{
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7D")]
		[Address(RVA = "0xCFEC30", Offset = "0xCFDC30", VA = "0x180CFEC30")]
		private void ShowElementAssignmentPrePollingWindow()
		{
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7E")]
		[Address(RVA = "0xCFF0B0", Offset = "0xCFE0B0", VA = "0x180CFF0B0")]
		private void ShowElementAssignmentPollingWindow()
		{
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7F")]
		[Address(RVA = "0xCFF190", Offset = "0xCFE190", VA = "0x180CFF190")]
		private void ShowJoystickElementAssignmentPollingWindow()
		{
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F80")]
		[Address(RVA = "0xCFF550", Offset = "0xCFE550", VA = "0x180CFF550")]
		private void ShowKeyboardElementAssignmentPollingWindow()
		{
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F81")]
		[Address(RVA = "0xCFF930", Offset = "0xCFE930", VA = "0x180CFF930")]
		private void ShowMouseElementAssignmentPollingWindow()
		{
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F82")]
		[Address(RVA = "0xCFFCF0", Offset = "0xCFECF0", VA = "0x180CFFCF0")]
		private void ShowElementAssignmentConflictWindow(ElementAssignment assignment, bool skipOtherPlayers)
		{
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F83")]
		[Address(RVA = "0xD005C0", Offset = "0xCFF5C0", VA = "0x180D005C0")]
		private void ShowMouseAssignmentConflictWindow()
		{
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F84")]
		[Address(RVA = "0xD00CE0", Offset = "0xCFFCE0", VA = "0x180D00CE0")]
		private void ShowCalibrateControllerWindow()
		{
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F85")]
		[Address(RVA = "0xD01070", Offset = "0xD00070", VA = "0x180D01070")]
		private void ShowCalibrateAxisStep1Window()
		{
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F86")]
		[Address(RVA = "0xD01620", Offset = "0xD00620", VA = "0x180D01620")]
		private void ShowCalibrateAxisStep2Window()
		{
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F87")]
		[Address(RVA = "0xD01BD0", Offset = "0xD00BD0", VA = "0x180D01BD0")]
		private void ShowEditInputBehaviorsWindow()
		{
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F88")]
		[Address(RVA = "0xD01EE0", Offset = "0xD00EE0", VA = "0x180D01EE0")]
		private void ShowRestoreDefaultsWindow()
		{
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F89")]
		[Address(RVA = "0xD020B0", Offset = "0xD010B0", VA = "0x180D020B0")]
		private void CreateInputGrid()
		{
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8A")]
		[Address(RVA = "0xD023C0", Offset = "0xD013C0", VA = "0x180D023C0")]
		private void InitializeInputGrid()
		{
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8B")]
		[Address(RVA = "0xD02B30", Offset = "0xD01B30", VA = "0x180D02B30")]
		private void RefreshInputGridStructure()
		{
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8C")]
		[Address(RVA = "0xD02D10", Offset = "0xD01D10", VA = "0x180D02D10")]
		private void CreateHeaderLabels()
		{
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8D")]
		[Address(RVA = "0xD03420", Offset = "0xD02420", VA = "0x180D03420")]
		private void CreateActionLabelColumn()
		{
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8E")]
		[Address(RVA = "0xD03540", Offset = "0xD02540", VA = "0x180D03540")]
		private void CreateKeyboardInputFieldColumn()
		{
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8F")]
		[Address(RVA = "0xD035B0", Offset = "0xD025B0", VA = "0x180D035B0")]
		private void CreateMouseInputFieldColumn()
		{
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F90")]
		[Address(RVA = "0xD03620", Offset = "0xD02620", VA = "0x180D03620")]
		private void CreateControllerInputFieldColumn()
		{
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F91")]
		[Address(RVA = "0xD03690", Offset = "0xD02690", VA = "0x180D03690")]
		private void CreateInputFieldColumn(string name, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis)
		{
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F92")]
		[Address(RVA = "0xD03900", Offset = "0xD02900", VA = "0x180D03900")]
		private void CreateInputActionLabels()
		{
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F93")]
		[Address(RVA = "0xD045B0", Offset = "0xD035B0", VA = "0x180D045B0")]
		private void CreateInputFields()
		{
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F94")]
		[Address(RVA = "0xD04690", Offset = "0xD03690", VA = "0x180D04690")]
		private void CreateInputFields(Transform columnXform, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis)
		{
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F95")]
		[Address(RVA = "0xD04E00", Offset = "0xD03E00", VA = "0x180D04E00")]
		private void CreateInputFieldSet(Transform parent, int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int cols, int fieldWidth, ref int yPos, bool disableFullAxis)
		{
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F96")]
		[Address(RVA = "0xD053E0", Offset = "0xD043E0", VA = "0x180D053E0")]
		private void PopulateInputFields()
		{
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F97")]
		[Address(RVA = "0xD05A40", Offset = "0xD04A40", VA = "0x180D05A40")]
		private void PopulateInputFieldGroup(ControlMapper.InputActionSet actionSet, ControllerMap controllerMap, ControllerType controllerType, int controllerId, int maxFields)
		{
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F98")]
		[Address(RVA = "0xD06010", Offset = "0xD05010", VA = "0x180D06010")]
		private void DisableInputFieldGroup(ControlMapper.InputActionSet actionSet, ControllerType controllerType, int fieldCount)
		{
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F99")]
		[Address(RVA = "0xD060D0", Offset = "0xD050D0", VA = "0x180D060D0")]
		private void ResetInputGridScrollBar()
		{
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F9A")]
		[Address(RVA = "0xD06220", Offset = "0xD05220", VA = "0x180D06220")]
		private void CreateLayout()
		{
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F9B")]
		[Address(RVA = "0xD06730", Offset = "0xD05730", VA = "0x180D06730")]
		private void Draw()
		{
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F9C")]
		[Address(RVA = "0xD06880", Offset = "0xD05880", VA = "0x180D06880")]
		private void DrawPlayersGroup()
		{
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F9D")]
		[Address(RVA = "0xD06C40", Offset = "0xD05C40", VA = "0x180D06C40")]
		private void DrawControllersGroup()
		{
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F9E")]
		[Address(RVA = "0xD071C0", Offset = "0xD061C0", VA = "0x180D071C0")]
		private void DrawSettingsGroup()
		{
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F9F")]
		[Address(RVA = "0xD07470", Offset = "0xD06470", VA = "0x180D07470")]
		private void DrawMapCategoriesGroup()
		{
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA0")]
		[Address(RVA = "0xD07840", Offset = "0xD06840", VA = "0x180D07840")]
		private void DrawWindowButtonsGroup()
		{
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA1")]
		[Address(RVA = "0xD07970", Offset = "0xD06970", VA = "0x180D07970")]
		private void Redraw(bool listsChanged, bool playTransitions)
		{
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA2")]
		[Address(RVA = "0xD07B50", Offset = "0xD06B50", VA = "0x180D07B50")]
		private void RedrawPlayerGroup(bool playTransitions)
		{
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA3")]
		[Address(RVA = "0xD07D10", Offset = "0xD06D10", VA = "0x180D07D10")]
		private void RedrawControllerGroup()
		{
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA4")]
		[Address(RVA = "0xD08C20", Offset = "0xD07C20", VA = "0x180D08C20")]
		private void RedrawMapCategoriesGroup(bool playTransitions)
		{
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA5")]
		[Address(RVA = "0xD08DF0", Offset = "0xD07DF0", VA = "0x180D08DF0")]
		private void RedrawInputGrid(bool listsChanged)
		{
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA6")]
		[Address(RVA = "0xD08E30", Offset = "0xD07E30", VA = "0x180D08E30")]
		private void ForceRefresh()
		{
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA7")]
		[Address(RVA = "0xD08E80", Offset = "0xD07E80", VA = "0x180D08E80")]
		private void CreateInputCategoryRow(ref int rowCount, InputCategory category)
		{
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FA8")]
		[Address(RVA = "0xD08F30", Offset = "0xD07F30", VA = "0x180D08F30")]
		private ControlMapper.GUILabel CreateLabel(string labelText, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FA9")]
		[Address(RVA = "0xD08F70", Offset = "0xD07F70", VA = "0x180D08F70")]
		private ControlMapper.GUILabel CreateLabel(GameObject prefab, string labelText, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FAA")]
		[Address(RVA = "0xD09190", Offset = "0xD08190", VA = "0x180D09190")]
		private ControlMapper.GUIButton CreateButton(string labelText, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FAB")]
		[Address(RVA = "0xD09280", Offset = "0xD08280", VA = "0x180D09280")]
		private ControlMapper.GUIButton CreateFitButton(string labelText, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FAC")]
		[Address(RVA = "0xD09370", Offset = "0xD08370", VA = "0x180D09370")]
		private ControlMapper.GUIInputField CreateInputField(Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			return null;
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FAD")]
		[Address(RVA = "0xD09680", Offset = "0xD08680", VA = "0x180D09680")]
		private ControlMapper.GUIInputField CreateInputField(Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FAE")]
		[Address(RVA = "0xD09740", Offset = "0xD08740", VA = "0x180D09740")]
		private ControlMapper.GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			return null;
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FAF")]
		[Address(RVA = "0xD09A10", Offset = "0xD08A10", VA = "0x180D09A10")]
		private ControlMapper.GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FB0")]
		[Address(RVA = "0xD09AD0", Offset = "0xD08AD0", VA = "0x180D09AD0")]
		private GameObject InstantiateGUIObject(GameObject prefab, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FB1")]
		[Address(RVA = "0xD09C90", Offset = "0xD08C90", VA = "0x180D09C90")]
		private GameObject CreateNewGUIObject(string name, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FB2")]
		[Address(RVA = "0xD09D60", Offset = "0xD08D60", VA = "0x180D09D60")]
		private GameObject InitializeNewGUIGameObject(GameObject gameObject, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FB3")]
		[Address(RVA = "0xD0A0E0", Offset = "0xD090E0", VA = "0x180D0A0E0")]
		private GameObject CreateNewColumnGroup(string name, Transform parent, int maxWidth)
		{
			return null;
		}

		// Token: 0x06002FB4 RID: 12212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FB4")]
		[Address(RVA = "0xD0A300", Offset = "0xD09300", VA = "0x180D0A300")]
		private Window OpenWindow(bool closeOthers)
		{
			return null;
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FB5")]
		[Address(RVA = "0xD0A4C0", Offset = "0xD094C0", VA = "0x180D0A4C0")]
		private Window OpenWindow(string name, bool closeOthers)
		{
			return null;
		}

		// Token: 0x06002FB6 RID: 12214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FB6")]
		[Address(RVA = "0xD0A650", Offset = "0xD09650", VA = "0x180D0A650")]
		private Window OpenWindow(GameObject windowPrefab, bool closeOthers)
		{
			return null;
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FB7")]
		[Address(RVA = "0xD0A6D0", Offset = "0xD096D0", VA = "0x180D0A6D0")]
		private Window OpenWindow(GameObject windowPrefab, string name, bool closeOthers)
		{
			return null;
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB8")]
		[Address(RVA = "0xD0A980", Offset = "0xD09980", VA = "0x180D0A980")]
		private void OpenModal(string title, string message, string confirmText, Action<int> confirmAction, string cancelText, Action<int> cancelAction, bool closeOthers)
		{
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB9")]
		[Address(RVA = "0xD0AF50", Offset = "0xD09F50", VA = "0x180D0AF50")]
		private void CloseWindow(int windowId)
		{
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBA")]
		[Address(RVA = "0xD0AFD0", Offset = "0xD09FD0", VA = "0x180D0AFD0")]
		private void CloseTopWindow()
		{
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBB")]
		[Address(RVA = "0xD0B020", Offset = "0xD0A020", VA = "0x180D0B020")]
		private void CloseAllWindows()
		{
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBC")]
		[Address(RVA = "0xD0B0C0", Offset = "0xD0A0C0", VA = "0x180D0B0C0")]
		private void ChildWindowOpened()
		{
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBD")]
		[Address(RVA = "0xD0B190", Offset = "0xD0A190", VA = "0x180D0B190")]
		private void ChildWindowClosed()
		{
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x00011508 File Offset: 0x0000F708
		[Token(Token = "0x6002FBE")]
		[Address(RVA = "0xD0B210", Offset = "0xD0A210", VA = "0x180D0B210")]
		private bool HasElementAssignmentConflicts(Player player, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			return default(bool);
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x00011520 File Offset: 0x0000F720
		[Token(Token = "0x6002FBF")]
		[Address(RVA = "0xD0B430", Offset = "0xD0A430", VA = "0x180D0B430")]
		private bool IsBlockingAssignmentConflict(ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			return default(bool);
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FC0")]
		[Address(RVA = "0xD0B9E0", Offset = "0xD0A9E0", VA = "0x180D0B9E0")]
		private IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(Player player, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			return null;
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x00011538 File Offset: 0x0000F738
		[Token(Token = "0x6002FC1")]
		[Address(RVA = "0xD0BBA0", Offset = "0xD0ABA0", VA = "0x180D0BBA0")]
		private bool CreateConflictCheck(ControlMapper.InputMapping mapping, ElementAssignment assignment, out ElementAssignmentConflictCheck conflictCheck)
		{
			return default(bool);
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC2")]
		[Address(RVA = "0xD0BD00", Offset = "0xD0AD00", VA = "0x180D0BD00")]
		private void PollKeyboardForAssignment(out ControllerPollingInfo pollingInfo, out bool modifierKeyPressed, out ModifierKeyFlags modifierFlags, out string label)
		{
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x00011550 File Offset: 0x0000F750
		[Token(Token = "0x6002FC3")]
		[Address(RVA = "0xD0C520", Offset = "0xD0B520", VA = "0x180D0C520")]
		private bool GetFirstElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict, bool skipOtherPlayers)
		{
			return default(bool);
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x00011568 File Offset: 0x0000F768
		[Token(Token = "0x6002FC4")]
		[Address(RVA = "0xD0C750", Offset = "0xD0B750", VA = "0x180D0C750")]
		private bool GetFirstElementAssignmentConflict(Player player, ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict)
		{
			return default(bool);
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC5")]
		[Address(RVA = "0xD0C970", Offset = "0xD0B970", VA = "0x180D0C970")]
		private void StartAxisCalibration(int axisIndex)
		{
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC6")]
		[Address(RVA = "0xD0CB90", Offset = "0xD0BB90", VA = "0x180D0CB90")]
		private void EndAxisCalibration()
		{
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC7")]
		[Address(RVA = "0xD0CCB0", Offset = "0xD0BCB0", VA = "0x180D0CCB0")]
		private void SetUISelection(GameObject selection)
		{
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC8")]
		[Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
		private void RestoreLastUISelection()
		{
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC9")]
		[Address(RVA = "0xD0CF90", Offset = "0xD0BF90", VA = "0x180D0CF90")]
		private void SetDefaultUISelection()
		{
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FCA")]
		[Address(RVA = "0xD0D140", Offset = "0xD0C140", VA = "0x180D0D140")]
		private void SelectDefaultMapCategory(bool redraw)
		{
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FCB")]
		[Address(RVA = "0xD0D430", Offset = "0xD0C430", VA = "0x180D0D430")]
		private void CheckUISelection()
		{
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FCC")]
		[Address(RVA = "0xD0D580", Offset = "0xD0C580", VA = "0x180D0D580")]
		private void OnUIElementSelected(GameObject selectedObject)
		{
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FCD")]
		[Address(RVA = "0xD0D5E0", Offset = "0xD0C5E0", VA = "0x180D0D5E0")]
		private void SetIsFocused(bool state)
		{
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FCE")]
		[Address(RVA = "0xD0D6E0", Offset = "0xD0C6E0", VA = "0x180D0D6E0")]
		public void Toggle()
		{
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FCF")]
		[Address(RVA = "0xCFAAA0", Offset = "0xCF9AA0", VA = "0x180CFAAA0")]
		public void Open()
		{
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD0")]
		[Address(RVA = "0xD0D720", Offset = "0xD0C720", VA = "0x180D0D720")]
		private void Open(bool force)
		{
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD1")]
		[Address(RVA = "0xD0D850", Offset = "0xD0C850", VA = "0x180D0D850")]
		public void Close(bool save)
		{
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD2")]
		[Address(RVA = "0xD0D990", Offset = "0xD0C990", VA = "0x180D0D990")]
		private void Clear()
		{
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD3")]
		[Address(RVA = "0xD0DB30", Offset = "0xD0CB30", VA = "0x180D0DB30")]
		private void ClearCompletely()
		{
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD4")]
		[Address(RVA = "0xD0DB60", Offset = "0xD0CB60", VA = "0x180D0DB60")]
		private void ClearSpawnedObjects()
		{
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD5")]
		[Address(RVA = "0xD0E560", Offset = "0xD0D560", VA = "0x180D0E560")]
		private void ClearVarsOnPlayerChange()
		{
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD6")]
		[Address(RVA = "0xD0E560", Offset = "0xD0D560", VA = "0x180D0E560")]
		private void ClearVarsOnJoystickChange()
		{
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD7")]
		[Address(RVA = "0xD0E570", Offset = "0xD0D570", VA = "0x180D0E570")]
		private void ClearAllVars()
		{
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD8")]
		[Address(RVA = "0xD0EA00", Offset = "0xD0DA00", VA = "0x180D0EA00")]
		public void Reset()
		{
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD9")]
		[Address(RVA = "0xD0EA60", Offset = "0xD0DA60", VA = "0x180D0EA60")]
		private void SetActionAxisInverted(bool state, ControllerType controllerType, int actionElementMapId)
		{
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FDA")]
		[Address(RVA = "0xD0EB30", Offset = "0xD0DB30", VA = "0x180D0EB30")]
		private ControllerMap GetControllerMap(ControllerType type)
		{
			return null;
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FDB")]
		[Address(RVA = "0xD0EC70", Offset = "0xD0DC70", VA = "0x180D0EC70")]
		private ControllerMap GetControllerMapOrCreateNew(ControllerType controllerType, int controllerId, int layoutId)
		{
			return null;
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x00011580 File Offset: 0x0000F780
		[Token(Token = "0x6002FDC")]
		private int CountIEnumerable<T>(IEnumerable<T> enumerable)
		{
			return 0;
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x00011598 File Offset: 0x0000F798
		[Token(Token = "0x6002FDD")]
		[Address(RVA = "0xD0ED40", Offset = "0xD0DD40", VA = "0x180D0ED40")]
		private int GetDefaultMapCategoryId()
		{
			return 0;
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FDE")]
		[Address(RVA = "0xD0EE50", Offset = "0xD0DE50", VA = "0x180D0EE50")]
		private void SubscribeFixedUISelectionEvents()
		{
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FDF")]
		[Address(RVA = "0xD0F070", Offset = "0xD0E070", VA = "0x180D0F070")]
		private void SubscribeMenuControlInputEvents()
		{
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE0")]
		[Address(RVA = "0xD0F200", Offset = "0xD0E200", VA = "0x180D0F200")]
		private void UnsubscribeMenuControlInputEvents()
		{
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE1")]
		[Address(RVA = "0xD0F390", Offset = "0xD0E390", VA = "0x180D0F390")]
		private void SubscribeRewiredInputEventAllPlayers(int actionId, Action<InputActionEventData> callback)
		{
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE2")]
		[Address(RVA = "0xD0F620", Offset = "0xD0E620", VA = "0x180D0F620")]
		private void UnsubscribeRewiredInputEventAllPlayers(int actionId, Action<InputActionEventData> callback)
		{
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x000115B0 File Offset: 0x0000F7B0
		[Token(Token = "0x6002FE3")]
		[Address(RVA = "0xD0F8D0", Offset = "0xD0E8D0", VA = "0x180D0F8D0")]
		private int GetMaxControllersPerPlayer()
		{
			return 0;
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x000115C8 File Offset: 0x0000F7C8
		[Token(Token = "0x6002FE4")]
		[Address(RVA = "0xD0F920", Offset = "0xD0E920", VA = "0x180D0F920")]
		private bool ShowAssignedControllers()
		{
			return default(bool);
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE5")]
		[Address(RVA = "0xD0F990", Offset = "0xD0E990", VA = "0x180D0F990")]
		private void InspectorPropertyChanged(bool reset = false)
		{
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE6")]
		[Address(RVA = "0xD0F9F0", Offset = "0xD0E9F0", VA = "0x180D0F9F0")]
		private void AssignController(Player player, int controllerId)
		{
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE7")]
		[Address(RVA = "0xD0FE70", Offset = "0xD0EE70", VA = "0x180D0FE70")]
		private void RemoveAllControllers(Player player)
		{
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE8")]
		[Address(RVA = "0xD0FFC0", Offset = "0xD0EFC0", VA = "0x180D0FFC0")]
		private void RemoveController(Player player, int controllerId)
		{
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x000115E0 File Offset: 0x0000F7E0
		[Token(Token = "0x6002FE9")]
		[Address(RVA = "0xD10160", Offset = "0xD0F160", VA = "0x180D10160")]
		private bool IsAllowedAssignment(ControlMapper.InputMapping pendingInputMapping, ControllerPollingInfo pollingInfo)
		{
			return default(bool);
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FEA")]
		[Address(RVA = "0xD101B0", Offset = "0xD0F1B0", VA = "0x180D101B0")]
		private void InputPollingStarted()
		{
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FEB")]
		[Address(RVA = "0xD10210", Offset = "0xD0F210", VA = "0x180D10210")]
		private void InputPollingStopped()
		{
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x000115F8 File Offset: 0x0000F7F8
		[Token(Token = "0x6002FEC")]
		[Address(RVA = "0xD10270", Offset = "0xD0F270", VA = "0x180D10270")]
		private int GetControllerInputFieldCount(ControllerType controllerType)
		{
			return 0;
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x00011610 File Offset: 0x0000F810
		[Token(Token = "0x6002FED")]
		[Address(RVA = "0xD102F0", Offset = "0xD0F2F0", VA = "0x180D102F0")]
		private bool ShowSwapButton(int windowId, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			return default(bool);
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x00011628 File Offset: 0x0000F828
		[Token(Token = "0x6002FEE")]
		[Address(RVA = "0xD10CD0", Offset = "0xD0FCD0", VA = "0x180D10CD0")]
		private bool SwapIsSameInputRange(ControllerElementType origElementType, AxisRange origAxisRange, Pole origAxisContribution, ControllerElementType conflictElementType, AxisRange conflictAxisRange, Pole conflictAxisContribution)
		{
			return default(bool);
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FEF")]
		[Address(RVA = "0xD10D20", Offset = "0xD0FD20", VA = "0x180D10D20")]
		public static void ApplyTheme(ThemedElement.ElementInfo[] elementInfo)
		{
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FF0")]
		[Address(RVA = "0xD10FB0", Offset = "0xD0FFB0", VA = "0x180D10FB0")]
		public static LanguageDataBase GetLanguage()
		{
			return null;
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FF1")]
		[Address(RVA = "0xD110F0", Offset = "0xD100F0", VA = "0x180D110F0")]
		public ControlMapper()
		{
		}

		// Token: 0x04004DE9 RID: 19945
		[Token(Token = "0x4004DE9")]
		public const int versionMajor = 1;

		// Token: 0x04004DEA RID: 19946
		[Token(Token = "0x4004DEA")]
		public const int versionMinor = 1;

		// Token: 0x04004DEB RID: 19947
		[Token(Token = "0x4004DEB")]
		public const bool usesTMPro = true;

		// Token: 0x04004DEC RID: 19948
		[Token(Token = "0x4004DEC")]
		private const float blockInputOnFocusTimeout = 0.1f;

		// Token: 0x04004DED RID: 19949
		[Token(Token = "0x4004DED")]
		private const string buttonIdentifier_playerSelection = "PlayerSelection";

		// Token: 0x04004DEE RID: 19950
		[Token(Token = "0x4004DEE")]
		private const string buttonIdentifier_removeController = "RemoveController";

		// Token: 0x04004DEF RID: 19951
		[Token(Token = "0x4004DEF")]
		private const string buttonIdentifier_assignController = "AssignController";

		// Token: 0x04004DF0 RID: 19952
		[Token(Token = "0x4004DF0")]
		private const string buttonIdentifier_calibrateController = "CalibrateController";

		// Token: 0x04004DF1 RID: 19953
		[Token(Token = "0x4004DF1")]
		private const string buttonIdentifier_editInputBehaviors = "EditInputBehaviors";

		// Token: 0x04004DF2 RID: 19954
		[Token(Token = "0x4004DF2")]
		private const string buttonIdentifier_mapCategorySelection = "MapCategorySelection";

		// Token: 0x04004DF3 RID: 19955
		[Token(Token = "0x4004DF3")]
		private const string buttonIdentifier_assignedControllerSelection = "AssignedControllerSelection";

		// Token: 0x04004DF4 RID: 19956
		[Token(Token = "0x4004DF4")]
		private const string buttonIdentifier_done = "Done";

		// Token: 0x04004DF5 RID: 19957
		[Token(Token = "0x4004DF5")]
		private const string buttonIdentifier_restoreDefaults = "RestoreDefaults";

		// Token: 0x04004DF6 RID: 19958
		[Token(Token = "0x4004DF6")]
		[FieldOffset(Offset = "0x18")]
		private InputManager _rewiredInputManager;

		// Token: 0x04004DF7 RID: 19959
		[Token(Token = "0x4004DF7")]
		[FieldOffset(Offset = "0x20")]
		private bool _dontDestroyOnLoad;

		// Token: 0x04004DF8 RID: 19960
		[Token(Token = "0x4004DF8")]
		[FieldOffset(Offset = "0x21")]
		private bool _openOnStart;

		// Token: 0x04004DF9 RID: 19961
		[Token(Token = "0x4004DF9")]
		[FieldOffset(Offset = "0x24")]
		private int _keyboardMapDefaultLayout;

		// Token: 0x04004DFA RID: 19962
		[Token(Token = "0x4004DFA")]
		[FieldOffset(Offset = "0x28")]
		private int _mouseMapDefaultLayout;

		// Token: 0x04004DFB RID: 19963
		[Token(Token = "0x4004DFB")]
		[FieldOffset(Offset = "0x2C")]
		private int _joystickMapDefaultLayout;

		// Token: 0x04004DFC RID: 19964
		[Token(Token = "0x4004DFC")]
		[FieldOffset(Offset = "0x30")]
		private ControlMapper.MappingSet[] _mappingSets;

		// Token: 0x04004DFD RID: 19965
		[Token(Token = "0x4004DFD")]
		[FieldOffset(Offset = "0x38")]
		private bool _showPlayers;

		// Token: 0x04004DFE RID: 19966
		[Token(Token = "0x4004DFE")]
		[FieldOffset(Offset = "0x39")]
		private bool _showControllers;

		// Token: 0x04004DFF RID: 19967
		[Token(Token = "0x4004DFF")]
		[FieldOffset(Offset = "0x3A")]
		private bool _showKeyboard;

		// Token: 0x04004E00 RID: 19968
		[Token(Token = "0x4004E00")]
		[FieldOffset(Offset = "0x3B")]
		private bool _showMouse;

		// Token: 0x04004E01 RID: 19969
		[Token(Token = "0x4004E01")]
		[FieldOffset(Offset = "0x3C")]
		private int _maxControllersPerPlayer;

		// Token: 0x04004E02 RID: 19970
		[Token(Token = "0x4004E02")]
		[FieldOffset(Offset = "0x40")]
		private bool _showActionCategoryLabels;

		// Token: 0x04004E03 RID: 19971
		[Token(Token = "0x4004E03")]
		[FieldOffset(Offset = "0x44")]
		private int _keyboardInputFieldCount;

		// Token: 0x04004E04 RID: 19972
		[Token(Token = "0x4004E04")]
		[FieldOffset(Offset = "0x48")]
		private int _mouseInputFieldCount;

		// Token: 0x04004E05 RID: 19973
		[Token(Token = "0x4004E05")]
		[FieldOffset(Offset = "0x4C")]
		private int _controllerInputFieldCount;

		// Token: 0x04004E06 RID: 19974
		[Token(Token = "0x4004E06")]
		[FieldOffset(Offset = "0x50")]
		private bool _showFullAxisInputFields;

		// Token: 0x04004E07 RID: 19975
		[Token(Token = "0x4004E07")]
		[FieldOffset(Offset = "0x51")]
		private bool _showSplitAxisInputFields;

		// Token: 0x04004E08 RID: 19976
		[Token(Token = "0x4004E08")]
		[FieldOffset(Offset = "0x52")]
		private bool _allowElementAssignmentConflicts;

		// Token: 0x04004E09 RID: 19977
		[Token(Token = "0x4004E09")]
		[FieldOffset(Offset = "0x53")]
		private bool _allowElementAssignmentSwap;

		// Token: 0x04004E0A RID: 19978
		[Token(Token = "0x4004E0A")]
		[FieldOffset(Offset = "0x54")]
		private int _actionLabelWidth;

		// Token: 0x04004E0B RID: 19979
		[Token(Token = "0x4004E0B")]
		[FieldOffset(Offset = "0x58")]
		private int _keyboardColMaxWidth;

		// Token: 0x04004E0C RID: 19980
		[Token(Token = "0x4004E0C")]
		[FieldOffset(Offset = "0x5C")]
		private int _mouseColMaxWidth;

		// Token: 0x04004E0D RID: 19981
		[Token(Token = "0x4004E0D")]
		[FieldOffset(Offset = "0x60")]
		private int _controllerColMaxWidth;

		// Token: 0x04004E0E RID: 19982
		[Token(Token = "0x4004E0E")]
		[FieldOffset(Offset = "0x64")]
		private int _inputRowHeight;

		// Token: 0x04004E0F RID: 19983
		[Token(Token = "0x4004E0F")]
		[FieldOffset(Offset = "0x68")]
		private RectOffset _inputRowPadding;

		// Token: 0x04004E10 RID: 19984
		[Token(Token = "0x4004E10")]
		[FieldOffset(Offset = "0x70")]
		private int _inputRowFieldSpacing;

		// Token: 0x04004E11 RID: 19985
		[Token(Token = "0x4004E11")]
		[FieldOffset(Offset = "0x74")]
		private int _inputColumnSpacing;

		// Token: 0x04004E12 RID: 19986
		[Token(Token = "0x4004E12")]
		[FieldOffset(Offset = "0x78")]
		private int _inputRowCategorySpacing;

		// Token: 0x04004E13 RID: 19987
		[Token(Token = "0x4004E13")]
		[FieldOffset(Offset = "0x7C")]
		private int _invertToggleWidth;

		// Token: 0x04004E14 RID: 19988
		[Token(Token = "0x4004E14")]
		[FieldOffset(Offset = "0x80")]
		private int _defaultWindowWidth;

		// Token: 0x04004E15 RID: 19989
		[Token(Token = "0x4004E15")]
		[FieldOffset(Offset = "0x84")]
		private int _defaultWindowHeight;

		// Token: 0x04004E16 RID: 19990
		[Token(Token = "0x4004E16")]
		[FieldOffset(Offset = "0x88")]
		private float _controllerAssignmentTimeout;

		// Token: 0x04004E17 RID: 19991
		[Token(Token = "0x4004E17")]
		[FieldOffset(Offset = "0x8C")]
		private float _preInputAssignmentTimeout;

		// Token: 0x04004E18 RID: 19992
		[Token(Token = "0x4004E18")]
		[FieldOffset(Offset = "0x90")]
		private float _inputAssignmentTimeout;

		// Token: 0x04004E19 RID: 19993
		[Token(Token = "0x4004E19")]
		[FieldOffset(Offset = "0x94")]
		private float _axisCalibrationTimeout;

		// Token: 0x04004E1A RID: 19994
		[Token(Token = "0x4004E1A")]
		[FieldOffset(Offset = "0x98")]
		private bool _ignoreMouseXAxisAssignment;

		// Token: 0x04004E1B RID: 19995
		[Token(Token = "0x4004E1B")]
		[FieldOffset(Offset = "0x99")]
		private bool _ignoreMouseYAxisAssignment;

		// Token: 0x04004E1C RID: 19996
		[Token(Token = "0x4004E1C")]
		[FieldOffset(Offset = "0x9C")]
		private int _screenToggleAction;

		// Token: 0x04004E1D RID: 19997
		[Token(Token = "0x4004E1D")]
		[FieldOffset(Offset = "0xA0")]
		private int _screenOpenAction;

		// Token: 0x04004E1E RID: 19998
		[Token(Token = "0x4004E1E")]
		[FieldOffset(Offset = "0xA4")]
		private int _screenCloseAction;

		// Token: 0x04004E1F RID: 19999
		[Token(Token = "0x4004E1F")]
		[FieldOffset(Offset = "0xA8")]
		private int _universalCancelAction;

		// Token: 0x04004E20 RID: 20000
		[Token(Token = "0x4004E20")]
		[FieldOffset(Offset = "0xAC")]
		private bool _universalCancelClosesScreen;

		// Token: 0x04004E21 RID: 20001
		[Token(Token = "0x4004E21")]
		[FieldOffset(Offset = "0xAD")]
		private bool _showInputBehaviorSettings;

		// Token: 0x04004E22 RID: 20002
		[Token(Token = "0x4004E22")]
		[FieldOffset(Offset = "0xB0")]
		private ControlMapper.InputBehaviorSettings[] _inputBehaviorSettings;

		// Token: 0x04004E23 RID: 20003
		[Token(Token = "0x4004E23")]
		[FieldOffset(Offset = "0xB8")]
		private bool _useThemeSettings;

		// Token: 0x04004E24 RID: 20004
		[Token(Token = "0x4004E24")]
		[FieldOffset(Offset = "0xC0")]
		private ThemeSettings _themeSettings;

		// Token: 0x04004E25 RID: 20005
		[Token(Token = "0x4004E25")]
		[FieldOffset(Offset = "0xC8")]
		private LanguageDataBase _language;

		// Token: 0x04004E26 RID: 20006
		[Token(Token = "0x4004E26")]
		[FieldOffset(Offset = "0xD0")]
		private ControlMapper.Prefabs prefabs;

		// Token: 0x04004E27 RID: 20007
		[Token(Token = "0x4004E27")]
		[FieldOffset(Offset = "0xD8")]
		private ControlMapper.References references;

		// Token: 0x04004E28 RID: 20008
		[Token(Token = "0x4004E28")]
		[FieldOffset(Offset = "0xE0")]
		private bool _showPlayersGroupLabel;

		// Token: 0x04004E29 RID: 20009
		[Token(Token = "0x4004E29")]
		[FieldOffset(Offset = "0xE1")]
		private bool _showControllerGroupLabel;

		// Token: 0x04004E2A RID: 20010
		[Token(Token = "0x4004E2A")]
		[FieldOffset(Offset = "0xE2")]
		private bool _showAssignedControllersGroupLabel;

		// Token: 0x04004E2B RID: 20011
		[Token(Token = "0x4004E2B")]
		[FieldOffset(Offset = "0xE3")]
		private bool _showSettingsGroupLabel;

		// Token: 0x04004E2C RID: 20012
		[Token(Token = "0x4004E2C")]
		[FieldOffset(Offset = "0xE4")]
		private bool _showMapCategoriesGroupLabel;

		// Token: 0x04004E2D RID: 20013
		[Token(Token = "0x4004E2D")]
		[FieldOffset(Offset = "0xE5")]
		private bool _showControllerNameLabel;

		// Token: 0x04004E2E RID: 20014
		[Token(Token = "0x4004E2E")]
		[FieldOffset(Offset = "0xE6")]
		private bool _showAssignedControllers;

		// Token: 0x04004E2F RID: 20015
		[Token(Token = "0x4004E2F")]
		[FieldOffset(Offset = "0xE8")]
		private Action _ScreenClosedEvent;

		// Token: 0x04004E30 RID: 20016
		[Token(Token = "0x4004E30")]
		[FieldOffset(Offset = "0xF0")]
		private Action _ScreenOpenedEvent;

		// Token: 0x04004E31 RID: 20017
		[Token(Token = "0x4004E31")]
		[FieldOffset(Offset = "0xF8")]
		private Action _PopupWindowOpenedEvent;

		// Token: 0x04004E32 RID: 20018
		[Token(Token = "0x4004E32")]
		[FieldOffset(Offset = "0x100")]
		private Action _PopupWindowClosedEvent;

		// Token: 0x04004E33 RID: 20019
		[Token(Token = "0x4004E33")]
		[FieldOffset(Offset = "0x108")]
		private Action _InputPollingStartedEvent;

		// Token: 0x04004E34 RID: 20020
		[Token(Token = "0x4004E34")]
		[FieldOffset(Offset = "0x110")]
		private Action _InputPollingEndedEvent;

		// Token: 0x04004E35 RID: 20021
		[Token(Token = "0x4004E35")]
		[FieldOffset(Offset = "0x118")]
		private UnityEvent _onScreenClosed;

		// Token: 0x04004E36 RID: 20022
		[Token(Token = "0x4004E36")]
		[FieldOffset(Offset = "0x120")]
		private UnityEvent _onScreenOpened;

		// Token: 0x04004E37 RID: 20023
		[Token(Token = "0x4004E37")]
		[FieldOffset(Offset = "0x128")]
		private UnityEvent _onPopupWindowClosed;

		// Token: 0x04004E38 RID: 20024
		[Token(Token = "0x4004E38")]
		[FieldOffset(Offset = "0x130")]
		private UnityEvent _onPopupWindowOpened;

		// Token: 0x04004E39 RID: 20025
		[Token(Token = "0x4004E39")]
		[FieldOffset(Offset = "0x138")]
		private UnityEvent _onInputPollingStarted;

		// Token: 0x04004E3A RID: 20026
		[Token(Token = "0x4004E3A")]
		[FieldOffset(Offset = "0x140")]
		private UnityEvent _onInputPollingEnded;

		// Token: 0x04004E3B RID: 20027
		[Token(Token = "0x4004E3B")]
		[FieldOffset(Offset = "0x0")]
		private static ControlMapper Instance;

		// Token: 0x04004E3C RID: 20028
		[Token(Token = "0x4004E3C")]
		[FieldOffset(Offset = "0x148")]
		private bool initialized;

		// Token: 0x04004E3D RID: 20029
		[Token(Token = "0x4004E3D")]
		[FieldOffset(Offset = "0x14C")]
		private int playerCount;

		// Token: 0x04004E3E RID: 20030
		[Token(Token = "0x4004E3E")]
		[FieldOffset(Offset = "0x150")]
		private ControlMapper.InputGrid inputGrid;

		// Token: 0x04004E3F RID: 20031
		[Token(Token = "0x4004E3F")]
		[FieldOffset(Offset = "0x158")]
		private ControlMapper.WindowManager windowManager;

		// Token: 0x04004E40 RID: 20032
		[Token(Token = "0x4004E40")]
		[FieldOffset(Offset = "0x160")]
		private int currentPlayerId;

		// Token: 0x04004E41 RID: 20033
		[Token(Token = "0x4004E41")]
		[FieldOffset(Offset = "0x164")]
		private int currentMapCategoryId;

		// Token: 0x04004E42 RID: 20034
		[Token(Token = "0x4004E42")]
		[FieldOffset(Offset = "0x168")]
		private List<ControlMapper.GUIButton> playerButtons;

		// Token: 0x04004E43 RID: 20035
		[Token(Token = "0x4004E43")]
		[FieldOffset(Offset = "0x170")]
		private List<ControlMapper.GUIButton> mapCategoryButtons;

		// Token: 0x04004E44 RID: 20036
		[Token(Token = "0x4004E44")]
		[FieldOffset(Offset = "0x178")]
		private List<ControlMapper.GUIButton> assignedControllerButtons;

		// Token: 0x04004E45 RID: 20037
		[Token(Token = "0x4004E45")]
		[FieldOffset(Offset = "0x180")]
		private ControlMapper.GUIButton assignedControllerButtonsPlaceholder;

		// Token: 0x04004E46 RID: 20038
		[Token(Token = "0x4004E46")]
		[FieldOffset(Offset = "0x188")]
		private List<GameObject> miscInstantiatedObjects;

		// Token: 0x04004E47 RID: 20039
		[Token(Token = "0x4004E47")]
		[FieldOffset(Offset = "0x190")]
		private GameObject canvas;

		// Token: 0x04004E48 RID: 20040
		[Token(Token = "0x4004E48")]
		[FieldOffset(Offset = "0x198")]
		private GameObject lastUISelection;

		// Token: 0x04004E49 RID: 20041
		[Token(Token = "0x4004E49")]
		[FieldOffset(Offset = "0x1A0")]
		private int currentJoystickId;

		// Token: 0x04004E4A RID: 20042
		[Token(Token = "0x4004E4A")]
		[FieldOffset(Offset = "0x1A4")]
		private float blockInputOnFocusEndTime;

		// Token: 0x04004E4B RID: 20043
		[Token(Token = "0x4004E4B")]
		[FieldOffset(Offset = "0x1A8")]
		private bool isPollingForInput;

		// Token: 0x04004E4C RID: 20044
		[Token(Token = "0x4004E4C")]
		[FieldOffset(Offset = "0x1B0")]
		private ControlMapper.InputMapping pendingInputMapping;

		// Token: 0x04004E4D RID: 20045
		[Token(Token = "0x4004E4D")]
		[FieldOffset(Offset = "0x1B8")]
		private ControlMapper.AxisCalibrator pendingAxisCalibration;

		// Token: 0x04004E4E RID: 20046
		[Token(Token = "0x4004E4E")]
		[FieldOffset(Offset = "0x1C0")]
		private Action<InputFieldInfo> inputFieldActivatedDelegate;

		// Token: 0x04004E4F RID: 20047
		[Token(Token = "0x4004E4F")]
		[FieldOffset(Offset = "0x1C8")]
		private Action<ToggleInfo, bool> inputFieldInvertToggleStateChangedDelegate;

		// Token: 0x04004E50 RID: 20048
		[Token(Token = "0x4004E50")]
		[FieldOffset(Offset = "0x1D0")]
		private Action _restoreDefaultsDelegate;

		// Token: 0x02000912 RID: 2322
		[Token(Token = "0x2000912")]
		private abstract class GUIElement
		{
			// Token: 0x170003DF RID: 991
			// (get) Token: 0x06002FF2 RID: 12274 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06002FF3 RID: 12275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170003DF")]
			public RectTransform rectTransform
			{
				[Token(Token = "0x6002FF2")]
				[Address(RVA = "0x728A20", Offset = "0x727A20", VA = "0x180728A20")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002FF3")]
				[Address(RVA = "0xD11640", Offset = "0xD10640", VA = "0x180D11640")]
				private set
				{
				}
			}

			// Token: 0x06002FF4 RID: 12276 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FF4")]
			[Address(RVA = "0xD11A60", Offset = "0xD10A60", VA = "0x180D11A60")]
			public GUIElement(GameObject gameObject)
			{
			}

			// Token: 0x06002FF5 RID: 12277 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FF5")]
			[Address(RVA = "0xD11F80", Offset = "0xD10F80", VA = "0x180D11F80")]
			public GUIElement(Selectable selectable, TMP_Text label)
			{
			}

			// Token: 0x06002FF6 RID: 12278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FF6")]
			[Address(RVA = "0xD123F0", Offset = "0xD113F0", VA = "0x180D123F0", Slot = "4")]
			public virtual void SetInteractible(bool state, bool playTransition)
			{
			}

			// Token: 0x06002FF7 RID: 12279 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FF7")]
			[Address(RVA = "0xD12420", Offset = "0xD11420", VA = "0x180D12420", Slot = "5")]
			public virtual void SetInteractible(bool state, bool playTransition, bool permanent)
			{
			}

			// Token: 0x06002FF8 RID: 12280 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FF8")]
			[Address(RVA = "0xD12640", Offset = "0xD11640", VA = "0x180D12640", Slot = "6")]
			public virtual void SetTextWidth(int value)
			{
			}

			// Token: 0x06002FF9 RID: 12281 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FF9")]
			[Address(RVA = "0xD128E0", Offset = "0xD118E0", VA = "0x180D128E0", Slot = "7")]
			public virtual void SetFirstChildObjectWidth(ControlMapper.LayoutElementSizeType type, int value)
			{
			}

			// Token: 0x06002FFA RID: 12282 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FFA")]
			[Address(RVA = "0xD12BD0", Offset = "0xD11BD0", VA = "0x180D12BD0", Slot = "8")]
			public virtual void SetLabel(string label)
			{
			}

			// Token: 0x06002FFB RID: 12283 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6002FFB")]
			[Address(RVA = "0xD12D00", Offset = "0xD11D00", VA = "0x180D12D00", Slot = "9")]
			public virtual string GetLabel()
			{
				return null;
			}

			// Token: 0x06002FFC RID: 12284 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FFC")]
			[Address(RVA = "0xD12E50", Offset = "0xD11E50", VA = "0x180D12E50", Slot = "10")]
			public virtual void AddChild(ControlMapper.GUIElement child)
			{
			}

			// Token: 0x06002FFD RID: 12285 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FFD")]
			[Address(RVA = "0xD12EB0", Offset = "0xD11EB0", VA = "0x180D12EB0")]
			public void SetElementInfoData(string identifier, int intData)
			{
			}

			// Token: 0x06002FFE RID: 12286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FFE")]
			[Address(RVA = "0xD13040", Offset = "0xD12040", VA = "0x180D13040", Slot = "11")]
			public virtual void SetActive(bool state)
			{
			}

			// Token: 0x06002FFF RID: 12287 RVA: 0x00011640 File Offset: 0x0000F840
			[Token(Token = "0x6002FFF")]
			[Address(RVA = "0xD131A0", Offset = "0xD121A0", VA = "0x180D131A0", Slot = "12")]
			protected virtual bool Init()
			{
				return default(bool);
			}

			// Token: 0x04004E51 RID: 20049
			[Token(Token = "0x4004E51")]
			[FieldOffset(Offset = "0x10")]
			public readonly GameObject gameObject;

			// Token: 0x04004E52 RID: 20050
			[Token(Token = "0x4004E52")]
			[FieldOffset(Offset = "0x18")]
			protected readonly TMP_Text text;

			// Token: 0x04004E53 RID: 20051
			[Token(Token = "0x4004E53")]
			[FieldOffset(Offset = "0x20")]
			public readonly Selectable selectable;

			// Token: 0x04004E54 RID: 20052
			[Token(Token = "0x4004E54")]
			[FieldOffset(Offset = "0x28")]
			protected readonly UIElementInfo uiElementInfo;

			// Token: 0x04004E55 RID: 20053
			[Token(Token = "0x4004E55")]
			[FieldOffset(Offset = "0x30")]
			protected bool permanentStateSet;

			// Token: 0x04004E56 RID: 20054
			[Token(Token = "0x4004E56")]
			[FieldOffset(Offset = "0x38")]
			protected readonly List<ControlMapper.GUIElement> children;

			// Token: 0x04004E57 RID: 20055
			[Token(Token = "0x4004E57")]
			[FieldOffset(Offset = "0x40")]
			private RectTransform <rectTransform>k__BackingField;
		}

		// Token: 0x02000913 RID: 2323
		[Token(Token = "0x2000913")]
		private class GUIButton : ControlMapper.GUIElement
		{
			// Token: 0x170003E0 RID: 992
			// (get) Token: 0x06003000 RID: 12288 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003E0")]
			protected Button button
			{
				[Token(Token = "0x6003000")]
				[Address(RVA = "0xD135E0", Offset = "0xD125E0", VA = "0x180D135E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003E1 RID: 993
			// (get) Token: 0x06003001 RID: 12289 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003E1")]
			public ButtonInfo buttonInfo
			{
				[Token(Token = "0x6003001")]
				[Address(RVA = "0xD13660", Offset = "0xD12660", VA = "0x180D13660")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003002 RID: 12290 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003002")]
			[Address(RVA = "0xD136E0", Offset = "0xD126E0", VA = "0x180D136E0")]
			public GUIButton(GameObject gameObject)
			{
			}

			// Token: 0x06003003 RID: 12291 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003003")]
			[Address(RVA = "0xD13710", Offset = "0xD12710", VA = "0x180D13710")]
			public GUIButton(Button button, TMP_Text label)
			{
			}

			// Token: 0x06003004 RID: 12292 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003004")]
			[Address(RVA = "0xD13740", Offset = "0xD12740", VA = "0x180D13740")]
			public void SetButtonInfoData(string identifier, int intData)
			{
			}

			// Token: 0x06003005 RID: 12293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003005")]
			[Address(RVA = "0xD13750", Offset = "0xD12750", VA = "0x180D13750")]
			public void SetOnClickCallback(Action<ButtonInfo> callback)
			{
			}

			// Token: 0x02000914 RID: 2324
			[Token(Token = "0x2000914")]
			private sealed class <>c__DisplayClass7_0
			{
				// Token: 0x06003006 RID: 12294 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003006")]
				[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
				public <>c__DisplayClass7_0()
				{
				}

				// Token: 0x06003007 RID: 12295 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003007")]
				[Address(RVA = "0xD139B0", Offset = "0xD129B0", VA = "0x180D139B0")]
				internal void <SetOnClickCallback>b__0()
				{
				}

				// Token: 0x04004E58 RID: 20056
				[Token(Token = "0x4004E58")]
				[FieldOffset(Offset = "0x10")]
				public Action<ButtonInfo> callback;

				// Token: 0x04004E59 RID: 20057
				[Token(Token = "0x4004E59")]
				[FieldOffset(Offset = "0x18")]
				public ControlMapper.GUIButton <>4__this;
			}
		}

		// Token: 0x02000915 RID: 2325
		[Token(Token = "0x2000915")]
		private class GUIInputField : ControlMapper.GUIElement
		{
			// Token: 0x170003E2 RID: 994
			// (get) Token: 0x06003008 RID: 12296 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003E2")]
			protected Button button
			{
				[Token(Token = "0x6003008")]
				[Address(RVA = "0xD139F0", Offset = "0xD129F0", VA = "0x180D139F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003E3 RID: 995
			// (get) Token: 0x06003009 RID: 12297 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003E3")]
			public InputFieldInfo fieldInfo
			{
				[Token(Token = "0x6003009")]
				[Address(RVA = "0xD13A70", Offset = "0xD12A70", VA = "0x180D13A70")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003E4 RID: 996
			// (get) Token: 0x0600300A RID: 12298 RVA: 0x00011658 File Offset: 0x0000F858
			[Token(Token = "0x170003E4")]
			public bool hasToggle
			{
				[Token(Token = "0x600300A")]
				[Address(RVA = "0xD13AF0", Offset = "0xD12AF0", VA = "0x180D13AF0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170003E5 RID: 997
			// (get) Token: 0x0600300B RID: 12299 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600300C RID: 12300 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170003E5")]
			public ControlMapper.GUIToggle toggle
			{
				[Token(Token = "0x600300B")]
				[Address(RVA = "0xD13B00", Offset = "0xD12B00", VA = "0x180D13B00")]
				get
				{
					return null;
				}
				[Token(Token = "0x600300C")]
				[Address(RVA = "0xD13B10", Offset = "0xD12B10", VA = "0x180D13B10")]
				private set
				{
				}
			}

			// Token: 0x170003E6 RID: 998
			// (get) Token: 0x0600300D RID: 12301 RVA: 0x00011670 File Offset: 0x0000F870
			// (set) Token: 0x0600300E RID: 12302 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170003E6")]
			public int actionElementMapId
			{
				[Token(Token = "0x600300D")]
				[Address(RVA = "0xD13B70", Offset = "0xD12B70", VA = "0x180D13B70")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600300E")]
				[Address(RVA = "0xD13CA0", Offset = "0xD12CA0", VA = "0x180D13CA0")]
				set
				{
				}
			}

			// Token: 0x170003E7 RID: 999
			// (get) Token: 0x0600300F RID: 12303 RVA: 0x00011688 File Offset: 0x0000F888
			// (set) Token: 0x06003010 RID: 12304 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170003E7")]
			public int controllerId
			{
				[Token(Token = "0x600300F")]
				[Address(RVA = "0xD13DD0", Offset = "0xD12DD0", VA = "0x180D13DD0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6003010")]
				[Address(RVA = "0xD13F00", Offset = "0xD12F00", VA = "0x180D13F00")]
				set
				{
				}
			}

			// Token: 0x06003011 RID: 12305 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003011")]
			[Address(RVA = "0xD136E0", Offset = "0xD126E0", VA = "0x180D136E0")]
			public GUIInputField(GameObject gameObject)
			{
			}

			// Token: 0x06003012 RID: 12306 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003012")]
			[Address(RVA = "0xD13710", Offset = "0xD12710", VA = "0x180D13710")]
			public GUIInputField(Button button, TMP_Text label)
			{
			}

			// Token: 0x06003013 RID: 12307 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003013")]
			[Address(RVA = "0xD14030", Offset = "0xD13030", VA = "0x180D14030")]
			public void SetFieldInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData)
			{
			}

			// Token: 0x06003014 RID: 12308 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003014")]
			[Address(RVA = "0xD141D0", Offset = "0xD131D0", VA = "0x180D141D0")]
			public void SetOnClickCallback(Action<InputFieldInfo> callback)
			{
			}

			// Token: 0x06003015 RID: 12309 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003015")]
			[Address(RVA = "0xD14430", Offset = "0xD13430", VA = "0x180D14430", Slot = "13")]
			public virtual void SetInteractable(bool state, bool playTransition, bool permanent)
			{
			}

			// Token: 0x06003016 RID: 12310 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003016")]
			[Address(RVA = "0xD144C0", Offset = "0xD134C0", VA = "0x180D144C0")]
			public void AddToggle(ControlMapper.GUIToggle toggle)
			{
			}

			// Token: 0x04004E5A RID: 20058
			[Token(Token = "0x4004E5A")]
			[FieldOffset(Offset = "0x48")]
			private ControlMapper.GUIToggle <toggle>k__BackingField;

			// Token: 0x02000916 RID: 2326
			[Token(Token = "0x2000916")]
			private sealed class <>c__DisplayClass19_0
			{
				// Token: 0x06003017 RID: 12311 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003017")]
				[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
				public <>c__DisplayClass19_0()
				{
				}

				// Token: 0x06003018 RID: 12312 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003018")]
				[Address(RVA = "0xD14520", Offset = "0xD13520", VA = "0x180D14520")]
				internal void <SetOnClickCallback>b__0()
				{
				}

				// Token: 0x04004E5B RID: 20059
				[Token(Token = "0x4004E5B")]
				[FieldOffset(Offset = "0x10")]
				public Action<InputFieldInfo> callback;

				// Token: 0x04004E5C RID: 20060
				[Token(Token = "0x4004E5C")]
				[FieldOffset(Offset = "0x18")]
				public ControlMapper.GUIInputField <>4__this;
			}
		}

		// Token: 0x02000917 RID: 2327
		[Token(Token = "0x2000917")]
		private class GUIToggle : ControlMapper.GUIElement
		{
			// Token: 0x170003E8 RID: 1000
			// (get) Token: 0x06003019 RID: 12313 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003E8")]
			protected Toggle toggle
			{
				[Token(Token = "0x6003019")]
				[Address(RVA = "0xD14560", Offset = "0xD13560", VA = "0x180D14560")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003E9 RID: 1001
			// (get) Token: 0x0600301A RID: 12314 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003E9")]
			public ToggleInfo toggleInfo
			{
				[Token(Token = "0x600301A")]
				[Address(RVA = "0xD145E0", Offset = "0xD135E0", VA = "0x180D145E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003EA RID: 1002
			// (get) Token: 0x0600301B RID: 12315 RVA: 0x000116A0 File Offset: 0x0000F8A0
			// (set) Token: 0x0600301C RID: 12316 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170003EA")]
			public int actionElementMapId
			{
				[Token(Token = "0x600301B")]
				[Address(RVA = "0xD14660", Offset = "0xD13660", VA = "0x180D14660")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600301C")]
				[Address(RVA = "0xD14790", Offset = "0xD13790", VA = "0x180D14790")]
				set
				{
				}
			}

			// Token: 0x0600301D RID: 12317 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600301D")]
			[Address(RVA = "0xD136E0", Offset = "0xD126E0", VA = "0x180D136E0")]
			public GUIToggle(GameObject gameObject)
			{
			}

			// Token: 0x0600301E RID: 12318 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600301E")]
			[Address(RVA = "0xD13710", Offset = "0xD12710", VA = "0x180D13710")]
			public GUIToggle(Toggle toggle, TMP_Text label)
			{
			}

			// Token: 0x0600301F RID: 12319 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600301F")]
			[Address(RVA = "0xD148C0", Offset = "0xD138C0", VA = "0x180D148C0")]
			public void SetToggleInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData)
			{
			}

			// Token: 0x06003020 RID: 12320 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003020")]
			[Address(RVA = "0xD14A60", Offset = "0xD13A60", VA = "0x180D14A60")]
			public void SetOnSubmitCallback(Action<ToggleInfo, bool> callback)
			{
			}

			// Token: 0x06003021 RID: 12321 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003021")]
			[Address(RVA = "0xD15090", Offset = "0xD14090", VA = "0x180D15090")]
			public void SetToggleState(bool state)
			{
			}

			// Token: 0x02000918 RID: 2328
			[Token(Token = "0x2000918")]
			private sealed class <>c__DisplayClass10_0
			{
				// Token: 0x06003022 RID: 12322 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003022")]
				[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
				public <>c__DisplayClass10_0()
				{
				}

				// Token: 0x06003023 RID: 12323 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003023")]
				[Address(RVA = "0xD151D0", Offset = "0xD141D0", VA = "0x180D151D0")]
				internal void <SetOnSubmitCallback>b__0(BaseEventData data)
				{
				}

				// Token: 0x04004E5D RID: 20061
				[Token(Token = "0x4004E5D")]
				[FieldOffset(Offset = "0x10")]
				public Action<ToggleInfo, bool> callback;

				// Token: 0x04004E5E RID: 20062
				[Token(Token = "0x4004E5E")]
				[FieldOffset(Offset = "0x18")]
				public ControlMapper.GUIToggle <>4__this;
			}
		}

		// Token: 0x02000919 RID: 2329
		[Token(Token = "0x2000919")]
		private class GUILabel
		{
			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x06003024 RID: 12324 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003025 RID: 12325 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170003EB")]
			public GameObject gameObject
			{
				[Token(Token = "0x6003024")]
				[Address(RVA = "0x3ED8F0", Offset = "0x3EC8F0", VA = "0x1803ED8F0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003025")]
				[Address(RVA = "0x3FE240", Offset = "0x3FD240", VA = "0x1803FE240")]
				private set
				{
				}
			}

			// Token: 0x170003EC RID: 1004
			// (get) Token: 0x06003026 RID: 12326 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003027 RID: 12327 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170003EC")]
			private TMP_Text text
			{
				[Token(Token = "0x6003026")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003027")]
				[Address(RVA = "0x3ED9D0", Offset = "0x3EC9D0", VA = "0x1803ED9D0")]
				set
				{
				}
			}

			// Token: 0x170003ED RID: 1005
			// (get) Token: 0x06003028 RID: 12328 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003029 RID: 12329 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170003ED")]
			public RectTransform rectTransform
			{
				[Token(Token = "0x6003028")]
				[Address(RVA = "0x3EDA30", Offset = "0x3ECA30", VA = "0x1803EDA30")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003029")]
				[Address(RVA = "0x3EDA40", Offset = "0x3ECA40", VA = "0x1803EDA40")]
				private set
				{
				}
			}

			// Token: 0x0600302A RID: 12330 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600302A")]
			[Address(RVA = "0xD152A0", Offset = "0xD142A0", VA = "0x180D152A0")]
			public GUILabel(GameObject gameObject)
			{
			}

			// Token: 0x0600302B RID: 12331 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600302B")]
			[Address(RVA = "0xD154A0", Offset = "0xD144A0", VA = "0x180D154A0")]
			public GUILabel(TMP_Text label)
			{
			}

			// Token: 0x0600302C RID: 12332 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600302C")]
			[Address(RVA = "0xD15500", Offset = "0xD14500", VA = "0x180D15500")]
			public void SetSize(int width, int height)
			{
			}

			// Token: 0x0600302D RID: 12333 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600302D")]
			[Address(RVA = "0xD15660", Offset = "0xD14660", VA = "0x180D15660")]
			public void SetWidth(int width)
			{
			}

			// Token: 0x0600302E RID: 12334 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600302E")]
			[Address(RVA = "0xD15790", Offset = "0xD14790", VA = "0x180D15790")]
			public void SetHeight(int height)
			{
			}

			// Token: 0x0600302F RID: 12335 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600302F")]
			[Address(RVA = "0xD158C0", Offset = "0xD148C0", VA = "0x180D158C0")]
			public void SetLabel(string label)
			{
			}

			// Token: 0x06003030 RID: 12336 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003030")]
			[Address(RVA = "0xD159F0", Offset = "0xD149F0", VA = "0x180D159F0")]
			public void SetFontStyle(FontStyles style)
			{
			}

			// Token: 0x06003031 RID: 12337 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003031")]
			[Address(RVA = "0xD15B50", Offset = "0xD14B50", VA = "0x180D15B50")]
			public void SetTextAlignment(TextAlignmentOptions alignment)
			{
			}

			// Token: 0x06003032 RID: 12338 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003032")]
			[Address(RVA = "0xD15CB0", Offset = "0xD14CB0", VA = "0x180D15CB0")]
			public void SetActive(bool state)
			{
			}

			// Token: 0x06003033 RID: 12339 RVA: 0x000116B8 File Offset: 0x0000F8B8
			[Token(Token = "0x6003033")]
			[Address(RVA = "0xD15E10", Offset = "0xD14E10", VA = "0x180D15E10")]
			private bool Check()
			{
				return default(bool);
			}

			// Token: 0x04004E5F RID: 20063
			[Token(Token = "0x4004E5F")]
			[FieldOffset(Offset = "0x10")]
			private GameObject <gameObject>k__BackingField;

			// Token: 0x04004E60 RID: 20064
			[Token(Token = "0x4004E60")]
			[FieldOffset(Offset = "0x18")]
			private TMP_Text <text>k__BackingField;

			// Token: 0x04004E61 RID: 20065
			[Token(Token = "0x4004E61")]
			[FieldOffset(Offset = "0x20")]
			private RectTransform <rectTransform>k__BackingField;
		}

		// Token: 0x0200091A RID: 2330
		[Token(Token = "0x200091A")]
		[Serializable]
		public class MappingSet
		{
			// Token: 0x170003EE RID: 1006
			// (get) Token: 0x06003034 RID: 12340 RVA: 0x000116D0 File Offset: 0x0000F8D0
			[Token(Token = "0x170003EE")]
			public int mapCategoryId
			{
				[Token(Token = "0x6003034")]
				[Address(RVA = "0x3F9850", Offset = "0x3F8850", VA = "0x1803F9850")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170003EF RID: 1007
			// (get) Token: 0x06003035 RID: 12341 RVA: 0x000116E8 File Offset: 0x0000F8E8
			[Token(Token = "0x170003EF")]
			public ControlMapper.MappingSet.ActionListMode actionListMode
			{
				[Token(Token = "0x6003035")]
				[Address(RVA = "0xD16090", Offset = "0xD15090", VA = "0x180D16090")]
				get
				{
					return ControlMapper.MappingSet.ActionListMode.ActionCategory;
				}
			}

			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x06003036 RID: 12342 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003F0")]
			public IList<int> actionCategoryIds
			{
				[Token(Token = "0x6003036")]
				[Address(RVA = "0xD160A0", Offset = "0xD150A0", VA = "0x180D160A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x06003037 RID: 12343 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003F1")]
			public IList<int> actionIds
			{
				[Token(Token = "0x6003037")]
				[Address(RVA = "0xD161E0", Offset = "0xD151E0", VA = "0x180D161E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x06003038 RID: 12344 RVA: 0x00011700 File Offset: 0x0000F900
			[Token(Token = "0x170003F2")]
			public bool isValid
			{
				[Token(Token = "0x6003038")]
				[Address(RVA = "0xD16320", Offset = "0xD15320", VA = "0x180D16320")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06003039 RID: 12345 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003039")]
			[Address(RVA = "0xD163A0", Offset = "0xD153A0", VA = "0x180D163A0")]
			public MappingSet()
			{
			}

			// Token: 0x0600303A RID: 12346 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600303A")]
			[Address(RVA = "0xD164B0", Offset = "0xD154B0", VA = "0x180D164B0")]
			private MappingSet(int mapCategoryId, ControlMapper.MappingSet.ActionListMode actionListMode, int[] actionCategoryIds, int[] actionIds)
			{
			}

			// Token: 0x170003F3 RID: 1011
			// (get) Token: 0x0600303B RID: 12347 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003F3")]
			public static ControlMapper.MappingSet Default
			{
				[Token(Token = "0x600303B")]
				[Address(RVA = "0xD16570", Offset = "0xD15570", VA = "0x180D16570")]
				get
				{
					return null;
				}
			}

			// Token: 0x04004E62 RID: 20066
			[Token(Token = "0x4004E62")]
			[FieldOffset(Offset = "0x10")]
			private int _mapCategoryId;

			// Token: 0x04004E63 RID: 20067
			[Token(Token = "0x4004E63")]
			[FieldOffset(Offset = "0x14")]
			private ControlMapper.MappingSet.ActionListMode _actionListMode;

			// Token: 0x04004E64 RID: 20068
			[Token(Token = "0x4004E64")]
			[FieldOffset(Offset = "0x18")]
			private int[] _actionCategoryIds;

			// Token: 0x04004E65 RID: 20069
			[Token(Token = "0x4004E65")]
			[FieldOffset(Offset = "0x20")]
			private int[] _actionIds;

			// Token: 0x04004E66 RID: 20070
			[Token(Token = "0x4004E66")]
			[FieldOffset(Offset = "0x28")]
			private IList<int> _actionCategoryIdsReadOnly;

			// Token: 0x04004E67 RID: 20071
			[Token(Token = "0x4004E67")]
			[FieldOffset(Offset = "0x30")]
			private IList<int> _actionIdsReadOnly;

			// Token: 0x0200091B RID: 2331
			[Token(Token = "0x200091B")]
			public enum ActionListMode
			{
				// Token: 0x04004E69 RID: 20073
				[Token(Token = "0x4004E69")]
				ActionCategory,
				// Token: 0x04004E6A RID: 20074
				[Token(Token = "0x4004E6A")]
				Action
			}
		}

		// Token: 0x0200091C RID: 2332
		[Token(Token = "0x200091C")]
		[Serializable]
		public class InputBehaviorSettings
		{
			// Token: 0x170003F4 RID: 1012
			// (get) Token: 0x0600303C RID: 12348 RVA: 0x00011718 File Offset: 0x0000F918
			[Token(Token = "0x170003F4")]
			public int inputBehaviorId
			{
				[Token(Token = "0x600303C")]
				[Address(RVA = "0x3F9850", Offset = "0x3F8850", VA = "0x1803F9850")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170003F5 RID: 1013
			// (get) Token: 0x0600303D RID: 12349 RVA: 0x00011730 File Offset: 0x0000F930
			[Token(Token = "0x170003F5")]
			public bool showJoystickAxisSensitivity
			{
				[Token(Token = "0x600303D")]
				[Address(RVA = "0xD166B0", Offset = "0xD156B0", VA = "0x180D166B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x0600303E RID: 12350 RVA: 0x00011748 File Offset: 0x0000F948
			[Token(Token = "0x170003F6")]
			public bool showMouseXYAxisSensitivity
			{
				[Token(Token = "0x600303E")]
				[Address(RVA = "0xD166C0", Offset = "0xD156C0", VA = "0x180D166C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x0600303F RID: 12351 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003F7")]
			public string labelLanguageKey
			{
				[Token(Token = "0x600303F")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x06003040 RID: 12352 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003F8")]
			public string joystickAxisSensitivityLabelLanguageKey
			{
				[Token(Token = "0x6003040")]
				[Address(RVA = "0x3EDA30", Offset = "0x3ECA30", VA = "0x1803EDA30")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x06003041 RID: 12353 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003F9")]
			public string mouseXYAxisSensitivityLabelLanguageKey
			{
				[Token(Token = "0x6003041")]
				[Address(RVA = "0xD166D0", Offset = "0xD156D0", VA = "0x180D166D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003FA RID: 1018
			// (get) Token: 0x06003042 RID: 12354 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003FA")]
			public Sprite joystickAxisSensitivityIcon
			{
				[Token(Token = "0x6003042")]
				[Address(RVA = "0xD166E0", Offset = "0xD156E0", VA = "0x180D166E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003FB RID: 1019
			// (get) Token: 0x06003043 RID: 12355 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003FB")]
			public Sprite mouseXYAxisSensitivityIcon
			{
				[Token(Token = "0x6003043")]
				[Address(RVA = "0xD166F0", Offset = "0xD156F0", VA = "0x180D166F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x06003044 RID: 12356 RVA: 0x00011760 File Offset: 0x0000F960
			[Token(Token = "0x170003FC")]
			public float joystickAxisSensitivityMin
			{
				[Token(Token = "0x6003044")]
				[Address(RVA = "0xD16700", Offset = "0xD15700", VA = "0x180D16700")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x06003045 RID: 12357 RVA: 0x00011778 File Offset: 0x0000F978
			[Token(Token = "0x170003FD")]
			public float joystickAxisSensitivityMax
			{
				[Token(Token = "0x6003045")]
				[Address(RVA = "0xD16710", Offset = "0xD15710", VA = "0x180D16710")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x06003046 RID: 12358 RVA: 0x00011790 File Offset: 0x0000F990
			[Token(Token = "0x170003FE")]
			public float mouseXYAxisSensitivityMin
			{
				[Token(Token = "0x6003046")]
				[Address(RVA = "0xD16720", Offset = "0xD15720", VA = "0x180D16720")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170003FF RID: 1023
			// (get) Token: 0x06003047 RID: 12359 RVA: 0x000117A8 File Offset: 0x0000F9A8
			[Token(Token = "0x170003FF")]
			public float mouseXYAxisSensitivityMax
			{
				[Token(Token = "0x6003047")]
				[Address(RVA = "0xD16730", Offset = "0xD15730", VA = "0x180D16730")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x06003048 RID: 12360 RVA: 0x000117C0 File Offset: 0x0000F9C0
			[Token(Token = "0x17000400")]
			public bool isValid
			{
				[Token(Token = "0x6003048")]
				[Address(RVA = "0xD16740", Offset = "0xD15740", VA = "0x180D16740")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06003049 RID: 12361 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003049")]
			[Address(RVA = "0xD16760", Offset = "0xD15760", VA = "0x180D16760")]
			public InputBehaviorSettings()
			{
			}

			// Token: 0x04004E6B RID: 20075
			[Token(Token = "0x4004E6B")]
			[FieldOffset(Offset = "0x10")]
			private int _inputBehaviorId;

			// Token: 0x04004E6C RID: 20076
			[Token(Token = "0x4004E6C")]
			[FieldOffset(Offset = "0x14")]
			private bool _showJoystickAxisSensitivity;

			// Token: 0x04004E6D RID: 20077
			[Token(Token = "0x4004E6D")]
			[FieldOffset(Offset = "0x15")]
			private bool _showMouseXYAxisSensitivity;

			// Token: 0x04004E6E RID: 20078
			[Token(Token = "0x4004E6E")]
			[FieldOffset(Offset = "0x18")]
			private string _labelLanguageKey;

			// Token: 0x04004E6F RID: 20079
			[Token(Token = "0x4004E6F")]
			[FieldOffset(Offset = "0x20")]
			private string _joystickAxisSensitivityLabelLanguageKey;

			// Token: 0x04004E70 RID: 20080
			[Token(Token = "0x4004E70")]
			[FieldOffset(Offset = "0x28")]
			private string _mouseXYAxisSensitivityLabelLanguageKey;

			// Token: 0x04004E71 RID: 20081
			[Token(Token = "0x4004E71")]
			[FieldOffset(Offset = "0x30")]
			private Sprite _joystickAxisSensitivityIcon;

			// Token: 0x04004E72 RID: 20082
			[Token(Token = "0x4004E72")]
			[FieldOffset(Offset = "0x38")]
			private Sprite _mouseXYAxisSensitivityIcon;

			// Token: 0x04004E73 RID: 20083
			[Token(Token = "0x4004E73")]
			[FieldOffset(Offset = "0x40")]
			private float _joystickAxisSensitivityMin;

			// Token: 0x04004E74 RID: 20084
			[Token(Token = "0x4004E74")]
			[FieldOffset(Offset = "0x44")]
			private float _joystickAxisSensitivityMax;

			// Token: 0x04004E75 RID: 20085
			[Token(Token = "0x4004E75")]
			[FieldOffset(Offset = "0x48")]
			private float _mouseXYAxisSensitivityMin;

			// Token: 0x04004E76 RID: 20086
			[Token(Token = "0x4004E76")]
			[FieldOffset(Offset = "0x4C")]
			private float _mouseXYAxisSensitivityMax;
		}

		// Token: 0x0200091D RID: 2333
		[Token(Token = "0x200091D")]
		[Serializable]
		private class Prefabs
		{
			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x0600304A RID: 12362 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000401")]
			public GameObject button
			{
				[Token(Token = "0x600304A")]
				[Address(RVA = "0x3ED8F0", Offset = "0x3EC8F0", VA = "0x1803ED8F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x0600304B RID: 12363 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000402")]
			public GameObject fitButton
			{
				[Token(Token = "0x600304B")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000403 RID: 1027
			// (get) Token: 0x0600304C RID: 12364 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000403")]
			public GameObject inputGridLabel
			{
				[Token(Token = "0x600304C")]
				[Address(RVA = "0x3EDA30", Offset = "0x3ECA30", VA = "0x1803EDA30")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000404 RID: 1028
			// (get) Token: 0x0600304D RID: 12365 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000404")]
			public GameObject inputGridHeaderLabel
			{
				[Token(Token = "0x600304D")]
				[Address(RVA = "0xD166D0", Offset = "0xD156D0", VA = "0x180D166D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000405 RID: 1029
			// (get) Token: 0x0600304E RID: 12366 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000405")]
			public GameObject inputGridFieldButton
			{
				[Token(Token = "0x600304E")]
				[Address(RVA = "0xD166E0", Offset = "0xD156E0", VA = "0x180D166E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000406 RID: 1030
			// (get) Token: 0x0600304F RID: 12367 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000406")]
			public GameObject inputGridFieldInvertToggle
			{
				[Token(Token = "0x600304F")]
				[Address(RVA = "0xD166F0", Offset = "0xD156F0", VA = "0x180D166F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000407 RID: 1031
			// (get) Token: 0x06003050 RID: 12368 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000407")]
			public GameObject window
			{
				[Token(Token = "0x6003050")]
				[Address(RVA = "0x728A20", Offset = "0x727A20", VA = "0x180728A20")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000408 RID: 1032
			// (get) Token: 0x06003051 RID: 12369 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000408")]
			public GameObject windowTitleText
			{
				[Token(Token = "0x6003051")]
				[Address(RVA = "0xD13B00", Offset = "0xD12B00", VA = "0x180D13B00")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000409 RID: 1033
			// (get) Token: 0x06003052 RID: 12370 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000409")]
			public GameObject windowContentText
			{
				[Token(Token = "0x6003052")]
				[Address(RVA = "0x3E97E0", Offset = "0x3E87E0", VA = "0x1803E97E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700040A RID: 1034
			// (get) Token: 0x06003053 RID: 12371 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700040A")]
			public GameObject fader
			{
				[Token(Token = "0x6003053")]
				[Address(RVA = "0xD168D0", Offset = "0xD158D0", VA = "0x180D168D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700040B RID: 1035
			// (get) Token: 0x06003054 RID: 12372 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700040B")]
			public GameObject calibrationWindow
			{
				[Token(Token = "0x6003054")]
				[Address(RVA = "0xD168E0", Offset = "0xD158E0", VA = "0x180D168E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700040C RID: 1036
			// (get) Token: 0x06003055 RID: 12373 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700040C")]
			public GameObject inputBehaviorsWindow
			{
				[Token(Token = "0x6003055")]
				[Address(RVA = "0xD168F0", Offset = "0xD158F0", VA = "0x180D168F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700040D RID: 1037
			// (get) Token: 0x06003056 RID: 12374 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700040D")]
			public GameObject centerStickGraphic
			{
				[Token(Token = "0x6003056")]
				[Address(RVA = "0xC1C120", Offset = "0xC1B120", VA = "0x180C1C120")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700040E RID: 1038
			// (get) Token: 0x06003057 RID: 12375 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700040E")]
			public GameObject moveStickGraphic
			{
				[Token(Token = "0x6003057")]
				[Address(RVA = "0xCE9E40", Offset = "0xCE8E40", VA = "0x180CE9E40")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003058 RID: 12376 RVA: 0x000117D8 File Offset: 0x0000F9D8
			[Token(Token = "0x6003058")]
			[Address(RVA = "0xD16900", Offset = "0xD15900", VA = "0x180D16900")]
			public bool Check()
			{
				return default(bool);
			}

			// Token: 0x06003059 RID: 12377 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003059")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public Prefabs()
			{
			}

			// Token: 0x04004E77 RID: 20087
			[Token(Token = "0x4004E77")]
			[FieldOffset(Offset = "0x10")]
			private GameObject _button;

			// Token: 0x04004E78 RID: 20088
			[Token(Token = "0x4004E78")]
			[FieldOffset(Offset = "0x18")]
			private GameObject _fitButton;

			// Token: 0x04004E79 RID: 20089
			[Token(Token = "0x4004E79")]
			[FieldOffset(Offset = "0x20")]
			private GameObject _inputGridLabel;

			// Token: 0x04004E7A RID: 20090
			[Token(Token = "0x4004E7A")]
			[FieldOffset(Offset = "0x28")]
			private GameObject _inputGridHeaderLabel;

			// Token: 0x04004E7B RID: 20091
			[Token(Token = "0x4004E7B")]
			[FieldOffset(Offset = "0x30")]
			private GameObject _inputGridFieldButton;

			// Token: 0x04004E7C RID: 20092
			[Token(Token = "0x4004E7C")]
			[FieldOffset(Offset = "0x38")]
			private GameObject _inputGridFieldInvertToggle;

			// Token: 0x04004E7D RID: 20093
			[Token(Token = "0x4004E7D")]
			[FieldOffset(Offset = "0x40")]
			private GameObject _window;

			// Token: 0x04004E7E RID: 20094
			[Token(Token = "0x4004E7E")]
			[FieldOffset(Offset = "0x48")]
			private GameObject _windowTitleText;

			// Token: 0x04004E7F RID: 20095
			[Token(Token = "0x4004E7F")]
			[FieldOffset(Offset = "0x50")]
			private GameObject _windowContentText;

			// Token: 0x04004E80 RID: 20096
			[Token(Token = "0x4004E80")]
			[FieldOffset(Offset = "0x58")]
			private GameObject _fader;

			// Token: 0x04004E81 RID: 20097
			[Token(Token = "0x4004E81")]
			[FieldOffset(Offset = "0x60")]
			private GameObject _calibrationWindow;

			// Token: 0x04004E82 RID: 20098
			[Token(Token = "0x4004E82")]
			[FieldOffset(Offset = "0x68")]
			private GameObject _inputBehaviorsWindow;

			// Token: 0x04004E83 RID: 20099
			[Token(Token = "0x4004E83")]
			[FieldOffset(Offset = "0x70")]
			private GameObject _centerStickGraphic;

			// Token: 0x04004E84 RID: 20100
			[Token(Token = "0x4004E84")]
			[FieldOffset(Offset = "0x78")]
			private GameObject _moveStickGraphic;
		}

		// Token: 0x0200091E RID: 2334
		[Token(Token = "0x200091E")]
		[Serializable]
		private class References
		{
			// Token: 0x1700040F RID: 1039
			// (get) Token: 0x0600305A RID: 12378 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700040F")]
			public Canvas canvas
			{
				[Token(Token = "0x600305A")]
				[Address(RVA = "0x3ED8F0", Offset = "0x3EC8F0", VA = "0x1803ED8F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000410 RID: 1040
			// (get) Token: 0x0600305B RID: 12379 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000410")]
			public CanvasGroup mainCanvasGroup
			{
				[Token(Token = "0x600305B")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000411 RID: 1041
			// (get) Token: 0x0600305C RID: 12380 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000411")]
			public Transform mainContent
			{
				[Token(Token = "0x600305C")]
				[Address(RVA = "0x3EDA30", Offset = "0x3ECA30", VA = "0x1803EDA30")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000412 RID: 1042
			// (get) Token: 0x0600305D RID: 12381 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000412")]
			public Transform mainContentInner
			{
				[Token(Token = "0x600305D")]
				[Address(RVA = "0xD166D0", Offset = "0xD156D0", VA = "0x180D166D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000413 RID: 1043
			// (get) Token: 0x0600305E RID: 12382 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000413")]
			public UIGroup playersGroup
			{
				[Token(Token = "0x600305E")]
				[Address(RVA = "0xD166E0", Offset = "0xD156E0", VA = "0x180D166E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000414 RID: 1044
			// (get) Token: 0x0600305F RID: 12383 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000414")]
			public Transform controllerGroup
			{
				[Token(Token = "0x600305F")]
				[Address(RVA = "0xD166F0", Offset = "0xD156F0", VA = "0x180D166F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000415 RID: 1045
			// (get) Token: 0x06003060 RID: 12384 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000415")]
			public Transform controllerGroupLabelGroup
			{
				[Token(Token = "0x6003060")]
				[Address(RVA = "0x728A20", Offset = "0x727A20", VA = "0x180728A20")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x06003061 RID: 12385 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000416")]
			public UIGroup controllerSettingsGroup
			{
				[Token(Token = "0x6003061")]
				[Address(RVA = "0xD13B00", Offset = "0xD12B00", VA = "0x180D13B00")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000417 RID: 1047
			// (get) Token: 0x06003062 RID: 12386 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000417")]
			public UIGroup assignedControllersGroup
			{
				[Token(Token = "0x6003062")]
				[Address(RVA = "0x3E97E0", Offset = "0x3E87E0", VA = "0x1803E97E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000418 RID: 1048
			// (get) Token: 0x06003063 RID: 12387 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000418")]
			public Transform settingsAndMapCategoriesGroup
			{
				[Token(Token = "0x6003063")]
				[Address(RVA = "0xD168D0", Offset = "0xD158D0", VA = "0x180D168D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000419 RID: 1049
			// (get) Token: 0x06003064 RID: 12388 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000419")]
			public UIGroup settingsGroup
			{
				[Token(Token = "0x6003064")]
				[Address(RVA = "0xD168E0", Offset = "0xD158E0", VA = "0x180D168E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700041A RID: 1050
			// (get) Token: 0x06003065 RID: 12389 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700041A")]
			public UIGroup mapCategoriesGroup
			{
				[Token(Token = "0x6003065")]
				[Address(RVA = "0xD168F0", Offset = "0xD158F0", VA = "0x180D168F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700041B RID: 1051
			// (get) Token: 0x06003066 RID: 12390 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700041B")]
			public Transform inputGridGroup
			{
				[Token(Token = "0x6003066")]
				[Address(RVA = "0xC1C120", Offset = "0xC1B120", VA = "0x180C1C120")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700041C RID: 1052
			// (get) Token: 0x06003067 RID: 12391 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700041C")]
			public Transform inputGridContainer
			{
				[Token(Token = "0x6003067")]
				[Address(RVA = "0xCE9E40", Offset = "0xCE8E40", VA = "0x180CE9E40")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700041D RID: 1053
			// (get) Token: 0x06003068 RID: 12392 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700041D")]
			public Transform inputGridHeadersGroup
			{
				[Token(Token = "0x6003068")]
				[Address(RVA = "0xD17220", Offset = "0xD16220", VA = "0x180D17220")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700041E RID: 1054
			// (get) Token: 0x06003069 RID: 12393 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700041E")]
			public Scrollbar inputGridVScrollbar
			{
				[Token(Token = "0x6003069")]
				[Address(RVA = "0xD17230", Offset = "0xD16230", VA = "0x180D17230")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700041F RID: 1055
			// (get) Token: 0x0600306A RID: 12394 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700041F")]
			public ScrollRect inputGridScrollRect
			{
				[Token(Token = "0x600306A")]
				[Address(RVA = "0xD17240", Offset = "0xD16240", VA = "0x180D17240")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000420 RID: 1056
			// (get) Token: 0x0600306B RID: 12395 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000420")]
			public Transform inputGridInnerGroup
			{
				[Token(Token = "0x600306B")]
				[Address(RVA = "0xD17250", Offset = "0xD16250", VA = "0x180D17250")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000421 RID: 1057
			// (get) Token: 0x0600306C RID: 12396 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000421")]
			public TMP_Text controllerNameLabel
			{
				[Token(Token = "0x600306C")]
				[Address(RVA = "0xD17260", Offset = "0xD16260", VA = "0x180D17260")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000422 RID: 1058
			// (get) Token: 0x0600306D RID: 12397 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000422")]
			public Button removeControllerButton
			{
				[Token(Token = "0x600306D")]
				[Address(RVA = "0xD17270", Offset = "0xD16270", VA = "0x180D17270")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000423 RID: 1059
			// (get) Token: 0x0600306E RID: 12398 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000423")]
			public Button assignControllerButton
			{
				[Token(Token = "0x600306E")]
				[Address(RVA = "0xD17280", Offset = "0xD16280", VA = "0x180D17280")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000424 RID: 1060
			// (get) Token: 0x0600306F RID: 12399 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000424")]
			public Button calibrateControllerButton
			{
				[Token(Token = "0x600306F")]
				[Address(RVA = "0xCEAB80", Offset = "0xCE9B80", VA = "0x180CEAB80")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000425 RID: 1061
			// (get) Token: 0x06003070 RID: 12400 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000425")]
			public Button doneButton
			{
				[Token(Token = "0x6003070")]
				[Address(RVA = "0xCEACC0", Offset = "0xCE9CC0", VA = "0x180CEACC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000426 RID: 1062
			// (get) Token: 0x06003071 RID: 12401 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000426")]
			public Button restoreDefaultsButton
			{
				[Token(Token = "0x6003071")]
				[Address(RVA = "0xCEAE00", Offset = "0xCE9E00", VA = "0x180CEAE00")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000427 RID: 1063
			// (get) Token: 0x06003072 RID: 12402 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000427")]
			public Selectable defaultSelection
			{
				[Token(Token = "0x6003072")]
				[Address(RVA = "0xCEAF40", Offset = "0xCE9F40", VA = "0x180CEAF40")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000428 RID: 1064
			// (get) Token: 0x06003073 RID: 12403 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000428")]
			public GameObject[] fixedSelectableUIElements
			{
				[Token(Token = "0x6003073")]
				[Address(RVA = "0xD17290", Offset = "0xD16290", VA = "0x180D17290")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000429 RID: 1065
			// (get) Token: 0x06003074 RID: 12404 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000429")]
			public Image mainBackgroundImage
			{
				[Token(Token = "0x6003074")]
				[Address(RVA = "0xD172A0", Offset = "0xD162A0", VA = "0x180D172A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700042A RID: 1066
			// (get) Token: 0x06003075 RID: 12405 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003076 RID: 12406 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700042A")]
			public LayoutElement inputGridLayoutElement
			{
				[Token(Token = "0x6003075")]
				[Address(RVA = "0xD172B0", Offset = "0xD162B0", VA = "0x180D172B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003076")]
				[Address(RVA = "0xD172C0", Offset = "0xD162C0", VA = "0x180D172C0")]
				set
				{
				}
			}

			// Token: 0x1700042B RID: 1067
			// (get) Token: 0x06003077 RID: 12407 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003078 RID: 12408 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700042B")]
			public Transform inputGridActionColumn
			{
				[Token(Token = "0x6003077")]
				[Address(RVA = "0xD17320", Offset = "0xD16320", VA = "0x180D17320")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003078")]
				[Address(RVA = "0xD17330", Offset = "0xD16330", VA = "0x180D17330")]
				set
				{
				}
			}

			// Token: 0x1700042C RID: 1068
			// (get) Token: 0x06003079 RID: 12409 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600307A RID: 12410 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700042C")]
			public Transform inputGridKeyboardColumn
			{
				[Token(Token = "0x6003079")]
				[Address(RVA = "0xD17390", Offset = "0xD16390", VA = "0x180D17390")]
				get
				{
					return null;
				}
				[Token(Token = "0x600307A")]
				[Address(RVA = "0xD173A0", Offset = "0xD163A0", VA = "0x180D173A0")]
				set
				{
				}
			}

			// Token: 0x1700042D RID: 1069
			// (get) Token: 0x0600307B RID: 12411 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600307C RID: 12412 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700042D")]
			public Transform inputGridMouseColumn
			{
				[Token(Token = "0x600307B")]
				[Address(RVA = "0xD17400", Offset = "0xD16400", VA = "0x180D17400")]
				get
				{
					return null;
				}
				[Token(Token = "0x600307C")]
				[Address(RVA = "0xD17410", Offset = "0xD16410", VA = "0x180D17410")]
				set
				{
				}
			}

			// Token: 0x1700042E RID: 1070
			// (get) Token: 0x0600307D RID: 12413 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600307E RID: 12414 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700042E")]
			public Transform inputGridControllerColumn
			{
				[Token(Token = "0x600307D")]
				[Address(RVA = "0xD17470", Offset = "0xD16470", VA = "0x180D17470")]
				get
				{
					return null;
				}
				[Token(Token = "0x600307E")]
				[Address(RVA = "0xD17480", Offset = "0xD16480", VA = "0x180D17480")]
				set
				{
				}
			}

			// Token: 0x1700042F RID: 1071
			// (get) Token: 0x0600307F RID: 12415 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003080 RID: 12416 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700042F")]
			public Transform inputGridHeader1
			{
				[Token(Token = "0x600307F")]
				[Address(RVA = "0xD174E0", Offset = "0xD164E0", VA = "0x180D174E0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003080")]
				[Address(RVA = "0xD174F0", Offset = "0xD164F0", VA = "0x180D174F0")]
				set
				{
				}
			}

			// Token: 0x17000430 RID: 1072
			// (get) Token: 0x06003081 RID: 12417 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003082 RID: 12418 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000430")]
			public Transform inputGridHeader2
			{
				[Token(Token = "0x6003081")]
				[Address(RVA = "0xD17550", Offset = "0xD16550", VA = "0x180D17550")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003082")]
				[Address(RVA = "0xD17560", Offset = "0xD16560", VA = "0x180D17560")]
				set
				{
				}
			}

			// Token: 0x17000431 RID: 1073
			// (get) Token: 0x06003083 RID: 12419 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003084 RID: 12420 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000431")]
			public Transform inputGridHeader3
			{
				[Token(Token = "0x6003083")]
				[Address(RVA = "0xD175C0", Offset = "0xD165C0", VA = "0x180D175C0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003084")]
				[Address(RVA = "0xD175D0", Offset = "0xD165D0", VA = "0x180D175D0")]
				set
				{
				}
			}

			// Token: 0x17000432 RID: 1074
			// (get) Token: 0x06003085 RID: 12421 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003086 RID: 12422 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000432")]
			public Transform inputGridHeader4
			{
				[Token(Token = "0x6003085")]
				[Address(RVA = "0x70EC50", Offset = "0x70DC50", VA = "0x18070EC50")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003086")]
				[Address(RVA = "0x70EBF0", Offset = "0x70DBF0", VA = "0x18070EBF0")]
				set
				{
				}
			}

			// Token: 0x06003087 RID: 12423 RVA: 0x000117F0 File Offset: 0x0000F9F0
			[Token(Token = "0x6003087")]
			[Address(RVA = "0xD17630", Offset = "0xD16630", VA = "0x180D17630")]
			public bool Check()
			{
				return default(bool);
			}

			// Token: 0x06003088 RID: 12424 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003088")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public References()
			{
			}

			// Token: 0x04004E85 RID: 20101
			[Token(Token = "0x4004E85")]
			[FieldOffset(Offset = "0x10")]
			private Canvas _canvas;

			// Token: 0x04004E86 RID: 20102
			[Token(Token = "0x4004E86")]
			[FieldOffset(Offset = "0x18")]
			private CanvasGroup _mainCanvasGroup;

			// Token: 0x04004E87 RID: 20103
			[Token(Token = "0x4004E87")]
			[FieldOffset(Offset = "0x20")]
			private Transform _mainContent;

			// Token: 0x04004E88 RID: 20104
			[Token(Token = "0x4004E88")]
			[FieldOffset(Offset = "0x28")]
			private Transform _mainContentInner;

			// Token: 0x04004E89 RID: 20105
			[Token(Token = "0x4004E89")]
			[FieldOffset(Offset = "0x30")]
			private UIGroup _playersGroup;

			// Token: 0x04004E8A RID: 20106
			[Token(Token = "0x4004E8A")]
			[FieldOffset(Offset = "0x38")]
			private Transform _controllerGroup;

			// Token: 0x04004E8B RID: 20107
			[Token(Token = "0x4004E8B")]
			[FieldOffset(Offset = "0x40")]
			private Transform _controllerGroupLabelGroup;

			// Token: 0x04004E8C RID: 20108
			[Token(Token = "0x4004E8C")]
			[FieldOffset(Offset = "0x48")]
			private UIGroup _controllerSettingsGroup;

			// Token: 0x04004E8D RID: 20109
			[Token(Token = "0x4004E8D")]
			[FieldOffset(Offset = "0x50")]
			private UIGroup _assignedControllersGroup;

			// Token: 0x04004E8E RID: 20110
			[Token(Token = "0x4004E8E")]
			[FieldOffset(Offset = "0x58")]
			private Transform _settingsAndMapCategoriesGroup;

			// Token: 0x04004E8F RID: 20111
			[Token(Token = "0x4004E8F")]
			[FieldOffset(Offset = "0x60")]
			private UIGroup _settingsGroup;

			// Token: 0x04004E90 RID: 20112
			[Token(Token = "0x4004E90")]
			[FieldOffset(Offset = "0x68")]
			private UIGroup _mapCategoriesGroup;

			// Token: 0x04004E91 RID: 20113
			[Token(Token = "0x4004E91")]
			[FieldOffset(Offset = "0x70")]
			private Transform _inputGridGroup;

			// Token: 0x04004E92 RID: 20114
			[Token(Token = "0x4004E92")]
			[FieldOffset(Offset = "0x78")]
			private Transform _inputGridContainer;

			// Token: 0x04004E93 RID: 20115
			[Token(Token = "0x4004E93")]
			[FieldOffset(Offset = "0x80")]
			private Transform _inputGridHeadersGroup;

			// Token: 0x04004E94 RID: 20116
			[Token(Token = "0x4004E94")]
			[FieldOffset(Offset = "0x88")]
			private Scrollbar _inputGridVScrollbar;

			// Token: 0x04004E95 RID: 20117
			[Token(Token = "0x4004E95")]
			[FieldOffset(Offset = "0x90")]
			private ScrollRect _inputGridScrollRect;

			// Token: 0x04004E96 RID: 20118
			[Token(Token = "0x4004E96")]
			[FieldOffset(Offset = "0x98")]
			private Transform _inputGridInnerGroup;

			// Token: 0x04004E97 RID: 20119
			[Token(Token = "0x4004E97")]
			[FieldOffset(Offset = "0xA0")]
			private TMP_Text _controllerNameLabel;

			// Token: 0x04004E98 RID: 20120
			[Token(Token = "0x4004E98")]
			[FieldOffset(Offset = "0xA8")]
			private Button _removeControllerButton;

			// Token: 0x04004E99 RID: 20121
			[Token(Token = "0x4004E99")]
			[FieldOffset(Offset = "0xB0")]
			private Button _assignControllerButton;

			// Token: 0x04004E9A RID: 20122
			[Token(Token = "0x4004E9A")]
			[FieldOffset(Offset = "0xB8")]
			private Button _calibrateControllerButton;

			// Token: 0x04004E9B RID: 20123
			[Token(Token = "0x4004E9B")]
			[FieldOffset(Offset = "0xC0")]
			private Button _doneButton;

			// Token: 0x04004E9C RID: 20124
			[Token(Token = "0x4004E9C")]
			[FieldOffset(Offset = "0xC8")]
			private Button _restoreDefaultsButton;

			// Token: 0x04004E9D RID: 20125
			[Token(Token = "0x4004E9D")]
			[FieldOffset(Offset = "0xD0")]
			private Selectable _defaultSelection;

			// Token: 0x04004E9E RID: 20126
			[Token(Token = "0x4004E9E")]
			[FieldOffset(Offset = "0xD8")]
			private GameObject[] _fixedSelectableUIElements;

			// Token: 0x04004E9F RID: 20127
			[Token(Token = "0x4004E9F")]
			[FieldOffset(Offset = "0xE0")]
			private Image _mainBackgroundImage;

			// Token: 0x04004EA0 RID: 20128
			[Token(Token = "0x4004EA0")]
			[FieldOffset(Offset = "0xE8")]
			private LayoutElement <inputGridLayoutElement>k__BackingField;

			// Token: 0x04004EA1 RID: 20129
			[Token(Token = "0x4004EA1")]
			[FieldOffset(Offset = "0xF0")]
			private Transform <inputGridActionColumn>k__BackingField;

			// Token: 0x04004EA2 RID: 20130
			[Token(Token = "0x4004EA2")]
			[FieldOffset(Offset = "0xF8")]
			private Transform <inputGridKeyboardColumn>k__BackingField;

			// Token: 0x04004EA3 RID: 20131
			[Token(Token = "0x4004EA3")]
			[FieldOffset(Offset = "0x100")]
			private Transform <inputGridMouseColumn>k__BackingField;

			// Token: 0x04004EA4 RID: 20132
			[Token(Token = "0x4004EA4")]
			[FieldOffset(Offset = "0x108")]
			private Transform <inputGridControllerColumn>k__BackingField;

			// Token: 0x04004EA5 RID: 20133
			[Token(Token = "0x4004EA5")]
			[FieldOffset(Offset = "0x110")]
			private Transform <inputGridHeader1>k__BackingField;

			// Token: 0x04004EA6 RID: 20134
			[Token(Token = "0x4004EA6")]
			[FieldOffset(Offset = "0x118")]
			private Transform <inputGridHeader2>k__BackingField;

			// Token: 0x04004EA7 RID: 20135
			[Token(Token = "0x4004EA7")]
			[FieldOffset(Offset = "0x120")]
			private Transform <inputGridHeader3>k__BackingField;

			// Token: 0x04004EA8 RID: 20136
			[Token(Token = "0x4004EA8")]
			[FieldOffset(Offset = "0x128")]
			private Transform <inputGridHeader4>k__BackingField;
		}

		// Token: 0x0200091F RID: 2335
		[Token(Token = "0x200091F")]
		private class InputActionSet
		{
			// Token: 0x17000433 RID: 1075
			// (get) Token: 0x06003089 RID: 12425 RVA: 0x00011808 File Offset: 0x0000FA08
			[Token(Token = "0x17000433")]
			public int actionId
			{
				[Token(Token = "0x6003089")]
				[Address(RVA = "0x3F9850", Offset = "0x3F8850", VA = "0x1803F9850")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000434 RID: 1076
			// (get) Token: 0x0600308A RID: 12426 RVA: 0x00011820 File Offset: 0x0000FA20
			[Token(Token = "0x17000434")]
			public AxisRange axisRange
			{
				[Token(Token = "0x600308A")]
				[Address(RVA = "0xD16090", Offset = "0xD15090", VA = "0x180D16090")]
				get
				{
					return AxisRange.Full;
				}
			}

			// Token: 0x0600308B RID: 12427 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600308B")]
			[Address(RVA = "0xD181C0", Offset = "0xD171C0", VA = "0x180D181C0")]
			public InputActionSet(int actionId, AxisRange axisRange)
			{
			}

			// Token: 0x04004EA9 RID: 20137
			[Token(Token = "0x4004EA9")]
			[FieldOffset(Offset = "0x10")]
			private int _actionId;

			// Token: 0x04004EAA RID: 20138
			[Token(Token = "0x4004EAA")]
			[FieldOffset(Offset = "0x14")]
			private AxisRange _axisRange;
		}

		// Token: 0x02000920 RID: 2336
		[Token(Token = "0x2000920")]
		private class InputMapping
		{
			// Token: 0x17000435 RID: 1077
			// (get) Token: 0x0600308C RID: 12428 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600308D RID: 12429 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000435")]
			public string actionName
			{
				[Token(Token = "0x600308C")]
				[Address(RVA = "0x3ED8F0", Offset = "0x3EC8F0", VA = "0x1803ED8F0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600308D")]
				[Address(RVA = "0x3FE240", Offset = "0x3FD240", VA = "0x1803FE240")]
				private set
				{
				}
			}

			// Token: 0x17000436 RID: 1078
			// (get) Token: 0x0600308E RID: 12430 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600308F RID: 12431 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000436")]
			public InputFieldInfo fieldInfo
			{
				[Token(Token = "0x600308E")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600308F")]
				[Address(RVA = "0x3ED9D0", Offset = "0x3EC9D0", VA = "0x1803ED9D0")]
				private set
				{
				}
			}

			// Token: 0x17000437 RID: 1079
			// (get) Token: 0x06003090 RID: 12432 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003091 RID: 12433 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000437")]
			public ControllerMap map
			{
				[Token(Token = "0x6003090")]
				[Address(RVA = "0x3EDA30", Offset = "0x3ECA30", VA = "0x1803EDA30")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003091")]
				[Address(RVA = "0x3EDA40", Offset = "0x3ECA40", VA = "0x1803EDA40")]
				private set
				{
				}
			}

			// Token: 0x17000438 RID: 1080
			// (get) Token: 0x06003092 RID: 12434 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003093 RID: 12435 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000438")]
			public ActionElementMap aem
			{
				[Token(Token = "0x6003092")]
				[Address(RVA = "0xD166D0", Offset = "0xD156D0", VA = "0x180D166D0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003093")]
				[Address(RVA = "0x3FE2A0", Offset = "0x3FD2A0", VA = "0x1803FE2A0")]
				private set
				{
				}
			}

			// Token: 0x17000439 RID: 1081
			// (get) Token: 0x06003094 RID: 12436 RVA: 0x00011838 File Offset: 0x0000FA38
			// (set) Token: 0x06003095 RID: 12437 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000439")]
			public ControllerType controllerType
			{
				[Token(Token = "0x6003094")]
				[Address(RVA = "0xD181D0", Offset = "0xD171D0", VA = "0x180D181D0")]
				get
				{
					return ControllerType.Keyboard;
				}
				[Token(Token = "0x6003095")]
				[Address(RVA = "0xD181E0", Offset = "0xD171E0", VA = "0x180D181E0")]
				private set
				{
				}
			}

			// Token: 0x1700043A RID: 1082
			// (get) Token: 0x06003096 RID: 12438 RVA: 0x00011850 File Offset: 0x0000FA50
			// (set) Token: 0x06003097 RID: 12439 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700043A")]
			public int controllerId
			{
				[Token(Token = "0x6003096")]
				[Address(RVA = "0xD181F0", Offset = "0xD171F0", VA = "0x180D181F0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6003097")]
				[Address(RVA = "0xD18200", Offset = "0xD17200", VA = "0x180D18200")]
				private set
				{
				}
			}

			// Token: 0x1700043B RID: 1083
			// (get) Token: 0x06003098 RID: 12440 RVA: 0x00011868 File Offset: 0x0000FA68
			// (set) Token: 0x06003099 RID: 12441 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700043B")]
			public ControllerPollingInfo pollingInfo
			{
				[Token(Token = "0x6003098")]
				[Address(RVA = "0xD18210", Offset = "0xD17210", VA = "0x180D18210")]
				get
				{
					return default(ControllerPollingInfo);
				}
				[Token(Token = "0x6003099")]
				[Address(RVA = "0xD18240", Offset = "0xD17240", VA = "0x180D18240")]
				set
				{
				}
			}

			// Token: 0x1700043C RID: 1084
			// (get) Token: 0x0600309A RID: 12442 RVA: 0x00011880 File Offset: 0x0000FA80
			// (set) Token: 0x0600309B RID: 12443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700043C")]
			public ModifierKeyFlags modifierKeyFlags
			{
				[Token(Token = "0x600309A")]
				[Address(RVA = "0xD182C0", Offset = "0xD172C0", VA = "0x180D182C0")]
				get
				{
					return ModifierKeyFlags.None;
				}
				[Token(Token = "0x600309B")]
				[Address(RVA = "0xD182D0", Offset = "0xD172D0", VA = "0x180D182D0")]
				set
				{
				}
			}

			// Token: 0x1700043D RID: 1085
			// (get) Token: 0x0600309C RID: 12444 RVA: 0x00011898 File Offset: 0x0000FA98
			[Token(Token = "0x1700043D")]
			public AxisRange axisRange
			{
				[Token(Token = "0x600309C")]
				[Address(RVA = "0xD182E0", Offset = "0xD172E0", VA = "0x180D182E0")]
				get
				{
					return AxisRange.Full;
				}
			}

			// Token: 0x1700043E RID: 1086
			// (get) Token: 0x0600309D RID: 12445 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700043E")]
			public string elementName
			{
				[Token(Token = "0x600309D")]
				[Address(RVA = "0xD18330", Offset = "0xD17330", VA = "0x180D18330")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600309E RID: 12446 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600309E")]
			[Address(RVA = "0xD18430", Offset = "0xD17430", VA = "0x180D18430")]
			public InputMapping(string actionName, InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, ControllerType controllerType, int controllerId)
			{
			}

			// Token: 0x0600309F RID: 12447 RVA: 0x000118B0 File Offset: 0x0000FAB0
			[Token(Token = "0x600309F")]
			[Address(RVA = "0xD18590", Offset = "0xD17590", VA = "0x180D18590")]
			public ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo)
			{
				return default(ElementAssignment);
			}

			// Token: 0x060030A0 RID: 12448 RVA: 0x000118C8 File Offset: 0x0000FAC8
			[Token(Token = "0x60030A0")]
			[Address(RVA = "0xD18640", Offset = "0xD17640", VA = "0x180D18640")]
			public ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo, ModifierKeyFlags modifierKeyFlags)
			{
				return default(ElementAssignment);
			}

			// Token: 0x060030A1 RID: 12449 RVA: 0x000118E0 File Offset: 0x0000FAE0
			[Token(Token = "0x60030A1")]
			[Address(RVA = "0xD18700", Offset = "0xD17700", VA = "0x180D18700")]
			public ElementAssignment ToElementAssignment()
			{
				return default(ElementAssignment);
			}

			// Token: 0x04004EAB RID: 20139
			[Token(Token = "0x4004EAB")]
			[FieldOffset(Offset = "0x10")]
			private string <actionName>k__BackingField;

			// Token: 0x04004EAC RID: 20140
			[Token(Token = "0x4004EAC")]
			[FieldOffset(Offset = "0x18")]
			private InputFieldInfo <fieldInfo>k__BackingField;

			// Token: 0x04004EAD RID: 20141
			[Token(Token = "0x4004EAD")]
			[FieldOffset(Offset = "0x20")]
			private ControllerMap <map>k__BackingField;

			// Token: 0x04004EAE RID: 20142
			[Token(Token = "0x4004EAE")]
			[FieldOffset(Offset = "0x28")]
			private ActionElementMap <aem>k__BackingField;

			// Token: 0x04004EAF RID: 20143
			[Token(Token = "0x4004EAF")]
			[FieldOffset(Offset = "0x30")]
			private ControllerType <controllerType>k__BackingField;

			// Token: 0x04004EB0 RID: 20144
			[Token(Token = "0x4004EB0")]
			[FieldOffset(Offset = "0x34")]
			private int <controllerId>k__BackingField;

			// Token: 0x04004EB1 RID: 20145
			[Token(Token = "0x4004EB1")]
			[FieldOffset(Offset = "0x38")]
			private ControllerPollingInfo <pollingInfo>k__BackingField;

			// Token: 0x04004EB2 RID: 20146
			[Token(Token = "0x4004EB2")]
			[FieldOffset(Offset = "0x70")]
			private ModifierKeyFlags <modifierKeyFlags>k__BackingField;
		}

		// Token: 0x02000921 RID: 2337
		[Token(Token = "0x2000921")]
		private class AxisCalibrator
		{
			// Token: 0x1700043F RID: 1087
			// (get) Token: 0x060030A2 RID: 12450 RVA: 0x000118F8 File Offset: 0x0000FAF8
			[Token(Token = "0x1700043F")]
			public bool isValid
			{
				[Token(Token = "0x60030A2")]
				[Address(RVA = "0xD188B0", Offset = "0xD178B0", VA = "0x180D188B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060030A3 RID: 12451 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030A3")]
			[Address(RVA = "0xD188C0", Offset = "0xD178C0", VA = "0x180D188C0")]
			public AxisCalibrator(Joystick joystick, int axisIndex)
			{
			}

			// Token: 0x060030A4 RID: 12452 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030A4")]
			[Address(RVA = "0xD18A30", Offset = "0xD17A30", VA = "0x180D18A30")]
			public void RecordMinMax()
			{
			}

			// Token: 0x060030A5 RID: 12453 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030A5")]
			[Address(RVA = "0xD18A80", Offset = "0xD17A80", VA = "0x180D18A80")]
			public void RecordZero()
			{
			}

			// Token: 0x060030A6 RID: 12454 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030A6")]
			[Address(RVA = "0xD18AB0", Offset = "0xD17AB0", VA = "0x180D18AB0")]
			public void Commit()
			{
			}

			// Token: 0x04004EB3 RID: 20147
			[Token(Token = "0x4004EB3")]
			[FieldOffset(Offset = "0x10")]
			public AxisCalibrationData data;

			// Token: 0x04004EB4 RID: 20148
			[Token(Token = "0x4004EB4")]
			[FieldOffset(Offset = "0x48")]
			public readonly Joystick joystick;

			// Token: 0x04004EB5 RID: 20149
			[Token(Token = "0x4004EB5")]
			[FieldOffset(Offset = "0x50")]
			public readonly int axisIndex;

			// Token: 0x04004EB6 RID: 20150
			[Token(Token = "0x4004EB6")]
			[FieldOffset(Offset = "0x58")]
			private Controller.Axis axis;

			// Token: 0x04004EB7 RID: 20151
			[Token(Token = "0x4004EB7")]
			[FieldOffset(Offset = "0x60")]
			private bool firstRun;
		}

		// Token: 0x02000922 RID: 2338
		[Token(Token = "0x2000922")]
		private class IndexedDictionary<TKey, TValue>
		{
			// Token: 0x17000440 RID: 1088
			// (get) Token: 0x060030A7 RID: 12455 RVA: 0x00011910 File Offset: 0x0000FB10
			[Token(Token = "0x17000440")]
			public int Count
			{
				[Token(Token = "0x60030A7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060030A8 RID: 12456 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030A8")]
			public IndexedDictionary()
			{
			}

			// Token: 0x17000441 RID: 1089
			// (get) Token: 0x060030A9 RID: 12457 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000441")]
			public TValue Item
			{
				[Token(Token = "0x60030A9")]
				get
				{
					return null;
				}
			}

			// Token: 0x060030AA RID: 12458 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60030AA")]
			public TValue Get(TKey key)
			{
				return null;
			}

			// Token: 0x060030AB RID: 12459 RVA: 0x00011928 File Offset: 0x0000FB28
			[Token(Token = "0x60030AB")]
			public bool TryGet(TKey key, out TValue value)
			{
				return default(bool);
			}

			// Token: 0x060030AC RID: 12460 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030AC")]
			public void Add(TKey key, TValue value)
			{
			}

			// Token: 0x060030AD RID: 12461 RVA: 0x00011940 File Offset: 0x0000FB40
			[Token(Token = "0x60030AD")]
			public int IndexOfKey(TKey key)
			{
				return 0;
			}

			// Token: 0x060030AE RID: 12462 RVA: 0x00011958 File Offset: 0x0000FB58
			[Token(Token = "0x60030AE")]
			public bool ContainsKey(TKey key)
			{
				return default(bool);
			}

			// Token: 0x060030AF RID: 12463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030AF")]
			public void Clear()
			{
			}

			// Token: 0x04004EB8 RID: 20152
			[Token(Token = "0x4004EB8")]
			[FieldOffset(Offset = "0x0")]
			private List<ControlMapper.IndexedDictionary<TKey, TValue>.Entry> list;

			// Token: 0x02000923 RID: 2339
			[Token(Token = "0x2000923")]
			private class Entry
			{
				// Token: 0x060030B0 RID: 12464 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030B0")]
				public Entry(TKey key, TValue value)
				{
				}

				// Token: 0x04004EB9 RID: 20153
				[Token(Token = "0x4004EB9")]
				[FieldOffset(Offset = "0x0")]
				public TKey key;

				// Token: 0x04004EBA RID: 20154
				[Token(Token = "0x4004EBA")]
				[FieldOffset(Offset = "0x0")]
				public TValue value;
			}
		}

		// Token: 0x02000924 RID: 2340
		[Token(Token = "0x2000924")]
		private enum LayoutElementSizeType
		{
			// Token: 0x04004EBC RID: 20156
			[Token(Token = "0x4004EBC")]
			MinSize,
			// Token: 0x04004EBD RID: 20157
			[Token(Token = "0x4004EBD")]
			PreferredSize
		}

		// Token: 0x02000925 RID: 2341
		[Token(Token = "0x2000925")]
		private enum WindowType
		{
			// Token: 0x04004EBF RID: 20159
			[Token(Token = "0x4004EBF")]
			None,
			// Token: 0x04004EC0 RID: 20160
			[Token(Token = "0x4004EC0")]
			ChooseJoystick,
			// Token: 0x04004EC1 RID: 20161
			[Token(Token = "0x4004EC1")]
			JoystickAssignmentConflict,
			// Token: 0x04004EC2 RID: 20162
			[Token(Token = "0x4004EC2")]
			ElementAssignment,
			// Token: 0x04004EC3 RID: 20163
			[Token(Token = "0x4004EC3")]
			ElementAssignmentPrePolling,
			// Token: 0x04004EC4 RID: 20164
			[Token(Token = "0x4004EC4")]
			ElementAssignmentPolling,
			// Token: 0x04004EC5 RID: 20165
			[Token(Token = "0x4004EC5")]
			ElementAssignmentResult,
			// Token: 0x04004EC6 RID: 20166
			[Token(Token = "0x4004EC6")]
			ElementAssignmentConflict,
			// Token: 0x04004EC7 RID: 20167
			[Token(Token = "0x4004EC7")]
			Calibration,
			// Token: 0x04004EC8 RID: 20168
			[Token(Token = "0x4004EC8")]
			CalibrateStep1,
			// Token: 0x04004EC9 RID: 20169
			[Token(Token = "0x4004EC9")]
			CalibrateStep2
		}

		// Token: 0x02000926 RID: 2342
		[Token(Token = "0x2000926")]
		private class InputGrid
		{
			// Token: 0x060030B1 RID: 12465 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030B1")]
			[Address(RVA = "0xD18B50", Offset = "0xD17B50", VA = "0x180D18B50")]
			public InputGrid()
			{
			}

			// Token: 0x060030B2 RID: 12466 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030B2")]
			[Address(RVA = "0xD18D80", Offset = "0xD17D80", VA = "0x180D18D80")]
			public void AddMapCategory(int mapCategoryId)
			{
			}

			// Token: 0x060030B3 RID: 12467 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030B3")]
			[Address(RVA = "0xD18DA0", Offset = "0xD17DA0", VA = "0x180D18DA0")]
			public void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
			}

			// Token: 0x060030B4 RID: 12468 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030B4")]
			[Address(RVA = "0xD18E50", Offset = "0xD17E50", VA = "0x180D18E50")]
			public void AddActionCategory(int mapCategoryId, int actionCategoryId)
			{
			}

			// Token: 0x060030B5 RID: 12469 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030B5")]
			[Address(RVA = "0xD18FB0", Offset = "0xD17FB0", VA = "0x180D18FB0")]
			public void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer)
			{
			}

			// Token: 0x060030B6 RID: 12470 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030B6")]
			[Address(RVA = "0xD19000", Offset = "0xD18000", VA = "0x180D19000")]
			public void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, ControlMapper.GUIInputField inputField)
			{
			}

			// Token: 0x060030B7 RID: 12471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030B7")]
			[Address(RVA = "0xD19120", Offset = "0xD18120", VA = "0x180D19120")]
			public void AddGroup(GameObject group)
			{
			}

			// Token: 0x060030B8 RID: 12472 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030B8")]
			[Address(RVA = "0xD19180", Offset = "0xD18180", VA = "0x180D19180")]
			public void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControlMapper.GUILabel label)
			{
			}

			// Token: 0x060030B9 RID: 12473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030B9")]
			[Address(RVA = "0xD19290", Offset = "0xD18290", VA = "0x180D19290")]
			public void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, ControlMapper.GUILabel label)
			{
			}

			// Token: 0x060030BA RID: 12474 RVA: 0x00011970 File Offset: 0x0000FB70
			[Token(Token = "0x60030BA")]
			[Address(RVA = "0xD19400", Offset = "0xD18400", VA = "0x180D19400")]
			public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
			{
				return default(bool);
			}

			// Token: 0x060030BB RID: 12475 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60030BB")]
			[Address(RVA = "0xD194E0", Offset = "0xD184E0", VA = "0x180D194E0")]
			public ControlMapper.GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
			{
				return null;
			}

			// Token: 0x060030BC RID: 12476 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60030BC")]
			[Address(RVA = "0xD19610", Offset = "0xD18610", VA = "0x180D19610")]
			public IEnumerable<ControlMapper.InputActionSet> GetActionSets(int mapCategoryId)
			{
				return null;
			}

			// Token: 0x060030BD RID: 12477 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030BD")]
			[Address(RVA = "0xD196E0", Offset = "0xD186E0", VA = "0x180D196E0")]
			public void SetColumnHeight(int mapCategoryId, float height)
			{
			}

			// Token: 0x060030BE RID: 12478 RVA: 0x00011988 File Offset: 0x0000FB88
			[Token(Token = "0x60030BE")]
			[Address(RVA = "0xD19770", Offset = "0xD18770", VA = "0x180D19770")]
			public float GetColumnHeight(int mapCategoryId)
			{
				return 0f;
			}

			// Token: 0x060030BF RID: 12479 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030BF")]
			[Address(RVA = "0xD19800", Offset = "0xD18800", VA = "0x180D19800")]
			public void SetFieldsActive(int mapCategoryId, bool state)
			{
			}

			// Token: 0x060030C0 RID: 12480 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030C0")]
			[Address(RVA = "0xD19930", Offset = "0xD18930", VA = "0x180D19930")]
			public void SetFieldLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int index, string label)
			{
			}

			// Token: 0x060030C1 RID: 12481 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030C1")]
			[Address(RVA = "0xD19A90", Offset = "0xD18A90", VA = "0x180D19A90")]
			public void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
			{
			}

			// Token: 0x060030C2 RID: 12482 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030C2")]
			[Address(RVA = "0xD19B10", Offset = "0xD18B10", VA = "0x180D19B10")]
			public void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId)
			{
			}

			// Token: 0x060030C3 RID: 12483 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030C3")]
			[Address(RVA = "0xD19B60", Offset = "0xD18B60", VA = "0x180D19B60")]
			public void InitializeFields(int mapCategoryId)
			{
			}

			// Token: 0x060030C4 RID: 12484 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030C4")]
			[Address(RVA = "0xD19C80", Offset = "0xD18C80", VA = "0x180D19C80")]
			public void Show(int mapCategoryId)
			{
			}

			// Token: 0x060030C5 RID: 12485 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030C5")]
			[Address(RVA = "0xD19D10", Offset = "0xD18D10", VA = "0x180D19D10")]
			public void HideAll()
			{
			}

			// Token: 0x060030C6 RID: 12486 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030C6")]
			[Address(RVA = "0xD19E20", Offset = "0xD18E20", VA = "0x180D19E20")]
			public void ClearLabels(int mapCategoryId)
			{
			}

			// Token: 0x060030C7 RID: 12487 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030C7")]
			[Address(RVA = "0xD19F40", Offset = "0xD18F40", VA = "0x180D19F40")]
			private void ClearGroups()
			{
			}

			// Token: 0x060030C8 RID: 12488 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030C8")]
			[Address(RVA = "0xD1A120", Offset = "0xD19120", VA = "0x180D1A120")]
			public void ClearAll()
			{
			}

			// Token: 0x04004ECA RID: 20170
			[Token(Token = "0x4004ECA")]
			[FieldOffset(Offset = "0x10")]
			private ControlMapper.InputGridEntryList list;

			// Token: 0x04004ECB RID: 20171
			[Token(Token = "0x4004ECB")]
			[FieldOffset(Offset = "0x18")]
			private List<GameObject> groups;
		}

		// Token: 0x02000927 RID: 2343
		[Token(Token = "0x2000927")]
		private class InputGridEntryList
		{
			// Token: 0x060030C9 RID: 12489 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030C9")]
			[Address(RVA = "0xD1A1A0", Offset = "0xD191A0", VA = "0x180D1A1A0")]
			public InputGridEntryList()
			{
			}

			// Token: 0x060030CA RID: 12490 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030CA")]
			[Address(RVA = "0xD1A270", Offset = "0xD19270", VA = "0x180D1A270")]
			public void AddMapCategory(int mapCategoryId)
			{
			}

			// Token: 0x060030CB RID: 12491 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030CB")]
			[Address(RVA = "0xD1A4B0", Offset = "0xD194B0", VA = "0x180D1A4B0")]
			public void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
			}

			// Token: 0x060030CC RID: 12492 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60030CC")]
			[Address(RVA = "0xD1A550", Offset = "0xD19550", VA = "0x180D1A550")]
			private ControlMapper.InputGridEntryList.ActionEntry AddActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
				return null;
			}

			// Token: 0x060030CD RID: 12493 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030CD")]
			[Address(RVA = "0xD1A5F0", Offset = "0xD195F0", VA = "0x180D1A5F0")]
			public void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControlMapper.GUILabel label)
			{
			}

			// Token: 0x060030CE RID: 12494 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030CE")]
			[Address(RVA = "0xD1A6E0", Offset = "0xD196E0", VA = "0x180D1A6E0")]
			public void AddActionCategory(int mapCategoryId, int actionCategoryId)
			{
			}

			// Token: 0x060030CF RID: 12495 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60030CF")]
			[Address(RVA = "0xD1A830", Offset = "0xD19830", VA = "0x180D1A830")]
			private ControlMapper.InputGridEntryList.ActionCategoryEntry AddActionCategoryEntry(int mapCategoryId, int actionCategoryId)
			{
				return null;
			}

			// Token: 0x060030D0 RID: 12496 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030D0")]
			[Address(RVA = "0xD1A980", Offset = "0xD19980", VA = "0x180D1A980")]
			public void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, ControlMapper.GUILabel label)
			{
			}

			// Token: 0x060030D1 RID: 12497 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030D1")]
			[Address(RVA = "0xD1AAD0", Offset = "0xD19AD0", VA = "0x180D1AAD0")]
			public void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer)
			{
			}

			// Token: 0x060030D2 RID: 12498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030D2")]
			[Address(RVA = "0xD1AB10", Offset = "0xD19B10", VA = "0x180D1AB10")]
			public void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, ControlMapper.GUIInputField inputField)
			{
			}

			// Token: 0x060030D3 RID: 12499 RVA: 0x000119A0 File Offset: 0x0000FBA0
			[Token(Token = "0x60030D3")]
			[Address(RVA = "0xD1AC30", Offset = "0xD19C30", VA = "0x180D1AC30")]
			public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange)
			{
				return default(bool);
			}

			// Token: 0x060030D4 RID: 12500 RVA: 0x000119B8 File Offset: 0x0000FBB8
			[Token(Token = "0x60030D4")]
			[Address(RVA = "0xD1AC50", Offset = "0xD19C50", VA = "0x180D1AC50")]
			public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
			{
				return default(bool);
			}

			// Token: 0x060030D5 RID: 12501 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030D5")]
			[Address(RVA = "0xD1AD20", Offset = "0xD19D20", VA = "0x180D1AD20")]
			public void SetColumnHeight(int mapCategoryId, float height)
			{
			}

			// Token: 0x060030D6 RID: 12502 RVA: 0x000119D0 File Offset: 0x0000FBD0
			[Token(Token = "0x60030D6")]
			[Address(RVA = "0xD1ADA0", Offset = "0xD19DA0", VA = "0x180D1ADA0")]
			public float GetColumnHeight(int mapCategoryId)
			{
				return 0f;
			}

			// Token: 0x060030D7 RID: 12503 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60030D7")]
			[Address(RVA = "0xD1AE20", Offset = "0xD19E20", VA = "0x180D1AE20")]
			public ControlMapper.GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
			{
				return null;
			}

			// Token: 0x060030D8 RID: 12504 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60030D8")]
			[Address(RVA = "0xD1AF50", Offset = "0xD19F50", VA = "0x180D1AF50")]
			private ControlMapper.InputGridEntryList.ActionEntry GetActionEntry(int mapCategoryId, int actionId, AxisRange axisRange)
			{
				return null;
			}

			// Token: 0x060030D9 RID: 12505 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60030D9")]
			[Address(RVA = "0xD1AFF0", Offset = "0xD19FF0", VA = "0x180D1AFF0")]
			private ControlMapper.InputGridEntryList.ActionEntry GetActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
				return null;
			}

			// Token: 0x060030DA RID: 12506 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60030DA")]
			[Address(RVA = "0xD1B010", Offset = "0xD1A010", VA = "0x180D1B010")]
			public IEnumerable<ControlMapper.InputActionSet> GetActionSets(int mapCategoryId)
			{
				return null;
			}

			// Token: 0x060030DB RID: 12507 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030DB")]
			[Address(RVA = "0xD1B0D0", Offset = "0xD1A0D0", VA = "0x180D1B0D0")]
			public void SetFieldsActive(int mapCategoryId, bool state)
			{
			}

			// Token: 0x060030DC RID: 12508 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030DC")]
			[Address(RVA = "0xD1B1F0", Offset = "0xD1A1F0", VA = "0x180D1B1F0")]
			public void SetLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int index, string label)
			{
			}

			// Token: 0x060030DD RID: 12509 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030DD")]
			[Address(RVA = "0xD1B340", Offset = "0xD1A340", VA = "0x180D1B340")]
			public void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
			{
			}

			// Token: 0x060030DE RID: 12510 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030DE")]
			[Address(RVA = "0xD1B3B0", Offset = "0xD1A3B0", VA = "0x180D1B3B0")]
			public void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId)
			{
			}

			// Token: 0x060030DF RID: 12511 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030DF")]
			[Address(RVA = "0xD1B3F0", Offset = "0xD1A3F0", VA = "0x180D1B3F0")]
			public void InitializeFields(int mapCategoryId)
			{
			}

			// Token: 0x060030E0 RID: 12512 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030E0")]
			[Address(RVA = "0xD1B4F0", Offset = "0xD1A4F0", VA = "0x180D1B4F0")]
			public void Show(int mapCategoryId)
			{
			}

			// Token: 0x060030E1 RID: 12513 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030E1")]
			[Address(RVA = "0xD1B570", Offset = "0xD1A570", VA = "0x180D1B570")]
			public void HideAll()
			{
			}

			// Token: 0x060030E2 RID: 12514 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030E2")]
			[Address(RVA = "0xD1B680", Offset = "0xD1A680", VA = "0x180D1B680")]
			public void ClearLabels(int mapCategoryId)
			{
			}

			// Token: 0x060030E3 RID: 12515 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030E3")]
			[Address(RVA = "0xD1B780", Offset = "0xD1A780", VA = "0x180D1B780")]
			public void Clear()
			{
			}

			// Token: 0x04004ECC RID: 20172
			[Token(Token = "0x4004ECC")]
			[FieldOffset(Offset = "0x10")]
			private ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.MapCategoryEntry> entries;

			// Token: 0x02000928 RID: 2344
			[Token(Token = "0x2000928")]
			private class MapCategoryEntry
			{
				// Token: 0x17000442 RID: 1090
				// (get) Token: 0x060030E4 RID: 12516 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x17000442")]
				public List<ControlMapper.InputGridEntryList.ActionEntry> actionList
				{
					[Token(Token = "0x60030E4")]
					[Address(RVA = "0x3ED8F0", Offset = "0x3EC8F0", VA = "0x1803ED8F0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000443 RID: 1091
				// (get) Token: 0x060030E5 RID: 12517 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x17000443")]
				public ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.ActionCategoryEntry> actionCategoryList
				{
					[Token(Token = "0x60030E5")]
					[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000444 RID: 1092
				// (get) Token: 0x060030E6 RID: 12518 RVA: 0x000119E8 File Offset: 0x0000FBE8
				// (set) Token: 0x060030E7 RID: 12519 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000444")]
				public float columnHeight
				{
					[Token(Token = "0x60030E6")]
					[Address(RVA = "0xD1B7F0", Offset = "0xD1A7F0", VA = "0x180D1B7F0")]
					get
					{
						return 0f;
					}
					[Token(Token = "0x60030E7")]
					[Address(RVA = "0xD1B800", Offset = "0xD1A800", VA = "0x180D1B800")]
					set
					{
					}
				}

				// Token: 0x060030E8 RID: 12520 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030E8")]
				[Address(RVA = "0xD1B810", Offset = "0xD1A810", VA = "0x180D1B810")]
				public MapCategoryEntry()
				{
				}

				// Token: 0x060030E9 RID: 12521 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x60030E9")]
				[Address(RVA = "0xD1B980", Offset = "0xD1A980", VA = "0x180D1B980")]
				public ControlMapper.InputGridEntryList.ActionEntry GetActionEntry(int actionId, AxisRange axisRange)
				{
					return null;
				}

				// Token: 0x060030EA RID: 12522 RVA: 0x00011A00 File Offset: 0x0000FC00
				[Token(Token = "0x60030EA")]
				[Address(RVA = "0xD1BA30", Offset = "0xD1AA30", VA = "0x180D1BA30")]
				public int IndexOfActionEntry(int actionId, AxisRange axisRange)
				{
					return 0;
				}

				// Token: 0x060030EB RID: 12523 RVA: 0x00011A18 File Offset: 0x0000FC18
				[Token(Token = "0x60030EB")]
				[Address(RVA = "0xD1BB10", Offset = "0xD1AB10", VA = "0x180D1BB10")]
				public bool ContainsActionEntry(int actionId, AxisRange axisRange)
				{
					return default(bool);
				}

				// Token: 0x060030EC RID: 12524 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x60030EC")]
				[Address(RVA = "0xD1BB30", Offset = "0xD1AB30", VA = "0x180D1BB30")]
				public ControlMapper.InputGridEntryList.ActionEntry AddAction(InputAction action, AxisRange axisRange)
				{
					return null;
				}

				// Token: 0x060030ED RID: 12525 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x60030ED")]
				[Address(RVA = "0xD1BDF0", Offset = "0xD1ADF0", VA = "0x180D1BDF0")]
				public ControlMapper.InputGridEntryList.ActionCategoryEntry GetActionCategoryEntry(int actionCategoryId)
				{
					return null;
				}

				// Token: 0x060030EE RID: 12526 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x60030EE")]
				[Address(RVA = "0xD1BE80", Offset = "0xD1AE80", VA = "0x180D1BE80")]
				public ControlMapper.InputGridEntryList.ActionCategoryEntry AddActionCategory(int actionCategoryId)
				{
					return null;
				}

				// Token: 0x060030EF RID: 12527 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030EF")]
				[Address(RVA = "0xD1BF80", Offset = "0xD1AF80", VA = "0x180D1BF80")]
				public void SetAllActive(bool state)
				{
				}

				// Token: 0x04004ECD RID: 20173
				[Token(Token = "0x4004ECD")]
				[FieldOffset(Offset = "0x10")]
				private List<ControlMapper.InputGridEntryList.ActionEntry> _actionList;

				// Token: 0x04004ECE RID: 20174
				[Token(Token = "0x4004ECE")]
				[FieldOffset(Offset = "0x18")]
				private ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.ActionCategoryEntry> _actionCategoryList;

				// Token: 0x04004ECF RID: 20175
				[Token(Token = "0x4004ECF")]
				[FieldOffset(Offset = "0x20")]
				private float _columnHeight;
			}

			// Token: 0x02000929 RID: 2345
			[Token(Token = "0x2000929")]
			private class ActionEntry
			{
				// Token: 0x060030F0 RID: 12528 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030F0")]
				[Address(RVA = "0xD1C2A0", Offset = "0xD1B2A0", VA = "0x180D1C2A0")]
				public ActionEntry(InputAction action, AxisRange axisRange)
				{
				}

				// Token: 0x060030F1 RID: 12529 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030F1")]
				[Address(RVA = "0x3ED9D0", Offset = "0x3EC9D0", VA = "0x1803ED9D0")]
				public void SetLabel(ControlMapper.GUILabel label)
				{
				}

				// Token: 0x060030F2 RID: 12530 RVA: 0x00011A30 File Offset: 0x0000FC30
				[Token(Token = "0x60030F2")]
				[Address(RVA = "0xD1C480", Offset = "0xD1B480", VA = "0x180D1C480")]
				public bool Matches(int actionId, AxisRange axisRange)
				{
					return default(bool);
				}

				// Token: 0x060030F3 RID: 12531 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030F3")]
				[Address(RVA = "0xD1C4B0", Offset = "0xD1B4B0", VA = "0x180D1C4B0")]
				public void AddInputFieldSet(ControllerType controllerType, GameObject fieldSetContainer)
				{
				}

				// Token: 0x060030F4 RID: 12532 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030F4")]
				[Address(RVA = "0xD1C6A0", Offset = "0xD1B6A0", VA = "0x180D1C6A0")]
				public void AddInputField(ControllerType controllerType, int fieldIndex, ControlMapper.GUIInputField inputField)
				{
				}

				// Token: 0x060030F5 RID: 12533 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x60030F5")]
				[Address(RVA = "0xD1C7A0", Offset = "0xD1B7A0", VA = "0x180D1C7A0")]
				public ControlMapper.GUIInputField GetGUIInputField(ControllerType controllerType, int fieldIndex)
				{
					return null;
				}

				// Token: 0x060030F6 RID: 12534 RVA: 0x00011A48 File Offset: 0x0000FC48
				[Token(Token = "0x60030F6")]
				[Address(RVA = "0xD1C8C0", Offset = "0xD1B8C0", VA = "0x180D1C8C0")]
				public bool Contains(ControllerType controllerType, int fieldId)
				{
					return default(bool);
				}

				// Token: 0x060030F7 RID: 12535 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030F7")]
				[Address(RVA = "0xD1C9A0", Offset = "0xD1B9A0", VA = "0x180D1C9A0")]
				public void SetFieldLabel(ControllerType controllerType, int index, string label)
				{
				}

				// Token: 0x060030F8 RID: 12536 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030F8")]
				[Address(RVA = "0xD1CAF0", Offset = "0xD1BAF0", VA = "0x180D1CAF0")]
				public void PopulateField(ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
				{
				}

				// Token: 0x060030F9 RID: 12537 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030F9")]
				[Address(RVA = "0xD1CCC0", Offset = "0xD1BCC0", VA = "0x180D1CCC0")]
				public void SetFixedFieldData(ControllerType controllerType, int controllerId)
				{
				}

				// Token: 0x060030FA RID: 12538 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030FA")]
				[Address(RVA = "0xD1CE30", Offset = "0xD1BE30", VA = "0x180D1CE30")]
				public void Initialize()
				{
				}

				// Token: 0x060030FB RID: 12539 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030FB")]
				[Address(RVA = "0xD1D080", Offset = "0xD1C080", VA = "0x180D1D080")]
				public void SetActive(bool state)
				{
				}

				// Token: 0x060030FC RID: 12540 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030FC")]
				[Address(RVA = "0xD1D200", Offset = "0xD1C200", VA = "0x180D1D200")]
				public void ClearLabels()
				{
				}

				// Token: 0x060030FD RID: 12541 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030FD")]
				[Address(RVA = "0xD1D3E0", Offset = "0xD1C3E0", VA = "0x180D1D3E0")]
				public void SetFieldsActive(bool state)
				{
				}

				// Token: 0x04004ED0 RID: 20176
				[Token(Token = "0x4004ED0")]
				[FieldOffset(Offset = "0x10")]
				private ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.FieldSet> fieldSets;

				// Token: 0x04004ED1 RID: 20177
				[Token(Token = "0x4004ED1")]
				[FieldOffset(Offset = "0x18")]
				public ControlMapper.GUILabel label;

				// Token: 0x04004ED2 RID: 20178
				[Token(Token = "0x4004ED2")]
				[FieldOffset(Offset = "0x20")]
				public readonly InputAction action;

				// Token: 0x04004ED3 RID: 20179
				[Token(Token = "0x4004ED3")]
				[FieldOffset(Offset = "0x28")]
				public readonly AxisRange axisRange;

				// Token: 0x04004ED4 RID: 20180
				[Token(Token = "0x4004ED4")]
				[FieldOffset(Offset = "0x30")]
				public readonly ControlMapper.InputActionSet actionSet;
			}

			// Token: 0x0200092A RID: 2346
			[Token(Token = "0x200092A")]
			private class FieldSet
			{
				// Token: 0x060030FE RID: 12542 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030FE")]
				[Address(RVA = "0xD1D600", Offset = "0xD1C600", VA = "0x180D1D600")]
				public FieldSet(GameObject groupContainer)
				{
				}

				// Token: 0x04004ED5 RID: 20181
				[Token(Token = "0x4004ED5")]
				[FieldOffset(Offset = "0x10")]
				public readonly GameObject groupContainer;

				// Token: 0x04004ED6 RID: 20182
				[Token(Token = "0x4004ED6")]
				[FieldOffset(Offset = "0x18")]
				public readonly ControlMapper.IndexedDictionary<int, ControlMapper.GUIInputField> fields;
			}

			// Token: 0x0200092B RID: 2347
			[Token(Token = "0x200092B")]
			private class ActionCategoryEntry
			{
				// Token: 0x060030FF RID: 12543 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60030FF")]
				[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
				public ActionCategoryEntry(int actionCategoryId)
				{
				}

				// Token: 0x06003100 RID: 12544 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003100")]
				[Address(RVA = "0x3ED9D0", Offset = "0x3EC9D0", VA = "0x1803ED9D0")]
				public void SetLabel(ControlMapper.GUILabel label)
				{
				}

				// Token: 0x06003101 RID: 12545 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003101")]
				[Address(RVA = "0xD1D720", Offset = "0xD1C720", VA = "0x180D1D720")]
				public void SetActive(bool state)
				{
				}

				// Token: 0x04004ED7 RID: 20183
				[Token(Token = "0x4004ED7")]
				[FieldOffset(Offset = "0x10")]
				public readonly int actionCategoryId;

				// Token: 0x04004ED8 RID: 20184
				[Token(Token = "0x4004ED8")]
				[FieldOffset(Offset = "0x18")]
				public ControlMapper.GUILabel label;
			}

			// Token: 0x0200092C RID: 2348
			[Token(Token = "0x200092C")]
			private sealed class <GetActionSets>d__18 : IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>, IDisposable
			{
				// Token: 0x06003102 RID: 12546 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003102")]
				[Address(RVA = "0xBD7DE0", Offset = "0xBD6DE0", VA = "0x180BD7DE0")]
				public <GetActionSets>d__18(int <>1__state)
				{
				}

				// Token: 0x06003103 RID: 12547 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003103")]
				[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "7")]
				private void Dispose()
				{
				}

				// Token: 0x06003104 RID: 12548 RVA: 0x00011A60 File Offset: 0x0000FC60
				[Token(Token = "0x6003104")]
				[Address(RVA = "0xD1D740", Offset = "0xD1C740", VA = "0x180D1D740", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000445 RID: 1093
				// (get) Token: 0x06003105 RID: 12549 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x17000445")]
				private ControlMapper.InputActionSet Current
				{
					[Token(Token = "0x6003105")]
					[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "6")]
					get
					{
						return null;
					}
				}

				// Token: 0x06003106 RID: 12550 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003106")]
				[Address(RVA = "0xD1D950", Offset = "0xD1C950", VA = "0x180D1D950", Slot = "10")]
				private void Reset()
				{
				}

				// Token: 0x17000446 RID: 1094
				// (get) Token: 0x06003107 RID: 12551 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x17000446")]
				private object Current
				{
					[Token(Token = "0x6003107")]
					[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "9")]
					get
					{
						return null;
					}
				}

				// Token: 0x06003108 RID: 12552 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x6003108")]
				[Address(RVA = "0xD1D9A0", Offset = "0xD1C9A0", VA = "0x180D1D9A0", Slot = "4")]
				private IEnumerator<ControlMapper.InputActionSet> GetEnumerator()
				{
					return null;
				}

				// Token: 0x06003109 RID: 12553 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x6003109")]
				[Address(RVA = "0xD1D9A0", Offset = "0xD1C9A0", VA = "0x180D1D9A0", Slot = "5")]
				private IEnumerator GetEnumerator()
				{
					return null;
				}

				// Token: 0x04004ED9 RID: 20185
				[Token(Token = "0x4004ED9")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x04004EDA RID: 20186
				[Token(Token = "0x4004EDA")]
				[FieldOffset(Offset = "0x18")]
				private ControlMapper.InputActionSet <>2__current;

				// Token: 0x04004EDB RID: 20187
				[Token(Token = "0x4004EDB")]
				[FieldOffset(Offset = "0x20")]
				private int <>l__initialThreadId;

				// Token: 0x04004EDC RID: 20188
				[Token(Token = "0x4004EDC")]
				[FieldOffset(Offset = "0x28")]
				public ControlMapper.InputGridEntryList <>4__this;

				// Token: 0x04004EDD RID: 20189
				[Token(Token = "0x4004EDD")]
				[FieldOffset(Offset = "0x30")]
				private int mapCategoryId;

				// Token: 0x04004EDE RID: 20190
				[Token(Token = "0x4004EDE")]
				[FieldOffset(Offset = "0x34")]
				public int <>3__mapCategoryId;

				// Token: 0x04004EDF RID: 20191
				[Token(Token = "0x4004EDF")]
				[FieldOffset(Offset = "0x38")]
				private List<ControlMapper.InputGridEntryList.ActionEntry> <list>5__2;

				// Token: 0x04004EE0 RID: 20192
				[Token(Token = "0x4004EE0")]
				[FieldOffset(Offset = "0x40")]
				private int <count>5__3;

				// Token: 0x04004EE1 RID: 20193
				[Token(Token = "0x4004EE1")]
				[FieldOffset(Offset = "0x44")]
				private int <i>5__4;
			}
		}

		// Token: 0x0200092D RID: 2349
		[Token(Token = "0x200092D")]
		private class WindowManager
		{
			// Token: 0x17000447 RID: 1095
			// (get) Token: 0x0600310A RID: 12554 RVA: 0x00011A78 File Offset: 0x0000FC78
			[Token(Token = "0x17000447")]
			public bool isWindowOpen
			{
				[Token(Token = "0x600310A")]
				[Address(RVA = "0xD1DA90", Offset = "0xD1CA90", VA = "0x180D1DA90")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000448 RID: 1096
			// (get) Token: 0x0600310B RID: 12555 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000448")]
			public Window topWindow
			{
				[Token(Token = "0x600310B")]
				[Address(RVA = "0xD1DC50", Offset = "0xD1CC50", VA = "0x180D1DC50")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600310C RID: 12556 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600310C")]
			[Address(RVA = "0xD1DE20", Offset = "0xD1CE20", VA = "0x180D1DE20")]
			public WindowManager(GameObject windowPrefab, GameObject faderPrefab, Transform parent)
			{
			}

			// Token: 0x0600310D RID: 12557 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600310D")]
			[Address(RVA = "0xD1E230", Offset = "0xD1D230", VA = "0x180D1E230")]
			public Window OpenWindow(string name, int width, int height)
			{
				return null;
			}

			// Token: 0x0600310E RID: 12558 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600310E")]
			[Address(RVA = "0xD1E270", Offset = "0xD1D270", VA = "0x180D1E270")]
			public Window OpenWindow(GameObject windowPrefab, string name)
			{
				return null;
			}

			// Token: 0x0600310F RID: 12559 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600310F")]
			[Address(RVA = "0xD1E3F0", Offset = "0xD1D3F0", VA = "0x180D1E3F0")]
			public void CloseTop()
			{
			}

			// Token: 0x06003110 RID: 12560 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003110")]
			[Address(RVA = "0xD1E610", Offset = "0xD1D610", VA = "0x180D1E610")]
			public void CloseWindow(int windowId)
			{
			}

			// Token: 0x06003111 RID: 12561 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003111")]
			[Address(RVA = "0xD1E640", Offset = "0xD1D640", VA = "0x180D1E640")]
			public void CloseWindow(Window window)
			{
			}

			// Token: 0x06003112 RID: 12562 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003112")]
			[Address(RVA = "0xD1EB30", Offset = "0xD1DB30", VA = "0x180D1EB30")]
			public void CloseAll()
			{
			}

			// Token: 0x06003113 RID: 12563 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003113")]
			[Address(RVA = "0xD1ED80", Offset = "0xD1DD80", VA = "0x180D1ED80")]
			public void CancelAll()
			{
			}

			// Token: 0x06003114 RID: 12564 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6003114")]
			[Address(RVA = "0xD1EF70", Offset = "0xD1DF70", VA = "0x180D1EF70")]
			public Window GetWindow(int windowId)
			{
				return null;
			}

			// Token: 0x06003115 RID: 12565 RVA: 0x00011A90 File Offset: 0x0000FC90
			[Token(Token = "0x6003115")]
			[Address(RVA = "0xD1F160", Offset = "0xD1E160", VA = "0x180D1F160")]
			public bool IsFocused(int windowId)
			{
				return default(bool);
			}

			// Token: 0x06003116 RID: 12566 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003116")]
			[Address(RVA = "0xD1F2B0", Offset = "0xD1E2B0", VA = "0x180D1F2B0")]
			public void Focus(int windowId)
			{
			}

			// Token: 0x06003117 RID: 12567 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003117")]
			[Address(RVA = "0xD1F2E0", Offset = "0xD1E2E0", VA = "0x180D1F2E0")]
			public void Focus(Window window)
			{
			}

			// Token: 0x06003118 RID: 12568 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003118")]
			[Address(RVA = "0xD1F400", Offset = "0xD1E400", VA = "0x180D1F400")]
			private void DefocusOtherWindows(int focusedWindowId)
			{
			}

			// Token: 0x06003119 RID: 12569 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003119")]
			[Address(RVA = "0xD1F610", Offset = "0xD1E610", VA = "0x180D1F610")]
			private void UpdateFader()
			{
			}

			// Token: 0x0600311A RID: 12570 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600311A")]
			[Address(RVA = "0xD1F9F0", Offset = "0xD1E9F0", VA = "0x180D1F9F0")]
			private void FocusTopWindow()
			{
			}

			// Token: 0x0600311B RID: 12571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600311B")]
			[Address(RVA = "0xD1FB20", Offset = "0xD1EB20", VA = "0x180D1FB20")]
			private void SetFaderActive(bool state)
			{
			}

			// Token: 0x0600311C RID: 12572 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600311C")]
			[Address(RVA = "0xD1FB90", Offset = "0xD1EB90", VA = "0x180D1FB90")]
			private Window InstantiateWindow(string name, int width, int height)
			{
				return null;
			}

			// Token: 0x0600311D RID: 12573 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600311D")]
			[Address(RVA = "0xD1FF10", Offset = "0xD1EF10", VA = "0x180D1FF10")]
			private Window InstantiateWindow(string name, GameObject windowPrefab)
			{
				return null;
			}

			// Token: 0x0600311E RID: 12574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600311E")]
			[Address(RVA = "0xD202D0", Offset = "0xD1F2D0", VA = "0x180D202D0")]
			private void DestroyWindow(Window window)
			{
			}

			// Token: 0x0600311F RID: 12575 RVA: 0x00011AA8 File Offset: 0x0000FCA8
			[Token(Token = "0x600311F")]
			[Address(RVA = "0xD20430", Offset = "0xD1F430", VA = "0x180D20430")]
			private int GetNewId()
			{
				return 0;
			}

			// Token: 0x06003120 RID: 12576 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003120")]
			[Address(RVA = "0xD20440", Offset = "0xD1F440", VA = "0x180D20440")]
			public void ClearCompletely()
			{
			}

			// Token: 0x04004EE2 RID: 20194
			[Token(Token = "0x4004EE2")]
			[FieldOffset(Offset = "0x10")]
			private List<Window> windows;

			// Token: 0x04004EE3 RID: 20195
			[Token(Token = "0x4004EE3")]
			[FieldOffset(Offset = "0x18")]
			private GameObject windowPrefab;

			// Token: 0x04004EE4 RID: 20196
			[Token(Token = "0x4004EE4")]
			[FieldOffset(Offset = "0x20")]
			private Transform parent;

			// Token: 0x04004EE5 RID: 20197
			[Token(Token = "0x4004EE5")]
			[FieldOffset(Offset = "0x28")]
			private GameObject fader;

			// Token: 0x04004EE6 RID: 20198
			[Token(Token = "0x4004EE6")]
			[FieldOffset(Offset = "0x30")]
			private int idCounter;
		}

		// Token: 0x0200092E RID: 2350
		[Token(Token = "0x200092E")]
		private sealed class <>c__DisplayClass341_0
		{
			// Token: 0x06003121 RID: 12577 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003121")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass341_0()
			{
			}

			// Token: 0x06003122 RID: 12578 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003122")]
			[Address(RVA = "0xD20570", Offset = "0xD1F570", VA = "0x180D20570")]
			internal void <ShowControllerAssignmentConflictWindow>b__0()
			{
			}

			// Token: 0x06003123 RID: 12579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003123")]
			[Address(RVA = "0xD205B0", Offset = "0xD1F5B0", VA = "0x180D205B0")]
			internal void <ShowControllerAssignmentConflictWindow>b__1()
			{
			}

			// Token: 0x04004EE7 RID: 20199
			[Token(Token = "0x4004EE7")]
			[FieldOffset(Offset = "0x10")]
			public ControlMapper <>4__this;

			// Token: 0x04004EE8 RID: 20200
			[Token(Token = "0x4004EE8")]
			[FieldOffset(Offset = "0x18")]
			public Window window;

			// Token: 0x04004EE9 RID: 20201
			[Token(Token = "0x4004EE9")]
			[FieldOffset(Offset = "0x20")]
			public int controllerId;
		}

		// Token: 0x0200092F RID: 2351
		[Token(Token = "0x200092F")]
		private sealed class <>c__DisplayClass342_0
		{
			// Token: 0x06003124 RID: 12580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003124")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass342_0()
			{
			}

			// Token: 0x06003125 RID: 12581 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003125")]
			[Address(RVA = "0xD20570", Offset = "0xD1F570", VA = "0x180D20570")]
			internal void <ShowBeginElementAssignmentReplacementWindow>b__0()
			{
			}

			// Token: 0x06003126 RID: 12582 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003126")]
			[Address(RVA = "0xD20630", Offset = "0xD1F630", VA = "0x180D20630")]
			internal void <ShowBeginElementAssignmentReplacementWindow>b__1()
			{
			}

			// Token: 0x06003127 RID: 12583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003127")]
			[Address(RVA = "0xD20670", Offset = "0xD1F670", VA = "0x180D20670")]
			internal void <ShowBeginElementAssignmentReplacementWindow>b__2()
			{
			}

			// Token: 0x04004EEA RID: 20202
			[Token(Token = "0x4004EEA")]
			[FieldOffset(Offset = "0x10")]
			public ControlMapper <>4__this;

			// Token: 0x04004EEB RID: 20203
			[Token(Token = "0x4004EEB")]
			[FieldOffset(Offset = "0x18")]
			public Window window;

			// Token: 0x04004EEC RID: 20204
			[Token(Token = "0x4004EEC")]
			[FieldOffset(Offset = "0x20")]
			public InputFieldInfo fieldInfo;

			// Token: 0x04004EED RID: 20205
			[Token(Token = "0x4004EED")]
			[FieldOffset(Offset = "0x28")]
			public ControllerMap map;

			// Token: 0x04004EEE RID: 20206
			[Token(Token = "0x4004EEE")]
			[FieldOffset(Offset = "0x30")]
			public ActionElementMap aem;

			// Token: 0x04004EEF RID: 20207
			[Token(Token = "0x4004EEF")]
			[FieldOffset(Offset = "0x38")]
			public string actionName;
		}

		// Token: 0x02000930 RID: 2352
		[Token(Token = "0x2000930")]
		private sealed class <>c__DisplayClass349_0
		{
			// Token: 0x06003128 RID: 12584 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003128")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass349_0()
			{
			}

			// Token: 0x06003129 RID: 12585 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003129")]
			[Address(RVA = "0xD20570", Offset = "0xD1F570", VA = "0x180D20570")]
			internal void <ShowElementAssignmentConflictWindow>b__0()
			{
			}

			// Token: 0x0600312A RID: 12586 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600312A")]
			[Address(RVA = "0xD206E0", Offset = "0xD1F6E0", VA = "0x180D206E0")]
			internal void <ShowElementAssignmentConflictWindow>b__1()
			{
			}

			// Token: 0x0600312B RID: 12587 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600312B")]
			[Address(RVA = "0xD20750", Offset = "0xD1F750", VA = "0x180D20750")]
			internal void <ShowElementAssignmentConflictWindow>b__2()
			{
			}

			// Token: 0x0600312C RID: 12588 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600312C")]
			[Address(RVA = "0xD20810", Offset = "0xD1F810", VA = "0x180D20810")]
			internal void <ShowElementAssignmentConflictWindow>b__3()
			{
			}

			// Token: 0x04004EF0 RID: 20208
			[Token(Token = "0x4004EF0")]
			[FieldOffset(Offset = "0x10")]
			public ControlMapper <>4__this;

			// Token: 0x04004EF1 RID: 20209
			[Token(Token = "0x4004EF1")]
			[FieldOffset(Offset = "0x18")]
			public Window window;

			// Token: 0x04004EF2 RID: 20210
			[Token(Token = "0x4004EF2")]
			[FieldOffset(Offset = "0x20")]
			public ElementAssignment assignment;

			// Token: 0x04004EF3 RID: 20211
			[Token(Token = "0x4004EF3")]
			[FieldOffset(Offset = "0x44")]
			public bool skipOtherPlayers;
		}

		// Token: 0x02000931 RID: 2353
		[Token(Token = "0x2000931")]
		private sealed class <>c__DisplayClass350_0
		{
			// Token: 0x0600312D RID: 12589 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600312D")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass350_0()
			{
			}

			// Token: 0x0600312E RID: 12590 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600312E")]
			[Address(RVA = "0xD20570", Offset = "0xD1F570", VA = "0x180D20570")]
			internal void <ShowMouseAssignmentConflictWindow>b__0()
			{
			}

			// Token: 0x0600312F RID: 12591 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600312F")]
			[Address(RVA = "0xD20880", Offset = "0xD1F880", VA = "0x180D20880")]
			internal void <ShowMouseAssignmentConflictWindow>b__1()
			{
			}

			// Token: 0x04004EF4 RID: 20212
			[Token(Token = "0x4004EF4")]
			[FieldOffset(Offset = "0x10")]
			public ControlMapper <>4__this;

			// Token: 0x04004EF5 RID: 20213
			[Token(Token = "0x4004EF5")]
			[FieldOffset(Offset = "0x18")]
			public Window window;
		}

		// Token: 0x02000932 RID: 2354
		[Token(Token = "0x2000932")]
		private sealed class <>c__DisplayClass403_0
		{
			// Token: 0x06003130 RID: 12592 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003130")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass403_0()
			{
			}

			// Token: 0x06003131 RID: 12593 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003131")]
			[Address(RVA = "0xD20570", Offset = "0xD1F570", VA = "0x180D20570")]
			internal void <OpenModal>b__0()
			{
			}

			// Token: 0x06003132 RID: 12594 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003132")]
			[Address(RVA = "0xD208D0", Offset = "0xD1F8D0", VA = "0x180D208D0")]
			internal void <OpenModal>b__1()
			{
			}

			// Token: 0x04004EF6 RID: 20214
			[Token(Token = "0x4004EF6")]
			[FieldOffset(Offset = "0x10")]
			public ControlMapper <>4__this;

			// Token: 0x04004EF7 RID: 20215
			[Token(Token = "0x4004EF7")]
			[FieldOffset(Offset = "0x18")]
			public Window window;
		}

		// Token: 0x02000933 RID: 2355
		[Token(Token = "0x2000933")]
		private sealed class <ElementAssignmentConflicts>d__411 : IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>, IDisposable
		{
			// Token: 0x06003133 RID: 12595 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003133")]
			[Address(RVA = "0xD20900", Offset = "0xD1F900", VA = "0x180D20900")]
			public <ElementAssignmentConflicts>d__411(int <>1__state)
			{
			}

			// Token: 0x06003134 RID: 12596 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003134")]
			[Address(RVA = "0xD20920", Offset = "0xD1F920", VA = "0x180D20920", Slot = "7")]
			private void Dispose()
			{
			}

			// Token: 0x06003135 RID: 12597 RVA: 0x00011AC0 File Offset: 0x0000FCC0
			[Token(Token = "0x6003135")]
			[Address(RVA = "0xD20B50", Offset = "0xD1FB50", VA = "0x180D20B50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06003136 RID: 12598 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003136")]
			[Address(RVA = "0xD213C0", Offset = "0xD203C0", VA = "0x180D213C0")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x06003137 RID: 12599 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003137")]
			[Address(RVA = "0xD21420", Offset = "0xD20420", VA = "0x180D21420")]
			private void <>m__Finally2()
			{
			}

			// Token: 0x06003138 RID: 12600 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003138")]
			[Address(RVA = "0xD21480", Offset = "0xD20480", VA = "0x180D21480")]
			private void <>m__Finally3()
			{
			}

			// Token: 0x17000449 RID: 1097
			// (get) Token: 0x06003139 RID: 12601 RVA: 0x00011AD8 File Offset: 0x0000FCD8
			[Token(Token = "0x17000449")]
			private ElementAssignmentConflictInfo Current
			{
				[Token(Token = "0x6003139")]
				[Address(RVA = "0xD214E0", Offset = "0xD204E0", VA = "0x180D214E0", Slot = "6")]
				get
				{
					return default(ElementAssignmentConflictInfo);
				}
			}

			// Token: 0x0600313A RID: 12602 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600313A")]
			[Address(RVA = "0xD21510", Offset = "0xD20510", VA = "0x180D21510", Slot = "10")]
			private void Reset()
			{
			}

			// Token: 0x1700044A RID: 1098
			// (get) Token: 0x0600313B RID: 12603 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700044A")]
			private object Current
			{
				[Token(Token = "0x600313B")]
				[Address(RVA = "0xD21560", Offset = "0xD20560", VA = "0x180D21560", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600313C RID: 12604 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600313C")]
			[Address(RVA = "0xD215D0", Offset = "0xD205D0", VA = "0x180D215D0", Slot = "4")]
			private IEnumerator<ElementAssignmentConflictInfo> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600313D RID: 12605 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600313D")]
			[Address(RVA = "0xD215D0", Offset = "0xD205D0", VA = "0x180D215D0", Slot = "5")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04004EF8 RID: 20216
			[Token(Token = "0x4004EF8")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04004EF9 RID: 20217
			[Token(Token = "0x4004EF9")]
			[FieldOffset(Offset = "0x14")]
			private ElementAssignmentConflictInfo <>2__current;

			// Token: 0x04004EFA RID: 20218
			[Token(Token = "0x4004EFA")]
			[FieldOffset(Offset = "0x40")]
			private int <>l__initialThreadId;

			// Token: 0x04004EFB RID: 20219
			[Token(Token = "0x4004EFB")]
			[FieldOffset(Offset = "0x48")]
			private Player player;

			// Token: 0x04004EFC RID: 20220
			[Token(Token = "0x4004EFC")]
			[FieldOffset(Offset = "0x50")]
			public Player <>3__player;

			// Token: 0x04004EFD RID: 20221
			[Token(Token = "0x4004EFD")]
			[FieldOffset(Offset = "0x58")]
			private ControlMapper.InputMapping mapping;

			// Token: 0x04004EFE RID: 20222
			[Token(Token = "0x4004EFE")]
			[FieldOffset(Offset = "0x60")]
			public ControlMapper.InputMapping <>3__mapping;

			// Token: 0x04004EFF RID: 20223
			[Token(Token = "0x4004EFF")]
			[FieldOffset(Offset = "0x68")]
			public ControlMapper <>4__this;

			// Token: 0x04004F00 RID: 20224
			[Token(Token = "0x4004F00")]
			[FieldOffset(Offset = "0x70")]
			private ElementAssignment assignment;

			// Token: 0x04004F01 RID: 20225
			[Token(Token = "0x4004F01")]
			[FieldOffset(Offset = "0x94")]
			public ElementAssignment <>3__assignment;

			// Token: 0x04004F02 RID: 20226
			[Token(Token = "0x4004F02")]
			[FieldOffset(Offset = "0xB8")]
			private bool skipOtherPlayers;

			// Token: 0x04004F03 RID: 20227
			[Token(Token = "0x4004F03")]
			[FieldOffset(Offset = "0xB9")]
			public bool <>3__skipOtherPlayers;

			// Token: 0x04004F04 RID: 20228
			[Token(Token = "0x4004F04")]
			[FieldOffset(Offset = "0xBC")]
			private ElementAssignmentConflictCheck <conflictCheck>5__2;

			// Token: 0x04004F05 RID: 20229
			[Token(Token = "0x4004F05")]
			[FieldOffset(Offset = "0xF8")]
			private IEnumerator<ElementAssignmentConflictInfo> <>7__wrap2;
		}

		// Token: 0x02000934 RID: 2356
		[Token(Token = "0x2000934")]
		private sealed class <>c__DisplayClass456_0
		{
			// Token: 0x0600313E RID: 12606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600313E")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass456_0()
			{
			}

			// Token: 0x0600313F RID: 12607 RVA: 0x00011AF0 File Offset: 0x0000FCF0
			[Token(Token = "0x600313F")]
			[Address(RVA = "0xD217A0", Offset = "0xD207A0", VA = "0x180D217A0")]
			internal bool <ShowSwapButton>b__0(ElementAssignmentConflictInfo x)
			{
				return default(bool);
			}

			// Token: 0x04004F06 RID: 20230
			[Token(Token = "0x4004F06")]
			[FieldOffset(Offset = "0x10")]
			public ActionElementMap aem;
		}
	}
}
