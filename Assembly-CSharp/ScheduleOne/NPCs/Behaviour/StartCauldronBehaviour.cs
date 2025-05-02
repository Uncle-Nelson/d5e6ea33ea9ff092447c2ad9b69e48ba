using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200050E RID: 1294
	public class StartCauldronBehaviour : Behaviour
	{
		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x0007CF50 File Offset: 0x0007B150
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x0007CF58 File Offset: 0x0007B158
		public Cauldron Station { get; protected set; }

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0007CF61 File Offset: 0x0007B161
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x0007CF69 File Offset: 0x0007B169
		public bool WorkInProgress { get; protected set; }

		// Token: 0x06001E64 RID: 7780 RVA: 0x0007CF72 File Offset: 0x0007B172
		protected override void Begin()
		{
			base.Begin();
			this.StartWork();
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x0007CF80 File Offset: 0x0007B180
		protected override void Resume()
		{
			base.Resume();
			this.StartWork();
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x0007CF90 File Offset: 0x0007B190
		protected override void Pause()
		{
			base.Pause();
			if (this.WorkInProgress)
			{
				this.StopCauldron();
			}
			if (InstanceFinder.IsServer && this.Station != null && this.Station.NPCUserObject == base.Npc.NetworkObject)
			{
				this.Station.SetNPCUser(null);
			}
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x00077BBF File Offset: 0x00075DBF
		public override void Disable()
		{
			base.Disable();
			if (base.Active)
			{
				this.End();
			}
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x0007CFF0 File Offset: 0x0007B1F0
		protected override void End()
		{
			base.End();
			if (this.WorkInProgress)
			{
				this.StopCauldron();
			}
			if (InstanceFinder.IsServer && this.Station != null && this.Station.NPCUserObject == base.Npc.NetworkObject)
			{
				this.Station.SetNPCUser(null);
			}
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x0007D050 File Offset: 0x0007B250
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.WorkInProgress)
			{
				if (this.IsStationReady(this.Station))
				{
					if (base.Npc.Movement.IsMoving)
					{
						return;
					}
					if (this.IsAtStation())
					{
						this.BeginCauldron();
						return;
					}
					this.GoToStation();
					return;
				}
				else
				{
					base.Disable_Networked(null);
				}
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0007D0B4 File Offset: 0x0007B2B4
		private void StartWork()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.IsStationReady(this.Station))
			{
				Console.LogWarning(base.Npc.fullName + " has no station to work with", null);
				base.Disable_Networked(null);
				return;
			}
			this.Station.SetNPCUser(base.Npc.NetworkObject);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x0007D110 File Offset: 0x0007B310
		public void AssignStation(Cauldron station)
		{
			this.Station = station;
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0007D119 File Offset: 0x0007B319
		public bool IsAtStation()
		{
			return base.Npc.Movement.IsAsCloseAsPossible(this.Station.StandPoint.position, 0.5f);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x0007D140 File Offset: 0x0007B340
		public void GoToStation()
		{
			base.SetDestination(this.Station.StandPoint.position, true);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x0007D15C File Offset: 0x0007B35C
		[ObserversRpc(RunLocally = true)]
		public void BeginCauldron()
		{
			this.RpcWriter___Observers_BeginCauldron_2166136261();
			this.RpcLogic___BeginCauldron_2166136261();
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x0007D178 File Offset: 0x0007B378
		private void StopCauldron()
		{
			if (this.workRoutine != null)
			{
				base.StopCoroutine(this.workRoutine);
			}
			if (InstanceFinder.IsServer && this.Station != null && this.Station.NPCUserObject == base.Npc.NetworkObject)
			{
				this.Station.SetNPCUser(null);
			}
			this.WorkInProgress = false;
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x0007D1E0 File Offset: 0x0007B3E0
		public bool IsStationReady(Cauldron station)
		{
			return !(station == null) && station.GetState() == Cauldron.EState.Ready && (!((IUsable)station).IsInUse || (!(station.PlayerUserObject != null) && !(station.NPCUserObject != base.Npc.NetworkObject))) && base.Npc.Movement.CanGetTo(station.StandPoint.position, 1f);
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x0007D258 File Offset: 0x0007B458
		[CompilerGenerated]
		private IEnumerator <BeginCauldron>g__Package|20_0()
		{
			yield return new WaitForEndOfFrame();
			base.Npc.Avatar.Anim.SetBool("UseChemistryStation", true);
			float packageTime = 15f;
			for (float i = 0f; i < packageTime; i += Time.deltaTime)
			{
				base.Npc.Avatar.LookController.OverrideLookTarget(this.Station.LinkOrigin.position, 0, false);
				yield return new WaitForEndOfFrame();
			}
			base.Npc.Avatar.Anim.SetBool("UseChemistryStation", false);
			if (InstanceFinder.IsServer)
			{
				EQuality quality = this.Station.RemoveIngredients();
				this.Station.StartCookOperation(null, this.Station.CookTime, quality);
			}
			this.WorkInProgress = false;
			this.workRoutine = null;
			yield break;
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x0007D267 File Offset: 0x0007B467
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartCauldronBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartCauldronBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_BeginCauldron_2166136261));
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x0007D297 File Offset: 0x0007B497
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartCauldronBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartCauldronBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0007D2B0 File Offset: 0x0007B4B0
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x0007D2C0 File Offset: 0x0007B4C0
		private void RpcWriter___Observers_BeginCauldron_2166136261()
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
			base.SendObserversRpc(15U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x0007D36C File Offset: 0x0007B56C
		public void RpcLogic___BeginCauldron_2166136261()
		{
			if (this.WorkInProgress)
			{
				return;
			}
			if (this.Station == null)
			{
				return;
			}
			this.WorkInProgress = true;
			base.Npc.Movement.FaceDirection(this.Station.StandPoint.forward, 0.5f);
			this.workRoutine = base.StartCoroutine(this.<BeginCauldron>g__Package|20_0());
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x0007D3D0 File Offset: 0x0007B5D0
		private void RpcReader___Observers_BeginCauldron_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___BeginCauldron_2166136261();
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x0007D3FA File Offset: 0x0007B5FA
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400181C RID: 6172
		public const float START_CAULDRON_TIME = 15f;

		// Token: 0x0400181F RID: 6175
		private Coroutine workRoutine;

		// Token: 0x04001820 RID: 6176
		private bool dll_Excuted;

		// Token: 0x04001821 RID: 6177
		private bool dll_Excuted;
	}
}
