using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000843 RID: 2115
	public class ActiveInRange : MonoBehaviour
	{
		// Token: 0x06003A2D RID: 14893 RVA: 0x000F61CC File Offset: 0x000F43CC
		private void LateUpdate()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			bool flag = Vector3.Distance(PlayerSingleton<PlayerCamera>.Instance.transform.position, base.transform.position) < this.Distance * (this.ScaleByLODBias ? QualitySettings.lodBias : 1f);
			if (flag && !this.isVisible)
			{
				this.isVisible = true;
				GameObject[] objectsToActivate = this.ObjectsToActivate;
				for (int i = 0; i < objectsToActivate.Length; i++)
				{
					objectsToActivate[i].SetActive(!this.Reverse);
				}
				return;
			}
			if (!flag && this.isVisible)
			{
				this.isVisible = false;
				GameObject[] objectsToActivate = this.ObjectsToActivate;
				for (int i = 0; i < objectsToActivate.Length; i++)
				{
					objectsToActivate[i].SetActive(this.Reverse);
				}
			}
		}

		// Token: 0x040029DE RID: 10718
		public float Distance = 10f;

		// Token: 0x040029DF RID: 10719
		public bool ScaleByLODBias = true;

		// Token: 0x040029E0 RID: 10720
		public GameObject[] ObjectsToActivate;

		// Token: 0x040029E1 RID: 10721
		public bool Reverse;

		// Token: 0x040029E2 RID: 10722
		private bool isVisible = true;
	}
}
