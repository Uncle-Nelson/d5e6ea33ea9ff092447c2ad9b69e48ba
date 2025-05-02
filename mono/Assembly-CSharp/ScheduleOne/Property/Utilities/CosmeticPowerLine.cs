using System;
using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.Property.Utilities.Power;
using UnityEngine;

namespace ScheduleOne.Property.Utilities
{
	// Token: 0x02000822 RID: 2082
	public class CosmeticPowerLine : MonoBehaviour
	{
		// Token: 0x060038BD RID: 14525 RVA: 0x000EFD36 File Offset: 0x000EDF36
		[Button]
		public void Draw()
		{
			PowerLine.DrawPowerLine(this.startPoint.position, this.endPoint.position, this.segments, this.LengthFactor);
		}

		// Token: 0x0400292C RID: 10540
		public Transform startPoint;

		// Token: 0x0400292D RID: 10541
		public Transform endPoint;

		// Token: 0x0400292E RID: 10542
		public List<Transform> segments = new List<Transform>();

		// Token: 0x0400292F RID: 10543
		public float LengthFactor = 1.002f;
	}
}
