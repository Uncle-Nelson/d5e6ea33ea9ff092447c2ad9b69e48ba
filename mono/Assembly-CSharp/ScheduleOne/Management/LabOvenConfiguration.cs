using System;
using ScheduleOne.EntityFramework;
using ScheduleOne.NPCs;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Management;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x0200056C RID: 1388
	public class LabOvenConfiguration : EntityConfiguration
	{
		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x0008DB82 File Offset: 0x0008BD82
		// (set) Token: 0x0600225C RID: 8796 RVA: 0x0008DB8A File Offset: 0x0008BD8A
		public LabOven Oven { get; protected set; }

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600225D RID: 8797 RVA: 0x0008DB93 File Offset: 0x0008BD93
		// (set) Token: 0x0600225E RID: 8798 RVA: 0x0008DB9B File Offset: 0x0008BD9B
		public TransitRoute DestinationRoute { get; protected set; }

		// Token: 0x0600225F RID: 8799 RVA: 0x0008DBA4 File Offset: 0x0008BDA4
		public LabOvenConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, LabOven oven) : base(replicator, configurable)
		{
			this.Oven = oven;
			this.AssignedChemist = new NPCField(this);
			this.AssignedChemist.onNPCChanged.AddListener(new UnityAction<NPC>(delegate(NPC <p0>)
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

		// Token: 0x06002260 RID: 8800 RVA: 0x0008DC4F File Offset: 0x0008BE4F
		public override void Destroy()
		{
			base.Destroy();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.Destroy();
				this.DestinationRoute = null;
			}
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x0008DC74 File Offset: 0x0008BE74
		private void DestinationChanged(BuildableItem item)
		{
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.Destroy();
				this.DestinationRoute = null;
			}
			if (this.Destination.SelectedObject != null)
			{
				this.DestinationRoute = new TransitRoute(this.Oven, this.Destination.SelectedObject as ITransitEntity);
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

		// Token: 0x06002262 RID: 8802 RVA: 0x0008DCEB File Offset: 0x0008BEEB
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			reason = "";
			return obj is ITransitEntity && (obj as ITransitEntity).Selectable && obj != this.Oven;
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x0008DD1A File Offset: 0x0008BF1A
		public override void Selected()
		{
			base.Selected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(true);
			}
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x0008DD36 File Offset: 0x0008BF36
		public override void Deselected()
		{
			base.Deselected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(false);
			}
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x0008DD52 File Offset: 0x0008BF52
		public override bool ShouldSave()
		{
			return this.Destination.SelectedObject != null || base.ShouldSave();
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x0008DD6F File Offset: 0x0008BF6F
		public override string GetSaveString()
		{
			return new LabOvenConfigurationData(this.Destination.GetData()).GetJson(true);
		}

		// Token: 0x040019FF RID: 6655
		public NPCField AssignedChemist;

		// Token: 0x04001A00 RID: 6656
		public ObjectField Destination;
	}
}
