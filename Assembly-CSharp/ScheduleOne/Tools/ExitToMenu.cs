using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000857 RID: 2135
	public class ExitToMenu : MonoBehaviour
	{
		// Token: 0x06003A6E RID: 14958 RVA: 0x000F6B88 File Offset: 0x000F4D88
		public void Exit()
		{
			Singleton<LoadManager>.Instance.ExitToMenu(null, null, false);
		}
	}
}
