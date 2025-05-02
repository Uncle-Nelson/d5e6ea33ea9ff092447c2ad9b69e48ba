using System;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI;
using TMPro;
using UnityEngine;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x02000631 RID: 1585
	public class LabelledSurfaceItem : SurfaceItem
	{
		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060029C5 RID: 10693 RVA: 0x000AC723 File Offset: 0x000AA923
		// (set) Token: 0x060029C6 RID: 10694 RVA: 0x000AC72B File Offset: 0x000AA92B
		public string Message { get; private set; } = "Your Message Here";

		// Token: 0x060029C7 RID: 10695 RVA: 0x000AC734 File Offset: 0x000AA934
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (connection.IsHost)
			{
				return;
			}
			this.SetMessage(connection, this.Message);
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x000AC753 File Offset: 0x000AA953
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMessageToServer(string message)
		{
			this.RpcWriter___Server_SendMessageToServer_3615296227(message);
			this.RpcLogic___SendMessageToServer_3615296227(message);
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x000AC769 File Offset: 0x000AA969
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetMessage(NetworkConnection conn, string message)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetMessage_2971853958(conn, message);
				this.RpcLogic___SetMessage_2971853958(conn, message);
			}
			else
			{
				this.RpcWriter___Target_SetMessage_2971853958(conn, message);
			}
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x000AC79F File Offset: 0x000AA99F
		public void Interacted()
		{
			Singleton<TextInputScreen>.Instance.Open("Edit Sign Message", this.Message, new TextInputScreen.OnSubmit(this.MessageSubmitted), this.MaxCharacters);
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x000AC7C8 File Offset: 0x000AA9C8
		private void MessageSubmitted(string message)
		{
			this.SendMessageToServer(message);
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x000AC7D4 File Offset: 0x000AA9D4
		public override string GetSaveString()
		{
			return new LabelledSurfaceItemData(base.GUID, base.ItemInstance, 0, base.ParentSurface.GUID.ToString(), this.RelativePosition, this.RelativeRotation, this.Message).GetJson(true);
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x000AC840 File Offset: 0x000AAA40
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.EntityFramework.LabelledSurfaceItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.EntityFramework.LabelledSurfaceItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SendMessageToServer_3615296227));
			base.RegisterObserversRpc(9U, new ClientRpcDelegate(this.RpcReader___Observers_SetMessage_2971853958));
			base.RegisterTargetRpc(10U, new ClientRpcDelegate(this.RpcReader___Target_SetMessage_2971853958));
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000AC8A9 File Offset: 0x000AAAA9
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.EntityFramework.LabelledSurfaceItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.EntityFramework.LabelledSurfaceItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000AC8C2 File Offset: 0x000AAAC2
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x000AC8D0 File Offset: 0x000AAAD0
		private void RpcWriter___Server_SendMessageToServer_3615296227(string message)
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
			writer.WriteString(message);
			base.SendServerRpc(8U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000AC977 File Offset: 0x000AAB77
		public void RpcLogic___SendMessageToServer_3615296227(string message)
		{
			this.SetMessage(null, message);
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x000AC984 File Offset: 0x000AAB84
		private void RpcReader___Server_SendMessageToServer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string message = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendMessageToServer_3615296227(message);
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x000AC9C4 File Offset: 0x000AABC4
		private void RpcWriter___Observers_SetMessage_2971853958(NetworkConnection conn, string message)
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
			writer.WriteString(message);
			base.SendObserversRpc(9U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x000ACA7A File Offset: 0x000AAC7A
		public void RpcLogic___SetMessage_2971853958(NetworkConnection conn, string message)
		{
			this.Message = message;
			this.Label.text = message;
			base.HasChanged = true;
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x000ACA98 File Offset: 0x000AAC98
		private void RpcReader___Observers_SetMessage_2971853958(PooledReader PooledReader0, Channel channel)
		{
			string message = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetMessage_2971853958(null, message);
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x000ACAD4 File Offset: 0x000AACD4
		private void RpcWriter___Target_SetMessage_2971853958(NetworkConnection conn, string message)
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
			writer.WriteString(message);
			base.SendTargetRpc(10U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x000ACB8C File Offset: 0x000AAD8C
		private void RpcReader___Target_SetMessage_2971853958(PooledReader PooledReader0, Channel channel)
		{
			string message = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetMessage_2971853958(base.LocalConnection, message);
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x000ACBC3 File Offset: 0x000AADC3
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001EAA RID: 7850
		public int MaxCharacters = 100;

		// Token: 0x04001EAB RID: 7851
		[Header("References")]
		public TextMeshPro Label;

		// Token: 0x04001EAC RID: 7852
		private bool dll_Excuted;

		// Token: 0x04001EAD RID: 7853
		private bool dll_Excuted;
	}
}
