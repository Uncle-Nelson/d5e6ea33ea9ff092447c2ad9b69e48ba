using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A26 RID: 2598
	public class EyelidOverlay : Singleton<EyelidOverlay>
	{
		// Token: 0x06004617 RID: 17943 RVA: 0x001260DC File Offset: 0x001242DC
		protected override void Awake()
		{
			base.Awake();
			this.OpenMultiplier.Initialize();
			this.SetOpen(1f);
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x001260FC File Offset: 0x001242FC
		private void Update()
		{
			if (Player.Local == null)
			{
				return;
			}
			if (this.AutoUpdate)
			{
				if (Player.Local.Energy.CurrentEnergy < 20f)
				{
					this.CurrentOpen = Mathf.Lerp(0.625f, 1f, Player.Local.Energy.CurrentEnergy / 20f);
				}
				else
				{
					this.CurrentOpen = 1f;
				}
			}
			this.SetOpen(this.CurrentOpen * this.OpenMultiplier.CurrentValue);
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x00126184 File Offset: 0x00124384
		public void SetOpen(float openness)
		{
			this.CurrentOpen = openness;
			this.Upper.anchoredPosition = new Vector2(0f, Mathf.Lerp(this.Closed, this.Open, openness));
			this.Lower.anchoredPosition = new Vector2(0f, -Mathf.Lerp(this.Closed, this.Open, openness));
			this.Canvas.enabled = (openness < 1f);
		}

		// Token: 0x040033A7 RID: 13223
		public const float MaxTiredOpenAmount = 0.625f;

		// Token: 0x040033A8 RID: 13224
		public bool AutoUpdate = true;

		// Token: 0x040033A9 RID: 13225
		[Header("Settings")]
		public float Open = 400f;

		// Token: 0x040033AA RID: 13226
		public float Closed = 30f;

		// Token: 0x040033AB RID: 13227
		[Header("References")]
		public RectTransform Upper;

		// Token: 0x040033AC RID: 13228
		public RectTransform Lower;

		// Token: 0x040033AD RID: 13229
		public Canvas Canvas;

		// Token: 0x040033AE RID: 13230
		[Range(0f, 1f)]
		public float CurrentOpen = 1f;

		// Token: 0x040033AF RID: 13231
		public FloatSmoother OpenMultiplier;
	}
}
