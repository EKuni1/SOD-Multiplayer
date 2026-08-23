using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002DB RID: 731
[Token(Token = "0x20002DB")]
public class SecurityApp : CruncherAppContent
{
	// Token: 0x0600102D RID: 4141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102D")]
	[Address(RVA = "0x693C70", Offset = "0x692C70", VA = "0x180693C70", Slot = "5")]
	public override void OnSetup()
	{
	}

	// Token: 0x0600102E RID: 4142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102E")]
	[Address(RVA = "0x6943C0", Offset = "0x6933C0", VA = "0x1806943C0")]
	public void SetCamera(Interactable newSelection)
	{
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102F")]
	[Address(RVA = "0x694A40", Offset = "0x693A40", VA = "0x180694A40")]
	private void Update()
	{
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001030")]
	[Address(RVA = "0x694DB0", Offset = "0x693DB0", VA = "0x180694DB0")]
	public void CameraSelection(int addSelection)
	{
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001031")]
	[Address(RVA = "0x694ED0", Offset = "0x693ED0", VA = "0x180694ED0")]
	public void AlarmTargetSelection(int addSelection)
	{
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001032")]
	[Address(RVA = "0x68D560", Offset = "0x68C560", VA = "0x18068D560")]
	public void ExitButton()
	{
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001033")]
	[Address(RVA = "0x6953B0", Offset = "0x6943B0", VA = "0x1806953B0")]
	public void SetCamActiveButton(bool val)
	{
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001034")]
	[Address(RVA = "0x6954A0", Offset = "0x6944A0", VA = "0x1806954A0")]
	public void SetAlarmActiveButton(bool val)
	{
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001035")]
	[Address(RVA = "0x6956E0", Offset = "0x6946E0", VA = "0x1806956E0")]
	private void UpdateCamStatus()
	{
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001036")]
	[Address(RVA = "0x696010", Offset = "0x695010", VA = "0x180696010")]
	public SecurityApp()
	{
	}

	// Token: 0x06001037 RID: 4151 RVA: 0x00008448 File Offset: 0x00006648
	[Token(Token = "0x6001037")]
	[Address(RVA = "0x6961B0", Offset = "0x6951B0", VA = "0x1806961B0")]
	private bool <SetCamera>b__22_0(Interactable item)
	{
		return default(bool);
	}

	// Token: 0x04001358 RID: 4952
	[Token(Token = "0x4001358")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI titleText;

	// Token: 0x04001359 RID: 4953
	[Token(Token = "0x4001359")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI cameraSelectionText;

	// Token: 0x0400135A RID: 4954
	[Token(Token = "0x400135A")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI targetSelectionText;

	// Token: 0x0400135B RID: 4955
	[Token(Token = "0x400135B")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI locationstampText;

	// Token: 0x0400135C RID: 4956
	[Token(Token = "0x400135C")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI locationstampTextShadow;

	// Token: 0x0400135D RID: 4957
	[Token(Token = "0x400135D")]
	[FieldOffset(Offset = "0x48")]
	public RenderTexture renderTexturePrefab;

	// Token: 0x0400135E RID: 4958
	[Token(Token = "0x400135E")]
	[FieldOffset(Offset = "0x50")]
	public RawImage captureDisplay;

	// Token: 0x0400135F RID: 4959
	[Token(Token = "0x400135F")]
	[FieldOffset(Offset = "0x58")]
	public RectTransform captureRect;

	// Token: 0x04001360 RID: 4960
	[Token(Token = "0x4001360")]
	[FieldOffset(Offset = "0x60")]
	public Button camOnButton;

	// Token: 0x04001361 RID: 4961
	[Token(Token = "0x4001361")]
	[FieldOffset(Offset = "0x68")]
	public Button camOffButton;

	// Token: 0x04001362 RID: 4962
	[Token(Token = "0x4001362")]
	[FieldOffset(Offset = "0x70")]
	public Button alarmOnButton;

	// Token: 0x04001363 RID: 4963
	[Token(Token = "0x4001363")]
	[FieldOffset(Offset = "0x78")]
	public Button alarmOffButton;

	// Token: 0x04001364 RID: 4964
	[Token(Token = "0x4001364")]
	[FieldOffset(Offset = "0x80")]
	public RectTransform camDisplayPageRect;

	// Token: 0x04001365 RID: 4965
	[Token(Token = "0x4001365")]
	[FieldOffset(Offset = "0x88")]
	public TextMeshProUGUI camOnText;

	// Token: 0x04001366 RID: 4966
	[Token(Token = "0x4001366")]
	[FieldOffset(Offset = "0x90")]
	public TextMeshProUGUI camOffText;

	// Token: 0x04001367 RID: 4967
	[Token(Token = "0x4001367")]
	[FieldOffset(Offset = "0x98")]
	public TextMeshProUGUI alarmOnText;

	// Token: 0x04001368 RID: 4968
	[Token(Token = "0x4001368")]
	[FieldOffset(Offset = "0xA0")]
	public TextMeshProUGUI alarmOffText;

	// Token: 0x04001369 RID: 4969
	[Token(Token = "0x4001369")]
	[FieldOffset(Offset = "0xA8")]
	public List<Interactable> cameras;

	// Token: 0x0400136A RID: 4970
	[Token(Token = "0x400136A")]
	[FieldOffset(Offset = "0xB0")]
	[NonSerialized]
	public Interactable selectedCamera;

	// Token: 0x0400136B RID: 4971
	[Token(Token = "0x400136B")]
	[FieldOffset(Offset = "0xB8")]
	public List<Interactable> selectedSentries;

	// Token: 0x0400136C RID: 4972
	[Token(Token = "0x400136C")]
	[FieldOffset(Offset = "0xC0")]
	private float camUpdateTimer;
}
