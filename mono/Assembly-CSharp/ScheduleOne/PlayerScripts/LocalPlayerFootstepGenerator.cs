using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Materials;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005DA RID: 1498
	public class LocalPlayerFootstepGenerator : MonoBehaviour
	{
		// Token: 0x060024FC RID: 9468 RVA: 0x00094FB4 File Offset: 0x000931B4
		private void LateUpdate()
		{
			if (!PlayerSingleton<PlayerMovement>.InstanceExists)
			{
				return;
			}
			if (!PlayerSingleton<PlayerMovement>.Instance.canMove)
			{
				this.currentDistance = 0f;
				this.lastFramePosition = base.transform.position;
				return;
			}
			Vector3 position = base.transform.position;
			this.currentDistance += Vector3.Distance(position, this.lastFramePosition) * (PlayerSingleton<PlayerMovement>.Instance.isSprinting ? 0.75f : 1f);
			if (this.currentDistance >= this.DistancePerStep)
			{
				this.currentDistance = 0f;
				this.lastFramePosition = position;
				this.TriggerStep();
			}
			this.lastFramePosition = position;
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x00095060 File Offset: 0x00093260
		public void TriggerStep()
		{
			EMaterialType arg;
			if (this.IsGrounded(out arg))
			{
				this.onStep.Invoke(arg, PlayerSingleton<PlayerMovement>.Instance.isSprinting ? 1f : 0.5f);
			}
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x0009509C File Offset: 0x0009329C
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

		// Token: 0x04001B8D RID: 7053
		public float DistancePerStep = 0.75f;

		// Token: 0x04001B8E RID: 7054
		public Transform ReferencePoint;

		// Token: 0x04001B8F RID: 7055
		public LayerMask GroundDetectionMask;

		// Token: 0x04001B90 RID: 7056
		public UnityEvent<EMaterialType, float> onStep = new UnityEvent<EMaterialType, float>();

		// Token: 0x04001B91 RID: 7057
		private float currentDistance;

		// Token: 0x04001B92 RID: 7058
		private Vector3 lastFramePosition = Vector3.zero;
	}
}
