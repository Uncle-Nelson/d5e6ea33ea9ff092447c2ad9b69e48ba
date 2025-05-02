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
	// Token: 0x020003C2 RID: 962
	public class MixingStationLoader : GridItemLoader
	{
		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x0005E6E1 File Offset: 0x0005C8E1
		public override string ItemType
		{
			get
			{
				return typeof(MixingStationData).Name;
			}
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x0005E6F4 File Offset: 0x0005C8F4
		public override void Load(string mainPath)
		{
			MixingStationLoader.<>c__DisplayClass3_0 CS$<>8__locals1 = new MixingStationLoader.<>c__DisplayClass3_0();
			GridItem gridItem = base.LoadAndCreate(mainPath);
			if (gridItem == null)
			{
				Console.LogWarning("Failed to load grid item", null);
				return;
			}
			CS$<>8__locals1.station = (gridItem as MixingStation);
			if (CS$<>8__locals1.station == null)
			{
				Console.LogWarning("Failed to cast grid item to mixing station", null);
				return;
			}
			MixingStationData data = base.GetData<MixingStationData>(mainPath);
			if (data == null)
			{
				Console.LogWarning("Failed to load mixing station data", null);
				return;
			}
			ItemInstance instance = ItemDeserializer.LoadItem(data.ProductContents.Items[0]);
			CS$<>8__locals1.station.ProductSlot.SetStoredItem(instance, false);
			ItemInstance instance2 = ItemDeserializer.LoadItem(data.MixerContents.Items[0]);
			CS$<>8__locals1.station.MixerSlot.SetStoredItem(instance2, false);
			ItemInstance instance3 = ItemDeserializer.LoadItem(data.OutputContents.Items[0]);
			CS$<>8__locals1.station.OutputSlot.SetStoredItem(instance3, false);
			if (data.CurrentMixOperation != null)
			{
				CS$<>8__locals1.station.SetMixOperation(null, data.CurrentMixOperation, data.CurrentMixTime);
				if (data.CurrentMixTime >= CS$<>8__locals1.station.GetMixTimeForCurrentOperation())
				{
					CS$<>8__locals1.station.MixingDone_Networked();
				}
			}
			string text;
			if (File.Exists(Path.Combine(mainPath, "Configuration.json")) && base.TryLoadFile(mainPath, "Configuration", out text))
			{
				CS$<>8__locals1.configData = JsonUtility.FromJson<MixingStationConfigurationData>(text);
				if (CS$<>8__locals1.configData != null)
				{
					Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(CS$<>8__locals1.<Load>g__LoadConfiguration|0));
				}
			}
		}
	}
}
