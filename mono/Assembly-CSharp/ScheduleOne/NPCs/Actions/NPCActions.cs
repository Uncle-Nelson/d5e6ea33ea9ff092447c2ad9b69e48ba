using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Law;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Actions
{
	// Token: 0x02000498 RID: 1176
	public class NPCActions : NetworkBehaviour
	{
		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x0007084D File Offset: 0x0006EA4D
		protected NPCBehaviour behaviour
		{
			get
			{
				return this.npc.behaviour;
			}
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0007085A File Offset: 0x0006EA5A
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Actions.NPCActions_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0007086E File Offset: 0x0006EA6E
		public void Cower()
		{
			this.behaviour.GetBehaviour("Cowering").Enable_Networked(null);
			base.StartCoroutine(this.<Cower>g__Wait|4_0());
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00070894 File Offset: 0x0006EA94
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CallPolice_Networked(Player player)
		{
			this.RpcWriter___Server_CallPolice_Networked_1385486242(player);
			this.RpcLogic___CallPolice_Networked_1385486242(player);
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x000708B5 File Offset: 0x0006EAB5
		public void SetCallPoliceBehaviourCrime(Crime crime)
		{
			this.npc.behaviour.CallPoliceBehaviour.ReportedCrime = crime;
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x000045B1 File Offset: 0x000027B1
		public void FacePlayer(Player player)
		{
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x000708CD File Offset: 0x0006EACD
		[CompilerGenerated]
		private IEnumerator <Cower>g__Wait|4_0()
		{
			yield return new WaitForSeconds(10f);
			this.behaviour.GetBehaviour("Cowering").Disable_Networked(null);
			yield break;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x000708DC File Offset: 0x0006EADC
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Actions.NPCActionsAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Actions.NPCActionsAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_CallPolice_Networked_1385486242));
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00070906 File Offset: 0x0006EB06
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Actions.NPCActionsAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Actions.NPCActionsAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x00070919 File Offset: 0x0006EB19
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x00070928 File Offset: 0x0006EB28
		private void RpcWriter___Server_CallPolice_Networked_1385486242(Player player)
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
			writer.Write___ScheduleOne.PlayerScripts.PlayerFishNet.Serializing.Generated(player);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x000709D0 File Offset: 0x0006EBD0
		public void RpcLogic___CallPolice_Networked_1385486242(Player player)
		{
			if (NetworkSingleton<GameManager>.Instance.IsTutorial)
			{
				return;
			}
			if (!this.npc.IsConscious)
			{
				return;
			}
			Console.Log(this.npc.fullName + " is calling the police on " + player.PlayerName, null);
			if (player.CrimeData.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.None)
			{
				Console.LogWarning("Player is already being pursued, ignoring call police request.", null);
				return;
			}
			this.npc.behaviour.CallPoliceBehaviour.Target = player;
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			this.npc.behaviour.CallPoliceBehaviour.Enable_Networked(null);
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00070A68 File Offset: 0x0006EC68
		private void RpcReader___Server_CallPolice_Networked_1385486242(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			Player player = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.PlayerScripts.PlayerFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___CallPolice_Networked_1385486242(player);
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00070AA6 File Offset: 0x0006ECA6
		protected virtual void dll()
		{
			this.npc = base.GetComponentInParent<NPC>();
		}

		// Token: 0x0400165E RID: 5726
		private NPC npc;

		// Token: 0x0400165F RID: 5727
		private bool dll_Excuted;

		// Token: 0x04001660 RID: 5728
		private bool dll_Excuted;
	}
}
