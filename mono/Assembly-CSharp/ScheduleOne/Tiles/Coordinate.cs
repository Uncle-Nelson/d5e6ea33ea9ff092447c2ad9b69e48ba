using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002B4 RID: 692
	[Serializable]
	public class Coordinate
	{
		// Token: 0x06000ED9 RID: 3801 RVA: 0x00041B96 File Offset: 0x0003FD96
		public static implicit operator Vector2(Coordinate c)
		{
			return new Vector2((float)c.x, (float)c.y);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00041BAB File Offset: 0x0003FDAB
		public Coordinate()
		{
			this.x = 0;
			this.y = 0;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00041BC1 File Offset: 0x0003FDC1
		public Coordinate(int _x, int _y)
		{
			this.x = _x;
			this.y = _y;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00041BD7 File Offset: 0x0003FDD7
		public Coordinate(Vector2 vector)
		{
			this.x = (int)vector.x;
			this.y = (int)vector.y;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00041BF9 File Offset: 0x0003FDF9
		public override int GetHashCode()
		{
			return this.SignedCantorPair(this.x, this.y);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00041C10 File Offset: 0x0003FE10
		public override bool Equals(object obj)
		{
			Coordinate coordinate = obj as Coordinate;
			return coordinate != null && coordinate.x == this.x && coordinate.y == this.y;
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00041C45 File Offset: 0x0003FE45
		public static Coordinate operator +(Coordinate a, Coordinate b)
		{
			return new Coordinate(a.x + b.x, a.y + b.y);
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00041C66 File Offset: 0x0003FE66
		public static Coordinate operator -(Coordinate a, Coordinate b)
		{
			return new Coordinate(a.x - b.x, a.y - b.y);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00041C87 File Offset: 0x0003FE87
		private int CantorPair(int x, int y)
		{
			return (int)(0.5f * (float)(x + y) * ((float)(x + y) + 1f) + (float)y);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00041CA4 File Offset: 0x0003FEA4
		private int SignedCantorPair(int x, int y)
		{
			int num = (int)(((float)x >= 0f) ? (2f * (float)x) : (-2f * (float)x - 1f));
			int num2 = (int)(((float)y >= 0f) ? (2f * (float)y) : (-2f * (float)y - 1f));
			return this.CantorPair(num, num2);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00041D00 File Offset: 0x0003FF00
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"[",
				this.x.ToString(),
				",",
				this.y.ToString(),
				"]"
			});
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00041D4C File Offset: 0x0003FF4C
		public static List<CoordinatePair> BuildCoordinateMatches(Coordinate originCoord, int sizeX, int sizeY, float rot)
		{
			List<CoordinatePair> list = new List<CoordinatePair>();
			rot = (float)Coordinate.MathMod(Mathf.RoundToInt(rot), 360);
			for (int i = 0; i < sizeX; i++)
			{
				for (int j = 0; j < sizeY; j++)
				{
					Coordinate coordinate = new Coordinate(originCoord.x, originCoord.y);
					if ((double)rot == 0.0)
					{
						coordinate.x += i;
						coordinate.y += j;
					}
					else if (rot == 90f)
					{
						coordinate.x += j;
						coordinate.y -= i;
					}
					else if (rot == 180f)
					{
						coordinate.x -= i;
						coordinate.y -= j;
					}
					else if (rot == 270f)
					{
						coordinate.x -= j;
						coordinate.y += i;
					}
					else
					{
						Console.LogWarning("Cock!!!!!! " + rot.ToString(), null);
					}
					list.Add(new CoordinatePair(new Coordinate(i, j), coordinate));
				}
			}
			return list;
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00041E74 File Offset: 0x00040074
		public static Coordinate RotateCoordinates(Coordinate coord, float angle)
		{
			angle = (float)Coordinate.MathMod(Mathf.RoundToInt(angle), 360);
			if (Mathf.Abs(angle - 90f) < 0.01f)
			{
				return new Coordinate(coord.y, -coord.x);
			}
			if (Mathf.Abs(angle - 180f) < 0.01f)
			{
				return new Coordinate(-coord.x, -coord.y);
			}
			if (Mathf.Abs(angle - 270f) < 0.01f)
			{
				return new Coordinate(-coord.y, coord.x);
			}
			return coord;
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00041F08 File Offset: 0x00040108
		private static int MathMod(int a, int b)
		{
			return (Mathf.Abs(a * b) + a) % b;
		}

		// Token: 0x04000F4C RID: 3916
		public int x;

		// Token: 0x04000F4D RID: 3917
		public int y;
	}
}
