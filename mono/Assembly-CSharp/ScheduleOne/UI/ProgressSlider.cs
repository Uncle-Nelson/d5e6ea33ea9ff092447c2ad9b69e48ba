using System;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A37 RID: 2615
	public class ProgressSlider : Singleton<ProgressSlider>
	{
		// Token: 0x06004684 RID: 18052 RVA: 0x00127FD3 File Offset: 0x001261D3
		private void LateUpdate()
		{
			if (this.progressSetThisFrame)
			{
				this.Container.SetActive(true);
				this.progressSetThisFrame = false;
				return;
			}
			this.Container.SetActive(false);
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x00127FFD File Offset: 0x001261FD
		public void ShowProgress(float progress)
		{
			this.progressSetThisFrame = true;
			this.Slider.value = progress;
		}

		// Token: 0x06004686 RID: 18054 RVA: 0x00128012 File Offset: 0x00126212
		public void Configure(string label, Color sliderFillColor)
		{
			this.Label.text = label;
			this.Label.color = sliderFillColor;
			this.SliderFill.color = sliderFillColor;
		}

		// Token: 0x04003415 RID: 13333
		[Header("References")]
		public GameObject Container;

		// Token: 0x04003416 RID: 13334
		public TextMeshProUGUI Label;

		// Token: 0x04003417 RID: 13335
		public Slider Slider;

		// Token: 0x04003418 RID: 13336
		public Image SliderFill;

		// Token: 0x04003419 RID: 13337
		private bool progressSetThisFrame;
	}
}
