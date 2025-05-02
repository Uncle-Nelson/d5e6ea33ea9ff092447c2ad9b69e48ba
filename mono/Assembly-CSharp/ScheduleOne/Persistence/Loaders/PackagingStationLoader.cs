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
	// Token: 0x020003C4 RID: 964
	public class PackagingStationLoader : GridItemLoader
	{
		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x0005E8D6 File Offset: 0x0005CAD6
		public override string ItemType
		{
			get
			{
				return typeof(PackagingStationData).Name;
			}
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0005E8E8 File Offset: 0x0005CAE8
		public override void Load(string mainPath)
		{
			PackagingStationLoader.<>c__DisplayClass3_0 CS$<>8__locals1 = new PackagingStationLoader.<>c__DisplayClass3_0();
			GridItem gridItem = base.LoadAndCreate(mainPath);
			if (gridItem == null)
			{
				Console.LogWarning("Failed to load grid item", null);
				return;
			}
			CS$<>8__locals1.station = (gridItem as PackagingStation);
			if (CS$<>8__locals1.station == null)
			{
				Console.LogWarning("Failed to cast grid item to pot", null);
				return;
			}
			PackagingStationData data = base.GetData<PackagingStationData>(mainPath);
			if (data == null)
			{
				Console.LogWarning("Failed to load packaging station data data", null);
				return;
			}
			for (int i = 0; i < data.Contents.Items.Length; i++)
			{
				ItemInstance instance = ItemDeserializer.LoadItem(data.Contents.Items[i]);
				if (CS$<>8__locals1.station.ItemSlots.Count > i)
				{
					CS$<>8__locals1.station.ItemSlots[i].SetStoredItem(instance, false);
				}
			}
			CS$<>8__locals1.station.UpdatePackagingVisuals();
			CS$<>8__locals1.station.UpdateProductVisuals();
			string text;
			if (File.Exists(Path.Combine(mainPath, "Configuration.json")) && base.TryLoadFile(mainPath, "Configuration", out text))
			{
				CS$<>8__locals1.configData = JsonUtility.FromJson<PackagingStationConfigurationData>(text);
				if (CS$<>8__locals1.configData != null)
				{
					Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(CS$<>8__locals1.<Load>g__LoadConfiguration|0));
				}
			}
		}
	}
}
