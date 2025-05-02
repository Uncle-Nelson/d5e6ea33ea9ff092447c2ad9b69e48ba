using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000092 RID: 146
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		// Token: 0x06000562 RID: 1378 RVA: 0x00024864 File Offset: 0x00022A64
		protected virtual void Start()
		{
			this.animator = base.GetComponent<Animator>();
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00024874 File Offset: 0x00022A74
		private void OnAnimatorMove()
		{
			this.velocity = Vector3.Lerp(this.velocity, base.transform.rotation * Vector3.ClampMagnitude(this.moveInput, 1f) * this.moveSpeed, Time.deltaTime * this.blendSpeed);
			base.transform.position += Vector3.Lerp(this.velocity * Time.deltaTime, this.animator.deltaPosition, this.rootMotionWeight);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00024908 File Offset: 0x00022B08
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
			this.moveInput = moveInput;
			Vector3 vector = base.transform.InverseTransformDirection(faceDirection);
			float num = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
			float num2 = num * Time.deltaTime * this.rotateSpeed;
			if (num > this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num - this.maxAngle, num2);
			}
			if (num < -this.maxAngle)
			{
				num2 = Mathf.Clamp(num2, num2, num + this.maxAngle);
			}
			base.transform.Rotate(Vector3.up, num2);
			this.moveBlend = Vector3.Lerp(this.moveBlend, moveInput, Time.deltaTime * this.blendSpeed);
			this.animator.SetFloat("X", this.moveBlend.x);
			this.animator.SetFloat("Z", this.moveBlend.z);
			this.animator.SetBool("IsMoving", isMoving);
		}

		// Token: 0x04000457 RID: 1111
		public float rotateSpeed = 7f;

		// Token: 0x04000458 RID: 1112
		public float blendSpeed = 10f;

		// Token: 0x04000459 RID: 1113
		public float maxAngle = 90f;

		// Token: 0x0400045A RID: 1114
		public float moveSpeed = 1.5f;

		// Token: 0x0400045B RID: 1115
		public float rootMotionWeight;

		// Token: 0x0400045C RID: 1116
		protected Animator animator;

		// Token: 0x0400045D RID: 1117
		protected Vector3 moveBlend;

		// Token: 0x0400045E RID: 1118
		protected Vector3 moveInput;

		// Token: 0x0400045F RID: 1119
		protected Vector3 velocity;
	}
}
