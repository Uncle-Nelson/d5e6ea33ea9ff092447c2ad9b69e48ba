using System;
using System.Collections.Generic;
using ScheduleOne.Delivery;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using ScheduleOne.Property;
using ScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Delivery
{
	// Token: 0x02000AB8 RID: 2744
	public class DeliveryShop : MonoBehaviour
	{
		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x060049BF RID: 18879 RVA: 0x00134E3B File Offset: 0x0013303B
		// (set) Token: 0x060049C0 RID: 18880 RVA: 0x00134E43 File Offset: 0x00133043
		public ShopInterface MatchingShop { get; private set; }

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x060049C1 RID: 18881 RVA: 0x00134E4C File Offset: 0x0013304C
		// (set) Token: 0x060049C2 RID: 18882 RVA: 0x00134E54 File Offset: 0x00133054
		public bool IsExpanded { get; private set; }

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x060049C3 RID: 18883 RVA: 0x00134E5D File Offset: 0x0013305D
		// (set) Token: 0x060049C4 RID: 18884 RVA: 0x00134E65 File Offset: 0x00133065
		public bool IsAvailable { get; private set; }

		// Token: 0x060049C5 RID: 18885 RVA: 0x00134E70 File Offset: 0x00133070
		private void Start()
		{
			this.MatchingShop = ShopInterface.AllShops.Find((ShopInterface x) => x.ShopName == this.MatchingShopInterfaceName);
			if (this.MatchingShop == null)
			{
				Debug.LogError("Could not find shop interface with name " + this.MatchingShopInterfaceName);
				return;
			}
			foreach (ShopListing shopListing in this.MatchingShop.Listings)
			{
				if (shopListing.CanBeDelivered)
				{
					ListingEntry listingEntry = Object.Instantiate<ListingEntry>(this.ListingEntryPrefab, this.ListingContainer);
					listingEntry.Initialize(shopListing);
					listingEntry.onQuantityChanged.AddListener(new UnityAction(this.RefreshCart));
					this.listingEntries.Add(listingEntry);
				}
			}
			this.DeliveryFeeLabel.text = MoneyManager.FormatAmount(this.DeliveryFee, false, false);
			int num = Mathf.CeilToInt((float)this.listingEntries.Count / 2f);
			this.ContentsContainer.sizeDelta = new Vector2(this.ContentsContainer.sizeDelta.x, 230f + (float)num * 60f);
			this.HeaderButton.onClick.AddListener(new UnityAction(delegate()
			{
				this.SetIsExpanded(!this.IsExpanded);
			}));
			this.OrderButton.onClick.AddListener(new UnityAction(this.OrderPressed));
			this.DestinationDropdown.onValueChanged.AddListener(new UnityAction<int>(this.DestinationDropdownSelected));
			this.LoadingDockDropdown.onValueChanged.AddListener(new UnityAction<int>(this.LoadingDockDropdownSelected));
			this.SetIsExpanded(false);
			if (this.AvailableByDefault)
			{
				this.SetIsAvailable();
			}
			else
			{
				base.gameObject.SetActive(false);
			}
			this.MatchingShop.DeliveryVehicle.Deactivate();
		}

		// Token: 0x060049C6 RID: 18886 RVA: 0x00135048 File Offset: 0x00133248
		private void FixedUpdate()
		{
			if (this.IsExpanded && PlayerSingleton<DeliveryApp>.Instance.isOpen)
			{
				this.RefreshOrderButton();
			}
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x00135064 File Offset: 0x00133264
		public void SetIsExpanded(bool expanded)
		{
			this.IsExpanded = expanded;
			this.ContentsContainer.gameObject.SetActive(this.IsExpanded);
			this.HeaderImage.sprite = (this.IsExpanded ? this.HeaderImage_Expanded : this.HeaderImage_Hidden);
			this.HeaderArrow.localRotation = (this.IsExpanded ? Quaternion.Euler(0f, 0f, 270f) : Quaternion.Euler(0f, 0f, 180f));
			PlayerSingleton<DeliveryApp>.Instance.RefreshContent(true);
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x001350F7 File Offset: 0x001332F7
		public void SetIsAvailable()
		{
			this.IsAvailable = true;
			base.gameObject.SetActive(true);
			PlayerSingleton<DeliveryApp>.Instance.RefreshContent(true);
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x00135118 File Offset: 0x00133318
		public void OrderPressed()
		{
			string str;
			if (!this.CanOrder(out str))
			{
				Debug.LogWarning("Cannot order: " + str);
				return;
			}
			float orderTotal = this.GetOrderTotal();
			List<StringIntPair> list = new List<StringIntPair>();
			foreach (ListingEntry listingEntry in this.listingEntries)
			{
				if (listingEntry.SelectedQuantity > 0)
				{
					list.Add(new StringIntPair(listingEntry.MatchingListing.Item.ID, listingEntry.SelectedQuantity));
				}
			}
			int orderItemCount = this.GetOrderItemCount();
			int timeUntilArrival = Mathf.RoundToInt(Mathf.Lerp(60f, 360f, Mathf.Clamp01((float)orderItemCount / 160f)));
			DeliveryInstance delivery = new DeliveryInstance(GUIDManager.GenerateUniqueGUID().ToString(), this.MatchingShopInterfaceName, this.destinationProperty.PropertyCode, this.loadingDockIndex - 1, list.ToArray(), EDeliveryStatus.InTransit, timeUntilArrival);
			NetworkSingleton<DeliveryManager>.Instance.SendDelivery(delivery);
			NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction("Delivery from " + this.MatchingShop.ShopName, -orderTotal, 1f, string.Empty);
			PlayerSingleton<DeliveryApp>.Instance.PlayOrderSubmittedAnim();
			this.ResetCart();
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x0013526C File Offset: 0x0013346C
		public void RefreshShop()
		{
			this.RefreshCart();
			this.RefreshOrderButton();
			this.RefreshDestinationUI();
			this.RefreshLoadingDockUI();
			this.RefreshEntryOrder();
			this.RefreshEntriesLocked();
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x00135294 File Offset: 0x00133494
		public void ResetCart()
		{
			foreach (ListingEntry listingEntry in this.listingEntries)
			{
				listingEntry.SetQuantity(0, false);
			}
			this.RefreshCart();
			this.RefreshOrderButton();
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x001352F4 File Offset: 0x001334F4
		private void RefreshCart()
		{
			this.ItemTotalLabel.text = MoneyManager.FormatAmount(this.GetCartCost(), false, false);
			this.OrderTotalLabel.text = MoneyManager.FormatAmount(this.GetOrderTotal(), false, false);
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x00135328 File Offset: 0x00133528
		private void RefreshOrderButton()
		{
			string text;
			if (this.CanOrder(out text))
			{
				this.OrderButton.interactable = true;
				this.OrderButtonNote.enabled = false;
				return;
			}
			this.OrderButton.interactable = false;
			this.OrderButtonNote.text = text;
			this.OrderButtonNote.enabled = true;
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x0013537C File Offset: 0x0013357C
		public bool CanOrder(out string reason)
		{
			reason = string.Empty;
			if (this.HasActiveDelivery())
			{
				reason = "Delivery already in progress";
				return false;
			}
			float cartCost = this.GetCartCost();
			if (this.GetOrderTotal() > NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance)
			{
				reason = "Insufficient online balance";
				return false;
			}
			if (this.destinationProperty == null)
			{
				reason = "Select a destination";
				return false;
			}
			if (this.destinationProperty.LoadingDockCount == 0)
			{
				reason = "Selected destination has no loading docks";
				return false;
			}
			if (this.loadingDockIndex == 0)
			{
				reason = "Select a loading dock";
				return false;
			}
			if (!this.WillCartFitInVehicle())
			{
				reason = "Order is too large for delivery vehicle";
				return false;
			}
			return cartCost > 0f;
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x0013541A File Offset: 0x0013361A
		public bool HasActiveDelivery()
		{
			return !(this.destinationProperty == null) && NetworkSingleton<DeliveryManager>.Instance.GetActiveShopDelivery(this) != null;
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x0013543C File Offset: 0x0013363C
		public bool WillCartFitInVehicle()
		{
			int num = 0;
			foreach (ListingEntry listingEntry in this.listingEntries)
			{
				if (listingEntry.SelectedQuantity != 0)
				{
					int i = listingEntry.SelectedQuantity;
					int stackLimit = listingEntry.MatchingListing.Item.StackLimit;
					while (i > 0)
					{
						if (i > stackLimit)
						{
							i -= stackLimit;
						}
						else
						{
							i = 0;
						}
						num++;
					}
				}
			}
			return num <= 16;
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x001354CC File Offset: 0x001336CC
		public void RefreshDestinationUI()
		{
			Property y = this.destinationProperty;
			this.destinationProperty = null;
			this.DestinationDropdown.ClearOptions();
			List<Dropdown.OptionData> list = new List<Dropdown.OptionData>();
			list.Add(new Dropdown.OptionData("-"));
			List<Property> potentialDestinations = this.GetPotentialDestinations();
			int num = 0;
			for (int i = 0; i < potentialDestinations.Count; i++)
			{
				list.Add(new Dropdown.OptionData(potentialDestinations[i].PropertyName));
				if (potentialDestinations[i] == y)
				{
					num = i + 1;
				}
			}
			this.DestinationDropdown.AddOptions(list);
			this.DestinationDropdown.SetValueWithoutNotify(num);
			this.DestinationDropdownSelected(num);
		}

		// Token: 0x060049D2 RID: 18898 RVA: 0x00135574 File Offset: 0x00133774
		private void DestinationDropdownSelected(int index)
		{
			if (index > 0 && index <= this.GetPotentialDestinations().Count)
			{
				this.destinationProperty = this.GetPotentialDestinations()[index - 1];
				if (this.loadingDockIndex == 0 && this.destinationProperty.LoadingDockCount > 0)
				{
					this.loadingDockIndex = 1;
				}
			}
			else
			{
				this.destinationProperty = null;
			}
			this.RefreshLoadingDockUI();
		}

		// Token: 0x060049D3 RID: 18899 RVA: 0x001355D3 File Offset: 0x001337D3
		private List<Property> GetPotentialDestinations()
		{
			return new List<Property>(Property.OwnedProperties);
		}

		// Token: 0x060049D4 RID: 18900 RVA: 0x001355E0 File Offset: 0x001337E0
		public void RefreshLoadingDockUI()
		{
			int value = this.loadingDockIndex;
			this.loadingDockIndex = 0;
			this.LoadingDockDropdown.ClearOptions();
			List<Dropdown.OptionData> list = new List<Dropdown.OptionData>();
			list.Add(new Dropdown.OptionData("-"));
			if (this.destinationProperty != null)
			{
				for (int i = 0; i < this.destinationProperty.LoadingDockCount; i++)
				{
					list.Add(new Dropdown.OptionData((i + 1).ToString()));
				}
			}
			this.LoadingDockDropdown.AddOptions(list);
			int num = Mathf.Clamp(value, 0, list.Count - 1);
			this.LoadingDockDropdown.SetValueWithoutNotify(num);
			this.LoadingDockDropdownSelected(num);
		}

		// Token: 0x060049D5 RID: 18901 RVA: 0x00135686 File Offset: 0x00133886
		private void LoadingDockDropdownSelected(int index)
		{
			this.loadingDockIndex = index;
		}

		// Token: 0x060049D6 RID: 18902 RVA: 0x00135690 File Offset: 0x00133890
		private float GetCartCost()
		{
			float num = 0f;
			foreach (ListingEntry listingEntry in this.listingEntries)
			{
				num += (float)listingEntry.SelectedQuantity * listingEntry.MatchingListing.Price;
			}
			return num;
		}

		// Token: 0x060049D7 RID: 18903 RVA: 0x001356FC File Offset: 0x001338FC
		private float GetOrderTotal()
		{
			return this.GetCartCost() + this.DeliveryFee;
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x0013570C File Offset: 0x0013390C
		private int GetOrderItemCount()
		{
			int num = 0;
			foreach (ListingEntry listingEntry in this.listingEntries)
			{
				num += listingEntry.SelectedQuantity;
			}
			return num;
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x00135764 File Offset: 0x00133964
		private void RefreshEntryOrder()
		{
			List<ListingEntry> list = new List<ListingEntry>();
			List<ListingEntry> list2 = new List<ListingEntry>();
			foreach (ListingEntry listingEntry in this.listingEntries)
			{
				if (!listingEntry.MatchingListing.Item.IsPurchasable)
				{
					list2.Add(listingEntry);
				}
				else
				{
					list.Add(listingEntry);
				}
			}
			list.AddRange(list2);
			for (int i = 0; i < list.Count; i++)
			{
				list[i].transform.SetSiblingIndex(i);
			}
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x00135810 File Offset: 0x00133A10
		private void RefreshEntriesLocked()
		{
			foreach (ListingEntry listingEntry in this.listingEntries)
			{
				listingEntry.RefreshLocked();
			}
		}

		// Token: 0x040036D4 RID: 14036
		public const int DELIVERY_VEHICLE_SLOT_CAPACITY = 16;

		// Token: 0x040036D5 RID: 14037
		public const int DELIVERY_TIME_MIN = 60;

		// Token: 0x040036D6 RID: 14038
		public const int DELIVERY_TIME_MAX = 360;

		// Token: 0x040036D7 RID: 14039
		public const int DELIVERY_TIME_ITEM_COUNT_DIVISOR = 160;

		// Token: 0x040036DB RID: 14043
		[Header("References")]
		public Image HeaderImage;

		// Token: 0x040036DC RID: 14044
		public Button HeaderButton;

		// Token: 0x040036DD RID: 14045
		public RectTransform ContentsContainer;

		// Token: 0x040036DE RID: 14046
		public RectTransform ListingContainer;

		// Token: 0x040036DF RID: 14047
		public Text DeliveryFeeLabel;

		// Token: 0x040036E0 RID: 14048
		public Text ItemTotalLabel;

		// Token: 0x040036E1 RID: 14049
		public Text OrderTotalLabel;

		// Token: 0x040036E2 RID: 14050
		public Button OrderButton;

		// Token: 0x040036E3 RID: 14051
		public Text OrderButtonNote;

		// Token: 0x040036E4 RID: 14052
		public Dropdown DestinationDropdown;

		// Token: 0x040036E5 RID: 14053
		public Dropdown LoadingDockDropdown;

		// Token: 0x040036E6 RID: 14054
		[Header("Settings")]
		public string MatchingShopInterfaceName = "ShopInterface";

		// Token: 0x040036E7 RID: 14055
		public float DeliveryFee = 200f;

		// Token: 0x040036E8 RID: 14056
		public bool AvailableByDefault;

		// Token: 0x040036E9 RID: 14057
		public ListingEntry ListingEntryPrefab;

		// Token: 0x040036EA RID: 14058
		public Sprite HeaderImage_Hidden;

		// Token: 0x040036EB RID: 14059
		public Sprite HeaderImage_Expanded;

		// Token: 0x040036EC RID: 14060
		public RectTransform HeaderArrow;

		// Token: 0x040036ED RID: 14061
		private List<ListingEntry> listingEntries = new List<ListingEntry>();

		// Token: 0x040036EE RID: 14062
		private Property destinationProperty;

		// Token: 0x040036EF RID: 14063
		private int loadingDockIndex;
	}
}
