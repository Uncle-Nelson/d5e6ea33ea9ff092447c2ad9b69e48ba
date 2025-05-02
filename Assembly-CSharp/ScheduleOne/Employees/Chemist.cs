using System;
using System.Collections.Generic;
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
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.StationFramework;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Employees
{
	// Token: 0x02000641 RID: 1601
	public class Chemist : Employee, IConfigurable
	{
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002AB0 RID: 10928 RVA: 0x000B016A File Offset: 0x000AE36A
		public EntityConfiguration Configuration
		{
			get
			{
				return this.configuration;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x000B0172 File Offset: 0x000AE372
		// (set) Token: 0x06002AB2 RID: 10930 RVA: 0x000B017A File Offset: 0x000AE37A
		protected ChemistConfiguration configuration { get; set; }

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x000B0183 File Offset: 0x000AE383
		public ConfigurationReplicator ConfigReplicator
		{
			get
			{
				return this.configReplicator;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06002AB4 RID: 10932 RVA: 0x000B018B File Offset: 0x000AE38B
		public EConfigurableType ConfigurableType
		{
			get
			{
				return EConfigurableType.Chemist;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06002AB5 RID: 10933 RVA: 0x000B018E File Offset: 0x000AE38E
		// (set) Token: 0x06002AB6 RID: 10934 RVA: 0x000B0196 File Offset: 0x000AE396
		public WorldspaceUIElement WorldspaceUI { get; set; }

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x000B019F File Offset: 0x000AE39F
		// (set) Token: 0x06002AB8 RID: 10936 RVA: 0x000B01A7 File Offset: 0x000AE3A7
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

		// Token: 0x06002AB9 RID: 10937 RVA: 0x000B01B1 File Offset: 0x000AE3B1
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
			this.RpcWriter___Server_SetConfigurer_3323014238(player);
			this.RpcLogic___SetConfigurer_3323014238(player);
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002ABA RID: 10938 RVA: 0x000B01C7 File Offset: 0x000AE3C7
		public Sprite TypeIcon
		{
			get
			{
				return this.typeIcon;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06002ABB RID: 10939 RVA: 0x000AEDCB File Offset: 0x000ACFCB
		public Transform Transform
		{
			get
			{
				return base.transform;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002ABC RID: 10940 RVA: 0x000B01CF File Offset: 0x000AE3CF
		public Transform UIPoint
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool CanBeSelected
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002ABE RID: 10942 RVA: 0x000AEDDB File Offset: 0x000ACFDB
		public Property ParentProperty
		{
			get
			{
				return base.AssignedProperty;
			}
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x000B01D7 File Offset: 0x000AE3D7
		protected override void AssignProperty(Property prop)
		{
			base.AssignProperty(prop);
			prop.AddConfigurable(this);
			this.configuration = new ChemistConfiguration(this.configReplicator, this, this);
			this.CreateWorldspaceUI();
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x000B0201 File Offset: 0x000AE401
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

		// Token: 0x06002AC1 RID: 10945 RVA: 0x000B023C File Offset: 0x000AE43C
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			this.SendConfigurationToClient(connection);
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x000B024C File Offset: 0x000AE44C
		public void SendConfigurationToClient(NetworkConnection conn)
		{
			Chemist.<>c__DisplayClass42_0 CS$<>8__locals1 = new Chemist.<>c__DisplayClass42_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.conn = conn;
			if (CS$<>8__locals1.conn.IsHost)
			{
				return;
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SendConfigurationToClient>g__WaitForConfig|0());
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x000B028C File Offset: 0x000AE48C
		protected override void UpdateBehaviour()
		{
			base.UpdateBehaviour();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.AnyWorkInProgress())
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
			if (this.configuration.TotalStations == 0)
			{
				base.SubmitNoWorkReason("I haven't been assigned any stations", "You can use your management clipboards to assign stations to me.", 0);
				this.SetIdle(true);
				return;
			}
			if (InstanceFinder.IsServer)
			{
				this.TryStartNewTask();
			}
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x000B0304 File Offset: 0x000AE504
		private void TryStartNewTask()
		{
			List<LabOven> labOvensReadyToFinish = this.GetLabOvensReadyToFinish();
			if (labOvensReadyToFinish.Count > 0)
			{
				this.FinishLabOven(labOvensReadyToFinish[0]);
				return;
			}
			List<LabOven> labOvensReadyToStart = this.GetLabOvensReadyToStart();
			if (labOvensReadyToStart.Count > 0)
			{
				this.StartLabOven(labOvensReadyToStart[0]);
				return;
			}
			List<ChemistryStation> chemistryStationsReadyToStart = this.GetChemistryStationsReadyToStart();
			if (chemistryStationsReadyToStart.Count > 0)
			{
				this.StartChemistryStation(chemistryStationsReadyToStart[0]);
				return;
			}
			List<Cauldron> cauldronsReadyToStart = this.GetCauldronsReadyToStart();
			if (cauldronsReadyToStart.Count > 0)
			{
				this.StartCauldron(cauldronsReadyToStart[0]);
				return;
			}
			List<MixingStation> mixingStationsReadyToStart = this.GetMixingStationsReadyToStart();
			if (mixingStationsReadyToStart.Count > 0)
			{
				this.StartMixingStation(mixingStationsReadyToStart[0]);
				return;
			}
			List<LabOven> labOvensReadyToMove = this.GetLabOvensReadyToMove();
			if (labOvensReadyToMove.Count > 0)
			{
				this.MoveItemBehaviour.Initialize((labOvensReadyToMove[0].Configuration as LabOvenConfiguration).DestinationRoute, labOvensReadyToMove[0].OutputSlot.ItemInstance, -1, false);
				this.MoveItemBehaviour.Enable_Networked(null);
				return;
			}
			List<ChemistryStation> chemStationsReadyToMove = this.GetChemStationsReadyToMove();
			if (chemStationsReadyToMove.Count > 0)
			{
				this.MoveItemBehaviour.Initialize((chemStationsReadyToMove[0].Configuration as ChemistryStationConfiguration).DestinationRoute, chemStationsReadyToMove[0].OutputSlot.ItemInstance, -1, false);
				this.MoveItemBehaviour.Enable_Networked(null);
				return;
			}
			List<Cauldron> cauldronsReadyToMove = this.GetCauldronsReadyToMove();
			if (cauldronsReadyToMove.Count > 0)
			{
				this.MoveItemBehaviour.Initialize((cauldronsReadyToMove[0].Configuration as CauldronConfiguration).DestinationRoute, cauldronsReadyToMove[0].OutputSlot.ItemInstance, -1, false);
				this.MoveItemBehaviour.Enable_Networked(null);
				return;
			}
			List<MixingStation> mixStationsReadyToMove = this.GetMixStationsReadyToMove();
			if (mixStationsReadyToMove.Count > 0)
			{
				this.MoveItemBehaviour.Initialize((mixStationsReadyToMove[0].Configuration as MixingStationConfiguration).DestinationRoute, mixStationsReadyToMove[0].OutputSlot.ItemInstance, -1, false);
				this.MoveItemBehaviour.Enable_Networked(null);
				return;
			}
			base.SubmitNoWorkReason("There's nothing for me to do right now.", string.Empty, 0);
			this.SetIdle(true);
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x000B0518 File Offset: 0x000AE718
		private bool AnyWorkInProgress()
		{
			return this.StartChemistryStationBehaviour.Active || this.StartLabOvenBehaviour.Active || this.FinishLabOvenBehaviour.Active || this.MoveItemBehaviour.Active || this.StartMixingStationBehaviour.Active;
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x000B0571 File Offset: 0x000AE771
		protected override bool ShouldIdle()
		{
			return this.configuration.Stations.SelectedObjects.Count == 0 || base.ShouldIdle();
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x000B0592 File Offset: 0x000AE792
		private void StartChemistryStation(ChemistryStation station)
		{
			this.StartChemistryStationBehaviour.SetTargetStation(station);
			this.StartChemistryStationBehaviour.Enable_Networked(null);
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x000B05AC File Offset: 0x000AE7AC
		private void StartCauldron(Cauldron cauldron)
		{
			this.StartCauldronBehaviour.AssignStation(cauldron);
			this.StartCauldronBehaviour.Enable_Networked(null);
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x000B05C6 File Offset: 0x000AE7C6
		private void StartLabOven(LabOven oven)
		{
			this.StartLabOvenBehaviour.SetTargetOven(oven);
			this.StartLabOvenBehaviour.Enable_Networked(null);
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x000B05E0 File Offset: 0x000AE7E0
		private void FinishLabOven(LabOven oven)
		{
			this.FinishLabOvenBehaviour.SetTargetOven(oven);
			this.FinishLabOvenBehaviour.Enable_Networked(null);
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x000B05FA File Offset: 0x000AE7FA
		private void StartMixingStation(MixingStation station)
		{
			this.StartMixingStationBehaviour.AssignStation(station);
			this.StartMixingStationBehaviour.Enable_Networked(null);
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x000B0614 File Offset: 0x000AE814
		public override BedItem GetBed()
		{
			return this.configuration.bedItem;
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x000B0624 File Offset: 0x000AE824
		public List<LabOven> GetLabOvensReadyToFinish()
		{
			List<LabOven> list = new List<LabOven>();
			foreach (LabOven labOven in this.configuration.LabOvens)
			{
				if (!((IUsable)labOven).IsInUse && labOven.CurrentOperation != null && labOven.IsReadyForHarvest() && labOven.CanOutputSpaceFitCurrentOperation())
				{
					list.Add(labOven);
				}
			}
			return list;
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x000B06A4 File Offset: 0x000AE8A4
		public List<LabOven> GetLabOvensReadyToStart()
		{
			List<LabOven> list = new List<LabOven>();
			foreach (LabOven labOven in this.configuration.LabOvens)
			{
				if (!((IUsable)labOven).IsInUse && labOven.CurrentOperation == null && labOven.IsReadyToStart())
				{
					list.Add(labOven);
				}
			}
			return list;
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x000B071C File Offset: 0x000AE91C
		public List<ChemistryStation> GetChemistryStationsReadyToStart()
		{
			List<ChemistryStation> list = new List<ChemistryStation>();
			foreach (ChemistryStation chemistryStation in this.configuration.ChemStations)
			{
				if (!((IUsable)chemistryStation).IsInUse && chemistryStation.CurrentCookOperation == null)
				{
					StationRecipe selectedRecipe = (chemistryStation.Configuration as ChemistryStationConfiguration).Recipe.SelectedRecipe;
					if (!(selectedRecipe == null) && chemistryStation.HasIngredientsForRecipe(selectedRecipe))
					{
						list.Add(chemistryStation);
					}
				}
			}
			return list;
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x000B07B4 File Offset: 0x000AE9B4
		public List<Cauldron> GetCauldronsReadyToStart()
		{
			List<Cauldron> list = new List<Cauldron>();
			foreach (Cauldron cauldron in this.configuration.Cauldrons)
			{
				if (!((IUsable)cauldron).IsInUse && cauldron.RemainingCookTime <= 0 && cauldron.GetState() == Cauldron.EState.Ready)
				{
					list.Add(cauldron);
				}
			}
			return list;
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x000B0830 File Offset: 0x000AEA30
		public List<MixingStation> GetMixingStationsReadyToStart()
		{
			List<MixingStation> list = new List<MixingStation>();
			foreach (MixingStation mixingStation in this.configuration.MixStations)
			{
				if (!((IUsable)mixingStation).IsInUse && mixingStation.CanStartMix() && mixingStation.CurrentMixOperation == null && (float)mixingStation.GetMixQuantity() >= (mixingStation.Configuration as MixingStationConfiguration).StartThrehold.Value)
				{
					list.Add(mixingStation);
				}
			}
			return list;
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x000B08C8 File Offset: 0x000AEAC8
		protected List<LabOven> GetLabOvensReadyToMove()
		{
			List<LabOven> list = new List<LabOven>();
			foreach (LabOven labOven in this.configuration.LabOvens)
			{
				ItemSlot outputSlot = labOven.OutputSlot;
				if (outputSlot.Quantity != 0 && this.MoveItemBehaviour.IsTransitRouteValid((labOven.Configuration as LabOvenConfiguration).DestinationRoute, outputSlot.ItemInstance.ID))
				{
					list.Add(labOven);
				}
			}
			return list;
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x000B0960 File Offset: 0x000AEB60
		protected List<ChemistryStation> GetChemStationsReadyToMove()
		{
			List<ChemistryStation> list = new List<ChemistryStation>();
			foreach (ChemistryStation chemistryStation in this.configuration.ChemStations)
			{
				ItemSlot outputSlot = chemistryStation.OutputSlot;
				if (outputSlot.Quantity != 0 && this.MoveItemBehaviour.IsTransitRouteValid((chemistryStation.Configuration as ChemistryStationConfiguration).DestinationRoute, outputSlot.ItemInstance.ID))
				{
					list.Add(chemistryStation);
				}
			}
			return list;
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x000B09F8 File Offset: 0x000AEBF8
		protected List<Cauldron> GetCauldronsReadyToMove()
		{
			List<Cauldron> list = new List<Cauldron>();
			foreach (Cauldron cauldron in this.configuration.Cauldrons)
			{
				ItemSlot outputSlot = cauldron.OutputSlot;
				if (outputSlot.Quantity != 0 && this.MoveItemBehaviour.IsTransitRouteValid((cauldron.Configuration as CauldronConfiguration).DestinationRoute, outputSlot.ItemInstance.ID))
				{
					list.Add(cauldron);
				}
			}
			return list;
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x000B0A90 File Offset: 0x000AEC90
		protected List<MixingStation> GetMixStationsReadyToMove()
		{
			List<MixingStation> list = new List<MixingStation>();
			foreach (MixingStation mixingStation in this.configuration.MixStations)
			{
				ItemSlot outputSlot = mixingStation.OutputSlot;
				if (outputSlot.Quantity != 0 && this.MoveItemBehaviour.IsTransitRouteValid((mixingStation.Configuration as MixingStationConfiguration).DestinationRoute, outputSlot.ItemInstance.ID))
				{
					list.Add(mixingStation);
				}
			}
			return list;
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x000B0B28 File Offset: 0x000AED28
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
			ChemistUIElement component = Object.Instantiate<ChemistUIElement>(this.WorldspaceUIPrefab, assignedProperty.WorldspaceUIContainer).GetComponent<ChemistUIElement>();
			component.Initialize(this);
			this.WorldspaceUI = component;
			return component;
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x000B0BB3 File Offset: 0x000AEDB3
		public void DestroyWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				this.WorldspaceUI.Destroy();
			}
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x000B0BD0 File Offset: 0x000AEDD0
		public override string GetSaveString()
		{
			return new ChemistData(this.ID, base.AssignedProperty.PropertyCode, this.FirstName, this.LastName, base.IsMale, base.AppearanceIndex, base.transform.position, base.transform.rotation, base.GUID, base.PaidForToday, this.MoveItemBehaviour.GetSaveData()).GetJson(true);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000B0C40 File Offset: 0x000AEE40
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

		// Token: 0x06002ADB RID: 10971 RVA: 0x000B0C9C File Offset: 0x000AEE9C
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField = new SyncVar<NetworkObject>(this, 2U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.<CurrentPlayerConfigurer>k__BackingField);
			base.RegisterServerRpc(40U, new ServerRpcDelegate(this.RpcReader___Server_SetConfigurer_3323014238));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Employees.Chemist));
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x000B0D14 File Offset: 0x000AEF14
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField.SetRegistered();
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000B0D38 File Offset: 0x000AEF38
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x000B0D48 File Offset: 0x000AEF48
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

		// Token: 0x06002ADF RID: 10975 RVA: 0x000B0DEF File Offset: 0x000AEFEF
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			this.CurrentPlayerConfigurer = player;
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000B0DF8 File Offset: 0x000AEFF8
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

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x000B0E36 File Offset: 0x000AF036
		// (set) Token: 0x06002AE2 RID: 10978 RVA: 0x000B0E3E File Offset: 0x000AF03E
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

		// Token: 0x06002AE3 RID: 10979 RVA: 0x000B0E7C File Offset: 0x000AF07C
		public virtual bool Chemist(PooledReader PooledReader0, uint UInt321, bool Boolean2)
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

		// Token: 0x06002AE4 RID: 10980 RVA: 0x000B0ECE File Offset: 0x000AF0CE
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001F08 RID: 7944
		public const int MAX_ASSIGNED_STATIONS = 4;

		// Token: 0x04001F09 RID: 7945
		[Header("References")]
		public Sprite typeIcon;

		// Token: 0x04001F0A RID: 7946
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x04001F0B RID: 7947
		[Header("Behaviours")]
		public StartChemistryStationBehaviour StartChemistryStationBehaviour;

		// Token: 0x04001F0C RID: 7948
		public StartLabOvenBehaviour StartLabOvenBehaviour;

		// Token: 0x04001F0D RID: 7949
		public FinishLabOvenBehaviour FinishLabOvenBehaviour;

		// Token: 0x04001F0E RID: 7950
		public StartCauldronBehaviour StartCauldronBehaviour;

		// Token: 0x04001F0F RID: 7951
		public StartMixingStationBehaviour StartMixingStationBehaviour;

		// Token: 0x04001F10 RID: 7952
		[Header("UI")]
		public ChemistUIElement WorldspaceUIPrefab;

		// Token: 0x04001F11 RID: 7953
		public Transform uiPoint;

		// Token: 0x04001F15 RID: 7957
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04001F16 RID: 7958
		private bool dll_Excuted;

		// Token: 0x04001F17 RID: 7959
		private bool dll_Excuted;
	}
}
