using System;
using System.Collections.Generic;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	// Token: 0x0200020C RID: 524
	[Serializable]
	public class MinMaxColor
	{
		// Token: 0x06000B72 RID: 2930 RVA: 0x000356C0 File Offset: 0x000338C0
		public Color GetRandom()
		{
			int index = Random.Range(0, this.minColors.Count);
			return Color.Lerp(this.minColors[index], this.maxColors[index], Random.Range(0f, 1f));
		}

		// Token: 0x04000C6C RID: 3180
		public List<Color> minColors = new List<Color>();

		// Token: 0x04000C6D RID: 3181
		public List<Color> maxColors = new List<Color>();
	}
}
