using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200048E RID: 1166
[Token(Token = "0x200048E")]
public class SceneRecorder
{
	// Token: 0x14000027 RID: 39
	// (add) Token: 0x06001A8E RID: 6798 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001A8F RID: 6799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000027")]
	public event SceneRecorder.OnCapture OnNewCapture
	{
		[Token(Token = "0x6001A8E")]
		[Address(RVA = "0x987000", Offset = "0x986000", VA = "0x180987000")]
		add
		{
		}
		[Token(Token = "0x6001A8F")]
		[Address(RVA = "0x9870F0", Offset = "0x9860F0", VA = "0x1809870F0")]
		remove
		{
		}
	}

	// Token: 0x06001A90 RID: 6800 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A90")]
	[Address(RVA = "0x9871E0", Offset = "0x9861E0", VA = "0x1809871E0")]
	public SceneRecorder(Interactable newInteractable)
	{
	}

	// Token: 0x06001A91 RID: 6801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A91")]
	[Address(RVA = "0x987600", Offset = "0x986600", VA = "0x180987600")]
	public void RefreshCoveredArea()
	{
	}

	// Token: 0x06001A92 RID: 6802 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A92")]
	[Address(RVA = "0x989080", Offset = "0x988080", VA = "0x180989080")]
	public SceneRecorder.SceneCapture ExecuteCapture(bool onlyIfMovement, bool detailedCapture = false, bool prepToSaveCapture = true, bool useFlashlight = false, bool useFlash = false, bool includePlayerModel = true, bool cctvCapture = false)
	{
		return null;
	}

	// Token: 0x0400203E RID: 8254
	[Token(Token = "0x400203E")]
	[FieldOffset(Offset = "0x10")]
	public Interactable interactable;

	// Token: 0x0400203F RID: 8255
	[Token(Token = "0x400203F")]
	[FieldOffset(Offset = "0x18")]
	public List<NewRoom> coversRooms;

