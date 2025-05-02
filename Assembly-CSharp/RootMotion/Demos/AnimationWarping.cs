using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000091 RID: 145
	public class AnimationWarping : OffsetModifier
	{
		// Token: 0x0600055D RID: 1373 RVA: 0x0002458D File Offset: 0x0002278D
		protected override void Start()
		{
			base.Start();
			this.lastMode = this.effectorMode;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000245A4 File Offset: 0x000227A4
		public float GetWarpWeight(int warpIndex)
		{
			if (warpIndex < 0)
			{
				Debug.LogError("Warp index out of range.");
				return 0f;
			}
			if (warpIndex >= this.warps.Length)
			{
				Debug.LogError("Warp index out of range.");
				return 0f;
			}
			if (this.animator == null)
			{
				Debug.LogError("Animator unassigned in AnimationWarping");
				return 0f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[warpIndex].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[warpIndex].animationState))
			{
				return 0f;
			}
			return this.warps[warpIndex].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00024664 File Offset: 0x00022864
		protected override void OnModifyOffset()
		{
			for (int i = 0; i < this.warps.Length; i++)
			{
				float warpWeight = this.GetWarpWeight(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.GetEffector(this.warps[i].effector).position = this.ik.solver.GetEffector(this.warps[i].effector).bone.position + vector;
						this.ik.solver.GetEffector(this.warps[i].effector).positionWeight = this.weight * warpWeight;
					}
				}
				else
				{
					this.ik.solver.GetEffector(this.warps[i].effector).positionOffset += vector * warpWeight * this.weight;
				}
			}
			if (this.lastMode == AnimationWarping.EffectorMode.Position && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				foreach (AnimationWarping.Warp warp in this.warps)
				{
					this.ik.solver.GetEffector(warp.effector).positionWeight = 0f;
				}
			}
			this.lastMode = this.effectorMode;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00024808 File Offset: 0x00022A08
		private void OnDisable()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.Position)
			{
				return;
			}
			foreach (AnimationWarping.Warp warp in this.warps)
			{
				this.ik.solver.GetEffector(warp.effector).positionWeight = 0f;
			}
		}

		// Token: 0x04000453 RID: 1107
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		// Token: 0x04000454 RID: 1108
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public AnimationWarping.EffectorMode effectorMode;

		// Token: 0x04000455 RID: 1109
		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public AnimationWarping.Warp[] warps;

		// Token: 0x04000456 RID: 1110
		private AnimationWarping.EffectorMode lastMode;

		// Token: 0x0200011D RID: 285
		[Serializable]
		public struct Warp
		{
			// Token: 0x04000841 RID: 2113
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			// Token: 0x04000842 RID: 2114
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			// Token: 0x04000843 RID: 2115
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			// Token: 0x04000844 RID: 2116
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			// Token: 0x04000845 RID: 2117
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			// Token: 0x04000846 RID: 2118
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		// Token: 0x0200011E RID: 286
		[Serializable]
		public enum EffectorMode
		{
			// Token: 0x04000848 RID: 2120
			PositionOffset,
			// Token: 0x04000849 RID: 2121
			Position
		}
	}
}
