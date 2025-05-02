using System;
using System.Collections.Generic;
using System.Linq;
using EasyButtons;
using FishNet;
using ScheduleOne.Audio;
using ScheduleOne.Delivery;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Levelling;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Storage;
using ScheduleOne.Variables;
using ScheduleOne.Vehicles;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000B5E RID: 2910
	public class ShopInterface : MonoBehaviour, ISaveable
	{
		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06004D7F RID: 19839 RVA: 0x0014683B File Offset: 0x00144A3B
		// (set) Token: 0x06004D80 RID: 19840 RVA: 0x00146843 File Offset: 0x00144A43
		public bool IsOpen { get; protected set; }

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06004D81 RID: 19841 RVA: 0x0014684C File Offset: 0x00144A4C
		public string SaveFolderName
		{
			get
			{
				return SaveManager.MakeFileSafe(this.ShopCode);
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06004D82 RID: 19842 RVA: 0x0014684C File Offset: 0x00144A4C
		public string SaveFileName
		{
			get
			{
				return SaveManager.MakeFileSafe(this.ShopCode);
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06004D83 RID: 19843 RVA: 0x00146859 File Offset: 0x00144A59
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06004D84 RID: 19844 RVA: 0x000141BA File Offset: 0x000123BA
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06004D85 RID: 19845 RVA: 0x00146861 File Offset: 0x00144A61
		// (set) Token: 0x06004D86 RID: 19846 RVA: 0x00146869 File Offset: 0x00144A69
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06004D87 RID: 19847 RVA: 0x00146872 File Offset: 0x00144A72
		// (set) Token: 0x06004D88 RID: 19848 RVA: 0x0014687A File Offset: 0x00144A7A
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06004D89 RID: 19849 RVA: 0x00146883 File Offset: 0x00144A83
		// (set) Token: 0x06004D8A RID: 19850 RVA: 0x0014688B File Offset: 0x00144A8B
		public bool HasChanged { get; set; } = true;

		// Token: 0x06004D8B RID: 19851 RVA: 0x00146894 File Offset: 0x00144A94
		protected virtual void Awake()
		{
			foreach (ShopListing listing in this.Listings)
			{
				this.CreateListingUI(listing);
			}
			this.ListingScrollRect.verticalNormalizedPosition = 1f;
			this.Listings = (from x in this.Listings
			orderby x.Item.Name
			select x).ToList<ShopListing>();
			this.categoryButtons = base.GetComponentsInChildren<CategoryButton>().ToList<CategoryButton>();
			this.StoreNameLabel.text = this.ShopName;
			this.ListingContainer.anchoredPosition = Vector2.zero;
			this.AmountSelector.onSubmitted.AddListener(new UnityAction<int>(this.QuantitySelected));
			ShopInterface.AllShops.Add(this);
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x00146988 File Offset: 0x00144B88
		protected virtual void Start()
		{
			this.RefreshShownItems();
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 7);
			this.RestockAllListings();
			foreach (ShopListing shopListing in this.Listings)
			{
				shopListing.Initialize(this);
				if (shopListing.Item.RequiresLevelToPurchase)
				{
					NetworkSingleton<LevelManager>.Instance.AddUnlockable(new Unlockable(shopListing.Item.RequiredRank, shopListing.Item.Name, shopListing.Item.Icon));
				}
			}
			this.IsOpen = false;
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			NetworkSingleton<TimeManager>.Instance._onSleepStart.RemoveListener(new UnityAction(this.OnDayPass));
			NetworkSingleton<TimeManager>.Instance._onSleepStart.AddListener(new UnityAction(this.OnDayPass));
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onWeekPass = (Action)Delegate.Remove(instance.onWeekPass, new Action(this.OnWeekPass));
			TimeManager instance2 = NetworkSingleton<TimeManager>.Instance;
			instance2.onWeekPass = (Action)Delegate.Combine(instance2.onWeekPass, new Action(this.OnWeekPass));
			this.InitializeSaveable();
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x00146AE4 File Offset: 0x00144CE4
		private void OnDestroy()
		{
			ShopInterface.AllShops.Remove(this);
		}

		// Token: 0x06004D8F RID: 19855 RVA: 0x00146AF4 File Offset: 0x00144CF4
		private void OnValidate()
		{
			this.StoreNameLabel.text = this.ShopName;
			for (int i = 0; i < this.Listings.Count; i++)
			{
				if (!(this.Listings[i].Item == null))
				{
					string text = "(";
					for (int j = 0; j < this.Listings[i].Item.ShopCategories.Count; j++)
					{
						text = text + this.Listings[i].Item.ShopCategories[j].Category.ToString() + ", ";
					}
					text += ")";
					this.Listings[i].name = string.Concat(new string[]
					{
						this.Listings[i].Item.Name,
						" ($",
						this.Listings[i].Price.ToString(),
						") ",
						text
					});
					if (this.Listings[i].Item.RequiresLevelToPurchase)
					{
						ShopListing shopListing = this.Listings[i];
						string name = shopListing.name;
						string str = " [Rank ";
						FullRank requiredRank = this.Listings[i].Item.RequiredRank;
						shopListing.name = name + str + requiredRank.ToString() + "]";
					}
				}
			}
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x00146C82 File Offset: 0x00144E82
		protected virtual void Update()
		{
			if (this.IsOpen && Input.GetMouseButtonUp(0))
			{
				if (this.dropdownMouseUp)
				{
					this.AmountSelector.Close();
					this.selectedListing = null;
					return;
				}
				this.dropdownMouseUp = true;
			}
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x00146CB8 File Offset: 0x00144EB8
		protected void OnDayPass()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			for (int i = 0; i < this.Listings.Count; i++)
			{
				if (!this.Listings[i].IsUnlimitedStock && this.Listings[i].RestockRate == ShopListing.ERestockRate.Daily)
				{
					this.Listings[i].Restock(true);
				}
			}
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x00146D1C File Offset: 0x00144F1C
		protected void OnWeekPass()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			for (int i = 0; i < this.Listings.Count; i++)
			{
				if (!this.Listings[i].IsUnlimitedStock && this.Listings[i].RestockRate == ShopListing.ERestockRate.Weekly)
				{
					this.Listings[i].Restock(true);
				}
			}
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x00146D80 File Offset: 0x00144F80
		[Button]
		public void Open()
		{
			this.SetIsOpen(true);
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x00146D8C File Offset: 0x00144F8C
		public virtual void SetIsOpen(bool isOpen)
		{
			this.IsOpen = isOpen;
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(this.ShopName);
			if (isOpen)
			{
				PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(this.ShopName);
				PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
				PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
				PlayerSingleton<PlayerMovement>.Instance.canMove = false;
				PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
				PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
				this.SelectCategory(EShopCategory.All);
				this.RefreshShownItems();
				this.ListingScrollRect.verticalNormalizedPosition = 1f;
				this.ListingScrollRect.content.anchoredPosition = Vector2.zero;
				this.RefreshUnlockStatus();
				Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
				if (this.ShowCurrencyHint)
				{
					this.ShowCurrencyHint = false;
					Singleton<HintDisplay>.Instance.ShowHint("Your <h1>online balance</h> is displayed in the top right corner.", 10f);
					base.Invoke("Hint", 10.5f);
				}
			}
			else
			{
				PlayerSingleton<PlayerCamera>.Instance.LockMouse();
				PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
				PlayerSingleton<PlayerMovement>.Instance.canMove = true;
				PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
				Singleton<InputPromptsCanvas>.Instance.UnloadModule();
				this.DetailPanel.Close();
				this.AmountSelector.Close();
			}
			this.Canvas.enabled = isOpen;
			this.Container.gameObject.SetActive(isOpen);
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x00146EE0 File Offset: 0x001450E0
		private void Hint()
		{
			Singleton<HintDisplay>.Instance.ShowHint("Most legal shops will only accept <h1>card payments</h>, while most illegal shops only take cash. Visit an <h1>ATM</h> to deposit and withdraw cash.", 20f);
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x00146EF6 File Offset: 0x001450F6
		protected virtual void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (this.IsOpen)
			{
				action.used = true;
				this.SetIsOpen(false);
			}
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x00146F18 File Offset: 0x00145118
		private void CreateListingUI(ShopListing listing)
		{
			ListingUI component = Object.Instantiate<GameObject>(this.ListingUIPrefab.gameObject, this.ListingContainer).GetComponent<ListingUI>();
			component.Initialize(listing);
			ListingUI ui = component;
			ListingUI listingUI = component;
			listingUI.onClicked = (Action)Delegate.Combine(listingUI.onClicked, new Action(delegate()
			{
				this.ListingClicked(ui);
			}));
			ListingUI listingUI2 = component;
			listingUI2.onDropdownClicked = (Action)Delegate.Combine(listingUI2.onDropdownClicked, new Action(delegate()
			{
				this.DropdownClicked(ui);
			}));
			ListingUI listingUI3 = component;
			listingUI3.hoverStart = (Action)Delegate.Combine(listingUI3.hoverStart, new Action(delegate()
			{
				this.EntryHovered(ui);
			}));
			ListingUI listingUI4 = component;
			listingUI4.hoverEnd = (Action)Delegate.Combine(listingUI4.hoverEnd, new Action(this.EntryUnhovered));
			this.listingUI.Add(component);
		}

		// Token: 0x06004D98 RID: 19864 RVA: 0x00146FF0 File Offset: 0x001451F0
		public void SelectCategory(EShopCategory category)
		{
			CategoryButton categoryButton = this.categoryButtons.Find((CategoryButton x) => x.Category == category);
			if (categoryButton == null)
			{
				Console.LogWarning("Category button not found: " + category.ToString(), null);
				return;
			}
			categoryButton.Select();
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x00147054 File Offset: 0x00145254
		public virtual void ListingClicked(ListingUI listingUI)
		{
			if (!listingUI.Listing.Item.IsPurchasable)
			{
				return;
			}
			if (!listingUI.CanAddToCart())
			{
				return;
			}
			int quantity = 1;
			if (this.AmountSelector.IsOpen)
			{
				quantity = this.AmountSelector.SelectedAmount;
			}
			this.Cart.AddItem(listingUI.Listing, quantity);
			this.AddItemSound.Play();
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x001470B8 File Offset: 0x001452B8
		private void ShowCartAnimation(ListingUI listing)
		{
			ShopInterface.<>c__DisplayClass70_0 CS$<>8__locals1 = new ShopInterface.<>c__DisplayClass70_0();
			CS$<>8__locals1.listing = listing;
			CS$<>8__locals1.<>4__this = this;
			base.StartCoroutine(CS$<>8__locals1.<ShowCartAnimation>g__Routine|0());
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x001470E6 File Offset: 0x001452E6
		public void CategorySelected(EShopCategory category)
		{
			if (category == this.categoryFilter)
			{
				return;
			}
			this.DeselectCurrentCategory();
			this.categoryFilter = category;
			this.RefreshShownItems();
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x00147105 File Offset: 0x00145305
		private void DeselectCurrentCategory()
		{
			this.categoryButtons.Find((CategoryButton x) => x.Category == this.categoryFilter).Deselect();
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x00147124 File Offset: 0x00145324
		private void RefreshShownItems()
		{
			for (int i = 0; i < this.listingUI.Count; i++)
			{
				if (this.searchTerm != string.Empty)
				{
					this.listingUI[i].gameObject.SetActive(this.listingUI[i].Listing.DoesListingMatchSearchTerm(this.searchTerm));
				}
				else
				{
					this.listingUI[i].gameObject.SetActive(this.listingUI[i].Listing.DoesListingMatchCategoryFilter(this.categoryFilter) && this.listingUI[i].Listing.ShouldShow());
				}
			}
			for (int j = 0; j < this.listingUI.Count; j++)
			{
				this.listingUI[j].transform.SetSiblingIndex(j);
			}
			List<ListingUI> list = this.listingUI.FindAll((ListingUI x) => !x.Listing.Item.IsPurchasable);
			list.Sort((ListingUI x, ListingUI y) => x.Listing.Item.RequiredRank.CompareTo(y.Listing.Item.RequiredRank));
			for (int k = 0; k < list.Count; k++)
			{
				list[k].transform.SetAsLastSibling();
			}
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x00147280 File Offset: 0x00145480
		private void RefreshUnlockStatus()
		{
			for (int i = 0; i < this.listingUI.Count; i++)
			{
				this.listingUI[i].UpdateLockStatus();
			}
		}

		// Token: 0x06004D9F RID: 19871 RVA: 0x001472B4 File Offset: 0x001454B4
		private void RestockAllListings()
		{
			foreach (ShopListing shopListing in this.Listings)
			{
				shopListing.Restock(false);
			}
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool CanCartFitItem(ShopListing listing)
		{
			return true;
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x00147308 File Offset: 0x00145508
		public bool WillCartFit()
		{
			List<ItemSlot> availableSlots = this.GetAvailableSlots();
			return this.WillCartFit(availableSlots);
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x00147324 File Offset: 0x00145524
		public bool WillCartFit(List<ItemSlot> availableSlots)
		{
			List<ShopListing> list = this.Cart.cartDictionary.Keys.ToList<ShopListing>();
			List<ItemSlot> list2 = new List<ItemSlot>();
			for (int i = 0; i < list.Count; i++)
			{
				int num = this.Cart.cartDictionary[list[i]];
				ItemInstance defaultInstance = list[i].Item.GetDefaultInstance(1);
				int num2 = 0;
				while (num2 < availableSlots.Count && num > 0)
				{
					if (!list2.Contains(availableSlots[num2]))
					{
						int capacityForItem = availableSlots[num2].GetCapacityForItem(defaultInstance);
						if (capacityForItem > 0)
						{
							list2.Add(availableSlots[num2]);
							num -= Mathf.Min(num, capacityForItem);
						}
					}
					num2++;
				}
				if (num > 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x001473F0 File Offset: 0x001455F0
		public virtual bool HandoverItems()
		{
			List<ItemSlot> availableSlots = this.GetAvailableSlots();
			List<ShopListing> list = this.Cart.cartDictionary.Keys.ToList<ShopListing>();
			bool result = true;
			for (int i = 0; i < list.Count; i++)
			{
				NetworkSingleton<VariableDatabase>.Instance.NotifyItemAcquired(list[i].Item.ID, this.Cart.cartDictionary[list[i]]);
				int num = this.Cart.cartDictionary[list[i]];
				ItemInstance defaultInstance = list[i].Item.GetDefaultInstance(1);
				int num2 = 0;
				while (num2 < availableSlots.Count && num > 0)
				{
					int capacityForItem = availableSlots[num2].GetCapacityForItem(defaultInstance);
					if (capacityForItem != 0)
					{
						int num3 = Mathf.Min(capacityForItem, num);
						availableSlots[num2].AddItem(defaultInstance.GetCopy(num3), false);
						num -= num3;
					}
					num2++;
				}
				if (num > 0)
				{
					Debug.LogWarning("Failed to handover all items in cart: " + defaultInstance.Name);
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06004DA4 RID: 19876 RVA: 0x00147508 File Offset: 0x00145708
		public List<ItemSlot> GetAvailableSlots()
		{
			List<ItemSlot> list = new List<ItemSlot>();
			LandVehicle loadingBayVehicle = this.GetLoadingBayVehicle();
			if (loadingBayVehicle != null && this.Cart.LoadVehicleToggle.isOn)
			{
				list.AddRange(loadingBayVehicle.Storage.ItemSlots);
			}
			else
			{
				list.AddRange(PlayerSingleton<PlayerInventory>.Instance.hotbarSlots);
			}
			for (int i = 0; i < this.DeliveryBays.Length; i++)
			{
				list.AddRange(this.DeliveryBays[i].ItemSlots);
			}
			return list;
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x00147588 File Offset: 0x00145788
		public LandVehicle GetLoadingBayVehicle()
		{
			if (this.LoadingBayDetector != null && this.LoadingBayDetector.closestVehicle != null && this.LoadingBayDetector.closestVehicle.IsPlayerOwned)
			{
				return this.LoadingBayDetector.closestVehicle;
			}
			return null;
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x001475D8 File Offset: 0x001457D8
		public void PlaceItemInDeliveryBay(ItemInstance item)
		{
			int num = item.Quantity;
			foreach (StorageEntity storageEntity in this.DeliveryBays)
			{
				int num2 = storageEntity.HowManyCanFit(item);
				if (num2 > 0)
				{
					ItemInstance copy = item.GetCopy(Mathf.Min(num, num2));
					storageEntity.InsertItem(copy, true);
					num -= copy.Quantity;
				}
				if (num <= 0)
				{
					break;
				}
			}
			if (num > 0)
			{
				Console.LogWarning("Could not fit all items in delivery bay!", null);
			}
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x0014764C File Offset: 0x0014584C
		public void QuantitySelected(int amount)
		{
			if (this.selectedListing == null)
			{
				return;
			}
			if (!this.selectedListing.Listing.Item.IsPurchasable)
			{
				return;
			}
			int quantity = Mathf.Clamp(amount, 1, this.selectedListing.Listing.IsUnlimitedStock ? 100000000 : this.selectedListing.Listing.CurrentStockMinusCart);
			this.Cart.AddItem(this.selectedListing.Listing, quantity);
			this.AddItemSound.Play();
			this.AmountSelector.Close();
			this.selectedListing = null;
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x001476E8 File Offset: 0x001458E8
		public void OpenAmountSelector(ListingUI listing)
		{
			if (!listing.Listing.Item.IsPurchasable)
			{
				return;
			}
			if (!listing.CanAddToCart())
			{
				return;
			}
			this.selectedListing = listing;
			this.AmountSelector.transform.position = listing.TopDropdownAnchor.position;
			this.dropdownMouseUp = false;
			this.AmountSelector.Open();
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x00147745 File Offset: 0x00145945
		private void DropdownClicked(ListingUI listing)
		{
			if (this.selectedListing == listing)
			{
				this.AmountSelector.Close();
				this.selectedListing = null;
				return;
			}
			this.OpenAmountSelector(listing);
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x0014776F File Offset: 0x0014596F
		private void EntryHovered(ListingUI listing)
		{
			this.DetailPanel.Open(listing);
		}

		// Token: 0x06004DAB RID: 19883 RVA: 0x0014777D File Offset: 0x0014597D
		private void EntryUnhovered()
		{
			this.DetailPanel.Close();
		}

		// Token: 0x06004DAC RID: 19884 RVA: 0x0014778C File Offset: 0x0014598C
		public void Load(ShopData data)
		{
			Console.Log("Loading shop data: " + data.ShopCode, null);
			StringIntPair[] itemStockQuantities = data.ItemStockQuantities;
			for (int i = 0; i < itemStockQuantities.Length; i++)
			{
				StringIntPair stockQuantity = itemStockQuantities[i];
				ShopListing shopListing = this.Listings.Find((ShopListing x) => x.Item.ID == stockQuantity.String);
				if (shopListing == null)
				{
					Console.LogWarning("Failed to load shop data: Listing not found: " + stockQuantity.String, null);
				}
				else
				{
					shopListing.SetStock(stockQuantity.Int, true);
				}
			}
		}

		// Token: 0x06004DAD RID: 19885 RVA: 0x00147820 File Offset: 0x00145A20
		public bool ShouldSave()
		{
			new List<StringIntPair>();
			foreach (ShopListing shopListing in this.Listings)
			{
				if (!shopListing.IsUnlimitedStock && shopListing.CurrentStock != shopListing.DefaultStock)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004DAE RID: 19886 RVA: 0x00147890 File Offset: 0x00145A90
		public ShopListing GetListing(string itemID)
		{
			return this.Listings.Find((ShopListing x) => x.Item.ID == itemID);
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x001478C4 File Offset: 0x00145AC4
		public virtual string GetSaveString()
		{
			Console.Log("Saving shop data: " + this.ShopCode, null);
			List<StringIntPair> list = new List<StringIntPair>();
			foreach (ShopListing shopListing in this.Listings)
			{
				if (!shopListing.IsUnlimitedStock && shopListing.CurrentStock != shopListing.DefaultStock)
				{
					list.Add(new StringIntPair(shopListing.Item.ID, shopListing.CurrentStock));
				}
			}
			return new ShopData(this.ShopCode, list.ToArray()).GetJson(true);
		}

		// Token: 0x04003A68 RID: 14952
		public static List<ShopInterface> AllShops = new List<ShopInterface>();

		// Token: 0x04003A69 RID: 14953
		public const int MAX_ITEM_QUANTITY = 999;

		// Token: 0x04003A6B RID: 14955
		[Header("Settings")]
		public string ShopName = "Shop";

		// Token: 0x04003A6C RID: 14956
		public string ShopCode = "shop";

		// Token: 0x04003A6D RID: 14957
		public ShopInterface.EPaymentType PaymentType;

		// Token: 0x04003A6E RID: 14958
		public bool ShowCurrencyHint;

		// Token: 0x04003A6F RID: 14959
		[Header("Listings")]
		public List<ShopListing> Listings = new List<ShopListing>();

		// Token: 0x04003A70 RID: 14960
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003A71 RID: 14961
		public RectTransform Container;

		// Token: 0x04003A72 RID: 14962
		public RectTransform ListingContainer;

		// Token: 0x04003A73 RID: 14963
		public TextMeshProUGUI StoreNameLabel;

		// Token: 0x04003A74 RID: 14964
		public Cart Cart;

		// Token: 0x04003A75 RID: 14965
		public StorageEntity[] DeliveryBays;

		// Token: 0x04003A76 RID: 14966
		public VehicleDetector LoadingBayDetector;

		// Token: 0x04003A77 RID: 14967
		public ShopInterfaceDetailPanel DetailPanel;

		// Token: 0x04003A78 RID: 14968
		public ScrollRect ListingScrollRect;

		// Token: 0x04003A79 RID: 14969
		public ShopAmountSelector AmountSelector;

		// Token: 0x04003A7A RID: 14970
		public DeliveryVehicle DeliveryVehicle;

		// Token: 0x04003A7B RID: 14971
		[Header("Audio")]
		public AudioSourceController AddItemSound;

		// Token: 0x04003A7C RID: 14972
		public AudioSourceController RemoveItemSound;

		// Token: 0x04003A7D RID: 14973
		public AudioSourceController CheckoutSound;

		// Token: 0x04003A7E RID: 14974
		[Header("Prefabs")]
		public ListingUI ListingUIPrefab;

		// Token: 0x04003A7F RID: 14975
		public UnityEvent onOrderCompleted;

		// Token: 0x04003A80 RID: 14976
		[SerializeField]
		private List<CategoryButton> categoryButtons = new List<CategoryButton>();

		// Token: 0x04003A81 RID: 14977
		private EShopCategory categoryFilter;

		// Token: 0x04003A82 RID: 14978
		private string searchTerm = string.Empty;

		// Token: 0x04003A83 RID: 14979
		private List<ListingUI> listingUI = new List<ListingUI>();

		// Token: 0x04003A84 RID: 14980
		private ListingUI selectedListing;

		// Token: 0x04003A85 RID: 14981
		private bool dropdownMouseUp;

		// Token: 0x04003A86 RID: 14982
		private ShopLoader loader = new ShopLoader();

		// Token: 0x02000B5F RID: 2911
		public enum EPaymentType
		{
			// Token: 0x04003A8B RID: 14987
			Cash,
			// Token: 0x04003A8C RID: 14988
			Online,
			// Token: 0x04003A8D RID: 14989
			PreferCash,
			// Token: 0x04003A8E RID: 14990
			PreferOnline
		}
	}
}
