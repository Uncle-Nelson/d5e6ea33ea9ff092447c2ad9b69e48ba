using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Management;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000564 RID: 1380
	public class BotanistConfiguration : EntityConfiguration
	{
		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060021EA RID: 8682 RVA: 0x0008BECF File Offset: 0x0008A0CF
		// (set) Token: 0x060021EB RID: 8683 RVA: 0x0008BED7 File Offset: 0x0008A0D7
		public Botanist botanist { get; protected set; }

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x0008BEE0 File Offset: 0x0008A0E0
		// (set) Token: 0x060021ED RID: 8685 RVA: 0x0008BEE8 File Offset: 0x0008A0E8
		public BedItem bedItem { get; private set; }

		// Token: 0x060021EE RID: 8686 RVA: 0x0008BEF4 File Offset: 0x0008A0F4
		public BotanistConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Botanist _botanist) : base(replicator, configurable)
		{
			this.botanist = _botanist;
			this.Bed = new ObjectField(this);
			this.Bed.TypeRequirements = new List<Type>
			{
				typeof(BedItem)
			};
			this.Bed.onObjectChanged.AddListener(new UnityAction<BuildableItem>(this.BedChanged));
			this.Bed.objectFilter = new ObjectSelector.ObjectFilter(BedItem.IsBedValid);
			this.Supplies = new ObjectField(this);
			this.Supplies.TypeRequirements = new List<Type>
			{
				typeof(PlaceableStorageEntity)
			};
			this.Supplies.onObjectChanged.AddListener(new UnityAction<BuildableItem>(delegate(BuildableItem <p0>)
			{
				base.InvokeChanged();
			}));
			this.AssignedStations = new ObjectListField(this);
			this.AssignedStations.MaxItems = this.botanist.MaxAssignedPots;
			this.AssignedStations.TypeRequirements = new List<Type>
			{
				typeof(Pot),
				typeof(DryingRack)
			};
			this.AssignedStations.onListChanged.AddListener(new UnityAction<List<BuildableItem>>(delegate(List<BuildableItem> <p0>)
			{
				base.InvokeChanged();
			}));
			this.AssignedStations.onListChanged.AddListener(new UnityAction<List<BuildableItem>>(this.AssignedPotsChanged));
			this.AssignedStations.objectFilter = new ObjectSelector.ObjectFilter(this.IsStationValid);
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x0008C070 File Offset: 0x0008A270
		public override void Destroy()
		{
			base.Destroy();
			this.Bed.SetObject(null, false);
			foreach (Pot pot in this.AssignedPots)
			{
				(pot.Configuration as PotConfiguration).AssignedBotanist.SetNPC(null, false);
			}
			foreach (DryingRack dryingRack in this.AssignedRacks)
			{
				(dryingRack.Configuration as DryingRackConfiguration).AssignedBotanist.SetNPC(null, false);
			}
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x0008C134 File Offset: 0x0008A334
		private bool IsStationValid(BuildableItem obj, out string reason)
		{
			reason = string.Empty;
			Pot pot = obj as Pot;
			DryingRack dryingRack = obj as DryingRack;
			if (pot != null)
			{
				PotConfiguration potConfiguration = pot.Configuration as PotConfiguration;
				if (potConfiguration.AssignedBotanist.SelectedNPC != null && potConfiguration.AssignedBotanist.SelectedNPC != this.botanist)
				{
					reason = "Already assigned to " + potConfiguration.AssignedBotanist.SelectedNPC.fullName;
					return false;
				}
				return true;
			}
			else
			{
				if (!(dryingRack != null))
				{
					reason = "Not a pot or drying rack";
					return false;
				}
				DryingRackConfiguration dryingRackConfiguration = dryingRack.Configuration as DryingRackConfiguration;
				if (dryingRackConfiguration.AssignedBotanist.SelectedNPC != null && dryingRackConfiguration.AssignedBotanist.SelectedNPC != this.botanist)
				{
					reason = "Already assigned to " + dryingRackConfiguration.AssignedBotanist.SelectedNPC.fullName;
					return false;
				}
				return true;
			}
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x0008C220 File Offset: 0x0008A420
		public void AssignedPotsChanged(List<BuildableItem> objects)
		{
			for (int i = 0; i < this.AssignedPots.Count; i++)
			{
				if (!objects.Contains(this.AssignedPots[i]))
				{
					Pot pot = this.AssignedPots[i];
					this.AssignedPots.RemoveAt(i);
					i--;
					if ((pot.Configuration as PotConfiguration).AssignedBotanist.SelectedNPC == this.botanist)
					{
						(pot.Configuration as PotConfiguration).AssignedBotanist.SetNPC(null, false);
					}
				}
			}
			for (int j = 0; j < objects.Count; j++)
			{
				if (objects[j] is Pot)
				{
					if (!this.AssignedPots.Contains(objects[j]))
					{
						Pot pot2 = objects[j] as Pot;
						this.AssignedPots.Add(pot2);
						if ((pot2.Configuration as PotConfiguration).AssignedBotanist.SelectedNPC != this.botanist)
						{
							(pot2.Configuration as PotConfiguration).AssignedBotanist.SetNPC(this.botanist, false);
						}
					}
				}
				else if (objects[j] is DryingRack && !this.AssignedRacks.Contains(objects[j]))
				{
					DryingRack dryingRack = objects[j] as DryingRack;
					this.AssignedRacks.Add(dryingRack);
					if ((dryingRack.Configuration as DryingRackConfiguration).AssignedBotanist.SelectedNPC != this.botanist)
					{
						(dryingRack.Configuration as DryingRackConfiguration).AssignedBotanist.SetNPC(this.botanist, false);
					}
				}
			}
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x0008C3C4 File Offset: 0x0008A5C4
		public override bool ShouldSave()
		{
			return this.AssignedPots.Count > 0 || this.AssignedRacks.Count > 0 || this.Supplies.SelectedObject != null || this.Bed.SelectedObject != null || base.ShouldSave();
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x0008C421 File Offset: 0x0008A621
		public override string GetSaveString()
		{
			return new BotanistConfigurationData(this.Bed.GetData(), this.Supplies.GetData(), this.AssignedStations.GetData()).GetJson(true);
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0008C450 File Offset: 0x0008A650
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
				this.bedItem.Bed.SetAssignedEmployee(this.botanist);
			}
			base.InvokeChanged();
		}

		// Token: 0x040019D3 RID: 6611
		public ObjectField Bed;

		// Token: 0x040019D4 RID: 6612
		public ObjectField Supplies;

		// Token: 0x040019D5 RID: 6613
		public ObjectListField AssignedStations;

		// Token: 0x040019D6 RID: 6614
		public List<Pot> AssignedPots = new List<Pot>();

		// Token: 0x040019D7 RID: 6615
		public List<DryingRack> AssignedRacks = new List<DryingRack>();
	}
}
