using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AE9 RID: 2793
	public class ItemFieldUI : MonoBehaviour
	{
		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06004AAC RID: 19116 RVA: 0x001398C8 File Offset: 0x00137AC8
		// (set) Token: 0x06004AAD RID: 19117 RVA: 0x001398D0 File Offset: 0x00137AD0
		public List<ItemField> Fields { get; protected set; } = new List<ItemField>();

		// Token: 0x06004AAE RID: 19118 RVA: 0x001398DC File Offset: 0x00137ADC
		public void Bind(List<ItemField> field)
		{
			this.Fields = new List<ItemField>();
			this.Fields.AddRange(field);
			this.Fields[this.Fields.Count - 1].onItemChanged.AddListener(new UnityAction<ItemDefinition>(this.Refresh));
			this.Refresh(this.Fields[0].SelectedItem);
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x00139948 File Offset: 0x00137B48
		private void Refresh(ItemDefinition newVal)
		{
			this.IconImg.gameObject.SetActive(false);
			this.NoneSelected.gameObject.SetActive(false);
			this.MultipleSelected.gameObject.SetActive(false);
			if (!this.AreFieldsUniform())
			{
				this.MultipleSelected.SetActive(true);
				this.SelectionLabel.text = "Mixed";
				return;
			}
			if (newVal != null)
			{
				this.IconImg.sprite = newVal.Icon;
				this.SelectionLabel.text = newVal.Name;
				this.IconImg.gameObject.SetActive(true);
				return;
			}
			this.NoneSelected.SetActive(true);
			this.SelectionLabel.text = (this.ShowNoneAsAny ? "Any" : "None");
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x00139A18 File Offset: 0x00137C18
		private bool AreFieldsUniform()
		{
			for (int i = 0; i < this.Fields.Count - 1; i++)
			{
				if (this.Fields[i].SelectedItem != this.Fields[i + 1].SelectedItem)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x00139A6C File Offset: 0x00137C6C
		public void Clicked()
		{
			List<ItemSelector.Option> list = new List<ItemSelector.Option>();
			ItemSelector.Option selectedOption = null;
			bool flag = this.AreFieldsUniform();
			if (this.Fields[0].CanSelectNone)
			{
				list.Add(new ItemSelector.Option(this.ShowNoneAsAny ? "Any" : "None", null));
				if (flag && this.Fields[0].SelectedItem == null)
				{
					selectedOption = list[0];
				}
			}
			foreach (ItemDefinition itemDefinition in this.Fields[0].Options)
			{
				ItemSelector.Option option = new ItemSelector.Option(itemDefinition.Name, itemDefinition);
				list.Add(option);
				if (flag && this.Fields[0].SelectedItem == option.Item)
				{
					selectedOption = option;
				}
			}
			Singleton<ManagementInterface>.Instance.ItemSelectorScreen.Initialize(this.FieldLabel.text, list, selectedOption, new Action<ItemSelector.Option>(this.OptionSelected));
			Singleton<ManagementInterface>.Instance.ItemSelectorScreen.Open();
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x00139BA0 File Offset: 0x00137DA0
		private void OptionSelected(ItemSelector.Option option)
		{
			foreach (ItemField itemField in this.Fields)
			{
				itemField.SetItem(option.Item, true);
			}
		}

		// Token: 0x040037FF RID: 14335
		public bool ShowNoneAsAny;

		// Token: 0x04003800 RID: 14336
		[Header("References")]
		public TextMeshProUGUI FieldLabel;

		// Token: 0x04003801 RID: 14337
		public Image IconImg;

		// Token: 0x04003802 RID: 14338
		public TextMeshProUGUI SelectionLabel;

		// Token: 0x04003803 RID: 14339
		public GameObject NoneSelected;

		// Token: 0x04003804 RID: 14340
		public GameObject MultipleSelected;
	}
}
