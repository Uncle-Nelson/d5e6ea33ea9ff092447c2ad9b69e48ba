using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Property;
using ScheduleOne.UI.Phone.Delivery;
using ScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Delivery
{
	// Token: 0x02000717 RID: 1815
	public class DeliveryManager : NetworkSingleton<DeliveryManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06003103 RID: 12547 RVA: 0x000CBE09 File Offset: 0x000CA009
		public string SaveFolderName
		{
			get
			{
				return "Deliveries";
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x000CBE09 File Offset: 0x000CA009
		public string SaveFileName
		{
			get
			{
				return "Deliveries";
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06003105 RID: 12549 RVA: 0x000CBE10 File Offset: 0x000CA010
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x000CBE18 File Offset: 0x000CA018
		// (set) Token: 0x06003108 RID: 12552 RVA: 0x000CBE20 File Offset: 0x000CA020
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x000CBE29 File Offset: 0x000CA029
		// (set) Token: 0x0600310A RID: 12554 RVA: 0x000CBE31 File Offset: 0x000CA031
		public List<string> LocalExtraFolders { get; set; } = new List<string>
		{
			"DeliveryVehicles"
		};

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600310B RID: 12555 RVA: 0x000CBE3A File Offset: 0x000CA03A
		// (set) Token: 0x0600310C RID: 12556 RVA: 0x000CBE42 File Offset: 0x000CA042
		public bool HasChanged { get; set; }

		// Token: 0x0600310D RID: 12557 RVA: 0x000CBE4B File Offset: 0x000CA04B
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Delivery.DeliveryManager_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x000CBE5F File Offset: 0x000CA05F
		protected override void Start()
		{
			base.Start();
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.OnMinPass));
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x000CBE90 File Offset: 0x000CA090
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			foreach (DeliveryInstance delivery in this.Deliveries)
			{
				this.SendDelivery(delivery);
			}
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x000CBEEC File Offset: 0x000CA0EC
		private void OnMinPass()
		{
			if (Singleton<LoadManager>.Instance.IsLoading)
			{
				return;
			}
			foreach (DeliveryInstance deliveryInstance in this.Deliveries.ToArray())
			{
				deliveryInstance.OnMinPass();
				if (InstanceFinder.IsServer)
				{
					if (deliveryInstance.TimeUntilArrival == 0 && deliveryInstance.Status != EDeliveryStatus.Arrived)
					{
						if (this.IsLoadingBayFree(deliveryInstance.Destination, deliveryInstance.LoadingDockIndex))
						{
							deliveryInstance.AddItemsToDeliveryVehicle();
							this.SetDeliveryState(deliveryInstance.DeliveryID, EDeliveryStatus.Arrived);
						}
						else if (deliveryInstance.Status != EDeliveryStatus.Waiting)
						{
							this.SetDeliveryState(deliveryInstance.DeliveryID, EDeliveryStatus.Waiting);
						}
					}
					if (deliveryInstance.Status == EDeliveryStatus.Arrived)
					{
						if (!this.minsSinceVehicleEmpty.ContainsKey(deliveryInstance))
						{
							this.minsSinceVehicleEmpty.Add(deliveryInstance, 0);
						}
						if (deliveryInstance.ActiveVehicle.Vehicle.Storage.ItemCount == 0 && deliveryInstance.ActiveVehicle.Vehicle.Storage.CurrentAccessor == null)
						{
							Dictionary<DeliveryInstance, int> dictionary = this.minsSinceVehicleEmpty;
							DeliveryInstance key = deliveryInstance;
							int num = dictionary[key];
							dictionary[key] = num + 1;
							if (this.minsSinceVehicleEmpty[deliveryInstance] >= 3)
							{
								this.SetDeliveryState(deliveryInstance.DeliveryID, EDeliveryStatus.Completed);
							}
						}
						else
						{
							this.minsSinceVehicleEmpty[deliveryInstance] = 0;
						}
					}
				}
			}
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x000CC02B File Offset: 0x000CA22B
		public bool IsLoadingBayFree(Property destination, int loadingDockIndex)
		{
			return !destination.LoadingDocks[loadingDockIndex].IsInUse;
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x000CC03D File Offset: 0x000CA23D
		[ServerRpc(RequireOwnership = false)]
		public void SendDelivery(DeliveryInstance delivery)
		{
			this.RpcWriter___Server_SendDelivery_2813439055(delivery);
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x000CC04C File Offset: 0x000CA24C
		[ObserversRpc]
		[TargetRpc]
		private void ReceiveDelivery(NetworkConnection conn, DeliveryInstance delivery)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_ReceiveDelivery_2795369214(conn, delivery);
			}
			else
			{
				this.RpcWriter___Target_ReceiveDelivery_2795369214(conn, delivery);
			}
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x000CC080 File Offset: 0x000CA280
		[ObserversRpc(RunLocally = true)]
		private void SetDeliveryState(string deliveryID, EDeliveryStatus status)
		{
			this.RpcWriter___Observers_SetDeliveryState_316609003(deliveryID, status);
			this.RpcLogic___SetDeliveryState_316609003(deliveryID, status);
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x000CC0AC File Offset: 0x000CA2AC
		private DeliveryInstance GetDelivery(string deliveryID)
		{
			return this.Deliveries.FirstOrDefault((DeliveryInstance d) => d.DeliveryID == deliveryID);
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x000CC0E0 File Offset: 0x000CA2E0
		public DeliveryInstance GetDelivery(Property destination)
		{
			return this.Deliveries.FirstOrDefault((DeliveryInstance d) => d.DestinationCode == destination.PropertyCode);
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x000CC114 File Offset: 0x000CA314
		public DeliveryInstance GetActiveShopDelivery(DeliveryShop shop)
		{
			return this.Deliveries.FirstOrDefault((DeliveryInstance d) => d.StoreName == shop.MatchingShopInterfaceName);
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x000CC148 File Offset: 0x000CA348
		public ShopInterface GetShopInterface(string shopName)
		{
			return ShopInterface.AllShops.Find((ShopInterface x) => x.ShopName == shopName);
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x000CC178 File Offset: 0x000CA378
		public virtual string GetSaveString()
		{
			return new DeliveriesData(this.Deliveries.ToArray()).GetJson(true);
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x000CC190 File Offset: 0x000CA390
		public virtual List<string> WriteData(string parentFolderPath)
		{
			List<string> result = new List<string>();
			this.writtenVehicles.Clear();
			((ISaveable)this).GetContainerFolder(parentFolderPath);
			string parentFolderPath2 = ((ISaveable)this).WriteFolder(parentFolderPath, "DeliveryVehicles");
			foreach (DeliveryInstance deliveryInstance in this.Deliveries)
			{
				if (!(deliveryInstance.ActiveVehicle == null))
				{
					new SaveRequest(deliveryInstance.ActiveVehicle.Vehicle, parentFolderPath2);
					this.writtenVehicles.Add(deliveryInstance.ActiveVehicle.Vehicle.SaveFolderName);
				}
			}
			return result;
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x000CC240 File Offset: 0x000CA440
		public virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
			string[] directories = Directory.GetDirectories(((ISaveable)this).WriteFolder(parentFolderPath, "DeliveryVehicles"));
			for (int i = 0; i < directories.Length; i++)
			{
				if (!this.writtenVehicles.Contains(directories[i]))
				{
					try
					{
						Directory.Delete(directories[i], true);
					}
					catch (Exception ex)
					{
						Console.LogError("Failed to delete unapproved vehicle folder: " + directories[i] + " - " + ex.Message, null);
					}
				}
			}
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x000CC31C File Offset: 0x000CA51C
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendDelivery_2813439055));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveDelivery_2795369214));
			base.RegisterTargetRpc(2U, new ClientRpcDelegate(this.RpcReader___Target_ReceiveDelivery_2795369214));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_SetDeliveryState_316609003));
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x000CC39C File Offset: 0x000CA59C
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x000CC3B5 File Offset: 0x000CA5B5
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x000CC3C4 File Offset: 0x000CA5C4
		private void RpcWriter___Server_SendDelivery_2813439055(DeliveryInstance delivery)
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
			writer.Write___ScheduleOne.Delivery.DeliveryInstanceFishNet.Serializing.Generated(delivery);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x000CC46B File Offset: 0x000CA66B
		public void RpcLogic___SendDelivery_2813439055(DeliveryInstance delivery)
		{
			this.ReceiveDelivery(null, delivery);
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x000CC478 File Offset: 0x000CA678
		private void RpcReader___Server_SendDelivery_2813439055(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			DeliveryInstance delivery = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Delivery.DeliveryInstanceFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendDelivery_2813439055(delivery);
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x000CC4AC File Offset: 0x000CA6AC
		private void RpcWriter___Observers_ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
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
			writer.Write___ScheduleOne.Delivery.DeliveryInstanceFishNet.Serializing.Generated(delivery);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x000CC564 File Offset: 0x000CA764
		private void RpcLogic___ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
			if (this.GetDelivery(delivery.DeliveryID) != null)
			{
				return;
			}
			this.Deliveries.Add(delivery);
			delivery.SetStatus(delivery.Status);
			if (this.onDeliveryCreated != null)
			{
				this.onDeliveryCreated.Invoke(delivery);
			}
			this.HasChanged = true;
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x000CC5B4 File Offset: 0x000CA7B4
		private void RpcReader___Observers_ReceiveDelivery_2795369214(PooledReader PooledReader0, Channel channel)
		{
			DeliveryInstance delivery = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Delivery.DeliveryInstanceFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveDelivery_2795369214(null, delivery);
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x000CC5E8 File Offset: 0x000CA7E8
		private void RpcWriter___Target_ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
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
			writer.Write___ScheduleOne.Delivery.DeliveryInstanceFishNet.Serializing.Generated(delivery);
			base.SendTargetRpc(2U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x000CC6A0 File Offset: 0x000CA8A0
		private void RpcReader___Target_ReceiveDelivery_2795369214(PooledReader PooledReader0, Channel channel)
		{
			DeliveryInstance delivery = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Delivery.DeliveryInstanceFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveDelivery_2795369214(base.LocalConnection, delivery);
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x000CC6D8 File Offset: 0x000CA8D8
		private void RpcWriter___Observers_SetDeliveryState_316609003(string deliveryID, EDeliveryStatus status)
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
			writer.WriteString(deliveryID);
			writer.Write___ScheduleOne.Delivery.EDeliveryStatusFishNet.Serializing.Generated(status);
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x000CC79C File Offset: 0x000CA99C
		private void RpcLogic___SetDeliveryState_316609003(string deliveryID, EDeliveryStatus status)
		{
			DeliveryInstance delivery = this.GetDelivery(deliveryID);
			if (delivery != null)
			{
				delivery.SetStatus(status);
			}
			if (status == EDeliveryStatus.Completed)
			{
				if (this.onDeliveryCompleted != null)
				{
					this.onDeliveryCompleted.Invoke(delivery);
				}
				this.Deliveries.Remove(delivery);
			}
			this.HasChanged = true;
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x000CC7E8 File Offset: 0x000CA9E8
		private void RpcReader___Observers_SetDeliveryState_316609003(PooledReader PooledReader0, Channel channel)
		{
			string deliveryID = PooledReader0.ReadString();
			EDeliveryStatus status = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Delivery.EDeliveryStatusFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetDeliveryState_316609003(deliveryID, status);
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x000CC834 File Offset: 0x000CAA34
		protected virtual void dll()
		{
			base.Awake();
			this.InitializeSaveable();
		}

		// Token: 0x04002302 RID: 8962
		public List<DeliveryInstance> Deliveries = new List<DeliveryInstance>();

		// Token: 0x04002303 RID: 8963
		public UnityEvent<DeliveryInstance> onDeliveryCreated;

		// Token: 0x04002304 RID: 8964
		public UnityEvent<DeliveryInstance> onDeliveryCompleted;

		// Token: 0x04002305 RID: 8965
		private DeliveriesLoader loader = new DeliveriesLoader();

		// Token: 0x04002309 RID: 8969
		private List<string> writtenVehicles = new List<string>();

		// Token: 0x0400230A RID: 8970
		private Dictionary<DeliveryInstance, int> minsSinceVehicleEmpty = new Dictionary<DeliveryInstance, int>();

		// Token: 0x0400230B RID: 8971
		private bool dll_Excuted;

		// Token: 0x0400230C RID: 8972
		private bool dll_Excuted;
	}
}
