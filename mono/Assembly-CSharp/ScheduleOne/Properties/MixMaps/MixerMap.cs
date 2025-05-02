using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Properties.MixMaps
{
	// Token: 0x0200032D RID: 813
	[Serializable]
	public class MixerMap : ScriptableObject
	{
		// Token: 0x060011DD RID: 4573 RVA: 0x0004DD90 File Offset: 0x0004BF90
		public MixerMapEffect GetEffectAtPoint(Vector2 point)
		{
			if (point.magnitude > this.MapRadius)
			{
				return null;
			}
			for (int i = 0; i < this.Effects.Count; i++)
			{
				if (this.Effects[i].IsPointInEffect(point))
				{
					return this.Effects[i];
				}
			}
			return null;
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0004DDE8 File Offset: 0x0004BFE8
		public MixerMapEffect GetEffect(Property property)
		{
			for (int i = 0; i < this.Effects.Count; i++)
			{
				if (this.Effects[i].Property == property)
				{
					return this.Effects[i];
				}
			}
			return null;
		}

		// Token: 0x04001169 RID: 4457
		public float MapRadius;

		// Token: 0x0400116A RID: 4458
		public List<MixerMapEffect> Effects;
	}
}
