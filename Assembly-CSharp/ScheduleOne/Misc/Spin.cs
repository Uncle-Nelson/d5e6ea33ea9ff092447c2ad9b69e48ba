using System;
using UnityEngine;

namespace ScheduleOne.Misc
{
	// Token: 0x02000C0F RID: 3087
	public class Spin : MonoBehaviour
	{
		// Token: 0x060056CE RID: 22222 RVA: 0x0016D1AF File Offset: 0x0016B3AF
		private void Update()
		{
			base.transform.Rotate(this.Axis, this.Speed * Time.deltaTime, Space.Self);
		}

		// Token: 0x0400402D RID: 16429
		public Vector3 Axis;

		// Token: 0x0400402E RID: 16430
		public float Speed;
	}
}
