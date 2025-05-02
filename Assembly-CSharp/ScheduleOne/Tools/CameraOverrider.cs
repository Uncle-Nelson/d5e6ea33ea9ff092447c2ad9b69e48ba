using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000846 RID: 2118
	public class CameraOverrider : MonoBehaviour
	{
		// Token: 0x06003A33 RID: 14899 RVA: 0x000F6374 File Offset: 0x000F4574
		public void LateUpdate()
		{
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(base.transform.position, base.transform.rotation, 0f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(this.FOV, 0f);
		}

		// Token: 0x040029E7 RID: 10727
		public float FOV = 70f;
	}
}
