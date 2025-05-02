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
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000502 RID: 1282
	public class PackagingStationBehaviour : Behaviour
	{
		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x0007AA40 File Offset: 0x00078C40
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x0007AA48 File Offset: 0x00078C48
		public PackagingStation Station { get; protected set; }

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x0007AA51 File Offset: 0x00078C51
		// (set) Token: 0x06001DCF RID: 7631 RVA: 0x0007AA59 File Offset: 0x00078C59
		public bool PackagingInProgress { get; protected set; }

		// Token: 0x06001DD0 RID: 7632 RVA: 0x0007AA62 File Offset: 0x00078C62
		protected override void Begin()
		{
			base.Begin();
			this.StartPackaging();
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x0007AA70 File Offset: 0x00078C70
		protected override void Resume()
		{
			base.Resume();
			this.StartPackaging();
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x0007AA7E File Offset: 0x00078C7E
		protected override void Pause()
		{
			base.Pause();
			if (this.PackagingInProgress)
			{
				this.StopPackaging();
			}
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00077BBF File Offset: 0x00075DBF
		public override void Disable()
		{
			base.Disable();
			if (base.Active)
			{
				this.End();
			}
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x0007AA94 File Offset: 0x00078C94
		protected override void End()
		{
			base.End();
			if (this.PackagingInProgress)
			{
				this.StopPackaging();
			}
			if (InstanceFinder.IsServer && this.Station != null && this.Station.NPCUserObject == base.Npc.NetworkObject)
			{
				this.Station.SetNPCUser(null);
			}
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x0007AAF4 File Offset: 0x00078CF4
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.PackagingInProgress)
			{
				if (this.IsStationReady(this.Station))
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

		// Token: 0x06001DD6 RID: 7638 RVA: 0x0007AB58 File Offset: 0x00078D58
		private void StartPackaging()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.IsStationReady(this.Station))
			{
				Console.LogWarning(base.Npc.fullName + " has no station to work with", null);
				base.Disable_Networked(null);
				return;
			}
			this.Station.SetNPCUser(base.Npc.NetworkObject);
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x0007ABB4 File Offset: 0x00078DB4
		public void AssignStation(PackagingStation station)
		{
			this.Station = station;
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x0007ABBD File Offset: 0x00078DBD
		public bool IsAtStation()
		{
			return base.Npc.Movement.IsAsCloseAsPossible(this.Station.StandPoint.position, 0.5f);
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x0007ABE4 File Offset: 0x00078DE4
		public void GoToStation()
		{
			base.Npc.Movement.SetDestination(this.Station.StandPoint.position);
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x0007AC08 File Offset: 0x00078E08
		[ObserversRpc(RunLocally = true)]
		public void BeginPackaging()
		{
			this.RpcWriter___Observers_BeginPackaging_2166136261();
			this.RpcLogic___BeginPackaging_2166136261();
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x0007AC24 File Offset: 0x00078E24
		private void StopPackaging()
		{
			if (this.packagingRoutine != null)
			{
				base.StopCoroutine(this.packagingRoutine);
			}
			base.Npc.Avatar.Anim.SetBool("UsePackagingStation", false);
			if (InstanceFinder.IsServer && this.Station != null && this.Station.NPCUserObject == base.Npc.NetworkObject)
			{
				this.Station.SetNPCUser(null);
			}
			this.PackagingInProgress = false;
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x0007ACA8 File Offset: 0x00078EA8
		public bool IsStationReady(PackagingStation station)
		{
			return !(station == null) && station.GetState(PackagingStation.EMode.Package) == PackagingStation.EState.CanBegin && (!((IUsable)station).IsInUse || !(station.NPCUserObject != base.Npc.NetworkObject)) && base.Npc.Movement.CanGetTo(station.StandPoint.position, 1f);
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x0007AD12 File Offset: 0x00078F12
		[CompilerGenerated]
		private IEnumerator <BeginPackaging>g__Package|20_0()
		{
			yield return new WaitForEndOfFrame();
			base.Npc.Avatar.Anim.SetBool("UsePackagingStation", true);
			float packageTime = 5f / (base.Npc as Packager).PackagingSpeedMultiplier * this.Station.PackagerEmployeeSpeedMultiplier;
			for (float i = 0f; i < packageTime; i += Time.deltaTime)
			{
				base.Npc.Avatar.LookController.OverrideLookTarget(this.Station.Container.position, 0, false);
				yield return new WaitForEndOfFrame();
			}
			base.Npc.Avatar.Anim.SetBool("UsePackagingStation", false);
			if (InstanceFinder.IsServer)
			{
				this.Station.PackSingleInstance();
			}
			Console.Log("Packaging done!", null);
			this.PackagingInProgress = false;
			this.packagingRoutine = null;
			yield break;
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x0007AD21 File Offset: 0x00078F21
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PackagingStationBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PackagingStationBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_BeginPackaging_2166136261));
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0007AD51 File Offset: 0x00078F51
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PackagingStationBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PackagingStationBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x0007AD6A File Offset: 0x00078F6A
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x0007AD78 File Offset: 0x00078F78
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

		// Token: 0x06001DE3 RID: 7651 RVA: 0x0007AE24 File Offset: 0x00079024
		public void RpcLogic___BeginPackaging_2166136261()
		{
			if (this.PackagingInProgress)
			{
				return;
			}
			if (this.Station == null)
			{
				return;
			}
			this.PackagingInProgress = true;
			base.Npc.Movement.FaceDirection(this.Station.StandPoint.forward, 0.5f);
			this.packagingRoutine = base.StartCoroutine(this.<BeginPackaging>g__Package|20_0());
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x0007AE88 File Offset: 0x00079088
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

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0007AEB2 File Offset: 0x000790B2
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040017D9 RID: 6105
		public const float BASE_PACKAGING_TIME = 5f;

		// Token: 0x040017DC RID: 6108
		private Coroutine packagingRoutine;

		// Token: 0x040017DD RID: 6109
		private bool dll_Excuted;

		// Token: 0x040017DE RID: 6110
		private bool dll_Excuted;
	}
}
