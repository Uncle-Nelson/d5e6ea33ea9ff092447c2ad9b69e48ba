using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	// Token: 0x020000F1 RID: 241
	[AddComponentMenu("")]
	public class EffectAbstractBase : MonoBehaviour
	{
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00015BE3 File Offset: 0x00013DE3
		// (set) Token: 0x060003DC RID: 988 RVA: 0x00015BEB File Offset: 0x00013DEB
		[Obsolete("Use 'restoreIntensityOnDisable' instead")]
		public bool restoreBaseIntensity
		{
			get
			{
				return this.restoreIntensityOnDisable;
			}
			set
			{
				this.restoreIntensityOnDisable = value;
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00015BF4 File Offset: 0x00013DF4
		public virtual void InitFrom(EffectAbstractBase Source)
		{
			if (Source)
			{
				this.componentsToChange = Source.componentsToChange;
				this.restoreIntensityOnDisable = Source.restoreIntensityOnDisable;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00015C16 File Offset: 0x00013E16
		private void GetIntensity(VolumetricLightBeamSD beam)
		{
			if (beam)
			{
				this.m_BaseIntensityBeamInside = beam.intensityInside;
				this.m_BaseIntensityBeamOutside = beam.intensityOutside;
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00015C38 File Offset: 0x00013E38
		private void GetIntensity(VolumetricLightBeamHD beam)
		{
			if (beam)
			{
				this.m_BaseIntensityBeamOutside = beam.intensity;
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00015C4E File Offset: 0x00013E4E
		private void SetIntensity(VolumetricLightBeamSD beam, float additive)
		{
			if (beam)
			{
				beam.intensityInside = Mathf.Max(0f, this.m_BaseIntensityBeamInside + additive);
				beam.intensityOutside = Mathf.Max(0f, this.m_BaseIntensityBeamOutside + additive);
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00015C88 File Offset: 0x00013E88
		private void SetIntensity(VolumetricLightBeamHD beam, float additive)
		{
			if (beam)
			{
				beam.intensity = Mathf.Max(0f, this.m_BaseIntensityBeamOutside + additive);
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00015CAC File Offset: 0x00013EAC
		protected void SetAdditiveIntensity(float additive)
		{
			if (this.componentsToChange.HasFlag(EffectAbstractBase.ComponentsToChange.VolumetricLightBeam) && this.m_Beam)
			{
				this.SetIntensity(this.m_Beam as VolumetricLightBeamSD, additive);
				this.SetIntensity(this.m_Beam as VolumetricLightBeamHD, additive);
			}
			if (this.componentsToChange.HasFlag(EffectAbstractBase.ComponentsToChange.UnityLight) && this.m_Light)
			{
				this.m_Light.intensity = Mathf.Max(0f, this.m_BaseIntensityLight + additive);
			}
			if (this.componentsToChange.HasFlag(EffectAbstractBase.ComponentsToChange.VolumetricDustParticles) && this.m_Particles)
			{
				this.m_Particles.alphaAdditionalRuntime = 1f + additive;
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00015D7C File Offset: 0x00013F7C
		private void Awake()
		{
			this.m_Beam = base.GetComponent<VolumetricLightBeamAbstractBase>();
			this.m_Light = base.GetComponent<Light>();
			this.m_Particles = base.GetComponent<VolumetricDustParticles>();
			this.GetIntensity(this.m_Beam as VolumetricLightBeamSD);
			this.GetIntensity(this.m_Beam as VolumetricLightBeamHD);
			this.m_BaseIntensityLight = (this.m_Light ? this.m_Light.intensity : 0f);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00015DF4 File Offset: 0x00013FF4
		protected virtual void OnEnable()
		{
			base.StopAllCoroutines();
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00015DFC File Offset: 0x00013FFC
		private void OnDisable()
		{
			base.StopAllCoroutines();
			if (this.restoreIntensityOnDisable)
			{
				this.SetAdditiveIntensity(0f);
			}
		}

		// Token: 0x04000555 RID: 1365
		public const string ClassName = "EffectAbstractBase";

		// Token: 0x04000556 RID: 1366
		public EffectAbstractBase.ComponentsToChange componentsToChange = (EffectAbstractBase.ComponentsToChange)2147483647;

		// Token: 0x04000557 RID: 1367
		[FormerlySerializedAs("restoreBaseIntensity")]
		public bool restoreIntensityOnDisable = true;

		// Token: 0x04000558 RID: 1368
		protected VolumetricLightBeamAbstractBase m_Beam;

		// Token: 0x04000559 RID: 1369
		protected Light m_Light;

		// Token: 0x0400055A RID: 1370
		protected VolumetricDustParticles m_Particles;

		// Token: 0x0400055B RID: 1371
		protected float m_BaseIntensityBeamInside;

		// Token: 0x0400055C RID: 1372
		protected float m_BaseIntensityBeamOutside;

		// Token: 0x0400055D RID: 1373
		protected float m_BaseIntensityLight;

		// Token: 0x020000F2 RID: 242
		[Flags]
		public enum ComponentsToChange
		{
			// Token: 0x0400055F RID: 1375
			UnityLight = 1,
			// Token: 0x04000560 RID: 1376
			VolumetricLightBeam = 2,
			// Token: 0x04000561 RID: 1377
			VolumetricDustParticles = 4
		}
	}
}
