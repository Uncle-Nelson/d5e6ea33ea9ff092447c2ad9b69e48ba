using System;
using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.Misc
{
	// Token: 0x02000C09 RID: 3081
	public class CarStopper : MonoBehaviour
	{
		// Token: 0x060056A1 RID: 22177 RVA: 0x0016C35C File Offset: 0x0016A55C
		protected virtual void Update()
		{
			float num = 70f;
			if (this.isActive)
			{
				this.Obstacle.enabled = true;
				this.blocker.localEulerAngles = new Vector3(0f, 0f, Mathf.Clamp(this.blocker.localEulerAngles.z + Time.deltaTime * num / this.moveTime, 0f, num));
				return;
			}
			this.Obstacle.enabled = false;
			this.blocker.localEulerAngles = new Vector3(0f, 0f, Mathf.Clamp(this.blocker.localEulerAngles.z - Time.deltaTime * num / this.moveTime, 0f, num));
		}

		// Token: 0x04004001 RID: 16385
		public bool isActive;

		// Token: 0x04004002 RID: 16386
		[Header("References")]
		[SerializeField]
		protected Transform blocker;

		// Token: 0x04004003 RID: 16387
		public NavMeshObstacle Obstacle;

		// Token: 0x04004004 RID: 16388
		private float moveTime = 0.5f;
	}
}
