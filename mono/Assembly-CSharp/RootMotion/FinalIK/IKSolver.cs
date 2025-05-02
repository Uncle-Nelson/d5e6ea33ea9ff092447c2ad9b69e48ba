using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000050 RID: 80
	[Serializable]
	public abstract class IKSolver
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x0001127C File Offset: 0x0000F47C
		public bool IsValid()
		{
			string empty = string.Empty;
			return this.IsValid(ref empty);
		}

		// Token: 0x060002B7 RID: 695
		public abstract bool IsValid(ref string message);

		// Token: 0x060002B8 RID: 696 RVA: 0x00011298 File Offset: 0x0000F498
		public void Initiate(Transform root)
		{
			if (this.executedInEditor)
			{
				return;
			}
			if (this.OnPreInitiate != null)
			{
				this.OnPreInitiate();
			}
			if (root == null)
			{
				Debug.LogError("Initiating IKSolver with null root Transform.");
			}
			this.root = root;
			this.initiated = false;
			string empty = string.Empty;
			if (!this.IsValid(ref empty))
			{
				Warning.Log(empty, root, false);
				return;
			}
			this.OnInitiate();
			this.StoreDefaultLocalState();
			this.initiated = true;
			this.firstInitiation = false;
			if (this.OnPostInitiate != null)
			{
				this.OnPostInitiate();
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00011328 File Offset: 0x0000F528
		public void Update()
		{
			if (this.OnPreUpdate != null)
			{
				this.OnPreUpdate();
			}
			if (this.firstInitiation)
			{
				this.Initiate(this.root);
			}
			if (!this.initiated)
			{
				return;
			}
			this.OnUpdate();
			if (this.OnPostUpdate != null)
			{
				this.OnPostUpdate();
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0001137E File Offset: 0x0000F57E
		public virtual Vector3 GetIKPosition()
		{
			return this.IKPosition;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00011386 File Offset: 0x0000F586
		public void SetIKPosition(Vector3 position)
		{
			this.IKPosition = position;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0001138F File Offset: 0x0000F58F
		public float GetIKPositionWeight()
		{
			return this.IKPositionWeight;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00011397 File Offset: 0x0000F597
		public void SetIKPositionWeight(float weight)
		{
			this.IKPositionWeight = Mathf.Clamp(weight, 0f, 1f);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000113AF File Offset: 0x0000F5AF
		public Transform GetRoot()
		{
			return this.root;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060002BF RID: 703 RVA: 0x000113B7 File Offset: 0x0000F5B7
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x000113BF File Offset: 0x0000F5BF
		public bool initiated { get; private set; }

		// Token: 0x060002C1 RID: 705
		public abstract IKSolver.Point[] GetPoints();

		// Token: 0x060002C2 RID: 706
		public abstract IKSolver.Point GetPoint(Transform transform);

		// Token: 0x060002C3 RID: 707
		public abstract void FixTransforms();

		// Token: 0x060002C4 RID: 708
		public abstract void StoreDefaultLocalState();

		// Token: 0x060002C5 RID: 709
		protected abstract void OnInitiate();

		// Token: 0x060002C6 RID: 710
		protected abstract void OnUpdate();

		// Token: 0x060002C7 RID: 711 RVA: 0x000113C8 File Offset: 0x0000F5C8
		protected void LogWarning(string message)
		{
			Warning.Log(message, this.root, true);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000113D8 File Offset: 0x0000F5D8
		public static Transform ContainsDuplicateBone(IKSolver.Bone[] bones)
		{
			for (int i = 0; i < bones.Length; i++)
			{
				for (int j = 0; j < bones.Length; j++)
				{
					if (i != j && bones[i].transform == bones[j].transform)
					{
						return bones[i].transform;
					}
				}
			}
			return null;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00011428 File Offset: 0x0000F628
		public static bool HierarchyIsValid(IKSolver.Bone[] bones)
		{
			for (int i = 1; i < bones.Length; i++)
			{
				if (!Hierarchy.IsAncestor(bones[i].transform, bones[i - 1].transform))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00011460 File Offset: 0x0000F660
		protected static float PreSolveBones(ref IKSolver.Bone[] bones)
		{
			float num = 0f;
			for (int i = 0; i < bones.Length; i++)
			{
				bones[i].solverPosition = bones[i].transform.position;
				bones[i].solverRotation = bones[i].transform.rotation;
			}
			for (int j = 0; j < bones.Length; j++)
			{
				if (j < bones.Length - 1)
				{
					bones[j].sqrMag = (bones[j + 1].solverPosition - bones[j].solverPosition).sqrMagnitude;
					bones[j].length = Mathf.Sqrt(bones[j].sqrMag);
					num += bones[j].length;
					bones[j].axis = Quaternion.Inverse(bones[j].solverRotation) * (bones[j + 1].solverPosition - bones[j].solverPosition);
				}
				else
				{
					bones[j].sqrMag = 0f;
					bones[j].length = 0f;
				}
			}
			return num;
		}

		// Token: 0x04000227 RID: 551
		[HideInInspector]
		public bool executedInEditor;

		// Token: 0x04000228 RID: 552
		[HideInInspector]
		public Vector3 IKPosition;

		// Token: 0x04000229 RID: 553
		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight = 1f;

		// Token: 0x0400022B RID: 555
		public IKSolver.UpdateDelegate OnPreInitiate;

		// Token: 0x0400022C RID: 556
		public IKSolver.UpdateDelegate OnPostInitiate;

		// Token: 0x0400022D RID: 557
		public IKSolver.UpdateDelegate OnPreUpdate;

		// Token: 0x0400022E RID: 558
		public IKSolver.UpdateDelegate OnPostUpdate;

		// Token: 0x0400022F RID: 559
		protected bool firstInitiation = true;

		// Token: 0x04000230 RID: 560
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		// Token: 0x020000E4 RID: 228
		[Serializable]
		public class Point
		{
			// Token: 0x060006D3 RID: 1747 RVA: 0x0002CF73 File Offset: 0x0002B173
			public void StoreDefaultLocalState()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x060006D4 RID: 1748 RVA: 0x0002CF98 File Offset: 0x0002B198
			public void FixTransform()
			{
				if (this.transform.localPosition != this.defaultLocalPosition)
				{
					this.transform.localPosition = this.defaultLocalPosition;
				}
				if (this.transform.localRotation != this.defaultLocalRotation)
				{
					this.transform.localRotation = this.defaultLocalRotation;
				}
			}

			// Token: 0x060006D5 RID: 1749 RVA: 0x0002CFF7 File Offset: 0x0002B1F7
			public void UpdateSolverPosition()
			{
				this.solverPosition = this.transform.position;
			}

			// Token: 0x060006D6 RID: 1750 RVA: 0x0002D00A File Offset: 0x0002B20A
			public void UpdateSolverLocalPosition()
			{
				this.solverPosition = this.transform.localPosition;
			}

			// Token: 0x060006D7 RID: 1751 RVA: 0x0002D01D File Offset: 0x0002B21D
			public void UpdateSolverState()
			{
				this.solverPosition = this.transform.position;
				this.solverRotation = this.transform.rotation;
			}

			// Token: 0x060006D8 RID: 1752 RVA: 0x0002D041 File Offset: 0x0002B241
			public void UpdateSolverLocalState()
			{
				this.solverPosition = this.transform.localPosition;
				this.solverRotation = this.transform.localRotation;
			}

			// Token: 0x04000676 RID: 1654
			public Transform transform;

			// Token: 0x04000677 RID: 1655
			[Range(0f, 1f)]
			public float weight = 1f;

			// Token: 0x04000678 RID: 1656
			public Vector3 solverPosition;

			// Token: 0x04000679 RID: 1657
			public Quaternion solverRotation = Quaternion.identity;

			// Token: 0x0400067A RID: 1658
			public Vector3 defaultLocalPosition;

			// Token: 0x0400067B RID: 1659
			public Quaternion defaultLocalRotation;
		}

		// Token: 0x020000E5 RID: 229
		[Serializable]
		public class Bone : IKSolver.Point
		{
			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060006DA RID: 1754 RVA: 0x0002D084 File Offset: 0x0002B284
			// (set) Token: 0x060006DB RID: 1755 RVA: 0x0002D0D2 File Offset: 0x0002B2D2
			public RotationLimit rotationLimit
			{
				get
				{
					if (!this.isLimited)
					{
						return null;
					}
					if (this._rotationLimit == null)
					{
						this._rotationLimit = this.transform.GetComponent<RotationLimit>();
					}
					this.isLimited = (this._rotationLimit != null);
					return this._rotationLimit;
				}
				set
				{
					this._rotationLimit = value;
					this.isLimited = (value != null);
				}
			}

			// Token: 0x060006DC RID: 1756 RVA: 0x0002D0E8 File Offset: 0x0002B2E8
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
				if (weight <= 0f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.axis, swingTarget - this.transform.position);
				if (weight >= 1f)
				{
					this.transform.rotation = quaternion * this.transform.rotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, weight) * this.transform.rotation;
			}

			// Token: 0x060006DD RID: 1757 RVA: 0x0002D178 File Offset: 0x0002B378
			public static void SolverSwing(IKSolver.Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
				if (weight <= 0f)
				{
					return;
				}
				Quaternion quaternion = Quaternion.FromToRotation(bones[index].solverRotation * bones[index].axis, swingTarget - bones[index].solverPosition);
				if (weight >= 1f)
				{
					for (int i = index; i < bones.Length; i++)
					{
						bones[i].solverRotation = quaternion * bones[i].solverRotation;
					}
					return;
				}
				for (int j = index; j < bones.Length; j++)
				{
					bones[j].solverRotation = Quaternion.Lerp(Quaternion.identity, quaternion, weight) * bones[j].solverRotation;
				}
			}

			// Token: 0x060006DE RID: 1758 RVA: 0x0002D214 File Offset: 0x0002B414
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
				if (weight <= 0f)
				{
					return;
				}
				Vector3 vector = this.transform.rotation * this.axis;
				Vector3 vector2 = swingTarget - this.transform.position;
				float current = Mathf.Atan2(vector.x, vector.y) * 57.29578f;
				float target = Mathf.Atan2(vector2.x, vector2.y) * 57.29578f;
				this.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target) * weight, Vector3.back) * this.transform.rotation;
			}

			// Token: 0x060006DF RID: 1759 RVA: 0x0002D2B1 File Offset: 0x0002B4B1
			public void SetToSolverPosition()
			{
				this.transform.position = this.solverPosition;
			}

			// Token: 0x060006E0 RID: 1760 RVA: 0x0002D2C4 File Offset: 0x0002B4C4
			public Bone()
			{
			}

			// Token: 0x060006E1 RID: 1761 RVA: 0x0002D2E3 File Offset: 0x0002B4E3
			public Bone(Transform transform)
			{
				this.transform = transform;
			}

			// Token: 0x060006E2 RID: 1762 RVA: 0x0002D309 File Offset: 0x0002B509
			public Bone(Transform transform, float weight)
			{
				this.transform = transform;
				this.weight = weight;
			}

			// Token: 0x0400067C RID: 1660
			public float length;

			// Token: 0x0400067D RID: 1661
			public float sqrMag;

			// Token: 0x0400067E RID: 1662
			public Vector3 axis = -Vector3.right;

			// Token: 0x0400067F RID: 1663
			private RotationLimit _rotationLimit;

			// Token: 0x04000680 RID: 1664
			private bool isLimited = true;
		}

		// Token: 0x020000E6 RID: 230
		[Serializable]
		public class Node : IKSolver.Point
		{
			// Token: 0x060006E3 RID: 1763 RVA: 0x0002D336 File Offset: 0x0002B536
			public Node()
			{
			}

			// Token: 0x060006E4 RID: 1764 RVA: 0x0002D33E File Offset: 0x0002B53E
			public Node(Transform transform)
			{
				this.transform = transform;
			}

			// Token: 0x060006E5 RID: 1765 RVA: 0x0002D34D File Offset: 0x0002B54D
			public Node(Transform transform, float weight)
			{
				this.transform = transform;
				this.weight = weight;
			}

			// Token: 0x04000681 RID: 1665
			public float length;

			// Token: 0x04000682 RID: 1666
			public float effectorPositionWeight;

			// Token: 0x04000683 RID: 1667
			public float effectorRotationWeight;

			// Token: 0x04000684 RID: 1668
			public Vector3 offset;
		}

		// Token: 0x020000E7 RID: 231
		// (Invoke) Token: 0x060006E7 RID: 1767
		public delegate void UpdateDelegate();

		// Token: 0x020000E8 RID: 232
		// (Invoke) Token: 0x060006EB RID: 1771
		public delegate void IterationDelegate(int i);
	}
}
