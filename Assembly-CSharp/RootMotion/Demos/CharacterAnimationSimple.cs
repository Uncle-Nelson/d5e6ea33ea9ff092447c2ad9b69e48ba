using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000BF RID: 191
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		// Token: 0x06000611 RID: 1553 RVA: 0x00028DEA File Offset: 0x00026FEA
		protected override void Start()
		{
			base.Start();
			this.animator = base.GetComponentInChildren<Animator>();
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00028E00 File Offset: 0x00027000
		public override Vector3 GetPivotPoint()
		{
			if (this.pivotOffset == 0f)
			{
				return base.transform.position;
			}
			return base.transform.position + base.transform.forward * this.pivotOffset;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00028E4C File Offset: 0x0002704C
		private void Update()
		{
			float num = this.moveSpeed.Evaluate(this.characterController.animState.moveDirection.z);
			this.animator.SetFloat("Speed", num);
			this.characterController.Move(this.characterController.transform.forward * Time.deltaTime * num, Quaternion.identity);
		}

		// Token: 0x0400055B RID: 1371
		public CharacterThirdPerson characterController;

		// Token: 0x0400055C RID: 1372
		public float pivotOffset;

		// Token: 0x0400055D RID: 1373
		public AnimationCurve moveSpeed;

		// Token: 0x0400055E RID: 1374
		private Animator animator;
	}
}
