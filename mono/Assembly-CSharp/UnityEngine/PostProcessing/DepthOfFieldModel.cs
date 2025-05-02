using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000B6 RID: 182
	[Serializable]
	public class DepthOfFieldModel : PostProcessingModel
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600031B RID: 795 RVA: 0x000130CE File Offset: 0x000112CE
		// (set) Token: 0x0600031C RID: 796 RVA: 0x000130D6 File Offset: 0x000112D6
		public DepthOfFieldModel.Settings settings
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

		// Token: 0x0600031D RID: 797 RVA: 0x000130DF File Offset: 0x000112DF
		public override void Reset()
		{
			this.m_Settings = DepthOfFieldModel.Settings.defaultSettings;
		}

		// Token: 0x040003F4 RID: 1012
		[SerializeField]
		private DepthOfFieldModel.Settings m_Settings = DepthOfFieldModel.Settings.defaultSettings;

		// Token: 0x020000B7 RID: 183
		public enum KernelSize
		{
			// Token: 0x040003F6 RID: 1014
			Small,
			// Token: 0x040003F7 RID: 1015
			Medium,
			// Token: 0x040003F8 RID: 1016
			Large,
			// Token: 0x040003F9 RID: 1017
			VeryLarge
		}

		// Token: 0x020000B8 RID: 184
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000066 RID: 102
			// (get) Token: 0x0600031F RID: 799 RVA: 0x00013100 File Offset: 0x00011300
			public static DepthOfFieldModel.Settings defaultSettings
			{
				get
				{
					return new DepthOfFieldModel.Settings
					{
						focusDistance = 10f,
						aperture = 5.6f,
						focalLength = 50f,
						useCameraFov = false,
						kernelSize = DepthOfFieldModel.KernelSize.Medium
					};
				}
			}

			// Token: 0x040003FA RID: 1018
			[Min(0.1f)]
			[Tooltip("Distance to the point of focus.")]
			public float focusDistance;

			// Token: 0x040003FB RID: 1019
			[Range(0.05f, 32f)]
			[Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
			public float aperture;

			// Token: 0x040003FC RID: 1020
			[Range(1f, 300f)]
			[Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
			public float focalLength;

			// Token: 0x040003FD RID: 1021
			[Tooltip("Calculate the focal length automatically from the field-of-view value set on the camera. Using this setting isn't recommended.")]
			public bool useCameraFov;

			// Token: 0x040003FE RID: 1022
			[Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects the performance (the larger the kernel is, the longer the GPU time is required).")]
			public DepthOfFieldModel.KernelSize kernelSize;
		}
	}
}
