using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x020009DF RID: 2527
	public class EyeLidOverlaySetter : MonoBehaviour
	{
		// Token: 0x06004437 RID: 17463 RVA: 0x0011E231 File Offset: 0x0011C431
		private void OnEnable()
		{
			Singleton<EyelidOverlay>.Instance.AutoUpdate = false;
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x0011E23E File Offset: 0x0011C43E
		private void OnDisable()
		{
			Singleton<EyelidOverlay>.Instance.AutoUpdate = true;
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x0011E24B File Offset: 0x0011C44B
		private void Update()
		{
			Singleton<EyelidOverlay>.Instance.SetOpen(this.OpenOverride);
		}

		// Token: 0x040031BD RID: 12733
		[Range(0f, 1f)]
		public float OpenOverride = 1f;
	}
}
