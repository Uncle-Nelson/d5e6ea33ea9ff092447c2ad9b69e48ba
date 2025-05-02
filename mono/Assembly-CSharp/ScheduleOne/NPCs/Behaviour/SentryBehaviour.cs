using System;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Law;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000532 RID: 1330
	public class SentryBehaviour : Behaviour
	{
		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x00084D25 File Offset: 0x00082F25
		// (set) Token: 0x06002044 RID: 8260 RVA: 0x00084D2D File Offset: 0x00082F2D
		public SentryLocation AssignedLocation { get; private set; }

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x00084D36 File Offset: 0x00082F36
		private Transform standPoint
		{
			get
			{
				return this.AssignedLocation.StandPoints[this.AssignedLocation.AssignedOfficers.IndexOf(this.officer)];
			}
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x00084D5E File Offset: 0x00082F5E
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Behaviour.SentryBehaviour_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x00080D45 File Offset: 0x0007EF45
		protected override void Begin()
		{
			base.Begin();
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x00080D4D File Offset: 0x0007EF4D
		protected override void Resume()
		{
			base.Resume();
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00084D72 File Offset: 0x00082F72
		protected override void End()
		{
			base.End();
			if (this.flashlightEquipped)
			{
				this.SetFlashlightEquipped(false);
			}
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00084D89 File Offset: 0x00082F89
		protected override void Pause()
		{
			base.Pause();
			if (this.flashlightEquipped)
			{
				this.SetFlashlightEquipped(false);
			}
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00077708 File Offset: 0x00075908
		public override void Disable()
		{
			base.Disable();
			this.End();
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x00084DA0 File Offset: 0x00082FA0
		public void AssignLocation(SentryLocation loc)
		{
			if (this.AssignedLocation != null)
			{
				this.UnassignLocation();
			}
			this.AssignedLocation = loc;
			this.AssignedLocation.AssignedOfficers.Add(this.officer);
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00084DD3 File Offset: 0x00082FD3
		public void UnassignLocation()
		{
			if (this.AssignedLocation != null)
			{
				this.AssignedLocation.AssignedOfficers.Remove(this.officer);
				this.AssignedLocation = null;
			}
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00084E04 File Offset: 0x00083004
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentTimeWithinRange(1930, this.FLASHLIGHT_MAX_TIME))
			{
				if (this.UseFlashlight && !this.flashlightEquipped)
				{
					this.SetFlashlightEquipped(true);
				}
			}
			else if (this.flashlightEquipped)
			{
				this.SetFlashlightEquipped(false);
			}
			this.officer.BodySearchChance = 0.1f;
			if (!base.Npc.Movement.IsMoving)
			{
				if (Vector3.Distance(base.Npc.transform.position, this.standPoint.position) < 2f)
				{
					this.officer.BodySearchChance = 0.75f;
					if (!base.Npc.Movement.FaceDirectionInProgress)
					{
						base.Npc.Movement.FaceDirection(this.standPoint.forward, 0.5f);
						return;
					}
				}
				else if (base.Npc.Movement.CanMove())
				{
					base.Npc.Movement.SetDestination(this.standPoint.position);
				}
			}
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x00084F1A File Offset: 0x0008311A
		private void SetFlashlightEquipped(bool equipped)
		{
			this.flashlightEquipped = equipped;
			if (equipped)
			{
				base.Npc.SetEquippable_Networked(null, "Tools/Flashlight/Flashlight_AvatarEquippable");
				return;
			}
			base.Npc.SetEquippable_Networked(null, string.Empty);
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00084F63 File Offset: 0x00083163
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.SentryBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.SentryBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00084F7C File Offset: 0x0008317C
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.SentryBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.SentryBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x00084F95 File Offset: 0x00083195
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00084FA3 File Offset: 0x000831A3
		protected virtual void dll()
		{
			base.Awake();
			this.officer = (base.Npc as PoliceOfficer);
		}

		// Token: 0x040018FA RID: 6394
		public const float BODY_SEARCH_CHANCE = 0.75f;

		// Token: 0x040018FB RID: 6395
		public const int FLASHLIGHT_MIN_TIME = 1930;

		// Token: 0x040018FC RID: 6396
		public int FLASHLIGHT_MAX_TIME = 500;

		// Token: 0x040018FD RID: 6397
		public const string FLASHLIGHT_ASSET_PATH = "Tools/Flashlight/Flashlight_AvatarEquippable";

		// Token: 0x040018FE RID: 6398
		public bool UseFlashlight = true;

		// Token: 0x040018FF RID: 6399
		private bool flashlightEquipped;

		// Token: 0x04001901 RID: 6401
		private PoliceOfficer officer;

		// Token: 0x04001902 RID: 6402
		private bool dll_Excuted;

		// Token: 0x04001903 RID: 6403
		private bool dll_Excuted;
	}
}
