using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000315 RID: 789
	[CreateAssetMenu(fileName = "Laxative", menuName = "Properties/Laxative Property")]
	public class Laxative : Property
	{
		// Token: 0x06001171 RID: 4465 RVA: 0x0004CE4B File Offset: 0x0004B04B
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.EnableLaxative(true);
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0004CE5E File Offset: 0x0004B05E
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.EnableLaxative(true);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x0004CE71 File Offset: 0x0004B071
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.DisableLaxative(true);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x0004CE84 File Offset: 0x0004B084
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.DisableLaxative(true);
		}
	}
}
