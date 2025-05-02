using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000B57 RID: 2903
	public class ClothingShopInterface : ShopInterface
	{
		// Token: 0x06004D51 RID: 19793 RVA: 0x00145EBA File Offset: 0x001440BA
		protected override void Start()
		{
			base.Start();
			this.ColorPicker.onColorPicked.AddListener(new UnityAction<EClothingColor>(this.ColorPicked));
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x00145EE0 File Offset: 0x001440E0
		public override void ListingClicked(ListingUI listingUI)
		{
			if (!listingUI.Listing.Item.IsPurchasable)
			{
				return;
			}
			if ((listingUI.Listing.Item as ClothingDefinition).Colorable)
			{
				this._selectedListing = listingUI.Listing;
				this.ColorPicker.Open(listingUI.Listing.Item);
				return;
			}
			base.ListingClicked(listingUI);
		}

		// Token: 0x06004D53 RID: 19795 RVA: 0x00145F41 File Offset: 0x00144141
		protected override void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (this.ColorPicker != null && this.ColorPicker.IsOpen)
			{
				action.used = true;
				this.ColorPicker.Close();
			}
			base.Exit(action);
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x00145F80 File Offset: 0x00144180
		private void ColorPicked(EClothingColor color)
		{
			if (this._selectedListing == null)
			{
				return;
			}
			ClothingShopListing clothingShopListing = new ClothingShopListing();
			clothingShopListing.Item = this._selectedListing.Item;
			clothingShopListing.Color = color;
			this.Cart.AddItem(clothingShopListing, 1);
			this.AddItemSound.Play();
		}

		// Token: 0x06004D55 RID: 19797 RVA: 0x00145FCC File Offset: 0x001441CC
		public override bool HandoverItems()
		{
			List<ItemSlot> availableSlots = base.GetAvailableSlots();
			List<ShopListing> list = this.Cart.cartDictionary.Keys.ToList<ShopListing>();
			bool result = true;
			for (int i = 0; i < list.Count; i++)
			{
				NetworkSingleton<VariableDatabase>.Instance.NotifyItemAcquired(list[i].Item.ID, this.Cart.cartDictionary[list[i]]);
				int num = this.Cart.cartDictionary[list[i]];
				ClothingInstance clothingInstance = list[i].Item.GetDefaultInstance(1) as ClothingInstance;
				clothingInstance.Color = EClothingColor.White;
				if (list[i] is ClothingShopListing)
				{
					Console.Log("Color: " + (list[i] as ClothingShopListing).Color.ToString(), null);
					clothingInstance.Color = (list[i] as ClothingShopListing).Color;
				}
				int num2 = 0;
				while (num2 < availableSlots.Count && num > 0)
				{
					int capacityForItem = availableSlots[num2].GetCapacityForItem(clothingInstance);
					if (capacityForItem != 0)
					{
						int num3 = Mathf.Min(capacityForItem, num);
						availableSlots[num2].AddItem(clothingInstance.GetCopy(num3), false);
						num -= num3;
					}
					num2++;
				}
				if (num > 0)
				{
					Debug.LogWarning("Failed to handover all items in cart: " + clothingInstance.Name);
					result = false;
				}
			}
			return result;
		}

		// Token: 0x04003A32 RID: 14898
		public ShopColorPicker ColorPicker;

		// Token: 0x04003A33 RID: 14899
		private ShopListing _selectedListing;
	}
}
