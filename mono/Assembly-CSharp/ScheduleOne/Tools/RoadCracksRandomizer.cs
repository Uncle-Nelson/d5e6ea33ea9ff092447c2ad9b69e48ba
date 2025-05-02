using System;
using System.Collections.Generic;
using EasyButtons;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000872 RID: 2162
	public class RoadCracksRandomizer : MonoBehaviour
	{
		// Token: 0x06003AD8 RID: 15064 RVA: 0x000F7A80 File Offset: 0x000F5C80
		[Button]
		private void Randomize()
		{
			List<Transform> list = new List<Transform>(this.Cracks);
			for (int i = 0; i < list.Count; i++)
			{
				int index = Random.Range(0, list.Count);
				Transform value = list[i];
				list[i] = list[index];
				list[index] = value;
			}
			int num = Random.Range(this.MinCount, this.MaxCount + 1);
			for (int j = 0; j < list.Count; j++)
			{
				list[j].gameObject.SetActive(j < num);
			}
		}

		// Token: 0x04002A54 RID: 10836
		public Transform[] Cracks;

		// Token: 0x04002A55 RID: 10837
		public int MinCount;

		// Token: 0x04002A56 RID: 10838
		public int MaxCount = 4;
	}
}
