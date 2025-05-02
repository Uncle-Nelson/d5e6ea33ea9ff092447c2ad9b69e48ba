using System;
using EasyButtons;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x02000301 RID: 769
	public class SystemTriggerObject : MonoBehaviour
	{
		// Token: 0x0600110F RID: 4367 RVA: 0x0004C22F File Offset: 0x0004A42F
		[Button]
		public void Trigger()
		{
			this.SystemTrigger.Trigger();
		}

		// Token: 0x04001138 RID: 4408
		public SystemTrigger SystemTrigger;
	}
}
