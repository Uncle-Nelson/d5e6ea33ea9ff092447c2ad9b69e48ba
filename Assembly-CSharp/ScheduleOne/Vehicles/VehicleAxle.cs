using System;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007D2 RID: 2002
	public class VehicleAxle : MonoBehaviour
	{
		// Token: 0x060036C0 RID: 14016 RVA: 0x000E65CD File Offset: 0x000E47CD
		protected virtual void Awake()
		{
			this.model = base.transform.Find("Model");
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x000E65E8 File Offset: 0x000E47E8
		protected virtual void LateUpdate()
		{
			Vector3 position = base.transform.position;
			Vector3 position2 = this.wheel.axleConnectionPoint.position;
			this.model.transform.position = (position + position2) / 2f;
			base.transform.LookAt(position2);
			this.model.transform.localScale = new Vector3(this.model.transform.localScale.x, 0.5f * Vector3.Distance(position, position2), this.model.transform.localScale.z);
		}

		// Token: 0x0400273F RID: 10047
		[Header("References")]
		[SerializeField]
		protected Wheel wheel;

		// Token: 0x04002740 RID: 10048
		private Transform model;
	}
}
