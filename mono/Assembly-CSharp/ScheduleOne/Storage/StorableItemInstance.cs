using System;
using FishNet.Serializing.Helping;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Storage
{
	// Token: 0x020008A8 RID: 2216
	[Serializable]
	public class StorableItemInstance : ItemInstance
	{
		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06003C09 RID: 15369 RVA: 0x000FCC04 File Offset: 0x000FAE04
		[CodegenExclude]
		public virtual StoredItem StoredItem
		{
			get
			{
				if (base.Definition != null && base.Definition is StorableItemDefinition)
				{
					return (base.Definition as StorableItemDefinition).StoredItem;
				}
				string str = "StorableItemInstance has invalid definition: ";
				ItemDefinition definition = base.Definition;
				Console.LogError(str + ((definition != null) ? definition.ToString() : null), null);
				return null;
			}
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x000FCC60 File Offset: 0x000FAE60
		public StorableItemInstance()
		{
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x000FCC68 File Offset: 0x000FAE68
		public StorableItemInstance(ItemDefinition definition, int quantity) : base(definition, quantity)
		{
			if (definition as StorableItemDefinition == null)
			{
				Console.LogError("StoredItemInstance initialized with invalid definition!", null);
				return;
			}
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x000FCC8C File Offset: 0x000FAE8C
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			int quantity = this.Quantity;
			if (overrideQuantity != -1)
			{
				quantity = overrideQuantity;
			}
			return new StorableItemInstance(base.Definition, quantity);
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x000FCCB2 File Offset: 0x000FAEB2
		public override float GetMonetaryValue()
		{
			return (base.Definition as StorableItemDefinition).BasePurchasePrice;
		}
	}
}
