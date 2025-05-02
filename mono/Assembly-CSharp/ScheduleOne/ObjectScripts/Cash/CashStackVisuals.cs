using System;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.Cash
{
	// Token: 0x02000C03 RID: 3075
	public class CashStackVisuals : MonoBehaviour
	{
		// Token: 0x06005686 RID: 22150 RVA: 0x000045B1 File Offset: 0x000027B1
		private void Awake()
		{
		}

		// Token: 0x06005687 RID: 22151 RVA: 0x0016BD50 File Offset: 0x00169F50
		public void ShowAmount(float amount)
		{
			this.Visuals_Over100.SetActive(amount >= 100f);
			this.Visuals_Under100.SetActive(amount < 100f);
			if (amount >= 100f)
			{
				int num = Mathf.RoundToInt(amount / 100f);
				for (int i = 0; i < this.Bills.Length; i++)
				{
					this.Bills[i].SetActive(num > i);
				}
				return;
			}
			int num2 = Mathf.Clamp(Mathf.RoundToInt(amount / 10f), 0, 10);
			for (int j = 0; j < this.Notes.Length; j++)
			{
				this.Notes[j].SetActive(num2 > j);
			}
		}

		// Token: 0x04003FE4 RID: 16356
		public const float MAX_AMOUNT = 1000f;

		// Token: 0x04003FE5 RID: 16357
		[Header("References")]
		public GameObject Visuals_Under100;

		// Token: 0x04003FE6 RID: 16358
		public GameObject[] Notes;

		// Token: 0x04003FE7 RID: 16359
		public GameObject Visuals_Over100;

		// Token: 0x04003FE8 RID: 16360
		public GameObject[] Bills;
	}
}
