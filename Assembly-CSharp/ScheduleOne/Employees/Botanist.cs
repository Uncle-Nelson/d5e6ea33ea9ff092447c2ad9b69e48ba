using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.EntityFramework;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Employees
{
	// Token: 0x0200063E RID: 1598
	public class Botanist : Employee, IConfigurable
	{
		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06002A69 RID: 10857 RVA: 0x000AED69 File Offset: 0x000ACF69
		public EntityConfiguration Configuration
		{
			get
			{
				return this.configuration;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06002A6A RID: 10858 RVA: 0x000AED71 File Offset: 0x000ACF71
		// (set) Token: 0x06002A6B RID: 10859 RVA: 0x000AED79 File Offset: 0x000ACF79
		protected BotanistConfiguration configuration { get; set; }

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06002A6C RID: 10860 RVA: 0x000AED82 File Offset: 0x000ACF82
		public ConfigurationReplicator ConfigReplicator
		{
			get
			{
				return this.configReplicator;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06002A6D RID: 10861 RVA: 0x000523A3 File Offset: 0x000505A3
		public EConfigurableType ConfigurableType
		{
			get
			{
				return EConfigurableType.Botanist;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x000AED8A File Offset: 0x000ACF8A
		// (set) Token: 0x06002A6F RID: 10863 RVA: 0x000AED92 File Offset: 0x000ACF92
		public WorldspaceUIElement WorldspaceUI { get; set; }

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x000AED9B File Offset: 0x000ACF9B
		// (set) Token: 0x06002A71 RID: 10865 RVA: 0x000AEDA3 File Offset: 0x000ACFA3
		public NetworkObject CurrentPlayerConfigurer
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<CurrentPlayerConfigurer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.sync___set_value_<CurrentPlayerConfigurer>k__BackingField(value, true);
			}
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x000AEDAD File Offset: 0x000ACFAD
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
			this.RpcWriter___Server_SetConfigurer_3323014238(player);
			this.RpcLogic___SetConfigurer_3323014238(player);
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06002A73 RID: 10867 RVA: 0x000AEDC3 File Offset: 0x000ACFC3
		public Sprite TypeIcon
		{
			get
			{
				return this.typeIcon;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x000AEDCB File Offset: 0x000ACFCB
		public Transform Transform
		{
			get
			{
				return base.transform;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06002A75 RID: 10869 RVA: 0x000AEDD3 File Offset: 0x000ACFD3
		public Transform UIPoint
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool CanBeSelected
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06002A77 RID: 10871 RVA: 0x000AEDDB File Offset: 0x000ACFDB
		public Property ParentProperty
		{
			get
			{
				return base.AssignedProperty;
			}
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x000AEDE3 File Offset: 0x000ACFE3
		protected override void Start()
		{
			base.Start();
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x000AEDEC File Offset: 0x000ACFEC
		protected override void UpdateBehaviour()
		{
			base.UpdateBehaviour();
			if (this.PotActionBehaviour.Active)
			{
				base.MarkIsWorking();
				return;
			}
			if (this.MoveItemBehaviour.Active)
			{
				base.MarkIsWorking();
				return;
			}
			if (base.Fired)
			{
				base.LeavePropertyAndDespawn();
				return;
			}
			if (!base.CanWork())
			{
				return;
			}
			if (this.configuration.AssignedPots.Count + this.configuration.AssignedRacks.Count == 0)
			{
				base.SubmitNoWorkReason("I haven't been assigned any pots or drying racks", "You can use your management clipboards to assign pots/drying racks to me.", 0);
				this.SetIdle(true);
				return;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			Pot potForWatering = this.GetPotForWatering(this.CRITICAL_WATERING_THRESHOLD, true);
			if (potForWatering != null && NavMeshUtility.GetAccessPoint(potForWatering, this) != null)
			{
				this.StartAction(potForWatering, PotActionBehaviour.EActionType.Water);
				return;
			}
			Pot potForSoilSour = this.GetPotForSoilSour();
			if (potForSoilSour != null)
			{
				if (this.PotActionBehaviour.DoesBotanistHaveMaterialsForTask(this, potForSoilSour, PotActionBehaviour.EActionType.PourSoil, -1))
				{
					this.StartAction(potForSoilSour, PotActionBehaviour.EActionType.PourSoil);
					return;
				}
				string fix = "Make sure there's soil in my supplies stash.";
				if (this.configuration.Supplies.SelectedObject == null)
				{
					fix = "Use your management clipboards to assign a supplies stash to me. Then make sure there's soil in it.";
				}
				base.SubmitNoWorkReason("There are empty pots, but I don't have any soil to pour.", fix, 0);
			}
			foreach (Pot pot in this.GetPotsReadyForSeed())
			{
				if (NavMeshUtility.GetAccessPoint(pot, this))
				{
					if (this.PotActionBehaviour.DoesBotanistHaveMaterialsForTask(this, pot, PotActionBehaviour.EActionType.SowSeed, -1))
					{
						this.StartAction(pot, PotActionBehaviour.EActionType.SowSeed);
						return;
					}
					string fix2 = "Make sure I have the right seeds in my supplies stash.";
					if (this.configuration.Supplies.SelectedObject == null)
					{
						fix2 = "Use your management clipboards to assign a supplies stash to me, and make sure it contains the right seeds.";
					}
					base.SubmitNoWorkReason("There is a pot ready for sowing, but I don't have any seeds for it.", fix2, 1);
				}
			}
			int additiveNumber;
			Pot potForAdditives = this.GetPotForAdditives(out additiveNumber);
			if (potForAdditives != null && this.PotActionBehaviour.DoesBotanistHaveMaterialsForTask(this, potForAdditives, PotActionBehaviour.EActionType.ApplyAdditive, additiveNumber))
			{
				this.PotActionBehaviour.AdditiveNumber = additiveNumber;
				this.StartAction(potForAdditives, PotActionBehaviour.EActionType.ApplyAdditive);
				return;
			}
			foreach (Pot pot2 in this.GetPotsForHarvest())
			{
				if (this.IsEntityAccessible(pot2))
				{
					if (this.PotActionBehaviour.DoesPotHaveValidDestination(pot2))
					{
						this.StartAction(pot2, PotActionBehaviour.EActionType.Harvest);
						return;
					}
					base.SubmitNoWorkReason("There is a plant ready for harvest, but it has no destination or it's destination is full.", "Use your management clipboard to assign a destination for each of my pots, and make sure the destination isn't full.", 0);
				}
			}
			foreach (DryingRack dryingRack in this.GetRacksToStop())
			{
				if (this.IsEntityAccessible(dryingRack))
				{
					this.StopDryingRack(dryingRack);
					return;
				}
			}
			foreach (DryingRack dryingRack2 in this.GetRacksToStart())
			{
				if (this.IsEntityAccessible(dryingRack2))
				{
					this.StartDryingRack(dryingRack2);
					return;
				}
			}
			foreach (DryingRack dryingRack3 in this.GetRacksReadyToMove())
			{
				if (this.IsEntityAccessible(dryingRack3))
				{
					this.MoveItemBehaviour.Initialize((dryingRack3.Configuration as DryingRackConfiguration).DestinationRoute, dryingRack3.OutputSlot.ItemInstance, -1, false);
					this.MoveItemBehaviour.Enable_Networked(null);
					return;
				}
			}
			Pot potForWatering2 = this.GetPotForWatering(this.WATERING_THRESHOLD, false);
			if (potForWatering2 != null)
			{
				this.StartAction(potForWatering2, PotActionBehaviour.EActionType.Water);
				return;
			}
			QualityItemInstance qualityItemInstance;
			DryingRack destination;
			int maxMoveAmount;
			if (this.CanMoveDryableToRack(out qualityItemInstance, out destination, out maxMoveAmount))
			{
				TransitRoute route = new TransitRoute(this.configuration.Supplies.SelectedObject as ITransitEntity, destination);
				this.MoveItemBehaviour.Initialize(route, qualityItemInstance, maxMoveAmount, false);
				this.MoveItemBehaviour.Enable_Networked(null);
				Console.Log(string.Concat(new string[]
				{
					"Moving ",
					maxMoveAmount.ToString(),
					" ",
					qualityItemInstance.ID,
					" to drying rack"
				}), null);
				return;
			}
			base.SubmitNoWorkReason("There's nothing for me to do right now.", string.Empty, 0);
			this.SetIdle(true);
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x000AF250 File Offset: 0x000AD450
		private bool IsEntityAccessible(ITransitEntity entity)
		{
			return NavMeshUtility.GetAccessPoint(entity, this) != null;
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x000AF25F File Offset: 0x000AD45F
		private void StartAction(Pot pot, PotActionBehaviour.EActionType actionType)
		{
			this.SetIdle(false);
			this.PotActionBehaviour.Initialize(pot, actionType);
			this.PotActionBehaviour.Enable_Networked(null);
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x000AF281 File Offset: 0x000AD481
		private void StartDryingRack(DryingRack rack)
		{
			this.StartDryingRackBehaviour.AssignRack(rack);
			this.StartDryingRackBehaviour.Enable_Networked(null);
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x000AF29B File Offset: 0x000AD49B
		private void StopDryingRack(DryingRack rack)
		{
			this.StopDryingRackBehaviour.AssignRack(rack);
			this.StopDryingRackBehaviour.Enable_Networked(null);
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x000AF2B5 File Offset: 0x000AD4B5
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			this.SendConfigurationToClient(connection);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x000AF2C8 File Offset: 0x000AD4C8
		public void SendConfigurationToClient(NetworkConnection conn)
		{
			Botanist.<>c__DisplayClass58_0 CS$<>8__locals1 = new Botanist.<>c__DisplayClass58_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.conn = conn;
			if (CS$<>8__locals1.conn.IsHost)
			{
				return;
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SendConfigurationToClient>g__WaitForConfig|0());
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x000AF308 File Offset: 0x000AD508
		protected override void AssignProperty(Property prop)
		{
			base.AssignProperty(prop);
			prop.AddConfigurable(this);
			this.configuration = new BotanistConfiguration(this.configReplicator, this, this);
			this.CreateWorldspaceUI();
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x000AF332 File Offset: 0x000AD532
		protected override void Fire()
		{
			if (this.configuration != null)
			{
				this.configuration.Destroy();
				this.DestroyWorldspaceUI();
				if (base.AssignedProperty != null)
				{
					base.AssignedProperty.RemoveConfigurable(this);
				}
			}
			base.Fire();
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x000AF370 File Offset: 0x000AD570
		private bool CanMoveDryableToRack(out QualityItemInstance dryable, out DryingRack destinationRack, out int moveQuantity)
		{
			moveQuantity = 0;
			destinationRack = null;
			dryable = this.GetDryableInSupplies();
			if (dryable == null)
			{
				return false;
			}
			Console.Log("Found dryable in supplies: " + dryable.ID, null);
			int b = 0;
			destinationRack = this.GetAssignedDryingRackFor(dryable, out b);
			if (destinationRack == null)
			{
				return false;
			}
			Console.Log("Found rack with capacity: " + b.ToString(), null);
			moveQuantity = Mathf.Min(dryable.Quantity, b);
			return true;
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x000AF3EC File Offset: 0x000AD5EC
		public QualityItemInstance GetDryableInSupplies()
		{
			if (this.configuration.Supplies.SelectedObject == null)
			{
				return null;
			}
			if (!this.PotActionBehaviour.CanGetToSupplies())
			{
				return null;
			}
			List<ItemSlot> list = new List<ItemSlot>();
			BuildableItem selectedObject = this.configuration.Supplies.SelectedObject;
			if (selectedObject != null)
			{
				list.AddRange((selectedObject as ITransitEntity).OutputSlots);
			}
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].Quantity > 0 && ItemFilter_Dryable.IsItemDryable(list[i].ItemInstance))
				{
					return list[i].ItemInstance as QualityItemInstance;
				}
			}
			return null;
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x000AF49C File Offset: 0x000AD69C
		private DryingRack GetAssignedDryingRackFor(QualityItemInstance dryable, out int rackInputCapacity)
		{
			rackInputCapacity = 0;
			foreach (DryingRack dryingRack in this.configuration.AssignedRacks)
			{
				if ((dryingRack.Configuration as DryingRackConfiguration).TargetQuality.Value > dryable.Quality)
				{
					int inputCapacityForItem = ((ITransitEntity)dryingRack).GetInputCapacityForItem(dryable, this);
					if (inputCapacityForItem > 0)
					{
						rackInputCapacity = inputCapacityForItem;
						return dryingRack;
					}
				}
			}
			return null;
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x000AF524 File Offset: 0x000AD724
		public ItemInstance GetItemInSupplies(string id)
		{
			if (this.configuration.Supplies.SelectedObject == null)
			{
				return null;
			}
			if (!this.PotActionBehaviour.CanGetToSupplies())
			{
				return null;
			}
			List<ItemSlot> list = new List<ItemSlot>();
			BuildableItem selectedObject = this.configuration.Supplies.SelectedObject;
			if (selectedObject != null)
			{
				list.AddRange((selectedObject as ITransitEntity).OutputSlots);
			}
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].Quantity > 0 && list[i].ItemInstance.ID.ToLower() == id.ToLower())
				{
					return list[i].ItemInstance;
				}
			}
			return null;
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x000AF5DC File Offset: 0x000AD7DC
		public ItemInstance GetSeedInSupplies()
		{
			if (this.configuration.Supplies.SelectedObject == null)
			{
				return null;
			}
			if (!this.PotActionBehaviour.CanGetToSupplies())
			{
				return null;
			}
			List<ItemSlot> list = new List<ItemSlot>();
			BuildableItem selectedObject = this.configuration.Supplies.SelectedObject;
			if (selectedObject != null)
			{
				list.AddRange((selectedObject as ITransitEntity).OutputSlots);
			}
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].Quantity > 0 && list[i].ItemInstance.Definition is SeedDefinition)
				{
					return list[i].ItemInstance;
				}
			}
			return null;
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x000AF689 File Offset: 0x000AD889
		protected override bool ShouldIdle()
		{
			return this.configuration.AssignedStations.SelectedObjects.Count == 0 || base.ShouldIdle();
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x000AF6AA File Offset: 0x000AD8AA
		public override BedItem GetBed()
		{
			return this.configuration.bedItem;
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x000AF6B8 File Offset: 0x000AD8B8
		private bool AreThereUnspecifiedPots()
		{
			for (int i = 0; i < this.configuration.AssignedPots.Count; i++)
			{
				if ((this.configuration.AssignedPots[i].Configuration as PotConfiguration).Seed.SelectedItem == null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x000AF710 File Offset: 0x000AD910
		private bool AreThereNullDestinationPots()
		{
			foreach (Pot pot in this.configuration.AssignedPots)
			{
				string text;
				if (pot.IsReadyForHarvest(out text) && (pot.Configuration as PotConfiguration).Destination.SelectedObject == null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x000AF790 File Offset: 0x000AD990
		private bool IsMissingRequiredMaterials()
		{
			Pot potForSoilSour = this.GetPotForSoilSour();
			if (potForSoilSour != null && !this.PotActionBehaviour.DoesBotanistHaveMaterialsForTask(this, potForSoilSour, PotActionBehaviour.EActionType.PourSoil, -1))
			{
				return false;
			}
			List<Pot> potsReadyForSeed = this.GetPotsReadyForSeed();
			for (int i = 0; i < potsReadyForSeed.Count; i++)
			{
				if (this.PotActionBehaviour.DoesBotanistHaveMaterialsForTask(this, potsReadyForSeed[i], PotActionBehaviour.EActionType.SowSeed, -1))
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x000AF7F4 File Offset: 0x000AD9F4
		private Pot GetPotForWatering(float threshold, bool excludeFullyGrowm)
		{
			for (int i = 0; i < this.configuration.AssignedPots.Count; i++)
			{
				if (this.PotActionBehaviour.CanPotBeWatered(this.configuration.AssignedPots[i], threshold) && (!excludeFullyGrowm || this.configuration.AssignedPots[i].Plant == null || !this.configuration.AssignedPots[i].Plant.IsFullyGrown) && this.IsEntityAccessible(this.configuration.AssignedPots[i]))
				{
					return this.configuration.AssignedPots[i];
				}
			}
			return null;
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x000AF8AC File Offset: 0x000ADAAC
		private Pot GetPotForSoilSour()
		{
			for (int i = 0; i < this.configuration.AssignedPots.Count; i++)
			{
				if (this.PotActionBehaviour.CanPotHaveSoilPour(this.configuration.AssignedPots[i]) && this.IsEntityAccessible(this.configuration.AssignedPots[i]))
				{
					return this.configuration.AssignedPots[i];
				}
			}
			return null;
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x000AF920 File Offset: 0x000ADB20
		private List<Pot> GetPotsReadyForSeed()
		{
			List<Pot> list = new List<Pot>();
			for (int i = 0; i < this.configuration.AssignedPots.Count; i++)
			{
				if (this.PotActionBehaviour.CanPotHaveSeedSown(this.configuration.AssignedPots[i]))
				{
					list.Add(this.configuration.AssignedPots[i]);
				}
			}
			return list;
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x000AF984 File Offset: 0x000ADB84
		private T GetAccessableEntity<T>(T entity) where T : ITransitEntity
		{
			if (!(NavMeshUtility.GetAccessPoint(entity, this) != null))
			{
				return default(T);
			}
			return entity;
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x000AF9B0 File Offset: 0x000ADBB0
		private List<T> GetAccessableEntities<T>(List<T> list) where T : ITransitEntity
		{
			return (from item in list
			where NavMeshUtility.GetAccessPoint(item, this) != null
			select item).ToList<T>();
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x000AF9CC File Offset: 0x000ADBCC
		private List<Pot> FilterPotsForSpecifiedSeed(List<Pot> pots)
		{
			List<Pot> list = new List<Pot>();
			foreach (Pot pot in pots)
			{
				if ((pot.Configuration as PotConfiguration).Seed.SelectedItem != null)
				{
					list.Add(pot);
				}
			}
			return list;
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x000AFA40 File Offset: 0x000ADC40
		private Pot GetPotForAdditives(out int additiveNumber)
		{
			additiveNumber = -1;
			for (int i = 0; i < this.configuration.AssignedPots.Count; i++)
			{
				if (this.PotActionBehaviour.CanPotHaveAdditiveApplied(this.configuration.AssignedPots[i], out additiveNumber) && this.IsEntityAccessible(this.configuration.AssignedPots[i]))
				{
					return this.configuration.AssignedPots[i];
				}
			}
			return null;
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x000AFAB8 File Offset: 0x000ADCB8
		private List<Pot> GetPotsForHarvest()
		{
			List<Pot> list = new List<Pot>();
			for (int i = 0; i < this.configuration.AssignedPots.Count; i++)
			{
				if (this.PotActionBehaviour.CanPotBeHarvested(this.configuration.AssignedPots[i]))
				{
					list.Add(this.configuration.AssignedPots[i]);
				}
			}
			return list;
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x000AFB1C File Offset: 0x000ADD1C
		private List<DryingRack> GetRacksToStart()
		{
			List<DryingRack> list = new List<DryingRack>();
			for (int i = 0; i < this.configuration.AssignedRacks.Count; i++)
			{
				if (this.StartDryingRackBehaviour.IsRackReady(this.configuration.AssignedRacks[i]))
				{
					list.Add(this.configuration.AssignedRacks[i]);
				}
			}
			return list;
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x000AFB80 File Offset: 0x000ADD80
		private List<DryingRack> GetRacksToStop()
		{
			List<DryingRack> list = new List<DryingRack>();
			for (int i = 0; i < this.configuration.AssignedRacks.Count; i++)
			{
				if (this.StopDryingRackBehaviour.IsRackReady(this.configuration.AssignedRacks[i]))
				{
					list.Add(this.configuration.AssignedRacks[i]);
				}
			}
			return list;
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x000AFBE4 File Offset: 0x000ADDE4
		private List<DryingRack> GetRacksReadyToMove()
		{
			List<DryingRack> list = new List<DryingRack>();
			for (int i = 0; i < this.configuration.AssignedRacks.Count; i++)
			{
				ItemSlot outputSlot = this.configuration.AssignedRacks[i].OutputSlot;
				if (outputSlot.Quantity != 0 && this.MoveItemBehaviour.IsTransitRouteValid((this.configuration.AssignedRacks[i].Configuration as DryingRackConfiguration).DestinationRoute, outputSlot.ItemInstance.ID))
				{
					list.Add(this.configuration.AssignedRacks[i]);
				}
			}
			return list;
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x000AFC84 File Offset: 0x000ADE84
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				Console.LogWarning(base.gameObject.name + " already has a worldspace UI element!", null);
			}
			Property assignedProperty = base.AssignedProperty;
			if (assignedProperty == null)
			{
				Property property = assignedProperty;
				Console.LogError(((property != null) ? property.ToString() : null) + " is not a child of a property!", null);
				return null;
			}
			BotanistUIElement component = Object.Instantiate<BotanistUIElement>(this.WorldspaceUIPrefab, assignedProperty.WorldspaceUIContainer).GetComponent<BotanistUIElement>();
			component.Initialize(this);
			this.WorldspaceUI = component;
			return component;
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x000AFD0F File Offset: 0x000ADF0F
		public void DestroyWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				this.WorldspaceUI.Destroy();
			}
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x000AFD2C File Offset: 0x000ADF2C
		public override string GetSaveString()
		{
			return new BotanistData(this.ID, base.AssignedProperty.PropertyCode, this.FirstName, this.LastName, base.IsMale, base.AppearanceIndex, base.transform.position, base.transform.rotation, base.GUID, base.PaidForToday, this.MoveItemBehaviour.GetSaveData()).GetJson(true);
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x000AFD9C File Offset: 0x000ADF9C
		public override List<string> WriteData(string parentFolderPath)
		{
			List<string> list = new List<string>();
			if (this.Configuration.ShouldSave())
			{
				list.Add("Configuration.json");
				((ISaveable)this).WriteSubfile(parentFolderPath, "Configuration", this.Configuration.GetSaveString());
			}
			list.AddRange(base.WriteData(parentFolderPath));
			return list;
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x000AFE84 File Offset: 0x000AE084
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField = new SyncVar<NetworkObject>(this, 2U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.<CurrentPlayerConfigurer>k__BackingField);
			base.RegisterServerRpc(40U, new ServerRpcDelegate(this.RpcReader___Server_SetConfigurer_3323014238));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Employees.Botanist));
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x000AFEFC File Offset: 0x000AE0FC
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField.SetRegistered();
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x000AFF20 File Offset: 0x000AE120
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x000AFF30 File Offset: 0x000AE130
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteNetworkObject(player);
			base.SendServerRpc(40U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x000AFFD7 File Offset: 0x000AE1D7
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			this.CurrentPlayerConfigurer = player;
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x000AFFE0 File Offset: 0x000AE1E0
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject player = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetConfigurer_3323014238(player);
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06002AA3 RID: 10915 RVA: 0x000B001E File Offset: 0x000AE21E
		// (set) Token: 0x06002AA4 RID: 10916 RVA: 0x000B0026 File Offset: 0x000AE226
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			get
			{
				return this.<CurrentPlayerConfigurer>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<CurrentPlayerConfigurer>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<CurrentPlayerConfigurer>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x000B0064 File Offset: 0x000AE264
		public virtual bool Botanist(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 != 2U)
			{
				return false;
			}
			if (PooledReader0 == null)
			{
				this.sync___set_value_<CurrentPlayerConfigurer>k__BackingField(this.syncVar___<CurrentPlayerConfigurer>k__BackingField.GetValue(true), true);
				return true;
			}
			NetworkObject value = PooledReader0.ReadNetworkObject();
			this.sync___set_value_<CurrentPlayerConfigurer>k__BackingField(value, Boolean2);
			return true;
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x000B00B6 File Offset: 0x000AE2B6
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001EE7 RID: 7911
		public float CRITICAL_WATERING_THRESHOLD = 0.1f;

		// Token: 0x04001EE8 RID: 7912
		public float WATERING_THRESHOLD = 0.3f;

		// Token: 0x04001EE9 RID: 7913
		public float TARGET_WATER_LEVEL_MIN = 0.75f;

		// Token: 0x04001EEA RID: 7914
		public float TARGET_WATER_LEVEL_MAX = 1f;

		// Token: 0x04001EEB RID: 7915
		public float SOIL_POUR_TIME = 10f;

		// Token: 0x04001EEC RID: 7916
		public float WATER_POUR_TIME = 10f;

		// Token: 0x04001EED RID: 7917
		public float ADDITIVE_POUR_TIME = 10f;

		// Token: 0x04001EEE RID: 7918
		public float SEED_SOW_TIME = 15f;

		// Token: 0x04001EEF RID: 7919
		public float HARVEST_TIME = 15f;

		// Token: 0x04001EF0 RID: 7920
		[Header("References")]
		public Sprite typeIcon;

		// Token: 0x04001EF1 RID: 7921
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x04001EF2 RID: 7922
		public PotActionBehaviour PotActionBehaviour;

		// Token: 0x04001EF3 RID: 7923
		public StartDryingRackBehaviour StartDryingRackBehaviour;

		// Token: 0x04001EF4 RID: 7924
		public StopDryingRackBehaviour StopDryingRackBehaviour;

		// Token: 0x04001EF5 RID: 7925
		[Header("UI")]
		public BotanistUIElement WorldspaceUIPrefab;

		// Token: 0x04001EF6 RID: 7926
		public Transform uiPoint;

		// Token: 0x04001EF7 RID: 7927
		[Header("Settings")]
		public int MaxAssignedPots = 8;

		// Token: 0x04001EF8 RID: 7928
		public DialogueContainer NoAssignedStationsDialogue;

		// Token: 0x04001EF9 RID: 7929
		public DialogueContainer UnspecifiedPotsDialogue;

		// Token: 0x04001EFA RID: 7930
		public DialogueContainer NullDestinationPotsDialogue;

		// Token: 0x04001EFB RID: 7931
		public DialogueContainer MissingMaterialsDialogue;

		// Token: 0x04001EFC RID: 7932
		public DialogueContainer NoPotsRequireWorkDialogue;

		// Token: 0x04001F00 RID: 7936
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04001F01 RID: 7937
		private bool dll_Excuted;

		// Token: 0x04001F02 RID: 7938
		private bool dll_Excuted;
	}
}
