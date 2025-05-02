using System;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000476 RID: 1142
	public class NPCEvent_LocationBasedAction : NPCEvent
	{
		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x0006B1A0 File Offset: 0x000693A0
		public new string ActionName
		{
			get
			{
				return "Location-based action";
			}
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0006B1A8 File Offset: 0x000693A8
		public override string GetName()
		{
			if (this.Destination == null)
			{
				return this.ActionName + " (No destination set)";
			}
			return this.ActionName + " (" + this.Destination.name + ")";
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0006B1F4 File Offset: 0x000693F4
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (!base.IsActive)
			{
				return;
			}
			if (this.IsActionStarted)
			{
				this.StartAction(connection);
			}
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x0006B215 File Offset: 0x00069415
		public override void Started()
		{
			base.Started();
			if (this.IsAtDestination())
			{
				this.WalkCallback(NPCMovement.WalkResult.Success);
				return;
			}
			base.SetDestination(this.Destination.position, true);
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x0006B240 File Offset: 0x00069440
		public override void ActiveMinPassed()
		{
			base.ActiveMinPassed();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.npc.Movement.IsMoving)
			{
				if (Vector3.Distance(this.npc.Movement.CurrentDestination, this.Destination.position) > this.DestinationThreshold)
				{
					base.SetDestination(this.Destination.position, true);
					return;
				}
			}
			else if (!this.IsAtDestination())
			{
				base.SetDestination(this.Destination.position, true);
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0006B2C2 File Offset: 0x000694C2
		public override void LateStarted()
		{
			base.LateStarted();
			if (this.IsAtDestination())
			{
				this.WalkCallback(NPCMovement.WalkResult.Success);
				return;
			}
			base.SetDestination(this.Destination.position, true);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0006B2EC File Offset: 0x000694EC
		public override void JumpTo()
		{
			base.JumpTo();
			if (!this.IsAtDestination())
			{
				if (this.npc.Movement.IsMoving)
				{
					this.npc.Movement.Stop();
				}
				if (InstanceFinder.IsServer)
				{
					this.npc.Movement.Warp(this.Destination.position);
				}
			}
			if (InstanceFinder.IsServer)
			{
				this.StartAction(null);
			}
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x0006B359 File Offset: 0x00069559
		public override void End()
		{
			base.End();
			if (this.IsActionStarted)
			{
				this.EndAction();
			}
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x0006B36F File Offset: 0x0006956F
		public override void Interrupt()
		{
			base.Interrupt();
			if (this.npc.Movement.IsMoving)
			{
				this.npc.Movement.Stop();
			}
			if (this.IsActionStarted)
			{
				this.EndAction();
			}
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0006B3A7 File Offset: 0x000695A7
		public override void Resume()
		{
			base.Resume();
			if (this.IsAtDestination())
			{
				this.WalkCallback(NPCMovement.WalkResult.Success);
				return;
			}
			base.SetDestination(this.Destination.position, true);
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0006B3D1 File Offset: 0x000695D1
		public override void Skipped()
		{
			base.Skipped();
			if (this.WarpIfSkipped)
			{
				this.npc.Movement.Warp(this.Destination.position);
			}
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0006B3FC File Offset: 0x000695FC
		private bool IsAtDestination()
		{
			return Vector3.Distance(this.npc.Movement.FootPosition, this.Destination.position) < this.DestinationThreshold;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0006B426 File Offset: 0x00069626
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
			if (InstanceFinder.IsServer)
			{
				this.StartAction(null);
			}
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0006B44C File Offset: 0x0006964C
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		protected virtual void StartAction(NetworkConnection conn)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_StartAction_328543758(conn);
				this.RpcLogic___StartAction_328543758(conn);
			}
			else
			{
				this.RpcWriter___Target_StartAction_328543758(conn);
			}
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0006B481 File Offset: 0x00069681
		[ObserversRpc(RunLocally = true)]
		protected virtual void EndAction()
		{
			this.RpcWriter___Observers_EndAction_2166136261();
			this.RpcLogic___EndAction_2166136261();
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x0006B4AC File Offset: 0x000696AC
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_LocationBasedActionAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_LocationBasedActionAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_StartAction_328543758));
			base.RegisterTargetRpc(1U, new ClientRpcDelegate(this.RpcReader___Target_StartAction_328543758));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_EndAction_2166136261));
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x0006B515 File Offset: 0x00069715
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_LocationBasedActionAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_LocationBasedActionAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0006B52E File Offset: 0x0006972E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0006B53C File Offset: 0x0006973C
		private void RpcWriter___Observers_StartAction_328543758(NetworkConnection conn)
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

		// Token: 0x06001866 RID: 6246 RVA: 0x0006B5E8 File Offset: 0x000697E8
		protected virtual void RpcLogic___StartAction_328543758(NetworkConnection conn)
		{
			if (this.IsActionStarted)
			{
				return;
			}
			if (this.FaceDestinationDir)
			{
				this.npc.Movement.FaceDirection(this.Destination.forward, 0.5f);
			}
			this.IsActionStarted = true;
			if (this.onStartAction != null)
			{
				this.onStartAction.Invoke();
			}
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x0006B640 File Offset: 0x00069840
		private void RpcReader___Observers_StartAction_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___StartAction_328543758(null);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0006B66C File Offset: 0x0006986C
		private void RpcWriter___Target_StartAction_328543758(NetworkConnection conn)
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
			base.SendTargetRpc(1U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0006B714 File Offset: 0x00069914
		private void RpcReader___Target_StartAction_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___StartAction_328543758(base.LocalConnection);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0006B73C File Offset: 0x0006993C
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

		// Token: 0x0600186B RID: 6251 RVA: 0x0006B7E5 File Offset: 0x000699E5
		protected virtual void RpcLogic___EndAction_2166136261()
		{
			if (!this.IsActionStarted)
			{
				return;
			}
			this.IsActionStarted = false;
			if (this.onEndAction != null)
			{
				this.onEndAction.Invoke();
			}
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0006B80C File Offset: 0x00069A0C
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

		// Token: 0x0600186D RID: 6253 RVA: 0x0006B836 File Offset: 0x00069A36
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040015B4 RID: 5556
		public Transform Destination;

		// Token: 0x040015B5 RID: 5557
		public bool FaceDestinationDir = true;

		// Token: 0x040015B6 RID: 5558
		public float DestinationThreshold = 1f;

		// Token: 0x040015B7 RID: 5559
		public bool WarpIfSkipped;

		// Token: 0x040015B8 RID: 5560
		public bool IsActionStarted;

		// Token: 0x040015B9 RID: 5561
		public UnityEvent onStartAction;

		// Token: 0x040015BA RID: 5562
		public UnityEvent onEndAction;

		// Token: 0x040015BB RID: 5563
		private bool dll_Excuted;

		// Token: 0x040015BC RID: 5564
		private bool dll_Excuted;
	}
}
