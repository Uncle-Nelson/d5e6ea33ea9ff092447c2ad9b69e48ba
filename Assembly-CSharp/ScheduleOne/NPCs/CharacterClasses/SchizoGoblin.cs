using System;
using FishNet;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004D9 RID: 1241
	public class SchizoGoblin : NPC
	{
		// Token: 0x06001B81 RID: 7041 RVA: 0x00072A2C File Offset: 0x00070C2C
		[ObserversRpc]
		public void SetTargetPlayer(NetworkObject player)
		{
			this.RpcWriter___Observers_SetTargetPlayer_3323014238(player);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x000045B1 File Offset: 0x000027B1
		public void Activate()
		{
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x00072A43 File Offset: 0x00070C43
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SchizoGoblinAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SchizoGoblinAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(35U, new ClientRpcDelegate(this.RpcReader___Observers_SetTargetPlayer_3323014238));
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00072A73 File Offset: 0x00070C73
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SchizoGoblinAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SchizoGoblinAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00072A8C File Offset: 0x00070C8C
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00072A9C File Offset: 0x00070C9C
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
			base.SendObserversRpc(35U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00072B54 File Offset: 0x00070D54
		public void RpcLogic___SetTargetPlayer_3323014238(NetworkObject player)
		{
			this.targetPlayer = player.GetComponent<Player>();
			if (this.targetPlayer.IsLocalPlayer)
			{
				LayerUtility.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("NPC"));
				return;
			}
			LayerUtility.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("Invisible"));
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00072BA8 File Offset: 0x00070DA8
		private void RpcReader___Observers_SetTargetPlayer_3323014238(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject player = PooledReader0.ReadNetworkObject();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetTargetPlayer_3323014238(player);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00072BD9 File Offset: 0x00070DD9
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001707 RID: 5895
		private Player targetPlayer;

		// Token: 0x04001708 RID: 5896
		private bool dll_Excuted;

		// Token: 0x04001709 RID: 5897
		private bool dll_Excuted;
	}
}
