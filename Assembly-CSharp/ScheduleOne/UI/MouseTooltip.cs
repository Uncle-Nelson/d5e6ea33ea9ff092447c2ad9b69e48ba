using System;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A08 RID: 2568
	public class MouseTooltip : Singleton<MouseTooltip>
	{
		// Token: 0x06004533 RID: 17715 RVA: 0x00121D03 File Offset: 0x0011FF03
		public void ShowTooltip(string text, Color col)
		{
			this.TooltipLabel.text = text;
			this.TooltipLabel.color = col;
			this.tooltipShownThisFrame = true;
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x00121D24 File Offset: 0x0011FF24
		public void ShowIcon(Sprite sprite, Color col)
		{
			this.IconImg.sprite = sprite;
			this.IconImg.color = col;
			this.iconShownThisFrame = true;
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x00121D48 File Offset: 0x0011FF48
		private void LateUpdate()
		{
			this.TooltipLabel.gameObject.SetActive(this.tooltipShownThisFrame);
			this.IconRect.gameObject.SetActive(this.iconShownThisFrame);
			this.IconRect.position = Input.mousePosition + this.IconOffset;
			if (this.iconShownThisFrame)
			{
				this.TooltipRect.position = Input.mousePosition + this.TooltipOffset_WithIcon;
			}
			else
			{
				this.TooltipRect.position = Input.mousePosition + this.TooltipOffset_NoIcon;
			}
			this.tooltipShownThisFrame = false;
			this.iconShownThisFrame = false;
		}

		// Token: 0x040032B3 RID: 12979
		[Header("References")]
		public RectTransform IconRect;

		// Token: 0x040032B4 RID: 12980
		public Image IconImg;

		// Token: 0x040032B5 RID: 12981
		public RectTransform TooltipRect;

		// Token: 0x040032B6 RID: 12982
		public TextMeshProUGUI TooltipLabel;

		// Token: 0x040032B7 RID: 12983
		[Header("Settings")]
		public Vector3 TooltipOffset_NoIcon;

		// Token: 0x040032B8 RID: 12984
		public Vector3 TooltipOffset_WithIcon;

		// Token: 0x040032B9 RID: 12985
		public Vector3 IconOffset;

		// Token: 0x040032BA RID: 12986
		[Header("Colors")]
		public Color Color_Invalid;

		// Token: 0x040032BB RID: 12987
		[Header("Sprites")]
		public Sprite Sprite_Cross;

		// Token: 0x040032BC RID: 12988
		private bool tooltipShownThisFrame;

		// Token: 0x040032BD RID: 12989
		private bool iconShownThisFrame;
	}
}
