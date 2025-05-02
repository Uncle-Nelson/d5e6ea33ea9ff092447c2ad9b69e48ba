using System;
using UnityEngine;

namespace ScheduleOne.Noise
{
	// Token: 0x0200053A RID: 1338
	public class NoiseEvent
	{
		// Token: 0x060020A6 RID: 8358 RVA: 0x0008634F File Offset: 0x0008454F
		public NoiseEvent(Vector3 _origin, float _range, ENoiseType _type, GameObject _source = null)
		{
			this.origin = _origin;
			this.range = _range;
			this.type = _type;
			this.source = _source;
		}

		// Token: 0x04001935 RID: 6453
		public Vector3 origin;

		// Token: 0x04001936 RID: 6454
		public float range;

		// Token: 0x04001937 RID: 6455
		public ENoiseType type;

		// Token: 0x04001938 RID: 6456
		public GameObject source;
	}
}
