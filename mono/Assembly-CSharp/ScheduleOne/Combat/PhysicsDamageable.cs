using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x0200073C RID: 1852
	public class PhysicsDamageable : MonoBehaviour, IDamageable
	{
		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x000CFDD6 File Offset: 0x000CDFD6
		// (set) Token: 0x06003211 RID: 12817 RVA: 0x000CFDDE File Offset: 0x000CDFDE
		public Vector3 averageVelocity { get; private set; } = Vector3.zero;

		// Token: 0x06003212 RID: 12818 RVA: 0x000CFDE7 File Offset: 0x000CDFE7
		public void OnValidate()
		{
			if (this.Rb == null)
			{
				this.Rb = base.GetComponent<Rigidbody>();
			}
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x000CFE03 File Offset: 0x000CE003
		public virtual void SendImpact(Impact impact)
		{
			this.ReceiveImpact(impact);
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x000CFE0C File Offset: 0x000CE00C
		public virtual void ReceiveImpact(Impact impact)
		{
			if (this.impactHistory.Contains(impact.ImpactID))
			{
				return;
			}
			this.impactHistory.Add(impact.ImpactID);
			if (this.onImpacted != null)
			{
				this.onImpacted(impact);
			}
			if (this.Rb != null)
			{
				this.Rb.AddForceAtPosition(-impact.Hit.normal * impact.ImpactForce * this.ForceMultiplier, impact.Hit.point, 1);
			}
		}

		// Token: 0x040023A6 RID: 9126
		public const int VELOCITY_HISTORY_LENGTH = 4;

		// Token: 0x040023A7 RID: 9127
		public Rigidbody Rb;

		// Token: 0x040023A8 RID: 9128
		public float ForceMultiplier = 1f;

		// Token: 0x040023A9 RID: 9129
		private List<int> impactHistory = new List<int>();

		// Token: 0x040023AA RID: 9130
		public Action<Impact> onImpacted;

		// Token: 0x040023AC RID: 9132
		private List<Vector3> velocityHistory = new List<Vector3>();
	}
}
