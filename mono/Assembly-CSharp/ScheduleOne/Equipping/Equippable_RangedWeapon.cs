using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.ItemFramework;
using ScheduleOne.Noise;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Storage;
using ScheduleOne.Trash;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000925 RID: 2341
	public class Equippable_RangedWeapon : Equippable_AvatarViewmodel
	{
		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06003F4B RID: 16203 RVA: 0x0010B1F1 File Offset: 0x001093F1
		// (set) Token: 0x06003F4C RID: 16204 RVA: 0x0010B1F9 File Offset: 0x001093F9
		public float Aim { get; private set; }

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06003F4D RID: 16205 RVA: 0x0010B202 File Offset: 0x00109402
		// (set) Token: 0x06003F4E RID: 16206 RVA: 0x0010B20A File Offset: 0x0010940A
		public float Accuracy { get; private set; }

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06003F4F RID: 16207 RVA: 0x0010B213 File Offset: 0x00109413
		// (set) Token: 0x06003F50 RID: 16208 RVA: 0x0010B21B File Offset: 0x0010941B
		public float TimeSinceFire { get; set; } = 1000f;

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06003F51 RID: 16209 RVA: 0x0010B224 File Offset: 0x00109424
		// (set) Token: 0x06003F52 RID: 16210 RVA: 0x0010B22C File Offset: 0x0010942C
		public bool IsReloading { get; private set; }

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06003F53 RID: 16211 RVA: 0x0010B235 File Offset: 0x00109435
		// (set) Token: 0x06003F54 RID: 16212 RVA: 0x0010B23D File Offset: 0x0010943D
		public bool IsCocked { get; private set; }

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06003F55 RID: 16213 RVA: 0x0010B246 File Offset: 0x00109446
		// (set) Token: 0x06003F56 RID: 16214 RVA: 0x0010B24E File Offset: 0x0010944E
		public bool IsCocking { get; private set; }

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06003F57 RID: 16215 RVA: 0x0010B257 File Offset: 0x00109457
		public int Ammo
		{
			get
			{
				if (this.weaponItem == null)
				{
					return 0;
				}
				return this.weaponItem.Value;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06003F58 RID: 16216 RVA: 0x0010B26E File Offset: 0x0010946E
		private float aimFov
		{
			get
			{
				return Singleton<Settings>.Instance.CameraFOV - this.AimFOVReduction;
			}
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x0010B284 File Offset: 0x00109484
		public override void Equip(ItemInstance item)
		{
			base.Equip(item);
			Singleton<HUD>.Instance.SetCrosshairVisible(false);
			Singleton<InputPromptsCanvas>.Instance.LoadModule("gun");
			this.weaponItem = (item as IntegerItemInstance);
			base.InvokeRepeating("CheckAimingAtNPC", 0f, 0.5f);
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x0010B2D4 File Offset: 0x001094D4
		public override void Unequip()
		{
			base.Unequip();
			Singleton<HUD>.Instance.SetCrosshairVisible(true);
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			if (this.fovOverridden)
			{
				PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(this.FOVChangeDuration);
				PlayerSingleton<PlayerMovement>.Instance.RemoveSprintBlocker("Aiming");
				this.fovOverridden = false;
			}
			if (this.reloadRoutine != null)
			{
				base.StopCoroutine(this.reloadRoutine);
			}
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x0010B33E File Offset: 0x0010953E
		protected override void Update()
		{
			base.Update();
			this.UpdateInput();
			this.UpdateAnim();
			Singleton<HUD>.Instance.SetCrosshairVisible(false);
			this.TimeSinceFire += Time.deltaTime;
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x0010B370 File Offset: 0x00109570
		private void UpdateInput()
		{
			if (Time.timeScale == 0f)
			{
				return;
			}
			if ((GameInput.GetButton(GameInput.ButtonCode.SecondaryClick) || this.timeSincePrimaryClick < 0.5f || this.IsCocking) && this.CanAim())
			{
				this.Aim = Mathf.SmoothDamp(this.Aim, 1f, ref this.aimVelocity, this.AimDuration);
				this.Accuracy = Mathf.MoveTowards(this.Accuracy, 1f, Time.deltaTime / this.AccuracyChangeDuration);
				if (!this.fovOverridden)
				{
					PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(this.aimFov, this.FOVChangeDuration);
					PlayerSingleton<PlayerMovement>.Instance.AddSprintBlocker("Aiming");
					this.fovOverridden = true;
					Player.Local.SendEquippableMessage_Networked("Raise", Random.Range(int.MinValue, int.MaxValue));
				}
			}
			else
			{
				if (this.TimeSinceFire > this.FireCooldown)
				{
					this.Aim = Mathf.SmoothDamp(this.Aim, 0f, ref this.aimVelocity, this.AimDuration);
				}
				this.Accuracy = Mathf.MoveTowards(this.Accuracy, 0f, Time.deltaTime / this.AccuracyChangeDuration * 2f);
				if (this.fovOverridden)
				{
					PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(this.FOVChangeDuration);
					PlayerSingleton<PlayerMovement>.Instance.RemoveSprintBlocker("Aiming");
					this.fovOverridden = false;
					Player.Local.SendEquippableMessage_Networked("Lower", Random.Range(int.MinValue, int.MaxValue));
				}
			}
			float t = Mathf.Clamp01(PlayerSingleton<PlayerMovement>.Instance.Controller.velocity.magnitude / PlayerMovement.WalkSpeed);
			float num = Mathf.Lerp(1f, 0f, t);
			if (this.Accuracy > num)
			{
				this.Accuracy = Mathf.MoveTowards(this.Accuracy, num, Time.deltaTime / this.AccuracyChangeDuration * 2f);
			}
			if (Singleton<PauseMenu>.Instance.IsPaused)
			{
				return;
			}
			if (GameInput.GetButton(GameInput.ButtonCode.PrimaryClick))
			{
				this.timeSincePrimaryClick = 0f;
			}
			else
			{
				this.timeSincePrimaryClick += Time.deltaTime;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick) || this.shotQueued)
			{
				if (this.CanFire(false))
				{
					if (this.Ammo > 0)
					{
						if (!this.MustBeCocked || this.IsCocked)
						{
							this.Fire();
						}
						else
						{
							this.Cock();
						}
					}
					else if (this.EmptySound != null)
					{
						this.EmptySound.Play();
						this.shotQueued = false;
						if (this.IsReloadReady(false))
						{
							this.Reload();
						}
					}
				}
				else if (this.TimeSinceFire < this.FireCooldown || this.IsCocking)
				{
					this.shotQueued = true;
				}
			}
			if (this.reloadQueued || GameInput.GetButtonDown(GameInput.ButtonCode.Reload))
			{
				if (this.IsReloadReady(false))
				{
					this.Reload();
					return;
				}
				if (GameInput.GetButtonDown(GameInput.ButtonCode.Reload) && this.IsReloadReady(true) && this.TimeSinceFire > this.FireCooldown * 0.5f)
				{
					Console.Log("Reload qeueued", null);
					this.reloadQueued = true;
				}
			}
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x0010B678 File Offset: 0x00109878
		private void UpdateAnim()
		{
			Singleton<ViewmodelAvatar>.Instance.Animator.SetFloat("Aim", this.Aim);
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x000022C9 File Offset: 0x000004C9
		private bool CanAim()
		{
			return true;
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x0010B694 File Offset: 0x00109894
		public virtual void Fire()
		{
			this.IsCocked = false;
			this.shotQueued = false;
			this.TimeSinceFire = 0f;
			Vector3 data = PlayerSingleton<PlayerCamera>.Instance.transform.position + PlayerSingleton<PlayerCamera>.Instance.transform.forward * 50f;
			Player.Local.SendEquippableMessage_Networked_Vector("Shoot", Random.Range(int.MinValue, int.MaxValue), data);
			Singleton<ViewmodelAvatar>.Instance.Animator.SetTrigger(this.FireAnimTriggers[Random.Range(0, this.FireAnimTriggers.Length)]);
			PlayerSingleton<PlayerCamera>.Instance.JoltCamera();
			this.FireSound.Play();
			this.weaponItem.ChangeValue(-1);
			float spread = this.GetSpread();
			Vector3 vector = PlayerSingleton<PlayerCamera>.Instance.transform.forward;
			vector = Quaternion.Euler(Random.insideUnitCircle * spread) * vector;
			Vector3 vector2 = PlayerSingleton<PlayerCamera>.Instance.transform.position;
			vector2 += PlayerSingleton<PlayerCamera>.Instance.transform.forward * 0.4f;
			vector2 += PlayerSingleton<PlayerCamera>.Instance.transform.right * 0.1f;
			vector2 += PlayerSingleton<PlayerCamera>.Instance.transform.up * -0.03f;
			Singleton<FXManager>.Instance.CreateBulletTrail(vector2, vector, this.TracerSpeed, this.Range, NetworkSingleton<CombatManager>.Instance.RangedWeaponLayerMask);
			NoiseUtility.EmitNoise(base.transform.position, ENoiseType.Gunshot, 25f, Player.Local.gameObject);
			if (Player.Local.CurrentProperty == null)
			{
				Player.Local.VisualState.ApplyState("shooting", PlayerVisualState.EVisualState.DischargingWeapon, 4f);
			}
			RaycastHit[] array = Physics.SphereCastAll(vector2, this.RayRadius, vector, this.Range, NetworkSingleton<CombatManager>.Instance.RangedWeaponLayerMask);
			Array.Sort<RaycastHit>(array, (RaycastHit a, RaycastHit b) => a.distance.CompareTo(b.distance));
			RaycastHit[] array2 = array;
			int i = 0;
			while (i < array2.Length)
			{
				RaycastHit hit = array2[i];
				IDamageable componentInParent = hit.collider.GetComponentInParent<IDamageable>();
				if (componentInParent == null || componentInParent != Player.Local)
				{
					if (componentInParent != null)
					{
						Impact impact = new Impact(hit, hit.point, PlayerSingleton<PlayerCamera>.Instance.transform.forward, this.ImpactForce, this.Damage, EImpactType.Bullet, Player.Local, Random.Range(int.MinValue, int.MaxValue));
						componentInParent.SendImpact(impact);
						Singleton<FXManager>.Instance.CreateImpactFX(impact);
						break;
					}
					break;
				}
				else
				{
					i++;
				}
			}
			this.Accuracy = 0f;
			if (this.onFire != null)
			{
				this.onFire.Invoke();
			}
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x0010B95F File Offset: 0x00109B5F
		public virtual void Reload()
		{
			this.reloadQueued = false;
			this.IsReloading = true;
			Console.Log("Reloading...", null);
			this.reloadRoutine = base.StartCoroutine(this.<Reload>g__ReloadRoutine|77_0());
		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void NotifyIncrementalReload()
		{
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x0010B98C File Offset: 0x00109B8C
		private bool IsReloadReady(bool ignoreTiming)
		{
			StorableItemInstance storableItemInstance;
			return this.CanReload && !this.IsReloading && this.GetMagazine(out storableItemInstance) && this.weaponItem.Value < this.MagazineSize && (this.TimeSinceFire >= this.FireCooldown || ignoreTiming) && (base.equipAnimDone || ignoreTiming) && !this.IsCocking;
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x0010B9FC File Offset: 0x00109BFC
		protected virtual bool GetMagazine(out StorableItemInstance mag)
		{
			mag = null;
			for (int i = 0; i < PlayerSingleton<PlayerInventory>.Instance.hotbarSlots.Count; i++)
			{
				if (PlayerSingleton<PlayerInventory>.Instance.hotbarSlots[i].Quantity != 0 && PlayerSingleton<PlayerInventory>.Instance.hotbarSlots[i].ItemInstance.ID == this.Magazine.ID)
				{
					mag = (PlayerSingleton<PlayerInventory>.Instance.hotbarSlots[i].ItemInstance as StorableItemInstance);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x0010BA88 File Offset: 0x00109C88
		private bool CanFire(bool checkAmmo = true)
		{
			return this.TimeSinceFire >= this.FireCooldown && this.Aim >= 0.1f && base.equipAnimDone && (!checkAmmo || this.Ammo > 0) && !this.IsReloading && !this.IsCocking;
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x0010BAE4 File Offset: 0x00109CE4
		private bool CanCock()
		{
			return !this.IsCocked && !this.IsCocking && this.weaponItem.Value > 0 && base.equipAnimDone && !this.IsReloading && this.TimeSinceFire >= this.FireCooldown;
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x0010BB3A File Offset: 0x00109D3A
		private void Cock()
		{
			Console.Log("Cocking", null);
			this.shotQueued = false;
			this.IsCocking = true;
			base.StartCoroutine(this.<Cock>g__CockRoutine|83_0());
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x0010BB62 File Offset: 0x00109D62
		private float GetSpread()
		{
			return Mathf.Lerp(this.MaxSpread, this.MinSpread, this.Accuracy);
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x0010BB7C File Offset: 0x00109D7C
		private void CheckAimingAtNPC()
		{
			if (this.Aim < 0.5f)
			{
				return;
			}
			RaycastHit[] array = Physics.SphereCastAll(new Ray(PlayerSingleton<PlayerCamera>.Instance.transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.forward), 0.5f, 10f, NetworkSingleton<CombatManager>.Instance.RangedWeaponLayerMask);
			List<NPC> list = new List<NPC>();
			foreach (RaycastHit raycastHit in array)
			{
				NPC componentInParent = raycastHit.collider.GetComponentInParent<NPC>();
				if (componentInParent != null && !list.Contains(componentInParent))
				{
					list.Add(componentInParent);
					if (componentInParent.awareness.VisionCone.IsPlayerVisible(Player.Local))
					{
						componentInParent.responses.RespondToAimedAt(Player.Local);
					}
				}
			}
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x0010BD45 File Offset: 0x00109F45
		[CompilerGenerated]
		private IEnumerator <Reload>g__ReloadRoutine|77_0()
		{
			if (this.onReloadStart != null)
			{
				this.onReloadStart.Invoke();
			}
			Singleton<ViewmodelAvatar>.Instance.Animator.SetTrigger(this.ReloadStartAnimTrigger);
			yield return new WaitForSeconds(this.ReloadStartTime);
			StorableItemInstance storableItemInstance;
			if (this.IncrementalReload)
			{
				StorableItemInstance mag;
				while (this.weaponItem.Value < this.MagazineSize && this.GetMagazine(out mag))
				{
					if (this.onReloadIndividual != null)
					{
						this.onReloadIndividual.Invoke();
					}
					Singleton<ViewmodelAvatar>.Instance.Animator.SetTrigger(this.ReloadIndividualAnimTrigger);
					yield return new WaitForSeconds(this.ReloadIndividalTime);
					this.weaponItem.ChangeValue(1);
					IntegerItemInstance integerItemInstance = mag as IntegerItemInstance;
					integerItemInstance.ChangeValue(-1);
					this.NotifyIncrementalReload();
					if (integerItemInstance.Value <= 0)
					{
						mag.ChangeQuantity(-1);
						if (this.ReloadTrash != null)
						{
							Vector3 posiiton = PlayerSingleton<PlayerCamera>.Instance.transform.position - PlayerSingleton<PlayerCamera>.Instance.transform.up * 0.4f;
							NetworkSingleton<TrashManager>.Instance.CreateTrashItem(this.ReloadTrash.ID, posiiton, Random.rotation, default(Vector3), "", false);
						}
					}
				}
				yield return new WaitForSeconds(0.05f);
				if (this.onReloadEnd != null)
				{
					this.onReloadEnd.Invoke();
				}
				Singleton<ViewmodelAvatar>.Instance.Animator.SetTrigger(this.ReloadEndAnimTrigger);
				yield return new WaitForSeconds(this.ReloadEndTime);
			}
			else if (this.GetMagazine(out storableItemInstance))
			{
				IntegerItemInstance integerItemInstance2 = storableItemInstance as IntegerItemInstance;
				integerItemInstance2.ChangeValue(-(this.MagazineSize - this.weaponItem.Value));
				if (integerItemInstance2.Value <= 0)
				{
					storableItemInstance.ChangeQuantity(-1);
					if (this.ReloadTrash != null)
					{
						Vector3 posiiton2 = PlayerSingleton<PlayerCamera>.Instance.transform.position - PlayerSingleton<PlayerCamera>.Instance.transform.up * 0.4f;
						NetworkSingleton<TrashManager>.Instance.CreateTrashItem(this.ReloadTrash.ID, posiiton2, Random.rotation, default(Vector3), "", false);
					}
				}
				this.weaponItem.SetValue(this.MagazineSize);
			}
			Console.Log("Reloading done!", null);
			this.IsReloading = false;
			this.reloadRoutine = null;
			yield break;
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x0010BD54 File Offset: 0x00109F54
		[CompilerGenerated]
		private IEnumerator <Cock>g__CockRoutine|83_0()
		{
			if (this.onCockStart != null)
			{
				this.onCockStart.Invoke();
			}
			Singleton<ViewmodelAvatar>.Instance.Animator.SetTrigger(this.CockAnimTrigger);
			yield return new WaitForSeconds(this.CockTime);
			this.IsCocked = true;
			this.IsCocking = false;
			yield break;
		}

		// Token: 0x04002D77 RID: 11639
		public const float NPC_AIM_DETECTION_RANGE = 10f;

		// Token: 0x04002D7E RID: 11646
		public int MagazineSize = 7;

		// Token: 0x04002D7F RID: 11647
		[Header("Aim Settings")]
		public float AimDuration = 0.2f;

		// Token: 0x04002D80 RID: 11648
		public float AimFOVReduction = 10f;

		// Token: 0x04002D81 RID: 11649
		public float FOVChangeDuration = 0.3f;

		// Token: 0x04002D82 RID: 11650
		[Header("Firing")]
		public AudioSourceController FireSound;

		// Token: 0x04002D83 RID: 11651
		public AudioSourceController EmptySound;

		// Token: 0x04002D84 RID: 11652
		public float FireCooldown = 0.3f;

		// Token: 0x04002D85 RID: 11653
		public string[] FireAnimTriggers;

		// Token: 0x04002D86 RID: 11654
		public float AccuracyChangeDuration = 0.6f;

		// Token: 0x04002D87 RID: 11655
		[Header("Raycasting")]
		public float Range = 40f;

		// Token: 0x04002D88 RID: 11656
		public float RayRadius = 0.05f;

		// Token: 0x04002D89 RID: 11657
		[Header("Spread")]
		public float MinSpread = 5f;

		// Token: 0x04002D8A RID: 11658
		public float MaxSpread = 15f;

		// Token: 0x04002D8B RID: 11659
		[Header("Damage")]
		public float Damage = 60f;

		// Token: 0x04002D8C RID: 11660
		public float ImpactForce = 300f;

		// Token: 0x04002D8D RID: 11661
		[Header("Reloading")]
		public bool CanReload = true;

		// Token: 0x04002D8E RID: 11662
		public bool IncrementalReload;

		// Token: 0x04002D8F RID: 11663
		public StorableItemDefinition Magazine;

		// Token: 0x04002D90 RID: 11664
		public float ReloadStartTime = 1.5f;

		// Token: 0x04002D91 RID: 11665
		public float ReloadIndividalTime;

		// Token: 0x04002D92 RID: 11666
		public float ReloadEndTime;

		// Token: 0x04002D93 RID: 11667
		public string ReloadStartAnimTrigger = "MagazineReload";

		// Token: 0x04002D94 RID: 11668
		public string ReloadIndividualAnimTrigger = string.Empty;

		// Token: 0x04002D95 RID: 11669
		public string ReloadEndAnimTrigger = string.Empty;

		// Token: 0x04002D96 RID: 11670
		public TrashItem ReloadTrash;

		// Token: 0x04002D97 RID: 11671
		[Header("Cocking")]
		public bool MustBeCocked;

		// Token: 0x04002D98 RID: 11672
		public float CockTime = 0.5f;

		// Token: 0x04002D99 RID: 11673
		public string CockAnimTrigger = "MagazineReload";

		// Token: 0x04002D9A RID: 11674
		[Header("Effects")]
		public float TracerSpeed = 50f;

		// Token: 0x04002D9B RID: 11675
		public UnityEvent onFire;

		// Token: 0x04002D9C RID: 11676
		public UnityEvent onReloadStart;

		// Token: 0x04002D9D RID: 11677
		public UnityEvent onReloadIndividual;

		// Token: 0x04002D9E RID: 11678
		public UnityEvent onReloadEnd;

		// Token: 0x04002D9F RID: 11679
		public UnityEvent onCockStart;

		// Token: 0x04002DA0 RID: 11680
		protected IntegerItemInstance weaponItem;

		// Token: 0x04002DA1 RID: 11681
		private bool fovOverridden;

		// Token: 0x04002DA2 RID: 11682
		private float aimVelocity;

		// Token: 0x04002DA3 RID: 11683
		private Coroutine reloadRoutine;

		// Token: 0x04002DA4 RID: 11684
		private bool shotQueued;

		// Token: 0x04002DA5 RID: 11685
		private bool reloadQueued;

		// Token: 0x04002DA6 RID: 11686
		private float timeSincePrimaryClick = 100f;
	}
}
