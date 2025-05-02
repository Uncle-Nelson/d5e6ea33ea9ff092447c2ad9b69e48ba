using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200008E RID: 142
	public class MechSpiderController : MonoBehaviour
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00023DF5 File Offset: 0x00021FF5
		public Vector3 inputVector
		{
			get
			{
				return new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00023E18 File Offset: 0x00022018
		private void Update()
		{
			Vector3 forward = this.cameraTransform.forward;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref forward);
			Quaternion quaternion = Quaternion.LookRotation(forward, base.transform.up);
			base.transform.Translate(quaternion * this.inputVector.normalized * Time.deltaTime * this.speed * this.mechSpider.scale, Space.World);
			base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, quaternion, Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x04000437 RID: 1079
		public MechSpider mechSpider;

		// Token: 0x04000438 RID: 1080
		public Transform cameraTransform;

		// Token: 0x04000439 RID: 1081
		public float speed = 6f;

		// Token: 0x0400043A RID: 1082
		public float turnSpeed = 30f;
	}
}
