using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000317 RID: 791
	[CreateAssetMenu(fileName = "Paranoia", menuName = "Properties/Paranoia Property")]
	public class Paranoia : Property
	{
		// Token: 0x0600117B RID: 4475 RVA: 0x0004D082 File Offset: 0x0004B282
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.EmotionManager.AddEmotionOverride("Concerned", "paranoia", 0f, 0);
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0004D0A4 File Offset: 0x0004B2A4
		public override void ApplyToPlayer(Player player)
		{
			player.Paranoid = true;
			player.Avatar.EmotionManager.AddEmotionOverride("Concerned", "paranoia", 0f, 0);
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0004D0CD File Offset: 0x0004B2CD
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.EmotionManager.RemoveEmotionOverride("paranoia");
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x0004D0E4 File Offset: 0x0004B2E4
		public override void ClearFromPlayer(Player player)
		{
			player.Paranoid = false;
			player.Avatar.EmotionManager.RemoveEmotionOverride("paranoia");
		}
	}
}
