using System;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x0200098F RID: 2447
	[Serializable]
	public class AvatarEmotionPreset
	{
		// Token: 0x06004254 RID: 16980 RVA: 0x00115D24 File Offset: 0x00113F24
		public static AvatarEmotionPreset Lerp(AvatarEmotionPreset start, AvatarEmotionPreset end, AvatarEmotionPreset neutralPreset, float lerp)
		{
			AvatarEmotionPreset avatarEmotionPreset = new AvatarEmotionPreset();
			avatarEmotionPreset.PresetName = "Lerp";
			avatarEmotionPreset.FaceTexture = ((lerp > 0f) ? end.FaceTexture : start.FaceTexture);
			avatarEmotionPreset.LeftEyeRestingState = Eye.EyeLidConfiguration.Lerp(start.LeftEyeRestingState, end.LeftEyeRestingState, lerp);
			avatarEmotionPreset.RightEyeRestingState = Eye.EyeLidConfiguration.Lerp(start.RightEyeRestingState, end.RightEyeRestingState, lerp);
			float browAngleChange_L = start.BrowAngleChange_L;
			float browAngleChange_R = start.BrowAngleChange_R;
			float browHeightChange_L = start.BrowHeightChange_L;
			float browHeightChange_R = start.BrowHeightChange_R;
			float num = end.BrowAngleChange_L;
			float num2 = end.BrowAngleChange_R;
			float num3 = end.BrowHeightChange_L;
			float num4 = end.BrowHeightChange_R;
			if (end.PresetName != "Neutral")
			{
				num += neutralPreset.BrowAngleChange_L;
				num2 += neutralPreset.BrowAngleChange_R;
				num3 += neutralPreset.BrowHeightChange_L;
				num4 += neutralPreset.BrowHeightChange_R;
			}
			avatarEmotionPreset.BrowAngleChange_L = Mathf.Lerp(browAngleChange_L, num, lerp);
			avatarEmotionPreset.BrowAngleChange_R = Mathf.Lerp(browAngleChange_R, num2, lerp);
			avatarEmotionPreset.BrowHeightChange_L = Mathf.Lerp(browHeightChange_L, num3, lerp);
			avatarEmotionPreset.BrowHeightChange_R = Mathf.Lerp(browHeightChange_R, num4, lerp);
			return avatarEmotionPreset;
		}

		// Token: 0x04002FEA RID: 12266
		public string PresetName = "Preset Name";

		// Token: 0x04002FEB RID: 12267
		public Texture2D FaceTexture;

		// Token: 0x04002FEC RID: 12268
		public Eye.EyeLidConfiguration LeftEyeRestingState;

		// Token: 0x04002FED RID: 12269
		public Eye.EyeLidConfiguration RightEyeRestingState;

		// Token: 0x04002FEE RID: 12270
		[Range(-30f, 30f)]
		public float BrowAngleChange_L;

		// Token: 0x04002FEF RID: 12271
		[Range(-30f, 30f)]
		public float BrowAngleChange_R;

		// Token: 0x04002FF0 RID: 12272
		[Range(-1f, 1f)]
		public float BrowHeightChange_L;

		// Token: 0x04002FF1 RID: 12273
		[Range(-1f, 1f)]
		public float BrowHeightChange_R;
	}
}
