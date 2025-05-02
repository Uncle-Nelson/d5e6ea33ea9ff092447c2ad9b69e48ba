using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using UnityEngine;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000B69 RID: 2921
	[Serializable]
	public class ShopListing
	{
		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06004DD7 RID: 19927 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool IsInStock
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06004DD8 RID: 19928 RVA: 0x00147EF8 File Offset: 0x001460F8
		public float Price
		{
			get
			{
				if (!this.OverridePrice)
				{
					return this.Item.BasePurchasePrice;
				}
				return this.OverriddenPrice;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06004DD9 RID: 19929 RVA: 0x00147F14 File Offset: 0x00146114
		public bool IsUnlimitedStock
		{
			get
			{
				return !this.LimitedStock;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06004DDA RID: 19930 RVA: 0x00147F1F File Offset: 0x0014611F
		// (set) Token: 0x06004DDB RID: 19931 RVA: 0x00147F27 File Offset: 0x00146127
		public ShopInterface Shop { get; private set; }

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06004DDC RID: 19932 RVA: 0x00147F30 File Offset: 0x00146130
		// (set) Token: 0x06004DDD RID: 19933 RVA: 0x00147F38 File Offset: 0x00146138
		public int CurrentStock { get; protected set; }

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06004DDE RID: 19934 RVA: 0x00147F41 File Offset: 0x00146141
		// (set) Token: 0x06004DDF RID: 19935 RVA: 0x00147F49 File Offset: 0x00146149
		public int QuantityInCart { get; private set; }

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06004DE0 RID: 19936 RVA: 0x00147F52 File Offset: 0x00146152
		public int CurrentStockMinusCart
		{
			get
			{
				return this.CurrentStock - this.QuantityInCart;
			}
		}

		// Token: 0x06004DE1 RID: 19937 RVA: 0x00147F61 File Offset: 0x00146161
		public void Initialize(ShopInterface shop)
		{
			this.Shop = shop;
		}

		// Token: 0x06004DE2 RID: 19938 RVA: 0x00147F6A File Offset: 0x0014616A
		public void Restock(bool network)
		{
			this.SetStock(this.DefaultStock, true);
		}

		// Token: 0x06004DE3 RID: 19939 RVA: 0x00147F79 File Offset: 0x00146179
		public void RemoveStock(int quantity)
		{
			this.SetStock(this.CurrentStock - quantity, true);
		}

		// Token: 0x06004DE4 RID: 19940 RVA: 0x00147F8C File Offset: 0x0014618C
		public void SetStock(int quantity, bool network = true)
		{
			if (this.IsUnlimitedStock)
			{
				return;
			}
			if (network && NetworkSingleton<ShopManager>.InstanceExists && this.Shop != null)
			{
				NetworkSingleton<ShopManager>.Instance.SendStock(this.Shop.ShopCode, this.Item.ID, quantity);
			}
			Console.Log("Setting stock for " + this.Item.Name + " to " + quantity.ToString(), null);
			this.CurrentStock = quantity;
			if (this.CurrentStock < 0)
			{
				this.CurrentStock = 0;
			}
			if (this.onStockChanged != null)
			{
				this.onStockChanged();
			}
		}

		// Token: 0x06004DE5 RID: 19941 RVA: 0x0014802C File Offset: 0x0014622C
		public virtual bool ShouldShow()
		{
			return !this.EnforceMinimumGameCreationVersion || SaveManager.GetVersionNumber(Singleton<MetadataManager>.Instance.CreationVersion) >= this.MinimumGameCreationVersion;
		}

		// Token: 0x06004DE6 RID: 19942 RVA: 0x00148050 File Offset: 0x00146250
		public virtual bool DoesListingMatchCategoryFilter(EShopCategory category)
		{
			return category == EShopCategory.All || this.Item.ShopCategories.Find((ShopListing.CategoryInstance x) => x.Category == category) != null;
		}

		// Token: 0x06004DE7 RID: 19943 RVA: 0x00148093 File Offset: 0x00146293
		public virtual bool DoesListingMatchSearchTerm(string searchTerm)
		{
			return this.Item.Name.ToLower().Contains(searchTerm.ToLower());
		}

		// Token: 0x06004DE8 RID: 19944 RVA: 0x001480B0 File Offset: 0x001462B0
		public void SetQuantityInCart(int quantity)
		{
			this.QuantityInCart = quantity;
			if (this.onStockChanged != null)
			{
				this.onStockChanged();
			}
		}

		// Token: 0x04003AAC RID: 15020
		public string name;

		// Token: 0x04003AAD RID: 15021
		public StorableItemDefinition Item;

		// Token: 0x04003AAE RID: 15022
		[Header("Pricing")]
		[SerializeField]
		protected bool OverridePrice;

		// Token: 0x04003AAF RID: 15023
		[SerializeField]
		protected float OverriddenPrice = 10f;

		// Token: 0x04003AB0 RID: 15024
		[Header("Stock")]
		public bool LimitedStock;

		// Token: 0x04003AB1 RID: 15025
		public int DefaultStock = -1;

		// Token: 0x04003AB2 RID: 15026
		public ShopListing.ERestockRate RestockRate;

		// Token: 0x04003AB3 RID: 15027
		[Header("Settings")]
		public bool EnforceMinimumGameCreationVersion;

		// Token: 0x04003AB4 RID: 15028
		public float MinimumGameCreationVersion = 27f;

		// Token: 0x04003AB5 RID: 15029
		public bool CanBeDelivered;

		// Token: 0x04003AB6 RID: 15030
		[Header("Color")]
		public bool UseIconTint;

		// Token: 0x04003AB7 RID: 15031
		public Color IconTint = Color.white;

		// Token: 0x04003ABB RID: 15035
		public Action onStockChanged;

		// Token: 0x02000B6A RID: 2922
		[Serializable]
		public class CategoryInstance
		{
			// Token: 0x04003ABC RID: 15036
			public EShopCategory Category;
		}

		// Token: 0x02000B6B RID: 2923
		public enum ERestockRate
		{
			// Token: 0x04003ABE RID: 15038
			Daily,
			// Token: 0x04003ABF RID: 15039
			Weekly,
			// Token: 0x04003AC0 RID: 15040
			Never
		}
	}
}
