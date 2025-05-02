using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x02000445 RID: 1093
	public class ItemLoader
	{
		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x0006082E File Offset: 0x0005EA2E
		public virtual string ItemType
		{
			get
			{
				return typeof(ItemData).Name;
			}
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0006083F File Offset: 0x0005EA3F
		public ItemLoader()
		{
			Singleton<LoadManager>.Instance.ItemLoaders.Add(this);
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00060858 File Offset: 0x0005EA58
		public virtual ItemInstance LoadItem(string itemString)
		{
			ItemData itemData = this.LoadData<ItemData>(itemString);
			if (itemData == null)
			{
				Console.LogWarning("Failed loading item data from " + itemString, null);
				return null;
			}
			if (itemData.ID == string.Empty)
			{
				return null;
			}
			ItemDefinition item = Registry.GetItem(itemData.ID);
			if (item == null)
			{
				Console.LogWarning("Failed to find item definition for " + itemData.ID, null);
				return null;
			}
			return new StorableItemInstance(item, itemData.Quantity);
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x000608D0 File Offset: 0x0005EAD0
		protected T LoadData<T>(string itemString) where T : ItemData
		{
			T result = default(T);
			try
			{
				result = JsonUtility.FromJson<T>(itemString);
			}
			catch (Exception ex)
			{
				string[] array = new string[5];
				int num = 0;
				Type type = base.GetType();
				array[num] = ((type != null) ? type.ToString() : null);
				array[1] = " error parsing item data: ";
				array[2] = itemString;
				array[3] = "\n";
				int num2 = 4;
				Exception ex2 = ex;
				array[num2] = ((ex2 != null) ? ex2.ToString() : null);
				Console.LogError(string.Concat(array), null);
				return default(T);
			}
			return result;
		}
	}
}
