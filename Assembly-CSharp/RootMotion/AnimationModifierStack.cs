using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000004 RID: 4
	public class AnimationModifierStack : MonoBehaviour
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000020E4 File Offset: 0x000002E4
		private void Start()
		{
			this.animator = base.GetComponent<Animator>();
			this.baker = base.GetComponent<Baker>();
			Baker baker = this.baker;
			baker.OnStartClip = (Baker.BakerDelegate)Delegate.Combine(baker.OnStartClip, new Baker.BakerDelegate(this.OnBakerStartClip));
			Baker baker2 = this.baker;
			baker2.OnUpdateClip = (Baker.BakerDelegate)Delegate.Combine(baker2.OnUpdateClip, new Baker.BakerDelegate(this.OnBakerUpdateClip));
			AnimationModifier[] array = this.modifiers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].OnInitiate(this.baker, this.animator);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002180 File Offset: 0x00000380
		private void OnBakerStartClip(AnimationClip clip, float normalizedTime)
		{
			AnimationModifier[] array = this.modifiers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].OnStartClip(clip);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021AC File Offset: 0x000003AC
		private void OnBakerUpdateClip(AnimationClip clip, float normalizedTime)
		{
			foreach (AnimationModifier animationModifier in this.modifiers)
			{
				if (animationModifier.enabled)
				{
					animationModifier.OnBakerUpdate(normalizedTime);
				}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000021E4 File Offset: 0x000003E4
		private void LateUpdate()
		{
			if (!this.animator.enabled && !this.baker.isBaking)
			{
				return;
			}
			if (this.baker.isBaking && this.baker.mode == Baker.Mode.AnimationClips)
			{
				return;
			}
			if (this.animator.runtimeAnimatorController == null)
			{
				return;
			}
			float normalizedTime = this.animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
			foreach (AnimationModifier animationModifier in this.modifiers)
			{
				if (animationModifier.enabled)
				{
					animationModifier.OnBakerUpdate(normalizedTime);
				}
			}
		}

		// Token: 0x04000003 RID: 3
		public AnimationModifier[] modifiers = new AnimationModifier[0];

		// Token: 0x04000004 RID: 4
		private Animator animator;

		// Token: 0x04000005 RID: 5
		private Baker baker;
	}
}
