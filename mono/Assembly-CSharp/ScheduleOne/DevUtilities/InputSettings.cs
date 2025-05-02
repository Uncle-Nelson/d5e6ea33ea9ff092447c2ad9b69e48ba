using System;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x0200070A RID: 1802
	[Serializable]
	public class InputSettings
	{
		// Token: 0x040022C0 RID: 8896
		public float MouseSensitivity;

		// Token: 0x040022C1 RID: 8897
		public bool InvertMouse;

		// Token: 0x040022C2 RID: 8898
		public InputSettings.EActionMode SprintMode;

		// Token: 0x040022C3 RID: 8899
		public string BindingOverrides;

		// Token: 0x0200070B RID: 1803
		public enum EActionMode
		{
			// Token: 0x040022C5 RID: 8901
			Press,
			// Token: 0x040022C6 RID: 8902
			Hold
		}
	}
}
