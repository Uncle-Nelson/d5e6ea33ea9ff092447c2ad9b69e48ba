using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D7 RID: 215
	public class PostProcessingProfile : ScriptableObject
	{
		// Token: 0x04000466 RID: 1126
		public BuiltinDebugViewsModel debugViews = new BuiltinDebugViewsModel();

		// Token: 0x04000467 RID: 1127
		public FogModel fog = new FogModel();

		// Token: 0x04000468 RID: 1128
		public AntialiasingModel antialiasing = new AntialiasingModel();

		// Token: 0x04000469 RID: 1129
		public AmbientOcclusionModel ambientOcclusion = new AmbientOcclusionModel();

		// Token: 0x0400046A RID: 1130
		public ScreenSpaceReflectionModel screenSpaceReflection = new ScreenSpaceReflectionModel();

		// Token: 0x0400046B RID: 1131
		public DepthOfFieldModel depthOfField = new DepthOfFieldModel();

		// Token: 0x0400046C RID: 1132
		public MotionBlurModel motionBlur = new MotionBlurModel();

		// Token: 0x0400046D RID: 1133
		public EyeAdaptationModel eyeAdaptation = new EyeAdaptationModel();

		// Token: 0x0400046E RID: 1134
		public BloomModel bloom = new BloomModel();

		// Token: 0x0400046F RID: 1135
		public ColorGradingModel colorGrading = new ColorGradingModel();

		// Token: 0x04000470 RID: 1136
		public UserLutModel userLut = new UserLutModel();

		// Token: 0x04000471 RID: 1137
		public ChromaticAberrationModel chromaticAberration = new ChromaticAberrationModel();

		// Token: 0x04000472 RID: 1138
		public GrainModel grain = new GrainModel();

		// Token: 0x04000473 RID: 1139
		public VignetteModel vignette = new VignetteModel();

		// Token: 0x04000474 RID: 1140
		public DitheringModel dithering = new DitheringModel();
	}
}
