using System;

namespace ScheduleOne.Combat
{
	// Token: 0x02000738 RID: 1848
	public struct ExplosionData
	{
		// Token: 0x06003208 RID: 12808 RVA: 0x000CFCFC File Offset: 0x000CDEFC
		public ExplosionData(float damageRadius, float maxDamage, float maxPushForce)
		{
			this.DamageRadius = damageRadius;
			this.MaxDamage = maxDamage;
			this.PushForceRadius = damageRadius * 2f;
			this.MaxPushForce = maxPushForce;
		}

		// Token: 0x04002392 RID: 9106
		public float DamageRadius;

		// Token: 0x04002393 RID: 9107
		public float MaxDamage;

		// Token: 0x04002394 RID: 9108
		public float PushForceRadius;

		// Token: 0x04002395 RID: 9109
		public float MaxPushForce;

		// Token: 0x04002396 RID: 9110
		public static readonly ExplosionData DefaultSmall = new ExplosionData(6f, 200f, 500f);
	}
}
