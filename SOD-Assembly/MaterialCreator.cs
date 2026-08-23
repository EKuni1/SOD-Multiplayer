using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200022F RID: 559
[Token(Token = "0x200022F")]
public class MaterialCreator : MonoBehaviour
{
	// Token: 0x06000CBB RID: 3259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CBB")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CreateMaterial()
	{
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CBC")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public static void SetTextureImporterFormat(Texture2D texture, bool isReadable)
	{
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x000071E8 File Offset: 0x000053E8
	[Token(Token = "0x6000CBD")]
	[Address(RVA = "0x59F3E0", Offset = "0x59E3E0", VA = "0x18059F3E0")]
	private float GetPixel(Texture2D tex, int x, int y)
	{
		return 0f;
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CBE")]
	public T SafeDestroyGameObject<T>(T component) where T : Component
	{
		return null;
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CBF")]
	public T SafeDestroy<T>(T obj) where T : UnityEngine.Object
	{
		return null;
	}

	// Token: 0x06000CC0 RID: 3264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CC0")]
	[Address(RVA = "0x59F440", Offset = "0x59E440", VA = "0x18059F440")]
	public MaterialCreator()
	{
	}

	// Token: 0x04000E18 RID: 3608
	[Token(Token = "0x4000E18")]
	[FieldOffset(Offset = "0x18")]
	public bool removeCollider;

	// Token: 0x04000E19 RID: 3609
	[Token(Token = "0x4000E19")]
	[FieldOffset(Offset = "0x19")]
	public bool addInteractableController;

	// Token: 0x04000E1A RID: 3610
	[Token(Token = "0x4000E1A")]
	[FieldOffset(Offset = "0x1A")]
	public bool duplicateDiffuseAndUseAsNormal;

	// Token: 0x04000E1B RID: 3611
	[Token(Token = "0x4000E1B")]
	[FieldOffset(Offset = "0x1B")]
	public bool forceColourShader;
}
