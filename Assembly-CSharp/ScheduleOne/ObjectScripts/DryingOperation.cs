using System;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BCE RID: 3022
	[Serializable]
	public class DryingOperation
	{
		// Token: 0x060052BA RID: 21178 RVA: 0x0015CA51 File Offset: 0x0015AC51
		public DryingOperation(string itemID, int quantity, EQuality startQuality, int time)
		{
			this.ItemID = itemID;
			this.Quantity = quantity;
			this.StartQuality = startQuality;
			this.Time = time;
		}

		// Token: 0x060052BB RID: 21179 RVA: 0x0000494F File Offset: 0x00002B4F
		public DryingOperation()
		{
		}

		// Token: 0x060052BC RID: 21180 RVA: 0x0015CA76 File Offset: 0x0015AC76
		public void IncreaseQuality()
		{
			this.StartQuality++;
			this.Time = 0;
		}

		// Token: 0x060052BD RID: 21181 RVA: 0x0015CA8D File Offset: 0x0015AC8D
		public QualityItemInstance GetQualityItemInstance()
		{
			QualityItemInstance qualityItemInstance = Registry.GetItem(this.ItemID).GetDefaultInstance(this.Quantity) as QualityItemInstance;
			qualityItemInstance.SetQuality(this.StartQuality);
			return qualityItemInstance;
		}

		// Token: 0x060052BE RID: 21182 RVA: 0x0015CAB6 File Offset: 0x0015ACB6
		public EQuality GetQuality()
		{
			if (this.Time >= 720)
			{
				return this.StartQuality + 1;
			}
			return this.StartQuality;
		}

		// Token: 0x04003DE9 RID: 15849
		public string ItemID;

		// Token: 0x04003DEA RID: 15850
		public int Quantity;

		// Token: 0x04003DEB RID: 15851
		public EQuality StartQuality;

		// Token: 0x04003DEC RID: 15852
		public int Time;
	}
}
