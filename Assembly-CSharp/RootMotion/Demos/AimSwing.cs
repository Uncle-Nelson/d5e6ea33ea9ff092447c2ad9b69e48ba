using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000088 RID: 136
	public class AimSwing : MonoBehaviour
	{
		// Token: 0x06000535 RID: 1333 RVA: 0x0002311C File Offset: 0x0002131C
		private void LateUpdate()
		{
			this.ik.solver.axis = this.ik.solver.transform.InverseTransformVector(this.ik.transform.rotation * this.animatedAimDirection);
		}

		// Token: 0x040003F7 RID: 1015
		public AimIK ik;

		// Token: 0x040003F8 RID: 1016
		[Tooltip("The direction in which the weapon is aimed in animation (in character space). Tweak this value to adjust the aiming.")]
		public Vector3 animatedAimDirection = Vector3.forward;
	}
}
