using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000B38 RID: 2872
	public class CharacterCustomizationCategory : MonoBehaviour
	{
		// Token: 0x06004C68 RID: 19560 RVA: 0x001428EC File Offset: 0x00140AEC
		private void Awake()
		{
			this.ui = base.GetComponentInParent<CharacterCustomizationUI>();
			this.options = base.GetComponentsInChildren<CharacterCustomizationOption>(true);
			this.TitleText.text = this.CategoryName;
			this.BackButton.onClick.AddListener(new UnityAction(this.Back));
			for (int i = 0; i < this.options.Length; i++)
			{
				CharacterCustomizationOption option = this.options[i];
				this.options[i].onSelect.AddListener(new UnityAction(delegate()
				{
					this.OptionSelected(option);
				}));
				this.options[i].onDeselect.AddListener(new UnityAction(delegate()
				{
					this.OptionDeselected(option);
				}));
				this.options[i].onPurchase.AddListener(new UnityAction(delegate()
				{
					this.OptionPurchased(option);
				}));
			}
			for (int j = 0; j < this.options.Length; j++)
			{
				for (int k = j + 1; k < this.options.Length; k++)
				{
					if (this.options[k].Price < this.options[j].Price)
					{
						Transform transform = this.options[j].transform;
						this.options[j].transform.SetSiblingIndex(k);
						this.options[k].transform.SetSiblingIndex(j);
					}
				}
			}
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x00142A44 File Offset: 0x00140C44
		public void Open()
		{
			bool flag = false;
			for (int i = 0; i < this.options.Length; i++)
			{
				if (this.ui.IsOptionCurrentlyApplied(this.options[i]))
				{
					flag = true;
					this.options[i].SetPurchased(true);
				}
				else
				{
					this.options[i].SetPurchased(false);
					this.options[i].SetSelected(false);
				}
			}
			if (!flag && this.options.Length != 0)
			{
				this.options[0].SetPurchased(true);
			}
			this.ScrollRect.verticalScrollbar.value = 1f;
			if (this.onOpen != null)
			{
				this.onOpen.Invoke();
			}
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x00142AEC File Offset: 0x00140CEC
		public void Back()
		{
			this.ui.SetActiveCategory(null);
			for (int i = 0; i < this.options.Length; i++)
			{
				this.options[i].ParentCategoryClosed();
			}
			if (this.onClose != null)
			{
				this.onClose.Invoke();
			}
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x00142B38 File Offset: 0x00140D38
		private void OptionSelected(CharacterCustomizationOption option)
		{
			this.ui.OptionSelected(option);
			for (int i = 0; i < this.options.Length; i++)
			{
				this.options[i].SiblingOptionSelected(option);
			}
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x00142B72 File Offset: 0x00140D72
		private void OptionDeselected(CharacterCustomizationOption option)
		{
			this.ui.OptionDeselected(option);
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x00142B80 File Offset: 0x00140D80
		private void OptionPurchased(CharacterCustomizationOption option)
		{
			this.ui.OptionPurchased(option);
			for (int i = 0; i < this.options.Length; i++)
			{
				this.options[i].SiblingOptionPurchased(option);
			}
		}

		// Token: 0x04003987 RID: 14727
		public string CategoryName;

		// Token: 0x04003988 RID: 14728
		[Header("References")]
		public TextMeshProUGUI TitleText;

		// Token: 0x04003989 RID: 14729
		public Button BackButton;

		// Token: 0x0400398A RID: 14730
		public ScrollRect ScrollRect;

		// Token: 0x0400398B RID: 14731
		private CharacterCustomizationUI ui;

		// Token: 0x0400398C RID: 14732
		private CharacterCustomizationOption[] options;

		// Token: 0x0400398D RID: 14733
		public UnityEvent onOpen;

		// Token: 0x0400398E RID: 14734
		public UnityEvent onClose;
	}
}
