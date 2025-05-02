using System;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000932 RID: 2354
	[CreateAssetMenu(fileName = "CashDefinition", menuName = "ScriptableObjects/CashDefinition", order = 1)]
	[Serializable]
	public class CashDefinition : StorableItemDefinition
	{
		// Token: 0x06004002 RID: 16386 RVA: 0x0010E02C File Offset: 0x0010C22C
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return new CashInstance(this, quantity);
		}
	}
}
