using System;
using ScheduleOne.Construction.Features;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Construction.Features
{
	// Token: 0x02000B84 RID: 2948
	public class FI_ColorPicker : FI_Base
	{
		// Token: 0x06004E79 RID: 20089 RVA: 0x0014B3B0 File Offset: 0x001495B0
		public override void Initialize(Feature _feature)
		{
			base.Initialize(_feature);
			this.specificFeature = (this.feature as ColorFeature);
			this.selectionIndex = this.specificFeature.SyncAccessor_ownedColorIndex;
			for (int i = 0; i < this.specificFeature.colors.Count; i++)
			{
				Button component = Object.Instantiate<GameObject>(this.colorButtonPrefab, this.colorButtonContainer).GetComponent<Button>();
				component.GetComponent<Image>().color = this.specificFeature.colors[i].color;
				int index = i;
				component.onClick.AddListener(new UnityAction(delegate()
				{
					this.Select(index);
				}));
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.colorButtonContainer);
			this.bar.anchoredPosition = new Vector2(this.bar.anchoredPosition.x, this.colorButtonContainer.GetChild(this.colorButtonContainer.childCount - 1).GetComponent<RectTransform>().anchoredPosition.y - 35f);
			this.UpdateSelection();
		}

		// Token: 0x06004E7A RID: 20090 RVA: 0x0014B4C0 File Offset: 0x001496C0
		public override void Close()
		{
			this.Select(this.specificFeature.SyncAccessor_ownedColorIndex);
			base.Close();
		}

		// Token: 0x06004E7B RID: 20091 RVA: 0x0014B4DC File Offset: 0x001496DC
		public void BuyButtonClicked()
		{
			if (NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance < this.specificFeature.colors[this.selectionIndex].price)
			{
				return;
			}
			NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction(Singleton<ConstructionMenu>.Instance.SelectedConstructable.ConstructableName + ": " + this.feature.featureName, -this.specificFeature.colors[this.selectionIndex].price, 1f, string.Empty);
			if (this.onSelectionPurchased != null)
			{
				this.onSelectionPurchased.Invoke(this.specificFeature.colors[this.selectionIndex]);
			}
			this.UpdateSelection();
		}

		// Token: 0x06004E7C RID: 20092 RVA: 0x0014B594 File Offset: 0x00149794
		public void Select(int index)
		{
			this.selectionIndex = Mathf.Clamp(index, 0, this.specificFeature.colors.Count - 1);
			if (this.onSelectionChanged != null)
			{
				this.onSelectionChanged.Invoke(this.specificFeature.colors[this.selectionIndex]);
			}
			this.UpdateSelection();
		}

		// Token: 0x06004E7D RID: 20093 RVA: 0x0014B5F0 File Offset: 0x001497F0
		private void UpdateSelection()
		{
			this.colorLabel.text = this.specificFeature.colors[this.selectionIndex].colorName;
			for (int i = 0; i < this.colorButtonContainer.childCount; i++)
			{
				this.colorButtonContainer.GetChild(i).Find("SelectionIndicator").gameObject.SetActive(false);
				this.colorButtonContainer.GetChild(i).Find("OwnedIndicator").gameObject.SetActive(false);
			}
			this.colorButtonContainer.GetChild(this.selectionIndex).Find("SelectionIndicator").gameObject.SetActive(true);
			this.colorButtonContainer.GetChild(this.specificFeature.SyncAccessor_ownedColorIndex).Find("OwnedIndicator").gameObject.SetActive(true);
			if (this.selectionIndex != this.specificFeature.SyncAccessor_ownedColorIndex)
			{
				this.buyButtonText.text = "Buy (" + MoneyManager.FormatAmount(this.specificFeature.colors[this.selectionIndex].price, false, false) + ")";
				this.buyButton.gameObject.SetActive(true);
				return;
			}
			this.buyButton.gameObject.SetActive(false);
		}

		// Token: 0x04003B3D RID: 15165
		[Header("References")]
		[SerializeField]
		protected RectTransform colorButtonContainer;

		// Token: 0x04003B3E RID: 15166
		[SerializeField]
		protected Button buyButton;

		// Token: 0x04003B3F RID: 15167
		[SerializeField]
		protected TextMeshProUGUI buyButtonText;

		// Token: 0x04003B40 RID: 15168
		[SerializeField]
		protected TextMeshProUGUI colorLabel;

		// Token: 0x04003B41 RID: 15169
		[SerializeField]
		protected RectTransform bar;

		// Token: 0x04003B42 RID: 15170
		[Header("Prefab")]
		[SerializeField]
		protected GameObject colorButtonPrefab;

		// Token: 0x04003B43 RID: 15171
		public UnityEvent<ColorFeature.NamedColor> onSelectionChanged;

		// Token: 0x04003B44 RID: 15172
		public UnityEvent<ColorFeature.NamedColor> onSelectionPurchased;

		// Token: 0x04003B45 RID: 15173
		private ColorFeature specificFeature;

		// Token: 0x04003B46 RID: 15174
		private int selectionIndex;
	}
}
