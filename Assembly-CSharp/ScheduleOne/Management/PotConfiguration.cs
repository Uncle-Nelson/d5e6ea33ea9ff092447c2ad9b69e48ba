using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
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
	// Token: 0x02000570 RID: 1392
	public class PotConfiguration : EntityConfiguration
	{
		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x0008E86F File Offset: 0x0008CA6F
		// (set) Token: 0x06002295 RID: 8853 RVA: 0x0008E877 File Offset: 0x0008CA77
		public Pot Pot { get; protected set; }

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x0008E880 File Offset: 0x0008CA80
		// (set) Token: 0x06002297 RID: 8855 RVA: 0x0008E888 File Offset: 0x0008CA88
		public TransitRoute DestinationRoute { get; protected set; }

		// Token: 0x06002298 RID: 8856 RVA: 0x0008E894 File Offset: 0x0008CA94
		public PotConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Pot pot) : base(replicator, configurable)
		{
			this.Pot = pot;
			this.Seed = new ItemField(this);
			this.Seed.CanSelectNone = true;
			List<ItemDefinition> options = Singleton<Registry>.Instance.Seeds.Cast<ItemDefinition>().ToList<ItemDefinition>();
			this.Seed.Options = options;
			this.Seed.onItemChanged.AddListener(new UnityAction<ItemDefinition>(delegate(ItemDefinition <p0>)
			{
				base.InvokeChanged();
			}));
			List<ItemDefinition> options2 = Singleton<ManagementUtilities>.Instance.AdditiveDefinitions.Cast<ItemDefinition>().ToList<ItemDefinition>();
			this.Additive1 = new ItemField(this);
			this.Additive1.CanSelectNone = true;
			this.Additive1.Options = options2;
			this.Additive1.onItemChanged.AddListener(new UnityAction<ItemDefinition>(delegate(ItemDefinition <p0>)
			{
				base.InvokeChanged();
			}));
			this.Additive2 = new ItemField(this);
			this.Additive2.CanSelectNone = true;
			this.Additive2.Options = options2;
			this.Additive2.onItemChanged.AddListener(new UnityAction<ItemDefinition>(delegate(ItemDefinition <p0>)
			{
				base.InvokeChanged();
			}));
			this.Additive3 = new ItemField(this);
			this.Additive3.CanSelectNone = true;
			this.Additive3.Options = options2;
			this.Additive3.onItemChanged.AddListener(new UnityAction<ItemDefinition>(delegate(ItemDefinition <p0>)
			{
				base.InvokeChanged();
			}));
			this.AssignedBotanist = new NPCField(this);
			this.AssignedBotanist.TypeRequirement = typeof(Botanist);
			this.AssignedBotanist.onNPCChanged.AddListener(new UnityAction<NPC>(delegate(NPC <p0>)
			{
				base.InvokeChanged();
			}));
			this.Destination = new ObjectField(this);
			this.Destination.objectFilter = new ScheduleOne.UI.Management.ObjectSelector.ObjectFilter(this.DestinationFilter);
			this.Destination.onObjectChanged.AddListener(new UnityAction<BuildableItem>(delegate(BuildableItem <p0>)
			{
				base.InvokeChanged();
			}));
			this.Destination.onObjectChanged.AddListener(new UnityAction<BuildableItem>(this.DestinationChanged));
			this.Destination.DrawTransitLine = true;
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x0008EA80 File Offset: 0x0008CC80
		public override void Destroy()
		{
			base.Destroy();
			if (this.AssignedBotanist.SelectedNPC != null)
			{
				((this.AssignedBotanist.SelectedNPC as Botanist).Configuration as BotanistConfiguration).AssignedStations.RemoveItem(this.Pot);
			}
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.Destroy();
				this.DestinationRoute = null;
			}
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x0008EAEC File Offset: 0x0008CCEC
		private void DestinationChanged(BuildableItem item)
		{
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.Destroy();
				this.DestinationRoute = null;
			}
			if (this.Destination.SelectedObject != null)
			{
				this.DestinationRoute = new TransitRoute(this.Pot, this.Destination.SelectedObject as ITransitEntity);
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

		// Token: 0x0600229B RID: 8859 RVA: 0x0008EB63 File Offset: 0x0008CD63
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			reason = "";
			return obj is ITransitEntity && (obj as ITransitEntity).Selectable && obj != this.Pot;
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x0008EB92 File Offset: 0x0008CD92
		public override void Selected()
		{
			base.Selected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(true);
			}
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x0008EBAE File Offset: 0x0008CDAE
		public override void Deselected()
		{
			base.Deselected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(false);
			}
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x0008EBCC File Offset: 0x0008CDCC
		public override bool ShouldSave()
		{
			return this.Seed.SelectedItem != null || this.Additive1.SelectedItem != null || this.Additive2.SelectedItem != null || this.Additive3.SelectedItem != null || this.AssignedBotanist.SelectedNPC != null || this.Destination.SelectedObject != null || base.ShouldSave();
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x0008EC60 File Offset: 0x0008CE60
		public override string GetSaveString()
		{
			return new PotConfigurationData(this.Seed.GetData(), this.Additive1.GetData(), this.Additive2.GetData(), this.Additive3.GetData(), this.Destination.GetData()).GetJson(true);
		}

		// Token: 0x04001A13 RID: 6675
		public ItemField Seed;

		// Token: 0x04001A14 RID: 6676
		public ItemField Additive1;

		// Token: 0x04001A15 RID: 6677
		public ItemField Additive2;

		// Token: 0x04001A16 RID: 6678
		public ItemField Additive3;

		// Token: 0x04001A17 RID: 6679
		public NPCField AssignedBotanist;

		// Token: 0x04001A18 RID: 6680
		public ObjectField Destination;
	}
}
