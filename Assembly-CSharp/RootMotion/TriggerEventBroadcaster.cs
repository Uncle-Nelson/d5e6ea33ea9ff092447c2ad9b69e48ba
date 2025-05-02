using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000025 RID: 37
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		// Token: 0x06000127 RID: 295 RVA: 0x00007BC9 File Offset: 0x00005DC9
		private void OnTriggerEnter(Collider collider)
		{
			if (this.target != null)
			{
				this.target.SendMessage("OnTriggerEnter", collider, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00007BEB File Offset: 0x00005DEB
		private void OnTriggerStay(Collider collider)
		{
			if (this.target != null)
			{
				this.target.SendMessage("OnTriggerStay", collider, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00007C0D File Offset: 0x00005E0D
		private void OnTriggerExit(Collider collider)
		{
			if (this.target != null)
			{
				this.target.SendMessage("OnTriggerExit", collider, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x040000E1 RID: 225
		public GameObject target;
	}
}
