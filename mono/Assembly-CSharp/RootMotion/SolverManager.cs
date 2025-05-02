using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000024 RID: 36
	public class SolverManager : MonoBehaviour
	{
		// Token: 0x06000118 RID: 280 RVA: 0x000079D9 File Offset: 0x00005BD9
		public void Disable()
		{
			Debug.Log("IK.Disable() is deprecated. Use enabled = false instead", base.transform);
			base.enabled = false;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000079F2 File Offset: 0x00005BF2
		protected virtual void InitiateSolver()
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000079F4 File Offset: 0x00005BF4
		protected virtual void UpdateSolver()
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000079F6 File Offset: 0x00005BF6
		protected virtual void FixTransforms()
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000079F8 File Offset: 0x00005BF8
		private void OnDisable()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			this.Initiate();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00007A08 File Offset: 0x00005C08
		private void Start()
		{
			this.Initiate();
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00007A10 File Offset: 0x00005C10
		private bool animatePhysics
		{
			get
			{
				if (this.animator != null)
				{
					return this.animator.updateMode == AnimatorUpdateMode.AnimatePhysics;
				}
				return this.legacy != null && this.legacy.animatePhysics;
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00007A4A File Offset: 0x00005C4A
		private void Initiate()
		{
			if (this.componentInitiated)
			{
				return;
			}
			this.FindAnimatorRecursive(base.transform, true);
			this.InitiateSolver();
			this.componentInitiated = true;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00007A6F File Offset: 0x00005C6F
		private void Update()
		{
			if (this.skipSolverUpdate)
			{
				return;
			}
			if (this.animatePhysics)
			{
				return;
			}
			if (this.fixTransforms)
			{
				this.FixTransforms();
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00007A94 File Offset: 0x00005C94
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
			if (this.isAnimated)
			{
				return;
			}
			this.animator = t.GetComponent<Animator>();
			this.legacy = t.GetComponent<Animation>();
			if (this.isAnimated)
			{
				return;
			}
			if (this.animator == null && findInChildren)
			{
				this.animator = t.GetComponentInChildren<Animator>();
			}
			if (this.legacy == null && findInChildren)
			{
				this.legacy = t.GetComponentInChildren<Animation>();
			}
			if (!this.isAnimated && t.parent != null)
			{
				this.FindAnimatorRecursive(t.parent, false);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00007B26 File Offset: 0x00005D26
		private bool isAnimated
		{
			get
			{
				return this.animator != null || this.legacy != null;
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00007B44 File Offset: 0x00005D44
		private void FixedUpdate()
		{
			if (this.skipSolverUpdate)
			{
				this.skipSolverUpdate = false;
			}
			this.updateFrame = true;
			if (this.animatePhysics && this.fixTransforms)
			{
				this.FixTransforms();
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00007B72 File Offset: 0x00005D72
		private void LateUpdate()
		{
			if (this.skipSolverUpdate)
			{
				return;
			}
			if (!this.animatePhysics)
			{
				this.updateFrame = true;
			}
			if (!this.updateFrame)
			{
				return;
			}
			this.updateFrame = false;
			this.UpdateSolver();
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00007BA2 File Offset: 0x00005DA2
		public void UpdateSolverExternal()
		{
			if (!base.enabled)
			{
				return;
			}
			this.skipSolverUpdate = true;
			this.UpdateSolver();
		}

		// Token: 0x040000DB RID: 219
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms = true;

		// Token: 0x040000DC RID: 220
		private Animator animator;

		// Token: 0x040000DD RID: 221
		private Animation legacy;

		// Token: 0x040000DE RID: 222
		private bool updateFrame;

		// Token: 0x040000DF RID: 223
		private bool componentInitiated;

		// Token: 0x040000E0 RID: 224
		private bool skipSolverUpdate;
	}
}
