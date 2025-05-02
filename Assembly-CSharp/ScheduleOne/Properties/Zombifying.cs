using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200032B RID: 811
	[CreateAssetMenu(fileName = "Zombifying", menuName = "Properties/Zombifying Property")]
	public class Zombifying : Property
	{
		// Token: 0x060011D5 RID: 4565 RVA: 0x0004DC58 File Offset: 0x0004BE58
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.SetZombified(true, true);
			npc.VoiceOverEmitter.SetRuntimePitchMultiplier(0.5f);
			npc.VoiceOverEmitter.SetDatabase(this.zombieVODatabase, false);
			npc.PlayVO(EVOLineType.Grunt);
			npc.Movement.SpeedController.SpeedMultiplier = 0.4f;
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0004DCB6 File Offset: 0x0004BEB6
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.SetZombified(true, true);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0004DCCC File Offset: 0x0004BECC
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.SetZombified(false, true);
			npc.VoiceOverEmitter.SetRuntimePitchMultiplier(1f);
			npc.VoiceOverEmitter.ResetDatabase();
			npc.Movement.SpeedController.SpeedMultiplier = 1f;
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0004DD1B File Offset: 0x0004BF1B
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.SetZombified(false, true);
		}

		// Token: 0x04001166 RID: 4454
		public VODatabase zombieVODatabase;
	}
}
