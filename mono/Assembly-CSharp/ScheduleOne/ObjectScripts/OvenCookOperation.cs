using System;
using FishNet.Serializing.Helping;
using ScheduleOne.ItemFramework;
using ScheduleOne.StationFramework;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BDE RID: 3038
	[Serializable]
	public class OvenCookOperation
	{
		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x0600540E RID: 21518 RVA: 0x001622BD File Offset: 0x001604BD
		[CodegenExclude]
		public StorableItemDefinition Ingredient
		{
			get
			{
				if (this._itemDefinition == null)
				{
					this._itemDefinition = (Registry.GetItem(this.IngredientID) as StorableItemDefinition);
				}
				return this._itemDefinition;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x0600540F RID: 21519 RVA: 0x001622E9 File Offset: 0x001604E9
		[CodegenExclude]
		public StorableItemDefinition Product
		{
			get
			{
				if (this._productionDefinition == null)
				{
					this._productionDefinition = (Registry.GetItem(this.ProductID) as StorableItemDefinition);
				}
				return this._productionDefinition;
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06005410 RID: 21520 RVA: 0x00162315 File Offset: 0x00160515
		[CodegenExclude]
		public CookableModule Cookable
		{
			get
			{
				if (this._cookable == null)
				{
					this._cookable = this.Ingredient.StationItem.GetModule<CookableModule>();
				}
				return this._cookable;
			}
		}

		// Token: 0x06005411 RID: 21521 RVA: 0x00162341 File Offset: 0x00160541
		public OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID)
		{
			this.IngredientID = ingredientID;
			this.IngredientQuality = ingredientQuality;
			this.IngredientQuantity = ingredientQuantity;
			this.ProductID = productID;
			this.CookProgress = 0;
		}

		// Token: 0x06005412 RID: 21522 RVA: 0x0016237B File Offset: 0x0016057B
		public OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID, int progress)
		{
			this.IngredientID = ingredientID;
			this.IngredientQuality = ingredientQuality;
			this.IngredientQuantity = ingredientQuantity;
			this.ProductID = productID;
			this.CookProgress = progress;
		}

		// Token: 0x06005413 RID: 21523 RVA: 0x001623B6 File Offset: 0x001605B6
		public OvenCookOperation()
		{
		}

		// Token: 0x06005414 RID: 21524 RVA: 0x001623CC File Offset: 0x001605CC
		public void UpdateCookProgress(int change)
		{
			this.CookProgress += change;
		}

		// Token: 0x06005415 RID: 21525 RVA: 0x001623DC File Offset: 0x001605DC
		public int GetCookDuration()
		{
			if (this.cookDuration == -1)
			{
				this.cookDuration = this.Ingredient.StationItem.GetModule<CookableModule>().CookTime;
			}
			return this.cookDuration;
		}

		// Token: 0x06005416 RID: 21526 RVA: 0x00162408 File Offset: 0x00160608
		public ItemInstance GetProductItem(int quantity)
		{
			ItemInstance defaultInstance = this.Product.GetDefaultInstance(quantity);
			if (defaultInstance is QualityItemInstance)
			{
				(defaultInstance as QualityItemInstance).Quality = this.IngredientQuality;
			}
			return defaultInstance;
		}

		// Token: 0x06005417 RID: 21527 RVA: 0x0016243C File Offset: 0x0016063C
		public bool IsReady()
		{
			return this.CookProgress >= this.GetCookDuration();
		}

		// Token: 0x04003EAA RID: 16042
		[CodegenExclude]
		private StorableItemDefinition _itemDefinition;

		// Token: 0x04003EAB RID: 16043
		[CodegenExclude]
		private StorableItemDefinition _productionDefinition;

		// Token: 0x04003EAC RID: 16044
		[CodegenExclude]
		private CookableModule _cookable;

		// Token: 0x04003EAD RID: 16045
		public string IngredientID;

		// Token: 0x04003EAE RID: 16046
		public EQuality IngredientQuality;

		// Token: 0x04003EAF RID: 16047
		public int IngredientQuantity = 1;

		// Token: 0x04003EB0 RID: 16048
		public string ProductID;

		// Token: 0x04003EB1 RID: 16049
		public int CookProgress;

		// Token: 0x04003EB2 RID: 16050
		[CodegenExclude]
		private int cookDuration = -1;
	}
}
