using System;
using System.Collections.Generic;
using ScheduleOne.Property;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A39 RID: 2617
	public class PropertyDropdown : MonoBehaviour
	{
		// Token: 0x0600468F RID: 18063 RVA: 0x001281D4 File Offset: 0x001263D4
		protected virtual void Awake()
		{
			List<string> list = new List<string>();
			list.Add("None");
			this.TMP_dropdown = base.GetComponent<TMP_Dropdown>();
			if (this.TMP_dropdown != null)
			{
				this.TMP_dropdown.onValueChanged.AddListener(new UnityAction<int>(this.ValueChanged));
				this.TMP_dropdown.AddOptions(list);
			}
			this.dropdown = base.GetComponent<Dropdown>();
			if (this.dropdown != null)
			{
				this.dropdown.onValueChanged.AddListener(new UnityAction<int>(this.ValueChanged));
				this.dropdown.AddOptions(list);
			}
			this.intToProperty.Add(0, null);
			Property.onPropertyAcquired = (Property.PropertyChange)Delegate.Combine(Property.onPropertyAcquired, new Property.PropertyChange(this.PropertyAcquired));
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x001282A4 File Offset: 0x001264A4
		private void PropertyAcquired(Property p)
		{
			List<string> list = new List<string>();
			list.Add(p.PropertyName);
			if (this.dropdown != null)
			{
				this.intToProperty.Add(this.dropdown.options.Count, p);
				this.dropdown.AddOptions(list);
			}
			if (this.TMP_dropdown != null)
			{
				this.intToProperty.Add(this.TMP_dropdown.options.Count, p);
				this.TMP_dropdown.AddOptions(list);
			}
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x0012832F File Offset: 0x0012652F
		private void ValueChanged(int newVal)
		{
			this.selectedProperty = this.intToProperty[newVal];
			if (this.onSelectionChanged != null)
			{
				this.onSelectionChanged();
			}
		}

		// Token: 0x0400341B RID: 13339
		public Property selectedProperty;

		// Token: 0x0400341C RID: 13340
		private TMP_Dropdown TMP_dropdown;

		// Token: 0x0400341D RID: 13341
		private Dropdown dropdown;

		// Token: 0x0400341E RID: 13342
		private Dictionary<int, Property> intToProperty = new Dictionary<int, Property>();

		// Token: 0x0400341F RID: 13343
		public Action onSelectionChanged;
	}
}
