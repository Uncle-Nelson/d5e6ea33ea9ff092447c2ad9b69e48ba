using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000032 RID: 50
	public class FingerRig : SolverManager
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0000952A File Offset: 0x0000772A
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00009532 File Offset: 0x00007732
		public bool initiated { get; private set; }

		// Token: 0x06000188 RID: 392 RVA: 0x0000953C File Offset: 0x0000773C
		public bool IsValid(ref string errorMessage)
		{
			Finger[] array = this.fingers;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].IsValid(ref errorMessage))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000956C File Offset: 0x0000776C
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
			this.fingers = new Finger[0];
			for (int i = 0; i < base.transform.childCount; i++)
			{
				Transform[] array = new Transform[0];
				this.AddChildrenRecursive(base.transform.GetChild(i), ref array);
				if (array.Length == 3 || array.Length == 4)
				{
					Finger finger = new Finger();
					finger.bone1 = array[0];
					finger.bone2 = array[1];
					if (array.Length == 3)
					{
						finger.tip = array[2];
					}
					else
					{
						finger.bone3 = array[2];
						finger.tip = array[3];
					}
					finger.weight = 1f;
					Array.Resize<Finger>(ref this.fingers, this.fingers.Length + 1);
					this.fingers[this.fingers.Length - 1] = finger;
				}
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00009638 File Offset: 0x00007838
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target = null)
		{
			Finger finger = new Finger();
			finger.bone1 = bone1;
			finger.bone2 = bone2;
			finger.bone3 = bone3;
			finger.tip = tip;
			finger.target = target;
			Array.Resize<Finger>(ref this.fingers, this.fingers.Length + 1);
			this.fingers[this.fingers.Length - 1] = finger;
			this.initiated = false;
			finger.Initiate(base.transform, this.fingers.Length - 1);
			if (this.fingers[this.fingers.Length - 1].initiated)
			{
				this.initiated = true;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000096D4 File Offset: 0x000078D4
		public void RemoveFinger(int index)
		{
			if ((float)index < 0f || index >= this.fingers.Length)
			{
				Warning.Log("RemoveFinger index out of bounds.", base.transform, false);
				return;
			}
			if (this.fingers.Length == 1)
			{
				this.fingers = new Finger[0];
				return;
			}
			Finger[] array = new Finger[this.fingers.Length - 1];
			int num = 0;
			for (int i = 0; i < this.fingers.Length; i++)
			{
				if (i != index)
				{
					array[num] = this.fingers[i];
					num++;
				}
			}
			this.fingers = array;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000975E File Offset: 0x0000795E
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
			Array.Resize<Transform>(ref array, array.Length + 1);
			array[array.Length - 1] = parent;
			if (parent.childCount != 1)
			{
				return;
			}
			this.AddChildrenRecursive(parent.GetChild(0), ref array);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00009790 File Offset: 0x00007990
		protected override void InitiateSolver()
		{
			this.initiated = true;
			for (int i = 0; i < this.fingers.Length; i++)
			{
				this.fingers[i].Initiate(base.transform, i);
				if (!this.fingers[i].initiated)
				{
					this.initiated = false;
				}
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000097E4 File Offset: 0x000079E4
		public void UpdateFingerSolvers()
		{
			Finger[] array = this.fingers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Update(this.weight);
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00009814 File Offset: 0x00007A14
		public void FixFingerTransforms()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			Finger[] array = this.fingers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].FixTransforms();
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000984C File Offset: 0x00007A4C
		public void StoreDefaultLocalState()
		{
			Finger[] array = this.fingers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].StoreDefaultLocalState();
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00009876 File Offset: 0x00007A76
		protected override void UpdateSolver()
		{
			this.UpdateFingerSolvers();
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000987E File Offset: 0x00007A7E
		protected override void FixTransforms()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			this.FixFingerTransforms();
		}

		// Token: 0x04000119 RID: 281
		[Tooltip("The master weight for all fingers.")]
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x0400011A RID: 282
		public Finger[] fingers = new Finger[0];
	}
}
