using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EasyButtons;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000850 RID: 2128
	public class DelayedUnityEvent : MonoBehaviour
	{
		// Token: 0x06003A59 RID: 14937 RVA: 0x000F69E0 File Offset: 0x000F4BE0
		[Button]
		public void Execute()
		{
			base.StartCoroutine(this.<Execute>g__Wait|3_0());
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x000F6A02 File Offset: 0x000F4C02
		[CompilerGenerated]
		private IEnumerator <Execute>g__Wait|3_0()
		{
			if (this.onDelayStart != null)
			{
				this.onDelayStart.Invoke();
			}
			yield return new WaitForSeconds(this.Delay);
			if (this.onDelayedExecute != null)
			{
				this.onDelayedExecute.Invoke();
			}
			yield break;
		}

		// Token: 0x04002A05 RID: 10757
		public float Delay = 1f;

		// Token: 0x04002A06 RID: 10758
		public UnityEvent onDelayStart;

		// Token: 0x04002A07 RID: 10759
		public UnityEvent onDelayedExecute;
	}
}
