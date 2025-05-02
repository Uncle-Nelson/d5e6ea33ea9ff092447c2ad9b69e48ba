using System;
using ScheduleOne.ItemFramework;
using TMPro;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000B79 RID: 2937
	public class QualityItemInfoContent : ItemInfoContent
	{
		// Token: 0x06004E31 RID: 20017 RVA: 0x0014A048 File Offset: 0x00148248
		public override void Initialize(ItemInstance instance)
		{
			base.Initialize(instance);
			QualityItemInstance qualityItemInstance = instance as QualityItemInstance;
			if (qualityItemInstance == null)
			{
				Console.LogError("QualityItemInfoContent can only be used with QualityItemInstance!", null);
				return;
			}
			this.QualityLabel.text = qualityItemInstance.Quality.ToString();
			this.QualityLabel.color = ItemQuality.GetColor(qualityItemInstance.Quality);
			this.Star.color = ItemQuality.GetColor(qualityItemInstance.Quality);
			this.QualityLabel.gameObject.SetActive(true);
		}

		// Token: 0x04003AFF RID: 15103
		public Image Star;

		// Token: 0x04003B00 RID: 15104
		public TextMeshProUGUI QualityLabel;
	}
}
