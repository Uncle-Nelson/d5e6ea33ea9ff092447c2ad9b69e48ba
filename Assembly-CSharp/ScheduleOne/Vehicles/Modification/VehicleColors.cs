using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Vehicles.Modification
{
	// Token: 0x020007E6 RID: 2022
	public class VehicleColors : Singleton<VehicleColors>
	{
		// Token: 0x0600373C RID: 14140 RVA: 0x000E888C File Offset: 0x000E6A8C
		public string GetColorName(EVehicleColor c)
		{
			return this.colorLibrary.Find((VehicleColors.VehicleColorData x) => x.color == c).colorName;
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x000E88C4 File Offset: 0x000E6AC4
		public Color32 GetColorUIColor(EVehicleColor c)
		{
			return this.colorLibrary.Find((VehicleColors.VehicleColorData x) => x.color == c).UIColor;
		}

		// Token: 0x040027DF RID: 10207
		public List<VehicleColors.VehicleColorData> colorLibrary = new List<VehicleColors.VehicleColorData>();

		// Token: 0x020007E7 RID: 2023
		[Serializable]
		public class VehicleColorData
		{
			// Token: 0x040027E0 RID: 10208
			public EVehicleColor color;

			// Token: 0x040027E1 RID: 10209
			public string colorName;

			// Token: 0x040027E2 RID: 10210
			public Material material;

			// Token: 0x040027E3 RID: 10211
			public Color32 UIColor = Color.white;
		}
	}
}
