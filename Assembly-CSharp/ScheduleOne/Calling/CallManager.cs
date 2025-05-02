using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ScriptableObjects;
using ScheduleOne.UI.Phone;
using UnityEngine;

namespace ScheduleOne.Calling
{
	// Token: 0x0200077A RID: 1914
	public class CallManager : Singleton<CallManager>
	{
		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06003459 RID: 13401 RVA: 0x000DAC77 File Offset: 0x000D8E77
		// (set) Token: 0x0600345A RID: 13402 RVA: 0x000DAC7F File Offset: 0x000D8E7F
		public PhoneCallData QueuedCallData { get; private set; }

		// Token: 0x0600345B RID: 13403 RVA: 0x000DAC88 File Offset: 0x000D8E88
		protected override void Start()
		{
			base.Start();
			if (Singleton<CallInterface>.Instance == null)
			{
				Debug.LogError("CallInterface instance is null. CallManager cannot function without it.");
				return;
			}
			CallInterface instance = Singleton<CallInterface>.Instance;
			instance.CallCompleted = (Action<PhoneCallData>)Delegate.Combine(instance.CallCompleted, new Action<PhoneCallData>(this.CallCompleted));
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x000DACD9 File Offset: 0x000D8ED9
		protected override void OnDestroy()
		{
			base.OnDestroy();
			if (Singleton<CallInterface>.Instance != null)
			{
				CallInterface instance = Singleton<CallInterface>.Instance;
				instance.CallCompleted = (Action<PhoneCallData>)Delegate.Remove(instance.CallCompleted, new Action<PhoneCallData>(this.CallCompleted));
			}
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x000DAD14 File Offset: 0x000D8F14
		public void QueueCall(PhoneCallData data)
		{
			this.QueuedCallData = data;
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x000DAD1D File Offset: 0x000D8F1D
		public void ClearQueuedCall()
		{
			this.QueuedCallData = null;
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x000DAD26 File Offset: 0x000D8F26
		private void CallCompleted(PhoneCallData call)
		{
			if (call == this.QueuedCallData)
			{
				this.ClearQueuedCall();
			}
		}
	}
}
