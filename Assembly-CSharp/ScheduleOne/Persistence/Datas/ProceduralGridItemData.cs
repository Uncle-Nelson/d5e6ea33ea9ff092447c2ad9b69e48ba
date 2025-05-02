using System;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200041F RID: 1055
	[Serializable]
	public class ProceduralGridItemData : BuildableItemData
	{
		// Token: 0x06001594 RID: 5524 RVA: 0x00060024 File Offset: 0x0005E224
		public ProceduralGridItemData(Guid guid, ItemInstance item, int loadOrder, int rotation, FootprintMatchData[] footprintMatches) : base(guid, item, loadOrder)
		{
			this.Rotation = rotation;
			this.FootprintMatches = footprintMatches;
		}

		// Token: 0x04001428 RID: 5160
		public int Rotation;

		// Token: 0x04001429 RID: 5161
		public FootprintMatchData[] FootprintMatches;
	}
}
