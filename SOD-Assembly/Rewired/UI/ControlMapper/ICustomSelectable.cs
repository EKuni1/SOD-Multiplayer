using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000939 RID: 2361
	[Token(Token = "0x2000939")]
	public interface ICustomSelectable : IEnumerator<object>, IDisposable
	{
		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060031AD RID: 12717
		// (set) Token: 0x060031AE RID: 12718
		[Token(Token = "0x17000465")]
		Sprite disabledHighlightedSprite { [Token(Token = "0x60031AD")] get; [Token(Token = "0x60031AE")] set; }

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060031AF RID: 12719
		// (set) Token: 0x060031B0 RID: 12720
		[Token(Token = "0x17000466")]
		Color disabledHighlightedColor { [Token(Token = "0x60031AF")] get; [Token(Token = "0x60031B0")] set; }

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060031B1 RID: 12721
		// (set) Token: 0x060031B2 RID: 12722
		[Token(Token = "0x17000467")]
		string disabledHighlightedTrigger { [Token(Token = "0x60031B1")] get; [Token(Token = "0x60031B2")] set; }

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060031B3 RID: 12723
		// (set) Token: 0x060031B4 RID: 12724
		[Token(Token = "0x17000468")]
		bool autoNavUp { [Token(Token = "0x60031B3")] get; [Token(Token = "0x60031B4")] set; }

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060031B5 RID: 12725
		// (set) Token: 0x060031B6 RID: 12726
		[Token(Token = "0x17000469")]
		bool autoNavDown { [Token(Token = "0x60031B5")] get; [Token(Token = "0x60031B6")] set; }

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060031B7 RID: 12727
		// (set) Token: 0x060031B8 RID: 12728
		[Token(Token = "0x1700046A")]
		bool autoNavLeft { [Token(Token = "0x60031B7")] get; [Token(Token = "0x60031B8")] set; }

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060031B9 RID: 12729
		// (set) Token: 0x060031BA RID: 12730
		[Token(Token = "0x1700046B")]
		bool autoNavRight { [Token(Token = "0x60031B9")] get; [Token(Token = "0x60031BA")] set; }

		// Token: 0x14000078 RID: 120
		// (add) Token: 0x060031BB RID: 12731
		// (remove) Token: 0x060031BC RID: 12732
		[Token(Token = "0x14000078")]
		event UnityAction CancelEvent;
	}
}
