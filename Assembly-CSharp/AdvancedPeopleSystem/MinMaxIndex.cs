using System;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	// Token: 0x0200020B RID: 523
	[Serializable]
	public class MinMaxIndex
	{
		// Token: 0x06000B70 RID: 2928 RVA: 0x000356A3 File Offset: 0x000338A3
		public int GetRandom(int max)
		{
			return Mathf.Clamp(Random.Range(this.Min, this.Max), -1, max);
		}

		// Token: 0x04000C6A RID: 3178
		public int Min;

		// Token: 0x04000C6B RID: 3179
		public int Max;
	}
}
