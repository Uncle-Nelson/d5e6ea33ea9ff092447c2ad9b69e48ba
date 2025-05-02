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
	// Token: 0x0200056D RID: 1389
	public class MixingStationConfiguration : EntityConfiguration
	{
		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06002269 RID: 8809 RVA: 0x0008DD87 File Offset: 0x0008BF87
		// (set) Token: 0x0600226A RID: 8810 RVA: 0x0008DD8F File Offset: 0x0008BF8F
		public MixingStation station { get; protected set; }

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600226B RID: 8811 RVA: 0x0008DD98 File Offset: 0x0008BF98
		// (set) Token: 0x0600226C RID: 8812 RVA: 0x0008DDA0 File Offset: 0x0008BFA0
		public TransitRoute DestinationRoute { get; protected set; }

		// Token: 0x0600226D RID: 8813 RVA: 0x0008DDAC File Offset: 0x0008BFAC
		public MixingStationConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, MixingStation station) : base(replicator, configurable)
		{
			this.station = station;
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
			this.StartThrehold = new NumberField(this);
			this.StartThrehold.Configure(1f, 10f, true);
			this.StartThrehold.SetValue(1f, false);
			this.StartThrehold.onItemChanged.AddListener(new UnityAction<float>(delegate(float <p0>)
			{
				base.InvokeChanged();
			}));
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x0008DEBB File Offset: 0x0008C0BB
		public override void Destroy()
		{
			base.Destroy();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.Destroy();
				this.DestinationRoute = null;
			}
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x0008DEE0 File Offset: 0x0008C0E0
		private void DestinationChanged(BuildableItem item)
		{
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.Destroy();
				this.DestinationRoute = null;
			}
			if (this.Destination.SelectedObject != null)
			{
				this.DestinationRoute = new TransitRoute(this.station, this.Destination.SelectedObject as ITransitEntity);
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

		// Token: 0x06002270 RID: 8816 RVA: 0x0008DF57 File Offset: 0x0008C157
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			reason = "";
			return obj is ITransitEntity && (obj as ITransitEntity).Selectable && obj != this.station;
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x0008DF86 File Offset: 0x0008C186
		public override void Selected()
		{
			base.Selected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(true);
			}
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x0008DFA2 File Offset: 0x0008C1A2
		public override void Deselected()
		{
			base.Deselected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(false);
			}
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x0008DFBE File Offset: 0x0008C1BE
		public override bool ShouldSave()
		{
			return this.Destination.SelectedObject != null || base.ShouldSave();
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x0008DFDB File Offset: 0x0008C1DB
		public override string GetSaveString()
		{
			return new MixingStationConfigurationData(this.Destination.GetData(), this.StartThrehold.GetData()).GetJson(true);
		}

		// Token: 0x04001A03 RID: 6659
		public NPCField AssignedChemist;

		// Token: 0x04001A04 RID: 6660
		public ObjectField Destination;

		// Token: 0x04001A05 RID: 6661
		public NumberField StartThrehold;
	}
}
