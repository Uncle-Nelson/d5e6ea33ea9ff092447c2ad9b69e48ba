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
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BF5 RID: 3061
	public class SurfaceStorageEntity : SurfaceItem, IStorageEntity, IUsable
	{
		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06005621 RID: 22049 RVA: 0x0016AA4A File Offset: 0x00168C4A
		public Transform storedItemContainer
		{
			get
			{
				return this._storedItemContainer;
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06005622 RID: 22050 RVA: 0x0016AA52 File Offset: 0x00168C52
		// (set) Token: 0x06005623 RID: 22051 RVA: 0x0016AA5A File Offset: 0x00168C5A
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

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06005624 RID: 22052 RVA: 0x0016AA63 File Offset: 0x00168C63
		// (set) Token: 0x06005625 RID: 22053 RVA: 0x0016AA6B File Offset: 0x00168C6B
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

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06005626 RID: 22054 RVA: 0x0016AA75 File Offset: 0x00168C75
		// (set) Token: 0x06005627 RID: 22055 RVA: 0x0016AA7D File Offset: 0x00168C7D
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

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06005628 RID: 22056 RVA: 0x0016AA87 File Offset: 0x00168C87
		public bool Selectable { get; } = 1;

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06005629 RID: 22057 RVA: 0x0016AA8F File Offset: 0x00168C8F
		// (set) Token: 0x0600562A RID: 22058 RVA: 0x0016AA97 File Offset: 0x00168C97
		public bool IsAcceptingItems { get; set; } = true;

		// Token: 0x0600562B RID: 22059 RVA: 0x0016AAA0 File Offset: 0x00168CA0
		protected override void Start()
		{
			base.Start();
		}

		// Token: 0x0600562C RID: 22060 RVA: 0x0016AAA8 File Offset: 0x00168CA8
		public List<StoredItem> GetStoredItems()
		{
			return new List<StoredItem>(this.storedItemContainer.GetComponentsInChildren<StoredItem>());
		}

		// Token: 0x0600562D RID: 22061 RVA: 0x0016AABA File Offset: 0x00168CBA
		public List<StorageGrid> GetStorageGrids()
		{
			return this.storageGrids;
		}

		// Token: 0x0600562E RID: 22062 RVA: 0x0016AAC4 File Offset: 0x00168CC4
		[ObserversRpc(RunLocally = true)]
		public void DestroyStoredItem(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			this.RpcWriter___Observers_DestroyStoredItem_3261517793(gridIndex, coord, jobID, network);
			this.RpcLogic___DestroyStoredItem_3261517793(gridIndex, coord, jobID, network);
		}

		// Token: 0x0600562F RID: 22063 RVA: 0x0016AAFD File Offset: 0x00168CFD
		[ServerRpc(RequireOwnership = false)]
		private void DestroyStoredItem_Server(int gridIndex, Coordinate coord, string jobID)
		{
			this.RpcWriter___Server_DestroyStoredItem_Server_3952619116(gridIndex, coord, jobID);
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x0016AB11 File Offset: 0x00168D11
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
			this.RpcWriter___Server_SetPlayerUser_3323014238(playerObject);
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x06005631 RID: 22065 RVA: 0x0016AB27 File Offset: 0x00168D27
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
			this.RpcWriter___Server_SetNPCUser_3323014238(npcObject);
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x06005632 RID: 22066 RVA: 0x0016AB3D File Offset: 0x00168D3D
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

		// Token: 0x06005633 RID: 22067 RVA: 0x0016AB7C File Offset: 0x00168D7C
		public override string GetSaveString()
		{
			return new StorageSurfaceItemData(base.GUID, base.ItemInstance, 0, base.ParentSurface.GUID.ToString(), this.RelativePosition, this.RelativeRotation, new ItemSet(this.StorageEntity.ItemSlots)).GetJson(true);
		}

		// Token: 0x06005635 RID: 22069 RVA: 0x0016AC10 File Offset: 0x00168E10
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.SurfaceStorageEntityAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.SurfaceStorageEntityAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<PlayerUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 1U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<PlayerUserObject>k__BackingField);
			this.syncVar___<NPCUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<NPCUserObject>k__BackingField);
			base.RegisterObserversRpc(8U, new ClientRpcDelegate(this.RpcReader___Observers_DestroyStoredItem_3261517793));
			base.RegisterServerRpc(9U, new ServerRpcDelegate(this.RpcReader___Server_DestroyStoredItem_Server_3952619116));
			base.RegisterServerRpc(10U, new ServerRpcDelegate(this.RpcReader___Server_SetPlayerUser_3323014238));
			base.RegisterServerRpc(11U, new ServerRpcDelegate(this.RpcReader___Server_SetNPCUser_3323014238));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.ObjectScripts.SurfaceStorageEntity));
		}

		// Token: 0x06005636 RID: 22070 RVA: 0x0016ACF8 File Offset: 0x00168EF8
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.SurfaceStorageEntityAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.SurfaceStorageEntityAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<PlayerUserObject>k__BackingField.SetRegistered();
			this.syncVar___<NPCUserObject>k__BackingField.SetRegistered();
		}

		// Token: 0x06005637 RID: 22071 RVA: 0x0016AD27 File Offset: 0x00168F27
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06005638 RID: 22072 RVA: 0x0016AD38 File Offset: 0x00168F38
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

		// Token: 0x06005639 RID: 22073 RVA: 0x0016AE1C File Offset: 0x0016901C
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

		// Token: 0x0600563A RID: 22074 RVA: 0x0016AEDC File Offset: 0x001690DC
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

		// Token: 0x0600563B RID: 22075 RVA: 0x0016AF50 File Offset: 0x00169150
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

		// Token: 0x0600563C RID: 22076 RVA: 0x0016B016 File Offset: 0x00169216
		private void RpcLogic___DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
			this.DestroyStoredItem(gridIndex, coord, jobID, false);
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x0016B024 File Offset: 0x00169224
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

		// Token: 0x0600563E RID: 22078 RVA: 0x0016B07C File Offset: 0x0016927C
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

		// Token: 0x0600563F RID: 22079 RVA: 0x0016B123 File Offset: 0x00169323
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			this.PlayerUserObject = playerObject;
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x0016B12C File Offset: 0x0016932C
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

		// Token: 0x06005641 RID: 22081 RVA: 0x0016B16C File Offset: 0x0016936C
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

		// Token: 0x06005642 RID: 22082 RVA: 0x0016B213 File Offset: 0x00169413
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			this.NPCUserObject = npcObject;
		}

		// Token: 0x06005643 RID: 22083 RVA: 0x0016B21C File Offset: 0x0016941C
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

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06005644 RID: 22084 RVA: 0x0016B25A File Offset: 0x0016945A
		// (set) Token: 0x06005645 RID: 22085 RVA: 0x0016B262 File Offset: 0x00169462
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

		// Token: 0x06005646 RID: 22086 RVA: 0x0016B2A0 File Offset: 0x001694A0
		public virtual bool SurfaceStorageEntity(PooledReader PooledReader0, uint UInt321, bool Boolean2)
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

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06005647 RID: 22087 RVA: 0x0016B336 File Offset: 0x00169536
		// (set) Token: 0x06005648 RID: 22088 RVA: 0x0016B33E File Offset: 0x0016953E
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

		// Token: 0x06005649 RID: 22089 RVA: 0x0016B37A File Offset: 0x0016957A
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04003FAA RID: 16298
		[Header("Reference")]
		[SerializeField]
		protected Transform _storedItemContainer;

		// Token: 0x04003FAB RID: 16299
		public StorageEntity StorageEntity;

		// Token: 0x04003FAC RID: 16300
		[SerializeField]
		protected List<StorageGrid> storageGrids = new List<StorageGrid>();

		// Token: 0x04003FAD RID: 16301
		protected Dictionary<StoredItem, Employee> _reservedItems = new Dictionary<StoredItem, Employee>();

		// Token: 0x04003FB2 RID: 16306
		private List<string> completedJobs = new List<string>();

		// Token: 0x04003FB3 RID: 16307
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04003FB4 RID: 16308
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04003FB5 RID: 16309
		private bool dll_Excuted;

		// Token: 0x04003FB6 RID: 16310
		private bool dll_Excuted;
	}
}
