using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002C4 RID: 708
	public class TileDetector : MonoBehaviour
	{
		// Token: 0x06000F19 RID: 3865 RVA: 0x00042884 File Offset: 0x00040A84
		public virtual void CheckIntersections(bool sort = true)
		{
			this.intersectedTiles.Clear();
			this.intersectedOutdoorTiles.Clear();
			this.intersectedIndoorTiles.Clear();
			this.intersectedStorageTiles.Clear();
			this.intersectedProceduralTiles.Clear();
			LayerMask mask = default(LayerMask) | 1 << LayerMask.NameToLayer("Tile");
			Collider[] array = Physics.OverlapSphere(base.transform.position, this.detectionRadius, mask);
			for (int i = 0; i < array.Length; i++)
			{
				if (this.tileDetectionMode == ETileDetectionMode.Tile)
				{
					Tile componentInParent = array[i].GetComponentInParent<Tile>();
					if (componentInParent != null && !this.intersectedTiles.Contains(componentInParent))
					{
						this.intersectedTiles.Add(componentInParent);
					}
				}
				if (this.tileDetectionMode == ETileDetectionMode.OutdoorTile)
				{
					Tile componentInParent2 = array[i].GetComponentInParent<Tile>();
					if (componentInParent2 != null && !(componentInParent2 is IndoorTile) && !this.intersectedOutdoorTiles.Contains(componentInParent2))
					{
						this.intersectedOutdoorTiles.Add(componentInParent2);
					}
				}
				if (this.tileDetectionMode == ETileDetectionMode.IndoorTile)
				{
					IndoorTile componentInParent3 = array[i].GetComponentInParent<IndoorTile>();
					if (componentInParent3 != null && !this.intersectedIndoorTiles.Contains(componentInParent3))
					{
						this.intersectedIndoorTiles.Add(componentInParent3);
					}
				}
				if (this.tileDetectionMode == ETileDetectionMode.StorageTile)
				{
					StorageTile componentInParent4 = array[i].GetComponentInParent<StorageTile>();
					if (componentInParent4 != null && !this.intersectedStorageTiles.Contains(componentInParent4))
					{
						this.intersectedStorageTiles.Add(componentInParent4);
					}
				}
				if (this.tileDetectionMode == ETileDetectionMode.ProceduralTile)
				{
					ProceduralTile componentInParent5 = array[i].GetComponentInParent<ProceduralTile>();
					if (componentInParent5 != null && !this.intersectedProceduralTiles.Contains(componentInParent5))
					{
						this.intersectedProceduralTiles.Add(componentInParent5);
					}
				}
			}
			if (sort)
			{
				this.intersectedTiles = this.OrderList<Tile>(this.intersectedTiles);
				this.intersectedOutdoorTiles = this.OrderList<Tile>(this.intersectedOutdoorTiles);
				this.intersectedIndoorTiles = this.OrderList<Tile>(this.intersectedIndoorTiles);
				this.intersectedStorageTiles = this.OrderList<StorageTile>(this.intersectedStorageTiles);
				this.intersectedProceduralTiles = this.OrderList<ProceduralTile>(this.intersectedProceduralTiles);
			}
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00042A9B File Offset: 0x00040C9B
		public List<T> OrderList<T>(List<T> list) where T : MonoBehaviour
		{
			return (from x in list
			orderby Vector3.Distance(x.transform.position, base.transform.position)
			select x).ToList<T>();
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00042AB4 File Offset: 0x00040CB4
		public Tile GetClosestTile()
		{
			Tile result = null;
			float num = 100f;
			for (int i = 0; i < this.intersectedTiles.Count; i++)
			{
				if (Vector3.Distance(this.intersectedTiles[i].transform.position, base.transform.position) < num)
				{
					result = this.intersectedTiles[i];
					num = Vector3.Distance(this.intersectedTiles[i].transform.position, base.transform.position);
				}
			}
			return result;
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00042B40 File Offset: 0x00040D40
		public ProceduralTile GetClosestProceduralTile()
		{
			ProceduralTile result = null;
			float num = 100f;
			for (int i = 0; i < this.intersectedProceduralTiles.Count; i++)
			{
				if (Vector3.Distance(this.intersectedProceduralTiles[i].transform.position, base.transform.position) < num)
				{
					result = this.intersectedProceduralTiles[i];
					num = Vector3.Distance(this.intersectedProceduralTiles[i].transform.position, base.transform.position);
				}
			}
			return result;
		}

		// Token: 0x04000F86 RID: 3974
		public float detectionRadius = 0.25f;

		// Token: 0x04000F87 RID: 3975
		public ETileDetectionMode tileDetectionMode;

		// Token: 0x04000F88 RID: 3976
		public List<Tile> intersectedTiles = new List<Tile>();

		// Token: 0x04000F89 RID: 3977
		public List<Tile> intersectedOutdoorTiles = new List<Tile>();

		// Token: 0x04000F8A RID: 3978
		public List<Tile> intersectedIndoorTiles = new List<Tile>();

		// Token: 0x04000F8B RID: 3979
		public List<StorageTile> intersectedStorageTiles = new List<StorageTile>();

		// Token: 0x04000F8C RID: 3980
		public List<ProceduralTile> intersectedProceduralTiles = new List<ProceduralTile>();
	}
}
