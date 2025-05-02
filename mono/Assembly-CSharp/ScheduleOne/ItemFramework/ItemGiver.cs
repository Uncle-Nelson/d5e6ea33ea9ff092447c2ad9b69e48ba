using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200094C RID: 2380
	public class ItemGiver : MonoBehaviour
	{
		// Token: 0x06004046 RID: 16454 RVA: 0x0010E680 File Offset: 0x0010C880
		public void Give()
		{
			PlayerSingleton<PlayerInventory>.Instance.AddItemToInventory(this.Item.GetDefaultInstance(this.Quantity));
		}

		// Token: 0x04002E32 RID: 11826
		public ItemDefinition Item;

		// Token: 0x04002E33 RID: 11827
		public int Quantity;
	}
}
