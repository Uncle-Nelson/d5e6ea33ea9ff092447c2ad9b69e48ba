using System;
using EasyButtons;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000701 RID: 1793
	public class GUIDUtility : MonoBehaviour
	{
		// Token: 0x060030B3 RID: 12467 RVA: 0x000CAA1C File Offset: 0x000C8C1C
		[Button]
		public void GenerateGUID()
		{
			Console.Log(Guid.NewGuid().ToString(), null);
		}
	}
}
