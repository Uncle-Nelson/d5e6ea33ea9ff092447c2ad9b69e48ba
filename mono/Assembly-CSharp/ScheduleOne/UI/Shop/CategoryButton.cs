using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000B56 RID: 2902
	public class CategoryButton : MonoBehaviour
	{
		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06004D48 RID: 19784 RVA: 0x00145DF3 File Offset: 0x00143FF3
		// (set) Token: 0x06004D49 RID: 19785 RVA: 0x00145DFB File Offset: 0x00143FFB
		public bool isSelected { get; protected set; }

		// Token: 0x06004D4A RID: 19786 RVA: 0x00145E04 File Offset: 0x00144004
		private void Awake()
		{
			this.button = base.GetComponent<Button>();
			this.shop = base.GetComponentInParent<ShopInterface>();
			this.button.onClick.AddListener(new UnityAction(this.Clicked));
			this.Deselect();
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x00145E40 File Offset: 0x00144040
		private void OnValidate()
		{
			base.gameObject.name = this.Category.ToString();
		}

		// Token: 0x06004D4C RID: 19788 RVA: 0x00145E5E File Offset: 0x0014405E
		private void Clicked()
		{
			if (this.isSelected)
			{
				this.Deselect();
				return;
			}
			this.Select();
		}

		// Token: 0x06004D4D RID: 19789 RVA: 0x00145E75 File Offset: 0x00144075
		public void Deselect()
		{
			this.isSelected = false;
			this.RefreshUI();
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x00145E84 File Offset: 0x00144084
		public void Select()
		{
			this.isSelected = true;
			this.RefreshUI();
			this.shop.CategorySelected(this.Category);
		}

		// Token: 0x06004D4F RID: 19791 RVA: 0x00145EA4 File Offset: 0x001440A4
		private void RefreshUI()
		{
			this.button.interactable = !this.isSelected;
		}

		// Token: 0x04003A2F RID: 14895
		public EShopCategory Category;

		// Token: 0x04003A30 RID: 14896
		private Button button;

		// Token: 0x04003A31 RID: 14897
		private ShopInterface shop;
	}
}
