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
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x020004F3 RID: 1267
	public class BrickPressBehaviour : Behaviour
	{
		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x0007807E File Offset: 0x0007627E
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x00078086 File Offset: 0x00076286
		public BrickPress Press { get; protected set; }

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x0007808F File Offset: 0x0007628F
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x00078097 File Offset: 0x00076297
		public bool PackagingInProgress { get; protected set; }

		// Token: 0x06001D0A RID: 7434 RVA: 0x000780A0 File Offset: 0x000762A0
		protected override void Begin()
		{
			base.Begin();
			this.StartPackaging();
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x000780AE File Offset: 0x000762AE
		protected override void Resume()
		{
			base.Resume();
			this.StartPackaging();
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x000780BC File Offset: 0x000762BC
		protected override void Pause()
		{
			base.Pause();
			if (this.PackagingInProgress)
			{
				this.StopPackaging();
			}
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00077BBF File Offset: 0x00075DBF
		public override void Disable()
		{
			base.Disable();
			if (base.Active)
			{
				this.End();
			}
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x000780D4 File Offset: 0x000762D4
		protected override void End()
		{
			base.End();
			if (this.PackagingInProgress)
			{
				this.StopPackaging();
			}
			if (InstanceFinder.IsServer && this.Press != null && this.Press.NPCUserObject == base.Npc.NetworkObject)
			{
				this.Press.SetNPCUser(null);
			}
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00078134 File Offset: 0x00076334
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.PackagingInProgress)
			{
				if (this.IsStationReady(this.Press))
				{
					if (base.Npc.Movement.IsMoving)
					{
						return;
					}
					if (this.IsAtStation())
					{
						this.BeginPackaging();
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

		// Token: 0x06001D10 RID: 7440 RVA: 0x00078198 File Offset: 0x00076398
		private void StartPackaging()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.IsStationReady(this.Press))
			{
				Console.LogWarning(base.Npc.fullName + " has no station to work with", null);
				base.Disable_Networked(null);
				return;
			}
			this.Press.SetNPCUser(base.Npc.NetworkObject);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x000781F4 File Offset: 0x000763F4
		public void AssignStation(BrickPress press)
		{
			this.Press = press;
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x000781FD File Offset: 0x000763FD
		public bool IsAtStation()
		{
			return base.Npc.Movement.IsAsCloseAsPossible(this.Press.StandPoint.position, 0.5f);
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x00078224 File Offset: 0x00076424
		public void GoToStation()
		{
			base.Npc.Movement.SetDestination(this.Press.StandPoint.position);
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x00078248 File Offset: 0x00076448
		[ObserversRpc(RunLocally = true)]
		public void BeginPackaging()
		{
			this.RpcWriter___Observers_BeginPackaging_2166136261();
			this.RpcLogic___BeginPackaging_2166136261();
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00078261 File Offset: 0x00076461
		private void StopPackaging()
		{
			if (this.packagingRoutine != null)
			{
				base.StopCoroutine(this.packagingRoutine);
			}
			this.PackagingInProgress = false;
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00078280 File Offset: 0x00076480
		public bool IsStationReady(BrickPress press)
		{
			return !(press == null) && press.GetState() == PackagingStation.EState.CanBegin && (!((IUsable)press).IsInUse || !(press.NPCUserObject != base.Npc.NetworkObject)) && base.Npc.Movement.CanGetTo(press.StandPoint.position, 1f);
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x000782E9 File Offset: 0x000764E9
		[CompilerGenerated]
		private IEnumerator <BeginPackaging>g__Package|20_0()
		{
			yield return new WaitForEndOfFrame();
			base.Npc.Avatar.Anim.SetBool("UsePackagingStation", true);
			float packageTime = 15f / (base.Npc as Packager).PackagingSpeedMultiplier;
			for (float i = 0f; i < packageTime; i += Time.deltaTime)
			{
				base.Npc.Avatar.LookController.OverrideLookTarget(this.Press.uiPoint.position, 0, false);
				yield return new WaitForEndOfFrame();
			}
			base.Npc.Avatar.Anim.SetBool("UsePackagingStation", false);
			yield return new WaitForSeconds(0.2f);
			base.Npc.Avatar.Anim.SetTrigger("GrabItem");
			this.Press.PlayPressAnim();
			yield return new WaitForSeconds(1f);
			ProductItemInstance product;
			if (InstanceFinder.IsServer && this.Press.HasSufficientProduct(out product))
			{
				this.Press.CompletePress(product);
			}
			this.PackagingInProgress = false;
			this.packagingRoutine = null;
			yield break;
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x000782F8 File Offset: 0x000764F8
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BrickPressBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BrickPressBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_BeginPackaging_2166136261));
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00078328 File Offset: 0x00076528
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BrickPressBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BrickPressBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00078341 File Offset: 0x00076541
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x00078350 File Offset: 0x00076550
		private void RpcWriter___Observers_BeginPackaging_2166136261()
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

		// Token: 0x06001D1D RID: 7453 RVA: 0x000783FC File Offset: 0x000765FC
		public void RpcLogic___BeginPackaging_2166136261()
		{
			if (this.PackagingInProgress)
			{
				return;
			}
			if (this.Press == null)
			{
				return;
			}
			this.PackagingInProgress = true;
			base.Npc.Movement.FaceDirection(this.Press.StandPoint.forward, 0.5f);
			this.packagingRoutine = base.StartCoroutine(this.<BeginPackaging>g__Package|20_0());
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00078460 File Offset: 0x00076660
		private void RpcReader___Observers_BeginPackaging_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___BeginPackaging_2166136261();
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x0007848A File Offset: 0x0007668A
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400178E RID: 6030
		public const float BASE_PACKAGING_TIME = 15f;

		// Token: 0x04001791 RID: 6033
		private Coroutine packagingRoutine;

		// Token: 0x04001792 RID: 6034
		private bool dll_Excuted;

		// Token: 0x04001793 RID: 6035
		private bool dll_Excuted;
	}
}
