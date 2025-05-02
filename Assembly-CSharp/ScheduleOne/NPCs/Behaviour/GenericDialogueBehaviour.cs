using System;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000520 RID: 1312
	public class GenericDialogueBehaviour : Behaviour
	{
		// Token: 0x06001F60 RID: 8032 RVA: 0x000807E0 File Offset: 0x0007E9E0
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendTargetPlayer(NetworkObject player)
		{
			this.RpcWriter___Server_SendTargetPlayer_3323014238(player);
			this.RpcLogic___SendTargetPlayer_3323014238(player);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x000807F8 File Offset: 0x0007E9F8
		[ObserversRpc(RunLocally = true)]
		private void SetTargetPlayer(NetworkObject player)
		{
			this.RpcWriter___Observers_SetTargetPlayer_3323014238(player);
			this.RpcLogic___SetTargetPlayer_3323014238(player);
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x00080819 File Offset: 0x0007EA19
		public override void Enable()
		{
			base.Enable();
			base.beh.Update();
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00077708 File Offset: 0x00075908
		public override void Disable()
		{
			base.Disable();
			this.End();
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x0008082C File Offset: 0x0007EA2C
		protected override void Begin()
		{
			base.Begin();
			if (base.Npc.Movement.IsMoving)
			{
				base.Npc.Movement.Stop();
			}
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00080856 File Offset: 0x0007EA56
		protected override void Resume()
		{
			base.Resume();
			if (base.Npc.Movement.IsMoving)
			{
				base.Npc.Movement.Stop();
			}
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x00080880 File Offset: 0x0007EA80
		protected override void End()
		{
			base.End();
			base.Npc.Movement.ResumeMovement();
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00080898 File Offset: 0x0007EA98
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (base.Npc.Movement.IsMoving)
			{
				base.Npc.Movement.Stop();
			}
			if (!base.Npc.Movement.FaceDirectionInProgress && base.Npc.Avatar.Anim.TimeSinceSitEnd >= 0.5f)
			{
				float num;
				Player closestPlayer = Player.GetClosestPlayer(base.transform.position, out num, null);
				if (closestPlayer == null)
				{
					return;
				}
				Vector3 vector = closestPlayer.transform.position - base.Npc.transform.position;
				vector.y = 0f;
				if (Vector3.Angle(base.Npc.transform.forward, vector) > 10f)
				{
					base.Npc.Movement.FaceDirection(vector, 0.5f);
				}
			}
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x00080984 File Offset: 0x0007EB84
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.GenericDialogueBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.GenericDialogueBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(15U, new ServerRpcDelegate(this.RpcReader___Server_SendTargetPlayer_3323014238));
			base.RegisterObserversRpc(16U, new ClientRpcDelegate(this.RpcReader___Observers_SetTargetPlayer_3323014238));
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x000809D6 File Offset: 0x0007EBD6
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.GenericDialogueBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.GenericDialogueBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x000809EF File Offset: 0x0007EBEF
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x00080A00 File Offset: 0x0007EC00
		private void RpcWriter___Server_SendTargetPlayer_3323014238(NetworkObject player)
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
			base.SendServerRpc(15U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x00080AA7 File Offset: 0x0007ECA7
		public void RpcLogic___SendTargetPlayer_3323014238(NetworkObject player)
		{
			this.SetTargetPlayer(player);
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00080AB0 File Offset: 0x0007ECB0
		private void RpcReader___Server_SendTargetPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject player = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendTargetPlayer_3323014238(player);
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x00080AF0 File Offset: 0x0007ECF0
		private void RpcWriter___Observers_SetTargetPlayer_3323014238(NetworkObject player)
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

		// Token: 0x06001F70 RID: 8048 RVA: 0x00080BA8 File Offset: 0x0007EDA8
		private void RpcLogic___SetTargetPlayer_3323014238(NetworkObject player)
		{
			if (Singleton<DialogueCanvas>.Instance.isActive && this.targetPlayer != null && this.targetPlayer.Owner.IsLocalClient && player != null && !player.Owner.IsLocalClient)
			{
				Singleton<GameInput>.Instance.ExitAll();
			}
			if (player != null)
			{
				this.targetPlayer = player.GetComponent<Player>();
				return;
			}
			this.targetPlayer = null;
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x00080C20 File Offset: 0x0007EE20
		private void RpcReader___Observers_SetTargetPlayer_3323014238(PooledReader PooledReader0, Channel channel)
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
			this.RpcLogic___SetTargetPlayer_3323014238(player);
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00080C5B File Offset: 0x0007EE5B
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400187E RID: 6270
		private Player targetPlayer;

		// Token: 0x0400187F RID: 6271
		private bool dll_Excuted;

		// Token: 0x04001880 RID: 6272
		private bool dll_Excuted;
	}
}
