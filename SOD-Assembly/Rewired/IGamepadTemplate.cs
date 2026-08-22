using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Rewired
{
	// Token: 0x020008E8 RID: 2280
	[Token(Token = "0x20008E8")]
	public interface IGamepadTemplate : IEnumerator<object>
	{
		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06002B26 RID: 11046
		[Token(Token = "0x17000165")]
		IControllerTemplateButton actionBottomRow1 { [Token(Token = "0x6002B26")] get; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06002B27 RID: 11047
		[Token(Token = "0x17000166")]
		IControllerTemplateButton a { [Token(Token = "0x6002B27")] get; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06002B28 RID: 11048
		[Token(Token = "0x17000167")]
		IControllerTemplateButton actionBottomRow2 { [Token(Token = "0x6002B28")] get; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06002B29 RID: 11049
		[Token(Token = "0x17000168")]
		IControllerTemplateButton b { [Token(Token = "0x6002B29")] get; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06002B2A RID: 11050
		[Token(Token = "0x17000169")]
		IControllerTemplateButton actionBottomRow3 { [Token(Token = "0x6002B2A")] get; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06002B2B RID: 11051
		[Token(Token = "0x1700016A")]
		IControllerTemplateButton c { [Token(Token = "0x6002B2B")] get; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06002B2C RID: 11052
		[Token(Token = "0x1700016B")]
		IControllerTemplateButton actionTopRow1 { [Token(Token = "0x6002B2C")] get; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06002B2D RID: 11053
		[Token(Token = "0x1700016C")]
		IControllerTemplateButton x { [Token(Token = "0x6002B2D")] get; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06002B2E RID: 11054
		[Token(Token = "0x1700016D")]
		IControllerTemplateButton actionTopRow2 { [Token(Token = "0x6002B2E")] get; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06002B2F RID: 11055
		[Token(Token = "0x1700016E")]
		IControllerTemplateButton y { [Token(Token = "0x6002B2F")] get; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06002B30 RID: 11056
		[Token(Token = "0x1700016F")]
		IControllerTemplateButton actionTopRow3 { [Token(Token = "0x6002B30")] get; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06002B31 RID: 11057
		[Token(Token = "0x17000170")]
		IControllerTemplateButton z { [Token(Token = "0x6002B31")] get; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06002B32 RID: 11058
		[Token(Token = "0x17000171")]
		IControllerTemplateButton leftShoulder1 { [Token(Token = "0x6002B32")] get; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06002B33 RID: 11059
		[Token(Token = "0x17000172")]
		IControllerTemplateButton leftBumper { [Token(Token = "0x6002B33")] get; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06002B34 RID: 11060
		[Token(Token = "0x17000173")]
		IControllerTemplateAxis leftShoulder2 { [Token(Token = "0x6002B34")] get; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06002B35 RID: 11061
		[Token(Token = "0x17000174")]
		IControllerTemplateAxis leftTrigger { [Token(Token = "0x6002B35")] get; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06002B36 RID: 11062
		[Token(Token = "0x17000175")]
		IControllerTemplateButton rightShoulder1 { [Token(Token = "0x6002B36")] get; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06002B37 RID: 11063
		[Token(Token = "0x17000176")]
		IControllerTemplateButton rightBumper { [Token(Token = "0x6002B37")] get; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06002B38 RID: 11064
		[Token(Token = "0x17000177")]
		IControllerTemplateAxis rightShoulder2 { [Token(Token = "0x6002B38")] get; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06002B39 RID: 11065
		[Token(Token = "0x17000178")]
		IControllerTemplateAxis rightTrigger { [Token(Token = "0x6002B39")] get; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06002B3A RID: 11066
		[Token(Token = "0x17000179")]
		IControllerTemplateButton center1 { [Token(Token = "0x6002B3A")] get; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06002B3B RID: 11067
		[Token(Token = "0x1700017A")]
		IControllerTemplateButton back { [Token(Token = "0x6002B3B")] get; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06002B3C RID: 11068
		[Token(Token = "0x1700017B")]
		IControllerTemplateButton center2 { [Token(Token = "0x6002B3C")] get; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06002B3D RID: 11069
		[Token(Token = "0x1700017C")]
		IControllerTemplateButton start { [Token(Token = "0x6002B3D")] get; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06002B3E RID: 11070
		[Token(Token = "0x1700017D")]
		IControllerTemplateButton center3 { [Token(Token = "0x6002B3E")] get; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06002B3F RID: 11071
		[Token(Token = "0x1700017E")]
		IControllerTemplateButton guide { [Token(Token = "0x6002B3F")] get; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06002B40 RID: 11072
		[Token(Token = "0x1700017F")]
		IControllerTemplateThumbStick leftStick { [Token(Token = "0x6002B40")] get; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06002B41 RID: 11073
		[Token(Token = "0x17000180")]
		IControllerTemplateThumbStick rightStick { [Token(Token = "0x6002B41")] get; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06002B42 RID: 11074
		[Token(Token = "0x17000181")]
		IControllerTemplateDPad dPad { [Token(Token = "0x6002B42")] get; }
	}
}
