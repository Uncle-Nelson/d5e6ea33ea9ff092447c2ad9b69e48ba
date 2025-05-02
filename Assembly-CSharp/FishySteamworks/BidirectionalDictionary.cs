using System;
using System.Collections;
using System.Collections.Generic;

namespace FishySteamworks
{
	// Token: 0x02000C3E RID: 3134
	public class BidirectionalDictionary<T1, T2> : IEnumerable
	{
		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x060057BF RID: 22463 RVA: 0x001702F7 File Offset: 0x0016E4F7
		public IEnumerable<T1> FirstTypes
		{
			get
			{
				return this.t1ToT2Dict.Keys;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x060057C0 RID: 22464 RVA: 0x00170304 File Offset: 0x0016E504
		public IEnumerable<T2> SecondTypes
		{
			get
			{
				return this.t2ToT1Dict.Keys;
			}
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x00170311 File Offset: 0x0016E511
		public IEnumerator GetEnumerator()
		{
			return this.t1ToT2Dict.GetEnumerator();
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x060057C2 RID: 22466 RVA: 0x00170323 File Offset: 0x0016E523
		public int Count
		{
			get
			{
				return this.t1ToT2Dict.Count;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060057C3 RID: 22467 RVA: 0x00170330 File Offset: 0x0016E530
		public Dictionary<T1, T2> First
		{
			get
			{
				return this.t1ToT2Dict;
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x060057C4 RID: 22468 RVA: 0x00170338 File Offset: 0x0016E538
		public Dictionary<T2, T1> Second
		{
			get
			{
				return this.t2ToT1Dict;
			}
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x00170340 File Offset: 0x0016E540
		public void Add(T1 key, T2 value)
		{
			if (this.t1ToT2Dict.ContainsKey(key))
			{
				this.Remove(key);
			}
			this.t1ToT2Dict[key] = value;
			this.t2ToT1Dict[value] = key;
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x00170371 File Offset: 0x0016E571
		public void Add(T2 key, T1 value)
		{
			if (this.t2ToT1Dict.ContainsKey(key))
			{
				this.Remove(key);
			}
			this.t2ToT1Dict[key] = value;
			this.t1ToT2Dict[value] = key;
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x001703A2 File Offset: 0x0016E5A2
		public T2 Get(T1 key)
		{
			return this.t1ToT2Dict[key];
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x001703B0 File Offset: 0x0016E5B0
		public T1 Get(T2 key)
		{
			return this.t2ToT1Dict[key];
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x001703BE File Offset: 0x0016E5BE
		public bool TryGetValue(T1 key, out T2 value)
		{
			return this.t1ToT2Dict.TryGetValue(key, out value);
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x001703CD File Offset: 0x0016E5CD
		public bool TryGetValue(T2 key, out T1 value)
		{
			return this.t2ToT1Dict.TryGetValue(key, out value);
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x001703DC File Offset: 0x0016E5DC
		public bool Contains(T1 key)
		{
			return this.t1ToT2Dict.ContainsKey(key);
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x001703EA File Offset: 0x0016E5EA
		public bool Contains(T2 key)
		{
			return this.t2ToT1Dict.ContainsKey(key);
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x001703F8 File Offset: 0x0016E5F8
		public void Remove(T1 key)
		{
			if (this.Contains(key))
			{
				T2 key2 = this.t1ToT2Dict[key];
				this.t1ToT2Dict.Remove(key);
				this.t2ToT1Dict.Remove(key2);
			}
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x00170438 File Offset: 0x0016E638
		public void Remove(T2 key)
		{
			if (this.Contains(key))
			{
				T1 key2 = this.t2ToT1Dict[key];
				this.t1ToT2Dict.Remove(key2);
				this.t2ToT1Dict.Remove(key);
			}
		}

		// Token: 0x17000C53 RID: 3155
		public T1 this[T2 key]
		{
			get
			{
				return this.t2ToT1Dict[key];
			}
			set
			{
				this.Add(key, value);
			}
		}

		// Token: 0x17000C54 RID: 3156
		public T2 this[T1 key]
		{
			get
			{
				return this.t1ToT2Dict[key];
			}
			set
			{
				this.Add(key, value);
			}
		}

		// Token: 0x04004115 RID: 16661
		private Dictionary<T1, T2> t1ToT2Dict = new Dictionary<T1, T2>();

		// Token: 0x04004116 RID: 16662
		private Dictionary<T2, T1> t2ToT1Dict = new Dictionary<T2, T1>();
	}
}
