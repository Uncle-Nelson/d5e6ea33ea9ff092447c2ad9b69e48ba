using System;
using System.Collections.Generic;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x02000666 RID: 1638
	[Serializable]
	public class CustomerAffinityData
	{
		// Token: 0x06002CD6 RID: 11478 RVA: 0x000BA7E8 File Offset: 0x000B89E8
		public void CopyTo(CustomerAffinityData data)
		{
			using (List<ProductTypeAffinity>.Enumerator enumerator = this.ProductAffinities.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ProductTypeAffinity affinity = enumerator.Current;
					if (data.ProductAffinities.Exists((ProductTypeAffinity x) => x.DrugType == affinity.DrugType))
					{
						data.ProductAffinities.Find((ProductTypeAffinity x) => x.DrugType == affinity.DrugType).Affinity = affinity.Affinity;
					}
					else
					{
						data.ProductAffinities.Add(new ProductTypeAffinity
						{
							DrugType = affinity.DrugType,
							Affinity = affinity.Affinity
						});
					}
				}
			}
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x000BA8BC File Offset: 0x000B8ABC
		public float GetAffinity(EDrugType type)
		{
			ProductTypeAffinity productTypeAffinity = this.ProductAffinities.Find((ProductTypeAffinity x) => x.DrugType == type);
			if (productTypeAffinity == null)
			{
				Debug.LogWarning("No affinity data found for product type " + type.ToString());
				return 0f;
			}
			return productTypeAffinity.Affinity;
		}

		// Token: 0x04001FEA RID: 8170
		[Header("Product Affinities - How much the customer likes each product type. -1 = hates, 0 = neutral, 1 = loves.")]
		public List<ProductTypeAffinity> ProductAffinities = new List<ProductTypeAffinity>();
	}
}
