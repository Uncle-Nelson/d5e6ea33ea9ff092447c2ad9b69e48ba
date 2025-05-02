using System;
using ScheduleOne.Noise;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using ScheduleOne.Vision;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000459 RID: 1113
	public class NPCAwareness : MonoBehaviour
	{
		// Token: 0x060016FB RID: 5883 RVA: 0x000654C4 File Offset: 0x000636C4
		protected virtual void Awake()
		{
			this.npc = base.GetComponentInParent<NPC>();
			if (this.Responses == null)
			{
				Console.LogError("NPCAwareness doesn't have a reference to NPCResponses - responses won't be automatically connected.", null);
			}
			VisionCone visionCone = this.VisionCone;
			visionCone.onVisionEventFull = (VisionCone.EventStateChange)Delegate.Combine(visionCone.onVisionEventFull, new VisionCone.EventStateChange(this.VisionEvent));
			Listener listener = this.Listener;
			listener.onNoiseHeard = (Listener.HearingEvent)Delegate.Combine(listener.onNoiseHeard, new Listener.HearingEvent(this.NoiseEvent));
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00065544 File Offset: 0x00063744
		public void SetAwarenessActive(bool active)
		{
			this.Listener.enabled = active;
			this.VisionCone.enabled = active;
			base.enabled = active;
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00065568 File Offset: 0x00063768
		public void VisionEvent(VisionEventReceipt vEvent)
		{
			if (!base.enabled)
			{
				return;
			}
			switch (vEvent.State)
			{
			case PlayerVisualState.EVisualState.Visible:
			case PlayerVisualState.EVisualState.SearchedFor:
				break;
			case PlayerVisualState.EVisualState.Suspicious:
				if (this.onNoticedSuspiciousPlayer != null)
				{
					this.onNoticedSuspiciousPlayer.Invoke(vEvent.TargetPlayer.GetComponent<Player>());
				}
				if (this.Responses != null)
				{
					this.Responses.NoticedSuspiciousPlayer(vEvent.TargetPlayer.GetComponent<Player>());
					return;
				}
				break;
			case PlayerVisualState.EVisualState.DisobeyingCurfew:
				if (this.onNoticedPlayerViolatingCurfew != null)
				{
					this.onNoticedPlayerViolatingCurfew.Invoke(vEvent.TargetPlayer.GetComponent<Player>());
				}
				if (this.Responses != null)
				{
					this.Responses.NoticedViolatingCurfew(vEvent.TargetPlayer.GetComponent<Player>());
					return;
				}
				break;
			case PlayerVisualState.EVisualState.Vandalizing:
				if (this.Responses != null)
				{
					this.Responses.NoticedVandalism(vEvent.TargetPlayer.GetComponent<Player>());
					return;
				}
				break;
			case PlayerVisualState.EVisualState.PettyCrime:
				if (this.onNoticedPettyCrime != null)
				{
					this.onNoticedPettyCrime.Invoke(vEvent.TargetPlayer.GetComponent<Player>());
				}
				if (this.onNoticedGeneralCrime != null)
				{
					this.onNoticedGeneralCrime.Invoke(vEvent.TargetPlayer.GetComponent<Player>());
				}
				if (this.Responses != null)
				{
					this.Responses.NoticedPettyCrime(vEvent.TargetPlayer.GetComponent<Player>());
					return;
				}
				break;
			case PlayerVisualState.EVisualState.DrugDealing:
				if (this.onNoticedDrugDealing != null)
				{
					this.onNoticedDrugDealing.Invoke(vEvent.TargetPlayer.GetComponent<Player>());
				}
				if (this.onNoticedGeneralCrime != null)
				{
					this.onNoticedGeneralCrime.Invoke(vEvent.TargetPlayer.GetComponent<Player>());
				}
				if (this.Responses != null)
				{
					this.Responses.NoticedDrugDeal(vEvent.TargetPlayer.GetComponent<Player>());
					return;
				}
				break;
			case PlayerVisualState.EVisualState.Wanted:
				if (this.Responses != null)
				{
					this.Responses.NoticedWantedPlayer(vEvent.TargetPlayer.GetComponent<Player>());
					return;
				}
				break;
			case PlayerVisualState.EVisualState.Pickpocketing:
				if (this.Responses != null)
				{
					this.Responses.SawPickpocketing(vEvent.TargetPlayer.GetComponent<Player>());
					return;
				}
				break;
			case PlayerVisualState.EVisualState.DischargingWeapon:
				if (this.Responses != null)
				{
					this.Responses.NoticePlayerDischargingWeapon(vEvent.TargetPlayer.GetComponent<Player>());
				}
				break;
			case PlayerVisualState.EVisualState.Brandishing:
				if (this.Responses != null)
				{
					this.Responses.NoticePlayerBrandishingWeapon(vEvent.TargetPlayer.GetComponent<Player>());
					return;
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x000657CC File Offset: 0x000639CC
		public void NoiseEvent(NoiseEvent nEvent)
		{
			if (!base.enabled)
			{
				return;
			}
			if (nEvent.type == ENoiseType.Gunshot)
			{
				if (this.onGunshotHeard != null)
				{
					this.onGunshotHeard.Invoke(nEvent);
				}
				if (this.Responses != null)
				{
					this.Responses.GunshotHeard(nEvent);
				}
			}
			if (nEvent.type == ENoiseType.Explosion)
			{
				if (this.onExplosionHeard != null)
				{
					this.onExplosionHeard.Invoke(nEvent);
				}
				if (this.Responses != null)
				{
					this.Responses.ExplosionHeard(nEvent);
				}
			}
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00065850 File Offset: 0x00063A50
		public void HitByCar(LandVehicle vehicle)
		{
			if (this.onHitByCar != null)
			{
				this.onHitByCar.Invoke(vehicle);
			}
			if (this.Responses != null)
			{
				this.Responses.HitByCar(vehicle);
			}
		}

		// Token: 0x040014E6 RID: 5350
		public const float PLAYER_AIM_DETECTION_RANGE = 15f;

		// Token: 0x040014E7 RID: 5351
		[Header("References")]
		public VisionCone VisionCone;

		// Token: 0x040014E8 RID: 5352
		public Listener Listener;

		// Token: 0x040014E9 RID: 5353
		public NPCResponses Responses;

		// Token: 0x040014EA RID: 5354
		public UnityEvent<Player> onNoticedGeneralCrime;

		// Token: 0x040014EB RID: 5355
		public UnityEvent<Player> onNoticedPettyCrime;

		// Token: 0x040014EC RID: 5356
		public UnityEvent<Player> onNoticedDrugDealing;

		// Token: 0x040014ED RID: 5357
		public UnityEvent<Player> onNoticedPlayerViolatingCurfew;

		// Token: 0x040014EE RID: 5358
		public UnityEvent<Player> onNoticedSuspiciousPlayer;

		// Token: 0x040014EF RID: 5359
		public UnityEvent<NoiseEvent> onGunshotHeard;

		// Token: 0x040014F0 RID: 5360
		public UnityEvent<NoiseEvent> onExplosionHeard;

		// Token: 0x040014F1 RID: 5361
		public UnityEvent<LandVehicle> onHitByCar;

		// Token: 0x040014F2 RID: 5362
		private NPC npc;
	}
}
