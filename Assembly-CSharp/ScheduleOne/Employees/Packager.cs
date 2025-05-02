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
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Employees
{
	// Token: 0x0200064E RID: 1614
	public class Packager : Employee, IConfigurable
	{
		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06002B89 RID: 11145 RVA: 0x000B33EC File Offset: 0x000B15EC
		public EntityConfiguration Configuration
		{
			get
			{
				return this.configuration;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x000B33F4 File Offset: 0x000B15F4
		// (set) Token: 0x06002B8B RID: 11147 RVA: 0x000B33FC File Offset: 0x000B15FC
		protected PackagerConfiguration configuration { get; set; }

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06002B8C RID: 11148 RVA: 0x000B3405 File Offset: 0x000B1605
		public ConfigurationReplicator ConfigReplicator
		{
			get
			{
				return this.configReplicator;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06002B8D RID: 11149 RVA: 0x000B340D File Offset: 0x000B160D
		public EConfigurableType ConfigurableType
		{
			get
			{
				return EConfigurableType.Packager;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002B8E RID: 11150 RVA: 0x000B3410 File Offset: 0x000B1610
		// (set) Token: 0x06002B8F RID: 11151 RVA: 0x000B3418 File Offset: 0x000B1618
		public WorldspaceUIElement WorldspaceUI { get; set; }

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x000B3421 File Offset: 0x000B1621
		// (set) Token: 0x06002B91 RID: 11153 RVA: 0x000B3429 File Offset: 0x000B1629
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

		// Token: 0x06002B92 RID: 11154 RVA: 0x000B3433 File Offset: 0x000B1633
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
			this.RpcWriter___Server_SetConfigurer_3323014238(player);
			this.RpcLogic___SetConfigurer_3323014238(player);
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06002B93 RID: 11155 RVA: 0x000B3449 File Offset: 0x000B1649
		public Sprite TypeIcon
		{
			get
			{
				return this.typeIcon;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002B94 RID: 11156 RVA: 0x000AEDCB File Offset: 0x000ACFCB
		public Transform Transform
		{
			get
			{
				return base.transform;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002B95 RID: 11157 RVA: 0x000B3451 File Offset: 0x000B1651
		public Transform UIPoint
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002B96 RID: 11158 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool CanBeSelected
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002B97 RID: 11159 RVA: 0x000AEDDB File Offset: 0x000ACFDB
		public Property ParentProperty
		{
			get
			{
				return base.AssignedProperty;
			}
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x000B3459 File Offset: 0x000B1659
		protected override void AssignProperty(Property prop)
		{
			base.AssignProperty(prop);
			prop.AddConfigurable(this);
			this.configuration = new PackagerConfiguration(this.configReplicator, this, this);
			this.CreateWorldspaceUI();
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x000B3483 File Offset: 0x000B1683
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

		// Token: 0x06002B9A RID: 11162 RVA: 0x000B34BE File Offset: 0x000B16BE
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			this.SendConfigurationToClient(connection);
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x000B34D0 File Offset: 0x000B16D0
		public void SendConfigurationToClient(NetworkConnection conn)
		{
			Packager.<>c__DisplayClass40_0 CS$<>8__locals1 = new Packager.<>c__DisplayClass40_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.conn = conn;
			if (CS$<>8__locals1.conn.IsHost)
			{
				return;
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SendConfigurationToClient>g__WaitForConfig|0());
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x000B3510 File Offset: 0x000B1710
		protected override void UpdateBehaviour()
		{
			base.UpdateBehaviour();
			if (this.PackagingBehaviour.Active)
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
			if (this.configuration.AssignedStationCount + this.configuration.Routes.Routes.Count == 0)
			{
				base.SubmitNoWorkReason("I haven't been assigned to any stations or routes.", "You can use your management clipboards to assign stations or routes to me.", 0);
				this.SetIdle(true);
				return;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			PackagingStation stationToAttend = this.GetStationToAttend();
			if (stationToAttend != null)
			{
				this.StartPackaging(stationToAttend);
				return;
			}
			BrickPress brickPress = this.GetBrickPress();
			if (brickPress != null)
			{
				this.StartPress(brickPress);
				return;
			}
			PackagingStation stationMoveItems = this.GetStationMoveItems();
			if (stationMoveItems != null)
			{
				this.StartMoveItem(stationMoveItems);
				return;
			}
			BrickPress brickPressMoveItems = this.GetBrickPressMoveItems();
			if (brickPressMoveItems != null)
			{
				this.StartMoveItem(brickPressMoveItems);
				return;
			}
			ItemInstance itemInstance;
			AdvancedTransitRoute transitRouteReady = this.GetTransitRouteReady(out itemInstance);
			if (transitRouteReady != null)
			{
				this.MoveItemBehaviour.Initialize(transitRouteReady, itemInstance, itemInstance.Quantity, false);
				this.MoveItemBehaviour.Enable_Networked(null);
				return;
			}
			base.SubmitNoWorkReason("There's nothing for me to do right now.", "I need one of my assigned stations to have enough product and packaging to get to work.", 0);
			this.SetIdle(true);
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x000B3651 File Offset: 0x000B1851
		private void StartPackaging(PackagingStation station)
		{
			Console.Log("Starting packaging at " + station.gameObject.name, null);
			this.PackagingBehaviour.AssignStation(station);
			this.PackagingBehaviour.Enable_Networked(null);
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x000B3686 File Offset: 0x000B1886
		private void StartPress(BrickPress press)
		{
			this.BrickPressBehaviour.AssignStation(press);
			this.BrickPressBehaviour.Enable_Networked(null);
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x000B36A0 File Offset: 0x000B18A0
		private void StartMoveItem(PackagingStation station)
		{
			Console.Log("Starting moving items from " + station.gameObject.name, null);
			this.MoveItemBehaviour.Initialize((station.Configuration as PackagingStationConfiguration).DestinationRoute, station.OutputSlot.ItemInstance, -1, false);
			this.MoveItemBehaviour.Enable_Networked(null);
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x000B36FC File Offset: 0x000B18FC
		private void StartMoveItem(BrickPress press)
		{
			this.MoveItemBehaviour.Initialize((press.Configuration as BrickPressConfiguration).DestinationRoute, press.OutputSlot.ItemInstance, -1, false);
			this.MoveItemBehaviour.Enable_Networked(null);
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x000B3734 File Offset: 0x000B1934
		protected PackagingStation GetStationToAttend()
		{
			foreach (PackagingStation packagingStation in this.configuration.AssignedStations)
			{
				if (this.PackagingBehaviour.IsStationReady(packagingStation))
				{
					return packagingStation;
				}
			}
			return null;
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x000B379C File Offset: 0x000B199C
		protected BrickPress GetBrickPress()
		{
			foreach (BrickPress brickPress in this.configuration.AssignedBrickPresses)
			{
				if (this.BrickPressBehaviour.IsStationReady(brickPress))
				{
					return brickPress;
				}
			}
			return null;
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x000B3804 File Offset: 0x000B1A04
		protected PackagingStation GetStationMoveItems()
		{
			foreach (PackagingStation packagingStation in this.configuration.AssignedStations)
			{
				ItemSlot outputSlot = packagingStation.OutputSlot;
				if (outputSlot.Quantity != 0 && this.MoveItemBehaviour.IsTransitRouteValid((packagingStation.Configuration as PackagingStationConfiguration).DestinationRoute, outputSlot.ItemInstance.ID))
				{
					return packagingStation;
				}
			}
			return null;
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x000B3894 File Offset: 0x000B1A94
		protected BrickPress GetBrickPressMoveItems()
		{
			foreach (BrickPress brickPress in this.configuration.AssignedBrickPresses)
			{
				ItemSlot outputSlot = brickPress.OutputSlot;
				if (outputSlot.Quantity != 0 && this.MoveItemBehaviour.IsTransitRouteValid((brickPress.Configuration as BrickPressConfiguration).DestinationRoute, outputSlot.ItemInstance.ID))
				{
					return brickPress;
				}
			}
			return null;
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x000B3924 File Offset: 0x000B1B24
		protected AdvancedTransitRoute GetTransitRouteReady(out ItemInstance item)
		{
			item = null;
			foreach (AdvancedTransitRoute advancedTransitRoute in this.configuration.Routes.Routes)
			{
				item = advancedTransitRoute.GetItemReadyToMove();
				if (item != null && this.movement.CanGetTo(advancedTransitRoute.Source, 1f) && this.movement.CanGetTo(advancedTransitRoute.Destination, 1f))
				{
					return advancedTransitRoute;
				}
			}
			return null;
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x000B39C0 File Offset: 0x000B1BC0
		protected override bool ShouldIdle()
		{
			return this.configuration.AssignedStationCount == 0 || base.ShouldIdle();
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x000B39D7 File Offset: 0x000B1BD7
		public override BedItem GetBed()
		{
			return this.configuration.bedItem;
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x000B39E4 File Offset: 0x000B1BE4
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
			PackagerUIElement component = Object.Instantiate<PackagerUIElement>(this.WorldspaceUIPrefab, assignedProperty.WorldspaceUIContainer).GetComponent<PackagerUIElement>();
			component.Initialize(this);
			this.WorldspaceUI = component;
			return component;
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x000B3A6F File Offset: 0x000B1C6F
		public void DestroyWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				this.WorldspaceUI.Destroy();
			}
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x000B3A8C File Offset: 0x000B1C8C
		public override string GetSaveString()
		{
			return new PackagerData(this.ID, base.AssignedProperty.PropertyCode, this.FirstName, this.LastName, base.IsMale, base.AppearanceIndex, base.transform.position, base.transform.rotation, base.GUID, base.PaidForToday, this.MoveItemBehaviour.GetSaveData()).GetJson(true);
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x000B3AFC File Offset: 0x000B1CFC
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

		// Token: 0x06002BAD RID: 11181 RVA: 0x000B3B68 File Offset: 0x000B1D68
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Employees.PackagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Employees.PackagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField = new SyncVar<NetworkObject>(this, 2U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.<CurrentPlayerConfigurer>k__BackingField);
			base.RegisterServerRpc(40U, new ServerRpcDelegate(this.RpcReader___Server_SetConfigurer_3323014238));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Employees.Packager));
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x000B3BE0 File Offset: 0x000B1DE0
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Employees.PackagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Employees.PackagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField.SetRegistered();
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x000B3C04 File Offset: 0x000B1E04
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x000B3C14 File Offset: 0x000B1E14
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

		// Token: 0x06002BB1 RID: 11185 RVA: 0x000B3CBB File Offset: 0x000B1EBB
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			this.CurrentPlayerConfigurer = player;
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x000B3CC4 File Offset: 0x000B1EC4
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

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06002BB3 RID: 11187 RVA: 0x000B3D02 File Offset: 0x000B1F02
		// (set) Token: 0x06002BB4 RID: 11188 RVA: 0x000B3D0A File Offset: 0x000B1F0A
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

		// Token: 0x06002BB5 RID: 11189 RVA: 0x000B3D48 File Offset: 0x000B1F48
		public virtual bool Packager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
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

		// Token: 0x06002BB6 RID: 11190 RVA: 0x000B3D9A File Offset: 0x000B1F9A
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001F69 RID: 8041
		[Header("References")]
		public Sprite typeIcon;

		// Token: 0x04001F6A RID: 8042
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x04001F6B RID: 8043
		public PackagingStationBehaviour PackagingBehaviour;

		// Token: 0x04001F6C RID: 8044
		public BrickPressBehaviour BrickPressBehaviour;

		// Token: 0x04001F6D RID: 8045
		[Header("UI")]
		public PackagerUIElement WorldspaceUIPrefab;

		// Token: 0x04001F6E RID: 8046
		public Transform uiPoint;

		// Token: 0x04001F6F RID: 8047
		[Header("Settings")]
		public int MaxAssignedStations = 3;

		// Token: 0x04001F70 RID: 8048
		[Header("Proficiency Settings")]
		public float PackagingSpeedMultiplier = 1f;

		// Token: 0x04001F74 RID: 8052
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04001F75 RID: 8053
		private bool dll_Excuted;

		// Token: 0x04001F76 RID: 8054
		private bool dll_Excuted;
	}
}
