using System;
using FishNet;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A7A RID: 2682
	public class GameSettingsWindow : MonoBehaviour
	{
		// Token: 0x06004847 RID: 18503 RVA: 0x0012FAC9 File Offset: 0x0012DCC9
		private void Awake()
		{
			this.ConsoleToggle.onValueChanged.AddListener(new UnityAction<bool>(this.ConsoleToggled));
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x0012FAE7 File Offset: 0x0012DCE7
		public void Start()
		{
			this.ApplySettings(NetworkSingleton<GameManager>.Instance.Settings);
			this.Blocker.SetActive(!InstanceFinder.IsServer);
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x0012FB0C File Offset: 0x0012DD0C
		public void ApplySettings(GameSettings settings)
		{
			this.ConsoleToggle.SetIsOnWithoutNotify(settings.ConsoleEnabled);
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x0012FB1F File Offset: 0x0012DD1F
		private void ConsoleToggled(bool value)
		{
			NetworkSingleton<GameManager>.Instance.Settings.ConsoleEnabled = value;
		}

		// Token: 0x04003593 RID: 13715
		public Toggle ConsoleToggle;

		// Token: 0x04003594 RID: 13716
		public GameObject Blocker;
	}
}
