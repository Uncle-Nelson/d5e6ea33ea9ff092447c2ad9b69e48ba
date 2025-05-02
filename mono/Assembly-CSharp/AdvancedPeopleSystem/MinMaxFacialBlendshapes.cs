using System;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	// Token: 0x02000211 RID: 529
	[Serializable]
	public class MinMaxFacialBlendshapes
	{
		// Token: 0x06000B78 RID: 2936 RVA: 0x0003574F File Offset: 0x0003394F
		public float GetRandom()
		{
			return Random.Range(this.Min, this.Max);
		}

		// Token: 0x04000C7D RID: 3197
		public string name;

		// Token: 0x04000C7E RID: 3198
		[Range(-100f, 100f)]
		public float Min;

		// Token: 0x04000C7F RID: 3199
		[Range(-100f, 100f)]
		public float Max;
	}
}
