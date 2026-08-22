using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000540 RID: 1344
[Token(Token = "0x2000540")]
public class PrecipitationParticleSystemController : MonoBehaviour
{
	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x06001D45 RID: 7493 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000E5")]
	public static PrecipitationParticleSystemController Instance
	{
		[Token(Token = "0x6001D45")]
		[Address(RVA = "0xA19E90", Offset = "0xA18E90", VA = "0x180A19E90")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D46")]
	[Address(RVA = "0xA19ED0", Offset = "0xA18ED0", VA = "0x180A19ED0")]
	private void Awake()
	{
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D47")]
	[Address(RVA = "0xA1A230", Offset = "0xA19230", VA = "0x180A1A230")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001D48 RID: 7496 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D48")]
	[Address(RVA = "0xA1A440", Offset = "0xA19440", VA = "0x180A1A440")]
	public void SetSnowMode(bool val, bool forceUpdate = false)
	{
	}

	// Token: 0x06001D49 RID: 7497 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D49")]
	[Address(RVA = "0xA1A590", Offset = "0xA19590", VA = "0x180A1A590")]
	public void SetEnabled(bool val)
	{
	}

	// Token: 0x06001D4A RID: 7498 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D4A")]
	[Address(RVA = "0xA1A8B0", Offset = "0xA198B0", VA = "0x180A1A8B0")]
	public void AddAreaTrigger(Collider coll)
	{
	}

	// Token: 0x06001D4B RID: 7499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D4B")]
	[Address(RVA = "0xA1AA50", Offset = "0xA19A50", VA = "0x180A1AA50")]
	public void RemoveAreaTrigger(Collider coll)
	{
	}

	// Token: 0x06001D4C RID: 7500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D4C")]
	[Address(RVA = "0xA1ABF0", Offset = "0xA19BF0", VA = "0x180A1ABF0")]
	private void Update()
	{
	}

	// Token: 0x06001D4D RID: 7501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D4D")]
	[Address(RVA = "0xA1B320", Offset = "0xA1A320", VA = "0x180A1B320")]
	public PrecipitationParticleSystemController()
	{
	}

	// Token: 0x040025C1 RID: 9665
	[Token(Token = "0x40025C1")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem snowSystem;

	// Token: 0x040025C2 RID: 9666
	[Token(Token = "0x40025C2")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem rainSystem;

	// Token: 0x040025C3 RID: 9667
	[Token(Token = "0x40025C3")]
	[FieldOffset(Offset = "0x28")]
	public int snowMaxEmissionRate;

	// Token: 0x040025C4 RID: 9668
	[Token(Token = "0x40025C4")]
	[FieldOffset(Offset = "0x2C")]
	public int rainMaxEmissionRate;

	// Token: 0x040025C5 RID: 9669
	[Token(Token = "0x40025C5")]
	[FieldOffset(Offset = "0x30")]
	public bool snowMode;

	// Token: 0x040025C6 RID: 9670
	[Token(Token = "0x40025C6")]
	[FieldOffset(Offset = "0x0")]
	private static PrecipitationParticleSystemController _instance;
}
