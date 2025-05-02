using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x0200086A RID: 2154
	public class ParticleCollisionDetector : MonoBehaviour
	{
		// Token: 0x06003AB6 RID: 15030 RVA: 0x000F745D File Offset: 0x000F565D
		private void Awake()
		{
			this.ps = base.GetComponent<ParticleSystem>();
		}

		// Token: 0x06003AB7 RID: 15031 RVA: 0x000F746B File Offset: 0x000F566B
		public void OnParticleCollision(GameObject other)
		{
			if (this.onCollision != null)
			{
				this.onCollision.Invoke(other);
			}
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x000F7484 File Offset: 0x000F5684
		private void OnParticleTrigger()
		{
			Component collider = this.ps.trigger.GetCollider(0);
			if (collider != null && this.onCollision != null)
			{
				this.onCollision.Invoke(collider.gameObject);
			}
		}

		// Token: 0x04002A40 RID: 10816
		public UnityEvent<GameObject> onCollision = new UnityEvent<GameObject>();

		// Token: 0x04002A41 RID: 10817
		private ParticleSystem ps;
	}
}
