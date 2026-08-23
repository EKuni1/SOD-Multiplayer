using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Rewired
{
	// Token: 0x020008EF RID: 2287
	[Token(Token = "0x20008EF")]
	public sealed class RacingWheelTemplate : ControllerTemplate, IEnumerator<object>, IDisposable
	{
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06002C41 RID: 11329 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700027E")]
		private IControllerTemplateAxis wheel
		{
			[Token(Token = "0x6002C41")]
			[Address(RVA = "0xCD4F20", Offset = "0xCD3F20", VA = "0x180CD4F20", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06002C42 RID: 11330 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700027F")]
		private IControllerTemplateAxis accelerator
		{
			[Token(Token = "0x6002C42")]
			[Address(RVA = "0xCD4F60", Offset = "0xCD3F60", VA = "0x180CD4F60", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000280")]
		private IControllerTemplateAxis brake
		{
			[Token(Token = "0x6002C43")]
			[Address(RVA = "0xCD4FB0", Offset = "0xCD3FB0", VA = "0x180CD4FB0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000281")]
		private IControllerTemplateAxis clutch
		{
			[Token(Token = "0x6002C44")]
			[Address(RVA = "0xCD5000", Offset = "0xCD4000", VA = "0x180CD5000", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000282")]
		private IControllerTemplateButton shiftDown
		{
			[Token(Token = "0x6002C45")]
			[Address(RVA = "0xCD5050", Offset = "0xCD4050", VA = "0x180CD5050", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06002C46 RID: 11334 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000283")]
		private IControllerTemplateButton shiftUp
		{
			[Token(Token = "0x6002C46")]
			[Address(RVA = "0xCD50A0", Offset = "0xCD40A0", VA = "0x180CD50A0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06002C47 RID: 11335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000284")]
		private IControllerTemplateButton wheelButton1
		{
			[Token(Token = "0x6002C47")]
			[Address(RVA = "0xCD50F0", Offset = "0xCD40F0", VA = "0x180CD50F0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06002C48 RID: 11336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000285")]
		private IControllerTemplateButton wheelButton2
		{
			[Token(Token = "0x6002C48")]
			[Address(RVA = "0xCD5140", Offset = "0xCD4140", VA = "0x180CD5140", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000286")]
		private IControllerTemplateButton wheelButton3
		{
			[Token(Token = "0x6002C49")]
			[Address(RVA = "0xCD5190", Offset = "0xCD4190", VA = "0x180CD5190", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000287")]
		private IControllerTemplateButton wheelButton4
		{
			[Token(Token = "0x6002C4A")]
			[Address(RVA = "0xCD51E0", Offset = "0xCD41E0", VA = "0x180CD51E0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000288")]
		private IControllerTemplateButton wheelButton5
		{
			[Token(Token = "0x6002C4B")]
			[Address(RVA = "0xCD5230", Offset = "0xCD4230", VA = "0x180CD5230", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06002C4C RID: 11340 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000289")]
		private IControllerTemplateButton wheelButton6
		{
			[Token(Token = "0x6002C4C")]
			[Address(RVA = "0xCD5280", Offset = "0xCD4280", VA = "0x180CD5280", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700028A")]
		private IControllerTemplateButton wheelButton7
		{
			[Token(Token = "0x6002C4D")]
			[Address(RVA = "0xCD52D0", Offset = "0xCD42D0", VA = "0x180CD52D0", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06002C4E RID: 11342 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700028B")]
		private IControllerTemplateButton wheelButton8
		{
			[Token(Token = "0x6002C4E")]
			[Address(RVA = "0xCD5320", Offset = "0xCD4320", VA = "0x180CD5320", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700028C")]
		private IControllerTemplateButton wheelButton9
		{
			[Token(Token = "0x6002C4F")]
			[Address(RVA = "0xCD5370", Offset = "0xCD4370", VA = "0x180CD5370", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700028D")]
		private IControllerTemplateButton wheelButton10
		{
			[Token(Token = "0x6002C50")]
			[Address(RVA = "0xCD53C0", Offset = "0xCD43C0", VA = "0x180CD53C0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700028E")]
		private IControllerTemplateButton consoleButton1
		{
			[Token(Token = "0x6002C51")]
			[Address(RVA = "0xCD5410", Offset = "0xCD4410", VA = "0x180CD5410", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06002C52 RID: 11346 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700028F")]
		private IControllerTemplateButton consoleButton2
		{
			[Token(Token = "0x6002C52")]
			[Address(RVA = "0xCD5460", Offset = "0xCD4460", VA = "0x180CD5460", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06002C53 RID: 11347 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000290")]
		private IControllerTemplateButton consoleButton3
		{
			[Token(Token = "0x6002C53")]
			[Address(RVA = "0xCD54B0", Offset = "0xCD44B0", VA = "0x180CD54B0", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000291")]
		private IControllerTemplateButton consoleButton4
		{
			[Token(Token = "0x6002C54")]
			[Address(RVA = "0xCD5500", Offset = "0xCD4500", VA = "0x180CD5500", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06002C55 RID: 11349 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000292")]
		private IControllerTemplateButton consoleButton5
		{
			[Token(Token = "0x6002C55")]
			[Address(RVA = "0xCD5550", Offset = "0xCD4550", VA = "0x180CD5550", Slot = "32")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000293")]
		private IControllerTemplateButton consoleButton6
		{
			[Token(Token = "0x6002C56")]
			[Address(RVA = "0xCD55A0", Offset = "0xCD45A0", VA = "0x180CD55A0", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06002C57 RID: 11351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000294")]
		private IControllerTemplateButton consoleButton7
		{
			[Token(Token = "0x6002C57")]
			[Address(RVA = "0xCD55F0", Offset = "0xCD45F0", VA = "0x180CD55F0", Slot = "34")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06002C58 RID: 11352 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000295")]
		private IControllerTemplateButton consoleButton8
		{
			[Token(Token = "0x6002C58")]
			[Address(RVA = "0xCD5640", Offset = "0xCD4640", VA = "0x180CD5640", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06002C59 RID: 11353 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000296")]
		private IControllerTemplateButton consoleButton9
		{
			[Token(Token = "0x6002C59")]
			[Address(RVA = "0xCD5690", Offset = "0xCD4690", VA = "0x180CD5690", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000297")]
		private IControllerTemplateButton consoleButton10
		{
			[Token(Token = "0x6002C5A")]
			[Address(RVA = "0xCD56E0", Offset = "0xCD46E0", VA = "0x180CD56E0", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000298")]
		private IControllerTemplateButton shifter1
		{
			[Token(Token = "0x6002C5B")]
			[Address(RVA = "0xCD5730", Offset = "0xCD4730", VA = "0x180CD5730", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06002C5C RID: 11356 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000299")]
		private IControllerTemplateButton shifter2
		{
			[Token(Token = "0x6002C5C")]
			[Address(RVA = "0xCD5780", Offset = "0xCD4780", VA = "0x180CD5780", Slot = "39")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029A")]
		private IControllerTemplateButton shifter3
		{
			[Token(Token = "0x6002C5D")]
			[Address(RVA = "0xCD57D0", Offset = "0xCD47D0", VA = "0x180CD57D0", Slot = "40")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029B")]
		private IControllerTemplateButton shifter4
		{
			[Token(Token = "0x6002C5E")]
			[Address(RVA = "0xCD5820", Offset = "0xCD4820", VA = "0x180CD5820", Slot = "41")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06002C5F RID: 11359 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029C")]
		private IControllerTemplateButton shifter5
		{
			[Token(Token = "0x6002C5F")]
			[Address(RVA = "0xCD5870", Offset = "0xCD4870", VA = "0x180CD5870", Slot = "42")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029D")]
		private IControllerTemplateButton shifter6
		{
			[Token(Token = "0x6002C60")]
			[Address(RVA = "0xCD58C0", Offset = "0xCD48C0", VA = "0x180CD58C0", Slot = "43")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06002C61 RID: 11361 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029E")]
		private IControllerTemplateButton shifter7
		{
			[Token(Token = "0x6002C61")]
			[Address(RVA = "0xCD5910", Offset = "0xCD4910", VA = "0x180CD5910", Slot = "44")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029F")]
		private IControllerTemplateButton shifter8
		{
			[Token(Token = "0x6002C62")]
			[Address(RVA = "0xCD5960", Offset = "0xCD4960", VA = "0x180CD5960", Slot = "45")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06002C63 RID: 11363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A0")]
		private IControllerTemplateButton shifter9
		{
			[Token(Token = "0x6002C63")]
			[Address(RVA = "0xCD59B0", Offset = "0xCD49B0", VA = "0x180CD59B0", Slot = "46")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A1")]
		private IControllerTemplateButton shifter10
		{
			[Token(Token = "0x6002C64")]
			[Address(RVA = "0xCD5A00", Offset = "0xCD4A00", VA = "0x180CD5A00", Slot = "47")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A2")]
		private IControllerTemplateButton reverseGear
		{
			[Token(Token = "0x6002C65")]
			[Address(RVA = "0xCD5A50", Offset = "0xCD4A50", VA = "0x180CD5A50", Slot = "48")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A3")]
		private IControllerTemplateButton select
		{
			[Token(Token = "0x6002C66")]
			[Address(RVA = "0xCD5AA0", Offset = "0xCD4AA0", VA = "0x180CD5AA0", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A4")]
		private IControllerTemplateButton start
		{
			[Token(Token = "0x6002C67")]
			[Address(RVA = "0xCD5AF0", Offset = "0xCD4AF0", VA = "0x180CD5AF0", Slot = "50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A5")]
		private IControllerTemplateButton systemButton
		{
			[Token(Token = "0x6002C68")]
			[Address(RVA = "0xCD5B40", Offset = "0xCD4B40", VA = "0x180CD5B40", Slot = "51")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A6")]
		private IControllerTemplateButton horn
		{
			[Token(Token = "0x6002C69")]
			[Address(RVA = "0xCD5B90", Offset = "0xCD4B90", VA = "0x180CD5B90", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06002C6A RID: 11370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A7")]
		private IControllerTemplateDPad dPad
		{
			[Token(Token = "0x6002C6A")]
			[Address(RVA = "0xCD5BE0", Offset = "0xCD4BE0", VA = "0x180CD5BE0", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C6B")]
		[Address(RVA = "0xCD4D30", Offset = "0xCD3D30", VA = "0x180CD4D30")]
		public RacingWheelTemplate(object payload)
		{
		}

		// Token: 0x04004BD9 RID: 19417
		[Token(Token = "0x4004BD9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Guid typeGuid;

		// Token: 0x04004BDA RID: 19418
		[Token(Token = "0x4004BDA")]
		public const int elementId_wheel = 0;

		// Token: 0x04004BDB RID: 19419
		[Token(Token = "0x4004BDB")]
		public const int elementId_accelerator = 1;

		// Token: 0x04004BDC RID: 19420
		[Token(Token = "0x4004BDC")]
		public const int elementId_brake = 2;

		// Token: 0x04004BDD RID: 19421
		[Token(Token = "0x4004BDD")]
		public const int elementId_clutch = 3;

		// Token: 0x04004BDE RID: 19422
		[Token(Token = "0x4004BDE")]
		public const int elementId_shiftDown = 4;

		// Token: 0x04004BDF RID: 19423
		[Token(Token = "0x4004BDF")]
		public const int elementId_shiftUp = 5;

		// Token: 0x04004BE0 RID: 19424
		[Token(Token = "0x4004BE0")]
		public const int elementId_wheelButton1 = 6;

		// Token: 0x04004BE1 RID: 19425
		[Token(Token = "0x4004BE1")]
		public const int elementId_wheelButton2 = 7;

		// Token: 0x04004BE2 RID: 19426
		[Token(Token = "0x4004BE2")]
		public const int elementId_wheelButton3 = 8;

		// Token: 0x04004BE3 RID: 19427
		[Token(Token = "0x4004BE3")]
		public const int elementId_wheelButton4 = 9;

		// Token: 0x04004BE4 RID: 19428
		[Token(Token = "0x4004BE4")]
		public const int elementId_wheelButton5 = 10;

		// Token: 0x04004BE5 RID: 19429
		[Token(Token = "0x4004BE5")]
		public const int elementId_wheelButton6 = 11;

		// Token: 0x04004BE6 RID: 19430
		[Token(Token = "0x4004BE6")]
		public const int elementId_wheelButton7 = 12;

		// Token: 0x04004BE7 RID: 19431
		[Token(Token = "0x4004BE7")]
		public const int elementId_wheelButton8 = 13;

		// Token: 0x04004BE8 RID: 19432
		[Token(Token = "0x4004BE8")]
		public const int elementId_wheelButton9 = 14;

		// Token: 0x04004BE9 RID: 19433
		[Token(Token = "0x4004BE9")]
		public const int elementId_wheelButton10 = 15;

		// Token: 0x04004BEA RID: 19434
		[Token(Token = "0x4004BEA")]
		public const int elementId_consoleButton1 = 16;

		// Token: 0x04004BEB RID: 19435
		[Token(Token = "0x4004BEB")]
		public const int elementId_consoleButton2 = 17;

		// Token: 0x04004BEC RID: 19436
		[Token(Token = "0x4004BEC")]
		public const int elementId_consoleButton3 = 18;

		// Token: 0x04004BED RID: 19437
		[Token(Token = "0x4004BED")]
		public const int elementId_consoleButton4 = 19;

		// Token: 0x04004BEE RID: 19438
		[Token(Token = "0x4004BEE")]
		public const int elementId_consoleButton5 = 20;

		// Token: 0x04004BEF RID: 19439
		[Token(Token = "0x4004BEF")]
		public const int elementId_consoleButton6 = 21;

		// Token: 0x04004BF0 RID: 19440
		[Token(Token = "0x4004BF0")]
		public const int elementId_consoleButton7 = 22;

		// Token: 0x04004BF1 RID: 19441
		[Token(Token = "0x4004BF1")]
		public const int elementId_consoleButton8 = 23;

		// Token: 0x04004BF2 RID: 19442
		[Token(Token = "0x4004BF2")]
		public const int elementId_consoleButton9 = 24;

		// Token: 0x04004BF3 RID: 19443
		[Token(Token = "0x4004BF3")]
		public const int elementId_consoleButton10 = 25;

		// Token: 0x04004BF4 RID: 19444
		[Token(Token = "0x4004BF4")]
		public const int elementId_shifter1 = 26;

		// Token: 0x04004BF5 RID: 19445
		[Token(Token = "0x4004BF5")]
		public const int elementId_shifter2 = 27;

		// Token: 0x04004BF6 RID: 19446
		[Token(Token = "0x4004BF6")]
		public const int elementId_shifter3 = 28;

		// Token: 0x04004BF7 RID: 19447
		[Token(Token = "0x4004BF7")]
		public const int elementId_shifter4 = 29;

		// Token: 0x04004BF8 RID: 19448
		[Token(Token = "0x4004BF8")]
		public const int elementId_shifter5 = 30;

		// Token: 0x04004BF9 RID: 19449
		[Token(Token = "0x4004BF9")]
		public const int elementId_shifter6 = 31;

		// Token: 0x04004BFA RID: 19450
		[Token(Token = "0x4004BFA")]
		public const int elementId_shifter7 = 32;

		// Token: 0x04004BFB RID: 19451
		[Token(Token = "0x4004BFB")]
		public const int elementId_shifter8 = 33;

		// Token: 0x04004BFC RID: 19452
		[Token(Token = "0x4004BFC")]
		public const int elementId_shifter9 = 34;

		// Token: 0x04004BFD RID: 19453
		[Token(Token = "0x4004BFD")]
		public const int elementId_shifter10 = 35;

		// Token: 0x04004BFE RID: 19454
		[Token(Token = "0x4004BFE")]
		public const int elementId_reverseGear = 44;

		// Token: 0x04004BFF RID: 19455
		[Token(Token = "0x4004BFF")]
		public const int elementId_select = 36;

		// Token: 0x04004C00 RID: 19456
		[Token(Token = "0x4004C00")]
		public const int elementId_start = 37;

		// Token: 0x04004C01 RID: 19457
		[Token(Token = "0x4004C01")]
		public const int elementId_systemButton = 38;

		// Token: 0x04004C02 RID: 19458
		[Token(Token = "0x4004C02")]
		public const int elementId_horn = 43;

		// Token: 0x04004C03 RID: 19459
		[Token(Token = "0x4004C03")]
		public const int elementId_dPadUp = 39;

		// Token: 0x04004C04 RID: 19460
		[Token(Token = "0x4004C04")]
		public const int elementId_dPadRight = 40;

		// Token: 0x04004C05 RID: 19461
		[Token(Token = "0x4004C05")]
		public const int elementId_dPadDown = 41;

		// Token: 0x04004C06 RID: 19462
		[Token(Token = "0x4004C06")]
		public const int elementId_dPadLeft = 42;

		// Token: 0x04004C07 RID: 19463
		[Token(Token = "0x4004C07")]
		public const int elementId_dPad = 45;
	}
}
