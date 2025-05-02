using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000110 RID: 272
	[Serializable]
	public class RaymarchingQuality
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00016F5E File Offset: 0x0001515E
		public int uniqueID
		{
			get
			{
				return this._UniqueID;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00016F66 File Offset: 0x00015166
		public bool hasValidUniqueID
		{
			get
			{
				return this._UniqueID >= 0;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00016F74 File Offset: 0x00015174
		public static RaymarchingQuality defaultInstance
		{
			get
			{
				return RaymarchingQuality.ms_DefaultInstance;
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00016F7B File Offset: 0x0001517B
		private RaymarchingQuality(int uniqueID)
		{
			this._UniqueID = uniqueID;
			this.name = "New quality";
			this.stepCount = 10;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00016F9D File Offset: 0x0001519D
		public static RaymarchingQuality New()
		{
			return new RaymarchingQuality(Random.Range(4, int.MaxValue));
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00016FAF File Offset: 0x000151AF
		public static RaymarchingQuality New(string name, int forcedUniqueID, int stepCount)
		{
			return new RaymarchingQuality(forcedUniqueID)
			{
				name = name,
				stepCount = stepCount
			};
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00016FC8 File Offset: 0x000151C8
		private static bool HasRaymarchingQualityWithSameUniqueID(RaymarchingQuality[] values, int id)
		{
			foreach (RaymarchingQuality raymarchingQuality in values)
			{
				if (raymarchingQuality != null && raymarchingQuality.uniqueID == id)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x040005EE RID: 1518
		public string name;

		// Token: 0x040005EF RID: 1519
		public int stepCount;

		// Token: 0x040005F0 RID: 1520
		[SerializeField]
		private int _UniqueID;

		// Token: 0x040005F1 RID: 1521
		private static RaymarchingQuality ms_DefaultInstance = new RaymarchingQuality(-1);

		// Token: 0x040005F2 RID: 1522
		private const int kRandomUniqueIdMinRange = 4;
	}
}
