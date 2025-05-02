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
	// Token: 0x02000565 RID: 1381
	public class BrickPressConfiguration : EntityConfiguration
	{
		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x0008C4C3 File Offset: 0x0008A6C3
		// (set) Token: 0x060021F8 RID: 8696 RVA: 0x0008C4CB File Offset: 0x0008A6CB
		public BrickPress BrickPress { get; protected set; }

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x0008C4D4 File Offset: 0x0008A6D4
		// (set) Token: 0x060021FA RID: 8698 RVA: 0x0008C4DC File Offset: 0x0008A6DC
		public TransitRoute DestinationRoute { get; protected set; }

		// Token: 0x060021FB RID: 8699 RVA: 0x0008C4E8 File Offset: 0x0008A6E8
		public BrickPressConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, BrickPress station) : base(replicator, configurable)
		{
			this.BrickPress = station;
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

		// Token: 0x060021FC RID: 8700 RVA: 0x0008C5A8 File Offset: 0x0008A7A8
		public override void Destroy()
		{
			base.Destroy();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.Destroy();
				this.DestinationRoute = null;
			}
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x0008C5CC File Offset: 0x0008A7CC
		private void DestinationChanged(BuildableItem item)
		{
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.Destroy();
				this.DestinationRoute = null;
			}
			if (this.Destination.SelectedObject != null)
			{
				this.DestinationRoute = new TransitRoute(this.BrickPress, this.Destination.SelectedObject as ITransitEntity);
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

		// Token: 0x060021FE RID: 8702 RVA: 0x0008C643 File Offset: 0x0008A843
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			reason = "";
			return obj is ITransitEntity && (obj as ITransitEntity).Selectable && obj != this.BrickPress;
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x0008C672 File Offset: 0x0008A872
		public override void Selected()
		{
			base.Selected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(true);
			}
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x0008C68E File Offset: 0x0008A88E
		public override void Deselected()
		{
			base.Deselected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(false);
			}
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x0008C6AA File Offset: 0x0008A8AA
		public override bool ShouldSave()
		{
			return this.Destination.SelectedObject != null || base.ShouldSave();
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x0008C6C7 File Offset: 0x0008A8C7
		public override string GetSaveString()
		{
			return new BrickPressConfigurationData(this.Destination.GetData()).GetJson(true);
		}

		// Token: 0x040019DB RID: 6619
		public NPCField AssignedPackager;

		// Token: 0x040019DC RID: 6620
		public ObjectField Destination;
	}
}
