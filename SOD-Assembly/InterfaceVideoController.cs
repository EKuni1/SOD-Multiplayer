using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

// Token: 0x020005A4 RID: 1444
[Token(Token = "0x20005A4")]
public class InterfaceVideoController : MonoBehaviour
{
	// Token: 0x06001F7A RID: 8058 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F7A")]
	[Address(RVA = "0xA792D0", Offset = "0xA782D0", VA = "0x180A792D0")]
	public void Setup(VideoClip clip, Texture2D img)
	{
	}

	// Token: 0x06001F7B RID: 8059 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F7B")]
	[Address(RVA = "0xA79980", Offset = "0xA78980", VA = "0x180A79980")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001F7C RID: 8060 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F7C")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public InterfaceVideoController()
	{
	}

	// Token: 0x0400289C RID: 10396
	[Token(Token = "0x400289C")]
	[FieldOffset(Offset = "0x18")]
	public VideoPlayer player;

	// Token: 0x0400289D RID: 10397
	[Token(Token = "0x400289D")]
	[FieldOffset(Offset = "0x20")]
	public RawImage image;

	// Token: 0x0400289E RID: 10398
	[Token(Token = "0x400289E")]
	[FieldOffset(Offset = "0x28")]
	public RenderTexture renderTexturePrefab;

	// Token: 0x0400289F RID: 10399
	[Token(Token = "0x400289F")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture renderTextureInstance;
}
