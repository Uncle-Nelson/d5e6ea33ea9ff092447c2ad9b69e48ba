using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AF0 RID: 2800
	public class QualityFieldUI : MonoBehaviour
	{
		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06004ADE RID: 19166 RVA: 0x0013A9C4 File Offset: 0x00138BC4
		// (set) Token: 0x06004ADF RID: 19167 RVA: 0x0013A9CC File Offset: 0x00138BCC
		public List<QualityField> Fields { get; protected set; } = new List<QualityField>();

		// Token: 0x06004AE0 RID: 19168 RVA: 0x0013A9D8 File Offset: 0x00138BD8
		public void Bind(List<QualityField> field)
		{
			this.Fields = new List<QualityField>();
			this.Fields.AddRange(field);
			this.Fields[this.Fields.Count - 1].onValueChanged.AddListener(new UnityAction<EQuality>(this.Refresh));
			for (int i = 0; i < this.QualityButtons.Length; i++)
			{
				EQuality quality = (EQuality)i;
				this.QualityButtons[i].onClick.AddListener(new UnityAction(delegate()
				{
					this.ValueChanged(quality);
				}));
			}
			this.Refresh(this.Fields[0].Value);
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x0013AA88 File Offset: 0x00138C88
		private void Refresh(EQuality value)
		{
			if (this.AreFieldsUniform())
			{
				EQuality value2 = this.Fields[0].Value;
				for (int i = 0; i < this.QualityButtons.Length; i++)
				{
					EQuality equality = (EQuality)i;
					this.QualityButtons[i].interactable = (equality != value2);
				}
				return;
			}
			Button[] qualityButtons = this.QualityButtons;
			for (int j = 0; j < qualityButtons.Length; j++)
			{
				qualityButtons[j].interactable = true;
			}
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x0013AAFC File Offset: 0x00138CFC
		private bool AreFieldsUniform()
		{
			for (int i = 0; i < this.Fields.Count - 1; i++)
			{
				if (this.Fields[i].Value != this.Fields[i + 1].Value)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x0013AB4C File Offset: 0x00138D4C
		public void ValueChanged(EQuality value)
		{
			for (int i = 0; i < this.Fields.Count; i++)
			{
				this.Fields[i].SetValue(value, true);
			}
		}

		// Token: 0x0400382B RID: 14379
		[Header("References")]
		public TextMeshProUGUI FieldLabel;

		// Token: 0x0400382C RID: 14380
		public Button[] QualityButtons;
	}
}
