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
	// Token: 0x02000566 RID: 1382
	public class CauldronConfiguration : EntityConfiguration
	{
		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x0008C6DF File Offset: 0x0008A8DF
		// (set) Token: 0x06002206 RID: 8710 RVA: 0x0008C6E7 File Offset: 0x0008A8E7
		public Cauldron Station { get; protected set; }

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x0008C6F0 File Offset: 0x0008A8F0
		// (set) Token: 0x06002208 RID: 8712 RVA: 0x0008C6F8 File Offset: 0x0008A8F8
		public TransitRoute DestinationRoute { get; protected set; }

		// Token: 0x06002209 RID: 8713 RVA: 0x0008C704 File Offset: 0x0008A904
		public CauldronConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Cauldron cauldron) : base(replicator, configurable)
		{
			this.Station = cauldron;
			this.AssignedChemist = new NPCField(this);
			this.AssignedChemist.TypeRequirement = typeof(Chemist);
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

		// Token: 0x0600220A RID: 8714 RVA: 0x0008C7C4 File Offset: 0x0008A9C4
		public override void Destroy()
		{
			base.Destroy();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.Destroy();
				this.DestinationRoute = null;
			}
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x0008C7E8 File Offset: 0x0008A9E8
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

		// Token: 0x0600220C RID: 8716 RVA: 0x0008C85F File Offset: 0x0008AA5F
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			reason = "";
			return obj is ITransitEntity && (obj as ITransitEntity).Selectable && obj != this.Station;
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x0008C88E File Offset: 0x0008AA8E
		public override void Selected()
		{
			base.Selected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(true);
			}
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x0008C8AA File Offset: 0x0008AAAA
		public override void Deselected()
		{
			base.Deselected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(false);
			}
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x0008C8C6 File Offset: 0x0008AAC6
		public override bool ShouldSave()
		{
			return this.Destination.SelectedObject != null || base.ShouldSave();
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x0008C8E3 File Offset: 0x0008AAE3
		public override string GetSaveString()
		{
			return new CauldronConfigurationData(this.Destination.GetData()).GetJson(true);
		}

		// Token: 0x040019DF RID: 6623
		public NPCField AssignedChemist;

		// Token: 0x040019E0 RID: 6624
		public ObjectField Destination;
	}
}
