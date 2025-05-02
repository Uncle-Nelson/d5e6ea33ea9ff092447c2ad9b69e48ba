using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020007FD RID: 2045
	public class Sensor : MonoBehaviour
	{
		// Token: 0x0600378C RID: 14220 RVA: 0x000EA0D6 File Offset: 0x000E82D6
		protected virtual void Start()
		{
			this.vehicle = base.GetComponentInParent<LandVehicle>();
			base.InvokeRepeating("Check", 0f, 0.33f);
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x000EA0FC File Offset: 0x000E82FC
		public void Check()
		{
			if (NetworkSingleton<TimeManager>.Instance.SleepInProgress)
			{
				return;
			}
			if (this.vehicle.Agent.KinematicMode)
			{
				return;
			}
			if (this.vehicle.isStatic)
			{
				return;
			}
			if (this.vehicle != null)
			{
				this.calculatedDetectionRange = Mathf.Lerp(this.minDetectionRange, this.maxDetectionRange, Mathf.Clamp01(this.vehicle.speed_Kmh / this.vehicle.TopSpeed));
			}
			else
			{
				this.calculatedDetectionRange = this.maxDetectionRange;
			}
			Vector3 vector = base.transform.position - base.transform.forward * this.checkRadius;
			this.hits = Physics.SphereCastAll(vector, this.checkRadius, base.transform.forward, this.calculatedDetectionRange, this.checkMask, 2).ToList<RaycastHit>();
			this.hits = (from x in this.hits
			orderby Vector3.Distance(base.transform.position, x.point)
			select x).ToList<RaycastHit>();
			bool flag = false;
			for (int i = 0; i < this.hits.Count; i++)
			{
				if (!(this.vehicle != null) || !this.hits[i].collider.transform.IsChildOf(this.vehicle.transform))
				{
					VehicleObstacle componentInParent = this.hits[i].collider.transform.GetComponentInParent<VehicleObstacle>();
					LandVehicle componentInParent2 = this.hits[i].collider.transform.GetComponentInParent<LandVehicle>();
					NPC componentInParent3 = this.hits[i].collider.transform.GetComponentInParent<NPC>();
					Player componentInParent4 = this.hits[i].collider.transform.GetComponentInParent<Player>();
					if (componentInParent != null)
					{
						if (!componentInParent.twoSided && Vector3.Angle(-componentInParent.transform.forward, base.transform.forward) > 90f)
						{
							goto IL_230;
						}
					}
					else if (!(componentInParent2 != null) && !(componentInParent3 != null))
					{
						componentInParent4 != null;
					}
					flag = true;
					this.hit = this.hits[i];
					break;
				}
				IL_230:;
			}
			if (flag)
			{
				this.obstruction = this.hit.collider;
				this.obstructionDistance = Vector3.Distance(base.transform.position, this.hit.point);
				return;
			}
			this.obstruction = null;
			this.obstructionDistance = float.MaxValue;
		}

		// Token: 0x04002833 RID: 10291
		public Collider obstruction;

		// Token: 0x04002834 RID: 10292
		public float obstructionDistance;

		// Token: 0x04002835 RID: 10293
		public const float checkRate = 0.33f;

		// Token: 0x04002836 RID: 10294
		[Header("Settings")]
		[SerializeField]
		protected float minDetectionRange = 3f;

		// Token: 0x04002837 RID: 10295
		[SerializeField]
		protected float maxDetectionRange = 12f;

		// Token: 0x04002838 RID: 10296
		public float checkRadius = 1f;

		// Token: 0x04002839 RID: 10297
		public LayerMask checkMask;

		// Token: 0x0400283A RID: 10298
		private LandVehicle vehicle;

		// Token: 0x0400283B RID: 10299
		[HideInInspector]
		public float calculatedDetectionRange;

		// Token: 0x0400283C RID: 10300
		private RaycastHit hit;

		// Token: 0x0400283D RID: 10301
		private List<RaycastHit> hits = new List<RaycastHit>();
	}
}
