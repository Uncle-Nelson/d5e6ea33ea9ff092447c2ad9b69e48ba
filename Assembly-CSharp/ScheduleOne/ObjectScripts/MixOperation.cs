using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;
using ScheduleOne.Properties;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BE4 RID: 3044
	[Serializable]
	public class MixOperation
	{
		// Token: 0x060054C2 RID: 21698 RVA: 0x00164EA6 File Offset: 0x001630A6
		public MixOperation(string productID, EQuality productQuality, string ingredientID, int quantity)
		{
			this.ProductID = productID;
			this.ProductQuality = productQuality;
			this.IngredientID = ingredientID;
			this.Quantity = quantity;
		}

		// Token: 0x060054C3 RID: 21699 RVA: 0x0000494F File Offset: 0x00002B4F
		public MixOperation()
		{
		}

		// Token: 0x060054C4 RID: 21700 RVA: 0x00164ECC File Offset: 0x001630CC
		public EDrugType GetOutput(out List<Property> properties)
		{
			ProductDefinition item = Registry.GetItem<ProductDefinition>(this.ProductID);
			PropertyItemDefinition item2 = Registry.GetItem<PropertyItemDefinition>(this.IngredientID);
			properties = PropertyMixCalculator.MixProperties(item.Properties, item2.Properties[0], item.DrugType);
			return item.DrugType;
		}

		// Token: 0x060054C5 RID: 21701 RVA: 0x00164F18 File Offset: 0x00163118
		public bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			List<Property> properties;
			EDrugType output = this.GetOutput(out properties);
			knownProduct = NetworkSingleton<ProductManager>.Instance.GetKnownProduct(output, properties);
			return knownProduct != null;
		}

		// Token: 0x04003EFB RID: 16123
		public string ProductID;

		// Token: 0x04003EFC RID: 16124
		public EQuality ProductQuality;

		// Token: 0x04003EFD RID: 16125
		public string IngredientID;

		// Token: 0x04003EFE RID: 16126
		public int Quantity;
	}
}
