using System;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000B16 RID: 2838
	public class ConfirmExitScreen : MainMenuScreen
	{
		// Token: 0x06004BC7 RID: 19399 RVA: 0x0013E6C0 File Offset: 0x0013C8C0
		private void Update()
		{
			if (base.IsOpen)
			{
				float secondsSinceLastSave = Singleton<SaveManager>.Instance.SecondsSinceLastSave;
				if (InstanceFinder.IsServer)
				{
					if (secondsSinceLastSave <= 60f)
					{
						this.TimeSinceSaveLabel.text = "Last save was " + Mathf.RoundToInt(secondsSinceLastSave).ToString() + " seconds ago";
						this.TimeSinceSaveLabel.color = Color.white;
					}
					else
					{
						int num = Mathf.FloorToInt(secondsSinceLastSave / 60f);
						this.TimeSinceSaveLabel.text = string.Concat(new string[]
						{
							"Last save was ",
							num.ToString(),
							" minute",
							(num > 1) ? "s" : "",
							" ago"
						});
						this.TimeSinceSaveLabel.color = ((num > 1) ? new Color32(byte.MaxValue, 100, 100, byte.MaxValue) : Color.white);
					}
					this.TimeSinceSaveLabel.enabled = true;
					return;
				}
				this.TimeSinceSaveLabel.enabled = false;
			}
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x0013E7D1 File Offset: 0x0013C9D1
		public void ConfirmExit()
		{
			Singleton<LoadManager>.Instance.ExitToMenu(null, null, false);
			this.Close(true);
		}

		// Token: 0x040038CE RID: 14542
		public TextMeshProUGUI TimeSinceSaveLabel;
	}
}
