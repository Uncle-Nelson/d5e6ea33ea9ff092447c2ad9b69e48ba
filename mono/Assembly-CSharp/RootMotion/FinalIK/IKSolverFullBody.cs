using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000056 RID: 86
	[Serializable]
	public class IKSolverFullBody : IKSolver
	{
		// Token: 0x0600030D RID: 781 RVA: 0x00013AC0 File Offset: 0x00011CC0
		public IKEffector GetEffector(Transform t)
		{
			for (int i = 0; i < this.effectors.Length; i++)
			{
				if (this.effectors[i].bone == t)
				{
					return this.effectors[i];
				}
			}
			return null;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00013B00 File Offset: 0x00011D00
		public FBIKChain GetChain(Transform transform)
		{
			int chainIndex = this.GetChainIndex(transform);
			if (chainIndex == -1)
			{
				return null;
			}
			return this.chain[chainIndex];
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00013B24 File Offset: 0x00011D24
		public int GetChainIndex(Transform transform)
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				for (int j = 0; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == transform)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00013B7D File Offset: 0x00011D7D
		public IKSolver.Node GetNode(int chainIndex, int nodeIndex)
		{
			return this.chain[chainIndex].nodes[nodeIndex];
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00013B8E File Offset: 0x00011D8E
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
			chainIndex = this.GetChainIndex(transform);
			if (chainIndex == -1)
			{
				nodeIndex = -1;
				return;
			}
			nodeIndex = this.chain[chainIndex].GetNodeIndex(transform);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00013BB4 File Offset: 0x00011DB4
		public override IKSolver.Point[] GetPoints()
		{
			int num = 0;
			for (int i = 0; i < this.chain.Length; i++)
			{
				num += this.chain[i].nodes.Length;
			}
			IKSolver.Point[] array = new IKSolver.Point[num];
			int num2 = 0;
			for (int j = 0; j < this.chain.Length; j++)
			{
				for (int k = 0; k < this.chain[j].nodes.Length; k++)
				{
					array[num2] = this.chain[j].nodes[k];
					num2++;
				}
			}
			return array;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00013C40 File Offset: 0x00011E40
		public override IKSolver.Point GetPoint(Transform transform)
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				for (int j = 0; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == transform)
					{
						return this.chain[i].nodes[j];
					}
				}
			}
			return null;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00013CA8 File Offset: 0x00011EA8
		public override bool IsValid(ref string message)
		{
			if (this.chain == null)
			{
				message = "FBIK chain is null, can't initiate solver.";
				return false;
			}
			if (this.chain.Length == 0)
			{
				message = "FBIK chain length is 0, can't initiate solver.";
				return false;
			}
			for (int i = 0; i < this.chain.Length; i++)
			{
				if (!this.chain[i].IsValid(ref message))
				{
					return false;
				}
			}
			IKEffector[] array = this.effectors;
			for (int j = 0; j < array.Length; j++)
			{
				if (!array[j].IsValid(this, ref message))
				{
					return false;
				}
			}
			if (!this.spineMapping.IsValid(this, ref message))
			{
				return false;
			}
			IKMappingLimb[] array2 = this.limbMappings;
			for (int j = 0; j < array2.Length; j++)
			{
				if (!array2[j].IsValid(this, ref message))
				{
					return false;
				}
			}
			IKMappingBone[] array3 = this.boneMappings;
			for (int j = 0; j < array3.Length; j++)
			{
				if (!array3[j].IsValid(this, ref message))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00013D7C File Offset: 0x00011F7C
		public override void StoreDefaultLocalState()
		{
			this.spineMapping.StoreDefaultLocalState();
			for (int i = 0; i < this.limbMappings.Length; i++)
			{
				this.limbMappings[i].StoreDefaultLocalState();
			}
			for (int j = 0; j < this.boneMappings.Length; j++)
			{
				this.boneMappings[j].StoreDefaultLocalState();
			}
			if (this.OnStoreDefaultLocalState != null)
			{
				this.OnStoreDefaultLocalState();
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00013DE8 File Offset: 0x00011FE8
		public override void FixTransforms()
		{
			if (!base.initiated)
			{
				return;
			}
			if (this.IKPositionWeight <= 0f)
			{
				return;
			}
			this.spineMapping.FixTransforms();
			for (int i = 0; i < this.limbMappings.Length; i++)
			{
				this.limbMappings[i].FixTransforms();
			}
			for (int j = 0; j < this.boneMappings.Length; j++)
			{
				this.boneMappings[j].FixTransforms();
			}
			if (this.OnFixTransforms != null)
			{
				this.OnFixTransforms();
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00013E6C File Offset: 0x0001206C
		protected override void OnInitiate()
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				this.chain[i].Initiate(this);
			}
			IKEffector[] array = this.effectors;
			for (int j = 0; j < array.Length; j++)
			{
				array[j].Initiate(this);
			}
			this.spineMapping.Initiate(this);
			IKMappingBone[] array2 = this.boneMappings;
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j].Initiate(this);
			}
			IKMappingLimb[] array3 = this.limbMappings;
			for (int j = 0; j < array3.Length; j++)
			{
				array3[j].Initiate(this);
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00013F04 File Offset: 0x00012104
		protected override void OnUpdate()
		{
			if (this.IKPositionWeight <= 0f)
			{
				for (int i = 0; i < this.effectors.Length; i++)
				{
					this.effectors[i].positionOffset = Vector3.zero;
				}
				return;
			}
			if (this.chain.Length == 0)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 0f, 1f);
			if (this.OnPreRead != null)
			{
				this.OnPreRead();
			}
			this.ReadPose();
			if (this.OnPreSolve != null)
			{
				this.OnPreSolve();
			}
			this.Solve();
			if (this.OnPostSolve != null)
			{
				this.OnPostSolve();
			}
			this.WritePose();
			for (int j = 0; j < this.effectors.Length; j++)
			{
				this.effectors[j].OnPostWrite();
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00013FD4 File Offset: 0x000121D4
		protected virtual void ReadPose()
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				if (this.chain[i].bendConstraint.initiated)
				{
					this.chain[i].bendConstraint.LimitBend(this.IKPositionWeight, this.GetEffector(this.chain[i].nodes[2].transform).positionWeight);
				}
			}
			for (int j = 0; j < this.effectors.Length; j++)
			{
				this.effectors[j].ResetOffset(this);
			}
			for (int k = 0; k < this.effectors.Length; k++)
			{
				this.effectors[k].OnPreSolve(this);
			}
			for (int l = 0; l < this.chain.Length; l++)
			{
				this.chain[l].ReadPose(this, this.iterations > 0);
			}
			if (this.iterations > 0)
			{
				this.spineMapping.ReadPose();
				for (int m = 0; m < this.boneMappings.Length; m++)
				{
					this.boneMappings[m].ReadPose();
				}
			}
			for (int n = 0; n < this.limbMappings.Length; n++)
			{
				this.limbMappings[n].ReadPose();
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0001410C File Offset: 0x0001230C
		protected virtual void Solve()
		{
			if (this.iterations > 0)
			{
				for (int i = 0; i < (this.FABRIKPass ? this.iterations : 1); i++)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 0; j < this.effectors.Length; j++)
					{
						if (this.effectors[j].isEndEffector)
						{
							this.effectors[j].Update(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[0].Push(this);
						if (this.FABRIKPass)
						{
							this.chain[0].Reach(this);
						}
						for (int k = 0; k < this.effectors.Length; k++)
						{
							if (!this.effectors[k].isEndEffector)
							{
								this.effectors[k].Update(this);
							}
						}
					}
					this.chain[0].SolveTrigonometric(this, false);
					if (this.FABRIKPass)
					{
						this.chain[0].Stage1(this);
						for (int l = 0; l < this.effectors.Length; l++)
						{
							if (!this.effectors[l].isEndEffector)
							{
								this.effectors[l].Update(this);
							}
						}
						this.chain[0].Stage2(this, this.chain[0].nodes[0].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 0; m < this.effectors.Length; m++)
			{
				if (this.effectors[m].isEndEffector)
				{
					this.effectors[m].Update(this);
				}
			}
			this.ApplyBendConstraints();
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000142C2 File Offset: 0x000124C2
		protected virtual void ApplyBendConstraints()
		{
			this.chain[0].SolveTrigonometric(this, true);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000142D4 File Offset: 0x000124D4
		protected virtual void WritePose()
		{
			if (this.IKPositionWeight <= 0f)
			{
				return;
			}
			if (this.iterations > 0)
			{
				this.spineMapping.WritePose(this);
				for (int i = 0; i < this.boneMappings.Length; i++)
				{
					this.boneMappings[i].WritePose(this.IKPositionWeight);
				}
			}
			for (int j = 0; j < this.limbMappings.Length; j++)
			{
				this.limbMappings[j].WritePose(this, this.iterations > 0);
			}
		}

		// Token: 0x04000253 RID: 595
		[Range(0f, 10f)]
		public int iterations = 4;

		// Token: 0x04000254 RID: 596
		public FBIKChain[] chain = new FBIKChain[0];

		// Token: 0x04000255 RID: 597
		public IKEffector[] effectors = new IKEffector[0];

		// Token: 0x04000256 RID: 598
		public IKMappingSpine spineMapping = new IKMappingSpine();

		// Token: 0x04000257 RID: 599
		public IKMappingBone[] boneMappings = new IKMappingBone[0];

		// Token: 0x04000258 RID: 600
		public IKMappingLimb[] limbMappings = new IKMappingLimb[0];

		// Token: 0x04000259 RID: 601
		public bool FABRIKPass = true;

		// Token: 0x0400025A RID: 602
		public IKSolver.UpdateDelegate OnPreRead;

		// Token: 0x0400025B RID: 603
		public IKSolver.UpdateDelegate OnPreSolve;

		// Token: 0x0400025C RID: 604
		public IKSolver.IterationDelegate OnPreIteration;

		// Token: 0x0400025D RID: 605
		public IKSolver.IterationDelegate OnPostIteration;

		// Token: 0x0400025E RID: 606
		public IKSolver.UpdateDelegate OnPreBend;

		// Token: 0x0400025F RID: 607
		public IKSolver.UpdateDelegate OnPostSolve;

		// Token: 0x04000260 RID: 608
		public IKSolver.UpdateDelegate OnStoreDefaultLocalState;

		// Token: 0x04000261 RID: 609
		public IKSolver.UpdateDelegate OnFixTransforms;
	}
}
