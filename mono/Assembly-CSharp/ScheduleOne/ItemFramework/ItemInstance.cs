using System;
using FishNet.Serializing.Helping;
using ScheduleOne.Equipping;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200094D RID: 2381
	[Serializable]
	public abstract class ItemInstance
	{
		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06004048 RID: 16456 RVA: 0x0010E6A0 File Offset: 0x0010C8A0
		[CodegenExclude]
		public ItemDefinition Definition
		{
			get
			{
				if (this.definition == null)
				{
					this.definition = Registry.GetItem(this.ID);
					if (this.definition == null)
					{
						Console.LogError("Failed to find definition with ID: " + this.ID, null);
					}
				}
				return this.definition;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06004049 RID: 16457 RVA: 0x0010E6F6 File Offset: 0x0010C8F6
		[CodegenExclude]
		public virtual string Name
		{
			get
			{
				return this.Definition.Name;
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x0600404A RID: 16458 RVA: 0x0010E703 File Offset: 0x0010C903
		[CodegenExclude]
		public virtual string Description
		{
			get
			{
				return this.Definition.Description;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x0600404B RID: 16459 RVA: 0x0010E710 File Offset: 0x0010C910
		[CodegenExclude]
		public virtual Sprite Icon
		{
			get
			{
				return this.Definition.Icon;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x0600404C RID: 16460 RVA: 0x0010E71D File Offset: 0x0010C91D
		[CodegenExclude]
		public virtual EItemCategory Category
		{
			get
			{
				return this.Definition.Category;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x0600404D RID: 16461 RVA: 0x0010E72A File Offset: 0x0010C92A
		[CodegenExclude]
		public virtual int StackLimit
		{
			get
			{
				return this.Definition.StackLimit;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x0600404E RID: 16462 RVA: 0x0010E737 File Offset: 0x0010C937
		[CodegenExclude]
		public virtual Color LabelDisplayColor
		{
			get
			{
				return this.Definition.LabelDisplayColor;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x0600404F RID: 16463 RVA: 0x0010E744 File Offset: 0x0010C944
		[CodegenExclude]
		public virtual Equippable Equippable
		{
			get
			{
				return this.Definition.Equippable;
			}
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x0010E751 File Offset: 0x0010C951
		public ItemInstance()
		{
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x0010E76B File Offset: 0x0010C96B
		public ItemInstance(ItemDefinition definition, int quantity)
		{
			this.definition = definition;
			this.Quantity = quantity;
			this.ID = definition.ID;
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x0010E79F File Offset: 0x0010C99F
		public virtual bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			return other != null && !(other.ID != this.ID) && (!checkQuantities || this.Quantity + other.Quantity <= this.StackLimit);
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x0010E650 File Offset: 0x0010C850
		public virtual ItemInstance GetCopy(int overrideQuantity = -1)
		{
			Console.LogError("This should be overridden in the definition class!", null);
			return null;
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x0010E7D6 File Offset: 0x0010C9D6
		public virtual bool IsValidInstance()
		{
			return this.ID != string.Empty && this.Definition != null && this.Quantity > 0;
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x0010E803 File Offset: 0x0010CA03
		protected void InvokeDataChange()
		{
			if (this.onDataChanged != null)
			{
				this.onDataChanged();
			}
		}

		// Token: 0x06004056 RID: 16470 RVA: 0x0010E818 File Offset: 0x0010CA18
		public void SetQuantity(int quantity)
		{
			if (quantity < 0)
			{
				Debug.LogError("SetQuantity called and passed quantity less than zero.");
				return;
			}
			if (quantity > this.StackLimit && quantity > this.Quantity)
			{
				Debug.LogError("SetQuantity called and passed quantity larger than stack limit.");
				return;
			}
			this.Quantity = quantity;
			this.InvokeDataChange();
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x0010E854 File Offset: 0x0010CA54
		public void ChangeQuantity(int change)
		{
			int num = this.Quantity + change;
			if (num < 0)
			{
				Debug.LogError("ChangeQuantity called and passed quantity less than zero.");
				return;
			}
			if (num > this.StackLimit)
			{
				Debug.LogError("ChangeQuantity called and passed quantity larger than stack limit.");
				return;
			}
			this.Quantity = num;
			this.InvokeDataChange();
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x0010E89A File Offset: 0x0010CA9A
		public virtual ItemData GetItemData()
		{
			return new ItemData(this.ID, this.Quantity);
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x0010E8AD File Offset: 0x0010CAAD
		public virtual float GetMonetaryValue()
		{
			return 0f;
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x0010E8B4 File Offset: 0x0010CAB4
		public void RequestClearSlot()
		{
			if (this.requestClearSlot != null)
			{
				this.requestClearSlot();
			}
		}

		// Token: 0x04002E34 RID: 11828
		[CodegenExclude]
		protected ItemDefinition definition;

		// Token: 0x04002E35 RID: 11829
		public string ID = string.Empty;

		// Token: 0x04002E36 RID: 11830
		public int Quantity = 1;

		// Token: 0x04002E37 RID: 11831
		[CodegenExclude]
		public Action onDataChanged;

		// Token: 0x04002E38 RID: 11832
		[CodegenExclude]
		public Action requestClearSlot;
	}
}
