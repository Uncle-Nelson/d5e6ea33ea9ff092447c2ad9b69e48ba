using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.GameTime;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006FF RID: 1791
	[RequireComponent(typeof(Rigidbody))]
	public class VehicleDetector : MonoBehaviour
	{
		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x000CA336 File Offset: 0x000C8536
		// (set) Token: 0x0600309C RID: 12444 RVA: 0x000CA33E File Offset: 0x000C853E
		public bool IgnoreNewDetections { get; protected set; }

		// Token: 0x0600309D RID: 12445 RVA: 0x000CA348 File Offset: 0x000C8548
		private void Awake()
		{
			Rigidbody rigidbody = base.GetComponent<Rigidbody>();
			if (rigidbody == null)
			{
				rigidbody = base.gameObject.AddComponent<Rigidbody>();
			}
			this.detectionColliders = base.GetComponentsInChildren<Collider>();
			rigidbody.isKinematic = true;
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x000CA384 File Offset: 0x000C8584
		private void Start()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onTick = (Action)Delegate.Combine(instance.onTick, new Action(this.MinPass));
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x000CA3AC File Offset: 0x000C85AC
		private void OnDestroy()
		{
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onTick = (Action)Delegate.Remove(instance.onTick, new Action(this.MinPass));
			}
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x000CA3DC File Offset: 0x000C85DC
		private void OnTriggerEnter(Collider other)
		{
			if (this.IgnoreNewDetections)
			{
				return;
			}
			LandVehicle componentInParent = other.GetComponentInParent<LandVehicle>();
			if (componentInParent != null && other == componentInParent.boundingBox && !this.vehicles.Contains(componentInParent))
			{
				this.vehicles.Add(componentInParent);
				this.SortVehicles();
			}
		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x000CA430 File Offset: 0x000C8630
		private void MinPass()
		{
			bool flag = false;
			for (int i = 0; i < NetworkSingleton<VehicleManager>.Instance.AllVehicles.Count; i++)
			{
				if (Vector3.SqrMagnitude(NetworkSingleton<VehicleManager>.Instance.AllVehicles[i].transform.position - base.transform.position) < 400f)
				{
					flag = true;
					break;
				}
			}
			if (flag != this.collidersEnabled)
			{
				this.collidersEnabled = flag;
				for (int j = 0; j < this.detectionColliders.Length; j++)
				{
					this.detectionColliders[j].enabled = this.collidersEnabled;
				}
			}
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x000CA4CC File Offset: 0x000C86CC
		private void OnTriggerExit(Collider other)
		{
			if (this.ignoreExit)
			{
				return;
			}
			LandVehicle componentInParent = other.GetComponentInParent<LandVehicle>();
			if (componentInParent != null && other == componentInParent.boundingBox && this.vehicles.Contains(componentInParent))
			{
				this.vehicles.Remove(componentInParent);
				this.SortVehicles();
			}
		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x000CA524 File Offset: 0x000C8724
		private void SortVehicles()
		{
			if (this.vehicles.Count > 1)
			{
				from x in this.vehicles
				orderby Vector3.Distance(base.transform.position, x.transform.position)
				select x;
			}
			if (this.vehicles.Count > 0)
			{
				this.closestVehicle = this.vehicles[0];
				return;
			}
			this.closestVehicle = null;
		}

		// Token: 0x060030A4 RID: 12452 RVA: 0x000CA580 File Offset: 0x000C8780
		public void SetIgnoreNewCollisions(bool ignore)
		{
			this.IgnoreNewDetections = ignore;
			if (!ignore)
			{
				this.ignoreExit = true;
				Collider[] componentsInChildren = base.GetComponentsInChildren<Collider>();
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					if (componentsInChildren[i].isTrigger)
					{
						componentsInChildren[i].enabled = false;
						componentsInChildren[i].enabled = true;
					}
				}
				this.ignoreExit = false;
			}
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x000CA5D8 File Offset: 0x000C87D8
		public bool AreAnyVehiclesOccupied()
		{
			for (int i = 0; i < this.vehicles.Count; i++)
			{
				if (this.vehicles[i].isOccupied)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x000CA611 File Offset: 0x000C8811
		public void Clear()
		{
			this.vehicles.Clear();
			this.SortVehicles();
		}

		// Token: 0x0400228B RID: 8843
		public const float ACTIVATION_DISTANCE_SQ = 400f;

		// Token: 0x0400228C RID: 8844
		public List<LandVehicle> vehicles = new List<LandVehicle>();

		// Token: 0x0400228D RID: 8845
		public LandVehicle closestVehicle;

		// Token: 0x0400228F RID: 8847
		private bool ignoreExit;

		// Token: 0x04002290 RID: 8848
		private Collider[] detectionColliders;

		// Token: 0x04002291 RID: 8849
		private bool collidersEnabled = true;
	}
}
