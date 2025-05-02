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
	// Token: 0x02000AED RID: 2797
	public class ObjectFieldUI : MonoBehaviour
	{
		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06004AC7 RID: 19143 RVA: 0x0013A109 File Offset: 0x00138309
		// (set) Token: 0x06004AC8 RID: 19144 RVA: 0x0013A111 File Offset: 0x00138311
		public List<ObjectField> Fields { get; protected set; } = new List<ObjectField>();

		// Token: 0x06004AC9 RID: 19145 RVA: 0x0013A11C File Offset: 0x0013831C
		public void Bind(List<ObjectField> field)
		{
			this.Fields = new List<ObjectField>();
			this.Fields.AddRange(field);
			this.Fields[this.Fields.Count - 1].onObjectChanged.AddListener(new UnityAction<BuildableItem>(this.Refresh));
			this.Refresh(this.Fields[0].SelectedObject);
		}

		// Token: 0x06004ACA RID: 19146 RVA: 0x0013A188 File Offset: 0x00138388
		private void Refresh(BuildableItem newVal)
		{
			this.IconImg.gameObject.SetActive(false);
			this.NoneSelected.gameObject.SetActive(false);
			this.MultipleSelected.gameObject.SetActive(false);
			if (this.AreFieldsUniform())
			{
				if (newVal != null)
				{
					this.IconImg.sprite = newVal.ItemInstance.Icon;
					this.SelectionLabel.text = newVal.ItemInstance.Name;
					this.IconImg.gameObject.SetActive(true);
				}
				else
				{
					this.NoneSelected.SetActive(true);
					this.SelectionLabel.text = "None";
				}
			}
			else
			{
				this.MultipleSelected.SetActive(true);
				this.SelectionLabel.text = "Mixed";
			}
			ObjectField objectField = this.Fields.FirstOrDefault((ObjectField x) => x.SelectedObject != null);
			this.ClearButton.gameObject.SetActive(objectField != null);
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x0013A294 File Offset: 0x00138494
		private bool AreFieldsUniform()
		{
			for (int i = 0; i < this.Fields.Count - 1; i++)
			{
				if (this.Fields[i].SelectedObject != this.Fields[i + 1].SelectedObject)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004ACC RID: 19148 RVA: 0x0013A2E8 File Offset: 0x001384E8
		public void Clicked()
		{
			BuildableItem buildableItem = null;
			if (this.AreFieldsUniform())
			{
				buildableItem = this.Fields[0].SelectedObject;
			}
			List<BuildableItem> list = new List<BuildableItem>();
			if (buildableItem != null)
			{
				list.Add(buildableItem);
			}
			List<Transform> list2 = new List<Transform>();
			for (int i = 0; i < this.Fields.Count; i++)
			{
				if (this.Fields[i].DrawTransitLine)
				{
					list2.Add(this.Fields[i].ParentConfig.Configurable.UIPoint);
				}
			}
			Singleton<ManagementInterface>.Instance.ObjectSelector.Open(this.InstructionText, this.ExtendedInstructionText, 1, list, this.Fields[0].TypeRequirements, this.Fields[0].ParentConfig.Configurable.ParentProperty, new ObjectSelector.ObjectFilter(this.ObjectValid), new Action<List<BuildableItem>>(this.ObjectsSelected), list2);
		}

		// Token: 0x06004ACD RID: 19149 RVA: 0x0013A3DC File Offset: 0x001385DC
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

		// Token: 0x06004ACE RID: 19150 RVA: 0x0013A442 File Offset: 0x00138642
		public void ObjectsSelected(List<BuildableItem> objs)
		{
			this.ObjectSelected((objs.Count > 0) ? objs[objs.Count - 1] : null);
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x0013A464 File Offset: 0x00138664
		private void ObjectSelected(BuildableItem obj)
		{
			if (obj != null && this.Fields[0].TypeRequirements.Count > 0 && !this.Fields[0].TypeRequirements.Contains(obj.GetType()))
			{
				Console.LogError("Wrong Object type selection", null);
				return;
			}
			foreach (ObjectField objectField in this.Fields)
			{
				objectField.SetObject(obj, true);
			}
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x0013A504 File Offset: 0x00138704
		public void ClearClicked()
		{
			this.ObjectSelected(null);
		}

		// Token: 0x04003815 RID: 14357
		[Header("References")]
		public string InstructionText = "Select <ObjectType>";

		// Token: 0x04003816 RID: 14358
		public string ExtendedInstructionText = string.Empty;

		// Token: 0x04003817 RID: 14359
		public TextMeshProUGUI FieldLabel;

		// Token: 0x04003818 RID: 14360
		public Image IconImg;

		// Token: 0x04003819 RID: 14361
		public TextMeshProUGUI SelectionLabel;

		// Token: 0x0400381A RID: 14362
		public GameObject NoneSelected;

		// Token: 0x0400381B RID: 14363
		public GameObject MultipleSelected;

		// Token: 0x0400381C RID: 14364
		public RectTransform ClearButton;
	}
}
