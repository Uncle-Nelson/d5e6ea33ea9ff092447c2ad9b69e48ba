using System;
using System.Collections.Generic;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000136 RID: 310
	public class PolygonHelper : MonoBehaviour
	{
		// Token: 0x02000137 RID: 311
		public struct Plane2D
		{
			// Token: 0x06000542 RID: 1346 RVA: 0x0001970A File Offset: 0x0001790A
			public float Distance(Vector2 point)
			{
				return Vector2.Dot(this.normal, point) + this.distance;
			}

			// Token: 0x06000543 RID: 1347 RVA: 0x0001971F File Offset: 0x0001791F
			public Vector2 ClosestPoint(Vector2 pt)
			{
				return pt - this.normal * this.Distance(pt);
			}

			// Token: 0x06000544 RID: 1348 RVA: 0x0001973C File Offset: 0x0001793C
			public Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				float num = Vector2.Dot(this.normal, p1 - p2);
				if (Utils.IsAlmostZero(num))
				{
					return (p1 + p2) * 0.5f;
				}
				float d = (this.normal.x * p1.x + this.normal.y * p1.y + this.distance) / num;
				return p1 + d * (p2 - p1);
			}

			// Token: 0x06000545 RID: 1349 RVA: 0x000197B8 File Offset: 0x000179B8
			public bool GetSide(Vector2 point)
			{
				return this.Distance(point) > 0f;
			}

			// Token: 0x06000546 RID: 1350 RVA: 0x000197C8 File Offset: 0x000179C8
			public static PolygonHelper.Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				Vector3 normalized = (p2 - p1).normalized;
				return new PolygonHelper.Plane2D
				{
					normal = new Vector2(normalized.y, -normalized.x),
					distance = -normalized.y * p1.x + normalized.x * p1.y
				};
			}

			// Token: 0x06000547 RID: 1351 RVA: 0x0001982C File Offset: 0x00017A2C
			public static PolygonHelper.Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				return new PolygonHelper.Plane2D
				{
					normal = normalizedNormal,
					distance = -normalizedNormal.x * p1.x - normalizedNormal.y * p1.y
				};
			}

			// Token: 0x06000548 RID: 1352 RVA: 0x00019872 File Offset: 0x00017A72
			public void Flip()
			{
				this.normal = -this.normal;
				this.distance = -this.distance;
			}

			// Token: 0x06000549 RID: 1353 RVA: 0x00019894 File Offset: 0x00017A94
			public Vector2[] CutConvex(Vector2[] poly)
			{
				List<Vector2> list = new List<Vector2>(poly.Length);
				Vector2 vector = poly[poly.Length - 1];
				foreach (Vector2 vector2 in poly)
				{
					bool side = this.GetSide(vector);
					bool side2 = this.GetSide(vector2);
					if (side && side2)
					{
						list.Add(vector2);
					}
					else if (side && !side2)
					{
						list.Add(this.Intersect(vector, vector2));
					}
					else if (!side && side2)
					{
						list.Add(this.Intersect(vector, vector2));
						list.Add(vector2);
					}
					vector = vector2;
				}
				return list.ToArray();
			}

			// Token: 0x0600054A RID: 1354 RVA: 0x00019936 File Offset: 0x00017B36
			public override string ToString()
			{
				return string.Format("{0} x {1} + {2}", this.normal.x, this.normal.y, this.distance);
			}

			// Token: 0x0400068C RID: 1676
			public Vector2 normal;

			// Token: 0x0400068D RID: 1677
			public float distance;
		}
	}
}
