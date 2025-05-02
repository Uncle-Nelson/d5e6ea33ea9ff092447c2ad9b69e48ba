using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000C2 RID: 194
	public class CharacterThirdPerson : CharacterBase
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00029665 File Offset: 0x00027865
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x0002966D File Offset: 0x0002786D
		public bool fullRootMotion { get; set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00029676 File Offset: 0x00027876
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x0002967E File Offset: 0x0002787E
		public bool onGround { get; private set; }

		// Token: 0x0600062A RID: 1578 RVA: 0x00029688 File Offset: 0x00027888
		protected override void Start()
		{
			base.Start();
			this.animator = base.GetComponent<Animator>();
			if (this.animator == null)
			{
				this.animator = this.characterAnimation.GetComponent<Animator>();
			}
			this.wallNormal = -this.gravity.normalized;
			this.onGround = true;
			this.animState.onGround = true;
			if (this.cam != null)
			{
				this.cam.enabled = false;
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00029709 File Offset: 0x00027909
		private void OnAnimatorMove()
		{
			this.Move(this.animator.deltaPosition, this.animator.deltaRotation);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00029727 File Offset: 0x00027927
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
			this.fixedDeltaTime += Time.deltaTime;
			this.fixedDeltaPosition += deltaPosition;
			this.fixedDeltaRotation *= deltaRotation;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00029760 File Offset: 0x00027960
		private void FixedUpdate()
		{
			this.gravity = (this.fullRootMotion ? Vector3.zero : base.GetGravity());
			this.verticalVelocity = V3Tools.ExtractVertical(this.r.velocity, this.gravity, 1f);
			this.velocityY = this.verticalVelocity.magnitude;
			if (Vector3.Dot(this.verticalVelocity, this.gravity) > 0f)
			{
				this.velocityY = -this.velocityY;
			}
			this.r.interpolation = (this.smoothPhysics ? RigidbodyInterpolation.Interpolate : RigidbodyInterpolation.None);
			this.characterAnimation.smoothFollow = this.smoothPhysics;
			this.MoveFixed(this.fixedDeltaPosition);
			this.fixedDeltaTime = 0f;
			this.fixedDeltaPosition = Vector3.zero;
			this.r.MoveRotation(base.transform.rotation * this.fixedDeltaRotation);
			this.fixedDeltaRotation = Quaternion.identity;
			this.Rotate();
			this.GroundCheck();
			if (this.userControl.state.move == Vector3.zero && this.groundDistance < this.airborneThreshold * 0.5f)
			{
				base.HighFriction();
			}
			else
			{
				base.ZeroFriction();
			}
			bool flag = !this.fullRootMotion && this.onGround && this.userControl.state.move == Vector3.zero && this.r.velocity.magnitude < 0.5f && this.groundDistance < this.airborneThreshold * 0.5f;
			if (this.gravityTarget != null)
			{
				this.r.useGravity = false;
				if (!flag)
				{
					this.r.AddForce(this.gravity);
				}
			}
			if (flag)
			{
				this.r.useGravity = false;
				this.r.velocity = Vector3.zero;
			}
			else if (this.gravityTarget == null)
			{
				this.r.useGravity = true;
			}
			if (this.onGround)
			{
				this.animState.jump = this.Jump();
				this.jumpReleased = false;
				this.doubleJumped = false;
			}
			else
			{
				if (!this.userControl.state.jump)
				{
					this.jumpReleased = true;
				}
				if (this.jumpReleased && this.userControl.state.jump && !this.doubleJumped && this.doubleJumpEnabled)
				{
					this.jumpEndTime = Time.time + 0.1f;
					this.animState.doubleJump = true;
					Vector3 velocity = this.userControl.state.move * this.airSpeed;
					this.r.velocity = velocity;
					this.r.velocity += base.transform.up * this.jumpPower * this.doubleJumpPowerMlp;
					this.doubleJumped = true;
				}
			}
			base.ScaleCapsule(this.userControl.state.crouch ? this.crouchCapsuleScaleMlp : 1f);
			this.fixedFrame = true;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00029A90 File Offset: 0x00027C90
		protected virtual void Update()
		{
			this.animState.onGround = this.onGround;
			this.animState.moveDirection = this.GetMoveDirection();
			this.animState.yVelocity = Mathf.Lerp(this.animState.yVelocity, this.velocityY, Time.deltaTime * 10f);
			this.animState.crouch = this.userControl.state.crouch;
			this.animState.isStrafing = (this.moveMode == CharacterThirdPerson.MoveMode.Strafe);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00029B1C File Offset: 0x00027D1C
		protected virtual void LateUpdate()
		{
			if (this.cam == null)
			{
				return;
			}
			this.cam.UpdateInput();
			if (!this.fixedFrame && this.r.interpolation == RigidbodyInterpolation.None)
			{
				return;
			}
			this.cam.UpdateTransform((this.r.interpolation == RigidbodyInterpolation.None) ? Time.fixedDeltaTime : Time.deltaTime);
			this.fixedFrame = false;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00029B84 File Offset: 0x00027D84
		private void MoveFixed(Vector3 deltaPosition)
		{
			this.WallRun();
			Vector3 vector = (this.fixedDeltaTime > 0f) ? (deltaPosition / this.fixedDeltaTime) : Vector3.zero;
			if (!this.fullRootMotion)
			{
				vector += V3Tools.ExtractHorizontal(this.platformVelocity, this.gravity, 1f);
				if (this.onGround)
				{
					if (this.velocityToGroundTangentWeight > 0f)
					{
						Quaternion b = Quaternion.FromToRotation(base.transform.up, this.normal);
						vector = Quaternion.Lerp(Quaternion.identity, b, this.velocityToGroundTangentWeight) * vector;
					}
				}
				else
				{
					Vector3 b2 = V3Tools.ExtractHorizontal(this.userControl.state.move * this.airSpeed, this.gravity, 1f);
					vector = Vector3.Lerp(this.r.velocity, b2, Time.deltaTime * this.airControl);
				}
				if (this.onGround && Time.time > this.jumpEndTime)
				{
					this.r.velocity = this.r.velocity - base.transform.up * this.stickyForce * Time.deltaTime;
				}
				Vector3 vector2 = V3Tools.ExtractVertical(this.r.velocity, this.gravity, 1f);
				Vector3 a = V3Tools.ExtractHorizontal(vector, this.gravity, 1f);
				if (this.onGround && Vector3.Dot(vector2, this.gravity) < 0f)
				{
					vector2 = Vector3.ClampMagnitude(vector2, this.maxVerticalVelocityOnGround);
				}
				this.r.velocity = a + vector2;
			}
			else
			{
				this.r.velocity = vector;
			}
			this.forwardMlp = 1f;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00029D44 File Offset: 0x00027F44
		private void WallRun()
		{
			bool flag = this.CanWallRun();
			if (this.wallRunWeight > 0f && !flag)
			{
				this.wallRunEndTime = Time.time;
			}
			if (Time.time < this.wallRunEndTime + 0.5f)
			{
				flag = false;
			}
			this.wallRunWeight = Mathf.MoveTowards(this.wallRunWeight, flag ? 1f : 0f, Time.deltaTime * this.wallRunWeightSpeed);
			if (this.wallRunWeight <= 0f && this.lastWallRunWeight > 0f)
			{
				Vector3 forward = V3Tools.ExtractHorizontal(base.transform.forward, this.gravity, 1f);
				base.transform.rotation = Quaternion.LookRotation(forward, -this.gravity);
				this.wallNormal = -this.gravity.normalized;
			}
			this.lastWallRunWeight = this.wallRunWeight;
			if (this.wallRunWeight <= 0f)
			{
				return;
			}
			if (this.onGround && this.velocityY < 0f)
			{
				this.r.velocity = V3Tools.ExtractHorizontal(this.r.velocity, this.gravity, 1f);
			}
			Vector3 vector = V3Tools.ExtractHorizontal(base.transform.forward, this.gravity, 1f);
			RaycastHit raycastHit = default(RaycastHit);
			raycastHit.normal = -this.gravity.normalized;
			Physics.Raycast(this.onGround ? base.transform.position : this.capsule.bounds.center, vector, out raycastHit, 3f, this.wallRunLayers);
			this.wallNormal = Vector3.Lerp(this.wallNormal, raycastHit.normal, Time.deltaTime * this.wallRunRotationSpeed);
			this.wallNormal = Vector3.RotateTowards(-this.gravity.normalized, this.wallNormal, this.wallRunMaxRotationAngle * 0.017453292f, 0f);
			Vector3 forward2 = base.transform.forward;
			Vector3 vector2 = this.wallNormal;
			Vector3.OrthoNormalize(ref vector2, ref forward2);
			base.transform.rotation = Quaternion.Slerp(Quaternion.LookRotation(vector, -this.gravity), Quaternion.LookRotation(forward2, this.wallNormal), this.wallRunWeight);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00029F98 File Offset: 0x00028198
		private bool CanWallRun()
		{
			return !this.fullRootMotion && Time.time >= this.jumpEndTime - 0.1f && Time.time <= this.jumpEndTime - 0.1f + this.wallRunMaxLength && this.velocityY >= this.wallRunMinVelocityY && this.userControl.state.move.magnitude >= this.wallRunMinMoveMag;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0002A010 File Offset: 0x00028210
		private Vector3 GetMoveDirection()
		{
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode == CharacterThirdPerson.MoveMode.Directional)
			{
				this.moveDirection = Vector3.SmoothDamp(this.moveDirection, new Vector3(0f, 0f, this.userControl.state.move.magnitude), ref this.moveDirectionVelocity, this.smoothAccelerationTime);
				this.moveDirection = Vector3.MoveTowards(this.moveDirection, new Vector3(0f, 0f, this.userControl.state.move.magnitude), Time.deltaTime * this.linearAccelerationSpeed);
				return this.moveDirection * this.forwardMlp;
			}
			if (moveMode != CharacterThirdPerson.MoveMode.Strafe)
			{
				return Vector3.zero;
			}
			this.moveDirection = Vector3.SmoothDamp(this.moveDirection, this.userControl.state.move, ref this.moveDirectionVelocity, this.smoothAccelerationTime);
			this.moveDirection = Vector3.MoveTowards(this.moveDirection, this.userControl.state.move, Time.deltaTime * this.linearAccelerationSpeed);
			return base.transform.InverseTransformDirection(this.moveDirection);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0002A138 File Offset: 0x00028338
		protected virtual void Rotate()
		{
			if (this.gravityTarget != null)
			{
				this.r.MoveRotation(Quaternion.FromToRotation(base.transform.up, base.transform.position - this.gravityTarget.position) * base.transform.rotation);
			}
			if (this.platformAngularVelocity != Vector3.zero)
			{
				this.r.MoveRotation(Quaternion.Euler(this.platformAngularVelocity) * base.transform.rotation);
			}
			float num = base.GetAngleFromForward(this.GetForwardDirection());
			if (this.userControl.state.move == Vector3.zero)
			{
				num *= (1.01f - Mathf.Abs(num) / 180f) * this.stationaryTurnSpeedMlp;
			}
			this.r.MoveRotation(Quaternion.AngleAxis(num * Time.deltaTime * this.turnSpeed, base.transform.up) * this.r.rotation);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0002A250 File Offset: 0x00028450
		private Vector3 GetForwardDirection()
		{
			bool flag = this.userControl.state.move != Vector3.zero;
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode != CharacterThirdPerson.MoveMode.Directional)
			{
				if (moveMode != CharacterThirdPerson.MoveMode.Strafe)
				{
					return Vector3.zero;
				}
				if (flag)
				{
					return this.userControl.state.lookPos - this.r.position;
				}
				if (!this.lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return this.userControl.state.lookPos - this.r.position;
			}
			else
			{
				if (flag)
				{
					return this.userControl.state.move;
				}
				if (!this.lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return this.userControl.state.lookPos - this.r.position;
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0002A334 File Offset: 0x00028534
		protected virtual bool Jump()
		{
			if (!this.userControl.state.jump)
			{
				return false;
			}
			if (this.userControl.state.crouch)
			{
				return false;
			}
			if (!this.characterAnimation.animationGrounded)
			{
				return false;
			}
			if (Time.time < this.lastAirTime + this.jumpRepeatDelayTime)
			{
				return false;
			}
			this.onGround = false;
			this.jumpEndTime = Time.time + 0.1f;
			Vector3 vector = this.userControl.state.move * this.airSpeed;
			vector += base.transform.up * this.jumpPower;
			if (this.smoothJump)
			{
				base.StopAllCoroutines();
				base.StartCoroutine(this.JumpSmooth(vector - this.r.velocity));
			}
			else
			{
				this.r.velocity = vector;
			}
			return true;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0002A41A File Offset: 0x0002861A
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			int steps = 0;
			int stepsToTake = 3;
			while (steps < stepsToTake)
			{
				this.r.AddForce(jumpVelocity / (float)stepsToTake, ForceMode.VelocityChange);
				int num = steps;
				steps = num + 1;
				yield return new WaitForFixedUpdate();
			}
			yield break;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0002A430 File Offset: 0x00028630
		private void GroundCheck()
		{
			Vector3 b = Vector3.zero;
			this.platformAngularVelocity = Vector3.zero;
			float num = 0f;
			this.hit = this.GetSpherecastHit();
			this.normal = base.transform.up;
			this.groundDistance = Vector3.Project(this.r.position - this.hit.point, base.transform.up).magnitude;
			if (Time.time > this.jumpEndTime && this.velocityY < this.jumpPower * 0.5f)
			{
				bool onGround = this.onGround;
				this.onGround = false;
				float num2 = (!onGround) ? (this.airborneThreshold * 0.5f) : this.airborneThreshold;
				float magnitude = V3Tools.ExtractHorizontal(this.r.velocity, this.gravity, 1f).magnitude;
				if (this.groundDistance < num2)
				{
					num = this.groundStickyEffect * magnitude * num2;
					if (this.hit.rigidbody != null)
					{
						b = this.hit.rigidbody.GetPointVelocity(this.hit.point);
						this.platformAngularVelocity = Vector3.Project(this.hit.rigidbody.angularVelocity, base.transform.up);
					}
					this.onGround = true;
				}
			}
			this.platformVelocity = Vector3.Lerp(this.platformVelocity, b, Time.deltaTime * this.platformFriction);
			if (this.fullRootMotion)
			{
				this.stickyForce = 0f;
			}
			this.stickyForce = num;
			if (!this.onGround)
			{
				this.lastAirTime = Time.time;
			}
		}

		// Token: 0x04000579 RID: 1401
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		// Token: 0x0400057A RID: 1402
		public UserControlThirdPerson userControl;

		// Token: 0x0400057B RID: 1403
		public CameraController cam;

		// Token: 0x0400057C RID: 1404
		[Header("Movement")]
		public CharacterThirdPerson.MoveMode moveMode;

		// Token: 0x0400057D RID: 1405
		public bool smoothPhysics = true;

		// Token: 0x0400057E RID: 1406
		public float smoothAccelerationTime = 0.2f;

		// Token: 0x0400057F RID: 1407
		public float linearAccelerationSpeed = 3f;

		// Token: 0x04000580 RID: 1408
		public float platformFriction = 7f;

		// Token: 0x04000581 RID: 1409
		public float groundStickyEffect = 4f;

		// Token: 0x04000582 RID: 1410
		public float maxVerticalVelocityOnGround = 3f;

		// Token: 0x04000583 RID: 1411
		public float velocityToGroundTangentWeight;

		// Token: 0x04000584 RID: 1412
		[Header("Rotation")]
		public bool lookInCameraDirection;

		// Token: 0x04000585 RID: 1413
		public float turnSpeed = 5f;

		// Token: 0x04000586 RID: 1414
		public float stationaryTurnSpeedMlp = 1f;

		// Token: 0x04000587 RID: 1415
		[Header("Jumping and Falling")]
		public bool smoothJump = true;

		// Token: 0x04000588 RID: 1416
		public float airSpeed = 6f;

		// Token: 0x04000589 RID: 1417
		public float airControl = 2f;

		// Token: 0x0400058A RID: 1418
		public float jumpPower = 12f;

		// Token: 0x0400058B RID: 1419
		public float jumpRepeatDelayTime;

		// Token: 0x0400058C RID: 1420
		public bool doubleJumpEnabled;

		// Token: 0x0400058D RID: 1421
		public float doubleJumpPowerMlp = 1f;

		// Token: 0x0400058E RID: 1422
		[Header("Wall Running")]
		public LayerMask wallRunLayers;

		// Token: 0x0400058F RID: 1423
		public float wallRunMaxLength = 1f;

		// Token: 0x04000590 RID: 1424
		public float wallRunMinMoveMag = 0.6f;

		// Token: 0x04000591 RID: 1425
		public float wallRunMinVelocityY = -1f;

		// Token: 0x04000592 RID: 1426
		public float wallRunRotationSpeed = 1.5f;

		// Token: 0x04000593 RID: 1427
		public float wallRunMaxRotationAngle = 70f;

		// Token: 0x04000594 RID: 1428
		public float wallRunWeightSpeed = 5f;

		// Token: 0x04000595 RID: 1429
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp = 0.6f;

		// Token: 0x04000598 RID: 1432
		public CharacterThirdPerson.AnimState animState;

		// Token: 0x04000599 RID: 1433
		protected Vector3 moveDirection;

		// Token: 0x0400059A RID: 1434
		private Animator animator;

		// Token: 0x0400059B RID: 1435
		private Vector3 normal;

		// Token: 0x0400059C RID: 1436
		private Vector3 platformVelocity;

		// Token: 0x0400059D RID: 1437
		private Vector3 platformAngularVelocity;

		// Token: 0x0400059E RID: 1438
		private RaycastHit hit;

		// Token: 0x0400059F RID: 1439
		private float jumpLeg;

		// Token: 0x040005A0 RID: 1440
		private float jumpEndTime;

		// Token: 0x040005A1 RID: 1441
		private float forwardMlp;

		// Token: 0x040005A2 RID: 1442
		private float groundDistance;

		// Token: 0x040005A3 RID: 1443
		private float lastAirTime;

		// Token: 0x040005A4 RID: 1444
		private float stickyForce;

		// Token: 0x040005A5 RID: 1445
		private Vector3 wallNormal = Vector3.up;

		// Token: 0x040005A6 RID: 1446
		private Vector3 moveDirectionVelocity;

		// Token: 0x040005A7 RID: 1447
		private float wallRunWeight;

		// Token: 0x040005A8 RID: 1448
		private float lastWallRunWeight;

		// Token: 0x040005A9 RID: 1449
		private float fixedDeltaTime;

		// Token: 0x040005AA RID: 1450
		private Vector3 fixedDeltaPosition;

		// Token: 0x040005AB RID: 1451
		private Quaternion fixedDeltaRotation = Quaternion.identity;

		// Token: 0x040005AC RID: 1452
		private bool fixedFrame;

		// Token: 0x040005AD RID: 1453
		private float wallRunEndTime;

		// Token: 0x040005AE RID: 1454
		private Vector3 gravity;

		// Token: 0x040005AF RID: 1455
		private Vector3 verticalVelocity;

		// Token: 0x040005B0 RID: 1456
		private float velocityY;

		// Token: 0x040005B1 RID: 1457
		private bool doubleJumped;

		// Token: 0x040005B2 RID: 1458
		private bool jumpReleased;

		// Token: 0x0200012A RID: 298
		[Serializable]
		public enum MoveMode
		{
			// Token: 0x04000888 RID: 2184
			Directional,
			// Token: 0x04000889 RID: 2185
			Strafe
		}

		// Token: 0x0200012B RID: 299
		public struct AnimState
		{
			// Token: 0x0400088A RID: 2186
			public Vector3 moveDirection;

			// Token: 0x0400088B RID: 2187
			public bool jump;

			// Token: 0x0400088C RID: 2188
			public bool crouch;

			// Token: 0x0400088D RID: 2189
			public bool onGround;

			// Token: 0x0400088E RID: 2190
			public bool isStrafing;

			// Token: 0x0400088F RID: 2191
			public float yVelocity;

			// Token: 0x04000890 RID: 2192
			public bool doubleJump;
		}
	}
}
