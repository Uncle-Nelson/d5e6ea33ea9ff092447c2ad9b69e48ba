using System;
using System.Collections.Generic;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Misc
{
	// Token: 0x02000C0A RID: 3082
	public class ModularSwitch : NetworkBehaviour
	{
		// Token: 0x060056A3 RID: 22179 RVA: 0x0016C42C File Offset: 0x0016A62C
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Misc.ModularSwitch_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x0016C44B File Offset: 0x0016A64B
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			this.SetIsOn(connection, this.isOn);
		}

		// Token: 0x060056A5 RID: 22181 RVA: 0x0016C464 File Offset: 0x0016A664
		protected virtual void LateUpdate()
		{
			if (this.isOn)
			{
				this.button.localEulerAngles = new Vector3(-7f, 0f, 0f);
				return;
			}
			this.button.localEulerAngles = new Vector3(7f, 0f, 0f);
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x0016C4B8 File Offset: 0x0016A6B8
		public void Hovered()
		{
			if (this.isOn)
			{
				this.intObj.SetMessage("Switch off");
				return;
			}
			this.intObj.SetMessage("Switch on");
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x0016C4E3 File Offset: 0x0016A6E3
		public void Interacted()
		{
			if (this.isOn)
			{
				this.SendIsOn(false);
				return;
			}
			this.SendIsOn(true);
		}

		// Token: 0x060056A8 RID: 22184 RVA: 0x0016C4FC File Offset: 0x0016A6FC
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendIsOn(bool isOn)
		{
			this.RpcWriter___Server_SendIsOn_1140765316(isOn);
			this.RpcLogic___SendIsOn_1140765316(isOn);
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x0016C512 File Offset: 0x0016A712
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetIsOn(NetworkConnection conn, bool isOn)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetIsOn_214505783(conn, isOn);
				this.RpcLogic___SetIsOn_214505783(conn, isOn);
			}
			else
			{
				this.RpcWriter___Target_SetIsOn_214505783(conn, isOn);
			}
		}

		// Token: 0x060056AA RID: 22186 RVA: 0x0016C548 File Offset: 0x0016A748
		public void SwitchOn()
		{
			if (this.isOn)
			{
				return;
			}
			this.isOn = true;
			if (this.switchedOn != null)
			{
				this.switchedOn.Invoke();
			}
			if (this.onToggled != null)
			{
				this.onToggled(this.isOn);
			}
			for (int i = 0; i < this.SwitchesToSyncWith.Count; i++)
			{
				this.SwitchesToSyncWith[i].SwitchOn();
			}
			this.OnAudio.Play();
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x0016C5C4 File Offset: 0x0016A7C4
		public void SwitchOff()
		{
			if (!this.isOn)
			{
				return;
			}
			this.isOn = false;
			if (this.switchedOff != null)
			{
				this.switchedOff.Invoke();
			}
			if (this.onToggled != null)
			{
				this.onToggled(this.isOn);
			}
			for (int i = 0; i < this.SwitchesToSyncWith.Count; i++)
			{
				this.SwitchesToSyncWith[i].SwitchOff();
			}
			this.OffAudio.Play();
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x0016C654 File Offset: 0x0016A854
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Misc.ModularSwitchAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Misc.ModularSwitchAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendIsOn_1140765316));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_SetIsOn_214505783));
			base.RegisterTargetRpc(2U, new ClientRpcDelegate(this.RpcReader___Target_SetIsOn_214505783));
		}

		// Token: 0x060056AE RID: 22190 RVA: 0x0016C6B7 File Offset: 0x0016A8B7
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Misc.ModularSwitchAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Misc.ModularSwitchAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x0016C6CA File Offset: 0x0016A8CA
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x0016C6D8 File Offset: 0x0016A8D8
		private void RpcWriter___Server_SendIsOn_1140765316(bool isOn)
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
			writer.WriteBoolean(isOn);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x0016C77F File Offset: 0x0016A97F
		private void RpcLogic___SendIsOn_1140765316(bool isOn)
		{
			this.SetIsOn(null, isOn);
		}

		// Token: 0x060056B2 RID: 22194 RVA: 0x0016C78C File Offset: 0x0016A98C
		private void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			bool flag = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendIsOn_1140765316(flag);
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x0016C7CC File Offset: 0x0016A9CC
		private void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool isOn)
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
			writer.WriteBoolean(isOn);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x0016C882 File Offset: 0x0016AA82
		private void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
			if (isOn)
			{
				this.SwitchOn();
				return;
			}
			this.SwitchOff();
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x0016C894 File Offset: 0x0016AA94
		private void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
			bool flag = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetIsOn_214505783(null, flag);
		}

		// Token: 0x060056B6 RID: 22198 RVA: 0x0016C8D0 File Offset: 0x0016AAD0
		private void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool isOn)
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
			writer.WriteBoolean(isOn);
			base.SendTargetRpc(2U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x0016C988 File Offset: 0x0016AB88
		private void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
			bool flag = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetIsOn_214505783(base.LocalConnection, flag);
		}

		// Token: 0x060056B8 RID: 22200 RVA: 0x0016C9C0 File Offset: 0x0016ABC0
		protected virtual void dll()
		{
			for (int i = 0; i < this.SwitchesToSyncWith.Count; i++)
			{
				if (!this.SwitchesToSyncWith[i].SwitchesToSyncWith.Contains(this))
				{
					this.SwitchesToSyncWith[i].SwitchesToSyncWith.Add(this);
				}
			}
		}

		// Token: 0x04004005 RID: 16389
		public bool isOn;

		// Token: 0x04004006 RID: 16390
		[Header("References")]
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x04004007 RID: 16391
		[SerializeField]
		protected Transform button;

		// Token: 0x04004008 RID: 16392
		public AudioSourceController OnAudio;

		// Token: 0x04004009 RID: 16393
		public AudioSourceController OffAudio;

		// Token: 0x0400400A RID: 16394
		[Header("Settings")]
		[SerializeField]
		protected List<ModularSwitch> SwitchesToSyncWith = new List<ModularSwitch>();

		// Token: 0x0400400B RID: 16395
		public ModularSwitch.ButtonChange onToggled;

		// Token: 0x0400400C RID: 16396
		public UnityEvent switchedOn;

		// Token: 0x0400400D RID: 16397
		public UnityEvent switchedOff;

		// Token: 0x0400400E RID: 16398
		private bool dll_Excuted;

		// Token: 0x0400400F RID: 16399
		private bool dll_Excuted;

		// Token: 0x02000C0B RID: 3083
		// (Invoke) Token: 0x060056BA RID: 22202
		public delegate void ButtonChange(bool isOn);
	}
}
