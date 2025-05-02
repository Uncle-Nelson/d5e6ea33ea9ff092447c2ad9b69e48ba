using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000A4 RID: 164
	public class MotionAbsorb : OffsetModifier
	{
		// Token: 0x060005A9 RID: 1449 RVA: 0x00026A37 File Offset: 0x00024C37
		protected override void Start()
		{
			base.Start();
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPostUpdate, new IKSolver.UpdateDelegate(this.AfterIK));
			this.initialMode = this.mode;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00026A78 File Offset: 0x00024C78
		private void OnCollisionEnter(Collision c)
		{
			if (this.timer > 0f)
			{
				return;
			}
			this.timer = 1f;
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].SetToBone(this.ik.solver, this.mode);
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00026AD0 File Offset: 0x00024CD0
		protected override void OnModifyOffset()
		{
			if (this.timer <= 0f)
			{
				return;
			}
			this.mode = this.initialMode;
			this.timer -= Time.deltaTime * this.falloffSpeed;
			this.w = this.falloff.Evaluate(this.timer);
			if (this.mode == MotionAbsorb.Mode.Position)
			{
				for (int i = 0; i < this.absorbers.Length; i++)
				{
					this.absorbers[i].UpdateEffectorWeights(this.w * this.weight);
				}
				return;
			}
			for (int j = 0; j < this.absorbers.Length; j++)
			{
				this.absorbers[j].SetPosition(this.w * this.weight);
			}
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00026B8C File Offset: 0x00024D8C
		private void AfterIK()
		{
			if (this.timer <= 0f)
			{
				return;
			}
			if (this.mode == MotionAbsorb.Mode.Position)
			{
				return;
			}
			for (int i = 0; i < this.absorbers.Length; i++)
			{
				this.absorbers[i].SetRotation(this.w * this.weight);
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00026BE0 File Offset: 0x00024DE0
		protected override void OnDestroy()
		{
			base.OnDestroy();
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPostUpdate, new IKSolver.UpdateDelegate(this.AfterIK));
			}
		}

		// Token: 0x040004CC RID: 1228
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public MotionAbsorb.Mode mode;

		// Token: 0x040004CD RID: 1229
		[Tooltip("Array containing the absorbers")]
		public MotionAbsorb.Absorber[] absorbers;

		// Token: 0x040004CE RID: 1230
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		// Token: 0x040004CF RID: 1231
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed = 1f;

		// Token: 0x040004D0 RID: 1232
		private float timer;

		// Token: 0x040004D1 RID: 1233
		private float w;

		// Token: 0x040004D2 RID: 1234
		private MotionAbsorb.Mode initialMode;

		// Token: 0x02000121 RID: 289
		[Serializable]
		public enum Mode
		{
			// Token: 0x04000859 RID: 2137
			Position,
			// Token: 0x0400085A RID: 2138
			PositionOffset
		}

		// Token: 0x02000122 RID: 290
		[Serializable]
		public class Absorber
		{
			// Token: 0x0600081E RID: 2078 RVA: 0x000352AC File Offset: 0x000334AC
			public void SetToBone(IKSolverFullBodyBiped solver, MotionAbsorb.Mode mode)
			{
				this.e = solver.GetEffector(this.effector);
				if (mode == MotionAbsorb.Mode.Position)
				{
					this.e.position = this.e.bone.position;
					this.e.rotation = this.e.bone.rotation;
					return;
				}
				if (mode != MotionAbsorb.Mode.PositionOffset)
				{
					return;
				}
				this.position = this.e.bone.position;
				this.rotation = this.e.bone.rotation;
			}

			// Token: 0x0600081F RID: 2079 RVA: 0x00035336 File Offset: 0x00033536
			public void UpdateEffectorWeights(float w)
			{
				this.e.positionWeight = w * this.weight;
				this.e.rotationWeight = w * this.weight;
			}

			// Token: 0x06000820 RID: 2080 RVA: 0x00035360 File Offset: 0x00033560
			public void SetPosition(float w)
			{
				this.e.positionOffset += (this.position - this.e.bone.position) * w * this.weight;
			}

			// Token: 0x06000821 RID: 2081 RVA: 0x000353AF File Offset: 0x000335AF
			public void SetRotation(float w)
			{
				this.e.bone.rotation = Quaternion.Slerp(this.e.bone.rotation, this.rotation, w * this.weight);
			}

			// Token: 0x0400085B RID: 2139
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			// Token: 0x0400085C RID: 2140
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight = 1f;

			// Token: 0x0400085D RID: 2141
			private Vector3 position;

			// Token: 0x0400085E RID: 2142
			private Quaternion rotation = Quaternion.identity;

			// Token: 0x0400085F RID: 2143
			private IKEffector e;
		}
	}
}
