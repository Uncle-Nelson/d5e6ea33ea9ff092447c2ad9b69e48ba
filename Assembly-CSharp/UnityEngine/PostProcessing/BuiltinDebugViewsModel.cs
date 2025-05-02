using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000A4 RID: 164
	[Serializable]
	public class BuiltinDebugViewsModel : PostProcessingModel
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00012A1A File Offset: 0x00010C1A
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00012A22 File Offset: 0x00010C22
		public BuiltinDebugViewsModel.Settings settings
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

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00012A2B File Offset: 0x00010C2B
		public bool willInterrupt
		{
			get
			{
				return !this.IsModeActive(BuiltinDebugViewsModel.Mode.None) && !this.IsModeActive(BuiltinDebugViewsModel.Mode.EyeAdaptation) && !this.IsModeActive(BuiltinDebugViewsModel.Mode.PreGradingLog) && !this.IsModeActive(BuiltinDebugViewsModel.Mode.LogLut) && !this.IsModeActive(BuiltinDebugViewsModel.Mode.UserLut);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00012A5E File Offset: 0x00010C5E
		public override void Reset()
		{
			this.settings = BuiltinDebugViewsModel.Settings.defaultSettings;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00012A6B File Offset: 0x00010C6B
		public bool IsModeActive(BuiltinDebugViewsModel.Mode mode)
		{
			return this.m_Settings.mode == mode;
		}

		// Token: 0x040003A5 RID: 933
		[SerializeField]
		private BuiltinDebugViewsModel.Settings m_Settings = BuiltinDebugViewsModel.Settings.defaultSettings;

		// Token: 0x020000A5 RID: 165
		[Serializable]
		public struct DepthSettings
		{
			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000302 RID: 770 RVA: 0x00012A90 File Offset: 0x00010C90
			public static BuiltinDebugViewsModel.DepthSettings defaultSettings
			{
				get
				{
					return new BuiltinDebugViewsModel.DepthSettings
					{
						scale = 1f
					};
				}
			}

			// Token: 0x040003A6 RID: 934
			[Range(0f, 1f)]
			[Tooltip("Scales the camera far plane before displaying the depth map.")]
			public float scale;
		}

		// Token: 0x020000A6 RID: 166
		[Serializable]
		public struct MotionVectorsSettings
		{
			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000303 RID: 771 RVA: 0x00012AB4 File Offset: 0x00010CB4
			public static BuiltinDebugViewsModel.MotionVectorsSettings defaultSettings
			{
				get
				{
					return new BuiltinDebugViewsModel.MotionVectorsSettings
					{
						sourceOpacity = 1f,
						motionImageOpacity = 0f,
						motionImageAmplitude = 16f,
						motionVectorsOpacity = 1f,
						motionVectorsResolution = 24,
						motionVectorsAmplitude = 64f
					};
				}
			}

			// Token: 0x040003A7 RID: 935
			[Range(0f, 1f)]
			[Tooltip("Opacity of the source render.")]
			public float sourceOpacity;

			// Token: 0x040003A8 RID: 936
			[Range(0f, 1f)]
			[Tooltip("Opacity of the per-pixel motion vector colors.")]
			public float motionImageOpacity;

			// Token: 0x040003A9 RID: 937
			[Min(0f)]
			[Tooltip("Because motion vectors are mainly very small vectors, you can use this setting to make them more visible.")]
			public float motionImageAmplitude;

			// Token: 0x040003AA RID: 938
			[Range(0f, 1f)]
			[Tooltip("Opacity for the motion vector arrows.")]
			public float motionVectorsOpacity;

			// Token: 0x040003AB RID: 939
			[Range(8f, 64f)]
			[Tooltip("The arrow density on screen.")]
			public int motionVectorsResolution;

			// Token: 0x040003AC RID: 940
			[Min(0f)]
			[Tooltip("Tweaks the arrows length.")]
			public float motionVectorsAmplitude;
		}

		// Token: 0x020000A7 RID: 167
		public enum Mode
		{
			// Token: 0x040003AE RID: 942
			None,
			// Token: 0x040003AF RID: 943
			Depth,
			// Token: 0x040003B0 RID: 944
			Normals,
			// Token: 0x040003B1 RID: 945
			MotionVectors,
			// Token: 0x040003B2 RID: 946
			AmbientOcclusion,
			// Token: 0x040003B3 RID: 947
			EyeAdaptation,
			// Token: 0x040003B4 RID: 948
			FocusPlane,
			// Token: 0x040003B5 RID: 949
			PreGradingLog,
			// Token: 0x040003B6 RID: 950
			LogLut,
			// Token: 0x040003B7 RID: 951
			UserLut
		}

		// Token: 0x020000A8 RID: 168
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000304 RID: 772 RVA: 0x00012B10 File Offset: 0x00010D10
			public static BuiltinDebugViewsModel.Settings defaultSettings
			{
				get
				{
					return new BuiltinDebugViewsModel.Settings
					{
						mode = BuiltinDebugViewsModel.Mode.None,
						depth = BuiltinDebugViewsModel.DepthSettings.defaultSettings,
						motionVectors = BuiltinDebugViewsModel.MotionVectorsSettings.defaultSettings
					};
				}
			}

			// Token: 0x040003B8 RID: 952
			public BuiltinDebugViewsModel.Mode mode;

			// Token: 0x040003B9 RID: 953
			public BuiltinDebugViewsModel.DepthSettings depth;

			// Token: 0x040003BA RID: 954
			public BuiltinDebugViewsModel.MotionVectorsSettings motionVectors;
		}
	}
}
