using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Packaging;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Management;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x0200056E RID: 1390
	public class PackagerConfiguration : EntityConfiguration
	{
		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x0008DFFE File Offset: 0x0008C1FE
		public int AssignedStationCount
		{
			get
			{
				return this.AssignedStations.Count + this.AssignedBrickPresses.Count;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x0008E017 File Offset: 0x0008C217
		// (set) Token: 0x0600227A RID: 8826 RVA: 0x0008E01F File Offset: 0x0008C21F
		public Packager packager { get; protected set; }

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x0008E028 File Offset: 0x0008C228
		// (set) Token: 0x0600227C RID: 8828 RVA: 0x0008E030 File Offset: 0x0008C230
		public BedItem bedItem { get; private set; }

		// Token: 0x0600227D RID: 8829 RVA: 0x0008E03C File Offset: 0x0008C23C
		public PackagerConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Packager _botanist) : base(replicator, configurable)
		{
			this.packager = _botanist;
			this.Bed = new ObjectField(this);
			this.Bed.TypeRequirements = new List<Type>
			{
				typeof(BedItem)
			};
			this.Bed.onObjectChanged.AddListener(new UnityAction<BuildableItem>(this.BedChanged));
			this.Bed.objectFilter = new ObjectSelector.ObjectFilter(BedItem.IsBedValid);
			this.Stations = new ObjectListField(this);
			this.Stations.MaxItems = this.packager.MaxAssignedStations;
			this.Stations.TypeRequirements = new List<Type>
			{
				typeof(PackagingStation),
				typeof(PackagingStationMk2),
				typeof(BrickPress)
			};
			this.Stations.onListChanged.AddListener(new UnityAction<List<BuildableItem>>(delegate(List<BuildableItem> <p0>)
			{
				base.InvokeChanged();
			}));
			this.Stations.onListChanged.AddListener(new UnityAction<List<BuildableItem>>(this.AssignedStationsChanged));
			this.Stations.objectFilter = new ObjectSelector.ObjectFilter(this.IsStationValid);
			this.Routes = new RouteListField(this);
			this.Routes.MaxRoutes = 5;
			this.Routes.onListChanged.AddListener(new UnityAction<List<AdvancedTransitRoute>>(delegate(List<AdvancedTransitRoute> <p0>)
			{
				base.InvokeChanged();
			}));
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x0008E1B4 File Offset: 0x0008C3B4
		public override void Destroy()
		{
			base.Destroy();
			this.Bed.SetObject(null, false);
			foreach (PackagingStation packagingStation in this.AssignedStations)
			{
				(packagingStation.Configuration as PackagingStationConfiguration).AssignedPackager.SetNPC(null, false);
			}
			foreach (BrickPress brickPress in this.AssignedBrickPresses)
			{
				(brickPress.Configuration as BrickPressConfiguration).AssignedPackager.SetNPC(null, false);
			}
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x0008E278 File Offset: 0x0008C478
		private bool IsStationValid(BuildableItem obj, out string reason)
		{
			reason = string.Empty;
			if (obj is PackagingStation)
			{
				PackagingStationConfiguration packagingStationConfiguration = (obj as PackagingStation).Configuration as PackagingStationConfiguration;
				if (packagingStationConfiguration.AssignedPackager.SelectedNPC != null && packagingStationConfiguration.AssignedPackager.SelectedNPC != this.packager)
				{
					reason = "Already assigned to " + packagingStationConfiguration.AssignedPackager.SelectedNPC.fullName;
					return false;
				}
				return true;
			}
			else
			{
				if (!(obj is BrickPress))
				{
					return false;
				}
				BrickPressConfiguration brickPressConfiguration = (obj as BrickPress).Configuration as BrickPressConfiguration;
				if (brickPressConfiguration.AssignedPackager.SelectedNPC != null && brickPressConfiguration.AssignedPackager.SelectedNPC != this.packager)
				{
					reason = "Already assigned to " + brickPressConfiguration.AssignedPackager.SelectedNPC.fullName;
					return false;
				}
				return true;
			}
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x0008E358 File Offset: 0x0008C558
		public void AssignedStationsChanged(List<BuildableItem> objects)
		{
			for (int i = 0; i < this.AssignedStations.Count; i++)
			{
				if (!objects.Contains(this.AssignedStations[i]))
				{
					PackagingStation packagingStation = this.AssignedStations[i];
					this.AssignedStations.RemoveAt(i);
					i--;
					if ((packagingStation.Configuration as PackagingStationConfiguration).AssignedPackager.SelectedNPC == this.packager)
					{
						(packagingStation.Configuration as PackagingStationConfiguration).AssignedPackager.SetNPC(null, false);
					}
				}
			}
			for (int j = 0; j < this.AssignedBrickPresses.Count; j++)
			{
				if (!objects.Contains(this.AssignedBrickPresses[j]))
				{
					BrickPress brickPress = this.AssignedBrickPresses[j];
					this.AssignedBrickPresses.RemoveAt(j);
					j--;
					if ((brickPress.Configuration as BrickPressConfiguration).AssignedPackager.SelectedNPC == this.packager)
					{
						(brickPress.Configuration as BrickPressConfiguration).AssignedPackager.SetNPC(null, false);
					}
				}
			}
			for (int k = 0; k < objects.Count; k++)
			{
				if (objects[k] is PackagingStation)
				{
					if (!this.AssignedStations.Contains(objects[k]))
					{
						PackagingStation packagingStation2 = objects[k] as PackagingStation;
						this.AssignedStations.Add(packagingStation2);
						if ((packagingStation2.Configuration as PackagingStationConfiguration).AssignedPackager.SelectedNPC != this.packager)
						{
							(packagingStation2.Configuration as PackagingStationConfiguration).AssignedPackager.SetNPC(this.packager, false);
						}
					}
				}
				else if (objects[k] is BrickPress && !this.AssignedBrickPresses.Contains(objects[k]))
				{
					BrickPress brickPress2 = objects[k] as BrickPress;
					this.AssignedBrickPresses.Add(brickPress2);
					if ((brickPress2.Configuration as BrickPressConfiguration).AssignedPackager.SelectedNPC != this.packager)
					{
						(brickPress2.Configuration as BrickPressConfiguration).AssignedPackager.SetNPC(this.packager, false);
					}
				}
			}
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x0008E58B File Offset: 0x0008C78B
		public override bool ShouldSave()
		{
			return this.Bed.SelectedObject != null || this.AssignedStations.Count > 0 || base.ShouldSave();
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x0008E5B8 File Offset: 0x0008C7B8
		public override string GetSaveString()
		{
			return new PackagerConfigurationData(this.Bed.GetData(), this.Stations.GetData(), this.Routes.GetData()).GetJson(true);
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x0008E5E8 File Offset: 0x0008C7E8
		private void BedChanged(BuildableItem newItem)
		{
			BedItem bedItem = this.bedItem;
			if (bedItem != null)
			{
				bedItem.Bed.SetAssignedEmployee(null);
			}
			this.bedItem = ((newItem != null) ? (newItem as BedItem) : null);
			if (this.bedItem != null)
			{
				this.bedItem.Bed.SetAssignedEmployee(this.packager);
			}
			base.InvokeChanged();
		}

		// Token: 0x04001A07 RID: 6663
		public ObjectField Bed;

		// Token: 0x04001A08 RID: 6664
		public ObjectListField Stations;

		// Token: 0x04001A09 RID: 6665
		public RouteListField Routes;

		// Token: 0x04001A0A RID: 6666
		public List<PackagingStation> AssignedStations = new List<PackagingStation>();

		// Token: 0x04001A0B RID: 6667
		public List<BrickPress> AssignedBrickPresses = new List<BrickPress>();
	}
}
