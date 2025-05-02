using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000A0 RID: 160
	[Serializable]
	public class BloomModel : PostProcessingModel
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00012922 File Offset: 0x00010B22
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x0001292A File Offset: 0x00010B2A
		public BloomModel.Settings settings
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

		// Token: 0x060002F5 RID: 757 RVA: 0x00012933 File Offset: 0x00010B33
		public override void Reset()
		{
			this.m_Settings = BloomModel.Settings.defaultSettings;
		}

		// Token: 0x0400039B RID: 923
		[SerializeField]
		private BloomModel.Settings m_Settings = BloomModel.Settings.defaultSettings;

		// Token: 0x020000A1 RID: 161
		[Serializable]
		public struct BloomSettings
		{
			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060002F8 RID: 760 RVA: 0x00012961 File Offset: 0x00010B61
			// (set) Token: 0x060002F7 RID: 759 RVA: 0x00012953 File Offset: 0x00010B53
			public float thresholdLinear
			{
				get
				{
					return Mathf.GammaToLinearSpace(this.threshold);
				}
				set
				{
					this.threshold = Mathf.LinearToGammaSpace(value);
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060002F9 RID: 761 RVA: 0x00012970 File Offset: 0x00010B70
			public static BloomModel.BloomSettings defaultSettings
			{
				get
				{
					return new BloomModel.BloomSettings
					{
						intensity = 0.5f,
						threshold = 1.1f,
						softKnee = 0.5f,
						radius = 4f,
						antiFlicker = false
					};
				}
			}

			// Token: 0x0400039C RID: 924
			[Min(0f)]
			[Tooltip("Strength of the bloom filter.")]
			public float intensity;

			// Token: 0x0400039D RID: 925
			[Min(0f)]
			[Tooltip("Filters out pixels under this level of brightness.")]
			public float threshold;

			// Token: 0x0400039E RID: 926
			[Range(0f, 1f)]
			[Tooltip("Makes transition between under/over-threshold gradual (0 = hard threshold, 1 = soft threshold).")]
			public float softKnee;

			// Token: 0x0400039F RID: 927
			[Range(1f, 7f)]
			[Tooltip("Changes extent of veiling effects in a screen resolution-independent fashion.")]
			public float radius;

			// Token: 0x040003A0 RID: 928
			[Tooltip("Reduces flashing noise with an additional filter.")]
			public bool antiFlicker;
		}

		// Token: 0x020000A2 RID: 162
		[Serializable]
		public struct LensDirtSettings
		{
			// Token: 0x17000051 RID: 81
			// (get) Token: 0x060002FA RID: 762 RVA: 0x000129C0 File Offset: 0x00010BC0
			public static BloomModel.LensDirtSettings defaultSettings
			{
				get
				{
					return new BloomModel.LensDirtSettings
					{
						texture = null,
						intensity = 3f
					};
				}
			}

			// Token: 0x040003A1 RID: 929
			[Tooltip("Dirtiness texture to add smudges or dust to the lens.")]
			public Texture texture;

			// Token: 0x040003A2 RID: 930
			[Min(0f)]
			[Tooltip("Amount of lens dirtiness.")]
			public float intensity;
		}

		// Token: 0x020000A3 RID: 163
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000052 RID: 82
			// (get) Token: 0x060002FB RID: 763 RVA: 0x000129EC File Offset: 0x00010BEC
			public static BloomModel.Settings defaultSettings
			{
				get
				{
					return new BloomModel.Settings
					{
						bloom = BloomModel.BloomSettings.defaultSettings,
						lensDirt = BloomModel.LensDirtSettings.defaultSettings
					};
				}
			}

			// Token: 0x040003A3 RID: 931
			public BloomModel.BloomSettings bloom;

			// Token: 0x040003A4 RID: 932
			public BloomModel.LensDirtSettings lensDirt;
		}
	}
}
