using System;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Interaction
{
	// Token: 0x0200061A RID: 1562
	public class NetworkedInteractableToggleable : NetworkBehaviour
	{
		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060028E8 RID: 10472 RVA: 0x000A8B9D File Offset: 0x000A6D9D
		// (set) Token: 0x060028E9 RID: 10473 RVA: 0x000A8BA5 File Offset: 0x000A6DA5
		public bool IsActivated { get; private set; }

		// Token: 0x060028EA RID: 10474 RVA: 0x000A8BAE File Offset: 0x000A6DAE
		public void Start()
		{
			this.IntObj.onHovered.AddListener(new UnityAction(this.Hovered));
			this.IntObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x000A8BE8 File Offset: 0x000A6DE8
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (this.IsActivated)
			{
				this.SetState(connection, true);
			}
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x000A8C04 File Offset: 0x000A6E04
		public void Hovered()
		{
			if (Time.time - this.lastActivated < this.CoolDown)
			{
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
			this.IntObj.SetMessage(this.IsActivated ? this.DeactivateMessage : this.ActivateMessage);
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x000A8C5F File Offset: 0x000A6E5F
		public void Interacted()
		{
			this.SendToggle();
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x000A8C67 File Offset: 0x000A6E67
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendToggle()
		{
			this.RpcWriter___Server_SendToggle_2166136261();
			this.RpcLogic___SendToggle_2166136261();
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x000A8C78 File Offset: 0x000A6E78
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetState(NetworkConnection conn, bool activated)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetState_214505783(conn, activated);
				this.RpcLogic___SetState_214505783(conn, activated);
			}
			else
			{
				this.RpcWriter___Target_SetState_214505783(conn, activated);
			}
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x000A8CB9 File Offset: 0x000A6EB9
		public void PoliceDetected()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.IsActivated)
			{
				this.SendToggle();
			}
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x000A8D10 File Offset: 0x000A6F10
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Interaction.NetworkedInteractableToggleableAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Interaction.NetworkedInteractableToggleableAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendToggle_2166136261));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_SetState_214505783));
			base.RegisterTargetRpc(2U, new ClientRpcDelegate(this.RpcReader___Target_SetState_214505783));
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x000A8D73 File Offset: 0x000A6F73
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Interaction.NetworkedInteractableToggleableAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Interaction.NetworkedInteractableToggleableAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x000A8D86 File Offset: 0x000A6F86
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x000A8D94 File Offset: 0x000A6F94
		private void RpcWriter___Server_SendToggle_2166136261()
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
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x000A8E2E File Offset: 0x000A702E
		public void RpcLogic___SendToggle_2166136261()
		{
			this.SetState(null, !this.IsActivated);
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x000A8E40 File Offset: 0x000A7040
		private void RpcReader___Server_SendToggle_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendToggle_2166136261();
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x000A8E70 File Offset: 0x000A7070
		private void RpcWriter___Observers_SetState_214505783(NetworkConnection conn, bool activated)
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
			writer.WriteBoolean(activated);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x000A8F28 File Offset: 0x000A7128
		public void RpcLogic___SetState_214505783(NetworkConnection conn, bool activated)
		{
			if (this.IsActivated == activated)
			{
				return;
			}
			this.lastActivated = Time.time;
			this.IsActivated = !this.IsActivated;
			if (this.onToggle != null)
			{
				this.onToggle.Invoke();
			}
			if (this.IsActivated)
			{
				this.onActivate.Invoke();
				return;
			}
			this.onDeactivate.Invoke();
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x000A8F8C File Offset: 0x000A718C
		private void RpcReader___Observers_SetState_214505783(PooledReader PooledReader0, Channel channel)
		{
			bool activated = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetState_214505783(null, activated);
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x000A8FC8 File Offset: 0x000A71C8
		private void RpcWriter___Target_SetState_214505783(NetworkConnection conn, bool activated)
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
			writer.WriteBoolean(activated);
			base.SendTargetRpc(2U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x000A9080 File Offset: 0x000A7280
		private void RpcReader___Target_SetState_214505783(PooledReader PooledReader0, Channel channel)
		{
			bool activated = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetState_214505783(base.LocalConnection, activated);
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x000A8D86 File Offset: 0x000A6F86
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001E10 RID: 7696
		public string ActivateMessage = "Activate";

		// Token: 0x04001E11 RID: 7697
		public string DeactivateMessage = "Deactivate";

		// Token: 0x04001E12 RID: 7698
		public float CoolDown;

		// Token: 0x04001E13 RID: 7699
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04001E14 RID: 7700
		public UnityEvent onToggle = new UnityEvent();

		// Token: 0x04001E15 RID: 7701
		public UnityEvent onActivate = new UnityEvent();

		// Token: 0x04001E16 RID: 7702
		public UnityEvent onDeactivate = new UnityEvent();

		// Token: 0x04001E17 RID: 7703
		private float lastActivated;

		// Token: 0x04001E18 RID: 7704
		private bool dll_Excuted;

		// Token: 0x04001E19 RID: 7705
		private bool dll_Excuted;
	}
}
