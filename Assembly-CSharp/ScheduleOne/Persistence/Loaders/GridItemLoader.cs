using System;
using ScheduleOne.Building;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003BE RID: 958
	public class GridItemLoader : BuildableItemLoader
	{
		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x0005E37E File Offset: 0x0005C57E
		public override string ItemType
		{
			get
			{
				return typeof(GridItemData).Name;
			}
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0005E397 File Offset: 0x0005C597
		public override void Load(string mainPath)
		{
			this.LoadAndCreate(mainPath);
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0005E3A4 File Offset: 0x0005C5A4
		protected GridItem LoadAndCreate(string mainPath)
		{
			string text;
			if (base.TryLoadFile(mainPath, "Data", out text))
			{
				GridItemData gridItemData = null;
				try
				{
					gridItemData = JsonUtility.FromJson<GridItemData>(text);
				}
				catch (Exception ex)
				{
					Type type = base.GetType();
					string str = (type != null) ? type.ToString() : null;
					string str2 = " error reading data: ";
					Exception ex2 = ex;
					Console.LogError(str + str2 + ((ex2 != null) ? ex2.ToString() : null), null);
				}
				if (gridItemData != null)
				{
					ItemInstance itemInstance = ItemDeserializer.LoadItem(gridItemData.ItemString);
					if (itemInstance == null)
					{
						return null;
					}
					Grid @object = GUIDManager.GetObject<Grid>(new Guid(gridItemData.GridGUID));
					if (@object == null)
					{
						Console.LogWarning("Failed to find grid for " + gridItemData.GridGUID, null);
						return null;
					}
					return Singleton<BuildManager>.Instance.CreateGridItem(itemInstance, @object, gridItemData.OriginCoordinate, gridItemData.Rotation, gridItemData.GUID);
				}
			}
			return null;
		}
	}
}
