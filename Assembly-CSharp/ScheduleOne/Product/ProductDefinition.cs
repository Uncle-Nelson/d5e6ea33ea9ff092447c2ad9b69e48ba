using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Packaging;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Properties;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008EE RID: 2286
	[CreateAssetMenu(fileName = "ProductDefinition", menuName = "ScriptableObjects/ProductDefinition", order = 1)]
	[Serializable]
	public class ProductDefinition : PropertyItemDefinition, ISaveable
	{
		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06003DAC RID: 15788 RVA: 0x00102DD7 File Offset: 0x00100FD7
		public EDrugType DrugType
		{
			get
			{
				return this.DrugTypes[0].DrugType;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06003DAD RID: 15789 RVA: 0x00102DEA File Offset: 0x00100FEA
		public float Price
		{
			get
			{
				return NetworkSingleton<ProductManager>.Instance.GetPrice(this);
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06003DAE RID: 15790 RVA: 0x00102DF7 File Offset: 0x00100FF7
		// (set) Token: 0x06003DAF RID: 15791 RVA: 0x00102DFF File Offset: 0x00100FFF
		public List<StationRecipe> Recipes { get; private set; } = new List<StationRecipe>();

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06003DB0 RID: 15792 RVA: 0x00102E08 File Offset: 0x00101008
		public string SaveFolderName
		{
			get
			{
				return SaveManager.SanitizeFileName(this.ID);
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06003DB1 RID: 15793 RVA: 0x00102E08 File Offset: 0x00101008
		public string SaveFileName
		{
			get
			{
				return SaveManager.SanitizeFileName(this.ID);
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06003DB2 RID: 15794 RVA: 0x00046D4A File Offset: 0x00044F4A
		public Loader Loader
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06003DB3 RID: 15795 RVA: 0x000141BA File Offset: 0x000123BA
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x00102E15 File Offset: 0x00101015
		// (set) Token: 0x06003DB5 RID: 15797 RVA: 0x00102E1D File Offset: 0x0010101D
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06003DB6 RID: 15798 RVA: 0x00102E26 File Offset: 0x00101026
		// (set) Token: 0x06003DB7 RID: 15799 RVA: 0x00102E2E File Offset: 0x0010102E
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x00102E37 File Offset: 0x00101037
		// (set) Token: 0x06003DB9 RID: 15801 RVA: 0x00102E3F File Offset: 0x0010103F
		public bool HasChanged { get; set; }

		// Token: 0x06003DBA RID: 15802 RVA: 0x00102E48 File Offset: 0x00101048
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return new ProductItemInstance(this, quantity, EQuality.Standard, null);
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x00102E53 File Offset: 0x00101053
		public void OnValidate()
		{
			this.MarketValue = ProductManager.CalculateProductValue(this, this.BasePrice);
			this.CleanRecipes();
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x00102E70 File Offset: 0x00101070
		public void Initialize(List<Property> properties, List<EDrugType> drugTypes)
		{
			base.Initialize(properties);
			this.DrugTypes = new List<DrugTypeContainer>();
			for (int i = 0; i < drugTypes.Count; i++)
			{
				this.DrugTypes.Add(new DrugTypeContainer
				{
					DrugType = drugTypes[i]
				});
			}
			this.CleanRecipes();
			this.MarketValue = ProductManager.CalculateProductValue(this, this.BasePrice);
			this.InitializeSaveable();
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x00102EDC File Offset: 0x001010DC
		public float GetAddictiveness()
		{
			float num = this.BaseAddictiveness;
			for (int i = 0; i < this.Properties.Count; i++)
			{
				num += this.Properties[i].Addictiveness;
			}
			return Mathf.Clamp01(num);
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x00102F20 File Offset: 0x00101120
		public void CleanRecipes()
		{
			for (int i = this.Recipes.Count - 1; i >= 0; i--)
			{
				if (this.Recipes[i] == null)
				{
					this.Recipes.RemoveAt(i);
				}
			}
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x00102F65 File Offset: 0x00101165
		public void AddRecipe(StationRecipe recipe)
		{
			if (recipe.Product.Item != this)
			{
				Debug.LogError("Recipe product does not match this product.");
				return;
			}
			if (!this.Recipes.Contains(recipe))
			{
				this.Recipes.Add(recipe);
			}
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x00102FA0 File Offset: 0x001011A0
		public virtual string GetSaveString()
		{
			string[] array = new string[this.Properties.Count];
			for (int i = 0; i < this.Properties.Count; i++)
			{
				array[i] = this.Properties[i].ID;
			}
			return new ProductData(this.Name, this.ID, this.DrugTypes[0].DrugType, array).GetJson(true);
		}

		// Token: 0x04002C7A RID: 11386
		[Header("Product Settings")]
		public List<DrugTypeContainer> DrugTypes;

		// Token: 0x04002C7B RID: 11387
		public float LawIntensityChange = 1f;

		// Token: 0x04002C7C RID: 11388
		public float BasePrice = 1f;

		// Token: 0x04002C7D RID: 11389
		public float MarketValue = 1f;

		// Token: 0x04002C7E RID: 11390
		public FunctionalProduct FunctionalProduct;

		// Token: 0x04002C7F RID: 11391
		public int EffectsDuration = 180;

		// Token: 0x04002C80 RID: 11392
		[Range(0f, 1f)]
		public float BaseAddictiveness;

		// Token: 0x04002C81 RID: 11393
		[Header("Packaging that can be applied to this product. MUST BE ORDERED FROm LOWEST TO HIGHEST QUANTITY")]
		public PackagingDefinition[] ValidPackaging;
	}
}
