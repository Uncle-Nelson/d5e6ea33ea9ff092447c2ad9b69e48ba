using System;
using System.Collections.Generic;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	// Token: 0x020001FD RID: 509
	[Serializable]
	public class ClothesAnchor
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x000340D6 File Offset: 0x000322D6
		public ClothesAnchor()
		{
			this.skinnedMesh = new List<SkinnedMeshRenderer>();
		}

		// Token: 0x04000C17 RID: 3095
		public CharacterElementType partType;

		// Token: 0x04000C18 RID: 3096
		public List<SkinnedMeshRenderer> skinnedMesh;
	}
}
