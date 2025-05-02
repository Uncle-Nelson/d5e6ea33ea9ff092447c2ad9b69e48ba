using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000308 RID: 776
	[CreateAssetMenu(fileName = "Balding", menuName = "Properties/Balding Property")]
	public class Balding : Property
	{
		// Token: 0x0600112F RID: 4399 RVA: 0x0004C559 File Offset: 0x0004A759
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.VanishHair(true);
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x0004C56C File Offset: 0x0004A76C
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.VanishHair(true);
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0004C57F File Offset: 0x0004A77F
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.ReturnHair(true);
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0004C592 File Offset: 0x0004A792
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.ReturnHair(true);
		}
	}
}
