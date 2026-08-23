using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Components;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x02000908 RID: 2312
	[Token(Token = "0x2000908")]
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
	{
		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E4A RID: 11850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000387")]
		public InputManager_Base RewiredInputManager
		{
			[Token(Token = "0x6002E49")]
			[Address(RVA = "0xCE9E40", Offset = "0xCE8E40", VA = "0x180CE9E40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E4A")]
			[Address(RVA = "0xCE9E50", Offset = "0xCE8E50", VA = "0x180CE9E50")]
			set
			{
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x00010C80 File Offset: 0x0000EE80
		// (set) Token: 0x06002E4C RID: 11852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000388")]
		public bool UseAllRewiredGamePlayers
		{
			[Token(Token = "0x6002E4B")]
			[Address(RVA = "0xCE9EB0", Offset = "0xCE8EB0", VA = "0x180CE9EB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E4C")]
			[Address(RVA = "0xCE9EC0", Offset = "0xCE8EC0", VA = "0x180CE9EC0")]
			set
			{
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x00010C98 File Offset: 0x0000EE98
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000389")]
		public bool UseRewiredSystemPlayer
		{
			[Token(Token = "0x6002E4D")]
			[Address(RVA = "0xCE9EE0", Offset = "0xCE8EE0", VA = "0x180CE9EE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E4E")]
			[Address(RVA = "0xCE9EF0", Offset = "0xCE8EF0", VA = "0x180CE9EF0")]
			set
			{
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E50 RID: 11856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038A")]
		public int[] RewiredPlayerIds
		{
			[Token(Token = "0x6002E4F")]
			[Address(RVA = "0xCE9F10", Offset = "0xCE8F10", VA = "0x180CE9F10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E50")]
			[Address(RVA = "0xCE9F90", Offset = "0xCE8F90", VA = "0x180CE9F90")]
			set
			{
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x00010CB0 File Offset: 0x0000EEB0
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038B")]
		public bool UsePlayingPlayersOnly
		{
			[Token(Token = "0x6002E51")]
			[Address(RVA = "0xCEA090", Offset = "0xCE9090", VA = "0x180CEA090")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E52")]
			[Address(RVA = "0xCEA0A0", Offset = "0xCE90A0", VA = "0x180CEA0A0")]
			set
			{
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038C")]
		public List<PlayerMouse> PlayerMice
		{
			[Token(Token = "0x6002E53")]
			[Address(RVA = "0xCEA0B0", Offset = "0xCE90B0", VA = "0x180CEA0B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E54")]
			[Address(RVA = "0xCEA130", Offset = "0xCE9130", VA = "0x180CEA130")]
			set
			{
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		// (set) Token: 0x06002E56 RID: 11862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038D")]
		public bool MoveOneElementPerAxisPress
		{
			[Token(Token = "0x6002E55")]
			[Address(RVA = "0xCEA2C0", Offset = "0xCE92C0", VA = "0x180CEA2C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E56")]
			[Address(RVA = "0xCEA2D0", Offset = "0xCE92D0", VA = "0x180CEA2D0")]
			set
			{
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		// (set) Token: 0x06002E58 RID: 11864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038E")]
		public bool allowMouseInput
		{
			[Token(Token = "0x6002E57")]
			[Address(RVA = "0xCEA2E0", Offset = "0xCE92E0", VA = "0x180CEA2E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E58")]
			[Address(RVA = "0xCEA2F0", Offset = "0xCE92F0", VA = "0x180CEA2F0")]
			set
			{
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06002E59 RID: 11865 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		// (set) Token: 0x06002E5A RID: 11866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038F")]
		public bool allowMouseInputIfTouchSupported
		{
			[Token(Token = "0x6002E59")]
			[Address(RVA = "0xCEA300", Offset = "0xCE9300", VA = "0x180CEA300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E5A")]
			[Address(RVA = "0xCEA310", Offset = "0xCE9310", VA = "0x180CEA310")]
			set
			{
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x00010D10 File Offset: 0x0000EF10
		// (set) Token: 0x06002E5C RID: 11868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000390")]
		public bool allowTouchInput
		{
			[Token(Token = "0x6002E5B")]
			[Address(RVA = "0xCEA320", Offset = "0xCE9320", VA = "0x180CEA320")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E5C")]
			[Address(RVA = "0xCEA330", Offset = "0xCE9330", VA = "0x180CEA330")]
			set
			{
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06002E5D RID: 11869 RVA: 0x00010D28 File Offset: 0x0000EF28
		// (set) Token: 0x06002E5E RID: 11870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000391")]
		public bool deselectIfBackgroundClicked
		{
			[Token(Token = "0x6002E5D")]
			[Address(RVA = "0xCEA340", Offset = "0xCE9340", VA = "0x180CEA340")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E5E")]
			[Address(RVA = "0xCEA350", Offset = "0xCE9350", VA = "0x180CEA350")]
			set
			{
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06002E5F RID: 11871 RVA: 0x00010D40 File Offset: 0x0000EF40
		// (set) Token: 0x06002E60 RID: 11872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000392")]
		private bool deselectBeforeSelecting
		{
			[Token(Token = "0x6002E5F")]
			[Address(RVA = "0xCEA360", Offset = "0xCE9360", VA = "0x180CEA360")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E60")]
			[Address(RVA = "0xCEA370", Offset = "0xCE9370", VA = "0x180CEA370")]
			set
			{
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x00010D58 File Offset: 0x0000EF58
		// (set) Token: 0x06002E62 RID: 11874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000393")]
		public bool SetActionsById
		{
			[Token(Token = "0x6002E61")]
			[Address(RVA = "0xCEA380", Offset = "0xCE9380", VA = "0x180CEA380")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E62")]
			[Address(RVA = "0xCEA390", Offset = "0xCE9390", VA = "0x180CEA390")]
			set
			{
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06002E63 RID: 11875 RVA: 0x00010D70 File Offset: 0x0000EF70
		// (set) Token: 0x06002E64 RID: 11876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000394")]
		public int HorizontalActionId
		{
			[Token(Token = "0x6002E63")]
			[Address(RVA = "0xCEA3B0", Offset = "0xCE93B0", VA = "0x180CEA3B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002E64")]
			[Address(RVA = "0xCEA3C0", Offset = "0xCE93C0", VA = "0x180CEA3C0")]
			set
			{
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x00010D88 File Offset: 0x0000EF88
		// (set) Token: 0x06002E66 RID: 11878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000395")]
		public int VerticalActionId
		{
			[Token(Token = "0x6002E65")]
			[Address(RVA = "0xCEA530", Offset = "0xCE9530", VA = "0x180CEA530")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002E66")]
			[Address(RVA = "0xCEA540", Offset = "0xCE9540", VA = "0x180CEA540")]
			set
			{
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		// (set) Token: 0x06002E68 RID: 11880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000396")]
		public int SubmitActionId
		{
			[Token(Token = "0x6002E67")]
			[Address(RVA = "0xCEA6B0", Offset = "0xCE96B0", VA = "0x180CEA6B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002E68")]
			[Address(RVA = "0xCEA6C0", Offset = "0xCE96C0", VA = "0x180CEA6C0")]
			set
			{
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06002E69 RID: 11881 RVA: 0x00010DB8 File Offset: 0x0000EFB8
		// (set) Token: 0x06002E6A RID: 11882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000397")]
		public int CancelActionId
		{
			[Token(Token = "0x6002E69")]
			[Address(RVA = "0xCEA830", Offset = "0xCE9830", VA = "0x180CEA830")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002E6A")]
			[Address(RVA = "0xCEA840", Offset = "0xCE9840", VA = "0x180CEA840")]
			set
			{
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06002E6B RID: 11883 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		[Token(Token = "0x17000398")]
		protected override bool isMouseSupported
		{
			[Token(Token = "0x6002E6B")]
			[Address(RVA = "0xCEA9B0", Offset = "0xCE99B0", VA = "0x180CEA9B0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06002E6C RID: 11884 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		[Token(Token = "0x17000399")]
		private bool isTouchAllowed
		{
			[Token(Token = "0x6002E6C")]
			[Address(RVA = "0xCEA320", Offset = "0xCE9320", VA = "0x180CEA320")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06002E6D RID: 11885 RVA: 0x00010E00 File Offset: 0x0000F000
		// (set) Token: 0x06002E6E RID: 11886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039A")]
		public bool allowActivationOnMobileDevice
		{
			[Token(Token = "0x6002E6D")]
			[Address(RVA = "0xCEAB20", Offset = "0xCE9B20", VA = "0x180CEAB20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E6E")]
			[Address(RVA = "0xCEAB30", Offset = "0xCE9B30", VA = "0x180CEAB30")]
			set
			{
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06002E6F RID: 11887 RVA: 0x00010E18 File Offset: 0x0000F018
		// (set) Token: 0x06002E70 RID: 11888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039B")]
		public bool forceModuleActive
		{
			[Token(Token = "0x6002E6F")]
			[Address(RVA = "0xCEAB20", Offset = "0xCE9B20", VA = "0x180CEAB20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E70")]
			[Address(RVA = "0xCEAB30", Offset = "0xCE9B30", VA = "0x180CEAB30")]
			set
			{
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06002E71 RID: 11889 RVA: 0x00010E30 File Offset: 0x0000F030
		// (set) Token: 0x06002E72 RID: 11890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039C")]
		public float inputActionsPerSecond
		{
			[Token(Token = "0x6002E71")]
			[Address(RVA = "0xCEAB40", Offset = "0xCE9B40", VA = "0x180CEAB40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002E72")]
			[Address(RVA = "0xCEAB50", Offset = "0xCE9B50", VA = "0x180CEAB50")]
			set
			{
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06002E73 RID: 11891 RVA: 0x00010E48 File Offset: 0x0000F048
		// (set) Token: 0x06002E74 RID: 11892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039D")]
		public float repeatDelay
		{
			[Token(Token = "0x6002E73")]
			[Address(RVA = "0xCEAB60", Offset = "0xCE9B60", VA = "0x180CEAB60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002E74")]
			[Address(RVA = "0xCEAB70", Offset = "0xCE9B70", VA = "0x180CEAB70")]
			set
			{
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06002E75 RID: 11893 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E76 RID: 11894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039E")]
		public string horizontalAxis
		{
			[Token(Token = "0x6002E75")]
			[Address(RVA = "0xCEAB80", Offset = "0xCE9B80", VA = "0x180CEAB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E76")]
			[Address(RVA = "0xCEAB90", Offset = "0xCE9B90", VA = "0x180CEAB90")]
			set
			{
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E78 RID: 11896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039F")]
		public string verticalAxis
		{
			[Token(Token = "0x6002E77")]
			[Address(RVA = "0xCEACC0", Offset = "0xCE9CC0", VA = "0x180CEACC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E78")]
			[Address(RVA = "0xCEACD0", Offset = "0xCE9CD0", VA = "0x180CEACD0")]
			set
			{
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06002E79 RID: 11897 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E7A RID: 11898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A0")]
		public string submitButton
		{
			[Token(Token = "0x6002E79")]
			[Address(RVA = "0xCEAE00", Offset = "0xCE9E00", VA = "0x180CEAE00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E7A")]
			[Address(RVA = "0xCEAE10", Offset = "0xCE9E10", VA = "0x180CEAE10")]
			set
			{
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06002E7B RID: 11899 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E7C RID: 11900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A1")]
		public string cancelButton
		{
			[Token(Token = "0x6002E7B")]
			[Address(RVA = "0xCEAF40", Offset = "0xCE9F40", VA = "0x180CEAF40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E7C")]
			[Address(RVA = "0xCEAF50", Offset = "0xCE9F50", VA = "0x180CEAF50")]
			set
			{
			}
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E7D")]
		[Address(RVA = "0xCEB080", Offset = "0xCEA080", VA = "0x180CEB080")]
		private RewiredStandaloneInputModule()
		{
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E7E")]
		[Address(RVA = "0xCEB3E0", Offset = "0xCEA3E0", VA = "0x180CEB3E0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E7F")]
		[Address(RVA = "0xCEB610", Offset = "0xCEA610", VA = "0x180CEB610", Slot = "24")]
		public override void UpdateModule()
		{
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x00010E60 File Offset: 0x0000F060
		[Token(Token = "0x6002E80")]
		[Address(RVA = "0x5221C0", Offset = "0x5211C0", VA = "0x1805221C0", Slot = "25")]
		public override bool IsModuleSupported()
		{
			return default(bool);
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x00010E78 File Offset: 0x0000F078
		[Token(Token = "0x6002E81")]
		[Address(RVA = "0xCEB6E0", Offset = "0xCEA6E0", VA = "0x180CEB6E0", Slot = "21")]
		public override bool ShouldActivateModule()
		{
			return default(bool);
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E82")]
		[Address(RVA = "0xCEBCF0", Offset = "0xCEACF0", VA = "0x180CEBCF0", Slot = "23")]
		public override void ActivateModule()
		{
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E83")]
		[Address(RVA = "0xCEBE70", Offset = "0xCEAE70", VA = "0x180CEBE70", Slot = "22")]
		public override void DeactivateModule()
		{
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E84")]
		[Address(RVA = "0xCEBE80", Offset = "0xCEAE80", VA = "0x180CEBE80", Slot = "17")]
		public override void Process()
		{
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x00010E90 File Offset: 0x0000F090
		[Token(Token = "0x6002E85")]
		[Address(RVA = "0xCEC2F0", Offset = "0xCEB2F0", VA = "0x180CEC2F0")]
		private bool ProcessTouchEvents()
		{
			return default(bool);
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E86")]
		[Address(RVA = "0xCEC620", Offset = "0xCEB620", VA = "0x180CEC620")]
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x00010EA8 File Offset: 0x0000F0A8
		[Token(Token = "0x6002E87")]
		[Address(RVA = "0xCED520", Offset = "0xCEC520", VA = "0x180CED520")]
		private bool SendSubmitEventToSelectedObject()
		{
			return default(bool);
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		[Token(Token = "0x6002E88")]
		[Address(RVA = "0xCED840", Offset = "0xCEC840", VA = "0x180CED840")]
		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		[Token(Token = "0x6002E89")]
		[Address(RVA = "0xCEDBE0", Offset = "0xCECBE0", VA = "0x180CEDBE0")]
		private bool SendMoveEventToSelectedObject()
		{
			return default(bool);
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E8A")]
		[Address(RVA = "0xCEDF40", Offset = "0xCECF40", VA = "0x180CEDF40")]
		private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
		{
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E8B")]
		[Address(RVA = "0xCEE100", Offset = "0xCED100", VA = "0x180CEE100")]
		private void ProcessMouseEvents()
		{
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E8C")]
		[Address(RVA = "0xCEE260", Offset = "0xCED260", VA = "0x180CEE260")]
		private void ProcessMouseEvent(int playerId, int pointerIndex)
		{
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x00010EF0 File Offset: 0x0000F0F0
		[Token(Token = "0x6002E8D")]
		[Address(RVA = "0xCEE680", Offset = "0xCED680", VA = "0x180CEE680")]
		private bool SendUpdateEventToSelectedObject()
		{
			return default(bool);
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E8E")]
		[Address(RVA = "0xCEE840", Offset = "0xCED840", VA = "0x180CEE840")]
		private void ProcessMousePress(RewiredPointerInputModule.MouseButtonEventData data)
		{
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E8F")]
		[Address(RVA = "0xCEF450", Offset = "0xCEE450", VA = "0x180CEF450")]
		private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E90")]
		[Address(RVA = "0xCEF920", Offset = "0xCEE920", VA = "0x180CEF920")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x00010F08 File Offset: 0x0000F108
		[Token(Token = "0x6002E91")]
		[Address(RVA = "0xCEF930", Offset = "0xCEE930", VA = "0x180CEF930")]
		private bool ShouldIgnoreEventsOnNoFocus()
		{
			return default(bool);
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E92")]
		[Address(RVA = "0xCEFA80", Offset = "0xCEEA80", VA = "0x180CEFA80", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x00010F20 File Offset: 0x0000F120
		[Token(Token = "0x6002E93")]
		[Address(RVA = "0xCEFBC0", Offset = "0xCEEBC0", VA = "0x180CEFBC0", Slot = "28")]
		protected override bool IsDefaultPlayer(int playerId)
		{
			return default(bool);
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E94")]
		[Address(RVA = "0xCEFD60", Offset = "0xCEED60", VA = "0x180CEFD60")]
		private void InitializeRewired()
		{
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E95")]
		[Address(RVA = "0xCF00D0", Offset = "0xCEF0D0", VA = "0x180CF00D0")]
		private void SetupRewiredVars()
		{
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E96")]
		[Address(RVA = "0xCF0880", Offset = "0xCEF880", VA = "0x180CF0880")]
		private void SetUpRewiredPlayerMice()
		{
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E97")]
		[Address(RVA = "0xCF0A30", Offset = "0xCEFA30", VA = "0x180CF0A30")]
		private void SetUpRewiredActions()
		{
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x00010F38 File Offset: 0x0000F138
		[Token(Token = "0x6002E98")]
		[Address(RVA = "0xCF0EB0", Offset = "0xCEFEB0", VA = "0x180CF0EB0")]
		private bool GetButton(Player player, int actionId)
		{
			return default(bool);
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x00010F50 File Offset: 0x0000F150
		[Token(Token = "0x6002E99")]
		[Address(RVA = "0xCF0EF0", Offset = "0xCEFEF0", VA = "0x180CF0EF0")]
		private bool GetButtonDown(Player player, int actionId)
		{
			return default(bool);
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x00010F68 File Offset: 0x0000F168
		[Token(Token = "0x6002E9A")]
		[Address(RVA = "0xCF0F30", Offset = "0xCEFF30", VA = "0x180CF0F30")]
		private bool GetNegativeButton(Player player, int actionId)
		{
			return default(bool);
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x00010F80 File Offset: 0x0000F180
		[Token(Token = "0x6002E9B")]
		[Address(RVA = "0xCF0F70", Offset = "0xCEFF70", VA = "0x180CF0F70")]
		private bool GetNegativeButtonDown(Player player, int actionId)
		{
			return default(bool);
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00010F98 File Offset: 0x0000F198
		[Token(Token = "0x6002E9C")]
		[Address(RVA = "0xCF0FB0", Offset = "0xCEFFB0", VA = "0x180CF0FB0")]
		private float GetAxis(Player player, int actionId)
		{
			return 0f;
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E9D")]
		[Address(RVA = "0xCF0FF0", Offset = "0xCEFFF0", VA = "0x180CF0FF0")]
		private void CheckEditorRecompile()
		{
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E9E")]
		[Address(RVA = "0xCF1060", Offset = "0xCF0060", VA = "0x180CF1060")]
		private void OnEditorRecompile()
		{
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E9F")]
		[Address(RVA = "0xCF1070", Offset = "0xCF0070", VA = "0x180CF1070")]
		private void ClearRewiredVars()
		{
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		[Token(Token = "0x6002EA0")]
		[Address(RVA = "0xCF1100", Offset = "0xCF0100", VA = "0x180CF1100")]
		private bool DidAnyMouseMove()
		{
			return default(bool);
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x00010FC8 File Offset: 0x0000F1C8
		[Token(Token = "0x6002EA1")]
		[Address(RVA = "0xCF12B0", Offset = "0xCF02B0", VA = "0x180CF12B0")]
		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
		{
			return default(bool);
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA2")]
		[Address(RVA = "0xCF1440", Offset = "0xCF0440", VA = "0x180CF1440")]
		private void OnRewiredInitialized()
		{
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA3")]
		[Address(RVA = "0xCF1450", Offset = "0xCF0450", VA = "0x180CF1450")]
		private void OnRewiredShutDown()
		{
		}

		// Token: 0x04004D90 RID: 19856
		[Token(Token = "0x4004D90")]
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";

		// Token: 0x04004D91 RID: 19857
		[Token(Token = "0x4004D91")]
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";

		// Token: 0x04004D92 RID: 19858
		[Token(Token = "0x4004D92")]
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit";

		// Token: 0x04004D93 RID: 19859
		[Token(Token = "0x4004D93")]
		private const string DEFAULT_ACTION_CANCEL = "UICancel";

		// Token: 0x04004D94 RID: 19860
		[Token(Token = "0x4004D94")]
		[FieldOffset(Offset = "0x78")]
		private InputManager_Base rewiredInputManager;

		// Token: 0x04004D95 RID: 19861
		[Token(Token = "0x4004D95")]
		[FieldOffset(Offset = "0x80")]
		private bool useAllRewiredGamePlayers;

		// Token: 0x04004D96 RID: 19862
		[Token(Token = "0x4004D96")]
		[FieldOffset(Offset = "0x81")]
		private bool useRewiredSystemPlayer;

		// Token: 0x04004D97 RID: 19863
		[Token(Token = "0x4004D97")]
		[FieldOffset(Offset = "0x88")]
		private int[] rewiredPlayerIds;

		// Token: 0x04004D98 RID: 19864
		[Token(Token = "0x4004D98")]
		[FieldOffset(Offset = "0x90")]
		private bool usePlayingPlayersOnly;

		// Token: 0x04004D99 RID: 19865
		[Token(Token = "0x4004D99")]
		[FieldOffset(Offset = "0x98")]
		private List<PlayerMouse> playerMice;

		// Token: 0x04004D9A RID: 19866
		[Token(Token = "0x4004D9A")]
		[FieldOffset(Offset = "0xA0")]
		private bool moveOneElementPerAxisPress;

		// Token: 0x04004D9B RID: 19867
		[Token(Token = "0x4004D9B")]
		[FieldOffset(Offset = "0xA1")]
		private bool setActionsById;

		// Token: 0x04004D9C RID: 19868
		[Token(Token = "0x4004D9C")]
		[FieldOffset(Offset = "0xA4")]
		private int horizontalActionId;

		// Token: 0x04004D9D RID: 19869
		[Token(Token = "0x4004D9D")]
		[FieldOffset(Offset = "0xA8")]
		private int verticalActionId;

		// Token: 0x04004D9E RID: 19870
		[Token(Token = "0x4004D9E")]
		[FieldOffset(Offset = "0xAC")]
		private int submitActionId;

		// Token: 0x04004D9F RID: 19871
		[Token(Token = "0x4004D9F")]
		[FieldOffset(Offset = "0xB0")]
		private int cancelActionId;

		// Token: 0x04004DA0 RID: 19872
		[Token(Token = "0x4004DA0")]
		[FieldOffset(Offset = "0xB8")]
		private string m_HorizontalAxis;

		// Token: 0x04004DA1 RID: 19873
		[Token(Token = "0x4004DA1")]
		[FieldOffset(Offset = "0xC0")]
		private string m_VerticalAxis;

		// Token: 0x04004DA2 RID: 19874
		[Token(Token = "0x4004DA2")]
		[FieldOffset(Offset = "0xC8")]
		private string m_SubmitButton;

		// Token: 0x04004DA3 RID: 19875
		[Token(Token = "0x4004DA3")]
		[FieldOffset(Offset = "0xD0")]
		private string m_CancelButton;

		// Token: 0x04004DA4 RID: 19876
		[Token(Token = "0x4004DA4")]
		[FieldOffset(Offset = "0xD8")]
		private float m_InputActionsPerSecond;

		// Token: 0x04004DA5 RID: 19877
		[Token(Token = "0x4004DA5")]
		[FieldOffset(Offset = "0xDC")]
		private float m_RepeatDelay;

		// Token: 0x04004DA6 RID: 19878
		[Token(Token = "0x4004DA6")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_allowMouseInput;

		// Token: 0x04004DA7 RID: 19879
		[Token(Token = "0x4004DA7")]
		[FieldOffset(Offset = "0xE1")]
		private bool m_allowMouseInputIfTouchSupported;

		// Token: 0x04004DA8 RID: 19880
		[Token(Token = "0x4004DA8")]
		[FieldOffset(Offset = "0xE2")]
		private bool m_allowTouchInput;

		// Token: 0x04004DA9 RID: 19881
		[Token(Token = "0x4004DA9")]
		[FieldOffset(Offset = "0xE3")]
		private bool m_deselectIfBackgroundClicked;

		// Token: 0x04004DAA RID: 19882
		[Token(Token = "0x4004DAA")]
		[FieldOffset(Offset = "0xE4")]
		private bool m_deselectBeforeSelecting;

		// Token: 0x04004DAB RID: 19883
		[Token(Token = "0x4004DAB")]
		[FieldOffset(Offset = "0xE5")]
		private bool m_ForceModuleActive;

		// Token: 0x04004DAC RID: 19884
		[Token(Token = "0x4004DAC")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		private int[] playerIds;

		// Token: 0x04004DAD RID: 19885
		[Token(Token = "0x4004DAD")]
		[FieldOffset(Offset = "0xF0")]
		private bool recompiling;

		// Token: 0x04004DAE RID: 19886
		[Token(Token = "0x4004DAE")]
		[FieldOffset(Offset = "0xF1")]
		[NonSerialized]
		private bool isTouchSupported;

		// Token: 0x04004DAF RID: 19887
		[Token(Token = "0x4004DAF")]
		[FieldOffset(Offset = "0xF8")]
		[NonSerialized]
		private double m_PrevActionTime;

		// Token: 0x04004DB0 RID: 19888
		[Token(Token = "0x4004DB0")]
		[FieldOffset(Offset = "0x100")]
		[NonSerialized]
		private Vector2 m_LastMoveVector;

		// Token: 0x04004DB1 RID: 19889
		[Token(Token = "0x4004DB1")]
		[FieldOffset(Offset = "0x108")]
		[NonSerialized]
		private int m_ConsecutiveMoveCount;

		// Token: 0x04004DB2 RID: 19890
		[Token(Token = "0x4004DB2")]
		[FieldOffset(Offset = "0x10C")]
		[NonSerialized]
		private bool m_HasFocus;

		// Token: 0x02000909 RID: 2313
		[Token(Token = "0x2000909")]
		[Serializable]
		public class PlayerSetting
		{
			// Token: 0x06002EA4 RID: 11940 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002EA4")]
			[Address(RVA = "0xCF1460", Offset = "0xCF0460", VA = "0x180CF1460")]
			public PlayerSetting()
			{
			}

			// Token: 0x06002EA5 RID: 11941 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002EA5")]
			[Address(RVA = "0xCF1530", Offset = "0xCF0530", VA = "0x180CF1530")]
			private PlayerSetting(RewiredStandaloneInputModule.PlayerSetting other)
			{
			}

			// Token: 0x06002EA6 RID: 11942 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6002EA6")]
			[Address(RVA = "0xCF1840", Offset = "0xCF0840", VA = "0x180CF1840")]
			public RewiredStandaloneInputModule.PlayerSetting Clone()
			{
				return null;
			}

			// Token: 0x04004DB3 RID: 19891
			[Token(Token = "0x4004DB3")]
			[FieldOffset(Offset = "0x10")]
			public int playerId;

			// Token: 0x04004DB4 RID: 19892
			[Token(Token = "0x4004DB4")]
			[FieldOffset(Offset = "0x18")]
			public List<PlayerMouse> playerMice;
		}
	}
}
