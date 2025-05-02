using System;
using ScheduleOne.Money;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x020009BC RID: 2492
	public class BalanceDisplay : MonoBehaviour
	{
		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x0600433B RID: 17211 RVA: 0x00119BB1 File Offset: 0x00117DB1
		// (set) Token: 0x0600433C RID: 17212 RVA: 0x00119BB9 File Offset: 0x00117DB9
		public bool active { get; protected set; }

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x0600433D RID: 17213 RVA: 0x00119BC2 File Offset: 0x00117DC2
		// (set) Token: 0x0600433E RID: 17214 RVA: 0x00119BCA File Offset: 0x00117DCA
		public float timeSinceActiveSet { get; protected set; }

		// Token: 0x0600433F RID: 17215 RVA: 0x00119BD4 File Offset: 0x00117DD4
		protected virtual void Update()
		{
			this.timeSinceActiveSet += Time.deltaTime;
			if (this.timeSinceActiveSet > 3f)
			{
				this.active = false;
			}
			if (this.Group != null)
			{
				this.Group.alpha = Mathf.MoveTowards(this.Group.alpha, this.active ? 1f : 0f, Time.deltaTime / 0.25f);
			}
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x00119C4F File Offset: 0x00117E4F
		public void SetBalance(float balance)
		{
			this.BalanceLabel.text = MoneyManager.FormatAmount(balance, false, false);
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x00119C64 File Offset: 0x00117E64
		public void Show()
		{
			this.active = true;
			this.timeSinceActiveSet = 0f;
		}

		// Token: 0x040030D6 RID: 12502
		public const float RESIDUAL_TIME = 3f;

		// Token: 0x040030D7 RID: 12503
		public const float FADE_TIME = 0.25f;

		// Token: 0x040030D8 RID: 12504
		[Header("References")]
		public CanvasGroup Group;

		// Token: 0x040030D9 RID: 12505
		public TextMeshProUGUI BalanceLabel;
	}
}
