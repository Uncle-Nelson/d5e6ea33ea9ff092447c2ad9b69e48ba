using System;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000384 RID: 900
	public class CocaineProductLoader : Loader
	{
		// Token: 0x06001473 RID: 5235 RVA: 0x0005B610 File Offset: 0x00059810
		public override void Load(string mainPath)
		{
			string text;
			if (base.TryLoadFile(mainPath, out text, false))
			{
				CocaineProductData cocaineProductData = null;
				try
				{
					cocaineProductData = JsonUtility.FromJson<CocaineProductData>(text);
				}
				catch (Exception ex)
				{
					Debug.LogError("Error loading product data: " + ex.Message);
				}
				if (cocaineProductData == null)
				{
					return;
				}
				NetworkSingleton<ProductManager>.Instance.CreateCocaine_Server(cocaineProductData.Name, cocaineProductData.ID, cocaineProductData.DrugType, cocaineProductData.Properties.ToList<string>(), cocaineProductData.AppearanceSettings);
			}
		}
	}
}
