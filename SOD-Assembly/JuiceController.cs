using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005A5 RID: 1445
[Token(Token = "0x20005A5")]
public class JuiceController : MonoBehaviour
{
	// Token: 0x06001F7D RID: 8061 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F7D")]
	[Address(RVA = "0xA79AF0", Offset = "0xA78AF0", VA = "0x180A79AF0")]
	private void Start()
	{
	}

	// Token: 0x06001F7E RID: 8062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F7E")]
	[Address(RVA = "0xA7A0A0", Offset = "0xA790A0", VA = "0x180A7A0A0")]
	public void GetOriginalRectSize()
	{
	}

	// Token: 0x06001F7F RID: 8063 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F7F")]
	[Address(RVA = "0xA7A410", Offset = "0xA79410", VA = "0x180A7A410")]
	private void Update()
	{
	}

	// Token: 0x06001F80 RID: 8064 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F80")]
	[Address(RVA = "0xA7B8F0", Offset = "0xA7A8F0", VA = "0x180A7B8F0")]
	public void Flash(int newRepeat, bool colourOverride, [Optional] Color colour, float speed = 10f)
	{
	}

	// Token: 0x06001F81 RID: 8065 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F81")]
	[Address(RVA = "0xA7B980", Offset = "0xA7A980", VA = "0x180A7B980")]
	public void Pulsate(bool toggle, bool smoothOff = false)
	{
	}

	// Token: 0x06001F82 RID: 8066 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F82")]
	[Address(RVA = "0xA7BCE0", Offset = "0xA7ACE0", VA = "0x180A7BCE0")]
	public void Nudge(Vector2 scaleRange, Vector2 rotationRange, bool updateOriginalPositionFirst = true, bool affectScale = true, bool affectRotation = true)
	{
	}

	// Token: 0x06001F83 RID: 8067 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F83")]
	[Address(RVA = "0xA7C1C0", Offset = "0xA7B1C0", VA = "0x180A7C1C0")]
	public void FancyAppear(float newAppearSpeed = 2f)
	{
	}

	// Token: 0x06001F84 RID: 8068 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F84")]
	[Address(RVA = "0xA7C6E0", Offset = "0xA7B6E0", VA = "0x180A7C6E0")]
	public void FancyDisappear(float newDisappearSpeed = 2f)
	{
	}

	// Token: 0x06001F85 RID: 8069 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F85")]
	[Address(RVA = "0xA7C800", Offset = "0xA7B800", VA = "0x180A7C800")]
	private void OnDisable()
	{
	}

	// Token: 0x06001F86 RID: 8070 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F86")]
	[Address(RVA = "0xA7CCE0", Offset = "0xA7BCE0", VA = "0x180A7CCE0")]
	public void Flash()
	{
	}

	// Token: 0x06001F87 RID: 8071 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F87")]
	[Address(RVA = "0xA7CD60", Offset = "0xA7BD60", VA = "0x180A7CD60")]
	public void PulsateToggle()
	{
	}

	// Token: 0x06001F88 RID: 8072 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F88")]
	[Address(RVA = "0xA7CD80", Offset = "0xA7BD80", VA = "0x180A7CD80")]
	public void Nudge()
	{
	}

	// Token: 0x06001F89 RID: 8073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F89")]
	[Address(RVA = "0xA7CDD0", Offset = "0xA7BDD0", VA = "0x180A7CDD0")]
	public void Appear()
	{
	}

	// Token: 0x06001F8A RID: 8074 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F8A")]
	[Address(RVA = "0xA7CDE0", Offset = "0xA7BDE0", VA = "0x180A7CDE0")]
	public void Disappear()
	{
	}

	// Token: 0x06001F8B RID: 8075 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F8B")]
	[Address(RVA = "0xA7CEF0", Offset = "0xA7BEF0", VA = "0x180A7CEF0")]
	public JuiceController()
	{
	}

