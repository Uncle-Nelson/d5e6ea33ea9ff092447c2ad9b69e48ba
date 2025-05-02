using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.NPCs;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.StationFramework;
using ScheduleOne.UI.Management;
using ScheduleOne.UI.Stations;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000568 RID: 1384
	public class ChemistryStationConfiguration : EntityConfiguration
	{
		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x0008D30F File Offset: 0x0008B50F
		// (set) Token: 0x06002221 RID: 8737 RVA: 0x0008D317 File Offset: 0x0008B517
		public ChemistryStation Station { get; protected set; }

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x0008D320 File Offset: 0x0008B520
		// (set) Token: 0x06002223 RID: 8739 RVA: 0x0008D328 File Offset: 0x0008B528
		public TransitRoute DestinationRoute { get; protected set; }

		// Token: 0x06002224 RID: 8740 RVA: 0x0008D334 File Offset: 0x0008B534
		public ChemistryStationConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, ChemistryStation station) : base(replicator, configurable)
		{
			this.Station = station;
			this.AssignedChemist = new NPCField(this);
			this.AssignedChemist.onNPCChanged.AddListener(new UnityAction<NPC>(delegate(NPC <p0>)
			{
				base.InvokeChanged();
			}));
			this.Recipe = new StationRecipeField(this);
			this.Recipe.Options = Singleton<ChemistryStationCanvas>.Instance.Recipes;
			this.Recipe.onRecipeChanged.AddListener(new UnityAction<StationRecipe>(delegate(StationRecipe <p0>)
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

		// Token: 0x06002225 RID: 8741 RVA: 0x0008D41C File Offset: 0x0008B61C
		public override void Destroy()
		{
			base.Destroy();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.Destroy();
				this.DestinationRoute = null;
			}
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x0008D440 File Offset: 0x0008B640
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

		// Token: 0x06002227 RID: 8743 RVA: 0x0008D4B7 File Offset: 0x0008B6B7
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			reason = "";
			return obj is ITransitEntity && (obj as ITransitEntity).Selectable && obj != this.Station;
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x0008D4E6 File Offset: 0x0008B6E6
		public override void Selected()
		{
			base.Selected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(true);
			}
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x0008D502 File Offset: 0x0008B702
		public override void Deselected()
		{
			base.Deselected();
			if (this.DestinationRoute != null)
			{
				this.DestinationRoute.SetVisualsActive(false);
			}
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x0008D51E File Offset: 0x0008B71E
		public override bool ShouldSave()
		{
			return this.Destination.SelectedObject != null || base.ShouldSave();
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x0008D53B File Offset: 0x0008B73B
		public override string GetSaveString()
		{
			return new ChemistryStationConfigurationData(this.Recipe.GetData(), this.Destination.GetData()).GetJson(true);
		}

		// Token: 0x040019EB RID: 6635
		public NPCField AssignedChemist;

		// Token: 0x040019EC RID: 6636
		public StationRecipeField Recipe;

		// Token: 0x040019ED RID: 6637
		public ObjectField Destination;
	}
}
