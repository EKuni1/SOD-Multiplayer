using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000960 RID: 2400
	[Token(Token = "0x2000960")]
	public class Window : MonoBehaviour
	{
		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600330F RID: 13071 RVA: 0x000120D8 File Offset: 0x000102D8
		[Token(Token = "0x17000504")]
		public bool hasFocus
		{
			[Token(Token = "0x600330F")]
			[Address(RVA = "0xD345C0", Offset = "0xD335C0", VA = "0x180D345C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06003310 RID: 13072 RVA: 0x000120F0 File Offset: 0x000102F0
		[Token(Token = "0x17000505")]
		public int id
		{
			[Token(Token = "0x6003310")]
			[Address(RVA = "0xCF6F20", Offset = "0xCF5F20", VA = "0x180CF6F20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06003311 RID: 13073 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000506")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6003311")]
			[Address(RVA = "0xD345F0", Offset = "0xD335F0", VA = "0x180D345F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06003312 RID: 13074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000507")]
		public TMP_Text titleText
		{
			[Token(Token = "0x6003312")]
			[Address(RVA = "0xD166F0", Offset = "0xD156F0", VA = "0x180D166F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06003313 RID: 13075 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000508")]
		public List<TMP_Text> contentText
		{
			[Token(Token = "0x6003313")]
			[Address(RVA = "0x728A20", Offset = "0x727A20", VA = "0x180728A20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06003314 RID: 13076 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003315 RID: 13077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000509")]
		public GameObject defaultUIElement
		{
			[Token(Token = "0x6003314")]
			[Address(RVA = "0xD13B00", Offset = "0xD12B00", VA = "0x180D13B00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003315")]
			[Address(RVA = "0xD13B10", Offset = "0xD12B10", VA = "0x180D13B10")]
			set
			{
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06003316 RID: 13078 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003317 RID: 13079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700050A")]
		public Action<int> updateCallback
		{
			[Token(Token = "0x6003316")]
			[Address(RVA = "0x3E97E0", Offset = "0x3E87E0", VA = "0x1803E97E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003317")]
			[Address(RVA = "0xD347B0", Offset = "0xD337B0", VA = "0x180D347B0")]
			set
			{
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06003318 RID: 13080 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700050B")]
		public Window.Timer timer
		{
			[Token(Token = "0x6003318")]
			[Address(RVA = "0xD168E0", Offset = "0xD158E0", VA = "0x180D168E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06003319 RID: 13081 RVA: 0x00012108 File Offset: 0x00010308
		// (set) Token: 0x0600331A RID: 13082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700050C")]
		public int width
		{
			[Token(Token = "0x6003319")]
			[Address(RVA = "0xD34810", Offset = "0xD33810", VA = "0x180D34810")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600331A")]
			[Address(RVA = "0xD34890", Offset = "0xD33890", VA = "0x180D34890")]
			set
			{
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600331B RID: 13083 RVA: 0x00012120 File Offset: 0x00010320
		// (set) Token: 0x0600331C RID: 13084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700050D")]
		public int height
		{
			[Token(Token = "0x600331B")]
			[Address(RVA = "0xD34990", Offset = "0xD33990", VA = "0x180D34990")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600331C")]
			[Address(RVA = "0xD34A10", Offset = "0xD33A10", VA = "0x180D34A10")]
			set
			{
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x0600331D RID: 13085 RVA: 0x00012138 File Offset: 0x00010338
		[Token(Token = "0x1700050E")]
		protected bool initialized
		{
			[Token(Token = "0x600331D")]
			[Address(RVA = "0xD34B10", Offset = "0xD33B10", VA = "0x180D34B10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600331E")]
		[Address(RVA = "0xD34B20", Offset = "0xD33B20", VA = "0x180D34B20")]
		private void OnEnable()
		{
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600331F")]
		[Address(RVA = "0xD34B70", Offset = "0xD33B70", VA = "0x180D34B70", Slot = "4")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003320")]
		[Address(RVA = "0xD34BE0", Offset = "0xD33BE0", VA = "0x180D34BE0", Slot = "5")]
		public virtual void Initialize(int id, Func<int, bool> isFocusedCallback)
		{
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003321")]
		[Address(RVA = "0xD34E60", Offset = "0xD33E60", VA = "0x180D34E60")]
		public void SetSize(int width, int height)
		{
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003322")]
		[Address(RVA = "0xD34F00", Offset = "0xD33F00", VA = "0x180D34F00")]
		public void CreateTitleText(GameObject prefab, Vector2 offset)
		{
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003323")]
		[Address(RVA = "0xD34FB0", Offset = "0xD33FB0", VA = "0x180D34FB0")]
		public void CreateTitleText(GameObject prefab, Vector2 offset, string text)
		{
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003324")]
		[Address(RVA = "0xD35170", Offset = "0xD34170", VA = "0x180D35170")]
		public void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003325")]
		[Address(RVA = "0xD35290", Offset = "0xD34290", VA = "0x180D35290")]
		public void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text)
		{
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003326")]
		[Address(RVA = "0xD35400", Offset = "0xD34400", VA = "0x180D35400")]
		public void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003327")]
		[Address(RVA = "0xD35400", Offset = "0xD34400", VA = "0x180D35400")]
		public void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text)
		{
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003328")]
		[Address(RVA = "0xD354A0", Offset = "0xD344A0", VA = "0x180D354A0")]
		public void CreateButton(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string buttonText, UnityAction confirmCallback, UnityAction cancelCallback, bool setDefault)
		{
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003329")]
		[Address(RVA = "0xD35A80", Offset = "0xD34A80", VA = "0x180D35A80")]
		public string GetTitleText(string text)
		{
			return null;
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600332A")]
		[Address(RVA = "0xD35BD0", Offset = "0xD34BD0", VA = "0x180D35BD0")]
		public void SetTitleText(string text)
		{
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600332B")]
		[Address(RVA = "0xD35D00", Offset = "0xD34D00", VA = "0x180D35D00")]
		public string GetContentText(int index)
		{
			return null;
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x00012150 File Offset: 0x00010350
		[Token(Token = "0x600332C")]
		[Address(RVA = "0xD35EF0", Offset = "0xD34EF0", VA = "0x180D35EF0")]
		public float GetContentTextHeight(int index)
		{
			return 0f;
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600332D")]
		[Address(RVA = "0xD360D0", Offset = "0xD350D0", VA = "0x180D360D0")]
		public void SetContentText(string text, int index)
		{
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600332E")]
		[Address(RVA = "0xD347B0", Offset = "0xD337B0", VA = "0x180D347B0")]
		public void SetUpdateCallback(Action<int> callback)
		{
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600332F")]
		[Address(RVA = "0xD36290", Offset = "0xD35290", VA = "0x180D36290", Slot = "6")]
		public virtual void TakeInputFocus()
		{
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003330")]
		[Address(RVA = "0xD36410", Offset = "0xD35410", VA = "0x180D36410", Slot = "7")]
		public virtual void Enable()
		{
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003331")]
		[Address(RVA = "0xD36470", Offset = "0xD35470", VA = "0x180D36470", Slot = "8")]
		public virtual void Disable()
		{
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003332")]
		[Address(RVA = "0xD364D0", Offset = "0xD354D0", VA = "0x180D364D0", Slot = "9")]
		public virtual void Cancel()
		{
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003333")]
		[Address(RVA = "0xD36500", Offset = "0xD35500", VA = "0x180D36500")]
		private void CreateText(GameObject prefab, ref TMP_Text textComponent, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003334")]
		[Address(RVA = "0xD369B0", Offset = "0xD359B0", VA = "0x180D369B0")]
		private void CreateImage(GameObject prefab, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003335")]
		[Address(RVA = "0xD36C70", Offset = "0xD35C70", VA = "0x180D36C70")]
		private GameObject CreateButton(GameObject prefab, string name, UIAnchor anchor, UIPivot pivot, Vector2 offset, out ButtonInfo buttonInfo)
		{
			return null;
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003336")]
		[Address(RVA = "0xD37230", Offset = "0xD36230", VA = "0x180D37230")]
		private IEnumerator OnEnableAsync()
		{
			return null;
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003337")]
		[Address(RVA = "0xD372D0", Offset = "0xD362D0", VA = "0x180D372D0")]
		private void CheckUISelection()
		{
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003338")]
		[Address(RVA = "0xD37700", Offset = "0xD36700", VA = "0x180D37700")]
		private void RestoreDefaultOrLastUISelection()
		{
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003339")]
		[Address(RVA = "0xD37890", Offset = "0xD36890", VA = "0x180D37890")]
		private void SetUISelection(GameObject selection)
		{
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600333A")]
		[Address(RVA = "0xD28640", Offset = "0xD27640", VA = "0x180D28640")]
		public Window()
		{
		}

		// Token: 0x04004FF6 RID: 20470
		[Token(Token = "0x4004FF6")]
		[FieldOffset(Offset = "0x18")]
		public Image backgroundImage;

		// Token: 0x04004FF7 RID: 20471
		[Token(Token = "0x4004FF7")]
		[FieldOffset(Offset = "0x20")]
		public GameObject content;

		// Token: 0x04004FF8 RID: 20472
		[Token(Token = "0x4004FF8")]
		[FieldOffset(Offset = "0x28")]
		private bool _initialized;

		// Token: 0x04004FF9 RID: 20473
		[Token(Token = "0x4004FF9")]
		[FieldOffset(Offset = "0x2C")]
		private int _id;

		// Token: 0x04004FFA RID: 20474
		[Token(Token = "0x4004FFA")]
		[FieldOffset(Offset = "0x30")]
		private RectTransform _rectTransform;

		// Token: 0x04004FFB RID: 20475
		[Token(Token = "0x4004FFB")]
		[FieldOffset(Offset = "0x38")]
		private TMP_Text _titleText;

		// Token: 0x04004FFC RID: 20476
		[Token(Token = "0x4004FFC")]
		[FieldOffset(Offset = "0x40")]
		private List<TMP_Text> _contentText;

		// Token: 0x04004FFD RID: 20477
		[Token(Token = "0x4004FFD")]
		[FieldOffset(Offset = "0x48")]
		private GameObject _defaultUIElement;

		// Token: 0x04004FFE RID: 20478
		[Token(Token = "0x4004FFE")]
		[FieldOffset(Offset = "0x50")]
		private Action<int> _updateCallback;

		// Token: 0x04004FFF RID: 20479
		[Token(Token = "0x4004FFF")]
		[FieldOffset(Offset = "0x58")]
		private Func<int, bool> _isFocusedCallback;

		// Token: 0x04005000 RID: 20480
		[Token(Token = "0x4005000")]
		[FieldOffset(Offset = "0x60")]
		private Window.Timer _timer;

		// Token: 0x04005001 RID: 20481
		[Token(Token = "0x4005001")]
		[FieldOffset(Offset = "0x68")]
		private CanvasGroup _canvasGroup;

		// Token: 0x04005002 RID: 20482
		[Token(Token = "0x4005002")]
		[FieldOffset(Offset = "0x70")]
		public UnityAction cancelCallback;

		// Token: 0x04005003 RID: 20483
		[Token(Token = "0x4005003")]
		[FieldOffset(Offset = "0x78")]
		private GameObject lastUISelection;

		// Token: 0x02000961 RID: 2401
		[Token(Token = "0x2000961")]
		public class Timer
		{
			// Token: 0x1700050F RID: 1295
			// (get) Token: 0x0600333B RID: 13115 RVA: 0x00012168 File Offset: 0x00010368
			[Token(Token = "0x1700050F")]
			public bool started
			{
				[Token(Token = "0x600333B")]
				[Address(RVA = "0xCDA3F0", Offset = "0xCD93F0", VA = "0x180CDA3F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000510 RID: 1296
			// (get) Token: 0x0600333C RID: 13116 RVA: 0x00012180 File Offset: 0x00010380
			[Token(Token = "0x17000510")]
			public bool finished
			{
				[Token(Token = "0x600333C")]
				[Address(RVA = "0xD379F0", Offset = "0xD369F0", VA = "0x180D379F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000511 RID: 1297
			// (get) Token: 0x0600333D RID: 13117 RVA: 0x00012198 File Offset: 0x00010398
			[Token(Token = "0x17000511")]
			public float remaining
			{
				[Token(Token = "0x600333D")]
				[Address(RVA = "0xD37A60", Offset = "0xD36A60", VA = "0x180D37A60")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600333E RID: 13118 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600333E")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public Timer()
			{
			}

			// Token: 0x0600333F RID: 13119 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600333F")]
			[Address(RVA = "0xD37AD0", Offset = "0xD36AD0", VA = "0x180D37AD0")]
			public void Start(float length)
			{
			}

			// Token: 0x06003340 RID: 13120 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003340")]
			[Address(RVA = "0xD37B40", Offset = "0xD36B40", VA = "0x180D37B40")]
			public void Stop()
			{
			}

			// Token: 0x04005004 RID: 20484
			[Token(Token = "0x4005004")]
			[FieldOffset(Offset = "0x10")]
			private bool _started;

			// Token: 0x04005005 RID: 20485
			[Token(Token = "0x4005005")]
			[FieldOffset(Offset = "0x14")]
			private float end;
		}

		// Token: 0x02000962 RID: 2402
		[Token(Token = "0x2000962")]
		private sealed class <OnEnableAsync>d__64 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x06003341 RID: 13121 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003341")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <OnEnableAsync>d__64(int <>1__state)
			{
			}

			// Token: 0x06003342 RID: 13122 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003342")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x06003343 RID: 13123 RVA: 0x000121B0 File Offset: 0x000103B0
			[Token(Token = "0x6003343")]
			[Address(RVA = "0xD37B50", Offset = "0xD36B50", VA = "0x180D37B50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000512 RID: 1298
			// (get) Token: 0x06003344 RID: 13124 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000512")]
			private object Current
			{
				[Token(Token = "0x6003344")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003345 RID: 13125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003345")]
			[Address(RVA = "0xD37E50", Offset = "0xD36E50", VA = "0x180D37E50", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000513 RID: 1299
			// (get) Token: 0x06003346 RID: 13126 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000513")]
			private object Current
			{
				[Token(Token = "0x6003346")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04005006 RID: 20486
			[Token(Token = "0x4005006")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04005007 RID: 20487
			[Token(Token = "0x4005007")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04005008 RID: 20488
			[Token(Token = "0x4005008")]
			[FieldOffset(Offset = "0x20")]
			public Window <>4__this;
		}
	}
}
