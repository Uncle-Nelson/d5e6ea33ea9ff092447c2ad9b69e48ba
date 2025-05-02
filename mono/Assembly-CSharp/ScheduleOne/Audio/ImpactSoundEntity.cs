using System;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x020007B0 RID: 1968
	[RequireComponent(typeof(Rigidbody))]
	public class ImpactSoundEntity : MonoBehaviour
	{
		// Token: 0x0600355F RID: 13663 RVA: 0x000E05A4 File Offset: 0x000DE7A4
		public void Awake()
		{
			PhysicsDamageable component = base.GetComponent<PhysicsDamageable>();
			if (component != null)
			{
				PhysicsDamageable physicsDamageable = component;
				physicsDamageable.onImpacted = (Action<Impact>)Delegate.Combine(physicsDamageable.onImpacted, new Action<Impact>(this.OnImpacted));
			}
			this.rb = base.GetComponent<Rigidbody>();
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x000E05F0 File Offset: 0x000DE7F0
		private void OnImpacted(Impact impact)
		{
			if (Vector3.SqrMagnitude(impact.Hit.point - PlayerSingleton<PlayerCamera>.Instance.transform.position) > 1600f)
			{
				return;
			}
			if (Time.time - this.lastImpactTime < 0.25f)
			{
				return;
			}
			float impactForce = impact.ImpactForce;
			if (impactForce < 4f)
			{
				return;
			}
			Singleton<SFXManager>.Instance.PlayImpactSound(this.Material, impact.Hit.point, impactForce);
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x000E066C File Offset: 0x000DE86C
		private void OnCollisionEnter(Collision collision)
		{
			if (Time.time - this.lastImpactTime < 0.25f)
			{
				return;
			}
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			if (Vector3.SqrMagnitude(collision.contacts[0].point - PlayerSingleton<PlayerCamera>.Instance.transform.position) > 1600f)
			{
				return;
			}
			Rigidbody rigidbody = collision.rigidbody;
			float num = collision.relativeVelocity.magnitude;
			float num2 = this.rb.mass;
			if (rigidbody != null)
			{
				num2 = Mathf.Min(num2, rigidbody.mass);
			}
			num *= num2;
			if (num < 4f)
			{
				return;
			}
			this.lastImpactTime = Time.time;
			Singleton<SFXManager>.Instance.PlayImpactSound(this.Material, collision.contacts[0].point, num);
		}

		// Token: 0x04002656 RID: 9814
		public const float MIN_IMPACT_MOMENTUM = 4f;

		// Token: 0x04002657 RID: 9815
		public const float COOLDOWN = 0.25f;

		// Token: 0x04002658 RID: 9816
		public ImpactSoundEntity.EMaterial Material;

		// Token: 0x04002659 RID: 9817
		private float lastImpactTime;

		// Token: 0x0400265A RID: 9818
		private Rigidbody rb;

		// Token: 0x020007B1 RID: 1969
		public enum EMaterial
		{
			// Token: 0x0400265C RID: 9820
			Wood,
			// Token: 0x0400265D RID: 9821
			HollowMetal,
			// Token: 0x0400265E RID: 9822
			Cardboard,
			// Token: 0x0400265F RID: 9823
			Glass,
			// Token: 0x04002660 RID: 9824
			Plastic,
			// Token: 0x04002661 RID: 9825
			Basketball,
			// Token: 0x04002662 RID: 9826
			SmallHollowMetal,
			// Token: 0x04002663 RID: 9827
			PlasticBag,
			// Token: 0x04002664 RID: 9828
			Punch,
			// Token: 0x04002665 RID: 9829
			BaseballBat
		}
	}
}
