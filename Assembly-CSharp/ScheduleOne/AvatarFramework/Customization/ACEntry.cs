using System;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020009A3 RID: 2467
	public class ACEntry : MonoBehaviour
	{
		// Token: 0x060042CA RID: 17098 RVA: 0x001182CC File Offset: 0x001164CC
		private void Awake()
		{
			if (this.DevOnly && !Application.isEditor)
			{
				base.gameObject.SetActive(false);
			}
		}

		// Token: 0x0400306E RID: 12398
		public bool DevOnly;
	}
}
