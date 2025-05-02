using System;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200038B RID: 907
	public class MethProductLoader : Loader
	{
		// Token: 0x06001485 RID: 5253 RVA: 0x0005BA34 File Offset: 0x00059C34
		public override void Load(string mainPath)
		{
			string text;
			if (base.TryLoadFile(mainPath, out text, false))
			{
				MethProductData methProductData = null;
				try
				{
					methProductData = JsonUtility.FromJson<MethProductData>(text);
				}
				catch (Exception ex)
				{
					Debug.LogError("Error loading product data: " + ex.Message);
				}
				if (methProductData == null)
				{
					return;
				}
				NetworkSingleton<ProductManager>.Instance.CreateMeth_Server(methProductData.Name, methProductData.ID, methProductData.DrugType, methProductData.Properties.ToList<string>(), methProductData.AppearanceSettings);
			}
		}
	}
}
