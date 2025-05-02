using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200030F RID: 783
	[CreateAssetMenu(fileName = "Explosive", menuName = "Properties/Explosive Property")]
	public class Explosive : Property
	{
		// Token: 0x06001152 RID: 4434 RVA: 0x0004CBA2 File Offset: 0x0004ADA2
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.TriggerCountdownExplosion(false);
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0004CBB5 File Offset: 0x0004ADB5
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.TriggerCountdownExplosion(false);
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x0004CBC8 File Offset: 0x0004ADC8
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.StopCountdownExplosion(false);
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0004CBDB File Offset: 0x0004ADDB
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.StopCountdownExplosion(false);
		}
	}
}
