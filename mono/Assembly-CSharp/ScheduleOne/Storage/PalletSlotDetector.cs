using System;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008A5 RID: 2213
	public class PalletSlotDetector : MonoBehaviour
	{
		// Token: 0x06003BF9 RID: 15353 RVA: 0x000FC9A0 File Offset: 0x000FABA0
		protected virtual void OnTriggerStay(Collider other)
		{
			this.pallet.TriggerStay(other);
		}

		// Token: 0x04002B4F RID: 11087
		public Pallet pallet;
	}
}
