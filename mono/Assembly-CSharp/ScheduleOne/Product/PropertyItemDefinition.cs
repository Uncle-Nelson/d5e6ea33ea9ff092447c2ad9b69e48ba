using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.Properties;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000903 RID: 2307
	[CreateAssetMenu(fileName = "PropertyItemDefinition", menuName = "ScriptableObjects/PropertyItemDefinition", order = 1)]
	[Serializable]
	public class PropertyItemDefinition : StorableItemDefinition
	{
		// Token: 0x06003EAF RID: 16047 RVA: 0x00108A57 File Offset: 0x00106C57
		public virtual void Initialize(List<Property> properties)
		{
			this.Properties.AddRange(properties);
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x00108A65 File Offset: 0x00106C65
		public bool HasProperty(Property property)
		{
			return this.Properties.Contains(property);
		}

		// Token: 0x04002CE8 RID: 11496
		[Header("Properties")]
		public List<Property> Properties = new List<Property>();
	}
}
