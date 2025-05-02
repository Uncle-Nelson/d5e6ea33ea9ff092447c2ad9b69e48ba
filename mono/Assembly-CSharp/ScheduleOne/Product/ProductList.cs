using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008F5 RID: 2293
	[Serializable]
	public class ProductList
	{
		// Token: 0x06003DEA RID: 15850 RVA: 0x00103944 File Offset: 0x00101B44
		public string GetCommaSeperatedString()
		{
			string text = string.Empty;
			foreach (ProductList.Entry entry in this.entries)
			{
				text = text + entry.Quantity.ToString() + "x ";
				text += Registry.GetItem(entry.ProductID).Name;
				if (entry != this.entries[this.entries.Count - 1])
				{
					text += ", ";
				}
			}
			return text;
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x001039EC File Offset: 0x00101BEC
		public string GetLineSeperatedString()
		{
			string text = "\n";
			foreach (ProductList.Entry entry in this.entries)
			{
				text = text + entry.Quantity.ToString() + "x ";
				text += Registry.GetItem(entry.ProductID).Name;
				if (entry != this.entries[this.entries.Count - 1])
				{
					text += "\n";
				}
			}
			return text;
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x00103A94 File Offset: 0x00101C94
		public string GetQualityString()
		{
			ProductList.Entry entry = this.entries[0];
			return string.Concat(new string[]
			{
				"<color=#",
				ColorUtility.ToHtmlStringRGBA(ItemQuality.GetColor(entry.Quality)),
				">",
				entry.Quality.ToString(),
				"</color> "
			});
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x00103AF8 File Offset: 0x00101CF8
		public int GetTotalQuantity()
		{
			int num = 0;
			foreach (ProductList.Entry entry in this.entries)
			{
				num += entry.Quantity;
			}
			return num;
		}

		// Token: 0x04002C98 RID: 11416
		public List<ProductList.Entry> entries = new List<ProductList.Entry>();

		// Token: 0x020008F6 RID: 2294
		[Serializable]
		public class Entry
		{
			// Token: 0x04002C99 RID: 11417
			public string ProductID;

			// Token: 0x04002C9A RID: 11418
			public EQuality Quality;

			// Token: 0x04002C9B RID: 11419
			public int Quantity;
		}
	}
}
