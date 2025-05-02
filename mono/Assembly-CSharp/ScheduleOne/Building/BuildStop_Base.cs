using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x0200078A RID: 1930
	public class BuildStop_Base : MonoBehaviour
	{
		// Token: 0x0600349A RID: 13466 RVA: 0x000DBB44 File Offset: 0x000D9D44
		public virtual void Stop_Building()
		{
			if (PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount == 0)
			{
				Singleton<HUD>.Instance.SetCrosshairVisible(true);
			}
			base.GetComponent<BuildUpdate_Base>().Stop();
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			Object.Destroy(base.gameObject);
		}
	}
}
