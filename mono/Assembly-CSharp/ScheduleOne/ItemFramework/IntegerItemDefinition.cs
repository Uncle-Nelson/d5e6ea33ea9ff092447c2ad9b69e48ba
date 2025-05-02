using System;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000948 RID: 2376
	[CreateAssetMenu(fileName = "IntegerItemDefinition", menuName = "ScriptableObjects/IntegerItemDefinition", order = 1)]
	[Serializable]
	public class IntegerItemDefinition : StorableItemDefinition
	{
		// Token: 0x0600403C RID: 16444 RVA: 0x0010E5AB File Offset: 0x0010C7AB
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return new IntegerItemInstance(this, quantity, this.DefaultValue);
		}

		// Token: 0x04002E1C RID: 11804
		public int DefaultValue;
	}
}
