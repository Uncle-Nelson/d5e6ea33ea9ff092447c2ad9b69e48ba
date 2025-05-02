using System;
using System.Collections.Generic;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AEC RID: 2796
	public class NumberFieldUI : MonoBehaviour
	{
		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06004AC0 RID: 19136 RVA: 0x00139F02 File Offset: 0x00138102
		// (set) Token: 0x06004AC1 RID: 19137 RVA: 0x00139F0A File Offset: 0x0013810A
		public List<NumberField> Fields { get; protected set; } = new List<NumberField>();

		// Token: 0x06004AC2 RID: 19138 RVA: 0x00139F14 File Offset: 0x00138114
		public void Bind(List<NumberField> field)
		{
			this.Fields = new List<NumberField>();
			this.Fields.AddRange(field);
			this.Fields[this.Fields.Count - 1].onItemChanged.AddListener(new UnityAction<float>(this.Refresh));
			this.MinValueLabel.text = this.Fields[0].MinValue.ToString();
			this.MaxValueLabel.text = this.Fields[0].MaxValue.ToString();
			this.Slider.minValue = this.Fields[0].MinValue;
			this.Slider.maxValue = this.Fields[0].MaxValue;
			this.Slider.wholeNumbers = this.Fields[0].WholeNumbers;
			this.Slider.onValueChanged.AddListener(new UnityAction<float>(this.ValueChanged));
			this.Refresh(this.Fields[0].Value);
		}

		// Token: 0x06004AC3 RID: 19139 RVA: 0x0013A035 File Offset: 0x00138235
		private void Refresh(float newVal)
		{
			if (this.AreFieldsUniform())
			{
				this.ValueLabel.text = newVal.ToString();
			}
			else
			{
				this.ValueLabel.text = "#";
			}
			this.Slider.SetValueWithoutNotify(newVal);
		}

		// Token: 0x06004AC4 RID: 19140 RVA: 0x0013A070 File Offset: 0x00138270
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

		// Token: 0x06004AC5 RID: 19141 RVA: 0x0013A0C0 File Offset: 0x001382C0
		public void ValueChanged(float value)
		{
			for (int i = 0; i < this.Fields.Count; i++)
			{
				this.Fields[i].SetValue(value, true);
			}
		}

		// Token: 0x0400380F RID: 14351
		[Header("References")]
		public TextMeshProUGUI FieldLabel;

		// Token: 0x04003810 RID: 14352
		public Slider Slider;

		// Token: 0x04003811 RID: 14353
		public TextMeshProUGUI ValueLabel;

		// Token: 0x04003812 RID: 14354
		public TextMeshProUGUI MinValueLabel;

		// Token: 0x04003813 RID: 14355
		public TextMeshProUGUI MaxValueLabel;
	}
}
