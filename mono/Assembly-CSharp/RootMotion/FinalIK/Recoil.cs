using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000081 RID: 129
	public class Recoil : OffsetModifier
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00020B2F File Offset: 0x0001ED2F
		public bool isFinished
		{
			get
			{
				return Time.time > this.endTime;
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00020B3E File Offset: 0x0001ED3E
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
			if (this.handedness == Recoil.Handedness.Left)
			{
				this.primaryHandRotation = leftHandRotation;
			}
			else
			{
				this.primaryHandRotation = rightHandRotation;
			}
			this.handRotationsSet = true;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00020B60 File Offset: 0x0001ED60
		public void Fire(float magnitude)
		{
			float num = magnitude * Random.value * this.magnitudeRandom;
			this.magnitudeMlp = magnitude + num;
			this.randomRotation = Quaternion.Euler(this.rotationRandom * Random.value);
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Start();
			}
			if (Time.time < this.endTime)
			{
				this.blendWeight = 0f;
			}
			else
			{
				this.blendWeight = 1f;
			}
			Keyframe[] keys = this.recoilWeight.keys;
			this.length = keys[keys.Length - 1].time;
			this.endTime = Time.time + this.length;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00020C18 File Offset: 0x0001EE18
		protected override void OnModifyOffset()
		{
			if (this.aimIK != null)
			{
				this.aimIKAxis = this.aimIK.solver.axis;
			}
			if (!this.initiated && this.ik != null)
			{
				this.initiated = true;
				if (this.headIK != null)
				{
					this.headIK.enabled = false;
				}
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPostUpdate, new IKSolver.UpdateDelegate(this.AfterFBBIK));
				if (this.aimIK != null)
				{
					IKSolverAim solver2 = this.aimIK.solver;
					solver2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver2.OnPostUpdate, new IKSolver.UpdateDelegate(this.AfterAimIK));
				}
			}
			if (Time.time >= this.endTime)
			{
				this.rotationOffset = Quaternion.identity;
				return;
			}
			this.blendTime = Mathf.Max(this.blendTime, 0f);
			if (this.blendTime > 0f)
			{
				this.blendWeight = Mathf.Min(this.blendWeight + Time.deltaTime * (1f / this.blendTime), 1f);
			}
			else
			{
				this.blendWeight = 1f;
			}
			float b = this.recoilWeight.Evaluate(this.length - (this.endTime - Time.time)) * this.magnitudeMlp;
			this.w = Mathf.Lerp(this.w, b, this.blendWeight);
			Quaternion quaternion = (this.aimIK != null && this.aimIK.solver.transform != null && !this.aimIKSolvedLast) ? Quaternion.LookRotation(this.aimIK.solver.IKPosition - this.aimIK.solver.transform.position, this.ik.references.root.up) : this.ik.references.root.rotation;
			quaternion = this.randomRotation * quaternion;
			Recoil.RecoilOffset[] array = this.offsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Apply(this.ik.solver, quaternion, this.w, this.length, this.endTime - Time.time);
			}
			if (!this.handRotationsSet)
			{
				this.primaryHandRotation = this.primaryHand.rotation;
			}
			this.handRotationsSet = false;
			this.rotationOffset = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(this.randomRotation * this.primaryHandRotation * this.handRotationOffset), this.w);
			this.handRotation = this.rotationOffset * this.primaryHandRotation;
			if (this.twoHanded)
			{
				Vector3 point = Quaternion.Inverse(this.primaryHand.rotation) * (this.secondaryHand.position - this.primaryHand.position);
				this.secondaryHandRelativeRotation = Quaternion.Inverse(this.primaryHand.rotation) * this.secondaryHand.rotation;
				Vector3 a = this.primaryHand.position + this.primaryHandEffector.positionOffset + this.handRotation * point;
				this.secondaryHandEffector.positionOffset += a - (this.secondaryHand.position + this.secondaryHandEffector.positionOffset);
			}
			if (this.aimIK != null && this.aimIKSolvedLast)
			{
				this.aimIK.solver.axis = Quaternion.Inverse(this.ik.references.root.rotation) * Quaternion.Inverse(this.rotationOffset) * this.aimIKAxis;
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00021008 File Offset: 0x0001F208
		private void AfterFBBIK()
		{
			if (Time.time < this.endTime)
			{
				this.primaryHand.rotation = this.handRotation;
				if (this.twoHanded)
				{
					this.secondaryHand.rotation = this.primaryHand.rotation * this.secondaryHandRelativeRotation;
				}
			}
			if (!this.aimIKSolvedLast && this.headIK != null)
			{
				this.headIK.solver.Update();
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00021084 File Offset: 0x0001F284
		private void AfterAimIK()
		{
			if (this.aimIKSolvedLast)
			{
				this.aimIK.solver.axis = this.aimIKAxis;
			}
			if (this.aimIKSolvedLast && this.headIK != null)
			{
				this.headIK.solver.Update();
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x000210D5 File Offset: 0x0001F2D5
		private IKEffector primaryHandEffector
		{
			get
			{
				if (this.handedness == Recoil.Handedness.Right)
				{
					return this.ik.solver.rightHandEffector;
				}
				return this.ik.solver.leftHandEffector;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00021100 File Offset: 0x0001F300
		private IKEffector secondaryHandEffector
		{
			get
			{
				if (this.handedness == Recoil.Handedness.Right)
				{
					return this.ik.solver.leftHandEffector;
				}
				return this.ik.solver.rightHandEffector;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0002112B File Offset: 0x0001F32B
		private Transform primaryHand
		{
			get
			{
				return this.primaryHandEffector.bone;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00021138 File Offset: 0x0001F338
		private Transform secondaryHand
		{
			get
			{
				return this.secondaryHandEffector.bone;
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00021148 File Offset: 0x0001F348
		protected override void OnDestroy()
		{
			base.OnDestroy();
			if (this.ik != null && this.initiated)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPostUpdate, new IKSolver.UpdateDelegate(this.AfterFBBIK));
				if (this.aimIK != null)
				{
					IKSolverAim solver2 = this.aimIK.solver;
					solver2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver2.OnPostUpdate, new IKSolver.UpdateDelegate(this.AfterAimIK));
				}
			}
		}

		// Token: 0x040003CE RID: 974
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		// Token: 0x040003CF RID: 975
		[Tooltip("Optional head AimIK solver. This solver should only use neck and head bones and have the head as Aim Transform")]
		public AimIK headIK;

		// Token: 0x040003D0 RID: 976
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		// Token: 0x040003D1 RID: 977
		[Tooltip("Which hand is holding the weapon?")]
		public Recoil.Handedness handedness;

		// Token: 0x040003D2 RID: 978
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded = true;

		// Token: 0x040003D3 RID: 979
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		// Token: 0x040003D4 RID: 980
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom = 0.1f;

		// Token: 0x040003D5 RID: 981
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		// Token: 0x040003D6 RID: 982
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		// Token: 0x040003D7 RID: 983
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		// Token: 0x040003D8 RID: 984
		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public Recoil.RecoilOffset[] offsets;

		// Token: 0x040003D9 RID: 985
		[HideInInspector]
		public Quaternion rotationOffset = Quaternion.identity;

		// Token: 0x040003DA RID: 986
		private float magnitudeMlp = 1f;

		// Token: 0x040003DB RID: 987
		private float endTime = -1f;

		// Token: 0x040003DC RID: 988
		private Quaternion handRotation;

		// Token: 0x040003DD RID: 989
		private Quaternion secondaryHandRelativeRotation;

		// Token: 0x040003DE RID: 990
		private Quaternion randomRotation;

		// Token: 0x040003DF RID: 991
		private float length = 1f;

		// Token: 0x040003E0 RID: 992
		private bool initiated;

		// Token: 0x040003E1 RID: 993
		private float blendWeight;

		// Token: 0x040003E2 RID: 994
		private float w;

		// Token: 0x040003E3 RID: 995
		private Quaternion primaryHandRotation = Quaternion.identity;

		// Token: 0x040003E4 RID: 996
		private bool handRotationsSet;

		// Token: 0x040003E5 RID: 997
		private Vector3 aimIKAxis;

		// Token: 0x02000117 RID: 279
		[Serializable]
		public class RecoilOffset
		{
			// Token: 0x0600080A RID: 2058 RVA: 0x00034AE7 File Offset: 0x00032CE7
			public void Start()
			{
				if (this.additivity <= 0f)
				{
					return;
				}
				this.additiveOffset = Vector3.ClampMagnitude(this.lastOffset * this.additivity, this.maxAdditiveOffsetMag);
			}

			// Token: 0x0600080B RID: 2059 RVA: 0x00034B1C File Offset: 0x00032D1C
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
				this.additiveOffset = Vector3.Lerp(Vector3.zero, this.additiveOffset, timeLeft / length);
				this.lastOffset = rotation * (this.offset * masterWeight) + rotation * this.additiveOffset;
				foreach (Recoil.RecoilOffset.EffectorLink effectorLink in this.effectorLinks)
				{
					solver.GetEffector(effectorLink.effector).positionOffset += this.lastOffset * effectorLink.weight;
				}
			}

			// Token: 0x04000815 RID: 2069
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			// Token: 0x04000816 RID: 2070
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
			public float additivity = 1f;

			// Token: 0x04000817 RID: 2071
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag = 0.2f;

			// Token: 0x04000818 RID: 2072
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public Recoil.RecoilOffset.EffectorLink[] effectorLinks;

			// Token: 0x04000819 RID: 2073
			private Vector3 additiveOffset;

			// Token: 0x0400081A RID: 2074
			private Vector3 lastOffset;

			// Token: 0x02000141 RID: 321
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x040008D8 RID: 2264
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				// Token: 0x040008D9 RID: 2265
				[Tooltip("Weight of using this effector")]
				public float weight;
			}
		}

		// Token: 0x02000118 RID: 280
		[Serializable]
		public enum Handedness
		{
			// Token: 0x0400081C RID: 2076
			Right,
			// Token: 0x0400081D RID: 2077
			Left
		}
	}
}
