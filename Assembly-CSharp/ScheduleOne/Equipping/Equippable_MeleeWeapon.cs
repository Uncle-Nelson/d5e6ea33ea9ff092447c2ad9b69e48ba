using System;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000921 RID: 2337
	public class Equippable_MeleeWeapon : Equippable_AvatarViewmodel
	{
		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06003F2F RID: 16175 RVA: 0x0010A933 File Offset: 0x00108B33
		public bool IsLoading
		{
			get
			{
				return this.load > 0f;
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06003F30 RID: 16176 RVA: 0x0010A942 File Offset: 0x00108B42
		// (set) Token: 0x06003F31 RID: 16177 RVA: 0x0010A94A File Offset: 0x00108B4A
		public bool IsAttacking { get; private set; }

		// Token: 0x06003F32 RID: 16178 RVA: 0x0010A953 File Offset: 0x00108B53
		protected override void Update()
		{
			base.Update();
			if (Singleton<PauseMenu>.Instance.IsPaused)
			{
				return;
			}
			this.UpdateInput();
			this.UpdateCooldown();
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x0010A974 File Offset: 0x00108B74
		public override void Equip(ItemInstance item)
		{
			base.Equip(item);
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x0010A97D File Offset: 0x00108B7D
		public override void Unequip()
		{
			base.Unequip();
			PlayerSingleton<PlayerCamera>.Instance.Animator.SetFloat("Load", 0f);
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x0010A9A0 File Offset: 0x00108BA0
		private void UpdateCooldown()
		{
			if (this.remainingCooldown > 0f && !this.IsLoading && !this.IsAttacking)
			{
				this.remainingCooldown -= Time.deltaTime;
				this.remainingCooldown = Mathf.Clamp(this.remainingCooldown, 0f, this.MaxCooldown);
			}
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x0010A9F8 File Offset: 0x00108BF8
		private void UpdateInput()
		{
			if (GameInput.GetButton(GameInput.ButtonCode.PrimaryClick))
			{
				if (this.load == 0f)
				{
					if (!GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick) && (!this.loadQueued || !GameInput.GetButton(GameInput.ButtonCode.PrimaryClick)))
					{
						return;
					}
					if (this.CanStartLoading())
					{
						this.StartLoad();
					}
					else if (this.clickReleased)
					{
						this.loadQueued = true;
					}
				}
				if (this.load >= 0.0001f)
				{
					this.load += Time.deltaTime;
					if (this.load < this.MaxLoadTime)
					{
						PlayerSingleton<PlayerMovement>.Instance.ChangeStamina(-(this.MaxStaminaCost - this.MinStaminaCost) * Time.deltaTime / this.MaxLoadTime, true);
					}
					else
					{
						PlayerSingleton<PlayerMovement>.Instance.ChangeStamina(-1E-07f, true);
					}
				}
				this.clickReleased = false;
				Singleton<ViewmodelAvatar>.Instance.Animator.SetFloat("Load", Mathf.Clamp01(this.load / this.MaxLoadTime));
				PlayerSingleton<PlayerCamera>.Instance.Animator.SetFloat("Load", Mathf.Clamp01(this.load / this.MaxLoadTime));
				if (this.IsLoading && PlayerSingleton<PlayerMovement>.Instance.CurrentStaminaReserve <= 0f)
				{
					this.Release();
					return;
				}
			}
			else
			{
				this.clickReleased = true;
				this.loadQueued = false;
				if (this.load > 0f)
				{
					this.Release();
				}
			}
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x0010AB50 File Offset: 0x00108D50
		private bool CanStartLoading()
		{
			return this.remainingCooldown <= 0f && !this.IsAttacking && base.equipAnimDone && PlayerSingleton<PlayerMovement>.Instance.CurrentStaminaReserve >= this.MinStaminaCost && !GameManager.IS_TUTORIAL;
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x0010ABA0 File Offset: 0x00108DA0
		private void StartLoad()
		{
			this.loadQueued = false;
			this.load = 0.001f;
			PlayerSingleton<PlayerMovement>.Instance.ChangeStamina(-this.MinStaminaCost, true);
			Singleton<ViewmodelAvatar>.Instance.Animator.SetFloat("Load", 0f);
			PlayerSingleton<PlayerCamera>.Instance.Animator.SetFloat("Load", 0f);
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x0010AC04 File Offset: 0x00108E04
		private void Release()
		{
			this.loadQueued = false;
			float num = Mathf.Clamp01(this.load / this.MaxLoadTime);
			this.remainingCooldown = Mathf.Lerp(this.MinCooldown, this.MaxCooldown, num);
			this.Hit(num);
			PlayerSingleton<PlayerMovement>.Instance.SetResidualVelocity(Player.Local.transform.forward, Mathf.Lerp(0f, 300f, num), Mathf.Lerp(0.05f, 0.15f, num));
			if (num >= 1f)
			{
				Singleton<ViewmodelAvatar>.Instance.Animator.SetTrigger("Release_Heavy");
				PlayerSingleton<PlayerCamera>.Instance.Animator.SetTrigger("Release_Heavy");
			}
			else
			{
				Singleton<ViewmodelAvatar>.Instance.Animator.SetTrigger("Release_Light");
				PlayerSingleton<PlayerCamera>.Instance.Animator.SetTrigger("Release_Light");
			}
			if (this.SwingAnimationTrigger != string.Empty)
			{
				Player.Local.SendAnimationTrigger(this.SwingAnimationTrigger);
			}
			this.load = 0f;
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x0010AD0C File Offset: 0x00108F0C
		private void Hit(float power)
		{
			Equippable_MeleeWeapon.<>c__DisplayClass37_0 CS$<>8__locals1 = new Equippable_MeleeWeapon.<>c__DisplayClass37_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.power = power;
			this.IsAttacking = true;
			this.WhooshSound.VolumeMultiplier = Mathf.Lerp(0.4f, 1f, CS$<>8__locals1.power);
			this.WhooshSound.PitchMultiplier = Mathf.Lerp(1f, 0.8f, CS$<>8__locals1.power) * this.WhooshSoundPitch;
			this.WhooshSound.Play();
			this.hitRoutine = base.StartCoroutine(CS$<>8__locals1.<Hit>g__HitRoutine|0());
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x0010AD98 File Offset: 0x00108F98
		private void ExecuteHit(float power)
		{
			RaycastHit hit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(this.Range, out hit, NetworkSingleton<CombatManager>.Instance.MeleeLayerMask, true, this.HitRadius))
			{
				IDamageable componentInParent = hit.collider.GetComponentInParent<IDamageable>();
				if (componentInParent != null)
				{
					float impactDamage = Mathf.Lerp(this.MinDamage, this.MaxDamage, power);
					float impactForce = Mathf.Lerp(this.MinForce, this.MaxForce, power);
					Impact impact = new Impact(hit, hit.point, PlayerSingleton<PlayerCamera>.Instance.transform.forward, impactForce, impactDamage, this.ImpactType, Player.Local, Random.Range(int.MinValue, int.MaxValue));
					string[] array = new string[7];
					array[0] = "Hit ";
					int num = 1;
					IDamageable damageable = componentInParent;
					array[num] = ((damageable != null) ? damageable.ToString() : null);
					array[2] = " with ";
					array[3] = impactDamage.ToString();
					array[4] = " damage and ";
					array[5] = impactForce.ToString();
					array[6] = " force.";
					Console.Log(string.Concat(array), null);
					componentInParent.SendImpact(impact);
					Singleton<FXManager>.Instance.CreateImpactFX(impact);
					this.ImpactSound.Play();
					PlayerSingleton<PlayerCamera>.Instance.StartCameraShake(Mathf.Lerp(0.1f, 0.4f, power), 0.2f, true);
					if (componentInParent is NPC)
					{
						Player.Local.VisualState.ApplyState("melee_attack", PlayerVisualState.EVisualState.Brandishing, 2.5f);
					}
				}
			}
		}

		// Token: 0x04002D58 RID: 11608
		[Header("Basic Settings")]
		public EImpactType ImpactType;

		// Token: 0x04002D59 RID: 11609
		public float Range = 1.25f;

		// Token: 0x04002D5A RID: 11610
		public float HitRadius = 0.2f;

		// Token: 0x04002D5B RID: 11611
		[Header("Timing")]
		public float MaxLoadTime = 1f;

		// Token: 0x04002D5C RID: 11612
		public float MinCooldown = 0.1f;

		// Token: 0x04002D5D RID: 11613
		public float MaxCooldown = 0.2f;

		// Token: 0x04002D5E RID: 11614
		public float MinHitDelay = 0.1f;

		// Token: 0x04002D5F RID: 11615
		public float MaxHitDelay = 0.2f;

		// Token: 0x04002D60 RID: 11616
		[Header("Damage")]
		public float MinDamage = 20f;

		// Token: 0x04002D61 RID: 11617
		public float MaxDamage = 60f;

		// Token: 0x04002D62 RID: 11618
		public float MinForce = 100f;

		// Token: 0x04002D63 RID: 11619
		public float MaxForce = 300f;

		// Token: 0x04002D64 RID: 11620
		[Header("Stamina Settings")]
		public float MinStaminaCost = 10f;

		// Token: 0x04002D65 RID: 11621
		public float MaxStaminaCost = 40f;

		// Token: 0x04002D66 RID: 11622
		[Header("Sound")]
		public AudioSourceController WhooshSound;

		// Token: 0x04002D67 RID: 11623
		public float WhooshSoundPitch = 1f;

		// Token: 0x04002D68 RID: 11624
		public AudioSourceController ImpactSound;

		// Token: 0x04002D69 RID: 11625
		[Header("Animation")]
		public string SwingAnimationTrigger;

		// Token: 0x04002D6A RID: 11626
		private float load;

		// Token: 0x04002D6B RID: 11627
		private float remainingCooldown;

		// Token: 0x04002D6C RID: 11628
		private Coroutine hitRoutine;

		// Token: 0x04002D6D RID: 11629
		private bool loadQueued;

		// Token: 0x04002D6E RID: 11630
		private bool clickReleased;
	}
}
