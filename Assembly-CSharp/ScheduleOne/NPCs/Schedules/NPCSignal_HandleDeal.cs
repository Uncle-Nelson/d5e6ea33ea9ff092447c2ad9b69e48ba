using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.Quests;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000481 RID: 1153
	public class NPCSignal_HandleDeal : NPCSignal
	{
		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x0006DFBE File Offset: 0x0006C1BE
		public new string ActionName
		{
			get
			{
				return "Handle deal";
			}
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0006DFC5 File Offset: 0x0006C1C5
		public void AssignContract(Contract c)
		{
			this.contract = c;
			if (this.contract != null)
			{
				this.customer = c.Customer.GetComponent<Customer>();
			}
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0006DFED File Offset: 0x0006C1ED
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Schedules.NPCSignal_HandleDeal_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x0006E001 File Offset: 0x0006C201
		protected override void OnValidate()
		{
			base.OnValidate();
			this.priority = 10;
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x0006E011 File Offset: 0x0006C211
		public override string GetName()
		{
			return this.ActionName;
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x0006E019 File Offset: 0x0006C219
		public override void Started()
		{
			base.Started();
			base.SetDestination(this.GetStandPos(), true);
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x0006E030 File Offset: 0x0006C230
		public override void MinPassed()
		{
			base.MinPassed();
			if (!base.IsActive)
			{
				return;
			}
			if (this.contract == null || this.contract.QuestState != EQuestState.Active)
			{
				this.End();
				base.gameObject.SetActive(false);
				this.contract = null;
				base.StartedThisCycle = false;
				return;
			}
			if (this.handoverRoutine != null)
			{
				return;
			}
			if (!this.npc.Movement.IsMoving)
			{
				if (this.IsAtDestination())
				{
					if (this.IsCustomerReady())
					{
						this.BeginHandover();
						return;
					}
				}
				else
				{
					base.SetDestination(this.GetStandPos(), true);
				}
			}
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x0006E0C8 File Offset: 0x0006C2C8
		public override void LateStarted()
		{
			base.LateStarted();
			base.SetDestination(this.GetStandPos(), true);
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x0006E0DD File Offset: 0x0006C2DD
		public override void JumpTo()
		{
			base.JumpTo();
			base.SetDestination(this.GetStandPos(), true);
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x0006E0F2 File Offset: 0x0006C2F2
		public override void Interrupt()
		{
			base.Interrupt();
			this.npc.Movement.Stop();
			this.StopHandover();
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x0006E110 File Offset: 0x0006C310
		public override void End()
		{
			base.End();
			this.StopHandover();
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x0006CD14 File Offset: 0x0006AF14
		public override void Skipped()
		{
			base.Skipped();
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x0006E11E File Offset: 0x0006C31E
		private bool IsAtDestination()
		{
			return Vector3.Distance(this.npc.Movement.FootPosition, this.GetStandPos()) < 2f;
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x0006E142 File Offset: 0x0006C342
		private bool IsCustomerReady()
		{
			return this.customer.IsAtDealLocation();
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x0006E14F File Offset: 0x0006C34F
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
			base.WalkCallback(result);
			if (!base.IsActive)
			{
				return;
			}
			if (result != NPCMovement.WalkResult.Success)
			{
				Debug.LogWarning(this.npc.fullName + ": walk to location not successful");
				return;
			}
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x0006E180 File Offset: 0x0006C380
		private void BeginHandover()
		{
			if (this.handoverRoutine != null)
			{
				return;
			}
			this.handoverRoutine = base.StartCoroutine(this.<BeginHandover>g__Routine|20_0());
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x0006E19D File Offset: 0x0006C39D
		private void StopHandover()
		{
			if (this.handoverRoutine != null)
			{
				base.StopCoroutine(this.handoverRoutine);
				this.handoverRoutine = null;
			}
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x0006E1BC File Offset: 0x0006C3BC
		private Vector3 GetStandPos()
		{
			if (this.contract == null)
			{
				return Vector3.zero;
			}
			return this.contract.DeliveryLocation.CustomerStandPoint.position + this.contract.DeliveryLocation.CustomerStandPoint.forward * 1.2f;
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x0006E216 File Offset: 0x0006C416
		private Vector3 GetStandDir()
		{
			return -this.contract.DeliveryLocation.CustomerStandPoint.forward;
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x0006E232 File Offset: 0x0006C432
		[CompilerGenerated]
		private IEnumerator <BeginHandover>g__Routine|20_0()
		{
			this.npc.Movement.FaceDirection(this.GetStandDir(), 0.5f);
			yield return new WaitForSeconds(2f);
			yield return new WaitUntil(() => this.customer.IsAtDealLocation());
			List<ItemInstance> items;
			if (!this.dealer.RemoveContractItems(this.contract, this.customer.CustomerData.Standards.GetCorrespondingQuality(), out items))
			{
				Console.LogWarning("Dealer does not have items for contract. Contract will still be marked as complete.", null);
			}
			bool flag;
			this.customer.OfferDealItems(items, false, out flag);
			this.npc.SetAnimationTrigger("GrabItem");
			this.End();
			base.gameObject.SetActive(false);
			this.contract = null;
			base.StartedThisCycle = false;
			this.handoverRoutine = null;
			yield break;
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x0006E241 File Offset: 0x0006C441
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_HandleDealAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_HandleDealAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0006E25A File Offset: 0x0006C45A
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_HandleDealAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_HandleDealAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x0006E273 File Offset: 0x0006C473
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x0006E281 File Offset: 0x0006C481
		protected virtual void dll()
		{
			base.Awake();
			this.priority = 100;
			this.MaxDuration = 720;
			this.dealer = (this.npc as Dealer);
		}

		// Token: 0x040015FC RID: 5628
		private Dealer dealer;

		// Token: 0x040015FD RID: 5629
		private Contract contract;

		// Token: 0x040015FE RID: 5630
		private Customer customer;

		// Token: 0x040015FF RID: 5631
		private Coroutine handoverRoutine;

		// Token: 0x04001600 RID: 5632
		private bool dll_Excuted;

		// Token: 0x04001601 RID: 5633
		private bool dll_Excuted;
	}
}
