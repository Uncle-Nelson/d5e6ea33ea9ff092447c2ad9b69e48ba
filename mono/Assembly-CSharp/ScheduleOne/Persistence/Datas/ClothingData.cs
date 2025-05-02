using System;
using ScheduleOne.Clothing;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003E3 RID: 995
	[Serializable]
	public class ClothingData : ItemData
	{
		// Token: 0x06001556 RID: 5462 RVA: 0x0005F87A File Offset: 0x0005DA7A
		public ClothingData(string iD, int quantity, EClothingColor color) : base(iD, quantity)
		{
			this.Color = color;
		}

		// Token: 0x0400139B RID: 5019
		public EClothingColor Color;
	}
}
