using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000059 RID: 89
	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600031E RID: 798 RVA: 0x000143B0 File Offset: 0x000125B0
		public IKEffector bodyEffector
		{
			get
			{
				return this.GetEffector(FullBodyBipedEffector.Body);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600031F RID: 799 RVA: 0x000143B9 File Offset: 0x000125B9
		public IKEffector leftShoulderEffector
		{
			get
			{
				return this.GetEffector(FullBodyBipedEffector.LeftShoulder);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000320 RID: 800 RVA: 0x000143C2 File Offset: 0x000125C2
		public IKEffector rightShoulderEffector
		{
			get
			{
				return this.GetEffector(FullBodyBipedEffector.RightShoulder);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000321 RID: 801 RVA: 0x000143CB File Offset: 0x000125CB
		public IKEffector leftThighEffector
		{
			get
			{
				return this.GetEffector(FullBodyBipedEffector.LeftThigh);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000322 RID: 802 RVA: 0x000143D4 File Offset: 0x000125D4
		public IKEffector rightThighEffector
		{
			get
			{
				return this.GetEffector(FullBodyBipedEffector.RightThigh);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000323 RID: 803 RVA: 0x000143DD File Offset: 0x000125DD
		public IKEffector leftHandEffector
		{
			get
			{
				return this.GetEffector(FullBodyBipedEffector.LeftHand);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000324 RID: 804 RVA: 0x000143E6 File Offset: 0x000125E6
		public IKEffector rightHandEffector
		{
			get
			{
				return this.GetEffector(FullBodyBipedEffector.RightHand);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000325 RID: 805 RVA: 0x000143EF File Offset: 0x000125EF
		public IKEffector leftFootEffector
		{
			get
			{
				return this.GetEffector(FullBodyBipedEffector.LeftFoot);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000326 RID: 806 RVA: 0x000143F8 File Offset: 0x000125F8
		public IKEffector rightFootEffector
		{
			get
			{
				return this.GetEffector(FullBodyBipedEffector.RightFoot);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00014401 File Offset: 0x00012601
		public FBIKChain leftArmChain
		{
			get
			{
				return this.chain[1];
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0001440B File Offset: 0x0001260B
		public FBIKChain rightArmChain
		{
			get
			{
				return this.chain[2];
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00014415 File Offset: 0x00012615
		public FBIKChain leftLegChain
		{
			get
			{
				return this.chain[3];
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0001441F File Offset: 0x0001261F
		public FBIKChain rightLegChain
		{
			get
			{
				return this.chain[4];
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00014429 File Offset: 0x00012629
		public IKMappingLimb leftArmMapping
		{
			get
			{
				return this.limbMappings[0];
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00014433 File Offset: 0x00012633
		public IKMappingLimb rightArmMapping
		{
			get
			{
				return this.limbMappings[1];
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0001443D File Offset: 0x0001263D
		public IKMappingLimb leftLegMapping
		{
			get
			{
				return this.limbMappings[2];
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00014447 File Offset: 0x00012647
		public IKMappingLimb rightLegMapping
		{
			get
			{
				return this.limbMappings[3];
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00014451 File Offset: 0x00012651
		public IKMappingBone headMapping
		{
			get
			{
				return this.boneMappings[0];
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0001445B File Offset: 0x0001265B
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
			this.GetChain(c).pull = pull;
			this.GetChain(c).reach = reach;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00014477 File Offset: 0x00012677
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
			this.GetEffector(effector).positionWeight = Mathf.Clamp(positionWeight, 0f, 1f);
			this.GetEffector(effector).rotationWeight = Mathf.Clamp(rotationWeight, 0f, 1f);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000144B1 File Offset: 0x000126B1
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			switch (c)
			{
			case FullBodyBipedChain.LeftArm:
				return this.chain[1];
			case FullBodyBipedChain.RightArm:
				return this.chain[2];
			case FullBodyBipedChain.LeftLeg:
				return this.chain[3];
			case FullBodyBipedChain.RightLeg:
				return this.chain[4];
			default:
				return null;
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000144F0 File Offset: 0x000126F0
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			switch (effector)
			{
			case FullBodyBipedEffector.Body:
				return this.chain[0];
			case FullBodyBipedEffector.LeftShoulder:
				return this.chain[1];
			case FullBodyBipedEffector.RightShoulder:
				return this.chain[2];
			case FullBodyBipedEffector.LeftThigh:
				return this.chain[3];
			case FullBodyBipedEffector.RightThigh:
				return this.chain[4];
			case FullBodyBipedEffector.LeftHand:
				return this.chain[1];
			case FullBodyBipedEffector.RightHand:
				return this.chain[2];
			case FullBodyBipedEffector.LeftFoot:
				return this.chain[3];
			case FullBodyBipedEffector.RightFoot:
				return this.chain[4];
			default:
				return null;
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0001457C File Offset: 0x0001277C
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			switch (effector)
			{
			case FullBodyBipedEffector.Body:
				return this.effectors[0];
			case FullBodyBipedEffector.LeftShoulder:
				return this.effectors[1];
			case FullBodyBipedEffector.RightShoulder:
				return this.effectors[2];
			case FullBodyBipedEffector.LeftThigh:
				return this.effectors[3];
			case FullBodyBipedEffector.RightThigh:
				return this.effectors[4];
			case FullBodyBipedEffector.LeftHand:
				return this.effectors[5];
			case FullBodyBipedEffector.RightHand:
				return this.effectors[6];
			case FullBodyBipedEffector.LeftFoot:
				return this.effectors[7];
			case FullBodyBipedEffector.RightFoot:
				return this.effectors[8];
			default:
				return null;
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00014607 File Offset: 0x00012807
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			switch (c)
			{
			case FullBodyBipedChain.LeftArm:
				return this.effectors[5];
			case FullBodyBipedChain.RightArm:
				return this.effectors[6];
			case FullBodyBipedChain.LeftLeg:
				return this.effectors[7];
			case FullBodyBipedChain.RightLeg:
				return this.effectors[8];
			default:
				return null;
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00014646 File Offset: 0x00012846
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			switch (chain)
			{
			case FullBodyBipedChain.LeftArm:
				return this.limbMappings[0];
			case FullBodyBipedChain.RightArm:
				return this.limbMappings[1];
			case FullBodyBipedChain.LeftLeg:
				return this.limbMappings[2];
			case FullBodyBipedChain.RightLeg:
				return this.limbMappings[3];
			default:
				return null;
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00014688 File Offset: 0x00012888
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			switch (effector)
			{
			case FullBodyBipedEffector.LeftShoulder:
				return this.limbMappings[0];
			case FullBodyBipedEffector.RightShoulder:
				return this.limbMappings[1];
			case FullBodyBipedEffector.LeftThigh:
				return this.limbMappings[2];
			case FullBodyBipedEffector.RightThigh:
				return this.limbMappings[3];
			case FullBodyBipedEffector.LeftHand:
				return this.limbMappings[0];
			case FullBodyBipedEffector.RightHand:
				return this.limbMappings[1];
			case FullBodyBipedEffector.LeftFoot:
				return this.limbMappings[2];
			case FullBodyBipedEffector.RightFoot:
				return this.limbMappings[3];
			default:
				return null;
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00014708 File Offset: 0x00012908
		public IKMappingSpine GetSpineMapping()
		{
			return this.spineMapping;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00014710 File Offset: 0x00012910
		public IKMappingBone GetHeadMapping()
		{
			return this.boneMappings[0];
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0001471C File Offset: 0x0001291C
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			switch (limb)
			{
			case FullBodyBipedChain.LeftArm:
				return this.chain[1].bendConstraint;
			case FullBodyBipedChain.RightArm:
				return this.chain[2].bendConstraint;
			case FullBodyBipedChain.LeftLeg:
				return this.chain[3].bendConstraint;
			case FullBodyBipedChain.RightLeg:
				return this.chain[4].bendConstraint;
			default:
				return null;
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0001477C File Offset: 0x0001297C
		public override bool IsValid(ref string message)
		{
			if (!base.IsValid(ref message))
			{
				return false;
			}
			if (this.rootNode == null)
			{
				message = "Root Node bone is null. FBBIK will not initiate.";
				return false;
			}
			if (this.chain.Length != 5 || this.chain[0].nodes.Length != 1 || this.chain[1].nodes.Length != 3 || this.chain[2].nodes.Length != 3 || this.chain[3].nodes.Length != 3 || this.chain[4].nodes.Length != 3 || this.effectors.Length != 9 || this.limbMappings.Length != 4)
			{
				message = "Invalid FBBIK setup. Please right-click on the component header and select 'Reinitiate'.";
				return false;
			}
			return true;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00014834 File Offset: 0x00012A34
		public void SetToReferences(BipedReferences references, Transform rootNode = null)
		{
			this.root = references.root;
			if (rootNode == null)
			{
				rootNode = IKSolverFullBodyBiped.DetectRootNodeBone(references);
			}
			this.rootNode = rootNode;
			if (this.chain == null || this.chain.Length != 5)
			{
				this.chain = new FBIKChain[5];
			}
			for (int i = 0; i < this.chain.Length; i++)
			{
				if (this.chain[i] == null)
				{
					this.chain[i] = new FBIKChain();
				}
			}
			this.chain[0].pin = 0f;
			this.chain[0].SetNodes(new Transform[]
			{
				rootNode
			});
			this.chain[0].children = new int[]
			{
				1,
				2,
				3,
				4
			};
			this.chain[1].SetNodes(new Transform[]
			{
				references.leftUpperArm,
				references.leftForearm,
				references.leftHand
			});
			this.chain[2].SetNodes(new Transform[]
			{
				references.rightUpperArm,
				references.rightForearm,
				references.rightHand
			});
			this.chain[3].SetNodes(new Transform[]
			{
				references.leftThigh,
				references.leftCalf,
				references.leftFoot
			});
			this.chain[4].SetNodes(new Transform[]
			{
				references.rightThigh,
				references.rightCalf,
				references.rightFoot
			});
			if (this.effectors.Length != 9)
			{
				this.effectors = new IKEffector[]
				{
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector(),
					new IKEffector()
				};
			}
			this.effectors[0].bone = rootNode;
			this.effectors[0].childBones = new Transform[]
			{
				references.leftThigh,
				references.rightThigh
			};
			this.effectors[1].bone = references.leftUpperArm;
			this.effectors[2].bone = references.rightUpperArm;
			this.effectors[3].bone = references.leftThigh;
			this.effectors[4].bone = references.rightThigh;
			this.effectors[5].bone = references.leftHand;
			this.effectors[6].bone = references.rightHand;
			this.effectors[7].bone = references.leftFoot;
			this.effectors[8].bone = references.rightFoot;
			this.effectors[5].planeBone1 = references.leftUpperArm;
			this.effectors[5].planeBone2 = references.rightUpperArm;
			this.effectors[5].planeBone3 = rootNode;
			this.effectors[6].planeBone1 = references.rightUpperArm;
			this.effectors[6].planeBone2 = references.leftUpperArm;
			this.effectors[6].planeBone3 = rootNode;
			this.effectors[7].planeBone1 = references.leftThigh;
			this.effectors[7].planeBone2 = references.rightThigh;
			this.effectors[7].planeBone3 = rootNode;
			this.effectors[8].planeBone1 = references.rightThigh;
			this.effectors[8].planeBone2 = references.leftThigh;
			this.effectors[8].planeBone3 = rootNode;
			this.chain[0].childConstraints = new FBIKChain.ChildConstraint[]
			{
				new FBIKChain.ChildConstraint(references.leftUpperArm, references.rightThigh, 0f, 1f),
				new FBIKChain.ChildConstraint(references.rightUpperArm, references.leftThigh, 0f, 1f),
				new FBIKChain.ChildConstraint(references.leftUpperArm, references.rightUpperArm, 0f, 0f),
				new FBIKChain.ChildConstraint(references.leftThigh, references.rightThigh, 0f, 0f)
			};
			Transform[] array = new Transform[references.spine.Length + 1];
			array[0] = references.pelvis;
			for (int j = 0; j < references.spine.Length; j++)
			{
				array[j + 1] = references.spine[j];
			}
			if (this.spineMapping == null)
			{
				this.spineMapping = new IKMappingSpine();
				this.spineMapping.iterations = 3;
			}
			this.spineMapping.SetBones(array, references.leftUpperArm, references.rightUpperArm, references.leftThigh, references.rightThigh);
			int num = (references.head != null) ? 1 : 0;
			if (this.boneMappings.Length != num)
			{
				this.boneMappings = new IKMappingBone[num];
				for (int k = 0; k < this.boneMappings.Length; k++)
				{
					this.boneMappings[k] = new IKMappingBone();
				}
				if (num == 1)
				{
					this.boneMappings[0].maintainRotationWeight = 0f;
				}
			}
			if (this.boneMappings.Length != 0)
			{
				this.boneMappings[0].bone = references.head;
			}
			if (this.limbMappings.Length != 4)
			{
				this.limbMappings = new IKMappingLimb[]
				{
					new IKMappingLimb(),
					new IKMappingLimb(),
					new IKMappingLimb(),
					new IKMappingLimb()
				};
				this.limbMappings[2].maintainRotationWeight = 1f;
				this.limbMappings[3].maintainRotationWeight = 1f;
			}
			this.limbMappings[0].SetBones(references.leftUpperArm, references.leftForearm, references.leftHand, IKSolverFullBodyBiped.GetLeftClavicle(references));
			this.limbMappings[1].SetBones(references.rightUpperArm, references.rightForearm, references.rightHand, IKSolverFullBodyBiped.GetRightClavicle(references));
			this.limbMappings[2].SetBones(references.leftThigh, references.leftCalf, references.leftFoot, null);
			this.limbMappings[3].SetBones(references.rightThigh, references.rightCalf, references.rightFoot, null);
			if (Application.isPlaying)
			{
				base.Initiate(references.root);
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00014E2C File Offset: 0x0001302C
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			if (!references.isFilled)
			{
				return null;
			}
			if (references.spine.Length < 1)
			{
				return null;
			}
			int num = references.spine.Length;
			if (num == 1)
			{
				return references.spine[0];
			}
			Vector3 b = Vector3.Lerp(references.leftThigh.position, references.rightThigh.position, 0.5f);
			Vector3 onNormal = Vector3.Lerp(references.leftUpperArm.position, references.rightUpperArm.position, 0.5f) - b;
			float magnitude = onNormal.magnitude;
			if (references.spine.Length < 2)
			{
				return references.spine[0];
			}
			int num2 = 0;
			for (int i = 1; i < num; i++)
			{
				Vector3 vector = Vector3.Project(references.spine[i].position - b, onNormal);
				if (Vector3.Dot(vector.normalized, onNormal.normalized) > 0f && vector.magnitude / magnitude < 0.5f)
				{
					num2 = i;
				}
			}
			return references.spine[num2];
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00014F30 File Offset: 0x00013130
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
			this.SetLimbOrientation(FullBodyBipedChain.LeftArm, o.leftArm);
			this.SetLimbOrientation(FullBodyBipedChain.RightArm, o.rightArm);
			this.SetLimbOrientation(FullBodyBipedChain.LeftLeg, o.leftLeg);
			this.SetLimbOrientation(FullBodyBipedChain.RightLeg, o.rightLeg);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00014F66 File Offset: 0x00013166
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00014F6E File Offset: 0x0001316E
		public Vector3 pullBodyOffset { get; private set; }

		// Token: 0x06000341 RID: 833 RVA: 0x00014F78 File Offset: 0x00013178
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
			if (chain == FullBodyBipedChain.LeftArm || chain == FullBodyBipedChain.RightArm)
			{
				this.GetBendConstraint(chain).SetLimbOrientation(-limbOrientation.upperBoneForwardAxis, -limbOrientation.lowerBoneForwardAxis, -limbOrientation.lastBoneLeftAxis);
				this.GetLimbMapping(chain).SetLimbOrientation(-limbOrientation.upperBoneForwardAxis, -limbOrientation.lowerBoneForwardAxis);
				return;
			}
			this.GetBendConstraint(chain).SetLimbOrientation(limbOrientation.upperBoneForwardAxis, limbOrientation.lowerBoneForwardAxis, limbOrientation.lastBoneLeftAxis);
			this.GetLimbMapping(chain).SetLimbOrientation(limbOrientation.upperBoneForwardAxis, limbOrientation.lowerBoneForwardAxis);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00015017 File Offset: 0x00013217
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			if (references.leftUpperArm == null)
			{
				return null;
			}
			if (!IKSolverFullBodyBiped.Contains(references.spine, references.leftUpperArm.parent))
			{
				return references.leftUpperArm.parent;
			}
			return null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0001504E File Offset: 0x0001324E
		private static Transform GetRightClavicle(BipedReferences references)
		{
			if (references.rightUpperArm == null)
			{
				return null;
			}
			if (!IKSolverFullBodyBiped.Contains(references.spine, references.rightUpperArm.parent))
			{
				return references.rightUpperArm.parent;
			}
			return null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00015088 File Offset: 0x00013288
		private static bool Contains(Transform[] array, Transform transform)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == transform)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000150B4 File Offset: 0x000132B4
		protected override void ReadPose()
		{
			for (int i = 0; i < this.effectors.Length; i++)
			{
				this.effectors[i].SetToTarget();
			}
			this.PullBody();
			float pushElasticity = Mathf.Clamp(1f - this.spineStiffness, 0f, 1f);
			this.chain[0].childConstraints[0].pushElasticity = pushElasticity;
			this.chain[0].childConstraints[1].pushElasticity = pushElasticity;
			base.ReadPose();
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00015134 File Offset: 0x00013334
		private void PullBody()
		{
			if (this.iterations < 1)
			{
				return;
			}
			if (this.pullBodyVertical != 0f || this.pullBodyHorizontal != 0f)
			{
				Vector3 bodyOffset = this.GetBodyOffset();
				this.pullBodyOffset = V3Tools.ExtractVertical(bodyOffset, this.root.up, this.pullBodyVertical) + V3Tools.ExtractHorizontal(bodyOffset, this.root.up, this.pullBodyHorizontal);
				this.bodyEffector.positionOffset += this.pullBodyOffset;
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000151C4 File Offset: 0x000133C4
		private Vector3 GetBodyOffset()
		{
			Vector3 a = Vector3.zero + this.GetHandBodyPull(this.leftHandEffector, this.leftArmChain, Vector3.zero) * Mathf.Clamp(this.leftHandEffector.positionWeight, 0f, 1f);
			return a + this.GetHandBodyPull(this.rightHandEffector, this.rightArmChain, a) * Mathf.Clamp(this.rightHandEffector.positionWeight, 0f, 1f);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0001524C File Offset: 0x0001344C
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			Vector3 a = effector.position - (arm.nodes[0].transform.position + offset);
			float num = arm.nodes[0].length + arm.nodes[1].length;
			float magnitude = a.magnitude;
			if (magnitude < num)
			{
				return Vector3.zero;
			}
			float d = magnitude - num;
			return a / magnitude * d;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000152BC File Offset: 0x000134BC
		protected override void ApplyBendConstraints()
		{
			if (this.iterations > 0)
			{
				this.chain[1].bendConstraint.rotationOffset = this.leftHandEffector.planeRotationOffset;
				this.chain[2].bendConstraint.rotationOffset = this.rightHandEffector.planeRotationOffset;
				this.chain[3].bendConstraint.rotationOffset = this.leftFootEffector.planeRotationOffset;
				this.chain[4].bendConstraint.rotationOffset = this.rightFootEffector.planeRotationOffset;
			}
			else
			{
				this.offset = Vector3.Lerp(this.effectors[0].positionOffset, this.effectors[0].position - (this.effectors[0].bone.position + this.effectors[0].positionOffset), this.effectors[0].positionWeight);
				for (int i = 0; i < 5; i++)
				{
					this.effectors[i].GetNode(this).solverPosition += this.offset;
				}
			}
			base.ApplyBendConstraints();
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000153DC File Offset: 0x000135DC
		protected override void WritePose()
		{
			if (this.iterations == 0)
			{
				this.spineMapping.spineBones[0].position += this.offset;
			}
			base.WritePose();
		}

		// Token: 0x04000271 RID: 625
		public Transform rootNode;

		// Token: 0x04000272 RID: 626
		[Range(0f, 1f)]
		public float spineStiffness = 0.5f;

		// Token: 0x04000273 RID: 627
		[Range(-1f, 1f)]
		public float pullBodyVertical = 0.5f;

		// Token: 0x04000274 RID: 628
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		// Token: 0x04000276 RID: 630
		private Vector3 offset;
	}
}
