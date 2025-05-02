using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000B4 RID: 180
	public class PlatformRotator : MonoBehaviour
	{
		// Token: 0x060005EA RID: 1514 RVA: 0x000280A8 File Offset: 0x000262A8
		private void Start()
		{
			this.defaultRotation = base.transform.rotation;
			this.targetPosition = base.transform.position + this.movePosition;
			this.r = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.SwitchRotation());
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000280FC File Offset: 0x000262FC
		private void FixedUpdate()
		{
			this.r.MovePosition(Vector3.SmoothDamp(this.r.position, this.targetPosition, ref this.velocity, 1f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.targetPosition) < 0.1f)
			{
				this.movePosition = -this.movePosition;
				this.targetPosition += this.movePosition;
			}
			this.r.MoveRotation(Quaternion.RotateTowards(this.r.rotation, this.targetRotation, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000281AD File Offset: 0x000263AD
		private IEnumerator SwitchRotation()
		{
			for (;;)
			{
				float angle = Random.Range(-this.maxAngle, this.maxAngle);
				Vector3 onUnitSphere = Random.onUnitSphere;
				this.targetRotation = Quaternion.AngleAxis(angle, onUnitSphere) * this.defaultRotation;
				yield return new WaitForSeconds(this.switchRotationTime + Random.value * this.random);
			}
			yield break;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000281BC File Offset: 0x000263BC
		private void OnCollisionEnter(Collision collision)
		{
			if (collision.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = collision.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = false;
				}
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00028204 File Offset: 0x00026404
		private void OnCollisionExit(Collision collision)
		{
			if (collision.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = collision.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = true;
			}
		}

		// Token: 0x04000518 RID: 1304
		public float maxAngle = 70f;

		// Token: 0x04000519 RID: 1305
		public float switchRotationTime = 0.5f;

		// Token: 0x0400051A RID: 1306
		public float random = 0.5f;

		// Token: 0x0400051B RID: 1307
		public float rotationSpeed = 50f;

		// Token: 0x0400051C RID: 1308
		public Vector3 movePosition;

		// Token: 0x0400051D RID: 1309
		public float moveSpeed = 5f;

		// Token: 0x0400051E RID: 1310
		public int characterLayer;

		// Token: 0x0400051F RID: 1311
		private Quaternion defaultRotation;

		// Token: 0x04000520 RID: 1312
		private Quaternion targetRotation;

		// Token: 0x04000521 RID: 1313
		private Vector3 targetPosition;

		// Token: 0x04000522 RID: 1314
		private Vector3 velocity;

		// Token: 0x04000523 RID: 1315
		private Rigidbody r;
	}
}
