using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BB RID: 443
[Token(Token = "0x20001BB")]
public class CorpseCollisionCorrection : MonoBehaviour
{
	// Token: 0x06000AFB RID: 2811 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AFB")]
	[Address(RVA = "0x549BB0", Offset = "0x548BB0", VA = "0x180549BB0")]
	private void Start()
	{
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0x549DE0", Offset = "0x548DE0", VA = "0x180549DE0")]
	private void ImplementSkeleton()
	{
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x549FE0", Offset = "0x548FE0", VA = "0x180549FE0")]
	private void SearchAndInstantiateBodyParts(Transform parent)
	{
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x00006A50 File Offset: 0x00004C50
	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x54A270", Offset = "0x549270", VA = "0x18054A270")]
	private bool DoesNameContainPart(string childName, string bodyPartName)
	{
		return default(bool);
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x54A460", Offset = "0x549460", VA = "0x18054A460")]
	private void InstantiateSkeletonPart(GameObject bodyPart, Transform child)
	{
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x00006A68 File Offset: 0x00004C68
	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x54AD30", Offset = "0x549D30", VA = "0x18054AD30")]
	private bool HasMatchingSkeletonPart(Transform child)
	{
		return default(bool);
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x54AE60", Offset = "0x549E60", VA = "0x18054AE60")]
	private string RemoveInvisibleCharacters(string input)
	{
		return null;
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x54AEF0", Offset = "0x549EF0", VA = "0x18054AEF0")]
	public void StartCollisionCorrection()
	{
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B03")]
	[Address(RVA = "0x54AFA0", Offset = "0x549FA0", VA = "0x18054AFA0")]
	private IEnumerator CorrectCollisionOnDelay()
	{
		return null;
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x54B040", Offset = "0x54A040", VA = "0x18054B040")]
	public CorpseCollisionCorrection()
	{
	}

	// Token: 0x04000ADD RID: 2781
	[Token(Token = "0x4000ADD")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 correctionDistance;

	// Token: 0x04000ADE RID: 2782
	[Token(Token = "0x4000ADE")]
	[FieldOffset(Offset = "0x28")]
	public Transform target;

	// Token: 0x04000ADF RID: 2783
	[Token(Token = "0x4000ADF")]
	[FieldOffset(Offset = "0x30")]
	public GameObject[] BodyParts;

	// Token: 0x04000AE0 RID: 2784
	[Token(Token = "0x4000AE0")]
	[FieldOffset(Offset = "0x38")]
	public float skeletonSizeModifier;

	// Token: 0x04000AE1 RID: 2785
	[Token(Token = "0x4000AE1")]
	[FieldOffset(Offset = "0x3C")]
	public float correctionCooldown;

	// Token: 0x04000AE2 RID: 2786
	[Token(Token = "0x4000AE2")]
	[FieldOffset(Offset = "0x40")]
	private bool isOnCooldown;

	// Token: 0x020001BC RID: 444
	[Token(Token = "0x20001BC")]
	private sealed class <CorrectCollisionOnDelay>d__14 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000B05 RID: 2821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <CorrectCollisionOnDelay>d__14(int <>1__state)
		{
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00006A80 File Offset: 0x00004C80
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x54B0B0", Offset = "0x54A0B0", VA = "0x18054B0B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000069")]
		private object Current
		{
			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x54B300", Offset = "0x54A300", VA = "0x18054B300", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006A")]
		private object Current
		{
			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AE3 RID: 2787
		[Token(Token = "0x4000AE3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000AE4 RID: 2788
		[Token(Token = "0x4000AE4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000AE5 RID: 2789
		[Token(Token = "0x4000AE5")]
		[FieldOffset(Offset = "0x20")]
		public CorpseCollisionCorrection <>4__this;
	}
}
