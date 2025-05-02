using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000A9 RID: 169
	public class PickUpBox : PickUp2Handed
	{
		// Token: 0x060005C6 RID: 1478 RVA: 0x00027784 File Offset: 0x00025984
		protected override void RotatePivot()
		{
			Vector3 normalized = (this.pivot.position - this.interactionSystem.transform.position).normalized;
			normalized.y = 0f;
			Vector3 axis = QuaTools.GetAxis(this.obj.transform.InverseTransformDirection(normalized));
			Vector3 axis2 = QuaTools.GetAxis(this.obj.transform.InverseTransformDirection(this.interactionSystem.transform.up));
			this.pivot.localRotation = Quaternion.LookRotation(axis, axis2);
			Quaternion lhs = QuaTools.FromToRotation(this.pivot.rotation, this.interactionSystem.transform.rotation);
			this.holdPoint.rotation = lhs * this.holdPoint.rotation;
		}
	}
}
