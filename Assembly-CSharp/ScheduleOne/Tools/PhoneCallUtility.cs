using System;
using ScheduleOne.Calling;
using ScheduleOne.DevUtilities;
using ScheduleOne.ScriptableObjects;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200086B RID: 2155
	public class PhoneCallUtility : MonoBehaviour
	{
		// Token: 0x06003ABA RID: 15034 RVA: 0x000F74DB File Offset: 0x000F56DB
		public void PromptCall(PhoneCallData callData)
		{
			Singleton<CallManager>.Instance.QueueCall(callData);
		}

		// Token: 0x06003ABB RID: 15035 RVA: 0x000F74DB File Offset: 0x000F56DB
		public void StartCall(PhoneCallData callData)
		{
			Singleton<CallManager>.Instance.QueueCall(callData);
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x000F74DB File Offset: 0x000F56DB
		public void SetQueuedCall(PhoneCallData callData)
		{
			Singleton<CallManager>.Instance.QueueCall(callData);
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x000F74E8 File Offset: 0x000F56E8
		public void ClearCall()
		{
			Singleton<CallManager>.Instance.ClearQueuedCall();
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x000045B1 File Offset: 0x000027B1
		public void SetPhoneOpenable(bool openable)
		{
		}
	}
}
