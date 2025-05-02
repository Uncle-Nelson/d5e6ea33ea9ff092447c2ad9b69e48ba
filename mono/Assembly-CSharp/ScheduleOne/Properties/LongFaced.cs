using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000312 RID: 786
	[CreateAssetMenu(fileName = "LongFaced", menuName = "Properties/LongFaced Property")]
	public class LongFaced : Property
	{
		// Token: 0x06001162 RID: 4450 RVA: 0x0004CCFD File Offset: 0x0004AEFD
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.SetGiraffeActive(true, true);
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x0004CD11 File Offset: 0x0004AF11
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.SetGiraffeActive(true, true);
			if (player.IsOwner)
			{
				PlayerSingleton<PlayerCamera>.Instance.FoVChangeSmoother.AddOverride(15f, this.Tier, "longfaced");
			}
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0004CD4C File Offset: 0x0004AF4C
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.SetGiraffeActive(false, true);
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0004CD60 File Offset: 0x0004AF60
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.SetGiraffeActive(false, true);
			if (player.IsOwner)
			{
				PlayerSingleton<PlayerCamera>.Instance.FoVChangeSmoother.RemoveOverride("longfaced");
			}
		}
	}
}
