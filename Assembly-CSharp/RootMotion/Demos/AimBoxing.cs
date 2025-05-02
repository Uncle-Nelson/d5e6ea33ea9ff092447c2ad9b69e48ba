using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000087 RID: 135
	public class AimBoxing : MonoBehaviour
	{
		// Token: 0x06000533 RID: 1331 RVA: 0x000230D7 File Offset: 0x000212D7
		private void LateUpdate()
		{
			this.aimIK.solver.transform.LookAt(this.pin.position);
			this.aimIK.solver.IKPosition = base.transform.position;
		}

		// Token: 0x040003F5 RID: 1013
		public AimIK aimIK;

		// Token: 0x040003F6 RID: 1014
		public Transform pin;
	}
}
