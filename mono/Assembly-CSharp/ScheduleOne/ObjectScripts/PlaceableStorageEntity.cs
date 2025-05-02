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
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BED RID: 3053
	public class PlaceableStorageEntity : GridItem, ITransitEntity, IStorageEntity, IUsable
	{
		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06005592 RID: 21906 RVA: 0x00168B42 File Offset: 0x00166D42
		public Transform storedItemContainer
		{
			get
			{
				return this._storedItemContainer;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06005593 RID: 21907 RVA: 0x00168B4A File Offset: 0x00166D4A
		// (set) Token: 0x06005594 RID: 21908 RVA: 0x00168B52 File Offset: 0x00166D52
		public Dictionary<StoredItem, Employee> reservedItems
		{
			get
			{
				return this._reservedItems;
			}
			set
			{
				this._reservedItems = value;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06005595 RID: 21909 RVA: 0x00150487 File Offset: 0x0014E687
		public string Name
		{
			get
			{
				return base.ItemInstance.Name;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06005596 RID: 21910 RVA: 0x00168B5B File Offset: 0x00166D5B
		// (set) Token: 0x06005597 RID: 21911 RVA: 0x00168B63 File Offset: 0x00166D63
		public List<ItemSlot> InputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06005598 RID: 21912 RVA: 0x00168B6C File Offset: 0x00166D6C
		// (set) Token: 0x06005599 RID: 21913 RVA: 0x00168B74 File Offset: 0x00166D74
		public List<ItemSlot> OutputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x0600559A RID: 21914 RVA: 0x000AEDCB File Offset: 0x000ACFCB
		public Transform LinkOrigin
		{
			get
			{
				return base.transform;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x0600559B RID: 21915 RVA: 0x00168B7D File Offset: 0x00166D7D
		// (set) Token: 0x0600559C RID: 21916 RVA: 0x00168B85 File Offset: 0x00166D85
		public NetworkObject NPCUserObject
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<NPCUserObject>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.sync___set_value_<NPCUserObject>k__BackingField(value, true);
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x0600559D RID: 21917 RVA: 0x00168B8F File Offset: 0x00166D8F
		// (set) Token: 0x0600559E RID: 21918 RVA: 0x00168B97 File Offset: 0x00166D97
		public NetworkObject PlayerUserObject
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<PlayerUserObject>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.sync___set_value_<PlayerUserObject>k__BackingField(value, true);
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x0600559F RID: 21919 RVA: 0x00168BA1 File Offset: 0x00166DA1
		public Transform[] AccessPoints
		{
			get
			{
				return this.accessPoints;
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x060055A0 RID: 21920 RVA: 0x00168BA9 File Offset: 0x00166DA9
		public bool Selectable { get; } = 1;

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x060055A1 RID: 21921 RVA: 0x00168BB1 File Offset: 0x00166DB1
		// (set) Token: 0x060055A2 RID: 21922 RVA: 0x00168BB9 File Offset: 0x00166DB9
		public bool IsAcceptingItems { get; set; } = true;

		// Token: 0x060055A3 RID: 21923 RVA: 0x00168BC4 File Offset: 0x00166DC4
		protected override void Start()
		{
			base.Start();
			for (int i = 0; i < this.StorageEntity.ItemSlots.Count; i++)
			{
				this.InputSlots.Add(this.StorageEntity.ItemSlots[i]);
				this.OutputSlots.Add(this.StorageEntity.ItemSlots[i]);
			}
		}

		// Token: 0x060055A4 RID: 21924 RVA: 0x00168C2A File Offset: 0x00166E2A
		public List<StoredItem> GetStoredItems()
		{
			return new List<StoredItem>(this.storedItemContainer.GetComponentsInChildren<StoredItem>());
		}

		// Token: 0x060055A5 RID: 21925 RVA: 0x00168C3C File Offset: 0x00166E3C
		public List<StorageGrid> GetStorageGrids()
		{
			return this.storageGrids;
		}

		// Token: 0x060055A6 RID: 21926 RVA: 0x00168C44 File Offset: 0x00166E44
		[ObserversRpc(RunLocally = true)]
		public void DestroyStoredItem(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			this.RpcWriter___Observers_DestroyStoredItem_3261517793(gridIndex, coord, jobID, network);
			this.RpcLogic___DestroyStoredItem_3261517793(gridIndex, coord, jobID, network);
		}

		// Token: 0x060055A7 RID: 21927 RVA: 0x00168C7D File Offset: 0x00166E7D
		[ServerRpc(RequireOwnership = false)]
		private void DestroyStoredItem_Server(int gridIndex, Coordinate coord, string jobID)
		{
			this.RpcWriter___Server_DestroyStoredItem_Server_3952619116(gridIndex, coord, jobID);
		}

		// Token: 0x060055A8 RID: 21928 RVA: 0x00168C91 File Offset: 0x00166E91
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
			this.RpcWriter___Server_SetPlayerUser_3323014238(playerObject);
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x060055A9 RID: 21929 RVA: 0x00168CA7 File Offset: 0x00166EA7
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
			this.RpcWriter___Server_SetNPCUser_3323014238(npcObject);
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x060055AA RID: 21930 RVA: 0x00168CBD File Offset: 0x00166EBD
		public override bool CanBeDestroyed(out string reason)
		{
			if (this.StorageEntity.CurrentAccessor != null)
			{
				reason = "In use by other player";
				return false;
			}
			if (this.StorageEntity.ItemCount > 0)
			{
				reason = "Contains items";
				return false;
			}
			return base.CanBeDestroyed(out reason);
		}

		// Token: 0x060055AB RID: 21931 RVA: 0x00168CF9 File Offset: 0x00166EF9
		public override string GetSaveString()
		{
			return new PlaceableStorageData(base.GUID, base.ItemInstance, 0, base.OwnerGrid, this.OriginCoordinate, this.Rotation, new ItemSet(this.StorageEntity.ItemSlots)).GetJson(true);
		}

		// Token: 0x060055AD RID: 21933 RVA: 0x00168D90 File Offset: 0x00166F90
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.PlaceableStorageEntityAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.PlaceableStorageEntityAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<PlayerUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 1U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<PlayerUserObject>k__BackingField);
			this.syncVar___<NPCUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<NPCUserObject>k__BackingField);
			base.RegisterObserversRpc(8U, new ClientRpcDelegate(this.RpcReader___Observers_DestroyStoredItem_3261517793));
			base.RegisterServerRpc(9U, new ServerRpcDelegate(this.RpcReader___Server_DestroyStoredItem_Server_3952619116));
			base.RegisterServerRpc(10U, new ServerRpcDelegate(this.RpcReader___Server_SetPlayerUser_3323014238));
			base.RegisterServerRpc(11U, new ServerRpcDelegate(this.RpcReader___Server_SetNPCUser_3323014238));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.ObjectScripts.PlaceableStorageEntity));
		}

		// Token: 0x060055AE RID: 21934 RVA: 0x00168E78 File Offset: 0x00167078
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.PlaceableStorageEntityAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.PlaceableStorageEntityAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<PlayerUserObject>k__BackingField.SetRegistered();
			this.syncVar___<NPCUserObject>k__BackingField.SetRegistered();
		}

		// Token: 0x060055AF RID: 21935 RVA: 0x00168EA7 File Offset: 0x001670A7
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060055B0 RID: 21936 RVA: 0x00168EB8 File Offset: 0x001670B8
		private void RpcWriter___Observers_DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(gridIndex, AutoPackType.Packed);
			writer.Write___ScheduleOne.Tiles.CoordinateFishNet.Serializing.Generated(coord);
			writer.WriteString(jobID);
			writer.WriteBoolean(network);
			base.SendObserversRpc(8U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060055B1 RID: 21937 RVA: 0x00168F9C File Offset: 0x0016719C
		public void RpcLogic___DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			if (jobID != "")
			{
				if (this.completedJobs.Contains(jobID))
				{
					return;
				}
			}
			else
			{
				jobID = Guid.NewGuid().ToString();
			}
			this.completedJobs.Add(jobID);
			List<StorageGrid> list = this.GetStorageGrids();
			if (gridIndex > list.Count)
			{
				Console.LogError("DestroyStoredItem: grid index out of range", null);
				return;
			}
			if (list[gridIndex].GetTile(coord) == null)
			{
				Console.LogError("DestroyStoredItem: no tile found at " + ((coord != null) ? coord.ToString() : null), null);
				return;
			}
			list[gridIndex].GetTile(coord).occupant.Destroy_Internal();
			if (network)
			{
				this.DestroyStoredItem_Server(gridIndex, coord, jobID);
			}
		}

		// Token: 0x060055B2 RID: 21938 RVA: 0x0016905C File Offset: 0x0016725C
		private void RpcReader___Observers_DestroyStoredItem_3261517793(PooledReader PooledReader0, Channel channel)
		{
			int gridIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			Coordinate coord = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Tiles.CoordinateFishNet.Serializing.Generateds(PooledReader0);
			string jobID = PooledReader0.ReadString();
			bool network = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___DestroyStoredItem_3261517793(gridIndex, coord, jobID, network);
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x001690D0 File Offset: 0x001672D0
		private void RpcWriter___Server_DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
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
			writer.WriteInt32(gridIndex, AutoPackType.Packed);
			writer.Write___ScheduleOne.Tiles.CoordinateFishNet.Serializing.Generated(coord);
			writer.WriteString(jobID);
			base.SendServerRpc(9U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060055B4 RID: 21940 RVA: 0x00169196 File Offset: 0x00167396
		private void RpcLogic___DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
			this.DestroyStoredItem(gridIndex, coord, jobID, false);
		}

		// Token: 0x060055B5 RID: 21941 RVA: 0x001691A4 File Offset: 0x001673A4
		private void RpcReader___Server_DestroyStoredItem_Server_3952619116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int gridIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			Coordinate coord = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Tiles.CoordinateFishNet.Serializing.Generateds(PooledReader0);
			string jobID = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___DestroyStoredItem_Server_3952619116(gridIndex, coord, jobID);
		}

		// Token: 0x060055B6 RID: 21942 RVA: 0x001691FC File Offset: 0x001673FC
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
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
			writer.WriteNetworkObject(playerObject);
			base.SendServerRpc(10U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060055B7 RID: 21943 RVA: 0x001692A3 File Offset: 0x001674A3
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			this.PlayerUserObject = playerObject;
		}

		// Token: 0x060055B8 RID: 21944 RVA: 0x001692AC File Offset: 0x001674AC
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject playerObject = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x060055B9 RID: 21945 RVA: 0x001692EC File Offset: 0x001674EC
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
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
			writer.WriteNetworkObject(npcObject);
			base.SendServerRpc(11U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x00169393 File Offset: 0x00167593
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			this.NPCUserObject = npcObject;
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x0016939C File Offset: 0x0016759C
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject npcObject = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x060055BC RID: 21948 RVA: 0x001693DA File Offset: 0x001675DA
		// (set) Token: 0x060055BD RID: 21949 RVA: 0x001693E2 File Offset: 0x001675E2
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			get
			{
				return this.<NPCUserObject>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<NPCUserObject>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<NPCUserObject>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x00169420 File Offset: 0x00167620
		public virtual bool PlaceableStorageEntity(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 == 1U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<PlayerUserObject>k__BackingField(this.syncVar___<PlayerUserObject>k__BackingField.GetValue(true), true);
					return true;
				}
				NetworkObject value = PooledReader0.ReadNetworkObject();
				this.sync___set_value_<PlayerUserObject>k__BackingField(value, Boolean2);
				return true;
			}
			else
			{
				if (UInt321 != 0U)
				{
					return false;
				}
				if (PooledReader0 == null)
				{
					this.sync___set_value_<NPCUserObject>k__BackingField(this.syncVar___<NPCUserObject>k__BackingField.GetValue(true), true);
					return true;
				}
				NetworkObject value2 = PooledReader0.ReadNetworkObject();
				this.sync___set_value_<NPCUserObject>k__BackingField(value2, Boolean2);
				return true;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x060055BF RID: 21951 RVA: 0x001694B6 File Offset: 0x001676B6
		// (set) Token: 0x060055C0 RID: 21952 RVA: 0x001694BE File Offset: 0x001676BE
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			get
			{
				return this.<PlayerUserObject>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<PlayerUserObject>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<PlayerUserObject>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x060055C1 RID: 21953 RVA: 0x001694FA File Offset: 0x001676FA
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04003F66 RID: 16230
		[Header("Reference")]
		[SerializeField]
		protected Transform _storedItemContainer;

		// Token: 0x04003F67 RID: 16231
		public StorageEntity StorageEntity;

		// Token: 0x04003F68 RID: 16232
		[SerializeField]
		protected List<StorageGrid> storageGrids = new List<StorageGrid>();

		// Token: 0x04003F69 RID: 16233
		public Transform[] accessPoints;

		// Token: 0x04003F6A RID: 16234
		protected Dictionary<StoredItem, Employee> _reservedItems = new Dictionary<StoredItem, Employee>();

		// Token: 0x04003F71 RID: 16241
		private List<string> completedJobs = new List<string>();

		// Token: 0x04003F72 RID: 16242
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04003F73 RID: 16243
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04003F74 RID: 16244
		private bool dll_Excuted;

		// Token: 0x04003F75 RID: 16245
		private bool dll_Excuted;
	}
}
