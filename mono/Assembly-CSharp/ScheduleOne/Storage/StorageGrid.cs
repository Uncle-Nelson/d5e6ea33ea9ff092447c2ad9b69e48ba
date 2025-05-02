using System;
using System.Collections.Generic;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008AE RID: 2222
	public class StorageGrid : MonoBehaviour
	{
		// Token: 0x06003C56 RID: 15446 RVA: 0x000FE3FC File Offset: 0x000FC5FC
		protected virtual void Awake()
		{
			this.ProcessCoordinateTilePairs();
			this.freeTiles.AddRange(this.storageTiles);
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x000FE418 File Offset: 0x000FC618
		private void ProcessCoordinateTilePairs()
		{
			foreach (CoordinateStorageTilePair coordinateStorageTilePair in this.coordinateStorageTilePairs)
			{
				this.coordinateToTile.Add(coordinateStorageTilePair.coord, coordinateStorageTilePair.tile);
			}
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x000FE47C File Offset: 0x000FC67C
		public void RegisterTile(StorageTile tile)
		{
			this.storageTiles.Add(tile);
			CoordinateStorageTilePair item = default(CoordinateStorageTilePair);
			item.coord = new Coordinate(tile.x, tile.y);
			item.tile = tile;
			this.coordinateStorageTilePairs.Add(item);
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x000FE4CC File Offset: 0x000FC6CC
		public void DeregisterTile(StorageTile tile)
		{
			this.storageTiles.Remove(tile);
			for (int i = 0; i < this.coordinateStorageTilePairs.Count; i++)
			{
				if (this.coordinateStorageTilePairs[i].tile == tile)
				{
					this.coordinateStorageTilePairs.RemoveAt(i);
					i--;
					return;
				}
			}
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x000FE528 File Offset: 0x000FC728
		public bool IsItemPositionValid(StorageTile primaryTile, FootprintTile primaryFootprintTile, StoredItem item)
		{
			foreach (CoordinateStorageFootprintTilePair coordinateStorageFootprintTilePair in item.CoordinateFootprintTilePairs)
			{
				Coordinate matchedCoordinate = this.GetMatchedCoordinate(coordinateStorageFootprintTilePair.tile);
				if (!this.IsGridPositionValid(matchedCoordinate, coordinateStorageFootprintTilePair.tile))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x000FE598 File Offset: 0x000FC798
		public Coordinate GetMatchedCoordinate(FootprintTile tileToMatch)
		{
			Vector3 vector = base.transform.InverseTransformPoint(tileToMatch.transform.position);
			return new Coordinate(Mathf.RoundToInt(vector.x / StorageGrid.gridSize), Mathf.RoundToInt(vector.z / StorageGrid.gridSize));
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x000FE5E3 File Offset: 0x000FC7E3
		public bool IsGridPositionValid(Coordinate gridCoord, FootprintTile tile)
		{
			return this.coordinateToTile.ContainsKey(gridCoord) && !(this.coordinateToTile[gridCoord].occupant != null);
		}

		// Token: 0x06003C5D RID: 15453 RVA: 0x000FE614 File Offset: 0x000FC814
		public StorageTile GetTile(Coordinate coord)
		{
			for (int i = 0; i < this.coordinateStorageTilePairs.Count; i++)
			{
				if (this.coordinateStorageTilePairs[i].coord.Equals(coord))
				{
					return this.coordinateStorageTilePairs[i].tile;
				}
			}
			return null;
		}

		// Token: 0x06003C5E RID: 15454 RVA: 0x000FE664 File Offset: 0x000FC864
		public int GetUserEndCapacity()
		{
			int actualY = this.GetActualY();
			int num = this.coordinateStorageTilePairs.Count / actualY;
			return (actualY - 1) * (num - 1);
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x000FE690 File Offset: 0x000FC890
		public int GetActualY()
		{
			int result = 0;
			for (int i = 0; i < this.coordinateStorageTilePairs.Count; i++)
			{
				if (this.coordinateStorageTilePairs[i].coord.x != 0)
				{
					result = i;
					break;
				}
				i++;
			}
			return result;
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x000FE6D8 File Offset: 0x000FC8D8
		public int GetActualX()
		{
			return this.coordinateStorageTilePairs.Count / this.GetActualY();
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x000FE6EC File Offset: 0x000FC8EC
		public int GetTotalFootprintSize()
		{
			return this.coordinateStorageTilePairs.Count;
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x000FE6FC File Offset: 0x000FC8FC
		public bool TryFitItem(int sizeX, int sizeY, List<Coordinate> lockedCoordinates, out Coordinate originCoordinate, out float rotation)
		{
			foreach (CoordinateStorageTilePair coordinateStorageTilePair in this.coordinateStorageTilePairs)
			{
				if (!(coordinateStorageTilePair.tile.occupant != null))
				{
					originCoordinate = coordinateStorageTilePair.coord;
					bool flag = true;
					rotation = 0f;
					for (int i = 0; i < sizeX; i++)
					{
						for (int j = 0; j < sizeY; j++)
						{
							Coordinate coordinate = new Coordinate(coordinateStorageTilePair.tile.x + i, coordinateStorageTilePair.tile.y + j);
							for (int k = 0; k < lockedCoordinates.Count; k++)
							{
								if (coordinate.Equals(lockedCoordinates[k]))
								{
									flag = false;
								}
							}
							StorageTile tile = this.GetTile(coordinate);
							if (tile == null || tile.occupant != null)
							{
								flag = false;
							}
						}
					}
					if (flag)
					{
						return true;
					}
					flag = true;
					rotation = 90f;
					for (int l = 0; l < sizeX; l++)
					{
						for (int m = 0; m < sizeY; m++)
						{
							Coordinate coordinate2 = new Coordinate(coordinateStorageTilePair.tile.x + m, coordinateStorageTilePair.tile.y - l);
							for (int n = 0; n < lockedCoordinates.Count; n++)
							{
								if (coordinate2.Equals(lockedCoordinates[n]))
								{
									flag = false;
								}
							}
							StorageTile tile2 = this.GetTile(coordinate2);
							if (tile2 == null || tile2.occupant != null)
							{
								flag = false;
							}
						}
					}
					if (flag)
					{
						return true;
					}
				}
			}
			originCoordinate = new Coordinate(0, 0);
			rotation = 0f;
			return false;
		}

		// Token: 0x04002B6C RID: 11116
		public static float gridSize = 0.25f;

		// Token: 0x04002B6D RID: 11117
		public List<StorageTile> storageTiles = new List<StorageTile>();

		// Token: 0x04002B6E RID: 11118
		public List<StorageTile> freeTiles = new List<StorageTile>();

		// Token: 0x04002B6F RID: 11119
		public List<CoordinateStorageTilePair> coordinateStorageTilePairs = new List<CoordinateStorageTilePair>();

		// Token: 0x04002B70 RID: 11120
		protected Dictionary<Coordinate, StorageTile> coordinateToTile = new Dictionary<Coordinate, StorageTile>();
	}
}
