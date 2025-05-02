using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000483 RID: 1155
	public class NPCSignal_UseATM : NPCSignal
	{
		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600194B RID: 6475 RVA: 0x0006E3D8 File Offset: 0x0006C5D8
		public new string ActionName
		{
			get
			{
				return "Use ATM";
			}
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x0006E3DF File Offset: 0x0006C5DF
		public override string GetName()
		{
			return this.ActionName;
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x0006E3E7 File Offset: 0x0006C5E7
		public override void Started()
		{
			base.Started();
			if (this.ATM == null)
			{
				Debug.LogWarning("No ATM found for NPC to use");
				this.End();
				return;
			}
			base.SetDestination(this.ATM.AccessPoint.position, true);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x0006E428 File Offset: 0x0006C628
		public override void ActiveMinPassed()
		{
			base.MinPassed();
			if (this.ATM == null)
			{
				this.End();
				return;
			}
			if (this.purchaseCoroutine != null)
			{
				return;
			}
			if (!this.npc.Movement.IsMoving)
			{
				if (this.IsAtDestination())
				{
					if (this.purchaseCoroutine == null)
					{
						this.Purchase();
						return;
					}
				}
				else
				{
					Debug.DrawLine(this.npc.Movement.FootPosition, this.ATM.AccessPoint.position, Color.red, 1f);
					base.SetDestination(this.ATM.AccessPoint.position, true);
				}
			}
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x0006E4C8 File Offset: 0x0006C6C8
		public override void LateStarted()
		{
			base.LateStarted();
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x0006E4D0 File Offset: 0x0006C6D0
		public override void Interrupt()
		{
			base.Interrupt();
			if (this.npc.Movement.IsMoving)
			{
				this.npc.Movement.Stop();
			}
			if (this.purchaseCoroutine != null)
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.purchaseCoroutine);
				this.purchaseCoroutine = null;
			}
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0006E524 File Offset: 0x0006C724
		public override void Resume()
		{
			base.Resume();
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x0006CD14 File Offset: 0x0006AF14
		public override void Skipped()
		{
			base.Skipped();
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x0006E52C File Offset: 0x0006C72C
		private bool IsAtDestination()
		{
			return !(this.ATM == null) && Vector3.Distance(this.npc.Movement.FootPosition, this.ATM.AccessPoint.position) < 2f;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0006E56A File Offset: 0x0006C76A
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
			this.Purchase();
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x0006E588 File Offset: 0x0006C788
		[ObserversRpc(RunLocally = true)]
		public void Purchase()
		{
			this.RpcWriter___Observers_Purchase_2166136261();
			this.RpcLogic___Purchase_2166136261();
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x0006E5A1 File Offset: 0x0006C7A1
		[CompilerGenerated]
		private IEnumerator <Purchase>g__Purchase|14_0()
		{
			if (this.ATM.IsBroken)
			{
				this.End();
				this.purchaseCoroutine = null;
				yield break;
			}
			yield return new WaitForSeconds(2f);
			this.npc.SetAnimationTrigger_Networked(null, "GrabItem");
			yield return new WaitForSeconds(1f);
			this.End();
			this.purchaseCoroutine = null;
			yield break;
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x0006E5B0 File Offset: 0x0006C7B0
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_UseATMAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_UseATMAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_Purchase_2166136261));
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x0006E5E0 File Offset: 0x0006C7E0
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_UseATMAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_UseATMAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x0006E5F9 File Offset: 0x0006C7F9
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x0006E608 File Offset: 0x0006C808
		private void RpcWriter___Observers_Purchase_2166136261()
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

		// Token: 0x0600195C RID: 6492 RVA: 0x0006E6B4 File Offset: 0x0006C8B4
		public void RpcLogic___Purchase_2166136261()
		{
			if (this.purchaseCoroutine != null)
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.purchaseCoroutine);
			}
			this.npc.Movement.FaceDirection(this.ATM.AccessPoint.forward, 0.5f);
			this.purchaseCoroutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.<Purchase>g__Purchase|14_0());
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x0006E714 File Offset: 0x0006C914
		private void RpcReader___Observers_Purchase_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Purchase_2166136261();
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x0006E73E File Offset: 0x0006C93E
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001605 RID: 5637
		private const float destinationThreshold = 2f;

		// Token: 0x04001606 RID: 5638
		public ATM ATM;

		// Token: 0x04001607 RID: 5639
		private Coroutine purchaseCoroutine;

		// Token: 0x04001608 RID: 5640
		private bool dll_Excuted;

		// Token: 0x04001609 RID: 5641
		private bool dll_Excuted;
	}
}
