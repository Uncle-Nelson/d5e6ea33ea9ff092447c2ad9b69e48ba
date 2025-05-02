using System;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000847 RID: 2119
	public class CashPile : MonoBehaviour
	{
		// Token: 0x06003A35 RID: 14901 RVA: 0x000F63C4 File Offset: 0x000F45C4
		private void Awake()
		{
			this.CashInstances = new Transform[this.Container.childCount];
			for (int i = 0; i < this.CashInstances.Length; i++)
			{
				this.CashInstances[i] = this.Container.GetChild(i);
				this.CashInstances[i].gameObject.SetActive(false);
			}
		}

		// Token: 0x06003A36 RID: 14902 RVA: 0x000F6424 File Offset: 0x000F4624
		public void SetDisplayedAmount(float amount)
		{
			int num = Mathf.FloorToInt(amount / 100000f * (float)this.CashInstances.Length);
			for (int i = 0; i < this.CashInstances.Length; i++)
			{
				this.CashInstances[i].gameObject.SetActive(i < num);
			}
		}

		// Token: 0x040029E8 RID: 10728
		public const float MAX_AMOUNT = 100000f;

		// Token: 0x040029E9 RID: 10729
		public Transform Container;

		// Token: 0x040029EA RID: 10730
		private Transform[] CashInstances;
	}
}
