using System;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006DC RID: 1756
	public class CopyPosition : MonoBehaviour
	{
		// Token: 0x06002FD6 RID: 12246 RVA: 0x000C7849 File Offset: 0x000C5A49
		private void LateUpdate()
		{
			base.transform.position = this.ToCopy.position;
		}

		// Token: 0x04002204 RID: 8708
		public Transform ToCopy;
	}
}
