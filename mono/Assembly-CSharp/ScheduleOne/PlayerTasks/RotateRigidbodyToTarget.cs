using System;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200033F RID: 831
	public class RotateRigidbodyToTarget : MonoBehaviour
	{
		// Token: 0x060012A3 RID: 4771 RVA: 0x000518AC File Offset: 0x0004FAAC
		public void FixedUpdate()
		{
			this.CuntAssFuckingBitch.localRotation = Quaternion.Euler(this.TargetRotation);
			Quaternion rotation = this.CuntAssFuckingBitch.rotation;
			Quaternion quaternion = rotation * Quaternion.Inverse(base.transform.rotation);
			Vector3 a = Vector3.Normalize(new Vector3(quaternion.x, quaternion.y, quaternion.z)) * this.RotationForce;
			float d = Mathf.Clamp01(Quaternion.Angle(base.transform.rotation, rotation) / 90f);
			this.Rigidbody.AddTorque(a * d, 5);
		}

		// Token: 0x04001206 RID: 4614
		public Rigidbody Rigidbody;

		// Token: 0x04001207 RID: 4615
		public Vector3 TargetRotation;

		// Token: 0x04001208 RID: 4616
		public float RotationForce = 1f;

		// Token: 0x04001209 RID: 4617
		public Transform CuntAssFuckingBitch;
	}
}
