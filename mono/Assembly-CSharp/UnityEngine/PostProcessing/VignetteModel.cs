using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000CD RID: 205
	[Serializable]
	public class VignetteModel : PostProcessingModel
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000343 RID: 835 RVA: 0x000134DA File Offset: 0x000116DA
		// (set) Token: 0x06000344 RID: 836 RVA: 0x000134E2 File Offset: 0x000116E2
		public VignetteModel.Settings settings
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

		// Token: 0x06000345 RID: 837 RVA: 0x000134EB File Offset: 0x000116EB
		public override void Reset()
		{
			this.m_Settings = VignetteModel.Settings.defaultSettings;
		}

		// Token: 0x04000434 RID: 1076
		[SerializeField]
		private VignetteModel.Settings m_Settings = VignetteModel.Settings.defaultSettings;

		// Token: 0x020000CE RID: 206
		public enum Mode
		{
			// Token: 0x04000436 RID: 1078
			Classic,
			// Token: 0x04000437 RID: 1079
			Masked
		}

		// Token: 0x020000CF RID: 207
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000076 RID: 118
			// (get) Token: 0x06000347 RID: 839 RVA: 0x0001350C File Offset: 0x0001170C
			public static VignetteModel.Settings defaultSettings
			{
				get
				{
					return new VignetteModel.Settings
					{
						mode = VignetteModel.Mode.Classic,
						color = new Color(0f, 0f, 0f, 1f),
						center = new Vector2(0.5f, 0.5f),
						intensity = 0.45f,
						smoothness = 0.2f,
						roundness = 1f,
						mask = null,
						opacity = 1f,
						rounded = false
					};
				}
			}

			// Token: 0x04000438 RID: 1080
			[Tooltip("Use the \"Classic\" mode for parametric controls. Use the \"Masked\" mode to use your own texture mask.")]
			public VignetteModel.Mode mode;

			// Token: 0x04000439 RID: 1081
			[ColorUsage(false)]
			[Tooltip("Vignette color. Use the alpha channel for transparency.")]
			public Color color;

			// Token: 0x0400043A RID: 1082
			[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
			public Vector2 center;

			// Token: 0x0400043B RID: 1083
			[Range(0f, 1f)]
			[Tooltip("Amount of vignetting on screen.")]
			public float intensity;

			// Token: 0x0400043C RID: 1084
			[Range(0.01f, 1f)]
			[Tooltip("Smoothness of the vignette borders.")]
			public float smoothness;

			// Token: 0x0400043D RID: 1085
			[Range(0f, 1f)]
			[Tooltip("Lower values will make a square-ish vignette.")]
			public float roundness;

			// Token: 0x0400043E RID: 1086
			[Tooltip("A black and white mask to use as a vignette.")]
			public Texture mask;

			// Token: 0x0400043F RID: 1087
			[Range(0f, 1f)]
			[Tooltip("Mask opacity.")]
			public float opacity;

			// Token: 0x04000440 RID: 1088
			[Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
			public bool rounded;
		}
	}
}
