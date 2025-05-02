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
using ScheduleOne.Management;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.ObjectScripts;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.Trash;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Employees
{
	// Token: 0x02000644 RID: 1604
	public class Cleaner : Employee, IConfigurable
	{
		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06002AEE RID: 10990 RVA: 0x000B0F82 File Offset: 0x000AF182
		// (set) Token: 0x06002AEF RID: 10991 RVA: 0x000B0F8A File Offset: 0x000AF18A
		public TrashGrabberInstance trashGrabberInstance { get; private set; }

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x000B0F93 File Offset: 0x000AF193
		public EntityConfiguration Configuration
		{
			get
			{
				return this.configuration;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x000B0F9B File Offset: 0x000AF19B
		// (set) Token: 0x06002AF2 RID: 10994 RVA: 0x000B0FA3 File Offset: 0x000AF1A3
		protected CleanerConfiguration configuration { get; set; }

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x000B0FAC File Offset: 0x000AF1AC
		public ConfigurationReplicator ConfigReplicator
		{
			get
			{
				return this.configReplicator;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x000B0FB4 File Offset: 0x000AF1B4
		public EConfigurableType ConfigurableType
		{
			get
			{
				return EConfigurableType.Cleaner;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x000B0FB7 File Offset: 0x000AF1B7
		// (set) Token: 0x06002AF6 RID: 10998 RVA: 0x000B0FBF File Offset: 0x000AF1BF
		public WorldspaceUIElement WorldspaceUI { get; set; }

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x000B0FC8 File Offset: 0x000AF1C8
		// (set) Token: 0x06002AF8 RID: 11000 RVA: 0x000B0FD0 File Offset: 0x000AF1D0
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

		// Token: 0x06002AF9 RID: 11001 RVA: 0x000B0FDA File Offset: 0x000AF1DA
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
			this.RpcWriter___Server_SetConfigurer_3323014238(player);
			this.RpcLogic___SetConfigurer_3323014238(player);
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06002AFA RID: 11002 RVA: 0x000B0FF0 File Offset: 0x000AF1F0
		public Sprite TypeIcon
		{
			get
			{
				return this.typeIcon;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06002AFB RID: 11003 RVA: 0x000AEDCB File Offset: 0x000ACFCB
		public Transform Transform
		{
			get
			{
				return base.transform;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06002AFC RID: 11004 RVA: 0x000B0FF8 File Offset: 0x000AF1F8
		public Transform UIPoint
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool CanBeSelected
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06002AFE RID: 11006 RVA: 0x000AEDDB File Offset: 0x000ACFDB
		public Property ParentProperty
		{
			get
			{
				return base.AssignedProperty;
			}
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x000B1000 File Offset: 0x000AF200
		protected override void AssignProperty(Property prop)
		{
			base.AssignProperty(prop);
			prop.AddConfigurable(this);
			this.configuration = new CleanerConfiguration(this.configReplicator, this, this);
			this.CreateWorldspaceUI();
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x000B102A File Offset: 0x000AF22A
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

		// Token: 0x06002B01 RID: 11009 RVA: 0x000B1065 File Offset: 0x000AF265
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			this.SendConfigurationToClient(connection);
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x000B1078 File Offset: 0x000AF278
		public void SendConfigurationToClient(NetworkConnection conn)
		{
			Cleaner.<>c__DisplayClass46_0 CS$<>8__locals1 = new Cleaner.<>c__DisplayClass46_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.conn = conn;
			if (CS$<>8__locals1.conn.IsHost)
			{
				return;
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SendConfigurationToClient>g__WaitForConfig|0());
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x000B10B8 File Offset: 0x000AF2B8
		protected override void MinPass()
		{
			base.MinPass();
			if (Singleton<LoadManager>.Instance.IsLoading)
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
			if (this.configuration.binItems.Count == 0)
			{
				base.SubmitNoWorkReason("I haven't been assigned any trash cans", "You can use your management clipboards to assign trash cans to me.", 0);
				this.SetIdle(true);
				return;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			this.TryStartNewTask();
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x000B1138 File Offset: 0x000AF338
		private void TryStartNewTask()
		{
			TrashContainerItem[] trashContainersOrderedByDistance = this.GetTrashContainersOrderedByDistance();
			this.EnsureTrashGrabberInInventory();
			foreach (TrashContainerItem trashContainerItem in trashContainersOrderedByDistance)
			{
				if (trashContainerItem.TrashBagsInRadius.Count > 0)
				{
					if (base.AssignedProperty.DisposalArea != null)
					{
						TrashBag targetBag = trashContainerItem.TrashBagsInRadius[0];
						this.DisposeTrashBagBehaviour.SetTargetBag(targetBag);
						this.DisposeTrashBagBehaviour.Enable_Networked(null);
						return;
					}
					Console.LogError("No disposal area assigned to property " + base.AssignedProperty.PropertyCode, null);
				}
			}
			if (this.GetTrashGrabberAmount() < 20)
			{
				foreach (TrashContainerItem trashContainerItem2 in trashContainersOrderedByDistance)
				{
					if (trashContainerItem2.TrashItemsInRadius.Count > 0)
					{
						int num = 0;
						TrashItem trashItem = trashContainerItem2.TrashItemsInRadius[num];
						while (trashItem == null || !this.movement.CanGetTo(trashItem.transform.position, 1f))
						{
							num++;
							if (num >= trashContainerItem2.TrashItemsInRadius.Count)
							{
								trashItem = null;
								break;
							}
							trashItem = trashContainerItem2.TrashItemsInRadius[num];
						}
						if (trashItem != null)
						{
							this.PickUpTrashBehaviour.SetTargetTrash(trashItem);
							this.PickUpTrashBehaviour.Enable_Networked(null);
							return;
						}
					}
				}
			}
			if (this.GetTrashGrabberAmount() >= 20 && this.GetFirstNonFullBin(trashContainersOrderedByDistance) != null)
			{
				this.EmptyTrashGrabberBehaviour.SetTargetTrashCan(this.GetFirstNonFullBin(trashContainersOrderedByDistance));
				this.EmptyTrashGrabberBehaviour.Enable_Networked(null);
				return;
			}
			foreach (TrashContainerItem trashContainerItem3 in trashContainersOrderedByDistance)
			{
				if (trashContainerItem3.Container.NormalizedTrashLevel >= 0.75f)
				{
					this.BagTrashCanBehaviour.SetTargetTrashCan(trashContainerItem3);
					this.BagTrashCanBehaviour.Enable_Networked(null);
					return;
				}
			}
			base.SubmitNoWorkReason("There's nothing for me to do right now.", string.Empty, 0);
			this.SetIdle(true);
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x000B1322 File Offset: 0x000AF522
		private TrashContainerItem GetFirstNonFullBin(TrashContainerItem[] bins)
		{
			return bins.FirstOrDefault((TrashContainerItem bin) => bin.Container.NormalizedTrashLevel < 1f);
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x000B1349 File Offset: 0x000AF549
		public override void SetIdle(bool idle)
		{
			base.SetIdle(idle);
			if (idle && this.Avatar.CurrentEquippable != null)
			{
				base.SetEquippable_Return(string.Empty);
			}
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x000B1374 File Offset: 0x000AF574
		private TrashContainerItem[] GetTrashContainersOrderedByDistance()
		{
			TrashContainerItem[] array = this.configuration.binItems.ToArray();
			Array.Sort<TrashContainerItem>(array, delegate(TrashContainerItem x, TrashContainerItem y)
			{
				float num = Vector3.Distance(x.transform.position, base.transform.position);
				float value = Vector3.Distance(y.transform.position, base.transform.position);
				return num.CompareTo(value);
			});
			return array;
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x000B1398 File Offset: 0x000AF598
		public override BedItem GetBed()
		{
			return this.configuration.bedItem;
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x000B13A8 File Offset: 0x000AF5A8
		private void EnsureTrashGrabberInInventory()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (base.Inventory._GetItemAmount(this.TrashGrabberDef.ID) == 0)
			{
				base.Inventory.InsertItem(this.TrashGrabberDef.GetDefaultInstance(1), true);
			}
			this.trashGrabberInstance = (base.Inventory.GetFirstItem(this.TrashGrabberDef.ID, null) as TrashGrabberInstance);
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x000B1410 File Offset: 0x000AF610
		private bool AnyWorkInProgress()
		{
			return this.PickUpTrashBehaviour.Active || this.EmptyTrashGrabberBehaviour.Active || this.BagTrashCanBehaviour.Active || this.DisposeTrashBagBehaviour.Active || this.MoveItemBehaviour.Active;
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x000B1469 File Offset: 0x000AF669
		private int GetTrashGrabberAmount()
		{
			return this.trashGrabberInstance.GetTotalSize();
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x000B1478 File Offset: 0x000AF678
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
			CleanerUIElement component = Object.Instantiate<CleanerUIElement>(this.WorldspaceUIPrefab, assignedProperty.WorldspaceUIContainer).GetComponent<CleanerUIElement>();
			component.Initialize(this);
			this.WorldspaceUI = component;
			return component;
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x000B1503 File Offset: 0x000AF703
		public void DestroyWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				this.WorldspaceUI.Destroy();
			}
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x000B1520 File Offset: 0x000AF720
		public override string GetSaveString()
		{
			return new CleanerData(this.ID, base.AssignedProperty.PropertyCode, this.FirstName, this.LastName, base.IsMale, base.AppearanceIndex, base.transform.position, base.transform.rotation, base.GUID, base.PaidForToday, this.MoveItemBehaviour.GetSaveData()).GetJson(true);
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x000B1590 File Offset: 0x000AF790
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

		// Token: 0x06002B12 RID: 11026 RVA: 0x000B1634 File Offset: 0x000AF834
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Employees.CleanerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Employees.CleanerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField = new SyncVar<NetworkObject>(this, 2U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.<CurrentPlayerConfigurer>k__BackingField);
			base.RegisterServerRpc(40U, new ServerRpcDelegate(this.RpcReader___Server_SetConfigurer_3323014238));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Employees.Cleaner));
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x000B16AC File Offset: 0x000AF8AC
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Employees.CleanerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Employees.CleanerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField.SetRegistered();
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x000B16D0 File Offset: 0x000AF8D0
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x000B16E0 File Offset: 0x000AF8E0
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

		// Token: 0x06002B16 RID: 11030 RVA: 0x000B1787 File Offset: 0x000AF987
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			this.CurrentPlayerConfigurer = player;
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x000B1790 File Offset: 0x000AF990
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

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06002B18 RID: 11032 RVA: 0x000B17CE File Offset: 0x000AF9CE
		// (set) Token: 0x06002B19 RID: 11033 RVA: 0x000B17D6 File Offset: 0x000AF9D6
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

		// Token: 0x06002B1A RID: 11034 RVA: 0x000B1814 File Offset: 0x000AFA14
		public virtual bool Cleaner(PooledReader PooledReader0, uint UInt321, bool Boolean2)
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

		// Token: 0x06002B1B RID: 11035 RVA: 0x000B1866 File Offset: 0x000AFA66
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001F1D RID: 7965
		public const int MAX_ASSIGNED_BINS = 3;

		// Token: 0x04001F1E RID: 7966
		public TrashGrabberDefinition TrashGrabberDef;

		// Token: 0x04001F1F RID: 7967
		[Header("References")]
		public PickUpTrashBehaviour PickUpTrashBehaviour;

		// Token: 0x04001F20 RID: 7968
		public EmptyTrashGrabberBehaviour EmptyTrashGrabberBehaviour;

		// Token: 0x04001F21 RID: 7969
		public BagTrashCanBehaviour BagTrashCanBehaviour;

		// Token: 0x04001F22 RID: 7970
		public DisposeTrashBagBehaviour DisposeTrashBagBehaviour;

		// Token: 0x04001F23 RID: 7971
		public Sprite typeIcon;

		// Token: 0x04001F24 RID: 7972
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x04001F25 RID: 7973
		[Header("UI")]
		public CleanerUIElement WorldspaceUIPrefab;

		// Token: 0x04001F26 RID: 7974
		public Transform uiPoint;

		// Token: 0x04001F2B RID: 7979
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04001F2C RID: 7980
		private bool dll_Excuted;

		// Token: 0x04001F2D RID: 7981
		private bool dll_Excuted;
	}
}
