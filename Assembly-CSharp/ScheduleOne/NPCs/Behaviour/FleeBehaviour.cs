using System;
using FishNet;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200051B RID: 1307
	public class FleeBehaviour : Behaviour
	{
		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001F27 RID: 7975 RVA: 0x0007F8DB File Offset: 0x0007DADB
		// (set) Token: 0x06001F28 RID: 7976 RVA: 0x0007F8E3 File Offset: 0x0007DAE3
		public NetworkObject EntityToFlee { get; private set; }

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x0007F8EC File Offset: 0x0007DAEC
		public Vector3 PointToFlee
		{
			get
			{
				if (this.FleeMode != FleeBehaviour.EFleeMode.Point)
				{
					return this.EntityToFlee.transform.position;
				}
				return this.FleeOrigin;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x0007F90E File Offset: 0x0007DB0E
		// (set) Token: 0x06001F2B RID: 7979 RVA: 0x0007F916 File Offset: 0x0007DB16
		public FleeBehaviour.EFleeMode FleeMode { get; private set; }

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x0007F91F File Offset: 0x0007DB1F
		// (set) Token: 0x06001F2D RID: 7981 RVA: 0x0007F927 File Offset: 0x0007DB27
		public Vector3 FleeOrigin { get; private set; } = Vector3.zero;

		// Token: 0x06001F2E RID: 7982 RVA: 0x0007F930 File Offset: 0x0007DB30
		[ObserversRpc(RunLocally = true)]
		public void SetEntityToFlee(NetworkObject entity)
		{
			this.RpcWriter___Observers_SetEntityToFlee_3323014238(entity);
			this.RpcLogic___SetEntityToFlee_3323014238(entity);
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x0007F946 File Offset: 0x0007DB46
		[ObserversRpc(RunLocally = true)]
		public void SetPointToFlee(Vector3 point)
		{
			this.RpcWriter___Observers_SetPointToFlee_4276783012(point);
			this.RpcLogic___SetPointToFlee_4276783012(point);
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x0007F95C File Offset: 0x0007DB5C
		protected override void Begin()
		{
			base.Begin();
			this.StartFlee();
			EVOLineType lineType = (Random.Range(0, 2) == 0) ? EVOLineType.Scared : EVOLineType.Concerned;
			base.Npc.PlayVO(lineType);
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x0007F990 File Offset: 0x0007DB90
		protected override void Resume()
		{
			base.Resume();
			this.StartFlee();
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x0007F99E File Offset: 0x0007DB9E
		protected override void End()
		{
			base.End();
			this.Stop();
			base.Npc.Avatar.EmotionManager.RemoveEmotionOverride("fleeing");
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x0007F9C6 File Offset: 0x0007DBC6
		protected override void Pause()
		{
			base.Pause();
			this.Stop();
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x0007F9D4 File Offset: 0x0007DBD4
		private void StartFlee()
		{
			this.Flee();
			base.Npc.Avatar.EmotionManager.AddEmotionOverride("Scared", "fleeing", 0f, 0);
			base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("fleeing", 2, 0.7f));
			this.nextVO = Time.time + Random.Range(5f, 15f);
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x0007FA4C File Offset: 0x0007DC4C
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.FleeMode == FleeBehaviour.EFleeMode.Entity && this.EntityToFlee == null)
			{
				this.End();
				return;
			}
			if (!base.Npc.Movement.IsMoving && Vector3.Distance(base.transform.position, this.currentFleeTarget) < 3f)
			{
				base.End_Networked(null);
				base.Disable_Networked(null);
				return;
			}
			Vector3 from = this.PointToFlee - base.transform.position;
			from.y = 0f;
			if (Vector3.Angle(from, base.Npc.Movement.Agent.desiredVelocity) < 30f)
			{
				Console.Log("Fleeing entity is in front, finding new flee position", null);
				this.Flee();
			}
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x0007FB18 File Offset: 0x0007DD18
		public override void BehaviourUpdate()
		{
			base.BehaviourUpdate();
			if (Time.time > this.nextVO)
			{
				EVOLineType lineType = (Random.Range(0, 2) == 0) ? EVOLineType.Scared : EVOLineType.Concerned;
				base.Npc.PlayVO(lineType);
				this.nextVO = Time.time + Random.Range(5f, 15f);
			}
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x0007FB6E File Offset: 0x0007DD6E
		private void Stop()
		{
			base.Npc.Movement.Stop();
			base.Npc.Movement.SpeedController.RemoveSpeedControl("fleeing");
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x0007FB9C File Offset: 0x0007DD9C
		private void Flee()
		{
			Vector3 fleePosition = this.GetFleePosition();
			this.currentFleeTarget = fleePosition;
			base.Npc.Movement.SetDestination(fleePosition);
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x0007FBC8 File Offset: 0x0007DDC8
		public Vector3 GetFleePosition()
		{
			int num = 0;
			float num2 = 0f;
			while (this.FleeMode != FleeBehaviour.EFleeMode.Entity || !(this.EntityToFlee == null))
			{
				Vector3 point = base.transform.position - this.PointToFlee;
				point.y = 0f;
				point = Quaternion.AngleAxis(num2, Vector3.up) * point;
				float d = Random.Range(20f, 40f);
				RaycastHit raycastHit;
				NavMeshHit navMeshHit;
				if (Physics.Raycast(base.transform.position + point.normalized * d + Vector3.up * 10f, Vector3.down, ref raycastHit, 20f, LayerMask.GetMask(new string[]
				{
					"Default"
				})) && NavMeshUtility.SamplePosition(raycastHit.point, out navMeshHit, 2f, -1, true))
				{
					return navMeshHit.position;
				}
				if (num > 10)
				{
					Console.LogWarning("Failed to find a valid flee position, returning current position", null);
					return base.transform.position;
				}
				num2 += 15f;
				num++;
			}
			return Vector3.zero;
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x0007FD00 File Offset: 0x0007DF00
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_SetEntityToFlee_3323014238));
			base.RegisterObserversRpc(16U, new ClientRpcDelegate(this.RpcReader___Observers_SetPointToFlee_4276783012));
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x0007FD52 File Offset: 0x0007DF52
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x0007FD6B File Offset: 0x0007DF6B
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x0007FD7C File Offset: 0x0007DF7C
		private void RpcWriter___Observers_SetEntityToFlee_3323014238(NetworkObject entity)
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
			writer.WriteNetworkObject(entity);
			base.SendObserversRpc(15U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x0007FE32 File Offset: 0x0007E032
		public void RpcLogic___SetEntityToFlee_3323014238(NetworkObject entity)
		{
			this.EntityToFlee = entity;
			this.FleeMode = FleeBehaviour.EFleeMode.Entity;
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x0007FE44 File Offset: 0x0007E044
		private void RpcReader___Observers_SetEntityToFlee_3323014238(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject entity = PooledReader0.ReadNetworkObject();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetEntityToFlee_3323014238(entity);
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x0007FE80 File Offset: 0x0007E080
		private void RpcWriter___Observers_SetPointToFlee_4276783012(Vector3 point)
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
			writer.WriteVector3(point);
			base.SendObserversRpc(16U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x0007FF36 File Offset: 0x0007E136
		public void RpcLogic___SetPointToFlee_4276783012(Vector3 point)
		{
			this.FleeOrigin = point;
			this.FleeMode = FleeBehaviour.EFleeMode.Point;
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x0007FF48 File Offset: 0x0007E148
		private void RpcReader___Observers_SetPointToFlee_4276783012(PooledReader PooledReader0, Channel channel)
		{
			Vector3 point = PooledReader0.ReadVector3();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetPointToFlee_4276783012(point);
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x0007FF83 File Offset: 0x0007E183
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001861 RID: 6241
		public const float FLEE_DIST_MIN = 20f;

		// Token: 0x04001862 RID: 6242
		public const float FLEE_DIST_MAX = 40f;

		// Token: 0x04001863 RID: 6243
		public const float FLEE_SPEED = 0.7f;

		// Token: 0x04001867 RID: 6247
		private Vector3 currentFleeTarget = Vector3.zero;

		// Token: 0x04001868 RID: 6248
		private float nextVO;

		// Token: 0x04001869 RID: 6249
		private bool dll_Excuted;

		// Token: 0x0400186A RID: 6250
		private bool dll_Excuted;

		// Token: 0x0200051C RID: 1308
		public enum EFleeMode
		{
			// Token: 0x0400186C RID: 6252
			Entity,
			// Token: 0x0400186D RID: 6253
			Point
		}
	}
}
