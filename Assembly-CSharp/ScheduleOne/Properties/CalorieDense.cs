using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200030B RID: 779
	[CreateAssetMenu(fileName = "CalorieDense", menuName = "Properties/CalorieDense Property")]
	public class CalorieDense : Property
	{
		// Token: 0x0600113E RID: 4414 RVA: 0x0004C747 File Offset: 0x0004A947
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.AddAdditionalWeightOverride(1f, 6, "calorie dense", true);
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0004C765 File Offset: 0x0004A965
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.AddAdditionalWeightOverride(1f, 6, "calorie dense", true);
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x0004C783 File Offset: 0x0004A983
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.RemoveAdditionalWeightOverride("calorie dense", true);
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x0004C79B File Offset: 0x0004A99B
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.RemoveAdditionalWeightOverride("calorie dense", true);
		}
	}
}
