using System;
using System.Collections.Generic;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Management;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000567 RID: 1383
	public class ChemistConfiguration : EntityConfiguration
	{
		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06002213 RID: 8723 RVA: 0x0008C8FB File Offset: 0x0008AAFB
		public int TotalStations
		{
			get
			{
				return this.ChemStations.Count + this.LabOvens.Count + this.Cauldrons.Count + this.MixStations.Count;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x0008C92C File Offset: 0x0008AB2C
		// (set) Token: 0x06002215 RID: 8725 RVA: 0x0008C934 File Offset: 0x0008AB34
		public Chemist chemist { get; protected set; }

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x0008C93D File Offset: 0x0008AB3D
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x0008C945 File Offset: 0x0008AB45
		public BedItem bedItem { get; private set; }

		// Token: 0x06002218 RID: 8728 RVA: 0x0008C950 File Offset: 0x0008AB50
		public ChemistConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Chemist _chemist) : base(replicator, configurable)
		{
			this.chemist = _chemist;
			this.Bed = new ObjectField(this);
			this.Bed.TypeRequirements = new List<Type>
			{
				typeof(BedItem)
			};
			this.Bed.onObjectChanged.AddListener(new UnityAction<BuildableItem>(this.BedChanged));
			this.Bed.objectFilter = new ObjectSelector.ObjectFilter(BedItem.IsBedValid);
			this.Stations = new ObjectListField(this);
			this.Stations.MaxItems = 4;
			this.Stations.TypeRequirements = new List<Type>
			{
				typeof(ChemistryStation),
				typeof(LabOven),
				typeof(Cauldron),
				typeof(MixingStation),
				typeof(MixingStationMk2)
			};
			this.Stations.onListChanged.AddListener(new UnityAction<List<BuildableItem>>(delegate(List<BuildableItem> <p0>)
			{
				base.InvokeChanged();
			}));
			this.Stations.onListChanged.AddListener(new UnityAction<List<BuildableItem>>(this.AssignedStationsChanged));
			this.Stations.objectFilter = new ObjectSelector.ObjectFilter(this.IsStationValid);
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x0008CAC0 File Offset: 0x0008ACC0
		public override void Destroy()
		{
			base.Destroy();
			this.Bed.SetObject(null, false);
			foreach (ChemistryStation chemistryStation in this.ChemStations)
			{
				(chemistryStation.Configuration as ChemistryStationConfiguration).AssignedChemist.SetNPC(null, false);
			}
			foreach (LabOven labOven in this.LabOvens)
			{
				(labOven.Configuration as LabOvenConfiguration).AssignedChemist.SetNPC(null, false);
			}
			foreach (Cauldron cauldron in this.Cauldrons)
			{
				(cauldron.Configuration as CauldronConfiguration).AssignedChemist.SetNPC(null, false);
			}
			foreach (MixingStation mixingStation in this.MixStations)
			{
				(mixingStation.Configuration as MixingStationConfiguration).AssignedChemist.SetNPC(null, false);
			}
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x0008CC24 File Offset: 0x0008AE24
		private bool IsStationValid(BuildableItem obj, out string reason)
		{
			reason = string.Empty;
			if (obj is ChemistryStation)
			{
				ChemistryStationConfiguration chemistryStationConfiguration = (obj as ChemistryStation).Configuration as ChemistryStationConfiguration;
				if (chemistryStationConfiguration.AssignedChemist.SelectedNPC != null && chemistryStationConfiguration.AssignedChemist.SelectedNPC != this.chemist)
				{
					reason = "Already assigned to " + chemistryStationConfiguration.AssignedChemist.SelectedNPC.fullName;
					return false;
				}
				return true;
			}
			else if (obj is LabOven)
			{
				LabOvenConfiguration labOvenConfiguration = (obj as LabOven).Configuration as LabOvenConfiguration;
				if (labOvenConfiguration.AssignedChemist.SelectedNPC != null && labOvenConfiguration.AssignedChemist.SelectedNPC != this.chemist)
				{
					reason = "Already assigned to " + labOvenConfiguration.AssignedChemist.SelectedNPC.fullName;
					return false;
				}
				return true;
			}
			else if (obj is Cauldron)
			{
				CauldronConfiguration cauldronConfiguration = (obj as Cauldron).Configuration as CauldronConfiguration;
				if (cauldronConfiguration.AssignedChemist.SelectedNPC != null && cauldronConfiguration.AssignedChemist.SelectedNPC != this.chemist)
				{
					reason = "Already assigned to " + cauldronConfiguration.AssignedChemist.SelectedNPC.fullName;
					return false;
				}
				return true;
			}
			else
			{
				if (!(obj is MixingStation))
				{
					return false;
				}
				MixingStationConfiguration mixingStationConfiguration = (obj as MixingStation).Configuration as MixingStationConfiguration;
				if (mixingStationConfiguration.AssignedChemist.SelectedNPC != null && mixingStationConfiguration.AssignedChemist.SelectedNPC != this.chemist)
				{
					reason = "Already assigned to " + mixingStationConfiguration.AssignedChemist.SelectedNPC.fullName;
					return false;
				}
				return true;
			}
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x0008CDCC File Offset: 0x0008AFCC
		public void AssignedStationsChanged(List<BuildableItem> objects)
		{
			for (int i = 0; i < this.ChemStations.Count; i++)
			{
				if (!objects.Contains(this.ChemStations[i]))
				{
					ChemistryStation chemistryStation = this.ChemStations[i];
					this.ChemStations.RemoveAt(i);
					i--;
					if ((chemistryStation.Configuration as ChemistryStationConfiguration).AssignedChemist.SelectedNPC == this.chemist)
					{
						(chemistryStation.Configuration as ChemistryStationConfiguration).AssignedChemist.SetNPC(null, false);
					}
				}
			}
			for (int j = 0; j < this.LabOvens.Count; j++)
			{
				if (!objects.Contains(this.LabOvens[j]))
				{
					LabOven labOven = this.LabOvens[j];
					this.LabOvens.RemoveAt(j);
					j--;
					if ((labOven.Configuration as LabOvenConfiguration).AssignedChemist.SelectedNPC == this.chemist)
					{
						(labOven.Configuration as LabOvenConfiguration).AssignedChemist.SetNPC(null, false);
					}
				}
			}
			for (int k = 0; k < this.Cauldrons.Count; k++)
			{
				if (!objects.Contains(this.Cauldrons[k]))
				{
					Cauldron cauldron = this.Cauldrons[k];
					this.Cauldrons.RemoveAt(k);
					k--;
					if ((cauldron.Configuration as CauldronConfiguration).AssignedChemist.SelectedNPC == this.chemist)
					{
						(cauldron.Configuration as CauldronConfiguration).AssignedChemist.SetNPC(null, false);
					}
				}
			}
			for (int l = 0; l < this.MixStations.Count; l++)
			{
				if (!objects.Contains(this.MixStations[l]))
				{
					MixingStation mixingStation = this.MixStations[l];
					this.MixStations.RemoveAt(l);
					l--;
					if ((mixingStation.Configuration as MixingStationConfiguration).AssignedChemist.SelectedNPC == this.chemist)
					{
						(mixingStation.Configuration as MixingStationConfiguration).AssignedChemist.SetNPC(null, false);
					}
				}
			}
			for (int m = 0; m < objects.Count; m++)
			{
				if (objects[m] is ChemistryStation && !this.ChemStations.Contains(objects[m] as ChemistryStation))
				{
					ChemistryStation chemistryStation2 = objects[m] as ChemistryStation;
					this.ChemStations.Add(chemistryStation2);
					if ((chemistryStation2.Configuration as ChemistryStationConfiguration).AssignedChemist.SelectedNPC != this.chemist)
					{
						(chemistryStation2.Configuration as ChemistryStationConfiguration).AssignedChemist.SetNPC(this.chemist, false);
					}
				}
				if (objects[m] is LabOven && !this.LabOvens.Contains(objects[m] as LabOven))
				{
					LabOven labOven2 = objects[m] as LabOven;
					this.LabOvens.Add(labOven2);
					if ((labOven2.Configuration as LabOvenConfiguration).AssignedChemist.SelectedNPC != this.chemist)
					{
						(labOven2.Configuration as LabOvenConfiguration).AssignedChemist.SetNPC(this.chemist, false);
					}
				}
				if (objects[m] is Cauldron && !this.Cauldrons.Contains(objects[m] as Cauldron))
				{
					Cauldron cauldron2 = objects[m] as Cauldron;
					this.Cauldrons.Add(cauldron2);
					if ((cauldron2.Configuration as CauldronConfiguration).AssignedChemist.SelectedNPC != this.chemist)
					{
						(cauldron2.Configuration as CauldronConfiguration).AssignedChemist.SetNPC(this.chemist, false);
					}
				}
				if (objects[m] is MixingStation && !this.MixStations.Contains(objects[m] as MixingStation))
				{
					MixingStation mixingStation2 = objects[m] as MixingStation;
					this.MixStations.Add(mixingStation2);
					if ((mixingStation2.Configuration as MixingStationConfiguration).AssignedChemist.SelectedNPC != this.chemist)
					{
						(mixingStation2.Configuration as MixingStationConfiguration).AssignedChemist.SetNPC(this.chemist, false);
					}
				}
			}
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x0008D228 File Offset: 0x0008B428
		public override bool ShouldSave()
		{
			return this.Bed.SelectedObject != null || this.ChemStations.Count > 0 || this.LabOvens.Count > 0 || this.Cauldrons.Count > 0 || base.ShouldSave();
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x0008D280 File Offset: 0x0008B480
		public override string GetSaveString()
		{
			return new ChemistConfigurationData(this.Bed.GetData(), this.Stations.GetData()).GetJson(true);
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x0008D2A4 File Offset: 0x0008B4A4
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
				this.bedItem.Bed.SetAssignedEmployee(this.chemist);
			}
			base.InvokeChanged();
		}

		// Token: 0x040019E2 RID: 6626
		public ObjectField Bed;

		// Token: 0x040019E3 RID: 6627
		public ObjectListField Stations;

		// Token: 0x040019E4 RID: 6628
		public List<ChemistryStation> ChemStations = new List<ChemistryStation>();

		// Token: 0x040019E5 RID: 6629
		public List<LabOven> LabOvens = new List<LabOven>();

		// Token: 0x040019E6 RID: 6630
		public List<Cauldron> Cauldrons = new List<Cauldron>();

		// Token: 0x040019E7 RID: 6631
		public List<MixingStation> MixStations = new List<MixingStation>();
	}
}
