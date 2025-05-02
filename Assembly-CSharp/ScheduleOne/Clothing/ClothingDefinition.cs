using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Clothing
{
	// Token: 0x02000742 RID: 1858
	[CreateAssetMenu(fileName = "ClothingDefinition", menuName = "ScriptableObjects/ClothingDefinition", order = 1)]
	[Serializable]
	public class ClothingDefinition : StorableItemDefinition
	{
		// Token: 0x06003272 RID: 12914 RVA: 0x000D1A44 File Offset: 0x000CFC44
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return new ClothingInstance(this, quantity, this.DefaultColor);
		}

		// Token: 0x040023ED RID: 9197
		public EClothingSlot Slot;

		// Token: 0x040023EE RID: 9198
		public EClothingApplicationType ApplicationType;

		// Token: 0x040023EF RID: 9199
		public string ClothingAssetPath = "Path/To/Clothing/Asset";

		// Token: 0x040023F0 RID: 9200
		public bool Colorable = true;

		// Token: 0x040023F1 RID: 9201
		public EClothingColor DefaultColor;

		// Token: 0x040023F2 RID: 9202
		public List<EClothingSlot> SlotsToBlock = new List<EClothingSlot>();
	}
}
