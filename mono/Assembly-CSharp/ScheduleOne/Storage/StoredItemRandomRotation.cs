using System;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008B7 RID: 2231
	public class StoredItemRandomRotation : MonoBehaviour
	{
		// Token: 0x06003CB5 RID: 15541 RVA: 0x000FFB98 File Offset: 0x000FDD98
		public void Awake()
		{
			this.ItemContainer.localEulerAngles = new Vector3(this.ItemContainer.localEulerAngles.x, Random.Range(0f, 360f), this.ItemContainer.localEulerAngles.z);
		}

		// Token: 0x04002B9A RID: 11162
		public Transform ItemContainer;
	}
}
