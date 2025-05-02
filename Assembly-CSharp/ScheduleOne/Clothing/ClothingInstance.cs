using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.Clothing
{
	// Token: 0x02000743 RID: 1859
	[Serializable]
	public class ClothingInstance : StorableItemInstance
	{
		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06003274 RID: 12916 RVA: 0x000D1A78 File Offset: 0x000CFC78
		public override string Name
		{
			get
			{
				return base.Name + ((this.Color != EClothingColor.White) ? (" (" + this.Color.GetLabel() + ")") : string.Empty);
			}
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x000D1AAE File Offset: 0x000CFCAE
		public ClothingInstance()
		{
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x000D1AB6 File Offset: 0x000CFCB6
		public ClothingInstance(ItemDefinition definition, int quantity, EClothingColor color) : base(definition, quantity)
		{
			this.Color = color;
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x000D1AC8 File Offset: 0x000CFCC8
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			int quantity = this.Quantity;
			if (overrideQuantity != -1)
			{
				quantity = overrideQuantity;
			}
			return new ClothingInstance(base.Definition, quantity, this.Color);
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x000D1AF4 File Offset: 0x000CFCF4
		public override ItemData GetItemData()
		{
			return new ClothingData(this.ID, this.Quantity, this.Color);
		}

		// Token: 0x040023F3 RID: 9203
		public EClothingColor Color;
	}
}
