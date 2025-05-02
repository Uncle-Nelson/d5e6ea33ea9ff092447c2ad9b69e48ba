using System;
using System.Collections;
using System.Collections.Generic;
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
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x020004F8 RID: 1272
	public class EmptyTrashGrabberBehaviour : Behaviour
	{
		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x00078ECD File Offset: 0x000770CD
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x00078ED5 File Offset: 0x000770D5
		public TrashContainerItem TargetTrashCan { get; private set; }

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x00077B54 File Offset: 0x00075D54
		private Cleaner Cleaner
		{
			get
			{
				return (Cleaner)base.Npc;
			}
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00078EDE File Offset: 0x000770DE
		public void SetTargetTrashCan(TrashContainerItem trashCan)
		{
			this.TargetTrashCan = trashCan;
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00078EE7 File Offset: 0x000770E7
		protected override void Begin()
		{
			base.Begin();
			this.StartAction();
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00078EF5 File Offset: 0x000770F5
		protected override void Resume()
		{
			base.Resume();
			this.StartAction();
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00078F04 File Offset: 0x00077104
		private void StartAction()
		{
			if (base.Npc.Avatar.CurrentEquippable == null || base.Npc.Avatar.CurrentEquippable.AssetPath != "Tools/TrashGrabber/Bin_AvatarEquippable")
			{
				base.Npc.SetEquippable_Return("Tools/TrashGrabber/Bin_AvatarEquippable");
			}
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x00078F5B File Offset: 0x0007715B
		protected override void Pause()
		{
			base.Pause();
			this.StopAllActions();
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x00077BBF File Offset: 0x00075DBF
		public override void Disable()
		{
			base.Disable();
			if (base.Active)
			{
				this.End();
			}
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x00078F69 File Offset: 0x00077169
		protected override void End()
		{
			base.End();
			this.StopAllActions();
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x00078F78 File Offset: 0x00077178
		private void StopAllActions()
		{
			if (base.Npc.Movement.IsMoving)
			{
				base.Npc.Movement.Stop();
			}
			if (this.actionCoroutine != null)
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.actionCoroutine);
				this.actionCoroutine = null;
			}
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x00078FC8 File Offset: 0x000771C8
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

		// Token: 0x06001D5C RID: 7516 RVA: 0x00079028 File Offset: 0x00077228
		private void GoToTarget()
		{
			if (!this.AreActionConditionsMet(true))
			{
				base.Disable_Networked(null);
				return;
			}
			Transform accessPoint = NavMeshUtility.GetAccessPoint(this.TargetTrashCan, base.Npc);
			if (accessPoint == null)
			{
				base.Disable_Networked(null);
				return;
			}
			base.SetDestination(accessPoint.position, true);
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00079076 File Offset: 0x00077276
		[ObserversRpc(RunLocally = true)]
		private void PerformAction()
		{
			this.RpcWriter___Observers_PerformAction_2166136261();
			this.RpcLogic___PerformAction_2166136261();
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00079084 File Offset: 0x00077284
		private bool IsAtDestination()
		{
			return Vector3.Distance(base.Npc.transform.position, this.TargetTrashCan.transform.position) <= 2f;
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x000790B8 File Offset: 0x000772B8
		private bool AreActionConditionsMet(bool checkAccess)
		{
			return !(this.TargetTrashCan == null) && this.TargetTrashCan.Container.NormalizedTrashLevel < 1f && this.Cleaner.trashGrabberInstance.GetTotalSize() != 0 && (!checkAccess || base.Npc.Movement.CanGetTo(this.TargetTrashCan.transform.position, 2f));
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x0007912F File Offset: 0x0007732F
		[CompilerGenerated]
		private IEnumerator <PerformAction>g__Action|20_0()
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
			yield return new WaitForSeconds(0.3f);
			if (this.onPerfomAction != null)
			{
				this.onPerfomAction.Invoke();
			}
			yield return new WaitForSeconds(0.4f);
			if (InstanceFinder.IsServer)
			{
				while (this.AreActionConditionsMet(false))
				{
					List<string> trashIDs = this.Cleaner.trashGrabberInstance.GetTrashIDs();
					string id = trashIDs[trashIDs.Count - 1];
					this.Cleaner.trashGrabberInstance.RemoveTrash(id, 1);
					NetworkSingleton<TrashManager>.Instance.CreateTrashItem(id, this.TargetTrashCan.transform.position + Vector3.up * 1.5f, Random.rotation, default(Vector3), "", false);
					yield return new WaitForSeconds(0.5f);
				}
			}
			yield return new WaitForSeconds(0.2f);
			this.actionCoroutine = null;
			base.Disable_Networked(null);
			yield break;
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x0007913E File Offset: 0x0007733E
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.EmptyTrashGrabberBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.EmptyTrashGrabberBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_PerformAction_2166136261));
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x0007916E File Offset: 0x0007736E
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.EmptyTrashGrabberBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.EmptyTrashGrabberBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00079187 File Offset: 0x00077387
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x00079198 File Offset: 0x00077398
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

		// Token: 0x06001D66 RID: 7526 RVA: 0x00079241 File Offset: 0x00077441
		private void RpcLogic___PerformAction_2166136261()
		{
			if (this.actionCoroutine != null)
			{
				return;
			}
			this.actionCoroutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.<PerformAction>g__Action|20_0());
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00079264 File Offset: 0x00077464
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

		// Token: 0x06001D68 RID: 7528 RVA: 0x0007928E File Offset: 0x0007748E
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040017A7 RID: 6055
		public const float ACTION_MAX_DISTANCE = 2f;

		// Token: 0x040017A8 RID: 6056
		public const string EQUIPPABLE_ASSET_PATH = "Tools/TrashGrabber/Bin_AvatarEquippable";

		// Token: 0x040017AA RID: 6058
		private Coroutine actionCoroutine;

		// Token: 0x040017AB RID: 6059
		public UnityEvent onPerfomAction;

		// Token: 0x040017AC RID: 6060
		private bool dll_Excuted;

		// Token: 0x040017AD RID: 6061
		private bool dll_Excuted;
	}
}
