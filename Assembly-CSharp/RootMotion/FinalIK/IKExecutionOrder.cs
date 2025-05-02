using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000040 RID: 64
	public class IKExecutionOrder : MonoBehaviour
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000C717 File Offset: 0x0000A917
		private bool animatePhysics
		{
			get
			{
				return !(this.animator == null) && this.animator.updateMode == AnimatorUpdateMode.AnimatePhysics;
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000C738 File Offset: 0x0000A938
		private void Start()
		{
			for (int i = 0; i < this.IKComponents.Length; i++)
			{
				this.IKComponents[i].enabled = false;
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000C766 File Offset: 0x0000A966
		private void Update()
		{
			if (this.animatePhysics)
			{
				return;
			}
			this.FixTransforms();
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000C777 File Offset: 0x0000A977
		private void FixedUpdate()
		{
			this.fixedFrame = true;
			if (this.animatePhysics)
			{
				this.FixTransforms();
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000C790 File Offset: 0x0000A990
		private void LateUpdate()
		{
			if (!this.animatePhysics || this.fixedFrame)
			{
				for (int i = 0; i < this.IKComponents.Length; i++)
				{
					this.IKComponents[i].GetIKSolver().Update();
				}
				this.fixedFrame = false;
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000C7DC File Offset: 0x0000A9DC
		private void FixTransforms()
		{
			for (int i = 0; i < this.IKComponents.Length; i++)
			{
				if (this.IKComponents[i].fixTransforms)
				{
					this.IKComponents[i].GetIKSolver().FixTransforms();
				}
			}
		}

		// Token: 0x0400017F RID: 383
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		// Token: 0x04000180 RID: 384
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		// Token: 0x04000181 RID: 385
		private bool fixedFrame;
	}
}
