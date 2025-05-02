using System;
using UnityEngine;

namespace ScheduleOne.NPCs.Relation
{
	// Token: 0x0200048E RID: 1166
	public class RelationshipCategory
	{
		// Token: 0x060019CE RID: 6606 RVA: 0x00070046 File Offset: 0x0006E246
		public static ERelationshipCategory GetCategory(float delta)
		{
			if (delta >= 4f)
			{
				return ERelationshipCategory.Loyal;
			}
			if (delta >= 3f)
			{
				return ERelationshipCategory.Friendly;
			}
			if (delta >= 2f)
			{
				return ERelationshipCategory.Neutral;
			}
			if (delta >= 1f)
			{
				return ERelationshipCategory.Unfriendly;
			}
			return ERelationshipCategory.Hostile;
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00070074 File Offset: 0x0006E274
		public static Color32 GetColor(ERelationshipCategory category)
		{
			switch (category)
			{
			case ERelationshipCategory.Hostile:
				return RelationshipCategory.Hostile_Color;
			case ERelationshipCategory.Unfriendly:
				return RelationshipCategory.Unfriendly_Color;
			case ERelationshipCategory.Neutral:
				return RelationshipCategory.Neutral_Color;
			case ERelationshipCategory.Friendly:
				return RelationshipCategory.Friendly_Color;
			case ERelationshipCategory.Loyal:
				return RelationshipCategory.Loyal_Color;
			default:
				Console.LogError("Failed to find relationship category color", null);
				return Color.white;
			}
		}

		// Token: 0x0400163B RID: 5691
		public static Color32 Hostile_Color = new Color32(173, 63, 63, byte.MaxValue);

		// Token: 0x0400163C RID: 5692
		public static Color32 Unfriendly_Color = new Color32(227, 136, 55, byte.MaxValue);

		// Token: 0x0400163D RID: 5693
		public static Color32 Neutral_Color = new Color32(208, 208, 208, byte.MaxValue);

		// Token: 0x0400163E RID: 5694
		public static Color32 Friendly_Color = new Color32(61, 181, 243, byte.MaxValue);

		// Token: 0x0400163F RID: 5695
		public static Color32 Loyal_Color = new Color32(63, 211, 63, byte.MaxValue);
	}
}
