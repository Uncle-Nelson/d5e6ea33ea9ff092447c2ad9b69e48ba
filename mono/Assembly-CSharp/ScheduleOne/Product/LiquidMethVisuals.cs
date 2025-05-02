using System;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008DA RID: 2266
	public class LiquidMethVisuals : MonoBehaviour
	{
		// Token: 0x06003D65 RID: 15717 RVA: 0x00101B10 File Offset: 0x000FFD10
		public void Setup(LiquidMethDefinition def)
		{
			if (def == null)
			{
				return;
			}
			if (this.StaticLiquidMesh != null)
			{
				this.StaticLiquidMesh.material.color = def.StaticLiquidColor;
			}
			if (this.LiquidContainer != null)
			{
				this.LiquidContainer.SetLiquidColor(def.LiquidVolumeColor, true, true);
			}
			if (this.PourParticles != null)
			{
				this.PourParticles.main.startColor = def.PourParticlesColor;
			}
		}

		// Token: 0x04002C38 RID: 11320
		public MeshRenderer StaticLiquidMesh;

		// Token: 0x04002C39 RID: 11321
		public LiquidContainer LiquidContainer;

		// Token: 0x04002C3A RID: 11322
		public ParticleSystem PourParticles;
	}
}
