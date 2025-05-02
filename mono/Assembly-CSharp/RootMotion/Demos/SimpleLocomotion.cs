using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000C3 RID: 195
	public class SimpleLocomotion : MonoBehaviour
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x0002A6D9 File Offset: 0x000288D9
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x0002A6E1 File Offset: 0x000288E1
		public bool isGrounded { get; private set; }

		// Token: 0x0600063C RID: 1596 RVA: 0x0002A6EA File Offset: 0x000288EA
		private void Start()
		{
			this.animator = base.GetComponent<Animator>();
			this.characterController = base.GetComponent<CharacterController>();
			this.cameraController.enabled = false;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0002A710 File Offset: 0x00028910
		private void Update()
		{
			this.isGrounded = (base.transform.position.y < 0.1f);
			this.Rotate();
			this.Move();
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0002A73B File Offset: 0x0002893B
		private void LateUpdate()
		{
			this.cameraController.UpdateInput();
			this.cameraController.UpdateTransform();
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0002A754 File Offset: 0x00028954
		private void Rotate()
		{
			if (!this.isGrounded)
			{
				return;
			}
			Vector3 inputVector = this.GetInputVector();
			if (inputVector == Vector3.zero)
			{
				return;
			}
			Vector3 vector = base.transform.forward;
			SimpleLocomotion.RotationMode rotationMode = this.rotationMode;
			if (rotationMode == SimpleLocomotion.RotationMode.Smooth)
			{
				Vector3 vector2 = this.cameraController.transform.rotation * inputVector;
				float current = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
				float target = Mathf.Atan2(vector2.x, vector2.z) * 57.29578f;
				float angle = Mathf.SmoothDampAngle(current, target, ref this.angleVel, this.turnTime);
				base.transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
				return;
			}
			if (rotationMode != SimpleLocomotion.RotationMode.Linear)
			{
				return;
			}
			Vector3 inputVectorRaw = this.GetInputVectorRaw();
			if (inputVectorRaw != Vector3.zero)
			{
				this.linearTargetDirection = this.cameraController.transform.rotation * inputVectorRaw;
			}
			vector = Vector3.RotateTowards(vector, this.linearTargetDirection, Time.deltaTime * (1f / this.turnTime), 1f);
			vector.y = 0f;
			base.transform.rotation = Quaternion.LookRotation(vector);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0002A884 File Offset: 0x00028A84
		private void Move()
		{
			float target = this.walkByDefault ? (Input.GetKey(KeyCode.LeftShift) ? 1f : 0.5f) : (Input.GetKey(KeyCode.LeftShift) ? 0.5f : 1f);
			this.speed = Mathf.SmoothDamp(this.speed, target, ref this.speedVel, this.accelerationTime);
			float num = this.GetInputVector().magnitude * this.speed;
			this.animator.SetFloat("Speed", num);
			if (!this.animator.hasRootMotion && this.isGrounded)
			{
				Vector3 a = base.transform.forward * num * this.moveSpeed;
				if (this.characterController != null)
				{
					this.characterController.SimpleMove(a);
					return;
				}
				base.transform.position += a * Time.deltaTime;
			}
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0002A984 File Offset: 0x00028B84
		private Vector3 GetInputVector()
		{
			Vector3 vector = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
			vector.z += Mathf.Abs(vector.x) * 0.05f;
			vector.x -= Mathf.Abs(vector.z) * 0.05f;
			return vector;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0002A9EA File Offset: 0x00028BEA
		private Vector3 GetInputVectorRaw()
		{
			return new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
		}

		// Token: 0x040005B3 RID: 1459
		[Tooltip("The component that updates the camera.")]
		public CameraController cameraController;

		// Token: 0x040005B4 RID: 1460
		[Tooltip("Acceleration of movement.")]
		public float accelerationTime = 0.2f;

		// Token: 0x040005B5 RID: 1461
		[Tooltip("Turning speed.")]
		public float turnTime = 0.2f;

		// Token: 0x040005B6 RID: 1462
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		public bool walkByDefault = true;

		// Token: 0x040005B7 RID: 1463
		[Tooltip("Smooth or linear rotation.")]
		public SimpleLocomotion.RotationMode rotationMode;

		// Token: 0x040005B8 RID: 1464
		[Tooltip("Procedural motion speed (if not using root motion).")]
		public float moveSpeed = 3f;

		// Token: 0x040005BA RID: 1466
		private Animator animator;

		// Token: 0x040005BB RID: 1467
		private float speed;

		// Token: 0x040005BC RID: 1468
		private float angleVel;

		// Token: 0x040005BD RID: 1469
		private float speedVel;

		// Token: 0x040005BE RID: 1470
		private Vector3 linearTargetDirection;

		// Token: 0x040005BF RID: 1471
		private CharacterController characterController;

		// Token: 0x0200012D RID: 301
		[Serializable]
		public enum RotationMode
		{
			// Token: 0x04000898 RID: 2200
			Smooth,
			// Token: 0x04000899 RID: 2201
			Linear
		}
	}
}
