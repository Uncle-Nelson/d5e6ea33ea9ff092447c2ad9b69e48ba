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
using ScheduleOne.Employees;
using ScheduleOne.ObjectScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x020004F1 RID: 1265
	public class BagTrashCanBehaviour : Behaviour
	{
		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x00077B43 File Offset: 0x00075D43
		// (set) Token: 0x06001CE8 RID: 7400 RVA: 0x00077B4B File Offset: 0x00075D4B
		public TrashContainerItem TargetTrashCan { get; private set; }

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x00077B54 File Offset: 0x00075D54
		private Cleaner Cleaner
		{
			get
			{
				return (Cleaner)base.Npc;
			}
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00077B61 File Offset: 0x00075D61
		public void SetTargetTrashCan(TrashContainerItem trashCan)
		{
			this.TargetTrashCan = trashCan;
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00077B6A File Offset: 0x00075D6A
		protected override void Begin()
		{
			base.Begin();
			this.StartAction();
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00077B78 File Offset: 0x00075D78
		protected override void Resume()
		{
			base.Resume();
			this.StartAction();
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x00077B86 File Offset: 0x00075D86
		private void StartAction()
		{
			if (base.Npc.Avatar.CurrentEquippable != null)
			{
				base.Npc.SetEquippable_Return(string.Empty);
			}
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00077BB1 File Offset: 0x00075DB1
		protected override void Pause()
		{
			base.Pause();
			this.StopAllActions();
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x00077BBF File Offset: 0x00075DBF
		public override void Disable()
		{
			base.Disable();
			if (base.Active)
			{
				this.End();
			}
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x00077BD5 File Offset: 0x00075DD5
		protected override void End()
		{
			base.End();
			this.StopAllActions();
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x00077BE4 File Offset: 0x00075DE4
		private void StopAllActions()
		{
			if (base.Npc.Movement.IsMoving)
			{
				base.Npc.Movement.Stop();
			}
			base.Npc.SetAnimationBool("PatSoil", false);
			base.Npc.SetCrouched_Networked(false);
			if (this.actionCoroutine != null)
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.actionCoroutine);
				this.actionCoroutine = null;
			}
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00077C50 File Offset: 0x00075E50
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (base.Npc.Movement.IsMoving)
			{
				return;
			}
			if (this.actionCoroutine != null)
			{
				return;
			}
			if (!this.AreActionConditionsMet(false))
			{
				base.Disable_Networked(null);
				return;
			}
			if (this.IsAtDestination())
			{
				this.PerformAction();
				return;
			}
			this.GoToTarget();
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00077CAD File Offset: 0x00075EAD
		private void GoToTarget()
		{
			if (!this.AreActionConditionsMet(true))
			{
				base.Disable_Networked(null);
				return;
			}
			base.SetDestination(NavMeshUtility.GetAccessPoint(this.TargetTrashCan, base.Npc).position, true);
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x00077CDD File Offset: 0x00075EDD
		[ObserversRpc(RunLocally = true)]
		private void PerformAction()
		{
			this.RpcWriter___Observers_PerformAction_2166136261();
			this.RpcLogic___PerformAction_2166136261();
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00077CEB File Offset: 0x00075EEB
		private bool IsAtDestination()
		{
			return Vector3.Distance(base.Npc.transform.position, this.TargetTrashCan.transform.position) <= 2f;
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00077D1C File Offset: 0x00075F1C
		private bool AreActionConditionsMet(bool checkAccess)
		{
			if (this.TargetTrashCan == null)
			{
				return false;
			}
			if (this.TargetTrashCan.Container.NormalizedTrashLevel == 0f)
			{
				return false;
			}
			if (checkAccess)
			{
				Transform accessPoint = NavMeshUtility.GetAccessPoint(this.TargetTrashCan, base.Npc);
				if (accessPoint == null)
				{
					return false;
				}
				if (!base.Npc.Movement.CanGetTo(accessPoint.position, 2f))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x00077D92 File Offset: 0x00075F92
		[CompilerGenerated]
		private IEnumerator <PerformAction>g__Action|21_0()
		{
			if (InstanceFinder.IsServer && !this.AreActionConditionsMet(false))
			{
				base.Disable_Networked(null);
				yield break;
			}
			if (InstanceFinder.IsServer)
			{
				base.Npc.Movement.FacePoint(this.TargetTrashCan.transform.position, 0.5f);
			}
			yield return new WaitForSeconds(0.4f);
			base.Npc.SetAnimationBool("PatSoil", true);
			base.Npc.SetCrouched_Networked(true);
			if (this.onPerfomAction != null)
			{
				this.onPerfomAction.Invoke();
			}
			yield return new WaitForSeconds(3f);
			if (InstanceFinder.IsServer && this.AreActionConditionsMet(false))
			{
				this.TargetTrashCan.Container.BagTrash();
				if (this.onPerfomDone != null)
				{
					this.onPerfomDone.Invoke();
				}
			}
			base.Npc.SetAnimationBool("PatSoil", false);
			yield return new WaitForSeconds(0.2f);
			this.actionCoroutine = null;
			base.Disable_Networked(null);
			yield break;
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x00077DA1 File Offset: 0x00075FA1
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BagTrashCanBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BagTrashCanBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_PerformAction_2166136261));
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00077DD1 File Offset: 0x00075FD1
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BagTrashCanBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BagTrashCanBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x00077DEA File Offset: 0x00075FEA
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x00077DF8 File Offset: 0x00075FF8
		private void RpcWriter___Observers_PerformAction_2166136261()
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

		// Token: 0x06001CFD RID: 7421 RVA: 0x00077EA1 File Offset: 0x000760A1
		private void RpcLogic___PerformAction_2166136261()
		{
			if (this.actionCoroutine != null)
			{
				return;
			}
			this.actionCoroutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.<PerformAction>g__Action|21_0());
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x00077EC4 File Offset: 0x000760C4
		private void RpcReader___Observers_PerformAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___PerformAction_2166136261();
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x00077EEE File Offset: 0x000760EE
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001783 RID: 6019
		public const float ACTION_MAX_DISTANCE = 2f;

		// Token: 0x04001784 RID: 6020
		public const float BAG_TIME = 3f;

		// Token: 0x04001786 RID: 6022
		private Coroutine actionCoroutine;

		// Token: 0x04001787 RID: 6023
		public UnityEvent onPerfomAction;

		// Token: 0x04001788 RID: 6024
		public UnityEvent onPerfomDone;

		// Token: 0x04001789 RID: 6025
		private bool dll_Excuted;

		// Token: 0x0400178A RID: 6026
		private bool dll_Excuted;
	}
}
