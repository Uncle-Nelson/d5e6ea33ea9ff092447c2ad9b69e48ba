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
	// Token: 0x0200063C RID: 1596
	public class ToggleableSurfaceItem : SurfaceItem
	{
		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06002A52 RID: 10834 RVA: 0x000AE7F9 File Offset: 0x000AC9F9
		// (set) Token: 0x06002A53 RID: 10835 RVA: 0x000AE801 File Offset: 0x000ACA01
		public bool IsOn { get; private set; }

		// Token: 0x06002A54 RID: 10836 RVA: 0x000AE80C File Offset: 0x000ACA0C
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.EntityFramework.ToggleableSurfaceItem_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x000AE82B File Offset: 0x000ACA2B
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (this.IsOn)
			{
				this.SetIsOn(connection, true);
			}
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x000AE844 File Offset: 0x000ACA44
		public void Toggle()
		{
			if (this.IsOn)
			{
				this.TurnOff(true);
				return;
			}
			this.TurnOn(true);
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x000AE860 File Offset: 0x000ACA60
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

		// Token: 0x06002A58 RID: 10840 RVA: 0x000AE8B0 File Offset: 0x000ACAB0
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

		// Token: 0x06002A59 RID: 10841 RVA: 0x000AE8FE File Offset: 0x000ACAFE
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendIsOn(bool on)
		{
			this.RpcWriter___Server_SendIsOn_1140765316(on);
			this.RpcLogic___SendIsOn_1140765316(on);
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x000AE914 File Offset: 0x000ACB14
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

		// Token: 0x06002A5B RID: 10843 RVA: 0x000AE94C File Offset: 0x000ACB4C
		public override string GetSaveString()
		{
			return new ToggleableSurfaceItemData(base.GUID, base.ItemInstance, 0, base.ParentSurface.GUID.ToString(), this.RelativePosition, this.RelativeRotation, this.IsOn).GetJson(true);
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x000AE9A4 File Offset: 0x000ACBA4
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.EntityFramework.ToggleableSurfaceItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.EntityFramework.ToggleableSurfaceItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SendIsOn_1140765316));
			base.RegisterObserversRpc(9U, new ClientRpcDelegate(this.RpcReader___Observers_SetIsOn_214505783));
			base.RegisterTargetRpc(10U, new ClientRpcDelegate(this.RpcReader___Target_SetIsOn_214505783));
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x000AEA0D File Offset: 0x000ACC0D
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.EntityFramework.ToggleableSurfaceItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.EntityFramework.ToggleableSurfaceItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x000AEA26 File Offset: 0x000ACC26
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x000AEA34 File Offset: 0x000ACC34
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

		// Token: 0x06002A61 RID: 10849 RVA: 0x000AEADB File Offset: 0x000ACCDB
		private void RpcLogic___SendIsOn_1140765316(bool on)
		{
			base.HasChanged = true;
			this.SetIsOn(null, on);
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x000AEAEC File Offset: 0x000ACCEC
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

		// Token: 0x06002A63 RID: 10851 RVA: 0x000AEB2C File Offset: 0x000ACD2C
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

		// Token: 0x06002A64 RID: 10852 RVA: 0x000AEBE2 File Offset: 0x000ACDE2
		private void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool on)
		{
			if (on)
			{
				this.TurnOn(false);
				return;
			}
			this.TurnOff(false);
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x000AEBF8 File Offset: 0x000ACDF8
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

		// Token: 0x06002A66 RID: 10854 RVA: 0x000AEC34 File Offset: 0x000ACE34
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

		// Token: 0x06002A67 RID: 10855 RVA: 0x000AECEC File Offset: 0x000ACEEC
		private void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
			bool on = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetIsOn_214505783(base.LocalConnection, on);
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x000AED24 File Offset: 0x000ACF24
		protected virtual void dll()
		{
			base.Awake();
			switch (this.StartupAction)
			{
			case ToggleableSurfaceItem.EStartupAction.TurnOn:
				this.TurnOn(true);
				return;
			case ToggleableSurfaceItem.EStartupAction.TurnOff:
				this.TurnOff(true);
				return;
			case ToggleableSurfaceItem.EStartupAction.Toggle:
				this.Toggle();
				return;
			default:
				return;
			}
		}

		// Token: 0x04001EDC RID: 7900
		[Header("Settings")]
		public ToggleableSurfaceItem.EStartupAction StartupAction;

		// Token: 0x04001EDD RID: 7901
		public UnityEvent onTurnedOn;

		// Token: 0x04001EDE RID: 7902
		public UnityEvent onTurnedOff;

		// Token: 0x04001EDF RID: 7903
		public UnityEvent onTurnOnOrOff;

		// Token: 0x04001EE0 RID: 7904
		private bool dll_Excuted;

		// Token: 0x04001EE1 RID: 7905
		private bool dll_Excuted;

		// Token: 0x0200063D RID: 1597
		public enum EStartupAction
		{
			// Token: 0x04001EE3 RID: 7907
			None,
			// Token: 0x04001EE4 RID: 7908
			TurnOn,
			// Token: 0x04001EE5 RID: 7909
			TurnOff,
			// Token: 0x04001EE6 RID: 7910
			Toggle
		}
	}
}
