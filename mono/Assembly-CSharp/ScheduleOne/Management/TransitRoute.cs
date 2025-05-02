using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x02000591 RID: 1425
	public class TransitRoute
	{
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06002370 RID: 9072 RVA: 0x00090AD9 File Offset: 0x0008ECD9
		// (set) Token: 0x06002371 RID: 9073 RVA: 0x00090AE1 File Offset: 0x0008ECE1
		public ITransitEntity Source { get; protected set; }

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x00090AEA File Offset: 0x0008ECEA
		// (set) Token: 0x06002373 RID: 9075 RVA: 0x00090AF2 File Offset: 0x0008ECF2
		public ITransitEntity Destination { get; protected set; }

		// Token: 0x06002374 RID: 9076 RVA: 0x00090AFB File Offset: 0x0008ECFB
		public TransitRoute(ITransitEntity source, ITransitEntity destination)
		{
			this.Source = source;
			this.Destination = destination;
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onFixedUpdate = (Action)Delegate.Combine(instance.onFixedUpdate, new Action(this.Update));
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x00090B38 File Offset: 0x0008ED38
		public void Destroy()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onFixedUpdate = (Action)Delegate.Remove(instance.onFixedUpdate, new Action(this.Update));
			if (this.visuals != null)
			{
				Object.Destroy(this.visuals.gameObject);
			}
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x00090B8C File Offset: 0x0008ED8C
		public void SetVisualsActive(bool active)
		{
			if (this.visuals == null)
			{
				this.visuals = Object.Instantiate<GameObject>(Singleton<ManagementWorldspaceCanvas>.Instance.TransitRouteVisualsPrefab.gameObject, GameObject.Find("_Temp").transform).GetComponent<TransitLineVisuals>();
			}
			this.visuals.gameObject.SetActive(active);
			if (active)
			{
				this.Update();
			}
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x00090BF0 File Offset: 0x0008EDF0
		private void Update()
		{
			this.ValidateEntities();
			if (this.visuals == null || !this.visuals.gameObject.activeSelf)
			{
				return;
			}
			if (this.Source == null || this.Destination == null)
			{
				this.visuals.gameObject.SetActive(false);
				return;
			}
			Vector3.Distance(this.Source.LinkOrigin.position, this.Destination.LinkOrigin.position);
			this.visuals.SetSourcePosition(this.Source.LinkOrigin.position);
			this.visuals.SetDestinationPosition(this.Destination.LinkOrigin.position);
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x00090CA2 File Offset: 0x0008EEA2
		public virtual void SetSource(ITransitEntity source)
		{
			this.Source = source;
			if (this.onSourceChange != null)
			{
				this.onSourceChange(this.Source);
			}
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x00090CC4 File Offset: 0x0008EEC4
		public bool AreEntitiesNonNull()
		{
			this.ValidateEntities();
			return this.Source != null && this.Destination != null;
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x00090CDF File Offset: 0x0008EEDF
		public virtual void SetDestination(ITransitEntity destination)
		{
			this.Destination = destination;
			if (this.onDestinationChange != null)
			{
				this.onDestinationChange(this.Destination);
			}
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x00090D01 File Offset: 0x0008EF01
		private void ValidateEntities()
		{
			if (this.Source != null && this.Source.IsDestroyed)
			{
				this.SetSource(null);
			}
			if (this.Destination != null && this.Destination.IsDestroyed)
			{
				this.SetDestination(null);
			}
		}

		// Token: 0x04001A83 RID: 6787
		protected TransitLineVisuals visuals;

		// Token: 0x04001A84 RID: 6788
		public Action<ITransitEntity> onSourceChange;

		// Token: 0x04001A85 RID: 6789
		public Action<ITransitEntity> onDestinationChange;
	}
}
