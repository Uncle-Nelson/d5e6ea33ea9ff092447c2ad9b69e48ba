using System;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000934 RID: 2356
	[CreateAssetMenu(fileName = "SoilDefinition", menuName = "ScriptableObjects/Item Definitions/SoilDefinition", order = 1)]
	[Serializable]
	public class SoilDefinition : StorableItemDefinition
	{
		// Token: 0x04002DF5 RID: 11765
		public SoilDefinition.ESoilQuality SoilQuality;

		// Token: 0x04002DF6 RID: 11766
		public Material DrySoilMat;

		// Token: 0x04002DF7 RID: 11767
		public Material WetSoilMat;

		// Token: 0x04002DF8 RID: 11768
		public Color ParticleColor;

		// Token: 0x04002DF9 RID: 11769
		public int Uses = 1;

		// Token: 0x02000935 RID: 2357
		public enum ESoilQuality
		{
			// Token: 0x04002DFB RID: 11771
			Basic,
			// Token: 0x04002DFC RID: 11772
			Premium
		}
	}
}
