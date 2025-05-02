using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000C0 RID: 192
	[Serializable]
	public class GrainModel : PostProcessingModel
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0001329E File Offset: 0x0001149E
		// (set) Token: 0x06000330 RID: 816 RVA: 0x000132A6 File Offset: 0x000114A6
		public GrainModel.Settings settings
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

		// Token: 0x06000331 RID: 817 RVA: 0x000132AF File Offset: 0x000114AF
		public override void Reset()
		{
			this.m_Settings = GrainModel.Settings.defaultSettings;
		}

		// Token: 0x04000411 RID: 1041
		[SerializeField]
		private GrainModel.Settings m_Settings = GrainModel.Settings.defaultSettings;

		// Token: 0x020000C1 RID: 193
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700006E RID: 110
			// (get) Token: 0x06000333 RID: 819 RVA: 0x000132D0 File Offset: 0x000114D0
			public static GrainModel.Settings defaultSettings
			{
				get
				{
					return new GrainModel.Settings
					{
						colored = true,
						intensity = 0.5f,
						size = 1f,
						luminanceContribution = 0.8f
					};
				}
			}

			// Token: 0x04000412 RID: 1042
			[Tooltip("Enable the use of colored grain.")]
			public bool colored;

			// Token: 0x04000413 RID: 1043
			[Range(0f, 1f)]
			[Tooltip("Grain strength. Higher means more visible grain.")]
			public float intensity;

			// Token: 0x04000414 RID: 1044
			[Range(0.3f, 3f)]
			[Tooltip("Grain particle size.")]
			public float size;

			// Token: 0x04000415 RID: 1045
			[Range(0f, 1f)]
			[Tooltip("Controls the noisiness response curve based on scene luminance. Lower values mean less noise in dark areas.")]
			public float luminanceContribution;
		}
	}
}
