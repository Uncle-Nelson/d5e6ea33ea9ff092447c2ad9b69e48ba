using System;
using ScheduleOne.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000980 RID: 2432
	public class AvatarWeapon : AvatarEquippable
	{
		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x0600420C RID: 16908 RVA: 0x00115147 File Offset: 0x00113347
		// (set) Token: 0x0600420D RID: 16909 RVA: 0x0011514F File Offset: 0x0011334F
		public float LastUseTime { get; private set; }

		// Token: 0x0600420E RID: 16910 RVA: 0x00115158 File Offset: 0x00113358
		public override void Equip(Avatar _avatar)
		{
			base.Equip(_avatar);
			if (this.EquipClips.Length != 0 && this.EquipSound != null)
			{
				this.EquipSound.AudioSource.clip = this.EquipClips[Random.Range(0, this.EquipClips.Length)];
				this.EquipSound.Play();
			}
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x001151B3 File Offset: 0x001133B3
		public virtual void Attack()
		{
			this.LastUseTime = Time.time;
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x001151C0 File Offset: 0x001133C0
		public virtual bool IsReadyToAttack()
		{
			return Time.time - this.LastUseTime > this.CooldownDuration;
		}

		// Token: 0x04002F9E RID: 12190
		[Header("Range settings")]
		public float MinUseRange;

		// Token: 0x04002F9F RID: 12191
		public float MaxUseRange = 1f;

		// Token: 0x04002FA0 RID: 12192
		[Header("Cooldown settings")]
		public float CooldownDuration = 1f;

		// Token: 0x04002FA1 RID: 12193
		[Header("Equipping")]
		public AudioClip[] EquipClips;

		// Token: 0x04002FA2 RID: 12194
		public AudioSourceController EquipSound;

		// Token: 0x04002FA4 RID: 12196
		public UnityEvent onSuccessfulHit;
	}
}
