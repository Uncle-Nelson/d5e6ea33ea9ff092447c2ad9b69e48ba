using System;
using System.Collections.Generic;
using FishNet;
using ScheduleOne.Combat;
using ScheduleOne.Dialogue;
using ScheduleOne.Law;
using ScheduleOne.Noise;
using ScheduleOne.PlayerScripts;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.NPCs.Responses
{
	// Token: 0x0200048A RID: 1162
	public class NPCResponses_Civilian : NPCResponses
	{
		// Token: 0x060019C1 RID: 6593 RVA: 0x0006F721 File Offset: 0x0006D921
		protected override void Update()
		{
			base.Update();
			this.timeSinceLastThreat += Time.deltaTime;
			if (this.timeSinceLastThreat > 30f)
			{
				this.currentThreatResponse = NPCResponses_Civilian.EAttackResponse.None;
			}
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x0006F750 File Offset: 0x0006D950
		public override void GunshotHeard(NoiseEvent gunshotSound)
		{
			base.GunshotHeard(gunshotSound);
			if (this.currentThreatResponse == NPCResponses_Civilian.EAttackResponse.None)
			{
				Player player = (gunshotSound.source != null) ? gunshotSound.source.GetComponent<Player>() : null;
				this.timeSinceLastThreat = 0f;
				this.currentThreatResponse = this.GetThreatResponse(NPCResponses_Civilian.EThreatType.GunshotHeard, player);
				this.ExecuteThreatResponse(this.currentThreatResponse, player, gunshotSound.origin, new DischargeFirearm());
			}
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x0006F7BC File Offset: 0x0006D9BC
		public override void ExplosionHeard(NoiseEvent explosionSound)
		{
			base.ExplosionHeard(explosionSound);
			Console.Log("Explosion heard by " + base.npc.fullName, null);
			if (this.currentThreatResponse == NPCResponses_Civilian.EAttackResponse.None)
			{
				Player threatSource = (explosionSound.source != null) ? explosionSound.source.GetComponent<Player>() : null;
				this.timeSinceLastThreat = 0f;
				this.currentThreatResponse = this.GetThreatResponse(NPCResponses_Civilian.EThreatType.ExplosionHeard, threatSource);
				this.ExecuteThreatResponse(this.currentThreatResponse, null, explosionSound.origin, null);
			}
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x0006F840 File Offset: 0x0006DA40
		public override void PlayerFailedPickpocket(Player player)
		{
			base.PlayerFailedPickpocket(player);
			string line = base.npc.dialogueHandler.Database.GetLine(EDialogueModule.Reactions, "noticed_pickpocket");
			base.npc.dialogueHandler.ShowWorldspaceDialogue(line, 3f);
			base.npc.Avatar.EmotionManager.AddEmotionOverride("Angry", "noticed_pickpocket", 20f, 3);
			if (base.npc.Aggression > 0.5f && Random.value < base.npc.Aggression)
			{
				base.npc.behaviour.CombatBehaviour.SetTarget(null, player.NetworkObject);
				base.npc.behaviour.CombatBehaviour.Enable_Networked(null);
				base.npc.VoiceOverEmitter.Play(EVOLineType.Angry);
				return;
			}
			float value = Random.value;
			if (value > 0.3f && this.CanCallPolice)
			{
				base.actions.SetCallPoliceBehaviourCrime(new Theft());
				base.actions.CallPolice_Networked(player);
				base.npc.PlayVO(EVOLineType.Alerted);
				return;
			}
			if (value > 0.1f)
			{
				base.npc.PlayVO(EVOLineType.Alerted);
				base.npc.behaviour.FacePlayerBehaviour.SetTarget(player.NetworkObject, 5f);
				base.npc.behaviour.FacePlayerBehaviour.SendEnable();
				return;
			}
			base.npc.PlayVO(EVOLineType.Alerted);
			base.npc.behaviour.FleeBehaviour.SetEntityToFlee(player.NetworkObject);
			base.npc.behaviour.FleeBehaviour.Enable_Networked(null);
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x0006F9DC File Offset: 0x0006DBDC
		protected override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
			base.RespondToFirstNonLethalAttack(perpetrator, impact);
			if (base.npc.Aggression > 0.5f && Random.value < base.npc.Aggression)
			{
				base.npc.behaviour.CombatBehaviour.SetTarget(null, perpetrator.NetworkObject);
				base.npc.behaviour.CombatBehaviour.Enable_Networked(null);
				base.npc.VoiceOverEmitter.Play(EVOLineType.Angry);
				return;
			}
			base.npc.dialogueHandler.PlayReaction("hurt", 2.5f, false);
			base.npc.Avatar.EmotionManager.AddEmotionOverride("Annoyed", "hurt", 20f, 3);
			if (InstanceFinder.IsServer)
			{
				base.npc.behaviour.FacePlayerBehaviour.SetTarget(perpetrator.NetworkObject, 5f);
				base.npc.behaviour.FacePlayerBehaviour.SendEnable();
			}
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x0006FAD8 File Offset: 0x0006DCD8
		protected override void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
			base.RespondToAnnoyingImpact(perpetrator, impact);
			if (base.npc.Aggression > 0.6f && Random.value * 1.5f < base.npc.Aggression)
			{
				base.npc.behaviour.CombatBehaviour.SetTarget(null, perpetrator.NetworkObject);
				base.npc.behaviour.CombatBehaviour.Enable_Networked(null);
				base.npc.VoiceOverEmitter.Play(EVOLineType.Angry);
				return;
			}
			base.npc.VoiceOverEmitter.Play(EVOLineType.Annoyed);
			base.npc.dialogueHandler.PlayReaction("annoyed", 2.5f, false);
			base.npc.Avatar.EmotionManager.AddEmotionOverride("Annoyed", "annoyed", 20f, 3);
			if (InstanceFinder.IsServer)
			{
				base.npc.behaviour.FacePlayerBehaviour.SetTarget(perpetrator.NetworkObject, 5f);
				base.npc.behaviour.FacePlayerBehaviour.SendEnable();
			}
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x0006FBEA File Offset: 0x0006DDEA
		protected override void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
			base.RespondToLethalAttack(perpetrator, impact);
			this.RespondToLethalOrRepeatedAttack(perpetrator, impact);
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x0006FBFC File Offset: 0x0006DDFC
		protected override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
			base.RespondToRepeatedNonLethalAttack(perpetrator, impact);
			this.RespondToLethalOrRepeatedAttack(perpetrator, impact);
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x0006FC10 File Offset: 0x0006DE10
		private void RespondToLethalOrRepeatedAttack(Player perpetrator, Impact impact)
		{
			float value = Random.value;
			float aggression = base.npc.Aggression;
			if (aggression > 0.5f && value < aggression)
			{
				base.npc.behaviour.CombatBehaviour.SetTarget(null, perpetrator.NetworkObject);
				base.npc.behaviour.CombatBehaviour.Enable_Networked(null);
				base.npc.VoiceOverEmitter.Play(EVOLineType.Angry);
				return;
			}
			if (value > 0.5f && this.CanCallPolice)
			{
				if (Impact.IsLethal(impact.ImpactType))
				{
					base.actions.SetCallPoliceBehaviourCrime(new DeadlyAssault());
				}
				else
				{
					base.actions.SetCallPoliceBehaviourCrime(new Assault());
				}
				base.actions.CallPolice_Networked(perpetrator);
				return;
			}
			base.npc.SetPanicked();
			base.npc.dialogueHandler.PlayReaction("panic_start", 3f, false);
			if (value > 0.2f)
			{
				base.npc.behaviour.FleeBehaviour.SetEntityToFlee(perpetrator.NetworkObject);
				base.npc.behaviour.FleeBehaviour.Enable_Networked(null);
			}
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x0006FD2C File Offset: 0x0006DF2C
		public override void RespondToAimedAt(Player player)
		{
			base.RespondToAimedAt(player);
			player.VisualState.ApplyState("aiming_at_npc", PlayerVisualState.EVisualState.Brandishing, 2.5f);
			if (this.currentThreatResponse == NPCResponses_Civilian.EAttackResponse.None)
			{
				this.timeSinceLastThreat = 0f;
				this.currentThreatResponse = this.GetThreatResponse(NPCResponses_Civilian.EThreatType.AimedAt, player);
				this.ExecuteThreatResponse(this.currentThreatResponse, player, player.transform.position, new BrandishingWeapon());
			}
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x0006FD98 File Offset: 0x0006DF98
		private void ExecuteThreatResponse(NPCResponses_Civilian.EAttackResponse response, Player target, Vector3 threatOrigin, Crime crime = null)
		{
			Console.Log(string.Concat(new string[]
			{
				base.npc.fullName,
				" executing threat response: ",
				response.ToString(),
				" on target ",
				(target != null) ? target.ToString() : null
			}), null);
			if (response == NPCResponses_Civilian.EAttackResponse.None)
			{
				return;
			}
			switch (response)
			{
			case NPCResponses_Civilian.EAttackResponse.Panic:
				base.npc.SetPanicked();
				base.npc.dialogueHandler.PlayReaction("panic_start", 3f, false);
				return;
			case NPCResponses_Civilian.EAttackResponse.Flee:
				base.npc.SetPanicked();
				base.npc.dialogueHandler.PlayReaction("panic_start", 3f, false);
				if (target != null)
				{
					base.npc.behaviour.FleeBehaviour.SetEntityToFlee(target.NetworkObject);
				}
				else
				{
					base.npc.behaviour.FleeBehaviour.SetPointToFlee(threatOrigin);
				}
				base.npc.behaviour.FleeBehaviour.Enable_Networked(null);
				return;
			case NPCResponses_Civilian.EAttackResponse.CallPolice:
				if (target != null)
				{
					base.actions.SetCallPoliceBehaviourCrime(crime);
					base.actions.CallPolice_Networked(target);
					return;
				}
				break;
			case NPCResponses_Civilian.EAttackResponse.Fight:
				if (target != null)
				{
					base.npc.behaviour.CombatBehaviour.SetTarget(null, target.NetworkObject);
					base.npc.behaviour.CombatBehaviour.Enable_Networked(null);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x0006FF10 File Offset: 0x0006E110
		private NPCResponses_Civilian.EAttackResponse GetThreatResponse(NPCResponses_Civilian.EThreatType type, Player threatSource)
		{
			if (base.npc.CurrentVehicle != null)
			{
				return NPCResponses_Civilian.EAttackResponse.Panic;
			}
			switch (type)
			{
			case NPCResponses_Civilian.EThreatType.None:
				break;
			case NPCResponses_Civilian.EThreatType.AimedAt:
				if (Random.Range(0f, 1f) < base.npc.Aggression)
				{
					return NPCResponses_Civilian.EAttackResponse.Fight;
				}
				if (threatSource != null && threatSource.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.None)
				{
					int num = Random.Range(0, 2);
					if (num == 0)
					{
						return NPCResponses_Civilian.EAttackResponse.Panic;
					}
					if (num == 1)
					{
						return NPCResponses_Civilian.EAttackResponse.Flee;
					}
					return NPCResponses_Civilian.EAttackResponse.CallPolice;
				}
				else
				{
					if (Random.value < 0.5f)
					{
						return NPCResponses_Civilian.EAttackResponse.Panic;
					}
					return NPCResponses_Civilian.EAttackResponse.Flee;
				}
				break;
			case NPCResponses_Civilian.EThreatType.GunshotHeard:
				if (threatSource != null && threatSource.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.None)
				{
					List<NPCResponses_Civilian.EAttackResponse> list = new List<NPCResponses_Civilian.EAttackResponse>
					{
						NPCResponses_Civilian.EAttackResponse.Panic,
						NPCResponses_Civilian.EAttackResponse.Flee
					};
					if (this.CanCallPolice)
					{
						list.Add(NPCResponses_Civilian.EAttackResponse.CallPolice);
					}
					int num2 = Random.Range(0, list.Count);
					if (num2 == 0)
					{
						return NPCResponses_Civilian.EAttackResponse.Panic;
					}
					if (num2 == 1)
					{
						return NPCResponses_Civilian.EAttackResponse.Flee;
					}
					return NPCResponses_Civilian.EAttackResponse.CallPolice;
				}
				else
				{
					if (Random.value < 0.5f)
					{
						return NPCResponses_Civilian.EAttackResponse.Panic;
					}
					return NPCResponses_Civilian.EAttackResponse.Flee;
				}
				break;
			case NPCResponses_Civilian.EThreatType.ExplosionHeard:
				if (Random.value < 0.5f)
				{
					return NPCResponses_Civilian.EAttackResponse.Panic;
				}
				return NPCResponses_Civilian.EAttackResponse.Flee;
			default:
				Console.LogError("Unhandled threat type: " + type.ToString(), null);
				break;
			}
			return NPCResponses_Civilian.EAttackResponse.None;
		}

		// Token: 0x04001627 RID: 5671
		public bool CanCallPolice = true;

		// Token: 0x04001628 RID: 5672
		private NPCResponses_Civilian.EAttackResponse currentThreatResponse;

		// Token: 0x04001629 RID: 5673
		private float timeSinceLastThreat;

		// Token: 0x0200048B RID: 1163
		public enum EAttackResponse
		{
			// Token: 0x0400162B RID: 5675
			None,
			// Token: 0x0400162C RID: 5676
			Panic,
			// Token: 0x0400162D RID: 5677
			Flee,
			// Token: 0x0400162E RID: 5678
			CallPolice,
			// Token: 0x0400162F RID: 5679
			Fight
		}

		// Token: 0x0200048C RID: 1164
		public enum EThreatType
		{
			// Token: 0x04001631 RID: 5681
			None,
			// Token: 0x04001632 RID: 5682
			AimedAt,
			// Token: 0x04001633 RID: 5683
			GunshotHeard,
			// Token: 0x04001634 RID: 5684
			ExplosionHeard
		}
	}
}
