using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B9 RID: 697
[Token(Token = "0x20002B9")]
public class ScenePoserController : MonoBehaviour
{
	// Token: 0x06000FA8 RID: 4008 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA8")]
	[Address(RVA = "0x67DF70", Offset = "0x67CF70", VA = "0x18067DF70")]
	public void SetupCitizen(SceneRecorder.ActorCapture newCapture)
	{
	}

	// Token: 0x06000FA9 RID: 4009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA9")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ScenePoserController()
	{
	}

	// Token: 0x040012B4 RID: 4788
	[Token(Token = "0x40012B4")]
	[FieldOffset(Offset = "0x18")]
	public CitizenOutfitController outfitController;

	// Token: 0x040012B5 RID: 4789
	[Token(Token = "0x40012B5")]
	[FieldOffset(Offset = "0x20")]
	public Human human;

	// Token: 0x040012B6 RID: 4790
	[Token(Token = "0x40012B6")]
	[FieldOffset(Offset = "0x28")]
	public NewNode node;

	// Token: 0x040012B7 RID: 4791
	[Token(Token = "0x40012B7")]
	[FieldOffset(Offset = "0x30")]
	public ClothesPreset.OutfitCategory outfit;

	// Token: 0x040012B8 RID: 4792
	[Token(Token = "0x40012B8")]
	[FieldOffset(Offset = "0x38")]
	public GameObject spawnedLeft;

	// Token: 0x040012B9 RID: 4793
	[Token(Token = "0x40012B9")]
	[FieldOffset(Offset = "0x40")]
	public GameObject spawnedRight;
}
