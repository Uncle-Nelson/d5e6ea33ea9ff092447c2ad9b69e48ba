using System;
using Beautify.Universal;
using CorgiGodRays;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.FX
{
	// Token: 0x02000624 RID: 1572
	public class PostProcessingManager : Singleton<PostProcessingManager>
	{
		// Token: 0x0600292B RID: 10539 RVA: 0x000A9D48 File Offset: 0x000A7F48
		protected override void Awake()
		{
			base.Awake();
			this.GlobalVolume.enabled = true;
			this.GlobalVolume.sharedProfile.TryGet<Vignette>(ref this.vig);
			this.ResetVignette();
			this.GlobalVolume.sharedProfile.TryGet<DepthOfField>(ref this.DoF);
			this.DoF.active = false;
			this.GlobalVolume.sharedProfile.TryGet<GodRaysVolume>(ref this.GodRays);
			this.GlobalVolume.sharedProfile.TryGet<ColorAdjustments>(ref this.ColorAdjustments);
			this.GlobalVolume.sharedProfile.TryGet<Beautify>(ref this.beautifySettings);
			this.GlobalVolume.sharedProfile.TryGet<Bloom>(ref this.bloom);
			this.GlobalVolume.sharedProfile.TryGet<ChromaticAberration>(ref this.chromaticAberration);
			this.GlobalVolume.sharedProfile.TryGet<ColorAdjustments>(ref this.colorAdjustments);
			this.ChromaticAberrationController.Initialize();
			this.SaturationController.Initialize();
			this.BloomController.Initialize();
			this.ColorFilterController.Initialize();
			this.SetBlur(0f);
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x000A9E68 File Offset: 0x000A8068
		public void Update()
		{
			this.UpdateEffects();
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x000A9E70 File Offset: 0x000A8070
		private void UpdateEffects()
		{
			float num = Mathf.Lerp(1f, 12f, PlayerSingleton<PlayerCamera>.InstanceExists ? PlayerSingleton<PlayerCamera>.Instance.FovJitter : 0f);
			this.chromaticAberration.intensity.value = this.ChromaticAberrationController.CurrentValue * num;
			this.ColorAdjustments.saturation.value = this.SaturationController.CurrentValue;
			this.ColorAdjustments.postExposure.value = 0.1f * num;
			this.bloom.intensity.value = this.BloomController.CurrentValue * num;
			this.colorAdjustments.colorFilter.value = this.ColorFilterController.CurrentValue;
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x000A9F2C File Offset: 0x000A812C
		public void OverrideVignette(float intensity, float smoothness)
		{
			this.vig.intensity.value = intensity;
			this.vig.smoothness.value = smoothness;
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x000A9F50 File Offset: 0x000A8150
		public void ResetVignette()
		{
			this.vig.intensity.value = this.Vig_DefaultIntensity;
			this.vig.smoothness.value = this.Vig_DefaultSmoothness;
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x000A9F7E File Offset: 0x000A817E
		public void SetGodRayIntensity(float intensity)
		{
			this.GodRays.MainLightIntensity.value = intensity;
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x000A9F91 File Offset: 0x000A8191
		public void SetContrast(float value)
		{
			this.ColorAdjustments.contrast.value = value;
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x000A9FA4 File Offset: 0x000A81A4
		public void SetSaturation(float value)
		{
			this.SaturationController.SetDefault(value);
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x000A9FB2 File Offset: 0x000A81B2
		public void SetBloomThreshold(float threshold)
		{
			this.bloom.threshold.value = threshold;
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x000A9FC5 File Offset: 0x000A81C5
		public void SetBlur(float blurLevel)
		{
			this.beautifySettings.blurIntensity.value = Mathf.Lerp(this.MinBlur, this.MaxBlur, blurLevel);
		}

		// Token: 0x04001E60 RID: 7776
		[Header("References")]
		public Volume GlobalVolume;

		// Token: 0x04001E61 RID: 7777
		[Header("Vignette")]
		public float Vig_DefaultIntensity = 0.25f;

		// Token: 0x04001E62 RID: 7778
		public float Vig_DefaultSmoothness = 0.3f;

		// Token: 0x04001E63 RID: 7779
		[Header("Blur")]
		public float MinBlur;

		// Token: 0x04001E64 RID: 7780
		public float MaxBlur = 1f;

		// Token: 0x04001E65 RID: 7781
		[Header("Smoothers")]
		public FloatSmoother ChromaticAberrationController;

		// Token: 0x04001E66 RID: 7782
		public FloatSmoother SaturationController;

		// Token: 0x04001E67 RID: 7783
		public FloatSmoother BloomController;

		// Token: 0x04001E68 RID: 7784
		public HDRColorSmoother ColorFilterController;

		// Token: 0x04001E69 RID: 7785
		private Vignette vig;

		// Token: 0x04001E6A RID: 7786
		private DepthOfField DoF;

		// Token: 0x04001E6B RID: 7787
		private GodRaysVolume GodRays;

		// Token: 0x04001E6C RID: 7788
		private ColorAdjustments ColorAdjustments;

		// Token: 0x04001E6D RID: 7789
		private Beautify beautifySettings;

		// Token: 0x04001E6E RID: 7790
		private Bloom bloom;

		// Token: 0x04001E6F RID: 7791
		private ChromaticAberration chromaticAberration;

		// Token: 0x04001E70 RID: 7792
		private ColorAdjustments colorAdjustments;
	}
}
