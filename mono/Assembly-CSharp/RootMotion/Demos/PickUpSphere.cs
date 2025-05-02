using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000AA RID: 170
	public class PickUpSphere : PickUp2Handed
	{
		// Token: 0x060005C8 RID: 1480 RVA: 0x0002785C File Offset: 0x00025A5C
		protected override void RotatePivot()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.ik.solver.leftHandEffector.bone.position, this.interactionSystem.ik.solver.rightHandEffector.bone.position, 0.5f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}
	}
}
