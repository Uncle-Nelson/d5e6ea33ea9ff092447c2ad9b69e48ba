using System;
using ScheduleOne.Combat;
using ScheduleOne.Law;
using ScheduleOne.Noise;
using ScheduleOne.NPCs.Actions;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.NPCs.Responses
{
	// Token: 0x02000489 RID: 1161
	public class NPCResponses : MonoBehaviour
	{
		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x0006F468 File Offset: 0x0006D668
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x0006F470 File Offset: 0x0006D670
		private protected NPC npc { protected get; private set; }

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x0006F479 File Offset: 0x0006D679
		protected NPCActions actions
		{
			get
			{
				return this.npc.actions;
			}
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x0006F486 File Offset: 0x0006D686
		protected virtual void Awake()
		{
			this.npc = base.GetComponentInParent<NPC>();
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x0006F494 File Offset: 0x0006D694
		protected virtual void Update()
		{
			this.timeSinceLastImpact += Time.deltaTime;
			this.timeSinceAimedAt += Time.deltaTime;
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void GunshotHeard(NoiseEvent gunshotSound)
		{
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void ExplosionHeard(NoiseEvent explosionSound)
		{
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void NoticedPettyCrime(Player player)
		{
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void NoticedVandalism(Player player)
		{
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void SawPickpocketing(Player player)
		{
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void NoticePlayerBrandishingWeapon(Player player)
		{
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void NoticePlayerDischargingWeapon(Player player)
		{
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x0006F4BA File Offset: 0x0006D6BA
		public virtual void PlayerFailedPickpocket(Player player)
		{
			if (this.npc.RelationData.Unlocked)
			{
				this.npc.RelationData.ChangeRelationship(0.25f, true);
			}
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void NoticedDrugDeal(Player player)
		{
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void NoticedViolatingCurfew(Player player)
		{
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void NoticedWantedPlayer(Player player)
		{
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void NoticedSuspiciousPlayer(Player player)
		{
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x0006F4E4 File Offset: 0x0006D6E4
		public virtual void HitByCar(LandVehicle vehicle)
		{
			if (vehicle.DriverPlayer != null && this.npc.Movement.timeSinceHitByCar > 2f)
			{
				if (vehicle.DriverPlayer.CrimeData.CurrentPursuitLevel > PlayerCrimeData.EPursuitLevel.None)
				{
					vehicle.DriverPlayer.CrimeData.AddCrime(new VehicularAssault(), 1);
				}
				else
				{
					vehicle.DriverPlayer.CrimeData.RecordVehicleCollision(this.npc);
				}
				this.npc.Avatar.EmotionManager.AddEmotionOverride("Angry", "hitbycar", 5f, 1);
				this.npc.Avatar.EmotionManager.AddEmotionOverride("Annoyed", "hitbycar1", 20f, 0);
				this.npc.PlayVO(EVOLineType.Hurt);
			}
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x0006F5B4 File Offset: 0x0006D7B4
		public virtual void ImpactReceived(Impact impact)
		{
			if (!this.npc.IsConscious)
			{
				this.timeSinceLastImpact = 0f;
				return;
			}
			this.npc.VoiceOverEmitter.Play(EVOLineType.Hurt);
			Player perpetrator2;
			if (impact.ImpactForce > 50f || impact.ImpactDamage > 10f)
			{
				Player perpetrator;
				if (impact.IsPlayerImpact(out perpetrator))
				{
					if (Impact.IsLethal(impact.ImpactType))
					{
						this.RespondToLethalAttack(perpetrator, impact);
					}
					else if (this.timeSinceLastImpact < 20f)
					{
						this.RespondToRepeatedNonLethalAttack(perpetrator, impact);
					}
					else
					{
						this.RespondToFirstNonLethalAttack(perpetrator, impact);
					}
				}
			}
			else if (impact.IsPlayerImpact(out perpetrator2))
			{
				this.RespondToAnnoyingImpact(perpetrator2, impact);
			}
			this.timeSinceLastImpact = 0f;
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0006F664 File Offset: 0x0006D864
		protected virtual void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
			if (this.timeSinceLastImpact > 20f)
			{
				this.npc.RelationData.ChangeRelationship(0.25f, true);
			}
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x0006F689 File Offset: 0x0006D889
		protected virtual void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
			if (this.timeSinceLastImpact > 20f)
			{
				this.npc.RelationData.ChangeRelationship(-0.25f, true);
			}
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x0006F6AE File Offset: 0x0006D8AE
		protected virtual void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
			if (this.timeSinceLastImpact > 20f)
			{
				this.npc.RelationData.ChangeRelationship(-1f, true);
			}
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0006F6D3 File Offset: 0x0006D8D3
		public virtual void RespondToAimedAt(Player player)
		{
			if (this.timeSinceAimedAt > 20f)
			{
				this.npc.RelationData.ChangeRelationship(-0.5f, true);
			}
			this.timeSinceAimedAt = 0f;
		}

		// Token: 0x04001620 RID: 5664
		public const float ASSAULT_RELATIONSHIPCHANGE = -0.25f;

		// Token: 0x04001621 RID: 5665
		public const float DEADLYASSAULT_RELATIONSHIPCHANGE = -1f;

		// Token: 0x04001622 RID: 5666
		public const float AIMED_AT_RELATIONSHIPCHANGE = -0.5f;

		// Token: 0x04001623 RID: 5667
		public const float PICKPOCKET_RELATIONSHIPCHANGE = -0.25f;

		// Token: 0x04001625 RID: 5669
		protected float timeSinceLastImpact = 100f;

		// Token: 0x04001626 RID: 5670
		protected float timeSinceAimedAt = 100f;
	}
}
