using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200032C RID: 812
[Token(Token = "0x200032C")]
public class ControlsDisplayController : MonoBehaviour
{
	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06001247 RID: 4679 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700009F")]
	public static ControlsDisplayController Instance
	{
		[Token(Token = "0x6001247")]
		[Address(RVA = "0x701040", Offset = "0x700040", VA = "0x180701040")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001248 RID: 4680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001248")]
	[Address(RVA = "0x701080", Offset = "0x700080", VA = "0x180701080")]
	private void Awake()
	{
	}

	// Token: 0x06001249 RID: 4681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001249")]
	[Address(RVA = "0x7013D0", Offset = "0x7003D0", VA = "0x1807013D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600124A RID: 4682 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600124A")]
	[Address(RVA = "0x7015E0", Offset = "0x7005E0", VA = "0x1807015E0")]
	public void UpdateControlDisplay()
	{
	}

	// Token: 0x0600124B RID: 4683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600124B")]
	[Address(RVA = "0x703270", Offset = "0x702270", VA = "0x180703270")]
	private void Update()
	{
	}

	// Token: 0x0600124C RID: 4684 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600124C")]
	[Address(RVA = "0x703A80", Offset = "0x702A80", VA = "0x180703A80")]
	public void RestoreDefaultDisplayArea()
	{
	}

	// Token: 0x0600124D RID: 4685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600124D")]
	[Address(RVA = "0x703B80", Offset = "0x702B80", VA = "0x180703B80")]
	public void SetControlDisplayArea(float yPos, float height, float rectFromLeft, float rectFromRight)
	{
	}

	// Token: 0x0600124E RID: 4686 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600124E")]
	[Address(RVA = "0x703C00", Offset = "0x702C00", VA = "0x180703C00")]
	public void DisplayControlIconAfterDelay(float afterSeconds, InteractablePreset.InteractionKey key, string interactionName, float forTime, bool overrideMinDisplayTime = false)
	{
	}

	// Token: 0x0600124F RID: 4687 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600124F")]
	[Address(RVA = "0x703D60", Offset = "0x702D60", VA = "0x180703D60")]
	private IEnumerator DisplayControlIconAfter(float afterSeconds, InteractablePreset.InteractionKey key, string interactionName, float forTime, bool overrideMinDisplayTime)
	{
		return null;
	}

	// Token: 0x06001250 RID: 4688 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001250")]
	[Address(RVA = "0x703EB0", Offset = "0x702EB0", VA = "0x180703EB0")]
	public void DisplayControlIcon(InteractablePreset.InteractionKey key, string interactionName, float forTime, bool overrideMinDisplayTime = false)
	{
	}

	// Token: 0x06001251 RID: 4689 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001251")]
	[Address(RVA = "0x704310", Offset = "0x703310", VA = "0x180704310")]
	public string GetControlIcon(InteractablePreset.InteractionKey key, out ControlDisplayController.ControlPositioning positioning, out bool foundControl)
	{
		return null;
	}

	// Token: 0x06001252 RID: 4690 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001252")]
	[Address(RVA = "0x705080", Offset = "0x704080", VA = "0x180705080")]
	public ControlsDisplayController()
	{
	}

	// Token: 0x040016C0 RID: 5824
	[Token(Token = "0x40016C0")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x040016C1 RID: 5825
	[Token(Token = "0x40016C1")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform anchor;

	// Token: 0x040016C2 RID: 5826
	[Token(Token = "0x40016C2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject controlDisplayPrefab;

	// Token: 0x040016C3 RID: 5827
	[Token(Token = "0x40016C3")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 padding;

	// Token: 0x040016C4 RID: 5828
	[Token(Token = "0x40016C4")]
	[FieldOffset(Offset = "0x38")]
	public float animationSelectTime;

	// Token: 0x040016C5 RID: 5829
	[Token(Token = "0x40016C5")]
	[FieldOffset(Offset = "0x40")]
	public AnimationCurve controlSelectAnimation;

	// Token: 0x040016C6 RID: 5830
	[Token(Token = "0x40016C6")]
	[FieldOffset(Offset = "0x48")]
	public float controlSelectScaleLerp;

	// Token: 0x040016C7 RID: 5831
	[Token(Token = "0x40016C7")]
	[FieldOffset(Offset = "0x4C")]
	public Color controlSelectColorLerp;

	// Token: 0x040016C8 RID: 5832
	[Token(Token = "0x40016C8")]
	[FieldOffset(Offset = "0x5C")]
	public Color audioFullColor;

	// Token: 0x040016C9 RID: 5833
	[Token(Token = "0x40016C9")]
	[FieldOffset(Offset = "0x6C")]
	public Color audioEmptyColor;

	// Token: 0x040016CA RID: 5834
	[Token(Token = "0x40016CA")]
	[FieldOffset(Offset = "0x7C")]
	private float posChangeProgress;

	// Token: 0x040016CB RID: 5835
	[Token(Token = "0x40016CB")]
	[FieldOffset(Offset = "0x80")]
	private float desiredYPos;

	// Token: 0x040016CC RID: 5836
	[Token(Token = "0x40016CC")]
	[FieldOffset(Offset = "0x84")]
	private float desiredHeight;

	// Token: 0x040016CD RID: 5837
	[Token(Token = "0x40016CD")]
	[FieldOffset(Offset = "0x88")]
	private float desiredRectFromLeft;

	// Token: 0x040016CE RID: 5838
	[Token(Token = "0x40016CE")]
	[FieldOffset(Offset = "0x8C")]
	private float desiredRectFromRight;

	// Token: 0x040016CF RID: 5839
	[Token(Token = "0x40016CF")]
	[FieldOffset(Offset = "0x90")]
	public float minimumCustomControlDisplayTimeInterval;

	// Token: 0x040016D0 RID: 5840
	[Token(Token = "0x40016D0")]
	[FieldOffset(Offset = "0x98")]
	public List<ControlDisplayController> spawned;

	// Token: 0x040016D1 RID: 5841
	[Token(Token = "0x40016D1")]
	[FieldOffset(Offset = "0xA0")]
	public List<ControlsDisplayController.CustomActionsDisplayed> customActionsDisplayed;

	// Token: 0x040016D2 RID: 5842
	[Token(Token = "0x40016D2")]
	[FieldOffset(Offset = "0xA8")]
	public List<InteractablePreset.InteractionKey> disableControlDisplay;

	// Token: 0x040016D3 RID: 5843
	[Token(Token = "0x40016D3")]
	[FieldOffset(Offset = "0x0")]
	private static ControlsDisplayController _instance;

	// Token: 0x0200032D RID: 813
	[Token(Token = "0x200032D")]
	public class CustomActionsDisplayed
	{
		// Token: 0x06001253 RID: 4691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001253")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public CustomActionsDisplayed()
		{
		}

		// Token: 0x040016D4 RID: 5844
		[Token(Token = "0x40016D4")]
		[FieldOffset(Offset = "0x10")]
		public InteractablePreset.InteractionKey key;

		// Token: 0x040016D5 RID: 5845
		[Token(Token = "0x40016D5")]
		[FieldOffset(Offset = "0x18")]
		public string interactionName;

		// Token: 0x040016D6 RID: 5846
		[Token(Token = "0x40016D6")]
		[FieldOffset(Offset = "0x20")]
		public float displayTime;

		// Token: 0x040016D7 RID: 5847
		[Token(Token = "0x40016D7")]
		[FieldOffset(Offset = "0x24")]
		public float lastDisplayedAt;

		// Token: 0x040016D8 RID: 5848
		[Token(Token = "0x40016D8")]
		[FieldOffset(Offset = "0x28")]
		public Interactable.InteractableCurrentAction action;
	}

	// Token: 0x0200032E RID: 814
	[Token(Token = "0x200032E")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001255 RID: 4693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001255")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00008B80 File Offset: 0x00006D80
		[Token(Token = "0x6001256")]
		[Address(RVA = "0x7053D0", Offset = "0x7043D0", VA = "0x1807053D0")]
		internal int <UpdateControlDisplay>b__25_0(ControlDisplayController p2, ControlDisplayController p1)
		{
			return 0;
		}

		// Token: 0x040016D9 RID: 5849
		[Token(Token = "0x40016D9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ControlsDisplayController.<>c <>9;

		// Token: 0x040016DA RID: 5850
		[Token(Token = "0x40016DA")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<ControlDisplayController> <>9__25_0;
	}

	// Token: 0x0200032F RID: 815
	[Token(Token = "0x200032F")]
	private sealed class <DisplayControlIconAfter>d__30 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001257 RID: 4695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001257")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <DisplayControlIconAfter>d__30(int <>1__state)
		{
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001258")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00008B98 File Offset: 0x00006D98
		[Token(Token = "0x6001259")]
		[Address(RVA = "0x705420", Offset = "0x704420", VA = "0x180705420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000A0")]
		private object Current
		{
			[Token(Token = "0x600125A")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125B")]
		[Address(RVA = "0x705550", Offset = "0x704550", VA = "0x180705550", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000A1")]
		private object Current
		{
			[Token(Token = "0x600125C")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040016DB RID: 5851
		[Token(Token = "0x40016DB")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040016DC RID: 5852
		[Token(Token = "0x40016DC")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040016DD RID: 5853
		[Token(Token = "0x40016DD")]
		[FieldOffset(Offset = "0x20")]
		public float afterSeconds;

		// Token: 0x040016DE RID: 5854
		[Token(Token = "0x40016DE")]
		[FieldOffset(Offset = "0x28")]
		public ControlsDisplayController <>4__this;

		// Token: 0x040016DF RID: 5855
		[Token(Token = "0x40016DF")]
		[FieldOffset(Offset = "0x30")]
		public InteractablePreset.InteractionKey key;

		// Token: 0x040016E0 RID: 5856
		[Token(Token = "0x40016E0")]
		[FieldOffset(Offset = "0x38")]
		public string interactionName;

		// Token: 0x040016E1 RID: 5857
		[Token(Token = "0x40016E1")]
		[FieldOffset(Offset = "0x40")]
		public float forTime;

		// Token: 0x040016E2 RID: 5858
		[Token(Token = "0x40016E2")]
		[FieldOffset(Offset = "0x44")]
		public bool overrideMinDisplayTime;
	}

	// Token: 0x02000330 RID: 816
	[Token(Token = "0x2000330")]
	private sealed class <>c__DisplayClass31_0
	{
		// Token: 0x0600125D RID: 4701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass31_0()
		{
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00008BB0 File Offset: 0x00006DB0
		[Token(Token = "0x600125E")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <DisplayControlIcon>b__0(ControlsDisplayController.CustomActionsDisplayed item)
		{
			return default(bool);
		}

		// Token: 0x040016E3 RID: 5859
		[Token(Token = "0x40016E3")]
		[FieldOffset(Offset = "0x10")]
		public InteractablePreset.InteractionKey key;
	}
}
