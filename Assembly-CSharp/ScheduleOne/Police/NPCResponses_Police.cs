using System;
using FishNet;
using ScheduleOne.Combat;
using ScheduleOne.Law;
using ScheduleOne.Noise;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using ScheduleOne.VoiceOver;

namespace ScheduleOne.Police
{
	// Token: 0x02000332 RID: 818
	public class NPCResponses_Police : NPCResponses
	{
		// Token: 0x060011EE RID: 4590 RVA: 0x0004DFCF File Offset: 0x0004C1CF
		protected override void Awake()
		{
			base.Awake();
			this.officer = (base.npc as PoliceOfficer);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0004DFE8 File Offset: 0x0004C1E8
		public override void HitByCar(LandVehicle vehicle)
		{
			base.HitByCar(vehicle);
			base.npc.PlayVO(EVOLineType.Angry);
			if (vehicle.DriverPlayer != null && vehicle.DriverPlayer.IsOwner)
			{
				vehicle.DriverPlayer.CrimeData.AddCrime(new VehicularAssault(), 1);
				if (vehicle.DriverPlayer.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.None)
				{
					vehicle.DriverPlayer.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.NonLethal);
					return;
				}
				vehicle.DriverPlayer.CrimeData.Escalate();
			}
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0004E070 File Offset: 0x0004C270
		public override void NoticedDrugDeal(Player player)
		{
			base.NoticedDrugDeal(player);
			base.npc.PlayVO(EVOLineType.Command);
			if (player.IsOwner)
			{
				player.CrimeData.AddCrime(new DrugTrafficking(), 1);
				player.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Arresting);
				(base.npc as PoliceOfficer).BeginFootPursuit_Networked(player.NetworkObject, true);
			}
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x0004E0CC File Offset: 0x0004C2CC
		public override void NoticedPettyCrime(Player player)
		{
			base.NoticedPettyCrime(player);
			base.npc.PlayVO(EVOLineType.Command);
			if (player.IsOwner)
			{
				player.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Arresting);
				(base.npc as PoliceOfficer).BeginFootPursuit_Networked(player.NetworkObject, true);
			}
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x0004E10C File Offset: 0x0004C30C
		public override void NoticedVandalism(Player player)
		{
			base.NoticedVandalism(player);
			base.npc.PlayVO(EVOLineType.Command);
			if (player.IsOwner)
			{
				player.CrimeData.AddCrime(new Vandalism(), 1);
				player.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Arresting);
				(base.npc as PoliceOfficer).BeginFootPursuit_Networked(player.NetworkObject, true);
			}
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x0004E168 File Offset: 0x0004C368
		public override void SawPickpocketing(Player player)
		{
			base.SawPickpocketing(player);
			base.npc.PlayVO(EVOLineType.Command);
			if (player.IsOwner)
			{
				player.CrimeData.AddCrime(new Theft(), 1);
				player.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Arresting);
				(base.npc as PoliceOfficer).BeginFootPursuit_Networked(player.NetworkObject, true);
			}
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0004E1C4 File Offset: 0x0004C3C4
		public override void NoticePlayerBrandishingWeapon(Player player)
		{
			base.NoticePlayerBrandishingWeapon(player);
			base.npc.PlayVO(EVOLineType.Command);
			if (player.IsOwner)
			{
				player.CrimeData.AddCrime(new BrandishingWeapon(), 1);
				player.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.NonLethal);
				(base.npc as PoliceOfficer).BeginFootPursuit_Networked(player.NetworkObject, true);
			}
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0004E220 File Offset: 0x0004C420
		public override void NoticePlayerDischargingWeapon(Player player)
		{
			base.NoticePlayerDischargingWeapon(player);
			base.npc.PlayVO(EVOLineType.Command);
			if (player.IsOwner)
			{
				player.CrimeData.AddCrime(new DischargeFirearm(), 1);
				player.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.NonLethal);
				(base.npc as PoliceOfficer).BeginFootPursuit_Networked(player.NetworkObject, true);
			}
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x0004E27C File Offset: 0x0004C47C
		public override void NoticedWantedPlayer(Player player)
		{
			base.NoticedWantedPlayer(player);
			base.npc.PlayVO(EVOLineType.Command);
			if (player.IsOwner)
			{
				player.CrimeData.RecordLastKnownPosition(true);
				if (base.npc.CurrentVehicle != null)
				{
					(base.npc as PoliceOfficer).BeginFootPursuit_Networked(player.NetworkObject, false);
					(base.npc as PoliceOfficer).BeginVehiclePursuit_Networked(player.NetworkObject, base.npc.CurrentVehicle.NetworkObject, true);
					return;
				}
				(base.npc as PoliceOfficer).BeginFootPursuit_Networked(player.NetworkObject, true);
			}
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0004E319 File Offset: 0x0004C519
		public override void NoticedSuspiciousPlayer(Player player)
		{
			base.NoticedSuspiciousPlayer(player);
			if (player.IsOwner)
			{
				(base.npc as PoliceOfficer).BeginBodySearch_Networked(player.NetworkObject);
			}
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0004E340 File Offset: 0x0004C540
		public override void NoticedViolatingCurfew(Player player)
		{
			base.NoticedViolatingCurfew(player);
			base.npc.PlayVO(EVOLineType.Command);
			if (player.IsOwner)
			{
				player.CrimeData.AddCrime(new ViolatingCurfew(), 1);
				player.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Arresting);
				if (base.npc.CurrentVehicle != null)
				{
					(base.npc as PoliceOfficer).BeginFootPursuit_Networked(player.NetworkObject, false);
					(base.npc as PoliceOfficer).BeginVehiclePursuit_Networked(player.NetworkObject, base.npc.CurrentVehicle.NetworkObject, true);
					return;
				}
				(base.npc as PoliceOfficer).BeginFootPursuit_Networked(player.NetworkObject, true);
			}
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0004E3F4 File Offset: 0x0004C5F4
		protected override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
			base.RespondToFirstNonLethalAttack(perpetrator, impact);
			perpetrator.CrimeData.AddCrime(new Assault(), 1);
			if (perpetrator.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.None)
			{
				perpetrator.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Arresting);
				this.officer.BeginFootPursuit_Networked(perpetrator.NetworkObject, true);
				return;
			}
			perpetrator.CrimeData.Escalate();
			this.officer.BeginFootPursuit_Networked(perpetrator.NetworkObject, true);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0004E464 File Offset: 0x0004C664
		protected override void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
			base.RespondToLethalAttack(perpetrator, impact);
			perpetrator.CrimeData.AddCrime(new DeadlyAssault(), 1);
			if (perpetrator.CrimeData.CurrentPursuitLevel < PlayerCrimeData.EPursuitLevel.Lethal)
			{
				perpetrator.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Lethal);
				this.officer.BeginFootPursuit_Networked(perpetrator.NetworkObject, true);
			}
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0004E4B8 File Offset: 0x0004C6B8
		protected override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
			base.RespondToRepeatedNonLethalAttack(perpetrator, impact);
			if (!perpetrator.CrimeData.IsCrimeOnRecord(typeof(Assault)))
			{
				perpetrator.CrimeData.AddCrime(new Assault(), 1);
			}
			if (perpetrator.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.None)
			{
				perpetrator.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Arresting);
				this.officer.BeginFootPursuit_Networked(perpetrator.NetworkObject, true);
				return;
			}
			perpetrator.CrimeData.Escalate();
			this.officer.BeginFootPursuit_Networked(perpetrator.NetworkObject, true);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0004E540 File Offset: 0x0004C740
		protected override void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
			base.RespondToAnnoyingImpact(perpetrator, impact);
			base.npc.VoiceOverEmitter.Play(EVOLineType.Annoyed);
			base.npc.dialogueHandler.PlayReaction("annoyed", 2.5f, false);
			base.npc.Avatar.EmotionManager.AddEmotionOverride("Annoyed", "annoyed", 20f, 3);
			if (InstanceFinder.IsServer)
			{
				base.npc.behaviour.FacePlayerBehaviour.SetTarget(perpetrator.NetworkObject, 5f);
				base.npc.behaviour.FacePlayerBehaviour.Enable_Networked(null);
			}
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0004E5E4 File Offset: 0x0004C7E4
		public override void RespondToAimedAt(Player player)
		{
			base.RespondToAimedAt(player);
			if (player.CrimeData.CurrentPursuitLevel < PlayerCrimeData.EPursuitLevel.Lethal)
			{
				player.CrimeData.AddCrime(new Assault(), 1);
				player.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Lethal);
			}
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0004E618 File Offset: 0x0004C818
		public override void ImpactReceived(Impact impact)
		{
			base.ImpactReceived(impact);
			if (this.officer.PursuitBehaviour.Active)
			{
				this.officer.PursuitBehaviour.ResetArrestProgress();
			}
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0004E644 File Offset: 0x0004C844
		public override void GunshotHeard(NoiseEvent gunshotSound)
		{
			base.GunshotHeard(gunshotSound);
			if (gunshotSound.source != null && gunshotSound.source.GetComponent<Player>() != null)
			{
				this.officer.behaviour.FacePlayerBehaviour.SetTarget(gunshotSound.source.GetComponent<Player>().NetworkObject, 5f);
				this.officer.behaviour.FacePlayerBehaviour.SendEnable();
			}
		}

		// Token: 0x04001175 RID: 4469
		private PoliceOfficer officer;
	}
}
