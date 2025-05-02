using System;
using ScheduleOne.Audio;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x0200097A RID: 2426
	public class AvatarMeleeWeapon : AvatarWeapon
	{
		// Token: 0x060041EE RID: 16878 RVA: 0x001149EB File Offset: 0x00112BEB
		public override void Unequip()
		{
			if (this.attackRoutine != null)
			{
				base.StopCoroutine(this.attackRoutine);
				this.attackRoutine = null;
			}
			base.Unequip();
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x00114A10 File Offset: 0x00112C10
		public override void Attack()
		{
			AvatarMeleeWeapon.<>c__DisplayClass10_0 CS$<>8__locals1 = new AvatarMeleeWeapon.<>c__DisplayClass10_0();
			CS$<>8__locals1.<>4__this = this;
			base.Attack();
			CS$<>8__locals1.attack = this.Attacks[Random.Range(0, this.Attacks.Length)];
			CS$<>8__locals1.npc = this.avatar.GetComponentInParent<NPC>();
			this.avatar.Anim.ResetTrigger(CS$<>8__locals1.attack.AnimationTrigger);
			this.avatar.Anim.SetTrigger(CS$<>8__locals1.attack.AnimationTrigger);
			this.attackRoutine = base.StartCoroutine(CS$<>8__locals1.<Attack>g__AttackRoutine|0());
		}

		// Token: 0x04002F71 RID: 12145
		public const float GruntChance = 0.4f;

		// Token: 0x04002F72 RID: 12146
		[Header("References")]
		public AudioSourceController AttackSound;

		// Token: 0x04002F73 RID: 12147
		public AudioSourceController HitSound;

		// Token: 0x04002F74 RID: 12148
		[Header("Melee Weapon settings")]
		public float AttackRange = 1.5f;

		// Token: 0x04002F75 RID: 12149
		public float AttackRadius = 0.25f;

		// Token: 0x04002F76 RID: 12150
		public float Damage = 25f;

		// Token: 0x04002F77 RID: 12151
		public AvatarMeleeWeapon.MeleeAttack[] Attacks;

		// Token: 0x04002F78 RID: 12152
		private Coroutine attackRoutine;

		// Token: 0x0200097B RID: 2427
		[Serializable]
		public class MeleeAttack
		{
			// Token: 0x04002F79 RID: 12153
			public float RangeMultiplier = 1f;

			// Token: 0x04002F7A RID: 12154
			public float DamageMultiplier = 1f;

			// Token: 0x04002F7B RID: 12155
			public string AnimationTrigger = string.Empty;

			// Token: 0x04002F7C RID: 12156
			public float DamageDelay = 0.4f;

			// Token: 0x04002F7D RID: 12157
			public float AttackSoundDelay;

			// Token: 0x04002F7E RID: 12158
			public AudioClip[] AttackClips;

			// Token: 0x04002F7F RID: 12159
			public AudioClip[] HitClips;
		}
	}
}
