using System;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x020005AC RID: 1452
	public class UsableLightSource : MonoBehaviour
	{
		// Token: 0x04001AD8 RID: 6872
		[Range(0.5f, 2f)]
		public float GrowSpeedMultiplier = 1f;

		// Token: 0x04001AD9 RID: 6873
		public bool isEmitting = true;
	}
}
