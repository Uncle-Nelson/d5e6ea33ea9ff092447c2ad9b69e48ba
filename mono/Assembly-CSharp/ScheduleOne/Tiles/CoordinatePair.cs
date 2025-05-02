using System;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002B8 RID: 696
	public class CoordinatePair
	{
		// Token: 0x06000EE8 RID: 3816 RVA: 0x00041F33 File Offset: 0x00040133
		public CoordinatePair(Coordinate _c1, Coordinate _c2)
		{
			this.coord1 = _c1;
			this.coord2 = _c2;
		}

		// Token: 0x04000F55 RID: 3925
		public Coordinate coord1;

		// Token: 0x04000F56 RID: 3926
		public Coordinate coord2;
	}
}
