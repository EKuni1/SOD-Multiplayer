using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x02000901 RID: 2305
	[Token(Token = "0x2000901")]
	public class RewiredEventSystem : EventSystem
	{
		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06002E09 RID: 11785 RVA: 0x000109E0 File Offset: 0x0000EBE0
		// (set) Token: 0x06002E0A RID: 11786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000376")]
		public bool alwaysUpdate
		{
			[Token(Token = "0x6002E09")]
			[Address(RVA = "0xCE4AE0", Offset = "0xCE3AE0", VA = "0x180CE4AE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E0A")]
			[Address(RVA = "0xCE4AF0", Offset = "0xCE3AF0", VA = "0x180CE4AF0")]
			set
			{
			}
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E0B")]
		[Address(RVA = "0xCE4B00", Offset = "0xCE3B00", VA = "0x180CE4B00", Slot = "18")]
		protected override void Update()
		{
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E0C")]
		[Address(RVA = "0xCE4F00", Offset = "0xCE3F00", VA = "0x180CE4F00")]
		public RewiredEventSystem()
		{
		}

		// Token: 0x04004D78 RID: 19832
		[Token(Token = "0x4004D78")]
		[FieldOffset(Offset = "0x50")]
		private bool _alwaysUpdate;
	}
}
