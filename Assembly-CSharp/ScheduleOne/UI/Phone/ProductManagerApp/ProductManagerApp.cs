using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.Product;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.ProductManagerApp
{
	// Token: 0x02000AA8 RID: 2728
	public class ProductManagerApp : App<ProductManagerApp>
	{
		// Token: 0x06004977 RID: 18807 RVA: 0x00133F47 File Offset: 0x00132147
		protected override void Awake()
		{
			base.Awake();
			this.DetailPanel.SetActiveProduct(null);
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x00133F5C File Offset: 0x0013215C
		protected override void Start()
		{
			base.Start();
			ProductManager instance = NetworkSingleton<ProductManager>.Instance;
			instance.onProductDiscovered = (Action<ProductDefinition>)Delegate.Combine(instance.onProductDiscovered, new Action<ProductDefinition>(this.CreateEntry));
			ProductManager instance2 = NetworkSingleton<ProductManager>.Instance;
			instance2.onProductFavourited = (Action<ProductDefinition>)Delegate.Combine(instance2.onProductFavourited, new Action<ProductDefinition>(this.ProductFavourited));
			ProductManager instance3 = NetworkSingleton<ProductManager>.Instance;
			instance3.onProductUnfavourited = (Action<ProductDefinition>)Delegate.Combine(instance3.onProductUnfavourited, new Action<ProductDefinition>(this.ProductUnfavourited));
			foreach (ProductDefinition definition in ProductManager.FavouritedProducts)
			{
				this.CreateFavouriteEntry(definition);
			}
			foreach (ProductDefinition definition2 in ProductManager.DiscoveredProducts)
			{
				this.CreateEntry(definition2);
			}
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x00134068 File Offset: 0x00132268
		private void LateUpdate()
		{
			if (!base.isOpen)
			{
				return;
			}
			if (this.selectedEntry != null)
			{
				this.SelectionIndicator.position = this.selectedEntry.transform.position;
			}
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x0013409C File Offset: 0x0013229C
		public virtual void CreateEntry(ProductDefinition definition)
		{
			ProductManagerApp.ProductTypeContainer productTypeContainer = this.ProductTypeContainers.Find((ProductManagerApp.ProductTypeContainer x) => x.DrugType == definition.DrugTypes[0].DrugType);
			ProductEntry component = Object.Instantiate<GameObject>(this.EntryPrefab, productTypeContainer.Container).GetComponent<ProductEntry>();
			component.Initialize(definition);
			this.entries.Add(component);
			productTypeContainer.RefreshNoneDisplay();
			LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x0013410E File Offset: 0x0013230E
		private void ProductFavourited(ProductDefinition product)
		{
			this.CreateFavouriteEntry(product);
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x00134117 File Offset: 0x00132317
		private void ProductUnfavourited(ProductDefinition product)
		{
			this.RemoveFavouriteEntry(product);
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x00134120 File Offset: 0x00132320
		private void CreateFavouriteEntry(ProductDefinition definition)
		{
			if (this.favouriteEntries.Find((ProductEntry x) => x.Definition == definition) != null)
			{
				return;
			}
			ProductEntry component = Object.Instantiate<GameObject>(this.EntryPrefab, this.FavouritesContainer.Container).GetComponent<ProductEntry>();
			component.Initialize(definition);
			this.favouriteEntries.Add(component);
			this.FavouritesContainer.RefreshNoneDisplay();
			this.DelayedRebuildLayout();
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x001341A0 File Offset: 0x001323A0
		private void RemoveFavouriteEntry(ProductDefinition definition)
		{
			ProductEntry productEntry = this.favouriteEntries.Find((ProductEntry x) => x.Definition == definition);
			if (this.selectedEntry == productEntry)
			{
				this.selectedEntry = null;
				this.SelectionIndicator.gameObject.SetActive(false);
				this.DetailPanel.SetActiveProduct(null);
			}
			if (productEntry != null)
			{
				this.favouriteEntries.Remove(productEntry);
				productEntry.Destroy();
			}
			this.FavouritesContainer.RefreshNoneDisplay();
			this.DelayedRebuildLayout();
		}

		// Token: 0x0600497F RID: 18815 RVA: 0x00134231 File Offset: 0x00132431
		private void DelayedRebuildLayout()
		{
			base.StartCoroutine(this.<DelayedRebuildLayout>g__Delay|17_0());
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x00134240 File Offset: 0x00132440
		public void SelectProduct(ProductEntry entry)
		{
			this.selectedEntry = entry;
			this.DetailPanel.SetActiveProduct(entry.Definition);
			this.SelectionIndicator.position = entry.transform.position;
			this.SelectionIndicator.gameObject.SetActive(true);
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x0013428C File Offset: 0x0013248C
		public override void SetOpen(bool open)
		{
			ProductManagerApp.<>c__DisplayClass19_0 CS$<>8__locals1 = new ProductManagerApp.<>c__DisplayClass19_0();
			CS$<>8__locals1.<>4__this = this;
			base.SetOpen(open);
			if (open)
			{
				for (int i = 0; i < this.entries.Count; i++)
				{
					this.entries[i].UpdateDiscovered(this.entries[i].Definition);
					this.entries[i].UpdateListed();
				}
				for (int j = 0; j < this.favouriteEntries.Count; j++)
				{
					this.favouriteEntries[j].UpdateDiscovered(this.favouriteEntries[j].Definition);
					this.favouriteEntries[j].UpdateListed();
				}
				LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
				base.gameObject.SetActive(false);
				base.gameObject.SetActive(true);
				CS$<>8__locals1.layoutGroups = base.GetComponentsInChildren<VerticalLayoutGroup>();
				for (int k = 0; k < CS$<>8__locals1.layoutGroups.Length; k++)
				{
					CS$<>8__locals1.layoutGroups[k].enabled = false;
					CS$<>8__locals1.layoutGroups[k].enabled = true;
				}
				if (this.selectedEntry != null)
				{
					this.DetailPanel.SetActiveProduct(this.selectedEntry.Definition);
				}
				base.StartCoroutine(CS$<>8__locals1.<SetOpen>g__Delay|0());
			}
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x001343F2 File Offset: 0x001325F2
		[CompilerGenerated]
		private IEnumerator <DelayedRebuildLayout>g__Delay|17_0()
		{
			LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
			yield return new WaitForEndOfFrame();
			LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
			ContentSizeFitter[] componentsInChildren = base.GetComponentsInChildren<ContentSizeFitter>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].enabled = false;
				componentsInChildren[i].enabled = true;
			}
			yield break;
		}

		// Token: 0x0400369A RID: 13978
		[Header("References")]
		public ProductManagerApp.ProductTypeContainer FavouritesContainer;

		// Token: 0x0400369B RID: 13979
		public List<ProductManagerApp.ProductTypeContainer> ProductTypeContainers;

		// Token: 0x0400369C RID: 13980
		public ProductAppDetailPanel DetailPanel;

		// Token: 0x0400369D RID: 13981
		public RectTransform SelectionIndicator;

		// Token: 0x0400369E RID: 13982
		public GameObject EntryPrefab;

		// Token: 0x0400369F RID: 13983
		private List<ProductEntry> favouriteEntries = new List<ProductEntry>();

		// Token: 0x040036A0 RID: 13984
		private List<ProductEntry> entries = new List<ProductEntry>();

		// Token: 0x040036A1 RID: 13985
		private ProductEntry selectedEntry;

		// Token: 0x02000AA9 RID: 2729
		[Serializable]
		public class ProductTypeContainer
		{
			// Token: 0x06004984 RID: 18820 RVA: 0x00134401 File Offset: 0x00132601
			public void RefreshNoneDisplay()
			{
				this.NoneDisplay.gameObject.SetActive(this.Container.childCount == 0);
			}

			// Token: 0x040036A2 RID: 13986
			public EDrugType DrugType;

			// Token: 0x040036A3 RID: 13987
			public RectTransform Container;

			// Token: 0x040036A4 RID: 13988
			public RectTransform NoneDisplay;
		}
	}
}
