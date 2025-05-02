using System;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x020004E6 RID: 1254
	public class Behaviour : NetworkBehaviour
	{
		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x000735BE File Offset: 0x000717BE
		// (set) Token: 0x06001BDF RID: 7135 RVA: 0x000735C6 File Offset: 0x000717C6
		public bool Enabled { get; protected set; }

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x000735CF File Offset: 0x000717CF
		// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x000735D7 File Offset: 0x000717D7
		public bool Started { get; private set; }

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x000735E0 File Offset: 0x000717E0
		// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x000735E8 File Offset: 0x000717E8
		public bool Active { get; private set; }

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x000735F1 File Offset: 0x000717F1
		// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x000735F9 File Offset: 0x000717F9
		public NPCBehaviour beh { get; private set; }

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x00073602 File Offset: 0x00071802
		public NPC Npc
		{
			get
			{
				return this.beh.Npc;
			}
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0007360F File Offset: 0x0007180F
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Behaviour.Behaviour_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x00073623 File Offset: 0x00071823
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (connection.IsHost)
			{
				return;
			}
			if (this.Enabled)
			{
				this.Enable_Networked(connection);
				return;
			}
			this.Disable_Networked(connection);
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x0007364C File Offset: 0x0007184C
		protected override void OnValidate()
		{
			base.OnValidate();
			this.UpdateGameObjectName();
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x0007365C File Offset: 0x0007185C
		public virtual void Enable()
		{
			if (this.Npc.behaviour.DEBUG_MODE)
			{
				Debug.Log(this.Name + " enabled");
			}
			this.Enabled = true;
			if (this.onEnable != null)
			{
				this.onEnable.Invoke();
			}
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x000736AA File Offset: 0x000718AA
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendEnable()
		{
			this.RpcWriter___Server_SendEnable_2166136261();
			this.RpcLogic___SendEnable_2166136261();
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x000736B8 File Offset: 0x000718B8
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void Enable_Networked(NetworkConnection conn)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_Enable_Networked_328543758(conn);
				this.RpcLogic___Enable_Networked_328543758(conn);
			}
			else
			{
				this.RpcWriter___Target_Enable_Networked_328543758(conn);
			}
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x000736E4 File Offset: 0x000718E4
		public virtual void Disable()
		{
			if (this.Npc.behaviour.DEBUG_MODE)
			{
				Debug.Log(this.Name + " disabled");
			}
			this.Enabled = false;
			this.Started = false;
			if (this.Active)
			{
				this.End();
			}
			if (this.onDisable != null)
			{
				this.onDisable.Invoke();
			}
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00073747 File Offset: 0x00071947
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendDisable()
		{
			this.RpcWriter___Server_SendDisable_2166136261();
			this.RpcLogic___SendDisable_2166136261();
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00073755 File Offset: 0x00071955
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void Disable_Networked(NetworkConnection conn)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_Disable_Networked_328543758(conn);
				this.RpcLogic___Disable_Networked_328543758(conn);
			}
			else
			{
				this.RpcWriter___Target_Disable_Networked_328543758(conn);
			}
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00073780 File Offset: 0x00071980
		private void UpdateGameObjectName()
		{
			if (base.gameObject == null)
			{
				return;
			}
			base.gameObject.name = this.Name + (this.Active ? " (Active)" : " (Inactive)");
			if (!this.Active)
			{
				base.gameObject.name = base.gameObject.name + (this.Enabled ? " (Enabled)" : " (Disabled)");
			}
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x000737FD File Offset: 0x000719FD
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void Begin_Networked(NetworkConnection conn)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_Begin_Networked_328543758(conn);
				this.RpcLogic___Begin_Networked_328543758(conn);
			}
			else
			{
				this.RpcWriter___Target_Begin_Networked_328543758(conn);
			}
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00073828 File Offset: 0x00071A28
		protected virtual void Begin()
		{
			if (this.beh.DEBUG_MODE)
			{
				Console.Log("Behaviour (" + this.Name + ") started", null);
			}
			this.Started = true;
			this.Active = true;
			this.beh.activeBehaviour = this;
			this.UpdateGameObjectName();
			if (this.onBegin != null)
			{
				this.onBegin.Invoke();
			}
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00073890 File Offset: 0x00071A90
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendEnd()
		{
			this.RpcWriter___Server_SendEnd_2166136261();
			this.RpcLogic___SendEnd_2166136261();
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0007389E File Offset: 0x00071A9E
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void End_Networked(NetworkConnection conn)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_End_Networked_328543758(conn);
				this.RpcLogic___End_Networked_328543758(conn);
			}
			else
			{
				this.RpcWriter___Target_End_Networked_328543758(conn);
			}
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x000738C8 File Offset: 0x00071AC8
		protected virtual void End()
		{
			if (this.beh.DEBUG_MODE)
			{
				Console.Log("Behaviour (" + this.Name + ") ended", null);
			}
			this.Active = false;
			this.beh.activeBehaviour = null;
			this.UpdateGameObjectName();
			if (this.onEnd != null)
			{
				this.onEnd.Invoke();
			}
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00073929 File Offset: 0x00071B29
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void Pause_Networked(NetworkConnection conn)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_Pause_Networked_328543758(conn);
				this.RpcLogic___Pause_Networked_328543758(conn);
			}
			else
			{
				this.RpcWriter___Target_Pause_Networked_328543758(conn);
			}
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00073953 File Offset: 0x00071B53
		protected virtual void Pause()
		{
			if (this.beh.DEBUG_MODE)
			{
				Console.Log("Behaviour (" + this.Name + ") paused", null);
			}
			this.Active = false;
			this.UpdateGameObjectName();
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0007398A File Offset: 0x00071B8A
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void Resume_Networked(NetworkConnection conn)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_Resume_Networked_328543758(conn);
				this.RpcLogic___Resume_Networked_328543758(conn);
			}
			else
			{
				this.RpcWriter___Target_Resume_Networked_328543758(conn);
			}
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x000739B4 File Offset: 0x00071BB4
		protected virtual void Resume()
		{
			if (this.beh.DEBUG_MODE)
			{
				Console.Log("Behaviour (" + this.Name + ") resumed", null);
			}
			this.Active = true;
			this.beh.activeBehaviour = this;
			this.UpdateGameObjectName();
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void BehaviourUpdate()
		{
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void BehaviourLateUpdate()
		{
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void ActiveMinPass()
		{
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00073A02 File Offset: 0x00071C02
		protected void SetPriority(int p)
		{
			this.Priority = p;
			this.beh.SortBehaviourStack();
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00073A16 File Offset: 0x00071C16
		protected void SetDestination(ITransitEntity transitEntity, bool teleportIfFail = true)
		{
			this.SetDestination(NavMeshUtility.GetAccessPoint(transitEntity, this.Npc).position, teleportIfFail);
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x00073A30 File Offset: 0x00071C30
		protected void SetDestination(Vector3 position, bool teleportIfFail = true)
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (teleportIfFail && this.consecutivePathingFailures >= 5 && !this.Npc.Movement.CanGetTo(position, 1f))
			{
				Console.LogWarning(this.Npc.fullName + " too many pathing failures. Warping to " + position.ToString(), null);
				this.Npc.Movement.Warp(position);
				this.WalkCallback(NPCMovement.WalkResult.Success);
			}
			this.Npc.Movement.SetDestination(position, new Action<NPCMovement.WalkResult>(this.WalkCallback), 1f, 0.1f);
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x00073AD4 File Offset: 0x00071CD4
		protected virtual void WalkCallback(NPCMovement.WalkResult result)
		{
			if (!this.Active)
			{
				return;
			}
			if (result == NPCMovement.WalkResult.Failed)
			{
				this.consecutivePathingFailures++;
			}
			else
			{
				this.consecutivePathingFailures = 0;
			}
			if (this.beh.DEBUG_MODE)
			{
				Console.Log("Walk callback result: " + result.ToString(), null);
			}
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00073B58 File Offset: 0x00071D58
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BehaviourAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendEnable_2166136261));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_Enable_Networked_328543758));
			base.RegisterTargetRpc(2U, new ClientRpcDelegate(this.RpcReader___Target_Enable_Networked_328543758));
			base.RegisterServerRpc(3U, new ServerRpcDelegate(this.RpcReader___Server_SendDisable_2166136261));
			base.RegisterObserversRpc(4U, new ClientRpcDelegate(this.RpcReader___Observers_Disable_Networked_328543758));
			base.RegisterTargetRpc(5U, new ClientRpcDelegate(this.RpcReader___Target_Disable_Networked_328543758));
			base.RegisterObserversRpc(6U, new ClientRpcDelegate(this.RpcReader___Observers_Begin_Networked_328543758));
			base.RegisterTargetRpc(7U, new ClientRpcDelegate(this.RpcReader___Target_Begin_Networked_328543758));
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SendEnd_2166136261));
			base.RegisterObserversRpc(9U, new ClientRpcDelegate(this.RpcReader___Observers_End_Networked_328543758));
			base.RegisterTargetRpc(10U, new ClientRpcDelegate(this.RpcReader___Target_End_Networked_328543758));
			base.RegisterObserversRpc(11U, new ClientRpcDelegate(this.RpcReader___Observers_Pause_Networked_328543758));
			base.RegisterTargetRpc(12U, new ClientRpcDelegate(this.RpcReader___Target_Pause_Networked_328543758));
			base.RegisterObserversRpc(13U, new ClientRpcDelegate(this.RpcReader___Observers_Resume_Networked_328543758));
			base.RegisterTargetRpc(14U, new ClientRpcDelegate(this.RpcReader___Target_Resume_Networked_328543758));
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00073CCF File Offset: 0x00071ECF
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BehaviourAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00073CE2 File Offset: 0x00071EE2
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00073CF0 File Offset: 0x00071EF0
		private void RpcWriter___Server_SendEnable_2166136261()
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

		// Token: 0x06001C06 RID: 7174 RVA: 0x00073D8A File Offset: 0x00071F8A
		public void RpcLogic___SendEnable_2166136261()
		{
			this.Enable_Networked(null);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00073D94 File Offset: 0x00071F94
		private void RpcReader___Server_SendEnable_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendEnable_2166136261();
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00073DC4 File Offset: 0x00071FC4
		private void RpcWriter___Observers_Enable_Networked_328543758(NetworkConnection conn)
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
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00073E6D File Offset: 0x0007206D
		public void RpcLogic___Enable_Networked_328543758(NetworkConnection conn)
		{
			this.Enable();
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00073E78 File Offset: 0x00072078
		private void RpcReader___Observers_Enable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Enable_Networked_328543758(null);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00073EA4 File Offset: 0x000720A4
		private void RpcWriter___Target_Enable_Networked_328543758(NetworkConnection conn)
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
			base.SendTargetRpc(2U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00073F4C File Offset: 0x0007214C
		private void RpcReader___Target_Enable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Enable_Networked_328543758(base.LocalConnection);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00073F74 File Offset: 0x00072174
		private void RpcWriter___Server_SendDisable_2166136261()
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

		// Token: 0x06001C0E RID: 7182 RVA: 0x0007400E File Offset: 0x0007220E
		public void RpcLogic___SendDisable_2166136261()
		{
			this.Disable_Networked(null);
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00074018 File Offset: 0x00072218
		private void RpcReader___Server_SendDisable_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendDisable_2166136261();
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00074048 File Offset: 0x00072248
		private void RpcWriter___Observers_Disable_Networked_328543758(NetworkConnection conn)
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

		// Token: 0x06001C11 RID: 7185 RVA: 0x000740F1 File Offset: 0x000722F1
		public void RpcLogic___Disable_Networked_328543758(NetworkConnection conn)
		{
			this.Disable();
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x000740FC File Offset: 0x000722FC
		private void RpcReader___Observers_Disable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Disable_Networked_328543758(null);
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x00074128 File Offset: 0x00072328
		private void RpcWriter___Target_Disable_Networked_328543758(NetworkConnection conn)
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
			base.SendTargetRpc(5U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000741D0 File Offset: 0x000723D0
		private void RpcReader___Target_Disable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Disable_Networked_328543758(base.LocalConnection);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x000741F8 File Offset: 0x000723F8
		private void RpcWriter___Observers_Begin_Networked_328543758(NetworkConnection conn)
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
			base.SendObserversRpc(6U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x000742A1 File Offset: 0x000724A1
		public void RpcLogic___Begin_Networked_328543758(NetworkConnection conn)
		{
			this.Begin();
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x000742AC File Offset: 0x000724AC
		private void RpcReader___Observers_Begin_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Begin_Networked_328543758(null);
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x000742D8 File Offset: 0x000724D8
		private void RpcWriter___Target_Begin_Networked_328543758(NetworkConnection conn)
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
			base.SendTargetRpc(7U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00074380 File Offset: 0x00072580
		private void RpcReader___Target_Begin_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Begin_Networked_328543758(base.LocalConnection);
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x000743A8 File Offset: 0x000725A8
		private void RpcWriter___Server_SendEnd_2166136261()
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
			base.SendServerRpc(8U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00074442 File Offset: 0x00072642
		public void RpcLogic___SendEnd_2166136261()
		{
			this.End_Networked(null);
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0007444C File Offset: 0x0007264C
		private void RpcReader___Server_SendEnd_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendEnd_2166136261();
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0007447C File Offset: 0x0007267C
		private void RpcWriter___Observers_End_Networked_328543758(NetworkConnection conn)
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
			base.SendObserversRpc(9U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00074525 File Offset: 0x00072725
		public void RpcLogic___End_Networked_328543758(NetworkConnection conn)
		{
			this.End();
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00074530 File Offset: 0x00072730
		private void RpcReader___Observers_End_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___End_Networked_328543758(null);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x0007455C File Offset: 0x0007275C
		private void RpcWriter___Target_End_Networked_328543758(NetworkConnection conn)
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
			base.SendTargetRpc(10U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00074604 File Offset: 0x00072804
		private void RpcReader___Target_End_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___End_Networked_328543758(base.LocalConnection);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0007462C File Offset: 0x0007282C
		private void RpcWriter___Observers_Pause_Networked_328543758(NetworkConnection conn)
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
			base.SendObserversRpc(11U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x000746D5 File Offset: 0x000728D5
		public void RpcLogic___Pause_Networked_328543758(NetworkConnection conn)
		{
			this.Pause();
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x000746E0 File Offset: 0x000728E0
		private void RpcReader___Observers_Pause_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Pause_Networked_328543758(null);
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0007470C File Offset: 0x0007290C
		private void RpcWriter___Target_Pause_Networked_328543758(NetworkConnection conn)
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
			base.SendTargetRpc(12U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x000747B4 File Offset: 0x000729B4
		private void RpcReader___Target_Pause_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Pause_Networked_328543758(base.LocalConnection);
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x000747DC File Offset: 0x000729DC
		private void RpcWriter___Observers_Resume_Networked_328543758(NetworkConnection conn)
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
			base.SendObserversRpc(13U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00074885 File Offset: 0x00072A85
		public void RpcLogic___Resume_Networked_328543758(NetworkConnection conn)
		{
			this.Resume();
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x00074890 File Offset: 0x00072A90
		private void RpcReader___Observers_Resume_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Resume_Networked_328543758(null);
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x000748BC File Offset: 0x00072ABC
		private void RpcWriter___Target_Resume_Networked_328543758(NetworkConnection conn)
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
			base.SendTargetRpc(14U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x00074964 File Offset: 0x00072B64
		private void RpcReader___Target_Resume_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Resume_Networked_328543758(base.LocalConnection);
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x0007498A File Offset: 0x00072B8A
		protected virtual void dll()
		{
			this.beh = base.GetComponentInParent<NPCBehaviour>();
			this.Enabled = this.EnabledOnAwake;
		}

		// Token: 0x0400172E RID: 5934
		public const int MAX_CONSECUTIVE_PATHING_FAILURES = 5;

		// Token: 0x0400172F RID: 5935
		public bool EnabledOnAwake;

		// Token: 0x04001731 RID: 5937
		[Header("Settings")]
		public string Name = "Behaviour";

		// Token: 0x04001732 RID: 5938
		[Tooltip("Behaviour priority; higher = takes priority over lower number behaviour")]
		public int Priority;

		// Token: 0x04001736 RID: 5942
		public UnityEvent onEnable = new UnityEvent();

		// Token: 0x04001737 RID: 5943
		public UnityEvent onDisable = new UnityEvent();

		// Token: 0x04001738 RID: 5944
		public UnityEvent onBegin;

		// Token: 0x04001739 RID: 5945
		public UnityEvent onEnd;

		// Token: 0x0400173A RID: 5946
		protected int consecutivePathingFailures;

		// Token: 0x0400173B RID: 5947
		private bool dll_Excuted;

		// Token: 0x0400173C RID: 5948
		private bool dll_Excuted;
	}
}
