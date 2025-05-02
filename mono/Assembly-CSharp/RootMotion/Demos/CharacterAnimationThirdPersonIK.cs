using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000094 RID: 148
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		// Token: 0x0600056F RID: 1391 RVA: 0x00024ED5 File Offset: 0x000230D5
		protected override void Start()
		{
			base.Start();
			this.ik = base.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00024EEC File Offset: 0x000230EC
		protected override void LateUpdate()
		{
			base.LateUpdate();
			if (Vector3.Angle(base.transform.up, Vector3.up) <= 0.01f)
			{
				return;
			}
			Quaternion rotation = Quaternion.FromToRotation(base.transform.up, Vector3.up);
			this.RotateEffector(this.ik.solver.bodyEffector, rotation, 0.1f);
			this.RotateEffector(this.ik.solver.leftShoulderEffector, rotation, 0.2f);
			this.RotateEffector(this.ik.solver.rightShoulderEffector, rotation, 0.2f);
			this.RotateEffector(this.ik.solver.leftHandEffector, rotation, 0.1f);
			this.RotateEffector(this.ik.solver.rightHandEffector, rotation, 0.1f);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00024FC0 File Offset: 0x000231C0
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
			Vector3 vector = effector.bone.position - base.transform.position;
			Vector3 a = rotation * vector - vector;
			effector.positionOffset += a * mlp;
		}

		// Token: 0x0400046B RID: 1131
		private FullBodyBipedIK ik;
	}
}
