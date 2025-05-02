using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000C4 RID: 196
	public class UserControlAI : UserControlThirdPerson
	{
		// Token: 0x06000644 RID: 1604 RVA: 0x0002AA3A File Offset: 0x00028C3A
		protected override void Start()
		{
			base.Start();
			this.navigator.Initiate(base.transform);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0002AA54 File Offset: 0x00028C54
		protected override void Update()
		{
			float d = this.walkByDefault ? 0.5f : 1f;
			if (this.navigator.activeTargetSeeking)
			{
				this.navigator.Update(this.moveTarget.position);
				this.state.move = this.navigator.normalizedDeltaPosition * d;
				return;
			}
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.move != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.move = ((magnitude > num) ? (a * d) : Vector3.zero);
			this.state.lookPos = this.moveTarget.position;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0002AB51 File Offset: 0x00028D51
		private void OnDrawGizmos()
		{
			if (this.navigator.activeTargetSeeking)
			{
				this.navigator.Visualize();
			}
		}

		// Token: 0x040005C0 RID: 1472
		public Transform moveTarget;

		// Token: 0x040005C1 RID: 1473
		public float stoppingDistance = 0.5f;

		// Token: 0x040005C2 RID: 1474
		public float stoppingThreshold = 1.5f;

		// Token: 0x040005C3 RID: 1475
		public Navigator navigator;
	}
}
