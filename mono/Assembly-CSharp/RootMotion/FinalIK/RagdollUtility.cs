using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200006B RID: 107
	public class RagdollUtility : MonoBehaviour
	{
		// Token: 0x06000471 RID: 1137 RVA: 0x0001DCB2 File Offset: 0x0001BEB2
		public void EnableRagdoll()
		{
			if (this.isRagdoll)
			{
				return;
			}
			base.StopAllCoroutines();
			this.enableRagdollFlag = true;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0001DCCA File Offset: 0x0001BECA
		public void DisableRagdoll()
		{
			if (!this.isRagdoll)
			{
				return;
			}
			this.StoreLocalState();
			base.StopAllCoroutines();
			base.StartCoroutine(this.DisableRagdollSmooth());
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0001DCF0 File Offset: 0x0001BEF0
		public void Start()
		{
			this.animator = base.GetComponent<Animator>();
			this.allIKComponents = base.GetComponentsInChildren<IK>();
			this.disabledIKComponents = new bool[this.allIKComponents.Length];
			this.fixTransforms = new bool[this.allIKComponents.Length];
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(iksolver.OnPostUpdate, new IKSolver.UpdateDelegate(this.AfterLastIK));
			}
			Rigidbody[] componentsInChildren = base.GetComponentsInChildren<Rigidbody>();
			int num = (componentsInChildren[0].gameObject == base.gameObject) ? 1 : 0;
			this.rigidbones = new RagdollUtility.Rigidbone[(num == 0) ? componentsInChildren.Length : (componentsInChildren.Length - 1)];
			for (int i = 0; i < this.rigidbones.Length; i++)
			{
				this.rigidbones[i] = new RagdollUtility.Rigidbone(componentsInChildren[i + num]);
			}
			Transform[] componentsInChildren2 = base.GetComponentsInChildren<Transform>();
			this.children = new RagdollUtility.Child[componentsInChildren2.Length - 1];
			for (int j = 0; j < this.children.Length; j++)
			{
				this.children[j] = new RagdollUtility.Child(componentsInChildren2[j + 1]);
			}
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0001DE15 File Offset: 0x0001C015
		private IEnumerator DisableRagdollSmooth()
		{
			for (int i = 0; i < this.rigidbones.Length; i++)
			{
				this.rigidbones[i].r.isKinematic = true;
			}
			for (int j = 0; j < this.allIKComponents.Length; j++)
			{
				this.allIKComponents[j].fixTransforms = this.fixTransforms[j];
				if (this.disabledIKComponents[j])
				{
					this.allIKComponents[j].enabled = true;
				}
			}
			this.animator.updateMode = this.animatorUpdateMode;
			this.animator.enabled = true;
			while (this.ragdollWeight > 0f)
			{
				this.ragdollWeight = Mathf.SmoothDamp(this.ragdollWeight, 0f, ref this.ragdollWeightV, this.ragdollToAnimationTime);
				if (this.ragdollWeight < 0.001f)
				{
					this.ragdollWeight = 0f;
				}
				yield return null;
			}
			yield return null;
			yield break;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0001DE24 File Offset: 0x0001C024
		private void Update()
		{
			if (!this.isRagdoll)
			{
				return;
			}
			if (!this.applyIkOnRagdoll)
			{
				bool flag = false;
				for (int i = 0; i < this.allIKComponents.Length; i++)
				{
					if (this.allIKComponents[i].enabled)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					for (int j = 0; j < this.allIKComponents.Length; j++)
					{
						this.disabledIKComponents[j] = false;
					}
				}
				for (int k = 0; k < this.allIKComponents.Length; k++)
				{
					if (this.allIKComponents[k].enabled)
					{
						this.allIKComponents[k].enabled = false;
						this.disabledIKComponents[k] = true;
					}
				}
				return;
			}
			bool flag2 = false;
			for (int l = 0; l < this.allIKComponents.Length; l++)
			{
				if (this.disabledIKComponents[l])
				{
					flag2 = true;
					break;
				}
			}
			if (flag2)
			{
				for (int m = 0; m < this.allIKComponents.Length; m++)
				{
					if (this.disabledIKComponents[m])
					{
						this.allIKComponents[m].enabled = true;
					}
				}
				for (int n = 0; n < this.allIKComponents.Length; n++)
				{
					this.disabledIKComponents[n] = false;
				}
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0001DF46 File Offset: 0x0001C146
		private void FixedUpdate()
		{
			if (this.isRagdoll && this.applyIkOnRagdoll)
			{
				this.FixTransforms(1f);
			}
			this.fixedFrame = true;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0001DF6C File Offset: 0x0001C16C
		private void LateUpdate()
		{
			if (this.animator.updateMode != AnimatorUpdateMode.AnimatePhysics || (this.animator.updateMode == AnimatorUpdateMode.AnimatePhysics && this.fixedFrame))
			{
				this.AfterAnimation();
			}
			this.fixedFrame = false;
			if (!this.ikUsed)
			{
				this.OnFinalPose();
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0001DFB8 File Offset: 0x0001C1B8
		private void AfterLastIK()
		{
			if (this.ikUsed)
			{
				this.OnFinalPose();
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0001DFC8 File Offset: 0x0001C1C8
		private void AfterAnimation()
		{
			if (this.isRagdoll)
			{
				this.StoreLocalState();
				return;
			}
			this.FixTransforms(this.ragdollWeight);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0001DFE5 File Offset: 0x0001C1E5
		private void OnFinalPose()
		{
			if (!this.isRagdoll)
			{
				this.RecordVelocities();
			}
			if (this.enableRagdollFlag)
			{
				this.RagdollEnabler();
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0001E004 File Offset: 0x0001C204
		private void RagdollEnabler()
		{
			this.StoreLocalState();
			for (int i = 0; i < this.allIKComponents.Length; i++)
			{
				this.disabledIKComponents[i] = false;
			}
			if (!this.applyIkOnRagdoll)
			{
				for (int j = 0; j < this.allIKComponents.Length; j++)
				{
					if (this.allIKComponents[j].enabled)
					{
						this.allIKComponents[j].enabled = false;
						this.disabledIKComponents[j] = true;
					}
				}
			}
			this.animatorUpdateMode = this.animator.updateMode;
			this.animator.updateMode = AnimatorUpdateMode.AnimatePhysics;
			this.animator.enabled = false;
			for (int k = 0; k < this.rigidbones.Length; k++)
			{
				this.rigidbones[k].WakeUp(this.applyVelocity, this.applyAngularVelocity);
			}
			for (int l = 0; l < this.fixTransforms.Length; l++)
			{
				this.fixTransforms[l] = this.allIKComponents[l].fixTransforms;
				this.allIKComponents[l].fixTransforms = false;
			}
			this.ragdollWeight = 1f;
			this.ragdollWeightV = 0f;
			this.enableRagdollFlag = false;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x0001E11C File Offset: 0x0001C31C
		private bool isRagdoll
		{
			get
			{
				return !this.rigidbones[0].r.isKinematic && !this.animator.enabled;
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001E144 File Offset: 0x0001C344
		private void RecordVelocities()
		{
			RagdollUtility.Rigidbone[] array = this.rigidbones;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].RecordVelocity();
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0001E170 File Offset: 0x0001C370
		private bool ikUsed
		{
			get
			{
				if (this.ik == null)
				{
					return false;
				}
				if (this.ik.enabled && this.ik.GetIKSolver().IKPositionWeight > 0f)
				{
					return true;
				}
				foreach (IK ik in this.allIKComponents)
				{
					if (ik.enabled && ik.GetIKSolver().IKPositionWeight > 0f)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0001E1EC File Offset: 0x0001C3EC
		private void StoreLocalState()
		{
			RagdollUtility.Child[] array = this.children;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].StoreLocalState();
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0001E218 File Offset: 0x0001C418
		private void FixTransforms(float weight)
		{
			RagdollUtility.Child[] array = this.children;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].FixTransform(weight);
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0001E243 File Offset: 0x0001C443
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(iksolver.OnPostUpdate, new IKSolver.UpdateDelegate(this.AfterLastIK));
			}
		}

		// Token: 0x04000355 RID: 853
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		// Token: 0x04000356 RID: 854
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime = 0.2f;

		// Token: 0x04000357 RID: 855
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		// Token: 0x04000358 RID: 856
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity = 1f;

		// Token: 0x04000359 RID: 857
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity = 1f;

		// Token: 0x0400035A RID: 858
		private Animator animator;

		// Token: 0x0400035B RID: 859
		private RagdollUtility.Rigidbone[] rigidbones = new RagdollUtility.Rigidbone[0];

		// Token: 0x0400035C RID: 860
		private RagdollUtility.Child[] children = new RagdollUtility.Child[0];

		// Token: 0x0400035D RID: 861
		private bool enableRagdollFlag;

		// Token: 0x0400035E RID: 862
		private AnimatorUpdateMode animatorUpdateMode;

		// Token: 0x0400035F RID: 863
		private IK[] allIKComponents = new IK[0];

		// Token: 0x04000360 RID: 864
		private bool[] fixTransforms = new bool[0];

		// Token: 0x04000361 RID: 865
		private float ragdollWeight;

		// Token: 0x04000362 RID: 866
		private float ragdollWeightV;

		// Token: 0x04000363 RID: 867
		private bool fixedFrame;

		// Token: 0x04000364 RID: 868
		private bool[] disabledIKComponents = new bool[0];

		// Token: 0x02000103 RID: 259
		public class Rigidbone
		{
			// Token: 0x060007A6 RID: 1958 RVA: 0x00033200 File Offset: 0x00031400
			public Rigidbone(Rigidbody r)
			{
				this.r = r;
				this.t = r.transform;
				this.joint = this.t.GetComponent<Joint>();
				this.collider = this.t.GetComponent<Collider>();
				if (this.joint != null)
				{
					this.c = this.joint.connectedBody;
					this.updateAnchor = (this.c != null);
				}
				this.lastPosition = this.t.position;
				this.lastRotation = this.t.rotation;
			}

			// Token: 0x060007A7 RID: 1959 RVA: 0x0003329C File Offset: 0x0003149C
			public void RecordVelocity()
			{
				this.deltaPosition = this.t.position - this.lastPosition;
				this.lastPosition = this.t.position;
				this.deltaRotation = QuaTools.FromToRotation(this.lastRotation, this.t.rotation);
				this.lastRotation = this.t.rotation;
				this.deltaTime = Time.deltaTime;
			}

			// Token: 0x060007A8 RID: 1960 RVA: 0x00033310 File Offset: 0x00031510
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
				if (this.updateAnchor)
				{
					this.joint.connectedAnchor = this.t.InverseTransformPoint(this.c.position);
				}
				this.r.isKinematic = false;
				if (velocityWeight != 0f)
				{
					this.r.velocity = this.deltaPosition / this.deltaTime * velocityWeight;
				}
				if (angularVelocityWeight != 0f)
				{
					float num = 0f;
					Vector3 vector = Vector3.zero;
					this.deltaRotation.ToAngleAxis(out num, out vector);
					num *= 0.017453292f;
					num /= this.deltaTime;
					vector *= num * angularVelocityWeight;
					this.r.angularVelocity = Vector3.ClampMagnitude(vector, this.r.maxAngularVelocity);
				}
				this.r.WakeUp();
			}

			// Token: 0x040007A2 RID: 1954
			public Rigidbody r;

			// Token: 0x040007A3 RID: 1955
			public Transform t;

			// Token: 0x040007A4 RID: 1956
			public Collider collider;

			// Token: 0x040007A5 RID: 1957
			public Joint joint;

			// Token: 0x040007A6 RID: 1958
			public Rigidbody c;

			// Token: 0x040007A7 RID: 1959
			public bool updateAnchor;

			// Token: 0x040007A8 RID: 1960
			public Vector3 deltaPosition;

			// Token: 0x040007A9 RID: 1961
			public Quaternion deltaRotation;

			// Token: 0x040007AA RID: 1962
			public float deltaTime;

			// Token: 0x040007AB RID: 1963
			public Vector3 lastPosition;

			// Token: 0x040007AC RID: 1964
			public Quaternion lastRotation;
		}

		// Token: 0x02000104 RID: 260
		public class Child
		{
			// Token: 0x060007A9 RID: 1961 RVA: 0x000333E1 File Offset: 0x000315E1
			public Child(Transform transform)
			{
				this.t = transform;
				this.localPosition = this.t.localPosition;
				this.localRotation = this.t.localRotation;
			}

			// Token: 0x060007AA RID: 1962 RVA: 0x00033414 File Offset: 0x00031614
			public void FixTransform(float weight)
			{
				if (weight <= 0f)
				{
					return;
				}
				if (weight >= 1f)
				{
					this.t.localPosition = this.localPosition;
					this.t.localRotation = this.localRotation;
					return;
				}
				this.t.localPosition = Vector3.Lerp(this.t.localPosition, this.localPosition, weight);
				this.t.localRotation = Quaternion.Lerp(this.t.localRotation, this.localRotation, weight);
			}

			// Token: 0x060007AB RID: 1963 RVA: 0x00033499 File Offset: 0x00031699
			public void StoreLocalState()
			{
				this.localPosition = this.t.localPosition;
				this.localRotation = this.t.localRotation;
			}

			// Token: 0x040007AD RID: 1965
			public Transform t;

			// Token: 0x040007AE RID: 1966
			public Vector3 localPosition;

			// Token: 0x040007AF RID: 1967
			public Quaternion localRotation;
		}
	}
}
