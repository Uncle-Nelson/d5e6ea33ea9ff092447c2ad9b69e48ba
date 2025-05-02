using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200005B RID: 91
	[Serializable]
	public class IKSolverLeg : IKSolver
	{
		// Token: 0x0600035E RID: 862 RVA: 0x00015B2C File Offset: 0x00013D2C
		public override bool IsValid(ref string message)
		{
			if (this.pelvis.transform == null || this.thigh.transform == null || this.calf.transform == null || this.foot.transform == null || this.toe.transform == null)
			{
				message = "Please assign all bone slots of the Leg IK solver.";
				return false;
			}
			Object[] objects = new Transform[]
			{
				this.pelvis.transform,
				this.thigh.transform,
				this.calf.transform,
				this.foot.transform,
				this.toe.transform
			};
			Transform transform = (Transform)Hierarchy.ContainsDuplicate(objects);
			if (transform != null)
			{
				message = transform.name + " is represented multiple times in the LegIK.";
				return false;
			}
			return true;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00015C18 File Offset: 0x00013E18
		public void SetRotationWeight(float weight)
		{
			this.IKRotationWeight = weight;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00015C24 File Offset: 0x00013E24
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			this.pelvis.transform = pelvis;
			this.thigh.transform = thigh;
			this.calf.transform = calf;
			this.foot.transform = foot;
			this.toe.transform = toe;
			base.Initiate(root);
			return base.initiated;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00015C7D File Offset: 0x00013E7D
		public override IKSolver.Point[] GetPoints()
		{
			return new IKSolver.Point[]
			{
				this.pelvis,
				this.thigh,
				this.calf,
				this.foot,
				this.toe
			};
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00015CB4 File Offset: 0x00013EB4
		public override IKSolver.Point GetPoint(Transform transform)
		{
			if (this.pelvis.transform == transform)
			{
				return this.pelvis;
			}
			if (this.thigh.transform == transform)
			{
				return this.thigh;
			}
			if (this.calf.transform == transform)
			{
				return this.calf;
			}
			if (this.foot.transform == transform)
			{
				return this.foot;
			}
			if (this.toe.transform == transform)
			{
				return this.toe;
			}
			return null;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00015D44 File Offset: 0x00013F44
		public override void StoreDefaultLocalState()
		{
			this.thigh.StoreDefaultLocalState();
			this.calf.StoreDefaultLocalState();
			this.foot.StoreDefaultLocalState();
			this.toe.StoreDefaultLocalState();
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00015D72 File Offset: 0x00013F72
		public override void FixTransforms()
		{
			if (!base.initiated)
			{
				return;
			}
			this.thigh.FixTransform();
			this.calf.FixTransform();
			this.foot.FixTransform();
			this.toe.FixTransform();
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00015DA9 File Offset: 0x00013FA9
		protected override void OnInitiate()
		{
			this.IKPosition = this.toe.transform.position;
			this.IKRotation = this.toe.transform.rotation;
			this.Read();
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00015DDD File Offset: 0x00013FDD
		protected override void OnUpdate()
		{
			this.Read();
			this.Solve();
			this.Write();
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00015DF4 File Offset: 0x00013FF4
		private void Solve()
		{
			this.leg.heelPositionOffset += this.heelOffset;
			this.leg.PreSolve(1f);
			this.leg.ApplyOffsets(1f);
			this.leg.Solve(true);
			this.leg.ResetOffsets();
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00015E54 File Offset: 0x00014054
		private void Read()
		{
			this.leg.IKPosition = this.IKPosition;
			this.leg.positionWeight = this.IKPositionWeight;
			this.leg.IKRotation = this.IKRotation;
			this.leg.rotationWeight = this.IKRotationWeight;
			this.positions[0] = this.root.position;
			this.positions[1] = this.pelvis.transform.position;
			this.positions[2] = this.thigh.transform.position;
			this.positions[3] = this.calf.transform.position;
			this.positions[4] = this.foot.transform.position;
			this.positions[5] = this.toe.transform.position;
			this.rotations[0] = this.root.rotation;
			this.rotations[1] = this.pelvis.transform.rotation;
			this.rotations[2] = this.thigh.transform.rotation;
			this.rotations[3] = this.calf.transform.rotation;
			this.rotations[4] = this.foot.transform.rotation;
			this.rotations[5] = this.toe.transform.rotation;
			this.leg.Read(this.positions, this.rotations, false, false, false, true, true, 1, 2);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0001600C File Offset: 0x0001420C
		private void Write()
		{
			this.leg.Write(ref this.positions, ref this.rotations);
			this.thigh.transform.rotation = this.rotations[2];
			this.calf.transform.rotation = this.rotations[3];
			this.foot.transform.rotation = this.rotations[4];
			this.toe.transform.rotation = this.rotations[5];
			this.calf.transform.position = this.positions[3];
			this.foot.transform.position = this.positions[4];
		}

		// Token: 0x0400027F RID: 639
		[Range(0f, 1f)]
		public float IKRotationWeight = 1f;

		// Token: 0x04000280 RID: 640
		public Quaternion IKRotation = Quaternion.identity;

		// Token: 0x04000281 RID: 641
		public IKSolver.Point pelvis = new IKSolver.Point();

		// Token: 0x04000282 RID: 642
		public IKSolver.Point thigh = new IKSolver.Point();

		// Token: 0x04000283 RID: 643
		public IKSolver.Point calf = new IKSolver.Point();

		// Token: 0x04000284 RID: 644
		public IKSolver.Point foot = new IKSolver.Point();

		// Token: 0x04000285 RID: 645
		public IKSolver.Point toe = new IKSolver.Point();

		// Token: 0x04000286 RID: 646
		public IKSolverVR.Leg leg = new IKSolverVR.Leg();

		// Token: 0x04000287 RID: 647
		public Vector3 heelOffset;

		// Token: 0x04000288 RID: 648
		private Vector3[] positions = new Vector3[6];

		// Token: 0x04000289 RID: 649
		private Quaternion[] rotations = new Quaternion[6];
	}
}
