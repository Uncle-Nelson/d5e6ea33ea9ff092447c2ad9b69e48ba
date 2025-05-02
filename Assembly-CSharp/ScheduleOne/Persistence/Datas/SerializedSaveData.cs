using System;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000434 RID: 1076
	[Serializable]
	public class SerializedSaveData
	{
		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x000603A2 File Offset: 0x0005E5A2
		public string Version
		{
			get
			{
				return Application.version;
			}
		}

		// Token: 0x04001464 RID: 5220
		[NonSerialized]
		public static string _DataType;

		// Token: 0x04001465 RID: 5221
		public string DataType = SerializedSaveData._DataType;

		// Token: 0x04001466 RID: 5222
		[NonSerialized]
		public static int _DataVersion;

		// Token: 0x04001467 RID: 5223
		public int DataVersion = SerializedSaveData._DataVersion;
	}
}
