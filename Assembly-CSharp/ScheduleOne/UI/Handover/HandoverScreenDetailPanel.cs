using System;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Handover
{
	// Token: 0x02000B31 RID: 2865
	public class HandoverScreenDetailPanel : MonoBehaviour
	{
		// Token: 0x06004C3F RID: 19519 RVA: 0x00141D40 File Offset: 0x0013FF40
		public void Open(Customer customer)
		{
			this.NameLabel.text = customer.NPC.fullName;
			if (customer.NPC.RelationData.Unlocked)
			{
				this.RelationshipContainer.gameObject.SetActive(true);
				this.RelationshipScrollbar.value = customer.NPC.RelationData.NormalizedRelationDelta;
				this.AddictionContainer.gameObject.SetActive(true);
				this.AdditionScrollbar.value = customer.CurrentAddiction;
			}
			else
			{
				this.RelationshipContainer.gameObject.SetActive(false);
				this.AddictionContainer.gameObject.SetActive(false);
			}
			this.StandardsStar.color = ItemQuality.GetColor(customer.CustomerData.Standards.GetCorrespondingQuality());
			this.StandardsLabel.text = customer.CustomerData.Standards.GetName();
			this.StandardsLabel.color = this.StandardsStar.color;
			this.EffectsLabel.text = string.Empty;
			for (int i = 0; i < customer.CustomerData.PreferredProperties.Count; i++)
			{
				if (i > 0)
				{
					TextMeshProUGUI effectsLabel = this.EffectsLabel;
					effectsLabel.text += "\n";
				}
				string str = string.Concat(new string[]
				{
					"<color=#",
					ColorUtility.ToHtmlStringRGBA(customer.CustomerData.PreferredProperties[i].LabelColor),
					">•  ",
					customer.CustomerData.PreferredProperties[i].Name,
					"</color>"
				});
				TextMeshProUGUI effectsLabel2 = this.EffectsLabel;
				effectsLabel2.text += str;
			}
			base.gameObject.SetActive(true);
			this.LayoutGroup.CalculateLayoutInputHorizontal();
			this.LayoutGroup.CalculateLayoutInputVertical();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.LayoutGroup.GetComponent<RectTransform>());
			this.LayoutGroup.GetComponent<ContentSizeFitter>().SetLayoutVertical();
			this.Container.anchoredPosition = new Vector2(0f, -this.Container.sizeDelta.y / 2f);
		}

		// Token: 0x06004C40 RID: 19520 RVA: 0x000C0CA9 File Offset: 0x000BEEA9
		public void Close()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x04003952 RID: 14674
		public LayoutGroup LayoutGroup;

		// Token: 0x04003953 RID: 14675
		public RectTransform Container;

		// Token: 0x04003954 RID: 14676
		public TextMeshProUGUI NameLabel;

		// Token: 0x04003955 RID: 14677
		public RectTransform RelationshipContainer;

		// Token: 0x04003956 RID: 14678
		public Scrollbar RelationshipScrollbar;

		// Token: 0x04003957 RID: 14679
		public RectTransform AddictionContainer;

		// Token: 0x04003958 RID: 14680
		public Scrollbar AdditionScrollbar;

		// Token: 0x04003959 RID: 14681
		public Image StandardsStar;

		// Token: 0x0400395A RID: 14682
		public TextMeshProUGUI StandardsLabel;

		// Token: 0x0400395B RID: 14683
		public TextMeshProUGUI EffectsLabel;
	}
}
