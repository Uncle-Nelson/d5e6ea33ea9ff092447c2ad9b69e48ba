using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;
using TMPro;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000B78 RID: 2936
	public class ProductItemInfoContent : QualityItemInfoContent
	{
		// Token: 0x06004E2E RID: 20014 RVA: 0x00149F0C File Offset: 0x0014810C
		public override void Initialize(ItemInstance instance)
		{
			base.Initialize(instance);
			ProductItemInstance productItemInstance = instance as ProductItemInstance;
			if (productItemInstance == null)
			{
				Console.LogError("ProductItemInfoContent can only be used with ProductItemInstance!", null);
				return;
			}
			this.Initialize(productItemInstance.Definition);
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x00149F44 File Offset: 0x00148144
		public override void Initialize(ItemDefinition definition)
		{
			base.Initialize(definition);
			ProductDefinition productDefinition = definition as ProductDefinition;
			PropertyUtility.DrugTypeData drugTypeData = PropertyUtility.GetDrugTypeData(productDefinition.DrugTypes[0].DrugType);
			TextMeshProUGUI qualityLabel = this.QualityLabel;
			qualityLabel.text = qualityLabel.text + " " + drugTypeData.Name;
			for (int i = 0; i < this.PropertyLabels.Count; i++)
			{
				if (productDefinition.Properties.Count > i)
				{
					this.PropertyLabels[i].text = "• " + productDefinition.Properties[i].Name;
					this.PropertyLabels[i].color = productDefinition.Properties[i].LabelColor;
					this.PropertyLabels[i].enabled = true;
				}
				else
				{
					this.PropertyLabels[i].enabled = false;
				}
			}
		}

		// Token: 0x04003AFE RID: 15102
		public List<TextMeshProUGUI> PropertyLabels = new List<TextMeshProUGUI>();
	}
}
