using System;
using System.Collections.Generic;
using ScheduleOne.Building;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003C8 RID: 968
	public class ProceduralGridItemLoader : BuildableItemLoader
	{
		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x0005EC71 File Offset: 0x0005CE71
		public override string ItemType
		{
			get
			{
				return typeof(ProceduralGridItemData).Name;
			}
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0005EC82 File Offset: 0x0005CE82
		public override void Load(string mainPath)
		{
			this.LoadAndCreate(mainPath);
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0005EC8C File Offset: 0x0005CE8C
		protected ProceduralGridItem LoadAndCreate(string mainPath)
		{
			string text;
			if (base.TryLoadFile(mainPath, "Data", out text))
			{
				ProceduralGridItemData proceduralGridItemData = null;
				try
				{
					proceduralGridItemData = JsonUtility.FromJson<ProceduralGridItemData>(text);
				}
				catch (Exception ex)
				{
					Type type = base.GetType();
					string str = (type != null) ? type.ToString() : null;
					string str2 = " error reading data: ";
					Exception ex2 = ex;
					Console.LogError(str + str2 + ((ex2 != null) ? ex2.ToString() : null), null);
				}
				if (proceduralGridItemData != null)
				{
					ItemInstance itemInstance = ItemDeserializer.LoadItem(proceduralGridItemData.ItemString);
					if (itemInstance == null)
					{
						return null;
					}
					List<CoordinateProceduralTilePair> list = new List<CoordinateProceduralTilePair>();
					for (int i = 0; i < proceduralGridItemData.FootprintMatches.Length; i++)
					{
						CoordinateProceduralTilePair item = default(CoordinateProceduralTilePair);
						item.coord = new Coordinate(Mathf.RoundToInt(proceduralGridItemData.FootprintMatches[i].FootprintCoordinate.x), Mathf.RoundToInt(proceduralGridItemData.FootprintMatches[i].FootprintCoordinate.y));
						item.tileIndex = proceduralGridItemData.FootprintMatches[i].TileIndex;
						BuildableItem @object = GUIDManager.GetObject<BuildableItem>(new Guid(proceduralGridItemData.FootprintMatches[i].TileOwnerGUID));
						if (@object == null)
						{
							Debug.LogError("Failed to find tile parent for " + proceduralGridItemData.FootprintMatches[i].TileOwnerGUID);
							return null;
						}
						item.tileParent = @object.NetworkObject;
						list.Add(item);
					}
					return Singleton<BuildManager>.Instance.CreateProceduralGridItem(itemInstance, proceduralGridItemData.Rotation, list, proceduralGridItemData.GUID);
				}
			}
			return null;
		}
	}
}
