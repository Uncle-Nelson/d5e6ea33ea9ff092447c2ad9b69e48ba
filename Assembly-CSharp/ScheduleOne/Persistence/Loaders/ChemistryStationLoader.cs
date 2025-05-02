using System;
using System.IO;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003BA RID: 954
	public class ChemistryStationLoader : GridItemLoader
	{
		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0005DF75 File Offset: 0x0005C175
		public override string ItemType
		{
			get
			{
				return typeof(ChemistryStationData).Name;
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0005DF88 File Offset: 0x0005C188
		public override void Load(string mainPath)
		{
			ChemistryStationLoader.<>c__DisplayClass3_0 CS$<>8__locals1 = new ChemistryStationLoader.<>c__DisplayClass3_0();
			GridItem gridItem = base.LoadAndCreate(mainPath);
			if (gridItem == null)
			{
				Console.LogWarning("Failed to load grid item", null);
				return;
			}
			CS$<>8__locals1.station = (gridItem as ChemistryStation);
			if (CS$<>8__locals1.station == null)
			{
				Console.LogWarning("Failed to cast grid item to chemistry station", null);
				return;
			}
			ChemistryStationData data = base.GetData<ChemistryStationData>(mainPath);
			if (data == null)
			{
				Console.LogWarning("Failed to load chemistry station data", null);
				return;
			}
			for (int i = 0; i < data.InputContents.Items.Length; i++)
			{
				ItemInstance instance = ItemDeserializer.LoadItem(data.InputContents.Items[i]);
				if (CS$<>8__locals1.station.ItemSlots.Count > i)
				{
					CS$<>8__locals1.station.ItemSlots[i].SetStoredItem(instance, false);
				}
			}
			ItemInstance instance2 = ItemDeserializer.LoadItem(data.OutputContents.Items[0]);
			CS$<>8__locals1.station.OutputSlot.SetStoredItem(instance2, false);
			if (data.CurrentRecipeID != string.Empty)
			{
				ChemistryCookOperation operation = new ChemistryCookOperation(data.CurrentRecipeID, data.ProductQuality, data.StartLiquidColor, data.LiquidLevel, data.CurrentTime);
				CS$<>8__locals1.station.SetCookOperation(null, operation);
			}
			string text;
			if (File.Exists(Path.Combine(mainPath, "Configuration.json")) && base.TryLoadFile(mainPath, "Configuration", out text))
			{
				CS$<>8__locals1.configData = JsonUtility.FromJson<ChemistryStationConfigurationData>(text);
				if (CS$<>8__locals1.configData != null)
				{
					Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(CS$<>8__locals1.<Load>g__LoadConfiguration|0));
				}
			}
		}
	}
}
