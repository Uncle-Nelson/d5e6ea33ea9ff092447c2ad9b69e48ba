using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200030A RID: 778
	[CreateAssetMenu(fileName = "CalmingProperty", menuName = "Properties/Calming Property")]
	public class Calming : Property
	{
		// Token: 0x06001139 RID: 4409 RVA: 0x0004C699 File Offset: 0x0004A899
		public override void ApplyToNPC(NPC npc)
		{
			npc.Movement.SpeedController.SpeedMultiplier = 0.8f;
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0004C6B0 File Offset: 0x0004A8B0
		public override void ApplyToPlayer(Player player)
		{
			if (player.IsOwner)
			{
				Singleton<EyelidOverlay>.Instance.OpenMultiplier.AddOverride(0.9f, 6, "calming");
				PlayerSingleton<PlayerCamera>.Instance.FoVChangeSmoother.AddOverride(-4f, this.Tier, "calming");
			}
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0004C6FE File Offset: 0x0004A8FE
		public override void ClearFromNPC(NPC npc)
		{
			npc.Movement.SpeedController.SpeedMultiplier = 1f;
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x0004C715 File Offset: 0x0004A915
		public override void ClearFromPlayer(Player player)
		{
			if (player.IsOwner)
			{
				Singleton<EyelidOverlay>.Instance.OpenMultiplier.RemoveOverride("calming");
				PlayerSingleton<PlayerCamera>.Instance.FoVChangeSmoother.RemoveOverride("calming");
			}
		}
	}
}
