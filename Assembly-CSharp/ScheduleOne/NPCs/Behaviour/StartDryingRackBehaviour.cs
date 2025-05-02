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
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000512 RID: 1298
	public class StartDryingRackBehaviour : Behaviour
	{
		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001E9D RID: 7837 RVA: 0x0007DE4C File Offset: 0x0007C04C
		// (set) Token: 0x06001E9E RID: 7838 RVA: 0x0007DE54 File Offset: 0x0007C054
		public DryingRack Rack { get; protected set; }

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x0007DE5D File Offset: 0x0007C05D
		// (set) Token: 0x06001EA0 RID: 7840 RVA: 0x0007DE65 File Offset: 0x0007C065
		public bool WorkInProgress { get; protected set; }

		// Token: 0x06001EA1 RID: 7841 RVA: 0x0007DE6E File Offset: 0x0007C06E
		protected override void Begin()
		{
			base.Begin();
			this.StartWork();
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x0007DE7C File Offset: 0x0007C07C
		protected override void Resume()
		{
			base.Resume();
			this.StartWork();
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x0007DE8A File Offset: 0x0007C08A
		protected override void Pause()
		{
			base.Pause();
			if (this.WorkInProgress)
			{
				this.StopCauldron();
			}
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00077BBF File Offset: 0x00075DBF
		public override void Disable()
		{
			base.Disable();
			if (base.Active)
			{
				this.End();
			}
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x0007DEA0 File Offset: 0x0007C0A0
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

		// Token: 0x06001EA6 RID: 7846 RVA: 0x0007DF00 File Offset: 0x0007C100
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

		// Token: 0x06001EA7 RID: 7847 RVA: 0x0007DF64 File Offset: 0x0007C164
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

		// Token: 0x06001EA8 RID: 7848 RVA: 0x0007DFC0 File Offset: 0x0007C1C0
		public void AssignRack(DryingRack rack)
		{
			this.Rack = rack;
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x0007DFC9 File Offset: 0x0007C1C9
		public bool IsAtStation()
		{
			return base.Npc.Movement.IsAsCloseAsPossible(NavMeshUtility.GetAccessPoint(this.Rack, base.Npc).position, 0.5f);
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x0007DFF6 File Offset: 0x0007C1F6
		public void GoToStation()
		{
			base.Npc.Movement.SetDestination(NavMeshUtility.GetAccessPoint(this.Rack, base.Npc).position);
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x0007E020 File Offset: 0x0007C220
		[ObserversRpc(RunLocally = true)]
		public void BeginAction()
		{
			this.RpcWriter___Observers_BeginAction_2166136261();
			this.RpcLogic___BeginAction_2166136261();
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0007E039 File Offset: 0x0007C239
		private void StopCauldron()
		{
			if (this.workRoutine != null)
			{
				base.StopCoroutine(this.workRoutine);
			}
			this.WorkInProgress = false;
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x0007E058 File Offset: 0x0007C258
		public bool IsRackReady(DryingRack rack)
		{
			return !(rack == null) && (!((IUsable)rack).IsInUse || (!(rack.PlayerUserObject != null) && !(rack.NPCUserObject != base.Npc.NetworkObject))) && rack.InputSlot.Quantity > 0 && rack.GetTotalDryingItems() < rack.ItemCapacity && base.Npc.Movement.CanGetTo(rack.transform.position, 1f);
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x0007E0E5 File Offset: 0x0007C2E5
		[CompilerGenerated]
		private IEnumerator <BeginAction>g__Package|20_0()
		{
			yield return new WaitForEndOfFrame();
			this.Rack.InputSlot.ItemInstance.GetCopy(1);
			int itemCount = 0;
			while (this.Rack != null && this.Rack.InputSlot.Quantity > itemCount && this.Rack.GetTotalDryingItems() + itemCount < this.Rack.ItemCapacity)
			{
				base.Npc.Avatar.Anim.SetTrigger("GrabItem");
				yield return new WaitForSeconds(1f);
				int num = itemCount;
				itemCount = num + 1;
			}
			if (InstanceFinder.IsServer)
			{
				this.Rack.StartOperation();
			}
			this.WorkInProgress = false;
			this.workRoutine = null;
			yield break;
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x0007E0F4 File Offset: 0x0007C2F4
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartDryingRackBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartDryingRackBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_BeginAction_2166136261));
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x0007E124 File Offset: 0x0007C324
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartDryingRackBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartDryingRackBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x0007E13D File Offset: 0x0007C33D
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x0007E14C File Offset: 0x0007C34C
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

		// Token: 0x06001EB4 RID: 7860 RVA: 0x0007E1F8 File Offset: 0x0007C3F8
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

		// Token: 0x06001EB5 RID: 7861 RVA: 0x0007E25C File Offset: 0x0007C45C
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

		// Token: 0x06001EB6 RID: 7862 RVA: 0x0007E286 File Offset: 0x0007C486
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001834 RID: 6196
		public const float TIME_PER_ITEM = 1f;

		// Token: 0x04001837 RID: 6199
		private Coroutine workRoutine;

		// Token: 0x04001838 RID: 6200
		private bool dll_Excuted;

		// Token: 0x04001839 RID: 6201
		private bool dll_Excuted;
	}
}
