using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000251 RID: 593
[Token(Token = "0x2000251")]
public class AnimateTiledTexture : MonoBehaviour
{
	// Token: 0x06000D5F RID: 3423 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D5F")]
	[Address(RVA = "0x5E9AA0", Offset = "0x5E8AA0", VA = "0x1805E9AA0")]
	public void RegisterCallback(AnimateTiledTexture.VoidEvent cbFunction)
	{
	}

	// Token: 0x06000D60 RID: 3424 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D60")]
	[Address(RVA = "0x5E9B30", Offset = "0x5E8B30", VA = "0x1805E9B30")]
	public void UnRegisterCallback(AnimateTiledTexture.VoidEvent cbFunction)
	{
	}

	// Token: 0x06000D61 RID: 3425 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D61")]
	[Address(RVA = "0x5E9BC0", Offset = "0x5E8BC0", VA = "0x1805E9BC0")]
	public void Play()
	{
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D62")]
	[Address(RVA = "0x5E9D70", Offset = "0x5E8D70", VA = "0x1805E9D70")]
	public void ChangeMaterial(Material newMaterial, bool newInstance = false)
	{
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D63")]
	[Address(RVA = "0x5EA0B0", Offset = "0x5E90B0", VA = "0x1805EA0B0")]
	private void Awake()
	{
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D64")]
	[Address(RVA = "0x5EA200", Offset = "0x5E9200", VA = "0x1805EA200")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D65")]
	[Address(RVA = "0x5EA2E0", Offset = "0x5E92E0", VA = "0x1805EA2E0")]
	private void HandleCallbacks(List<AnimateTiledTexture.VoidEvent> cbList)
	{
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D66")]
	[Address(RVA = "0x5EA390", Offset = "0x5E9390", VA = "0x1805EA390")]
	private void OnEnable()
	{
	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D67")]
	[Address(RVA = "0x5EA5A0", Offset = "0x5E95A0", VA = "0x1805EA5A0")]
	private void CalcTextureSize()
	{
	}

	// Token: 0x06000D68 RID: 3432 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D68")]
	[Address(RVA = "0x5EA600", Offset = "0x5E9600", VA = "0x1805EA600")]
	private IEnumerator updateTiling()
	{
		return null;
	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D69")]
	[Address(RVA = "0x5EA6A0", Offset = "0x5E96A0", VA = "0x1805EA6A0")]
	private void ApplyOffset()
	{
	}

	// Token: 0x06000D6A RID: 3434 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D6A")]
	[Address(RVA = "0x5EA810", Offset = "0x5E9810", VA = "0x1805EA810")]
	public AnimateTiledTexture()
	{
	}

	// Token: 0x04000EF9 RID: 3833
	[Token(Token = "0x4000EF9")]
	[FieldOffset(Offset = "0x18")]
	public int _columns;

	// Token: 0x04000EFA RID: 3834
	[Token(Token = "0x4000EFA")]
	[FieldOffset(Offset = "0x1C")]
	public int _rows;

	// Token: 0x04000EFB RID: 3835
	[Token(Token = "0x4000EFB")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 _scale;

	// Token: 0x04000EFC RID: 3836
	[Token(Token = "0x4000EFC")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 _offset;

	// Token: 0x04000EFD RID: 3837
	[Token(Token = "0x4000EFD")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 _buffer;

	// Token: 0x04000EFE RID: 3838
	[Token(Token = "0x4000EFE")]
	[FieldOffset(Offset = "0x38")]
	public float _framesPerSecond;

	// Token: 0x04000EFF RID: 3839
	[Token(Token = "0x4000EFF")]
	[FieldOffset(Offset = "0x3C")]
	public bool _playOnce;

	// Token: 0x04000F00 RID: 3840
	[Token(Token = "0x4000F00")]
	[FieldOffset(Offset = "0x3D")]
	public bool _disableUponCompletion;

	// Token: 0x04000F01 RID: 3841
	[Token(Token = "0x4000F01")]
	[FieldOffset(Offset = "0x3E")]
	public bool _enableEvents;

	// Token: 0x04000F02 RID: 3842
	[Token(Token = "0x4000F02")]
	[FieldOffset(Offset = "0x3F")]
	public bool _playOnEnable;

	// Token: 0x04000F03 RID: 3843
	[Token(Token = "0x4000F03")]
	[FieldOffset(Offset = "0x40")]
	public bool _newMaterialInstance;

	// Token: 0x04000F04 RID: 3844
	[Token(Token = "0x4000F04")]
	[FieldOffset(Offset = "0x44")]
	private int _index;

	// Token: 0x04000F05 RID: 3845
	[Token(Token = "0x4000F05")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 _textureSize;

	// Token: 0x04000F06 RID: 3846
	[Token(Token = "0x4000F06")]
	[FieldOffset(Offset = "0x50")]
	private Material _materialInstance;

	// Token: 0x04000F07 RID: 3847
	[Token(Token = "0x4000F07")]
	[FieldOffset(Offset = "0x58")]
	private bool _hasMaterialInstance;

	// Token: 0x04000F08 RID: 3848
	[Token(Token = "0x4000F08")]
	[FieldOffset(Offset = "0x59")]
	private bool _isPlaying;

	// Token: 0x04000F09 RID: 3849
	[Token(Token = "0x4000F09")]
	[FieldOffset(Offset = "0x60")]
	private List<AnimateTiledTexture.VoidEvent> _voidEventCallbackList;

	// Token: 0x02000252 RID: 594
	// (Invoke) Token: 0x06000D6C RID: 3436
	[Token(Token = "0x2000252")]
	public delegate void VoidEvent();

	// Token: 0x02000253 RID: 595
	[Token(Token = "0x2000253")]
	private sealed class <updateTiling>d__27 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000D6F RID: 3439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6F")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <updateTiling>d__27(int <>1__state)
		{
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D70")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00007350 File Offset: 0x00005550
		[Token(Token = "0x6000D71")]
		[Address(RVA = "0x5EA950", Offset = "0x5E9950", VA = "0x1805EA950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000070")]
		private object Current
		{
			[Token(Token = "0x6000D72")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D73")]
		[Address(RVA = "0x5EAB90", Offset = "0x5E9B90", VA = "0x1805EAB90", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000071")]
		private object Current
		{
			[Token(Token = "0x6000D74")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F0A RID: 3850
		[Token(Token = "0x4000F0A")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000F0B RID: 3851
		[Token(Token = "0x4000F0B")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000F0C RID: 3852
		[Token(Token = "0x4000F0C")]
		[FieldOffset(Offset = "0x20")]
		public AnimateTiledTexture <>4__this;

		// Token: 0x04000F0D RID: 3853
		[Token(Token = "0x4000F0D")]
		[FieldOffset(Offset = "0x28")]
		private int <checkAgainst>5__2;
	}
}
