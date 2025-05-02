using System;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200087A RID: 2170
	public class SmoothRotate : MonoBehaviour
	{
		// Token: 0x06003AF3 RID: 15091 RVA: 0x000F8330 File Offset: 0x000F6530
		private void Update()
		{
			if (this.Active)
			{
				this.currentSpeed = Mathf.MoveTowards(this.currentSpeed, this.Speed, this.Aceleration * Time.deltaTime);
			}
			else
			{
				this.currentSpeed = Mathf.MoveTowards(this.currentSpeed, 0f, this.Aceleration * Time.deltaTime);
			}
			base.transform.Rotate(this.Axis, this.currentSpeed * Time.deltaTime, Space.Self);
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x000F83AA File Offset: 0x000F65AA
		public void SetActive(bool active)
		{
			this.Active = active;
		}

		// Token: 0x04002A71 RID: 10865
		public bool Active = true;

		// Token: 0x04002A72 RID: 10866
		public float Speed = 5f;

		// Token: 0x04002A73 RID: 10867
		public float Aceleration = 2f;

		// Token: 0x04002A74 RID: 10868
		public Vector3 Axis = Vector3.up;

		// Token: 0x04002A75 RID: 10869
		private float currentSpeed;
	}
}
