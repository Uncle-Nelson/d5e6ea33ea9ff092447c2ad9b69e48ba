using System;
using UnityEngine;

namespace ScheduleOne.Properties.MixMaps
{
	// Token: 0x0200032E RID: 814
	[Serializable]
	public class MixerMapEffect
	{
		// Token: 0x060011E0 RID: 4576 RVA: 0x0004DE32 File Offset: 0x0004C032
		public bool IsPointInEffect(Vector2 point)
		{
			return Vector2.Distance(point, this.Position) < this.Radius;
		}

		// Token: 0x0400116B RID: 4459
		public Vector2 Position;

		// Token: 0x0400116C RID: 4460
		public float Radius;

		// Token: 0x0400116D RID: 4461
		public Property Property;
	}
}
