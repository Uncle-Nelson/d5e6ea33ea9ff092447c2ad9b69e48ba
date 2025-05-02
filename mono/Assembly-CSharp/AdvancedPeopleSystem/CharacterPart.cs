using System;
using System.Collections.Generic;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	// Token: 0x020001FC RID: 508
	[Serializable]
	public class CharacterPart
	{
		// Token: 0x06000B54 RID: 2900 RVA: 0x000340C3 File Offset: 0x000322C3
		public CharacterPart()
		{
			this.skinnedMesh = new List<SkinnedMeshRenderer>();
		}

		// Token: 0x04000C15 RID: 3093
		public string name;

		// Token: 0x04000C16 RID: 3094
		public List<SkinnedMeshRenderer> skinnedMesh;
	}
}
