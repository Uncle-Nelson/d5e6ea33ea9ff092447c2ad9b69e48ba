using System;
using System.Collections.Generic;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002BD RID: 701
	public class ProceduralTile : MonoBehaviour
	{
		// Token: 0x06000F02 RID: 3842 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void Awake()
		{
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00042561 File Offset: 0x00040761
		public void AddOccupant(FootprintTile footprint, ProceduralGridItem item)
		{
			if (!this.Occupants.Contains(item))
			{
				this.Occupants.Add(item);
			}
			if (!this.OccupantTiles.Contains(footprint))
			{
				this.OccupantTiles.Add(footprint);
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00042597 File Offset: 0x00040797
		public void RemoveOccupant(FootprintTile footprint, ProceduralGridItem item)
		{
			if (this.Occupants.Contains(item))
			{
				this.Occupants.Remove(item);
			}
			if (this.OccupantTiles.Contains(footprint))
			{
				this.OccupantTiles.Remove(footprint);
			}
		}

		// Token: 0x04000F67 RID: 3943
		[Header("Settings")]
		public ProceduralTile.EProceduralTileType TileType;

		// Token: 0x04000F68 RID: 3944
		[Header("References")]
		public BuildableItem ParentBuildableItem;

		// Token: 0x04000F69 RID: 3945
		public FootprintTile MatchedFootprintTile;

		// Token: 0x04000F6A RID: 3946
		[Header("Occupants")]
		public List<ProceduralGridItem> Occupants = new List<ProceduralGridItem>();

		// Token: 0x04000F6B RID: 3947
		public List<FootprintTile> OccupantTiles = new List<FootprintTile>();

		// Token: 0x020002BE RID: 702
		public enum EProceduralTileType
		{
			// Token: 0x04000F6D RID: 3949
			Rack
		}
	}
}
