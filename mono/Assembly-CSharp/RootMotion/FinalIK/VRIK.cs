using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000045 RID: 69
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		// Token: 0x06000241 RID: 577 RVA: 0x0000C951 File Offset: 0x0000AB51
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page16.html");
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000C95D File Offset: 0x0000AB5D
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_v_r_i_k.html");
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000C969 File Offset: 0x0000AB69
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=6Pfx7lYQiIA&feature=youtu.be");
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000C975 File Offset: 0x0000AB75
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
			VRIK.References.AutoDetectReferences(base.transform, out this.references);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000C989 File Offset: 0x0000AB89
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
			this.solver.GuessHandOrientations(this.references, false);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000C99D File Offset: 0x0000AB9D
		public override IKSolver GetIKSolver()
		{
			return this.solver;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000C9A5 File Offset: 0x0000ABA5
		protected override void InitiateSolver()
		{
			if (this.references.isEmpty)
			{
				this.AutoDetectReferences();
			}
			if (this.references.isFilled)
			{
				this.solver.SetToReferences(this.references);
			}
			base.InitiateSolver();
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000C9E0 File Offset: 0x0000ABE0
		protected override void UpdateSolver()
		{
			if (this.references.root != null && this.references.root.localScale == Vector3.zero)
			{
				Debug.LogError("VRIK Root Transform's scale is zero, can not update VRIK. Make sure you have not calibrated the character to a zero scale.", base.transform);
				base.enabled = false;
				return;
			}
			base.UpdateSolver();
		}

		// Token: 0x04000186 RID: 390
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		public VRIK.References references = new VRIK.References();

		// Token: 0x04000187 RID: 391
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver = new IKSolverVR();

		// Token: 0x020000DE RID: 222
		[Serializable]
		public class References
		{
			// Token: 0x060006A7 RID: 1703 RVA: 0x0002BFDA File Offset: 0x0002A1DA
			public References()
			{
			}

			// Token: 0x060006A8 RID: 1704 RVA: 0x0002BFE4 File Offset: 0x0002A1E4
			public References(BipedReferences b)
			{
				this.root = b.root;
				this.pelvis = b.pelvis;
				this.spine = b.spine[0];
				this.chest = ((b.spine.Length > 1) ? b.spine[1] : null);
				this.head = b.head;
				this.leftShoulder = b.leftUpperArm.parent;
				this.leftUpperArm = b.leftUpperArm;
				this.leftForearm = b.leftForearm;
				this.leftHand = b.leftHand;
				this.rightShoulder = b.rightUpperArm.parent;
				this.rightUpperArm = b.rightUpperArm;
				this.rightForearm = b.rightForearm;
				this.rightHand = b.rightHand;
				this.leftThigh = b.leftThigh;
				this.leftCalf = b.leftCalf;
				this.leftFoot = b.leftFoot;
				this.leftToes = b.leftFoot.GetChild(0);
				this.rightThigh = b.rightThigh;
				this.rightCalf = b.rightCalf;
				this.rightFoot = b.rightFoot;
				this.rightToes = b.rightFoot.GetChild(0);
			}

			// Token: 0x060006A9 RID: 1705 RVA: 0x0002C11C File Offset: 0x0002A31C
			public Transform[] GetTransforms()
			{
				return new Transform[]
				{
					this.root,
					this.pelvis,
					this.spine,
					this.chest,
					this.neck,
					this.head,
					this.leftShoulder,
					this.leftUpperArm,
					this.leftForearm,
					this.leftHand,
					this.rightShoulder,
					this.rightUpperArm,
					this.rightForearm,
					this.rightHand,
					this.leftThigh,
					this.leftCalf,
					this.leftFoot,
					this.leftToes,
					this.rightThigh,
					this.rightCalf,
					this.rightFoot,
					this.rightToes
				};
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x060006AA RID: 1706 RVA: 0x0002C204 File Offset: 0x0002A404
			public bool isFilled
			{
				get
				{
					if (this.root == null || this.pelvis == null || this.spine == null || this.head == null)
					{
						return false;
					}
					bool flag = this.leftUpperArm == null && this.leftForearm == null && this.leftHand == null && this.rightUpperArm == null && this.rightForearm == null && this.rightHand == null;
					bool flag2 = this.leftUpperArm == null || this.leftForearm == null || this.leftHand == null || this.rightUpperArm == null || this.rightForearm == null || this.rightHand == null;
					bool flag3 = this.leftThigh == null && this.leftCalf == null && this.leftFoot == null && this.rightThigh == null && this.rightCalf == null && this.rightFoot == null;
					return ((!(this.leftThigh == null) && !(this.leftCalf == null) && !(this.leftFoot == null) && !(this.rightThigh == null) && !(this.rightCalf == null) && !(this.rightFoot == null)) || flag3) && (!flag2 || flag);
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x060006AB RID: 1707 RVA: 0x0002C3B4 File Offset: 0x0002A5B4
			public bool isEmpty
			{
				get
				{
					return !(this.root != null) && !(this.pelvis != null) && !(this.spine != null) && !(this.chest != null) && !(this.neck != null) && !(this.head != null) && !(this.leftShoulder != null) && !(this.leftUpperArm != null) && !(this.leftForearm != null) && !(this.leftHand != null) && !(this.rightShoulder != null) && !(this.rightUpperArm != null) && !(this.rightForearm != null) && !(this.rightHand != null) && !(this.leftThigh != null) && !(this.leftCalf != null) && !(this.leftFoot != null) && !(this.leftToes != null) && !(this.rightThigh != null) && !(this.rightCalf != null) && !(this.rightFoot != null) && !(this.rightToes != null);
				}
			}

			// Token: 0x060006AC RID: 1708 RVA: 0x0002C51C File Offset: 0x0002A71C
			public static bool AutoDetectReferences(Transform root, out VRIK.References references)
			{
				references = new VRIK.References();
				Animator componentInChildren = root.GetComponentInChildren<Animator>();
				if (componentInChildren == null || !componentInChildren.isHuman)
				{
					Debug.LogWarning("VRIK needs a Humanoid Animator to auto-detect biped references. Please assign references manually.");
					return false;
				}
				references.root = root;
				references.pelvis = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				references.spine = componentInChildren.GetBoneTransform(HumanBodyBones.Spine);
				references.chest = componentInChildren.GetBoneTransform(HumanBodyBones.Chest);
				references.neck = componentInChildren.GetBoneTransform(HumanBodyBones.Neck);
				references.head = componentInChildren.GetBoneTransform(HumanBodyBones.Head);
				references.leftShoulder = componentInChildren.GetBoneTransform(HumanBodyBones.LeftShoulder);
				references.leftUpperArm = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperArm);
				references.leftForearm = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerArm);
				references.leftHand = componentInChildren.GetBoneTransform(HumanBodyBones.LeftHand);
				references.rightShoulder = componentInChildren.GetBoneTransform(HumanBodyBones.RightShoulder);
				references.rightUpperArm = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperArm);
				references.rightForearm = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerArm);
				references.rightHand = componentInChildren.GetBoneTransform(HumanBodyBones.RightHand);
				references.leftThigh = componentInChildren.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				references.leftCalf = componentInChildren.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				references.leftFoot = componentInChildren.GetBoneTransform(HumanBodyBones.LeftFoot);
				references.leftToes = componentInChildren.GetBoneTransform(HumanBodyBones.LeftToes);
				references.rightThigh = componentInChildren.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				references.rightCalf = componentInChildren.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				references.rightFoot = componentInChildren.GetBoneTransform(HumanBodyBones.RightFoot);
				references.rightToes = componentInChildren.GetBoneTransform(HumanBodyBones.RightToes);
				return true;
			}

			// Token: 0x04000634 RID: 1588
			public Transform root;

			// Token: 0x04000635 RID: 1589
			[LargeHeader("Spine")]
			public Transform pelvis;

			// Token: 0x04000636 RID: 1590
			public Transform spine;

			// Token: 0x04000637 RID: 1591
			[Tooltip("Optional")]
			public Transform chest;

			// Token: 0x04000638 RID: 1592
			[Tooltip("Optional")]
			public Transform neck;

			// Token: 0x04000639 RID: 1593
			public Transform head;

			// Token: 0x0400063A RID: 1594
			[LargeHeader("Left Arm")]
			[Tooltip("Optional")]
			public Transform leftShoulder;

			// Token: 0x0400063B RID: 1595
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform leftUpperArm;

			// Token: 0x0400063C RID: 1596
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform leftForearm;

			// Token: 0x0400063D RID: 1597
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform leftHand;

			// Token: 0x0400063E RID: 1598
			[LargeHeader("Right Arm")]
			[Tooltip("Optional")]
			public Transform rightShoulder;

			// Token: 0x0400063F RID: 1599
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform rightUpperArm;

			// Token: 0x04000640 RID: 1600
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform rightForearm;

			// Token: 0x04000641 RID: 1601
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform rightHand;

			// Token: 0x04000642 RID: 1602
			[LargeHeader("Left Leg")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			// Token: 0x04000643 RID: 1603
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			// Token: 0x04000644 RID: 1604
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			// Token: 0x04000645 RID: 1605
			[Tooltip("Optional")]
			public Transform leftToes;

			// Token: 0x04000646 RID: 1606
			[LargeHeader("Right Leg")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			// Token: 0x04000647 RID: 1607
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			// Token: 0x04000648 RID: 1608
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			// Token: 0x04000649 RID: 1609
			[Tooltip("Optional")]
			public Transform rightToes;
		}
	}
}
