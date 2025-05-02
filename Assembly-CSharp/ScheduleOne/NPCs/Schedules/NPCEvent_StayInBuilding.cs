using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using FluffyUnderware.DevTools.Extensions;
using ScheduleOne.DevUtilities;
using ScheduleOne.Doors;
using ScheduleOne.Map;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000479 RID: 1145
	public class NPCEvent_StayInBuilding : NPCEvent
	{
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x0006CA56 File Offset: 0x0006AC56
		public new string ActionName
		{
			get
			{
				return "Stay in Building";
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x0006CA5D File Offset: 0x0006AC5D
		private bool InBuilding
		{
			get
			{
				return this.npc.CurrentBuilding == this.Building;
			}
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0006CA75 File Offset: 0x0006AC75
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Schedules.NPCEvent_StayInBuilding_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0006CA8C File Offset: 0x0006AC8C
		public override string GetName()
		{
			if (this.Building == null)
			{
				return this.ActionName + " (No building set)";
			}
			return this.ActionName + " (" + this.Building.BuildingName + ")";
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0006CAD8 File Offset: 0x0006ACD8
		public override void Started()
		{
			base.Started();
			if (!base.IsActive)
			{
				return;
			}
			if (this.Building == null)
			{
				return;
			}
			if (InstanceFinder.IsServer)
			{
				base.SetDestination(this.GetEntryPoint().position, true);
			}
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0006CB14 File Offset: 0x0006AD14
		public override void ActiveMinPassed()
		{
			base.ActiveMinPassed();
			if (!base.IsActive)
			{
				return;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.schedule.DEBUG_MODE)
			{
				Debug.Log("StayInBuilding: ActiveMinPassed");
				Debug.Log("In building: " + this.InBuilding.ToString());
				Debug.Log("Is entering: " + this.IsEntering.ToString());
			}
			if (this.Building == null || this.Building.Doors.Length == 0)
			{
				return;
			}
			if (!this.InBuilding && !this.IsEntering && (!this.npc.Movement.IsMoving || Vector3.Distance(this.npc.Movement.CurrentDestination, this.GetEntryPoint().position) > 2f))
			{
				if (Vector3.Distance(this.npc.transform.position, this.GetEntryPoint().position) < 0.5f)
				{
					this.PlayEnterAnimation();
					return;
				}
				if (this.npc.Movement.CanMove())
				{
					base.SetDestination(this.GetEntryPoint().position, true);
				}
			}
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0006CC44 File Offset: 0x0006AE44
		public override void LateStarted()
		{
			base.LateStarted();
			if (this.Building == null || this.Building.Doors.Length == 0)
			{
				return;
			}
			if (InstanceFinder.IsServer)
			{
				base.SetDestination(this.GetEntryPoint().position, true);
			}
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0006CC82 File Offset: 0x0006AE82
		public override void JumpTo()
		{
			base.JumpTo();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.npc.Movement.IsMoving)
			{
				this.npc.Movement.Stop();
			}
			this.PlayEnterAnimation();
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0006CCBA File Offset: 0x0006AEBA
		public override void End()
		{
			base.End();
			this.CancelEnter();
			if (this.InBuilding)
			{
				this.ExitBuilding();
				return;
			}
			this.npc.Movement.Stop();
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0006CCE7 File Offset: 0x0006AEE7
		public override void Interrupt()
		{
			base.Interrupt();
			this.CancelEnter();
			if (this.InBuilding)
			{
				this.ExitBuilding();
				return;
			}
			this.npc.Movement.Stop();
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0006CD14 File Offset: 0x0006AF14
		public override void Skipped()
		{
			base.Skipped();
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0006CD1C File Offset: 0x0006AF1C
		public override void Resume()
		{
			base.Resume();
			if (!this.InBuilding && InstanceFinder.IsServer)
			{
				base.SetDestination(this.GetEntryPoint().position, true);
			}
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0006CD45 File Offset: 0x0006AF45
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
			base.WalkCallback(result);
			if (!base.IsActive)
			{
				return;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (result == NPCMovement.WalkResult.Success || result == NPCMovement.WalkResult.Partial)
			{
				this.PlayEnterAnimation();
			}
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x0006CD6D File Offset: 0x0006AF6D
		[ObserversRpc(RunLocally = true)]
		private void PlayEnterAnimation()
		{
			this.RpcWriter___Observers_PlayEnterAnimation_2166136261();
			this.RpcLogic___PlayEnterAnimation_2166136261();
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0006CD7B File Offset: 0x0006AF7B
		private void CancelEnter()
		{
			this.IsEntering = false;
			if (this.enterRoutine != null)
			{
				base.StopCoroutine(this.enterRoutine);
			}
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0006CD98 File Offset: 0x0006AF98
		private void EnterBuilding(int doorIndex)
		{
			if (this.Building == null)
			{
				Console.LogWarning("Building is null in StayInBuilding event", null);
				return;
			}
			if (InstanceFinder.IsServer)
			{
				this.npc.EnterBuilding(null, this.Building.GUID.ToString(), doorIndex);
			}
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0006CDEC File Offset: 0x0006AFEC
		private void ExitBuilding()
		{
			if (InstanceFinder.IsServer)
			{
				this.npc.ExitBuilding("");
			}
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x0006CE08 File Offset: 0x0006B008
		private Transform GetEntryPoint()
		{
			if (this.Door != null)
			{
				return this.Door.AccessPoint;
			}
			if (this.Building == null)
			{
				return null;
			}
			StaticDoor closestDoor = this.Building.GetClosestDoor(this.npc.Movement.FootPosition, true);
			if (closestDoor == null)
			{
				return null;
			}
			return closestDoor.AccessPoint;
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0006CE70 File Offset: 0x0006B070
		private StaticDoor GetDoor(out int doorIndex)
		{
			doorIndex = -1;
			if (this.Door != null)
			{
				return this.Door;
			}
			if (this.Building == null)
			{
				return null;
			}
			if (this.npc == null)
			{
				return null;
			}
			StaticDoor closestDoor = this.Building.GetClosestDoor(this.npc.Movement.FootPosition, true);
			doorIndex = ArrayExt.IndexOf<StaticDoor>(this.Building.Doors, closestDoor);
			return closestDoor;
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x0006CEE6 File Offset: 0x0006B0E6
		[CompilerGenerated]
		private IEnumerator <PlayEnterAnimation>g__Enter|19_0()
		{
			this.IsEntering = true;
			yield return new WaitUntil(() => !this.npc.Movement.IsMoving);
			int doorIndex;
			StaticDoor door = this.GetDoor(out doorIndex);
			if (door != null)
			{
				Transform faceDir = door.transform;
				this.npc.Movement.FacePoint(faceDir.position, 0.5f);
				float t = 0f;
				while (Vector3.SignedAngle(this.npc.Avatar.transform.forward, faceDir.position - this.npc.Avatar.CenterPoint, Vector3.up) > 15f && t < 1f)
				{
					yield return new WaitForEndOfFrame();
					t += Time.deltaTime;
				}
				faceDir = null;
			}
			this.npc.Avatar.Anim.SetTrigger("GrabItem");
			yield return new WaitForSeconds(0.6f);
			this.IsEntering = false;
			this.enterRoutine = null;
			this.EnterBuilding(doorIndex);
			yield break;
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x0006CF0A File Offset: 0x0006B10A
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_StayInBuildingAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_StayInBuildingAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_PlayEnterAnimation_2166136261));
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x0006CF3A File Offset: 0x0006B13A
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_StayInBuildingAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_StayInBuildingAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0006CF53 File Offset: 0x0006B153
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0006CF64 File Offset: 0x0006B164
		private void RpcWriter___Observers_PlayEnterAnimation_2166136261()
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

		// Token: 0x060018C0 RID: 6336 RVA: 0x0006D00D File Offset: 0x0006B20D
		private void RpcLogic___PlayEnterAnimation_2166136261()
		{
			if (this.IsEntering)
			{
				return;
			}
			this.enterRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.<PlayEnterAnimation>g__Enter|19_0());
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x0006D030 File Offset: 0x0006B230
		private void RpcReader___Observers_PlayEnterAnimation_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___PlayEnterAnimation_2166136261();
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0006D05A File Offset: 0x0006B25A
		protected virtual void dll()
		{
			base.Awake();
		}

		// Token: 0x040015D0 RID: 5584
		public NPCEnterableBuilding Building;

		// Token: 0x040015D1 RID: 5585
		[Header("Optionally specify door to use. Otherwise closest door will be used.")]
		public StaticDoor Door;

		// Token: 0x040015D2 RID: 5586
		private bool IsEntering;

		// Token: 0x040015D3 RID: 5587
		private Coroutine enterRoutine;

		// Token: 0x040015D4 RID: 5588
		private bool dll_Excuted;

		// Token: 0x040015D5 RID: 5589
		private bool dll_Excuted;
	}
}
