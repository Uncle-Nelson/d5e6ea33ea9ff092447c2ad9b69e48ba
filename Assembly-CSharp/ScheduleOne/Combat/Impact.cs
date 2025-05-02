using System;
using FishNet.Object;
using FishNet.Serializing.Helping;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x0200073B RID: 1851
	[Serializable]
	public class Impact
	{
		// Token: 0x0600320C RID: 12812 RVA: 0x000CFD3C File Offset: 0x000CDF3C
		public Impact(RaycastHit hit, Vector3 hitPoint, Vector3 impactForceDirection, float impactForce, float impactDamage, EImpactType impactType, Player impactSource, int impactID)
		{
			this.Hit = hit;
			this.HitPoint = hitPoint;
			this.ImpactForceDirection = impactForceDirection;
			this.ImpactForce = impactForce;
			this.ImpactDamage = impactDamage;
			this.ImpactType = impactType;
			if (impactSource != null)
			{
				this.ImpactSource = impactSource.NetworkObject;
			}
			this.ImpactID = impactID;
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x0000494F File Offset: 0x00002B4F
		public Impact()
		{
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x000CFD9B File Offset: 0x000CDF9B
		public static bool IsLethal(EImpactType impactType)
		{
			return impactType == EImpactType.SharpMetal || impactType == EImpactType.Bullet || impactType == EImpactType.Explosion;
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x000CFDAC File Offset: 0x000CDFAC
		public bool IsPlayerImpact(out Player player)
		{
			if (this.ImpactSource == null)
			{
				player = null;
				return false;
			}
			player = this.ImpactSource.GetComponent<Player>();
			return player != null;
		}

		// Token: 0x0400239E RID: 9118
		[CodegenExclude]
		public RaycastHit Hit;

		// Token: 0x0400239F RID: 9119
		public Vector3 HitPoint;

		// Token: 0x040023A0 RID: 9120
		public Vector3 ImpactForceDirection;

		// Token: 0x040023A1 RID: 9121
		public float ImpactForce;

		// Token: 0x040023A2 RID: 9122
		public float ImpactDamage;

		// Token: 0x040023A3 RID: 9123
		public EImpactType ImpactType;

		// Token: 0x040023A4 RID: 9124
		public NetworkObject ImpactSource;

		// Token: 0x040023A5 RID: 9125
		public int ImpactID;
	}
}
