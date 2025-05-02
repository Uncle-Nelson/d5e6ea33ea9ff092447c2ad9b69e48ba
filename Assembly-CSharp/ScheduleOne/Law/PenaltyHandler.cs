using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005D0 RID: 1488
	public static class PenaltyHandler
	{
		// Token: 0x060024DE RID: 9438 RVA: 0x0009474C File Offset: 0x0009294C
		public static List<string> ProcessCrimeList(Dictionary<Crime, int> crimes)
		{
			List<string> list = new List<string>();
			float num = 0f;
			Crime[] array = crimes.Keys.ToArray<Crime>();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] is PossessingControlledSubstances)
				{
					float num2 = 5f * (float)crimes[array[i]];
					num += num2;
					list.Add(crimes[array[i]].ToString() + " controlled substances confiscated");
				}
				else if (array[i] is PossessingLowSeverityDrug)
				{
					float num3 = 10f * (float)crimes[array[i]];
					num += num3;
					list.Add(crimes[array[i]].ToString() + " low-severity drugs confiscated");
				}
				else if (array[i] is PossessingModerateSeverityDrug)
				{
					float num4 = 20f * (float)crimes[array[i]];
					num += num4;
					list.Add(crimes[array[i]].ToString() + " moderate-severity drugs confiscated");
				}
				else if (array[i] is PossessingHighSeverityDrug)
				{
					float num5 = 30f * (float)crimes[array[i]];
					num += num5;
					list.Add(crimes[array[i]].ToString() + " high-severity drugs confiscated");
				}
				else if (array[i] is Evading)
				{
					num += 50f;
				}
				else if (array[i] is FailureToComply)
				{
					num += 50f;
				}
				else if (array[i] is ViolatingCurfew)
				{
					num += 100f;
				}
				else if (array[i] is AttemptingToSell)
				{
					num += 150f;
				}
				else if (array[i] is Assault)
				{
					num += 75f;
				}
				else if (array[i] is DeadlyAssault)
				{
					num += 150f;
				}
				else if (array[i] is Vandalism)
				{
					num += 50f;
				}
				else if (array[i] is Theft)
				{
					num += 50f;
				}
				else if (array[i] is BrandishingWeapon)
				{
					num += 50f;
				}
				else if (array[i] is DischargeFirearm)
				{
					num += 50f;
				}
			}
			if (num > 0f)
			{
				float num6 = Mathf.Min(num, NetworkSingleton<MoneyManager>.Instance.cashBalance);
				string text = MoneyManager.FormatAmount(num, true, false) + " fine";
				if (num6 == num)
				{
					text += " (paid in cash)";
				}
				else
				{
					text = text + " (" + MoneyManager.FormatAmount(num6, true, false) + " paid";
					text += " - insufficient cash)";
				}
				list.Add(text);
				if (num6 > 0f)
				{
					NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(-num6, true, false);
				}
			}
			return list;
		}

		// Token: 0x04001B61 RID: 7009
		public const float CONTROLLED_SUBSTANCE_FINE = 5f;

		// Token: 0x04001B62 RID: 7010
		public const float LOW_SEVERITY_DRUG_FINE = 10f;

		// Token: 0x04001B63 RID: 7011
		public const float MED_SEVERITY_DRUG_FINE = 20f;

		// Token: 0x04001B64 RID: 7012
		public const float HIGH_SEVERITY_DRUG_FINE = 30f;

		// Token: 0x04001B65 RID: 7013
		public const float FAILURE_TO_COMPLY_FINE = 50f;

		// Token: 0x04001B66 RID: 7014
		public const float EVADING_ARREST_FINE = 50f;

		// Token: 0x04001B67 RID: 7015
		public const float VIOLATING_CURFEW_TIME = 100f;

		// Token: 0x04001B68 RID: 7016
		public const float ATTEMPT_TO_SELL_FINE = 150f;

		// Token: 0x04001B69 RID: 7017
		public const float ASSAULT_FINE = 75f;

		// Token: 0x04001B6A RID: 7018
		public const float DEADLY_ASSAULT_FINE = 150f;

		// Token: 0x04001B6B RID: 7019
		public const float VANDALISM_FINE = 50f;

		// Token: 0x04001B6C RID: 7020
		public const float THEFT_FINE = 50f;

		// Token: 0x04001B6D RID: 7021
		public const float BRANDISHING_FINE = 50f;

		// Token: 0x04001B6E RID: 7022
		public const float DISCHARGE_FIREARM_FINE = 50f;
	}
}
