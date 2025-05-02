using System;
using System.Collections.Generic;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	// Token: 0x0200020A RID: 522
	[CreateAssetMenu(fileName = "NewCharacterGenerator", menuName = "Advanced People Pack/CharacterGenerator", order = 1)]
	public class CharacterGeneratorSettings : ScriptableObject
	{
		// Token: 0x04000C58 RID: 3160
		public MinMaxIndex hair;

		// Token: 0x04000C59 RID: 3161
		public MinMaxIndex beard;

		// Token: 0x04000C5A RID: 3162
		public MinMaxIndex hat;

		// Token: 0x04000C5B RID: 3163
		public MinMaxIndex accessory;

		// Token: 0x04000C5C RID: 3164
		public MinMaxIndex shirt;

		// Token: 0x04000C5D RID: 3165
		public MinMaxIndex pants;

		// Token: 0x04000C5E RID: 3166
		public MinMaxIndex shoes;

		// Token: 0x04000C5F RID: 3167
		[Space(10f)]
		public MinMaxColor skinColors = new MinMaxColor();

		// Token: 0x04000C60 RID: 3168
		public MinMaxColor eyeColors = new MinMaxColor();

		// Token: 0x04000C61 RID: 3169
		public MinMaxColor hairColors = new MinMaxColor();

		// Token: 0x04000C62 RID: 3170
		[Space(10f)]
		public MinMaxBlendshapes headSize;

		// Token: 0x04000C63 RID: 3171
		public MinMaxBlendshapes headOffset;

		// Token: 0x04000C64 RID: 3172
		public MinMaxBlendshapes height;

		// Token: 0x04000C65 RID: 3173
		public MinMaxBlendshapes fat;

		// Token: 0x04000C66 RID: 3174
		public MinMaxBlendshapes muscles;

		// Token: 0x04000C67 RID: 3175
		public MinMaxBlendshapes thin;

		// Token: 0x04000C68 RID: 3176
		[Space(15f)]
		public List<MinMaxFacialBlendshapes> facialBlendshapes = new List<MinMaxFacialBlendshapes>();

		// Token: 0x04000C69 RID: 3177
		[Space(15f)]
		public List<GeneratorExclude> excludes = new List<GeneratorExclude>();
	}
}
