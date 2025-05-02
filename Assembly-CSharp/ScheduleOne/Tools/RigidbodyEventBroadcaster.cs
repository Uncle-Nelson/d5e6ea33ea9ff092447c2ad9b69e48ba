using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000871 RID: 2161
	public class RigidbodyEventBroadcaster : MonoBehaviour
	{
		// Token: 0x06003AD6 RID: 15062 RVA: 0x000F7A6A File Offset: 0x000F5C6A
		private void OnTriggerEnter(Collider other)
		{
			if (this.onTriggerEnter != null)
			{
				this.onTriggerEnter.Invoke(other);
			}
		}

		// Token: 0x04002A53 RID: 10835
		public UnityEvent<Collider> onTriggerEnter;
	}
}
