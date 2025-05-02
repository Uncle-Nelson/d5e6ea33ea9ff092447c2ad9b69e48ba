using System;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000707 RID: 1799
	[Serializable]
	public class GraphicsSettings
	{
		// Token: 0x040022B2 RID: 8882
		public GraphicsSettings.EGraphicsQuality GraphicsQuality;

		// Token: 0x040022B3 RID: 8883
		public GraphicsSettings.EAntiAliasingMode AntiAliasingMode;

		// Token: 0x040022B4 RID: 8884
		public float FOV;

		// Token: 0x040022B5 RID: 8885
		public bool SSAO;

		// Token: 0x040022B6 RID: 8886
		public bool GodRays;

		// Token: 0x02000708 RID: 1800
		public enum EAntiAliasingMode
		{
			// Token: 0x040022B8 RID: 8888
			Off,
			// Token: 0x040022B9 RID: 8889
			FXAA,
			// Token: 0x040022BA RID: 8890
			SMAA
		}

		// Token: 0x02000709 RID: 1801
		public enum EGraphicsQuality
		{
			// Token: 0x040022BC RID: 8892
			Low,
			// Token: 0x040022BD RID: 8893
			Medium,
			// Token: 0x040022BE RID: 8894
			High,
			// Token: 0x040022BF RID: 8895
			Ultra
		}
	}
}
