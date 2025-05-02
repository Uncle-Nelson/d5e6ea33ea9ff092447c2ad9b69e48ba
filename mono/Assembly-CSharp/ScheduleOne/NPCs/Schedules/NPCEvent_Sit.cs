using System;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using FluffyUnderware.DevTools.Extensions;
using ScheduleOne.AvatarFramework.Animation;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000478 RID: 1144
	public class NPCEvent_Sit : NPCEvent
	{
		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x0006C096 File Offset: 0x0006A296
		public new string ActionName
		{
			get
			{
				return "Sit";
			}
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x0006C0A0 File Offset: 0x0006A2A0
		public override string GetName()
		{
			string text = this.ActionName;
			if (this.SeatSet == null)
			{
				text += "(no seat assigned)";
			}
			return text;
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0006C0D0 File Offset: 0x0006A2D0
		public override void Started()
		{
			base.Started();
			this.seated = false;
			if (this.IsAtDestination())
			{
				this.WalkCallback(NPCMovement.WalkResult.Success);
				return;
			}
			this.targetSeat = this.SeatSet.GetRandomFreeSeat();
			base.SetDestination(this.targetSeat.AccessPoint.position, true);
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x0006C124 File Offset: 0x0006A324
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (!base.IsActive)
			{
				return;
			}
			if (this.seated)
			{
				this.StartAction(connection, ArrayExt.IndexOf<AvatarSeat>(this.SeatSet.Seats, this.npc.Avatar.Anim.CurrentSeat));
			}
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x0006C178 File Offset: 0x0006A378
		public override void LateStarted()
		{
			base.LateStarted();
			this.seated = false;
			if (this.IsAtDestination())
			{
				this.WalkCallback(NPCMovement.WalkResult.Success);
				return;
			}
			this.targetSeat = this.SeatSet.GetRandomFreeSeat();
			base.SetDestination(this.targetSeat.AccessPoint.position, true);
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0006C1CC File Offset: 0x0006A3CC
		public override void ActiveMinPassed()
		{
			base.ActiveMinPassed();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.schedule.DEBUG_MODE)
			{
				Debug.Log("ActiveMinPassed");
				Debug.Log("Moving: " + this.npc.Movement.IsMoving.ToString());
				Debug.Log("At destination: " + this.IsAtDestination().ToString());
				Debug.Log("Seated: " + this.seated.ToString());
			}
			if (!base.IsActive)
			{
				return;
			}
			if (!this.npc.Movement.IsMoving)
			{
				if (this.IsAtDestination() || this.seated)
				{
					if (!this.seated)
					{
						if (!this.npc.Movement.FaceDirectionInProgress)
						{
							this.npc.Movement.FaceDirection(this.targetSeat.SittingPoint.forward, 0.5f);
						}
						if (Vector3.Angle(this.npc.Movement.transform.forward, this.targetSeat.SittingPoint.forward) < 10f)
						{
							this.StartAction(null, ArrayExt.IndexOf<AvatarSeat>(this.SeatSet.Seats, this.SeatSet.GetRandomFreeSeat()));
							return;
						}
					}
					else if (!this.npc.Movement.FaceDirectionInProgress && Vector3.Angle(this.npc.Movement.transform.forward, this.targetSeat.SittingPoint.forward) > 15f)
					{
						this.npc.Movement.FaceDirection(this.targetSeat.SittingPoint.forward, 0.5f);
						return;
					}
				}
				else
				{
					base.SetDestination(this.targetSeat.AccessPoint.position, true);
				}
			}
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0006C3A8 File Offset: 0x0006A5A8
		public override void JumpTo()
		{
			base.JumpTo();
			if (!this.IsAtDestination())
			{
				if (this.npc.Movement.IsMoving)
				{
					this.npc.Movement.Stop();
				}
				this.targetSeat = this.SeatSet.GetRandomFreeSeat();
				if (InstanceFinder.IsServer)
				{
					this.npc.Movement.Warp(this.targetSeat.AccessPoint.position);
					this.StartAction(null, ArrayExt.IndexOf<AvatarSeat>(this.SeatSet.Seats, this.SeatSet.GetRandomFreeSeat()));
				}
				this.npc.Movement.FaceDirection(this.targetSeat.AccessPoint.forward, 0f);
			}
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0006C467 File Offset: 0x0006A667
		public override void End()
		{
			base.End();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.seated)
			{
				this.EndAction();
			}
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x0006C485 File Offset: 0x0006A685
		public override void Interrupt()
		{
			base.Interrupt();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.npc.Movement.IsMoving)
			{
				this.npc.Movement.Stop();
			}
			if (this.seated)
			{
				this.EndAction();
			}
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x0006C4C5 File Offset: 0x0006A6C5
		public override void Resume()
		{
			base.Resume();
			if (this.IsAtDestination())
			{
				this.WalkCallback(NPCMovement.WalkResult.Success);
				return;
			}
			this.targetSeat = this.SeatSet.GetRandomFreeSeat();
			base.SetDestination(this.targetSeat.AccessPoint.position, true);
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x0006C508 File Offset: 0x0006A708
		public override void Skipped()
		{
			base.Skipped();
			if (this.WarpIfSkipped)
			{
				this.targetSeat = this.SeatSet.GetRandomFreeSeat();
				this.npc.Movement.Warp(this.targetSeat.AccessPoint.position);
			}
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0006C554 File Offset: 0x0006A754
		private bool IsAtDestination()
		{
			return !(this.targetSeat == null) && Vector3.Distance(this.npc.Movement.FootPosition, this.targetSeat.AccessPoint.position) < 1.5f;
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x0006C594 File Offset: 0x0006A794
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
			base.WalkCallback(result);
			if (!base.IsActive)
			{
				return;
			}
			if (result != NPCMovement.WalkResult.Success)
			{
				return;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			this.StartAction(null, ArrayExt.IndexOf<AvatarSeat>(this.SeatSet.Seats, this.SeatSet.GetRandomFreeSeat()));
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x0006C5E0 File Offset: 0x0006A7E0
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		protected virtual void StartAction(NetworkConnection conn, int seatIndex)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_StartAction_2681120339(conn, seatIndex);
				this.RpcLogic___StartAction_2681120339(conn, seatIndex);
			}
			else
			{
				this.RpcWriter___Target_StartAction_2681120339(conn, seatIndex);
			}
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x0006C621 File Offset: 0x0006A821
		[ObserversRpc(RunLocally = true)]
		protected virtual void EndAction()
		{
			this.RpcWriter___Observers_EndAction_2166136261();
			this.RpcLogic___EndAction_2166136261();
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x0006C638 File Offset: 0x0006A838
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_SitAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_SitAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_StartAction_2681120339));
			base.RegisterTargetRpc(1U, new ClientRpcDelegate(this.RpcReader___Target_StartAction_2681120339));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_EndAction_2166136261));
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0006C6A1 File Offset: 0x0006A8A1
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_SitAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_SitAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0006C6BA File Offset: 0x0006A8BA
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x0006C6C8 File Offset: 0x0006A8C8
		private void RpcWriter___Observers_StartAction_2681120339(NetworkConnection conn, int seatIndex)
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
			writer.WriteInt32(seatIndex, AutoPackType.Packed);
			base.SendObserversRpc(0U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x0006C784 File Offset: 0x0006A984
		protected virtual void RpcLogic___StartAction_2681120339(NetworkConnection conn, int seatIndex)
		{
			if (this.seated)
			{
				return;
			}
			this.seated = true;
			if (seatIndex >= 0 && seatIndex < this.SeatSet.Seats.Length)
			{
				this.targetSeat = this.SeatSet.Seats[seatIndex];
			}
			else
			{
				this.targetSeat = null;
			}
			this.npc.Movement.SetSeat(this.targetSeat);
			if (this.onSeated != null)
			{
				this.onSeated.Invoke();
			}
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0006C7FC File Offset: 0x0006A9FC
		private void RpcReader___Observers_StartAction_2681120339(PooledReader PooledReader0, Channel channel)
		{
			int seatIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___StartAction_2681120339(null, seatIndex);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0006C840 File Offset: 0x0006AA40
		private void RpcWriter___Target_StartAction_2681120339(NetworkConnection conn, int seatIndex)
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
			writer.WriteInt32(seatIndex, AutoPackType.Packed);
			base.SendTargetRpc(1U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0006C8FC File Offset: 0x0006AAFC
		private void RpcReader___Target_StartAction_2681120339(PooledReader PooledReader0, Channel channel)
		{
			int seatIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___StartAction_2681120339(base.LocalConnection, seatIndex);
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0006C938 File Offset: 0x0006AB38
		private void RpcWriter___Observers_EndAction_2166136261()
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
			base.SendObserversRpc(2U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0006C9E1 File Offset: 0x0006ABE1
		protected virtual void RpcLogic___EndAction_2166136261()
		{
			if (!this.seated)
			{
				return;
			}
			this.seated = false;
			this.npc.Movement.SetSeat(null);
			if (this.onStandUp != null)
			{
				this.onStandUp.Invoke();
			}
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0006CA18 File Offset: 0x0006AC18
		private void RpcReader___Observers_EndAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___EndAction_2166136261();
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0006CA42 File Offset: 0x0006AC42
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040015C7 RID: 5575
		public const float DESTINATION_THRESHOLD = 1.5f;

		// Token: 0x040015C8 RID: 5576
		public AvatarSeatSet SeatSet;

		// Token: 0x040015C9 RID: 5577
		public bool WarpIfSkipped;

		// Token: 0x040015CA RID: 5578
		private bool seated;

		// Token: 0x040015CB RID: 5579
		private AvatarSeat targetSeat;

		// Token: 0x040015CC RID: 5580
		public UnityEvent onSeated;

		// Token: 0x040015CD RID: 5581
		public UnityEvent onStandUp;

		// Token: 0x040015CE RID: 5582
		private bool dll_Excuted;

		// Token: 0x040015CF RID: 5583
		private bool dll_Excuted;
	}
}
