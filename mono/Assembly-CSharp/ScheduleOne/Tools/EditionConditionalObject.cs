using System;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000854 RID: 2132
	public class EditionConditionalObject : MonoBehaviour
	{
		// Token: 0x06003A68 RID: 14952 RVA: 0x000F6B35 File Offset: 0x000F4D35
		private void Awake()
		{
			if (this.type == EditionConditionalObject.EType.ActiveInDemo)
			{
				base.gameObject.SetActive(false);
			}
		}

		// Token: 0x04002A0D RID: 10765
		public EditionConditionalObject.EType type;

		// Token: 0x02000855 RID: 2133
		public enum EType
		{
			// Token: 0x04002A0F RID: 10767
			ActiveInDemo,
			// Token: 0x04002A10 RID: 10768
			ActiveInFullGame
		}
	}
}
