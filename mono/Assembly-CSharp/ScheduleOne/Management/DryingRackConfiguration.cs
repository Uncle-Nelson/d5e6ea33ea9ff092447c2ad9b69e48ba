using System;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Management;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x0200056A RID: 1386
	public class DryingRackConfiguration : EntityConfiguration
	{
		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x0600223D RID: 8765 RVA: 0x0008D823 File Offset: 0x0008BA23
		// (set) Token: 0x0600223E RID: 8766 RVA: 0x0008D82B File Offset: 0x0008BA2B
		public DryingRack Rack { get; protected set; }

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600223F RID: 8767 RVA: 0x0008D834 File Offset: 0x0008BA34
		// (set) Token: 0x06002240 RID: 8768 RVA: 0x0008D83C File Offset: 0x0008BA3C
		public TransitRoute DestinationRoute { get; protected set; }

		// Token: 0x06002241 RID: 8769 RVA: 0x0008D848 File Offset: 0x0008BA48
		public DryingRackConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, DryingRack rack) : base(replicator, configurable)
		{
			this.Rack = rack;
			this.AssignedBotanist = new NPCField(this);
			this.AssignedBotanist.TypeRequirement = typeof(Botanist);
			this.AssignedBotanist.onNPCChanged.AddListener(new UnityAction<NPC>(delegate(NPC <p0>)
			{
				base.InvokeChanged();
			}));
			this.TargetQuality = new QualityField(this);
			this.TargetQuality.onValueChanged.AddListener(new UnityAction<EQuality>(delegate(EQuality <p0>)
			{
				base.InvokeChanged();
			}));
			this.TargetQuality.SetValue(EQuality.Premium, false);
			this.Destination = new ObjectField(this);
			this.Destination.objectFilter = new ObjectSelector.ObjectFilter(this.DestinationFilter);
			this.Destination.onObjectChanged.AddListener(new UnityAction<BuildableItem>(delegate(BuildableItem <p0>)
			{
				base.InvokeChanged();
			}));
			this.Destination.onObjectChanged.AddListener(new UnityAction<BuildableItem>(this.DestinationChanged));
			this.Destination.DrawTransitLine = true;
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x0008D93D File Offset: 0x0008BB3D
		public override void Destroy()
		{
			base.Destroy();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.Destroy();
				this.DestinationRoute = null;
			}
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x0008D960 File Offset: 0x0008BB60
		private void DestinationChanged(BuildableItem item)
		{
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.Destroy();
				this.DestinationRoute = null;
			}
			if (this.Destination.SelectedObject != null)
			{
				this.DestinationRoute = new TransitRoute(this.Rack, this.Destination.SelectedObject as ITransitEntity);
				if (base.IsSelected)
				{
					this.DestinationRoute.SetVisualsActive(true);
					return;
				}
			}
			else
			{
				this.DestinationRoute = null;
			}
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x0008D9D7 File Offset: 0x0008BBD7
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			reason = "";
			return obj is ITransitEntity && (obj as ITransitEntity).Selectable && obj != this.Rack;
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x0008DA06 File Offset: 0x0008BC06
		public override void Selected()
		{
			base.Selected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(true);
			}
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x0008DA22 File Offset: 0x0008BC22
		public override void Deselected()
		{
			base.Deselected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(false);
			}
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x0008DA3E File Offset: 0x0008BC3E
		public override bool ShouldSave()
		{
			return this.Destination.SelectedObject != null || base.ShouldSave();
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0008DA5B File Offset: 0x0008BC5B
		public override string GetSaveString()
		{
			return new DryingRackConfigurationData(this.TargetQuality.GetData(), this.Destination.GetData()).GetJson(true);
		}

		// Token: 0x040019F5 RID: 6645
		public NPCField AssignedBotanist;

		// Token: 0x040019F6 RID: 6646
		public QualityField TargetQuality;

		// Token: 0x040019F7 RID: 6647
		public ObjectField Destination;
	}
}
