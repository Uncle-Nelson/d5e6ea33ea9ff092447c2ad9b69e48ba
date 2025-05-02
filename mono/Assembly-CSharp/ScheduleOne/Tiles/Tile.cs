using System;
using System.Collections.Generic;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.EntityFramework;
using ScheduleOne.Lighting;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002BF RID: 703
	[Serializable]
	public class Tile : MonoBehaviour
	{
		// Token: 0x06000F06 RID: 3846 RVA: 0x000425ED File Offset: 0x000407ED
		public void InitializePropertyTile(int _x, int _y, float _available_Offset, Grid _ownerGrid)
		{
			this.x = _x;
			this.y = _y;
			this.AvailableOffset = _available_Offset;
			this.OwnerGrid = _ownerGrid;
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0004260C File Offset: 0x0004080C
		public void AddOccupant(GridItem occ, FootprintTile tile)
		{
			this.BuildableOccupants.Remove(occ);
			this.BuildableOccupants.Add(occ);
			this.OccupantTiles.Remove(tile);
			this.OccupantTiles.Add(tile);
			if (this.onTileChanged != null)
			{
				this.onTileChanged(this);
			}
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00042660 File Offset: 0x00040860
		public void AddOccupant(Constructable_GridBased occ, FootprintTile tile)
		{
			this.ConstructableOccupants.Remove(occ);
			this.ConstructableOccupants.Add(occ);
			this.OccupantTiles.Remove(tile);
			this.OccupantTiles.Add(tile);
			if (this.onTileChanged != null)
			{
				this.onTileChanged(this);
			}
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x000426B3 File Offset: 0x000408B3
		public void RemoveOccupant(GridItem occ, FootprintTile tile)
		{
			this.BuildableOccupants.Remove(occ);
			this.OccupantTiles.Remove(tile);
			if (this.onTileChanged != null)
			{
				this.onTileChanged(this);
			}
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x000426E3 File Offset: 0x000408E3
		public void RemoveOccupant(Constructable_GridBased occ, FootprintTile tile)
		{
			this.ConstructableOccupants.Remove(occ);
			this.OccupantTiles.Remove(tile);
			if (this.onTileChanged != null)
			{
				this.onTileChanged(this);
			}
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00042713 File Offset: 0x00040913
		public virtual bool CanBeBuiltOn()
		{
			return !(this.OwnerGrid.GetComponentInParent<Property>() != null) || this.OwnerGrid.GetComponentInParent<Property>().IsOwned;
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00042740 File Offset: 0x00040940
		public List<Tile> GetSurroundingTiles()
		{
			List<Tile> list = new List<Tile>();
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Tile tile = this.OwnerGrid.GetTile(new Coordinate(this.x + i - 1, this.y + j - 1));
					if (tile != null && tile != this && !list.Contains(tile))
					{
						list.Add(tile);
					}
				}
			}
			return list;
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x000141BA File Offset: 0x000123BA
		public virtual bool IsIndoorTile()
		{
			return false;
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x000427B3 File Offset: 0x000409B3
		public void SetVisible(bool vis)
		{
			base.transform.Find("Model").gameObject.SetActive(vis);
		}

		// Token: 0x04000F6E RID: 3950
		public static float TileSize = 0.5f;

		// Token: 0x04000F6F RID: 3951
		public int x;

		// Token: 0x04000F70 RID: 3952
		public int y;

		// Token: 0x04000F71 RID: 3953
		[Header("Settings")]
		public float AvailableOffset = 1000f;

		// Token: 0x04000F72 RID: 3954
		[Header("References")]
		public Grid OwnerGrid;

		// Token: 0x04000F73 RID: 3955
		public LightExposureNode LightExposureNode;

		// Token: 0x04000F74 RID: 3956
		[Header("Occupants")]
		public List<GridItem> BuildableOccupants = new List<GridItem>();

		// Token: 0x04000F75 RID: 3957
		public List<Constructable_GridBased> ConstructableOccupants = new List<Constructable_GridBased>();

		// Token: 0x04000F76 RID: 3958
		public List<FootprintTile> OccupantTiles = new List<FootprintTile>();

		// Token: 0x04000F77 RID: 3959
		public Tile.TileChange onTileChanged;

		// Token: 0x020002C0 RID: 704
		// (Invoke) Token: 0x06000F12 RID: 3858
		public delegate void TileChange(Tile thisTile);
	}
}
