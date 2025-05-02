using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200007D RID: 125
	public abstract class OffsetModifier : MonoBehaviour
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x0002084D File Offset: 0x0001EA4D
		protected float deltaTime
		{
			get
			{
				return Time.time - this.lastTime;
			}
		}

		// Token: 0x060004EF RID: 1263
		protected abstract void OnModifyOffset();

		// Token: 0x060004F0 RID: 1264 RVA: 0x0002085B File Offset: 0x0001EA5B
		protected virtual void Start()
		{
			base.StartCoroutine(this.Initiate());
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0002086A File Offset: 0x0001EA6A
		private IEnumerator Initiate()
		{
			while (this.ik == null)
			{
				yield return null;
			}
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPreUpdate, new IKSolver.UpdateDelegate(this.ModifyOffset));
			this.lastTime = Time.time;
			yield break;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0002087C File Offset: 0x0001EA7C
		private void ModifyOffset()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 0f)
			{
				return;
			}
			if (this.ik == null)
			{
				return;
			}
			this.weight = Mathf.Clamp(this.weight, 0f, 1f);
			if (this.deltaTime <= 0f)
			{
				return;
			}
			this.OnModifyOffset();
			this.lastTime = Time.time;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x000208EC File Offset: 0x0001EAEC
		protected void ApplyLimits(OffsetModifier.OffsetLimits[] limits)
		{
			foreach (OffsetModifier.OffsetLimits offsetLimits in limits)
			{
				offsetLimits.Apply(this.ik.solver.GetEffector(offsetLimits.effector), base.transform.rotation);
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00020934 File Offset: 0x0001EB34
		protected virtual void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPreUpdate, new IKSolver.UpdateDelegate(this.ModifyOffset));
			}
		}

		// Token: 0x040003C6 RID: 966
		[Tooltip("The master weight")]
		public float weight = 1f;

		// Token: 0x040003C7 RID: 967
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		// Token: 0x040003C8 RID: 968
		protected float lastTime;

		// Token: 0x02000112 RID: 274
		[Serializable]
		public class OffsetLimits
		{
			// Token: 0x060007F4 RID: 2036 RVA: 0x00034520 File Offset: 0x00032720
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
				Vector3 vector = Quaternion.Inverse(rootRotation) * e.positionOffset;
				if (this.spring <= 0f)
				{
					if (this.x)
					{
						vector.x = Mathf.Clamp(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = Mathf.Clamp(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = Mathf.Clamp(vector.z, this.minZ, this.maxZ);
					}
				}
				else
				{
					if (this.x)
					{
						vector.x = this.SpringAxis(vector.x, this.minX, this.maxX);
					}
					if (this.y)
					{
						vector.y = this.SpringAxis(vector.y, this.minY, this.maxY);
					}
					if (this.z)
					{
						vector.z = this.SpringAxis(vector.z, this.minZ, this.maxZ);
					}
				}
				e.positionOffset = rootRotation * vector;
			}

			// Token: 0x060007F5 RID: 2037 RVA: 0x00034645 File Offset: 0x00032845
			private float SpringAxis(float value, float min, float max)
			{
				if (value > min && value < max)
				{
					return value;
				}
				if (value < min)
				{
					return this.Spring(value, min, true);
				}
				return this.Spring(value, max, false);
			}

			// Token: 0x060007F6 RID: 2038 RVA: 0x00034668 File Offset: 0x00032868
			private float Spring(float value, float limit, bool negative)
			{
				float num = value - limit;
				float num2 = num * this.spring;
				if (negative)
				{
					return value + Mathf.Clamp(-num2, 0f, -num);
				}
				return value - Mathf.Clamp(num2, 0f, num);
			}

			// Token: 0x040007F6 RID: 2038
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			// Token: 0x040007F7 RID: 2039
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			// Token: 0x040007F8 RID: 2040
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			// Token: 0x040007F9 RID: 2041
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			// Token: 0x040007FA RID: 2042
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			// Token: 0x040007FB RID: 2043
			[Tooltip("The limits")]
			public float minX;

			// Token: 0x040007FC RID: 2044
			[Tooltip("The limits")]
			public float maxX;

			// Token: 0x040007FD RID: 2045
			[Tooltip("The limits")]
			public float minY;

			// Token: 0x040007FE RID: 2046
			[Tooltip("The limits")]
			public float maxY;

			// Token: 0x040007FF RID: 2047
			[Tooltip("The limits")]
			public float minZ;

			// Token: 0x04000800 RID: 2048
			[Tooltip("The limits")]
			public float maxZ;
		}
	}
}
