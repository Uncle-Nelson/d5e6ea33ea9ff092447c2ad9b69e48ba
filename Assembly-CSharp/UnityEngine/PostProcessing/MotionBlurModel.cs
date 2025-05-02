using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000C2 RID: 194
	[Serializable]
	public class MotionBlurModel : PostProcessingModel
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00013312 File Offset: 0x00011512
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0001331A File Offset: 0x0001151A
		public MotionBlurModel.Settings settings
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

		// Token: 0x06000336 RID: 822 RVA: 0x00013323 File Offset: 0x00011523
		public override void Reset()
		{
			this.m_Settings = MotionBlurModel.Settings.defaultSettings;
		}

		// Token: 0x04000416 RID: 1046
		[SerializeField]
		private MotionBlurModel.Settings m_Settings = MotionBlurModel.Settings.defaultSettings;

		// Token: 0x020000C3 RID: 195
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000070 RID: 112
			// (get) Token: 0x06000338 RID: 824 RVA: 0x00013344 File Offset: 0x00011544
			public static MotionBlurModel.Settings defaultSettings
			{
				get
				{
					return new MotionBlurModel.Settings
					{
						shutterAngle = 270f,
						sampleCount = 10,
						frameBlending = 0f
					};
				}
			}

			// Token: 0x04000417 RID: 1047
			[Range(0f, 360f)]
			[Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
			public float shutterAngle;

			// Token: 0x04000418 RID: 1048
			[Range(4f, 32f)]
			[Tooltip("The amount of sample points, which affects quality and performances.")]
			public int sampleCount;

			// Token: 0x04000419 RID: 1049
			[Range(0f, 1f)]
			[Tooltip("The strength of multiple frame blending. The opacity of preceding frames are determined from this coefficient and time differences.")]
			public float frameBlending;
		}
	}
}
