using System;
using System.Collections;
using System.Collections.Generic;
using ScheduleOne.Employees;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008A1 RID: 2209
	public interface IStorageEntity
	{
		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06003BA0 RID: 15264
		Transform storedItemContainer { get; }

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06003BA1 RID: 15265
		Dictionary<StoredItem, Employee> reservedItems { get; }

		// Token: 0x06003BA2 RID: 15266
		List<StoredItem> GetStoredItems();

		// Token: 0x06003BA3 RID: 15267
		List<StorageGrid> GetStorageGrids();

		// Token: 0x06003BA4 RID: 15268 RVA: 0x000FACB0 File Offset: 0x000F8EB0
		List<StoredItem> GetStoredItemsByID(string ID)
		{
			List<StoredItem> storedItems = this.GetStoredItems();
			List<StoredItem> list = new List<StoredItem>();
			for (int i = 0; i < storedItems.Count; i++)
			{
				if (storedItems[i].item.ID == ID)
				{
					list.Add(storedItems[i]);
				}
			}
			return list;
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x000FAD04 File Offset: 0x000F8F04
		void ReserveItem(StoredItem item, Employee employee)
		{
			if (this.IsItemReserved(item))
			{
				if (this.reservedItems[item] != employee)
				{
					Console.LogWarning("Item already reserved by someone else!", null);
				}
				return;
			}
			this.reservedItems.Add(item, employee);
			(this as MonoBehaviour).StartCoroutine(this.ClearReserve(item));
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x000FAD5A File Offset: 0x000F8F5A
		void DereserveItem(StoredItem item)
		{
			if (this.reservedItems.ContainsKey(item))
			{
				this.reservedItems.Remove(item);
			}
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x000FAD77 File Offset: 0x000F8F77
		bool IsItemReserved(StoredItem item)
		{
			return this.reservedItems.ContainsKey(item);
		}

		// Token: 0x06003BA8 RID: 15272 RVA: 0x000FAD85 File Offset: 0x000F8F85
		Employee WhoIsReserving(StoredItem item)
		{
			if (this.reservedItems.ContainsKey(item))
			{
				return this.reservedItems[item];
			}
			return null;
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x000FADA4 File Offset: 0x000F8FA4
		List<StoredItem> GetNonReservedItemsByPrefabID(string prefabID, Employee whosAskin)
		{
			List<StoredItem> storedItemsByID = this.GetStoredItemsByID(prefabID);
			List<StoredItem> list = new List<StoredItem>();
			for (int i = 0; i < storedItemsByID.Count; i++)
			{
				Employee x = this.WhoIsReserving(storedItemsByID[i]);
				if (x == null || x == whosAskin)
				{
					list.Add(storedItemsByID[i]);
				}
			}
			return list;
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x000FADFE File Offset: 0x000F8FFE
		IEnumerator ClearReserve(StoredItem item)
		{
			yield return new WaitForSeconds(60f);
			if (item != null)
			{
				this.DereserveItem(item);
			}
			yield break;
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x000FAE14 File Offset: 0x000F9014
		bool TryFitItem(int sizeX, int sizeY, out StorageGrid grid, out Coordinate originCoordinate, out float rotation)
		{
			grid = null;
			originCoordinate = new Coordinate(0, 0);
			rotation = 0f;
			List<StorageGrid> storageGrids = this.GetStorageGrids();
			for (int i = 0; i < storageGrids.Count; i++)
			{
				grid = storageGrids[i];
				if (storageGrids[i].TryFitItem(sizeX, sizeY, new List<Coordinate>(), out originCoordinate, out rotation))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x000FAE74 File Offset: 0x000F9074
		int HowManyCanFit(int sizeX, int sizeY, int limit = 2147483647)
		{
			int num = 0;
			List<StorageGrid> storageGrids = this.GetStorageGrids();
			for (int i = 0; i < storageGrids.Count; i++)
			{
				List<Coordinate> list = new List<Coordinate>();
				Coordinate originCoord;
				float rot;
				while (storageGrids[i].TryFitItem(sizeX, sizeY, list, out originCoord, out rot) && num < limit)
				{
					num++;
					List<CoordinatePair> list2 = Coordinate.BuildCoordinateMatches(originCoord, sizeX, sizeY, rot);
					for (int j = 0; j < list2.Count; j++)
					{
						list.Add(list2[i].coord2);
					}
				}
			}
			return num;
		}
	}
}
