using System;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Dialogue;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000477 RID: 1143
	public class NPCEvent_LocationDialogue : NPCEvent
	{
		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x0006B84A File Offset: 0x00069A4A
		public new string ActionName
		{
			get
			{
				return "Location-based dialogue";
			}
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0006B854 File Offset: 0x00069A54
		public override string GetName()
		{
			if (this.Destination == null)
			{
				return this.ActionName + " (No destination set)";
			}
			string actionName = this.ActionName;
			string str = " (";
			Transform destination = this.Destination;
			return actionName + str + ((destination != null) ? destination.name : null) + ")";
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x0006B8A7 File Offset: 0x00069AA7
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

		// Token: 0x06001871 RID: 6257 RVA: 0x0006B8C8 File Offset: 0x00069AC8
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

		// Token: 0x06001872 RID: 6258 RVA: 0x0006B8F4 File Offset: 0x00069AF4
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
			else if (this.IsAtDestination())
			{
				if (this.FaceDestinationDir && !this.npc.Movement.FaceDirectionInProgress && Vector3.Angle(base.transform.forward, this.Destination.forward) > 5f)
				{
					this.npc.Movement.FaceDirection(this.Destination.forward, 0.5f);
					return;
				}
			}
			else
			{
				base.SetDestination(this.Destination.position, true);
			}
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x0006B9D6 File Offset: 0x00069BD6
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

		// Token: 0x06001874 RID: 6260 RVA: 0x0006BA00 File Offset: 0x00069C00
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
				this.WalkCallback(NPCMovement.WalkResult.Success);
			}
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x0006BA6D File Offset: 0x00069C6D
		public override void End()
		{
			base.End();
			if (this.IsActionStarted)
			{
				this.EndAction();
			}
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x0006BA83 File Offset: 0x00069C83
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

		// Token: 0x06001877 RID: 6263 RVA: 0x0006BABB File Offset: 0x00069CBB
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

		// Token: 0x06001878 RID: 6264 RVA: 0x0006BAE5 File Offset: 0x00069CE5
		public override void Skipped()
		{
			base.Skipped();
			if (this.WarpIfSkipped)
			{
				this.npc.Movement.Warp(this.Destination.position);
			}
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x0006BB10 File Offset: 0x00069D10
		private bool IsAtDestination()
		{
			return Vector3.Distance(this.npc.Movement.FootPosition, this.Destination.position) < this.DestinationThreshold;
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x0006BB3A File Offset: 0x00069D3A
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

		// Token: 0x0600187B RID: 6267 RVA: 0x0006BB60 File Offset: 0x00069D60
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

		// Token: 0x0600187C RID: 6268 RVA: 0x0006BB98 File Offset: 0x00069D98
		[ObserversRpc(RunLocally = true)]
		protected virtual void EndAction()
		{
			this.RpcWriter___Observers_EndAction_2166136261();
			this.RpcLogic___EndAction_2166136261();
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x0006BBDC File Offset: 0x00069DDC
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_LocationDialogueAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_LocationDialogueAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_StartAction_328543758));
			base.RegisterTargetRpc(1U, new ClientRpcDelegate(this.RpcReader___Target_StartAction_328543758));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_EndAction_2166136261));
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x0006BC45 File Offset: 0x00069E45
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_LocationDialogueAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_LocationDialogueAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x0006BC5E File Offset: 0x00069E5E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x0006BC6C File Offset: 0x00069E6C
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

		// Token: 0x06001882 RID: 6274 RVA: 0x0006BD18 File Offset: 0x00069F18
		protected virtual void RpcLogic___StartAction_328543758(NetworkConnection conn)
		{
			if (this.IsActionStarted)
			{
				Console.LogWarning("Dialogue action already started", null);
				return;
			}
			if (this.FaceDestinationDir)
			{
				this.npc.Movement.FaceDirection(this.Destination.forward, 0.5f);
			}
			this.IsActionStarted = true;
			DialogueController component = this.npc.dialogueHandler.GetComponent<DialogueController>();
			if (this.DialogueOverride != null)
			{
				component.OverrideContainer = this.DialogueOverride;
				return;
			}
			component.OverrideContainer = null;
			if (component.GreetingOverrides.Count > this.GreetingOverrideToEnable && this.GreetingOverrideToEnable >= 0)
			{
				component.GreetingOverrides[this.GreetingOverrideToEnable].ShouldShow = true;
			}
			if (component.Choices.Count > this.ChoiceToEnable && this.ChoiceToEnable >= 0)
			{
				component.Choices[this.ChoiceToEnable].Enabled = true;
			}
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0006BE04 File Offset: 0x0006A004
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

		// Token: 0x06001884 RID: 6276 RVA: 0x0006BE30 File Offset: 0x0006A030
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

		// Token: 0x06001885 RID: 6277 RVA: 0x0006BED8 File Offset: 0x0006A0D8
		private void RpcReader___Target_StartAction_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___StartAction_328543758(base.LocalConnection);
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0006BF00 File Offset: 0x0006A100
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

		// Token: 0x06001887 RID: 6279 RVA: 0x0006BFAC File Offset: 0x0006A1AC
		protected virtual void RpcLogic___EndAction_2166136261()
		{
			if (!this.IsActionStarted)
			{
				return;
			}
			this.IsActionStarted = false;
			DialogueController component = this.npc.dialogueHandler.GetComponent<DialogueController>();
			if (this.DialogueOverride != null)
			{
				component.OverrideContainer = null;
				return;
			}
			if (component.GreetingOverrides.Count > this.GreetingOverrideToEnable && this.GreetingOverrideToEnable >= 0)
			{
				component.GreetingOverrides[this.GreetingOverrideToEnable].ShouldShow = false;
			}
			if (component.Choices.Count > this.ChoiceToEnable && this.ChoiceToEnable >= 0)
			{
				component.Choices[this.ChoiceToEnable].Enabled = false;
			}
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0006C058 File Offset: 0x0006A258
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

		// Token: 0x06001889 RID: 6281 RVA: 0x0006C082 File Offset: 0x0006A282
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040015BD RID: 5565
		public Transform Destination;

		// Token: 0x040015BE RID: 5566
		public bool FaceDestinationDir = true;

		// Token: 0x040015BF RID: 5567
		public float DestinationThreshold = 1f;

		// Token: 0x040015C0 RID: 5568
		public bool WarpIfSkipped;

		// Token: 0x040015C1 RID: 5569
		[Header("Dialogue Settings")]
		public int GreetingOverrideToEnable = -1;

		// Token: 0x040015C2 RID: 5570
		public int ChoiceToEnable = -1;

		// Token: 0x040015C3 RID: 5571
		public DialogueContainer DialogueOverride;

		// Token: 0x040015C4 RID: 5572
		protected bool IsActionStarted;

		// Token: 0x040015C5 RID: 5573
		private bool dll_Excuted;

		// Token: 0x040015C6 RID: 5574
		private bool dll_Excuted;
	}
}
