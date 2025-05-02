using System;
using System.Collections.Generic;

namespace AdvancedPeopleSystem
{
	// Token: 0x02000210 RID: 528
	[Serializable]
	public class GeneratorExclude
	{
		// Token: 0x04000C7A RID: 3194
		public ExcludeItem ExcludeItem;

		// Token: 0x04000C7B RID: 3195
		public int targetIndex;

		// Token: 0x04000C7C RID: 3196
		public List<ExcludeIndexes> exclude = new List<ExcludeIndexes>();
	}
}
