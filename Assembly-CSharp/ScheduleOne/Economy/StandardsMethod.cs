using System;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Economy
{
	// Token: 0x0200067A RID: 1658
	public static class StandardsMethod
	{
		// Token: 0x06002DA7 RID: 11687 RVA: 0x000BED6C File Offset: 0x000BCF6C
		public static string GetName(this ECustomerStandard property)
		{
			switch (property)
			{
			case ECustomerStandard.VeryLow:
				return "Very Low";
			case ECustomerStandard.Low:
				return "Low";
			case ECustomerStandard.Moderate:
				return "Moderate";
			case ECustomerStandard.High:
				return "High";
			case ECustomerStandard.VeryHigh:
				return "Very High";
			default:
				return "Standard";
			}
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x000BEDB8 File Offset: 0x000BCFB8
		public static EQuality GetCorrespondingQuality(this ECustomerStandard property)
		{
			switch (property)
			{
			case ECustomerStandard.VeryLow:
				return EQuality.Trash;
			case ECustomerStandard.Low:
				return EQuality.Poor;
			case ECustomerStandard.Moderate:
				return EQuality.Standard;
			case ECustomerStandard.High:
				return EQuality.Premium;
			case ECustomerStandard.VeryHigh:
				return EQuality.Heavenly;
			default:
				return EQuality.Standard;
			}
		}
	}
}
