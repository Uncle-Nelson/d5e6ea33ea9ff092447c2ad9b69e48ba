using System;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006E6 RID: 1766
	public class LookAt : MonoBehaviour
	{
		// Token: 0x0600300D RID: 12301 RVA: 0x000C81FF File Offset: 0x000C63FF
		private void LateUpdate()
		{
			if (this.Target != null)
			{
				base.transform.LookAt(this.Target);
			}
		}

		// Token: 0x04002227 RID: 8743
		public Transform Target;
	}
}
