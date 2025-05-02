using System;
using ScheduleOne.DevUtilities;
using UnityEngine;
using VLB;

namespace ScheduleOne.Lighting
{
	// Token: 0x020005AD RID: 1453
	[ExecuteInEditMode]
	[RequireComponent(typeof(Light))]
	[RequireComponent(typeof(VolumetricLightBeamSD))]
	public class VolumetricLightTracker : MonoBehaviour
	{
		// Token: 0x060023FA RID: 9210 RVA: 0x00092014 File Offset: 0x00090214
		private void OnValidate()
		{
			if (this.light == null)
			{
				this.light = base.GetComponent<Light>();
			}
			if (this.optimizedLight == null)
			{
				this.optimizedLight = base.GetComponent<OptimizedLight>();
			}
			if (this.beam == null)
			{
				this.beam = base.GetComponent<VolumetricLightBeamSD>();
			}
			if (this.dust == null)
			{
				this.dust = base.GetComponent<VolumetricDustParticles>();
			}
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x0009208C File Offset: 0x0009028C
		private void LateUpdate()
		{
			if (this.Override)
			{
				this.beam.enabled = this.Enabled;
			}
			else if (this.optimizedLight != null)
			{
				this.beam.enabled = this.optimizedLight.Enabled;
			}
			else if (this.light != null)
			{
				this.beam.enabled = this.light.enabled;
			}
			if (this.dust != null)
			{
				this.dust.enabled = this.beam.enabled;
			}
		}

		// Token: 0x04001ADA RID: 6874
		public bool Override;

		// Token: 0x04001ADB RID: 6875
		public bool Enabled;

		// Token: 0x04001ADC RID: 6876
		public Light light;

		// Token: 0x04001ADD RID: 6877
		public OptimizedLight optimizedLight;

		// Token: 0x04001ADE RID: 6878
		public VolumetricLightBeamSD beam;

		// Token: 0x04001ADF RID: 6879
		public VolumetricDustParticles dust;
	}
}
