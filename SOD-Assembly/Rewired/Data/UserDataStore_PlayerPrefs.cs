using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Rewired.Data
{
	// Token: 0x020008F6 RID: 2294
	[Token(Token = "0x20008F6")]
	public class UserDataStore_PlayerPrefs : UserDataStore
	{
		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06002D8B RID: 11659 RVA: 0x00010620 File Offset: 0x0000E820
		// (set) Token: 0x06002D8C RID: 11660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000360")]
		public bool IsEnabled
		{
			[Token(Token = "0x6002D8B")]
			[Address(RVA = "0x409BC0", Offset = "0x408BC0", VA = "0x180409BC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002D8C")]
			[Address(RVA = "0x409BD0", Offset = "0x408BD0", VA = "0x180409BD0")]
			set
			{
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06002D8D RID: 11661 RVA: 0x00010638 File Offset: 0x0000E838
		// (set) Token: 0x06002D8E RID: 11662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000361")]
		public bool LoadDataOnStart
		{
			[Token(Token = "0x6002D8D")]
			[Address(RVA = "0xCDB320", Offset = "0xCDA320", VA = "0x180CDB320")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002D8E")]
			[Address(RVA = "0xCDB330", Offset = "0xCDA330", VA = "0x180CDB330")]
			set
			{
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06002D8F RID: 11663 RVA: 0x00010650 File Offset: 0x0000E850
		// (set) Token: 0x06002D90 RID: 11664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000362")]
		public bool LoadJoystickAssignments
		{
			[Token(Token = "0x6002D8F")]
			[Address(RVA = "0xCDB340", Offset = "0xCDA340", VA = "0x180CDB340")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002D90")]
			[Address(RVA = "0xCDB350", Offset = "0xCDA350", VA = "0x180CDB350")]
			set
			{
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06002D91 RID: 11665 RVA: 0x00010668 File Offset: 0x0000E868
		// (set) Token: 0x06002D92 RID: 11666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000363")]
		public bool LoadKeyboardAssignments
		{
			[Token(Token = "0x6002D91")]
			[Address(RVA = "0xCDB360", Offset = "0xCDA360", VA = "0x180CDB360")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002D92")]
			[Address(RVA = "0xCDB370", Offset = "0xCDA370", VA = "0x180CDB370")]
			set
			{
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06002D93 RID: 11667 RVA: 0x00010680 File Offset: 0x0000E880
		// (set) Token: 0x06002D94 RID: 11668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000364")]
		public bool LoadMouseAssignments
		{
			[Token(Token = "0x6002D93")]
			[Address(RVA = "0x409A70", Offset = "0x408A70", VA = "0x180409A70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002D94")]
			[Address(RVA = "0x409A80", Offset = "0x408A80", VA = "0x180409A80")]
			set
			{
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06002D95 RID: 11669 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002D96 RID: 11670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000365")]
		public string PlayerPrefsKeyPrefix
		{
			[Token(Token = "0x6002D95")]
			[Address(RVA = "0x3EDA30", Offset = "0x3ECA30", VA = "0x1803EDA30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D96")]
			[Address(RVA = "0x3EDA40", Offset = "0x3ECA40", VA = "0x1803EDA40")]
			set
			{
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06002D97 RID: 11671 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000366")]
		private string playerPrefsKey_controllerAssignments
		{
			[Token(Token = "0x6002D97")]
			[Address(RVA = "0xCDB380", Offset = "0xCDA380", VA = "0x180CDB380")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x00010698 File Offset: 0x0000E898
		[Token(Token = "0x17000367")]
		private bool loadControllerAssignments
		{
			[Token(Token = "0x6002D98")]
			[Address(RVA = "0xCDB420", Offset = "0xCDA420", VA = "0x180CDB420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000368")]
		private List<int> allActionIds
		{
			[Token(Token = "0x6002D99")]
			[Address(RVA = "0xCDB440", Offset = "0xCDA440", VA = "0x180CDB440")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000369")]
		private string allActionIdsString
		{
			[Token(Token = "0x6002D9A")]
			[Address(RVA = "0xCDB750", Offset = "0xCDA750", VA = "0x180CDB750")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D9B")]
		[Address(RVA = "0xCDB8D0", Offset = "0xCDA8D0", VA = "0x180CDB8D0", Slot = "21")]
		public override void Save()
		{
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D9C")]
		[Address(RVA = "0xCDB950", Offset = "0xCDA950", VA = "0x180CDB950", Slot = "22")]
		public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D9D")]
		[Address(RVA = "0xCDBA90", Offset = "0xCDAA90", VA = "0x180CDBA90", Slot = "23")]
		public override void SaveControllerData(ControllerType controllerType, int controllerId)
		{
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D9E")]
		[Address(RVA = "0xCDBB80", Offset = "0xCDAB80", VA = "0x180CDBB80", Slot = "24")]
		public override void SavePlayerData(int playerId)
		{
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D9F")]
		[Address(RVA = "0xCDBCB0", Offset = "0xCDACB0", VA = "0x180CDBCB0", Slot = "25")]
		public override void SaveInputBehavior(int playerId, int behaviorId)
		{
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA0")]
		[Address(RVA = "0xCDBE60", Offset = "0xCDAE60", VA = "0x180CDBE60", Slot = "16")]
		public override void Load()
		{
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA1")]
		[Address(RVA = "0xCDBEE0", Offset = "0xCDAEE0", VA = "0x180CDBEE0", Slot = "17")]
		public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA2")]
		[Address(RVA = "0xCDBFB0", Offset = "0xCDAFB0", VA = "0x180CDBFB0", Slot = "18")]
		public override void LoadControllerData(ControllerType controllerType, int controllerId)
		{
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA3")]
		[Address(RVA = "0xCDC060", Offset = "0xCDB060", VA = "0x180CDC060", Slot = "19")]
		public override void LoadPlayerData(int playerId)
		{
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA4")]
		[Address(RVA = "0xCDC150", Offset = "0xCDB150", VA = "0x180CDC150", Slot = "20")]
		public override void LoadInputBehavior(int playerId, int behaviorId)
		{
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA5")]
		[Address(RVA = "0xCDC2A0", Offset = "0xCDB2A0", VA = "0x180CDC2A0", Slot = "28")]
		protected override void OnInitialize()
		{
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA6")]
		[Address(RVA = "0xCDC350", Offset = "0xCDB350", VA = "0x180CDC350", Slot = "29")]
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA7")]
		[Address(RVA = "0xCDC4B0", Offset = "0xCDB4B0", VA = "0x180CDC4B0", Slot = "32")]
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA8")]
		[Address(RVA = "0xCDC4E0", Offset = "0xCDB4E0", VA = "0x180CDC4E0", Slot = "30")]
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA9")]
		[Address(RVA = "0xCDC560", Offset = "0xCDB560", VA = "0x180CDC560", Slot = "26")]
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
		{
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DAA")]
		[Address(RVA = "0xCDC600", Offset = "0xCDB600", VA = "0x180CDC600", Slot = "27")]
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x000106B0 File Offset: 0x0000E8B0
		[Token(Token = "0x6002DAB")]
		[Address(RVA = "0xCDC6E0", Offset = "0xCDB6E0", VA = "0x180CDC6E0")]
		private int LoadAll()
		{
			return 0;
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x000106C8 File Offset: 0x0000E8C8
		[Token(Token = "0x6002DAC")]
		[Address(RVA = "0xCDC8F0", Offset = "0xCDB8F0", VA = "0x180CDC8F0")]
		private int LoadPlayerDataNow(int playerId)
		{
			return 0;
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x000106E0 File Offset: 0x0000E8E0
		[Token(Token = "0x6002DAD")]
		[Address(RVA = "0xCDC970", Offset = "0xCDB970", VA = "0x180CDC970")]
		private int LoadPlayerDataNow(Player player)
		{
			return 0;
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x000106F8 File Offset: 0x0000E8F8
		[Token(Token = "0x6002DAE")]
		[Address(RVA = "0xCDCC30", Offset = "0xCDBC30", VA = "0x180CDCC30")]
		private int LoadAllJoystickCalibrationData()
		{
			return 0;
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00010710 File Offset: 0x0000E910
		[Token(Token = "0x6002DAF")]
		[Address(RVA = "0xCDCE20", Offset = "0xCDBE20", VA = "0x180CDCE20")]
		private int LoadJoystickCalibrationData(Joystick joystick)
		{
			return 0;
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x00010728 File Offset: 0x0000E928
		[Token(Token = "0x6002DB0")]
		[Address(RVA = "0xCDCF00", Offset = "0xCDBF00", VA = "0x180CDCF00")]
		private int LoadJoystickCalibrationData(int joystickId)
		{
			return 0;
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x00010740 File Offset: 0x0000E940
		[Token(Token = "0x6002DB1")]
		[Address(RVA = "0xCDCF80", Offset = "0xCDBF80", VA = "0x180CDCF80")]
		private int LoadJoystickData(int joystickId)
		{
			return 0;
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x00010758 File Offset: 0x0000E958
		[Token(Token = "0x6002DB2")]
		[Address(RVA = "0xCDD2F0", Offset = "0xCDC2F0", VA = "0x180CDD2F0")]
		private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
			return 0;
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00010770 File Offset: 0x0000E970
		[Token(Token = "0x6002DB3")]
		[Address(RVA = "0xCDD370", Offset = "0xCDC370", VA = "0x180CDD370")]
		private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
		{
			return 0;
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x00010788 File Offset: 0x0000E988
		[Token(Token = "0x6002DB4")]
		[Address(RVA = "0xCDD390", Offset = "0xCDC390", VA = "0x180CDD390")]
		private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
			return 0;
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DB5")]
		[Address(RVA = "0xCDD6F0", Offset = "0xCDC6F0", VA = "0x180CDD6F0")]
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x000107A0 File Offset: 0x0000E9A0
		[Token(Token = "0x6002DB6")]
		[Address(RVA = "0xCDD8D0", Offset = "0xCDC8D0", VA = "0x180CDD8D0")]
		private int LoadInputBehaviors(int playerId)
		{
			return 0;
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x000107B8 File Offset: 0x0000E9B8
		[Token(Token = "0x6002DB7")]
		[Address(RVA = "0xCDDB10", Offset = "0xCDCB10", VA = "0x180CDDB10")]
		private int LoadInputBehaviorNow(int playerId, int behaviorId)
		{
			return 0;
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x000107D0 File Offset: 0x0000E9D0
		[Token(Token = "0x6002DB8")]
		[Address(RVA = "0xCDDBF0", Offset = "0xCDCBF0", VA = "0x180CDDBF0")]
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
			return 0;
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x000107E8 File Offset: 0x0000E9E8
		[Token(Token = "0x6002DB9")]
		[Address(RVA = "0xCDDD70", Offset = "0xCDCD70", VA = "0x180CDDD70")]
		private bool LoadControllerAssignmentsNow()
		{
			return default(bool);
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x00010800 File Offset: 0x0000EA00
		[Token(Token = "0x6002DBA")]
		[Address(RVA = "0xCDDDE0", Offset = "0xCDCDE0", VA = "0x180CDDDE0")]
		private bool LoadKeyboardAndMouseAssignmentsNow(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
		{
			return default(bool);
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x00010818 File Offset: 0x0000EA18
		[Token(Token = "0x6002DBB")]
		[Address(RVA = "0xCDE110", Offset = "0xCDD110", VA = "0x180CDE110")]
		private bool LoadJoystickAssignmentsNow(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
		{
			return default(bool);
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DBC")]
		[Address(RVA = "0xCDEFB0", Offset = "0xCDDFB0", VA = "0x180CDEFB0")]
		private UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo LoadControllerAssignmentData()
		{
			return null;
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DBD")]
		[Address(RVA = "0xCDF120", Offset = "0xCDE120", VA = "0x180CDF120")]
		private IEnumerator LoadJoystickAssignmentsDeferred()
		{
			return null;
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBE")]
		[Address(RVA = "0xCDF1C0", Offset = "0xCDE1C0", VA = "0x180CDF1C0")]
		private void SaveAll()
		{
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBF")]
		[Address(RVA = "0xCDF410", Offset = "0xCDE410", VA = "0x180CDF410")]
		private void SavePlayerDataNow(int playerId)
		{
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC0")]
		[Address(RVA = "0xCDF4D0", Offset = "0xCDE4D0", VA = "0x180CDF4D0")]
		private void SavePlayerDataNow(Player player)
		{
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC1")]
		[Address(RVA = "0xCDF630", Offset = "0xCDE630", VA = "0x180CDF630")]
		private void SaveAllJoystickCalibrationData()
		{
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC2")]
		[Address(RVA = "0xCDF810", Offset = "0xCDE810", VA = "0x180CDF810")]
		private void SaveJoystickCalibrationData(int joystickId)
		{
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC3")]
		[Address(RVA = "0xCDF890", Offset = "0xCDE890", VA = "0x180CDF890")]
		private void SaveJoystickCalibrationData(Joystick joystick)
		{
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC4")]
		[Address(RVA = "0xCDFA90", Offset = "0xCDEA90", VA = "0x180CDFA90")]
		private void SaveJoystickData(int joystickId)
		{
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC5")]
		[Address(RVA = "0xCDFDE0", Offset = "0xCDEDE0", VA = "0x180CDFDE0")]
		private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC6")]
		[Address(RVA = "0xCDFEB0", Offset = "0xCDEEB0", VA = "0x180CDFEB0")]
		private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
		{
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC7")]
		[Address(RVA = "0xCDFF10", Offset = "0xCDEF10", VA = "0x180CDFF10")]
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
		{
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC8")]
		[Address(RVA = "0xCE0110", Offset = "0xCDF110", VA = "0x180CE0110")]
		private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC9")]
		[Address(RVA = "0xCE02E0", Offset = "0xCDF2E0", VA = "0x180CE02E0")]
		private void SaveControllerMap(Player player, ControllerMap controllerMap)
		{
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCA")]
		[Address(RVA = "0xCE05C0", Offset = "0xCDF5C0", VA = "0x180CE05C0")]
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
		{
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCB")]
		[Address(RVA = "0xCE0680", Offset = "0xCDF680", VA = "0x180CE0680")]
		private void SaveInputBehaviorNow(int playerId, int behaviorId)
		{
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCC")]
		[Address(RVA = "0xCE07C0", Offset = "0xCDF7C0", VA = "0x180CE07C0")]
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x00010830 File Offset: 0x0000EA30
		[Token(Token = "0x6002DCD")]
		[Address(RVA = "0xCE0810", Offset = "0xCDF810", VA = "0x180CE0810")]
		private bool SaveControllerAssignments()
		{
			return default(bool);
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x00010848 File Offset: 0x0000EA48
		[Token(Token = "0x6002DCE")]
		[Address(RVA = "0xCE0E10", Offset = "0xCDFE10", VA = "0x180CE0E10")]
		private bool ControllerAssignmentSaveDataExists()
		{
			return default(bool);
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DCF")]
		[Address(RVA = "0xCE0EB0", Offset = "0xCDFEB0", VA = "0x180CE0EB0")]
		private string GetBasePlayerPrefsKey(Player player)
		{
			return null;
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DD0")]
		[Address(RVA = "0xCE0F20", Offset = "0xCDFF20", VA = "0x180CE0F20")]
		private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DD1")]
		[Address(RVA = "0xCE1040", Offset = "0xCE0040", VA = "0x180CE1040")]
		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DD2")]
		[Address(RVA = "0xCE1160", Offset = "0xCE0160", VA = "0x180CE1160")]
		private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DD3")]
		[Address(RVA = "0xCE1760", Offset = "0xCE0760", VA = "0x180CE1760")]
		private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
		{
			return null;
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DD4")]
		[Address(RVA = "0xCE18E0", Offset = "0xCE08E0", VA = "0x180CE18E0")]
		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
		{
			return null;
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DD5")]
		[Address(RVA = "0xCE19C0", Offset = "0xCE09C0", VA = "0x180CE19C0")]
		private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DD6")]
		[Address(RVA = "0xCE1AC0", Offset = "0xCE0AC0", VA = "0x180CE1AC0")]
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DD7")]
		[Address(RVA = "0xCE1CC0", Offset = "0xCE0CC0", VA = "0x180CE1CC0")]
		private string GetJoystickCalibrationMapXml(Joystick joystick)
		{
			return null;
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DD8")]
		[Address(RVA = "0xCE1D80", Offset = "0xCE0D80", VA = "0x180CE1D80")]
		private string GetInputBehaviorXml(Player player, int id)
		{
			return null;
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD9")]
		[Address(RVA = "0xCE1E50", Offset = "0xCE0E50", VA = "0x180CE1E50")]
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
		{
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DDA")]
		[Address(RVA = "0xCE24A0", Offset = "0xCE14A0", VA = "0x180CE24A0")]
		private Joystick FindJoystickPrecise(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
		{
			return null;
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x00010860 File Offset: 0x0000EA60
		[Token(Token = "0x6002DDB")]
		[Address(RVA = "0xCE2680", Offset = "0xCE1680", VA = "0x180CE2680")]
		private bool TryFindJoysticksImprecise(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
		{
			return default(bool);
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x00010878 File Offset: 0x0000EA78
		[Token(Token = "0x6002DDC")]
		[Address(RVA = "0xCE2A30", Offset = "0xCE1A30", VA = "0x180CE2A30")]
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
		{
			return 0;
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDD")]
		[Address(RVA = "0xCE2EE0", Offset = "0xCE1EE0", VA = "0x180CE2EE0")]
		private void RefreshLayoutManager(int playerId)
		{
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DDE")]
		[Address(RVA = "0xCE2F70", Offset = "0xCE1F70", VA = "0x180CE2F70")]
		private static Type GetControllerMapType(ControllerType controllerType)
		{
			return null;
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDF")]
		[Address(RVA = "0xCE30E0", Offset = "0xCE20E0", VA = "0x180CE30E0")]
		public UserDataStore_PlayerPrefs()
		{
		}

		// Token: 0x04004D4C RID: 19788
		[Token(Token = "0x4004D4C")]
		private const string thisScriptName = "UserDataStore_PlayerPrefs";

		// Token: 0x04004D4D RID: 19789
		[Token(Token = "0x4004D4D")]
		private const string logPrefix = "Rewired: ";

		// Token: 0x04004D4E RID: 19790
		[Token(Token = "0x4004D4E")]
		private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component.";

		// Token: 0x04004D4F RID: 19791
		[Token(Token = "0x4004D4F")]
		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";

		// Token: 0x04004D50 RID: 19792
		[Token(Token = "0x4004D50")]
		private const int controllerMapPPKeyVersion_original = 0;

		// Token: 0x04004D51 RID: 19793
		[Token(Token = "0x4004D51")]
		private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;

		// Token: 0x04004D52 RID: 19794
		[Token(Token = "0x4004D52")]
		private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;

		// Token: 0x04004D53 RID: 19795
		[Token(Token = "0x4004D53")]
		private const int controllerMapPPKeyVersion_includeFormatVersion = 2;

		// Token: 0x04004D54 RID: 19796
		[Token(Token = "0x4004D54")]
		private const int controllerMapPPKeyVersion = 2;

		// Token: 0x04004D55 RID: 19797
		[Token(Token = "0x4004D55")]
		[FieldOffset(Offset = "0x18")]
		private bool isEnabled;

		// Token: 0x04004D56 RID: 19798
		[Token(Token = "0x4004D56")]
		[FieldOffset(Offset = "0x19")]
		private bool loadDataOnStart;

		// Token: 0x04004D57 RID: 19799
		[Token(Token = "0x4004D57")]
		[FieldOffset(Offset = "0x1A")]
		private bool loadJoystickAssignments;

		// Token: 0x04004D58 RID: 19800
		[Token(Token = "0x4004D58")]
		[FieldOffset(Offset = "0x1B")]
		private bool loadKeyboardAssignments;

		// Token: 0x04004D59 RID: 19801
		[Token(Token = "0x4004D59")]
		[FieldOffset(Offset = "0x1C")]
		private bool loadMouseAssignments;

		// Token: 0x04004D5A RID: 19802
		[Token(Token = "0x4004D5A")]
		[FieldOffset(Offset = "0x20")]
		private string playerPrefsKeyPrefix;

		// Token: 0x04004D5B RID: 19803
		[Token(Token = "0x4004D5B")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private bool allowImpreciseJoystickAssignmentMatching;

		// Token: 0x04004D5C RID: 19804
		[Token(Token = "0x4004D5C")]
		[FieldOffset(Offset = "0x29")]
		[NonSerialized]
		private bool deferredJoystickAssignmentLoadPending;

		// Token: 0x04004D5D RID: 19805
		[Token(Token = "0x4004D5D")]
		[FieldOffset(Offset = "0x2A")]
		[NonSerialized]
		private bool wasJoystickEverDetected;

		// Token: 0x04004D5E RID: 19806
		[Token(Token = "0x4004D5E")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		private List<int> __allActionIds;

		// Token: 0x04004D5F RID: 19807
		[Token(Token = "0x4004D5F")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private string __allActionIdsString;

		// Token: 0x020008F7 RID: 2295
		[Token(Token = "0x20008F7")]
		private class ControllerAssignmentSaveInfo
		{
			// Token: 0x1700036A RID: 874
			// (get) Token: 0x06002DE0 RID: 11744 RVA: 0x00010890 File Offset: 0x0000EA90
			[Token(Token = "0x1700036A")]
			public int playerCount
			{
				[Token(Token = "0x6002DE0")]
				[Address(RVA = "0xCE31B0", Offset = "0xCE21B0", VA = "0x180CE31B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06002DE1 RID: 11745 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DE1")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public ControllerAssignmentSaveInfo()
			{
			}

			// Token: 0x06002DE2 RID: 11746 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DE2")]
			[Address(RVA = "0xCE31D0", Offset = "0xCE21D0", VA = "0x180CE31D0")]
			public ControllerAssignmentSaveInfo(int playerCount)
			{
			}

			// Token: 0x06002DE3 RID: 11747 RVA: 0x000108A8 File Offset: 0x0000EAA8
			[Token(Token = "0x6002DE3")]
			[Address(RVA = "0xCE3390", Offset = "0xCE2390", VA = "0x180CE3390")]
			public int IndexOfPlayer(int playerId)
			{
				return 0;
			}

			// Token: 0x06002DE4 RID: 11748 RVA: 0x000108C0 File Offset: 0x0000EAC0
			[Token(Token = "0x6002DE4")]
			[Address(RVA = "0xCE3400", Offset = "0xCE2400", VA = "0x180CE3400")]
			public bool ContainsPlayer(int playerId)
			{
				return default(bool);
			}

			// Token: 0x04004D60 RID: 19808
			[Token(Token = "0x4004D60")]
			[FieldOffset(Offset = "0x10")]
			public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo[] players;

			// Token: 0x020008F8 RID: 2296
			[Token(Token = "0x20008F8")]
			public class PlayerInfo
			{
				// Token: 0x1700036B RID: 875
				// (get) Token: 0x06002DE5 RID: 11749 RVA: 0x000108D8 File Offset: 0x0000EAD8
				[Token(Token = "0x1700036B")]
				public int joystickCount
				{
					[Token(Token = "0x6002DE5")]
					[Address(RVA = "0xCE3420", Offset = "0xCE2420", VA = "0x180CE3420")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06002DE6 RID: 11750 RVA: 0x000108F0 File Offset: 0x0000EAF0
				[Token(Token = "0x6002DE6")]
				[Address(RVA = "0xCE3440", Offset = "0xCE2440", VA = "0x180CE3440")]
				public int IndexOfJoystick(int joystickId)
				{
					return 0;
				}

				// Token: 0x06002DE7 RID: 11751 RVA: 0x00010908 File Offset: 0x0000EB08
				[Token(Token = "0x6002DE7")]
				[Address(RVA = "0xCE34B0", Offset = "0xCE24B0", VA = "0x180CE34B0")]
				public bool ContainsJoystick(int joystickId)
				{
					return default(bool);
				}

				// Token: 0x06002DE8 RID: 11752 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6002DE8")]
				[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
				public PlayerInfo()
				{
				}

				// Token: 0x04004D61 RID: 19809
				[Token(Token = "0x4004D61")]
				[FieldOffset(Offset = "0x10")]
				public int id;

				// Token: 0x04004D62 RID: 19810
				[Token(Token = "0x4004D62")]
				[FieldOffset(Offset = "0x14")]
				public bool hasKeyboard;

				// Token: 0x04004D63 RID: 19811
				[Token(Token = "0x4004D63")]
				[FieldOffset(Offset = "0x15")]
				public bool hasMouse;

				// Token: 0x04004D64 RID: 19812
				[Token(Token = "0x4004D64")]
				[FieldOffset(Offset = "0x18")]
				public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[] joysticks;
			}

			// Token: 0x020008F9 RID: 2297
			[Token(Token = "0x20008F9")]
			public class JoystickInfo
			{
				// Token: 0x06002DE9 RID: 11753 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6002DE9")]
				[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
				public JoystickInfo()
				{
				}

				// Token: 0x04004D65 RID: 19813
				[Token(Token = "0x4004D65")]
				[FieldOffset(Offset = "0x10")]
				public Guid instanceGuid;

				// Token: 0x04004D66 RID: 19814
				[Token(Token = "0x4004D66")]
				[FieldOffset(Offset = "0x20")]
				public string hardwareIdentifier;

				// Token: 0x04004D67 RID: 19815
				[Token(Token = "0x4004D67")]
				[FieldOffset(Offset = "0x28")]
				public int id;
			}
		}

		// Token: 0x020008FA RID: 2298
		[Token(Token = "0x20008FA")]
		private class JoystickAssignmentHistoryInfo
		{
			// Token: 0x06002DEA RID: 11754 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DEA")]
			[Address(RVA = "0xCE3520", Offset = "0xCE2520", VA = "0x180CE3520")]
			public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
			{
			}

			// Token: 0x04004D68 RID: 19816
			[Token(Token = "0x4004D68")]
			[FieldOffset(Offset = "0x10")]
			public readonly Joystick joystick;

			// Token: 0x04004D69 RID: 19817
			[Token(Token = "0x4004D69")]
			[FieldOffset(Offset = "0x18")]
			public readonly int oldJoystickId;
		}

		// Token: 0x020008FB RID: 2299
		[Token(Token = "0x20008FB")]
		private sealed class <>c__DisplayClass78_0
		{
			// Token: 0x06002DEB RID: 11755 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DEB")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass78_0()
			{
			}

			// Token: 0x06002DEC RID: 11756 RVA: 0x00010920 File Offset: 0x0000EB20
			[Token(Token = "0x6002DEC")]
			[Address(RVA = "0xC02D60", Offset = "0xC01D60", VA = "0x180C02D60")]
			internal bool <LoadJoystickAssignmentsNow>b__0(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x)
			{
				return default(bool);
			}

			// Token: 0x04004D6A RID: 19818
			[Token(Token = "0x4004D6A")]
			[FieldOffset(Offset = "0x10")]
			public Joystick joystick;
		}

		// Token: 0x020008FC RID: 2300
		[Token(Token = "0x20008FC")]
		private sealed class <>c__DisplayClass78_1
		{
			// Token: 0x06002DED RID: 11757 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DED")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass78_1()
			{
			}

			// Token: 0x06002DEE RID: 11758 RVA: 0x00010938 File Offset: 0x0000EB38
			[Token(Token = "0x6002DEE")]
			[Address(RVA = "0xCE35E0", Offset = "0xCE25E0", VA = "0x180CE35E0")]
			internal bool <LoadJoystickAssignmentsNow>b__1(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x)
			{
				return default(bool);
			}

			// Token: 0x04004D6B RID: 19819
			[Token(Token = "0x4004D6B")]
			[FieldOffset(Offset = "0x10")]
			public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo;
		}

		// Token: 0x020008FD RID: 2301
		[Token(Token = "0x20008FD")]
		private sealed class <>c__DisplayClass78_2
		{
			// Token: 0x06002DEF RID: 11759 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DEF")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass78_2()
			{
			}

			// Token: 0x06002DF0 RID: 11760 RVA: 0x00010950 File Offset: 0x0000EB50
			[Token(Token = "0x6002DF0")]
			[Address(RVA = "0xC02D60", Offset = "0xC01D60", VA = "0x180C02D60")]
			internal bool <LoadJoystickAssignmentsNow>b__2(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x)
			{
				return default(bool);
			}

			// Token: 0x04004D6C RID: 19820
			[Token(Token = "0x4004D6C")]
			[FieldOffset(Offset = "0x10")]
			public Joystick match;
		}

		// Token: 0x020008FE RID: 2302
		[Token(Token = "0x20008FE")]
		private sealed class <LoadJoystickAssignmentsDeferred>d__80 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x06002DF1 RID: 11761 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DF1")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <LoadJoystickAssignmentsDeferred>d__80(int <>1__state)
			{
			}

			// Token: 0x06002DF2 RID: 11762 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DF2")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x06002DF3 RID: 11763 RVA: 0x00010968 File Offset: 0x0000EB68
			[Token(Token = "0x6002DF3")]
			[Address(RVA = "0xCE3610", Offset = "0xCE2610", VA = "0x180CE3610", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700036C RID: 876
			// (get) Token: 0x06002DF4 RID: 11764 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700036C")]
			private object Current
			{
				[Token(Token = "0x6002DF4")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002DF5 RID: 11765 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DF5")]
			[Address(RVA = "0xCE3750", Offset = "0xCE2750", VA = "0x180CE3750", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x1700036D RID: 877
			// (get) Token: 0x06002DF6 RID: 11766 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700036D")]
			private object Current
			{
				[Token(Token = "0x6002DF6")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04004D6D RID: 19821
			[Token(Token = "0x4004D6D")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04004D6E RID: 19822
			[Token(Token = "0x4004D6E")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04004D6F RID: 19823
			[Token(Token = "0x4004D6F")]
			[FieldOffset(Offset = "0x20")]
			public UserDataStore_PlayerPrefs <>4__this;
		}
	}
}
