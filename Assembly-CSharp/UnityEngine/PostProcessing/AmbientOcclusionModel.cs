using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000095 RID: 149
	[Serializable]
	public class AmbientOcclusionModel : PostProcessingModel
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00012554 File Offset: 0x00010754
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0001255C File Offset: 0x0001075C
		public AmbientOcclusionModel.Settings settings
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

		// Token: 0x060002E7 RID: 743 RVA: 0x00012565 File Offset: 0x00010765
		public override void Reset()
		{
			this.m_Settings = AmbientOcclusionModel.Settings.defaultSettings;
		}

		// Token: 0x04000373 RID: 883
		[SerializeField]
		private AmbientOcclusionModel.Settings m_Settings = AmbientOcclusionModel.Settings.defaultSettings;

		// Token: 0x02000096 RID: 150
		public enum SampleCount
		{
			// Token: 0x04000375 RID: 885
			Lowest = 3,
			// Token: 0x04000376 RID: 886
			Low = 6,
			// Token: 0x04000377 RID: 887
			Medium = 10,
			// Token: 0x04000378 RID: 888
			High = 16
		}

		// Token: 0x02000097 RID: 151
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060002E9 RID: 745 RVA: 0x00012588 File Offset: 0x00010788
			public static AmbientOcclusionModel.Settings defaultSettings
			{
				get
				{
					return new AmbientOcclusionModel.Settings
					{
						intensity = 1f,
						radius = 0.3f,
						sampleCount = AmbientOcclusionModel.SampleCount.Medium,
						downsampling = true,
						forceForwardCompatibility = false,
						ambientOnly = false,
						highPrecision = false
					};
				}
			}

			// Token: 0x04000379 RID: 889
			[Range(0f, 4f)]
			[Tooltip("Degree of darkness produced by the effect.")]
			public float intensity;

			// Token: 0x0400037A RID: 890
			[Min(0.0001f)]
			[Tooltip("Radius of sample points, which affects extent of darkened areas.")]
			public float radius;

			// Token: 0x0400037B RID: 891
			[Tooltip("Number of sample points, which affects quality and performance.")]
			public AmbientOcclusionModel.SampleCount sampleCount;

			// Token: 0x0400037C RID: 892
			[Tooltip("Halves the resolution of the effect to increase performance at the cost of visual quality.")]
			public bool downsampling;

			// Token: 0x0400037D RID: 893
			[Tooltip("Forces compatibility with Forward rendered objects when working with the Deferred rendering path.")]
			public bool forceForwardCompatibility;

			// Token: 0x0400037E RID: 894
			[Tooltip("Enables the ambient-only mode in that the effect only affects ambient lighting. This mode is only available with the Deferred rendering path and HDR rendering.")]
			public bool ambientOnly;

			// Token: 0x0400037F RID: 895
			[Tooltip("Toggles the use of a higher precision depth texture with the forward rendering path (may impact performances). Has no effect with the deferred rendering path.")]
			public bool highPrecision;
		}
	}
}
