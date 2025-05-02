using System;
using UnityEngine;

namespace ScheduleOne.Levelling
{
	// Token: 0x020005AE RID: 1454
	[Serializable]
	public struct FullRank
	{
		// Token: 0x060023FD RID: 9213 RVA: 0x00092122 File Offset: 0x00090322
		public FullRank(ERank rank, int tier)
		{
			this.Rank = rank;
			this.Tier = tier;
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x00092132 File Offset: 0x00090332
		public override string ToString()
		{
			return FullRank.GetString(this);
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x00092140 File Offset: 0x00090340
		public FullRank NextRank()
		{
			if (this.Rank == ERank.Kingpin)
			{
				return new FullRank(ERank.Kingpin, this.Tier + 1);
			}
			if (this.Tier < 5)
			{
				return new FullRank(this.Rank, this.Tier + 1);
			}
			return new FullRank(this.Rank + 1, 1);
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x00092194 File Offset: 0x00090394
		public static string GetString(FullRank rank)
		{
			string text = rank.Rank.ToString();
			text = text.Replace("_", " ");
			switch (rank.Tier)
			{
			case 1:
				text += " I";
				break;
			case 2:
				text += " II";
				break;
			case 3:
				text += " III";
				break;
			case 4:
				text += " IV";
				break;
			case 5:
				text += " V";
				break;
			default:
				text = text + " " + rank.Tier.ToString();
				break;
			}
			return text;
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x00092249 File Offset: 0x00090449
		public static bool operator >(FullRank a, FullRank b)
		{
			return a.Rank > b.Rank || (a.Rank == b.Rank && a.Tier > b.Tier);
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x00092279 File Offset: 0x00090479
		public static bool operator <(FullRank a, FullRank b)
		{
			return a.Rank < b.Rank || (a.Rank == b.Rank && a.Tier < b.Tier);
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x000922A9 File Offset: 0x000904A9
		public static bool operator <=(FullRank a, FullRank b)
		{
			return a < b || a == b;
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x000922BD File Offset: 0x000904BD
		public static bool operator >=(FullRank a, FullRank b)
		{
			return a > b || a == b;
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x000922D1 File Offset: 0x000904D1
		public static bool operator ==(FullRank a, FullRank b)
		{
			return a.Rank == b.Rank && a.Tier == b.Tier;
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x000922F1 File Offset: 0x000904F1
		public static bool operator !=(FullRank a, FullRank b)
		{
			return a.Rank != b.Rank || a.Tier != b.Tier;
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x00092314 File Offset: 0x00090514
		public override bool Equals(object obj)
		{
			return obj is FullRank && this == (FullRank)obj;
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00092331 File Offset: 0x00090531
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00092343 File Offset: 0x00090543
		public int CompareTo(FullRank other)
		{
			if (this > other)
			{
				return 1;
			}
			if (this < other)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x04001AE0 RID: 6880
		public ERank Rank;

		// Token: 0x04001AE1 RID: 6881
		[Range(1f, 5f)]
		public int Tier;
	}
}
