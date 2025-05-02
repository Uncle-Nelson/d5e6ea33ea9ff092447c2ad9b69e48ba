using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000864 RID: 2148
	public class ImpactDetector : MonoBehaviour
	{
		// Token: 0x06003A9F RID: 15007 RVA: 0x000F7122 File Offset: 0x000F5322
		private void OnCollisionEnter(Collision collision)
		{
			this.onImpact.Invoke();
			if (this.DestroyScriptOnImpact)
			{
				Object.Destroy(this);
			}
		}

		// Token: 0x04002A2E RID: 10798
		public bool DestroyScriptOnImpact;

		// Token: 0x04002A2F RID: 10799
		public UnityEvent onImpact = new UnityEvent();
	}
}
