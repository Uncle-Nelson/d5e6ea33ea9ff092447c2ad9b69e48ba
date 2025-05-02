using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000C7 RID: 199
	public class SlowMo : MonoBehaviour
	{
		// Token: 0x0600064D RID: 1613 RVA: 0x0002AD1C File Offset: 0x00028F1C
		private void Update()
		{
			Time.timeScale = (this.IsSlowMotion() ? this.slowMoTimeScale : 1f);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0002AD38 File Offset: 0x00028F38
		private bool IsSlowMotion()
		{
			if (this.mouse0 && Input.GetMouseButton(0))
			{
				return true;
			}
			if (this.mouse1 && Input.GetMouseButton(1))
			{
				return true;
			}
			for (int i = 0; i < this.keyCodes.Length; i++)
			{
				if (Input.GetKey(this.keyCodes[i]))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x040005C9 RID: 1481
		public KeyCode[] keyCodes;

		// Token: 0x040005CA RID: 1482
		public bool mouse0;

		// Token: 0x040005CB RID: 1483
		public bool mouse1;

		// Token: 0x040005CC RID: 1484
		public float slowMoTimeScale = 0.3f;
	}
}
