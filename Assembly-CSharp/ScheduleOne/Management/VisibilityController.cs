using System;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x02000589 RID: 1417
	public class VisibilityController : MonoBehaviour
	{
		// Token: 0x0600234E RID: 9038 RVA: 0x000906B1 File Offset: 0x0008E8B1
		private void Start()
		{
			bool flag = this.visibleOnlyInFullscreen;
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x000906BA File Offset: 0x0008E8BA
		private void OnEnterFullScreen()
		{
			if (this.visibleOnlyInFullscreen)
			{
				base.gameObject.SetActive(true);
			}
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x000906D0 File Offset: 0x0008E8D0
		private void OnExitFullScreen()
		{
			if (this.visibleOnlyInFullscreen)
			{
				base.gameObject.SetActive(false);
			}
		}

		// Token: 0x04001A66 RID: 6758
		public bool visibleOnlyInFullscreen = true;
	}
}
