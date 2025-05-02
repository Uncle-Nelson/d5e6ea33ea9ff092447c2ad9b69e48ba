using System;
using ScheduleOne.NPCs;
using ScheduleOne.Police;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x0200084E RID: 2126
	[RequireComponent(typeof(Rigidbody))]
	public class CombatNPCDetector : MonoBehaviour
	{
		// Token: 0x06003A50 RID: 14928 RVA: 0x000F6760 File Offset: 0x000F4960
		private void Awake()
		{
			Rigidbody rigidbody = base.GetComponent<Rigidbody>();
			if (rigidbody == null)
			{
				rigidbody = base.gameObject.AddComponent<Rigidbody>();
			}
			rigidbody.isKinematic = true;
		}

		// Token: 0x06003A51 RID: 14929 RVA: 0x000F6790 File Offset: 0x000F4990
		private void FixedUpdate()
		{
			if (this.timeSinceLastContact < 0.1f)
			{
				this.contactTime += Time.fixedDeltaTime;
				if (this.contactTime >= this.ContactTimeForDetection)
				{
					this.contactTime = 0f;
					if (this.onDetected != null)
					{
						this.onDetected.Invoke();
					}
				}
			}
			else
			{
				this.contactTime = 0f;
			}
			this.timeSinceLastContact += Time.fixedDeltaTime;
		}

		// Token: 0x06003A52 RID: 14930 RVA: 0x000F6808 File Offset: 0x000F4A08
		private void OnTriggerStay(Collider other)
		{
			NPC componentInParent = other.GetComponentInParent<NPC>();
			if (componentInParent != null && (!this.DetectOnlyInCombat || componentInParent.behaviour.CombatBehaviour.Active))
			{
				this.timeSinceLastContact = 0f;
				return;
			}
			PoliceOfficer policeOfficer = componentInParent as PoliceOfficer;
			if (policeOfficer != null && (!this.DetectOnlyInCombat || policeOfficer.PursuitBehaviour.Active))
			{
				this.timeSinceLastContact = 0f;
				return;
			}
		}

		// Token: 0x040029F8 RID: 10744
		public bool DetectOnlyInCombat;

		// Token: 0x040029F9 RID: 10745
		public UnityEvent onDetected;

		// Token: 0x040029FA RID: 10746
		public float ContactTimeForDetection = 0.5f;

		// Token: 0x040029FB RID: 10747
		private float contactTime;

		// Token: 0x040029FC RID: 10748
		private float timeSinceLastContact = 100f;
	}
}
