using System;
using System.Collections.Generic;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000575 RID: 1397
[Token(Token = "0x2000575")]
public class SoundIndicatorController : MonoBehaviour
{
	// Token: 0x06001E54 RID: 7764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E54")]
	[Address(RVA = "0xA4C5E0", Offset = "0xA4B5E0", VA = "0x180A4C5E0")]
	public void SetSoundEvent(AudioEvent newEvent, bool updateEvent = true)
	{
	}

	// Token: 0x06001E55 RID: 7765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E55")]
	[Address(RVA = "0xA4C6A0", Offset = "0xA4B6A0", VA = "0x180A4C6A0")]
	public void UpdateCurrentEvent()
	{
	}

	// Token: 0x06001E56 RID: 7766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E56")]
	[Address(RVA = "0xA4D320", Offset = "0xA4C320", VA = "0x180A4D320")]
	private void Update()
	{
	}

	// Token: 0x06001E57 RID: 7767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E57")]
	[Address(RVA = "0xA4E660", Offset = "0xA4D660", VA = "0x180A4E660")]
	public SoundIndicatorController()
	{
	}

	// Token: 0x040026ED RID: 9965
	[Token(Token = "0x40026ED")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x040026EE RID: 9966
	[Token(Token = "0x40026EE")]
	[FieldOffset(Offset = "0x20")]
	public JuiceController juice;

	// Token: 0x040026EF RID: 9967
	[Token(Token = "0x40026EF")]
	[FieldOffset(Offset = "0x28")]
	public Image additionalGraphic;

	// Token: 0x040026F0 RID: 9968
	[Token(Token = "0x40026F0")]
	[FieldOffset(Offset = "0x30")]
	public bool isFootstep;

	// Token: 0x040026F1 RID: 9969
	[Token(Token = "0x40026F1")]
	[FieldOffset(Offset = "0x31")]
	public bool rightFoot;

	// Token: 0x040026F2 RID: 9970
	[Token(Token = "0x40026F2")]
	[FieldOffset(Offset = "0x38")]
	public AudioEvent currentEvent;

	// Token: 0x040026F3 RID: 9971
	[Token(Token = "0x40026F3")]
	[FieldOffset(Offset = "0x40")]
	private EventDescription description;

	// Token: 0x040026F4 RID: 9972
	[Token(Token = "0x40026F4")]
	[FieldOffset(Offset = "0x48")]
	public List<AudioController.ActiveListener> currentListeners;

	// Token: 0x040026F5 RID: 9973
	[Token(Token = "0x40026F5")]
	[FieldOffset(Offset = "0x50")]
	public float currentHearingRange;

	// Token: 0x040026F6 RID: 9974
	[Token(Token = "0x40026F6")]
	[FieldOffset(Offset = "0x54")]
	public int currentIconCount;

	// Token: 0x040026F7 RID: 9975
	[Token(Token = "0x40026F7")]
	[FieldOffset(Offset = "0x58")]
	private int previousIconCount;

	// Token: 0x040026F8 RID: 9976
	[Token(Token = "0x40026F8")]
	[FieldOffset(Offset = "0x5C")]
	public float colourLerp;

	// Token: 0x040026F9 RID: 9977
	[Token(Token = "0x40026F9")]
	[FieldOffset(Offset = "0x60")]
	public Color col;

	// Token: 0x040026FA RID: 9978
	[Token(Token = "0x40026FA")]
	[FieldOffset(Offset = "0x70")]
	public Vector2 iconOffset;

	// Token: 0x040026FB RID: 9979
	[Token(Token = "0x40026FB")]
	[FieldOffset(Offset = "0x78")]
	public List<SoundIndicatorController.AudioIcon> spawnedIcons;

	// Token: 0x040026FC RID: 9980
	[Token(Token = "0x40026FC")]
	[FieldOffset(Offset = "0x80")]
	public List<SoundIndicatorController.AudioIcon> fullIcons;

	// Token: 0x02000576 RID: 1398
	[Token(Token = "0x2000576")]
	[Serializable]
	public class AudioIcon
	{
		// Token: 0x06001E58 RID: 7768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E58")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public AudioIcon()
		{
		}

		// Token: 0x040026FD RID: 9981
		[Token(Token = "0x40026FD")]
		[FieldOffset(Offset = "0x10")]
		public RectTransform rect;

		// Token: 0x040026FE RID: 9982
		[Token(Token = "0x40026FE")]
		[FieldOffset(Offset = "0x18")]
		public Image img;

		// Token: 0x040026FF RID: 9983
		[Token(Token = "0x40026FF")]
		[FieldOffset(Offset = "0x20")]
		public float fadeIn;

		// Token: 0x04002700 RID: 9984
		[Token(Token = "0x4002700")]
		[FieldOffset(Offset = "0x24")]
		public bool remove;
	}
}
