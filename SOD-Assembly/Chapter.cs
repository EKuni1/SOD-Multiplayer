using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000283 RID: 643
[Token(Token = "0x2000283")]
public class Chapter : MonoBehaviour
{
	// Token: 0x06000E44 RID: 3652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E44")]
	[Address(RVA = "0x650EC0", Offset = "0x64FEC0", VA = "0x180650EC0")]
	public void Awake()
	{
	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E45")]
	[Address(RVA = "0x6514C0", Offset = "0x6504C0", VA = "0x1806514C0", Slot = "4")]
	public virtual void OnLoaded()
	{
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E46")]
	[Address(RVA = "0x651EE0", Offset = "0x650EE0", VA = "0x180651EE0", Slot = "5")]
	public virtual void OnLoadFinalize()
	{
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E47")]
	[Address(RVA = "0x651F20", Offset = "0x650F20", VA = "0x180651F20", Slot = "6")]
	public virtual void OnObjectsCreated()
	{
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E48")]
	[Address(RVA = "0x651F60", Offset = "0x650F60", VA = "0x180651F60", Slot = "7")]
	public virtual void OnGameStart()
	{
	}

	// Token: 0x06000E49 RID: 3657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E49")]
	[Address(RVA = "0x652400", Offset = "0x651400", VA = "0x180652400")]
	public void ClearAllObjectives()
	{
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E4A")]
	[Address(RVA = "0x6528A0", Offset = "0x6518A0", VA = "0x1806528A0")]
	public void ClearObjective(string clearThis)
	{
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E4B")]
	[Address(RVA = "0x653100", Offset = "0x652100", VA = "0x180653100", Slot = "8")]
	public virtual void OnNewChapterPart(bool delay = false, bool teleportPlayer = false)
	{
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E4C")]
	[Address(RVA = "0x6534A0", Offset = "0x6524A0", VA = "0x1806534A0")]
	private IEnumerator ChapterActivationDelay()
	{
		return null;
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E4D")]
	[Address(RVA = "0x653540", Offset = "0x652540", VA = "0x180653540")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E4E")]
	[Address(RVA = "0x653A20", Offset = "0x652A20", VA = "0x180653A20", Slot = "9")]
	public virtual void OnGameWorldLoop()
	{
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E4F")]
	[Address(RVA = "0x653F30", Offset = "0x652F30", VA = "0x180653F30")]
	public void InvokeAfterDelay(string command, float delayRealSeconds)
	{
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E50")]
	[Address(RVA = "0x654020", Offset = "0x653020", VA = "0x180654020", Slot = "10")]
	public virtual void SetCurrentPartLocation(NewNode newNode)
	{
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E51")]
	[Address(RVA = "0x6541D0", Offset = "0x6531D0", VA = "0x1806541D0", Slot = "11")]
	public virtual void PlayerVO(string entryRef, float delay = 0f, bool useParsing = true, bool shouting = false, bool interupt = false, bool forceColour = false, [Optional] Color color)
	{
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E52")]
	[Address(RVA = "0x6545F0", Offset = "0x6535F0", VA = "0x1806545F0", Slot = "12")]
	public virtual void AddObjective(string entryRef, List<Objective.ObjectiveTrigger> triggers, bool usePointer = false, [Optional] Vector3 pointerPosition, InterfaceControls.Icon useIcon = InterfaceControls.Icon.lookingGlass, Objective.OnCompleteAction onCompleteAction = Objective.OnCompleteAction.nextChapterPart, float delay = 0f, bool removePrevious = false, string chapterString = "", bool isSilent = false, bool allowCrouchPromt = false, bool useParsing = true)
	{
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E53")]
	[Address(RVA = "0x654EA0", Offset = "0x653EA0", VA = "0x180654EA0", Slot = "13")]
	public virtual void AddObjective(string entryRef, Objective.ObjectiveTrigger trigger, bool usePointer = false, [Optional] Vector3 pointerPosition, InterfaceControls.Icon useIcon = InterfaceControls.Icon.lookingGlass, Objective.OnCompleteAction onCompleteAction = Objective.OnCompleteAction.nextChapterPart, float delay = 0f, bool removePrevious = false, string chapterString = "", bool isSilent = false, bool allowCrouchPromt = false)
	{
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E54")]
	[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "14")]
	public virtual StateSaveData.ChaperStateSave GetChapterSaveData()
	{
		return null;
	}

	// Token: 0x06000E55 RID: 3669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E55")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "15")]
	public virtual void LoadStateSaveData(StateSaveData.ChaperStateSave newData)
	{
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E56")]
	[Address(RVA = "0x655020", Offset = "0x654020", VA = "0x180655020")]
	public Interactable LoadInteractableFromData(string reference, ref StateSaveData.ChaperStateSave saveData)
	{
		return null;
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E57")]
	[Address(RVA = "0x6554C0", Offset = "0x6544C0", VA = "0x1806554C0")]
	public Chapter()
	{
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x00007788 File Offset: 0x00005988
	[Token(Token = "0x6000E58")]
	[Address(RVA = "0x6555E0", Offset = "0x6545E0", VA = "0x1806555E0")]
	private bool <OnLoaded>b__13_0(Case item)
	{
		return default(bool);
	}

	// Token: 0x0400107C RID: 4220
	[Token(Token = "0x400107C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ChapterPreset preset;

	// Token: 0x0400107D RID: 4221
	[Token(Token = "0x400107D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public Case thisCase;

	// Token: 0x0400107E RID: 4222
	[Token(Token = "0x400107E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool loadedFromSave;

	// Token: 0x0400107F RID: 4223
	[Token(Token = "0x400107F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool gameStart;

	// Token: 0x04001080 RID: 4224
	[Token(Token = "0x4001080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float blackTimer;

	// Token: 0x04001081 RID: 4225
	[Token(Token = "0x4001081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float blurTimer;

	// Token: 0x04001082 RID: 4226
	[Token(Token = "0x4001082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float blackFade;

	// Token: 0x04001083 RID: 4227
	[Token(Token = "0x4001083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float blurFade;

	// Token: 0x04001084 RID: 4228
	[Token(Token = "0x4001084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public NewNode currentPartLocation;

	// Token: 0x04001085 RID: 4229
	[Token(Token = "0x4001085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool teleportPlayerToChapter;

	// Token: 0x04001086 RID: 4230
	[Token(Token = "0x4001086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool chapterFrameDelay;

	// Token: 0x04001087 RID: 4231
	[Token(Token = "0x4001087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Dictionary<string, float> invokeOnDelay;

	// Token: 0x02000284 RID: 644
	[Token(Token = "0x2000284")]
	private sealed class <>c__DisplayClass18_0
	{
		// Token: 0x06000E59 RID: 3673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass18_0()
		{
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x655670", Offset = "0x654670", VA = "0x180655670")]
		internal bool <ClearObjective>b__0(SpeechController.QueueElement item)
		{
			return default(bool);
		}

		// Token: 0x04001088 RID: 4232
		[Token(Token = "0x4001088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string clearThis;
	}

	// Token: 0x02000285 RID: 645
	[Token(Token = "0x2000285")]
	private sealed class <ChapterActivationDelay>d__20 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000E5B RID: 3675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <ChapterActivationDelay>d__20(int <>1__state)
		{
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x000077B8 File Offset: 0x000059B8
		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x655710", Offset = "0x654710", VA = "0x180655710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000077")]
		private object Current
		{
			[Token(Token = "0x6000E5E")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x655B60", Offset = "0x654B60", VA = "0x180655B60", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000078")]
		private object Current
		{
			[Token(Token = "0x6000E60")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001089 RID: 4233
		[Token(Token = "0x4001089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400108A RID: 4234
		[Token(Token = "0x400108A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400108B RID: 4235
		[Token(Token = "0x400108B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Chapter <>4__this;

		// Token: 0x0400108C RID: 4236
		[Token(Token = "0x400108C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <frameDelay>5__2;

		// Token: 0x0400108D RID: 4237
		[Token(Token = "0x400108D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MethodInfo <method>5__3;

		// Token: 0x0400108E RID: 4238
		[Token(Token = "0x400108E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object[] <passed>5__4;
	}

	// Token: 0x02000286 RID: 646
	[Token(Token = "0x2000286")]
	private sealed class <>c__DisplayClass25_0
	{
		// Token: 0x06000E61 RID: 3681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass25_0()
		{
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x000077D0 File Offset: 0x000059D0
		[Token(Token = "0x6000E62")]
		[Address(RVA = "0x655BB0", Offset = "0x654BB0", VA = "0x180655BB0")]
		internal bool <PlayerVO>b__0(SpeechController.QueueElement item)
		{
			return default(bool);
		}

		// Token: 0x0400108F RID: 4239
		[Token(Token = "0x400108F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string entryRef;
	}

	// Token: 0x02000287 RID: 647
	[Token(Token = "0x2000287")]
	private sealed class <>c__DisplayClass26_0
	{
		// Token: 0x06000E63 RID: 3683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E63")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass26_0()
		{
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x6000E64")]
		[Address(RVA = "0x64F580", Offset = "0x64E580", VA = "0x18064F580")]
		internal bool <AddObjective>b__0(Objective item)
		{
			return default(bool);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x6000E65")]
		[Address(RVA = "0x64F580", Offset = "0x64E580", VA = "0x18064F580")]
		internal bool <AddObjective>b__1(Objective item)
		{
			return default(bool);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00007818 File Offset: 0x00005A18
		[Token(Token = "0x6000E66")]
		[Address(RVA = "0x64F580", Offset = "0x64E580", VA = "0x18064F580")]
		internal bool <AddObjective>b__2(Objective item)
		{
			return default(bool);
		}

		// Token: 0x04001090 RID: 4240
		[Token(Token = "0x4001090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string entryRef;
	}

	// Token: 0x02000288 RID: 648
	[Token(Token = "0x2000288")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000E68 RID: 3688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E68")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00007830 File Offset: 0x00005A30
		[Token(Token = "0x6000E69")]
		[Address(RVA = "0x64F370", Offset = "0x64E370", VA = "0x18064F370")]
		internal bool <AddObjective>b__26_3(SpeechController.QueueElement item)
		{
			return default(bool);
		}

		// Token: 0x04001091 RID: 4241
		[Token(Token = "0x4001091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Chapter.<>c <>9;

		// Token: 0x04001092 RID: 4242
		[Token(Token = "0x4001092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<SpeechController.QueueElement> <>9__26_3;
	}

	// Token: 0x02000289 RID: 649
	[Token(Token = "0x2000289")]
	private sealed class <>c__DisplayClass30_0
	{
		// Token: 0x06000E6A RID: 3690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass30_0()
		{
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00007848 File Offset: 0x00005A48
		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <LoadInteractableFromData>b__0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04001093 RID: 4243
		[Token(Token = "0x4001093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;
	}
}
