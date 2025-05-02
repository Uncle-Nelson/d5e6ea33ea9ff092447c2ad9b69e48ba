using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200030D RID: 781
	[CreateAssetMenu(fileName = "Electrifying", menuName = "Properties/Electrifying Property")]
	public class Electrifying : Property
	{
		// Token: 0x06001148 RID: 4424 RVA: 0x0004C93C File Offset: 0x0004AB3C
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.SetZapped(true, true);
			npc.Avatar.Effects.OverrideEyeColor(this.EyeColor, 0.5f, true);
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0004C96C File Offset: 0x0004AB6C
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.SetZapped(true, true);
			player.Avatar.Effects.OverrideEyeColor(this.EyeColor, 0.5f, true);
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x0004C99C File Offset: 0x0004AB9C
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.SetZapped(false, true);
			npc.Avatar.Effects.ResetEyeColor(true);
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x0004C9C1 File Offset: 0x0004ABC1
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.SetZapped(false, true);
			player.Avatar.Effects.ResetEyeColor(true);
		}

		// Token: 0x0400113F RID: 4415
		public Color EyeColor;
	}
}
