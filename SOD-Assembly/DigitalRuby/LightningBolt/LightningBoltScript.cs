using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.LightningBolt
{
	// Token: 0x02000A2F RID: 2607
	[Token(Token = "0x2000A2F")]
	public class LightningBoltScript : MonoBehaviour
	{
		// Token: 0x06003750 RID: 14160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003750")]
		[Address(RVA = "0xDEE140", Offset = "0xDED140", VA = "0x180DEE140")]
		private void GetPerpendicularVector(ref Vector3 directionNormalized, out Vector3 side)
		{
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003751")]
		[Address(RVA = "0xDEE390", Offset = "0xDED390", VA = "0x180DEE390")]
		private void GenerateLightningBolt(Vector3 start, Vector3 end, int generation, int totalGenerations, float offsetAmount)
		{
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003752")]
		[Address(RVA = "0xDEE820", Offset = "0xDED820", VA = "0x180DEE820")]
		public void RandomVector(ref Vector3 start, ref Vector3 end, float offsetAmount, out Vector3 result)
		{
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003753")]
		[Address(RVA = "0xDEECA0", Offset = "0xDEDCA0", VA = "0x180DEECA0")]
		private void SelectOffsetFromAnimationMode()
		{
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003754")]
		[Address(RVA = "0xDEEEF0", Offset = "0xDEDEF0", VA = "0x180DEEEF0")]
		private void UpdateLineRenderer()
		{
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003755")]
		[Address(RVA = "0xDEF200", Offset = "0xDEE200", VA = "0x180DEF200")]
		private void Start()
		{
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003756")]
		[Address(RVA = "0xDEF4B0", Offset = "0xDEE4B0", VA = "0x180DEF4B0")]
		private void Update()
		{
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003757")]
		[Address(RVA = "0xDEF730", Offset = "0xDEE730", VA = "0x180DEF730")]
		public void Trigger()
		{
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003758")]
		[Address(RVA = "0xDEFB80", Offset = "0xDEEB80", VA = "0x180DEFB80")]
		public void UpdateFromMaterialChange()
		{
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003759")]
		[Address(RVA = "0xDEFD50", Offset = "0xDEED50", VA = "0x180DEFD50")]
		public LightningBoltScript()
		{
		}

		// Token: 0x0400552E RID: 21806
		[Token(Token = "0x400552E")]
		[FieldOffset(Offset = "0x18")]
		public GameObject StartObject;

		// Token: 0x0400552F RID: 21807
		[Token(Token = "0x400552F")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 StartPosition;

		// Token: 0x04005530 RID: 21808
		[Token(Token = "0x4005530")]
		[FieldOffset(Offset = "0x30")]
		public GameObject EndObject;

		// Token: 0x04005531 RID: 21809
		[Token(Token = "0x4005531")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 EndPosition;

		// Token: 0x04005532 RID: 21810
		[Token(Token = "0x4005532")]
		[FieldOffset(Offset = "0x44")]
		public int Generations;

		// Token: 0x04005533 RID: 21811
		[Token(Token = "0x4005533")]
		[FieldOffset(Offset = "0x48")]
		public float Duration;

		// Token: 0x04005534 RID: 21812
		[Token(Token = "0x4005534")]
		[FieldOffset(Offset = "0x4C")]
		private float timer;

		// Token: 0x04005535 RID: 21813
		[Token(Token = "0x4005535")]
		[FieldOffset(Offset = "0x50")]
		public float ChaosFactor;

		// Token: 0x04005536 RID: 21814
		[Token(Token = "0x4005536")]
		[FieldOffset(Offset = "0x54")]
		public bool ManualMode;

		// Token: 0x04005537 RID: 21815
		[Token(Token = "0x4005537")]
		[FieldOffset(Offset = "0x58")]
		public int Rows;

		// Token: 0x04005538 RID: 21816
		[Token(Token = "0x4005538")]
		[FieldOffset(Offset = "0x5C")]
		public int Columns;

		// Token: 0x04005539 RID: 21817
		[Token(Token = "0x4005539")]
		[FieldOffset(Offset = "0x60")]
		public LightningBoltAnimationMode AnimationMode;

		// Token: 0x0400553A RID: 21818
		[Token(Token = "0x400553A")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public System.Random RandomGenerator;

		// Token: 0x0400553B RID: 21819
		[Token(Token = "0x400553B")]
		[FieldOffset(Offset = "0x70")]
		private LineRenderer lineRenderer;

		// Token: 0x0400553C RID: 21820
		[Token(Token = "0x400553C")]
		[FieldOffset(Offset = "0x78")]
		private List<KeyValuePair<Vector3, Vector3>> segments;

		// Token: 0x0400553D RID: 21821
		[Token(Token = "0x400553D")]
		[FieldOffset(Offset = "0x80")]
		private int startIndex;

		// Token: 0x0400553E RID: 21822
		[Token(Token = "0x400553E")]
		[FieldOffset(Offset = "0x84")]
		private Vector2 size;

		// Token: 0x0400553F RID: 21823
		[Token(Token = "0x400553F")]
		[FieldOffset(Offset = "0x90")]
		private Vector2[] offsets;

		// Token: 0x04005540 RID: 21824
		[Token(Token = "0x4005540")]
		[FieldOffset(Offset = "0x98")]
		private int animationOffsetIndex;

		// Token: 0x04005541 RID: 21825
		[Token(Token = "0x4005541")]
		[FieldOffset(Offset = "0x9C")]
		private int animationPingPongDirection;

		// Token: 0x04005542 RID: 21826
		[Token(Token = "0x4005542")]
		[FieldOffset(Offset = "0xA0")]
		private bool orthographic;
	}
}
