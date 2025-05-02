using System;
using ScheduleOne.Growing;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000936 RID: 2358
	[CreateAssetMenu(fileName = "AdditiveDefinition", menuName = "ScriptableObjects/Item Definitions/AdditiveDefinition", order = 1)]
	[Serializable]
	public class AdditiveDefinition : StorableItemDefinition
	{
		// Token: 0x04002DFD RID: 11773
		public Additive AdditivePrefab;
	}
}
