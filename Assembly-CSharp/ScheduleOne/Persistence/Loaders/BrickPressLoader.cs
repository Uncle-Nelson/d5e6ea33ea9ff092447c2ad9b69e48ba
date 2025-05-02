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
	// Token: 0x020003B5 RID: 949
	public class BrickPressLoader : GridItemLoader
	{
		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x0005DB23 File Offset: 0x0005BD23
		public override string ItemType
		{
			get
			{
				return typeof(BrickPressData).Name;
			}
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0005DB3C File Offset: 0x0005BD3C
		public override void Load(string mainPath)
		{
			BrickPressLoader.<>c__DisplayClass3_0 CS$<>8__locals1 = new BrickPressLoader.<>c__DisplayClass3_0();
			GridItem gridItem = base.LoadAndCreate(mainPath);
			if (gridItem == null)
			{
				Console.LogWarning("Failed to load grid item", null);
				return;
			}
			CS$<>8__locals1.brickPress = (gridItem as BrickPress);
			if (CS$<>8__locals1.brickPress == null)
			{
				Console.LogWarning("Failed to cast grid item to brick press", null);
				return;
			}
			BrickPressData data = base.GetData<BrickPressData>(mainPath);
			if (data == null)
			{
				Console.LogWarning("Failed to load brick press data", null);
				return;
			}
			for (int i = 0; i < data.Contents.Items.Length; i++)
			{
				ItemInstance instance = ItemDeserializer.LoadItem(data.Contents.Items[i]);
				if (CS$<>8__locals1.brickPress.ItemSlots.Count > i)
				{
					CS$<>8__locals1.brickPress.ItemSlots[i].SetStoredItem(instance, false);
				}
			}
			string text;
			if (File.Exists(Path.Combine(mainPath, "Configuration.json")) && base.TryLoadFile(mainPath, "Configuration", out text))
			{
				CS$<>8__locals1.configData = JsonUtility.FromJson<BrickPressConfigurationData>(text);
				if (CS$<>8__locals1.configData != null)
				{
					Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(CS$<>8__locals1.<Load>g__LoadConfiguration|0));
				}
			}
		}
	}
}
