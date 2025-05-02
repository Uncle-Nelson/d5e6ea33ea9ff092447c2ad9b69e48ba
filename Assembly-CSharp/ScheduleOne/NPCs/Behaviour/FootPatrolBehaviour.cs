using System;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200051D RID: 1309
	public class FootPatrolBehaviour : Behaviour
	{
		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x0007FF97 File Offset: 0x0007E197
		// (set) Token: 0x06001F46 RID: 8006 RVA: 0x0007FF9F File Offset: 0x0007E19F
		public PatrolGroup Group { get; protected set; }

		// Token: 0x06001F47 RID: 8007 RVA: 0x0007FFA8 File Offset: 0x0007E1A8
		protected override void Begin()
		{
			base.Begin();
			if (InstanceFinder.IsServer && this.Group == null)
			{
				Console.LogError("Foot patrol behaviour started without a group!", null);
			}
			base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("footpatrol", 1, 0.08f));
			(base.Npc as PoliceOfficer).BodySearchChance = 0.4f;
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00080010 File Offset: 0x0007E210
		protected override void Resume()
		{
			base.Resume();
			if (InstanceFinder.IsServer && this.Group == null)
			{
				Console.LogError("Foot patrol behaviour resumed without a group!", null);
			}
			base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("footpatrol", 1, 0.08f));
			(base.Npc as PoliceOfficer).BodySearchChance = 0.25f;
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00080078 File Offset: 0x0007E278
		protected override void Pause()
		{
			base.Pause();
			base.Npc.Movement.SpeedController.RemoveSpeedControl("footpatrol");
			(base.Npc as PoliceOfficer).BodySearchChance = 0.1f;
			if (this.flashlightEquipped)
			{
				this.SetFlashlightEquipped(false);
			}
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x000800CC File Offset: 0x0007E2CC
		protected override void End()
		{
			base.End();
			if (this.Group != null)
			{
				this.Group.Members.Remove(base.Npc);
			}
			base.Npc.Movement.SpeedController.RemoveSpeedControl("footpatrol");
			if (this.flashlightEquipped)
			{
				this.SetFlashlightEquipped(false);
			}
			(base.Npc as PoliceOfficer).BodySearchChance = 0.1f;
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x0008013C File Offset: 0x0007E33C
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentTimeWithinRange(1930, this.FLASHLIGHT_MAX_TIME))
			{
				if (this.UseFlashlight && !this.flashlightEquipped && this.Group.Members.Count > 0 && this.Group.Members[0] == base.Npc)
				{
					this.SetFlashlightEquipped(true);
				}
			}
			else if (this.flashlightEquipped)
			{
				this.SetFlashlightEquipped(false);
			}
			if (this.Group == null)
			{
				return;
			}
			if (!this.Group.Members.Contains(base.Npc))
			{
				Console.LogWarning("Foot patrol behaviour is not in group members list! Adding now", null);
				this.SetGroup(this.Group);
			}
			if (this.Group.IsPaused())
			{
				if (base.Npc.Movement.IsMoving)
				{
					base.Npc.Movement.Stop();
				}
				return;
			}
			if (base.Npc.Movement.IsMoving)
			{
				return;
			}
			if (this.IsReadyToAdvance())
			{
				if (this.Group.Members.Count > 0 && this.Group.Members[0] == base.Npc && this.Group.IsGroupReadyToAdvance())
				{
					this.Group.AdvanceGroup();
					return;
				}
			}
			else if (!this.IsAtDestination())
			{
				base.Npc.Movement.SetDestination(this.Group.GetDestination(base.Npc));
			}
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x000802BD File Offset: 0x0007E4BD
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

		// Token: 0x06001F4D RID: 8013 RVA: 0x000802EC File Offset: 0x0007E4EC
		public void SetGroup(PatrolGroup group)
		{
			this.Group = group;
			this.Group.Members.Add(base.Npc);
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x0008030C File Offset: 0x0007E50C
		public bool IsReadyToAdvance()
		{
			Vector3 destination = this.Group.GetDestination(base.Npc);
			return Vector3.Distance(base.transform.position, destination) < 2f || (!base.Npc.Movement.IsMoving && base.Npc.Movement.IsAsCloseAsPossible(this.Group.GetDestination(base.Npc), 3f));
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00080384 File Offset: 0x0007E584
		private bool IsAtDestination()
		{
			return this.Group != null && Vector3.Distance(base.Npc.Movement.FootPosition, this.Group.GetDestination(base.Npc)) < 2f;
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x000803D7 File Offset: 0x0007E5D7
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FootPatrolBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FootPatrolBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x000803F0 File Offset: 0x0007E5F0
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FootPatrolBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FootPatrolBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x00080409 File Offset: 0x0007E609
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00080417 File Offset: 0x0007E617
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400186E RID: 6254
		public const float MOVE_SPEED = 0.08f;

		// Token: 0x0400186F RID: 6255
		public const int FLASHLIGHT_MIN_TIME = 1930;

		// Token: 0x04001870 RID: 6256
		public int FLASHLIGHT_MAX_TIME = 500;

		// Token: 0x04001871 RID: 6257
		public const string FLASHLIGHT_ASSET_PATH = "Tools/Flashlight/Flashlight_AvatarEquippable";

		// Token: 0x04001872 RID: 6258
		public bool UseFlashlight = true;

		// Token: 0x04001873 RID: 6259
		private bool flashlightEquipped;

		// Token: 0x04001875 RID: 6261
		private bool dll_Excuted;

		// Token: 0x04001876 RID: 6262
		private bool dll_Excuted;
	}
}
