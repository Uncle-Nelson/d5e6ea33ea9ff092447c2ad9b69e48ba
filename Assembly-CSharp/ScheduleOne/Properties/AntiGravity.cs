using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000306 RID: 774
	[CreateAssetMenu(fileName = "AntiGravity", menuName = "Properties/AntiGravity Property")]
	public class AntiGravity : Property
	{
		// Token: 0x06001125 RID: 4389 RVA: 0x0004C295 File Offset: 0x0004A495
		public override void ApplyToNPC(NPC npc)
		{
			npc.Movement.SetGravityMultiplier(0.3f);
			npc.Avatar.Effects.SetAntiGrav(true, true);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0004C2B9 File Offset: 0x0004A4B9
		public override void ApplyToPlayer(Player player)
		{
			player.SetGravityMultiplier(0.3f);
			player.Avatar.Effects.SetAntiGrav(true, true);
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0004C2D8 File Offset: 0x0004A4D8
		public override void ClearFromNPC(NPC npc)
		{
			npc.Movement.SetGravityMultiplier(1f);
			npc.Avatar.Effects.SetAntiGrav(false, true);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0004C2FC File Offset: 0x0004A4FC
		public override void ClearFromPlayer(Player player)
		{
			player.SetGravityMultiplier(1f);
			player.Avatar.Effects.SetAntiGrav(false, true);
		}

		// Token: 0x04001139 RID: 4409
		public const float GravityMultiplier = 0.3f;
	}
}
