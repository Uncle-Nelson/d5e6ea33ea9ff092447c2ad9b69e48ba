using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000C4 RID: 196
	[Serializable]
	public class ScreenSpaceReflectionModel : PostProcessingModel
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0001337B File Offset: 0x0001157B
		// (set) Token: 0x0600033A RID: 826 RVA: 0x00013383 File Offset: 0x00011583
		public ScreenSpaceReflectionModel.Settings settings
		{
			get
			{
				return this.m_Settings;
			}
			set
			{
				this.m_Settings = value;
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0001338C File Offset: 0x0001158C
		public override void Reset()
		{
			this.m_Settings = ScreenSpaceReflectionModel.Settings.defaultSettings;
		}

		// Token: 0x0400041A RID: 1050
		[SerializeField]
		private ScreenSpaceReflectionModel.Settings m_Settings = ScreenSpaceReflectionModel.Settings.defaultSettings;

		// Token: 0x020000C5 RID: 197
		public enum SSRResolution
		{
			// Token: 0x0400041C RID: 1052
			High,
			// Token: 0x0400041D RID: 1053
			Low = 2
		}

		// Token: 0x020000C6 RID: 198
		public enum SSRReflectionBlendType
		{
			// Token: 0x0400041F RID: 1055
			PhysicallyBased,
			// Token: 0x04000420 RID: 1056
			Additive
		}

		// Token: 0x020000C7 RID: 199
		[Serializable]
		public struct IntensitySettings
		{
			// Token: 0x04000421 RID: 1057
			[Tooltip("Nonphysical multiplier for the SSR reflections. 1.0 is physically based.")]
			[Range(0f, 2f)]
			public float reflectionMultiplier;

			// Token: 0x04000422 RID: 1058
			[Tooltip("How far away from the maxDistance to begin fading SSR.")]
			[Range(0f, 1000f)]
			public float fadeDistance;

			// Token: 0x04000423 RID: 1059
			[Tooltip("Amplify Fresnel fade out. Increase if floor reflections look good close to the surface and bad farther 'under' the floor.")]
			[Range(0f, 1f)]
			public float fresnelFade;

			// Token: 0x04000424 RID: 1060
			[Tooltip("Higher values correspond to a faster Fresnel fade as the reflection changes from the grazing angle.")]
			[Range(0.1f, 10f)]
			public float fresnelFadePower;
		}

		// Token: 0x020000C8 RID: 200
		[Serializable]
		public struct ReflectionSettings
		{
			// Token: 0x04000425 RID: 1061
			[Tooltip("How the reflections are blended into the render.")]
			public ScreenSpaceReflectionModel.SSRReflectionBlendType blendType;

			// Token: 0x04000426 RID: 1062
			[Tooltip("Half resolution SSRR is much faster, but less accurate.")]
			public ScreenSpaceReflectionModel.SSRResolution reflectionQuality;

			// Token: 0x04000427 RID: 1063
			[Tooltip("Maximum reflection distance in world units.")]
			[Range(0.1f, 300f)]
			public float maxDistance;

			// Token: 0x04000428 RID: 1064
			[Tooltip("Max raytracing length.")]
			[Range(16f, 1024f)]
			public int iterationCount;

			// Token: 0x04000429 RID: 1065
			[Tooltip("Log base 2 of ray tracing coarse step size. Higher traces farther, lower gives better quality silhouettes.")]
			[Range(1f, 16f)]
			public int stepSize;

			// Token: 0x0400042A RID: 1066
			[Tooltip("Typical thickness of columns, walls, furniture, and other objects that reflection rays might pass behind.")]
			[Range(0.01f, 10f)]
			public float widthModifier;

			// Token: 0x0400042B RID: 1067
			[Tooltip("Blurriness of reflections.")]
			[Range(0.1f, 8f)]
			public float reflectionBlur;

			// Token: 0x0400042C RID: 1068
			[Tooltip("Disable for a performance gain in scenes where most glossy objects are horizontal, like floors, water, and tables. Leave on for scenes with glossy vertical objects.")]
			public bool reflectBackfaces;
		}

		// Token: 0x020000C9 RID: 201
		[Serializable]
		public struct ScreenEdgeMask
		{
			// Token: 0x0400042D RID: 1069
			[Tooltip("Higher = fade out SSRR near the edge of the screen so that reflections don't pop under camera motion.")]
			[Range(0f, 1f)]
			public float intensity;
		}

		// Token: 0x020000CA RID: 202
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000072 RID: 114
			// (get) Token: 0x0600033D RID: 829 RVA: 0x000133AC File Offset: 0x000115AC
			public static ScreenSpaceReflectionModel.Settings defaultSettings
			{
				get
				{
					return new ScreenSpaceReflectionModel.Settings
					{
						reflection = new ScreenSpaceReflectionModel.ReflectionSettings
						{
							blendType = ScreenSpaceReflectionModel.SSRReflectionBlendType.PhysicallyBased,
							reflectionQuality = ScreenSpaceReflectionModel.SSRResolution.Low,
							maxDistance = 100f,
							iterationCount = 256,
							stepSize = 3,
							widthModifier = 0.5f,
							reflectionBlur = 1f,
							reflectBackfaces = false
						},
						intensity = new ScreenSpaceReflectionModel.IntensitySettings
						{
							reflectionMultiplier = 1f,
							fadeDistance = 100f,
							fresnelFade = 1f,
							fresnelFadePower = 1f
						},
						screenEdgeMask = new ScreenSpaceReflectionModel.ScreenEdgeMask
						{
							intensity = 0.03f
						}
					};
				}
			}

			// Token: 0x0400042E RID: 1070
			public ScreenSpaceReflectionModel.ReflectionSettings reflection;

			// Token: 0x0400042F RID: 1071
			public ScreenSpaceReflectionModel.IntensitySettings intensity;

			// Token: 0x04000430 RID: 1072
			public ScreenSpaceReflectionModel.ScreenEdgeMask screenEdgeMask;
		}
	}
}
