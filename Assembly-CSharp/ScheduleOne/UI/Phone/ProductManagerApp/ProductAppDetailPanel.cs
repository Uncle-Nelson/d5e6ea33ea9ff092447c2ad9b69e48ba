using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using ScheduleOne.UI.Tooltips;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.ProductManagerApp
{
	// Token: 0x02000AA7 RID: 2727
	public class ProductAppDetailPanel : MonoBehaviour
	{
		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x0600496B RID: 18795 RVA: 0x00133881 File Offset: 0x00131A81
		// (set) Token: 0x0600496C RID: 18796 RVA: 0x00133889 File Offset: 0x00131A89
		public ProductDefinition ActiveProduct { get; protected set; }

		// Token: 0x0600496D RID: 18797 RVA: 0x00133892 File Offset: 0x00131A92
		public void Awake()
		{
			this.ListedForSale.onValueChanged.AddListener(new UnityAction<bool>(delegate(bool value)
			{
				this.ListingToggled();
			}));
			this.ValueLabel.onEndEdit.AddListener(new UnityAction<string>(delegate(string value)
			{
				this.PriceSubmitted(value);
			}));
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x001338CC File Offset: 0x00131ACC
		public void SetActiveProduct(ProductDefinition productDefinition)
		{
			this.ActiveProduct = productDefinition;
			bool flag = ProductManager.DiscoveredProducts.Contains(productDefinition);
			if (this.ActiveProduct != null)
			{
				this.NameLabel.text = productDefinition.Name;
				this.SuggestedPriceLabel.text = "Suggested: " + MoneyManager.FormatAmount(productDefinition.MarketValue, false, false);
				this.UpdatePrice();
				if (flag)
				{
					this.DescLabel.text = productDefinition.Description;
				}
				else
				{
					this.DescLabel.text = "???";
				}
				for (int i = 0; i < this.PropertyLabels.Length; i++)
				{
					if (productDefinition.Properties.Count > i)
					{
						this.PropertyLabels[i].text = "•  " + productDefinition.Properties[i].Name;
						this.PropertyLabels[i].color = productDefinition.Properties[i].LabelColor;
						this.PropertyLabels[i].gameObject.SetActive(true);
					}
					else
					{
						this.PropertyLabels[i].gameObject.SetActive(false);
					}
				}
				for (int j = 0; j < this.RecipeEntries.Length; j++)
				{
					if (productDefinition.Recipes.Count > j)
					{
						this.RecipeEntries[j].gameObject.SetActive(true);
						if (productDefinition.Recipes[j].Ingredients[0].Item is ProductDefinition)
						{
							this.RecipeEntries[j].Find("Product").GetComponent<Image>().sprite = productDefinition.Recipes[j].Ingredients[0].Item.Icon;
							this.RecipeEntries[j].Find("Product").GetComponent<Tooltip>().text = productDefinition.Recipes[j].Ingredients[0].Item.Name;
							this.RecipeEntries[j].Find("Mixer").GetComponent<Image>().sprite = productDefinition.Recipes[j].Ingredients[1].Item.Icon;
							this.RecipeEntries[j].Find("Mixer").GetComponent<Tooltip>().text = productDefinition.Recipes[j].Ingredients[1].Item.Name;
						}
						else
						{
							this.RecipeEntries[j].Find("Product").GetComponent<Image>().sprite = productDefinition.Recipes[j].Ingredients[1].Item.Icon;
							this.RecipeEntries[j].Find("Product").GetComponent<Tooltip>().text = productDefinition.Recipes[j].Ingredients[1].Item.Name;
							this.RecipeEntries[j].Find("Mixer").GetComponent<Image>().sprite = productDefinition.Recipes[j].Ingredients[0].Item.Icon;
							this.RecipeEntries[j].Find("Mixer").GetComponent<Tooltip>().text = productDefinition.Recipes[j].Ingredients[0].Item.Name;
						}
						this.RecipeEntries[j].Find("Output").GetComponent<Image>().sprite = productDefinition.Icon;
						this.RecipeEntries[j].Find("Output").GetComponent<Tooltip>().text = productDefinition.Name;
					}
					else
					{
						this.RecipeEntries[j].gameObject.SetActive(false);
					}
				}
				this.RecipesLabel.gameObject.SetActive(productDefinition.Recipes.Count > 0);
				this.NothingSelected.gameObject.SetActive(false);
				this.Container.gameObject.SetActive(true);
				this.AddictionSlider.value = productDefinition.GetAddictiveness();
				this.AddictionLabel.text = Mathf.FloorToInt(productDefinition.GetAddictiveness() * 100f).ToString() + "%";
				this.AddictionLabel.color = Color.Lerp(this.AddictionColor_Min, this.AddictionColor_Max, productDefinition.GetAddictiveness());
				ContentSizeFitter[] componentsInChildren = base.GetComponentsInChildren<ContentSizeFitter>();
				for (int k = 0; k < componentsInChildren.Length; k++)
				{
					componentsInChildren[k].enabled = false;
					componentsInChildren[k].enabled = true;
				}
				this.LayoutGroup.enabled = false;
				this.LayoutGroup.enabled = true;
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.LayoutGroup.GetComponent<RectTransform>());
				this.ScrollRect.enabled = false;
				this.ScrollRect.enabled = true;
				this.ScrollRect.verticalNormalizedPosition = 1f;
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.ScrollRect.GetComponent<RectTransform>());
			}
			else
			{
				this.NothingSelected.gameObject.SetActive(true);
				this.Container.gameObject.SetActive(false);
			}
			this.UpdateListed();
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x00133DF3 File Offset: 0x00131FF3
		private void Update()
		{
			if (PlayerSingleton<ProductManagerApp>.Instance.isOpen)
			{
				this.UpdateListed();
			}
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x00133E07 File Offset: 0x00132007
		private void UpdateListed()
		{
			this.ListedForSale.SetIsOnWithoutNotify(ProductManager.ListedProducts.Contains(this.ActiveProduct));
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x00133E24 File Offset: 0x00132024
		private void UpdatePrice()
		{
			this.ValueLabel.SetTextWithoutNotify(NetworkSingleton<ProductManager>.Instance.GetPrice(this.ActiveProduct).ToString());
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x00133E54 File Offset: 0x00132054
		private void ListingToggled()
		{
			if (!NetworkSingleton<ProductManager>.InstanceExists)
			{
				return;
			}
			if (this.ActiveProduct == null)
			{
				return;
			}
			if (ProductManager.ListedProducts.Contains(this.ActiveProduct))
			{
				NetworkSingleton<ProductManager>.Instance.SetProductListed(this.ActiveProduct.ID, false);
			}
			else
			{
				NetworkSingleton<ProductManager>.Instance.SetProductListed(this.ActiveProduct.ID, true);
			}
			Singleton<TaskManager>.Instance.PlayTaskCompleteSound();
			this.UpdateListed();
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x00133EC8 File Offset: 0x001320C8
		private void PriceSubmitted(string value)
		{
			if (!NetworkSingleton<ProductManager>.InstanceExists)
			{
				return;
			}
			if (!PlayerSingleton<ProductManagerApp>.Instance.isOpen)
			{
				return;
			}
			if (!PlayerSingleton<Phone>.Instance.IsOpen)
			{
				return;
			}
			if (this.ActiveProduct == null)
			{
				return;
			}
			float value2;
			if (float.TryParse(value, out value2))
			{
				NetworkSingleton<ProductManager>.Instance.SendPrice(this.ActiveProduct.ID, value2);
				Singleton<TaskManager>.Instance.PlayTaskCompleteSound();
			}
			this.UpdatePrice();
		}

		// Token: 0x04003687 RID: 13959
		public Color AddictionColor_Min;

		// Token: 0x04003688 RID: 13960
		public Color AddictionColor_Max;

		// Token: 0x04003689 RID: 13961
		[Header("References")]
		public GameObject NothingSelected;

		// Token: 0x0400368A RID: 13962
		public GameObject Container;

		// Token: 0x0400368B RID: 13963
		public Text NameLabel;

		// Token: 0x0400368C RID: 13964
		public InputField ValueLabel;

		// Token: 0x0400368D RID: 13965
		public Text SuggestedPriceLabel;

		// Token: 0x0400368E RID: 13966
		public Toggle ListedForSale;

		// Token: 0x0400368F RID: 13967
		public Text DescLabel;

		// Token: 0x04003690 RID: 13968
		public Text[] PropertyLabels;

		// Token: 0x04003691 RID: 13969
		public RectTransform Listed;

		// Token: 0x04003692 RID: 13970
		public RectTransform Delisted;

		// Token: 0x04003693 RID: 13971
		public RectTransform NotDiscovered;

		// Token: 0x04003694 RID: 13972
		public RectTransform RecipesLabel;

		// Token: 0x04003695 RID: 13973
		public RectTransform[] RecipeEntries;

		// Token: 0x04003696 RID: 13974
		public VerticalLayoutGroup LayoutGroup;

		// Token: 0x04003697 RID: 13975
		public Scrollbar AddictionSlider;

		// Token: 0x04003698 RID: 13976
		public Text AddictionLabel;

		// Token: 0x04003699 RID: 13977
		public ScrollRect ScrollRect;
	}
}
