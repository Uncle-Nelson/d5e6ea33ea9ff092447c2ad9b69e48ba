using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000327 RID: 807
	[CreateAssetMenu(fileName = "TropicThunder", menuName = "Properties/TropicThunder Property")]
	public class TropicThunder : Property
	{
		// Token: 0x060011C7 RID: 4551 RVA: 0x0004D955 File Offset: 0x0004BB55
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.SetSkinColorInverted(true, true);
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0004D969 File Offset: 0x0004BB69
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.SetSkinColorInverted(true, true);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0004D97D File Offset: 0x0004BB7D
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.SetSkinColorInverted(false, true);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0004D991 File Offset: 0x0004BB91
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.SetSkinColorInverted(false, true);
		}
	}
}
