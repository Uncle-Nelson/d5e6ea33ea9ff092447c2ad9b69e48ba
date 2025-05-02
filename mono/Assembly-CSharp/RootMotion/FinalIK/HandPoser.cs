using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000069 RID: 105
	public class HandPoser : Poser
	{
		// Token: 0x06000462 RID: 1122 RVA: 0x0001DA00 File Offset: 0x0001BC00
		public override void AutoMapping()
		{
			if (this.poseRoot == null)
			{
				this.poseChildren = new Transform[0];
			}
			else
			{
				this.poseChildren = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this._poseRoot = this.poseRoot;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0001DA3B File Offset: 0x0001BC3B
		protected override void InitiatePoser()
		{
			this.children = base.GetComponentsInChildren<Transform>();
			this.StoreDefaultState();
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0001DA50 File Offset: 0x0001BC50
		protected override void FixPoserTransforms()
		{
			for (int i = 0; i < this.children.Length; i++)
			{
				this.children[i].localPosition = this.defaultLocalPositions[i];
				this.children[i].localRotation = this.defaultLocalRotations[i];
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0001DAA4 File Offset: 0x0001BCA4
		protected override void UpdatePoser()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			if (this.localPositionWeight <= 0f && this.localRotationWeight <= 0f)
			{
				return;
			}
			if (this._poseRoot != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.children.Length != this.poseChildren.Length)
			{
				Warning.Log("Number of children does not match with the pose", base.transform, false);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 0; i < this.children.Length; i++)
			{
				if (this.children[i] != base.transform)
				{
					this.children[i].localRotation = Quaternion.Lerp(this.children[i].localRotation, this.poseChildren[i].localRotation, t);
					this.children[i].localPosition = Vector3.Lerp(this.children[i].localPosition, this.poseChildren[i].localPosition, t2);
				}
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0001DBC4 File Offset: 0x0001BDC4
		protected void StoreDefaultState()
		{
			this.defaultLocalPositions = new Vector3[this.children.Length];
			this.defaultLocalRotations = new Quaternion[this.children.Length];
			for (int i = 0; i < this.children.Length; i++)
			{
				this.defaultLocalPositions[i] = this.children[i].localPosition;
				this.defaultLocalRotations[i] = this.children[i].localRotation;
			}
		}

		// Token: 0x0400034B RID: 843
		protected Transform[] children;

		// Token: 0x0400034C RID: 844
		private Transform _poseRoot;

		// Token: 0x0400034D RID: 845
		private Transform[] poseChildren;

		// Token: 0x0400034E RID: 846
		private Vector3[] defaultLocalPositions;

		// Token: 0x0400034F RID: 847
		private Quaternion[] defaultLocalRotations;
	}
}
