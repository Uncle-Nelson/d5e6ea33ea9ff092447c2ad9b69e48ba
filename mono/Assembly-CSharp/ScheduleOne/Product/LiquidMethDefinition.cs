using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008D9 RID: 2265
	[CreateAssetMenu(fileName = "LiquidMethDefinition", menuName = "ScriptableObjects/LiquidMethDefinition", order = 1)]
	[Serializable]
	public class LiquidMethDefinition : QualityItemDefinition
	{
		// Token: 0x04002C33 RID: 11315
		[Header("Liquid Meth Color Settings")]
		public Color StaticLiquidColor;

		// Token: 0x04002C34 RID: 11316
		public Color LiquidVolumeColor;

		// Token: 0x04002C35 RID: 11317
		public Color PourParticlesColor;

		// Token: 0x04002C36 RID: 11318
		public Color CookableLiquidColor;

		// Token: 0x04002C37 RID: 11319
		public Color CookableSolidColor;
	}
}
