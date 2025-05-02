using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.ItemFramework;
using ScheduleOne.StationFramework;
using ScheduleOne.UI.Items;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	// Token: 0x02000A6A RID: 2666
	public class StationRecipeEntry : MonoBehaviour
	{
		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x060047CD RID: 18381 RVA: 0x0012CF2D File Offset: 0x0012B12D
		// (set) Token: 0x060047CE RID: 18382 RVA: 0x0012CF35 File Offset: 0x0012B135
		public bool IsValid { get; private set; }

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x060047CF RID: 18383 RVA: 0x0012CF3E File Offset: 0x0012B13E
		// (set) Token: 0x060047D0 RID: 18384 RVA: 0x0012CF46 File Offset: 0x0012B146
		public StationRecipe Recipe { get; private set; }

		// Token: 0x060047D1 RID: 18385 RVA: 0x0012CF50 File Offset: 0x0012B150
		public void AssignRecipe(StationRecipe recipe)
		{
			this.Recipe = recipe;
			this.Icon.sprite = recipe.Product.Item.Icon;
			this.TitleLabel.text = recipe.RecipeTitle;
			if (recipe.Product.Quantity > 1)
			{
				this.TitleLabel.text = this.TitleLabel.text + "(" + recipe.Product.Quantity.ToString() + "x)";
			}
			this.Icon.GetComponent<ItemDefinitionInfoHoverable>().AssignedItem = recipe.Product.Item;
			int num = recipe.CookTime_Mins / 60;
			int num2 = recipe.CookTime_Mins % 60;
			this.CookingTimeLabel.text = string.Format("{0}h", num);
			if (num2 > 0)
			{
				TextMeshProUGUI cookingTimeLabel = this.CookingTimeLabel;
				cookingTimeLabel.text += string.Format(" {0}m", num2);
			}
			this.IngredientQuantities = new TextMeshProUGUI[this.IngredientRects.Length];
			for (int i = 0; i < this.IngredientRects.Length; i++)
			{
				if (i < recipe.Ingredients.Count)
				{
					this.IngredientRects[i].Find("Icon").GetComponent<Image>().sprite = recipe.Ingredients[i].Item.Icon;
					this.IngredientQuantities[i] = this.IngredientRects[i].Find("Quantity").GetComponent<TextMeshProUGUI>();
					this.IngredientQuantities[i].text = recipe.Ingredients[i].Quantity.ToString() + "x";
					this.IngredientRects[i].GetComponent<ItemDefinitionInfoHoverable>().AssignedItem = recipe.Ingredients[i].Item;
					this.IngredientRects[i].gameObject.SetActive(true);
				}
				else
				{
					this.IngredientRects[i].gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x060047D2 RID: 18386 RVA: 0x0012D150 File Offset: 0x0012B350
		public void RefreshValidity(List<ItemInstance> ingredients)
		{
			if (!this.Recipe.Unlocked)
			{
				this.IsValid = false;
				base.gameObject.SetActive(false);
				return;
			}
			this.IsValid = true;
			for (int i = 0; i < this.Recipe.Ingredients.Count; i++)
			{
				List<ItemInstance> list = new List<ItemInstance>();
				using (List<ItemDefinition>.Enumerator enumerator = this.Recipe.Ingredients[i].Items.GetEnumerator())
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
				if (num >= this.Recipe.Ingredients[i].Quantity)
				{
					this.IngredientQuantities[i].color = StationRecipeEntry.ValidColor;
				}
				else
				{
					this.IngredientQuantities[i].color = StationRecipeEntry.InvalidColor;
					this.IsValid = false;
				}
			}
			base.gameObject.SetActive(true);
			this.Button.interactable = this.IsValid;
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x0012D2B4 File Offset: 0x0012B4B4
		public float GetIngredientsMatchDelta(List<ItemInstance> ingredients)
		{
			int num = this.Recipe.Ingredients.Sum((StationRecipe.IngredientQuantity x) => x.Quantity);
			int num2 = 0;
			for (int i = 0; i < this.Recipe.Ingredients.Count; i++)
			{
				List<ItemInstance> list = new List<ItemInstance>();
				using (List<ItemDefinition>.Enumerator enumerator = this.Recipe.Ingredients[i].Items.GetEnumerator())
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
				int num3 = 0;
				for (int j = 0; j < list.Count; j++)
				{
					num3 += list[j].Quantity;
				}
				num2 += Mathf.Min(num3, this.Recipe.Ingredients[i].Quantity);
			}
			return (float)num2 / (float)num;
		}

		// Token: 0x04003534 RID: 13620
		public static Color ValidColor = Color.white;

		// Token: 0x04003535 RID: 13621
		public static Color InvalidColor = new Color32(byte.MaxValue, 80, 80, byte.MaxValue);

		// Token: 0x04003536 RID: 13622
		public Button Button;

		// Token: 0x04003537 RID: 13623
		public Image Icon;

		// Token: 0x04003538 RID: 13624
		public TextMeshProUGUI TitleLabel;

		// Token: 0x04003539 RID: 13625
		public TextMeshProUGUI CookingTimeLabel;

		// Token: 0x0400353A RID: 13626
		public RectTransform[] IngredientRects;

		// Token: 0x0400353B RID: 13627
		private TextMeshProUGUI[] IngredientQuantities;
	}
}