	// Token: 0x04002040 RID: 8256
	[Token(Token = "0x4002040")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<NewNode, List<int>> coveredNodes;

	// Token: 0x04002041 RID: 8257
	[Token(Token = "0x4002041")]
	[FieldOffset(Offset = "0x0")]
	public static List<ScenePoserController> scenePoserPool;

	// Token: 0x04002042 RID: 8258
	[Token(Token = "0x4002042")]
	[FieldOffset(Offset = "0x8")]
	public static Dictionary<string, List<GameObject>> objectPoserPool;

	// Token: 0x04002043 RID: 8259
	[Token(Token = "0x4002043")]
	[FieldOffset(Offset = "0x28")]
	public float lastCaptureAt;

	// Token: 0x04002044 RID: 8260
	[Token(Token = "0x4002044")]
	[FieldOffset(Offset = "0x10")]
	public static int assignCapID;

	// Token: 0x0200048F RID: 1167
	// (Invoke) Token: 0x06001A95 RID: 6805
	[Token(Token = "0x200048F")]
	public delegate void OnCapture();

	// Token: 0x02000490 RID: 1168
	[Token(Token = "0x2000490")]
	[Serializable]
	public class SceneCapture
	{
		// Token: 0x06001A98 RID: 6808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A98")]
		[Address(RVA = "0x989A20", Offset = "0x988A20", VA = "0x180989A20")]
		public SceneCapture(SceneRecorder newRecorder, bool detailedCapture, bool flashLightActive = false, bool flashActive = false, bool includePlayerModel = true, bool cctvCapture = false)
		{
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A99")]
		[Address(RVA = "0x98C060", Offset = "0x98B060", VA = "0x18098C060")]
		public SceneCapture(SceneRecorder.SceneCapture copyFrom)
		{
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A9A")]
		[Address(RVA = "0x98C7D0", Offset = "0x98B7D0", VA = "0x18098C7D0")]
		public NewGameLocation GetCaptureGamelocation()
		{
			return null;
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0x98C8D0", Offset = "0x98B8D0", VA = "0x18098C8D0")]
		public NewRoom GetCaptureRoom()
		{
			return null;
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0000C678 File Offset: 0x0000A878
		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0x98C9D0", Offset = "0x98B9D0", VA = "0x18098C9D0")]
		public float GetDecimalClock()
		{
			return 0f;
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0000C690 File Offset: 0x0000A890
		[Token(Token = "0x6001A9D")]
		[Address(RVA = "0x98CBB0", Offset = "0x98BBB0", VA = "0x18098CBB0")]
		public Vector3 GetCaptureWorldPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		[Token(Token = "0x6001A9E")]
		[Address(RVA = "0x98CD20", Offset = "0x98BD20", VA = "0x18098CD20")]
		public Vector3 GetCaptureWorldRotation()
		{
			return default(Vector3);
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A9F")]
		[Address(RVA = "0x98CE70", Offset = "0x98BE70", VA = "0x18098CE70")]
		public string GetUniqueIDForInstance()
		{
			return null;
		}

		// Token: 0x04002046 RID: 8262
		[Token(Token = "0x4002046")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public SceneRecorder recorder;

		// Token: 0x04002047 RID: 8263
		[Token(Token = "0x4002047")]
		[FieldOffset(Offset = "0x18")]
		public int id;

		// Token: 0x04002048 RID: 8264
		[Token(Token = "0x4002048")]
		[FieldOffset(Offset = "0x20")]
		public List<SceneRecorder.DynamicRecordPosition> drp;

		// Token: 0x04002049 RID: 8265
		[Token(Token = "0x4002049")]
		[FieldOffset(Offset = "0x28")]
		public float t;

		// Token: 0x0400204A RID: 8266
		[Token(Token = "0x400204A")]
		[FieldOffset(Offset = "0x2C")]
		public bool k;

		// Token: 0x0400204B RID: 8267
		[Token(Token = "0x400204B")]
		[FieldOffset(Offset = "0x30")]
		public int l;

		// Token: 0x0400204C RID: 8268
		[Token(Token = "0x400204C")]
		[FieldOffset(Offset = "0x34")]
		public int a;

		// Token: 0x0400204D RID: 8269
		[Token(Token = "0x400204D")]
		[FieldOffset(Offset = "0x38")]
		public List<SceneRecorder.RoomCapture> rCap;

		// Token: 0x0400204E RID: 8270
		[Token(Token = "0x400204E")]
		[FieldOffset(Offset = "0x40")]
		public List<SceneRecorder.DoorCapture> dCap;

		// Token: 0x0400204F RID: 8271
		[Token(Token = "0x400204F")]
		[FieldOffset(Offset = "0x48")]
		public List<SceneRecorder.ActorCapture> aCap;

		// Token: 0x04002050 RID: 8272
		[Token(Token = "0x4002050")]
		[FieldOffset(Offset = "0x50")]
		public List<SceneRecorder.InteractableCapture> oCap;

		// Token: 0x04002051 RID: 8273
		[Token(Token = "0x4002051")]
		[FieldOffset(Offset = "0x58")]
		public List<SceneRecorder.InteractableStateCapture> oSCap;
	}

	// Token: 0x02000491 RID: 1169
	[Token(Token = "0x2000491")]
	[Serializable]
	public class DynamicRecordPosition
	{
		// Token: 0x06001AA0 RID: 6816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DynamicRecordPosition()
		{
		}

		// Token: 0x04002052 RID: 8274
		[Token(Token = "0x4002052")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 pos;

		// Token: 0x04002053 RID: 8275
		[Token(Token = "0x4002053")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 rot;
	}

	// Token: 0x02000492 RID: 1170
	[Token(Token = "0x2000492")]
	[Serializable]
	public class RoomCapture
	{
		// Token: 0x06001AA1 RID: 6817 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001AA1")]
		[Address(RVA = "0x98CE80", Offset = "0x98BE80", VA = "0x18098CE80")]
		public NewRoom GetRoom()
		{
			return null;
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public RoomCapture()
		{
		}

		// Token: 0x04002054 RID: 8276
		[Token(Token = "0x4002054")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x04002055 RID: 8277
		[Token(Token = "0x4002055")]
		[FieldOffset(Offset = "0x14")]
		public bool light;
	}

	// Token: 0x02000493 RID: 1171
	[Token(Token = "0x2000493")]
	[Serializable]
	public class TransformCapture
	{
		// Token: 0x06001AA3 RID: 6819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA3")]
		[Address(RVA = "0x98CF20", Offset = "0x98BF20", VA = "0x18098CF20")]
		public TransformCapture(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x04002056 RID: 8278
		[Token(Token = "0x4002056")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 wP;

		// Token: 0x04002057 RID: 8279
		[Token(Token = "0x4002057")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion wR;
	}

	// Token: 0x02000494 RID: 1172
	[Token(Token = "0x2000494")]
	[Serializable]
	public class DoorCapture
	{
		// Token: 0x06001AA4 RID: 6820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA4")]
		[Address(RVA = "0x98D070", Offset = "0x98C070", VA = "0x18098D070")]
		public DoorCapture(NewDoor door)
		{
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001AA5")]
		[Address(RVA = "0x98D0C0", Offset = "0x98C0C0", VA = "0x18098D0C0")]
		public NewDoor GetDoor()
		{
			return null;
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0000C6C0 File Offset: 0x0000A8C0
		[Token(Token = "0x6001AA6")]
		[Address(RVA = "0x98D160", Offset = "0x98C160", VA = "0x18098D160")]
		public bool IsOpen()
		{
			return default(bool);
		}

		// Token: 0x04002058 RID: 8280
		[Token(Token = "0x4002058")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x04002059 RID: 8281
		[Token(Token = "0x4002059")]
		[FieldOffset(Offset = "0x14")]
		public int a;

		// Token: 0x0400205A RID: 8282
		[Token(Token = "0x400205A")]
		[FieldOffset(Offset = "0x18")]
		public bool t;
	}

	// Token: 0x02000495 RID: 1173
	[Token(Token = "0x2000495")]
	[Serializable]
	public class InteractableCapture : SceneRecorder.TransformCapture
	{
		// Token: 0x06001AA7 RID: 6823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA7")]
		[Address(RVA = "0x98D170", Offset = "0x98C170", VA = "0x18098D170")]
		public InteractableCapture(Interactable newInter)
		{
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001AA8")]
		[Address(RVA = "0x98DA70", Offset = "0x98CA70", VA = "0x18098DA70")]
		public InteractablePreset GetPreset()
		{
			return null;
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA9")]
		[Address(RVA = "0x98DAD0", Offset = "0x98CAD0", VA = "0x18098DAD0")]
		public void Load()
		{
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAA")]
		[Address(RVA = "0x98EF90", Offset = "0x98DF90", VA = "0x18098EF90")]
		public void Unload()
		{
		}

		// Token: 0x0400205B RID: 8283
		[Token(Token = "0x400205B")]
		[FieldOffset(Offset = "0x30")]
		public string p;

		// Token: 0x0400205C RID: 8284
		[Token(Token = "0x400205C")]
		[FieldOffset(Offset = "0x38")]
		public List<string> d;

		// Token: 0x0400205D RID: 8285
		[Token(Token = "0x400205D")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public GameObject poser;

		// Token: 0x02000496 RID: 1174
		[Token(Token = "0x2000496")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001AAC RID: 6828 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001AAC")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c()
			{
			}

			// Token: 0x06001AAD RID: 6829 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
			[Token(Token = "0x6001AAD")]
			[Address(RVA = "0x96DD20", Offset = "0x96CD20", VA = "0x18096DD20")]
			internal bool <.ctor>b__3_0(Interactable.Passed item)
			{
				return default(bool);
			}

			// Token: 0x0400205E RID: 8286
			[Token(Token = "0x400205E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SceneRecorder.InteractableCapture.<>c <>9;

			// Token: 0x0400205F RID: 8287
			[Token(Token = "0x400205F")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<Interactable.Passed> <>9__3_0;
		}

		// Token: 0x02000497 RID: 1175
		[Token(Token = "0x2000497")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06001AAE RID: 6830 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001AAE")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x06001AAF RID: 6831 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
			[Token(Token = "0x6001AAF")]
			[Address(RVA = "0x98F610", Offset = "0x98E610", VA = "0x18098F610")]
			internal bool <Load>b__0(FurnitureLocation item)
			{
				return default(bool);
			}

			// Token: 0x06001AB0 RID: 6832 RVA: 0x0000C708 File Offset: 0x0000A908
			[Token(Token = "0x6001AB0")]
			[Address(RVA = "0x98F640", Offset = "0x98E640", VA = "0x18098F640")]
			internal bool <Load>b__1(ArtPreset item)
			{
				return default(bool);
			}

			// Token: 0x04002060 RID: 8288
			[Token(Token = "0x4002060")]
			[FieldOffset(Offset = "0x10")]
			public InteractablePreset pr;

			// Token: 0x04002061 RID: 8289
			[Token(Token = "0x4002061")]
			[FieldOffset(Offset = "0x18")]
			public SceneRecorder.InteractableCapture <>4__this;
		}
	}

	// Token: 0x02000498 RID: 1176
	[Token(Token = "0x2000498")]
	[Serializable]
	public class InteractableStateCapture
	{
		// Token: 0x06001AB1 RID: 6833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AB1")]
		[Address(RVA = "0x98F720", Offset = "0x98E720", VA = "0x18098F720")]
		public InteractableStateCapture(Interactable i)
		{
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AB2")]
		[Address(RVA = "0x98F750", Offset = "0x98E750", VA = "0x18098F750")]
		public void Load()
		{
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001AB3")]
		[Address(RVA = "0x98F940", Offset = "0x98E940", VA = "0x18098F940")]
		public Interactable GetInteractable()
		{
			return null;
		}

		// Token: 0x04002062 RID: 8290
		[Token(Token = "0x4002062")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x04002063 RID: 8291
		[Token(Token = "0x4002063")]
		[FieldOffset(Offset = "0x14")]
		public bool sw;
	}

	// Token: 0x02000499 RID: 1177
	[Token(Token = "0x2000499")]
	[Serializable]
	public class ActorCapture
	{
		// Token: 0x06001AB4 RID: 6836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AB4")]
		[Address(RVA = "0x98F9E0", Offset = "0x98E9E0", VA = "0x18098F9E0")]
		public ActorCapture(Human newHuman, bool limbCapture)
		{
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001AB5")]
		[Address(RVA = "0x791830", Offset = "0x790830", VA = "0x180791830")]
		public Human GetHuman()
		{
			return null;
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AB6")]
		[Address(RVA = "0x990EC0", Offset = "0x98FEC0", VA = "0x180990EC0")]
		public void Load()
		{
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AB7")]
		[Address(RVA = "0x9917E0", Offset = "0x9907E0", VA = "0x1809917E0")]
		public void Unload()
		{
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0000C720 File Offset: 0x0000A920
		[Token(Token = "0x6001AB8")]
		[Address(RVA = "0x991AB0", Offset = "0x990AB0", VA = "0x180991AB0")]
		private bool <Load>b__13_0(ScenePoserController item)
		{
			return default(bool);
		}

		// Token: 0x04002064 RID: 8292
		[Token(Token = "0x4002064")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x04002065 RID: 8293
		[Token(Token = "0x4002065")]
		[FieldOffset(Offset = "0x14")]
		public int o;

		// Token: 0x04002066 RID: 8294
		[Token(Token = "0x4002066")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 pos;

		// Token: 0x04002067 RID: 8295
		[Token(Token = "0x4002067")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 rot;

		// Token: 0x04002068 RID: 8296
		[Token(Token = "0x4002068")]
		[FieldOffset(Offset = "0x30")]
		public int main;

		// Token: 0x04002069 RID: 8297
		[Token(Token = "0x4002069")]
		[FieldOffset(Offset = "0x34")]
		public int arms;

		// Token: 0x0400206A RID: 8298
		[Token(Token = "0x400206A")]
		[FieldOffset(Offset = "0x38")]
		public int sp;

		// Token: 0x0400206B RID: 8299
		[Token(Token = "0x400206B")]
		[FieldOffset(Offset = "0x40")]
		public List<SceneRecorder.LimbCapture> limb;

		// Token: 0x0400206C RID: 8300
		[Token(Token = "0x400206C")]
		[FieldOffset(Offset = "0x48")]
		public SceneRecorder.HandItemCapture lH;

		// Token: 0x0400206D RID: 8301
		[Token(Token = "0x400206D")]
		[FieldOffset(Offset = "0x50")]
		public SceneRecorder.HandItemCapture rH;

		// Token: 0x0400206E RID: 8302
		[Token(Token = "0x400206E")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public ScenePoserController poser;
	}

	// Token: 0x0200049A RID: 1178
	[Token(Token = "0x200049A")]
	[Serializable]
	public class LimbCapture : SceneRecorder.TransformCapture
	{
		// Token: 0x06001AB9 RID: 6841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AB9")]
		[Address(RVA = "0x991BF0", Offset = "0x990BF0", VA = "0x180991BF0")]
		public LimbCapture(CitizenOutfitController.CharacterAnchor anchor, Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x0400206F RID: 8303
		[Token(Token = "0x400206F")]
		[FieldOffset(Offset = "0x30")]
		public int a;
	}

	// Token: 0x0200049B RID: 1179
	[Token(Token = "0x200049B")]
	[Serializable]
	public class HandItemCapture : SceneRecorder.TransformCapture
	{
		// Token: 0x06001ABA RID: 6842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ABA")]
		[Address(RVA = "0x991C40", Offset = "0x990C40", VA = "0x180991C40")]
		public HandItemCapture(GameObject obj, Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x04002070 RID: 8304
		[Token(Token = "0x4002070")]
		[FieldOffset(Offset = "0x30")]
		public string i;
	}
}
