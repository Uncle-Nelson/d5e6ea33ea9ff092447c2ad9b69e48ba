using System;
using System.Collections;
using ScheduleOne.Audio;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x0200097E RID: 2430
	public class AvatarRangedWeapon : AvatarWeapon
	{
		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060041FA RID: 16890 RVA: 0x00114D2C File Offset: 0x00112F2C
		// (set) Token: 0x060041FB RID: 16891 RVA: 0x00114D34 File Offset: 0x00112F34
		public bool IsRaised { get; protected set; }

		// Token: 0x060041FC RID: 16892 RVA: 0x00114D3D File Offset: 0x00112F3D
		public override void Equip(Avatar _avatar)
		{
			base.Equip(_avatar);
			if (this.MagazineSize != -1)
			{
				this.currentAmmo = this.MagazineSize;
			}
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x00114D5C File Offset: 0x00112F5C
		public virtual void SetIsRaised(bool raised)
		{
			if (this.IsRaised == raised)
			{
				return;
			}
			this.IsRaised = raised;
			this.timeRaised = 0f;
			if (this.IsRaised)
			{
				base.ResetTrigger(this.LoweredAnimationTrigger);
				base.SetTrigger(this.RaisedAnimationTrigger);
				return;
			}
			base.ResetTrigger(this.RaisedAnimationTrigger);
			base.SetTrigger(this.LoweredAnimationTrigger);
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x00114DBE File Offset: 0x00112FBE
		private void Update()
		{
			this.timeEquipped += Time.deltaTime;
			this.timeSinceLastShot += Time.deltaTime;
			if (this.IsRaised)
			{
				this.timeRaised += Time.deltaTime;
			}
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x00114E00 File Offset: 0x00113000
		public override void ReceiveMessage(string message, object data)
		{
			base.ReceiveMessage(message, data);
			if (message == "Shoot")
			{
				this.Shoot((Vector3)data);
			}
			if (message == "Lower")
			{
				this.SetIsRaised(false);
			}
			if (message == "Raise")
			{
				this.SetIsRaised(true);
			}
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x00114E58 File Offset: 0x00113058
		public bool CanShoot()
		{
			return (this.currentAmmo > 0 || this.MagazineSize == -1) && this.timeEquipped > this.EquipTime && !this.isReloading && this.timeSinceLastShot > this.MaxFireRate && this.timeRaised > this.RaiseTime;
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x00114EAC File Offset: 0x001130AC
		public virtual void Shoot(Vector3 endPoint)
		{
			this.timeSinceLastShot = 0f;
			if (this.RecoilAnimationTrigger != string.Empty)
			{
				base.ResetTrigger(this.RecoilAnimationTrigger);
				base.SetTrigger(this.RecoilAnimationTrigger);
			}
			Player componentInParent = base.GetComponentInParent<Player>();
			if (componentInParent != null && componentInParent.IsOwner)
			{
				return;
			}
			this.currentAmmo--;
			this.FireSound.PlayOneShot(true);
			if (this.currentAmmo <= 0 && this.MagazineSize != -1)
			{
				base.StartCoroutine(this.Reload());
			}
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x00114F40 File Offset: 0x00113140
		private IEnumerator Reload()
		{
			this.isReloading = true;
			yield return new WaitForSeconds(this.ReloadTime);
			this.currentAmmo = this.MagazineSize;
			this.isReloading = false;
			yield break;
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x00114F50 File Offset: 0x00113150
		public bool IsPlayerInLoS(Player target)
		{
			LayerMask mask = LayerMask.GetMask(AvatarRangedWeapon.RaycastLayers);
			RaycastHit raycastHit;
			return !Physics.Raycast(this.MuzzlePoint.position, (target.Avatar.CenterPoint - this.MuzzlePoint.position).normalized, ref raycastHit, Vector3.Distance(this.MuzzlePoint.position, target.Avatar.CenterPoint), mask) || !raycastHit.collider.GetComponentInParent<Player>() || raycastHit.collider.GetComponentInParent<Player>() == target || (raycastHit.collider.GetComponentInParent<LandVehicle>() != null && raycastHit.collider.GetComponentInParent<LandVehicle>().DriverPlayer == target);
		}

		// Token: 0x04002F86 RID: 12166
		public static string[] RaycastLayers = new string[]
		{
			"Default",
			"Vehicle",
			"Door",
			"Terrain",
			"Player"
		};

		// Token: 0x04002F87 RID: 12167
		[Header("Weapon Settings")]
		public int MagazineSize = -1;

		// Token: 0x04002F88 RID: 12168
		public float ReloadTime = 2f;

		// Token: 0x04002F89 RID: 12169
		public float MaxFireRate = 0.5f;

		// Token: 0x04002F8A RID: 12170
		public bool CanShootWhileMoving;

		// Token: 0x04002F8B RID: 12171
		public float EquipTime = 1f;

		// Token: 0x04002F8C RID: 12172
		public float RaiseTime = 1f;

		// Token: 0x04002F8D RID: 12173
		public float Damage = 35f;

		// Token: 0x04002F8E RID: 12174
		[Header("Accuracy")]
		public float HitChange_MinRange = 0.6f;

		// Token: 0x04002F8F RID: 12175
		public float HitChange_MaxRange = 0.1f;

		// Token: 0x04002F90 RID: 12176
		[Header("References")]
		public Transform MuzzlePoint;

		// Token: 0x04002F91 RID: 12177
		public AudioSourceController FireSound;

		// Token: 0x04002F92 RID: 12178
		[Header("Settings")]
		public string LoweredAnimationTrigger;

		// Token: 0x04002F93 RID: 12179
		public string RaisedAnimationTrigger;

		// Token: 0x04002F94 RID: 12180
		public string RecoilAnimationTrigger;

		// Token: 0x04002F96 RID: 12182
		private bool isReloading;

		// Token: 0x04002F97 RID: 12183
		private float timeEquipped;

		// Token: 0x04002F98 RID: 12184
		private float timeRaised;

		// Token: 0x04002F99 RID: 12185
		private float timeSinceLastShot = 1000f;

		// Token: 0x04002F9A RID: 12186
		private int currentAmmo;
	}
}
