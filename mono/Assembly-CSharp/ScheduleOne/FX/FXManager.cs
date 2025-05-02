using System;
using System.Linq;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.FX
{
	// Token: 0x0200061F RID: 1567
	public class FXManager : Singleton<FXManager>
	{
		// Token: 0x06002911 RID: 10513 RVA: 0x000A97CD File Offset: 0x000A79CD
		protected override void Start()
		{
			base.Start();
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x000A97D8 File Offset: 0x000A79D8
		public void CreateImpactFX(Impact impact)
		{
			AudioClip impactSound = this.GetImpactSound(impact);
			if (impactSound != null)
			{
				this.PlayImpact(impactSound, impact.HitPoint, Mathf.Clamp01(impact.ImpactForce / 400f));
			}
			GameObject impactParticles = this.GetImpactParticles(impact);
			if (impactParticles != null)
			{
				this.PlayParticles(impactParticles, impact.HitPoint, Quaternion.LookRotation(impact.HitPoint));
			}
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000A9840 File Offset: 0x000A7A40
		public void CreateBulletTrail(Vector3 start, Vector3 dir, float speed, float range, LayerMask mask)
		{
			FXManager.<>c__DisplayClass7_0 CS$<>8__locals1 = new FXManager.<>c__DisplayClass7_0();
			CS$<>8__locals1.start = start;
			CS$<>8__locals1.trail = Object.Instantiate<TrailRenderer>(this.BulletTrail, NetworkSingleton<GameManager>.Instance.Temp);
			CS$<>8__locals1.trail.transform.position = CS$<>8__locals1.start;
			CS$<>8__locals1.trail.transform.forward = dir;
			CS$<>8__locals1.maxDistance = range;
			RaycastHit raycastHit;
			if (Physics.Raycast(CS$<>8__locals1.start, dir, ref raycastHit, range, mask))
			{
				CS$<>8__locals1.maxDistance = raycastHit.distance;
			}
			Debug.DrawRay(CS$<>8__locals1.start, dir * CS$<>8__locals1.maxDistance, Color.red, 5f);
			base.StartCoroutine(CS$<>8__locals1.<CreateBulletTrail>g__Routine|0());
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000A98F8 File Offset: 0x000A7AF8
		private void PlayImpact(AudioClip clip, Vector3 position, float volume)
		{
			AudioSourceController source = this.GetSource();
			if (source == null)
			{
				Console.LogWarning("No available audio source controller found", null);
				return;
			}
			source.transform.position = position;
			source.AudioSource.clip = clip;
			source.VolumeMultiplier = volume;
			source.AudioSource.Play();
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x000A994B File Offset: 0x000A7B4B
		private void PlayParticles(GameObject prefab, Vector3 position, Quaternion rotation)
		{
			Object.Destroy(Object.Instantiate<GameObject>(prefab, position, rotation), 2f);
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000A995F File Offset: 0x000A7B5F
		private AudioClip GetImpactSound(Impact impact)
		{
			if (!(impact.Hit.collider.GetComponentInParent<NPC>() != null))
			{
				return null;
			}
			if (impact.ImpactType == EImpactType.SharpMetal)
			{
				return FXManager.GetRandomClip(this.SlashImpactClips);
			}
			return FXManager.GetRandomClip(this.PunchImpactsClips);
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x000A999B File Offset: 0x000A7B9B
		private GameObject GetImpactParticles(Impact impact)
		{
			if (impact.Hit.collider.GetComponentInParent<NPC>() != null)
			{
				return this.PunchParticlePrefab;
			}
			return null;
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x000A99BD File Offset: 0x000A7BBD
		private AudioSourceController GetSource()
		{
			return this.ImpactSources.FirstOrDefault((AudioSourceController x) => !x.isPlaying);
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x000A99E9 File Offset: 0x000A7BE9
		private static AudioClip GetRandomClip(AudioClip[] clips)
		{
			return clips[Random.Range(0, clips.Length)];
		}

		// Token: 0x04001E48 RID: 7752
		public AudioClip[] PunchImpactsClips;

		// Token: 0x04001E49 RID: 7753
		public AudioClip[] SlashImpactClips;

		// Token: 0x04001E4A RID: 7754
		[Header("References")]
		public AudioSourceController[] ImpactSources;

		// Token: 0x04001E4B RID: 7755
		[Header("Particle Prefabs")]
		public GameObject PunchParticlePrefab;

		// Token: 0x04001E4C RID: 7756
		[Header("Trails")]
		public TrailRenderer BulletTrail;
	}
}
