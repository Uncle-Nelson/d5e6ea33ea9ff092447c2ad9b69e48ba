using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000325 RID: 805
	[CreateAssetMenu(fileName = "ThoughtProvoking", menuName = "Properties/ThoughtProvoking Property")]
	public class ThoughtProvoking : Property
	{
		// Token: 0x060011BD RID: 4541 RVA: 0x0004D82E File Offset: 0x0004BA2E
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.SetBigHeadActive(true, true);
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0004D842 File Offset: 0x0004BA42
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.SetBigHeadActive(true, true);
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0004D856 File Offset: 0x0004BA56
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.SetBigHeadActive(false, true);
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0004D86A File Offset: 0x0004BA6A
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.SetBigHeadActive(false, true);
		}
	}
}
