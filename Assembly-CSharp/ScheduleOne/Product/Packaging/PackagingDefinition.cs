using System;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.Packaging;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Product.Packaging
{
	// Token: 0x02000914 RID: 2324
	[CreateAssetMenu(fileName = "PackagingDefinition", menuName = "ScriptableObjects/Item Definitions/PackagingDefinition", order = 1)]
	[Serializable]
	public class PackagingDefinition : StorableItemDefinition
	{
		// Token: 0x04002D1F RID: 11551
		public int Quantity = 1;

		// Token: 0x04002D20 RID: 11552
		public EStealthLevel StealthLevel;

		// Token: 0x04002D21 RID: 11553
		public FunctionalPackaging FunctionalPackaging;

		// Token: 0x04002D22 RID: 11554
		public Equippable Equippable_Filled;

		// Token: 0x04002D23 RID: 11555
		public StoredItem StoredItem_Filled;
	}
}
