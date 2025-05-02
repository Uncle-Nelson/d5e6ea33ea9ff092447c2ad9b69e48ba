using System;
using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.EntityFramework;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002BA RID: 698
	public class Grid : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x000420EB File Offset: 0x000402EB
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x000420F3 File Offset: 0x000402F3
		public Guid GUID { get; protected set; }

		// Token: 0x06000EF1 RID: 3825 RVA: 0x000420FC File Offset: 0x000402FC
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0004210C File Offset: 0x0004030C
		protected virtual void Awake()
		{
			if (this.IsStatic)
			{
				if (!GUIDManager.IsGUIDValid(this.StaticGUID))
				{
					Console.LogError("Static GUID is not valid.", null);
				}
				((IGUIDRegisterable)this).SetGUID(this.StaticGUID);
			}
			if (base.GetComponentInParent<Property>() != null && !this.IsStatic)
			{
				Debug.LogWarning("Grid is a child of a Property, but is not marked as static!");
			}
			this.SetInvisible();
			this.ProcessCoordinateDataPairs();
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00042174 File Offset: 0x00040374
		public virtual void DestroyGrid()
		{
			GridItem[] componentsInChildren = this.Container.GetComponentsInChildren<GridItem>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].DestroyItem(true);
			}
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x000421A4 File Offset: 0x000403A4
		private void ProcessCoordinateDataPairs()
		{
			foreach (CoordinateTilePair coordinateTilePair in this.CoordinateTilePairs)
			{
				this._coordinateToTile.Add(coordinateTilePair.coord, coordinateTilePair.tile);
			}
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00042208 File Offset: 0x00040408
		public void RegisterTile(Tile tile)
		{
			this.Tiles.Add(tile);
			CoordinateTilePair item = default(CoordinateTilePair);
			item.coord = new Coordinate(tile.x, tile.y);
			item.tile = tile;
			this.CoordinateTilePairs.Add(item);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00042258 File Offset: 0x00040458
		public void DeregisterTile(Tile tile)
		{
			Console.Log("Deregistering tile: " + tile.x.ToString() + ", " + tile.y.ToString(), null);
			this.Tiles.Remove(tile);
			for (int i = 0; i < this.CoordinateTilePairs.Count; i++)
			{
				if (this.CoordinateTilePairs[i].tile == tile)
				{
					this.CoordinateTilePairs.RemoveAt(i);
					i--;
					return;
				}
			}
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x000422E0 File Offset: 0x000404E0
		public Coordinate GetMatchedCoordinate(FootprintTile tileToMatch)
		{
			Vector3 vector = base.transform.InverseTransformPoint(tileToMatch.transform.position);
			return new Coordinate(Mathf.RoundToInt(vector.x / Grid.GridSideLength), Mathf.RoundToInt(vector.z / Grid.GridSideLength));
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0004232C File Offset: 0x0004052C
		public bool IsTileValidAtCoordinate(Coordinate gridCoord, FootprintTile tile, GridItem tileOwner = null)
		{
			if (!this._coordinateToTile.ContainsKey(gridCoord))
			{
				return false;
			}
			Tile tile2 = this._coordinateToTile[gridCoord];
			return tile2.ConstructableOccupants.Count <= 0 && (tile2.BuildableOccupants.Count <= 0 || (!(tileOwner == null) && tileOwner.CanShareTileWith(tile2.BuildableOccupants))) && (tile2.AvailableOffset == 0f || tile.RequiredOffset == 0f || tile2.AvailableOffset >= tile.RequiredOffset) && tile2.CanBeBuiltOn();
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x000423C0 File Offset: 0x000405C0
		public bool IsTileValidAtCoordinate(Coordinate gridCoord, FootprintTile tile, Constructable_GridBased ignoreConstructable)
		{
			if (!this._coordinateToTile.ContainsKey(gridCoord))
			{
				return false;
			}
			Tile tile2 = this._coordinateToTile[gridCoord];
			if (tile2.BuildableOccupants.Count > 0)
			{
				return false;
			}
			for (int i = 0; i < tile2.ConstructableOccupants.Count; i++)
			{
				if (tile2.ConstructableOccupants[i] != ignoreConstructable)
				{
					return false;
				}
			}
			return (tile2.AvailableOffset == 0f || tile.RequiredOffset == 0f || tile2.AvailableOffset >= tile.RequiredOffset) && tile2.CanBeBuiltOn();
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00042458 File Offset: 0x00040658
		public Tile GetTile(Coordinate coord)
		{
			return this.CoordinateTilePairs.Find((CoordinateTilePair x) => x.coord.Equals(coord)).tile;
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00042490 File Offset: 0x00040690
		[Button]
		public void SetVisible()
		{
			for (int i = 0; i < this.CoordinateTilePairs.Count; i++)
			{
				this.CoordinateTilePairs[i].tile.SetVisible(true);
			}
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x000424CC File Offset: 0x000406CC
		[Button]
		public void SetInvisible()
		{
			for (int i = 0; i < this.CoordinateTilePairs.Count; i++)
			{
				this.CoordinateTilePairs[i].tile.SetVisible(false);
			}
		}

		// Token: 0x04000F5E RID: 3934
		public static float GridSideLength = 0.5f;

		// Token: 0x04000F5F RID: 3935
		public List<Tile> Tiles = new List<Tile>();

		// Token: 0x04000F60 RID: 3936
		public List<CoordinateTilePair> CoordinateTilePairs = new List<CoordinateTilePair>();

		// Token: 0x04000F61 RID: 3937
		public Transform Container;

		// Token: 0x04000F62 RID: 3938
		public bool IsStatic;

		// Token: 0x04000F63 RID: 3939
		public string StaticGUID = string.Empty;

		// Token: 0x04000F65 RID: 3941
		protected Dictionary<Coordinate, Tile> _coordinateToTile = new Dictionary<Coordinate, Tile>();
	}
}
