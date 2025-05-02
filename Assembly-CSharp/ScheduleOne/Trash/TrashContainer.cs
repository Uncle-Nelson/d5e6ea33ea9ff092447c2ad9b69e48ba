using System;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Trash
{
	// Token: 0x0200082B RID: 2091
	public class TrashContainer : NetworkBehaviour
	{
		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06003935 RID: 14645 RVA: 0x000F2014 File Offset: 0x000F0214
		// (set) Token: 0x06003936 RID: 14646 RVA: 0x000F201C File Offset: 0x000F021C
		public TrashContent Content { get; protected set; } = new TrashContent();

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x000F2025 File Offset: 0x000F0225
		public int TrashLevel
		{
			get
			{
				return this.Content.GetTotalSize();
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06003938 RID: 14648 RVA: 0x000F2032 File Offset: 0x000F0232
		public float NormalizedTrashLevel
		{
			get
			{
				return (float)this.Content.GetTotalSize() / (float)this.TrashCapacity;
			}
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x000F2048 File Offset: 0x000F0248
		public virtual void AddTrash(TrashItem item)
		{
			this.SendTrash(item.ID, 1);
			item.DestroyTrash();
			if (InstanceFinder.IsServer)
			{
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("ContainedTrashItems", (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("ContainedTrashItems") + 1f).ToString(), true);
			}
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x000F209C File Offset: 0x000F029C
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (this.Content.GetTotalSize() > 0)
			{
				this.LoadContent(connection, this.Content.GetData());
			}
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x000F20C5 File Offset: 0x000F02C5
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendTrash(string trashID, int quantity)
		{
			this.RpcWriter___Server_SendTrash_3643459082(trashID, quantity);
			this.RpcLogic___SendTrash_3643459082(trashID, quantity);
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x000F20E4 File Offset: 0x000F02E4
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void AddTrash(NetworkConnection conn, string trashID, int quantity)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_AddTrash_3905681115(conn, trashID, quantity);
				this.RpcLogic___AddTrash_3905681115(conn, trashID, quantity);
			}
			else
			{
				this.RpcWriter___Target_AddTrash_3905681115(conn, trashID, quantity);
			}
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x000F2131 File Offset: 0x000F0331
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendClear()
		{
			this.RpcWriter___Server_SendClear_2166136261();
			this.RpcLogic___SendClear_2166136261();
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x000F213F File Offset: 0x000F033F
		[ObserversRpc(RunLocally = true)]
		private void Clear()
		{
			this.RpcWriter___Observers_Clear_2166136261();
			this.RpcLogic___Clear_2166136261();
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x000F214D File Offset: 0x000F034D
		[TargetRpc]
		private void LoadContent(NetworkConnection conn, TrashContentData data)
		{
			this.RpcWriter___Target_LoadContent_189522235(conn, data);
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x000F2160 File Offset: 0x000F0360
		public void TriggerEnter(Collider other)
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.TrashLevel >= this.TrashCapacity)
			{
				return;
			}
			TrashItem componentInParent = other.GetComponentInParent<TrashItem>();
			if (componentInParent == null)
			{
				return;
			}
			if (!componentInParent.CanGoInContainer)
			{
				return;
			}
			this.AddTrash(componentInParent);
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x000F21A5 File Offset: 0x000F03A5
		public bool CanBeBagged()
		{
			return this.TrashLevel > 0;
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x000F21B0 File Offset: 0x000F03B0
		public void BagTrash()
		{
			NetworkSingleton<TrashManager>.Instance.CreateTrashBag(NetworkSingleton<TrashManager>.Instance.TrashBagPrefab.ID, this.TrashBagDropLocation.position, this.TrashBagDropLocation.rotation, this.Content.GetData(), this.TrashBagDropLocation.forward * 3f, "", false);
			this.SendClear();
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("TrashContainersBagged", (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("TrashContainersBagged") + 1f).ToString(), true);
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x000F2264 File Offset: 0x000F0464
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendTrash_3643459082));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_AddTrash_3905681115));
			base.RegisterTargetRpc(2U, new ClientRpcDelegate(this.RpcReader___Target_AddTrash_3905681115));
			base.RegisterServerRpc(3U, new ServerRpcDelegate(this.RpcReader___Server_SendClear_2166136261));
			base.RegisterObserversRpc(4U, new ClientRpcDelegate(this.RpcReader___Observers_Clear_2166136261));
			base.RegisterTargetRpc(5U, new ClientRpcDelegate(this.RpcReader___Target_LoadContent_189522235));
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x000F230C File Offset: 0x000F050C
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x000F231F File Offset: 0x000F051F
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x000F2330 File Offset: 0x000F0530
		private void RpcWriter___Server_SendTrash_3643459082(string trashID, int quantity)
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
			writer.WriteString(trashID);
			writer.WriteInt32(quantity, AutoPackType.Packed);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x000F23E9 File Offset: 0x000F05E9
		private void RpcLogic___SendTrash_3643459082(string trashID, int quantity)
		{
			this.AddTrash(null, trashID, quantity);
		}

		// Token: 0x06003949 RID: 14665 RVA: 0x000F23F4 File Offset: 0x000F05F4
		private void RpcReader___Server_SendTrash_3643459082(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string trashID = PooledReader0.ReadString();
			int quantity = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendTrash_3643459082(trashID, quantity);
		}

		// Token: 0x0600394A RID: 14666 RVA: 0x000F2448 File Offset: 0x000F0648
		private void RpcWriter___Observers_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
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
			writer.WriteString(trashID);
			writer.WriteInt32(quantity, AutoPackType.Packed);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x000F2510 File Offset: 0x000F0710
		private void RpcLogic___AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
			this.Content.AddTrash(trashID, quantity);
			if (this.onTrashAdded != null)
			{
				this.onTrashAdded.Invoke(trashID);
			}
			if (this.onTrashLevelChanged != null)
			{
				this.onTrashLevelChanged.Invoke();
			}
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x000F2548 File Offset: 0x000F0748
		private void RpcReader___Observers_AddTrash_3905681115(PooledReader PooledReader0, Channel channel)
		{
			string trashID = PooledReader0.ReadString();
			int quantity = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___AddTrash_3905681115(null, trashID, quantity);
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x000F259C File Offset: 0x000F079C
		private void RpcWriter___Target_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
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
			writer.WriteString(trashID);
			writer.WriteInt32(quantity, AutoPackType.Packed);
			base.SendTargetRpc(2U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x000F2664 File Offset: 0x000F0864
		private void RpcReader___Target_AddTrash_3905681115(PooledReader PooledReader0, Channel channel)
		{
			string trashID = PooledReader0.ReadString();
			int quantity = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___AddTrash_3905681115(base.LocalConnection, trashID, quantity);
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x000F26B4 File Offset: 0x000F08B4
		private void RpcWriter___Server_SendClear_2166136261()
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
			base.SendServerRpc(3U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x000F274E File Offset: 0x000F094E
		private void RpcLogic___SendClear_2166136261()
		{
			this.Clear();
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x000F2758 File Offset: 0x000F0958
		private void RpcReader___Server_SendClear_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendClear_2166136261();
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x000F2788 File Offset: 0x000F0988
		private void RpcWriter___Observers_Clear_2166136261()
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
			base.SendObserversRpc(4U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x000F2831 File Offset: 0x000F0A31
		private void RpcLogic___Clear_2166136261()
		{
			this.Content.Clear();
			if (this.onTrashLevelChanged != null)
			{
				this.onTrashLevelChanged.Invoke();
			}
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x000F2854 File Offset: 0x000F0A54
		private void RpcReader___Observers_Clear_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Clear_2166136261();
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x000F2880 File Offset: 0x000F0A80
		private void RpcWriter___Target_LoadContent_189522235(NetworkConnection conn, TrashContentData data)
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
			writer.Write___ScheduleOne.Persistence.TrashContentDataFishNet.Serializing.Generated(data);
			base.SendTargetRpc(5U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x000F2935 File Offset: 0x000F0B35
		private void RpcLogic___LoadContent_189522235(NetworkConnection conn, TrashContentData data)
		{
			this.Content.LoadFromData(data);
			if (this.onTrashLevelChanged != null)
			{
				this.onTrashLevelChanged.Invoke();
			}
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x000F2958 File Offset: 0x000F0B58
		private void RpcReader___Target_LoadContent_189522235(PooledReader PooledReader0, Channel channel)
		{
			TrashContentData data = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Persistence.TrashContentDataFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___LoadContent_189522235(base.LocalConnection, data);
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x000F231F File Offset: 0x000F051F
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400296E RID: 10606
		[Header("Settings")]
		[Range(1f, 50f)]
		public int TrashCapacity = 10;

		// Token: 0x0400296F RID: 10607
		[Header("Settings")]
		public Transform TrashBagDropLocation;

		// Token: 0x04002970 RID: 10608
		public UnityEvent<string> onTrashAdded;

		// Token: 0x04002971 RID: 10609
		public UnityEvent onTrashLevelChanged;

		// Token: 0x04002972 RID: 10610
		private bool dll_Excuted;

		// Token: 0x04002973 RID: 10611
		private bool dll_Excuted;
	}
}
