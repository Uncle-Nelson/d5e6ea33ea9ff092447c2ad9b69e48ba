using System;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x0200068D RID: 1677
	public class PivotDoor : MonoBehaviour
	{
		// Token: 0x06002E7E RID: 11902 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void Awake()
		{
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x000C307D File Offset: 0x000C127D
		private void LateUpdate()
		{
			this.DoorTransform.localRotation = Quaternion.Lerp(this.DoorTransform.localRotation, Quaternion.Euler(0f, this.targetDoorAngle, 0f), Time.deltaTime * this.SwingSpeed);
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x000C30BC File Offset: 0x000C12BC
		public virtual void Opened(EDoorSide openSide)
		{
			if (openSide == EDoorSide.Interior)
			{
				this.targetDoorAngle = (this.FlipSide ? this.OpenInwardsAngle : this.OpenOutwardsAngle);
				return;
			}
			if (openSide != EDoorSide.Exterior)
			{
				return;
			}
			this.targetDoorAngle = (this.FlipSide ? this.OpenOutwardsAngle : this.OpenInwardsAngle);
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x000C310A File Offset: 0x000C130A
		public virtual void Closed()
		{
			this.targetDoorAngle = 0f;
		}

		// Token: 0x040020FD RID: 8445
		[Header("Settings")]
		public Transform DoorTransform;

		// Token: 0x040020FE RID: 8446
		public bool FlipSide;

		// Token: 0x040020FF RID: 8447
		public float OpenInwardsAngle = -100f;

		// Token: 0x04002100 RID: 8448
		public float OpenOutwardsAngle = 100f;

		// Token: 0x04002101 RID: 8449
		public float SwingSpeed = 5f;

		// Token: 0x04002102 RID: 8450
		private float targetDoorAngle;
	}
}
