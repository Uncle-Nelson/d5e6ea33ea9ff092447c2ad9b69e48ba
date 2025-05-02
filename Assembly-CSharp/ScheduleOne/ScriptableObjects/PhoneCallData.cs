using System;
using ScheduleOne.Quests;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ScriptableObjects
{
	// Token: 0x0200077D RID: 1917
	[CreateAssetMenu(fileName = "PhoneCallData", menuName = "ScriptableObjects/PhoneCallData", order = 1)]
	[Serializable]
	public class PhoneCallData : ScriptableObject
	{
		// Token: 0x06003469 RID: 13417 RVA: 0x000DAF0E File Offset: 0x000D910E
		public void Completed()
		{
			if (this.onCallCompleted != null)
			{
				this.onCallCompleted.Invoke();
			}
		}

		// Token: 0x04002577 RID: 9591
		public CallerID CallerID;

		// Token: 0x04002578 RID: 9592
		public PhoneCallData.Stage[] Stages;

		// Token: 0x04002579 RID: 9593
		public UnityEvent onCallCompleted;

		// Token: 0x0200077E RID: 1918
		[Serializable]
		public class Stage
		{
			// Token: 0x0600346B RID: 13419 RVA: 0x000DAF24 File Offset: 0x000D9124
			public void OnStageStart()
			{
				if (this.OnStartTriggers != null)
				{
					for (int i = 0; i < this.OnStartTriggers.Length; i++)
					{
						this.OnStartTriggers[i].Trigger();
					}
				}
			}

			// Token: 0x0600346C RID: 13420 RVA: 0x000DAF5C File Offset: 0x000D915C
			public void OnStageEnd()
			{
				if (this.OnDoneTriggers != null)
				{
					for (int i = 0; i < this.OnDoneTriggers.Length; i++)
					{
						this.OnDoneTriggers[i].Trigger();
					}
				}
			}

			// Token: 0x0400257A RID: 9594
			[TextArea(3, 10)]
			public string Text;

			// Token: 0x0400257B RID: 9595
			public SystemTrigger[] OnStartTriggers;

			// Token: 0x0400257C RID: 9596
			public SystemTrigger[] OnDoneTriggers;
		}
	}
}
