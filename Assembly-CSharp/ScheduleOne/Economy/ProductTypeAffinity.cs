using System;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x02000665 RID: 1637
	[Serializable]
	public class ProductTypeAffinity
	{
		// Token: 0x04001FE8 RID: 8168
		public EDrugType DrugType;

		// Token: 0x04001FE9 RID: 8169
		[Range(-1f, 1f)]
		public float Affinity;
	}
}
