using System;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000B17 RID: 2839
	public class ConfirmOverwriteScreen : MainMenuScreen
	{
		// Token: 0x06004BCA RID: 19402 RVA: 0x0013E7EF File Offset: 0x0013C9EF
		public void Initialize(int index)
		{
			this.slotIndex = index;
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x0013E7F8 File Offset: 0x0013C9F8
		public void Confirm()
		{
			this.Close(false);
			this.SetupScreen.Initialize(this.slotIndex);
			this.SetupScreen.Open(false);
		}

		// Token: 0x040038CF RID: 14543
		public SetupScreen SetupScreen;

		// Token: 0x040038D0 RID: 14544
		private int slotIndex;
	}
}
