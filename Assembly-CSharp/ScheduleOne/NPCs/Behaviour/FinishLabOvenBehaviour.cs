using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Employees;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x020004FA RID: 1274
	public class FinishLabOvenBehaviour : Behaviour
	{
		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x00079470 File Offset: 0x00077670
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x00079478 File Offset: 0x00077678
		public LabOven targetOven { get; private set; }

		// Token: 0x06001D71 RID: 7537 RVA: 0x00079481 File Offset: 0x00077681
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Behaviour.FinishLabOvenBehaviour_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x00079495 File Offset: 0x00077695
		public void SetTargetOven(LabOven oven)
		{
			this.targetOven = oven;
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x000794A0 File Offset: 0x000776A0
		protected override void End()
		{
			base.End();
			if (this.targetOven != null)
			{
				this.targetOven.Door.SetPosition(0f);
				this.targetOven.ClearShards();
				this.targetOven.RemoveTrayAnimation.Stop();
				this.targetOven.ResetSquareTray();
			}
			this.Disable();
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00079504 File Offset: 0x00077704
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (this.actionRoutine != null)
			{
				base.Npc.Avatar.LookController.OverrideLookTarget(this.targetOven.UIPoint.position, 5, false);
				return;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!base.Npc.Movement.IsMoving)
			{
				if (this.IsAtStation())
				{
					this.StartAction();
					return;
				}
				base.SetDestination(this.GetStationAccessPoint(), true);
			}
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x0007957D File Offset: 0x0007777D
		[ObserversRpc(RunLocally = true)]
		private void StartAction()
		{
			this.RpcWriter___Observers_StartAction_2166136261();
			this.RpcLogic___StartAction_2166136261();
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x0007958C File Offset: 0x0007778C
		private bool CanActionStart()
		{
			return !(this.targetOven == null) && (!((IUsable)this.targetOven).IsInUse || !(((IUsable)this.targetOven).NPCUserObject != base.Npc.NetworkObject)) && this.targetOven.CurrentOperation != null && this.targetOven.CurrentOperation.IsReady() && this.targetOven.CanOutputSpaceFitCurrentOperation();
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x00079608 File Offset: 0x00077808
		private void StopAction()
		{
			this.targetOven.SetNPCUser(null);
			base.Npc.SetEquippable_Networked(null, string.Empty);
			base.Npc.SetAnimationBool_Networked(null, "UseHammer", false);
			if (this.actionRoutine != null)
			{
				base.StopCoroutine(this.actionRoutine);
				this.actionRoutine = null;
			}
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x0007965F File Offset: 0x0007785F
		private Vector3 GetStationAccessPoint()
		{
			if (this.targetOven == null)
			{
				return base.Npc.transform.position;
			}
			return ((ITransitEntity)this.targetOven).AccessPoints[0].position;
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00079692 File Offset: 0x00077892
		private bool IsAtStation()
		{
			return !(this.targetOven == null) && Vector3.Distance(base.Npc.transform.position, this.GetStationAccessPoint()) < 1f;
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x000796C6 File Offset: 0x000778C6
		[CompilerGenerated]
		private IEnumerator <StartAction>g__ActionRoutine|11_0()
		{
			this.targetOven.SetNPCUser(base.Npc.NetworkObject);
			base.Npc.Movement.FacePoint(this.targetOven.transform.position, 0.5f);
			yield return new WaitForSeconds(0.5f);
			if (!this.CanActionStart())
			{
				this.StopAction();
				base.End_Networked(null);
				yield break;
			}
			base.Npc.SetEquippable_Networked(null, "Avatar/Equippables/Hammer");
			this.targetOven.Door.SetPosition(1f);
			this.targetOven.WireTray.SetPosition(1f);
			yield return new WaitForSeconds(0.5f);
			this.targetOven.SquareTray.SetParent(this.targetOven.transform);
			this.targetOven.RemoveTrayAnimation.Play();
			yield return new WaitForSeconds(0.1f);
			this.targetOven.Door.SetPosition(0f);
			yield return new WaitForSeconds(1f);
			base.Npc.SetAnimationBool_Networked(null, "UseHammer", true);
			yield return new WaitForSeconds(10f);
			base.Npc.SetAnimationBool_Networked(null, "UseHammer", false);
			this.targetOven.Shatter(this.targetOven.CurrentOperation.Cookable.ProductQuantity, this.targetOven.CurrentOperation.Cookable.ProductShardPrefab.gameObject);
			yield return new WaitForSeconds(1f);
			ItemInstance productItem = this.targetOven.CurrentOperation.GetProductItem(this.targetOven.CurrentOperation.Cookable.ProductQuantity * this.targetOven.CurrentOperation.IngredientQuantity);
			this.targetOven.OutputSlot.AddItem(productItem, false);
			this.targetOven.SendCookOperation(null);
			this.StopAction();
			base.End_Networked(null);
			yield break;
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x000796D5 File Offset: 0x000778D5
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FinishLabOvenBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FinishLabOvenBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_StartAction_2166136261));
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x00079705 File Offset: 0x00077905
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FinishLabOvenBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FinishLabOvenBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x0007971E File Offset: 0x0007791E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x0007972C File Offset: 0x0007792C
		private void RpcWriter___Observers_StartAction_2166136261()
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

		// Token: 0x06001D80 RID: 7552 RVA: 0x000797D5 File Offset: 0x000779D5
		private void RpcLogic___StartAction_2166136261()
		{
			if (this.actionRoutine != null)
			{
				return;
			}
			if (this.targetOven == null)
			{
				return;
			}
			this.actionRoutine = base.StartCoroutine(this.<StartAction>g__ActionRoutine|11_0());
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x00079804 File Offset: 0x00077A04
		private void RpcReader___Observers_StartAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___StartAction_2166136261();
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x0007982E File Offset: 0x00077A2E
		protected virtual void dll()
		{
			base.Awake();
			this.chemist = (base.Npc as Chemist);
		}

		// Token: 0x040017B1 RID: 6065
		public const float HARVEST_TIME = 10f;

		// Token: 0x040017B3 RID: 6067
		private Chemist chemist;

		// Token: 0x040017B4 RID: 6068
		private Coroutine actionRoutine;

		// Token: 0x040017B5 RID: 6069
		private bool dll_Excuted;

		// Token: 0x040017B6 RID: 6070
		private bool dll_Excuted;
	}
}
