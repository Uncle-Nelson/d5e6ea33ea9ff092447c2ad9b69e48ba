using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000A5 RID: 165
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		// Token: 0x060005AF RID: 1455 RVA: 0x00026C40 File Offset: 0x00024E40
		private void Start()
		{
			this.cubeDefaultPosition = this.cube.position;
			this.cubeRigidbody = this.cube.GetComponent<Rigidbody>();
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00026C64 File Offset: 0x00024E64
		private void Update()
		{
			this.info = this.animator.GetCurrentAnimatorStateInfo(0);
			this.motionAbsorb.weight = this.motionAbsorbWeight.Evaluate(this.info.normalizedTime - (float)((int)this.info.normalizedTime));
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00026CB4 File Offset: 0x00024EB4
		private void SwingStart()
		{
			this.cubeRigidbody.MovePosition(this.cubeDefaultPosition + Random.insideUnitSphere * this.cubeRandomPosition);
			this.cubeRigidbody.MoveRotation(Quaternion.identity);
			this.cubeRigidbody.velocity = Vector3.zero;
			this.cubeRigidbody.angularVelocity = Vector3.zero;
		}

		// Token: 0x040004D3 RID: 1235
		public Animator animator;

		// Token: 0x040004D4 RID: 1236
		public MotionAbsorb motionAbsorb;

		// Token: 0x040004D5 RID: 1237
		public Transform cube;

		// Token: 0x040004D6 RID: 1238
		public float cubeRandomPosition = 0.1f;

		// Token: 0x040004D7 RID: 1239
		public AnimationCurve motionAbsorbWeight;

		// Token: 0x040004D8 RID: 1240
		private Vector3 cubeDefaultPosition;

		// Token: 0x040004D9 RID: 1241
		private AnimatorStateInfo info;

		// Token: 0x040004DA RID: 1242
		private Rigidbody cubeRigidbody;
	}
}
