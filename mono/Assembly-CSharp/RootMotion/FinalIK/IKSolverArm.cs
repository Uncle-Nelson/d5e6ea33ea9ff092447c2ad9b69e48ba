using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000052 RID: 82
	[Serializable]
	public class IKSolverArm : IKSolver
	{
		// Token: 0x060002D7 RID: 727 RVA: 0x00011D14 File Offset: 0x0000FF14
		public override bool IsValid(ref string message)
		{
			if (this.chest.transform == null || this.shoulder.transform == null || this.upperArm.transform == null || this.forearm.transform == null || this.hand.transform == null)
			{
				message = "Please assign all bone slots of the Arm IK solver.";
				return false;
			}
			Object[] objects = new Transform[]
			{
				this.chest.transform,
				this.shoulder.transform,
				this.upperArm.transform,
				this.forearm.transform,
				this.hand.transform
			};
			Transform transform = (Transform)Hierarchy.ContainsDuplicate(objects);
			if (transform != null)
			{
				message = transform.name + " is represented multiple times in the ArmIK.";
				return false;
			}
			return true;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00011E00 File Offset: 0x00010000
		public void SetRotationWeight(float weight)
		{
			this.IKRotationWeight = weight;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00011E0C File Offset: 0x0001000C
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			this.chest.transform = chest;
			this.shoulder.transform = shoulder;
			this.upperArm.transform = upperArm;
			this.forearm.transform = forearm;
			this.hand.transform = hand;
			base.Initiate(root);
			return base.initiated;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00011E65 File Offset: 0x00010065
		public override IKSolver.Point[] GetPoints()
		{
			return new IKSolver.Point[]
			{
				this.chest,
				this.shoulder,
				this.upperArm,
				this.forearm,
				this.hand
			};
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00011E9C File Offset: 0x0001009C
		public override IKSolver.Point GetPoint(Transform transform)
		{
			if (this.chest.transform == transform)
			{
				return this.chest;
			}
			if (this.shoulder.transform == transform)
			{
				return this.shoulder;
			}
			if (this.upperArm.transform == transform)
			{
				return this.upperArm;
			}
			if (this.forearm.transform == transform)
			{
				return this.forearm;
			}
			if (this.hand.transform == transform)
			{
				return this.hand;
			}
			return null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00011F2C File Offset: 0x0001012C
		public override void StoreDefaultLocalState()
		{
			this.shoulder.StoreDefaultLocalState();
			this.upperArm.StoreDefaultLocalState();
			this.forearm.StoreDefaultLocalState();
			this.hand.StoreDefaultLocalState();
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00011F5A File Offset: 0x0001015A
		public override void FixTransforms()
		{
			if (!base.initiated)
			{
				return;
			}
			this.shoulder.FixTransform();
			this.upperArm.FixTransform();
			this.forearm.FixTransform();
			this.hand.FixTransform();
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00011F91 File Offset: 0x00010191
		protected override void OnInitiate()
		{
			this.IKPosition = this.hand.transform.position;
			this.IKRotation = this.hand.transform.rotation;
			this.Read();
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00011FC5 File Offset: 0x000101C5
		protected override void OnUpdate()
		{
			this.Read();
			this.Solve();
			this.Write();
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00011FD9 File Offset: 0x000101D9
		private void Solve()
		{
			this.arm.PreSolve(1f);
			this.arm.ApplyOffsets(1f);
			this.arm.Solve(this.isLeft);
			this.arm.ResetOffsets();
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00012018 File Offset: 0x00010218
		private void Read()
		{
			this.arm.IKPosition = this.IKPosition;
			this.arm.positionWeight = this.IKPositionWeight;
			this.arm.IKRotation = this.IKRotation;
			this.arm.rotationWeight = this.IKRotationWeight;
			this.positions[0] = this.root.position;
			this.positions[1] = this.chest.transform.position;
			this.positions[2] = this.shoulder.transform.position;
			this.positions[3] = this.upperArm.transform.position;
			this.positions[4] = this.forearm.transform.position;
			this.positions[5] = this.hand.transform.position;
			this.rotations[0] = this.root.rotation;
			this.rotations[1] = this.chest.transform.rotation;
			this.rotations[2] = this.shoulder.transform.rotation;
			this.rotations[3] = this.upperArm.transform.rotation;
			this.rotations[4] = this.forearm.transform.rotation;
			this.rotations[5] = this.hand.transform.rotation;
			this.arm.Read(this.positions, this.rotations, false, false, true, false, false, 1, 2);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000121D0 File Offset: 0x000103D0
		private void Write()
		{
			this.arm.Write(ref this.positions, ref this.rotations);
			this.shoulder.transform.rotation = this.rotations[2];
			this.upperArm.transform.rotation = this.rotations[3];
			this.forearm.transform.rotation = this.rotations[4];
			this.hand.transform.rotation = this.rotations[5];
			this.forearm.transform.position = this.positions[4];
			this.hand.transform.position = this.positions[5];
		}

		// Token: 0x0400023E RID: 574
		[Range(0f, 1f)]
		public float IKRotationWeight = 1f;

		// Token: 0x0400023F RID: 575
		public Quaternion IKRotation = Quaternion.identity;

		// Token: 0x04000240 RID: 576
		public IKSolver.Point chest = new IKSolver.Point();

		// Token: 0x04000241 RID: 577
		public IKSolver.Point shoulder = new IKSolver.Point();

		// Token: 0x04000242 RID: 578
		public IKSolver.Point upperArm = new IKSolver.Point();

		// Token: 0x04000243 RID: 579
		public IKSolver.Point forearm = new IKSolver.Point();

		// Token: 0x04000244 RID: 580
		public IKSolver.Point hand = new IKSolver.Point();

		// Token: 0x04000245 RID: 581
		public bool isLeft;

		// Token: 0x04000246 RID: 582
		public IKSolverVR.Arm arm = new IKSolverVR.Arm();

		// Token: 0x04000247 RID: 583
		private Vector3[] positions = new Vector3[6];

		// Token: 0x04000248 RID: 584
		private Quaternion[] rotations = new Quaternion[6];
	}
}
