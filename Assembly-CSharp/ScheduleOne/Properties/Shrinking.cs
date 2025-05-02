using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000320 RID: 800
	[CreateAssetMenu(fileName = "Shrinking", menuName = "Properties/Shrinking Property")]
	public class Shrinking : Property
	{
		// Token: 0x060011A4 RID: 4516 RVA: 0x0004D618 File Offset: 0x0004B818
		public override void ApplyToNPC(NPC npc)
		{
			npc.SetScale(0.8f, 1f);
			npc.VoiceOverEmitter.SetRuntimePitchMultiplier(1.5f);
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0004D63A File Offset: 0x0004B83A
		public override void ApplyToPlayer(Player player)
		{
			player.SetScale(0.8f, 1f);
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0004D64C File Offset: 0x0004B84C
		public override void ClearFromNPC(NPC npc)
		{
			npc.SetScale(1f, 1f);
			npc.VoiceOverEmitter.SetRuntimePitchMultiplier(1f);
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0004D66E File Offset: 0x0004B86E
		public override void ClearFromPlayer(Player player)
		{
			player.SetScale(1f, 1f);
		}

		// Token: 0x04001150 RID: 4432
		public const float Scale = 0.8f;

		// Token: 0x04001151 RID: 4433
		public const float LerpTime = 1f;
	}
}
