using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000302 RID: 770
	[CreateAssetMenu(fileName = "Cyclopean", menuName = "Properties/Cyclopean Property")]
	public class Cyclopean : Property
	{
		// Token: 0x06001111 RID: 4369 RVA: 0x0004C23D File Offset: 0x0004A43D
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.SetCyclopean(true, true);
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0004C251 File Offset: 0x0004A451
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.SetCyclopean(true, true);
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0004C265 File Offset: 0x0004A465
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.SetCyclopean(false, true);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0004C279 File Offset: 0x0004A479
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.SetCyclopean(false, true);
		}
	}
}
