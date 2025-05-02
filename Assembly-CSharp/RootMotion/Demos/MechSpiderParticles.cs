using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000090 RID: 144
	public class MechSpiderParticles : MonoBehaviour
	{
		// Token: 0x0600055A RID: 1370 RVA: 0x00024482 File Offset: 0x00022682
		private void Start()
		{
			this.particles = (ParticleSystem)base.GetComponent(typeof(ParticleSystem));
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000244A0 File Offset: 0x000226A0
		private void Update()
		{
			float magnitude = this.mechSpiderController.inputVector.magnitude;
			float constant = Mathf.Clamp(magnitude * 50f, 30f, 50f);
			this.particles.emission.rateOverTime = new ParticleSystem.MinMaxCurve(constant);
			this.particles.main.startColor = new Color(this.particles.main.startColor.color.r, this.particles.main.startColor.color.g, this.particles.main.startColor.color.b, Mathf.Clamp(magnitude, 0.4f, 1f));
		}

		// Token: 0x04000451 RID: 1105
		public MechSpiderController mechSpiderController;

		// Token: 0x04000452 RID: 1106
		private ParticleSystem particles;
	}
}
