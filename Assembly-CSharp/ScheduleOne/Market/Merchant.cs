using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Interaction;
using UnityEngine;

namespace ScheduleOne.Market
{
	// Token: 0x0200055E RID: 1374
	public class Merchant : MonoBehaviour
	{
		// Token: 0x0600218F RID: 8591 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void Start()
		{
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x0008A2E4 File Offset: 0x000884E4
		public void Hovered()
		{
			if (NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(this.openTime, this.closeTime))
			{
				this.intObj.SetMessage("Browse " + this.shopName);
				this.intObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				return;
			}
			this.intObj.SetInteractableState(InteractableObject.EInteractableState.Invalid);
			this.intObj.SetMessage("Closed");
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void Interacted()
		{
		}

		// Token: 0x040019C4 RID: 6596
		[Header("Settings")]
		[SerializeField]
		protected string shopName = "Store";

		// Token: 0x040019C5 RID: 6597
		[SerializeField]
		protected int openTime = 600;

		// Token: 0x040019C6 RID: 6598
		[SerializeField]
		protected int closeTime = 1800;

		// Token: 0x040019C7 RID: 6599
		[Header("References")]
		[SerializeField]
		protected InteractableObject intObj;
	}
}
