using System;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003D6 RID: 982
	[Serializable]
	public class FootprintMatchData
	{
		// Token: 0x0600153B RID: 5435 RVA: 0x0005F5BF File Offset: 0x0005D7BF
		public FootprintMatchData(string tileOwnerGUID, int tileIndex, Vector2 footprintCoordinate)
		{
			this.TileOwnerGUID = tileOwnerGUID;
			this.TileIndex = tileIndex;
			this.FootprintCoordinate = footprintCoordinate;
		}

		// Token: 0x04001381 RID: 4993
		public string TileOwnerGUID;

		// Token: 0x04001382 RID: 4994
		public int TileIndex;

		// Token: 0x04001383 RID: 4995
		public Vector2 FootprintCoordinate;
	}
}
