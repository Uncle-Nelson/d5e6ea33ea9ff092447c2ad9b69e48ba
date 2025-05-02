using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000A9 RID: 169
	[Serializable]
	public class ChromaticAberrationModel : PostProcessingModel
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00012B46 File Offset: 0x00010D46
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00012B4E File Offset: 0x00010D4E
		public ChromaticAberrationModel.Settings settings
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

		// Token: 0x06000307 RID: 775 RVA: 0x00012B57 File Offset: 0x00010D57
		public override void Reset()
		{
			this.m_Settings = ChromaticAberrationModel.Settings.defaultSettings;
		}

		// Token: 0x040003BB RID: 955
		[SerializeField]
		private ChromaticAberrationModel.Settings m_Settings = ChromaticAberrationModel.Settings.defaultSettings;

		// Token: 0x020000AA RID: 170
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000309 RID: 777 RVA: 0x00012B78 File Offset: 0x00010D78
			public static ChromaticAberrationModel.Settings defaultSettings
			{
				get
				{
					return new ChromaticAberrationModel.Settings
					{
						spectralTexture = null,
						intensity = 0.1f
					};
				}
			}

			// Token: 0x040003BC RID: 956
			[Tooltip("Shift the hue of chromatic aberrations.")]
			public Texture2D spectralTexture;

			// Token: 0x040003BD RID: 957
			[Range(0f, 1f)]
			[Tooltip("Amount of tangential distortion.")]
			public float intensity;
		}
	}
}
