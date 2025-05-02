using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x02000BF6 RID: 3062
	[CreateAssetMenu(fileName = "TrashGrabberDefinition", menuName = "ScriptableObjects/Item Definitions/TrashGrabberDefinition", order = 1)]
	[Serializable]
	public class TrashGrabberDefinition : StorableItemDefinition
	{
		// Token: 0x0600564A RID: 22090 RVA: 0x0016B38E File Offset: 0x0016958E
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return new TrashGrabberInstance(this, quantity);
		}
	}
}
