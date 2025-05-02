using System;
using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001D3 RID: 467
	[Serializable]
	public class SerializableDictionary<K, V> : ISerializationCallbackReceiver
	{
		// Token: 0x06000A36 RID: 2614 RVA: 0x0002DB75 File Offset: 0x0002BD75
		public void Clear()
		{
			this.dict.Clear();
		}

		// Token: 0x17000247 RID: 583
		public V this[K aKey]
		{
			get
			{
				return this.dict[aKey];
			}
			set
			{
				this.dict[aKey] = value;
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0002DBA0 File Offset: 0x0002BDA0
		public void OnBeforeSerialize()
		{
			this.m_Keys.Clear();
			this.m_Values.Clear();
			foreach (K k in this.dict.Keys)
			{
				this.m_Keys.Add(k);
				this.m_Values.Add(this.dict[k]);
			}
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0002DC2C File Offset: 0x0002BE2C
		public void OnAfterDeserialize()
		{
			if (this.m_Keys.Count != this.m_Values.Count)
			{
				Debug.LogError("Can't restore dictionry with unbalaned key/values");
				return;
			}
			this.dict.Clear();
			for (int i = 0; i < this.m_Keys.Count; i++)
			{
				this.dict[this.m_Keys[i]] = this.m_Values[i];
			}
		}

		// Token: 0x04000B4C RID: 2892
		[NonSerialized]
		public Dictionary<K, V> dict = new Dictionary<K, V>();

		// Token: 0x04000B4D RID: 2893
		[SerializeField]
		public List<K> m_Keys = new List<K>();

		// Token: 0x04000B4E RID: 2894
		[SerializeField]
		public List<V> m_Values = new List<V>();
	}
}
