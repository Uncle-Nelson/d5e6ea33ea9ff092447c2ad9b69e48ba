using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x020009C6 RID: 2502
	public class CanvasDistanceFade : MonoBehaviour
	{
		// Token: 0x0600437B RID: 17275 RVA: 0x0011AC10 File Offset: 0x00118E10
		public void LateUpdate()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			float num = Vector3.Distance(PlayerSingleton<PlayerCamera>.Instance.transform.position, base.transform.position);
			if (num < this.MinDistance)
			{
				this.CanvasGroup.alpha = 1f;
				return;
			}
			if (num > this.MaxDistance)
			{
				this.CanvasGroup.alpha = 0f;
				return;
			}
			this.CanvasGroup.alpha = 1f - (num - this.MinDistance) / (this.MaxDistance - this.MinDistance);
		}

		// Token: 0x0400311A RID: 12570
		public CanvasGroup CanvasGroup;

		// Token: 0x0400311B RID: 12571
		public float MinDistance = 5f;

		// Token: 0x0400311C RID: 12572
		public float MaxDistance = 10f;
	}
}
