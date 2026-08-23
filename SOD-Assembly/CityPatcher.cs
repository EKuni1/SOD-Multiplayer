using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200021C RID: 540
[Token(Token = "0x200021C")]
public class CityPatcher : MonoBehaviour
{
	// Token: 0x06000C7B RID: 3195 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C7B")]
	[Address(RVA = "0x598610", Offset = "0x597610", VA = "0x180598610")]
	public void PatchCity()
	{
	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C7C")]
	[Address(RVA = "0x598CA0", Offset = "0x597CA0", VA = "0x180598CA0")]
	private void LoadFullCityData()
	{
	}

	// Token: 0x06000C7D RID: 3197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C7D")]
	[Address(RVA = "0x599230", Offset = "0x598230", VA = "0x180599230")]
	private void SaveCityData()
	{
	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public CityPatcher()
	{
	}

	// Token: 0x04000DAC RID: 3500
	[Token(Token = "0x4000DAC")]
	[FieldOffset(Offset = "0x18")]
	public string inputCityPath;

	// Token: 0x04000DAD RID: 3501
	[Token(Token = "0x4000DAD")]
	[FieldOffset(Offset = "0x20")]
	private FileInfo loadCityFileInfo;

	// Token: 0x04000DAE RID: 3502
	[Token(Token = "0x4000DAE")]
	[FieldOffset(Offset = "0x28")]
	private CitySaveData currentData;

	// Token: 0x0200021D RID: 541
	[Token(Token = "0x200021D")]
	private sealed class <>c__DisplayClass3_0
	{
		// Token: 0x06000C7F RID: 3199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass3_0()
		{
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00007158 File Offset: 0x00005358
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x599460", Offset = "0x598460", VA = "0x180599460")]
		internal bool <PatchCity>b__0(Citizen item)
		{
			return default(bool);
		}

		// Token: 0x04000DAF RID: 3503
		[Token(Token = "0x4000DAF")]
		[FieldOffset(Offset = "0x10")]
		public CitySaveData.HumanCitySave h;
	}
}
