using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x02000885 RID: 2181
	public class PourableAdditive : Pourable
	{
		// Token: 0x06003B1E RID: 15134 RVA: 0x000F8DF4 File Offset: 0x000F6FF4
		protected override void PourAmount(float amount)
		{
			base.PourAmount(amount);
		}

		// Token: 0x04002AA7 RID: 10919
		public const float NormalizedAmountForSuccess = 0.8f;

		// Token: 0x04002AA8 RID: 10920
		public AdditiveDefinition AdditiveDefinition;

		// Token: 0x04002AA9 RID: 10921
		public Color LiquidColor;

		// Token: 0x04002AAA RID: 10922
		private float pouredAmount;
	}
}
