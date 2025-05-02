using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Phone.ProductManagerApp;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.Product
{
	// Token: 0x02000912 RID: 2322
	public class ProductEntry : MonoBehaviour
	{
		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06003EE3 RID: 16099 RVA: 0x001096D3 File Offset: 0x001078D3
		// (set) Token: 0x06003EE4 RID: 16100 RVA: 0x001096DB File Offset: 0x001078DB
		public ProductDefinition Definition { get; private set; }

		// Token: 0x06003EE5 RID: 16101 RVA: 0x001096E4 File Offset: 0x001078E4
		public void Initialize(ProductDefinition definition)
		{
			this.Definition = definition;
			this.Icon.sprite = definition.Icon;
			this.Button.onClick.AddListener(new UnityAction(this.Clicked));
			this.FavouriteButton.onClick.AddListener(new UnityAction(this.FavouriteClicked));
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = 0;
			entry.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
			{
				this.onHovered.Invoke();
			}));
			this.Trigger.triggers.Add(entry);
			this.UpdateListed();
			this.UpdateFavourited();
			this.UpdateDiscovered(this.Definition);
			ProductManager instance = NetworkSingleton<ProductManager>.Instance;
			instance.onProductDiscovered = (Action<ProductDefinition>)Delegate.Combine(instance.onProductDiscovered, new Action<ProductDefinition>(this.UpdateDiscovered));
			ProductManager instance2 = NetworkSingleton<ProductManager>.Instance;
			instance2.onProductListed = (Action<ProductDefinition>)Delegate.Combine(instance2.onProductListed, new Action<ProductDefinition>(this.ProductListedOrDelisted));
			ProductManager instance3 = NetworkSingleton<ProductManager>.Instance;
			instance3.onProductDelisted = (Action<ProductDefinition>)Delegate.Combine(instance3.onProductDelisted, new Action<ProductDefinition>(this.ProductListedOrDelisted));
			ProductManager instance4 = NetworkSingleton<ProductManager>.Instance;
			instance4.onProductFavourited = (Action<ProductDefinition>)Delegate.Combine(instance4.onProductFavourited, new Action<ProductDefinition>(this.ProductFavouritedOrUnFavourited));
			ProductManager instance5 = NetworkSingleton<ProductManager>.Instance;
			instance5.onProductUnfavourited = (Action<ProductDefinition>)Delegate.Combine(instance5.onProductUnfavourited, new Action<ProductDefinition>(this.ProductFavouritedOrUnFavourited));
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x0010984C File Offset: 0x00107A4C
		public void Destroy()
		{
			this.destroyed = true;
			base.gameObject.SetActive(false);
			Object.DestroyImmediate(base.gameObject);
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x0010986C File Offset: 0x00107A6C
		private void OnDestroy()
		{
			ProductManager instance = NetworkSingleton<ProductManager>.Instance;
			instance.onProductDiscovered = (Action<ProductDefinition>)Delegate.Remove(instance.onProductDiscovered, new Action<ProductDefinition>(this.UpdateDiscovered));
			ProductManager instance2 = NetworkSingleton<ProductManager>.Instance;
			instance2.onProductListed = (Action<ProductDefinition>)Delegate.Remove(instance2.onProductListed, new Action<ProductDefinition>(this.ProductListedOrDelisted));
			ProductManager instance3 = NetworkSingleton<ProductManager>.Instance;
			instance3.onProductDelisted = (Action<ProductDefinition>)Delegate.Remove(instance3.onProductDelisted, new Action<ProductDefinition>(this.ProductListedOrDelisted));
			ProductManager instance4 = NetworkSingleton<ProductManager>.Instance;
			instance4.onProductFavourited = (Action<ProductDefinition>)Delegate.Remove(instance4.onProductFavourited, new Action<ProductDefinition>(this.ProductFavouritedOrUnFavourited));
			ProductManager instance5 = NetworkSingleton<ProductManager>.Instance;
			instance5.onProductUnfavourited = (Action<ProductDefinition>)Delegate.Remove(instance5.onProductUnfavourited, new Action<ProductDefinition>(this.ProductFavouritedOrUnFavourited));
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x00109937 File Offset: 0x00107B37
		private void Clicked()
		{
			PlayerSingleton<ProductManagerApp>.Instance.SelectProduct(this);
			this.UpdateListed();
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x0010994C File Offset: 0x00107B4C
		private void FavouriteClicked()
		{
			if (!ProductManager.DiscoveredProducts.Contains(this.Definition))
			{
				return;
			}
			if (ProductManager.FavouritedProducts.Contains(this.Definition))
			{
				NetworkSingleton<ProductManager>.Instance.SetProductFavourited(this.Definition.ID, false);
				return;
			}
			NetworkSingleton<ProductManager>.Instance.SetProductFavourited(this.Definition.ID, true);
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x001099AB File Offset: 0x00107BAB
		private void ProductListedOrDelisted(ProductDefinition def)
		{
			if (def == this.Definition)
			{
				this.UpdateListed();
			}
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x001099C4 File Offset: 0x00107BC4
		public void UpdateListed()
		{
			if (this.destroyed)
			{
				return;
			}
			if (this == null)
			{
				return;
			}
			if (base.gameObject == null)
			{
				return;
			}
			if (ProductManager.ListedProducts.Contains(this.Definition))
			{
				this.Frame.color = this.SelectedColor;
				this.Tick.gameObject.SetActive(true);
				this.Cross.gameObject.SetActive(false);
				return;
			}
			this.Frame.color = this.DeselectedColor;
			this.Tick.gameObject.SetActive(false);
			this.Cross.gameObject.SetActive(true);
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x00109A6C File Offset: 0x00107C6C
		private void ProductFavouritedOrUnFavourited(ProductDefinition def)
		{
			if (def == this.Definition)
			{
				this.UpdateFavourited();
			}
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x00109A84 File Offset: 0x00107C84
		public void UpdateFavourited()
		{
			if (this.destroyed)
			{
				return;
			}
			if (this == null)
			{
				return;
			}
			if (base.gameObject == null)
			{
				return;
			}
			if (ProductManager.FavouritedProducts.Contains(this.Definition))
			{
				this.FavouriteIcon.color = this.FavouritedColor;
				return;
			}
			this.FavouriteIcon.color = this.UnfavouritedColor;
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x00109AE8 File Offset: 0x00107CE8
		public void UpdateDiscovered(ProductDefinition def)
		{
			if (def == null)
			{
				Console.LogWarning(((def != null) ? def.ToString() : null) + " productDefinition is null", null);
			}
			if (def.ID == this.Definition.ID)
			{
				if (ProductManager.DiscoveredProducts.Contains(this.Definition))
				{
					this.Icon.color = Color.white;
				}
				else
				{
					this.Icon.color = Color.black;
				}
				this.UpdateListed();
			}
		}

		// Token: 0x04002D0D RID: 11533
		public Color SelectedColor;

		// Token: 0x04002D0E RID: 11534
		public Color DeselectedColor;

		// Token: 0x04002D0F RID: 11535
		public Color FavouritedColor;

		// Token: 0x04002D10 RID: 11536
		public Color UnfavouritedColor;

		// Token: 0x04002D11 RID: 11537
		[Header("References")]
		public Button Button;

		// Token: 0x04002D12 RID: 11538
		public Image Frame;

		// Token: 0x04002D13 RID: 11539
		public Image Icon;

		// Token: 0x04002D14 RID: 11540
		public RectTransform Tick;

		// Token: 0x04002D15 RID: 11541
		public RectTransform Cross;

		// Token: 0x04002D16 RID: 11542
		public EventTrigger Trigger;

		// Token: 0x04002D17 RID: 11543
		public Button FavouriteButton;

		// Token: 0x04002D18 RID: 11544
		public Image FavouriteIcon;

		// Token: 0x04002D19 RID: 11545
		public UnityEvent onHovered;

		// Token: 0x04002D1A RID: 11546
		private bool destroyed;
	}
}
