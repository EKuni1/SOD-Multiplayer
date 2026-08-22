using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Rewired
{
	// Token: 0x020008EC RID: 2284
	[Token(Token = "0x20008EC")]
	public interface IFlightPedalsTemplate : IEnumerator<object>
	{
		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06002BF6 RID: 11254
		[Token(Token = "0x17000235")]
		IControllerTemplateAxis leftPedal { [Token(Token = "0x6002BF6")] get; }

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06002BF7 RID: 11255
		[Token(Token = "0x17000236")]
		IControllerTemplateAxis rightPedal { [Token(Token = "0x6002BF7")] get; }

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06002BF8 RID: 11256
		[Token(Token = "0x17000237")]
		IControllerTemplateAxis slide { [Token(Token = "0x6002BF8")] get; }
	}
}
