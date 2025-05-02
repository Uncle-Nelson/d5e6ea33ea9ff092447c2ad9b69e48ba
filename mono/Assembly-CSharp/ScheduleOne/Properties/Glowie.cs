using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000313 RID: 787
	[CreateAssetMenu(fileName = "Glowie", menuName = "Properties/Glowie Property")]
	public class Glowie : Property
	{
		// Token: 0x06001167 RID: 4455 RVA: 0x0004CD90 File Offset: 0x0004AF90
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.SetGlowingOn(this.GlowColor, true);
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0004CDA9 File Offset: 0x0004AFA9
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.SetGlowingOn(this.GlowColor, true);
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x0004CDC2 File Offset: 0x0004AFC2
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.SetGlowingOff(true);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0004CDD5 File Offset: 0x0004AFD5
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.SetGlowingOff(true);
		}

		// Token: 0x04001142 RID: 4418
		[ColorUsage(true, true)]
		[SerializeField]
		public Color GlowColor = Color.white;
	}
}
