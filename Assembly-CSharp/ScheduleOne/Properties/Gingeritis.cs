using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000311 RID: 785
	[CreateAssetMenu(fileName = "Gingeritis", menuName = "Properties/Gingeritis Property")]
	public class Gingeritis : Property
	{
		// Token: 0x0600115C RID: 4444 RVA: 0x0004CC83 File Offset: 0x0004AE83
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.OverrideHairColor(Gingeritis.Color, true);
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x0004CCA0 File Offset: 0x0004AEA0
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.OverrideHairColor(Gingeritis.Color, true);
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0004CCBD File Offset: 0x0004AEBD
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.ResetHairColor(true);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0004CCD0 File Offset: 0x0004AED0
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.ResetHairColor(true);
		}

		// Token: 0x04001141 RID: 4417
		public static Color32 Color = new Color32(198, 113, 34, byte.MaxValue);
	}
}
