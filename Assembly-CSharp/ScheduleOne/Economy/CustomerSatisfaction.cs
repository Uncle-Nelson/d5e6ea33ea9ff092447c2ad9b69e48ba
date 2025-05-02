using System;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x02000678 RID: 1656
	public class CustomerSatisfaction
	{
		// Token: 0x06002DA5 RID: 11685 RVA: 0x000BED58 File Offset: 0x000BCF58
		public static float GetRelationshipChange(float satisfaction)
		{
			return Mathf.Lerp(-0.5f, 0.5f, satisfaction);
		}
	}
}
