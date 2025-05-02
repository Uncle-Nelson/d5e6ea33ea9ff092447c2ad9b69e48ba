using System;
using FishNet;
using ScheduleOne.Economy;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000487 RID: 1159
	public class NPCSignal_WaitForDelivery : NPCSignal
	{
		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x0006EEEC File Offset: 0x0006D0EC
		public new string ActionName
		{
			get
			{
				return "Wait for delivery";
			}
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x0006EEF3 File Offset: 0x0006D0F3
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Schedules.NPCSignal_WaitForDelivery_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x0006EF07 File Offset: 0x0006D107
		protected override void OnValidate()
		{
			base.OnValidate();
			this.priority = 100;
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x0006EF17 File Offset: 0x0006D117
		public override string GetName()
		{
			return this.ActionName;
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x0006EF1F File Offset: 0x0006D11F
		public override void Started()
		{
			base.Started();
			base.SetDestination(this.Location.CustomerStandPoint.position, true);
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x0006EF40 File Offset: 0x0006D140
		public override void ActiveMinPassed()
		{
			base.ActiveMinPassed();
			if (this.npc.Movement.IsMoving)
			{
				if (Vector3.Distance(this.npc.Movement.CurrentDestination, this.Location.CustomerStandPoint.position) > 1.5f)
				{
					base.SetDestination(this.Location.CustomerStandPoint.position, true);
				}
				return;
			}
			if (!this.IsAtDestination())
			{
				base.SetDestination(this.Location.CustomerStandPoint.position, true);
				return;
			}
			this.npc.GetComponent<Customer>().SetIsAwaitingDelivery(true);
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x0006EFDA File Offset: 0x0006D1DA
		public override void LateStarted()
		{
			base.LateStarted();
			this.npc.GetComponent<Customer>().SetIsAwaitingDelivery(true);
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			base.SetDestination(this.Location.CustomerStandPoint.position, true);
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x0006F012 File Offset: 0x0006D212
		public override void JumpTo()
		{
			base.JumpTo();
			this.npc.GetComponent<Customer>().SetIsAwaitingDelivery(true);
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			base.SetDestination(this.Location.CustomerStandPoint.position, true);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x0006F04A File Offset: 0x0006D24A
		public override void Interrupt()
		{
			base.Interrupt();
			this.npc.GetComponent<Customer>().SetIsAwaitingDelivery(false);
			this.npc.Movement.Stop();
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x0006F073 File Offset: 0x0006D273
		public override void Resume()
		{
			base.Resume();
			this.npc.GetComponent<Customer>().SetIsAwaitingDelivery(true);
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x0006F08C File Offset: 0x0006D28C
		public override void End()
		{
			this.npc.GetComponent<Customer>().SetIsAwaitingDelivery(false);
			base.StartedThisCycle = false;
			base.End();
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x0006F0AC File Offset: 0x0006D2AC
		public override void Skipped()
		{
			base.Skipped();
			if (InstanceFinder.IsServer)
			{
				this.npc.Movement.Warp(this.Location.CustomerStandPoint.position);
			}
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x0006F0DB File Offset: 0x0006D2DB
		private bool IsAtDestination()
		{
			return Vector3.Distance(this.npc.Movement.FootPosition, this.Location.CustomerStandPoint.position) < 1.5f;
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x0006F10C File Offset: 0x0006D30C
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
			base.WalkCallback(result);
			if (!base.IsActive)
			{
				return;
			}
			if (result != NPCMovement.WalkResult.Success)
			{
				return;
			}
			this.npc.Movement.FaceDirection(this.Location.CustomerStandPoint.forward, 0.5f);
			this.npc.GetComponent<Customer>().SetIsAwaitingDelivery(true);
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x0006F164 File Offset: 0x0006D364
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_WaitForDeliveryAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_WaitForDeliveryAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x0006F17D File Offset: 0x0006D37D
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_WaitForDeliveryAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_WaitForDeliveryAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x0006F196 File Offset: 0x0006D396
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x0006F1A4 File Offset: 0x0006D3A4
		protected virtual void dll()
		{
			base.Awake();
			this.priority = 1000;
			this.MaxDuration = 720;
		}

		// Token: 0x04001616 RID: 5654
		public const float DESTINATION_THRESHOLD = 1.5f;

		// Token: 0x04001617 RID: 5655
		public DeliveryLocation Location;

		// Token: 0x04001618 RID: 5656
		private bool dll_Excuted;

		// Token: 0x04001619 RID: 5657
		private bool dll_Excuted;
	}
}
