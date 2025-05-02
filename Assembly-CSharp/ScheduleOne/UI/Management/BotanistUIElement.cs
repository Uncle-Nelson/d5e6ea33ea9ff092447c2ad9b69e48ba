using System;
using ScheduleOne.Employees;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B06 RID: 2822
	public class BotanistUIElement : WorldspaceUIElement
	{
		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06004B73 RID: 19315 RVA: 0x0013D82D File Offset: 0x0013BA2D
		// (set) Token: 0x06004B74 RID: 19316 RVA: 0x0013D835 File Offset: 0x0013BA35
		public Botanist AssignedBotanist { get; protected set; }

		// Token: 0x06004B75 RID: 19317 RVA: 0x0013D840 File Offset: 0x0013BA40
		public void Initialize(Botanist bot)
		{
			this.AssignedBotanist = bot;
			this.AssignedBotanist.Configuration.onChanged.AddListener(new UnityAction(this.RefreshUI));
			this.TitleLabel.text = bot.fullName;
			this.RefreshUI();
			base.gameObject.SetActive(false);
		}

		// Token: 0x06004B76 RID: 19318 RVA: 0x0013D89C File Offset: 0x0013BA9C
		protected virtual void RefreshUI()
		{
			BotanistConfiguration botanistConfiguration = this.AssignedBotanist.Configuration as BotanistConfiguration;
			this.NoSupply.gameObject.SetActive(botanistConfiguration.Supplies.SelectedObject == null);
			if (botanistConfiguration.Supplies.SelectedObject != null)
			{
				this.SupplyIcon.sprite = botanistConfiguration.Supplies.SelectedObject.ItemInstance.Icon;
				this.SupplyIcon.gameObject.SetActive(true);
			}
			else
			{
				this.SupplyIcon.gameObject.SetActive(false);
			}
			for (int i = 0; i < this.PotRects.Length; i++)
			{
				if (botanistConfiguration.AssignedStations.SelectedObjects.Count > i)
				{
					this.PotRects[i].Find("Icon").GetComponent<Image>().sprite = botanistConfiguration.AssignedStations.SelectedObjects[i].ItemInstance.Icon;
					this.PotRects[i].Find("Icon").gameObject.SetActive(true);
				}
				else
				{
					this.PotRects[i].Find("Icon").gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x040038A1 RID: 14497
		[Header("References")]
		public Image SupplyIcon;

		// Token: 0x040038A2 RID: 14498
		public GameObject NoSupply;

		// Token: 0x040038A3 RID: 14499
		public TextMeshProUGUI SupplyLabel;

		// Token: 0x040038A4 RID: 14500
		public RectTransform[] PotRects;
	}
}
