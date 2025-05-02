using System;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000403 RID: 1027
	[Serializable]
	public class QualityFieldData
	{
		// Token: 0x06001577 RID: 5495 RVA: 0x0005FAC8 File Offset: 0x0005DCC8
		public QualityFieldData(EQuality value)
		{
			this.Value = value;
		}

		// Token: 0x040013CB RID: 5067
		public EQuality Value;
	}
}
