using System;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005CB RID: 1483
	[Serializable]
	public class LawActivitySettings
	{
		// Token: 0x060024A9 RID: 9385 RVA: 0x00093F28 File Offset: 0x00092128
		public void Evaluate()
		{
			for (int i = 0; i < this.Patrols.Length; i++)
			{
				this.Patrols[i].Evaluate();
			}
			for (int j = 0; j < this.Checkpoints.Length; j++)
			{
				this.Checkpoints[j].Evaluate();
			}
			for (int k = 0; k < this.Curfews.Length; k++)
			{
				this.Curfews[k].Evaluate(false);
			}
			for (int l = 0; l < this.VehiclePatrols.Length; l++)
			{
				this.VehiclePatrols[l].Evaluate();
			}
			for (int m = 0; m < this.Sentries.Length; m++)
			{
				this.Sentries[m].Evaluate();
			}
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x00093FDC File Offset: 0x000921DC
		public void End()
		{
			for (int i = 0; i < this.Curfews.Length; i++)
			{
				if (this.Curfews[i].Enabled)
				{
					this.Curfews[i].shouldDisable = true;
				}
			}
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x0009401C File Offset: 0x0009221C
		public void OnLoaded()
		{
			Debug.Log("Settings loaded");
			for (int i = 0; i < this.Curfews.Length; i++)
			{
				this.Curfews[i].Evaluate(true);
			}
		}

		// Token: 0x04001B3F RID: 6975
		public PatrolInstance[] Patrols;

		// Token: 0x04001B40 RID: 6976
		public CheckpointInstance[] Checkpoints;

		// Token: 0x04001B41 RID: 6977
		public CurfewInstance[] Curfews;

		// Token: 0x04001B42 RID: 6978
		public VehiclePatrolInstance[] VehiclePatrols;

		// Token: 0x04001B43 RID: 6979
		public SentryInstance[] Sentries;
	}
}
