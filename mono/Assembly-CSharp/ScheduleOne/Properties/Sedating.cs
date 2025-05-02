using System;
using ScheduleOne.AvatarFramework;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200031A RID: 794
	[CreateAssetMenu(fileName = "Sedating", menuName = "Properties/Sedating Property")]
	public class Sedating : Property
	{
		// Token: 0x0600118A RID: 4490 RVA: 0x0004D2D4 File Offset: 0x0004B4D4
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Eyes.OverrideEyeLids(new Eye.EyeLidConfiguration
			{
				bottomLidOpen = 0.18f,
				topLidOpen = 0.18f
			});
			npc.Avatar.Eyes.ForceBlink();
			npc.Movement.SpeedController.SpeedMultiplier = 0.6f;
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0004D338 File Offset: 0x0004B538
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Eyes.OverrideEyeLids(new Eye.EyeLidConfiguration
			{
				bottomLidOpen = 0.18f,
				topLidOpen = 0.18f
			});
			player.Avatar.Eyes.ForceBlink();
			if (player.IsOwner)
			{
				Singleton<EyelidOverlay>.Instance.OpenMultiplier.AddOverride(0.7f, 6, "sedating");
				PlayerSingleton<PlayerCamera>.Instance.FoVChangeSmoother.AddOverride(-8f, this.Tier, "sedating");
				PlayerSingleton<PlayerCamera>.Instance.SmoothLookSmoother.AddOverride(0.8f, this.Tier, "sedating");
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0004C46F File Offset: 0x0004A66F
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Eyes.ResetEyeLids();
			npc.Avatar.Eyes.ForceBlink();
			npc.Movement.SpeedController.SpeedMultiplier = 1f;
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0004D3E8 File Offset: 0x0004B5E8
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Eyes.ResetEyeLids();
			player.Avatar.Eyes.ForceBlink();
			if (player.IsOwner)
			{
				Singleton<EyelidOverlay>.Instance.OpenMultiplier.RemoveOverride("sedating");
				PlayerSingleton<PlayerCamera>.Instance.FoVChangeSmoother.RemoveOverride("sedating");
				PlayerSingleton<PlayerCamera>.Instance.SmoothLookSmoother.RemoveOverride("sedating");
			}
		}
	}
}
