using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000086 RID: 134
	public class FKOffset : MonoBehaviour
	{
		// Token: 0x0600052F RID: 1327 RVA: 0x00023053 File Offset: 0x00021253
		private void Start()
		{
			this.animator = base.GetComponent<Animator>();
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00023064 File Offset: 0x00021264
		private void LateUpdate()
		{
			FKOffset.Offset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Apply(this.animator);
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00023094 File Offset: 0x00021294
		private void OnDrawGizmosSelected()
		{
			foreach (FKOffset.Offset offset in this.offsets)
			{
				offset.name = offset.bone.ToString();
			}
		}

		// Token: 0x040003F3 RID: 1011
		public FKOffset.Offset[] offsets;

		// Token: 0x040003F4 RID: 1012
		private Animator animator;

		// Token: 0x0200011B RID: 283
		[Serializable]
		public class Offset
		{
			// Token: 0x0600080F RID: 2063 RVA: 0x00034C54 File Offset: 0x00032E54
			public void Apply(Animator animator)
			{
				if (this.t == null)
				{
					this.t = animator.GetBoneTransform(this.bone);
				}
				if (this.t == null)
				{
					return;
				}
				this.t.localRotation *= Quaternion.Euler(this.rotationOffset);
			}

			// Token: 0x04000838 RID: 2104
			[HideInInspector]
			public string name;

			// Token: 0x04000839 RID: 2105
			public HumanBodyBones bone;

			// Token: 0x0400083A RID: 2106
			public Vector3 rotationOffset;

			// Token: 0x0400083B RID: 2107
			private Transform t;
		}
	}
}
