using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001D2 RID: 466
	[Serializable]
	public class KeyframeGroupDictionary : ISerializationCallbackReceiver, IEnumerable<string>, IEnumerable
	{
		// Token: 0x17000246 RID: 582
		public IKeyframeGroup this[string aKey]
		{
			get
			{
				return this.m_Groups[aKey];
			}
			set
			{
				this.m_Groups[aKey] = value;
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0002D6AE File Offset: 0x0002B8AE
		public bool ContainsKey(string key)
		{
			return this.m_Groups.ContainsKey(key);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0002D6BC File Offset: 0x0002B8BC
		public void Clear()
		{
			this.m_Groups.Clear();
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0002D6CC File Offset: 0x0002B8CC
		public T GetGroup<T>(string propertyName) where T : class
		{
			if (typeof(T) == typeof(ColorKeyframeGroup))
			{
				return this.m_Groups[propertyName] as T;
			}
			if (typeof(T) == typeof(NumberKeyframeGroup))
			{
				return this.m_Groups[propertyName] as T;
			}
			if (typeof(T) == typeof(TextureKeyframeGroup))
			{
				return this.m_Groups[propertyName] as T;
			}
			if (typeof(T) == typeof(SpherePointGroupDictionary))
			{
				return this.m_Groups[propertyName] as T;
			}
			if (typeof(T) == typeof(BoolKeyframeGroup))
			{
				return this.m_Groups[propertyName] as T;
			}
			return default(T);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0002D7DC File Offset: 0x0002B9DC
		public void OnBeforeSerialize()
		{
			this.m_ColorGroup.Clear();
			this.m_NumberGroup.Clear();
			this.m_TextureGroup.Clear();
			this.m_SpherePointGroup.Clear();
			this.m_BoolGroup.Clear();
			foreach (string text in this.m_Groups.Keys)
			{
				IKeyframeGroup keyframeGroup = this.m_Groups[text];
				if (keyframeGroup is ColorKeyframeGroup)
				{
					this.m_ColorGroup[text] = (keyframeGroup as ColorKeyframeGroup);
				}
				else if (keyframeGroup is NumberKeyframeGroup)
				{
					this.m_NumberGroup[text] = (keyframeGroup as NumberKeyframeGroup);
				}
				else if (keyframeGroup is TextureKeyframeGroup)
				{
					this.m_TextureGroup[text] = (keyframeGroup as TextureKeyframeGroup);
				}
				else if (keyframeGroup is SpherePointKeyframeGroup)
				{
					this.m_SpherePointGroup[text] = (keyframeGroup as SpherePointKeyframeGroup);
				}
				else if (keyframeGroup is BoolKeyframeGroup)
				{
					this.m_BoolGroup[text] = (keyframeGroup as BoolKeyframeGroup);
				}
			}
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0002D904 File Offset: 0x0002BB04
		public void OnAfterDeserialize()
		{
			this.m_Groups.Clear();
			foreach (string text in this.m_ColorGroup.dict.Keys)
			{
				this.m_Groups[text] = this.m_ColorGroup[text];
			}
			foreach (string text2 in this.m_NumberGroup.dict.Keys)
			{
				this.m_Groups[text2] = this.m_NumberGroup[text2];
			}
			foreach (string text3 in this.m_TextureGroup.dict.Keys)
			{
				this.m_Groups[text3] = this.m_TextureGroup[text3];
			}
			foreach (string text4 in this.m_SpherePointGroup.dict.Keys)
			{
				this.m_Groups[text4] = this.m_SpherePointGroup[text4];
			}
			foreach (string text5 in this.m_BoolGroup.dict.Keys)
			{
				this.m_Groups[text5] = this.m_BoolGroup[text5];
			}
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0002DB00 File Offset: 0x0002BD00
		public IEnumerator<string> GetEnumerator()
		{
			return this.m_Groups.Keys.GetEnumerator();
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0002DB17 File Offset: 0x0002BD17
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000B46 RID: 2886
		[NonSerialized]
		private Dictionary<string, IKeyframeGroup> m_Groups = new Dictionary<string, IKeyframeGroup>();

		// Token: 0x04000B47 RID: 2887
		[SerializeField]
		private ColorGroupDictionary m_ColorGroup = new ColorGroupDictionary();

		// Token: 0x04000B48 RID: 2888
		[SerializeField]
		private NumberGroupDictionary m_NumberGroup = new NumberGroupDictionary();

		// Token: 0x04000B49 RID: 2889
		[SerializeField]
		private TextureGroupDictionary m_TextureGroup = new TextureGroupDictionary();

		// Token: 0x04000B4A RID: 2890
		[SerializeField]
		private SpherePointGroupDictionary m_SpherePointGroup = new SpherePointGroupDictionary();

		// Token: 0x04000B4B RID: 2891
		[SerializeField]
		private BoolGroupDictionary m_BoolGroup = new BoolGroupDictionary();
	}
}
