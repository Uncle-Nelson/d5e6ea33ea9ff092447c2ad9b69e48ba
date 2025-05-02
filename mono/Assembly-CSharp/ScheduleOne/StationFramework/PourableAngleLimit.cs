using System;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008CE RID: 2254
	public class PourableAngleLimit : MonoBehaviour
	{
		// Token: 0x06003D31 RID: 15665 RVA: 0x00100FF2 File Offset: 0x000FF1F2
		private void Awake()
		{
			this.Constraint.ClampUpDirection = true;
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x00101000 File Offset: 0x000FF200
		public void FixedUpdate()
		{
			float upDirectionMaxDifference = Mathf.Lerp(this.AngleAtMinFill, this.AngleAtMaxFill, this.Pourable.NormalizedLiquidLevel);
			this.Constraint.UpDirectionMaxDifference = upDirectionMaxDifference;
			float angleFromUpToPour = Mathf.Lerp(this.PourAngleMinFill, this.PourAngleMaxFill, this.Pourable.NormalizedLiquidLevel);
			this.Pourable.AngleFromUpToPour = angleFromUpToPour;
		}

		// Token: 0x04002BFD RID: 11261
		public PourableModule Pourable;

		// Token: 0x04002BFE RID: 11262
		public DraggableConstraint Constraint;

		// Token: 0x04002BFF RID: 11263
		[Header("Settings")]
		public float AngleAtMaxFill = 15f;

		// Token: 0x04002C00 RID: 11264
		public float AngleAtMinFill = 90f;

		// Token: 0x04002C01 RID: 11265
		public float PourAngleMaxFill = 15f;

		// Token: 0x04002C02 RID: 11266
		public float PourAngleMinFill = 90f;
	}
}
