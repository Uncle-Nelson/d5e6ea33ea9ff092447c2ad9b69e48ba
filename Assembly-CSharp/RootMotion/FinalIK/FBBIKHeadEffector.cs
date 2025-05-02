using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000048 RID: 72
	public class FBBIKHeadEffector : MonoBehaviour
	{
		// Token: 0x06000254 RID: 596 RVA: 0x0000CF88 File Offset: 0x0000B188
		private void Start()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPreRead, new IKSolver.UpdateDelegate(this.OnPreRead));
			IKSolverFullBodyBiped solver2 = this.ik.solver;
			solver2.OnPreIteration = (IKSolver.IterationDelegate)Delegate.Combine(solver2.OnPreIteration, new IKSolver.IterationDelegate(this.Iterate));
			IKSolverFullBodyBiped solver3 = this.ik.solver;
			solver3.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver3.OnPostUpdate, new IKSolver.UpdateDelegate(this.OnPostUpdate));
			IKSolverFullBodyBiped solver4 = this.ik.solver;
			solver4.OnStoreDefaultLocalState = (IKSolver.UpdateDelegate)Delegate.Combine(solver4.OnStoreDefaultLocalState, new IKSolver.UpdateDelegate(this.OnStoreDefaultLocalState));
			IKSolverFullBodyBiped solver5 = this.ik.solver;
			solver5.OnFixTransforms = (IKSolver.UpdateDelegate)Delegate.Combine(solver5.OnFixTransforms, new IKSolver.UpdateDelegate(this.OnFixTransforms));
			this.OnStoreDefaultLocalState();
			this.headRotationRelativeToRoot = Quaternion.Inverse(this.ik.references.root.rotation) * this.ik.references.head.rotation;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000D0B4 File Offset: 0x0000B2B4
		private void OnStoreDefaultLocalState()
		{
			foreach (FBBIKHeadEffector.BendBone bendBone in this.bendBones)
			{
				if (bendBone != null)
				{
					bendBone.StoreDefaultLocalState();
				}
			}
			this.ccdDefaultLocalRotations = new Quaternion[this.CCDBones.Length];
			for (int j = 0; j < this.CCDBones.Length; j++)
			{
				if (this.CCDBones[j] != null)
				{
					this.ccdDefaultLocalRotations[j] = this.CCDBones[j].localRotation;
				}
			}
			this.headLocalPosition = this.ik.references.head.localPosition;
			this.headLocalRotation = this.ik.references.head.localRotation;
			this.stretchLocalPositions = new Vector3[this.stretchBones.Length];
			this.stretchLocalRotations = new Quaternion[this.stretchBones.Length];
			for (int k = 0; k < this.stretchBones.Length; k++)
			{
				if (this.stretchBones[k] != null)
				{
					this.stretchLocalPositions[k] = this.stretchBones[k].localPosition;
					this.stretchLocalRotations[k] = this.stretchBones[k].localRotation;
				}
			}
			this.chestLocalPositions = new Vector3[this.chestBones.Length];
			this.chestLocalRotations = new Quaternion[this.chestBones.Length];
			for (int l = 0; l < this.chestBones.Length; l++)
			{
				if (this.chestBones[l] != null)
				{
					this.chestLocalPositions[l] = this.chestBones[l].localPosition;
					this.chestLocalRotations[l] = this.chestBones[l].localRotation;
				}
			}
			this.bendBonesCount = this.bendBones.Length;
			this.ccdBonesCount = this.CCDBones.Length;
			this.stretchBonesCount = this.stretchBones.Length;
			this.chestBonesCount = this.chestBones.Length;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		private void OnFixTransforms()
		{
			if (!base.enabled)
			{
				return;
			}
			foreach (FBBIKHeadEffector.BendBone bendBone in this.bendBones)
			{
				if (bendBone != null)
				{
					bendBone.FixTransforms();
				}
			}
			for (int j = 0; j < this.CCDBones.Length; j++)
			{
				if (this.CCDBones[j] != null)
				{
					this.CCDBones[j].localRotation = this.ccdDefaultLocalRotations[j];
				}
			}
			this.ik.references.head.localPosition = this.headLocalPosition;
			this.ik.references.head.localRotation = this.headLocalRotation;
			for (int k = 0; k < this.stretchBones.Length; k++)
			{
				if (this.stretchBones[k] != null)
				{
					this.stretchBones[k].localPosition = this.stretchLocalPositions[k];
					this.stretchBones[k].localRotation = this.stretchLocalRotations[k];
				}
			}
			for (int l = 0; l < this.chestBones.Length; l++)
			{
				if (this.chestBones[l] != null)
				{
					this.chestBones[l].localPosition = this.chestLocalPositions[l];
					this.chestBones[l].localRotation = this.chestLocalRotations[l];
				}
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000D410 File Offset: 0x0000B610
		private void OnPreRead()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.ik.solver.FABRIKPass = this.handsPullBody;
			if (this.bendBonesCount != this.bendBones.Length || this.ccdBonesCount != this.CCDBones.Length || this.stretchBonesCount != this.stretchBones.Length || this.chestBonesCount != this.chestBones.Length)
			{
				this.OnStoreDefaultLocalState();
			}
			this.ChestDirection();
			this.SpineBend();
			this.CCDPass();
			this.offset = base.transform.position - this.ik.references.head.position;
			this.shoulderDist = Vector3.Distance(this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position);
			this.leftShoulderDist = Vector3.Distance(this.ik.references.head.position, this.ik.references.leftUpperArm.position);
			this.rightShoulderDist = Vector3.Distance(this.ik.references.head.position, this.ik.references.rightUpperArm.position);
			this.headToBody = this.ik.solver.rootNode.position - this.ik.references.head.position;
			this.headToLeftThigh = this.ik.references.leftThigh.position - this.ik.references.head.position;
			this.headToRightThigh = this.ik.references.rightThigh.position - this.ik.references.head.position;
			this.leftShoulderPos = this.ik.references.leftUpperArm.position + this.offset * this.bodyWeight;
			this.rightShoulderPos = this.ik.references.rightUpperArm.position + this.offset * this.bodyWeight;
			this.chestRotation = Quaternion.LookRotation(this.ik.references.head.position - this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position - this.ik.references.leftUpperArm.position);
			if (this.OnPostHeadEffectorFK != null)
			{
				this.OnPostHeadEffectorFK();
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000D6FC File Offset: 0x0000B8FC
		private void SpineBend()
		{
			float num = this.bendWeight * this.ik.solver.IKPositionWeight;
			if (num <= 0f)
			{
				return;
			}
			if (this.bendBones.Length == 0)
			{
				return;
			}
			Quaternion quaternion = base.transform.rotation * Quaternion.Inverse(this.ik.references.root.rotation * this.headRotationRelativeToRoot);
			quaternion = QuaTools.ClampRotation(quaternion, this.bodyClampWeight, 2);
			float num2 = 1f / (float)this.bendBones.Length;
			for (int i = 0; i < this.bendBones.Length; i++)
			{
				if (this.bendBones[i].transform != null)
				{
					this.bendBones[i].transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, num2 * this.bendBones[i].weight * num) * this.bendBones[i].transform.rotation;
				}
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000D7F8 File Offset: 0x0000B9F8
		private void CCDPass()
		{
			float num = this.CCDWeight * this.ik.solver.IKPositionWeight;
			if (num <= 0f)
			{
				return;
			}
			for (int i = this.CCDBones.Length - 1; i > -1; i--)
			{
				Quaternion quaternion = Quaternion.FromToRotation(this.ik.references.head.position - this.CCDBones[i].position, base.transform.position - this.CCDBones[i].position) * this.CCDBones[i].rotation;
				float num2 = Mathf.Lerp((float)((this.CCDBones.Length - i) / this.CCDBones.Length), 1f, this.roll);
				float num3 = Quaternion.Angle(Quaternion.identity, quaternion);
				num3 = Mathf.Lerp(0f, num3, (this.damper - num3) / this.damper);
				this.CCDBones[i].rotation = Quaternion.RotateTowards(this.CCDBones[i].rotation, quaternion, num3 * num * num2);
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000D914 File Offset: 0x0000BB14
		private void Iterate(int iteration)
		{
			if (!base.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.leftShoulderPos = base.transform.position + (this.leftShoulderPos - base.transform.position).normalized * this.leftShoulderDist;
			this.rightShoulderPos = base.transform.position + (this.rightShoulderPos - base.transform.position).normalized * this.rightShoulderDist;
			this.Solve(ref this.leftShoulderPos, ref this.rightShoulderPos, this.shoulderDist);
			this.LerpSolverPosition(this.ik.solver.leftShoulderEffector, this.leftShoulderPos, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.leftShoulderEffector.positionOffset);
			this.LerpSolverPosition(this.ik.solver.rightShoulderEffector, this.rightShoulderPos, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.rightShoulderEffector.positionOffset);
			Quaternion to = Quaternion.LookRotation(base.transform.position - this.leftShoulderPos, this.rightShoulderPos - this.leftShoulderPos);
			Quaternion quaternion = QuaTools.FromToRotation(this.chestRotation, to);
			Vector3 b = quaternion * this.headToBody;
			this.LerpSolverPosition(this.ik.solver.bodyEffector, base.transform.position + b, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.bodyEffector.positionOffset - this.ik.solver.pullBodyOffset);
			Quaternion rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.thighWeight);
			Vector3 b2 = rotation * this.headToLeftThigh;
			Vector3 b3 = rotation * this.headToRightThigh;
			this.LerpSolverPosition(this.ik.solver.leftThighEffector, base.transform.position + b2, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.bodyEffector.positionOffset - this.ik.solver.pullBodyOffset + this.ik.solver.leftThighEffector.positionOffset);
			this.LerpSolverPosition(this.ik.solver.rightThighEffector, base.transform.position + b3, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.bodyEffector.positionOffset - this.ik.solver.pullBodyOffset + this.ik.solver.rightThighEffector.positionOffset);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000DC54 File Offset: 0x0000BE54
		private void OnPostUpdate()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			this.PostStretching();
			Quaternion quaternion = QuaTools.FromToRotation(this.ik.references.head.rotation, base.transform.rotation);
			quaternion = QuaTools.ClampRotation(quaternion, this.headClampWeight, 2);
			this.ik.references.head.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.rotationWeight * this.ik.solver.IKPositionWeight) * this.ik.references.head.rotation;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000DD04 File Offset: 0x0000BF04
		private void ChestDirection()
		{
			float num = this.chestDirectionWeight * this.ik.solver.IKPositionWeight;
			if (num <= 0f)
			{
				return;
			}
			bool flag = false;
			this.chestDirection = V3Tools.ClampDirection(this.chestDirection, this.ik.references.root.forward, 0.45f, 2, out flag);
			if (this.chestDirection == Vector3.zero)
			{
				return;
			}
			Quaternion quaternion = Quaternion.FromToRotation(this.ik.references.root.forward, this.chestDirection);
			quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, num * (1f / (float)this.chestBones.Length));
			foreach (Transform transform in this.chestBones)
			{
				transform.rotation = quaternion * transform.rotation;
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		private void PostStretching()
		{
			float num = this.postStretchWeight * this.ik.solver.IKPositionWeight;
			if (num > 0f)
			{
				Vector3 a = Vector3.ClampMagnitude(base.transform.position - this.ik.references.head.position, this.maxStretch);
				a *= num;
				this.stretchDamper = Mathf.Max(this.stretchDamper, 0f);
				if (this.stretchDamper > 0f)
				{
					a /= (1f + a.magnitude) * (1f + this.stretchDamper);
				}
				for (int i = 0; i < this.stretchBones.Length; i++)
				{
					if (this.stretchBones[i] != null)
					{
						this.stretchBones[i].position += a / (float)this.stretchBones.Length;
					}
				}
			}
			if (this.fixHead && this.ik.solver.IKPositionWeight > 0f)
			{
				this.ik.references.head.position = base.transform.position;
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000DF1E File Offset: 0x0000C11E
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
			effector.GetNode(this.ik.solver).solverPosition = Vector3.Lerp(effector.GetNode(this.ik.solver).solverPosition, position + offset, weight);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000DF5C File Offset: 0x0000C15C
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
			Vector3 a = pos2 - pos1;
			float magnitude = a.magnitude;
			if (magnitude == nominalDistance)
			{
				return;
			}
			if (magnitude == 0f)
			{
				return;
			}
			float num = 1f;
			num *= 1f - nominalDistance / magnitude;
			Vector3 b = a * num * 0.5f;
			pos1 += b;
			pos2 -= b;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000DFDC File Offset: 0x0000C1DC
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreRead = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPreRead, new IKSolver.UpdateDelegate(this.OnPreRead));
				IKSolverFullBodyBiped solver2 = this.ik.solver;
				solver2.OnPreIteration = (IKSolver.IterationDelegate)Delegate.Remove(solver2.OnPreIteration, new IKSolver.IterationDelegate(this.Iterate));
				IKSolverFullBodyBiped solver3 = this.ik.solver;
				solver3.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver3.OnPostUpdate, new IKSolver.UpdateDelegate(this.OnPostUpdate));
				IKSolverFullBodyBiped solver4 = this.ik.solver;
				solver4.OnStoreDefaultLocalState = (IKSolver.UpdateDelegate)Delegate.Remove(solver4.OnStoreDefaultLocalState, new IKSolver.UpdateDelegate(this.OnStoreDefaultLocalState));
				IKSolverFullBodyBiped solver5 = this.ik.solver;
				solver5.OnFixTransforms = (IKSolver.UpdateDelegate)Delegate.Remove(solver5.OnFixTransforms, new IKSolver.UpdateDelegate(this.OnFixTransforms));
			}
		}

		// Token: 0x04000194 RID: 404
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		// Token: 0x04000195 RID: 405
		[LargeHeader("Position")]
		[Tooltip("Master weight for positioning the head.")]
		[Range(0f, 1f)]
		public float positionWeight = 1f;

		// Token: 0x04000196 RID: 406
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight = 0.8f;

		// Token: 0x04000197 RID: 407
		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
		public float thighWeight = 0.8f;

		// Token: 0x04000198 RID: 408
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody = true;

		// Token: 0x04000199 RID: 409
		[LargeHeader("Rotation")]
		[Tooltip("The weight of rotating the head bone after solving")]
		[Range(0f, 1f)]
		public float rotationWeight;

		// Token: 0x0400019A RID: 410
		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight = 0.5f;

		// Token: 0x0400019B RID: 411
		[Tooltip("Clamping the rotation of the head")]
		[Range(0f, 1f)]
		public float headClampWeight = 0.5f;

		// Token: 0x0400019C RID: 412
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		[Range(0f, 1f)]
		public float bendWeight = 1f;

		// Token: 0x0400019D RID: 413
		[Tooltip("The bones to use for bending.")]
		public FBBIKHeadEffector.BendBone[] bendBones = new FBBIKHeadEffector.BendBone[0];

		// Token: 0x0400019E RID: 414
		[LargeHeader("CCD")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[Range(0f, 1f)]
		public float CCDWeight = 1f;

		// Token: 0x0400019F RID: 415
		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		// Token: 0x040001A0 RID: 416
		[Tooltip("Smoothing the CCD effect.")]
		[Range(0f, 1000f)]
		public float damper = 500f;

		// Token: 0x040001A1 RID: 417
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones = new Transform[0];

		// Token: 0x040001A2 RID: 418
		[LargeHeader("Stretching")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[Range(0f, 1f)]
		public float postStretchWeight = 1f;

		// Token: 0x040001A3 RID: 419
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch = 0.1f;

		// Token: 0x040001A4 RID: 420
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		// Token: 0x040001A5 RID: 421
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		// Token: 0x040001A6 RID: 422
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones = new Transform[0];

		// Token: 0x040001A7 RID: 423
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection = Vector3.forward;

		// Token: 0x040001A8 RID: 424
		[Range(0f, 1f)]
		public float chestDirectionWeight = 1f;

		// Token: 0x040001A9 RID: 425
		public Transform[] chestBones = new Transform[0];

		// Token: 0x040001AA RID: 426
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		// Token: 0x040001AB RID: 427
		private Vector3 offset;

		// Token: 0x040001AC RID: 428
		private Vector3 headToBody;

		// Token: 0x040001AD RID: 429
		private Vector3 shoulderCenterToHead;

		// Token: 0x040001AE RID: 430
		private Vector3 headToLeftThigh;

		// Token: 0x040001AF RID: 431
		private Vector3 headToRightThigh;

		// Token: 0x040001B0 RID: 432
		private Vector3 leftShoulderPos;

		// Token: 0x040001B1 RID: 433
		private Vector3 rightShoulderPos;

		// Token: 0x040001B2 RID: 434
		private float shoulderDist;

		// Token: 0x040001B3 RID: 435
		private float leftShoulderDist;

		// Token: 0x040001B4 RID: 436
		private float rightShoulderDist;

		// Token: 0x040001B5 RID: 437
		private Quaternion chestRotation;

		// Token: 0x040001B6 RID: 438
		private Quaternion headRotationRelativeToRoot;

		// Token: 0x040001B7 RID: 439
		private Quaternion[] ccdDefaultLocalRotations = new Quaternion[0];

		// Token: 0x040001B8 RID: 440
		private Vector3 headLocalPosition;

		// Token: 0x040001B9 RID: 441
		private Quaternion headLocalRotation;

		// Token: 0x040001BA RID: 442
		private Vector3[] stretchLocalPositions = new Vector3[0];

		// Token: 0x040001BB RID: 443
		private Quaternion[] stretchLocalRotations = new Quaternion[0];

		// Token: 0x040001BC RID: 444
		private Vector3[] chestLocalPositions = new Vector3[0];

		// Token: 0x040001BD RID: 445
		private Quaternion[] chestLocalRotations = new Quaternion[0];

		// Token: 0x040001BE RID: 446
		private int bendBonesCount;

		// Token: 0x040001BF RID: 447
		private int ccdBonesCount;

		// Token: 0x040001C0 RID: 448
		private int stretchBonesCount;

		// Token: 0x040001C1 RID: 449
		private int chestBonesCount;

		// Token: 0x020000DF RID: 223
		[Serializable]
		public class BendBone
		{
			// Token: 0x060006AD RID: 1709 RVA: 0x0002C68F File Offset: 0x0002A88F
			public BendBone()
			{
			}

			// Token: 0x060006AE RID: 1710 RVA: 0x0002C6AD File Offset: 0x0002A8AD
			public BendBone(Transform transform, float weight)
			{
				this.transform = transform;
				this.weight = weight;
			}

			// Token: 0x060006AF RID: 1711 RVA: 0x0002C6D9 File Offset: 0x0002A8D9
			public void StoreDefaultLocalState()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x060006B0 RID: 1712 RVA: 0x0002C6EC File Offset: 0x0002A8EC
			public void FixTransforms()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0400064A RID: 1610
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			// Token: 0x0400064B RID: 1611
			[Tooltip("The weight of rotating this bone.")]
			[Range(0f, 1f)]
			public float weight = 0.5f;

			// Token: 0x0400064C RID: 1612
			private Quaternion defaultLocalRotation = Quaternion.identity;
		}
	}
}
