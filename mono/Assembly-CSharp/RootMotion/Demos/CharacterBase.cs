using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000C1 RID: 193
	public abstract class CharacterBase : MonoBehaviour
	{
		// Token: 0x0600061B RID: 1563
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		// Token: 0x0600061C RID: 1564 RVA: 0x000292E0 File Offset: 0x000274E0
		protected Vector3 GetGravity()
		{
			if (this.gravityTarget != null)
			{
				return (this.gravityTarget.position - base.transform.position).normalized * Physics.gravity.magnitude;
			}
			return Physics.gravity;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00029338 File Offset: 0x00027538
		protected virtual void Start()
		{
			this.capsule = (base.GetComponent<Collider>() as CapsuleCollider);
			this.r = base.GetComponent<Rigidbody>();
			this.originalHeight = this.capsule.height;
			this.originalCenter = this.capsule.center;
			this.zeroFrictionMaterial = new PhysicMaterial();
			this.zeroFrictionMaterial.dynamicFriction = 0f;
			this.zeroFrictionMaterial.staticFriction = 0f;
			this.zeroFrictionMaterial.frictionCombine = PhysicMaterialCombine.Minimum;
			this.zeroFrictionMaterial.bounciness = 0f;
			this.zeroFrictionMaterial.bounceCombine = PhysicMaterialCombine.Minimum;
			this.highFrictionMaterial = new PhysicMaterial();
			this.r.constraints = RigidbodyConstraints.FreezeRotation;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000293F0 File Offset: 0x000275F0
		protected virtual RaycastHit GetSpherecastHit()
		{
			Vector3 up = base.transform.up;
			Ray ray = new Ray(this.r.position + up * this.airborneThreshold, -up);
			RaycastHit result = default(RaycastHit);
			result.point = base.transform.position - base.transform.transform.up * this.airborneThreshold;
			result.normal = base.transform.up;
			Physics.SphereCast(ray, this.spherecastRadius, out result, this.airborneThreshold * 2f, this.groundLayers);
			return result;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000294A4 File Offset: 0x000276A4
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			Vector3 vector = base.transform.InverseTransformDirection(worldDirection);
			return Mathf.Atan2(vector.x, vector.z) * 57.29578f;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x000294D8 File Offset: 0x000276D8
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
			Quaternion quaternion = Quaternion.AngleAxis(angle, axis);
			Vector3 point2 = base.transform.position - point;
			this.r.MovePosition(point + quaternion * point2);
			this.r.MoveRotation(quaternion * base.transform.rotation);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00029534 File Offset: 0x00027734
		protected void ScaleCapsule(float mlp)
		{
			if (this.capsule.height != this.originalHeight * mlp)
			{
				this.capsule.height = Mathf.MoveTowards(this.capsule.height, this.originalHeight * mlp, Time.deltaTime * 4f);
				this.capsule.center = Vector3.MoveTowards(this.capsule.center, this.originalCenter * mlp, Time.deltaTime * 2f);
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x000295B6 File Offset: 0x000277B6
		protected void HighFriction()
		{
			this.capsule.material = this.highFrictionMaterial;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000295C9 File Offset: 0x000277C9
		protected void ZeroFriction()
		{
			this.capsule.material = this.zeroFrictionMaterial;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x000295DC File Offset: 0x000277DC
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			float num = 90f - Vector3.Angle(velocity, groundNormal);
			num -= this.slopeStartAngle;
			float num2 = this.slopeEndAngle - this.slopeStartAngle;
			return 1f - Mathf.Clamp(num / num2, 0f, 1f);
		}

		// Token: 0x0400056B RID: 1387
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		// Token: 0x0400056C RID: 1388
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		public float gravityMultiplier = 2f;

		// Token: 0x0400056D RID: 1389
		public float airborneThreshold = 0.6f;

		// Token: 0x0400056E RID: 1390
		public float slopeStartAngle = 50f;

		// Token: 0x0400056F RID: 1391
		public float slopeEndAngle = 85f;

		// Token: 0x04000570 RID: 1392
		public float spherecastRadius = 0.1f;

		// Token: 0x04000571 RID: 1393
		public LayerMask groundLayers;

		// Token: 0x04000572 RID: 1394
		private PhysicMaterial zeroFrictionMaterial;

		// Token: 0x04000573 RID: 1395
		private PhysicMaterial highFrictionMaterial;

		// Token: 0x04000574 RID: 1396
		protected Rigidbody r;

		// Token: 0x04000575 RID: 1397
		protected const float half = 0.5f;

		// Token: 0x04000576 RID: 1398
		protected float originalHeight;

		// Token: 0x04000577 RID: 1399
		protected Vector3 originalCenter;

		// Token: 0x04000578 RID: 1400
		protected CapsuleCollider capsule;
	}
}
