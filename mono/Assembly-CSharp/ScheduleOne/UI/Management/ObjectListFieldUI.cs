using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AEF RID: 2799
	public class ObjectListFieldUI : MonoBehaviour
	{
		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06004AD5 RID: 19157 RVA: 0x0013A550 File Offset: 0x00138750
		// (set) Token: 0x06004AD6 RID: 19158 RVA: 0x0013A558 File Offset: 0x00138758
		public List<ObjectListField> Fields { get; protected set; } = new List<ObjectListField>();

		// Token: 0x06004AD7 RID: 19159 RVA: 0x0013A564 File Offset: 0x00138764
		public void Bind(List<ObjectListField> field)
		{
			this.Fields = new List<ObjectListField>();
			this.Fields.AddRange(field);
			this.Fields[this.Fields.Count - 1].onListChanged.AddListener(new UnityAction<List<BuildableItem>>(this.Refresh));
			this.Refresh(this.Fields[0].SelectedObjects);
			if (field.Count == 1)
			{
				this.EditIcon.gameObject.SetActive(true);
				this.NoMultiEdit.gameObject.SetActive(false);
				this.Button.interactable = true;
				return;
			}
			this.EditIcon.gameObject.SetActive(false);
			this.NoMultiEdit.gameObject.SetActive(true);
			this.Button.interactable = false;
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x0013A634 File Offset: 0x00138834
		private void Refresh(List<BuildableItem> newVal)
		{
			this.NoneSelected.gameObject.SetActive(false);
			this.MultipleSelected.gameObject.SetActive(false);
			bool flag = this.AreFieldsUniform();
			if (flag)
			{
				if (this.Fields[0].SelectedObjects.Count == 0)
				{
					this.NoneSelected.SetActive(true);
				}
			}
			else
			{
				this.MultipleSelected.SetActive(true);
			}
			if (this.Fields.Count == 1)
			{
				this.FieldLabel.text = string.Concat(new string[]
				{
					this.FieldText,
					" (",
					newVal.Count.ToString(),
					"/",
					this.Fields[0].MaxItems.ToString(),
					")"
				});
			}
			else
			{
				this.FieldLabel.text = this.FieldText;
			}
			for (int i = 0; i < this.Entries.Length; i++)
			{
				if (flag && this.Fields[0].SelectedObjects.Count > i)
				{
					this.Entries[i].Find("Title").GetComponent<TextMeshProUGUI>().text = this.Fields[0].SelectedObjects[i].ItemInstance.Name;
					this.Entries[i].Find("Title").gameObject.SetActive(true);
				}
				else
				{
					this.Entries[i].Find("Title").gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x0013A7D0 File Offset: 0x001389D0
		private bool AreFieldsUniform()
		{
			for (int i = 0; i < this.Fields.Count - 1; i++)
			{
				if (!this.Fields[i].SelectedObjects.SequenceEqual(this.Fields[i + 1].SelectedObjects))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x0013A824 File Offset: 0x00138A24
		public void Clicked()
		{
			List<BuildableItem> list = new List<BuildableItem>();
			if (this.AreFieldsUniform())
			{
				list.AddRange(this.Fields[0].SelectedObjects);
			}
			Singleton<ManagementInterface>.Instance.ObjectSelector.Open(this.InstructionText, this.ExtendedInstructionText, this.Fields[0].MaxItems, list, this.Fields[0].TypeRequirements, this.Fields[0].ParentConfig.Configurable.ParentProperty, new ObjectSelector.ObjectFilter(this.ObjectValid), new Action<List<BuildableItem>>(this.ObjectsSelected), null);
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x0013A8C8 File Offset: 0x00138AC8
		private bool ObjectValid(BuildableItem obj, out string reason)
		{
			string text = string.Empty;
			for (int i = 0; i < this.Fields.Count; i++)
			{
				if (this.Fields[i].objectFilter == null || this.Fields[i].objectFilter(obj, out reason))
				{
					reason = string.Empty;
					return true;
				}
				text = reason;
			}
			reason = text;
			return false;
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x0013A930 File Offset: 0x00138B30
		public void ObjectsSelected(List<BuildableItem> objs)
		{
			foreach (ObjectListField objectListField in this.Fields)
			{
				new List<BuildableItem>().AddRange(objs);
				objectListField.SetList(objs, true);
			}
		}

		// Token: 0x04003820 RID: 14368
		[Header("References")]
		public string FieldText = "Objects";

		// Token: 0x04003821 RID: 14369
		public string InstructionText = "Select <ObjectType>";

		// Token: 0x04003822 RID: 14370
		public string ExtendedInstructionText = string.Empty;

		// Token: 0x04003823 RID: 14371
		public TextMeshProUGUI FieldLabel;

		// Token: 0x04003824 RID: 14372
		public GameObject NoneSelected;

		// Token: 0x04003825 RID: 14373
		public GameObject MultipleSelected;

		// Token: 0x04003826 RID: 14374
		public RectTransform[] Entries;

		// Token: 0x04003827 RID: 14375
		public Button Button;

		// Token: 0x04003828 RID: 14376
		public GameObject EditIcon;

		// Token: 0x04003829 RID: 14377
		public GameObject NoMultiEdit;
	}
}
