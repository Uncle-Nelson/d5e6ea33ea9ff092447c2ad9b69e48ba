using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200008A RID: 138
	public class SimpleAimingSystem : MonoBehaviour
	{
		// Token: 0x0600053A RID: 1338 RVA: 0x000232B4 File Offset: 0x000214B4
		private void Start()
		{
			this.aim.enabled = false;
			this.lookAt.enabled = false;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000232CE File Offset: 0x000214CE
		private void LateUpdate()
		{
			this.Pose();
			this.aim.solver.Update();
			if (this.lookAt != null)
			{
				this.lookAt.solver.Update();
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00023304 File Offset: 0x00021504
		private void Pose()
		{
			this.LimitAimTarget();
			Vector3 direction = this.aim.solver.IKPosition - this.aim.solver.bones[0].transform.position;
			Vector3 localDirection = base.transform.InverseTransformDirection(direction);
			this.aimPose = this.aimPoser.GetPose(localDirection);
			if (this.aimPose != this.lastPose)
			{
				this.aimPoser.SetPoseActive(this.aimPose);
				this.lastPose = this.aimPose;
			}
			foreach (AimPoser.Pose pose in this.aimPoser.poses)
			{
				if (pose == this.aimPose)
				{
					this.DirectCrossFade(pose.name, 1f);
				}
				else
				{
					this.DirectCrossFade(pose.name, 0f);
				}
			}
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000233E4 File Offset: 0x000215E4
		private void LimitAimTarget()
		{
			Vector3 position = this.aim.solver.bones[0].transform.position;
			Vector3 b = this.aim.solver.IKPosition - position;
			b = b.normalized * Mathf.Max(b.magnitude, this.minAimDistance);
			this.aim.solver.IKPosition = position + b;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0002345C File Offset: 0x0002165C
		private void DirectCrossFade(string state, float target)
		{
			float value = Mathf.MoveTowards(this.animator.GetFloat(state), target, Time.deltaTime * (1f / this.crossfadeTime));
			this.animator.SetFloat(state, value);
		}

		// Token: 0x04000402 RID: 1026
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		// Token: 0x04000403 RID: 1027
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		// Token: 0x04000404 RID: 1028
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		// Token: 0x04000405 RID: 1029
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		// Token: 0x04000406 RID: 1030
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime = 0.2f;

		// Token: 0x04000407 RID: 1031
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance = 0.5f;

		// Token: 0x04000408 RID: 1032
		private AimPoser.Pose aimPose;

		// Token: 0x04000409 RID: 1033
		private AimPoser.Pose lastPose;
	}
}
