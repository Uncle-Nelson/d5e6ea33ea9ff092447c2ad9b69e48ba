using System;
using FishNet.Object;
using ScheduleOne.EntityFramework;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002B6 RID: 694
	[Serializable]
	public struct CoordinateProceduralTilePair
	{
		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00041F16 File Offset: 0x00040116
		public ProceduralTile tile
		{
			get
			{
				return this.tileParent.GetComponent<IProceduralTileContainer>().ProceduralTiles[this.tileIndex];
			}
		}

		// Token: 0x04000F50 RID: 3920
		public Coordinate coord;

		// Token: 0x04000F51 RID: 3921
		public NetworkObject tileParent;

		// Token: 0x04000F52 RID: 3922
		public int tileIndex;
	}
}
