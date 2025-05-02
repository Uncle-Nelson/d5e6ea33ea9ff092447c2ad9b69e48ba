using System;
using ScheduleOne.Equipping;
using ScheduleOne.UI.Items;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200094B RID: 2379
	[CreateAssetMenu(fileName = "ItemDefinition", menuName = "ScriptableObjects/ItemDefinition", order = 1)]
	[Serializable]
	public class ItemDefinition : ScriptableObject
	{
		// Token: 0x06004044 RID: 16452 RVA: 0x0010E650 File Offset: 0x0010C850
		public virtual ItemInstance GetDefaultInstance(int quantity = 1)
		{
			Console.LogError("This should be overridden in the definition class!", null);
			return null;
		}

		// Token: 0x04002E24 RID: 11812
		public const int DEFAULT_STACK_LIMIT = 10;

		// Token: 0x04002E25 RID: 11813
		public string Name;

		// Token: 0x04002E26 RID: 11814
		[TextArea(3, 10)]
		public string Description;

		// Token: 0x04002E27 RID: 11815
		public string ID;

		// Token: 0x04002E28 RID: 11816
		public Sprite Icon;

		// Token: 0x04002E29 RID: 11817
		public EItemCategory Category;

		// Token: 0x04002E2A RID: 11818
		public string[] Keywords;

		// Token: 0x04002E2B RID: 11819
		public bool AvailableInDemo = true;

		// Token: 0x04002E2C RID: 11820
		public Color LabelDisplayColor = Color.white;

		// Token: 0x04002E2D RID: 11821
		public int StackLimit = 10;

		// Token: 0x04002E2E RID: 11822
		public Equippable Equippable;

		// Token: 0x04002E2F RID: 11823
		public ItemUI CustomItemUI;

		// Token: 0x04002E30 RID: 11824
		public ItemInfoContent CustomInfoContent;

		// Token: 0x04002E31 RID: 11825
		[Header("Legal Status")]
		public ELegalStatus legalStatus;
	}
}
