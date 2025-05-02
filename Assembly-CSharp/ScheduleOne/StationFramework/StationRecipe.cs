using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008D3 RID: 2259
	[CreateAssetMenu(fileName = "StationRecipe", menuName = "StationFramework/StationRecipe", order = 1)]
	[Serializable]
	public class StationRecipe : ScriptableObject
	{
		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06003D55 RID: 15701 RVA: 0x001017AE File Offset: 0x000FF9AE
		public float CookTemperatureLowerBound
		{
			get
			{
				return this.CookTemperature - this.CookTemperatureTolerance;
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06003D56 RID: 15702 RVA: 0x001017BD File Offset: 0x000FF9BD
		public float CookTemperatureUpperBound
		{
			get
			{
				return this.CookTemperature + this.CookTemperatureTolerance;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06003D57 RID: 15703 RVA: 0x001017CC File Offset: 0x000FF9CC
		public string RecipeID
		{
			get
			{
				return this.Product.Quantity.ToString() + "x" + this.Product.Item.ID;
			}
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x001017F8 File Offset: 0x000FF9F8
		public StorableItemInstance GetProductInstance(List<ItemInstance> ingredients)
		{
			StorableItemInstance storableItemInstance = this.Product.Item.GetDefaultInstance(this.Product.Quantity) as StorableItemInstance;
			if (storableItemInstance is QualityItemInstance)
			{
				EQuality quality = this.CalculateQuality(ingredients);
				(storableItemInstance as QualityItemInstance).Quality = quality;
			}
			return storableItemInstance;
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x00101844 File Offset: 0x000FFA44
		public StorableItemInstance GetProductInstance(EQuality quality)
		{
			StorableItemInstance storableItemInstance = this.Product.Item.GetDefaultInstance(this.Product.Quantity) as StorableItemInstance;
			if (storableItemInstance is QualityItemInstance)
			{
				(storableItemInstance as QualityItemInstance).Quality = quality;
			}
			return storableItemInstance;
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x00101888 File Offset: 0x000FFA88
		public bool DoIngredientsSuffice(List<ItemInstance> ingredients)
		{
			for (int i = 0; i < this.Ingredients.Count; i++)
			{
				List<ItemInstance> list = new List<ItemInstance>();
				using (List<ItemDefinition>.Enumerator enumerator = this.Ingredients[i].Items.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ItemDefinition ingredientVariant = enumerator.Current;
						List<ItemInstance> collection = (from x in ingredients
						where x.ID == ingredientVariant.ID
						select x).ToList<ItemInstance>();
						list.AddRange(collection);
					}
				}
				int num = 0;
				for (int j = 0; j < list.Count; j++)
				{
					num += list[j].Quantity;
				}
				if (num < this.Ingredients[i].Quantity)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x00101970 File Offset: 0x000FFB70
		public EQuality CalculateQuality(List<ItemInstance> ingredients)
		{
			EQuality result = EQuality.Standard;
			if (this.QualityCalculationMethod == StationRecipe.EQualityCalculationMethod.Additive)
			{
				int num = 0;
				for (int i = 0; i < ingredients.Count; i++)
				{
					if (ingredients[i] is QualityItemInstance)
					{
						switch ((ingredients[i] as QualityItemInstance).Quality)
						{
						case EQuality.Trash:
							num -= 2;
							break;
						case EQuality.Poor:
							num--;
							break;
						case EQuality.Standard:
							num = num;
							break;
						case EQuality.Premium:
							num++;
							break;
						case EQuality.Heavenly:
							num += 2;
							break;
						}
					}
				}
				if ((float)num <= -2f)
				{
					result = EQuality.Trash;
				}
				else if ((float)num == -1f)
				{
					result = EQuality.Poor;
				}
				else if ((float)num == 0f)
				{
					result = EQuality.Standard;
				}
				else if ((float)num == 1f)
				{
					result = EQuality.Premium;
				}
				else if ((float)num >= 2f)
				{
					result = EQuality.Heavenly;
				}
			}
			return result;
		}

		// Token: 0x04002C21 RID: 11297
		[HideInInspector]
		public bool IsDiscovered;

		// Token: 0x04002C22 RID: 11298
		public string RecipeTitle;

		// Token: 0x04002C23 RID: 11299
		public bool Unlocked;

		// Token: 0x04002C24 RID: 11300
		public List<StationRecipe.IngredientQuantity> Ingredients = new List<StationRecipe.IngredientQuantity>();

		// Token: 0x04002C25 RID: 11301
		public StationRecipe.ItemQuantity Product;

		// Token: 0x04002C26 RID: 11302
		public Color FinalLiquidColor = Color.white;

		// Token: 0x04002C27 RID: 11303
		[Tooltip("The time it takes to cook this recipe in minutes")]
		public int CookTime_Mins = 180;

		// Token: 0x04002C28 RID: 11304
		[Tooltip("The temperature at which this recipe should be cooked")]
		[Range(0f, 500f)]
		public float CookTemperature = 250f;

		// Token: 0x04002C29 RID: 11305
		[Range(0f, 100f)]
		public float CookTemperatureTolerance = 25f;

		// Token: 0x04002C2A RID: 11306
		public StationRecipe.EQualityCalculationMethod QualityCalculationMethod;

		// Token: 0x020008D4 RID: 2260
		public enum EQualityCalculationMethod
		{
			// Token: 0x04002C2C RID: 11308
			Additive
		}

		// Token: 0x020008D5 RID: 2261
		[Serializable]
		public class ItemQuantity
		{
			// Token: 0x04002C2D RID: 11309
			public ItemDefinition Item;

			// Token: 0x04002C2E RID: 11310
			public int Quantity = 1;
		}

		// Token: 0x020008D6 RID: 2262
		[Serializable]
		public class IngredientQuantity
		{
			// Token: 0x1700089F RID: 2207
			// (get) Token: 0x06003D5E RID: 15710 RVA: 0x00101A81 File Offset: 0x000FFC81
			public ItemDefinition Item
			{
				get
				{
					return this.Items.FirstOrDefault<ItemDefinition>();
				}
			}

			// Token: 0x04002C2F RID: 11311
			public List<ItemDefinition> Items = new List<ItemDefinition>();

			// Token: 0x04002C30 RID: 11312
			public int Quantity = 1;
		}
	}
}
