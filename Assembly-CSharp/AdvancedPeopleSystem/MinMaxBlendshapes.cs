using System;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	// Token: 0x0200020D RID: 525
	[Serializable]
	public class MinMaxBlendshapes
	{
		// Token: 0x06000B74 RID: 2932 RVA: 0x00035729 File Offset: 0x00033929
		public float GetRandom()
		{
			return Random.Range(this.Min, this.Max);
		}

		// Token: 0x04000C6E RID: 3182
		[Range(-100f, 100f)]
		public float Min;

		// Token: 0x04000C6F RID: 3183
		[Range(-100f, 100f)]
		public float Max;
	}
}
