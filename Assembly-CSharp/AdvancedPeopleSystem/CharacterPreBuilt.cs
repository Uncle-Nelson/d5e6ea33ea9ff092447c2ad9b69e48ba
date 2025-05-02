using System;
using System.Collections.Generic;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	// Token: 0x02000214 RID: 532
	public class CharacterPreBuilt : ScriptableObject
	{
		// Token: 0x04000C85 RID: 3205
		[SerializeField]
		public CharacterSettings settings;

		// Token: 0x04000C86 RID: 3206
		[SerializeField]
		public List<PreBuiltData> preBuiltDatas = new List<PreBuiltData>();

		// Token: 0x04000C87 RID: 3207
		[SerializeField]
		public List<PreBuiltBlendshape> blendshapes = new List<PreBuiltBlendshape>();
	}
}
