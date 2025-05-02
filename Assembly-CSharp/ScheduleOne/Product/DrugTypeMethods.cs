using System;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008E1 RID: 2273
	public static class DrugTypeMethods
	{
		// Token: 0x06003D7E RID: 15742 RVA: 0x0010227E File Offset: 0x0010047E
		public static string GetName(this EDrugType property)
		{
			return PropertyUtility.GetDrugTypeData(property).Name;
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x0010228B File Offset: 0x0010048B
		public static Color GetColor(this EDrugType property)
		{
			return PropertyUtility.GetDrugTypeData(property).Color;
		}
	}
}
