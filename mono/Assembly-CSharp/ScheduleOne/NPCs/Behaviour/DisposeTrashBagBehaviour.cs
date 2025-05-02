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
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x020004F5 RID: 1269
	public class DisposeTrashBagBehaviour : Behaviour
	{
		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x00078668 File Offset: 0x00076868
		// (set) Token: 0x06001D27 RID: 7463 RVA: 0x00078670 File Offset: 0x00076870
		public TrashBag TargetBag { get; private set; }

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x00077B54 File Offset: 0x00075D54
		private Cleaner Cleaner
		{
			get
			{
				return (Cleaner)base.Npc;
			}
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x00078679 File Offset: 0x00076879
		public void SetTargetBag(TrashBag bag)
		{
			this.TargetBag = bag;
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x00078682 File Offset: 0x00076882
		protected override void Begin()
		{
			base.Begin();
			this.StartAction();
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x00078690 File Offset: 0x00076890
		protected override void Resume()
		{
			base.Resume();
			this.StartAction();
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x000045B1 File Offset: 0x000027B1
		private void StartAction()
		{
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x0007869E File Offset: 0x0007689E
		protected override void Pause()
		{
			base.Pause();
			this.StopAllActions();
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x00077BBF File Offset: 0x00075DBF
		public override void Disable()
		{
			base.Disable();
			if (base.Active)
			{
				this.End();
			}
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x000786AC File Offset: 0x000768AC
		protected override void End()
		{
			base.End();
			this.StopAllActions();
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x000786BC File Offset: 0x000768BC
		private void StopAllActions()
		{
			if (base.Npc.Movement.IsMoving)
			{
				base.Npc.Movement.Stop();
			}
			if (this.grabRoutine != null)
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.grabRoutine);
				this.grabRoutine = null;
			}
			if (this.dropRoutine != null)
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.dropRoutine);
				this.dropRoutine = null;
			}
			if (base.Npc.Avatar.CurrentEquippable != null && base.Npc.Avatar.CurrentEquippable.AssetPath == this.TRASH_BAG_ASSET_PATH)
			{
				base.Npc.SetEquippable_Return(string.Empty);
			}
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x00078774 File Offset: 0x00076974
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
			if (this.grabRoutine != null)
			{
				return;
			}
			if (this.dropRoutine != null)
			{
				return;
			}
			if (!this.AreActionConditionsMet(false))
			{
				base.Disable_Networked(null);
				return;
			}
			if (this.heldTrash == null)
			{
				if (this.IsAtDestination())
				{
					this.GrabTrash();
					return;
				}
				this.GoToTarget();
				return;
			}
			else
			{
				if (this.IsAtDestination())
				{
					this.DropTrash();
					return;
				}
				this.GoToTarget();
				return;
			}
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x000787F8 File Offset: 0x000769F8
		private void GoToTarget()
		{
			if (!this.AreActionConditionsMet(true))
			{
				base.Disable_Networked(null);
				return;
			}
			if (this.heldTrash == null)
			{
				base.SetDestination(this.TargetBag.transform.position, true);
				return;
			}
			base.SetDestination(this.Cleaner.AssignedProperty.DisposalArea.StandPoint.position, true);
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00078857 File Offset: 0x00076A57
		[ObserversRpc(RunLocally = true)]
		private void GrabTrash()
		{
			this.RpcWriter___Observers_GrabTrash_2166136261();
			this.RpcLogic___GrabTrash_2166136261();
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x00078865 File Offset: 0x00076A65
		[ObserversRpc(RunLocally = true)]
		private void DropTrash()
		{
			this.RpcWriter___Observers_DropTrash_2166136261();
			this.RpcLogic___DropTrash_2166136261();
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x00078874 File Offset: 0x00076A74
		private bool IsAtDestination()
		{
			if (this.heldTrash == null)
			{
				return Vector3.Distance(base.Npc.transform.position, this.TargetBag.transform.position) <= 2f;
			}
			return Vector3.Distance(base.Npc.transform.position, this.Cleaner.AssignedProperty.DisposalArea.StandPoint.position) <= 2f;
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x000788F4 File Offset: 0x00076AF4
		private bool AreActionConditionsMet(bool checkAccess)
		{
			if (this.heldTrash == null)
			{
				if (this.TargetBag == null)
				{
					return false;
				}
				if (this.TargetBag.Draggable.IsBeingDragged)
				{
					return false;
				}
				if (checkAccess && !base.Npc.Movement.CanGetTo(this.TargetBag.transform.position, 2f))
				{
					return false;
				}
			}
			else if (checkAccess && !base.Npc.Movement.CanGetTo(this.Cleaner.AssignedProperty.DisposalArea.StandPoint.position, 2f))
			{
				return false;
			}
			return true;
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x000789A3 File Offset: 0x00076BA3
		[CompilerGenerated]
		private IEnumerator <GrabTrash>g__Action|21_0()
		{
			if (InstanceFinder.IsServer && !this.AreActionConditionsMet(false))
			{
				base.Disable_Networked(null);
				yield break;
			}
			if (InstanceFinder.IsServer)
			{
				base.Npc.Movement.FacePoint(this.TargetBag.transform.position, 0.5f);
			}
			yield return new WaitForSeconds(0.3f);
			base.Npc.SetAnimationTrigger("GrabItem");
			if (InstanceFinder.IsServer)
			{
				if (!this.AreActionConditionsMet(false))
				{
					base.Disable_Networked(null);
					this.grabRoutine = null;
					yield break;
				}
				base.Npc.SetEquippable_Networked(null, this.TRASH_BAG_ASSET_PATH);
				this.heldTrash = this.TargetBag.Content;
				this.TargetBag.DestroyTrash();
			}
			yield return new WaitForSeconds(0.2f);
			this.grabRoutine = null;
			yield break;
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x000789B2 File Offset: 0x00076BB2
		[CompilerGenerated]
		private IEnumerator <DropTrash>g__Action|22_0()
		{
			if (InstanceFinder.IsServer && !this.AreActionConditionsMet(false))
			{
				base.Disable_Networked(null);
				yield break;
			}
			base.Npc.Movement.FaceDirection(this.Cleaner.AssignedProperty.DisposalArea.StandPoint.forward, 0.5f);
			yield return new WaitForSeconds(0.5f);
			if (InstanceFinder.IsServer)
			{
				Transform trashDropPoint = this.Cleaner.AssignedProperty.DisposalArea.TrashDropPoint;
				NetworkSingleton<TrashManager>.Instance.CreateTrashBag("trashbag", trashDropPoint.position, Random.rotation, this.heldTrash.GetData(), default(Vector3), "", false);
				this.heldTrash = null;
				base.Npc.SetEquippable_Networked(null, string.Empty);
			}
			yield return new WaitForSeconds(0.2f);
			this.dropRoutine = null;
			base.Disable_Networked(null);
			yield break;
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x000789C4 File Offset: 0x00076BC4
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.DisposeTrashBagBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.DisposeTrashBagBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_GrabTrash_2166136261));
			base.RegisterObserversRpc(16U, new ClientRpcDelegate(this.RpcReader___Observers_DropTrash_2166136261));
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x00078A16 File Offset: 0x00076C16
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.DisposeTrashBagBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.DisposeTrashBagBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00078A2F File Offset: 0x00076C2F
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x00078A40 File Offset: 0x00076C40
		private void RpcWriter___Observers_GrabTrash_2166136261()
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

		// Token: 0x06001D3E RID: 7486 RVA: 0x00078AE9 File Offset: 0x00076CE9
		private void RpcLogic___GrabTrash_2166136261()
		{
			if (this.grabRoutine != null)
			{
				return;
			}
			this.grabRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.<GrabTrash>g__Action|21_0());
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x00078B0C File Offset: 0x00076D0C
		private void RpcReader___Observers_GrabTrash_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___GrabTrash_2166136261();
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x00078B38 File Offset: 0x00076D38
		private void RpcWriter___Observers_DropTrash_2166136261()
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
			base.SendObserversRpc(16U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00078BE1 File Offset: 0x00076DE1
		private void RpcLogic___DropTrash_2166136261()
		{
			if (this.dropRoutine != null)
			{
				return;
			}
			this.dropRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.<DropTrash>g__Action|22_0());
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x00078C04 File Offset: 0x00076E04
		private void RpcReader___Observers_DropTrash_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___DropTrash_2166136261();
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x00078C2E File Offset: 0x00076E2E
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001799 RID: 6041
		public string TRASH_BAG_ASSET_PATH = "Avatar/Equippables/TrashBag";

		// Token: 0x0400179A RID: 6042
		public const float GRAB_MAX_DISTANCE = 2f;

		// Token: 0x0400179C RID: 6044
		private TrashContent heldTrash;

		// Token: 0x0400179D RID: 6045
		private Coroutine grabRoutine;

		// Token: 0x0400179E RID: 6046
		private Coroutine dropRoutine;

		// Token: 0x0400179F RID: 6047
		private bool dll_Excuted;

		// Token: 0x040017A0 RID: 6048
		private bool dll_Excuted;
	}
}
