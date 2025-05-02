using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003D0 RID: 976
	[Serializable]
	public class ItemSet
	{
		// Token: 0x0600152E RID: 5422 RVA: 0x0005F25C File Offset: 0x0005D45C
		public ItemSet(List<ItemData> items)
		{
			this.Items = new string[items.Count];
			for (int i = 0; i < items.Count; i++)
			{
				this.Items[i] = items[i].GetJson(false);
			}
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0005F2A6 File Offset: 0x0005D4A6
		public string GetJSON()
		{
			return JsonUtility.ToJson(this, true);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0005F2B0 File Offset: 0x0005D4B0
		public ItemSet(List<ItemInstance> items)
		{
			this.Items = new string[items.Count];
			for (int i = 0; i < items.Count; i++)
			{
				this.Items[i] = items[i].GetItemData().GetJson(false);
			}
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0005F300 File Offset: 0x0005D500
		public ItemSet(List<ItemSlot> itemSlots)
		{
			this.Items = new string[itemSlots.Count];
			for (int i = 0; i < itemSlots.Count; i++)
			{
				if (itemSlots[i].ItemInstance != null)
				{
					this.Items[i] = itemSlots[i].ItemInstance.GetItemData().GetJson(false);
				}
				else
				{
					this.Items[i] = new ItemData(string.Empty, 0).GetJson(false);
				}
			}
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0005F380 File Offset: 0x0005D580
		public ItemSet(ItemSlot[] itemSlots)
		{
			this.Items = new string[itemSlots.Length];
			for (int i = 0; i < itemSlots.Length; i++)
			{
				if (itemSlots[i].ItemInstance != null)
				{
					this.Items[i] = itemSlots[i].ItemInstance.GetItemData().GetJson(false);
				}
				else
				{
					this.Items[i] = new ItemData(string.Empty, 0).GetJson(false);
				}
			}
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0005F3F0 File Offset: 0x0005D5F0
		public static ItemInstance[] Deserialize(string json)
		{
			ItemSet itemSet = null;
			try
			{
				itemSet = JsonUtility.FromJson<ItemSet>(json);
			}
			catch (Exception ex)
			{
				string str = "Failed to deserialize ItemSet from JSON: ";
				string str2 = "\nException: ";
				Exception ex2 = ex;
				Console.LogError(str + json + str2 + ((ex2 != null) ? ex2.ToString() : null), null);
				return new ItemInstance[0];
			}
			ItemInstance[] array = new ItemInstance[itemSet.Items.Length];
			for (int i = 0; i < itemSet.Items.Length; i++)
			{
				array[i] = ItemDeserializer.LoadItem(itemSet.Items[i]);
			}
			return array;
		}

		// Token: 0x0400136A RID: 4970
		public string[] Items;
	}
}
