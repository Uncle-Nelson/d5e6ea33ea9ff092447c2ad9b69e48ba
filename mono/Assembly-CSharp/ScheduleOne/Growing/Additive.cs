using System;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x02000880 RID: 2176
	public class Additive : MonoBehaviour
	{
		// Token: 0x04002A8B RID: 10891
		public string AdditiveName = "Name";

		// Token: 0x04002A8C RID: 10892
		public string AssetPath;

		// Token: 0x04002A8D RID: 10893
		[Header("Plant effector settings")]
		public float QualityChange;

		// Token: 0x04002A8E RID: 10894
		public float YieldChange;

		// Token: 0x04002A8F RID: 10895
		public float GrowSpeedMultiplier = 1f;

		// Token: 0x04002A90 RID: 10896
		public float InstantGrowth;
	}
}
