using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000845 RID: 2117
	public class BetaEnabledGameObject : MonoBehaviour
	{
		// Token: 0x06003A31 RID: 14897 RVA: 0x000F635F File Offset: 0x000F455F
		private void Start()
		{
			if (!GameManager.IS_BETA)
			{
				base.gameObject.SetActive(false);
			}
		}
	}
}
