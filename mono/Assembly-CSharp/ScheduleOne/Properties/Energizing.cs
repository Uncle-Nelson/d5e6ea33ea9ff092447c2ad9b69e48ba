using System;
using ScheduleOne.AvatarFramework;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200030E RID: 782
	[CreateAssetMenu(fileName = "Energizing", menuName = "Properties/Energizing Property")]
	public class Energizing : Property
	{
		// Token: 0x0600114D RID: 4429 RVA: 0x0004C9E8 File Offset: 0x0004ABE8
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Eyes.OverrideEyeLids(new Eye.EyeLidConfiguration
			{
				bottomLidOpen = 0.6f,
				topLidOpen = 0.7f
			});
			npc.Avatar.Eyes.ForceBlink();
			npc.Movement.SpeedController.SpeedMultiplier = 1.15f;
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0004CA4C File Offset: 0x0004AC4C
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Eyes.OverrideEyeLids(new Eye.EyeLidConfiguration
			{
				bottomLidOpen = 0.6f,
				topLidOpen = 0.7f
			});
			player.Avatar.Eyes.ForceBlink();
			if (player.IsOwner)
			{
				PlayerSingleton<PlayerMovement>.Instance.MoveSpeedMultiplier = 1.15f;
				PlayerSingleton<PlayerCamera>.Instance.FoVChangeSmoother.AddOverride(5f, this.Tier, "energizing");
				PlayerSingleton<PlayerCamera>.Instance.HeartbeatSoundController.VolumeController.AddOverride(0.3f, this.Tier, "energizing");
				PlayerSingleton<PlayerCamera>.Instance.HeartbeatSoundController.PitchController.AddOverride(1.4f, this.Tier, "energizing");
			}
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x0004C46F File Offset: 0x0004A66F
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Eyes.ResetEyeLids();
			npc.Avatar.Eyes.ForceBlink();
			npc.Movement.SpeedController.SpeedMultiplier = 1f;
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x0004CB18 File Offset: 0x0004AD18
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Eyes.ResetEyeLids();
			player.Avatar.Eyes.ForceBlink();
			if (player.IsOwner)
			{
				PlayerSingleton<PlayerMovement>.Instance.MoveSpeedMultiplier = 1f;
				PlayerSingleton<PlayerCamera>.Instance.FoVChangeSmoother.RemoveOverride("energizing");
				PlayerSingleton<PlayerCamera>.Instance.HeartbeatSoundController.VolumeController.RemoveOverride("energizing");
				PlayerSingleton<PlayerCamera>.Instance.HeartbeatSoundController.PitchController.RemoveOverride("energizing");
			}
		}

		// Token: 0x04001140 RID: 4416
		public const float SPEED_MULTIPLIER = 1.15f;
	}
}
