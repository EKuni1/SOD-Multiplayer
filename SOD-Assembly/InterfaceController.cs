using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200058B RID: 1419
[Token(Token = "0x200058B")]
public class InterfaceController : MonoBehaviour
{
	// Token: 0x1400002F RID: 47
	// (add) Token: 0x06001EC5 RID: 7877 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001EC6 RID: 7878 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400002F")]
	public event InterfaceController.InputCode OnInputCode
	{
		[Token(Token = "0x6001EC5")]
		[Address(RVA = "0xA5AA30", Offset = "0xA59A30", VA = "0x180A5AA30")]
		add
		{
		}
		[Token(Token = "0x6001EC6")]
		[Address(RVA = "0xA5AB30", Offset = "0xA59B30", VA = "0x180A5AB30")]
		remove
		{
		}
	}

	// Token: 0x14000030 RID: 48
	// (add) Token: 0x06001EC7 RID: 7879 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001EC8 RID: 7880 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000030")]
	public event InterfaceController.NewActiveCodeInput OnNewActiveCodeInput
	{
		[Token(Token = "0x6001EC7")]
		[Address(RVA = "0xA5AC30", Offset = "0xA59C30", VA = "0x180A5AC30")]
		add
		{
		}
		[Token(Token = "0x6001EC8")]
		[Address(RVA = "0xA5AD30", Offset = "0xA59D30", VA = "0x180A5AD30")]
		remove
		{
		}
	}

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000FA")]
	public static InterfaceController Instance
	{
		[Token(Token = "0x6001EC9")]
		[Address(RVA = "0xA5AE30", Offset = "0xA59E30", VA = "0x180A5AE30")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001ECA RID: 7882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ECA")]
	[Address(RVA = "0xA5AE90", Offset = "0xA59E90", VA = "0x180A5AE90")]
	private void Awake()
	{
	}

	// Token: 0x06001ECB RID: 7883 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ECB")]
	[Address(RVA = "0xA5B230", Offset = "0xA5A230", VA = "0x180A5B230")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001ECC RID: 7884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ECC")]
	[Address(RVA = "0xA5B4F0", Offset = "0xA5A4F0", VA = "0x180A5B4F0")]
	private void Start()
	{
	}

	// Token: 0x06001ECD RID: 7885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ECD")]
	[Address(RVA = "0xA5BE70", Offset = "0xA5AE70", VA = "0x180A5BE70")]
	private void Update()
	{
	}

	// Token: 0x06001ECE RID: 7886 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ECE")]
	[Address(RVA = "0xA602D0", Offset = "0xA5F2D0", VA = "0x180A602D0")]
	public void UpdateDOF()
	{
	}

	// Token: 0x06001ECF RID: 7887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ECF")]
	[Address(RVA = "0xA61040", Offset = "0xA60040", VA = "0x180A61040")]
	public void DeselectAllPins()
	{
	}

	// Token: 0x06001ED0 RID: 7888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ED0")]
	[Address(RVA = "0xA61390", Offset = "0xA60390", VA = "0x180A61390")]
	public void UpdateAnchoredSpeechPositions()
	{
	}

	// Token: 0x06001ED1 RID: 7889 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ED1")]
	[Address(RVA = "0xA61AD0", Offset = "0xA60AD0", VA = "0x180A61AD0")]
	public InterfaceController.AwarenessIcon AddAwarenessIcon(InterfaceController.AwarenessType newType, InterfaceController.AwarenessBehaviour newBehaviour, Actor newActor, Transform newTransform, Vector3 newPosition, Material newMat, int newPriority, bool forceMaxDistance = false, float maxDist = 20f)
	{
		return null;
	}

	// Token: 0x06001ED2 RID: 7890 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ED2")]
	[Address(RVA = "0xA62C70", Offset = "0xA61C70", VA = "0x180A62C70")]
	public UIPointerController AddUIPointer(Objective newObjective)
	{
		return null;
	}

	// Token: 0x06001ED3 RID: 7891 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ED3")]
	[Address(RVA = "0xA62D80", Offset = "0xA61D80", VA = "0x180A62D80")]
	public InfoWindow SpawnWindow(Evidence passedEvidence, Evidence.DataKey passedEvidenceKey = Evidence.DataKey.name, [Optional] List<Evidence.DataKey> passedEvidenceKeys, string presetName = "", bool worldInteraction = false, bool autoPosition = true, [Optional] Vector2 forcePosition, [Optional] Interactable passedInteractable, [Optional] Case passedCase, [Optional] Case.CaseElement forcedPinnedElement, bool passDialogSuccess = true)
	{
		return null;
	}

	// Token: 0x06001ED4 RID: 7892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ED4")]
	[Address(RVA = "0xA64AC0", Offset = "0xA63AC0", VA = "0x180A64AC0")]
	public void SetDragged(GameObject drag, string tag, Vector2 dCursorOffset)
	{
	}

	// Token: 0x06001ED5 RID: 7893 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ED5")]
	[Address(RVA = "0xA64B90", Offset = "0xA63B90", VA = "0x180A64B90")]
	public InfoWindow GetWindow(Evidence winEntry)
	{
		return null;
	}

	// Token: 0x06001ED6 RID: 7894 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ED6")]
	[Address(RVA = "0xA64D40", Offset = "0xA63D40", VA = "0x180A64D40")]
	public InfoWindow GetWindow(Evidence winEntry, List<Evidence.DataKey> evKeys)
	{
		return null;
	}

	// Token: 0x06001ED7 RID: 7895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ED7")]
	[Address(RVA = "0xA65140", Offset = "0xA64140", VA = "0x180A65140")]
	public void MinimizeWindow(InfoWindow window)
	{
	}

	// Token: 0x06001ED8 RID: 7896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ED8")]
	[Address(RVA = "0xA655E0", Offset = "0xA645E0", VA = "0x180A655E0")]
	public void RestoreWindow(InfoWindow window)
	{
	}

	// Token: 0x06001ED9 RID: 7897 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ED9")]
	[Address(RVA = "0xA65C60", Offset = "0xA64C60", VA = "0x180A65C60")]
	private IEnumerator WindowScaleAnimation(InfoWindow window, Vector2 toPosition, Vector2 toPivot, Vector3 toScale, bool removeAtEnd)
	{
		return null;
	}

	// Token: 0x06001EDA RID: 7898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EDA")]
	[Address(RVA = "0xA65D60", Offset = "0xA64D60", VA = "0x180A65D60")]
	public void RemoveAllMouseInteractionComponents()
	{
	}

	// Token: 0x06001EDB RID: 7899 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EDB")]
	[Address(RVA = "0xA65FA0", Offset = "0xA64FA0", VA = "0x180A65FA0")]
	public void DisplayLocationText(float duration, bool forceUpdate)
	{
	}

	// Token: 0x06001EDC RID: 7900 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EDC")]
	[Address(RVA = "0xA66100", Offset = "0xA65100", VA = "0x180A66100")]
	private IEnumerator DisplayLocText(float duration, bool forceUpdate = false)
	{
		return null;
	}

	// Token: 0x06001EDD RID: 7901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EDD")]
	[Address(RVA = "0xA661D0", Offset = "0xA651D0", VA = "0x180A661D0")]
	public void ShowLocationText(float fadeSpeed)
	{
	}

	// Token: 0x06001EDE RID: 7902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EDE")]
	[Address(RVA = "0xA66360", Offset = "0xA65360", VA = "0x180A66360")]
	public void HideLocationText(float fadeSpeed)
	{
	}

	// Token: 0x06001EDF RID: 7903 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EDF")]
	[Address(RVA = "0xA664F0", Offset = "0xA654F0", VA = "0x180A664F0")]
	private IEnumerator LocationTextFade(bool show = true, float fadeSpeed = 1f)
	{
		return null;
	}

	// Token: 0x06001EE0 RID: 7904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EE0")]
	[Address(RVA = "0xA665C0", Offset = "0xA655C0", VA = "0x180A665C0")]
	public void OpenCurrentLocationAsEvidence()
	{
	}

	// Token: 0x06001EE1 RID: 7905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EE1")]
	[Address(RVA = "0xA669D0", Offset = "0xA659D0", VA = "0x180A669D0")]
	public void OpenApartmentAsEvidence()
	{
	}

	// Token: 0x06001EE2 RID: 7906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EE2")]
	[Address(RVA = "0xA66EC0", Offset = "0xA65EC0", VA = "0x180A66EC0")]
	public void SetInterfaceActive(bool val)
	{
	}

	// Token: 0x06001EE3 RID: 7907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EE3")]
	[Address(RVA = "0xA670F0", Offset = "0xA660F0", VA = "0x180A670F0")]
	public void SetDesktopMode(bool val, bool showPanels)
	{
	}

	// Token: 0x06001EE4 RID: 7908 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EE4")]
	[Address(RVA = "0xA687D0", Offset = "0xA677D0", VA = "0x180A687D0")]
	public void ToggleSetShowDesktopMap()
	{
	}

	// Token: 0x06001EE5 RID: 7909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EE5")]
	[Address(RVA = "0xA68800", Offset = "0xA67800", VA = "0x180A68800")]
	public void SetShowDesktopMap(bool val, bool playSound)
	{
	}

	// Token: 0x06001EE6 RID: 7910 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EE6")]
	[Address(RVA = "0xA688C0", Offset = "0xA678C0", VA = "0x180A688C0")]
	public void ShowDesktopMap(bool val, bool playSound)
	{
	}

	// Token: 0x06001EE7 RID: 7911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EE7")]
	[Address(RVA = "0xA68C20", Offset = "0xA67C20", VA = "0x180A68C20")]
	public void ToggleShowInventory()
	{
	}

	// Token: 0x06001EE8 RID: 7912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EE8")]
	[Address(RVA = "0xA68CC0", Offset = "0xA67CC0", VA = "0x180A68CC0")]
	public void ToggleSetShowDesktopCaseBoard()
	{
	}

	// Token: 0x06001EE9 RID: 7913 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EE9")]
	[Address(RVA = "0xA68CE0", Offset = "0xA67CE0", VA = "0x180A68CE0")]
	public void SetShowDesktopCaseBoard(bool val)
	{
	}

	// Token: 0x06001EEA RID: 7914 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EEA")]
	[Address(RVA = "0xA68E50", Offset = "0xA67E50", VA = "0x180A68E50")]
	public void ShowCaseBoard(bool val)
	{
	}

	// Token: 0x06001EEB RID: 7915 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EEB")]
	[Address(RVA = "0xA694D0", Offset = "0xA684D0", VA = "0x180A694D0")]
	public void SetBackgroundBlur(bool val)
	{
	}

	// Token: 0x06001EEC RID: 7916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EEC")]
	[Address(RVA = "0xA69640", Offset = "0xA68640", VA = "0x180A69640")]
	public void NewHelpPointer(string helpSection)
	{
	}

	// Token: 0x06001EED RID: 7917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EED")]
	[Address(RVA = "0xA69910", Offset = "0xA68910", VA = "0x180A69910")]
	public void NewGameMessage(InterfaceController.GameMessageType newType, int newNumerical, string newMessage, InterfaceControls.Icon newIcon = InterfaceControls.Icon.agent, [Optional] AudioEvent additionalSFX, bool colourOverride = false, [Optional] Color col, int newMergeType = -1, float newMessageDelay = 0f, [Optional] RectTransform moveToOnDestroy, GameMessageController.PingOnComplete ping = GameMessageController.PingOnComplete.none, [Optional] Evidence keyMergeEvidence, [Optional] List<Evidence.DataKey> keyMergeKeys, [Optional] Sprite iconOverride)
	{
	}

	// Token: 0x06001EEE RID: 7918 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EEE")]
	[Address(RVA = "0xA6A110", Offset = "0xA69110", VA = "0x180A6A110")]
	private IEnumerator GameMessages()
	{
		return null;
	}

	// Token: 0x06001EEF RID: 7919 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EEF")]
	[Address(RVA = "0xA6A1B0", Offset = "0xA691B0", VA = "0x180A6A1B0")]
	private void PlayTypewriterKey()
	{
	}

	// Token: 0x06001EF0 RID: 7920 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EF0")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	private void PlayTypewriterSpace()
	{
	}

	// Token: 0x06001EF1 RID: 7921 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EF1")]
	[Address(RVA = "0xA6A260", Offset = "0xA69260", VA = "0x180A6A260")]
	public void ToggleNotebookButton()
	{
	}

	// Token: 0x06001EF2 RID: 7922 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EF2")]
	[Address(RVA = "0xA6A2B0", Offset = "0xA692B0", VA = "0x180A6A2B0")]
	public void ToggleNotebook(string startingPage = "", bool openHelpSection = false)
	{
	}

	// Token: 0x06001EF3 RID: 7923 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EF3")]
	[Address(RVA = "0xA6ABE0", Offset = "0xA69BE0", VA = "0x180A6ABE0")]
	public void OpenNotebookNoPause(string startingPage = "", bool openHelpSection = false)
	{
	}

	// Token: 0x06001EF4 RID: 7924 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EF4")]
	[Address(RVA = "0xA6B1B0", Offset = "0xA6A1B0", VA = "0x180A6B1B0")]
	public void ResetToggleNotebookButton()
	{
	}

	// Token: 0x06001EF5 RID: 7925 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EF5")]
	[Address(RVA = "0xA6B380", Offset = "0xA6A380", VA = "0x180A6B380")]
	public void ToggleUpgrades()
	{
	}

	// Token: 0x06001EF6 RID: 7926 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EF6")]
	[Address(RVA = "0xA6B550", Offset = "0xA6A550", VA = "0x180A6B550")]
	public void EvaluateActiveControllerViewRectScroll()
	{
	}

	// Token: 0x06001EF7 RID: 7927 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EF7")]
	[Address(RVA = "0xA6C010", Offset = "0xA6B010", VA = "0x180A6C010")]
	public void Fade(float fadeVal, float newFadeTime = 2f, bool newFadeAudio = false)
	{
	}

	// Token: 0x06001EF8 RID: 7928 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EF8")]
	[Address(RVA = "0xA6C1A0", Offset = "0xA6B1A0", VA = "0x180A6C1A0")]
	private IEnumerator FadeGame()
	{
		return null;
	}

	// Token: 0x06001EF9 RID: 7929 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EF9")]
	[Address(RVA = "0xA6C240", Offset = "0xA6B240", VA = "0x180A6C240")]
	private IEnumerator DesktopModeTransition()
	{
		return null;
	}

	// Token: 0x06001EFA RID: 7930 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EFA")]
	[Address(RVA = "0xA6C2E0", Offset = "0xA6B2E0", VA = "0x180A6C2E0")]
	public void InputCodeButton(List<int> code)
	{
	}

	// Token: 0x06001EFB RID: 7931 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EFB")]
	[Address(RVA = "0xA6C310", Offset = "0xA6B310", VA = "0x180A6C310")]
	public void AddMouseOverElement(MonoBehaviour mono)
	{
	}

	// Token: 0x06001EFC RID: 7932 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EFC")]
	[Address(RVA = "0xA6C4F0", Offset = "0xA6B4F0", VA = "0x180A6C4F0")]
	public void RemoveMouseOverElement(MonoBehaviour mono)
	{
	}

	// Token: 0x06001EFD RID: 7933 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EFD")]
	[Address(RVA = "0xA6C630", Offset = "0xA6B630", VA = "0x180A6C630")]
	public void ClearAllMouseOverElements()
	{
	}

	// Token: 0x06001EFE RID: 7934 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EFE")]
	[Address(RVA = "0xA6C700", Offset = "0xA6B700", VA = "0x180A6C700")]
	public void UpdateCursorSprite()
	{
	}

	// Token: 0x06001EFF RID: 7935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EFF")]
	[Address(RVA = "0xA6D6C0", Offset = "0xA6C6C0", VA = "0x180A6D6C0")]
	public void SetCursorGraphic(Texture2D mouseImage, Vector2 size, CursorMode cursorMode = CursorMode.Auto)
	{
	}

	// Token: 0x06001F00 RID: 7936 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F00")]
	[Address(RVA = "0xA6DBD0", Offset = "0xA6CBD0", VA = "0x180A6DBD0")]
	public void MinimizeAll()
	{
	}

	// Token: 0x06001F01 RID: 7937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F01")]
	[Address(RVA = "0xA6DC90", Offset = "0xA6CC90", VA = "0x180A6DC90")]
	public void ShowWindowFocus()
	{
	}

	// Token: 0x06001F02 RID: 7938 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F02")]
	[Address(RVA = "0xA6DF60", Offset = "0xA6CF60", VA = "0x180A6DF60")]
	public void RemoveWindowFocus()
	{
	}

	// Token: 0x06001F03 RID: 7939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F03")]
	[Address(RVA = "0xA6E170", Offset = "0xA6D170", VA = "0x180A6E170")]
	public void CrosshairReaction()
	{
	}

	// Token: 0x06001F04 RID: 7940 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
	[Token(Token = "0x6001F04")]
	[Address(RVA = "0xA6E270", Offset = "0xA6D270", VA = "0x180A6E270")]
	public Color GetEvidenceColour(InterfaceControls.EvidenceColours col)
	{
		return default(Color);
	}

	// Token: 0x06001F05 RID: 7941 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F05")]
	[Address(RVA = "0xA6E3B0", Offset = "0xA6D3B0", VA = "0x180A6E3B0")]
	public void PingLockpicks()
	{
	}

	// Token: 0x06001F06 RID: 7942 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F06")]
	[Address(RVA = "0xA6E460", Offset = "0xA6D460", VA = "0x180A6E460")]
	public void PingMoney()
	{
	}

	// Token: 0x06001F07 RID: 7943 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F07")]
	[Address(RVA = "0xA6E510", Offset = "0xA6D510", VA = "0x180A6E510")]
	private IEnumerator ExecutePing(RectTransform pingRect, JuiceController pingJuice, TextMeshProUGUI textPing, int originalValue, List<CanvasRenderer> renderers, bool isMoney)
	{
		return null;
	}

	// Token: 0x06001F08 RID: 7944 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F08")]
	[Address(RVA = "0xA6E740", Offset = "0xA6D740", VA = "0x180A6E740")]
	public void SetCrosshairVisible(bool val)
	{
	}

	// Token: 0x06001F09 RID: 7945 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F09")]
	[Address(RVA = "0xA6EE50", Offset = "0xA6DE50", VA = "0x180A6EE50")]
	public void SetPlayerTextInput(bool val)
	{
	}

	// Token: 0x06001F0A RID: 7946 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F0A")]
	[Address(RVA = "0xA6EFD0", Offset = "0xA6DFD0", VA = "0x180A6EFD0")]
	public void SetActiveCodeInput(KeypadController keypad)
	{
	}

	// Token: 0x06001F0B RID: 7947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F0B")]
	[Address(RVA = "0xA6F050", Offset = "0xA6E050", VA = "0x180A6F050")]
	public void ActivateObjectivesDisplay()
	{
	}

	// Token: 0x06001F0C RID: 7948 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F0C")]
	[Address(RVA = "0xA6F0E0", Offset = "0xA6E0E0", VA = "0x180A6F0E0")]
	public void NewMurderCaseDisplay()
	{
	}

	// Token: 0x06001F0D RID: 7949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F0D")]
	[Address(RVA = "0xA6F150", Offset = "0xA6E150", VA = "0x180A6F150")]
	public void MissionCompleteDisplay()
	{
	}

	// Token: 0x06001F0E RID: 7950 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F0E")]
	[Address(RVA = "0xA6F1B0", Offset = "0xA6E1B0", VA = "0x180A6F1B0")]
	public void ApartmentPurchaseDisplay()
	{
	}

	// Token: 0x06001F0F RID: 7951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F0F")]
	[Address(RVA = "0xA6F220", Offset = "0xA6E220", VA = "0x180A6F220")]
	public void ExecuteMissionCompleteDisplay(Case forCase)
	{
	}

	// Token: 0x06001F10 RID: 7952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F10")]
	[Address(RVA = "0xA6F3A0", Offset = "0xA6E3A0", VA = "0x180A6F3A0")]
	public void SocialCreditLevelUpDisplay()
	{
	}

	// Token: 0x06001F11 RID: 7953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F11")]
	[Address(RVA = "0xA6F420", Offset = "0xA6E420", VA = "0x180A6F420")]
	public void MissionFailedDisplay()
	{
	}

	// Token: 0x06001F12 RID: 7954 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F12")]
	[Address(RVA = "0xA6F480", Offset = "0xA6E480", VA = "0x180A6F480")]
	public void ExecuteMissionFailedDisplay(Case forCase)
	{
	}

	// Token: 0x06001F13 RID: 7955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F13")]
	[Address(RVA = "0xA6F4F0", Offset = "0xA6E4F0", VA = "0x180A6F4F0")]
	public void ExecuteGameOverDisplay()
	{
	}

	// Token: 0x06001F14 RID: 7956 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F14")]
	[Address(RVA = "0xA6F560", Offset = "0xA6E560", VA = "0x180A6F560")]
	public void UnsolvedDisplay()
	{
	}

	// Token: 0x06001F15 RID: 7957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F15")]
	[Address(RVA = "0xA6F5C0", Offset = "0xA6E5C0", VA = "0x180A6F5C0")]
	public void ExecuteMissionUnsolvedDisplay(Case forCase)
	{
	}

	// Token: 0x06001F16 RID: 7958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F16")]
	[Address(RVA = "0xA6F630", Offset = "0xA6E630", VA = "0x180A6F630")]
	public void ExecuteResolveDisplay(Case forCase)
	{
	}

	// Token: 0x06001F17 RID: 7959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F17")]
	[Address(RVA = "0xA6F6A0", Offset = "0xA6E6A0", VA = "0x180A6F6A0")]
	public void ExecuteCoverUpFailedDisplay()
	{
	}

	// Token: 0x06001F18 RID: 7960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F18")]
	[Address(RVA = "0xA6F710", Offset = "0xA6E710", VA = "0x180A6F710")]
	public void ExecuteCoverUpSuccessDisplay()
	{
	}

	// Token: 0x06001F19 RID: 7961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F19")]
	[Address(RVA = "0xA6F780", Offset = "0xA6E780", VA = "0x180A6F780")]
	public void UpdateAvailableCanvases()
	{
	}

	// Token: 0x06001F1A RID: 7962 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F1A")]
	[Address(RVA = "0xA6FC80", Offset = "0xA6EC80", VA = "0x180A6FC80")]
	public void DisplayCreditThresholdForLevel()
	{
	}

	// Token: 0x06001F1B RID: 7963 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F1B")]
	[Address(RVA = "0xA6FD20", Offset = "0xA6ED20", VA = "0x180A6FD20")]
	private IEnumerator DisplayMissionEndText(InterfaceController.ScreenDisplayType newType, [Optional] Case forCase)
	{
		return null;
	}

	// Token: 0x06001F1C RID: 7964 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
	[Token(Token = "0x6001F1C")]
	[Address(RVA = "0xA6FE40", Offset = "0xA6EE40", VA = "0x180A6FE40")]
	public bool StupidUnityChangeToTheWayOnPointerExitHandles(PointerEventData eventData, Transform t)
	{
		return default(bool);
	}

	// Token: 0x06001F1D RID: 7965 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F1D")]
	[Address(RVA = "0xA6FFE0", Offset = "0xA6EFE0", VA = "0x180A6FFE0")]
	public void PromptGlyphTest()
	{
	}

	// Token: 0x06001F1E RID: 7966 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F1E")]
	[Address(RVA = "0xA70190", Offset = "0xA6F190", VA = "0x180A70190")]
	public InterfaceController()
	{
	}

	// Token: 0x0400276F RID: 10095
	[Token(Token = "0x400276F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Canvas caseCanvas;

	// Token: 0x04002770 RID: 10096
	[Token(Token = "0x4002770")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CanvasGroup caseCanvasGroup;

	// Token: 0x04002771 RID: 10097
	[Token(Token = "0x4002771")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GraphicRaycaster caseCanvasRaycaster;

	// Token: 0x04002772 RID: 10098
	[Token(Token = "0x4002772")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Canvas minimapCanvas;

	// Token: 0x04002773 RID: 10099
	[Token(Token = "0x4002773")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CanvasGroup minimapCanvasGroup;

	// Token: 0x04002774 RID: 10100
	[Token(Token = "0x4002774")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas controlsCanvas;

	// Token: 0x04002775 RID: 10101
	[Token(Token = "0x4002775")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public CanvasGroup controlsCanvasGroup;

	// Token: 0x04002776 RID: 10102
	[Token(Token = "0x4002776")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Canvas controlPanelCanvas;

	// Token: 0x04002777 RID: 10103
	[Token(Token = "0x4002777")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public CanvasGroup controlPanelCanvasGroup;

	// Token: 0x04002778 RID: 10104
	[Token(Token = "0x4002778")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Canvas gameWorldCanvas;

	// Token: 0x04002779 RID: 10105
	[Token(Token = "0x4002779")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public CanvasGroup gameWorldCanvasGroup;

	// Token: 0x0400277A RID: 10106
	[Token(Token = "0x400277A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Canvas windowCanvas;

	// Token: 0x0400277B RID: 10107
	[Token(Token = "0x400277B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GraphicRaycaster windowRaycaster;

	// Token: 0x0400277C RID: 10108
	[Token(Token = "0x400277C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public CanvasGroup windowCanvasGroup;

	// Token: 0x0400277D RID: 10109
	[Token(Token = "0x400277D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Canvas statusCanvas;

	// Token: 0x0400277E RID: 10110
	[Token(Token = "0x400277E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public CanvasGroup statusCanvasGroup;

	// Token: 0x0400277F RID: 10111
	[Token(Token = "0x400277F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Canvas upgradesCanvas;

	// Token: 0x04002780 RID: 10112
	[Token(Token = "0x4002780")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public CanvasGroup upgradesCanvasGroup;

	// Token: 0x04002781 RID: 10113
	[Token(Token = "0x4002781")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Canvas dialogCanvas;

	// Token: 0x04002782 RID: 10114
	[Token(Token = "0x4002782")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public CanvasGroup dialogCanvasGroup;

	// Token: 0x04002783 RID: 10115
	[Token(Token = "0x4002783")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Canvas interactionProgressCanvas;

	// Token: 0x04002784 RID: 10116
	[Token(Token = "0x4002784")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public CanvasGroup interactionProgressCanvasGroup;

	// Token: 0x04002785 RID: 10117
	[Token(Token = "0x4002785")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public RectTransform fingerprintDisplayCanvas;

	// Token: 0x04002786 RID: 10118
	[Token(Token = "0x4002786")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public List<RectTransform> uiScaling;

	// Token: 0x04002787 RID: 10119
	[Token(Token = "0x4002787")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public ButtonController notebookButton;

	// Token: 0x04002788 RID: 10120
	[Token(Token = "0x4002788")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public ButtonController upgradesButton;

	// Token: 0x04002789 RID: 10121
	[Token(Token = "0x4002789")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public ButtonController mapButton;

	// Token: 0x0400278A RID: 10122
	[Token(Token = "0x400278A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public ButtonController personButton;

	// Token: 0x0400278B RID: 10123
	[Token(Token = "0x400278B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public RectTransform firstPersonUI;

	// Token: 0x0400278C RID: 10124
	[Token(Token = "0x400278C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public RectTransform caseReferenceAnchor;

	// Token: 0x0400278D RID: 10125
	[Token(Token = "0x400278D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public GameObject backgroundBlur;

	// Token: 0x0400278E RID: 10126
	[Token(Token = "0x400278E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public RectTransform speechDisplayAnchor;

	// Token: 0x0400278F RID: 10127
	[Token(Token = "0x400278F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public RectTransform objectiveSideAnchor;

	// Token: 0x04002790 RID: 10128
	[Token(Token = "0x4002790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public RectTransform objectiveTextBackground;

	// Token: 0x04002791 RID: 10129
	[Token(Token = "0x4002791")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public TextMeshProUGUI objectiveTitleText;

	// Token: 0x04002792 RID: 10130
	[Token(Token = "0x4002792")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public CanvasRenderer objectiveTitleTextRenderer;

	// Token: 0x04002793 RID: 10131
	[Token(Token = "0x4002793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public CanvasRenderer objectiveBackgroundRenderer;

	// Token: 0x04002794 RID: 10132
	[Token(Token = "0x4002794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public RectTransform uiPointerContainer;

	// Token: 0x04002795 RID: 10133
	[Token(Token = "0x4002795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Image takeDamageIndicatorImg;

	// Token: 0x04002796 RID: 10134
	[Token(Token = "0x4002796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public JuiceController takeDamageIndicatorJuice;

	// Token: 0x04002797 RID: 10135
	[Token(Token = "0x4002797")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Image lowHealthIndicatorImg;

	// Token: 0x04002798 RID: 10136
	[Token(Token = "0x4002798")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public RectTransform movieBarTop;

	// Token: 0x04002799 RID: 10137
	[Token(Token = "0x4002799")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public RectTransform movieBarBottom;

	// Token: 0x0400279A RID: 10138
	[Token(Token = "0x400279A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public JuiceController movieBarJuice;

	// Token: 0x0400279B RID: 10139
	[Token(Token = "0x400279B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public TextMeshProUGUI timeText;

	// Token: 0x0400279C RID: 10140
	[Token(Token = "0x400279C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public RectTransform speechAnchor;

	// Token: 0x0400279D RID: 10141
	[Token(Token = "0x400279D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public RectTransform objectCycleAnchor;

	// Token: 0x0400279E RID: 10142
	[Token(Token = "0x400279E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public TextMeshProUGUI timerText;

	// Token: 0x0400279F RID: 10143
	[Token(Token = "0x400279F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public ControllerViewRectScroll caseScrollingViewRect;

	// Token: 0x040027A0 RID: 10144
	[Token(Token = "0x40027A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public ControllerViewRectScroll mapScrollingViewRect;

	// Token: 0x040027A1 RID: 10145
	[Token(Token = "0x40027A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public SoundIndicatorController footstepAudioIndicator;

	// Token: 0x040027A2 RID: 10146
	[Token(Token = "0x40027A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public bool desktopMode;

	// Token: 0x040027A3 RID: 10147
	[Token(Token = "0x40027A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	public float desktopModeTransition;

	// Token: 0x040027A4 RID: 10148
	[Token(Token = "0x40027A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public float desktopModeDesiredTransition;

	// Token: 0x040027A5 RID: 10149
	[Token(Token = "0x40027A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	public bool showDesktopMap;

	// Token: 0x040027A6 RID: 10150
	[Token(Token = "0x40027A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
	public bool showDesktopCaseBoard;

	// Token: 0x040027A7 RID: 10151
	[Token(Token = "0x40027A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public ButtonController selectedElement;

	// Token: 0x040027A8 RID: 10152
	[Token(Token = "0x40027A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public string selectedElementTag;

	// Token: 0x040027A9 RID: 10153
	[Token(Token = "0x40027A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public List<MonoBehaviour> currentMouseOverElement;

	// Token: 0x040027AA RID: 10154
	[Token(Token = "0x40027AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private InfoWindow detectiveNotebook;

	// Token: 0x040027AB RID: 10155
	[Token(Token = "0x40027AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public bool crosshairVisible;

	// Token: 0x040027AC RID: 10156
	[Token(Token = "0x40027AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
	public bool playerTextInputActive;

	// Token: 0x040027AD RID: 10157
	[Token(Token = "0x40027AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public List<SpeechBubbleController> activeSpeechBubbles;

	// Token: 0x040027AE RID: 10158
	[Token(Token = "0x40027AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public bool interfaceIsActive;

	// Token: 0x040027AF RID: 10159
	[Token(Token = "0x40027AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int assignStickyNoteID;

	// Token: 0x040027B0 RID: 10160
	[Token(Token = "0x40027B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public TextMeshProUGUI locationText;

	// Token: 0x040027B1 RID: 10161
	[Token(Token = "0x40027B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private Coroutine displayedTextCoroutine;

	// Token: 0x040027B2 RID: 10162
	[Token(Token = "0x40027B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public bool locationTextDisplayed;

	// Token: 0x040027B3 RID: 10163
	[Token(Token = "0x40027B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public TextMeshProUGUI titleText;

	// Token: 0x040027B4 RID: 10164
	[Token(Token = "0x40027B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public CanvasRenderer titleTextRenderer;

	// Token: 0x040027B5 RID: 10165
	[Token(Token = "0x40027B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public RectTransform gameMessageParent;

	// Token: 0x040027B6 RID: 10166
	[Token(Token = "0x40027B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public bool messageCoroutineRunning;

	// Token: 0x040027B7 RID: 10167
	[Token(Token = "0x40027B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public List<InterfaceController.GameMessage> notificationQueue;

	// Token: 0x040027B8 RID: 10168
	[Token(Token = "0x40027B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public List<InterfaceController.GameMessage> gameHeaderQueue;

	// Token: 0x040027B9 RID: 10169
	[Token(Token = "0x40027B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public List<InterfaceController.GameMessage> helpPointerQueue;

	// Token: 0x040027BA RID: 10170
	[Token(Token = "0x40027BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public GameObject currentNotification;

	// Token: 0x040027BB RID: 10171
	[Token(Token = "0x40027BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	public InterfaceController.GameMessage currentGameHeader;

	// Token: 0x040027BC RID: 10172
	[Token(Token = "0x40027BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private float gameHeaderDelay;

	// Token: 0x040027BD RID: 10173
	[Token(Token = "0x40027BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
	public float gameHeaderTimer;

	// Token: 0x040027BE RID: 10174
	[Token(Token = "0x40027BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private float typewriterDelay;

	// Token: 0x040027BF RID: 10175
	[Token(Token = "0x40027BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
	private float gameHeaderFadeDelay;

	// Token: 0x040027C0 RID: 10176
	[Token(Token = "0x40027C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public bool gameHeaderDisplayed;

	// Token: 0x040027C1 RID: 10177
	[Token(Token = "0x40027C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x269")]
	public bool gameSceenDisplayed;

	// Token: 0x040027C2 RID: 10178
	[Token(Token = "0x40027C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26A")]
	public bool gameScreenQueued;

	// Token: 0x040027C3 RID: 10179
	[Token(Token = "0x40027C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26B")]
	public bool levelUpScreenActive;

	// Token: 0x040027C4 RID: 10180
	[Token(Token = "0x40027C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
	public InterfaceController.ScreenDisplayType currentGameScreen;

	// Token: 0x040027C5 RID: 10181
	[Token(Token = "0x40027C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	public RectTransform notebookNotificationIcon;

	// Token: 0x040027C6 RID: 10182
	[Token(Token = "0x40027C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	public JuiceController notebookNotificationJuice;

	// Token: 0x040027C7 RID: 10183
	[Token(Token = "0x40027C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	public RectTransform syncDiskNotificationIcon;

	// Token: 0x040027C8 RID: 10184
	[Token(Token = "0x40027C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	public JuiceController syncDiskNotificationJuice;

	// Token: 0x040027C9 RID: 10185
	[Token(Token = "0x40027C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	public RectTransform lockpicksNotificationIcon;

	// Token: 0x040027CA RID: 10186
	[Token(Token = "0x40027CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	public TextMeshProUGUI lockpicksNotificationText;

	// Token: 0x040027CB RID: 10187
	[Token(Token = "0x40027CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	public JuiceController lockpicksNotificationJuice;

	// Token: 0x040027CC RID: 10188
	[Token(Token = "0x40027CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	public List<CanvasRenderer> lockpicksNotificationRenderers;

	// Token: 0x040027CD RID: 10189
	[Token(Token = "0x40027CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	public bool lockpickNotificationActive;

	// Token: 0x040027CE RID: 10190
	[Token(Token = "0x40027CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
	public int lastLockpicks;

	// Token: 0x040027CF RID: 10191
	[Token(Token = "0x40027CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	public RectTransform moneyNotificationIcon;

	// Token: 0x040027D0 RID: 10192
	[Token(Token = "0x40027D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	public TextMeshProUGUI moneyNotificationText;

	// Token: 0x040027D1 RID: 10193
	[Token(Token = "0x40027D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	public JuiceController moneyNotificationJuice;

	// Token: 0x040027D2 RID: 10194
	[Token(Token = "0x40027D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	public List<CanvasRenderer> moneyNotificationRenderers;

	// Token: 0x040027D3 RID: 10195
	[Token(Token = "0x40027D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	public bool moneyNotificationActive;

	// Token: 0x040027D4 RID: 10196
	[Token(Token = "0x40027D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
	public int lastMoney;

	// Token: 0x040027D5 RID: 10197
	[Token(Token = "0x40027D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	public RectTransform bioNotificationIcon;

	// Token: 0x040027D6 RID: 10198
	[Token(Token = "0x40027D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	private InterfaceController.GameMessage currentHelpPointer;

	// Token: 0x040027D7 RID: 10199
	[Token(Token = "0x40027D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	public RectTransform helpPointerRect;

	// Token: 0x040027D8 RID: 10200
	[Token(Token = "0x40027D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	public List<CanvasRenderer> helpPointerRenderers;

	// Token: 0x040027D9 RID: 10201
	[Token(Token = "0x40027D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	public TextMeshProUGUI helpPointerText;

	// Token: 0x040027DA RID: 10202
	[Token(Token = "0x40027DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	private string helpPointerTextDisplay;

	// Token: 0x040027DB RID: 10203
	[Token(Token = "0x40027DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	private float helpPointerProgress;

	// Token: 0x040027DC RID: 10204
	[Token(Token = "0x40027DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
	private float helpPointerFadeOut;

	// Token: 0x040027DD RID: 10205
	[Token(Token = "0x40027DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	private float helpPointerTimer;

	// Token: 0x040027DE RID: 10206
	[Token(Token = "0x40027DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
	private float helpPointerDesiredHeight;

	// Token: 0x040027DF RID: 10207
	[Token(Token = "0x40027DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	[NonSerialized]
	public Objective currentlyDisplaying;

	// Token: 0x040027E0 RID: 10208
	[Token(Token = "0x40027E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	public List<Objective> displayedObjectives;

	// Token: 0x040027E1 RID: 10209
	[Token(Token = "0x40027E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	public List<ChecklistButtonController> objectiveList;

	// Token: 0x040027E2 RID: 10210
	[Token(Token = "0x40027E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	public AnimationCurve radialActivateScale;

	// Token: 0x040027E3 RID: 10211
	[Token(Token = "0x40027E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	public GameObject dragged;

	// Token: 0x040027E4 RID: 10212
	[Token(Token = "0x40027E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	public string draggedTag;

	// Token: 0x040027E5 RID: 10213
	[Token(Token = "0x40027E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	public Vector2 dragCursorOffset;

	// Token: 0x040027E6 RID: 10214
	[Token(Token = "0x40027E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	public PinnedItemController pinnedBeingDragged;

	// Token: 0x040027E7 RID: 10215
	[Token(Token = "0x40027E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	public float windowFadeProgress;

	// Token: 0x040027E8 RID: 10216
	[Token(Token = "0x40027E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x364")]
	public bool windowFullFade;

	// Token: 0x040027E9 RID: 10217
	[Token(Token = "0x40027E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	public float objectivesDisplayTimer;

	// Token: 0x040027EA RID: 10218
	[Token(Token = "0x40027EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
	public float objectivesAlpha;

	// Token: 0x040027EB RID: 10219
	[Token(Token = "0x40027EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	public bool boxSelectActive;

	// Token: 0x040027EC RID: 10220
	[Token(Token = "0x40027EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	public RectTransform boxSelect;

	// Token: 0x040027ED RID: 10221
	[Token(Token = "0x40027ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	public List<PinnedItemController> selectedPinned;

	// Token: 0x040027EE RID: 10222
	[Token(Token = "0x40027EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	public Dictionary<string, WindowStylePreset> windowDictionary;

	// Token: 0x040027EF RID: 10223
	[Token(Token = "0x40027EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
	public List<InfoWindow> activeWindows;

	// Token: 0x040027F0 RID: 10224
	[Token(Token = "0x40027F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	public string openHelpToPage;

	// Token: 0x040027F1 RID: 10225
	[Token(Token = "0x40027F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
	public RectTransform windowFocus;

	// Token: 0x040027F2 RID: 10226
	[Token(Token = "0x40027F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
	public KeypadController activeCodeInput;

	// Token: 0x040027F3 RID: 10227
	[Token(Token = "0x40027F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
	public CanvasRenderer fadeOverlay;

	// Token: 0x040027F4 RID: 10228
	[Token(Token = "0x40027F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
	public AnimationCurve fadeOverlayAlphaCurve;

	// Token: 0x040027F5 RID: 10229
	[Token(Token = "0x40027F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
	public float desiredFade;

	// Token: 0x040027F6 RID: 10230
	[Token(Token = "0x40027F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C4")]
	private float fadeTime;

	// Token: 0x040027F7 RID: 10231
	[Token(Token = "0x40027F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
	private bool fadeAudio;

	// Token: 0x040027F8 RID: 10232
	[Token(Token = "0x40027F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3CC")]
	public float fade;

	// Token: 0x040027F9 RID: 10233
	[Token(Token = "0x40027F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	private CameraClearFlags savedCameraClear;

	// Token: 0x040027FA RID: 10234
	[Token(Token = "0x40027FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
	public GameObject compassContainer;

	// Token: 0x040027FB RID: 10235
	[Token(Token = "0x40027FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
	public Transform backgroundTransform;

	// Token: 0x040027FC RID: 10236
	[Token(Token = "0x40027FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
	public MeshRenderer compassMeshRend;

	// Token: 0x040027FD RID: 10237
	[Token(Token = "0x40027FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
	public Material compassMaterial;

	// Token: 0x040027FE RID: 10238
	[Token(Token = "0x40027FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
	public float compassDesiredAlpha;

	// Token: 0x040027FF RID: 10239
	[Token(Token = "0x40027FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3FC")]
	public float compassActualAlpha;

	// Token: 0x04002800 RID: 10240
	[Token(Token = "0x4002800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
	public List<InterfaceController.AwarenessIcon> awarenessIcons;

	// Token: 0x04002801 RID: 10241
	[Token(Token = "0x4002801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
	public List<SpeechBubbleController> anchoredSpeech;

	// Token: 0x04002802 RID: 10242
	[Token(Token = "0x4002802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
	public GameObject firstPersonModel;

	// Token: 0x04002803 RID: 10243
	[Token(Token = "0x4002803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
	public Animator firstPersonAnimator;

	// Token: 0x04002804 RID: 10244
	[Token(Token = "0x4002804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
	public float desiredDofNearStart;

	// Token: 0x04002805 RID: 10245
	[Token(Token = "0x4002805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x424")]
	public float desiredDofNearEnd;

	// Token: 0x04002806 RID: 10246
	[Token(Token = "0x4002806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
	public float desiredDofFarStart;

	// Token: 0x04002807 RID: 10247
	[Token(Token = "0x4002807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42C")]
	public float desiredDofFarEnd;

	// Token: 0x04002808 RID: 10248
	[Token(Token = "0x4002808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
	public float dofProgress;

	// Token: 0x04002809 RID: 10249
	[Token(Token = "0x4002809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
	public PopupMessageController popupController;

	// Token: 0x0400280A RID: 10250
	[Token(Token = "0x400280A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
	public int debugLevel;

	// Token: 0x0400280D RID: 10253
	[Token(Token = "0x400280D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static InterfaceController _instance;

	// Token: 0x0200058C RID: 1420
	[Token(Token = "0x200058C")]
	public enum GameMessageType
	{
		// Token: 0x0400280F RID: 10255
		[Token(Token = "0x400280F")]
		notification,
		// Token: 0x04002810 RID: 10256
		[Token(Token = "0x4002810")]
		gameHeader,
		// Token: 0x04002811 RID: 10257
		[Token(Token = "0x4002811")]
		keyMerge,
		// Token: 0x04002812 RID: 10258
		[Token(Token = "0x4002812")]
		helpPointer,
		// Token: 0x04002813 RID: 10259
		[Token(Token = "0x4002813")]
		socialCredit
	}

	// Token: 0x0200058D RID: 1421
	[Token(Token = "0x200058D")]
	public class GameMessage
	{
		// Token: 0x06001F20 RID: 7968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F20")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public GameMessage()
		{
		}

		// Token: 0x04002814 RID: 10260
		[Token(Token = "0x4002814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InterfaceController.GameMessageType messageType;

		// Token: 0x04002815 RID: 10261
		[Token(Token = "0x4002815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int numerical;

		// Token: 0x04002816 RID: 10262
		[Token(Token = "0x4002816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string message;

		// Token: 0x04002817 RID: 10263
		[Token(Token = "0x4002817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sprite graphic;

		// Token: 0x04002818 RID: 10264
		[Token(Token = "0x4002818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioEvent additionalSFX;

		// Token: 0x04002819 RID: 10265
		[Token(Token = "0x4002819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool colourOverride;

		// Token: 0x0400281A RID: 10266
		[Token(Token = "0x400281A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color col;

		// Token: 0x0400281B RID: 10267
		[Token(Token = "0x400281B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int mergeType;

		// Token: 0x0400281C RID: 10268
		[Token(Token = "0x400281C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float delay;

		// Token: 0x0400281D RID: 10269
		[Token(Token = "0x400281D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RectTransform moveOnDestroy;

		// Token: 0x0400281E RID: 10270
		[Token(Token = "0x400281E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameMessageController.PingOnComplete ping;

		// Token: 0x0400281F RID: 10271
		[Token(Token = "0x400281F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool keyMerge;

		// Token: 0x04002820 RID: 10272
		[Token(Token = "0x4002820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		public bool socCredit;

		// Token: 0x04002821 RID: 10273
		[Token(Token = "0x4002821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Evidence keyMergeEvidence;

		// Token: 0x04002822 RID: 10274
		[Token(Token = "0x4002822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<Evidence.DataKey> mergedKeys;
	}

	// Token: 0x0200058E RID: 1422
	[Token(Token = "0x200058E")]
	public enum AwarenessType
	{
		// Token: 0x04002824 RID: 10276
		[Token(Token = "0x4002824")]
		actor,
		// Token: 0x04002825 RID: 10277
		[Token(Token = "0x4002825")]
		transform,
		// Token: 0x04002826 RID: 10278
		[Token(Token = "0x4002826")]
		position
	}

	// Token: 0x0200058F RID: 1423
	[Token(Token = "0x200058F")]
	public enum AwarenessBehaviour
	{
		// Token: 0x04002828 RID: 10280
		[Token(Token = "0x4002828")]
		alwaysVisible,
		// Token: 0x04002829 RID: 10281
		[Token(Token = "0x4002829")]
		invisibleInfront
	}

	// Token: 0x02000590 RID: 1424
	[Token(Token = "0x2000590")]
	[Serializable]
	public class AwarenessIcon
	{
		// Token: 0x06001F21 RID: 7969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F21")]
		[Address(RVA = "0xA70BE0", Offset = "0xA6FBE0", VA = "0x180A70BE0")]
		public void Remove(bool instant = false)
		{
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F22")]
		[Address(RVA = "0xA71100", Offset = "0xA70100", VA = "0x180A71100")]
		public void SetAlpha(float val)
		{
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F23")]
		[Address(RVA = "0xA71250", Offset = "0xA70250", VA = "0x180A71250")]
		public void SetTexture(Texture tex)
		{
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		[Token(Token = "0x6001F24")]
		[Address(RVA = "0xA713E0", Offset = "0xA703E0", VA = "0x180A713E0")]
		public float GetActualAlpha()
		{
			return 0f;
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F25")]
		[Address(RVA = "0xA71400", Offset = "0xA70400", VA = "0x180A71400")]
		public void TriggerAlert()
		{
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F26")]
		[Address(RVA = "0xA71410", Offset = "0xA70410", VA = "0x180A71410")]
		public AwarenessIcon()
		{
		}

		// Token: 0x0400282A RID: 10282
		[Token(Token = "0x400282A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InterfaceController.AwarenessType awarenessType;

		// Token: 0x0400282B RID: 10283
		[Token(Token = "0x400282B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public InterfaceController.AwarenessBehaviour awarenessBehaviour;

		// Token: 0x0400282C RID: 10284
		[Token(Token = "0x400282C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Actor actor;

		// Token: 0x0400282D RID: 10285
		[Token(Token = "0x400282D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform targetTransform;

		// Token: 0x0400282E RID: 10286
		[Token(Token = "0x400282E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 targetPosition;

		// Token: 0x0400282F RID: 10287
		[Token(Token = "0x400282F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject spawned;

		// Token: 0x04002830 RID: 10288
		[Token(Token = "0x4002830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform imageTransform;

		// Token: 0x04002831 RID: 10289
		[Token(Token = "0x4002831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Material imageMaterial;

		// Token: 0x04002832 RID: 10290
		[Token(Token = "0x4002832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform arrowTransform;

		// Token: 0x04002833 RID: 10291
		[Token(Token = "0x4002833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Material arrowMaterial;

		// Token: 0x04002834 RID: 10292
		[Token(Token = "0x4002834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture overrideTexture;

		// Token: 0x04002835 RID: 10293
		[Token(Token = "0x4002835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float fadeIn;

		// Token: 0x04002836 RID: 10294
		[Token(Token = "0x4002836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float springAction;

		// Token: 0x04002837 RID: 10295
		[Token(Token = "0x4002837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float removalProgress;

		// Token: 0x04002838 RID: 10296
		[Token(Token = "0x4002838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool removalFlag;

		// Token: 0x04002839 RID: 10297
		[Token(Token = "0x4002839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float alpha;

		// Token: 0x0400283A RID: 10298
		[Token(Token = "0x400283A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float displayAlpha;

		// Token: 0x0400283B RID: 10299
		[Token(Token = "0x400283B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float maxDistance;

		// Token: 0x0400283C RID: 10300
		[Token(Token = "0x400283C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool setup;

		// Token: 0x0400283D RID: 10301
		[Token(Token = "0x400283D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int priority;

		// Token: 0x0400283E RID: 10302
		[Token(Token = "0x400283E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool triggerAlert;

		// Token: 0x0400283F RID: 10303
		[Token(Token = "0x400283F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float alertProgress;

		// Token: 0x02000591 RID: 1425
		[Token(Token = "0x2000591")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001F28 RID: 7976 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F28")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c()
			{
			}

			// Token: 0x06001F29 RID: 7977 RVA: 0x0000DB00 File Offset: 0x0000BD00
			[Token(Token = "0x6001F29")]
			[Address(RVA = "0xA714D0", Offset = "0xA704D0", VA = "0x180A714D0")]
			internal int <Remove>b__22_0(InterfaceController.AwarenessIcon p1, InterfaceController.AwarenessIcon p2)
			{
				return 0;
			}

			// Token: 0x04002840 RID: 10304
			[Token(Token = "0x4002840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly InterfaceController.AwarenessIcon.<>c <>9;

			// Token: 0x04002841 RID: 10305
			[Token(Token = "0x4002841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<InterfaceController.AwarenessIcon> <>9__22_0;
		}
	}

	// Token: 0x02000592 RID: 1426
	[Token(Token = "0x2000592")]
	public enum ScreenDisplayType
	{
		// Token: 0x04002843 RID: 10307
		[Token(Token = "0x4002843")]
		missionComplete,
		// Token: 0x04002844 RID: 10308
		[Token(Token = "0x4002844")]
		missionFailed,
		// Token: 0x04002845 RID: 10309
		[Token(Token = "0x4002845")]
		newMurderCase,
		// Token: 0x04002846 RID: 10310
		[Token(Token = "0x4002846")]
		socialCreditLevelUp,
		// Token: 0x04002847 RID: 10311
		[Token(Token = "0x4002847")]
		unsolved,
		// Token: 0x04002848 RID: 10312
		[Token(Token = "0x4002848")]
		displayResolve,
		// Token: 0x04002849 RID: 10313
		[Token(Token = "0x4002849")]
		apartmentPurchase,
		// Token: 0x0400284A RID: 10314
		[Token(Token = "0x400284A")]
		gameOver,
		// Token: 0x0400284B RID: 10315
		[Token(Token = "0x400284B")]
		coverUpSuccess,
		// Token: 0x0400284C RID: 10316
		[Token(Token = "0x400284C")]
		coverUpFailed
	}

	// Token: 0x02000593 RID: 1427
	// (Invoke) Token: 0x06001F2B RID: 7979
	[Token(Token = "0x2000593")]
	public delegate void InputCode(List<int> code);

	// Token: 0x02000594 RID: 1428
	// (Invoke) Token: 0x06001F2F RID: 7983
	[Token(Token = "0x2000594")]
	public delegate void NewActiveCodeInput(KeypadController keypad);

	// Token: 0x02000595 RID: 1429
	[Token(Token = "0x2000595")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001F33 RID: 7987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F33")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x0000DB18 File Offset: 0x0000BD18
		[Token(Token = "0x6001F34")]
		[Address(RVA = "0xA714D0", Offset = "0xA704D0", VA = "0x180A714D0")]
		internal int <Update>b__176_0(InterfaceController.AwarenessIcon p1, InterfaceController.AwarenessIcon p2)
		{
			return 0;
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x0000DB30 File Offset: 0x0000BD30
		[Token(Token = "0x6001F35")]
		[Address(RVA = "0xA715C0", Offset = "0xA705C0", VA = "0x180A715C0")]
		internal int <UpdateAnchoredSpeechPositions>b__179_0(SpeechBubbleController p1, SpeechBubbleController p2)
		{
			return 0;
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x0000DB48 File Offset: 0x0000BD48
		[Token(Token = "0x6001F36")]
		[Address(RVA = "0xA71650", Offset = "0xA70650", VA = "0x180A71650")]
		internal bool <UpdateAnchoredSpeechPositions>b__179_1(SpeechBubbleController item)
		{
			return default(bool);
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x0000DB60 File Offset: 0x0000BD60
		[Token(Token = "0x6001F37")]
		[Address(RVA = "0xA714D0", Offset = "0xA704D0", VA = "0x180A714D0")]
		internal int <AddAwarenessIcon>b__180_1(InterfaceController.AwarenessIcon p1, InterfaceController.AwarenessIcon p2)
		{
			return 0;
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x0000DB78 File Offset: 0x0000BD78
		[Token(Token = "0x6001F38")]
		[Address(RVA = "0xA71670", Offset = "0xA70670", VA = "0x180A71670")]
		internal bool <OpenApartmentAsEvidence>b__196_0(GameplayController.HotelGuest item)
		{
			return default(bool);
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x0000DB90 File Offset: 0x0000BD90
		[Token(Token = "0x6001F39")]
		[Address(RVA = "0xA71850", Offset = "0xA70850", VA = "0x180A71850")]
		internal bool <SetDesktopMode>b__198_0(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
		[Token(Token = "0x6001F3A")]
		[Address(RVA = "0xA718E0", Offset = "0xA708E0", VA = "0x180A718E0")]
		internal bool <SetDesktopMode>b__198_1(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		[Token(Token = "0x6001F3B")]
		[Address(RVA = "0xA71970", Offset = "0xA70970", VA = "0x180A71970")]
		internal bool <ToggleNotebook>b__213_0(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		[Token(Token = "0x6001F3C")]
		[Address(RVA = "0xA71A00", Offset = "0xA70A00", VA = "0x180A71A00")]
		internal bool <OpenNotebookNoPause>b__214_0(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x0400284D RID: 10317
		[Token(Token = "0x400284D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly InterfaceController.<>c <>9;

		// Token: 0x0400284E RID: 10318
		[Token(Token = "0x400284E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<InterfaceController.AwarenessIcon> <>9__176_0;

		// Token: 0x0400284F RID: 10319
		[Token(Token = "0x400284F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Comparison<SpeechBubbleController> <>9__179_0;

		// Token: 0x04002850 RID: 10320
		[Token(Token = "0x4002850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<SpeechBubbleController> <>9__179_1;

		// Token: 0x04002851 RID: 10321
		[Token(Token = "0x4002851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Comparison<InterfaceController.AwarenessIcon> <>9__180_1;

		// Token: 0x04002852 RID: 10322
		[Token(Token = "0x4002852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<GameplayController.HotelGuest> <>9__196_0;

		// Token: 0x04002853 RID: 10323
		[Token(Token = "0x4002853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<InfoWindow> <>9__198_0;

		// Token: 0x04002854 RID: 10324
		[Token(Token = "0x4002854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Predicate<InfoWindow> <>9__198_1;

		// Token: 0x04002855 RID: 10325
		[Token(Token = "0x4002855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Predicate<InfoWindow> <>9__213_0;

		// Token: 0x04002856 RID: 10326
		[Token(Token = "0x4002856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Predicate<InfoWindow> <>9__214_0;
	}

	// Token: 0x02000596 RID: 1430
	[Token(Token = "0x2000596")]
	private sealed class <>c__DisplayClass180_0
	{
		// Token: 0x06001F3D RID: 7997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F3D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass180_0()
		{
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
		[Token(Token = "0x6001F3E")]
		[Address(RVA = "0xA71A90", Offset = "0xA70A90", VA = "0x180A71A90")]
		internal bool <AddAwarenessIcon>b__0(InterfaceController.AwarenessIcon item)
		{
			return default(bool);
		}

		// Token: 0x04002857 RID: 10327
		[Token(Token = "0x4002857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InterfaceController.AwarenessType newType;

		// Token: 0x04002858 RID: 10328
		[Token(Token = "0x4002858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public InterfaceController.AwarenessBehaviour newBehaviour;

		// Token: 0x04002859 RID: 10329
		[Token(Token = "0x4002859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Actor newActor;

		// Token: 0x0400285A RID: 10330
		[Token(Token = "0x400285A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform newTransform;

		// Token: 0x0400285B RID: 10331
		[Token(Token = "0x400285B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 newPosition;
	}

	// Token: 0x02000597 RID: 1431
	[Token(Token = "0x2000597")]
	private sealed class <>c__DisplayClass182_0
	{
		// Token: 0x06001F3F RID: 7999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F3F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass182_0()
		{
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x0000DC08 File Offset: 0x0000BE08
		[Token(Token = "0x6001F40")]
		[Address(RVA = "0xA71DE0", Offset = "0xA70DE0", VA = "0x180A71DE0")]
		internal bool <SpawnWindow>b__0(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x0400285C RID: 10332
		[Token(Token = "0x400285C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Evidence passedEvidence;
	}

	// Token: 0x02000598 RID: 1432
	[Token(Token = "0x2000598")]
	private sealed class <>c__DisplayClass184_0
	{
		// Token: 0x06001F41 RID: 8001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F41")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass184_0()
		{
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x0000DC20 File Offset: 0x0000BE20
		[Token(Token = "0x6001F42")]
		[Address(RVA = "0xA71DE0", Offset = "0xA70DE0", VA = "0x180A71DE0")]
		internal bool <GetWindow>b__0(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x0400285D RID: 10333
		[Token(Token = "0x400285D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Evidence winEntry;
	}

	// Token: 0x02000599 RID: 1433
	[Token(Token = "0x2000599")]
	private sealed class <>c__DisplayClass185_0
	{
		// Token: 0x06001F43 RID: 8003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F43")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass185_0()
		{
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x0000DC38 File Offset: 0x0000BE38
		[Token(Token = "0x6001F44")]
		[Address(RVA = "0xA71DE0", Offset = "0xA70DE0", VA = "0x180A71DE0")]
		internal bool <GetWindow>b__0(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x0400285E RID: 10334
		[Token(Token = "0x400285E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Evidence winEntry;
	}

	// Token: 0x0200059A RID: 1434
	[Token(Token = "0x200059A")]
	private sealed class <WindowScaleAnimation>d__188 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001F45 RID: 8005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F45")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <WindowScaleAnimation>d__188(int <>1__state)
		{
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F46")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x0000DC50 File Offset: 0x0000BE50
		[Token(Token = "0x6001F47")]
		[Address(RVA = "0xA71E10", Offset = "0xA70E10", VA = "0x180A71E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06001F48 RID: 8008 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000FB")]
		private object Current
		{
			[Token(Token = "0x6001F48")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F49")]
		[Address(RVA = "0xA73490", Offset = "0xA72490", VA = "0x180A73490", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06001F4A RID: 8010 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000FC")]
		private object Current
		{
			[Token(Token = "0x6001F4A")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400285F RID: 10335
		[Token(Token = "0x400285F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002860 RID: 10336
		[Token(Token = "0x4002860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002861 RID: 10337
		[Token(Token = "0x4002861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InfoWindow window;

		// Token: 0x04002862 RID: 10338
		[Token(Token = "0x4002862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 toPosition;

		// Token: 0x04002863 RID: 10339
		[Token(Token = "0x4002863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 toPivot;

		// Token: 0x04002864 RID: 10340
		[Token(Token = "0x4002864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 toScale;

		// Token: 0x04002865 RID: 10341
		[Token(Token = "0x4002865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool removeAtEnd;

		// Token: 0x04002866 RID: 10342
		[Token(Token = "0x4002866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform <itemCanvas>5__2;

		// Token: 0x04002867 RID: 10343
		[Token(Token = "0x4002867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GraphicRaycaster <gr>5__3;

		// Token: 0x04002868 RID: 10344
		[Token(Token = "0x4002868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector2 <movementDirection>5__4;

		// Token: 0x04002869 RID: 10345
		[Token(Token = "0x4002869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 <startScale>5__5;

		// Token: 0x0400286A RID: 10346
		[Token(Token = "0x400286A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float <progress>5__6;
	}

	// Token: 0x0200059B RID: 1435
	[Token(Token = "0x200059B")]
	private sealed class <DisplayLocText>d__191 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001F4B RID: 8011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F4B")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <DisplayLocText>d__191(int <>1__state)
		{
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F4C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x0000DC68 File Offset: 0x0000BE68
		[Token(Token = "0x6001F4D")]
		[Address(RVA = "0xA734E0", Offset = "0xA724E0", VA = "0x180A734E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000FD")]
		private object Current
		{
			[Token(Token = "0x6001F4E")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F4F")]
		[Address(RVA = "0xA73C60", Offset = "0xA72C60", VA = "0x180A73C60", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000FE")]
		private object Current
		{
			[Token(Token = "0x6001F50")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400286B RID: 10347
		[Token(Token = "0x400286B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400286C RID: 10348
		[Token(Token = "0x400286C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400286D RID: 10349
		[Token(Token = "0x400286D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool forceUpdate;

		// Token: 0x0400286E RID: 10350
		[Token(Token = "0x400286E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InterfaceController <>4__this;

		// Token: 0x0400286F RID: 10351
		[Token(Token = "0x400286F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float duration;

		// Token: 0x04002870 RID: 10352
		[Token(Token = "0x4002870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timeDisplayed>5__2;
	}

	// Token: 0x0200059C RID: 1436
	[Token(Token = "0x200059C")]
	private sealed class <LocationTextFade>d__194 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001F51 RID: 8017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F51")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <LocationTextFade>d__194(int <>1__state)
		{
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F52")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x0000DC80 File Offset: 0x0000BE80
		[Token(Token = "0x6001F53")]
		[Address(RVA = "0xA73CB0", Offset = "0xA72CB0", VA = "0x180A73CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06001F54 RID: 8020 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000FF")]
		private object Current
		{
			[Token(Token = "0x6001F54")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F55")]
		[Address(RVA = "0xA743A0", Offset = "0xA733A0", VA = "0x180A743A0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000100")]
		private object Current
		{
			[Token(Token = "0x6001F56")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002871 RID: 10353
		[Token(Token = "0x4002871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002872 RID: 10354
		[Token(Token = "0x4002872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002873 RID: 10355
		[Token(Token = "0x4002873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool show;

		// Token: 0x04002874 RID: 10356
		[Token(Token = "0x4002874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InterfaceController <>4__this;

		// Token: 0x04002875 RID: 10357
		[Token(Token = "0x4002875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float fadeSpeed;

		// Token: 0x04002876 RID: 10358
		[Token(Token = "0x4002876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <snapProgress>5__2;
	}

	// Token: 0x0200059D RID: 1437
	[Token(Token = "0x200059D")]
	private sealed class <>c__DisplayClass208_0
	{
		// Token: 0x06001F57 RID: 8023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F57")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass208_0()
		{
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x0000DC98 File Offset: 0x0000BE98
		[Token(Token = "0x6001F58")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <NewGameMessage>b__0(InterfaceControls.IconConfig item)
		{
			return default(bool);
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
		[Token(Token = "0x6001F59")]
		[Address(RVA = "0xA743F0", Offset = "0xA733F0", VA = "0x180A743F0")]
		internal bool <NewGameMessage>b__1(InterfaceController.GameMessage item)
		{
			return default(bool);
		}

		// Token: 0x04002877 RID: 10359
		[Token(Token = "0x4002877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InterfaceControls.Icon newIcon;

		// Token: 0x04002878 RID: 10360
		[Token(Token = "0x4002878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string newMessage;
	}

	// Token: 0x0200059E RID: 1438
	[Token(Token = "0x200059E")]
	private sealed class <GameMessages>d__209 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001F5A RID: 8026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5A")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <GameMessages>d__209(int <>1__state)
		{
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		[Token(Token = "0x6001F5C")]
		[Address(RVA = "0xA74450", Offset = "0xA73450", VA = "0x180A74450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000101")]
		private object Current
		{
			[Token(Token = "0x6001F5D")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5E")]
		[Address(RVA = "0xA75C40", Offset = "0xA74C40", VA = "0x180A75C40", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000102")]
		private object Current
		{
			[Token(Token = "0x6001F5F")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002879 RID: 10361
		[Token(Token = "0x4002879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400287A RID: 10362
		[Token(Token = "0x400287A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400287B RID: 10363
		[Token(Token = "0x400287B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InterfaceController <>4__this;

		// Token: 0x0400287C RID: 10364
		[Token(Token = "0x400287C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <waitedAFrame>5__2;

		// Token: 0x0400287D RID: 10365
		[Token(Token = "0x400287D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioController.LoopingSoundInfo <typewriterSoundTriggered>5__3;
	}

	// Token: 0x0200059F RID: 1439
	[Token(Token = "0x200059F")]
	private sealed class <FadeGame>d__219 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001F60 RID: 8032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F60")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <FadeGame>d__219(int <>1__state)
		{
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F61")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
		[Token(Token = "0x6001F62")]
		[Address(RVA = "0xA75C90", Offset = "0xA74C90", VA = "0x180A75C90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000103")]
		private object Current
		{
			[Token(Token = "0x6001F63")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F64")]
		[Address(RVA = "0xA76320", Offset = "0xA75320", VA = "0x180A76320", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000104")]
		private object Current
		{
			[Token(Token = "0x6001F65")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400287E RID: 10366
		[Token(Token = "0x400287E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400287F RID: 10367
		[Token(Token = "0x400287F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002880 RID: 10368
		[Token(Token = "0x4002880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InterfaceController <>4__this;
	}

	// Token: 0x020005A0 RID: 1440
	[Token(Token = "0x20005A0")]
	private sealed class <DesktopModeTransition>d__220 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001F66 RID: 8038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F66")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <DesktopModeTransition>d__220(int <>1__state)
		{
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F67")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		[Token(Token = "0x6001F68")]
		[Address(RVA = "0xA76370", Offset = "0xA75370", VA = "0x180A76370", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06001F69 RID: 8041 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000105")]
		private object Current
		{
			[Token(Token = "0x6001F69")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F6A")]
		[Address(RVA = "0xA77030", Offset = "0xA76030", VA = "0x180A77030", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000106")]
		private object Current
		{
			[Token(Token = "0x6001F6B")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002881 RID: 10369
		[Token(Token = "0x4002881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002882 RID: 10370
		[Token(Token = "0x4002882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002883 RID: 10371
		[Token(Token = "0x4002883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InterfaceController <>4__this;

		// Token: 0x04002884 RID: 10372
		[Token(Token = "0x4002884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform <canvasRect>5__2;

		// Token: 0x04002885 RID: 10373
		[Token(Token = "0x4002885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RectTransform <windowRect>5__3;

		// Token: 0x04002886 RID: 10374
		[Token(Token = "0x4002886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <setControlDisplay>5__4;
	}

	// Token: 0x020005A1 RID: 1441
	[Token(Token = "0x20005A1")]
	private sealed class <>c__DisplayClass231_0
	{
		// Token: 0x06001F6C RID: 8044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F6C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass231_0()
		{
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x0000DD10 File Offset: 0x0000BF10
		[Token(Token = "0x6001F6D")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <GetEvidenceColour>b__0(InterfaceControls.PinColours item)
		{
			return default(bool);
		}

		// Token: 0x04002887 RID: 10375
		[Token(Token = "0x4002887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InterfaceControls.EvidenceColours col;
	}

	// Token: 0x020005A2 RID: 1442
	[Token(Token = "0x20005A2")]
	private sealed class <ExecutePing>d__234 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001F6E RID: 8046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F6E")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <ExecutePing>d__234(int <>1__state)
		{
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F6F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x0000DD28 File Offset: 0x0000BF28
		[Token(Token = "0x6001F70")]
		[Address(RVA = "0xA77080", Offset = "0xA76080", VA = "0x180A77080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000107")]
		private object Current
		{
			[Token(Token = "0x6001F71")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F72")]
		[Address(RVA = "0xA779E0", Offset = "0xA769E0", VA = "0x180A779E0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000108")]
		private object Current
		{
			[Token(Token = "0x6001F73")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002888 RID: 10376
		[Token(Token = "0x4002888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002889 RID: 10377
		[Token(Token = "0x4002889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400288A RID: 10378
		[Token(Token = "0x400288A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RectTransform pingRect;

		// Token: 0x0400288B RID: 10379
		[Token(Token = "0x400288B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public JuiceController pingJuice;

		// Token: 0x0400288C RID: 10380
		[Token(Token = "0x400288C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI textPing;

		// Token: 0x0400288D RID: 10381
		[Token(Token = "0x400288D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int originalValue;

		// Token: 0x0400288E RID: 10382
		[Token(Token = "0x400288E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool isMoney;

		// Token: 0x0400288F RID: 10383
		[Token(Token = "0x400288F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CanvasRenderer> renderers;

		// Token: 0x04002890 RID: 10384
		[Token(Token = "0x4002890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InterfaceController <>4__this;

		// Token: 0x04002891 RID: 10385
		[Token(Token = "0x4002891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float <progress>5__2;

		// Token: 0x04002892 RID: 10386
		[Token(Token = "0x4002892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string <moneyStr>5__3;
	}

	// Token: 0x020005A3 RID: 1443
	[Token(Token = "0x20005A3")]
	private sealed class <DisplayMissionEndText>d__254 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001F74 RID: 8052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F74")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <DisplayMissionEndText>d__254(int <>1__state)
		{
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F75")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0000DD40 File Offset: 0x0000BF40
		[Token(Token = "0x6001F76")]
		[Address(RVA = "0xA77B10", Offset = "0xA76B10", VA = "0x180A77B10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000109")]
		private object Current
		{
			[Token(Token = "0x6001F77")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F78")]
		[Address(RVA = "0xA79280", Offset = "0xA78280", VA = "0x180A79280", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010A")]
		private object Current
		{
			[Token(Token = "0x6001F79")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002893 RID: 10387
		[Token(Token = "0x4002893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002894 RID: 10388
		[Token(Token = "0x4002894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002895 RID: 10389
		[Token(Token = "0x4002895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InterfaceController.ScreenDisplayType newType;

		// Token: 0x04002896 RID: 10390
		[Token(Token = "0x4002896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InterfaceController <>4__this;

		// Token: 0x04002897 RID: 10391
		[Token(Token = "0x4002897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Case forCase;

		// Token: 0x04002898 RID: 10392
		[Token(Token = "0x4002898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CanvasRenderer <rend>5__2;

		// Token: 0x04002899 RID: 10393
		[Token(Token = "0x4002899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <lastsFor>5__3;

		// Token: 0x0400289A RID: 10394
		[Token(Token = "0x400289A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float <timer>5__4;

		// Token: 0x0400289B RID: 10395
		[Token(Token = "0x400289B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool <firstFrame>5__5;
	}
}
