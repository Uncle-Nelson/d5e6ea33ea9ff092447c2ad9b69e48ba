using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000061 RID: 97
	[Serializable]
	public class TwistSolver
	{
		// Token: 0x060003CB RID: 971 RVA: 0x00019EB4 File Offset: 0x000180B4
		public TwistSolver()
		{
			this.weight = 1f;
			this.parentChildCrossfade = 0.5f;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00019F20 File Offset: 0x00018120
		public TwistSolver(Transform t)
		{
			this.transform = t;
			this.weight = 1f;
			this.parentChildCrossfade = 0.5f;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00019F94 File Offset: 0x00018194
		public void Initiate()
		{
			if (this.inititated)
			{
				return;
			}
			if (this.transform == null)
			{
				Debug.LogError("TwistRelaxer solver has unassigned Transform. TwistRelaxer.cs was restructured for FIK v2.0 to support multiple relaxers on the same body part and TwistRelaxer components need to be set up again, sorry for the inconvenience!", this.transform);
				return;
			}
			if (this.parent == null)
			{
				this.parent = this.transform.parent;
			}
			if (this.children.Length == 0)
			{
				if (this.transform.childCount == 0)
				{
					Transform[] componentsInChildren = this.parent.GetComponentsInChildren<Transform>();
					for (int i = 1; i < componentsInChildren.Length; i++)
					{
						if (componentsInChildren[i] != this.transform)
						{
							Transform[] array = new Transform[]
							{
								componentsInChildren[i]
							};
							break;
						}
					}
				}
				else
				{
					this.children = new Transform[]
					{
						this.transform.GetChild(0)
					};
				}
			}
			if (this.children.Length == 0 || this.children[0] == null)
			{
				Debug.LogError("TwistRelaxer has no children assigned.", this.transform);
				return;
			}
			this.twistAxis = this.transform.InverseTransformDirection(this.children[0].position - this.transform.position);
			this.axis = new Vector3(this.twistAxis.y, this.twistAxis.z, this.twistAxis.x);
			Vector3 point = this.transform.rotation * this.axis;
			this.axisRelativeToParentDefault = Quaternion.Inverse(this.parent.rotation) * point;
			this.axisRelativeToChildDefault = Quaternion.Inverse(this.children[0].rotation) * point;
			this.childRotations = new Quaternion[this.children.Length];
			this.defaultLocalRotation = this.transform.localRotation;
			this.defaultChildLocalRotations = new Quaternion[this.children.Length];
			for (int j = 0; j < this.children.Length; j++)
			{
				this.defaultChildLocalRotations[j] = this.children[j].localRotation;
			}
			this.inititated = true;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0001A194 File Offset: 0x00018394
		public void FixTransforms()
		{
			this.transform.localRotation = this.defaultLocalRotation;
			for (int i = 0; i < this.children.Length; i++)
			{
				this.children[i].localRotation = this.defaultChildLocalRotations[i];
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0001A1E0 File Offset: 0x000183E0
		public void Relax()
		{
			if (!this.inititated)
			{
				return;
			}
			if (this.weight <= 0f)
			{
				return;
			}
			Quaternion quaternion = this.transform.rotation;
			Quaternion lhs = Quaternion.AngleAxis(this.twistAngleOffset, quaternion * this.twistAxis);
			quaternion = lhs * quaternion;
			Vector3 vector = lhs * this.parent.rotation * this.axisRelativeToParentDefault;
			vector = Quaternion.FromToRotation(this.transform.position - this.parent.position, this.children[0].position - this.transform.position) * vector;
			Vector3 b = lhs * this.children[0].rotation * this.axisRelativeToChildDefault;
			Vector3 vector2 = Vector3.Slerp(vector, b, this.parentChildCrossfade);
			vector2 = Quaternion.Inverse(Quaternion.LookRotation(quaternion * this.axis, quaternion * this.twistAxis)) * vector2;
			float num = Mathf.Atan2(vector2.x, vector2.z) * 57.29578f;
			for (int i = 0; i < this.children.Length; i++)
			{
				this.childRotations[i] = this.children[i].rotation;
			}
			this.transform.rotation = Quaternion.AngleAxis(num * this.weight, quaternion * this.twistAxis) * quaternion;
			for (int j = 0; j < this.children.Length; j++)
			{
				this.children[j].rotation = this.childRotations[j];
			}
		}

		// Token: 0x040002DE RID: 734
		[Tooltip("The transform that this solver operates on.")]
		public Transform transform;

		// Token: 0x040002DF RID: 735
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		// Token: 0x040002E0 RID: 736
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform[] children = new Transform[0];

		// Token: 0x040002E1 RID: 737
		[Tooltip("The weight of relaxing the twist of this Transform")]
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x040002E2 RID: 738
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		[Range(0f, 1f)]
		public float parentChildCrossfade = 0.5f;

		// Token: 0x040002E3 RID: 739
		[Tooltip("Rotation offset around the twist axis.")]
		[Range(-180f, 180f)]
		public float twistAngleOffset;

		// Token: 0x040002E4 RID: 740
		private Vector3 twistAxis = Vector3.right;

		// Token: 0x040002E5 RID: 741
		private Vector3 axis = Vector3.forward;

		// Token: 0x040002E6 RID: 742
		private Vector3 axisRelativeToParentDefault;

		// Token: 0x040002E7 RID: 743
		private Vector3 axisRelativeToChildDefault;

		// Token: 0x040002E8 RID: 744
		private Quaternion[] childRotations;

		// Token: 0x040002E9 RID: 745
		private bool inititated;

		// Token: 0x040002EA RID: 746
		private Quaternion defaultLocalRotation = Quaternion.identity;

		// Token: 0x040002EB RID: 747
		private Quaternion[] defaultChildLocalRotations;
	}
}
