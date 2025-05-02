using System;
using System.Collections.Generic;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000B4F RID: 2895
	public class ShopManager : NetworkSingleton<ShopManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06004CF9 RID: 19705 RVA: 0x00144A4B File Offset: 0x00142C4B
		public string SaveFolderName
		{
			get
			{
				return "Shops";
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06004CFA RID: 19706 RVA: 0x00144A4B File Offset: 0x00142C4B
		public string SaveFileName
		{
			get
			{
				return "Shops";
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06004CFB RID: 19707 RVA: 0x00144A52 File Offset: 0x00142C52
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06004CFC RID: 19708 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06004CFD RID: 19709 RVA: 0x00144A5A File Offset: 0x00142C5A
		// (set) Token: 0x06004CFE RID: 19710 RVA: 0x00144A62 File Offset: 0x00142C62
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06004CFF RID: 19711 RVA: 0x00144A6B File Offset: 0x00142C6B
		// (set) Token: 0x06004D00 RID: 19712 RVA: 0x00144A73 File Offset: 0x00142C73
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06004D01 RID: 19713 RVA: 0x00144A7C File Offset: 0x00142C7C
		// (set) Token: 0x06004D02 RID: 19714 RVA: 0x00144A84 File Offset: 0x00142C84
		public bool HasChanged { get; set; }

		// Token: 0x06004D03 RID: 19715 RVA: 0x00144A8D File Offset: 0x00142C8D
		protected override void Start()
		{
			base.Start();
			this.InitializeSaveable();
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x0003CEED File Offset: 0x0003B0ED
		public virtual string GetSaveString()
		{
			return string.Empty;
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x00144A9C File Offset: 0x00142C9C
		public virtual List<string> WriteData(string parentFolderPath)
		{
			List<string> list = new List<string>();
			string containerFolder = ((ISaveable)this).GetContainerFolder(parentFolderPath);
			for (int i = 0; i < ShopInterface.AllShops.Count; i++)
			{
				if (!(ShopInterface.AllShops[i] == null) && ShopInterface.AllShops[i].ShouldSave())
				{
					new SaveRequest(ShopInterface.AllShops[i], containerFolder);
					list.Add(ShopInterface.AllShops[i].SaveFileName);
				}
			}
			return list;
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x00144B1A File Offset: 0x00142D1A
		[ServerRpc(RequireOwnership = false)]
		public void SendStock(string shopCode, string itemID, int stock)
		{
			this.RpcWriter___Server_SendStock_15643032(shopCode, itemID, stock);
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x00144B30 File Offset: 0x00142D30
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetStock(NetworkConnection conn, string shopCode, string itemID, int stock)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetStock_3509965635(conn, shopCode, itemID, stock);
				this.RpcLogic___SetStock_3509965635(conn, shopCode, itemID, stock);
			}
			else
			{
				this.RpcWriter___Target_SetStock_3509965635(conn, shopCode, itemID, stock);
			}
		}

		// Token: 0x06004D0A RID: 19722 RVA: 0x00144BB4 File Offset: 0x00142DB4
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.UI.Shop.ShopManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.UI.Shop.ShopManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendStock_15643032));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_SetStock_3509965635));
			base.RegisterTargetRpc(2U, new ClientRpcDelegate(this.RpcReader___Target_SetStock_3509965635));
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x00144C1D File Offset: 0x00142E1D
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.UI.Shop.ShopManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.UI.Shop.ShopManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x00144C36 File Offset: 0x00142E36
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x00144C44 File Offset: 0x00142E44
		private void RpcWriter___Server_SendStock_15643032(string shopCode, string itemID, int stock)
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
			writer.WriteString(shopCode);
			writer.WriteString(itemID);
			writer.WriteInt32(stock, AutoPackType.Packed);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x00144D0A File Offset: 0x00142F0A
		public void RpcLogic___SendStock_15643032(string shopCode, string itemID, int stock)
		{
			this.SetStock(null, shopCode, itemID, stock);
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x00144D18 File Offset: 0x00142F18
		private void RpcReader___Server_SendStock_15643032(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string shopCode = PooledReader0.ReadString();
			string itemID = PooledReader0.ReadString();
			int stock = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendStock_15643032(shopCode, itemID, stock);
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x00144D70 File Offset: 0x00142F70
		private void RpcWriter___Observers_SetStock_3509965635(NetworkConnection conn, string shopCode, string itemID, int stock)
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
			writer.WriteString(shopCode);
			writer.WriteString(itemID);
			writer.WriteInt32(stock, AutoPackType.Packed);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x00144E48 File Offset: 0x00143048
		public void RpcLogic___SetStock_3509965635(NetworkConnection conn, string shopCode, string itemID, int stock)
		{
			ShopInterface shopInterface = ShopInterface.AllShops.Find((ShopInterface x) => x.ShopCode == shopCode);
			if (shopInterface == null)
			{
				Debug.LogError("Failed to set stock: Shop not found: " + shopCode);
				return;
			}
			ShopListing listing = shopInterface.GetListing(itemID);
			if (listing == null)
			{
				Debug.LogError("Failed to set stock: Listing not found: " + itemID);
				return;
			}
			listing.SetStock(stock, false);
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x00144EC0 File Offset: 0x001430C0
		private void RpcReader___Observers_SetStock_3509965635(PooledReader PooledReader0, Channel channel)
		{
			string shopCode = PooledReader0.ReadString();
			string itemID = PooledReader0.ReadString();
			int stock = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetStock_3509965635(null, shopCode, itemID, stock);
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x00144F24 File Offset: 0x00143124
		private void RpcWriter___Target_SetStock_3509965635(NetworkConnection conn, string shopCode, string itemID, int stock)
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
			writer.WriteString(shopCode);
			writer.WriteString(itemID);
			writer.WriteInt32(stock, AutoPackType.Packed);
			base.SendTargetRpc(2U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x00144FF8 File Offset: 0x001431F8
		private void RpcReader___Target_SetStock_3509965635(PooledReader PooledReader0, Channel channel)
		{
			string shopCode = PooledReader0.ReadString();
			string itemID = PooledReader0.ReadString();
			int stock = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetStock_3509965635(base.LocalConnection, shopCode, itemID, stock);
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x00145056 File Offset: 0x00143256
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04003A08 RID: 14856
		private ShopManagerLoader loader = new ShopManagerLoader();

		// Token: 0x04003A0C RID: 14860
		private bool dll_Excuted;

		// Token: 0x04003A0D RID: 14861
		private bool dll_Excuted;
	}
}
