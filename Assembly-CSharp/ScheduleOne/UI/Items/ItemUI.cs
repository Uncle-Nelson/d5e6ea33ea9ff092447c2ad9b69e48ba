using System;
using ScheduleOne.ItemFramework;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000B74 RID: 2932
	public class ItemUI : MonoBehaviour
	{
		// Token: 0x06004E06 RID: 19974 RVA: 0x00148688 File Offset: 0x00146888
		public virtual void Setup(ItemInstance item)
		{
			if (item == null)
			{
				Console.LogError("ItemUI.Setup called and passed null item", null);
			}
			this.itemInstance = item;
			ItemInstance itemInstance = this.itemInstance;
			itemInstance.onDataChanged = (Action)Delegate.Remove(itemInstance.onDataChanged, new Action(this.UpdateUI));
			ItemInstance itemInstance2 = this.itemInstance;
			itemInstance2.onDataChanged = (Action)Delegate.Combine(itemInstance2.onDataChanged, new Action(this.UpdateUI));
			this.UpdateUI();
		}

		// Token: 0x06004E07 RID: 19975 RVA: 0x00148700 File Offset: 0x00146900
		public virtual void Destroy()
		{
			this.Destroyed = true;
			ItemInstance itemInstance = this.itemInstance;
			itemInstance.onDataChanged = (Action)Delegate.Remove(itemInstance.onDataChanged, new Action(this.UpdateUI));
			this.itemInstance = null;
			Object.Destroy(this.Rect.gameObject);
		}

		// Token: 0x06004E08 RID: 19976 RVA: 0x00148754 File Offset: 0x00146954
		public virtual RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1)
		{
			int displayedQuantity = this.DisplayedQuantity;
			if (overriddenQuantity != -1)
			{
				this.SetDisplayedQuantity(overriddenQuantity);
			}
			RectTransform component = Object.Instantiate<GameObject>(this.IconImg.gameObject, parent).GetComponent<RectTransform>();
			component.localScale = Vector3.one;
			this.SetDisplayedQuantity(displayedQuantity);
			return component;
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x0014879B File Offset: 0x0014699B
		public virtual void SetVisible(bool vis)
		{
			this.Rect.gameObject.SetActive(vis);
		}

		// Token: 0x06004E0A RID: 19978 RVA: 0x001487AE File Offset: 0x001469AE
		public virtual void UpdateUI()
		{
			if (this.Destroyed)
			{
				return;
			}
			this.IconImg.sprite = this.itemInstance.Icon;
			this.SetDisplayedQuantity(this.itemInstance.Quantity);
		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x001487E0 File Offset: 0x001469E0
		public virtual void SetDisplayedQuantity(int quantity)
		{
			this.DisplayedQuantity = quantity;
			if (quantity > 1)
			{
				this.QuantityLabel.text = quantity.ToString() + "x";
				return;
			}
			this.QuantityLabel.text = string.Empty;
		}

		// Token: 0x04003AD8 RID: 15064
		protected ItemInstance itemInstance;

		// Token: 0x04003AD9 RID: 15065
		[Header("References")]
		public RectTransform Rect;

		// Token: 0x04003ADA RID: 15066
		public Image IconImg;

		// Token: 0x04003ADB RID: 15067
		public TextMeshProUGUI QuantityLabel;

		// Token: 0x04003ADC RID: 15068
		protected int DisplayedQuantity;

		// Token: 0x04003ADD RID: 15069
		protected bool Destroyed;
	}
}
