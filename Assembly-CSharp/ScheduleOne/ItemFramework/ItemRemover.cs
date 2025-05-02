using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000953 RID: 2387
	public class ItemRemover : MonoBehaviour
	{
		// Token: 0x06004078 RID: 16504 RVA: 0x0010EE2C File Offset: 0x0010D02C
		public void Remove()
		{
			PlayerSingleton<PlayerInventory>.Instance.RemoveAmountOfItem(this.Item.ID, (uint)this.Quantity);
		}

		// Token: 0x04002E56 RID: 11862
		public ItemDefinition Item;

		// Token: 0x04002E57 RID: 11863
		public int Quantity;
	}
}
