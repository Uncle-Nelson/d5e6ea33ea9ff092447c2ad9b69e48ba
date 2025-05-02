using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000326 RID: 806
	[CreateAssetMenu(fileName = "Toxic", menuName = "Properties/Toxic Property")]
	public class Toxic : Property
	{
		// Token: 0x060011C2 RID: 4546 RVA: 0x0004D87E File Offset: 0x0004BA7E
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.TriggerSick(true);
			npc.Avatar.EmotionManager.AddEmotionOverride("Concerned", "toxic", 30f, 1);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0004D8B4 File Offset: 0x0004BAB4
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.TriggerSick(true);
			player.Avatar.EmotionManager.AddEmotionOverride("Concerned", "toxic", 30f, 1);
			if (player.Owner.IsLocalClient)
			{
				Singleton<PostProcessingManager>.Instance.ColorFilterController.AddOverride(this.TintColor, this.Tier, "Toxic");
			}
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x000045B1 File Offset: 0x000027B1
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0004D91F File Offset: 0x0004BB1F
		public override void ClearFromPlayer(Player player)
		{
			if (player.Owner.IsLocalClient)
			{
				Singleton<PostProcessingManager>.Instance.ColorFilterController.RemoveOverride("Toxic");
			}
		}

		// Token: 0x04001154 RID: 4436
		[ColorUsage(true, true)]
		[SerializeField]
		public Color TintColor = Color.white;
	}
}
