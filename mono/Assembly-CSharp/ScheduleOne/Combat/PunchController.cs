using System;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dragging;
using ScheduleOne.FX;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Combat
{
	// Token: 0x0200073D RID: 1853
	public class PunchController : MonoBehaviour
	{
		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06003216 RID: 12822 RVA: 0x000CFED1 File Offset: 0x000CE0D1
		// (set) Token: 0x06003217 RID: 12823 RVA: 0x000CFED9 File Offset: 0x000CE0D9
		public bool PunchingEnabled { get; set; } = true;

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06003218 RID: 12824 RVA: 0x000CFEE2 File Offset: 0x000CE0E2
		public bool IsLoading
		{
			get
			{
				return this.punchLoad > 0f;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06003219 RID: 12825 RVA: 0x000CFEF1 File Offset: 0x000CE0F1
		// (set) Token: 0x0600321A RID: 12826 RVA: 0x000CFEF9 File Offset: 0x000CE0F9
		public bool IsPunching { get; private set; }

		// Token: 0x0600321B RID: 12827 RVA: 0x000CFF02 File Offset: 0x000CE102
		private void Awake()
		{
			this.player = base.GetComponentInParent<Player>();
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x000CFF10 File Offset: 0x000CE110
		private void Start()
		{
			PlayerSingleton<PlayerInventory>.Instance.onPreItemEquipped.AddListener(new UnityAction(delegate()
			{
				this.SetPunchingEnabled(false);
			}));
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x000CFF2D File Offset: 0x000CE12D
		private void Update()
		{
			this.SetPunchingEnabled(this.ShouldBeEnabled());
			if (!this.PunchingEnabled || this.timeSincePunchingEnabled < 0.1f)
			{
				return;
			}
			this.UpdateInput();
			this.UpdateCooldown();
			this.itemEquippedLastFrame = PlayerSingleton<PlayerInventory>.Instance.isAnythingEquipped;
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x000CFF6D File Offset: 0x000CE16D
		private void LateUpdate()
		{
			if (this.PunchingEnabled)
			{
				this.timeSincePunchingEnabled += Time.deltaTime;
				return;
			}
			this.timeSincePunchingEnabled = 0f;
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x000CFF98 File Offset: 0x000CE198
		private void UpdateCooldown()
		{
			if (this.remainingCooldown > 0f && !this.IsLoading && !this.IsPunching)
			{
				this.remainingCooldown -= Time.deltaTime;
				this.remainingCooldown = Mathf.Clamp(this.remainingCooldown, 0f, 0.2f);
			}
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x000CFFF0 File Offset: 0x000CE1F0
		private void UpdateInput()
		{
			if (GameInput.GetButton(GameInput.ButtonCode.PrimaryClick))
			{
				if (this.punchLoad == 0f)
				{
					if (!this.CanStartLoading() || !GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick))
					{
						return;
					}
					this.StartLoad();
				}
				this.punchLoad += Time.deltaTime;
				Singleton<ViewmodelAvatar>.Instance.Animator.SetFloat("Load", this.punchLoad / 1f);
				PlayerSingleton<PlayerCamera>.Instance.Animator.SetFloat("Load", this.punchLoad / 1f);
				if (this.punchLoad < 1f)
				{
					PlayerSingleton<PlayerMovement>.Instance.ChangeStamina(-(this.MaxStaminaCost - this.MinStaminaCost) * Time.deltaTime / 1f, true);
				}
				else
				{
					PlayerSingleton<PlayerMovement>.Instance.ChangeStamina(-1E-07f, true);
				}
				if (this.IsLoading && PlayerSingleton<PlayerMovement>.Instance.CurrentStaminaReserve <= 0f)
				{
					this.Release();
					return;
				}
			}
			else if (this.punchLoad > 0f)
			{
				this.Release();
			}
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x000D00F8 File Offset: 0x000CE2F8
		private bool CanStartLoading()
		{
			return this.remainingCooldown <= 0f && !this.IsPunching && PlayerSingleton<PlayerMovement>.Instance.CurrentStaminaReserve >= this.MinStaminaCost && !this.itemEquippedLastFrame && !GameManager.IS_TUTORIAL;
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x000D0148 File Offset: 0x000CE348
		private void StartLoad()
		{
			PlayerSingleton<PlayerMovement>.Instance.ChangeStamina(-this.MinStaminaCost, true);
			Singleton<ViewmodelAvatar>.Instance.SetVisibility(true);
			Singleton<ViewmodelAvatar>.Instance.SetOffset(this.ViewmodelAvatarOffset);
			Singleton<ViewmodelAvatar>.Instance.SetAnimatorController(this.PunchAnimator);
			Singleton<ViewmodelAvatar>.Instance.Animator.SetFloat("Load", 0f);
			PlayerSingleton<PlayerCamera>.Instance.Animator.SetFloat("Load", 0f);
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x000D01C4 File Offset: 0x000CE3C4
		private void Release()
		{
			float num = Mathf.Clamp01(this.punchLoad / 1f);
			this.Punch(num);
			PlayerSingleton<PlayerMovement>.Instance.SetResidualVelocity(this.player.transform.forward, Mathf.Lerp(0f, 300f, num), Mathf.Lerp(0.05f, 0.15f, num));
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
			this.punchLoad = 0f;
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x000D028C File Offset: 0x000CE48C
		private void Punch(float power)
		{
			PunchController.<>c__DisplayClass39_0 CS$<>8__locals1 = new PunchController.<>c__DisplayClass39_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.power = power;
			this.IsPunching = true;
			this.PunchSound.VolumeMultiplier = Mathf.Lerp(0.4f, 1f, CS$<>8__locals1.power);
			this.PunchSound.PitchMultiplier = Mathf.Lerp(1f, 0.8f, CS$<>8__locals1.power);
			this.PunchSound.Play();
			this.player.SendPunch();
			this.punchRoutine = base.StartCoroutine(CS$<>8__locals1.<Punch>g__PunchRoutine|0());
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x000D031C File Offset: 0x000CE51C
		private void ExecuteHit(float power)
		{
			RaycastHit hit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(1.25f, out hit, NetworkSingleton<CombatManager>.Instance.MeleeLayerMask, true, 0.3f))
			{
				IDamageable componentInParent = hit.collider.GetComponentInParent<IDamageable>();
				if (componentInParent != null)
				{
					float impactDamage = Mathf.Lerp(this.MinPunchDamage, this.MaxPunchDamage, power);
					float impactForce = Mathf.Lerp(this.MinPunchForce, this.MaxPunchForce, power);
					Impact impact = new Impact(hit, hit.point, PlayerSingleton<PlayerCamera>.Instance.transform.forward, impactForce, impactDamage, EImpactType.Punch, this.player, Random.Range(int.MinValue, int.MaxValue));
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
					PlayerSingleton<PlayerCamera>.Instance.StartCameraShake(Mathf.Lerp(0.1f, 0.4f, power), 0.2f, true);
				}
			}
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x000D0448 File Offset: 0x000CE648
		private void SetPunchingEnabled(bool enabled)
		{
			if (this.PunchingEnabled == enabled)
			{
				return;
			}
			this.PunchingEnabled = enabled;
			if (!this.PunchingEnabled)
			{
				this.punchLoad = 0f;
				Singleton<ViewmodelAvatar>.Instance.Animator.SetFloat("Load", 0f);
				Singleton<ViewmodelAvatar>.Instance.SetVisibility(false);
				PlayerSingleton<PlayerCamera>.Instance.Animator.SetFloat("Load", 0f);
				if (this.punchRoutine != null)
				{
					base.StopCoroutine(this.punchRoutine);
					this.remainingCooldown = 0.1f;
					this.IsPunching = false;
					this.punchRoutine = null;
				}
			}
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x000D04E4 File Offset: 0x000CE6E4
		private bool ShouldBeEnabled()
		{
			return PlayerSingleton<PlayerInventory>.InstanceExists && PlayerSingleton<PlayerCamera>.InstanceExists && !(Player.Local == null) && Singleton<PauseMenu>.InstanceExists && !PlayerSingleton<PlayerInventory>.Instance.isAnythingEquipped && PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount <= 0 && !Singleton<PauseMenu>.Instance.IsPaused && !(Player.Local.CurrentVehicle != null) && Player.Local.Health.IsAlive && !NetworkSingleton<DragManager>.Instance.IsDragging;
		}

		// Token: 0x040023AD RID: 9133
		public const float MAX_PUNCH_LOAD = 1f;

		// Token: 0x040023AE RID: 9134
		public const float MIN_COOLDOWN = 0.1f;

		// Token: 0x040023AF RID: 9135
		public const float MAX_COOLDOWN = 0.2f;

		// Token: 0x040023B0 RID: 9136
		public const float PUNCH_RANGE = 1.25f;

		// Token: 0x040023B1 RID: 9137
		public const float PUNCH_DEBOUNCE = 0.1f;

		// Token: 0x040023B4 RID: 9140
		[Header("Settings")]
		public Vector3 ViewmodelAvatarOffset = new Vector3(0f, 0f, 0f);

		// Token: 0x040023B5 RID: 9141
		public float MinPunchDamage = 20f;

		// Token: 0x040023B6 RID: 9142
		public float MaxPunchDamage = 60f;

		// Token: 0x040023B7 RID: 9143
		public float MinPunchForce = 100f;

		// Token: 0x040023B8 RID: 9144
		public float MaxPunchForce = 300f;

		// Token: 0x040023B9 RID: 9145
		[Header("Stamina Settings")]
		public float MinStaminaCost = 10f;

		// Token: 0x040023BA RID: 9146
		public float MaxStaminaCost = 40f;

		// Token: 0x040023BB RID: 9147
		[Header("References")]
		public AudioSourceController PunchSound;

		// Token: 0x040023BC RID: 9148
		public RuntimeAnimatorController PunchAnimator;

		// Token: 0x040023BD RID: 9149
		private float punchLoad;

		// Token: 0x040023BE RID: 9150
		private float remainingCooldown;

		// Token: 0x040023BF RID: 9151
		private Player player;

		// Token: 0x040023C0 RID: 9152
		private Coroutine punchRoutine;

		// Token: 0x040023C1 RID: 9153
		private bool itemEquippedLastFrame;

		// Token: 0x040023C2 RID: 9154
		private float timeSincePunchingEnabled;
	}
}
