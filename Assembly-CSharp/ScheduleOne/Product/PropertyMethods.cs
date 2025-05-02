using System;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008E4 RID: 2276
	public static class PropertyMethods
	{
		// Token: 0x06003D81 RID: 15745 RVA: 0x00102298 File Offset: 0x00100498
		public static string GetName(this EProperty property)
		{
			return PropertyUtility.GetPropertyData(property).Name;
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x001022A5 File Offset: 0x001004A5
		public static string GetDescription(this EProperty property)
		{
			return PropertyUtility.GetPropertyData(property).Description;
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x001022B2 File Offset: 0x001004B2
		public static Color GetColor(this EProperty property)
		{
			return PropertyUtility.GetPropertyData(property).Color;
		}
	}
}
