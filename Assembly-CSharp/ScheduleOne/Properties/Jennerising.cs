using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000314 RID: 788
	[CreateAssetMenu(fileName = "Jennerising", menuName = "Properties/Jennerising Property")]
	public class Jennerising : Property
	{
		// Token: 0x0600116C RID: 4460 RVA: 0x0004CDFB File Offset: 0x0004AFFB
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.SetGenderInverted(true, true);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0004CE0F File Offset: 0x0004B00F
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.SetGenderInverted(true, true);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x0004CE23 File Offset: 0x0004B023
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.SetGenderInverted(false, true);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0004CE37 File Offset: 0x0004B037
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.SetGenderInverted(false, true);
		}
	}
}
