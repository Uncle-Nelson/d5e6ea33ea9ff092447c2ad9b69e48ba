using System;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	// Token: 0x02000208 RID: 520
	public static class CharacterSystemUpdater
	{
		// Token: 0x06000B6B RID: 2923 RVA: 0x00035208 File Offset: 0x00033408
		[RuntimeInitializeOnLoadMethod]
		private static void updateCharacters()
		{
			CharacterSystemUpdater.UpdateCharactersOnScene(false, null);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00035214 File Offset: 0x00033414
		public static void UpdateCharactersOnScene(bool revertPrefabs = false, CharacterCustomization reverbObject = null)
		{
			CharacterCustomization[] array = Object.FindObjectsOfType<CharacterCustomization>();
			if (array == null)
			{
				return;
			}
			foreach (CharacterCustomization characterCustomization in array)
			{
				if (!(characterCustomization == null))
				{
					characterCustomization.InitColors();
				}
			}
		}
	}
}
