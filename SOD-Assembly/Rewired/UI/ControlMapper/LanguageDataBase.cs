using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000944 RID: 2372
	[Token(Token = "0x2000944")]
	[Serializable]
	public abstract class LanguageDataBase : ScriptableObject
	{
		// Token: 0x06003231 RID: 12849
		[Token(Token = "0x6003231")]
		public abstract void Initialize();

		// Token: 0x06003232 RID: 12850
		[Token(Token = "0x6003232")]
		public abstract string GetCustomEntry(string key);

		// Token: 0x06003233 RID: 12851
		[Token(Token = "0x6003233")]
		public abstract bool ContainsCustomEntryKey(string key);

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06003234 RID: 12852
		[Token(Token = "0x1700049F")]
		public abstract string yes { [Token(Token = "0x6003234")] get; }

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06003235 RID: 12853
		[Token(Token = "0x170004A0")]
		public abstract string no { [Token(Token = "0x6003235")] get; }

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06003236 RID: 12854
		[Token(Token = "0x170004A1")]
		public abstract string add { [Token(Token = "0x6003236")] get; }

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06003237 RID: 12855
		[Token(Token = "0x170004A2")]
		public abstract string replace { [Token(Token = "0x6003237")] get; }

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06003238 RID: 12856
		[Token(Token = "0x170004A3")]
		public abstract string remove { [Token(Token = "0x6003238")] get; }

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06003239 RID: 12857
		[Token(Token = "0x170004A4")]
		public abstract string swap { [Token(Token = "0x6003239")] get; }

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600323A RID: 12858
		[Token(Token = "0x170004A5")]
		public abstract string cancel { [Token(Token = "0x600323A")] get; }

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600323B RID: 12859
		[Token(Token = "0x170004A6")]
		public abstract string none { [Token(Token = "0x600323B")] get; }

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x0600323C RID: 12860
		[Token(Token = "0x170004A7")]
		public abstract string okay { [Token(Token = "0x600323C")] get; }

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x0600323D RID: 12861
		[Token(Token = "0x170004A8")]
		public abstract string done { [Token(Token = "0x600323D")] get; }

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x0600323E RID: 12862
		[Token(Token = "0x170004A9")]
		public abstract string default_ { [Token(Token = "0x600323E")] get; }

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600323F RID: 12863
		[Token(Token = "0x170004AA")]
		public abstract string assignControllerWindowTitle { [Token(Token = "0x600323F")] get; }

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06003240 RID: 12864
		[Token(Token = "0x170004AB")]
		public abstract string assignControllerWindowMessage { [Token(Token = "0x6003240")] get; }

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06003241 RID: 12865
		[Token(Token = "0x170004AC")]
		public abstract string controllerAssignmentConflictWindowTitle { [Token(Token = "0x6003241")] get; }

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06003242 RID: 12866
		[Token(Token = "0x170004AD")]
		public abstract string elementAssignmentPrePollingWindowMessage { [Token(Token = "0x6003242")] get; }

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06003243 RID: 12867
		[Token(Token = "0x170004AE")]
		public abstract string elementAssignmentConflictWindowMessage { [Token(Token = "0x6003243")] get; }

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06003244 RID: 12868
		[Token(Token = "0x170004AF")]
		public abstract string mouseAssignmentConflictWindowTitle { [Token(Token = "0x6003244")] get; }

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06003245 RID: 12869
		[Token(Token = "0x170004B0")]
		public abstract string calibrateControllerWindowTitle { [Token(Token = "0x6003245")] get; }

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06003246 RID: 12870
		[Token(Token = "0x170004B1")]
		public abstract string calibrateAxisStep1WindowTitle { [Token(Token = "0x6003246")] get; }

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06003247 RID: 12871
		[Token(Token = "0x170004B2")]
		public abstract string calibrateAxisStep2WindowTitle { [Token(Token = "0x6003247")] get; }

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06003248 RID: 12872
		[Token(Token = "0x170004B3")]
		public abstract string inputBehaviorSettingsWindowTitle { [Token(Token = "0x6003248")] get; }

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06003249 RID: 12873
		[Token(Token = "0x170004B4")]
		public abstract string restoreDefaultsWindowTitle { [Token(Token = "0x6003249")] get; }

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600324A RID: 12874
		[Token(Token = "0x170004B5")]
		public abstract string actionColumnLabel { [Token(Token = "0x600324A")] get; }

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600324B RID: 12875
		[Token(Token = "0x170004B6")]
		public abstract string keyboardColumnLabel { [Token(Token = "0x600324B")] get; }

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600324C RID: 12876
		[Token(Token = "0x170004B7")]
		public abstract string mouseColumnLabel { [Token(Token = "0x600324C")] get; }

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600324D RID: 12877
		[Token(Token = "0x170004B8")]
		public abstract string controllerColumnLabel { [Token(Token = "0x600324D")] get; }

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x0600324E RID: 12878
		[Token(Token = "0x170004B9")]
		public abstract string removeControllerButtonLabel { [Token(Token = "0x600324E")] get; }

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600324F RID: 12879
		[Token(Token = "0x170004BA")]
		public abstract string calibrateControllerButtonLabel { [Token(Token = "0x600324F")] get; }

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06003250 RID: 12880
		[Token(Token = "0x170004BB")]
		public abstract string assignControllerButtonLabel { [Token(Token = "0x6003250")] get; }

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06003251 RID: 12881
		[Token(Token = "0x170004BC")]
		public abstract string inputBehaviorSettingsButtonLabel { [Token(Token = "0x6003251")] get; }

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06003252 RID: 12882
		[Token(Token = "0x170004BD")]
		public abstract string doneButtonLabel { [Token(Token = "0x6003252")] get; }

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06003253 RID: 12883
		[Token(Token = "0x170004BE")]
		public abstract string restoreDefaultsButtonLabel { [Token(Token = "0x6003253")] get; }

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06003254 RID: 12884
		[Token(Token = "0x170004BF")]
		public abstract string controllerSettingsGroupLabel { [Token(Token = "0x6003254")] get; }

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06003255 RID: 12885
		[Token(Token = "0x170004C0")]
		public abstract string playersGroupLabel { [Token(Token = "0x6003255")] get; }

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06003256 RID: 12886
		[Token(Token = "0x170004C1")]
		public abstract string assignedControllersGroupLabel { [Token(Token = "0x6003256")] get; }

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06003257 RID: 12887
		[Token(Token = "0x170004C2")]
		public abstract string settingsGroupLabel { [Token(Token = "0x6003257")] get; }

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06003258 RID: 12888
		[Token(Token = "0x170004C3")]
		public abstract string mapCategoriesGroupLabel { [Token(Token = "0x6003258")] get; }

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06003259 RID: 12889
		[Token(Token = "0x170004C4")]
		public abstract string restoreDefaultsWindowMessage { [Token(Token = "0x6003259")] get; }

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600325A RID: 12890
		[Token(Token = "0x170004C5")]
		public abstract string calibrateWindow_deadZoneSliderLabel { [Token(Token = "0x600325A")] get; }

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600325B RID: 12891
		[Token(Token = "0x170004C6")]
		public abstract string calibrateWindow_zeroSliderLabel { [Token(Token = "0x600325B")] get; }

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600325C RID: 12892
		[Token(Token = "0x170004C7")]
		public abstract string calibrateWindow_sensitivitySliderLabel { [Token(Token = "0x600325C")] get; }

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600325D RID: 12893
		[Token(Token = "0x170004C8")]
		public abstract string calibrateWindow_invertToggleLabel { [Token(Token = "0x600325D")] get; }

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x0600325E RID: 12894
		[Token(Token = "0x170004C9")]
		public abstract string calibrateWindow_calibrateButtonLabel { [Token(Token = "0x600325E")] get; }

		// Token: 0x0600325F RID: 12895
		[Token(Token = "0x600325F")]
		public abstract string GetControllerAssignmentConflictWindowMessage(string joystickName, string otherPlayerName, string currentPlayerName);

		// Token: 0x06003260 RID: 12896
		[Token(Token = "0x6003260")]
		public abstract string GetJoystickElementAssignmentPollingWindowMessage(string actionName);

		// Token: 0x06003261 RID: 12897
		[Token(Token = "0x6003261")]
		public abstract string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName);

		// Token: 0x06003262 RID: 12898
		[Token(Token = "0x6003262")]
		public abstract string GetKeyboardElementAssignmentPollingWindowMessage(string actionName);

		// Token: 0x06003263 RID: 12899
		[Token(Token = "0x6003263")]
		public abstract string GetMouseElementAssignmentPollingWindowMessage(string actionName);

		// Token: 0x06003264 RID: 12900
		[Token(Token = "0x6003264")]
		public abstract string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName);

		// Token: 0x06003265 RID: 12901
		[Token(Token = "0x6003265")]
		public abstract string GetElementAlreadyInUseBlocked(string elementName);

		// Token: 0x06003266 RID: 12902
		[Token(Token = "0x6003266")]
		public abstract string GetElementAlreadyInUseCanReplace(string elementName, bool allowConflicts);

		// Token: 0x06003267 RID: 12903
		[Token(Token = "0x6003267")]
		public abstract string GetMouseAssignmentConflictWindowMessage(string otherPlayerName, string thisPlayerName);

		// Token: 0x06003268 RID: 12904
		[Token(Token = "0x6003268")]
		public abstract string GetCalibrateAxisStep1WindowMessage(string axisName);

		// Token: 0x06003269 RID: 12905
		[Token(Token = "0x6003269")]
		public abstract string GetCalibrateAxisStep2WindowMessage(string axisName);

		// Token: 0x0600326A RID: 12906
		[Token(Token = "0x600326A")]
		public abstract string GetPlayerName(int playerId);

		// Token: 0x0600326B RID: 12907
		[Token(Token = "0x600326B")]
		public abstract string GetControllerName(Controller controller);

		// Token: 0x0600326C RID: 12908
		[Token(Token = "0x600326C")]
		public abstract string GetElementIdentifierName(ActionElementMap actionElementMap);

		// Token: 0x0600326D RID: 12909
		[Token(Token = "0x600326D")]
		public abstract string GetElementIdentifierName(Controller controller, int elementIdentifierId, AxisRange axisRange);

		// Token: 0x0600326E RID: 12910
		[Token(Token = "0x600326E")]
		public abstract string GetElementIdentifierName(KeyCode keyCode, ModifierKeyFlags modifierKeyFlags);

		// Token: 0x0600326F RID: 12911
		[Token(Token = "0x600326F")]
		public abstract string GetActionName(int actionId);

		// Token: 0x06003270 RID: 12912
		[Token(Token = "0x6003270")]
		public abstract string GetActionName(int actionId, AxisRange axisRange);

		// Token: 0x06003271 RID: 12913
		[Token(Token = "0x6003271")]
		public abstract string GetMapCategoryName(int id);

		// Token: 0x06003272 RID: 12914
		[Token(Token = "0x6003272")]
		public abstract string GetActionCategoryName(int id);

		// Token: 0x06003273 RID: 12915
		[Token(Token = "0x6003273")]
		public abstract string GetLayoutName(ControllerType controllerType, int id);

		// Token: 0x06003274 RID: 12916
		[Token(Token = "0x6003274")]
		public abstract string ModifierKeyFlagsToString(ModifierKeyFlags flags);

		// Token: 0x06003275 RID: 12917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003275")]
		[Address(RVA = "0x5C7970", Offset = "0x5C6970", VA = "0x1805C7970")]
		protected LanguageDataBase()
		{
		}
	}
}
