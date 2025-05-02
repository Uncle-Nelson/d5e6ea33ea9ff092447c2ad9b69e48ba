using System;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x020009CF RID: 2511
	public class CrosshairText : MonoBehaviour
	{
		// Token: 0x060043BD RID: 17341 RVA: 0x0011BE12 File Offset: 0x0011A012
		private void Awake()
		{
			this.Hide();
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x0011BE1A File Offset: 0x0011A01A
		private void LateUpdate()
		{
			if (!this.setThisFrame)
			{
				this.Label.enabled = false;
			}
			this.setThisFrame = false;
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x0011BE38 File Offset: 0x0011A038
		public void Show(string text, Color col = default(Color))
		{
			this.setThisFrame = true;
			this.Label.color = ((col != default(Color)) ? col : Color.white);
			this.Label.text = text;
			this.Label.enabled = true;
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x0011BE88 File Offset: 0x0011A088
		public void Hide()
		{
			this.Label.enabled = false;
		}

		// Token: 0x0400314B RID: 12619
		public TextMeshProUGUI Label;

		// Token: 0x0400314C RID: 12620
		private bool setThisFrame;
	}
}
