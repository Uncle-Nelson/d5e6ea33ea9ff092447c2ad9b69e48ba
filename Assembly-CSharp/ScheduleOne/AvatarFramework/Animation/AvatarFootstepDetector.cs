using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Materials;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000998 RID: 2456
	public class AvatarFootstepDetector : MonoBehaviour
	{
		// Token: 0x06004296 RID: 17046 RVA: 0x00117258 File Offset: 0x00115458
		private void LateUpdate()
		{
			if (!this.Avatar.Anim.animator.enabled)
			{
				this.leftDown = false;
				this.rightDown = false;
				return;
			}
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			if (!this.LeftBone.gameObject.activeInHierarchy)
			{
				return;
			}
			if (Vector3.Distance(this.ReferencePoint.position, PlayerSingleton<PlayerCamera>.Instance.transform.position) > 20f)
			{
				this.leftDown = false;
				this.rightDown = false;
				return;
			}
			if (this.LeftBone.position.y - this.ReferencePoint.position.y < this.StepThreshold)
			{
				if (!this.leftDown)
				{
					this.leftDown = true;
					this.TriggerStep();
				}
			}
			else
			{
				this.leftDown = false;
			}
			if (this.RightBone.position.y - this.ReferencePoint.position.y < this.StepThreshold)
			{
				if (!this.rightDown)
				{
					this.rightDown = true;
					this.TriggerStep();
					return;
				}
			}
			else
			{
				this.rightDown = false;
			}
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x00117368 File Offset: 0x00115568
		public void TriggerStep()
		{
			EMaterialType arg;
			if (this.IsGrounded(out arg))
			{
				this.onStep.Invoke(arg, 1f);
			}
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x00117390 File Offset: 0x00115590
		public bool IsGrounded(out EMaterialType surfaceType)
		{
			surfaceType = EMaterialType.Generic;
			RaycastHit raycastHit;
			if (Physics.Raycast(this.ReferencePoint.position + Vector3.up * 0.1f, Vector3.down, ref raycastHit, 0.25f, this.GroundDetectionMask, 1))
			{
				MaterialTag componentInParent = raycastHit.collider.GetComponentInParent<MaterialTag>();
				if (componentInParent != null)
				{
					surfaceType = componentInParent.MaterialType;
				}
				return true;
			}
			return false;
		}

		// Token: 0x04003036 RID: 12342
		public const float MAX_DETECTION_RANGE = 20f;

		// Token: 0x04003037 RID: 12343
		public const float GROUND_DETECTION_RANGE = 0.25f;

		// Token: 0x04003038 RID: 12344
		public Avatar Avatar;

		// Token: 0x04003039 RID: 12345
		public Transform ReferencePoint;

		// Token: 0x0400303A RID: 12346
		public Transform LeftBone;

		// Token: 0x0400303B RID: 12347
		public Transform RightBone;

		// Token: 0x0400303C RID: 12348
		public float StepThreshold = 0.1f;

		// Token: 0x0400303D RID: 12349
		public LayerMask GroundDetectionMask;

		// Token: 0x0400303E RID: 12350
		private bool leftDown;

		// Token: 0x0400303F RID: 12351
		private bool rightDown;

		// Token: 0x04003040 RID: 12352
		public UnityEvent<EMaterialType, float> onStep = new UnityEvent<EMaterialType, float>();
	}
}
