using System;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Persistence
{
	// Token: 0x02000366 RID: 870
	public class LoadEventTransmitter : MonoBehaviour
	{
		// Token: 0x060013B8 RID: 5048 RVA: 0x00057FC0 File Offset: 0x000561C0
		private void Start()
		{
			Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(this.OnLoadComplete));
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00057FDD File Offset: 0x000561DD
		private void OnLoadComplete()
		{
			if (this.onLoadComplete != null)
			{
				this.onLoadComplete.Invoke();
			}
		}

		// Token: 0x040012B7 RID: 4791
		public UnityEvent onLoadComplete;
	}
}
