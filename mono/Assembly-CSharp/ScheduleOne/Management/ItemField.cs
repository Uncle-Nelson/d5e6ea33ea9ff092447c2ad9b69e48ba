using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000574 RID: 1396
	public class ItemField : ConfigField
	{
		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x0008ED90 File Offset: 0x0008CF90
		// (set) Token: 0x060022AC RID: 8876 RVA: 0x0008ED98 File Offset: 0x0008CF98
		public ItemDefinition SelectedItem { get; protected set; }

		// Token: 0x060022AD RID: 8877 RVA: 0x0008EDA1 File Offset: 0x0008CFA1
		public ItemField(EntityConfiguration parentConfig) : base(parentConfig)
		{
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x0008EDC7 File Offset: 0x0008CFC7
		public void SetItem(ItemDefinition item, bool network)
		{
			this.SelectedItem = item;
			if (network)
			{
				base.ParentConfig.ReplicateField(this, null);
			}
			if (this.onItemChanged != null)
			{
				this.onItemChanged.Invoke(this.SelectedItem);
			}
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x0008EDF9 File Offset: 0x0008CFF9
		public override bool IsValueDefault()
		{
			return this.SelectedItem == null;
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x0008EE07 File Offset: 0x0008D007
		public ItemFieldData GetData()
		{
			return new ItemFieldData((this.SelectedItem != null) ? this.SelectedItem.ID.ToString() : "");
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x0008EE34 File Offset: 0x0008D034
		public void Load(ItemFieldData data)
		{
			if (data != null && !string.IsNullOrEmpty(data.ItemID))
			{
				ItemDefinition item = Registry.GetItem(data.ItemID);
				if (item != null)
				{
					this.SetItem(item, true);
				}
			}
		}

		// Token: 0x04001A29 RID: 6697
		public bool CanSelectNone = true;

		// Token: 0x04001A2A RID: 6698
		public List<ItemDefinition> Options = new List<ItemDefinition>();

		// Token: 0x04001A2B RID: 6699
		public UnityEvent<ItemDefinition> onItemChanged = new UnityEvent<ItemDefinition>();
	}
}
