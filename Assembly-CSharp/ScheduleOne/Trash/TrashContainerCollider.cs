using System;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x0200082C RID: 2092
	[RequireComponent(typeof(Rigidbody))]
	public class TrashContainerCollider : MonoBehaviour
	{
		// Token: 0x06003959 RID: 14681 RVA: 0x000F298F File Offset: 0x000F0B8F
		public void OnTriggerEnter(Collider other)
		{
			this.Container.TriggerEnter(other);
		}

		// Token: 0x04002974 RID: 10612
		public TrashContainer Container;
	}
}
