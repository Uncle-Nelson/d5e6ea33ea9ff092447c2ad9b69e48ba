using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000003 RID: 3
	public abstract class AnimationModifier : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x000020C6 File Offset: 0x000002C6
		public virtual void OnInitiate(Baker baker, Animator animator)
		{
			this.baker = baker;
			this.animator = animator;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020D6 File Offset: 0x000002D6
		public virtual void OnStartClip(AnimationClip clip)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020D8 File Offset: 0x000002D8
		public virtual void OnBakerUpdate(float normalizedTime)
		{
		}

		// Token: 0x04000001 RID: 1
		protected Animator animator;

		// Token: 0x04000002 RID: 2
		protected Baker baker;
	}
}
