using System;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C1C RID: 3100
	public class FoliageRustleSound : MonoBehaviour
	{
		// Token: 0x0600570E RID: 22286 RVA: 0x0016DED4 File Offset: 0x0016C0D4
		private void Awake()
		{
			base.InvokeRepeating("UpdateActive", Random.Range(0f, 3f), 3f);
			this.Container.SetActive(false);
		}

		// Token: 0x0600570F RID: 22287 RVA: 0x0016DF04 File Offset: 0x0016C104
		public void OnTriggerEnter(Collider other)
		{
			if (Time.timeSinceLevelLoad - this.timeOnLastHit > 1f)
			{
				Player componentInParent = other.gameObject.GetComponentInParent<Player>();
				if (componentInParent != null)
				{
					if (componentInParent.IsOwner)
					{
						this.Sound.VolumeMultiplier = Mathf.Clamp01(PlayerSingleton<PlayerMovement>.Instance.Controller.velocity.magnitude / (PlayerMovement.WalkSpeed * PlayerMovement.SprintMultiplier));
					}
					else
					{
						this.Sound.VolumeMultiplier = 1f;
					}
					this.Sound.Play();
					this.timeOnLastHit = Time.timeSinceLevelLoad;
				}
			}
		}

		// Token: 0x06005710 RID: 22288 RVA: 0x0016DF9C File Offset: 0x0016C19C
		private void UpdateActive()
		{
			if (Player.Local == null)
			{
				return;
			}
			float num = Vector3.SqrMagnitude(Player.Local.Avatar.CenterPoint - base.transform.position);
			this.Container.SetActive(num < 900f);
		}

		// Token: 0x04004065 RID: 16485
		public const float ACTIVATION_RANGE_SQUARED = 900f;

		// Token: 0x04004066 RID: 16486
		public const float COOLDOWN = 1f;

		// Token: 0x04004067 RID: 16487
		public AudioSourceController Sound;

		// Token: 0x04004068 RID: 16488
		public GameObject Container;

		// Token: 0x04004069 RID: 16489
		private float timeOnLastHit;
	}
}
