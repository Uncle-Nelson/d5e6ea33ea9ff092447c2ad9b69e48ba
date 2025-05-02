using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A46 RID: 2630
	public class RegionUnlockedCanvas : Singleton<RegionUnlockedCanvas>, IPostSleepEvent
	{
		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x060046EF RID: 18159 RVA: 0x00129532 File Offset: 0x00127732
		// (set) Token: 0x060046F0 RID: 18160 RVA: 0x0012953A File Offset: 0x0012773A
		public bool IsRunning { get; private set; }

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x060046F1 RID: 18161 RVA: 0x00129543 File Offset: 0x00127743
		// (set) Token: 0x060046F2 RID: 18162 RVA: 0x0012954B File Offset: 0x0012774B
		public int Order { get; private set; } = 5;

		// Token: 0x060046F3 RID: 18163 RVA: 0x00129554 File Offset: 0x00127754
		public void QueueUnlocked(EMapRegion _region)
		{
			this.region = _region;
			Singleton<SleepCanvas>.Instance.AddPostSleepEvent(this);
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x00129568 File Offset: 0x00127768
		public void StartEvent()
		{
			this.IsRunning = true;
			MapRegionData regionData = Singleton<Map>.Instance.GetRegionData(this.region);
			this.RegionLabel.text = regionData.Name;
			this.RegionImage.sprite = regionData.RegionSprite;
			List<NPC> npcsInRegion = NPCManager.GetNPCsInRegion(this.region);
			int num = npcsInRegion.Count((NPC x) => x.GetComponent<Customer>() != null);
			int num2 = npcsInRegion.Count((NPC x) => x is Dealer);
			int num3 = npcsInRegion.Count((NPC x) => x is Supplier);
			this.RegionDescription.text = string.Empty;
			if (num > 0)
			{
				TextMeshProUGUI regionDescription = this.RegionDescription;
				regionDescription.text = regionDescription.text + num.ToString() + " potential customer" + ((num > 1) ? "s" : "");
			}
			if (num2 > 0)
			{
				if (this.RegionDescription.text.Length > 0)
				{
					TextMeshProUGUI regionDescription2 = this.RegionDescription;
					regionDescription2.text += "\n";
				}
				TextMeshProUGUI regionDescription3 = this.RegionDescription;
				regionDescription3.text = regionDescription3.text + num2.ToString() + " dealer" + ((num2 > 1) ? "s" : "");
			}
			if (num3 > 0)
			{
				if (this.RegionDescription.text.Length > 0)
				{
					TextMeshProUGUI regionDescription4 = this.RegionDescription;
					regionDescription4.text += "\n";
				}
				TextMeshProUGUI regionDescription5 = this.RegionDescription;
				regionDescription5.text = regionDescription5.text + num3.ToString() + " supplier" + ((num3 > 1) ? "s" : "");
			}
			this.OpenCloseAnim.Play("Rank up open");
		}

		// Token: 0x060046F5 RID: 18165 RVA: 0x0012974A File Offset: 0x0012794A
		public void EndEvent()
		{
			if (!this.IsRunning)
			{
				return;
			}
			this.OpenCloseAnim.Play("Rank up close");
			this.IsRunning = false;
		}

		// Token: 0x04003462 RID: 13410
		public Animation OpenCloseAnim;

		// Token: 0x04003463 RID: 13411
		public TextMeshProUGUI RegionLabel;

		// Token: 0x04003464 RID: 13412
		public TextMeshProUGUI RegionDescription;

		// Token: 0x04003465 RID: 13413
		public Image RegionImage;

		// Token: 0x04003466 RID: 13414
		private EMapRegion region;
	}
}
