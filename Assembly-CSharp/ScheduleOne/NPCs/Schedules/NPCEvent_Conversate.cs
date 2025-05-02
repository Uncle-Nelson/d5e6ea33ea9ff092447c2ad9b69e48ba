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
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000474 RID: 1140
	public class NPCEvent_Conversate : NPCEvent
	{
		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x0006A70B File Offset: 0x0006890B
		public new string ActionName
		{
			get
			{
				return "Conversate";
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x0006A712 File Offset: 0x00068912
		private Transform StandPoint
		{
			get
			{
				return this.Location.GetStandPoint(this.npc);
			}
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x0006A728 File Offset: 0x00068928
		public override string GetName()
		{
			if (this.Location == null)
			{
				return this.ActionName + " (No destination set)";
			}
			return this.ActionName + " (" + this.Location.gameObject.name + ")";
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x0006A779 File Offset: 0x00068979
		protected override void Start()
		{
			base.Start();
			this.Location.NPCs.Add(this.npc);
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0006A797 File Offset: 0x00068997
		public override void Started()
		{
			base.Started();
			if (this.IsAtDestination())
			{
				this.WalkCallback(NPCMovement.WalkResult.Success);
				return;
			}
			base.SetDestination(this.StandPoint.position, true);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x0006A7C4 File Offset: 0x000689C4
		public override void ActiveUpdate()
		{
			base.ActiveUpdate();
			if (this.npc.Movement.IsMoving)
			{
				this.Location.SetNPCReady(this.npc, false);
				this.timeAtDestination = 0f;
				return;
			}
			if (this.IsAtDestination())
			{
				this.Location.SetNPCReady(this.npc, true);
				this.timeAtDestination += Time.deltaTime;
				return;
			}
			this.Location.SetNPCReady(this.npc, false);
			this.timeAtDestination = 0f;
			base.SetDestination(this.StandPoint.position, true);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x0006A864 File Offset: 0x00068A64
		public override void MinPassed()
		{
			base.MinPassed();
			if (InstanceFinder.IsServer)
			{
				if (!this.IsConversating && this.timeAtDestination >= 0.1f && this.CanConversationStart())
				{
					this.StartConversate();
				}
				if (!this.IsConversating && !this.IsWaiting && this.timeAtDestination >= 3f && !this.CanConversationStart())
				{
					this.StartWait();
				}
				if (this.IsConversating && !this.CanConversationStart())
				{
					this.EndConversate();
				}
			}
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x0006A8E2 File Offset: 0x00068AE2
		public override void LateStarted()
		{
			base.LateStarted();
			if (this.IsAtDestination())
			{
				this.WalkCallback(NPCMovement.WalkResult.Success);
				return;
			}
			base.SetDestination(this.StandPoint.position, true);
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0006A90C File Offset: 0x00068B0C
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
					this.npc.Movement.Warp(this.StandPoint.position);
				}
				this.npc.Movement.FaceDirection(this.StandPoint.forward, 0.5f);
			}
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0006A98B File Offset: 0x00068B8B
		public override void End()
		{
			base.End();
			this.Location.SetNPCReady(this.npc, false);
			if (this.IsWaiting)
			{
				this.EndWait();
			}
			if (this.IsConversating)
			{
				this.EndConversate();
			}
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x0006A9C4 File Offset: 0x00068BC4
		public override void Interrupt()
		{
			base.Interrupt();
			this.Location.SetNPCReady(this.npc, false);
			if (this.npc.Movement.IsMoving)
			{
				this.npc.Movement.Stop();
			}
			if (this.IsWaiting)
			{
				this.EndWait();
			}
			if (this.IsConversating)
			{
				this.EndConversate();
			}
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x0006AA27 File Offset: 0x00068C27
		public override void Resume()
		{
			base.Resume();
			if (this.IsAtDestination())
			{
				this.WalkCallback(NPCMovement.WalkResult.Success);
				return;
			}
			base.SetDestination(this.StandPoint.position, true);
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x0006AA51 File Offset: 0x00068C51
		private bool IsAtDestination()
		{
			return Vector3.Distance(this.npc.Movement.FootPosition, this.StandPoint.position) < 1f;
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x0006AA7A File Offset: 0x00068C7A
		private bool CanConversationStart()
		{
			return this.Location.NPCsReady;
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x0006AA87 File Offset: 0x00068C87
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
			this.npc.Movement.FaceDirection(this.StandPoint.forward, 0.5f);
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0006AABE File Offset: 0x00068CBE
		[ObserversRpc(RunLocally = true)]
		protected virtual void StartWait()
		{
			this.RpcWriter___Observers_StartWait_2166136261();
			this.RpcLogic___StartWait_2166136261();
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x0006AACC File Offset: 0x00068CCC
		[ObserversRpc(RunLocally = true)]
		protected virtual void EndWait()
		{
			this.RpcWriter___Observers_EndWait_2166136261();
			this.RpcLogic___EndWait_2166136261();
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x0006AADA File Offset: 0x00068CDA
		[ObserversRpc(RunLocally = true)]
		protected virtual void StartConversate()
		{
			this.RpcWriter___Observers_StartConversate_2166136261();
			this.RpcLogic___StartConversate_2166136261();
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x0006AAE8 File Offset: 0x00068CE8
		[ObserversRpc(RunLocally = true)]
		protected virtual void EndConversate()
		{
			this.RpcWriter___Observers_EndConversate_2166136261();
			this.RpcLogic___EndConversate_2166136261();
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0006AB4E File Offset: 0x00068D4E
		[CompilerGenerated]
		private IEnumerator <StartConversate>g__Routine|30_0()
		{
			while (this.IsConversating)
			{
				Random.InitState(this.npc.fullName.GetHashCode() + (int)Time.time);
				float wait = Random.Range(2f, 8f);
				NPC otherNPC = this.Location.GetOtherNPC(this.npc);
				for (float t = 0f; t < wait; t += Time.deltaTime)
				{
					if (!this.IsConversating)
					{
						yield break;
					}
					this.npc.Avatar.LookController.OverrideLookTarget(otherNPC.Avatar.LookController.HeadBone.position, 1, false);
					yield return new WaitForEndOfFrame();
				}
				this.npc.VoiceOverEmitter.Play(this.ConversationLines[Random.Range(0, this.ConversationLines.Length)]);
				this.npc.Avatar.Anim.SetTrigger(this.AnimationTriggers[Random.Range(0, this.AnimationTriggers.Length)]);
				otherNPC = null;
			}
			yield break;
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x0006AB60 File Offset: 0x00068D60
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_ConversateAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_ConversateAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_StartWait_2166136261));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_EndWait_2166136261));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_StartConversate_2166136261));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_EndConversate_2166136261));
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0006ABE0 File Offset: 0x00068DE0
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_ConversateAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_ConversateAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x0006ABF9 File Offset: 0x00068DF9
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x0006AC08 File Offset: 0x00068E08
		private void RpcWriter___Observers_StartWait_2166136261()
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

		// Token: 0x06001840 RID: 6208 RVA: 0x0006ACB1 File Offset: 0x00068EB1
		protected virtual void RpcLogic___StartWait_2166136261()
		{
			if (this.IsWaiting)
			{
				return;
			}
			this.IsWaiting = true;
			if (this.OnWaitStart != null)
			{
				this.OnWaitStart.Invoke();
			}
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0006ACD8 File Offset: 0x00068ED8
		private void RpcReader___Observers_StartWait_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___StartWait_2166136261();
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0006AD04 File Offset: 0x00068F04
		private void RpcWriter___Observers_EndWait_2166136261()
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
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0006ADAD File Offset: 0x00068FAD
		protected virtual void RpcLogic___EndWait_2166136261()
		{
			if (!this.IsWaiting)
			{
				return;
			}
			this.IsWaiting = false;
			if (this.OnWaitEnd != null)
			{
				this.OnWaitEnd.Invoke();
			}
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0006ADD4 File Offset: 0x00068FD4
		private void RpcReader___Observers_EndWait_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___EndWait_2166136261();
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x0006AE00 File Offset: 0x00069000
		private void RpcWriter___Observers_StartConversate_2166136261()
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

		// Token: 0x06001846 RID: 6214 RVA: 0x0006AEA9 File Offset: 0x000690A9
		protected virtual void RpcLogic___StartConversate_2166136261()
		{
			if (this.IsConversating)
			{
				return;
			}
			if (this.IsWaiting)
			{
				this.EndWait();
			}
			this.IsConversating = true;
			this.conversateRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.<StartConversate>g__Routine|30_0());
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x0006AEE0 File Offset: 0x000690E0
		private void RpcReader___Observers_StartConversate_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___StartConversate_2166136261();
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0006AF0C File Offset: 0x0006910C
		private void RpcWriter___Observers_EndConversate_2166136261()
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
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0006AFB5 File Offset: 0x000691B5
		protected virtual void RpcLogic___EndConversate_2166136261()
		{
			if (!this.IsConversating)
			{
				return;
			}
			this.IsConversating = false;
			this.timeAtDestination = 0f;
			if (this.conversateRoutine != null)
			{
				base.StopCoroutine(this.conversateRoutine);
			}
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0006AFE8 File Offset: 0x000691E8
		private void RpcReader___Observers_EndConversate_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___EndConversate_2166136261();
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x0006B012 File Offset: 0x00069212
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040015A1 RID: 5537
		private EVOLineType[] ConversationLines = new EVOLineType[]
		{
			EVOLineType.Greeting,
			EVOLineType.Question,
			EVOLineType.Surprised,
			EVOLineType.Alerted,
			EVOLineType.Annoyed,
			EVOLineType.Acknowledge,
			EVOLineType.Think,
			EVOLineType.No
		};

		// Token: 0x040015A2 RID: 5538
		private string[] AnimationTriggers = new string[]
		{
			"ThumbsUp",
			"DisagreeWave",
			"Nod",
			"ConversationGesture1"
		};

		// Token: 0x040015A3 RID: 5539
		public const float DESTINATION_THRESHOLD = 1f;

		// Token: 0x040015A4 RID: 5540
		public const float TIME_BEFORE_WAIT_START = 3f;

		// Token: 0x040015A5 RID: 5541
		public ConversationLocation Location;

		// Token: 0x040015A6 RID: 5542
		private bool IsConversating;

		// Token: 0x040015A7 RID: 5543
		private Coroutine conversateRoutine;

		// Token: 0x040015A8 RID: 5544
		private bool IsWaiting;

		// Token: 0x040015A9 RID: 5545
		public UnityEvent OnWaitStart;

		// Token: 0x040015AA RID: 5546
		public UnityEvent OnWaitEnd;

		// Token: 0x040015AB RID: 5547
		private float timeAtDestination;

		// Token: 0x040015AC RID: 5548
		private bool dll_Excuted;

		// Token: 0x040015AD RID: 5549
		private bool dll_Excuted;
	}
}
