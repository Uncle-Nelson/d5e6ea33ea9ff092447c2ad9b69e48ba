using System;
using System.Collections.Generic;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	// Token: 0x02000215 RID: 533
	[CreateAssetMenu(fileName = "NewCharacterSettings", menuName = "Advanced People Pack/Settings", order = 1)]
	public class CharacterSettings : ScriptableObject
	{
		// Token: 0x04000C88 RID: 3208
		public GameObject OriginalMesh;

		// Token: 0x04000C89 RID: 3209
		public Material bodyMaterial;

		// Token: 0x04000C8A RID: 3210
		[Space(20f)]
		public List<CharacterAnimationPreset> characterAnimationPresets = new List<CharacterAnimationPreset>();

		// Token: 0x04000C8B RID: 3211
		[Space(20f)]
		public List<CharacterBlendshapeData> characterBlendshapeDatas = new List<CharacterBlendshapeData>();

		// Token: 0x04000C8C RID: 3212
		[Space(20f)]
		public List<CharacterElementsPreset> hairPresets = new List<CharacterElementsPreset>();

		// Token: 0x04000C8D RID: 3213
		public List<CharacterElementsPreset> beardPresets = new List<CharacterElementsPreset>();

		// Token: 0x04000C8E RID: 3214
		public List<CharacterElementsPreset> hatsPresets = new List<CharacterElementsPreset>();

		// Token: 0x04000C8F RID: 3215
		public List<CharacterElementsPreset> accessoryPresets = new List<CharacterElementsPreset>();

		// Token: 0x04000C90 RID: 3216
		public List<CharacterElementsPreset> shirtsPresets = new List<CharacterElementsPreset>();

		// Token: 0x04000C91 RID: 3217
		public List<CharacterElementsPreset> pantsPresets = new List<CharacterElementsPreset>();

		// Token: 0x04000C92 RID: 3218
		public List<CharacterElementsPreset> shoesPresets = new List<CharacterElementsPreset>();

		// Token: 0x04000C93 RID: 3219
		public List<CharacterElementsPreset> item1Presets = new List<CharacterElementsPreset>();

		// Token: 0x04000C94 RID: 3220
		[Space(20f)]
		public List<CharacterSettingsSelector> settingsSelectors = new List<CharacterSettingsSelector>();

		// Token: 0x04000C95 RID: 3221
		[Space(20f)]
		public RuntimeAnimatorController Animator;

		// Token: 0x04000C96 RID: 3222
		public Avatar Avatar;

		// Token: 0x04000C97 RID: 3223
		[Space(20f)]
		public CharacterGeneratorSettings generator;

		// Token: 0x04000C98 RID: 3224
		[Space(20f)]
		public CharacterSelectedElements DefaultSelectedElements = new CharacterSelectedElements();

		// Token: 0x04000C99 RID: 3225
		[Space(20f)]
		public bool DisableBlendshapeModifier;
	}
}
