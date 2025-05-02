using System;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006F3 RID: 1779
	public abstract class PersistentSingleton<T> : Singleton<T> where T : Singleton<T>
	{
		// Token: 0x0600306A RID: 12394 RVA: 0x000C9B35 File Offset: 0x000C7D35
		protected override void Awake()
		{
			base.Awake();
			if (this.Destroyed)
			{
				return;
			}
			base.transform.SetParent(null);
			Object.DontDestroyOnLoad(base.gameObject);
		}
	}
}
