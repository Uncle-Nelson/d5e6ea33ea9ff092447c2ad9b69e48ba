using System;
using System.Collections.Generic;
using ScheduleOne.Construction.Features;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Construction.Features
{
	// Token: 0x02000B87 RID: 2951
	public class FI_OptionList : FI_Base
	{
		// Token: 0x06004E84 RID: 20100 RVA: 0x0014B784 File Offset: 0x00149984
		public virtual void Initialize(OptionListFeature _feature, List<FI_OptionList.Option> _options)
		{
			base.Initialize(_feature);
			this.specificFeature = _feature;
			this.options.AddRange(_options);
			this.selectionIndex = this.specificFeature.SyncAccessor_ownedOptionIndex;
			for (int i = 0; i < this.options.Count; i++)
			{
				Button component = Object.Instantiate<GameObject>(this.buttonPrefab, this.buttonContainer).GetComponent<Button>();
				component.GetComponent<Image>().color = this.options[i].optionColor;
				component.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = this.options[i].optionLabel;
				int index = i;
				component.onClick.AddListener(new UnityAction(delegate()
				{
					this.Select(index);
				}));
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.buttonContainer);
			this.bar.anchoredPosition = new Vector2(this.bar.anchoredPosition.x, this.buttonContainer.GetChild(this.buttonContainer.childCount - 1).GetComponent<RectTransform>().anchoredPosition.y - 35f);
			this.UpdateSelection();
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x0014B8BD File Offset: 0x00149ABD
		public override void Close()
		{
			this.Select(this.specificFeature.SyncAccessor_ownedOptionIndex);
			base.Close();
		}

		// Token: 0x06004E86 RID: 20102 RVA: 0x0014B8D8 File Offset: 0x00149AD8
		public void BuyButtonClicked()
		{
			if (NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance < this.options[this.selectionIndex].optionPrice)
			{
				return;
			}
			NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction(Singleton<ConstructionMenu>.Instance.SelectedConstructable.ConstructableName + ": " + this.feature.featureName, -this.options[this.selectionIndex].optionPrice, 1f, string.Empty);
			if (this.onSelectionPurchased != null)
			{
				this.onSelectionPurchased.Invoke(this.selectionIndex);
			}
			this.UpdateSelection();
		}

		// Token: 0x06004E87 RID: 20103 RVA: 0x0014B976 File Offset: 0x00149B76
		public void Select(int index)
		{
			this.selectionIndex = Mathf.Clamp(index, 0, this.options.Count - 1);
			if (this.onSelectionChanged != null)
			{
				this.onSelectionChanged.Invoke(this.selectionIndex);
			}
			this.UpdateSelection();
		}

		// Token: 0x06004E88 RID: 20104 RVA: 0x0014B9B4 File Offset: 0x00149BB4
		private void UpdateSelection()
		{
			for (int i = 0; i < this.buttonContainer.childCount; i++)
			{
				this.buttonContainer.GetChild(i).Find("SelectionIndicator").gameObject.SetActive(false);
				this.buttonContainer.GetChild(i).Find("OwnedIndicator").gameObject.SetActive(false);
			}
			this.buttonContainer.GetChild(this.selectionIndex).Find("SelectionIndicator").gameObject.SetActive(true);
			this.buttonContainer.GetChild(this.specificFeature.SyncAccessor_ownedOptionIndex).Find("OwnedIndicator").gameObject.SetActive(true);
			if (this.selectionIndex != this.specificFeature.SyncAccessor_ownedOptionIndex)
			{
				this.buyButtonText.text = "Buy (" + MoneyManager.FormatAmount(this.options[this.selectionIndex].optionPrice, false, false) + ")";
				this.buyButton.gameObject.SetActive(true);
				return;
			}
			this.buyButton.gameObject.SetActive(false);
		}

		// Token: 0x04003B4B RID: 15179
		[Header("References")]
		[SerializeField]
		protected RectTransform buttonContainer;

		// Token: 0x04003B4C RID: 15180
		[SerializeField]
		protected Button buyButton;

		// Token: 0x04003B4D RID: 15181
		[SerializeField]
		protected TextMeshProUGUI buyButtonText;

		// Token: 0x04003B4E RID: 15182
		[SerializeField]
		protected RectTransform bar;

		// Token: 0x04003B4F RID: 15183
		[Header("Prefab")]
		[SerializeField]
		protected GameObject buttonPrefab;

		// Token: 0x04003B50 RID: 15184
		public UnityEvent<int> onSelectionChanged;

		// Token: 0x04003B51 RID: 15185
		public UnityEvent<int> onSelectionPurchased;

		// Token: 0x04003B52 RID: 15186
		private List<FI_OptionList.Option> options = new List<FI_OptionList.Option>();

		// Token: 0x04003B53 RID: 15187
		public OptionListFeature specificFeature;

		// Token: 0x04003B54 RID: 15188
		private int selectionIndex;

		// Token: 0x02000B88 RID: 2952
		public class Option
		{
			// Token: 0x06004E8A RID: 20106 RVA: 0x0014BAEA File Offset: 0x00149CEA
			public Option(string _optionLabel, Color _optionColor, float _optionPrice)
			{
				this.optionLabel = _optionLabel;
				this.optionColor = _optionColor;
				this.optionPrice = _optionPrice;
			}

			// Token: 0x04003B55 RID: 15189
			public string optionLabel;

			// Token: 0x04003B56 RID: 15190
			public Color optionColor;

			// Token: 0x04003B57 RID: 15191
			public float optionPrice;
		}
	}
}
