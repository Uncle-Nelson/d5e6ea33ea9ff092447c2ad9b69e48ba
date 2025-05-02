using System;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200051A RID: 1306
	public class FacePlayerBehaviour : Behaviour
	{
		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001F13 RID: 7955 RVA: 0x0007F4EB File Offset: 0x0007D6EB
		// (set) Token: 0x06001F14 RID: 7956 RVA: 0x0007F4F3 File Offset: 0x0007D6F3
		public Player Player { get; private set; }

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x0007F4FC File Offset: 0x0007D6FC
		// (set) Token: 0x06001F16 RID: 7958 RVA: 0x0007F504 File Offset: 0x0007D704
		public float Countdown { get; private set; }

		// Token: 0x06001F17 RID: 7959 RVA: 0x0007F510 File Offset: 0x0007D710
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetTarget(NetworkObject player, float countDown = 5f)
		{
			this.RpcWriter___Server_SetTarget_244313061(player, countDown);
			this.RpcLogic___SetTarget_244313061(player, countDown);
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x0007F539 File Offset: 0x0007D739
		[ObserversRpc(RunLocally = true)]
		private void SetTargetLocal(NetworkObject player)
		{
			this.RpcWriter___Observers_SetTargetLocal_3323014238(player);
			this.RpcLogic___SetTargetLocal_3323014238(player);
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x0007F54F File Offset: 0x0007D74F
		protected override void Begin()
		{
			base.Begin();
			base.Npc.Movement.Stop();
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x0007F568 File Offset: 0x0007D768
		public override void BehaviourUpdate()
		{
			base.BehaviourUpdate();
			if (base.Active)
			{
				if (this.Player != null)
				{
					base.Npc.Avatar.LookController.OverrideLookTarget(this.Player.EyePosition, 1, true);
				}
				if (InstanceFinder.IsServer)
				{
					this.Countdown -= Time.deltaTime;
					if (this.Countdown <= 0f)
					{
						base.Disable_Networked(null);
					}
				}
			}
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x00077708 File Offset: 0x00075908
		public override void Disable()
		{
			base.Disable();
			this.End();
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x0007F5E0 File Offset: 0x0007D7E0
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FacePlayerBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FacePlayerBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(15U, new ServerRpcDelegate(this.RpcReader___Server_SetTarget_244313061));
			base.RegisterObserversRpc(16U, new ClientRpcDelegate(this.RpcReader___Observers_SetTargetLocal_3323014238));
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x0007F632 File Offset: 0x0007D832
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FacePlayerBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FacePlayerBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x0007F64B File Offset: 0x0007D84B
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x0007F65C File Offset: 0x0007D85C
		private void RpcWriter___Server_SetTarget_244313061(NetworkObject player, float countDown = 5f)
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
			writer.WriteNetworkObject(player);
			writer.WriteSingle(countDown, AutoPackType.Unpacked);
			base.SendServerRpc(15U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x0007F718 File Offset: 0x0007D918
		public void RpcLogic___SetTarget_244313061(NetworkObject player, float countDown = 5f)
		{
			Console.Log("SetTarget: " + ((player != null) ? player.ToString() : null), null);
			this.Countdown = countDown;
			this.Player = ((player != null) ? player.GetComponent<Player>() : null);
			this.SetTargetLocal(player);
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x0007F768 File Offset: 0x0007D968
		private void RpcReader___Server_SetTarget_244313061(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject player = PooledReader0.ReadNetworkObject();
			float countDown = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetTarget_244313061(player, countDown);
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x0007F7BC File Offset: 0x0007D9BC
		private void RpcWriter___Observers_SetTargetLocal_3323014238(NetworkObject player)
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
			writer.WriteNetworkObject(player);
			base.SendObserversRpc(16U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x0007F872 File Offset: 0x0007DA72
		private void RpcLogic___SetTargetLocal_3323014238(NetworkObject player)
		{
			this.Player = ((player != null) ? player.GetComponent<Player>() : null);
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x0007F88C File Offset: 0x0007DA8C
		private void RpcReader___Observers_SetTargetLocal_3323014238(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject player = PooledReader0.ReadNetworkObject();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetTargetLocal_3323014238(player);
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x0007F8C7 File Offset: 0x0007DAC7
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400185F RID: 6239
		private bool dll_Excuted;

		// Token: 0x04001860 RID: 6240
		private bool dll_Excuted;
	}
}
