using System;
using AtmosphericHeightFog;
using Funly.SkyStudio;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Tools;
using UnityEngine;
using VolumetricFogAndMist2;

namespace ScheduleOne.FX
{
	// Token: 0x0200061E RID: 1566
	[ExecuteInEditMode]
	public class EnvironmentFX : Singleton<EnvironmentFX>
	{
		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x000A9426 File Offset: 0x000A7626
		public float normalizedEnvironmentalBrightness
		{
			get
			{
				return this.environmentalBrightnessCurve.Evaluate(((float)NetworkSingleton<TimeManager>.Instance.DailyMinTotal + NetworkSingleton<TimeManager>.Instance.TimeOnCurrentMinute / 1f) / 1440f);
			}
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x000A9458 File Offset: 0x000A7658
		protected override void Start()
		{
			base.Start();
			this.UpdateVisuals();
			this.FogEndDistanceController = new FloatSmoother();
			this.FogEndDistanceController.Initialize();
			this.FogEndDistanceController.SetSmoothingSpeed(0.2f);
			this.FogEndDistanceController.SetDefault(1f);
			if (Application.isPlaying && !this.started)
			{
				this.started = true;
				base.InvokeRepeating("UpdateVisuals", 0f, 0.1f);
			}
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x000A94D4 File Offset: 0x000A76D4
		private void Update()
		{
			if (Application.isEditor)
			{
				byte b = (byte)this.distanceTreeColorCurve.Evaluate(this.timeOfDayController.skyTime);
				this.distanceTreeMat.SetColor("_TintColor", new Color32(b, b, b, byte.MaxValue));
				this.grassMat.color = this.grassColorGradient.Evaluate(this.timeOfDayController.skyTime);
			}
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x000A9544 File Offset: 0x000A7744
		private void UpdateVisuals()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			float num = (float)NetworkSingleton<TimeManager>.Instance.DailyMinTotal + NetworkSingleton<TimeManager>.Instance.TimeOnCurrentMinute / 1f;
			this.timeOfDayController.skyTime = num / 1440f;
			RenderSettings.fogColor = this.fogColorGradient.Evaluate(this.timeOfDayController.skyTime);
			RenderSettings.fogEndDistance = this.fogEndDistanceCurve.Evaluate(this.timeOfDayController.skyTime) * this.fogEndDistanceMultiplier * this.FogEndDistanceController.CurrentValue;
			this.HeightFog.fogColorStart = this.HeightFogColor.Evaluate(this.timeOfDayController.skyTime);
			this.HeightFog.fogColorEnd = this.HeightFogColor.Evaluate(this.timeOfDayController.skyTime);
			this.HeightFog.fogIntensity = this.HeightFogIntensityCurve.Evaluate(this.timeOfDayController.skyTime);
			this.HeightFog.directionalIntensity = this.HeightFogDirectionalIntensityCurve.Evaluate(this.timeOfDayController.skyTime);
			Color albedo = this.VolumetricFogColor.Evaluate(this.timeOfDayController.skyTime);
			albedo.a = this.VolumetricFogIntensityCurve.Evaluate(this.timeOfDayController.skyTime) * this.VolumetricFogIntensityMultiplier;
			this.VolumetricFog.profile.albedo = albedo;
			byte b = (byte)this.distanceTreeColorCurve.Evaluate(num / 1440f);
			this.distanceTreeMat.SetColor("_TintColor", new Color32(b, b, b, byte.MaxValue));
			this.grassMat.color = this.grassColorGradient.Evaluate(this.timeOfDayController.skyTime);
			Singleton<PostProcessingManager>.Instance.SetGodRayIntensity(this.godRayIntensityCurve.Evaluate(this.timeOfDayController.skyTime));
			Singleton<PostProcessingManager>.Instance.SetContrast(this.contrastCurve.Evaluate(this.timeOfDayController.skyTime) * this.contractMultiplier);
			Singleton<PostProcessingManager>.Instance.SetSaturation(this.saturationCurve.Evaluate(this.timeOfDayController.skyTime) * this.saturationMultiplier);
			Singleton<PostProcessingManager>.Instance.SetBloomThreshold(this.bloomThreshholdCurve.Evaluate(this.timeOfDayController.skyTime));
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x000A9786 File Offset: 0x000A7986
		protected override void OnDestroy()
		{
			base.OnDestroy();
		}

		// Token: 0x04001E2B RID: 7723
		[Header("References")]
		[SerializeField]
		protected WindZone windZone;

		// Token: 0x04001E2C RID: 7724
		[SerializeField]
		protected TimeOfDayController timeOfDayController;

		// Token: 0x04001E2D RID: 7725
		public HeightFogGlobal HeightFog;

		// Token: 0x04001E2E RID: 7726
		public VolumetricFog VolumetricFog;

		// Token: 0x04001E2F RID: 7727
		public Light SunLight;

		// Token: 0x04001E30 RID: 7728
		public Light MoonLight;

		// Token: 0x04001E31 RID: 7729
		[Header("Fog")]
		[SerializeField]
		protected Gradient fogColorGradient;

		// Token: 0x04001E32 RID: 7730
		[SerializeField]
		protected AnimationCurve fogEndDistanceCurve;

		// Token: 0x04001E33 RID: 7731
		[SerializeField]
		protected float fogEndDistanceMultiplier = 0.01f;

		// Token: 0x04001E34 RID: 7732
		[Header("Height Fog")]
		[SerializeField]
		protected Gradient HeightFogColor;

		// Token: 0x04001E35 RID: 7733
		[SerializeField]
		protected AnimationCurve HeightFogIntensityCurve;

		// Token: 0x04001E36 RID: 7734
		[SerializeField]
		protected float HeightFogIntensityMultiplier = 0.5f;

		// Token: 0x04001E37 RID: 7735
		[SerializeField]
		protected AnimationCurve HeightFogDirectionalIntensityCurve;

		// Token: 0x04001E38 RID: 7736
		[Header("Volumetric Fog")]
		[SerializeField]
		protected Gradient VolumetricFogColor;

		// Token: 0x04001E39 RID: 7737
		[SerializeField]
		protected AnimationCurve VolumetricFogIntensityCurve;

		// Token: 0x04001E3A RID: 7738
		[SerializeField]
		protected float VolumetricFogIntensityMultiplier = 0.5f;

		// Token: 0x04001E3B RID: 7739
		[Header("God rays")]
		[SerializeField]
		protected AnimationCurve godRayIntensityCurve;

		// Token: 0x04001E3C RID: 7740
		[Header("Contrast")]
		[SerializeField]
		protected AnimationCurve contrastCurve;

		// Token: 0x04001E3D RID: 7741
		[SerializeField]
		protected float contractMultiplier = 1f;

		// Token: 0x04001E3E RID: 7742
		[Header("Saturation")]
		[SerializeField]
		protected AnimationCurve saturationCurve;

		// Token: 0x04001E3F RID: 7743
		[SerializeField]
		protected float saturationMultiplier = 1f;

		// Token: 0x04001E40 RID: 7744
		[Header("Grass")]
		[SerializeField]
		protected Material grassMat;

		// Token: 0x04001E41 RID: 7745
		[SerializeField]
		protected Gradient grassColorGradient;

		// Token: 0x04001E42 RID: 7746
		[Header("Trees")]
		public Material distanceTreeMat;

		// Token: 0x04001E43 RID: 7747
		public AnimationCurve distanceTreeColorCurve;

		// Token: 0x04001E44 RID: 7748
		[Header("Stealth settings")]
		public AnimationCurve environmentalBrightnessCurve;

		// Token: 0x04001E45 RID: 7749
		[Header("Bloom")]
		public AnimationCurve bloomThreshholdCurve;

		// Token: 0x04001E46 RID: 7750
		private bool started;

		// Token: 0x04001E47 RID: 7751
		public FloatSmoother FogEndDistanceController;
	}
}
