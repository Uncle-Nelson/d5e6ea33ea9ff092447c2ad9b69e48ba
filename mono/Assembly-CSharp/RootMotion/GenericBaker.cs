using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000006 RID: 6
	public class GenericBaker : Baker
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002358 File Offset: 0x00000558
		private void Awake()
		{
			Transform[] componentsInChildren = this.root.GetComponentsInChildren<Transform>();
			this.children = new BakerTransform[0];
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (!this.IsIgnored(componentsInChildren[i]))
				{
					Array.Resize<BakerTransform>(ref this.children, this.children.Length + 1);
					bool flag = componentsInChildren[i] == this.rootNode;
					if (flag)
					{
						this.rootChildIndex = this.children.Length - 1;
					}
					this.children[this.children.Length - 1] = new BakerTransform(componentsInChildren[i], this.root, this.BakePosition(componentsInChildren[i]), flag);
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000023F6 File Offset: 0x000005F6
		protected override Transform GetCharacterRoot()
		{
			return this.root;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002400 File Offset: 0x00000600
		protected override void OnStartBaking()
		{
			for (int i = 0; i < this.children.Length; i++)
			{
				this.children[i].Reset();
				if (i == this.rootChildIndex)
				{
					this.children[i].SetRelativeSpace(this.root.position, this.root.rotation);
				}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000245C File Offset: 0x0000065C
		protected override void OnSetLoopFrame(float time)
		{
			for (int i = 0; i < this.children.Length; i++)
			{
				this.children[i].AddLoopFrame(time);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000248C File Offset: 0x0000068C
		protected override void OnSetCurves(ref AnimationClip clip)
		{
			for (int i = 0; i < this.children.Length; i++)
			{
				this.children[i].SetCurves(ref clip);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000024BC File Offset: 0x000006BC
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
			for (int i = 0; i < this.children.Length; i++)
			{
				this.children[i].SetKeyframes(time);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000024EC File Offset: 0x000006EC
		private bool IsIgnored(Transform t)
		{
			for (int i = 0; i < this.ignoreList.Length; i++)
			{
				if (t == this.ignoreList[i])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002520 File Offset: 0x00000720
		private bool BakePosition(Transform t)
		{
			for (int i = 0; i < this.bakePositionList.Length; i++)
			{
				if (t == this.bakePositionList[i])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000018 RID: 24
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy;

		// Token: 0x04000019 RID: 25
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root;

		// Token: 0x0400001A RID: 26
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode;

		// Token: 0x0400001B RID: 27
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList;

		// Token: 0x0400001C RID: 28
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
		public Transform[] bakePositionList;

		// Token: 0x0400001D RID: 29
		private BakerTransform[] children = new BakerTransform[0];

		// Token: 0x0400001E RID: 30
		private BakerTransform rootChild;

		// Token: 0x0400001F RID: 31
		private int rootChildIndex = -1;
	}
}
