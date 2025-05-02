using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007D4 RID: 2004
	public class VehicleCollisionDetector : MonoBehaviour
	{
		// Token: 0x060036CE RID: 14030 RVA: 0x000E6DEA File Offset: 0x000E4FEA
		public void OnCollisionEnter(Collision collision)
		{
			if (this.onCollisionEnter != null)
			{
				this.onCollisionEnter.Invoke(collision);
			}
		}

		// Token: 0x04002755 RID: 10069
		public UnityEvent<Collision> onCollisionEnter;
	}
}
