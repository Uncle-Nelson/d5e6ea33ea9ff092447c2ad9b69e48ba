using System;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.NPCs;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Management;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x0200056F RID: 1391
	public class PackagingStationConfiguration : EntityConfiguration
	{
		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x0008E653 File Offset: 0x0008C853
		// (set) Token: 0x06002287 RID: 8839 RVA: 0x0008E65B File Offset: 0x0008C85B
		public PackagingStation Station { get; protected set; }

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x0008E664 File Offset: 0x0008C864
		// (set) Token: 0x06002289 RID: 8841 RVA: 0x0008E66C File Offset: 0x0008C86C
		public TransitRoute DestinationRoute { get; protected set; }

		// Token: 0x0600228A RID: 8842 RVA: 0x0008E678 File Offset: 0x0008C878
		public PackagingStationConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, PackagingStation station) : base(replicator, configurable)
		{
			this.Station = station;
			this.AssignedPackager = new NPCField(this);
			this.AssignedPackager.TypeRequirement = typeof(Packager);
			this.AssignedPackager.onNPCChanged.AddListener(new UnityAction<NPC>(delegate(NPC <p0>)
			{
				base.InvokeChanged();
			}));
			this.Destination = new ObjectField(this);
			this.Destination.objectFilter = new ObjectSelector.ObjectFilter(this.DestinationFilter);
			this.Destination.onObjectChanged.AddListener(new UnityAction<BuildableItem>(delegate(BuildableItem <p0>)
			{
				base.InvokeChanged();
			}));
			this.Destination.onObjectChanged.AddListener(new UnityAction<BuildableItem>(this.DestinationChanged));
			this.Destination.DrawTransitLine = true;
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x0008E738 File Offset: 0x0008C938
		public override void Destroy()
		{
			base.Destroy();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.Destroy();
				this.DestinationRoute = null;
			}
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x0008E75C File Offset: 0x0008C95C
		private void DestinationChanged(BuildableItem item)
		{
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.Destroy();
				this.DestinationRoute = null;
			}
			if (this.Destination.SelectedObject != null)
			{
				this.DestinationRoute = new TransitRoute(this.Station, this.Destination.SelectedObject as ITransitEntity);
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

		// Token: 0x0600228D RID: 8845 RVA: 0x0008E7D3 File Offset: 0x0008C9D3
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			reason = "";
			return obj is ITransitEntity && (obj as ITransitEntity).Selectable && obj != this.Station;
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x0008E802 File Offset: 0x0008CA02
		public override void Selected()
		{
			base.Selected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(true);
			}
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x0008E81E File Offset: 0x0008CA1E
		public override void Deselected()
		{
			base.Deselected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(false);
			}
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x0008E83A File Offset: 0x0008CA3A
		public override bool ShouldSave()
		{
			return this.Destination.SelectedObject != null || base.ShouldSave();
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x0008E857 File Offset: 0x0008CA57
		public override string GetSaveString()
		{
			return new PackagingStationConfigurationData(this.Destination.GetData()).GetJson(true);
		}

		// Token: 0x04001A0F RID: 6671
		public NPCField AssignedPackager;

		// Token: 0x04001A10 RID: 6672
		public ObjectField Destination;
	}
}
