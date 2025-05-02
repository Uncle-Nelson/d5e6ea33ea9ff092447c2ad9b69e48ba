using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000518 RID: 1304
	public class StopDryingRackBehaviour : Behaviour
	{
		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x0007EF3A File Offset: 0x0007D13A
		// (set) Token: 0x06001EF3 RID: 7923 RVA: 0x0007EF42 File Offset: 0x0007D142
		public DryingRack Rack { get; protected set; }

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x0007EF4B File Offset: 0x0007D14B
		// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x0007EF53 File Offset: 0x0007D153
		public bool WorkInProgress { get; protected set; }

		// Token: 0x06001EF6 RID: 7926 RVA: 0x0007EF5C File Offset: 0x0007D15C
		protected override void Begin()
		{
			base.Begin();
			this.StartWork();
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x0007EF6A File Offset: 0x0007D16A
		protected override void Resume()
		{
			base.Resume();
			this.StartWork();
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x0007EF78 File Offset: 0x0007D178
		protected override void Pause()
		{
			base.Pause();
			if (this.WorkInProgress)
			{
				this.StopCauldron();
			}
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00077BBF File Offset: 0x00075DBF
		public override void Disable()
		{
			base.Disable();
			if (base.Active)
			{
				this.End();
			}
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x0007EF90 File Offset: 0x0007D190
		protected override void End()
		{
			base.End();
			if (this.WorkInProgress)
			{
				this.StopCauldron();
			}
			if (InstanceFinder.IsServer && this.Rack != null && this.Rack.NPCUserObject == base.Npc.NetworkObject)
			{
				this.Rack.SetNPCUser(null);
			}
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x0007EFF0 File Offset: 0x0007D1F0
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.WorkInProgress)
			{
				if (this.IsRackReady(this.Rack))
				{
					if (base.Npc.Movement.IsMoving)
					{
						return;
					}
					if (this.IsAtStation())
					{
						this.BeginAction();
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

		// Token: 0x06001EFC RID: 7932 RVA: 0x0007F054 File Offset: 0x0007D254
		private void StartWork()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.IsRackReady(this.Rack))
			{
				Console.LogWarning(base.Npc.fullName + " has no station to work with", null);
				base.Disable_Networked(null);
				return;
			}
			this.Rack.SetNPCUser(base.Npc.NetworkObject);
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x0007F0B0 File Offset: 0x0007D2B0
		public void AssignRack(DryingRack rack)
		{
			this.Rack = rack;
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x0007F0B9 File Offset: 0x0007D2B9
		public bool IsAtStation()
		{
			return base.Npc.Movement.IsAsCloseAsPossible(NavMeshUtility.GetAccessPoint(this.Rack, base.Npc).position, 0.5f);
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x0007F0E6 File Offset: 0x0007D2E6
		public void GoToStation()
		{
			base.Npc.Movement.SetDestination(NavMeshUtility.GetAccessPoint(this.Rack, base.Npc).position);
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x0007F110 File Offset: 0x0007D310
		[ObserversRpc(RunLocally = true)]
		public void BeginAction()
		{
			this.RpcWriter___Observers_BeginAction_2166136261();
			this.RpcLogic___BeginAction_2166136261();
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x0007F129 File Offset: 0x0007D329
		private void StopCauldron()
		{
			if (this.workRoutine != null)
			{
				base.StopCoroutine(this.workRoutine);
			}
			this.WorkInProgress = false;
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x0007F148 File Offset: 0x0007D348
		public bool IsRackReady(DryingRack rack)
		{
			if (rack == null)
			{
				return false;
			}
			if (((IUsable)rack).IsInUse && (rack.PlayerUserObject != null || rack.NPCUserObject != base.Npc.NetworkObject))
			{
				return false;
			}
			List<DryingOperation> operationsAtTargetQuality = rack.GetOperationsAtTargetQuality();
			bool flag = false;
			foreach (DryingOperation dryingOperation in operationsAtTargetQuality)
			{
				if (rack.GetOutputCapacityForOperation(dryingOperation, dryingOperation.GetQuality()) > 0)
				{
					flag = true;
				}
			}
			return flag && base.Npc.Movement.CanGetTo(rack.transform.position, 1f);
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x0007F210 File Offset: 0x0007D410
		[CompilerGenerated]
		private IEnumerator <BeginAction>g__Package|20_0()
		{
			yield return new WaitForEndOfFrame();
			base.Npc.Avatar.Anim.SetTrigger("GrabItem");
			yield return new WaitForSeconds(0.5f);
			if (InstanceFinder.IsServer)
			{
				DryingOperation dryingOperation = this.Rack.GetOperationsAtTargetQuality().FirstOrDefault((DryingOperation x) => this.Rack.GetOutputCapacityForOperation(x, x.GetQuality()) > 0);
				if (dryingOperation != null)
				{
					this.Rack.TryEndOperation(this.Rack.DryingOperations.IndexOf(dryingOperation), true, dryingOperation.GetQuality(), Random.Range(int.MinValue, int.MaxValue));
				}
			}
			this.WorkInProgress = false;
			this.workRoutine = null;
			yield break;
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x0007F236 File Offset: 0x0007D436
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StopDryingRackBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StopDryingRackBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_BeginAction_2166136261));
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x0007F266 File Offset: 0x0007D466
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StopDryingRackBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StopDryingRackBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x0007F27F File Offset: 0x0007D47F
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x0007F290 File Offset: 0x0007D490
		private void RpcWriter___Observers_BeginAction_2166136261()
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

		// Token: 0x06001F0A RID: 7946 RVA: 0x0007F33C File Offset: 0x0007D53C
		public void RpcLogic___BeginAction_2166136261()
		{
			if (this.WorkInProgress)
			{
				return;
			}
			if (this.Rack == null)
			{
				return;
			}
			this.WorkInProgress = true;
			base.Npc.Movement.FacePoint(this.Rack.uiPoint.position, 0.5f);
			this.workRoutine = base.StartCoroutine(this.<BeginAction>g__Package|20_0());
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x0007F3A0 File Offset: 0x0007D5A0
		private void RpcReader___Observers_BeginAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___BeginAction_2166136261();
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x0007F3CA File Offset: 0x0007D5CA
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001854 RID: 6228
		public const float TIME_PER_ITEM = 1f;

		// Token: 0x04001857 RID: 6231
		private Coroutine workRoutine;

		// Token: 0x04001858 RID: 6232
		private bool dll_Excuted;

		// Token: 0x04001859 RID: 6233
		private bool dll_Excuted;
	}
}