	// Token: 0x040028A0 RID: 10400
	[Token(Token = "0x40028A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<JuiceController.JuiceElement> elements;

	// Token: 0x040028A1 RID: 10401
	[Token(Token = "0x40028A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool pulsateActive;

	// Token: 0x040028A2 RID: 10402
	[Token(Token = "0x40028A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool pulsateScale;

	// Token: 0x040028A3 RID: 10403
	[Token(Token = "0x40028A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float pulsateProgress;

	// Token: 0x040028A4 RID: 10404
	[Token(Token = "0x40028A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool pulsateOnStart;

	// Token: 0x040028A5 RID: 10405
	[Token(Token = "0x40028A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color pulsateColour;

	// Token: 0x040028A6 RID: 10406
	[Token(Token = "0x40028A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float pulsateSpeed;

	// Token: 0x040028A7 RID: 10407
	[Token(Token = "0x40028A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool flashActive;

	// Token: 0x040028A8 RID: 10408
	[Token(Token = "0x40028A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float flashSpeed;

	// Token: 0x040028A9 RID: 10409
	[Token(Token = "0x40028A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Color flashColour;

	// Token: 0x040028AA RID: 10410
	[Token(Token = "0x40028AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int cycle;

	// Token: 0x040028AB RID: 10411
	[Token(Token = "0x40028AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float flashProgress;

	// Token: 0x040028AC RID: 10412
	[Token(Token = "0x40028AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float flashF;

	// Token: 0x040028AD RID: 10413
	[Token(Token = "0x40028AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int flashRepeat;

	// Token: 0x040028AE RID: 10414
	[Token(Token = "0x40028AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool onOff;

	// Token: 0x040028AF RID: 10415
	[Token(Token = "0x40028AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool smoothPulsateOff;

	// Token: 0x040028B0 RID: 10416
	[Token(Token = "0x40028B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	private bool nudgeActive;

	// Token: 0x040028B1 RID: 10417
	[Token(Token = "0x40028B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
	private bool nudgeState;

	// Token: 0x040028B2 RID: 10418
	[Token(Token = "0x40028B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float nudgeProgress;

	// Token: 0x040028B3 RID: 10419
	[Token(Token = "0x40028B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float amountToScale;

	// Token: 0x040028B4 RID: 10420
	[Token(Token = "0x40028B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Vector3 desiredScale;

	// Token: 0x040028B5 RID: 10421
	[Token(Token = "0x40028B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float amountToRotate;

	// Token: 0x040028B6 RID: 10422
	[Token(Token = "0x40028B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool nudgeEffectScale;

	// Token: 0x040028B7 RID: 10423
	[Token(Token = "0x40028B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
	private bool nudgeEffectRotation;

	// Token: 0x040028B8 RID: 10424
	[Token(Token = "0x40028B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
	public bool fancyAppearActive;

	// Token: 0x040028B9 RID: 10425
	[Token(Token = "0x40028B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float appearSpeed;

	// Token: 0x040028BA RID: 10426
	[Token(Token = "0x40028BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float fancyAppearProgress;

	// Token: 0x040028BB RID: 10427
	[Token(Token = "0x40028BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool fancyDisappearActive;

	// Token: 0x040028BC RID: 10428
	[Token(Token = "0x40028BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float disappearSpeed;

	// Token: 0x040028BD RID: 10429
	[Token(Token = "0x40028BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float fancyDisappearProgress;

	// Token: 0x020005A6 RID: 1446
	[Token(Token = "0x20005A6")]
	[Serializable]
	public class JuiceElement
	{
		// Token: 0x06001F8C RID: 8076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8C")]
		[Address(RVA = "0xA7D030", Offset = "0xA7C030", VA = "0x180A7D030")]
		public JuiceElement()
		{
		}

		// Token: 0x040028BE RID: 10430
		[Token(Token = "0x40028BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform transformElement;

		// Token: 0x040028BF RID: 10431
		[Token(Token = "0x40028BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Image imageElement;

		// Token: 0x040028C0 RID: 10432
		[Token(Token = "0x40028C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RawImage rawImageElement;

		// Token: 0x040028C1 RID: 10433
		[Token(Token = "0x40028C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CanvasRenderer renderer;

		// Token: 0x040028C2 RID: 10434
		[Token(Token = "0x40028C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color originalColour;

		// Token: 0x040028C3 RID: 10435
		[Token(Token = "0x40028C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool getNormalColourAtStart;

		// Token: 0x040028C4 RID: 10436
		[Token(Token = "0x40028C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 originalLocalPos;

		// Token: 0x040028C5 RID: 10437
		[Token(Token = "0x40028C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 originalLocalRot;

		// Token: 0x040028C6 RID: 10438
		[Token(Token = "0x40028C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 originalLocalScale;

		// Token: 0x040028C7 RID: 10439
		[Token(Token = "0x40028C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool getNormalTransformAtStart;
	}
}
