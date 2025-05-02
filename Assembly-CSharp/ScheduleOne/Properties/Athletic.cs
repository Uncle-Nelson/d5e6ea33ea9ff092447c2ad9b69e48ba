using System;
using ScheduleOne.AvatarFramework;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000307 RID: 775
	[CreateAssetMenu(fileName = "Athletic", menuName = "Properties/Athletic Property")]
	public class Athletic : Property
	{
		// Token: 0x0600112A RID: 4394 RVA: 0x0004C31C File Offset: 0x0004A51C
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Eyes.OverrideEyeLids(new Eye.EyeLidConfiguration
			{
				bottomLidOpen = 0.7f,
				topLidOpen = 0.8f
			});
			npc.Avatar.Eyes.ForceBlink();
			npc.Movement.SpeedController.SpeedMultiplier = 1.3f;
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x0004C380 File Offset: 0x0004A580
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Eyes.OverrideEyeLids(new Eye.EyeLidConfiguration
			{
				bottomLidOpen = 0.7f,
				topLidOpen = 0.8f
			});
			player.Avatar.Eyes.ForceBlink();
			if (player.IsOwner)
			{
				PlayerSingleton<PlayerMovement>.Instance.MoveSpeedMultiplier = 1.3f;
				PlayerSingleton<PlayerCamera>.Instance.FoVChangeSmoother.AddOverride(10f, this.Tier, "athletic");
				PlayerSingleton<PlayerCamera>.Instance.HeartbeatSoundController.VolumeController.AddOverride(0.5f, this.Tier, "athletic");
				PlayerSingleton<PlayerCamera>.Instance.HeartbeatSoundController.PitchController.AddOverride(1.7f, this.Tier, "athletic");
				Singleton<PostProcessingManager>.Instance.ColorFilterController.AddOverride(this.TintColor, this.Tier, "athletic");
			}
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0004C46F File Offset: 0x0004A66F
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Eyes.ResetEyeLids();
			npc.Avatar.Eyes.ForceBlink();
			npc.Movement.SpeedController.SpeedMultiplier = 1f;
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0004C4A8 File Offset: 0x0004A6A8
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Eyes.ResetEyeLids();
			player.Avatar.Eyes.ForceBlink();
			if (player.IsOwner)
			{
				PlayerSingleton<PlayerMovement>.Instance.MoveSpeedMultiplier = 1f;
				PlayerSingleton<PlayerCamera>.Instance.FoVChangeSmoother.RemoveOverride("athletic");
				PlayerSingleton<PlayerCamera>.Instance.HeartbeatSoundController.VolumeController.RemoveOverride("athletic");
				PlayerSingleton<PlayerCamera>.Instance.HeartbeatSoundController.PitchController.RemoveOverride("athletic");
				Singleton<PostProcessingManager>.Instance.ColorFilterController.RemoveOverride("athletic");
			}
		}

		// Token: 0x0400113A RID: 4410
		public const float SPEED_MULTIPLIER = 1.3f;

		// Token: 0x0400113B RID: 4411
		[ColorUsage(true, true)]
		[SerializeField]
		public Color TintColor = Color.white;
	}
}
