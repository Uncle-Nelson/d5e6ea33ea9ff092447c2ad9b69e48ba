using System;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x02000681 RID: 1665
	public class SupplierLocationConfiguration : MonoBehaviour
	{
		// Token: 0x06002E03 RID: 11779 RVA: 0x000C0C9B File Offset: 0x000BEE9B
		public void Activate()
		{
			base.gameObject.SetActive(true);
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x000C0CA9 File Offset: 0x000BEEA9
		public void Deactivate()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x040020A6 RID: 8358
		public string SupplierID;
	}
}
