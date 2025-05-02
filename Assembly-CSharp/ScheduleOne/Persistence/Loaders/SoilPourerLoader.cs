using System;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003C9 RID: 969
	public class SoilPourerLoader : GridItemLoader
	{
		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x0005EE04 File Offset: 0x0005D004
		public override string ItemType
		{
			get
			{
				return typeof(SoilPourerData).Name;
			}
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0005EE18 File Offset: 0x0005D018
		public override void Load(string mainPath)
		{
			GridItem gridItem = base.LoadAndCreate(mainPath);
			if (gridItem == null)
			{
				Console.LogWarning("Failed to load grid item", null);
				return;
			}
			SoilPourerData data = base.GetData<SoilPourerData>(mainPath);
			if (data == null)
			{
				Console.LogWarning("Failed to load toggleableitem data", null);
				return;
			}
			SoilPourer soilPourer = gridItem as SoilPourer;
			if (soilPourer != null)
			{
				soilPourer.SendSoil(data.SoilID);
			}
		}
	}
}
