using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000321 RID: 801
	[CreateAssetMenu(fileName = "Slippery", menuName = "Properties/Slippery Property")]
	public class Slippery : Property
	{
		// Token: 0x060011A9 RID: 4521 RVA: 0x0004D680 File Offset: 0x0004B880
		public override void ApplyToNPC(NPC npc)
		{
			npc.Movement.SlipperyMode = true;
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0004D68E File Offset: 0x0004B88E
		public override void ApplyToPlayer(Player player)
		{
			player.Slippery = true;
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0004D697 File Offset: 0x0004B897
		public override void ClearFromNPC(NPC npc)
		{
			npc.Movement.SlipperyMode = false;
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0004D6A5 File Offset: 0x0004B8A5
		public override void ClearFromPlayer(Player player)
		{
			player.Slippery = false;
		}
	}
}
