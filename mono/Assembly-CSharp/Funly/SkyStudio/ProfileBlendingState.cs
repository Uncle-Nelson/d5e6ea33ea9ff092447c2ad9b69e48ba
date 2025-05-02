using System;

namespace Funly.SkyStudio
{
	// Token: 0x020001A0 RID: 416
	public struct ProfileBlendingState
	{
		// Token: 0x06000871 RID: 2161 RVA: 0x00026BD9 File Offset: 0x00024DD9
		public ProfileBlendingState(SkyProfile blendedProfile, SkyProfile fromProfile, SkyProfile toProfile, float progress, float outProgress, float inProgress, float timeOfDay)
		{
			this.blendedProfile = blendedProfile;
			this.fromProfile = fromProfile;
			this.toProfile = toProfile;
			this.progress = progress;
			this.inProgress = inProgress;
			this.outProgress = outProgress;
			this.timeOfDay = timeOfDay;
		}

		// Token: 0x04000951 RID: 2385
		public SkyProfile blendedProfile;

		// Token: 0x04000952 RID: 2386
		public SkyProfile fromProfile;

		// Token: 0x04000953 RID: 2387
		public SkyProfile toProfile;

		// Token: 0x04000954 RID: 2388
		public float progress;

		// Token: 0x04000955 RID: 2389
		public float outProgress;

		// Token: 0x04000956 RID: 2390
		public float inProgress;

		// Token: 0x04000957 RID: 2391
		public float timeOfDay;
	}
}
