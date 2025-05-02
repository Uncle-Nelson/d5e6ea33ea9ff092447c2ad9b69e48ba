using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000A90 RID: 2704
	public class CounterOfferProductSelector : MonoBehaviour
	{
		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x060048C6 RID: 18630 RVA: 0x001311B7 File Offset: 0x0012F3B7
		// (set) Token: 0x060048C7 RID: 18631 RVA: 0x001311BF File Offset: 0x0012F3BF
		public bool IsOpen { get; private set; }

		// Token: 0x060048C8 RID: 18632 RVA: 0x001311C8 File Offset: 0x0012F3C8
		public void Awake()
		{
			this.SearchBar.onValueChanged.AddListener(new UnityAction<string>(this.SetSearchTerm));
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x001311E6 File Offset: 0x0012F3E6
		public void Open()
		{
			this.IsOpen = true;
			this.Container.gameObject.SetActive(true);
			this.EnsureAllEntriesExist();
			this.SetSearchTerm(string.Empty);
			this.SearchBar.ActivateInputField();
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x0013121C File Offset: 0x0012F41C
		public void Close()
		{
			this.IsOpen = false;
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x00131236 File Offset: 0x0012F436
		private void Update()
		{
			if (!this.IsOpen)
			{
				return;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.Submit) && this.lastPreviewedResult != null)
			{
				this.ProductSelected(this.lastPreviewedResult);
			}
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x00131264 File Offset: 0x0012F464
		public void SetSearchTerm(string search)
		{
			this.searchTerm = search.ToLower();
			this.SearchBar.SetTextWithoutNotify(this.searchTerm);
			this.RebuildResultsList();
			if (search != string.Empty && this.results.Count > 0)
			{
				this.ProductHovered(this.results[0]);
			}
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x001312C4 File Offset: 0x0012F4C4
		private void RebuildResultsList()
		{
			this.results = this.GetMatchingProducts(this.searchTerm);
			this.results.Sort(delegate(ProductDefinition a, ProductDefinition b)
			{
				int num = a.DrugType.CompareTo(b.DrugType);
				if (num != 0)
				{
					return num;
				}
				return a.Name.CompareTo(b.Name);
			});
			Console.Log(string.Format("Found {0} results for {1}", this.results.Count, this.searchTerm), null);
			this.pageCount = Mathf.CeilToInt((float)this.results.Count / 25f);
			this.SetPage(this.pageIndex);
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x0013135C File Offset: 0x0012F55C
		private List<ProductDefinition> GetMatchingProducts(string searchTerm)
		{
			List<ProductDefinition> list = new List<ProductDefinition>();
			List<EDrugType> list2 = new List<EDrugType>();
			foreach (object obj in Enum.GetValues(typeof(EDrugType)))
			{
				EDrugType item = (EDrugType)obj;
				if (searchTerm.ToLower().Contains(item.ToString().ToLower()))
				{
					list2.Add(item);
				}
			}
			if (searchTerm.ToLower().Contains("weed"))
			{
				list2.Add(EDrugType.Marijuana);
			}
			if (searchTerm.ToLower().Contains("coke"))
			{
				list2.Add(EDrugType.Cocaine);
			}
			if (searchTerm.ToLower().Contains("meth"))
			{
				list2.Add(EDrugType.Methamphetamine);
			}
			foreach (ProductDefinition productDefinition in ProductManager.DiscoveredProducts)
			{
				if (list2.Contains(productDefinition.DrugType))
				{
					list.Add(productDefinition);
				}
				else if (productDefinition.Name.ToLower().Contains(searchTerm))
				{
					list.Add(productDefinition);
				}
			}
			return list;
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x001314AC File Offset: 0x0012F6AC
		private void EnsureAllEntriesExist()
		{
			foreach (ProductDefinition productDefinition in ProductManager.DiscoveredProducts)
			{
				if (!this.productEntriesDict.ContainsKey(productDefinition))
				{
					this.CreateProductEntry(productDefinition);
				}
			}
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x0013150C File Offset: 0x0012F70C
		private void CreateProductEntry(ProductDefinition product)
		{
			if (this.productEntriesDict.ContainsKey(product))
			{
				return;
			}
			RectTransform component = Object.Instantiate<GameObject>(this.ProductEntryPrefab, this.ProductContainer).GetComponent<RectTransform>();
			component.Find("Icon").GetComponent<Image>().sprite = product.Icon;
			component.GetComponent<Button>().onClick.AddListener(new UnityAction(delegate()
			{
				this.ProductSelected(product);
			}));
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = 0;
			entry.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
			{
				this.ProductHovered(product);
			}));
			component.gameObject.AddComponent<EventTrigger>().triggers.Add(entry);
			this.productEntries.Add(component);
			this.productEntriesDict.Add(product, component);
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x001315EC File Offset: 0x0012F7EC
		public void ChangePage(int change)
		{
			this.SetPage(this.pageIndex + change);
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x001315FC File Offset: 0x0012F7FC
		private void SetPage(int page)
		{
			this.pageIndex = Mathf.Clamp(page, 0, Mathf.Max(this.pageCount - 1, 0));
			int num = this.pageIndex * 25;
			int num2 = Mathf.Min(num + 25, this.results.Count);
			Console.Log(string.Format("Page {0} / {1} ({2} - {3})", new object[]
			{
				this.pageIndex + 1,
				this.pageCount,
				num,
				num2
			}), null);
			List<ProductDefinition> range = this.results.GetRange(num, num2 - num);
			List<ProductDefinition> list = this.productEntriesDict.Keys.ToList<ProductDefinition>();
			for (int i = 0; i < list.Count; i++)
			{
				RectTransform rectTransform = this.productEntriesDict[list[i]];
				if (range.Contains(list[i]))
				{
					rectTransform.gameObject.SetActive(true);
				}
				else
				{
					rectTransform.gameObject.SetActive(false);
				}
			}
			for (int j = 0; j < range.Count; j++)
			{
				this.productEntriesDict[range[j]].SetSiblingIndex(j);
			}
			this.PageLabel.text = string.Format("{0} / {1}", this.pageIndex + 1, this.pageCount);
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x0013175C File Offset: 0x0012F95C
		private void ProductHovered(ProductDefinition def)
		{
			if (this.onProductPreviewed != null)
			{
				this.onProductPreviewed(def);
			}
			this.lastPreviewedResult = def;
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x00131779 File Offset: 0x0012F979
		private void ProductSelected(ProductDefinition def)
		{
			if (this.onProductSelected != null)
			{
				this.onProductSelected(def);
			}
			this.Close();
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x00131798 File Offset: 0x0012F998
		public bool IsMouseOverSelector()
		{
			bool flag = RectTransformUtility.RectangleContainsScreenPoint(this.Container, GameInput.MousePosition, PlayerSingleton<PlayerCamera>.Instance.OverlayCamera);
			Console.Log(string.Format("Mouse over selector: {0}", flag), null);
			return flag;
		}

		// Token: 0x040035DF RID: 13791
		public const int ENTRIES_PER_PAGE = 25;

		// Token: 0x040035E0 RID: 13792
		public RectTransform Container;

		// Token: 0x040035E1 RID: 13793
		public InputField SearchBar;

		// Token: 0x040035E2 RID: 13794
		public RectTransform ProductContainer;

		// Token: 0x040035E3 RID: 13795
		public Text PageLabel;

		// Token: 0x040035E4 RID: 13796
		public GameObject ProductEntryPrefab;

		// Token: 0x040035E6 RID: 13798
		public Action<ProductDefinition> onProductPreviewed;

		// Token: 0x040035E7 RID: 13799
		public Action<ProductDefinition> onProductSelected;

		// Token: 0x040035E8 RID: 13800
		private List<RectTransform> productEntries = new List<RectTransform>();

		// Token: 0x040035E9 RID: 13801
		private Dictionary<ProductDefinition, RectTransform> productEntriesDict = new Dictionary<ProductDefinition, RectTransform>();

		// Token: 0x040035EA RID: 13802
		private string searchTerm = string.Empty;

		// Token: 0x040035EB RID: 13803
		private int pageIndex;

		// Token: 0x040035EC RID: 13804
		private int pageCount;

		// Token: 0x040035ED RID: 13805
		private List<ProductDefinition> results = new List<ProductDefinition>();

		// Token: 0x040035EE RID: 13806
		private ProductDefinition lastPreviewedResult;
	}
}
