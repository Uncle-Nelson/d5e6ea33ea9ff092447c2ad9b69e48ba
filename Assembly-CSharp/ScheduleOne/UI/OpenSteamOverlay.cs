using System;
using Steamworks;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x020009B8 RID: 2488
	public class OpenSteamOverlay : MonoBehaviour
	{
		// Token: 0x0600432D RID: 17197 RVA: 0x00119A94 File Offset: 0x00117C94
		public void OpenOverlay()
		{
			if (!SteamManager.Initialized)
			{
				return;
			}
			OpenSteamOverlay.EType type = this.Type;
			if (type == OpenSteamOverlay.EType.Store)
			{
				SteamFriends.ActivateGameOverlayToStore(new AppId_t(3164500U), EOverlayToStoreFlag.k_EOverlayToStoreFlag_None);
				return;
			}
			if (type != OpenSteamOverlay.EType.CustomLink)
			{
				return;
			}
			SteamFriends.ActivateGameOverlayToWebPage(this.CustomLink, EActivateGameOverlayToWebPageMode.k_EActivateGameOverlayToWebPageMode_Default);
		}

		// Token: 0x040030CE RID: 12494
		public const uint APP_ID = 3164500U;

		// Token: 0x040030CF RID: 12495
		public OpenSteamOverlay.EType Type;

		// Token: 0x040030D0 RID: 12496
		public string CustomLink;

		// Token: 0x020009B9 RID: 2489
		public enum EType
		{
			// Token: 0x040030D2 RID: 12498
			Store,
			// Token: 0x040030D3 RID: 12499
			CustomLink
		}
	}
}
