using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x02000886 RID: 2182
	[CreateAssetMenu(fileName = "SeedDefinition", menuName = "ScriptableObjects/Item Definitions/SeedDefinition", order = 1)]
	[Serializable]
	public class SeedDefinition : StorableItemDefinition
	{
		// Token: 0x04002AAB RID: 10923
		public FunctionalSeed FunctionSeedPrefab;

		// Token: 0x04002AAC RID: 10924
		public Plant PlantPrefab;
	}
}
