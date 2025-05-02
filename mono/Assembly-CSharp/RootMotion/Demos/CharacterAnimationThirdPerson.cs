using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000C0 RID: 192
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		// Token: 0x06000615 RID: 1557 RVA: 0x00028EC3 File Offset: 0x000270C3
		protected override void Start()
		{
			base.Start();
			this.animator = base.GetComponent<Animator>();
			this.lastForward = base.transform.forward;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00028EE8 File Offset: 0x000270E8
		public override Vector3 GetPivotPoint()
		{
			return this.animator.pivotPosition;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00028EF8 File Offset: 0x000270F8
		public override bool animationGrounded
		{
			get
			{
				return this.animator.GetCurrentAnimatorStateInfo(0).IsName("Grounded Directional") || this.animator.GetCurrentAnimatorStateInfo(0).IsName("Grounded Strafe");
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00028F3C File Offset: 0x0002713C
		protected virtual void Update()
		{
			if (Time.deltaTime == 0f)
			{
				return;
			}
			this.animatePhysics = (this.animator.updateMode == AnimatorUpdateMode.AnimatePhysics);
			if (this.characterController.animState.jump && !this.lastJump)
			{
				float value = (float)((Mathf.Repeat(this.animator.GetCurrentAnimatorStateInfo(0).normalizedTime + this.runCycleLegOffset, 1f) < 0.5f) ? 1 : -1) * this.characterController.animState.moveDirection.z;
				this.animator.SetFloat("JumpLeg", value);
			}
			this.lastJump = this.characterController.animState.jump;
			float num = -base.GetAngleFromForward(this.lastForward) - this.deltaAngle;
			this.deltaAngle = 0f;
			this.lastForward = base.transform.forward;
			num *= this.turnSensitivity * 0.01f;
			num = Mathf.Clamp(num / Time.deltaTime, -1f, 1f);
			this.animator.SetFloat("Turn", Mathf.Lerp(this.animator.GetFloat("Turn"), num, Time.deltaTime * this.turnSpeed));
			this.animator.SetFloat("Forward", this.characterController.animState.moveDirection.z);
			this.animator.SetFloat("Right", this.characterController.animState.moveDirection.x);
			this.animator.SetBool("Crouch", this.characterController.animState.crouch);
			this.animator.SetBool("OnGround", this.characterController.animState.onGround);
			this.animator.SetBool("IsStrafing", this.characterController.animState.isStrafing);
			if (!this.characterController.animState.onGround)
			{
				this.animator.SetFloat("Jump", this.characterController.animState.yVelocity);
			}
			if (this.characterController.doubleJumpEnabled)
			{
				this.animator.SetBool("DoubleJump", this.characterController.animState.doubleJump);
			}
			this.characterController.animState.doubleJump = false;
			if (this.characterController.animState.onGround && this.characterController.animState.moveDirection.z > 0f)
			{
				this.animator.speed = this.animSpeedMultiplier;
				return;
			}
			this.animator.speed = 1f;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000291E8 File Offset: 0x000273E8
		private void OnAnimatorMove()
		{
			Vector3 vector = this.animator.deltaRotation * Vector3.forward;
			this.deltaAngle += Mathf.Atan2(vector.x, vector.z) * 57.29578f;
			if (this.characterController.fullRootMotion)
			{
				this.characterController.transform.position += this.animator.deltaPosition;
				this.characterController.transform.rotation *= this.animator.deltaRotation;
				return;
			}
			this.characterController.Move(this.animator.deltaPosition, this.animator.deltaRotation);
		}

		// Token: 0x0400055F RID: 1375
		public CharacterThirdPerson characterController;

		// Token: 0x04000560 RID: 1376
		[SerializeField]
		private float turnSensitivity = 0.2f;

		// Token: 0x04000561 RID: 1377
		[SerializeField]
		private float turnSpeed = 5f;

		// Token: 0x04000562 RID: 1378
		[SerializeField]
		private float runCycleLegOffset = 0.2f;

		// Token: 0x04000563 RID: 1379
		[Range(0.1f, 3f)]
		[SerializeField]
		private float animSpeedMultiplier = 1f;

		// Token: 0x04000564 RID: 1380
		protected Animator animator;

		// Token: 0x04000565 RID: 1381
		private Vector3 lastForward;

		// Token: 0x04000566 RID: 1382
		private const string groundedDirectional = "Grounded Directional";

		// Token: 0x04000567 RID: 1383
		private const string groundedStrafe = "Grounded Strafe";

		// Token: 0x04000568 RID: 1384
		private float deltaAngle;

		// Token: 0x04000569 RID: 1385
		private float jumpLeg;

		// Token: 0x0400056A RID: 1386
		private bool lastJump;
	}
}
