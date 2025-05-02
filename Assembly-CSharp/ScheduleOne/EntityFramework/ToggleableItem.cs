using System;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Persistence.Datas;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x0200063A RID: 1594
	public class ToggleableItem : GridItem
	{
		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06002A3B RID: 10811 RVA: 0x000AE2AA File Offset: 0x000AC4AA
		// (set) Token: 0x06002A3C RID: 10812 RVA: 0x000AE2B2 File Offset: 0x000AC4B2
		public bool IsOn { get; private set; }

		// Token: 0x06002A3D RID: 10813 RVA: 0x000AE2BC File Offset: 0x000AC4BC
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.EntityFramework.ToggleableItem_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x000AE2DB File Offset: 0x000AC4DB
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (this.IsOn)
			{
				this.SetIsOn(connection, true);
			}
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x000AE2F4 File Offset: 0x000AC4F4
		public void Toggle()
		{
			if (this.IsOn)
			{
				this.TurnOff(true);
				return;
			}
			this.TurnOn(true);
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x000AE310 File Offset: 0x000AC510
		public void TurnOn(bool network = true)
		{
			if (this.IsOn)
			{
				return;
			}
			if (network)
			{
				this.SendIsOn(true);
				return;
			}
			this.IsOn = true;
			if (this.onTurnedOn != null)
			{
				this.onTurnedOn.Invoke();
			}
			if (this.onTurnOnOrOff != null)
			{
				this.onTurnOnOrOff.Invoke();
			}
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x000AE360 File Offset: 0x000AC560
		public void TurnOff(bool network = true)
		{
			if (!this.IsOn)
			{
				return;
			}
			if (network)
			{
				this.SendIsOn(false);
				return;
			}
			this.IsOn = false;
			if (this.onTurnedOff != null)
			{
				this.onTurnedOff.Invoke();
			}
			if (this.onTurnOnOrOff != null)
			{
				this.onTurnOnOrOff.Invoke();
			}
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x000AE3AE File Offset: 0x000AC5AE
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendIsOn(bool on)
		{
			this.RpcWriter___Server_SendIsOn_1140765316(on);
			this.RpcLogic___SendIsOn_1140765316(on);
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x000AE3C4 File Offset: 0x000AC5C4
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetIsOn(NetworkConnection conn, bool on)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetIsOn_214505783(conn, on);
				this.RpcLogic___SetIsOn_214505783(conn, on);
			}
			else
			{
				this.RpcWriter___Target_SetIsOn_214505783(conn, on);
			}
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x000AE3FA File Offset: 0x000AC5FA
		public override string GetSaveString()
		{
			return new ToggleableItemData(base.GUID, base.ItemInstance, 0, base.OwnerGrid, this.OriginCoordinate, this.Rotation, this.IsOn).GetJson(true);
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x000AE434 File Offset: 0x000AC634
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.EntityFramework.ToggleableItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.EntityFramework.ToggleableItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SendIsOn_1140765316));
			base.RegisterObserversRpc(9U, new ClientRpcDelegate(this.RpcReader___Observers_SetIsOn_214505783));
			base.RegisterTargetRpc(10U, new ClientRpcDelegate(this.RpcReader___Target_SetIsOn_214505783));
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x000AE49D File Offset: 0x000AC69D
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.EntityFramework.ToggleableItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.EntityFramework.ToggleableItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x000AE4B6 File Offset: 0x000AC6B6
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x000AE4C4 File Offset: 0x000AC6C4
		private void RpcWriter___Server_SendIsOn_1140765316(bool on)
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
			writer.WriteBoolean(on);
			base.SendServerRpc(8U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x000AE56B File Offset: 0x000AC76B
		private void RpcLogic___SendIsOn_1140765316(bool on)
		{
			base.HasChanged = true;
			this.SetIsOn(null, on);
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x000AE57C File Offset: 0x000AC77C
		private void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			bool on = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendIsOn_1140765316(on);
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x000AE5BC File Offset: 0x000AC7BC
		private void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool on)
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
			writer.WriteBoolean(on);
			base.SendObserversRpc(9U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x000AE672 File Offset: 0x000AC872
		private void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool on)
		{
			if (on)
			{
				this.TurnOn(false);
				return;
			}
			this.TurnOff(false);
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x000AE688 File Offset: 0x000AC888
		private void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
			bool on = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetIsOn_214505783(null, on);
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x000AE6C4 File Offset: 0x000AC8C4
		private void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool on)
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
			writer.WriteBoolean(on);
			base.SendTargetRpc(10U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x000AE77C File Offset: 0x000AC97C
		private void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
			bool on = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetIsOn_214505783(base.LocalConnection, on);
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x000AE7B4 File Offset: 0x000AC9B4
		protected virtual void dll()
		{
			base.Awake();
			switch (this.StartupAction)
			{
			case ToggleableItem.EStartupAction.TurnOn:
				this.TurnOn(true);
				return;
			case ToggleableItem.EStartupAction.TurnOff:
				this.TurnOff(true);
				return;
			case ToggleableItem.EStartupAction.Toggle:
				this.Toggle();
				return;
			default:
				return;
			}
		}

		// Token: 0x04001ED0 RID: 7888
		[Header("Settings")]
		public ToggleableItem.EStartupAction StartupAction;

		// Token: 0x04001ED1 RID: 7889
		public UnityEvent onTurnedOn;

		// Token: 0x04001ED2 RID: 7890
		public UnityEvent onTurnedOff;

		// Token: 0x04001ED3 RID: 7891
		public UnityEvent onTurnOnOrOff;

		// Token: 0x04001ED4 RID: 7892
		private bool dll_Excuted;

		// Token: 0x04001ED5 RID: 7893
		private bool dll_Excuted;

		// Token: 0x0200063B RID: 1595
		public enum EStartupAction
		{
			// Token: 0x04001ED7 RID: 7895
			None,
			// Token: 0x04001ED8 RID: 7896
			TurnOn,
			// Token: 0x04001ED9 RID: 7897
			TurnOff,
			// Token: 0x04001EDA RID: 7898
			Toggle
		}
	}
}
