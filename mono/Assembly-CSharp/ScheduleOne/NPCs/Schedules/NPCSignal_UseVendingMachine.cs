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
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000485 RID: 1157
	public class NPCSignal_UseVendingMachine : NPCSignal
	{
		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001965 RID: 6501 RVA: 0x0006E81D File Offset: 0x0006CA1D
		public new string ActionName
		{
			get
			{
				return "Use Vending Machine";
			}
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x0006E824 File Offset: 0x0006CA24
		public override string GetName()
		{
			return this.ActionName;
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x0006E82C File Offset: 0x0006CA2C
		public override void Started()
		{
			base.Started();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			this.TargetMachine = this.GetTargetMachine();
			if (this.TargetMachine == null)
			{
				Debug.LogWarning("No vending machine found for NPC to use");
				this.End();
				return;
			}
			base.SetDestination(this.TargetMachine.AccessPoint.position, true);
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x0006E88C File Offset: 0x0006CA8C
		public override void MinPassed()
		{
			base.MinPassed();
			if (!base.IsActive)
			{
				return;
			}
			if (!this.npc.Movement.IsMoving)
			{
				if (this.TargetMachine == null)
				{
					this.TargetMachine = this.GetTargetMachine();
				}
				if (this.TargetMachine == null)
				{
					Debug.LogWarning("No vending machine found for NPC to use");
					this.End();
					return;
				}
				if (this.TargetMachine.AccessPoint == null)
				{
					Debug.LogWarning("Vending machine has no access point");
					this.End();
					return;
				}
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
					if (this.npc.Movement.CanGetTo(this.TargetMachine.AccessPoint.position, 1f))
					{
						base.SetDestination(this.TargetMachine.AccessPoint.position, true);
						return;
					}
					Debug.LogWarning("Unable to reach vending machine");
					this.End();
					return;
				}
			}
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x0006E4C8 File Offset: 0x0006C6C8
		public override void LateStarted()
		{
			base.LateStarted();
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x0006E984 File Offset: 0x0006CB84
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

		// Token: 0x0600196B RID: 6507 RVA: 0x0006E524 File Offset: 0x0006C724
		public override void Resume()
		{
			base.Resume();
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x0006CD14 File Offset: 0x0006AF14
		public override void Skipped()
		{
			base.Skipped();
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x0006E9D8 File Offset: 0x0006CBD8
		private bool IsAtDestination()
		{
			return !(this.TargetMachine == null) && Vector3.Distance(this.npc.Movement.FootPosition, this.TargetMachine.AccessPoint.position) < 1f;
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x0006EA18 File Offset: 0x0006CC18
		private VendingMachine GetTargetMachine()
		{
			if (this.MachineOverride != null && base.movement.CanGetTo(this.MachineOverride.AccessPoint.position, 1f))
			{
				return this.MachineOverride;
			}
			VendingMachine result = null;
			float num = float.MaxValue;
			foreach (VendingMachine vendingMachine in VendingMachine.AllMachines)
			{
				if (base.movement.CanGetTo(vendingMachine.AccessPoint.position, 1f))
				{
					float num2 = Vector3.Distance(this.npc.Movement.FootPosition, vendingMachine.AccessPoint.position);
					if (num2 < num)
					{
						result = vendingMachine;
						num = num2;
					}
				}
			}
			return result;
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x0006EAEC File Offset: 0x0006CCEC
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

		// Token: 0x06001970 RID: 6512 RVA: 0x0006EB0C File Offset: 0x0006CD0C
		[ObserversRpc(RunLocally = true)]
		public void Purchase()
		{
			this.RpcWriter___Observers_Purchase_2166136261();
			this.RpcLogic___Purchase_2166136261();
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x0006EB25 File Offset: 0x0006CD25
		private bool CheckItem()
		{
			if (this.TargetMachine.lastDroppedItem == null || this.TargetMachine.lastDroppedItem.gameObject == null)
			{
				this.ItemWasStolen();
				this.End();
				return false;
			}
			return true;
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x0006EB61 File Offset: 0x0006CD61
		private void ItemWasStolen()
		{
			this.npc.Avatar.EmotionManager.AddEmotionOverride("Annoyed", "drinkstolen", 20f, 0);
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x0006EB88 File Offset: 0x0006CD88
		[CompilerGenerated]
		private IEnumerator <Purchase>g__Purchase|16_0()
		{
			yield return new WaitForSeconds(1f);
			if (this.TargetMachine == null || this.TargetMachine.IsBroken)
			{
				this.purchaseCoroutine = null;
				this.End();
				yield break;
			}
			this.TargetMachine.PurchaseRoutine();
			yield return new WaitForSeconds(1f);
			if (!this.CheckItem())
			{
				this.purchaseCoroutine = null;
				this.End();
				yield break;
			}
			this.npc.SetAnimationTrigger_Networked(null, "GrabItem");
			yield return new WaitForSeconds(0.4f);
			if (!this.CheckItem())
			{
				this.purchaseCoroutine = null;
				this.End();
				yield break;
			}
			this.TargetMachine.RemoveLastDropped();
			yield return new WaitForSeconds(0.5f);
			this.End();
			this.purchaseCoroutine = null;
			this.npc.Avatar.EmotionManager.AddEmotionOverride("Cheery", "energydrink", 5f, 0);
			yield break;
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x0006EB97 File Offset: 0x0006CD97
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_UseVendingMachineAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_UseVendingMachineAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_Purchase_2166136261));
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x0006EBC7 File Offset: 0x0006CDC7
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_UseVendingMachineAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_UseVendingMachineAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x0006EBE0 File Offset: 0x0006CDE0
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x0006EBF0 File Offset: 0x0006CDF0
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

		// Token: 0x06001979 RID: 6521 RVA: 0x0006EC9C File Offset: 0x0006CE9C
		public void RpcLogic___Purchase_2166136261()
		{
			if (this.purchaseCoroutine != null)
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.purchaseCoroutine);
			}
			if (this.TargetMachine == null)
			{
				this.TargetMachine = this.GetTargetMachine();
			}
			if (this.TargetMachine != null)
			{
				this.npc.Movement.FaceDirection(this.TargetMachine.AccessPoint.forward, 0.5f);
			}
			this.purchaseCoroutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.<Purchase>g__Purchase|16_0());
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x0006ED24 File Offset: 0x0006CF24
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

		// Token: 0x0600197B RID: 6523 RVA: 0x0006ED4E File Offset: 0x0006CF4E
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400160D RID: 5645
		private const float destinationThreshold = 1f;

		// Token: 0x0400160E RID: 5646
		public VendingMachine MachineOverride;

		// Token: 0x0400160F RID: 5647
		private VendingMachine TargetMachine;

		// Token: 0x04001610 RID: 5648
		private Coroutine purchaseCoroutine;

		// Token: 0x04001611 RID: 5649
		private bool dll_Excuted;

		// Token: 0x04001612 RID: 5650
		private bool dll_Excuted;
	}
}
