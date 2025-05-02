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
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000504 RID: 1284
	public class PickUpTrashBehaviour : Behaviour
	{
		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x0007B02A File Offset: 0x0007922A
		// (set) Token: 0x06001DED RID: 7661 RVA: 0x0007B032 File Offset: 0x00079232
		public TrashItem TargetTrash { get; private set; }

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x00077B54 File Offset: 0x00075D54
		private Cleaner Cleaner
		{
			get
			{
				return (Cleaner)base.Npc;
			}
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x0007B03B File Offset: 0x0007923B
		public void SetTargetTrash(TrashItem trash)
		{
			this.TargetTrash = trash;
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x0007B044 File Offset: 0x00079244
		protected override void Begin()
		{
			base.Begin();
			this.StartAction();
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x0007B052 File Offset: 0x00079252
		protected override void Resume()
		{
			base.Resume();
			this.StartAction();
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x0007B060 File Offset: 0x00079260
		private void StartAction()
		{
			if (base.Npc.Avatar.CurrentEquippable == null || base.Npc.Avatar.CurrentEquippable.AssetPath != "Tools/TrashGrabber/TrashGrabber_AvatarEquippable")
			{
				base.Npc.SetEquippable_Return("Tools/TrashGrabber/TrashGrabber_AvatarEquippable");
			}
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x0007B0B7 File Offset: 0x000792B7
		protected override void Pause()
		{
			base.Pause();
			this.StopAllActions();
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x00077BBF File Offset: 0x00075DBF
		public override void Disable()
		{
			base.Disable();
			if (base.Active)
			{
				this.End();
			}
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x0007B0C5 File Offset: 0x000792C5
		protected override void End()
		{
			base.End();
			this.StopAllActions();
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x0007B0D4 File Offset: 0x000792D4
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

		// Token: 0x06001DF7 RID: 7671 RVA: 0x0007B124 File Offset: 0x00079324
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (base.Npc.Movement.IsMoving)
			{
				if (this.Cleaner.DEBUG)
				{
					Console.Log("Waiting for movement to finish", null);
				}
				return;
			}
			if (this.actionCoroutine != null)
			{
				if (this.Cleaner.DEBUG)
				{
					Console.Log("Waiting for action to finish", null);
				}
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

		// Token: 0x06001DF8 RID: 7672 RVA: 0x0007B1B4 File Offset: 0x000793B4
		private void GoToTarget()
		{
			if (this.Cleaner.DEBUG)
			{
				Console.Log("Going to target", null);
			}
			if (!this.AreActionConditionsMet(true))
			{
				base.Disable_Networked(null);
				return;
			}
			base.SetDestination(this.TargetTrash.transform.position, true);
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x0007B201 File Offset: 0x00079401
		[ObserversRpc(RunLocally = true)]
		private void PerformAction()
		{
			this.RpcWriter___Observers_PerformAction_2166136261();
			this.RpcLogic___PerformAction_2166136261();
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x0007B20F File Offset: 0x0007940F
		private bool IsAtDestination()
		{
			return Vector3.Distance(base.Npc.transform.position, this.TargetTrash.transform.position) <= 2f;
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x0007B240 File Offset: 0x00079440
		private bool AreActionConditionsMet(bool checkAccess)
		{
			return !(this.TargetTrash == null) && !this.TargetTrash.Draggable.IsBeingDragged && (!checkAccess || base.Npc.Movement.CanGetTo(this.TargetTrash.transform.position, 2f));
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x0007B29E File Offset: 0x0007949E
		[CompilerGenerated]
		private IEnumerator <PerformAction>g__Action|20_0()
		{
			if (InstanceFinder.IsServer && !this.AreActionConditionsMet(false))
			{
				this.actionCoroutine = null;
				base.Disable_Networked(null);
				yield break;
			}
			if (InstanceFinder.IsServer)
			{
				base.Npc.Movement.FacePoint(this.TargetTrash.transform.position, 0.5f);
			}
			yield return new WaitForSeconds(0.3f);
			if (this.onPerfomAction != null)
			{
				this.onPerfomAction.Invoke();
			}
			yield return new WaitForSeconds(0.4f);
			if (InstanceFinder.IsServer)
			{
				this.Cleaner.trashGrabberInstance.AddTrash(this.TargetTrash.ID, 1);
				if (this.TargetTrash != null)
				{
					this.TargetTrash.DestroyTrash();
				}
			}
			yield return new WaitForSeconds(0.2f);
			this.actionCoroutine = null;
			base.Disable_Networked(null);
			yield break;
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x0007B2AD File Offset: 0x000794AD
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PickUpTrashBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PickUpTrashBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_PerformAction_2166136261));
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x0007B2DD File Offset: 0x000794DD
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PickUpTrashBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PickUpTrashBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x0007B2F6 File Offset: 0x000794F6
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x0007B304 File Offset: 0x00079504
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

		// Token: 0x06001E02 RID: 7682 RVA: 0x0007B3AD File Offset: 0x000795AD
		private void RpcLogic___PerformAction_2166136261()
		{
			if (this.Cleaner.DEBUG)
			{
				Console.Log("Picking up trash", null);
			}
			if (this.actionCoroutine != null)
			{
				return;
			}
			this.actionCoroutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.<PerformAction>g__Action|20_0());
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0007B3E8 File Offset: 0x000795E8
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

		// Token: 0x06001E04 RID: 7684 RVA: 0x0007B412 File Offset: 0x00079612
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040017E4 RID: 6116
		public const float ACTION_MAX_DISTANCE = 2f;

		// Token: 0x040017E5 RID: 6117
		public const string EQUIPPABLE_ASSET_PATH = "Tools/TrashGrabber/TrashGrabber_AvatarEquippable";

		// Token: 0x040017E7 RID: 6119
		private Coroutine actionCoroutine;

		// Token: 0x040017E8 RID: 6120
		public UnityEvent onPerfomAction;

		// Token: 0x040017E9 RID: 6121
		private bool dll_Excuted;

		// Token: 0x040017EA RID: 6122
		private bool dll_Excuted;
	}
}
