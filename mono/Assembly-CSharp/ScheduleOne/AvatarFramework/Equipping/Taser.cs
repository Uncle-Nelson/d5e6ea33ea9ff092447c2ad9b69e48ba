using System;
using System.Collections;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000983 RID: 2435
	public class Taser : AvatarRangedWeapon
	{
		// Token: 0x0600421B RID: 16923 RVA: 0x001153D2 File Offset: 0x001135D2
		public override void Equip(Avatar _avatar)
		{
			base.Equip(_avatar);
			this.FlashObject.gameObject.SetActive(false);
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x001153EC File Offset: 0x001135EC
		public override void Shoot(Vector3 endPoint)
		{
			base.Shoot(endPoint);
			if (this.flashRoutine != null)
			{
				base.StopCoroutine(this.flashRoutine);
			}
			this.ChargeSound.Stop();
			this.flashRoutine = base.StartCoroutine(this.Flash(endPoint));
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x00115427 File Offset: 0x00113627
		public override void SetIsRaised(bool raised)
		{
			base.SetIsRaised(raised);
			if (base.IsRaised)
			{
				this.ChargeSound.Play();
				return;
			}
			this.ChargeSound.Stop();
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x0011544F File Offset: 0x0011364F
		private IEnumerator Flash(Vector3 endPoint)
		{
			float t = 0.2f;
			this.FlashObject.gameObject.SetActive(true);
			Transform transform = Object.Instantiate<GameObject>(this.RayPrefab, GameObject.Find("_Temp").transform).transform;
			Object.Destroy(transform.gameObject, t);
			transform.transform.position = (this.MuzzlePoint.position + endPoint) / 2f;
			transform.transform.LookAt(endPoint);
			transform.transform.localScale = new Vector3(1f, 1f, Vector3.Distance(this.MuzzlePoint.position, endPoint));
			yield return new WaitForSeconds(0.2f);
			this.FlashObject.gameObject.SetActive(false);
			yield break;
		}

		// Token: 0x04002FAF RID: 12207
		public const float TaseDuration = 2f;

		// Token: 0x04002FB0 RID: 12208
		public const float TaseMoveSpeedMultiplier = 0.5f;

		// Token: 0x04002FB1 RID: 12209
		[Header("References")]
		public GameObject FlashObject;

		// Token: 0x04002FB2 RID: 12210
		public AudioSourceController ChargeSound;

		// Token: 0x04002FB3 RID: 12211
		[Header("Prefabs")]
		public GameObject RayPrefab;

		// Token: 0x04002FB4 RID: 12212
		private Coroutine flashRoutine;
	}
}
