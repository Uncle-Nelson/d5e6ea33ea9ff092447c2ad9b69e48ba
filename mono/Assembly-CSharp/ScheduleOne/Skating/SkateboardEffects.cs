using System;
using UnityEngine;

namespace ScheduleOne.Skating
{
	// Token: 0x020002D1 RID: 721
	[RequireComponent(typeof(Skateboard))]
	public class SkateboardEffects : MonoBehaviour
	{
		// Token: 0x06000F9C RID: 3996 RVA: 0x000459A5 File Offset: 0x00043BA5
		private void Awake()
		{
			this.skateboard = base.GetComponent<Skateboard>();
			this.trailsOpacity = this.Trails[0].startColor.a;
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x000459CC File Offset: 0x00043BCC
		private void FixedUpdate()
		{
			foreach (TrailRenderer trailRenderer in this.Trails)
			{
				Color startColor = trailRenderer.startColor;
				startColor.a = this.trailsOpacity * Mathf.Clamp01(this.skateboard.CurrentSpeed_Kmh / this.skateboard.TopSpeed_Kmh);
				trailRenderer.startColor = startColor;
			}
		}

		// Token: 0x04001049 RID: 4169
		private Skateboard skateboard;

		// Token: 0x0400104A RID: 4170
		[Header("References")]
		public TrailRenderer[] Trails;

		// Token: 0x0400104B RID: 4171
		private float trailsOpacity;
	}
}
