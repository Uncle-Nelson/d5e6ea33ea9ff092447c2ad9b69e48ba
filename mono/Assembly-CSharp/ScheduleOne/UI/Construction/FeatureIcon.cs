using System;
using ScheduleOne.Construction.Features;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Construction
{
	// Token: 0x02000B82 RID: 2946
	public class FeatureIcon : MonoBehaviour
	{
		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06004E61 RID: 20065 RVA: 0x0014ADAC File Offset: 0x00148FAC
		// (set) Token: 0x06004E62 RID: 20066 RVA: 0x0014ADB4 File Offset: 0x00148FB4
		public Feature feature { get; protected set; }

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06004E63 RID: 20067 RVA: 0x0014ADBD File Offset: 0x00148FBD
		// (set) Token: 0x06004E64 RID: 20068 RVA: 0x0014ADC5 File Offset: 0x00148FC5
		public bool isSelected { get; protected set; }

		// Token: 0x06004E65 RID: 20069 RVA: 0x0014ADD0 File Offset: 0x00148FD0
		public void AssignFeature(Feature _feature)
		{
			this.feature = _feature;
			this.icon.sprite = this.feature.featureIcon;
			this.text.text = this.feature.featureName;
			this.text.gameObject.SetActive(false);
		}

		// Token: 0x06004E66 RID: 20070 RVA: 0x0014AE24 File Offset: 0x00149024
		public void UpdateTransform()
		{
			Vector3 position = this.feature.featureIconLocation.position;
			if (PlayerSingleton<PlayerCamera>.Instance.transform.InverseTransformPoint(position).z < 0f)
			{
				base.gameObject.SetActive(false);
				return;
			}
			this.rectTransform.position = PlayerSingleton<PlayerCamera>.Instance.Camera.WorldToScreenPoint(position);
			float num = 0.3f;
			float num2 = 1f;
			float num3 = 3f;
			float num4 = 30f;
			float num5 = Vector3.Distance(position, PlayerSingleton<PlayerCamera>.Instance.transform.position);
			float num6 = 1f - Mathf.Clamp((num5 - num3) / (num4 - num3), 0f, 1f);
			float num7 = num + (num2 - num) * num6;
			this.rectTransform.localScale = new Vector3(num7, num7, num7);
			base.gameObject.SetActive(true);
		}

		// Token: 0x06004E67 RID: 20071 RVA: 0x0014AF02 File Offset: 0x00149102
		public void Clicked()
		{
			this.SetIsSelected(!this.isSelected);
			if (this.isSelected)
			{
				Singleton<FeaturesManager>.Instance.OpenFeatureMenu(this.feature);
				return;
			}
			Singleton<FeaturesManager>.Instance.CloseFeatureMenu();
		}

		// Token: 0x06004E68 RID: 20072 RVA: 0x0014AF38 File Offset: 0x00149138
		public void SetIsSelected(bool s)
		{
			this.isSelected = s;
			if (this.isSelected)
			{
				if (FeatureIcon.selectedFeatureIcon != null && FeatureIcon.selectedFeatureIcon != this)
				{
					FeatureIcon.selectedFeatureIcon.SetIsSelected(false);
				}
				FeatureIcon.selectedFeatureIcon = this;
			}
			else if (FeatureIcon.selectedFeatureIcon == this)
			{
				FeatureIcon.selectedFeatureIcon = null;
			}
			if (!this.hovered)
			{
				this.text.gameObject.SetActive(false);
			}
			this.UpdateColors();
		}

		// Token: 0x06004E69 RID: 20073 RVA: 0x0014AFB4 File Offset: 0x001491B4
		private void UpdateColors()
		{
			if (this.isSelected)
			{
				this.background.color = new Color32(byte.MaxValue, 156, 37, byte.MaxValue);
				this.icon.color = Color.white;
				return;
			}
			this.background.color = Color.white;
			this.icon.color = new Color32(byte.MaxValue, 156, 37, byte.MaxValue);
		}

		// Token: 0x06004E6A RID: 20074 RVA: 0x0014B036 File Offset: 0x00149236
		public void PointerEnter()
		{
			this.hovered = true;
			this.text.gameObject.SetActive(true);
		}

		// Token: 0x06004E6B RID: 20075 RVA: 0x0014B050 File Offset: 0x00149250
		public void PointerExit()
		{
			this.hovered = false;
			if (!this.isSelected)
			{
				this.text.gameObject.SetActive(false);
			}
		}

		// Token: 0x04003B2B RID: 15147
		public static FeatureIcon selectedFeatureIcon;

		// Token: 0x04003B2C RID: 15148
		[Header("References")]
		public RectTransform rectTransform;

		// Token: 0x04003B2D RID: 15149
		public Image icon;

		// Token: 0x04003B2E RID: 15150
		public TextMeshProUGUI text;

		// Token: 0x04003B2F RID: 15151
		public Image background;

		// Token: 0x04003B32 RID: 15154
		private bool hovered;
	}
}
