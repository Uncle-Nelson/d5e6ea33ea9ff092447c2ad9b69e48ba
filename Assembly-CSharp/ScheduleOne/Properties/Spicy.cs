using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000324 RID: 804
	[CreateAssetMenu(fileName = "Spicy", menuName = "Properties/Spicy Property")]
	public class Spicy : Property
	{
		// Token: 0x060011B8 RID: 4536 RVA: 0x0004D76E File Offset: 0x0004B96E
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.SetFireActive(true, true);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0004D784 File Offset: 0x0004B984
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.SetFireActive(true, true);
			if (player.Owner.IsLocalClient)
			{
				Singleton<PostProcessingManager>.Instance.ColorFilterController.AddOverride(this.TintColor, this.Tier, base.name);
			}
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0004D7D1 File Offset: 0x0004B9D1
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.SetFireActive(false, true);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0004D7E5 File Offset: 0x0004B9E5
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.SetFireActive(false, true);
			if (player.Owner.IsLocalClient)
			{
				Singleton<PostProcessingManager>.Instance.ColorFilterController.RemoveOverride(base.name);
			}
		}

		// Token: 0x04001153 RID: 4435
		[ColorUsage(true, true)]
		[SerializeField]
		public Color TintColor = Color.white;
	}
}
