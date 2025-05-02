using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A2E RID: 2606
	public class PlayerEnergyUI : Singleton<PlayerEnergyUI>
	{
		// Token: 0x06004646 RID: 17990 RVA: 0x00126F29 File Offset: 0x00125129
		protected override void Awake()
		{
			base.Awake();
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(delegate()
			{
				this.UpdateDisplayedEnergy();
				Player.Local.Energy.onEnergyChanged.AddListener(new UnityAction(this.UpdateDisplayedEnergy));
			}));
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x00126F51 File Offset: 0x00125151
		private void UpdateDisplayedEnergy()
		{
			this.SetDisplayedEnergy(Player.Local.Energy.CurrentEnergy);
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x00126F68 File Offset: 0x00125168
		public void SetDisplayedEnergy(float energy)
		{
			this.displayedValue = energy;
			this.Slider.value = energy / 100f;
			this.FillImage.color = ((energy <= 20f) ? this.SliderColor_Red : this.SliderColor_Green);
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x00126FA4 File Offset: 0x001251A4
		protected virtual void Update()
		{
			if (this.displayedValue < 20f)
			{
				float num = Mathf.Clamp((20f - this.displayedValue) / 20f, 0.25f, 1f);
				float num2 = num * 3f;
				this.SliderRect.anchoredPosition = new Vector2(Random.Range(-num2, num2), Random.Range(-num2, num2));
				Color white = Color.white;
				Color b = Color.Lerp(Color.white, Color.red, num);
				white.a = this.Label.color.a;
				b.a = this.Label.color.a;
				this.Label.color = Color.Lerp(white, b, (Mathf.Sin(Time.timeSinceLevelLoad * num * 10f) + 1f) / 2f);
				return;
			}
			this.SliderRect.anchoredPosition = Vector2.zero;
			this.Label.color = new Color(1f, 1f, 1f, this.Label.color.a);
		}

		// Token: 0x040033D9 RID: 13273
		public Slider Slider;

		// Token: 0x040033DA RID: 13274
		public RectTransform SliderRect;

		// Token: 0x040033DB RID: 13275
		public Image FillImage;

		// Token: 0x040033DC RID: 13276
		public TextMeshProUGUI Label;

		// Token: 0x040033DD RID: 13277
		[Header("Settings")]
		public Color SliderColor_Green;

		// Token: 0x040033DE RID: 13278
		public Color SliderColor_Red;

		// Token: 0x040033DF RID: 13279
		private float displayedValue = 1f;
	}
}
