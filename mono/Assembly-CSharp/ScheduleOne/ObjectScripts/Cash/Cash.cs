using System;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.Cash
{
	// Token: 0x02000C02 RID: 3074
	public class Cash : MonoBehaviour
	{
		// Token: 0x06005683 RID: 22147 RVA: 0x0016BD15 File Offset: 0x00169F15
		public static int GetBillStacksToDisplay(float amount)
		{
			return Mathf.Clamp((int)(amount / 5f), 1, 50);
		}

		// Token: 0x04003FE2 RID: 16354
		public static float stackSize = 250f;

		// Token: 0x04003FE3 RID: 16355
		public static int[] amounts = new int[]
		{
			5,
			50,
			(int)Cash.stackSize
		};
	}
}
