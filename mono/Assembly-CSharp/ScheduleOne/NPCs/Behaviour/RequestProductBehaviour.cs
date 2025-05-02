using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.Economy;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.Quests;
using ScheduleOne.UI;
using ScheduleOne.UI.Handover;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200052E RID: 1326
	public class RequestProductBehaviour : Behaviour
	{
		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x00083C3C File Offset: 0x00081E3C
		// (set) Token: 0x06002006 RID: 8198 RVA: 0x00083C44 File Offset: 0x00081E44
		public Player TargetPlayer { get; private set; }

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06002007 RID: 8199 RVA: 0x00083C4D File Offset: 0x00081E4D
		// (set) Token: 0x06002008 RID: 8200 RVA: 0x00083C55 File Offset: 0x00081E55
		public RequestProductBehaviour.EState State { get; private set; }

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x00083C5E File Offset: 0x00081E5E
		private Customer customer
		{
			get
			{
				return base.Npc.GetComponent<Customer>();
			}
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00083C6B File Offset: 0x00081E6B
		[ObserversRpc(RunLocally = true)]
		public void AssignTarget(NetworkObject plr)
		{
			this.RpcWriter___Observers_AssignTarget_3323014238(plr);
			this.RpcLogic___AssignTarget_3323014238(plr);
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x00083C81 File Offset: 0x00081E81
		protected virtual void Start()
		{
			this.SetUpDialogue();
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00083C8C File Offset: 0x00081E8C
		protected override void Begin()
		{
			base.Begin();
			this.State = RequestProductBehaviour.EState.InitialApproach;
			this.requestGreeting.Greeting = base.Npc.dialogueHandler.Database.GetLine(EDialogueModule.Customer, "request_product_initial");
			if (InstanceFinder.IsServer)
			{
				Transform target = NetworkSingleton<NPCManager>.Instance.GetOrderedDistanceWarpPoints(this.TargetPlayer.transform.position)[1];
				base.Npc.Movement.Warp(target);
				if (base.Npc.isInBuilding)
				{
					base.Npc.ExitBuilding("");
				}
				base.Npc.Movement.SetAgentType(NPCMovement.EAgentType.IgnoreCosts);
				base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("requestproduct", 5, 0.4f));
			}
			this.requestGreeting.ShouldShow = (this.TargetPlayer != null && this.TargetPlayer.Owner.IsLocalClient);
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00083D88 File Offset: 0x00081F88
		protected override void End()
		{
			base.End();
			if (this.requestGreeting != null)
			{
				this.requestGreeting.ShouldShow = false;
			}
			if (InstanceFinder.IsServer)
			{
				base.Npc.Movement.SetAgentType(NPCMovement.EAgentType.Humanoid);
				base.Npc.Movement.SpeedController.RemoveSpeedControl("requestproduct");
			}
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00077708 File Offset: 0x00075908
		public override void Disable()
		{
			base.Disable();
			this.End();
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x00083DE4 File Offset: 0x00081FE4
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (base.Npc.dialogueHandler.IsPlaying)
			{
				this.minsSinceLastDialogue = 0;
			}
			this.minsSinceLastDialogue++;
			if (this.TargetPlayer == null)
			{
				return;
			}
			if (this.TargetPlayer.Owner.IsLocalClient)
			{
				if (this.State == RequestProductBehaviour.EState.InitialApproach && this.CanStartDialogue())
				{
					this.SendStartInitialDialogue();
				}
				if (this.State == RequestProductBehaviour.EState.FollowPlayer && this.minsSinceLastDialogue >= 90 && this.CanStartDialogue())
				{
					this.minsSinceLastDialogue = 0;
					this.SendStartFollowUpDialogue();
				}
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (Singleton<HandoverScreen>.Instance.CurrentCustomer == this.customer)
			{
				return;
			}
			if (!RequestProductBehaviour.IsTargetValid(this.TargetPlayer))
			{
				base.SendDisable();
				return;
			}
			if (this.State == RequestProductBehaviour.EState.InitialApproach)
			{
				if (!this.IsTargetDestinationValid())
				{
					Vector3 destination;
					if (this.GetNewDestination(out destination))
					{
						base.Npc.Movement.SetDestination(destination);
						return;
					}
					base.SendDisable();
					return;
				}
			}
			else if (this.State == RequestProductBehaviour.EState.FollowPlayer && !this.IsTargetDestinationValid())
			{
				Vector3 destination2;
				if (this.GetNewDestination(out destination2))
				{
					base.Npc.Movement.SetDestination(destination2);
					return;
				}
				base.SendDisable();
				return;
			}
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x00083F18 File Offset: 0x00082118
		private bool IsTargetDestinationValid()
		{
			return base.Npc.Movement.IsMoving && Vector3.Distance(base.Npc.Movement.CurrentDestination, this.TargetPlayer.transform.position) <= ((this.State == RequestProductBehaviour.EState.InitialApproach) ? 2.5f : 5f) && base.Npc.Movement.Agent.path != null;
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00083F90 File Offset: 0x00082190
		private bool GetNewDestination(out Vector3 dest)
		{
			dest = this.TargetPlayer.transform.position;
			if (this.State == RequestProductBehaviour.EState.InitialApproach)
			{
				dest += this.TargetPlayer.transform.forward * 1.5f;
			}
			else if (this.State == RequestProductBehaviour.EState.InitialApproach)
			{
				dest += (base.Npc.transform.position - this.TargetPlayer.transform.position).normalized * 2.5f;
			}
			NavMeshHit navMeshHit;
			if (NavMeshUtility.SamplePosition(dest, out navMeshHit, 15f, -1, true))
			{
				dest = navMeshHit.position;
				return true;
			}
			Console.LogError("Failed to find valid destination for RequestProductBehaviour: stopping", null);
			return false;
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x0008406C File Offset: 0x0008226C
		public static bool IsTargetValid(Player player)
		{
			return !(player == null) && !player.IsArrested && player.Health.IsAlive && player.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.None && !player.CrimeData.BodySearchPending && !player.IsSleeping;
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x000840C8 File Offset: 0x000822C8
		public bool CanStartDialogue()
		{
			return RequestProductBehaviour.IsTargetValid(this.TargetPlayer) && this.TargetPlayer.Owner.IsLocalClient && !Singleton<DialogueCanvas>.Instance.isActive && Vector3.Distance(base.Npc.transform.position, this.TargetPlayer.transform.position) <= 2.5f && !Singleton<HandoverScreen>.Instance.IsOpen && PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount <= 0;
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x00084154 File Offset: 0x00082354
		private void SetUpDialogue()
		{
			if (this.requestGreeting != null)
			{
				return;
			}
			this.acceptRequestChoice = new DialogueController.DialogueChoice();
			this.acceptRequestChoice.ChoiceText = "[Make an offer]";
			this.acceptRequestChoice.Enabled = true;
			this.acceptRequestChoice.Conversation = null;
			this.acceptRequestChoice.onChoosen = new UnityEvent();
			this.acceptRequestChoice.onChoosen.AddListener(new UnityAction(this.RequestAccepted));
			this.acceptRequestChoice.shouldShowCheck = new DialogueController.DialogueChoice.ShouldShowCheck(this.DialogueActive);
			base.Npc.dialogueHandler.GetComponent<DialogueController>().AddDialogueChoice(this.acceptRequestChoice, 0);
			this.followChoice = new DialogueController.DialogueChoice();
			this.followChoice.ChoiceText = "Follow me, I need to grab it first";
			this.followChoice.Enabled = true;
			this.followChoice.Conversation = null;
			this.followChoice.onChoosen = new UnityEvent();
			this.followChoice.onChoosen.AddListener(new UnityAction(this.Follow));
			this.followChoice.shouldShowCheck = new DialogueController.DialogueChoice.ShouldShowCheck(this.DialogueActive);
			base.Npc.dialogueHandler.GetComponent<DialogueController>().AddDialogueChoice(this.followChoice, 0);
			this.rejectChoice = new DialogueController.DialogueChoice();
			this.rejectChoice.ChoiceText = "Get out of here";
			this.rejectChoice.Enabled = true;
			this.rejectChoice.Conversation = null;
			this.rejectChoice.onChoosen = new UnityEvent();
			this.rejectChoice.onChoosen.AddListener(new UnityAction(this.RequestRejected));
			this.rejectChoice.shouldShowCheck = new DialogueController.DialogueChoice.ShouldShowCheck(this.DialogueActive);
			base.Npc.dialogueHandler.GetComponent<DialogueController>().AddDialogueChoice(this.rejectChoice, 0);
			this.requestGreeting = new DialogueController.GreetingOverride();
			this.requestGreeting.Greeting = base.Npc.dialogueHandler.Database.GetLine(EDialogueModule.Customer, "request_product_initial");
			this.requestGreeting.ShouldShow = false;
			this.requestGreeting.PlayVO = true;
			this.requestGreeting.VOType = EVOLineType.Question;
			base.Npc.dialogueHandler.GetComponent<DialogueController>().AddGreetingOverride(this.requestGreeting);
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x00084394 File Offset: 0x00082594
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendStartInitialDialogue()
		{
			this.RpcWriter___Server_SendStartInitialDialogue_2166136261();
			this.RpcLogic___SendStartInitialDialogue_2166136261();
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x000843A4 File Offset: 0x000825A4
		[ObserversRpc(RunLocally = true)]
		private void StartInitialDialogue()
		{
			this.RpcWriter___Observers_StartInitialDialogue_2166136261();
			this.RpcLogic___StartInitialDialogue_2166136261();
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x000843BD File Offset: 0x000825BD
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendStartFollowUpDialogue()
		{
			this.RpcWriter___Server_SendStartFollowUpDialogue_2166136261();
			this.RpcLogic___SendStartFollowUpDialogue_2166136261();
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x000843CC File Offset: 0x000825CC
		[ObserversRpc(RunLocally = true)]
		private void StartFollowUpDialogue()
		{
			this.RpcWriter___Observers_StartFollowUpDialogue_2166136261();
			this.RpcLogic___StartFollowUpDialogue_2166136261();
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x000843E5 File Offset: 0x000825E5
		private bool DialogueActive(bool enabled)
		{
			return base.Active && this.TargetPlayer.Owner.IsLocalClient;
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00084401 File Offset: 0x00082601
		private void RequestAccepted()
		{
			this.minsSinceLastDialogue = 0;
			Singleton<HandoverScreen>.Instance.Open(null, this.customer, HandoverScreen.EMode.Offer, new Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float>(this.HandoverClosed), new Func<List<ItemInstance>, float, float>(this.customer.GetOfferSuccessChance));
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x0008443C File Offset: 0x0008263C
		private void HandoverClosed(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float askingPrice)
		{
			if (outcome == HandoverScreen.EHandoverOutcome.Cancelled)
			{
				Singleton<DialogueCanvas>.Instance.SkipNextRollout = true;
				Singleton<CoroutineService>.Instance.StartCoroutine(this.<HandoverClosed>g__Wait|36_0());
				return;
			}
			float offerSuccessChance = this.customer.GetOfferSuccessChance(items, askingPrice);
			if (Random.value < offerSuccessChance)
			{
				Contract contract = new Contract();
				ProductList productList = new ProductList();
				for (int i = 0; i < items.Count; i++)
				{
					if (items[i] is ProductItemInstance)
					{
						productList.entries.Add(new ProductList.Entry
						{
							ProductID = items[i].ID,
							Quantity = items[i].Quantity,
							Quality = this.customer.CustomerData.Standards.GetCorrespondingQuality()
						});
					}
				}
				contract.SilentlyInitializeContract("Offer", string.Empty, null, string.Empty, base.Npc.NetworkObject, askingPrice, productList, string.Empty, new QuestWindowConfig(), 0, NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.GetDateTime());
				this.customer.ProcessHandover(HandoverScreen.EHandoverOutcome.Finalize, contract, items, true, false);
			}
			else
			{
				Singleton<HandoverScreen>.Instance.ClearCustomerSlots(true);
				this.customer.RejectProductRequestOffer();
			}
			base.SendDisable();
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x00084564 File Offset: 0x00082764
		private void Follow()
		{
			this.minsSinceLastDialogue = 0;
			this.State = RequestProductBehaviour.EState.FollowPlayer;
			base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("requestproduct", 5, 0.6f));
			this.requestGreeting.Greeting = base.Npc.dialogueHandler.Database.GetLine(EDialogueModule.Customer, "request_product_after_follow");
			base.Npc.dialogueHandler.ShowWorldspaceDialogue("Ok...", 3f);
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x000845E4 File Offset: 0x000827E4
		private void RequestRejected()
		{
			this.minsSinceLastDialogue = 0;
			this.customer.PlayerRejectedProductRequest();
			base.SendDisable();
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x000845FE File Offset: 0x000827FE
		[CompilerGenerated]
		private IEnumerator <HandoverClosed>g__Wait|36_0()
		{
			yield return new WaitForEndOfFrame();
			this.StartInitialDialogue();
			yield break;
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00084610 File Offset: 0x00082810
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.RequestProductBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.RequestProductBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_AssignTarget_3323014238));
			base.RegisterServerRpc(16U, new ServerRpcDelegate(this.RpcReader___Server_SendStartInitialDialogue_2166136261));
			base.RegisterObserversRpc(17U, new ClientRpcDelegate(this.RpcReader___Observers_StartInitialDialogue_2166136261));
			base.RegisterServerRpc(18U, new ServerRpcDelegate(this.RpcReader___Server_SendStartFollowUpDialogue_2166136261));
			base.RegisterObserversRpc(19U, new ClientRpcDelegate(this.RpcReader___Observers_StartFollowUpDialogue_2166136261));
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x000846A7 File Offset: 0x000828A7
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.RequestProductBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.RequestProductBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x000846C0 File Offset: 0x000828C0
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x000846D0 File Offset: 0x000828D0
		private void RpcWriter___Observers_AssignTarget_3323014238(NetworkObject plr)
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
			writer.WriteNetworkObject(plr);
			base.SendObserversRpc(15U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00084786 File Offset: 0x00082986
		public void RpcLogic___AssignTarget_3323014238(NetworkObject plr)
		{
			this.TargetPlayer = ((plr != null) ? plr.GetComponent<Player>() : null);
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x000847A0 File Offset: 0x000829A0
		private void RpcReader___Observers_AssignTarget_3323014238(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject plr = PooledReader0.ReadNetworkObject();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___AssignTarget_3323014238(plr);
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x000847DC File Offset: 0x000829DC
		private void RpcWriter___Server_SendStartInitialDialogue_2166136261()
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendServerRpc(16U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00084876 File Offset: 0x00082A76
		private void RpcLogic___SendStartInitialDialogue_2166136261()
		{
			this.StartInitialDialogue();
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00084880 File Offset: 0x00082A80
		private void RpcReader___Server_SendStartInitialDialogue_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendStartInitialDialogue_2166136261();
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x000848B0 File Offset: 0x00082AB0
		private void RpcWriter___Observers_StartInitialDialogue_2166136261()
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
			base.SendObserversRpc(17U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x0008495C File Offset: 0x00082B5C
		private void RpcLogic___StartInitialDialogue_2166136261()
		{
			if (this.TargetPlayer != null && this.TargetPlayer.IsOwner && !base.Npc.dialogueHandler.IsPlaying)
			{
				if (PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount > 0)
				{
					Singleton<GameInput>.Instance.ExitAll();
				}
				base.Npc.dialogueHandler.GetComponent<DialogueController>().StartGenericDialogue(false);
			}
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x000849C4 File Offset: 0x00082BC4
		private void RpcReader___Observers_StartInitialDialogue_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___StartInitialDialogue_2166136261();
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x000849F0 File Offset: 0x00082BF0
		private void RpcWriter___Server_SendStartFollowUpDialogue_2166136261()
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendServerRpc(18U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00084A8A File Offset: 0x00082C8A
		private void RpcLogic___SendStartFollowUpDialogue_2166136261()
		{
			this.StartFollowUpDialogue();
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x00084A94 File Offset: 0x00082C94
		private void RpcReader___Server_SendStartFollowUpDialogue_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendStartFollowUpDialogue_2166136261();
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00084AC4 File Offset: 0x00082CC4
		private void RpcWriter___Observers_StartFollowUpDialogue_2166136261()
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
			base.SendObserversRpc(19U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00084B70 File Offset: 0x00082D70
		private void RpcLogic___StartFollowUpDialogue_2166136261()
		{
			if (this.TargetPlayer != null && this.TargetPlayer.IsOwner && !base.Npc.dialogueHandler.IsPlaying)
			{
				if (PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount > 0)
				{
					Singleton<GameInput>.Instance.ExitAll();
				}
				base.Npc.dialogueHandler.GetComponent<DialogueController>().StartGenericDialogue(false);
			}
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00084BD8 File Offset: 0x00082DD8
		private void RpcReader___Observers_StartFollowUpDialogue_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___StartFollowUpDialogue_2166136261();
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00084C02 File Offset: 0x00082E02
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040018E5 RID: 6373
		public const float CONVERSATION_RANGE = 2.5f;

		// Token: 0x040018E6 RID: 6374
		public const float FOLLOW_MAX_RANGE = 5f;

		// Token: 0x040018E7 RID: 6375
		public const int MINS_TO_ASK_AGAIN = 90;

		// Token: 0x040018EA RID: 6378
		private int minsSinceLastDialogue;

		// Token: 0x040018EB RID: 6379
		private DialogueController.GreetingOverride requestGreeting;

		// Token: 0x040018EC RID: 6380
		private DialogueController.DialogueChoice acceptRequestChoice;

		// Token: 0x040018ED RID: 6381
		private DialogueController.DialogueChoice followChoice;

		// Token: 0x040018EE RID: 6382
		private DialogueController.DialogueChoice rejectChoice;

		// Token: 0x040018EF RID: 6383
		private bool dll_Excuted;

		// Token: 0x040018F0 RID: 6384
		private bool dll_Excuted;

		// Token: 0x0200052F RID: 1327
		public enum EState
		{
			// Token: 0x040018F2 RID: 6386
			InitialApproach,
			// Token: 0x040018F3 RID: 6387
			FollowPlayer
		}
	}
}
