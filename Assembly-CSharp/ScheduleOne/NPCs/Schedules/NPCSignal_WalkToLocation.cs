using System;
using FishNet;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000488 RID: 1160
	public class NPCSignal_WalkToLocation : NPCSignal
	{
		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x0006F1C2 File Offset: 0x0006D3C2
		public new string ActionName
		{
			get
			{
				return "Walk to location";
			}
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x0006F1C9 File Offset: 0x0006D3C9
		public override string GetName()
		{
			return this.ActionName + " (" + this.Destination.name + ")";
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x0006F1EB File Offset: 0x0006D3EB
		public override void Started()
		{
			base.Started();
			base.SetDestination(this.Destination.position, true);
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x0006F205 File Offset: 0x0006D405
		public override void ActiveUpdate()
		{
			base.ActiveUpdate();
			if (!this.npc.Movement.IsMoving && !this.IsAtDestination())
			{
				base.SetDestination(this.Destination.position, true);
			}
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0006E4C8 File Offset: 0x0006C6C8
		public override void LateStarted()
		{
			base.LateStarted();
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0006F239 File Offset: 0x0006D439
		public override void Interrupt()
		{
			base.Interrupt();
			if (this.npc.Movement.IsMoving)
			{
				this.npc.Movement.Stop();
			}
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0006E524 File Offset: 0x0006C724
		public override void Resume()
		{
			base.Resume();
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x0006F263 File Offset: 0x0006D463
		public override void Skipped()
		{
			base.Skipped();
			if (this.WarpIfSkipped)
			{
				this.npc.Movement.Warp(this.Destination.position);
			}
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0006F28E File Offset: 0x0006D48E
		private bool IsAtDestination()
		{
			return Vector3.Distance(this.npc.Movement.FootPosition, this.Destination.position) < this.DestinationThreshold;
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x0006F2B8 File Offset: 0x0006D4B8
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
			base.WalkCallback(result);
			if (!base.IsActive)
			{
				return;
			}
			if (result != NPCMovement.WalkResult.Success)
			{
				Debug.LogWarning("NPC walk to location not successful");
				return;
			}
			this.ReachedDestination();
			this.End();
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0006F2E5 File Offset: 0x0006D4E5
		[ObserversRpc]
		private void ReachedDestination()
		{
			this.RpcWriter___Observers_ReachedDestination_2166136261();
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x0006F307 File Offset: 0x0006D507
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_WalkToLocationAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_WalkToLocationAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_ReachedDestination_2166136261));
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x0006F337 File Offset: 0x0006D537
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_WalkToLocationAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_WalkToLocationAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x0006F350 File Offset: 0x0006D550
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0006F360 File Offset: 0x0006D560
		private void RpcWriter___Observers_ReachedDestination_2166136261()
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
			base.SendObserversRpc(0U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0006F409 File Offset: 0x0006D609
		private void RpcLogic___ReachedDestination_2166136261()
		{
			if (this.FaceDestinationDir)
			{
				this.npc.Movement.FaceDirection(this.Destination.forward, 0.5f);
			}
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x0006F434 File Offset: 0x0006D634
		private void RpcReader___Observers_ReachedDestination_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReachedDestination_2166136261();
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x0006F454 File Offset: 0x0006D654
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400161A RID: 5658
		public Transform Destination;

		// Token: 0x0400161B RID: 5659
		public bool FaceDestinationDir = true;

		// Token: 0x0400161C RID: 5660
		public float DestinationThreshold = 1f;

		// Token: 0x0400161D RID: 5661
		public bool WarpIfSkipped;

		// Token: 0x0400161E RID: 5662
		private bool dll_Excuted;

		// Token: 0x0400161F RID: 5663
		private bool dll_Excuted;
	}
}
