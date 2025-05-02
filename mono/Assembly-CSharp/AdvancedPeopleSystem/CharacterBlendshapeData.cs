using System;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	// Token: 0x02000219 RID: 537
	[Serializable]
	public class CharacterBlendshapeData
	{
		// Token: 0x06000B81 RID: 2945 RVA: 0x000358DA File Offset: 0x00033ADA
		public CharacterBlendshapeData(string name, CharacterBlendShapeType t, CharacterBlendShapeGroup g, float value = 0f)
		{
			this.blendshapeName = name;
			this.type = t;
			this.group = g;
			this.value = value;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0000494F File Offset: 0x00002B4F
		public CharacterBlendshapeData()
		{
		}

		// Token: 0x04000CA8 RID: 3240
		public string blendshapeName;

		// Token: 0x04000CA9 RID: 3241
		public CharacterBlendShapeType type;

		// Token: 0x04000CAA RID: 3242
		public CharacterBlendShapeGroup group;

		// Token: 0x04000CAB RID: 3243
		[HideInInspector]
		public float value;
	}
}
