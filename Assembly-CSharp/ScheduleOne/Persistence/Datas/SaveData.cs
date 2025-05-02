using System;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000433 RID: 1075
	[Serializable]
	public class SaveData
	{
		// Token: 0x060015AA RID: 5546 RVA: 0x00060314 File Offset: 0x0005E514
		public SaveData()
		{
			this.DataType = base.GetType().Name;
			this.DataVersion = this.GetDataVersion();
			this.GameVersion = Application.version;
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x000141BA File Offset: 0x000123BA
		protected virtual int GetDataVersion()
		{
			return 0;
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00060365 File Offset: 0x0005E565
		public virtual string GetJson(bool prettyPrint = true)
		{
			if (this.DataType == string.Empty)
			{
				Type type = base.GetType();
				Console.LogError(((type != null) ? type.ToString() : null) + " GetJson() called but has no data type set!", null);
			}
			return JsonUtility.ToJson(this, prettyPrint);
		}

		// Token: 0x04001461 RID: 5217
		public string DataType = string.Empty;

		// Token: 0x04001462 RID: 5218
		public int DataVersion;

		// Token: 0x04001463 RID: 5219
		public string GameVersion = string.Empty;
	}
}
