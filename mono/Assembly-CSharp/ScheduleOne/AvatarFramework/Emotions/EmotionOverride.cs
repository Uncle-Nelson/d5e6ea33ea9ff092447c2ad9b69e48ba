using System;

namespace ScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x02000986 RID: 2438
	public class EmotionOverride
	{
		// Token: 0x06004226 RID: 16934 RVA: 0x00115589 File Offset: 0x00113789
		public EmotionOverride(string emotion, string label, int priority)
		{
			this.Emotion = emotion;
			this.Label = label;
			this.Priority = priority;
		}

		// Token: 0x04002FC5 RID: 12229
		public string Emotion;

		// Token: 0x04002FC6 RID: 12230
		public string Label;

		// Token: 0x04002FC7 RID: 12231
		public int Priority;
	}
}
