using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew
{
	// Token: 0x020009AB RID: 2475
	[Token(Token = "0x20009AB")]
	[Serializable]
	public class SerializableDictionary<TKey, TValue> : IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>
	{
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060034FF RID: 13567 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700054B")]
		public Dictionary<TKey, TValue> AsDictionary
		{
			[Token(Token = "0x60034FF")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06003500 RID: 13568 RVA: 0x00012768 File Offset: 0x00010968
		[Token(Token = "0x1700054C")]
		public int Count
		{
			[Token(Token = "0x6003500")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06003501 RID: 13569 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700054D")]
		public TValue Item
		{
			[Token(Token = "0x6003501")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06003502 RID: 13570 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003503 RID: 13571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054E")]
		public TValue Item
		{
			[Token(Token = "0x6003502")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003503")]
			set
			{
			}
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003504")]
		public SerializableDictionary()
		{
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003505")]
		public SerializableDictionary(int capacity)
		{
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003506")]
		public SerializableDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003507")]
		public SerializableDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003508")]
		public SerializableDictionary(IDictionary<TKey, TValue> dictionary)
		{
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003509")]
		public SerializableDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x00012780 File Offset: 0x00010980
		[Token(Token = "0x600350A")]
		public bool ContainsValue(TValue value)
		{
			return default(bool);
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x00012798 File Offset: 0x00010998
		[Token(Token = "0x600350B")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350C")]
		public void Clear()
		{
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350D")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350E")]
		private void Resize(int newSize, bool forceNewHashCodes)
		{
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350F")]
		private void Resize()
		{
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x000127B0 File Offset: 0x000109B0
		[Token(Token = "0x6003510")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06003511 RID: 13585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003511")]
		private void Insert(TKey key, TValue value, bool add)
		{
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003512")]
		private void Initialize(int capacity)
		{
		}

		// Token: 0x06003513 RID: 13587 RVA: 0x000127C8 File Offset: 0x000109C8
		[Token(Token = "0x6003513")]
		private int FindIndex(TKey key)
		{
			return 0;
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x000127E0 File Offset: 0x000109E0
		[Token(Token = "0x6003514")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06003515 RID: 13589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700054F")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x6003515")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000550")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x6003516")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003517")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x000127F8 File Offset: 0x000109F8
		[Token(Token = "0x6003518")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003519")]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x0600351A RID: 13594 RVA: 0x00012810 File Offset: 0x00010A10
		[Token(Token = "0x17000551")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600351A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x00012828 File Offset: 0x00010A28
		[Token(Token = "0x600351B")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x00012840 File Offset: 0x00010A40
		[Token(Token = "0x600351C")]
		public SerializableDictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			return default(SerializableDictionary<TKey, TValue>.Enumerator);
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600351D")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600351E")]
		private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x040051D4 RID: 20948
		[Token(Token = "0x40051D4")]
		[FieldOffset(Offset = "0x0")]
		private int[] _Buckets;

		// Token: 0x040051D5 RID: 20949
		[Token(Token = "0x40051D5")]
		[FieldOffset(Offset = "0x0")]
		private int[] _HashCodes;

		// Token: 0x040051D6 RID: 20950
		[Token(Token = "0x40051D6")]
		[FieldOffset(Offset = "0x0")]
		private int[] _Next;

		// Token: 0x040051D7 RID: 20951
		[Token(Token = "0x40051D7")]
		[FieldOffset(Offset = "0x0")]
		private int _Count;

		// Token: 0x040051D8 RID: 20952
		[Token(Token = "0x40051D8")]
		[FieldOffset(Offset = "0x0")]
		private int _Version;

		// Token: 0x040051D9 RID: 20953
		[Token(Token = "0x40051D9")]
		[FieldOffset(Offset = "0x0")]
		private int _FreeList;

		// Token: 0x040051DA RID: 20954
		[Token(Token = "0x40051DA")]
		[FieldOffset(Offset = "0x0")]
		private int _FreeCount;

		// Token: 0x040051DB RID: 20955
		[Token(Token = "0x40051DB")]
		[FieldOffset(Offset = "0x0")]
		private TKey[] _Keys;

		// Token: 0x040051DC RID: 20956
		[Token(Token = "0x40051DC")]
		[FieldOffset(Offset = "0x0")]
		private TValue[] _Values;

		// Token: 0x040051DD RID: 20957
		[Token(Token = "0x40051DD")]
		[FieldOffset(Offset = "0x0")]
		private readonly IEqualityComparer<TKey> _Comparer;

		// Token: 0x020009AC RID: 2476
		[Token(Token = "0x20009AC")]
		private static class PrimeHelper
		{
			// Token: 0x0600351F RID: 13599 RVA: 0x00012858 File Offset: 0x00010A58
			[Token(Token = "0x600351F")]
			public static bool IsPrime(int candidate)
			{
				return default(bool);
			}

			// Token: 0x06003520 RID: 13600 RVA: 0x00012870 File Offset: 0x00010A70
			[Token(Token = "0x6003520")]
			public static int GetPrime(int min)
			{
				return 0;
			}

			// Token: 0x06003521 RID: 13601 RVA: 0x00012888 File Offset: 0x00010A88
			[Token(Token = "0x6003521")]
			public static int ExpandPrime(int oldSize)
			{
				return 0;
			}

			// Token: 0x040051DE RID: 20958
			[Token(Token = "0x40051DE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int[] Primes;
		}

		// Token: 0x020009AD RID: 2477
		[Token(Token = "0x20009AD")]
		public struct Enumerator : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x17000552 RID: 1362
			// (get) Token: 0x06003523 RID: 13603 RVA: 0x000128A0 File Offset: 0x00010AA0
			[Token(Token = "0x17000552")]
			public KeyValuePair<TKey, TValue> Current
			{
				[Token(Token = "0x6003523")]
				get
				{
					return default(KeyValuePair<TKey, TValue>);
				}
			}

			// Token: 0x06003524 RID: 13604 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003524")]
			internal Enumerator(SerializableDictionary<TKey, TValue> dictionary)
			{
			}

			// Token: 0x06003525 RID: 13605 RVA: 0x000128B8 File Offset: 0x00010AB8
			[Token(Token = "0x6003525")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06003526 RID: 13606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003526")]
			private void Reset()
			{
			}

			// Token: 0x17000553 RID: 1363
			// (get) Token: 0x06003527 RID: 13607 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000553")]
			private object Current
			{
				[Token(Token = "0x6003527")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003528 RID: 13608 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003528")]
			public void Dispose()
			{
			}

			// Token: 0x040051DF RID: 20959
			[Token(Token = "0x40051DF")]
			[FieldOffset(Offset = "0x0")]
			private readonly SerializableDictionary<TKey, TValue> _Dictionary;

			// Token: 0x040051E0 RID: 20960
			[Token(Token = "0x40051E0")]
			[FieldOffset(Offset = "0x0")]
			private int _Version;

			// Token: 0x040051E1 RID: 20961
			[Token(Token = "0x40051E1")]
			[FieldOffset(Offset = "0x0")]
			private int _Index;

			// Token: 0x040051E2 RID: 20962
			[Token(Token = "0x40051E2")]
			[FieldOffset(Offset = "0x0")]
			private KeyValuePair<TKey, TValue> _Current;
		}
	}
}
