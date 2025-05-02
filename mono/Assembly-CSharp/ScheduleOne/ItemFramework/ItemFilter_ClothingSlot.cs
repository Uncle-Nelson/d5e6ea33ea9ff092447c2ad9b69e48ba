using System;
using ScheduleOne.Clothing;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200093F RID: 2367
	public class ItemFilter_ClothingSlot : ItemFilter
	{
		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06004020 RID: 16416 RVA: 0x0010E226 File Offset: 0x0010C426
		// (set) Token: 0x06004021 RID: 16417 RVA: 0x0010E22E File Offset: 0x0010C42E
		public EClothingSlot SlotType { get; private set; }

		// Token: 0x06004022 RID: 16418 RVA: 0x0010E237 File Offset: 0x0010C437
		public ItemFilter_ClothingSlot(EClothingSlot slot)
		{
			this.SlotType = slot;
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x0010E248 File Offset: 0x0010C448
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			ClothingInstance clothingInstance = instance as ClothingInstance;
			if (clothingInstance == null)
			{
				return false;
			}
			ClothingDefinition clothingDefinition = clothingInstance.Definition as ClothingDefinition;
			return !(clothingDefinition == null) && clothingDefinition.Slot == this.SlotType && base.DoesItemMatchFilter(instance);
		}
	}
}
