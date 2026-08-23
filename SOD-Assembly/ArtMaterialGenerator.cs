using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200021A RID: 538
[Token(Token = "0x200021A")]
public class ArtMaterialGenerator : MonoBehaviour
{
	// Token: 0x06000C72 RID: 3186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C72")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void GenerateMaterialsAndPresets()
	{
	}

	// Token: 0x06000C73 RID: 3187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C73")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public static void SetTextureImporterFormat(Texture2D texture, bool isReadable)
	{
	}

	// Token: 0x06000C74 RID: 3188 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C74")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ArtMaterialGenerator()
	{
	}

	// Token: 0x04000D9E RID: 3486
	[Token(Token = "0x4000D9E")]
	[FieldOffset(Offset = "0x18")]
	public string textureSourceDirectory;

	// Token: 0x04000D9F RID: 3487
	[Token(Token = "0x4000D9F")]
	[FieldOffset(Offset = "0x20")]
	public string materialOutputDirectory;

	// Token: 0x04000DA0 RID: 3488
	[Token(Token = "0x4000DA0")]
	[FieldOffset(Offset = "0x28")]
	public string presetOutputDirectory;

	// Token: 0x04000DA1 RID: 3489
	[Token(Token = "0x4000DA1")]
	[FieldOffset(Offset = "0x30")]
	public ArtPreset presetTemplate;

	// Token: 0x04000DA2 RID: 3490
	[Token(Token = "0x4000DA2")]
	[FieldOffset(Offset = "0x38")]
	public Material materialTemplate;
}
