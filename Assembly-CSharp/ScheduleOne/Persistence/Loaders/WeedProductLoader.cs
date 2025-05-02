using System;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003A1 RID: 929
	public class WeedProductLoader : Loader
	{
		// Token: 0x060014B6 RID: 5302 RVA: 0x0005CD30 File Offset: 0x0005AF30
		public override void Load(string mainPath)
		{
			string text;
			if (base.TryLoadFile(mainPath, out text, false))
			{
				WeedProductData weedProductData = null;
				try
				{
					weedProductData = JsonUtility.FromJson<WeedProductData>(text);
				}
				catch (Exception ex)
				{
					Debug.LogError("Error loading product data: " + ex.Message);
				}
				if (weedProductData == null)
				{
					return;
				}
				NetworkSingleton<ProductManager>.Instance.CreateWeed_Server(weedProductData.Name, weedProductData.ID, weedProductData.DrugType, weedProductData.Properties.ToList<string>(), weedProductData.AppearanceSettings);
			}
		}
	}
}
