using System;
using System.Collections.Generic;
using ScheduleOne.Building;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002B9 RID: 697
	public class FootprintTile : MonoBehaviour
	{
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00041F49 File Offset: 0x00040149
		// (set) Token: 0x06000EEA RID: 3818 RVA: 0x00041F51 File Offset: 0x00040151
		public Tile MatchedStandardTile { get; protected set; }

		// Token: 0x06000EEB RID: 3819 RVA: 0x00041F5A File Offset: 0x0004015A
		protected virtual void Awake()
		{
			this.tileAppearance.SetVisible(false);
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00041F68 File Offset: 0x00040168
		public virtual void Initialize(Tile matchedTile)
		{
			this.MatchedStandardTile = matchedTile;
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00041F74 File Offset: 0x00040174
		public bool AreCornerObstaclesBlocked(Tile proposedTile)
		{
			if (proposedTile == null)
			{
				return true;
			}
			for (int i = 0; i < this.Corners.Count; i++)
			{
				if (this.Corners[i].obstacleEnabled)
				{
					List<Tile> neighbourTiles = this.Corners[i].GetNeighbourTiles(proposedTile);
					if (neighbourTiles.Count >= 4)
					{
						Dictionary<GridItem, int> dictionary = new Dictionary<GridItem, int>();
						for (int j = 0; j < neighbourTiles.Count; j++)
						{
							for (int k = 0; k < neighbourTiles[j].BuildableOccupants.Count; k++)
							{
								if (!dictionary.ContainsKey(neighbourTiles[j].BuildableOccupants[k]))
								{
									dictionary.Add(neighbourTiles[j].BuildableOccupants[k], 1);
								}
								else
								{
									Dictionary<GridItem, int> dictionary2 = dictionary;
									GridItem key = neighbourTiles[j].BuildableOccupants[k];
									int num = dictionary2[key];
									dictionary2[key] = num + 1;
								}
							}
						}
						foreach (GridItem key2 in dictionary.Keys)
						{
							if (dictionary[key2] == neighbourTiles.Count)
							{
								return true;
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x04000F57 RID: 3927
		public TileAppearance tileAppearance;

		// Token: 0x04000F58 RID: 3928
		public TileDetector tileDetector;

		// Token: 0x04000F59 RID: 3929
		public int X;

		// Token: 0x04000F5A RID: 3930
		public int Y;

		// Token: 0x04000F5B RID: 3931
		public float RequiredOffset;

		// Token: 0x04000F5C RID: 3932
		public List<CornerObstacle> Corners = new List<CornerObstacle>();
	}
}
