using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Networking;
using ScheduleOne.Persistence;
using UnityEngine;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000B18 RID: 2840
	public class ContinueScreen : MainMenuScreen
	{
		// Token: 0x06004BCD RID: 19405 RVA: 0x0013E81E File Offset: 0x0013CA1E
		private void Update()
		{
			if (base.IsOpen)
			{
				this.NotHostWarning.gameObject.SetActive(!Singleton<Lobby>.Instance.IsHost);
			}
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x0013E845 File Offset: 0x0013CA45
		public void LoadGame(int index)
		{
			if (!Singleton<Lobby>.Instance.IsHost)
			{
				Console.LogWarning("Only the host can start the game.", null);
				return;
			}
			Singleton<LoadManager>.Instance.StartGame(LoadManager.SaveGames[index], false);
		}

		// Token: 0x040038D1 RID: 14545
		public RectTransform NotHostWarning;
	}
}
