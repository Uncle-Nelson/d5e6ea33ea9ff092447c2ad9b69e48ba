using System;
using ScheduleOne.Persistence;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000B22 RID: 2850
	public class NewGameScreen : MainMenuScreen
	{
		// Token: 0x06004BF5 RID: 19445 RVA: 0x0013F014 File Offset: 0x0013D214
		public void SlotSelected(int slotIndex)
		{
			if (LoadManager.SaveGames[slotIndex] != null)
			{
				this.ConfirmOverwriteScreen.Initialize(slotIndex);
				this.ConfirmOverwriteScreen.Open(true);
				return;
			}
			this.SetupScreen.Initialize(slotIndex);
			this.SetupScreen.Open(false);
			this.Close(false);
		}

		// Token: 0x040038F7 RID: 14583
		public ConfirmOverwriteScreen ConfirmOverwriteScreen;

		// Token: 0x040038F8 RID: 14584
		public SetupScreen SetupScreen;
	}
}
