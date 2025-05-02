using System;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BDC RID: 3036
	public class LabOvenHammer : MonoBehaviour
	{
		// Token: 0x060053FA RID: 21498 RVA: 0x00161FAD File Offset: 0x001601AD
		private void Start()
		{
			this.Draggable.Rb.centerOfMass = this.CoM.localPosition;
		}

		// Token: 0x060053FB RID: 21499 RVA: 0x00161FCC File Offset: 0x001601CC
		private void Update()
		{
			this.Rotator.enabled = this.Draggable.IsHeld;
			if (this.Draggable.IsHeld)
			{
				this.Rotator.TargetRotation.z = Mathf.Lerp(this.MinAngle, this.MaxAngle, Mathf.Clamp01(Mathf.InverseLerp(this.MinHeight, this.MaxHeight, base.transform.localPosition.y)));
			}
		}

		// Token: 0x060053FC RID: 21500 RVA: 0x00162043 File Offset: 0x00160243
		private void OnCollisionEnter(Collision collision)
		{
			if (this.onCollision != null)
			{
				this.onCollision.Invoke(collision);
			}
		}

		// Token: 0x04003E91 RID: 16017
		public Draggable Draggable;

		// Token: 0x04003E92 RID: 16018
		public DraggableConstraint Constraint;

		// Token: 0x04003E93 RID: 16019
		public RotateRigidbodyToTarget Rotator;

		// Token: 0x04003E94 RID: 16020
		public Transform CoM;

		// Token: 0x04003E95 RID: 16021
		public Transform ImpactPoint;

		// Token: 0x04003E96 RID: 16022
		public SmoothedVelocityCalculator VelocityCalculator;

		// Token: 0x04003E97 RID: 16023
		[Header("Settings")]
		public float MinHeight;

		// Token: 0x04003E98 RID: 16024
		public float MaxHeight = 0.3f;

		// Token: 0x04003E99 RID: 16025
		public float MinAngle = 100f;

		// Token: 0x04003E9A RID: 16026
		public float MaxAngle = 40f;

		// Token: 0x04003E9B RID: 16027
		public UnityEvent<Collision> onCollision;
	}
}
