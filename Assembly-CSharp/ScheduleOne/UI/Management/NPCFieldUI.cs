using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using ScheduleOne.NPCs;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AEA RID: 2794
	public class NPCFieldUI : MonoBehaviour
	{
		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06004AB4 RID: 19124 RVA: 0x00139C0B File Offset: 0x00137E0B
		// (set) Token: 0x06004AB5 RID: 19125 RVA: 0x00139C13 File Offset: 0x00137E13
		public List<NPCField> Fields { get; protected set; } = new List<NPCField>();

		// Token: 0x06004AB6 RID: 19126 RVA: 0x00139C1C File Offset: 0x00137E1C
		public void Bind(List<NPCField> field)
		{
			this.Fields = new List<NPCField>();
			this.Fields.AddRange(field);
			this.Fields[this.Fields.Count - 1].onNPCChanged.AddListener(new UnityAction<NPC>(this.Refresh));
			this.Refresh(this.Fields[0].SelectedNPC);
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x00139C88 File Offset: 0x00137E88
		private void Refresh(NPC newVal)
		{
			this.IconImg.gameObject.SetActive(false);
			this.NoneSelected.gameObject.SetActive(false);
			this.MultipleSelected.gameObject.SetActive(false);
			if (this.AreFieldsUniform())
			{
				if (newVal != null)
				{
					this.IconImg.sprite = newVal.MugshotSprite;
					this.SelectionLabel.text = newVal.FirstName + "\n" + newVal.LastName;
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
			NPCField npcfield = this.Fields.FirstOrDefault((NPCField x) => x.SelectedNPC != null);
			this.ClearButton.gameObject.SetActive(npcfield != null);
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x00139D98 File Offset: 0x00137F98
		private bool AreFieldsUniform()
		{
			for (int i = 0; i < this.Fields.Count - 1; i++)
			{
				if (this.Fields[i].SelectedNPC != this.Fields[i + 1].SelectedNPC)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x00139DEC File Offset: 0x00137FEC
		public void Clicked()
		{
			this.AreFieldsUniform();
			Singleton<ManagementInterface>.Instance.NPCSelector.Open("Select " + this.FieldLabel.text, this.Fields[0].TypeRequirement, new Action<NPC>(this.NPCSelected));
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x00139E44 File Offset: 0x00138044
		public void NPCSelected(NPC npc)
		{
			if (npc != null && npc.GetType() != this.Fields[0].TypeRequirement)
			{
				Console.LogError("Wrong NPC type selection", null);
				return;
			}
			foreach (NPCField npcfield in this.Fields)
			{
				npcfield.SetNPC(npc, true);
			}
		}

		// Token: 0x06004ABB RID: 19131 RVA: 0x00139ECC File Offset: 0x001380CC
		public void ClearClicked()
		{
			this.NPCSelected(null);
		}

		// Token: 0x04003806 RID: 14342
		[Header("References")]
		public TextMeshProUGUI FieldLabel;

		// Token: 0x04003807 RID: 14343
		public Image IconImg;

		// Token: 0x04003808 RID: 14344
		public TextMeshProUGUI SelectionLabel;

		// Token: 0x04003809 RID: 14345
		public GameObject NoneSelected;

		// Token: 0x0400380A RID: 14346
		public GameObject MultipleSelected;

		// Token: 0x0400380B RID: 14347
		public RectTransform ClearButton;
	}
}
