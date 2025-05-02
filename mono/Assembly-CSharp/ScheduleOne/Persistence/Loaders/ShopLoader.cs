using System;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Shop;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000398 RID: 920
	public class ShopLoader : Loader
	{
		// Token: 0x060014A4 RID: 5284 RVA: 0x0005C628 File Offset: 0x0005A828
		public override void Load(string mainPath)
		{
			string text;
			if (base.TryLoadFile(mainPath, out text, false))
			{
				Console.Log("Loading shop file a: " + mainPath, null);
				ShopData data = null;
				try
				{
					data = JsonUtility.FromJson<ShopData>(text);
				}
				catch (Exception ex)
				{
					Debug.LogError("Failed to load shop data: " + ex.Message);
				}
				if (data != null)
				{
					Console.Log("Found shop data", null);
					ShopInterface shopInterface = ShopInterface.AllShops.Find((ShopInterface x) => x.ShopCode == data.ShopCode);
					if (shopInterface == null)
					{
						Debug.LogError("Failed to load shop data: Shop not found: " + data.ShopCode);
						return;
					}
					shopInterface.Load(data);
					return;
				}
			}
			else
			{
				Console.Log("Failed to load shop file: " + mainPath, null);
			}
		}
	}
}
