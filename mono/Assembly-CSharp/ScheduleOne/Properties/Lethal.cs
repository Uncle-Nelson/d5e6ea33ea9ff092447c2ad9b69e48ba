using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000316 RID: 790
	[CreateAssetMenu(fileName = "Lethal", menuName = "Properties/Lethal Property")]
	public class Lethal : Property
	{
		// Token: 0x06001176 RID: 4470 RVA: 0x0004CE98 File Offset: 0x0004B098
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.SetSicklySkinColor(true);
			npc.Avatar.EmotionManager.AddEmotionOverride("Concerned", "Sickly", 0f, this.Tier);
			npc.Avatar.Effects.TriggerSick(true);
			npc.Health.SetAfflictedWithLethalEffect(true);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0004CEF8 File Offset: 0x0004B0F8
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.SetSicklySkinColor(true);
			player.Avatar.EmotionManager.AddEmotionOverride("Concerned", "Sickly", 0f, this.Tier);
			player.Avatar.Effects.TriggerSick(true);
			player.Health.SetAfflictedWithLethalEffect(true);
			if (player.IsOwner)
			{
				PlayerSingleton<PlayerCamera>.Instance.HeartbeatSoundController.VolumeController.AddOverride(0.7f, this.Tier, "sickly");
				PlayerSingleton<PlayerCamera>.Instance.HeartbeatSoundController.PitchController.AddOverride(1f, this.Tier, "sickly");
			}
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0004CFA8 File Offset: 0x0004B1A8
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.SetSicklySkinColor(false);
			npc.Avatar.EmotionManager.RemoveEmotionOverride("Sickly");
			npc.Avatar.Effects.TriggerSick(true);
			npc.Health.SetAfflictedWithLethalEffect(false);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0004CFF8 File Offset: 0x0004B1F8
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.SetSicklySkinColor(false);
			player.Avatar.EmotionManager.RemoveEmotionOverride("Sickly");
			player.Avatar.Effects.TriggerSick(true);
			player.Health.SetAfflictedWithLethalEffect(false);
			if (player.IsOwner)
			{
				PlayerSingleton<PlayerCamera>.Instance.HeartbeatSoundController.VolumeController.RemoveOverride("sickly");
				PlayerSingleton<PlayerCamera>.Instance.HeartbeatSoundController.PitchController.RemoveOverride("sickly");
			}
		}

		// Token: 0x04001143 RID: 4419
		public const float HEALTH_DRAIN_PLAYER = 15f;

		// Token: 0x04001144 RID: 4420
		public const float HEALTH_DRAIN_NPC = 15f;
	}
}
