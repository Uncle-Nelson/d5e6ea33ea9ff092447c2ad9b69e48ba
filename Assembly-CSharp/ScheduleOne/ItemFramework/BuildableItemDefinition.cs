using System;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000937 RID: 2359
	[CreateAssetMenu(fileName = "BuildableItemDefinition", menuName = "ScriptableObjects/BuildableItemDefinition", order = 1)]
	[Serializable]
	public class BuildableItemDefinition : StorableItemDefinition
	{
		// Token: 0x04002DFE RID: 11774
		public BuildableItem BuiltItem;

		// Token: 0x04002DFF RID: 11775
		public BuildableItemDefinition.EBuildSoundType BuildSoundType;

		// Token: 0x02000938 RID: 2360
		public enum EBuildSoundType
		{
			// Token: 0x04002E01 RID: 11777
			Cardboard,
			// Token: 0x04002E02 RID: 11778
			Wood,
			// Token: 0x04002E03 RID: 11779
			Metal
		}
	}
}
