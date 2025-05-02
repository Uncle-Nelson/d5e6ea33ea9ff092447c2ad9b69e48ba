using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200006F RID: 111
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		// Token: 0x060004A2 RID: 1186 RVA: 0x0001E746 File Offset: 0x0001C946
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page14.html");
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0001E752 File Offset: 0x0001C952
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_polygonal.html");
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0001E75E File Offset: 0x0001C95E
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0001E76A File Offset: 0x0001C96A
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0001E776 File Offset: 0x0001C976
		public void SetLimitPoints(RotationLimitPolygonal.LimitPoint[] points)
		{
			if (points.Length < 3)
			{
				base.LogWarning("The polygon must have at least 3 Limit Points.");
				return;
			}
			this.points = points;
			this.BuildReachCones();
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0001E797 File Offset: 0x0001C997
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			if (this.reachCones.Length == 0)
			{
				this.Start();
			}
			return RotationLimit.LimitTwist(this.LimitSwing(rotation), this.axis, base.secondaryAxis, this.twistLimit);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0001E7C8 File Offset: 0x0001C9C8
		private void Start()
		{
			if (this.points.Length < 3)
			{
				this.ResetToDefault();
			}
			for (int i = 0; i < this.reachCones.Length; i++)
			{
				if (!this.reachCones[i].isValid)
				{
					if (this.smoothIterations <= 0)
					{
						int num;
						if (i < this.reachCones.Length - 1)
						{
							num = i + 1;
						}
						else
						{
							num = 0;
						}
						base.LogWarning(string.Concat(new string[]
						{
							"Reach Cone {point ",
							i.ToString(),
							", point ",
							num.ToString(),
							", Origin} has negative volume. Make sure Axis vector is in the reachable area and the polygon is convex."
						}));
					}
					else
					{
						base.LogWarning("One of the Reach Cones in the polygon has negative volume. Make sure Axis vector is in the reachable area and the polygon is convex.");
					}
				}
			}
			this.axis = this.axis.normalized;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0001E888 File Offset: 0x0001CA88
		public void ResetToDefault()
		{
			this.points = new RotationLimitPolygonal.LimitPoint[4];
			for (int i = 0; i < this.points.Length; i++)
			{
				this.points[i] = new RotationLimitPolygonal.LimitPoint();
			}
			Quaternion quaternion = Quaternion.AngleAxis(45f, Vector3.right);
			Quaternion quaternion2 = Quaternion.AngleAxis(45f, Vector3.up);
			this.points[0].point = quaternion * quaternion2 * this.axis;
			this.points[1].point = Quaternion.Inverse(quaternion) * quaternion2 * this.axis;
			this.points[2].point = Quaternion.Inverse(quaternion) * Quaternion.Inverse(quaternion2) * this.axis;
			this.points[3].point = quaternion * Quaternion.Inverse(quaternion2) * this.axis;
			this.BuildReachCones();
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0001E978 File Offset: 0x0001CB78
		public void BuildReachCones()
		{
			this.smoothIterations = Mathf.Clamp(this.smoothIterations, 0, 3);
			this.P = new Vector3[this.points.Length];
			for (int i = 0; i < this.points.Length; i++)
			{
				this.P[i] = this.points[i].point.normalized;
			}
			for (int j = 0; j < this.smoothIterations; j++)
			{
				this.P = this.SmoothPoints();
			}
			this.reachCones = new RotationLimitPolygonal.ReachCone[this.P.Length];
			for (int k = 0; k < this.reachCones.Length - 1; k++)
			{
				this.reachCones[k] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[k], this.P[k + 1]);
			}
			this.reachCones[this.P.Length - 1] = new RotationLimitPolygonal.ReachCone(Vector3.zero, this.axis.normalized, this.P[this.P.Length - 1], this.P[0]);
			for (int l = 0; l < this.reachCones.Length; l++)
			{
				this.reachCones[l].Calculate();
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0001EAC0 File Offset: 0x0001CCC0
		private Vector3[] SmoothPoints()
		{
			Vector3[] array = new Vector3[this.P.Length * 2];
			float scalar = this.GetScalar(this.P.Length);
			for (int i = 0; i < array.Length; i += 2)
			{
				array[i] = this.PointToTangentPlane(this.P[i / 2], 1f);
			}
			for (int j = 1; j < array.Length; j += 2)
			{
				Vector3 b = Vector3.zero;
				Vector3 vector = Vector3.zero;
				Vector3 b2 = Vector3.zero;
				if (j > 1 && j < array.Length - 2)
				{
					b = array[j - 2];
					b2 = array[j + 1];
				}
				else if (j == 1)
				{
					b = array[array.Length - 2];
					b2 = array[j + 1];
				}
				else if (j == array.Length - 1)
				{
					b = array[j - 2];
					b2 = array[0];
				}
				if (j < array.Length - 1)
				{
					vector = array[j + 1];
				}
				else
				{
					vector = array[0];
				}
				int num = array.Length / this.points.Length;
				array[j] = 0.5f * (array[j - 1] + vector) + scalar * this.points[j / num].tangentWeight * (vector - b) + scalar * this.points[j / num].tangentWeight * (array[j - 1] - b2);
			}
			for (int k = 0; k < array.Length; k++)
			{
				array[k] = this.TangentPointToSphere(array[k], 1f);
			}
			return array;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0001EC6D File Offset: 0x0001CE6D
		private float GetScalar(int k)
		{
			if (k <= 3)
			{
				return 0.1667f;
			}
			if (k == 4)
			{
				return 0.1036f;
			}
			if (k == 5)
			{
				return 0.085f;
			}
			if (k == 6)
			{
				return 0.0773f;
			}
			if (k == 7)
			{
				return 0.07f;
			}
			return 0.0625f;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0001ECA8 File Offset: 0x0001CEA8
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			float num = Vector3.Dot(this.axis, p);
			float num2 = 2f * r * r / (r * r + num);
			return num2 * p + (1f - num2) * -this.axis;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0001ECF8 File Offset: 0x0001CEF8
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			float num = Vector3.Dot(q - this.axis, q - this.axis);
			float num2 = 4f * r * r / (4f * r * r + num);
			return num2 * q + (1f - num2) * -this.axis;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0001ED5C File Offset: 0x0001CF5C
		private Quaternion LimitSwing(Quaternion rotation)
		{
			if (rotation == Quaternion.identity)
			{
				return rotation;
			}
			Vector3 vector = rotation * this.axis;
			int reachCone = this.GetReachCone(vector);
			if (reachCone == -1)
			{
				if (!Warning.logged)
				{
					base.LogWarning("RotationLimitPolygonal reach cones are invalid.");
				}
				return rotation;
			}
			if (Vector3.Dot(this.reachCones[reachCone].B, vector) > 0f)
			{
				return rotation;
			}
			Vector3 rhs = Vector3.Cross(this.axis, vector);
			vector = Vector3.Cross(-this.reachCones[reachCone].B, rhs);
			return Quaternion.FromToRotation(rotation * this.axis, vector) * rotation;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0001EE00 File Offset: 0x0001D000
		private int GetReachCone(Vector3 L)
		{
			float num = Vector3.Dot(this.reachCones[0].S, L);
			for (int i = 0; i < this.reachCones.Length; i++)
			{
				float num2 = num;
				if (i < this.reachCones.Length - 1)
				{
					num = Vector3.Dot(this.reachCones[i + 1].S, L);
				}
				else
				{
					num = Vector3.Dot(this.reachCones[0].S, L);
				}
				if (num2 >= 0f && num < 0f)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x04000372 RID: 882
		[Range(0f, 180f)]
		public float twistLimit = 180f;

		// Token: 0x04000373 RID: 883
		[Range(0f, 3f)]
		public int smoothIterations;

		// Token: 0x04000374 RID: 884
		[HideInInspector]
		public RotationLimitPolygonal.LimitPoint[] points;

		// Token: 0x04000375 RID: 885
		[HideInInspector]
		public Vector3[] P;

		// Token: 0x04000376 RID: 886
		[HideInInspector]
		public RotationLimitPolygonal.ReachCone[] reachCones = new RotationLimitPolygonal.ReachCone[0];

		// Token: 0x02000106 RID: 262
		[Serializable]
		public class ReachCone
		{
			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x060007B2 RID: 1970 RVA: 0x00033618 File Offset: 0x00031818
			public Vector3 o
			{
				get
				{
					return this.tetrahedron[0];
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00033626 File Offset: 0x00031826
			public Vector3 a
			{
				get
				{
					return this.tetrahedron[1];
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x060007B4 RID: 1972 RVA: 0x00033634 File Offset: 0x00031834
			public Vector3 b
			{
				get
				{
					return this.tetrahedron[2];
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00033642 File Offset: 0x00031842
			public Vector3 c
			{
				get
				{
					return this.tetrahedron[3];
				}
			}

			// Token: 0x060007B6 RID: 1974 RVA: 0x00033650 File Offset: 0x00031850
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
				this.tetrahedron = new Vector3[4];
				this.tetrahedron[0] = _o;
				this.tetrahedron[1] = _a;
				this.tetrahedron[2] = _b;
				this.tetrahedron[3] = _c;
				this.volume = 0f;
				this.S = Vector3.zero;
				this.B = Vector3.zero;
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x060007B7 RID: 1975 RVA: 0x000336C5 File Offset: 0x000318C5
			public bool isValid
			{
				get
				{
					return this.volume > 0f;
				}
			}

			// Token: 0x060007B8 RID: 1976 RVA: 0x000336D4 File Offset: 0x000318D4
			public void Calculate()
			{
				Vector3 lhs = Vector3.Cross(this.a, this.b);
				this.volume = Vector3.Dot(lhs, this.c) / 6f;
				this.S = Vector3.Cross(this.a, this.b).normalized;
				this.B = Vector3.Cross(this.b, this.c).normalized;
			}

			// Token: 0x040007B3 RID: 1971
			public Vector3[] tetrahedron;

			// Token: 0x040007B4 RID: 1972
			public float volume;

			// Token: 0x040007B5 RID: 1973
			public Vector3 S;

			// Token: 0x040007B6 RID: 1974
			public Vector3 B;
		}

		// Token: 0x02000107 RID: 263
		[Serializable]
		public class LimitPoint
		{
			// Token: 0x060007B9 RID: 1977 RVA: 0x00033749 File Offset: 0x00031949
			public LimitPoint()
			{
				this.point = Vector3.forward;
				this.tangentWeight = 1f;
			}

			// Token: 0x040007B7 RID: 1975
			public Vector3 point;

			// Token: 0x040007B8 RID: 1976
			public float tangentWeight;
		}
	}
}
