using System;
using System.Collections.Generic;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x02000794 RID: 1940
	public class CornerObstacle : MonoBehaviour
	{
		// Token: 0x060034D7 RID: 13527 RVA: 0x000DE4C4 File Offset: 0x000DC6C4
		public List<Tile> GetNeighbourTiles(Tile pairedTile)
		{
			List<Tile> list = new List<Tile>();
			List<Tile> surroundingTiles = pairedTile.GetSurroundingTiles();
			surroundingTiles.Add(pairedTile);
			for (int i = 0; i < surroundingTiles.Count; i++)
			{
				if (Vector3.Distance(surroundingTiles[i].transform.position, base.transform.position) < 0.5f)
				{
					list.Add(surroundingTiles[i]);
				}
			}
			return list;
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x000DE52C File Offset: 0x000DC72C
		private bool ApproxEquals(float a, float b, float precision)
		{
			return Mathf.Abs(a - b) <= precision;
		}

		// Token: 0x040025BE RID: 9662
		public bool obstacleEnabled;

		// Token: 0x040025BF RID: 9663
		public FootprintTile parentFootprint;

		// Token: 0x040025C0 RID: 9664
		public Vector2 coordinates = Vector2.zero;
	}
}
