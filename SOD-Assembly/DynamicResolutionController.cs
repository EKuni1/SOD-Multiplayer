using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000307 RID: 775
[Token(Token = "0x2000307")]
public class DynamicResolutionController : MonoBehaviour
{
	// Token: 0x17000090 RID: 144
	// (get) Token: 0x060010FE RID: 4350 RVA: 0x00008628 File Offset: 0x00006828
	// (set) Token: 0x060010FF RID: 4351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000090")]
	public bool DynamicResolutionEnabled
	{
		[Token(Token = "0x60010FE")]
		[Address(RVA = "0x6B74A0", Offset = "0x6B64A0", VA = "0x1806B74A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60010FF")]
		[Address(RVA = "0x6B74B0", Offset = "0x6B64B0", VA = "0x1806B74B0")]
		set
		{
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06001100 RID: 4352 RVA: 0x00008640 File Offset: 0x00006840
	// (set) Token: 0x06001101 RID: 4353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000091")]
	public bool DLSSEnabled
	{
		[Token(Token = "0x6001100")]
		[Address(RVA = "0x6B74C0", Offset = "0x6B64C0", VA = "0x1806B74C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001101")]
		[Address(RVA = "0x6B74D0", Offset = "0x6B64D0", VA = "0x1806B74D0")]
		set
		{
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06001102 RID: 4354 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000092")]
	public static DynamicResolutionController Instance
	{
		[Token(Token = "0x6001102")]
		[Address(RVA = "0x6B74E0", Offset = "0x6B64E0", VA = "0x1806B74E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001103")]
	[Address(RVA = "0x6B7520", Offset = "0x6B6520", VA = "0x1806B7520")]
	private void Awake()
	{
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001104")]
	[Address(RVA = "0x6B7870", Offset = "0x6B6870", VA = "0x1806B7870")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001105 RID: 4357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001105")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	private void Start()
	{
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001106")]
	[Address(RVA = "0x6B7A80", Offset = "0x6B6A80", VA = "0x1806B7A80")]
	public void SetDynamicResolutionEnabled(bool enable)
	{
	}

	// Token: 0x06001107 RID: 4359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001107")]
	[Address(RVA = "0x6B7C70", Offset = "0x6B6C70", VA = "0x1806B7C70")]
	public void SetDLSSEnabled(bool enable)
	{
	}

	// Token: 0x06001108 RID: 4360 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001108")]
	[Address(RVA = "0x6B83B0", Offset = "0x6B73B0", VA = "0x1806B83B0")]
	public void SetDLSSQualityMode(DynamicResolutionController.DLSSQuality quality)
	{
	}

	// Token: 0x06001109 RID: 4361 RVA: 0x00008658 File Offset: 0x00006858
	[Token(Token = "0x6001109")]
	[Address(RVA = "0x6B85A0", Offset = "0x6B75A0", VA = "0x1806B85A0")]
	private uint ConvertDLSSQualityValue(DynamicResolutionController.DLSSQuality quality)
	{
		return 0U;
	}

	// Token: 0x0600110A RID: 4362 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600110A")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public DynamicResolutionController()
	{
	}

	// Token: 0x040014C0 RID: 5312
	[Token(Token = "0x40014C0")]
	[FieldOffset(Offset = "0x18")]
	public List<HDAdditionalCameraData> AllHDCameras;

	// Token: 0x040014C1 RID: 5313
	[Token(Token = "0x40014C1")]
	[FieldOffset(Offset = "0x20")]
	private bool dynamicResolutionEnabled;

	// Token: 0x040014C2 RID: 5314
	[Token(Token = "0x40014C2")]
	[FieldOffset(Offset = "0x21")]
	private bool dlssEnabled;

	// Token: 0x040014C3 RID: 5315
	[Token(Token = "0x40014C3")]
	[FieldOffset(Offset = "0x0")]
	private static DynamicResolutionController _instance;

	// Token: 0x02000308 RID: 776
	[Token(Token = "0x2000308")]
	public enum DLSSQuality
	{
		// Token: 0x040014C5 RID: 5317
		[Token(Token = "0x40014C5")]
		MaximumPerformance,
		// Token: 0x040014C6 RID: 5318
		[Token(Token = "0x40014C6")]
		Balanced,
		// Token: 0x040014C7 RID: 5319
		[Token(Token = "0x40014C7")]
		MaximumQuality,
		// Token: 0x040014C8 RID: 5320
		[Token(Token = "0x40014C8")]
		UltraPerformance
	}
}
