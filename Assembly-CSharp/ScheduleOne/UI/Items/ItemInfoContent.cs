using System;
using ScheduleOne.ItemFramework;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000B72 RID: 2930
	public class ItemInfoContent : MonoBehaviour
	{
		// Token: 0x06004DFA RID: 19962 RVA: 0x001482C3 File Offset: 0x001464C3
		public virtual void Initialize(ItemInstance instance)
		{
			this.NameLabel.text = instance.Name;
			this.DescriptionLabel.text = instance.Description;
		}

		// Token: 0x06004DFB RID: 19963 RVA: 0x001482E7 File Offset: 0x001464E7
		public virtual void Initialize(ItemDefinition definition)
		{
			this.NameLabel.text = definition.Name;
			this.DescriptionLabel.text = definition.Description;
		}

		// Token: 0x04003ACA RID: 15050
		[Header("Settings")]
		public float Height = 90f;

		// Token: 0x04003ACB RID: 15051
		[Header("References")]
		public TextMeshProUGUI NameLabel;

		// Token: 0x04003ACC RID: 15052
		public TextMeshProUGUI DescriptionLabel;
	}
}
