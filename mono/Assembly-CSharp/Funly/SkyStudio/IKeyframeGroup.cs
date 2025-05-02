using System;

namespace Funly.SkyStudio
{
	// Token: 0x020001A4 RID: 420
	public interface IKeyframeGroup
	{
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000878 RID: 2168
		// (set) Token: 0x06000879 RID: 2169
		string name { get; set; }

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600087A RID: 2170
		string id { get; }

		// Token: 0x0600087B RID: 2171
		void SortKeyframes();

		// Token: 0x0600087C RID: 2172
		void TrimToSingleKeyframe();

		// Token: 0x0600087D RID: 2173
		void RemoveKeyFrame(IBaseKeyframe keyframe);

		// Token: 0x0600087E RID: 2174
		int GetKeyFrameCount();
	}
}
