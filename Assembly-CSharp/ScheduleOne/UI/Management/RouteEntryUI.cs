using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AF2 RID: 2802
	public class RouteEntryUI : MonoBehaviour
	{
		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06004AE7 RID: 19175 RVA: 0x0013ABA8 File Offset: 0x00138DA8
		// (set) Token: 0x06004AE8 RID: 19176 RVA: 0x0013ABB0 File Offset: 0x00138DB0
		public AdvancedTransitRoute AssignedRoute { get; private set; }

		// Token: 0x06004AE9 RID: 19177 RVA: 0x0013ABB9 File Offset: 0x00138DB9
		public void AssignRoute(AdvancedTransitRoute route)
		{
			this.AssignedRoute = route;
			this.RefreshUI();
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x0013ABC8 File Offset: 0x00138DC8
		public void ClearRoute()
		{
			this.AssignedRoute = null;
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x0013ABD4 File Offset: 0x00138DD4
		public void RefreshUI()
		{
			if (this.AssignedRoute != null && this.AssignedRoute.Source != null)
			{
				this.SourceLabel.text = this.AssignedRoute.Source.Name;
			}
			else
			{
				this.SourceLabel.text = "None";
			}
			if (this.AssignedRoute != null && this.AssignedRoute.Destination != null)
			{
				this.DestinationLabel.text = this.AssignedRoute.Destination.Name;
				return;
			}
			this.DestinationLabel.text = "None";
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x0013AC64 File Offset: 0x00138E64
		public void SourceClicked()
		{
			this.settingSource = true;
			this.settingDestination = false;
			List<ITransitEntity> selectedObjects = new List<ITransitEntity>();
			List<Transform> list = new List<Transform>();
			if (this.AssignedRoute.Destination != null)
			{
				list.Add(this.AssignedRoute.Destination.LinkOrigin);
			}
			Singleton<ManagementInterface>.Instance.TransitEntitySelector.Open("Select source", "Click an entity to set it as the route source", 1, selectedObjects, new List<Type>(), new TransitEntitySelector.ObjectFilter(this.ObjectValid), new Action<List<ITransitEntity>>(this.ObjectsSelected), list, false);
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x0013ACE8 File Offset: 0x00138EE8
		public void DestinationClicked()
		{
			this.settingDestination = true;
			this.settingSource = false;
			List<ITransitEntity> selectedObjects = new List<ITransitEntity>();
			List<Transform> list = new List<Transform>();
			if (this.AssignedRoute.Source != null)
			{
				list.Add(this.AssignedRoute.Source.LinkOrigin);
			}
			Singleton<ManagementInterface>.Instance.TransitEntitySelector.Open("Select destination", "Click an entity to set it as the route destination", 1, selectedObjects, new List<Type>(), new TransitEntitySelector.ObjectFilter(this.ObjectValid), new Action<List<ITransitEntity>>(this.ObjectsSelected), list, true);
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x000045B1 File Offset: 0x000027B1
		public void FilterClicked()
		{
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x0013AD6C File Offset: 0x00138F6C
		public void DeleteClicked()
		{
			if (this.onDeleteClicked != null)
			{
				this.onDeleteClicked.Invoke();
			}
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x0013AD84 File Offset: 0x00138F84
		private bool ObjectValid(ITransitEntity obj, out string reason)
		{
			reason = string.Empty;
			if (this.AssignedRoute == null)
			{
				return false;
			}
			if (obj == null)
			{
				return false;
			}
			if (this.settingDestination && obj == this.AssignedRoute.Source)
			{
				reason = "Destination cannot be the same as the source";
				return false;
			}
			if (this.settingSource && obj == this.AssignedRoute.Destination)
			{
				reason = "Source cannot be the same as the destination";
				return false;
			}
			return true;
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x0013ADE8 File Offset: 0x00138FE8
		public void ObjectsSelected(List<ITransitEntity> objs)
		{
			if (objs.Count > 1)
			{
				objs.RemoveAt(0);
			}
			if (this.settingSource)
			{
				this.AssignedRoute.SetSource((objs.Count > 0) ? objs[0] : null);
			}
			if (this.settingDestination)
			{
				this.AssignedRoute.SetDestination((objs.Count > 0) ? objs[0] : null);
			}
		}

		// Token: 0x04003830 RID: 14384
		[Header("References")]
		public TextMeshProUGUI SourceLabel;

		// Token: 0x04003831 RID: 14385
		public TextMeshProUGUI DestinationLabel;

		// Token: 0x04003832 RID: 14386
		public Image FilterIcon;

		// Token: 0x04003833 RID: 14387
		public UnityEvent onDeleteClicked = new UnityEvent();

		// Token: 0x04003834 RID: 14388
		private bool settingSource;

		// Token: 0x04003835 RID: 14389
		private bool settingDestination;
	}
}
