using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000323 RID: 803
	[CreateAssetMenu(fileName = "Sneaky", menuName = "Properties/Sneaky Property")]
	public class Sneaky : Property
	{
		// Token: 0x060011B3 RID: 4531 RVA: 0x000045B1 File Offset: 0x000027B1
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0004D736 File Offset: 0x0004B936
		public override void ApplyToPlayer(Player player)
		{
			player.Sneaky = true;
			this.visibilityAttribute = new VisibilityAttribute("sneaky", 0f, 0.6f, -1);
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x000045B1 File Offset: 0x000027B1
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0004D75A File Offset: 0x0004B95A
		public override void ClearFromPlayer(Player player)
		{
			player.Sneaky = true;
			this.visibilityAttribute.Delete();
		}

		// Token: 0x04001152 RID: 4434
		private VisibilityAttribute visibilityAttribute;
	}
}
