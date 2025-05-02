using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000322 RID: 802
	[CreateAssetMenu(fileName = "Smelly", menuName = "Properties/Smelly Property")]
	public class Smelly : Property
	{
		// Token: 0x060011AE RID: 4526 RVA: 0x0004D6AE File Offset: 0x0004B8AE
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.SetStinkParticlesActive(true, true);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0004D6C2 File Offset: 0x0004B8C2
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.SetStinkParticlesActive(true, true);
			if (player.Owner.IsLocalClient)
			{
				PlayerSingleton<PlayerCamera>.Instance.Flies.Play();
			}
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0004D6F2 File Offset: 0x0004B8F2
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.SetStinkParticlesActive(false, true);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0004D706 File Offset: 0x0004B906
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.SetStinkParticlesActive(false, true);
			if (player.Owner.IsLocalClient)
			{
				PlayerSingleton<PlayerCamera>.Instance.Flies.Stop();
			}
		}
	}
}
