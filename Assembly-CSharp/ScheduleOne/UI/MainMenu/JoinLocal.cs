using System;
using FishNet.Managing;
using UnityEngine;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000B1B RID: 2843
	public class JoinLocal : MonoBehaviour
	{
		// Token: 0x06004BDA RID: 19418 RVA: 0x0013EA38 File Offset: 0x0013CC38
		private void Awake()
		{
			base.gameObject.SetActive(Application.isEditor || Debug.isDebugBuild);
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x0013EA54 File Offset: 0x0013CC54
		public void Clicked()
		{
			Object.FindObjectOfType<NetworkManager>().ClientManager.StartConnection();
		}
	}
}
