using System;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x020009E3 RID: 2531
	public class FeedbackFormPopup : MonoBehaviour
	{
		// Token: 0x06004456 RID: 17494 RVA: 0x0011E8B8 File Offset: 0x0011CAB8
		public void Open(string text)
		{
			if (this.Label != null)
			{
				this.Label.text = text;
			}
			base.gameObject.SetActive(true);
			this.closeTime = Time.unscaledTime + 4f;
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x000C0CA9 File Offset: 0x000BEEA9
		public void Close()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x0011E8F1 File Offset: 0x0011CAF1
		private void Update()
		{
			if (this.AutoClose && Time.unscaledTime > this.closeTime)
			{
				this.Close();
			}
		}

		// Token: 0x040031CC RID: 12748
		public TextMeshProUGUI Label;

		// Token: 0x040031CD RID: 12749
		public bool AutoClose = true;

		// Token: 0x040031CE RID: 12750
		private float closeTime;
	}
}
