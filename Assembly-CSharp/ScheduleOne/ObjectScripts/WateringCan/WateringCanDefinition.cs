using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x02000BF9 RID: 3065
	[CreateAssetMenu(fileName = "WateringCanDefinition", menuName = "ScriptableObjects/Item Definitions/WateringCanDefinition", order = 1)]
	[Serializable]
	public class WateringCanDefinition : StorableItemDefinition
	{
		// Token: 0x0600565A RID: 22106 RVA: 0x0016B5DE File Offset: 0x001697DE
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return new WateringCanInstance(this, quantity, 0f);
		}

		// Token: 0x04003FBA RID: 16314
		public const float Capacity = 15f;

		// Token: 0x04003FBB RID: 16315
		public GameObject FunctionalWateringCanPrefab;
	}
}
