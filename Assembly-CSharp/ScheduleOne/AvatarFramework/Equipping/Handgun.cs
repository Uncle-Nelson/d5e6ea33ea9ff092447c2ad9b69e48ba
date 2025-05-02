using System;
using System.Collections;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000981 RID: 2433
	public class Handgun : AvatarRangedWeapon
	{
		// Token: 0x06004212 RID: 16914 RVA: 0x001151F4 File Offset: 0x001133F4
		public override void Shoot(Vector3 endPoint)
		{
			base.Shoot(endPoint);
			this.Anim.Play();
			this.ShellParticles.Play();
			this.SmokeParticles.Play();
			Player componentInParent = base.GetComponentInParent<Player>();
			if (componentInParent != null && componentInParent.IsOwner)
			{
				return;
			}
			if (this.flashRoutine != null)
			{
				base.StopCoroutine(this.flashRoutine);
			}
			this.flashRoutine = base.StartCoroutine(this.Flash(endPoint));
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x0011526A File Offset: 0x0011346A
		private IEnumerator Flash(Vector3 endPoint)
		{
			float num = 0.06f;
			this.FlashObject.localEulerAngles = new Vector3(0f, 0f, Random.Range(0f, 360f));
			this.FlashObject.gameObject.SetActive(true);
			Transform transform = Object.Instantiate<GameObject>(this.RayPrefab, GameObject.Find("_Temp").transform).transform;
			Object.Destroy(transform.gameObject, num);
			transform.transform.position = (this.MuzzlePoint.position + endPoint) / 2f;
			transform.transform.LookAt(endPoint);
			transform.transform.localScale = new Vector3(1f, 1f, Vector3.Distance(this.MuzzlePoint.position, endPoint));
			yield return new WaitForSeconds(num);
			this.FlashObject.gameObject.SetActive(false);
			yield break;
		}

		// Token: 0x04002FA5 RID: 12197
		[Header("References")]
		public Animation Anim;

		// Token: 0x04002FA6 RID: 12198
		public ParticleSystem ShellParticles;

		// Token: 0x04002FA7 RID: 12199
		public ParticleSystem SmokeParticles;

		// Token: 0x04002FA8 RID: 12200
		public Transform FlashObject;

		// Token: 0x04002FA9 RID: 12201
		[Header("Prefabs")]
		public GameObject RayPrefab;

		// Token: 0x04002FAA RID: 12202
		private Coroutine flashRoutine;
	}
}
