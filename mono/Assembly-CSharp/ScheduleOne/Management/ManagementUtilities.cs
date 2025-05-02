using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Management
{
	// Token: 0x02000584 RID: 1412
	public class ManagementUtilities : Singleton<ManagementUtilities>
	{
		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x000901D8 File Offset: 0x0008E3D8
		public static List<string> WeedSeedAssetPaths
		{
			get
			{
				return Singleton<ManagementUtilities>.Instance.weedSeedAssetPaths;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x000901E4 File Offset: 0x0008E3E4
		public static List<string> AdditiveAssetPaths
		{
			get
			{
				return Singleton<ManagementUtilities>.Instance.additiveAssetPaths;
			}
		}

		// Token: 0x04001A53 RID: 6739
		public List<string> weedSeedAssetPaths = new List<string>();

		// Token: 0x04001A54 RID: 6740
		public List<string> additiveAssetPaths = new List<string>();

		// Token: 0x04001A55 RID: 6741
		public List<AdditiveDefinition> AdditiveDefinitions = new List<AdditiveDefinition>();
	}
}
